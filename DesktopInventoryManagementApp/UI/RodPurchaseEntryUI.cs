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
    public partial class RodPurchaseEntryUI : Form
    {
        public RodPurchaseEntryUI()
        {
            InitializeComponent();
        }

        Manufacturer aManufacturer = new Manufacturer();
        ProviderCompany aProviderCompany = new ProviderCompany();
        RodSize aRodSize = new RodSize();
        RodQuality aRodQuality = new RodQuality();
        RodPurchese aRodPurchese = new RodPurchese();

        ManufacturerManager aManufacturerManager = new ManufacturerManager();
        ProviderComapnyManager aProviderComapnyManager = new ProviderComapnyManager();
        RodSizeManager aRodSizeManager = new RodSizeManager();
        RodQualityManager aQualityManager = new RodQualityManager();
        RodPurchaseManager aRodPurchaseManager = new RodPurchaseManager();

        private void RodPurchaseEntryUI_Load(object sender, EventArgs e)
        {
            manufacturerComboBox.DisplayMember = "Name";
            manufacturerComboBox.ValueMember = "Id";
            manufacturerComboBox.DataSource = aManufacturerManager.GetAll();

            providerComboBox.DisplayMember = "Name";
            providerComboBox.ValueMember = "Id";
            providerComboBox.DataSource = aProviderComapnyManager.GetAll();

            sizeComboBox.DisplayMember = "Size";
            sizeComboBox.ValueMember = "Id";
            sizeComboBox.DataSource = aRodSizeManager.GetAll();

            qualityComboBox.DisplayMember = "Quality";
            qualityComboBox.ValueMember = "Id";
            qualityComboBox.DataSource = aQualityManager.GetAll();
        }

        private void addManufacturerButton_Click(object sender, EventArgs e)
        {
            ManufacturerEntryUI aManufacturerEntryUi = new ManufacturerEntryUI();
            aManufacturerEntryUi.Show();
        }

        private void addProviderButton_Click(object sender, EventArgs e)
        {
            ProviderCompanyUI aProviderCompanyUi = new ProviderCompanyUI();
            aProviderCompanyUi.Show();
        }

        private void addQualityButton_Click(object sender, EventArgs e)
        {
            RodQualityEntryUI aRodQualityEntryUi = new RodQualityEntryUI();
            aRodQualityEntryUi.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            manufacturerComboBox.DisplayMember = "Name";
            manufacturerComboBox.ValueMember = "Id";
            manufacturerComboBox.DataSource = aManufacturerManager.GetAll();

            providerComboBox.DisplayMember = "Name";
            providerComboBox.ValueMember = "Id";
            providerComboBox.DataSource = aProviderComapnyManager.GetAll();

            sizeComboBox.DisplayMember = "Size";
            sizeComboBox.ValueMember = "Id";
            sizeComboBox.DataSource = aRodSizeManager.GetAll();

            qualityComboBox.DisplayMember = "Quality";
            qualityComboBox.ValueMember = "Id";
            qualityComboBox.DataSource = aQualityManager.GetAll();
        }

        private void addSizeButton_Click(object sender, EventArgs e)
        {
            RodSizeEntryUI aRodSizeEntryUi = new RodSizeEntryUI();
            aRodSizeEntryUi.Show();
        }


       

        

        private void paidEntryTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            
            paidShowTextBox.Text = paidEntryTextBox.Text.ToString();
            aRodPurchese.Paid = Convert.ToDouble(paidEntryTextBox.Text);
            dueShowTextBox.Text = aRodPurchese.GetDueAmount().ToString();

            

        }



        private void showPaymentStatusButton_Click(object sender, EventArgs e)
        {
            aRodPurchese.UnitPrice = Convert.ToDouble(unitPriceEntryTextBox.Text);
            aRodPurchese.Quantity = Convert.ToDouble(quantityEntryTextBox.Text);
            totalPriceShowTextBox1.Text = aRodPurchese.GetTotalPrice().ToString();
            totalPriceShowTextBox.Text = aRodPurchese.GetTotalPrice().ToString();
        }

        private void totalPriceShowButton_Click(object sender, EventArgs e)
        {
            aRodPurchese.UnitPrice = Convert.ToDouble(unitPriceEntryTextBox.Text);
            aRodPurchese.Quantity = Convert.ToDouble(quantityEntryTextBox.Text);
            totalPriceShowTextBox1.Text = aRodPurchese.GetTotalPrice().ToString();
            totalPriceShowTextBox.Text = aRodPurchese.GetTotalPrice().ToString();
        }

       

        

        
    }
}
