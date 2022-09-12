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
			int num = 339809898;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x30536F8Au) % 5u)
				{
				case 4u:
				{
					int num3;
					int num4;
					if (Form4.smethod_2(e) != ' ')
					{
						num3 = -626392132;
						num4 = -626392132;
					}
					else
					{
						num3 = -948046337;
						num4 = -948046337;
					}
					num = num3 ^ ((int)num2 * -2064006395);
					continue;
				}
				case 3u:
					Form4.smethod_3(e, bool_0: true);
					num = ((int)num2 * -314496696) ^ -1619401183;
					continue;
				case 0u:
					num = (int)(num2 * 2140460228) ^ -867190384;
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
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
		if (!disposing)
		{
			goto IL_0009;
		}
		goto IL_0025;
		IL_0025:
		int num = 1802193871;
		goto IL_0061;
		IL_0061:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x7DE082EBu) % 7u)
			{
			case 5u:
				num = (int)(num2 * 1192042485) ^ -467532480;
				continue;
			case 3u:
				break;
			case 2u:
				num = ((int)num2 * -488381878) ^ 0x7881A7AA;
				continue;
			case 1u:
				((Form)this).Dispose(disposing);
				num = 652356957;
				continue;
			case 0u:
				Form4.smethod_5((IDisposable)components);
				num = ((int)num2 * -122897766) ^ 0x3416A172;
				continue;
			default:
				return;
			case 6u:
				goto IL_008e;
			case 4u:
				return;
			}
			break;
			IL_008e:
			if (components != null)
			{
				num = 858826420;
				num3 = 858826420;
				continue;
			}
			goto IL_0009;
		}
		goto IL_0025;
		IL_0009:
		num = 862784656;
		num3 = 862784656;
		goto IL_0061;
	}

	private void InitializeComponent()
	{
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected O, but got Unknown
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected O, but got Unknown
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Expected O, but got Unknown
		components = Form4.smethod_6();
		textBox1 = Form4.smethod_7();
		while (true)
		{
			int num = 1024502844;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x164717BBu) % 63u)
				{
				case 62u:
					num = ((int)num2 * -682488355) ^ 0x16C6A399;
					continue;
				case 61u:
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -384786291) ^ 0x64A0C23F;
					continue;
				case 60u:
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = (int)(num2 * 106094476) ^ -1606820146;
					continue;
				case 59u:
					Form4.smethod_11((Control)(object)this);
					num = ((int)num2 * -586474897) ^ -363575481;
					continue;
				case 58u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -833559522) ^ -1354156275;
					continue;
				case 57u:
					num = ((int)num2 * -1888596044) ^ 0x493B5523;
					continue;
				case 56u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = ((int)num2 * -911757885) ^ 0x2B3CAB99;
					continue;
				case 55u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = (int)((num2 * 624805415) ^ 0x6090B18);
					continue;
				case 54u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -311030517) ^ 0x76631678;
					continue;
				case 53u:
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					num = (int)(num2 * 1957661275) ^ -1278174292;
					continue;
				case 52u:
					Form4.smethod_18(textBox3, bool_0: true);
					num = ((int)num2 * -1335384735) ^ 0x34F76C2B;
					continue;
				case 50u:
					textBox2 = Form4.smethod_7();
					num = (int)((num2 * 708277330) ^ 0x2EED65C0);
					continue;
				case 49u:
					num = (int)(num2 * 1958951780) ^ -1669481374;
					continue;
				case 48u:
					num = ((int)num2 * -684194467) ^ -1008563308;
					continue;
				case 47u:
					num = (int)(num2 * 1453671981) ^ -2078415491;
					continue;
				case 46u:
					Form4.smethod_37((Control)(object)this);
					num = (int)(num2 * 599641303) ^ -1534438612;
					continue;
				case 45u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)(num2 * 1856798291) ^ -1595002033;
					continue;
				case 44u:
					num = (int)((num2 * 994727931) ^ 0x7544C618);
					continue;
				case 43u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = ((int)num2 * -1770810047) ^ -2082338601;
					continue;
				case 42u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = ((int)num2 * -213719394) ^ 0x5F7867E9;
					continue;
				case 41u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = (int)((num2 * 220668567) ^ 0x6B29D132);
					continue;
				case 40u:
					Form4.smethod_31((Control)(object)this, "Form4");
					Form4.smethod_32((Form)(object)this, bool_0: false);
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1711188322) ^ -1799108178;
					continue;
				case 39u:
					num = ((int)num2 * -233256321) ^ -1651118792;
					continue;
				case 38u:
					num = (int)((num2 * 1482486274) ^ 0x1EF107F1);
					continue;
				case 37u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					num = (int)(num2 * 180001168) ^ -1074787406;
					continue;
				case 36u:
					num = ((int)num2 * -922095316) ^ 0x5DAEB1F;
					continue;
				case 35u:
					num = (int)((num2 * 55101848) ^ 0x132A25FB);
					continue;
				case 34u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					num = ((int)num2 * -436421647) ^ -68017564;
					continue;
				case 33u:
					button1 = Form4.smethod_8();
					num = ((int)num2 * -497155389) ^ 0x676B0AC9;
					continue;
				case 32u:
					Form4.smethod_29((Form)(object)this, bool_0: false);
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = (int)((num2 * 1270636208) ^ 0x576345B);
					continue;
				case 31u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = (int)((num2 * 1261992227) ^ 0x1275D42C);
					continue;
				case 30u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = (int)(num2 * 1499294497) ^ -963827070;
					continue;
				case 29u:
					num = ((int)num2 * -805821054) ^ -1335026494;
					continue;
				case 28u:
					num = ((int)num2 * -252120948) ^ -254310696;
					continue;
				case 27u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = (int)(num2 * 1503665430) ^ -809581233;
					continue;
				case 26u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)(num2 * 84440156) ^ -1109208474;
					continue;
				case 24u:
					Form4.smethod_18(textBox2, bool_0: true);
					num = ((int)num2 * -2102607119) ^ 0x2336742;
					continue;
				case 23u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = (int)((num2 * 269996129) ^ 0x157EBF9B);
					continue;
				case 22u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = (int)(num2 * 430716456) ^ -723597307;
					continue;
				case 21u:
					num = (int)(num2 * 1760114733) ^ -6098214;
					continue;
				case 20u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 342571012) ^ -2061415617;
					continue;
				case 19u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = (int)(num2 * 1709187933) ^ -1379129900;
					continue;
				case 18u:
					num = ((int)num2 * -1903807297) ^ 0x3C9CDB16;
					continue;
				case 17u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = (int)(num2 * 433111550) ^ -1939944451;
					continue;
				case 16u:
					num = (int)((num2 * 1727935352) ^ 0x2133E3B3);
					continue;
				case 15u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1569984069) ^ -1478969781;
					continue;
				case 14u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = ((int)num2 * -1057246807) ^ 0x6224D0CC;
					continue;
				case 13u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -743156079) ^ -336121325;
					continue;
				case 12u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -78421764) ^ 0x5E86887B;
					continue;
				case 11u:
					num = ((int)num2 * -354244750) ^ -1456381034;
					continue;
				case 10u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = (int)((num2 * 379540874) ^ 0x735B4407);
					continue;
				case 9u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = (int)(num2 * 998215752) ^ -1092528949;
					continue;
				case 8u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 80690657) ^ 0x1857346C);
					continue;
				case 7u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = (int)(num2 * 399738043) ^ -1207327435;
					continue;
				case 6u:
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = (int)((num2 * 1841978606) ^ 0x42184436);
					continue;
				case 5u:
					num = (int)((num2 * 1836681430) ^ 0x2A31596B);
					continue;
				case 4u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = (int)(num2 * 1642593787) ^ -2004720978;
					continue;
				case 3u:
					textBox3 = Form4.smethod_7();
					num = (int)((num2 * 907260482) ^ 0x495C08C2);
					continue;
				case 2u:
					errorProvider1 = Form4.smethod_9(components);
					num = ((int)num2 * -1376951618) ^ 0x506D9852;
					continue;
				case 1u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = (int)((num2 * 1938293948) ^ 0x64BE17D9);
					continue;
				case 0u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = ((int)num2 * -1421619915) ^ 0x6F6BB078;
					continue;
				default:
					return;
				case 51u:
					break;
				case 25u:
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
