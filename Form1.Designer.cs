namespace Operasi_Citra_Sederhana
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bukaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpanSebagaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarAplikasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luminaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbOutput = new System.Windows.Forms.PictureBox();
            this.pbInput = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.colorsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1101, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bukaToolStripMenuItem,
            this.simpanSebagaiToolStripMenuItem,
            this.keluarAplikasiToolStripMenuItem});
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // bukaToolStripMenuItem
            // 
            this.bukaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bukaToolStripMenuItem.Image")));
            this.bukaToolStripMenuItem.Name = "bukaToolStripMenuItem";
            this.bukaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bukaToolStripMenuItem.Text = "Buka";
            this.bukaToolStripMenuItem.Click += new System.EventHandler(this.bukaToolStripMenuItem_Click);
            // 
            // simpanSebagaiToolStripMenuItem
            // 
            this.simpanSebagaiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("simpanSebagaiToolStripMenuItem.Image")));
            this.simpanSebagaiToolStripMenuItem.Name = "simpanSebagaiToolStripMenuItem";
            this.simpanSebagaiToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.simpanSebagaiToolStripMenuItem.Text = "Simpan Sebagai...";
            this.simpanSebagaiToolStripMenuItem.Click += new System.EventHandler(this.simpanSebagaiToolStripMenuItem_Click);
            // 
            // keluarAplikasiToolStripMenuItem
            // 
            this.keluarAplikasiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("keluarAplikasiToolStripMenuItem.Image")));
            this.keluarAplikasiToolStripMenuItem.Name = "keluarAplikasiToolStripMenuItem";
            this.keluarAplikasiToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.keluarAplikasiToolStripMenuItem.Text = "Keluar Aplikasi";
            this.keluarAplikasiToolStripMenuItem.Click += new System.EventHandler(this.keluarAplikasiToolStripMenuItem_Click);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayscaleToolStripMenuItem,
            this.brightnessToolStripMenuItem});
            this.colorsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("colorsToolStripMenuItem.Image")));
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.colorsToolStripMenuItem.Text = "Colors";
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.averageToolStripMenuItem,
            this.lightnessToolStripMenuItem,
            this.luminaceToolStripMenuItem});
            this.grayscaleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("grayscaleToolStripMenuItem.Image")));
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.grayscaleToolStripMenuItem_Click);
            // 
            // averageToolStripMenuItem
            // 
            this.averageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("averageToolStripMenuItem.Image")));
            this.averageToolStripMenuItem.Name = "averageToolStripMenuItem";
            this.averageToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.averageToolStripMenuItem.Text = "Average";
            // 
            // lightnessToolStripMenuItem
            // 
            this.lightnessToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lightnessToolStripMenuItem.Image")));
            this.lightnessToolStripMenuItem.Name = "lightnessToolStripMenuItem";
            this.lightnessToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.lightnessToolStripMenuItem.Text = "Lightness";
            // 
            // luminaceToolStripMenuItem
            // 
            this.luminaceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("luminaceToolStripMenuItem.Image")));
            this.luminaceToolStripMenuItem.Name = "luminaceToolStripMenuItem";
            this.luminaceToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.luminaceToolStripMenuItem.Text = "Luminance";
            this.luminaceToolStripMenuItem.Click += new System.EventHandler(this.luminaceToolStripMenuItem_Click);
            // 
            // brightnessToolStripMenuItem
            // 
            this.brightnessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contrastToolStripMenuItem});
            this.brightnessToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("brightnessToolStripMenuItem.Image")));
            this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
            this.brightnessToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.brightnessToolStripMenuItem.Text = "Brightness";
            this.brightnessToolStripMenuItem.Click += new System.EventHandler(this.brightnessToolStripMenuItem_Click);
            // 
            // contrastToolStripMenuItem
            // 
            this.contrastToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contrastToolStripMenuItem.Image")));
            this.contrastToolStripMenuItem.Name = "contrastToolStripMenuItem";
            this.contrastToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.contrastToolStripMenuItem.Text = "Contrast";
            this.contrastToolStripMenuItem.Click += new System.EventHandler(this.contrastToolStripMenuItem_Click_1);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pbOutput
            // 
            this.pbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOutput.Location = new System.Drawing.Point(552, 40);
            this.pbOutput.Name = "pbOutput";
            this.pbOutput.Size = new System.Drawing.Size(500, 350);
            this.pbOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOutput.TabIndex = 1;
            this.pbOutput.TabStop = false;
            this.pbOutput.Click += new System.EventHandler(this.pbOutput_Click);
            // 
            // pbInput
            // 
            this.pbInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbInput.Location = new System.Drawing.Point(35, 40);
            this.pbInput.Name = "pbInput";
            this.pbInput.Size = new System.Drawing.Size(500, 350);
            this.pbInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInput.TabIndex = 0;
            this.pbInput.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1101, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked_1);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 444);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pbOutput);
            this.Controls.Add(this.pbInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Garuda Image Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbInput;
        private System.Windows.Forms.PictureBox pbOutput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bukaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpanSebagaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keluarAplikasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luminaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrastToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

