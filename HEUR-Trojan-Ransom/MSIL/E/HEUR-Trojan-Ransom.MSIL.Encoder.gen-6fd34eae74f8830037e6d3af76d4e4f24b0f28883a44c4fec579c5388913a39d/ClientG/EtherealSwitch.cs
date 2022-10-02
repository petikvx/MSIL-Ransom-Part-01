using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG;

[DefaultEvent("CheckedChanged")]
public class EtherealSwitch : Control
{
	public delegate void CheckedChangedEventHandler(object sender);

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private bool _Switch;

	private HelperMethods.MouseMode State;

	private CheckedChangedEventHandler CheckedChangedEvent;

	public bool Switched
	{
		get
		{
			return _Switch;
		}
		set
		{
			_Switch = value;
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

	public EtherealSwitch()
	{
		__ENCAddToList(this);
		_Switch = false;
		((Control)this).SetStyle((ControlStyles)141330, true);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_Cursor(Cursors.get_Default());
		Size size = new Size(46, 25);
		((Control)this).set_Size(size);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		try
		{
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			try
			{
				Graphics val3 = val2;
				val3.set_SmoothingMode((SmoothingMode)4);
				if (Switched)
				{
					Color hTMLColor = HelperMethods.GetHTMLColor("3f2153");
					Rectangle rect = new Rectangle(1, 1, 42, 22);
					HelperMethods.FillRoundedPath(val2, hTMLColor, rect, 22);
					Color hTMLColor2 = HelperMethods.GetHTMLColor("ededed");
					rect = new Rectangle(1, 1, 42, 22);
					HelperMethods.DrawRoundedPath(val2, hTMLColor2, 1.5f, rect, 20);
					SolidBrush obj = HelperMethods.SolidBrushHTMlColor("fcfcfc");
					rect = new Rectangle(22, 3, 19, 18);
					val2.FillEllipse((Brush)(object)obj, rect);
					Pen obj2 = HelperMethods.PenHTMlColor("e9e9e9", 1.5f);
					rect = new Rectangle(22, 3, 19, 18);
					val2.DrawEllipse(obj2, rect);
				}
				else
				{
					Color hTMLColor3 = HelperMethods.GetHTMLColor("f8f8f8");
					Rectangle rect = new Rectangle(1, 1, 42, 22);
					HelperMethods.FillRoundedPath(val2, hTMLColor3, rect, 22);
					Color hTMLColor4 = HelperMethods.GetHTMLColor("ededed");
					rect = new Rectangle(1, 1, 42, 22);
					HelperMethods.DrawRoundedPath(val2, hTMLColor4, 1.5f, rect, 20);
					SolidBrush obj3 = HelperMethods.SolidBrushHTMlColor("fcfcfc");
					rect = new Rectangle(3, 3, 19, 18);
					val2.FillEllipse((Brush)(object)obj3, rect);
					Pen obj4 = HelperMethods.PenHTMlColor("e9e9e9", 1.5f);
					rect = new Rectangle(3, 3, 19, 18);
					val2.DrawEllipse(obj4, rect);
				}
				val3 = null;
				NewLateBinding.LateCall((object)e.get_Graphics(), (Type)null, "DrawImage", new object[3]
				{
					RuntimeHelpers.GetObjectValue(((Image)val).Clone()),
					0,
					0
				}, (string[])null, (Type[])null, (bool[])null, true);
				val2.Dispose();
				((Image)val).Dispose();
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		((Control)this).OnMouseDown(e);
		State = HelperMethods.MouseMode.Pushed;
		((Control)this).Invalidate();
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		((Control)this).OnMouseUp(e);
		State = HelperMethods.MouseMode.Hovered;
		((Control)this).Invalidate();
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		((Control)this).OnMouseEnter(e);
		State = HelperMethods.MouseMode.Hovered;
		((Control)this).Invalidate();
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((Control)this).OnMouseLeave(e);
		State = HelperMethods.MouseMode.NormalMode;
		((Control)this).Invalidate();
	}

	protected override void OnClick(EventArgs e)
	{
		_Switch = !_Switch;
		CheckedChangedEvent?.Invoke(this);
		((Control)this).OnClick(e);
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		Size size = new Size(46, 25);
		((Control)this).set_Size(size);
	}
}
