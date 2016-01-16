using System;
using System.Windows.Forms;
using static Mover.WinAPI;

namespace Mover
{
    public partial class Form1 : Form
    {
        public int tick = 0;
        public Timer timer;
        public int? X;
        public int? Y;
        public int? H;
        public int? W;

        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Tick += new EventHandler(this.OnTick_Timer);
            timer.Interval = 1; //間隔設定
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            // 多重クリック回避
            timer.Stop();
            lab_cntdown.Text = "―";
            tick = 0;

            if (Control.ModifierKeys == Keys.Control)
            {
                Coordinater c = new Coordinater(true);
                c.form = this;
                c.ShowDialog();
            } else if (Control.ModifierKeys == Keys.Shift)
            {
                Coordinater c = new Coordinater(false);
                c.form = this;
                c.ShowDialog();
            } else
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
                if (X == null && Y == null)
                {
                    X = Screen.PrimaryScreen.Bounds.Width - Screen.PrimaryScreen.WorkingArea.Width + 20;
                    Y = Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height + 20;
                }
                if (H == null && W == null)
                {
                    W = winRect.right - winRect.left;
                    H = winRect.bottom - winRect.top;
                }
                MoveWindow(hWnd, X.Value, Y.Value, W.Value, H.Value, 0);

                lab_cntdown.Text = "―";
                tick = 0;
                X = Y = H = W = null;
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
            X = Y = H = W = null;
        }
    }
}
