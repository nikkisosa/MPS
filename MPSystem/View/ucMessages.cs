using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace MPSystem.View
{
    public partial class ucMessages : UserControl
    {
        private static ucMessages _instance;
        public static ucMessages Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucMessages();
                return _instance;
            }
        }

        private static string str;
        private static int pageNumber = 1;
        private static int item_new_id = 0;
        private static int item_old_id = 0;
        private static int totalCount = 0;
        private static int totalPage = 0;
        public ucMessages()
        {
            InitializeComponent();
            backgroundworker.DoWork += backgroundworker_DoWork;
            backgroundworker.ProgressChanged += backgroundworker_ProgressChanged;
            backgroundworker.RunWorkerCompleted += backgroundworker_RunWorkerCompleted;
            backgroundworker.WorkerReportsProgress = true;
            backgroundworker.WorkerSupportsCancellation = true;
        }

        void backgroundworker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Process was cancelled");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("There was an error running the process. The thread aborted");
            }
            else
            {
                loadData();
            }
        }

        void backgroundworker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //progressBar1.Value = e.ProgressPercentage;
        }

        void backgroundworker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
                backgroundworker.ReportProgress(i);

                //Check if there is a request to cancel the process
                if (backgroundworker.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundworker.ReportProgress(0);
                    return;
                }
            }
            //If the process exits the loop, ensure that progress is set to 100%
            //Remember in the loop we set i < 100 so in theory the process will complete at 99%
            backgroundworker.ReportProgress(100);
        }

        /**
         * Load data from database
         */
        public void loadData()
        {
            str = Model.messageModel.getMessage(pageNumber);
            if (str == "success")
            {
                
                totalCount = config.records.Count;
                if (totalCount > 0)
                {
                    lvList.Items.Clear();

                    for (int count = 0; count < config.records.Count; count++)
                    {
                        ListViewItem item = new ListViewItem(config.records[count].id.ToString());
                        item.SubItems.Add(config.records[count].mobile_no.ToString());
                        item.SubItems.Add(config.records[count].message.ToString());
                        item.SubItems.Add(config.records[count].dateCreated.ToString());
                        item.SubItems.Add(config.records[count].promotionTitle.ToString());
                        lvList.Items.Add(item);
                        item_new_id = config.records[count].id;
                    }

                    str = Model.messageModel.getTotalPage();
                    if(str == "success")
                    {
                        if (item_new_id == item_old_id)
                        {

                        }
                        else
                        {
                            item_old_id = item_new_id;
                            totalPage = ((config.records[0].totalpage / Entity.variables.pageSize) + 1);
                            lblPages.Text = "Page " + pageNumber + " of " + ((config.records[0].totalpage / Entity.variables.pageSize) + 1).ToString();
                        }
                    }
                }
            }
            else
            {
                
            }

        }

        private void ucMessages_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            backgroundworker.RunWorkerAsync();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (totalCount > 0)
            {
                if (totalPage == pageNumber)
                {

                }
                else
                {
                    pageNumber = pageNumber + 1;
                    loadData();
                }

            }
            else
            {
                //leave empty
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (totalCount != 0)
            {
                if (pageNumber == 1)
                {

                }
                else
                {
                    pageNumber = pageNumber - 1;
                    loadData();
                }

            }
            else
            {
                if (pageNumber == 1)
                {

                }
                else
                {
                    pageNumber = pageNumber - 1;
                    loadData();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
