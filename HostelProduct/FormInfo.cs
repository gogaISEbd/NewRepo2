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
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent();
            FormLoad();
        }

        private void FormLoad()
        {
            textBox1.Text = "Программа позволяет заполнять справочники сотрудников, номеров и дополнительных услшуг, оказываемых компанией" +
                " В программе существует две роли, Консьерж и Бухгалтер. Бухгалтер заполняет указанные справочники, выдает задачи подчиненным";
        }
    }
}
