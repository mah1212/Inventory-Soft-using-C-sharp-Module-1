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
    public partial class RodQualityEntryUI : Form
    {
        public RodQualityEntryUI()
        {
            InitializeComponent();
        }

        private void saveRodQualityButton_Click(object sender, EventArgs e)
        {
            RodQuality aRodQuality = new RodQuality();
            aRodQuality.Quality= rodQualityEntryTextBox.Text;

            RodQualityManager aRodQualityManager = new RodQualityManager();
            string msg = aRodQualityManager.Save(aRodQuality);
            MessageBox.Show(msg);
        }
    }
}
