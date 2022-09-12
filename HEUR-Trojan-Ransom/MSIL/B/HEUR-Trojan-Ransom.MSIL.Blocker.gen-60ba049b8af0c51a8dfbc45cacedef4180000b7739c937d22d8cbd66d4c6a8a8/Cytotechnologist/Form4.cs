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
			int num = 1032267538;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAB01CB5u) % 5u)
				{
				case 4u:
					num = ((int)num2 * -1359664663) ^ -1912356802;
					continue;
				case 3u:
					Form4.smethod_3(e, bool_0: true);
					num = (int)(num2 * 533340063) ^ -130377581;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1087736389;
						num4 = -1087736389;
					}
					else
					{
						num3 = -768921952;
						num4 = -768921952;
					}
					num = num3 ^ ((int)num2 * -341654604);
					continue;
				}
				default:
					return;
				case 2u:
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
		while (true)
		{
			int num = -1468899445;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xBC87D3C2u) % 8u)
				{
				case 7u:
					num = ((int)num2 * -217298755) ^ -1805303865;
					continue;
				case 6u:
					Form4.smethod_5((IDisposable)components);
					num = (int)((num2 * 1546272707) ^ 0x1642B222);
					continue;
				case 5u:
					((Form)this).Dispose(disposing);
					num = -1840323058;
					continue;
				case 3u:
					if (components != null)
					{
						num = -65204291;
						num3 = -65204291;
						continue;
					}
					goto IL_0048;
				case 2u:
					num = ((int)num2 * -147560800) ^ 0x5F2EDAC7;
					continue;
				case 1u:
					if (disposing)
					{
						num = (int)(num2 * 85048504) ^ -931223247;
						continue;
					}
					goto IL_0048;
				default:
					return;
				case 0u:
					break;
				case 4u:
					return;
					IL_0048:
					num = -70315641;
					num3 = -70315641;
					continue;
				}
				break;
			}
		}
	}

	private void InitializeComponent()
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Expected O, but got Unknown
		while (true)
		{
			int num = -672765103;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE209DE70u) % 72u)
				{
				case 71u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = (int)(num2 * 1811141879) ^ -540776967;
					continue;
				case 70u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = (int)((num2 * 1692668222) ^ 0x2F7543BE);
					continue;
				case 69u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = (int)(num2 * 916323670) ^ -1225498455;
					continue;
				case 68u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)((num2 * 1904061236) ^ 0x143C69DA);
					continue;
				case 67u:
					num = ((int)num2 * -1536447826) ^ -2009483816;
					continue;
				case 66u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = (int)(num2 * 328042861) ^ -1366254138;
					continue;
				case 65u:
					num = (int)(num2 * 1277296875) ^ -36081984;
					continue;
				case 64u:
					num = ((int)num2 * -1441567954) ^ -429574464;
					continue;
				case 63u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = (int)((num2 * 296765044) ^ 0x709A8E92);
					continue;
				case 62u:
					num = (int)((num2 * 1143971603) ^ 0x411156BC);
					continue;
				case 61u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = ((int)num2 * -672497915) ^ -1982331528;
					continue;
				case 60u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = ((int)num2 * -385220353) ^ -1451442845;
					continue;
				case 59u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = ((int)num2 * -885667230) ^ -769875520;
					continue;
				case 58u:
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = ((int)num2 * -277796671) ^ -155077574;
					continue;
				case 57u:
					num = (int)((num2 * 442973912) ^ 0x60E395E7);
					continue;
				case 56u:
					num = (int)((num2 * 2113362928) ^ 0x6AD8CB1D);
					continue;
				case 55u:
					num = ((int)num2 * -216385012) ^ 0x65CCF368;
					continue;
				case 54u:
					num = ((int)num2 * -2024235376) ^ -2108808694;
					continue;
				case 53u:
					num = (int)(num2 * 1126094174) ^ -1761966484;
					continue;
				case 52u:
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = (int)(num2 * 146609010) ^ -236647379;
					continue;
				case 51u:
					num = (int)(num2 * 161982809) ^ -1128209899;
					continue;
				case 50u:
					num = ((int)num2 * -1010859084) ^ 0x31360B31;
					continue;
				case 49u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = ((int)num2 * -364944462) ^ -744333607;
					continue;
				case 48u:
					button1 = Form4.smethod_8();
					num = (int)((num2 * 545751307) ^ 0x1FF0771E);
					continue;
				case 47u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = (int)((num2 * 1528774389) ^ 0x6FBF2D7E);
					continue;
				case 46u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 1651698029) ^ -1403703809;
					continue;
				case 45u:
					Form4.smethod_37((Control)(object)this);
					num = ((int)num2 * -845405662) ^ 0x52CB49C1;
					continue;
				case 44u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = (int)((num2 * 475081035) ^ 0x642147AD);
					continue;
				case 43u:
					num = (int)(num2 * 1767831409) ^ -844667060;
					continue;
				case 42u:
					num = ((int)num2 * -1868678139) ^ 0x156B6645;
					continue;
				case 41u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = (int)((num2 * 1597351864) ^ 0x50A0B9D1);
					continue;
				case 40u:
					num = (int)((num2 * 99581471) ^ 0x13192F7E);
					continue;
				case 39u:
					num = (int)(num2 * 705895740) ^ -349218521;
					continue;
				case 38u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = ((int)num2 * -1897148978) ^ -645847615;
					continue;
				case 37u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -1347534554) ^ -1050011522;
					continue;
				case 36u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -177262026) ^ 0x329762B1;
					continue;
				case 35u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = ((int)num2 * -1514533341) ^ -1862231590;
					continue;
				case 33u:
					num = (int)((num2 * 1007806399) ^ 0x911DFFA);
					continue;
				case 32u:
					num = (int)(num2 * 943540948) ^ -1542479911;
					continue;
				case 31u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -290197410) ^ -777560284;
					continue;
				case 30u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = (int)(num2 * 565282490) ^ -2091940936;
					continue;
				case 29u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -1228624794) ^ -1210789855;
					continue;
				case 28u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = ((int)num2 * -666244172) ^ 0x72764BBC;
					continue;
				case 27u:
					textBox3 = Form4.smethod_7();
					num = ((int)num2 * -1421778370) ^ 0xF0F765A;
					continue;
				case 26u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -1233728214) ^ 0x1C4E4963;
					continue;
				case 25u:
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = ((int)num2 * -651854539) ^ -1765400962;
					continue;
				case 24u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = (int)(num2 * 1767353550) ^ -469258756;
					continue;
				case 23u:
					num = (int)((num2 * 1552305944) ^ 0x71A12B68);
					continue;
				case 22u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = (int)(num2 * 656911863) ^ -981930165;
					continue;
				case 21u:
					Form4.smethod_18(textBox2, bool_0: true);
					num = ((int)num2 * -1320404558) ^ 0xF87CC45;
					continue;
				case 20u:
					num = ((int)num2 * -1221748558) ^ -629374300;
					continue;
				case 19u:
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -428262059) ^ 0x449A944D;
					continue;
				case 18u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = ((int)num2 * -883905092) ^ 0x6176DD55;
					continue;
				case 17u:
					components = Form4.smethod_6();
					textBox1 = Form4.smethod_7();
					num = (int)(num2 * 639929235) ^ -1561849485;
					continue;
				case 16u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1626583995) ^ 0xCCDC51A;
					continue;
				case 14u:
					errorProvider1 = Form4.smethod_9(components);
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					Form4.smethod_11((Control)(object)this);
					num = (int)(num2 * 544589888) ^ -552589733;
					continue;
				case 13u:
					num = (int)(num2 * 868685872) ^ -832354789;
					continue;
				case 12u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1089241483) ^ -1022570487;
					continue;
				case 11u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = ((int)num2 * -1210145240) ^ -899655696;
					continue;
				case 10u:
					num = (int)(num2 * 316443370) ^ -1166159351;
					continue;
				case 9u:
					num = (int)(num2 * 1139359656) ^ -1005324896;
					continue;
				case 8u:
					textBox2 = Form4.smethod_7();
					num = ((int)num2 * -1164612746) ^ 0xCB78D8B;
					continue;
				case 7u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 1979373372) ^ -1589555336;
					continue;
				case 6u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = ((int)num2 * -801728668) ^ -2087783046;
					continue;
				case 5u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = (int)(num2 * 1326485678) ^ -1532711693;
					continue;
				case 4u:
					Form4.smethod_18(textBox3, bool_0: true);
					num = ((int)num2 * -767872716) ^ 0x72F3505E;
					continue;
				case 3u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -944641019) ^ -711197917;
					continue;
				case 2u:
					Form4.smethod_31((Control)(object)this, "Form4");
					num = (int)((num2 * 818207817) ^ 0x609164AD);
					continue;
				case 1u:
					num = (int)(num2 * 30403848) ^ -1872630196;
					continue;
				case 0u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = (int)((num2 * 1785701072) ^ 0x54A98E56);
					continue;
				default:
					return;
				case 34u:
					break;
				case 15u:
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
