using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace VI_Theme_Dll_By_xVenoxi;

public class VIGroupBox : ThemeContainer154
{
	public VIGroupBox()
	{
		ControlMode = true;
		Size size = new Size(150, 150);
		((Control)this).set_Size(size);
	}

	protected override void ColorHook()
	{
	}

	protected override void PaintHook()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		G.Clear(Color.Transparent);
		Pen val = new Pen(Color.FromArgb(36, 36, 36));
		Pen val2 = new Pen(Color.FromArgb(48, 48, 48));
		DrawBorders(val, 1);
		DrawBorders(Pens.get_Black());
		checked
		{
			G.DrawLine(val2, 1, 1, ((Control)this).get_Width() - 2, 1);
			Graphics g = G;
			Rectangle rectangle = new Rectangle(4, 4, ((Control)this).get_Width() - 8, ((Control)this).get_Height() - 8);
			g.FillRectangle((Brush)new LinearGradientBrush(rectangle, Color.FromArgb(12, 12, 12), Color.FromArgb(18, 18, 18), (LinearGradientMode)3), 4, 4, ((Control)this).get_Width() - 8, ((Control)this).get_Height() - 8);
			DrawBorders(val, 3);
			DrawBorders(Pens.get_Black(), 5);
			Rectangle rectangle2 = new Rectangle(5, 5, ((Control)this).get_Width() - 25, 20);
			G.DrawRectangle(Pens.get_Black(), rectangle2);
			G.DrawLine(val, 5, 27, ((Control)this).get_Width() - 20, 27);
			G.DrawLine(val, ((Control)this).get_Width() - 19, 6, ((Control)this).get_Width() - 19, 27);
			G.DrawLine(val2, 5, 25, ((Control)this).get_Width() - 22, 25);
			G.DrawLine(val2, ((Control)this).get_Width() - 21, 6, ((Control)this).get_Width() - 21, 25);
			DrawText(Brushes.get_White(), 35, 8);
		}
	}
}
