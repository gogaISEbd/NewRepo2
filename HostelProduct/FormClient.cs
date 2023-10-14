using Controllers;
using HostelProduct;
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
    public partial class FormClient : Form
    {
        public new IUnityContainer Container { get; set; }

        private int id;
        private readonly ClientController client;
        public FormClient(ClientController client)
        {
            InitializeComponent();
            this.client = client;
        }
        private void FormClients_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                List<Client> list = client.GetList();
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].HeaderText = "Фио";
                    dataGridView1.Columns[2].HeaderText = "Возраст";
                    dataGridView1.Columns[3].HeaderText = "Пасспорт";
                    dataGridView1.Columns[4].HeaderText = "Номер телефона";
                    dataGridView1.Columns[5].Visible = false;
                    dataGridView1.Columns[6].Visible = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Заполните ФИО", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Заполните возраст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Заполните пасспорт", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                client.AddElement(new Client
                {
                    Fio = textBox1.Text,
                    Age = Convert.ToInt32(textBox2.Text),
                    Passport = textBox3.Text,
                    Phone = textBox4.Text
                });
                MessageBox.Show("Клиент успешно добавлена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Введите корректные значения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Заполните ФИО", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Заполните возраст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Заполните пасспорт", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                client.UpdElement(new Client
                {
                    Fio = textBox1.Text,
                    Age = Convert.ToInt32(textBox2.Text),
                    Passport = textBox3.Text,
                    Phone = textBox4.Text
                });
                MessageBox.Show("Клиент успешно добавлена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Введите корректные значения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        client.DelElement(id);
                        MessageBox.Show("Клиент успешно удален!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    Client view = client.GetElement(id);
                    textBox1.Text = view.Fio;
                    textBox2.Text = Convert.ToString(view.Age);
                    textBox3.Text = view.Passport;
                    textBox4.Text = view.Phone;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

