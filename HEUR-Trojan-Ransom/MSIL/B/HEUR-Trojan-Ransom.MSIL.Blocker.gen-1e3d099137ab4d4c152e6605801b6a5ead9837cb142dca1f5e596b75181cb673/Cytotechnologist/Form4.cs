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
			int num = -1624146510;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC8996A00u) % 5u)
				{
				case 3u:
					InitializeComponent();
					num = ((int)num2 * -1003867133) ^ -116677431;
					continue;
				case 1u:
					num = ((int)num2 * -385718539) ^ -1994565972;
					continue;
				case 0u:
					num = ((int)num2 * -754394631) ^ -1539921207;
					continue;
				default:
					return;
				case 2u:
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
		bool flag = default(bool);
		while (true)
		{
			int num = 1902201630;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x33767513u) % 6u)
				{
				case 5u:
					flag = Form4.smethod_2(e) == ' ';
					num = ((int)num2 * -1849220388) ^ 0x41FF4643;
					continue;
				case 2u:
					num = (int)(num2 * 51753589) ^ -150682744;
					continue;
				case 1u:
					Form4.smethod_3(e, bool_0: true);
					num = (int)((num2 * 904753124) ^ 0x3A791891);
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 39732306;
						num4 = 39732306;
					}
					else
					{
						num3 = 1467512798;
						num4 = 1467512798;
					}
					num = num3 ^ ((int)num2 * -1662717945);
					continue;
				}
				default:
					return;
				case 4u:
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
		bool flag = default(bool);
		while (true)
		{
			int num = 493362277;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0xA0BE600u) % 9u)
				{
				case 8u:
					if (disposing)
					{
						num = ((int)num2 * -242077673) ^ -523716110;
						continue;
					}
					num5 = 0;
					goto IL_0019;
				case 6u:
					num5 = ((components != null) ? 1 : 0);
					goto IL_0019;
				case 4u:
					Form4.smethod_5((IDisposable)components);
					num = (int)(num2 * 407413867) ^ -459435746;
					continue;
				case 3u:
					num = ((int)num2 * -1430410299) ^ 0x21B21952;
					continue;
				case 2u:
					((Form)this).Dispose(disposing);
					num = 1838599558;
					continue;
				case 1u:
					num = ((int)num2 * -1440327663) ^ 0x53D045D9;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 276875863;
						num4 = 276875863;
					}
					else
					{
						num3 = 1419180036;
						num4 = 1419180036;
					}
					num = num3 ^ (int)(num2 * 1452521340);
					continue;
				}
				default:
					return;
				case 7u:
					break;
				case 5u:
					return;
					IL_0019:
					flag = (byte)num5 != 0;
					num = 66034003;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected O, but got Unknown
		while (true)
		{
			int num = -749765523;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB429F2D0u) % 68u)
				{
				case 67u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1984115938) ^ 0x7ABC9CFE;
					continue;
				case 66u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = (int)((num2 * 565582790) ^ 0x5230A9E2);
					continue;
				case 65u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = ((int)num2 * -893108427) ^ -207842304;
					continue;
				case 64u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = ((int)num2 * -2043126416) ^ 0x48A8B4BD;
					continue;
				case 63u:
					button1 = Form4.smethod_8();
					num = ((int)num2 * -965514767) ^ 0x75BAF8D8;
					continue;
				case 62u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = (int)((num2 * 661406904) ^ 0x743738C6);
					continue;
				case 61u:
					Form4.smethod_15((Control)(object)button1, 0);
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = ((int)num2 * -560208077) ^ 0x34A2201A;
					continue;
				case 60u:
					Form4.smethod_18(textBox3, bool_0: true);
					num = (int)(num2 * 556123757) ^ -47951121;
					continue;
				case 59u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)((num2 * 877542682) ^ 0x68A1516);
					continue;
				case 58u:
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = ((int)num2 * -102456127) ^ 0x40A9EE46;
					continue;
				case 57u:
					num = ((int)num2 * -401215049) ^ 0x73252EF4;
					continue;
				case 56u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					Form4.smethod_18(textBox2, bool_0: true);
					num = (int)((num2 * 808561306) ^ 0x3D286DC5);
					continue;
				case 55u:
					textBox1 = Form4.smethod_7();
					textBox2 = Form4.smethod_7();
					num = ((int)num2 * -1758462387) ^ -1147593320;
					continue;
				case 54u:
					num = (int)((num2 * 497185211) ^ 0x6F301C9);
					continue;
				case 53u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)(num2 * 406560075) ^ -2075765743;
					continue;
				case 52u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)((num2 * 1808549262) ^ 0x4A122E93);
					continue;
				case 51u:
					errorProvider1 = Form4.smethod_9(components);
					num = (int)((num2 * 1099158562) ^ 0x57F87D08);
					continue;
				case 50u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = (int)(num2 * 1299941085) ^ -1503085110;
					continue;
				case 49u:
					num = ((int)num2 * -397497827) ^ 0x67FD2C3D;
					continue;
				case 48u:
					num = ((int)num2 * -125260203) ^ -2090925856;
					continue;
				case 47u:
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = (int)(num2 * 1693813519) ^ -2029843139;
					continue;
				case 46u:
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = (int)((num2 * 133852742) ^ 0x6A434C78);
					continue;
				case 45u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = ((int)num2 * -666228545) ^ 0x5D7EC94;
					continue;
				case 44u:
					num = (int)(num2 * 1598327521) ^ -314827192;
					continue;
				case 43u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = ((int)num2 * -1126813634) ^ -1861019950;
					continue;
				case 42u:
					Form4.smethod_31((Control)(object)this, "Form4");
					num = (int)((num2 * 537701316) ^ 0x77A85B91);
					continue;
				case 40u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = (int)((num2 * 930680203) ^ 0x6440E20F);
					continue;
				case 39u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = (int)((num2 * 1894000343) ^ 0x630838BF);
					continue;
				case 38u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1407079295) ^ 0x4B24D6FC;
					continue;
				case 37u:
					num = (int)((num2 * 966297494) ^ 0xB0B0566);
					continue;
				case 36u:
					num = (int)((num2 * 1321520692) ^ 0x2B8F0311);
					continue;
				case 35u:
					textBox3 = Form4.smethod_7();
					num = ((int)num2 * -1678249384) ^ -714905869;
					continue;
				case 34u:
					num = ((int)num2 * -1549899585) ^ 0x50B4DD74;
					continue;
				case 33u:
					num = (int)(num2 * 406597654) ^ -1007006748;
					continue;
				case 31u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = (int)(num2 * 1449380115) ^ -852931419;
					continue;
				case 30u:
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = (int)(num2 * 789393339) ^ -417371104;
					continue;
				case 29u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -990776196) ^ 0x26EA3C43;
					continue;
				case 28u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = (int)((num2 * 1287384213) ^ 0x63D8EDD5);
					continue;
				case 27u:
					num = (int)((num2 * 211034166) ^ 0x3A0145B6);
					continue;
				case 26u:
					num = ((int)num2 * -1652390078) ^ -654877931;
					continue;
				case 25u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = ((int)num2 * -1995163014) ^ 0x33FBBF7A;
					continue;
				case 24u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1887121071) ^ -1944510457;
					continue;
				case 23u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = (int)(num2 * 1786079018) ^ -201646183;
					continue;
				case 22u:
					num = (int)((num2 * 1692530262) ^ 0x5ED8C301);
					continue;
				case 21u:
					num = (int)((num2 * 1935746056) ^ 0x6B8745B2);
					continue;
				case 20u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = (int)((num2 * 519198521) ^ 0x5B1A5554);
					continue;
				case 19u:
					num = ((int)num2 * -1004209332) ^ 0x45D7B16A;
					continue;
				case 18u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = ((int)num2 * -210815319) ^ 0x46857ADF;
					continue;
				case 17u:
					num = ((int)num2 * -1487319719) ^ -2034604006;
					continue;
				case 16u:
					Form4.smethod_11((Control)(object)this);
					num = ((int)num2 * -258551444) ^ -1100786974;
					continue;
				case 15u:
					num = ((int)num2 * -696406936) ^ -1903489097;
					continue;
				case 14u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = ((int)num2 * -796390462) ^ -829539520;
					continue;
				case 13u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -2119066577) ^ -1833193644;
					continue;
				case 12u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = (int)(num2 * 1054948236) ^ -2115230663;
					continue;
				case 11u:
					num = ((int)num2 * -233926038) ^ 0x5DC09A30;
					continue;
				case 10u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					num = (int)((num2 * 722640746) ^ 0x2047511);
					continue;
				case 9u:
					components = Form4.smethod_6();
					num = (int)((num2 * 356821923) ^ 0x7E396AA4);
					continue;
				case 8u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = ((int)num2 * -361050369) ^ -1686722542;
					continue;
				case 7u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = (int)((num2 * 85471837) ^ 0x1F55C846);
					continue;
				case 6u:
					num = ((int)num2 * -1261615140) ^ 0x4F18A8D2;
					continue;
				case 5u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 2089919346) ^ -1052349760;
					continue;
				case 4u:
					num = (int)(num2 * 568927456) ^ -1918138153;
					continue;
				case 3u:
					num = ((int)num2 * -1263303241) ^ 0x3D6C818;
					continue;
				case 2u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1250269557) ^ -64869953;
					continue;
				case 1u:
					num = (int)(num2 * 1142465568) ^ -1880286700;
					continue;
				case 0u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 1638057991) ^ -1228180786;
					continue;
				case 41u:
					break;
				default:
					Form4.smethod_37((Control)(object)this);
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
