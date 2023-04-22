
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
        private void buttonTasks_Click(object sender, EventArgs e)
        {
            Hide();
            //var form = Container.Resolve<FormTasks>();
            //form.ShowDialog();
            Show();
        }
    }
}
