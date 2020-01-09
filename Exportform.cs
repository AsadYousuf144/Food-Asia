using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
//using System.Data.OleDb.OleDbConnection;
using System.Configuration;
using System.Drawing.Printing;
using System.IO;
//using Microsoft.Office.Intero

namespace Textile_Asia
{
    public partial class Exportform : Form
    {
        public Exportform()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ASAD-PC;Initial Catalog=March_Events;Persist Security Info=True;User ID=sa;Password=ecg");
        string c = "";

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT * FROM Registration";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //bunifuCustomDataGrid1.DataSource = dt;
            con.Close();
        }

        private void ToCsV(DataGridView dGV, string filename)
        {

          //  string filename = "Textile1";

            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dataGridView1.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dataGridView1.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dataGridView1.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();


        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");
                ToCsV(dataGridView1, sfd.FileName); // Here dataGridview1 is your grid view name
                MessageBox.Show("Export Completed");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();
                string company, hall, stall, country, city, email, website, product, description;

                company = textBox1.Text;
                hall = textBox2.Text;
                stall = textBox3.Text;
                country = textBox4.Text;
                city = textBox5.Text;
                email = textBox6.Text;
                website = textBox7.Text;
                product = textBox8.Text;
                description = textBox9.Text;

                string sql = "insert into Textile1(Company,Hall,Stall,Country,City,Email,Website,Product,Description) values ('" + company + "','" + hall + "', '" + stall + "','" + country + "','" + city + "','" + email + "','" + website + "','" + product + "','" + description + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Values Inserted");
                con.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }





        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "Delete from Textile1 where Company = '" + textBox11.Text + "' ";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //SqlCommand cmd = new SqlCommand("SELECT Company from Textile1 ", con);
            //con.Open();
            //SqlDataReader reader = cmd.ExecuteReader();
            //AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            //while (reader.Read())
            //{
            //    MyCollection.Add(reader.GetString(0));

            //}

            //textBox11.AutoCompleteCustomSource = MyCollection;
            //con.Close();
            

        }


        private void textBox10_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{

            //    if (c == textBox10.Text) { }
            //    else
            //    {
            //        Deleted();
            //    }

            //} 
        }

        private void textBox10_Enter(object sender, EventArgs e)
        {

          
        }

        private void Exportform_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT Company from Textile1 ", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
              while (reader.Read())
                {
                    MyCollection.Add(reader.GetString(0));

                }
            

            textBox11.AutoCompleteCustomSource = MyCollection;
            con.Close();
        }
    }
}
