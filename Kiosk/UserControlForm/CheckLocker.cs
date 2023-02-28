using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk.UserControlForm
{
    public partial class CheckLocker : UserControl
    {
        List<string> buttonTextList= new List<string>();

        public CheckLocker(List<string> buttonTextList)
        {
            InitializeComponent();
            this.buttonTextList = buttonTextList;
            label_information.Text = "";
        }

        private void CheckLocker_Load(object sender, EventArgs e)
        {
            foreach (string button in buttonTextList)
            {
                label_information.Text += button + " ";
            }
            label_information.Text += "번 보관함 선택";
        }

        public void setText(string text)
        {
            label_information.Text = text;
        }
    }
}
