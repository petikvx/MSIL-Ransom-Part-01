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
		bool flag = Form4.smethod_2(e) == ' ';
		while (true)
		{
			int num = -1695887390;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFE6F23BFu) % 4u)
				{
				case 2u:
					Form4.smethod_3(e, bool_0: true);
					num = (int)((num2 * 1084144273) ^ 0x73502A69);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 506420086;
						num4 = 506420086;
					}
					else
					{
						num3 = 91274624;
						num4 = 91274624;
					}
					num = num3 ^ (int)(num2 * 2089003655);
					continue;
				}
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
		while (true)
		{
			int num = -122231027;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9C1DC733u) % 3u)
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
				num = ((int)num2 * -88633240) ^ 0x6CE21726;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_0009;
		}
		int num = 0;
		goto IL_00c6;
		IL_00c6:
		bool flag = (byte)num != 0;
		int num2 = -165037052;
		goto IL_0087;
		IL_0009:
		num2 = -1977435889;
		goto IL_0087;
		IL_0087:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xBBE12750u) % 9u)
			{
			case 6u:
				break;
			case 5u:
				((Form)this).Dispose(disposing);
				num2 = -1085711210;
				continue;
			case 4u:
				num2 = (int)(num3 * 1225750720) ^ -527831575;
				continue;
			case 3u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = -468614842;
					num5 = -468614842;
				}
				else
				{
					num4 = -125886429;
					num5 = -125886429;
				}
				num2 = num4 ^ (int)(num3 * 2145511951);
				continue;
			}
			case 2u:
				num2 = (int)(num3 * 319897340) ^ -2082774461;
				continue;
			case 1u:
				num2 = (int)((num3 * 1344891742) ^ 0x1DE42153);
				continue;
			case 0u:
				Form4.smethod_5((IDisposable)components);
				num2 = ((int)num3 * -1850273574) ^ 0x6013591B;
				continue;
			default:
				return;
			case 8u:
				goto IL_00bd;
			case 7u:
				return;
			}
			break;
		}
		goto IL_0009;
		IL_00bd:
		num = ((components != null) ? 1 : 0);
		goto IL_00c6;
	}

	private void InitializeComponent()
	{
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected O, but got Unknown
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0675: Expected O, but got Unknown
		components = Form4.smethod_6();
		textBox1 = Form4.smethod_7();
		textBox2 = Form4.smethod_7();
		while (true)
		{
			int num = 233109761;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2CEB8671u) % 66u)
				{
				case 65u:
					num = ((int)num2 * -439806452) ^ 0x5F30E20C;
					continue;
				case 63u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)((num2 * 448013985) ^ 0x3DA5FFF9);
					continue;
				case 62u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = (int)(num2 * 1246478552) ^ -110573806;
					continue;
				case 61u:
					num = (int)(num2 * 1204640666) ^ -121478181;
					continue;
				case 60u:
					button1 = Form4.smethod_8();
					num = (int)((num2 * 186239291) ^ 0x5B530DBC);
					continue;
				case 59u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1125236852) ^ -1841106101;
					continue;
				case 58u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					num = (int)((num2 * 1559959485) ^ 0x6A61D174);
					continue;
				case 57u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 586047489) ^ -1723511063;
					continue;
				case 56u:
					textBox3 = Form4.smethod_7();
					num = (int)(num2 * 1656376768) ^ -322546499;
					continue;
				case 55u:
					num = ((int)num2 * -966839499) ^ -1183046586;
					continue;
				case 54u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = ((int)num2 * -792139693) ^ -1040106103;
					continue;
				case 52u:
					num = (int)((num2 * 1204492352) ^ 0x34F04E31);
					continue;
				case 51u:
					num = ((int)num2 * -1171955199) ^ -233171288;
					continue;
				case 50u:
					num = ((int)num2 * -607915395) ^ 0x2450360F;
					continue;
				case 49u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -1013235122) ^ 0x2BC22D1B;
					continue;
				case 48u:
					num = ((int)num2 * -1823821240) ^ -614836732;
					continue;
				case 47u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -1674516780) ^ -1383175044;
					continue;
				case 46u:
					num = (int)((num2 * 1900032650) ^ 0x69BF1720);
					continue;
				case 45u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)(num2 * 2147466467) ^ -930320970;
					continue;
				case 44u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -138162935) ^ -1943152093;
					continue;
				case 43u:
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1758868185) ^ 0x63F7D8DA;
					continue;
				case 42u:
					num = ((int)num2 * -2079818739) ^ -324544234;
					continue;
				case 41u:
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1897985892) ^ -2085878296;
					continue;
				case 40u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = (int)((num2 * 689191788) ^ 0x71461E67);
					continue;
				case 39u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 1687998930) ^ 0x29588987);
					continue;
				case 38u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = (int)((num2 * 2015815971) ^ 0x672D89F7);
					continue;
				case 37u:
					num = ((int)num2 * -1857526122) ^ 0x6920F804;
					continue;
				case 36u:
					num = ((int)num2 * -1339276779) ^ 0x3DA77B9C;
					continue;
				case 35u:
					Form4.smethod_11((Control)(object)this);
					num = ((int)num2 * -1547665440) ^ 0x4DC06993;
					continue;
				case 34u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -605392207) ^ 0x25E6A9D4;
					continue;
				case 33u:
					num = (int)(num2 * 1726920416) ^ -130387816;
					continue;
				case 32u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = (int)(num2 * 748548427) ^ -805971695;
					continue;
				case 31u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = (int)(num2 * 246804644) ^ -1126903451;
					continue;
				case 30u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1191580922) ^ 0x2E446776;
					continue;
				case 29u:
					errorProvider1 = Form4.smethod_9(components);
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -509081458) ^ -1171237124;
					continue;
				case 28u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = ((int)num2 * -1512245878) ^ -1484673587;
					continue;
				case 27u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = ((int)num2 * -621593378) ^ 0x58F21E61;
					continue;
				case 26u:
					Form4.smethod_18(textBox2, bool_0: true);
					num = ((int)num2 * -587091414) ^ -2118368103;
					continue;
				case 25u:
					num = ((int)num2 * -747954819) ^ 0x1FEE1FFD;
					continue;
				case 24u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = ((int)num2 * -1098934807) ^ -1450064154;
					continue;
				case 23u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = ((int)num2 * -246075536) ^ 0x738C33C;
					continue;
				case 22u:
					num = (int)((num2 * 632668393) ^ 0x7109205F);
					continue;
				case 21u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = (int)((num2 * 921944602) ^ 0x5EA62A23);
					continue;
				case 20u:
					num = ((int)num2 * -136377378) ^ -1683251316;
					continue;
				case 19u:
					num = ((int)num2 * -335589671) ^ -1810853726;
					continue;
				case 18u:
					num = (int)(num2 * 1261697172) ^ -1704436574;
					continue;
				case 17u:
					num = ((int)num2 * -1960157975) ^ -454005823;
					continue;
				case 16u:
					num = ((int)num2 * -917480948) ^ 0x22B66D10;
					continue;
				case 15u:
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = (int)(num2 * 730206983) ^ -2048072308;
					continue;
				case 14u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = (int)((num2 * 922745549) ^ 0x65DDC737);
					continue;
				case 13u:
					Form4.smethod_31((Control)(object)this, "Form4");
					num = ((int)num2 * -1248417980) ^ -232032697;
					continue;
				case 12u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					num = (int)(num2 * 483010028) ^ -841027328;
					continue;
				case 11u:
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 1422573654) ^ -576480532;
					continue;
				case 10u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = ((int)num2 * -1441906054) ^ -828193342;
					continue;
				case 9u:
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -539042174) ^ -804835481;
					continue;
				case 8u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = ((int)num2 * -638804993) ^ -352771850;
					continue;
				case 7u:
					Form4.smethod_18(textBox3, bool_0: true);
					num = ((int)num2 * -2049131539) ^ 0x2D430B5A;
					continue;
				case 6u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 1638503410) ^ 0x6C29BDD);
					continue;
				case 5u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = (int)((num2 * 295800915) ^ 0x3C821A16);
					continue;
				case 4u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 1058547700) ^ 0x52CDF9A);
					continue;
				case 3u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = (int)((num2 * 1516391277) ^ 0x33E64747);
					continue;
				case 2u:
					num = (int)(num2 * 379763213) ^ -2142748217;
					continue;
				case 1u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1615920867) ^ 0x35D9B10F;
					continue;
				case 0u:
					num = ((int)num2 * -170603454) ^ -522043490;
					continue;
				case 53u:
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
