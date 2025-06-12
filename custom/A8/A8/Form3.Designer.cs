namespace A8
{
    partial class Form3
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.prikaziButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.godinaLabel = new System.Windows.Forms.Label();
            this.otkricaLabel = new System.Windows.Forms.Label();
            this.godinaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.otkricaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.godinaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otkricaNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(451, 59);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // prikaziButton
            // 
            this.prikaziButton.Location = new System.Drawing.Point(57, 328);
            this.prikaziButton.Name = "prikaziButton";
            this.prikaziButton.Size = new System.Drawing.Size(240, 30);
            this.prikaziButton.TabIndex = 1;
            this.prikaziButton.Text = "Prikazi";
            this.prikaziButton.UseVisualStyleBackColor = true;
            this.prikaziButton.Click += new System.EventHandler(this.prikaziButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 207);
            this.dataGridView1.TabIndex = 2;
            // 
            // godinaLabel
            // 
            this.godinaLabel.AutoSize = true;
            this.godinaLabel.Location = new System.Drawing.Point(57, 59);
            this.godinaLabel.Name = "godinaLabel";
            this.godinaLabel.Size = new System.Drawing.Size(41, 13);
            this.godinaLabel.TabIndex = 3;
            this.godinaLabel.Text = "Godina";
            // 
            // otkricaLabel
            // 
            this.otkricaLabel.AutoSize = true;
            this.otkricaLabel.Location = new System.Drawing.Point(57, 91);
            this.otkricaLabel.Name = "otkricaLabel";
            this.otkricaLabel.Size = new System.Drawing.Size(60, 13);
            this.otkricaLabel.TabIndex = 4;
            this.otkricaLabel.Text = "Broj otkrica";
            // 
            // godinaNumericUpDown
            // 
            this.godinaNumericUpDown.Location = new System.Drawing.Point(124, 57);
            this.godinaNumericUpDown.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.godinaNumericUpDown.Name = "godinaNumericUpDown";
            this.godinaNumericUpDown.Size = new System.Drawing.Size(76, 20);
            this.godinaNumericUpDown.TabIndex = 5;
            // 
            // otkricaNumericUpDown
            // 
            this.otkricaNumericUpDown.Location = new System.Drawing.Point(124, 89);
            this.otkricaNumericUpDown.Name = "otkricaNumericUpDown";
            this.otkricaNumericUpDown.Size = new System.Drawing.Size(76, 20);
            this.otkricaNumericUpDown.TabIndex = 6;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.otkricaNumericUpDown);
            this.Controls.Add(this.godinaNumericUpDown);
            this.Controls.Add(this.otkricaLabel);
            this.Controls.Add(this.godinaLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.prikaziButton);
            this.Controls.Add(this.chart1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.godinaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otkricaNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button prikaziButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label godinaLabel;
        private System.Windows.Forms.Label otkricaLabel;
        private System.Windows.Forms.NumericUpDown godinaNumericUpDown;
        private System.Windows.Forms.NumericUpDown otkricaNumericUpDown;
    }
}