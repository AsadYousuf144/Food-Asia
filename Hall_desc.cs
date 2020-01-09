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

namespace Textile_Asia
{
    public partial class Hall_desc : Form
    {
        public Hall_desc()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static string x = "";
        public static string temp = "";

       // SqlConnection con = new SqlConnection(@"Data Source=ASAD-PC;Initial Catalog=Textile;User ID=sa;Password=ecg");
        //SqlConnection con = new SqlConnection(@"Data Source=ASAD-PC;Initial Catalog=March_Events;Persist Security Info=True;User ID=sa;Password=ecg");

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|March_Events.accdb");
        

        Label l0;
        private void Hall_desc_Load(object sender, EventArgs e)
        {
            Halls();
        }

        protected void l1_MouseEnter(object sender, EventArgs e)
        {
            //string cName = ((Label)sender).Name;
            Label lbl = sender as Label;
            // MessageBox.Show(cName.ToString());
            lbl.Font = new Font(lbl.Font.Name, lbl.Font.SizeInPoints, FontStyle.Underline);
        }

        protected void l1_MouseLeave(object sender, EventArgs e)
        {
            //string cName = ((Label)sender).Name;
            Label lbl = sender as Label;
            // MessageBox.Show(cName.ToString());
            lbl.Font = new Font(lbl.Font.Name, lbl.Font.SizeInPoints, FontStyle.Regular);
        }

        protected void l1_Click(object sender, EventArgs e)
        {
            temp = "hall";
            //MessageBox.Show("ECG");

            Label c = sender as Label;
            x = c.Name.ToString();
            Desc22 h = new Desc22();
            h.Show();
            temp = "";

        }
        public void Halls()
        {
            // MessageBox.Show("ECG");
            int a = 8;
            try
            {
                con.Open();
                label2.Text = Hall.x;
                
                OleDbCommand command = new OleDbCommand("select distinct Company from Textile1 where Hall = '" + Hall.x + "';", con);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    
                    l0 = new Label();
                    l0.Location = new Point(5, a);
                    // l0.BackColor = System.Drawing.ColorTranslator.FromHtml("#cccccc");

                    l0.Font = new System.Drawing.Font("Segoe UI Semibold", 12);
                    l0.Size = new Size(350, 25);
                    l0.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");
                    l0.AutoEllipsis = true;
                    l0.UseMnemonic = false;
                    l0.MouseEnter += new EventHandler(l1_MouseEnter);
                    l0.MouseLeave += new EventHandler(l1_MouseLeave);
                    l0.Click += new EventHandler(l1_Click);
                    l0.Name = reader.GetString(0);

                    if (reader.IsDBNull(0))
                    {
                        l0.Text = "-----";
                    }
                    else
                    {
                        l0.Text = reader.GetString(0);
                    }

                    this.Controls.Add(l0);
                    panel2.Controls.Add(l0);

                    
                    PictureBox pb4 = new PictureBox();
                    //pb4.Image = Image.FromFile(string.Format(@"C:\Users\Asad\Downloads\L12.png"));
                    pb4.Image = Properties.Resources.L12;

                    // panel1.Controls.Add(pb3);
                    // pb4.BackColor = System.Drawing.ColorTranslator.FromHtml("#cccccc");

                    pb4.Location = new Point(5, a + 28);
                    pb4.Size = new Size(350, 10);

                    this.Controls.Add(pb4);
                    panel2.Controls.Add(pb4);



                    a = a + 40;

                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
