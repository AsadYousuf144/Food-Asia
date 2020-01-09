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
//using Microsoft.Office.Interop.Excel;
//using System.Web.HttpContext;
//using HttpContext.Current.Response;
//using System.Collections.Generic;

//using System.ComponentModel;
using System.IO;


namespace Textile_Asia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       // SqlConnection con = new SqlConnection(@"Data Source=ASAD-PC;Initial Catalog=Textile;User ID=sa;Password=ecg");
       // SqlConnection con = new SqlConnection(@"Data Source=ASAD-PC;Initial Catalog=March_Events;Persist Security Info=True;User ID=sa;Password=ecg");

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|March_Events.accdb");


        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
      
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
       
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            Animate();
            panel3.Width = 222;
            panel3.BringToFront();
            companies1.BringToFront();
            panel1.BringToFront();
            //Form1.Location = new Point(10, 10);
            Form1 f = new Form1();
            f.Location = new Point(1, 1);
            con.Open();

            //f.StartPosition = FormStartPosition.CenterScreen;
            
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            //if (panel3.Width == 222)
            //{
            //    panel3.Visible = false;
            //    panel3.Width = 53;
            //    bunifuTransition2.ShowSync(panel3);
            //}
            //else
            //{
            //    panel3.Visible = false;
            //    panel3.Width = 222;
            //    bunifuTransition2.ShowSync(panel3);
            //}
        }


        void Showcontrols()
        {
            foreach (Control item in this.Controls)
            {
                bunifuTransition1.ShowSync(item);
                Application.DoEvents();
                //item.Visible = true();
            }

        }
        public void hideControls()
        {
            foreach (Control item in this.Controls)
            {
                item.Visible = false;
                Application.DoEvents();
            }

        }


        private void bunifuFlatButton16_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage11;
        }

        private void bunifuFlatButton18_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton26_Click(object sender, EventArgs e)
        {
           // tabControl1.SelectedTab = tabPage2;
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_MouseEnter(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_MouseLeave(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_MouseEnter(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_MouseLeave(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_MouseEnter(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_MouseLeave(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton27_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
             
        }

        private void bunifuCustomLabel10_MouseEnter(object sender, EventArgs e)
        {
            bunifuCustomLabel10.ForeColor = System.Drawing.ColorTranslator.FromHtml("#a5cd39");
        }

        private void bunifuCustomLabel10_MouseLeave(object sender, EventArgs e)
        {
            bunifuCustomLabel10.ForeColor = System.Drawing.ColorTranslator.FromHtml("#404040");

        }

        private void bunifuCustomLabel9_MouseEnter(object sender, EventArgs e)
        {
            bunifuCustomLabel9.ForeColor = System.Drawing.ColorTranslator.FromHtml("#a5cd39");

        }

        private void bunifuCustomLabel9_MouseLeave(object sender, EventArgs e)
        {
            bunifuCustomLabel9.ForeColor = System.Drawing.ColorTranslator.FromHtml("#404040");

        }

        private void bunifuCustomLabel8_MouseEnter(object sender, EventArgs e)
        {
            bunifuCustomLabel8.ForeColor = System.Drawing.ColorTranslator.FromHtml("#a5cd39");

        }

        private void bunifuCustomLabel8_MouseLeave(object sender, EventArgs e)
        {
            bunifuCustomLabel8.ForeColor = System.Drawing.ColorTranslator.FromHtml("#404040");

        }

        private void bunifuCustomLabel7_MouseEnter(object sender, EventArgs e)
        {
            bunifuCustomLabel7.ForeColor = System.Drawing.ColorTranslator.FromHtml("#a5cd39");

        }

        private void bunifuCustomLabel7_MouseLeave(object sender, EventArgs e)
        {
            bunifuCustomLabel7.ForeColor = System.Drawing.ColorTranslator.FromHtml("#404040");

        }

        private void bunifuCustomLabel6_MouseEnter(object sender, EventArgs e)
        {
            bunifuCustomLabel6.ForeColor = System.Drawing.ColorTranslator.FromHtml("#a5cd39");

        }

        private void bunifuCustomLabel6_MouseLeave(object sender, EventArgs e)
        {
            bunifuCustomLabel6.ForeColor = System.Drawing.ColorTranslator.FromHtml("#404040");

        }

       // public static string ab = "";
        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }
        int a = 2;
        private void bunifuCustomLabel10_Click(object sender, EventArgs e)
        {

            bunifuSeparator2.Width = bunifuCustomLabel10.Width;
            bunifuSeparator2.Left = bunifuCustomLabel10.Left;

            companies1.Visible = false;
            companies1.BringToFront();
            bunifuTransition2.ShowSync(companies1);

            //ab = bunifuCustomLabel10.Text;

            //Desc d = new Desc();
            //d.Show();


            if (a == 2)
            {
                companies1.Company();
                a += 1;
            }
      
        }
        int b = 3;

        private void bunifuCustomLabel9_Click(object sender, EventArgs e)
        {

            //Product_desc p = new Product_desc();
            //p.Show();


            bunifuSeparator2.Width = bunifuCustomLabel9.Width;
            bunifuSeparator2.Left = bunifuCustomLabel9.Left;

            products1.Visible = false;
            products1.BringToFront();
            bunifuTransition2.ShowSync(products1);

            if (b == 3)
            {
                products1.Product();
                b += 1;
            }

        }
        int c = 4;
        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {
            bunifuSeparator2.Width = bunifuCustomLabel8.Width;
            bunifuSeparator2.Left = bunifuCustomLabel8.Left;

            countries1.Visible = false;
            countries1.BringToFront();
            bunifuTransition2.ShowSync(countries1);
            if (c == 4)
            {
                countries1.Country();
                c += 1;
            }

        }
        int d = 5;
        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {
            bunifuSeparator2.Width = bunifuCustomLabel7.Width;
            bunifuSeparator2.Left = bunifuCustomLabel7.Left;
            
            hall1.Visible = false;
            hall1.BringToFront();
            bunifuTransition2.ShowSync(hall1);
            if (d == 5)
            {
                hall1.Halls(); 
                d += 1;
            }
        }
        int g = 6;
        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
           {
            bunifuSeparator2.Width = bunifuCustomLabel6.Width;
            bunifuSeparator2.Left = bunifuCustomLabel6.Left;

            stalls1.Visible = false;
            stalls1.BringToFront();
            bunifuTransition2.ShowSync(stalls1);
            if (g == 6) {
                stalls1.Stall();
                g += 1;
            }
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

            
        }

        private void bunifuFlatButton25_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void bunifuFlatButton24_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void bunifuFlatButton23_Click(object sender, EventArgs e)
        {
          //  tabControl1.SelectedTab = tabPage5;
        }

        private void bunifuFlatButton22_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }

        private void bunifuFlatButton21_Click(object sender, EventArgs e)
        {
           // tabControl1.SelectedTab = tabPage7;
        }

        private void bunifuFlatButton20_Click(object sender, EventArgs e)
        {
           // tabControl1.SelectedTab = tabPage8;
        }

        private void bunifuFlatButton19_Click(object sender, EventArgs e)
        {
           // tabControl1.SelectedTab = tabPage9;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {

                DialogResult result = MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    //con.Close();
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void details1_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void stalls1_Load(object sender, EventArgs e)
        {

        }

        private void hall1_Load(object sender, EventArgs e)
        {

        }

        private void countries1_Load(object sender, EventArgs e)
        {

        }

        private void products1_Load(object sender, EventArgs e)
        {

        }

        private void companies1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator2_Load(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void gallery1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage10_Click(object sender, EventArgs e)
        {

        }

        private void tabPage11_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator4_Load(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator3_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {
           // panel2.BackColor = System.Drawing.Color.Red;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("https://twitter.com/textileasia");

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/FoodTechnologyAsia/");  

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=TMXMl3lYGnc");

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;

        }

        private void bunifuGradientPanel12_Paint(object sender, PaintEventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;

        }

        private void tabPage6_Click_1(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton1_MouseEnter(object sender, EventArgs e)
        {
            bunifuFlatButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            MessageBox.Show("ECG");
        }

        private void bunifuFlatButton1_MouseLeave(object sender, EventArgs e)
        {
            bunifuFlatButton1.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //this.BackColor = System.Drawing.ColorTranslator.FromHtml("#E74C3C");  
            label25.Text = "Invalid Value";
            //label26.Text = "Invalid Value";


            string Company, Address, Country, Person, Designation, Cell, Fax, Email, Web, Product;
           
            Company = bunifuMetroTextbox2.Text;
            Address = bunifuMetroTextbox4.Text;
            Country = bunifuMetroTextbox3.Text;
            Person = bunifuMetroTextbox8.Text;
            Designation = bunifuMetroTextbox7.Text;
            Cell = bunifuMetroTextbox6.Text;
            Fax = bunifuMetroTextbox5.Text;
            Email = bunifuMetroTextbox11.Text;
            Web = bunifuMetroTextbox10.Text;
            Product = bunifuMetroTextbox9.Text;

            pictureBox18.Visible = false;
            label20.Visible = false;
            //pictureBox19.Visible = false;
           // label21.Visible = false;
            pictureBox20.Visible = false;
            label22.Visible = false;
            pictureBox21.Visible = false;
            label23.Visible = false;
            pictureBox22.Visible = false;
            label24.Visible = false;
            pictureBox23.Visible = false;
            label25.Visible = false;
           // pictureBox24.Visible = false;
           // label26.Visible = false;
            pictureBox25.Visible = false;
            label27.Visible = false;
            pictureBox26.Visible = false;
            label28.Visible = false;
            pictureBox27.Visible = false;
            label29.Visible = false;

            string sql = "insert into Registration(Company,Address,Country,Person,Designation,Cell,Fax,Email,Web,Product) values ('" + Company + "','" + Address + "', '" + Country + "','" + Person + "','" + Designation + "','" + Cell + "','" + Fax + "','" + Email + "','" + Web + "','" + Product + "')";
            //MessageBox.Show("Values Inserted");
            try
            {      
               // con.Open();
                if (bunifuMetroTextbox2.Text == "")
                {
                    pictureBox18.Visible = true;
                    label20.Visible = true;
                }
                //else if (bunifuMetroTextbox4.Text == "")
                //{
                //    pictureBox19.Visible = true;
                //    label21.Visible = true;
                //}
                else if (bunifuMetroTextbox3.Text == "")
                {
                    pictureBox20.Visible = true;
                    label22.Visible = true;
                }
                else if (bunifuMetroTextbox8.Text == "")
                {
                    pictureBox21.Visible = true;
                    label23.Visible = true;
                }
                else if (bunifuMetroTextbox7.Text == "")
                {
                    pictureBox22.Visible = true;
                    label24.Visible = true;
                }
                else  if (bunifuMetroTextbox6.Text == "")
                {

                    pictureBox23.Visible = true;
                    label25.Visible = true;
                }

                //else if (System.Text.RegularExpressions.Regex.IsMatch(bunifuMetroTextbox6.Text, "[^0-9]"))
                //{
                //    //MessageBox.Show("ECG");
                //    label25.Visible = true;
                //    pictureBox23.Visible = true;
                //    label25.Text = "Please enter only numbers";
                //   // bunifuMetroTextbox6.Text = bunifuMetroTextbox6.Text.Remove(bunifuMetroTextbox6.Text.Length - 1);
                //}
                //else if (bunifuMetroTextbox5.Text == "")
                //{
                //    pictureBox24.Visible = true;
                //    label26.Visible = true;
                //}
                //else if (System.Text.RegularExpressions.Regex.IsMatch(bunifuMetroTextbox5.Text, "[^0-9]"))
                //{
                //    //MessageBox.Show("ECG");
                //   // pictureBox24.Visible = true;
                //   // label26.Visible = true;
                //   // label26.Text = "Please enter only numbers";
                //    // bunifuMetroTextbox6.Text = bunifuMetroTextbox6.Text.Remove(bunifuMetroTextbox6.Text.Length - 1);
                //}

                else if (bunifuMetroTextbox11.Text == "")
                {
                    pictureBox25.Visible = true;
                    label27.Visible = true;
                }
                else if (bunifuMetroTextbox10.Text == "")
                {
                    pictureBox26.Visible = true;
                    label28.Visible = true;
                }
                else if (bunifuMetroTextbox9.Text == "")
                {
                    pictureBox27.Visible = true;
                    label29.Visible = true;
                }

                else
                {

                    //OleDbCommand cmd = new OleDbCommand(sql, con);
                    //cmd.ExecuteNonQuery();
                    //MessageBox.Show("Values Inserted");

                    bunifuMetroTextbox2.Text = "";
                    bunifuMetroTextbox4.Text = "";
                    bunifuMetroTextbox3.Text = "";
                    bunifuMetroTextbox8.Text = "";
                    bunifuMetroTextbox7.Text = "";
                    bunifuMetroTextbox6.Text = "";
                    bunifuMetroTextbox5.Text = "";
                    bunifuMetroTextbox11.Text = "";
                    bunifuMetroTextbox10.Text = "";
                    bunifuMetroTextbox9.Text = "";
                }
                
            }
            catch (System.Data.OleDb.OleDbException ex)
            {
                string msg = "Error:";
                msg += ex.Message;
            }
            finally
            {
              //  con.Close();
            }
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            //panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            //panel2.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            //panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
          //  panel4.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
          //  panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
          //  panel5.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }

        private void panel6_MouseEnter(object sender, EventArgs e)
        {
           // panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            //panel6.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }

        private void panel7_MouseEnter(object sender, EventArgs e)
        {
            //panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {
           // panel7.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }

        private void panel8_MouseEnter(object sender, EventArgs e)
        {
           // panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        }

        private void panel8_MouseLeave(object sender, EventArgs e)
        {
           // panel8.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;

        }

        private void panel6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;

        }

        private void panel7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;

        }

        private void panel8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage11;

        }

        private void tabPage2_Click_2(object sender, EventArgs e)
        {

        }
        public void Animate()
        {
            hideControls();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Showcontrols();
        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {

        }

        private void panel9_MouseEnter(object sender, EventArgs e)
        {
            panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        }

        private void panel9_MouseLeave(object sender, EventArgs e)
        {
            panel9.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }

        private void panel10_MouseEnter(object sender, EventArgs e)
        {
            //panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        }

        private void panel10_MouseLeave(object sender, EventArgs e)
        {
            //panel10.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }

        private void panel11_MouseEnter(object sender, EventArgs e)
        {
          //  panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        }

        private void panel11_MouseLeave(object sender, EventArgs e)
        {
           // panel11.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }

        private void panel12_MouseEnter(object sender, EventArgs e)
        {
            panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        }

        private void panel12_MouseLeave(object sender, EventArgs e)
        {
            panel12.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }

        private void panel13_MouseEnter(object sender, EventArgs e)
        {
            panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        }

        private void panel13_MouseLeave(object sender, EventArgs e)
        {
            panel13.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }

        private void panel14_MouseEnter(object sender, EventArgs e)
        {
            panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        }

        private void panel14_MouseLeave(object sender, EventArgs e)
        {
            panel14.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage11;
        }
        //int ab = 1;
        //int ac = 5;


        private void button1_Click_3(object sender, EventArgs e)
        {
            
           // pictureBox6.Image = 
           // picturebox6.Image = project.Properties.Resources.imgfromresource;

            //pictureBox6.Image = Properties.Resources._1;
            //pictureBox6.Image = Image.FromFile("2.jpg");
           // List<string> imageName;
         //   var image = Image.FromFile(imageName[0]);
            //Image image = Image.FromFile(imageName[counter]);
            //counter = counter + 1;
            //Image image = Image.FromFile(imageName[counter]);
            //pictureBox1.Image = image;
            //if (counter == imageName.Count - 1)
            //{
            //    counter = -1;
            //}

            

            //if (ab == 1) {
            //    pictureBox6.Image = Properties.Resources._1;
                
            //}
            //else if (ab == 2)
            //{
            //    pictureBox6.Image = Properties.Resources._2;
            //}
            //else if (ab == 3)
            //{
            //    pictureBox6.Image = Properties.Resources._3;
            //}
            //else if (ab == 4)
            //{
            //    pictureBox6.Image = Properties.Resources._4;
            //}
            //if (ab == 5)
            //{
            //    pictureBox6.Image = Properties.Resources._5;
            //}

            //ab += 1;
            //ac = ab;

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            //int ac = 5;
            
            //if (ac == 1)
            //{
            //    pictureBox6.Image = Properties.Resources._1;
            //}
            //else if (ac == 2)
            //{
            //    pictureBox6.Image = Properties.Resources._2;
            //}
            //else if (ac == 3)
            //{
            //    pictureBox6.Image = Properties.Resources._3;
            //}
            //else if (ac == 4)
            //{
            //    pictureBox6.Image = Properties.Resources._4;
            //}
            //if (ac == 5)
            //{
            //    pictureBox6.Image = Properties.Resources._5;
            //}

            //ac -=1 ;

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
           pictureBox6.Image = Properties.Resources._11;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources._12;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources._13;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources._14;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources._15;
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources._16;
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources._17;
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources._18;
        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources._19;
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources._20;
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources._21;
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources._23;
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources._24;
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources._22;
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources._25;
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources._27;
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources._28;
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources._30;
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources._26;
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Click(object sender, EventArgs e)
        {
            //tabControl1.SelectedTab = tabPage4;
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
          //  pictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
          //  pictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void pictureBox41_MouseEnter(object sender, EventArgs e)
        {
          //  pictureBox41.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void pictureBox41_MouseLeave(object sender, EventArgs e)
        {
          //  pictureBox41.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            //con.Open();
            //string sql = "SELECT * FROM Registration";
            //SqlDataAdapter da = new SqlDataAdapter(sql, con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //con.Close();  
        }

        private void gallery1_Load_1(object sender, EventArgs e)
        {

        }
        //private void ToCsV(DataGridView dGV, string filename) {

        //    //string filename = "Textile1";

        //    string stOutput = "";
        //    // Export titles:
        //    string sHeaders = "";

        //    for (int j = 0; j < dataGridView1.Columns.Count; j++)
        //        sHeaders = sHeaders.ToString() + Convert.ToString(dataGridView1.Columns[j].HeaderText) + "\t";
        //    stOutput += sHeaders + "\r\n";
        //    // Export data.
        //    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
        //    {
        //        string stLine = "";
        //        for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
        //            stLine = stLine.ToString() + Convert.ToString(dataGridView1.Rows[i].Cells[j].Value) + "\t";
        //        stOutput += stLine + "\r\n";
        //    }
        //    Encoding utf16 = Encoding.GetEncoding(1254);
        //    byte[] output = utf16.GetBytes(stOutput);
        //    FileStream fs = new FileStream(filename, FileMode.Create);
        //    BinaryWriter bw = new BinaryWriter(fs);
        //    bw.Write(output, 0, output.Length); //write the encoded file
        //    bw.Flush();
        //    bw.Close();
        //    fs.Close();

        //}
        private void button2_Click_3(object sender, EventArgs e)
        {


            //SaveFileDialog sfd = new SaveFileDialog();
            //sfd.Filter = "Excel Documents (*.xls)|*.xls";
            //sfd.FileName = "export.xls";
            //if (sfd.ShowDialog() == DialogResult.OK)
            //{
            //    //ToCsV(dataGridView1, @"c:\export.xls");
            //    ToCsV(dataGridView1, sfd.FileName); // Here dataGridview1 is your grid view name
            //}



        }

        private void button3_Click(object sender, EventArgs e)
        {
            //tabControl1.SelectedTab = tabPage5;
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            //con.Open();
            //string sql = "SELECT * FROM Registration";
            //SqlDataAdapter da = new SqlDataAdapter(sql, con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //con.Close(); 
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            //SaveFileDialog sfd = new SaveFileDialog();
            //sfd.Filter = "Excel Documents (*.xls)|*.xls";
            //sfd.FileName = "export.xls";
            //if (sfd.ShowDialog() == DialogResult.OK)
            //{
            //    //ToCsV(dataGridView1, @"c:\export.xls");
            //    ToCsV(dataGridView1, sfd.FileName); // Here dataGridview1 is your grid view name
            //    MessageBox.Show("Export Completed");
            //}
        }
        int cd = 1;
        private void pictureBox43_Click(object sender, EventArgs e)
        {
            //tabControl1.SelectedTab = tabPage5;
            
            //if (cd == 1)
            //{
            //    PopupForm popup = new PopupForm();
            //    DialogResult dialogresult = popup.ShowDialog();
            //    cd = 1;
            //}
            ////cd += 1;

        }

        OleDbDataAdapter da;
       // SqlDataAdapter da;
        DataTable dt;
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
                 //con.Open();
                //SqlCommand command = new SqlCommand("select distinct Company from Textile1 where Product = 'looms';", con);
                //SqlDataReader reader = command.ExecuteReader();
                //while (reader.Read()) {

                //    label31.Text = reader.GetString(0);
                //}


                 //da = new SqlDataAdapter("Select  select distinct Company from Textile1 where Product  like '" + bunifuMetroTextbox1.Text + "%'", con);
                 //try
                 //{

                 //    dt = new DataTable();
                 //    da.Fill(dt);
                 //    dataGridView1.DataSource = dt;
                 //    //metroGrid1.DataSource = dt;
                 //    //metroListView1.DataSource = dt;

                 //    //da.Fill(dt);
                 //    //BindingSource bsource = new BindingSource();
                 //    //bsource.DataSource = dt;
                 //    //metroGrid1.DataSource = bsource;



                 //    //metroGrid1.Columns[0].Visible = false;

                 //    //dataGridView1.Columns[0].Width = 300;
                 //}
                 //catch (Exception ec)
                 //{
                 //    MessageBox.Show(ec.Message);
                 //}
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

            da = new OleDbDataAdapter("select distinct Company, Hall, Stall, Product,Country,City,Website,Email,Description from Textile1 where Company  like '%" + bunifuMetroTextbox1.Text + "%'", con);
                 try
                 {

                     dt = new DataTable();
                     da.Fill(dt);
                     dataGridView1.DataSource = dt;

                     dataGridView1.Columns[0].Width = 200;
                     dataGridView1.Columns[1].Width = 50;
                     dataGridView1.Columns[2].Width = 80;
                     dataGridView1.Columns[3].Width = 200;
                     dataGridView1.Columns[4].Width = 70;
                     dataGridView1.Columns[5].Width = 70;
                     dataGridView1.Columns[6].Width = 150;
                     dataGridView1.Columns[7].Width = 150;
                     dataGridView1.Columns[8].Width = 400;

                 }
                 catch (Exception ec)
                 {
                     MessageBox.Show(ec.Message);
                 }
        }

        private void bunifuFlatButton2_Click_2(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pictureBox50.Image = Properties.Resources.F1;
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            pictureBox50.Image = Properties.Resources.F2;
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {
            pictureBox50.Image = Properties.Resources.F3;
        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {
           // pictureBox50.Image = Properties.Resources.t4;
        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {
         //   pictureBox50.Image = Properties.Resources.t5;
        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {
           // pictureBox50.Image = Properties.Resources.t6;
        }

        private void pictureBox49_Click(object sender, EventArgs e)
        {
            //pictureBox50.Image = Properties.Resources.t7;
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void panel2_MouseEnter_1(object sender, EventArgs e)
        {
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void panel2_MouseLeave_1(object sender, EventArgs e)
        {
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void stalls1_Load_1(object sender, EventArgs e)
        {

        }
        }
    }

