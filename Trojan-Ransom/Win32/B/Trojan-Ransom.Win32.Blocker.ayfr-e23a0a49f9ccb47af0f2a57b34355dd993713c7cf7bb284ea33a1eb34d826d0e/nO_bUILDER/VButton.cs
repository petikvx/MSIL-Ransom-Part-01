using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace nO_bUILDER;

internal class VButton : ThemeControl154
{
	[DebuggerNonUserCode]
	public VButton()
	{
	}

	protected override void ColorHook()
	{
	}

	protected override void PaintHook()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		DrawBorders(new Pen(Color.FromArgb(16, 16, 16)), 1);
		G.FillRectangle((Brush)new SolidBrush(Color.FromArgb(5, 5, 5)), 0, 0, ((Control)this).get_Width(), 8);
		DrawBorders(Pens.get_Black(), 3);
		DrawBorders(new Pen(Color.FromArgb(24, 24, 24)));
		checked
		{
			if (State == MouseState.Over)
			{
				G.FillRectangle((Brush)new SolidBrush(Color.FromArgb(25, 25, 25)), 3, 3, ((Control)this).get_Width() - 6, ((Control)this).get_Height() - 6);
				DrawBorders(new Pen(Color.FromArgb(0, 0, 0)), 2);
			}
			else if (State == MouseState.Down)
			{
				Graphics g = G;
				Rectangle rectangle = new Rectangle(3, 3, ((Control)this).get_Width() - 6, ((Control)this).get_Height() - 6);
				g.FillRectangle((Brush)new LinearGradientBrush(rectangle, Color.FromArgb(12, 12, 12), Color.FromArgb(30, 30, 30), (LinearGradientMode)3), 3, 3, ((Control)this).get_Width() - 6, ((Control)this).get_Height() - 6);
				DrawBorders(new Pen(Color.FromArgb(0, 0, 0)), 2);
			}
			else
			{
				Graphics g2 = G;
				Rectangle rectangle = new Rectangle(3, 3, ((Control)this).get_Width() - 6, ((Control)this).get_Height() - 6);
				g2.FillRectangle((Brush)new LinearGradientBrush(rectangle, Color.FromArgb(9, 9, 9), Color.FromArgb(18, 18, 18), (LinearGradientMode)1), 3, 3, ((Control)this).get_Width() - 6, ((Control)this).get_Height() - 6);
				DrawBorders(new Pen(Color.FromArgb(32, 32, 32)), 2);
			}
			if (State == MouseState.Down)
			{
				DrawText(Brushes.get_White(), (HorizontalAlignment)2, 2, 2);
			}
			else
			{
				DrawText(Brushes.get_White(), (HorizontalAlignment)2, 0, 0);
			}
		}
	}
}
