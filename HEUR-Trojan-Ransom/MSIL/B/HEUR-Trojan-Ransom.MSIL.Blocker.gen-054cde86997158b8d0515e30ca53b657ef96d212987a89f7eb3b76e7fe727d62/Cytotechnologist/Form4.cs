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
			int num = -149481806;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA021721Au) % 5u)
				{
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -883023568;
						num4 = -883023568;
					}
					else
					{
						num3 = -1610295099;
						num4 = -1610295099;
					}
					num = num3 ^ ((int)num2 * -244725413);
					continue;
				}
				case 3u:
					Form4.smethod_3(e, bool_0: true);
					num = ((int)num2 * -476550083) ^ 0x7414512D;
					continue;
				case 1u:
					num = (int)((num2 * 277119828) ^ 0x21869979);
					continue;
				default:
					return;
				case 0u:
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
			int num = -810811203;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD2CDB373u) % 3u)
				{
				case 1u:
					goto IL_000d;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000d:
				num = (int)((num2 * 906313845) ^ 0x2486AC32);
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		while (true)
		{
			int num = -1204492532;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x8252D499u) % 7u)
				{
				case 6u:
					if (disposing)
					{
						num = ((int)num2 * -111582308) ^ 0x18FE904D;
						continue;
					}
					goto IL_001b;
				case 4u:
					num = ((int)num2 * -947389901) ^ 0x4CCB727;
					continue;
				case 3u:
					num = ((int)num2 * -1170027507) ^ 0x1CACD2D3;
					continue;
				case 2u:
					Form4.smethod_5((IDisposable)components);
					num = ((int)num2 * -1868986514) ^ -1147548963;
					continue;
				case 0u:
					if (components != null)
					{
						num = -1901915291;
						num3 = -1901915291;
						continue;
					}
					goto IL_001b;
				case 5u:
					break;
				default:
					{
						((Form)this).Dispose(disposing);
						return;
					}
					IL_001b:
					num = -1941539963;
					num3 = -1941539963;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected O, but got Unknown
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected O, but got Unknown
		while (true)
		{
			int num = -1642486149;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9F290BB4u) % 70u)
				{
				case 69u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -268050473) ^ 0x7120AC26;
					continue;
				case 68u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = ((int)num2 * -90638823) ^ 0x2CD09F10;
					continue;
				case 67u:
					button1 = Form4.smethod_8();
					num = (int)(num2 * 1206689585) ^ -142624789;
					continue;
				case 66u:
					num = (int)((num2 * 1679691469) ^ 0x7E6E682A);
					continue;
				case 65u:
					num = (int)((num2 * 64768071) ^ 0x4750E4A0);
					continue;
				case 64u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = (int)(num2 * 94433361) ^ -638632425;
					continue;
				case 63u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = ((int)num2 * -1388111027) ^ 0x11C66338;
					continue;
				case 62u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = ((int)num2 * -914928329) ^ 0x6A98DB1A;
					continue;
				case 61u:
					num = (int)(num2 * 674332459) ^ -574300018;
					continue;
				case 60u:
					textBox3 = Form4.smethod_7();
					num = (int)(num2 * 989714175) ^ -124277255;
					continue;
				case 59u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 1841406331) ^ -2078434798;
					continue;
				case 58u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = (int)((num2 * 1109944668) ^ 0xC378C23);
					continue;
				case 57u:
					num = (int)(num2 * 293906138) ^ -1503036335;
					continue;
				case 56u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = ((int)num2 * -1944597765) ^ -503170273;
					continue;
				case 55u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = ((int)num2 * -120124341) ^ 0x24C0F8DA;
					continue;
				case 54u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = ((int)num2 * -1227243010) ^ 0x18DC22D;
					continue;
				case 53u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 712549535) ^ -1042419255;
					continue;
				case 52u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = ((int)num2 * -555238955) ^ 0xE01EDF5;
					continue;
				case 51u:
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = (int)((num2 * 842832619) ^ 0x2B81C7B3);
					continue;
				case 50u:
					num = (int)(num2 * 1706913044) ^ -387393606;
					continue;
				case 49u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)(num2 * 967742312) ^ -388752385;
					continue;
				case 48u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = (int)((num2 * 1613279061) ^ 0x43F3DC64);
					continue;
				case 47u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1868753478) ^ 0x7C560AEA);
					continue;
				case 46u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = (int)((num2 * 1951137829) ^ 0x4D867854);
					continue;
				case 45u:
					Form4.smethod_37((Control)(object)this);
					num = ((int)num2 * -883316317) ^ -1847683361;
					continue;
				case 44u:
					num = ((int)num2 * -1388760103) ^ 0x1A3796B6;
					continue;
				case 43u:
					num = ((int)num2 * -903531625) ^ 0x5AAAD01A;
					continue;
				case 42u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1287611799) ^ -2021656148;
					continue;
				case 41u:
					num = ((int)num2 * -1948685438) ^ 0x3E96D092;
					continue;
				case 40u:
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -572026014) ^ 0x73430F4B;
					continue;
				case 39u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = ((int)num2 * -1265105345) ^ -1448697550;
					continue;
				case 38u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -865023051) ^ -1774731134;
					continue;
				case 37u:
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = ((int)num2 * -438248462) ^ 0x308C7C68;
					continue;
				case 36u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)(num2 * 66697150) ^ -632026312;
					continue;
				case 35u:
					num = (int)(num2 * 2024163291) ^ -84470565;
					continue;
				case 34u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = (int)((num2 * 545450882) ^ 0x22600BAA);
					continue;
				case 33u:
					num = ((int)num2 * -1459905382) ^ 0x379B0F56;
					continue;
				case 32u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					num = ((int)num2 * -931461192) ^ -1345946889;
					continue;
				case 31u:
					num = ((int)num2 * -381875418) ^ 0x783D53D1;
					continue;
				case 30u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = ((int)num2 * -1056930255) ^ -1971188391;
					continue;
				case 29u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -2132644988) ^ 0x409F72FC;
					continue;
				case 28u:
					num = (int)((num2 * 995188025) ^ 0x2ACE151B);
					continue;
				case 27u:
					Form4.smethod_31((Control)(object)this, "Form4");
					num = (int)(num2 * 2130410018) ^ -1332250099;
					continue;
				case 25u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -1513240826) ^ 0x7344E6E0;
					continue;
				case 24u:
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = (int)((num2 * 1124498091) ^ 0x1EE1B5BF);
					continue;
				case 22u:
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = (int)((num2 * 445178869) ^ 0x3784787D);
					continue;
				case 21u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = ((int)num2 * -594429842) ^ 0x73E387E9;
					continue;
				case 20u:
					errorProvider1 = Form4.smethod_9(components);
					num = ((int)num2 * -1463834176) ^ 0x3F018E4A;
					continue;
				case 19u:
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1321523252) ^ -1376123426;
					continue;
				case 18u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)(num2 * 539590117) ^ -1767180771;
					continue;
				case 17u:
					Form4.smethod_18(textBox2, bool_0: true);
					num = ((int)num2 * -725416044) ^ -1433890752;
					continue;
				case 16u:
					num = ((int)num2 * -60776179) ^ -1400221003;
					continue;
				case 15u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)((num2 * 611788379) ^ 0x6ED8E267);
					continue;
				case 14u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -2016938033) ^ -357125254;
					continue;
				case 13u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = (int)((num2 * 1621632121) ^ 0x7ABB56B2);
					continue;
				case 12u:
					num = (int)((num2 * 512973841) ^ 0x4D6CA3C0);
					continue;
				case 11u:
					num = (int)(num2 * 690490501) ^ -804269939;
					continue;
				case 10u:
					num = ((int)num2 * -314204278) ^ 0x5602B9BC;
					continue;
				case 9u:
					components = Form4.smethod_6();
					textBox1 = Form4.smethod_7();
					textBox2 = Form4.smethod_7();
					num = (int)((num2 * 7726311) ^ 0x1C4D2BDB);
					continue;
				case 8u:
					Form4.smethod_11((Control)(object)this);
					num = ((int)num2 * -74354604) ^ -1966313891;
					continue;
				case 7u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1960297251) ^ 0x28F60C0C;
					continue;
				case 6u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = (int)(num2 * 1933280764) ^ -547926221;
					continue;
				case 5u:
					num = ((int)num2 * -2104181490) ^ 0x6F698C0B;
					continue;
				case 4u:
					num = ((int)num2 * -1470818090) ^ 0x5F6AB546;
					continue;
				case 3u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = ((int)num2 * -2047992140) ^ 0x284D6674;
					continue;
				case 2u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = ((int)num2 * -1772723490) ^ -1323656262;
					continue;
				case 1u:
					num = (int)(num2 * 658808862) ^ -1744653780;
					continue;
				case 0u:
					Form4.smethod_18(textBox3, bool_0: true);
					num = (int)((num2 * 313716013) ^ 0x7A935A43);
					continue;
				default:
					return;
				case 23u:
					break;
				case 26u:
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
