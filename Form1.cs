using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operasi_Citra_Sederhana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pbOutput_Click(object sender, EventArgs e)
        {

        }

        private void simpanSebagaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(pbOutput.Image == null)
        {
                MessageBox.Show("Tidak Ada citra yang akan disimpan");
            }
            else
            {
                SaveFileDialog simpanFile = new SaveFileDialog();
                simpanFile.Title = "Simpan File Citra";
                simpanFile.Filter = "Image File (*.bmp, *.jpg, *.jpeg)|*.bmp;*.jpg;*.jpeg";
                if (DialogResult.OK == simpanFile.ShowDialog())
                    this.pbOutput.Image.Save(simpanFile.FileName);
            }
        }

        private void bukaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog bukaFile = new OpenFileDialog();
            bukaFile.Filter = "Image File (*.bmp, *.jpg, *.jpeg)|*.bmp;*.jpg;*.jpeg";
            if (DialogResult.OK == bukaFile.ShowDialog())
            {
                this.pbInput.Image = new Bitmap(bukaFile.FileName);
                string path = Path.GetFullPath(bukaFile.FileName);
                string reso = ("Res. Citra: " + pbInput.Image.Width + "X" + pbInput.Image.Height);
                this.toolStripStatusLabel1.Text = path;
                this.toolStripStatusLabel2.Text = reso;
            }
        }

        private void keluarAplikasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void brightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void luminaceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pbInput.Image);
            olahCitra.keBrightness(copy);
            this.pbOutput.Image = copy;
        }

        private void contrastToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pbInput.Image);
            olahCitra.keBrightness(copy);
            this.pbOutput.Image = copy;
        }

        
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void ToolStripStatusLabel2_Click_2(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
