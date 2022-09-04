using System.Drawing;
using System.Windows.Forms;

namespace SurveyLocker;

internal class WinEightButton : ThemeControl151
{
	private Color C1;

	private Color C2;

	private Color C3;

	private Pen P1;

	public WinEightButton()
	{
		SetColor("BackColor", Color.Black);
	}

	protected override void ColorHook()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		C1 = GetColor("BackColor");
		C2 = Color.FromArgb(230, 230, 230);
		C3 = Color.FromArgb(239, 239, 239);
		P1 = new Pen(Color.FromArgb(172, 172, 172));
	}

	protected override void PaintHook()
	{
		G.Clear(C1);
		if (State == MouseState.Over)
		{
			DrawGradient(C2, C3, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
		}
		else if (State == MouseState.Down)
		{
			DrawGradient(C3, C2, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
		}
		else
		{
			DrawGradient(C3, C2, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
		}
		DrawBorders(P1, ((Control)this).get_ClientRectangle());
		DrawText(Brushes.get_Black(), (HorizontalAlignment)2, 0, 0);
	}
}
