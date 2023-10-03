
using Unity;
using Task = Models.Model.Task;
using Controllers;
using Models.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelProduct
{
    public partial class FormPas : Form

    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public string fio { get; set; }
        public int idUser { get; set; }
        private int id;
        private readonly TaskController task;
        public FormPas(TaskController task)
        {
            InitializeComponent();
            this.task = task;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Добрый день, " + fio + "", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
        }
        private void LoadData()
        {
            try
            {
                List<Task> Task = task.GetList(idUser);
                if (Task != null)
                {
                    dataGridView1.DataSource = Task;
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].HeaderText = "Дата";
                    dataGridView1.Columns[2].HeaderText = "Сотрудник";
                    dataGridView1.Columns[3].HeaderText = "Задача ";
                    dataGridView1.Columns[4].HeaderText = "Выполнение";
                    dataGridView1.Columns[5].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfirmTask_Click()
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                
                    id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        task.ConfElement(id);
                        MessageBox.Show("Услуга успешно удалена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }


        }

    }
}
