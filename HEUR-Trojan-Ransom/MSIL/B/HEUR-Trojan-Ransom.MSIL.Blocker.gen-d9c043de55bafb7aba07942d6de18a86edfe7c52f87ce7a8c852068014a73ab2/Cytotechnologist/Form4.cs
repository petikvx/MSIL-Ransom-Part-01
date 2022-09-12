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
	}

	private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = Form4.smethod_2(e) == ' ';
		while (true)
		{
			int num = 68831938;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1A75B248u) % 5u)
				{
				case 4u:
					Form4.smethod_3(e, bool_0: true);
					num = (int)((num2 * 1462315717) ^ 0x3F1486A7);
					continue;
				case 3u:
					num = (int)(num2 * 1283913512) ^ -1116453081;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 773284731;
						num4 = 773284731;
					}
					else
					{
						num3 = 1749050393;
						num4 = 1749050393;
					}
					num = num3 ^ (int)(num2 * 1332176795);
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 1u:
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
		bool flag = default(bool);
		while (true)
		{
			int num = -1842702510;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xC0978D80u) % 10u)
				{
				case 9u:
					((Form)this).Dispose(disposing);
					num = -388772497;
					continue;
				case 8u:
					Form4.smethod_5((IDisposable)components);
					num = ((int)num2 * -175161285) ^ -176762394;
					continue;
				case 7u:
					num = ((int)num2 * -831810727) ^ -1871187520;
					continue;
				case 6u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_0049;
				case 5u:
					num = ((int)num2 * -404218033) ^ -506038425;
					continue;
				case 4u:
					num = ((int)num2 * -330121400) ^ 0x690BB3CB;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1391462207;
						num5 = -1391462207;
					}
					else
					{
						num4 = -675627789;
						num5 = -675627789;
					}
					num = num4 ^ (int)(num2 * 79380240);
					continue;
				}
				case 2u:
					if (disposing)
					{
						num = (int)(num2 * 1092647137) ^ -1363397972;
						continue;
					}
					num3 = 0;
					goto IL_0049;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
					IL_0049:
					flag = (byte)num3 != 0;
					num = -753916301;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected O, but got Unknown
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected O, but got Unknown
		components = Form4.smethod_6();
		while (true)
		{
			int num = -1237994080;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBE0A2FBEu) % 68u)
				{
				case 67u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -540387323) ^ 0x499E787D;
					continue;
				case 66u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1471953063) ^ -990665200;
					continue;
				case 65u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = ((int)num2 * -1251085915) ^ -867795812;
					continue;
				case 64u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = ((int)num2 * -1045747030) ^ 0x4393414E;
					continue;
				case 63u:
					button1 = Form4.smethod_8();
					num = ((int)num2 * -1748465848) ^ 0x106491DD;
					continue;
				case 62u:
					num = ((int)num2 * -165940339) ^ 0x3C5D2E9D;
					continue;
				case 60u:
					num = ((int)num2 * -851148582) ^ 0x7CA6E56E;
					continue;
				case 59u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = ((int)num2 * -2139809500) ^ 0x33073A55;
					continue;
				case 58u:
					Form4.smethod_37((Control)(object)this);
					num = (int)(num2 * 859715725) ^ -1485380283;
					continue;
				case 57u:
					num = ((int)num2 * -25388748) ^ 0x514B2C54;
					continue;
				case 56u:
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -1631803517) ^ -1078032008;
					continue;
				case 55u:
					Form4.smethod_31((Control)(object)this, "Form4");
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = ((int)num2 * -93762015) ^ 0x5172D5A7;
					continue;
				case 54u:
					num = (int)(num2 * 1942380872) ^ -923723040;
					continue;
				case 53u:
					num = ((int)num2 * -2138087856) ^ -1759869855;
					continue;
				case 52u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -242401129) ^ -2124304307;
					continue;
				case 51u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 76027716) ^ -1091077680;
					continue;
				case 50u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = (int)(num2 * 1198825826) ^ -1316042633;
					continue;
				case 49u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1267920846) ^ -423675780;
					continue;
				case 47u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 468152356) ^ -1812440824;
					continue;
				case 46u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = (int)((num2 * 415029532) ^ 0x22660212);
					continue;
				case 45u:
					num = ((int)num2 * -1884522528) ^ 0x82792DB;
					continue;
				case 44u:
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = ((int)num2 * -233483561) ^ 0x6BF0B40F;
					continue;
				case 43u:
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = ((int)num2 * -1621134613) ^ -1517423501;
					continue;
				case 42u:
					num = (int)(num2 * 1960048710) ^ -1031270939;
					continue;
				case 41u:
					num = ((int)num2 * -1468455322) ^ -1389858615;
					continue;
				case 40u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = ((int)num2 * -1215689827) ^ 0xA9C0405;
					continue;
				case 39u:
					errorProvider1 = Form4.smethod_9(components);
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -340210060) ^ 0x676086B4;
					continue;
				case 38u:
					num = (int)((num2 * 1174800542) ^ 0x2C6A985);
					continue;
				case 37u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -846061113) ^ -295346368;
					continue;
				case 36u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = (int)(num2 * 74620457) ^ -1721621125;
					continue;
				case 35u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = ((int)num2 * -1933279620) ^ 0x12603374;
					continue;
				case 34u:
					textBox1 = Form4.smethod_7();
					num = ((int)num2 * -564411809) ^ -1130722525;
					continue;
				case 33u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1212439189) ^ -1603443107;
					continue;
				case 32u:
					num = (int)(num2 * 616734260) ^ -1107419030;
					continue;
				case 31u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = (int)((num2 * 171195050) ^ 0x6A2C8AA5);
					continue;
				case 30u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = (int)((num2 * 1162745278) ^ 0x69D0A4E2);
					continue;
				case 29u:
					num = ((int)num2 * -1896793523) ^ -16030130;
					continue;
				case 28u:
					num = (int)(num2 * 1109942513) ^ -1288534065;
					continue;
				case 27u:
					textBox2 = Form4.smethod_7();
					num = (int)((num2 * 2072058810) ^ 0x669AEBF7);
					continue;
				case 26u:
					Form4.smethod_11((Control)(object)this);
					num = (int)(num2 * 1084908780) ^ -401751983;
					continue;
				case 25u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)(num2 * 1756439557) ^ -701310011;
					continue;
				case 24u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = (int)((num2 * 2037847401) ^ 0x1B8A930C);
					continue;
				case 23u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = (int)(num2 * 632824576) ^ -1008560612;
					continue;
				case 22u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = (int)((num2 * 1596114276) ^ 0x18E85C4F);
					continue;
				case 21u:
					Form4.smethod_18(textBox3, bool_0: true);
					num = ((int)num2 * -1647116240) ^ 0x30DEAE8F;
					continue;
				case 20u:
					num = (int)((num2 * 189029834) ^ 0x7E1D581B);
					continue;
				case 19u:
					textBox3 = Form4.smethod_7();
					num = ((int)num2 * -259843210) ^ -1993428357;
					continue;
				case 18u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = (int)(num2 * 1745816780) ^ -1819988977;
					continue;
				case 17u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -1530512068) ^ 0x7156B187;
					continue;
				case 16u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					num = ((int)num2 * -425234209) ^ 0x238FF866;
					continue;
				case 15u:
					num = (int)(num2 * 134767725) ^ -1126046610;
					continue;
				case 14u:
					num = (int)((num2 * 1052051286) ^ 0x38EEB89E);
					continue;
				case 13u:
					num = ((int)num2 * -389908761) ^ 0x7D52B2CF;
					continue;
				case 12u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					Form4.smethod_18(textBox2, bool_0: true);
					num = (int)(num2 * 333917983) ^ -633141011;
					continue;
				case 11u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = ((int)num2 * -36469086) ^ 0x655BA14A;
					continue;
				case 10u:
					num = (int)(num2 * 1021117235) ^ -480639922;
					continue;
				case 9u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = ((int)num2 * -1757670837) ^ 0xE78DE37;
					continue;
				case 8u:
					num = (int)((num2 * 469844335) ^ 0x645B9711);
					continue;
				case 7u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = ((int)num2 * -2025120664) ^ -526891994;
					continue;
				case 6u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1418373486) ^ -294295899;
					continue;
				case 5u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = (int)((num2 * 1733192753) ^ 0x50A94EE8);
					continue;
				case 4u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = ((int)num2 * -588252847) ^ -1723100802;
					continue;
				case 3u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1233594563) ^ -1698719583;
					continue;
				case 2u:
					num = ((int)num2 * -1484064536) ^ -40108530;
					continue;
				case 1u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = ((int)num2 * -1691841191) ^ -402731105;
					continue;
				case 0u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1941881121) ^ 0x5AC39C23;
					continue;
				default:
					return;
				case 48u:
					break;
				case 61u:
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
