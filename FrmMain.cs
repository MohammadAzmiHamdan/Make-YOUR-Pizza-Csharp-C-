using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOrderForm_Click(object sender, System.EventArgs e)
        {
            FrmOrder1 frmOrder = new FrmOrder1();
            frmOrder.Show();
        }
    }
}
