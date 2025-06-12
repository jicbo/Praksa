using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A8
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=JICBO_PC\MSSQLSERVER01;Initial Catalog=Antikviteti;Integrated Security=True;Encrypt=False;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT GRADOVI.ime_grada as Grad, COUNT(ANTIKVITETI.antikvitetID) AS 'Broj Otkrica'\r\n  FROM ANTIKVITETI\r\n  INNER JOIN LOKALITETI ON ANTIKVITETI.lokalitetID=LOKALITETI.lokalitetID\r\n  INNER JOIN GRADOVI ON LOKALITETI.gradID=GRADOVI.gradID\r\n  GROUP BY GRADOVI.ime_grada\r\n  ORDER BY GRADOVI.ime_grada";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                // SELECT GRADOVI.ime_grada as Grad, COUNT(ANTIKVITETI.antikvitetID) AS 'Broj Otkrica'  FROM ANTIKVITETI INNER JOIN LOKALITETI ON ANTIKVITETI.lokalitetID=LOKALITETI.lokalitetID  INNER JOIN GRADOVI ON LOKALITETI.gradID=GRADOVI.gradID WHERE ANTIKVITETI.datum_pronalaska=2012  GROUP BY GRADOVI.ime_grada  ORDER BY GRADOVI.ime_grada
                dataGridView1.DataSource = dataTable;
            }
        }

        private void prikaziButton_Click(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.AddXY();
        }
    }
}
