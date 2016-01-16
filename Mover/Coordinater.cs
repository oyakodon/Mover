using System;
using System.Windows.Forms;

namespace Mover
{
    public partial class Coordinater : Form
    {
        public Form1 form;
        public bool locateMode;

        public Coordinater(bool arg)
        {
            InitializeComponent();

            locateMode = arg;
            if (arg)
            {
                // 位置を変更するモード
                lab_instr1.Text = "X座標";
                lab_instr2.Text = "Y座標";
            } else
            {
                // 大きさを変更するモード
                lab_instr1.Text = "横幅";
                lab_instr2.Text = "縦幅";
            }
        }

        private void numbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            try {
                var first = int.Parse(tb_X.Text);
                var second = int.Parse(tb_Y.Text);
                if (first <= Screen.PrimaryScreen.Bounds.Width && second <= Screen.PrimaryScreen.Bounds.Height)
                {
                    if (locateMode)
                    {
                        form.X = first;
                        form.Y = second;
                        if (Control.ModifierKeys == Keys.Shift)
                        {
                            Coordinater c = new Coordinater(false);
                            c.form = form;
                            c.ShowDialog();
                        } else
                        {
                            form.timer.Start();
                        }
                    }
                    else
                    {
                        form.W = first;
                        form.H = second;
                        form.timer.Start();
                    }
                    this.Close();
                }
                else
                {
                    throw new FormatException("入力された値が画面の範囲外です");
                }
            } catch (FormatException ex)
            {
                MessageBox.Show("入力の形式が正しくありません。\n(入力漏れ、画面の範囲外の値など)\n\n【エラー詳細】" + ex.Message + "\n【スタックトレース】" + ex.StackTrace, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
