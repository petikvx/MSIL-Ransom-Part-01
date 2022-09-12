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
			int num = -1044241936;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x86E2B089u) % 4u)
				{
				case 2u:
					InitializeComponent();
					num = ((int)num2 * -228979687) ^ 0x47785DB4;
					continue;
				case 1u:
					num = ((int)num2 * -1510057821) ^ 0x6D457A3C;
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

	private void Form4_FormClosing(object sender, FormClosingEventArgs e)
	{
		Form4.smethod_1((Control)(object)Form4.smethod_0((Form)(object)this), bool_0: true);
	}

	private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -561728747;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x879A162Eu) % 6u)
				{
				case 4u:
					num = ((int)num2 * -1113000892) ^ 0x134FC9F1;
					continue;
				case 3u:
					Form4.smethod_3(e, bool_0: true);
					num = (int)(num2 * 1850733896) ^ -519599712;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1406970169;
						num4 = 1406970169;
					}
					else
					{
						num3 = 365240993;
						num4 = 365240993;
					}
					num = num3 ^ ((int)num2 * -1505896498);
					continue;
				}
				case 1u:
					flag = Form4.smethod_2(e) == ' ';
					num = ((int)num2 * -897574228) ^ -982407438;
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
			goto IL_004b;
		}
		int num = 0;
		goto IL_00c6;
		IL_00bd:
		num = ((components != null) ? 1 : 0);
		goto IL_00c6;
		IL_004b:
		int num2 = -828921845;
		goto IL_0087;
		IL_0087:
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xDAE15B17u) % 9u)
			{
			case 7u:
				num2 = (int)(num3 * 1987715123) ^ -441505428;
				continue;
			case 6u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 529981149;
					num5 = 529981149;
				}
				else
				{
					num4 = 247981490;
					num5 = 247981490;
				}
				num2 = num4 ^ (int)(num3 * 262805061);
				continue;
			}
			case 5u:
				num2 = ((int)num3 * -331841652) ^ -2084915623;
				continue;
			case 4u:
				break;
			case 3u:
				((Form)this).Dispose(disposing);
				num2 = -699460558;
				continue;
			case 2u:
				Form4.smethod_5((IDisposable)components);
				num2 = ((int)num3 * -1075934577) ^ -2069666108;
				continue;
			case 0u:
				num2 = ((int)num3 * -1621841844) ^ -1572750625;
				continue;
			default:
				return;
			case 1u:
				goto IL_00bd;
			case 8u:
				return;
			}
			break;
		}
		goto IL_004b;
		IL_00c6:
		flag = (byte)num != 0;
		num2 = -1932731323;
		goto IL_0087;
	}

	private void InitializeComponent()
	{
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		//IL_064c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0656: Expected O, but got Unknown
		//IL_0670: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Expected O, but got Unknown
		while (true)
		{
			int num = -1697241359;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB3CE54E5u) % 60u)
				{
				case 59u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1146372971) ^ -1616254422;
					continue;
				case 58u:
					num = (int)((num2 * 478526206) ^ 0x60536CDE);
					continue;
				case 57u:
					num = (int)(num2 * 287271248) ^ -115145076;
					continue;
				case 56u:
					Form4.smethod_37((Control)(object)this);
					num = ((int)num2 * -1180944951) ^ -1314578276;
					continue;
				case 55u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = ((int)num2 * -686432014) ^ 0x3C121501;
					continue;
				case 54u:
					button1 = Form4.smethod_8();
					errorProvider1 = Form4.smethod_9(components);
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					Form4.smethod_11((Control)(object)this);
					num = (int)(num2 * 1704639871) ^ -693523026;
					continue;
				case 53u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = ((int)num2 * -536645780) ^ -1081504027;
					continue;
				case 52u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -698255515) ^ 0x8761515;
					continue;
				case 51u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = (int)((num2 * 460176324) ^ 0x74047693);
					continue;
				case 50u:
					num = (int)(num2 * 1111562919) ^ -1649455521;
					continue;
				case 48u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					num = (int)(num2 * 1489143580) ^ -1220193456;
					continue;
				case 47u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -841289284) ^ -39387054;
					continue;
				case 46u:
					Form4.smethod_18(textBox2, bool_0: true);
					num = (int)((num2 * 1893875152) ^ 0x5C00858B);
					continue;
				case 45u:
					num = ((int)num2 * -1028385556) ^ 0x1B4CAA4A;
					continue;
				case 44u:
					num = ((int)num2 * -965448525) ^ -1421620540;
					continue;
				case 43u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = ((int)num2 * -339886449) ^ 0x484E383A;
					continue;
				case 42u:
					num = (int)((num2 * 509010767) ^ 0x4F8CE0E3);
					continue;
				case 41u:
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = (int)((num2 * 2667316) ^ 0x29ECC50);
					continue;
				case 40u:
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)(num2 * 2146460240) ^ -500584395;
					continue;
				case 39u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = (int)((num2 * 871691676) ^ 0x2E04DBAC);
					continue;
				case 38u:
					num = ((int)num2 * -577261593) ^ 0x5071369D;
					continue;
				case 37u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = ((int)num2 * -28094056) ^ 0x20B1A5C3;
					continue;
				case 36u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1595785427) ^ -925998515;
					continue;
				case 35u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -2023876502) ^ 0x726A48A4;
					continue;
				case 34u:
					textBox2 = Form4.smethod_7();
					num = ((int)num2 * -1645273921) ^ -641610312;
					continue;
				case 33u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -1027348889) ^ 0x330C24D5;
					continue;
				case 32u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1322911288) ^ 0x106F6F51;
					continue;
				case 31u:
					num = (int)((num2 * 1400678009) ^ 0x34EFB8B7);
					continue;
				case 30u:
					Form4.smethod_31((Control)(object)this, "Form4");
					num = ((int)num2 * -453512587) ^ 0x781B670E;
					continue;
				case 29u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -533839365) ^ 0x4B711C16;
					continue;
				case 28u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1516290973) ^ -1640577306;
					continue;
				case 27u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1267778318) ^ -831905952;
					continue;
				case 26u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = ((int)num2 * -1505552305) ^ 0x6C71ED5D;
					continue;
				case 25u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = ((int)num2 * -1725994640) ^ -1402992304;
					continue;
				case 24u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 224894202) ^ -1235669795;
					continue;
				case 23u:
					num = (int)((num2 * 1778045120) ^ 0x728A883F);
					continue;
				case 22u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 822432712) ^ 0x558DDB6F);
					continue;
				case 21u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = ((int)num2 * -1309701526) ^ 0x45E75FAB;
					continue;
				case 20u:
					num = (int)(num2 * 701051433) ^ -166712616;
					continue;
				case 19u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = (int)(num2 * 2084541904) ^ -310325358;
					continue;
				case 18u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = ((int)num2 * -1477340930) ^ 0x67E2A32B;
					continue;
				case 17u:
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = ((int)num2 * -1428766394) ^ 0x4270DBF;
					continue;
				case 16u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = ((int)num2 * -938669987) ^ 0x5E7CFDDC;
					continue;
				case 15u:
					textBox3 = Form4.smethod_7();
					num = ((int)num2 * -741522826) ^ 0x1077DBCD;
					continue;
				case 14u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = (int)((num2 * 765689128) ^ 0x4E7DC773);
					continue;
				case 13u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = (int)(num2 * 1440803649) ^ -1239762781;
					continue;
				case 12u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -249656462) ^ 0x49E0BF5A;
					continue;
				case 11u:
					num = ((int)num2 * -2048579351) ^ 0x48A3DC3E;
					continue;
				case 10u:
					num = (int)(num2 * 85217461) ^ -1166045431;
					continue;
				case 9u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = (int)(num2 * 11745750) ^ -2011175491;
					continue;
				case 8u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -163549828) ^ -1375424130;
					continue;
				case 7u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = (int)((num2 * 1693045464) ^ 0x658774C9);
					continue;
				case 6u:
					num = ((int)num2 * -1393813974) ^ 0x75BCE81E;
					continue;
				case 5u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = (int)(num2 * 460506124) ^ -24085030;
					continue;
				case 4u:
					components = Form4.smethod_6();
					num = (int)((num2 * 364078460) ^ 0x6D741A7E);
					continue;
				case 3u:
					textBox1 = Form4.smethod_7();
					num = (int)(num2 * 2059686913) ^ -194758512;
					continue;
				case 2u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = (int)(num2 * 1985072746) ^ -1422562444;
					continue;
				case 0u:
					Form4.smethod_18(textBox3, bool_0: true);
					num = ((int)num2 * -988714581) ^ 0x8ED23BC;
					continue;
				default:
					return;
				case 49u:
					break;
				case 1u:
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
