using System;
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
public class BlackShadesNetCheckBox : Control
{
	public delegate void CheckedChangedEventHandler(object sender);

	private static List<WeakReference> list_0;

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
	static BlackShadesNetCheckBox()
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

	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
	}

	protected override void OnTextChanged(EventArgs e)
	{
		((Control)this).OnTextChanged(e);
		((Control)this).Invalidate();
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		((Control)this).set_Height(14);
	}

	protected override void OnClick(EventArgs e)
	{
		bool_0 = !bool_0;
		checkedChangedEventHandler_0?.Invoke(this);
		((Control)this).OnClick(e);
	}

	public BlackShadesNetCheckBox()
	{
		Class14.hYiyYvszsKHjE();
		((Control)this)._002Ector();
		smethod_0(this);
		enum0_0 = (Enum0)0;
		((Control)this).set_BackColor(Color.FromArgb(20, 20, 20));
		((Control)this).set_ForeColor(Color.White);
		Size size = new Size(145, 16);
		((Control)this).set_Size(size);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected O, but got Unknown
		//IL_02ad: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		new Class10();
		checked
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Height() - 1, ((Control)this).get_Height() - 1);
			val2.Clear(Color.FromArgb(42, 47, 49));
			LinearGradientBrush val3 = new LinearGradientBrush(rectangle, Color.FromArgb(36, 40, 42), Color.FromArgb(64, 71, 74), 90f);
			val2.FillRectangle((Brush)(object)val3, val3.get_Rectangle());
			Pen val4 = new Pen(Color.FromArgb(42, 47, 49));
			Rectangle rectangle2 = new Rectangle(1, 1, ((Control)this).get_Height() - 3, ((Control)this).get_Height() - 3);
			val2.DrawRectangle(val4, rectangle2);
			val2.DrawRectangle(new Pen(Color.FromArgb(102, 108, 112)), rectangle);
			Point point3;
			if (Checked)
			{
				Rectangle rectangle3 = new Rectangle((int)Math.Round((double)rectangle.X + (double)rectangle.Width / 4.0), (int)Math.Round((double)rectangle.Y + (double)rectangle.Height / 4.0), unchecked(rectangle.Width / 2), unchecked(rectangle.Height / 2));
				Point[] array = new Point[3];
				ref Point reference = ref array[0];
				Point point = (reference = new Point(rectangle3.X, rectangle3.Y + unchecked(rectangle3.Height / 2)));
				ref Point reference2 = ref array[1];
				Point point2 = (reference2 = new Point(rectangle3.X + unchecked(rectangle3.Width / 2), rectangle3.Y + rectangle3.Height));
				ref Point reference3 = ref array[2];
				point3 = (reference3 = new Point(rectangle3.X + rectangle3.Width, rectangle3.Y));
				Point[] array2 = array;
				val2.set_SmoothingMode((SmoothingMode)2);
				Pen val5 = new Pen(Color.FromArgb(250, 255, 255, 255), 2f);
				new LinearGradientBrush(rectangle3, Color.FromArgb(200, 200, 200), Color.FromArgb(255, 255, 255), 0f);
				int num = array2.Length - 2;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					val2.DrawLine(val5, array2[num2], array2[num2 + 1]);
					num2++;
				}
			}
			string text = ((Control)this).get_Text();
			Font font = ((Control)this).get_Font();
			SolidBrush val6 = new SolidBrush(((Control)this).get_ForeColor());
			point3 = new Point(18, -1);
			PointF pointF = point3;
			StringFormat val7 = new StringFormat();
			val7.set_Alignment((StringAlignment)0);
			val7.set_LineAlignment((StringAlignment)0);
			val2.DrawString(text, font, (Brush)val6, pointF, val7);
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
