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
				int num = 1064296936;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x15E012EDu) % 7u)
					{
					case 6u:
					{
						int num4;
						int num5;
						if (searchResultGrid != null)
						{
							num4 = 197006146;
							num5 = 197006146;
						}
						else
						{
							num4 = 2014839786;
							num5 = 2014839786;
						}
						num = num4 ^ (int)(num2 * 738843209);
						continue;
					}
					case 5u:
					{
						_SearchResultGrid = value;
						searchResultGrid = _SearchResultGrid;
						int num3;
						if (searchResultGrid == null)
						{
							num = 521495575;
							num3 = 521495575;
						}
						else
						{
							num = 1642477869;
							num3 = 1642477869;
						}
						continue;
					}
					case 3u:
						searchResultGrid = _SearchResultGrid;
						num = ((int)num2 * -1088425755) ^ 0x23B8E06;
						continue;
					case 2u:
						CheckUp.smethod_53(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = ((int)num2 * -1923294803) ^ 0x35434D7;
						continue;
					case 1u:
						CheckUp.smethod_52(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = (int)(num2 * 1864279720) ^ -173672000;
						continue;
					default:
						return;
					case 0u:
						break;
					case 4u:
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
				goto IL_0032;
			}
			goto IL_00a1;
			IL_00a1:
			_SearchBtn = value;
			int num = 1206235151;
			goto IL_0078;
			IL_0078:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x49321D77u) % 6u)
				{
				case 5u:
					CheckUp.smethod_54((Control)(object)searchBtn, eventHandler_);
					num = (int)(num2 * 794154120) ^ -1147017997;
					continue;
				case 3u:
					break;
				case 2u:
					CheckUp.smethod_55((Control)(object)searchBtn, eventHandler_);
					num = ((int)num2 * -1758114314) ^ -388264346;
					continue;
				case 0u:
				{
					searchBtn = _SearchBtn;
					int num3;
					int num4;
					if (searchBtn == null)
					{
						num3 = 1784127886;
						num4 = 1784127886;
					}
					else
					{
						num3 = 410703859;
						num4 = 410703859;
					}
					num = num3 ^ ((int)num2 * -367451754);
					continue;
				}
				default:
					return;
				case 4u:
					goto IL_00a1;
				case 1u:
					return;
				}
				break;
			}
			goto IL_0032;
			IL_0032:
			num = 510901552;
			goto IL_0078;
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
			Button clearBtn = _ClearBtn;
			if (clearBtn != null)
			{
				goto IL_0082;
			}
			goto IL_00b4;
			IL_00b4:
			_ClearBtn = value;
			int num = -1122955090;
			goto IL_0087;
			IL_0087:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC6196987u) % 7u)
				{
				case 6u:
					clearBtn = _ClearBtn;
					num = (int)((num2 * 1966299833) ^ 0x75E802BC);
					continue;
				case 4u:
					CheckUp.smethod_54((Control)(object)clearBtn, eventHandler_);
					num = ((int)num2 * -195040090) ^ 0x2A8ED594;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (clearBtn == null)
					{
						num3 = -1923442970;
						num4 = -1923442970;
					}
					else
					{
						num3 = -1725361452;
						num4 = -1725361452;
					}
					num = num3 ^ (int)(num2 * 1260188963);
					continue;
				}
				case 1u:
					CheckUp.smethod_55((Control)(object)clearBtn, eventHandler_);
					num = ((int)num2 * -479005193) ^ 0x27431153;
					continue;
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_00b4;
				case 5u:
					return;
				}
				break;
			}
			goto IL_0082;
			IL_0082:
			num = -1075721663;
			goto IL_0087;
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
				int num = 1468252589;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x861E22Cu) % 8u)
					{
					case 7u:
					{
						int num5;
						int num6;
						if (printBtn != null)
						{
							num5 = -703562614;
							num6 = -703562614;
						}
						else
						{
							num5 = -139745740;
							num6 = -139745740;
						}
						num = num5 ^ ((int)num2 * -364078926);
						continue;
					}
					case 6u:
						_PrintBtn = value;
						printBtn = _PrintBtn;
						num = 1750811073;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (printBtn != null)
						{
							num3 = 1984534939;
							num4 = 1984534939;
						}
						else
						{
							num3 = 1358278442;
							num4 = 1358278442;
						}
						num = num3 ^ ((int)num2 * -150804700);
						continue;
					}
					case 3u:
						CheckUp.smethod_55((Control)(object)printBtn, eventHandler_);
						num = (int)((num2 * 634843042) ^ 0x7A90C5D8);
						continue;
					case 1u:
						printBtn = _PrintBtn;
						num = (int)((num2 * 247009740) ^ 0x48E834BF);
						continue;
					case 0u:
						CheckUp.smethod_54((Control)(object)printBtn, eventHandler_);
						num = (int)((num2 * 1545288137) ^ 0x3C82F7D2);
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
			while (true)
			{
				int num = 794287185;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x42C7B42Bu) % 7u)
					{
					case 5u:
						CheckUp.smethod_57(printDocument, printPageEventHandler_);
						num = ((int)num2 * -1548156130) ^ -1011093660;
						continue;
					case 4u:
					{
						int num5;
						int num6;
						if (printDocument == null)
						{
							num5 = 1341030789;
							num6 = 1341030789;
						}
						else
						{
							num5 = 1234634664;
							num6 = 1234634664;
						}
						num = num5 ^ ((int)num2 * -1614009460);
						continue;
					}
					case 3u:
						_PrintDocument1 = value;
						printDocument = _PrintDocument1;
						num = 929151597;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (printDocument != null)
						{
							num3 = 965096120;
							num4 = 965096120;
						}
						else
						{
							num3 = 50064828;
							num4 = 50064828;
						}
						num = num3 ^ (int)(num2 * 76118853);
						continue;
					}
					case 0u:
						CheckUp.smethod_56(printDocument, printPageEventHandler_);
						num = (int)((num2 * 1512117475) ^ 0x4400886C);
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
		while (true)
		{
			int num = 574868006;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2F8FD508u) % 5u)
				{
				case 4u:
					CheckUp.smethod_0((UserControl)(object)this, (EventHandler)CheckUp_Load);
					num = ((int)num2 * -251554248) ^ 0x57F0E48C;
					continue;
				case 3u:
					num = (int)((num2 * 203023387) ^ 0x1B030279);
					continue;
				case 2u:
					myconnection = CheckUp.smethod_1();
					InitializeComponent();
					num = (int)(num2 * 1353769739) ^ -1954377552;
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

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			bool flag = default(bool);
			while (true)
			{
				int num = 1455409223;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x4485339Eu) % 8u)
					{
					case 7u:
						num3 = ((components != null) ? 1 : 0);
						goto IL_0010;
					case 6u:
						num = 1244706250;
						continue;
					case 5u:
						CheckUp.smethod_2((IDisposable)components);
						num = (int)(num2 * 1762558891) ^ -106142077;
						continue;
					case 3u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -1923818640;
							num5 = -1923818640;
						}
						else
						{
							num4 = -1806309445;
							num5 = -1806309445;
						}
						num = num4 ^ (int)(num2 * 611240168);
						continue;
					}
					case 2u:
						num = ((int)num2 * -470264424) ^ 0x5B72E538;
						continue;
					case 1u:
						if (disposing)
						{
							num = (int)(num2 * 857605035) ^ -269214334;
							continue;
						}
						num3 = 0;
						goto IL_0010;
					default:
						return;
					case 0u:
						break;
					case 4u:
						return;
						IL_0010:
						flag = (byte)num3 != 0;
						num = 1795291557;
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
				IL_00ef:
				int num6 = 172603801;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num6 ^ 0x4485339Eu) % 3u)
					{
					case 1u:
						goto IL_00be;
					default:
						goto end_IL_00d2;
					case 2u:
						break;
					case 0u:
						goto end_IL_00d2;
					}
					goto IL_00ef;
					IL_00be:
					((ContainerControl)this).Dispose(disposing);
					num6 = (int)(num2 * 289642579) ^ -919442458;
					continue;
					end_IL_00d2:
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
		while (true)
		{
			int num = 1143220378;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4811C8DDu) % 341u)
				{
				case 340u:
					CheckUp.smethod_22(SearchResultGrid, Color.White);
					num = ((int)num2 * -1098346299) ^ 0x6B364684;
					continue;
				case 339u:
					DOBTxt = CheckUp.smethod_7();
					num = ((int)num2 * -2077021866) ^ -287517388;
					continue;
				case 338u:
					CheckUp.smethod_19((Control)(object)FeesTxt, 9);
					num = ((int)num2 * -998812848) ^ 0x5AC5030B;
					continue;
				case 337u:
					CheckUp.smethod_19((Control)(object)AddressTxt, 7);
					num = ((int)num2 * -956286295) ^ -340630530;
					continue;
				case 336u:
					CheckUp.smethod_17((Control)(object)PIDTxt, "PIDTxt");
					num = ((int)num2 * -441874812) ^ -1711510418;
					continue;
				case 335u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)SearchBox), (Control)(object)Label3);
					num = (int)((num2 * 1503192504) ^ 0x4CA38658);
					continue;
				case 334u:
					CheckUp.smethod_17((Control)(object)PrintBtn, "PrintBtn");
					num = ((int)num2 * -1688045912) ^ 0x633FAB27;
					continue;
				case 333u:
					CheckUp.smethod_19((Control)(object)Label5, 1);
					CheckUp.smethod_20(Label5, "DOB :");
					num = ((int)num2 * -596367471) ^ 0x71BE02B;
					continue;
				case 332u:
					num = (int)((num2 * 82100985) ^ 0x7ED1042C);
					continue;
				case 331u:
					CheckUp.smethod_15((Control)(object)PatientInfoBox, CheckUp.smethod_14("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1213689620) ^ 0x62318351);
					continue;
				case 330u:
					num = ((int)num2 * -96350782) ^ 0x533305D3;
					continue;
				case 329u:
					num = (int)(num2 * 1867267021) ^ -971093218;
					continue;
				case 328u:
					CheckUp.smethod_19((Control)(object)PaymentBox, 6);
					num = ((int)num2 * -332450571) ^ 0x28F68394;
					continue;
				case 327u:
					CheckUp.smethod_12((Control)(object)PatientInfoBox);
					num = (int)(num2 * 1496630460) ^ -116467556;
					continue;
				case 326u:
					CheckUp.smethod_16((Control)(object)PictureBox1, new Point(281, 21));
					num = ((int)num2 * -1656575957) ^ -105580182;
					continue;
				case 325u:
					CheckUp.smethod_17((Control)(object)RoomNoTxt, "RoomNoTxt");
					num = ((int)num2 * -1572999002) ^ -1227897103;
					continue;
				case 324u:
					CheckUp.smethod_16((Control)(object)SearchBox, new Point(179, 151));
					num = (int)(num2 * 1577061335) ^ -2087808437;
					continue;
				case 323u:
					num = ((int)num2 * -347418554) ^ -958134533;
					continue;
				case 322u:
					CheckUp.smethod_18((Control)(object)Label7, new Size(105, 26));
					num = ((int)num2 * -2124945540) ^ 0x272B01C8;
					continue;
				case 320u:
					CheckUp.smethod_16((Control)(object)GenderTxt, new Point(322, 115));
					num = ((int)num2 * -1632843992) ^ -625652253;
					continue;
				case 319u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PaymentBox), (Control)(object)Label10);
					num = ((int)num2 * -1356765289) ^ 0x7108661A;
					continue;
				case 318u:
					num = (int)(num2 * 153730452) ^ -720975667;
					continue;
				case 317u:
					CheckUp.smethod_18((Control)(object)Label3, new Size(77, 28));
					num = (int)(num2 * 929449276) ^ -1219012074;
					continue;
				case 316u:
					Label8 = CheckUp.smethod_3();
					num = ((int)num2 * -1089067736) ^ -299701438;
					continue;
				case 315u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)SearchBox), (Control)(object)NameSTxt);
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)SearchBox), (Control)(object)Label2);
					num = ((int)num2 * -1235799096) ^ 0x403D891;
					continue;
				case 314u:
					CheckUp.smethod_15((Control)(object)PIDTxt, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1201718409) ^ 0x5D062521;
					continue;
				case 313u:
					num = ((int)num2 * -50537483) ^ 0x6F8073DF;
					continue;
				case 312u:
					CheckUp.smethod_17((Control)(object)Label6, "Label6");
					CheckUp.smethod_18((Control)(object)Label6, new Size(84, 26));
					num = ((int)num2 * -1667550586) ^ -1877859773;
					continue;
				case 311u:
					num = (int)((num2 * 434653316) ^ 0x5D29C80);
					continue;
				case 310u:
					CheckUp.smethod_18((Control)(object)PictureBox1, new Size(126, 122));
					num = (int)((num2 * 2076963116) ^ 0x26BF0AF0);
					continue;
				case 309u:
					num = (int)(num2 * 1322367739) ^ -1500826837;
					continue;
				case 308u:
					CheckUp.smethod_15((Control)(object)Label3, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1387960655) ^ -1005370629;
					continue;
				case 307u:
					CheckUp.smethod_35((TextBoxBase)(object)RoomNoTxt, bool_0: true);
					num = (int)((num2 * 1779204538) ^ 0x47F8F1A1);
					continue;
				case 306u:
					CheckUp.smethod_19((Control)(object)PatientInfoBox, 5);
					num = ((int)num2 * -1877334007) ^ -1036991849;
					continue;
				case 305u:
					CheckUp.smethod_18((Control)(object)AddressTxt, new Size(298, 90));
					num = ((int)num2 * -1858144011) ^ 0x5AD8CD4C;
					continue;
				case 304u:
					num = ((int)num2 * -829003312) ^ 0x4B372A7D;
					continue;
				case 303u:
					CheckUp.smethod_19((Control)(object)TokenNoTxt, 8);
					num = ((int)num2 * -1662284015) ^ 0x1358865E;
					continue;
				case 302u:
					NameTxt = CheckUp.smethod_7();
					num = ((int)num2 * -210626716) ^ -1121766547;
					continue;
				case 301u:
					SearchResultGrid = CheckUp.smethod_4();
					num = ((int)num2 * -1610337350) ^ 0x4B62933C;
					continue;
				case 300u:
					num = ((int)num2 * -2034629469) ^ -2120833485;
					continue;
				case 299u:
					CheckUp.smethod_17((Control)(object)NameSTxt, "NameSTxt");
					num = (int)(num2 * 485579075) ^ -1020658526;
					continue;
				case 298u:
					Label10 = CheckUp.smethod_3();
					num = (int)((num2 * 58072182) ^ 0x6E0A15F2);
					continue;
				case 297u:
					CheckUp.smethod_17((Control)(object)Label8, "Label8");
					num = (int)(num2 * 1196679517) ^ -1527344623;
					continue;
				case 296u:
					PaymentBox = CheckUp.smethod_5();
					FeesTxt = CheckUp.smethod_7();
					num = ((int)num2 * -1305302353) ^ -1078691851;
					continue;
				case 295u:
					CheckUp.smethod_16((Control)(object)Label1, new Point(392, 60));
					num = (int)(num2 * 1140704397) ^ -1418507244;
					continue;
				case 294u:
					CheckUp.smethod_15((Control)(object)Label11, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -809385728) ^ -1329155514;
					continue;
				case 293u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)Label4);
					num = (int)(num2 * 1631462341) ^ -496217220;
					continue;
				case 292u:
					num = ((int)num2 * -1894829639) ^ -386439713;
					continue;
				case 291u:
					CheckUp.smethod_50((Control)(object)SearchBox);
					num = ((int)num2 * -1331182897) ^ -2049666012;
					continue;
				case 290u:
					num = (int)((num2 * 1977525886) ^ 0x209EB972);
					continue;
				case 289u:
					CheckUp.smethod_19((Control)(object)Label3, 3);
					num = (int)((num2 * 656773333) ^ 0x551EB664);
					continue;
				case 288u:
					CheckUp.smethod_28(CheckUp.smethod_45((Control)(object)this), (Control)(object)PictureBox1);
					num = (int)((num2 * 1549491597) ^ 0x16EE19B6);
					continue;
				case 287u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)SearchBox), (Control)(object)MobileTxt);
					num = (int)(num2 * 1464599629) ^ -55390810;
					continue;
				case 286u:
					num = (int)((num2 * 832686223) ^ 0x642BB7FD);
					continue;
				case 285u:
					num = ((int)num2 * -1268847885) ^ -1356226373;
					continue;
				case 284u:
					num = (int)(num2 * 1359834755) ^ -1320425564;
					continue;
				case 283u:
					num = ((int)num2 * -786639208) ^ -671053146;
					continue;
				case 282u:
					CheckUp.smethod_18((Control)(object)Label2, new Size(77, 28));
					num = (int)(num2 * 206464657) ^ -1055384352;
					continue;
				case 281u:
					CheckUp.smethod_18((Control)(object)Label5, new Size(68, 26));
					num = ((int)num2 * -1917822349) ^ 0x32BCC9FA;
					continue;
				case 280u:
					SearchBtn = CheckUp.smethod_6();
					num = ((int)num2 * -15353974) ^ -571955295;
					continue;
				case 279u:
					CheckUp.smethod_29(SearchBox, bool_0: false);
					num = (int)(num2 * 1428299102) ^ -57159460;
					continue;
				case 278u:
					num = ((int)num2 * -1848749827) ^ -520318967;
					continue;
				case 277u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)DOBTxt);
					num = (int)((num2 * 1069761614) ^ 0x1979E0C0);
					continue;
				case 276u:
					CheckUp.smethod_11((ISupportInitialize)PictureBox1);
					num = (int)((num2 * 962336618) ^ 0x765CD8);
					continue;
				case 275u:
					num = (int)(num2 * 56279738) ^ -78032588;
					continue;
				case 274u:
					CheckUp.smethod_47((Control)(object)this, new Size(977, 804));
					num = (int)(num2 * 444650877) ^ -1719330921;
					continue;
				case 273u:
					CheckUp.smethod_16((Control)(object)Label7, new Point(20, 159));
					num = (int)((num2 * 2146088786) ^ 0x1F8EC31D);
					continue;
				case 272u:
					num = ((int)num2 * -1221706541) ^ 0x7DFB55D3;
					continue;
				case 271u:
					CheckUp.smethod_28(CheckUp.smethod_45((Control)(object)this), (Control)(object)PrintBtn);
					num = (int)((num2 * 1854698332) ^ 0x6BE53B57);
					continue;
				case 270u:
					CheckUp.smethod_19((Control)(object)SearchBtn, 4);
					num = (int)((num2 * 1326492669) ^ 0x23999D9D);
					continue;
				case 269u:
					Label9 = CheckUp.smethod_3();
					num = ((int)num2 * -344122661) ^ 0x1149776C;
					continue;
				case 268u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PaymentBox), (Control)(object)TokenNoTxt);
					num = (int)(num2 * 1879295711) ^ -28632167;
					continue;
				case 267u:
					num = ((int)num2 * -686870733) ^ -1008827317;
					continue;
				case 266u:
					num = (int)((num2 * 963789361) ^ 0x32B469D8);
					continue;
				case 265u:
					CheckUp.smethod_31((ButtonBase)(object)PrintBtn, Color.MidnightBlue);
					num = (int)(num2 * 1100962137) ^ -27275959;
					continue;
				case 264u:
					num = (int)(num2 * 354796669) ^ -969920839;
					continue;
				case 263u:
					num = (int)((num2 * 1107153342) ^ 0x1B50F03E);
					continue;
				case 262u:
					CheckUp.smethod_17((Control)(object)Label1, "Label1");
					num = ((int)num2 * -958927171) ^ -246425306;
					continue;
				case 261u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)Label11);
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)AddressTxt);
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)GenderTxt);
					num = (int)(num2 * 1814239346) ^ -449440158;
					continue;
				case 260u:
					num = (int)(num2 * 1075405799) ^ -1674471173;
					continue;
				case 259u:
					num = ((int)num2 * -1101345531) ^ 0x7A02941F;
					continue;
				case 258u:
					CheckUp.smethod_31((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					num = ((int)num2 * -1803368585) ^ -1132651701;
					continue;
				case 257u:
					CheckUp.smethod_19((Control)(object)SearchBox, 4);
					num = ((int)num2 * -1545715686) ^ 0x581344D2;
					continue;
				case 256u:
					PatientInfoBox = CheckUp.smethod_5();
					num = (int)(num2 * 1782685031) ^ -1040958780;
					continue;
				case 255u:
					CheckUp.smethod_17((Control)(object)Label2, "Label2");
					num = ((int)num2 * -1870657132) ^ -539947577;
					continue;
				case 254u:
					CheckUp.smethod_19((Control)(object)Label7, 3);
					num = ((int)num2 * -1480106330) ^ -379582232;
					continue;
				case 253u:
					num = ((int)num2 * -1731103778) ^ 0x7B0B761C;
					continue;
				case 252u:
					num = (int)(num2 * 1518739087) ^ -457396936;
					continue;
				case 251u:
					CheckUp.smethod_23(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					CheckUp.smethod_16((Control)(object)SearchResultGrid, new Point(59, 295));
					num = (int)(num2 * 694169295) ^ -510118007;
					continue;
				case 250u:
					CheckUp.smethod_18((Control)(object)DOBTxt, new Size(130, 26));
					num = ((int)num2 * -388951852) ^ -56268705;
					continue;
				case 249u:
					CheckUp.smethod_15((Control)(object)Label1, CheckUp.smethod_14("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 2058126676) ^ -1532899281;
					continue;
				case 248u:
					CheckUp.smethod_17((Control)(object)SearchBox, "SearchBox");
					num = (int)(num2 * 1266422521) ^ -1140849123;
					continue;
				case 247u:
					CheckUp.smethod_35((TextBoxBase)(object)TokenNoTxt, bool_0: true);
					num = ((int)num2 * -1245866348) ^ -1863709110;
					continue;
				case 246u:
					num = (int)(num2 * 1697540185) ^ -1681271211;
					continue;
				case 245u:
					CheckUp.smethod_19((Control)(object)NameTxt, 9);
					num = ((int)num2 * -145201474) ^ -1383287377;
					continue;
				case 244u:
					CheckUp.smethod_49((Control)(object)SearchBox, bool_0: false);
					num = (int)((num2 * 1058905914) ^ 0x4BC65C1C);
					continue;
				case 243u:
					CheckUp.smethod_17((Control)(object)FeesTxt, "FeesTxt");
					num = ((int)num2 * -493702180) ^ -1560791645;
					continue;
				case 242u:
					CheckUp.smethod_42((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -2028461019) ^ -1132267577;
					continue;
				case 241u:
					CheckUp.smethod_19((Control)(object)MobileTxt, 2);
					num = (int)((num2 * 1647917459) ^ 0x410707CC);
					continue;
				case 240u:
					CheckUp.smethod_41(PictureBox1, bool_0: false);
					num = ((int)num2 * -1067690204) ^ -388925306;
					continue;
				case 239u:
					CheckUp.smethod_17((Control)(object)PaymentBox, "PaymentBox");
					num = (int)((num2 * 593391113) ^ 0x2AB0AF82);
					continue;
				case 238u:
					num = ((int)num2 * -1592369116) ^ -1500028256;
					continue;
				case 237u:
					CheckUp.smethod_18((Control)(object)ClearBtn, new Size(119, 44));
					num = (int)(num2 * 887358992) ^ -987324432;
					continue;
				case 236u:
					CheckUp.smethod_20(Label2, "Name : ");
					num = (int)((num2 * 1984579657) ^ 0x5817CE7D);
					continue;
				case 235u:
					RoomNoTxt = CheckUp.smethod_7();
					num = (int)((num2 * 1998099912) ^ 0x6F4B081A);
					continue;
				case 234u:
					CheckUp.smethod_18((Control)(object)Label1, new Size(261, 47));
					num = ((int)num2 * -256471575) ^ 0x2B610004;
					continue;
				case 233u:
					CheckUp.smethod_17((Control)(object)Label3, "Label3");
					num = ((int)num2 * -1472565972) ^ 0x74BD8AD3;
					continue;
				case 232u:
					CheckUp.smethod_48((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -1359677855) ^ 0x5D2AB848;
					continue;
				case 231u:
					num = (int)(num2 * 375387559) ^ -363861179;
					continue;
				case 230u:
					CheckUp.smethod_35((TextBoxBase)(object)PIDTxt, bool_0: true);
					num = (int)((num2 * 2074367735) ^ 0x633EDC23);
					continue;
				case 229u:
					num = (int)(num2 * 93144854) ^ -1230654254;
					continue;
				case 228u:
					num = (int)(num2 * 1337991871) ^ -2130011629;
					continue;
				case 227u:
					CheckUp.smethod_20(Label11, "Name :");
					num = ((int)num2 * -904764338) ^ -1589019735;
					continue;
				case 226u:
					CheckUp.smethod_50((Control)(object)PatientInfoBox);
					num = (int)(num2 * 361307553) ^ -172350206;
					continue;
				case 225u:
					num = ((int)num2 * -1202121443) ^ 0x4015D1CE;
					continue;
				case 224u:
					num = ((int)num2 * -2071225717) ^ 0xBBADC54;
					continue;
				case 223u:
					num = ((int)num2 * -603068427) ^ -1297139885;
					continue;
				case 222u:
					GenderTxt = CheckUp.smethod_7();
					num = (int)(num2 * 257675273) ^ -834446419;
					continue;
				case 221u:
					CheckUp.smethod_15((Control)(object)NameTxt, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					CheckUp.smethod_16((Control)(object)NameTxt, new Point(94, 80));
					CheckUp.smethod_17((Control)(object)NameTxt, "NameTxt");
					num = ((int)num2 * -179407565) ^ -82224322;
					continue;
				case 220u:
					Label3 = CheckUp.smethod_3();
					num = ((int)num2 * -1047640290) ^ 0x308C11EB;
					continue;
				case 219u:
					Label7 = CheckUp.smethod_3();
					num = ((int)num2 * -1617520662) ^ 0x70CBCA8E;
					continue;
				case 218u:
					num = (int)((num2 * 977424251) ^ 0x41921EC6);
					continue;
				case 217u:
					CheckUp.smethod_48((ISupportInitialize)SearchResultGrid);
					num = (int)(num2 * 1211613360) ^ -631986162;
					continue;
				case 216u:
					CheckUp.smethod_16((Control)(object)MobileTxt, new Point(120, 87));
					num = (int)((num2 * 1429956337) ^ 0x55F9D1F1);
					continue;
				case 215u:
					CheckUp.smethod_16((Control)(object)Label2, new Point(37, 44));
					num = (int)(num2 * 1251318146) ^ -280254615;
					continue;
				case 214u:
					CheckUp.smethod_17((Control)(object)MobileTxt, "MobileTxt");
					CheckUp.smethod_18((Control)(object)MobileTxt, new Size(237, 28));
					num = (int)((num2 * 2047991690) ^ 0x6238FA1);
					continue;
				case 213u:
					CheckUp.smethod_15((Control)(object)Label5, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1320323397) ^ 0xEB26AC0);
					continue;
				case 212u:
					CheckUp.smethod_16((Control)(object)SearchBtn, new Point(468, 82));
					num = (int)(num2 * 1938004841) ^ -269626728;
					continue;
				case 211u:
					num = ((int)num2 * -824690028) ^ 0x3700054A;
					continue;
				case 210u:
					CheckUp.smethod_18((Control)(object)GenderTxt, new Size(100, 26));
					num = ((int)num2 * -268509953) ^ -727490529;
					continue;
				case 209u:
					Label4 = CheckUp.smethod_3();
					num = ((int)num2 * -969288763) ^ -1152496514;
					continue;
				case 208u:
					num = ((int)num2 * -975492437) ^ -300782600;
					continue;
				case 207u:
					num = ((int)num2 * -641351098) ^ -686924603;
					continue;
				case 206u:
					num = ((int)num2 * -504560779) ^ -1873458494;
					continue;
				case 205u:
					CheckUp.smethod_19((Control)(object)GenderTxt, 6);
					num = (int)((num2 * 672512170) ^ 0x2F59E29F);
					continue;
				case 204u:
					num = (int)(num2 * 911333496) ^ -226112418;
					continue;
				case 203u:
					num = ((int)num2 * -1045700791) ^ -1412427879;
					continue;
				case 202u:
					CheckUp.smethod_49((Control)(object)PatientInfoBox, bool_0: false);
					num = (int)(num2 * 1208051290) ^ -1384369754;
					continue;
				case 201u:
					num = (int)((num2 * 979793000) ^ 0x71C05D7E);
					continue;
				case 200u:
					CheckUp.smethod_21(Label3, (ContentAlignment)32);
					num = (int)(num2 * 398787262) ^ -1723936291;
					continue;
				case 199u:
					num = (int)((num2 * 541827079) ^ 0x60BF1B67);
					continue;
				case 198u:
					AddressTxt = CheckUp.smethod_7();
					num = (int)((num2 * 969707409) ^ 0x1A537FE6);
					continue;
				case 197u:
					CheckUp.smethod_20(Label6, "Gender : ");
					num = (int)(num2 * 162953894) ^ -432806508;
					continue;
				case 196u:
					num = (int)(num2 * 1685019983) ^ -816596960;
					continue;
				case 195u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PaymentBox), (Control)(object)RoomNoTxt);
					num = ((int)num2 * -1814845375) ^ 0x49CDE285;
					continue;
				case 194u:
					CheckUp.smethod_18((Control)(object)TokenNoTxt, new Size(100, 26));
					num = ((int)num2 * -226617546) ^ 0x5CE128B6;
					continue;
				case 193u:
					CheckUp.smethod_17((Control)(object)Label9, "Label9");
					num = ((int)num2 * -45249295) ^ 0x91F7F0B;
					continue;
				case 192u:
					num = (int)(num2 * 1875280043) ^ -725001624;
					continue;
				case 191u:
					CheckUp.smethod_29(PaymentBox, bool_0: false);
					CheckUp.smethod_30(PaymentBox, "Payment Details");
					CheckUp.smethod_15((Control)(object)FeesTxt, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					CheckUp.smethod_16((Control)(object)FeesTxt, new Point(125, 108));
					num = (int)((num2 * 1328406104) ^ 0x5BB162DA);
					continue;
				case 190u:
					SearchBox = CheckUp.smethod_5();
					num = ((int)num2 * -320379717) ^ -1029540723;
					continue;
				case 189u:
					num = ((int)num2 * -381026245) ^ -651513680;
					continue;
				case 188u:
					CheckUp.smethod_15((Control)(object)GenderTxt, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -722040469) ^ 0x3A9EECC5;
					continue;
				case 187u:
					CheckUp.smethod_15((Control)(object)RoomNoTxt, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1140918612) ^ 0x540D77F3;
					continue;
				case 186u:
					num = ((int)num2 * -754451813) ^ -2081878566;
					continue;
				case 185u:
					CheckUp.smethod_28(CheckUp.smethod_45((Control)(object)this), (Control)(object)PaymentBox);
					num = (int)(num2 * 761525104) ^ -1961750563;
					continue;
				case 184u:
					num = ((int)num2 * -859998984) ^ -1903157918;
					continue;
				case 183u:
					PrintDialog1 = CheckUp.smethod_9();
					num = ((int)num2 * -448848134) ^ -838324699;
					continue;
				case 182u:
					CheckUp.smethod_19((Control)(object)Label9, 2);
					num = ((int)num2 * -1358252134) ^ -737538077;
					continue;
				case 181u:
					num = ((int)num2 * -802373428) ^ 0x5226BB76;
					continue;
				case 180u:
					CheckUp.smethod_19((Control)(object)Label1, 0);
					num = (int)((num2 * 493940442) ^ 0x3DE6EDE7);
					continue;
				case 179u:
					CheckUp.smethod_17((Control)(object)ClearBtn, "ClearBtn");
					num = (int)((num2 * 1119291166) ^ 0x5636FC62);
					continue;
				case 178u:
					num = ((int)num2 * -1747183413) ^ -1179098652;
					continue;
				case 177u:
					CheckUp.smethod_17((Control)(object)DOBTxt, "DOBTxt");
					num = ((int)num2 * -1366344500) ^ 0x33F5E109;
					continue;
				case 176u:
					CheckUp.smethod_34((ButtonBase)(object)ClearBtn, bool_0: false);
					num = ((int)num2 * -28682080) ^ -137076970;
					continue;
				case 175u:
					CheckUp.smethod_32((Control)(object)ClearBtn, Color.White);
					num = ((int)num2 * -1656655454) ^ -1705238245;
					continue;
				case 174u:
					CheckUp.smethod_33((ButtonBase)(object)SearchBtn, "Search");
					num = (int)(num2 * 1173671525) ^ -1821719868;
					continue;
				case 173u:
					CheckUp.smethod_28(CheckUp.smethod_45((Control)(object)this), (Control)(object)PatientInfoBox);
					CheckUp.smethod_28(CheckUp.smethod_45((Control)(object)this), (Control)(object)SearchBox);
					num = (int)(num2 * 1706290263) ^ -1613322440;
					continue;
				case 172u:
					num = (int)(num2 * 1071224380) ^ -658752682;
					continue;
				case 171u:
					ClearBtn = CheckUp.smethod_6();
					num = (int)(num2 * 1129468517) ^ -1803596263;
					continue;
				case 170u:
					CheckUp.smethod_16((Control)(object)Label10, new Point(18, 114));
					num = ((int)num2 * -319801980) ^ 0x360FC0E0;
					continue;
				case 169u:
					CheckUp.smethod_19((Control)(object)PIDTxt, 4);
					num = (int)(num2 * 591849513) ^ -970420502;
					continue;
				case 168u:
					num = ((int)num2 * -16020670) ^ 0xD00FA5A;
					continue;
				case 167u:
					Label5 = CheckUp.smethod_3();
					num = ((int)num2 * -1213788108) ^ 0x1A55B345;
					continue;
				case 166u:
					CheckUp.smethod_30(PatientInfoBox, "Patient Information");
					num = (int)((num2 * 663354383) ^ 0x9E557DF);
					continue;
				case 165u:
					num = ((int)num2 * -1224747504) ^ 0x7A786FF3;
					continue;
				case 164u:
					CheckUp.smethod_19((Control)(object)ClearBtn, 7);
					CheckUp.smethod_33((ButtonBase)(object)ClearBtn, "Clear");
					num = ((int)num2 * -1271462864) ^ 0xD0F57C3;
					continue;
				case 163u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)NameTxt);
					num = ((int)num2 * -167186918) ^ -1521742313;
					continue;
				case 162u:
					num = ((int)num2 * -1499906203) ^ 0x7DE0EAA2;
					continue;
				case 161u:
					CheckUp.smethod_16((Control)(object)Label11, new Point(20, 80));
					num = (int)(num2 * 614705152) ^ -1770706185;
					continue;
				case 160u:
					CheckUp.smethod_32((Control)(object)PrintBtn, Color.White);
					num = ((int)num2 * -1655620398) ^ 0x7F7318C6;
					continue;
				case 159u:
					CheckUp.smethod_20(Label9, "Token No :");
					CheckUp.smethod_21(Label9, (ContentAlignment)32);
					num = ((int)num2 * -1011234227) ^ 0x35C55D2C;
					continue;
				case 158u:
					CheckUp.smethod_18((Control)(object)SearchBox, new Size(623, 128));
					num = ((int)num2 * -388697005) ^ -1103596114;
					continue;
				case 157u:
					num = (int)(num2 * 1949055338) ^ -468141880;
					continue;
				case 156u:
					CheckUp.smethod_17((Control)(object)SearchBtn, "SearchBtn");
					num = ((int)num2 * -17588619) ^ -693003627;
					continue;
				case 155u:
					CheckUp.smethod_28(CheckUp.smethod_45((Control)(object)this), (Control)(object)ClearBtn);
					num = ((int)num2 * -1975820935) ^ 0x16139655;
					continue;
				case 154u:
					CheckUp.smethod_17((Control)(object)PatientInfoBox, "PatientInfoBox");
					num = (int)(num2 * 49701059) ^ -1079413727;
					continue;
				case 153u:
					num = (int)((num2 * 1642385239) ^ 0x74B53043);
					continue;
				case 152u:
					CheckUp.smethod_17((Control)(object)Label7, "Label7");
					num = (int)(num2 * 1998454292) ^ -464754992;
					continue;
				case 151u:
					CheckUp.smethod_19((Control)(object)Label4, 0);
					CheckUp.smethod_20(Label4, "PID :");
					num = (int)((num2 * 1399875548) ^ 0x5EA9F991);
					continue;
				case 150u:
					CheckUp.smethod_21(Label5, (ContentAlignment)32);
					num = ((int)num2 * -389567990) ^ -1888712634;
					continue;
				case 149u:
					CheckUp.smethod_18((Control)(object)NameSTxt, new Size(237, 28));
					num = (int)(num2 * 1393468433) ^ -154532154;
					continue;
				case 148u:
					CheckUp.smethod_40(PictureBox1, 2);
					num = ((int)num2 * -510561414) ^ -873241600;
					continue;
				case 147u:
					CheckUp.smethod_17((Control)(object)PictureBox1, "PictureBox1");
					num = ((int)num2 * -452979227) ^ 0x7960FFD2;
					continue;
				case 146u:
					CheckUp.smethod_13((Control)(object)this);
					num = ((int)num2 * -1860006913) ^ -1247504183;
					continue;
				case 145u:
					CheckUp.smethod_18((Control)(object)PIDTxt, new Size(130, 26));
					num = ((int)num2 * -668415377) ^ 0x41F56FDF;
					continue;
				case 144u:
					CheckUp.smethod_19((Control)(object)Label11, 8);
					num = ((int)num2 * -7415513) ^ 0x222F99B4;
					continue;
				case 143u:
					num = (int)(num2 * 1666611450) ^ -1744951870;
					continue;
				case 142u:
					num = (int)((num2 * 586842546) ^ 0x1474B9C7);
					continue;
				case 141u:
					CheckUp.smethod_21(Label8, (ContentAlignment)32);
					num = ((int)num2 * -1431128892) ^ 0xD5FE25C;
					continue;
				case 140u:
					CheckUp.smethod_18((Control)(object)Label10, new Size(101, 25));
					num = ((int)num2 * -1121217000) ^ 0x28E023BB;
					continue;
				case 139u:
					CheckUp.smethod_50((Control)(object)PaymentBox);
					num = (int)((num2 * 1631222547) ^ 0x128FE43C);
					continue;
				case 138u:
					CheckUp.smethod_17((Control)(object)Label5, "Label5");
					num = (int)(num2 * 568960323) ^ -763070920;
					continue;
				case 137u:
					num = ((int)num2 * -1331141843) ^ 0x36718553;
					continue;
				case 136u:
					num = ((int)num2 * -1936072110) ^ -507781864;
					continue;
				case 135u:
					num = ((int)num2 * -824012931) ^ -1452906585;
					continue;
				case 134u:
					MobileTxt = CheckUp.smethod_7();
					NameSTxt = CheckUp.smethod_7();
					num = ((int)num2 * -802975410) ^ -1636642196;
					continue;
				case 133u:
					CheckUp.smethod_24(SearchResultGrid, bool_0: true);
					num = ((int)num2 * -1476333850) ^ -2070156552;
					continue;
				case 132u:
					CheckUp.smethod_35((TextBoxBase)(object)FeesTxt, bool_0: true);
					CheckUp.smethod_18((Control)(object)FeesTxt, new Size(100, 26));
					num = (int)(num2 * 1240058917) ^ -1350632;
					continue;
				case 131u:
					CheckUp.smethod_15((Control)(object)PrintBtn, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1588228959) ^ 0x522E6B26);
					continue;
				case 130u:
					TokenNoTxt = CheckUp.smethod_7();
					num = (int)((num2 * 979368171) ^ 0x6E4DF919);
					continue;
				case 129u:
					Label6 = CheckUp.smethod_3();
					num = (int)(num2 * 394050805) ^ -341339805;
					continue;
				case 128u:
					CheckUp.smethod_15((Control)(object)Label10, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 443553584) ^ 0x170EB5B0);
					continue;
				case 127u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)Label5);
					num = (int)(num2 * 1403141968) ^ -1822042385;
					continue;
				case 126u:
					CheckUp.smethod_16((Control)(object)PrintBtn, new Point(756, 696));
					num = ((int)num2 * -408172231) ^ -1145303538;
					continue;
				case 125u:
					CheckUp.smethod_18((Control)(object)RoomNoTxt, new Size(100, 26));
					CheckUp.smethod_19((Control)(object)RoomNoTxt, 7);
					num = ((int)num2 * -930192446) ^ 0x480B5372;
					continue;
				case 124u:
					num = ((int)num2 * -1417400668) ^ -1111931512;
					continue;
				case 123u:
					CheckUp.smethod_19((Control)(object)SearchResultGrid, 3);
					num = ((int)num2 * -861756315) ^ -2102171993;
					continue;
				case 122u:
					CheckUp.smethod_18((Control)(object)Label9, new Size(107, 28));
					num = (int)((num2 * 1487508419) ^ 0x57101931);
					continue;
				case 121u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PaymentBox), (Control)(object)Label9);
					num = (int)(num2 * 1497077834) ^ -307724894;
					continue;
				case 120u:
					CheckUp.smethod_26(CheckUp.smethod_25(SearchResultGrid), 24);
					CheckUp.smethod_18((Control)(object)SearchResultGrid, new Size(853, 169));
					num = ((int)num2 * -586932415) ^ 0x44F5A846;
					continue;
				case 119u:
					CheckUp.smethod_18((Control)(object)PatientInfoBox, new Size(439, 255));
					num = ((int)num2 * -1605806373) ^ -540996771;
					continue;
				case 118u:
					CheckUp.smethod_15((Control)(object)PaymentBox, CheckUp.smethod_14("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1534018170) ^ 0x6C64F09F;
					continue;
				case 117u:
					CheckUp.smethod_18((Control)(object)PaymentBox, new Size(286, 165));
					num = (int)((num2 * 58383083) ^ 0x5CD87396);
					continue;
				case 116u:
					CheckUp.smethod_19((Control)(object)Label6, 2);
					num = ((int)num2 * -2095425681) ^ -1672414495;
					continue;
				case 115u:
					CheckUp.smethod_15((Control)(object)Label2, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 596427265) ^ 0x4F69BC44);
					continue;
				case 114u:
					CheckUp.smethod_43((ContainerControl)(object)this, (AutoScaleMode)1);
					CheckUp.smethod_44((Control)(object)this, Color.White);
					num = (int)(num2 * 267011899) ^ -430084205;
					continue;
				case 113u:
					CheckUp.smethod_49((Control)(object)PaymentBox, bool_0: false);
					num = ((int)num2 * -134592195) ^ 0xC518C48;
					continue;
				case 112u:
					CheckUp.smethod_16((Control)(object)PaymentBox, new Point(589, 485));
					num = (int)(num2 * 726766903) ^ -1808629686;
					continue;
				case 111u:
					CheckUp.smethod_34((ButtonBase)(object)PrintBtn, bool_0: false);
					CheckUp.smethod_37(PrintDialog1, bool_0: true);
					CheckUp.smethod_38(PictureBox1, (Image)(object)Resources.doc_Pic);
					num = ((int)num2 * -1936660313) ^ -536545142;
					continue;
				case 110u:
					CheckUp.smethod_18((Control)(object)PrintBtn, new Size(119, 44));
					num = ((int)num2 * -848933475) ^ -550413377;
					continue;
				case 109u:
					num = (int)(num2 * 764399061) ^ -1408969129;
					continue;
				case 108u:
					num = ((int)num2 * -1347173358) ^ -1229773655;
					continue;
				case 107u:
					CheckUp.smethod_16((Control)(object)TokenNoTxt, new Point(125, 68));
					num = (int)((num2 * 2032826785) ^ 0x12796E80);
					continue;
				case 106u:
					CheckUp.smethod_35((TextBoxBase)(object)NameTxt, bool_0: true);
					num = ((int)num2 * -919070434) ^ -984211844;
					continue;
				case 105u:
					CheckUp.smethod_15((Control)(object)DOBTxt, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					CheckUp.smethod_16((Control)(object)DOBTxt, new Point(94, 115));
					num = (int)(num2 * 83951068) ^ -550473061;
					continue;
				case 104u:
					CheckUp.smethod_15((Control)(object)ClearBtn, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 194555975) ^ -337228967;
					continue;
				case 103u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PaymentBox), (Control)(object)Label8);
					num = (int)(num2 * 292315685) ^ -154970527;
					continue;
				case 102u:
					num = ((int)num2 * -1288216575) ^ 0x1C7C1097;
					continue;
				case 101u:
					num = ((int)num2 * -1865021988) ^ 0x5645BAB4;
					continue;
				case 100u:
					CheckUp.smethod_39(PictureBox1, (PictureBoxSizeMode)1);
					num = (int)((num2 * 625083203) ^ 0x7131F8BE);
					continue;
				case 99u:
					CheckUp.smethod_30(SearchBox, "Search Patient");
					CheckUp.smethod_31((ButtonBase)(object)SearchBtn, Color.MidnightBlue);
					num = (int)((num2 * 479380713) ^ 0x3470134F);
					continue;
				case 98u:
					PrintBtn = CheckUp.smethod_6();
					num = (int)((num2 * 229627882) ^ 0x1DFB4CB9);
					continue;
				case 97u:
					CheckUp.smethod_18((Control)(object)SearchBtn, new Size(133, 37));
					num = ((int)num2 * -50186781) ^ -582565791;
					continue;
				case 96u:
					CheckUp.smethod_20(Label7, "Address : ");
					num = (int)(num2 * 186058883) ^ -1822402311;
					continue;
				case 95u:
					PIDTxt = CheckUp.smethod_7();
					num = ((int)num2 * -601271947) ^ -131253350;
					continue;
				case 94u:
					num = ((int)num2 * -2019712417) ^ 0x205EDA5;
					continue;
				case 93u:
					num = (int)((num2 * 1229931485) ^ 0x7A110FF3);
					continue;
				case 92u:
					CheckUp.smethod_15((Control)(object)TokenNoTxt, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 758886371) ^ 0x7106D9EE);
					continue;
				case 91u:
					CheckUp.smethod_28(CheckUp.smethod_45((Control)(object)this), (Control)(object)SearchResultGrid);
					num = (int)((num2 * 230715159) ^ 0x5136594F);
					continue;
				case 90u:
					num = ((int)num2 * -1669157351) ^ 0x3EBDF88B;
					continue;
				case 89u:
					CheckUp.smethod_33((ButtonBase)(object)PrintBtn, "Print");
					num = (int)((num2 * 1626902184) ^ 0x299F265);
					continue;
				case 88u:
					num = (int)((num2 * 476098618) ^ 0x7C855C19);
					continue;
				case 87u:
					CheckUp.smethod_35((TextBoxBase)(object)GenderTxt, bool_0: true);
					num = ((int)num2 * -1450501625) ^ 0x494C48ED;
					continue;
				case 86u:
					PrintDocument1 = CheckUp.smethod_8();
					num = (int)((num2 * 389349656) ^ 0x447404FC);
					continue;
				case 85u:
					CheckUp.smethod_15((Control)(object)SearchBox, CheckUp.smethod_14("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 784372597) ^ -1852026236;
					continue;
				case 84u:
					CheckUp.smethod_15((Control)(object)Label6, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -147852403) ^ -326561242;
					continue;
				case 83u:
					CheckUp.smethod_15((Control)(object)Label8, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 603996462) ^ -1919327493;
					continue;
				case 82u:
					CheckUp.smethod_16((Control)(object)Label8, new Point(18, 34));
					num = (int)(num2 * 749936756) ^ -946189585;
					continue;
				case 81u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)PIDTxt);
					num = (int)((num2 * 1287358379) ^ 0x573CF22A);
					continue;
				case 80u:
					num = (int)((num2 * 1107788339) ^ 0x469CE663);
					continue;
				case 79u:
					CheckUp.smethod_17((Control)(object)Label11, "Label11");
					CheckUp.smethod_18((Control)(object)Label11, new Size(76, 26));
					num = ((int)num2 * -1803106688) ^ 0x63440023;
					continue;
				case 78u:
					CheckUp.smethod_17((Control)(object)SearchResultGrid, "SearchResultGrid");
					num = (int)((num2 * 1012973282) ^ 0xFA80C14);
					continue;
				case 77u:
					CheckUp.smethod_20(Label10, "Fees  :");
					num = ((int)num2 * -1035086793) ^ -1274731578;
					continue;
				case 76u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PaymentBox), (Control)(object)FeesTxt);
					num = (int)((num2 * 613881158) ^ 0x35751D08);
					continue;
				case 75u:
					Label11 = CheckUp.smethod_3();
					num = (int)(num2 * 522345443) ^ -924567798;
					continue;
				case 74u:
					num = (int)(num2 * 1620291304) ^ -247380680;
					continue;
				case 73u:
					num = ((int)num2 * -222873046) ^ -803134721;
					continue;
				case 72u:
					CheckUp.smethod_15((Control)(object)SearchBtn, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					CheckUp.smethod_32((Control)(object)SearchBtn, Color.White);
					num = ((int)num2 * -1291438641) ^ 0x2AE53DBA;
					continue;
				case 71u:
					CheckUp.smethod_21(Label10, (ContentAlignment)32);
					CheckUp.smethod_15((Control)(object)Label9, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					CheckUp.smethod_16((Control)(object)Label9, new Point(18, 71));
					num = (int)(num2 * 1955325674) ^ -2130558257;
					continue;
				case 70u:
					CheckUp.smethod_46((Control)(object)this, "CheckUp");
					num = ((int)num2 * -1119601918) ^ 0x299684CF;
					continue;
				case 69u:
					num = ((int)num2 * -1319960598) ^ 0x3451A3B9;
					continue;
				case 68u:
					num = (int)((num2 * 115300752) ^ 0x2B48B3AF);
					continue;
				case 67u:
					num = (int)((num2 * 2079421207) ^ 0x19F9AD78);
					continue;
				case 66u:
					CheckUp.smethod_16((Control)(object)Label3, new Point(37, 87));
					num = (int)(num2 * 1567784767) ^ -1729786743;
					continue;
				case 65u:
					CheckUp.smethod_16((Control)(object)RoomNoTxt, new Point(125, 34));
					num = (int)(num2 * 97216236) ^ -451667299;
					continue;
				case 64u:
					CheckUp.smethod_16((Control)(object)Label4, new Point(20, 46));
					num = ((int)num2 * -1811450045) ^ -1620207480;
					continue;
				case 63u:
					num = (int)((num2 * 1768789432) ^ 0x6788C0AB);
					continue;
				case 61u:
					CheckUp.smethod_16((Control)(object)AddressTxt, new Point(124, 159));
					num = ((int)num2 * -738735866) ^ -936016280;
					continue;
				case 60u:
					CheckUp.smethod_36(AddressTxt, bool_0: true);
					num = ((int)num2 * -1604279267) ^ -514953637;
					continue;
				case 59u:
					num = (int)(num2 * 236689327) ^ -660430064;
					continue;
				case 58u:
					num = ((int)num2 * -142549627) ^ -1714959023;
					continue;
				case 57u:
					num = ((int)num2 * -353204430) ^ -49165286;
					continue;
				case 56u:
					CheckUp.smethod_12((Control)(object)SearchBox);
					num = ((int)num2 * -261513259) ^ -2062217603;
					continue;
				case 55u:
					num = (int)((num2 * 1799198834) ^ 0x517550DD);
					continue;
				case 54u:
					num = ((int)num2 * -732549488) ^ 0x44341F0A;
					continue;
				case 53u:
					CheckUp.smethod_17((Control)(object)AddressTxt, "AddressTxt");
					num = ((int)num2 * -1797574888) ^ -294664577;
					continue;
				case 52u:
					CheckUp.smethod_17((Control)(object)Label4, "Label4");
					CheckUp.smethod_18((Control)(object)Label4, new Size(68, 25));
					num = (int)(num2 * 333951541) ^ -1544072608;
					continue;
				case 51u:
					CheckUp.smethod_16((Control)(object)PIDTxt, new Point(94, 43));
					num = ((int)num2 * -349872001) ^ -1681805064;
					continue;
				case 50u:
					CheckUp.smethod_15((Control)(object)Label7, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1547619709) ^ 0x21733E0D;
					continue;
				case 49u:
					CheckUp.smethod_20(Label8, "Room No :");
					num = ((int)num2 * -6851646) ^ 0x1DDC2274;
					continue;
				case 48u:
					CheckUp.smethod_16((Control)(object)NameSTxt, new Point(120, 43));
					num = ((int)num2 * -1875749360) ^ 0x7E707AE2;
					continue;
				case 47u:
					CheckUp.smethod_19((Control)(object)Label8, 1);
					num = ((int)num2 * -125262814) ^ 0x303704E3;
					continue;
				case 46u:
					num = (int)(num2 * 1376123102) ^ -97252342;
					continue;
				case 45u:
					num = ((int)num2 * -30293514) ^ 0x484DFE3D;
					continue;
				case 44u:
					num = (int)((num2 * 516381529) ^ 0x27EA697D);
					continue;
				case 43u:
					CheckUp.smethod_15((Control)(object)Label4, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1019177692) ^ 0x20FDD8F4);
					continue;
				case 42u:
					CheckUp.smethod_16((Control)(object)Label6, new Point(230, 113));
					num = (int)(num2 * 16815121) ^ -1438342423;
					continue;
				case 41u:
					num = ((int)num2 * -1562794367) ^ -1826434686;
					continue;
				case 40u:
					CheckUp.smethod_20(Label1, "Check-Up");
					num = (int)((num2 * 1791025997) ^ 0x3B198F52);
					continue;
				case 39u:
					num = (int)(num2 * 1548245668) ^ -1369369036;
					continue;
				case 38u:
					CheckUp.smethod_21(Label11, (ContentAlignment)32);
					num = ((int)num2 * -646373200) ^ 0x7D3774F8;
					continue;
				case 37u:
					CheckUp.smethod_17((Control)(object)GenderTxt, "GenderTxt");
					num = ((int)num2 * -904040218) ^ 0x3E96DB65;
					continue;
				case 36u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)Label7);
					num = (int)(num2 * 392404749) ^ -157792385;
					continue;
				case 35u:
					CheckUp.smethod_16((Control)(object)Label5, new Point(20, 115));
					num = (int)((num2 * 479470662) ^ 0x504E4B6A);
					continue;
				case 34u:
					CheckUp.smethod_18((Control)(object)NameTxt, new Size(328, 26));
					num = ((int)num2 * -1338278534) ^ -1623509077;
					continue;
				case 33u:
					CheckUp.smethod_19((Control)(object)DOBTxt, 5);
					num = (int)((num2 * 1952134933) ^ 0x16F2EB90);
					continue;
				case 32u:
					num = (int)(num2 * 1359533906) ^ -1674269572;
					continue;
				case 31u:
					num = (int)(num2 * 1310732502) ^ -1050169489;
					continue;
				case 30u:
					Label2 = CheckUp.smethod_3();
					num = (int)(num2 * 741576419) ^ -2059027414;
					continue;
				case 29u:
					CheckUp.smethod_28(CheckUp.smethod_45((Control)(object)this), (Control)(object)Label1);
					num = ((int)num2 * -652539598) ^ 0x38B72E55;
					continue;
				case 28u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)SearchBox), (Control)(object)SearchBtn);
					num = ((int)num2 * -1542892733) ^ -395288702;
					continue;
				case 27u:
					CheckUp.smethod_35((TextBoxBase)(object)DOBTxt, bool_0: true);
					num = (int)((num2 * 2092127197) ^ 0x76C2DF0E);
					continue;
				case 26u:
					PictureBox1 = CheckUp.smethod_10();
					num = (int)((num2 * 222718240) ^ 0x27EF0457);
					continue;
				case 25u:
					CheckUp.smethod_16((Control)(object)PatientInfoBox, new Point(101, 485));
					num = ((int)num2 * -2043447905) ^ 0x1C1DD49D;
					continue;
				case 24u:
					CheckUp.smethod_29(PatientInfoBox, bool_0: false);
					num = (int)(num2 * 92443706) ^ -615117461;
					continue;
				case 23u:
					CheckUp.smethod_19((Control)(object)Label2, 0);
					num = (int)((num2 * 287881798) ^ 0x5D1CCF22);
					continue;
				case 22u:
					num = ((int)num2 * -606896115) ^ -1960116270;
					continue;
				case 21u:
					CheckUp.smethod_19((Control)(object)PrintBtn, 8);
					num = (int)((num2 * 1558092890) ^ 0x55448930);
					continue;
				case 20u:
					num = (int)(num2 * 649731085) ^ -2147475029;
					continue;
				case 19u:
					num = (int)((num2 * 1157892489) ^ 0x5B1EC511);
					continue;
				case 18u:
					CheckUp.smethod_35((TextBoxBase)(object)AddressTxt, bool_0: true);
					num = (int)((num2 * 419293930) ^ 0x715D8D72);
					continue;
				case 17u:
					CheckUp.smethod_20(Label3, "Mobile : ");
					num = ((int)num2 * -1007663033) ^ 0x32318AAA;
					continue;
				case 16u:
					CheckUp.smethod_21(Label2, (ContentAlignment)32);
					num = ((int)num2 * -2094941311) ^ -1183093603;
					continue;
				case 15u:
					CheckUp.smethod_17((Control)(object)TokenNoTxt, "TokenNoTxt");
					num = ((int)num2 * -241337755) ^ -653124246;
					continue;
				case 14u:
					CheckUp.smethod_18((Control)(object)Label8, new Size(101, 25));
					num = ((int)num2 * -583530591) ^ -1906945065;
					continue;
				case 13u:
					CheckUp.smethod_15((Control)(object)AddressTxt, CheckUp.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -829002799) ^ 0x71146938;
					continue;
				case 12u:
					num = ((int)num2 * -1917041354) ^ 0xB417E85;
					continue;
				case 11u:
					CheckUp.smethod_11((ISupportInitialize)SearchResultGrid);
					num = ((int)num2 * -1524987766) ^ 0x14FCFFF9;
					continue;
				case 10u:
					CheckUp.smethod_28(CheckUp.smethod_27((Control)(object)PatientInfoBox), (Control)(object)Label6);
					num = (int)(num2 * 1168981912) ^ -457047313;
					continue;
				case 9u:
					CheckUp.smethod_21(Label1, (ContentAlignment)32);
					num = ((int)num2 * -37993180) ^ -267339398;
					continue;
				case 8u:
					num = (int)((num2 * 1462286429) ^ 0x5D0B1950);
					continue;
				case 7u:
					CheckUp.smethod_34((ButtonBase)(object)SearchBtn, bool_0: false);
					num = ((int)num2 * -1752786116) ^ 0xA8CB886;
					continue;
				case 6u:
					CheckUp.smethod_19((Control)(object)NameSTxt, 1);
					num = ((int)num2 * -1980858344) ^ -1258782902;
					continue;
				case 5u:
					CheckUp.smethod_12((Control)(object)PaymentBox);
					num = ((int)num2 * -1852745558) ^ 0x279F8C22;
					continue;
				case 4u:
					CheckUp.smethod_17((Control)(object)Label10, "Label10");
					num = (int)((num2 * 1531277877) ^ 0x316AB76F);
					continue;
				case 3u:
					num = (int)((num2 * 1464570337) ^ 0x7095BAC);
					continue;
				case 2u:
					CheckUp.smethod_19((Control)(object)Label10, 3);
					num = (int)((num2 * 1072370631) ^ 0x659EDEF1);
					continue;
				case 1u:
					CheckUp.smethod_16((Control)(object)ClearBtn, new Point(589, 696));
					num = (int)((num2 * 1838200228) ^ 0x6C2DAB79);
					continue;
				case 0u:
					num = (int)(num2 * 1776384468) ^ -1957740755;
					continue;
				case 62u:
					break;
				default:
					CheckUp.smethod_51((Control)(object)this, bool_0: false);
					return;
				}
				break;
			}
		}
	}

	private void CheckUp_Load(object sender, EventArgs e)
	{
		CheckUp.smethod_59(myconnection, CheckUp.smethod_58(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
		while (true)
		{
			int num = 661580724;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x608E490Fu) % 3u)
				{
				case 2u:
					goto IL_0030;
				case 0u:
					break;
				default:
					HideItemsOnForm();
					return;
				}
				break;
				IL_0030:
				num = (int)((num2 * 114414393) ^ 0x5EF35D33);
			}
		}
	}

	private void SearchBtn_Click(object sender, EventArgs e)
	{
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected I4, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected I4, but got Unknown
		//IL_02d3: Incompatible stack heights: 0 vs 1
		//IL_02f3: Incompatible stack heights: 0 vs 1
		//IL_02fa: Incompatible stack heights: 0 vs 1
		HideItemsOnForm();
		bool flag = !MyProject.Forms.Form1.Name_Validation(CheckUp.smethod_61(CheckUp.smethod_60(NameSTxt))) | !MyProject.Forms.Form1.Mobile_Validator(CheckUp.smethod_61(CheckUp.smethod_60(MobileTxt)));
		string string_ = default(string);
		DataTable dataTable = default(DataTable);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -178875426;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBB24F5BBu) % 8u)
				{
				case 6u:
					CheckUp.smethod_63();
					num = (int)(num2 * 805771735) ^ -927625411;
					continue;
				case 5u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = 1839286020;
						num7 = 1839286020;
					}
					else
					{
						num6 = 236609182;
						num7 = 236609182;
					}
					num = num6 ^ ((int)num2 * -67796559);
					continue;
				}
				case 4u:
					string_ = CheckUp.smethod_64(new string[5]
					{
						"Select * From [Patient] Where [Name] Like '%",
						CheckUp.smethod_61(CheckUp.smethod_60(NameSTxt)),
						"%' And [Mobile] Like '%",
						CheckUp.smethod_60(MobileTxt),
						"%';"
					});
					dataTable = CheckUp.smethod_65();
					num = (int)((num2 * 518197560) ^ 0x465FDC2);
					continue;
				case 2u:
					num = -718381267;
					continue;
				case 1u:
					CheckUp.smethod_66(myconnection);
					num = ((int)num2 * -808074568) ^ 0x6D1536B4;
					continue;
				case 3u:
					break;
				case 0u:
					CheckUp.smethod_62("No Result Found");
					return;
				default:
					try
					{
						while (true)
						{
							int num3 = -1062844144;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xBB24F5BBu) % 10u)
								{
								case 9u:
									CheckUp.smethod_71(myconnection);
									num3 = ((int)num2 * -1942478573) ^ 0x1D2F287C;
									continue;
								case 7u:
								{
									OleDbDataAdapter dbDataAdapter_ = CheckUp.smethod_67(string_, myconnection);
									CheckUp.smethod_68((DbDataAdapter)(object)dbDataAdapter_, dataTable);
									CheckUp.smethod_69(SearchResultGrid, (object)dataTable);
									num3 = ((int)num2 * -1696538461) ^ 0x78CE93EF;
									continue;
								}
								case 6u:
									num3 = (int)((num2 * 831732783) ^ 0x732A372E);
									continue;
								case 5u:
									flag2 = CheckUp.smethod_70(SearchResultGrid) == 1;
									num3 = ((int)num2 * -173082293) ^ 0x7872C526;
									continue;
								case 4u:
									CheckUp.smethod_62("No Result Found");
									num3 = (int)((num2 * 1364166818) ^ 0x36236CAC);
									continue;
								case 2u:
								{
									int num4;
									int num5;
									if (flag2)
									{
										num4 = 1368431421;
										num5 = 1368431421;
									}
									else
									{
										num4 = 987096612;
										num5 = 987096612;
									}
									num3 = num4 ^ ((int)num2 * -1952257163);
									continue;
								}
								case 1u:
									SetPaymentBoxFields();
									CheckUp.smethod_72((Control)(object)SearchResultGrid, bool_0: true);
									num3 = -1706121751;
									continue;
								case 8u:
									break;
								default:
									mobile = CheckUp.smethod_60(MobileTxt);
									return;
								case 3u:
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
							_ = -1807484220;
							while (true)
							{
								_003F val = /*Error near IL_02a9: Stack underflow*/^ -1155205701;
								num2 = (uint)(int)val;
								switch (val % 4)
								{
								default:
									return;
								case 3:
									_ = (num2 * 735070039) ^ 0x31674DB2;
									continue;
								case 0:
									CheckUp.smethod_71(myconnection);
									CheckUp.smethod_74();
									_ = (num2 * 1077375340) ^ 0x4A0CADFE;
									continue;
								case 2:
									break;
								case 1:
									return;
								}
								break;
							}
						}
					}
				}
				break;
			}
		}
	}

	private void ClearBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1229342635;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD6EEBA29u) % 13u)
				{
				case 12u:
					CheckUp.smethod_75((TextBoxBase)(object)AddressTxt);
					num = (int)((num2 * 1979546185) ^ 0x4405E624);
					continue;
				case 11u:
					CheckUp.smethod_75((TextBoxBase)(object)RoomNoTxt);
					num = ((int)num2 * -590261405) ^ -162440815;
					continue;
				case 9u:
					CheckUp.smethod_75((TextBoxBase)(object)DOBTxt);
					num = ((int)num2 * -1779063499) ^ 0x1587C307;
					continue;
				case 8u:
					num = (int)((num2 * 388056116) ^ 0x549EED16);
					continue;
				case 7u:
					CheckUp.smethod_75((TextBoxBase)(object)TokenNoTxt);
					num = ((int)num2 * -206026626) ^ 0x658214AF;
					continue;
				case 6u:
					num = (int)((num2 * 2121405001) ^ 0x301E4FDE);
					continue;
				case 5u:
					CheckUp.smethod_75((TextBoxBase)(object)NameTxt);
					num = (int)((num2 * 208577239) ^ 0x30BB38C7);
					continue;
				case 4u:
					CheckUp.smethod_75((TextBoxBase)(object)PIDTxt);
					num = ((int)num2 * -388142075) ^ -1168861955;
					continue;
				case 3u:
					CheckUp.smethod_75((TextBoxBase)(object)FeesTxt);
					num = ((int)num2 * -825960398) ^ -809911538;
					continue;
				case 2u:
					CheckUp.smethod_75((TextBoxBase)(object)GenderTxt);
					num = (int)(num2 * 806382066) ^ -929788980;
					continue;
				case 0u:
					num = (int)(num2 * 350790572) ^ -619412480;
					continue;
				default:
					return;
				case 10u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private void SearchResultGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected I4, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected I4, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Incompatible stack heights: 0 vs 1
		//IL_0281: Incompatible stack heights: 0 vs 1
		//IL_0288: Incompatible stack heights: 0 vs 1
		try
		{
			while (true)
			{
				int num = 379160821;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x767243D9u) % 11u)
					{
					case 10u:
						CheckUp.smethod_83(DOBTxt, CheckUp.smethod_82(CheckUp.smethod_81(CheckUp.smethod_80(CheckUp.smethod_79(CheckUp.smethod_78(CheckUp.smethod_76(SearchResultGrid), CheckUp.smethod_77(e))), 2))));
						num = (int)(num2 * 280276751) ^ -327716958;
						continue;
					case 9u:
						CheckUp.smethod_72((Control)(object)PatientInfoBox, bool_0: true);
						num = (int)((num2 * 1766532002) ^ 0x4F5F85EC);
						continue;
					case 7u:
						num = ((int)num2 * -1549041318) ^ -1850315070;
						continue;
					case 6u:
						CheckUp.smethod_83(AddressTxt, CheckUp.smethod_82(CheckUp.smethod_81(CheckUp.smethod_80(CheckUp.smethod_79(CheckUp.smethod_78(CheckUp.smethod_76(SearchResultGrid), CheckUp.smethod_77(e))), 5))));
						num = (int)(num2 * 1894165867) ^ -69339659;
						continue;
					case 5u:
						num = ((int)num2 * -1625529467) ^ 0x6F98E911;
						continue;
					case 3u:
						CheckUp.smethod_83(PIDTxt, CheckUp.smethod_82(CheckUp.smethod_81(CheckUp.smethod_80(CheckUp.smethod_79(CheckUp.smethod_78(CheckUp.smethod_76(SearchResultGrid), CheckUp.smethod_77(e))), 0))));
						CheckUp.smethod_83(NameTxt, CheckUp.smethod_82(CheckUp.smethod_81(CheckUp.smethod_80(CheckUp.smethod_79(CheckUp.smethod_78(CheckUp.smethod_76(SearchResultGrid), CheckUp.smethod_77(e))), 1))));
						num = (int)(num2 * 1037733171) ^ -1489530992;
						continue;
					case 2u:
						CheckUp.smethod_72((Control)(object)ClearBtn, bool_0: true);
						CheckUp.smethod_72((Control)(object)PrintBtn, bool_0: true);
						num = ((int)num2 * -1417748102) ^ -862624205;
						continue;
					case 1u:
						CheckUp.smethod_83(GenderTxt, CheckUp.smethod_82(CheckUp.smethod_81(CheckUp.smethod_80(CheckUp.smethod_79(CheckUp.smethod_78(CheckUp.smethod_76(SearchResultGrid), CheckUp.smethod_77(e))), 3))));
						num = ((int)num2 * -781495536) ^ 0x7605CF46;
						continue;
					case 0u:
						CheckUp.smethod_72((Control)(object)PaymentBox, bool_0: true);
						num = (int)(num2 * 964427863) ^ -1129230410;
						continue;
					case 4u:
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
			while (true)
			{
				_ = 1953369183;
				while (true)
				{
					_003F val = /*Error near IL_0239: Stack underflow*/^ 0x767243D9;
					uint num2 = (uint)(int)val;
					switch (val % 4)
					{
					default:
						return;
					case 3:
						CheckUp.smethod_62(CheckUp.smethod_84(exception_));
						CheckUp.smethod_74();
						_ = (num2 * 2077747995) ^ 0xC07387DDu;
						continue;
					case 2:
						_ = ((int)num2 * -2058388124) ^ -8301638;
						continue;
					case 0:
						break;
					case 1:
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
			int num = 1092024405;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4AF392F2u) % 6u)
				{
				case 3u:
					CheckUp.smethod_83(TokenNoTxt, CheckUp.smethod_85(MyProject.Forms.Form1.Current_tokenNo));
					num = (int)(num2 * 442159836) ^ -1090299088;
					continue;
				case 2u:
					result = true;
					num = (int)(num2 * 2101615916) ^ -85462346;
					continue;
				case 1u:
					CheckUp.smethod_83(RoomNoTxt, CheckUp.smethod_85(checked(MyProject.Forms.Form1.Current_RoomNo + 100)));
					CheckUp.smethod_83(FeesTxt, "500");
					num = ((int)num2 * -1187525290) ^ -918040460;
					continue;
				case 0u:
					num = (int)(num2 * 1546573377) ^ -571241565;
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

	private bool HideItemsOnForm()
	{
		bool result = default(bool);
		while (true)
		{
			int num = -1011700330;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x894C8720u) % 10u)
				{
				case 9u:
					num = ((int)num2 * -1987279976) ^ 0x28C70043;
					continue;
				case 8u:
					CheckUp.smethod_72((Control)(object)PaymentBox, bool_0: false);
					num = ((int)num2 * -361878905) ^ 0x58B56C54;
					continue;
				case 7u:
					CheckUp.smethod_72((Control)(object)PatientInfoBox, bool_0: false);
					CheckUp.smethod_72((Control)(object)ClearBtn, bool_0: false);
					num = ((int)num2 * -382660177) ^ -224537536;
					continue;
				case 6u:
					num = (int)((num2 * 631893601) ^ 0x7672977C);
					continue;
				case 5u:
					result = true;
					num = ((int)num2 * -570713937) ^ 0x6F577EFF;
					continue;
				case 2u:
					CheckUp.smethod_72((Control)(object)SearchResultGrid, bool_0: false);
					num = ((int)num2 * -171049952) ^ 0x32F2F5A;
					continue;
				case 1u:
					CheckUp.smethod_72((Control)(object)PrintBtn, bool_0: false);
					num = ((int)num2 * -926131997) ^ -98990898;
					continue;
				case 0u:
					num = (int)(num2 * 580077672) ^ -1503499389;
					continue;
				case 3u:
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -935163245;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA017FF10u) % 16u)
				{
				case 15u:
					flag2 = (int)CheckUp.smethod_91((CommonDialog)(object)PrintDialog1) == 1;
					num = ((int)num2 * -1102742881) ^ -1648082603;
					continue;
				case 14u:
					num = ((int)num2 * -361976365) ^ 0x7F989308;
					continue;
				case 13u:
					MyProject.Forms.Form1.Current_RoomNo = checked(MyProject.Forms.Form1.Current_RoomNo + 1) % 8;
					CheckUp.smethod_87(PrintDialog1, PrintDocument1);
					CheckUp.smethod_89(PrintDialog1, CheckUp.smethod_88(PrintDocument1));
					CheckUp.smethod_90(PrintDialog1, bool_0: true);
					num = (int)((num2 * 1824485047) ^ 0x43256D2C);
					continue;
				case 11u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -1961195682;
						num6 = -1961195682;
					}
					else
					{
						num5 = -1788629109;
						num6 = -1788629109;
					}
					num = num5 ^ ((int)num2 * -1888280550);
					continue;
				}
				case 10u:
					num = ((int)num2 * -315472979) ^ 0x3C9B08AC;
					continue;
				case 9u:
					CheckUp.smethod_94(PrintDocument1);
					num = (int)((num2 * 1251945928) ^ 0x5B07D832);
					continue;
				case 7u:
					num = (int)(num2 * 383908196) ^ -1834132957;
					continue;
				case 6u:
					CheckUp.smethod_93(PrintDocument1, CheckUp.smethod_92(PrintDialog1));
					num = (int)((num2 * 457847496) ^ 0x1816BCC9);
					continue;
				case 5u:
					CheckUp.smethod_62("No Patient to Print");
					num = (int)((num2 * 1955647324) ^ 0x435F87E0);
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag2)
					{
						num3 = -306725426;
						num4 = -306725426;
					}
					else
					{
						num3 = -542383542;
						num4 = -542383542;
					}
					num = num3 ^ (int)(num2 * 669760035);
					continue;
				}
				case 3u:
					flag = CheckUp.smethod_86(CheckUp.smethod_60(PIDTxt), "", bool_0: false) == 0;
					num = (int)(num2 * 1053105753) ^ -486938000;
					continue;
				case 2u:
					num = -999376852;
					continue;
				case 1u:
					MyProject.Forms.Form1.Current_tokenNo = checked(MyProject.Forms.Form1.Current_tokenNo + 1);
					num = (int)(num2 * 1997076430) ^ -1630650941;
					continue;
				case 0u:
					num = -278277007;
					continue;
				default:
					return;
				case 8u:
					break;
				case 12u:
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
			int num = -441007128;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA126406Au) % 8u)
				{
				case 7u:
					num = ((int)num2 * -961547017) ^ 0x5440273E;
					continue;
				case 6u:
					CheckUp.smethod_98(CheckUp.smethod_96(e), "Check Up", font_2, CheckUp.smethod_97(), 250f, 100f);
					num = (int)((num2 * 2017870856) ^ 0x241CA481);
					continue;
				case 5u:
					CheckUp.smethod_98(CheckUp.smethod_96(e), CheckUp.smethod_58("Token No. - ", CheckUp.smethod_60(TokenNoTxt)) ?? "", font_, CheckUp.smethod_97(), 100f, 1000f);
					CheckUp.smethod_98(CheckUp.smethod_96(e), CheckUp.smethod_58("Room No. - ", CheckUp.smethod_60(RoomNoTxt)) ?? "", font_, CheckUp.smethod_97(), 100f, 1200f);
					num = -1963213357;
					continue;
				case 4u:
					CheckUp.smethod_98(CheckUp.smethod_96(e), CheckUp.smethod_58("Mobile - ", mobile) ?? "", font_, CheckUp.smethod_97(), 100f, 800f);
					num = -1248145803;
					continue;
				case 3u:
					CheckUp.smethod_98(CheckUp.smethod_96(e), CheckUp.smethod_58("Name - ", CheckUp.smethod_60(NameTxt)) ?? "", font_, CheckUp.smethod_97(), 100f, 400f);
					num = -1291709594;
					continue;
				case 2u:
					font_2 = CheckUp.smethod_95("Times New Roman", 20f);
					font_ = CheckUp.smethod_95("Times New Roman", 12f);
					num = (int)((num2 * 1582535049) ^ 0x139062E6);
					continue;
				case 0u:
					break;
				default:
					CheckUp.smethod_98(CheckUp.smethod_96(e), CheckUp.smethod_58("Fees - ", CheckUp.smethod_60(FeesTxt)) ?? "", font_, CheckUp.smethod_97(), 100f, 1400f);
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
