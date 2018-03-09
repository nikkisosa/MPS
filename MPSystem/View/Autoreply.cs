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
    public partial class Autoreply : UserControl
    {
        private static Autoreply _instance;
        public static Autoreply Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Autoreply();
                return _instance;
            }
        }
        public Autoreply()
        {
            InitializeComponent();
        }

        private void Autoreply_Load(object sender, EventArgs e)
        {

        }
    }
}
