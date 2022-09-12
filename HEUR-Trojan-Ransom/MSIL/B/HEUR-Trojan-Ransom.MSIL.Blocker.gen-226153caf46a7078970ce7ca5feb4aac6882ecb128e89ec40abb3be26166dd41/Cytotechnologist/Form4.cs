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
			int num = 723135506;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4A677FCFu) % 3u)
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
				num = (int)((num2 * 1543035635) ^ 0x662687B6);
			}
		}
	}

	private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		while (true)
		{
			int num = 2096697827;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3DEBB1ADu) % 5u)
				{
				case 4u:
					num = (int)((num2 * 1462474456) ^ 0x3BC39918);
					continue;
				case 3u:
					Form4.smethod_3(e, bool_0: true);
					num = (int)(num2 * 1774849078) ^ -355118377;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (Form4.smethod_2(e) == ' ')
					{
						num3 = -1003221309;
						num4 = -1003221309;
					}
					else
					{
						num3 = -145516916;
						num4 = -145516916;
					}
					num = num3 ^ (int)(num2 * 1531452270);
					continue;
				}
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
	}

	protected override void Dispose(bool disposing)
	{
		while (true)
		{
			int num = -1880380146;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xA3C3128Cu) % 8u)
				{
				case 5u:
					num = ((int)num2 * -2112111324) ^ 0x14A93BBC;
					continue;
				case 4u:
					num = ((int)num2 * -1308637904) ^ -803610513;
					continue;
				case 3u:
					((Form)this).Dispose(disposing);
					num = -758259805;
					continue;
				case 2u:
					if (disposing)
					{
						num = ((int)num2 * -707483096) ^ 0x1E9C5B4D;
						continue;
					}
					goto IL_0053;
				case 1u:
					if (components != null)
					{
						num = -724887828;
						num3 = -724887828;
						continue;
					}
					goto IL_0053;
				case 0u:
					Form4.smethod_5((IDisposable)components);
					num = ((int)num2 * -1609595000) ^ 0x40B4F189;
					continue;
				default:
					return;
				case 6u:
					break;
				case 7u:
					return;
					IL_0053:
					num = -910439249;
					num3 = -910439249;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected O, but got Unknown
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected O, but got Unknown
		while (true)
		{
			int num = 1914564625;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x43E583E5u) % 66u)
				{
				case 65u:
					num = ((int)num2 * -430109782) ^ 0x49723664;
					continue;
				case 64u:
					num = (int)((num2 * 1562439776) ^ 0x29935F85);
					continue;
				case 63u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 292619247) ^ -844020915;
					continue;
				case 62u:
					num = (int)(num2 * 758353969) ^ -1138634273;
					continue;
				case 61u:
					textBox2 = Form4.smethod_7();
					num = (int)(num2 * 264831720) ^ -1177074364;
					continue;
				case 60u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					Form4.smethod_31((Control)(object)this, "Form4");
					num = (int)(num2 * 314240217) ^ -454230605;
					continue;
				case 59u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 1242699040) ^ -1595293532;
					continue;
				case 58u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = (int)((num2 * 1560709694) ^ 0x29683450);
					continue;
				case 57u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -99474133) ^ -405807373;
					continue;
				case 56u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -484248633) ^ -498564356;
					continue;
				case 55u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = ((int)num2 * -1488305275) ^ 0x5F71A712;
					continue;
				case 54u:
					num = (int)((num2 * 162199052) ^ 0x2D665D66);
					continue;
				case 53u:
					num = (int)((num2 * 1874999575) ^ 0x1A759954);
					continue;
				case 52u:
					num = (int)(num2 * 1813595504) ^ -1356575757;
					continue;
				case 51u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = (int)((num2 * 959625071) ^ 0x319C05D7);
					continue;
				case 50u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -240554804) ^ 0x68F808F7;
					continue;
				case 49u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -877064213) ^ -1720994247;
					continue;
				case 48u:
					num = (int)((num2 * 1917310465) ^ 0x793C8164);
					continue;
				case 47u:
					button1 = Form4.smethod_8();
					num = ((int)num2 * -827773509) ^ 0x52CFEBBD;
					continue;
				case 45u:
					num = ((int)num2 * -788976365) ^ -369528386;
					continue;
				case 44u:
					num = ((int)num2 * -2002894695) ^ -764969167;
					continue;
				case 43u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = ((int)num2 * -1536380074) ^ -1613515775;
					continue;
				case 42u:
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)(num2 * 1244681472) ^ -1966681080;
					continue;
				case 41u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = (int)((num2 * 1782379123) ^ 0x435D9AC8);
					continue;
				case 40u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = (int)(num2 * 2070755047) ^ -1153525987;
					continue;
				case 39u:
					num = ((int)num2 * -694017154) ^ -1044929573;
					continue;
				case 38u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = (int)(num2 * 1541205844) ^ -1238772350;
					continue;
				case 37u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1116645025) ^ -1984096878;
					continue;
				case 36u:
					num = ((int)num2 * -676135398) ^ 0xDC3935A;
					continue;
				case 35u:
					Form4.smethod_18(textBox2, bool_0: true);
					num = (int)(num2 * 985356829) ^ -1537029927;
					continue;
				case 33u:
					num = (int)((num2 * 292348933) ^ 0x527A232E);
					continue;
				case 32u:
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1147177071) ^ 0x20B69291;
					continue;
				case 31u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = (int)((num2 * 1108758773) ^ 0x1E07BC01);
					continue;
				case 30u:
					num = (int)((num2 * 705374426) ^ 0x5A7FD583);
					continue;
				case 29u:
					errorProvider1 = Form4.smethod_9(components);
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					Form4.smethod_11((Control)(object)this);
					num = (int)((num2 * 75233036) ^ 0x47859CE);
					continue;
				case 28u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 1348886782) ^ 0x9D1841B);
					continue;
				case 27u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1394005369) ^ 0x59E2E2CC);
					continue;
				case 26u:
					num = ((int)num2 * -1483682022) ^ 0x510FF96E;
					continue;
				case 25u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = ((int)num2 * -1102534492) ^ -1495059911;
					continue;
				case 24u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = (int)(num2 * 755037420) ^ -244936581;
					continue;
				case 23u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = ((int)num2 * -1229009857) ^ 0x6A0208AD;
					continue;
				case 22u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = (int)((num2 * 2032558431) ^ 0x7C1575AA);
					continue;
				case 21u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = (int)(num2 * 832084497) ^ -223190898;
					continue;
				case 20u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -1197633256) ^ -949451706;
					continue;
				case 19u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = (int)(num2 * 473034256) ^ -577609035;
					continue;
				case 18u:
					num = ((int)num2 * -2050848579) ^ -835286603;
					continue;
				case 17u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = (int)((num2 * 1385864158) ^ 0x58ACB2D9);
					continue;
				case 16u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = ((int)num2 * -905898128) ^ -331686205;
					continue;
				case 15u:
					textBox3 = Form4.smethod_7();
					num = (int)((num2 * 1074669450) ^ 0x7B19193E);
					continue;
				case 14u:
					num = ((int)num2 * -544049481) ^ -180197980;
					continue;
				case 13u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = (int)((num2 * 306457668) ^ 0x84ED41);
					continue;
				case 12u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1199035063) ^ 0x6D2F888D;
					continue;
				case 11u:
					num = ((int)num2 * -308416540) ^ 0x65DA18C;
					continue;
				case 10u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = (int)(num2 * 1928239910) ^ -280604;
					continue;
				case 9u:
					Form4.smethod_18(textBox3, bool_0: true);
					num = (int)((num2 * 1396499895) ^ 0x370941A7);
					continue;
				case 8u:
					components = Form4.smethod_6();
					textBox1 = Form4.smethod_7();
					num = (int)(num2 * 1354881820) ^ -1441366592;
					continue;
				case 7u:
					num = (int)(num2 * 2026680577) ^ -2047438437;
					continue;
				case 6u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1616284730) ^ 0x48389DA4;
					continue;
				case 5u:
					num = ((int)num2 * -1667289449) ^ 0x1C00D8CB;
					continue;
				case 4u:
					Form4.smethod_37((Control)(object)this);
					num = (int)((num2 * 1324284420) ^ 0x37A5369);
					continue;
				case 3u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = ((int)num2 * -1486154586) ^ -1398531860;
					continue;
				case 2u:
					num = (int)((num2 * 1138124213) ^ 0x42E26C2B);
					continue;
				case 1u:
					num = (int)((num2 * 1429999203) ^ 0x7F55098E);
					continue;
				case 0u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = (int)((num2 * 1888099315) ^ 0x76EE6932);
					continue;
				default:
					return;
				case 46u:
					break;
				case 34u:
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
