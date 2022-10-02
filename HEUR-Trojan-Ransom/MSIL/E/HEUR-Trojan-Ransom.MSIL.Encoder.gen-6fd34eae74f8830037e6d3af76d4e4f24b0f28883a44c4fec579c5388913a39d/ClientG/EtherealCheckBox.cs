using System;
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
public class EtherealCheckBox : Control
{
	public delegate void CheckedChangedEventHandler(object sender);

	private static List<WeakReference> __ENCList = new List<WeakReference>();

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

	public EtherealCheckBox()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		__ENCAddToList(this);
		_Checked = false;
		((Control)this).SetStyle((ControlStyles)141330, true);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_Cursor(Cursors.get_Default());
		Size size = new Size(200, 20);
		((Control)this).set_Size(size);
		((Control)this).set_Font(new Font("Proxima Nova", 11f, (FontStyle)0));
		((Control)this).set_BackColor(Color.Transparent);
	}

	protected override void OnClick(EventArgs e)
	{
		_Checked = !_Checked;
		CheckedChangedEvent?.Invoke(this);
		((Control)this).OnClick(e);
		((Control)this).Invalidate();
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		((Control)this).set_Height(20);
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
				val3.set_TextRenderingHint((TextRenderingHint)4);
				Color hTMLColor = HelperMethods.GetHTMLColor("746188");
				Rectangle rect = new Rectangle(1, 1, 16, 16);
				HelperMethods.DrawRoundedPath(val2, hTMLColor, 3f, rect, 3);
				if (Checked)
				{
					Color hTMLColor2 = HelperMethods.GetHTMLColor("746188");
					rect = new Rectangle(5, 5, 8, 8);
					HelperMethods.FillRoundedPath(val2, hTMLColor2, rect, 1);
				}
				string text = ((Control)this).get_Text();
				Font font = ((Control)this).get_Font();
				Brush gray = Brushes.get_Gray();
				rect = new Rectangle(22, -1, ((Control)this).get_Width(), checked(((Control)this).get_Height() - 2));
				val2.DrawString(text, font, gray, (RectangleF)rect);
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
}
