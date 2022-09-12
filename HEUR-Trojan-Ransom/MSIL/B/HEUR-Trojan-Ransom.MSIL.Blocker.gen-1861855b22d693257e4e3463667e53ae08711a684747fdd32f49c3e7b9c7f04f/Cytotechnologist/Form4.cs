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
			int num = -1669735006;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCA27E41Du) % 5u)
				{
				case 4u:
					InitializeComponent();
					num = (int)((num2 * 1555428254) ^ 0x329B2EF8);
					continue;
				case 3u:
					num = (int)((num2 * 1130359907) ^ 0x2F7D7A04);
					continue;
				case 2u:
					num = (int)(num2 * 105689520) ^ -679539169;
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
		bool flag = Form4.smethod_2(e) == ' ';
		while (true)
		{
			int num = -2137441866;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x862E722Bu) % 5u)
				{
				case 3u:
					Form4.smethod_3(e, bool_0: true);
					num = ((int)num2 * -596422723) ^ 0x688660AE;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1355574743;
						num4 = 1355574743;
					}
					else
					{
						num3 = 446088608;
						num4 = 446088608;
					}
					num = num3 ^ ((int)num2 * -1159075921);
					continue;
				}
				case 0u:
					num = ((int)num2 * -507754878) ^ 0x59D366FE;
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
			int num = 1092846774;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x2B82A051u) % 8u)
				{
				case 7u:
					if (disposing)
					{
						num = (int)(num2 * 871630069) ^ -48334962;
						continue;
					}
					goto IL_001b;
				case 6u:
					num = (int)(num2 * 1126687676) ^ -1323366000;
					continue;
				case 5u:
					((Form)this).Dispose(disposing);
					num = 910075699;
					continue;
				case 4u:
					if (components != null)
					{
						num = 1485330105;
						num3 = 1485330105;
						continue;
					}
					goto IL_001b;
				case 1u:
					num = (int)(num2 * 287472756) ^ -955013592;
					continue;
				case 0u:
					Form4.smethod_5((IDisposable)components);
					num = ((int)num2 * -1007737709) ^ -1694439793;
					continue;
				default:
					return;
				case 3u:
					break;
				case 2u:
					return;
					IL_001b:
					num = 1400954044;
					num3 = 1400954044;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected O, but got Unknown
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected O, but got Unknown
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Expected O, but got Unknown
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Expected O, but got Unknown
		components = Form4.smethod_6();
		textBox1 = Form4.smethod_7();
		textBox2 = Form4.smethod_7();
		textBox3 = Form4.smethod_7();
		while (true)
		{
			int num = 1061756968;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7BEF2E75u) % 53u)
				{
				case 52u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 2000097720) ^ 0x41EE739F);
					continue;
				case 51u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = (int)(num2 * 797479672) ^ -274586189;
					continue;
				case 50u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = (int)(num2 * 423954788) ^ -597423373;
					continue;
				case 49u:
					Form4.smethod_31((Control)(object)this, "Form4");
					num = ((int)num2 * -961679729) ^ -1399384233;
					continue;
				case 48u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 1177041526) ^ 0x3ADFA0FF);
					continue;
				case 47u:
					num = ((int)num2 * -1062227926) ^ -401740247;
					continue;
				case 46u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = (int)((num2 * 1966214738) ^ 0x2FAAD2B5);
					continue;
				case 45u:
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = (int)(num2 * 1048907827) ^ -1803776929;
					continue;
				case 44u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					Form4.smethod_13((Control)(object)button1, "button1");
					num = (int)((num2 * 1915515523) ^ 0x428380BA);
					continue;
				case 43u:
					num = ((int)num2 * -1691108713) ^ 0x7C2347EF;
					continue;
				case 42u:
					num = ((int)num2 * -1834592951) ^ 0x2BF29BA2;
					continue;
				case 41u:
					Form4.smethod_29((Form)(object)this, bool_0: false);
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1090253766) ^ 0x1578935A;
					continue;
				case 40u:
					button1 = Form4.smethod_8();
					errorProvider1 = Form4.smethod_9(components);
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -1348972686) ^ -2078125437;
					continue;
				case 38u:
					num = (int)((num2 * 154384963) ^ 0x53E25D12);
					continue;
				case 37u:
					num = (int)(num2 * 1623234441) ^ -65362410;
					continue;
				case 36u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = (int)((num2 * 1082369590) ^ 0x60BF6445);
					continue;
				case 35u:
					Form4.smethod_18(textBox2, bool_0: true);
					num = ((int)num2 * -1393312062) ^ 0x6C87B14B;
					continue;
				case 34u:
					num = (int)((num2 * 1963318898) ^ 0x20DE58D7);
					continue;
				case 33u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = (int)(num2 * 952610026) ^ -2017008420;
					continue;
				case 32u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -1225799678) ^ -1327650289;
					continue;
				case 31u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = (int)((num2 * 1452944001) ^ 0x754513CF);
					continue;
				case 30u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1574012072) ^ -272267016;
					continue;
				case 29u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = (int)(num2 * 959503171) ^ -884618841;
					continue;
				case 28u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = (int)(num2 * 1199840472) ^ -1451558735;
					continue;
				case 27u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1904600042) ^ -736791177;
					continue;
				case 26u:
					Form4.smethod_11((Control)(object)this);
					num = ((int)num2 * -784195455) ^ -620687664;
					continue;
				case 25u:
					Form4.smethod_18(textBox3, bool_0: true);
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -526601462) ^ 0x15748A9E;
					continue;
				case 24u:
					num = ((int)num2 * -518555043) ^ 0x565C04D;
					continue;
				case 22u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = (int)((num2 * 665603329) ^ 0xA718772);
					continue;
				case 21u:
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -477719147) ^ -895503205;
					continue;
				case 20u:
					num = ((int)num2 * -1291033125) ^ 0x6F3FDC9A;
					continue;
				case 19u:
					num = (int)(num2 * 951269424) ^ -549738310;
					continue;
				case 18u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1248220262) ^ -1942487374;
					continue;
				case 17u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					num = ((int)num2 * -475851266) ^ 0x1EF80087;
					continue;
				case 16u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 1985925540) ^ -1884359861;
					continue;
				case 15u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = (int)((num2 * 1564698069) ^ 0x529C034B);
					continue;
				case 14u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = ((int)num2 * -461930397) ^ -1432351209;
					continue;
				case 13u:
					num = ((int)num2 * -126654785) ^ -852399311;
					continue;
				case 12u:
					num = ((int)num2 * -1101805089) ^ -2020528694;
					continue;
				case 11u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 1553857862) ^ 0x4741326F);
					continue;
				case 10u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -1130245782) ^ 0x48E32741;
					continue;
				case 9u:
					num = (int)(num2 * 1339237467) ^ -1430418766;
					continue;
				case 8u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = (int)(num2 * 1753939111) ^ -1812631937;
					continue;
				case 7u:
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)(num2 * 1288199558) ^ -653997903;
					continue;
				case 6u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -392323696) ^ -396421246;
					continue;
				case 5u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = ((int)num2 * -670538491) ^ 0x4ACFBB83;
					continue;
				case 4u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = (int)(num2 * 128116368) ^ -1784706953;
					continue;
				case 3u:
					num = (int)(num2 * 369792590) ^ -1010431222;
					continue;
				case 2u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 528916154) ^ 0x6E631FF4);
					continue;
				case 1u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = (int)((num2 * 39437581) ^ 0x388E518D);
					continue;
				case 0u:
					num = (int)(num2 * 1261576857) ^ -993700554;
					continue;
				case 39u:
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
