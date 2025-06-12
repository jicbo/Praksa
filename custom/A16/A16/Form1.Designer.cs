
namespace A16
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kategorijaCB = new System.Windows.Forms.ComboBox();
            this.izlozbaCB = new System.Windows.Forms.ComboBox();
            this.pasCB = new System.Windows.Forms.ComboBox();
            this.izlazBTN1 = new System.Windows.Forms.Button();
            this.prijavaBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.izlazBTN3 = new System.Windows.Forms.Button();
            this.prikaziBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statistikaUcestvovaloLB = new System.Windows.Forms.Label();
            this.statistikaPrijavljenoLB = new System.Windows.Forms.Label();
            this.statistikaIzlozbaCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.izlazBTN2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(644, 348);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.kategorijaCB);
            this.tabPage1.Controls.Add(this.izlozbaCB);
            this.tabPage1.Controls.Add(this.pasCB);
            this.tabPage1.Controls.Add(this.izlazBTN1);
            this.tabPage1.Controls.Add(this.prijavaBTN);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(636, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Unesi prijavu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // kategorijaCB
            // 
            this.kategorijaCB.FormattingEnabled = true;
            this.kategorijaCB.Location = new System.Drawing.Point(50, 59);
            this.kategorijaCB.Name = "kategorijaCB";
            this.kategorijaCB.Size = new System.Drawing.Size(106, 21);
            this.kategorijaCB.TabIndex = 11;
            // 
            // izlozbaCB
            // 
            this.izlozbaCB.FormattingEnabled = true;
            this.izlozbaCB.Location = new System.Drawing.Point(50, 32);
            this.izlozbaCB.Name = "izlozbaCB";
            this.izlozbaCB.Size = new System.Drawing.Size(106, 21);
            this.izlozbaCB.TabIndex = 10;
            // 
            // pasCB
            // 
            this.pasCB.FormattingEnabled = true;
            this.pasCB.Location = new System.Drawing.Point(50, 6);
            this.pasCB.Name = "pasCB";
            this.pasCB.Size = new System.Drawing.Size(106, 21);
            this.pasCB.TabIndex = 9;
            // 
            // izlazBTN1
            // 
            this.izlazBTN1.Location = new System.Drawing.Point(126, 114);
            this.izlazBTN1.Name = "izlazBTN1";
            this.izlazBTN1.Size = new System.Drawing.Size(61, 56);
            this.izlazBTN1.TabIndex = 8;
            this.izlazBTN1.Text = "Izadji";
            this.izlazBTN1.UseVisualStyleBackColor = true;
            this.izlazBTN1.Click += new System.EventHandler(this.izlazBTN1_Click);
            // 
            // prijavaBTN
            // 
            this.prijavaBTN.Location = new System.Drawing.Point(12, 114);
            this.prijavaBTN.Name = "prijavaBTN";
            this.prijavaBTN.Size = new System.Drawing.Size(61, 56);
            this.prijavaBTN.TabIndex = 7;
            this.prijavaBTN.Text = "Prijava";
            this.prijavaBTN.UseVisualStyleBackColor = true;
            this.prijavaBTN.Click += new System.EventHandler(this.prijavaBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(249, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 161);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategorija:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Izlozba:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pas:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.izlazBTN3);
            this.tabPage2.Controls.Add(this.prikaziBTN);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Controls.Add(this.statistikaUcestvovaloLB);
            this.tabPage2.Controls.Add(this.statistikaPrijavljenoLB);
            this.tabPage2.Controls.Add(this.statistikaIzlozbaCB);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(636, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Statistika";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // izlazBTN3
            // 
            this.izlazBTN3.Location = new System.Drawing.Point(94, 283);
            this.izlazBTN3.Name = "izlazBTN3";
            this.izlazBTN3.Size = new System.Drawing.Size(75, 23);
            this.izlazBTN3.TabIndex = 14;
            this.izlazBTN3.Text = "Izadji";
            this.izlazBTN3.UseVisualStyleBackColor = true;
            this.izlazBTN3.Click += new System.EventHandler(this.izlazBTN3_Click);
            // 
            // prikaziBTN
            // 
            this.prikaziBTN.Location = new System.Drawing.Point(10, 283);
            this.prikaziBTN.Name = "prikaziBTN";
            this.prikaziBTN.Size = new System.Drawing.Size(75, 23);
            this.prikaziBTN.TabIndex = 13;
            this.prikaziBTN.Text = "Prikazi";
            this.prikaziBTN.UseVisualStyleBackColor = true;
            this.prikaziBTN.Click += new System.EventHandler(this.prikaziBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(251, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 300);
            this.dataGridView1.TabIndex = 12;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(10, 97);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "rezultat";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(235, 163);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // statistikaUcestvovaloLB
            // 
            this.statistikaUcestvovaloLB.AutoSize = true;
            this.statistikaUcestvovaloLB.Location = new System.Drawing.Point(181, 67);
            this.statistikaUcestvovaloLB.Name = "statistikaUcestvovaloLB";
            this.statistikaUcestvovaloLB.Size = new System.Drawing.Size(13, 13);
            this.statistikaUcestvovaloLB.TabIndex = 10;
            this.statistikaUcestvovaloLB.Text = "0";
            // 
            // statistikaPrijavljenoLB
            // 
            this.statistikaPrijavljenoLB.AutoSize = true;
            this.statistikaPrijavljenoLB.Location = new System.Drawing.Point(181, 41);
            this.statistikaPrijavljenoLB.Name = "statistikaPrijavljenoLB";
            this.statistikaPrijavljenoLB.Size = new System.Drawing.Size(13, 13);
            this.statistikaPrijavljenoLB.TabIndex = 9;
            this.statistikaPrijavljenoLB.Text = "0";
            // 
            // statistikaIzlozbaCB
            // 
            this.statistikaIzlozbaCB.FormattingEnabled = true;
            this.statistikaIzlozbaCB.Location = new System.Drawing.Point(48, 12);
            this.statistikaIzlozbaCB.Name = "statistikaIzlozbaCB";
            this.statistikaIzlozbaCB.Size = new System.Drawing.Size(121, 21);
            this.statistikaIzlozbaCB.TabIndex = 8;
            this.statistikaIzlozbaCB.SelectedIndexChanged += new System.EventHandler(this.statistikaIzlozbaCB_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ukupan broj pasa koji se takmicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ukupan broj pasa koji je prijavljen:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Izlozba:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(636, 322);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "O aplikaciji";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(326, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "U tabu \"Statistika\" mozete videti podatke o svakoj izlozbi ponaosob";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(163, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(281, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "U tabu \"Unesi prijavu\" mozete prijaviti spa za neku izlozbu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Zadatak A16 - Izlozba pasa";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.izlazBTN2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(636, 322);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Izlaz";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // izlazBTN2
            // 
            this.izlazBTN2.Location = new System.Drawing.Point(270, 123);
            this.izlazBTN2.Name = "izlazBTN2";
            this.izlazBTN2.Size = new System.Drawing.Size(75, 72);
            this.izlazBTN2.TabIndex = 0;
            this.izlazBTN2.Text = "Izadji";
            this.izlazBTN2.UseVisualStyleBackColor = true;
            this.izlazBTN2.Click += new System.EventHandler(this.izlazBTN2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 341);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "A16 Izlozba pasa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox kategorijaCB;
        private System.Windows.Forms.ComboBox izlozbaCB;
        private System.Windows.Forms.ComboBox pasCB;
        private System.Windows.Forms.Button izlazBTN1;
        private System.Windows.Forms.Button prijavaBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button izlazBTN3;
        private System.Windows.Forms.Button prikaziBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label statistikaUcestvovaloLB;
        private System.Windows.Forms.Label statistikaPrijavljenoLB;
        private System.Windows.Forms.ComboBox statistikaIzlozbaCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button izlazBTN2;
    }
}

