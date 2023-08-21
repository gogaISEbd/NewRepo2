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

namespace HostelProduct
{
    public partial class FormPay : Form
    {

        public new IUnityContainer Container { get; set; }

        private int id;
        private readonly PayController service;

        public FormPay(PayController service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void FormPay_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<MainOperation> list = service.GetList();
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns[1].HeaderText = "Дата";
                    dataGridView1.Columns[2].HeaderText = "Дата Заезда";
                    dataGridView1.Columns[3].HeaderText = "Дата Выезда";
                    dataGridView1.Columns[4].HeaderText = "Цена";
                    dataGridView1.Columns[5].HeaderText = "Клиент";
                    dataGridView1.Columns[6].HeaderText = "Номер";
                    dataGridView1.Columns[7].HeaderText = "Состояние";
                    dataGridView1.Columns[8].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonPay_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxDate.Text))
            {
                MessageBox.Show("Заполните дату!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxCost.Text))
            {
                MessageBox.Show("Цену!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            try
            {
                service.UpdPay(new MainOperation
                {
                    Id = id,
                    Cost=Convert.ToInt32(textBoxCost.Text)
                });
                MessageBox.Show("Услуга успешно олачена", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Введите корректные значения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }



    }
}
