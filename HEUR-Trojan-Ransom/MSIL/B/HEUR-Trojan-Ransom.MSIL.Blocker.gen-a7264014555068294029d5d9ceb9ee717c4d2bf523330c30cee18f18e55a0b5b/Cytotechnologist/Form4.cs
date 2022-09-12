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
			int num = 1208331259;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x15661F78u) % 5u)
				{
				case 4u:
					InitializeComponent();
					num = (int)((num2 * 1723603428) ^ 0xA928880);
					continue;
				case 3u:
					num = ((int)num2 * -363010048) ^ -699613126;
					continue;
				case 1u:
					num = ((int)num2 * -1996756073) ^ 0x79E8BA6F;
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

	private void Form4_FormClosing(object sender, FormClosingEventArgs e)
	{
		Form4.smethod_1((Control)(object)Form4.smethod_0((Form)(object)this), bool_0: true);
	}

	private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		while (true)
		{
			int num = -1786466010;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEF8CB0CCu) % 4u)
				{
				case 2u:
				{
					int num3;
					int num4;
					if (Form4.smethod_2(e) == ' ')
					{
						num3 = 1373822689;
						num4 = 1373822689;
					}
					else
					{
						num3 = 172574143;
						num4 = 172574143;
					}
					num = num3 ^ (int)(num2 * 859217072);
					continue;
				}
				case 1u:
					Form4.smethod_3(e, bool_0: true);
					num = (int)(num2 * 1512696535) ^ -220056204;
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
	}

	protected override void Dispose(bool disposing)
	{
		while (true)
		{
			int num = 705554131;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x52A4B816u) % 6u)
				{
				case 4u:
					if (components != null)
					{
						num = 1293052222;
						num3 = 1293052222;
						continue;
					}
					goto IL_001d;
				case 2u:
					((Form)this).Dispose(disposing);
					num = 996030333;
					continue;
				case 1u:
					if (disposing)
					{
						num = ((int)num2 * -1067337272) ^ 0x7FEDC414;
						continue;
					}
					goto IL_001d;
				case 0u:
					Form4.smethod_5((IDisposable)components);
					num = (int)((num2 * 422101022) ^ 0x42FB832E);
					continue;
				default:
					return;
				case 3u:
					break;
				case 5u:
					return;
					IL_001d:
					num = 678494622;
					num3 = 678494622;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Expected O, but got Unknown
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected O, but got Unknown
		while (true)
		{
			int num = -333410856;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9F725815u) % 60u)
				{
				case 59u:
					num = ((int)num2 * -1640314154) ^ 0x791C7AD9;
					continue;
				case 58u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = (int)((num2 * 1329015192) ^ 0x1C6D368F);
					continue;
				case 57u:
					num = ((int)num2 * -1586863816) ^ -2099709198;
					continue;
				case 56u:
					num = (int)((num2 * 830438757) ^ 0x390B47B);
					continue;
				case 55u:
					num = (int)(num2 * 1140613205) ^ -163118039;
					continue;
				case 54u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = (int)(num2 * 622701716) ^ -2025995775;
					continue;
				case 52u:
					num = ((int)num2 * -720104376) ^ -1207221950;
					continue;
				case 51u:
					num = ((int)num2 * -1620739953) ^ 0x11C7201E;
					continue;
				case 50u:
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1883681387) ^ 0x46947B44;
					continue;
				case 49u:
					Form4.smethod_11((Control)(object)this);
					num = ((int)num2 * -969975985) ^ 0x74093678;
					continue;
				case 48u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = (int)(num2 * 1203188388) ^ -623700961;
					continue;
				case 47u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = ((int)num2 * -855505928) ^ 0x7D9CFD6F;
					continue;
				case 46u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = ((int)num2 * -674550772) ^ -17480139;
					continue;
				case 45u:
					components = Form4.smethod_6();
					num = (int)((num2 * 1129738409) ^ 0x27CEA9F);
					continue;
				case 44u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = (int)(num2 * 1643926526) ^ -1559311445;
					continue;
				case 43u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = ((int)num2 * -581298834) ^ 0x36CD83BC;
					continue;
				case 42u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = (int)((num2 * 1570106998) ^ 0x6A41D2D2);
					continue;
				case 41u:
					Form4.smethod_31((Control)(object)this, "Form4");
					num = ((int)num2 * -1067741299) ^ -1599395472;
					continue;
				case 40u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = (int)((num2 * 2021253540) ^ 0x4753B2BB);
					continue;
				case 39u:
					num = (int)(num2 * 2067264152) ^ -2130122025;
					continue;
				case 38u:
					Form4.smethod_18(textBox2, bool_0: true);
					num = (int)(num2 * 868289341) ^ -1705517729;
					continue;
				case 37u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)(num2 * 1539282847) ^ -34271473;
					continue;
				case 36u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 468374088) ^ -92415740;
					continue;
				case 35u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = (int)(num2 * 1934337939) ^ -1199708604;
					continue;
				case 34u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = (int)(num2 * 336192733) ^ -896069470;
					continue;
				case 33u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = (int)((num2 * 876502621) ^ 0x213D26FC);
					continue;
				case 32u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 192701724) ^ 0x2A71D890);
					continue;
				case 31u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = (int)((num2 * 1489329442) ^ 0x67E5E8A9);
					continue;
				case 30u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = ((int)num2 * -1933273802) ^ -134232608;
					continue;
				case 29u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 1067604283) ^ -373449527;
					continue;
				case 28u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					Form4.smethod_18(textBox3, bool_0: true);
					num = ((int)num2 * -1177745752) ^ 0x5F8ED530;
					continue;
				case 27u:
					textBox1 = Form4.smethod_7();
					textBox2 = Form4.smethod_7();
					num = ((int)num2 * -1992857096) ^ -589742591;
					continue;
				case 26u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = (int)((num2 * 849138985) ^ 0x7AFFBACE);
					continue;
				case 25u:
					num = ((int)num2 * -1962855809) ^ -471121254;
					continue;
				case 24u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = (int)(num2 * 1934176177) ^ -44360959;
					continue;
				case 22u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = ((int)num2 * -1530200711) ^ -161430068;
					continue;
				case 21u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = (int)((num2 * 1398380739) ^ 0x4F588DC9);
					continue;
				case 20u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					num = (int)((num2 * 973403357) ^ 0x5F0AD5AB);
					continue;
				case 19u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -999928503) ^ -1844896751;
					continue;
				case 18u:
					num = ((int)num2 * -761988457) ^ -374819133;
					continue;
				case 17u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					num = ((int)num2 * -554282069) ^ 0x2D6CB650;
					continue;
				case 16u:
					textBox3 = Form4.smethod_7();
					button1 = Form4.smethod_8();
					errorProvider1 = Form4.smethod_9(components);
					num = ((int)num2 * -1008737929) ^ 0x1938E7C;
					continue;
				case 15u:
					Form4.smethod_37((Control)(object)this);
					num = ((int)num2 * -1767334503) ^ -569620693;
					continue;
				case 14u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 685007224) ^ 0x3375F6DE);
					continue;
				case 13u:
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1383227044) ^ -1949737370;
					continue;
				case 12u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1074146339) ^ -1619961444;
					continue;
				case 11u:
					num = ((int)num2 * -764725337) ^ -342854772;
					continue;
				case 10u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = (int)(num2 * 104820920) ^ -1660118176;
					continue;
				case 9u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1137868746) ^ -1820711349;
					continue;
				case 8u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = (int)(num2 * 1038973764) ^ -791221138;
					continue;
				case 7u:
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -1115558664) ^ 0x28B0A1F9;
					continue;
				case 6u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = ((int)num2 * -122967413) ^ 0x434FAACC;
					continue;
				case 5u:
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -1527144830) ^ -1885003110;
					continue;
				case 4u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 2032271150) ^ -1236011608;
					continue;
				case 3u:
					num = (int)(num2 * 912646312) ^ -1333904075;
					continue;
				case 2u:
					num = ((int)num2 * -2013499792) ^ -48360375;
					continue;
				case 1u:
					num = (int)((num2 * 515197882) ^ 0x586CDF59);
					continue;
				case 0u:
					num = ((int)num2 * -1991292760) ^ -1251978713;
					continue;
				default:
					return;
				case 53u:
					break;
				case 23u:
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
