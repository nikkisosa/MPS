using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPSystem
{
    public partial class MMS : Form
    {
        public MMS()
        {
            InitializeComponent();
        }

        private void btn_contacts_Click(object sender, EventArgs e)
        {
            if (!Mainpanel.Controls.Contains(ucContacts.Instance))
            {
                Mainpanel.Controls.Add(ucContacts.Instance);
                ucContacts.Instance.Dock = DockStyle.Fill;
                ucContacts.Instance.BringToFront();
            }
            else
            {
                ucContacts.Instance.BringToFront();
            }
        }
    }
}
