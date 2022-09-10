using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace NoobCrypt2._0;

internal class NSGroupBox : ContainerControl
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private bool _DrawSeperator;

	private string _Title;

	private string _SubTitle;

	private Font _TitleFont;

	private Font _SubTitleFont;

	private GraphicsPath GP1;

	private GraphicsPath GP2;

	private PointF PT1;

	private SizeF SZ1;

	private SizeF SZ2;

	private Pen P1;

	private Pen P2;

	private SolidBrush B1;

	public bool DrawSeperator
	{
		get
		{
			return _DrawSeperator;
		}
		set
		{
			_DrawSeperator = value;
			((Control)this).Invalidate();
		}
	}

	public string Title
	{
		get
		{
			return _Title;
		}
		set
		{
			_Title = value;
			((Control)this).Invalidate();
		}
	}

	public string SubTitle
	{
		get
		{
			return _SubTitle;
		}
		set
		{
			_SubTitle = value;
			((Control)this).Invalidate();
		}
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	public NSGroupBox()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		__ENCAddToList(this);
		_Title = "GroupBox";
		_SubTitle = "Details";
		((Control)this).SetStyle((ControlStyles)139286, true);
		((Control)this).SetStyle((ControlStyles)512, false);
		_TitleFont = new Font("Verdana", 10f);
		_SubTitleFont = new Font("Verdana", 6.5f);
		P1 = new Pen(Color.FromArgb(35, 35, 35));
		P2 = new Pen(Color.FromArgb(55, 55, 55));
		B1 = new SolidBrush(Color.FromArgb(205, 150, 0));
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		ThemeModule.G = e.get_Graphics();
		ThemeModule.G.set_TextRenderingHint((TextRenderingHint)5);
		ThemeModule.G.Clear(((Control)this).get_BackColor());
		ThemeModule.G.set_SmoothingMode((SmoothingMode)4);
		checked
		{
			GP1 = ThemeModule.CreateRound(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1, 7);
			GP2 = ThemeModule.CreateRound(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3, 7);
			ThemeModule.G.DrawPath(P1, GP1);
			ThemeModule.G.DrawPath(P2, GP2);
			SZ1 = ThemeModule.G.MeasureString(_Title, _TitleFont, ((Control)this).get_Width(), StringFormat.get_GenericTypographic());
			SZ2 = ThemeModule.G.MeasureString(_SubTitle, _SubTitleFont, ((Control)this).get_Width(), StringFormat.get_GenericTypographic());
			ThemeModule.G.DrawString(_Title, _TitleFont, Brushes.get_Black(), 6f, 6f);
			ThemeModule.G.DrawString(_Title, _TitleFont, (Brush)(object)B1, 5f, 5f);
			ref PointF pT = ref PT1;
			pT = new PointF(6f, SZ1.Height + 4f);
			ThemeModule.G.DrawString(_SubTitle, _SubTitleFont, Brushes.get_Black(), PT1.X + 1f, PT1.Y + 1f);
			ThemeModule.G.DrawString(_SubTitle, _SubTitleFont, Brushes.get_White(), PT1.X, PT1.Y);
			if (_DrawSeperator)
			{
				int num = (int)Math.Round(PT1.Y + SZ2.Height) + 8;
				ThemeModule.G.DrawLine(P1, 4, num, ((Control)this).get_Width() - 5, num);
				ThemeModule.G.DrawLine(P2, 4, num + 1, ((Control)this).get_Width() - 5, num + 1);
			}
		}
	}
}
