namespace Sayac
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
            this.btnYap = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtBasla = new System.Windows.Forms.TextBox();
            this.txtBitis = new System.Windows.Forms.TextBox();
            this.lstSayac = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnYap
            // 
            this.btnYap.Location = new System.Drawing.Point(167, 113);
            this.btnYap.Name = "btnYap";
            this.btnYap.Size = new System.Drawing.Size(100, 32);
            this.btnYap.TabIndex = 0;
            this.btnYap.Text = "YAP!!!";
            this.btnYap.UseVisualStyleBackColor = true;
            this.btnYap.Click += new System.EventHandler(this.btnYap_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(108, 60);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(53, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Başlangıç";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(125, 94);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(26, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Bitiş";
            // 
            // txtBasla
            // 
            this.txtBasla.Location = new System.Drawing.Point(167, 57);
            this.txtBasla.Name = "txtBasla";
            this.txtBasla.Size = new System.Drawing.Size(100, 20);
            this.txtBasla.TabIndex = 3;
            // 
            // txtBitis
            // 
            this.txtBitis.Location = new System.Drawing.Point(167, 87);
            this.txtBitis.Name = "txtBitis";
            this.txtBitis.Size = new System.Drawing.Size(100, 20);
            this.txtBitis.TabIndex = 4;
            // 
            // lstSayac
            // 
            this.lstSayac.FormattingEnabled = true;
            this.lstSayac.Location = new System.Drawing.Point(332, 57);
            this.lstSayac.Name = "lstSayac";
            this.lstSayac.Size = new System.Drawing.Size(192, 251);
            this.lstSayac.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 362);
            this.Controls.Add(this.lstSayac);
            this.Controls.Add(this.txtBitis);
            this.Controls.Add(this.txtBasla);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnYap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYap;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtBasla;
        private System.Windows.Forms.TextBox txtBitis;
        private System.Windows.Forms.ListBox lstSayac;
    }
}

