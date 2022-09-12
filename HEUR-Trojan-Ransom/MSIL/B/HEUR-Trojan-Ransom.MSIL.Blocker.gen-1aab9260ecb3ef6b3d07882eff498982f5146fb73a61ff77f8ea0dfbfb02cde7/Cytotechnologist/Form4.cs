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
			int num = -1866087410;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x91C0FCCFu) % 4u)
				{
				case 2u:
					InitializeComponent();
					num = (int)(num2 * 312277513) ^ -1550337490;
					continue;
				case 1u:
					num = ((int)num2 * -234863174) ^ 0x217330CF;
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
		while (true)
		{
			int num = -857097256;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA11C51F0u) % 3u)
				{
				case 1u:
					goto IL_000e;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000e:
				num = ((int)num2 * -1613406092) ^ 0x1525C00C;
			}
		}
	}

	private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = Form4.smethod_2(e) == ' ';
		while (true)
		{
			int num = 2005479592;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5CD46A2Eu) % 4u)
				{
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1974228542;
						num4 = -1974228542;
					}
					else
					{
						num3 = -1568475809;
						num4 = -1568475809;
					}
					num = num3 ^ ((int)num2 * -1264612180);
					continue;
				}
				case 1u:
					Form4.smethod_3(e, bool_0: true);
					num = (int)((num2 * 1518059018) ^ 0x2AABB770);
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
		while (true)
		{
			int num = 1762179102;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x107C6F78u) % 3u)
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
				num = (int)((num2 * 1502354987) ^ 0x31A633CC);
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_005c;
		}
		goto IL_0099;
		IL_005c:
		int num = -1155943436;
		goto IL_0061;
		IL_0061:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xEB1B32C1u) % 7u)
			{
			case 6u:
				num = ((int)num2 * -1178420306) ^ 0x2AD7D4F9;
				continue;
			case 4u:
				((Form)this).Dispose(disposing);
				num = -748251585;
				continue;
			case 3u:
				Form4.smethod_5((IDisposable)components);
				num = (int)((num2 * 1483685262) ^ 0x4AC6BD1E);
				continue;
			case 1u:
				num = ((int)num2 * -1000485672) ^ 0xDBB0780;
				continue;
			case 0u:
				break;
			default:
				return;
			case 2u:
				goto IL_008e;
			case 5u:
				return;
			}
			break;
			IL_008e:
			if (components != null)
			{
				num = -1802848132;
				num3 = -1802848132;
				continue;
			}
			goto IL_0099;
		}
		goto IL_005c;
		IL_0099:
		num = -223191417;
		num3 = -223191417;
		goto IL_0061;
	}

	private void InitializeComponent()
	{
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected O, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected O, but got Unknown
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected O, but got Unknown
		while (true)
		{
			int num = 1896467274;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7FE2CB02u) % 66u)
				{
				case 65u:
					button1 = Form4.smethod_8();
					errorProvider1 = Form4.smethod_9(components);
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 121176063) ^ -82430179;
					continue;
				case 64u:
					num = (int)(num2 * 2106437172) ^ -514074364;
					continue;
				case 63u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = ((int)num2 * -2006386764) ^ 0x474AD528;
					continue;
				case 62u:
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = ((int)num2 * -2017930447) ^ 0x3D1F6772;
					continue;
				case 61u:
					Form4.smethod_37((Control)(object)this);
					num = (int)(num2 * 242462925) ^ -171197348;
					continue;
				case 60u:
					num = (int)(num2 * 1216990396) ^ -323768437;
					continue;
				case 59u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = (int)(num2 * 1723951300) ^ -1501274812;
					continue;
				case 58u:
					num = ((int)num2 * -927270443) ^ -316465213;
					continue;
				case 57u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1988383512) ^ 0x691701AC;
					continue;
				case 56u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = (int)((num2 * 599011912) ^ 0x1BEB8961);
					continue;
				case 55u:
					num = (int)((num2 * 843350708) ^ 0x662BA52A);
					continue;
				case 54u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = (int)((num2 * 1952469496) ^ 0x3A5525EB);
					continue;
				case 53u:
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1770854105) ^ 0x572D7EDB;
					continue;
				case 52u:
					textBox1 = Form4.smethod_7();
					num = (int)(num2 * 890247022) ^ -381221325;
					continue;
				case 51u:
					Form4.smethod_18(textBox2, bool_0: true);
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -381249946) ^ 0x6CA529B7;
					continue;
				case 50u:
					num = ((int)num2 * -1888701702) ^ -1083934323;
					continue;
				case 49u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = (int)(num2 * 1591564507) ^ -782364086;
					continue;
				case 48u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = ((int)num2 * -1404844576) ^ -647631422;
					continue;
				case 47u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = (int)((num2 * 1986316790) ^ 0x22143E6D);
					continue;
				case 46u:
					num = ((int)num2 * -1255887398) ^ 0x2D02022A;
					continue;
				case 45u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = (int)(num2 * 482020991) ^ -1483167477;
					continue;
				case 44u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = ((int)num2 * -652461521) ^ 0x4D588E74;
					continue;
				case 43u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					num = (int)((num2 * 404563907) ^ 0x4F45E32A);
					continue;
				case 42u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -333548947) ^ 0x6B158A5F;
					continue;
				case 41u:
					num = (int)(num2 * 454722668) ^ -1767659248;
					continue;
				case 40u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = (int)((num2 * 448654352) ^ 0x670FD286);
					continue;
				case 38u:
					num = ((int)num2 * -1865229583) ^ 0x18DD8095;
					continue;
				case 37u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1872777368) ^ -1903290650;
					continue;
				case 36u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 175346087) ^ 0x26673D24);
					continue;
				case 35u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -976449374) ^ 0xDC22ECA;
					continue;
				case 34u:
					textBox3 = Form4.smethod_7();
					num = ((int)num2 * -1145107538) ^ -1182670229;
					continue;
				case 33u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 872738222) ^ 0x608544BD);
					continue;
				case 32u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = (int)(num2 * 1352582101) ^ -1802279454;
					continue;
				case 31u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = ((int)num2 * -1851917047) ^ -1328626763;
					continue;
				case 30u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = ((int)num2 * -910186272) ^ 0x610A397E;
					continue;
				case 29u:
					num = ((int)num2 * -262958365) ^ 0xBF61640;
					continue;
				case 28u:
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)(num2 * 1210665337) ^ -16608408;
					continue;
				case 27u:
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = ((int)num2 * -630164558) ^ -742856711;
					continue;
				case 26u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = (int)(num2 * 59877668) ^ -1538598792;
					continue;
				case 25u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1553062043) ^ 0x38162CE1;
					continue;
				case 24u:
					components = Form4.smethod_6();
					num = (int)(num2 * 2028844728) ^ -323199788;
					continue;
				case 23u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = (int)((num2 * 1978768594) ^ 0x29A3716D);
					continue;
				case 22u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -321253576) ^ 0x15CC96EE;
					continue;
				case 21u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					num = ((int)num2 * -1991251989) ^ -1892792464;
					continue;
				case 20u:
					Form4.smethod_11((Control)(object)this);
					num = (int)(num2 * 1569908586) ^ -923291507;
					continue;
				case 19u:
					num = (int)(num2 * 883543187) ^ -6838044;
					continue;
				case 18u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = ((int)num2 * -453225982) ^ -1817827133;
					continue;
				case 17u:
					textBox2 = Form4.smethod_7();
					num = ((int)num2 * -804902389) ^ -987209839;
					continue;
				case 16u:
					Form4.smethod_18(textBox3, bool_0: true);
					num = ((int)num2 * -1641164487) ^ -1893322904;
					continue;
				case 15u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = ((int)num2 * -1368298374) ^ 0x7C961D2D;
					continue;
				case 14u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 1752194133) ^ -1722838807;
					continue;
				case 13u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -967223161) ^ -1287321820;
					continue;
				case 11u:
					num = ((int)num2 * -293607) ^ 0x6C268EC7;
					continue;
				case 10u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = (int)(num2 * 2133026408) ^ -1885627707;
					continue;
				case 9u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = ((int)num2 * -1825452017) ^ -1831366710;
					continue;
				case 8u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 2080983625) ^ 0x28311359);
					continue;
				case 7u:
					num = ((int)num2 * -822157820) ^ -1955187293;
					continue;
				case 6u:
					num = (int)((num2 * 911516466) ^ 0x33525105);
					continue;
				case 5u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = ((int)num2 * -1367163503) ^ 0x4CD06185;
					continue;
				case 4u:
					num = ((int)num2 * -931896340) ^ 0x566C532A;
					continue;
				case 3u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)((num2 * 1378487774) ^ 0x2599CB36);
					continue;
				case 2u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					Form4.smethod_31((Control)(object)this, "Form4");
					num = ((int)num2 * -906185851) ^ 0x5934BD9F;
					continue;
				case 1u:
					num = ((int)num2 * -1682102107) ^ 0x4F38A6F0;
					continue;
				case 0u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = (int)((num2 * 2105008756) ^ 0x69B434F9);
					continue;
				default:
					return;
				case 12u:
					break;
				case 39u:
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
