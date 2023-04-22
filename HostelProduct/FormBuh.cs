
using Unity;

namespace HostelProduct
{
    public partial class FormBuh : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public string fio { get; set; }
        public int idUser { get; set; }
        public FormBuh()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Добрый день, " + fio + "", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new FormInfo();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
            Show();
        }
        private void buttonTasks_Click(object sender, EventArgs e)
        {
            Hide();
            var form = Program.Container.Resolve<FormTasks>();
            form.ShowDialog();
            Show();
        }
        private void buttonStaff_Click(object sender, EventArgs e)
        {
            Hide();
            var form = Program.Container.Resolve<FormStaff>();
            form.ShowDialog();
            Show();
        }
        private void buttonRoom_Click(object sender, EventArgs e)
        {
            Hide();
            var form = Program.Container.Resolve<FormRoom>();
            form.ShowDialog();
            Show();
        }
        private void buttonService_Click(object sender, EventArgs e)
        {
            Hide();
            var form = Program.Container.Resolve<FormService>();
            form.ShowDialog();
            Show();
        }


    }
}
