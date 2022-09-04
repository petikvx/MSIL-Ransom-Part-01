using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace VI_Theme_Dll_By_xVenoxi;

public class VIToggle : ThemeControl154
{
	private Pen P1;

	private Pen P2;

	private Brush B1;

	private Brush B2;

	private Brush B3;

	private bool _Checked;

	public bool Checked
	{
		get
		{
			return _Checked;
		}
		set
		{
			_Checked = value;
			((Control)this).Invalidate();
		}
	}

	public VIToggle()
	{
		((Control)this).add_Click((EventHandler)delegate
		{
			changeChecked();
		});
		_Checked = false;
		BackColor = Color.Transparent;
		Transparent = true;
		Size size = new Size(120, 25);
		((Control)this).set_Size(size);
	}

	public void changeChecked()
	{
		switch (_Checked)
		{
		case false:
			_Checked = true;
			break;
		case true:
			_Checked = false;
			break;
		}
	}

	protected override void ColorHook()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		P1 = new Pen(Color.FromArgb(0, 0, 0));
		P2 = new Pen(Color.FromArgb(24, 24, 24));
		B1 = (Brush)new SolidBrush(Color.FromArgb(15, Color.FromArgb(26, 26, 26)));
		B2 = (Brush)new SolidBrush(Color.White);
		B3 = (Brush)new SolidBrush(Color.FromArgb(0, 0, 0));
	}

	protected override void PaintHook()
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		G.Clear(BackColor);
		if (!_Checked)
		{
			G.FillRectangle(B3, 4, 4, 45, 15);
			G.DrawRectangle(P1, 4, 4, 45, 15);
			G.DrawRectangle(P2, 5, 5, 43, 13);
			G.DrawString("OFF", Font, Brushes.get_Gray(), 7f, 5f);
			Graphics g = G;
			Rectangle rectangle = new Rectangle(32, 2, 13, 19);
			g.FillRectangle((Brush)new LinearGradientBrush(rectangle, Color.FromArgb(35, 35, 35), Color.FromArgb(25, 25, 25), 90f), 32, 2, 13, 19);
			G.DrawRectangle(P2, 32, 2, 13, 19);
			G.DrawRectangle(P1, 33, 3, 11, 17);
			G.DrawRectangle(P1, 31, 1, 15, 21);
		}
		else
		{
			G.FillRectangle(B3, 4, 4, 45, 15);
			G.DrawRectangle(P1, 4, 4, 45, 15);
			G.DrawRectangle(P2, 5, 5, 43, 13);
			G.DrawString("ON", Font, Brushes.get_White(), 23f, 5f);
			Graphics g2 = G;
			Rectangle rectangle = new Rectangle(8, 2, 13, 19);
			g2.FillRectangle((Brush)new LinearGradientBrush(rectangle, Color.FromArgb(80, 80, 80), Color.FromArgb(60, 60, 60), 90f), 8, 2, 13, 19);
			G.DrawRectangle(P2, 8, 2, 13, 19);
			G.DrawRectangle(P1, 9, 3, 11, 17);
			G.DrawRectangle(P1, 7, 1, 15, 21);
		}
		G.FillRectangle(B1, 2, 2, 41, 11);
		DrawText(B2, (HorizontalAlignment)0, 50, 0);
	}
}
