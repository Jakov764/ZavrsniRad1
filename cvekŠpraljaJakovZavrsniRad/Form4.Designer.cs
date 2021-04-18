namespace cvekŠpraljaJakovZavrsniRad
{
    partial class Form4
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
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.Color.LightBlue;
            this.btnZatvori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZatvori.Font = new System.Drawing.Font("Noto Mono", 10F);
            this.btnZatvori.Location = new System.Drawing.Point(320, 160);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(92, 75);
            this.btnZatvori.TabIndex = 8;
            this.btnZatvori.Text = "Odustani";
            this.btnZatvori.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.LightBlue;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Noto Mono", 10F);
            this.btnPrint.Location = new System.Drawing.Point(320, 50);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(92, 75);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Ispiši i Zatvori";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(18, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(282, 384);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(425, 408);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}