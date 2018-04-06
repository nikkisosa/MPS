using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MPSystem.View;
namespace MPSystem.View
{
    public partial class ucSettings : UserControl
    {
        private static ucSettings _instance;
        public static ucSettings Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSettings();
                return _instance;
            }
        }
        public ucSettings()
        {
            InitializeComponent();
        }

        private void pnlDump_Paint(object sender, PaintEventArgs e)
        {
            frmDumpContact dump = new frmDumpContact();
            dump.ShowDialog();
        }

        private void ucSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
