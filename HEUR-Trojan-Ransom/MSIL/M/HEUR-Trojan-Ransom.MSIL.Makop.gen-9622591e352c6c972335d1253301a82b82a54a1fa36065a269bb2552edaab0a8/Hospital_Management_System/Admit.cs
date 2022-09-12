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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hospital_Management_System;

[DesignerGenerated]
public class Admit : UserControl
{
	private IContainer components;

	private OleDbConnection myconnection;

	private string id;

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
			Button searchBtn = _SearchBtn;
			while (true)
			{
				int num = -1591909398;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD07F9BCCu) % 6u)
					{
					case 4u:
					{
						_SearchBtn = value;
						searchBtn = _SearchBtn;
						int num5;
						if (searchBtn != null)
						{
							num = -2032515724;
							num5 = -2032515724;
						}
						else
						{
							num = -1071659807;
							num5 = -1071659807;
						}
						continue;
					}
					case 2u:
					{
						int num3;
						int num4;
						if (searchBtn == null)
						{
							num3 = -1197879228;
							num4 = -1197879228;
						}
						else
						{
							num3 = -787530099;
							num4 = -787530099;
						}
						num = num3 ^ ((int)num2 * -375447509);
						continue;
					}
					case 1u:
						Admit.smethod_60((Control)(object)searchBtn, eventHandler_);
						num = (int)((num2 * 728124466) ^ 0x2E03AEF0);
						continue;
					case 0u:
						Admit.smethod_61((Control)(object)searchBtn, eventHandler_);
						num = ((int)num2 * -410410142) ^ -1059475823;
						continue;
					default:
						return;
					case 5u:
						break;
					case 3u:
						return;
					}
					break;
				}
			}
		}
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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
			while (true)
			{
				int num = -1760921016;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB347B971u) % 8u)
					{
					case 7u:
					{
						int num5;
						int num6;
						if (searchResultGrid != null)
						{
							num5 = 1079941033;
							num6 = 1079941033;
						}
						else
						{
							num5 = 1474631046;
							num6 = 1474631046;
						}
						num = num5 ^ ((int)num2 * -2094971379);
						continue;
					}
					case 5u:
						_SearchResultGrid = value;
						num = -898739221;
						continue;
					case 3u:
						Admit.smethod_63(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = ((int)num2 * -63766056) ^ 0x1B6006C5;
						continue;
					case 2u:
						searchResultGrid = _SearchResultGrid;
						num = (int)((num2 * 76979835) ^ 0x2969C738);
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (searchResultGrid == null)
						{
							num3 = -1489843387;
							num4 = -1489843387;
						}
						else
						{
							num3 = -1424303208;
							num4 = -1424303208;
						}
						num = num3 ^ (int)(num2 * 598045465);
						continue;
					}
					case 0u:
						Admit.smethod_62(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = ((int)num2 * -1371679227) ^ -1023582324;
						continue;
					default:
						return;
					case 6u:
						break;
					case 4u:
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

	[field: AccessedThroughProperty("AgeTxt")]
	internal virtual TextBox AgeTxt
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

	[field: AccessedThroughProperty("AdmitDetailsBox")]
	internal virtual GroupBox AdmitDetailsBox
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

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
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

	[field: AccessedThroughProperty("DateOut1Txt")]
	internal virtual TextBox DateOut1Txt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateIn1Txt")]
	internal virtual TextBox DateIn1Txt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("StatusTxt")]
	internal virtual ComboBox StatusTxt
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
				int num = 340562353;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3518397Cu) % 6u)
					{
					case 5u:
						Admit.smethod_61((Control)(object)clearBtn, eventHandler_);
						num = (int)(num2 * 1326092018) ^ -2131430280;
						continue;
					case 3u:
						Admit.smethod_60((Control)(object)clearBtn, eventHandler_);
						num = (int)((num2 * 294252143) ^ 0xC08D527);
						continue;
					case 2u:
					{
						_ClearBtn = value;
						clearBtn = _ClearBtn;
						int num5;
						if (clearBtn == null)
						{
							num = 1816581330;
							num5 = 1816581330;
						}
						else
						{
							num = 1741067713;
							num5 = 1741067713;
						}
						continue;
					}
					case 1u:
					{
						clearBtn = _ClearBtn;
						int num3;
						int num4;
						if (clearBtn == null)
						{
							num3 = -880781209;
							num4 = -880781209;
						}
						else
						{
							num3 = -2056022350;
							num4 = -2056022350;
						}
						num = num3 ^ (int)(num2 * 1572219911);
						continue;
					}
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
			while (true)
			{
				int num = 1234525909;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x15849FACu) % 7u)
					{
					case 6u:
						_PrintBtn = value;
						num = 28623237;
						continue;
					case 4u:
					{
						int num5;
						int num6;
						if (printBtn != null)
						{
							num5 = -2017290029;
							num6 = -2017290029;
						}
						else
						{
							num5 = -542131331;
							num6 = -542131331;
						}
						num = num5 ^ ((int)num2 * -231339934);
						continue;
					}
					case 2u:
						Admit.smethod_61((Control)(object)printBtn, eventHandler_);
						num = ((int)num2 * -857172774) ^ 0x4BAC4B30;
						continue;
					case 1u:
					{
						printBtn = _PrintBtn;
						int num3;
						int num4;
						if (printBtn == null)
						{
							num3 = 1587713459;
							num4 = 1587713459;
						}
						else
						{
							num3 = 191762153;
							num4 = 191762153;
						}
						num = num3 ^ (int)(num2 * 818333439);
						continue;
					}
					case 0u:
						Admit.smethod_60((Control)(object)printBtn, eventHandler_);
						num = ((int)num2 * -647851743) ^ 0x6CC822E2;
						continue;
					default:
						return;
					case 5u:
						break;
					case 3u:
						return;
					}
					break;
				}
			}
		}
	}

	internal virtual Button SaveBtn
	{
		[CompilerGenerated]
		get
		{
			return _SaveBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = SaveBtn_Click;
			Button saveBtn = _SaveBtn;
			while (true)
			{
				int num = -1291500323;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBDCB0E3Fu) % 8u)
					{
					case 7u:
						Admit.smethod_61((Control)(object)saveBtn, eventHandler_);
						num = (int)(num2 * 1173770233) ^ -393534474;
						continue;
					case 5u:
						_SaveBtn = value;
						num = -1180702257;
						continue;
					case 3u:
					{
						int num5;
						int num6;
						if (saveBtn != null)
						{
							num5 = 54222153;
							num6 = 54222153;
						}
						else
						{
							num5 = 791666632;
							num6 = 791666632;
						}
						num = num5 ^ ((int)num2 * -927031493);
						continue;
					}
					case 2u:
					{
						int num3;
						int num4;
						if (saveBtn == null)
						{
							num3 = -1557245494;
							num4 = -1557245494;
						}
						else
						{
							num3 = -2096099170;
							num4 = -2096099170;
						}
						num = num3 ^ ((int)num2 * -822039296);
						continue;
					}
					case 1u:
						Admit.smethod_60((Control)(object)saveBtn, eventHandler_);
						num = (int)(num2 * 1898605890) ^ -1025895096;
						continue;
					case 0u:
						saveBtn = _SaveBtn;
						num = ((int)num2 * -1601941991) ^ 0x71A809DC;
						continue;
					default:
						return;
					case 4u:
						break;
					case 6u:
						return;
					}
					break;
				}
			}
		}
	}

	[field: AccessedThroughProperty("NameTxt")]
	internal virtual TextBox NameTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateOutTxt")]
	internal virtual ComboBox DateOutTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateInTxt")]
	internal virtual ComboBox DateInTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label15")]
	internal virtual Label Label15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MobileSTxt")]
	internal virtual TextBox MobileSTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintDialog1")]
	internal virtual PrintDialog PrintDialog1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
				int num = -1227089385;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCA492542u) % 8u)
					{
					case 7u:
						Admit.smethod_64(printDocument, printPageEventHandler_);
						num = (int)((num2 * 1426921994) ^ 0xBB33F96);
						continue;
					case 5u:
						printDocument = _PrintDocument1;
						num = ((int)num2 * -1087069897) ^ 0x5B92E8B1;
						continue;
					case 4u:
						Admit.smethod_65(printDocument, printPageEventHandler_);
						num = (int)((num2 * 1926937903) ^ 0x7B8A9E4D);
						continue;
					case 2u:
						_PrintDocument1 = value;
						num = -855293845;
						continue;
					case 1u:
					{
						printDocument = _PrintDocument1;
						int num5;
						int num6;
						if (printDocument == null)
						{
							num5 = 1940172355;
							num6 = 1940172355;
						}
						else
						{
							num5 = 1056252276;
							num6 = 1056252276;
						}
						num = num5 ^ ((int)num2 * -926355318);
						continue;
					}
					case 0u:
					{
						int num3;
						int num4;
						if (printDocument == null)
						{
							num3 = 1629708880;
							num4 = 1629708880;
						}
						else
						{
							num3 = 1900441293;
							num4 = 1900441293;
						}
						num = num3 ^ (int)(num2 * 1404053441);
						continue;
					}
					default:
						return;
					case 6u:
						break;
					case 3u:
						return;
					}
					break;
				}
			}
		}
	}

	internal virtual Button HistoryBtn
	{
		[CompilerGenerated]
		get
		{
			return _HistoryBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = HistoryBtn_Click;
			Button historyBtn = _HistoryBtn;
			if (historyBtn != null)
			{
				goto IL_0073;
			}
			goto IL_00a1;
			IL_00a1:
			_HistoryBtn = value;
			int num = 638880920;
			goto IL_0078;
			IL_0078:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x683E9B5Du) % 6u)
				{
				case 4u:
					Admit.smethod_60((Control)(object)historyBtn, eventHandler_);
					num = ((int)num2 * -1876340883) ^ 0x596300D2;
					continue;
				case 2u:
					Admit.smethod_61((Control)(object)historyBtn, eventHandler_);
					num = (int)((num2 * 1470321482) ^ 0x4FA3DA14);
					continue;
				case 1u:
				{
					historyBtn = _HistoryBtn;
					int num3;
					int num4;
					if (historyBtn == null)
					{
						num3 = -864348297;
						num4 = -864348297;
					}
					else
					{
						num3 = -1886239414;
						num4 = -1886239414;
					}
					num = num3 ^ (int)(num2 * 1176649823);
					continue;
				}
				case 0u:
					break;
				default:
					return;
				case 3u:
					goto IL_00a1;
				case 5u:
					return;
				}
				break;
			}
			goto IL_0073;
			IL_0073:
			num = 1359663153;
			goto IL_0078;
		}
	}

	internal virtual Button AdmitDischargeBtn
	{
		[CompilerGenerated]
		get
		{
			return _AdmitDischargeBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = AdmitDischargeBtn_Click;
			Button admitDischargeBtn = default(Button);
			while (true)
			{
				int num = 913876392;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x284AF29Eu) % 8u)
					{
					case 7u:
						Admit.smethod_60((Control)(object)admitDischargeBtn, eventHandler_);
						num = ((int)num2 * -1668823833) ^ 0x550A1C95;
						continue;
					case 6u:
						admitDischargeBtn = _AdmitDischargeBtn;
						num = ((int)num2 * -1285135407) ^ -136346767;
						continue;
					case 4u:
						Admit.smethod_61((Control)(object)admitDischargeBtn, eventHandler_);
						num = ((int)num2 * -218229803) ^ -1975813593;
						continue;
					case 3u:
					{
						int num5;
						int num6;
						if (admitDischargeBtn == null)
						{
							num5 = 69483259;
							num6 = 69483259;
						}
						else
						{
							num5 = 836327314;
							num6 = 836327314;
						}
						num = num5 ^ (int)(num2 * 596672784);
						continue;
					}
					case 2u:
						_AdmitDischargeBtn = value;
						admitDischargeBtn = _AdmitDischargeBtn;
						num = 522468285;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (admitDischargeBtn != null)
						{
							num3 = 1409267070;
							num4 = 1409267070;
						}
						else
						{
							num3 = 717564259;
							num4 = 717564259;
						}
						num = num3 ^ (int)(num2 * 262583359);
						continue;
					}
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

	[field: AccessedThroughProperty("RoomTypeTxt")]
	internal virtual ComboBox RoomTypeTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RoomNoTxt")]
	internal virtual ComboBox RoomNoTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RoomNo1Txt")]
	internal virtual TextBox RoomNo1Txt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RoomType1Txt")]
	internal virtual TextBox RoomType1Txt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Admit()
	{
		Admit.smethod_0((UserControl)(object)this, (EventHandler)Admit_Load);
		myconnection = Admit.smethod_1();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing)
			{
				goto IL_006d;
			}
			int num = 0;
			goto IL_00ac;
			IL_00ac:
			bool flag = (byte)num != 0;
			int num2 = 234210459;
			goto IL_0072;
			IL_006d:
			num2 = 180275281;
			goto IL_0072;
			IL_0072:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xA5DC83Eu) % 8u)
				{
				case 6u:
					num2 = (int)((num3 * 107194074) ^ 0x1FD7D240);
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1225320396;
						num5 = -1225320396;
					}
					else
					{
						num4 = -487153770;
						num5 = -487153770;
					}
					num2 = num4 ^ ((int)num3 * -1938847155);
					continue;
				}
				case 3u:
					num2 = 1943421122;
					continue;
				case 2u:
					num2 = (int)((num3 * 2089106632) ^ 0x4D6F7A05);
					continue;
				case 1u:
					Admit.smethod_2((IDisposable)components);
					num2 = ((int)num3 * -1109464898) ^ 0xC643026;
					continue;
				case 0u:
					break;
				default:
					return;
				case 7u:
					goto IL_00a3;
				case 4u:
					return;
				}
				break;
			}
			goto IL_006d;
			IL_00a3:
			num = ((components != null) ? 1 : 0);
			goto IL_00ac;
		}
		finally
		{
			((ContainerControl)this).Dispose(disposing);
			while (true)
			{
				IL_00e9:
				int num6 = 1409162228;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0xA5DC83Eu) % 3u)
					{
					case 2u:
						goto IL_00bf;
					default:
						goto end_IL_00cc;
					case 0u:
						break;
					case 1u:
						goto end_IL_00cc;
					}
					goto IL_00e9;
					IL_00bf:
					num6 = ((int)num3 * -806545889) ^ 0x5FD95BF7;
					continue;
					end_IL_00cc:
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
			int num = -1168075459;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB0691EFBu) % 525u)
				{
				case 524u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)MobileSTxt);
					num = ((int)num2 * -1507046663) ^ 0x4AC682B7;
					continue;
				case 523u:
					Admit.smethod_17((Control)(object)Label5, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1402729013) ^ -18528945;
					continue;
				case 522u:
					num = (int)((num2 * 870613816) ^ 0x5610C862);
					continue;
				case 521u:
					Admit.smethod_18((Control)(object)Label8, new Point(18, 34));
					num = (int)((num2 * 610247845) ^ 0x7389209);
					continue;
				case 520u:
					Admit.smethod_21((Control)(object)SearchResultGrid, 6);
					num = ((int)num2 * -1512730487) ^ 0x4EA11A5;
					continue;
				case 519u:
					AdmitDischargeBtn = Admit.smethod_5();
					num = (int)(num2 * 1639526025) ^ -1136536505;
					continue;
				case 518u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)StatusTxt);
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)DateOut1Txt);
					num = ((int)num2 * -1613755905) ^ -1942427621;
					continue;
				case 517u:
					Admit.smethod_17((Control)(object)Label1, Admit.smethod_16("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -553916734) ^ 0x16571340;
					continue;
				case 516u:
					Admit.smethod_20((Control)(object)SearchBtn, new Size(133, 37));
					num = (int)(num2 * 576042689) ^ -1457622222;
					continue;
				case 515u:
					Admit.smethod_18((Control)(object)AdmitDischargeBtn, new Point(784, 220));
					num = (int)(num2 * 646064061) ^ -2121493897;
					continue;
				case 514u:
					Label9 = Admit.smethod_3();
					num = ((int)num2 * -1708759446) ^ 0x7A443B75;
					continue;
				case 513u:
					Admit.smethod_13((ISupportInitialize)SearchResultGrid);
					num = (int)(num2 * 505598756) ^ -1692711599;
					continue;
				case 512u:
					num = ((int)num2 * -355523777) ^ 0x37DA7B1;
					continue;
				case 511u:
					Admit.smethod_22(Label14, "Name :");
					num = (int)((num2 * 1016860630) ^ 0x24E6C1BF);
					continue;
				case 510u:
					num = ((int)num2 * -839390122) ^ -633454089;
					continue;
				case 509u:
					num = (int)((num2 * 1521645123) ^ 0x242B0DCA);
					continue;
				case 508u:
					num = (int)((num2 * 1472672861) ^ 0xB1E58C6);
					continue;
				case 507u:
					Admit.smethod_41((ListControl)(object)RoomNoTxt, bool_0: true);
					num = ((int)num2 * -1491730220) ^ -555900075;
					continue;
				case 506u:
					num = ((int)num2 * -69158376) ^ -341323888;
					continue;
				case 505u:
					Admit.smethod_29((Control)(object)SearchBtn, Color.White);
					num = ((int)num2 * -326519819) ^ 0x647070CE;
					continue;
				case 504u:
					Admit.smethod_19((Control)(object)ClearBtn, "ClearBtn");
					num = ((int)num2 * -948847721) ^ -1447343773;
					continue;
				case 503u:
					num = (int)((num2 * 504731790) ^ 0x11C8ED28);
					continue;
				case 502u:
					Admit.smethod_22(Label13, "Date Out  :");
					num = (int)((num2 * 1724458535) ^ 0x60CAC149);
					continue;
				case 501u:
					num = (int)(num2 * 2051780316) ^ -2120148454;
					continue;
				case 500u:
					Admit.smethod_23(Label9, (ContentAlignment)32);
					num = (int)(num2 * 353590489) ^ -132746068;
					continue;
				case 499u:
					Admit.smethod_33(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					Admit.smethod_18((Control)(object)SearchResultGrid, new Point(59, 295));
					num = ((int)num2 * -1524936348) ^ -235551538;
					continue;
				case 498u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)RoomNoTxt);
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)RoomTypeTxt);
					num = ((int)num2 * -431261067) ^ 0x78FAF7F9;
					continue;
				case 497u:
					Admit.smethod_20((Control)(object)GenderTxt, new Size(100, 28));
					num = ((int)num2 * -14660077) ^ -1740831110;
					continue;
				case 496u:
					num = (int)((num2 * 395820731) ^ 0x22983C7F);
					continue;
				case 495u:
					Admit.smethod_38((TextBoxBase)(object)NameTxt, bool_0: true);
					num = (int)(num2 * 2123367305) ^ -1455491678;
					continue;
				case 494u:
					num = ((int)num2 * -1855933847) ^ 0x3AF87558;
					continue;
				case 493u:
					num = ((int)num2 * -1489558337) ^ -353395797;
					continue;
				case 492u:
					num = (int)((num2 * 1274173764) ^ 0x3D38D638);
					continue;
				case 491u:
					num = ((int)num2 * -1194424626) ^ -1303471201;
					continue;
				case 490u:
					Admit.smethod_17((Control)(object)Label10, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1013075812) ^ 0x5287B0CC);
					continue;
				case 489u:
					num = (int)(num2 * 1718853990) ^ -1528765451;
					continue;
				case 488u:
					Admit.smethod_40(RoomNoTxt, (ComboBoxStyle)2);
					num = (int)((num2 * 1384965356) ^ 0x34859CB5);
					continue;
				case 487u:
					num = ((int)num2 * -980691078) ^ 0x230E833B;
					continue;
				case 486u:
					Admit.smethod_21((Control)(object)NameTxt, 9);
					num = (int)(num2 * 421558647) ^ -416417074;
					continue;
				case 485u:
					Admit.smethod_17((Control)(object)Label13, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1945327524) ^ 0x43F2763E);
					continue;
				case 484u:
					Admit.smethod_17((Control)(object)ClearBtn, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1074882100) ^ -1884659952;
					continue;
				case 483u:
					Admit.smethod_20((Control)(object)RoomNo1Txt, new Size(141, 28));
					num = ((int)num2 * -889707228) ^ 0xC1E5DCE;
					continue;
				case 482u:
					num = ((int)num2 * -53816467) ^ 0xD2C8C14;
					continue;
				case 481u:
					Admit.smethod_28((ButtonBase)(object)SearchBtn, Color.MidnightBlue);
					num = (int)(num2 * 942373375) ^ -400445016;
					continue;
				case 480u:
					num = (int)(num2 * 566869500) ^ -2104937192;
					continue;
				case 479u:
					num = ((int)num2 * -1882182699) ^ 0x204AD7FA;
					continue;
				case 478u:
					Admit.smethod_19((Control)(object)Label8, "Label8");
					num = ((int)num2 * -1805202711) ^ 0x48496283;
					continue;
				case 477u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)Label5);
					num = ((int)num2 * -1446796290) ^ -277089601;
					continue;
				case 476u:
					Admit.smethod_21((Control)(object)SearchBtn, 4);
					num = (int)(num2 * 730621217) ^ -444681013;
					continue;
				case 475u:
					Admit.smethod_18((Control)(object)StatusTxt, new Point(266, 198));
					num = ((int)num2 * -222077576) ^ -1049248417;
					continue;
				case 474u:
					Admit.smethod_29((Control)(object)ClearBtn, Color.White);
					num = (int)(num2 * 828329146) ^ -1224713682;
					continue;
				case 473u:
					num = (int)((num2 * 854190618) ^ 0x13B5E149);
					continue;
				case 472u:
					Admit.smethod_17((Control)(object)Label14, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1320492838) ^ 0x370BA631;
					continue;
				case 471u:
					num = ((int)num2 * -557248609) ^ -315333064;
					continue;
				case 470u:
					Admit.smethod_20((Control)(object)AddressTxt, new Size(298, 90));
					num = (int)(num2 * 1685737701) ^ -2135022790;
					continue;
				case 469u:
					Admit.smethod_17((Control)(object)Label11, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1382641619) ^ -957450081;
					continue;
				case 468u:
					Admit.smethod_41((ListControl)(object)DateInTxt, bool_0: true);
					num = (int)(num2 * 875983923) ^ -215017759;
					continue;
				case 467u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)DateOutTxt);
					num = ((int)num2 * -1432696768) ^ 0x2D974A67;
					continue;
				case 466u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)Label14);
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)AddressTxt);
					num = (int)((num2 * 221024835) ^ 0x11BADCDF);
					continue;
				case 465u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)AdmitDischargeBtn);
					num = ((int)num2 * -950422041) ^ 0x56F2CE02;
					continue;
				case 464u:
					Admit.smethod_18((Control)(object)Label9, new Point(18, 71));
					num = (int)(num2 * 987804608) ^ -88798984;
					continue;
				case 463u:
					Admit.smethod_21((Control)(object)AddressTxt, 7);
					num = (int)((num2 * 1381286748) ^ 0x41D533C0);
					continue;
				case 462u:
					num = (int)((num2 * 21263978) ^ 0x738083C4);
					continue;
				case 461u:
					num = (int)(num2 * 788775539) ^ -1079535340;
					continue;
				case 460u:
					num = ((int)num2 * -258373936) ^ -808435657;
					continue;
				case 459u:
					num = (int)(num2 * 1819037954) ^ -2107190143;
					continue;
				case 458u:
					num = (int)(num2 * 1948809919) ^ -990601476;
					continue;
				case 457u:
					Admit.smethod_57((ISupportInitialize)PictureBox1);
					num = (int)((num2 * 403207994) ^ 0x341F64);
					continue;
				case 456u:
					Admit.smethod_18((Control)(object)DateInTxt, new Point(161, 111));
					num = (int)((num2 * 532983672) ^ 0x73A7992E);
					continue;
				case 455u:
					Admit.smethod_57((ISupportInitialize)SearchResultGrid);
					num = ((int)num2 * -256262150) ^ 0x53DDBC79;
					continue;
				case 454u:
					num = (int)((num2 * 297259943) ^ 0x4F0A71A4);
					continue;
				case 453u:
					Admit.smethod_17((Control)(object)HistoryBtn, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1620493794) ^ -745961429;
					continue;
				case 452u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)Label12);
					num = ((int)num2 * -508124665) ^ 0x4F1C444C;
					continue;
				case 451u:
					DateOut1Txt = Admit.smethod_6();
					num = ((int)num2 * -31387374) ^ -1146273154;
					continue;
				case 450u:
					num = (int)(num2 * 1035122133) ^ -1116330576;
					continue;
				case 449u:
					num = ((int)num2 * -572284887) ^ 0x2612B8E4;
					continue;
				case 448u:
					Admit.smethod_17((Control)(object)Label9, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -668332271) ^ 0x11F98004;
					continue;
				case 447u:
					num = ((int)num2 * -1439290518) ^ -1290914077;
					continue;
				case 446u:
					Admit.smethod_40(DateOutTxt, (ComboBoxStyle)2);
					num = ((int)num2 * -1926719015) ^ -1741160153;
					continue;
				case 445u:
					num = ((int)num2 * -795461533) ^ -2030983944;
					continue;
				case 444u:
					Admit.smethod_19((Control)(object)RoomTypeTxt, "RoomTypeTxt");
					Admit.smethod_20((Control)(object)RoomTypeTxt, new Size(181, 27));
					Admit.smethod_21((Control)(object)RoomTypeTxt, 18);
					num = (int)(num2 * 1549645376) ^ -1226773752;
					continue;
				case 443u:
					Admit.smethod_31((ButtonBase)(object)HistoryBtn, bool_0: false);
					num = ((int)num2 * -1616379854) ^ 0x2E12E370;
					continue;
				case 442u:
					num = (int)((num2 * 916212488) ^ 0x3B8E9217);
					continue;
				case 441u:
					Admit.smethod_26(PatientInfoBox, bool_0: false);
					Admit.smethod_27(PatientInfoBox, "Patient Information");
					num = (int)((num2 * 525065141) ^ 0x5F58B5EF);
					continue;
				case 440u:
					Admit.smethod_21((Control)(object)Label11, 10);
					num = ((int)num2 * -451387107) ^ -2070567166;
					continue;
				case 439u:
					Admit.smethod_22(Label6, "Gender : ");
					num = ((int)num2 * -1016399747) ^ -830563130;
					continue;
				case 438u:
					Admit.smethod_18((Control)(object)NameTxt, new Point(96, 77));
					num = ((int)num2 * -1061937097) ^ 0x2B2C771;
					continue;
				case 437u:
					Admit.smethod_19((Control)(object)SearchResultGrid, "SearchResultGrid");
					Admit.smethod_34(SearchResultGrid, bool_0: true);
					num = (int)(num2 * 1919239632) ^ -66202207;
					continue;
				case 436u:
					Admit.smethod_17((Control)(object)SearchBtn, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1543422176) ^ -2064876748;
					continue;
				case 435u:
					num = ((int)num2 * -1505761375) ^ 0x2602F2B6;
					continue;
				case 434u:
					Admit.smethod_18((Control)(object)Label13, new Point(18, 157));
					num = (int)(num2 * 1952240932) ^ -1824914763;
					continue;
				case 433u:
					Admit.smethod_50((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 1181776762) ^ 0x2F555564);
					continue;
				case 432u:
					Admit.smethod_17((Control)(object)Label3, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Admit.smethod_18((Control)(object)Label3, new Point(37, 87));
					num = (int)((num2 * 1022761295) ^ 0x75D61D53);
					continue;
				case 431u:
					num = (int)(num2 * 819255046) ^ -1982015081;
					continue;
				case 430u:
					Admit.smethod_38((TextBoxBase)(object)AddressTxt, bool_0: true);
					num = ((int)num2 * -724155756) ^ -550927839;
					continue;
				case 429u:
					num = (int)(num2 * 643676649) ^ -322605215;
					continue;
				case 428u:
					Admit.smethod_20((Control)(object)Label1, new Size(344, 35));
					num = (int)(num2 * 1628495210) ^ -1465153722;
					continue;
				case 427u:
					Admit.smethod_17((Control)(object)Label15, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -820082994) ^ -1853459852;
					continue;
				case 426u:
					Admit.smethod_18((Control)(object)Label11, new Point(184, 201));
					num = (int)((num2 * 1356546210) ^ 0x63D44D1C);
					continue;
				case 425u:
					num = (int)((num2 * 1860032075) ^ 0x1B248BE3);
					continue;
				case 424u:
					Admit.smethod_19((Control)(object)HistoryBtn, "HistoryBtn");
					Admit.smethod_20((Control)(object)HistoryBtn, new Size(181, 41));
					num = ((int)num2 * -1490384485) ^ 0x43213AE2;
					continue;
				case 423u:
					num = ((int)num2 * -882250031) ^ -1592855223;
					continue;
				case 422u:
					Admit.smethod_19((Control)(object)RoomNo1Txt, "RoomNo1Txt");
					num = ((int)num2 * -387173711) ^ 0x5BD5C437;
					continue;
				case 421u:
					Admit.smethod_18((Control)(object)Label4, new Point(13, 43));
					num = (int)(num2 * 410888633) ^ -1807994654;
					continue;
				case 420u:
					StatusTxt = Admit.smethod_8();
					num = (int)((num2 * 1236513559) ^ 0xC671AF2);
					continue;
				case 419u:
					Admit.smethod_12((Control)(object)AdmitDetailsBox);
					Admit.smethod_13((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -1376541627) ^ -1784499718;
					continue;
				case 418u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)Label10);
					num = (int)(num2 * 776191069) ^ -1066637069;
					continue;
				case 417u:
					Admit.smethod_20((Control)(object)MobileSTxt, new Size(253, 28));
					Admit.smethod_21((Control)(object)MobileSTxt, 11);
					num = ((int)num2 * -1352999094) ^ 0x5F0D728B;
					continue;
				case 416u:
					Admit.smethod_41((ListControl)(object)RoomTypeTxt, bool_0: true);
					num = ((int)num2 * -1170267643) ^ -909980806;
					continue;
				case 415u:
					Admit.smethod_55((Control)(object)GroupBox1, bool_0: false);
					num = ((int)num2 * -1966171105) ^ -240914709;
					continue;
				case 414u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)PIDTxt);
					num = (int)(num2 * 843485942) ^ -1093722767;
					continue;
				case 413u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)GroupBox1), (Control)(object)Label2);
					Admit.smethod_17((Control)(object)GroupBox1, Admit.smethod_16("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -825228316) ^ -239731484;
					continue;
				case 412u:
					Admit.smethod_18((Control)(object)Label10, new Point(18, 201));
					num = ((int)num2 * -955362624) ^ 0x5750D5DD;
					continue;
				case 411u:
					Admit.smethod_28((ButtonBase)(object)AdmitDischargeBtn, Color.MidnightBlue);
					num = (int)((num2 * 97505434) ^ 0x79841C81);
					continue;
				case 410u:
					num = (int)(num2 * 1258935885) ^ -2055218883;
					continue;
				case 409u:
					num = ((int)num2 * -704587257) ^ 0x3795FD4E;
					continue;
				case 408u:
					num = (int)(num2 * 538749145) ^ -1397111270;
					continue;
				case 407u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)Label7);
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)Label6);
					num = ((int)num2 * -864774082) ^ 0x27F79FF1;
					continue;
				case 406u:
					num = ((int)num2 * -1801869947) ^ -1913293952;
					continue;
				case 405u:
					num = ((int)num2 * -1704923220) ^ 0x42C6C02;
					continue;
				case 404u:
					num = ((int)num2 * -1689129333) ^ -1297987608;
					continue;
				case 403u:
					Admit.smethod_37((Control)(object)AdmitDetailsBox, bool_0: false);
					num = (int)((num2 * 1408861072) ^ 0x75B3140C);
					continue;
				case 402u:
					Admit.smethod_19((Control)(object)GroupBox1, "GroupBox1");
					Admit.smethod_20((Control)(object)GroupBox1, new Size(623, 128));
					num = (int)((num2 * 1334501065) ^ 0x6E58E3F4);
					continue;
				case 401u:
					Admit.smethod_22(Label9, "Room Type :");
					num = ((int)num2 * -1006557914) ^ -1297787879;
					continue;
				case 400u:
					Admit.smethod_19((Control)(object)AdmitDetailsBox, "AdmitDetailsBox");
					num = (int)((num2 * 2143908509) ^ 0x496DF403);
					continue;
				case 399u:
					Admit.smethod_18((Control)(object)RoomTypeTxt, new Point(161, 71));
					num = (int)((num2 * 61431940) ^ 0x273AAD5B);
					continue;
				case 398u:
					Admit.smethod_18((Control)(object)RoomNoTxt, new Point(161, 32));
					num = ((int)num2 * -1900612703) ^ -835571023;
					continue;
				case 397u:
					num = (int)(num2 * 1478776571) ^ -989959878;
					continue;
				case 396u:
					Admit.smethod_19((Control)(object)Label5, "Label5");
					num = (int)((num2 * 1165659083) ^ 0x619C2F5);
					continue;
				case 395u:
					Admit.smethod_21((Control)(object)MobileTxt, 2);
					num = ((int)num2 * -737036446) ^ -45222572;
					continue;
				case 393u:
					num = (int)((num2 * 1603442088) ^ 0x268EDEAF);
					continue;
				case 392u:
					Admit.smethod_37((Control)(object)RoomNo1Txt, bool_0: false);
					Admit.smethod_18((Control)(object)RoomType1Txt, new Point(161, 73));
					Admit.smethod_19((Control)(object)RoomType1Txt, "RoomType1Txt");
					num = (int)(num2 * 88432475) ^ -216891227;
					continue;
				case 391u:
					Admit.smethod_20((Control)(object)DateOut1Txt, new Size(181, 28));
					num = ((int)num2 * -1193560264) ^ 0x3B2DBCDD;
					continue;
				case 390u:
					Label11 = Admit.smethod_3();
					num = (int)(num2 * 283353741) ^ -1648356345;
					continue;
				case 389u:
					num = ((int)num2 * -1484500148) ^ 0x1A117CED;
					continue;
				case 388u:
					num = ((int)num2 * -1073943954) ^ -166672091;
					continue;
				case 387u:
					Admit.smethod_21((Control)(object)ClearBtn, 9);
					Admit.smethod_30((ButtonBase)(object)ClearBtn, "Clear");
					Admit.smethod_31((ButtonBase)(object)ClearBtn, bool_0: false);
					num = (int)(num2 * 1558898641) ^ -675316823;
					continue;
				case 386u:
					Admit.smethod_17((Control)(object)DateOutTxt, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -252463099) ^ -1762111727;
					continue;
				case 385u:
					num = (int)(num2 * 298352042) ^ -1245812916;
					continue;
				case 384u:
					Admit.smethod_20((Control)(object)Label2, new Size(77, 28));
					num = ((int)num2 * -948653617) ^ -111982327;
					continue;
				case 383u:
					num = ((int)num2 * -303175441) ^ -222344151;
					continue;
				case 382u:
					num = ((int)num2 * -397052823) ^ -1885722334;
					continue;
				case 381u:
					Admit.smethod_38((TextBoxBase)(object)RoomNo1Txt, bool_0: true);
					num = ((int)num2 * -1708332849) ^ -120944293;
					continue;
				case 380u:
					Admit.smethod_38((TextBoxBase)(object)PIDTxt, bool_0: true);
					Admit.smethod_20((Control)(object)PIDTxt, new Size(128, 28));
					num = ((int)num2 * -1606601105) ^ 0x139BE8D1;
					continue;
				case 379u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)Label1);
					num = ((int)num2 * -1860802076) ^ 0x15650B00;
					continue;
				case 378u:
					Admit.smethod_20((Control)(object)DateInTxt, new Size(181, 27));
					Admit.smethod_21((Control)(object)DateInTxt, 16);
					num = ((int)num2 * -1243150633) ^ 0x73692BC;
					continue;
				case 377u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)Label13);
					num = ((int)num2 * -552328917) ^ -1022766750;
					continue;
				case 376u:
					Admit.smethod_21((Control)(object)PIDTxt, 4);
					num = (int)(num2 * 1177177407) ^ -734728035;
					continue;
				case 375u:
					Admit.smethod_17((Control)(object)DateInTxt, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 921203033) ^ 0x71B5E9AE);
					continue;
				case 374u:
					Admit.smethod_38((TextBoxBase)(object)GenderTxt, bool_0: true);
					num = (int)(num2 * 1707113828) ^ -379519487;
					continue;
				case 373u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)GroupBox1), (Control)(object)Label3);
					num = (int)(num2 * 709346956) ^ -389926006;
					continue;
				case 372u:
					Admit.smethod_27(GroupBox1, "Search Patient");
					num = ((int)num2 * -2020267198) ^ 0x5F4F5264;
					continue;
				case 371u:
					num = (int)(num2 * 1258472850) ^ -1055697522;
					continue;
				case 370u:
					Admit.smethod_20((Control)(object)StatusTxt, new Size(136, 30));
					num = ((int)num2 * -1248075482) ^ -387581520;
					continue;
				case 369u:
					Admit.smethod_29((Control)(object)AdmitDischargeBtn, Color.White);
					num = ((int)num2 * -924174957) ^ 0x2CAA045C;
					continue;
				case 368u:
					Admit.smethod_32(SearchResultGrid, Color.White);
					num = ((int)num2 * -602052323) ^ -648118437;
					continue;
				case 367u:
					Admit.smethod_22(Label12, "Date In  :");
					num = (int)((num2 * 1901327667) ^ 0x1A29465F);
					continue;
				case 366u:
					num = (int)((num2 * 223056871) ^ 0x25336D59);
					continue;
				case 365u:
					Admit.smethod_21((Control)(object)Label3, 3);
					num = (int)(num2 * 649237922) ^ -1232044707;
					continue;
				case 364u:
					Admit.smethod_20((Control)(object)Label5, new Size(68, 26));
					num = (int)((num2 * 25696946) ^ 0x51F5092D);
					continue;
				case 363u:
					num = (int)(num2 * 1320402614) ^ -1559868773;
					continue;
				case 362u:
					num = ((int)num2 * -1023439237) ^ 0x21E1F451;
					continue;
				case 361u:
					Admit.smethod_30((ButtonBase)(object)PrintBtn, "Print");
					num = (int)((num2 * 1594950968) ^ 0x2A4E8C26);
					continue;
				case 360u:
					Admit.smethod_20((Control)(object)SaveBtn, new Size(98, 37));
					Admit.smethod_21((Control)(object)SaveBtn, 11);
					Admit.smethod_30((ButtonBase)(object)SaveBtn, "Save");
					num = (int)((num2 * 1149853654) ^ 0x5DADB05B);
					continue;
				case 359u:
					Admit.smethod_37((Control)(object)ClearBtn, bool_0: false);
					num = (int)(num2 * 53196460) ^ -839307640;
					continue;
				case 358u:
					num = (int)((num2 * 1101907240) ^ 0x1FA000D4);
					continue;
				case 357u:
					num = (int)(num2 * 1075816749) ^ -799473759;
					continue;
				case 356u:
					DateIn1Txt = Admit.smethod_6();
					num = (int)(num2 * 68919948) ^ -715832683;
					continue;
				case 355u:
					Admit.smethod_37((Control)(object)PatientInfoBox, bool_0: false);
					Admit.smethod_18((Control)(object)MobileSTxt, new Point(96, 116));
					num = ((int)num2 * -840192066) ^ -2102637782;
					continue;
				case 354u:
					Admit.smethod_21((Control)(object)RoomNoTxt, 19);
					num = ((int)num2 * -1254874923) ^ 0x16DEAA75;
					continue;
				case 353u:
					Admit.smethod_21((Control)(object)RoomType1Txt, 21);
					num = (int)(num2 * 784673699) ^ -1430548971;
					continue;
				case 352u:
					Admit.smethod_17((Control)(object)Label8, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1944251621) ^ -533958856;
					continue;
				case 351u:
					Admit.smethod_54((Control)(object)this, new Size(977, 804));
					num = ((int)num2 * -2051762627) ^ -245196489;
					continue;
				case 350u:
					Admit.smethod_18((Control)(object)MobileTxt, new Point(120, 86));
					Admit.smethod_19((Control)(object)MobileTxt, "MobileTxt");
					num = ((int)num2 * -1656935073) ^ -831382891;
					continue;
				case 349u:
					num = (int)((num2 * 458564833) ^ 0xBE4BD77);
					continue;
				case 348u:
					num = ((int)num2 * -1832652788) ^ -617483732;
					continue;
				case 347u:
					num = (int)(num2 * 1826784824) ^ -1585285414;
					continue;
				case 346u:
					Admit.smethod_21((Control)(object)Label8, 1);
					num = ((int)num2 * -1854958498) ^ 0x2FDB06F;
					continue;
				case 345u:
					num = (int)((num2 * 330675419) ^ 0x69A47281);
					continue;
				case 344u:
					Admit.smethod_23(Label1, (ContentAlignment)32);
					num = ((int)num2 * -1588558718) ^ -2043835118;
					continue;
				case 343u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)NameTxt);
					num = ((int)num2 * -573536206) ^ -1249123255;
					continue;
				case 342u:
					num = (int)(num2 * 146590412) ^ -1323124765;
					continue;
				case 341u:
					Label1 = Admit.smethod_3();
					num = ((int)num2 * -1623209271) ^ 0x4A1C4A1A;
					continue;
				case 340u:
					Admit.smethod_18((Control)(object)AddressTxt, new Point(124, 198));
					num = ((int)num2 * -194785151) ^ 0x46B9081B;
					continue;
				case 339u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)RoomType1Txt);
					num = ((int)num2 * -432224539) ^ -1621323653;
					continue;
				case 338u:
					Admit.smethod_20((Control)(object)NameSTxt, new Size(237, 28));
					num = ((int)num2 * -1793097226) ^ -1896717735;
					continue;
				case 337u:
					Admit.smethod_20((Control)(object)AdmitDischargeBtn, new Size(181, 45));
					num = ((int)num2 * -807312260) ^ -2129128421;
					continue;
				case 336u:
					Admit.smethod_21((Control)(object)StatusTxt, 15);
					num = ((int)num2 * -1823520100) ^ -1493450407;
					continue;
				case 335u:
					num = ((int)num2 * -590485570) ^ -266449173;
					continue;
				case 334u:
					Admit.smethod_37((Control)(object)AdmitDischargeBtn, bool_0: false);
					num = (int)(num2 * 1423457935) ^ -620307112;
					continue;
				case 333u:
					Admit.smethod_21((Control)(object)Label12, 11);
					num = (int)(num2 * 591738535) ^ -949252380;
					continue;
				case 332u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)PrintBtn);
					num = (int)((num2 * 215153369) ^ 0x68D13241);
					continue;
				case 331u:
					Admit.smethod_17((Control)(object)AdmitDischargeBtn, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1092399948) ^ 0x5A421C99);
					continue;
				case 330u:
					Admit.smethod_38((TextBoxBase)(object)RoomType1Txt, bool_0: true);
					num = ((int)num2 * -712344783) ^ -740225496;
					continue;
				case 329u:
					Label14 = Admit.smethod_3();
					num = ((int)num2 * -2078373507) ^ 0x37ADB3E8;
					continue;
				case 328u:
					Admit.smethod_45(PictureBox1, (Image)(object)Resources.medical_bed_icon);
					Admit.smethod_18((Control)(object)PictureBox1, new Point(260, 22));
					num = (int)((num2 * 1879022768) ^ 0xC7A379D);
					continue;
				case 327u:
					Admit.smethod_17((Control)(object)RoomTypeTxt, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1169723609) ^ -1108700287;
					continue;
				case 326u:
					Admit.smethod_21((Control)(object)DateIn1Txt, 13);
					num = ((int)num2 * -1468642822) ^ 0x9F556BD;
					continue;
				case 325u:
					num = (int)(num2 * 1376994751) ^ -86641299;
					continue;
				case 324u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)HistoryBtn);
					num = ((int)num2 * -1479304570) ^ 0x2A1FC730;
					continue;
				case 323u:
					Admit.smethod_53((Control)(object)this, "Admit");
					num = (int)(num2 * 390696105) ^ -1495262915;
					continue;
				case 322u:
					num = (int)(num2 * 520083676) ^ -1359865359;
					continue;
				case 321u:
					Admit.smethod_38((TextBoxBase)(object)DateIn1Txt, bool_0: true);
					num = ((int)num2 * -917185865) ^ 0x79864B83;
					continue;
				case 320u:
					Admit.smethod_20((Control)(object)Label15, new Size(77, 26));
					num = ((int)num2 * -1654193399) ^ 0x70AEE2BA;
					continue;
				case 319u:
					Admit.smethod_19((Control)(object)DateIn1Txt, "DateIn1Txt");
					num = ((int)num2 * -1874736401) ^ -1973374857;
					continue;
				case 318u:
					Admit.smethod_30((ButtonBase)(object)HistoryBtn, "History");
					num = (int)((num2 * 1279412487) ^ 0x49CEC39F);
					continue;
				case 317u:
					Admit.smethod_38((TextBoxBase)(object)MobileSTxt, bool_0: true);
					num = (int)(num2 * 1443026026) ^ -662776177;
					continue;
				case 316u:
					Admit.smethod_17((Control)(object)Label2, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -622196638) ^ -1409737444;
					continue;
				case 315u:
					num = (int)((num2 * 150951073) ^ 0x54C0F392);
					continue;
				case 314u:
					num = ((int)num2 * -630333077) ^ 0x30A4B625;
					continue;
				case 313u:
					Admit.smethod_31((ButtonBase)(object)AdmitDischargeBtn, bool_0: false);
					num = ((int)num2 * -1771041960) ^ -1753285849;
					continue;
				case 312u:
					num = (int)((num2 * 1276557633) ^ 0x42E72EF8);
					continue;
				case 311u:
					Admit.smethod_19((Control)(object)AddressTxt, "AddressTxt");
					num = (int)((num2 * 1793688890) ^ 0x397256FF);
					continue;
				case 310u:
					num = (int)(num2 * 96231408) ^ -1504505774;
					continue;
				case 309u:
					Admit.smethod_21((Control)(object)AdmitDetailsBox, 8);
					num = (int)(num2 * 1287700998) ^ -2009081310;
					continue;
				case 308u:
					Admit.smethod_14((Control)(object)this);
					Admit.smethod_15(Label1, bool_0: true);
					num = ((int)num2 * -1645418066) ^ 0x5B5139C8;
					continue;
				case 307u:
					num = (int)(num2 * 1644099095) ^ -1778778577;
					continue;
				case 306u:
					num = (int)((num2 * 547966234) ^ 0x3064444F);
					continue;
				case 305u:
					Admit.smethod_20((Control)(object)Label13, new Size(109, 25));
					num = ((int)num2 * -1310848532) ^ 0x66EFD2EB;
					continue;
				case 304u:
					Admit.smethod_17((Control)(object)Label7, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 281183897) ^ 0x7DA1F589);
					continue;
				case 303u:
					Admit.smethod_55((Control)(object)AdmitDetailsBox, bool_0: false);
					num = (int)(num2 * 346593995) ^ -1705704984;
					continue;
				case 302u:
					Admit.smethod_56((Control)(object)AdmitDetailsBox);
					num = (int)(num2 * 989783163) ^ -345825591;
					continue;
				case 301u:
					num = (int)(num2 * 1470980848) ^ -1842923131;
					continue;
				case 300u:
					MobileTxt = Admit.smethod_6();
					num = ((int)num2 * -1025063805) ^ -1141729961;
					continue;
				case 299u:
					Admit.smethod_22(Label5, "DOB :");
					num = ((int)num2 * -1732350824) ^ 0x29C613C4;
					continue;
				case 298u:
					Admit.smethod_23(Label11, (ContentAlignment)32);
					num = ((int)num2 * -572371645) ^ -1771411898;
					continue;
				case 297u:
					Admit.smethod_28((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					num = ((int)num2 * -287358219) ^ 0x43365871;
					continue;
				case 296u:
					Admit.smethod_20((Control)(object)PatientInfoBox, new Size(439, 298));
					num = ((int)num2 * -414772197) ^ 0x6274415F;
					continue;
				case 295u:
					Admit.smethod_22(Label1, "Admit And Discharge ");
					num = (int)((num2 * 684989600) ^ 0x6FBD619C);
					continue;
				case 294u:
					num = (int)(num2 * 1819031000) ^ -457283566;
					continue;
				case 293u:
					Admit.smethod_22(Label15, "Mobile :");
					num = ((int)num2 * -280450386) ^ -785507073;
					continue;
				case 292u:
					Admit.smethod_20((Control)(object)NameTxt, new Size(326, 28));
					num = ((int)num2 * -1738804634) ^ 0x1AAB7A8C;
					continue;
				case 291u:
					num = (int)((num2 * 1362518354) ^ 0x7007E2D1);
					continue;
				case 290u:
					Admit.smethod_22(Label8, "Room No :");
					num = (int)((num2 * 1118686776) ^ 0x2EB361B5);
					continue;
				case 289u:
					Label3 = Admit.smethod_3();
					num = ((int)num2 * -1783758020) ^ 0x672D715B;
					continue;
				case 288u:
					SearchBtn = Admit.smethod_5();
					num = ((int)num2 * -840100954) ^ -2089799593;
					continue;
				case 287u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)SearchResultGrid);
					num = ((int)num2 * -1995765682) ^ -1119921596;
					continue;
				case 286u:
					Admit.smethod_18((Control)(object)GenderTxt, new Point(322, 152));
					num = (int)(num2 * 756337845) ^ -800800012;
					continue;
				case 285u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)AdmitDetailsBox);
					num = (int)((num2 * 1199561828) ^ 0x3D773429);
					continue;
				case 284u:
					Admit.smethod_39(AddressTxt, bool_0: true);
					num = (int)(num2 * 717589492) ^ -1031722555;
					continue;
				case 283u:
					Admit.smethod_49((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = (int)(num2 * 1122585066) ^ -1360460683;
					continue;
				case 282u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)Label4);
					num = (int)(num2 * 964261915) ^ -1724356642;
					continue;
				case 281u:
					PatientInfoBox = Admit.smethod_4();
					num = (int)(num2 * 1159727983) ^ -1521045223;
					continue;
				case 280u:
					Admit.smethod_20((Control)(object)Label11, new Size(76, 28));
					num = ((int)num2 * -1785796243) ^ -1869568623;
					continue;
				case 279u:
					num = ((int)num2 * -1783908942) ^ 0x1F699C31;
					continue;
				case 278u:
					Admit.smethod_21((Control)(object)HistoryBtn, 18);
					num = ((int)num2 * -1434978780) ^ -1144141394;
					continue;
				case 277u:
					AgeTxt = Admit.smethod_6();
					num = (int)((num2 * 1087776895) ^ 0x4DB3B80D);
					continue;
				case 276u:
					Admit.smethod_18((Control)(object)PrintBtn, new Point(655, 746));
					num = ((int)num2 * -455891691) ^ -1606917308;
					continue;
				case 275u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)FeesTxt);
					num = ((int)num2 * -969263489) ^ -1979531320;
					continue;
				case 274u:
					Admit.smethod_20((Control)(object)AgeTxt, new Size(128, 23));
					num = ((int)num2 * -2036686175) ^ -1586272091;
					continue;
				case 273u:
					num = (int)((num2 * 1178516733) ^ 0x7A70F19E);
					continue;
				case 272u:
					num = ((int)num2 * -1631134291) ^ 0x58AD7F76;
					continue;
				case 271u:
					Admit.smethod_46(PictureBox1, (PictureBoxSizeMode)1);
					Admit.smethod_47(PictureBox1, 2);
					Admit.smethod_48(PictureBox1, bool_0: false);
					Admit.smethod_28((ButtonBase)(object)HistoryBtn, Color.MidnightBlue);
					num = ((int)num2 * -2040270191) ^ 0x3A20A02B;
					continue;
				case 270u:
					Admit.smethod_18((Control)(object)RoomNo1Txt, new Point(161, 32));
					num = ((int)num2 * -765276224) ^ 0x68A911A1;
					continue;
				case 269u:
					Admit.smethod_28((ButtonBase)(object)PrintBtn, Color.MidnightBlue);
					num = (int)((num2 * 1170466327) ^ 0x8C1E4AE);
					continue;
				case 268u:
					GroupBox1 = Admit.smethod_4();
					num = (int)(num2 * 2013375878) ^ -379358252;
					continue;
				case 267u:
					Admit.smethod_19((Control)(object)SearchBtn, "SearchBtn");
					num = ((int)num2 * -2047829453) ^ 0x29EF7847;
					continue;
				case 266u:
					Admit.smethod_19((Control)(object)Label10, "Label10");
					Admit.smethod_20((Control)(object)Label10, new Size(79, 25));
					num = ((int)num2 * -1276500416) ^ -1977937777;
					continue;
				case 265u:
					Admit.smethod_18((Control)(object)ClearBtn, new Point(504, 746));
					num = (int)(num2 * 1116116792) ^ -2142761037;
					continue;
				case 264u:
					Admit.smethod_38((TextBoxBase)(object)DateOut1Txt, bool_0: true);
					num = (int)(num2 * 512325427) ^ -1898500924;
					continue;
				case 263u:
					RoomType1Txt = Admit.smethod_6();
					Admit.smethod_12((Control)(object)GroupBox1);
					num = ((int)num2 * -726097590) ^ 0x41859DFD;
					continue;
				case 262u:
					num = ((int)num2 * -482737820) ^ -1023179714;
					continue;
				case 261u:
					num = (int)((num2 * 499295731) ^ 0x1F114E3);
					continue;
				case 260u:
					Admit.smethod_30((ButtonBase)(object)AdmitDischargeBtn, "Admit/Discharge");
					num = (int)(num2 * 792517615) ^ -1483138464;
					continue;
				case 259u:
					num = (int)(num2 * 575616064) ^ -1357433709;
					continue;
				case 258u:
					Admit.smethod_20((Control)(object)RoomNoTxt, new Size(141, 27));
					num = ((int)num2 * -1639313472) ^ -451217512;
					continue;
				case 257u:
					num = ((int)num2 * -1347800240) ^ -767290972;
					continue;
				case 256u:
					Label13 = Admit.smethod_3();
					num = (int)(num2 * 625584494) ^ -479013711;
					continue;
				case 255u:
					num = ((int)num2 * -218985359) ^ 0x10844070;
					continue;
				case 254u:
					num = (int)(num2 * 1044314120) ^ -1632321232;
					continue;
				case 253u:
					num = ((int)num2 * -1017636646) ^ -1371707087;
					continue;
				case 252u:
					num = ((int)num2 * -1356113824) ^ -1371700753;
					continue;
				case 251u:
					Admit.smethod_19((Control)(object)Label14, "Label14");
					num = (int)((num2 * 1872874251) ^ 0x1670105A);
					continue;
				case 250u:
					Admit.smethod_19((Control)(object)NameTxt, "NameTxt");
					num = ((int)num2 * -1041218639) ^ -1512366912;
					continue;
				case 249u:
					num = (int)((num2 * 600961939) ^ 0x5CCF6C4F);
					continue;
				case 248u:
					num = ((int)num2 * -1942332347) ^ 0x5029056F;
					continue;
				case 247u:
					num = ((int)num2 * -132982459) ^ 0x8DF514;
					continue;
				case 246u:
					Admit.smethod_37((Control)(object)HistoryBtn, bool_0: false);
					num = ((int)num2 * -211042919) ^ -1878787085;
					continue;
				case 245u:
					Admit.smethod_19((Control)(object)Label4, "Label4");
					num = ((int)num2 * -2901644) ^ 0x129C4204;
					continue;
				case 244u:
					num = (int)(num2 * 346293517) ^ -898052348;
					continue;
				case 243u:
					Admit.smethod_22(Label3, "Mobile : ");
					num = ((int)num2 * -1128550195) ^ -1282383150;
					continue;
				case 242u:
					num = ((int)num2 * -1332037627) ^ -324048275;
					continue;
				case 241u:
					num = ((int)num2 * -740429278) ^ -197554611;
					continue;
				case 239u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)PatientInfoBox);
					num = (int)((num2 * 197974177) ^ 0x1CD40A30);
					continue;
				case 238u:
					PrintDocument1 = Admit.smethod_10();
					PictureBox1 = Admit.smethod_11();
					num = ((int)num2 * -1964991630) ^ 0x79850B57;
					continue;
				case 237u:
					Label5 = Admit.smethod_3();
					num = (int)(num2 * 1333830955) ^ -781796866;
					continue;
				case 236u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)GroupBox1);
					num = ((int)num2 * -1003516910) ^ -306264179;
					continue;
				case 235u:
					Admit.smethod_17((Control)(object)PrintBtn, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1327845340) ^ 0x73154B43;
					continue;
				case 234u:
					Admit.smethod_29((Control)(object)PrintBtn, Color.White);
					num = ((int)num2 * -1148466606) ^ 0x7531F719;
					continue;
				case 233u:
					RoomNo1Txt = Admit.smethod_6();
					num = (int)((num2 * 1657805932) ^ 0x3CB08D38);
					continue;
				case 232u:
					Admit.smethod_36(Admit.smethod_35(SearchResultGrid), 24);
					num = (int)(num2 * 106194855) ^ -235628816;
					continue;
				case 231u:
					Admit.smethod_21((Control)(object)Label10, 3);
					Admit.smethod_22(Label10, "Fees  :");
					Admit.smethod_23(Label10, (ContentAlignment)32);
					num = ((int)num2 * -622195486) ^ -1303447291;
					continue;
				case 230u:
					Admit.smethod_20((Control)(object)Label4, new Size(68, 25));
					num = ((int)num2 * -390712841) ^ 0xFD433F3;
					continue;
				case 229u:
					Admit.smethod_20((Control)(object)Label3, new Size(77, 28));
					num = (int)((num2 * 1917988182) ^ 0x36BC7766);
					continue;
				case 228u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)Label9);
					num = (int)(num2 * 298562343) ^ -783566905;
					continue;
				case 227u:
					Admit.smethod_17((Control)(object)Label6, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -707356172) ^ 0x67A96EB5;
					continue;
				case 226u:
					Admit.smethod_19((Control)(object)PIDTxt, "PIDTxt");
					num = (int)(num2 * 1321835481) ^ -1862973656;
					continue;
				case 225u:
					PIDTxt = Admit.smethod_6();
					Label7 = Admit.smethod_3();
					num = (int)((num2 * 1503571658) ^ 0x381ADD35);
					continue;
				case 224u:
					Admit.smethod_18((Control)(object)Label12, new Point(18, 111));
					num = (int)((num2 * 672991182) ^ 0x4FD36F83);
					continue;
				case 223u:
					Admit.smethod_20((Control)(object)MobileTxt, new Size(237, 28));
					num = ((int)num2 * -589071765) ^ -179391937;
					continue;
				case 222u:
					Admit.smethod_41((ListControl)(object)DateOutTxt, bool_0: true);
					num = (int)(num2 * 650819940) ^ -2085717744;
					continue;
				case 221u:
					Admit.smethod_40(StatusTxt, (ComboBoxStyle)2);
					num = (int)(num2 * 1518196415) ^ -344991299;
					continue;
				case 220u:
					Admit.smethod_21((Control)(object)Label13, 12);
					num = (int)(num2 * 1071322372) ^ -1711123176;
					continue;
				case 219u:
					PrintBtn = Admit.smethod_5();
					num = ((int)num2 * -1989736387) ^ 0x36520B43;
					continue;
				case 218u:
					Admit.smethod_18((Control)(object)DateOut1Txt, new Point(161, 157));
					num = ((int)num2 * -1629244087) ^ 0x2DC4580A;
					continue;
				case 217u:
					Admit.smethod_58((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1385683489) ^ 0x6D2D4FB2;
					continue;
				case 216u:
					num = ((int)num2 * -867662588) ^ -1818442193;
					continue;
				case 215u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)DateIn1Txt);
					num = (int)((num2 * 33204951) ^ 0x6E7D0AD2);
					continue;
				case 214u:
					Admit.smethod_19((Control)(object)Label12, "Label12");
					num = (int)(num2 * 619266998) ^ -295036751;
					continue;
				case 213u:
					num = ((int)num2 * -772144796) ^ 0x6B26E567;
					continue;
				case 212u:
					num = (int)(num2 * 395464422) ^ -944975286;
					continue;
				case 211u:
					num = ((int)num2 * -1147361050) ^ -2062611545;
					continue;
				case 210u:
					num = ((int)num2 * -1647765559) ^ 0x4CA194DD;
					continue;
				case 209u:
					num = ((int)num2 * -1186682428) ^ -1128476170;
					continue;
				case 208u:
					Admit.smethod_19((Control)(object)MobileSTxt, "MobileSTxt");
					num = (int)((num2 * 1691299146) ^ 0x62626D52);
					continue;
				case 207u:
					Admit.smethod_29((Control)(object)HistoryBtn, Color.White);
					num = (int)(num2 * 1614879423) ^ -238564777;
					continue;
				case 206u:
					Admit.smethod_18((Control)(object)FeesTxt, new Point(92, 201));
					num = (int)((num2 * 428221121) ^ 0x6E08C94A);
					continue;
				case 205u:
					num = (int)(num2 * 185209925) ^ -1968751029;
					continue;
				case 204u:
					num = ((int)num2 * -1785790117) ^ -1554577130;
					continue;
				case 203u:
					num = (int)((num2 * 721425862) ^ 0x2F49663F);
					continue;
				case 202u:
					Label12 = Admit.smethod_3();
					num = (int)(num2 * 1073953922) ^ -2078887582;
					continue;
				case 201u:
					Admit.smethod_18((Control)(object)Label1, new Point(392, 63));
					Admit.smethod_19((Control)(object)Label1, "Label1");
					num = ((int)num2 * -664413924) ^ 0x14CF9C8C;
					continue;
				case 200u:
					Admit.smethod_21((Control)(object)GenderTxt, 6);
					num = (int)((num2 * 425115935) ^ 0x62AC089C);
					continue;
				case 199u:
					Admit.smethod_19((Control)(object)Label13, "Label13");
					num = (int)(num2 * 1432900177) ^ -778044823;
					continue;
				case 198u:
					Admit.smethod_19((Control)(object)Label3, "Label3");
					num = ((int)num2 * -523042364) ^ 0x3B32707D;
					continue;
				case 197u:
					Label15 = Admit.smethod_3();
					num = (int)(num2 * 482659037) ^ -197632004;
					continue;
				case 196u:
					Admit.smethod_21((Control)(object)AgeTxt, 5);
					num = ((int)num2 * -1764488819) ^ -1582774061;
					continue;
				case 195u:
					num = (int)(num2 * 811124732) ^ -1974259921;
					continue;
				case 194u:
					num = ((int)num2 * -710271784) ^ -1624752331;
					continue;
				case 193u:
					PrintDialog1 = Admit.smethod_9();
					num = ((int)num2 * -467667246) ^ 0x21C19806;
					continue;
				case 192u:
					Admit.smethod_20((Control)(object)SearchResultGrid, new Size(853, 169));
					num = ((int)num2 * -1859690290) ^ -1912445164;
					continue;
				case 191u:
					Admit.smethod_31((ButtonBase)(object)PrintBtn, bool_0: false);
					num = (int)(num2 * 643098665) ^ -1079798901;
					continue;
				case 190u:
					Admit.smethod_19((Control)(object)AdmitDischargeBtn, "AdmitDischargeBtn");
					num = ((int)num2 * -794080598) ^ -355108103;
					continue;
				case 189u:
					num = ((int)num2 * -37470335) ^ 0x4A0CB59B;
					continue;
				case 188u:
					num = ((int)num2 * -1363486205) ^ -1322101631;
					continue;
				case 187u:
					Admit.smethod_21((Control)(object)NameSTxt, 1);
					num = (int)((num2 * 740036031) ^ 0x69DC658A);
					continue;
				case 186u:
					Admit.smethod_19((Control)(object)Label6, "Label6");
					num = (int)(num2 * 14960312) ^ -2035053965;
					continue;
				case 185u:
					num = (int)(num2 * 1434020472) ^ -1664157299;
					continue;
				case 184u:
					Admit.smethod_18((Control)(object)DateIn1Txt, new Point(161, 110));
					num = (int)((num2 * 2121731238) ^ 0x213CCED1);
					continue;
				case 183u:
					Admit.smethod_18((Control)(object)DateOutTxt, new Point(161, 157));
					num = (int)(num2 * 1880181935) ^ -28036409;
					continue;
				case 182u:
					Admit.smethod_20((Control)(object)Label14, new Size(77, 25));
					num = ((int)num2 * -2051919622) ^ 0x4833C54;
					continue;
				case 181u:
					Admit.smethod_17((Control)(object)Label4, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -744826599) ^ 0x2D9C38B6;
					continue;
				case 180u:
					Admit.smethod_20((Control)(object)ClearBtn, new Size(97, 37));
					num = ((int)num2 * -695905395) ^ 0x2BA4AD5B;
					continue;
				case 179u:
					Admit.smethod_20((Control)(object)PictureBox1, new Size(126, 122));
					num = ((int)num2 * -2031854909) ^ 0x3F53740A;
					continue;
				case 178u:
					num = ((int)num2 * -1187372439) ^ -1666663446;
					continue;
				case 177u:
					num = ((int)num2 * -842495951) ^ 0x57114B52;
					continue;
				case 176u:
					Admit.smethod_21((Control)(object)Label14, 8);
					num = ((int)num2 * -506700361) ^ 0x3EAE09EA;
					continue;
				case 175u:
					Admit.smethod_37((Control)(object)PrintBtn, bool_0: false);
					Admit.smethod_28((ButtonBase)(object)SaveBtn, Color.MidnightBlue);
					num = (int)(num2 * 1453280992) ^ -128746143;
					continue;
				case 174u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)GenderTxt);
					num = (int)(num2 * 195003130) ^ -1542850110;
					continue;
				case 173u:
					Admit.smethod_21((Control)(object)GroupBox1, 5);
					num = (int)((num2 * 29823035) ^ 0x1047C182);
					continue;
				case 172u:
					Admit.smethod_19((Control)(object)RoomNoTxt, "RoomNoTxt");
					num = (int)(num2 * 1512597633) ^ -253091048;
					continue;
				case 171u:
					num = (int)(num2 * 842656225) ^ -1529835292;
					continue;
				case 170u:
					num = ((int)num2 * -2035105659) ^ -304541210;
					continue;
				case 169u:
					Label4 = Admit.smethod_3();
					num = (int)(num2 * 883839896) ^ -1334810254;
					continue;
				case 168u:
					Admit.smethod_19((Control)(object)DateOut1Txt, "DateOut1Txt");
					num = ((int)num2 * -2143015676) ^ 0x40A275DC;
					continue;
				case 167u:
					AddressTxt = Admit.smethod_6();
					GenderTxt = Admit.smethod_6();
					num = (int)((num2 * 223586088) ^ 0x54286CED);
					continue;
				case 166u:
					Admit.smethod_38((TextBoxBase)(object)AgeTxt, bool_0: true);
					num = (int)((num2 * 1499867097) ^ 0x5C62698C);
					continue;
				case 165u:
					Admit.smethod_18((Control)(object)NameSTxt, new Point(120, 44));
					Admit.smethod_19((Control)(object)NameSTxt, "NameSTxt");
					num = ((int)num2 * -2104343939) ^ 0x17AC1C78;
					continue;
				case 164u:
					Admit.smethod_31((ButtonBase)(object)SaveBtn, bool_0: false);
					Admit.smethod_37((Control)(object)SaveBtn, bool_0: false);
					num = (int)((num2 * 1056816744) ^ 0x2EE06ACB);
					continue;
				case 163u:
					num = ((int)num2 * -990957237) ^ -1210101237;
					continue;
				case 162u:
					Admit.smethod_37((Control)(object)SearchResultGrid, bool_0: false);
					num = ((int)num2 * -1281730501) ^ 0x344680F4;
					continue;
				case 161u:
					Admit.smethod_18((Control)(object)Label6, new Point(232, 154));
					num = ((int)num2 * -1362558957) ^ 0x1C9B8A44;
					continue;
				case 160u:
					num = ((int)num2 * -450393495) ^ -280187139;
					continue;
				case 159u:
					num = (int)(num2 * 1655157022) ^ -1914706283;
					continue;
				case 158u:
					Admit.smethod_19((Control)(object)Label7, "Label7");
					num = (int)(num2 * 1775836373) ^ -595475195;
					continue;
				case 157u:
					Admit.smethod_21((Control)(object)FeesTxt, 9);
					num = ((int)num2 * -1057711751) ^ -1131616307;
					continue;
				case 156u:
					Admit.smethod_56((Control)(object)GroupBox1);
					num = (int)((num2 * 48466768) ^ 0x23F83A75);
					continue;
				case 155u:
					num = (int)(num2 * 1128139349) ^ -1582381216;
					continue;
				case 154u:
					num = ((int)num2 * -1790347076) ^ 0x51263249;
					continue;
				case 153u:
					num = (int)(num2 * 1639434155) ^ -1353648117;
					continue;
				case 152u:
					num = ((int)num2 * -1365399057) ^ 0x35DAC754;
					continue;
				case 151u:
					num = ((int)num2 * -1260730507) ^ 0x177A3F23;
					continue;
				case 150u:
					Admit.smethod_21((Control)(object)PrintBtn, 10);
					num = ((int)num2 * -582049585) ^ -926777090;
					continue;
				case 149u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)DateInTxt);
					num = (int)((num2 * 224213967) ^ 0x2635B840);
					continue;
				case 148u:
					Admit.smethod_23(Label13, (ContentAlignment)32);
					Admit.smethod_17((Control)(object)Label12, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -925885485) ^ -381880622;
					continue;
				case 147u:
					Admit.smethod_20((Control)(object)Label7, new Size(105, 26));
					num = ((int)num2 * -689838346) ^ -1936846036;
					continue;
				case 146u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)Label8);
					num = ((int)num2 * -935005603) ^ 0x18EAB8C1;
					continue;
				case 145u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)ClearBtn);
					num = ((int)num2 * -1741418312) ^ -1078393118;
					continue;
				case 144u:
					Admit.smethod_18((Control)(object)SaveBtn, new Point(814, 746));
					num = (int)(num2 * 107501456) ^ -1778242995;
					continue;
				case 143u:
					num = ((int)num2 * -185100507) ^ 0x41D11BD2;
					continue;
				case 142u:
					num = ((int)num2 * -1069335836) ^ 0x2C764C1C;
					continue;
				case 141u:
					SaveBtn = Admit.smethod_5();
					num = ((int)num2 * -1023393721) ^ -983195862;
					continue;
				case 140u:
					num = (int)((num2 * 497485914) ^ 0x4780AD01);
					continue;
				case 139u:
					Admit.smethod_20((Control)(object)DateIn1Txt, new Size(181, 28));
					num = ((int)num2 * -1897498702) ^ 0x22111F95;
					continue;
				case 138u:
					Admit.smethod_21((Control)(object)Label7, 3);
					Admit.smethod_22(Label7, "Address : ");
					num = ((int)num2 * -814361854) ^ 0x2E19B952;
					continue;
				case 137u:
					Admit.smethod_20((Control)(object)Label8, new Size(101, 25));
					num = ((int)num2 * -1822341367) ^ -61790977;
					continue;
				case 136u:
					num = ((int)num2 * -1405206474) ^ 0x2F89FB91;
					continue;
				case 135u:
					Admit.smethod_17((Control)(object)AgeTxt, Admit.smethod_16("MS Reference Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Admit.smethod_18((Control)(object)AgeTxt, new Point(96, 154));
					num = (int)(num2 * 1809491261) ^ -1862189174;
					continue;
				case 134u:
					Admit.smethod_29((Control)(object)SaveBtn, Color.White);
					num = (int)(num2 * 648729757) ^ -1997408267;
					continue;
				case 133u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)GroupBox1), (Control)(object)SearchBtn);
					num = ((int)num2 * -1248968787) ^ 0x39EA900A;
					continue;
				case 132u:
					num = ((int)num2 * -1944673266) ^ -823309385;
					continue;
				case 131u:
					num = ((int)num2 * -1475258382) ^ 0x5E18E732;
					continue;
				case 130u:
					Label8 = Admit.smethod_3();
					num = ((int)num2 * -2135861515) ^ -421446632;
					continue;
				case 129u:
					num = ((int)num2 * -1868991106) ^ -507271410;
					continue;
				case 128u:
					Admit.smethod_23(Label12, (ContentAlignment)32);
					num = ((int)num2 * -1647838406) ^ -1853221607;
					continue;
				case 127u:
					Admit.smethod_21((Control)(object)Label5, 1);
					num = (int)(num2 * 1777961201) ^ -1964590698;
					continue;
				case 126u:
					num = ((int)num2 * -1714993028) ^ 0x2E9D5A2;
					continue;
				case 125u:
					num = (int)(num2 * 1966815248) ^ -1807748987;
					continue;
				case 124u:
					num = (int)((num2 * 1942923456) ^ 0x3932933A);
					continue;
				case 123u:
					num = (int)(num2 * 1543029009) ^ -637504968;
					continue;
				case 122u:
					num = ((int)num2 * -1268254340) ^ -154255460;
					continue;
				case 121u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)GroupBox1), (Control)(object)MobileTxt);
					num = ((int)num2 * -1716089117) ^ 0x5E882FCE;
					continue;
				case 120u:
					Admit.smethod_55((Control)(object)PatientInfoBox, bool_0: false);
					num = ((int)num2 * -2073787557) ^ -1910296955;
					continue;
				case 119u:
					Admit.smethod_30((ButtonBase)(object)SearchBtn, "Search");
					num = (int)(num2 * 1064212092) ^ -1087773996;
					continue;
				case 118u:
					Admit.smethod_21((Control)(object)PatientInfoBox, 7);
					num = (int)((num2 * 929191387) ^ 0x54311D04);
					continue;
				case 117u:
					ClearBtn = Admit.smethod_5();
					num = ((int)num2 * -949352136) ^ -36924493;
					continue;
				case 116u:
					Admit.smethod_27(AdmitDetailsBox, "Admit Details");
					num = (int)(num2 * 1742064309) ^ -1952975829;
					continue;
				case 115u:
					Admit.smethod_43(Admit.smethod_42(RoomTypeTxt), new object[3] { "General", "V.I.P.", "ICU" });
					num = (int)((num2 * 1037664247) ^ 0x59378252);
					continue;
				case 114u:
					Admit.smethod_19((Control)(object)PrintBtn, "PrintBtn");
					num = ((int)num2 * -781388408) ^ -1965770700;
					continue;
				case 113u:
					Admit.smethod_18((Control)(object)Label7, new Point(13, 198));
					num = ((int)num2 * -888317168) ^ 0x7272BF2B;
					continue;
				case 112u:
					num = (int)(num2 * 1342708127) ^ -585926069;
					continue;
				case 111u:
					AdmitDetailsBox = Admit.smethod_4();
					RoomNoTxt = Admit.smethod_8();
					num = ((int)num2 * -2076231854) ^ 0x346D04DE;
					continue;
				case 110u:
					Admit.smethod_26(GroupBox1, bool_0: false);
					num = (int)(num2 * 1546104777) ^ -1239017502;
					continue;
				case 109u:
					Admit.smethod_19((Control)(object)Label11, "Label11");
					num = ((int)num2 * -514109976) ^ 0x53813411;
					continue;
				case 108u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)SaveBtn);
					num = ((int)num2 * -26499492) ^ 0x47033B31;
					continue;
				case 107u:
					Label10 = Admit.smethod_3();
					num = ((int)num2 * -22986760) ^ -449325802;
					continue;
				case 106u:
					num = ((int)num2 * -1700231451) ^ 0x7A6370D0;
					continue;
				case 105u:
					num = ((int)num2 * -413604347) ^ -937803085;
					continue;
				case 104u:
					num = (int)(num2 * 1610351068) ^ -257314943;
					continue;
				case 103u:
					num = ((int)num2 * -358430596) ^ 0x155E933B;
					continue;
				case 102u:
					Admit.smethod_21((Control)(object)Label1, 3);
					num = (int)(num2 * 318802912) ^ -814533205;
					continue;
				case 101u:
					SearchResultGrid = Admit.smethod_7();
					num = (int)(num2 * 2039910693) ^ -1517716311;
					continue;
				case 100u:
					Admit.smethod_19((Control)(object)AgeTxt, "AgeTxt");
					num = (int)(num2 * 1891289564) ^ -1766325977;
					continue;
				case 99u:
					num = ((int)num2 * -1337124252) ^ -989685745;
					continue;
				case 98u:
					num = (int)(num2 * 1352920302) ^ -503123041;
					continue;
				case 97u:
					num = ((int)num2 * -1043783814) ^ 0x5A9C0B9D;
					continue;
				case 96u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)AgeTxt);
					num = (int)(num2 * 1132840022) ^ -1617428144;
					continue;
				case 95u:
					Admit.smethod_20((Control)(object)PrintBtn, new Size(101, 37));
					num = (int)(num2 * 463699481) ^ -1196877507;
					continue;
				case 94u:
					Admit.smethod_18((Control)(object)Label2, new Point(37, 44));
					Admit.smethod_19((Control)(object)Label2, "Label2");
					num = (int)((num2 * 435022721) ^ 0x64445CA9);
					continue;
				case 93u:
					Admit.smethod_21((Control)(object)Label2, 0);
					Admit.smethod_22(Label2, "Name : ");
					num = ((int)num2 * -1918714001) ^ 0x583926B5;
					continue;
				case 92u:
					Admit.smethod_18((Control)(object)Label15, new Point(13, 116));
					Admit.smethod_19((Control)(object)Label15, "Label15");
					num = ((int)num2 * -1492773767) ^ -225802514;
					continue;
				case 91u:
					num = (int)((num2 * 220940198) ^ 0x69111C80);
					continue;
				case 90u:
					Admit.smethod_18((Control)(object)PatientInfoBox, new Point(59, 485));
					num = ((int)num2 * -2042447197) ^ -1972513173;
					continue;
				case 89u:
					Admit.smethod_18((Control)(object)Label5, new Point(13, 154));
					num = ((int)num2 * -365207261) ^ 0x387CB675;
					continue;
				case 88u:
					NameTxt = Admit.smethod_6();
					num = (int)((num2 * 1724339936) ^ 0x368A6ADF);
					continue;
				case 87u:
					Admit.smethod_18((Control)(object)PIDTxt, new Point(96, 43));
					num = ((int)num2 * -113302189) ^ -1532650491;
					continue;
				case 86u:
					RoomTypeTxt = Admit.smethod_8();
					DateOutTxt = Admit.smethod_8();
					DateInTxt = Admit.smethod_8();
					num = (int)(num2 * 89289528) ^ -239315509;
					continue;
				case 85u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)Label15);
					num = (int)(num2 * 572485213) ^ -1051369978;
					continue;
				case 84u:
					num = ((int)num2 * -183002610) ^ -1350438906;
					continue;
				case 83u:
					num = ((int)num2 * -374123681) ^ -262201128;
					continue;
				case 82u:
					Admit.smethod_20((Control)(object)Label12, new Size(101, 28));
					num = ((int)num2 * -353107180) ^ 0x6E2CFE54;
					continue;
				case 81u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)Label11);
					num = (int)(num2 * 955602203) ^ -1414324378;
					continue;
				case 80u:
					Admit.smethod_19((Control)(object)DateInTxt, "DateInTxt");
					num = (int)((num2 * 1969684024) ^ 0x6BAA032D);
					continue;
				case 79u:
					Label2 = Admit.smethod_3();
					num = ((int)num2 * -1368061157) ^ 0x107F06BB;
					continue;
				case 78u:
					num = ((int)num2 * -722680368) ^ -1276728907;
					continue;
				case 77u:
					Admit.smethod_19((Control)(object)GenderTxt, "GenderTxt");
					num = (int)(num2 * 2107585596) ^ -1284044619;
					continue;
				case 76u:
					Admit.smethod_20((Control)(object)Label9, new Size(122, 28));
					Admit.smethod_21((Control)(object)Label9, 2);
					num = ((int)num2 * -370177028) ^ -295908137;
					continue;
				case 75u:
					num = ((int)num2 * -162632985) ^ -323079305;
					continue;
				case 74u:
					num = (int)((num2 * 1852816297) ^ 0x732E6CE3);
					continue;
				case 73u:
					Admit.smethod_21((Control)(object)RoomNo1Txt, 20);
					num = ((int)num2 * -2101166598) ^ 0x228C7F29;
					continue;
				case 72u:
					num = (int)((num2 * 287454861) ^ 0x25D0EB46);
					continue;
				case 71u:
					num = ((int)num2 * -750784363) ^ 0x53912ED2;
					continue;
				case 70u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)PictureBox1);
					num = ((int)num2 * -95756839) ^ -1717625316;
					continue;
				case 69u:
					num = (int)((num2 * 446439911) ^ 0x6116DCDF);
					continue;
				case 68u:
					Admit.smethod_20((Control)(object)RoomType1Txt, new Size(181, 28));
					num = (int)(num2 * 772380571) ^ -92770863;
					continue;
				case 67u:
					Admit.smethod_40(RoomTypeTxt, (ComboBoxStyle)2);
					num = (int)(num2 * 26797522) ^ -120621706;
					continue;
				case 66u:
					Admit.smethod_21((Control)(object)DateOut1Txt, 14);
					num = ((int)num2 * -517552428) ^ 0x1DBAC3CB;
					continue;
				case 65u:
					num = (int)((num2 * 1658112534) ^ 0x7CF05ADB);
					continue;
				case 64u:
					Admit.smethod_21((Control)(object)Label15, 10);
					num = ((int)num2 * -1033140905) ^ 0x259B8790;
					continue;
				case 63u:
					num = (int)(num2 * 2141118698) ^ -884640917;
					continue;
				case 62u:
					HistoryBtn = Admit.smethod_5();
					num = (int)(num2 * 870161812) ^ -1902651118;
					continue;
				case 61u:
					Label6 = Admit.smethod_3();
					num = (int)(num2 * 718692660) ^ -1245276677;
					continue;
				case 60u:
					Admit.smethod_20((Control)(object)AdmitDetailsBox, new Size(408, 255));
					num = ((int)num2 * -338538507) ^ -647653086;
					continue;
				case 59u:
					FeesTxt = Admit.smethod_6();
					num = (int)((num2 * 540004013) ^ 0x3C1E0B2A);
					continue;
				case 58u:
					num = (int)((num2 * 327848843) ^ 0x32057D3D);
					continue;
				case 57u:
					NameSTxt = Admit.smethod_6();
					num = (int)(num2 * 1772272185) ^ -1186442172;
					continue;
				case 56u:
					Admit.smethod_19((Control)(object)StatusTxt, "StatusTxt");
					num = ((int)num2 * -17417637) ^ -1014020247;
					continue;
				case 55u:
					num = ((int)num2 * -1325989989) ^ -93925295;
					continue;
				case 54u:
					Admit.smethod_17((Control)(object)SaveBtn, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1828805932) ^ -1685021477;
					continue;
				case 53u:
					Admit.smethod_44(PrintDialog1, bool_0: true);
					num = (int)((num2 * 1823547545) ^ 0x38A58740);
					continue;
				case 52u:
					num = (int)((num2 * 1831808552) ^ 0x3FF6AC56);
					continue;
				case 51u:
					Admit.smethod_19((Control)(object)SaveBtn, "SaveBtn");
					num = (int)(num2 * 1472907191) ^ -248471262;
					continue;
				case 50u:
					Admit.smethod_56((Control)(object)PatientInfoBox);
					num = (int)(num2 * 1745075748) ^ -412687328;
					continue;
				case 49u:
					Admit.smethod_18((Control)(object)SearchBtn, new Point(468, 82));
					num = ((int)num2 * -1404154980) ^ -1008966104;
					continue;
				case 48u:
					num = (int)(num2 * 1342516844) ^ -1568140666;
					continue;
				case 47u:
					Admit.smethod_18((Control)(object)Label14, new Point(13, 80));
					num = ((int)num2 * -1025362793) ^ 0x1A94B813;
					continue;
				case 46u:
					num = ((int)num2 * -1447737666) ^ -2121308487;
					continue;
				case 45u:
					Admit.smethod_19((Control)(object)FeesTxt, "FeesTxt");
					Admit.smethod_20((Control)(object)FeesTxt, new Size(86, 28));
					num = ((int)num2 * -1892445878) ^ 0x1A5CA2ED;
					continue;
				case 44u:
					MobileSTxt = Admit.smethod_6();
					num = ((int)num2 * -1526427685) ^ 0x4E3E5737;
					continue;
				case 43u:
					Admit.smethod_17((Control)(object)RoomNoTxt, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -497576398) ^ 0x2CCD6F94;
					continue;
				case 42u:
					Admit.smethod_40(DateInTxt, (ComboBoxStyle)2);
					num = ((int)num2 * -749698831) ^ 0x6B0F2C69;
					continue;
				case 41u:
					Admit.smethod_23(Label3, (ContentAlignment)32);
					num = ((int)num2 * -1033593857) ^ -322874762;
					continue;
				case 40u:
					Admit.smethod_17((Control)(object)AdmitDetailsBox, Admit.smethod_16("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Admit.smethod_18((Control)(object)AdmitDetailsBox, new Point(504, 485));
					num = ((int)num2 * -1730430623) ^ -1619481096;
					continue;
				case 39u:
					num = (int)(num2 * 517695844) ^ -656489661;
					continue;
				case 38u:
					num = ((int)num2 * -1119551721) ^ 0x7F7144D0;
					continue;
				case 37u:
					Admit.smethod_23(Label8, (ContentAlignment)32);
					num = ((int)num2 * -36919584) ^ 0x104B59CC;
					continue;
				case 36u:
					num = (int)(num2 * 759440518) ^ -1036163518;
					continue;
				case 35u:
					Admit.smethod_23(Label2, (ContentAlignment)32);
					num = (int)((num2 * 881196245) ^ 0x53532C4E);
					continue;
				case 34u:
					Admit.smethod_41((ListControl)(object)StatusTxt, bool_0: true);
					Admit.smethod_43(Admit.smethod_42(StatusTxt), new object[2] { "Paid", "Not Paid" });
					num = (int)((num2 * 2010576668) ^ 0x2733E246);
					continue;
				case 33u:
					Admit.smethod_12((Control)(object)PatientInfoBox);
					num = ((int)num2 * -2114630359) ^ -1103990783;
					continue;
				case 32u:
					num = ((int)num2 * -938804647) ^ 0x4D7197B2;
					continue;
				case 31u:
					Admit.smethod_19((Control)(object)PatientInfoBox, "PatientInfoBox");
					num = (int)(num2 * 258148422) ^ -639182688;
					continue;
				case 30u:
					Admit.smethod_19((Control)(object)Label9, "Label9");
					num = (int)(num2 * 326430438) ^ -1923111067;
					continue;
				case 29u:
					num = ((int)num2 * -1842503989) ^ -527781317;
					continue;
				case 28u:
					num = (int)((num2 * 812878069) ^ 0x6A5221FF);
					continue;
				case 27u:
					num = ((int)num2 * -69534674) ^ -1552317260;
					continue;
				case 26u:
					Admit.smethod_21((Control)(object)AdmitDischargeBtn, 19);
					num = ((int)num2 * -99077308) ^ -798071151;
					continue;
				case 25u:
					Admit.smethod_37((Control)(object)RoomType1Txt, bool_0: false);
					num = (int)(num2 * 740842830) ^ -35490071;
					continue;
				case 24u:
					num = (int)((num2 * 1454154131) ^ 0x3332692);
					continue;
				case 23u:
					Admit.smethod_19((Control)(object)PictureBox1, "PictureBox1");
					num = ((int)num2 * -1283895215) ^ 0x4D09CD03;
					continue;
				case 22u:
					Admit.smethod_21((Control)(object)Label4, 0);
					Admit.smethod_22(Label4, "PID :");
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)RoomNo1Txt);
					num = ((int)num2 * -427660269) ^ 0x318F943E;
					continue;
				case 21u:
					Admit.smethod_20((Control)(object)DateOutTxt, new Size(181, 27));
					Admit.smethod_21((Control)(object)DateOutTxt, 17);
					num = ((int)num2 * -1286813552) ^ -200999166;
					continue;
				case 20u:
					Admit.smethod_31((ButtonBase)(object)SearchBtn, bool_0: false);
					num = (int)(num2 * 179649478) ^ -859336687;
					continue;
				case 19u:
					num = (int)(num2 * 1735863879) ^ -1832536031;
					continue;
				case 18u:
					Admit.smethod_20((Control)(object)Label6, new Size(84, 26));
					Admit.smethod_21((Control)(object)Label6, 2);
					num = ((int)num2 * -1869044691) ^ -1194312741;
					continue;
				case 17u:
					num = (int)((num2 * 335743747) ^ 0x2DF6053B);
					continue;
				case 16u:
					Admit.smethod_51((Control)(object)this, Color.White);
					num = ((int)num2 * -1959354983) ^ -836452217;
					continue;
				case 15u:
					num = ((int)num2 * -377769852) ^ 0x3A293C56;
					continue;
				case 14u:
					Admit.smethod_19((Control)(object)DateOutTxt, "DateOutTxt");
					num = (int)((num2 * 1530429784) ^ 0x29B5059C);
					continue;
				case 13u:
					Admit.smethod_22(Label11, "Status:");
					num = ((int)num2 * -496743770) ^ -1421703416;
					continue;
				case 12u:
					num = ((int)num2 * -1922038307) ^ 0x54DB7D82;
					continue;
				case 11u:
					num = ((int)num2 * -142185739) ^ 0x22DE3A14;
					continue;
				case 10u:
					num = ((int)num2 * -893839815) ^ -715580276;
					continue;
				case 9u:
					Admit.smethod_18((Control)(object)GroupBox1, new Point(155, 150));
					num = ((int)num2 * -1190222358) ^ -734291777;
					continue;
				case 8u:
					num = ((int)num2 * -186698083) ^ 0x57478A15;
					continue;
				case 7u:
					num = ((int)num2 * -1505432586) ^ 0x3E93B02C;
					continue;
				case 6u:
					Admit.smethod_18((Control)(object)HistoryBtn, new Point(784, 163));
					num = (int)((num2 * 620914765) ^ 0x4382F746);
					continue;
				case 5u:
					num = ((int)num2 * -588857415) ^ 0x3B99043E;
					continue;
				case 4u:
					Admit.smethod_17((Control)(object)PatientInfoBox, Admit.smethod_16("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 253696699) ^ -1612006421;
					continue;
				case 3u:
					num = ((int)num2 * -65518544) ^ -946442713;
					continue;
				case 2u:
					num = (int)(num2 * 608751416) ^ -760135161;
					continue;
				case 1u:
					Admit.smethod_26(AdmitDetailsBox, bool_0: false);
					num = (int)((num2 * 147168775) ^ 0x6D253A9);
					continue;
				case 0u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)GroupBox1), (Control)(object)NameSTxt);
					num = (int)(num2 * 1597201948) ^ -1580208474;
					continue;
				case 394u:
					break;
				default:
					Admit.smethod_59((Control)(object)this);
					return;
				}
				break;
			}
		}
	}

	private void Admit_Load(object sender, EventArgs e)
	{
		Admit.smethod_67(myconnection, Admit.smethod_66(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
		while (true)
		{
			int num = -1505439977;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBB38F6AAu) % 6u)
				{
				case 4u:
					Admit.smethod_70(Admit.smethod_42(DateOutTxt), (object)Admit.smethod_68());
					Admit.smethod_71(Admit.smethod_42(RoomNoTxt));
					num = ((int)num2 * -2074972990) ^ -469817897;
					continue;
				case 3u:
					num = ((int)num2 * -1282051478) ^ -1027451352;
					continue;
				case 1u:
					Add_Rooms();
					num = (int)(num2 * 112376192) ^ -949543562;
					continue;
				case 0u:
					HideItemsOnForm();
					Admit.smethod_70(Admit.smethod_42(DateInTxt), (object)Admit.smethod_69((object)Admit.smethod_68(), "dd-MM-yyyy"));
					num = ((int)num2 * -2128484370) ^ -1212063652;
					continue;
				default:
					return;
				case 5u:
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
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected I4, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected I4, but got Unknown
		//IL_02ed: Incompatible stack heights: 0 vs 1
		//IL_0308: Incompatible stack heights: 0 vs 1
		//IL_030f: Incompatible stack heights: 0 vs 1
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		string string_ = default(string);
		DataTable dataTable = default(DataTable);
		bool flag = default(bool);
		while (true)
		{
			int num = -691065759;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBAF7642Fu) % 10u)
				{
				case 8u:
					num = -1304777472;
					continue;
				case 7u:
					string_ = Admit.smethod_76(new string[5]
					{
						"Select * From [Patient] Where [Name] Like '%",
						Admit.smethod_73(Admit.smethod_72(NameSTxt)),
						"%' And [Mobile] Like '%",
						Admit.smethod_72(MobileTxt),
						"%';"
					});
					dataTable = Admit.smethod_77();
					num = ((int)num2 * -366780767) ^ 0x7442F713;
					continue;
				case 6u:
					flag = !MyProject.Forms.Form1.Name_Validation(Admit.smethod_73(Admit.smethod_72(NameSTxt))) | !MyProject.Forms.Form1.Mobile_Validator(Admit.smethod_73(Admit.smethod_72(MobileTxt)));
					num = ((int)num2 * -700228626) ^ 0x4C8857BD;
					continue;
				case 5u:
					Admit.smethod_78(myconnection);
					num = (int)(num2 * 1775843379) ^ -1826692312;
					continue;
				case 4u:
					HideItemsOnForm();
					num = (int)((num2 * 1102184637) ^ 0x53B59431);
					continue;
				case 1u:
					Admit.smethod_75();
					num = ((int)num2 * -448953973) ^ -2132635285;
					continue;
				case 0u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = 673200088;
						num7 = 673200088;
					}
					else
					{
						num6 = 119097931;
						num7 = 119097931;
					}
					num = num6 ^ ((int)num2 * -1721861132);
					continue;
				}
				case 3u:
					break;
				default:
					try
					{
						while (true)
						{
							int num3 = -87003428;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xBAF7642Fu) % 11u)
								{
								case 10u:
									Admit.smethod_37((Control)(object)SearchResultGrid, bool_0: true);
									num3 = ((int)num2 * -1828325310) ^ 0x45610623;
									continue;
								case 9u:
								{
									OleDbDataAdapter dbDataAdapter_ = Admit.smethod_79(string_, myconnection);
									Admit.smethod_80((DbDataAdapter)(object)dbDataAdapter_, dataTable);
									Admit.smethod_81(SearchResultGrid, (object)dataTable);
									num3 = ((int)num2 * -1999447693) ^ 0x19C3EFF0;
									continue;
								}
								case 7u:
								{
									int num4;
									int num5;
									if (Admit.smethod_82(SearchResultGrid) != 1)
									{
										num4 = -245466571;
										num5 = -245466571;
									}
									else
									{
										num4 = -356870129;
										num5 = -356870129;
									}
									num3 = num4 ^ ((int)num2 * -587720044);
									continue;
								}
								case 4u:
									num3 = (int)((num2 * 12641405) ^ 0x320E7826);
									continue;
								case 3u:
									Admit.smethod_83(myconnection);
									num3 = ((int)num2 * -734165569) ^ -1005789592;
									continue;
								case 2u:
									num3 = ((int)num2 * -1965095712) ^ -1501685714;
									continue;
								case 1u:
									Admit.smethod_74("No Result Found");
									num3 = (int)((num2 * 1865771805) ^ 0x33E9867);
									continue;
								case 0u:
									num3 = -1588590874;
									continue;
								case 8u:
									break;
								case 5u:
									return;
								default:
									Admit.smethod_83(myconnection);
									return;
								}
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						Admit.smethod_84(exception_);
						while (true)
						{
							_ = -1152550458;
							while (true)
							{
								_003F val = /*Error near IL_02be: Stack underflow*/^ -1158192081;
								num2 = (uint)(int)val;
								switch (val % 4)
								{
								default:
									return;
								case 3:
									Admit.smethod_85();
									_ = ((int)num2 * -2008863302) ^ -1886291413;
									continue;
								case 1:
									Admit.smethod_83(myconnection);
									_ = (num2 * 538613272) ^ 0xC31108E0u;
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
				case 9u:
					Admit.smethod_74("No Results Found");
					return;
				}
				break;
			}
		}
	}

	private void SaveBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -657143300;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB1E1A4DFu) % 6u)
				{
				case 5u:
				{
					int num3;
					int num4;
					if (Validate_Print_Data())
					{
						num3 = 1173578490;
						num4 = 1173578490;
					}
					else
					{
						num3 = 1011756149;
						num4 = 1011756149;
					}
					num = num3 ^ (int)(num2 * 491933185);
					continue;
				}
				case 4u:
					Admit.smethod_75();
					performQueryStatement();
					num = ((int)num2 * -1957614631) ^ 0xC239964;
					continue;
				case 2u:
					num = -876521969;
					continue;
				case 1u:
					num = (int)(num2 * 107641183) ^ -1780699165;
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
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
			int num = -311353030;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE00810FBu) % 12u)
				{
				case 11u:
					Admit.smethod_37((Control)(object)PatientInfoBox, bool_0: false);
					num = (int)(num2 * 1602583979) ^ -1118217624;
					continue;
				case 10u:
					Admit.smethod_37((Control)(object)ClearBtn, bool_0: false);
					Admit.smethod_37((Control)(object)PrintBtn, bool_0: false);
					num = ((int)num2 * -1792004555) ^ 0x2FC8DFC1;
					continue;
				case 9u:
					num = ((int)num2 * -792011697) ^ 0x414CBA84;
					continue;
				case 7u:
					num = ((int)num2 * -817321125) ^ 0x214147C8;
					continue;
				case 6u:
					result = true;
					num = (int)(num2 * 1647127946) ^ -1208564384;
					continue;
				case 5u:
					num = ((int)num2 * -885577530) ^ -1646273677;
					continue;
				case 4u:
					Admit.smethod_37((Control)(object)SaveBtn, bool_0: false);
					num = ((int)num2 * -59878642) ^ -107151326;
					continue;
				case 3u:
					Admit.smethod_37((Control)(object)AdmitDischargeBtn, bool_0: false);
					num = ((int)num2 * -1440533872) ^ 0x2EA1082E;
					continue;
				case 1u:
					Admit.smethod_37((Control)(object)SearchResultGrid, bool_0: false);
					Admit.smethod_37((Control)(object)AdmitDetailsBox, bool_0: false);
					num = ((int)num2 * -907679412) ^ -796227528;
					continue;
				case 0u:
					Admit.smethod_37((Control)(object)HistoryBtn, bool_0: false);
					num = ((int)num2 * -1125679187) ^ -556604308;
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

	private string performQueryStatement()
	{
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected I4, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected I4, but got Unknown
		//IL_02be: Incompatible stack heights: 0 vs 1
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Incompatible stack heights: 0 vs 1
		//IL_02e5: Incompatible stack heights: 0 vs 1
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected I4, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected I4, but got Unknown
		//IL_04cd: Incompatible stack heights: 0 vs 1
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Incompatible stack heights: 0 vs 1
		//IL_0502: Incompatible stack heights: 0 vs 1
		//IL_0509: Incompatible stack heights: 0 vs 1
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0682: Expected I4, but got Unknown
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_069d: Expected I4, but got Unknown
		//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Incompatible stack heights: 0 vs 1
		//IL_06d2: Incompatible stack heights: 0 vs 1
		//IL_06ed: Incompatible stack heights: 0 vs 1
		//IL_06f4: Incompatible stack heights: 0 vs 1
		OleDbCommand val = Admit.smethod_75();
		bool flag = default(bool);
		string text = default(string);
		string result = default(string);
		DateTime dateTime_ = default(DateTime);
		while (true)
		{
			int num = 1474141823;
			while (true)
			{
				int num4;
				int num5;
				int num6;
				uint num2;
				switch ((num2 = (uint)num ^ 0x13A402B5u) % 5u)
				{
				case 3u:
					if (flag)
					{
						num = (int)((num2 * 524789626) ^ 0x3E1A5A4E);
						continue;
					}
					goto IL_02f1;
				case 2u:
					dateTime_ = Admit.smethod_86(Admit.smethod_69((object)DateTime.Now, "dd-MM-yyyy"));
					num = (int)(num2 * 2097234058) ^ -417485735;
					continue;
				case 1u:
					flag = Admit.smethod_87(Admit.smethod_72(DateIn1Txt), "", bool_0: false) == 0;
					num = ((int)num2 * -458972229) ^ 0x486C06C3;
					continue;
				case 4u:
					break;
				default:
					{
						text = "Insert Into [Admit-Discharge] ([DateIn],[PID],[Fee Status],[Room No],[Room type]) Values (?,?,?,?,?);";
						Admit.smethod_78(myconnection);
						try
						{
							while (true)
							{
								IL_026e:
								int num3 = 1673595227;
								while (true)
								{
									switch ((num2 = (uint)num3 ^ 0x13A402B5u) % 9u)
									{
									case 8u:
										Admit.smethod_83(myconnection);
										num3 = ((int)num2 * -753753574) ^ -1233015345;
										continue;
									case 7u:
										Admit.smethod_92(Admit.smethod_89(val), Admit.smethod_91("DateIn", (object)Admit.smethod_90(dateTime_)));
										Admit.smethod_92(Admit.smethod_89(val), Admit.smethod_91("PID", (object)Admit.smethod_93(Admit.smethod_72(PIDTxt))));
										num3 = ((int)num2 * -849035986) ^ -526384604;
										continue;
									case 6u:
										Admit.smethod_92(Admit.smethod_89(val), Admit.smethod_91("Room No", (object)Admit.smethod_93(Admit.smethod_94(RoomNoTxt))));
										Admit.smethod_92(Admit.smethod_89(val), Admit.smethod_91("Room Type", (object)Admit.smethod_95(Admit.smethod_94(RoomTypeTxt))));
										Admit.smethod_96(val);
										Admit.smethod_97((Component)(object)val);
										num3 = (int)((num2 * 131154656) ^ 0x24D158F5);
										continue;
									case 4u:
										Admit.smethod_92(Admit.smethod_89(val), Admit.smethod_91("Fee Status", (object)Admit.smethod_94(StatusTxt)));
										num3 = ((int)num2 * -1891444102) ^ -56346553;
										continue;
									case 3u:
										val = Admit.smethod_88(text, myconnection);
										num3 = (int)((num2 * 1594066921) ^ 0x77580A2B);
										continue;
									case 1u:
										Admit.smethod_74("Successfully Updated Details");
										Update_Rooms(Admit.smethod_94(RoomNoTxt), "No");
										num3 = ((int)num2 * -1713516300) ^ -1518094160;
										continue;
									case 0u:
										UpdateTable();
										num3 = ((int)num2 * -382022897) ^ 0x6D3614A8;
										continue;
									default:
										goto end_IL_0237;
									case 5u:
										break;
									case 2u:
										goto end_IL_0237;
									}
									goto IL_026e;
									continue;
									end_IL_0237:
									break;
								}
								break;
							}
						}
						catch (Exception exception_)
						{
							Admit.smethod_84(exception_);
							while (true)
							{
								IL_02e0:
								_ = 833753354;
								while (true)
								{
									_003F val2 = /*Error near IL_0289: Stack underflow*/^ 0x13A402B5;
									num2 = (uint)(int)val2;
									switch (val2 % 4)
									{
									case 3:
										Admit.smethod_83(myconnection);
										_ = ((int)num2 * -1770286727) ^ 0x26BFA370;
										continue;
									case 2:
										Admit.smethod_98("Cannot proceed with the request!", "INVALID REQUEST");
										_ = ((int)num2 * -295869961) ^ -765476186;
										continue;
									case 0:
										break;
									default:
										Admit.smethod_85();
										goto end_IL_0283;
									}
									goto IL_02e0;
									continue;
									end_IL_0283:
									break;
								}
								break;
							}
						}
						goto IL_03f2;
					}
					IL_072f:
					result = text;
					num4 = 762649347;
					goto IL_06fd;
					IL_02f1:
					if ((Admit.smethod_87(Admit.smethod_72(DateIn1Txt), "", bool_0: false) != 0) & (Admit.smethod_87(Admit.smethod_72(DateOut1Txt), "", bool_0: false) == 0))
					{
						num5 = 2124080928;
						goto IL_032e;
					}
					goto IL_0510;
					IL_05e0:
					num6 = 1803691168;
					goto IL_0515;
					IL_032e:
					while (true)
					{
						switch ((num2 = (uint)num5 ^ 0x13A402B5u) % 6u)
						{
						case 5u:
							break;
						case 3u:
							dateTime_ = Admit.smethod_86(Admit.smethod_69((object)DateTime.Today, "MM-dd-yyyy"));
							text = Admit.smethod_76(new string[7]
							{
								"Update [Admit-Discharge] Set [DateOut] = #",
								Admit.smethod_90(dateTime_),
								"#, [Fee Status] = '",
								Admit.smethod_94(StatusTxt),
								"' Where [ID] = ",
								id,
								" ;"
							});
							num5 = (int)((num2 * 1074655901) ^ 0x1A615886);
							continue;
						case 0u:
							Admit.smethod_78(myconnection);
							num5 = ((int)num2 * -748096793) ^ -387500825;
							continue;
						case 4u:
							goto IL_03f2;
						default:
							goto IL_03fc;
						case 1u:
							goto IL_072f;
						}
						break;
					}
					goto IL_02f1;
					IL_03fc:
					try
					{
						val = Admit.smethod_88(text, myconnection);
						while (true)
						{
							IL_0472:
							int num7 = 212542578;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0x13A402B5u) % 3u)
								{
								case 1u:
									goto IL_040c;
								case 0u:
									break;
								default:
									UpdateTable();
									goto end_IL_0454;
								}
								goto IL_0472;
								IL_040c:
								Admit.smethod_96(val);
								Admit.smethod_97((Component)(object)val);
								Admit.smethod_83(myconnection);
								Admit.smethod_74("Successfully Updated Details");
								Update_Rooms(Admit.smethod_72(RoomNo1Txt), "Yes");
								num7 = (int)(num2 * 77679879) ^ -1001682345;
								continue;
								end_IL_0454:
								break;
							}
							break;
						}
					}
					catch (Exception exception_2)
					{
						Admit.smethod_84(exception_2);
						while (true)
						{
							IL_0504:
							_ = 150633730;
							while (true)
							{
								_003F val3 = /*Error near IL_0494: Stack underflow*/^ 0x13A402B5;
								num2 = (uint)(int)val3;
								switch (val3 % 5)
								{
								default:
									goto end_IL_048e;
								case 4:
									Admit.smethod_83(myconnection);
									_ = ((int)num2 * -676599991) ^ -925818772;
									continue;
								case 3:
									Admit.smethod_98("Cannot proceed with the request!", "INVALID REQUEST");
									Admit.smethod_85();
									_ = (num2 * 521732206) ^ 0x7D38EC96;
									continue;
								case 1:
									_ = (num2 * 888338036) ^ 0x4686FB94;
									continue;
								case 2:
									break;
								case 0:
									goto end_IL_048e;
								}
								goto IL_0504;
								continue;
								end_IL_048e:
								break;
							}
							break;
						}
					}
					goto IL_05e0;
					IL_03f2:
					num5 = 1747387042;
					goto IL_032e;
					IL_0510:
					num6 = 1934361452;
					goto IL_0515;
					IL_0515:
					while (true)
					{
						switch ((num2 = (uint)num6 ^ 0x13A402B5u) % 6u)
						{
						case 4u:
							break;
						case 3u:
							text = Admit.smethod_76(new string[9]
							{
								"Update [Admit-Discharge] Set [Room No] = ",
								Admit.smethod_94(RoomNoTxt),
								", [Room Type] = '",
								Admit.smethod_94(RoomTypeTxt),
								"', [Fee Status] = '",
								Admit.smethod_94(StatusTxt),
								"' Where [PID] = ",
								Admit.smethod_72(PIDTxt),
								";"
							});
							Admit.smethod_78(myconnection);
							num6 = (int)(num2 * 474865773) ^ -692016389;
							continue;
						case 1u:
							num6 = (int)((num2 * 147218359) ^ 0x106CFACC);
							continue;
						case 2u:
							goto IL_05e0;
						default:
							goto IL_05ea;
						case 0u:
							goto IL_072f;
						}
						break;
					}
					goto IL_0510;
					IL_05ea:
					try
					{
						val = Admit.smethod_88(text, myconnection);
						while (true)
						{
							IL_0652:
							int num8 = 484831792;
							while (true)
							{
								switch ((num2 = (uint)num8 ^ 0x13A402B5u) % 4u)
								{
								case 2u:
									Admit.smethod_83(myconnection);
									num8 = (int)((num2 * 1668790685) ^ 0x799ABDEB);
									continue;
								case 1u:
									Admit.smethod_96(val);
									Admit.smethod_97((Component)(object)val);
									num8 = (int)((num2 * 951991952) ^ 0x725DFC73);
									continue;
								case 3u:
									break;
								default:
									Admit.smethod_74("Successfully Updated Details");
									UpdateTable();
									goto end_IL_0630;
								}
								goto IL_0652;
								continue;
								end_IL_0630:
								break;
							}
							break;
						}
					}
					catch (Exception exception_3)
					{
						Admit.smethod_84(exception_3);
						while (true)
						{
							IL_06ef:
							_ = 517289480;
							while (true)
							{
								_003F val4 = /*Error near IL_067f: Stack underflow*/^ 0x13A402B5;
								num2 = (uint)(int)val4;
								switch (val4 % 5)
								{
								default:
									goto end_IL_0679;
								case 4:
									Admit.smethod_98("Cannot proceed with the request!", "INVALID REQUEST");
									Admit.smethod_85();
									_ = (num2 * 1119918822) ^ 0xE062BC8;
									continue;
								case 2:
									_ = (num2 * 1154768774) ^ 0xD69A473Au;
									continue;
								case 1:
									Admit.smethod_83(myconnection);
									_ = ((int)num2 * -894635676) ^ 0x5D696702;
									continue;
								case 3:
									break;
								case 0:
									goto end_IL_0679;
								}
								goto IL_06ef;
								continue;
								end_IL_0679:
								break;
							}
							break;
						}
					}
					goto IL_06f8;
					IL_06f8:
					num4 = 96183066;
					goto IL_06fd;
					IL_06fd:
					while (true)
					{
						switch ((num2 = (uint)num4 ^ 0x13A402B5u) % 4u)
						{
						case 0u:
							break;
						case 3u:
							num4 = (int)((num2 * 705135639) ^ 0x3589ED65);
							continue;
						case 1u:
							goto IL_072f;
						default:
							return result;
						}
						break;
					}
					goto IL_06f8;
				}
				break;
			}
		}
	}

	private void SearchResultGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected I4, but got Unknown
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected I4, but got Unknown
		//IL_0488: Incompatible stack heights: 0 vs 1
		//IL_048f: Incompatible stack heights: 0 vs 1
		try
		{
			while (true)
			{
				int num = -1365661769;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEDFD1E78u) % 28u)
					{
					case 27u:
						num = (int)((num2 * 1498046375) ^ 0x621A14BB);
						continue;
					case 26u:
						Admit.smethod_37((Control)(object)SaveBtn, bool_0: false);
						num = ((int)num2 * -563731149) ^ -653225470;
						continue;
					case 25u:
						num = (int)((num2 * 1913272759) ^ 0x2C80811A);
						continue;
					case 24u:
						Admit.smethod_107(DateInTxt, -1);
						num = (int)((num2 * 514376429) ^ 0x37AEDC);
						continue;
					case 23u:
						Admit.smethod_106(GenderTxt, Admit.smethod_105(Admit.smethod_104(Admit.smethod_103(Admit.smethod_102(Admit.smethod_101(Admit.smethod_99(SearchResultGrid), Admit.smethod_100(e))), 3))));
						num = ((int)num2 * -1916018589) ^ 0x1CDCC1F;
						continue;
					case 22u:
						num = (int)((num2 * 308627790) ^ 0x32291B1C);
						continue;
					case 21u:
						Admit.smethod_108((TextBoxBase)(object)DateIn1Txt);
						num = (int)((num2 * 554283696) ^ 0x79DF8E81);
						continue;
					case 20u:
						num = (int)(num2 * 479086389) ^ -393190641;
						continue;
					case 19u:
						Admit.smethod_106(AgeTxt, Admit.smethod_105(Admit.smethod_104(Admit.smethod_103(Admit.smethod_102(Admit.smethod_101(Admit.smethod_99(SearchResultGrid), Admit.smethod_100(e))), 2))));
						num = (int)(num2 * 1978117550) ^ -2123168519;
						continue;
					case 18u:
						num = ((int)num2 * -1282023482) ^ -1820083377;
						continue;
					case 17u:
						Admit.smethod_37((Control)(object)HistoryBtn, bool_0: true);
						num = (int)(num2 * 81903499) ^ -1922484310;
						continue;
					case 16u:
						num = (int)((num2 * 889077738) ^ 0x136DB314);
						continue;
					case 15u:
						Admit.smethod_37((Control)(object)PrintBtn, bool_0: false);
						num = ((int)num2 * -992109865) ^ -610616361;
						continue;
					case 14u:
						Admit.smethod_37((Control)(object)AdmitDetailsBox, bool_0: false);
						num = ((int)num2 * -1513830363) ^ -1754108441;
						continue;
					case 12u:
						Admit.smethod_107(RoomNoTxt, -1);
						num = ((int)num2 * -734456484) ^ -201656262;
						continue;
					case 11u:
						Admit.smethod_106(AddressTxt, Admit.smethod_105(Admit.smethod_104(Admit.smethod_103(Admit.smethod_102(Admit.smethod_101(Admit.smethod_99(SearchResultGrid), Admit.smethod_100(e))), 5))));
						num = (int)(num2 * 960324520) ^ -1881400283;
						continue;
					case 10u:
						Admit.smethod_107(RoomTypeTxt, -1);
						Admit.smethod_108((TextBoxBase)(object)FeesTxt);
						num = (int)(num2 * 250469817) ^ -1042030793;
						continue;
					case 9u:
						Admit.smethod_108((TextBoxBase)(object)DateOut1Txt);
						num = (int)((num2 * 244132585) ^ 0x5AE9680F);
						continue;
					case 8u:
						Admit.smethod_106(NameTxt, Admit.smethod_105(Admit.smethod_104(Admit.smethod_103(Admit.smethod_102(Admit.smethod_101(Admit.smethod_99(SearchResultGrid), Admit.smethod_100(e))), 1))));
						num = (int)((num2 * 319971244) ^ 0x66BA47A0);
						continue;
					case 7u:
						Admit.smethod_37((Control)(object)ClearBtn, bool_0: false);
						num = (int)(num2 * 194631918) ^ -565497252;
						continue;
					case 6u:
						Admit.smethod_106(MobileSTxt, Admit.smethod_105(Admit.smethod_104(Admit.smethod_103(Admit.smethod_102(Admit.smethod_101(Admit.smethod_99(SearchResultGrid), Admit.smethod_100(e))), 4))));
						num = ((int)num2 * -662669156) ^ 0x5F4A60E7;
						continue;
					case 5u:
						num = ((int)num2 * -70870356) ^ 0x389DB358;
						continue;
					case 3u:
						Admit.smethod_106(PIDTxt, Admit.smethod_105(Admit.smethod_104(Admit.smethod_103(Admit.smethod_102(Admit.smethod_101(Admit.smethod_99(SearchResultGrid), Admit.smethod_100(e))), 0))));
						num = (int)((num2 * 742883918) ^ 0x75DA14A2);
						continue;
					case 2u:
						Admit.smethod_107(StatusTxt, -1);
						num = ((int)num2 * -1139771472) ^ 0x9B47DF2;
						continue;
					case 1u:
						Admit.smethod_37((Control)(object)AdmitDischargeBtn, bool_0: true);
						num = ((int)num2 * -1239062903) ^ -254421702;
						continue;
					case 0u:
						Admit.smethod_37((Control)(object)PatientInfoBox, bool_0: true);
						num = (int)((num2 * 486099745) ^ 0x4F45BB6F);
						continue;
					case 13u:
						break;
					default:
						Admit.smethod_107(DateOutTxt, -1);
						return;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			Admit.smethod_84(exception_);
			while (true)
			{
				_ = -527024965;
				while (true)
				{
					_003F val = /*Error near IL_045f: Stack underflow*/^ -302178696;
					uint num2 = (uint)(int)val;
					switch (val % 3)
					{
					default:
						return;
					case 1:
						Admit.smethod_85();
						_ = (num2 * 1561662849) ^ 0xCD8134B9u;
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

	private bool UpdateTable()
	{
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected I4, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected I4, but got Unknown
		//IL_0293: Incompatible stack heights: 0 vs 1
		//IL_02ae: Incompatible stack heights: 0 vs 1
		//IL_02b5: Incompatible stack heights: 0 vs 1
		string string_ = default(string);
		DataTable dataTable = default(DataTable);
		OleDbDataAdapter dbDataAdapter_ = default(OleDbDataAdapter);
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 1277741695;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x67EF1B70u) % 5u)
				{
				case 4u:
					string_ = Admit.smethod_76(new string[5]
					{
						"Select * From [Patient] Where [Name] Like '%",
						Admit.smethod_73(Admit.smethod_72(NameSTxt)),
						"%' And [Mobile] Like '%",
						Admit.smethod_72(MobileTxt),
						"%';"
					});
					dataTable = Admit.smethod_77();
					num = (int)(num2 * 1658641999) ^ -752773700;
					continue;
				case 3u:
					Admit.smethod_78(myconnection);
					num = (int)(num2 * 1645900982) ^ -1968991793;
					continue;
				case 1u:
					Admit.smethod_75();
					num = (int)((num2 * 127788726) ^ 0x4F82D4E4);
					continue;
				case 2u:
					break;
				default:
					try
					{
						while (true)
						{
							IL_0247:
							int num3 = 1343507753;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x67EF1B70u) % 15u)
								{
								case 14u:
									num3 = (int)((num2 * 958012559) ^ 0x5C189251);
									continue;
								case 12u:
									Admit.smethod_80((DbDataAdapter)(object)dbDataAdapter_, dataTable);
									num3 = ((int)num2 * -48191825) ^ -274228338;
									continue;
								case 11u:
									Admit.smethod_37((Control)(object)SearchResultGrid, bool_0: true);
									num3 = (int)((num2 * 1603698757) ^ 0x2850AAE2);
									continue;
								case 10u:
									flag = Admit.smethod_82(SearchResultGrid) == 1;
									num3 = ((int)num2 * -792408842) ^ -326012961;
									continue;
								case 9u:
									Admit.smethod_83(myconnection);
									num3 = ((int)num2 * -1817260490) ^ -24912457;
									continue;
								case 6u:
									result = false;
									num3 = (int)((num2 * 161050649) ^ 0x1E7D852B);
									continue;
								case 5u:
									Admit.smethod_83(myconnection);
									num3 = (int)(num2 * 1492449296) ^ -1720196950;
									continue;
								case 4u:
									Admit.smethod_81(SearchResultGrid, (object)dataTable);
									num3 = ((int)num2 * -161161336) ^ 0x3B0024E3;
									continue;
								case 3u:
									num3 = 1291153998;
									continue;
								case 2u:
								{
									int num4;
									int num5;
									if (flag)
									{
										num4 = 1785273492;
										num5 = 1785273492;
									}
									else
									{
										num4 = 298440878;
										num5 = 298440878;
									}
									num3 = num4 ^ ((int)num2 * -1219303889);
									continue;
								}
								case 1u:
									dbDataAdapter_ = Admit.smethod_79(string_, myconnection);
									num3 = ((int)num2 * -1772177290) ^ 0x277777CB;
									continue;
								case 0u:
									num3 = (int)((num2 * 508526570) ^ 0x705AB9E4);
									continue;
								default:
									goto end_IL_01f8;
								case 13u:
									break;
								case 8u:
									goto end_IL_01f8;
								case 7u:
									return result;
								}
								goto IL_0247;
								continue;
								end_IL_01f8:
								break;
							}
							break;
						}
					}
					catch (Exception exception_)
					{
						Admit.smethod_84(exception_);
						while (true)
						{
							IL_02b0:
							_ = 502907061;
							while (true)
							{
								_003F val = /*Error near IL_0264: Stack underflow*/^ 0x67EF1B70;
								num2 = (uint)(int)val;
								switch (val % 4)
								{
								default:
									goto end_IL_025e;
								case 3:
									Admit.smethod_85();
									_ = (num2 * 1707599944) ^ 0xFE2FFCCCu;
									continue;
								case 1:
									Admit.smethod_83(myconnection);
									_ = (num2 * 842650146) ^ 0x73E84F8D;
									continue;
								case 2:
									break;
								case 0:
									goto end_IL_025e;
								}
								goto IL_02b0;
								continue;
								end_IL_025e:
								break;
							}
							break;
						}
					}
					result = true;
					while (true)
					{
						int num6 = 461440037;
						while (true)
						{
							switch ((num2 = (uint)num6 ^ 0x67EF1B70u) % 3u)
							{
							case 2u:
								goto IL_02bd;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_02bd:
							num6 = ((int)num2 * -1439893969) ^ 0x1ADA1367;
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
			int num = -1308775013;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB07F0D7Cu) % 5u)
				{
				case 3u:
					Admit.smethod_71(Admit.smethod_42(RoomNoTxt));
					num = (int)(num2 * 574347059) ^ -1703242742;
					continue;
				case 2u:
					ClearPatientInfo();
					ClearAdmitDetails();
					num = ((int)num2 * -885487833) ^ -939197384;
					continue;
				case 1u:
					Add_Rooms();
					num = (int)(num2 * 1454587670) ^ -1470812318;
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

	private bool ClearPatientInfo()
	{
		bool result = default(bool);
		while (true)
		{
			int num = 269765026;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x142E3B98u) % 10u)
				{
				case 9u:
					Admit.smethod_108((TextBoxBase)(object)AgeTxt);
					num = ((int)num2 * -1705884815) ^ 0x89A6178;
					continue;
				case 8u:
					Admit.smethod_108((TextBoxBase)(object)GenderTxt);
					num = (int)((num2 * 642193411) ^ 0x6FCCE443);
					continue;
				case 6u:
					num = ((int)num2 * -1303554609) ^ -1912626504;
					continue;
				case 5u:
					Admit.smethod_108((TextBoxBase)(object)AddressTxt);
					num = (int)((num2 * 889726135) ^ 0x62AF2C69);
					continue;
				case 4u:
					Admit.smethod_108((TextBoxBase)(object)PIDTxt);
					num = (int)((num2 * 1077113110) ^ 0x2A6D37FB);
					continue;
				case 3u:
					Admit.smethod_108((TextBoxBase)(object)NameTxt);
					Admit.smethod_108((TextBoxBase)(object)MobileSTxt);
					num = ((int)num2 * -1627335475) ^ -929124298;
					continue;
				case 1u:
					num = (int)((num2 * 690002283) ^ 0x62A7094F);
					continue;
				case 0u:
					result = true;
					num = ((int)num2 * -1910039303) ^ -166770588;
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

	private bool ClearAdmitDetails()
	{
		Admit.smethod_107(RoomNoTxt, -1);
		bool result = default(bool);
		while (true)
		{
			int num = 36879268;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2AFAF695u) % 15u)
				{
				case 14u:
					Admit.smethod_108((TextBoxBase)(object)RoomNo1Txt);
					num = ((int)num2 * -278424418) ^ -318028531;
					continue;
				case 13u:
					num = ((int)num2 * -748011027) ^ 0x522A671;
					continue;
				case 12u:
					Admit.smethod_108((TextBoxBase)(object)FeesTxt);
					result = true;
					num = ((int)num2 * -272532738) ^ 0x71C23B6B;
					continue;
				case 11u:
					Admit.smethod_108((TextBoxBase)(object)RoomType1Txt);
					num = (int)(num2 * 510404618) ^ -1625520876;
					continue;
				case 10u:
					Admit.smethod_107(DateOutTxt, -1);
					Admit.smethod_107(StatusTxt, -1);
					num = ((int)num2 * -1166396246) ^ -636274015;
					continue;
				case 9u:
					Admit.smethod_108((TextBoxBase)(object)DateOut1Txt);
					num = (int)(num2 * 416001401) ^ -1960714735;
					continue;
				case 8u:
					num = (int)((num2 * 92829923) ^ 0xF5ECF8F);
					continue;
				case 6u:
					Admit.smethod_107(RoomTypeTxt, -1);
					num = ((int)num2 * -1435819329) ^ -199367995;
					continue;
				case 5u:
					num = (int)(num2 * 826388265) ^ -1524656874;
					continue;
				case 4u:
					Admit.smethod_108((TextBoxBase)(object)DateIn1Txt);
					num = (int)(num2 * 1254570948) ^ -941299176;
					continue;
				case 3u:
					num = (int)((num2 * 1637741185) ^ 0x656230B);
					continue;
				case 2u:
					num = (int)((num2 * 480021305) ^ 0x6C98BEB7);
					continue;
				case 1u:
					Admit.smethod_107(DateInTxt, -1);
					num = ((int)num2 * -1064175019) ^ -955256295;
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

	private void PrintBtn_Click(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Invalid comparison between Unknown and I4
		bool flag = Admit.smethod_87(Admit.smethod_72(PIDTxt), "", bool_0: false) == 0;
		bool flag2 = default(bool);
		while (true)
		{
			int num = 141697711;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC3B1692u) % 21u)
				{
				case 19u:
					Admit.smethod_74("No Patient to Print");
					num = ((int)num2 * -1170987143) ^ 0x6B69BF80;
					continue;
				case 17u:
					num = ((int)num2 * -1993260360) ^ 0x4EE5E7A;
					continue;
				case 16u:
					num = ((int)num2 * -1237407942) ^ -515930035;
					continue;
				case 15u:
				{
					int num4;
					int num5;
					if (flag2)
					{
						num4 = -1876558603;
						num5 = -1876558603;
					}
					else
					{
						num4 = -1714648511;
						num5 = -1714648511;
					}
					num = num4 ^ (int)(num2 * 558564712);
					continue;
				}
				case 14u:
					num = (int)(num2 * 1506805603) ^ -1105755291;
					continue;
				case 13u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -203337217;
						num7 = -203337217;
					}
					else
					{
						num6 = -678075517;
						num7 = -678075517;
					}
					num = num6 ^ ((int)num2 * -456022619);
					continue;
				}
				case 12u:
					num = (int)((num2 * 886018946) ^ 0x7AA87C55);
					continue;
				case 11u:
				{
					int num3;
					if (!Validate_Print_Data())
					{
						num = 133149588;
						num3 = 133149588;
					}
					else
					{
						num = 323970615;
						num3 = 323970615;
					}
					continue;
				}
				case 10u:
					num = ((int)num2 * -136148988) ^ -2076025815;
					continue;
				case 9u:
					Admit.smethod_116(PrintDocument1);
					num = (int)(num2 * 501591840) ^ -186499351;
					continue;
				case 8u:
					Admit.smethod_111(PrintDialog1, Admit.smethod_110(PrintDocument1));
					num = (int)(num2 * 1402185639) ^ -772715077;
					continue;
				case 7u:
					Admit.smethod_112(PrintDialog1, bool_0: true);
					num = (int)(num2 * 137561091) ^ -253290028;
					continue;
				case 6u:
					Admit.smethod_115(PrintDocument1, Admit.smethod_114(PrintDialog1));
					num = ((int)num2 * -1379641139) ^ 0x37293736;
					continue;
				case 5u:
					num = ((int)num2 * -1726980124) ^ 0x21479118;
					continue;
				case 4u:
					num = (int)(num2 * 2062162961) ^ -531108614;
					continue;
				case 3u:
					num = 1081591057;
					continue;
				case 2u:
					num = ((int)num2 * -1453300173) ^ -577388635;
					continue;
				case 1u:
					Admit.smethod_109(PrintDialog1, PrintDocument1);
					num = 533129590;
					continue;
				case 0u:
					flag2 = (int)Admit.smethod_113((CommonDialog)(object)PrintDialog1) == 1;
					num = ((int)num2 * -1816943605) ^ -1756554990;
					continue;
				default:
					return;
				case 18u:
					break;
				case 20u:
					return;
				}
				break;
			}
		}
	}

	private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
	{
		bool flag = Admit.smethod_117((Control)(object)RoomNo1Txt);
		string string_2 = default(string);
		Font font_ = default(Font);
		Font font_2 = default(Font);
		string string_ = default(string);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 2028633593;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x184DA4DAu) % 23u)
				{
				case 22u:
					num = 28986859;
					continue;
				case 21u:
					Admit.smethod_121(Admit.smethod_119(e), Admit.smethod_66("Room No - ", string_2) ?? "", font_, Admit.smethod_120(), 100f, 250f);
					num = 2053140689;
					continue;
				case 20u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -1040989776;
						num6 = -1040989776;
					}
					else
					{
						num5 = -1954711792;
						num6 = -1954711792;
					}
					num = num5 ^ (int)(num2 * 1195648428);
					continue;
				}
				case 19u:
					font_2 = Admit.smethod_118("Times New Roman", 20f);
					num = 1109178493;
					continue;
				case 18u:
					Admit.smethod_121(Admit.smethod_119(e), Admit.smethod_66("Room Type - ", string_) ?? "", font_, Admit.smethod_120(), 100f, 300f);
					num = 1562842910;
					continue;
				case 17u:
					Admit.smethod_121(Admit.smethod_119(e), Admit.smethod_66("Name - ", Admit.smethod_72(NameTxt)) ?? "", font_, Admit.smethod_120(), 100f, 150f);
					num = 1372800353;
					continue;
				case 16u:
					string_ = Admit.smethod_94(RoomTypeTxt);
					num = (int)(num2 * 784924319) ^ -768805646;
					continue;
				case 14u:
					string_ = Admit.smethod_72(RoomType1Txt);
					num = ((int)num2 * -1752560291) ^ 0x36CFB0A4;
					continue;
				case 13u:
					flag2 = Admit.smethod_117((Control)(object)RoomType1Txt);
					num = 549629685;
					continue;
				case 12u:
					string_2 = Admit.smethod_94(RoomNoTxt);
					num = ((int)num2 * -1941864225) ^ -1836185483;
					continue;
				case 11u:
					string_2 = Admit.smethod_72(RoomNo1Txt);
					num = (int)(num2 * 1139419001) ^ -240378617;
					continue;
				case 10u:
					num = 1637632050;
					continue;
				case 9u:
					num = (int)(num2 * 269003366) ^ -2116386316;
					continue;
				case 8u:
					Admit.smethod_121(Admit.smethod_119(e), Admit.smethod_66("Fees - ", Admit.smethod_72(FeesTxt)) ?? "", font_, Admit.smethod_120(), 100f, 350f);
					num = 328311517;
					continue;
				case 7u:
					Admit.smethod_121(Admit.smethod_119(e), Admit.smethod_66("Mobile - ", Admit.smethod_72(MobileTxt)) ?? "", font_, Admit.smethod_120(), 100f, 200f);
					num = 1584527808;
					continue;
				case 6u:
					font_ = Admit.smethod_118("Times New Roman", 12f);
					Admit.smethod_121(Admit.smethod_119(e), "Admit/Discharge", font_2, Admit.smethod_120(), 250f, 100f);
					num = ((int)num2 * -1325490351) ^ 0x74EBDF58;
					continue;
				case 4u:
					num = (int)((num2 * 643698268) ^ 0x72A94306);
					continue;
				case 3u:
					num = ((int)num2 * -1614129601) ^ 0x2464E877;
					continue;
				case 2u:
					num = ((int)num2 * -161005101) ^ -401587899;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag2)
					{
						num3 = -543900278;
						num4 = -543900278;
					}
					else
					{
						num3 = -1571614016;
						num4 = -1571614016;
					}
					num = num3 ^ ((int)num2 * -459228597);
					continue;
				}
				case 0u:
					num = ((int)num2 * -1291080297) ^ 0x3E04116F;
					continue;
				default:
					return;
				case 15u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	private void HistoryBtn_Click(object sender, EventArgs e)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		bool flag = Admit.smethod_87(Admit.smethod_72(PIDTxt), "", bool_0: false) == 0;
		while (true)
		{
			int num = -745392109;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9760CBD0u) % 7u)
				{
				case 6u:
					num = -1044454508;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1354265684;
						num4 = 1354265684;
					}
					else
					{
						num3 = 27800980;
						num4 = 27800980;
					}
					num = num3 ^ (int)(num2 * 1985966711);
					continue;
				}
				case 3u:
					Admit.smethod_74("No Patient Selected");
					num = ((int)num2 * -319752591) ^ 0x458C3A10;
					continue;
				case 2u:
					MyProject.Forms.Form2.PID_Value = Admit.smethod_72(PIDTxt);
					Admit.smethod_122((Control)(object)MyProject.Forms.Form5);
					num = (int)(num2 * 1457626302) ^ -192983021;
					continue;
				case 1u:
					num = ((int)num2 * -1294005335) ^ 0x39554B32;
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

	private void AdmitDischargeBtn_Click(object sender, EventArgs e)
	{
		//IL_06ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Expected I4, but got Unknown
		//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Expected I4, but got Unknown
		//IL_0736: Unknown result type (might be due to invalid IL or missing references)
		//IL_073d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0751: Incompatible stack heights: 0 vs 1
		//IL_076d: Incompatible stack heights: 0 vs 1
		//IL_0780: Incompatible stack heights: 0 vs 1
		//IL_079f: Incompatible stack heights: 0 vs 1
		//IL_07be: Incompatible stack heights: 0 vs 1
		//IL_07dd: Incompatible stack heights: 0 vs 1
		//IL_07f0: Incompatible stack heights: 0 vs 1
		//IL_081b: Incompatible stack heights: 0 vs 1
		//IL_083a: Incompatible stack heights: 0 vs 1
		//IL_0859: Incompatible stack heights: 0 vs 1
		//IL_0878: Incompatible stack heights: 0 vs 1
		//IL_0882: Incompatible stack heights: 0 vs 1
		//IL_0893: Unknown result type (might be due to invalid IL or missing references)
		bool flag4 = default(bool);
		string string_ = default(string);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = -1123990211;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD0C60AAFu) % 8u)
				{
				case 7u:
				{
					OleDbCommand oleDbCommand_ = Admit.smethod_75();
					num = ((int)num2 * -1181827126) ^ -418625123;
					continue;
				}
				case 5u:
				{
					int num11;
					int num12;
					if (!flag4)
					{
						num11 = 1394407352;
						num12 = 1394407352;
					}
					else
					{
						num11 = 954439454;
						num12 = 954439454;
					}
					num = num11 ^ ((int)num2 * -46207733);
					continue;
				}
				case 4u:
					string_ = Admit.smethod_123("Select * From [Admit-Discharge] Where [PID] = ", Admit.smethod_72(PIDTxt), ";");
					num = ((int)num2 * -329711746) ^ -1514622850;
					continue;
				case 2u:
					flag4 = Admit.smethod_87(Admit.smethod_72(PIDTxt), "", bool_0: false) == 0;
					num = ((int)num2 * -1044022442) ^ 0x592B400E;
					continue;
				case 0u:
					num = -599429328;
					continue;
				case 3u:
					break;
				default:
					Admit.smethod_78(myconnection);
					try
					{
						OleDbCommand oleDbCommand_ = Admit.smethod_88(string_, myconnection);
						OleDbDataReader oleDbDataReader_ = Admit.smethod_124(oleDbCommand_);
						int num3 = 0;
						while (true)
						{
							bool flag = Admit.smethod_128(oleDbDataReader_);
							int num4 = -521576713;
							while (true)
							{
								switch ((num2 = (uint)num4 ^ 0xD0C60AAFu) % 45u)
								{
								case 43u:
									num4 = (int)((num2 * 1941734642) ^ 0x7B2F0216);
									continue;
								case 42u:
									Admit.smethod_83(myconnection);
									num4 = -222051688;
									continue;
								case 41u:
									num4 = -2054693986;
									continue;
								case 40u:
									Admit.smethod_127(StatusTxt, Admit.smethod_126(Admit.smethod_125(oleDbDataReader_, 6)));
									num4 = (int)((num2 * 606603501) ^ 0x264DACC8);
									continue;
								case 39u:
									Admit.smethod_37((Control)(object)ClearBtn, bool_0: true);
									num4 = ((int)num2 * -1783089384) ^ -1615052368;
									continue;
								case 38u:
								{
									int num7;
									int num8;
									if (!flag2)
									{
										num7 = -399106285;
										num8 = -399106285;
									}
									else
									{
										num7 = -1033430554;
										num8 = -1033430554;
									}
									num4 = num7 ^ ((int)num2 * -211667219);
									continue;
								}
								case 37u:
									Admit.smethod_37((Control)(object)AdmitDischargeBtn, bool_0: false);
									num4 = ((int)num2 * -1240476692) ^ 0x78E45FD2;
									continue;
								case 36u:
									num4 = (int)((num2 * 244197955) ^ 0x5C909311);
									continue;
								case 35u:
									num4 = ((int)num2 * -1444908891) ^ -1377652692;
									continue;
								case 34u:
									num4 = ((int)num2 * -212434283) ^ -1279699991;
									continue;
								case 33u:
									Admit.smethod_106(DateIn1Txt, Admit.smethod_105(Admit.smethod_125(oleDbDataReader_, 2)));
									Admit.smethod_106(RoomNo1Txt, Admit.smethod_126(Admit.smethod_125(oleDbDataReader_, 4)));
									num4 = (int)((num2 * 1496915167) ^ 0x1DE61900);
									continue;
								case 32u:
									Admit.smethod_37((Control)(object)AdmitDetailsBox, bool_0: true);
									num4 = ((int)num2 * -324746126) ^ -1770392125;
									continue;
								case 31u:
									num4 = (int)((num2 * 224328580) ^ 0x4D35D634);
									continue;
								case 30u:
									id = Admit.smethod_126(Admit.smethod_125(oleDbDataReader_, 0));
									num4 = (int)(num2 * 390422085) ^ -1471526595;
									continue;
								case 29u:
									num4 = (int)((num2 * 417793882) ^ 0x4034A458);
									continue;
								case 28u:
									num3 = 1;
									num4 = ((int)num2 * -843927302) ^ 0x27981FDD;
									continue;
								case 27u:
								{
									int num9;
									int num10;
									if (flag)
									{
										num9 = 967839756;
										num10 = 967839756;
									}
									else
									{
										num9 = 1188052013;
										num10 = 1188052013;
									}
									num4 = num9 ^ (int)(num2 * 111241998);
									continue;
								}
								case 26u:
									Admit.smethod_37((Control)(object)DateIn1Txt, bool_0: true);
									num4 = ((int)num2 * -1564150193) ^ 0xB9224F0;
									continue;
								case 25u:
									Admit.smethod_106(RoomType1Txt, Admit.smethod_126(Admit.smethod_125(oleDbDataReader_, 5)));
									num4 = ((int)num2 * -1186024809) ^ -1578227598;
									continue;
								case 24u:
									num4 = (int)(num2 * 1923120367) ^ -1725726615;
									continue;
								case 23u:
									Admit.smethod_37((Control)(object)RoomNoTxt, bool_0: true);
									num4 = ((int)num2 * -591198917) ^ -1051895565;
									continue;
								case 22u:
									Admit.smethod_37((Control)(object)DateOutTxt, bool_0: true);
									num4 = ((int)num2 * -2010574568) ^ -1480836259;
									continue;
								case 21u:
									flag3 = (Admit.smethod_87(Admit.smethod_126(Admit.smethod_125(oleDbDataReader_, 2)), "", bool_0: false) != 0) & (Admit.smethod_87(Admit.smethod_126(Admit.smethod_125(oleDbDataReader_, 3)), "", bool_0: false) == 0);
									num4 = -388876426;
									continue;
								case 20u:
									num4 = ((int)num2 * -764574138) ^ 0x40A0C77D;
									continue;
								case 19u:
									Admit.smethod_37((Control)(object)PrintBtn, bool_0: true);
									num4 = (int)((num2 * 758855362) ^ 0x1C975EA1);
									continue;
								case 18u:
									num4 = ((int)num2 * -287947871) ^ 0x3D33A4B7;
									continue;
								case 17u:
									Admit.smethod_37((Control)(object)DateOut1Txt, bool_0: true);
									Admit.smethod_37((Control)(object)DateOutTxt, bool_0: false);
									num4 = ((int)num2 * -641646165) ^ 0x29B970E7;
									continue;
								case 15u:
									Admit.smethod_37((Control)(object)SaveBtn, bool_0: true);
									num4 = ((int)num2 * -594748824) ^ 0x1ED7A43D;
									continue;
								case 14u:
									Admit.smethod_37((Control)(object)RoomNo1Txt, bool_0: true);
									num4 = (int)((num2 * 2015994213) ^ 0x75CE4D7D);
									continue;
								case 13u:
									Admit.smethod_37((Control)(object)RoomNoTxt, bool_0: false);
									num4 = ((int)num2 * -111722177) ^ -283622977;
									continue;
								case 12u:
									num4 = ((int)num2 * -6375610) ^ 0x3AE06A3A;
									continue;
								case 11u:
									num4 = -1080068900;
									continue;
								case 10u:
									Admit.smethod_37((Control)(object)RoomTypeTxt, bool_0: false);
									num4 = ((int)num2 * -1871844364) ^ -1710360154;
									continue;
								case 9u:
								{
									int num5;
									int num6;
									if (flag3)
									{
										num5 = -518205962;
										num6 = -518205962;
									}
									else
									{
										num5 = -1672909923;
										num6 = -1672909923;
									}
									num4 = num5 ^ (int)(num2 * 507660320);
									continue;
								}
								case 8u:
									Admit.smethod_37((Control)(object)RoomTypeTxt, bool_0: true);
									num4 = (int)(num2 * 1042571288) ^ -1168898629;
									continue;
								case 7u:
									Admit.smethod_37((Control)(object)RoomNo1Txt, bool_0: false);
									num4 = ((int)num2 * -1008464440) ^ 0x599DB09F;
									continue;
								case 6u:
									Admit.smethod_37((Control)(object)DateOut1Txt, bool_0: false);
									num4 = ((int)num2 * -54217247) ^ 0x45515FAB;
									continue;
								case 5u:
									Admit.smethod_37((Control)(object)RoomType1Txt, bool_0: false);
									num4 = ((int)num2 * -1654516542) ^ 0x7F4550F9;
									continue;
								case 4u:
									flag2 = num3 == 0;
									num4 = ((int)num2 * -289731689) ^ -1779520736;
									continue;
								case 3u:
									num4 = ((int)num2 * -1004724696) ^ -145770124;
									continue;
								case 2u:
									Admit.smethod_37((Control)(object)RoomType1Txt, bool_0: true);
									num4 = ((int)num2 * -1406519108) ^ -1576479331;
									continue;
								case 1u:
									Admit.smethod_37((Control)(object)DateIn1Txt, bool_0: false);
									Admit.smethod_37((Control)(object)DateInTxt, bool_0: true);
									num4 = (int)(num2 * 1548972968) ^ -920962333;
									continue;
								case 0u:
									Admit.smethod_37((Control)(object)DateInTxt, bool_0: false);
									num4 = (int)(num2 * 1445330350) ^ -632689759;
									continue;
								default:
									return;
								case 44u:
									break;
								case 16u:
									return;
								}
								break;
							}
						}
					}
					catch (Exception ex)
					{
						Admit.smethod_84(ex);
						Exception exception_ = ex;
						Admit.smethod_83(myconnection);
						while (true)
						{
							_ = -1189277747;
							while (true)
							{
								_003F val = /*Error near IL_06eb: Stack underflow*/^ -792327505;
								num2 = (uint)(int)val;
								switch (val % 13)
								{
								case 11:
									Admit.smethod_74(Admit.smethod_129(exception_));
									Admit.smethod_74(string_);
									_ = ((int)num2 * -1921481456) ^ -404942827;
									continue;
								case 10:
									Admit.smethod_37((Control)(object)DateIn1Txt, bool_0: false);
									_ = ((int)num2 * -471461360) ^ 0x600509E3;
									continue;
								case 9:
									_ = ((int)num2 * -1640244712) ^ -2098677520;
									continue;
								case 8:
									Admit.smethod_37((Control)(object)AdmitDetailsBox, bool_0: true);
									_ = ((int)num2 * -1440831186) ^ -1697184664;
									continue;
								case 7:
									Admit.smethod_37((Control)(object)RoomTypeTxt, bool_0: true);
									_ = (num2 * 1812609550) ^ 0xEBE2340Eu;
									continue;
								case 6:
									Admit.smethod_37((Control)(object)DateInTxt, bool_0: true);
									_ = ((int)num2 * -453652313) ^ 0x61B22B34;
									continue;
								case 5:
									_ = ((int)num2 * -632747766) ^ -1757335958;
									continue;
								case 4:
									Admit.smethod_37((Control)(object)RoomType1Txt, bool_0: false);
									Admit.smethod_37((Control)(object)RoomNoTxt, bool_0: true);
									_ = (num2 * 1121686278) ^ 0x7567315A;
									continue;
								case 3:
									Admit.smethod_37((Control)(object)DateOut1Txt, bool_0: true);
									_ = ((int)num2 * -348706223) ^ -1628665764;
									continue;
								case 2:
									Admit.smethod_37((Control)(object)RoomNo1Txt, bool_0: false);
									_ = ((int)num2 * -1196456071) ^ -551999577;
									continue;
								case 1:
									Admit.smethod_37((Control)(object)DateOutTxt, bool_0: false);
									_ = ((int)num2 * -1069206637) ^ 0x186F508D;
									continue;
								case 0:
									break;
								default:
									Admit.smethod_85();
									return;
								}
								break;
							}
						}
					}
				case 6u:
					Admit.smethod_74("No Patient Selected");
					return;
				}
				break;
			}
		}
	}

	private bool Add_Rooms()
	{
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected I4, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected I4, but got Unknown
		//IL_01b7: Incompatible stack heights: 0 vs 1
		//IL_01c7: Incompatible stack heights: 0 vs 1
		//IL_01ce: Incompatible stack heights: 0 vs 1
		OleDbCommand oleDbCommand_ = Admit.smethod_75();
		string string_ = "Select * From [Room] Where [Availability] = 'Yes';";
		Admit.smethod_78(myconnection);
		try
		{
			bool flag = default(bool);
			bool flag2 = default(bool);
			OleDbDataReader oleDbDataReader_ = default(OleDbDataReader);
			while (true)
			{
				IL_015c:
				int num = -1107305287;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDF99B59Bu) % 12u)
					{
					case 11u:
					{
						int num5;
						int num6;
						if (!flag)
						{
							num5 = 519706102;
							num6 = 519706102;
						}
						else
						{
							num5 = 1846455769;
							num6 = 1846455769;
						}
						num = num5 ^ ((int)num2 * -1140844983);
						continue;
					}
					case 10u:
						num = ((int)num2 * -2041161654) ^ 0x773A064E;
						continue;
					case 9u:
						num = -182665369;
						continue;
					case 7u:
						flag2 = Admit.smethod_130(oleDbDataReader_);
						num = ((int)num2 * -890564862) ^ 0x7C763ABE;
						continue;
					case 6u:
						oleDbCommand_ = Admit.smethod_88(string_, myconnection);
						num = ((int)num2 * -781987330) ^ 0x6701E663;
						continue;
					case 5u:
						num = (int)((num2 * 1399005789) ^ 0x59623D10);
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (flag2)
						{
							num3 = 1169190834;
							num4 = 1169190834;
						}
						else
						{
							num3 = 1288994662;
							num4 = 1288994662;
						}
						num = num3 ^ (int)(num2 * 1851161412);
						continue;
					}
					case 2u:
						flag = Admit.smethod_128(oleDbDataReader_);
						num = -2037770380;
						continue;
					case 1u:
						Admit.smethod_70(Admit.smethod_42(RoomNoTxt), (object)Admit.smethod_126(Admit.smethod_125(oleDbDataReader_, 0)));
						num = -291659359;
						continue;
					case 0u:
						oleDbDataReader_ = Admit.smethod_124(oleDbCommand_);
						num = (int)((num2 * 1195549548) ^ 0x47AACC68);
						continue;
					case 4u:
						break;
					default:
						Admit.smethod_83(myconnection);
						goto end_IL_0119;
					}
					goto IL_015c;
					continue;
					end_IL_0119:
					break;
				}
				break;
			}
		}
		catch (Exception exception_)
		{
			Admit.smethod_84(exception_);
			while (true)
			{
				IL_01c9:
				_ = -88699354;
				while (true)
				{
					_003F val = /*Error near IL_0182: Stack underflow*/^ -543574629;
					uint num2 = (uint)(int)val;
					switch (val % 4)
					{
					case 3:
						Admit.smethod_83(myconnection);
						_ = ((int)num2 * -1864700528) ^ 0x9E985DD;
						continue;
					case 1:
						_ = ((int)num2 * -704084451) ^ 0x583BB9F9;
						continue;
					case 0:
						break;
					default:
						Admit.smethod_85();
						goto end_IL_017c;
					}
					goto IL_01c9;
					continue;
					end_IL_017c:
					break;
				}
				break;
			}
		}
		bool result = default(bool);
		while (true)
		{
			int num7 = -490341580;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num7 ^ 0xDF99B59Bu) % 4u)
				{
				case 3u:
					result = true;
					num7 = ((int)num2 * -1841417646) ^ 0x5AAD7E6D;
					continue;
				case 0u:
					num7 = (int)(num2 * 1217318818) ^ -1039722854;
					continue;
				case 2u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private bool Update_Rooms(string roomNo, string status)
	{
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected I4, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected I4, but got Unknown
		//IL_015e: Incompatible stack heights: 0 vs 1
		//IL_016e: Incompatible stack heights: 0 vs 1
		//IL_017e: Incompatible stack heights: 0 vs 1
		//IL_0193: Incompatible stack heights: 0 vs 1
		//IL_019a: Incompatible stack heights: 0 vs 1
		string string_ = default(string);
		bool result = default(bool);
		while (true)
		{
			int num = -1892411460;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8993298Au) % 5u)
				{
				case 4u:
				{
					OleDbCommand val = Admit.smethod_75();
					num = (int)((num2 * 459070497) ^ 0x5892E910);
					continue;
				}
				case 3u:
					string_ = Admit.smethod_76(new string[5] { "Update [Room] Set [Availability] = '", status, "' Where [Room No] = ", roomNo, ";" });
					num = (int)((num2 * 1242613711) ^ 0x46A6A419);
					continue;
				case 2u:
					Admit.smethod_78(myconnection);
					num = ((int)num2 * -2088786517) ^ 0x675FA5C2;
					continue;
				case 0u:
					break;
				default:
					try
					{
						OleDbCommand val = Admit.smethod_88(string_, myconnection);
						Admit.smethod_96(val);
						Admit.smethod_97((Component)(object)val);
						while (true)
						{
							IL_0106:
							int num3 = -1148905151;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x8993298Au) % 4u)
								{
								case 3u:
									num3 = (int)(num2 * 1673951664) ^ -1569659605;
									continue;
								case 1u:
									Admit.smethod_83(myconnection);
									num3 = ((int)num2 * -1850988659) ^ -898078715;
									continue;
								default:
									goto end_IL_00e4;
								case 0u:
									break;
								case 2u:
									goto end_IL_00e4;
								}
								goto IL_0106;
								continue;
								end_IL_00e4:
								break;
							}
							break;
						}
					}
					catch (Exception exception_)
					{
						Admit.smethod_84(exception_);
						while (true)
						{
							IL_0195:
							_ = -937412239;
							while (true)
							{
								_003F val2 = /*Error near IL_0121: Stack underflow*/^ -1986844278;
								num2 = (uint)(int)val2;
								switch (val2 % 6)
								{
								default:
									goto end_IL_011b;
								case 4:
									Admit.smethod_83(myconnection);
									_ = ((int)num2 * -781314447) ^ 0x2B73F40E;
									continue;
								case 2:
									_ = (num2 * 603357892) ^ 0x2E3A4A4E;
									continue;
								case 1:
									_ = ((int)num2 * -951515775) ^ 0x26F9983D;
									continue;
								case 0:
									Admit.smethod_85();
									_ = (num2 * 1833785711) ^ 0xEEF6DB89u;
									continue;
								case 3:
									break;
								case 5:
									goto end_IL_011b;
								}
								goto IL_0195;
								continue;
								end_IL_011b:
								break;
							}
							break;
						}
					}
					while (true)
					{
						int num4 = -1621180715;
						while (true)
						{
							switch ((num2 = (uint)num4 ^ 0x8993298Au) % 3u)
							{
							case 2u:
								goto IL_01a1;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_01a1:
							result = true;
							num4 = (int)(num2 * 485507335) ^ -35801696;
						}
					}
				}
				break;
			}
		}
	}

	private bool Validate_Print_Data()
	{
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		bool flag = (Admit.smethod_131(RoomNoTxt) == -1) & (Admit.smethod_87(Admit.smethod_72(RoomNo1Txt), "", bool_0: false) == 0);
		bool flag4 = default(bool);
		bool result = default(bool);
		bool flag7 = default(bool);
		bool flag6 = default(bool);
		bool flag2 = default(bool);
		bool flag5 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 1324088473;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6EA4B26Bu) % 44u)
				{
				case 43u:
					num = ((int)num2 * -98482627) ^ -1933181110;
					continue;
				case 42u:
				{
					int num5;
					if (!((Admit.smethod_87(Admit.smethod_94(StatusTxt), "", bool_0: false) == 0) | (Admit.smethod_87(Admit.smethod_94(StatusTxt), "Not Paid", bool_0: false) == 0)))
					{
						num = 976873300;
						num5 = 976873300;
					}
					else
					{
						num = 404369978;
						num5 = 404369978;
					}
					continue;
				}
				case 41u:
					flag4 = Admit.smethod_131(DateOutTxt) == -1;
					num = (int)((num2 * 1634630007) ^ 0x4281B7F5);
					continue;
				case 40u:
					result = true;
					num = (int)(num2 * 1564736765) ^ -391013051;
					continue;
				case 39u:
					num = 1994976749;
					continue;
				case 38u:
				{
					int num17;
					int num18;
					if (!flag)
					{
						num17 = 386302185;
						num18 = 386302185;
					}
					else
					{
						num17 = 1697218817;
						num18 = 1697218817;
					}
					num = num17 ^ ((int)num2 * -294678691);
					continue;
				}
				case 37u:
					Admit.smethod_74("Cannot discharge Without Paying fees");
					num = (int)(num2 * 895215842) ^ -1603608005;
					continue;
				case 36u:
				{
					int num14;
					if (Admit.smethod_117((Control)(object)DateOut1Txt))
					{
						num = 1796853949;
						num14 = 1796853949;
					}
					else
					{
						num = 175717574;
						num14 = 175717574;
					}
					continue;
				}
				case 35u:
					flag7 = (Admit.smethod_87(Admit.smethod_94(StatusTxt), "Paid", bool_0: false) == 0) & !MyProject.Forms.Form1.Number_Validator(Admit.smethod_72(FeesTxt));
					num = 1774626904;
					continue;
				case 34u:
					num = 909186915;
					continue;
				case 33u:
					num = (int)(num2 * 1319615868) ^ -715540527;
					continue;
				case 32u:
					Admit.smethod_74("Cannot Display Fees when Not Paid");
					num = ((int)num2 * -784733887) ^ 0xBF682;
					continue;
				case 31u:
					num = ((int)num2 * -1287725250) ^ 0x76B1702D;
					continue;
				case 30u:
					result = false;
					num = (int)(num2 * 723037333) ^ -173584866;
					continue;
				case 29u:
					Admit.smethod_74("Incorrect fees Value");
					result = false;
					num = ((int)num2 * -918452032) ^ -844503815;
					continue;
				case 28u:
					result = false;
					num = ((int)num2 * -1153703886) ^ 0x654B9500;
					continue;
				case 27u:
					flag6 = !Admit.smethod_117((Control)(object)DateIn1Txt);
					num = 2028848562;
					continue;
				case 26u:
					Admit.smethod_74("Missing fees");
					num = (int)((num2 * 228619607) ^ 0x7E937D35);
					continue;
				case 25u:
				{
					int num19;
					int num20;
					if (flag4)
					{
						num19 = 730635117;
						num20 = 730635117;
					}
					else
					{
						num19 = 1234003228;
						num20 = 1234003228;
					}
					num = num19 ^ (int)(num2 * 1186271715);
					continue;
				}
				case 24u:
				{
					int num15;
					int num16;
					if (flag2)
					{
						num15 = 1229708774;
						num16 = 1229708774;
					}
					else
					{
						num15 = 402234789;
						num16 = 402234789;
					}
					num = num15 ^ ((int)num2 * -820378037);
					continue;
				}
				case 23u:
				{
					int num12;
					int num13;
					if (!flag7)
					{
						num12 = 1813432796;
						num13 = 1813432796;
					}
					else
					{
						num12 = 1103117939;
						num13 = 1103117939;
					}
					num = num12 ^ (int)(num2 * 165261858);
					continue;
				}
				case 21u:
				{
					int num10;
					int num11;
					if (!flag6)
					{
						num10 = 1701446474;
						num11 = 1701446474;
					}
					else
					{
						num10 = 1853997185;
						num11 = 1853997185;
					}
					num = num10 ^ (int)(num2 * 154261997);
					continue;
				}
				case 20u:
					num = 70087809;
					continue;
				case 19u:
					num = 658750196;
					continue;
				case 17u:
					Admit.smethod_74("Missing Date out");
					num = (int)(num2 * 2104089434) ^ -1745964616;
					continue;
				case 16u:
					Admit.smethod_74("Missing Room No");
					num = ((int)num2 * -1606107997) ^ 0x6647DB63;
					continue;
				case 15u:
					result = false;
					num = (int)(num2 * 1832537148) ^ -1154661355;
					continue;
				case 14u:
					num = ((int)num2 * -1059701515) ^ -530886865;
					continue;
				case 13u:
					Admit.smethod_74("Missing Room type");
					num = (int)((num2 * 47334354) ^ 0x313B1BF6);
					continue;
				case 12u:
					result = false;
					num = (int)(num2 * 222831076) ^ -523144822;
					continue;
				case 11u:
					num = (int)(num2 * 1657491465) ^ -1235820950;
					continue;
				case 10u:
					num = ((int)num2 * -359842171) ^ 0x1D680B37;
					continue;
				case 9u:
					result = false;
					num = ((int)num2 * -2015218563) ^ -432386636;
					continue;
				case 8u:
				{
					int num8;
					int num9;
					if (flag5)
					{
						num8 = 47489775;
						num9 = 47489775;
					}
					else
					{
						num8 = 378914536;
						num9 = 378914536;
					}
					num = num8 ^ ((int)num2 * -1192149826);
					continue;
				}
				case 7u:
				{
					int num6;
					int num7;
					if (Admit.smethod_131(DateInTxt) != -1)
					{
						num6 = 1635430015;
						num7 = 1635430015;
					}
					else
					{
						num6 = 52175572;
						num7 = 52175572;
					}
					num = num6 ^ (int)(num2 * 786857953);
					continue;
				}
				case 6u:
					flag3 = (Admit.smethod_131(RoomTypeTxt) == -1) & (Admit.smethod_87(Admit.smethod_72(RoomType1Txt), "", bool_0: false) == 0);
					num = ((int)num2 * -868019039) ^ 0x2B7F1F92;
					continue;
				case 5u:
					flag5 = (Admit.smethod_87(Admit.smethod_94(StatusTxt), "Not Paid", bool_0: false) == 0) & (Admit.smethod_87(Admit.smethod_72(FeesTxt), "", bool_0: false) != 0);
					num = 1043627099;
					continue;
				case 4u:
					Admit.smethod_74("Missing Date In");
					result = false;
					num = (int)(num2 * 321646305) ^ -1395013827;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag3)
					{
						num3 = 378320153;
						num4 = 378320153;
					}
					else
					{
						num3 = 2139567175;
						num4 = 2139567175;
					}
					num = num3 ^ ((int)num2 * -1485356521);
					continue;
				}
				case 2u:
					num = (int)(num2 * 591416485) ^ -502494749;
					continue;
				case 1u:
					result = false;
					num = ((int)num2 * -2111857479) ^ 0x5F6F377C;
					continue;
				case 0u:
					flag2 = !MyProject.Forms.Form1.Number_Validator(Admit.smethod_72(FeesTxt));
					num = 2028105255;
					continue;
				case 22u:
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

	static GroupBox smethod_4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new GroupBox();
	}

	static Button smethod_5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static TextBox smethod_6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static DataGridView smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DataGridView();
	}

	static ComboBox smethod_8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ComboBox();
	}

	static PrintDialog smethod_9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PrintDialog();
	}

	static PrintDocument smethod_10()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PrintDocument();
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

	static void smethod_15(Label label_0, bool bool_0)
	{
		label_0.set_AutoSize(bool_0);
	}

	static Font smethod_16(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
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

	static ControlCollection smethod_24(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_25(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_26(GroupBox groupBox_0, bool bool_0)
	{
		groupBox_0.set_TabStop(bool_0);
	}

	static void smethod_27(GroupBox groupBox_0, string string_0)
	{
		groupBox_0.set_Text(string_0);
	}

	static void smethod_28(ButtonBase buttonBase_0, Color color_0)
	{
		buttonBase_0.set_BackColor(color_0);
	}

	static void smethod_29(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
	}

	static void smethod_30(ButtonBase buttonBase_0, string string_0)
	{
		buttonBase_0.set_Text(string_0);
	}

	static void smethod_31(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_32(DataGridView dataGridView_0, Color color_0)
	{
		dataGridView_0.set_BackgroundColor(color_0);
	}

	static void smethod_33(DataGridView dataGridView_0, DataGridViewColumnHeadersHeightSizeMode dataGridViewColumnHeadersHeightSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		dataGridView_0.set_ColumnHeadersHeightSizeMode(dataGridViewColumnHeadersHeightSizeMode_0);
	}

	static void smethod_34(DataGridView dataGridView_0, bool bool_0)
	{
		dataGridView_0.set_ReadOnly(bool_0);
	}

	static DataGridViewRow smethod_35(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_RowTemplate();
	}

	static void smethod_36(DataGridViewRow dataGridViewRow_0, int int_0)
	{
		dataGridViewRow_0.set_Height(int_0);
	}

	static void smethod_37(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static void smethod_38(TextBoxBase textBoxBase_0, bool bool_0)
	{
		textBoxBase_0.set_ReadOnly(bool_0);
	}

	static void smethod_39(TextBox textBox_0, bool bool_0)
	{
		textBox_0.set_Multiline(bool_0);
	}

	static void smethod_40(ComboBox comboBox_0, ComboBoxStyle comboBoxStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		comboBox_0.set_DropDownStyle(comboBoxStyle_0);
	}

	static void smethod_41(ListControl listControl_0, bool bool_0)
	{
		listControl_0.set_FormattingEnabled(bool_0);
	}

	static ObjectCollection smethod_42(ComboBox comboBox_0)
	{
		return comboBox_0.get_Items();
	}

	static void smethod_43(ObjectCollection objectCollection_0, object[] object_0)
	{
		objectCollection_0.AddRange(object_0);
	}

	static void smethod_44(PrintDialog printDialog_0, bool bool_0)
	{
		printDialog_0.set_UseEXDialog(bool_0);
	}

	static void smethod_45(PictureBox pictureBox_0, Image image_0)
	{
		pictureBox_0.set_Image(image_0);
	}

	static void smethod_46(PictureBox pictureBox_0, PictureBoxSizeMode pictureBoxSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		pictureBox_0.set_SizeMode(pictureBoxSizeMode_0);
	}

	static void smethod_47(PictureBox pictureBox_0, int int_0)
	{
		pictureBox_0.set_TabIndex(int_0);
	}

	static void smethod_48(PictureBox pictureBox_0, bool bool_0)
	{
		pictureBox_0.set_TabStop(bool_0);
	}

	static void smethod_49(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_50(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_51(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static ControlCollection smethod_52(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_53(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_54(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_55(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_56(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_57(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_58(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_59(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_60(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_61(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_62(DataGridView dataGridView_0, DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler_0)
	{
		dataGridView_0.remove_CellMouseClick(dataGridViewCellMouseEventHandler_0);
	}

	static void smethod_63(DataGridView dataGridView_0, DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler_0)
	{
		dataGridView_0.add_CellMouseClick(dataGridViewCellMouseEventHandler_0);
	}

	static void smethod_64(PrintDocument printDocument_0, PrintPageEventHandler printPageEventHandler_0)
	{
		printDocument_0.remove_PrintPage(printPageEventHandler_0);
	}

	static void smethod_65(PrintDocument printDocument_0, PrintPageEventHandler printPageEventHandler_0)
	{
		printDocument_0.add_PrintPage(printPageEventHandler_0);
	}

	static string smethod_66(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_67(OleDbConnection oleDbConnection_0, string string_0)
	{
		oleDbConnection_0.set_ConnectionString(string_0);
	}

	static DateTime smethod_68()
	{
		return DateAndTime.get_Today();
	}

	static string smethod_69(object object_0, string string_0)
	{
		return Strings.Format(object_0, string_0);
	}

	static int smethod_70(ObjectCollection objectCollection_0, object object_0)
	{
		return objectCollection_0.Add(object_0);
	}

	static void smethod_71(ObjectCollection objectCollection_0)
	{
		objectCollection_0.Clear();
	}

	static string smethod_72(TextBox textBox_0)
	{
		return textBox_0.get_Text();
	}

	static string smethod_73(string string_0)
	{
		return string_0.ToLower();
	}

	static DialogResult smethod_74(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}

	static OleDbCommand smethod_75()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new OleDbCommand();
	}

	static string smethod_76(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static DataTable smethod_77()
	{
		return new DataTable();
	}

	static void smethod_78(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Open();
	}

	static OleDbDataAdapter smethod_79(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbDataAdapter(string_0, oleDbConnection_0);
	}

	static int smethod_80(DbDataAdapter dbDataAdapter_0, DataTable dataTable_0)
	{
		return dbDataAdapter_0.Fill(dataTable_0);
	}

	static void smethod_81(DataGridView dataGridView_0, object object_0)
	{
		dataGridView_0.set_DataSource(object_0);
	}

	static int smethod_82(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_RowCount();
	}

	static void smethod_83(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Close();
	}

	static void smethod_84(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_85()
	{
		ProjectData.ClearProjectError();
	}

	static DateTime smethod_86(string string_0)
	{
		return Conversions.ToDate(string_0);
	}

	static int smethod_87(string string_0, string string_1, bool bool_0)
	{
		return Operators.CompareString(string_0, string_1, bool_0);
	}

	static OleDbCommand smethod_88(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbCommand(string_0, oleDbConnection_0);
	}

	static OleDbParameterCollection smethod_89(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.get_Parameters();
	}

	static string smethod_90(DateTime dateTime_0)
	{
		return Conversions.ToString(dateTime_0);
	}

	static OleDbParameter smethod_91(string string_0, object object_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbParameter(string_0, object_0);
	}

	static OleDbParameter smethod_92(OleDbParameterCollection oleDbParameterCollection_0, OleDbParameter oleDbParameter_0)
	{
		return oleDbParameterCollection_0.Add(oleDbParameter_0);
	}

	static int smethod_93(string string_0)
	{
		return Conversions.ToInteger(string_0);
	}

	static string smethod_94(ComboBox comboBox_0)
	{
		return comboBox_0.get_Text();
	}

	static string smethod_95(string string_0)
	{
		return string_0.ToString();
	}

	static int smethod_96(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.ExecuteNonQuery();
	}

	static void smethod_97(Component component_0)
	{
		component_0.Dispose();
	}

	static DialogResult smethod_98(string string_0, string string_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0, string_1);
	}

	static DataGridViewRowCollection smethod_99(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_Rows();
	}

	static int smethod_100(DataGridViewCellMouseEventArgs dataGridViewCellMouseEventArgs_0)
	{
		return dataGridViewCellMouseEventArgs_0.get_RowIndex();
	}

	static DataGridViewRow smethod_101(DataGridViewRowCollection dataGridViewRowCollection_0, int int_0)
	{
		return dataGridViewRowCollection_0.get_Item(int_0);
	}

	static DataGridViewCellCollection smethod_102(DataGridViewRow dataGridViewRow_0)
	{
		return dataGridViewRow_0.get_Cells();
	}

	static DataGridViewCell smethod_103(DataGridViewCellCollection dataGridViewCellCollection_0, int int_0)
	{
		return dataGridViewCellCollection_0.get_Item(int_0);
	}

	static object smethod_104(DataGridViewCell dataGridViewCell_0)
	{
		return dataGridViewCell_0.get_Value();
	}

	static string smethod_105(object object_0)
	{
		return Conversions.ToString(object_0);
	}

	static void smethod_106(TextBox textBox_0, string string_0)
	{
		textBox_0.set_Text(string_0);
	}

	static void smethod_107(ComboBox comboBox_0, int int_0)
	{
		comboBox_0.set_SelectedIndex(int_0);
	}

	static void smethod_108(TextBoxBase textBoxBase_0)
	{
		textBoxBase_0.Clear();
	}

	static void smethod_109(PrintDialog printDialog_0, PrintDocument printDocument_0)
	{
		printDialog_0.set_Document(printDocument_0);
	}

	static PrinterSettings smethod_110(PrintDocument printDocument_0)
	{
		return printDocument_0.get_PrinterSettings();
	}

	static void smethod_111(PrintDialog printDialog_0, PrinterSettings printerSettings_0)
	{
		printDialog_0.set_PrinterSettings(printerSettings_0);
	}

	static void smethod_112(PrintDialog printDialog_0, bool bool_0)
	{
		printDialog_0.set_AllowSomePages(bool_0);
	}

	static DialogResult smethod_113(CommonDialog commonDialog_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return commonDialog_0.ShowDialog();
	}

	static PrinterSettings smethod_114(PrintDialog printDialog_0)
	{
		return printDialog_0.get_PrinterSettings();
	}

	static void smethod_115(PrintDocument printDocument_0, PrinterSettings printerSettings_0)
	{
		printDocument_0.set_PrinterSettings(printerSettings_0);
	}

	static void smethod_116(PrintDocument printDocument_0)
	{
		printDocument_0.Print();
	}

	static bool smethod_117(Control control_0)
	{
		return control_0.get_Visible();
	}

	static Font smethod_118(string string_0, float float_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new Font(string_0, float_0);
	}

	static Graphics smethod_119(PrintPageEventArgs printPageEventArgs_0)
	{
		return printPageEventArgs_0.get_Graphics();
	}

	static Brush smethod_120()
	{
		return Brushes.get_Chocolate();
	}

	static void smethod_121(Graphics graphics_0, string string_0, Font font_0, Brush brush_0, float float_0, float float_1)
	{
		graphics_0.DrawString(string_0, font_0, brush_0, float_0, float_1);
	}

	static void smethod_122(Control control_0)
	{
		control_0.Show();
	}

	static string smethod_123(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static OleDbDataReader smethod_124(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.ExecuteReader();
	}

	static object smethod_125(OleDbDataReader oleDbDataReader_0, int int_0)
	{
		return oleDbDataReader_0.get_Item(int_0);
	}

	static string smethod_126(object object_0)
	{
		return object_0.ToString();
	}

	static void smethod_127(ComboBox comboBox_0, string string_0)
	{
		comboBox_0.set_Text(string_0);
	}

	static bool smethod_128(OleDbDataReader oleDbDataReader_0)
	{
		return oleDbDataReader_0.Read();
	}

	static string smethod_129(Exception exception_0)
	{
		return exception_0.Message;
	}

	static bool smethod_130(OleDbDataReader oleDbDataReader_0)
	{
		return oleDbDataReader_0.get_HasRows();
	}

	static int smethod_131(ComboBox comboBox_0)
	{
		return comboBox_0.get_SelectedIndex();
	}
}
