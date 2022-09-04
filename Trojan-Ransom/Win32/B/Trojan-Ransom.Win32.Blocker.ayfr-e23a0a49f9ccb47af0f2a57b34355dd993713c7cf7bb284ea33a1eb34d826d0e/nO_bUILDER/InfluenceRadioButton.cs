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

namespace nO_bUILDER;

[DefaultEvent("CheckedChanged")]
public class InfluenceRadioButton : Control
{
	public delegate void CheckedChangedEventHandler(object sender);

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private Rectangle R1;

	private LinearGradientBrush G1;

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
			InvalidateControls();
			CheckedChangedEvent?.Invoke(this);
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

	protected override void OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		((Control)this).set_Height(16);
	}

	protected override void OnTextChanged(EventArgs e)
	{
		((Control)this).OnTextChanged(e);
		((Control)this).Invalidate();
	}

	protected override void OnClick(EventArgs e)
	{
		if (!_Checked)
		{
			Checked = true;
		}
		((Control)this).OnClick(e);
	}

	protected override void OnCreateControl()
	{
		((Control)this).OnCreateControl();
		InvalidateControls();
	}

	private void InvalidateControls()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		if ((!((Control)this).get_IsHandleCreated() || !_Checked) ? true : false)
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
				if ((val != this && val is InfluenceRadioButton) ? true : false)
				{
					((InfluenceRadioButton)(object)val).Checked = false;
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

	public InfluenceRadioButton()
	{
		__ENCAddToList(this);
		State = MouseState.None;
		((Control)this).SetStyle((ControlStyles)2050, true);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).set_ForeColor(Color.White);
		Size size = new Size(150, 16);
		((Control)this).set_Size(size);
		((Control)this).set_DoubleBuffered(true);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected O, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		new Draw();
		checked
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Height() - 1, ((Control)this).get_Height() - 1);
			val2.set_SmoothingMode((SmoothingMode)2);
			val2.Clear(((Control)this).get_BackColor());
			switch (Checked)
			{
			case false:
			{
				LinearGradientBrush val9 = new LinearGradientBrush(rectangle, Color.FromArgb(10, 10, 10), Color.FromArgb(16, 16, 16), 90f);
				val2.FillEllipse((Brush)(object)val9, rectangle);
				Pen val10 = new Pen(Color.FromArgb(80, 97, 94, 90));
				Rectangle rectangle2 = new Rectangle(1, 1, ((Control)this).get_Height() - 3, ((Control)this).get_Height() - 3);
				val2.DrawEllipse(val10, rectangle2);
				val2.DrawEllipse(Pens.get_Black(), rectangle);
				break;
			}
			case true:
			{
				LinearGradientBrush val3 = new LinearGradientBrush(rectangle, Color.FromArgb(10, 10, 10), Color.FromArgb(16, 16, 16), 90f);
				val2.FillEllipse((Brush)(object)val3, rectangle);
				HatchBrush val4 = new HatchBrush((HatchStyle)21, Color.FromArgb(100, 31, 31, 31), Color.FromArgb(100, 36, 36, 36));
				val2.FillEllipse((Brush)(object)val4, rectangle);
				Rectangle rectangle2 = new Rectangle(0, 1, ((Control)this).get_Height() - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0 - 1.0));
				LinearGradientBrush val5 = new LinearGradientBrush(rectangle2, Color.FromArgb(35, Color.White), Color.FromArgb(0, Color.White), 90f);
				val2.FillEllipse((Brush)(object)val5, val5.get_Rectangle());
				SolidBrush val6 = new SolidBrush(Color.FromArgb(15, 15, 15));
				rectangle2 = new Rectangle(4, 4, ((Control)this).get_Height() - 9, ((Control)this).get_Height() - 9);
				val2.FillEllipse((Brush)val6, rectangle2);
				SolidBrush val7 = new SolidBrush(Color.FromArgb(250, 255, 255, 255));
				rectangle2 = new Rectangle(5, 5, ((Control)this).get_Height() - 11, ((Control)this).get_Height() - 11);
				val2.FillEllipse((Brush)val7, rectangle2);
				Pen val8 = new Pen(Color.FromArgb(80, 97, 94, 90));
				rectangle2 = new Rectangle(1, 1, ((Control)this).get_Height() - 3, ((Control)this).get_Height() - 3);
				val2.DrawEllipse(val8, rectangle2);
				val2.DrawEllipse(Pens.get_Black(), rectangle);
				break;
			}
			}
			string text = ((Control)this).get_Text();
			Font font = ((Control)this).get_Font();
			Brush white = Brushes.get_White();
			Point point = new Point(16, 0);
			PointF pointF = point;
			StringFormat val11 = new StringFormat();
			val11.set_Alignment((StringAlignment)0);
			val11.set_LineAlignment((StringAlignment)0);
			val2.DrawString(text, font, white, pointF, val11);
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
