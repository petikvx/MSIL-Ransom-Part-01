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
			int num = -2147021653;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9FB82DA0u) % 6u)
				{
				case 5u:
					flag = Form4.smethod_2(e) == ' ';
					num = ((int)num2 * -1729516925) ^ 0x656DF234;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1744374676;
						num4 = -1744374676;
					}
					else
					{
						num3 = -1642220277;
						num4 = -1642220277;
					}
					num = num3 ^ (int)(num2 * 1991421341);
					continue;
				}
				case 2u:
					num = (int)((num2 * 290799965) ^ 0x36A0114);
					continue;
				case 1u:
					Form4.smethod_3(e, bool_0: true);
					num = ((int)num2 * -1773308779) ^ -511341753;
					continue;
				default:
					return;
				case 0u:
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
		bool flag = default(bool);
		while (true)
		{
			int num = 115232132;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x7565993Fu) % 8u)
				{
				case 7u:
					Form4.smethod_5((IDisposable)components);
					num = (int)(num2 * 962543733) ^ -1957217495;
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1145589646;
						num5 = 1145589646;
					}
					else
					{
						num4 = 1017331979;
						num5 = 1017331979;
					}
					num = num4 ^ (int)(num2 * 962763569);
					continue;
				}
				case 5u:
					num = ((int)num2 * -1746734115) ^ 0x71DCEE0A;
					continue;
				case 4u:
					num = ((int)num2 * -1112857572) ^ 0x3E319845;
					continue;
				case 3u:
					if (disposing)
					{
						num = (int)(num2 * 1703759231) ^ -1003799237;
						continue;
					}
					num3 = 0;
					goto IL_0075;
				case 1u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_0075;
				case 0u:
					break;
				default:
					{
						((Form)this).Dispose(disposing);
						return;
					}
					IL_0075:
					flag = (byte)num3 != 0;
					num = 478268097;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected O, but got Unknown
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected O, but got Unknown
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected O, but got Unknown
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Expected O, but got Unknown
		components = Form4.smethod_6();
		while (true)
		{
			int num = -2027672198;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDFAB9753u) % 63u)
				{
				case 62u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = (int)((num2 * 36821790) ^ 0x3FADDDD8);
					continue;
				case 61u:
					num = (int)((num2 * 1702286176) ^ 0x552AB6FD);
					continue;
				case 60u:
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = (int)((num2 * 1284903699) ^ 0x128B632D);
					continue;
				case 59u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = (int)(num2 * 614474961) ^ -302632109;
					continue;
				case 57u:
					Form4.smethod_18(textBox2, bool_0: true);
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1992012306) ^ 0x436E8A23;
					continue;
				case 56u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					num = (int)(num2 * 340245077) ^ -500736493;
					continue;
				case 55u:
					num = (int)(num2 * 662520177) ^ -766980447;
					continue;
				case 54u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					Form4.smethod_19((Control)(object)this, "Регистрация");
					num = (int)(num2 * 1973031811) ^ -83850403;
					continue;
				case 53u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = (int)((num2 * 402962028) ^ 0x4C6F4C50);
					continue;
				case 52u:
					num = ((int)num2 * -336881472) ^ -1419706981;
					continue;
				case 51u:
					num = ((int)num2 * -1457917996) ^ 0x212CDFB2;
					continue;
				case 50u:
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = (int)(num2 * 763272394) ^ -1492645356;
					continue;
				case 49u:
					num = (int)(num2 * 1890352615) ^ -61757970;
					continue;
				case 48u:
					num = ((int)num2 * -683870965) ^ 0x40F8C88;
					continue;
				case 47u:
					num = ((int)num2 * -1768753370) ^ 0x38BE7777;
					continue;
				case 46u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1283888768) ^ -794884264;
					continue;
				case 45u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -632435510) ^ -1325946512;
					continue;
				case 44u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 1910115486) ^ 0x24D42A8);
					continue;
				case 43u:
					num = (int)(num2 * 1865294599) ^ -105321039;
					continue;
				case 42u:
					num = ((int)num2 * -1078652743) ^ -740195551;
					continue;
				case 41u:
					errorProvider1 = Form4.smethod_9(components);
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -1975236647) ^ 0x6F18654E;
					continue;
				case 40u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = (int)((num2 * 164665963) ^ 0x1B535860);
					continue;
				case 39u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = ((int)num2 * -204134837) ^ -270488423;
					continue;
				case 38u:
					num = ((int)num2 * -862251419) ^ -1976875110;
					continue;
				case 37u:
					num = ((int)num2 * -666738598) ^ -1197145452;
					continue;
				case 36u:
					num = ((int)num2 * -567966808) ^ 0x66F3B22C;
					continue;
				case 35u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = (int)(num2 * 205585273) ^ -2132662470;
					continue;
				case 34u:
					Form4.smethod_11((Control)(object)this);
					num = (int)((num2 * 281548295) ^ 0x2C7886EF);
					continue;
				case 33u:
					num = (int)((num2 * 157183737) ^ 0x317126D4);
					continue;
				case 32u:
					Form4.smethod_18(textBox3, bool_0: true);
					num = (int)(num2 * 237788795) ^ -1026557243;
					continue;
				case 31u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = (int)(num2 * 947117475) ^ -1271621197;
					continue;
				case 30u:
					num = (int)((num2 * 1720904524) ^ 0x26B2C522);
					continue;
				case 29u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = (int)(num2 * 1110189346) ^ -476546848;
					continue;
				case 28u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -457274645) ^ -1265540807;
					continue;
				case 26u:
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1460507219) ^ -336535005;
					continue;
				case 25u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = (int)(num2 * 1652695068) ^ -337015412;
					continue;
				case 24u:
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = ((int)num2 * -471778256) ^ 0x2666D3CE;
					continue;
				case 23u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 1052903863) ^ -1149354834;
					continue;
				case 22u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					Form4.smethod_31((Control)(object)this, "Form4");
					num = ((int)num2 * -338437173) ^ 0x5E1CB59;
					continue;
				case 21u:
					Form4.smethod_13((Control)(object)button1, "button1");
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = ((int)num2 * -942785127) ^ -997591506;
					continue;
				case 20u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)(num2 * 430390538) ^ -1665938385;
					continue;
				case 19u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -1336663516) ^ 0x44A55A8A;
					continue;
				case 18u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -1355228175) ^ -1939673676;
					continue;
				case 17u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = (int)(num2 * 1941615387) ^ -1666223952;
					continue;
				case 16u:
					Form4.smethod_37((Control)(object)this);
					num = (int)((num2 * 1405251596) ^ 0x7D71E509);
					continue;
				case 15u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = (int)(num2 * 1642289632) ^ -1115665004;
					continue;
				case 14u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 250284195) ^ -1069920292;
					continue;
				case 13u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = (int)(num2 * 1554280248) ^ -820455466;
					continue;
				case 12u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -838489984) ^ -913700859;
					continue;
				case 11u:
					textBox1 = Form4.smethod_7();
					num = (int)(num2 * 651973776) ^ -2071465450;
					continue;
				case 10u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = (int)(num2 * 1950080355) ^ -1462749723;
					continue;
				case 9u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = (int)(num2 * 973595430) ^ -669061246;
					continue;
				case 8u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = ((int)num2 * -666087353) ^ 0x7606C380;
					continue;
				case 7u:
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)((num2 * 929824218) ^ 0x24C79D95);
					continue;
				case 6u:
					textBox2 = Form4.smethod_7();
					textBox3 = Form4.smethod_7();
					button1 = Form4.smethod_8();
					num = (int)(num2 * 264913679) ^ -1232457502;
					continue;
				case 5u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = (int)(num2 * 1830224278) ^ -1715606512;
					continue;
				case 4u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1012663488) ^ 0x2619A75;
					continue;
				case 3u:
					num = ((int)num2 * -1583606917) ^ 0x3DF1718D;
					continue;
				case 2u:
					num = (int)((num2 * 1501567771) ^ 0x3CB6C35B);
					continue;
				case 1u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = (int)(num2 * 2059824074) ^ -2055492413;
					continue;
				case 0u:
					num = ((int)num2 * -1456616929) ^ -827765052;
					continue;
				default:
					return;
				case 27u:
					break;
				case 58u:
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
