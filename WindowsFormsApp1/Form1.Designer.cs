
namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DonörOlmaButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DonörFormu = new System.Windows.Forms.TabPage();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.UR = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.Donörs = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.AdSoya = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bloodt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Emai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.İlçesi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.DonörFormu.SuspendLayout();
            this.UR.SuspendLayout();
            this.Donörs.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad-Soyad";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kan Grubu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rh Faktörü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "E-Mail";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(48, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 20);
            this.textBox2.TabIndex = 7;
            // 
            // DonörOlmaButton
            // 
            this.DonörOlmaButton.Location = new System.Drawing.Point(339, 253);
            this.DonörOlmaButton.Name = "DonörOlmaButton";
            this.DonörOlmaButton.Size = new System.Drawing.Size(75, 23);
            this.DonörOlmaButton.TabIndex = 8;
            this.DonörOlmaButton.Text = "Donör Ol";
            this.DonörOlmaButton.UseVisualStyleBackColor = true;
            this.DonörOlmaButton.Click += new System.EventHandler(this.DonörOlmaButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(10, 253);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(183, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Acil İhtiyaçlardanbeni haberdar et";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DonörFormu);
            this.tabControl1.Controls.Add(this.UR);
            this.tabControl1.Controls.Add(this.Donörs);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(595, 617);
            this.tabControl1.TabIndex = 10;
            // 
            // DonörFormu
            // 
            this.DonörFormu.Controls.Add(this.checkBox3);
            this.DonörFormu.Controls.Add(this.checkBox2);
            this.DonörFormu.Controls.Add(this.comboBox2);
            this.DonörFormu.Controls.Add(this.comboBox1);
            this.DonörFormu.Controls.Add(this.label9);
            this.DonörFormu.Controls.Add(this.comboBox6);
            this.DonörFormu.Controls.Add(this.textBox1);
            this.DonörFormu.Controls.Add(this.DonörOlmaButton);
            this.DonörFormu.Controls.Add(this.checkBox1);
            this.DonörFormu.Controls.Add(this.label1);
            this.DonörFormu.Controls.Add(this.label2);
            this.DonörFormu.Controls.Add(this.textBox2);
            this.DonörFormu.Controls.Add(this.label4);
            this.DonörFormu.Controls.Add(this.label3);
            this.DonörFormu.Location = new System.Drawing.Point(4, 22);
            this.DonörFormu.Name = "DonörFormu";
            this.DonörFormu.Padding = new System.Windows.Forms.Padding(3);
            this.DonörFormu.Size = new System.Drawing.Size(587, 591);
            this.DonörFormu.TabIndex = 0;
            this.DonörFormu.Text = "Donörlük Formu";
            this.DonörFormu.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(297, 60);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(135, 17);
            this.checkBox3.TabIndex = 15;
            this.checkBox3.Text = "Bulaşıcı Hastalığım Yok";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(297, 24);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(130, 17);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "18 Yaşndan Büyüğüm";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Rh(-)",
            "Rh(+)"});
            this.comboBox2.Location = new System.Drawing.Point(73, 102);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AB",
            "A",
            "B",
            "O"});
            this.comboBox1.Location = new System.Drawing.Point(73, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "İlçeler";
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(48, 192);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(183, 21);
            this.comboBox6.TabIndex = 10;
            // 
            // UR
            // 
            this.UR.Controls.Add(this.label5);
            this.UR.Controls.Add(this.comboBox7);
            this.UR.Controls.Add(this.button1);
            this.UR.Controls.Add(this.comboBox5);
            this.UR.Controls.Add(this.label8);
            this.UR.Controls.Add(this.comboBox4);
            this.UR.Controls.Add(this.label7);
            this.UR.Controls.Add(this.label6);
            this.UR.Controls.Add(this.comboBox3);
            this.UR.Location = new System.Drawing.Point(4, 22);
            this.UR.Name = "UR";
            this.UR.Padding = new System.Windows.Forms.Padding(3);
            this.UR.Size = new System.Drawing.Size(587, 591);
            this.UR.TabIndex = 1;
            this.UR.Text = "Acil İhtiyaç";
            this.UR.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hastane";
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(79, 96);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(348, 21);
            this.comboBox7.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Acil İstek";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Acilbutton);
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Rh(-)",
            "Rh(+)"});
            this.comboBox5.Location = new System.Drawing.Point(125, 211);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Rh Faktörü";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "AB",
            "A",
            "B",
            "O"});
            this.comboBox4.Location = new System.Drawing.Point(125, 164);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Kan Grubu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "İlçe";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(75, 46);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 0;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // Donörs
            // 
            this.Donörs.Controls.Add(this.listView1);
            this.Donörs.Location = new System.Drawing.Point(4, 22);
            this.Donörs.Name = "Donörs";
            this.Donörs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Donörs.Size = new System.Drawing.Size(587, 591);
            this.Donörs.TabIndex = 2;
            this.Donörs.Text = "Donörler";
            this.Donörs.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AdSoya,
            this.Bloodt,
            this.Emai,
            this.İlçesi});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 7);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(575, 573);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // AdSoya
            // 
            this.AdSoya.Text = "Ad Soyad";
            this.AdSoya.Width = 114;
            // 
            // Bloodt
            // 
            this.Bloodt.Text = "Kan Grubu";
            this.Bloodt.Width = 117;
            // 
            // Emai
            // 
            this.Emai.Text = "E-Mail";
            this.Emai.Width = 183;
            // 
            // İlçesi
            // 
            this.İlçesi.Text = "İlçe";
            this.İlçesi.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 630);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.DonörFormu.ResumeLayout(false);
            this.DonörFormu.PerformLayout();
            this.UR.ResumeLayout(false);
            this.UR.PerformLayout();
            this.Donörs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button DonörOlmaButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DonörFormu;
        private System.Windows.Forms.TabPage UR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TabPage Donörs;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader AdSoya;
        private System.Windows.Forms.ColumnHeader Bloodt;
        private System.Windows.Forms.ColumnHeader Emai;
        private System.Windows.Forms.ColumnHeader İlçesi;
    }
}

