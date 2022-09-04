using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace VI_Theme_Dll_By_xVenoxi;

public class VIButton : ThemeControl154
{
	protected override void ColorHook()
	{
	}

	public VIButton()
	{
		Size size = new Size(75, 25);
		((Control)this).set_Size(size);
	}

	protected override void PaintHook()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		Pen p = new Pen(Color.FromArgb(16, 16, 16));
		G.FillRectangle((Brush)new HatchBrush((HatchStyle)42, Color.FromArgb(35, 35, 35), Color.FromArgb(15, 15, 15)), 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
		DrawBorders(Pens.get_Black());
		DrawBorders(p, 1);
		DrawBorders(Pens.get_Black(), 2);
		DrawCorners(Color.Transparent, 3);
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
				G.FillRectangle((Brush)new HatchBrush((HatchStyle)42, Color.FromArgb(35, 35, 35), Color.FromArgb(15, 15, 15)), 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
				DrawBorders(Pens.get_Black());
				DrawBorders(p, 1);
				DrawBorders(Pens.get_Black(), 2);
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
