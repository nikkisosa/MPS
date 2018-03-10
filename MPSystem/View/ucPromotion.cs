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
    public partial class ucPromotion : UserControl
    {
        private static ucPromotion _instance;
        public static ucPromotion Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucPromotion();
                return _instance;
            }
        }

        public ucPromotion()
        {
            InitializeComponent();
        }

        private void ucPromotion_Load(object sender, EventArgs e)
        {

        }
    }
}
