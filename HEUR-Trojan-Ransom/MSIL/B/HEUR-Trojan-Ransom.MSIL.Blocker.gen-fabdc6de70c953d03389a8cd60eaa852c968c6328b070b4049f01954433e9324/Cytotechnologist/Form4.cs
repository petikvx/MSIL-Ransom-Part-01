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
			int num = 193795155;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x18348AD0u) % 5u)
				{
				case 3u:
				{
					int num3;
					int num4;
					if (Form4.smethod_2(e) != ' ')
					{
						num3 = -600216690;
						num4 = -600216690;
					}
					else
					{
						num3 = -913631751;
						num4 = -913631751;
					}
					num = num3 ^ ((int)num2 * -794165795);
					continue;
				}
				case 2u:
					num = ((int)num2 * -1942169452) ^ -1223062871;
					continue;
				case 1u:
					Form4.smethod_3(e, bool_0: true);
					num = ((int)num2 * -1411942027) ^ 0x2FADB15A;
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
		if (disposing)
		{
			goto IL_0082;
		}
		int num = 0;
		goto IL_00c6;
		IL_00c6:
		bool flag = (byte)num != 0;
		int num2 = -29535763;
		goto IL_0087;
		IL_0082:
		num2 = -1434611743;
		goto IL_0087;
		IL_0087:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x88233119u) % 9u)
			{
			case 6u:
				num2 = (int)((num3 * 581827236) ^ 0x3D3E0019);
				continue;
			case 5u:
				num2 = (int)(num3 * 194155111) ^ -85139547;
				continue;
			case 4u:
				Form4.smethod_5((IDisposable)components);
				num2 = (int)(num3 * 914944758) ^ -1053496228;
				continue;
			case 3u:
				((Form)this).Dispose(disposing);
				num2 = -1989175482;
				continue;
			case 2u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 631393095;
					num5 = 631393095;
				}
				else
				{
					num4 = 1902169601;
					num5 = 1902169601;
				}
				num2 = num4 ^ ((int)num3 * -1028938263);
				continue;
			}
			case 1u:
				num2 = (int)(num3 * 538713198) ^ -1058460107;
				continue;
			case 0u:
				break;
			default:
				return;
			case 8u:
				goto IL_00bd;
			case 7u:
				return;
			}
			break;
		}
		goto IL_0082;
		IL_00bd:
		num = ((components != null) ? 1 : 0);
		goto IL_00c6;
	}

	private void InitializeComponent()
	{
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected O, but got Unknown
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Expected O, but got Unknown
		//IL_076a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0774: Expected O, but got Unknown
		components = Form4.smethod_6();
		while (true)
		{
			int num = 547514695;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1736F89Au) % 65u)
				{
				case 63u:
					Form4.smethod_18(textBox3, bool_0: true);
					num = (int)((num2 * 1973423588) ^ 0x930CDFD);
					continue;
				case 62u:
					errorProvider1 = Form4.smethod_9(components);
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = (int)((num2 * 491009313) ^ 0x28F057F3);
					continue;
				case 61u:
					num = (int)(num2 * 913550370) ^ -1241346279;
					continue;
				case 60u:
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = (int)((num2 * 1915910642) ^ 0x489C95A1);
					continue;
				case 59u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = (int)(num2 * 452454601) ^ -1156214626;
					continue;
				case 58u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -236345850) ^ -354150703;
					continue;
				case 57u:
					num = (int)(num2 * 399859704) ^ -852326645;
					continue;
				case 56u:
					num = (int)(num2 * 1131648132) ^ -755866655;
					continue;
				case 55u:
					num = (int)((num2 * 2094069855) ^ 0x1E7275A4);
					continue;
				case 54u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = (int)(num2 * 65721948) ^ -2004196683;
					continue;
				case 53u:
					num = (int)((num2 * 1951810072) ^ 0x1D277A3D);
					continue;
				case 52u:
					num = ((int)num2 * -2036435917) ^ 0x3540800C;
					continue;
				case 51u:
					num = (int)((num2 * 1086511947) ^ 0x70F71EC8);
					continue;
				case 50u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = (int)(num2 * 1981856414) ^ -1522375184;
					continue;
				case 49u:
					textBox1 = Form4.smethod_7();
					textBox2 = Form4.smethod_7();
					num = ((int)num2 * -204221048) ^ 0x1779C7DE;
					continue;
				case 48u:
					Form4.smethod_11((Control)(object)this);
					num = (int)((num2 * 795430212) ^ 0x2EE89CA1);
					continue;
				case 47u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = ((int)num2 * -945000928) ^ 0x554296EE;
					continue;
				case 45u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = (int)(num2 * 1600590045) ^ -1008230985;
					continue;
				case 44u:
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = ((int)num2 * -1572852893) ^ 0x4A300C93;
					continue;
				case 43u:
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)((num2 * 1840784641) ^ 0x5490B08);
					continue;
				case 42u:
					num = (int)(num2 * 1600679792) ^ -556877404;
					continue;
				case 41u:
					num = (int)((num2 * 1091714088) ^ 0x12143368);
					continue;
				case 40u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = ((int)num2 * -2130384526) ^ 0x7544FF6E;
					continue;
				case 39u:
					num = ((int)num2 * -613935825) ^ -108868404;
					continue;
				case 38u:
					Form4.smethod_18(textBox2, bool_0: true);
					num = ((int)num2 * -496240877) ^ 0x114EF63;
					continue;
				case 37u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = (int)(num2 * 1366613186) ^ -1965680584;
					continue;
				case 36u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -1567355464) ^ -1392927676;
					continue;
				case 35u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = (int)((num2 * 2127600659) ^ 0x3E60D8FB);
					continue;
				case 34u:
					textBox3 = Form4.smethod_7();
					button1 = Form4.smethod_8();
					num = (int)((num2 * 1449235384) ^ 0x7D63DB25);
					continue;
				case 33u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -1928901562) ^ 0x54A2DDDD;
					continue;
				case 32u:
					num = (int)((num2 * 2080330142) ^ 0x650A5D5A);
					continue;
				case 31u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = (int)(num2 * 1347231861) ^ -429558617;
					continue;
				case 30u:
					num = ((int)num2 * -964150352) ^ -509134840;
					continue;
				case 29u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = ((int)num2 * -147417580) ^ 0x1DB185FC;
					continue;
				case 28u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -1217121731) ^ 0x58730541;
					continue;
				case 27u:
					num = ((int)num2 * -1489276457) ^ 0x1537007C;
					continue;
				case 26u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					Form4.smethod_13((Control)(object)button1, "button1");
					num = ((int)num2 * -727573410) ^ 0x6A6200C5;
					continue;
				case 25u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = (int)(num2 * 1180586780) ^ -1393027817;
					continue;
				case 24u:
					num = (int)(num2 * 1311995247) ^ -1489353119;
					continue;
				case 23u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = (int)((num2 * 1959354195) ^ 0x7B8CD67E);
					continue;
				case 22u:
					num = (int)(num2 * 585873639) ^ -538925642;
					continue;
				case 21u:
					Form4.smethod_37((Control)(object)this);
					num = ((int)num2 * -430471843) ^ -1500726922;
					continue;
				case 20u:
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = (int)((num2 * 189201848) ^ 0x1C579D3C);
					continue;
				case 19u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1582510520) ^ -363118293;
					continue;
				case 18u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -1072132054) ^ 0x54315244;
					continue;
				case 17u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = (int)((num2 * 1893577925) ^ 0x7B6FFC39);
					continue;
				case 16u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1427313452) ^ 0x54D95BE5);
					continue;
				case 15u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -557793714) ^ 0x3607B514;
					continue;
				case 14u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 861855923) ^ -60356946;
					continue;
				case 13u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 1801595726) ^ 0x5F9BA411);
					continue;
				case 12u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = ((int)num2 * -1562078338) ^ 0x10B6AF87;
					continue;
				case 11u:
					num = (int)((num2 * 765251902) ^ 0x5E0C3687);
					continue;
				case 10u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)(num2 * 579688099) ^ -880482687;
					continue;
				case 9u:
					num = ((int)num2 * -856944228) ^ -706933739;
					continue;
				case 8u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = ((int)num2 * -474118481) ^ -769874405;
					continue;
				case 7u:
					num = ((int)num2 * -292484246) ^ 0x6423940;
					continue;
				case 6u:
					num = ((int)num2 * -625236652) ^ -1990405623;
					continue;
				case 5u:
					num = (int)((num2 * 763605949) ^ 0x716D9D9D);
					continue;
				case 4u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 1063105419) ^ -357206549;
					continue;
				case 3u:
					Form4.smethod_31((Control)(object)this, "Form4");
					num = ((int)num2 * -1787958773) ^ -988320682;
					continue;
				case 2u:
					num = ((int)num2 * -808964718) ^ 0x17A3DCDF;
					continue;
				case 1u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -571141651) ^ -1355203418;
					continue;
				case 0u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = (int)(num2 * 1319244653) ^ -573180942;
					continue;
				default:
					return;
				case 64u:
					break;
				case 46u:
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
