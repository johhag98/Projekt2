namespace scr
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
            this.tbxAnd1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbxAnd2 = new System.Windows.Forms.TextBox();
            this.pbxAnd = new System.Windows.Forms.PictureBox();
            this.lblSvarAnd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnd)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxAnd1
            // 
            this.tbxAnd1.Location = new System.Drawing.Point(12, 42);
            this.tbxAnd1.MaxLength = 1;
            this.tbxAnd1.Name = "tbxAnd1";
            this.tbxAnd1.Size = new System.Drawing.Size(25, 20);
            this.tbxAnd1.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 160);
            this.textBox3.MaxLength = 1;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(25, 20);
            this.textBox3.TabIndex = 2;
            // 
            // tbxAnd2
            // 
            this.tbxAnd2.Location = new System.Drawing.Point(12, 87);
            this.tbxAnd2.MaxLength = 1;
            this.tbxAnd2.Name = "tbxAnd2";
            this.tbxAnd2.Size = new System.Drawing.Size(25, 20);
            this.tbxAnd2.TabIndex = 3;
            // 
            // pbxAnd
            // 
            this.pbxAnd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxAnd.BackgroundImage")));
            this.pbxAnd.Location = new System.Drawing.Point(43, 12);
            this.pbxAnd.Name = "pbxAnd";
            this.pbxAnd.Size = new System.Drawing.Size(190, 115);
            this.pbxAnd.TabIndex = 4;
            this.pbxAnd.TabStop = false;
            this.pbxAnd.Click += new System.EventHandler(this.pbxAnd_Click);
            // 
            // lblSvarAnd
            // 
            this.lblSvarAnd.AutoSize = true;
            this.lblSvarAnd.Location = new System.Drawing.Point(239, 65);
            this.lblSvarAnd.Name = "lblSvarAnd";
            this.lblSvarAnd.Size = new System.Drawing.Size(13, 13);
            this.lblSvarAnd.TabIndex = 5;
            this.lblSvarAnd.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 457);
            this.Controls.Add(this.lblSvarAnd);
            this.Controls.Add(this.pbxAnd);
            this.Controls.Add(this.tbxAnd2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tbxAnd1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Projekt";
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxAnd1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tbxAnd2;
        private System.Windows.Forms.PictureBox pbxAnd;
        private System.Windows.Forms.Label lblSvarAnd;
    }
}

