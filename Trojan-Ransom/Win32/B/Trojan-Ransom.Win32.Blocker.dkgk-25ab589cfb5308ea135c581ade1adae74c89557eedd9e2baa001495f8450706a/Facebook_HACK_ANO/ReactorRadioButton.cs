using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Facebook_HACK_ANO;

[DefaultEvent("CheckedChanged")]
public class ReactorRadioButton : Control
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
				if ((val != this && val is ReactorRadioButton) ? true : false)
				{
					((ReactorRadioButton)(object)val).Checked = false;
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

	public ReactorRadioButton()
	{
		__ENCAddToList(this);
		State = MouseState.None;
		((Control)this).set_BackColor(Color.FromArgb(38, 38, 38));
		((Control)this).set_ForeColor(Color.White);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		((Control)this).OnPaint(e);
		Graphics graphics = e.get_Graphics();
		((Control)this).set_Height(16);
		graphics.Clear(((Control)this).get_BackColor());
		graphics.set_SmoothingMode((SmoothingMode)2);
		ref Rectangle r = ref R1;
		r = new Rectangle(2, 0, 13, 13);
		if (_Checked)
		{
			G1 = new LinearGradientBrush(R1, Color.FromArgb(220, 209, 68, 0), Color.FromArgb(220, 210, 75, 0), 90f);
		}
		else
		{
			G1 = new LinearGradientBrush(R1, Color.FromArgb(24, 24, 24), Color.FromArgb(30, 30, 30), 90f);
		}
		graphics.FillEllipse((Brush)(object)G1, R1);
		if (State == MouseState.Over)
		{
			ref Rectangle r2 = ref R1;
			r2 = new Rectangle(2, 0, 13, 13);
			graphics.FillEllipse((Brush)new SolidBrush(Color.FromArgb(5, Color.White)), R1);
		}
		if (_Checked)
		{
			ref Rectangle r3 = ref R1;
			r3 = new Rectangle(4, 1, 9, 6);
			G1 = new LinearGradientBrush(R1, Color.FromArgb(80, 255, 255, 255), Color.FromArgb(30, 255, 255, 255), 90f);
			graphics.FillEllipse((Brush)(object)G1, R1);
			graphics.DrawEllipse(new Pen((Brush)new SolidBrush(Color.FromArgb(225, 110, 30))), 3, 1, 11, 11);
		}
		graphics.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)new SolidBrush(((Control)this).get_ForeColor()), 18f, 1f);
		graphics.DrawEllipse(Pens.get_Black(), 2, 0, 13, 13);
		graphics.DrawEllipse(new Pen(Color.FromArgb(15, Color.White)), 1, -1, 15, 15);
	}
}
