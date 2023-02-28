using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new ProgressForm()).ShowDialog();
            this.Close();
        }
    }
}
