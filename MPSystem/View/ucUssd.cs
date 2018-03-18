using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPSystem.View
{
    public partial class ucUssd : UserControl
    {
        private static ucUssd _instance;
        public static ucUssd Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucUssd();
                return _instance;
            }
        }

        public ucUssd()
        {
            InitializeComponent();
        }

        private void ucUssd_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
