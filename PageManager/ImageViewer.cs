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

namespace PageManager
{
    public partial class ImageViewer : Form
    {
        string imagePath = null;

        public ImageViewer()
        {
            InitializeComponent();

            // set open image dialog to restrict files
            openImageDialog.Filter = "Image files (*.jpg,*.jpeg,*.jpe,*.jfif,*.png,*.tiff)|*.jpg;*.jpeg;*.jpe;*.jfif;*.png;*.tiff";
            trackBar1.SetRange(10, 50);
        }

        private void selectImageBtn_Click(object sender, EventArgs e)
        {
            if (openImageDialog.ShowDialog() == DialogResult.OK) {
                imagePath = openImageDialog.FileName;    // image path

                imagePathField.Text = imagePath;

                Bitmap b = new Bitmap(imagePath);
                ImageViewModule.CanvasSize = b.Size;
                ImageViewModule.Image = b;
                ImageViewModule.Zoom = trackBar1.Value * 0.02f;
            }
            
        }

        private void savePageBtn_Click(object sender, EventArgs e)
        {
            // testing variables ~ will be dynamic in main application
            const string LedgerID = "HELLO";    // is folder name
            const int PageNumber = 1;   // is image name
            const string DumpFolder = "dump";   // name of dump folder for exisiting images

            string sourceFile = imagePath;  
            string imageExtention = Path.GetExtension(imagePath);   // get image extension type
            string destinationFolder = @"C:\Users\shala\Desktop\" + LedgerID + @"\";   // 
            string destinationFile = destinationFolder + PageNumber + imageExtention;  // hard coded path
            try {

                Directory.CreateDirectory(destinationFolder);   // create ledger folder
                
                if (File.Exists(destinationFile)) {
                    // create a dump folder 
                    // move existing image to dump 
                    // proceed to paste new image

                    string dumpFolder = destinationFolder + DumpFolder + @"\";   // dump folder for current ledger
                    string dumpFile = dumpFolder + PageNumber + imageExtention;   // dump file location for current page in ledger
                    
                    Directory.CreateDirectory(dumpFolder);   // create dump folder

                    if (File.Exists(dumpFile))
                    {
                        // an exisiting dump image already exists for current ledger
                        // count number of images in dump folder
                        // create name of dump imagename_(numimage+1)

                        // count files in dump directory
                        int fCount = Directory.GetFiles(dumpFolder, "*", SearchOption.TopDirectoryOnly).Length;
                        string newDumpFileName = PageNumber + "_" + fCount; // new dump image name
                        string newDumpFile = dumpFolder + newDumpFileName + imageExtention; // create new dump path with renamed dump image
                        File.Move(destinationFile,newDumpFile);
                    }
                    else { 
                        // no dump image(s) for current page in currrent ledger
                        File.Move(destinationFile,dumpFile);   // moves the exisiting file
                    }
                }

                File.Copy(sourceFile,destinationFile,false);   // copy image to

            }catch(InvalidOperationException iox){
                MessageBox.Show(iox.Message);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ImageViewModule.Zoom = trackBar1.Value * 0.02f;
        }
    }
}
