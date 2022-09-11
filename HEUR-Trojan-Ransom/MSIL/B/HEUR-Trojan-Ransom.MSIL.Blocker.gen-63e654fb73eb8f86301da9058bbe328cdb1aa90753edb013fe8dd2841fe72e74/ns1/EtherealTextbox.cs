using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ns1;

public class EtherealTextbox : Control
{
	private bool bool_0;

	private Image image_0;

	private bool bool_1;

	protected HelperMethods.MouseMode mouseMode_0;

	private Color color_0;

	private Color color_1;

	internal TextBox textBox_0;

	internal HorizontalAlignment horizontalAlignment_0;

	internal int int_0;

	internal bool bool_2;

	internal string string_0;

	internal Color color_2;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public BorderStyle BorderStyle => (BorderStyle)0;

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool Multiline
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
			if (textBox_0 != null)
			{
				((TextBoxBase)textBox_0).set_Multiline(value);
			}
		}
	}

	public HorizontalAlignment TextAlign
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
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			HorizontalAlignment val = (horizontalAlignment_0 = value);
			if (textBox_0 != null)
			{
				textBox_0.set_TextAlign(value);
			}
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
			if (textBox_0 != null)
			{
				((TextBoxBase)textBox_0).set_MaxLength(value);
			}
		}
	}

	public bool ReadOnly
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
				((TextBoxBase)textBox_0).set_ReadOnly(value);
			}
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
			bool flag = (bool_2 = value);
			if (textBox_0 != null)
			{
				textBox_0.set_UseSystemPasswordChar(value);
			}
		}
	}

	public string WatermarkText
	{
		get
		{
			return string_0;
		}
		set
		{
			string text = (string_0 = value);
			((Control)this).Invalidate();
		}
	}

	public Image SideImage
	{
		get
		{
			return image_0;
		}
		set
		{
			image_0 = value;
			((Control)this).Invalidate();
		}
	}

	[Browsable(false)]
	public override Image BackgroundImage
	{
		get
		{
			return ((Control)this).get_BackgroundImage();
		}
		set
		{
			((Control)this).set_BackgroundImage(value);
		}
	}

	[Browsable(false)]
	public override ImageLayout BackgroundImageLayout
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_BackgroundImageLayout();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).set_BackgroundImageLayout(value);
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
		}
	}

	public override Color BackColor
	{
		get
		{
			return color_0;
		}
		set
		{
			((Control)this).set_BackColor(value);
			((Control)textBox_0).set_BackColor(value);
			color_0 = value;
			((Control)this).Invalidate();
		}
	}

	public override Color ForeColor
	{
		get
		{
			return color_2;
		}
		set
		{
			((Control)this).set_ForeColor(value);
			((Control)textBox_0).set_ForeColor(value);
			Color color = (color_2 = value);
			((Control)this).Invalidate();
		}
	}

	public Color BorderColor
	{
		get
		{
			return color_1;
		}
		set
		{
			color_1 = value;
			((Control)this).Invalidate();
		}
	}

	public EtherealTextbox()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		TextBox val = (textBox_0 = new TextBox());
		int_0 = 32767;
		string text = (string_0 = "");
		Color color = (color_2 = Color.Gray);
		color_0 = Color.White;
		color_1 = HelperMethods.smethod_10(" ");
		((Control)this)._002Ector();
		((Control)this).SetStyle((ControlStyles)141330, true);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).UpdateStyles();
		((Control)this).set_Font(new Font(" ", 10f, (FontStyle)0));
		((Control)this).set_Text(WatermarkText);
		((Control)this).set_Size(new Size(135, 30));
		((TextBoxBase)textBox_0).set_Multiline(bool_1);
		((Control)textBox_0).set_Cursor(Cursors.get_IBeam());
		((Control)textBox_0).set_BackColor(Color.White);
		((Control)textBox_0).set_ForeColor(Color.Gray);
		((Control)textBox_0).set_Text(WatermarkText);
		((TextBoxBase)textBox_0).set_BorderStyle((BorderStyle)0);
		((Control)textBox_0).set_Location(new Point(7, 7));
		((Control)textBox_0).set_Font(((Control)this).get_Font());
		((Control)textBox_0).set_Size(new Size(((Control)this).get_Width() - 10, 30));
		textBox_0.set_UseSystemPasswordChar(bool_2);
		((Control)textBox_0).add_TextChanged((EventHandler)textBox_0_TextChanged);
		((Control)textBox_0).add_KeyDown(new KeyEventHandler(textBox_0_KeyDown));
	}

	protected override void vmethod_0(PaintEventArgs paintEventArgs_0)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		((Control)this).OnPaint(paintEventArgs_0);
		new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			val2.set_SmoothingMode((SmoothingMode)2);
			val2.Clear(((Control)this).get_BackColor());
			HelperMethods.smethod_4(val2, BorderColor, 1f, new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1), 4);
			if (SideImage != null)
			{
				((Control)textBox_0).set_Location(new Point(45, 5));
				((Control)textBox_0).set_Width(((Control)this).get_Width() - 60);
				val2.DrawRectangle(new Pen(BorderColor, 1f), new Rectangle(-1, -1, 35, ((Control)this).get_Height() + 1));
				val2.DrawImage(SideImage, new Rectangle(8, 7, 16, 16));
			}
			else
			{
				((Control)textBox_0).set_Location(new Point(7, 5));
				((Control)textBox_0).set_Width(((Control)this).get_Width() - 10);
			}
			if (((Control)this).get_ContextMenuStrip() != null)
			{
				((Control)textBox_0).set_ContextMenuStrip(((Control)this).get_ContextMenuStrip());
			}
			paintEventArgs_0.get_Graphics().DrawImage((Image)((Image)val).Clone(), 0, 0);
			val2.Dispose();
			((Image)val).Dispose();
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	private void method_0(object sender, EventArgs e)
	{
		mouseMode_0 = HelperMethods.MouseMode.Hovered;
	}

	private void method_1(object sender, EventArgs e)
	{
		mouseMode_0 = HelperMethods.MouseMode.NormalMode;
	}

	private void method_2(object sender, EventArgs e)
	{
		mouseMode_0 = HelperMethods.MouseMode.Pushed;
	}

	private void method_3(object sender, EventArgs e)
	{
		mouseMode_0 = HelperMethods.MouseMode.Pushed;
	}

	private void method_4(object sender, EventArgs e)
	{
		mouseMode_0 = HelperMethods.MouseMode.Pushed;
	}

	private void textBox_0_TextChanged(object sender, EventArgs e)
	{
		((Control)this).set_Text(((Control)textBox_0).get_Text());
	}

	protected override void vmethod_1(EventArgs eventArgs_0)
	{
		((Control)this).OnTextChanged(eventArgs_0);
		((Control)textBox_0).set_Text(((Control)this).get_Text());
	}

	private void textBox_0_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		if (e.get_Control() && (int)e.get_KeyCode() == 65)
		{
			e.set_SuppressKeyPress(true);
		}
		if (e.get_Control() && (int)e.get_KeyCode() == 67)
		{
			((TextBoxBase)textBox_0).Copy();
			e.set_SuppressKeyPress(true);
		}
	}

	protected override void vmethod_2()
	{
		((Control)this).OnCreateControl();
		if (!((Control)this).get_Controls().Contains((Control)(object)textBox_0))
		{
			((Control)this).get_Controls().Add((Control)(object)textBox_0);
		}
		if (((Control)textBox_0).get_Text() == "" && WatermarkText != "")
		{
			((Control)textBox_0).set_Text(WatermarkText);
		}
	}

	protected override void vmethod_3(EventArgs eventArgs_0)
	{
		((Control)this).OnResize(eventArgs_0);
		if (!bool_1)
		{
			((Control)this).set_Height(30);
		}
	}
}
