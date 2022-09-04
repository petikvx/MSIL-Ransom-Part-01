using System.Drawing;
using System.Windows.Forms;

namespace SurveyLocker;

internal class WinEightMinimizeButton : ThemeControl151
{
	private Color C1;

	private Color C2;

	private Color C3;

	public WinEightMinimizeButton()
	{
		SetColor("BackColor", Color.Black);
	}

	protected override void ColorHook()
	{
		C1 = GetColor("BackColor");
		C2 = Color.FromArgb(80, 199, 84);
		C3 = Color.FromArgb(80, 199, 84);
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
		DrawText(Brushes.get_White(), (HorizontalAlignment)2, 0, 0);
	}
}
