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
			int num = 1149078516;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5BD1EA5Bu) % 6u)
				{
				case 4u:
					num = (int)((num2 * 653085559) ^ 0x103E55B8);
					continue;
				case 3u:
					Form4.smethod_3(e, bool_0: true);
					num = ((int)num2 * -772828783) ^ -37217388;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1942978250;
						num4 = -1942978250;
					}
					else
					{
						num3 = -731160502;
						num4 = -731160502;
					}
					num = num3 ^ (int)(num2 * 1430695195);
					continue;
				}
				case 1u:
					flag = Form4.smethod_2(e) == ' ';
					num = ((int)num2 * -2101464544) ^ -1092205743;
					continue;
				default:
					return;
				case 0u:
					break;
				case 5u:
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
			goto IL_006b;
		}
		goto IL_00ac;
		IL_006b:
		int num = 80588322;
		goto IL_0070;
		IL_0070:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x57213D63u) % 8u)
			{
			case 6u:
				num = ((int)num2 * -600108784) ^ 0x7FF69D9C;
				continue;
			case 5u:
				((Form)this).Dispose(disposing);
				num = 139361637;
				continue;
			case 4u:
				Form4.smethod_5((IDisposable)components);
				num = (int)((num2 * 1290214111) ^ 0x2B65C5AD);
				continue;
			case 3u:
				num = ((int)num2 * -91647509) ^ 0x1E385C8E;
				continue;
			case 2u:
				num = ((int)num2 * -1553411518) ^ 0x236F65C2;
				continue;
			case 0u:
				break;
			default:
				return;
			case 1u:
				goto IL_00a1;
			case 7u:
				return;
			}
			break;
			IL_00a1:
			if (components != null)
			{
				num = 866090112;
				num3 = 866090112;
				continue;
			}
			goto IL_00ac;
		}
		goto IL_006b;
		IL_00ac:
		num = 576598838;
		num3 = 576598838;
		goto IL_0070;
	}

	private void InitializeComponent()
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected O, but got Unknown
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected O, but got Unknown
		//IL_06a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Expected O, but got Unknown
		while (true)
		{
			int num = -655221502;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE86BB5DEu) % 64u)
				{
				case 63u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = (int)(num2 * 619122284) ^ -1370791988;
					continue;
				case 62u:
					num = ((int)num2 * -1231439123) ^ 0x2CA7EC39;
					continue;
				case 61u:
					num = (int)((num2 * 1076935677) ^ 0x5513A172);
					continue;
				case 60u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = (int)((num2 * 851819476) ^ 0x5FFA0D7F);
					continue;
				case 59u:
					num = ((int)num2 * -2058408139) ^ 0x33A14B3C;
					continue;
				case 58u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = (int)((num2 * 1842322988) ^ 0x3C071911);
					continue;
				case 57u:
					num = ((int)num2 * -240657085) ^ 0x216ACA0A;
					continue;
				case 56u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = ((int)num2 * -1182083408) ^ 0x4AC32E92;
					continue;
				case 55u:
					num = (int)((num2 * 2125176591) ^ 0x324FE13F);
					continue;
				case 54u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = ((int)num2 * -2015079586) ^ 0x75B0F720;
					continue;
				case 53u:
					num = (int)(num2 * 1133901715) ^ -1699792024;
					continue;
				case 52u:
					textBox2 = Form4.smethod_7();
					textBox3 = Form4.smethod_7();
					button1 = Form4.smethod_8();
					num = ((int)num2 * -1086625820) ^ -394650516;
					continue;
				case 51u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = (int)(num2 * 1717136631) ^ -1639058285;
					continue;
				case 50u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = (int)((num2 * 836511958) ^ 0x4CC145BA);
					continue;
				case 49u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = (int)((num2 * 671760381) ^ 0x31BB1943);
					continue;
				case 48u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1426254176) ^ -1466882242;
					continue;
				case 47u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = (int)(num2 * 1417193455) ^ -149634926;
					continue;
				case 46u:
					Form4.smethod_37((Control)(object)this);
					num = ((int)num2 * -21793495) ^ -1347065340;
					continue;
				case 45u:
					num = (int)(num2 * 1963066325) ^ -67367188;
					continue;
				case 44u:
					num = (int)(num2 * 88572553) ^ -1877147877;
					continue;
				case 43u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = ((int)num2 * -892845891) ^ -583466723;
					continue;
				case 42u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -22271034) ^ 0x12857374;
					continue;
				case 41u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = ((int)num2 * -1770982236) ^ 0x6BCEAC8E;
					continue;
				case 40u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = ((int)num2 * -763652584) ^ 0x4B7BC8D5;
					continue;
				case 39u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -196405683) ^ 0x53034EE5;
					continue;
				case 38u:
					num = (int)(num2 * 1177822779) ^ -2002394474;
					continue;
				case 37u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = ((int)num2 * -1024046642) ^ 0xECB37E2;
					continue;
				case 35u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					Form4.smethod_18(textBox2, bool_0: true);
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 912718703) ^ -1865515219;
					continue;
				case 34u:
					errorProvider1 = Form4.smethod_9(components);
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = (int)((num2 * 91404756) ^ 0x6BE5542C);
					continue;
				case 33u:
					num = ((int)num2 * -1106611734) ^ 0xDCD6B07;
					continue;
				case 32u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -85039400) ^ -1993170164;
					continue;
				case 30u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = (int)((num2 * 1708952559) ^ 0x2F572F29);
					continue;
				case 29u:
					num = ((int)num2 * -147864272) ^ -761130263;
					continue;
				case 28u:
					components = Form4.smethod_6();
					textBox1 = Form4.smethod_7();
					num = ((int)num2 * -1931115601) ^ -203140786;
					continue;
				case 27u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = ((int)num2 * -1859611455) ^ -644241161;
					continue;
				case 26u:
					num = (int)((num2 * 1559251543) ^ 0x7CB97718);
					continue;
				case 25u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = ((int)num2 * -1349469278) ^ -779020691;
					continue;
				case 24u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = (int)(num2 * 1194134536) ^ -1784902659;
					continue;
				case 23u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -1181596051) ^ -1446344134;
					continue;
				case 22u:
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1826175863) ^ 0x50A5CBB6;
					continue;
				case 21u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1129214916) ^ -1550149684;
					continue;
				case 20u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -2018457856) ^ 0x604D02F2;
					continue;
				case 19u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -835043733) ^ -1050954070;
					continue;
				case 18u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = (int)(num2 * 1104887692) ^ -1576182460;
					continue;
				case 17u:
					num = ((int)num2 * -1865911250) ^ 0x7370B7E1;
					continue;
				case 16u:
					Form4.smethod_11((Control)(object)this);
					num = (int)(num2 * 1022410283) ^ -1092004363;
					continue;
				case 15u:
					Form4.smethod_31((Control)(object)this, "Form4");
					num = ((int)num2 * -1803168629) ^ -1891332032;
					continue;
				case 14u:
					num = (int)(num2 * 33665622) ^ -755104327;
					continue;
				case 13u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = ((int)num2 * -1501860319) ^ 0x401C0D55;
					continue;
				case 12u:
					Form4.smethod_18(textBox3, bool_0: true);
					num = (int)((num2 * 1857809208) ^ 0x14A08159);
					continue;
				case 11u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 1601111099) ^ -1322964321;
					continue;
				case 10u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 868804940) ^ 0x6E93318F);
					continue;
				case 9u:
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = ((int)num2 * -84194959) ^ -1370491490;
					continue;
				case 8u:
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -1646796636) ^ -1215457533;
					continue;
				case 7u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					num = (int)((num2 * 1443752868) ^ 0x41EA8794);
					continue;
				case 6u:
					num = (int)(num2 * 265174182) ^ -1349501131;
					continue;
				case 5u:
					num = (int)(num2 * 842935292) ^ -1006933249;
					continue;
				case 4u:
					num = ((int)num2 * -1391312500) ^ -1468564943;
					continue;
				case 3u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = (int)((num2 * 746893997) ^ 0x452B0872);
					continue;
				case 2u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -559957455) ^ -1610534222;
					continue;
				case 1u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1200886816) ^ -2146294173;
					continue;
				case 0u:
					num = ((int)num2 * -209840313) ^ -1872065719;
					continue;
				default:
					return;
				case 36u:
					break;
				case 31u:
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
