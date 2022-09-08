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
internal class Control6 : Control2
{
	public delegate void Delegate3(object sender);

	private static List<WeakReference> list_0;

	private int int_2;

	private bool bool_6;

	private Delegate3 delegate3_0;

	public event Delegate3 Event_0
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			delegate3_0 = (Delegate3)Delegate.Combine(delegate3_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			delegate3_0 = (Delegate3)Delegate.Remove(delegate3_0, value);
		}
	}

	[DebuggerNonUserCode]
	static Control6()
	{
		Class14.hYiyYvszsKHjE();
		list_0 = new List<WeakReference>();
	}

	[DebuggerNonUserCode]
	private static void smethod_0(object object_0)
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
				list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
			}
		}
	}

	[SpecialName]
	public bool method_82()
	{
		return bool_6;
	}

	[SpecialName]
	public void method_83(bool bool_7)
	{
		bool_6 = bool_7;
		method_84();
		delegate3_0?.Invoke(this);
		((Control)this).Invalidate();
	}

	protected override void OnCreation()
	{
		method_84();
	}

	private void method_84()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		if ((!((Control)this).get_IsHandleCreated() || !bool_6) ? true : false)
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
				if ((val != this && val is Control6) ? true : false)
				{
					((Control6)(object)val).method_83(bool_7: false);
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
		if (!bool_6)
		{
			method_83(bool_7: true);
		}
		base.OnMouseDown(e);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		((Control)this).OnMouseMove(e);
		int_2 = e.get_X();
		((Control)this).Invalidate();
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
			((Control)this).set_Width(20 + num);
		}
	}

	protected override void PaintHook()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected O, but got Unknown
		graphics_0.Clear(Color.FromArgb(60, 60, 60));
		HatchBrush val = new HatchBrush((HatchStyle)20, Color.FromArgb(35, Color.Black), Color.FromArgb(0, Color.Gray));
		Graphics obj = graphics_0;
		SolidBrush val2 = new SolidBrush(Color.FromArgb(60, 60, 60));
		Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
		obj.FillRectangle((Brush)val2, rectangle);
		val = new HatchBrush((HatchStyle)18, Color.DimGray);
		graphics_0.FillRectangle((Brush)(object)val, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
		graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(230, 20, 20, 20)), 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
		graphics_0.set_SmoothingMode((SmoothingMode)4);
		graphics_0.FillEllipse((Brush)new SolidBrush(Color.Black), 2, 2, 11, 11);
		graphics_0.DrawEllipse(Pens.get_Black(), 0, 0, 13, 13);
		graphics_0.DrawEllipse(new Pen(Color.FromArgb(90, 90, 90)), 1, 1, 11, 11);
		if (!bool_6)
		{
			HatchBrush val3 = new HatchBrush((HatchStyle)18, Color.FromArgb(20, Color.White), Color.FromArgb(0, Color.Gray));
			graphics_0.FillEllipse((Brush)(object)val3, 2, 2, 10, 10);
		}
		else
		{
			graphics_0.FillEllipse((Brush)new SolidBrush(Color.FromArgb(80, 80, 80)), 3, 3, 7, 7);
			HatchBrush val4 = new HatchBrush((HatchStyle)18, Color.FromArgb(60, Color.Black), Color.FromArgb(0, Color.Gray));
			graphics_0.FillRectangle((Brush)(object)val4, 3, 3, 7, 7);
		}
		if ((enum0_0 == (Enum0)1) & (int_2 < 13))
		{
			graphics_0.FillEllipse((Brush)new SolidBrush(Color.FromArgb(20, Color.White)), 2, 2, 11, 11);
		}
		graphics_0.DrawString(Text, Font, Brushes.get_White(), 16f, 0f);
	}

	public Control6()
	{
		Class14.hYiyYvszsKHjE();
		base._002Ector();
		smethod_0(this);
		Point point = new Point(50, 14);
		((Control)this).set_Size((Size)point);
	}
}
