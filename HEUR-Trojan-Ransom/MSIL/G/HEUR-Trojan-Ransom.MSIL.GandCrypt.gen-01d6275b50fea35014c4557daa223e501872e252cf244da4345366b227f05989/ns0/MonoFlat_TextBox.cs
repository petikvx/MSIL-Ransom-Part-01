using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ns0;

[DefaultEvent("TextChanged")]
public class MonoFlat_TextBox : Control
{
	public TextBox textBox_0 = new TextBox();

	private bool bool_0;

	private Image image_0;

	private Size size_0;

	private HorizontalAlignment horizontalAlignment_0;

	private GraphicsPath graphicsPath_0;

	internal int int_0 = 32767;

	internal bool bool_1;

	internal bool bool_2;

	internal Pen pen_0;

	internal SolidBrush solidBrush_0;

	public HorizontalAlignment TextAlignment
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
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

	public int MaxLength
	{
		get
		{
			return int_0;
		}
		set
		{
			int num = (int_0 = value);
			((TextBoxBase)textBox_0).set_MaxLength(MaxLength);
			((Control)this).Invalidate();
		}
	}

	public bool UseSystemPasswordChar
	{
		get
		{
			return bool_2;
		}
		set
		{
			textBox_0.set_UseSystemPasswordChar(UseSystemPasswordChar);
			bool flag = (bool_2 = value);
			((Control)this).Invalidate();
		}
	}

	public bool ReadOnly
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool flag = (bool_1 = value);
			if (textBox_0 != null)
			{
				((TextBoxBase)textBox_0).set_ReadOnly(value);
			}
		}
	}

	public bool Multiline
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
			if (textBox_0 != null)
			{
				((TextBoxBase)textBox_0).set_Multiline(value);
				if (value)
				{
					((Control)textBox_0).set_Height(((Control)this).get_Height() - 23);
				}
				else
				{
					((Control)this).set_Height(((Control)textBox_0).get_Height() + 23);
				}
			}
		}
	}

	public Image Image
	{
		get
		{
			return image_0;
		}
		set
		{
			if (value == null)
			{
				size_0 = Size.Empty;
			}
			else
			{
				size_0 = value.get_Size();
			}
			image_0 = value;
			if (Image == null)
			{
				((Control)textBox_0).set_Location(new Point(8, 10));
			}
			else
			{
				((Control)textBox_0).set_Location(new Point(35, 11));
			}
			((Control)this).Invalidate();
		}
	}

	protected Size ImageSize => size_0;

	private void textBox_0_Enter(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		Pen val = (pen_0 = new Pen(Color.FromArgb(181, 41, 42)));
		((Control)this).Refresh();
	}

	private void textBox_0_Leave(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		Pen val = (pen_0 = new Pen(Color.FromArgb(32, 41, 50)));
		((Control)this).Refresh();
	}

	private void textBox_0_TextChanged(object sender, EventArgs e)
	{
		((Control)this).set_Text(((Control)textBox_0).get_Text());
	}

	protected override void vmethod_0(EventArgs eventArgs_0)
	{
		((Control)this).OnTextChanged(eventArgs_0);
		((Control)textBox_0).set_Text(((Control)this).get_Text());
		((Control)this).Invalidate();
	}

	protected override void vmethod_1(EventArgs eventArgs_0)
	{
		((Control)this).OnForeColorChanged(eventArgs_0);
		((Control)textBox_0).set_ForeColor(((Control)this).get_ForeColor());
		((Control)this).Invalidate();
	}

	protected override void vmethod_2(EventArgs eventArgs_0)
	{
		((Control)this).OnFontChanged(eventArgs_0);
		((Control)textBox_0).set_Font(((Control)this).get_Font());
	}

	protected override void vmethod_3(PaintEventArgs paintEventArgs_0)
	{
		((Control)this).OnPaintBackground(paintEventArgs_0);
	}

	private void textBox_0_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		if (e.get_Control() && (int)e.get_KeyCode() == 65)
		{
			((TextBoxBase)textBox_0).SelectAll();
			e.set_SuppressKeyPress(true);
		}
		if (e.get_Control() && (int)e.get_KeyCode() == 67)
		{
			((TextBoxBase)textBox_0).Copy();
			e.set_SuppressKeyPress(true);
		}
	}

	protected override void vmethod_4(EventArgs eventArgs_0)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		((Control)this).OnResize(eventArgs_0);
		if (bool_0)
		{
			((Control)textBox_0).set_Height(((Control)this).get_Height() - 23);
		}
		else
		{
			((Control)this).set_Height(((Control)textBox_0).get_Height() + 23);
		}
		graphicsPath_0 = new GraphicsPath();
		graphicsPath_0.AddArc(0, 0, 10, 10, 180f, 90f);
		graphicsPath_0.AddArc(((Control)this).get_Width() - 11, 0, 10, 10, -90f, 90f);
		graphicsPath_0.AddArc(((Control)this).get_Width() - 11, ((Control)this).get_Height() - 11, 10, 10, 0f, 90f);
		graphicsPath_0.AddArc(0, ((Control)this).get_Height() - 11, 10, 10, 90f, 90f);
		graphicsPath_0.CloseAllFigures();
	}

	protected override void vmethod_5(EventArgs eventArgs_0)
	{
		((Control)this).OnGotFocus(eventArgs_0);
		((Control)textBox_0).Focus();
	}

	public void method_0(object sender, EventArgs e)
	{
		((Control)this).set_Text(((Control)textBox_0).get_Text());
	}

	public void method_1(object sender, EventArgs e)
	{
		((Control)textBox_0).set_Text(((Control)this).get_Text());
	}

	public void method_2()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		((Control)textBox_0).set_Location(new Point(8, 10));
		((Control)textBox_0).set_Text(string.Empty);
		((TextBoxBase)textBox_0).set_BorderStyle((BorderStyle)0);
		textBox_0.set_TextAlign((HorizontalAlignment)0);
		((Control)textBox_0).set_Font(new Font("Tahoma", 11f));
		textBox_0.set_UseSystemPasswordChar(UseSystemPasswordChar);
		((TextBoxBase)textBox_0).set_Multiline(false);
		((Control)textBox_0).set_BackColor(Color.FromArgb(66, 76, 85));
		textBox_0.set_ScrollBars((ScrollBars)0);
		((Control)textBox_0).add_KeyDown(new KeyEventHandler(textBox_0_KeyDown));
		((Control)textBox_0).add_Enter((EventHandler)textBox_0_Enter);
		((Control)textBox_0).add_Leave((EventHandler)textBox_0_Leave);
		((Control)textBox_0).add_TextChanged((EventHandler)textBox_0_TextChanged);
	}

	public MonoFlat_TextBox()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		((Control)this).SetStyle((ControlStyles)2048, true);
		((Control)this).SetStyle((ControlStyles)2, true);
		method_2();
		((Control)this).get_Controls().Add((Control)(object)textBox_0);
		Pen val = (pen_0 = new Pen(Color.FromArgb(32, 41, 50)));
		SolidBrush val2 = (solidBrush_0 = new SolidBrush(Color.FromArgb(66, 76, 85)));
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).set_ForeColor(Color.FromArgb(176, 183, 191));
		((Control)this).set_Text((string)null);
		((Control)this).set_Font(new Font("Tahoma", 11f));
		((Control)this).set_Size(new Size(135, 43));
		((Control)this).set_DoubleBuffered(true);
	}

	protected override void vmethod_6(PaintEventArgs paintEventArgs_0)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		((Control)this).OnPaint(paintEventArgs_0);
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.set_SmoothingMode((SmoothingMode)4);
		if (Image == null)
		{
			((Control)textBox_0).set_Width(((Control)this).get_Width() - 18);
		}
		else
		{
			((Control)textBox_0).set_Width(((Control)this).get_Width() - 45);
		}
		textBox_0.set_TextAlign(TextAlignment);
		textBox_0.set_UseSystemPasswordChar(UseSystemPasswordChar);
		val2.Clear(Color.Transparent);
		val2.FillPath((Brush)(object)solidBrush_0, graphicsPath_0);
		val2.DrawPath(pen_0, graphicsPath_0);
		if (Image != null)
		{
			val2.DrawImage(image_0, 5, 8, 24, 24);
		}
		paintEventArgs_0.get_Graphics().DrawImage((Image)((Image)val).Clone(), 0, 0);
		val2.Dispose();
		((Image)val).Dispose();
	}
}
