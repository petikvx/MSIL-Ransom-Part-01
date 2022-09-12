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
			int num = -1394394568;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEED817D7u) % 6u)
				{
				case 3u:
					InitializeComponent();
					num = (int)((num2 * 233660394) ^ 0x5EEF79F7);
					continue;
				case 2u:
					num = ((int)num2 * -1243321813) ^ 0x1C24CFB4;
					continue;
				case 1u:
					num = (int)(num2 * 2121299948) ^ -1472593981;
					continue;
				case 0u:
					num = (int)(num2 * 135186759) ^ -2102231738;
					continue;
				default:
					return;
				case 4u:
					break;
				case 5u:
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
			int num = 1464986402;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3B870DD7u) % 4u)
				{
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -2139569527;
						num4 = -2139569527;
					}
					else
					{
						num3 = -1625357498;
						num4 = -1625357498;
					}
					num = num3 ^ (int)(num2 * 615848754);
					continue;
				}
				case 0u:
					Form4.smethod_3(e, bool_0: true);
					num = (int)(num2 * 1591998183) ^ -1767068800;
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
		while (true)
		{
			int num = -1474236295;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD5DAA206u) % 3u)
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
				num = (int)((num2 * 260010910) ^ 0x6E3CF852);
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_0017;
		}
		int num = 0;
		goto IL_009f;
		IL_009f:
		bool flag = (byte)num != 0;
		int num2 = -2055139228;
		goto IL_0069;
		IL_0017:
		num2 = -1983316343;
		goto IL_0069;
		IL_0069:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xFFBAC089u) % 7u)
			{
			case 4u:
				((Form)this).Dispose(disposing);
				num2 = -2084933681;
				continue;
			case 3u:
				break;
			case 2u:
				num2 = (int)(num3 * 994397285) ^ -603197703;
				continue;
			case 1u:
				Form4.smethod_5((IDisposable)components);
				num2 = ((int)num3 * -766116746) ^ -991627806;
				continue;
			case 0u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 1609632382;
					num5 = 1609632382;
				}
				else
				{
					num4 = 1838928540;
					num5 = 1838928540;
				}
				num2 = num4 ^ (int)(num3 * 1355101550);
				continue;
			}
			default:
				return;
			case 6u:
				goto IL_0096;
			case 5u:
				return;
			}
			break;
		}
		goto IL_0017;
		IL_0096:
		num = ((components != null) ? 1 : 0);
		goto IL_009f;
	}

	private void InitializeComponent()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected O, but got Unknown
		while (true)
		{
			int num = -49264751;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD3522CD6u) % 68u)
				{
				case 67u:
					Form4.smethod_15((Control)(object)button1, 0);
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = ((int)num2 * -477189256) ^ 0x7834AE94;
					continue;
				case 66u:
					num = ((int)num2 * -1848362512) ^ 0x2ABA941B;
					continue;
				case 65u:
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -840797364) ^ 0x43C50E65;
					continue;
				case 64u:
					num = ((int)num2 * -1801632890) ^ -1060228957;
					continue;
				case 63u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1316805436) ^ -581777758;
					continue;
				case 62u:
					Form4.smethod_37((Control)(object)this);
					num = ((int)num2 * -27119967) ^ 0x5DC0DDE4;
					continue;
				case 61u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = (int)(num2 * 1190469617) ^ -947402012;
					continue;
				case 60u:
					textBox3 = Form4.smethod_7();
					num = (int)(num2 * 1633004282) ^ -871730899;
					continue;
				case 59u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = (int)(num2 * 616740666) ^ -55654014;
					continue;
				case 58u:
					num = (int)(num2 * 1328171770) ^ -266439016;
					continue;
				case 57u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = ((int)num2 * -1520648973) ^ 0x466AC8E6;
					continue;
				case 56u:
					num = (int)(num2 * 1445007650) ^ -1646349610;
					continue;
				case 55u:
					num = (int)((num2 * 1934339452) ^ 0x74599111);
					continue;
				case 54u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = (int)(num2 * 1271479622) ^ -1882998642;
					continue;
				case 53u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -534655053) ^ 0x548322F7;
					continue;
				case 52u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = (int)(num2 * 1160412602) ^ -1543476393;
					continue;
				case 51u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 297621094) ^ -1414594079;
					continue;
				case 50u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -619742698) ^ -408616388;
					continue;
				case 49u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 1715825549) ^ 0x60BE7FBA);
					continue;
				case 48u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = (int)((num2 * 252288797) ^ 0x2893C2B4);
					continue;
				case 47u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = ((int)num2 * -2110834907) ^ -1223624338;
					continue;
				case 46u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					num = (int)((num2 * 2033755289) ^ 0x2D8DCE80);
					continue;
				case 45u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = ((int)num2 * -162080650) ^ -997822776;
					continue;
				case 44u:
					Form4.smethod_18(textBox3, bool_0: true);
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -719964269) ^ 0x37A1E48F;
					continue;
				case 43u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -1164558598) ^ -1580779178;
					continue;
				case 42u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					Form4.smethod_18(textBox2, bool_0: true);
					num = ((int)num2 * -1535134290) ^ -1051029366;
					continue;
				case 41u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1112709212) ^ -1684607614;
					continue;
				case 40u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = ((int)num2 * -91887185) ^ 0x6DB2A8BC;
					continue;
				case 39u:
					num = ((int)num2 * -357129677) ^ 0x81072DA;
					continue;
				case 38u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = (int)((num2 * 1104656884) ^ 0x39DCB25);
					continue;
				case 37u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					num = (int)((num2 * 410478827) ^ 0x60EAFA60);
					continue;
				case 35u:
					components = Form4.smethod_6();
					num = ((int)num2 * -1833612221) ^ -938103702;
					continue;
				case 34u:
					num = ((int)num2 * -1432439164) ^ -986150564;
					continue;
				case 33u:
					num = ((int)num2 * -1066679584) ^ -136400028;
					continue;
				case 32u:
					num = ((int)num2 * -1671362970) ^ 0x561E49D3;
					continue;
				case 31u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = (int)((num2 * 570236707) ^ 0x12F1FAA5);
					continue;
				case 30u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = ((int)num2 * -2030697359) ^ 0x6D98621A;
					continue;
				case 29u:
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = ((int)num2 * -163560776) ^ 0x6170D977;
					continue;
				case 28u:
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1532061766) ^ 0x45813EB8;
					continue;
				case 27u:
					Form4.smethod_11((Control)(object)this);
					num = (int)(num2 * 509523826) ^ -47872492;
					continue;
				case 26u:
					num = ((int)num2 * -1125817099) ^ 0x725C86F;
					continue;
				case 25u:
					num = ((int)num2 * -1837496494) ^ -10158029;
					continue;
				case 24u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = (int)(num2 * 1346801263) ^ -1011432056;
					continue;
				case 23u:
					num = (int)(num2 * 228240751) ^ -484823510;
					continue;
				case 22u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 1199014558) ^ -823421275;
					continue;
				case 20u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = (int)(num2 * 1161609975) ^ -981952594;
					continue;
				case 19u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = (int)(num2 * 741762098) ^ -515934106;
					continue;
				case 18u:
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1942854541) ^ -543627006;
					continue;
				case 17u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1406455438) ^ 0x11CB585B;
					continue;
				case 16u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = ((int)num2 * -194014101) ^ -176542515;
					continue;
				case 15u:
					num = (int)((num2 * 1676777450) ^ 0xF7BD875);
					continue;
				case 14u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = (int)((num2 * 1080247593) ^ 0x388CE469);
					continue;
				case 13u:
					errorProvider1 = Form4.smethod_9(components);
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = (int)((num2 * 577505810) ^ 0x5C66AC27);
					continue;
				case 12u:
					num = (int)(num2 * 1447167800) ^ -1668317595;
					continue;
				case 11u:
					button1 = Form4.smethod_8();
					num = (int)(num2 * 55169944) ^ -1690566681;
					continue;
				case 10u:
					num = ((int)num2 * -542748076) ^ -687440039;
					continue;
				case 9u:
					textBox1 = Form4.smethod_7();
					textBox2 = Form4.smethod_7();
					num = ((int)num2 * -261840347) ^ -414918729;
					continue;
				case 8u:
					Form4.smethod_31((Control)(object)this, "Form4");
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = ((int)num2 * -945114596) ^ 0x26070E42;
					continue;
				case 7u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = ((int)num2 * -2019471769) ^ -592348457;
					continue;
				case 6u:
					num = (int)((num2 * 524072406) ^ 0x789AC156);
					continue;
				case 5u:
					num = ((int)num2 * -1502675942) ^ -1801772614;
					continue;
				case 4u:
					num = ((int)num2 * -1166624479) ^ -1290832886;
					continue;
				case 3u:
					num = (int)((num2 * 1665798032) ^ 0x58F86E31);
					continue;
				case 2u:
					num = (int)((num2 * 1514657981) ^ 0x37A52DFC);
					continue;
				case 1u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 351398960) ^ 0x13BF4866);
					continue;
				case 0u:
					num = (int)((num2 * 284316278) ^ 0x3F9F4BCB);
					continue;
				default:
					return;
				case 21u:
					break;
				case 36u:
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
