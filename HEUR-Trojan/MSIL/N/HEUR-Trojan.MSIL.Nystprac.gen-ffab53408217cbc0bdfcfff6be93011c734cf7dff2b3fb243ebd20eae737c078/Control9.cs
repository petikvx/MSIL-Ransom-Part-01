using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DefaultEvent("TextChanged")]
internal class Control9 : Control2
{
	private HorizontalAlignment horizontalAlignment_0;

	private int int_2;

	private bool bool_6;

	private bool bool_7;

	private bool bool_8;

	private TextBox textBox_0;

	private Color color_0;

	private Pen pen_0;

	private Pen pen_1;

	public override string Text
	{
		get
		{
			return base.Text;
		}
		set
		{
			base.Text = value;
			if (textBox_0 != null)
			{
				textBox_0.set_Text(value);
			}
		}
	}

	public override Font Font
	{
		get
		{
			return base.Font;
		}
		set
		{
			base.Font = value;
			checked
			{
				if (textBox_0 != null)
				{
					((Control)textBox_0).set_Font(value);
					TextBox obj = textBox_0;
					Point location = new Point(3, 5);
					((Control)obj).set_Location(location);
					((Control)textBox_0).set_Width(((Control)this).get_Width() - 6);
					if (!bool_8)
					{
						method_15(((Control)textBox_0).get_Height() + 11);
					}
				}
			}
		}
	}

	[SpecialName]
	public HorizontalAlignment method_82()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return horizontalAlignment_0;
	}

	[SpecialName]
	public void method_83(HorizontalAlignment horizontalAlignment_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		horizontalAlignment_0 = horizontalAlignment_1;
		if (textBox_0 != null)
		{
			textBox_0.set_TextAlign(horizontalAlignment_1);
		}
	}

	[SpecialName]
	public int method_84()
	{
		return int_2;
	}

	[SpecialName]
	public void method_85(int int_3)
	{
		int_2 = int_3;
		if (textBox_0 != null)
		{
			((TextBoxBase)textBox_0).set_MaxLength(int_3);
		}
	}

	[SpecialName]
	public bool method_86()
	{
		return bool_6;
	}

	[SpecialName]
	public void method_87(bool bool_9)
	{
		bool_6 = bool_9;
		if (textBox_0 != null)
		{
			((TextBoxBase)textBox_0).set_ReadOnly(bool_9);
		}
	}

	[SpecialName]
	public bool method_88()
	{
		return bool_7;
	}

	[SpecialName]
	public void method_89(bool bool_9)
	{
		bool_7 = bool_9;
		if (textBox_0 != null)
		{
			textBox_0.set_UseSystemPasswordChar(bool_9);
		}
	}

	[SpecialName]
	public bool method_90()
	{
		return bool_8;
	}

	[SpecialName]
	public void method_91(bool bool_9)
	{
		bool_8 = bool_9;
		checked
		{
			if (textBox_0 != null)
			{
				textBox_0.set_Multiline(bool_9);
				if (bool_9)
				{
					method_15(0);
					((Control)textBox_0).set_Height(((Control)this).get_Height() - 11);
				}
				else
				{
					method_15(((Control)textBox_0).get_Height() + 11);
				}
			}
		}
	}

	protected override void OnCreation()
	{
		if (!((Control)this).get_Controls().Contains((Control)(object)textBox_0))
		{
			((Control)this).get_Controls().Add((Control)(object)textBox_0);
		}
	}

	public Control9()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		Class14.hYiyYvszsKHjE();
		base._002Ector();
		horizontalAlignment_0 = (HorizontalAlignment)0;
		int_2 = 32767;
		textBox_0 = new TextBox();
		((Control)textBox_0).set_Font(Font);
		textBox_0.set_Text(Text);
		((TextBoxBase)textBox_0).set_MaxLength(int_2);
		textBox_0.set_Multiline(bool_8);
		((TextBoxBase)textBox_0).set_ReadOnly(bool_6);
		textBox_0.set_UseSystemPasswordChar(bool_7);
		((TextBoxBase)textBox_0).set_BorderStyle((BorderStyle)0);
		TextBox obj = textBox_0;
		Point location = new Point(5, 5);
		((Control)obj).set_Location(location);
		checked
		{
			((Control)textBox_0).set_Width(((Control)this).get_Width() - 10);
			if (bool_8)
			{
				((Control)textBox_0).set_Height(((Control)this).get_Height() - 11);
			}
			else
			{
				method_15(((Control)textBox_0).get_Height() + 11);
			}
			((Control)textBox_0).add_TextChanged((EventHandler)textBox_0_TextChanged);
			((Control)textBox_0).add_KeyDown(new KeyEventHandler(textBox_0_KeyDown));
			method_22("Text", Color.White);
			method_23("Back", 0, 0, 0);
			method_22("Border1", Color.Black);
			method_23("Border2", 90, 90, 90);
		}
	}

	protected override void ColorHook()
	{
		color_0 = method_21("Back");
		pen_0 = method_18("Border1");
		pen_1 = method_18("Border2");
		((TextBoxBase)textBox_0).set_ForeColor(method_21("Text"));
		((TextBoxBase)textBox_0).set_BackColor(color_0);
	}

	protected override void PaintHook()
	{
		graphics_0.Clear(color_0);
		method_47(pen_0, 1);
		method_50(pen_1);
	}

	private void textBox_0_TextChanged(object sender, EventArgs e)
	{
		Text = textBox_0.get_Text();
	}

	private void textBox_0_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		if ((e.get_Control() && (int)e.get_KeyCode() == 65) ? true : false)
		{
			((TextBoxBase)textBox_0).SelectAll();
			e.set_SuppressKeyPress(true);
		}
	}

	protected override void OnResize(EventArgs eventargs)
	{
		TextBox obj = textBox_0;
		Point location = new Point(5, 5);
		((Control)obj).set_Location(location);
		checked
		{
			((Control)textBox_0).set_Width(((Control)this).get_Width() - 10);
			if (bool_8)
			{
				((Control)textBox_0).set_Height(((Control)this).get_Height() - 11);
			}
			((Control)this).OnResize(eventargs);
		}
	}
}
