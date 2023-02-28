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
    public partial class ProgressForm : Form
    {
        List<string> buttonTextList;
        int step; // 단계
        int homeTime; // 홈으로 돌아가는 시간
        UserControlForm.ChoiceLockerUC ucChoiceLocker;
        UserControlForm.CheckLocker uccheckLocker;
        UserControlForm.Complete ucComplete;
        System.Windows.Forms.Timer timer;

        public ProgressForm()
        {
            InitializeComponent();
            step = 1;
            homeTime = 5;
            label_timer.Text = "";

            ucChoiceLocker = new UserControlForm.ChoiceLockerUC();
            ucComplete = new UserControlForm.Complete();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_event);
        }

        private void ProgressForm_Load(object sender, EventArgs e)
        {
            // 처음 로드 시엔 패널에 보관함 선택 화면 추가
            panel_main.Controls.Add(ucChoiceLocker);
            button_previous.Visible = false;   
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new HomeForm()).ShowDialog();
            this.Close();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            changeUc("next");
        }

        private void button_previous_Click(object sender, EventArgs e)
        {
            changeUc("pre");
        }

        private void timer_event(object sender, EventArgs e) 
        {
            homeTime -= 1;

            label_timer.Text = homeTime.ToString() + "초 뒤 홈으로 돌아갑니다잉..";

            if (homeTime <= 0)
            {
                timer.Stop();
                this.Visible = false;
                (new HomeForm()).ShowDialog();
                this.Close();
            }
        }

        private void changeUc(string clickButton)
        {
            // 누른 버튼에 따라 step +,- 처리
            if (clickButton.Equals("next")) { step += 1; }
            else { step -= 1; }

            // 패널 비우고 step에 맞는 User Control 넣기
            panel_main.Controls.Clear();
            switch (step)
            {
                case 1:
                    panel_main.Controls.Add(ucChoiceLocker);
                    button_previous.Visible = false;
                    break;
                case 2:
                    buttonTextList = ucChoiceLocker.getList();
                    // Next버튼일 경우 보관함 선택했는지 체크
                    if (clickButton.Equals("next") && buttonTextList.Count == 0)
                    {
                        button_previous.Visible = false;
                        MessageBox.Show("보관함을 선택하세요.");
                        step -= 1;
                    }
                    else
                    {
                        uccheckLocker = new UserControlForm.CheckLocker(buttonTextList);
                        panel_main.Controls.Add(uccheckLocker);
                        button_previous.Visible = true;
                    }
                    break;
                case 3:
                    panel_main.Controls.Add(ucComplete);
                    button_previous.Visible = false;
                    button_next.Visible = false;
                    label_timer.Text = homeTime.ToString() + "초 뒤 홈으로 돌아갑니다잉..";
                    timer.Start();
                    break;
            }
        }
    }
}
