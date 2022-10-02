using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DefaultEvent("CheckedChanged")]
internal class Control6 : Control3
{
	public delegate void Delegate3(object sender);

	private static List<WeakReference> list_0;

	private bool bool_5;

	private int int_2;

	private Delegate3 delegate3_0;

	private object object_0;

	private Pen pen_0;

	private Pen pen_1;

	[DebuggerNonUserCode]
	static Control6()
	{
		Class14.vPNVHkezq0oMI();
		list_0 = new List<WeakReference>();
	}

	[DebuggerNonUserCode]
	private static void smethod_0(object object_1)
	{
		checked
		{
			lock (list_0)
			{
				if (list_0.Count == list_0.Capacity)
				{
					int num = 0;
					int num2 = list_0.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = list_0[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								list_0[num] = list_0[num3];
							}
							num++;
						}
						num3++;
					}
					list_0.RemoveRange(num, list_0.Count - num);
					list_0.Capacity = list_0.Count;
				}
				list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_1)));
			}
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	public void method_77(Delegate3 delegate3_1)
	{
		delegate3_0 = (Delegate3)Delegate.Combine(delegate3_0, delegate3_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	public void method_78(Delegate3 delegate3_1)
	{
		delegate3_0 = (Delegate3)Delegate.Remove(delegate3_0, delegate3_1);
	}

	[SpecialName]
	public bool method_79()
	{
		return bool_5;
	}

	[SpecialName]
	public void method_80(bool bool_6)
	{
		bool_5 = bool_6;
		((Control)this).Invalidate();
		delegate3_0?.Invoke(this);
	}

	protected override void ColorHook()
	{
		object_0 = method_20("Text");
		pen_0 = method_18("Border");
		pen_1 = method_18("Inner");
	}

	protected override void OnTextChanged(EventArgs e)
	{
		((Control)this).OnTextChanged(e);
		checked
		{
			int num = (int)Math.Round(((Control)this).CreateGraphics().MeasureString(Text, Font).Width);
			((Control)this).set_Width(30 + num);
		}
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		((Control)this).OnMouseMove(e);
		int_2 = e.get_X();
		((Control)this).Invalidate();
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		base.OnMouseDown(e);
		if (bool_5)
		{
			bool_5 = false;
		}
		else
		{
			bool_5 = true;
		}
	}

	protected override void PaintHook()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		graphics_0.Clear(BackColor);
		graphics_0.set_SmoothingMode((SmoothingMode)2);
		Point point;
		if (bool_5)
		{
			Graphics obj = graphics_0;
			SolidBrush val = new SolidBrush(Color.Orange);
			Rectangle rectangle = new Rectangle(3, 3, 10, 10);
			obj.FillRectangle((Brush)val, rectangle);
			Graphics obj2 = graphics_0;
			Font val2 = new Font("Marlett", 12f);
			Brush black = Brushes.get_Black();
			point = new Point(-2, 0);
			obj2.DrawString("a", val2, black, (PointF)point);
			Graphics obj3 = graphics_0;
			Pen obj4 = pen_1;
			rectangle = new Rectangle(1, 1, 14, 14);
			obj3.DrawRectangle(obj4, rectangle);
			Graphics obj5 = graphics_0;
			Pen obj6 = pen_0;
			rectangle = new Rectangle(0, 0, 16, 16);
			obj5.DrawRectangle(obj6, rectangle);
		}
		else
		{
			Graphics obj7 = graphics_0;
			Pen obj8 = pen_1;
			Rectangle rectangle = new Rectangle(1, 1, 14, 14);
			obj7.DrawRectangle(obj8, rectangle);
			Graphics obj9 = graphics_0;
			Pen obj10 = pen_0;
			rectangle = new Rectangle(0, 0, 16, 16);
			obj9.DrawRectangle(obj10, rectangle);
		}
		if (enum0_0 == (Enum0)1)
		{
			graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(20, Color.Orange)), 3, 3, 10, 10);
		}
		Graphics obj11 = graphics_0;
		string text = Text;
		Font font = Font;
		object obj12 = object_0;
		point = new Point(22, 2);
		obj11.DrawString(text, font, (Brush)obj12, (PointF)point);
	}

	public Control6()
	{
		Class14.vPNVHkezq0oMI();
		base._002Ector();
		smethod_0(this);
		Point point = new Point(50, 17);
		((Control)this).set_Size((Size)point);
		method_22("Text", Color.Orange);
		method_22("Border", Color.Black);
		method_22("Inner", Color.FromArgb(40, 40, 40));
	}
}
