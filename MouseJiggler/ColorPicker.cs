using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MouseJiggler
{
    public class ColorPicker
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("gdi32.dll")]
        private static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        public static string GetColorAt(Point position)
        {
            IntPtr hdc = GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hdc, position.X, position.Y);
            ReleaseDC(IntPtr.Zero, hdc);

            Color color = Color.FromArgb((int)(pixel & 0x000000FF),
                                         (int)(pixel & 0x0000FF00) >> 8,
                                         (int)(pixel & 0x00FF0000) >> 16);

            return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }
    }
}
