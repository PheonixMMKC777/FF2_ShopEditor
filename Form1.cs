using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FF2_ShopEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openRomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open file Dialog...
            this.openFileDialog1.DefaultExt = "nes";
            this.openFileDialog1.InitialDirectory = @"C:\";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Filter = "NES files (*.nes)|*nes|All files (*.*)|*.*\"";
            this.openFileDialog1.Title = "Final Fantasy 2 Rom...";
            this.openFileDialog1.ShowDialog();



            PRG.ROM = File.ReadAllBytes(this.openFileDialog1.FileName);
            this.ItemPriceBox.Enabled = true;
            this.UpdateItemPrice.Enabled = true;
            this.ItemListBox.Enabled = true;
            this.ShopNameComboBox.Enabled = true;
            //this.ShopNameComboBox.SelectedIndex = 0;

            this.UpdateShopButton.Enabled = true;
            this.ItemAComboBox.Enabled = true;
            this.ItemBComboBox.Enabled = true;
            this.ItemCComboBox.Enabled = true;
            this.ItemDComboBox.Enabled = true;

            this.StoreCostboxA.Enabled = true;
            this.StoreCostboxB.Enabled = true;
            this.StoreCostboxC.Enabled = true;
            this.StoreCostboxD.Enabled = true;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PRG.CurrentIndex = this.ItemListBox.SelectedIndex * 2;
            PRG.HiByte = PRG.ROM[PRG.ItemOffset + PRG.CurrentIndex];
            PRG.LoByte = PRG.ROM[PRG.ItemOffset + PRG.CurrentIndex + 1];


            PRG.RealPrice[0] = PRG.HiByte;
            PRG.RealPrice[1] = PRG.LoByte;

            int RP = BitConverter.ToUInt16(PRG.RealPrice,0) * 2;
            this.ItemPriceBox.Text = RP.ToString();

        }



        private void saveRomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save handler
            this.SaveAsRom.RestoreDirectory = true;
            this.SaveAsRom.Title = "Save Rom File...";
            this.SaveAsRom.DefaultExt = "nes";
            this.SaveAsRom.Filter = "NES files (*.nes)|*nes|All files (*.*)|*.*\"";
            this.SaveAsRom.FileName = "FinalFantasy2_Shop";
            this.SaveAsRom.CheckPathExists = true;
            this.SaveAsRom.ShowDialog();

            //write to file
            File.WriteAllBytes(this.SaveAsRom.FileName, PRG.ROM);
        }

        private void UpdateItemPrice_Click(object sender, EventArgs e)
        {
            int x = (Convert.ToUInt16(this.ItemPriceBox.Text) / 2);
            byte[] barr = BitConverter.GetBytes(x);
            PRG.ROM[PRG.ItemOffset + PRG.CurrentIndex] = barr[0];
            PRG.ROM[PRG.ItemOffset + PRG.CurrentIndex + 1] = barr[1];
        }

        private void ShopNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PRG.ShopIndex = this.ShopNameComboBox.SelectedIndex * 8;

            this.ItemAComboBox.SelectedIndex = PRG.ROM[PRG.ShopOffset + PRG.ShopIndex];
            this.StoreCostboxA.Text = PRG.ROM[PRG.ShopOffset + PRG.ShopIndex + 1].ToString();

            this.ItemBComboBox.SelectedIndex = PRG.ROM[PRG.ShopOffset + PRG.ShopIndex + 2];
            this.StoreCostboxB.Text = PRG.ROM[PRG.ShopOffset + PRG.ShopIndex + 3].ToString();

            this.ItemCComboBox.SelectedIndex = PRG.ROM[PRG.ShopOffset + PRG.ShopIndex + 4];
            this.StoreCostboxC.Text = PRG.ROM[PRG.ShopOffset + PRG.ShopIndex + 5].ToString();

            this.ItemDComboBox.SelectedIndex = PRG.ROM[PRG.ShopOffset + PRG.ShopIndex + 6];
            this.StoreCostboxD .Text = PRG.ROM[PRG.ShopOffset + PRG.ShopIndex + 7].ToString();
        }
    }
}
