namespace PresentationLayer
{
    partial class NotGirmeUserControl
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
            kaydetButton = new Button();
            groupBox1 = new GroupBox();
            notTextBox = new TextBox();
            label3 = new Label();
            ogrenciNoTextBox = new TextBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // kaydetButton
            // 
            kaydetButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kaydetButton.Location = new Point(125, 256);
            kaydetButton.Name = "kaydetButton";
            kaydetButton.Size = new Size(102, 36);
            kaydetButton.TabIndex = 0;
            kaydetButton.Text = "Kaydet";
            kaydetButton.UseVisualStyleBackColor = true;
            kaydetButton.Click += kaydetButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(notTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(ogrenciNoTextBox);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(kaydetButton);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(60, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(408, 387);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Not Girme";
            // 
            // notTextBox
            // 
            notTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            notTextBox.Location = new Point(186, 172);
            notTextBox.Name = "notTextBox";
            notTextBox.Size = new Size(151, 30);
            notTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(38, 179);
            label3.Name = "label3";
            label3.Size = new Size(39, 23);
            label3.TabIndex = 6;
            label3.Text = "Not";
            // 
            // ogrenciNoTextBox
            // 
            ogrenciNoTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ogrenciNoTextBox.Location = new Point(186, 118);
            ogrenciNoTextBox.Name = "ogrenciNoTextBox";
            ogrenciNoTextBox.Size = new Size(151, 30);
            ogrenciNoTextBox.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "A", "A", "A" });
            comboBox1.Location = new Point(186, 64);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 31);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "Ders Seçiniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(38, 125);
            label2.Name = "label2";
            label2.Size = new Size(98, 23);
            label2.TabIndex = 3;
            label2.Text = "Öğrenci No";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(38, 72);
            label1.Name = "label1";
            label1.Size = new Size(74, 23);
            label1.TabIndex = 2;
            label1.Text = "Ders Adı";
            // 
            // NotGirmeUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "NotGirmeUserControl";
            Size = new Size(675, 393);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button kaydetButton;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox ogrenciNoTextBox;
        private ComboBox comboBox1;
        private TextBox notTextBox;
        private Label label3;
    }
}
