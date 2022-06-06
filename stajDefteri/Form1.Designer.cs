namespace stajDefteri
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.darkModecbox = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDate = new System.Windows.Forms.DateTimePicker();
            this.tbJobText = new System.Windows.Forms.TextBox();
            this.tbSummary = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ekle.png");
            this.ımageList1.Images.SetKeyName(1, "cıkar.png");
            this.ımageList1.Images.SetKeyName(2, "cıkar2.png");
            this.ımageList1.Images.SetKeyName(3, "cıkar3.png");
            this.ımageList1.Images.SetKeyName(4, "cıkar4.png");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.darkModecbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1200, 631);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ayarlar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // darkModecbox
            // 
            this.darkModecbox.AutoSize = true;
            this.darkModecbox.Location = new System.Drawing.Point(252, 7);
            this.darkModecbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.darkModecbox.Name = "darkModecbox";
            this.darkModecbox.Size = new System.Drawing.Size(96, 20);
            this.darkModecbox.TabIndex = 0;
            this.darkModecbox.Text = "Dark Mode";
            this.darkModecbox.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.dateDate);
            this.tabPage3.Controls.Add(this.tbJobText);
            this.tabPage3.Controls.Add(this.tbSummary);
            this.tabPage3.Controls.Add(this.tbTitle);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.tabPage3.Size = new System.Drawing.Size(1200, 631);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DEFTER";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 191);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 153);
            this.textBox1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tarih";
            // 
            // dateDate
            // 
            this.dateDate.Location = new System.Drawing.Point(192, 119);
            this.dateDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDate.Name = "dateDate";
            this.dateDate.Size = new System.Drawing.Size(235, 22);
            this.dateDate.TabIndex = 18;
            // 
            // tbJobText
            // 
            this.tbJobText.BackColor = System.Drawing.Color.White;
            this.tbJobText.Location = new System.Drawing.Point(645, 177);
            this.tbJobText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbJobText.Multiline = true;
            this.tbJobText.Name = "tbJobText";
            this.tbJobText.Size = new System.Drawing.Size(540, 440);
            this.tbJobText.TabIndex = 7;
            this.tbJobText.Text = "YAPILAN İŞ";
            // 
            // tbSummary
            // 
            this.tbSummary.BackColor = System.Drawing.Color.White;
            this.tbSummary.Location = new System.Drawing.Point(916, 23);
            this.tbSummary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSummary.Multiline = true;
            this.tbSummary.Name = "tbSummary";
            this.tbSummary.Size = new System.Drawing.Size(269, 146);
            this.tbSummary.TabIndex = 7;
            this.tbSummary.Text = "ÖZET";
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.Color.RosyBrown;
            this.tbTitle.Location = new System.Drawing.Point(643, 23);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTitle.Multiline = true;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(264, 146);
            this.tbTitle.TabIndex = 6;
            this.tbTitle.Text = "BAŞLIK";
            // 
            // button5
            // 
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.ImageIndex = 4;
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(315, 23);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(13, 0, 16, 0);
            this.button5.Size = new System.Drawing.Size(115, 33);
            this.button5.TabIndex = 2;
            this.button5.Text = "Çıkar ";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.ImageKey = "ekle.png";
            this.button3.Location = new System.Drawing.Point(193, 64);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.button3.Size = new System.Drawing.Size(236, 33);
            this.button3.TabIndex = 1;
            this.button3.Text = "DÜZENLE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.ImageKey = "ekle.png";
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(193, 23);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.button4.Size = new System.Drawing.Size(115, 33);
            this.button4.TabIndex = 1;
            this.button4.Text = "    Ekle";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(185, 628);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Günler";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(437, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 628);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1208, 660);
            this.tabControl1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 661);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "torostaj";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox darkModecbox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateDate;
        private System.Windows.Forms.TextBox tbJobText;
        private System.Windows.Forms.TextBox tbSummary;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

