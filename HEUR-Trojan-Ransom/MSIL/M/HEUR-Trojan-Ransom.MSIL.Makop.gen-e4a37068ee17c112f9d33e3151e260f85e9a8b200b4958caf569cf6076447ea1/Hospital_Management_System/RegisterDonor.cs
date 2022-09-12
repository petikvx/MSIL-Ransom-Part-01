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
				int num = -1306299979;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x984612D2u) % 7u)
					{
					case 5u:
					{
						int num4;
						int num5;
						if (timer == null)
						{
							num4 = 469950245;
							num5 = 469950245;
						}
						else
						{
							num4 = 1201225571;
							num5 = 1201225571;
						}
						num = num4 ^ ((int)num2 * -1203405897);
						continue;
					}
					case 4u:
					{
						_Timer1 = value;
						timer = _Timer1;
						int num3;
						if (timer == null)
						{
							num = -1785043941;
							num3 = -1785043941;
						}
						else
						{
							num = -488488561;
							num3 = -488488561;
						}
						continue;
					}
					case 2u:
						RegisterDonor.smethod_56(timer, eventHandler_);
						num = ((int)num2 * -248652255) ^ 0x76AC94;
						continue;
					case 1u:
						timer = _Timer1;
						num = ((int)num2 * -2070000276) ^ 0x1EB2CE01;
						continue;
					case 0u:
						RegisterDonor.smethod_57(timer, eventHandler_);
						num = (int)(num2 * 370113310) ^ -1504176131;
						continue;
					default:
						return;
					case 3u:
						break;
					case 6u:
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
			Button clearBtn = default(Button);
			while (true)
			{
				int num = 451103495;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x685CF3CDu) % 7u)
					{
					case 6u:
						clearBtn = _ClearBtn;
						num = ((int)num2 * -2118975391) ^ 0x335382E3;
						continue;
					case 5u:
						RegisterDonor.smethod_59((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -1954784748) ^ 0x31EA9D83;
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (clearBtn != null)
						{
							num4 = -636673639;
							num5 = -636673639;
						}
						else
						{
							num4 = -1338585320;
							num5 = -1338585320;
						}
						num = num4 ^ ((int)num2 * -1803292196);
						continue;
					}
					case 3u:
					{
						_ClearBtn = value;
						clearBtn = _ClearBtn;
						int num3;
						if (clearBtn == null)
						{
							num = 819702943;
							num3 = 819702943;
						}
						else
						{
							num = 930315414;
							num3 = 930315414;
						}
						continue;
					}
					case 0u:
						RegisterDonor.smethod_58((Control)(object)clearBtn, eventHandler_);
						num = (int)((num2 * 964127000) ^ 0x43531088);
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
				int num = -1505794036;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA27C5C19u) % 8u)
					{
					case 7u:
						_AddBtn = value;
						num = -2035460793;
						continue;
					case 6u:
						addBtn = _AddBtn;
						num = (int)((num2 * 740461214) ^ 0x42F190B1);
						continue;
					case 5u:
					{
						addBtn = _AddBtn;
						int num5;
						int num6;
						if (addBtn == null)
						{
							num5 = -864445755;
							num6 = -864445755;
						}
						else
						{
							num5 = -1352907501;
							num6 = -1352907501;
						}
						num = num5 ^ (int)(num2 * 771762223);
						continue;
					}
					case 4u:
					{
						int num3;
						int num4;
						if (addBtn == null)
						{
							num3 = -269354033;
							num4 = -269354033;
						}
						else
						{
							num3 = -33062642;
							num4 = -33062642;
						}
						num = num3 ^ (int)(num2 * 1738336941);
						continue;
					}
					case 3u:
						RegisterDonor.smethod_59((Control)(object)addBtn, eventHandler_);
						num = ((int)num2 * -569682828) ^ -1164215153;
						continue;
					case 1u:
						RegisterDonor.smethod_58((Control)(object)addBtn, eventHandler_);
						num = (int)((num2 * 164623879) ^ 0x3A3030A9);
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
			ComboBox genderTxt = default(ComboBox);
			while (true)
			{
				int num = 1204859778;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1C8CD7B5u) % 8u)
					{
					case 7u:
						genderTxt = _GenderTxt;
						num = ((int)num2 * -595881537) ^ -2124102435;
						continue;
					case 5u:
					{
						genderTxt = _GenderTxt;
						int num5;
						int num6;
						if (genderTxt != null)
						{
							num5 = -304860589;
							num6 = -304860589;
						}
						else
						{
							num5 = -1312577143;
							num6 = -1312577143;
						}
						num = num5 ^ ((int)num2 * -1704273402);
						continue;
					}
					case 4u:
						_GenderTxt = value;
						num = 982767312;
						continue;
					case 3u:
						RegisterDonor.smethod_60(genderTxt, eventHandler_);
						num = ((int)num2 * -1182776686) ^ -1473471809;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (genderTxt == null)
						{
							num3 = -924304900;
							num4 = -924304900;
						}
						else
						{
							num3 = -1451291093;
							num4 = -1451291093;
						}
						num = num3 ^ (int)(num2 * 1181331333);
						continue;
					}
					case 0u:
						RegisterDonor.smethod_61(genderTxt, eventHandler_);
						num = (int)(num2 * 244665671) ^ -238061601;
						continue;
					default:
						return;
					case 6u:
						break;
					case 2u:
						return;
					}
					break;
				}
			}
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
			int num = -353144722;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8DBE5C47u) % 7u)
				{
				case 5u:
					num = ((int)num2 * -657267933) ^ -1202335489;
					continue;
				case 4u:
					myconnection = RegisterDonor.smethod_1();
					num = (int)(num2 * 236448605) ^ -2075001688;
					continue;
				case 3u:
					RegisterDonor.smethod_0((UserControl)(object)this, (EventHandler)RegisterDonor_Load);
					num = ((int)num2 * -565931828) ^ -233372240;
					continue;
				case 2u:
					num = (int)(num2 * 347491691) ^ -340153791;
					continue;
				case 1u:
					InitializeComponent();
					num = ((int)num2 * -196502241) ^ -329142470;
					continue;
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

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			bool flag = default(bool);
			while (true)
			{
				int num = 382102867;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x794F0097u) % 7u)
					{
					case 5u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -1794255717;
							num5 = -1794255717;
						}
						else
						{
							num4 = -1482857305;
							num5 = -1482857305;
						}
						num = num4 ^ ((int)num2 * -2125537228);
						continue;
					}
					case 3u:
						RegisterDonor.smethod_2((IDisposable)components);
						num = (int)((num2 * 2069289589) ^ 0x40CC6288);
						continue;
					case 2u:
						if (disposing)
						{
							num = ((int)num2 * -326249187) ^ 0x733EEAAB;
							continue;
						}
						num3 = 0;
						goto IL_0058;
					case 1u:
						num3 = ((components != null) ? 1 : 0);
						goto IL_0058;
					case 0u:
						num = (int)(num2 * 564983617) ^ -1477877756;
						continue;
					default:
						return;
					case 4u:
						break;
					case 6u:
						return;
						IL_0058:
						flag = (byte)num3 != 0;
						num = 748229426;
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
			int num = 893167030;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9EBFBE8u) % 402u)
				{
				case 401u:
					RegisterDonor.smethod_18((Control)(object)PictureBox1, new Point(156, 33));
					num = (int)((num2 * 1580752463) ^ 0x48137972);
					continue;
				case 400u:
					RegisterDonor.smethod_34((ButtonBase)(object)CheckBox4, bool_0: true);
					RegisterDonor.smethod_17((Control)(object)CheckBox4, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1579972722) ^ -1877010358;
					continue;
				case 399u:
					AddBtn = RegisterDonor.smethod_6();
					num = ((int)num2 * -468654256) ^ 0x5131687F;
					continue;
				case 398u:
					RegisterDonor.smethod_19((Control)(object)MobileLbl, "MobileLbl");
					num = (int)(num2 * 152563957) ^ -2090272651;
					continue;
				case 397u:
					RegisterDonor.smethod_17((Control)(object)GroupBox1, RegisterDonor.smethod_26("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 316323957) ^ -96399723;
					continue;
				case 396u:
					num = ((int)num2 * -1652658083) ^ 0x4100EC55;
					continue;
				case 395u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)NameTxt);
					num = ((int)num2 * -1507101221) ^ -97567855;
					continue;
				case 394u:
					num = (int)(num2 * 1866857881) ^ -1102237246;
					continue;
				case 393u:
					RegisterDonor.smethod_36(NameLbl, bool_0: true);
					num = (int)((num2 * 971364614) ^ 0x5C140F1B);
					continue;
				case 392u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)AgeTxt);
					num = ((int)num2 * -1690451910) ^ -135253673;
					continue;
				case 391u:
					RegisterDonor.smethod_22(NameLbl, "Name :");
					num = (int)((num2 * 2026405544) ^ 0x368EA5EE);
					continue;
				case 390u:
					RegisterDonor.smethod_20((Control)(object)CheckBox2, new Size(128, 23));
					num = (int)(num2 * 93943397) ^ -1943434849;
					continue;
				case 389u:
					num = ((int)num2 * -645065097) ^ 0x49816BB6;
					continue;
				case 388u:
					RegisterDonor.smethod_21((Control)(object)SuccessMsg, 21);
					num = ((int)num2 * -1166642420) ^ -1399273265;
					continue;
				case 387u:
					RegisterDonor.smethod_23(SuccessMsg, (ContentAlignment)32);
					num = ((int)num2 * -1961987467) ^ 0x7B246ADD;
					continue;
				case 386u:
					RegisterDonor.smethod_52((Control)(object)GroupBox1);
					num = ((int)num2 * -660089950) ^ -1941965822;
					continue;
				case 385u:
					RegisterDonor.smethod_18((Control)(object)BloodGrpTxt, new Point(163, 277));
					num = ((int)num2 * -487952030) ^ 0x7C7B5078;
					continue;
				case 384u:
					num = ((int)num2 * -1718899561) ^ -449492797;
					continue;
				case 383u:
					num = ((int)num2 * -817777259) ^ -449549286;
					continue;
				case 382u:
					num = ((int)num2 * -668439805) ^ 0x4365F55E;
					continue;
				case 381u:
					RegisterDonor.smethod_17((Control)(object)AgeLbl, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -491448380) ^ 0x5204E812;
					continue;
				case 380u:
					NameTxt = RegisterDonor.smethod_9();
					num = ((int)num2 * -847464652) ^ -1498917861;
					continue;
				case 379u:
					BloodGrpLbl = RegisterDonor.smethod_5();
					num = ((int)num2 * -62683006) ^ 0x3D1124E1;
					continue;
				case 378u:
					RegisterDonor.smethod_34((ButtonBase)(object)CheckBox8, bool_0: true);
					num = (int)(num2 * 104108812) ^ -1916570498;
					continue;
				case 377u:
					RegisterDonor.smethod_36(Label7, bool_0: true);
					num = (int)((num2 * 888937358) ^ 0x35A37739);
					continue;
				case 376u:
					RegisterDonor.smethod_21((Control)(object)GenderTxt, 14);
					num = ((int)num2 * -787838448) ^ -1520412589;
					continue;
				case 375u:
					RegisterDonor.smethod_32(GroupBox2, bool_0: false);
					num = (int)(num2 * 184864914) ^ -347517773;
					continue;
				case 374u:
					RegisterDonor.smethod_14((Control)(object)this);
					num = ((int)num2 * -1822723074) ^ -1335339145;
					continue;
				case 373u:
					RegisterDonor.smethod_19((Control)(object)PictureBox1, "PictureBox1");
					num = ((int)num2 * -121244847) ^ 0x5D0A56E9;
					continue;
				case 372u:
					RegisterDonor.smethod_36(Label1, bool_0: true);
					num = ((int)num2 * -1465239015) ^ -154943590;
					continue;
				case 371u:
					RegisterDonor.smethod_20((Control)(object)MobileTxt, new Size(232, 26));
					num = (int)(num2 * 152500185) ^ -1742229033;
					continue;
				case 370u:
					RegisterDonor.smethod_28((ButtonBase)(object)CheckBox8, "Typhoid");
					num = (int)((num2 * 1883637680) ^ 0x672495F0);
					continue;
				case 369u:
					RegisterDonor.smethod_17((Control)(object)CheckBox6, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1136493998) ^ 0x5F89DCA1);
					continue;
				case 368u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox1), (Control)(object)CheckBox4);
					num = ((int)num2 * -565352317) ^ 0x6C3B54BA;
					continue;
				case 367u:
					RegisterDonor.smethod_18((Control)(object)AgeTxt, new Point(127, 128));
					num = ((int)num2 * -1892773709) ^ -423918665;
					continue;
				case 366u:
					num = ((int)num2 * -256253824) ^ 0x4FCF9BFC;
					continue;
				case 365u:
					SuccessMsg = RegisterDonor.smethod_5();
					num = (int)((num2 * 868243750) ^ 0x1CABBAFA);
					continue;
				case 364u:
					RegisterDonor.smethod_23(BloodGrpLbl, (ContentAlignment)32);
					num = (int)((num2 * 1327503945) ^ 0x24631033);
					continue;
				case 363u:
					CheckBox2 = RegisterDonor.smethod_8();
					num = (int)((num2 * 1895753196) ^ 0x3BC86F3A);
					continue;
				case 362u:
					RegisterDonor.smethod_18((Control)(object)CheckBox4, new Point(34, 237));
					RegisterDonor.smethod_19((Control)(object)CheckBox4, "CheckBox4");
					num = ((int)num2 * -165420414) ^ 0x44DCF4B2;
					continue;
				case 361u:
					RegisterDonor.smethod_21((Control)(object)BloodGrpTxt, 20);
					num = (int)(num2 * 66465525) ^ -1385904003;
					continue;
				case 360u:
					num = (int)(num2 * 1881804229) ^ -1969192561;
					continue;
				case 359u:
					num = ((int)num2 * -128774333) ^ 0x7C89B44F;
					continue;
				case 358u:
					RegisterDonor.smethod_21((Control)(object)CheckBox7, 6);
					num = ((int)num2 * -1140407097) ^ -1659524457;
					continue;
				case 357u:
					RegisterDonor.smethod_22(GenderLbl, "Gender :");
					RegisterDonor.smethod_23(GenderLbl, (ContentAlignment)32);
					num = ((int)num2 * -512820557) ^ 0x76D3BBE;
					continue;
				case 356u:
					RegisterDonor.smethod_52((Control)(object)GroupBox2);
					num = (int)(num2 * 2047584515) ^ -483484079;
					continue;
				case 355u:
					RegisterDonor.smethod_21((Control)(object)Label1, 16);
					num = ((int)num2 * -1098752350) ^ 0x61899BB2;
					continue;
				case 354u:
					RegisterDonor.smethod_19((Control)(object)GroupBox2, "GroupBox2");
					num = (int)(num2 * 1562084244) ^ -1801089580;
					continue;
				case 353u:
					RegisterDonor.smethod_36(AgeLbl, bool_0: true);
					num = ((int)num2 * -406015772) ^ -789314909;
					continue;
				case 352u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)BloodGrpLbl);
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)GenderTxt);
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)AgeLbl);
					num = ((int)num2 * -161595690) ^ 0x779DE542;
					continue;
				case 351u:
					RegisterDonor.smethod_20((Control)(object)CheckBox6, new Size(93, 23));
					num = (int)((num2 * 413738919) ^ 0x772B63C7);
					continue;
				case 350u:
					RegisterDonor.smethod_34((ButtonBase)(object)CheckBox3, bool_0: true);
					RegisterDonor.smethod_17((Control)(object)CheckBox3, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 2006788886) ^ 0x7927CBBC);
					continue;
				case 349u:
					Label1 = RegisterDonor.smethod_5();
					num = ((int)num2 * -1563859610) ^ 0x6EF586E4;
					continue;
				case 348u:
					num = ((int)num2 * -1535543957) ^ 0xB8906DC;
					continue;
				case 347u:
					RegisterDonor.smethod_22(Label4, "(In litres)");
					num = (int)((num2 * 1479818422) ^ 0x369A6140);
					continue;
				case 346u:
					RegisterDonor.smethod_24((Control)(object)Label4, bool_0: false);
					num = ((int)num2 * -642953690) ^ 0x556272CC;
					continue;
				case 345u:
					RegisterDonor.smethod_47((Control)(object)this, Color.White);
					RegisterDonor.smethod_31(RegisterDonor.smethod_48((Control)(object)this), (Control)(object)SuccessMsg);
					RegisterDonor.smethod_31(RegisterDonor.smethod_48((Control)(object)this), (Control)(object)ClearBtn);
					num = ((int)num2 * -1136770762) ^ 0x39A30896;
					continue;
				case 344u:
					RegisterDonor.smethod_19((Control)(object)Label3, "Label3");
					num = ((int)num2 * -1686014155) ^ -607199677;
					continue;
				case 343u:
					RegisterDonor.smethod_18((Control)(object)AddBtn, new Point(760, 704));
					num = ((int)num2 * -1125225418) ^ 0x621FC892;
					continue;
				case 342u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox1), (Control)(object)CheckBox5);
					num = (int)(num2 * 403600486) ^ -1786988914;
					continue;
				case 341u:
					RegisterDonor.smethod_20((Control)(object)GenderTxt, new Size(124, 27));
					num = ((int)num2 * -871930493) ^ 0x36818E7;
					continue;
				case 340u:
					RegisterDonor.smethod_17((Control)(object)NameTxt, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -901014281) ^ -460959448;
					continue;
				case 339u:
					RegisterDonor.smethod_33(GroupBox2, "Donor Information");
					num = (int)(num2 * 1037787973) ^ -976836472;
					continue;
				case 338u:
					RegisterDonor.smethod_29((ButtonBase)(object)CheckBox6, bool_0: true);
					num = (int)(num2 * 185141211) ^ -803226215;
					continue;
				case 337u:
					RegisterDonor.smethod_20((Control)(object)NameLbl, new Size(71, 19));
					num = ((int)num2 * -209730123) ^ 0x4A5DEA87;
					continue;
				case 336u:
					RegisterDonor.smethod_20((Control)(object)PictureBox1, new Size(230, 123));
					RegisterDonor.smethod_42(PictureBox1, (PictureBoxSizeMode)1);
					num = ((int)num2 * -589255004) ^ 0x1D2BD5D1;
					continue;
				case 335u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox1), (Control)(object)CheckBox1);
					num = ((int)num2 * -1198573750) ^ -876521216;
					continue;
				case 334u:
					RegisterDonor.smethod_36(BloodGrpLbl, bool_0: true);
					RegisterDonor.smethod_17((Control)(object)BloodGrpLbl, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1823810335) ^ 0x3C67252A;
					continue;
				case 333u:
					num = ((int)num2 * -501128671) ^ 0x65BC751A;
					continue;
				case 332u:
					num = ((int)num2 * -1030406224) ^ 0x2B37D066;
					continue;
				case 331u:
					num = (int)((num2 * 1016418722) ^ 0x36F20B0C);
					continue;
				case 330u:
					num = ((int)num2 * -548885371) ^ -1867644279;
					continue;
				case 329u:
					RegisterDonor.smethod_22(BloodGrpLbl, "Blood Group :");
					num = (int)(num2 * 2126889351) ^ -1501428067;
					continue;
				case 328u:
					num = ((int)num2 * -555432282) ^ 0x1F132E9C;
					continue;
				case 327u:
					num = (int)(num2 * 105712538) ^ -900885992;
					continue;
				case 326u:
					RegisterDonor.smethod_34((ButtonBase)(object)CheckBox1, bool_0: true);
					RegisterDonor.smethod_17((Control)(object)CheckBox1, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					RegisterDonor.smethod_18((Control)(object)CheckBox1, new Point(34, 86));
					num = (int)((num2 * 1951224246) ^ 0x1112948);
					continue;
				case 325u:
					RegisterDonor.smethod_21((Control)(object)CheckBox4, 3);
					num = (int)((num2 * 1832984102) ^ 0x71F5E714);
					continue;
				case 324u:
					num = (int)(num2 * 253222524) ^ -582393292;
					continue;
				case 323u:
					RegisterDonor.smethod_17((Control)(object)CheckBox8, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 800719473) ^ -1502896208;
					continue;
				case 322u:
					RegisterDonor.smethod_17((Control)(object)ClearBtn, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 569582084) ^ -1730332134;
					continue;
				case 321u:
					num = (int)(num2 * 225584825) ^ -871356672;
					continue;
				case 320u:
					RegisterDonor.smethod_20((Control)(object)SuccessMsg, new Size(401, 44));
					num = (int)((num2 * 279952813) ^ 0x62E397DE);
					continue;
				case 319u:
					num = ((int)num2 * -158796174) ^ 0x5037A1C3;
					continue;
				case 318u:
					RegisterDonor.smethod_17((Control)(object)GroupBox2, RegisterDonor.smethod_26("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 206293517) ^ -674296194;
					continue;
				case 317u:
					RegisterDonor.smethod_40(RegisterDonor.smethod_39(BloodGrpTxt), new object[9] { "--Select--", "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
					num = (int)(num2 * 1266461010) ^ -1706141473;
					continue;
				case 316u:
					RegisterDonor.smethod_13((ISupportInitialize)PictureBox1);
					num = (int)((num2 * 1760913455) ^ 0x51E38356);
					continue;
				case 315u:
					RegisterDonor.smethod_21((Control)(object)CheckBox2, 1);
					RegisterDonor.smethod_28((ButtonBase)(object)CheckBox2, "Hepatitus C");
					num = ((int)num2 * -528129526) ^ -6738935;
					continue;
				case 314u:
					Label3 = RegisterDonor.smethod_5();
					CheckBox8 = RegisterDonor.smethod_8();
					num = ((int)num2 * -411129675) ^ -1381808834;
					continue;
				case 313u:
					num = ((int)num2 * -582675443) ^ 0x2D02B283;
					continue;
				case 312u:
					num = ((int)num2 * -292149154) ^ -2019010887;
					continue;
				case 311u:
					RegisterDonor.smethod_19((Control)(object)GenderLbl, "GenderLbl");
					RegisterDonor.smethod_20((Control)(object)GenderLbl, new Size(83, 19));
					num = ((int)num2 * -1344698005) ^ -202693787;
					continue;
				case 310u:
					CheckBox5 = RegisterDonor.smethod_8();
					CheckBox4 = RegisterDonor.smethod_8();
					num = ((int)num2 * -1117798459) ^ -1830272161;
					continue;
				case 309u:
					num = (int)(num2 * 1958457325) ^ -520389665;
					continue;
				case 308u:
					num = ((int)num2 * -1778685658) ^ 0x7C4044CF;
					continue;
				case 307u:
					GroupBox1 = RegisterDonor.smethod_7();
					num = ((int)num2 * -969575480) ^ -234186534;
					continue;
				case 306u:
					num = (int)((num2 * 804814218) ^ 0x4976366C);
					continue;
				case 305u:
					num = (int)((num2 * 2140319104) ^ 0x26C1E599);
					continue;
				case 304u:
					RegisterDonor.smethod_18((Control)(object)GroupBox2, new Point(68, 234));
					num = (int)((num2 * 1177876673) ^ 0x7A938D74);
					continue;
				case 303u:
					num = ((int)num2 * -1686256035) ^ 0x4AD3B97E;
					continue;
				case 302u:
					num = (int)(num2 * 1521241664) ^ -1183033695;
					continue;
				case 301u:
					RegisterDonor.smethod_34((ButtonBase)(object)CheckBox6, bool_0: true);
					num = ((int)num2 * -1979669224) ^ -886010477;
					continue;
				case 300u:
					num = (int)(num2 * 1775617785) ^ -2086243581;
					continue;
				case 299u:
					RegisterDonor.smethod_19((Control)(object)Label7, "Label7");
					num = (int)((num2 * 1370802878) ^ 0x19C2BE47);
					continue;
				case 298u:
					num = (int)(num2 * 629845722) ^ -13892824;
					continue;
				case 297u:
					RegisterDonor.smethod_28((ButtonBase)(object)CheckBox4, "HTLV I");
					num = (int)((num2 * 2119148466) ^ 0x55D3B758);
					continue;
				case 296u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)DateTxt);
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)Label2);
					num = ((int)num2 * -394579510) ^ -638360450;
					continue;
				case 295u:
					RegisterDonor.smethod_18((Control)(object)MobileTxt, new Point(147, 178));
					num = ((int)num2 * -1337135943) ^ 0x57A0E8BE;
					continue;
				case 294u:
					RegisterDonor.smethod_21((Control)(object)CheckBox6, 5);
					num = (int)((num2 * 534361403) ^ 0x3D93A539);
					continue;
				case 293u:
					RegisterDonor.smethod_20((Control)(object)CheckBox4, new Size(85, 23));
					num = ((int)num2 * -2002870341) ^ -494912628;
					continue;
				case 292u:
					RegisterDonor.smethod_23(Label2, (ContentAlignment)32);
					RegisterDonor.smethod_17((Control)(object)QuantityTxt, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1004730162) ^ 0x7A526264;
					continue;
				case 291u:
					num = (int)(num2 * 39524347) ^ -1301192944;
					continue;
				case 290u:
					num = ((int)num2 * -1266351644) ^ -2106776195;
					continue;
				case 289u:
					RegisterDonor.smethod_12((Control)(object)GroupBox1);
					num = ((int)num2 * -1388910001) ^ -794415485;
					continue;
				case 288u:
					RegisterDonor.smethod_18((Control)(object)GenderLbl, new Point(25, 229));
					num = (int)(num2 * 703466294) ^ -806083217;
					continue;
				case 287u:
					RegisterDonor.smethod_21((Control)(object)AgeLbl, 13);
					num = ((int)num2 * -808251840) ^ 0x500A2D1A;
					continue;
				case 286u:
					RegisterDonor.smethod_17((Control)(object)MobileTxt, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1473792600) ^ -552976523;
					continue;
				case 285u:
					RegisterDonor.smethod_17((Control)(object)GenderTxt, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					RegisterDonor.smethod_38((ListControl)(object)GenderTxt, bool_0: true);
					num = (int)(num2 * 264606395) ^ -1410252056;
					continue;
				case 284u:
					num = ((int)num2 * -956447490) ^ 0x6CD3A870;
					continue;
				case 283u:
					num = ((int)num2 * -1698475883) ^ -807745200;
					continue;
				case 282u:
					RegisterDonor.smethod_27((Control)(object)WarningLbl, Color.Red);
					num = (int)((num2 * 1744767001) ^ 0x3EEFDB60);
					continue;
				case 281u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox1), (Control)(object)CheckBox8);
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox1), (Control)(object)CheckBox7);
					num = (int)((num2 * 1597302929) ^ 0x4941F0A);
					continue;
				case 280u:
					num = (int)((num2 * 1375563488) ^ 0x7793F444);
					continue;
				case 279u:
					RegisterDonor.smethod_21((Control)(object)WarningLbl, 21);
					num = ((int)num2 * -2143651310) ^ -1281199540;
					continue;
				case 278u:
					num = (int)((num2 * 124367692) ^ 0xE7AA569);
					continue;
				case 277u:
					RegisterDonor.smethod_34((ButtonBase)(object)CheckBox5, bool_0: true);
					num = (int)((num2 * 825241938) ^ 0xC982138);
					continue;
				case 276u:
					RegisterDonor.smethod_21((Control)(object)GroupBox1, 18);
					num = ((int)num2 * -1576056387) ^ -210813279;
					continue;
				case 275u:
					num = ((int)num2 * -1109554642) ^ 0x40371AC7;
					continue;
				case 274u:
					num = ((int)num2 * -963044621) ^ -2138073199;
					continue;
				case 273u:
					RegisterDonor.smethod_35((TextBoxBase)(object)DateTxt, bool_0: true);
					num = (int)(num2 * 1359688048) ^ -781025822;
					continue;
				case 272u:
					RegisterDonor.smethod_21((Control)(object)MobileLbl, 8);
					num = (int)(num2 * 1104926298) ^ -374405627;
					continue;
				case 271u:
					num = (int)((num2 * 514645551) ^ 0x649646C7);
					continue;
				case 270u:
					RegisterDonor.smethod_22(Label1, "Register Donor");
					num = (int)(num2 * 236755475) ^ -1857536239;
					continue;
				case 269u:
					RegisterDonor.smethod_19((Control)(object)GenderTxt, "GenderTxt");
					num = (int)(num2 * 1874931500) ^ -711337455;
					continue;
				case 268u:
					RegisterDonor.smethod_20((Control)(object)DateTxt, new Size(167, 26));
					num = (int)((num2 * 474687632) ^ 0x7314AAA5);
					continue;
				case 267u:
					RegisterDonor.smethod_23(Label3, (ContentAlignment)32);
					num = ((int)num2 * -2069539016) ^ -283484156;
					continue;
				case 266u:
					RegisterDonor.smethod_28((ButtonBase)(object)CheckBox6, "Syphilis");
					num = (int)(num2 * 216701416) ^ -235310773;
					continue;
				case 265u:
					num = ((int)num2 * -1663858893) ^ -1237780584;
					continue;
				case 264u:
					num = ((int)num2 * -1753410617) ^ -49095220;
					continue;
				case 263u:
					RegisterDonor.smethod_29((ButtonBase)(object)CheckBox3, bool_0: true);
					num = (int)(num2 * 1366438569) ^ -1401832766;
					continue;
				case 262u:
					RegisterDonor.smethod_19((Control)(object)CheckBox5, "CheckBox5");
					num = ((int)num2 * -1275502320) ^ -1509000101;
					continue;
				case 261u:
					RegisterDonor.smethod_22(AgeLbl, "Age :");
					RegisterDonor.smethod_23(AgeLbl, (ContentAlignment)32);
					num = (int)((num2 * 944674237) ^ 0x45EC6F10);
					continue;
				case 260u:
					RegisterDonor.smethod_33(GroupBox1, "Parameter Check");
					RegisterDonor.smethod_17((Control)(object)Label3, RegisterDonor.smethod_26("Microsoft Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1091721751) ^ 0x78B282B0);
					continue;
				case 259u:
					RegisterDonor.smethod_37(BloodGrpTxt, (ComboBoxStyle)2);
					RegisterDonor.smethod_17((Control)(object)BloodGrpTxt, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -30781812) ^ 0x2649180D;
					continue;
				case 258u:
					num = (int)((num2 * 1194390360) ^ 0x13ECA599);
					continue;
				case 257u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_48((Control)(object)this), (Control)(object)PictureBox1);
					num = ((int)num2 * -857865287) ^ 0x88998D0;
					continue;
				case 256u:
					RegisterDonor.smethod_27((Control)(object)Label4, Color.Red);
					num = (int)((num2 * 1012867870) ^ 0x1B78795D);
					continue;
				case 255u:
					RegisterDonor.smethod_20((Control)(object)AddBtn, new Size(148, 51));
					num = ((int)num2 * -2082850451) ^ -963249687;
					continue;
				case 254u:
					num = (int)(num2 * 1171882744) ^ -1448630739;
					continue;
				case 253u:
					num = (int)((num2 * 1910795527) ^ 0x49973B02);
					continue;
				case 252u:
					RegisterDonor.smethod_20((Control)(object)GroupBox2, new Size(520, 444));
					num = (int)(num2 * 176447853) ^ -206111538;
					continue;
				case 251u:
					RegisterDonor.smethod_21((Control)(object)Label3, 23);
					RegisterDonor.smethod_22(Label3, "Diseases Not Present");
					num = (int)((num2 * 1132798845) ^ 0x4AFA8B0);
					continue;
				case 250u:
					RegisterDonor.smethod_19((Control)(object)CheckBox7, "CheckBox7");
					RegisterDonor.smethod_20((Control)(object)CheckBox7, new Size(116, 23));
					num = (int)((num2 * 1813954184) ^ 0x431BFEC4);
					continue;
				case 249u:
					RegisterDonor.smethod_28((ButtonBase)(object)CheckBox7, "Cholestrol");
					num = ((int)num2 * -2048748694) ^ -561506548;
					continue;
				case 248u:
					RegisterDonor.smethod_21((Control)(object)CheckBox1, 0);
					num = (int)(num2 * 1611734698) ^ -123223837;
					continue;
				case 247u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_48((Control)(object)this), (Control)(object)GroupBox1);
					num = ((int)num2 * -1797418549) ^ -1993699856;
					continue;
				case 246u:
					RegisterDonor.smethod_25((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					num = ((int)num2 * -2145174487) ^ 0x5AE5D437;
					continue;
				case 245u:
					num = (int)(num2 * 1858266070) ^ -168795234;
					continue;
				case 244u:
					RegisterDonor.smethod_18((Control)(object)CheckBox7, new Point(34, 387));
					num = ((int)num2 * -2125825301) ^ 0xEA31814;
					continue;
				case 243u:
					RegisterDonor.smethod_46((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -248110211) ^ -2009845257;
					continue;
				case 242u:
					RegisterDonor.smethod_54((Control)(object)this, bool_0: false);
					num = ((int)num2 * -267239534) ^ -1976721827;
					continue;
				case 241u:
					QuantityTxt = RegisterDonor.smethod_9();
					Label7 = RegisterDonor.smethod_5();
					num = (int)(num2 * 2031667144) ^ -242234762;
					continue;
				case 240u:
					num = (int)((num2 * 1839959566) ^ 0x75E54EB7);
					continue;
				case 239u:
					RegisterDonor.smethod_20((Control)(object)CheckBox5, new Size(91, 23));
					RegisterDonor.smethod_21((Control)(object)CheckBox5, 4);
					num = ((int)num2 * -53417241) ^ 0x17ABBDD9;
					continue;
				case 238u:
					RegisterDonor.smethod_19((Control)(object)AgeLbl, "AgeLbl");
					RegisterDonor.smethod_20((Control)(object)AgeLbl, new Size(54, 19));
					num = ((int)num2 * -850458474) ^ -337625774;
					continue;
				case 237u:
					AgeTxt = RegisterDonor.smethod_9();
					num = ((int)num2 * -1497240922) ^ -1883972827;
					continue;
				case 236u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)NameLbl);
					num = ((int)num2 * -1709063249) ^ 0xEF5E733;
					continue;
				case 235u:
					RegisterDonor.smethod_20((Control)(object)BloodGrpTxt, new Size(113, 27));
					num = ((int)num2 * -1586587995) ^ -119503386;
					continue;
				case 234u:
					num = ((int)num2 * -1493563533) ^ -1695160895;
					continue;
				case 233u:
					num = (int)(num2 * 1618293108) ^ -411723324;
					continue;
				case 232u:
					RegisterDonor.smethod_22(MobileLbl, "Mobile :");
					num = ((int)num2 * -102113200) ^ -1869134935;
					continue;
				case 231u:
					MobileLbl = RegisterDonor.smethod_5();
					num = ((int)num2 * -338668402) ^ -332459165;
					continue;
				case 230u:
					num = (int)(num2 * 46063992) ^ -908506889;
					continue;
				case 229u:
					num = ((int)num2 * -1302891964) ^ -765153916;
					continue;
				case 228u:
					num = (int)(num2 * 1052814287) ^ -1048850206;
					continue;
				case 227u:
					RegisterDonor.smethod_19((Control)(object)MobileTxt, "MobileTxt");
					num = ((int)num2 * -913871228) ^ 0x3DDF5131;
					continue;
				case 226u:
					RegisterDonor.smethod_18((Control)(object)AgeLbl, new Point(25, 131));
					num = (int)((num2 * 679848284) ^ 0x29B41CE2);
					continue;
				case 225u:
					num = ((int)num2 * -1410031783) ^ -1816726008;
					continue;
				case 224u:
					num = ((int)num2 * -699150061) ^ -514445461;
					continue;
				case 223u:
					RegisterDonor.smethod_29((ButtonBase)(object)CheckBox7, bool_0: true);
					num = (int)((num2 * 425972253) ^ 0x12761AB3);
					continue;
				case 222u:
					num = ((int)num2 * -1747184214) ^ -994177539;
					continue;
				case 221u:
					num = ((int)num2 * -1363307294) ^ -1802345335;
					continue;
				case 220u:
					RegisterDonor.smethod_22(WarningLbl, "(18-55 years)");
					num = ((int)num2 * -1133515957) ^ 0x1E5BC4;
					continue;
				case 219u:
					RegisterDonor.smethod_21((Control)(object)Label4, 26);
					num = (int)(num2 * 1359101239) ^ -365824814;
					continue;
				case 218u:
					num = ((int)num2 * -1728660847) ^ -1355674323;
					continue;
				case 217u:
					num = (int)(num2 * 406497906) ^ -393546816;
					continue;
				case 216u:
					RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: false);
					num = (int)((num2 * 2041831000) ^ 0x2016588);
					continue;
				case 215u:
					num = (int)(num2 * 1137746772) ^ -1374901715;
					continue;
				case 214u:
					components = RegisterDonor.smethod_3();
					Timer1 = RegisterDonor.smethod_4(components);
					num = (int)((num2 * 1740166477) ^ 0x6CB62D9B);
					continue;
				case 213u:
					RegisterDonor.smethod_18((Control)(object)QuantityTxt, new Point(250, 324));
					num = ((int)num2 * -1457688217) ^ 0x78B7D74F;
					continue;
				case 212u:
					RegisterDonor.smethod_36(Label4, bool_0: true);
					RegisterDonor.smethod_17((Control)(object)Label4, RegisterDonor.smethod_26("MS Reference Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -643771232) ^ 0x548164A7;
					continue;
				case 211u:
					num = ((int)num2 * -557634184) ^ -34805643;
					continue;
				case 210u:
					DateTxt = RegisterDonor.smethod_9();
					num = ((int)num2 * -1919203337) ^ 0x4C3E0E68;
					continue;
				case 209u:
					num = ((int)num2 * -1855474070) ^ -2081659625;
					continue;
				case 208u:
					num = ((int)num2 * -1673288394) ^ -2133692264;
					continue;
				case 207u:
					RegisterDonor.smethod_22(SuccessMsg, "Name :");
					num = (int)(num2 * 970317945) ^ -1821571014;
					continue;
				case 206u:
					RegisterDonor.smethod_28((ButtonBase)(object)CheckBox5, "HTLV II");
					RegisterDonor.smethod_29((ButtonBase)(object)CheckBox5, bool_0: true);
					num = ((int)num2 * -616716496) ^ 0x1925C36C;
					continue;
				case 205u:
					RegisterDonor.smethod_17((Control)(object)AgeTxt, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1485168079) ^ -755855980;
					continue;
				case 204u:
					num = (int)(num2 * 656032777) ^ -1682829924;
					continue;
				case 203u:
					RegisterDonor.smethod_23(Label7, (ContentAlignment)32);
					num = (int)((num2 * 278246104) ^ 0x34EEE829);
					continue;
				case 202u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)BloodGrpTxt);
					num = (int)(num2 * 641580278) ^ -713814799;
					continue;
				case 201u:
					num = (int)(num2 * 1235479621) ^ -1218429707;
					continue;
				case 200u:
					RegisterDonor.smethod_19((Control)(object)AgeTxt, "AgeTxt");
					num = ((int)num2 * -13159353) ^ 0x34EB5112;
					continue;
				case 199u:
					num = ((int)num2 * -2006415216) ^ -2139690081;
					continue;
				case 198u:
					num = (int)((num2 * 1164853821) ^ 0x4D8323D7);
					continue;
				case 197u:
					num = (int)((num2 * 1761428482) ^ 0x626F9079);
					continue;
				case 196u:
					num = ((int)num2 * -1240195866) ^ 0x5E2F822F;
					continue;
				case 195u:
					num = (int)(num2 * 82528624) ^ -2138438415;
					continue;
				case 194u:
					RegisterDonor.smethod_20((Control)(object)CheckBox3, new Size(60, 23));
					num = (int)((num2 * 1489941577) ^ 0x22C0DE0);
					continue;
				case 193u:
					RegisterDonor.smethod_29((ButtonBase)(object)AddBtn, bool_0: false);
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox1), (Control)(object)Label3);
					num = ((int)num2 * -608960506) ^ -2092286781;
					continue;
				case 192u:
					num = (int)(num2 * 845361585) ^ -528763918;
					continue;
				case 191u:
					RegisterDonor.smethod_51((Control)(object)GroupBox2, bool_0: false);
					num = ((int)num2 * -857265050) ^ -1764515689;
					continue;
				case 190u:
					num = ((int)num2 * -1559523217) ^ 0x2919E85;
					continue;
				case 189u:
					num = (int)(num2 * 507974385) ^ -931409740;
					continue;
				case 188u:
					RegisterDonor.smethod_17((Control)(object)SuccessMsg, RegisterDonor.smethod_16("MS Reference Sans Serif", 10.8f, (FontStyle)1));
					num = (int)(num2 * 6348077) ^ -893732448;
					continue;
				case 187u:
					RegisterDonor.smethod_49((Control)(object)this, "RegisterDonor");
					num = ((int)num2 * -3935563) ^ -1943910425;
					continue;
				case 186u:
					RegisterDonor.smethod_21((Control)(object)CheckBox8, 7);
					num = (int)((num2 * 818159081) ^ 0x1AD985B5);
					continue;
				case 185u:
					RegisterDonor.smethod_27((Control)(object)AddBtn, Color.White);
					num = ((int)num2 * -2131871963) ^ -626332730;
					continue;
				case 184u:
					num = (int)((num2 * 1071961105) ^ 0x5E64C30B);
					continue;
				case 183u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox1), (Control)(object)CheckBox3);
					num = (int)((num2 * 130608002) ^ 0x6B4C6212);
					continue;
				case 182u:
					RegisterDonor.smethod_17((Control)(object)CheckBox5, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 777063570) ^ -1470073156;
					continue;
				case 181u:
					RegisterDonor.smethod_20((Control)(object)CheckBox8, new Size(96, 23));
					num = ((int)num2 * -2070120739) ^ 0x6590455B;
					continue;
				case 180u:
					num = ((int)num2 * -154420099) ^ 0x52384F69;
					continue;
				case 179u:
					RegisterDonor.smethod_29((ButtonBase)(object)CheckBox4, bool_0: true);
					num = ((int)num2 * -459600030) ^ 0x5FD17248;
					continue;
				case 178u:
					RegisterDonor.smethod_18((Control)(object)DateTxt, new Point(121, 374));
					num = (int)((num2 * 678800077) ^ 0xA01BBDE);
					continue;
				case 177u:
					num = ((int)num2 * -1175437672) ^ 0xE53A5BC;
					continue;
				case 176u:
					RegisterDonor.smethod_20((Control)(object)WarningLbl, new Size(107, 17));
					num = ((int)num2 * -301697643) ^ 0x7E2C875B;
					continue;
				case 175u:
					num = ((int)num2 * -1612989212) ^ -515298401;
					continue;
				case 174u:
					num = ((int)num2 * -1052930818) ^ 0x546F432C;
					continue;
				case 173u:
					num = (int)((num2 * 481702261) ^ 0x56AA9489);
					continue;
				case 172u:
					num = ((int)num2 * -1606471950) ^ -96865576;
					continue;
				case 171u:
					RegisterDonor.smethod_20((Control)(object)Label7, new Size(164, 19));
					num = ((int)num2 * -184962332) ^ -422706530;
					continue;
				case 170u:
					num = ((int)num2 * -45701980) ^ -803329585;
					continue;
				case 169u:
					RegisterDonor.smethod_25((ButtonBase)(object)AddBtn, Color.MidnightBlue);
					num = (int)((num2 * 1418911672) ^ 0x291B2560);
					continue;
				case 168u:
					num = ((int)num2 * -653557200) ^ 0x4D021B20;
					continue;
				case 167u:
					RegisterDonor.smethod_23(Label1, (ContentAlignment)32);
					RegisterDonor.smethod_41(PictureBox1, (Image)(object)Resources.images1232);
					num = (int)((num2 * 256042958) ^ 0x33179A2F);
					continue;
				case 166u:
					RegisterDonor.smethod_21((Control)(object)GenderLbl, 6);
					num = (int)((num2 * 673224798) ^ 0x2BEE9892);
					continue;
				case 165u:
					num = (int)(num2 * 825332207) ^ -1965294063;
					continue;
				case 164u:
					num = (int)(num2 * 1879953887) ^ -226097289;
					continue;
				case 163u:
					CheckBox3 = RegisterDonor.smethod_8();
					num = ((int)num2 * -1277091922) ^ 0x5666D83B;
					continue;
				case 162u:
					CheckBox6 = RegisterDonor.smethod_8();
					num = (int)((num2 * 1570602352) ^ 0x69F8DCB0);
					continue;
				case 161u:
					num = ((int)num2 * -1269717881) ^ 0x1A5AF160;
					continue;
				case 160u:
					RegisterDonor.smethod_20((Control)(object)AgeTxt, new Size(124, 26));
					num = (int)((num2 * 766946145) ^ 0x23090EAE);
					continue;
				case 159u:
					num = (int)(num2 * 347583381) ^ -580125319;
					continue;
				case 158u:
					RegisterDonor.smethod_17((Control)(object)NameLbl, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					RegisterDonor.smethod_18((Control)(object)NameLbl, new Point(25, 76));
					num = ((int)num2 * -1439806991) ^ 0xB7A6721;
					continue;
				case 157u:
					num = (int)(num2 * 1673838787) ^ -2009454620;
					continue;
				case 156u:
					Label2 = RegisterDonor.smethod_5();
					num = ((int)num2 * -1740611735) ^ 0x20E8E3C6;
					continue;
				case 155u:
					RegisterDonor.smethod_38((ListControl)(object)BloodGrpTxt, bool_0: true);
					num = (int)(num2 * 1840883824) ^ -1690316361;
					continue;
				case 154u:
					RegisterDonor.smethod_18((Control)(object)CheckBox8, new Point(34, 434));
					num = ((int)num2 * -406794797) ^ 0x1EF49B02;
					continue;
				case 153u:
					RegisterDonor.smethod_21((Control)(object)CheckBox3, 2);
					num = ((int)num2 * -253067745) ^ -1498480438;
					continue;
				case 152u:
					PictureBox1 = RegisterDonor.smethod_11();
					num = ((int)num2 * -154751016) ^ -1932005802;
					continue;
				case 151u:
					num = (int)((num2 * 1164353144) ^ 0x2CF8E325);
					continue;
				case 150u:
					num = ((int)num2 * -1422878129) ^ -2111276790;
					continue;
				case 149u:
					num = ((int)num2 * -1755235655) ^ -1848388161;
					continue;
				case 148u:
					RegisterDonor.smethod_21((Control)(object)Label7, 22);
					num = ((int)num2 * -2061242722) ^ 0x83DDD6;
					continue;
				case 147u:
					num = (int)(num2 * 2086791052) ^ -1483106410;
					continue;
				case 146u:
					RegisterDonor.smethod_21((Control)(object)GroupBox2, 17);
					num = ((int)num2 * -1750431088) ^ -1947283019;
					continue;
				case 145u:
					RegisterDonor.smethod_55((Control)(object)this);
					num = (int)((num2 * 486473037) ^ 0x46D4632F);
					continue;
				case 144u:
					RegisterDonor.smethod_21((Control)(object)MobileTxt, 2);
					num = ((int)num2 * -761095125) ^ -1840682798;
					continue;
				case 143u:
					RegisterDonor.smethod_18((Control)(object)Label4, new Point(357, 328));
					num = (int)((num2 * 1408886020) ^ 0x5EB403C2);
					continue;
				case 142u:
					RegisterDonor.smethod_17((Control)(object)AddBtn, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1588813731) ^ -1072731772;
					continue;
				case 141u:
					RegisterDonor.smethod_20((Control)(object)MobileLbl, new Size(76, 19));
					num = (int)((num2 * 715418886) ^ 0x52C19AF5);
					continue;
				case 140u:
					RegisterDonor.smethod_22(Label7, "Amount Donated: ");
					num = (int)(num2 * 1410654703) ^ -646166541;
					continue;
				case 139u:
					RegisterDonor.smethod_27((Control)(object)Label3, Color.Red);
					num = ((int)num2 * -904049706) ^ -734806093;
					continue;
				case 138u:
					RegisterDonor.smethod_21((Control)(object)ClearBtn, 20);
					num = (int)((num2 * 2026327102) ^ 0x772A3D8F);
					continue;
				case 137u:
					RegisterDonor.smethod_19((Control)(object)Label1, "Label1");
					num = ((int)num2 * -630296585) ^ -892527193;
					continue;
				case 136u:
					num = (int)((num2 * 1537251525) ^ 0x3CB3C965);
					continue;
				case 135u:
					RegisterDonor.smethod_18((Control)(object)CheckBox2, new Point(34, 137));
					RegisterDonor.smethod_19((Control)(object)CheckBox2, "CheckBox2");
					num = (int)((num2 * 30178174) ^ 0x75E86576);
					continue;
				case 134u:
					RegisterDonor.smethod_20((Control)(object)CheckBox1, new Size(127, 23));
					num = (int)(num2 * 850821618) ^ -1270517224;
					continue;
				case 133u:
					RegisterDonor.smethod_18((Control)(object)WarningLbl, new Point(272, 133));
					RegisterDonor.smethod_19((Control)(object)WarningLbl, "WarningLbl");
					num = (int)(num2 * 402217766) ^ -1907713220;
					continue;
				case 132u:
					num = ((int)num2 * -1769369196) ^ -879454990;
					continue;
				case 131u:
					RegisterDonor.smethod_19((Control)(object)DateTxt, "DateTxt");
					num = ((int)num2 * -612390745) ^ -971372542;
					continue;
				case 130u:
					num = ((int)num2 * -994218852) ^ 0x72C412D0;
					continue;
				case 129u:
					num = ((int)num2 * -829502960) ^ -130898455;
					continue;
				case 128u:
					RegisterDonor.smethod_19((Control)(object)ClearBtn, "ClearBtn");
					RegisterDonor.smethod_20((Control)(object)ClearBtn, new Size(148, 51));
					num = ((int)num2 * -573717175) ^ -1781935972;
					continue;
				case 127u:
					RegisterDonor.smethod_23(MobileLbl, (ContentAlignment)32);
					RegisterDonor.smethod_36(GenderLbl, bool_0: true);
					num = (int)(num2 * 1906562251) ^ -756385153;
					continue;
				case 126u:
					num = (int)(num2 * 777540951) ^ -883618343;
					continue;
				case 125u:
					RegisterDonor.smethod_29((ButtonBase)(object)ClearBtn, bool_0: false);
					num = ((int)num2 * -1306490538) ^ -1847897405;
					continue;
				case 124u:
					RegisterDonor.smethod_23(Label4, (ContentAlignment)32);
					num = ((int)num2 * -993877869) ^ -320224510;
					continue;
				case 123u:
					num = ((int)num2 * -1703745665) ^ -1985281051;
					continue;
				case 122u:
					RegisterDonor.smethod_19((Control)(object)CheckBox6, "CheckBox6");
					num = (int)((num2 * 1176438519) ^ 0xA799A5F);
					continue;
				case 121u:
					RegisterDonor.smethod_17((Control)(object)DateTxt, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -2014199764) ^ -442141168;
					continue;
				case 120u:
					RegisterDonor.smethod_23(WarningLbl, (ContentAlignment)32);
					num = (int)(num2 * 470458657) ^ -1098930013;
					continue;
				case 119u:
					RegisterDonor.smethod_12((Control)(object)GroupBox2);
					num = (int)((num2 * 636455681) ^ 0x4A7C9BEA);
					continue;
				case 118u:
					RegisterDonor.smethod_17((Control)(object)Label2, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					RegisterDonor.smethod_18((Control)(object)Label2, new Point(25, 377));
					num = (int)((num2 * 1802954057) ^ 0x28B99F6F);
					continue;
				case 117u:
					WarningLbl = RegisterDonor.smethod_5();
					num = ((int)num2 * -2005177746) ^ 0x489E399A;
					continue;
				case 116u:
					AgeLbl = RegisterDonor.smethod_5();
					num = ((int)num2 * -1890677663) ^ 0x24871285;
					continue;
				case 115u:
					num = ((int)num2 * -740791966) ^ 0x29469602;
					continue;
				case 114u:
					num = ((int)num2 * -1718810153) ^ -1274821380;
					continue;
				case 113u:
					RegisterDonor.smethod_21((Control)(object)DateTxt, 25);
					RegisterDonor.smethod_36(Label2, bool_0: true);
					num = (int)((num2 * 6953029) ^ 0x4AB29844);
					continue;
				case 112u:
					RegisterDonor.smethod_50((Control)(object)this, new Size(977, 804));
					num = ((int)num2 * -507239815) ^ -1922278376;
					continue;
				case 111u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_48((Control)(object)this), (Control)(object)AddBtn);
					num = ((int)num2 * -1020015828) ^ -559191191;
					continue;
				case 110u:
					RegisterDonor.smethod_18((Control)(object)NameTxt, new Point(127, 73));
					num = (int)((num2 * 1245768637) ^ 0x469E645D);
					continue;
				case 109u:
					num = ((int)num2 * -695433236) ^ 0x320478A3;
					continue;
				case 108u:
					RegisterDonor.smethod_17((Control)(object)CheckBox2, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1697568480) ^ -1621630589;
					continue;
				case 107u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)MobileLbl);
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)GenderLbl);
					num = (int)(num2 * 414429017) ^ -1669729517;
					continue;
				case 106u:
					RegisterDonor.smethod_29((ButtonBase)(object)CheckBox8, bool_0: true);
					num = (int)((num2 * 1490640241) ^ 0x542016CA);
					continue;
				case 104u:
					RegisterDonor.smethod_19((Control)(object)BloodGrpTxt, "BloodGrpTxt");
					num = ((int)num2 * -1727332610) ^ 0x18E49023;
					continue;
				case 103u:
					RegisterDonor.smethod_29((ButtonBase)(object)CheckBox2, bool_0: true);
					num = ((int)num2 * -1797629438) ^ 0x49DD3C9A;
					continue;
				case 102u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)QuantityTxt);
					num = ((int)num2 * -81970539) ^ 0x6ED51A0C;
					continue;
				case 101u:
					RegisterDonor.smethod_18((Control)(object)CheckBox3, new Point(34, 187));
					num = ((int)num2 * -879380655) ^ 0x56E8C177;
					continue;
				case 100u:
					RegisterDonor.smethod_34((ButtonBase)(object)CheckBox7, bool_0: true);
					num = (int)((num2 * 1836266697) ^ 0x64AE1B3F);
					continue;
				case 99u:
					num = ((int)num2 * -1731073387) ^ -1098764801;
					continue;
				case 98u:
					RegisterDonor.smethod_28((ButtonBase)(object)CheckBox1, "Hepatitus B");
					num = ((int)num2 * -963423956) ^ -331503246;
					continue;
				case 97u:
					RegisterDonor.smethod_22(Label2, "Date :");
					num = (int)((num2 * 1683801405) ^ 0x30880A5B);
					continue;
				case 96u:
					RegisterDonor.smethod_18((Control)(object)GroupBox1, new Point(614, 198));
					RegisterDonor.smethod_19((Control)(object)GroupBox1, "GroupBox1");
					num = (int)(num2 * 831374468) ^ -884489098;
					continue;
				case 95u:
					RegisterDonor.smethod_21((Control)(object)Label2, 24);
					num = ((int)num2 * -1337774420) ^ 0x1CD84E93;
					continue;
				case 94u:
					RegisterDonor.smethod_23(NameLbl, (ContentAlignment)32);
					num = (int)((num2 * 1162903491) ^ 0x4F42F138);
					continue;
				case 93u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox1), (Control)(object)CheckBox2);
					num = ((int)num2 * -1149825001) ^ 0x432CD364;
					continue;
				case 92u:
					RegisterDonor.smethod_19((Control)(object)CheckBox8, "CheckBox8");
					num = ((int)num2 * -1312730492) ^ 0x2F4FB15D;
					continue;
				case 91u:
					num = (int)(num2 * 1577097222) ^ -443907217;
					continue;
				case 90u:
					num = (int)(num2 * 1540281487) ^ -1783241062;
					continue;
				case 89u:
					num = (int)((num2 * 912216394) ^ 0x5B71061);
					continue;
				case 88u:
					ClearBtn = RegisterDonor.smethod_6();
					num = (int)((num2 * 1342778187) ^ 0x76B54FAD);
					continue;
				case 87u:
					num = ((int)num2 * -620117764) ^ -1103294071;
					continue;
				case 86u:
					RegisterDonor.smethod_19((Control)(object)CheckBox3, "CheckBox3");
					num = ((int)num2 * -111954785) ^ 0x741A67B8;
					continue;
				case 85u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox1), (Control)(object)CheckBox6);
					num = (int)((num2 * 1514702086) ^ 0xAC68F5E);
					continue;
				case 84u:
					GroupBox2 = RegisterDonor.smethod_7();
					num = ((int)num2 * -1525307861) ^ -1453541165;
					continue;
				case 83u:
					RegisterDonor.smethod_36(MobileLbl, bool_0: true);
					RegisterDonor.smethod_17((Control)(object)MobileLbl, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1981964587) ^ -1204742597;
					continue;
				case 82u:
					RegisterDonor.smethod_20((Control)(object)GroupBox1, new Size(269, 480));
					num = (int)(num2 * 852954919) ^ -1151427846;
					continue;
				case 81u:
					RegisterDonor.smethod_18((Control)(object)CheckBox6, new Point(34, 333));
					num = (int)((num2 * 839387876) ^ 0x5F1A12EC);
					continue;
				case 80u:
					RegisterDonor.smethod_19((Control)(object)QuantityTxt, "QuantityTxt");
					num = (int)(num2 * 278470356) ^ -2037681864;
					continue;
				case 79u:
					RegisterDonor.smethod_15(Timer1, 1500);
					num = ((int)num2 * -463520982) ^ -1760609452;
					continue;
				case 78u:
					RegisterDonor.smethod_17((Control)(object)Label7, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -557793770) ^ -1494249023;
					continue;
				case 77u:
					num = (int)((num2 * 1268895688) ^ 0x2B492BD3);
					continue;
				case 76u:
					RegisterDonor.smethod_19((Control)(object)BloodGrpLbl, "BloodGrpLbl");
					num = (int)((num2 * 1637882420) ^ 0x39FCA1E7);
					continue;
				case 75u:
					RegisterDonor.smethod_17((Control)(object)CheckBox7, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1640481595) ^ 0x2FABC4F7;
					continue;
				case 74u:
					num = (int)((num2 * 1535876787) ^ 0x74099AFA);
					continue;
				case 73u:
					RegisterDonor.smethod_20((Control)(object)BloodGrpLbl, new Size(127, 19));
					RegisterDonor.smethod_21((Control)(object)BloodGrpLbl, 19);
					num = ((int)num2 * -1942887398) ^ -405919841;
					continue;
				case 72u:
					num = ((int)num2 * -1671047777) ^ -771764487;
					continue;
				case 71u:
					num = ((int)num2 * -433634568) ^ -1322658065;
					continue;
				case 70u:
					num = ((int)num2 * -1932132455) ^ -44823810;
					continue;
				case 69u:
					num = ((int)num2 * -1082450051) ^ -53679977;
					continue;
				case 68u:
					num = (int)((num2 * 1030868536) ^ 0xE36B0D7);
					continue;
				case 67u:
					RegisterDonor.smethod_28((ButtonBase)(object)ClearBtn, "Clear");
					num = ((int)num2 * -260277293) ^ 0x1C7F4966;
					continue;
				case 66u:
					num = ((int)num2 * -1807455772) ^ 0x6C193DDF;
					continue;
				case 65u:
					RegisterDonor.smethod_18((Control)(object)Label1, new Point(392, 60));
					num = ((int)num2 * -1093512333) ^ -983402056;
					continue;
				case 64u:
					num = ((int)num2 * -1356701783) ^ 0x7A9A2ED9;
					continue;
				case 63u:
					RegisterDonor.smethod_28((ButtonBase)(object)AddBtn, "Add Donor");
					num = ((int)num2 * -1739069984) ^ -2079565853;
					continue;
				case 62u:
					Label4 = RegisterDonor.smethod_5();
					num = ((int)num2 * -561356405) ^ -1887016505;
					continue;
				case 61u:
					RegisterDonor.smethod_18((Control)(object)Label7, new Point(25, 327));
					num = (int)((num2 * 38025251) ^ 0xAF8F6A0);
					continue;
				case 60u:
					RegisterDonor.smethod_17((Control)(object)Label1, RegisterDonor.smethod_26("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 247281278) ^ -1709355809;
					continue;
				case 59u:
					RegisterDonor.smethod_20((Control)(object)Label2, new Size(62, 19));
					num = ((int)num2 * -903349721) ^ -1040406986;
					continue;
				case 58u:
					RegisterDonor.smethod_29((ButtonBase)(object)CheckBox1, bool_0: true);
					num = (int)(num2 * 1242297656) ^ -959954412;
					continue;
				case 57u:
					RegisterDonor.smethod_28((ButtonBase)(object)CheckBox3, "HIV");
					num = ((int)num2 * -610331673) ^ -1272871001;
					continue;
				case 56u:
					RegisterDonor.smethod_21((Control)(object)AgeTxt, 10);
					num = (int)((num2 * 2038933218) ^ 0x336C6317);
					continue;
				case 55u:
					RegisterDonor.smethod_21((Control)(object)NameTxt, 0);
					num = (int)(num2 * 1958331569) ^ -747727145;
					continue;
				case 54u:
					RegisterDonor.smethod_51((Control)(object)GroupBox1, bool_0: false);
					num = ((int)num2 * -342508250) ^ 0x7F45EA60;
					continue;
				case 53u:
					RegisterDonor.smethod_19((Control)(object)NameLbl, "NameLbl");
					num = (int)((num2 * 223345749) ^ 0x4484E6C0);
					continue;
				case 52u:
					RegisterDonor.smethod_20((Control)(object)QuantityTxt, new Size(87, 26));
					RegisterDonor.smethod_21((Control)(object)QuantityTxt, 23);
					num = ((int)num2 * -571054472) ^ -1686122255;
					continue;
				case 51u:
					GenderLbl = RegisterDonor.smethod_5();
					num = (int)(num2 * 981073346) ^ -1143745301;
					continue;
				case 50u:
					BloodGrpTxt = RegisterDonor.smethod_10();
					num = ((int)num2 * -900234575) ^ -1393483412;
					continue;
				case 49u:
					RegisterDonor.smethod_19((Control)(object)Label2, "Label2");
					num = (int)((num2 * 1024821544) ^ 0x5C668C2F);
					continue;
				case 48u:
					num = (int)(num2 * 531506190) ^ -1876338243;
					continue;
				case 47u:
					RegisterDonor.smethod_44(PictureBox1, bool_0: false);
					num = (int)(num2 * 1273743451) ^ -290731565;
					continue;
				case 46u:
					num = (int)(num2 * 2098603627) ^ -354914110;
					continue;
				case 45u:
					RegisterDonor.smethod_21((Control)(object)AddBtn, 19);
					num = (int)(num2 * 135737155) ^ -1519808866;
					continue;
				case 44u:
					num = ((int)num2 * -1438043778) ^ 0x1672E0C;
					continue;
				case 43u:
					RegisterDonor.smethod_18((Control)(object)GenderTxt, new Point(127, 226));
					num = (int)(num2 * 166084116) ^ -1367941007;
					continue;
				case 42u:
					CheckBox1 = RegisterDonor.smethod_8();
					num = (int)(num2 * 1554259922) ^ -630567418;
					continue;
				case 41u:
					NameLbl = RegisterDonor.smethod_5();
					MobileTxt = RegisterDonor.smethod_9();
					num = (int)((num2 * 385912090) ^ 0x5C91352F);
					continue;
				case 39u:
					RegisterDonor.smethod_34((ButtonBase)(object)CheckBox2, bool_0: true);
					num = ((int)num2 * -1630867106) ^ -1925865726;
					continue;
				case 38u:
					num = ((int)num2 * -1427156260) ^ -1236294892;
					continue;
				case 37u:
					CheckBox7 = RegisterDonor.smethod_8();
					num = ((int)num2 * -804813088) ^ -1126563918;
					continue;
				case 36u:
					RegisterDonor.smethod_21((Control)(object)NameLbl, 5);
					num = (int)(num2 * 2100104747) ^ -862838426;
					continue;
				case 35u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)MobileTxt);
					num = (int)((num2 * 1975821406) ^ 0x42413543);
					continue;
				case 34u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)Label7);
					num = (int)(num2 * 418648557) ^ -1640026283;
					continue;
				case 33u:
					GenderTxt = RegisterDonor.smethod_10();
					num = (int)(num2 * 26079621) ^ -1103647063;
					continue;
				case 32u:
					RegisterDonor.smethod_36(WarningLbl, bool_0: true);
					RegisterDonor.smethod_17((Control)(object)WarningLbl, RegisterDonor.smethod_26("Microsoft Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1285229822) ^ -1294262923;
					continue;
				case 31u:
					num = (int)((num2 * 1877259126) ^ 0x38FA4839);
					continue;
				case 30u:
					num = (int)(num2 * 657911424) ^ -952746635;
					continue;
				case 29u:
					num = (int)((num2 * 1538914426) ^ 0x43D6C1C);
					continue;
				case 28u:
					RegisterDonor.smethod_18((Control)(object)CheckBox5, new Point(34, 284));
					num = (int)(num2 * 985137190) ^ -982867266;
					continue;
				case 27u:
					num = (int)((num2 * 1346093986) ^ 0x34878D2F);
					continue;
				case 26u:
					RegisterDonor.smethod_18((Control)(object)SuccessMsg, new Point(117, 174));
					num = (int)((num2 * 1929209492) ^ 0x36B9E6D1);
					continue;
				case 25u:
					num = (int)((num2 * 292162781) ^ 0x61A49F02);
					continue;
				case 24u:
					RegisterDonor.smethod_45((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = (int)((num2 * 1754018698) ^ 0x3987F6D0);
					continue;
				case 23u:
					RegisterDonor.smethod_18((Control)(object)Label3, new Point(31, 36));
					num = ((int)num2 * -56519317) ^ 0x4B5A84BD;
					continue;
				case 22u:
					RegisterDonor.smethod_19((Control)(object)CheckBox1, "CheckBox1");
					num = ((int)num2 * -640003865) ^ 0x7B62F722;
					continue;
				case 21u:
					RegisterDonor.smethod_40(RegisterDonor.smethod_39(GenderTxt), new object[3] { "MALE", "FEMALE", "OTHERS" });
					num = ((int)num2 * -1822968233) ^ -908452074;
					continue;
				case 20u:
					RegisterDonor.smethod_19((Control)(object)Label4, "Label4");
					RegisterDonor.smethod_20((Control)(object)Label4, new Size(84, 18));
					num = (int)((num2 * 1619639274) ^ 0x2D15E64C);
					continue;
				case 19u:
					RegisterDonor.smethod_19((Control)(object)SuccessMsg, "SuccessMsg");
					num = ((int)num2 * -1146277909) ^ 0x2976C73A;
					continue;
				case 18u:
					RegisterDonor.smethod_43(PictureBox1, 15);
					num = ((int)num2 * -1498182190) ^ -638407937;
					continue;
				case 17u:
					RegisterDonor.smethod_32(GroupBox1, bool_0: false);
					num = (int)(num2 * 170469971) ^ -1032054897;
					continue;
				case 16u:
					RegisterDonor.smethod_19((Control)(object)NameTxt, "NameTxt");
					RegisterDonor.smethod_20((Control)(object)NameTxt, new Size(355, 26));
					num = (int)((num2 * 570260761) ^ 0x307EF10F);
					continue;
				case 15u:
					RegisterDonor.smethod_18((Control)(object)MobileLbl, new Point(25, 181));
					num = (int)(num2 * 1838803699) ^ -446298199;
					continue;
				case 14u:
					RegisterDonor.smethod_27((Control)(object)ClearBtn, Color.White);
					num = ((int)num2 * -1089103250) ^ 0x1AAC29D6;
					continue;
				case 13u:
					num = (int)(num2 * 433574155) ^ -441660740;
					continue;
				case 12u:
					RegisterDonor.smethod_20((Control)(object)Label1, new Size(242, 35));
					num = ((int)num2 * -986357908) ^ -1778447129;
					continue;
				case 11u:
					num = (int)(num2 * 865896206) ^ -1912187703;
					continue;
				case 10u:
					RegisterDonor.smethod_18((Control)(object)BloodGrpLbl, new Point(25, 280));
					num = (int)((num2 * 1581531164) ^ 0x2F271072);
					continue;
				case 9u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)WarningLbl);
					num = (int)(num2 * 1968786207) ^ -236068593;
					continue;
				case 8u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_30((Control)(object)GroupBox2), (Control)(object)Label4);
					num = ((int)num2 * -324812086) ^ -197328204;
					continue;
				case 7u:
					num = (int)((num2 * 929725532) ^ 0x69C8ACA);
					continue;
				case 6u:
					RegisterDonor.smethod_17((Control)(object)GenderLbl, RegisterDonor.smethod_26("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -541252623) ^ -737674062;
					continue;
				case 5u:
					RegisterDonor.smethod_53((ISupportInitialize)PictureBox1);
					num = (int)(num2 * 1832505942) ^ -635550797;
					continue;
				case 4u:
					num = (int)((num2 * 366343966) ^ 0x1DA28468);
					continue;
				case 3u:
					RegisterDonor.smethod_31(RegisterDonor.smethod_48((Control)(object)this), (Control)(object)GroupBox2);
					RegisterDonor.smethod_31(RegisterDonor.smethod_48((Control)(object)this), (Control)(object)Label1);
					num = ((int)num2 * -1126734568) ^ 0x64E623;
					continue;
				case 2u:
					RegisterDonor.smethod_19((Control)(object)AddBtn, "AddBtn");
					num = (int)(num2 * 15587158) ^ -1050011745;
					continue;
				case 1u:
					RegisterDonor.smethod_20((Control)(object)Label3, new Size(212, 36));
					num = ((int)num2 * -1286299748) ^ 0x359AE9AE;
					continue;
				case 0u:
					RegisterDonor.smethod_18((Control)(object)ClearBtn, new Point(547, 704));
					num = (int)((num2 * 974993686) ^ 0x6C43DC62);
					continue;
				default:
					return;
				case 105u:
					break;
				case 40u:
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
			int num = 471075362;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x44174B7Fu) % 7u)
				{
				case 6u:
					RegisterDonor.smethod_63(myconnection, RegisterDonor.smethod_62(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
					RegisterDonor.smethod_64(BloodGrpTxt, 0);
					num = (int)((num2 * 1363555149) ^ 0x15561D33);
					continue;
				case 5u:
					num = ((int)num2 * -549149008) ^ -838643090;
					continue;
				case 4u:
					RegisterDonor.smethod_65(DateTxt, DateTime.Today.ToShortDateString());
					num = ((int)num2 * -753246713) ^ 0x7D3C058D;
					continue;
				case 3u:
					RegisterDonor.smethod_64(GenderTxt, -1);
					num = ((int)num2 * -24778585) ^ -1216496631;
					continue;
				case 1u:
					num = ((int)num2 * -359337551) ^ -1931467902;
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

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected I4, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected I4, but got Unknown
		//IL_0364: Incompatible stack heights: 0 vs 1
		//IL_0380: Incompatible stack heights: 0 vs 1
		//IL_0390: Incompatible stack heights: 0 vs 1
		//IL_03a3: Incompatible stack heights: 0 vs 1
		//IL_03c1: Incompatible stack heights: 0 vs 1
		//IL_03f4: Incompatible stack heights: 0 vs 1
		//IL_03fe: Incompatible stack heights: 0 vs 1
		bool flag = !Validate_data();
		OleDbCommand val = default(OleDbCommand);
		while (true)
		{
			int num = 1757165767;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4A97549Eu) % 5u)
				{
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1602191231;
						num5 = -1602191231;
					}
					else
					{
						num4 = -1837570278;
						num5 = -1837570278;
					}
					num = num4 ^ (int)(num2 * 940550747);
					continue;
				}
				case 3u:
					num = 323787284;
					continue;
				case 0u:
					break;
				default:
				{
					string string_ = "Insert Into [Donor] (Name,Gender,Age,Blood,Mobile,[Blood Amount],[Donation Date]) Values (?,?,?,?,?,?,?)";
					RegisterDonor.smethod_66(myconnection);
					try
					{
						while (true)
						{
							int num3 = 1601508993;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x4A97549Eu) % 14u)
								{
								case 12u:
									RegisterDonor.smethod_76(val);
									RegisterDonor.smethod_77((Component)(object)val);
									RegisterDonor.smethod_78(myconnection);
									num3 = (int)((num2 * 84468995) ^ 0x2DD4A11C);
									continue;
								case 10u:
									num3 = ((int)num2 * -992420192) ^ -1339741445;
									continue;
								case 9u:
									RegisterDonor.smethod_72(RegisterDonor.smethod_68(val), RegisterDonor.smethod_71("Gender", (object)RegisterDonor.smethod_70(RegisterDonor.smethod_73(GenderTxt))));
									num3 = ((int)num2 * -754756999) ^ -1677989668;
									continue;
								case 8u:
									RegisterDonor.smethod_72(RegisterDonor.smethod_68(val), RegisterDonor.smethod_71("Name", (object)RegisterDonor.smethod_70(RegisterDonor.smethod_69(NameTxt))));
									num3 = (int)((num2 * 771846084) ^ 0x37542A09);
									continue;
								case 7u:
									RegisterDonor.smethod_72(RegisterDonor.smethod_68(val), RegisterDonor.smethod_71("Age", (object)(int)RegisterDonor.smethod_74(RegisterDonor.smethod_69(AgeTxt))));
									num3 = ((int)num2 * -1440967697) ^ 0x20FBA821;
									continue;
								case 6u:
									RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
									RegisterDonor.smethod_22(SuccessMsg, "Donor Successfully Registered !!");
									num3 = ((int)num2 * -755567779) ^ -1572736500;
									continue;
								case 5u:
									val = RegisterDonor.smethod_67(string_, myconnection);
									num3 = (int)((num2 * 313430295) ^ 0x234B4E6F);
									continue;
								case 4u:
									RegisterDonor.smethod_72(RegisterDonor.smethod_68(val), RegisterDonor.smethod_71("Blood", (object)RegisterDonor.smethod_73(BloodGrpTxt)));
									RegisterDonor.smethod_72(RegisterDonor.smethod_68(val), RegisterDonor.smethod_71("Mobile", (object)RegisterDonor.smethod_75(RegisterDonor.smethod_69(MobileTxt))));
									RegisterDonor.smethod_72(RegisterDonor.smethod_68(val), RegisterDonor.smethod_71("Blood Amount", (object)RegisterDonor.smethod_69(QuantityTxt)));
									num3 = (int)((num2 * 342488431) ^ 0x16CA9320);
									continue;
								case 3u:
									num3 = (int)(num2 * 2094912512) ^ -1794821131;
									continue;
								case 2u:
									RegisterDonor.smethod_72(RegisterDonor.smethod_68(val), RegisterDonor.smethod_71("Donation Date", (object)RegisterDonor.smethod_75(RegisterDonor.smethod_69(DateTxt))));
									num3 = (int)(num2 * 2123144566) ^ -1169326894;
									continue;
								case 1u:
									RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Green);
									num3 = ((int)num2 * -177634553) ^ -732153145;
									continue;
								case 0u:
									RegisterDonor.smethod_79(Timer1);
									num3 = (int)(num2 * 765191118) ^ -1519238681;
									continue;
								default:
									return;
								case 11u:
									break;
								case 13u:
									return;
								}
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						RegisterDonor.smethod_80(exception_);
						while (true)
						{
							_ = 1163088431;
							while (true)
							{
								_003F val2 = /*Error near IL_0317: Stack underflow*/^ 0x4A97549E;
								num2 = (uint)(int)val2;
								switch (val2 % 8)
								{
								default:
									return;
								case 6:
									RegisterDonor.smethod_79(Timer1);
									RegisterDonor.smethod_81();
									_ = ((int)num2 * -772648182) ^ 0x358CB67D;
									continue;
								case 5:
									RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
									_ = ((int)num2 * -789697839) ^ 0x1A8CC7D0;
									continue;
								case 3:
									_ = (num2 * 376387187) ^ 0xE5310EFFu;
									continue;
								case 2:
									_ = (num2 * 395862592) ^ 0x937C3033u;
									continue;
								case 1:
									RegisterDonor.smethod_78(myconnection);
									_ = (num2 * 1863289672) ^ 0x6B68F1EC;
									continue;
								case 0:
									RegisterDonor.smethod_22(SuccessMsg, "Invalid Credentials");
									RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Red);
									_ = ((int)num2 * -1295665422) ^ 0x493DF398;
									continue;
								case 4:
									break;
								case 7:
									return;
								}
								break;
							}
						}
					}
				}
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private bool Validate_data()
	{
		bool flag5 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool result = default(bool);
		bool flag4 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = -1871030355;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF3731120u) % 66u)
				{
				case 65u:
					RegisterDonor.smethod_79(Timer1);
					num = ((int)num2 * -108065263) ^ -1335342835;
					continue;
				case 64u:
					num = (int)((num2 * 1790413431) ^ 0x4D4D3D54);
					continue;
				case 63u:
					num = (int)(num2 * 915936696) ^ -2075209626;
					continue;
				case 62u:
					RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = (int)(num2 * 2100999473) ^ -1496953822;
					continue;
				case 61u:
				{
					int num15;
					int num16;
					if (flag5)
					{
						num15 = -1387228848;
						num16 = -1387228848;
					}
					else
					{
						num15 = -102525646;
						num16 = -102525646;
					}
					num = num15 ^ (int)(num2 * 702333607);
					continue;
				}
				case 60u:
				{
					int num10;
					int num11;
					if (flag2)
					{
						num10 = 1402803649;
						num11 = 1402803649;
					}
					else
					{
						num10 = 1654690094;
						num11 = 1654690094;
					}
					num = num10 ^ ((int)num2 * -530388414);
					continue;
				}
				case 59u:
					flag = !MyProject.Forms.Form1.Decimal_Validator(RegisterDonor.smethod_69(QuantityTxt));
					num = (int)(num2 * 1359974134) ^ -462590735;
					continue;
				case 58u:
					RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -141906458) ^ -607092881;
					continue;
				case 57u:
					num = (int)(num2 * 1903118766) ^ -1438857430;
					continue;
				case 56u:
					RegisterDonor.smethod_79(Timer1);
					num = (int)(num2 * 1572720520) ^ -1694720951;
					continue;
				case 55u:
					RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -275510919) ^ 0x1744DE2E;
					continue;
				case 54u:
					RegisterDonor.smethod_22(SuccessMsg, "Invalid Quantity");
					num = (int)((num2 * 544196272) ^ 0xBBB9F7B);
					continue;
				case 53u:
					num = (int)((num2 * 663022395) ^ 0x6B8D9749);
					continue;
				case 52u:
					num = (int)(num2 * 2025933001) ^ -1327662062;
					continue;
				case 51u:
					RegisterDonor.smethod_22(SuccessMsg, "Invalid Mobile Number");
					num = (int)((num2 * 304187583) ^ 0x18D4F19A);
					continue;
				case 50u:
				{
					flag2 = int.TryParse(RegisterDonor.smethod_69(AgeTxt), out var result2) && (result2 < 18 || result2 > 55);
					num = -176212344;
					continue;
				}
				case 49u:
					num = (int)(num2 * 918243593) ^ -550662549;
					continue;
				case 48u:
				{
					int num14;
					if (MyProject.Forms.Form1.age_validator(RegisterDonor.smethod_69(AgeTxt)))
					{
						num = -508589230;
						num14 = -508589230;
					}
					else
					{
						num = -1076419975;
						num14 = -1076419975;
					}
					continue;
				}
				case 47u:
					RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
					num = (int)((num2 * 993412264) ^ 0x1118AA8B);
					continue;
				case 46u:
					result = false;
					num = (int)((num2 * 1368243506) ^ 0x5A9147F2);
					continue;
				case 45u:
					RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = (int)((num2 * 454582159) ^ 0x90D86C7);
					continue;
				case 44u:
					result = true;
					num = -1490899714;
					continue;
				case 43u:
					num = (int)(num2 * 768892271) ^ -51666847;
					continue;
				case 42u:
					result = false;
					num = ((int)num2 * -556884707) ^ -1474669248;
					continue;
				case 41u:
					RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
					num = (int)((num2 * 1589347939) ^ 0x4A73F2F8);
					continue;
				case 40u:
					num = -2120728305;
					continue;
				case 38u:
					RegisterDonor.smethod_79(Timer1);
					num = ((int)num2 * -1018688235) ^ -35535114;
					continue;
				case 37u:
					num = ((int)num2 * -1061856390) ^ -1386515145;
					continue;
				case 36u:
					num = (int)((num2 * 1633055053) ^ 0x2C9F4DD8);
					continue;
				case 35u:
				{
					int num12;
					int num13;
					if (MyProject.Forms.Form1.Mobile_Validator(RegisterDonor.smethod_69(MobileTxt)))
					{
						num12 = -2027281357;
						num13 = -2027281357;
					}
					else
					{
						num12 = -68302479;
						num13 = -68302479;
					}
					num = num12 ^ (int)(num2 * 440403220);
					continue;
				}
				case 34u:
					num = ((int)num2 * -89069638) ^ 0x309450E2;
					continue;
				case 33u:
					num = -1473610011;
					continue;
				case 32u:
					RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
					num = (int)(num2 * 1423633855) ^ -434563164;
					continue;
				case 31u:
					RegisterDonor.smethod_22(SuccessMsg, "Invalid Name");
					num = (int)(num2 * 113045088) ^ -1258953126;
					continue;
				case 30u:
					RegisterDonor.smethod_79(Timer1);
					result = false;
					num = ((int)num2 * -649132502) ^ -1961650410;
					continue;
				case 29u:
					num = ((int)num2 * -1375955330) ^ -597983066;
					continue;
				case 28u:
					RegisterDonor.smethod_79(Timer1);
					num = (int)(num2 * 1952371915) ^ -1538660478;
					continue;
				case 27u:
					flag5 = RegisterDonor.smethod_82(BloodGrpTxt) == 0;
					num = -1215930751;
					continue;
				case 26u:
					RegisterDonor.smethod_22(SuccessMsg, "Invalid Age");
					num = (int)((num2 * 904243732) ^ 0x4AD26C5E);
					continue;
				case 25u:
					flag4 = !MyProject.Forms.Form1.Name_Validation(RegisterDonor.smethod_70(RegisterDonor.smethod_69(NameTxt)));
					num = (int)((num2 * 837555820) ^ 0x54493DB4);
					continue;
				case 23u:
					result = false;
					num = (int)((num2 * 1152358184) ^ 0x6A0F9E19);
					continue;
				case 22u:
					num = ((int)num2 * -1380516325) ^ -1247047410;
					continue;
				case 21u:
					RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -893500041) ^ 0x27EE446;
					continue;
				case 20u:
					result = false;
					num = (int)((num2 * 253148527) ^ 0x602F283F);
					continue;
				case 19u:
					RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
					RegisterDonor.smethod_22(SuccessMsg, "Donor Not Eligible");
					RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Red);
					RegisterDonor.smethod_79(Timer1);
					num = ((int)num2 * -1681907612) ^ 0x42AA670F;
					continue;
				case 18u:
					result = false;
					num = ((int)num2 * -174148260) ^ 0x60C7A0D5;
					continue;
				case 17u:
					RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = (int)(num2 * 996556469) ^ -1808588974;
					continue;
				case 16u:
					RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
					RegisterDonor.smethod_22(SuccessMsg, "Invalid Gender");
					num = ((int)num2 * -527564627) ^ -454115947;
					continue;
				case 15u:
					num = ((int)num2 * -1716945355) ^ 0x1D82AB69;
					continue;
				case 14u:
					RegisterDonor.smethod_22(SuccessMsg, "Donor Not Eligible.");
					num = ((int)num2 * -316325490) ^ 0x59AA4454;
					continue;
				case 13u:
					RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -1393921550) ^ 0x397D6C28;
					continue;
				case 12u:
				{
					int num8;
					int num9;
					if (flag4)
					{
						num8 = 83399447;
						num9 = 83399447;
					}
					else
					{
						num8 = 416839906;
						num9 = 416839906;
					}
					num = num8 ^ (int)(num2 * 1435220193);
					continue;
				}
				case 11u:
					RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = (int)((num2 * 561936541) ^ 0x7A513203);
					continue;
				case 10u:
					RegisterDonor.smethod_79(Timer1);
					result = false;
					num = (int)(num2 * 621972386) ^ -2072046796;
					continue;
				case 9u:
				{
					int num6;
					int num7;
					if (flag3)
					{
						num6 = -1108234897;
						num7 = -1108234897;
					}
					else
					{
						num6 = -1194800816;
						num7 = -1194800816;
					}
					num = num6 ^ ((int)num2 * -1063771507);
					continue;
				}
				case 8u:
					num = ((int)num2 * -1588268525) ^ -129033034;
					continue;
				case 7u:
					result = false;
					num = ((int)num2 * -558880623) ^ -2104106433;
					continue;
				case 6u:
					RegisterDonor.smethod_22(SuccessMsg, "Select Proper Blood Group");
					RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = (int)((num2 * 2113747555) ^ 0x3C1A25D);
					continue;
				case 5u:
					flag3 = !RegisterDonor.smethod_83(CheckBox1) | !RegisterDonor.smethod_83(CheckBox2) | !RegisterDonor.smethod_83(CheckBox3) | !RegisterDonor.smethod_83(CheckBox4) | !RegisterDonor.smethod_83(CheckBox5) | !RegisterDonor.smethod_83(CheckBox6) | !RegisterDonor.smethod_83(CheckBox7) | !RegisterDonor.smethod_83(CheckBox8);
					num = -1549835505;
					continue;
				case 4u:
				{
					int num5;
					if (!MyProject.Forms.Form1.Gender_Validator(RegisterDonor.smethod_70(RegisterDonor.smethod_73(GenderTxt))))
					{
						num = -1369569242;
						num5 = -1369569242;
					}
					else
					{
						num = -1903147372;
						num5 = -1903147372;
					}
					continue;
				}
				case 3u:
					num = (int)(num2 * 1588244476) ^ -268438911;
					continue;
				case 2u:
					RegisterDonor.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -1137292629) ^ 0x722B44EA;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1589687474;
						num4 = 1589687474;
					}
					else
					{
						num3 = 779418799;
						num4 = 779418799;
					}
					num = num3 ^ ((int)num2 * -1583867402);
					continue;
				}
				case 0u:
					RegisterDonor.smethod_79(Timer1);
					num = ((int)num2 * -67743079) ^ -83543794;
					continue;
				case 39u:
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
		while (true)
		{
			int num = 1058112200;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1FF9D70Bu) % 15u)
				{
				case 14u:
					num = (int)(num2 * 1928706341) ^ -1328846416;
					continue;
				case 13u:
					RegisterDonor.smethod_84((TextBoxBase)(object)MobileTxt);
					num = (int)(num2 * 864857443) ^ -1006982338;
					continue;
				case 12u:
					RegisterDonor.smethod_64(GenderTxt, -1);
					num = (int)(num2 * 442844772) ^ -736516356;
					continue;
				case 11u:
					RegisterDonor.smethod_85(CheckBox5, bool_0: false);
					num = (int)(num2 * 243163672) ^ -1836097380;
					continue;
				case 9u:
					num = (int)(num2 * 114969905) ^ -550225970;
					continue;
				case 8u:
					RegisterDonor.smethod_85(CheckBox7, bool_0: false);
					num = (int)((num2 * 1007665034) ^ 0x4FB42004);
					continue;
				case 7u:
					RegisterDonor.smethod_85(CheckBox8, bool_0: false);
					num = (int)(num2 * 2107833450) ^ -1346881647;
					continue;
				case 6u:
					RegisterDonor.smethod_85(CheckBox4, bool_0: false);
					num = (int)((num2 * 807311186) ^ 0x5D7E2E23);
					continue;
				case 5u:
					RegisterDonor.smethod_64(BloodGrpTxt, 0);
					RegisterDonor.smethod_85(CheckBox1, bool_0: false);
					num = ((int)num2 * -1945747150) ^ -1158233606;
					continue;
				case 4u:
					num = ((int)num2 * -768841236) ^ 0x24CC584E;
					continue;
				case 2u:
					RegisterDonor.smethod_85(CheckBox2, bool_0: false);
					RegisterDonor.smethod_85(CheckBox3, bool_0: false);
					num = ((int)num2 * -1409796635) ^ 0x61CB7114;
					continue;
				case 1u:
					RegisterDonor.smethod_84((TextBoxBase)(object)AgeTxt);
					num = ((int)num2 * -250954482) ^ 0x5B9FBCC9;
					continue;
				case 0u:
					RegisterDonor.smethod_85(CheckBox6, bool_0: false);
					num = ((int)num2 * -2050880854) ^ -1825790898;
					continue;
				default:
					return;
				case 10u:
					break;
				case 3u:
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
			int num = -1522645416;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA61F2210u) % 5u)
				{
				case 4u:
					RegisterDonor.smethod_86(Timer1);
					num = (int)(num2 * 712457686) ^ -1267756421;
					continue;
				case 3u:
					RegisterDonor.smethod_24((Control)(object)SuccessMsg, bool_0: false);
					num = ((int)num2 * -1289736080) ^ 0x77F6F8E0;
					continue;
				case 1u:
					num = ((int)num2 * -1888921453) ^ -2007663332;
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

	private void GenderTxt_SelectionChangeCommitted(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 157052570;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4768F734u) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0003:
				RegisterDonor.smethod_87((Control)(object)BloodGrpTxt);
				num = (int)((num2 * 2026227874) ^ 0x434255BC);
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
