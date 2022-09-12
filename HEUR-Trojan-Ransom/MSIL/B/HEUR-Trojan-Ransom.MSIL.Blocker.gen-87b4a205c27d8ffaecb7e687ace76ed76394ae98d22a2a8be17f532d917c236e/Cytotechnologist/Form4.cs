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
			int num = 1828050217;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD0B3FDCu) % 3u)
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
				num = ((int)num2 * -1466235467) ^ 0x6E7354EE;
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
			int num = -1254895441;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xED0E5E8Du) % 4u)
				{
				case 2u:
					Form4.smethod_3(e, bool_0: true);
					num = ((int)num2 * -1479499142) ^ 0x7D77FA10;
					continue;
				case 1u:
					num = (int)((num2 * 61819945) ^ 0x67704EF0);
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
		while (true)
		{
			int num = 583611423;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x4D06BA63u) % 8u)
				{
				case 7u:
					num = ((int)num2 * -1461531319) ^ 0x242FBAE9;
					continue;
				case 6u:
					num = (int)((num2 * 1228796701) ^ 0x72CFDDF7);
					continue;
				case 5u:
					Form4.smethod_5((IDisposable)components);
					num = ((int)num2 * -853413704) ^ -692011435;
					continue;
				case 4u:
					if (disposing)
					{
						num = (int)(num2 * 187735444) ^ -1031957728;
						continue;
					}
					goto IL_005f;
				case 3u:
					if (components != null)
					{
						num = 749213940;
						num3 = 749213940;
						continue;
					}
					goto IL_005f;
				case 2u:
					((Form)this).Dispose(disposing);
					num = 1202688274;
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
					IL_005f:
					num = 1873142081;
					num3 = 1873142081;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_066d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0677: Expected O, but got Unknown
		components = Form4.smethod_6();
		while (true)
		{
			int num = -1765138606;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB6A620C9u) % 55u)
				{
				case 54u:
					errorProvider1 = Form4.smethod_9(components);
					num = (int)(num2 * 870323394) ^ -1713252892;
					continue;
				case 53u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = (int)((num2 * 995091908) ^ 0x3E31BA2D);
					continue;
				case 52u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1735789721) ^ 0x1A6A2EF5;
					continue;
				case 51u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = ((int)num2 * -1238111861) ^ 0x26E112EE;
					continue;
				case 50u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = (int)(num2 * 816290737) ^ -2062679869;
					continue;
				case 49u:
					num = (int)((num2 * 324030899) ^ 0x48169C1B);
					continue;
				case 48u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = (int)(num2 * 716401309) ^ -1637167004;
					continue;
				case 47u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					Form4.smethod_31((Control)(object)this, "Form4");
					num = ((int)num2 * -512827057) ^ 0x1ACDBE07;
					continue;
				case 46u:
					num = (int)((num2 * 1965322507) ^ 0x4C911BBF);
					continue;
				case 45u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = ((int)num2 * -743032445) ^ 0x2A9A406D;
					continue;
				case 44u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = (int)((num2 * 867917947) ^ 0x458622D);
					continue;
				case 43u:
					num = ((int)num2 * -2090867284) ^ 0x1B3D0D1C;
					continue;
				case 42u:
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1358329848) ^ -1553589252;
					continue;
				case 40u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = ((int)num2 * -703859992) ^ -1992818233;
					continue;
				case 39u:
					Form4.smethod_18(textBox2, bool_0: true);
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -103845803) ^ -1081959166;
					continue;
				case 38u:
					num = (int)((num2 * 815211486) ^ 0x603E81AA);
					continue;
				case 37u:
					num = (int)((num2 * 2013039997) ^ 0x34F43078);
					continue;
				case 36u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1685845178) ^ -199867030;
					continue;
				case 35u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -823354149) ^ -1861591130;
					continue;
				case 34u:
					num = ((int)num2 * -92016887) ^ 0x53CA87B;
					continue;
				case 33u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)(num2 * 1491609827) ^ -1874285235;
					continue;
				case 32u:
					textBox2 = Form4.smethod_7();
					textBox3 = Form4.smethod_7();
					button1 = Form4.smethod_8();
					num = ((int)num2 * -1096897210) ^ -1379318449;
					continue;
				case 31u:
					Form4.smethod_37((Control)(object)this);
					num = (int)((num2 * 1418083576) ^ 0x3D0452F3);
					continue;
				case 30u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = (int)(num2 * 680963427) ^ -443423801;
					continue;
				case 29u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = ((int)num2 * -1753485938) ^ -1254708959;
					continue;
				case 28u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1782347687) ^ -1939160920;
					continue;
				case 27u:
					Form4.smethod_15((Control)(object)button1, 0);
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = ((int)num2 * -152523323) ^ 0x36718284;
					continue;
				case 26u:
					num = ((int)num2 * -528478931) ^ -2083758203;
					continue;
				case 24u:
					num = ((int)num2 * -584371624) ^ 0x4E8129D4;
					continue;
				case 23u:
					num = (int)((num2 * 627841335) ^ 0xEDE2BBB);
					continue;
				case 22u:
					num = ((int)num2 * -473155730) ^ -53523774;
					continue;
				case 21u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = ((int)num2 * -888568042) ^ -1059790638;
					continue;
				case 20u:
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = (int)(num2 * 1462924358) ^ -1141408998;
					continue;
				case 19u:
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1633350648) ^ 0x129E0F75;
					continue;
				case 18u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1705109899) ^ -531697275;
					continue;
				case 17u:
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					Form4.smethod_11((Control)(object)this);
					num = (int)(num2 * 306807677) ^ -1694792702;
					continue;
				case 16u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					Form4.smethod_18(textBox3, bool_0: true);
					num = (int)(num2 * 255325189) ^ -1335129468;
					continue;
				case 15u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = (int)((num2 * 1903895166) ^ 0x4570FC65);
					continue;
				case 14u:
					num = ((int)num2 * -1654976597) ^ 0x5373ACA2;
					continue;
				case 13u:
					textBox1 = Form4.smethod_7();
					num = (int)(num2 * 1656679092) ^ -495720637;
					continue;
				case 12u:
					num = (int)(num2 * 2014309639) ^ -1493745736;
					continue;
				case 11u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = ((int)num2 * -214647597) ^ -1453528079;
					continue;
				case 10u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -1180976658) ^ -432158371;
					continue;
				case 9u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 778177627) ^ 0x7D4A3C25);
					continue;
				case 8u:
					num = (int)(num2 * 588532480) ^ -89504103;
					continue;
				case 7u:
					num = (int)(num2 * 1010626104) ^ -449794320;
					continue;
				case 6u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = (int)((num2 * 1302236034) ^ 0x28C4F856);
					continue;
				case 5u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = (int)(num2 * 1362365066) ^ -1442660223;
					continue;
				case 4u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1919232227) ^ 0x30902AD7;
					continue;
				case 3u:
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)(num2 * 1285306341) ^ -958757741;
					continue;
				case 2u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 431363065) ^ -1966612063;
					continue;
				case 1u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = ((int)num2 * -1955117182) ^ -38623171;
					continue;
				case 0u:
					num = ((int)num2 * -2093689846) ^ 0x1C349F7;
					continue;
				default:
					return;
				case 25u:
					break;
				case 41u:
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
