using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

[DefaultEvent("TextChanged")]
public class GControl9 : GControl2
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

	public HorizontalAlignment HorizontalAlignment_0
	{
		get
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			if (1 == 0)
			{
			}
			return horizontalAlignment_0;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			horizontalAlignment_0 = value;
			int num = 0;
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						textBox_0.set_TextAlign(value);
						num = 2;
						break;
					}
					return;
				case 0:
					flag = textBox_0 == null;
					num = 1;
					break;
				default:
					return;
				}
			}
		}
	}

	public int Int32_2
	{
		get
		{
			if (1 == 0)
			{
			}
			return int_2;
		}
		set
		{
			int_2 = value;
			int num = 0;
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						((TextBoxBase)textBox_0).set_MaxLength(value);
						num = 2;
						break;
					}
					return;
				case 0:
					flag = textBox_0 == null;
					num = 1;
					break;
				default:
					return;
				}
			}
		}
	}

	public bool Boolean_3
	{
		get
		{
			if (1 == 0)
			{
			}
			return bool_6;
		}
		set
		{
			bool_6 = value;
			int num = 0;
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						((TextBoxBase)textBox_0).set_ReadOnly(value);
						num = 2;
						break;
					}
					return;
				case 0:
					flag = textBox_0 == null;
					num = 1;
					break;
				default:
					return;
				}
			}
		}
	}

	public bool Boolean_4
	{
		get
		{
			if (1 == 0)
			{
			}
			return bool_7;
		}
		set
		{
			bool_7 = value;
			int num = 0;
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						textBox_0.set_UseSystemPasswordChar(value);
						num = 2;
						break;
					}
					return;
				case 0:
					flag = textBox_0 == null;
					num = 1;
					break;
				default:
					return;
				}
			}
		}
	}

	public bool Boolean_5
	{
		get
		{
			if (1 == 0)
			{
			}
			return bool_8;
		}
		set
		{
			bool_8 = value;
			int num = 0;
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				case 4:
					((Control)textBox_0).set_Height(((Control)this).get_Height() - 11);
					num = 5;
					break;
				case 3:
					if (!flag)
					{
						base.Int32_1 = 0;
						num = 4;
					}
					else
					{
						base.Int32_1 = ((Control)textBox_0).get_Height() + 11;
						num = 6;
					}
					break;
				case 2:
					flag = !value;
					num = 3;
					break;
				case 1:
					if (!flag)
					{
						((TextBoxBase)textBox_0).set_Multiline(value);
						num = 2;
						break;
					}
					return;
				case 0:
					flag = textBox_0 == null;
					num = 1;
					break;
				default:
					return;
				}
			}
		}
	}

	public override string Text
	{
		get
		{
			if (1 == 0)
			{
			}
			return base.Text;
		}
		set
		{
			base.Text = value;
			int num = 0;
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						((Control)textBox_0).set_Text(value);
						num = 2;
						break;
					}
					return;
				case 0:
					flag = textBox_0 == null;
					num = 1;
					break;
				default:
					return;
				}
			}
		}
	}

	public override Font Font
	{
		get
		{
			if (1 == 0)
			{
			}
			return base.Font;
		}
		set
		{
			base.Font = value;
			int num = 0;
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						base.Int32_1 = ((Control)textBox_0).get_Height() + 11;
						num = 6;
						break;
					}
					return;
				case 4:
					flag = bool_8;
					num = 5;
					break;
				case 3:
					((Control)textBox_0).set_Width(((Control)this).get_Width() - 6);
					num = 4;
					break;
				case 2:
					((Control)textBox_0).set_Location(new Point(3, 5));
					num = 3;
					break;
				case 1:
					if (!flag)
					{
						((Control)textBox_0).set_Font(value);
						num = 2;
						break;
					}
					return;
				case 0:
					flag = textBox_0 == null;
					num = 1;
					break;
				default:
					return;
				}
			}
		}
	}

	public GControl9()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		if (1 == 0)
		{
		}
		horizontalAlignment_0 = (HorizontalAlignment)0;
		int_2 = 32767;
		base._002Ector();
		textBox_0 = new TextBox();
		((Control)textBox_0).set_Font(((Control)this).get_Font());
		((Control)textBox_0).set_Text(((Control)this).get_Text());
		((TextBoxBase)textBox_0).set_MaxLength(int_2);
		((TextBoxBase)textBox_0).set_Multiline(bool_8);
		((TextBoxBase)textBox_0).set_ReadOnly(bool_6);
		textBox_0.set_UseSystemPasswordChar(bool_7);
		((TextBoxBase)textBox_0).set_BorderStyle((BorderStyle)0);
		((Control)textBox_0).set_Location(new Point(5, 5));
		((Control)textBox_0).set_Width(((Control)this).get_Width() - 10);
		if (bool_8)
		{
			((Control)textBox_0).set_Height(((Control)this).get_Height() - 11);
		}
		else
		{
			base.Int32_1 = ((Control)textBox_0).get_Height() + 11;
		}
		((Control)textBox_0).add_TextChanged((EventHandler)textBox_0_TextChanged);
		((Control)textBox_0).add_KeyDown(new KeyEventHandler(textBox_0_KeyDown));
		method_6("Text", Color.White);
		method_7("Back", 0, 0, 0);
		method_6("Border1", Color.Black);
		method_7("Border2", 90, 90, 90);
	}

	protected override void vmethod_2()
	{
		bool flag = ((Control)this).get_Controls().Contains((Control)(object)textBox_0);
		int num = 0;
		while (num == 0 && !flag)
		{
			((Control)this).get_Controls().Add((Control)(object)textBox_0);
			num = 1;
		}
	}

	protected override void vmethod_0()
	{
		color_0 = method_5("Back");
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 3:
				((Control)textBox_0).set_BackColor(color_0);
				num = 4;
				break;
			case 2:
				((Control)textBox_0).set_ForeColor(method_5("Text"));
				num = 3;
				break;
			case 1:
				pen_1 = method_2("Border2");
				num = 2;
				break;
			case 0:
				pen_0 = method_2("Border1");
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected override void vmethod_1()
	{
		graphics_0.Clear(color_0);
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				method_35(pen_1);
				num = 2;
				break;
			case 0:
				method_32(pen_0, 1);
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	private void textBox_0_TextChanged(object sender, EventArgs e)
	{
		if (1 == 0)
		{
		}
		((Control)this).set_Text(((Control)textBox_0).get_Text());
	}

	private void textBox_0_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		bool flag = !e.get_Control() || (int)e.get_KeyCode() != 65;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				e.set_SuppressKeyPress(true);
				num = 2;
				break;
			case 0:
				if (!flag)
				{
					((TextBoxBase)textBox_0).SelectAll();
					num = 1;
					break;
				}
				return;
			default:
				return;
			}
		}
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)textBox_0).set_Location(new Point(5, 5));
		int num = 0;
		bool flag = default(bool);
		while (true)
		{
			switch (num)
			{
			case 3:
				((Control)this).OnResize(e);
				num = 4;
				break;
			case 2:
				if (!flag)
				{
					((Control)textBox_0).set_Height(((Control)this).get_Height() - 11);
					num = 3;
					break;
				}
				goto case 3;
			case 1:
				flag = !bool_8;
				num = 2;
				break;
			case 0:
				((Control)textBox_0).set_Width(((Control)this).get_Width() - 10);
				num = 1;
				break;
			default:
				return;
			}
		}
	}
}
