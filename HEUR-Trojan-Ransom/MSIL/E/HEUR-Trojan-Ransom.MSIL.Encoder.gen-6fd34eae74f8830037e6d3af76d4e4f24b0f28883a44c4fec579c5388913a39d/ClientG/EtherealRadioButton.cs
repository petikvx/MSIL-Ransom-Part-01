using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG;

[DefaultEvent("CheckedChanged")]
public class EtherealRadioButton : Control
{
	public delegate void CheckedChangedEventHandler(object sender);

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private bool _Checked;

	private int _Group;

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
			CheckedChangedEvent?.Invoke(this);
			((Control)this).Invalidate();
		}
	}

	public int Group
	{
		get
		{
			return _Group;
		}
		set
		{
			_Group = value;
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

	public EtherealRadioButton()
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		__ENCAddToList(this);
		_Group = 1;
		((Control)this).SetStyle((ControlStyles)141314, true);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_Cursor(Cursors.get_Default());
		((Control)this).set_Font(new Font("Proxima Nova", 11f, (FontStyle)0));
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
				val3.set_SmoothingMode((SmoothingMode)2);
				val3.set_TextRenderingHint((TextRenderingHint)4);
				val3.DrawEllipse(HelperMethods.PenHTMlColor("746188", 2.5f), 1, 1, 18, 18);
				Graphics obj = val3;
				string text = ((Control)this).get_Text();
				Font font = ((Control)this).get_Font();
				Brush gray = Brushes.get_Gray();
				Rectangle rectangle = new Rectangle(23, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
				obj.DrawString(text, font, gray, (RectangleF)rectangle);
				if (Checked)
				{
					Graphics obj2 = val3;
					SolidBrush obj3 = HelperMethods.SolidBrushHTMlColor("746188");
					rectangle = new Rectangle(5, 5, 10, 10);
					obj2.FillEllipse((Brush)(object)obj3, rectangle);
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

	protected override void OnClick(EventArgs e)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		_Checked = !Checked;
		CheckedChangedEvent?.Invoke(this);
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
				if ((val != this && val is EtherealRadioButton && ((EtherealRadioButton)(object)val).Group == _Group) ? true : false)
				{
					((EtherealRadioButton)(object)val).Checked = false;
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
		((Control)this).OnClick(e);
		((Control)this).Invalidate();
	}

	protected override void OnCreateControl()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		if ((!((Control)this).get_IsHandleCreated() || !Checked) ? true : false)
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
				if ((val != this && val is EtherealRadioButton && ((EtherealRadioButton)(object)val).Group == _Group) ? true : false)
				{
					((EtherealRadioButton)(object)val).Checked = false;
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
		((Control)this).OnCreateControl();
	}

	protected override void OnTextChanged(EventArgs e)
	{
		((Control)this).Invalidate();
		((Control)this).OnTextChanged(e);
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).Invalidate();
		((Control)this).OnResize(e);
		((Control)this).set_Height(21);
	}
}
