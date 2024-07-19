using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseJiggler
{
    public class CustomCheckBox : CheckBox
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            // Base drawing
            base.OnPaint(pevent);

            // Check if the control is enabled
            if (!this.Enabled)
            {
                // Determine the size of the checkbox itself
                Size checkBoxSize = CheckBoxRenderer.GetGlyphSize(pevent.Graphics, System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal);

                // Draw the checkbox
                CheckBoxRenderer.DrawCheckBox(pevent.Graphics, new Point(0, (this.Height - checkBoxSize.Height) / 2), System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedDisabled);

                // Draw the text next to the checkbox
                Rectangle textRect = new Rectangle(checkBoxSize.Width + 2, 0, this.Width - checkBoxSize.Width - 2, this.Height);
                TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, textRect, Color.Gray, TextFormatFlags.Left);
            }
        }
    }
}
