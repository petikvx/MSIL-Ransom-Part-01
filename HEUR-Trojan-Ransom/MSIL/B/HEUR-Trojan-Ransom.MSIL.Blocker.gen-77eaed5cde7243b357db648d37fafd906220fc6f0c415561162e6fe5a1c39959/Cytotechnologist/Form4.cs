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
			int num = 1966904409;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2F33B8Fu) % 4u)
				{
				case 3u:
					InitializeComponent();
					num = ((int)num2 * -506566644) ^ 0x7756F752;
					continue;
				case 2u:
					num = (int)(num2 * 1328700512) ^ -1780772964;
					continue;
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

	private void Form4_FormClosing(object sender, FormClosingEventArgs e)
	{
		Form4.smethod_1((Control)(object)Form4.smethod_0((Form)(object)this), bool_0: true);
	}

	private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		while (true)
		{
			int num = 145926391;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7B4D92FAu) % 4u)
				{
				case 3u:
					Form4.smethod_3(e, bool_0: true);
					num = ((int)num2 * -672045913) ^ -2091124033;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (Form4.smethod_2(e) == ' ')
					{
						num3 = -2124753776;
						num4 = -2124753776;
					}
					else
					{
						num3 = -667903197;
						num4 = -667903197;
					}
					num = num3 ^ (int)(num2 * 195965837);
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
			int num = -239133242;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xAC6A1C55u) % 7u)
				{
				case 6u:
					((Form)this).Dispose(disposing);
					num = -1135620365;
					continue;
				case 5u:
					if (disposing)
					{
						num = ((int)num2 * -1171523282) ^ -1253484785;
						continue;
					}
					goto IL_0035;
				case 3u:
					if (components != null)
					{
						num = -20463104;
						num3 = -20463104;
						continue;
					}
					goto IL_0035;
				case 2u:
					Form4.smethod_5((IDisposable)components);
					num = ((int)num2 * -784959512) ^ 0x12168C1;
					continue;
				case 1u:
					num = (int)(num2 * 2015657539) ^ -2106513416;
					continue;
				default:
					return;
				case 0u:
					break;
				case 4u:
					return;
					IL_0035:
					num = -716979567;
					num3 = -716979567;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		components = Form4.smethod_6();
		textBox1 = Form4.smethod_7();
		while (true)
		{
			int num = 1844627940;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x791BB097u) % 66u)
				{
				case 65u:
					Form4.smethod_18(textBox3, bool_0: true);
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1062213506) ^ -343502320;
					continue;
				case 63u:
					num = (int)(num2 * 382898137) ^ -2081320594;
					continue;
				case 62u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = (int)((num2 * 1390800854) ^ 0x6B4A06DA);
					continue;
				case 61u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = ((int)num2 * -746432766) ^ -1053085787;
					continue;
				case 60u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -413707780) ^ -700890686;
					continue;
				case 59u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1199133434) ^ 0x22633602;
					continue;
				case 58u:
					num = (int)((num2 * 177184275) ^ 0x23AAD8FB);
					continue;
				case 57u:
					textBox2 = Form4.smethod_7();
					textBox3 = Form4.smethod_7();
					num = (int)(num2 * 1070420818) ^ -1591295118;
					continue;
				case 56u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = ((int)num2 * -2085775693) ^ -156354843;
					continue;
				case 55u:
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = ((int)num2 * -828513861) ^ -9606254;
					continue;
				case 54u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)((num2 * 1192503037) ^ 0x1FB899EA);
					continue;
				case 53u:
					num = (int)(num2 * 1162151537) ^ -686501795;
					continue;
				case 52u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 1718695680) ^ -1255396153;
					continue;
				case 51u:
					num = ((int)num2 * -38210257) ^ -2143364077;
					continue;
				case 50u:
					num = (int)(num2 * 1302999768) ^ -92191041;
					continue;
				case 49u:
					errorProvider1 = Form4.smethod_9(components);
					num = (int)(num2 * 1196746386) ^ -2069648162;
					continue;
				case 48u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = ((int)num2 * -589577104) ^ 0x26243CDA;
					continue;
				case 47u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1188849836) ^ 0x3B789EA;
					continue;
				case 46u:
					num = ((int)num2 * -2101283546) ^ -1543217082;
					continue;
				case 45u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)((num2 * 2038063252) ^ 0x54E7659F);
					continue;
				case 44u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -865356872) ^ 0x9AD3B12;
					continue;
				case 43u:
					num = (int)((num2 * 1012070796) ^ 0x13D0F711);
					continue;
				case 42u:
					num = ((int)num2 * -925569864) ^ -1311247674;
					continue;
				case 41u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = (int)((num2 * 346843556) ^ 0x279A6E95);
					continue;
				case 40u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 290804178) ^ 0x70BD9588);
					continue;
				case 39u:
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = (int)(num2 * 1676207705) ^ -113500208;
					continue;
				case 38u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = ((int)num2 * -2136833495) ^ -1227307267;
					continue;
				case 37u:
					num = ((int)num2 * -777002491) ^ 0x6D9C4D96;
					continue;
				case 36u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = (int)(num2 * 1526192223) ^ -1971879051;
					continue;
				case 35u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 387255819) ^ -803273708;
					continue;
				case 34u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = (int)((num2 * 1520441247) ^ 0x5E86A6DC);
					continue;
				case 33u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = ((int)num2 * -1782042162) ^ 0x1B89074B;
					continue;
				case 32u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1362725440) ^ -869318284;
					continue;
				case 31u:
					Form4.smethod_37((Control)(object)this);
					num = (int)(num2 * 1288999125) ^ -349442963;
					continue;
				case 30u:
					Form4.smethod_31((Control)(object)this, "Form4");
					num = ((int)num2 * -1544084957) ^ -1510505887;
					continue;
				case 29u:
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = (int)((num2 * 789164292) ^ 0x2DF0034);
					continue;
				case 28u:
					num = (int)(num2 * 1174293110) ^ -1797682925;
					continue;
				case 27u:
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					num = (int)((num2 * 185584835) ^ 0x5607FAE9);
					continue;
				case 26u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = (int)((num2 * 888925337) ^ 0x553DC24C);
					continue;
				case 25u:
					num = (int)((num2 * 9024897) ^ 0x144FA170);
					continue;
				case 24u:
					Form4.smethod_18(textBox2, bool_0: true);
					num = (int)((num2 * 749231929) ^ 0x41EFCBC7);
					continue;
				case 23u:
					num = (int)(num2 * 77685029) ^ -1226965033;
					continue;
				case 22u:
					num = ((int)num2 * -1522353973) ^ -71508058;
					continue;
				case 21u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -2055287252) ^ -1382905355;
					continue;
				case 20u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -1479714198) ^ -194248147;
					continue;
				case 18u:
					num = ((int)num2 * -1960503154) ^ 0xF39B088;
					continue;
				case 17u:
					button1 = Form4.smethod_8();
					num = (int)(num2 * 188295690) ^ -1016364184;
					continue;
				case 16u:
					num = (int)((num2 * 126937186) ^ 0x3F052F9);
					continue;
				case 15u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = (int)((num2 * 250744722) ^ 0x6867D04B);
					continue;
				case 14u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = ((int)num2 * -1419817414) ^ 0x45ECC15C;
					continue;
				case 13u:
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 1218633678) ^ -2137600899;
					continue;
				case 12u:
					Form4.smethod_11((Control)(object)this);
					num = (int)((num2 * 59438640) ^ 0x11B305DB);
					continue;
				case 11u:
					num = ((int)num2 * -1300649696) ^ -1224363098;
					continue;
				case 10u:
					num = (int)((num2 * 890003224) ^ 0x6A74B567);
					continue;
				case 9u:
					num = (int)(num2 * 838990813) ^ -1166237249;
					continue;
				case 8u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = ((int)num2 * -958714801) ^ -939688766;
					continue;
				case 7u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = ((int)num2 * -665963301) ^ 0x1664B3C6;
					continue;
				case 6u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = ((int)num2 * -334740829) ^ -178398564;
					continue;
				case 5u:
					num = (int)((num2 * 1350818784) ^ 0x7B591701);
					continue;
				case 4u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					Form4.smethod_13((Control)(object)button1, "button1");
					num = ((int)num2 * -1892406787) ^ 0x123442C9;
					continue;
				case 3u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = (int)((num2 * 168183277) ^ 0x1714BF57);
					continue;
				case 2u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1959924739) ^ -1273350771;
					continue;
				case 1u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = (int)(num2 * 658239508) ^ -515994355;
					continue;
				case 0u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = ((int)num2 * -1819752445) ^ 0x214BE496;
					continue;
				default:
					return;
				case 64u:
					break;
				case 19u:
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
