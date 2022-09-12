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
			int num = 148840362;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x506628AAu) % 3u)
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
				num = ((int)num2 * -659107919) ^ 0x1255D3AC;
			}
		}
	}

	private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (Form4.smethod_2(e) != ' ')
		{
			return;
		}
		while (true)
		{
			int num = -1591019965;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC563E0CDu) % 4u)
				{
				case 2u:
					Form4.smethod_3(e, bool_0: true);
					num = ((int)num2 * -514704201) ^ 0xBF2F08A;
					continue;
				case 1u:
					num = ((int)num2 * -1959562004) ^ -963964107;
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
		bool flag = default(bool);
		while (true)
		{
			int num = -6569696;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xCD0A8488u) % 10u)
				{
				case 9u:
					num = (int)((num2 * 1054325443) ^ 0x49E21520);
					continue;
				case 8u:
					Form4.smethod_5((IDisposable)components);
					num = (int)((num2 * 1013582047) ^ 0x60F5FEF1);
					continue;
				case 7u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1823358174;
						num5 = -1823358174;
					}
					else
					{
						num4 = -1161935170;
						num5 = -1161935170;
					}
					num = num4 ^ ((int)num2 * -1422055296);
					continue;
				}
				case 6u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_005f;
				case 4u:
					((Form)this).Dispose(disposing);
					num = -1957842201;
					continue;
				case 3u:
					num = ((int)num2 * -1877216385) ^ -163522331;
					continue;
				case 2u:
					if (disposing)
					{
						num = ((int)num2 * -432534018) ^ 0x78147DEC;
						continue;
					}
					num3 = 0;
					goto IL_005f;
				case 1u:
					num = (int)(num2 * 1077383131) ^ -299433310;
					continue;
				default:
					return;
				case 0u:
					break;
				case 5u:
					return;
					IL_005f:
					flag = (byte)num3 != 0;
					num = -1830879977;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected O, but got Unknown
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Expected O, but got Unknown
		//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fb: Expected O, but got Unknown
		components = Form4.smethod_6();
		while (true)
		{
			int num = 1581540887;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4C57086Eu) % 67u)
				{
				case 66u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = (int)(num2 * 1872544208) ^ -1441299870;
					continue;
				case 65u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -47936111) ^ 0x54AFCB35;
					continue;
				case 64u:
					num = (int)(num2 * 262157949) ^ -933684254;
					continue;
				case 63u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = (int)((num2 * 1604842558) ^ 0x302F1FEB);
					continue;
				case 62u:
					num = (int)((num2 * 313352397) ^ 0x653E9564);
					continue;
				case 61u:
					Form4.smethod_31((Control)(object)this, "Form4");
					num = (int)(num2 * 512443474) ^ -1275855062;
					continue;
				case 60u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					Form4.smethod_19((Control)(object)this, "Регистрация");
					num = (int)((num2 * 626217324) ^ 0x27CBC8EC);
					continue;
				case 59u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = ((int)num2 * -910215323) ^ 0x3C62D3D9;
					continue;
				case 58u:
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					num = (int)((num2 * 749106217) ^ 0x7068F7EF);
					continue;
				case 57u:
					num = (int)((num2 * 524007683) ^ 0x638FAB19);
					continue;
				case 56u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = (int)(num2 * 1581389600) ^ -1145808878;
					continue;
				case 55u:
					textBox3 = Form4.smethod_7();
					button1 = Form4.smethod_8();
					num = (int)((num2 * 716545555) ^ 0x7F01D85B);
					continue;
				case 54u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1019325051) ^ -1179874899;
					continue;
				case 53u:
					Form4.smethod_18(textBox3, bool_0: true);
					num = ((int)num2 * -1162002684) ^ 0x7DF07DC8;
					continue;
				case 52u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = (int)(num2 * 328699750) ^ -985149776;
					continue;
				case 51u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = (int)((num2 * 19252881) ^ 0x5884B09A);
					continue;
				case 50u:
					num = ((int)num2 * -526173474) ^ 0x7EF6C1A1;
					continue;
				case 49u:
					num = ((int)num2 * -975923385) ^ 0x66384C1B;
					continue;
				case 48u:
					textBox2 = Form4.smethod_7();
					num = (int)(num2 * 1918912020) ^ -1503507999;
					continue;
				case 47u:
					textBox1 = Form4.smethod_7();
					num = (int)((num2 * 757707144) ^ 0x7279191F);
					continue;
				case 46u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -273662670) ^ -925177999;
					continue;
				case 45u:
					Form4.smethod_36((Control)(object)this, bool_0: false);
					Form4.smethod_37((Control)(object)this);
					num = ((int)num2 * -25534658) ^ -1230560788;
					continue;
				case 44u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = (int)((num2 * 909102245) ^ 0x11DBFA05);
					continue;
				case 43u:
					errorProvider1 = Form4.smethod_9(components);
					num = (int)(num2 * 2016491969) ^ -1620007126;
					continue;
				case 42u:
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = (int)(num2 * 629918513) ^ -783306174;
					continue;
				case 41u:
					num = ((int)num2 * -1894041831) ^ -392461406;
					continue;
				case 40u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = (int)((num2 * 827979439) ^ 0x1B54D45E);
					continue;
				case 39u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					num = (int)((num2 * 143095772) ^ 0x22BD54A7);
					continue;
				case 38u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = (int)(num2 * 245595593) ^ -1036795261;
					continue;
				case 37u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -1084103626) ^ -702941910;
					continue;
				case 36u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1304539663) ^ 0x1BA302DC;
					continue;
				case 35u:
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -2033480297) ^ -1305912111;
					continue;
				case 33u:
					num = (int)(num2 * 2129914830) ^ -548058994;
					continue;
				case 32u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1064296006) ^ 0x6439B932;
					continue;
				case 31u:
					num = (int)(num2 * 437800607) ^ -498451806;
					continue;
				case 30u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = (int)((num2 * 1044941050) ^ 0x441F52E1);
					continue;
				case 29u:
					num = ((int)num2 * -1750512583) ^ -910104299;
					continue;
				case 28u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = ((int)num2 * -1863483869) ^ -153014326;
					continue;
				case 27u:
					Form4.smethod_18(textBox2, bool_0: true);
					num = (int)(num2 * 905504877) ^ -1877823494;
					continue;
				case 26u:
					num = (int)((num2 * 797476908) ^ 0x5A0B9960);
					continue;
				case 24u:
					num = ((int)num2 * -319774007) ^ 0x429F0D87;
					continue;
				case 23u:
					num = (int)(num2 * 1364026945) ^ -1107645347;
					continue;
				case 22u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = (int)((num2 * 1786171686) ^ 0x7BB4E46D);
					continue;
				case 21u:
					num = (int)((num2 * 1894079950) ^ 0xED1EB07);
					continue;
				case 20u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 433224430) ^ 0x370B6B9F);
					continue;
				case 19u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = (int)((num2 * 663088088) ^ 0x5A210DBC);
					continue;
				case 18u:
					Form4.smethod_11((Control)(object)this);
					num = ((int)num2 * -807570262) ^ 0x7D0A7C11;
					continue;
				case 17u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -682231477) ^ 0x52258B71;
					continue;
				case 16u:
					num = ((int)num2 * -1118352407) ^ 0x57298F87;
					continue;
				case 15u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = ((int)num2 * -1491708761) ^ -1647370389;
					continue;
				case 14u:
					num = (int)((num2 * 1991449805) ^ 0x4B634746);
					continue;
				case 13u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -2049050508) ^ 0x266B420B;
					continue;
				case 12u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)(num2 * 2135706389) ^ -400726446;
					continue;
				case 11u:
					num = (int)((num2 * 619656793) ^ 0x3C1C4908);
					continue;
				case 10u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = (int)((num2 * 2114501936) ^ 0x6897C38C);
					continue;
				case 9u:
					num = (int)(num2 * 1902495621) ^ -263916924;
					continue;
				case 8u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = ((int)num2 * -1369272694) ^ -1976403709;
					continue;
				case 7u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 222059338) ^ 0x5C90DD4C);
					continue;
				case 6u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = ((int)num2 * -402317873) ^ 0x62C6757;
					continue;
				case 5u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = (int)(num2 * 59555266) ^ -296123771;
					continue;
				case 4u:
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -1692057965) ^ -1664369679;
					continue;
				case 3u:
					num = (int)((num2 * 69549846) ^ 0x59FDB0EA);
					continue;
				case 2u:
					num = ((int)num2 * -1730276509) ^ -246364064;
					continue;
				case 1u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 1038951840) ^ 0x11B9EC87);
					continue;
				case 0u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = (int)(num2 * 1992328928) ^ -881030070;
					continue;
				default:
					return;
				case 25u:
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
