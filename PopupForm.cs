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
    public partial class PopupForm : Form
    {
        public PopupForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox1.Text == "e")
            {
               Exportform ef = new Exportform();  
               ef.Show();
               ef.BringToFront();
               this.Hide();
               
            }
            else {
                label20.Visible = true;
                pictureBox18.Visible = true;
                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
