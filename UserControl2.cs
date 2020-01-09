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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            Animate();
        }
        public void Animate()
        {
            hideControls();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
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

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Stop();
            Showcontrols();
        }
    }
}
