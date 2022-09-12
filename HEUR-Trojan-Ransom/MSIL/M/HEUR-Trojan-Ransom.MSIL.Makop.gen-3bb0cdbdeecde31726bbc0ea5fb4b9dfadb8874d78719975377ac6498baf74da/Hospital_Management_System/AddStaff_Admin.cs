using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hospital_Management_System.My;
using Hospital_Management_System.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hospital_Management_System;

[DesignerGenerated]
public class AddStaff_Admin : UserControl
{
	private IContainer components;

	private string username;

	private string password;

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SuccessMsg")]
	internal virtual Label SuccessMsg
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("AddressTxt")]
	internal virtual TextBox AddressTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MobileTxt")]
	internal virtual TextBox MobileTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GenderTxt")]
	internal virtual ComboBox GenderTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NameTxt")]
	internal virtual TextBox NameTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("WorkShiftTxt")]
	internal virtual ComboBox WorkShiftTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DesignationTxt")]
	internal virtual ComboBox DesignationTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button RegisterBtn
	{
		[CompilerGenerated]
		get
		{
			return _RegisterBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = RegisterBtn_Click;
			Button registerBtn = default(Button);
			while (true)
			{
				int num = 1853953052;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x39E222EDu) % 9u)
					{
					case 8u:
						registerBtn = _RegisterBtn;
						num = ((int)num2 * -187136750) ^ -527051384;
						continue;
					case 7u:
						AddStaff_Admin.smethod_60((Control)(object)registerBtn, eventHandler_);
						num = (int)((num2 * 346637861) ^ 0x6E49ED16);
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (registerBtn == null)
						{
							num5 = 2104070491;
							num6 = 2104070491;
						}
						else
						{
							num5 = 1532132484;
							num6 = 1532132484;
						}
						num = num5 ^ (int)(num2 * 1062093538);
						continue;
					}
					case 5u:
					{
						int num3;
						int num4;
						if (registerBtn != null)
						{
							num3 = -239814623;
							num4 = -239814623;
						}
						else
						{
							num3 = -599119366;
							num4 = -599119366;
						}
						num = num3 ^ (int)(num2 * 1503091207);
						continue;
					}
					case 4u:
						registerBtn = _RegisterBtn;
						num = (int)((num2 * 1912198127) ^ 0x7A54CDE9);
						continue;
					case 2u:
						AddStaff_Admin.smethod_61((Control)(object)registerBtn, eventHandler_);
						num = ((int)num2 * -1106418210) ^ 0x2946F83D;
						continue;
					case 1u:
						_RegisterBtn = value;
						num = 32668044;
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
	}

	internal virtual Button ClearBtn
	{
		[CompilerGenerated]
		get
		{
			return _ClearBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = ClearBtn_Click;
			Button clearBtn = default(Button);
			while (true)
			{
				int num = -608746286;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBD05B2EAu) % 9u)
					{
					case 8u:
						AddStaff_Admin.smethod_61((Control)(object)clearBtn, eventHandler_);
						num = (int)((num2 * 622557595) ^ 0x2E6D85D8);
						continue;
					case 7u:
						_ClearBtn = value;
						num = -2022526208;
						continue;
					case 4u:
						clearBtn = _ClearBtn;
						num = (int)((num2 * 19911149) ^ 0x1C01B9E);
						continue;
					case 3u:
						clearBtn = _ClearBtn;
						num = (int)(num2 * 1446043712) ^ -824421586;
						continue;
					case 2u:
					{
						int num5;
						int num6;
						if (clearBtn != null)
						{
							num5 = -426209169;
							num6 = -426209169;
						}
						else
						{
							num5 = -1997241071;
							num6 = -1997241071;
						}
						num = num5 ^ (int)(num2 * 1099776176);
						continue;
					}
					case 1u:
						AddStaff_Admin.smethod_60((Control)(object)clearBtn, eventHandler_);
						num = (int)((num2 * 1664428481) ^ 0x7D4966D4);
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (clearBtn != null)
						{
							num3 = -914203637;
							num4 = -914203637;
						}
						else
						{
							num3 = -1471571733;
							num4 = -1471571733;
						}
						num = num3 ^ ((int)num2 * -90341246);
						continue;
					}
					default:
						return;
					case 5u:
						break;
					case 6u:
						return;
					}
					break;
				}
			}
		}
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("EmailTxt")]
	internal virtual TextBox EmailTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = Timer1_Tick;
			Timer timer = default(Timer);
			while (true)
			{
				int num = 1766306815;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1A0943A8u) % 7u)
					{
					case 5u:
						AddStaff_Admin.smethod_62(timer, eventHandler_);
						num = (int)((num2 * 23418943) ^ 0x621218F5);
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (timer == null)
						{
							num4 = 35334860;
							num5 = 35334860;
						}
						else
						{
							num4 = 2110961967;
							num5 = 2110961967;
						}
						num = num4 ^ ((int)num2 * -1823754521);
						continue;
					}
					case 3u:
						AddStaff_Admin.smethod_63(timer, eventHandler_);
						num = ((int)num2 * -1096340003) ^ 0x1D4769F1;
						continue;
					case 2u:
						timer = _Timer1;
						num = (int)((num2 * 1737667230) ^ 0xD025BA4);
						continue;
					case 1u:
					{
						_Timer1 = value;
						timer = _Timer1;
						int num3;
						if (timer == null)
						{
							num = 1053799684;
							num3 = 1053799684;
						}
						else
						{
							num = 1602877009;
							num3 = 1602877009;
						}
						continue;
					}
					default:
						return;
					case 0u:
						break;
					case 6u:
						return;
					}
					break;
				}
			}
		}
	}

	[field: AccessedThroughProperty("DOBTxt")]
	internal virtual DateTimePicker DOBTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public AddStaff_Admin()
	{
		while (true)
		{
			int num = -952008825;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC4A0EA04u) % 4u)
				{
				case 3u:
					AddStaff_Admin.smethod_0((UserControl)(object)this, (EventHandler)AddStaff_Admin_Load);
					num = (int)(num2 * 1169168904) ^ -734605431;
					continue;
				case 1u:
					InitializeComponent();
					num = (int)(num2 * 206098556) ^ -476686626;
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

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			bool flag = default(bool);
			while (true)
			{
				int num = 1688272274;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x1F6D36F3u) % 8u)
					{
					case 7u:
						AddStaff_Admin.smethod_1((IDisposable)components);
						num = (int)((num2 * 891783480) ^ 0x6E790DCE);
						continue;
					case 5u:
						num = ((int)num2 * -1400906167) ^ 0x5E1130E5;
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -580163252;
							num5 = -580163252;
						}
						else
						{
							num4 = -473101680;
							num5 = -473101680;
						}
						num = num4 ^ (int)(num2 * 339521942);
						continue;
					}
					case 3u:
						num = 92857851;
						continue;
					case 2u:
						num3 = ((components != null) ? 1 : 0);
						goto IL_0064;
					case 1u:
						if (disposing)
						{
							num = ((int)num2 * -1525975335) ^ 0x506CD190;
							continue;
						}
						num3 = 0;
						goto IL_0064;
					default:
						return;
					case 6u:
						break;
					case 0u:
						return;
						IL_0064:
						flag = (byte)num3 != 0;
						num = 385474799;
						continue;
					}
					break;
				}
			}
		}
		finally
		{
			while (true)
			{
				IL_0102:
				int num6 = 454983156;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num6 ^ 0x1F6D36F3u) % 4u)
					{
					case 3u:
						((ContainerControl)this).Dispose(disposing);
						num6 = (int)((num2 * 1703417262) ^ 0x4A2F2873);
						continue;
					case 2u:
						num6 = (int)((num2 * 2067154377) ^ 0x5E2E7E4C);
						continue;
					default:
						goto end_IL_00e1;
					case 0u:
						break;
					case 1u:
						goto end_IL_00e1;
					}
					goto IL_0102;
					continue;
					end_IL_00e1:
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
			int num = 247286994;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8C5A627u) % 271u)
				{
				case 270u:
					AddStaff_Admin.smethod_16((Control)(object)Label7, "Label7");
					num = (int)((num2 * 1445556698) ^ 0x30CE699);
					continue;
				case 269u:
					num = ((int)num2 * -1288184249) ^ 0x83A18C7;
					continue;
				case 268u:
					num = (int)((num2 * 620934941) ^ 0xA0BF6B6);
					continue;
				case 267u:
					num = ((int)num2 * -1438156482) ^ 0x2388C100;
					continue;
				case 266u:
					num = ((int)num2 * -1839473772) ^ -221872390;
					continue;
				case 265u:
					AddStaff_Admin.smethod_43((ListControl)(object)DesignationTxt, bool_0: true);
					num = ((int)num2 * -1995509313) ^ 0x226C0F7B;
					continue;
				case 264u:
					AddStaff_Admin.smethod_16((Control)(object)MobileTxt, "MobileTxt");
					num = ((int)num2 * -259804319) ^ -460027972;
					continue;
				case 263u:
					AddStaff_Admin.smethod_22((Control)(object)Label7, AddStaff_Admin.smethod_21("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					AddStaff_Admin.smethod_15((Control)(object)Label7, new Point(3, 222));
					num = (int)((num2 * 298023433) ^ 0x142EEFD0);
					continue;
				case 262u:
					AddStaff_Admin.smethod_47((ButtonBase)(object)RegisterBtn, Color.MidnightBlue);
					AddStaff_Admin.smethod_22((Control)(object)RegisterBtn, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 582459412) ^ -1868402946;
					continue;
				case 261u:
					AddressTxt = AddStaff_Admin.smethod_7();
					num = (int)((num2 * 1854063616) ^ 0x29140B6F);
					continue;
				case 260u:
					MobileTxt = AddStaff_Admin.smethod_7();
					num = ((int)num2 * -369555359) ^ -510656077;
					continue;
				case 259u:
					num = ((int)num2 * -1270854996) ^ 0x7CDF0AAD;
					continue;
				case 258u:
					AddStaff_Admin.smethod_48((ButtonBase)(object)ClearBtn, "Clear");
					num = ((int)num2 * -1734697084) ^ 0x709EDFA2;
					continue;
				case 257u:
					num = (int)(num2 * 1653747170) ^ -375786324;
					continue;
				case 256u:
					AddStaff_Admin.smethod_16((Control)(object)WorkShiftTxt, "WorkShiftTxt");
					num = ((int)num2 * -13953579) ^ -1255977308;
					continue;
				case 255u:
					num = ((int)num2 * -1958989019) ^ 0x53E07739;
					continue;
				case 254u:
					num = ((int)num2 * -1401875972) ^ 0x786096EA;
					continue;
				case 253u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)Label6);
					num = ((int)num2 * -1243612388) ^ 0x51AEC9EF;
					continue;
				case 252u:
					AddStaff_Admin.smethod_58((Control)(object)GroupBox2);
					num = (int)(num2 * 1895909505) ^ -1889619889;
					continue;
				case 251u:
					num = ((int)num2 * -698429168) ^ 0xEEC289B;
					continue;
				case 250u:
					AddStaff_Admin.smethod_15((Control)(object)GenderTxt, new Point(137, 182));
					num = (int)(num2 * 693422612) ^ -609379025;
					continue;
				case 249u:
					AddStaff_Admin.smethod_25(Label7, (ContentAlignment)32);
					num = ((int)num2 * -470674086) ^ 0x548071AE;
					continue;
				case 248u:
					num = ((int)num2 * -255957087) ^ -1816676911;
					continue;
				case 247u:
					AddStaff_Admin.smethod_22((Control)(object)AddressTxt, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -444980778) ^ -637071767;
					continue;
				case 246u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)Label2);
					num = ((int)num2 * -256088284) ^ -1400052206;
					continue;
				case 245u:
					AddStaff_Admin.smethod_17((Control)(object)Label3, new Size(82, 31));
					AddStaff_Admin.smethod_23((Control)(object)Label3, 6);
					num = ((int)num2 * -1368781459) ^ 0x6C7C79F7;
					continue;
				case 244u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)WorkShiftTxt);
					num = ((int)num2 * -1029651147) ^ 0x356B1E3F;
					continue;
				case 243u:
					AddStaff_Admin.smethod_23((Control)(object)Label7, 14);
					num = (int)((num2 * 1494439186) ^ 0x666B6705);
					continue;
				case 242u:
					num = (int)((num2 * 1066981862) ^ 0x23A0248A);
					continue;
				case 241u:
					AddStaff_Admin.smethod_22((Control)(object)WorkShiftTxt, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -803831815) ^ -1900354420;
					continue;
				case 240u:
					num = ((int)num2 * -2112691093) ^ -896594903;
					continue;
				case 239u:
					AddStaff_Admin.smethod_19(PictureBox1, 10);
					num = ((int)num2 * -898577358) ^ -865357671;
					continue;
				case 238u:
					AddStaff_Admin.smethod_24(Label9, "Email :");
					num = ((int)num2 * -1004840276) ^ -346511560;
					continue;
				case 237u:
					AddStaff_Admin.smethod_15((Control)(object)ClearBtn, new Point(261, 703));
					num = ((int)num2 * -2079327480) ^ 0x62D96F9E;
					continue;
				case 236u:
					AddStaff_Admin.smethod_15((Control)(object)Label2, new Point(8, 55));
					num = ((int)num2 * -565421798) ^ 0x7A2802E2;
					continue;
				case 235u:
					num = (int)((num2 * 1909484001) ^ 0x3572376C);
					continue;
				case 234u:
					AddStaff_Admin.smethod_22((Control)(object)Label4, AddStaff_Admin.smethod_21("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1335789616) ^ 0x272F9550;
					continue;
				case 233u:
					components = AddStaff_Admin.smethod_2();
					num = (int)((num2 * 894996953) ^ 0x24E0755F);
					continue;
				case 232u:
					AddStaff_Admin.smethod_23((Control)(object)DOBTxt, 20);
					num = (int)((num2 * 2016200062) ^ 0x40C0D17C);
					continue;
				case 231u:
					Label3 = AddStaff_Admin.smethod_4();
					Label2 = AddStaff_Admin.smethod_4();
					num = ((int)num2 * -2141781254) ^ 0x55198B64;
					continue;
				case 230u:
					AddStaff_Admin.smethod_11((ISupportInitialize)PictureBox1);
					num = (int)((num2 * 295096197) ^ 0x22A1B338);
					continue;
				case 229u:
					AddStaff_Admin.smethod_39(AddStaff_Admin.smethod_38(GenderTxt), new string[3] { "Male", "Female", "Others" });
					num = ((int)num2 * -1503802619) ^ -684528451;
					continue;
				case 228u:
					AddStaff_Admin.smethod_15((Control)(object)Label4, new Point(8, 101));
					AddStaff_Admin.smethod_16((Control)(object)Label4, "Label4");
					AddStaff_Admin.smethod_17((Control)(object)Label4, new Size(92, 24));
					num = ((int)num2 * -631609907) ^ -945436203;
					continue;
				case 227u:
					AddStaff_Admin.smethod_16((Control)(object)DesignationTxt, "DesignationTxt");
					num = (int)(num2 * 1487252467) ^ -1476364640;
					continue;
				case 226u:
					AddStaff_Admin.smethod_45(AddStaff_Admin.smethod_44(GenderTxt), new object[3] { "Male", "Female", "Others" });
					num = ((int)num2 * -1019726346) ^ 0x2FB3ADFE;
					continue;
				case 225u:
					GroupBox2 = AddStaff_Admin.smethod_5();
					num = ((int)num2 * -1117578702) ^ 0xAC8BAA9;
					continue;
				case 224u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)AddressTxt);
					num = (int)((num2 * 1351398893) ^ 0x71A50FAE);
					continue;
				case 223u:
					AddStaff_Admin.smethod_52((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1668891527) ^ -1034781404;
					continue;
				case 222u:
					AddStaff_Admin.smethod_15((Control)(object)Label8, new Point(3, 263));
					num = ((int)num2 * -454306774) ^ 0x12353F35;
					continue;
				case 221u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_53((Control)(object)this), (Control)(object)Label1);
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_53((Control)(object)this), (Control)(object)PictureBox1);
					num = (int)(num2 * 828258813) ^ -1542049380;
					continue;
				case 220u:
					num = (int)(num2 * 1150592680) ^ -562468568;
					continue;
				case 219u:
					AddStaff_Admin.smethod_40(GenderTxt, (AutoCompleteMode)2);
					num = ((int)num2 * -1757807495) ^ 0x38DD8AEA;
					continue;
				case 218u:
					AddStaff_Admin.smethod_15((Control)(object)Label3, new Point(13, 182));
					num = ((int)num2 * -447466867) ^ -890626225;
					continue;
				case 217u:
					AddStaff_Admin.smethod_24(SuccessMsg, "Patient Successfully registered");
					num = (int)(num2 * 772144249) ^ -639177591;
					continue;
				case 216u:
					num = (int)(num2 * 330929201) ^ -334661882;
					continue;
				case 215u:
					AddStaff_Admin.smethod_22((Control)(object)Label3, AddStaff_Admin.smethod_21("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1802556258) ^ 0x66619328;
					continue;
				case 214u:
					num = ((int)num2 * -1591275319) ^ 0x37DAB261;
					continue;
				case 213u:
					AddStaff_Admin.smethod_23((Control)(object)MobileTxt, 12);
					num = (int)(num2 * 980588858) ^ -816632701;
					continue;
				case 212u:
					num = ((int)num2 * -1776397036) ^ -973706464;
					continue;
				case 211u:
					AddStaff_Admin.smethod_23((Control)(object)Label9, 18);
					num = (int)(num2 * 1363477108) ^ -1057260135;
					continue;
				case 210u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)DesignationTxt);
					num = ((int)num2 * -1440011898) ^ -1625928536;
					continue;
				case 209u:
					AddStaff_Admin.smethod_34(DOBTxt, (DateTimePickerFormat)2);
					num = (int)(num2 * 181516894) ^ -852159789;
					continue;
				case 208u:
					num = (int)(num2 * 1517729163) ^ -643025435;
					continue;
				case 207u:
					WorkShiftTxt = AddStaff_Admin.smethod_8();
					Label7 = AddStaff_Admin.smethod_4();
					num = (int)(num2 * 491852104) ^ -359123768;
					continue;
				case 206u:
					AddStaff_Admin.smethod_22((Control)(object)Label8, AddStaff_Admin.smethod_21("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -993664808) ^ -524218394;
					continue;
				case 205u:
					num = ((int)num2 * -237326213) ^ 0x12DEDA2E;
					continue;
				case 204u:
					AddStaff_Admin.smethod_23((Control)(object)SuccessMsg, 12);
					num = ((int)num2 * -89843678) ^ -1961970347;
					continue;
				case 203u:
					AddStaff_Admin.smethod_16((Control)(object)Label6, "Label6");
					AddStaff_Admin.smethod_17((Control)(object)Label6, new Size(87, 26));
					num = ((int)num2 * -111937628) ^ -882428528;
					continue;
				case 202u:
					Timer1 = AddStaff_Admin.smethod_10(components);
					num = ((int)num2 * -1254272244) ^ 0x780B9EAD;
					continue;
				case 201u:
					Label6 = AddStaff_Admin.smethod_4();
					num = (int)((num2 * 602052586) ^ 0x42AB32C3);
					continue;
				case 200u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)NameTxt);
					num = (int)((num2 * 1738950377) ^ 0x3D4C043);
					continue;
				case 199u:
					GenderTxt = AddStaff_Admin.smethod_8();
					num = (int)(num2 * 31110294) ^ -1709433133;
					continue;
				case 198u:
					num = ((int)num2 * -761713846) ^ -435558182;
					continue;
				case 197u:
					num = (int)(num2 * 1964792416) ^ -564711628;
					continue;
				case 196u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_53((Control)(object)this), (Control)(object)RegisterBtn);
					num = ((int)num2 * -1561339939) ^ 0x7E559525;
					continue;
				case 195u:
					AddStaff_Admin.smethod_15((Control)(object)DOBTxt, new Point(137, 102));
					num = ((int)num2 * -1268916621) ^ -81219616;
					continue;
				case 194u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)Label4);
					num = ((int)num2 * -831718510) ^ -1168575800;
					continue;
				case 193u:
					AddStaff_Admin.smethod_50(Timer1, 1500);
					num = ((int)num2 * -962532013) ^ -2117497355;
					continue;
				case 192u:
					AddStaff_Admin.smethod_23((Control)(object)Label1, 11);
					num = (int)(num2 * 801267934) ^ -748978234;
					continue;
				case 191u:
					AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Olive);
					num = (int)((num2 * 674564842) ^ 0x586F2947);
					continue;
				case 190u:
					AddStaff_Admin.smethod_16((Control)(object)Label3, "Label3");
					num = ((int)num2 * -1764475265) ^ -480092044;
					continue;
				case 189u:
					AddStaff_Admin.smethod_16((Control)(object)DOBTxt, "DOBTxt");
					num = (int)(num2 * 150015437) ^ -1332953975;
					continue;
				case 188u:
					num = ((int)num2 * -548713214) ^ 0x41408EDF;
					continue;
				case 187u:
					num = ((int)num2 * -252311794) ^ 0x176A30F9;
					continue;
				case 186u:
					AddStaff_Admin.smethod_41(GenderTxt, (AutoCompleteSource)256);
					num = ((int)num2 * -592576494) ^ -845452774;
					continue;
				case 185u:
					num = (int)(num2 * 1664301650) ^ -661241682;
					continue;
				case 184u:
					AddStaff_Admin.smethod_16((Control)(object)PictureBox1, "PictureBox1");
					num = ((int)num2 * -1696811790) ^ -365778737;
					continue;
				case 183u:
					AddStaff_Admin.smethod_24(Label5, "Mobile :");
					num = (int)(num2 * 4114502) ^ -745062584;
					continue;
				case 182u:
					AddStaff_Admin.smethod_43((ListControl)(object)GenderTxt, bool_0: true);
					num = (int)(num2 * 817087505) ^ -1829171035;
					continue;
				case 181u:
					Label5 = AddStaff_Admin.smethod_4();
					Label4 = AddStaff_Admin.smethod_4();
					num = (int)(num2 * 1424969898) ^ -1244509974;
					continue;
				case 180u:
					AddStaff_Admin.smethod_24(Label4, "D.O.B :");
					num = ((int)num2 * -840103301) ^ 0x483837D0;
					continue;
				case 179u:
					AddStaff_Admin.smethod_45(AddStaff_Admin.smethod_44(WorkShiftTxt), new object[2] { "Day", "Night" });
					num = ((int)num2 * -1697070227) ^ 0x72586D15;
					continue;
				case 178u:
					AddStaff_Admin.smethod_47((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					AddStaff_Admin.smethod_22((Control)(object)ClearBtn, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1185044297) ^ -60914968;
					continue;
				case 177u:
					AddStaff_Admin.smethod_24(Label2, "Name :");
					num = ((int)num2 * -1163328167) ^ -1802671998;
					continue;
				case 176u:
					AddStaff_Admin.smethod_15((Control)(object)RegisterBtn, new Point(608, 703));
					AddStaff_Admin.smethod_16((Control)(object)RegisterBtn, "RegisterBtn");
					num = (int)(num2 * 208838371) ^ -1533402489;
					continue;
				case 175u:
					num = ((int)num2 * -415905687) ^ 0x2990C061;
					continue;
				case 174u:
					AddStaff_Admin.smethod_23((Control)(object)RegisterBtn, 14);
					num = ((int)num2 * -1085782539) ^ -1852773416;
					continue;
				case 173u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)GenderTxt);
					num = ((int)num2 * -2033796974) ^ -1010254699;
					continue;
				case 172u:
					AddStaff_Admin.smethod_22((Control)(object)Label6, AddStaff_Admin.smethod_21("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1713253537) ^ 0x308A9D41);
					continue;
				case 171u:
					AddStaff_Admin.smethod_37(DOBTxt, new DateTime(2019, 2, 11, 0, 0, 0, 0));
					num = (int)((num2 * 622316497) ^ 0x36CB3CD8);
					continue;
				case 170u:
					AddStaff_Admin.smethod_57((Control)(object)GroupBox2, bool_0: false);
					num = ((int)num2 * -2114396063) ^ -508399209;
					continue;
				case 169u:
					AddStaff_Admin.smethod_17((Control)(object)GroupBox2, new Size(486, 446));
					num = ((int)num2 * -1542677823) ^ -1524649315;
					continue;
				case 168u:
					num = (int)((num2 * 1574716928) ^ 0xD5A376B);
					continue;
				case 167u:
					AddStaff_Admin.smethod_16((Control)(object)NameTxt, "NameTxt");
					AddStaff_Admin.smethod_17((Control)(object)NameTxt, new Size(324, 26));
					num = ((int)num2 * -1989286573) ^ 0x483EBF6F;
					continue;
				case 166u:
					EmailTxt = AddStaff_Admin.smethod_7();
					num = (int)((num2 * 851456485) ^ 0x996E13E);
					continue;
				case 165u:
					num = ((int)num2 * -1840063368) ^ 0x15A13DC0;
					continue;
				case 164u:
					AddStaff_Admin.smethod_25(Label1, (ContentAlignment)32);
					num = (int)(num2 * 444527663) ^ -1692564805;
					continue;
				case 163u:
					AddStaff_Admin.smethod_17((Control)(object)MobileTxt, new Size(208, 26));
					num = (int)(num2 * 1602558742) ^ -1394418185;
					continue;
				case 162u:
					AddStaff_Admin.smethod_22((Control)(object)Label1, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					AddStaff_Admin.smethod_15((Control)(object)Label1, new Point(392, 63));
					num = (int)(num2 * 1507509825) ^ -262970047;
					continue;
				case 161u:
					AddStaff_Admin.smethod_17((Control)(object)RegisterBtn, new Size(139, 43));
					num = (int)((num2 * 1237329912) ^ 0x5F78CC62);
					continue;
				case 160u:
					AddStaff_Admin.smethod_16((Control)(object)Label1, "Label1");
					num = ((int)num2 * -1445991643) ^ -1682904864;
					continue;
				case 159u:
					AddStaff_Admin.smethod_17((Control)(object)SuccessMsg, new Size(401, 44));
					num = ((int)num2 * -464823554) ^ 0x6E634248;
					continue;
				case 158u:
					AddStaff_Admin.smethod_14(PictureBox1, (Image)(object)Resources.doc_Pic);
					num = ((int)num2 * -1239415659) ^ 0x2DC2945B;
					continue;
				case 157u:
					AddStaff_Admin.smethod_24(Label7, "Work Shift :");
					num = (int)((num2 * 1748907621) ^ 0x33A77596);
					continue;
				case 156u:
					AddStaff_Admin.smethod_35(DOBTxt, new DateTime(2019, 2, 11, 0, 0, 0, 0));
					num = ((int)num2 * -1445333622) ^ 0x49E962B;
					continue;
				case 155u:
					num = (int)((num2 * 696178336) ^ 0xB892CD4);
					continue;
				case 154u:
					Label1 = AddStaff_Admin.smethod_4();
					SuccessMsg = AddStaff_Admin.smethod_4();
					num = (int)((num2 * 1517724770) ^ 0x504F57E7);
					continue;
				case 153u:
					AddStaff_Admin.smethod_17((Control)(object)ClearBtn, new Size(143, 43));
					num = (int)(num2 * 32251692) ^ -535807351;
					continue;
				case 152u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)DOBTxt);
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)EmailTxt);
					num = (int)((num2 * 823609300) ^ 0x4D9D23AF);
					continue;
				case 151u:
					AddStaff_Admin.smethod_18(PictureBox1, (PictureBoxSizeMode)1);
					num = ((int)num2 * -1507771073) ^ 0x723FBA0C;
					continue;
				case 150u:
					num = ((int)num2 * -449445884) ^ -1184211097;
					continue;
				case 149u:
					num = ((int)num2 * -101439781) ^ -400772547;
					continue;
				case 148u:
					num = (int)((num2 * 580316341) ^ 0x1A6C021F);
					continue;
				case 147u:
					AddStaff_Admin.smethod_24(Label1, "Add Staff");
					num = (int)(num2 * 2033535593) ^ -264787824;
					continue;
				case 146u:
					num = (int)(num2 * 1330015174) ^ -1698426448;
					continue;
				case 145u:
					AddStaff_Admin.smethod_42(DesignationTxt, (ComboBoxStyle)2);
					AddStaff_Admin.smethod_22((Control)(object)DesignationTxt, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1785027502) ^ -436545336;
					continue;
				case 144u:
					AddStaff_Admin.smethod_17((Control)(object)DOBTxt, new Size(208, 29));
					num = ((int)num2 * -1420850269) ^ 0x5B927B48;
					continue;
				case 143u:
					num = (int)((num2 * 866520168) ^ 0x4524A836);
					continue;
				case 142u:
					AddStaff_Admin.smethod_17((Control)(object)Label8, new Size(128, 26));
					num = (int)(num2 * 1298059008) ^ -920972760;
					continue;
				case 141u:
					num = (int)(num2 * 980659524) ^ -1258496910;
					continue;
				case 140u:
					AddStaff_Admin.smethod_48((ButtonBase)(object)RegisterBtn, "Register");
					num = (int)(num2 * 137035801) ^ -245794122;
					continue;
				case 139u:
					AddStaff_Admin.smethod_39(AddStaff_Admin.smethod_38(DesignationTxt), new string[3] { "Male", "Female", "Others" });
					AddStaff_Admin.smethod_40(DesignationTxt, (AutoCompleteMode)2);
					num = ((int)num2 * -1589278534) ^ -547242063;
					continue;
				case 138u:
					AddStaff_Admin.smethod_23((Control)(object)NameTxt, 0);
					num = (int)((num2 * 791765690) ^ 0x2274088E);
					continue;
				case 137u:
					AddStaff_Admin.smethod_16((Control)(object)EmailTxt, "EmailTxt");
					num = (int)((num2 * 1006445747) ^ 0x51C209A5);
					continue;
				case 136u:
					num = ((int)num2 * -1161705782) ^ -1535310633;
					continue;
				case 135u:
					num = (int)(num2 * 885301538) ^ -826457759;
					continue;
				case 134u:
					AddStaff_Admin.smethod_49((ButtonBase)(object)RegisterBtn, bool_0: false);
					num = (int)((num2 * 2026092057) ^ 0x7170C2B1);
					continue;
				case 133u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_53((Control)(object)this), (Control)(object)SuccessMsg);
					num = ((int)num2 * -1642213149) ^ -1580759103;
					continue;
				case 132u:
					AddStaff_Admin.smethod_15((Control)(object)AddressTxt, new Point(137, 349));
					AddStaff_Admin.smethod_46(AddressTxt, bool_0: true);
					num = ((int)num2 * -1956835569) ^ -1582343380;
					continue;
				case 131u:
					num = ((int)num2 * -229277250) ^ 0x4F8265CB;
					continue;
				case 130u:
					AddStaff_Admin.smethod_22((Control)(object)SuccessMsg, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					AddStaff_Admin.smethod_28((Control)(object)SuccessMsg, AddStaff_Admin.smethod_27());
					num = ((int)num2 * -321198456) ^ -995908056;
					continue;
				case 129u:
					AddStaff_Admin.smethod_23((Control)(object)AddressTxt, 13);
					num = ((int)num2 * -232085470) ^ -632634396;
					continue;
				case 128u:
					AddStaff_Admin.smethod_16((Control)(object)ClearBtn, "ClearBtn");
					num = ((int)num2 * -1472318029) ^ 0x5832EE35;
					continue;
				case 127u:
					Label9 = AddStaff_Admin.smethod_4();
					num = ((int)num2 * -1432980097) ^ -1464209862;
					continue;
				case 126u:
					AddStaff_Admin.smethod_26((Control)(object)this, Color.White);
					num = ((int)num2 * -1626675420) ^ -1065219427;
					continue;
				case 125u:
					DesignationTxt = AddStaff_Admin.smethod_8();
					Label8 = AddStaff_Admin.smethod_4();
					num = ((int)num2 * -1429031778) ^ 0x232A2052;
					continue;
				case 124u:
					AddStaff_Admin.smethod_23((Control)(object)WorkShiftTxt, 15);
					num = (int)(num2 * 909751264) ^ -537867861;
					continue;
				case 123u:
					AddStaff_Admin.smethod_17((Control)(object)Label1, new Size(330, 47));
					num = ((int)num2 * -257389574) ^ 0x4D367D52;
					continue;
				case 122u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)MobileTxt);
					num = ((int)num2 * -122307644) ^ -1989114031;
					continue;
				case 121u:
					AddStaff_Admin.smethod_22((Control)(object)Label5, AddStaff_Admin.smethod_21("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					AddStaff_Admin.smethod_15((Control)(object)Label5, new Point(8, 144));
					num = ((int)num2 * -320218630) ^ -1119566113;
					continue;
				case 120u:
					num = (int)((num2 * 1890821052) ^ 0x378370EC);
					continue;
				case 119u:
					AddStaff_Admin.smethod_15((Control)(object)DesignationTxt, new Point(137, 262));
					num = (int)(num2 * 979912761) ^ -1051837098;
					continue;
				case 118u:
					num = ((int)num2 * -771531218) ^ 0x256A0354;
					continue;
				case 117u:
					num = (int)(num2 * 794858893) ^ -674932594;
					continue;
				case 116u:
					num = (int)((num2 * 1159400722) ^ 0x697F1EB0);
					continue;
				case 115u:
					num = ((int)num2 * -1473151576) ^ 0x637DD0A5;
					continue;
				case 114u:
					AddStaff_Admin.smethod_16((Control)(object)AddressTxt, "AddressTxt");
					num = (int)((num2 * 505170851) ^ 0xC910A76);
					continue;
				case 113u:
					AddStaff_Admin.smethod_17((Control)(object)PictureBox1, new Size(141, 136));
					num = ((int)num2 * -400805208) ^ 0x2460A111;
					continue;
				case 112u:
					num = (int)(num2 * 1703529154) ^ -959104439;
					continue;
				case 111u:
					AddStaff_Admin.smethod_23((Control)(object)ClearBtn, 15);
					num = (int)((num2 * 1393264442) ^ 0x5BC8C0C5);
					continue;
				case 110u:
					AddStaff_Admin.smethod_16((Control)(object)GroupBox2, "GroupBox2");
					num = (int)(num2 * 1737482922) ^ -334251877;
					continue;
				case 109u:
					AddStaff_Admin.smethod_17((Control)(object)AddressTxt, new Size(324, 91));
					num = (int)((num2 * 1784832947) ^ 0x2219266C);
					continue;
				case 108u:
					num = ((int)num2 * -683324450) ^ -566677712;
					continue;
				case 107u:
					num = ((int)num2 * -1327994798) ^ -421418850;
					continue;
				case 106u:
					num = ((int)num2 * -316697592) ^ -1294586967;
					continue;
				case 105u:
					AddStaff_Admin.smethod_22((Control)(object)MobileTxt, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					AddStaff_Admin.smethod_15((Control)(object)MobileTxt, new Point(137, 147));
					num = ((int)num2 * -228711658) ^ 0x7D111785;
					continue;
				case 104u:
					AddStaff_Admin.smethod_17((Control)(object)Label9, new Size(87, 26));
					num = (int)(num2 * 203166868) ^ -112838209;
					continue;
				case 103u:
					AddStaff_Admin.smethod_23((Control)(object)EmailTxt, 19);
					num = ((int)num2 * -1387685729) ^ -1196265777;
					continue;
				case 102u:
					AddStaff_Admin.smethod_22((Control)(object)Label9, AddStaff_Admin.smethod_21("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -479692038) ^ 0x6C8B285C;
					continue;
				case 101u:
					AddStaff_Admin.smethod_13((Control)(object)this);
					num = ((int)num2 * -1886830454) ^ -227638152;
					continue;
				case 100u:
					num = ((int)num2 * -1087878856) ^ 0x3244E31D;
					continue;
				case 99u:
					AddStaff_Admin.smethod_15((Control)(object)SuccessMsg, new Point(305, 156));
					num = ((int)num2 * -573927473) ^ -1782488729;
					continue;
				case 98u:
					AddStaff_Admin.smethod_16((Control)(object)Label9, "Label9");
					num = ((int)num2 * -459269273) ^ 0x79FD0F84;
					continue;
				case 97u:
					AddStaff_Admin.smethod_24(Label8, "Designation :");
					num = (int)(num2 * 2086679297) ^ -1608499310;
					continue;
				case 96u:
					num = (int)(num2 * 180161213) ^ -2002180571;
					continue;
				case 95u:
					AddStaff_Admin.smethod_16((Control)(object)Label2, "Label2");
					AddStaff_Admin.smethod_17((Control)(object)Label2, new Size(92, 23));
					num = (int)((num2 * 854157123) ^ 0x16872C8B);
					continue;
				case 94u:
					num = ((int)num2 * -1289338958) ^ -88722046;
					continue;
				case 93u:
					AddStaff_Admin.smethod_25(Label2, (ContentAlignment)32);
					num = ((int)num2 * -874659792) ^ 0x70772170;
					continue;
				case 92u:
					AddStaff_Admin.smethod_22((Control)(object)Label2, AddStaff_Admin.smethod_21("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1555883815) ^ 0x715BE853);
					continue;
				case 91u:
					AddStaff_Admin.smethod_15((Control)(object)EmailTxt, new Point(137, 307));
					num = (int)(num2 * 248387638) ^ -671512887;
					continue;
				case 90u:
					num = ((int)num2 * -1740234683) ^ 0x1EA3D37;
					continue;
				case 89u:
					AddStaff_Admin.smethod_39(AddStaff_Admin.smethod_38(WorkShiftTxt), new string[3] { "Male", "Female", "Others" });
					num = (int)((num2 * 1753408690) ^ 0x1D6FB1A8);
					continue;
				case 88u:
					AddStaff_Admin.smethod_28((Control)(object)ClearBtn, Color.White);
					num = ((int)num2 * -645962272) ^ 0xE23931F;
					continue;
				case 87u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)Label9);
					num = (int)((num2 * 1973300034) ^ 0x62E92D5A);
					continue;
				case 86u:
					num = ((int)num2 * -1555735563) ^ -2006621401;
					continue;
				case 85u:
					AddStaff_Admin.smethod_43((ListControl)(object)WorkShiftTxt, bool_0: true);
					num = ((int)num2 * -1223826052) ^ 0x52BCF4F1;
					continue;
				case 84u:
					AddStaff_Admin.smethod_17((Control)(object)DesignationTxt, new Size(147, 27));
					num = ((int)num2 * -44439870) ^ 0x860ABD0;
					continue;
				case 83u:
					num = (int)(num2 * 919288935) ^ -1223428143;
					continue;
				case 82u:
					num = (int)(num2 * 1713851171) ^ -1889931039;
					continue;
				case 81u:
					AddStaff_Admin.smethod_17((Control)(object)GenderTxt, new Size(130, 27));
					AddStaff_Admin.smethod_23((Control)(object)GenderTxt, 11);
					num = ((int)num2 * -998625432) ^ -63305347;
					continue;
				case 80u:
					AddStaff_Admin.smethod_15((Control)(object)Label9, new Point(13, 307));
					num = ((int)num2 * -231146305) ^ -1989860013;
					continue;
				case 79u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_53((Control)(object)this), (Control)(object)ClearBtn);
					num = ((int)num2 * -1281915909) ^ 0x28D79A4A;
					continue;
				case 78u:
					AddStaff_Admin.smethod_25(Label3, (ContentAlignment)32);
					num = (int)(num2 * 1094019098) ^ -674979412;
					continue;
				case 77u:
					AddStaff_Admin.smethod_41(DesignationTxt, (AutoCompleteSource)256);
					num = ((int)num2 * -1209869840) ^ -92043466;
					continue;
				case 76u:
					AddStaff_Admin.smethod_20(PictureBox1, bool_0: false);
					num = (int)(num2 * 1337862184) ^ -1586093604;
					continue;
				case 75u:
					AddStaff_Admin.smethod_23((Control)(object)DesignationTxt, 17);
					num = ((int)num2 * -1711400031) ^ -1630867098;
					continue;
				case 74u:
					AddStaff_Admin.smethod_25(Label5, (ContentAlignment)32);
					num = ((int)num2 * -571646904) ^ -1920721425;
					continue;
				case 73u:
					AddStaff_Admin.smethod_22((Control)(object)EmailTxt, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 333144711) ^ 0x5E95435);
					continue;
				case 72u:
					num = (int)(num2 * 1282662459) ^ -742982430;
					continue;
				case 71u:
					AddStaff_Admin.smethod_25(SuccessMsg, (ContentAlignment)32);
					num = ((int)num2 * -975182614) ^ 0x1153086D;
					continue;
				case 70u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_53((Control)(object)this), (Control)(object)GroupBox2);
					num = (int)(num2 * 178695388) ^ -2075948200;
					continue;
				case 68u:
					num = (int)((num2 * 582455962) ^ 0x7294C73A);
					continue;
				case 67u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)Label3);
					num = (int)((num2 * 192041498) ^ 0xC8008C8);
					continue;
				case 66u:
					num = (int)(num2 * 137650422) ^ -976114371;
					continue;
				case 65u:
					AddStaff_Admin.smethod_15((Control)(object)Label6, new Point(15, 348));
					num = (int)(num2 * 1835915058) ^ -1075809227;
					continue;
				case 64u:
					AddStaff_Admin.smethod_17((Control)(object)Label7, new Size(128, 26));
					num = ((int)num2 * -1650536296) ^ 0x3FD1F52;
					continue;
				case 63u:
					AddStaff_Admin.smethod_16((Control)(object)Label5, "Label5");
					AddStaff_Admin.smethod_17((Control)(object)Label5, new Size(94, 29));
					num = ((int)num2 * -1998314152) ^ 0x7C28F464;
					continue;
				case 62u:
					num = ((int)num2 * -1870565845) ^ 0x6FA8EC52;
					continue;
				case 61u:
					num = (int)(num2 * 162670674) ^ -1345561855;
					continue;
				case 60u:
					AddStaff_Admin.smethod_22((Control)(object)NameTxt, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					AddStaff_Admin.smethod_15((Control)(object)NameTxt, new Point(137, 55));
					num = (int)(num2 * 135746805) ^ -1908161497;
					continue;
				case 59u:
					num = (int)((num2 * 339769557) ^ 0x50514343);
					continue;
				case 58u:
					num = (int)(num2 * 381355125) ^ -1958945360;
					continue;
				case 57u:
					AddStaff_Admin.smethod_41(WorkShiftTxt, (AutoCompleteSource)256);
					AddStaff_Admin.smethod_42(WorkShiftTxt, (ComboBoxStyle)2);
					num = ((int)num2 * -836138504) ^ -531523431;
					continue;
				case 56u:
					num = ((int)num2 * -1181690617) ^ 0x3DAFB615;
					continue;
				case 55u:
					num = (int)(num2 * 1782967730) ^ -1577338459;
					continue;
				case 54u:
					num = ((int)num2 * -230998278) ^ 0x2E7EAC57;
					continue;
				case 53u:
					AddStaff_Admin.smethod_54((Control)(object)this, "AddStaff_Admin");
					num = (int)((num2 * 438844485) ^ 0x610C2C8F);
					continue;
				case 52u:
					NameTxt = AddStaff_Admin.smethod_7();
					num = ((int)num2 * -130030580) ^ -1733242126;
					continue;
				case 51u:
					AddStaff_Admin.smethod_17((Control)(object)EmailTxt, new Size(324, 26));
					num = ((int)num2 * -2003427646) ^ -1302380094;
					continue;
				case 50u:
					AddStaff_Admin.smethod_15((Control)(object)WorkShiftTxt, new Point(137, 221));
					num = ((int)num2 * -1673520940) ^ 0x33040DD6;
					continue;
				case 49u:
					num = ((int)num2 * -698433826) ^ 0xC0A3253;
					continue;
				case 48u:
					AddStaff_Admin.smethod_25(Label9, (ContentAlignment)32);
					num = ((int)num2 * -1924211801) ^ 0x7E26E27A;
					continue;
				case 47u:
					DOBTxt = AddStaff_Admin.smethod_6();
					num = (int)(num2 * 1224364462) ^ -386392640;
					continue;
				case 46u:
					AddStaff_Admin.smethod_51((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -487089481) ^ -260047822;
					continue;
				case 45u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)Label5);
					num = (int)(num2 * 1551252062) ^ -1714110347;
					continue;
				case 44u:
					PictureBox1 = AddStaff_Admin.smethod_3();
					num = (int)(num2 * 1804431555) ^ -262800604;
					continue;
				case 43u:
					AddStaff_Admin.smethod_15((Control)(object)PictureBox1, new Point(245, 17));
					num = (int)((num2 * 1105113390) ^ 0x7D9AC617);
					continue;
				case 42u:
					AddStaff_Admin.smethod_17((Control)(object)WorkShiftTxt, new Size(147, 27));
					num = ((int)num2 * -476928934) ^ -1370888149;
					continue;
				case 41u:
					AddStaff_Admin.smethod_22((Control)(object)GroupBox2, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					AddStaff_Admin.smethod_15((Control)(object)GroupBox2, new Point(261, 235));
					num = (int)(num2 * 567862099) ^ -141564347;
					continue;
				case 40u:
					num = ((int)num2 * -848447788) ^ -1240727477;
					continue;
				case 39u:
					num = (int)(num2 * 1053798133) ^ -1986286709;
					continue;
				case 38u:
					num = (int)((num2 * 1187761316) ^ 0x4A6FDBE);
					continue;
				case 37u:
					AddStaff_Admin.smethod_22((Control)(object)GenderTxt, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1411587934) ^ 0x723A2692;
					continue;
				case 36u:
					AddStaff_Admin.smethod_16((Control)(object)GenderTxt, "GenderTxt");
					num = ((int)num2 * -355621908) ^ -6418084;
					continue;
				case 35u:
					AddStaff_Admin.smethod_12((Control)(object)GroupBox2);
					num = ((int)num2 * -799105463) ^ 0x371B6D12;
					continue;
				case 34u:
					num = ((int)num2 * -1173972839) ^ -836911205;
					continue;
				case 33u:
					AddStaff_Admin.smethod_42(GenderTxt, (ComboBoxStyle)2);
					num = (int)(num2 * 761067527) ^ -517162253;
					continue;
				case 32u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)Label8);
					num = ((int)num2 * -1377190881) ^ -1050038444;
					continue;
				case 31u:
					num = ((int)num2 * -2121865468) ^ 0x68EBF72B;
					continue;
				case 30u:
					AddStaff_Admin.smethod_25(Label8, (ContentAlignment)32);
					num = ((int)num2 * -1537513170) ^ -56207813;
					continue;
				case 29u:
					ClearBtn = AddStaff_Admin.smethod_9();
					num = ((int)num2 * -120745245) ^ 0x553EF193;
					continue;
				case 28u:
					AddStaff_Admin.smethod_23((Control)(object)GroupBox2, 13);
					AddStaff_Admin.smethod_32(GroupBox2, bool_0: false);
					num = (int)((num2 * 564165547) ^ 0x3E5BED62);
					continue;
				case 27u:
					RegisterBtn = AddStaff_Admin.smethod_9();
					num = ((int)num2 * -775120131) ^ -1794215638;
					continue;
				case 26u:
					num = (int)(num2 * 2129313717) ^ -811763450;
					continue;
				case 25u:
					AddStaff_Admin.smethod_36(DOBTxt, new DateTime(1900, 1, 1, 0, 0, 0, 0));
					num = (int)((num2 * 193839499) ^ 0x75D4BEE3);
					continue;
				case 24u:
					AddStaff_Admin.smethod_23((Control)(object)Label2, 5);
					num = ((int)num2 * -1048137468) ^ -429638388;
					continue;
				case 23u:
					AddStaff_Admin.smethod_24(Label3, "Gender :");
					num = (int)((num2 * 426053204) ^ 0x324382C);
					continue;
				case 22u:
					AddStaff_Admin.smethod_45(AddStaff_Admin.smethod_44(DesignationTxt), new object[4] { "Doctor", "Nurse", "Receptionist", "Admin" });
					num = (int)((num2 * 123014060) ^ 0x7F5C898B);
					continue;
				case 21u:
					AddStaff_Admin.smethod_28((Control)(object)RegisterBtn, Color.White);
					num = ((int)num2 * -1201894867) ^ 0x505098F3;
					continue;
				case 20u:
					AddStaff_Admin.smethod_23((Control)(object)Label5, 8);
					num = (int)(num2 * 1670693807) ^ -536519172;
					continue;
				case 19u:
					AddStaff_Admin.smethod_33(GroupBox2, "Patient's Information");
					num = (int)((num2 * 1570980247) ^ 0x73B3681D);
					continue;
				case 18u:
					AddStaff_Admin.smethod_49((ButtonBase)(object)ClearBtn, bool_0: false);
					num = ((int)num2 * -535025225) ^ 0x49467D2D;
					continue;
				case 17u:
					num = (int)((num2 * 460941547) ^ 0x7DBAC89);
					continue;
				case 16u:
					num = (int)(num2 * 1335771871) ^ -76566653;
					continue;
				case 15u:
					num = ((int)num2 * -829008597) ^ -1050015563;
					continue;
				case 14u:
					AddStaff_Admin.smethod_55((Control)(object)this, new Size(977, 804));
					AddStaff_Admin.smethod_56((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -1380328808) ^ 0x19CE290A;
					continue;
				case 13u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: false);
					num = (int)((num2 * 907450586) ^ 0xF9199DE);
					continue;
				case 12u:
					AddStaff_Admin.smethod_25(Label6, (ContentAlignment)32);
					num = ((int)num2 * -791352865) ^ -239142700;
					continue;
				case 10u:
					num = ((int)num2 * -484652436) ^ 0x10A5BD3E;
					continue;
				case 9u:
					AddStaff_Admin.smethod_25(Label4, (ContentAlignment)32);
					num = ((int)num2 * -1077298225) ^ 0x5CFAB4D2;
					continue;
				case 8u:
					AddStaff_Admin.smethod_16((Control)(object)SuccessMsg, "SuccessMsg");
					num = ((int)num2 * -1537444222) ^ 0x1B22C7D9;
					continue;
				case 7u:
					AddStaff_Admin.smethod_16((Control)(object)Label8, "Label8");
					num = ((int)num2 * -373754862) ^ 0x24D7ED;
					continue;
				case 6u:
					AddStaff_Admin.smethod_23((Control)(object)Label4, 7);
					num = ((int)num2 * -480061256) ^ -1608652160;
					continue;
				case 5u:
					num = (int)((num2 * 1727156989) ^ 0x27149774);
					continue;
				case 4u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)Label7);
					num = ((int)num2 * -21432230) ^ 0x1C274B24;
					continue;
				case 3u:
					AddStaff_Admin.smethod_40(WorkShiftTxt, (AutoCompleteMode)2);
					num = ((int)num2 * -21385455) ^ 0x73F40961;
					continue;
				case 2u:
					AddStaff_Admin.smethod_23((Control)(object)Label8, 16);
					num = (int)(num2 * 1840619750) ^ -1182991889;
					continue;
				case 1u:
					num = ((int)num2 * -1813293977) ^ -799685423;
					continue;
				case 0u:
					AddStaff_Admin.smethod_23((Control)(object)Label6, 9);
					AddStaff_Admin.smethod_24(Label6, "Address :");
					num = (int)((num2 * 722589756) ^ 0x62B9BFED);
					continue;
				case 11u:
					break;
				default:
					AddStaff_Admin.smethod_59((Control)(object)this, bool_0: false);
					return;
				}
				break;
			}
		}
	}

	private void AddStaff_Admin_Load(object sender, EventArgs e)
	{
		AddStaff_Admin.smethod_35(DOBTxt, AddStaff_Admin.smethod_65(AddStaff_Admin.smethod_64((object)DateTime.Now, "dd-MM-yyyy")));
	}

	private void ClearBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -348527474;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA128E912u) % 12u)
				{
				case 11u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: false);
					num = ((int)num2 * -923428866) ^ 0xA5263D1;
					continue;
				case 10u:
					AddStaff_Admin.smethod_37(DOBTxt, AddStaff_Admin.smethod_65(AddStaff_Admin.smethod_64((object)AddStaff_Admin.smethod_67(), "dd-MM-yyyy")));
					AddStaff_Admin.smethod_68(GenderTxt, -1);
					num = (int)(num2 * 78122277) ^ -112957243;
					continue;
				case 9u:
					num = ((int)num2 * -904165538) ^ -608532112;
					continue;
				case 8u:
					AddStaff_Admin.smethod_66((TextBoxBase)(object)NameTxt);
					num = ((int)num2 * -1769484345) ^ 0x7C1A1255;
					continue;
				case 7u:
					AddStaff_Admin.smethod_66((TextBoxBase)(object)MobileTxt);
					num = (int)(num2 * 921876822) ^ -170911878;
					continue;
				case 6u:
					AddStaff_Admin.smethod_66((TextBoxBase)(object)EmailTxt);
					num = (int)(num2 * 1491984603) ^ -608333955;
					continue;
				case 5u:
					num = ((int)num2 * -1928048705) ^ -770960919;
					continue;
				case 4u:
					AddStaff_Admin.smethod_68(WorkShiftTxt, -1);
					AddStaff_Admin.smethod_68(DesignationTxt, -1);
					num = (int)(num2 * 1391050440) ^ -886496227;
					continue;
				case 3u:
					num = ((int)num2 * -113810461) ^ -981604735;
					continue;
				case 1u:
					AddStaff_Admin.smethod_66((TextBoxBase)(object)AddressTxt);
					num = ((int)num2 * -763989643) ^ 0x54F0F68C;
					continue;
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

	private void RegisterBtn_Click(object sender, EventArgs e)
	{
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected I4, but got Unknown
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected I4, but got Unknown
		//IL_04ee: Incompatible stack heights: 0 vs 1
		//IL_04fe: Incompatible stack heights: 0 vs 1
		//IL_051e: Incompatible stack heights: 0 vs 1
		//IL_0539: Incompatible stack heights: 0 vs 1
		//IL_0568: Incompatible stack heights: 0 vs 1
		//IL_0572: Incompatible stack heights: 0 vs 1
		OleDbConnection oleDbConnection_ = default(OleDbConnection);
		DateTime dateTime_ = default(DateTime);
		bool flag = default(bool);
		while (true)
		{
			int num = 2087751986;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7E0B999Du) % 12u)
				{
				case 11u:
					oleDbConnection_ = AddStaff_Admin.smethod_69();
					num = ((int)num2 * -809379976) ^ -917048661;
					continue;
				case 10u:
					AddStaff_Admin.smethod_71(oleDbConnection_, AddStaff_Admin.smethod_70(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
					num = ((int)num2 * -1972435675) ^ -584292914;
					continue;
				case 9u:
					username = AddStaff_Admin.smethod_73(username, new char[1] { ' ' })[0];
					num = (int)(num2 * 2110289118) ^ -506034697;
					continue;
				case 8u:
					password = Random_Password_Generator();
					num = ((int)num2 * -1353134747) ^ -1347456274;
					continue;
				case 7u:
					dateTime_ = AddStaff_Admin.smethod_65(AddStaff_Admin.smethod_64((object)AddStaff_Admin.smethod_74(DOBTxt), "dd-MM-yyyy"));
					AddStaff_Admin.smethod_75(oleDbConnection_);
					num = ((int)num2 * -1466396485) ^ 0xDCA38CE;
					continue;
				case 6u:
					num = (int)(num2 * 20835533) ^ -2129672056;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1709784842;
						num5 = -1709784842;
					}
					else
					{
						num4 = -2137762510;
						num5 = -2137762510;
					}
					num = num4 ^ ((int)num2 * -77570645);
					continue;
				}
				case 1u:
					flag = !Validate_data();
					num = ((int)num2 * -604027385) ^ -2960201;
					continue;
				case 0u:
					username = AddStaff_Admin.smethod_73(AddStaff_Admin.smethod_72(NameTxt), new char[1] { '.' })[0];
					num = 1740648628;
					continue;
				case 2u:
					break;
				default:
				{
					string string_ = "Insert Into [Staff] ([Name],[Designation],[Date Of Birth],[Gender],[Mobile],[Address],[Work Shift],[Username],[Password]) Values (?,?,?,?,?,?,?,?,?)";
					OleDbCommand val = AddStaff_Admin.smethod_76(string_, oleDbConnection_);
					try
					{
						AddStaff_Admin.smethod_80(AddStaff_Admin.smethod_77(val), AddStaff_Admin.smethod_79("Name", (object)AddStaff_Admin.smethod_78(AddStaff_Admin.smethod_72(NameTxt))));
						AddStaff_Admin.smethod_80(AddStaff_Admin.smethod_77(val), AddStaff_Admin.smethod_79("Designation", (object)AddStaff_Admin.smethod_78(AddStaff_Admin.smethod_81(DesignationTxt))));
						AddStaff_Admin.smethod_80(AddStaff_Admin.smethod_77(val), AddStaff_Admin.smethod_79("Date Of Birth", (object)AddStaff_Admin.smethod_82(dateTime_)));
						AddStaff_Admin.smethod_80(AddStaff_Admin.smethod_77(val), AddStaff_Admin.smethod_79("Gender", (object)AddStaff_Admin.smethod_78(AddStaff_Admin.smethod_81(GenderTxt))));
						while (true)
						{
							int num3 = 641847024;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x7E0B999Du) % 15u)
								{
								case 13u:
									AddStaff_Admin.smethod_80(AddStaff_Admin.smethod_77(val), AddStaff_Admin.smethod_79("Mobile", (object)AddStaff_Admin.smethod_83(AddStaff_Admin.smethod_72(MobileTxt))));
									num3 = ((int)num2 * -643864765) ^ -451019239;
									continue;
								case 12u:
									num3 = ((int)num2 * -310268479) ^ 0x29291F2A;
									continue;
								case 11u:
									AddStaff_Admin.smethod_80(AddStaff_Admin.smethod_77(val), AddStaff_Admin.smethod_79("Work Shift", (object)AddStaff_Admin.smethod_83(AddStaff_Admin.smethod_81(WorkShiftTxt))));
									num3 = (int)(num2 * 1414724899) ^ -1254551937;
									continue;
								case 10u:
									Send_Mail();
									num3 = ((int)num2 * -376057842) ^ -526465513;
									continue;
								case 9u:
									AddStaff_Admin.smethod_86(oleDbConnection_);
									num3 = (int)(num2 * 1843264859) ^ -443080018;
									continue;
								case 8u:
									AddStaff_Admin.smethod_87(Timer1);
									num3 = ((int)num2 * -2092587942) ^ 0x18A147EA;
									continue;
								case 7u:
									num3 = ((int)num2 * -1769969771) ^ -1738233439;
									continue;
								case 6u:
									AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Green);
									num3 = ((int)num2 * -1142162344) ^ -612477751;
									continue;
								case 5u:
									ClearBtn_Click(AddStaff_Admin.smethod_88(sender), e);
									num3 = (int)(num2 * 2068008386) ^ -1419464320;
									continue;
								case 4u:
									AddStaff_Admin.smethod_80(AddStaff_Admin.smethod_77(val), AddStaff_Admin.smethod_79("Username", (object)username));
									AddStaff_Admin.smethod_80(AddStaff_Admin.smethod_77(val), AddStaff_Admin.smethod_79("Password", (object)password));
									AddStaff_Admin.smethod_84(val);
									num3 = (int)(num2 * 1625255519) ^ -362150040;
									continue;
								case 3u:
									AddStaff_Admin.smethod_80(AddStaff_Admin.smethod_77(val), AddStaff_Admin.smethod_79("Address", (object)AddStaff_Admin.smethod_83(AddStaff_Admin.smethod_72(AddressTxt))));
									num3 = (int)(num2 * 1337134547) ^ -443967859;
									continue;
								case 2u:
									AddStaff_Admin.smethod_85((Component)(object)val);
									num3 = ((int)num2 * -1674285948) ^ -1855717454;
									continue;
								case 1u:
									AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
									AddStaff_Admin.smethod_24(SuccessMsg, "Staff Successfully Registered !!");
									num3 = ((int)num2 * -594897731) ^ -1381924855;
									continue;
								case 0u:
									break;
								default:
									AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
									return;
								}
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						AddStaff_Admin.smethod_89(exception_);
						while (true)
						{
							_ = 1812423112;
							while (true)
							{
								_003F val2 = /*Error near IL_04af: Stack underflow*/^ 0x7E0B999D;
								num2 = (uint)(int)val2;
								switch (val2 % 7)
								{
								case 6:
									AddStaff_Admin.smethod_86(oleDbConnection_);
									_ = (num2 * 1289373556) ^ 0x75866B1A;
									continue;
								case 5:
									_ = (num2 * 436663178) ^ 0xA2E2B0A0u;
									continue;
								case 3:
									AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Red);
									_ = (num2 * 1203499113) ^ 0xBF613182u;
									continue;
								case 2:
									AddStaff_Admin.smethod_87(Timer1);
									_ = ((int)num2 * -805233716) ^ -1063340811;
									continue;
								case 0:
									AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
									AddStaff_Admin.smethod_24(SuccessMsg, "Invalid Credentialsl");
									_ = ((int)num2 * -536825846) ^ 0x111F0202;
									continue;
								case 4:
									break;
								default:
									AddStaff_Admin.smethod_90();
									return;
								}
								break;
							}
						}
					}
				}
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private bool Send_Mail()
	{
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected I4, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected I4, but got Unknown
		//IL_023f: Incompatible stack heights: 0 vs 1
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Incompatible stack heights: 0 vs 1
		//IL_0271: Incompatible stack heights: 0 vs 1
		//IL_0278: Incompatible stack heights: 0 vs 1
		try
		{
			SmtpClient smtpClient_ = AddStaff_Admin.smethod_91();
			MailMessage mailMessage_ = AddStaff_Admin.smethod_92();
			while (true)
			{
				IL_01e5:
				int num = -455423985;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8CB1BA76u) % 14u)
					{
					case 13u:
						AddStaff_Admin.smethod_93(smtpClient_, bool_0: false);
						num = (int)(num2 * 1369058622) ^ -1465525109;
						continue;
					case 12u:
						AddStaff_Admin.smethod_104(mailMessage_, bool_0: false);
						num = ((int)num2 * -1991764935) ^ -377740966;
						continue;
					case 10u:
						AddStaff_Admin.smethod_98(smtpClient_, "smtp.gmail.com");
						num = ((int)num2 * -700042916) ^ -1800518682;
						continue;
					case 8u:
						AddStaff_Admin.smethod_97(smtpClient_, bool_0: true);
						num = (int)(num2 * 569436169) ^ -1986050034;
						continue;
					case 7u:
						num = (int)(num2 * 921026319) ^ -1739727287;
						continue;
					case 6u:
						mailMessage_ = AddStaff_Admin.smethod_92();
						AddStaff_Admin.smethod_100(mailMessage_, AddStaff_Admin.smethod_99("tyagianubhav619@gmail.com"));
						num = ((int)num2 * -1580330016) ^ 0x2A29802F;
						continue;
					case 5u:
						AddStaff_Admin.smethod_95(smtpClient_, (ICredentialsByHost)AddStaff_Admin.smethod_94("tyagianubhav619@gmail.com", "tyagi09101999"));
						num = (int)((num2 * 1962544209) ^ 0x5A7AF7D0);
						continue;
					case 4u:
						AddStaff_Admin.smethod_103(mailMessage_, "Login Credential Details");
						num = (int)((num2 * 2054785541) ^ 0x1286A611);
						continue;
					case 3u:
						AddStaff_Admin.smethod_102(AddStaff_Admin.smethod_101(mailMessage_), AddStaff_Admin.smethod_72(EmailTxt));
						num = ((int)num2 * -1009930042) ^ 0xF21FD4C;
						continue;
					case 2u:
						AddStaff_Admin.smethod_106(mailMessage_, AddStaff_Admin.smethod_105(new string[5] { "Your Username is : ", username, " and Password is : ", password, ". Remember your login credentials for future use" }));
						num = ((int)num2 * -33076418) ^ -1163249054;
						continue;
					case 1u:
						AddStaff_Admin.smethod_96(smtpClient_, 587);
						num = ((int)num2 * -886296295) ^ 0x22C86E49;
						continue;
					case 0u:
						num = (int)((num2 * 1084243411) ^ 0x4FB3C229);
						continue;
					case 11u:
						break;
					default:
						AddStaff_Admin.smethod_107(smtpClient_, mailMessage_);
						AddStaff_Admin.smethod_108((object)"Mail Sent", (MsgBoxStyle)0, (object)null);
						goto end_IL_019a;
					}
					goto IL_01e5;
					continue;
					end_IL_019a:
					break;
				}
				break;
			}
		}
		catch (Exception exception_)
		{
			AddStaff_Admin.smethod_89(exception_);
			while (true)
			{
				IL_0273:
				_ = -2026313555;
				while (true)
				{
					_003F val = /*Error near IL_0211: Stack underflow*/^ -1934509450;
					uint num2 = (uint)(int)val;
					switch (val % 5)
					{
					default:
						goto end_IL_020b;
					case 4:
						_ = ((int)num2 * -530325121) ^ -1988515847;
						continue;
					case 1:
						AddStaff_Admin.smethod_108((object)"Cannot Send Mail. Network Not available", (MsgBoxStyle)0, (object)null);
						_ = (num2 * 262381706) ^ 0xB0BA3A6Bu;
						continue;
					case 0:
						AddStaff_Admin.smethod_90();
						_ = ((int)num2 * -272965244) ^ -1861487563;
						continue;
					case 3:
						break;
					case 2:
						goto end_IL_020b;
					}
					goto IL_0273;
					continue;
					end_IL_020b:
					break;
				}
				break;
			}
		}
		bool result = true;
		while (true)
		{
			int num3 = -1318063211;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num3 ^ 0x8CB1BA76u) % 3u)
				{
				case 1u:
					goto IL_0280;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0280:
				num3 = (int)((num2 * 711103239) ^ 0x23FEAA89);
			}
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: false);
		while (true)
		{
			int num = 1782304657;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5E542CE5u) % 3u)
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
				AddStaff_Admin.smethod_109(Timer1);
				num = ((int)num2 * -1430567954) ^ 0x3C3E8FC2;
			}
		}
	}

	private bool Validate_data()
	{
		bool flag = !MyProject.Forms.Form1.Name_Validation(AddStaff_Admin.smethod_78(AddStaff_Admin.smethod_72(NameTxt)));
		bool result = default(bool);
		bool flag6 = default(bool);
		bool flag4 = default(bool);
		bool flag5 = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = -530677466;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB865C2CBu) % 74u)
				{
				case 73u:
					num = (int)(num2 * 179344310) ^ -1244787117;
					continue;
				case 72u:
				{
					int num15;
					int num16;
					if (AddStaff_Admin.smethod_110(DesignationTxt) != -1)
					{
						num15 = 1819497893;
						num16 = 1819497893;
					}
					else
					{
						num15 = 65472986;
						num16 = 65472986;
					}
					num = num15 ^ ((int)num2 * -1289977897);
					continue;
				}
				case 71u:
					AddStaff_Admin.smethod_87(Timer1);
					num = (int)(num2 * 1339910224) ^ -1571822572;
					continue;
				case 70u:
					num = ((int)num2 * -385715314) ^ -36777962;
					continue;
				case 69u:
					result = false;
					num = (int)(num2 * 140305021) ^ -664996620;
					continue;
				case 68u:
				{
					int num17;
					int num18;
					if (!flag6)
					{
						num17 = 1469616278;
						num18 = 1469616278;
					}
					else
					{
						num17 = 670836320;
						num18 = 670836320;
					}
					num = num17 ^ (int)(num2 * 1375641560);
					continue;
				}
				case 67u:
					num = ((int)num2 * -948252720) ^ -939099700;
					continue;
				case 66u:
					num = ((int)num2 * -1420490725) ^ 0x51BFDB11;
					continue;
				case 65u:
					num = (int)((num2 * 1014959246) ^ 0x1E23CAD7);
					continue;
				case 64u:
					AddStaff_Admin.smethod_87(Timer1);
					num = ((int)num2 * -246832381) ^ -2065324719;
					continue;
				case 63u:
					result = true;
					num = (int)((num2 * 593658958) ^ 0x3DF6DF43);
					continue;
				case 62u:
				{
					int num7;
					int num8;
					if (!flag4)
					{
						num7 = -100739324;
						num8 = -100739324;
					}
					else
					{
						num7 = -1084420702;
						num8 = -1084420702;
					}
					num = num7 ^ (int)(num2 * 1015590853);
					continue;
				}
				case 61u:
					num = ((int)num2 * -9584757) ^ 0x41FA4782;
					continue;
				case 60u:
					num = (int)((num2 * 210302256) ^ 0x2022DC75);
					continue;
				case 59u:
					num = (int)((num2 * 872053935) ^ 0x12D239F1);
					continue;
				case 58u:
					AddStaff_Admin.smethod_87(Timer1);
					num = ((int)num2 * -1294332540) ^ 0x76297D0E;
					continue;
				case 57u:
					AddStaff_Admin.smethod_24(SuccessMsg, "Adress required ");
					num = (int)(num2 * 152531287) ^ -584030491;
					continue;
				case 56u:
					num = ((int)num2 * -458156743) ^ 0x78F72DE3;
					continue;
				case 55u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
					AddStaff_Admin.smethod_24(SuccessMsg, "Invalid Designation");
					num = (int)(num2 * 1911263176) ^ -1559440220;
					continue;
				case 54u:
					num = -975075377;
					continue;
				case 53u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -930415847) ^ -1850438268;
					continue;
				case 52u:
					flag4 = !MyProject.Forms.Form1.Gender_Validator(AddStaff_Admin.smethod_78(AddStaff_Admin.smethod_81(GenderTxt)));
					num = (int)(num2 * 288004529) ^ -1840806073;
					continue;
				case 50u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -287038458) ^ -376329494;
					continue;
				case 49u:
				{
					int num13;
					int num14;
					if (flag5)
					{
						num13 = -342654444;
						num14 = -342654444;
					}
					else
					{
						num13 = -1004383990;
						num14 = -1004383990;
					}
					num = num13 ^ ((int)num2 * -1985086926);
					continue;
				}
				case 48u:
					AddStaff_Admin.smethod_87(Timer1);
					num = ((int)num2 * -2040385396) ^ -2069249994;
					continue;
				case 47u:
					AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Red);
					AddStaff_Admin.smethod_87(Timer1);
					num = (int)(num2 * 30211899) ^ -146969341;
					continue;
				case 46u:
					num = -1700942805;
					continue;
				case 45u:
					num = -1192867665;
					continue;
				case 44u:
					num = (int)(num2 * 600625801) ^ -766083803;
					continue;
				case 43u:
				{
					int num11;
					int num12;
					if (flag2)
					{
						num11 = -460906156;
						num12 = -460906156;
					}
					else
					{
						num11 = -1836539039;
						num12 = -1836539039;
					}
					num = num11 ^ (int)(num2 * 542451831);
					continue;
				}
				case 42u:
					num = (int)((num2 * 1669189820) ^ 0x21632F55);
					continue;
				case 41u:
				{
					int num9;
					int num10;
					if (!flag)
					{
						num9 = -286042886;
						num10 = -286042886;
					}
					else
					{
						num9 = -267812799;
						num10 = -267812799;
					}
					num = num9 ^ (int)(num2 * 1709259246);
					continue;
				}
				case 40u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
					num = (int)(num2 * 790106563) ^ -201055603;
					continue;
				case 39u:
					AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Red);
					num = (int)(num2 * 1961000895) ^ -1823238201;
					continue;
				case 38u:
					AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -1267646336) ^ -60431076;
					continue;
				case 37u:
					num = (int)((num2 * 1736417460) ^ 0x3BBF9334);
					continue;
				case 36u:
					result = false;
					num = ((int)num2 * -1984979158) ^ 0x5A6683CA;
					continue;
				case 35u:
					AddStaff_Admin.smethod_24(SuccessMsg, "Invalid Gender");
					num = (int)(num2 * 437671386) ^ -1807314301;
					continue;
				case 34u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -1649411556) ^ -670963826;
					continue;
				case 33u:
					num = ((int)num2 * -1293718166) ^ 0x7ED900D3;
					continue;
				case 32u:
					AddStaff_Admin.smethod_24(SuccessMsg, "Invalid Gender");
					num = ((int)num2 * -220958596) ^ 0x58A3953F;
					continue;
				case 31u:
					AddStaff_Admin.smethod_24(SuccessMsg, "Invalid Workshift Number");
					num = (int)(num2 * 482250661) ^ -325768480;
					continue;
				case 30u:
					AddStaff_Admin.smethod_24(SuccessMsg, "Invalid Mobile Number");
					AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Red);
					AddStaff_Admin.smethod_87(Timer1);
					num = ((int)num2 * -332084712) ^ -1191175561;
					continue;
				case 29u:
					num = -1831898822;
					continue;
				case 28u:
					AddStaff_Admin.smethod_87(Timer1);
					num = ((int)num2 * -328978526) ^ 0x2E7BBBA6;
					continue;
				case 27u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
					num = (int)((num2 * 1119309867) ^ 0x73185452);
					continue;
				case 26u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
					num = (int)(num2 * 1610276085) ^ -1498798201;
					continue;
				case 25u:
					num = (int)(num2 * 1736089042) ^ -434404381;
					continue;
				case 24u:
					flag6 = AddStaff_Admin.smethod_111(AddStaff_Admin.smethod_72(AddressTxt), "", bool_0: false) == 0;
					num = ((int)num2 * -36953968) ^ -489405555;
					continue;
				case 23u:
					flag5 = !MyProject.Forms.Form1.Mobile_Validator(AddStaff_Admin.smethod_72(MobileTxt));
					num = -1685073938;
					continue;
				case 22u:
				{
					int num5;
					int num6;
					if (!flag3)
					{
						num5 = 262929002;
						num6 = 262929002;
					}
					else
					{
						num5 = 2005120351;
						num6 = 2005120351;
					}
					num = num5 ^ (int)(num2 * 657384545);
					continue;
				}
				case 21u:
					result = false;
					num = (int)(num2 * 1888455486) ^ -557797555;
					continue;
				case 20u:
					AddStaff_Admin.smethod_24(SuccessMsg, "Invalid Name");
					num = (int)(num2 * 243717097) ^ -1879872744;
					continue;
				case 19u:
					num = -1198249063;
					continue;
				case 18u:
					AddStaff_Admin.smethod_24(SuccessMsg, "Email field is required");
					num = ((int)num2 * -443028449) ^ -169546637;
					continue;
				case 17u:
					num = ((int)num2 * -1367626839) ^ -1666030172;
					continue;
				case 16u:
					AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -1148498075) ^ -1756943531;
					continue;
				case 15u:
					AddStaff_Admin.smethod_87(Timer1);
					num = (int)(num2 * 101046627) ^ -526931724;
					continue;
				case 14u:
				{
					int num3;
					int num4;
					if (AddStaff_Admin.smethod_110(GenderTxt) == -1)
					{
						num3 = -860064435;
						num4 = -860064435;
					}
					else
					{
						num3 = -449643813;
						num4 = -449643813;
					}
					num = num3 ^ ((int)num2 * -425319351);
					continue;
				}
				case 13u:
					flag3 = AddStaff_Admin.smethod_110(WorkShiftTxt) == -1;
					num = -1307476581;
					continue;
				case 11u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -561103394) ^ -600819540;
					continue;
				case 10u:
					result = false;
					num = (int)((num2 * 403488334) ^ 0x1C94E738);
					continue;
				case 9u:
					result = false;
					num = (int)((num2 * 1244449366) ^ 0x8E86513);
					continue;
				case 8u:
					num = ((int)num2 * -1300722784) ^ 0x42B57E33;
					continue;
				case 7u:
					flag2 = AddStaff_Admin.smethod_111(AddStaff_Admin.smethod_72(EmailTxt), "", bool_0: false) == 0;
					num = -200268384;
					continue;
				case 6u:
					num = ((int)num2 * -1271638364) ^ 0x2122A600;
					continue;
				case 5u:
					result = false;
					num = ((int)num2 * -155603645) ^ 0x7B877245;
					continue;
				case 4u:
					num = (int)((num2 * 1811630317) ^ 0xBF39611);
					continue;
				case 3u:
					result = false;
					num = (int)(num2 * 1428321464) ^ -2139672668;
					continue;
				case 2u:
					AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Red);
					num = (int)((num2 * 1105318933) ^ 0x2FF6F8C8);
					continue;
				case 1u:
					AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Red);
					num = (int)((num2 * 1095288959) ^ 0x1C396C00);
					continue;
				case 0u:
					AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -919272350) ^ 0x5F249BF1;
					continue;
				case 51u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private string Random_Password_Generator()
	{
		Random random_ = default(Random);
		string string_ = default(string);
		string text = default(string);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = -1311425805;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE1F74A12u) % 7u)
				{
				case 4u:
					num = (int)(num2 * 1550399343) ^ -543315689;
					continue;
				case 3u:
				{
					int int_ = AddStaff_Admin.smethod_114(random_, 0, AddStaff_Admin.smethod_113(string_));
					char char_ = AddStaff_Admin.smethod_115(string_, int_);
					text = AddStaff_Admin.smethod_70(text, AddStaff_Admin.smethod_116(char_));
					num3 = checked(num3 + 1);
					int num4;
					if (num3 <= 10)
					{
						num = -1010950424;
						num4 = -1010950424;
					}
					else
					{
						num = -741063593;
						num4 = -741063593;
					}
					continue;
				}
				case 2u:
					string_ = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
					text = "";
					random_ = AddStaff_Admin.smethod_112();
					num = ((int)num2 * -1036367254) ^ -1228424520;
					continue;
				case 1u:
					num3 = 1;
					num = (int)((num2 * 1304965298) ^ 0x78E689E8);
					continue;
				case 0u:
					result = text;
					num = ((int)num2 * -1044671244) ^ -1179385631;
					continue;
				case 6u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	static void smethod_0(UserControl userControl_0, EventHandler eventHandler_0)
	{
		userControl_0.add_Load(eventHandler_0);
	}

	static void smethod_1(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_2()
	{
		return new Container();
	}

	static PictureBox smethod_3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PictureBox();
	}

	static Label smethod_4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static GroupBox smethod_5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new GroupBox();
	}

	static DateTimePicker smethod_6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DateTimePicker();
	}

	static TextBox smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static ComboBox smethod_8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ComboBox();
	}

	static Button smethod_9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static Timer smethod_10(IContainer icontainer_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_0);
	}

	static void smethod_11(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_12(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_13(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_14(PictureBox pictureBox_0, Image image_0)
	{
		pictureBox_0.set_Image(image_0);
	}

	static void smethod_15(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_16(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_17(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_18(PictureBox pictureBox_0, PictureBoxSizeMode pictureBoxSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		pictureBox_0.set_SizeMode(pictureBoxSizeMode_0);
	}

	static void smethod_19(PictureBox pictureBox_0, int int_0)
	{
		pictureBox_0.set_TabIndex(int_0);
	}

	static void smethod_20(PictureBox pictureBox_0, bool bool_0)
	{
		pictureBox_0.set_TabStop(bool_0);
	}

	static Font smethod_21(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_22(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_23(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_24(Label label_0, string string_0)
	{
		label_0.set_Text(string_0);
	}

	static void smethod_25(Label label_0, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_TextAlign(contentAlignment_0);
	}

	static void smethod_26(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static Color smethod_27()
	{
		return SystemColors.ButtonHighlight;
	}

	static void smethod_28(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
	}

	static void smethod_29(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static ControlCollection smethod_30(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_31(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_32(GroupBox groupBox_0, bool bool_0)
	{
		groupBox_0.set_TabStop(bool_0);
	}

	static void smethod_33(GroupBox groupBox_0, string string_0)
	{
		groupBox_0.set_Text(string_0);
	}

	static void smethod_34(DateTimePicker dateTimePicker_0, DateTimePickerFormat dateTimePickerFormat_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		dateTimePicker_0.set_Format(dateTimePickerFormat_0);
	}

	static void smethod_35(DateTimePicker dateTimePicker_0, DateTime dateTime_0)
	{
		dateTimePicker_0.set_MaxDate(dateTime_0);
	}

	static void smethod_36(DateTimePicker dateTimePicker_0, DateTime dateTime_0)
	{
		dateTimePicker_0.set_MinDate(dateTime_0);
	}

	static void smethod_37(DateTimePicker dateTimePicker_0, DateTime dateTime_0)
	{
		dateTimePicker_0.set_Value(dateTime_0);
	}

	static AutoCompleteStringCollection smethod_38(ComboBox comboBox_0)
	{
		return comboBox_0.get_AutoCompleteCustomSource();
	}

	static void smethod_39(AutoCompleteStringCollection autoCompleteStringCollection_0, string[] string_0)
	{
		autoCompleteStringCollection_0.AddRange(string_0);
	}

	static void smethod_40(ComboBox comboBox_0, AutoCompleteMode autoCompleteMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		comboBox_0.set_AutoCompleteMode(autoCompleteMode_0);
	}

	static void smethod_41(ComboBox comboBox_0, AutoCompleteSource autoCompleteSource_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		comboBox_0.set_AutoCompleteSource(autoCompleteSource_0);
	}

	static void smethod_42(ComboBox comboBox_0, ComboBoxStyle comboBoxStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		comboBox_0.set_DropDownStyle(comboBoxStyle_0);
	}

	static void smethod_43(ListControl listControl_0, bool bool_0)
	{
		listControl_0.set_FormattingEnabled(bool_0);
	}

	static ObjectCollection smethod_44(ComboBox comboBox_0)
	{
		return comboBox_0.get_Items();
	}

	static void smethod_45(ObjectCollection objectCollection_0, object[] object_0)
	{
		objectCollection_0.AddRange(object_0);
	}

	static void smethod_46(TextBox textBox_0, bool bool_0)
	{
		textBox_0.set_Multiline(bool_0);
	}

	static void smethod_47(ButtonBase buttonBase_0, Color color_0)
	{
		buttonBase_0.set_BackColor(color_0);
	}

	static void smethod_48(ButtonBase buttonBase_0, string string_0)
	{
		buttonBase_0.set_Text(string_0);
	}

	static void smethod_49(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_50(Timer timer_0, int int_0)
	{
		timer_0.set_Interval(int_0);
	}

	static void smethod_51(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_52(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static ControlCollection smethod_53(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_54(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_55(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_56(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_57(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_58(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_59(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_60(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_61(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_62(Timer timer_0, EventHandler eventHandler_0)
	{
		timer_0.remove_Tick(eventHandler_0);
	}

	static void smethod_63(Timer timer_0, EventHandler eventHandler_0)
	{
		timer_0.add_Tick(eventHandler_0);
	}

	static string smethod_64(object object_0, string string_0)
	{
		return Strings.Format(object_0, string_0);
	}

	static DateTime smethod_65(string string_0)
	{
		return Conversions.ToDate(string_0);
	}

	static void smethod_66(TextBoxBase textBoxBase_0)
	{
		textBoxBase_0.Clear();
	}

	static DateTime smethod_67()
	{
		return DateAndTime.get_Today();
	}

	static void smethod_68(ComboBox comboBox_0, int int_0)
	{
		comboBox_0.set_SelectedIndex(int_0);
	}

	static OleDbConnection smethod_69()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new OleDbConnection();
	}

	static string smethod_70(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_71(OleDbConnection oleDbConnection_0, string string_0)
	{
		oleDbConnection_0.set_ConnectionString(string_0);
	}

	static string smethod_72(TextBox textBox_0)
	{
		return textBox_0.get_Text();
	}

	static string[] smethod_73(string string_0, char[] char_0)
	{
		return string_0.Split(char_0);
	}

	static DateTime smethod_74(DateTimePicker dateTimePicker_0)
	{
		return dateTimePicker_0.get_Value();
	}

	static void smethod_75(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Open();
	}

	static OleDbCommand smethod_76(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbCommand(string_0, oleDbConnection_0);
	}

	static OleDbParameterCollection smethod_77(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.get_Parameters();
	}

	static string smethod_78(string string_0)
	{
		return string_0.ToLower();
	}

	static OleDbParameter smethod_79(string string_0, object object_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbParameter(string_0, object_0);
	}

	static OleDbParameter smethod_80(OleDbParameterCollection oleDbParameterCollection_0, OleDbParameter oleDbParameter_0)
	{
		return oleDbParameterCollection_0.Add(oleDbParameter_0);
	}

	static string smethod_81(ComboBox comboBox_0)
	{
		return comboBox_0.get_Text();
	}

	static string smethod_82(DateTime dateTime_0)
	{
		return Conversions.ToString(dateTime_0);
	}

	static string smethod_83(string string_0)
	{
		return string_0.ToString();
	}

	static int smethod_84(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.ExecuteNonQuery();
	}

	static void smethod_85(Component component_0)
	{
		component_0.Dispose();
	}

	static void smethod_86(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Close();
	}

	static void smethod_87(Timer timer_0)
	{
		timer_0.Start();
	}

	static object smethod_88(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}

	static void smethod_89(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_90()
	{
		ProjectData.ClearProjectError();
	}

	static SmtpClient smethod_91()
	{
		return new SmtpClient();
	}

	static MailMessage smethod_92()
	{
		return new MailMessage();
	}

	static void smethod_93(SmtpClient smtpClient_0, bool bool_0)
	{
		smtpClient_0.UseDefaultCredentials = bool_0;
	}

	static NetworkCredential smethod_94(string string_0, string string_1)
	{
		return new NetworkCredential(string_0, string_1);
	}

	static void smethod_95(SmtpClient smtpClient_0, ICredentialsByHost icredentialsByHost_0)
	{
		smtpClient_0.Credentials = icredentialsByHost_0;
	}

	static void smethod_96(SmtpClient smtpClient_0, int int_0)
	{
		smtpClient_0.Port = int_0;
	}

	static void smethod_97(SmtpClient smtpClient_0, bool bool_0)
	{
		smtpClient_0.EnableSsl = bool_0;
	}

	static void smethod_98(SmtpClient smtpClient_0, string string_0)
	{
		smtpClient_0.Host = string_0;
	}

	static MailAddress smethod_99(string string_0)
	{
		return new MailAddress(string_0);
	}

	static void smethod_100(MailMessage mailMessage_0, MailAddress mailAddress_0)
	{
		mailMessage_0.From = mailAddress_0;
	}

	static MailAddressCollection smethod_101(MailMessage mailMessage_0)
	{
		return mailMessage_0.To;
	}

	static void smethod_102(MailAddressCollection mailAddressCollection_0, string string_0)
	{
		mailAddressCollection_0.Add(string_0);
	}

	static void smethod_103(MailMessage mailMessage_0, string string_0)
	{
		mailMessage_0.Subject = string_0;
	}

	static void smethod_104(MailMessage mailMessage_0, bool bool_0)
	{
		mailMessage_0.IsBodyHtml = bool_0;
	}

	static string smethod_105(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static void smethod_106(MailMessage mailMessage_0, string string_0)
	{
		mailMessage_0.Body = string_0;
	}

	static void smethod_107(SmtpClient smtpClient_0, MailMessage mailMessage_0)
	{
		smtpClient_0.Send(mailMessage_0);
	}

	static MsgBoxResult smethod_108(object object_0, MsgBoxStyle msgBoxStyle_0, object object_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return Interaction.MsgBox(object_0, msgBoxStyle_0, object_1);
	}

	static void smethod_109(Timer timer_0)
	{
		timer_0.Stop();
	}

	static int smethod_110(ComboBox comboBox_0)
	{
		return comboBox_0.get_SelectedIndex();
	}

	static int smethod_111(string string_0, string string_1, bool bool_0)
	{
		return Operators.CompareString(string_0, string_1, bool_0);
	}

	static Random smethod_112()
	{
		return new Random();
	}

	static int smethod_113(string string_0)
	{
		return string_0.Length;
	}

	static int smethod_114(Random random_0, int int_0, int int_1)
	{
		return random_0.Next(int_0, int_1);
	}

	static char smethod_115(string string_0, int int_0)
	{
		return string_0[int_0];
	}

	static string smethod_116(char char_0)
	{
		return Conversions.ToString(char_0);
	}
}
