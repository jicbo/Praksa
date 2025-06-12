using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string projectRoot;
        Image noImage;
        int itemNumber = 1;
        Image newImage;
        bool newImageUploaded = false;

        private void Form2_Load(object sender, EventArgs e)
        {
            getItem(itemNumber);
            nazadButton.Enabled = false;

            projectRoot = Directory.GetParent(Directory.GetParent(System.Windows.Forms.Application.StartupPath).FullName).FullName;
            string imagePath = Path.Combine(projectRoot, "Resources", "antikviteti", "no-image.png");
            noImage = Image.FromFile(imagePath);

            if (File.Exists(imagePath))
            {
                noImage = Image.FromFile(imagePath);
                pictureBox1.BackgroundImage = noImage;
            }
            else
            {
                MessageBox.Show("Image file not found.");
            }
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                ofd.Title = "Select an image file";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.BackgroundImage = new Bitmap(ofd.FileName);
                        newImageUploaded = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}");
                    }
                }
            }
        }

        private void napredButton_Click(object sender, EventArgs e)
        {
            itemNumber++;
            getItem(itemNumber);
            nazadButton.Enabled = true;
        }

        private void nazadButton_Click(object sender, EventArgs e)
        {
            if (itemNumber > 1)
            {
                itemNumber--;
                getItem(itemNumber);
                napredButton.Enabled = true;
                if (itemNumber == 1)
                {
                    nazadButton.Enabled = false;
                }
            }
        }

        private void izmeniButton_Click(object sender, EventArgs e)
        {
            updateItem(imeTextBox.Text, pictureBox1.BackgroundImage);


        }

        void getItem(int id)
        {
            newImageUploaded = false;
            string connectionString = @"Data Source=JICBO_PC\MSSQLSERVER01;Initial Catalog=Antikviteti;Integrated Security=True;Encrypt=False;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT tipAntikvitetaID, tip, slika FROM TIPOVI_ANTIKVITETA WHERE tipAntikvitetaID = {id}";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string column1Value = reader["tipAntikvitetaID"].ToString();
                            string column2Value = reader["tip"].ToString();

                            if (reader["slika"] != DBNull.Value)
                            {
                                byte[] imageData = (byte[])reader["slika"];
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    Image column3Value = Image.FromStream(ms);
                                    pictureBox1.BackgroundImage = column3Value;
                                    pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                                }
                            }
                            else
                            {
                                pictureBox1.BackgroundImage = noImage;
                                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                            }

                            label2.Text = column1Value;
                            imeTextBox.Text = column2Value;
                        }
                        else
                        {
                            label2.Text = "No data found";
                            imeTextBox.Text = "";
                            napredButton.Enabled = false;
                            pictureBox1.BackgroundImage = noImage;
                            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                    }
                }
                connection.Close();
            }
        }

        void updateItem(string itemName, Image itemImage)
        {
            string imageFolder = Path.Combine(projectRoot, "Resources", "antikviteti");
            if (!Directory.Exists(imageFolder))
            {
                Directory.CreateDirectory(imageFolder);
            }
            byte[] imageData;
            if (newImageUploaded)
            {
                string imagePath = Path.Combine(imageFolder, $"{itemNumber}.png");
                itemImage.Save(imagePath, System.Drawing.Imaging.ImageFormat.Png);

                using (MemoryStream ms = new MemoryStream())
                {
                    itemImage.Save(ms, itemImage.RawFormat);
                    imageData = ms.ToArray();
                }
            }
            else
            {
                imageData = new byte[0];
            }

            string connectionString = @"Data Source=JICBO_PC\MSSQLSERVER01;Initial Catalog=Antikviteti;Integrated Security=True;Encrypt=False;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query;
                if (newImageUploaded)
                {
                    query = "UPDATE TIPOVI_ANTIKVITETA SET tip = @itemName, slika = @ImageData WHERE tipAntikvitetaID = @ID";
                } else
                {
                    query = "UPDATE TIPOVI_ANTIKVITETA SET tip = @itemName WHERE tipAntikvitetaID = @ID";
                }
                
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@itemName", itemName);
                    command.Parameters.AddWithValue("@ImageData", imageData);
                    command.Parameters.AddWithValue("@ID", label2.Text);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update item. No rows were updated.");
                    }
                    connection.Close();
                }
            }
        }
    }
}
