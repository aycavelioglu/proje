namespace proje_aramamotoru
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
            this.arama = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.aranacak_kelime = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.RadioButton();
            this.pdf = new System.Windows.Forms.RadioButton();
            this.html = new System.Windows.Forms.RadioButton();
            this.docx = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // arama
            // 
            this.arama.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.arama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.arama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arama.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.arama.Location = new System.Drawing.Point(482, 54);
            this.arama.Name = "arama";
            this.arama.Size = new System.Drawing.Size(146, 40);
            this.arama.TabIndex = 0;
            this.arama.Text = "Search";
            this.arama.UseVisualStyleBackColor = false;
            this.arama.Click += new System.EventHandler(this.arama_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dosya Türünü Seçiniz";
            // 
            // aranacak_kelime
            // 
            this.aranacak_kelime.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.aranacak_kelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aranacak_kelime.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.aranacak_kelime.Location = new System.Drawing.Point(145, 54);
            this.aranacak_kelime.Multiline = true;
            this.aranacak_kelime.Name = "aranacak_kelime";
            this.aranacak_kelime.Size = new System.Drawing.Size(331, 40);
            this.aranacak_kelime.TabIndex = 6;
            this.aranacak_kelime.Text = "Aranacak Kelimeyi Giriniz...";
            this.aranacak_kelime.Click += new System.EventHandler(this.aranacak_kelime_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(145, 141);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(331, 154);
            this.listBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(142, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bunu Mu Demek İstediniz?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(13, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Çalışma Hızı:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt.Location = new System.Drawing.Point(16, 44);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(44, 19);
            this.txt.TabIndex = 10;
            this.txt.TabStop = true;
            this.txt.Text = "Txt";
            this.txt.UseVisualStyleBackColor = true;
            this.txt.CheckedChanged += new System.EventHandler(this.text_CheckedChanged);
            // 
            // pdf
            // 
            this.pdf.AutoSize = true;
            this.pdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pdf.ForeColor = System.Drawing.SystemColors.GrayText;
            this.pdf.Location = new System.Drawing.Point(16, 67);
            this.pdf.Name = "pdf";
            this.pdf.Size = new System.Drawing.Size(46, 19);
            this.pdf.TabIndex = 11;
            this.pdf.TabStop = true;
            this.pdf.Text = "Pdf";
            this.pdf.UseVisualStyleBackColor = true;
            this.pdf.CheckedChanged += new System.EventHandler(this.pdf_CheckedChanged);
            // 
            // html
            // 
            this.html.AutoSize = true;
            this.html.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.html.ForeColor = System.Drawing.SystemColors.GrayText;
            this.html.Location = new System.Drawing.Point(16, 91);
            this.html.Name = "html";
            this.html.Size = new System.Drawing.Size(55, 19);
            this.html.TabIndex = 12;
            this.html.TabStop = true;
            this.html.Text = "Html";
            this.html.UseVisualStyleBackColor = true;
            // 
            // docx
            // 
            this.docx.AutoSize = true;
            this.docx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.docx.ForeColor = System.Drawing.SystemColors.GrayText;
            this.docx.Location = new System.Drawing.Point(16, 115);
            this.docx.Name = "docx";
            this.docx.Size = new System.Drawing.Size(57, 19);
            this.docx.TabIndex = 13;
            this.docx.TabStop = true;
            this.docx.Text = "Docx";
            this.docx.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 307);
            this.Controls.Add(this.docx);
            this.Controls.Add(this.html);
            this.Controls.Add(this.pdf);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.aranacak_kelime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button arama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aranacak_kelime;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton txt;
        private System.Windows.Forms.RadioButton pdf;
        private System.Windows.Forms.RadioButton html;
        private System.Windows.Forms.RadioButton docx;
    }
}

