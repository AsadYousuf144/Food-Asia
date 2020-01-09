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
    public partial class Gallery : UserControl
    {
        public Gallery()
        {
            InitializeComponent();
        }

        public void Animate() {
            Hidecontrols();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Showcontrols();
        }

        public void Showcontrols() {

            foreach (Control item in this.Controls) {
                bunifuTransition1.ShowSync(item);
                Application.DoEvents();
            }
        }

        public void Hidecontrols() {
            foreach (Control item in this.Controls)
            {
                item.Visible = false;
                Application.DoEvents();
            }
        }

        private void Gallery_Load(object sender, EventArgs e)
        {
            Showcontrols();
        }
    }
}
