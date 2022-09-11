using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns0;

namespace ns1;

public class LXTextBox : Control
{
	private TextBox textBox_0;

	private bool bool_0;

	internal bool bool_1;

	internal int int_0 = 32767;

	internal HorizontalAlignment horizontalAlignment_0;

	internal bool bool_2;

	private TextBox TextBox_0
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		get
		{
			return textBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
		}
	}

	public bool UseSystemPasswordChar
	{
		get
		{
			return bool_1;
		}
		set
		{
			TextBox_0.set_UseSystemPasswordChar(UseSystemPasswordChar);
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
			((TextBoxBase)TextBox_0).set_MaxLength(MaxLength);
			((Control)this).Invalidate();
		}
	}

	public HorizontalAlignment TextAlignment
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return horizontalAlignment_0;
		}
		set
		{
			((Control)this).Invalidate();
		}
	}

	public bool MultiLine
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
			((Control)this).Invalidate();
		}
	}

	public bool WordWrap
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool flag = (bool_2 = value);
			((Control)this).Invalidate();
		}
	}

	public LXTextBox()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		TextBox_0 = new TextBox();
		method_2();
		((Control)this).get_Controls().Add((Control)(object)TextBox_0);
		((Control)this).set_Text("");
		((Control)this).set_BackColor(Color.FromArgb(50, 50, 50));
		((Control)this).set_ForeColor(Color.Silver);
		((Control)this).set_Size(new Size(135, 24));
		((Control)this).set_DoubleBuffered(true);
	}

	protected override void vmethod_0(PaintEventArgs paintEventArgs_0)
	{
	}

	protected override void vmethod_1(EventArgs eventArgs_0)
	{
		((Control)this).OnTextChanged(eventArgs_0);
		((Control)this).Invalidate();
	}

	protected override void vmethod_2(EventArgs eventArgs_0)
	{
		((Control)this).OnBackColorChanged(eventArgs_0);
		((Control)TextBox_0).set_BackColor(((Control)this).get_BackColor());
		((Control)this).Invalidate();
	}

	protected override void vmethod_3(EventArgs eventArgs_0)
	{
		((Control)this).OnForeColorChanged(eventArgs_0);
		((Control)TextBox_0).set_ForeColor(((Control)this).get_ForeColor());
		((Control)this).Invalidate();
	}

	protected override void vmethod_4(EventArgs eventArgs_0)
	{
		((Control)this).OnFontChanged(eventArgs_0);
		((Control)TextBox_0).set_Font(((Control)this).get_Font());
	}

	protected override void vmethod_5(EventArgs eventArgs_0)
	{
		((Control)this).OnGotFocus(eventArgs_0);
		((Control)TextBox_0).Focus();
	}

	public void method_0()
	{
		((Control)this).set_Text(((Control)TextBox_0).get_Text());
	}

	public void method_1()
	{
		((Control)TextBox_0).set_Text(((Control)this).get_Text());
	}

	protected override void vmethod_6(EventArgs eventArgs_0)
	{
		((Control)this).OnResize(eventArgs_0);
		if (!MultiLine)
		{
			((Control)this).set_Height(24);
		}
	}

	public void method_2()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		TextBox val = TextBox_0;
		((TextBoxBase)val).set_Multiline(MultiLine);
		((Control)val).set_BackColor(Color.FromArgb(50, 50, 50));
		((Control)val).set_ForeColor(((Control)this).get_ForeColor());
		((Control)val).set_Text(string.Empty);
		val.set_TextAlign((HorizontalAlignment)2);
		((TextBoxBase)val).set_BorderStyle((BorderStyle)0);
		((Control)val).set_Location(new Point(5, 4));
		((Control)val).set_Font(new Font(" ", 8f, (FontStyle)0));
		if (MultiLine)
		{
			if (WordWrap)
			{
				((TextBoxBase)val).set_WordWrap(true);
			}
			else
			{
				((TextBoxBase)val).set_WordWrap(false);
			}
		}
		else if (WordWrap)
		{
			((TextBoxBase)val).set_WordWrap(true);
		}
		else
		{
			((TextBoxBase)val).set_WordWrap(false);
		}
		((Control)val).set_Size(new Size(((Control)this).get_Width() - 10, ((Control)this).get_Height() - 11));
		val.set_UseSystemPasswordChar(UseSystemPasswordChar);
	}

	protected override void vmethod_7(PaintEventArgs paintEventArgs_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.set_SmoothingMode((SmoothingMode)2);
		Rectangle rectangle_ = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
		TextBox val3 = TextBox_0;
		((TextBoxBase)val3).set_Multiline(MultiLine);
		if (!MultiLine)
		{
			((Control)this).set_Height(((Control)TextBox_0).get_Height() + 11);
			if (WordWrap)
			{
				((TextBoxBase)val3).set_WordWrap(true);
			}
			else
			{
				((TextBoxBase)val3).set_WordWrap(false);
			}
		}
		else
		{
			((Control)TextBox_0).set_Height(((Control)this).get_Height() - 11);
			if (WordWrap)
			{
				((TextBoxBase)val3).set_WordWrap(true);
			}
			else
			{
				((TextBoxBase)val3).set_WordWrap(false);
			}
		}
		((Control)val3).set_Width(((Control)this).get_Width() - 10);
		val3.set_TextAlign(TextAlignment);
		val3.set_UseSystemPasswordChar(UseSystemPasswordChar);
		val2.Clear(((Control)this).get_BackColor());
		Color[] color_ = new Color[8]
		{
			Color.FromArgb(20, 20, 20),
			Color.FromArgb(40, 40, 40),
			Color.FromArgb(45, 45, 45),
			Color.FromArgb(46, 46, 46),
			Color.FromArgb(47, 47, 47),
			Color.FromArgb(48, 48, 48),
			Color.FromArgb(49, 49, 49),
			Color.FromArgb(50, 50, 50)
		};
		val2.FillPath((Brush)new SolidBrush(Color.FromArgb(50, 50, 50)), Class2.smethod_0(rectangle_, 3));
		Class2.smethod_3(val2, rectangle_, 1, color_);
		paintEventArgs_0.get_Graphics().DrawImage((Image)((Image)val).Clone(), 0, 0);
		val2.Dispose();
		((Image)val).Dispose();
	}
}
