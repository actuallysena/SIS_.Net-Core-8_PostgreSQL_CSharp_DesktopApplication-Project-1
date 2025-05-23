namespace PresentationLayer
{
    partial class DersEkleUserControl
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            kaydetbutton = new Button();
            label1 = new Label();
            dersAdıtextBox = new TextBox();
            kontenjanlabel = new Label();
            kontenjanTextBox = new TextBox();
            dersverenlabel = new Label();
            ogretimElemaniTextBox = new TextBox();
            dersliklabel = new Label();
            derslikTextBox = new TextBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            dersKoduTextBox = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // kaydetbutton
            // 
            kaydetbutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kaydetbutton.ForeColor = SystemColors.InactiveCaptionText;
            kaydetbutton.Location = new Point(187, 300);
            kaydetbutton.MinimumSize = new Size(1, 1);
            kaydetbutton.Name = "kaydetbutton";
            kaydetbutton.Size = new Size(118, 42);
            kaydetbutton.TabIndex = 0;
            kaydetbutton.Text = "Kaydet";
            kaydetbutton.UseVisualStyleBackColor = false;
            kaydetbutton.Click += kaydetbutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(89, 76);
            label1.Name = "label1";
            label1.Size = new Size(74, 23);
            label1.TabIndex = 1;
            label1.Text = "Ders Adı";
            // 
            // dersAdıtextBox
            // 
            dersAdıtextBox.Font = new Font("Segoe UI", 10.2F);
            dersAdıtextBox.Location = new Point(291, 69);
            dersAdıtextBox.Name = "dersAdıtextBox";
            dersAdıtextBox.Size = new Size(125, 30);
            dersAdıtextBox.TabIndex = 2;
            // 
            // kontenjanlabel
            // 
            kontenjanlabel.AutoSize = true;
            kontenjanlabel.Font = new Font("Segoe UI", 10.2F);
            kontenjanlabel.Location = new Point(89, 129);
            kontenjanlabel.Name = "kontenjanlabel";
            kontenjanlabel.Size = new Size(93, 23);
            kontenjanlabel.TabIndex = 3;
            kontenjanlabel.Text = "Kontenjan ";
            // 
            // kontenjanTextBox
            // 
            kontenjanTextBox.Font = new Font("Segoe UI", 10.2F);
            kontenjanTextBox.Location = new Point(291, 122);
            kontenjanTextBox.Name = "kontenjanTextBox";
            kontenjanTextBox.Size = new Size(125, 30);
            kontenjanTextBox.TabIndex = 4;
            // 
            // dersverenlabel
            // 
            dersverenlabel.AutoSize = true;
            dersverenlabel.Font = new Font("Segoe UI", 10.2F);
            dersverenlabel.Location = new Point(89, 182);
            dersverenlabel.Name = "dersverenlabel";
            dersverenlabel.Size = new Size(138, 23);
            dersverenlabel.TabIndex = 5;
            dersverenlabel.Text = "Öğretim Elemanı";
            // 
            // ogretimElemaniTextBox
            // 
            ogretimElemaniTextBox.Font = new Font("Segoe UI", 10.2F);
            ogretimElemaniTextBox.Location = new Point(291, 175);
            ogretimElemaniTextBox.Name = "ogretimElemaniTextBox";
            ogretimElemaniTextBox.Size = new Size(125, 30);
            ogretimElemaniTextBox.TabIndex = 6;
            // 
            // dersliklabel
            // 
            dersliklabel.AutoSize = true;
            dersliklabel.Font = new Font("Segoe UI", 10.2F);
            dersliklabel.Location = new Point(89, 234);
            dersliklabel.Name = "dersliklabel";
            dersliklabel.Size = new Size(60, 23);
            dersliklabel.TabIndex = 7;
            dersliklabel.Text = "Derslik";
            // 
            // derslikTextBox
            // 
            derslikTextBox.Font = new Font("Segoe UI", 10.2F);
            derslikTextBox.Location = new Point(291, 227);
            derslikTextBox.Name = "derslikTextBox";
            derslikTextBox.Size = new Size(125, 30);
            derslikTextBox.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dersKoduTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dersAdıtextBox);
            groupBox1.Controls.Add(derslikTextBox);
            groupBox1.Controls.Add(kaydetbutton);
            groupBox1.Controls.Add(dersliklabel);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ogretimElemaniTextBox);
            groupBox1.Controls.Add(kontenjanlabel);
            groupBox1.Controls.Add(dersverenlabel);
            groupBox1.Controls.Add(kontenjanTextBox);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(30, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(591, 348);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ders Ekle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(89, 26);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 9;
            label2.Text = "Ders Kodu";
            // 
            // dersKoduTextBox
            // 
            dersKoduTextBox.Font = new Font("Segoe UI", 10.2F);
            dersKoduTextBox.Location = new Point(291, 19);
            dersKoduTextBox.Name = "dersKoduTextBox";
            dersKoduTextBox.Size = new Size(125, 30);
            dersKoduTextBox.TabIndex = 10;
            // 
            // DersEkleUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "DersEkleUserControl";
            Size = new Size(675, 393);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button kaydetbutton;
        private Label label1;
        private TextBox dersAdıtextBox;
        private Label kontenjanlabel;
        private TextBox kontenjanTextBox;
        private Label dersverenlabel;
        private TextBox ogretimElemaniTextBox;
        private Label dersliklabel;
        private TextBox derslikTextBox;
        private GroupBox groupBox1;
        private TextBox dersKoduTextBox;
        private Label label2;
    }
}
