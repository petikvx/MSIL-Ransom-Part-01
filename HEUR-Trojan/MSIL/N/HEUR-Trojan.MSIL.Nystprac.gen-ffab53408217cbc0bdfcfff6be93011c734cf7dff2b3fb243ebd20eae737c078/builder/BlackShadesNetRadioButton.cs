using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace builder;

[DefaultEvent("CheckedChanged")]
public class BlackShadesNetRadioButton : Control
{
	public delegate void CheckedChangedEventHandler(object sender);

	private static List<WeakReference> list_0;

	private Rectangle rectangle_0;

	private LinearGradientBrush linearGradientBrush_0;

	private Enum0 enum0_0;

	private bool bool_0;

	private CheckedChangedEventHandler checkedChangedEventHandler_0;

	public bool Checked
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
			method_0();
			checkedChangedEventHandler_0?.Invoke(this);
			((Control)this).Invalidate();
		}
	}

	public event CheckedChangedEventHandler CheckedChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			checkedChangedEventHandler_0 = (CheckedChangedEventHandler)Delegate.Combine(checkedChangedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			checkedChangedEventHandler_0 = (CheckedChangedEventHandler)Delegate.Remove(checkedChangedEventHandler_0, value);
		}
	}

	[DebuggerNonUserCode]
	static BlackShadesNetRadioButton()
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

	protected override void OnMouseEnter(EventArgs e)
	{
		((Control)this).OnMouseEnter(e);
		enum0_0 = (Enum0)1;
		((Control)this).Invalidate();
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		((Control)this).OnMouseDown(e);
		enum0_0 = (Enum0)2;
		((Control)this).Invalidate();
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((Control)this).OnMouseLeave(e);
		enum0_0 = (Enum0)0;
		((Control)this).Invalidate();
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		((Control)this).OnMouseUp(e);
		enum0_0 = (Enum0)1;
		((Control)this).Invalidate();
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		((Control)this).set_Height(16);
	}

	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
	}

	protected override void OnTextChanged(EventArgs e)
	{
		((Control)this).OnTextChanged(e);
		((Control)this).Invalidate();
	}

	protected override void OnClick(EventArgs e)
	{
		if (!bool_0)
		{
			Checked = true;
		}
		((Control)this).OnClick(e);
	}

	protected override void OnCreateControl()
	{
		((Control)this).OnCreateControl();
		method_0();
	}

	private void method_0()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		if ((!((Control)this).get_IsHandleCreated() || !bool_0) ? true : false)
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
				if ((val != this && val is BlackShadesNetRadioButton) ? true : false)
				{
					((BlackShadesNetRadioButton)(object)val).Checked = false;
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

	public BlackShadesNetRadioButton()
	{
		Class14.hYiyYvszsKHjE();
		((Control)this)._002Ector();
		smethod_0(this);
		enum0_0 = (Enum0)0;
		((Control)this).set_BackColor(Color.FromArgb(42, 47, 49));
		((Control)this).set_ForeColor(Color.White);
		Size size = new Size(150, 16);
		((Control)this).set_Size(size);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		new Class10();
		checked
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Height() - 1, ((Control)this).get_Height() - 1);
			val2.set_SmoothingMode((SmoothingMode)2);
			val2.Clear(((Control)this).get_BackColor());
			LinearGradientBrush val3 = new LinearGradientBrush(rectangle, Color.FromArgb(36, 40, 42), Color.FromArgb(66, 70, 72), 90f);
			val2.FillEllipse((Brush)(object)val3, rectangle);
			Pen val4 = new Pen(Color.FromArgb(44, 48, 50));
			Rectangle rectangle2 = new Rectangle(1, 1, ((Control)this).get_Height() - 3, ((Control)this).get_Height() - 3);
			val2.DrawEllipse(val4, rectangle2);
			val2.DrawEllipse(new Pen(Color.FromArgb(102, 108, 112)), rectangle);
			if (Checked)
			{
				rectangle2 = new Rectangle(4, 4, ((Control)this).get_Height() - 9, ((Control)this).get_Height() - 8);
				LinearGradientBrush val5 = new LinearGradientBrush(rectangle2, Color.White, Color.Black, 90f);
				rectangle2 = new Rectangle(4, 4, ((Control)this).get_Height() - 9, ((Control)this).get_Height() - 9);
				val2.FillEllipse((Brush)(object)val5, rectangle2);
			}
			string text = ((Control)this).get_Text();
			Font font = ((Control)this).get_Font();
			Brush white = Brushes.get_White();
			Point point = new Point(18, 0);
			PointF pointF = point;
			StringFormat val6 = new StringFormat();
			val6.set_Alignment((StringAlignment)0);
			val6.set_LineAlignment((StringAlignment)0);
			val2.DrawString(text, font, white, pointF, val6);
			NewLateBinding.LateCall((object)e.get_Graphics(), (Type)null, "DrawImage", new object[3]
			{
				RuntimeHelpers.GetObjectValue(((Image)val).Clone()),
				0,
				0
			}, (string[])null, (Type[])null, (bool[])null, true);
			val2.Dispose();
			((Image)val).Dispose();
		}
	}
}
