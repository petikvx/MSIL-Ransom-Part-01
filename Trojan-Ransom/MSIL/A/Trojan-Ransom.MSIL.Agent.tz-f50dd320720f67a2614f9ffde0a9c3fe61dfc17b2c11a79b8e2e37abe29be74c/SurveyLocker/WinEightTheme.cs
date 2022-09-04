using System.Drawing;
using System.Windows.Forms;

namespace SurveyLocker;

internal class WinEightTheme : ThemeContainer151
{
	private Color C1;

	private Color C2;

	private Color C3;

	private SolidBrush B1;

	private Pen P1;

	private Pen P2;

	public WinEightTheme()
	{
		MoveHeight = 20;
		SetColor("BackColor", Color.White);
		TransparencyKey = Color.Fuchsia;
	}

	protected override void ColorHook()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		C1 = GetColor("BackColor");
		C2 = Color.FromArgb(0, 162, 255);
		C3 = Color.FromArgb(0, 162, 255);
		P1 = new Pen(Color.FromArgb(90, 90, 50));
		P2 = new Pen(Color.FromArgb(90, 90, 90));
	}

	protected override void PaintHook()
	{
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		G.Clear(C1);
		DrawGradient(Color.FromArgb(15, 15, 15), Color.FromArgb(30, 30, 30), 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height(), 90f);
		DrawGradient(C2, C3, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
		G.DrawLine(P1, 0, 0, 0, 20);
		checked
		{
			G.DrawLine(P1, ((Control)this).get_Width() - 1, 0, ((Control)this).get_Width() - 1, 25);
			G.DrawLine(P2, 0, 0, 0, ((Control)this).get_Height());
			G.DrawLine(P2, ((Control)this).get_Width() - 1, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height());
			G.DrawLine(P2, 0, ((Control)this).get_Height() - 1, ((Control)this).get_Width(), ((Control)this).get_Height() - 1);
			G.FillRectangle((Brush)new SolidBrush(Color.FromArgb(240, 240, 240)), 10, 20, ((Control)this).get_Width() - 20, ((Control)this).get_Height() - 30);
			G.DrawLine(P2, 0, 0, ((Control)this).get_Width(), 0);
			DrawText(Brushes.get_White(), (HorizontalAlignment)2, 0, 0);
		}
	}
}
