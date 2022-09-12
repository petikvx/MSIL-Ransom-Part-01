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
			int num = -1099623238;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA3E30071u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -2103382258) ^ 0x332B1D61;
					continue;
				case 2u:
					InitializeComponent();
					num = (int)(num2 * 2709711) ^ -1704660346;
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
		while (true)
		{
			int num = -1454401599;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9DE3B840u) % 3u)
				{
				case 1u:
					goto IL_000e;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_000e:
				num = ((int)num2 * -1380696264) ^ -1910850104;
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
			int num = -848356728;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD29915FAu) % 4u)
				{
				case 2u:
					Form4.smethod_3(e, bool_0: true);
					num = (int)((num2 * 371254896) ^ 0x79EF39B);
					continue;
				case 1u:
					num = (int)((num2 * 597023976) ^ 0x70A8D631);
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
		while (true)
		{
			int num = 1095565102;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x426B3C9Bu) % 3u)
				{
				case 1u:
					goto IL_000d;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_000d:
				num = (int)((num2 * 1121037582) ^ 0x6C7E8FEF);
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -160171426;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xE5852C59u) % 8u)
				{
				case 7u:
					if (disposing)
					{
						num = (int)(num2 * 956510553) ^ -525450258;
						continue;
					}
					num3 = 0;
					goto IL_0019;
				case 6u:
					Form4.smethod_5((IDisposable)components);
					num = (int)((num2 * 279176894) ^ 0x4CFCC87E);
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1451822660;
						num5 = -1451822660;
					}
					else
					{
						num4 = -1614967015;
						num5 = -1614967015;
					}
					num = num4 ^ (int)(num2 * 1639741677);
					continue;
				}
				case 4u:
					num = ((int)num2 * -2086245439) ^ 0x741079AB;
					continue;
				case 3u:
					num = (int)((num2 * 1707721363) ^ 0x375E021);
					continue;
				case 0u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_0019;
				case 2u:
					break;
				default:
					{
						((Form)this).Dispose(disposing);
						return;
					}
					IL_0019:
					flag = (byte)num3 != 0;
					num = -722810132;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Expected O, but got Unknown
		while (true)
		{
			int num = -33583854;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDDD2006Fu) % 61u)
				{
				case 60u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = ((int)num2 * -5114562) ^ -1668573918;
					continue;
				case 59u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = (int)(num2 * 2097099333) ^ -1253818197;
					continue;
				case 58u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = (int)(num2 * 1846274188) ^ -1837516811;
					continue;
				case 57u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = ((int)num2 * -2015005140) ^ -127825766;
					continue;
				case 56u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = ((int)num2 * -608625738) ^ -1236875363;
					continue;
				case 55u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = (int)(num2 * 35610358) ^ -290865387;
					continue;
				case 54u:
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1342398603) ^ -456926590;
					continue;
				case 53u:
					Form4.smethod_31((Control)(object)this, "Form4");
					num = ((int)num2 * -985254928) ^ 0x655704E6;
					continue;
				case 52u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = ((int)num2 * -958077465) ^ 0x1C8EDA68;
					continue;
				case 51u:
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = (int)((num2 * 42425525) ^ 0x46346F4D);
					continue;
				case 50u:
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1818808228) ^ -1694266135;
					continue;
				case 49u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = ((int)num2 * -1173684497) ^ -1844575840;
					continue;
				case 48u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -2129801726) ^ 0xADE44E9;
					continue;
				case 47u:
					num = ((int)num2 * -1133577023) ^ 0x26148CBE;
					continue;
				case 46u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = ((int)num2 * -182846165) ^ -465495307;
					continue;
				case 45u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 895207735) ^ -1174106717;
					continue;
				case 44u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					num = ((int)num2 * -1167783001) ^ -1172927876;
					continue;
				case 43u:
					num = ((int)num2 * -1013484450) ^ -1337681172;
					continue;
				case 42u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = ((int)num2 * -587979282) ^ -1926160445;
					continue;
				case 41u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = (int)(num2 * 1054627041) ^ -955298057;
					continue;
				case 40u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -225446123) ^ -1763679690;
					continue;
				case 39u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = ((int)num2 * -2145674751) ^ 0x63312868;
					continue;
				case 38u:
					errorProvider1 = Form4.smethod_9(components);
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = (int)((num2 * 1390468599) ^ 0x2FE07BCD);
					continue;
				case 37u:
					num = (int)((num2 * 1433991929) ^ 0x30C3FA10);
					continue;
				case 36u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = ((int)num2 * -555099296) ^ -1645977904;
					continue;
				case 35u:
					num = ((int)num2 * -2029081569) ^ -916739773;
					continue;
				case 34u:
					Form4.smethod_29((Form)(object)this, bool_0: false);
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = (int)(num2 * 795717656) ^ -319166539;
					continue;
				case 33u:
					num = ((int)num2 * -1116111246) ^ 0x2E3082B;
					continue;
				case 32u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -1131541304) ^ -421489443;
					continue;
				case 31u:
					components = Form4.smethod_6();
					num = ((int)num2 * -1132465569) ^ 0x63AC8C42;
					continue;
				case 30u:
					num = ((int)num2 * -576655595) ^ -320594873;
					continue;
				case 29u:
					Form4.smethod_11((Control)(object)this);
					num = ((int)num2 * -436112221) ^ 0x6C07E453;
					continue;
				case 28u:
					Form4.smethod_18(textBox2, bool_0: true);
					num = (int)((num2 * 1217400438) ^ 0x3391A92D);
					continue;
				case 27u:
					num = ((int)num2 * -167747349) ^ -940469958;
					continue;
				case 26u:
					num = (int)((num2 * 256522061) ^ 0x34C08426);
					continue;
				case 25u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = ((int)num2 * -1093406833) ^ -303547829;
					continue;
				case 24u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = ((int)num2 * -2063192147) ^ 0x54AF5B9;
					continue;
				case 23u:
					textBox1 = Form4.smethod_7();
					textBox2 = Form4.smethod_7();
					num = ((int)num2 * -1758756418) ^ 0x528EBAF1;
					continue;
				case 21u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 617763528) ^ -1102962235;
					continue;
				case 20u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = (int)((num2 * 122694311) ^ 0x77077D37);
					continue;
				case 18u:
					num = ((int)num2 * -1865016456) ^ 0x43357C72;
					continue;
				case 17u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1264417209) ^ 0x24248C45);
					continue;
				case 16u:
					textBox3 = Form4.smethod_7();
					num = ((int)num2 * -336597891) ^ -74601074;
					continue;
				case 15u:
					num = (int)((num2 * 320321289) ^ 0x4FFD2CD8);
					continue;
				case 14u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -217290943) ^ -389377054;
					continue;
				case 13u:
					num = (int)((num2 * 1758998180) ^ 0x34439D0E);
					continue;
				case 12u:
					num = ((int)num2 * -1498656506) ^ -1786106245;
					continue;
				case 11u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -171727912) ^ 0x443C87BE;
					continue;
				case 10u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = (int)((num2 * 1019170815) ^ 0x44EE0571);
					continue;
				case 9u:
					num = ((int)num2 * -1225358830) ^ -451104351;
					continue;
				case 8u:
					num = ((int)num2 * -946179181) ^ -526186513;
					continue;
				case 7u:
					num = (int)(num2 * 702644596) ^ -1043202838;
					continue;
				case 6u:
					button1 = Form4.smethod_8();
					num = ((int)num2 * -1081450609) ^ -1998081839;
					continue;
				case 5u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = (int)((num2 * 1219866311) ^ 0x3D2B1C2C);
					continue;
				case 4u:
					Form4.smethod_18(textBox3, bool_0: true);
					num = (int)(num2 * 221137865) ^ -1928759062;
					continue;
				case 3u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -462725359) ^ -647097679;
					continue;
				case 2u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -394909749) ^ 0x3C34DD55;
					continue;
				case 1u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = ((int)num2 * -448359681) ^ -1160129857;
					continue;
				case 0u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -527935947) ^ 0x56CB7C10;
					continue;
				case 22u:
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
