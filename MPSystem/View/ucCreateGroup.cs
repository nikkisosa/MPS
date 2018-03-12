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
    public partial class ucCreateGroup : UserControl
    {
        private static ucCreateGroup _instance;
        public static ucCreateGroup Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucCreateGroup();
                return _instance;
            }
        }
        public ucCreateGroup()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
        }
    }
}
