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
		while (true)
		{
			int num = 49034024;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3AAECDF0u) % 5u)
				{
				case 2u:
					num = (int)((num2 * 898259309) ^ 0x56838A9);
					continue;
				case 1u:
					InitializeComponent();
					num = (int)(num2 * 1505861246) ^ -402573492;
					continue;
				case 0u:
					num = ((int)num2 * -454456701) ^ -227993006;
					continue;
				default:
					return;
				case 3u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void Form4_FormClosing(object sender, FormClosingEventArgs e)
	{
		Form4.smethod_1((Control)(object)Form4.smethod_0((Form)(object)this), bool_0: true);
	}

	private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		while (true)
		{
			int num = -1067525960;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB448ACF6u) % 4u)
				{
				case 2u:
				{
					int num3;
					int num4;
					if (Form4.smethod_2(e) == ' ')
					{
						num3 = -1917512605;
						num4 = -1917512605;
					}
					else
					{
						num3 = -890459662;
						num4 = -890459662;
					}
					num = num3 ^ (int)(num2 * 536889704);
					continue;
				}
				case 1u:
					Form4.smethod_3(e, bool_0: true);
					num = ((int)num2 * -742914) ^ 0x6360D3F4;
					continue;
				default:
					return;
				case 3u:
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
		if (disposing)
		{
			goto IL_0023;
		}
		int num = 0;
		goto IL_009f;
		IL_009f:
		bool flag = (byte)num != 0;
		int num2 = 1917526429;
		goto IL_0069;
		IL_0023:
		num2 = 2107276257;
		goto IL_0069;
		IL_0069:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x211C7A21u) % 7u)
			{
			case 6u:
				Form4.smethod_5((IDisposable)components);
				num2 = (int)(num3 * 2006192161) ^ -2097333242;
				continue;
			case 5u:
				break;
			case 4u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = -1723833428;
					num5 = -1723833428;
				}
				else
				{
					num4 = -740126053;
					num5 = -740126053;
				}
				num2 = num4 ^ ((int)num3 * -266336282);
				continue;
			}
			case 2u:
				num2 = ((int)num3 * -1705386674) ^ 0x74B6C162;
				continue;
			case 0u:
				((Form)this).Dispose(disposing);
				num2 = 930411386;
				continue;
			default:
				return;
			case 3u:
				goto IL_0096;
			case 1u:
				return;
			}
			break;
		}
		goto IL_0023;
		IL_0096:
		num = ((components != null) ? 1 : 0);
		goto IL_009f;
	}

	private void InitializeComponent()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected O, but got Unknown
		while (true)
		{
			int num = -995070060;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xECF62C94u) % 65u)
				{
				case 64u:
					num = (int)((num2 * 1876379815) ^ 0x787BFABE);
					continue;
				case 63u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -233798470) ^ -1984316475;
					continue;
				case 62u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)((num2 * 1592522203) ^ 0x2590D13B);
					continue;
				case 61u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = ((int)num2 * -406928973) ^ -381371297;
					continue;
				case 60u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = ((int)num2 * -970174136) ^ -779590939;
					continue;
				case 59u:
					Form4.smethod_11((Control)(object)this);
					num = ((int)num2 * -462785568) ^ 0x248639F3;
					continue;
				case 58u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = ((int)num2 * -1999664416) ^ -1347691708;
					continue;
				case 57u:
					num = (int)((num2 * 151163292) ^ 0xA2CE2EB);
					continue;
				case 55u:
					button1 = Form4.smethod_8();
					errorProvider1 = Form4.smethod_9(components);
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -69417327) ^ -1098003572;
					continue;
				case 54u:
					Form4.smethod_29((Form)(object)this, bool_0: false);
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1261885657) ^ 0x6C0F90C5;
					continue;
				case 53u:
					num = (int)(num2 * 1445869335) ^ -1177906070;
					continue;
				case 52u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 2040777203) ^ -1481877116;
					continue;
				case 51u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					Form4.smethod_13((Control)(object)button1, "button1");
					num = ((int)num2 * -836398604) ^ 0x4A7C5C60;
					continue;
				case 50u:
					num = ((int)num2 * -2151069) ^ -204925880;
					continue;
				case 49u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = (int)((num2 * 435094911) ^ 0x428C4C12);
					continue;
				case 48u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = (int)(num2 * 196223854) ^ -2042176177;
					continue;
				case 47u:
					components = Form4.smethod_6();
					num = (int)(num2 * 1831425715) ^ -280517925;
					continue;
				case 46u:
					num = ((int)num2 * -780199293) ^ -1126185246;
					continue;
				case 45u:
					Form4.smethod_31((Control)(object)this, "Form4");
					num = (int)(num2 * 1828387695) ^ -678636820;
					continue;
				case 44u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -1961409484) ^ -957251261;
					continue;
				case 43u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = ((int)num2 * -488205455) ^ 0x681FDAD4;
					continue;
				case 42u:
					textBox2 = Form4.smethod_7();
					textBox3 = Form4.smethod_7();
					num = ((int)num2 * -925765811) ^ 0x4DBD4221;
					continue;
				case 41u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1177561653) ^ 0x1C7CFDDB;
					continue;
				case 40u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -322072029) ^ 0x5DE6BB02;
					continue;
				case 39u:
					num = ((int)num2 * -831292434) ^ -1505816829;
					continue;
				case 38u:
					num = (int)((num2 * 1589662464) ^ 0x544C2304);
					continue;
				case 37u:
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 940624093) ^ -201144568;
					continue;
				case 36u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -1469581070) ^ 0x51777EFA;
					continue;
				case 35u:
					num = (int)(num2 * 1286686001) ^ -2101737572;
					continue;
				case 34u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = (int)((num2 * 1021841080) ^ 0x3C1784BE);
					continue;
				case 33u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = (int)((num2 * 26202193) ^ 0x52B03D3B);
					continue;
				case 32u:
					num = (int)((num2 * 1731235984) ^ 0x279E9374);
					continue;
				case 31u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = (int)((num2 * 619363603) ^ 0x28131E51);
					continue;
				case 30u:
					textBox1 = Form4.smethod_7();
					num = ((int)num2 * -1852218930) ^ 0x2977177D;
					continue;
				case 29u:
					num = ((int)num2 * -2107270515) ^ 0x4146160C;
					continue;
				case 28u:
					num = (int)((num2 * 1416877389) ^ 0x3FC7DD0B);
					continue;
				case 27u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1788393866) ^ 0x692180D9;
					continue;
				case 26u:
					Form4.smethod_18(textBox2, bool_0: true);
					num = (int)(num2 * 2018402472) ^ -1915669815;
					continue;
				case 25u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = (int)(num2 * 816251123) ^ -2141295450;
					continue;
				case 24u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = (int)(num2 * 1557974007) ^ -519542300;
					continue;
				case 23u:
					num = (int)(num2 * 1198537651) ^ -1257239595;
					continue;
				case 22u:
					num = ((int)num2 * -1726070235) ^ -96071278;
					continue;
				case 21u:
					num = (int)((num2 * 1038648067) ^ 0x420C6E99);
					continue;
				case 20u:
					num = ((int)num2 * -1789759689) ^ 0x6D1E4958;
					continue;
				case 19u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = (int)((num2 * 852540210) ^ 0x468C1D99);
					continue;
				case 18u:
					Form4.smethod_37((Control)(object)this);
					num = ((int)num2 * -764844869) ^ -1912063883;
					continue;
				case 17u:
					num = ((int)num2 * -1180077287) ^ 0x26B7FB46;
					continue;
				case 16u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					num = (int)(num2 * 260277570) ^ -1772617972;
					continue;
				case 15u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = (int)(num2 * 1866469353) ^ -1090012709;
					continue;
				case 14u:
					num = (int)((num2 * 1852524113) ^ 0x4D04CF7D);
					continue;
				case 13u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 285234002) ^ 0x125069F);
					continue;
				case 12u:
					num = ((int)num2 * -1588275577) ^ -1917155358;
					continue;
				case 11u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = (int)((num2 * 1994020122) ^ 0x5E9B36C8);
					continue;
				case 10u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = (int)(num2 * 1755968873) ^ -834351939;
					continue;
				case 9u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = ((int)num2 * -777746008) ^ 0x2591137B;
					continue;
				case 8u:
					num = ((int)num2 * -1733444225) ^ 0x6E749C17;
					continue;
				case 7u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 817380427) ^ 0x74186D6B);
					continue;
				case 6u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -1664651243) ^ -1033516904;
					continue;
				case 5u:
					Form4.smethod_18(textBox3, bool_0: true);
					num = ((int)num2 * -502539474) ^ -742089485;
					continue;
				case 4u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = ((int)num2 * -1971619443) ^ -1539813536;
					continue;
				case 3u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = (int)((num2 * 64536009) ^ 0x4A8FE616);
					continue;
				case 2u:
					num = ((int)num2 * -1619268595) ^ 0x7A276462;
					continue;
				case 0u:
					num = (int)((num2 * 371103419) ^ 0x79D989D0);
					continue;
				default:
					return;
				case 56u:
					break;
				case 1u:
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
