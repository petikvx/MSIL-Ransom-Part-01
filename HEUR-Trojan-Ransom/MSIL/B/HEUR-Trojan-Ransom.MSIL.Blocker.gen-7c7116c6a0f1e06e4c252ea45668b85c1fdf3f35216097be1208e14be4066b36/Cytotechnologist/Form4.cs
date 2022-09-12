using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Cytotechnologist;

public class Form4 : Form
{
	private IContainer components = null;

	private TextBox textBox1;

	private TextBox textBox2;

	private TextBox textBox3;

	private Button button1;

	private ErrorProvider errorProvider1;

	public Form4()
	{
		InitializeComponent();
	}

	private void Form4_FormClosing(object sender, FormClosingEventArgs e)
	{
		Form4.smethod_1((Control)(object)Form4.smethod_0((Form)(object)this), bool_0: true);
		while (true)
		{
			int num = 1518833555;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2AB00DB6u) % 3u)
				{
				case 1u:
					goto IL_000e;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000e:
				num = ((int)num2 * -1102160415) ^ -209074925;
			}
		}
	}

	private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -780084252;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA298B2DDu) % 6u)
				{
				case 5u:
					Form4.smethod_3(e, bool_0: true);
					num = ((int)num2 * -1288880252) ^ 0x4A3E9287;
					continue;
				case 4u:
					num = (int)(num2 * 1999468277) ^ -828619605;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 194523477;
						num4 = 194523477;
					}
					else
					{
						num3 = 249343710;
						num4 = 249343710;
					}
					num = num3 ^ ((int)num2 * -463726057);
					continue;
				}
				case 1u:
					flag = Form4.smethod_2(e) == ' ';
					num = ((int)num2 * -1895221283) ^ -1240938027;
					continue;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	private void TextBox_TextChanged(object sender, EventArgs e)
	{
		Form4.smethod_4(errorProvider1);
		while (true)
		{
			int num = 1284701026;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x485A32D9u) % 3u)
				{
				case 1u:
					goto IL_000d;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000d:
				num = ((int)num2 * -910124555) ^ -1588353020;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		while (true)
		{
			int num = 1199485317;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x379E9AF5u) % 9u)
				{
				case 8u:
					num = (int)((num2 * 1975969821) ^ 0x169347DF);
					continue;
				case 5u:
					((Form)this).Dispose(disposing);
					num = 556996270;
					continue;
				case 4u:
					Form4.smethod_5((IDisposable)components);
					num = ((int)num2 * -1308481601) ^ 0x4AFCD991;
					continue;
				case 3u:
					num = (int)((num2 * 955496759) ^ 0x582DF6B0);
					continue;
				case 2u:
					if (disposing)
					{
						num = ((int)num2 * -2078571024) ^ -1106687502;
						continue;
					}
					goto IL_006d;
				case 1u:
					if (components != null)
					{
						num = 704251430;
						num3 = 704251430;
						continue;
					}
					goto IL_006d;
				case 0u:
					num = (int)(num2 * 703306824) ^ -1260952491;
					continue;
				default:
					return;
				case 7u:
					break;
				case 6u:
					return;
					IL_006d:
					num = 332364333;
					num3 = 332364333;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected O, but got Unknown
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected O, but got Unknown
		while (true)
		{
			int num = 1759449359;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x53FD9427u) % 55u)
				{
				case 54u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = ((int)num2 * -850653012) ^ -431093709;
					continue;
				case 53u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					Form4.smethod_29((Form)(object)this, bool_0: false);
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1854626405) ^ -1184304998;
					continue;
				case 52u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -71114511) ^ -2126037849;
					continue;
				case 51u:
					num = ((int)num2 * -883006291) ^ -1684949454;
					continue;
				case 50u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					num = (int)(num2 * 617239396) ^ -1409364680;
					continue;
				case 49u:
					num = ((int)num2 * -1395241057) ^ 0x748D4035;
					continue;
				case 48u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = (int)((num2 * 1970914192) ^ 0x550E902F);
					continue;
				case 47u:
					num = ((int)num2 * -1621037378) ^ -949232749;
					continue;
				case 46u:
					Form4.smethod_15((Control)(object)button1, 0);
					Form4.smethod_19((Control)(object)button1, "Добавить");
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 1504372121) ^ -1662477093;
					continue;
				case 45u:
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = ((int)num2 * -885096318) ^ -172934811;
					continue;
				case 44u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = ((int)num2 * -2005575359) ^ 0x18B9530;
					continue;
				case 43u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -493401315) ^ -25134000;
					continue;
				case 42u:
					num = (int)(num2 * 2141370885) ^ -8400997;
					continue;
				case 41u:
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -208821072) ^ -839248702;
					continue;
				case 40u:
					num = (int)(num2 * 265380561) ^ -236699990;
					continue;
				case 39u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = ((int)num2 * -903937508) ^ 0x6F58EEB6;
					continue;
				case 38u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 1711789287) ^ 0x3090DBE2);
					continue;
				case 37u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					Form4.smethod_18(textBox3, bool_0: true);
					num = (int)((num2 * 1758907909) ^ 0x8AFE7AD);
					continue;
				case 36u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = (int)((num2 * 309980058) ^ 0x16177AE3);
					continue;
				case 35u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = ((int)num2 * -1359416532) ^ -583917360;
					continue;
				case 34u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = (int)(num2 * 561211134) ^ -100057804;
					continue;
				case 33u:
					textBox2 = Form4.smethod_7();
					num = ((int)num2 * -208839459) ^ 0x63989F9C;
					continue;
				case 32u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = (int)(num2 * 1178385976) ^ -1458900613;
					continue;
				case 31u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = (int)(num2 * 988830522) ^ -121513020;
					continue;
				case 30u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = (int)((num2 * 1623982798) ^ 0x28D44727);
					continue;
				case 29u:
					textBox3 = Form4.smethod_7();
					num = ((int)num2 * -144326610) ^ 0x41DEB827;
					continue;
				case 28u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = ((int)num2 * -819328899) ^ 0x6A0CBD5B;
					continue;
				case 27u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = (int)((num2 * 559797169) ^ 0x43DABDB5);
					continue;
				case 26u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = (int)((num2 * 1284695186) ^ 0x56F62B90);
					continue;
				case 25u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = (int)((num2 * 326505909) ^ 0x55B180A5);
					continue;
				case 24u:
					button1 = Form4.smethod_8();
					num = ((int)num2 * -2009721865) ^ 0x502939C7;
					continue;
				case 22u:
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = (int)(num2 * 911256801) ^ -978988272;
					continue;
				case 21u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = (int)((num2 * 1953662236) ^ 0x3091449D);
					continue;
				case 20u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -1848662739) ^ -1967790485;
					continue;
				case 19u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = (int)(num2 * 1424022030) ^ -286112274;
					continue;
				case 18u:
					num = ((int)num2 * -1907592314) ^ -1970533071;
					continue;
				case 17u:
					Form4.smethod_11((Control)(object)this);
					num = (int)((num2 * 93555709) ^ 0x7A4F71B7);
					continue;
				case 15u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = ((int)num2 * -1546214857) ^ 0x486B3ABE;
					continue;
				case 14u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 146105438) ^ 0x79825967);
					continue;
				case 13u:
					num = (int)(num2 * 700742498) ^ -1562747531;
					continue;
				case 12u:
					errorProvider1 = Form4.smethod_9(components);
					num = ((int)num2 * -1815901722) ^ -829124598;
					continue;
				case 11u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -825293518) ^ 0x1FA47F69;
					continue;
				case 10u:
					num = ((int)num2 * -294701993) ^ 0x2F8C3419;
					continue;
				case 9u:
					Form4.smethod_31((Control)(object)this, "Form4");
					num = (int)((num2 * 46477066) ^ 0x21FABE57);
					continue;
				case 8u:
					num = (int)(num2 * 1098333351) ^ -1231473059;
					continue;
				case 7u:
					Form4.smethod_37((Control)(object)this);
					num = (int)((num2 * 284438739) ^ 0x5F86CABB);
					continue;
				case 6u:
					components = Form4.smethod_6();
					textBox1 = Form4.smethod_7();
					num = (int)(num2 * 326517297) ^ -1984176271;
					continue;
				case 5u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = (int)(num2 * 473687896) ^ -1752771979;
					continue;
				case 4u:
					Form4.smethod_18(textBox2, bool_0: true);
					num = ((int)num2 * -193880406) ^ -417949379;
					continue;
				case 3u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -15565021) ^ 0x3C21C3AB;
					continue;
				case 2u:
					num = (int)((num2 * 791406217) ^ 0x7F4153DB);
					continue;
				case 1u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1547382193) ^ 0x6F3BD187;
					continue;
				case 0u:
					num = ((int)num2 * -1792311839) ^ 0x290DF969;
					continue;
				default:
					return;
				case 16u:
					break;
				case 23u:
					return;
				}
				break;
			}
		}
	}

	static Form smethod_0(Form form_0)
	{
		return form_0.get_Owner();
	}

	static void smethod_1(Control control_0, bool bool_0)
	{
		control_0.set_Enabled(bool_0);
	}

	static char smethod_2(KeyPressEventArgs keyPressEventArgs_0)
	{
		return keyPressEventArgs_0.get_KeyChar();
	}

	static void smethod_3(KeyPressEventArgs keyPressEventArgs_0, bool bool_0)
	{
		keyPressEventArgs_0.set_Handled(bool_0);
	}

	static void smethod_4(ErrorProvider errorProvider_0)
	{
		errorProvider_0.Clear();
	}

	static void smethod_5(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_6()
	{
		return new Container();
	}

	static TextBox smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static Button smethod_8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static ErrorProvider smethod_9(IContainer icontainer_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new ErrorProvider(icontainer_0);
	}

	static void smethod_10(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_11(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_12(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_13(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_14(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_15(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_16(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_TextChanged(eventHandler_0);
	}

	static void smethod_17(Control control_0, KeyPressEventHandler keyPressEventHandler_0)
	{
		control_0.add_KeyPress(keyPressEventHandler_0);
	}

	static void smethod_18(TextBox textBox_0, bool bool_0)
	{
		textBox_0.set_UseSystemPasswordChar(bool_0);
	}

	static void smethod_19(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static void smethod_20(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_21(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_22(ErrorProvider errorProvider_0, ContainerControl containerControl_0)
	{
		errorProvider_0.set_ContainerControl(containerControl_0);
	}

	static void smethod_23(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_24(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_25(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_26(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_27(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_28(Form form_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_FormBorderStyle(formBorderStyle_0);
	}

	static void smethod_29(Form form_0, bool bool_0)
	{
		form_0.set_MaximizeBox(bool_0);
	}

	static void smethod_30(Form form_0, bool bool_0)
	{
		form_0.set_MinimizeBox(bool_0);
	}

	static void smethod_31(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_32(Form form_0, bool bool_0)
	{
		form_0.set_ShowIcon(bool_0);
	}

	static void smethod_33(Form form_0, bool bool_0)
	{
		form_0.set_ShowInTaskbar(bool_0);
	}

	static void smethod_34(Form form_0, FormClosingEventHandler formClosingEventHandler_0)
	{
		form_0.add_FormClosing(formClosingEventHandler_0);
	}

	static void smethod_35(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_36(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_37(Control control_0)
	{
		control_0.PerformLayout();
	}
}
