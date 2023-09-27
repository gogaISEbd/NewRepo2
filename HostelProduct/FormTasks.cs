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
using Unity;
using Task = Models.Model.Task;

namespace HostelProduct
{
    public partial class FormTasks : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private int id;
        private readonly TaskController task;

        public FormTasks(TaskController task)
        {
            InitializeComponent();
            this.task = task;
        }

        private void FormRoom_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<Task> Task = task.GetListAll();
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


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTask.Text))
            {
                MessageBox.Show("Заполните название комнаты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(comboBoxStaff.Text))
            {
                MessageBox.Show("Напишите стоимость", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                task.AddElement(new Task
                {
                    Task1 = textBoxTask.Text,
                    Date = dateTimePicker.Value,
                    IsDone = false,
                    StaffId = 2
                });
                MessageBox.Show("Услуга успешно добавлена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Введите корректные значения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTask.Text))
            {
                MessageBox.Show("Заполните название комнаты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(comboBoxStaff.Text))
            {
                MessageBox.Show("Напишите стоимость", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                task.UpdElement(new Task
                {
                    Id = id,
                    Task1 = textBoxTask.Text,
                    Date = Convert.ToDateTime("01022002"),
                    IsDone = false,
                    StaffId = 2
                });
                MessageBox.Show("Услуга успешно отредактирована!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Введите корректные значения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        task.DelElement(id);
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            if (dataGridView1.SelectedRows.Count == 1)
            {
                try
                {
                    Task view = task.GetElement(id);
                    textBoxTask.Text = view.Task1;
                    comboBoxStaff.Text = Convert.ToString(view.StaffId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
