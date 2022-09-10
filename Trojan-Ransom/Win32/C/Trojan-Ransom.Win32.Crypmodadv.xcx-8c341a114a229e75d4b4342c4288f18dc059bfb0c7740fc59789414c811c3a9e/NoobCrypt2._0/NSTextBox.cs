using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace NoobCrypt2._0;

[DefaultEvent("TextChanged")]
internal class NSTextBox : Control
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private HorizontalAlignment _TextAlign;

	private int _MaxLength;

	private bool _ReadOnly;

	private bool _UseSystemPasswordChar;

	private bool _Multiline;

	private TextBox Base;

	private GraphicsPath GP1;

	private GraphicsPath GP2;

	private Pen P1;

	private Pen P2;

	private PathGradientBrush PB1;

	public HorizontalAlignment TextAlign
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
			if (Base != null)
			{
				Base.set_TextAlign(value);
			}
		}
	}

	public int MaxLength
	{
		get
		{
			return _MaxLength;
		}
		set
		{
			_MaxLength = value;
			if (Base != null)
			{
				((TextBoxBase)Base).set_MaxLength(value);
			}
		}
	}

	public bool ReadOnly
	{
		get
		{
			return _ReadOnly;
		}
		set
		{
			_ReadOnly = value;
			if (Base != null)
			{
				((TextBoxBase)Base).set_ReadOnly(value);
			}
		}
	}

	public bool UseSystemPasswordChar
	{
		get
		{
			return _UseSystemPasswordChar;
		}
		set
		{
			_UseSystemPasswordChar = value;
			if (Base != null)
			{
				Base.set_UseSystemPasswordChar(value);
			}
		}
	}

	public bool Multiline
	{
		get
		{
			return _Multiline;
		}
		set
		{
			_Multiline = value;
			checked
			{
				if (Base != null)
				{
					Base.set_Multiline(value);
					if (value)
					{
						((Control)Base).set_Height(((Control)this).get_Height() - 11);
					}
					else
					{
						((Control)this).set_Height(((Control)Base).get_Height() + 11);
					}
				}
			}
		}
	}

	public override string Text
	{
		get
		{
			return ((Control)this).get_Text();
		}
		set
		{
			((Control)this).set_Text(value);
			if (Base != null)
			{
				Base.set_Text(value);
			}
		}
	}

	public override Font Font
	{
		get
		{
			return ((Control)this).get_Font();
		}
		set
		{
			((Control)this).set_Font(value);
			checked
			{
				if (Base != null)
				{
					((Control)Base).set_Font(value);
					TextBox @base = Base;
					Point location = new Point(5, 5);
					((Control)@base).set_Location(location);
					((Control)Base).set_Width(((Control)this).get_Width() - 8);
					if (!_Multiline)
					{
						((Control)this).set_Height(((Control)Base).get_Height() + 11);
					}
				}
			}
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

	protected override void OnHandleCreated(EventArgs e)
	{
		if (!((Control)this).get_Controls().Contains((Control)(object)Base))
		{
			((Control)this).get_Controls().Add((Control)(object)Base);
		}
		((Control)this).OnHandleCreated(e);
	}

	public NSTextBox()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		__ENCAddToList(this);
		_TextAlign = (HorizontalAlignment)0;
		_MaxLength = 32767;
		((Control)this).SetStyle((ControlStyles)139286, true);
		((Control)this).SetStyle((ControlStyles)512, true);
		((Control)this).set_Cursor(Cursors.get_IBeam());
		Base = new TextBox();
		((Control)Base).set_Font(Font);
		Base.set_Text(Text);
		((TextBoxBase)Base).set_MaxLength(_MaxLength);
		Base.set_Multiline(_Multiline);
		((TextBoxBase)Base).set_ReadOnly(_ReadOnly);
		Base.set_UseSystemPasswordChar(_UseSystemPasswordChar);
		((TextBoxBase)Base).set_ForeColor(Color.White);
		((TextBoxBase)Base).set_BackColor(Color.FromArgb(50, 50, 50));
		((TextBoxBase)Base).set_BorderStyle((BorderStyle)0);
		TextBox @base = Base;
		Point location = new Point(5, 5);
		((Control)@base).set_Location(location);
		checked
		{
			((Control)Base).set_Width(((Control)this).get_Width() - 14);
			if (_Multiline)
			{
				((Control)Base).set_Height(((Control)this).get_Height() - 11);
			}
			else
			{
				((Control)this).set_Height(((Control)Base).get_Height() + 11);
			}
			((Control)Base).add_TextChanged((EventHandler)OnBaseTextChanged);
			((Control)Base).add_KeyDown(new KeyEventHandler(OnBaseKeyDown));
			P1 = new Pen(Color.FromArgb(35, 35, 35));
			P2 = new Pen(Color.FromArgb(55, 55, 55));
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		ThemeModule.G = e.get_Graphics();
		ThemeModule.G.Clear(((Control)this).get_BackColor());
		ThemeModule.G.set_SmoothingMode((SmoothingMode)4);
		checked
		{
			GP1 = ThemeModule.CreateRound(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1, 7);
			GP2 = ThemeModule.CreateRound(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3, 7);
			PB1 = new PathGradientBrush(GP1);
			PB1.set_CenterColor(Color.FromArgb(50, 50, 50));
			PB1.set_SurroundColors(new Color[1] { Color.FromArgb(45, 45, 45) });
			PathGradientBrush pB = PB1;
			PointF focusScales = new PointF(0.9f, 0.5f);
			pB.set_FocusScales(focusScales);
			ThemeModule.G.FillPath((Brush)(object)PB1, GP1);
			ThemeModule.G.DrawPath(P2, GP1);
			ThemeModule.G.DrawPath(P1, GP2);
		}
	}

	private void OnBaseTextChanged(object sender, EventArgs e)
	{
		Text = Base.get_Text();
	}

	private void OnBaseKeyDown(object sender, KeyEventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		if ((e.get_Control() && (int)e.get_KeyCode() == 65) ? true : false)
		{
			((TextBoxBase)Base).SelectAll();
			e.set_SuppressKeyPress(true);
		}
	}

	protected override void OnResize(EventArgs e)
	{
		TextBox @base = Base;
		Point location = new Point(5, 5);
		((Control)@base).set_Location(location);
		checked
		{
			((Control)Base).set_Width(((Control)this).get_Width() - 10);
			((Control)Base).set_Height(((Control)this).get_Height() - 11);
			((Control)this).OnResize(e);
		}
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		((Control)Base).Focus();
		((Control)this).OnMouseDown(e);
	}

	protected override void OnEnter(EventArgs e)
	{
		((Control)Base).Focus();
		((Control)this).Invalidate();
		((Control)this).OnEnter(e);
	}

	protected override void OnLeave(EventArgs e)
	{
		((Control)this).Invalidate();
		((Control)this).OnLeave(e);
	}
}
