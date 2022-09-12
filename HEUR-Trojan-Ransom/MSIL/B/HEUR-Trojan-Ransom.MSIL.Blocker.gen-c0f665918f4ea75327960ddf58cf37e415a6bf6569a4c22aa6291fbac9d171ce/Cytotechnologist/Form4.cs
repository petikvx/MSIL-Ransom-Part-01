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
		while (true)
		{
			int num = 1639226889;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6157C173u) % 4u)
				{
				case 2u:
				{
					int num3;
					int num4;
					if (Form4.smethod_2(e) == ' ')
					{
						num3 = -2120653912;
						num4 = -2120653912;
					}
					else
					{
						num3 = -1585776602;
						num4 = -1585776602;
					}
					num = num3 ^ (int)(num2 * 907858717);
					continue;
				}
				case 1u:
					Form4.smethod_3(e, bool_0: true);
					num = (int)((num2 * 1939840525) ^ 0x33C3FC81);
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
			int num = 1524329121;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x75406120u) % 8u)
				{
				case 7u:
					num = (int)((num2 * 2050054630) ^ 0x66A8D122);
					continue;
				case 6u:
					((Form)this).Dispose(disposing);
					num = 2055581018;
					continue;
				case 5u:
					if (components != null)
					{
						num = 1375627959;
						num3 = 1375627959;
						continue;
					}
					goto IL_003a;
				case 2u:
					num = ((int)num2 * -1112693955) ^ -223485527;
					continue;
				case 1u:
					if (disposing)
					{
						num = (int)((num2 * 1327301793) ^ 0x14334434);
						continue;
					}
					goto IL_003a;
				case 0u:
					Form4.smethod_5((IDisposable)components);
					num = ((int)num2 * -127844207) ^ 0x5AB6FF56;
					continue;
				default:
					return;
				case 4u:
					break;
				case 3u:
					return;
					IL_003a:
					num = 792643710;
					num3 = 792643710;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected O, but got Unknown
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected O, but got Unknown
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Expected O, but got Unknown
		while (true)
		{
			int num = -2138952582;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCE94249Cu) % 65u)
				{
				case 64u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					Form4.smethod_31((Control)(object)this, "Form4");
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1874977637) ^ 0x736099A);
					continue;
				case 63u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)((num2 * 829393944) ^ 0x50C8AB6E);
					continue;
				case 62u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)((num2 * 1071793000) ^ 0x38FAFE30);
					continue;
				case 61u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = (int)((num2 * 827144194) ^ 0x2357D622);
					continue;
				case 60u:
					num = ((int)num2 * -1518291420) ^ -942154236;
					continue;
				case 58u:
					Form4.smethod_11((Control)(object)this);
					num = (int)(num2 * 976650839) ^ -2128803285;
					continue;
				case 57u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					Form4.smethod_15((Control)(object)textBox3, 3);
					Form4.smethod_18(textBox3, bool_0: true);
					num = (int)(num2 * 586664556) ^ -1265490091;
					continue;
				case 56u:
					num = (int)((num2 * 85835150) ^ 0x716F4AA3);
					continue;
				case 55u:
					num = (int)((num2 * 2123433108) ^ 0x6205C2E0);
					continue;
				case 54u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					num = ((int)num2 * -1908876493) ^ 0x2A31A66B;
					continue;
				case 53u:
					num = ((int)num2 * -1061850510) ^ -2132270383;
					continue;
				case 52u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = ((int)num2 * -1053195417) ^ 0x53E4406F;
					continue;
				case 51u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = (int)(num2 * 1078696392) ^ -53246389;
					continue;
				case 50u:
					num = (int)((num2 * 1356270959) ^ 0x5C8F6A99);
					continue;
				case 49u:
					Form4.smethod_37((Control)(object)this);
					num = ((int)num2 * -456023356) ^ -1665522638;
					continue;
				case 47u:
					Form4.smethod_18(textBox2, bool_0: true);
					num = ((int)num2 * -2042654153) ^ -1905614408;
					continue;
				case 46u:
					num = (int)(num2 * 1245745915) ^ -496149989;
					continue;
				case 45u:
					textBox1 = Form4.smethod_7();
					textBox2 = Form4.smethod_7();
					textBox3 = Form4.smethod_7();
					button1 = Form4.smethod_8();
					errorProvider1 = Form4.smethod_9(components);
					num = (int)((num2 * 302414238) ^ 0x2A5B7917);
					continue;
				case 44u:
					num = ((int)num2 * -719579780) ^ -752371423;
					continue;
				case 43u:
					components = Form4.smethod_6();
					num = ((int)num2 * -1947694298) ^ 0x46843F1E;
					continue;
				case 42u:
					num = ((int)num2 * -846137017) ^ -764031934;
					continue;
				case 41u:
					num = ((int)num2 * -935038005) ^ 0x752DD6DE;
					continue;
				case 40u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = (int)(num2 * 1568939917) ^ -542216740;
					continue;
				case 39u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 646352377) ^ 0x71714F7D);
					continue;
				case 38u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = (int)(num2 * 779538799) ^ -914089720;
					continue;
				case 37u:
					num = ((int)num2 * -1587837105) ^ -1377737530;
					continue;
				case 36u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 1392741472) ^ 0x4A33F395);
					continue;
				case 35u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = (int)((num2 * 1880938752) ^ 0x10030BC1);
					continue;
				case 34u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = (int)(num2 * 1252034730) ^ -1513042015;
					continue;
				case 33u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1888717924) ^ 0x8B94B52;
					continue;
				case 32u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = (int)((num2 * 1526515992) ^ 0x7F1E4333);
					continue;
				case 31u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = ((int)num2 * -744519149) ^ 0x183D0A0B;
					continue;
				case 30u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1612743237) ^ -2012826546;
					continue;
				case 29u:
					num = ((int)num2 * -1848346128) ^ 0x5116E10B;
					continue;
				case 28u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 1736277767) ^ 0x15037853);
					continue;
				case 27u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1162788781) ^ -1964821640;
					continue;
				case 26u:
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)(num2 * 1529158019) ^ -494373563;
					continue;
				case 25u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = ((int)num2 * -1628902283) ^ -58574188;
					continue;
				case 24u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = (int)((num2 * 735135158) ^ 0x699E4658);
					continue;
				case 23u:
					num = ((int)num2 * -740334678) ^ 0x5C4766FC;
					continue;
				case 22u:
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					num = (int)((num2 * 1728401208) ^ 0x73BD47F0);
					continue;
				case 21u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					Form4.smethod_13((Control)(object)button1, "button1");
					num = ((int)num2 * -1268445561) ^ -1620109018;
					continue;
				case 20u:
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = ((int)num2 * -589504416) ^ 0x56C540D1;
					continue;
				case 19u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = (int)((num2 * 981208385) ^ 0x7FCA3A60);
					continue;
				case 18u:
					num = ((int)num2 * -2089013571) ^ -433309966;
					continue;
				case 17u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -565112195) ^ 0x79C07EA4;
					continue;
				case 16u:
					num = (int)((num2 * 1302059483) ^ 0x8EBBF76);
					continue;
				case 15u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 471174898) ^ 0x7FB73100);
					continue;
				case 14u:
					num = (int)((num2 * 1748760706) ^ 0x6B689026);
					continue;
				case 13u:
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -686964162) ^ 0x45A530B4;
					continue;
				case 12u:
					num = (int)(num2 * 1454799170) ^ -1219872894;
					continue;
				case 11u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = (int)(num2 * 1917874241) ^ -1098999587;
					continue;
				case 10u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -1400492351) ^ 0x5C217DCE;
					continue;
				case 9u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -407120573) ^ -1991917332;
					continue;
				case 8u:
					num = (int)(num2 * 2076408127) ^ -1489847365;
					continue;
				case 7u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = ((int)num2 * -1856590311) ^ -1804649158;
					continue;
				case 6u:
					num = (int)(num2 * 853456067) ^ -664930490;
					continue;
				case 5u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -2116854639) ^ -1193405579;
					continue;
				case 4u:
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1684920833) ^ 0x2B9E8CFC;
					continue;
				case 3u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = ((int)num2 * -1919312504) ^ -1431736494;
					continue;
				case 2u:
					num = ((int)num2 * -1949803499) ^ 0x3FE2E03D;
					continue;
				case 1u:
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = ((int)num2 * -1667492214) ^ -1133012477;
					continue;
				case 0u:
					num = ((int)num2 * -1813088883) ^ -1334896538;
					continue;
				default:
					return;
				case 59u:
					break;
				case 48u:
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
