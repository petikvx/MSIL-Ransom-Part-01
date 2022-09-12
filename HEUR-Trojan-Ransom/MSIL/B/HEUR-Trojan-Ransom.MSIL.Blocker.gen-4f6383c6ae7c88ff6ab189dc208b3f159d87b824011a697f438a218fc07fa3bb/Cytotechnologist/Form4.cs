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
			int num = -1352152858;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE633D821u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1473345654) ^ -747611897;
					continue;
				case 0u:
					num = ((int)num2 * -1352877847) ^ -2091461544;
					continue;
				case 2u:
					break;
				default:
					InitializeComponent();
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
		if (Form4.smethod_2(e) != ' ')
		{
			return;
		}
		while (true)
		{
			int num = -725990915;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAE976A64u) % 4u)
				{
				case 2u:
					num = (int)(num2 * 150248753) ^ -280563131;
					continue;
				case 1u:
					Form4.smethod_3(e, bool_0: true);
					num = ((int)num2 * -544690944) ^ 0x79419DB6;
					continue;
				default:
					return;
				case 0u:
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
			int num = 532849022;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x1BF110ECu) % 7u)
				{
				case 6u:
					((Form)this).Dispose(disposing);
					num = 436343256;
					continue;
				case 5u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_001d;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -259821843;
						num5 = -259821843;
					}
					else
					{
						num4 = -800565961;
						num5 = -800565961;
					}
					num = num4 ^ ((int)num2 * -1837358321);
					continue;
				}
				case 1u:
					if (disposing)
					{
						num = ((int)num2 * -752173802) ^ -910395187;
						continue;
					}
					num3 = 0;
					goto IL_001d;
				case 0u:
					Form4.smethod_5((IDisposable)components);
					num = ((int)num2 * -863172643) ^ 0x758C9B62;
					continue;
				default:
					return;
				case 3u:
					break;
				case 4u:
					return;
					IL_001d:
					flag = (byte)num3 != 0;
					num = 1908746254;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected O, but got Unknown
		while (true)
		{
			int num = 2093538335;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x26B29336u) % 52u)
				{
				case 51u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = (int)((num2 * 1240857684) ^ 0x18E9D0D9);
					continue;
				case 50u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = (int)(num2 * 2001221468) ^ -1415592904;
					continue;
				case 49u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					num = (int)(num2 * 1730097445) ^ -1843860198;
					continue;
				case 48u:
					Form4.smethod_31((Control)(object)this, "Form4");
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1759948823) ^ 0x498D6FA3;
					continue;
				case 47u:
					errorProvider1 = Form4.smethod_9(components);
					num = ((int)num2 * -930209590) ^ -1677072340;
					continue;
				case 46u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)(num2 * 189614657) ^ -826476507;
					continue;
				case 45u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = ((int)num2 * -1768785032) ^ 0x6E2F6417;
					continue;
				case 44u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1601779993) ^ 0x6584FB02);
					continue;
				case 43u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = (int)((num2 * 1953749521) ^ 0x7A6AC6A5);
					continue;
				case 42u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 991256229) ^ -1445366486;
					continue;
				case 41u:
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					num = (int)((num2 * 791042324) ^ 0x5D1F1102);
					continue;
				case 40u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = (int)((num2 * 752084105) ^ 0x5B1AC439);
					continue;
				case 39u:
					num = ((int)num2 * -2017801623) ^ -359283753;
					continue;
				case 38u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					Form4.smethod_15((Control)(object)button1, 0);
					num = ((int)num2 * -1468362262) ^ 0x68C89ABC;
					continue;
				case 37u:
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = (int)((num2 * 761768217) ^ 0x17EC85E6);
					continue;
				case 36u:
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1844359343) ^ 0x60C0788E;
					continue;
				case 35u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					num = ((int)num2 * -1494463214) ^ 0x78E72764;
					continue;
				case 34u:
					num = (int)((num2 * 142302708) ^ 0x401B8242);
					continue;
				case 33u:
					textBox2 = Form4.smethod_7();
					textBox3 = Form4.smethod_7();
					button1 = Form4.smethod_8();
					num = (int)(num2 * 1032481004) ^ -49184715;
					continue;
				case 32u:
					Form4.smethod_11((Control)(object)this);
					num = (int)(num2 * 145386208) ^ -666800299;
					continue;
				case 31u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = (int)(num2 * 185999086) ^ -1884805718;
					continue;
				case 30u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = (int)((num2 * 1049489367) ^ 0x568F5E45);
					continue;
				case 29u:
					num = (int)(num2 * 191391488) ^ -649567767;
					continue;
				case 28u:
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -1586200024) ^ -1714650714;
					continue;
				case 27u:
					textBox1 = Form4.smethod_7();
					num = (int)((num2 * 514436673) ^ 0x7B69B1F4);
					continue;
				case 26u:
					num = ((int)num2 * -147245888) ^ -1910561841;
					continue;
				case 25u:
					components = Form4.smethod_6();
					num = (int)((num2 * 1396383394) ^ 0x555506F7);
					continue;
				case 24u:
					num = ((int)num2 * -1011104622) ^ 0x464EA0EB;
					continue;
				case 22u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -1121732693) ^ 0x619905CE;
					continue;
				case 21u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = ((int)num2 * -850948012) ^ -233855457;
					continue;
				case 20u:
					num = ((int)num2 * -1548386013) ^ -125780988;
					continue;
				case 19u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = ((int)num2 * -46672170) ^ -725030716;
					continue;
				case 18u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = ((int)num2 * -457091982) ^ 0x4EB3947E;
					continue;
				case 17u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 1972957447) ^ -1841720435;
					continue;
				case 16u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1973307167) ^ 0x7E15E9C7;
					continue;
				case 15u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 1325565071) ^ 0x59D4A14D);
					continue;
				case 14u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = (int)((num2 * 2054579416) ^ 0x1C1843F0);
					continue;
				case 13u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -2140545856) ^ -1219867927;
					continue;
				case 12u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = (int)(num2 * 292673397) ^ -243239454;
					continue;
				case 11u:
					Form4.smethod_18(textBox3, bool_0: true);
					num = (int)(num2 * 1625679998) ^ -761969310;
					continue;
				case 10u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = (int)(num2 * 592231377) ^ -1884671606;
					continue;
				case 9u:
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = ((int)num2 * -2097407282) ^ 0x6056147B;
					continue;
				case 8u:
					num = (int)((num2 * 1442697140) ^ 0x3D14571);
					continue;
				case 7u:
					Form4.smethod_18(textBox2, bool_0: true);
					num = (int)(num2 * 1838230523) ^ -2114054312;
					continue;
				case 6u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 1456687454) ^ 0x4B70EEA);
					continue;
				case 5u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = (int)(num2 * 596430369) ^ -485495720;
					continue;
				case 4u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 1868636601) ^ 0x6C9BC2B8);
					continue;
				case 3u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 2087203276) ^ 0x4CD0E43B);
					continue;
				case 1u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = (int)((num2 * 1007042016) ^ 0x6843C1D5);
					continue;
				case 0u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = ((int)num2 * -7123697) ^ 0x3D46CA49;
					continue;
				case 2u:
					break;
				default:
					Form4.smethod_36((Control)(object)this, bool_0: false);
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
