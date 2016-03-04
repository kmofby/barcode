using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenCode128;

namespace BarcodeSample1
{
    public partial class Form1 : Form
    {
        Image myimg;

        public Form1()
        {
            InitializeComponent();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
        }



        private void cmdMakeBarcode_Click(object sender, EventArgs e)
        {
            try
            {
                myimg = Code128Rendering.MakeBarcodeImage(txtInput.Text, int.Parse(txtWeight.Text), true);
                pictBarcode.Image = myimg;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, this.Text);
            }
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                using (Font fnt = new Font("Arial", 16))
                {
                    string caption = string.Format("Code128 barcode weight={0}", txtWeight.Text);
                    g.DrawString(caption, fnt, System.Drawing.Brushes.Black, 50, 50);
                    caption = string.Format("message='{0}'", txtInput.Text);
                    g.DrawString(caption, fnt, System.Drawing.Brushes.Black, 50, 75);
                    g.DrawImage(pictBarcode.Image, 50, 110);
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            pictBarcode.Image.Save("c:\\button.gif", System.Drawing.Imaging.ImageFormat.Gif);
        }
    }
}
