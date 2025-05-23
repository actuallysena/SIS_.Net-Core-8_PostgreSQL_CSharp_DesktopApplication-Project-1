namespace PresentationLayer
{
    partial class OgrenciListeleUserControl
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
            dataGridView = new DataGridView();
            groupBox1 = new GroupBox();
            sınıfComboBox = new ComboBox();
            label1 = new Label();
            sorgulaButton = new Button();
            label2 = new Label();
            dersComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(42, 83);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(561, 281);
            dataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dersComboBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(sınıfComboBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(sorgulaButton);
            groupBox1.Controls.Add(dataGridView);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(669, 370);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Listele";
            // 
            // sınıfComboBox
            // 
            sınıfComboBox.Font = new Font("Segoe UI", 10.2F);
            sınıfComboBox.FormattingEnabled = true;
            sınıfComboBox.Items.AddRange(new object[] { "1", "2", "3", "4" });
            sınıfComboBox.Location = new Point(83, 33);
            sınıfComboBox.Name = "sınıfComboBox";
            sınıfComboBox.Size = new Size(151, 31);
            sınıfComboBox.TabIndex = 3;
            sınıfComboBox.Text = "Sınıf Seçiniz";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(15, 33);
            label1.Name = "label1";
            label1.Size = new Size(46, 25);
            label1.TabIndex = 2;
            label1.Text = "Sınıf";
            // 
            // sorgulaButton
            // 
            sorgulaButton.Font = new Font("Segoe UI", 10.2F);
            sorgulaButton.Location = new Point(530, 25);
            sorgulaButton.Name = "sorgulaButton";
            sorgulaButton.Size = new Size(94, 39);
            sorgulaButton.TabIndex = 1;
            sorgulaButton.Text = "Sorgula";
            sorgulaButton.UseVisualStyleBackColor = true;
            sorgulaButton.Click += sorgulaButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(291, 33);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 4;
            label2.Text = "Ders";
            // 
            // dersComboBox
            // 
            dersComboBox.Font = new Font("Segoe UI", 10.2F);
            dersComboBox.FormattingEnabled = true;
            dersComboBox.Location = new Point(359, 32);
            dersComboBox.Name = "dersComboBox";
            dersComboBox.Size = new Size(151, 31);
            dersComboBox.TabIndex = 5;
            dersComboBox.Tag = "";
            // 
            // OgrenciListeleUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "OgrenciListeleUserControl";
            Size = new Size(675, 393);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private GroupBox groupBox1;
        private Button sorgulaButton;
        private ComboBox sınıfComboBox;
        private Label label1;
        private ComboBox dersComboBox;
        private Label label2;
    }
}
