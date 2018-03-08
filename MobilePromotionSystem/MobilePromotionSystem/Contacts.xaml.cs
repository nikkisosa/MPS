using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MobilePromotionSystem
{
    /// <summary>
    /// Interaction logic for Contacts.xaml
    /// </summary>
    public partial class Contacts : UserControl
    {
        public Contacts()
        {
            InitializeComponent();
        }

        private void loadContact()
        {
            string str = Model.contactModel.getContacts();
            if(str == "success")
            {
                listContact.Items.Clear();
                ListView item = new ListView();
                for (int count = 0; count < config.records.Count; count++)
                {
                    item.ad
                    listContact.ItemsSource = config.records[count].mobile_no.ToString();
                    //listContact.Items.Add(config.records[count].mobile_no.ToString());

                }
            }
            else
            {

            }
            
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string mobile_no = txtContact.Text.Trim();
            string network = cboNetwork.Text.Trim();
            if (mobile_no == "" || network == "")
            {
                MessageBox.Show("Please enter the number and network","MPS",MessageBoxButton.OK,MessageBoxImage.Hand);
            }
            else
            {
                Entity.Contacts ent = new Entity.Contacts();
                ent.mobile_no = mobile_no;
                ent.network = network;
                string str = Model.contactModel.addContact(ent);
                if (str == "success")
                {
                    MessageBox.Show("successfully added","MPS",MessageBoxButton.OK,MessageBoxImage.Information);
                    loadContact();
                }
                else
                {
                    MessageBox.Show(str);
                }
            }
        }

        private void frmContact_Loaded(object sender, RoutedEventArgs e)
        {
            loadContact();
        }

    }
}
