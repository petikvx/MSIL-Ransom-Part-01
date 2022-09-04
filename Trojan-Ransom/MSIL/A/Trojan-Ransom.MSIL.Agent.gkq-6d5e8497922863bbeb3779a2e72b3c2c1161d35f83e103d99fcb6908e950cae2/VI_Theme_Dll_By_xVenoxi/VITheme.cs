using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace VI_Theme_Dll_By_xVenoxi;

public class VITheme : ThemeContainer154
{
	public VITheme()
	{
		TransparencyKey = Color.Fuchsia;
	}

	protected override void ColorHook()
	{
	}

	protected override void PaintHook()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		G.Clear(Color.FromArgb(15, 15, 15));
		Pen val = new Pen(Color.FromArgb(32, 32, 32));
		checked
		{
			G.DrawLine(val, 11, 31, ((Control)this).get_Width() - 12, 31);
			G.DrawLine(val, 11, 8, ((Control)this).get_Width() - 12, 8);
			Graphics g = G;
			Rectangle rectangle = new Rectangle(8, 38, ((Control)this).get_Width() - 16, ((Control)this).get_Height() - 46);
			g.FillRectangle((Brush)new LinearGradientBrush(rectangle, Color.FromArgb(12, 12, 12), Color.FromArgb(18, 18, 18), (LinearGradientMode)3), 8, 38, ((Control)this).get_Width() - 16, ((Control)this).get_Height() - 46);
			DrawText(Brushes.get_White(), (HorizontalAlignment)0, 25, 6);
			DrawBorders(new Pen(Color.FromArgb(60, 60, 60)), 1);
			DrawBorders(Pens.get_Black());
			val = new Pen(Color.FromArgb(25, 25, 25));
			G.DrawLine(Pens.get_Black(), 6, 0, 6, ((Control)this).get_Height() - 6);
			G.DrawLine(Pens.get_Black(), ((Control)this).get_Width() - 6, 0, ((Control)this).get_Width() - 6, ((Control)this).get_Height() - 6);
			G.DrawLine(val, 6, 0, 6, ((Control)this).get_Height() - 6);
			G.DrawLine(val, ((Control)this).get_Width() - 8, 0, ((Control)this).get_Width() - 8, ((Control)this).get_Height() - 6);
			G.DrawRectangle(Pens.get_Black(), 11, 4, ((Control)this).get_Width() - 23, 22);
			G.DrawLine(val, 6, ((Control)this).get_Height() - 6, ((Control)this).get_Width() - 8, ((Control)this).get_Height() - 6);
			G.DrawLine(Pens.get_Black(), 6, ((Control)this).get_Height() - 8, ((Control)this).get_Width() - 8, ((Control)this).get_Height() - 8);
			DrawCorners(Color.Fuchsia);
		}
	}
}
