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
    public partial class RodSizeEntryUI : Form
    {
        public RodSizeEntryUI()
        {
            InitializeComponent();
        }

        private void rodSizeSaveButton_Click(object sender, EventArgs e)
        {
            RodSize aRodSize = new RodSize();
            aRodSize.Size = rodSizeEntryTextBox.Text;

            RodSizeManager aRodSizeManager = new RodSizeManager();
            string msg = aRodSizeManager.Save(aRodSize);
            MessageBox.Show(msg);
        }
    }
}
