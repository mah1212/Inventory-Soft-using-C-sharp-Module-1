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
    public partial class ManufacturerEntryUI : Form
    {
        public ManufacturerEntryUI()
        {
            InitializeComponent();
        }

        private void companySaveButton_Click(object sender, EventArgs e)
        {
            string companyName = companyEntryTextBox.Text;

            Manufacturer aManufacturer = new Manufacturer();
            aManufacturer.Name = companyName;

            ManufacturerManager manufacturerManager = new ManufacturerManager();
            string msg = manufacturerManager.Save(aManufacturer);
            MessageBox.Show(msg);
        }
    }
}
