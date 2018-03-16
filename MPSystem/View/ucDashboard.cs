using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace MPSystem.View
{
    public partial class ucDashboard : UserControl
    {
        private static ucDashboard _instance;
        public static ucDashboard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucDashboard();
                return _instance;
            }
        }

        public ucDashboard()
        {
            InitializeComponent();
        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            string result = Model.dashBoardModel.getActivePorts();
            if (result == "success")
            {
                // Check if the records contains data.
                if (config.records.Count > 0)
                {
                    for (int i = 0; i < config.records.Count; i++)
                    {
                        //Add the fields to the DataGridView
                        ArrayList row = new ArrayList();
                        row.Add(false);
                        row.Add(config.records[i].port);
                        row.Add(config.records[i].mobile_no);
                        row.Add(config.records[i].balance);
                        dashGrid.Rows.Add(row.ToArray());
                    }
                    
                }
            }
        }
    }
}
