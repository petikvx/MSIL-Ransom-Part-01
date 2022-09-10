using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace NoobCrypt2._0;

internal class NSButton : Control
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private bool IsMouseDown;

	private GraphicsPath GP1;

	private GraphicsPath GP2;

	private SizeF SZ1;

	private PointF PT1;

	private Pen P1;

	private Pen P2;

	private PathGradientBrush PB1;

	private LinearGradientBrush GB1;

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

	public NSButton()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		__ENCAddToList(this);
		((Control)this).SetStyle((ControlStyles)139286, true);
		((Control)this).SetStyle((ControlStyles)512, false);
		P1 = new Pen(Color.FromArgb(35, 35, 35));
		P2 = new Pen(Color.FromArgb(65, 65, 65));
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		ThemeModule.G = e.get_Graphics();
		ThemeModule.G.set_TextRenderingHint((TextRenderingHint)5);
		ThemeModule.G.Clear(((Control)this).get_BackColor());
		ThemeModule.G.set_SmoothingMode((SmoothingMode)4);
		ref PointF pT;
		checked
		{
			GP1 = ThemeModule.CreateRound(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1, 7);
			GP2 = ThemeModule.CreateRound(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3, 7);
			if (IsMouseDown)
			{
				PB1 = new PathGradientBrush(GP1);
				PB1.set_CenterColor(Color.FromArgb(60, 60, 60));
				PB1.set_SurroundColors(new Color[1] { Color.FromArgb(55, 55, 55) });
				PathGradientBrush pB = PB1;
				PointF focusScales = new PointF(0.8f, 0.5f);
				pB.set_FocusScales(focusScales);
				ThemeModule.G.FillPath((Brush)(object)PB1, GP1);
			}
			else
			{
				GB1 = new LinearGradientBrush(((Control)this).get_ClientRectangle(), Color.FromArgb(60, 60, 60), Color.FromArgb(55, 55, 55), 90f);
				ThemeModule.G.FillPath((Brush)(object)GB1, GP1);
			}
			ThemeModule.G.DrawPath(P1, GP1);
			ThemeModule.G.DrawPath(P2, GP2);
			SZ1 = ThemeModule.G.MeasureString(((Control)this).get_Text(), ((Control)this).get_Font());
			pT = ref PT1;
		}
		pT = new PointF(5f, (float)(((Control)this).get_Height() / 2) - SZ1.Height / 2f);
		if (IsMouseDown)
		{
			PT1.X += 1f;
			PT1.Y += 1f;
		}
		ThemeModule.G.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), Brushes.get_Black(), PT1.X + 1f, PT1.Y + 1f);
		ThemeModule.G.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), Brushes.get_White(), PT1);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		IsMouseDown = true;
		((Control)this).Invalidate();
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		IsMouseDown = false;
		((Control)this).Invalidate();
	}
}
