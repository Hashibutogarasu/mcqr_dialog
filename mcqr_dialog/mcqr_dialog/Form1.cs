using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mcqr_dialog
{
    public partial class dialog_yesno : Form
    {
        public dialog_yesno()
        {
            InitializeComponent();
            
        }

        private void dialog_yesno_Load(object sender, EventArgs e)
        {

        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OKButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
