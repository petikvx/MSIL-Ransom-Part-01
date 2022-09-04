using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using nO_bUILDER.My;

namespace nO_bUILDER;

internal class VRadiobutton : ThemeControl154
{
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

	public VRadiobutton()
	{
		BackColor = Color.Transparent;
		Transparent = true;
		Point point = new Point(50, 17);
		((Control)this).set_Size((Size)point);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	protected override void OnClick(EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		((Control)this).OnClick(e);
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((Control)this).get_Parent().get_Controls().GetEnumerator();
			while (enumerator.MoveNext())
			{
				Control val = (Control)enumerator.Current;
				if (Operators.CompareString(((object)val).GetType().ToString(), Strings.Replace(((ApplicationBase)MyProject.Application).get_Info().get_ProductName(), " ", "_", 1, -1, (CompareMethod)0) + ".VRadiobutton", false) == 0)
				{
					VRadiobutton vRadiobutton = (VRadiobutton)(object)val;
					vRadiobutton.Checked = false;
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		_Checked = true;
	}

	protected override void ColorHook()
	{
	}

	protected override void OnTextChanged(EventArgs e)
	{
		((Control)this).OnTextChanged(e);
		checked
		{
			int num = (int)Math.Round(((Control)this).CreateGraphics().MeasureString(Text, Font).Width);
			((Control)this).set_Width(25 + num);
		}
	}

	protected override void PaintHook()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		G.Clear(BackColor);
		G.set_SmoothingMode((SmoothingMode)4);
		if (!_Checked)
		{
			G.FillEllipse((Brush)new SolidBrush(Color.Black), 0, 0, 16, 16);
			Rectangle rectangle = new Rectangle(1, 1, 14, 14);
			LinearGradientBrush val = new LinearGradientBrush(rectangle, Color.FromArgb(24, 30, 36), Color.FromArgb(25, 25, 25), 90f);
			Graphics g = G;
			LinearGradientBrush obj = val;
			rectangle = new Rectangle(1, 1, 14, 14);
			g.FillEllipse((Brush)(object)obj, rectangle);
			rectangle = new Rectangle(2, 2, 12, 12);
			val = new LinearGradientBrush(rectangle, Color.FromArgb(12, 12, 12), Color.FromArgb(25, 25, 25), 90f);
			Graphics g2 = G;
			LinearGradientBrush obj2 = val;
			rectangle = new Rectangle(2, 2, 12, 12);
			g2.FillEllipse((Brush)(object)obj2, rectangle);
		}
		else
		{
			G.FillEllipse((Brush)new SolidBrush(Color.Black), 0, 0, 16, 16);
			Rectangle rectangle = new Rectangle(1, 1, 14, 14);
			LinearGradientBrush val2 = new LinearGradientBrush(rectangle, Color.FromArgb(45, 45, 45), Color.FromArgb(10, 10, 10), 90f);
			Graphics g3 = G;
			LinearGradientBrush obj3 = val2;
			rectangle = new Rectangle(1, 1, 14, 14);
			g3.FillEllipse((Brush)(object)obj3, rectangle);
			rectangle = new Rectangle(2, 2, 12, 12);
			val2 = new LinearGradientBrush(rectangle, Color.FromArgb(25, 25, 25), Color.FromArgb(20, 20, 20), 90f);
			Graphics g4 = G;
			LinearGradientBrush obj4 = val2;
			rectangle = new Rectangle(2, 2, 12, 12);
			g4.FillEllipse((Brush)(object)obj4, rectangle);
			Graphics g5 = G;
			Brush black = Brushes.get_Black();
			rectangle = new Rectangle(5, 6, 5, 5);
			g5.FillEllipse(black, rectangle);
			rectangle = new Rectangle(1, 1, 14, 14);
			LinearGradientBrush val3 = new LinearGradientBrush(rectangle, Color.FromArgb(130, 130, 130), Color.FromArgb(20, 20, 20), (LinearGradientMode)2);
			Graphics g6 = G;
			rectangle = new Rectangle(3, 3, 10, 10);
			g6.FillEllipse((Brush)(object)val3, rectangle);
		}
		G.DrawString(Text, Font, Brushes.get_White(), 22f, 2f);
	}
}
