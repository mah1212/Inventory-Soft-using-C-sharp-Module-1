using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopInventoryManagementApp.InventoryManager;
using DesktopInventoryManagementApp.Model;

namespace DesktopInventoryManagementApp.UI
{
    public partial class ProviderCompanyUI : Form
    {
        public ProviderCompanyUI()
        {
            InitializeComponent();
        }

        private void saveProviderCompanyButton_Click(object sender, EventArgs e)
        {
            ProviderCompany aProviderCompany = new ProviderCompany();
            aProviderCompany.Name = nameProviderCompanyEntryTextBox.Text;
            aProviderCompany.Contact = contactProviderCompnayEntrytextBox.Text;

            ProviderComapnyManager aProviderComapnyManager = new ProviderComapnyManager();
            string msg = aProviderComapnyManager.Save(aProviderCompany);
            MessageBox.Show(msg);


        }
    }
}
