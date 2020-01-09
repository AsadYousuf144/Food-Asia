using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Textile_Asia
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            panel3.Width = 53;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //Environment.Exit(0);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (panel3.Width == 222)
            {
                panel3.Visible = false;
                panel3.Width = 53;
                bunifuTransition2.ShowSync(panel3);
            }
            else
            {
                panel3.Visible = false;
                panel3.Width = 222;
                bunifuTransition2.ShowSync(panel3);
            }
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
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

        private void bunifuFlatButton27_Click(object sender, EventArgs e)
        {
            
        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {

        }
    }
}
