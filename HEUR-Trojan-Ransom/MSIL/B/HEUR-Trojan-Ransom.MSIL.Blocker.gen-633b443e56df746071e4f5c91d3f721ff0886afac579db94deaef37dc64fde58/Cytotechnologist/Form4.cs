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
			int num = -523919222;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCD7324CDu) % 4u)
				{
				case 3u:
					num = (int)(num2 * 775216619) ^ -103010876;
					continue;
				case 0u:
					InitializeComponent();
					num = (int)((num2 * 946522222) ^ 0x6EBE714);
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
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
		bool flag = Form4.smethod_2(e) == ' ';
		while (true)
		{
			int num = -889655946;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE19186C9u) % 5u)
				{
				case 4u:
					Form4.smethod_3(e, bool_0: true);
					num = (int)((num2 * 1994529016) ^ 0x6B979870);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1158452018;
						num4 = -1158452018;
					}
					else
					{
						num3 = -256682193;
						num4 = -256682193;
					}
					num = num3 ^ ((int)num2 * -450314385);
					continue;
				}
				case 0u:
					num = ((int)num2 * -331831959) ^ -1110136209;
					continue;
				default:
					return;
				case 2u:
					break;
				case 3u:
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
		if (!disposing)
		{
			goto IL_0009;
		}
		goto IL_0025;
		IL_0025:
		int num = 409731421;
		goto IL_0070;
		IL_0070:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x7A96E8F4u) % 8u)
			{
			case 7u:
				num = (int)(num2 * 1823449721) ^ -143586369;
				continue;
			case 6u:
				break;
			case 5u:
				((Form)this).Dispose(disposing);
				num = 22539326;
				continue;
			case 4u:
				num = ((int)num2 * -1740344311) ^ 0x5BE00E35;
				continue;
			case 3u:
				Form4.smethod_5((IDisposable)components);
				num = ((int)num2 * -1279513195) ^ 0x61A28664;
				continue;
			case 2u:
				num = (int)(num2 * 2025210415) ^ -571274982;
				continue;
			default:
				return;
			case 1u:
				goto IL_00a1;
			case 0u:
				return;
			}
			break;
			IL_00a1:
			if (components != null)
			{
				num = 1929598991;
				num3 = 1929598991;
				continue;
			}
			goto IL_0009;
		}
		goto IL_0025;
		IL_0009:
		num = 675872145;
		num3 = 675872145;
		goto IL_0070;
	}

	private void InitializeComponent()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected O, but got Unknown
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected O, but got Unknown
		components = Form4.smethod_6();
		while (true)
		{
			int num = 637188954;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6FD855C9u) % 55u)
				{
				case 54u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -159993429) ^ 0x64CC5C4B;
					continue;
				case 53u:
					num = (int)((num2 * 806728784) ^ 0x2FD969C);
					continue;
				case 52u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 1469393246) ^ -941295910;
					continue;
				case 51u:
					Form4.smethod_18(textBox2, bool_0: true);
					num = (int)(num2 * 254055135) ^ -1958589764;
					continue;
				case 50u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = (int)((num2 * 1217693299) ^ 0x5CA9ACA8);
					continue;
				case 49u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = ((int)num2 * -71544466) ^ -745545275;
					continue;
				case 48u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = (int)(num2 * 495248813) ^ -997490169;
					continue;
				case 47u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1824982061) ^ 0x39124D6A;
					continue;
				case 46u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = (int)((num2 * 808135241) ^ 0x59DAD9B6);
					continue;
				case 45u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = (int)(num2 * 1581919099) ^ -1554552192;
					continue;
				case 44u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1970386788) ^ -853194160;
					continue;
				case 43u:
					Form4.smethod_18(textBox3, bool_0: true);
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -109862343) ^ 0x3051D74E;
					continue;
				case 42u:
					num = (int)((num2 * 248636846) ^ 0x7A3E488E);
					continue;
				case 41u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)(num2 * 1484734298) ^ -1584704449;
					continue;
				case 40u:
					errorProvider1 = Form4.smethod_9(components);
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					Form4.smethod_11((Control)(object)this);
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = (int)(num2 * 442621573) ^ -592082829;
					continue;
				case 39u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = ((int)num2 * -713802638) ^ 0x315390C;
					continue;
				case 38u:
					button1 = Form4.smethod_8();
					num = ((int)num2 * -2032973833) ^ -738513960;
					continue;
				case 37u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = (int)((num2 * 383303715) ^ 0x7C6A9B77);
					continue;
				case 36u:
					num = ((int)num2 * -12314874) ^ 0x8DCD621;
					continue;
				case 35u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = ((int)num2 * -829615799) ^ 0x52D361F1;
					continue;
				case 34u:
					num = (int)((num2 * 1336950897) ^ 0x627F2D5B);
					continue;
				case 33u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -1608130044) ^ -655049455;
					continue;
				case 32u:
					num = (int)(num2 * 153506444) ^ -2018577184;
					continue;
				case 31u:
					num = (int)(num2 * 627173917) ^ -92107040;
					continue;
				case 30u:
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = (int)((num2 * 644854679) ^ 0x148926D6);
					continue;
				case 29u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 1167017733) ^ -1752994718;
					continue;
				case 28u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = ((int)num2 * -1602097353) ^ -252059097;
					continue;
				case 27u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1823912266) ^ 0x36AD6F43);
					continue;
				case 26u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = (int)((num2 * 1789167229) ^ 0x4AF6553C);
					continue;
				case 25u:
					textBox3 = Form4.smethod_7();
					num = ((int)num2 * -1854826693) ^ 0x49B9EA52;
					continue;
				case 24u:
					num = (int)((num2 * 1433845930) ^ 0x46C4772C);
					continue;
				case 22u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = (int)(num2 * 302634840) ^ -1188230869;
					continue;
				case 21u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = ((int)num2 * -1585224850) ^ 0x6E90DDBB;
					continue;
				case 20u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -744221192) ^ 0x2C12C4C9;
					continue;
				case 19u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = (int)(num2 * 449665680) ^ -928387458;
					continue;
				case 18u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -53629406) ^ -1194902172;
					continue;
				case 17u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -799882586) ^ 0x566BE263;
					continue;
				case 16u:
					num = ((int)num2 * -1965375236) ^ -1303242997;
					continue;
				case 15u:
					Form4.smethod_31((Control)(object)this, "Form4");
					Form4.smethod_32((Form)(object)this, bool_0: false);
					Form4.smethod_33((Form)(object)this, bool_0: false);
					Form4.smethod_19((Control)(object)this, "Регистрация");
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = (int)(num2 * 453023675) ^ -543180827;
					continue;
				case 14u:
					num = ((int)num2 * -335515436) ^ 0x7020C7BB;
					continue;
				case 13u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1737491165) ^ -602225589;
					continue;
				case 12u:
					Form4.smethod_37((Control)(object)this);
					num = ((int)num2 * -60900833) ^ -643088165;
					continue;
				case 11u:
					num = ((int)num2 * -1342253244) ^ -59440493;
					continue;
				case 10u:
					num = ((int)num2 * -1068827409) ^ 0x72B34629;
					continue;
				case 9u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -849587607) ^ -1759746390;
					continue;
				case 8u:
					textBox1 = Form4.smethod_7();
					textBox2 = Form4.smethod_7();
					num = ((int)num2 * -71600059) ^ -795916124;
					continue;
				case 7u:
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1509407396) ^ -1953777612;
					continue;
				case 6u:
					num = ((int)num2 * -2026300582) ^ 0x344FFFDE;
					continue;
				case 5u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = (int)((num2 * 157062928) ^ 0x5AF82F83);
					continue;
				case 4u:
					num = ((int)num2 * -982246303) ^ -692084804;
					continue;
				case 2u:
					num = (int)(num2 * 958010195) ^ -1551368527;
					continue;
				case 1u:
					num = (int)((num2 * 1011786513) ^ 0xE2CE91D);
					continue;
				case 0u:
					num = ((int)num2 * -133709773) ^ -1054367965;
					continue;
				default:
					return;
				case 3u:
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
