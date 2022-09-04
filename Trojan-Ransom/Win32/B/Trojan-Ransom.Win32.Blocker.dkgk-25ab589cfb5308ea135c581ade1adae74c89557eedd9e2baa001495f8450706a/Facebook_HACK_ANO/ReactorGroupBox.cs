using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Facebook_HACK_ANO;

public class ReactorGroupBox : ContainerControl
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

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

	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
	}

	protected override void OnTextChanged(EventArgs e)
	{
		((Control)this).OnTextChanged(e);
		((Control)this).Invalidate();
	}

	public ReactorGroupBox()
	{
		__ENCAddToList(this);
		((Control)this).set_BackColor(Color.FromArgb(33, 33, 33));
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		((Control)this).OnPaint(e);
		Graphics graphics = e.get_Graphics();
		graphics.Clear(((Control)this).get_BackColor());
		graphics.set_SmoothingMode((SmoothingMode)2);
		Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), 24);
		LinearGradientBrush val = new LinearGradientBrush(rectangle, Color.FromArgb(10, 10, 10), Color.FromArgb(50, 50, 50), 90f);
		rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), 24);
		graphics.FillRectangle((Brush)(object)val, rectangle);
		rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), 12);
		LinearGradientBrush val2 = new LinearGradientBrush(rectangle, Color.FromArgb(60, Color.White), Color.FromArgb(20, Color.White), 90f);
		rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), 12);
		graphics.FillRectangle((Brush)(object)val2, rectangle);
		graphics.DrawLine(Pens.get_Black(), 0, 24, ((Control)this).get_Width(), 24);
		Pen val3 = new Pen((Brush)new SolidBrush(Color.Black));
		checked
		{
			rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3);
			graphics.DrawRectangle(val3, rectangle);
			Pen val4 = new Pen((Brush)new SolidBrush(Color.FromArgb(70, 70, 70)));
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			graphics.DrawRectangle(val4, rectangle);
			graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(45, 45, 45))), 0, 0, ((Control)this).get_Width(), 0);
			graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(45, 45, 45))), 0, 0, 0, ((Control)this).get_Height());
			graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(45, 45, 45))), ((Control)this).get_Width() - 1, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height());
			graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(31, 31, 31))), 2, 2, ((Control)this).get_Width() - 3, 2);
			graphics.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), Brushes.get_Black(), (float)((double)((Control)this).get_Width() / 2.0 - (double)(3 * ((Control)this).get_Text().Length) + 1.0), 6f);
			graphics.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), Brushes.get_White(), (float)((double)((Control)this).get_Width() / 2.0 - (double)(3 * ((Control)this).get_Text().Length) + 1.0), 7f);
		}
	}
}
