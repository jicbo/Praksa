namespace A8
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
            this.label1 = new System.Windows.Forms.Label();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.izmeniButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nazadButton = new System.Windows.Forms.Button();
            this.napredButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sifra:";
            // 
            // imeTextBox
            // 
            this.imeTextBox.Location = new System.Drawing.Point(42, 63);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(171, 20);
            this.imeTextBox.TabIndex = 1;
            // 
            // izmeniButton
            // 
            this.izmeniButton.Location = new System.Drawing.Point(42, 102);
            this.izmeniButton.Name = "izmeniButton";
            this.izmeniButton.Size = new System.Drawing.Size(171, 57);
            this.izmeniButton.TabIndex = 2;
            this.izmeniButton.Text = "Upamti izmene";
            this.izmeniButton.UseVisualStyleBackColor = true;
            this.izmeniButton.Click += new System.EventHandler(this.izmeniButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "n";
            // 
            // nazadButton
            // 
            this.nazadButton.Location = new System.Drawing.Point(42, 165);
            this.nazadButton.Name = "nazadButton";
            this.nazadButton.Size = new System.Drawing.Size(83, 57);
            this.nazadButton.TabIndex = 4;
            this.nazadButton.Text = "Nazad";
            this.nazadButton.UseVisualStyleBackColor = true;
            this.nazadButton.Click += new System.EventHandler(this.nazadButton_Click);
            // 
            // napredButton
            // 
            this.napredButton.Location = new System.Drawing.Point(130, 165);
            this.napredButton.Name = "napredButton";
            this.napredButton.Size = new System.Drawing.Size(83, 57);
            this.napredButton.TabIndex = 5;
            this.napredButton.Text = "Napred";
            this.napredButton.UseVisualStyleBackColor = true;
            this.napredButton.Click += new System.EventHandler(this.napredButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(253, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 254);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 286);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.napredButton);
            this.Controls.Add(this.nazadButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.izmeniButton);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.Button izmeniButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nazadButton;
        private System.Windows.Forms.Button napredButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}