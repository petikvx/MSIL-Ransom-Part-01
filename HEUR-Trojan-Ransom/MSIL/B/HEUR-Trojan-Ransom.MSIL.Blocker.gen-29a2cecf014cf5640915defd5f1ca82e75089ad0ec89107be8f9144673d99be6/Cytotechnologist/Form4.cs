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
			int num = 289656502;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x34EF4D6Fu) % 3u)
				{
				case 2u:
					goto IL_000e;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_000e:
				num = ((int)num2 * -458608703) ^ -2002770203;
			}
		}
	}

	private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -25815010;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA78C6EA5u) % 6u)
				{
				case 5u:
					flag = Form4.smethod_2(e) == ' ';
					num = (int)(num2 * 326374212) ^ -637914566;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 941269348;
						num4 = 941269348;
					}
					else
					{
						num3 = 1860082962;
						num4 = 1860082962;
					}
					num = num3 ^ (int)(num2 * 409828199);
					continue;
				}
				case 2u:
					Form4.smethod_3(e, bool_0: true);
					num = (int)((num2 * 1183473341) ^ 0x5C85B9B8);
					continue;
				case 1u:
					num = ((int)num2 * -263860122) ^ 0x2038FCC1;
					continue;
				default:
					return;
				case 0u:
					break;
				case 4u:
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
			int num = -1131376735;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF4EFFF26u) % 3u)
				{
				case 2u:
					goto IL_000d;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_000d:
				num = (int)((num2 * 1426303922) ^ 0x6B90C0F9);
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_0023;
		}
		int num = 0;
		goto IL_00a0;
		IL_0097:
		num = ((components != null) ? 1 : 0);
		goto IL_00a0;
		IL_0023:
		int num2 = 1903280934;
		goto IL_006a;
		IL_006a:
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x4E1B2B42u) % 7u)
			{
			case 5u:
				Form4.smethod_5((IDisposable)components);
				num2 = (int)(num3 * 522824100) ^ -1257415386;
				continue;
			case 4u:
				break;
			case 3u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = -2013457464;
					num5 = -2013457464;
				}
				else
				{
					num4 = -278322609;
					num5 = -278322609;
				}
				num2 = num4 ^ (int)(num3 * 281644478);
				continue;
			}
			case 2u:
				num2 = (int)((num3 * 2094002930) ^ 0x600E47AF);
				continue;
			case 0u:
				num2 = (int)((num3 * 409959938) ^ 0x4568C451);
				continue;
			case 1u:
				goto IL_0097;
			default:
				((Form)this).Dispose(disposing);
				return;
			}
			break;
		}
		goto IL_0023;
		IL_00a0:
		flag = (byte)num != 0;
		num2 = 513100132;
		goto IL_006a;
	}

	private void InitializeComponent()
	{
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected O, but got Unknown
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected O, but got Unknown
		//IL_0688: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Expected O, but got Unknown
		components = Form4.smethod_6();
		while (true)
		{
			int num = -808653681;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xABD6F76Eu) % 69u)
				{
				case 68u:
					num = (int)(num2 * 1082294442) ^ -484252412;
					continue;
				case 67u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = (int)(num2 * 1738737438) ^ -1908614266;
					continue;
				case 66u:
					textBox1 = Form4.smethod_7();
					num = (int)((num2 * 325125038) ^ 0x61062F01);
					continue;
				case 64u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 1290760148) ^ 0x5ACA8A1E);
					continue;
				case 63u:
					num = (int)((num2 * 527108692) ^ 0x512D9DB4);
					continue;
				case 62u:
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1209457811) ^ 0x63979529);
					continue;
				case 61u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -900572997) ^ -614090989;
					continue;
				case 60u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = ((int)num2 * -720289148) ^ 0x19EDE4E3;
					continue;
				case 59u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					num = (int)((num2 * 267129683) ^ 0xD68EE56);
					continue;
				case 58u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1753445825) ^ 0x69564A65;
					continue;
				case 57u:
					num = (int)((num2 * 1109651995) ^ 0x6DE4068F);
					continue;
				case 55u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = (int)((num2 * 1646730637) ^ 0x2833EB76);
					continue;
				case 54u:
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -646573926) ^ -126592516;
					continue;
				case 53u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -1326901136) ^ -207528944;
					continue;
				case 52u:
					num = ((int)num2 * -266033599) ^ -92047372;
					continue;
				case 51u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = ((int)num2 * -1807563736) ^ 0x3E90B716;
					continue;
				case 50u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = ((int)num2 * -806649988) ^ 0x2A7CF383;
					continue;
				case 49u:
					num = (int)(num2 * 1455634242) ^ -973180996;
					continue;
				case 48u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 1857329346) ^ -198033831;
					continue;
				case 47u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = (int)(num2 * 690695667) ^ -938924002;
					continue;
				case 46u:
					textBox2 = Form4.smethod_7();
					num = (int)((num2 * 398931472) ^ 0x1B0AC779);
					continue;
				case 45u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -540029505) ^ 0x49EFB21A;
					continue;
				case 44u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -821872387) ^ 0x312A15E1;
					continue;
				case 43u:
					Form4.smethod_18(textBox3, bool_0: true);
					num = ((int)num2 * -1980902240) ^ -909877576;
					continue;
				case 42u:
					Form4.smethod_31((Control)(object)this, "Form4");
					num = (int)(num2 * 1579107465) ^ -956823385;
					continue;
				case 41u:
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1602400284) ^ -60726755;
					continue;
				case 40u:
					num = (int)((num2 * 1091527397) ^ 0x584EBD59);
					continue;
				case 39u:
					num = (int)((num2 * 1114200272) ^ 0x6C4E2976);
					continue;
				case 38u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = (int)(num2 * 1252166796) ^ -230392004;
					continue;
				case 37u:
					num = ((int)num2 * -1921352419) ^ 0x65E5F7B9;
					continue;
				case 36u:
					num = (int)(num2 * 1024702439) ^ -1907067559;
					continue;
				case 35u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = (int)((num2 * 753083119) ^ 0x9D6F040);
					continue;
				case 34u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = (int)((num2 * 888479680) ^ 0x52D2A3F5);
					continue;
				case 33u:
					Form4.smethod_18(textBox2, bool_0: true);
					num = ((int)num2 * -274426820) ^ -1361792396;
					continue;
				case 32u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -1580662259) ^ 0x6E82E4C0;
					continue;
				case 31u:
					num = ((int)num2 * -1051920896) ^ -1789492277;
					continue;
				case 30u:
					Form4.smethod_11((Control)(object)this);
					num = (int)(num2 * 1676565879) ^ -892019333;
					continue;
				case 29u:
					num = (int)((num2 * 802956171) ^ 0x14E66601);
					continue;
				case 28u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -1307811103) ^ 0x4A425E99;
					continue;
				case 27u:
					num = (int)((num2 * 437349437) ^ 0x1E3BEDDC);
					continue;
				case 26u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = ((int)num2 * -1856311166) ^ -1500179133;
					continue;
				case 25u:
					Form4.smethod_37((Control)(object)this);
					num = ((int)num2 * -639197931) ^ 0x6509676;
					continue;
				case 24u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = ((int)num2 * -1938620419) ^ -1588384717;
					continue;
				case 23u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = (int)(num2 * 2064897405) ^ -1728463716;
					continue;
				case 22u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1814259714) ^ 0x47B47A3F;
					continue;
				case 21u:
					num = ((int)num2 * -967948675) ^ 0x4E500C67;
					continue;
				case 20u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					Form4.smethod_15((Control)(object)button1, 0);
					num = ((int)num2 * -90810061) ^ 0x504F5986;
					continue;
				case 19u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1243616459) ^ 0xCB36534;
					continue;
				case 18u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = (int)((num2 * 778115032) ^ 0x38BF340);
					continue;
				case 17u:
					num = (int)((num2 * 262584072) ^ 0x4044B879);
					continue;
				case 16u:
					textBox3 = Form4.smethod_7();
					button1 = Form4.smethod_8();
					errorProvider1 = Form4.smethod_9(components);
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 787126318) ^ -1202025692;
					continue;
				case 15u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = ((int)num2 * -401385932) ^ 0x7DCD7319;
					continue;
				case 14u:
					num = ((int)num2 * -1172427954) ^ 0x689A7718;
					continue;
				case 13u:
					num = (int)(num2 * 95022085) ^ -1510076685;
					continue;
				case 12u:
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)((num2 * 496351417) ^ 0x4DC7DAE1);
					continue;
				case 11u:
					num = ((int)num2 * -1763954902) ^ 0x2F21110D;
					continue;
				case 10u:
					num = (int)((num2 * 1490323479) ^ 0x752FD931);
					continue;
				case 9u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = ((int)num2 * -1714044157) ^ 0x531E7661;
					continue;
				case 8u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = (int)(num2 * 1954495771) ^ -1801942787;
					continue;
				case 7u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = (int)((num2 * 214952046) ^ 0x3DE19895);
					continue;
				case 6u:
					num = (int)(num2 * 1822880207) ^ -1385677376;
					continue;
				case 5u:
					num = (int)((num2 * 1227241931) ^ 0xB1DB911);
					continue;
				case 4u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = ((int)num2 * -1212369145) ^ -2112571440;
					continue;
				case 3u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = (int)((num2 * 1543018734) ^ 0x51D0D7CA);
					continue;
				case 2u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1326543050) ^ 0x46D3135C;
					continue;
				case 1u:
					num = (int)(num2 * 520556106) ^ -340045012;
					continue;
				case 0u:
					num = (int)((num2 * 1304540776) ^ 0x270F8A18);
					continue;
				default:
					return;
				case 65u:
					break;
				case 56u:
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
