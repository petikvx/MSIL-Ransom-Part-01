using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace nO_bUILDER;

[DefaultEvent("CheckedChanged")]
public class InfluenceCheckBox : Control
{
	public delegate void CheckedChangedEventHandler(object sender);

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private MouseState State;

	private bool _Checked;

	private CheckedChangedEventHandler CheckedChangedEvent;

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

	public event CheckedChangedEventHandler CheckedChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			CheckedChangedEvent = (CheckedChangedEventHandler)Delegate.Combine(CheckedChangedEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			CheckedChangedEvent = (CheckedChangedEventHandler)Delegate.Remove(CheckedChangedEvent, value);
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

	protected override void OnMouseEnter(EventArgs e)
	{
		((Control)this).OnMouseEnter(e);
		State = MouseState.Over;
		((Control)this).Invalidate();
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		((Control)this).OnMouseDown(e);
		State = MouseState.Down;
		((Control)this).Invalidate();
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((Control)this).OnMouseLeave(e);
		State = MouseState.None;
		((Control)this).Invalidate();
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		((Control)this).OnMouseUp(e);
		State = MouseState.Over;
		((Control)this).Invalidate();
	}

	protected override void OnTextChanged(EventArgs e)
	{
		((Control)this).OnTextChanged(e);
		((Control)this).Invalidate();
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		((Control)this).set_Height(16);
	}

	protected override void OnClick(EventArgs e)
	{
		_Checked = !_Checked;
		CheckedChangedEvent?.Invoke(this);
		((Control)this).OnClick(e);
	}

	public InfluenceCheckBox()
	{
		__ENCAddToList(this);
		State = MouseState.None;
		((Control)this).SetStyle((ControlStyles)2050, true);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).set_ForeColor(Color.White);
		Size size = new Size(145, 16);
		((Control)this).set_Size(size);
		((Control)this).set_DoubleBuffered(true);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected O, but got Unknown
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected O, but got Unknown
		//IL_03f3: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		Draw draw = new Draw();
		checked
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Height() - 1, ((Control)this).get_Height() - 1);
			val2.Clear(((Control)this).get_BackColor());
			Point point3;
			switch (Checked)
			{
			case false:
			{
				LinearGradientBrush val8 = new LinearGradientBrush(rectangle, Color.FromArgb(10, 10, 10), Color.FromArgb(16, 16, 16), 90f);
				val2.FillPath((Brush)(object)val8, draw.RoundRect(rectangle, 2));
				Pen val9 = new Pen(Color.FromArgb(80, 97, 94, 90));
				Rectangle rectangle2 = new Rectangle(1, 1, ((Control)this).get_Height() - 3, ((Control)this).get_Height() - 3);
				val2.DrawPath(val9, draw.RoundRect(rectangle2, 2));
				val2.DrawPath(Pens.get_Black(), draw.RoundRect(rectangle, 2));
				break;
			}
			case true:
			{
				LinearGradientBrush val3 = new LinearGradientBrush(rectangle, Color.FromArgb(10, 10, 10), Color.FromArgb(16, 16, 16), 90f);
				val2.FillPath((Brush)(object)val3, draw.RoundRect(rectangle, 2));
				HatchBrush val4 = new HatchBrush((HatchStyle)21, Color.FromArgb(100, 31, 31, 31), Color.FromArgb(100, 36, 36, 36));
				Rectangle rectangle2 = new Rectangle(0, 0, ((Control)this).get_Height() - 1, ((Control)this).get_Height() - 2);
				val2.FillPath((Brush)(object)val4, draw.RoundRect(rectangle2, 2));
				rectangle2 = new Rectangle(0, 0, ((Control)this).get_Height() - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0));
				LinearGradientBrush val5 = new LinearGradientBrush(rectangle2, Color.FromArgb(35, Color.White), Color.FromArgb(0, Color.White), 90f);
				rectangle2 = new Rectangle(0, 0, ((Control)this).get_Height() - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0 - 1.0));
				val2.FillPath((Brush)(object)val5, draw.RoundRect(rectangle2, 2));
				Pen val6 = new Pen(Color.FromArgb(80, 97, 94, 90));
				rectangle2 = new Rectangle(1, 1, ((Control)this).get_Height() - 3, ((Control)this).get_Height() - 3);
				val2.DrawPath(val6, draw.RoundRect(rectangle2, 2));
				val2.DrawPath(Pens.get_Black(), draw.RoundRect(rectangle, 2));
				Rectangle rectangle3 = new Rectangle((int)Math.Round((double)rectangle.X + (double)rectangle.Width / 4.0), (int)Math.Round((double)rectangle.Y + (double)rectangle.Height / 4.0), unchecked(rectangle.Width / 2), unchecked(rectangle.Height / 2));
				Point[] array = new Point[3];
				ref Point reference = ref array[0];
				Point point = (reference = new Point(rectangle3.X, rectangle3.Y + unchecked(rectangle3.Height / 2)));
				ref Point reference2 = ref array[1];
				Point point2 = (reference2 = new Point(rectangle3.X + unchecked(rectangle3.Width / 2), rectangle3.Y + rectangle3.Height));
				ref Point reference3 = ref array[2];
				point3 = (reference3 = new Point(rectangle3.X + rectangle3.Width, rectangle3.Y));
				Point[] array2 = array;
				if (!Checked)
				{
					break;
				}
				val2.set_SmoothingMode((SmoothingMode)2);
				Pen val7 = new Pen(Color.FromArgb(250, 255, 255, 255), 2f);
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
					val2.DrawLine(val7, array2[num2], array2[num2 + 1]);
					num2++;
				}
				break;
			}
			}
			string text = ((Control)this).get_Text();
			Font font = ((Control)this).get_Font();
			SolidBrush val10 = new SolidBrush(((Control)this).get_ForeColor());
			point3 = new Point(16, 1);
			PointF pointF = point3;
			StringFormat val11 = new StringFormat();
			val11.set_Alignment((StringAlignment)0);
			val11.set_LineAlignment((StringAlignment)0);
			val2.DrawString(text, font, (Brush)val10, pointF, val11);
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
