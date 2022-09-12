using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hospital_Management_System.My;
using Hospital_Management_System.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace Hospital_Management_System;

[DesignerGenerated]
public class CheckUp : UserControl
{
	private IContainer components;

	private OleDbConnection myconnection;

	private string mobile;

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
			DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler_ = new DataGridViewCellMouseEventHandler(SearchResultGrid_CellMouseClick);
			DataGridView searchResultGrid = _SearchResultGrid;
			if (searchResultGrid != null)
			{
				goto IL_0017;
			}
			goto IL_0095;
			IL_0095:
			_SearchResultGrid = value;
			searchResultGrid = _SearchResultGrid;
			int num = 624539201;
			goto IL_006c;
			IL_006c:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6AC627C5u) % 6u)
				{
				case 5u:
					break;
				case 3u:
					CheckUp.smethod_52(searchResultGrid, dataGridViewCellMouseEventHandler_);
					num = ((int)num2 * -550235125) ^ 0x495F0325;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (searchResultGrid == null)
					{
						num3 = 1804129625;
						num4 = 1804129625;
					}
					else
					{
						num3 = 280681313;
						num4 = 280681313;
					}
					num = num3 ^ (int)(num2 * 1480500330);
					continue;
				}
				case 0u:
					CheckUp.smethod_53(searchResultGrid, dataGridViewCellMouseEventHandler_);
					num = (int)((num2 * 1074480790) ^ 0x50F712F9);
					continue;
				default:
					return;
				case 1u:
					goto IL_0095;
				case 4u:
					return;
				}
				break;
			}
			goto IL_0017;
			IL_0017:
			num = 1749120262;
			goto IL_006c;
		}
	}

	[field: AccessedThroughProperty("SearchBox")]
	internal virtual GroupBox SearchBox
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("NameSTxt")]
	internal virtual TextBox NameSTxt
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
				int num = 1425975282;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x59F85995u) % 7u)
					{
					case 6u:
						CheckUp.smethod_54((Control)(object)searchBtn, eventHandler_);
						num = ((int)num2 * -1130479670) ^ 0x1736B7AF;
						continue;
					case 5u:
						_SearchBtn = value;
						searchBtn = _SearchBtn;
						num = 465342202;
						continue;
					case 4u:
					{
						int num5;
						int num6;
						if (searchBtn == null)
						{
							num5 = -2125001266;
							num6 = -2125001266;
						}
						else
						{
							num5 = -660330033;
							num6 = -660330033;
						}
						num = num5 ^ ((int)num2 * -941792721);
						continue;
					}
					case 3u:
					{
						searchBtn = _SearchBtn;
						int num3;
						int num4;
						if (searchBtn == null)
						{
							num3 = 59779059;
							num4 = 59779059;
						}
						else
						{
							num3 = 1774506511;
							num4 = 1774506511;
						}
						num = num3 ^ (int)(num2 * 351890840);
						continue;
					}
					case 2u:
						CheckUp.smethod_55((Control)(object)searchBtn, eventHandler_);
						num = ((int)num2 * -842149264) ^ 0x2F63497F;
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
	}

	[field: AccessedThroughProperty("PatientInfoBox")]
	internal virtual GroupBox PatientInfoBox
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

	[field: AccessedThroughProperty("PIDTxt")]
	internal virtual TextBox PIDTxt
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

	[field: AccessedThroughProperty("PaymentBox")]
	internal virtual GroupBox PaymentBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RoomNoTxt")]
	internal virtual TextBox RoomNoTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
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

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TokenNoTxt")]
	internal virtual TextBox TokenNoTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FeesTxt")]
	internal virtual TextBox FeesTxt
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
				int num = 2128525606;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4D1908ECu) % 9u)
					{
					case 8u:
						clearBtn = _ClearBtn;
						num = (int)((num2 * 387947918) ^ 0x3BA4BB64);
						continue;
					case 7u:
					{
						int num5;
						int num6;
						if (clearBtn == null)
						{
							num5 = -681326499;
							num6 = -681326499;
						}
						else
						{
							num5 = -1611780;
							num6 = -1611780;
						}
						num = num5 ^ (int)(num2 * 1891213910);
						continue;
					}
					case 6u:
						CheckUp.smethod_55((Control)(object)clearBtn, eventHandler_);
						num = (int)((num2 * 1558393399) ^ 0x75D3A2A4);
						continue;
					case 5u:
						clearBtn = _ClearBtn;
						num = (int)(num2 * 1259308996) ^ -1633799206;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (clearBtn == null)
						{
							num3 = 652882082;
							num4 = 652882082;
						}
						else
						{
							num3 = 1311376166;
							num4 = 1311376166;
						}
						num = num3 ^ ((int)num2 * -1392889547);
						continue;
					}
					case 2u:
						CheckUp.smethod_54((Control)(object)clearBtn, eventHandler_);
						num = (int)((num2 * 270161358) ^ 0x6CD5FC71);
						continue;
					case 0u:
						_ClearBtn = value;
						num = 1221223886;
						continue;
					default:
						return;
					case 4u:
						break;
					case 1u:
						return;
					}
					break;
				}
			}
		}
	}

	internal virtual Button PrintBtn
	{
		[CompilerGenerated]
		get
		{
			return _PrintBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = PrintBtn_Click;
			Button printBtn = default(Button);
			while (true)
			{
				int num = 600964603;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7FC8744Du) % 7u)
					{
					case 6u:
						CheckUp.smethod_54((Control)(object)printBtn, eventHandler_);
						num = ((int)num2 * -1473799702) ^ -1235064062;
						continue;
					case 5u:
						CheckUp.smethod_55((Control)(object)printBtn, eventHandler_);
						num = (int)(num2 * 2092333055) ^ -1659300814;
						continue;
					case 4u:
						printBtn = _PrintBtn;
						num = (int)((num2 * 687739571) ^ 0x1E863DCE);
						continue;
					case 1u:
					{
						_PrintBtn = value;
						printBtn = _PrintBtn;
						int num5;
						if (printBtn != null)
						{
							num = 1186477374;
							num5 = 1186477374;
						}
						else
						{
							num = 1038529215;
							num5 = 1038529215;
						}
						continue;
					}
					case 0u:
					{
						int num3;
						int num4;
						if (printBtn == null)
						{
							num3 = -1681303892;
							num4 = -1681303892;
						}
						else
						{
							num3 = -2017490444;
							num4 = -2017490444;
						}
						num = num3 ^ (int)(num2 * 1447286332);
						continue;
					}
					default:
						return;
					case 3u:
						break;
					case 2u:
						return;
					}
					break;
				}
			}
		}
	}

	internal virtual PrintDocument PrintDocument1
	{
		[CompilerGenerated]
		get
		{
			return _PrintDocument1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			PrintPageEventHandler printPageEventHandler_ = new PrintPageEventHandler(PrintDocument1_PrintPage);
			PrintDocument printDocument = _PrintDocument1;
			if (printDocument != null)
			{
				goto IL_005e;
			}
			goto IL_00b4;
			IL_00b4:
			_PrintDocument1 = value;
			int num = 228470461;
			goto IL_0087;
			IL_0087:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x485908B4u) % 7u)
				{
				case 6u:
					CheckUp.smethod_56(printDocument, printPageEventHandler_);
					num = ((int)num2 * -484923113) ^ -1991633905;
					continue;
				case 5u:
					printDocument = _PrintDocument1;
					num = (int)(num2 * 220862458) ^ -1434295510;
					continue;
				case 4u:
					CheckUp.smethod_57(printDocument, printPageEventHandler_);
					num = (int)((num2 * 400497601) ^ 0x756E1EAC);
					continue;
				case 3u:
					break;
				case 2u:
				{
					int num3;
					int num4;
					if (printDocument == null)
					{
						num3 = -938381149;
						num4 = -938381149;
					}
					else
					{
						num3 = -1574102917;
						num4 = -1574102917;
					}
					num = num3 ^ ((int)num2 * -1327105226);
					continue;
				}
				default:
					return;
				case 0u:
					goto IL_00b4;
				case 1u:
					return;
				}
				break;
			}
			goto IL_005e;
			IL_005e:
			num = 415250991;
			goto IL_0087;
		}
	}

	[field: AccessedThroughProperty("PrintDialog1")]
	internal virtual PrintDialog PrintDialog1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
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

	public CheckUp()
	{
		CheckUp.smethod_0((UserControl)(object)this, (EventHandler)CheckUp_Load);
		myconnection = CheckUp.smethod_1();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			while (true)
			{
				int num = -884069870;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x81543AAFu) % 8u)
					{
					case 6u:
						num = (int)((num2 * 620384652) ^ 0x382B4666);
						continue;
					case 5u:
						if (disposing)
						{
							num = (int)((num2 * 1360797160) ^ 0x6E0AFAC5);
							continue;
						}
						goto IL_0037;
					case 3u:
						num = ((int)num2 * -1501493176) ^ 0x383DA399;
						continue;
					case 2u:
						if (components != null)
						{
							num = -2089744393;
							num3 = -2089744393;
							continue;
						}
						goto IL_0037;
					case 1u:
						num = -1149695229;
						continue;
					case 0u:
						CheckUp.smethod_2((IDisposable)components);
						num = (int)((num2 * 1063544732) ^ 0x3FF49374);
						continue;
					default:
						return;
					case 7u:
						break;
					case 4u:
						return;
						IL_0037:
						num = -1134045362;
						num3 = -1134045362;
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
				IL_00fe:
				int num4 = -1220337018;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num4 ^ 0x81543AAFu) % 4u)
					{
					case 3u:
						num4 = ((int)num2 * -1151493977) ^ -650919390;
						continue;
					case 1u:
						((ContainerControl)this).Dispose(disposing);
						num4 = ((int)num2 * -2009358079) ^ -622950859;
						continue;
					default:
						goto end_IL_00dd;
					case 2u:
						break;
					case 0u:
						goto end_IL_00dd;
					}
					goto IL_00fe;
					continue;
					end_IL_00dd:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		Label1 = CheckUp.smethod_3();
		SearchResultGrid = CheckUp.smethod_4();
		SearchBox = CheckUp.smethod_5();
		SearchBtn = CheckUp.smethod_6();
		while (true)
		{
			int num = -875762545;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x98269532u) % 334u)
				{
				case 333u:
					Label3 = CheckUp.smethod_3();
					num = ((int)num2 * -1890132075) ^ -701855971;
					continue;
				case 332u:
					num = (int)((num2 * 280529543) ^ 0x5DF4A8F8);
					continue;
				case 331u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PaymentBox), (Control)(object)Label10);
					num = ((int)num2 * -1596726727) ^ -205922149;
					continue;
				case 330u:
					CheckUp.smethod_28(CheckUp.smethod_45((Control)(object)this), (Control)(object)PatientInfoBox);
					num = ((int)num2 * -1850197639) ^ 0x78BB0D62;
					continue;
				case 329u:
					CheckUp.smethod_28(CheckUp.smethod_45((Control)(object)this), (Control)(object)PrintBtn);
					num = (int)((num2 * 1805001980) ^ 0x6BA76C75);
					continue;
				case 328u:
					CheckUp.smethod_33((ButtonBase)(object)ClearBtn, "Clear");
					num = ((int)num2 * -399214845) ^ -10081638;
					continue;
				case 327u:
					num = (int)((num2 * 232275242) ^ 0x31792DA9);
					continue;
				case 326u:
					CheckUp.smethod_17((Control)(object)Label4, "Label4");
					num = ((int)num2 * -81498449) ^ 0x4F24B555;
					continue;
				case 325u:
					num = (int)(num2 * 1688852806) ^ -82333295;
					continue;
				case 324u:
					num = (int)((num2 * 1997273489) ^ 0x4E4B3224);
					continue;
				case 323u:
					CheckUp.smethod_16((Control)(object)TokenNoTxt, new Point(125, 68));
					CheckUp.smethod_17((Control)(object)TokenNoTxt, "TokenNoTxt");
					num = (int)((num2 * 2111195022) ^ 0x449182B5);
					continue;
				case 322u:
					num = (int)(num2 * 1751427613) ^ -214177143;
					continue;
				case 321u:
					CheckUp.smethod_16((Control)(object)Label9, new Point(18, 71));
					num = ((int)num2 * -723777230) ^ 0x75FF8194;
					continue;
				case 320u:
					CheckUp.smethod_18((Control)(object)Label9, new Size(107, 28));
					CheckUp.smethod_19((Control)(object)Label9, 2);
					num = (int)((num2 * 670426749) ^ 0x3FCC4358);
					continue;
				case 319u:
					CheckUp.smethod_21(Label10, (ContentAlignment)32);
					num = ((int)num2 * -257910842) ^ -782179042;
					continue;
				case 318u:
					num = (int)((num2 * 1000099766) ^ 0x4173BF3A);
					continue;
				case 317u:
					num = ((int)num2 * -153473696) ^ -2085262288;
					continue;
				case 316u:
					CheckUp.smethod_20(Label9, "Token No :");
					CheckUp.smethod_21(Label9, (ContentAlignment)32);
					num = ((int)num2 * -1718324106) ^ -1608247363;
					continue;
				case 315u:
					num = (int)(num2 * 355527876) ^ -561011331;
					continue;
				case 314u:
					CheckUp.smethod_34((ButtonBase)(object)ClearBtn, bool_0: false);
					num = ((int)num2 * -1679452986) ^ 0x630EB403;
					continue;
				case 313u:
					num = ((int)num2 * -1374795169) ^ 0x42D3F87E;
					continue;
				case 312u:
					CheckUp.smethod_16((Control)(object)PaymentBox, new Point(589, 485));
					num = (int)(num2 * 1109461296) ^ -1225382805;
					continue;
				case 311u:
					CheckUp.smethod_44((Control)(object)this, Color.White);
					num = ((int)num2 * -147970775) ^ -2036161010;
					continue;
				case 310u:
					num = (int)(num2 * 539770645) ^ -1698041213;
					continue;
				case 309u:
					CheckUp.smethod_19((Control)(object)Label4, 0);
					num = (int)((num2 * 248862951) ^ 0x24E332E8);
					continue;
				case 308u:
					num = ((int)num2 * -1779151110) ^ -820586798;
					continue;
				case 307u:
					CheckUp.smethod_50((Control)(object)SearchBox);
					CheckUp.smethod_49((Control)(object)PatientInfoBox, bool_0: false);
					num = ((int)num2 * -206581953) ^ 0xB5EFDA;
					continue;
				case 306u:
					num = (int)(num2 * 1208018028) ^ -1834965813;
					continue;
				case 305u:
					num = (int)((num2 * 461808) ^ 0x68B236D8);
					continue;
				case 304u:
					CheckUp.smethod_17((Control)(object)Label2, "Label2");
					num = (int)(num2 * 1351803836) ^ -277953333;
					continue;
				case 303u:
					CheckUp.smethod_34((ButtonBase)(object)SearchBtn, bool_0: false);
					num = (int)(num2 * 1315119433) ^ -310444472;
					continue;
				case 302u:
					num = ((int)num2 * -790709069) ^ -489120591;
					continue;
				case 301u:
					num = ((int)num2 * -223597224) ^ 0x6FF1ECE8;
					continue;
				case 300u:
					Label2 = CheckUp.smethod_3();
					num = ((int)num2 * -671984268) ^ -1281006270;
					continue;
				case 299u:
					num = (int)((num2 * 1491378288) ^ 0x3C3F9F87);
					continue;
				case 298u:
					num = (int)((num2 * 2063563530) ^ 0xE12803E);
					continue;
				case 297u:
					CheckUp.smethod_35((TextBoxBase)(object)DOBTxt, bool_0: true);
					num = ((int)num2 * -2099706449) ^ 0x597B2E9A;
					continue;
				case 296u:
					CheckUp.smethod_18((Control)(object)ClearBtn, new Size(119, 44));
					num = ((int)num2 * -1526409581) ^ 0x6E6F0FF7;
					continue;
				case 295u:
					num = (int)(num2 * 1930025213) ^ -514397286;
					continue;
				case 294u:
					num = (int)(num2 * 635744075) ^ -1818248981;
					continue;
				case 293u:
					num = (int)(num2 * 1195391621) ^ -2113752786;
					continue;
				case 292u:
					CheckUp.smethod_35((TextBoxBase)(object)PIDTxt, bool_0: true);
					num = ((int)num2 * -178999379) ^ 0x548B2CDE;
					continue;
				case 291u:
					num = ((int)num2 * -772171820) ^ -1811894540;
					continue;
				case 290u:
					CheckUp.smethod_16((Control)(object)Label7, new Point(20, 159));
					num = ((int)num2 * -412309216) ^ 0x2F7B5D9;
					continue;
				case 289u:
					num = ((int)num2 * -511799069) ^ -267752550;
					continue;
				case 288u:
					CheckUp.smethod_15((Control)(object)FeesTxt, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1028324649) ^ -848343431;
					continue;
				case 287u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)SearchBox), (Control)(object)Label2);
					num = (int)((num2 * 90204561) ^ 0x705018B3);
					continue;
				case 286u:
					CheckUp.smethod_40(PictureBox1, 2);
					num = (int)((num2 * 517716188) ^ 0x3A0A55F9);
					continue;
				case 285u:
					num = (int)(num2 * 1523568330) ^ -1916363463;
					continue;
				case 284u:
					CheckUp.smethod_17((Control)(object)Label8, "Label8");
					CheckUp.smethod_18((Control)(object)Label8, new Size(101, 25));
					num = ((int)num2 * -411031744) ^ 0xFDCE775;
					continue;
				case 283u:
					AddressTxt = CheckUp.smethod_7();
					num = ((int)num2 * -613117527) ^ 0x718047C4;
					continue;
				case 282u:
					num = (int)(num2 * 1854456115) ^ -322889669;
					continue;
				case 281u:
					CheckUp.smethod_28(CheckUp.smethod_45((Control)(object)this), (Control)(object)ClearBtn);
					num = ((int)num2 * -1623989276) ^ -1764744328;
					continue;
				case 280u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)DOBTxt);
					num = ((int)num2 * -1861439485) ^ -277565947;
					continue;
				case 279u:
					CheckUp.smethod_15((Control)(object)Label11, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					CheckUp.smethod_16((Control)(object)Label11, new Point(20, 80));
					num = ((int)num2 * -1083845993) ^ -2160697;
					continue;
				case 278u:
					num = (int)(num2 * 1926407367) ^ -1890818935;
					continue;
				case 277u:
					num = (int)((num2 * 1377534164) ^ 0x201D8DAF);
					continue;
				case 276u:
					CheckUp.smethod_17((Control)(object)PrintBtn, "PrintBtn");
					num = (int)(num2 * 2003151741) ^ -745807645;
					continue;
				case 275u:
					num = (int)(num2 * 861300347) ^ -798835791;
					continue;
				case 274u:
					num = ((int)num2 * -864723955) ^ 0x6790850E;
					continue;
				case 273u:
					num = ((int)num2 * -256956556) ^ -2051371296;
					continue;
				case 272u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)SearchBox), (Control)(object)SearchBtn);
					num = (int)((num2 * 1695695743) ^ 0x5757786F);
					continue;
				case 271u:
					num = ((int)num2 * -1162006678) ^ 0x1955926B;
					continue;
				case 270u:
					CheckUp.smethod_16((Control)(object)SearchBox, new Point(179, 151));
					CheckUp.smethod_17((Control)(object)SearchBox, "SearchBox");
					num = (int)((num2 * 367250212) ^ 0x1989D082);
					continue;
				case 269u:
					CheckUp.smethod_18((Control)(object)Label2, new Size(77, 28));
					num = (int)(num2 * 1291535304) ^ -560025063;
					continue;
				case 268u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)SearchBox), (Control)(object)MobileTxt);
					num = (int)(num2 * 2144200534) ^ -163740414;
					continue;
				case 267u:
					CheckUp.smethod_50((Control)(object)PatientInfoBox);
					num = ((int)num2 * -1272757397) ^ -2107818829;
					continue;
				case 265u:
					CheckUp.smethod_18((Control)(object)Label11, new Size(76, 26));
					num = ((int)num2 * -1934508560) ^ -239536084;
					continue;
				case 264u:
					CheckUp.smethod_16((Control)(object)SearchBtn, new Point(468, 82));
					num = ((int)num2 * -651283617) ^ -2113936988;
					continue;
				case 263u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)SearchBox), (Control)(object)Label3);
					num = (int)((num2 * 205162151) ^ 0x1BCA9F76);
					continue;
				case 262u:
					CheckUp.smethod_17((Control)(object)Label11, "Label11");
					num = (int)((num2 * 1522356099) ^ 0x5837A0F3);
					continue;
				case 261u:
					num = ((int)num2 * -272465056) ^ -1483112040;
					continue;
				case 260u:
					CheckUp.smethod_49((Control)(object)SearchBox, bool_0: false);
					num = (int)(num2 * 468015123) ^ -1465355121;
					continue;
				case 259u:
					CheckUp.smethod_22(SearchResultGrid, Color.White);
					num = ((int)num2 * -540537198) ^ -1177891863;
					continue;
				case 258u:
					num = (int)(num2 * 2079730292) ^ -749427277;
					continue;
				case 257u:
					CheckUp.smethod_20(Label1, "Check-Up");
					num = ((int)num2 * -2132913562) ^ 0x42CAEF08;
					continue;
				case 256u:
					CheckUp.smethod_20(Label6, "Gender : ");
					num = (int)(num2 * 509637130) ^ -250451435;
					continue;
				case 255u:
					CheckUp.smethod_20(Label11, "Name :");
					num = (int)((num2 * 460377775) ^ 0x2A6790DB);
					continue;
				case 254u:
					CheckUp.smethod_18((Control)(object)SearchBtn, new Size(133, 37));
					CheckUp.smethod_19((Control)(object)SearchBtn, 4);
					num = (int)(num2 * 1300926127) ^ -1621398248;
					continue;
				case 253u:
					num = ((int)num2 * -1495091959) ^ -1808517607;
					continue;
				case 252u:
					MobileTxt = CheckUp.smethod_7();
					NameSTxt = CheckUp.smethod_7();
					num = (int)(num2 * 31656817) ^ -1978647958;
					continue;
				case 251u:
					CheckUp.smethod_15((Control)(object)PatientInfoBox, CheckUp.smethod_14("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1981868869) ^ -577266104;
					continue;
				case 250u:
					num = ((int)num2 * -454378051) ^ 0x22059340;
					continue;
				case 249u:
					CheckUp.smethod_16((Control)(object)GenderTxt, new Point(322, 115));
					num = (int)(num2 * 1818760938) ^ -181072030;
					continue;
				case 248u:
					CheckUp.smethod_34((ButtonBase)(object)PrintBtn, bool_0: false);
					num = (int)(num2 * 534954761) ^ -623284351;
					continue;
				case 247u:
					num = (int)((num2 * 1012260328) ^ 0x1B6F6A28);
					continue;
				case 246u:
					num = (int)(num2 * 1202989989) ^ -1877379290;
					continue;
				case 245u:
					CheckUp.smethod_16((Control)(object)ClearBtn, new Point(589, 696));
					num = ((int)num2 * -1993072086) ^ -103929181;
					continue;
				case 244u:
					num = ((int)num2 * -1990049225) ^ 0x20DCA018;
					continue;
				case 243u:
					CheckUp.smethod_16((Control)(object)FeesTxt, new Point(125, 108));
					CheckUp.smethod_17((Control)(object)FeesTxt, "FeesTxt");
					num = (int)((num2 * 898896089) ^ 0x34578A2D);
					continue;
				case 242u:
					CheckUp.smethod_18((Control)(object)PIDTxt, new Size(130, 26));
					num = (int)((num2 * 1622117017) ^ 0x68732903);
					continue;
				case 241u:
					CheckUp.smethod_28(CheckUp.smethod_45((Control)(object)this), (Control)(object)PictureBox1);
					num = ((int)num2 * -295296723) ^ -1190660644;
					continue;
				case 240u:
					PIDTxt = CheckUp.smethod_7();
					num = (int)(num2 * 166287628) ^ -1366743103;
					continue;
				case 239u:
					num = (int)(num2 * 368342551) ^ -2004257815;
					continue;
				case 238u:
					CheckUp.smethod_19((Control)(object)MobileTxt, 2);
					num = (int)(num2 * 1527116542) ^ -124787794;
					continue;
				case 237u:
					CheckUp.smethod_48((ISupportInitialize)PictureBox1);
					num = (int)(num2 * 231871854) ^ -766296332;
					continue;
				case 236u:
					CheckUp.smethod_18((Control)(object)MobileTxt, new Size(237, 28));
					num = (int)((num2 * 662002147) ^ 0x92748DC);
					continue;
				case 235u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)Label7);
					num = (int)((num2 * 1309957139) ^ 0x1C67CC30);
					continue;
				case 234u:
					CheckUp.smethod_15((Control)(object)Label8, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 534391040) ^ 0x7861366F);
					continue;
				case 233u:
					CheckUp.smethod_17((Control)(object)ClearBtn, "ClearBtn");
					num = ((int)num2 * -881647446) ^ 0x31211362;
					continue;
				case 232u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PaymentBox), (Control)(object)Label8);
					CheckUp.smethod_15((Control)(object)PaymentBox, CheckUp.smethod_14("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1534330259) ^ -1508413622;
					continue;
				case 231u:
					CheckUp.smethod_17((Control)(object)Label7, "Label7");
					CheckUp.smethod_18((Control)(object)Label7, new Size(105, 26));
					num = ((int)num2 * -981188208) ^ 0x14BD00;
					continue;
				case 230u:
					num = ((int)num2 * -643817688) ^ 0x2F1EDD08;
					continue;
				case 229u:
					CheckUp.smethod_11((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -1058525781) ^ -1468095601;
					continue;
				case 228u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)SearchBox), (Control)(object)NameSTxt);
					num = ((int)num2 * -221651152) ^ 0x740C1DA9;
					continue;
				case 227u:
					Label4 = CheckUp.smethod_3();
					num = ((int)num2 * -94359233) ^ 0x514F9035;
					continue;
				case 226u:
					CheckUp.smethod_35((TextBoxBase)(object)FeesTxt, bool_0: true);
					num = ((int)num2 * -681566282) ^ -1202630518;
					continue;
				case 225u:
					CheckUp.smethod_37(PrintDialog1, bool_0: true);
					CheckUp.smethod_38(PictureBox1, (Image)(object)Resources.doc_Pic);
					num = (int)((num2 * 2139599864) ^ 0x2A3CEAC7);
					continue;
				case 224u:
					CheckUp.smethod_17((Control)(object)AddressTxt, "AddressTxt");
					num = (int)((num2 * 1942264671) ^ 0x1BAE80FF);
					continue;
				case 223u:
					DOBTxt = CheckUp.smethod_7();
					num = ((int)num2 * -1274147378) ^ -1765327962;
					continue;
				case 222u:
					CheckUp.smethod_21(Label1, (ContentAlignment)32);
					num = (int)(num2 * 2081215126) ^ -2001526771;
					continue;
				case 221u:
					CheckUp.smethod_15((Control)(object)RoomNoTxt, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1901646711) ^ 0x2D2C1CCE;
					continue;
				case 220u:
					num = (int)((num2 * 603213526) ^ 0x33E46FBD);
					continue;
				case 219u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)Label6);
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)Label5);
					num = (int)(num2 * 1719123979) ^ -1952480570;
					continue;
				case 218u:
					num = ((int)num2 * -730859089) ^ -1941870308;
					continue;
				case 217u:
					CheckUp.smethod_19((Control)(object)Label2, 0);
					num = (int)((num2 * 2014223874) ^ 0xBD05FC9);
					continue;
				case 216u:
					num = ((int)num2 * -1252422462) ^ -420698254;
					continue;
				case 215u:
					num = (int)(num2 * 1095816206) ^ -2109634741;
					continue;
				case 214u:
					num = ((int)num2 * -1582997668) ^ -766621579;
					continue;
				case 213u:
					num = (int)((num2 * 1585746350) ^ 0x5D1EF517);
					continue;
				case 212u:
					CheckUp.smethod_19((Control)(object)AddressTxt, 7);
					num = (int)((num2 * 457531137) ^ 0x6D8D960D);
					continue;
				case 211u:
					CheckUp.smethod_19((Control)(object)NameSTxt, 1);
					CheckUp.smethod_15((Control)(object)Label2, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					CheckUp.smethod_16((Control)(object)Label2, new Point(37, 44));
					num = (int)(num2 * 1897630341) ^ -738440447;
					continue;
				case 210u:
					num = ((int)num2 * -509495874) ^ 0x2968ECF1;
					continue;
				case 209u:
					num = ((int)num2 * -1836197428) ^ -86946617;
					continue;
				case 208u:
					CheckUp.smethod_19((Control)(object)DOBTxt, 5);
					num = ((int)num2 * -459331691) ^ -615165820;
					continue;
				case 207u:
					num = (int)(num2 * 1634728219) ^ -1609442741;
					continue;
				case 206u:
					Label7 = CheckUp.smethod_3();
					num = ((int)num2 * -541145015) ^ 0x5C8EDE31;
					continue;
				case 205u:
					CheckUp.smethod_15((Control)(object)Label1, CheckUp.smethod_14("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					CheckUp.smethod_16((Control)(object)Label1, new Point(392, 60));
					num = ((int)num2 * -885678758) ^ -64002979;
					continue;
				case 204u:
					CheckUp.smethod_19((Control)(object)Label11, 8);
					num = ((int)num2 * -2084539909) ^ -1156242857;
					continue;
				case 203u:
					CheckUp.smethod_17((Control)(object)Label1, "Label1");
					num = ((int)num2 * -2058488700) ^ 0x4DA7F927;
					continue;
				case 202u:
					num = (int)((num2 * 1936057263) ^ 0x66A76C0C);
					continue;
				case 201u:
					CheckUp.smethod_31((ButtonBase)(object)SearchBtn, Color.MidnightBlue);
					num = ((int)num2 * -435538015) ^ -1275287843;
					continue;
				case 200u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)NameTxt);
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)Label11);
					num = ((int)num2 * -1775200533) ^ 0x1C9DED9E;
					continue;
				case 199u:
					Label6 = CheckUp.smethod_3();
					num = ((int)num2 * -303823838) ^ -1429922507;
					continue;
				case 198u:
					CheckUp.smethod_18((Control)(object)DOBTxt, new Size(130, 26));
					num = (int)((num2 * 1145455868) ^ 0x1C76A2);
					continue;
				case 197u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)Label4);
					num = (int)((num2 * 1426176896) ^ 0x33A92E79);
					continue;
				case 196u:
					CheckUp.smethod_18((Control)(object)FeesTxt, new Size(100, 26));
					CheckUp.smethod_19((Control)(object)FeesTxt, 9);
					num = (int)(num2 * 1064626862) ^ -290046333;
					continue;
				case 195u:
					CheckUp.smethod_16((Control)(object)Label6, new Point(230, 113));
					num = ((int)num2 * -1862994417) ^ 0x41B64E10;
					continue;
				case 194u:
					CheckUp.smethod_21(Label2, (ContentAlignment)32);
					num = (int)(num2 * 1118906537) ^ -1701917228;
					continue;
				case 193u:
					CheckUp.smethod_28(CheckUp.smethod_45((Control)(object)this), (Control)(object)SearchResultGrid);
					num = ((int)num2 * -182195878) ^ 0x40F2B1A2;
					continue;
				case 192u:
					num = (int)(num2 * 1804501829) ^ -1813904363;
					continue;
				case 191u:
					GenderTxt = CheckUp.smethod_7();
					num = (int)(num2 * 2095077843) ^ -337024939;
					continue;
				case 190u:
					CheckUp.smethod_17((Control)(object)DOBTxt, "DOBTxt");
					num = (int)((num2 * 1356185419) ^ 0x7E7D5423);
					continue;
				case 189u:
					NameTxt = CheckUp.smethod_7();
					num = ((int)num2 * -1167257323) ^ -1146614337;
					continue;
				case 188u:
					num = ((int)num2 * -1015141606) ^ -2136967962;
					continue;
				case 187u:
					CheckUp.smethod_15((Control)(object)Label10, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1478660811) ^ -449660029;
					continue;
				case 186u:
					num = (int)((num2 * 1734962852) ^ 0x5358FFA1);
					continue;
				case 185u:
					CheckUp.smethod_32((Control)(object)ClearBtn, Color.White);
					num = ((int)num2 * -2091986998) ^ 0x44C4338D;
					continue;
				case 184u:
					num = ((int)num2 * -626101032) ^ 0x20D0FC05;
					continue;
				case 183u:
					num = (int)((num2 * 1738139338) ^ 0x4D2D8F);
					continue;
				case 182u:
					CheckUp.smethod_21(Label5, (ContentAlignment)32);
					CheckUp.smethod_15((Control)(object)Label4, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -868419658) ^ -1420986438;
					continue;
				case 181u:
					CheckUp.smethod_16((Control)(object)NameSTxt, new Point(120, 43));
					num = (int)((num2 * 1198196656) ^ 0x6EA53A0);
					continue;
				case 180u:
					CheckUp.smethod_18((Control)(object)SearchBox, new Size(623, 128));
					num = (int)((num2 * 1506850421) ^ 0x917F470);
					continue;
				case 179u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)PIDTxt);
					num = (int)(num2 * 1890783047) ^ -1164170830;
					continue;
				case 178u:
					num = ((int)num2 * -107452878) ^ -71710590;
					continue;
				case 177u:
					CheckUp.smethod_16((Control)(object)PrintBtn, new Point(756, 696));
					num = (int)(num2 * 822655718) ^ -1889669281;
					continue;
				case 176u:
					CheckUp.smethod_19((Control)(object)Label7, 3);
					num = ((int)num2 * -1903605201) ^ 0x2341937C;
					continue;
				case 175u:
					PatientInfoBox = CheckUp.smethod_5();
					num = ((int)num2 * -1055316536) ^ -1802341753;
					continue;
				case 174u:
					CheckUp.smethod_17((Control)(object)RoomNoTxt, "RoomNoTxt");
					num = ((int)num2 * -566188859) ^ 0x53291AE4;
					continue;
				case 173u:
					CheckUp.smethod_16((Control)(object)Label8, new Point(18, 34));
					num = (int)(num2 * 1128281747) ^ -843092513;
					continue;
				case 172u:
					CheckUp.smethod_17((Control)(object)Label5, "Label5");
					CheckUp.smethod_18((Control)(object)Label5, new Size(68, 26));
					num = (int)((num2 * 1632579574) ^ 0x2B7B7643);
					continue;
				case 171u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)AddressTxt);
					num = ((int)num2 * -1485501999) ^ 0x47A8EA4D;
					continue;
				case 170u:
					num = ((int)num2 * -460326957) ^ 0x1243A0D7;
					continue;
				case 169u:
					CheckUp.smethod_16((Control)(object)PictureBox1, new Point(281, 21));
					num = ((int)num2 * -431548654) ^ -314577552;
					continue;
				case 168u:
					num = ((int)num2 * -543327046) ^ 0x3D7ED115;
					continue;
				case 167u:
					CheckUp.smethod_41(PictureBox1, bool_0: false);
					num = (int)(num2 * 1256712451) ^ -575849559;
					continue;
				case 166u:
					CheckUp.smethod_17((Control)(object)PIDTxt, "PIDTxt");
					num = ((int)num2 * -567926541) ^ -719448924;
					continue;
				case 165u:
					CheckUp.smethod_28(CheckUp.smethod_45((Control)(object)this), (Control)(object)Label1);
					num = (int)(num2 * 1400698401) ^ -1891760440;
					continue;
				case 163u:
					CheckUp.smethod_19((Control)(object)Label8, 1);
					num = ((int)num2 * -851758129) ^ -1486077992;
					continue;
				case 162u:
					num = (int)((num2 * 1346683720) ^ 0x30242FCA);
					continue;
				case 161u:
					num = ((int)num2 * -133147985) ^ 0x9251AA5;
					continue;
				case 160u:
					CheckUp.smethod_20(Label7, "Address : ");
					num = (int)((num2 * 511942500) ^ 0x253D0AEF);
					continue;
				case 159u:
					CheckUp.smethod_32((Control)(object)SearchBtn, Color.White);
					num = (int)(num2 * 215269113) ^ -2002312230;
					continue;
				case 158u:
					PrintDocument1 = CheckUp.smethod_8();
					PrintDialog1 = CheckUp.smethod_9();
					num = (int)(num2 * 1073369466) ^ -1185600722;
					continue;
				case 157u:
					CheckUp.smethod_23(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					num = (int)((num2 * 1705612361) ^ 0x25398614);
					continue;
				case 156u:
					CheckUp.smethod_15((Control)(object)Label3, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1745704640) ^ -1570077123;
					continue;
				case 155u:
					CheckUp.smethod_15((Control)(object)ClearBtn, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1084868939) ^ 0x6B883044;
					continue;
				case 154u:
					num = (int)((num2 * 1873068514) ^ 0x303CE386);
					continue;
				case 153u:
					CheckUp.smethod_18((Control)(object)PrintBtn, new Size(119, 44));
					CheckUp.smethod_19((Control)(object)PrintBtn, 8);
					num = (int)(num2 * 166795209) ^ -1479220085;
					continue;
				case 152u:
					CheckUp.smethod_19((Control)(object)Label1, 0);
					num = ((int)num2 * -8533044) ^ 0x1D9E12E3;
					continue;
				case 151u:
					num = ((int)num2 * -1098444151) ^ -2122423695;
					continue;
				case 150u:
					CheckUp.smethod_15((Control)(object)PIDTxt, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1500508084) ^ 0x63F2FEF;
					continue;
				case 149u:
					CheckUp.smethod_42((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -419841503) ^ 0x49B66535;
					continue;
				case 148u:
					num = ((int)num2 * -2043639499) ^ 0x1E8FF20;
					continue;
				case 147u:
					num = (int)((num2 * 180267903) ^ 0x52BB69DC);
					continue;
				case 146u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PaymentBox), (Control)(object)FeesTxt);
					num = ((int)num2 * -117718670) ^ 0x521271AF;
					continue;
				case 145u:
					num = ((int)num2 * -998290089) ^ 0x4921D441;
					continue;
				case 144u:
					CheckUp.smethod_17((Control)(object)GenderTxt, "GenderTxt");
					num = (int)(num2 * 268504377) ^ -612695809;
					continue;
				case 143u:
					CheckUp.smethod_35((TextBoxBase)(object)RoomNoTxt, bool_0: true);
					CheckUp.smethod_18((Control)(object)RoomNoTxt, new Size(100, 26));
					CheckUp.smethod_19((Control)(object)RoomNoTxt, 7);
					num = (int)(num2 * 589118799) ^ -998285342;
					continue;
				case 142u:
					CheckUp.smethod_26(CheckUp.smethod_25(SearchResultGrid), 24);
					num = (int)(num2 * 932642379) ^ -1191010440;
					continue;
				case 141u:
					num = ((int)num2 * -2004905380) ^ -1582876484;
					continue;
				case 140u:
					num = (int)(num2 * 525401927) ^ -1188119109;
					continue;
				case 139u:
					CheckUp.smethod_15((Control)(object)Label5, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					CheckUp.smethod_16((Control)(object)Label5, new Point(20, 115));
					num = ((int)num2 * -429755486) ^ 0x2DCBB612;
					continue;
				case 138u:
					CheckUp.smethod_15((Control)(object)SearchBox, CheckUp.smethod_14("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 229322199) ^ 0x4D232F94);
					continue;
				case 137u:
					num = (int)(num2 * 1200724444) ^ -1343233945;
					continue;
				case 136u:
					CheckUp.smethod_15((Control)(object)PrintBtn, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -2019807157) ^ -1703928922;
					continue;
				case 135u:
					CheckUp.smethod_33((ButtonBase)(object)PrintBtn, "Print");
					num = ((int)num2 * -1086619030) ^ -1700685706;
					continue;
				case 134u:
					num = ((int)num2 * -1645906722) ^ 0x1948A33C;
					continue;
				case 133u:
					Label11 = CheckUp.smethod_3();
					num = ((int)num2 * -1454419703) ^ 0x4EEC9147;
					continue;
				case 132u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)GenderTxt);
					num = (int)(num2 * 153315438) ^ -158804636;
					continue;
				case 131u:
					Label10 = CheckUp.smethod_3();
					Label9 = CheckUp.smethod_3();
					num = (int)((num2 * 589712223) ^ 0x51353A06);
					continue;
				case 130u:
					CheckUp.smethod_17((Control)(object)NameTxt, "NameTxt");
					num = (int)((num2 * 1304428906) ^ 0x4BABC6CF);
					continue;
				case 129u:
					CheckUp.smethod_50((Control)(object)PaymentBox);
					num = (int)(num2 * 1834019244) ^ -1851443871;
					continue;
				case 128u:
					num = ((int)num2 * -1740572585) ^ 0x7D512B77;
					continue;
				case 127u:
					num = (int)(num2 * 990992070) ^ -1180100312;
					continue;
				case 126u:
					num = ((int)num2 * -1959302738) ^ 0x1F179398;
					continue;
				case 125u:
					CheckUp.smethod_15((Control)(object)TokenNoTxt, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1868932222) ^ 0x7BB066EF;
					continue;
				case 124u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PaymentBox), (Control)(object)TokenNoTxt);
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PaymentBox), (Control)(object)RoomNoTxt);
					num = ((int)num2 * -702214851) ^ -1768124877;
					continue;
				case 123u:
					CheckUp.smethod_35((TextBoxBase)(object)NameTxt, bool_0: true);
					CheckUp.smethod_18((Control)(object)NameTxt, new Size(328, 26));
					num = ((int)num2 * -259418628) ^ -1670077274;
					continue;
				case 122u:
					CheckUp.smethod_49((Control)(object)PaymentBox, bool_0: false);
					num = (int)(num2 * 901956478) ^ -951253505;
					continue;
				case 121u:
					CheckUp.smethod_19((Control)(object)Label10, 3);
					num = (int)(num2 * 1475547846) ^ -405643480;
					continue;
				case 120u:
					CheckUp.smethod_18((Control)(object)AddressTxt, new Size(298, 90));
					num = ((int)num2 * -38695992) ^ -996793744;
					continue;
				case 119u:
					Label8 = CheckUp.smethod_3();
					ClearBtn = CheckUp.smethod_6();
					num = (int)(num2 * 743693332) ^ -1682892640;
					continue;
				case 118u:
					CheckUp.smethod_17((Control)(object)Label6, "Label6");
					num = (int)(num2 * 279559614) ^ -1452056373;
					continue;
				case 117u:
					num = (int)(num2 * 977950370) ^ -737591097;
					continue;
				case 116u:
					CheckUp.smethod_17((Control)(object)SearchBtn, "SearchBtn");
					num = (int)((num2 * 879933183) ^ 0x57D05EDC);
					continue;
				case 115u:
					num = (int)((num2 * 409714195) ^ 0x73FDDCE6);
					continue;
				case 114u:
					num = (int)((num2 * 1874055994) ^ 0x62116B7F);
					continue;
				case 113u:
					CheckUp.smethod_18((Control)(object)Label10, new Size(101, 25));
					num = (int)((num2 * 1408865750) ^ 0x4FD4F360);
					continue;
				case 112u:
					num = (int)((num2 * 1202201629) ^ 0x478209A5);
					continue;
				case 111u:
					CheckUp.smethod_30(PatientInfoBox, "Patient Information");
					CheckUp.smethod_15((Control)(object)NameTxt, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1841679685) ^ -10437399;
					continue;
				case 110u:
					CheckUp.smethod_33((ButtonBase)(object)SearchBtn, "Search");
					num = ((int)num2 * -31457266) ^ -799094495;
					continue;
				case 109u:
					CheckUp.smethod_35((TextBoxBase)(object)TokenNoTxt, bool_0: true);
					CheckUp.smethod_18((Control)(object)TokenNoTxt, new Size(100, 26));
					num = ((int)num2 * -1504986219) ^ 0x27D1220F;
					continue;
				case 108u:
					CheckUp.smethod_19((Control)(object)Label6, 2);
					num = ((int)num2 * -1025218663) ^ -850666353;
					continue;
				case 107u:
					CheckUp.smethod_19((Control)(object)Label5, 1);
					CheckUp.smethod_20(Label5, "DOB :");
					num = ((int)num2 * -1145633547) ^ -909742514;
					continue;
				case 106u:
					CheckUp.smethod_11((ISupportInitialize)SearchResultGrid);
					num = ((int)num2 * -290543397) ^ 0x3B60101A;
					continue;
				case 105u:
					CheckUp.smethod_15((Control)(object)Label6, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1968692678) ^ 0x7D947E75;
					continue;
				case 104u:
					num = ((int)num2 * -1724069051) ^ -1536998682;
					continue;
				case 103u:
					CheckUp.smethod_30(PaymentBox, "Payment Details");
					num = (int)((num2 * 355081014) ^ 0x1294BE83);
					continue;
				case 102u:
					CheckUp.smethod_19((Control)(object)TokenNoTxt, 8);
					num = (int)(num2 * 1536336150) ^ -437517323;
					continue;
				case 101u:
					CheckUp.smethod_17((Control)(object)MobileTxt, "MobileTxt");
					num = (int)(num2 * 1817591757) ^ -1365291883;
					continue;
				case 100u:
					num = (int)((num2 * 1550384212) ^ 0x6EA22B8E);
					continue;
				case 99u:
					CheckUp.smethod_12((Control)(object)SearchBox);
					num = ((int)num2 * -1323088959) ^ -1897830289;
					continue;
				case 98u:
					CheckUp.smethod_15((Control)(object)AddressTxt, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					CheckUp.smethod_16((Control)(object)AddressTxt, new Point(124, 159));
					num = ((int)num2 * -1113576813) ^ 0x886CB7;
					continue;
				case 97u:
					CheckUp.smethod_36(AddressTxt, bool_0: true);
					num = ((int)num2 * -1701387822) ^ 0x6AE6BF4C;
					continue;
				case 96u:
					num = (int)(num2 * 395260782) ^ -652641046;
					continue;
				case 95u:
					num = (int)(num2 * 644250752) ^ -1669611480;
					continue;
				case 94u:
					num = (int)((num2 * 588529541) ^ 0x1C66B3EC);
					continue;
				case 93u:
					CheckUp.smethod_16((Control)(object)RoomNoTxt, new Point(125, 34));
					num = (int)((num2 * 305821971) ^ 0x7B85728F);
					continue;
				case 92u:
					PaymentBox = CheckUp.smethod_5();
					FeesTxt = CheckUp.smethod_7();
					num = ((int)num2 * -830041163) ^ 0x342CC623;
					continue;
				case 91u:
					CheckUp.smethod_29(PatientInfoBox, bool_0: false);
					num = ((int)num2 * -1650055131) ^ -1814860490;
					continue;
				case 90u:
					CheckUp.smethod_16((Control)(object)NameTxt, new Point(94, 80));
					num = ((int)num2 * -631469264) ^ -1617501562;
					continue;
				case 89u:
					CheckUp.smethod_17((Control)(object)PaymentBox, "PaymentBox");
					num = (int)(num2 * 1078512282) ^ -1603637685;
					continue;
				case 88u:
					CheckUp.smethod_18((Control)(object)Label1, new Size(261, 47));
					num = (int)((num2 * 673065037) ^ 0x313E5E31);
					continue;
				case 87u:
					num = ((int)num2 * -1804270358) ^ -1008859632;
					continue;
				case 86u:
					CheckUp.smethod_17((Control)(object)Label9, "Label9");
					num = (int)(num2 * 1560725391) ^ -716488998;
					continue;
				case 85u:
					CheckUp.smethod_16((Control)(object)Label3, new Point(37, 87));
					CheckUp.smethod_17((Control)(object)Label3, "Label3");
					CheckUp.smethod_18((Control)(object)Label3, new Size(77, 28));
					CheckUp.smethod_19((Control)(object)Label3, 3);
					num = (int)(num2 * 140565705) ^ -653797151;
					continue;
				case 84u:
					CheckUp.smethod_21(Label11, (ContentAlignment)32);
					num = (int)((num2 * 220601992) ^ 0x75C0C3C1);
					continue;
				case 83u:
					CheckUp.smethod_16((Control)(object)SearchResultGrid, new Point(59, 295));
					CheckUp.smethod_17((Control)(object)SearchResultGrid, "SearchResultGrid");
					num = (int)((num2 * 101220615) ^ 0x1857305);
					continue;
				case 82u:
					CheckUp.smethod_18((Control)(object)SearchResultGrid, new Size(853, 169));
					num = (int)(num2 * 1348573101) ^ -1165431649;
					continue;
				case 81u:
					CheckUp.smethod_16((Control)(object)Label10, new Point(18, 114));
					num = (int)(num2 * 432155278) ^ -100966488;
					continue;
				case 80u:
					CheckUp.smethod_19((Control)(object)SearchResultGrid, 3);
					num = ((int)num2 * -1649528520) ^ 0x68788CBA;
					continue;
				case 79u:
					num = ((int)num2 * -861961207) ^ 0x83C31D2;
					continue;
				case 78u:
					PrintBtn = CheckUp.smethod_6();
					num = (int)(num2 * 632404868) ^ -1688612556;
					continue;
				case 77u:
					CheckUp.smethod_19((Control)(object)ClearBtn, 7);
					num = (int)(num2 * 429232813) ^ -122471051;
					continue;
				case 76u:
					num = ((int)num2 * -1464475756) ^ -1456706168;
					continue;
				case 75u:
					CheckUp.smethod_35((TextBoxBase)(object)GenderTxt, bool_0: true);
					num = ((int)num2 * -471372068) ^ -1580256695;
					continue;
				case 74u:
					CheckUp.smethod_28(CheckUp.smethod_45((Control)(object)this), (Control)(object)PaymentBox);
					num = ((int)num2 * -914132796) ^ 0x18988FC9;
					continue;
				case 73u:
					num = ((int)num2 * -1956102783) ^ 0x1015B119;
					continue;
				case 72u:
					CheckUp.smethod_29(SearchBox, bool_0: false);
					CheckUp.smethod_30(SearchBox, "Search Patient");
					num = (int)(num2 * 172313815) ^ -1751659663;
					continue;
				case 71u:
					CheckUp.smethod_17((Control)(object)PatientInfoBox, "PatientInfoBox");
					num = ((int)num2 * -1411031084) ^ 0x7111080D;
					continue;
				case 70u:
					CheckUp.smethod_17((Control)(object)Label10, "Label10");
					num = (int)((num2 * 2144155621) ^ 0x7E9DF1F1);
					continue;
				case 69u:
					num = ((int)num2 * -1947461700) ^ -1934545958;
					continue;
				case 68u:
					TokenNoTxt = CheckUp.smethod_7();
					num = (int)(num2 * 1659626875) ^ -510788141;
					continue;
				case 67u:
					CheckUp.smethod_18((Control)(object)PatientInfoBox, new Size(439, 255));
					CheckUp.smethod_19((Control)(object)PatientInfoBox, 5);
					num = (int)(num2 * 1446036485) ^ -777662940;
					continue;
				case 66u:
					CheckUp.smethod_12((Control)(object)PatientInfoBox);
					CheckUp.smethod_12((Control)(object)PaymentBox);
					num = ((int)num2 * -1539848698) ^ 0x74A2955;
					continue;
				case 65u:
					CheckUp.smethod_19((Control)(object)PIDTxt, 4);
					num = (int)((num2 * 1296410651) ^ 0x3B98FFBC);
					continue;
				case 64u:
					CheckUp.smethod_17((Control)(object)PictureBox1, "PictureBox1");
					CheckUp.smethod_18((Control)(object)PictureBox1, new Size(126, 122));
					num = (int)(num2 * 1128656188) ^ -733576817;
					continue;
				case 63u:
					Label5 = CheckUp.smethod_3();
					num = (int)(num2 * 233208804) ^ -159532513;
					continue;
				case 62u:
					num = (int)(num2 * 1409288722) ^ -454026868;
					continue;
				case 61u:
					CheckUp.smethod_51((Control)(object)this, bool_0: false);
					num = ((int)num2 * -25971097) ^ -857660889;
					continue;
				case 60u:
					num = ((int)num2 * -828230042) ^ -1390667902;
					continue;
				case 59u:
					num = (int)((num2 * 835629534) ^ 0x44178538);
					continue;
				case 58u:
					CheckUp.smethod_24(SearchResultGrid, bool_0: true);
					num = (int)((num2 * 898736974) ^ 0x177CFBCC);
					continue;
				case 57u:
					num = (int)((num2 * 142028583) ^ 0x5A8315CE);
					continue;
				case 56u:
					CheckUp.smethod_19((Control)(object)PaymentBox, 6);
					num = (int)((num2 * 735766086) ^ 0x31FA7E96);
					continue;
				case 55u:
					CheckUp.smethod_16((Control)(object)Label4, new Point(20, 46));
					num = ((int)num2 * -1262833185) ^ 0x142D36EF;
					continue;
				case 54u:
					CheckUp.smethod_20(Label10, "Fees  :");
					num = (int)(num2 * 1292943142) ^ -1731823893;
					continue;
				case 53u:
					num = ((int)num2 * -290803379) ^ 0x6EBA3678;
					continue;
				case 52u:
					CheckUp.smethod_15((Control)(object)SearchBtn, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1838981689) ^ 0x65DCDCFD);
					continue;
				case 51u:
					num = ((int)num2 * -405254387) ^ -16304598;
					continue;
				case 50u:
					CheckUp.smethod_43((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1022250858) ^ -168987547;
					continue;
				case 49u:
					CheckUp.smethod_16((Control)(object)PatientInfoBox, new Point(101, 485));
					num = ((int)num2 * -381606683) ^ 0x3DBC7374;
					continue;
				case 48u:
					CheckUp.smethod_19((Control)(object)SearchBox, 4);
					num = ((int)num2 * -1289025982) ^ -692387200;
					continue;
				case 47u:
					CheckUp.smethod_18((Control)(object)PaymentBox, new Size(286, 165));
					num = ((int)num2 * -617384101) ^ -1376967707;
					continue;
				case 46u:
					CheckUp.smethod_35((TextBoxBase)(object)AddressTxt, bool_0: true);
					num = (int)((num2 * 1123148294) ^ 0x1BD1F58C);
					continue;
				case 45u:
					num = ((int)num2 * -2050072597) ^ 0x4CA6886;
					continue;
				case 44u:
					CheckUp.smethod_47((Control)(object)this, new Size(977, 804));
					num = ((int)num2 * -680246589) ^ -1497147924;
					continue;
				case 43u:
					CheckUp.smethod_15((Control)(object)Label7, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1190450181) ^ -29069309;
					continue;
				case 42u:
					num = (int)((num2 * 223076824) ^ 0x50189785);
					continue;
				case 41u:
					num = (int)(num2 * 1405288507) ^ -94027733;
					continue;
				case 40u:
					CheckUp.smethod_13((Control)(object)this);
					num = ((int)num2 * -575530934) ^ -983098724;
					continue;
				case 39u:
					num = ((int)num2 * -258712014) ^ -393883599;
					continue;
				case 38u:
					CheckUp.smethod_17((Control)(object)NameSTxt, "NameSTxt");
					num = ((int)num2 * -464231369) ^ 0x72806AA3;
					continue;
				case 37u:
					CheckUp.smethod_15((Control)(object)DOBTxt, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					CheckUp.smethod_16((Control)(object)DOBTxt, new Point(94, 115));
					num = ((int)num2 * -769948859) ^ 0x31DC91BA;
					continue;
				case 36u:
					PictureBox1 = CheckUp.smethod_10();
					num = ((int)num2 * -1254014166) ^ 0x753F5545;
					continue;
				case 35u:
					CheckUp.smethod_18((Control)(object)Label4, new Size(68, 25));
					num = (int)((num2 * 807372491) ^ 0x4D8A79F6);
					continue;
				case 34u:
					num = ((int)num2 * -321157836) ^ 0x451724D3;
					continue;
				case 33u:
					num = ((int)num2 * -1527056434) ^ -199045031;
					continue;
				case 32u:
					CheckUp.smethod_28(CheckUp.smethod_45((Control)(object)this), (Control)(object)SearchBox);
					num = ((int)num2 * -862517461) ^ 0x495D439F;
					continue;
				case 31u:
					CheckUp.smethod_20(Label8, "Room No :");
					CheckUp.smethod_21(Label8, (ContentAlignment)32);
					CheckUp.smethod_31((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					num = ((int)num2 * -1852222560) ^ -878211739;
					continue;
				case 30u:
					CheckUp.smethod_29(PaymentBox, bool_0: false);
					num = (int)((num2 * 1625066501) ^ 0x65D7FB66);
					continue;
				case 29u:
					CheckUp.smethod_18((Control)(object)NameSTxt, new Size(237, 28));
					num = (int)(num2 * 787254493) ^ -1997367795;
					continue;
				case 28u:
					num = (int)((num2 * 67111518) ^ 0x13436396);
					continue;
				case 27u:
					num = (int)((num2 * 1570009293) ^ 0x21CE708);
					continue;
				case 26u:
					CheckUp.smethod_19((Control)(object)NameTxt, 9);
					num = (int)(num2 * 1674632487) ^ -1930592791;
					continue;
				case 25u:
					CheckUp.smethod_15((Control)(object)GenderTxt, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1890159759) ^ 0x73B7D738;
					continue;
				case 24u:
					num = ((int)num2 * -1420368890) ^ 0x2BC9E0;
					continue;
				case 23u:
					num = ((int)num2 * -1918289579) ^ -1357987551;
					continue;
				case 22u:
					CheckUp.smethod_16((Control)(object)PIDTxt, new Point(94, 43));
					num = (int)((num2 * 629804565) ^ 0x3DC554A0);
					continue;
				case 21u:
					num = (int)(num2 * 244419462) ^ -717225415;
					continue;
				case 20u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PaymentBox), (Control)(object)Label9);
					num = (int)((num2 * 1219162407) ^ 0x64979AE6);
					continue;
				case 19u:
					num = (int)(num2 * 1313038800) ^ -747972052;
					continue;
				case 18u:
					RoomNoTxt = CheckUp.smethod_7();
					num = ((int)num2 * -1583078094) ^ 0x514656C8;
					continue;
				case 17u:
					num = (int)(num2 * 546545144) ^ -512229640;
					continue;
				case 16u:
					CheckUp.smethod_15((Control)(object)Label9, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1681255152) ^ 0x10346CA9;
					continue;
				case 15u:
					num = (int)(num2 * 869392898) ^ -1077553368;
					continue;
				case 14u:
					CheckUp.smethod_46((Control)(object)this, "CheckUp");
					num = (int)((num2 * 150662902) ^ 0x5E72A6C8);
					continue;
				case 13u:
					CheckUp.smethod_20(Label4, "PID :");
					num = ((int)num2 * -2089775008) ^ -542629285;
					continue;
				case 12u:
					num = (int)((num2 * 1828536761) ^ 0x358E9E24);
					continue;
				case 11u:
					CheckUp.smethod_32((Control)(object)PrintBtn, Color.White);
					num = ((int)num2 * -69850728) ^ 0x24D5902C;
					continue;
				case 10u:
					CheckUp.smethod_20(Label2, "Name : ");
					num = (int)((num2 * 452788918) ^ 0x5D660D5A);
					continue;
				case 9u:
					CheckUp.smethod_18((Control)(object)Label6, new Size(84, 26));
					num = (int)(num2 * 18073151) ^ -1504838439;
					continue;
				case 8u:
					CheckUp.smethod_48((ISupportInitialize)SearchResultGrid);
					num = (int)(num2 * 366083238) ^ -874357482;
					continue;
				case 7u:
					CheckUp.smethod_39(PictureBox1, (PictureBoxSizeMode)1);
					num = (int)((num2 * 1449215540) ^ 0x64F58044);
					continue;
				case 6u:
					CheckUp.smethod_20(Label3, "Mobile : ");
					CheckUp.smethod_21(Label3, (ContentAlignment)32);
					CheckUp.smethod_16((Control)(object)MobileTxt, new Point(120, 87));
					num = ((int)num2 * -177506685) ^ -2023836396;
					continue;
				case 5u:
					num = ((int)num2 * -545475245) ^ 0x45A2E4B7;
					continue;
				case 4u:
					CheckUp.smethod_18((Control)(object)GenderTxt, new Size(100, 26));
					CheckUp.smethod_19((Control)(object)GenderTxt, 6);
					num = ((int)num2 * -52431548) ^ 0x7D362EA9;
					continue;
				case 3u:
					num = ((int)num2 * -1499641645) ^ 0xEB3119C;
					continue;
				case 2u:
					num = (int)((num2 * 28101297) ^ 0x64FC31EA);
					continue;
				case 1u:
					num = ((int)num2 * -1075234791) ^ -1020388359;
					continue;
				case 0u:
					CheckUp.smethod_31((ButtonBase)(object)PrintBtn, Color.MidnightBlue);
					num = (int)((num2 * 1257447962) ^ 0x4EF3A466);
					continue;
				default:
					return;
				case 266u:
					break;
				case 164u:
					return;
				}
				break;
			}
		}
	}

	private void CheckUp_Load(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1599440521;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD7236D6Au) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1426825525) ^ 0x7284324C;
					continue;
				case 1u:
					CheckUp.smethod_59(myconnection, CheckUp.smethod_58(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
					num = ((int)num2 * -1178655767) ^ 0x4BFA03D;
					continue;
				case 3u:
					break;
				default:
					HideItemsOnForm();
					return;
				}
				break;
			}
		}
	}

	private void SearchBtn_Click(object sender, EventArgs e)
	{
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected I4, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected I4, but got Unknown
		//IL_02cd: Incompatible stack heights: 0 vs 1
		//IL_02d4: Incompatible stack heights: 0 vs 1
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		HideItemsOnForm();
		bool flag = !MyProject.Forms.Form1.Name_Validation(CheckUp.smethod_61(CheckUp.smethod_60(NameSTxt))) | !MyProject.Forms.Form1.Mobile_Validator(CheckUp.smethod_61(CheckUp.smethod_60(MobileTxt)));
		OleDbDataAdapter dbDataAdapter_ = default(OleDbDataAdapter);
		while (true)
		{
			int num = 579081006;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5AD836F5u) % 5u)
				{
				case 3u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -1280191;
						num7 = -1280191;
					}
					else
					{
						num6 = -1359600727;
						num7 = -1359600727;
					}
					num = num6 ^ (int)(num2 * 1412545968);
					continue;
				}
				case 1u:
					num = 1540297484;
					continue;
				case 2u:
					break;
				default:
				{
					CheckUp.smethod_63();
					string string_ = CheckUp.smethod_64(new string[5]
					{
						"Select * From [Patient] Where [Name] Like '%",
						CheckUp.smethod_61(CheckUp.smethod_60(NameSTxt)),
						"%' And [Mobile] Like '%",
						CheckUp.smethod_60(MobileTxt),
						"%';"
					});
					DataTable dataTable = CheckUp.smethod_65();
					CheckUp.smethod_66(myconnection);
					try
					{
						while (true)
						{
							int num3 = 676679957;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x5AD836F5u) % 13u)
								{
								case 11u:
									dbDataAdapter_ = CheckUp.smethod_67(string_, myconnection);
									num3 = (int)(num2 * 1093010327) ^ -2047843009;
									continue;
								case 10u:
									SetPaymentBoxFields();
									num3 = (int)((num2 * 1449099311) ^ 0x36A60ED2);
									continue;
								case 9u:
									CheckUp.smethod_69(SearchResultGrid, (object)dataTable);
									num3 = (int)(num2 * 2023604468) ^ -805766418;
									continue;
								case 8u:
									CheckUp.smethod_72((Control)(object)SearchResultGrid, bool_0: true);
									num3 = ((int)num2 * -815345995) ^ -1788886393;
									continue;
								case 7u:
									mobile = CheckUp.smethod_60(MobileTxt);
									num3 = (int)(num2 * 1846837666) ^ -1352826782;
									continue;
								case 4u:
								{
									int num4;
									int num5;
									if (CheckUp.smethod_70(SearchResultGrid) != 1)
									{
										num4 = 1936405461;
										num5 = 1936405461;
									}
									else
									{
										num4 = 111677858;
										num5 = 111677858;
									}
									num3 = num4 ^ ((int)num2 * -834302836);
									continue;
								}
								case 3u:
									CheckUp.smethod_71(myconnection);
									num3 = (int)(num2 * 1427623871) ^ -410801490;
									continue;
								case 2u:
									CheckUp.smethod_62("No Result Found");
									num3 = ((int)num2 * -1857884928) ^ 0x74826B5F;
									continue;
								case 1u:
									num3 = 1924855813;
									continue;
								case 0u:
									CheckUp.smethod_68((DbDataAdapter)(object)dbDataAdapter_, dataTable);
									num3 = ((int)num2 * -764217497) ^ 0x3BB873D9;
									continue;
								default:
									return;
								case 12u:
									break;
								case 5u:
									return;
								case 6u:
									CheckUp.smethod_71(myconnection);
									return;
								}
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						CheckUp.smethod_73(exception_);
						while (true)
						{
							_ = 630694879;
							while (true)
							{
								_003F val = /*Error near IL_0297: Stack underflow*/^ 0x5AD836F5;
								num2 = (uint)(int)val;
								switch (val % 3)
								{
								default:
									return;
								case 1:
									CheckUp.smethod_71(myconnection);
									CheckUp.smethod_74();
									_ = ((int)num2 * -727722780) ^ -552649157;
									continue;
								case 2:
									break;
								case 0:
									return;
								}
								break;
							}
						}
					}
				}
				case 4u:
					CheckUp.smethod_62("No Result Found");
					return;
				}
				break;
			}
		}
	}

	private void ClearBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1489952403;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF13B9067u) % 10u)
				{
				case 9u:
					CheckUp.smethod_75((TextBoxBase)(object)DOBTxt);
					num = ((int)num2 * -788389913) ^ 0x18C5EE27;
					continue;
				case 8u:
					CheckUp.smethod_75((TextBoxBase)(object)NameTxt);
					num = (int)(num2 * 2069745787) ^ -1843718403;
					continue;
				case 7u:
					CheckUp.smethod_75((TextBoxBase)(object)AddressTxt);
					num = (int)((num2 * 766846123) ^ 0x6EDA49A2);
					continue;
				case 5u:
					num = ((int)num2 * -1047803674) ^ 0x37C6771A;
					continue;
				case 4u:
					CheckUp.smethod_75((TextBoxBase)(object)TokenNoTxt);
					CheckUp.smethod_75((TextBoxBase)(object)RoomNoTxt);
					num = (int)(num2 * 1535080687) ^ -1934249840;
					continue;
				case 3u:
					CheckUp.smethod_75((TextBoxBase)(object)FeesTxt);
					num = (int)(num2 * 1634887581) ^ -1675770898;
					continue;
				case 2u:
					CheckUp.smethod_75((TextBoxBase)(object)GenderTxt);
					CheckUp.smethod_75((TextBoxBase)(object)PIDTxt);
					num = (int)((num2 * 1758663099) ^ 0x24452750);
					continue;
				case 1u:
					num = ((int)num2 * -1074116781) ^ -2038526383;
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

	private void SearchResultGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected I4, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected I4, but got Unknown
		//IL_0280: Incompatible stack heights: 0 vs 1
		//IL_0287: Incompatible stack heights: 0 vs 1
		try
		{
			CheckUp.smethod_83(PIDTxt, CheckUp.smethod_82(CheckUp.smethod_81(CheckUp.smethod_80(CheckUp.smethod_79(CheckUp.smethod_78(CheckUp.smethod_76(SearchResultGrid), CheckUp.smethod_77(e))), 0))));
			while (true)
			{
				int num = -1872315821;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA5F33E49u) % 12u)
					{
					case 11u:
						CheckUp.smethod_72((Control)(object)PaymentBox, bool_0: true);
						num = (int)((num2 * 1367623566) ^ 0x1D0D57DE);
						continue;
					case 10u:
						num = ((int)num2 * -314725636) ^ -960330391;
						continue;
					case 9u:
						CheckUp.smethod_72((Control)(object)PrintBtn, bool_0: true);
						num = (int)(num2 * 1256091905) ^ -1372894501;
						continue;
					case 8u:
						CheckUp.smethod_83(DOBTxt, CheckUp.smethod_82(CheckUp.smethod_81(CheckUp.smethod_80(CheckUp.smethod_79(CheckUp.smethod_78(CheckUp.smethod_76(SearchResultGrid), CheckUp.smethod_77(e))), 2))));
						num = ((int)num2 * -1359240240) ^ -406792946;
						continue;
					case 7u:
						CheckUp.smethod_83(GenderTxt, CheckUp.smethod_82(CheckUp.smethod_81(CheckUp.smethod_80(CheckUp.smethod_79(CheckUp.smethod_78(CheckUp.smethod_76(SearchResultGrid), CheckUp.smethod_77(e))), 3))));
						num = (int)(num2 * 1622293554) ^ -1350644758;
						continue;
					case 6u:
						CheckUp.smethod_83(NameTxt, CheckUp.smethod_82(CheckUp.smethod_81(CheckUp.smethod_80(CheckUp.smethod_79(CheckUp.smethod_78(CheckUp.smethod_76(SearchResultGrid), CheckUp.smethod_77(e))), 1))));
						num = (int)((num2 * 1456967646) ^ 0xD9296C5);
						continue;
					case 5u:
						CheckUp.smethod_83(AddressTxt, CheckUp.smethod_82(CheckUp.smethod_81(CheckUp.smethod_80(CheckUp.smethod_79(CheckUp.smethod_78(CheckUp.smethod_76(SearchResultGrid), CheckUp.smethod_77(e))), 5))));
						num = ((int)num2 * -383477149) ^ 0x2069226E;
						continue;
					case 4u:
						CheckUp.smethod_72((Control)(object)ClearBtn, bool_0: true);
						num = (int)((num2 * 1183862385) ^ 0x20B93CA0);
						continue;
					case 1u:
						CheckUp.smethod_72((Control)(object)PatientInfoBox, bool_0: true);
						num = (int)(num2 * 980563710) ^ -887010983;
						continue;
					case 0u:
						num = ((int)num2 * -1689674362) ^ 0x690B996E;
						continue;
					case 2u:
						break;
					default:
						SetPaymentBoxFields();
						return;
					}
					break;
				}
			}
		}
		catch (Exception ex)
		{
			CheckUp.smethod_73(ex);
			Exception exception_ = ex;
			CheckUp.smethod_62(CheckUp.smethod_84(exception_));
			while (true)
			{
				_ = -73745545;
				while (true)
				{
					_003F val = /*Error near IL_0257: Stack underflow*/^ -1510785463;
					uint num2 = (uint)(int)val;
					switch (val % 3)
					{
					default:
						return;
					case 1:
						CheckUp.smethod_74();
						_ = ((int)num2 * -587847874) ^ -20866994;
						continue;
					case 0:
						break;
					case 2:
						return;
					}
					break;
				}
			}
		}
	}

	private bool SetPaymentBoxFields()
	{
		CheckUp.smethod_83(TokenNoTxt, CheckUp.smethod_85(MyProject.Forms.Form1.Current_tokenNo));
		bool result = default(bool);
		while (true)
		{
			int num = -80549876;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAE7D49F2u) % 8u)
				{
				case 6u:
					num = (int)(num2 * 2064961136) ^ -1266396833;
					continue;
				case 5u:
					CheckUp.smethod_83(RoomNoTxt, CheckUp.smethod_85(checked(MyProject.Forms.Form1.Current_RoomNo + 100)));
					num = ((int)num2 * -1585053323) ^ -14328296;
					continue;
				case 3u:
					num = (int)(num2 * 970089716) ^ -1736305452;
					continue;
				case 2u:
					CheckUp.smethod_83(FeesTxt, "500");
					num = ((int)num2 * -1986010908) ^ -323964294;
					continue;
				case 1u:
					num = (int)((num2 * 673354609) ^ 0x6FDD283C);
					continue;
				case 0u:
					result = true;
					num = (int)((num2 * 871435072) ^ 0x131A2A9B);
					continue;
				case 4u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private bool HideItemsOnForm()
	{
		bool result = default(bool);
		while (true)
		{
			int num = -1900051668;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEF0839ADu) % 9u)
				{
				case 7u:
					CheckUp.smethod_72((Control)(object)PaymentBox, bool_0: false);
					num = ((int)num2 * -1559450775) ^ -806186149;
					continue;
				case 6u:
					CheckUp.smethod_72((Control)(object)ClearBtn, bool_0: false);
					num = (int)((num2 * 1920274061) ^ 0x67892A38);
					continue;
				case 4u:
					CheckUp.smethod_72((Control)(object)PatientInfoBox, bool_0: false);
					num = ((int)num2 * -407294250) ^ -1508891793;
					continue;
				case 3u:
					num = (int)((num2 * 581865297) ^ 0x4F37967D);
					continue;
				case 2u:
					num = ((int)num2 * -1145596966) ^ 0x43444E51;
					continue;
				case 1u:
					CheckUp.smethod_72((Control)(object)SearchResultGrid, bool_0: false);
					num = (int)(num2 * 1103718705) ^ -204212689;
					continue;
				case 0u:
					CheckUp.smethod_72((Control)(object)PrintBtn, bool_0: false);
					result = true;
					num = ((int)num2 * -1859492363) ^ 0x31C3DACE;
					continue;
				case 8u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private void PrintBtn_Click(object sender, EventArgs e)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Invalid comparison between Unknown and I4
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 651397181;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7BBB0D82u) % 18u)
				{
				case 16u:
					CheckUp.smethod_87(PrintDialog1, PrintDocument1);
					num = ((int)num2 * -1789718871) ^ -2093793275;
					continue;
				case 15u:
					num = 836409764;
					continue;
				case 14u:
					CheckUp.smethod_90(PrintDialog1, bool_0: true);
					num = (int)((num2 * 1241770221) ^ 0x7B60C139);
					continue;
				case 13u:
					num = ((int)num2 * -621994570) ^ -1524359899;
					continue;
				case 11u:
					CheckUp.smethod_62("No Patient to Print");
					num = ((int)num2 * -743243465) ^ -2008174720;
					continue;
				case 10u:
					CheckUp.smethod_94(PrintDocument1);
					num = (int)((num2 * 1820648174) ^ 0x6CB93099);
					continue;
				case 9u:
					num = ((int)num2 * -819312394) ^ 0x4992AF5C;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 1756093818;
						num6 = 1756093818;
					}
					else
					{
						num5 = 1321819223;
						num6 = 1321819223;
					}
					num = num5 ^ (int)(num2 * 1944102322);
					continue;
				}
				case 7u:
					flag2 = (int)CheckUp.smethod_91((CommonDialog)(object)PrintDialog1) == 1;
					num = (int)((num2 * 684028818) ^ 0x3D6487B4);
					continue;
				case 6u:
					MyProject.Forms.Form1.Current_tokenNo = checked(MyProject.Forms.Form1.Current_tokenNo + 1);
					MyProject.Forms.Form1.Current_RoomNo = checked(MyProject.Forms.Form1.Current_RoomNo + 1) % 8;
					num = (int)((num2 * 74623767) ^ 0x1F528388);
					continue;
				case 5u:
					flag = CheckUp.smethod_86(CheckUp.smethod_60(PIDTxt), "", bool_0: false) == 0;
					num = ((int)num2 * -541883839) ^ -505752704;
					continue;
				case 4u:
					CheckUp.smethod_89(PrintDialog1, CheckUp.smethod_88(PrintDocument1));
					num = (int)((num2 * 1953756183) ^ 0x1B27E9FC);
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 910158353;
						num4 = 910158353;
					}
					else
					{
						num3 = 97284923;
						num4 = 97284923;
					}
					num = num3 ^ ((int)num2 * -561066442);
					continue;
				}
				case 2u:
					CheckUp.smethod_93(PrintDocument1, CheckUp.smethod_92(PrintDialog1));
					num = ((int)num2 * -1634894804) ^ -667526726;
					continue;
				case 1u:
					num = 2051008289;
					continue;
				case 0u:
					num = (int)(num2 * 1257574651) ^ -636862092;
					continue;
				default:
					return;
				case 12u:
					break;
				case 17u:
					return;
				}
				break;
			}
		}
	}

	private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
	{
		Font font_ = CheckUp.smethod_95("Times New Roman", 20f);
		Font font_2 = default(Font);
		while (true)
		{
			int num = 1698195161;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7E713120u) % 10u)
				{
				case 9u:
					CheckUp.smethod_98(CheckUp.smethod_96(e), CheckUp.smethod_58("Name - ", CheckUp.smethod_60(NameTxt)) ?? "", font_2, CheckUp.smethod_97(), 100f, 400f);
					num = 1133996520;
					continue;
				case 8u:
					num = ((int)num2 * -1632008161) ^ 0x634FD9F0;
					continue;
				case 5u:
					CheckUp.smethod_98(CheckUp.smethod_96(e), CheckUp.smethod_58("Room No. - ", CheckUp.smethod_60(RoomNoTxt)) ?? "", font_2, CheckUp.smethod_97(), 100f, 1200f);
					num = 1583741247;
					continue;
				case 4u:
					CheckUp.smethod_98(CheckUp.smethod_96(e), CheckUp.smethod_58("Mobile - ", mobile) ?? "", font_2, CheckUp.smethod_97(), 100f, 800f);
					num = 748025712;
					continue;
				case 3u:
					num = ((int)num2 * -2098402074) ^ 0x181A9B98;
					continue;
				case 2u:
					CheckUp.smethod_98(CheckUp.smethod_96(e), CheckUp.smethod_58("Token No. - ", CheckUp.smethod_60(TokenNoTxt)) ?? "", font_2, CheckUp.smethod_97(), 100f, 1000f);
					num = 1784939094;
					continue;
				case 1u:
					font_2 = CheckUp.smethod_95("Times New Roman", 12f);
					CheckUp.smethod_98(CheckUp.smethod_96(e), "Check Up", font_, CheckUp.smethod_97(), 250f, 100f);
					num = (int)((num2 * 831688988) ^ 0x64572313);
					continue;
				case 0u:
					num = ((int)num2 * -1473246484) ^ 0x44E26499;
					continue;
				case 7u:
					break;
				default:
					CheckUp.smethod_98(CheckUp.smethod_96(e), CheckUp.smethod_58("Fees - ", CheckUp.smethod_60(FeesTxt)) ?? "", font_2, CheckUp.smethod_97(), 100f, 1400f);
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

	static DataGridView smethod_4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DataGridView();
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

	static TextBox smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static PrintDocument smethod_8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PrintDocument();
	}

	static PrintDialog smethod_9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PrintDialog();
	}

	static PictureBox smethod_10()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PictureBox();
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

	static Font smethod_14(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_15(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_16(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_17(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_18(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_19(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_20(Label label_0, string string_0)
	{
		label_0.set_Text(string_0);
	}

	static void smethod_21(Label label_0, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_TextAlign(contentAlignment_0);
	}

	static void smethod_22(DataGridView dataGridView_0, Color color_0)
	{
		dataGridView_0.set_BackgroundColor(color_0);
	}

	static void smethod_23(DataGridView dataGridView_0, DataGridViewColumnHeadersHeightSizeMode dataGridViewColumnHeadersHeightSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		dataGridView_0.set_ColumnHeadersHeightSizeMode(dataGridViewColumnHeadersHeightSizeMode_0);
	}

	static void smethod_24(DataGridView dataGridView_0, bool bool_0)
	{
		dataGridView_0.set_ReadOnly(bool_0);
	}

	static DataGridViewRow smethod_25(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_RowTemplate();
	}

	static void smethod_26(DataGridViewRow dataGridViewRow_0, int int_0)
	{
		dataGridViewRow_0.set_Height(int_0);
	}

	static ControlCollection smethod_27(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_28(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_29(GroupBox groupBox_0, bool bool_0)
	{
		groupBox_0.set_TabStop(bool_0);
	}

	static void smethod_30(GroupBox groupBox_0, string string_0)
	{
		groupBox_0.set_Text(string_0);
	}

	static void smethod_31(ButtonBase buttonBase_0, Color color_0)
	{
		buttonBase_0.set_BackColor(color_0);
	}

	static void smethod_32(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
	}

	static void smethod_33(ButtonBase buttonBase_0, string string_0)
	{
		buttonBase_0.set_Text(string_0);
	}

	static void smethod_34(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_35(TextBoxBase textBoxBase_0, bool bool_0)
	{
		textBoxBase_0.set_ReadOnly(bool_0);
	}

	static void smethod_36(TextBox textBox_0, bool bool_0)
	{
		textBox_0.set_Multiline(bool_0);
	}

	static void smethod_37(PrintDialog printDialog_0, bool bool_0)
	{
		printDialog_0.set_UseEXDialog(bool_0);
	}

	static void smethod_38(PictureBox pictureBox_0, Image image_0)
	{
		pictureBox_0.set_Image(image_0);
	}

	static void smethod_39(PictureBox pictureBox_0, PictureBoxSizeMode pictureBoxSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		pictureBox_0.set_SizeMode(pictureBoxSizeMode_0);
	}

	static void smethod_40(PictureBox pictureBox_0, int int_0)
	{
		pictureBox_0.set_TabIndex(int_0);
	}

	static void smethod_41(PictureBox pictureBox_0, bool bool_0)
	{
		pictureBox_0.set_TabStop(bool_0);
	}

	static void smethod_42(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_43(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_44(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static ControlCollection smethod_45(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_46(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_47(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_48(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_49(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_50(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_51(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_52(DataGridView dataGridView_0, DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler_0)
	{
		dataGridView_0.remove_CellMouseClick(dataGridViewCellMouseEventHandler_0);
	}

	static void smethod_53(DataGridView dataGridView_0, DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler_0)
	{
		dataGridView_0.add_CellMouseClick(dataGridViewCellMouseEventHandler_0);
	}

	static void smethod_54(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_55(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_56(PrintDocument printDocument_0, PrintPageEventHandler printPageEventHandler_0)
	{
		printDocument_0.remove_PrintPage(printPageEventHandler_0);
	}

	static void smethod_57(PrintDocument printDocument_0, PrintPageEventHandler printPageEventHandler_0)
	{
		printDocument_0.add_PrintPage(printPageEventHandler_0);
	}

	static string smethod_58(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_59(OleDbConnection oleDbConnection_0, string string_0)
	{
		oleDbConnection_0.set_ConnectionString(string_0);
	}

	static string smethod_60(TextBox textBox_0)
	{
		return textBox_0.get_Text();
	}

	static string smethod_61(string string_0)
	{
		return string_0.ToLower();
	}

	static DialogResult smethod_62(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}

	static OleDbCommand smethod_63()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new OleDbCommand();
	}

	static string smethod_64(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static DataTable smethod_65()
	{
		return new DataTable();
	}

	static void smethod_66(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Open();
	}

	static OleDbDataAdapter smethod_67(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbDataAdapter(string_0, oleDbConnection_0);
	}

	static int smethod_68(DbDataAdapter dbDataAdapter_0, DataTable dataTable_0)
	{
		return dbDataAdapter_0.Fill(dataTable_0);
	}

	static void smethod_69(DataGridView dataGridView_0, object object_0)
	{
		dataGridView_0.set_DataSource(object_0);
	}

	static int smethod_70(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_RowCount();
	}

	static void smethod_71(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Close();
	}

	static void smethod_72(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static void smethod_73(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_74()
	{
		ProjectData.ClearProjectError();
	}

	static void smethod_75(TextBoxBase textBoxBase_0)
	{
		textBoxBase_0.Clear();
	}

	static DataGridViewRowCollection smethod_76(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_Rows();
	}

	static int smethod_77(DataGridViewCellMouseEventArgs dataGridViewCellMouseEventArgs_0)
	{
		return dataGridViewCellMouseEventArgs_0.get_RowIndex();
	}

	static DataGridViewRow smethod_78(DataGridViewRowCollection dataGridViewRowCollection_0, int int_0)
	{
		return dataGridViewRowCollection_0.get_Item(int_0);
	}

	static DataGridViewCellCollection smethod_79(DataGridViewRow dataGridViewRow_0)
	{
		return dataGridViewRow_0.get_Cells();
	}

	static DataGridViewCell smethod_80(DataGridViewCellCollection dataGridViewCellCollection_0, int int_0)
	{
		return dataGridViewCellCollection_0.get_Item(int_0);
	}

	static object smethod_81(DataGridViewCell dataGridViewCell_0)
	{
		return dataGridViewCell_0.get_Value();
	}

	static string smethod_82(object object_0)
	{
		return Conversions.ToString(object_0);
	}

	static void smethod_83(TextBox textBox_0, string string_0)
	{
		textBox_0.set_Text(string_0);
	}

	static string smethod_84(Exception exception_0)
	{
		return exception_0.Message;
	}

	static string smethod_85(int int_0)
	{
		return Conversions.ToString(int_0);
	}

	static int smethod_86(string string_0, string string_1, bool bool_0)
	{
		return Operators.CompareString(string_0, string_1, bool_0);
	}

	static void smethod_87(PrintDialog printDialog_0, PrintDocument printDocument_0)
	{
		printDialog_0.set_Document(printDocument_0);
	}

	static PrinterSettings smethod_88(PrintDocument printDocument_0)
	{
		return printDocument_0.get_PrinterSettings();
	}

	static void smethod_89(PrintDialog printDialog_0, PrinterSettings printerSettings_0)
	{
		printDialog_0.set_PrinterSettings(printerSettings_0);
	}

	static void smethod_90(PrintDialog printDialog_0, bool bool_0)
	{
		printDialog_0.set_AllowSomePages(bool_0);
	}

	static DialogResult smethod_91(CommonDialog commonDialog_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return commonDialog_0.ShowDialog();
	}

	static PrinterSettings smethod_92(PrintDialog printDialog_0)
	{
		return printDialog_0.get_PrinterSettings();
	}

	static void smethod_93(PrintDocument printDocument_0, PrinterSettings printerSettings_0)
	{
		printDocument_0.set_PrinterSettings(printerSettings_0);
	}

	static void smethod_94(PrintDocument printDocument_0)
	{
		printDocument_0.Print();
	}

	static Font smethod_95(string string_0, float float_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new Font(string_0, float_0);
	}

	static Graphics smethod_96(PrintPageEventArgs printPageEventArgs_0)
	{
		return printPageEventArgs_0.get_Graphics();
	}

	static Brush smethod_97()
	{
		return Brushes.get_Chocolate();
	}

	static void smethod_98(Graphics graphics_0, string string_0, Font font_0, Brush brush_0, float float_0, float float_1)
	{
		graphics_0.DrawString(string_0, font_0, brush_0, float_0, float_1);
	}
}
