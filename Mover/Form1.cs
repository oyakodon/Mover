using System;
using System.Windows.Forms;
using static Mover.WinAPI;

namespace Mover
{
    public partial class Form1 : Form
    {
        public int tick = 0;
        public Timer timer;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Tick += new EventHandler(this.OnTick_Timer);
            timer.Interval = 1; //間隔設定
            timer.Start(); // タイマーを開始 
        }

        public void OnTick_Timer(object sender, EventArgs e)
        {
            ++tick;
            var rem = 5 - (tick / 60);
            if (rem == 0)
            {
                timer.Stop();

                var hWnd = GetForegroundWindow();
                var winRect = new RECT();
                GetWindowRect(hWnd, ref winRect);
                var w = winRect.right - winRect.left;
                var h = winRect.bottom - winRect.top;
                var x = Screen.PrimaryScreen.Bounds.Width - Screen.PrimaryScreen.WorkingArea.Width + 20;
                var y = Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height + 20;
                MoveWindow(hWnd, x, y, w, h, 0);

                lab_cntdown.Text = "―";
                tick = 0;
            }
            else if (rem > 0) {
                lab_cntdown.Text = rem.ToString();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            timer.Stop();
            lab_cntdown.Text = "―";
            tick = 0;
        }
    }
}
