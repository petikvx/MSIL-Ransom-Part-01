using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DefaultEvent("CheckedChanged")]
internal class Control5 : Control3
{
	public delegate void Delegate2(object sender);

	private static List<WeakReference> list_0;

	private int fXvqcGejsa;

	private bool bool_5;

	private Delegate2 delegate2_0;

	private object object_0;

	private Pen pen_0;

	private Pen pen_1;

	[DebuggerNonUserCode]
	static Control5()
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

	[SpecialName]
	public bool method_77()
	{
		return bool_5;
	}

	[SpecialName]
	public void method_78(bool bool_6)
	{
		bool_5 = bool_6;
		method_81();
		delegate2_0?.Invoke(this);
		((Control)this).Invalidate();
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	public void method_79(Delegate2 delegate2_1)
	{
		delegate2_0 = (Delegate2)Delegate.Combine(delegate2_0, delegate2_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	public void method_80(Delegate2 delegate2_1)
	{
		delegate2_0 = (Delegate2)Delegate.Remove(delegate2_0, delegate2_1);
	}

	protected override void OnCreation()
	{
		method_81();
	}

	private void method_81()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		if ((!((Control)this).get_IsHandleCreated() || !bool_5) ? true : false)
		{
			return;
		}
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((Control)this).get_Parent().get_Controls().GetEnumerator();
			while (enumerator.MoveNext())
			{
				Control val = (Control)enumerator.Current;
				if ((val != this && val is Control5) ? true : false)
				{
					((Control5)(object)val).method_78(bool_6: false);
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
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		if (!bool_5)
		{
			method_78(bool_6: true);
		}
		base.OnMouseDown(e);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		((Control)this).OnMouseMove(e);
		fXvqcGejsa = e.get_X();
		((Control)this).Invalidate();
	}

	protected override void ColorHook()
	{
		object_0 = method_20("Text");
		pen_0 = method_18("Circle");
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

	protected override void PaintHook()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		graphics_0.Clear(BackColor);
		graphics_0.set_SmoothingMode((SmoothingMode)2);
		if (bool_5)
		{
			Graphics obj = graphics_0;
			Pen obj2 = pen_0;
			Rectangle rectangle = new Rectangle(0, 0, 16, 16);
			obj.DrawEllipse(obj2, rectangle);
			Graphics obj3 = graphics_0;
			Pen obj4 = pen_1;
			rectangle = new Rectangle(1, 1, 14, 14);
			obj3.DrawEllipse(obj4, rectangle);
			Graphics obj5 = graphics_0;
			SolidBrush val = new SolidBrush(Color.DarkOrange);
			rectangle = new Rectangle(5, 5, 6, 6);
			obj5.FillEllipse((Brush)val, rectangle);
		}
		else
		{
			Graphics obj6 = graphics_0;
			Pen obj7 = pen_0;
			Rectangle rectangle = new Rectangle(0, 0, 16, 16);
			obj6.DrawEllipse(obj7, rectangle);
			Graphics obj8 = graphics_0;
			Pen obj9 = pen_1;
			rectangle = new Rectangle(1, 1, 14, 14);
			obj8.DrawEllipse(obj9, rectangle);
		}
		if (enum0_0 == (Enum0)1)
		{
			graphics_0.FillEllipse((Brush)new SolidBrush(Color.FromArgb(20, Color.Orange)), 5, 5, 6, 6);
		}
		Graphics obj10 = graphics_0;
		string text = Text;
		Font font = Font;
		object obj11 = object_0;
		Point point = new Point(22, 2);
		obj10.DrawString(text, font, (Brush)obj11, (PointF)point);
	}

	public Control5()
	{
		Class14.vPNVHkezq0oMI();
		base._002Ector();
		smethod_0(this);
		Point point = new Point(50, 17);
		((Control)this).set_Size((Size)point);
		method_22("Text", Color.Orange);
		method_22("Circle", Color.Black);
		method_22("Inner", Color.FromArgb(40, 40, 40));
	}
}
