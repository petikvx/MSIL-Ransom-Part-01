using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace builder;

public class BlackShadesNetTextBox : Control
{
	private static List<WeakReference> list_0;

	[AccessedThroughProperty("txtbox")]
	private TextBox textBox_0;

	private bool bool_0;

	private int int_0;

	private HorizontalAlignment horizontalAlignment_0;

	public bool UseSystemPasswordChar
	{
		get
		{
			return bool_0;
		}
		set
		{
			vmethod_0().set_UseSystemPasswordChar(UseSystemPasswordChar);
			bool_0 = value;
			((Control)this).Invalidate();
		}
	}

	public int MaxLength
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
			((TextBoxBase)vmethod_0()).set_MaxLength(MaxLength);
			((Control)this).Invalidate();
		}
	}

	public HorizontalAlignment TextAlignment
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return horizontalAlignment_0;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			horizontalAlignment_0 = value;
			((Control)this).Invalidate();
		}
	}

	[DebuggerNonUserCode]
	static BlackShadesNetTextBox()
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

	[SpecialName]
	[DebuggerNonUserCode]
	private virtual TextBox vmethod_0()
	{
		return textBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	private virtual void vmethod_1(TextBox WithEventsValue)
	{
		EventHandler eventHandler = delegate
		{
			TextChngTxtBox();
		};
		if (textBox_0 != null)
		{
			((Control)textBox_0).remove_TextChanged(eventHandler);
		}
		textBox_0 = WithEventsValue;
		if (textBox_0 != null)
		{
			((Control)textBox_0).add_TextChanged(eventHandler);
		}
	}

	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
	}

	protected override void OnTextChanged(EventArgs e)
	{
		((Control)this).OnTextChanged(e);
		((Control)this).Invalidate();
	}

	protected override void OnBackColorChanged(EventArgs e)
	{
		((Control)this).OnBackColorChanged(e);
		((TextBoxBase)vmethod_0()).set_BackColor(((Control)this).get_BackColor());
		((Control)this).Invalidate();
	}

	protected override void OnForeColorChanged(EventArgs e)
	{
		((Control)this).OnForeColorChanged(e);
		((TextBoxBase)vmethod_0()).set_ForeColor(((Control)this).get_ForeColor());
		((Control)this).Invalidate();
	}

	protected override void OnFontChanged(EventArgs e)
	{
		((Control)this).OnFontChanged(e);
		((Control)vmethod_0()).set_Font(((Control)this).get_Font());
	}

	protected override void OnGotFocus(EventArgs e)
	{
		((Control)this).OnGotFocus(e);
		((Control)vmethod_0()).Focus();
	}

	public void TextChngTxtBox()
	{
		((Control)this).set_Text(vmethod_0().get_Text());
	}

	public void TextChng()
	{
		vmethod_0().set_Text(((Control)this).get_Text());
	}

	public void NewTextBox()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		TextBox val = vmethod_0();
		val.set_Multiline(false);
		((TextBoxBase)val).set_BackColor(Color.FromArgb(43, 43, 43));
		((TextBoxBase)val).set_ForeColor(((Control)this).get_ForeColor());
		val.set_Text(string.Empty);
		val.set_TextAlign((HorizontalAlignment)2);
		((TextBoxBase)val).set_BorderStyle((BorderStyle)0);
		TextBox obj = val;
		Point location = new Point(5, 4);
		((Control)obj).set_Location(location);
		((Control)val).set_Font(new Font("Trebuchet MS", 8.25f, (FontStyle)1));
		TextBox obj2 = val;
		Size size = checked(new Size(((Control)this).get_Width() - 10, ((Control)this).get_Height() - 11));
		((Control)obj2).set_Size(size);
		val.set_UseSystemPasswordChar(UseSystemPasswordChar);
		val = null;
	}

	public BlackShadesNetTextBox()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		Class14.hYiyYvszsKHjE();
		((Control)this)._002Ector();
		((Control)this).add_TextChanged((EventHandler)delegate
		{
			TextChng();
		});
		smethod_0(this);
		vmethod_1(new TextBox());
		bool_0 = false;
		int_0 = 32767;
		NewTextBox();
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Control)this).set_Text("");
		((Control)this).set_BackColor(Color.FromArgb(36, 40, 42));
		((Control)this).set_ForeColor(Color.FromArgb(142, 152, 156));
		Size size = new Size(135, 35);
		((Control)this).set_Size(size);
		((Control)this).set_DoubleBuffered(true);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.set_SmoothingMode((SmoothingMode)2);
		new Class10();
		checked
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			((Control)this).set_Height(((Control)vmethod_0()).get_Height() + 11);
			TextBox val3 = vmethod_0();
			((Control)val3).set_Width(((Control)this).get_Width() - 10);
			val3.set_TextAlign(TextAlignment);
			val3.set_UseSystemPasswordChar(UseSystemPasswordChar);
			val3 = null;
			val2.Clear(Color.FromArgb(36, 40, 42));
			val2.FillRectangle((Brush)new SolidBrush(Color.FromArgb(36, 40, 42)), rectangle);
			val2.DrawRectangle(new Pen(Color.FromArgb(53, 57, 60)), rectangle);
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
