using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static MouseJiggler.MainForm;
using System.Windows.Forms;

namespace MouseJiggler
{
    public class MouseJiggler
    {
        public bool IsJiggling => isJiggling;

        private const int INPUT_MOUSE = 0;
        private const int MOUSEEVENTF_MOVE = 0x0001;
        private bool isJiggling = false;
        private bool moveRight = true;
        private Timer timerMouseJiggler;
        private int distance = 5;


        public MouseJiggler()
        {
            timerMouseJiggler = new Timer();
            timerMouseJiggler.Tick += TimerMouseJiggler_Tick;
            timerMouseJiggler.Interval = 60000; // Default interval
        }

        public void StartStop()
        {
            if (isJiggling)
            {
                timerMouseJiggler.Stop();
            }
            else
            {
                timerMouseJiggler.Start();
            }
            isJiggling = !isJiggling;
        }
        public void Stop()
        {
            timerMouseJiggler.Stop();
            isJiggling = !isJiggling;
        }
        public void ForceStop()
        {
            timerMouseJiggler.Stop();
            isJiggling = false;
        }
        public void Start()
        {
            timerMouseJiggler.Start();
            isJiggling = !isJiggling;
        }

        private void TimerMouseJiggler_Tick(object sender, EventArgs e)
        {
            int deltaX = moveRight ? distance : -distance;
            MoveMouse(deltaX, 0);
            moveRight = !moveRight;
        }

        public void SetTimerInterval(int interval)
        {
            timerMouseJiggler.Interval = interval;
        }

        public int GetMouseJigglerInterval()
        {
            return timerMouseJiggler.Interval;
        }

        private void MoveMouse(int deltaX, int deltaY)
        {
            INPUT[] input = new INPUT[1];
            input[0].type = INPUT_MOUSE;
            input[0].mi.dx = deltaX;
            input[0].mi.dy = deltaY;
            input[0].mi.dwFlags = MOUSEEVENTF_MOVE;
            SendInput(1, input, Marshal.SizeOf(typeof(INPUT)));
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
