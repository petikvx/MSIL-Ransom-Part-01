using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DefaultEvent("CheckedChanged")]
internal class Control5 : Control2
{
	public delegate void Delegate2(object sender);

	private static List<WeakReference> list_0;

	private bool bool_6;

	private int int_2;

	private Delegate2 delegate2_0;

	public event Delegate2 Event_0
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			delegate2_0 = (Delegate2)Delegate.Combine(delegate2_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			delegate2_0 = (Delegate2)Delegate.Remove(delegate2_0, value);
		}
	}

	[DebuggerNonUserCode]
	static Control5()
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
		((Control)this).Invalidate();
		delegate2_0?.Invoke(this);
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

	protected override void OnMouseMove(MouseEventArgs e)
	{
		((Control)this).OnMouseMove(e);
		int_2 = e.get_X();
		((Control)this).Invalidate();
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		base.OnMouseDown(e);
		if (bool_6)
		{
			bool_6 = false;
		}
		else
		{
			bool_6 = true;
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
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		graphics_0.Clear(Color.FromArgb(60, 60, 60));
		HatchBrush val = new HatchBrush((HatchStyle)20, Color.FromArgb(35, Color.Black), Color.FromArgb(0, Color.Gray));
		Graphics obj = graphics_0;
		SolidBrush val2 = new SolidBrush(Color.FromArgb(60, 60, 60));
		Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
		obj.FillRectangle((Brush)val2, rectangle);
		val = new HatchBrush((HatchStyle)18, Color.DimGray);
		graphics_0.FillRectangle((Brush)(object)val, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
		graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(230, 20, 20, 20)), 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
		graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(10, 10, 10)), 3, 3, 10, 10);
		if (bool_6)
		{
			ColorBlend val3 = new ColorBlend(2);
			ref Color reference = ref val3.get_Colors()[0];
			reference = Color.FromArgb(60, 60, 60);
			ref Color reference2 = ref val3.get_Colors()[1];
			reference2 = Color.FromArgb(80, 80, 80);
			val3.get_Positions()[0] = 0f;
			val3.get_Positions()[1] = 1f;
			rectangle = new Rectangle(3, 3, 10, 10);
			method_64(val3, rectangle);
			ref Color reference3 = ref val3.get_Colors()[0];
			reference3 = Color.FromArgb(70, 70, 70);
			ref Color reference4 = ref val3.get_Colors()[1];
			reference4 = Color.FromArgb(100, 100, 100);
			rectangle = new Rectangle(3, 3, 10, 4);
			method_64(val3, rectangle);
			HatchBrush val4 = new HatchBrush((HatchStyle)18, Color.FromArgb(60, Color.Black), Color.FromArgb(0, Color.Gray));
			graphics_0.FillRectangle((Brush)(object)val4, 3, 3, 10, 10);
		}
		else
		{
			HatchBrush val5 = new HatchBrush((HatchStyle)18, Color.FromArgb(20, Color.White), Color.FromArgb(0, Color.Gray));
			graphics_0.FillRectangle((Brush)(object)val5, 3, 3, 10, 10);
		}
		if ((enum0_0 == (Enum0)1) & (int_2 < 15))
		{
			Graphics obj2 = graphics_0;
			SolidBrush val6 = new SolidBrush(Color.FromArgb(30, Color.Gray));
			rectangle = new Rectangle(3, 3, 10, 10);
			obj2.FillRectangle((Brush)val6, rectangle);
		}
		else if (enum0_0 == (Enum0)2)
		{
			Graphics obj3 = graphics_0;
			SolidBrush val7 = new SolidBrush(Color.FromArgb(30, Color.Black));
			rectangle = new Rectangle(3, 3, 10, 10);
			obj3.FillRectangle((Brush)val7, rectangle);
		}
		graphics_0.DrawRectangle(Pens.get_Black(), 0, 0, 15, 15);
		graphics_0.DrawRectangle(new Pen(Color.FromArgb(90, 90, 90)), 1, 1, 13, 13);
		graphics_0.DrawString(Text, Font, Brushes.get_White(), 17f, 1f);
	}

	public Control5()
	{
		Class14.hYiyYvszsKHjE();
		base._002Ector();
		smethod_0(this);
		Point point = new Point(16, 50);
		((Control)this).set_Size((Size)point);
	}
}
