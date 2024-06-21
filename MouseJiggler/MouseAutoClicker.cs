using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MouseJiggler
{
    public class MouseAutoClicker
    {
        public bool IsClicking => isClicking;

        private const int INPUT_MOUSE = 0;
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private bool isClicking = false;
        private Timer clickTimer;

        public MouseAutoClicker()
        {
            clickTimer = new Timer();
            clickTimer.Tick += ClickTimer_Tick;
            clickTimer.Interval = 60;
        }

        public void StartStop()
        {
            if (isClicking)
            {
                clickTimer.Stop();
            }
            else
            {
                clickTimer.Start();
            }
            isClicking = !isClicking;
        }

        public void Stop()
        {
            clickTimer.Stop();
            isClicking = false;
        }

        public void Start()
        {
            clickTimer.Start();
            isClicking = true;
        }

        public void SetClickInterval(int interval)
        {
            clickTimer.Interval = interval;
        }

        public int GetAutoclickerInterval()
        {
            return clickTimer.Interval;
        }

        private void ClickTimer_Tick(object sender, EventArgs e)
        {
            DoMouseClick();
        }

        private void DoMouseClick()
        {
            INPUT[] inputs = new INPUT[2];

            inputs[0].type = INPUT_MOUSE;
            inputs[0].mi.dx = 0;
            inputs[0].mi.dy = 0;
            inputs[0].mi.mouseData = 0;
            inputs[0].mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            inputs[0].mi.time = 0;
            inputs[0].mi.dwExtraInfo = IntPtr.Zero;

            inputs[1].type = INPUT_MOUSE;
            inputs[1].mi.dx = 0;
            inputs[1].mi.dy = 0;
            inputs[1].mi.mouseData = 0;
            inputs[1].mi.dwFlags = MOUSEEVENTF_LEFTUP;
            inputs[1].mi.time = 0;
            inputs[1].mi.dwExtraInfo = IntPtr.Zero;

            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));
        }

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

        [StructLayout(LayoutKind.Sequential)]
        public struct INPUT
        {
            public int type;
            public MOUSEINPUT mi;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public uint mouseData;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }
    }
}