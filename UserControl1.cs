using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Textile_Asia
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            Animate();
            bunifuGradientPanel2.BringToFront();
            //panel1.Visible = false;

        }

        public void Animate() {
            hideControls();
            timer1.Start();
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Showcontrols();
        }
        //PaintEventArgs e;
       // object sender;
        public void Border()
        {
           
        
        
        }

        void Showcontrols() {
            foreach (Control item in this.Controls) {
                bunifuTransition1.ShowSync(item);
                Application.DoEvents();
                //item.Visible = true();
            }
        
        }
        public void hideControls() {
            foreach (Control item in this.Controls) {
                item.Visible = false;
                Application.DoEvents();
            }
        
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
          // ControlPaint.DrawBorder(e.Graphics, bunifuGradientPanel1.DisplayRectangle, Color.Transparent, ButtonBorderStyle.Solid);
        }

        private void bunifuGradientPanel2_MouseEnter(object sender, EventArgs ab)
        {
          //  this.DrawBorder(e.Graphics, bunifuGradientPanel2.DisplayRectangle, Color.Yellow, ButtonBorderStyle.Inset);
           // bunifuGradientPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel2_Paint);

            //PaintEventArgs e;
            // //Graphics g = e.Graphics;
            //e.Graphics.DrawRectangle(Pens.DeepSkyBlue,
            //e.ClipRectangle.Left,
            //e.ClipRectangle.Top,
            //e.ClipRectangle.Width - 1,
            //e.ClipRectangle.Height - 1);
            //base.OnPaint(e);

          //  panel1.Visible = true;

            bunifuGradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        }
        //UserControl1 u = (UserControl1)
        //var form = (Form1)this.Owner();
       // public static string x = "";
        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {
            //tabControl1.SelectedTab = tabPage1;
           // tabControl1.SelectedTab = tabPage3;

            //Form1 f = new Form1();

           

           // Graphics g = e.Graphics;

           // bunifuGradientPanel2.BackColor = System.Drawing.Color.Red;
            //e.Graphics.DrawRectangle(Pens.DeepSkyBlue,
            //e.ClipRectangle.Left,
            //e.ClipRectangle.Top,
            //e.ClipRectangle.Width - 1,
            //e.ClipRectangle.Height - 1);
            //base.OnPaint(e);


            //g.DrawLine(System.Drawing.Pens.Red, pictureBox1.Left, pictureBox1.Top,
            //pictureBox1.Right, pictureBox1.Bottom);
        }

        private void bunifuGradientPanel2_Click(object sender, EventArgs e)
        {
            //bunifuGradientPanel2.BackColor = System.Drawing.ColorTranslator.FromHtml("#8e44ad");
          //  MessageBox.Show("ECG");
           // bunifuGradientPanel2.BackColor = System.Drawing.Color.Red;
           // bunifuGradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
           // MessageBox.Show("ECG");
           // x = "abc";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            //panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#8e44ad");
        }

        private void bunifuGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show("ECG");
        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("ECG");
        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {
         //   MessageBox.Show("ECG");
        }

        private void bunifuGradientPanel2_MouseLeave(object sender, EventArgs e)
        {
           // panel1.Visible = false;
            bunifuGradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }

        private void bunifuGradientPanel3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ECG");
        }

        private void bunifuGradientPanel3_MouseEnter(object sender, EventArgs e)
        {
            bunifuGradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        }

        private void bunifuGradientPanel3_MouseLeave(object sender, EventArgs e)
        {
            bunifuGradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }

        private void bunifuGradientPanel6_MouseEnter(object sender, EventArgs e)
        {
            bunifuGradientPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        }

        private void bunifuGradientPanel6_MouseLeave(object sender, EventArgs e)
        {
            bunifuGradientPanel6.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }

        private void bunifuGradientPanel5_MouseEnter(object sender, EventArgs e)
        {
            bunifuGradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        }

        private void bunifuGradientPanel5_MouseLeave(object sender, EventArgs e)
        {
            bunifuGradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }

        private void bunifuGradientPanel8_MouseEnter(object sender, EventArgs e)
        {
            bunifuGradientPanel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        }

        private void bunifuGradientPanel8_MouseLeave(object sender, EventArgs e)
        {
            bunifuGradientPanel8.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }

        private void bunifuGradientPanel9_MouseEnter(object sender, EventArgs e)
        {
            bunifuGradientPanel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        }

        private void bunifuGradientPanel9_MouseLeave(object sender, EventArgs e)
        {
            bunifuGradientPanel9.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }
    }

}
