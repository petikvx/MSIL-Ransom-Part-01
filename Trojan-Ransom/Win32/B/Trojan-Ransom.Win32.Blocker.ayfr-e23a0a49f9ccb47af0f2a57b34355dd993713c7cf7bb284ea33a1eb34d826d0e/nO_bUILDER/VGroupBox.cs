using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace nO_bUILDER;

internal class VGroupBox : ThemeContainer154
{
	public VGroupBox()
	{
		ControlMode = true;
	}

	protected override void ColorHook()
	{
	}

	protected override void PaintHook()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		G.Clear(Color.Transparent);
		DrawBorders(new Pen(Color.FromArgb(36, 36, 36)), 1);
		DrawBorders(Pens.get_Black());
		checked
		{
			G.DrawLine(new Pen(Color.FromArgb(48, 48, 48)), 1, 1, ((Control)this).get_Width() - 2, 1);
			Graphics g = G;
			Rectangle rectangle = new Rectangle(8, 8, ((Control)this).get_Width() - 16, ((Control)this).get_Height() - 16);
			g.FillRectangle((Brush)new LinearGradientBrush(rectangle, Color.FromArgb(12, 12, 12), Color.FromArgb(18, 18, 18), (LinearGradientMode)3), 8, 8, ((Control)this).get_Width() - 16, ((Control)this).get_Height() - 16);
			DrawBorders(new Pen(Color.FromArgb(36, 36, 36)), 7);
		}
	}
}
