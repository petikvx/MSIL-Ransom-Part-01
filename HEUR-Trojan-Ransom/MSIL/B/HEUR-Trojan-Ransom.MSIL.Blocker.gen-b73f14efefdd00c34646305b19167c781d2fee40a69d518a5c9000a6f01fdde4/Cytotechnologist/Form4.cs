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
		bool flag = default(bool);
		while (true)
		{
			int num = -1012480973;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE7492BBCu) % 6u)
				{
				case 5u:
					num = (int)((num2 * 1417535136) ^ 0x566756A8);
					continue;
				case 4u:
					Form4.smethod_3(e, bool_0: true);
					num = (int)((num2 * 830102194) ^ 0x210DE4A1);
					continue;
				case 3u:
					flag = Form4.smethod_2(e) == ' ';
					num = (int)((num2 * 633916720) ^ 0x32F41E0B);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -2063354746;
						num4 = -2063354746;
					}
					else
					{
						num3 = -1622926210;
						num4 = -1622926210;
					}
					num = num3 ^ (int)(num2 * 871768730);
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 2u:
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
			int num = -649571174;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA57EF373u) % 3u)
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
				num = ((int)num2 * -1448851352) ^ -2010020236;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 1809359792;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x7BC8FBDAu) % 9u)
				{
				case 8u:
					Form4.smethod_5((IDisposable)components);
					num = (int)((num2 * 1329762739) ^ 0xE4971A5);
					continue;
				case 7u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_0029;
				case 6u:
					num = (int)(num2 * 322076336) ^ -1778173542;
					continue;
				case 5u:
					num = (int)(num2 * 1577823607) ^ -275604158;
					continue;
				case 4u:
					((Form)this).Dispose(disposing);
					num = 496913776;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1848643149;
						num5 = 1848643149;
					}
					else
					{
						num4 = 1318474390;
						num5 = 1318474390;
					}
					num = num4 ^ (int)(num2 * 193067763);
					continue;
				}
				case 1u:
					if (disposing)
					{
						num = ((int)num2 * -1586211005) ^ 0x38A924B6;
						continue;
					}
					num3 = 0;
					goto IL_0029;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
					IL_0029:
					flag = (byte)num3 != 0;
					num = 670118543;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected O, but got Unknown
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected O, but got Unknown
		//IL_076e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0778: Expected O, but got Unknown
		while (true)
		{
			int num = -1979188518;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB8C93C6Eu) % 73u)
				{
				case 71u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1942454844) ^ -527228879;
					continue;
				case 70u:
					Form4.smethod_31((Control)(object)this, "Form4");
					num = ((int)num2 * -302111827) ^ 0x7905FBB1;
					continue;
				case 69u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = (int)((num2 * 412552308) ^ 0x179A2D49);
					continue;
				case 68u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = (int)(num2 * 265394175) ^ -1234380581;
					continue;
				case 67u:
					num = (int)(num2 * 1784681511) ^ -463046152;
					continue;
				case 65u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = (int)((num2 * 1056599924) ^ 0x52DE8E20);
					continue;
				case 64u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = (int)(num2 * 676493920) ^ -901990675;
					continue;
				case 63u:
					components = Form4.smethod_6();
					num = (int)((num2 * 287247455) ^ 0x6A96889B);
					continue;
				case 62u:
					num = (int)((num2 * 219388339) ^ 0x510E6AEE);
					continue;
				case 61u:
					num = ((int)num2 * -133013390) ^ 0x10053D30;
					continue;
				case 60u:
					num = ((int)num2 * -1325807623) ^ -1401510411;
					continue;
				case 59u:
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1569970688) ^ 0x42124C49);
					continue;
				case 58u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -1907980299) ^ 0x496DBC98;
					continue;
				case 57u:
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = (int)((num2 * 2055620644) ^ 0x10A9A524);
					continue;
				case 56u:
					Form4.smethod_11((Control)(object)this);
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = (int)(num2 * 1886849008) ^ -720476156;
					continue;
				case 55u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -424800422) ^ -122364130;
					continue;
				case 54u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = (int)(num2 * 2109718861) ^ -1959314572;
					continue;
				case 53u:
					num = (int)(num2 * 311214417) ^ -126563168;
					continue;
				case 52u:
					num = (int)((num2 * 1413837622) ^ 0x265CD3F);
					continue;
				case 51u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)(num2 * 1511837714) ^ -884500583;
					continue;
				case 50u:
					num = (int)((num2 * 2098247360) ^ 0x3664EBF2);
					continue;
				case 49u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = (int)((num2 * 2037533951) ^ 0x28816AB1);
					continue;
				case 48u:
					num = (int)(num2 * 137421739) ^ -302653122;
					continue;
				case 47u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = ((int)num2 * -270933854) ^ 0x26887B85;
					continue;
				case 46u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -1227250649) ^ 0x1C8E0FCD;
					continue;
				case 45u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = (int)(num2 * 505531580) ^ -178811590;
					continue;
				case 44u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = ((int)num2 * -1099640399) ^ 0x6F10DF06;
					continue;
				case 43u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 975694622) ^ 0x20B2AF97);
					continue;
				case 42u:
					num = ((int)num2 * -147724551) ^ -310601272;
					continue;
				case 41u:
					num = (int)(num2 * 1535351640) ^ -1802154896;
					continue;
				case 40u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = ((int)num2 * -634210835) ^ -957767869;
					continue;
				case 39u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -580702452) ^ -489813461;
					continue;
				case 38u:
					num = ((int)num2 * -720044625) ^ 0x135CDF43;
					continue;
				case 37u:
					button1 = Form4.smethod_8();
					errorProvider1 = Form4.smethod_9(components);
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -806823504) ^ -861027571;
					continue;
				case 36u:
					textBox2 = Form4.smethod_7();
					num = ((int)num2 * -2137761042) ^ 0x605F2BC5;
					continue;
				case 35u:
					num = (int)((num2 * 1650478160) ^ 0x40B7803B);
					continue;
				case 34u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1506470241) ^ 0x315D73D0;
					continue;
				case 33u:
					num = ((int)num2 * -839321504) ^ 0x6869F721;
					continue;
				case 32u:
					Form4.smethod_18(textBox3, bool_0: true);
					num = ((int)num2 * -408737189) ^ 0x185B045A;
					continue;
				case 31u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = ((int)num2 * -362609027) ^ 0x16CA8C58;
					continue;
				case 30u:
					Form4.smethod_37((Control)(object)this);
					num = (int)((num2 * 372021014) ^ 0xC4A2F13);
					continue;
				case 29u:
					num = ((int)num2 * -856449361) ^ -314548767;
					continue;
				case 28u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = ((int)num2 * -188180326) ^ -577486967;
					continue;
				case 27u:
					num = (int)((num2 * 1477603054) ^ 0x4C1694EE);
					continue;
				case 26u:
					num = ((int)num2 * -826421327) ^ -2027532485;
					continue;
				case 25u:
					num = ((int)num2 * -1708762686) ^ -1311967866;
					continue;
				case 24u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)((num2 * 220703693) ^ 0x587F82AD);
					continue;
				case 23u:
					textBox3 = Form4.smethod_7();
					num = ((int)num2 * -1304442146) ^ 0x515805C4;
					continue;
				case 22u:
					num = ((int)num2 * -264560617) ^ 0x2A439076;
					continue;
				case 21u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = ((int)num2 * -1606356917) ^ -1187295964;
					continue;
				case 20u:
					num = (int)((num2 * 965850182) ^ 0x1ACC6371);
					continue;
				case 19u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -591510280) ^ 0x11128DC1;
					continue;
				case 18u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = ((int)num2 * -1839950390) ^ -394897723;
					continue;
				case 17u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = ((int)num2 * -1845846079) ^ 0x4F4A1180;
					continue;
				case 16u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = (int)((num2 * 2043996438) ^ 0xA249978);
					continue;
				case 15u:
					num = ((int)num2 * -741326510) ^ 0x2FB017CE;
					continue;
				case 14u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = (int)((num2 * 765728450) ^ 0x46E20EC7);
					continue;
				case 13u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1880206666) ^ -149477364;
					continue;
				case 12u:
					Form4.smethod_18(textBox2, bool_0: true);
					num = (int)(num2 * 1955726350) ^ -1495804553;
					continue;
				case 11u:
					num = ((int)num2 * -2145513123) ^ -1968864165;
					continue;
				case 10u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = ((int)num2 * -1444567365) ^ -560293835;
					continue;
				case 9u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					num = (int)((num2 * 199643693) ^ 0x3E8503CB);
					continue;
				case 8u:
					num = (int)(num2 * 1387535407) ^ -1726677804;
					continue;
				case 7u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = ((int)num2 * -1604781935) ^ -271861548;
					continue;
				case 6u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = (int)((num2 * 1005884770) ^ 0xB241AF0);
					continue;
				case 5u:
					textBox1 = Form4.smethod_7();
					num = ((int)num2 * -1252650045) ^ 0xCFE8F34;
					continue;
				case 4u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 2080772536) ^ -433668144;
					continue;
				case 3u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = ((int)num2 * -1141893238) ^ 0x2375786F;
					continue;
				case 2u:
					num = ((int)num2 * -1195085706) ^ 0x1A913631;
					continue;
				case 1u:
					num = ((int)num2 * -1099511245) ^ 0x212B9115;
					continue;
				case 0u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1708698638) ^ -1887811854;
					continue;
				default:
					return;
				case 66u:
					break;
				case 72u:
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
