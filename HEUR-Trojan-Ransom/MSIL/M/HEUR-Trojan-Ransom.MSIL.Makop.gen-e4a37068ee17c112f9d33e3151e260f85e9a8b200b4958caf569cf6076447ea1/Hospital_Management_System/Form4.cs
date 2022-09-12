using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hospital_Management_System.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Hospital_Management_System;

[DesignerGenerated]
public class Form4 : Form
{
	private IContainer components;

	private OleDbConnection myconnection;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button OkBtn
	{
		[CompilerGenerated]
		get
		{
			return _OkBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = Button1_Click;
			Button okBtn = default(Button);
			while (true)
			{
				int num = 1257907236;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6FDBAB1Cu) % 7u)
					{
					case 6u:
						_OkBtn = value;
						num = 1182815628;
						continue;
					case 4u:
					{
						okBtn = _OkBtn;
						int num5;
						int num6;
						if (okBtn != null)
						{
							num5 = -186085460;
							num6 = -186085460;
						}
						else
						{
							num5 = -529883532;
							num6 = -529883532;
						}
						num = num5 ^ (int)(num2 * 1731214722);
						continue;
					}
					case 3u:
					{
						okBtn = _OkBtn;
						int num3;
						int num4;
						if (okBtn == null)
						{
							num3 = -416149952;
							num4 = -416149952;
						}
						else
						{
							num3 = -1086600580;
							num4 = -1086600580;
						}
						num = num3 ^ (int)(num2 * 127086148);
						continue;
					}
					case 2u:
						Form4.smethod_32((Control)(object)okBtn, eventHandler_);
						num = ((int)num2 * -20844801) ^ 0x5DDDB524;
						continue;
					case 0u:
						Form4.smethod_31((Control)(object)okBtn, eventHandler_);
						num = (int)(num2 * 934720007) ^ -1579650016;
						continue;
					default:
						return;
					case 5u:
						break;
					case 1u:
						return;
					}
					break;
				}
			}
		}
	}

	public Form4()
	{
		while (true)
		{
			int num = 85897516;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x58B8B6FFu) % 7u)
				{
				case 6u:
					num = ((int)num2 * -1300499249) ^ 0x41062D27;
					continue;
				case 5u:
					InitializeComponent();
					num = (int)(num2 * 2054657045) ^ -516348758;
					continue;
				case 3u:
					myconnection = Form4.smethod_1();
					num = (int)(num2 * 1845383649) ^ -1284325522;
					continue;
				case 1u:
					Form4.smethod_0((Form)(object)this, (EventHandler)Form4_Load);
					num = ((int)num2 * -2077725948) ^ -2029631035;
					continue;
				case 0u:
					num = (int)((num2 * 354484317) ^ 0x60ADB484);
					continue;
				default:
					return;
				case 4u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing)
			{
				goto IL_0007;
			}
			int num = 0;
			goto IL_0083;
			IL_0083:
			bool flag = (byte)num != 0;
			int num2 = -1829919753;
			goto IL_0051;
			IL_0007:
			num2 = -203909988;
			goto IL_0051;
			IL_0051:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xCEB59666u) % 6u)
				{
				case 5u:
					break;
				case 4u:
					Form4.smethod_2((IDisposable)components);
					num2 = ((int)num3 * -1402756865) ^ -212033019;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 540670850;
						num5 = 540670850;
					}
					else
					{
						num4 = 1607764509;
						num5 = 1607764509;
					}
					num2 = num4 ^ (int)(num3 * 1387565278);
					continue;
				}
				case 1u:
					num2 = -524206102;
					continue;
				default:
					return;
				case 2u:
					goto IL_007a;
				case 0u:
					return;
				}
				break;
			}
			goto IL_0007;
			IL_007a:
			num = ((components != null) ? 1 : 0);
			goto IL_0083;
		}
		finally
		{
			while (true)
			{
				IL_00d4:
				int num6 = -1011230263;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0xCEB59666u) % 4u)
					{
					case 3u:
						((Form)this).Dispose(disposing);
						num6 = ((int)num3 * -1846386675) ^ 0x1A873BAF;
						continue;
					case 2u:
						num6 = (int)(num3 * 1599044241) ^ -422699923;
						continue;
					default:
						goto end_IL_00b3;
					case 0u:
						break;
					case 1u:
						goto end_IL_00b3;
					}
					goto IL_00d4;
					continue;
					end_IL_00b3:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		while (true)
		{
			int num = 247971498;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x488981F4u) % 54u)
				{
				case 53u:
					Form4.smethod_8((Control)(object)TextBox1, Form4.smethod_7("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Form4.smethod_9((Control)(object)TextBox1, new Point(60, 107));
					num = (int)((num2 * 1684246934) ^ 0x4A909BD);
					continue;
				case 52u:
					Form4.smethod_30((Control)(object)this);
					num = (int)(num2 * 1121013611) ^ -1717456418;
					continue;
				case 51u:
					Form4.smethod_10((Control)(object)Label1, "Label1");
					num = ((int)num2 * -848918660) ^ 0x65DAB3B6;
					continue;
				case 50u:
					Form4.smethod_27((Control)(object)this, "Form4");
					num = (int)(num2 * 102129159) ^ -1525252359;
					continue;
				case 49u:
					num = (int)(num2 * 1507112655) ^ -1625141152;
					continue;
				case 48u:
					num = ((int)num2 * -250059367) ^ -1798369471;
					continue;
				case 47u:
					Form4.smethod_10((Control)(object)TextBox1, "TextBox1");
					num = ((int)num2 * -1375041637) ^ -1927292682;
					continue;
				case 46u:
					Form4.smethod_8((Control)(object)Label1, Form4.smethod_7("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -679522896) ^ 0xB60E8F9;
					continue;
				case 45u:
					Form4.smethod_10((Control)(object)OkBtn, "OkBtn");
					num = ((int)num2 * -1748371260) ^ 0x77710369;
					continue;
				case 44u:
					num = (int)(num2 * 1081923225) ^ -114192925;
					continue;
				case 43u:
					Form4.smethod_29((Control)(object)this, bool_0: false);
					num = ((int)num2 * -425957343) ^ -270152021;
					continue;
				case 42u:
					Form4.smethod_8((Control)(object)OkBtn, Form4.smethod_7("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -2062989134) ^ 0x6A22510E;
					continue;
				case 41u:
					Form4.smethod_9((Control)(object)OkBtn, new Point(77, 157));
					num = (int)((num2 * 1344569776) ^ 0x2CBBEB44);
					continue;
				case 40u:
					Form4.smethod_17((ButtonBase)(object)OkBtn, "Ok");
					num = (int)((num2 * 1095503239) ^ 0x5ECFA145);
					continue;
				case 39u:
					num = ((int)num2 * -848756436) ^ 0x4DEBC48E;
					continue;
				case 38u:
					Form4.smethod_11((Control)(object)Label1, new Size(200, 49));
					num = ((int)num2 * -2059102339) ^ 0x74443E1F;
					continue;
				case 37u:
					num = ((int)num2 * -541590224) ^ 0x61AF6A84;
					continue;
				case 36u:
					Form4.smethod_24(Form4.smethod_23((Control)(object)this), (Control)(object)TextBox1);
					num = ((int)num2 * -1824975284) ^ -2069230143;
					continue;
				case 35u:
					Form4.smethod_21((Form)(object)this, Color.White);
					num = ((int)num2 * -922461098) ^ 0x31E12922;
					continue;
				case 34u:
					Form4.smethod_15((ButtonBase)(object)OkBtn, Color.MidnightBlue);
					num = (int)(num2 * 363658501) ^ -1508228714;
					continue;
				case 33u:
					Form4.smethod_11((Control)(object)TextBox1, new Size(146, 28));
					Form4.smethod_12((Control)(object)TextBox1, 1);
					num = (int)((num2 * 978200149) ^ 0x6C27798D);
					continue;
				case 31u:
					Form4.smethod_6((Control)(object)this);
					num = (int)(num2 * 795224369) ^ -737707278;
					continue;
				case 30u:
					Form4.smethod_20((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -2145282034) ^ 0x4DE26969;
					continue;
				case 29u:
					num = (int)((num2 * 1923719605) ^ 0x230D1642);
					continue;
				case 28u:
					num = ((int)num2 * -719316887) ^ 0x7B4CE79;
					continue;
				case 27u:
					OkBtn = Form4.smethod_5();
					num = (int)((num2 * 1364397980) ^ 0x7B54599C);
					continue;
				case 26u:
					Label1 = Form4.smethod_3();
					num = ((int)num2 * -922736264) ^ 0x5F8C7077;
					continue;
				case 25u:
					TextBox1 = Form4.smethod_4();
					num = (int)((num2 * 595905811) ^ 0x64DA2BE9);
					continue;
				case 24u:
					Form4.smethod_18((ButtonBase)(object)OkBtn, bool_0: false);
					num = (int)((num2 * 1475883254) ^ 0x6CBB83FE);
					continue;
				case 23u:
					num = ((int)num2 * -1861639289) ^ -1413544877;
					continue;
				case 22u:
					num = (int)(num2 * 397948641) ^ -1187120039;
					continue;
				case 21u:
					num = ((int)num2 * -1026636954) ^ -1346779836;
					continue;
				case 20u:
					num = ((int)num2 * -2047783671) ^ 0x26D44932;
					continue;
				case 19u:
					num = ((int)num2 * -1366449284) ^ -851703912;
					continue;
				case 18u:
					Form4.smethod_19((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -1995683168) ^ 0x62A44B4A;
					continue;
				case 17u:
					Form4.smethod_16((Control)(object)OkBtn, Color.White);
					num = ((int)num2 * -1096403942) ^ 0xD440D29;
					continue;
				case 16u:
					num = (int)((num2 * 1721434669) ^ 0x5DA31CF9);
					continue;
				case 15u:
					Form4.smethod_11((Control)(object)OkBtn, new Size(96, 37));
					num = (int)((num2 * 1041361765) ^ 0x2EB8C8E);
					continue;
				case 14u:
					num = (int)((num2 * 103119175) ^ 0x1DD3C6C6);
					continue;
				case 13u:
					Form4.smethod_12((Control)(object)OkBtn, 2);
					num = ((int)num2 * -674422387) ^ -29225934;
					continue;
				case 12u:
					Form4.smethod_14(Label1, (ContentAlignment)32);
					num = ((int)num2 * -93012804) ^ 0x14B82187;
					continue;
				case 11u:
					num = (int)(num2 * 490050392) ^ -160285880;
					continue;
				case 10u:
					Form4.smethod_25((Form)(object)this, bool_0: false);
					num = (int)(num2 * 254512477) ^ -2029968900;
					continue;
				case 8u:
					Form4.smethod_28((Form)(object)this, "Form4");
					num = (int)(num2 * 1251825992) ^ -302051635;
					continue;
				case 7u:
					Form4.smethod_24(Form4.smethod_23((Control)(object)this), (Control)(object)Label1);
					num = (int)((num2 * 1493355800) ^ 0x10235640);
					continue;
				case 6u:
					Form4.smethod_13(Label1, "Update Amount");
					num = ((int)num2 * -2002373977) ^ -2039449656;
					continue;
				case 5u:
					Form4.smethod_22((Form)(object)this, new Size(282, 253));
					Form4.smethod_24(Form4.smethod_23((Control)(object)this), (Control)(object)OkBtn);
					num = (int)(num2 * 930038804) ^ -1827783574;
					continue;
				case 4u:
					num = ((int)num2 * -693951331) ^ -1008676719;
					continue;
				case 3u:
					Form4.smethod_9((Control)(object)Label1, new Point(32, 43));
					num = ((int)num2 * -1221113751) ^ -620698218;
					continue;
				case 2u:
					Form4.smethod_26((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1869400075) ^ 0x7752E89C;
					continue;
				case 1u:
					num = (int)(num2 * 928972614) ^ -1679608229;
					continue;
				case 0u:
					Form4.smethod_12((Control)(object)Label1, 0);
					num = ((int)num2 * -949393755) ^ -1791084683;
					continue;
				default:
					return;
				case 32u:
					break;
				case 9u:
					return;
				}
				break;
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected I4, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected I4, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Incompatible stack heights: 0 vs 1
		//IL_0280: Incompatible stack heights: 0 vs 1
		//IL_0287: Incompatible stack heights: 0 vs 1
		OleDbCommand val = default(OleDbCommand);
		string string_ = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = 782955435;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6A7EDC30u) % 9u)
				{
				case 8u:
					val = Form4.smethod_35();
					string_ = Form4.smethod_37(new string[5]
					{
						"Update [Blood_Available] Set Quantity = ",
						Form4.smethod_33(TextBox1),
						" Where [ID] =",
						Form4.smethod_36(MyProject.Forms.Form1.blood_available_id),
						";"
					});
					num = ((int)num2 * -1955529580) ^ -1587876901;
					continue;
				case 6u:
					num = 1938302068;
					continue;
				case 5u:
					flag = !MyProject.Forms.Form1.Decimal_Validator(Form4.smethod_33(TextBox1));
					num = (int)((num2 * 757988567) ^ 0x45DCB280);
					continue;
				case 4u:
					Form4.smethod_38(myconnection);
					num = ((int)num2 * -323790771) ^ -1346735220;
					continue;
				case 1u:
					Form4.smethod_34("Enter Valid Amount");
					num = ((int)num2 * -738449361) ^ 0x796A6453;
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1370947307;
						num5 = 1370947307;
					}
					else
					{
						num4 = 1359488740;
						num5 = 1359488740;
					}
					num = num4 ^ (int)(num2 * 88087458);
					continue;
				}
				case 2u:
					break;
				default:
					try
					{
						while (true)
						{
							int num3 = 1718224474;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x6A7EDC30u) % 8u)
								{
								case 7u:
									MyProject.Forms.Form1.cur_blood_amount = Form4.smethod_43(Form4.smethod_33(TextBox1));
									Form4.smethod_44((Form)(object)this);
									num3 = (int)((num2 * 2005600269) ^ 0x62E3AC93);
									continue;
								case 6u:
									num3 = (int)(num2 * 1528426026) ^ -978634999;
									continue;
								case 5u:
									Form4.smethod_42(myconnection);
									num3 = (int)(num2 * 1093749544) ^ -2072719081;
									continue;
								case 2u:
									val = Form4.smethod_39(string_, myconnection);
									num3 = ((int)num2 * -1200997508) ^ 0xF92091;
									continue;
								case 1u:
									Form4.smethod_40(val);
									Form4.smethod_41((Component)(object)val);
									num3 = (int)(num2 * 457615394) ^ -297023900;
									continue;
								case 0u:
									num3 = (int)(num2 * 1407017721) ^ -174889125;
									continue;
								default:
									return;
								case 4u:
									break;
								case 3u:
									return;
								}
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						Form4.smethod_45(exception_);
						while (true)
						{
							_ = 756336615;
							while (true)
							{
								_003F val2 = /*Error near IL_0230: Stack underflow*/^ 0x6A7EDC30;
								num2 = (uint)(int)val2;
								switch (val2 % 4)
								{
								case 3:
									Form4.smethod_34("Error Updating database");
									_ = (num2 * 1110603497) ^ 0xFC786ABDu;
									continue;
								case 2:
									Form4.smethod_42(myconnection);
									_ = ((int)num2 * -1344427896) ^ 0x2A05CD25;
									continue;
								case 0:
									break;
								default:
									Form4.smethod_46();
									return;
								}
								break;
							}
						}
					}
				case 3u:
					return;
				}
				break;
			}
		}
	}

	private void Form4_Load(object sender, EventArgs e)
	{
		Form4.smethod_48(myconnection, Form4.smethod_47(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
	}

	static void smethod_0(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static OleDbConnection smethod_1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new OleDbConnection();
	}

	static void smethod_2(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Label smethod_3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static TextBox smethod_4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static Button smethod_5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static void smethod_6(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static Font smethod_7(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_8(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_9(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_10(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_11(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_12(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_13(Label label_0, string string_0)
	{
		label_0.set_Text(string_0);
	}

	static void smethod_14(Label label_0, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_TextAlign(contentAlignment_0);
	}

	static void smethod_15(ButtonBase buttonBase_0, Color color_0)
	{
		buttonBase_0.set_BackColor(color_0);
	}

	static void smethod_16(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
	}

	static void smethod_17(ButtonBase buttonBase_0, string string_0)
	{
		buttonBase_0.set_Text(string_0);
	}

	static void smethod_18(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_19(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_20(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_21(Form form_0, Color color_0)
	{
		form_0.set_BackColor(color_0);
	}

	static void smethod_22(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_23(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_24(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_25(Form form_0, bool bool_0)
	{
		form_0.set_MaximizeBox(bool_0);
	}

	static void smethod_26(Form form_0, bool bool_0)
	{
		form_0.set_MinimizeBox(bool_0);
	}

	static void smethod_27(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_28(Form form_0, string string_0)
	{
		form_0.set_Text(string_0);
	}

	static void smethod_29(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_30(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_31(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_32(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static string smethod_33(TextBox textBox_0)
	{
		return textBox_0.get_Text();
	}

	static DialogResult smethod_34(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}

	static OleDbCommand smethod_35()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new OleDbCommand();
	}

	static string smethod_36(int int_0)
	{
		return Conversions.ToString(int_0);
	}

	static string smethod_37(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static void smethod_38(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Open();
	}

	static OleDbCommand smethod_39(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbCommand(string_0, oleDbConnection_0);
	}

	static int smethod_40(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.ExecuteNonQuery();
	}

	static void smethod_41(Component component_0)
	{
		component_0.Dispose();
	}

	static void smethod_42(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Close();
	}

	static decimal smethod_43(string string_0)
	{
		return Conversions.ToDecimal(string_0);
	}

	static void smethod_44(Form form_0)
	{
		form_0.Close();
	}

	static void smethod_45(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_46()
	{
		ProjectData.ClearProjectError();
	}

	static string smethod_47(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_48(OleDbConnection oleDbConnection_0, string string_0)
	{
		oleDbConnection_0.set_ConnectionString(string_0);
	}
}
