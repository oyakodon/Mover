using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Mover
{
    public class WinAPI
    {
        /// <summary>
        /// 指定された文字列と一致するクラス名とウィンドウ名を持つウィンドウのハンドルを返す
        /// </summary>
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        /// <summary>
        /// 指定されたウィンドウのタイトルバーのテキストをバッファに返す
        /// </summary>
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int cch);

        /// <summary>
        /// ウィンドウを移動する
        /// </summary>
        [DllImport("User32.dll")]
        public static extern int MoveWindow(
            IntPtr hWnd,
            int x,
            int y,
            int nWidth,
            int nHeight,
            int bRepaint
            );

        /// <summary>
        /// 指定されたウィンドウをフォアグラウンドにし、アクティブにする
        /// </summary>
        [DllImport("User32.dll")]
        public static extern int SetForegroundWindow(
            IntPtr hWnd
            );

        /// <summary>
        /// 指定された座標を含むウィンドウのハンドルを取得する
        /// </summary>
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr WindowFromPoint(Point lpPoint);

        /// <summary>
        /// カーソルのある座標を取得する
        /// </summary>
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool GetCursorPos(ref Point lpPoint);

        /// <summary>
        /// 指定されたウィンドウの左上端と右下端の座標をスクリーン座標で取得する
        /// </summary>
        [DllImport("User32.dll")]
        public static extern int GetWindowRect(IntPtr hwnd,
            ref RECT lpRect);

        /// <summary>
        /// フォアグラウンドのウィンドウのハンドルを取得する
        /// </summary>
        [DllImport("User32.dll")]
        public static extern IntPtr GetForegroundWindow();

        /// <summary>
        /// Point構造体
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct Point
        {
            public int X;
            public int Y;
        }

        /// <summary>
        /// RECT構造体
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

    }
}
