 
using Unity;

namespace HostelProduct
{
    public partial class FormPas : Form

    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public string fio { get; set; }
        public int idUser { get; set; }
        public FormPas()
        {
            InitializeComponent();
        }
    }
}
