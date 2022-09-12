using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
public class Availability : UserControl
{
	private IContainer components;

	private string Designation;

	private OleDbConnection myconnection;

	private int day;

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

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button SearchBtn
	{
		[CompilerGenerated]
		get
		{
			return _SearchBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = SearchBtn_Click;
			Button searchBtn = default(Button);
			while (true)
			{
				int num = 386680948;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1E0B1A7Du) % 6u)
					{
					case 5u:
					{
						searchBtn = _SearchBtn;
						int num4;
						int num5;
						if (searchBtn == null)
						{
							num4 = 1965605437;
							num5 = 1965605437;
						}
						else
						{
							num4 = 1172365868;
							num5 = 1172365868;
						}
						num = num4 ^ ((int)num2 * -566808841);
						continue;
					}
					case 4u:
						Availability.smethod_55((Control)(object)searchBtn, eventHandler_);
						num = ((int)num2 * -1322673009) ^ -66592912;
						continue;
					case 1u:
					{
						_SearchBtn = value;
						searchBtn = _SearchBtn;
						int num3;
						if (searchBtn != null)
						{
							num = 1948195979;
							num3 = 1948195979;
						}
						else
						{
							num = 2096819198;
							num3 = 2096819198;
						}
						continue;
					}
					case 0u:
						Availability.smethod_56((Control)(object)searchBtn, eventHandler_);
						num = (int)((num2 * 788785197) ^ 0x764CC2C0);
						continue;
					default:
						return;
					case 2u:
						break;
					case 3u:
						return;
					}
					break;
				}
			}
		}
	}

	[field: AccessedThroughProperty("NameSTxt")]
	internal virtual TextBox NameSTxt
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

	internal virtual RadioButton NurseBtn
	{
		[CompilerGenerated]
		get
		{
			return _NurseBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = RadioButton2_CheckedChanged;
			RadioButton nurseBtn = default(RadioButton);
			while (true)
			{
				int num = 1126640888;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1C265BBBu) % 8u)
					{
					case 7u:
						Availability.smethod_58(nurseBtn, eventHandler_);
						num = ((int)num2 * -1633969430) ^ -291567345;
						continue;
					case 6u:
						Availability.smethod_57(nurseBtn, eventHandler_);
						num = (int)(num2 * 925977386) ^ -1868807993;
						continue;
					case 5u:
					{
						nurseBtn = _NurseBtn;
						int num5;
						int num6;
						if (nurseBtn != null)
						{
							num5 = 915493452;
							num6 = 915493452;
						}
						else
						{
							num5 = 716328017;
							num6 = 716328017;
						}
						num = num5 ^ ((int)num2 * -1091832536);
						continue;
					}
					case 3u:
						nurseBtn = _NurseBtn;
						num = ((int)num2 * -1993448452) ^ 0x4A1DC3EE;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (nurseBtn != null)
						{
							num3 = -1217969078;
							num4 = -1217969078;
						}
						else
						{
							num3 = -1422279172;
							num4 = -1422279172;
						}
						num = num3 ^ ((int)num2 * -357293113);
						continue;
					}
					case 0u:
						_NurseBtn = value;
						num = 1080383582;
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

	internal virtual RadioButton DoctorBtn
	{
		[CompilerGenerated]
		get
		{
			return _DoctorBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = RadioButton1_CheckedChanged;
			RadioButton doctorBtn = default(RadioButton);
			while (true)
			{
				int num = 575540123;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1926B5FDu) % 9u)
					{
					case 7u:
						doctorBtn = _DoctorBtn;
						num = (int)((num2 * 402768357) ^ 0x593E8EE8);
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (doctorBtn == null)
						{
							num5 = 1537940158;
							num6 = 1537940158;
						}
						else
						{
							num5 = 668212421;
							num6 = 668212421;
						}
						num = num5 ^ ((int)num2 * -2095922533);
						continue;
					}
					case 5u:
						_DoctorBtn = value;
						num = 389039204;
						continue;
					case 4u:
						Availability.smethod_58(doctorBtn, eventHandler_);
						num = ((int)num2 * -4389830) ^ 0x54E073E6;
						continue;
					case 2u:
						doctorBtn = _DoctorBtn;
						num = (int)((num2 * 892584042) ^ 0x192084A);
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (doctorBtn == null)
						{
							num3 = -1495789560;
							num4 = -1495789560;
						}
						else
						{
							num3 = -403374331;
							num4 = -403374331;
						}
						num = num3 ^ ((int)num2 * -91251219);
						continue;
					}
					case 0u:
						Availability.smethod_57(doctorBtn, eventHandler_);
						num = ((int)num2 * -1242201772) ^ 0x722C1D2B;
						continue;
					default:
						return;
					case 3u:
						break;
					case 8u:
						return;
					}
					break;
				}
			}
		}
	}

	internal virtual RadioButton ReceptionistBtn
	{
		[CompilerGenerated]
		get
		{
			return _ReceptionistBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = RadioButton3_CheckedChanged;
			RadioButton receptionistBtn = default(RadioButton);
			while (true)
			{
				int num = -661464927;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8285B2EDu) % 7u)
					{
					case 6u:
					{
						receptionistBtn = _ReceptionistBtn;
						int num5;
						int num6;
						if (receptionistBtn != null)
						{
							num5 = 461107529;
							num6 = 461107529;
						}
						else
						{
							num5 = 1299246018;
							num6 = 1299246018;
						}
						num = num5 ^ ((int)num2 * -498668271);
						continue;
					}
					case 3u:
						Availability.smethod_57(receptionistBtn, eventHandler_);
						num = (int)(num2 * 1277129411) ^ -73447626;
						continue;
					case 2u:
						_ReceptionistBtn = value;
						num = -1843313131;
						continue;
					case 1u:
						Availability.smethod_58(receptionistBtn, eventHandler_);
						num = ((int)num2 * -1728148755) ^ 0x678E1E27;
						continue;
					case 0u:
					{
						receptionistBtn = _ReceptionistBtn;
						int num3;
						int num4;
						if (receptionistBtn != null)
						{
							num3 = -1871806079;
							num4 = -1871806079;
						}
						else
						{
							num3 = -1260337477;
							num4 = -1260337477;
						}
						num = num3 ^ (int)(num2 * 491970226);
						continue;
					}
					default:
						return;
					case 4u:
						break;
					case 5u:
						return;
					}
					break;
				}
			}
		}
	}

	internal virtual DataGridView SearchResultGrid
	{
		[CompilerGenerated]
		get
		{
			return _SearchResultGrid;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler_ = new DataGridViewCellMouseEventHandler(DataGridView1_CellMouseClick);
			DataGridView searchResultGrid = _SearchResultGrid;
			while (true)
			{
				int num = 229163800;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x36520AC9u) % 8u)
					{
					case 7u:
						_SearchResultGrid = value;
						num = 1571832355;
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (searchResultGrid != null)
						{
							num5 = -995111043;
							num6 = -995111043;
						}
						else
						{
							num5 = -1033944520;
							num6 = -1033944520;
						}
						num = num5 ^ ((int)num2 * -347158786);
						continue;
					}
					case 3u:
						Availability.smethod_59(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = (int)(num2 * 1184786034) ^ -1238432152;
						continue;
					case 2u:
						searchResultGrid = _SearchResultGrid;
						num = (int)(num2 * 1839989595) ^ -1873867663;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (searchResultGrid != null)
						{
							num3 = 645658531;
							num4 = 645658531;
						}
						else
						{
							num3 = 1427208503;
							num4 = 1427208503;
						}
						num = num3 ^ (int)(num2 * 1085551225);
						continue;
					}
					case 0u:
						Availability.smethod_60(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = (int)(num2 * 1231061779) ^ -1233949492;
						continue;
					default:
						return;
					case 4u:
						break;
					case 5u:
						return;
					}
					break;
				}
			}
		}
	}

	[field: AccessedThroughProperty("DetailsBox")]
	internal virtual GroupBox DetailsBox
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

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
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

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
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

	[field: AccessedThroughProperty("GenderTxt")]
	internal virtual TextBox GenderTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DOBTxt")]
	internal virtual TextBox DOBTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SIDTxt")]
	internal virtual TextBox SIDTxt
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

	[field: AccessedThroughProperty("DesignationTxt")]
	internal virtual TextBox DesignationTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ShowAvailability")]
	internal virtual Label ShowAvailability
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
			EventHandler eventHandler_ = Button2_Click;
			Button clearBtn = default(Button);
			while (true)
			{
				int num = 467680636;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x40A9A4EAu) % 7u)
					{
					case 5u:
						clearBtn = _ClearBtn;
						num = ((int)num2 * -37165971) ^ -1135268105;
						continue;
					case 4u:
					{
						_ClearBtn = value;
						clearBtn = _ClearBtn;
						int num5;
						if (clearBtn != null)
						{
							num = 652679206;
							num5 = 652679206;
						}
						else
						{
							num = 1361490317;
							num5 = 1361490317;
						}
						continue;
					}
					case 3u:
						Availability.smethod_56((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -217128790) ^ -1652199691;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (clearBtn != null)
						{
							num3 = 1963608169;
							num4 = 1963608169;
						}
						else
						{
							num3 = 623440724;
							num4 = 623440724;
						}
						num = num3 ^ (int)(num2 * 1574278008);
						continue;
					}
					case 1u:
						Availability.smethod_55((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -676158395) ^ 0x6457646B;
						continue;
					default:
						return;
					case 6u:
						break;
					case 0u:
						return;
					}
					break;
				}
			}
		}
	}

	public Availability()
	{
		Availability.smethod_0((UserControl)(object)this, (EventHandler)Availability_Load);
		myconnection = Availability.smethod_1();
		day = Availability.smethod_2(DateTime.Now.ToString("HH"));
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (!disposing)
			{
				goto IL_000a;
			}
			goto IL_0035;
			IL_0035:
			int num = -1086273698;
			goto IL_0054;
			IL_0054:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE6B6F4B3u) % 6u)
				{
				case 4u:
					num = ((int)num2 * -35014960) ^ 0x397847E6;
					continue;
				case 3u:
					num = ((int)num2 * -986638554) ^ -111161934;
					continue;
				case 2u:
					break;
				case 0u:
					Availability.smethod_3((IDisposable)components);
					num = (int)((num2 * 1934376243) ^ 0x6164FE3F);
					continue;
				default:
					return;
				case 5u:
					goto IL_007d;
				case 1u:
					return;
				}
				break;
				IL_007d:
				if (components != null)
				{
					num = -1737138289;
					num3 = -1737138289;
					continue;
				}
				goto IL_000a;
			}
			goto IL_0035;
			IL_000a:
			num = -1379007700;
			num3 = -1379007700;
			goto IL_0054;
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
			int num = -2138018051;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x886D8899u) % 302u)
				{
				case 301u:
					num = (int)((num2 * 1449902439) ^ 0xFDEE099);
					continue;
				case 300u:
					Availability.smethod_19((Control)(object)GroupBox1, new Size(623, 127));
					num = (int)(num2 * 1633107921) ^ -1459447573;
					continue;
				case 299u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)Label9);
					num = ((int)num2 * -1298274986) ^ -1867530161;
					continue;
				case 298u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)Label3);
					num = (int)(num2 * 247751496) ^ -465576758;
					continue;
				case 297u:
					Availability.smethod_20((Control)(object)Label8, 9);
					num = ((int)num2 * -543187369) ^ -1618497638;
					continue;
				case 296u:
					Availability.smethod_18((Control)(object)NurseBtn, "NurseBtn");
					Availability.smethod_19((Control)(object)NurseBtn, new Size(78, 23));
					num = (int)(num2 * 1564673678) ^ -1919311786;
					continue;
				case 295u:
					Availability.smethod_19((Control)(object)SIDTxt, new Size(100, 28));
					num = ((int)num2 * -209626118) ^ -796257405;
					continue;
				case 294u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)GenderTxt);
					num = ((int)num2 * -327624038) ^ -1440392943;
					continue;
				case 293u:
					num = ((int)num2 * -437078257) ^ -437676707;
					continue;
				case 292u:
					Availability.smethod_19((Control)(object)NameSTxt, new Size(292, 28));
					num = ((int)num2 * -1925822938) ^ -675279805;
					continue;
				case 291u:
					PictureBox1 = Availability.smethod_10();
					num = ((int)num2 * -1335061810) ^ 0x422C8037;
					continue;
				case 290u:
					Availability.smethod_18((Control)(object)PictureBox1, "PictureBox1");
					num = (int)((num2 * 328412011) ^ 0x7AC4D111);
					continue;
				case 289u:
					Availability.smethod_28((Control)(object)ClearBtn, Color.White);
					num = ((int)num2 * -582625527) ^ 0x726102B7;
					continue;
				case 288u:
					num = (int)((num2 * 405473819) ^ 0x117EABD0);
					continue;
				case 287u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)DOBTxt);
					num = (int)((num2 * 1035082502) ^ 0x24611043);
					continue;
				case 286u:
					Availability.smethod_49((Control)(object)this, new Size(977, 804));
					num = (int)(num2 * 755812200) ^ -145280936;
					continue;
				case 285u:
					num = ((int)num2 * -1102081470) ^ 0x1F74B8F1;
					continue;
				case 284u:
					Availability.smethod_21(Label9, "Phone : ");
					num = (int)(num2 * 2107788723) ^ -1714418212;
					continue;
				case 283u:
					Availability.smethod_25(DetailsBox, bool_0: false);
					num = (int)(num2 * 642376407) ^ -1042119073;
					continue;
				case 282u:
					Availability.smethod_34(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					num = ((int)num2 * -1388851651) ^ -2113774428;
					continue;
				case 281u:
					num = ((int)num2 * -261895652) ^ 0x296F35FA;
					continue;
				case 280u:
					Availability.smethod_19((Control)(object)Label7, new Size(98, 26));
					num = (int)((num2 * 2057490344) ^ 0x14081084);
					continue;
				case 279u:
					num = ((int)num2 * -50901732) ^ -141702358;
					continue;
				case 278u:
					num = (int)(num2 * 348756833) ^ -699745516;
					continue;
				case 277u:
					num = (int)((num2 * 911428393) ^ 0x7011983E);
					continue;
				case 276u:
					num = (int)((num2 * 456555116) ^ 0x56355BD7);
					continue;
				case 275u:
					Availability.smethod_19((Control)(object)AddressTxt, new Size(483, 90));
					num = (int)(num2 * 236393125) ^ -1037365951;
					continue;
				case 274u:
					Availability.smethod_54((Control)(object)this);
					num = ((int)num2 * -1221358913) ^ 0xD4B43C6;
					continue;
				case 273u:
					Availability.smethod_42(PictureBox1, (PictureBoxSizeMode)1);
					num = (int)(num2 * 1497490422) ^ -252579986;
					continue;
				case 272u:
					Availability.smethod_20((Control)(object)DetailsBox, 9);
					num = ((int)num2 * -1748217004) ^ -1733908125;
					continue;
				case 271u:
					num = ((int)num2 * -861392623) ^ 0x1CE5ACB1;
					continue;
				case 270u:
					num = ((int)num2 * -1556040588) ^ 0x1B3C4FC2;
					continue;
				case 269u:
					num = (int)(num2 * 1721037888) ^ -2068604849;
					continue;
				case 268u:
					Availability.smethod_18((Control)(object)SearchResultGrid, "SearchResultGrid");
					num = (int)(num2 * 1292446192) ^ -646370019;
					continue;
				case 267u:
					num = (int)((num2 * 1474478016) ^ 0x364C8083);
					continue;
				case 266u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)DesignationTxt);
					num = (int)(num2 * 666165742) ^ -1087675087;
					continue;
				case 265u:
					Availability.smethod_20((Control)(object)NurseBtn, 6);
					num = ((int)num2 * -137303958) ^ -1617187105;
					continue;
				case 264u:
					Label3 = Availability.smethod_4();
					num = (int)(num2 * 599048543) ^ -580672507;
					continue;
				case 263u:
					num = ((int)num2 * -997377528) ^ -1913294583;
					continue;
				case 262u:
					num = ((int)num2 * -1661581918) ^ 0x2BACB9EB;
					continue;
				case 261u:
					Availability.smethod_16((Control)(object)DetailsBox, Availability.smethod_15("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1057686483) ^ -1372211370;
					continue;
				case 260u:
					Availability.smethod_30((ButtonBase)(object)SearchBtn, bool_0: false);
					num = ((int)num2 * -1235490140) ^ 0x741AA1F1;
					continue;
				case 259u:
					Availability.smethod_20((Control)(object)NameTxt, 10);
					num = ((int)num2 * -1328149526) ^ 0x6FFC225A;
					continue;
				case 258u:
					Availability.smethod_12((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -1972660941) ^ -541302494;
					continue;
				case 257u:
					Availability.smethod_19((Control)(object)DesignationTxt, new Size(179, 28));
					num = (int)(num2 * 1607694231) ^ -46024296;
					continue;
				case 256u:
					num = ((int)num2 * -1545705377) ^ -1167449694;
					continue;
				case 255u:
					Availability.smethod_32(NurseBtn, bool_0: true);
					Availability.smethod_29((ButtonBase)(object)NurseBtn, "Nurse");
					Availability.smethod_30((ButtonBase)(object)NurseBtn, bool_0: true);
					num = (int)(num2 * 1488386347) ^ -5807768;
					continue;
				case 254u:
					num = (int)((num2 * 1763178097) ^ 0x7CAA7E63);
					continue;
				case 253u:
					Availability.smethod_26(GroupBox1, "Search Staff Member");
					num = (int)((num2 * 2103718555) ^ 0x703B5262);
					continue;
				case 252u:
					num = (int)((num2 * 197505669) ^ 0x371EEFE1);
					continue;
				case 251u:
					Availability.smethod_28((Control)(object)SearchBtn, Color.White);
					num = ((int)num2 * -400546879) ^ 0x9710A3C;
					continue;
				case 250u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)Label6);
					num = (int)((num2 * 854950731) ^ 0x676262FA);
					continue;
				case 249u:
					num = ((int)num2 * -5719966) ^ 0x753B294D;
					continue;
				case 248u:
					num = (int)(num2 * 574041363) ^ -2054398272;
					continue;
				case 247u:
					num = (int)(num2 * 1442003641) ^ -270170967;
					continue;
				case 246u:
					Availability.smethod_17((Control)(object)GroupBox1, new Point(155, 150));
					Availability.smethod_18((Control)(object)GroupBox1, "GroupBox1");
					num = ((int)num2 * -1366886987) ^ 0x4DFBA47B;
					continue;
				case 245u:
					num = (int)((num2 * 456874537) ^ 0x34D6E808);
					continue;
				case 244u:
					Availability.smethod_21(Label1, "Staff Availability");
					Availability.smethod_22(Label1, (ContentAlignment)32);
					num = ((int)num2 * -1516462838) ^ -1281012766;
					continue;
				case 243u:
					Availability.smethod_17((Control)(object)ClearBtn, new Point(467, 30));
					num = ((int)num2 * -1888081859) ^ -246277046;
					continue;
				case 242u:
					Availability.smethod_18((Control)(object)ReceptionistBtn, "ReceptionistBtn");
					num = ((int)num2 * -1312229921) ^ -508346101;
					continue;
				case 241u:
					Availability.smethod_14(Label1, bool_0: true);
					Availability.smethod_16((Control)(object)Label1, Availability.smethod_15("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -2133819292) ^ 0x5A8B0587;
					continue;
				case 240u:
					Availability.smethod_18((Control)(object)Label2, "Label2");
					Availability.smethod_19((Control)(object)Label2, new Size(77, 28));
					num = ((int)num2 * -991555229) ^ 0x33AB2048;
					continue;
				case 239u:
					num = (int)((num2 * 1112060579) ^ 0x1894741E);
					continue;
				case 238u:
					Availability.smethod_30((ButtonBase)(object)DoctorBtn, bool_0: true);
					Availability.smethod_27((ButtonBase)(object)SearchBtn, Color.MidnightBlue);
					num = (int)(num2 * 359881781) ^ -562568198;
					continue;
				case 237u:
					Availability.smethod_17((Control)(object)DetailsBox, new Point(155, 470));
					num = ((int)num2 * -833926505) ^ 0x53B31A5D;
					continue;
				case 236u:
					Availability.smethod_17((Control)(object)PictureBox1, new Point(260, 22));
					num = (int)(num2 * 1131164034) ^ -275901787;
					continue;
				case 235u:
					num = (int)(num2 * 1584954362) ^ -1728097066;
					continue;
				case 234u:
					num = ((int)num2 * -1060809864) ^ 0x7DA4EAA8;
					continue;
				case 233u:
					Availability.smethod_51((Control)(object)DetailsBox);
					num = (int)((num2 * 1445322579) ^ 0x2136465B);
					continue;
				case 232u:
					num = (int)(num2 * 416653898) ^ -576039767;
					continue;
				case 231u:
					num = (int)(num2 * 268264364) ^ -1835693771;
					continue;
				case 230u:
					num = ((int)num2 * -1447782801) ^ -1347712652;
					continue;
				case 229u:
					Availability.smethod_18((Control)(object)MobileTxt, "MobileTxt");
					num = (int)(num2 * 1290134485) ^ -501175807;
					continue;
				case 228u:
					Availability.smethod_17((Control)(object)DesignationTxt, new Point(428, 71));
					num = ((int)num2 * -472187472) ^ -813821166;
					continue;
				case 227u:
					num = ((int)num2 * -1085932200) ^ -425157612;
					continue;
				case 226u:
					Availability.smethod_33(SearchResultGrid, Color.White);
					num = ((int)num2 * -1161109153) ^ -193853845;
					continue;
				case 225u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)AddressTxt);
					num = ((int)num2 * -544139324) ^ 0x19610FEB;
					continue;
				case 224u:
					num = (int)((num2 * 616693962) ^ 0x1574AE5A);
					continue;
				case 223u:
					Availability.smethod_20((Control)(object)SearchResultGrid, 8);
					num = (int)((num2 * 1086509740) ^ 0x4A80CF58);
					continue;
				case 222u:
					Availability.smethod_46((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1629226059) ^ -1231897579;
					continue;
				case 221u:
					Availability.smethod_20((Control)(object)AddressTxt, 7);
					num = ((int)num2 * -1210613386) ^ -378697475;
					continue;
				case 220u:
					Availability.smethod_12((ISupportInitialize)SearchResultGrid);
					Availability.smethod_11((Control)(object)DetailsBox);
					num = (int)(num2 * 686672500) ^ -617487395;
					continue;
				case 219u:
					Availability.smethod_18((Control)(object)DoctorBtn, "DoctorBtn");
					Availability.smethod_19((Control)(object)DoctorBtn, new Size(87, 23));
					num = (int)((num2 * 1938996276) ^ 0x5AD6AB62);
					continue;
				case 218u:
					num = ((int)num2 * -1985851940) ^ -2112722936;
					continue;
				case 217u:
					Availability.smethod_16((Control)(object)SearchBtn, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1979266929) ^ -606306899;
					continue;
				case 216u:
					num = ((int)num2 * -1310896614) ^ 0x347B7C6B;
					continue;
				case 215u:
					num = ((int)num2 * -760964614) ^ -1287299374;
					continue;
				case 214u:
					Availability.smethod_18((Control)(object)Label9, "Label9");
					num = (int)(num2 * 828217821) ^ -1935303587;
					continue;
				case 213u:
					Availability.smethod_52((ISupportInitialize)SearchResultGrid);
					num = (int)(num2 * 53710455) ^ -1080190748;
					continue;
				case 212u:
					num = ((int)num2 * -62414162) ^ 0x798A1908;
					continue;
				case 211u:
					Availability.smethod_17((Control)(object)GenderTxt, new Point(479, 163));
					num = ((int)num2 * -2060639767) ^ 0x2B024114;
					continue;
				case 210u:
					num = ((int)num2 * -1654999587) ^ 0x2ECE1A18;
					continue;
				case 209u:
					num = (int)(num2 * 36677029) ^ -1416906437;
					continue;
				case 208u:
					Availability.smethod_27((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					num = (int)((num2 * 1407026860) ^ 0x76115276);
					continue;
				case 207u:
					Availability.smethod_16((Control)(object)Label2, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 976749618) ^ 0x6ECA2F04);
					continue;
				case 206u:
					DoctorBtn = Availability.smethod_7();
					num = ((int)num2 * -1004211181) ^ -1111799915;
					continue;
				case 205u:
					num = ((int)num2 * -2088235903) ^ 0x29324C8F;
					continue;
				case 204u:
					Availability.smethod_20((Control)(object)ReceptionistBtn, 7);
					num = (int)(num2 * 2089359700) ^ -107148818;
					continue;
				case 203u:
					num = (int)((num2 * 1642393103) ^ 0x6BE54AA);
					continue;
				case 202u:
					num = ((int)num2 * -1598107039) ^ 0x121F2105;
					continue;
				case 201u:
					num = ((int)num2 * -2025928033) ^ 0x4FA95318;
					continue;
				case 200u:
					Label4 = Availability.smethod_4();
					num = (int)((num2 * 261494512) ^ 0x640B78DA);
					continue;
				case 199u:
					num = ((int)num2 * -872714533) ^ 0x2D99F88D;
					continue;
				case 198u:
					Availability.smethod_17((Control)(object)MobileTxt, new Point(124, 169));
					num = (int)(num2 * 1242939395) ^ -1617220672;
					continue;
				case 197u:
					Availability.smethod_39((TextBoxBase)(object)AddressTxt, bool_0: true);
					num = (int)(num2 * 1808976541) ^ -347720885;
					continue;
				case 195u:
					num = ((int)num2 * -444325306) ^ -2114833488;
					continue;
				case 194u:
					NurseBtn = Availability.smethod_7();
					num = (int)((num2 * 840416363) ^ 0x7B82878F);
					continue;
				case 193u:
					Availability.smethod_17((Control)(object)NameSTxt, new Point(120, 44));
					num = (int)(num2 * 82609421) ^ -1710599491;
					continue;
				case 192u:
					num = ((int)num2 * -903582140) ^ 0x18EEFC77;
					continue;
				case 191u:
					ClearBtn = Availability.smethod_6();
					num = (int)((num2 * 1303046346) ^ 0x3D903A51);
					continue;
				case 190u:
					SIDTxt = Availability.smethod_8();
					Label7 = Availability.smethod_4();
					num = (int)((num2 * 1107226415) ^ 0x464E7F69);
					continue;
				case 189u:
					Availability.smethod_21(Label7, "Address : ");
					Availability.smethod_16((Control)(object)Label6, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1452130796) ^ 0xAC80BDA;
					continue;
				case 188u:
					num = ((int)num2 * -1543962062) ^ 0x3B6BFFE5;
					continue;
				case 187u:
					num = (int)((num2 * 724208794) ^ 0x7CE20845);
					continue;
				case 186u:
					num = (int)((num2 * 1800335240) ^ 0x2D191749);
					continue;
				case 185u:
					Availability.smethod_24(Availability.smethod_47((Control)(object)this), (Control)(object)Label1);
					num = ((int)num2 * -428819384) ^ -1224729675;
					continue;
				case 184u:
					Availability.smethod_19((Control)(object)PictureBox1, new Size(126, 122));
					num = (int)(num2 * 1419621360) ^ -1180449684;
					continue;
				case 183u:
					DesignationTxt = Availability.smethod_8();
					num = (int)(num2 * 2133676388) ^ -1092065787;
					continue;
				case 182u:
					Availability.smethod_19((Control)(object)ReceptionistBtn, new Size(132, 23));
					num = ((int)num2 * -1762465147) ^ 0x662D357;
					continue;
				case 181u:
					Availability.smethod_16((Control)(object)Label7, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1467897297) ^ 0x5D9192C8;
					continue;
				case 180u:
					Availability.smethod_17((Control)(object)Label9, new Point(16, 169));
					num = ((int)num2 * -586655869) ^ -114141264;
					continue;
				case 179u:
					Availability.smethod_21(Label6, "Gender : ");
					num = (int)(num2 * 1472658489) ^ -862395591;
					continue;
				case 178u:
					Availability.smethod_20((Control)(object)GenderTxt, 6);
					Availability.smethod_17((Control)(object)DOBTxt, new Point(479, 121));
					num = (int)((num2 * 300113299) ^ 0x53C7F6EF);
					continue;
				case 177u:
					num = ((int)num2 * -499590557) ^ 0x6ED79973;
					continue;
				case 176u:
					Availability.smethod_18((Control)(object)Label3, "Label3");
					num = (int)((num2 * 749509397) ^ 0x3753710E);
					continue;
				case 175u:
					num = ((int)num2 * -51191313) ^ -1309182302;
					continue;
				case 174u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)Label8);
					num = ((int)num2 * -1016822825) ^ -1216943936;
					continue;
				case 173u:
					Availability.smethod_29((ButtonBase)(object)ReceptionistBtn, "Receptionist");
					num = (int)(num2 * 2012111246) ^ -258515116;
					continue;
				case 172u:
					num = ((int)num2 * -441736905) ^ -2037380892;
					continue;
				case 171u:
					num = ((int)num2 * -202049790) ^ 0x4A1E4467;
					continue;
				case 170u:
					Availability.smethod_18((Control)(object)SIDTxt, "SIDTxt");
					num = ((int)num2 * -1015509858) ^ -1385610338;
					continue;
				case 169u:
					Availability.smethod_20((Control)(object)Label7, 3);
					num = ((int)num2 * -141450422) ^ -946248819;
					continue;
				case 168u:
					Availability.smethod_16((Control)(object)GroupBox1, Availability.smethod_15("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 2126496871) ^ 0x3329FB53);
					continue;
				case 167u:
					Availability.smethod_19((Control)(object)Label3, new Size(121, 28));
					Availability.smethod_20((Control)(object)Label3, 13);
					Availability.smethod_21(Label3, "Designation : ");
					num = (int)((num2 * 1867793903) ^ 0x27DC6F7F);
					continue;
				case 166u:
					num = ((int)num2 * -464699386) ^ -1716340857;
					continue;
				case 165u:
					Availability.smethod_21(Label2, "Name : ");
					num = ((int)num2 * -1665000781) ^ -1789933121;
					continue;
				case 164u:
					Availability.smethod_22(ShowAvailability, (ContentAlignment)32);
					num = (int)(num2 * 1113008452) ^ -2065639841;
					continue;
				case 163u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)GroupBox1), (Control)(object)DoctorBtn);
					num = (int)(num2 * 1155272588) ^ -1552083606;
					continue;
				case 162u:
					Label1 = Availability.smethod_4();
					num = ((int)num2 * -135918093) ^ 0x5DB6BD4B;
					continue;
				case 161u:
					num = ((int)num2 * -100281630) ^ -747974046;
					continue;
				case 160u:
					Availability.smethod_16((Control)(object)Label5, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Availability.smethod_17((Control)(object)Label5, new Point(389, 123));
					num = ((int)num2 * -432164247) ^ 0x1A8B7FF2;
					continue;
				case 159u:
					Label5 = Availability.smethod_4();
					num = ((int)num2 * -1602700772) ^ -414397203;
					continue;
				case 158u:
					Availability.smethod_11((Control)(object)GroupBox1);
					num = ((int)num2 * -1325575269) ^ 0x3B82DC06;
					continue;
				case 157u:
					Availability.smethod_18((Control)(object)Label5, "Label5");
					num = ((int)num2 * -1586342576) ^ 0x3C70D995;
					continue;
				case 156u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)Label7);
					num = ((int)num2 * -1963714213) ^ -546664299;
					continue;
				case 155u:
					Availability.smethod_18((Control)(object)DesignationTxt, "DesignationTxt");
					Availability.smethod_39((TextBoxBase)(object)DesignationTxt, bool_0: true);
					num = (int)(num2 * 1581566676) ^ -1480600862;
					continue;
				case 154u:
					Availability.smethod_21(Label8, "Name : ");
					num = ((int)num2 * -1468234264) ^ -875428470;
					continue;
				case 153u:
					Availability.smethod_39((TextBoxBase)(object)DOBTxt, bool_0: true);
					Availability.smethod_19((Control)(object)DOBTxt, new Size(128, 28));
					num = (int)((num2 * 1978913745) ^ 0x3C29B2C9);
					continue;
				case 152u:
					Availability.smethod_18((Control)(object)ClearBtn, "ClearBtn");
					num = ((int)num2 * -694226213) ^ 0x1A19A1FB;
					continue;
				case 151u:
					Availability.smethod_16((Control)(object)Label4, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -606355341) ^ -425330659;
					continue;
				case 150u:
					Label8 = Availability.smethod_4();
					AddressTxt = Availability.smethod_8();
					num = (int)((num2 * 95895687) ^ 0x2E8AC191);
					continue;
				case 149u:
					num = (int)(num2 * 736522522) ^ -379552193;
					continue;
				case 148u:
					Availability.smethod_19((Control)(object)MobileTxt, new Size(241, 28));
					Availability.smethod_20((Control)(object)MobileTxt, 12);
					num = ((int)num2 * -1277441350) ^ -1775124831;
					continue;
				case 147u:
					Availability.smethod_19((Control)(object)NameTxt, new Size(241, 28));
					num = ((int)num2 * -780436223) ^ 0x4226D439;
					continue;
				case 146u:
					num = ((int)num2 * -1723801470) ^ -342453338;
					continue;
				case 145u:
					Availability.smethod_18((Control)(object)NameTxt, "NameTxt");
					num = ((int)num2 * -903120937) ^ 0x49BC07C1;
					continue;
				case 144u:
					Availability.smethod_24(Availability.smethod_47((Control)(object)this), (Control)(object)SearchResultGrid);
					num = (int)((num2 * 1200189730) ^ 0x198EE5DC);
					continue;
				case 143u:
					Availability.smethod_13((Control)(object)this);
					num = ((int)num2 * -1962280487) ^ 0x1B12521F;
					continue;
				case 142u:
					Availability.smethod_18((Control)(object)Label7, "Label7");
					num = (int)((num2 * 1585634541) ^ 0x60729125);
					continue;
				case 141u:
					Availability.smethod_19((Control)(object)SearchResultGrid, new Size(853, 169));
					num = ((int)num2 * -1758241417) ^ -2125555199;
					continue;
				case 140u:
					Availability.smethod_17((Control)(object)Label7, new Point(16, 217));
					num = (int)(num2 * 1444102419) ^ -413222607;
					continue;
				case 139u:
					num = ((int)num2 * -372647756) ^ 0x510DB16A;
					continue;
				case 138u:
					Availability.smethod_25(GroupBox1, bool_0: false);
					num = ((int)num2 * -1114957464) ^ 0x7CD0600C;
					continue;
				case 137u:
					Availability.smethod_18((Control)(object)AddressTxt, "AddressTxt");
					num = (int)((num2 * 1253757907) ^ 0x318A9BD1);
					continue;
				case 136u:
					Label6 = Availability.smethod_4();
					num = ((int)num2 * -25269538) ^ -1403804602;
					continue;
				case 135u:
					num = (int)((num2 * 679488264) ^ 0x7CF09DFC);
					continue;
				case 134u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)ShowAvailability);
					num = (int)((num2 * 1777740827) ^ 0x14CD540F);
					continue;
				case 133u:
					Availability.smethod_20((Control)(object)Label2, 0);
					num = (int)((num2 * 1724273653) ^ 0x7EFE3CA3);
					continue;
				case 132u:
					num = (int)(num2 * 1039515225) ^ -1884547907;
					continue;
				case 131u:
					Availability.smethod_19((Control)(object)Label4, new Size(68, 25));
					num = (int)((num2 * 592062581) ^ 0x9B0CA5C);
					continue;
				case 130u:
					num = (int)(num2 * 1475347959) ^ -348287306;
					continue;
				case 129u:
					num = (int)((num2 * 934849200) ^ 0x5F031540);
					continue;
				case 128u:
					Availability.smethod_17((Control)(object)SearchBtn, new Point(467, 73));
					num = (int)((num2 * 1018901301) ^ 0x71241082);
					continue;
				case 127u:
					Availability.smethod_16((Control)(object)NurseBtn, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Availability.smethod_17((Control)(object)NurseBtn, new Point(174, 84));
					num = ((int)num2 * -1978175050) ^ -1781224790;
					continue;
				case 126u:
					Availability.smethod_51((Control)(object)GroupBox1);
					num = ((int)num2 * -1878013062) ^ 0x5D16B4AF;
					continue;
				case 125u:
					num = (int)(num2 * 1966615357) ^ -1521746633;
					continue;
				case 124u:
					Availability.smethod_38((Control)(object)this, Color.White);
					num = (int)(num2 * 469716445) ^ -454160181;
					continue;
				case 123u:
					Availability.smethod_30((ButtonBase)(object)ReceptionistBtn, bool_0: true);
					num = (int)((num2 * 1643970823) ^ 0x66D97600);
					continue;
				case 122u:
					Availability.smethod_24(Availability.smethod_47((Control)(object)this), (Control)(object)DetailsBox);
					num = (int)((num2 * 247276916) ^ 0x5AC40D15);
					continue;
				case 121u:
					num = (int)((num2 * 1875224787) ^ 0x798E1E9);
					continue;
				case 120u:
					Availability.smethod_20((Control)(object)Label6, 2);
					num = (int)((num2 * 1018986635) ^ 0x73FCAE6E);
					continue;
				case 119u:
					num = ((int)num2 * -862312816) ^ -21463268;
					continue;
				case 118u:
					Availability.smethod_16((Control)(object)ReceptionistBtn, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Availability.smethod_17((Control)(object)ReceptionistBtn, new Point(280, 84));
					num = ((int)num2 * -1638000706) ^ -1369534319;
					continue;
				case 117u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)GroupBox1), (Control)(object)SearchBtn);
					Availability.smethod_24(Availability.smethod_23((Control)(object)GroupBox1), (Control)(object)NameSTxt);
					num = (int)(num2 * 1620691979) ^ -1764540647;
					continue;
				case 116u:
					num = ((int)num2 * -764505452) ^ 0x6E42E27F;
					continue;
				case 115u:
					Availability.smethod_39((TextBoxBase)(object)MobileTxt, bool_0: true);
					num = ((int)num2 * -55522824) ^ -1167097549;
					continue;
				case 114u:
					Availability.smethod_20((Control)(object)DoctorBtn, 5);
					num = (int)(num2 * 1907724934) ^ -73327634;
					continue;
				case 113u:
					num = (int)((num2 * 434949738) ^ 0x7D170F65);
					continue;
				case 112u:
					Availability.smethod_31((ButtonBase)(object)DoctorBtn, bool_0: true);
					Availability.smethod_16((Control)(object)DoctorBtn, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Availability.smethod_17((Control)(object)DoctorBtn, new Point(65, 84));
					num = (int)((num2 * 905069233) ^ 0x2B28F624);
					continue;
				case 111u:
					DetailsBox = Availability.smethod_5();
					num = (int)((num2 * 1813212725) ^ 0x26E98070);
					continue;
				case 110u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)Label5);
					num = ((int)num2 * -175055378) ^ -818456074;
					continue;
				case 109u:
					Availability.smethod_19((Control)(object)DetailsBox, new Size(623, 313));
					num = (int)(num2 * 632150271) ^ -1206620362;
					continue;
				case 108u:
					num = (int)((num2 * 1044022373) ^ 0x5BB08329);
					continue;
				case 107u:
					Availability.smethod_19((Control)(object)GenderTxt, new Size(128, 28));
					num = ((int)num2 * -625737228) ^ 0x4DF84235;
					continue;
				case 106u:
					Availability.smethod_20((Control)(object)Label4, 0);
					num = ((int)num2 * -323966638) ^ 0x4CBA14A1;
					continue;
				case 105u:
					Availability.smethod_16((Control)(object)Label8, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1635857554) ^ 0x1A42BFEA;
					continue;
				case 104u:
					Availability.smethod_31((ButtonBase)(object)NurseBtn, bool_0: true);
					num = (int)((num2 * 2086628011) ^ 0x3D9C0BA6);
					continue;
				case 103u:
					Availability.smethod_22(Label9, (ContentAlignment)32);
					Availability.smethod_17((Control)(object)NameTxt, new Point(124, 123));
					num = (int)(num2 * 178306175) ^ -2089466209;
					continue;
				case 102u:
					Availability.smethod_20((Control)(object)GroupBox1, 7);
					num = (int)((num2 * 1526081794) ^ 0x1827A203);
					continue;
				case 101u:
					Availability.smethod_20((Control)(object)SearchBtn, 4);
					Availability.smethod_29((ButtonBase)(object)SearchBtn, "Search");
					num = ((int)num2 * -545431249) ^ -333591127;
					continue;
				case 100u:
					ReceptionistBtn = Availability.smethod_7();
					num = (int)((num2 * 809749312) ^ 0x2D8460B9);
					continue;
				case 99u:
					Availability.smethod_22(Label3, (ContentAlignment)32);
					num = ((int)num2 * -1764405215) ^ -530387232;
					continue;
				case 98u:
					Availability.smethod_20((Control)(object)DOBTxt, 5);
					Availability.smethod_17((Control)(object)SIDTxt, new Point(124, 77));
					num = (int)((num2 * 889719357) ^ 0x52299C07);
					continue;
				case 97u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)MobileTxt);
					num = ((int)num2 * -698439814) ^ -1034944299;
					continue;
				case 96u:
					NameTxt = Availability.smethod_8();
					num = ((int)num2 * -1944362420) ^ 0x40E70077;
					continue;
				case 95u:
					Availability.smethod_50((Control)(object)GroupBox1, bool_0: false);
					num = ((int)num2 * -252210194) ^ -2036235663;
					continue;
				case 94u:
					Availability.smethod_26(DetailsBox, "Staff Member Detail");
					Availability.smethod_38((Control)(object)ShowAvailability, Color.Red);
					Availability.smethod_17((Control)(object)ShowAvailability, new Point(389, 24));
					Availability.smethod_18((Control)(object)ShowAvailability, "ShowAvailability");
					Availability.smethod_19((Control)(object)ShowAvailability, new Size(218, 23));
					Availability.smethod_20((Control)(object)ShowAvailability, 15);
					Availability.smethod_21(ShowAvailability, "UnAvailable");
					num = ((int)num2 * -1842129267) ^ 0x63E2F998;
					continue;
				case 93u:
					Availability.smethod_21(Label5, "D.O.B. :");
					num = (int)((num2 * 300305331) ^ 0x55E7D7AD);
					continue;
				case 92u:
					Availability.smethod_50((Control)(object)DetailsBox, bool_0: false);
					num = ((int)num2 * -1418919099) ^ 0x1C01495C;
					continue;
				case 91u:
					Availability.smethod_19((Control)(object)Label1, new Size(270, 35));
					num = (int)(num2 * 1051790967) ^ -284590193;
					continue;
				case 90u:
					num = (int)(num2 * 340325849) ^ -612690709;
					continue;
				case 89u:
					Availability.smethod_18((Control)(object)NameSTxt, "NameSTxt");
					num = (int)((num2 * 393564113) ^ 0x125CB2BE);
					continue;
				case 88u:
					num = ((int)num2 * -631351339) ^ -480391421;
					continue;
				case 87u:
					num = (int)((num2 * 1105631714) ^ 0x71E3989E);
					continue;
				case 86u:
					Label9 = Availability.smethod_4();
					num = ((int)num2 * -1365877766) ^ -1872397781;
					continue;
				case 85u:
					num = ((int)num2 * -1131756134) ^ -2029929430;
					continue;
				case 84u:
					Availability.smethod_20((Control)(object)NameSTxt, 1);
					num = ((int)num2 * -1324685672) ^ 0x712E296E;
					continue;
				case 83u:
					Availability.smethod_39((TextBoxBase)(object)NameTxt, bool_0: true);
					num = ((int)num2 * -1361069513) ^ -1678754532;
					continue;
				case 82u:
					num = (int)(num2 * 1404924444) ^ -1609929696;
					continue;
				case 81u:
					Availability.smethod_18((Control)(object)DOBTxt, "DOBTxt");
					num = ((int)num2 * -1829539101) ^ 0x49E8121F;
					continue;
				case 80u:
					Availability.smethod_24(Availability.smethod_47((Control)(object)this), (Control)(object)PictureBox1);
					Availability.smethod_48((Control)(object)this, "Availability");
					num = ((int)num2 * -1216138947) ^ 0x16203779;
					continue;
				case 79u:
					num = (int)(num2 * 1175169865) ^ -980313097;
					continue;
				case 78u:
					num = (int)((num2 * 1061230554) ^ 0x107F45D3);
					continue;
				case 77u:
					Availability.smethod_16((Control)(object)ClearBtn, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1344591733) ^ -794725845;
					continue;
				case 76u:
					Availability.smethod_40(AddressTxt, bool_0: true);
					num = (int)((num2 * 705174629) ^ 0x5CA1AA7D);
					continue;
				case 75u:
					Availability.smethod_52((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -1642435481) ^ -406153065;
					continue;
				case 74u:
					num = ((int)num2 * -1369526338) ^ -751667615;
					continue;
				case 73u:
					num = ((int)num2 * -94268607) ^ -1023115636;
					continue;
				case 72u:
					Availability.smethod_19((Control)(object)Label9, new Size(77, 28));
					Availability.smethod_20((Control)(object)Label9, 11);
					num = ((int)num2 * -1098731010) ^ -584517432;
					continue;
				case 71u:
					SearchBtn = Availability.smethod_6();
					num = ((int)num2 * -1256512104) ^ 0x46DDCEFF;
					continue;
				case 70u:
					num = ((int)num2 * -159884655) ^ 0x716685C0;
					continue;
				case 69u:
					Availability.smethod_18((Control)(object)Label4, "Label4");
					num = (int)(num2 * 745436481) ^ -188846889;
					continue;
				case 68u:
					num = (int)(num2 * 151808404) ^ -1849775543;
					continue;
				case 67u:
					num = ((int)num2 * -1904415859) ^ 0x41942E61;
					continue;
				case 66u:
					Availability.smethod_18((Control)(object)GenderTxt, "GenderTxt");
					num = ((int)num2 * -1796143437) ^ -1405004682;
					continue;
				case 65u:
					Availability.smethod_32(ReceptionistBtn, bool_0: true);
					num = (int)(num2 * 1893261952) ^ -1970411674;
					continue;
				case 64u:
					Availability.smethod_18((Control)(object)SearchBtn, "SearchBtn");
					Availability.smethod_19((Control)(object)SearchBtn, new Size(133, 37));
					num = (int)(num2 * 1314490858) ^ -368407844;
					continue;
				case 63u:
					num = (int)(num2 * 607950626) ^ -341704797;
					continue;
				case 62u:
					Availability.smethod_19((Control)(object)ClearBtn, new Size(133, 37));
					Availability.smethod_20((Control)(object)ClearBtn, 8);
					num = (int)(num2 * 224558411) ^ -530565007;
					continue;
				case 61u:
					Availability.smethod_32(DoctorBtn, bool_0: true);
					num = (int)((num2 * 812123835) ^ 0x3D626304);
					continue;
				case 60u:
					Availability.smethod_24(Availability.smethod_47((Control)(object)this), (Control)(object)GroupBox1);
					num = (int)((num2 * 146067546) ^ 0x6068D074);
					continue;
				case 59u:
					Availability.smethod_17((Control)(object)Label2, new Point(37, 44));
					num = ((int)num2 * -714722909) ^ -1407478276;
					continue;
				case 58u:
					Availability.smethod_17((Control)(object)SearchResultGrid, new Point(59, 295));
					num = ((int)num2 * -1122201664) ^ 0x65696285;
					continue;
				case 57u:
					Availability.smethod_20((Control)(object)Label1, 5);
					num = (int)((num2 * 231172133) ^ 0xA46DDCE);
					continue;
				case 56u:
					Availability.smethod_19((Control)(object)Label8, new Size(77, 28));
					num = ((int)num2 * -1802073141) ^ -495383194;
					continue;
				case 55u:
					num = (int)((num2 * 8172356) ^ 0x48CB445E);
					continue;
				case 54u:
					Availability.smethod_21(Label4, "SID :");
					Availability.smethod_41(PictureBox1, (Image)(object)Resources.images);
					num = ((int)num2 * -560874224) ^ 0x2EA42B75;
					continue;
				case 53u:
					Availability.smethod_22(Label2, (ContentAlignment)32);
					num = (int)(num2 * 17141462) ^ -1428132361;
					continue;
				case 52u:
					Availability.smethod_29((ButtonBase)(object)DoctorBtn, "Doctor");
					num = (int)((num2 * 1636377893) ^ 0x53433640);
					continue;
				case 51u:
					Availability.smethod_43(PictureBox1, 4);
					num = (int)(num2 * 570267160) ^ -633194888;
					continue;
				case 50u:
					Availability.smethod_17((Control)(object)Label1, new Point(392, 63));
					Availability.smethod_18((Control)(object)Label1, "Label1");
					num = ((int)num2 * -1701574395) ^ -664639137;
					continue;
				case 49u:
					Availability.smethod_17((Control)(object)Label8, new Point(20, 124));
					num = (int)(num2 * 263088266) ^ -1162509264;
					continue;
				case 48u:
					Availability.smethod_39((TextBoxBase)(object)GenderTxt, bool_0: true);
					num = ((int)num2 * -1912016764) ^ 0x498F2CF0;
					continue;
				case 47u:
					Availability.smethod_17((Control)(object)Label3, new Point(291, 72));
					num = ((int)num2 * -620659111) ^ 0x1F839A76;
					continue;
				case 46u:
					Availability.smethod_45((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -185438444) ^ 0x2D9AE671;
					continue;
				case 45u:
					Availability.smethod_18((Control)(object)Label6, "Label6");
					num = ((int)num2 * -1973801321) ^ 0xDF0BE57;
					continue;
				case 44u:
					GenderTxt = Availability.smethod_8();
					DOBTxt = Availability.smethod_8();
					num = ((int)num2 * -1131115717) ^ -1152385013;
					continue;
				case 43u:
					num = ((int)num2 * -1730038855) ^ -808604360;
					continue;
				case 42u:
					Availability.smethod_29((ButtonBase)(object)ClearBtn, "Clear");
					num = ((int)num2 * -1883746917) ^ -1614626736;
					continue;
				case 41u:
					num = ((int)num2 * -1519104805) ^ 0x19A2BE70;
					continue;
				case 40u:
					Availability.smethod_17((Control)(object)Label4, new Point(25, 77));
					num = ((int)num2 * -842144034) ^ 0x72A7A46C;
					continue;
				case 39u:
					Availability.smethod_22(Label8, (ContentAlignment)32);
					Availability.smethod_17((Control)(object)AddressTxt, new Point(124, 217));
					num = (int)((num2 * 370515129) ^ 0x2ECDBF4A);
					continue;
				case 38u:
					num = ((int)num2 * -574525613) ^ 0x46FBCFC;
					continue;
				case 37u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)GroupBox1), (Control)(object)NurseBtn);
					num = (int)((num2 * 1438112341) ^ 0x75CB188F);
					continue;
				case 36u:
					num = (int)(num2 * 1197047972) ^ -1760005059;
					continue;
				case 35u:
					Availability.smethod_39((TextBoxBase)(object)SIDTxt, bool_0: true);
					num = ((int)num2 * -1597713568) ^ 0x2FB1E2D2;
					continue;
				case 34u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)GroupBox1), (Control)(object)ClearBtn);
					Availability.smethod_24(Availability.smethod_23((Control)(object)GroupBox1), (Control)(object)ReceptionistBtn);
					num = ((int)num2 * -278455623) ^ 0x547678EC;
					continue;
				case 33u:
					Availability.smethod_19((Control)(object)Label5, new Size(84, 26));
					Availability.smethod_20((Control)(object)Label5, 1);
					num = (int)((num2 * 1808519163) ^ 0x5095A49F);
					continue;
				case 32u:
					Availability.smethod_44(PictureBox1, bool_0: false);
					num = (int)(num2 * 1024324073) ^ -408260793;
					continue;
				case 31u:
					Availability.smethod_16((Control)(object)Label3, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1270717837) ^ 0x10803279);
					continue;
				case 30u:
					Availability.smethod_30((ButtonBase)(object)ClearBtn, bool_0: false);
					Availability.smethod_31((ButtonBase)(object)ReceptionistBtn, bool_0: true);
					num = ((int)num2 * -405220914) ^ -937502797;
					continue;
				case 29u:
					num = (int)((num2 * 637815365) ^ 0x5BF95301);
					continue;
				case 28u:
					MobileTxt = Availability.smethod_8();
					num = ((int)num2 * -161456462) ^ -905319561;
					continue;
				case 27u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)SIDTxt);
					num = (int)(num2 * 1570907551) ^ -552243424;
					continue;
				case 26u:
					Availability.smethod_20((Control)(object)SIDTxt, 4);
					num = ((int)num2 * -833493252) ^ 0x597DB4E2;
					continue;
				case 25u:
					num = (int)(num2 * 1271782540) ^ -1144306755;
					continue;
				case 24u:
					Availability.smethod_19((Control)(object)Label6, new Size(84, 26));
					num = ((int)num2 * -1827240782) ^ -682494707;
					continue;
				case 23u:
					SearchResultGrid = Availability.smethod_9();
					num = ((int)num2 * -1950859530) ^ -937672804;
					continue;
				case 22u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)NameTxt);
					num = (int)(num2 * 681271262) ^ -1858930213;
					continue;
				case 21u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)GroupBox1), (Control)(object)Label2);
					num = (int)(num2 * 2127884079) ^ -1832538774;
					continue;
				case 20u:
					NameSTxt = Availability.smethod_8();
					num = (int)(num2 * 1382714104) ^ -129973597;
					continue;
				case 19u:
					num = (int)((num2 * 1455331022) ^ 0x12EC3803);
					continue;
				case 18u:
					GroupBox1 = Availability.smethod_5();
					num = ((int)num2 * -1168827574) ^ -347349552;
					continue;
				case 17u:
					num = (int)(num2 * 1085458328) ^ -1367886091;
					continue;
				case 16u:
					Availability.smethod_17((Control)(object)Label6, new Point(389, 169));
					num = (int)((num2 * 1091590106) ^ 0x64560C4C);
					continue;
				case 15u:
					Availability.smethod_18((Control)(object)DetailsBox, "DetailsBox");
					num = ((int)num2 * -154363147) ^ -93218393;
					continue;
				case 14u:
					num = (int)((num2 * 2093181022) ^ 0x185E7E40);
					continue;
				case 12u:
					Availability.smethod_16((Control)(object)Label9, Availability.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -2092896557) ^ -2028990719;
					continue;
				case 11u:
					num = ((int)num2 * -68412443) ^ -1786622114;
					continue;
				case 10u:
					num = (int)((num2 * 1158956444) ^ 0x50ECA61D);
					continue;
				case 9u:
					num = (int)((num2 * 785996970) ^ 0x4FD2650A);
					continue;
				case 8u:
					Availability.smethod_20((Control)(object)DesignationTxt, 14);
					num = ((int)num2 * -2139053093) ^ -938679604;
					continue;
				case 7u:
					Availability.smethod_53((Control)(object)this, bool_0: false);
					num = ((int)num2 * -2139572394) ^ -456217407;
					continue;
				case 6u:
					Availability.smethod_35(SearchResultGrid, bool_0: true);
					Availability.smethod_37(Availability.smethod_36(SearchResultGrid), 24);
					num = (int)((num2 * 643440838) ^ 0x71ED3F50);
					continue;
				case 5u:
					num = (int)(num2 * 1884666575) ^ -1767308000;
					continue;
				case 4u:
					num = (int)(num2 * 690891336) ^ -1776687265;
					continue;
				case 3u:
					Availability.smethod_24(Availability.smethod_23((Control)(object)DetailsBox), (Control)(object)Label4);
					num = ((int)num2 * -825539189) ^ -305136637;
					continue;
				case 2u:
					Availability.smethod_18((Control)(object)Label8, "Label8");
					num = (int)(num2 * 1242410283) ^ -2102158828;
					continue;
				case 1u:
					Label2 = Availability.smethod_4();
					num = (int)((num2 * 1976214566) ^ 0x4393F03E);
					continue;
				case 0u:
					ShowAvailability = Availability.smethod_4();
					num = ((int)num2 * -399576921) ^ 0x53674EF3;
					continue;
				default:
					return;
				case 196u:
					break;
				case 13u:
					return;
				}
				break;
			}
		}
	}

	private void Availability_Load(object sender, EventArgs e)
	{
		Availability.smethod_62(myconnection, Availability.smethod_61(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
		while (true)
		{
			int num = 929223763;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2A2DCFAEu) % 3u)
				{
				case 1u:
					goto IL_0030;
				case 2u:
					break;
				default:
					Designation = "";
					close();
					return;
				}
				break;
				IL_0030:
				num = ((int)num2 * -1209979243) ^ -1874155931;
			}
		}
	}

	private void SearchBtn_Click(object sender, EventArgs e)
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected I4, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected I4, but got Unknown
		//IL_02b8: Incompatible stack heights: 0 vs 1
		//IL_02d3: Incompatible stack heights: 0 vs 1
		//IL_02e3: Incompatible stack heights: 0 vs 1
		//IL_02ea: Incompatible stack heights: 0 vs 1
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		close();
		bool flag = Availability.smethod_63(Designation, "", bool_0: false) == 0;
		bool flag2 = default(bool);
		OleDbDataAdapter dbDataAdapter_ = default(OleDbDataAdapter);
		while (true)
		{
			int num = 1885192373;
			while (true)
			{
				int num6;
				uint num2;
				switch ((num2 = (uint)num ^ 0x4F6EB174u) % 4u)
				{
				case 1u:
				{
					int num7;
					if (flag)
					{
						num6 = -1102314286;
						num7 = -1102314286;
					}
					else
					{
						num6 = -339847301;
						num7 = -339847301;
					}
					goto IL_0036;
				}
				case 0u:
					break;
				case 2u:
					Availability.smethod_64("click designation");
					return;
				default:
					try
					{
						DataTable dataTable_ = Availability.smethod_65();
						while (true)
						{
							int num3 = 289333468;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x4F6EB174u) % 15u)
								{
								case 14u:
									Availability.smethod_77((Control)(object)SearchResultGrid);
									Availability.smethod_76(myconnection);
									num3 = ((int)num2 * -1747853297) ^ 0x56290E95;
									continue;
								case 13u:
									flag2 = Availability.smethod_74(SearchResultGrid) == 1;
									num3 = (int)(num2 * 1450749811) ^ -88040434;
									continue;
								case 12u:
									Availability.smethod_76(myconnection);
									num3 = (int)((num2 * 478100752) ^ 0x72EC6E94);
									continue;
								case 10u:
									num3 = 224830547;
									continue;
								case 9u:
									dbDataAdapter_ = Availability.smethod_70(Availability.smethod_69(new string[5]
									{
										"Select * from Staff where Name like '%",
										Availability.smethod_68(NameSTxt),
										"%'  And   Designation = '",
										Designation,
										"'"
									}), myconnection);
									num3 = (int)(num2 * 86840795) ^ -946609569;
									continue;
								case 8u:
									Availability.smethod_73(SearchResultGrid, (object)Availability.smethod_72(dataTable_));
									num3 = ((int)num2 * -1770921407) ^ 0x2CCD3850;
									continue;
								case 7u:
									num3 = ((int)num2 * -1613114562) ^ 0x1AF3E34A;
									continue;
								case 6u:
									num3 = ((int)num2 * -300863321) ^ -501546113;
									continue;
								case 4u:
									Availability.smethod_75("Not Found.", "Result");
									num3 = (int)((num2 * 12858510) ^ 0x3CCB3C59);
									continue;
								case 3u:
									dbDataAdapter_ = Availability.smethod_66();
									Availability.smethod_67(myconnection);
									num3 = (int)((num2 * 811986828) ^ 0x2554CC28);
									continue;
								case 2u:
								{
									int num4;
									int num5;
									if (!flag2)
									{
										num4 = 871465569;
										num5 = 871465569;
									}
									else
									{
										num4 = 1139079492;
										num5 = 1139079492;
									}
									num3 = num4 ^ (int)(num2 * 422243746);
									continue;
								}
								case 1u:
									Availability.smethod_71((DbDataAdapter)(object)dbDataAdapter_, dataTable_);
									num3 = (int)(num2 * 153420479) ^ -1777642827;
									continue;
								case 11u:
									break;
								case 0u:
									return;
								default:
									HideunusedColumns();
									return;
								}
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						Availability.smethod_78(exception_);
						while (true)
						{
							_ = 85752047;
							while (true)
							{
								_003F val = /*Error near IL_028a: Stack underflow*/^ 0x4F6EB174;
								num2 = (uint)(int)val;
								switch (val % 5)
								{
								case 4:
									_ = ((int)num2 * -250525379) ^ -1594731149;
									continue;
								case 3:
									Availability.smethod_76(myconnection);
									_ = (num2 * 771623206) ^ 0xA4208D14u;
									continue;
								case 2:
									_ = ((int)num2 * -961841324) ^ 0x25A22D25;
									continue;
								case 0:
									break;
								default:
									Availability.smethod_64("Incorrect Credentials");
									Availability.smethod_79();
									return;
								}
								break;
							}
						}
					}
				}
				break;
				IL_0036:
				num = num6 ^ (int)(num2 * 284108296);
			}
		}
	}

	private bool HideunusedColumns()
	{
		bool result = default(bool);
		while (true)
		{
			int num = -1418707486;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8690858Au) % 6u)
				{
				case 4u:
					num = ((int)num2 * -1897694171) ^ -546430655;
					continue;
				case 3u:
					num = (int)((num2 * 1425336695) ^ 0x32780CFD);
					continue;
				case 2u:
					Availability.smethod_82(Availability.smethod_81(Availability.smethod_80(SearchResultGrid), 7), bool_0: false);
					Availability.smethod_82(Availability.smethod_81(Availability.smethod_80(SearchResultGrid), 9), bool_0: false);
					num = (int)((num2 * 673441560) ^ 0x106F763A);
					continue;
				case 1u:
					result = false;
					num = ((int)num2 * -802514139) ^ -617034444;
					continue;
				case 5u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private void RadioButton1_CheckedChanged(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 258320963;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x86FB3E5u) % 3u)
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
				Designation = "Doctor";
				num = ((int)num2 * -11492744) ^ 0x66C302F0;
			}
		}
	}

	private void RadioButton2_CheckedChanged(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1275101857;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x36419DB5u) % 3u)
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
				Designation = "Nurse";
				num = ((int)num2 * -938026339) ^ -2090335636;
			}
		}
	}

	private void RadioButton3_CheckedChanged(object sender, EventArgs e)
	{
		Designation = "Receptionist";
	}

	private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected I4, but got Unknown
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected I4, but got Unknown
		//IL_0403: Incompatible stack heights: 0 vs 1
		//IL_040a: Incompatible stack heights: 0 vs 1
		bool flag = (checked(Availability.smethod_83(e) + 1) == Availability.smethod_74(SearchResultGrid)) | (Availability.smethod_83(e) == -1);
		int int_ = default(int);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1169832211;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2641E715u) % 7u)
				{
				case 6u:
					int_ = Availability.smethod_83(e);
					num = ((int)num2 * -523028257) ^ -502707696;
					continue;
				case 4u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = -1371323818;
						num7 = -1371323818;
					}
					else
					{
						num6 = -669607109;
						num7 = -669607109;
					}
					num = num6 ^ ((int)num2 * -1147203042);
					continue;
				}
				case 2u:
					num = 824373827;
					continue;
				case 0u:
					Availability.smethod_84((Control)(object)DetailsBox, bool_0: true);
					num = ((int)num2 * -1833423340) ^ 0xEB6A18C;
					continue;
				case 3u:
					break;
				default:
					try
					{
						DataGridViewRow dataGridViewRow_ = Availability.smethod_85();
						while (true)
						{
							int num3 = 2051012099;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x2641E715u) % 22u)
								{
								case 21u:
									num3 = ((int)num2 * -1294154986) ^ 0xD5D0568;
									continue;
								case 20u:
									num3 = (int)((num2 * 1577917611) ^ 0x1A725209);
									continue;
								case 19u:
								{
									int num4;
									int num5;
									if (flag2)
									{
										num4 = -1284102620;
										num5 = -1284102620;
									}
									else
									{
										num4 = -1183201815;
										num5 = -1183201815;
									}
									num3 = num4 ^ (int)(num2 * 1514990626);
									continue;
								}
								case 18u:
									Availability.smethod_92(MobileTxt, Availability.smethod_91(Availability.smethod_90(Availability.smethod_89(Availability.smethod_88(dataGridViewRow_), 5))));
									num3 = ((int)num2 * -83291138) ^ 0x739F9AB5;
									continue;
								case 16u:
									Availability.smethod_92(DesignationTxt, Availability.smethod_91(Availability.smethod_90(Availability.smethod_89(Availability.smethod_88(dataGridViewRow_), 2))));
									num3 = ((int)num2 * -1216695146) ^ 0x273E5C64;
									continue;
								case 15u:
									num3 = (int)((num2 * 1257579476) ^ 0x2BBCE15F);
									continue;
								case 14u:
									num3 = 2059239056;
									continue;
								case 13u:
									Availability.smethod_92(DOBTxt, Availability.smethod_93(Availability.smethod_90(Availability.smethod_89(Availability.smethod_88(dataGridViewRow_), 3))));
									num3 = ((int)num2 * -627578484) ^ 0x6FA55782;
									continue;
								case 12u:
									Availability.smethod_92(NameTxt, Availability.smethod_91(Availability.smethod_90(Availability.smethod_89(Availability.smethod_88(dataGridViewRow_), 1))));
									num3 = ((int)num2 * -637406495) ^ -1877328208;
									continue;
								case 11u:
									Availability.smethod_92(SIDTxt, Availability.smethod_91(Availability.smethod_90(Availability.smethod_89(Availability.smethod_88(dataGridViewRow_), 0))));
									num3 = (int)((num2 * 1066530170) ^ 0x639F23D);
									continue;
								case 10u:
									num3 = ((int)num2 * -893437953) ^ -1712969294;
									continue;
								case 9u:
									colourred();
									num3 = (int)(num2 * 98107392) ^ -2049341368;
									continue;
								case 8u:
									Availability.smethod_92(AddressTxt, Availability.smethod_91(Availability.smethod_90(Availability.smethod_89(Availability.smethod_88(dataGridViewRow_), 6))));
									num3 = (int)((num2 * 216498851) ^ 0x1FAB198F);
									continue;
								case 7u:
									Availability.smethod_92(GenderTxt, Availability.smethod_91(Availability.smethod_90(Availability.smethod_89(Availability.smethod_88(dataGridViewRow_), 4))));
									num3 = (int)(num2 * 304984655) ^ -1261895863;
									continue;
								case 6u:
									dataGridViewRow_ = Availability.smethod_87(Availability.smethod_86(SearchResultGrid), int_);
									num3 = (int)((num2 * 611598003) ^ 0xEE8D576);
									continue;
								case 5u:
									num3 = (int)(num2 * 1406331201) ^ -114889690;
									continue;
								case 4u:
									num3 = ((int)num2 * -1478479894) ^ 0x2A92E7AB;
									continue;
								case 3u:
									colourgreen();
									num3 = ((int)num2 * -222987457) ^ 0x3492A300;
									continue;
								case 2u:
									num3 = ((int)num2 * -444302133) ^ 0xD9B3E9C;
									continue;
								case 1u:
									flag2 = Availability.smethod_94((object)Shift(), Availability.smethod_90(Availability.smethod_89(Availability.smethod_88(dataGridViewRow_), 8)), bool_0: false);
									num3 = ((int)num2 * -1167807920) ^ -2012828312;
									continue;
								default:
									return;
								case 0u:
									break;
								case 17u:
									return;
								}
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						Availability.smethod_78(exception_);
						while (true)
						{
							_ = 1350133944;
							while (true)
							{
								_003F val = /*Error near IL_03dd: Stack underflow*/^ 0x2641E715;
								num2 = (uint)(int)val;
								switch (val % 3)
								{
								case 1:
									_ = ((int)num2 * -712806222) ^ 0x3469A995;
									continue;
								case 0:
									break;
								default:
									Availability.smethod_79();
									return;
								}
								break;
							}
						}
					}
				case 5u:
					return;
				}
				break;
			}
		}
	}

	private void close()
	{
		Availability.smethod_84((Control)(object)DetailsBox, bool_0: false);
		while (true)
		{
			int num = -136165589;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF07DFBCEu) % 4u)
				{
				case 1u:
					Availability.smethod_95((Control)(object)SearchResultGrid);
					num = ((int)num2 * -1982183958) ^ -845015104;
					continue;
				case 0u:
					num = (int)((num2 * 1179829085) ^ 0x2CF8A171);
					continue;
				default:
					return;
				case 2u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1520888332;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD2BDA6A9u) % 13u)
				{
				case 12u:
					num = ((int)num2 * -2116717826) ^ -40795732;
					continue;
				case 11u:
					Availability.smethod_96((TextBoxBase)(object)NameSTxt);
					num = (int)(num2 * 1864969871) ^ -16611123;
					continue;
				case 10u:
					Availability.smethod_97(ReceptionistBtn, bool_0: false);
					num = (int)((num2 * 806807688) ^ 0x4738181C);
					continue;
				case 9u:
					num = (int)(num2 * 345679415) ^ -186927513;
					continue;
				case 7u:
					num = ((int)num2 * -1497876095) ^ 0x22F223A3;
					continue;
				case 6u:
					Availability.smethod_95((Control)(object)SearchResultGrid);
					num = ((int)num2 * -864855104) ^ -912344084;
					continue;
				case 5u:
					Designation = "";
					num = (int)((num2 * 1351973497) ^ 0x2DC3F4B);
					continue;
				case 4u:
					Availability.smethod_97(NurseBtn, bool_0: false);
					num = ((int)num2 * -1077636398) ^ 0x60AE76D;
					continue;
				case 2u:
					Availability.smethod_97(DoctorBtn, bool_0: false);
					num = (int)((num2 * 967143669) ^ 0x7591CE01);
					continue;
				case 1u:
					num = (int)((num2 * 694153669) ^ 0x7C38C1F2);
					continue;
				case 0u:
					Availability.smethod_84((Control)(object)DetailsBox, bool_0: false);
					num = (int)(num2 * 1478804294) ^ -2058095759;
					continue;
				default:
					return;
				case 8u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	private string Shift()
	{
		string result = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = -1735054144;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB0C6F42Bu) % 8u)
				{
				case 7u:
					result = "Night";
					num = (int)(num2 * 1902004329) ^ -1094478431;
					continue;
				case 6u:
					num = -91828188;
					continue;
				case 4u:
					result = "Day";
					num = (int)((num2 * 967669847) ^ 0x743E096);
					continue;
				case 3u:
					flag = (day >= 7) & (day <= 19);
					num = ((int)num2 * -508326922) ^ -947191397;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1109707719;
						num4 = 1109707719;
					}
					else
					{
						num3 = 30197917;
						num4 = 30197917;
					}
					num = num3 ^ (int)(num2 * 2087338940);
					continue;
				}
				case 1u:
					num = (int)((num2 * 1308910060) ^ 0x38501EAA);
					continue;
				case 0u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private void colourgreen()
	{
		Availability.smethod_38((Control)(object)ShowAvailability, Color.Green);
		Availability.smethod_21(ShowAvailability, "Available");
		while (true)
		{
			int num = -1993052132;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBFB4021Fu) % 3u)
				{
				case 2u:
					goto IL_0022;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0022:
				num = (int)((num2 * 196816136) ^ 0x5537BCF4);
			}
		}
	}

	private void colourred()
	{
		Availability.smethod_38((Control)(object)ShowAvailability, Color.Red);
		while (true)
		{
			int num = -2104215483;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x906A9810u) % 5u)
				{
				case 4u:
					num = ((int)num2 * -1740102005) ^ -1438957177;
					continue;
				case 3u:
					Availability.smethod_21(ShowAvailability, "Unavailable");
					num = (int)(num2 * 1403458348) ^ -1006835515;
					continue;
				case 2u:
					num = (int)(num2 * 148457327) ^ -2097759479;
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

	static int smethod_2(string string_0)
	{
		return Conversions.ToInteger(string_0);
	}

	static void smethod_3(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
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

	static Button smethod_6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static RadioButton smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new RadioButton();
	}

	static TextBox smethod_8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static DataGridView smethod_9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DataGridView();
	}

	static PictureBox smethod_10()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PictureBox();
	}

	static void smethod_11(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_12(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_13(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_14(Label label_0, bool bool_0)
	{
		label_0.set_AutoSize(bool_0);
	}

	static Font smethod_15(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_16(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_17(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_18(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_19(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_20(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_21(Label label_0, string string_0)
	{
		label_0.set_Text(string_0);
	}

	static void smethod_22(Label label_0, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_TextAlign(contentAlignment_0);
	}

	static ControlCollection smethod_23(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_24(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_25(GroupBox groupBox_0, bool bool_0)
	{
		groupBox_0.set_TabStop(bool_0);
	}

	static void smethod_26(GroupBox groupBox_0, string string_0)
	{
		groupBox_0.set_Text(string_0);
	}

	static void smethod_27(ButtonBase buttonBase_0, Color color_0)
	{
		buttonBase_0.set_BackColor(color_0);
	}

	static void smethod_28(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
	}

	static void smethod_29(ButtonBase buttonBase_0, string string_0)
	{
		buttonBase_0.set_Text(string_0);
	}

	static void smethod_30(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_31(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_AutoSize(bool_0);
	}

	static void smethod_32(RadioButton radioButton_0, bool bool_0)
	{
		radioButton_0.set_TabStop(bool_0);
	}

	static void smethod_33(DataGridView dataGridView_0, Color color_0)
	{
		dataGridView_0.set_BackgroundColor(color_0);
	}

	static void smethod_34(DataGridView dataGridView_0, DataGridViewColumnHeadersHeightSizeMode dataGridViewColumnHeadersHeightSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		dataGridView_0.set_ColumnHeadersHeightSizeMode(dataGridViewColumnHeadersHeightSizeMode_0);
	}

	static void smethod_35(DataGridView dataGridView_0, bool bool_0)
	{
		dataGridView_0.set_ReadOnly(bool_0);
	}

	static DataGridViewRow smethod_36(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_RowTemplate();
	}

	static void smethod_37(DataGridViewRow dataGridViewRow_0, int int_0)
	{
		dataGridViewRow_0.set_Height(int_0);
	}

	static void smethod_38(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static void smethod_39(TextBoxBase textBoxBase_0, bool bool_0)
	{
		textBoxBase_0.set_ReadOnly(bool_0);
	}

	static void smethod_40(TextBox textBox_0, bool bool_0)
	{
		textBox_0.set_Multiline(bool_0);
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

	static ControlCollection smethod_47(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_48(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_49(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_50(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_51(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_52(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_53(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_54(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_55(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_56(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_57(RadioButton radioButton_0, EventHandler eventHandler_0)
	{
		radioButton_0.remove_CheckedChanged(eventHandler_0);
	}

	static void smethod_58(RadioButton radioButton_0, EventHandler eventHandler_0)
	{
		radioButton_0.add_CheckedChanged(eventHandler_0);
	}

	static void smethod_59(DataGridView dataGridView_0, DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler_0)
	{
		dataGridView_0.remove_CellMouseClick(dataGridViewCellMouseEventHandler_0);
	}

	static void smethod_60(DataGridView dataGridView_0, DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler_0)
	{
		dataGridView_0.add_CellMouseClick(dataGridViewCellMouseEventHandler_0);
	}

	static string smethod_61(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_62(OleDbConnection oleDbConnection_0, string string_0)
	{
		oleDbConnection_0.set_ConnectionString(string_0);
	}

	static int smethod_63(string string_0, string string_1, bool bool_0)
	{
		return Operators.CompareString(string_0, string_1, bool_0);
	}

	static DialogResult smethod_64(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}

	static DataTable smethod_65()
	{
		return new DataTable();
	}

	static OleDbDataAdapter smethod_66()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new OleDbDataAdapter();
	}

	static void smethod_67(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Open();
	}

	static string smethod_68(TextBox textBox_0)
	{
		return textBox_0.get_Text();
	}

	static string smethod_69(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static OleDbDataAdapter smethod_70(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbDataAdapter(string_0, oleDbConnection_0);
	}

	static int smethod_71(DbDataAdapter dbDataAdapter_0, DataTable dataTable_0)
	{
		return dbDataAdapter_0.Fill(dataTable_0);
	}

	static DataView smethod_72(DataTable dataTable_0)
	{
		return dataTable_0.DefaultView;
	}

	static void smethod_73(DataGridView dataGridView_0, object object_0)
	{
		dataGridView_0.set_DataSource(object_0);
	}

	static int smethod_74(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_RowCount();
	}

	static DialogResult smethod_75(string string_0, string string_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0, string_1);
	}

	static void smethod_76(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Close();
	}

	static void smethod_77(Control control_0)
	{
		control_0.Show();
	}

	static void smethod_78(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_79()
	{
		ProjectData.ClearProjectError();
	}

	static DataGridViewColumnCollection smethod_80(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_Columns();
	}

	static DataGridViewColumn smethod_81(DataGridViewColumnCollection dataGridViewColumnCollection_0, int int_0)
	{
		return dataGridViewColumnCollection_0.get_Item(int_0);
	}

	static void smethod_82(DataGridViewColumn dataGridViewColumn_0, bool bool_0)
	{
		dataGridViewColumn_0.set_Visible(bool_0);
	}

	static int smethod_83(DataGridViewCellMouseEventArgs dataGridViewCellMouseEventArgs_0)
	{
		return dataGridViewCellMouseEventArgs_0.get_RowIndex();
	}

	static void smethod_84(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static DataGridViewRow smethod_85()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DataGridViewRow();
	}

	static DataGridViewRowCollection smethod_86(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_Rows();
	}

	static DataGridViewRow smethod_87(DataGridViewRowCollection dataGridViewRowCollection_0, int int_0)
	{
		return dataGridViewRowCollection_0.get_Item(int_0);
	}

	static DataGridViewCellCollection smethod_88(DataGridViewRow dataGridViewRow_0)
	{
		return dataGridViewRow_0.get_Cells();
	}

	static DataGridViewCell smethod_89(DataGridViewCellCollection dataGridViewCellCollection_0, int int_0)
	{
		return dataGridViewCellCollection_0.get_Item(int_0);
	}

	static object smethod_90(DataGridViewCell dataGridViewCell_0)
	{
		return dataGridViewCell_0.get_Value();
	}

	static string smethod_91(object object_0)
	{
		return object_0.ToString();
	}

	static void smethod_92(TextBox textBox_0, string string_0)
	{
		textBox_0.set_Text(string_0);
	}

	static string smethod_93(object object_0)
	{
		return Conversions.ToString(object_0);
	}

	static bool smethod_94(object object_0, object object_1, bool bool_0)
	{
		return Operators.ConditionalCompareObjectEqual(object_0, object_1, bool_0);
	}

	static void smethod_95(Control control_0)
	{
		control_0.Hide();
	}

	static void smethod_96(TextBoxBase textBoxBase_0)
	{
		textBoxBase_0.Clear();
	}

	static void smethod_97(RadioButton radioButton_0, bool bool_0)
	{
		radioButton_0.set_Checked(bool_0);
	}
}
