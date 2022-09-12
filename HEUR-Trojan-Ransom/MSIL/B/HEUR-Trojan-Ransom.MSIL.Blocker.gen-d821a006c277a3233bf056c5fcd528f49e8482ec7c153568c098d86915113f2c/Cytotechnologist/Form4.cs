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
			int num = -504045235;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA75885B9u) % 3u)
				{
				case 1u:
					goto IL_000e;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_000e:
				num = (int)((num2 * 320275205) ^ 0x2CF50A90);
			}
		}
	}

	private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -1225896641;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB27B492Au) % 6u)
				{
				case 4u:
					num = (int)(num2 * 1617567709) ^ -2062045393;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -201254544;
						num4 = -201254544;
					}
					else
					{
						num3 = -1097917029;
						num4 = -1097917029;
					}
					num = num3 ^ ((int)num2 * -1808183702);
					continue;
				}
				case 1u:
					flag = Form4.smethod_2(e) == ' ';
					num = ((int)num2 * -610332578) ^ -1084871243;
					continue;
				case 0u:
					Form4.smethod_3(e, bool_0: true);
					num = ((int)num2 * -533275989) ^ -876974484;
					continue;
				default:
					return;
				case 2u:
					break;
				case 5u:
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
			int num = -276908518;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB8ADF423u) % 3u)
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
				num = ((int)num2 * -512600351) ^ 0x57DCBF69;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_0009;
		}
		int num = 0;
		goto IL_009f;
		IL_0096:
		num = ((components != null) ? 1 : 0);
		goto IL_009f;
		IL_0009:
		int num2 = 248215034;
		goto IL_0069;
		IL_0069:
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x3E257F39u) % 7u)
			{
			case 6u:
				break;
			case 4u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = -462735884;
					num5 = -462735884;
				}
				else
				{
					num4 = -1197071177;
					num5 = -1197071177;
				}
				num2 = num4 ^ (int)(num3 * 141478380);
				continue;
			}
			case 2u:
				((Form)this).Dispose(disposing);
				num2 = 1986320399;
				continue;
			case 1u:
				Form4.smethod_5((IDisposable)components);
				num2 = (int)((num3 * 1031609894) ^ 0x313BE840);
				continue;
			case 0u:
				num2 = ((int)num3 * -369690615) ^ -936292038;
				continue;
			default:
				return;
			case 3u:
				goto IL_0096;
			case 5u:
				return;
			}
			break;
		}
		goto IL_0009;
		IL_009f:
		flag = (byte)num != 0;
		num2 = 1067941329;
		goto IL_0069;
	}

	private void InitializeComponent()
	{
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Expected O, but got Unknown
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Expected O, but got Unknown
		//IL_072b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0735: Expected O, but got Unknown
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Expected O, but got Unknown
		components = Form4.smethod_6();
		while (true)
		{
			int num = 628400882;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x316C91F3u) % 63u)
				{
				case 62u:
					num = (int)((num2 * 1143356100) ^ 0x2AA32B48);
					continue;
				case 61u:
					num = (int)((num2 * 562281518) ^ 0xF8EDCEF);
					continue;
				case 60u:
					num = (int)((num2 * 569814682) ^ 0x3D320933);
					continue;
				case 59u:
					num = (int)(num2 * 605541439) ^ -650991200;
					continue;
				case 58u:
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = (int)(num2 * 647697305) ^ -1721856552;
					continue;
				case 57u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = ((int)num2 * -2010153341) ^ -1554409702;
					continue;
				case 56u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = (int)((num2 * 80292574) ^ 0x7CB4A68E);
					continue;
				case 55u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 309691204) ^ 0x2585F809);
					continue;
				case 54u:
					textBox3 = Form4.smethod_7();
					button1 = Form4.smethod_8();
					num = (int)(num2 * 909513293) ^ -1281596568;
					continue;
				case 53u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = (int)(num2 * 1614177252) ^ -2545254;
					continue;
				case 52u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1967992013) ^ -934573422;
					continue;
				case 51u:
					num = ((int)num2 * -994683555) ^ 0x76F36056;
					continue;
				case 50u:
					textBox2 = Form4.smethod_7();
					num = ((int)num2 * -1020064713) ^ 0x799254F5;
					continue;
				case 49u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = (int)((num2 * 918486012) ^ 0x61C79B9F);
					continue;
				case 48u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					num = (int)(num2 * 2042333818) ^ -691012615;
					continue;
				case 47u:
					num = ((int)num2 * -2138865827) ^ 0x1970CEF5;
					continue;
				case 46u:
					Form4.smethod_18(textBox3, bool_0: true);
					num = ((int)num2 * -1021847744) ^ -337503016;
					continue;
				case 45u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = (int)((num2 * 47028009) ^ 0x4907781D);
					continue;
				case 44u:
					Form4.smethod_37((Control)(object)this);
					num = (int)(num2 * 144022201) ^ -1104710792;
					continue;
				case 43u:
					errorProvider1 = Form4.smethod_9(components);
					num = (int)((num2 * 1037627314) ^ 0x6BFBEAE);
					continue;
				case 42u:
					textBox1 = Form4.smethod_7();
					num = ((int)num2 * -1612023591) ^ -2060441376;
					continue;
				case 41u:
					Form4.smethod_11((Control)(object)this);
					num = ((int)num2 * -881904940) ^ -254228524;
					continue;
				case 40u:
					num = (int)(num2 * 343637512) ^ -2105807551;
					continue;
				case 39u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1335564584) ^ 0x17D7A3F6;
					continue;
				case 38u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -694698054) ^ -999499505;
					continue;
				case 37u:
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 565529257) ^ -1700394145;
					continue;
				case 36u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -1892930578) ^ -95069856;
					continue;
				case 35u:
					num = ((int)num2 * -1962571793) ^ 0x7CC364A8;
					continue;
				case 33u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = (int)(num2 * 1864608040) ^ -684878946;
					continue;
				case 32u:
					num = (int)((num2 * 2069950090) ^ 0x73603D7D);
					continue;
				case 30u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 801608398) ^ 0x1C933449);
					continue;
				case 29u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = ((int)num2 * -609668383) ^ -1648406646;
					continue;
				case 28u:
					Form4.smethod_18(textBox2, bool_0: true);
					num = (int)((num2 * 1384670753) ^ 0x7B484371);
					continue;
				case 27u:
					num = ((int)num2 * -1897486207) ^ -649153494;
					continue;
				case 26u:
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -893844270) ^ 0x6AA51C11;
					continue;
				case 25u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = ((int)num2 * -721026572) ^ 0x2E418F9F;
					continue;
				case 24u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					num = (int)((num2 * 1643057987) ^ 0x21A21DB3);
					continue;
				case 23u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1724816949) ^ 0x3BE1AC50);
					continue;
				case 22u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1884112992) ^ -1935053539;
					continue;
				case 21u:
					num = (int)(num2 * 122450761) ^ -379803430;
					continue;
				case 20u:
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = ((int)num2 * -221601262) ^ -1095157884;
					continue;
				case 19u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = (int)(num2 * 1617314962) ^ -1609366287;
					continue;
				case 18u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -214730890) ^ -1908406463;
					continue;
				case 17u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = (int)((num2 * 1615733259) ^ 0x162AC972);
					continue;
				case 16u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = ((int)num2 * -1900560039) ^ -1077717343;
					continue;
				case 15u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = (int)(num2 * 94084337) ^ -368943596;
					continue;
				case 14u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = (int)(num2 * 1180977711) ^ -41162993;
					continue;
				case 13u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)(num2 * 1169576709) ^ -1943116325;
					continue;
				case 12u:
					Form4.smethod_31((Control)(object)this, "Form4");
					num = (int)((num2 * 670701780) ^ 0x601F6E6D);
					continue;
				case 11u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = (int)((num2 * 1828802071) ^ 0x10044E98);
					continue;
				case 10u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = (int)((num2 * 623738125) ^ 0x4C7D6AE3);
					continue;
				case 9u:
					num = (int)(num2 * 707307181) ^ -1536993520;
					continue;
				case 8u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = (int)(num2 * 553398564) ^ -1789436505;
					continue;
				case 7u:
					num = ((int)num2 * -118338675) ^ 0x340C3649;
					continue;
				case 6u:
					num = ((int)num2 * -124803831) ^ 0x21279FA4;
					continue;
				case 5u:
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = (int)((num2 * 579314504) ^ 0x6C854D2C);
					continue;
				case 4u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = ((int)num2 * -797608305) ^ -1016780550;
					continue;
				case 3u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = ((int)num2 * -178428595) ^ 0x2ADF54BC;
					continue;
				case 2u:
					num = ((int)num2 * -472147936) ^ -2102527859;
					continue;
				case 1u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)((num2 * 1425256312) ^ 0xD1FD7DA);
					continue;
				case 0u:
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -1757146489) ^ 0x51C3EB00;
					continue;
				default:
					return;
				case 34u:
					break;
				case 31u:
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
