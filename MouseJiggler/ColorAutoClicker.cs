using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Timers;
using System.Threading;


namespace MouseJiggler
{
    public class ColorAutoClicker
    {
        private Color targetColor = Color.Red;
        public bool isColorAutoClickerRunning = false;
        private Action<Color, bool> updateColorStatusButton;

        public bool IsColorAutoClickerRunning => isColorAutoClickerRunning;

        public ColorAutoClicker(Action<Color, bool> updateColorStatusButton)
        {
            this.updateColorStatusButton = updateColorStatusButton;
        }
        public void Start()
        {
            isColorAutoClickerRunning = true;
            CheckMouseColorAndClick();
        }

        public void Stop()
        {
            isColorAutoClickerRunning = false;
        }

        public void SetTargetColor(Color color)
        {
            targetColor = color;
        }

        private void CheckMouseColorAndClick()
        {
            Point cursorPosition = Cursor.Position;
            Color pixelColor = GetColorAt(cursorPosition);
            bool isMouseOverTargetColor = pixelColor.ToArgb() == targetColor.ToArgb();
            updateColorStatusButton?.Invoke(targetColor, isMouseOverTargetColor);

            if (isMouseOverTargetColor)
            {
                //PerformRightClick(cursorPosition);               // RECHTSKLICK
                //ClickCenterOfScreen(); //Optional (Has to be tested)
                PerformLeftClick(cursorPosition); // LMB           // LINKSKLICK
            }

            // Restart the check at regular intervals when the AutoClicker is running
            if (isColorAutoClickerRunning)
            {
                Task.Delay(100).ContinueWith(_ => CheckMouseColorAndClick());
            }
        }

        private Color GetColorAt(Point position)
        {
            using (Bitmap bitmap = new Bitmap(1, 1))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(position, Point.Empty, new Size(1, 1));
                }
                return bitmap.GetPixel(0, 0);
            }
        }

        private void PerformRightClick(Point position)
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, (uint)position.X, (uint)position.Y, 0, 0);
        }

        [DllImport("user32.dll", SetLastError = true)]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        // Constants for RMB
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const uint MOUSEEVENTF_RIGHTUP = 0x10;

        // Method to calculate the center of the screen and left-click there
        private void ClickCenterOfScreen()
        {
            // Get the screen size
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            // Calculate point in the center
            Point center = new Point(screenWidth / 2, screenHeight / 2);

            // Left-click in the middle of the screen
            PerformLeftClick(center);
        }
        private void PerformLeftClick(Point position)
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)position.X, (uint)position.Y, 0, 0);
        }

        // Constants for LMB
        private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        private const uint MOUSEEVENTF_LEFTUP = 0x04;

        
    }
}
