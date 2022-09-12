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
			int num = -2050049089;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF76A899Eu) % 5u)
				{
				case 4u:
					num = (int)((num2 * 2111868643) ^ 0x5A5E6A04);
					continue;
				case 2u:
					InitializeComponent();
					num = (int)(num2 * 1177773421) ^ -1030554115;
					continue;
				case 1u:
					num = (int)(num2 * 884007862) ^ -763453207;
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

	private void Form4_FormClosing(object sender, FormClosingEventArgs e)
	{
		Form4.smethod_1((Control)(object)Form4.smethod_0((Form)(object)this), bool_0: true);
		while (true)
		{
			int num = 766059154;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7AB85B3Bu) % 3u)
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
				num = ((int)num2 * -1209549171) ^ -1917762278;
			}
		}
	}

	private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		while (true)
		{
			int num = -1227251658;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBA8624F0u) % 5u)
				{
				case 3u:
					num = ((int)num2 * -549087208) ^ -2012553765;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (Form4.smethod_2(e) == ' ')
					{
						num3 = 1584903310;
						num4 = 1584903310;
					}
					else
					{
						num3 = 370283811;
						num4 = 370283811;
					}
					num = num3 ^ ((int)num2 * -95910892);
					continue;
				}
				case 1u:
					Form4.smethod_3(e, bool_0: true);
					num = (int)(num2 * 1112281156) ^ -1160833992;
					continue;
				default:
					return;
				case 4u:
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
		bool flag = default(bool);
		while (true)
		{
			int num = 478554889;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x79E01D46u) % 10u)
				{
				case 9u:
					num3 = ((components != null) ? 1 : 0);
					goto IL_000f;
				case 8u:
					((Form)this).Dispose(disposing);
					num = 624665472;
					continue;
				case 7u:
					Form4.smethod_5((IDisposable)components);
					num = ((int)num2 * -871310523) ^ -1956281509;
					continue;
				case 6u:
					num = (int)(num2 * 88297973) ^ -598963718;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1581087590;
						num5 = 1581087590;
					}
					else
					{
						num4 = 2012381966;
						num5 = 2012381966;
					}
					num = num4 ^ ((int)num2 * -1645243842);
					continue;
				}
				case 4u:
					num = (int)((num2 * 1000141353) ^ 0x5EE0274E);
					continue;
				case 2u:
					num = (int)(num2 * 2044805730) ^ -1137032575;
					continue;
				case 1u:
					if (disposing)
					{
						num = (int)(num2 * 404180564) ^ -1576539341;
						continue;
					}
					num3 = 0;
					goto IL_000f;
				default:
					return;
				case 3u:
					break;
				case 0u:
					return;
					IL_000f:
					flag = (byte)num3 != 0;
					num = 2097758907;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected O, but got Unknown
		while (true)
		{
			int num = 1489357379;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x58610693u) % 65u)
				{
				case 64u:
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -1299548621) ^ -1559851470;
					continue;
				case 63u:
					num = (int)((num2 * 44238213) ^ 0x7F53F89);
					continue;
				case 62u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = ((int)num2 * -444321218) ^ -1333523583;
					continue;
				case 61u:
					textBox3 = Form4.smethod_7();
					num = (int)((num2 * 57936697) ^ 0x7946C780);
					continue;
				case 60u:
					num = ((int)num2 * -1030547054) ^ 0x35A452DC;
					continue;
				case 59u:
					Form4.smethod_11((Control)(object)this);
					num = ((int)num2 * -652818277) ^ 0x364BCFC8;
					continue;
				case 58u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 98541907) ^ -1847660956;
					continue;
				case 57u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -1537392252) ^ 0x77C24512;
					continue;
				case 56u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1622697217) ^ -1629526222;
					continue;
				case 55u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -160234909) ^ 0x65D94F2D;
					continue;
				case 54u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = ((int)num2 * -465272238) ^ -1878138893;
					continue;
				case 53u:
					num = ((int)num2 * -1877773508) ^ -2110376869;
					continue;
				case 52u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -2142412684) ^ -2025544435;
					continue;
				case 51u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 1160804741) ^ -2116739611;
					continue;
				case 50u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = (int)(num2 * 1981321696) ^ -1533842866;
					continue;
				case 49u:
					num = ((int)num2 * -895629650) ^ 0x23B152CF;
					continue;
				case 48u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					Form4.smethod_18(textBox3, bool_0: true);
					num = (int)(num2 * 333429258) ^ -1926258546;
					continue;
				case 47u:
					num = ((int)num2 * -1689144611) ^ 0x40F6ACB2;
					continue;
				case 46u:
					num = (int)(num2 * 852651199) ^ -84976814;
					continue;
				case 45u:
					num = (int)(num2 * 1761311273) ^ -1610293770;
					continue;
				case 44u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = ((int)num2 * -1758264930) ^ 0xFB3E83B;
					continue;
				case 42u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = (int)((num2 * 1099738669) ^ 0x3D3FACA3);
					continue;
				case 41u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 1212317426) ^ 0x384D3C22);
					continue;
				case 40u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					Form4.smethod_13((Control)(object)button1, "button1");
					num = ((int)num2 * -1466620238) ^ -174428637;
					continue;
				case 39u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = ((int)num2 * -32410328) ^ 0x4E9276DF;
					continue;
				case 37u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -425353636) ^ 0x331B3DFA;
					continue;
				case 36u:
					num = (int)(num2 * 1590047989) ^ -926911004;
					continue;
				case 35u:
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -619789459) ^ 0x20D2FADF;
					continue;
				case 34u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = (int)((num2 * 1736296521) ^ 0x275D306B);
					continue;
				case 33u:
					textBox2 = Form4.smethod_7();
					num = ((int)num2 * -1019870923) ^ 0x16D4F608;
					continue;
				case 32u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1648804422) ^ -1649797126;
					continue;
				case 31u:
					num = ((int)num2 * -1267298892) ^ 0x2EB34F15;
					continue;
				case 30u:
					num = (int)(num2 * 32738794) ^ -723725548;
					continue;
				case 29u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = ((int)num2 * -796063590) ^ 0x38706FBE;
					continue;
				case 28u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = (int)((num2 * 50692610) ^ 0x3B477447);
					continue;
				case 27u:
					num = (int)((num2 * 1591428137) ^ 0x76598983);
					continue;
				case 26u:
					Form4.smethod_31((Control)(object)this, "Form4");
					num = ((int)num2 * -680203654) ^ 0x10143763;
					continue;
				case 25u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					Form4.smethod_18(textBox2, bool_0: true);
					num = ((int)num2 * -1441331872) ^ -1216640368;
					continue;
				case 24u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1655847191) ^ 0x76081D1A;
					continue;
				case 23u:
					num = (int)((num2 * 82775968) ^ 0x51BFF029);
					continue;
				case 22u:
					num = (int)((num2 * 1113155556) ^ 0xDC170C8);
					continue;
				case 21u:
					textBox1 = Form4.smethod_7();
					num = ((int)num2 * -1616540679) ^ -405514698;
					continue;
				case 20u:
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 1975907295) ^ -1225055791;
					continue;
				case 19u:
					num = ((int)num2 * -1377512570) ^ -165862805;
					continue;
				case 18u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1138167053) ^ -981021440;
					continue;
				case 17u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = ((int)num2 * -853374017) ^ -1062642331;
					continue;
				case 16u:
					num = ((int)num2 * -52994171) ^ 0xA1596D8;
					continue;
				case 15u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = (int)(num2 * 277620933) ^ -1119366474;
					continue;
				case 14u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					num = (int)((num2 * 276152446) ^ 0x747AE1EA);
					continue;
				case 13u:
					Form4.smethod_37((Control)(object)this);
					num = ((int)num2 * -374946435) ^ -761177094;
					continue;
				case 12u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					num = ((int)num2 * -1292474725) ^ -1030203613;
					continue;
				case 11u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = ((int)num2 * -11166327) ^ -460769249;
					continue;
				case 10u:
					num = ((int)num2 * -319474888) ^ -657112956;
					continue;
				case 9u:
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = ((int)num2 * -1363780015) ^ -1750469104;
					continue;
				case 8u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1402839424) ^ 0x2AFA59E7;
					continue;
				case 7u:
					button1 = Form4.smethod_8();
					num = (int)(num2 * 251862557) ^ -1266096054;
					continue;
				case 6u:
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = (int)(num2 * 738892476) ^ -1135818620;
					continue;
				case 5u:
					errorProvider1 = Form4.smethod_9(components);
					num = (int)((num2 * 841797706) ^ 0x6229F19A);
					continue;
				case 4u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = (int)(num2 * 1762796865) ^ -1693606044;
					continue;
				case 3u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1301023382) ^ -1795677670;
					continue;
				case 2u:
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = (int)((num2 * 710226167) ^ 0x3F10E24);
					continue;
				case 1u:
					components = Form4.smethod_6();
					num = (int)(num2 * 396507702) ^ -2104179615;
					continue;
				case 0u:
					num = (int)(num2 * 285632845) ^ -533537398;
					continue;
				default:
					return;
				case 38u:
					break;
				case 43u:
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
