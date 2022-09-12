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
			int num = -319774849;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA6B0B4A1u) % 4u)
				{
				case 3u:
					InitializeComponent();
					num = ((int)num2 * -655879697) ^ -1381061115;
					continue;
				case 2u:
					num = ((int)num2 * -988802433) ^ 0x1A51BC84;
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
		bool flag = default(bool);
		while (true)
		{
			int num = 1969686372;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x60E66CEDu) % 6u)
				{
				case 5u:
					num = ((int)num2 * -2091722982) ^ 0xB57CA25;
					continue;
				case 4u:
					Form4.smethod_3(e, bool_0: true);
					num = (int)(num2 * 1588784079) ^ -575804642;
					continue;
				case 1u:
					flag = Form4.smethod_2(e) == ' ';
					num = ((int)num2 * -276022369) ^ -250860654;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -80697399;
						num4 = -80697399;
					}
					else
					{
						num3 = -802876645;
						num4 = -802876645;
					}
					num = num3 ^ ((int)num2 * -208276899);
					continue;
				}
				default:
					return;
				case 3u:
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
			int num = -268723216;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDEBB7F58u) % 3u)
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
				num = ((int)num2 * -1375813397) ^ -2027319959;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_006b;
		}
		goto IL_00ac;
		IL_006b:
		int num = 1796172260;
		goto IL_0070;
		IL_0070:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x3F859373u) % 8u)
			{
			case 6u:
				((Form)this).Dispose(disposing);
				num = 526891087;
				continue;
			case 5u:
				Form4.smethod_5((IDisposable)components);
				num = ((int)num2 * -672074236) ^ 0x198AA415;
				continue;
			case 3u:
				num = (int)((num2 * 987819027) ^ 0x5D988247);
				continue;
			case 2u:
				num = (int)((num2 * 1100655928) ^ 0x2BF9452);
				continue;
			case 1u:
				num = ((int)num2 * -769764337) ^ -117932574;
				continue;
			case 0u:
				break;
			default:
				return;
			case 7u:
				goto IL_00a1;
			case 4u:
				return;
			}
			break;
			IL_00a1:
			if (components != null)
			{
				num = 1515619552;
				num3 = 1515619552;
				continue;
			}
			goto IL_00ac;
		}
		goto IL_006b;
		IL_00ac:
		num = 1988885469;
		num3 = 1988885469;
		goto IL_0070;
	}

	private void InitializeComponent()
	{
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected O, but got Unknown
		//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Expected O, but got Unknown
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b7: Expected O, but got Unknown
		while (true)
		{
			int num = -72046233;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB21D74EBu) % 55u)
				{
				case 54u:
					num = ((int)num2 * -1755330937) ^ 0x1A2B1A63;
					continue;
				case 53u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)((num2 * 15927420) ^ 0x76A9696C);
					continue;
				case 52u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = ((int)num2 * -798821038) ^ 0x55E86464;
					continue;
				case 51u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = ((int)num2 * -275367677) ^ -1605748343;
					continue;
				case 50u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 305493443) ^ -626579448;
					continue;
				case 49u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = (int)((num2 * 858990687) ^ 0x7791780A);
					continue;
				case 48u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = (int)((num2 * 1025678028) ^ 0x2BFD5A8E);
					continue;
				case 47u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = (int)((num2 * 2091497602) ^ 0x4CEA87CB);
					continue;
				case 46u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = (int)((num2 * 1612112458) ^ 0x1D20E934);
					continue;
				case 45u:
					num = ((int)num2 * -751765959) ^ -1194795085;
					continue;
				case 44u:
					num = ((int)num2 * -544770106) ^ 0x348CBB0D;
					continue;
				case 43u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = (int)(num2 * 1488278514) ^ -594369072;
					continue;
				case 42u:
					num = (int)((num2 * 1271161904) ^ 0x3528C459);
					continue;
				case 41u:
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					num = (int)((num2 * 2044463794) ^ 0x355D36A2);
					continue;
				case 40u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1328881988) ^ -1191196550;
					continue;
				case 38u:
					components = Form4.smethod_6();
					textBox1 = Form4.smethod_7();
					textBox2 = Form4.smethod_7();
					textBox3 = Form4.smethod_7();
					button1 = Form4.smethod_8();
					num = ((int)num2 * -1719483324) ^ 0x83983B3;
					continue;
				case 37u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = (int)((num2 * 1221190395) ^ 0x43AD33CA);
					continue;
				case 36u:
					num = ((int)num2 * -1179355758) ^ -1728062911;
					continue;
				case 35u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					Form4.smethod_31((Control)(object)this, "Form4");
					num = (int)(num2 * 324020875) ^ -284271669;
					continue;
				case 34u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = (int)(num2 * 219285699) ^ -1573519350;
					continue;
				case 33u:
					Form4.smethod_18(textBox3, bool_0: true);
					num = ((int)num2 * -882092189) ^ -1861518079;
					continue;
				case 32u:
					num = (int)((num2 * 987723761) ^ 0x373AAA26);
					continue;
				case 31u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = ((int)num2 * -920831624) ^ 0x5A8AE496;
					continue;
				case 30u:
					num = (int)((num2 * 1943261920) ^ 0x327BEED1);
					continue;
				case 29u:
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -721289574) ^ -2074568312;
					continue;
				case 28u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = ((int)num2 * -1609416463) ^ -438051372;
					continue;
				case 27u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -182799799) ^ 0x4D5E54E2;
					continue;
				case 26u:
					num = ((int)num2 * -1209271583) ^ 0x5A7BF3C4;
					continue;
				case 25u:
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 373645292) ^ -1909882955;
					continue;
				case 24u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 1078364127) ^ 0x124FB285);
					continue;
				case 23u:
					errorProvider1 = Form4.smethod_9(components);
					num = ((int)num2 * -454253729) ^ -2056722119;
					continue;
				case 22u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = ((int)num2 * -290047490) ^ 0x627C0820;
					continue;
				case 21u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = (int)(num2 * 584051647) ^ -246915064;
					continue;
				case 20u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = (int)((num2 * 728523460) ^ 0x31887AF9);
					continue;
				case 19u:
					num = (int)((num2 * 1582449710) ^ 0x17F13400);
					continue;
				case 18u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = (int)((num2 * 392463405) ^ 0x5924B800);
					continue;
				case 17u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = ((int)num2 * -666044296) ^ 0x5B8441B5;
					continue;
				case 16u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					num = (int)((num2 * 277686359) ^ 0x4DFBAEE8);
					continue;
				case 15u:
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = ((int)num2 * -956268667) ^ -400477274;
					continue;
				case 14u:
					Form4.smethod_37((Control)(object)this);
					num = ((int)num2 * -1515271434) ^ 0x4166ABA0;
					continue;
				case 13u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = ((int)num2 * -634709596) ^ 0x3843BE53;
					continue;
				case 12u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1177481071) ^ 0x259DFB1;
					continue;
				case 10u:
					num = (int)((num2 * 1733982808) ^ 0x138EA64E);
					continue;
				case 9u:
					num = ((int)num2 * -1224471424) ^ 0x19758A0B;
					continue;
				case 8u:
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = ((int)num2 * -179245520) ^ 0xCB962FC;
					continue;
				case 7u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = ((int)num2 * -1358319388) ^ 0x5CB58DA6;
					continue;
				case 6u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)(num2 * 1007741509) ^ -635906323;
					continue;
				case 5u:
					num = (int)((num2 * 1744227637) ^ 0x5A1EF107);
					continue;
				case 4u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -213181172) ^ -686577670;
					continue;
				case 3u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					Form4.smethod_18(textBox2, bool_0: true);
					num = (int)(num2 * 1311816082) ^ -2005768640;
					continue;
				case 2u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = (int)(num2 * 638099486) ^ -1500249280;
					continue;
				case 1u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)((num2 * 216830465) ^ 0x56583859);
					continue;
				case 0u:
					Form4.smethod_11((Control)(object)this);
					num = ((int)num2 * -1731078869) ^ -335956404;
					continue;
				default:
					return;
				case 39u:
					break;
				case 11u:
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
