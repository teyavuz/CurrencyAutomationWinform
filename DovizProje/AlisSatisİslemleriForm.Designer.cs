
namespace DovizProje
{
    partial class AlisSatisİslemleriForm
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
            this.lwMusteri = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmbİslem = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lwEnvanter = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lwDoviz = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwVezne = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwAlisSatis = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lwMusteri
            // 
            this.lwMusteri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lwMusteri.HideSelection = false;
            this.lwMusteri.Location = new System.Drawing.Point(21, 123);
            this.lwMusteri.Name = "lwMusteri";
            this.lwMusteri.Size = new System.Drawing.Size(298, 143);
            this.lwMusteri.TabIndex = 25;
            this.lwMusteri.UseCompatibleStateImageBehavior = false;
            this.lwMusteri.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Müşteri ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad/Ünvan";
            this.columnHeader2.Width = 103;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad/Ünvan Devam";
            this.columnHeader3.Width = 129;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(811, 239);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(113, 27);
            this.btnKaydet.TabIndex = 24;
            this.btnKaydet.Text = "İşlemi Gerçekleştir";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbİslem
            // 
            this.cmbİslem.FormattingEnabled = true;
            this.cmbİslem.Items.AddRange(new object[] {
            "Alış",
            "Satış"});
            this.cmbİslem.Location = new System.Drawing.Point(335, 123);
            this.cmbİslem.Name = "cmbİslem";
            this.cmbİslem.Size = new System.Drawing.Size(111, 21);
            this.cmbİslem.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Müşteri Seçimi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 54);
            this.label1.TabIndex = 15;
            this.label1.Text = "Alış Satış İşlemleri";
            // 
            // lwEnvanter
            // 
            this.lwEnvanter.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lwEnvanter.HideSelection = false;
            this.lwEnvanter.Location = new System.Drawing.Point(21, 293);
            this.lwEnvanter.Name = "lwEnvanter";
            this.lwEnvanter.Size = new System.Drawing.Size(298, 264);
            this.lwEnvanter.TabIndex = 26;
            this.lwEnvanter.UseCompatibleStateImageBehavior = false;
            this.lwEnvanter.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Envanter ID";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Döviz";
            this.columnHeader5.Width = 103;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Sahip Olunan Miktar";
            this.columnHeader6.Width = 121;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Alış/Satış:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Döviz:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(615, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Miktar:";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(618, 123);
            this.txtMiktar.Mask = "0000.000";
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(110, 20);
            this.txtMiktar.TabIndex = 28;
            this.txtMiktar.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(760, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Vezne:";
            // 
            // lwDoviz
            // 
            this.lwDoviz.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.lwDoviz.HideSelection = false;
            this.lwDoviz.Location = new System.Drawing.Point(476, 123);
            this.lwDoviz.Name = "lwDoviz";
            this.lwDoviz.Size = new System.Drawing.Size(136, 143);
            this.lwDoviz.TabIndex = 25;
            this.lwDoviz.UseCompatibleStateImageBehavior = false;
            this.lwDoviz.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "DövizID";
            this.columnHeader7.Width = 50;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Döviz";
            this.columnHeader8.Width = 82;
            // 
            // lwVezne
            // 
            this.lwVezne.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.lwVezne.HideSelection = false;
            this.lwVezne.Location = new System.Drawing.Point(763, 123);
            this.lwVezne.Name = "lwVezne";
            this.lwVezne.Size = new System.Drawing.Size(161, 110);
            this.lwVezne.TabIndex = 25;
            this.lwVezne.UseCompatibleStateImageBehavior = false;
            this.lwVezne.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "VezneID";
            this.columnHeader9.Width = 53;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Vezne";
            this.columnHeader10.Width = 77;
            // 
            // lwAlisSatis
            // 
            this.lwAlisSatis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17});
            this.lwAlisSatis.HideSelection = false;
            this.lwAlisSatis.Location = new System.Drawing.Point(345, 293);
            this.lwAlisSatis.Name = "lwAlisSatis";
            this.lwAlisSatis.Size = new System.Drawing.Size(579, 264);
            this.lwAlisSatis.TabIndex = 29;
            this.lwAlisSatis.UseCompatibleStateImageBehavior = false;
            this.lwAlisSatis.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "İşlem ID";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Müşteri";
            this.columnHeader12.Width = 191;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "İşlem Tipi";
            this.columnHeader13.Width = 77;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Döviz";
            this.columnHeader14.Width = 72;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Miktar";
            this.columnHeader15.Width = 87;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Vezne";
            this.columnHeader16.Width = 85;
            // 
            // AlisSatisİslemleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 594);
            this.Controls.Add(this.lwAlisSatis);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.lwEnvanter);
            this.Controls.Add(this.lwVezne);
            this.Controls.Add(this.lwDoviz);
            this.Controls.Add(this.lwMusteri);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cmbİslem);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AlisSatisİslemleriForm";
            this.Text = "AlisSatisİslemleriForm";
            this.Load += new System.EventHandler(this.AlisSatisİslemleriForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lwMusteri;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cmbİslem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lwEnvanter;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtMiktar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lwDoviz;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView lwVezne;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ListView lwAlisSatis;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
    }
}