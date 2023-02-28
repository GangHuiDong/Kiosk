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
    public partial class ChoiceLockerUC : UserControl
    {
        Dictionary<Button, bool> buttonDic; // 보관함 버튼, 체크여부
        List<string> buttonList;
        int x; // 버튼 x 좌표
        int y; // 버튼 y 좌표
        int count; // 버튼 개수

        public ChoiceLockerUC()
        {
            InitializeComponent();
            x = 10; y = 10;
            count = 10;
            buttonDic = new Dictionary<Button, bool>();
            buttonList = new List<string>();
        }

        private void ChoiceLockerUC_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < count; i++)
            {
                // 버튼 속성 설정
                Button button = setButton(i);

                // 버튼 줄 설정
                if (i + 1 == (count / 2))
                {
                    y += 100;
                    x = 10;
                }
                else
                {
                    x += 60;
                }

                buttonDic.Add(button, false);
                this.Controls.Add(button);
            }
        }

        private Button setButton(int i) 
        {
            Button button = new Button();
            button.Text = (i + 1).ToString();
            button.Name = (i + 1).ToString();
            button.Width = 50;
            button.Height = 50;
            button.Location = new Point(x, y);
            button.FlatStyle = FlatStyle.Flat;
            button.Click += buttonClickEvent;

            return button;
        }

        private void buttonClickEvent(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // 버튼 리스트에 추가 및 제거
            if (!buttonList.Contains(button.Text))
            {
                buttonList.Add(button.Text);
            }
            else
            {
                buttonList.Remove(button.Text);
            }

            // 버튼 색 및 체크 여부 변경
            if (!buttonDic[button])
            {
                
                buttonDic[button] = true;
                button.BackColor= Color.Green;
            }
            else
            {
                buttonDic[button] = false;
                button.BackColor= Color.White;
            }
        }

        public List<string> getList()
        {
            return buttonList;
        }
    }
}
