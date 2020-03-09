namespace Operasi_Citra_Sederhana
{
    partial class FormBrightContrast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBrightContrast));
            this.btnOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbContrast = new System.Windows.Forms.TextBox();
            this.tbBrightness = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hscContrast = new System.Windows.Forms.HScrollBar();
            this.hscBrightness = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(365, 305);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "BRIGHTNESS && CONTRAST";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbContrast
            // 
            this.tbContrast.Location = new System.Drawing.Point(634, 224);
            this.tbContrast.Margin = new System.Windows.Forms.Padding(4);
            this.tbContrast.Name = "tbContrast";
            this.tbContrast.Size = new System.Drawing.Size(48, 22);
            this.tbContrast.TabIndex = 13;
            // 
            // tbBrightness
            // 
            this.tbBrightness.Location = new System.Drawing.Point(634, 183);
            this.tbBrightness.Margin = new System.Windows.Forms.Padding(4);
            this.tbBrightness.Name = "tbBrightness";
            this.tbBrightness.Size = new System.Drawing.Size(48, 22);
            this.tbBrightness.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Contrast";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Brightness";
            // 
            // hscContrast
            // 
            this.hscContrast.Location = new System.Drawing.Point(214, 228);
            this.hscContrast.Maximum = 127;
            this.hscContrast.Minimum = -127;
            this.hscContrast.Name = "hscContrast";
            this.hscContrast.Size = new System.Drawing.Size(393, 17);
            this.hscContrast.TabIndex = 9;
            // 
            // hscBrightness
            // 
            this.hscBrightness.Location = new System.Drawing.Point(214, 183);
            this.hscBrightness.Maximum = 127;
            this.hscBrightness.Minimum = -127;
            this.hscBrightness.Name = "hscBrightness";
            this.hscBrightness.Size = new System.Drawing.Size(393, 17);
            this.hscBrightness.TabIndex = 8;
            // 
            // FormBrightContrast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbContrast);
            this.Controls.Add(this.tbBrightness);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hscContrast);
            this.Controls.Add(this.hscBrightness);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBrightContrast";
            this.Text = "FormBrightContrast";
            this.Load += new System.EventHandler(this.FormBrightContrast_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbContrast;
        public System.Windows.Forms.TextBox tbBrightness;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar hscContrast;
        private System.Windows.Forms.HScrollBar hscBrightness;
    }
}