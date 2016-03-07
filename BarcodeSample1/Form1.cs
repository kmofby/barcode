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
using System.IO;
using System.Drawing.Imaging;
using System.Security.AccessControl;
using System.Security.Principal;
using TemplateEngine.Docx;
//using DocumentFormat.OpenXml;
//using DocumentFormat.OpenXml.Packaging;
//using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Packaging;

namespace BarcodeSample1
{
    public partial class Form1 : Form
    {
        Bitmap myBitmap;
        Graphics g;


        public Form1()
        {
            InitializeComponent();
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
        }



        private void cmdMakeBarcode_Click(object sender, EventArgs e)
        {
            try
            {
                myBitmap = (Bitmap)Code128Rendering.MakeBarcodeImage(txtInput.Text, int.Parse(txtWeight.Text), true);
                pictBarcode.Image = myBitmap;
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
            using (g = e.Graphics)
            {
                using (System.Drawing.Font fnt = new System.Drawing.Font("Arial", 16))
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
            GrantAccess("c:\\temp");
            myBitmap.Save("c:\\temp\\1button.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private bool GrantAccess(string fullPath)
        {
            DirectoryInfo dInfo = new DirectoryInfo(fullPath);
            DirectorySecurity dSecurity = dInfo.GetAccessControl();
            dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
            dInfo.SetAccessControl(dSecurity);
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var valuesToFill = new Content(
            new FieldContent("Phone number", txtInput.Text));

            File.Copy("OutputDocument.docx", "OutputDocument" + txtInput.Text + ".docx");
            using (var outputDocument = new TemplateProcessor("OutputDocument" + txtInput.Text + ".docx")
                    .SetRemoveContentControls(true))
            {
                outputDocument.FillContent(valuesToFill);
                outputDocument.SaveChanges();
            }

            using (WordprocessingDocument document = WordprocessingDocument.Open("OutputDocument" + txtInput.Text + ".docx", true))
            {

                // go through the document and pull out the inline image elements
                IEnumerable<Inline> imageElements = from run in document.MainDocumentPart.Document.Descendants<Run>()
                                                    where run.Descendants<Inline>().First() != null
                                                    select run.Descendants<Inline>().First();

                // select the image that has the correct filename (chooses the first if there are many)
               // Inline selectedImage = (from image in imageElements
               //                         where (image.DocProperties != null &&
               //                             image.DocProperties.Equals("image1.png"))
               //                         select image).First();

                // get the ID from the inline element
                string imageId = "rId9";
               // Blip blipElement = selectedImage.Descendants<Blip>().First();
               // if (blipElement != null)
               // {
               //     imageId = blipElement.Embed.Value;
               // }

                ImagePart imagePart = (ImagePart)document.MainDocumentPart.GetPartById(imageId);
                byte[] imageBytes = File.ReadAllBytes("1button.jpg");
                BinaryWriter writer = new BinaryWriter(imagePart.GetStream());
                writer.Write(imageBytes);
                writer.Close();

            }

            
        }

    }
}
