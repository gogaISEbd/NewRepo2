using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;
using Microsoft.VisualBasic.ApplicationServices;
using Models.Model;
using Unity;

namespace HostelProduct
{
    public partial class FormEntry : Form
    {
        public new IUnityContainer Container { get; set; }
        private readonly StaffController mainService;
        private readonly EncryptiontController encryptionService;
        public FormEntry(StaffController mainService)
        {
            InitializeComponent();
            this.mainService = mainService;
        }
        private void buttonEntry_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text))
            {
                MessageBox.Show("Заполните логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Заполните пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {

                Staff view = mainService.GetElement(textBoxLogin.Text, textBoxPassword.Text);

                if (view.Role == "Бухгалтер")
                {
                    var form = Program.Container.Resolve<FormBuh>();
                    form.idUser = view.Id;
                    form.fio = view.Fio;
                    form.ShowDialog();
                }
                if (view.Role == "Консьерж")
                {
                    var form = Program.Container.Resolve<FormPas>();
                    form.idUser = view.Id;
                    form.fio = view.Fio;
                    form.ShowDialog();
                }
                if (view.Role == "Руководитель")
                {
                    MessageBox.Show("АРМ Руководителя в данный момент недоступна", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            textBoxLogin.Clear();
            textBoxPassword.Clear();
            return;
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '●';
        }
    }
}
