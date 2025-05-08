using BusinessLogicLayer;

namespace PresentationLayer
{
    partial class Form2
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
            ogr_radioB = new RadioButton();
            aka_radioB = new RadioButton();
            per_radioB = new RadioButton();
            it_radioB = new RadioButton();
            girisbtn = new Button();
            girisIdText = new TextBox();
            sifreText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // ogr_radioB
            // 
            ogr_radioB.AutoSize = true;
            ogr_radioB.Location = new Point(8, 32);
            ogr_radioB.Margin = new Padding(4);
            ogr_radioB.Name = "ogr_radioB";
            ogr_radioB.Size = new Size(79, 24);
            ogr_radioB.TabIndex = 0;
            ogr_radioB.TabStop = true;
            ogr_radioB.Text = "Öğrenci";
            ogr_radioB.UseVisualStyleBackColor = true;
            // 
            // aka_radioB
            // 
            aka_radioB.AutoSize = true;
            aka_radioB.Location = new Point(131, 32);
            aka_radioB.Margin = new Padding(4);
            aka_radioB.Name = "aka_radioB";
            aka_radioB.Size = new Size(115, 24);
            aka_radioB.TabIndex = 1;
            aka_radioB.TabStop = true;
            aka_radioB.Text = "Akademisyen";
            aka_radioB.UseVisualStyleBackColor = true;
            // 
            // per_radioB
            // 
            per_radioB.AutoSize = true;
            per_radioB.Location = new Point(311, 32);
            per_radioB.Margin = new Padding(4);
            per_radioB.Name = "per_radioB";
            per_radioB.Size = new Size(82, 24);
            per_radioB.TabIndex = 2;
            per_radioB.TabStop = true;
            per_radioB.Text = "Personel";
            per_radioB.UseVisualStyleBackColor = true;
            // 
            // it_radioB
            // 
            it_radioB.AutoSize = true;
            it_radioB.Location = new Point(445, 32);
            it_radioB.Margin = new Padding(4);
            it_radioB.Name = "it_radioB";
            it_radioB.Size = new Size(96, 24);
            it_radioB.TabIndex = 3;
            it_radioB.TabStop = true;
            it_radioB.Text = "Bilgi İşlem";
            it_radioB.UseVisualStyleBackColor = true;
            // 
            // girisbtn
            // 
            girisbtn.Location = new Point(120, 182);
            girisbtn.Margin = new Padding(4);
            girisbtn.Name = "girisbtn";
            girisbtn.Size = new Size(118, 36);
            girisbtn.TabIndex = 4;
            girisbtn.Text = "Giriş";
            girisbtn.UseVisualStyleBackColor = true;
            girisbtn.Click += girisbtn_Click;
            // 
            // girisIdText
            // 
            girisIdText.Location = new Point(144, 49);
            girisIdText.Margin = new Padding(4);
            girisIdText.Name = "girisIdText";
            girisIdText.Size = new Size(155, 27);
            girisIdText.TabIndex = 5;
            // 
            // sifreText
            // 
            sifreText.Location = new Point(144, 121);
            sifreText.Margin = new Padding(4);
            sifreText.Name = "sifreText";
            sifreText.Size = new Size(155, 27);
            sifreText.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 130);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 7;
            label1.Text = "Şifre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 52);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 8;
            label2.Text = "Giriş Id";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(girisIdText);
            groupBox1.Controls.Add(girisbtn);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(sifreText);
            groupBox1.Location = new Point(387, 214);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(356, 235);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.CausesValidation = false;
            groupBox2.Controls.Add(ogr_radioB);
            groupBox2.Controls.Add(aka_radioB);
            groupBox2.Controls.Add(it_radioB);
            groupBox2.Controls.Add(per_radioB);
            groupBox2.Location = new Point(267, 107);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(594, 79);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Segoe MDL2 Assets", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(478, 42);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 0, 0, 12);
            label3.Size = new Size(165, 41);
            label3.TabIndex = 11;
            label3.Text = "PORTAL GİRİŞ";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 514);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form2";
            Text = "Giriş Ekranı";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton ogr_radioB;
        private RadioButton aka_radioB;
        private RadioButton per_radioB;
        private RadioButton it_radioB;
        private Button girisbtn;
        private TextBox girisIdText;
        private TextBox sifreText;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        internal GroupBox groupBox2;
    }
}