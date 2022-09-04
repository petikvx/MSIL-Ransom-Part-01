using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Facebook_HACK_ANO;

[DefaultEvent("CheckedChanged")]
public class ReactorCheckBox : Control
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
		_Checked = !_Checked;
		CheckedChangedEvent?.Invoke(this);
		((Control)this).OnClick(e);
	}

	public ReactorCheckBox()
	{
		__ENCAddToList(this);
		State = MouseState.None;
		((Control)this).set_BackColor(Color.FromArgb(38, 38, 38));
		((Control)this).set_ForeColor(Color.White);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected O, but got Unknown
		((Control)this).OnPaint(e);
		Graphics graphics = e.get_Graphics();
		((Control)this).set_Height(16);
		graphics.Clear(((Control)this).get_BackColor());
		Color color = Color.FromArgb(46, 45, 44);
		checked
		{
			Rectangle rectangle = new Rectangle(1, 1, 14, ((Control)this).get_Height() - 2);
			LinearGradientBrush val = new LinearGradientBrush(rectangle, Color.FromArgb(10, 9, 8), Color.FromArgb(31, 29, 26), 90f);
			rectangle = new Rectangle(1, 1, 13, (int)Math.Round((double)((Control)this).get_Height() / 2.0 - 2.0));
			LinearGradientBrush val2 = new LinearGradientBrush(rectangle, Color.FromArgb(80, Color.White), Color.FromArgb(50, Color.White), 90f);
			if (_Checked)
			{
				color = Color.FromArgb(225, 110, 30);
				rectangle = new Rectangle(1, 1, 14, ((Control)this).get_Height() - 2);
				val = new LinearGradientBrush(rectangle, Color.FromArgb(209, 68, 0), Color.FromArgb(210, 75, 0), 90f);
			}
			else
			{
				color = Color.FromArgb(46, 45, 44);
				rectangle = new Rectangle(1, 1, 14, ((Control)this).get_Height() - 2);
				val = new LinearGradientBrush(rectangle, Color.FromArgb(24, 24, 24), Color.FromArgb(30, 30, 30), 90f);
			}
			string text = ((Control)this).get_Text();
			Font font = ((Control)this).get_Font();
			SolidBrush val3 = new SolidBrush(((Control)this).get_ForeColor());
			Point point = new Point(18, (int)Math.Round((double)((Control)this).get_Height() / 2.0 + (double)((Control)this).get_Font().get_Height() - 18.0));
			graphics.DrawString(text, font, (Brush)val3, (PointF)point);
			graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(36, 34, 30))), 2, ((Control)this).get_Height() - 1, 14, ((Control)this).get_Height() - 1);
			LinearGradientBrush obj = val;
			rectangle = new Rectangle(1, 1, 14, ((Control)this).get_Height() - 2);
			graphics.FillRectangle((Brush)(object)obj, rectangle);
			Pen val4 = new Pen((Brush)new SolidBrush(color));
			rectangle = new Rectangle(1, 1, 12, ((Control)this).get_Height() - 4);
			graphics.DrawRectangle(val4, rectangle);
			if (_Checked)
			{
				rectangle = new Rectangle(1, 1, 13, (int)Math.Round((double)((Control)this).get_Height() / 2.0 - 2.0));
				graphics.FillRectangle((Brush)(object)val2, rectangle);
			}
			Pen val5 = new Pen((Brush)new SolidBrush(Color.FromArgb(10, 10, 10)));
			rectangle = new Rectangle(0, 0, 14, ((Control)this).get_Height() - 2);
			graphics.DrawRectangle(val5, rectangle);
		}
	}
}
