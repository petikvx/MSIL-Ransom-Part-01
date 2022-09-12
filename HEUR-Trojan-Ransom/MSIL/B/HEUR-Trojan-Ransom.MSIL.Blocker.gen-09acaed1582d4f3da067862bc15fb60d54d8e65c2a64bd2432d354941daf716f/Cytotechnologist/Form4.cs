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
			int num = -284007756;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA97CFC92u) % 3u)
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
				num = ((int)num2 * -1847837667) ^ -162663036;
			}
		}
	}

	private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		while (true)
		{
			int num = 2069612455;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA40B459u) % 5u)
				{
				case 4u:
				{
					int num3;
					int num4;
					if (Form4.smethod_2(e) != ' ')
					{
						num3 = -314175742;
						num4 = -314175742;
					}
					else
					{
						num3 = -1170263789;
						num4 = -1170263789;
					}
					num = num3 ^ (int)(num2 * 576981872);
					continue;
				}
				case 3u:
					Form4.smethod_3(e, bool_0: true);
					num = (int)(num2 * 1966326069) ^ -1954640359;
					continue;
				case 2u:
					num = ((int)num2 * -1307433873) ^ -654245364;
					continue;
				default:
					return;
				case 0u:
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
		while (true)
		{
			int num = -1425986408;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA9FA4D85u) % 3u)
				{
				case 1u:
					goto IL_000d;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_000d:
				num = (int)((num2 * 528241547) ^ 0x24DCA3FC);
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_0047;
		}
		int num = 0;
		goto IL_00a0;
		IL_0097:
		num = ((components != null) ? 1 : 0);
		goto IL_00a0;
		IL_0047:
		int num2 = 1285752823;
		goto IL_006a;
		IL_006a:
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x1FA54C6Eu) % 7u)
			{
			case 6u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 1409989412;
					num5 = 1409989412;
				}
				else
				{
					num4 = 1539141326;
					num5 = 1539141326;
				}
				num2 = num4 ^ ((int)num3 * -864417792);
				continue;
			}
			case 5u:
				Form4.smethod_5((IDisposable)components);
				num2 = ((int)num3 * -217579307) ^ -1399523702;
				continue;
			case 4u:
				break;
			case 1u:
				num2 = (int)((num3 * 1344301203) ^ 0x6178F280);
				continue;
			case 0u:
				num2 = (int)(num3 * 1854348946) ^ -1187452288;
				continue;
			case 2u:
				goto IL_0097;
			default:
				((Form)this).Dispose(disposing);
				return;
			}
			break;
		}
		goto IL_0047;
		IL_00a0:
		flag = (byte)num != 0;
		num2 = 1064147309;
		goto IL_006a;
	}

	private void InitializeComponent()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		while (true)
		{
			int num = -2134992331;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCE003B63u) % 69u)
				{
				case 68u:
					num = ((int)num2 * -585652294) ^ 0x7A820F6;
					continue;
				case 66u:
					button1 = Form4.smethod_8();
					errorProvider1 = Form4.smethod_9(components);
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -2048014310) ^ 0x5CD3DC91;
					continue;
				case 65u:
					Form4.smethod_37((Control)(object)this);
					num = (int)(num2 * 205132445) ^ -754444442;
					continue;
				case 64u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = ((int)num2 * -1879198936) ^ 0x77021033;
					continue;
				case 63u:
					Form4.smethod_19((Control)(object)button1, "Добавить");
					num = (int)((num2 * 544850709) ^ 0x4F55C89D);
					continue;
				case 62u:
					num = (int)(num2 * 1858571578) ^ -669207996;
					continue;
				case 60u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					num = ((int)num2 * -1725795554) ^ -1438307394;
					continue;
				case 59u:
					num = (int)(num2 * 1291485777) ^ -1705075420;
					continue;
				case 58u:
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)((num2 * 382987299) ^ 0x1A0D3129);
					continue;
				case 57u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)((num2 * 1069103586) ^ 0x22009A66);
					continue;
				case 56u:
					num = (int)((num2 * 2029039721) ^ 0x23A4A538);
					continue;
				case 55u:
					Form4.smethod_19((Control)(object)this, "Регистрация");
					num = ((int)num2 * -1077895990) ^ -1434476256;
					continue;
				case 54u:
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					num = ((int)num2 * -1867370246) ^ -899760602;
					continue;
				case 53u:
					Form4.smethod_11((Control)(object)this);
					num = (int)((num2 * 1323304397) ^ 0x64DAA041);
					continue;
				case 52u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = ((int)num2 * -1854779442) ^ 0x67CF1DE0;
					continue;
				case 51u:
					num = (int)((num2 * 778398964) ^ 0x1F6CF7CE);
					continue;
				case 50u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1802021555) ^ -1538255468;
					continue;
				case 49u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = (int)((num2 * 43584111) ^ 0x371A54C8);
					continue;
				case 48u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = ((int)num2 * -2005574685) ^ -1130835844;
					continue;
				case 47u:
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = (int)((num2 * 1831325430) ^ 0x216F7068);
					continue;
				case 46u:
					num = (int)((num2 * 57471327) ^ 0x1CD8C409);
					continue;
				case 45u:
					Form4.smethod_31((Control)(object)this, "Form4");
					num = ((int)num2 * -1195022577) ^ -1996279073;
					continue;
				case 44u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1744821459) ^ 0x78839A2C;
					continue;
				case 43u:
					num = (int)(num2 * 1372135011) ^ -650317917;
					continue;
				case 42u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = ((int)num2 * -1647499457) ^ -633607913;
					continue;
				case 41u:
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = (int)((num2 * 1972809456) ^ 0x3108F13);
					continue;
				case 40u:
					num = (int)(num2 * 120374315) ^ -1423728092;
					continue;
				case 39u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)((num2 * 1040041712) ^ 0x5D967FD0);
					continue;
				case 38u:
					components = Form4.smethod_6();
					num = ((int)num2 * -811660428) ^ 0x32E1107D;
					continue;
				case 37u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 1408711868) ^ -1051453841;
					continue;
				case 36u:
					Form4.smethod_18(textBox3, bool_0: true);
					num = (int)(num2 * 1073494466) ^ -1101030106;
					continue;
				case 35u:
					num = ((int)num2 * -968877314) ^ -1351026726;
					continue;
				case 34u:
					num = (int)(num2 * 956353026) ^ -69329782;
					continue;
				case 33u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = (int)((num2 * 574765747) ^ 0x4E2A0B76);
					continue;
				case 32u:
					num = (int)((num2 * 1205139334) ^ 0x1A1E5E58);
					continue;
				case 31u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = ((int)num2 * -944430050) ^ 0x7716174;
					continue;
				case 30u:
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					num = ((int)num2 * -995253594) ^ 0x165B304A;
					continue;
				case 29u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					num = (int)(num2 * 307023254) ^ -2039454561;
					continue;
				case 28u:
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = (int)(num2 * 918947063) ^ -407151167;
					continue;
				case 27u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 1389175432) ^ -2076801560;
					continue;
				case 26u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = (int)((num2 * 521730228) ^ 0x7ADD0FC9);
					continue;
				case 25u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = ((int)num2 * -1498379767) ^ 0x3779EB7F;
					continue;
				case 24u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					num = (int)(num2 * 511755881) ^ -130766874;
					continue;
				case 23u:
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = ((int)num2 * -1713608842) ^ -1286793664;
					continue;
				case 22u:
					Form4.smethod_36((Control)(object)this, bool_0: false);
					num = (int)(num2 * 413996617) ^ -1458499501;
					continue;
				case 21u:
					num = (int)((num2 * 1835672787) ^ 0x263D1287);
					continue;
				case 20u:
					num = (int)((num2 * 154143368) ^ 0x7777E5A2);
					continue;
				case 19u:
					num = (int)(num2 * 250365119) ^ -1737148038;
					continue;
				case 18u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = ((int)num2 * -301244209) ^ 0x2388C26A;
					continue;
				case 17u:
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = ((int)num2 * -18493574) ^ -182227371;
					continue;
				case 16u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -339264160) ^ 0xE205BD9;
					continue;
				case 15u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1345074931) ^ -1695670886;
					continue;
				case 14u:
					num = (int)((num2 * 85499192) ^ 0x3E9CB9FA);
					continue;
				case 13u:
					num = ((int)num2 * -295840180) ^ -1276907564;
					continue;
				case 12u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1614068729) ^ 0x2A3F4363;
					continue;
				case 11u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 620788448) ^ -2137894003;
					continue;
				case 10u:
					textBox1 = Form4.smethod_7();
					textBox2 = Form4.smethod_7();
					textBox3 = Form4.smethod_7();
					num = (int)((num2 * 1758717117) ^ 0x554C536F);
					continue;
				case 9u:
					num = (int)((num2 * 1933375385) ^ 0x2B3C04BF);
					continue;
				case 8u:
					num = (int)(num2 * 385225987) ^ -387988188;
					continue;
				case 7u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					num = ((int)num2 * -1930640024) ^ 0x93BEA22;
					continue;
				case 6u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1932585156) ^ 0x621BA2ED;
					continue;
				case 5u:
					num = (int)(num2 * 1579943877) ^ -1315820316;
					continue;
				case 4u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = (int)(num2 * 871236474) ^ -297758271;
					continue;
				case 3u:
					Form4.smethod_18(textBox2, bool_0: true);
					num = (int)(num2 * 989598802) ^ -1115623308;
					continue;
				case 2u:
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = ((int)num2 * -1602047696) ^ -1123838792;
					continue;
				case 1u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = (int)((num2 * 412394416) ^ 0x5251623D);
					continue;
				case 0u:
					num = (int)((num2 * 892737755) ^ 0x52352221);
					continue;
				default:
					return;
				case 61u:
					break;
				case 67u:
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
