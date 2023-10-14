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
    public partial class FormRoom : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private int id;
        private readonly RoomsController rooms;

        public FormRoom(RoomsController rooms)
        {
            InitializeComponent();
            this.rooms = rooms;
        }

        private void FormRoom_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<Room> list = rooms.GetList();
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].HeaderText = "Название комнаты";
                    dataGridView1.Columns[2].HeaderText = "Стоимость ";
                    dataGridView1.Columns[3].HeaderText = "Площадь";
                    dataGridView1.Columns[4].HeaderText = "Расположение";
                    dataGridView1.Columns[5].HeaderText = "Колличество комнат";
                    dataGridView1.Columns[6].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNameRoom.Text))
            {
                MessageBox.Show("Заполните название комнаты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxCost.Text))
            {
                MessageBox.Show("Напишите стоимость", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxLocation.Text))
            {
                MessageBox.Show("Напишите Адресс", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxRooms.Text))
            {
                MessageBox.Show("Напишите стоимость", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxSize.Text))
            {
                MessageBox.Show("Напишите площадь", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                rooms.AddElement(new Room
                {
                    Name = textBoxNameRoom.Text,
                    Price = Convert.ToDecimal(textBoxCost.Text),
                    Location = textBoxLocation.Text,
                    Rooms = Convert.ToInt32(textBoxRooms.Text),
                    Size = Convert.ToDecimal(textBoxSize.Text)
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
            if (string.IsNullOrEmpty(textBoxNameRoom.Text))
            {
                MessageBox.Show("Заполните название комнаты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxCost.Text))
            {
                MessageBox.Show("Напишите стоимость", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxLocation.Text))
            {
                MessageBox.Show("Напишите Адресс", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxRooms.Text))
            {
                MessageBox.Show("Напишите стоимость", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxSize.Text))
            {
                MessageBox.Show("Напишите площадь", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                rooms.UpdElement(new Room
                {
                    Id = id,
                    Name = textBoxNameRoom.Text,
                    Price = Convert.ToDecimal(textBoxCost.Text),
                    Location = textBoxLocation.Text,
                    Rooms = Convert.ToInt32(textBoxRooms.Text),
                    Size = Convert.ToDecimal(textBoxSize.Text)
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
                        rooms.DelElement(id);
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
                    Room view = rooms.GetElement(id);
                    textBoxCost.Text = Convert.ToString(view.Price);
                    textBoxNameRoom.Text = view.Name;
                    textBoxLocation.Text = view.Location;
                    textBoxRooms.Text = Convert.ToString(view.Rooms);
                    textBoxSize.Text = Convert.ToString(view.Size); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
