using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class GControl20 : GControl17
{
	[AccessedThroughProperty("txtbox")]
	private TextBox textBox_0;

	private bool bool_2;

	private int int_2;

	private Color color_1;

	private Color color_2;

	private Color color_3;

	private Color color_4;

	private Color color_5;

	private Color color_6;

	private virtual TextBox TextBox_0
	{
		get
		{
			return textBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = delegate
			{
				method_44();
			};
			for (int num = 0; num == 0; num = 1)
			{
				if (textBox_0 != null)
				{
					((Control)textBox_0).remove_TextChanged(eventHandler);
				}
				textBox_0 = value;
			}
			if (textBox_0 != null)
			{
				((Control)textBox_0).add_TextChanged(eventHandler);
			}
		}
	}

	public bool Boolean_2
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
			for (int num = 0; num == 0; num = 1)
			{
				((Control)this).Invalidate();
			}
		}
	}

	public int Int32_2
	{
		get
		{
			return int_2;
		}
		set
		{
			int_2 = value;
		}
	}

	public GControl20()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		if (1 == 0)
		{
		}
		base._002Ector();
		((Control)this).add_TextChanged((EventHandler)delegate
		{
			method_45();
		});
		TextBox_0 = new TextBox();
		TextBox_0.set_TextAlign((HorizontalAlignment)2);
		((TextBoxBase)TextBox_0).set_BorderStyle((BorderStyle)0);
		TextBox obj = TextBox_0;
		Point location = new Point(5, 6);
		((Control)obj).set_Location(location);
		((Control)TextBox_0).set_Font(new Font("Verdana", 7.25f));
		((Control)this).get_Controls().Add((Control)(object)TextBox_0);
		BackColor = Color.FromArgb(37, 37, 37);
		Text = "";
		TextBox_0.set_Text("");
		Size size = new Size(135, 35);
		((Control)this).set_Size(size);
		method_3("BackColor", Color.FromArgb(37, 37, 37));
		method_3("TextColor", Color.White);
		method_3("TopInset", Color.FromArgb(45, 45, 45));
		method_3("BottomInset", Color.FromArgb(70, 70, 70));
		method_3("TextBoxShadow", Color.FromArgb(31, 31, 31));
		method_3("BorderColor", Color.Black);
	}

	protected override void vmethod_1()
	{
		color_1 = method_2("BackColor");
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 6:
				((TextBoxBase)TextBox_0).set_BackColor(color_1);
				num = 7;
				break;
			case 5:
				((TextBoxBase)TextBox_0).set_ForeColor(color_2);
				num = 6;
				break;
			case 4:
				color_6 = method_2("BorderColor");
				num = 5;
				break;
			case 3:
				color_5 = method_2("TextBoxShadow");
				num = 4;
				break;
			case 2:
				color_4 = method_2("BottomInset");
				num = 3;
				break;
			case 1:
				color_3 = method_2("TopInset");
				num = 2;
				break;
			case 0:
				color_2 = method_2("TextColor");
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected override void vmethod_2()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		graphics_0.Clear(BackColor);
		int num = 0;
		checked
		{
			while (true)
			{
				Size size;
				switch (num)
				{
				case 13:
				{
					Color backColor = BackColor;
					Rectangle rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2);
					method_18(backColor, rectangle);
					num = 14;
					continue;
				}
				case 12:
					method_17(BackColor);
					num = 13;
					continue;
				case 11:
					graphics_0.DrawLine(new Pen((Brush)new SolidBrush(color_5)), 2, 2, ((Control)this).get_Width() - 3, 2);
					num = 12;
					continue;
				case 10:
					graphics_0.DrawLine(new Pen((Brush)new SolidBrush(color_3)), ((Control)this).get_Width() - 1, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height());
					num = 11;
					continue;
				case 9:
					graphics_0.DrawLine(new Pen((Brush)new SolidBrush(color_3)), 0, 0, 0, ((Control)this).get_Height());
					num = 10;
					continue;
				case 8:
					graphics_0.DrawLine(new Pen((Brush)new SolidBrush(color_3)), 0, 0, ((Control)this).get_Width(), 0);
					num = 9;
					continue;
				case 7:
					method_24(new Pen((Brush)new SolidBrush(color_4)));
					num = 8;
					continue;
				case 6:
					method_21(new Pen((Brush)new SolidBrush(color_6)), 1);
					num = 7;
					continue;
				case 5:
				{
					Graphics obj2 = graphics_0;
					SolidBrush val = new SolidBrush(color_1);
					Rectangle rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2);
					obj2.FillRectangle((Brush)val, rectangle);
					num = 6;
					continue;
				}
				case 4:
					((TextBoxBase)TextBox_0).set_MaxLength(Int32_2);
					num = 5;
					continue;
				case 3:
				{
					TextBox obj = TextBox_0;
					size = new Size(((Control)this).get_Width() - 10, ((Control)TextBox_0).get_Height() - 10);
					((Control)obj).set_Size(size);
					num = 4;
					continue;
				}
				case 2:
					((Control)TextBox_0).set_Font(Font);
					num = 3;
					continue;
				case 1:
					break;
				case 0:
					switch (Boolean_2)
					{
					case false:
						TextBox_0.set_UseSystemPasswordChar(false);
						break;
					case true:
						TextBox_0.set_UseSystemPasswordChar(true);
						num = 1;
						continue;
					}
					break;
				default:
					return;
				}
				size = new Size(((Control)this).get_Width(), 25);
				((Control)this).set_Size(size);
				num = 2;
			}
		}
	}

	public void method_44()
	{
		if (1 == 0)
		{
		}
		Text = TextBox_0.get_Text();
	}

	public void method_45()
	{
		if (1 == 0)
		{
		}
		TextBox_0.set_Text(Text);
	}

	[CompilerGenerated]
	[DebuggerStepThrough]
	private void TextBox_0_TextChanged(object sender, EventArgs e)
	{
		method_44();
	}

	[CompilerGenerated]
	[DebuggerStepThrough]
	private void GControl20_TextChanged(object sender, EventArgs e)
	{
		method_45();
	}
}
