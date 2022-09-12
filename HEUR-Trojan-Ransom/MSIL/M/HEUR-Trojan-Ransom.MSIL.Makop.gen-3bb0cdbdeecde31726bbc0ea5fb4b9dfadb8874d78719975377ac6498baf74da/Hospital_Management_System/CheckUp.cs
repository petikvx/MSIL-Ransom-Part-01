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
			DataGridView searchResultGrid = default(DataGridView);
			while (true)
			{
				int num = -1473303205;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x89F338B9u) % 8u)
					{
					case 7u:
						_SearchResultGrid = value;
						searchResultGrid = _SearchResultGrid;
						num = -860249987;
						continue;
					case 6u:
						CheckUp.smethod_53(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = ((int)num2 * -1568063342) ^ 0x6612F4F0;
						continue;
					case 4u:
					{
						int num5;
						int num6;
						if (searchResultGrid != null)
						{
							num5 = 1745165619;
							num6 = 1745165619;
						}
						else
						{
							num5 = 1256120016;
							num6 = 1256120016;
						}
						num = num5 ^ (int)(num2 * 703726307);
						continue;
					}
					case 3u:
					{
						int num3;
						int num4;
						if (searchResultGrid != null)
						{
							num3 = 437291623;
							num4 = 437291623;
						}
						else
						{
							num3 = 1958054177;
							num4 = 1958054177;
						}
						num = num3 ^ (int)(num2 * 1196818597);
						continue;
					}
					case 2u:
						searchResultGrid = _SearchResultGrid;
						num = (int)(num2 * 1723107267) ^ -1404099092;
						continue;
					case 1u:
						CheckUp.smethod_52(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = (int)((num2 * 1755978812) ^ 0x5128E02);
						continue;
					default:
						return;
					case 0u:
						break;
					case 5u:
						return;
					}
					break;
				}
			}
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
			Button searchBtn = _SearchBtn;
			if (searchBtn != null)
			{
				goto IL_0056;
			}
			goto IL_009a;
			IL_009a:
			_SearchBtn = value;
			searchBtn = _SearchBtn;
			int num = 1381550885;
			goto IL_0071;
			IL_0071:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1908EDA0u) % 6u)
				{
				case 5u:
				{
					int num3;
					int num4;
					if (searchBtn == null)
					{
						num3 = -1240693396;
						num4 = -1240693396;
					}
					else
					{
						num3 = -1779153538;
						num4 = -1779153538;
					}
					num = num3 ^ ((int)num2 * -606270828);
					continue;
				}
				case 4u:
					CheckUp.smethod_55((Control)(object)searchBtn, eventHandler_);
					num = ((int)num2 * -910908164) ^ -2062869872;
					continue;
				case 3u:
					break;
				case 1u:
					CheckUp.smethod_54((Control)(object)searchBtn, eventHandler_);
					num = (int)(num2 * 2110760996) ^ -97248732;
					continue;
				default:
					return;
				case 2u:
					goto IL_009a;
				case 0u:
					return;
				}
				break;
			}
			goto IL_0056;
			IL_0056:
			num = 987161467;
			goto IL_0071;
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
				int num = 819357000;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x47EED1CEu) % 8u)
					{
					case 7u:
					{
						int num5;
						int num6;
						if (clearBtn == null)
						{
							num5 = 1812317473;
							num6 = 1812317473;
						}
						else
						{
							num5 = 954119002;
							num6 = 954119002;
						}
						num = num5 ^ ((int)num2 * -317610574);
						continue;
					}
					case 6u:
					{
						clearBtn = _ClearBtn;
						int num3;
						int num4;
						if (clearBtn == null)
						{
							num3 = -19447776;
							num4 = -19447776;
						}
						else
						{
							num3 = -1937934548;
							num4 = -1937934548;
						}
						num = num3 ^ ((int)num2 * -1198550987);
						continue;
					}
					case 5u:
						clearBtn = _ClearBtn;
						num = (int)(num2 * 792707092) ^ -322031347;
						continue;
					case 4u:
						CheckUp.smethod_54((Control)(object)clearBtn, eventHandler_);
						num = (int)((num2 * 1454767422) ^ 0x62F5EFD6);
						continue;
					case 2u:
						CheckUp.smethod_55((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -1409484271) ^ 0xBE1CF15;
						continue;
					case 0u:
						_ClearBtn = value;
						num = 1494248403;
						continue;
					default:
						return;
					case 3u:
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
			Button printBtn = _PrintBtn;
			if (printBtn != null)
			{
				goto IL_0026;
			}
			goto IL_0088;
			IL_0088:
			_PrintBtn = value;
			printBtn = _PrintBtn;
			int num;
			int num2;
			if (printBtn == null)
			{
				num = -938802724;
				num2 = -938802724;
			}
			else
			{
				num = -568642778;
				num2 = -568642778;
			}
			goto IL_0057;
			IL_0057:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num ^ 0xE3ABD0FEu) % 5u)
				{
				case 3u:
					break;
				case 2u:
					CheckUp.smethod_54((Control)(object)printBtn, eventHandler_);
					num = ((int)num3 * -1929399452) ^ 0x567812DB;
					continue;
				case 0u:
					CheckUp.smethod_55((Control)(object)printBtn, eventHandler_);
					num = (int)((num3 * 63673511) ^ 0x7E6E8034);
					continue;
				default:
					return;
				case 4u:
					goto IL_0088;
				case 1u:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			num = -176726637;
			goto IL_0057;
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
			PrintDocument printDocument = default(PrintDocument);
			while (true)
			{
				int num = 101313881;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x544684F4u) % 8u)
					{
					case 7u:
					{
						int num5;
						int num6;
						if (printDocument == null)
						{
							num5 = 547671879;
							num6 = 547671879;
						}
						else
						{
							num5 = 1396059733;
							num6 = 1396059733;
						}
						num = num5 ^ ((int)num2 * -406102169);
						continue;
					}
					case 6u:
						_PrintDocument1 = value;
						num = 1763549672;
						continue;
					case 5u:
					{
						printDocument = _PrintDocument1;
						int num3;
						int num4;
						if (printDocument == null)
						{
							num3 = -1624819581;
							num4 = -1624819581;
						}
						else
						{
							num3 = -1746533220;
							num4 = -1746533220;
						}
						num = num3 ^ (int)(num2 * 1660689021);
						continue;
					}
					case 4u:
						printDocument = _PrintDocument1;
						num = ((int)num2 * -2107781250) ^ -654218085;
						continue;
					case 1u:
						CheckUp.smethod_56(printDocument, printPageEventHandler_);
						num = ((int)num2 * -1215086152) ^ 0x245456C2;
						continue;
					case 0u:
						CheckUp.smethod_57(printDocument, printPageEventHandler_);
						num = (int)(num2 * 1038676271) ^ -1340210938;
						continue;
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
			if (disposing)
			{
				goto IL_005e;
			}
			int num = 0;
			goto IL_0099;
			IL_0090:
			num = ((components != null) ? 1 : 0);
			goto IL_0099;
			IL_005e:
			int num2 = -2085404854;
			goto IL_0063;
			IL_0063:
			bool flag = default(bool);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xBFB74897u) % 7u)
				{
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 702185879;
						num5 = 702185879;
					}
					else
					{
						num4 = 1028722942;
						num5 = 1028722942;
					}
					num2 = num4 ^ ((int)num3 * -507096732);
					continue;
				}
				case 4u:
					num2 = (int)(num3 * 1679548016) ^ -1909462606;
					continue;
				case 3u:
					CheckUp.smethod_2((IDisposable)components);
					num2 = (int)((num3 * 521808021) ^ 0x1ED62274);
					continue;
				case 1u:
					num2 = -1491514532;
					continue;
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0090;
				case 6u:
					return;
				}
				break;
			}
			goto IL_005e;
			IL_0099:
			flag = (byte)num != 0;
			num2 = -1423875752;
			goto IL_0063;
		}
		finally
		{
			while (true)
			{
				IL_00ea:
				int num6 = -1174933424;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0xBFB74897u) % 4u)
					{
					case 3u:
						((ContainerControl)this).Dispose(disposing);
						num6 = ((int)num3 * -49921314) ^ -767361017;
						continue;
					case 2u:
						num6 = ((int)num3 * -1463979581) ^ 0x942580;
						continue;
					default:
						goto end_IL_00c9;
					case 0u:
						break;
					case 1u:
						goto end_IL_00c9;
					}
					goto IL_00ea;
					continue;
					end_IL_00c9:
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
			int num = -1229973177;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA4B1B183u) % 335u)
				{
				case 334u:
					AddressTxt = CheckUp.smethod_7();
					num = ((int)num2 * -1115077302) ^ 0x581CA5F1;
					continue;
				case 333u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PaymentBox), (Control)(object)FeesTxt);
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PaymentBox), (Control)(object)TokenNoTxt);
					num = ((int)num2 * -1580225743) ^ 0x1F1FEFB2;
					continue;
				case 332u:
					CheckUp.smethod_30(SearchBox, "Search Patient");
					num = (int)(num2 * 2112320864) ^ -173104508;
					continue;
				case 331u:
					MobileTxt = CheckUp.smethod_7();
					NameSTxt = CheckUp.smethod_7();
					Label2 = CheckUp.smethod_3();
					PatientInfoBox = CheckUp.smethod_5();
					num = ((int)num2 * -1567122535) ^ -693884219;
					continue;
				case 330u:
					num = (int)(num2 * 1346197576) ^ -1078486377;
					continue;
				case 329u:
					CheckUp.smethod_18((Control)(object)NameTxt, new Size(328, 26));
					num = (int)(num2 * 1946247425) ^ -1451769871;
					continue;
				case 328u:
					num = (int)(num2 * 798126249) ^ -553228916;
					continue;
				case 327u:
					CheckUp.smethod_18((Control)(object)Label6, new Size(84, 26));
					num = (int)(num2 * 2007849305) ^ -1787760410;
					continue;
				case 326u:
					CheckUp.smethod_21(Label2, (ContentAlignment)32);
					num = (int)((num2 * 76321835) ^ 0x382F93C8);
					continue;
				case 325u:
					num = ((int)num2 * -2010424904) ^ 0x4561D9FF;
					continue;
				case 324u:
					CheckUp.smethod_18((Control)(object)Label11, new Size(76, 26));
					num = (int)(num2 * 1533044300) ^ -571120416;
					continue;
				case 323u:
					CheckUp.smethod_18((Control)(object)Label7, new Size(105, 26));
					num = (int)((num2 * 1089463407) ^ 0x49A4F1F4);
					continue;
				case 322u:
					CheckUp.smethod_18((Control)(object)SearchBox, new Size(623, 128));
					CheckUp.smethod_19((Control)(object)SearchBox, 4);
					num = (int)(num2 * 1651666661) ^ -460666102;
					continue;
				case 321u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)Label7);
					num = (int)((num2 * 1328266945) ^ 0x3FF7CFD3);
					continue;
				case 320u:
					num = (int)((num2 * 170450945) ^ 0x1F92EBEE);
					continue;
				case 319u:
					CheckUp.smethod_47((Control)(object)this, new Size(977, 804));
					num = ((int)num2 * -2018137629) ^ 0x97F3922;
					continue;
				case 318u:
					Label1 = CheckUp.smethod_3();
					num = (int)((num2 * 1604956807) ^ 0x791C4E0A);
					continue;
				case 317u:
					num = ((int)num2 * -1563074875) ^ 0x738D86FA;
					continue;
				case 316u:
					num = (int)((num2 * 7215346) ^ 0x59DD8BA5);
					continue;
				case 315u:
					CheckUp.smethod_15((Control)(object)Label7, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1479542540) ^ -476730457;
					continue;
				case 314u:
					CheckUp.smethod_38(PictureBox1, (Image)(object)Resources.doc_Pic);
					num = ((int)num2 * -1325966471) ^ -1678794965;
					continue;
				case 313u:
					CheckUp.smethod_16((Control)(object)Label4, new Point(20, 46));
					num = (int)((num2 * 1770376197) ^ 0x3E719F56);
					continue;
				case 312u:
					CheckUp.smethod_20(Label7, "Address : ");
					num = (int)(num2 * 800391654) ^ -1876208002;
					continue;
				case 311u:
					num = (int)(num2 * 490607234) ^ -879260496;
					continue;
				case 310u:
					Label5 = CheckUp.smethod_3();
					num = (int)(num2 * 1248303887) ^ -2113758753;
					continue;
				case 309u:
					num = ((int)num2 * -1163778555) ^ 0x4FBD4724;
					continue;
				case 308u:
					CheckUp.smethod_15((Control)(object)RoomNoTxt, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1084437710) ^ 0x5BDC2E01;
					continue;
				case 307u:
					CheckUp.smethod_20(Label1, "Check-Up");
					num = ((int)num2 * -1041416459) ^ 0x397B73FF;
					continue;
				case 306u:
					CheckUp.smethod_18((Control)(object)SearchBtn, new Size(133, 37));
					num = (int)(num2 * 112401056) ^ -1865743049;
					continue;
				case 305u:
					num = (int)((num2 * 2015370158) ^ 0x45DCC148);
					continue;
				case 304u:
					CheckUp.smethod_16((Control)(object)NameTxt, new Point(94, 80));
					num = ((int)num2 * -262087167) ^ -784018865;
					continue;
				case 303u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)DOBTxt);
					num = (int)(num2 * 482202269) ^ -554493441;
					continue;
				case 302u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PaymentBox), (Control)(object)Label10);
					num = ((int)num2 * -1228894583) ^ 0x66ACACE0;
					continue;
				case 301u:
					CheckUp.smethod_15((Control)(object)DOBTxt, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					CheckUp.smethod_16((Control)(object)DOBTxt, new Point(94, 115));
					num = ((int)num2 * -362552301) ^ -1528002877;
					continue;
				case 300u:
					CheckUp.smethod_17((Control)(object)FeesTxt, "FeesTxt");
					num = (int)((num2 * 1875473507) ^ 0x344A833C);
					continue;
				case 298u:
					num = (int)((num2 * 517952308) ^ 0x5AF4B56E);
					continue;
				case 297u:
					CheckUp.smethod_35((TextBoxBase)(object)FeesTxt, bool_0: true);
					num = (int)((num2 * 2106877960) ^ 0x5952BA28);
					continue;
				case 296u:
					CheckUp.smethod_40(PictureBox1, 2);
					CheckUp.smethod_41(PictureBox1, bool_0: false);
					num = (int)(num2 * 657879409) ^ -823526944;
					continue;
				case 295u:
					num = ((int)num2 * -1884373225) ^ 0xA09885E;
					continue;
				case 294u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)Label6);
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)Label5);
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)Label4);
					num = (int)(num2 * 1055362592) ^ -272380063;
					continue;
				case 293u:
					PaymentBox = CheckUp.smethod_5();
					num = (int)(num2 * 1255765875) ^ -1736065001;
					continue;
				case 292u:
					CheckUp.smethod_21(Label3, (ContentAlignment)32);
					num = ((int)num2 * -1999267630) ^ 0x210FE080;
					continue;
				case 291u:
					num = (int)(num2 * 584199304) ^ -1026057788;
					continue;
				case 290u:
					CheckUp.smethod_21(Label10, (ContentAlignment)32);
					CheckUp.smethod_15((Control)(object)Label9, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1437458887) ^ -1339974692;
					continue;
				case 289u:
					num = (int)((num2 * 796288206) ^ 0x79ED5FEE);
					continue;
				case 288u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)SearchBox), (Control)(object)Label2);
					num = (int)(num2 * 959687193) ^ -285849248;
					continue;
				case 287u:
					CheckUp.smethod_18((Control)(object)Label1, new Size(261, 47));
					num = (int)(num2 * 24262960) ^ -2079580704;
					continue;
				case 286u:
					CheckUp.smethod_16((Control)(object)Label10, new Point(18, 114));
					num = (int)((num2 * 568852518) ^ 0x4B3522F6);
					continue;
				case 285u:
					CheckUp.smethod_20(Label8, "Room No :");
					num = ((int)num2 * -1725061252) ^ -1027566132;
					continue;
				case 284u:
					CheckUp.smethod_23(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					num = (int)(num2 * 1586111216) ^ -1555344094;
					continue;
				case 283u:
					CheckUp.smethod_19((Control)(object)AddressTxt, 7);
					num = ((int)num2 * -947474038) ^ 0x31B52EE;
					continue;
				case 282u:
					CheckUp.smethod_18((Control)(object)PictureBox1, new Size(126, 122));
					num = (int)((num2 * 1781772512) ^ 0x23C22A1B);
					continue;
				case 281u:
					CheckUp.smethod_18((Control)(object)Label3, new Size(77, 28));
					num = ((int)num2 * -1992987398) ^ 0x309B628D;
					continue;
				case 280u:
					num = ((int)num2 * -1589465107) ^ 0x17FD287E;
					continue;
				case 279u:
					CheckUp.smethod_18((Control)(object)PaymentBox, new Size(286, 165));
					num = (int)((num2 * 1974985324) ^ 0x319C9F02);
					continue;
				case 278u:
					CheckUp.smethod_16((Control)(object)MobileTxt, new Point(120, 87));
					num = (int)(num2 * 1272168958) ^ -832897977;
					continue;
				case 277u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PaymentBox), (Control)(object)Label8);
					num = ((int)num2 * -718341396) ^ 0x79551425;
					continue;
				case 276u:
					CheckUp.smethod_11((ISupportInitialize)SearchResultGrid);
					num = ((int)num2 * -1250837369) ^ -1819044858;
					continue;
				case 275u:
					CheckUp.smethod_16((Control)(object)Label11, new Point(20, 80));
					CheckUp.smethod_17((Control)(object)Label11, "Label11");
					num = (int)(num2 * 1087972031) ^ -1764133190;
					continue;
				case 274u:
					CheckUp.smethod_16((Control)(object)PatientInfoBox, new Point(101, 485));
					num = ((int)num2 * -2123687223) ^ 0x4AD798F8;
					continue;
				case 273u:
					num = (int)(num2 * 1503245151) ^ -1460848875;
					continue;
				case 272u:
					num = (int)(num2 * 1554750796) ^ -701442974;
					continue;
				case 271u:
					num = (int)((num2 * 616658996) ^ 0x5503D3AD);
					continue;
				case 270u:
					CheckUp.smethod_17((Control)(object)PaymentBox, "PaymentBox");
					num = (int)((num2 * 864808785) ^ 0x1C4A7E36);
					continue;
				case 269u:
					CheckUp.smethod_49((Control)(object)SearchBox, bool_0: false);
					num = (int)(num2 * 310210472) ^ -566632617;
					continue;
				case 268u:
					num = (int)(num2 * 1301440926) ^ -1687332399;
					continue;
				case 267u:
					CheckUp.smethod_18((Control)(object)PIDTxt, new Size(130, 26));
					num = (int)(num2 * 2059394730) ^ -1480778530;
					continue;
				case 266u:
					CheckUp.smethod_17((Control)(object)SearchResultGrid, "SearchResultGrid");
					num = ((int)num2 * -596210195) ^ -437596193;
					continue;
				case 265u:
					num = ((int)num2 * -1687028430) ^ 0x7097AB18;
					continue;
				case 264u:
					CheckUp.smethod_35((TextBoxBase)(object)GenderTxt, bool_0: true);
					num = ((int)num2 * -747180002) ^ -1266982508;
					continue;
				case 263u:
					CheckUp.smethod_17((Control)(object)Label6, "Label6");
					num = (int)(num2 * 1588444300) ^ -16242934;
					continue;
				case 262u:
					CheckUp.smethod_32((Control)(object)ClearBtn, Color.White);
					num = (int)(num2 * 1753605200) ^ -1043492383;
					continue;
				case 261u:
					CheckUp.smethod_18((Control)(object)Label8, new Size(101, 25));
					num = ((int)num2 * -929218378) ^ 0x683910F6;
					continue;
				case 260u:
					PrintDialog1 = CheckUp.smethod_9();
					PictureBox1 = CheckUp.smethod_10();
					num = ((int)num2 * -337221699) ^ -2080726531;
					continue;
				case 259u:
					num = (int)(num2 * 891163909) ^ -46399997;
					continue;
				case 258u:
					CheckUp.smethod_16((Control)(object)PIDTxt, new Point(94, 43));
					CheckUp.smethod_17((Control)(object)PIDTxt, "PIDTxt");
					num = (int)(num2 * 770454418) ^ -1784511934;
					continue;
				case 257u:
					CheckUp.smethod_17((Control)(object)Label3, "Label3");
					num = ((int)num2 * -1778792160) ^ 0x1356C1AD;
					continue;
				case 256u:
					CheckUp.smethod_19((Control)(object)Label1, 0);
					num = (int)((num2 * 1673715043) ^ 0x44BD175F);
					continue;
				case 255u:
					RoomNoTxt = CheckUp.smethod_7();
					num = ((int)num2 * -1569266794) ^ -474297142;
					continue;
				case 254u:
					num = ((int)num2 * -563779720) ^ -589879632;
					continue;
				case 253u:
					num = ((int)num2 * -1661649989) ^ -1146490361;
					continue;
				case 252u:
					CheckUp.smethod_28(CheckUp.smethod_45((Control)(object)this), (Control)(object)ClearBtn);
					num = (int)((num2 * 1104722667) ^ 0xD0FDE49);
					continue;
				case 251u:
					CheckUp.smethod_15((Control)(object)Label10, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1834444866) ^ 0x4A37FBDE);
					continue;
				case 250u:
					CheckUp.smethod_19((Control)(object)DOBTxt, 5);
					num = ((int)num2 * -701693007) ^ -2133389762;
					continue;
				case 249u:
					CheckUp.smethod_50((Control)(object)PatientInfoBox);
					num = (int)(num2 * 1973946699) ^ -157638397;
					continue;
				case 248u:
					CheckUp.smethod_16((Control)(object)ClearBtn, new Point(589, 696));
					num = (int)((num2 * 292606920) ^ 0x5FC792B);
					continue;
				case 247u:
					CheckUp.smethod_18((Control)(object)Label2, new Size(77, 28));
					num = (int)((num2 * 1493624636) ^ 0x3BBFE079);
					continue;
				case 246u:
					CheckUp.smethod_32((Control)(object)PrintBtn, Color.White);
					num = ((int)num2 * -1177565124) ^ -371235196;
					continue;
				case 245u:
					CheckUp.smethod_15((Control)(object)GenderTxt, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -2029077947) ^ 0x30712E6;
					continue;
				case 244u:
					CheckUp.smethod_17((Control)(object)Label9, "Label9");
					CheckUp.smethod_18((Control)(object)Label9, new Size(107, 28));
					CheckUp.smethod_19((Control)(object)Label9, 2);
					num = (int)(num2 * 748224201) ^ -1552190740;
					continue;
				case 243u:
					CheckUp.smethod_15((Control)(object)PaymentBox, CheckUp.smethod_14("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -638085751) ^ -1268767389;
					continue;
				case 242u:
					PrintDocument1 = CheckUp.smethod_8();
					num = ((int)num2 * -1886115675) ^ 0x4AE50611;
					continue;
				case 241u:
					CheckUp.smethod_19((Control)(object)GenderTxt, 6);
					num = ((int)num2 * -2132202207) ^ 0x6F726401;
					continue;
				case 240u:
					CheckUp.smethod_28(CheckUp.smethod_45((Control)(object)this), (Control)(object)PictureBox1);
					num = (int)(num2 * 2044449798) ^ -1961542380;
					continue;
				case 239u:
					CheckUp.smethod_17((Control)(object)Label2, "Label2");
					num = (int)(num2 * 2034192615) ^ -943219765;
					continue;
				case 238u:
					CheckUp.smethod_15((Control)(object)Label6, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 777557817) ^ -1219273888;
					continue;
				case 237u:
					CheckUp.smethod_15((Control)(object)Label4, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -161975390) ^ 0x3CDC91F;
					continue;
				case 236u:
					CheckUp.smethod_16((Control)(object)Label7, new Point(20, 159));
					num = (int)((num2 * 611150813) ^ 0x57FBEF83);
					continue;
				case 235u:
					CheckUp.smethod_16((Control)(object)NameSTxt, new Point(120, 43));
					num = (int)((num2 * 423314956) ^ 0x173092B0);
					continue;
				case 234u:
					num = ((int)num2 * -424164702) ^ -2052379809;
					continue;
				case 233u:
					CheckUp.smethod_16((Control)(object)SearchBtn, new Point(468, 82));
					num = (int)(num2 * 629233127) ^ -1002696881;
					continue;
				case 232u:
					CheckUp.smethod_18((Control)(object)PatientInfoBox, new Size(439, 255));
					num = (int)((num2 * 98446818) ^ 0x47930E19);
					continue;
				case 231u:
					CheckUp.smethod_17((Control)(object)TokenNoTxt, "TokenNoTxt");
					num = (int)((num2 * 1582123276) ^ 0x5B330769);
					continue;
				case 230u:
					num = (int)(num2 * 1040177920) ^ -123889360;
					continue;
				case 229u:
					CheckUp.smethod_15((Control)(object)PatientInfoBox, CheckUp.smethod_14("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1284951648) ^ 0x5520C7B1);
					continue;
				case 228u:
					CheckUp.smethod_19((Control)(object)Label2, 0);
					num = ((int)num2 * -1718345700) ^ -1807302326;
					continue;
				case 227u:
					CheckUp.smethod_15((Control)(object)PIDTxt, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -967150063) ^ -703201467;
					continue;
				case 226u:
					CheckUp.smethod_21(Label8, (ContentAlignment)32);
					num = ((int)num2 * -290030661) ^ 0x5C6F968F;
					continue;
				case 225u:
					CheckUp.smethod_20(Label5, "DOB :");
					num = ((int)num2 * -1820841057) ^ -1218669298;
					continue;
				case 224u:
					CheckUp.smethod_29(SearchBox, bool_0: false);
					num = ((int)num2 * -640964542) ^ 0x3579594B;
					continue;
				case 223u:
					CheckUp.smethod_16((Control)(object)PrintBtn, new Point(756, 696));
					CheckUp.smethod_17((Control)(object)PrintBtn, "PrintBtn");
					num = ((int)num2 * -1306538474) ^ 0x3985454B;
					continue;
				case 222u:
					CheckUp.smethod_19((Control)(object)Label8, 1);
					num = ((int)num2 * -1055449423) ^ -1973338848;
					continue;
				case 221u:
					CheckUp.smethod_17((Control)(object)AddressTxt, "AddressTxt");
					num = (int)(num2 * 113044709) ^ -2003678117;
					continue;
				case 220u:
					CheckUp.smethod_15((Control)(object)Label1, CheckUp.smethod_14("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 2054590437) ^ -1189195452;
					continue;
				case 219u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)GenderTxt);
					num = ((int)num2 * -1829965655) ^ 0x70A23EFA;
					continue;
				case 218u:
					ClearBtn = CheckUp.smethod_6();
					num = (int)(num2 * 2084561162) ^ -614433162;
					continue;
				case 217u:
					CheckUp.smethod_17((Control)(object)Label4, "Label4");
					num = (int)(num2 * 1122241478) ^ -2136373061;
					continue;
				case 216u:
					TokenNoTxt = CheckUp.smethod_7();
					num = ((int)num2 * -408474456) ^ 0x4F13BB7D;
					continue;
				case 215u:
					num = ((int)num2 * -380856422) ^ 0x7D54B60D;
					continue;
				case 214u:
					CheckUp.smethod_17((Control)(object)NameSTxt, "NameSTxt");
					CheckUp.smethod_18((Control)(object)NameSTxt, new Size(237, 28));
					CheckUp.smethod_19((Control)(object)NameSTxt, 1);
					num = ((int)num2 * -889054701) ^ -15582305;
					continue;
				case 213u:
					SearchBtn = CheckUp.smethod_6();
					num = ((int)num2 * -343135534) ^ -1319879364;
					continue;
				case 212u:
					CheckUp.smethod_18((Control)(object)Label5, new Size(68, 26));
					num = ((int)num2 * -1288633088) ^ -1545987471;
					continue;
				case 211u:
					CheckUp.smethod_43((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 1423597365) ^ 0x423E5C23);
					continue;
				case 210u:
					CheckUp.smethod_19((Control)(object)SearchBtn, 4);
					num = ((int)num2 * -1784216653) ^ 0x2BD13352;
					continue;
				case 209u:
					num = ((int)num2 * -927717402) ^ -1403290165;
					continue;
				case 208u:
					CheckUp.smethod_16((Control)(object)PaymentBox, new Point(589, 485));
					num = ((int)num2 * -1071223753) ^ 0x415CECAB;
					continue;
				case 207u:
					CheckUp.smethod_48((ISupportInitialize)SearchResultGrid);
					num = ((int)num2 * -1904246773) ^ 0x2B6C4C95;
					continue;
				case 206u:
					CheckUp.smethod_18((Control)(object)RoomNoTxt, new Size(100, 26));
					num = ((int)num2 * -315688678) ^ 0x23437059;
					continue;
				case 205u:
					CheckUp.smethod_28(CheckUp.smethod_45((Control)(object)this), (Control)(object)PaymentBox);
					num = ((int)num2 * -1493393283) ^ 0x5B58681D;
					continue;
				case 204u:
					CheckUp.smethod_15((Control)(object)Label5, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					CheckUp.smethod_16((Control)(object)Label5, new Point(20, 115));
					num = ((int)num2 * -177224303) ^ -1916619956;
					continue;
				case 203u:
					CheckUp.smethod_28(CheckUp.smethod_45((Control)(object)this), (Control)(object)SearchResultGrid);
					num = (int)((num2 * 662040642) ^ 0x390D3751);
					continue;
				case 202u:
					CheckUp.smethod_24(SearchResultGrid, bool_0: true);
					num = ((int)num2 * -1670924428) ^ 0x4103C3BE;
					continue;
				case 201u:
					CheckUp.smethod_16((Control)(object)Label3, new Point(37, 87));
					num = (int)(num2 * 398677763) ^ -1832007200;
					continue;
				case 200u:
					CheckUp.smethod_17((Control)(object)MobileTxt, "MobileTxt");
					num = (int)(num2 * 1772927578) ^ -988550077;
					continue;
				case 199u:
					num = ((int)num2 * -180955201) ^ -246242128;
					continue;
				case 198u:
					CheckUp.smethod_49((Control)(object)PatientInfoBox, bool_0: false);
					num = ((int)num2 * -156065837) ^ -1547764139;
					continue;
				case 197u:
					num = ((int)num2 * -2084545437) ^ 0x716046FB;
					continue;
				case 196u:
					PrintBtn = CheckUp.smethod_6();
					num = ((int)num2 * -990425066) ^ -1894057686;
					continue;
				case 195u:
					CheckUp.smethod_28(CheckUp.smethod_45((Control)(object)this), (Control)(object)Label1);
					CheckUp.smethod_46((Control)(object)this, "CheckUp");
					num = (int)(num2 * 599620926) ^ -2033227394;
					continue;
				case 194u:
					CheckUp.smethod_19((Control)(object)Label3, 3);
					num = ((int)num2 * -1027704567) ^ -2084393528;
					continue;
				case 193u:
					CheckUp.smethod_33((ButtonBase)(object)SearchBtn, "Search");
					num = ((int)num2 * -845670136) ^ 0x367EB21;
					continue;
				case 192u:
					CheckUp.smethod_15((Control)(object)Label3, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 2083521316) ^ 0xF6570EE);
					continue;
				case 191u:
					CheckUp.smethod_15((Control)(object)NameTxt, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1142219570) ^ -806090545;
					continue;
				case 190u:
					Label9 = CheckUp.smethod_3();
					num = (int)(num2 * 2084158006) ^ -1848872602;
					continue;
				case 189u:
					CheckUp.smethod_16((Control)(object)SearchResultGrid, new Point(59, 295));
					num = ((int)num2 * -1010625841) ^ 0x5A037680;
					continue;
				case 188u:
					num = ((int)num2 * -977781932) ^ -2024330878;
					continue;
				case 187u:
					CheckUp.smethod_21(Label11, (ContentAlignment)32);
					num = (int)(num2 * 2003088523) ^ -1289600772;
					continue;
				case 186u:
					CheckUp.smethod_17((Control)(object)DOBTxt, "DOBTxt");
					num = (int)(num2 * 829803684) ^ -1686864634;
					continue;
				case 185u:
					num = (int)(num2 * 327002013) ^ -1024415683;
					continue;
				case 184u:
					CheckUp.smethod_35((TextBoxBase)(object)NameTxt, bool_0: true);
					num = (int)((num2 * 198418993) ^ 0x7773FE3D);
					continue;
				case 183u:
					CheckUp.smethod_17((Control)(object)RoomNoTxt, "RoomNoTxt");
					num = (int)(num2 * 661315805) ^ -657367078;
					continue;
				case 182u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PaymentBox), (Control)(object)RoomNoTxt);
					num = (int)((num2 * 1722754711) ^ 0x21F31F9F);
					continue;
				case 181u:
					CheckUp.smethod_44((Control)(object)this, Color.White);
					num = ((int)num2 * -1545128823) ^ 0x641AAF4;
					continue;
				case 180u:
					CheckUp.smethod_15((Control)(object)SearchBtn, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1901445776) ^ 0x72062AEF;
					continue;
				case 179u:
					CheckUp.smethod_49((Control)(object)PaymentBox, bool_0: false);
					num = (int)((num2 * 1949169406) ^ 0x5EC1B982);
					continue;
				case 178u:
					CheckUp.smethod_19((Control)(object)Label11, 8);
					CheckUp.smethod_20(Label11, "Name :");
					num = (int)((num2 * 328672866) ^ 0x7304D295);
					continue;
				case 177u:
					num = ((int)num2 * -623522824) ^ 0x2314B1B1;
					continue;
				case 176u:
					num = (int)(num2 * 1554471746) ^ -953602890;
					continue;
				case 175u:
					Label8 = CheckUp.smethod_3();
					num = ((int)num2 * -83054487) ^ -1303278246;
					continue;
				case 174u:
					num = ((int)num2 * -288468191) ^ 0x1C471086;
					continue;
				case 173u:
					CheckUp.smethod_31((ButtonBase)(object)PrintBtn, Color.MidnightBlue);
					num = ((int)num2 * -307861032) ^ -99545928;
					continue;
				case 172u:
					CheckUp.smethod_18((Control)(object)MobileTxt, new Size(237, 28));
					num = (int)(num2 * 1186523768) ^ -2076866635;
					continue;
				case 171u:
					num = ((int)num2 * -791091575) ^ 0x10868BE2;
					continue;
				case 170u:
					num = (int)((num2 * 272624083) ^ 0x3B30941E);
					continue;
				case 169u:
					CheckUp.smethod_20(Label4, "PID :");
					num = (int)(num2 * 801787813) ^ -1963855752;
					continue;
				case 168u:
					num = ((int)num2 * -2119366113) ^ -651353922;
					continue;
				case 167u:
					num = (int)(num2 * 1445657080) ^ -552771560;
					continue;
				case 166u:
					CheckUp.smethod_15((Control)(object)Label11, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 845565516) ^ 0x78843ADA);
					continue;
				case 165u:
					num = ((int)num2 * -1869869384) ^ 0x5AE6648;
					continue;
				case 164u:
					num = ((int)num2 * -1063110219) ^ 0x65683CD9;
					continue;
				case 163u:
					num = ((int)num2 * -450753351) ^ 0x2C73A7D1;
					continue;
				case 162u:
					CheckUp.smethod_19((Control)(object)ClearBtn, 7);
					CheckUp.smethod_33((ButtonBase)(object)ClearBtn, "Clear");
					CheckUp.smethod_34((ButtonBase)(object)ClearBtn, bool_0: false);
					num = ((int)num2 * -1532295438) ^ -494910690;
					continue;
				case 161u:
					num = (int)((num2 * 1218114389) ^ 0x18297CB1);
					continue;
				case 160u:
					CheckUp.smethod_37(PrintDialog1, bool_0: true);
					num = ((int)num2 * -1828899909) ^ 0x5734DCE4;
					continue;
				case 159u:
					num = ((int)num2 * -1024357153) ^ 0x66095741;
					continue;
				case 158u:
					CheckUp.smethod_18((Control)(object)FeesTxt, new Size(100, 26));
					num = ((int)num2 * -12948466) ^ -1108336820;
					continue;
				case 157u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)SearchBox), (Control)(object)SearchBtn);
					num = (int)(num2 * 169236541) ^ -326865607;
					continue;
				case 156u:
					CheckUp.smethod_15((Control)(object)SearchBox, CheckUp.smethod_14("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1814858940) ^ -316079654;
					continue;
				case 155u:
					num = ((int)num2 * -1342050524) ^ -1722568067;
					continue;
				case 154u:
					CheckUp.smethod_28(CheckUp.smethod_45((Control)(object)this), (Control)(object)PrintBtn);
					num = (int)(num2 * 1286046186) ^ -726737167;
					continue;
				case 153u:
					CheckUp.smethod_19((Control)(object)NameTxt, 9);
					num = (int)((num2 * 1795573650) ^ 0x74EF9F07);
					continue;
				case 152u:
					CheckUp.smethod_18((Control)(object)PrintBtn, new Size(119, 44));
					num = (int)((num2 * 1846048887) ^ 0x61C3E37C);
					continue;
				case 151u:
					num = (int)(num2 * 2034206209) ^ -458872798;
					continue;
				case 150u:
					CheckUp.smethod_21(Label1, (ContentAlignment)32);
					CheckUp.smethod_22(SearchResultGrid, Color.White);
					num = (int)((num2 * 1110247781) ^ 0x5211F95D);
					continue;
				case 149u:
					num = ((int)num2 * -1598738236) ^ -2011769545;
					continue;
				case 148u:
					CheckUp.smethod_16((Control)(object)GenderTxt, new Point(322, 115));
					num = (int)(num2 * 1659990378) ^ -1287186008;
					continue;
				case 147u:
					CheckUp.smethod_17((Control)(object)PatientInfoBox, "PatientInfoBox");
					num = (int)((num2 * 1864062386) ^ 0x77115F0);
					continue;
				case 146u:
					GenderTxt = CheckUp.smethod_7();
					num = ((int)num2 * -949564804) ^ -1119575407;
					continue;
				case 145u:
					num = ((int)num2 * -501700797) ^ 0x3D617A7C;
					continue;
				case 144u:
					CheckUp.smethod_20(Label6, "Gender : ");
					num = (int)((num2 * 855320564) ^ 0x26FFF1B3);
					continue;
				case 143u:
					SearchResultGrid = CheckUp.smethod_4();
					num = (int)(num2 * 865977589) ^ -467951580;
					continue;
				case 142u:
					num = (int)(num2 * 1552572852) ^ -1101970590;
					continue;
				case 141u:
					num = ((int)num2 * -1038462417) ^ 0xB7CA86B;
					continue;
				case 140u:
					num = ((int)num2 * -1395246443) ^ -552559374;
					continue;
				case 139u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)PIDTxt);
					num = ((int)num2 * -1683161210) ^ -1617671501;
					continue;
				case 138u:
					CheckUp.smethod_16((Control)(object)FeesTxt, new Point(125, 108));
					num = (int)(num2 * 882749951) ^ -1405421443;
					continue;
				case 137u:
					num = (int)((num2 * 908591558) ^ 0x1CBD9766);
					continue;
				case 136u:
					CheckUp.smethod_17((Control)(object)SearchBtn, "SearchBtn");
					num = (int)(num2 * 1938238755) ^ -1829075276;
					continue;
				case 135u:
					CheckUp.smethod_19((Control)(object)RoomNoTxt, 7);
					num = ((int)num2 * -364547327) ^ -1533116649;
					continue;
				case 134u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PaymentBox), (Control)(object)Label9);
					num = ((int)num2 * -1949732231) ^ 0x3B09E2EF;
					continue;
				case 133u:
					num = (int)((num2 * 125893974) ^ 0x4971D366);
					continue;
				case 132u:
					num = ((int)num2 * -1496729035) ^ -357731952;
					continue;
				case 131u:
					CheckUp.smethod_17((Control)(object)Label10, "Label10");
					num = ((int)num2 * -2003339364) ^ 0x2163E3DE;
					continue;
				case 130u:
					num = ((int)num2 * -1662100162) ^ -2088573237;
					continue;
				case 129u:
					CheckUp.smethod_21(Label5, (ContentAlignment)32);
					num = ((int)num2 * -266699843) ^ 0x3CB72854;
					continue;
				case 128u:
					SearchBox = CheckUp.smethod_5();
					num = ((int)num2 * -1649974196) ^ 0x6BD880AC;
					continue;
				case 127u:
					CheckUp.smethod_19((Control)(object)TokenNoTxt, 8);
					num = ((int)num2 * -870835554) ^ 0x4C658167;
					continue;
				case 126u:
					num = (int)(num2 * 1566218876) ^ -107744655;
					continue;
				case 125u:
					CheckUp.smethod_11((ISupportInitialize)PictureBox1);
					CheckUp.smethod_13((Control)(object)this);
					num = ((int)num2 * -284693074) ^ 0x70A9107;
					continue;
				case 124u:
					CheckUp.smethod_35((TextBoxBase)(object)RoomNoTxt, bool_0: true);
					num = ((int)num2 * -224796131) ^ 0x45006548;
					continue;
				case 123u:
					num = (int)((num2 * 1288505205) ^ 0x1720E9A3);
					continue;
				case 122u:
					num = ((int)num2 * -397352021) ^ -1251700429;
					continue;
				case 121u:
					CheckUp.smethod_21(Label9, (ContentAlignment)32);
					CheckUp.smethod_15((Control)(object)Label8, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					CheckUp.smethod_16((Control)(object)Label8, new Point(18, 34));
					num = ((int)num2 * -2079836917) ^ 0x1F59EEA4;
					continue;
				case 120u:
					num = ((int)num2 * -1645689680) ^ -902819225;
					continue;
				case 119u:
					num = (int)(num2 * 2051453783) ^ -1794380298;
					continue;
				case 118u:
					CheckUp.smethod_12((Control)(object)PatientInfoBox);
					num = ((int)num2 * -1919439423) ^ -318148411;
					continue;
				case 117u:
					num = ((int)num2 * -1706158848) ^ 0x1490298E;
					continue;
				case 116u:
					CheckUp.smethod_18((Control)(object)TokenNoTxt, new Size(100, 26));
					num = ((int)num2 * -1236210436) ^ -255844128;
					continue;
				case 115u:
					CheckUp.smethod_15((Control)(object)FeesTxt, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1795400612) ^ -32180154;
					continue;
				case 114u:
					CheckUp.smethod_16((Control)(object)Label9, new Point(18, 71));
					num = (int)(num2 * 267686197) ^ -683031759;
					continue;
				case 113u:
					num = (int)(num2 * 1762250759) ^ -355763616;
					continue;
				case 112u:
					CheckUp.smethod_42((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -345776707) ^ 0x403A2E2F;
					continue;
				case 111u:
					num = (int)((num2 * 780568265) ^ 0x396F0245);
					continue;
				case 110u:
					num = ((int)num2 * -480833954) ^ 0x124FAE63;
					continue;
				case 109u:
					CheckUp.smethod_18((Control)(object)GenderTxt, new Size(100, 26));
					num = ((int)num2 * -1926437699) ^ -1055977831;
					continue;
				case 108u:
					CheckUp.smethod_19((Control)(object)MobileTxt, 2);
					num = ((int)num2 * -635949657) ^ 0x19BC08E;
					continue;
				case 107u:
					num = (int)((num2 * 1848372940) ^ 0x6B6A7105);
					continue;
				case 106u:
					CheckUp.smethod_16((Control)(object)Label6, new Point(230, 113));
					num = (int)((num2 * 1778387536) ^ 0x30787FCA);
					continue;
				case 105u:
					CheckUp.smethod_15((Control)(object)TokenNoTxt, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1817819621) ^ -1865630310;
					continue;
				case 104u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)NameTxt);
					num = ((int)num2 * -1883083001) ^ 0x2A503516;
					continue;
				case 103u:
					CheckUp.smethod_20(Label10, "Fees  :");
					num = ((int)num2 * -724782924) ^ -760597508;
					continue;
				case 102u:
					num = (int)(num2 * 1535924467) ^ -1149385829;
					continue;
				case 101u:
					num = (int)(num2 * 468167668) ^ -1469660715;
					continue;
				case 100u:
					Label10 = CheckUp.smethod_3();
					num = ((int)num2 * -463621169) ^ 0x5F165308;
					continue;
				case 99u:
					num = ((int)num2 * -482670150) ^ -1085497840;
					continue;
				case 98u:
					CheckUp.smethod_51((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1833844840) ^ 0x157CD750;
					continue;
				case 97u:
					num = (int)((num2 * 2042254276) ^ 0x744670BA);
					continue;
				case 96u:
					num = ((int)num2 * -632221741) ^ 0x1F4E111A;
					continue;
				case 95u:
					CheckUp.smethod_19((Control)(object)PIDTxt, 4);
					num = (int)((num2 * 637474031) ^ 0x3DDD67B8);
					continue;
				case 94u:
					CheckUp.smethod_19((Control)(object)Label7, 3);
					num = (int)((num2 * 1148301591) ^ 0x7146A869);
					continue;
				case 93u:
					CheckUp.smethod_16((Control)(object)SearchBox, new Point(179, 151));
					CheckUp.smethod_17((Control)(object)SearchBox, "SearchBox");
					num = (int)(num2 * 377275611) ^ -1290605486;
					continue;
				case 92u:
					num = (int)(num2 * 1584973788) ^ -2131255592;
					continue;
				case 91u:
					num = (int)((num2 * 1209927012) ^ 0x131056FB);
					continue;
				case 90u:
					CheckUp.smethod_19((Control)(object)PaymentBox, 6);
					num = ((int)num2 * -1659964716) ^ 0x1578F4B6;
					continue;
				case 89u:
					CheckUp.smethod_15((Control)(object)AddressTxt, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1595385333) ^ -1310127949;
					continue;
				case 88u:
					CheckUp.smethod_31((ButtonBase)(object)SearchBtn, Color.MidnightBlue);
					num = ((int)num2 * -1970785423) ^ -748277160;
					continue;
				case 87u:
					num = ((int)num2 * -1130414635) ^ -950437572;
					continue;
				case 86u:
					num = (int)((num2 * 1105438357) ^ 0x61405C3D);
					continue;
				case 85u:
					CheckUp.smethod_34((ButtonBase)(object)SearchBtn, bool_0: false);
					num = ((int)num2 * -46553087) ^ 0x7484E1A1;
					continue;
				case 84u:
					CheckUp.smethod_17((Control)(object)GenderTxt, "GenderTxt");
					num = (int)(num2 * 1448799489) ^ -81187642;
					continue;
				case 83u:
					num = ((int)num2 * -1206233343) ^ -914238841;
					continue;
				case 82u:
					num = ((int)num2 * -851028915) ^ 0x44EE0747;
					continue;
				case 81u:
					CheckUp.smethod_20(Label3, "Mobile : ");
					num = (int)(num2 * 328953103) ^ -1249814015;
					continue;
				case 79u:
					CheckUp.smethod_17((Control)(object)Label5, "Label5");
					num = (int)(num2 * 227849883) ^ -1370221586;
					continue;
				case 78u:
					num = ((int)num2 * -2011776119) ^ 0x661A0948;
					continue;
				case 77u:
					num = ((int)num2 * -806314442) ^ -290368856;
					continue;
				case 76u:
					num = ((int)num2 * -257219697) ^ 0x248C5F84;
					continue;
				case 75u:
					CheckUp.smethod_28(CheckUp.smethod_45((Control)(object)this), (Control)(object)PatientInfoBox);
					CheckUp.smethod_28(CheckUp.smethod_45((Control)(object)this), (Control)(object)SearchBox);
					num = (int)(num2 * 1845553685) ^ -654123668;
					continue;
				case 74u:
					CheckUp.smethod_16((Control)(object)RoomNoTxt, new Point(125, 34));
					num = ((int)num2 * -929537558) ^ -1578715544;
					continue;
				case 73u:
					CheckUp.smethod_50((Control)(object)PaymentBox);
					CheckUp.smethod_48((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -1658765496) ^ 0x77F18F4;
					continue;
				case 72u:
					CheckUp.smethod_18((Control)(object)ClearBtn, new Size(119, 44));
					num = (int)(num2 * 1519847746) ^ -1889756620;
					continue;
				case 71u:
					num = (int)(num2 * 566332038) ^ -1743438292;
					continue;
				case 70u:
					CheckUp.smethod_19((Control)(object)PatientInfoBox, 5);
					CheckUp.smethod_29(PatientInfoBox, bool_0: false);
					num = (int)((num2 * 536206581) ^ 0x3384A247);
					continue;
				case 69u:
					num = ((int)num2 * -448014075) ^ -211432508;
					continue;
				case 68u:
					num = (int)((num2 * 810010357) ^ 0x1158360);
					continue;
				case 67u:
					num = (int)((num2 * 106706016) ^ 0x6468F6C9);
					continue;
				case 66u:
					CheckUp.smethod_50((Control)(object)SearchBox);
					num = (int)((num2 * 1647497310) ^ 0x5A4E53E8);
					continue;
				case 65u:
					CheckUp.smethod_19((Control)(object)Label5, 1);
					num = ((int)num2 * -1265966597) ^ -838916962;
					continue;
				case 64u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)SearchBox), (Control)(object)Label3);
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)SearchBox), (Control)(object)MobileTxt);
					num = ((int)num2 * -1590873553) ^ -1479475281;
					continue;
				case 63u:
					CheckUp.smethod_30(PatientInfoBox, "Patient Information");
					num = ((int)num2 * -1535855260) ^ -1026726407;
					continue;
				case 62u:
					CheckUp.smethod_15((Control)(object)ClearBtn, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1285029808) ^ 0x36A09822);
					continue;
				case 61u:
					CheckUp.smethod_12((Control)(object)SearchBox);
					num = ((int)num2 * -488299486) ^ -894618708;
					continue;
				case 60u:
					CheckUp.smethod_19((Control)(object)FeesTxt, 9);
					num = ((int)num2 * -744660991) ^ 0x105B3BF8;
					continue;
				case 59u:
					CheckUp.smethod_26(CheckUp.smethod_25(SearchResultGrid), 24);
					CheckUp.smethod_18((Control)(object)SearchResultGrid, new Size(853, 169));
					CheckUp.smethod_19((Control)(object)SearchResultGrid, 3);
					num = ((int)num2 * -8411513) ^ 0xC9B2BE0;
					continue;
				case 58u:
					CheckUp.smethod_17((Control)(object)NameTxt, "NameTxt");
					num = ((int)num2 * -813377246) ^ 0x24C1E820;
					continue;
				case 57u:
					CheckUp.smethod_35((TextBoxBase)(object)PIDTxt, bool_0: true);
					num = ((int)num2 * -2067078785) ^ 0x1F448856;
					continue;
				case 56u:
					num = (int)((num2 * 1170278211) ^ 0x1F4A3DE7);
					continue;
				case 55u:
					CheckUp.smethod_35((TextBoxBase)(object)AddressTxt, bool_0: true);
					CheckUp.smethod_18((Control)(object)AddressTxt, new Size(298, 90));
					num = ((int)num2 * -2034190846) ^ -1288521491;
					continue;
				case 54u:
					num = ((int)num2 * -476893456) ^ -1063327941;
					continue;
				case 53u:
					CheckUp.smethod_20(Label2, "Name : ");
					num = (int)(num2 * 1598619395) ^ -1272265958;
					continue;
				case 52u:
					FeesTxt = CheckUp.smethod_7();
					num = ((int)num2 * -364374424) ^ 0x2705D489;
					continue;
				case 51u:
					num = (int)((num2 * 739278619) ^ 0x501C82B2);
					continue;
				case 50u:
					num = ((int)num2 * -45370869) ^ 0x34651D3B;
					continue;
				case 49u:
					CheckUp.smethod_16((Control)(object)AddressTxt, new Point(124, 159));
					num = ((int)num2 * -2128427995) ^ -961250487;
					continue;
				case 48u:
					Label4 = CheckUp.smethod_3();
					num = (int)((num2 * 1330907683) ^ 0x2CCCB3F);
					continue;
				case 47u:
					CheckUp.smethod_32((Control)(object)SearchBtn, Color.White);
					num = (int)(num2 * 734122686) ^ -795255165;
					continue;
				case 46u:
					CheckUp.smethod_35((TextBoxBase)(object)TokenNoTxt, bool_0: true);
					num = ((int)num2 * -492049347) ^ 0x5468CD7D;
					continue;
				case 45u:
					CheckUp.smethod_16((Control)(object)PictureBox1, new Point(281, 21));
					num = ((int)num2 * -159034467) ^ -1081338961;
					continue;
				case 44u:
					CheckUp.smethod_15((Control)(object)PrintBtn, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 432300348) ^ 0x628B7B10);
					continue;
				case 43u:
					CheckUp.smethod_19((Control)(object)Label4, 0);
					num = ((int)num2 * -1208357567) ^ 0x7A004351;
					continue;
				case 42u:
					CheckUp.smethod_19((Control)(object)Label6, 2);
					num = (int)(num2 * 1110757016) ^ -879343775;
					continue;
				case 41u:
					num = (int)(num2 * 870830410) ^ -918871603;
					continue;
				case 40u:
					num = (int)(num2 * 349813774) ^ -85388837;
					continue;
				case 39u:
					CheckUp.smethod_18((Control)(object)Label10, new Size(101, 25));
					num = ((int)num2 * -2033513385) ^ -1247387858;
					continue;
				case 38u:
					num = ((int)num2 * -1566009529) ^ 0x11FA528;
					continue;
				case 37u:
					num = ((int)num2 * -1147778333) ^ -496492043;
					continue;
				case 36u:
					NameTxt = CheckUp.smethod_7();
					num = (int)(num2 * 197968689) ^ -895207223;
					continue;
				case 35u:
					CheckUp.smethod_17((Control)(object)Label7, "Label7");
					num = (int)((num2 * 957812158) ^ 0x7F30B093);
					continue;
				case 34u:
					CheckUp.smethod_33((ButtonBase)(object)PrintBtn, "Print");
					CheckUp.smethod_34((ButtonBase)(object)PrintBtn, bool_0: false);
					num = ((int)num2 * -944502286) ^ 0x79EA84C0;
					continue;
				case 33u:
					num = (int)(num2 * 68742098) ^ -1175093217;
					continue;
				case 32u:
					CheckUp.smethod_18((Control)(object)Label4, new Size(68, 25));
					num = ((int)num2 * -98814342) ^ 0x6A074FA3;
					continue;
				case 31u:
					CheckUp.smethod_16((Control)(object)TokenNoTxt, new Point(125, 68));
					num = ((int)num2 * -70836838) ^ 0x4ADD5E8A;
					continue;
				case 30u:
					CheckUp.smethod_20(Label9, "Token No :");
					num = (int)((num2 * 221239015) ^ 0x3AFE4F73);
					continue;
				case 29u:
					CheckUp.smethod_17((Control)(object)PictureBox1, "PictureBox1");
					num = (int)(num2 * 1524613964) ^ -446787182;
					continue;
				case 28u:
					num = ((int)num2 * -636849304) ^ 0x353059CC;
					continue;
				case 27u:
					CheckUp.smethod_15((Control)(object)Label2, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					CheckUp.smethod_16((Control)(object)Label2, new Point(37, 44));
					num = (int)((num2 * 78437035) ^ 0x3AAFBAF3);
					continue;
				case 26u:
					num = ((int)num2 * -1615094055) ^ 0x1714739F;
					continue;
				case 25u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)SearchBox), (Control)(object)NameSTxt);
					num = (int)(num2 * 442940672) ^ -195891662;
					continue;
				case 24u:
					CheckUp.smethod_12((Control)(object)PaymentBox);
					num = (int)(num2 * 2132526785) ^ -2060529285;
					continue;
				case 23u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)Label11);
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)AddressTxt);
					num = (int)((num2 * 1802737830) ^ 0x157C1375);
					continue;
				case 22u:
					DOBTxt = CheckUp.smethod_7();
					PIDTxt = CheckUp.smethod_7();
					Label7 = CheckUp.smethod_3();
					Label6 = CheckUp.smethod_3();
					num = (int)((num2 * 541058893) ^ 0x3802B015);
					continue;
				case 21u:
					num = ((int)num2 * -963624804) ^ 0x46256C75;
					continue;
				case 20u:
					CheckUp.smethod_19((Control)(object)Label10, 3);
					num = (int)((num2 * 1477163457) ^ 0x7389048B);
					continue;
				case 19u:
					CheckUp.smethod_16((Control)(object)Label1, new Point(392, 60));
					num = ((int)num2 * -140171329) ^ -17712927;
					continue;
				case 18u:
					num = (int)((num2 * 1744413533) ^ 0x35FEE78E);
					continue;
				case 17u:
					Label11 = CheckUp.smethod_3();
					num = ((int)num2 * -13360908) ^ -1314145318;
					continue;
				case 16u:
					CheckUp.smethod_31((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					num = (int)(num2 * 1855267629) ^ -1772235613;
					continue;
				case 15u:
					CheckUp.smethod_17((Control)(object)ClearBtn, "ClearBtn");
					num = ((int)num2 * -1884449039) ^ -574226791;
					continue;
				case 14u:
					CheckUp.smethod_39(PictureBox1, (PictureBoxSizeMode)1);
					num = (int)(num2 * 1265166647) ^ -997971063;
					continue;
				case 13u:
					CheckUp.smethod_19((Control)(object)PrintBtn, 8);
					num = (int)((num2 * 1317357149) ^ 0x378738D6);
					continue;
				case 12u:
					num = (int)((num2 * 1369465794) ^ 0x1ACDD7F9);
					continue;
				case 11u:
					num = ((int)num2 * -153038186) ^ -757148801;
					continue;
				case 10u:
					num = (int)(num2 * 1608073781) ^ -1095838034;
					continue;
				case 9u:
					CheckUp.smethod_29(PaymentBox, bool_0: false);
					CheckUp.smethod_30(PaymentBox, "Payment Details");
					num = (int)(num2 * 1737819198) ^ -565832465;
					continue;
				case 8u:
					num = (int)(num2 * 1472058232) ^ -1539204701;
					continue;
				case 7u:
					Label3 = CheckUp.smethod_3();
					num = ((int)num2 * -179795986) ^ -125153407;
					continue;
				case 6u:
					num = (int)(num2 * 454986336) ^ -1442611784;
					continue;
				case 5u:
					CheckUp.smethod_36(AddressTxt, bool_0: true);
					num = ((int)num2 * -921877333) ^ 0x56D01205;
					continue;
				case 4u:
					CheckUp.smethod_35((TextBoxBase)(object)DOBTxt, bool_0: true);
					CheckUp.smethod_18((Control)(object)DOBTxt, new Size(130, 26));
					num = ((int)num2 * -2048857171) ^ -1941160708;
					continue;
				case 3u:
					num = (int)((num2 * 702543978) ^ 0x5617F89A);
					continue;
				case 2u:
					CheckUp.smethod_17((Control)(object)Label1, "Label1");
					num = ((int)num2 * -1038967626) ^ 0x7FE94AE2;
					continue;
				case 1u:
					num = (int)(num2 * 1231326017) ^ -210665837;
					continue;
				case 0u:
					CheckUp.smethod_17((Control)(object)Label8, "Label8");
					num = (int)((num2 * 1363644599) ^ 0xDE360F0);
					continue;
				default:
					return;
				case 80u:
					break;
				case 299u:
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
			int num = -616960317;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC1BD195Fu) % 5u)
				{
				case 4u:
					HideItemsOnForm();
					num = ((int)num2 * -237817098) ^ 0x48241BE5;
					continue;
				case 1u:
					CheckUp.smethod_59(myconnection, CheckUp.smethod_58(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
					num = ((int)num2 * -1591777647) ^ -96716603;
					continue;
				case 0u:
					num = ((int)num2 * -225126589) ^ -1591707856;
					continue;
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

	private void SearchBtn_Click(object sender, EventArgs e)
	{
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		HideItemsOnForm();
		bool flag = !MyProject.Forms.Form1.Name_Validation(CheckUp.smethod_61(CheckUp.smethod_60(NameSTxt))) | !MyProject.Forms.Form1.Mobile_Validator(CheckUp.smethod_61(CheckUp.smethod_60(MobileTxt)));
		bool flag2 = default(bool);
		OleDbDataAdapter dbDataAdapter_ = default(OleDbDataAdapter);
		while (true)
		{
			int num = 1279375608;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2B231113u) % 6u)
				{
				case 5u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = 297585167;
						num7 = 297585167;
					}
					else
					{
						num6 = 1134379776;
						num7 = 1134379776;
					}
					num = num6 ^ ((int)num2 * -878163176);
					continue;
				}
				case 4u:
					num = 174864917;
					continue;
				case 2u:
					CheckUp.smethod_63();
					num = ((int)num2 * -770331580) ^ 0x4F8B872A;
					continue;
				case 0u:
					break;
				default:
				{
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
							int num3 = 1074243747;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x2B231113u) % 15u)
								{
								case 13u:
									flag2 = CheckUp.smethod_70(SearchResultGrid) == 1;
									num3 = ((int)num2 * -194508038) ^ 0x7DBEF913;
									continue;
								case 12u:
									num3 = ((int)num2 * -1766918606) ^ -1244428826;
									continue;
								case 11u:
									num3 = ((int)num2 * -1574716459) ^ -36335138;
									continue;
								case 10u:
									SetPaymentBoxFields();
									num3 = ((int)num2 * -529351384) ^ -1287889685;
									continue;
								case 9u:
									dbDataAdapter_ = CheckUp.smethod_67(string_, myconnection);
									num3 = (int)((num2 * 1953455756) ^ 0x2EFA9773);
									continue;
								case 7u:
									CheckUp.smethod_72((Control)(object)SearchResultGrid, bool_0: true);
									num3 = ((int)num2 * -592048276) ^ 0x2F92A273;
									continue;
								case 6u:
								{
									int num4;
									int num5;
									if (!flag2)
									{
										num4 = 1386184443;
										num5 = 1386184443;
									}
									else
									{
										num4 = 1778602593;
										num5 = 1778602593;
									}
									num3 = num4 ^ ((int)num2 * -1692649259);
									continue;
								}
								case 5u:
									CheckUp.smethod_71(myconnection);
									num3 = (int)((num2 * 1061425754) ^ 0x3760F9DD);
									continue;
								case 4u:
									CheckUp.smethod_62("No Result Found");
									CheckUp.smethod_71(myconnection);
									num3 = ((int)num2 * -1696198818) ^ 0x3D2F5B1E;
									continue;
								case 2u:
									num3 = 514973139;
									continue;
								case 1u:
									CheckUp.smethod_68((DbDataAdapter)(object)dbDataAdapter_, dataTable);
									CheckUp.smethod_69(SearchResultGrid, (object)dataTable);
									num3 = ((int)num2 * -1851131272) ^ -1663161814;
									continue;
								case 0u:
									num3 = ((int)num2 * -1632734600) ^ -1788881241;
									continue;
								case 3u:
									break;
								case 8u:
									return;
								default:
									mobile = CheckUp.smethod_60(MobileTxt);
									return;
								}
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						CheckUp.smethod_73(exception_);
						CheckUp.smethod_71(myconnection);
						CheckUp.smethod_74();
						return;
					}
				}
				case 3u:
					CheckUp.smethod_62("No Result Found");
					return;
				}
				break;
			}
		}
	}

	private void ClearBtn_Click(object sender, EventArgs e)
	{
		CheckUp.smethod_75((TextBoxBase)(object)NameTxt);
		while (true)
		{
			int num = -712727528;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDEB99B30u) % 13u)
				{
				case 11u:
					CheckUp.smethod_75((TextBoxBase)(object)AddressTxt);
					num = (int)((num2 * 1857796600) ^ 0x5341C17);
					continue;
				case 10u:
					CheckUp.smethod_75((TextBoxBase)(object)PIDTxt);
					num = ((int)num2 * -218388602) ^ -248369124;
					continue;
				case 9u:
					CheckUp.smethod_75((TextBoxBase)(object)TokenNoTxt);
					num = ((int)num2 * -523440664) ^ -1303028551;
					continue;
				case 8u:
					num = ((int)num2 * -1986153233) ^ 0x660A19DF;
					continue;
				case 7u:
					CheckUp.smethod_75((TextBoxBase)(object)RoomNoTxt);
					num = (int)(num2 * 1409068976) ^ -1403219524;
					continue;
				case 6u:
					num = ((int)num2 * -1964389043) ^ 0x5D305236;
					continue;
				case 5u:
					num = (int)((num2 * 1558371051) ^ 0x129F5463);
					continue;
				case 4u:
					CheckUp.smethod_75((TextBoxBase)(object)DOBTxt);
					num = ((int)num2 * -833762725) ^ 0x44CC3F97;
					continue;
				case 3u:
					CheckUp.smethod_75((TextBoxBase)(object)GenderTxt);
					num = ((int)num2 * -1948105812) ^ -277295708;
					continue;
				case 2u:
					num = (int)(num2 * 1199185467) ^ -517621241;
					continue;
				case 1u:
					CheckUp.smethod_75((TextBoxBase)(object)FeesTxt);
					num = (int)((num2 * 1378626101) ^ 0xB4F076B);
					continue;
				default:
					return;
				case 12u:
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
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected I4, but got Unknown
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected I4, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Incompatible stack heights: 0 vs 1
		//IL_0318: Incompatible stack heights: 0 vs 1
		//IL_031f: Incompatible stack heights: 0 vs 1
		try
		{
			while (true)
			{
				int num = 572322584;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x20D70314u) % 18u)
					{
					case 17u:
						SetPaymentBoxFields();
						num = ((int)num2 * -2008501640) ^ 0x7152DC2E;
						continue;
					case 16u:
						CheckUp.smethod_83(AddressTxt, CheckUp.smethod_82(CheckUp.smethod_81(CheckUp.smethod_80(CheckUp.smethod_79(CheckUp.smethod_78(CheckUp.smethod_76(SearchResultGrid), CheckUp.smethod_77(e))), 5))));
						num = (int)((num2 * 1486637936) ^ 0x1D847F3F);
						continue;
					case 15u:
						CheckUp.smethod_83(GenderTxt, CheckUp.smethod_82(CheckUp.smethod_81(CheckUp.smethod_80(CheckUp.smethod_79(CheckUp.smethod_78(CheckUp.smethod_76(SearchResultGrid), CheckUp.smethod_77(e))), 3))));
						num = ((int)num2 * -870791683) ^ 0x7089D963;
						continue;
					case 14u:
						num = ((int)num2 * -2072467657) ^ -299418522;
						continue;
					case 13u:
						CheckUp.smethod_72((Control)(object)ClearBtn, bool_0: true);
						num = (int)(num2 * 1450973580) ^ -1964481261;
						continue;
					case 12u:
						CheckUp.smethod_72((Control)(object)PatientInfoBox, bool_0: true);
						num = (int)(num2 * 2024489020) ^ -177868575;
						continue;
					case 11u:
						num = ((int)num2 * -878215674) ^ 0x19C943F8;
						continue;
					case 10u:
						CheckUp.smethod_83(PIDTxt, CheckUp.smethod_82(CheckUp.smethod_81(CheckUp.smethod_80(CheckUp.smethod_79(CheckUp.smethod_78(CheckUp.smethod_76(SearchResultGrid), CheckUp.smethod_77(e))), 0))));
						num = ((int)num2 * -791923264) ^ 0x33F2C330;
						continue;
					case 9u:
						CheckUp.smethod_72((Control)(object)PaymentBox, bool_0: true);
						num = (int)(num2 * 404556483) ^ -788083968;
						continue;
					case 7u:
						CheckUp.smethod_72((Control)(object)PrintBtn, bool_0: true);
						num = (int)(num2 * 1686491814) ^ -1355346798;
						continue;
					case 5u:
						num = ((int)num2 * -1690786868) ^ -1325993624;
						continue;
					case 4u:
						num = ((int)num2 * -1796410541) ^ 0x2C03E509;
						continue;
					case 3u:
						CheckUp.smethod_83(NameTxt, CheckUp.smethod_82(CheckUp.smethod_81(CheckUp.smethod_80(CheckUp.smethod_79(CheckUp.smethod_78(CheckUp.smethod_76(SearchResultGrid), CheckUp.smethod_77(e))), 1))));
						num = (int)((num2 * 2104458074) ^ 0x10D389EF);
						continue;
					case 2u:
						CheckUp.smethod_83(DOBTxt, CheckUp.smethod_82(CheckUp.smethod_81(CheckUp.smethod_80(CheckUp.smethod_79(CheckUp.smethod_78(CheckUp.smethod_76(SearchResultGrid), CheckUp.smethod_77(e))), 2))));
						num = ((int)num2 * -957857236) ^ -1136552797;
						continue;
					case 1u:
						num = (int)(num2 * 1158269311) ^ -6797368;
						continue;
					case 0u:
						num = (int)(num2 * 337398087) ^ -1667112517;
						continue;
					default:
						return;
					case 8u:
						break;
					case 6u:
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
			while (true)
			{
				_ = 1637670105;
				while (true)
				{
					_003F val = /*Error near IL_02d0: Stack underflow*/^ 0x20D70314;
					uint num2 = (uint)(int)val;
					switch (val % 4)
					{
					default:
						return;
					case 1:
						CheckUp.smethod_62(CheckUp.smethod_84(exception_));
						_ = ((int)num2 * -778417364) ^ 0x45914E6C;
						continue;
					case 0:
						CheckUp.smethod_74();
						_ = (num2 * 1127752654) ^ 0xF6A31FB;
						continue;
					case 2:
						break;
					case 3:
						return;
					}
					break;
				}
			}
		}
	}

	private bool SetPaymentBoxFields()
	{
		bool result = default(bool);
		while (true)
		{
			int num = 1169928719;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5833E3DBu) % 9u)
				{
				case 6u:
					CheckUp.smethod_83(FeesTxt, "500");
					num = ((int)num2 * -1830755976) ^ 0x7870D707;
					continue;
				case 5u:
					CheckUp.smethod_83(TokenNoTxt, CheckUp.smethod_85(MyProject.Forms.Form1.Current_tokenNo));
					num = (int)(num2 * 170409287) ^ -355086547;
					continue;
				case 4u:
					CheckUp.smethod_83(RoomNoTxt, CheckUp.smethod_85(checked(MyProject.Forms.Form1.Current_RoomNo + 100)));
					num = ((int)num2 * -638748983) ^ -156824369;
					continue;
				case 3u:
					result = true;
					num = (int)(num2 * 25803548) ^ -948595427;
					continue;
				case 2u:
					num = (int)(num2 * 863469263) ^ -58052298;
					continue;
				case 1u:
					num = ((int)num2 * -1251466723) ^ 0x4BB80B57;
					continue;
				case 0u:
					num = (int)(num2 * 90662156) ^ -1347824169;
					continue;
				case 7u:
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
			int num = -1978691896;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE197EA81u) % 8u)
				{
				case 7u:
					CheckUp.smethod_72((Control)(object)ClearBtn, bool_0: false);
					num = (int)((num2 * 1459299982) ^ 0x30EFD750);
					continue;
				case 5u:
					num = (int)((num2 * 618231116) ^ 0x3BA59E9D);
					continue;
				case 3u:
					CheckUp.smethod_72((Control)(object)PrintBtn, bool_0: false);
					result = true;
					num = (int)((num2 * 1724739776) ^ 0x15167785);
					continue;
				case 2u:
					num = ((int)num2 * -88838642) ^ -781213846;
					continue;
				case 1u:
					CheckUp.smethod_72((Control)(object)SearchResultGrid, bool_0: false);
					CheckUp.smethod_72((Control)(object)PaymentBox, bool_0: false);
					num = ((int)num2 * -910139140) ^ 0x5A714448;
					continue;
				case 0u:
					CheckUp.smethod_72((Control)(object)PatientInfoBox, bool_0: false);
					num = (int)((num2 * 764591469) ^ 0x2DDB3F13);
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

	private void PrintBtn_Click(object sender, EventArgs e)
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Invalid comparison between Unknown and I4
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 993237596;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x28821A1u) % 17u)
				{
				case 16u:
					CheckUp.smethod_89(PrintDialog1, CheckUp.smethod_88(PrintDocument1));
					num = (int)(num2 * 1116993627) ^ -1344441317;
					continue;
				case 15u:
					MyProject.Forms.Form1.Current_tokenNo = checked(MyProject.Forms.Form1.Current_tokenNo + 1);
					num = (int)(num2 * 1759255013) ^ -211410863;
					continue;
				case 14u:
					num = 613816528;
					continue;
				case 12u:
					CheckUp.smethod_93(PrintDocument1, CheckUp.smethod_92(PrintDialog1));
					CheckUp.smethod_94(PrintDocument1);
					num = ((int)num2 * -1213653140) ^ 0x7CD49F66;
					continue;
				case 11u:
					num = (int)((num2 * 346590588) ^ 0x22ED4F82);
					continue;
				case 10u:
					flag2 = (int)CheckUp.smethod_91((CommonDialog)(object)PrintDialog1) == 1;
					num = ((int)num2 * -1600271047) ^ -931067418;
					continue;
				case 9u:
					MyProject.Forms.Form1.Current_RoomNo = checked(MyProject.Forms.Form1.Current_RoomNo + 1) % 8;
					CheckUp.smethod_87(PrintDialog1, PrintDocument1);
					num = ((int)num2 * -1063346649) ^ -1755306956;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 1421596586;
						num6 = 1421596586;
					}
					else
					{
						num5 = 749933463;
						num6 = 749933463;
					}
					num = num5 ^ ((int)num2 * -533932628);
					continue;
				}
				case 7u:
				{
					int num3;
					int num4;
					if (!flag2)
					{
						num3 = -1361332431;
						num4 = -1361332431;
					}
					else
					{
						num3 = -1624280657;
						num4 = -1624280657;
					}
					num = num3 ^ ((int)num2 * -1953875935);
					continue;
				}
				case 6u:
					num = 32114466;
					continue;
				case 5u:
					num = ((int)num2 * -1630864080) ^ 0x35F87CF7;
					continue;
				case 4u:
					flag = CheckUp.smethod_86(CheckUp.smethod_60(PIDTxt), "", bool_0: false) == 0;
					num = ((int)num2 * -1572109857) ^ 0x5D5936D2;
					continue;
				case 3u:
					num = ((int)num2 * -521462262) ^ -1625007293;
					continue;
				case 2u:
					CheckUp.smethod_62("No Patient to Print");
					num = ((int)num2 * -187718589) ^ -1068537359;
					continue;
				case 1u:
					CheckUp.smethod_90(PrintDialog1, bool_0: true);
					num = ((int)num2 * -191623143) ^ -602499718;
					continue;
				default:
					return;
				case 13u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
	{
		Font font_2 = default(Font);
		Font font_ = default(Font);
		while (true)
		{
			int num = -1279290001;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEE68C640u) % 14u)
				{
				case 13u:
					font_2 = CheckUp.smethod_95("Times New Roman", 20f);
					num = (int)(num2 * 1959900374) ^ -981501185;
					continue;
				case 12u:
					CheckUp.smethod_98(CheckUp.smethod_96(e), CheckUp.smethod_58("Name - ", CheckUp.smethod_60(NameTxt)) ?? "", font_, CheckUp.smethod_97(), 100f, 400f);
					num = -816879685;
					continue;
				case 10u:
					CheckUp.smethod_98(CheckUp.smethod_96(e), "Check Up", font_2, CheckUp.smethod_97(), 250f, 100f);
					num = ((int)num2 * -1176230565) ^ -433542226;
					continue;
				case 9u:
					num = ((int)num2 * -879785568) ^ -224474956;
					continue;
				case 8u:
					CheckUp.smethod_98(CheckUp.smethod_96(e), CheckUp.smethod_58("Token No. - ", CheckUp.smethod_60(TokenNoTxt)) ?? "", font_, CheckUp.smethod_97(), 100f, 1000f);
					num = -595450079;
					continue;
				case 7u:
					num = (int)(num2 * 1930841153) ^ -1231018312;
					continue;
				case 5u:
					CheckUp.smethod_98(CheckUp.smethod_96(e), CheckUp.smethod_58("Mobile - ", mobile) ?? "", font_, CheckUp.smethod_97(), 100f, 800f);
					num = -1748707787;
					continue;
				case 4u:
					num = ((int)num2 * -1254242413) ^ -1573198006;
					continue;
				case 3u:
					CheckUp.smethod_98(CheckUp.smethod_96(e), CheckUp.smethod_58("Room No. - ", CheckUp.smethod_60(RoomNoTxt)) ?? "", font_, CheckUp.smethod_97(), 100f, 1200f);
					num = -1718498186;
					continue;
				case 2u:
					CheckUp.smethod_98(CheckUp.smethod_96(e), CheckUp.smethod_58("Fees - ", CheckUp.smethod_60(FeesTxt)) ?? "", font_, CheckUp.smethod_97(), 100f, 1400f);
					num = -1891707117;
					continue;
				case 1u:
					font_ = CheckUp.smethod_95("Times New Roman", 12f);
					num = ((int)num2 * -62590107) ^ -1543490253;
					continue;
				case 0u:
					num = ((int)num2 * -951316411) ^ -1036700678;
					continue;
				default:
					return;
				case 6u:
					break;
				case 11u:
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
