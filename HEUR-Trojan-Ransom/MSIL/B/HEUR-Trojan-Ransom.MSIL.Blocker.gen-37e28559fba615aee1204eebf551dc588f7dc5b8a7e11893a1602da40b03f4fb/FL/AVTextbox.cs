using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FL;

public class AVTextbox : Control
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("txtbox")]
	private TextBox textBox_0;

	private bool bool_0;

	private int int_0;

	private HorizontalAlignment horizontalAlignment_0;

	private bool bool_1;

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

	public bool MultiLine
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
			((Control)this).Invalidate();
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual TextBox vmethod_0()
	{
		return textBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void vmethod_1(TextBox value)
	{
		EventHandler eventHandler = delegate
		{
			TextChngTxtBox();
		};
		TextBox val = textBox_0;
		if (val != null)
		{
			((Control)val).remove_TextChanged(eventHandler);
		}
		textBox_0 = value;
		val = textBox_0;
		if (val != null)
		{
			((Control)val).add_TextChanged(eventHandler);
		}
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
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		TextBox val = vmethod_0();
		val.set_Multiline(false);
		((TextBoxBase)val).set_BackColor(Color.FromArgb(43, 43, 43));
		((TextBoxBase)val).set_ForeColor(((Control)this).get_ForeColor());
		val.set_Text(string.Empty);
		val.set_TextAlign((HorizontalAlignment)2);
		((TextBoxBase)val).set_BorderStyle((BorderStyle)0);
		((Control)val).set_Location(new Point(7, 5));
		((Control)val).set_Font(new Font("Verdana", 10f));
		((Control)val).set_Size(new Size(checked(((Control)this).get_Width() - 10), 33));
		val.set_UseSystemPasswordChar(UseSystemPasswordChar);
		val = null;
	}

	public AVTextbox()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		Class8.t3hvLuccnmfIO();
		Class8.t3hvLuccnmfIO();
		((Control)this)._002Ector();
		((Control)this).add_TextChanged((EventHandler)delegate
		{
			TextChng();
		});
		vmethod_1(new TextBox());
		bool_0 = false;
		int_0 = 32767;
		bool_1 = false;
		NewTextBox();
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)2048, true);
		((Control)this).set_Text("");
		((Control)this).set_BackColor(Color.White);
		((Control)this).set_ForeColor(Color.Gray);
		((Control)this).set_Font(new Font("Verdana", 10f));
		((Control)this).set_Size(new Size(135, 33));
		((Control)this).set_DoubleBuffered(true);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.set_SmoothingMode((SmoothingMode)2);
		((Control)this).set_Height(33);
		TextBox val3 = vmethod_0();
		checked
		{
			((Control)val3).set_Width(((Control)this).get_Width() - 10);
			val3.set_TextAlign(TextAlignment);
			val3.set_UseSystemPasswordChar(UseSystemPasswordChar);
			((Control)val3).set_Height(33);
			val3 = null;
			val2.Clear(Color.Transparent);
			val2.DrawRectangle(new Pen((Brush)new SolidBrush(Color.FromArgb(216, 216, 216))), new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1));
			NewLateBinding.LateCall((object)e.get_Graphics(), (Type)null, "DrawImage", new object[3]
			{
				((Image)val).Clone(),
				0,
				0
			}, (string[])null, (Type[])null, (bool[])null, true);
			val2.Dispose();
			((Image)val).Dispose();
		}
	}
}
