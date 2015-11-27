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
            this.tbxOr1 = new System.Windows.Forms.TextBox();
            this.tbxAnd2 = new System.Windows.Forms.TextBox();
            this.pbxAnd = new System.Windows.Forms.PictureBox();
            this.lblSvarAnd = new System.Windows.Forms.Label();
            this.tbxOr2 = new System.Windows.Forms.TextBox();
            this.pbxOr = new System.Windows.Forms.PictureBox();
            this.lblSvarOr = new System.Windows.Forms.Label();
            this.tbxNand1 = new System.Windows.Forms.TextBox();
            this.tbxNand2 = new System.Windows.Forms.TextBox();
            this.pbxNand = new System.Windows.Forms.PictureBox();
            this.lblSvarNand = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNand)).BeginInit();
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
            // tbxOr1
            // 
            this.tbxOr1.Location = new System.Drawing.Point(12, 162);
            this.tbxOr1.MaxLength = 1;
            this.tbxOr1.Name = "tbxOr1";
            this.tbxOr1.Size = new System.Drawing.Size(25, 20);
            this.tbxOr1.TabIndex = 2;
            // 
            // tbxAnd2
            // 
            this.tbxAnd2.Location = new System.Drawing.Point(12, 87);
            this.tbxAnd2.MaxLength = 1;
            this.tbxAnd2.Name = "tbxAnd2";
            this.tbxAnd2.Size = new System.Drawing.Size(25, 20);
            this.tbxAnd2.TabIndex = 3;
            this.tbxAnd2.TextChanged += new System.EventHandler(this.Form1_TextChanged);
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
            // tbxOr2
            // 
            this.tbxOr2.Location = new System.Drawing.Point(12, 208);
            this.tbxOr2.MaxLength = 1;
            this.tbxOr2.Name = "tbxOr2";
            this.tbxOr2.Size = new System.Drawing.Size(25, 20);
            this.tbxOr2.TabIndex = 6;
            // 
            // pbxOr
            // 
            this.pbxOr.BackgroundImage = global::scr.Properties.Resources.Kopia_av_2or;
            this.pbxOr.Location = new System.Drawing.Point(43, 133);
            this.pbxOr.Name = "pbxOr";
            this.pbxOr.Size = new System.Drawing.Size(189, 111);
            this.pbxOr.TabIndex = 7;
            this.pbxOr.TabStop = false;
            this.pbxOr.Click += new System.EventHandler(this.pbxOr_Click);
            // 
            // lblSvarOr
            // 
            this.lblSvarOr.AutoSize = true;
            this.lblSvarOr.Location = new System.Drawing.Point(239, 184);
            this.lblSvarOr.Name = "lblSvarOr";
            this.lblSvarOr.Size = new System.Drawing.Size(13, 13);
            this.lblSvarOr.TabIndex = 8;
            this.lblSvarOr.Text = "?";
            // 
            // tbxNand1
            // 
            this.tbxNand1.Location = new System.Drawing.Point(291, 42);
            this.tbxNand1.MaxLength = 1;
            this.tbxNand1.Name = "tbxNand1";
            this.tbxNand1.Size = new System.Drawing.Size(27, 20);
            this.tbxNand1.TabIndex = 9;
            // 
            // tbxNand2
            // 
            this.tbxNand2.Location = new System.Drawing.Point(291, 87);
            this.tbxNand2.MaxLength = 1;
            this.tbxNand2.Name = "tbxNand2";
            this.tbxNand2.Size = new System.Drawing.Size(25, 20);
            this.tbxNand2.TabIndex = 10;
            // 
            // pbxNand
            // 
            this.pbxNand.BackgroundImage = global::scr.Properties.Resources.Kopia_av_1nand;
            this.pbxNand.Location = new System.Drawing.Point(324, 12);
            this.pbxNand.Name = "pbxNand";
            this.pbxNand.Size = new System.Drawing.Size(190, 115);
            this.pbxNand.TabIndex = 11;
            this.pbxNand.TabStop = false;
            this.pbxNand.Click += new System.EventHandler(this.pbxNand_Click);
            // 
            // lblSvarNand
            // 
            this.lblSvarNand.AutoSize = true;
            this.lblSvarNand.Location = new System.Drawing.Point(521, 65);
            this.lblSvarNand.Name = "lblSvarNand";
            this.lblSvarNand.Size = new System.Drawing.Size(13, 13);
            this.lblSvarNand.TabIndex = 12;
            this.lblSvarNand.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 457);
            this.Controls.Add(this.lblSvarNand);
            this.Controls.Add(this.pbxNand);
            this.Controls.Add(this.tbxNand2);
            this.Controls.Add(this.tbxNand1);
            this.Controls.Add(this.lblSvarOr);
            this.Controls.Add(this.pbxOr);
            this.Controls.Add(this.tbxOr2);
            this.Controls.Add(this.lblSvarAnd);
            this.Controls.Add(this.pbxAnd);
            this.Controls.Add(this.tbxAnd2);
            this.Controls.Add(this.tbxOr1);
            this.Controls.Add(this.tbxAnd1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Projekt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TextChanged += new System.EventHandler(this.Form1_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxAnd1;
        private System.Windows.Forms.TextBox tbxOr1;
        private System.Windows.Forms.TextBox tbxAnd2;
        private System.Windows.Forms.PictureBox pbxAnd;
        private System.Windows.Forms.Label lblSvarAnd;
        private System.Windows.Forms.TextBox tbxOr2;
        private System.Windows.Forms.PictureBox pbxOr;
        private System.Windows.Forms.Label lblSvarOr;
        private System.Windows.Forms.TextBox tbxNand1;
        private System.Windows.Forms.TextBox tbxNand2;
        private System.Windows.Forms.PictureBox pbxNand;
        private System.Windows.Forms.Label lblSvarNand;
    }
}

