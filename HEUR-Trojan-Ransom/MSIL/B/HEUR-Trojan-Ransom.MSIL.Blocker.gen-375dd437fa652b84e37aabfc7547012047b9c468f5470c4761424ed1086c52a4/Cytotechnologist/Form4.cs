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
			int num = -1942317496;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9151B79Bu) % 3u)
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
				num = (int)((num2 * 329199111) ^ 0x401D955F);
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
			int num = -84886297;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA2EBDFD6u) % 4u)
				{
				case 1u:
					Form4.smethod_3(e, bool_0: true);
					num = ((int)num2 * -427791839) ^ -892315385;
					continue;
				case 0u:
					num = (int)(num2 * 1569314747) ^ -434990235;
					continue;
				default:
					return;
				case 2u:
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
			int num = -1724454584;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0xF5C5AE08u) % 9u)
				{
				case 8u:
					num5 = ((components != null) ? 1 : 0);
					goto IL_000f;
				case 6u:
					if (disposing)
					{
						num = (int)((num2 * 1944348404) ^ 0x7AF985A9);
						continue;
					}
					num5 = 0;
					goto IL_000f;
				case 5u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 2141434657;
						num4 = 2141434657;
					}
					else
					{
						num3 = 1212340830;
						num4 = 1212340830;
					}
					num = num3 ^ (int)(num2 * 946066980);
					continue;
				}
				case 3u:
					Form4.smethod_5((IDisposable)components);
					num = ((int)num2 * -310504261) ^ -712857239;
					continue;
				case 2u:
					((Form)this).Dispose(disposing);
					num = -1376335299;
					continue;
				case 1u:
					num = ((int)num2 * -735314414) ^ -211474179;
					continue;
				case 0u:
					num = ((int)num2 * -2051411826) ^ 0x566FCD96;
					continue;
				default:
					return;
				case 4u:
					break;
				case 7u:
					return;
					IL_000f:
					flag = (byte)num5 != 0;
					num = -1331447111;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected O, but got Unknown
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected O, but got Unknown
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Expected O, but got Unknown
		while (true)
		{
			int num = -775856773;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCBD7C246u) % 63u)
				{
				case 62u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -898083610) ^ -1621414644;
					continue;
				case 61u:
					textBox3 = Form4.smethod_7();
					num = ((int)num2 * -306142028) ^ -1421431266;
					continue;
				case 60u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 452592103) ^ -1508313345;
					continue;
				case 59u:
					Form4.smethod_15((Control)(object)button1, 0);
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = (int)((num2 * 1300469164) ^ 0x21434ECC);
					continue;
				case 58u:
					num = ((int)num2 * -1758581172) ^ -269511016;
					continue;
				case 57u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = (int)(num2 * 463142914) ^ -928418164;
					continue;
				case 56u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = (int)((num2 * 1614330740) ^ 0x136025F9);
					continue;
				case 55u:
					num = (int)(num2 * 273957671) ^ -1268004656;
					continue;
				case 54u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 23498489) ^ 0x21327D7E);
					continue;
				case 53u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 55456601) ^ -2063966042;
					continue;
				case 52u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 385053673) ^ 0x3ED2E97);
					continue;
				case 51u:
					errorProvider1 = Form4.smethod_9(components);
					num = (int)((num2 * 175097049) ^ 0x3BA716E);
					continue;
				case 50u:
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					Form4.smethod_11((Control)(object)this);
					num = ((int)num2 * -441460201) ^ -1283203590;
					continue;
				case 49u:
					num = ((int)num2 * -1885942765) ^ -1668739637;
					continue;
				case 48u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = ((int)num2 * -1323689647) ^ 0x11350ECE;
					continue;
				case 47u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = (int)(num2 * 240082444) ^ -535213574;
					continue;
				case 46u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1447174911) ^ 0x3D0BA84;
					continue;
				case 45u:
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -2065387044) ^ 0x3B148213;
					continue;
				case 44u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -1494676024) ^ 0x1DD40739;
					continue;
				case 43u:
					num = ((int)num2 * -976222607) ^ 0x29EB475;
					continue;
				case 42u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = (int)(num2 * 1023452308) ^ -359982814;
					continue;
				case 41u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -1346206580) ^ 0x4AEB658C;
					continue;
				case 40u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					Form4.smethod_19((Control)(object)this, "Регистрация");
					num = (int)(num2 * 244880082) ^ -513760089;
					continue;
				case 39u:
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1505456506) ^ 0x23F35E7B;
					continue;
				case 38u:
					button1 = Form4.smethod_8();
					num = ((int)num2 * -72587052) ^ 0x45C1DDF7;
					continue;
				case 37u:
					num = ((int)num2 * -125266458) ^ -1232165195;
					continue;
				case 36u:
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = (int)(num2 * 606160938) ^ -811954272;
					continue;
				case 35u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = (int)((num2 * 1461670901) ^ 0x68757D5E);
					continue;
				case 34u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = (int)((num2 * 900988099) ^ 0x6187EB9D);
					continue;
				case 33u:
					Form4.smethod_18(textBox2, bool_0: true);
					num = (int)(num2 * 680712288) ^ -1066681765;
					continue;
				case 32u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = ((int)num2 * -1397990608) ^ 0x27DAA0CB;
					continue;
				case 31u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = ((int)num2 * -478364660) ^ 0xF31890;
					continue;
				case 30u:
					num = ((int)num2 * -364869691) ^ -1979727414;
					continue;
				case 29u:
					num = ((int)num2 * -608755929) ^ -755930367;
					continue;
				case 28u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = (int)(num2 * 688025720) ^ -1453843598;
					continue;
				case 27u:
					num = ((int)num2 * -588725837) ^ 0x3801CCD3;
					continue;
				case 25u:
					num = (int)((num2 * 2022920825) ^ 0xC204FDA);
					continue;
				case 24u:
					num = ((int)num2 * -1560828118) ^ 0x2E7000D5;
					continue;
				case 23u:
					num = (int)(num2 * 1974103971) ^ -2130557163;
					continue;
				case 22u:
					num = (int)((num2 * 916208161) ^ 0x71BB60E4);
					continue;
				case 21u:
					num = (int)(num2 * 416293303) ^ -430637638;
					continue;
				case 20u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = (int)(num2 * 574423640) ^ -1200936462;
					continue;
				case 19u:
					num = (int)(num2 * 1534824995) ^ -193841998;
					continue;
				case 18u:
					num = (int)((num2 * 2039534994) ^ 0x34E31963);
					continue;
				case 17u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = ((int)num2 * -150500870) ^ 0x1C0F8D22;
					continue;
				case 16u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = (int)(num2 * 480514420) ^ -1307667847;
					continue;
				case 15u:
					num = ((int)num2 * -1869343800) ^ -1801164562;
					continue;
				case 14u:
					Form4.smethod_18(textBox3, bool_0: true);
					num = ((int)num2 * -188532469) ^ -1716301845;
					continue;
				case 13u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1581874797) ^ 0x256BBFAE);
					continue;
				case 12u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = (int)(num2 * 476932716) ^ -1725603775;
					continue;
				case 11u:
					num = ((int)num2 * -1192040310) ^ -297493418;
					continue;
				case 10u:
					num = (int)((num2 * 629594693) ^ 0x72862201);
					continue;
				case 9u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = (int)((num2 * 1000873352) ^ 0x7AA12E5);
					continue;
				case 8u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -2113994455) ^ 0x7CF37D07;
					continue;
				case 7u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					num = (int)(num2 * 1866410300) ^ -910390088;
					continue;
				case 6u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					Form4.smethod_31((Control)(object)this, "Form4");
					num = ((int)num2 * -1469419953) ^ -2122089342;
					continue;
				case 5u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = (int)(num2 * 503738214) ^ -92415023;
					continue;
				case 4u:
					components = Form4.smethod_6();
					num = ((int)num2 * -321566413) ^ -1281041627;
					continue;
				case 2u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = ((int)num2 * -1790396235) ^ 0x55926594;
					continue;
				case 1u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -421986002) ^ -885741015;
					continue;
				case 0u:
					textBox1 = Form4.smethod_7();
					textBox2 = Form4.smethod_7();
					num = (int)(num2 * 2097132030) ^ -2144604362;
					continue;
				case 3u:
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
