using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG;

public class EtherealTextbox : Control
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	[AccessedThroughProperty("T")]
	private TextBox _T;

	private HorizontalAlignment _TextAlign;

	private int _MaxLength;

	private bool _ReadOnly;

	private bool _UseSystemPasswordChar;

	private string _WatermarkText;

	private Image _SideImage;

	private virtual TextBox T
	{
		[DebuggerNonUserCode]
		get
		{
			return _T;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			KeyEventHandler val = new KeyEventHandler(T_KeyDown);
			EventHandler eventHandler = T_TextChanged;
			if (_T != null)
			{
				((Control)_T).remove_KeyDown(val);
				((Control)_T).remove_TextChanged(eventHandler);
			}
			_T = value;
			if (_T != null)
			{
				((Control)_T).add_KeyDown(val);
				((Control)_T).add_TextChanged(eventHandler);
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public BorderStyle BorderStyle
	{
		get
		{
			return (BorderStyle)0;
		}
		set
		{
		}
	}

	public string WatermarkText
	{
		get
		{
			return _WatermarkText;
		}
		set
		{
			_WatermarkText = value;
			SendMessage(((Control)T).get_Handle(), 5377, 0, value);
			((Control)this).Invalidate();
		}
	}

	public virtual HorizontalAlignment TextAlign
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return _TextAlign;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			_TextAlign = value;
			if (T != null)
			{
				T.set_TextAlign(value);
			}
		}
	}

	public virtual int MaxLength
	{
		get
		{
			return _MaxLength;
		}
		set
		{
			_MaxLength = value;
			if (T != null)
			{
				((TextBoxBase)T).set_MaxLength(value);
			}
		}
	}

	public virtual bool ReadOnly
	{
		get
		{
			return _ReadOnly;
		}
		set
		{
			_ReadOnly = value;
			if (T != null)
			{
				((TextBoxBase)T).set_ReadOnly(value);
			}
		}
	}

	public virtual bool UseSystemPasswordChar
	{
		get
		{
			return _UseSystemPasswordChar;
		}
		set
		{
			_UseSystemPasswordChar = value;
			if (T != null)
			{
				T.set_UseSystemPasswordChar(value);
			}
		}
	}

	public virtual bool Multiline => false;

	public virtual string Text
	{
		get
		{
			return ((Control)this).get_Text();
		}
		set
		{
			((Control)this).set_Text(value);
			if (T != null)
			{
				T.set_Text(value);
			}
		}
	}

	[Browsable(false)]
	public virtual Font Font => new Font("Segoe UI", 10f, (FontStyle)0);

	[Browsable(false)]
	public virtual Color ForeColor => Color.Gray;

	[Browsable(true)]
	public Image SideImage
	{
		get
		{
			return _SideImage;
		}
		set
		{
			_SideImage = value;
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

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

	protected override void OnCreateControl()
	{
		((Control)this).OnCreateControl();
		if (!((Control)this).get_Controls().Contains((Control)(object)T))
		{
			((Control)this).get_Controls().Add((Control)(object)T);
		}
	}

	private void T_TextChanged(object sender, EventArgs e)
	{
		Text = T.get_Text();
	}

	private void T_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		if ((e.get_Control() && (int)e.get_KeyCode() == 65) ? true : false)
		{
			e.set_SuppressKeyPress(true);
		}
		if ((e.get_Control() && (int)e.get_KeyCode() == 67) ? true : false)
		{
			((TextBoxBase)T).Copy();
			e.set_SuppressKeyPress(true);
		}
	}

	public EtherealTextbox()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		__ENCAddToList(this);
		T = new TextBox();
		_TextAlign = (HorizontalAlignment)0;
		_MaxLength = 32767;
		_ReadOnly = false;
		_UseSystemPasswordChar = false;
		_WatermarkText = string.Empty;
		((Control)this).SetStyle((ControlStyles)141330, true);
		((Control)this).set_DoubleBuffered(true);
		TextBox t = T;
		t.set_Multiline(false);
		((Control)t).set_Cursor(Cursors.get_Default());
		((TextBoxBase)t).set_BackColor(Color.White);
		((TextBoxBase)t).set_ForeColor(ForeColor);
		t.set_Text(WatermarkText);
		((TextBoxBase)t).set_BorderStyle((BorderStyle)0);
		TextBox obj = t;
		Point location = new Point(7, 7);
		((Control)obj).set_Location(location);
		((Control)t).set_Font(Font);
		TextBox obj2 = t;
		Size size = new Size(checked(((Control)this).get_Width() - 10), 34);
		((Control)obj2).set_Size(size);
		t.set_UseSystemPasswordChar(_UseSystemPasswordChar);
		Text = WatermarkText;
		t = null;
		size = new Size(135, 34);
		((Control)this).set_Size(size);
		((Control)this).set_BackColor(Color.White);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		checked
		{
			try
			{
				Graphics val2 = Graphics.FromImage((Image)(object)val);
				try
				{
					((Control)this).set_Height(34);
					Graphics val3 = val2;
					val3.set_SmoothingMode((SmoothingMode)2);
					val3.Clear(((Control)this).get_BackColor());
					Color hTMLColor = HelperMethods.GetHTMLColor("ececec");
					Rectangle rect = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
					HelperMethods.DrawRoundedPath(val2, hTMLColor, 1.8f, rect, 4);
					if (SideImage != null)
					{
						TextBox t = T;
						Point location = new Point(45, 7);
						((Control)t).set_Location(location);
						((Control)T).set_Width(((Control)this).get_Width() - 60);
						Graphics obj = val3;
						Pen obj2 = HelperMethods.PenHTMlColor("ececec", 1f);
						rect = new Rectangle(-1, -1, 35, ((Control)this).get_Height() + 1);
						obj.DrawRectangle(obj2, rect);
						Graphics obj3 = val3;
						Image sideImage = SideImage;
						rect = new Rectangle(8, 7, 16, 16);
						obj3.DrawImage(sideImage, rect);
					}
					else
					{
						TextBox t2 = T;
						Point location = new Point(7, 7);
						((Control)t2).set_Location(location);
						((Control)T).set_Width(((Control)this).get_Width() - 10);
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
	}
}
