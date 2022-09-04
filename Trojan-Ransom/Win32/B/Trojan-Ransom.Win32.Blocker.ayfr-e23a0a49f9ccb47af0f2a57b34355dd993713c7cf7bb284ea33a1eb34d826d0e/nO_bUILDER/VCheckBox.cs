using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace nO_bUILDER;

internal class VCheckBox : ThemeControl154
{
	private Pen P1;

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

	public VCheckBox()
	{
		((Control)this).add_Click((EventHandler)delegate
		{
			changeChecked();
		});
		_Checked = false;
		BackColor = Color.Transparent;
		Transparent = true;
		Size size = new Size(150, 16);
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
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		P1 = new Pen(Color.FromArgb(0, 0, 0));
		B1 = (Brush)new SolidBrush(Color.FromArgb(15, Color.FromArgb(26, 26, 26)));
		B2 = (Brush)new SolidBrush(Color.White);
		B3 = (Brush)new SolidBrush(Color.FromArgb(0, 0, 0));
	}

	protected override void PaintHook()
	{
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		G.Clear(BackColor);
		G.FillRectangle(B3, 0, 0, 45, 15);
		G.DrawRectangle(P1, 0, 0, 45, 15);
		if (!_Checked)
		{
			G.DrawString("OFF", Font, Brushes.get_Gray(), 3f, 1f);
			Graphics g = G;
			Rectangle rectangle = new Rectangle(29, -1, 13, 16);
			g.FillRectangle((Brush)new LinearGradientBrush(rectangle, Color.FromArgb(35, 35, 35), Color.FromArgb(25, 25, 25), 90f), 29, -1, 13, 16);
		}
		else
		{
			DrawGradient(Color.FromArgb(10, 10, 10), Color.FromArgb(20, 20, 20), 15, 2, 28, 11, 90f);
			G.DrawString("ON", Font, Brushes.get_White(), 18f, 0f);
			Graphics g2 = G;
			Rectangle rectangle = new Rectangle(2, -1, 13, 16);
			g2.FillRectangle((Brush)new LinearGradientBrush(rectangle, Color.FromArgb(80, 80, 80), Color.FromArgb(60, 60, 60), 90f), 2, -1, 13, 16);
		}
		G.FillRectangle(B1, 2, 2, 41, 11);
		DrawText(B2, (HorizontalAlignment)0, 50, 0);
	}
}
