using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hospital_Management_System.My;
using Hospital_Management_System.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace Hospital_Management_System;

[DesignerGenerated]
internal class RegisterDonor : UserControl
{
	private IContainer components;

	private OleDbConnection myconnection;

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
				int num = -454459202;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA1AEE937u) % 8u)
					{
					case 7u:
						_Timer1 = value;
						num = -538511967;
						continue;
					case 6u:
						timer = _Timer1;
						num = (int)(num2 * 1074094936) ^ -331608116;
						continue;
					case 5u:
						RegisterDonor.smethod_57(timer, eventHandler_);
						num = ((int)num2 * -1159657384) ^ 0x4A999255;
						continue;
					case 3u:
					{
						int num5;
						int num6;
						if (timer != null)
						{
							num5 = 1443679463;
							num6 = 1443679463;
						}
						else
						{
							num5 = 200063896;
							num6 = 200063896;
						}
						num = num5 ^ ((int)num2 * -1021006177);
						continue;
					}
					case 1u:
					{
						timer = _Timer1;
						int num3;
						int num4;
						if (timer == null)
						{
							num3 = -356834349;
							num4 = -356834349;
						}
						else
						{
							num3 = -678578292;
							num4 = -678578292;
						}
						num = num3 ^ ((int)num2 * -1810147397);
						continue;
					}
					case 0u:
						RegisterDonor.smethod_56(timer, eventHandler_);
						num = (int)(num2 * 1808801054) ^ -1980256656;
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
	}

	[field: AccessedThroughProperty("SuccessMsg")]
	internal virtual Label SuccessMsg
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			Button clearBtn = _ClearBtn;
			while (true)
			{
				int num = 1289443933;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x545E5B6Eu) % 7u)
					{
					case 6u:
						RegisterDonor.smethod_58((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -735894298) ^ 0x7AE6ED6F;
						continue;
					case 5u:
					{
						clearBtn = _ClearBtn;
						int num5;
						int num6;
						if (clearBtn != null)
						{
							num5 = 1784008225;
							num6 = 1784008225;
						}
						else
						{
							num5 = 674268280;
							num6 = 674268280;
						}
						num = num5 ^ ((int)num2 * -1533059099);
						continue;
					}
					case 2u:
					{
						int num3;
						int num4;
						if (clearBtn == null)
						{
							num3 = 268438512;
							num4 = 268438512;
						}
						else
						{
							num3 = 1295421149;
							num4 = 1295421149;
						}
						num = num3 ^ (int)(num2 * 29649021);
						continue;
					}
					case 1u:
						_ClearBtn = value;
						num = 1511752375;
						continue;
					case 0u:
						RegisterDonor.smethod_59((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -1728134199) ^ -605986041;
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
	}

	internal virtual Button AddBtn
	{
		[CompilerGenerated]
		get
		{
			return _AddBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = Button1_Click;
			Button addBtn = default(Button);
			while (true)
			{
				int num = -1596673102;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9BFFE55Eu) % 9u)
					{
					case 8u:
						RegisterDonor.smethod_59((Control)(object)addBtn, eventHandler_);
						num = ((int)num2 * -519813114) ^ -1501724468;
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (addBtn != null)
						{
							num5 = -197862907;
							num6 = -197862907;
						}
						else
						{
							num5 = -2145084952;
							num6 = -2145084952;
						}
						num = num5 ^ (int)(num2 * 352211294);
						continue;
					}
					case 5u:
						RegisterDonor.smethod_58((Control)(object)addBtn, eventHandler_);
						num = ((int)num2 * -2123020713) ^ -1954820061;
						continue;
					case 4u:
						addBtn = _AddBtn;
						num = ((int)num2 * -955562474) ^ -1209994765;
						continue;
					case 2u:
						addBtn = _AddBtn;
						num = ((int)num2 * -1129762721) ^ -304014753;
						continue;
					case 1u:
						_AddBtn = value;
						num = -2051130396;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (addBtn != null)
						{
							num3 = 1004841216;
							num4 = 1004841216;
						}
						else
						{
							num3 = 266322459;
							num4 = 266322459;
						}
						num = num3 ^ (int)(num2 * 242258423);
						continue;
					}
					default:
						return;
					case 7u:
						break;
					case 3u:
						return;
					}
					break;
				}
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox8")]
	internal virtual CheckBox CheckBox8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox7")]
	internal virtual CheckBox CheckBox7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox6")]
	internal virtual CheckBox CheckBox6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox5")]
	internal virtual CheckBox CheckBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox4")]
	internal virtual CheckBox CheckBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox3")]
	internal virtual CheckBox CheckBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox2")]
	internal virtual CheckBox CheckBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox1")]
	internal virtual CheckBox CheckBox1
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

	[field: AccessedThroughProperty("DateTxt")]
	internal virtual TextBox DateTxt
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

	[field: AccessedThroughProperty("QuantityTxt")]
	internal virtual TextBox QuantityTxt
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

	[field: AccessedThroughProperty("WarningLbl")]
	internal virtual Label WarningLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BloodGrpTxt")]
	internal virtual ComboBox BloodGrpTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BloodGrpLbl")]
	internal virtual Label BloodGrpLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox GenderTxt
	{
		[CompilerGenerated]
		get
		{
			return _GenderTxt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = GenderTxt_SelectionChangeCommitted;
			ComboBox genderTxt = _GenderTxt;
			if (genderTxt != null)
			{
				goto IL_0082;
			}
			goto IL_00b4;
			IL_00b4:
			_GenderTxt = value;
			int num = 160566760;
			goto IL_0087;
			IL_0087:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2A5E1DCBu) % 7u)
				{
				case 6u:
					RegisterDonor.smethod_61(genderTxt, eventHandler_);
					num = (int)((num2 * 2137526165) ^ 0x7F4A6DEE);
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (genderTxt == null)
					{
						num3 = -822393393;
						num4 = -822393393;
					}
					else
					{
						num3 = -2100163202;
						num4 = -2100163202;
					}
					num = num3 ^ ((int)num2 * -1990501469);
					continue;
				}
				case 3u:
					genderTxt = _GenderTxt;
					num = ((int)num2 * -897063395) ^ -1328824360;
					continue;
				case 2u:
					RegisterDonor.smethod_60(genderTxt, eventHandler_);
					num = (int)((num2 * 2107366712) ^ 0x425FCDC0);
					continue;
				case 0u:
					break;
				default:
					return;
				case 5u:
					goto IL_00b4;
				case 1u:
					return;
				}
				break;
			}
			goto IL_0082;
			IL_0082:
			num = 925047567;
			goto IL_0087;
		}
	}

	[field: AccessedThroughProperty("AgeLbl")]
	internal virtual Label AgeLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("AgeTxt")]
	internal virtual TextBox AgeTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MobileLbl")]
	internal virtual Label MobileLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GenderLbl")]
	internal virtual Label GenderLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NameLbl")]
	internal virtual Label NameLbl
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

	[field: AccessedThroughProperty("NameTxt")]
	internal virtual TextBox NameTxt
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

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public RegisterDonor()
	{
		while (true)
		{
			int num = 1600038458;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x175BE301u) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 0u:
					break;
				default:
					InitializeComponent();
					return;
				}
				break;
				IL_0008:
				RegisterDonor.smethod_0((UserControl)(object)this, (EventHandler)RegisterDonor_Load);
				myconnection = RegisterDonor.smethod_1();
				num = (int)(num2 * 972118836) ^ -45797006;
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			while (true)
			{
				int num = -1327013544;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xA281B752u) % 7u)
					{
					case 6u:
						if (components != null)
						{
							num = -119923733;
							num3 = -119923733;
							continue;
						}
						goto IL_001e;
					case 5u:
						num = (int)((num2 * 830505981) ^ 0x1078BA58);
						continue;
					case 4u:
						RegisterDonor.smethod_2((IDisposable)components);
						num = (int)((num2 * 929776987) ^ 0x6416B8A1);
						continue;
					case 3u:
						if (disposing)
						{
							num = ((int)num2 * -1922560826) ^ 0x6B37D327;
							continue;
						}
						goto IL_001e;
					case 1u:
						num = ((int)num2 * -2012725827) ^ -500616661;
						continue;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
						IL_001e:
						num = -966896963;
						num3 = -966896963;
						continue;
					}
					break;
				}
			}
		}
		finally
		{
			((ContainerControl)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		while (true)
		{
			int num = 1813487531;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5EE9793Du) % 379u)
				{
				case 378u:
					num = ((int)num2 * -198493291) ^ -202702619;
					continue;
				case 377u:
					RegisterDonor.smethod_17((Control)(object)CheckBox5, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1898663798) ^ -470991332;
					continue;
				case 376u:
					RegisterDonor.smethod_38((ListControl)(object)BloodGrpTxt, bool_0: true);
					RegisterDonor.smethod_40(RegisterDonor.smethod_39(BloodGrpTxt), new object[9] { "--Select--", "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
					num = ((int)num2 * -1324159223) ^ 0x5EABF0C5;
					continue;
				case 375u:
					RegisterDonor.smethod_28((ButtonBase)(object)AddBtn, "Add Donor");
					RegisterDonor.smethod_29((ButtonBase)(object)AddBtn, bool_0: false);
					num = (int)((num2 * 403358577) ^ 0x4664D920);
					continue;
				case 374u:
					RegisterDonor.smethod_20((Control)(object)MobileLbl, new Size(76, 19));
					num = ((int)num2 * -969394471) ^ -2036212055;
					continue;
				case 373u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox1), (Control)(object)Label3);
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox1), (Control)(object)CheckBox8);
					num = (int)(num2 * 38341436) ^ -118985594;
					continue;
				case 372u:
					RegisterDonor.smethod_20((Control)(object)CheckBox5, new Size(91, 23));
					num = (int)(num2 * 1523190154) ^ -1566692759;
					continue;
				case 371u:
					num = (int)(num2 * 1561818196) ^ -91265407;
					continue;
				case 370u:
					num = ((int)num2 * -2131865704) ^ -876037554;
					continue;
				case 369u:
					RegisterDonor.smethod_20((Control)(object)NameTxt, new Size(355, 26));
					num = (int)(num2 * 2054305609) ^ -291492957;
					continue;
				case 368u:
					RegisterDonor.smethod_17((Control)(object)AgeTxt, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1784579992) ^ -1672471410;
					continue;
				case 367u:
					RegisterDonor.smethod_18((Control)(object)AddBtn, new Point(760, 704));
					RegisterDonor.smethod_19((Control)(object)AddBtn, "AddBtn");
					num = ((int)num2 * -1409975609) ^ 0x5E521C19;
					continue;
				case 366u:
					RegisterDonor.smethod_22(NameLbl, "Name :");
					num = (int)(num2 * 25454389) ^ -1411993975;
					continue;
				case 365u:
					RegisterDonor.smethod_19((Control)(object)CheckBox4, "CheckBox4");
					num = ((int)num2 * -1847102089) ^ -1893690116;
					continue;
				case 364u:
					RegisterDonor.smethod_20((Control)(object)CheckBox3, new Size(60, 23));
					num = (int)((num2 * 954228942) ^ 0x6A1C944B);
					continue;
				case 363u:
					RegisterDonor.smethod_52((Control)(object)GroupBox2);
					num = (int)(num2 * 1070897299) ^ -1554113449;
					continue;
				case 362u:
					RegisterDonor.smethod_36(MobileLbl, bool_0: true);
					RegisterDonor.smethod_17((Control)(object)MobileLbl, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					RegisterDonor.smethod_18((Control)(object)MobileLbl, new Point(25, 181));
					num = ((int)num2 * -895965782) ^ 0x5B69907D;
					continue;
				case 361u:
					RegisterDonor.smethod_20((Control)(object)CheckBox1, new Size(127, 23));
					num = (int)(num2 * 582731263) ^ -1931542502;
					continue;
				case 360u:
					num = ((int)num2 * -416259607) ^ -2068906691;
					continue;
				case 359u:
					num = ((int)num2 * -648100011) ^ 0x8B80EEF;
					continue;
				case 358u:
					num = ((int)num2 * -1580354283) ^ 0x531AE500;
					continue;
				case 357u:
					RegisterDonor.smethod_34((ButtonBase)(object)CheckBox3, bool_0: true);
					RegisterDonor.smethod_17((Control)(object)CheckBox3, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					RegisterDonor.smethod_18((Control)(object)CheckBox3, new Point(34, 187));
					num = ((int)num2 * -583414399) ^ -1502053476;
					continue;
				case 356u:
					num = (int)((num2 * 483856262) ^ 0x29CFAF32);
					continue;
				case 355u:
					RegisterDonor.smethod_29((ButtonBase)(object)CheckBox8, bool_0: true);
					RegisterDonor.smethod_34((ButtonBase)(object)CheckBox7, bool_0: true);
					num = (int)(num2 * 943975407) ^ -1620496031;
					continue;
				case 354u:
					CheckBox6 = RegisterDonor.smethod_8();
					num = (int)(num2 * 808469159) ^ -621529323;
					continue;
				case 353u:
					RegisterDonor.smethod_19((Control)(object)BloodGrpTxt, "BloodGrpTxt");
					num = ((int)num2 * -1758831994) ^ -2141161616;
					continue;
				case 352u:
					RegisterDonor.smethod_34((ButtonBase)(object)CheckBox5, bool_0: true);
					num = (int)((num2 * 1923727991) ^ 0xAE76649);
					continue;
				case 351u:
					RegisterDonor.smethod_18((Control)(object)CheckBox6, new Point(34, 333));
					num = (int)(num2 * 926272456) ^ -2023122503;
					continue;
				case 350u:
					RegisterDonor.smethod_19((Control)(object)CheckBox3, "CheckBox3");
					num = (int)(num2 * 2034325212) ^ -195836749;
					continue;
				case 349u:
					num = ((int)num2 * -1479700921) ^ -1342563387;
					continue;
				case 348u:
					RegisterDonor.smethod_19((Control)(object)GenderLbl, "GenderLbl");
					num = (int)(num2 * 2118253590) ^ -1071713611;
					continue;
				case 347u:
					RegisterDonor.smethod_17((Control)(object)Label3, RegisterDonor.smethod_26("Microsoft Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 749610324) ^ 0x4E1C8693);
					continue;
				case 346u:
					RegisterDonor.smethod_22(MobileLbl, "Mobile :");
					num = (int)(num2 * 1057589530) ^ -819890335;
					continue;
				case 345u:
					RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: false);
					num = (int)((num2 * 926829) ^ 0x59D01542);
					continue;
				case 344u:
					num = (int)(num2 * 1446562374) ^ -1538460185;
					continue;
				case 343u:
					num = ((int)num2 * -52385305) ^ -1564501258;
					continue;
				case 342u:
					RegisterDonor.smethod_15(Timer1, 1500);
					num = ((int)num2 * -787942525) ^ 0x117AD01E;
					continue;
				case 341u:
					num = (int)((num2 * 157513081) ^ 0x354051C8);
					continue;
				case 340u:
					WarningLbl = RegisterDonor.smethod_5();
					num = ((int)num2 * -817315366) ^ 0x53617DE5;
					continue;
				case 339u:
					RegisterDonor.smethod_17((Control)(object)CheckBox7, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 77723654) ^ -608667174;
					continue;
				case 338u:
					num = (int)(num2 * 1266931196) ^ -1578632262;
					continue;
				case 337u:
					RegisterDonor.smethod_22(BloodGrpLbl, "Blood Group :");
					num = ((int)num2 * -1133664899) ^ 0x5D34763F;
					continue;
				case 336u:
					ClearBtn = RegisterDonor.smethod_6();
					num = ((int)num2 * -1097877792) ^ -1913398589;
					continue;
				case 335u:
					num = ((int)num2 * -112137264) ^ -162192777;
					continue;
				case 334u:
					RegisterDonor.smethod_34((ButtonBase)(object)CheckBox8, bool_0: true);
					num = (int)(num2 * 1319668997) ^ -1387722271;
					continue;
				case 333u:
					RegisterDonor.smethod_20((Control)(object)AgeLbl, new Size(54, 19));
					num = ((int)num2 * -1678595098) ^ 0x4CF9B81B;
					continue;
				case 332u:
					GenderLbl = RegisterDonor.smethod_5();
					num = ((int)num2 * -1092255843) ^ -724341509;
					continue;
				case 331u:
					RegisterDonor.smethod_28((ButtonBase)(object)CheckBox3, "HIV");
					num = (int)(num2 * 142137004) ^ -597337712;
					continue;
				case 330u:
					RegisterDonor.smethod_18((Control)(object)GroupBox1, new Point(614, 198));
					RegisterDonor.smethod_19((Control)(object)GroupBox1, "GroupBox1");
					RegisterDonor.smethod_20((Control)(object)GroupBox1, new Size(269, 480));
					num = ((int)num2 * -395521629) ^ 0x4B1AFD9E;
					continue;
				case 329u:
					RegisterDonor.smethod_27((Control)(object)WarningLbl, Color.Red);
					num = ((int)num2 * -884471651) ^ 0x5D1DE4F4;
					continue;
				case 328u:
					RegisterDonor.smethod_19((Control)(object)QuantityTxt, "QuantityTxt");
					num = (int)((num2 * 2044628171) ^ 0x49B1A8E0);
					continue;
				case 327u:
					RegisterDonor.smethod_21((Control)(object)CheckBox5, 4);
					num = ((int)num2 * -1206324566) ^ -802588602;
					continue;
				case 326u:
					num = (int)((num2 * 1702597642) ^ 0x789F7C0B);
					continue;
				case 325u:
					RegisterDonor.smethod_18((Control)(object)GroupBox2, new Point(68, 234));
					RegisterDonor.smethod_19((Control)(object)GroupBox2, "GroupBox2");
					num = ((int)num2 * -494399784) ^ 0x337EA73F;
					continue;
				case 324u:
					RegisterDonor.smethod_37(BloodGrpTxt, (ComboBoxStyle)2);
					num = (int)((num2 * 1009922951) ^ 0x29B6B8A3);
					continue;
				case 323u:
					RegisterDonor.smethod_18((Control)(object)BloodGrpLbl, new Point(25, 280));
					num = (int)(num2 * 497311240) ^ -1832587711;
					continue;
				case 322u:
					num = (int)(num2 * 1523838777) ^ -368582459;
					continue;
				case 321u:
					RegisterDonor.smethod_13((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -1513222886) ^ -1754396474;
					continue;
				case 320u:
					num = (int)(num2 * 1004421915) ^ -230663418;
					continue;
				case 319u:
					RegisterDonor.smethod_52((Control)(object)GroupBox1);
					RegisterDonor.smethod_51((Control)(object)GroupBox2, bool_0: false);
					num = ((int)num2 * -888713899) ^ 0x2096F4E3;
					continue;
				case 318u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)DateTxt);
					num = ((int)num2 * -909677122) ^ -427800172;
					continue;
				case 317u:
					num = (int)((num2 * 35541520) ^ 0x753CC77F);
					continue;
				case 316u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)Label4);
					num = (int)(num2 * 250755761) ^ -1832644695;
					continue;
				case 315u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_48((Control)(object)this), (Control)(object)AddBtn);
					RegisterDonor.smethod_31(RegisterDonor.smethod_48((Control)(object)this), (Control)(object)GroupBox1);
					num = ((int)num2 * -1418184531) ^ 0x21ED5AE0;
					continue;
				case 314u:
					RegisterDonor.smethod_21((Control)(object)GroupBox2, 17);
					num = (int)((num2 * 796749534) ^ 0x65D8155C);
					continue;
				case 313u:
					num = (int)((num2 * 958256570) ^ 0x5EE24984);
					continue;
				case 312u:
					num = ((int)num2 * -104810505) ^ -1408724854;
					continue;
				case 311u:
					RegisterDonor.smethod_21((Control)(object)BloodGrpTxt, 20);
					num = (int)((num2 * 1038035712) ^ 0x4C1063E8);
					continue;
				case 310u:
					RegisterDonor.smethod_34((ButtonBase)(object)CheckBox4, bool_0: true);
					RegisterDonor.smethod_17((Control)(object)CheckBox4, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1755709518) ^ -1214989040;
					continue;
				case 309u:
					RegisterDonor.smethod_20((Control)(object)CheckBox4, new Size(85, 23));
					num = (int)(num2 * 182512976) ^ -868336358;
					continue;
				case 308u:
					RegisterDonor.smethod_19((Control)(object)BloodGrpLbl, "BloodGrpLbl");
					RegisterDonor.smethod_20((Control)(object)BloodGrpLbl, new Size(127, 19));
					RegisterDonor.smethod_21((Control)(object)BloodGrpLbl, 19);
					num = (int)((num2 * 1125420521) ^ 0xCAEF82B);
					continue;
				case 307u:
					RegisterDonor.smethod_20((Control)(object)CheckBox7, new Size(116, 23));
					num = (int)(num2 * 1241689207) ^ -1589812179;
					continue;
				case 306u:
					num = (int)((num2 * 1876805116) ^ 0x8CE97D3);
					continue;
				case 305u:
					RegisterDonor.smethod_14((Control)(object)this);
					num = (int)((num2 * 361485903) ^ 0x2E0D364A);
					continue;
				case 304u:
					num = (int)((num2 * 2022661982) ^ 0x6F9160D0);
					continue;
				case 303u:
					num = (int)(num2 * 670758729) ^ -1517515720;
					continue;
				case 302u:
					RegisterDonor.smethod_33(GroupBox2, "Donor Information");
					num = (int)((num2 * 388799229) ^ 0x616E4C78);
					continue;
				case 301u:
					RegisterDonor.smethod_22(Label1, "Register Donor");
					num = (int)(num2 * 1752714995) ^ -102715049;
					continue;
				case 300u:
					RegisterDonor.smethod_21((Control)(object)NameLbl, 5);
					num = (int)(num2 * 1015468381) ^ -361103493;
					continue;
				case 299u:
					num = ((int)num2 * -249851284) ^ 0x341914B8;
					continue;
				case 298u:
					RegisterDonor.smethod_17((Control)(object)AddBtn, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 784977843) ^ 0x726783A5);
					continue;
				case 297u:
					Label2 = RegisterDonor.smethod_5();
					QuantityTxt = RegisterDonor.smethod_9();
					num = ((int)num2 * -13328475) ^ -2056892977;
					continue;
				case 296u:
					num = ((int)num2 * -192058520) ^ -154553979;
					continue;
				case 295u:
					GenderTxt = RegisterDonor.smethod_10();
					num = ((int)num2 * -1384450099) ^ 0x269462E3;
					continue;
				case 294u:
					num = (int)(num2 * 867350838) ^ -417179930;
					continue;
				case 293u:
					RegisterDonor.smethod_23(GenderLbl, (ContentAlignment)32);
					RegisterDonor.smethod_36(NameLbl, bool_0: true);
					num = (int)((num2 * 1796127169) ^ 0x30B2CC96);
					continue;
				case 292u:
					num = (int)((num2 * 1201880450) ^ 0x136A8C27);
					continue;
				case 291u:
					RegisterDonor.smethod_29((ButtonBase)(object)CheckBox2, bool_0: true);
					num = ((int)num2 * -958109657) ^ 0x4CDFE4EF;
					continue;
				case 290u:
					num = (int)(num2 * 1092998314) ^ -331086110;
					continue;
				case 289u:
					RegisterDonor.smethod_20((Control)(object)NameLbl, new Size(71, 19));
					num = ((int)num2 * -462854267) ^ -958511434;
					continue;
				case 288u:
					RegisterDonor.smethod_27((Control)(object)AddBtn, Color.White);
					num = ((int)num2 * -725275117) ^ 0x74CB6A85;
					continue;
				case 287u:
					RegisterDonor.smethod_42(PictureBox1, (PictureBoxSizeMode)1);
					num = ((int)num2 * -1282538451) ^ -780260964;
					continue;
				case 286u:
					CheckBox5 = RegisterDonor.smethod_8();
					num = ((int)num2 * -1114178110) ^ -1791456205;
					continue;
				case 285u:
					RegisterDonor.smethod_18((Control)(object)CheckBox8, new Point(34, 434));
					num = (int)((num2 * 2141258925) ^ 0x21B4DCA8);
					continue;
				case 284u:
					RegisterDonor.smethod_20((Control)(object)ClearBtn, new Size(148, 51));
					num = ((int)num2 * -1039713624) ^ -1950386912;
					continue;
				case 283u:
					RegisterDonor.smethod_19((Control)(object)NameTxt, "NameTxt");
					num = (int)((num2 * 1056294141) ^ 0x7BA72BAC);
					continue;
				case 282u:
					RegisterDonor.smethod_12((Control)(object)GroupBox1);
					num = (int)(num2 * 1085361373) ^ -487047802;
					continue;
				case 281u:
					num = (int)(num2 * 2139547299) ^ -1158412930;
					continue;
				case 280u:
					RegisterDonor.smethod_22(Label3, "Diseases Not Present");
					num = ((int)num2 * -415423911) ^ 0x2327E55D;
					continue;
				case 279u:
					RegisterDonor.smethod_21((Control)(object)QuantityTxt, 23);
					num = (int)((num2 * 207745142) ^ 0x606A1C6C);
					continue;
				case 278u:
					RegisterDonor.smethod_25((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					num = (int)(num2 * 657117689) ^ -1491828852;
					continue;
				case 277u:
					RegisterDonor.smethod_44(PictureBox1, bool_0: false);
					num = (int)((num2 * 919720790) ^ 0x46FDDB2B);
					continue;
				case 276u:
					RegisterDonor.smethod_21((Control)(object)CheckBox3, 2);
					num = (int)(num2 * 449178000) ^ -896389511;
					continue;
				case 275u:
					RegisterDonor.smethod_32(GroupBox2, bool_0: false);
					num = (int)((num2 * 828089709) ^ 0x16DE322E);
					continue;
				case 274u:
					RegisterDonor.smethod_54((Control)(object)this, bool_0: false);
					num = (int)((num2 * 967289749) ^ 0x1327E2C4);
					continue;
				case 273u:
					RegisterDonor.smethod_18((Control)(object)CheckBox2, new Point(34, 137));
					num = (int)(num2 * 227061195) ^ -438098012;
					continue;
				case 272u:
					RegisterDonor.smethod_23(Label4, (ContentAlignment)32);
					num = ((int)num2 * -630188115) ^ -166040970;
					continue;
				case 271u:
					RegisterDonor.smethod_28((ButtonBase)(object)CheckBox6, "Syphilis");
					num = ((int)num2 * -2146271642) ^ 0x61D3C75C;
					continue;
				case 270u:
					num = ((int)num2 * -651865526) ^ -17573833;
					continue;
				case 269u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox1), (Control)(object)CheckBox3);
					num = (int)(num2 * 1124779621) ^ -1122880830;
					continue;
				case 268u:
					num = ((int)num2 * -231188354) ^ -77624773;
					continue;
				case 267u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_48((Control)(object)this), (Control)(object)ClearBtn);
					num = ((int)num2 * -1399914904) ^ 0x1CF09160;
					continue;
				case 266u:
					RegisterDonor.smethod_17((Control)(object)ClearBtn, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 606760700) ^ -864372259;
					continue;
				case 265u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)WarningLbl);
					num = (int)((num2 * 756539998) ^ 0x3E24DF0B);
					continue;
				case 264u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)BloodGrpLbl);
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)GenderTxt);
					num = ((int)num2 * -1663198547) ^ -215216208;
					continue;
				case 263u:
					RegisterDonor.smethod_18((Control)(object)WarningLbl, new Point(272, 133));
					num = ((int)num2 * -129917934) ^ -354073302;
					continue;
				case 262u:
					RegisterDonor.smethod_28((ButtonBase)(object)CheckBox2, "Hepatitus C");
					num = (int)(num2 * 1850190775) ^ -1684780444;
					continue;
				case 261u:
					num = (int)((num2 * 1992539807) ^ 0x2866167);
					continue;
				case 260u:
					num = ((int)num2 * -1785477948) ^ 0xF52F38B;
					continue;
				case 259u:
					RegisterDonor.smethod_22(GenderLbl, "Gender :");
					num = (int)((num2 * 1297563782) ^ 0x774E7164);
					continue;
				case 258u:
					RegisterDonor.smethod_21((Control)(object)WarningLbl, 21);
					num = (int)((num2 * 277544483) ^ 0x91254DD);
					continue;
				case 257u:
					AgeLbl = RegisterDonor.smethod_5();
					num = (int)(num2 * 966126812) ^ -2095212489;
					continue;
				case 256u:
					RegisterDonor.smethod_17((Control)(object)GroupBox2, RegisterDonor.smethod_26("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 432945921) ^ -1674283041;
					continue;
				case 255u:
					RegisterDonor.smethod_19((Control)(object)DateTxt, "DateTxt");
					RegisterDonor.smethod_35((TextBoxBase)(object)DateTxt, bool_0: true);
					num = ((int)num2 * -847173323) ^ 0x7C4AD348;
					continue;
				case 254u:
					RegisterDonor.smethod_20((Control)(object)Label3, new Size(212, 36));
					num = (int)(num2 * 215715897) ^ -1126940031;
					continue;
				case 253u:
					RegisterDonor.smethod_21((Control)(object)SuccessMsg, 21);
					RegisterDonor.smethod_22(SuccessMsg, "Name :");
					num = ((int)num2 * -162963518) ^ -400633680;
					continue;
				case 252u:
					num = (int)(num2 * 2093640495) ^ -267055299;
					continue;
				case 251u:
					num = ((int)num2 * -1058581737) ^ 0x55A0C0A0;
					continue;
				case 250u:
					num = ((int)num2 * -683569126) ^ -1375901434;
					continue;
				case 249u:
					num = (int)((num2 * 842675731) ^ 0x38E80B77);
					continue;
				case 248u:
					RegisterDonor.smethod_12((Control)(object)GroupBox2);
					num = ((int)num2 * -940810633) ^ 0x1002F2E9;
					continue;
				case 247u:
					RegisterDonor.smethod_19((Control)(object)Label3, "Label3");
					num = (int)((num2 * 183584694) ^ 0x6CB441B6);
					continue;
				case 246u:
					RegisterDonor.smethod_19((Control)(object)GenderTxt, "GenderTxt");
					num = (int)((num2 * 1136234493) ^ 0x752F3FEA);
					continue;
				case 245u:
					RegisterDonor.smethod_28((ButtonBase)(object)CheckBox5, "HTLV II");
					num = ((int)num2 * -1569821319) ^ 0x57E3C459;
					continue;
				case 244u:
					num = (int)((num2 * 358883418) ^ 0x1FA255CF);
					continue;
				case 243u:
					RegisterDonor.smethod_22(Label2, "Date :");
					num = (int)(num2 * 783246373) ^ -1180183073;
					continue;
				case 242u:
					RegisterDonor.smethod_17((Control)(object)AgeLbl, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 326325629) ^ 0xBED1532);
					continue;
				case 241u:
					num = ((int)num2 * -704462521) ^ 0x7C0BAD5C;
					continue;
				case 240u:
					num = (int)(num2 * 416126288) ^ -1634667176;
					continue;
				case 239u:
					num = ((int)num2 * -1535195895) ^ 0x22E6C0B;
					continue;
				case 238u:
					RegisterDonor.smethod_36(WarningLbl, bool_0: true);
					num = (int)(num2 * 970443008) ^ -310760863;
					continue;
				case 237u:
					num = (int)((num2 * 1262999619) ^ 0x41B634CF);
					continue;
				case 236u:
					RegisterDonor.smethod_18((Control)(object)Label1, new Point(392, 60));
					num = (int)((num2 * 1066848538) ^ 0x2C7A19FC);
					continue;
				case 235u:
					num = ((int)num2 * -1376347356) ^ -553055162;
					continue;
				case 234u:
					num = ((int)num2 * -498723801) ^ -1205556663;
					continue;
				case 233u:
					num = ((int)num2 * -1955671694) ^ -356692048;
					continue;
				case 232u:
					RegisterDonor.smethod_20((Control)(object)MobileTxt, new Size(232, 26));
					num = ((int)num2 * -474223438) ^ 0x1326A09F;
					continue;
				case 231u:
					RegisterDonor.smethod_21((Control)(object)NameTxt, 0);
					num = (int)(num2 * 448371683) ^ -1401701696;
					continue;
				case 230u:
					RegisterDonor.smethod_21((Control)(object)GenderTxt, 14);
					num = ((int)num2 * -1490401638) ^ -1179716895;
					continue;
				case 229u:
					RegisterDonor.smethod_36(GenderLbl, bool_0: true);
					num = ((int)num2 * -1691937843) ^ -954993053;
					continue;
				case 228u:
					RegisterDonor.smethod_22(WarningLbl, "(18-55 years)");
					RegisterDonor.smethod_23(WarningLbl, (ContentAlignment)32);
					num = ((int)num2 * -1186124277) ^ -1421723050;
					continue;
				case 227u:
					num = ((int)num2 * -1348287401) ^ -565254054;
					continue;
				case 226u:
					RegisterDonor.smethod_19((Control)(object)Label7, "Label7");
					RegisterDonor.smethod_20((Control)(object)Label7, new Size(164, 19));
					num = (int)((num2 * 1938383187) ^ 0x4CAF24B8);
					continue;
				case 225u:
					RegisterDonor.smethod_28((ButtonBase)(object)CheckBox8, "Typhoid");
					num = ((int)num2 * -1107182038) ^ 0x57854E47;
					continue;
				case 224u:
					RegisterDonor.smethod_19((Control)(object)Label1, "Label1");
					num = ((int)num2 * -1652335589) ^ -519486254;
					continue;
				case 222u:
					RegisterDonor.smethod_18((Control)(object)Label2, new Point(25, 377));
					num = (int)((num2 * 1229358533) ^ 0x60DDD512);
					continue;
				case 221u:
					RegisterDonor.smethod_22(Label4, "(In litres)");
					num = (int)(num2 * 142723292) ^ -792524237;
					continue;
				case 220u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox1), (Control)(object)CheckBox1);
					num = ((int)num2 * -1646449022) ^ 0x79FDA98;
					continue;
				case 219u:
					RegisterDonor.smethod_36(BloodGrpLbl, bool_0: true);
					num = (int)((num2 * 1346087990) ^ 0x19BC8592);
					continue;
				case 218u:
					RegisterDonor.smethod_21((Control)(object)AgeTxt, 10);
					num = (int)((num2 * 552418413) ^ 0x29B90FDB);
					continue;
				case 217u:
					num = ((int)num2 * -224591920) ^ 0x73F16840;
					continue;
				case 216u:
					RegisterDonor.smethod_17((Control)(object)GroupBox1, RegisterDonor.smethod_26("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 2110619393) ^ -1889993658;
					continue;
				case 215u:
					num = (int)(num2 * 786803525) ^ -1223946706;
					continue;
				case 214u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)Label2);
					num = ((int)num2 * -1749773732) ^ 0x42246BE4;
					continue;
				case 213u:
					num = (int)((num2 * 1678321004) ^ 0x27F20FA2);
					continue;
				case 212u:
					RegisterDonor.smethod_29((ButtonBase)(object)CheckBox7, bool_0: true);
					num = (int)((num2 * 667509694) ^ 0x7E2ECE08);
					continue;
				case 211u:
					num = (int)((num2 * 212587896) ^ 0xE86A550);
					continue;
				case 210u:
					num = (int)(num2 * 991410830) ^ -982801440;
					continue;
				case 209u:
					num = (int)((num2 * 1473724362) ^ 0x43A67E8B);
					continue;
				case 208u:
					num = (int)(num2 * 104362990) ^ -1036666313;
					continue;
				case 207u:
					num = ((int)num2 * -1841472222) ^ -1832030163;
					continue;
				case 206u:
					RegisterDonor.smethod_19((Control)(object)Label2, "Label2");
					num = ((int)num2 * -581628729) ^ 0x3EEBB96E;
					continue;
				case 205u:
					BloodGrpLbl = RegisterDonor.smethod_5();
					num = (int)(num2 * 1664921721) ^ -187047294;
					continue;
				case 204u:
					RegisterDonor.smethod_20((Control)(object)PictureBox1, new Size(230, 123));
					num = (int)(num2 * 768863081) ^ -2110928789;
					continue;
				case 203u:
					RegisterDonor.smethod_20((Control)(object)AgeTxt, new Size(124, 26));
					num = (int)(num2 * 347632298) ^ -1264345810;
					continue;
				case 202u:
					num = (int)((num2 * 1010275313) ^ 0x5FE0B9BD);
					continue;
				case 200u:
					RegisterDonor.smethod_21((Control)(object)GenderLbl, 6);
					num = (int)((num2 * 1325481328) ^ 0x4709E2B);
					continue;
				case 199u:
					RegisterDonor.smethod_19((Control)(object)CheckBox7, "CheckBox7");
					num = ((int)num2 * -1381697333) ^ 0x2BB493D9;
					continue;
				case 198u:
					num = ((int)num2 * -710167403) ^ 0x32092342;
					continue;
				case 197u:
					RegisterDonor.smethod_17((Control)(object)CheckBox2, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 634170181) ^ 0x5389EFD);
					continue;
				case 196u:
					GroupBox2 = RegisterDonor.smethod_7();
					num = (int)((num2 * 1978560083) ^ 0x75D1B2C7);
					continue;
				case 195u:
					RegisterDonor.smethod_17((Control)(object)GenderLbl, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1268400541) ^ -82407487;
					continue;
				case 194u:
					CheckBox4 = RegisterDonor.smethod_8();
					num = ((int)num2 * -808383935) ^ -1046420460;
					continue;
				case 193u:
					num = (int)((num2 * 1877708897) ^ 0x4F4F66ED);
					continue;
				case 192u:
					RegisterDonor.smethod_21((Control)(object)CheckBox4, 3);
					num = ((int)num2 * -1812787667) ^ 0x6DDD2646;
					continue;
				case 191u:
					num = (int)(num2 * 1550683885) ^ -1633056171;
					continue;
				case 190u:
					RegisterDonor.smethod_23(Label2, (ContentAlignment)32);
					num = ((int)num2 * -1303810155) ^ -6898400;
					continue;
				case 189u:
					RegisterDonor.smethod_28((ButtonBase)(object)ClearBtn, "Clear");
					RegisterDonor.smethod_29((ButtonBase)(object)ClearBtn, bool_0: false);
					num = ((int)num2 * -1284290774) ^ -297489314;
					continue;
				case 188u:
					num = (int)((num2 * 724442152) ^ 0x277CB11B);
					continue;
				case 187u:
					RegisterDonor.smethod_19((Control)(object)MobileLbl, "MobileLbl");
					num = ((int)num2 * -1645201947) ^ 0x54CC6BA4;
					continue;
				case 186u:
					RegisterDonor.smethod_19((Control)(object)CheckBox5, "CheckBox5");
					num = (int)(num2 * 302078394) ^ -230888696;
					continue;
				case 185u:
					RegisterDonor.smethod_18((Control)(object)MobileTxt, new Point(147, 178));
					RegisterDonor.smethod_19((Control)(object)MobileTxt, "MobileTxt");
					num = ((int)num2 * -1357620510) ^ -432332320;
					continue;
				case 184u:
					Label4 = RegisterDonor.smethod_5();
					num = ((int)num2 * -1155664918) ^ 0x273860B6;
					continue;
				case 183u:
					num = (int)(num2 * 109475255) ^ -1865492504;
					continue;
				case 182u:
					RegisterDonor.smethod_20((Control)(object)CheckBox6, new Size(93, 23));
					num = ((int)num2 * -2057716018) ^ 0x8F2E5E4;
					continue;
				case 181u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox1), (Control)(object)CheckBox2);
					num = ((int)num2 * -1429015335) ^ -536771301;
					continue;
				case 180u:
					RegisterDonor.smethod_21((Control)(object)Label4, 26);
					num = (int)(num2 * 1725716635) ^ -1149079838;
					continue;
				case 179u:
					AgeTxt = RegisterDonor.smethod_9();
					num = (int)((num2 * 1980990410) ^ 0x2A896885);
					continue;
				case 178u:
					RegisterDonor.smethod_21((Control)(object)CheckBox8, 7);
					num = ((int)num2 * -162731458) ^ 0x16F3CCE0;
					continue;
				case 177u:
					RegisterDonor.smethod_17((Control)(object)NameLbl, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 823656489) ^ -98761390;
					continue;
				case 176u:
					RegisterDonor.smethod_19((Control)(object)WarningLbl, "WarningLbl");
					num = ((int)num2 * -354986456) ^ -1603080511;
					continue;
				case 175u:
					RegisterDonor.smethod_23(Label1, (ContentAlignment)32);
					num = ((int)num2 * -1009237183) ^ 0x478C8F49;
					continue;
				case 174u:
					RegisterDonor.smethod_27((Control)(object)Label3, Color.Red);
					num = (int)((num2 * 1349767479) ^ 0x7644A2E);
					continue;
				case 173u:
					RegisterDonor.smethod_21((Control)(object)AgeLbl, 13);
					RegisterDonor.smethod_22(AgeLbl, "Age :");
					RegisterDonor.smethod_23(AgeLbl, (ContentAlignment)32);
					num = ((int)num2 * -918220912) ^ -1262083624;
					continue;
				case 172u:
					RegisterDonor.smethod_17((Control)(object)BloodGrpLbl, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 992422686) ^ -907409312;
					continue;
				case 171u:
					SuccessMsg = RegisterDonor.smethod_5();
					num = ((int)num2 * -1948261769) ^ 0x2EED4DCE;
					continue;
				case 170u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox1), (Control)(object)CheckBox4);
					num = ((int)num2 * -1845478391) ^ 0x6976D1AC;
					continue;
				case 169u:
					RegisterDonor.smethod_18((Control)(object)GenderLbl, new Point(25, 229));
					num = ((int)num2 * -1516725591) ^ -1813586504;
					continue;
				case 168u:
					RegisterDonor.smethod_18((Control)(object)BloodGrpTxt, new Point(163, 277));
					num = ((int)num2 * -1106905773) ^ 0x2A06F599;
					continue;
				case 167u:
					RegisterDonor.smethod_18((Control)(object)NameLbl, new Point(25, 76));
					RegisterDonor.smethod_19((Control)(object)NameLbl, "NameLbl");
					num = ((int)num2 * -1769445733) ^ -1871265391;
					continue;
				case 166u:
					num = ((int)num2 * -1306452003) ^ 0x265FBA8D;
					continue;
				case 165u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_48((Control)(object)this), (Control)(object)PictureBox1);
					RegisterDonor.smethod_49((Control)(object)this, "RegisterDonor");
					num = (int)(num2 * 922485415) ^ -1322463494;
					continue;
				case 164u:
					NameLbl = RegisterDonor.smethod_5();
					num = (int)(num2 * 361385456) ^ -1979750328;
					continue;
				case 163u:
					PictureBox1 = RegisterDonor.smethod_11();
					num = ((int)num2 * -2086462074) ^ 0x6C55E110;
					continue;
				case 162u:
					Label7 = RegisterDonor.smethod_5();
					num = ((int)num2 * -1463325531) ^ 0x4A322636;
					continue;
				case 161u:
					RegisterDonor.smethod_34((ButtonBase)(object)CheckBox6, bool_0: true);
					num = ((int)num2 * -1587826738) ^ 0x7324DA02;
					continue;
				case 160u:
					RegisterDonor.smethod_20((Control)(object)GenderLbl, new Size(83, 19));
					num = ((int)num2 * -2126176569) ^ 0x75108B82;
					continue;
				case 159u:
					RegisterDonor.smethod_21((Control)(object)MobileTxt, 2);
					RegisterDonor.smethod_17((Control)(object)NameTxt, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 22039958) ^ 0x5A8F30B6);
					continue;
				case 158u:
					num = ((int)num2 * -1184374554) ^ -656521469;
					continue;
				case 157u:
					RegisterDonor.smethod_53((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -1342188754) ^ 0x7B0E36F5;
					continue;
				case 156u:
					RegisterDonor.smethod_29((ButtonBase)(object)CheckBox5, bool_0: true);
					num = (int)(num2 * 102804257) ^ -1045586024;
					continue;
				case 155u:
					RegisterDonor.smethod_23(NameLbl, (ContentAlignment)32);
					num = ((int)num2 * -1417750893) ^ 0x5A4F3BB4;
					continue;
				case 154u:
					RegisterDonor.smethod_19((Control)(object)SuccessMsg, "SuccessMsg");
					RegisterDonor.smethod_20((Control)(object)SuccessMsg, new Size(401, 44));
					num = ((int)num2 * -1364783075) ^ 0x55DE09F9;
					continue;
				case 153u:
					RegisterDonor.smethod_20((Control)(object)AddBtn, new Size(148, 51));
					num = ((int)num2 * -1206061908) ^ 0x159BC219;
					continue;
				case 152u:
					RegisterDonor.smethod_18((Control)(object)QuantityTxt, new Point(250, 324));
					num = (int)((num2 * 436151677) ^ 0x68BA726B);
					continue;
				case 151u:
					RegisterDonor.smethod_21((Control)(object)CheckBox6, 5);
					num = (int)((num2 * 1819596827) ^ 0x6FC87507);
					continue;
				case 150u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)AgeLbl);
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)AgeTxt);
					num = (int)(num2 * 345524218) ^ -345516860;
					continue;
				case 149u:
					num = (int)((num2 * 1574215314) ^ 0x32998FEB);
					continue;
				case 148u:
					RegisterDonor.smethod_18((Control)(object)DateTxt, new Point(121, 374));
					num = (int)((num2 * 1515991895) ^ 0x55B1120B);
					continue;
				case 147u:
					RegisterDonor.smethod_18((Control)(object)CheckBox1, new Point(34, 86));
					num = ((int)num2 * -898751369) ^ -50674795;
					continue;
				case 146u:
					RegisterDonor.smethod_18((Control)(object)ClearBtn, new Point(547, 704));
					num = ((int)num2 * -867389979) ^ -4941356;
					continue;
				case 145u:
					RegisterDonor.smethod_36(Label4, bool_0: true);
					num = (int)((num2 * 799030015) ^ 0x3F1AA5FD);
					continue;
				case 144u:
					num = (int)(num2 * 1334477884) ^ -1453857184;
					continue;
				case 143u:
					num = ((int)num2 * -900440337) ^ -271081342;
					continue;
				case 142u:
					RegisterDonor.smethod_21((Control)(object)GroupBox1, 18);
					num = (int)(num2 * 1455416273) ^ -1590986673;
					continue;
				case 141u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)Label7);
					num = (int)((num2 * 266559868) ^ 0x3BFAC1DF);
					continue;
				case 140u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)NameTxt);
					num = (int)((num2 * 1354622929) ^ 0x788C8C69);
					continue;
				case 139u:
					RegisterDonor.smethod_20((Control)(object)GenderTxt, new Size(124, 27));
					num = (int)((num2 * 1772249024) ^ 0xFC34A1E);
					continue;
				case 138u:
					RegisterDonor.smethod_50((Control)(object)this, new Size(977, 804));
					num = (int)(num2 * 68056070) ^ -1623014440;
					continue;
				case 137u:
					MobileTxt = RegisterDonor.smethod_9();
					NameTxt = RegisterDonor.smethod_9();
					num = ((int)num2 * -723681748) ^ 0x163CF39C;
					continue;
				case 136u:
					RegisterDonor.smethod_55((Control)(object)this);
					num = ((int)num2 * -1860859368) ^ 0x20CEBA66;
					continue;
				case 135u:
					RegisterDonor.smethod_17((Control)(object)QuantityTxt, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 947839082) ^ 0x244590B8);
					continue;
				case 134u:
					RegisterDonor.smethod_27((Control)(object)Label4, Color.Red);
					RegisterDonor.smethod_18((Control)(object)Label4, new Point(357, 328));
					RegisterDonor.smethod_19((Control)(object)Label4, "Label4");
					RegisterDonor.smethod_20((Control)(object)Label4, new Size(84, 18));
					num = ((int)num2 * -572733927) ^ -1642350348;
					continue;
				case 133u:
					CheckBox2 = RegisterDonor.smethod_8();
					CheckBox1 = RegisterDonor.smethod_8();
					num = ((int)num2 * -599431680) ^ -188010132;
					continue;
				case 132u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_48((Control)(object)this), (Control)(object)GroupBox2);
					RegisterDonor.smethod_31(RegisterDonor.smethod_48((Control)(object)this), (Control)(object)Label1);
					num = ((int)num2 * -65010340) ^ 0x4B67C244;
					continue;
				case 131u:
					RegisterDonor.smethod_21((Control)(object)Label3, 23);
					num = ((int)num2 * -1775824398) ^ 0x27BBD02B;
					continue;
				case 130u:
					num = ((int)num2 * -554400911) ^ 0x7A1E6AD6;
					continue;
				case 129u:
					RegisterDonor.smethod_18((Control)(object)AgeTxt, new Point(127, 128));
					RegisterDonor.smethod_19((Control)(object)AgeTxt, "AgeTxt");
					num = ((int)num2 * -221280962) ^ -1249555381;
					continue;
				case 128u:
					RegisterDonor.smethod_18((Control)(object)GenderTxt, new Point(127, 226));
					num = (int)((num2 * 547579587) ^ 0xF252C83);
					continue;
				case 127u:
					num = (int)((num2 * 855437060) ^ 0x637DBF5);
					continue;
				case 126u:
					RegisterDonor.smethod_17((Control)(object)Label4, RegisterDonor.smethod_26("MS Reference Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -383761371) ^ 0x60F99170;
					continue;
				case 125u:
					MobileLbl = RegisterDonor.smethod_5();
					num = (int)((num2 * 1266191417) ^ 0x45008D67);
					continue;
				case 124u:
					RegisterDonor.smethod_17((Control)(object)Label7, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					RegisterDonor.smethod_18((Control)(object)Label7, new Point(25, 327));
					num = ((int)num2 * -393048788) ^ -1369762867;
					continue;
				case 123u:
					RegisterDonor.smethod_17((Control)(object)WarningLbl, RegisterDonor.smethod_26("Microsoft Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -994252643) ^ 0x2C68EDC9;
					continue;
				case 122u:
					RegisterDonor.smethod_19((Control)(object)CheckBox6, "CheckBox6");
					num = ((int)num2 * -1550767672) ^ -437197424;
					continue;
				case 121u:
					RegisterDonor.smethod_47((Control)(object)this, Color.White);
					num = ((int)num2 * -917922982) ^ 0x2EE5D73F;
					continue;
				case 120u:
					RegisterDonor.smethod_29((ButtonBase)(object)CheckBox6, bool_0: true);
					num = (int)((num2 * 1213181023) ^ 0x77F0C6B6);
					continue;
				case 119u:
					num = (int)((num2 * 779038546) ^ 0x40F89FAF);
					continue;
				case 118u:
					RegisterDonor.smethod_21((Control)(object)CheckBox1, 0);
					num = ((int)num2 * -1944911810) ^ -76406795;
					continue;
				case 117u:
					num = (int)((num2 * 453851025) ^ 0x668DCF71);
					continue;
				case 116u:
					num = ((int)num2 * -2007843365) ^ 0x1181FD39;
					continue;
				case 115u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_48((Control)(object)this), (Control)(object)SuccessMsg);
					num = ((int)num2 * -762738273) ^ 0xE2B9D8;
					continue;
				case 114u:
					num = ((int)num2 * -1785110734) ^ 0x64E13F;
					continue;
				case 113u:
					num = (int)((num2 * 960508054) ^ 0xE409415);
					continue;
				case 112u:
					num = (int)(num2 * 715337335) ^ -1810182672;
					continue;
				case 111u:
					num = (int)((num2 * 783677453) ^ 0x675D4C5E);
					continue;
				case 110u:
					RegisterDonor.smethod_28((ButtonBase)(object)CheckBox4, "HTLV I");
					num = (int)(num2 * 711376371) ^ -1864544464;
					continue;
				case 109u:
					RegisterDonor.smethod_23(BloodGrpLbl, (ContentAlignment)32);
					num = ((int)num2 * -833739056) ^ -1096478003;
					continue;
				case 108u:
					RegisterDonor.smethod_20((Control)(object)DateTxt, new Size(167, 26));
					RegisterDonor.smethod_21((Control)(object)DateTxt, 25);
					RegisterDonor.smethod_36(Label2, bool_0: true);
					num = (int)(num2 * 133870135) ^ -2041469696;
					continue;
				case 107u:
					RegisterDonor.smethod_24((Control)(object)Label4, bool_0: false);
					RegisterDonor.smethod_45((ContainerControl)(object)this, new SizeF(8f, 16f));
					RegisterDonor.smethod_46((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -423675482) ^ -114119829;
					continue;
				case 106u:
					num = (int)((num2 * 33196028) ^ 0x15DAF3F4);
					continue;
				case 105u:
					num = (int)(num2 * 491514172) ^ -2019272143;
					continue;
				case 104u:
					RegisterDonor.smethod_18((Control)(object)CheckBox7, new Point(34, 387));
					num = ((int)num2 * -728412892) ^ 0x1A1F657D;
					continue;
				case 103u:
					RegisterDonor.smethod_43(PictureBox1, 15);
					num = ((int)num2 * -672910248) ^ -379483894;
					continue;
				case 102u:
					RegisterDonor.smethod_27((Control)(object)ClearBtn, Color.White);
					num = (int)((num2 * 1768682962) ^ 0x7934B9B);
					continue;
				case 101u:
					RegisterDonor.smethod_20((Control)(object)BloodGrpTxt, new Size(113, 27));
					num = ((int)num2 * -811462785) ^ 0x5D6740E0;
					continue;
				case 100u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox1), (Control)(object)CheckBox5);
					num = ((int)num2 * -62918756) ^ 0x67158AD7;
					continue;
				case 99u:
					num = ((int)num2 * -134028234) ^ 0x3186DBE0;
					continue;
				case 98u:
					RegisterDonor.smethod_18((Control)(object)CheckBox4, new Point(34, 237));
					num = ((int)num2 * -278580719) ^ 0x656B0E5D;
					continue;
				case 97u:
					num = (int)((num2 * 914670764) ^ 0x24ACF864);
					continue;
				case 96u:
					num = ((int)num2 * -644397833) ^ -246332033;
					continue;
				case 95u:
					num = ((int)num2 * -2035506684) ^ -2041124380;
					continue;
				case 94u:
					CheckBox8 = RegisterDonor.smethod_8();
					num = (int)(num2 * 411159750) ^ -1266918374;
					continue;
				case 93u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)QuantityTxt);
					num = ((int)num2 * -1120625487) ^ 0x310C3F57;
					continue;
				case 92u:
					CheckBox7 = RegisterDonor.smethod_8();
					num = ((int)num2 * -1511633518) ^ 0x14AB4CB0;
					continue;
				case 91u:
					RegisterDonor.smethod_23(Label7, (ContentAlignment)32);
					num = (int)(num2 * 943729260) ^ -784065490;
					continue;
				case 90u:
					DateTxt = RegisterDonor.smethod_9();
					num = ((int)num2 * -2054460192) ^ -391001659;
					continue;
				case 89u:
					RegisterDonor.smethod_28((ButtonBase)(object)CheckBox1, "Hepatitus B");
					num = (int)((num2 * 715477261) ^ 0x557E172);
					continue;
				case 88u:
					RegisterDonor.smethod_21((Control)(object)ClearBtn, 20);
					num = (int)(num2 * 1900541218) ^ -378325386;
					continue;
				case 87u:
					num = ((int)num2 * -63493099) ^ 0x44505814;
					continue;
				case 86u:
					num = (int)(num2 * 916770736) ^ -173997256;
					continue;
				case 85u:
					num = (int)((num2 * 1020711138) ^ 0x1217B927);
					continue;
				case 84u:
					RegisterDonor.smethod_20((Control)(object)Label1, new Size(242, 35));
					RegisterDonor.smethod_21((Control)(object)Label1, 16);
					num = ((int)num2 * -2140043678) ^ -570216530;
					continue;
				case 83u:
					num = ((int)num2 * -860745447) ^ -844975961;
					continue;
				case 82u:
					RegisterDonor.smethod_20((Control)(object)Label2, new Size(62, 19));
					num = (int)((num2 * 1343262871) ^ 0x38BFE70B);
					continue;
				case 81u:
					num = (int)((num2 * 2030403637) ^ 0x7627650C);
					continue;
				case 80u:
					RegisterDonor.smethod_18((Control)(object)Label3, new Point(31, 36));
					num = (int)((num2 * 528459618) ^ 0xE7B5368);
					continue;
				case 79u:
					num = (int)(num2 * 1039165702) ^ -1296798996;
					continue;
				case 78u:
					RegisterDonor.smethod_17((Control)(object)DateTxt, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -759875457) ^ 0x6DDBBBCD;
					continue;
				case 77u:
					RegisterDonor.smethod_17((Control)(object)BloodGrpTxt, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -825719231) ^ 0x1B062295;
					continue;
				case 76u:
					RegisterDonor.smethod_40(RegisterDonor.smethod_39(GenderTxt), new object[3] { "MALE", "FEMALE", "OTHERS" });
					num = (int)(num2 * 1200894782) ^ -1357490651;
					continue;
				case 75u:
					RegisterDonor.smethod_18((Control)(object)AgeLbl, new Point(25, 131));
					RegisterDonor.smethod_19((Control)(object)AgeLbl, "AgeLbl");
					num = (int)((num2 * 134521912) ^ 0x69B3124A);
					continue;
				case 74u:
					RegisterDonor.smethod_17((Control)(object)CheckBox8, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1092658933) ^ 0x50E75F2;
					continue;
				case 73u:
					RegisterDonor.smethod_28((ButtonBase)(object)CheckBox7, "Cholestrol");
					num = ((int)num2 * -132980998) ^ -1986194855;
					continue;
				case 72u:
					RegisterDonor.smethod_29((ButtonBase)(object)CheckBox3, bool_0: true);
					num = (int)(num2 * 829440578) ^ -807704087;
					continue;
				case 71u:
					num = (int)(num2 * 1982370161) ^ -154367017;
					continue;
				case 70u:
					RegisterDonor.smethod_17((Control)(object)GenderTxt, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					RegisterDonor.smethod_38((ListControl)(object)GenderTxt, bool_0: true);
					num = ((int)num2 * -850043547) ^ 0x188120C4;
					continue;
				case 69u:
					num = (int)((num2 * 1906044329) ^ 0x6FC4135D);
					continue;
				case 68u:
					RegisterDonor.smethod_21((Control)(object)AddBtn, 19);
					num = (int)(num2 * 733645756) ^ -1592611410;
					continue;
				case 67u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)BloodGrpTxt);
					num = (int)((num2 * 1301013908) ^ 0x13DD263A);
					continue;
				case 66u:
					num = ((int)num2 * -1535328518) ^ 0x48F5D3FC;
					continue;
				case 65u:
					Label1 = RegisterDonor.smethod_5();
					num = (int)((num2 * 539645461) ^ 0xDFA67E9);
					continue;
				case 64u:
					BloodGrpTxt = RegisterDonor.smethod_10();
					num = (int)(num2 * 2105586809) ^ -1962840539;
					continue;
				case 63u:
					num = ((int)num2 * -1665725640) ^ -242917577;
					continue;
				case 62u:
					RegisterDonor.smethod_29((ButtonBase)(object)CheckBox4, bool_0: true);
					num = ((int)num2 * -725450468) ^ -573287382;
					continue;
				case 61u:
					num = ((int)num2 * -2084814806) ^ -1111761201;
					continue;
				case 60u:
					RegisterDonor.smethod_20((Control)(object)WarningLbl, new Size(107, 17));
					num = (int)(num2 * 970888916) ^ -662928336;
					continue;
				case 59u:
					num = ((int)num2 * -1458047206) ^ 0x3573CCA;
					continue;
				case 58u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)MobileLbl);
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)GenderLbl);
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)NameLbl);
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)MobileTxt);
					num = (int)((num2 * 154394462) ^ 0x1ED373A);
					continue;
				case 57u:
					RegisterDonor.smethod_17((Control)(object)SuccessMsg, RegisterDonor.smethod_16("MS Reference Sans Serif", 10.8f, (FontStyle)1));
					num = (int)(num2 * 1376266015) ^ -1078417671;
					continue;
				case 56u:
					RegisterDonor.smethod_19((Control)(object)CheckBox2, "CheckBox2");
					RegisterDonor.smethod_20((Control)(object)CheckBox2, new Size(128, 23));
					RegisterDonor.smethod_21((Control)(object)CheckBox2, 1);
					num = (int)((num2 * 415336304) ^ 0x75E6E4CA);
					continue;
				case 55u:
					RegisterDonor.smethod_19((Control)(object)CheckBox8, "CheckBox8");
					RegisterDonor.smethod_20((Control)(object)CheckBox8, new Size(96, 23));
					num = ((int)num2 * -463416344) ^ 0x6EBF97EC;
					continue;
				case 54u:
					num = ((int)num2 * -1467234806) ^ -1278577084;
					continue;
				case 53u:
					num = (int)(num2 * 154882554) ^ -75905183;
					continue;
				case 52u:
					num = ((int)num2 * -1294823287) ^ 0x3D0015A7;
					continue;
				case 51u:
					RegisterDonor.smethod_32(GroupBox1, bool_0: false);
					num = ((int)num2 * -1912899836) ^ 0x6680A2E1;
					continue;
				case 50u:
					num = (int)(num2 * 808185989) ^ -1033533357;
					continue;
				case 49u:
					num = (int)(num2 * 1189133619) ^ -351785668;
					continue;
				case 48u:
					RegisterDonor.smethod_19((Control)(object)ClearBtn, "ClearBtn");
					num = (int)(num2 * 1521779432) ^ -1108226127;
					continue;
				case 47u:
					num = ((int)num2 * -530141686) ^ -1084342199;
					continue;
				case 46u:
					num = ((int)num2 * -471033482) ^ 0x4A12A8B6;
					continue;
				case 45u:
					RegisterDonor.smethod_18((Control)(object)CheckBox5, new Point(34, 284));
					num = (int)((num2 * 659571014) ^ 0x39D42878);
					continue;
				case 44u:
					RegisterDonor.smethod_33(GroupBox1, "Parameter Check");
					num = (int)(num2 * 654754875) ^ -13637459;
					continue;
				case 43u:
					RegisterDonor.smethod_21((Control)(object)MobileLbl, 8);
					num = ((int)num2 * -1438344478) ^ -2000696717;
					continue;
				case 42u:
					num = ((int)num2 * -42244500) ^ -1567041320;
					continue;
				case 41u:
					CheckBox3 = RegisterDonor.smethod_8();
					num = ((int)num2 * -137482250) ^ -380467049;
					continue;
				case 40u:
					RegisterDonor.smethod_21((Control)(object)Label2, 24);
					num = ((int)num2 * -427855200) ^ -2036790357;
					continue;
				case 39u:
					RegisterDonor.smethod_36(Label1, bool_0: true);
					RegisterDonor.smethod_17((Control)(object)Label1, RegisterDonor.smethod_26("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1273727760) ^ 0x7C2F8BB5;
					continue;
				case 38u:
					RegisterDonor.smethod_23(Label3, (ContentAlignment)32);
					num = ((int)num2 * -1531932123) ^ -534005598;
					continue;
				case 37u:
					RegisterDonor.smethod_21((Control)(object)CheckBox7, 6);
					num = (int)(num2 * 614445599) ^ -1608775933;
					continue;
				case 36u:
					num = (int)((num2 * 1036361096) ^ 0x73CCE967);
					continue;
				case 35u:
					num = (int)(num2 * 1005986944) ^ -135025010;
					continue;
				case 34u:
					RegisterDonor.smethod_18((Control)(object)SuccessMsg, new Point(117, 174));
					num = ((int)num2 * -1781409679) ^ -1543642127;
					continue;
				case 33u:
					RegisterDonor.smethod_29((ButtonBase)(object)CheckBox1, bool_0: true);
					num = (int)(num2 * 1530011561) ^ -2018700126;
					continue;
				case 32u:
					RegisterDonor.smethod_36(Label7, bool_0: true);
					num = ((int)num2 * -961747587) ^ -356741816;
					continue;
				case 31u:
					RegisterDonor.smethod_20((Control)(object)QuantityTxt, new Size(87, 26));
					num = (int)((num2 * 774136531) ^ 0x6457759D);
					continue;
				case 30u:
					num = (int)(num2 * 1222266773) ^ -1043140913;
					continue;
				case 29u:
					num = (int)(num2 * 956817299) ^ -877519765;
					continue;
				case 28u:
					RegisterDonor.smethod_21((Control)(object)Label7, 22);
					RegisterDonor.smethod_22(Label7, "Amount Donated: ");
					num = ((int)num2 * -121527274) ^ -599781251;
					continue;
				case 27u:
					num = (int)((num2 * 5302326) ^ 0x2C6A58AD);
					continue;
				case 26u:
					RegisterDonor.smethod_18((Control)(object)NameTxt, new Point(127, 73));
					num = (int)((num2 * 1364032920) ^ 0x6A6D159B);
					continue;
				case 25u:
					RegisterDonor.smethod_41(PictureBox1, (Image)(object)Resources.images1232);
					RegisterDonor.smethod_18((Control)(object)PictureBox1, new Point(156, 33));
					num = ((int)num2 * -1905217031) ^ -1780229557;
					continue;
				case 24u:
					RegisterDonor.smethod_19((Control)(object)CheckBox1, "CheckBox1");
					num = ((int)num2 * -229198579) ^ -1810918102;
					continue;
				case 23u:
					RegisterDonor.smethod_19((Control)(object)PictureBox1, "PictureBox1");
					num = (int)(num2 * 912891551) ^ -215043355;
					continue;
				case 22u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox1), (Control)(object)CheckBox7);
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox1), (Control)(object)CheckBox6);
					num = ((int)num2 * -424613600) ^ 0x3F19C1D2;
					continue;
				case 21u:
					RegisterDonor.smethod_17((Control)(object)CheckBox6, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -2085707031) ^ 0x73F948B0;
					continue;
				case 20u:
					RegisterDonor.smethod_34((ButtonBase)(object)CheckBox2, bool_0: true);
					num = (int)(num2 * 737548352) ^ -1011921614;
					continue;
				case 19u:
					RegisterDonor.smethod_34((ButtonBase)(object)CheckBox1, bool_0: true);
					num = (int)((num2 * 1068114310) ^ 0x66FF92BA);
					continue;
				case 18u:
					RegisterDonor.smethod_20((Control)(object)GroupBox2, new Size(520, 444));
					num = ((int)num2 * -828513656) ^ 0x637ABF0;
					continue;
				case 17u:
					Timer1 = RegisterDonor.smethod_4(components);
					num = (int)(num2 * 1449002517) ^ -895898898;
					continue;
				case 16u:
					num = (int)((num2 * 126966887) ^ 0x7C28E52B);
					continue;
				case 15u:
					AddBtn = RegisterDonor.smethod_6();
					GroupBox1 = RegisterDonor.smethod_7();
					Label3 = RegisterDonor.smethod_5();
					num = ((int)num2 * -1273833337) ^ -726641748;
					continue;
				case 14u:
					RegisterDonor.smethod_25((ButtonBase)(object)AddBtn, Color.MidnightBlue);
					num = (int)((num2 * 1873606049) ^ 0x79CFAC79);
					continue;
				case 13u:
					num = (int)((num2 * 1341247502) ^ 0x7D5C95BE);
					continue;
				case 12u:
					RegisterDonor.smethod_23(MobileLbl, (ContentAlignment)32);
					num = ((int)num2 * -74516265) ^ -272745902;
					continue;
				case 11u:
					RegisterDonor.smethod_36(AgeLbl, bool_0: true);
					num = ((int)num2 * -294725870) ^ -1931389611;
					continue;
				case 10u:
					num = (int)(num2 * 469747660) ^ -1908676236;
					continue;
				case 9u:
					RegisterDonor.smethod_17((Control)(object)MobileTxt, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1763443280) ^ -862442972;
					continue;
				case 8u:
					RegisterDonor.smethod_17((Control)(object)CheckBox1, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 598379764) ^ -1316060390;
					continue;
				case 7u:
					RegisterDonor.smethod_23(SuccessMsg, (ContentAlignment)32);
					num = (int)(num2 * 1170350043) ^ -50315513;
					continue;
				case 6u:
					num = ((int)num2 * -1292779699) ^ 0x1ADE3FF3;
					continue;
				case 5u:
					num = (int)((num2 * 1953352584) ^ 0x2740A638);
					continue;
				case 4u:
					components = RegisterDonor.smethod_3();
					num = (int)(num2 * 55957792) ^ -1552971146;
					continue;
				case 3u:
					num = (int)((num2 * 1152221356) ^ 0x21570DC6);
					continue;
				case 2u:
					RegisterDonor.smethod_17((Control)(object)Label2, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1892674847) ^ 0x218BEC9A);
					continue;
				case 1u:
					RegisterDonor.smethod_51((Control)(object)GroupBox1, bool_0: false);
					num = (int)(num2 * 1304648439) ^ -1129417270;
					continue;
				case 0u:
					num = ((int)num2 * -1948112520) ^ 0x471DEAF;
					continue;
				default:
					return;
				case 201u:
					break;
				case 223u:
					return;
				}
				break;
			}
		}
	}

	private void RegisterDonor_Load(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1419367713;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAA62EAF0u) % 9u)
				{
				case 8u:
					RegisterDonor.smethod_64(GenderTxt, -1);
					num = (int)((num2 * 1511297179) ^ 0x24ED4A17);
					continue;
				case 7u:
					RegisterDonor.smethod_63(myconnection, RegisterDonor.smethod_62(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
					num = (int)(num2 * 1486570169) ^ -670074113;
					continue;
				case 5u:
					num = ((int)num2 * -538670988) ^ -612046148;
					continue;
				case 4u:
					num = ((int)num2 * -1359645548) ^ -744238903;
					continue;
				case 3u:
					num = ((int)num2 * -806359820) ^ 0x72A8FDC7;
					continue;
				case 2u:
					RegisterDonor.smethod_64(BloodGrpTxt, 0);
					num = ((int)num2 * -1905269138) ^ -239247574;
					continue;
				case 0u:
					RegisterDonor.smethod_65(DateTxt, DateTime.Today.ToShortDateString());
					num = ((int)num2 * -1881552815) ^ 0x3A66A64D;
					continue;
				default:
					return;
				case 6u:
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
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected I4, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected I4, but got Unknown
		//IL_0362: Incompatible stack heights: 0 vs 1
		//IL_0372: Incompatible stack heights: 0 vs 1
		//IL_0382: Incompatible stack heights: 0 vs 1
		//IL_039d: Incompatible stack heights: 0 vs 1
		//IL_03b5: Incompatible stack heights: 0 vs 1
		//IL_03d8: Incompatible stack heights: 0 vs 1
		//IL_03fb: Incompatible stack heights: 0 vs 1
		//IL_0405: Incompatible stack heights: 0 vs 1
		bool flag = !Validate_data();
		string string_ = default(string);
		OleDbCommand val = default(OleDbCommand);
		while (true)
		{
			int num = 803344938;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2F0DB4F1u) % 5u)
				{
				case 4u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -896554059;
						num5 = -896554059;
					}
					else
					{
						num4 = -2033841574;
						num5 = -2033841574;
					}
					num = num4 ^ (int)(num2 * 684783004);
					continue;
				}
				case 0u:
					string_ = "Insert Into [Donor] (Name,Gender,Age,Blood,Mobile,[Blood Amount],[Donation Date]) Values (?,?,?,?,?,?,?)";
					num = 497820132;
					continue;
				case 3u:
					break;
				default:
					RegisterDonor.smethod_66(myconnection);
					try
					{
						while (true)
						{
							int num3 = 1803876311;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x2F0DB4F1u) % 13u)
								{
								case 12u:
									RegisterDonor.smethod_78(myconnection);
									num3 = (int)(num2 * 1465773711) ^ -977517673;
									continue;
								case 11u:
									num3 = (int)(num2 * 70129807) ^ -929775063;
									continue;
								case 10u:
									RegisterDonor.smethod_72(RegisterDonor.smethod_68(val), RegisterDonor.smethod_71("Blood", (object)RegisterDonor.smethod_73(BloodGrpTxt)));
									RegisterDonor.smethod_72(RegisterDonor.smethod_68(val), RegisterDonor.smethod_71("Mobile", (object)RegisterDonor.smethod_75(RegisterDonor.smethod_69(MobileTxt))));
									num3 = (int)((num2 * 1694463918) ^ 0x1B8E67DF);
									continue;
								case 8u:
									RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
									RegisterDonor.smethod_22(SuccessMsg, "Donor Successfully Registered !!");
									num3 = ((int)num2 * -560931879) ^ -1914811036;
									continue;
								case 7u:
									RegisterDonor.smethod_72(RegisterDonor.smethod_68(val), RegisterDonor.smethod_71("Gender", (object)RegisterDonor.smethod_70(RegisterDonor.smethod_73(GenderTxt))));
									RegisterDonor.smethod_72(RegisterDonor.smethod_68(val), RegisterDonor.smethod_71("Age", (object)(int)RegisterDonor.smethod_74(RegisterDonor.smethod_69(AgeTxt))));
									num3 = (int)(num2 * 520026506) ^ -1494167502;
									continue;
								case 6u:
									RegisterDonor.smethod_77((Component)(object)val);
									num3 = (int)(num2 * 1035037337) ^ -685163918;
									continue;
								case 4u:
									RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Green);
									num3 = ((int)num2 * -101139340) ^ 0x4BBB87CD;
									continue;
								case 3u:
									num3 = ((int)num2 * -161842341) ^ 0x22339BF0;
									continue;
								case 2u:
									val = RegisterDonor.smethod_67(string_, myconnection);
									num3 = (int)((num2 * 187820832) ^ 0xB1F2CA0);
									continue;
								case 1u:
									RegisterDonor.smethod_72(RegisterDonor.smethod_68(val), RegisterDonor.smethod_71("Name", (object)RegisterDonor.smethod_70(RegisterDonor.smethod_69(NameTxt))));
									num3 = ((int)num2 * -737179451) ^ -2007840271;
									continue;
								case 0u:
									RegisterDonor.smethod_72(RegisterDonor.smethod_68(val), RegisterDonor.smethod_71("Blood Amount", (object)RegisterDonor.smethod_69(QuantityTxt)));
									RegisterDonor.smethod_72(RegisterDonor.smethod_68(val), RegisterDonor.smethod_71("Donation Date", (object)RegisterDonor.smethod_75(RegisterDonor.smethod_69(DateTxt))));
									RegisterDonor.smethod_76(val);
									num3 = ((int)num2 * -2049348549) ^ -1817060515;
									continue;
								case 5u:
									break;
								default:
									RegisterDonor.smethod_79(Timer1);
									return;
								}
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						RegisterDonor.smethod_80(exception_);
						RegisterDonor.smethod_78(myconnection);
						while (true)
						{
							_ = 868799082;
							while (true)
							{
								_003F val2 = /*Error near IL_0314: Stack underflow*/^ 0x2F0DB4F1;
								num2 = (uint)(int)val2;
								switch (val2 % 9)
								{
								default:
									return;
								case 8:
									RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
									_ = (num2 * 852133302) ^ 0x50806F46;
									continue;
								case 7:
									_ = (num2 * 1415346524) ^ 0xAD77C277u;
									continue;
								case 6:
									_ = (num2 * 1920062335) ^ 0xE45FB4BDu;
									continue;
								case 5:
									RegisterDonor.smethod_79(Timer1);
									_ = ((int)num2 * -462473285) ^ 0x171C25F9;
									continue;
								case 3:
									RegisterDonor.smethod_81();
									_ = ((int)num2 * -1333337519) ^ -1050196790;
									continue;
								case 2:
									RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Red);
									_ = (num2 * 1825993700) ^ 0x2A3515E3;
									continue;
								case 0:
									RegisterDonor.smethod_22(SuccessMsg, "Invalid Credentials");
									_ = ((int)num2 * -1438050150) ^ -891651055;
									continue;
								case 4:
									break;
								case 1:
									return;
								}
								break;
							}
						}
					}
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private bool Validate_data()
	{
		bool flag = !MyProject.Forms.Form1.Name_Validation(RegisterDonor.smethod_70(RegisterDonor.smethod_69(NameTxt)));
		bool flag4 = default(bool);
		bool result = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 1476076583;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7F358E21u) % 61u)
				{
				case 60u:
					num = (int)((num2 * 194247132) ^ 0x3634B96D);
					continue;
				case 59u:
				{
					flag4 = int.TryParse(RegisterDonor.smethod_69(AgeTxt), out var result2) && (result2 < 18 || result2 > 55);
					num = 1558404305;
					continue;
				}
				case 58u:
				{
					int num8;
					int num9;
					if (flag)
					{
						num8 = -598320362;
						num9 = -598320362;
					}
					else
					{
						num8 = -790188172;
						num9 = -790188172;
					}
					num = num8 ^ (int)(num2 * 2000147294);
					continue;
				}
				case 56u:
					num = (int)(num2 * 1175585423) ^ -1369619396;
					continue;
				case 55u:
				{
					int num16;
					int num17;
					if (!flag4)
					{
						num16 = 917506326;
						num17 = 917506326;
					}
					else
					{
						num16 = 1105967383;
						num17 = 1105967383;
					}
					num = num16 ^ ((int)num2 * -995160186);
					continue;
				}
				case 54u:
					result = false;
					num = ((int)num2 * -317962713) ^ -653372555;
					continue;
				case 53u:
					result = false;
					num = ((int)num2 * -1309480769) ^ 0xA4A33D5;
					continue;
				case 52u:
					num = ((int)num2 * -229350260) ^ 0x660989BE;
					continue;
				case 51u:
					RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
					RegisterDonor.smethod_22(SuccessMsg, "Donor Not Eligible");
					num = (int)(num2 * 1318507369) ^ -1027213778;
					continue;
				case 50u:
					RegisterDonor.smethod_79(Timer1);
					num = (int)((num2 * 1817968003) ^ 0x2FEF7BC7);
					continue;
				case 49u:
					RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
					num = (int)((num2 * 1787902532) ^ 0x6513E6F);
					continue;
				case 48u:
					num = (int)((num2 * 1355514672) ^ 0x5E3492D5);
					continue;
				case 47u:
				{
					int num4;
					int num5;
					if (!flag2)
					{
						num4 = 1192843408;
						num5 = 1192843408;
					}
					else
					{
						num4 = 1944661904;
						num5 = 1944661904;
					}
					num = num4 ^ ((int)num2 * -1497767846);
					continue;
				}
				case 46u:
					RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
					num = (int)((num2 * 100340893) ^ 0x42FAFF04);
					continue;
				case 45u:
					num = (int)(num2 * 1060288039) ^ -195521205;
					continue;
				case 44u:
					RegisterDonor.smethod_22(SuccessMsg, "Select Proper Blood Group");
					num = ((int)num2 * -1310188185) ^ 0x39C38E9E;
					continue;
				case 43u:
					num = (int)((num2 * 2099270828) ^ 0x74E93926);
					continue;
				case 42u:
					RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = (int)((num2 * 43825357) ^ 0xE80B3F5);
					continue;
				case 41u:
					num = (int)(num2 * 1087137040) ^ -1986664349;
					continue;
				case 40u:
					num = ((int)num2 * -983041551) ^ -175628230;
					continue;
				case 39u:
					RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -924009235) ^ -1139090683;
					continue;
				case 38u:
					result = false;
					num = ((int)num2 * -1071072019) ^ 0x9864D10;
					continue;
				case 37u:
					num = ((int)num2 * -245272395) ^ 0x31E4CF94;
					continue;
				case 36u:
					RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Red);
					RegisterDonor.smethod_79(Timer1);
					num = (int)((num2 * 67302654) ^ 0x5FC55409);
					continue;
				case 35u:
					num = 1140912226;
					continue;
				case 34u:
				{
					int num14;
					int num15;
					if (!(!RegisterDonor.smethod_83(CheckBox1) | !RegisterDonor.smethod_83(CheckBox2) | !RegisterDonor.smethod_83(CheckBox3) | !RegisterDonor.smethod_83(CheckBox4) | !RegisterDonor.smethod_83(CheckBox5) | !RegisterDonor.smethod_83(CheckBox6) | !RegisterDonor.smethod_83(CheckBox7) | !RegisterDonor.smethod_83(CheckBox8)))
					{
						num14 = -1041013840;
						num15 = -1041013840;
					}
					else
					{
						num14 = -1615911892;
						num15 = -1615911892;
					}
					num = num14 ^ ((int)num2 * -141917882);
					continue;
				}
				case 33u:
					RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
					RegisterDonor.smethod_22(SuccessMsg, "Invalid Quantity");
					RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -869798875) ^ 0x107DF26D;
					continue;
				case 32u:
					RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
					RegisterDonor.smethod_22(SuccessMsg, "Invalid Name");
					RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = (int)((num2 * 1388925517) ^ 0x7C8B40C);
					continue;
				case 30u:
					num = (int)(num2 * 1175330082) ^ -1647434270;
					continue;
				case 29u:
					num = (int)((num2 * 102039097) ^ 0x3A20946);
					continue;
				case 28u:
					num = 1091557112;
					continue;
				case 27u:
					RegisterDonor.smethod_79(Timer1);
					num = ((int)num2 * -1627502418) ^ 0x6F161C4E;
					continue;
				case 26u:
					RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
					num = (int)((num2 * 836742387) ^ 0x53EB9F05);
					continue;
				case 25u:
					RegisterDonor.smethod_22(SuccessMsg, "Invalid Gender");
					num = (int)((num2 * 574826291) ^ 0x3EA08A);
					continue;
				case 24u:
				{
					int num12;
					int num13;
					if (RegisterDonor.smethod_82(BloodGrpTxt) == 0)
					{
						num12 = -363132877;
						num13 = -363132877;
					}
					else
					{
						num12 = -672348040;
						num13 = -672348040;
					}
					num = num12 ^ (int)(num2 * 1549082955);
					continue;
				}
				case 23u:
					num = (int)((num2 * 937881327) ^ 0x106F3647);
					continue;
				case 22u:
					result = true;
					num = (int)((num2 * 443195702) ^ 0x30BEE008);
					continue;
				case 21u:
					flag3 = !MyProject.Forms.Form1.age_validator(RegisterDonor.smethod_69(AgeTxt));
					num = ((int)num2 * -1143546665) ^ 0x5FB93D32;
					continue;
				case 20u:
					num = ((int)num2 * -1746035338) ^ 0x752DEDC6;
					continue;
				case 19u:
					num = 1186196100;
					continue;
				case 18u:
					result = false;
					num = (int)((num2 * 875914657) ^ 0x37EA3C3B);
					continue;
				case 17u:
					num = 457483267;
					continue;
				case 16u:
					result = false;
					num = ((int)num2 * -72333744) ^ 0x6BEEC45C;
					continue;
				case 15u:
					flag2 = !MyProject.Forms.Form1.Gender_Validator(RegisterDonor.smethod_70(RegisterDonor.smethod_73(GenderTxt)));
					num = 1863758677;
					continue;
				case 14u:
					result = false;
					num = ((int)num2 * -768830408) ^ -2042917526;
					continue;
				case 13u:
					RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = (int)((num2 * 936150762) ^ 0x25406BF6);
					continue;
				case 12u:
					RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -1690032577) ^ 0x29F391A;
					continue;
				case 11u:
					RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
					RegisterDonor.smethod_22(SuccessMsg, "Invalid Age");
					RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Red);
					RegisterDonor.smethod_79(Timer1);
					num = ((int)num2 * -417294454) ^ -1560557230;
					continue;
				case 10u:
					result = false;
					num = (int)((num2 * 680158598) ^ 0x771E8B12);
					continue;
				case 9u:
					num = 413992199;
					continue;
				case 8u:
					RegisterDonor.smethod_22(SuccessMsg, "Donor Not Eligible.");
					num = ((int)num2 * -2071602110) ^ 0x4A86B5F0;
					continue;
				case 7u:
				{
					int num10;
					int num11;
					if (!MyProject.Forms.Form1.Decimal_Validator(RegisterDonor.smethod_69(QuantityTxt)))
					{
						num10 = -34010785;
						num11 = -34010785;
					}
					else
					{
						num10 = -1000363289;
						num11 = -1000363289;
					}
					num = num10 ^ ((int)num2 * -541072395);
					continue;
				}
				case 6u:
					num = (int)((num2 * 1858297065) ^ 0x700E25DE);
					continue;
				case 5u:
					RegisterDonor.smethod_22(SuccessMsg, "Invalid Mobile Number");
					RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Red);
					RegisterDonor.smethod_79(Timer1);
					num = (int)(num2 * 1608074790) ^ -1964739180;
					continue;
				case 4u:
				{
					int num6;
					int num7;
					if (!flag3)
					{
						num6 = -1159577284;
						num7 = -1159577284;
					}
					else
					{
						num6 = -818653877;
						num7 = -818653877;
					}
					num = num6 ^ (int)(num2 * 1023978522);
					continue;
				}
				case 3u:
					RegisterDonor.smethod_79(Timer1);
					result = false;
					num = ((int)num2 * -1664372701) ^ -1830686229;
					continue;
				case 2u:
					RegisterDonor.smethod_79(Timer1);
					num = (int)((num2 * 429219062) ^ 0x34693481);
					continue;
				case 1u:
				{
					int num3;
					if (MyProject.Forms.Form1.Mobile_Validator(RegisterDonor.smethod_69(MobileTxt)))
					{
						num = 277433202;
						num3 = 277433202;
					}
					else
					{
						num = 72593293;
						num3 = 72593293;
					}
					continue;
				}
				case 0u:
					RegisterDonor.smethod_79(Timer1);
					num = (int)(num2 * 377312375) ^ -367493140;
					continue;
				case 31u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private void ClearBtn_Click(object sender, EventArgs e)
	{
		RegisterDonor.smethod_84((TextBoxBase)(object)NameTxt);
		RegisterDonor.smethod_84((TextBoxBase)(object)AgeTxt);
		while (true)
		{
			int num = -1923160173;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBF1360FDu) % 16u)
				{
				case 15u:
					RegisterDonor.smethod_85(CheckBox2, bool_0: false);
					num = (int)((num2 * 1074046085) ^ 0x6A4CFA34);
					continue;
				case 14u:
					RegisterDonor.smethod_64(GenderTxt, -1);
					num = ((int)num2 * -1213361802) ^ -440325188;
					continue;
				case 13u:
					RegisterDonor.smethod_85(CheckBox8, bool_0: false);
					num = ((int)num2 * -2074142667) ^ -1407831296;
					continue;
				case 12u:
					num = ((int)num2 * -776936807) ^ -351454800;
					continue;
				case 11u:
					num = (int)(num2 * 545060024) ^ -1372880036;
					continue;
				case 10u:
					RegisterDonor.smethod_85(CheckBox6, bool_0: false);
					num = (int)(num2 * 1613246338) ^ -301161443;
					continue;
				case 9u:
					RegisterDonor.smethod_85(CheckBox5, bool_0: false);
					num = (int)(num2 * 1446644902) ^ -402574063;
					continue;
				case 7u:
					RegisterDonor.smethod_85(CheckBox1, bool_0: false);
					num = (int)((num2 * 634230354) ^ 0x495DA220);
					continue;
				case 6u:
					RegisterDonor.smethod_64(BloodGrpTxt, 0);
					num = ((int)num2 * -2037886598) ^ -1859788250;
					continue;
				case 5u:
					RegisterDonor.smethod_84((TextBoxBase)(object)MobileTxt);
					num = (int)(num2 * 724772819) ^ -1989842700;
					continue;
				case 4u:
					RegisterDonor.smethod_85(CheckBox7, bool_0: false);
					num = (int)((num2 * 205519848) ^ 0x44632C80);
					continue;
				case 3u:
					num = ((int)num2 * -1415428327) ^ 0x35BF2E89;
					continue;
				case 2u:
					RegisterDonor.smethod_85(CheckBox3, bool_0: false);
					num = (int)((num2 * 758949246) ^ 0x42F1FA81);
					continue;
				case 0u:
					RegisterDonor.smethod_85(CheckBox4, bool_0: false);
					num = (int)(num2 * 281179633) ^ -2019530730;
					continue;
				default:
					return;
				case 8u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1952128645;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9E2C8054u) % 6u)
				{
				case 5u:
					num = (int)((num2 * 75718882) ^ 0x64761590);
					continue;
				case 3u:
					num = (int)(num2 * 1043844588) ^ -1446118116;
					continue;
				case 2u:
					RegisterDonor.smethod_86(Timer1);
					num = (int)((num2 * 39843793) ^ 0x1D873E89);
					continue;
				case 1u:
					RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: false);
					num = (int)((num2 * 1816324168) ^ 0x3C26745D);
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

	private void GenderTxt_SelectionChangeCommitted(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1648816533;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2AC09A87u) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0003:
				RegisterDonor.smethod_87((Control)(object)BloodGrpTxt);
				num = ((int)num2 * -871203634) ^ 0x4C4345D9;
			}
		}
	}

	static void smethod_0(UserControl userControl_0, EventHandler eventHandler_0)
	{
		userControl_0.add_Load(eventHandler_0);
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

	static Container smethod_3()
	{
		return new Container();
	}

	static Timer smethod_4(IContainer icontainer_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_0);
	}

	static Label smethod_5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static Button smethod_6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static GroupBox smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new GroupBox();
	}

	static CheckBox smethod_8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new CheckBox();
	}

	static TextBox smethod_9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static ComboBox smethod_10()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ComboBox();
	}

	static PictureBox smethod_11()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PictureBox();
	}

	static void smethod_12(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_13(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_14(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_15(Timer timer_0, int int_0)
	{
		timer_0.set_Interval(int_0);
	}

	static Font smethod_16(string string_0, float float_0, FontStyle fontStyle_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0);
	}

	static void smethod_17(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_18(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_19(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_20(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_21(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_22(Label label_0, string string_0)
	{
		label_0.set_Text(string_0);
	}

	static void smethod_23(Label label_0, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_TextAlign(contentAlignment_0);
	}

	static void smethod_24(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static void smethod_25(ButtonBase buttonBase_0, Color color_0)
	{
		buttonBase_0.set_BackColor(color_0);
	}

	static Font smethod_26(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_27(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
	}

	static void smethod_28(ButtonBase buttonBase_0, string string_0)
	{
		buttonBase_0.set_Text(string_0);
	}

	static void smethod_29(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
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

	static void smethod_34(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_AutoSize(bool_0);
	}

	static void smethod_35(TextBoxBase textBoxBase_0, bool bool_0)
	{
		textBoxBase_0.set_ReadOnly(bool_0);
	}

	static void smethod_36(Label label_0, bool bool_0)
	{
		label_0.set_AutoSize(bool_0);
	}

	static void smethod_37(ComboBox comboBox_0, ComboBoxStyle comboBoxStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		comboBox_0.set_DropDownStyle(comboBoxStyle_0);
	}

	static void smethod_38(ListControl listControl_0, bool bool_0)
	{
		listControl_0.set_FormattingEnabled(bool_0);
	}

	static ObjectCollection smethod_39(ComboBox comboBox_0)
	{
		return comboBox_0.get_Items();
	}

	static void smethod_40(ObjectCollection objectCollection_0, object[] object_0)
	{
		objectCollection_0.AddRange(object_0);
	}

	static void smethod_41(PictureBox pictureBox_0, Image image_0)
	{
		pictureBox_0.set_Image(image_0);
	}

	static void smethod_42(PictureBox pictureBox_0, PictureBoxSizeMode pictureBoxSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		pictureBox_0.set_SizeMode(pictureBoxSizeMode_0);
	}

	static void smethod_43(PictureBox pictureBox_0, int int_0)
	{
		pictureBox_0.set_TabIndex(int_0);
	}

	static void smethod_44(PictureBox pictureBox_0, bool bool_0)
	{
		pictureBox_0.set_TabStop(bool_0);
	}

	static void smethod_45(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_46(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_47(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static ControlCollection smethod_48(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_49(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_50(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_51(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_52(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_53(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_54(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_55(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_56(Timer timer_0, EventHandler eventHandler_0)
	{
		timer_0.remove_Tick(eventHandler_0);
	}

	static void smethod_57(Timer timer_0, EventHandler eventHandler_0)
	{
		timer_0.add_Tick(eventHandler_0);
	}

	static void smethod_58(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_59(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_60(ComboBox comboBox_0, EventHandler eventHandler_0)
	{
		comboBox_0.remove_SelectionChangeCommitted(eventHandler_0);
	}

	static void smethod_61(ComboBox comboBox_0, EventHandler eventHandler_0)
	{
		comboBox_0.add_SelectionChangeCommitted(eventHandler_0);
	}

	static string smethod_62(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_63(OleDbConnection oleDbConnection_0, string string_0)
	{
		oleDbConnection_0.set_ConnectionString(string_0);
	}

	static void smethod_64(ComboBox comboBox_0, int int_0)
	{
		comboBox_0.set_SelectedIndex(int_0);
	}

	static void smethod_65(TextBox textBox_0, string string_0)
	{
		textBox_0.set_Text(string_0);
	}

	static void smethod_66(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Open();
	}

	static OleDbCommand smethod_67(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbCommand(string_0, oleDbConnection_0);
	}

	static OleDbParameterCollection smethod_68(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.get_Parameters();
	}

	static string smethod_69(TextBox textBox_0)
	{
		return textBox_0.get_Text();
	}

	static string smethod_70(string string_0)
	{
		return string_0.ToLower();
	}

	static OleDbParameter smethod_71(string string_0, object object_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbParameter(string_0, object_0);
	}

	static OleDbParameter smethod_72(OleDbParameterCollection oleDbParameterCollection_0, OleDbParameter oleDbParameter_0)
	{
		return oleDbParameterCollection_0.Add(oleDbParameter_0);
	}

	static string smethod_73(ComboBox comboBox_0)
	{
		return comboBox_0.get_Text();
	}

	static short smethod_74(string string_0)
	{
		return Convert.ToInt16(string_0);
	}

	static string smethod_75(string string_0)
	{
		return string_0.ToString();
	}

	static int smethod_76(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.ExecuteNonQuery();
	}

	static void smethod_77(Component component_0)
	{
		component_0.Dispose();
	}

	static void smethod_78(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Close();
	}

	static void smethod_79(Timer timer_0)
	{
		timer_0.Start();
	}

	static void smethod_80(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_81()
	{
		ProjectData.ClearProjectError();
	}

	static int smethod_82(ComboBox comboBox_0)
	{
		return comboBox_0.get_SelectedIndex();
	}

	static bool smethod_83(CheckBox checkBox_0)
	{
		return checkBox_0.get_Checked();
	}

	static void smethod_84(TextBoxBase textBoxBase_0)
	{
		textBoxBase_0.Clear();
	}

	static void smethod_85(CheckBox checkBox_0, bool bool_0)
	{
		checkBox_0.set_Checked(bool_0);
	}

	static void smethod_86(Timer timer_0)
	{
		timer_0.Stop();
	}

	static bool smethod_87(Control control_0)
	{
		return control_0.Focus();
	}
}
