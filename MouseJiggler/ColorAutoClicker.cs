using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Timers;


namespace MouseJiggler
{
    public class ColorAutoClicker
    {
        private Color targetColor = Color.Red; // Beispiel-Ziel-Farbe
        private bool isRunning = false;

        public bool IsRunning => isRunning;

        public ColorAutoClicker()
        {
            
        }
        public void Start()
        {
            isRunning = true;
            CheckMouseColorAndClick();
        }

        public void Stop()
        {
            isRunning = false;
        }

        public void SetTargetColor(Color color)
        {
            targetColor = color;
        }

        private void CheckMouseColorAndClick()
        {
            Point cursorPosition = Cursor.Position;
            Color pixelColor = GetColorAt(cursorPosition);

            if (pixelColor.ToArgb() == targetColor.ToArgb())
            {
                PerformRightClick(cursorPosition);
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

        private const uint MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const uint MOUSEEVENTF_RIGHTUP = 0x10;
    }
}
