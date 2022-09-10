using System;
using System.Drawing;
using System.Windows.Forms;

namespace NoobCrypt2._0;

internal class NSTheme : ThemeContainer154
{
	private int _AccentOffset;

	private Rectangle R1;

	private Pen P1;

	private Pen P2;

	private SolidBrush B1;

	private int Pad;

	public int AccentOffset
	{
		get
		{
			return _AccentOffset;
		}
		set
		{
			_AccentOffset = value;
			((Control)this).Invalidate();
		}
	}

	public NSTheme()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		_AccentOffset = 42;
		Header = 30;
		BackColor = Color.FromArgb(50, 50, 50);
		P1 = new Pen(Color.FromArgb(35, 35, 35));
		P2 = new Pen(Color.FromArgb(60, 60, 60));
		B1 = new SolidBrush(Color.FromArgb(50, 50, 50));
	}

	protected override void ColorHook()
	{
	}

	protected override void PaintHook()
	{
		G.Clear(BackColor);
		DrawBorders(P2, 1);
		G.DrawLine(P1, 0, 26, ((Control)this).get_Width(), 26);
		G.DrawLine(P2, 0, 25, ((Control)this).get_Width(), 25);
		checked
		{
			Pad = Math.Max(Measure().Width + 20, 80);
			ref Rectangle r = ref R1;
			r = new Rectangle(Pad, 17, ((Control)this).get_Width() - Pad * 2 + _AccentOffset, 8);
			G.DrawRectangle(P2, R1);
			G.DrawRectangle(P1, R1.X + 1, R1.Y + 1, R1.Width - 2, R1.Height);
			G.DrawLine(P1, 0, 29, ((Control)this).get_Width(), 29);
			G.DrawLine(P2, 0, 30, ((Control)this).get_Width(), 30);
			DrawText(Brushes.get_Black(), (HorizontalAlignment)0, 8, 1);
			DrawText(Brushes.get_White(), (HorizontalAlignment)0, 7, 0);
			G.FillRectangle((Brush)(object)B1, 0, 27, ((Control)this).get_Width(), 2);
			DrawBorders(Pens.get_Black());
		}
	}
}
