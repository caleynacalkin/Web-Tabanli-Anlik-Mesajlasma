namespace Msg
{
    partial class frmİletisim
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
            this.btnOk = new System.Windows.Forms.Button();
            this.lblYazi = new System.Windows.Forms.Label();
            this.gb = new System.Windows.Forms.GroupBox();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Wheat;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOk.Location = new System.Drawing.Point(68, 106);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 41);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblYazi
            // 
            this.lblYazi.AutoSize = true;
            this.lblYazi.Location = new System.Drawing.Point(58, 34);
            this.lblYazi.Name = "lblYazi";
            this.lblYazi.Size = new System.Drawing.Size(0, 13);
            this.lblYazi.TabIndex = 1;
            // 
            // gb
            // 
            this.gb.Controls.Add(this.btnOk);
            this.gb.Controls.Add(this.lblYazi);
            this.gb.Location = new System.Drawing.Point(4, 2);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(231, 159);
            this.gb.TabIndex = 2;
            this.gb.TabStop = false;
            this.gb.Text = "İletişim Bilgileri";
            // 
            // frmİletisim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(237, 166);
            this.Controls.Add(this.gb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmİletisim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmİletisim";
            this.Load += new System.EventHandler(this.frmİletisim_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmİletisim_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmİletisim_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmİletisim_MouseUp);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblYazi;
        private System.Windows.Forms.GroupBox gb;
    }
}