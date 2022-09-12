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
			Button searchBtn = default(Button);
			while (true)
			{
				int num = 1626488586;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6FA8550Fu) % 7u)
					{
					case 6u:
						Admit.smethod_60((Control)(object)searchBtn, eventHandler_);
						num = ((int)num2 * -718169038) ^ -1020511200;
						continue;
					case 5u:
						Admit.smethod_61((Control)(object)searchBtn, eventHandler_);
						num = (int)((num2 * 2028803883) ^ 0x3354E194);
						continue;
					case 3u:
					{
						int num5;
						int num6;
						if (searchBtn == null)
						{
							num5 = 2128458838;
							num6 = 2128458838;
						}
						else
						{
							num5 = 733572197;
							num6 = 733572197;
						}
						num = num5 ^ ((int)num2 * -2068959101);
						continue;
					}
					case 2u:
						_SearchBtn = value;
						searchBtn = _SearchBtn;
						num = 1587436989;
						continue;
					case 1u:
					{
						searchBtn = _SearchBtn;
						int num3;
						int num4;
						if (searchBtn != null)
						{
							num3 = 1791801050;
							num4 = 1791801050;
						}
						else
						{
							num3 = 1937233548;
							num4 = 1937233548;
						}
						num = num3 ^ ((int)num2 * -1443082614);
						continue;
					}
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
			DataGridView searchResultGrid = default(DataGridView);
			while (true)
			{
				int num = 123006915;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x47D6E4A9u) % 7u)
					{
					case 6u:
						_SearchResultGrid = value;
						searchResultGrid = _SearchResultGrid;
						num = 964744807;
						continue;
					case 5u:
					{
						searchResultGrid = _SearchResultGrid;
						int num5;
						int num6;
						if (searchResultGrid == null)
						{
							num5 = -1330251589;
							num6 = -1330251589;
						}
						else
						{
							num5 = -232432867;
							num6 = -232432867;
						}
						num = num5 ^ ((int)num2 * -11079618);
						continue;
					}
					case 4u:
					{
						int num3;
						int num4;
						if (searchResultGrid != null)
						{
							num3 = -1959675034;
							num4 = -1959675034;
						}
						else
						{
							num3 = -1034720326;
							num4 = -1034720326;
						}
						num = num3 ^ ((int)num2 * -1583954698);
						continue;
					}
					case 3u:
						Admit.smethod_63(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = (int)((num2 * 288872769) ^ 0x257985B5);
						continue;
					case 1u:
						Admit.smethod_62(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = (int)((num2 * 971658452) ^ 0x3556F8F7);
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
				int num = -103229116;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC76227F2u) % 8u)
					{
					case 7u:
						_ClearBtn = value;
						num = -1330844536;
						continue;
					case 6u:
						clearBtn = _ClearBtn;
						num = (int)((num2 * 717005715) ^ 0xA69E71B);
						continue;
					case 4u:
						Admit.smethod_60((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -1084689488) ^ 0x2BD9A07D;
						continue;
					case 3u:
					{
						int num5;
						int num6;
						if (clearBtn == null)
						{
							num5 = 1906014127;
							num6 = 1906014127;
						}
						else
						{
							num5 = 1814162404;
							num6 = 1814162404;
						}
						num = num5 ^ ((int)num2 * -1403727946);
						continue;
					}
					case 2u:
					{
						clearBtn = _ClearBtn;
						int num3;
						int num4;
						if (clearBtn == null)
						{
							num3 = 442690157;
							num4 = 442690157;
						}
						else
						{
							num3 = 1598501977;
							num4 = 1598501977;
						}
						num = num3 ^ ((int)num2 * -1755350435);
						continue;
					}
					case 1u:
						Admit.smethod_61((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -722565349) ^ -1929529220;
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
				int num = 527902244;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2BD9AF60u) % 7u)
					{
					case 6u:
						Admit.smethod_61((Control)(object)printBtn, eventHandler_);
						num = (int)(num2 * 523361024) ^ -1368611012;
						continue;
					case 3u:
					{
						int num4;
						int num5;
						if (printBtn == null)
						{
							num4 = 1258008118;
							num5 = 1258008118;
						}
						else
						{
							num4 = 1634971690;
							num5 = 1634971690;
						}
						num = num4 ^ (int)(num2 * 2050874078);
						continue;
					}
					case 2u:
					{
						_PrintBtn = value;
						printBtn = _PrintBtn;
						int num3;
						if (printBtn == null)
						{
							num = 422065724;
							num3 = 422065724;
						}
						else
						{
							num = 1640501859;
							num3 = 1640501859;
						}
						continue;
					}
					case 1u:
						printBtn = _PrintBtn;
						num = ((int)num2 * -608604768) ^ -1864421112;
						continue;
					case 0u:
						Admit.smethod_60((Control)(object)printBtn, eventHandler_);
						num = (int)((num2 * 2093103119) ^ 0xC2EA620);
						continue;
					default:
						return;
					case 5u:
						break;
					case 4u:
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
				int num = 1151452834;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7FA03BE2u) % 6u)
					{
					case 5u:
						Admit.smethod_60((Control)(object)saveBtn, eventHandler_);
						num = (int)((num2 * 2069787387) ^ 0x61A4BC15);
						continue;
					case 3u:
						Admit.smethod_61((Control)(object)saveBtn, eventHandler_);
						num = (int)(num2 * 709351316) ^ -491228387;
						continue;
					case 2u:
					{
						int num4;
						int num5;
						if (saveBtn == null)
						{
							num4 = 425951792;
							num5 = 425951792;
						}
						else
						{
							num4 = 322869437;
							num5 = 322869437;
						}
						num = num4 ^ (int)(num2 * 1770323787);
						continue;
					}
					case 0u:
					{
						_SaveBtn = value;
						saveBtn = _SaveBtn;
						int num3;
						if (saveBtn != null)
						{
							num = 698518745;
							num3 = 698518745;
						}
						else
						{
							num = 1651050497;
							num3 = 1651050497;
						}
						continue;
					}
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
			PrintDocument printDocument = _PrintDocument1;
			if (printDocument != null)
			{
				goto IL_0048;
			}
			goto IL_00b4;
			IL_00b4:
			_PrintDocument1 = value;
			int num = 1039757403;
			goto IL_0087;
			IL_0087:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x467AEC0Au) % 7u)
				{
				case 6u:
					Admit.smethod_64(printDocument, printPageEventHandler_);
					num = (int)((num2 * 1045443286) ^ 0x5E96D6E9);
					continue;
				case 5u:
					printDocument = _PrintDocument1;
					num = ((int)num2 * -1472609172) ^ -999877286;
					continue;
				case 3u:
					break;
				case 2u:
					Admit.smethod_65(printDocument, printPageEventHandler_);
					num = (int)((num2 * 932750454) ^ 0x6AE437D3);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (printDocument == null)
					{
						num3 = 1905660153;
						num4 = 1905660153;
					}
					else
					{
						num3 = 1155610737;
						num4 = 1155610737;
					}
					num = num3 ^ ((int)num2 * -1498630394);
					continue;
				}
				default:
					return;
				case 0u:
					goto IL_00b4;
				case 4u:
					return;
				}
				break;
			}
			goto IL_0048;
			IL_0048:
			num = 1407200307;
			goto IL_0087;
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
			Button historyBtn = default(Button);
			while (true)
			{
				int num = 974191374;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD03A30Au) % 7u)
					{
					case 6u:
						Admit.smethod_60((Control)(object)historyBtn, eventHandler_);
						num = (int)(num2 * 1300364618) ^ -1916165057;
						continue;
					case 5u:
					{
						historyBtn = _HistoryBtn;
						int num5;
						int num6;
						if (historyBtn != null)
						{
							num5 = 1753453713;
							num6 = 1753453713;
						}
						else
						{
							num5 = 2136073108;
							num6 = 2136073108;
						}
						num = num5 ^ (int)(num2 * 113711562);
						continue;
					}
					case 4u:
						Admit.smethod_61((Control)(object)historyBtn, eventHandler_);
						num = (int)((num2 * 635710016) ^ 0x7BECB486);
						continue;
					case 3u:
						_HistoryBtn = value;
						num = 1816053375;
						continue;
					case 1u:
					{
						historyBtn = _HistoryBtn;
						int num3;
						int num4;
						if (historyBtn != null)
						{
							num3 = 158245591;
							num4 = 158245591;
						}
						else
						{
							num3 = 4075173;
							num4 = 4075173;
						}
						num = num3 ^ (int)(num2 * 1133597570);
						continue;
					}
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
			Button admitDischargeBtn = _AdmitDischargeBtn;
			while (true)
			{
				int num = 1311552006;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1032E9E5u) % 6u)
					{
					case 5u:
						Admit.smethod_61((Control)(object)admitDischargeBtn, eventHandler_);
						num = ((int)num2 * -2012133403) ^ -1317225538;
						continue;
					case 4u:
					{
						_AdmitDischargeBtn = value;
						admitDischargeBtn = _AdmitDischargeBtn;
						int num5;
						if (admitDischargeBtn == null)
						{
							num = 1376035249;
							num5 = 1376035249;
						}
						else
						{
							num = 687127302;
							num5 = 687127302;
						}
						continue;
					}
					case 3u:
						Admit.smethod_60((Control)(object)admitDischargeBtn, eventHandler_);
						num = (int)((num2 * 571426604) ^ 0x4A4F35AD);
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (admitDischargeBtn == null)
						{
							num3 = -1879298019;
							num4 = -1879298019;
						}
						else
						{
							num3 = -1150059636;
							num4 = -1150059636;
						}
						num = num3 ^ ((int)num2 * -300076124);
						continue;
					}
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
		while (true)
		{
			int num = 106758806;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x21FADF74u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -275493387) ^ -1958064357;
					continue;
				case 1u:
					Admit.smethod_0((UserControl)(object)this, (EventHandler)Admit_Load);
					num = ((int)num2 * -1254627280) ^ -1122946356;
					continue;
				case 3u:
					break;
				default:
					myconnection = Admit.smethod_1();
					InitializeComponent();
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
				int num = 1545072968;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xBA1080Du) % 9u)
					{
					case 8u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = 693245774;
							num5 = 693245774;
						}
						else
						{
							num4 = 1943222265;
							num5 = 1943222265;
						}
						num = num4 ^ (int)(num2 * 1877404123);
						continue;
					}
					case 7u:
						Admit.smethod_2((IDisposable)components);
						num = ((int)num2 * -196069994) ^ -1801966223;
						continue;
					case 6u:
						num = ((int)num2 * -946366823) ^ -250102009;
						continue;
					case 5u:
						if (disposing)
						{
							num = (int)((num2 * 1813047403) ^ 0x472A6BF9);
							continue;
						}
						num3 = 0;
						goto IL_0067;
					case 4u:
						num3 = ((components != null) ? 1 : 0);
						goto IL_0067;
					case 2u:
						num = ((int)num2 * -1776069987) ^ -768210281;
						continue;
					case 1u:
						num = 1336935596;
						continue;
					default:
						return;
					case 3u:
						break;
					case 0u:
						return;
						IL_0067:
						flag = (byte)num3 != 0;
						num = 813630766;
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
				IL_0101:
				int num6 = 337688175;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num6 ^ 0xBA1080Du) % 3u)
					{
					case 1u:
						goto IL_00d0;
					default:
						goto end_IL_00e4;
					case 0u:
						break;
					case 2u:
						goto end_IL_00e4;
					}
					goto IL_0101;
					IL_00d0:
					((ContainerControl)this).Dispose(disposing);
					num6 = (int)((num2 * 1095364198) ^ 0xA00E38D);
					continue;
					end_IL_00e4:
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
			int num = -938188649;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC0560C2Fu) % 497u)
				{
				case 496u:
					num = (int)((num2 * 784616745) ^ 0x4A1598AE);
					continue;
				case 495u:
					Admit.smethod_39(AddressTxt, bool_0: true);
					Admit.smethod_19((Control)(object)AddressTxt, "AddressTxt");
					num = (int)(num2 * 1408551240) ^ -710811749;
					continue;
				case 494u:
					Admit.smethod_31((ButtonBase)(object)AdmitDischargeBtn, bool_0: false);
					num = ((int)num2 * -952297478) ^ -1473238190;
					continue;
				case 493u:
					Admit.smethod_21((Control)(object)SearchBtn, 4);
					Admit.smethod_30((ButtonBase)(object)SearchBtn, "Search");
					num = (int)(num2 * 294322829) ^ -178326631;
					continue;
				case 492u:
					Admit.smethod_21((Control)(object)DateOut1Txt, 14);
					num = (int)((num2 * 1741927230) ^ 0x28575510);
					continue;
				case 491u:
					GroupBox1 = Admit.smethod_4();
					num = (int)(num2 * 848677522) ^ -569324634;
					continue;
				case 490u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)HistoryBtn);
					num = ((int)num2 * -1007501174) ^ -1958516551;
					continue;
				case 489u:
					Admit.smethod_17((Control)(object)Label4, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 553596334) ^ -688299982;
					continue;
				case 488u:
					Admit.smethod_18((Control)(object)GenderTxt, new Point(322, 152));
					num = ((int)num2 * -1109244705) ^ -700962797;
					continue;
				case 487u:
					Admit.smethod_29((Control)(object)ClearBtn, Color.White);
					num = ((int)num2 * -157710756) ^ -1800785856;
					continue;
				case 486u:
					Admit.smethod_22(Label15, "Mobile :");
					num = ((int)num2 * -1462310014) ^ 0x7158F985;
					continue;
				case 485u:
					num = ((int)num2 * -1316935536) ^ 0x52209C5C;
					continue;
				case 484u:
					Admit.smethod_18((Control)(object)GroupBox1, new Point(155, 150));
					num = (int)((num2 * 903173761) ^ 0xB35E852);
					continue;
				case 483u:
					num = (int)(num2 * 1798370904) ^ -1345531155;
					continue;
				case 482u:
					num = (int)(num2 * 958928323) ^ -178936495;
					continue;
				case 481u:
					Admit.smethod_17((Control)(object)AdmitDischargeBtn, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -724605371) ^ 0x5B849EF5;
					continue;
				case 480u:
					Admit.smethod_19((Control)(object)StatusTxt, "StatusTxt");
					Admit.smethod_20((Control)(object)StatusTxt, new Size(136, 30));
					num = ((int)num2 * -448362957) ^ 0x96ACA77;
					continue;
				case 479u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)GroupBox1), (Control)(object)SearchBtn);
					Admit.smethod_25(Admit.smethod_24((Control)(object)GroupBox1), (Control)(object)Label3);
					num = ((int)num2 * -1980919420) ^ -1357623104;
					continue;
				case 478u:
					Admit.smethod_19((Control)(object)PIDTxt, "PIDTxt");
					num = ((int)num2 * -861293958) ^ 0x60AF67E6;
					continue;
				case 477u:
					Admit.smethod_21((Control)(object)Label5, 1);
					num = ((int)num2 * -620928616) ^ 0x55724E10;
					continue;
				case 476u:
					Admit.smethod_28((ButtonBase)(object)SearchBtn, Color.MidnightBlue);
					num = (int)((num2 * 877325584) ^ 0xF62406E);
					continue;
				case 475u:
					Admit.smethod_28((ButtonBase)(object)SaveBtn, Color.MidnightBlue);
					Admit.smethod_17((Control)(object)SaveBtn, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 182953795) ^ 0x2923341A);
					continue;
				case 474u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)GroupBox1), (Control)(object)MobileTxt);
					Admit.smethod_25(Admit.smethod_24((Control)(object)GroupBox1), (Control)(object)NameSTxt);
					num = (int)((num2 * 1863461345) ^ 0x7359E1A6);
					continue;
				case 473u:
					num = ((int)num2 * -1275585719) ^ 0x46AB791D;
					continue;
				case 472u:
					Admit.smethod_17((Control)(object)Label11, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -414996874) ^ 0x60349DBF;
					continue;
				case 471u:
					Admit.smethod_18((Control)(object)NameTxt, new Point(96, 77));
					num = ((int)num2 * -1509953529) ^ -1275576801;
					continue;
				case 470u:
					num = ((int)num2 * -103551759) ^ 0x830BC23;
					continue;
				case 469u:
					Admit.smethod_29((Control)(object)AdmitDischargeBtn, Color.White);
					num = ((int)num2 * -1542569660) ^ 0x168B28E1;
					continue;
				case 468u:
					AgeTxt = Admit.smethod_6();
					num = (int)((num2 * 1545997844) ^ 0x1099A347);
					continue;
				case 467u:
					num = (int)((num2 * 260782956) ^ 0xAE5B852);
					continue;
				case 466u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)DateInTxt);
					num = (int)((num2 * 685667739) ^ 0x5A883227);
					continue;
				case 465u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)Label5);
					num = (int)(num2 * 1631205306) ^ -229925632;
					continue;
				case 464u:
					Admit.smethod_38((TextBoxBase)(object)GenderTxt, bool_0: true);
					Admit.smethod_20((Control)(object)GenderTxt, new Size(100, 28));
					num = ((int)num2 * -56030961) ^ 0x2544583;
					continue;
				case 463u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)Label10);
					num = ((int)num2 * -352462705) ^ -1109650489;
					continue;
				case 462u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)Label14);
					num = ((int)num2 * -2073243555) ^ 0x7A98A707;
					continue;
				case 461u:
					Admit.smethod_38((TextBoxBase)(object)MobileSTxt, bool_0: true);
					num = ((int)num2 * -564925265) ^ -991462667;
					continue;
				case 460u:
					num = (int)((num2 * 1651013617) ^ 0x73FB3C86);
					continue;
				case 459u:
					num = (int)((num2 * 81335282) ^ 0x73F4ED8F);
					continue;
				case 458u:
					num = (int)((num2 * 1619474772) ^ 0x251946B9);
					continue;
				case 457u:
					Admit.smethod_19((Control)(object)PrintBtn, "PrintBtn");
					num = (int)(num2 * 638740878) ^ -1901000548;
					continue;
				case 456u:
					num = (int)((num2 * 1788083502) ^ 0x674A51EE);
					continue;
				case 455u:
					Admit.smethod_48(PictureBox1, bool_0: false);
					num = ((int)num2 * -1689979894) ^ -194362254;
					continue;
				case 454u:
					Admit.smethod_20((Control)(object)DateOut1Txt, new Size(181, 28));
					num = (int)((num2 * 1844570122) ^ 0x6FE04DFC);
					continue;
				case 453u:
					Admit.smethod_45(PictureBox1, (Image)(object)Resources.medical_bed_icon);
					num = ((int)num2 * -1072333617) ^ 0x5B3DA61A;
					continue;
				case 452u:
					num = (int)(num2 * 615674441) ^ -400341744;
					continue;
				case 451u:
					Admit.smethod_20((Control)(object)Label5, new Size(68, 26));
					num = ((int)num2 * -125955567) ^ 0x34AA98CC;
					continue;
				case 450u:
					num = ((int)num2 * -1986340838) ^ 0x176589E7;
					continue;
				case 449u:
					Admit.smethod_21((Control)(object)Label9, 2);
					num = ((int)num2 * -488906841) ^ 0x586D7101;
					continue;
				case 448u:
					Admit.smethod_20((Control)(object)PrintBtn, new Size(101, 37));
					num = ((int)num2 * -1045330617) ^ -984802147;
					continue;
				case 447u:
					MobileTxt = Admit.smethod_6();
					NameSTxt = Admit.smethod_6();
					Label2 = Admit.smethod_3();
					num = (int)(num2 * 555502288) ^ -32879013;
					continue;
				case 446u:
					Admit.smethod_18((Control)(object)MobileTxt, new Point(120, 86));
					Admit.smethod_19((Control)(object)MobileTxt, "MobileTxt");
					num = (int)(num2 * 1665251599) ^ -1591069436;
					continue;
				case 445u:
					Admit.smethod_38((TextBoxBase)(object)RoomType1Txt, bool_0: true);
					Admit.smethod_20((Control)(object)RoomType1Txt, new Size(181, 28));
					Admit.smethod_21((Control)(object)RoomType1Txt, 21);
					num = ((int)num2 * -698776242) ^ 0x5152764F;
					continue;
				case 444u:
					Admit.smethod_19((Control)(object)Label10, "Label10");
					num = (int)(num2 * 1767769631) ^ -1581919604;
					continue;
				case 443u:
					Admit.smethod_31((ButtonBase)(object)PrintBtn, bool_0: false);
					num = ((int)num2 * -118288889) ^ 0xA265C4F;
					continue;
				case 442u:
					Admit.smethod_37((Control)(object)PatientInfoBox, bool_0: false);
					num = ((int)num2 * -2142771254) ^ 0x4B1EF914;
					continue;
				case 441u:
					Admit.smethod_47(PictureBox1, 2);
					num = ((int)num2 * -1866546843) ^ 0x1CC833F5;
					continue;
				case 440u:
					Admit.smethod_20((Control)(object)PictureBox1, new Size(126, 122));
					num = (int)(num2 * 1504076983) ^ -982339595;
					continue;
				case 439u:
					num = (int)(num2 * 1293262829) ^ -1422781528;
					continue;
				case 438u:
					num = (int)(num2 * 1469173171) ^ -474492295;
					continue;
				case 437u:
					num = ((int)num2 * -1218947460) ^ 0x2AEDBC66;
					continue;
				case 436u:
					num = (int)(num2 * 870378574) ^ -515622248;
					continue;
				case 435u:
					Admit.smethod_29((Control)(object)SearchBtn, Color.White);
					num = (int)(num2 * 1634104633) ^ -873691744;
					continue;
				case 434u:
					Admit.smethod_19((Control)(object)NameSTxt, "NameSTxt");
					Admit.smethod_20((Control)(object)NameSTxt, new Size(237, 28));
					num = (int)((num2 * 55581800) ^ 0x73B12682);
					continue;
				case 433u:
					Admit.smethod_23(Label9, (ContentAlignment)32);
					num = ((int)num2 * -1792683032) ^ 0xA99F5FE;
					continue;
				case 432u:
					num = ((int)num2 * -1126003722) ^ 0x2F0C4900;
					continue;
				case 431u:
					num = ((int)num2 * -753932906) ^ 0x5EB2E724;
					continue;
				case 430u:
					num = ((int)num2 * -1299772473) ^ 0x48D35DA7;
					continue;
				case 429u:
					Admit.smethod_18((Control)(object)DateInTxt, new Point(161, 111));
					num = (int)(num2 * 556535258) ^ -472953657;
					continue;
				case 428u:
					Admit.smethod_18((Control)(object)PrintBtn, new Point(655, 746));
					num = ((int)num2 * -1756677286) ^ 0x10D35CE2;
					continue;
				case 427u:
					num = ((int)num2 * -811107951) ^ 0x6631203E;
					continue;
				case 426u:
					num = (int)((num2 * 187510028) ^ 0x19699BDB);
					continue;
				case 425u:
					num = (int)((num2 * 1776548647) ^ 0x7D73D69F);
					continue;
				case 424u:
					Admit.smethod_21((Control)(object)Label15, 10);
					num = ((int)num2 * -1669128151) ^ 0x36C043D;
					continue;
				case 423u:
					Admit.smethod_21((Control)(object)Label2, 0);
					num = (int)((num2 * 613550875) ^ 0x1DABCCB6);
					continue;
				case 422u:
					RoomTypeTxt = Admit.smethod_8();
					DateOutTxt = Admit.smethod_8();
					num = (int)((num2 * 969491536) ^ 0x6C38F87C);
					continue;
				case 421u:
					Admit.smethod_19((Control)(object)NameTxt, "NameTxt");
					num = ((int)num2 * -313989124) ^ 0x5F4D703C;
					continue;
				case 420u:
					Admit.smethod_13((ISupportInitialize)SearchResultGrid);
					num = ((int)num2 * -1035342167) ^ 0x2047760B;
					continue;
				case 419u:
					Admit.smethod_21((Control)(object)NameTxt, 9);
					num = (int)(num2 * 1338579712) ^ -1058388255;
					continue;
				case 418u:
					Admit.smethod_19((Control)(object)Label15, "Label15");
					Admit.smethod_20((Control)(object)Label15, new Size(77, 26));
					num = ((int)num2 * -569381216) ^ 0xFC3A0CF;
					continue;
				case 417u:
					Admit.smethod_27(PatientInfoBox, "Patient Information");
					num = (int)(num2 * 1665365152) ^ -1804485054;
					continue;
				case 416u:
					Admit.smethod_18((Control)(object)Label11, new Point(184, 201));
					num = ((int)num2 * -1416433917) ^ -977321496;
					continue;
				case 415u:
					Admit.smethod_41((ListControl)(object)RoomTypeTxt, bool_0: true);
					num = (int)((num2 * 455689276) ^ 0x3B5AFEC4);
					continue;
				case 414u:
					Admit.smethod_20((Control)(object)Label8, new Size(101, 25));
					num = (int)(num2 * 1127303979) ^ -1128785010;
					continue;
				case 413u:
					num = ((int)num2 * -294357310) ^ -912319879;
					continue;
				case 412u:
					Admit.smethod_55((Control)(object)PatientInfoBox, bool_0: false);
					num = (int)((num2 * 660684835) ^ 0xF2CA9D0);
					continue;
				case 411u:
					Admit.smethod_18((Control)(object)RoomTypeTxt, new Point(161, 71));
					num = (int)((num2 * 1858681399) ^ 0x61B06D03);
					continue;
				case 410u:
					AdmitDetailsBox = Admit.smethod_4();
					num = ((int)num2 * -574532372) ^ 0x1B714C03;
					continue;
				case 409u:
					Admit.smethod_21((Control)(object)DateIn1Txt, 13);
					num = ((int)num2 * -1234031183) ^ -391452079;
					continue;
				case 408u:
					num = ((int)num2 * -390379749) ^ 0x21FC06AD;
					continue;
				case 407u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)PIDTxt);
					num = ((int)num2 * -713367956) ^ -1010585714;
					continue;
				case 406u:
					Admit.smethod_20((Control)(object)AddressTxt, new Size(298, 90));
					num = ((int)num2 * -988783988) ^ -389951647;
					continue;
				case 405u:
					Admit.smethod_20((Control)(object)AdmitDischargeBtn, new Size(181, 45));
					num = ((int)num2 * -54432228) ^ 0x8D22BA;
					continue;
				case 404u:
					SearchBtn = Admit.smethod_5();
					num = (int)((num2 * 542711381) ^ 0x6E231DD);
					continue;
				case 403u:
					Admit.smethod_19((Control)(object)Label2, "Label2");
					num = (int)((num2 * 1118541213) ^ 0x35BED30D);
					continue;
				case 402u:
					Admit.smethod_19((Control)(object)Label4, "Label4");
					num = (int)(num2 * 1393114314) ^ -1585126535;
					continue;
				case 401u:
					Admit.smethod_19((Control)(object)SearchResultGrid, "SearchResultGrid");
					num = (int)((num2 * 2055548160) ^ 0x20A53E5E);
					continue;
				case 400u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)RoomNoTxt);
					num = (int)(num2 * 1559915837) ^ -510070314;
					continue;
				case 399u:
					num = ((int)num2 * -644588) ^ -1517143929;
					continue;
				case 398u:
					Admit.smethod_18((Control)(object)Label2, new Point(37, 44));
					num = ((int)num2 * -464354851) ^ 0x70EDC248;
					continue;
				case 397u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)RoomTypeTxt);
					num = ((int)num2 * -5360007) ^ -1060572039;
					continue;
				case 396u:
					Admit.smethod_20((Control)(object)Label2, new Size(77, 28));
					num = ((int)num2 * -2126013449) ^ -1163552265;
					continue;
				case 395u:
					Admit.smethod_41((ListControl)(object)StatusTxt, bool_0: true);
					num = (int)(num2 * 1878319948) ^ -849595251;
					continue;
				case 394u:
					SearchResultGrid = Admit.smethod_7();
					num = (int)(num2 * 1612110509) ^ -27705586;
					continue;
				case 393u:
					num = (int)((num2 * 608193063) ^ 0x6EB491E1);
					continue;
				case 392u:
					Admit.smethod_21((Control)(object)SearchResultGrid, 6);
					num = (int)(num2 * 1030533481) ^ -1694053320;
					continue;
				case 391u:
					Admit.smethod_21((Control)(object)RoomNoTxt, 19);
					num = ((int)num2 * -2101916838) ^ 0x58AD07E5;
					continue;
				case 390u:
					Admit.smethod_28((ButtonBase)(object)PrintBtn, Color.MidnightBlue);
					num = (int)((num2 * 2016967694) ^ 0x4AD372E4);
					continue;
				case 389u:
					Admit.smethod_38((TextBoxBase)(object)RoomNo1Txt, bool_0: true);
					Admit.smethod_20((Control)(object)RoomNo1Txt, new Size(141, 28));
					num = (int)(num2 * 1090749400) ^ -412933944;
					continue;
				case 388u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)Label12);
					num = ((int)num2 * -298242239) ^ 0x1F4D42D5;
					continue;
				case 387u:
					num = (int)(num2 * 618909719) ^ -1520146620;
					continue;
				case 386u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)AgeTxt);
					num = (int)(num2 * 1231904217) ^ -1868163609;
					continue;
				case 385u:
					PatientInfoBox = Admit.smethod_4();
					num = ((int)num2 * -752242690) ^ 0x1623C9CC;
					continue;
				case 384u:
					num = (int)(num2 * 62161798) ^ -311177262;
					continue;
				case 383u:
					Admit.smethod_21((Control)(object)Label1, 3);
					Admit.smethod_22(Label1, "Admit And Discharge ");
					num = (int)((num2 * 1958758967) ^ 0x21A1FF08);
					continue;
				case 382u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)NameTxt);
					num = ((int)num2 * -330501959) ^ 0x2E9A4291;
					continue;
				case 381u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)Label7);
					num = (int)(num2 * 117677646) ^ -101580041;
					continue;
				case 380u:
					Admit.smethod_51((Control)(object)this, Color.White);
					num = ((int)num2 * -1136297498) ^ -1411145227;
					continue;
				case 379u:
					Admit.smethod_31((ButtonBase)(object)SaveBtn, bool_0: false);
					num = ((int)num2 * -351734330) ^ 0x1A742708;
					continue;
				case 378u:
					Label1 = Admit.smethod_3();
					num = ((int)num2 * -155189210) ^ 0x3604D56;
					continue;
				case 377u:
					Admit.smethod_19((Control)(object)Label7, "Label7");
					num = (int)((num2 * 550363793) ^ 0x67F05E3);
					continue;
				case 376u:
					num = (int)((num2 * 1783416487) ^ 0x7E10AA97);
					continue;
				case 375u:
					num = ((int)num2 * -1790488695) ^ -1504382875;
					continue;
				case 374u:
					Admit.smethod_23(Label12, (ContentAlignment)32);
					num = ((int)num2 * -1417531749) ^ 0x33726E5F;
					continue;
				case 373u:
					Admit.smethod_22(Label9, "Room Type :");
					num = ((int)num2 * -1524556701) ^ 0x6002D379;
					continue;
				case 372u:
					num = (int)(num2 * 210569158) ^ -1646839866;
					continue;
				case 371u:
					num = (int)(num2 * 1822644329) ^ -421128161;
					continue;
				case 370u:
					num = ((int)num2 * -2057411613) ^ -1673008562;
					continue;
				case 369u:
					num = (int)((num2 * 1946522504) ^ 0x5BD9B9BF);
					continue;
				case 368u:
					num = (int)(num2 * 1643996446) ^ -90446363;
					continue;
				case 367u:
					num = (int)(num2 * 794095255) ^ -1076186715;
					continue;
				case 366u:
					Admit.smethod_22(Label13, "Date Out  :");
					num = (int)((num2 * 1079683141) ^ 0x10FC043C);
					continue;
				case 365u:
					Admit.smethod_12((Control)(object)PatientInfoBox);
					num = (int)(num2 * 1104455965) ^ -1418951352;
					continue;
				case 364u:
					Admit.smethod_19((Control)(object)GenderTxt, "GenderTxt");
					num = ((int)num2 * -1110012188) ^ -1370243877;
					continue;
				case 363u:
					Admit.smethod_29((Control)(object)SaveBtn, Color.White);
					Admit.smethod_18((Control)(object)SaveBtn, new Point(814, 746));
					num = (int)((num2 * 1514750601) ^ 0xBDF076A);
					continue;
				case 362u:
					Admit.smethod_40(DateInTxt, (ComboBoxStyle)2);
					num = (int)((num2 * 177680381) ^ 0x36A9E9BD);
					continue;
				case 361u:
					Admit.smethod_20((Control)(object)RoomTypeTxt, new Size(181, 27));
					num = ((int)num2 * -1142887190) ^ 0x4C743794;
					continue;
				case 360u:
					Admit.smethod_19((Control)(object)Label3, "Label3");
					Admit.smethod_20((Control)(object)Label3, new Size(77, 28));
					num = ((int)num2 * -1018431486) ^ 0x7FBD52B3;
					continue;
				case 359u:
					num = (int)((num2 * 1707516549) ^ 0x1A6627BB);
					continue;
				case 358u:
					num = (int)((num2 * 1675549523) ^ 0x4DEFC8F2);
					continue;
				case 357u:
					num = ((int)num2 * -118748365) ^ 0xCA1408C;
					continue;
				case 356u:
					Admit.smethod_22(Label2, "Name : ");
					num = (int)((num2 * 1238845716) ^ 0x701B42FD);
					continue;
				case 355u:
					Admit.smethod_30((ButtonBase)(object)ClearBtn, "Clear");
					num = ((int)num2 * -943629293) ^ 0x721D263F;
					continue;
				case 354u:
					num = ((int)num2 * -317662704) ^ -123870361;
					continue;
				case 353u:
					num = ((int)num2 * -814926682) ^ 0x79BCEC0C;
					continue;
				case 352u:
					Admit.smethod_23(Label13, (ContentAlignment)32);
					num = (int)(num2 * 1288849690) ^ -770041483;
					continue;
				case 351u:
					Admit.smethod_21((Control)(object)RoomTypeTxt, 18);
					num = ((int)num2 * -913194655) ^ -1851440490;
					continue;
				case 350u:
					Admit.smethod_22(Label12, "Date In  :");
					num = ((int)num2 * -961887725) ^ -1881272981;
					continue;
				case 349u:
					Admit.smethod_18((Control)(object)SearchBtn, new Point(468, 82));
					num = (int)(num2 * 1376317182) ^ -799442908;
					continue;
				case 348u:
					Admit.smethod_19((Control)(object)DateInTxt, "DateInTxt");
					num = (int)((num2 * 1855676587) ^ 0x78D2C3A2);
					continue;
				case 347u:
					Admit.smethod_14((Control)(object)this);
					num = ((int)num2 * -1097142740) ^ -1786152323;
					continue;
				case 346u:
					Admit.smethod_18((Control)(object)AdmitDischargeBtn, new Point(784, 220));
					Admit.smethod_19((Control)(object)AdmitDischargeBtn, "AdmitDischargeBtn");
					num = ((int)num2 * -1320406167) ^ -983135718;
					continue;
				case 345u:
					num = (int)((num2 * 386097516) ^ 0x181AC9EC);
					continue;
				case 344u:
					Admit.smethod_38((TextBoxBase)(object)NameTxt, bool_0: true);
					Admit.smethod_20((Control)(object)NameTxt, new Size(326, 28));
					num = ((int)num2 * -1787434473) ^ 0x8CB9302;
					continue;
				case 343u:
					Admit.smethod_37((Control)(object)RoomNo1Txt, bool_0: false);
					num = (int)(num2 * 1636297210) ^ -1549942700;
					continue;
				case 342u:
					num = (int)((num2 * 749510989) ^ 0x942E541);
					continue;
				case 341u:
					Admit.smethod_18((Control)(object)Label12, new Point(18, 111));
					num = (int)(num2 * 1411088531) ^ -562776808;
					continue;
				case 340u:
					Admit.smethod_20((Control)(object)MobileSTxt, new Size(253, 28));
					Admit.smethod_21((Control)(object)MobileSTxt, 11);
					num = ((int)num2 * -2052191673) ^ 0x7DC8BA62;
					continue;
				case 339u:
					Admit.smethod_17((Control)(object)Label14, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Admit.smethod_18((Control)(object)Label14, new Point(13, 80));
					num = (int)((num2 * 1611435909) ^ 0x68D53EF0);
					continue;
				case 338u:
					MobileSTxt = Admit.smethod_6();
					num = ((int)num2 * -1814531881) ^ 0x13ED7BB0;
					continue;
				case 337u:
					Admit.smethod_19((Control)(object)PatientInfoBox, "PatientInfoBox");
					num = (int)(num2 * 1303248221) ^ -1237389144;
					continue;
				case 336u:
					Admit.smethod_57((ISupportInitialize)SearchResultGrid);
					num = ((int)num2 * -1967754527) ^ -257529736;
					continue;
				case 335u:
					num = ((int)num2 * -1092446679) ^ 0x494B88BD;
					continue;
				case 334u:
					Admit.smethod_20((Control)(object)RoomNoTxt, new Size(141, 27));
					num = ((int)num2 * -1257825687) ^ -149565855;
					continue;
				case 333u:
					num = (int)((num2 * 284120120) ^ 0x205BFF12);
					continue;
				case 332u:
					Admit.smethod_18((Control)(object)Label4, new Point(13, 43));
					num = ((int)num2 * -21618122) ^ -288895188;
					continue;
				case 331u:
					num = ((int)num2 * -1949891054) ^ 0x4D764B57;
					continue;
				case 330u:
					Admit.smethod_31((ButtonBase)(object)SearchBtn, bool_0: false);
					num = ((int)num2 * -683924706) ^ -225030337;
					continue;
				case 329u:
					num = (int)(num2 * 1816142929) ^ -2126268689;
					continue;
				case 328u:
					Admit.smethod_21((Control)(object)DateOutTxt, 17);
					num = ((int)num2 * -742961411) ^ 0x9454BD4;
					continue;
				case 327u:
					Admit.smethod_17((Control)(object)DateOutTxt, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Admit.smethod_41((ListControl)(object)DateOutTxt, bool_0: true);
					Admit.smethod_18((Control)(object)DateOutTxt, new Point(161, 157));
					num = (int)(num2 * 1820519597) ^ -309807280;
					continue;
				case 326u:
					num = ((int)num2 * -1629467553) ^ -1536238464;
					continue;
				case 325u:
					Admit.smethod_12((Control)(object)GroupBox1);
					num = ((int)num2 * -1975236791) ^ 0x60D63718;
					continue;
				case 324u:
					RoomType1Txt = Admit.smethod_6();
					num = ((int)num2 * -773467295) ^ -817397019;
					continue;
				case 323u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)SearchResultGrid);
					num = ((int)num2 * -1240748344) ^ 0x6455E8DF;
					continue;
				case 322u:
					num = ((int)num2 * -2094086716) ^ -1282451294;
					continue;
				case 321u:
					Admit.smethod_28((ButtonBase)(object)AdmitDischargeBtn, Color.MidnightBlue);
					num = ((int)num2 * -531117771) ^ -1205679393;
					continue;
				case 320u:
					Admit.smethod_20((Control)(object)DateInTxt, new Size(181, 27));
					num = (int)((num2 * 261140699) ^ 0x66DFC69);
					continue;
				case 319u:
					Admit.smethod_26(AdmitDetailsBox, bool_0: false);
					Admit.smethod_27(AdmitDetailsBox, "Admit Details");
					Admit.smethod_37((Control)(object)AdmitDetailsBox, bool_0: false);
					Admit.smethod_40(RoomNoTxt, (ComboBoxStyle)2);
					num = (int)(num2 * 447955428) ^ -936852175;
					continue;
				case 318u:
					Admit.smethod_21((Control)(object)GenderTxt, 6);
					num = ((int)num2 * -1885216059) ^ 0x5E985530;
					continue;
				case 317u:
					num = (int)((num2 * 115794892) ^ 0x459E69E3);
					continue;
				case 316u:
					num = ((int)num2 * -1787342613) ^ -2095009726;
					continue;
				case 315u:
					Admit.smethod_18((Control)(object)AddressTxt, new Point(124, 198));
					num = ((int)num2 * -59485269) ^ 0x199561DA;
					continue;
				case 314u:
					Label5 = Admit.smethod_3();
					num = ((int)num2 * -1300682484) ^ -564051760;
					continue;
				case 313u:
					Admit.smethod_40(RoomTypeTxt, (ComboBoxStyle)2);
					num = (int)(num2 * 1459838908) ^ -2009631832;
					continue;
				case 312u:
					Admit.smethod_27(GroupBox1, "Search Patient");
					num = ((int)num2 * -2070987409) ^ -1103188011;
					continue;
				case 311u:
					Admit.smethod_37((Control)(object)AdmitDischargeBtn, bool_0: false);
					num = (int)(num2 * 227345117) ^ -330765433;
					continue;
				case 310u:
					Admit.smethod_19((Control)(object)Label11, "Label11");
					Admit.smethod_20((Control)(object)Label11, new Size(76, 28));
					num = ((int)num2 * -195646940) ^ 0xDB05C36;
					continue;
				case 309u:
					Admit.smethod_19((Control)(object)DateOutTxt, "DateOutTxt");
					num = ((int)num2 * -1348083332) ^ -1045296672;
					continue;
				case 308u:
					Admit.smethod_32(SearchResultGrid, Color.White);
					num = ((int)num2 * -437162308) ^ -1533917007;
					continue;
				case 307u:
					Admit.smethod_21((Control)(object)Label7, 3);
					Admit.smethod_22(Label7, "Address : ");
					Admit.smethod_17((Control)(object)Label6, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 381404781) ^ -1421412543;
					continue;
				case 306u:
					Admit.smethod_19((Control)(object)DateIn1Txt, "DateIn1Txt");
					num = ((int)num2 * -20750552) ^ 0x4F0F2212;
					continue;
				case 305u:
					Admit.smethod_21((Control)(object)Label3, 3);
					num = (int)(num2 * 474147875) ^ -1637724204;
					continue;
				case 304u:
					Admit.smethod_19((Control)(object)Label6, "Label6");
					num = ((int)num2 * -1581555205) ^ 0x745C2C65;
					continue;
				case 303u:
					Admit.smethod_20((Control)(object)AgeTxt, new Size(128, 23));
					num = ((int)num2 * -1674245377) ^ 0x313E3450;
					continue;
				case 302u:
					Admit.smethod_20((Control)(object)PatientInfoBox, new Size(439, 298));
					num = (int)(num2 * 2042251213) ^ -930676371;
					continue;
				case 301u:
					Admit.smethod_17((Control)(object)Label5, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1592817170) ^ -759044013;
					continue;
				case 299u:
					Admit.smethod_37((Control)(object)ClearBtn, bool_0: false);
					num = (int)((num2 * 1241996211) ^ 0x7104E048);
					continue;
				case 298u:
					Admit.smethod_20((Control)(object)DateOutTxt, new Size(181, 27));
					num = ((int)num2 * -1575764394) ^ -1385163384;
					continue;
				case 297u:
					Admit.smethod_30((ButtonBase)(object)SaveBtn, "Save");
					num = ((int)num2 * -2078907011) ^ -1442726498;
					continue;
				case 296u:
					num = (int)((num2 * 201781590) ^ 0x1CBE18E0);
					continue;
				case 295u:
					Admit.smethod_17((Control)(object)GroupBox1, Admit.smethod_16("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -2015869646) ^ 0x72DEA98F;
					continue;
				case 294u:
					Admit.smethod_18((Control)(object)Label1, new Point(392, 63));
					Admit.smethod_19((Control)(object)Label1, "Label1");
					num = (int)(num2 * 660125264) ^ -578997293;
					continue;
				case 293u:
					num = ((int)num2 * -2075744119) ^ 0x51244C43;
					continue;
				case 292u:
					Admit.smethod_38((TextBoxBase)(object)PIDTxt, bool_0: true);
					num = ((int)num2 * -1395020170) ^ 0x41330594;
					continue;
				case 291u:
					num = (int)((num2 * 1245978232) ^ 0x24FDD4E5);
					continue;
				case 290u:
					Admit.smethod_37((Control)(object)SaveBtn, bool_0: false);
					num = ((int)num2 * -1450504086) ^ -2007622292;
					continue;
				case 289u:
					HistoryBtn = Admit.smethod_5();
					AdmitDischargeBtn = Admit.smethod_5();
					num = (int)((num2 * 386876132) ^ 0x58680DC9);
					continue;
				case 288u:
					num = (int)(num2 * 566078637) ^ -590946813;
					continue;
				case 287u:
					num = (int)(num2 * 1195638581) ^ -623800254;
					continue;
				case 286u:
					num = ((int)num2 * -264611884) ^ -466912355;
					continue;
				case 285u:
					num = ((int)num2 * -780852132) ^ -629598681;
					continue;
				case 284u:
					Admit.smethod_19((Control)(object)GroupBox1, "GroupBox1");
					Admit.smethod_20((Control)(object)GroupBox1, new Size(623, 128));
					num = ((int)num2 * -384178940) ^ 0x5C1DD905;
					continue;
				case 283u:
					num = ((int)num2 * -866751271) ^ -447690334;
					continue;
				case 282u:
					num = ((int)num2 * -2121237085) ^ 0x390EB926;
					continue;
				case 281u:
					num = ((int)num2 * -383328348) ^ -848624502;
					continue;
				case 280u:
					num = (int)(num2 * 1125675300) ^ -1714737435;
					continue;
				case 279u:
					Admit.smethod_19((Control)(object)RoomTypeTxt, "RoomTypeTxt");
					num = ((int)num2 * -1011617867) ^ 0x2DBA8ED4;
					continue;
				case 278u:
					num = ((int)num2 * -331623992) ^ -609038021;
					continue;
				case 277u:
					num = (int)((num2 * 1977463415) ^ 0x5C08F9A3);
					continue;
				case 276u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)GroupBox1);
					num = (int)(num2 * 1432128871) ^ -1068554172;
					continue;
				case 275u:
					Admit.smethod_22(Label14, "Name :");
					num = (int)(num2 * 1221223233) ^ -726141064;
					continue;
				case 274u:
					num = ((int)num2 * -1307868526) ^ 0x321881D7;
					continue;
				case 273u:
					Admit.smethod_20((Control)(object)HistoryBtn, new Size(181, 41));
					num = (int)(num2 * 2017154161) ^ -1444076834;
					continue;
				case 272u:
					num = ((int)num2 * -1445434885) ^ -2137184829;
					continue;
				case 271u:
					Admit.smethod_20((Control)(object)PIDTxt, new Size(128, 28));
					num = ((int)num2 * -443495773) ^ -1092154676;
					continue;
				case 270u:
					Admit.smethod_21((Control)(object)Label11, 10);
					Admit.smethod_22(Label11, "Status:");
					num = ((int)num2 * -284532555) ^ 0x53C50F09;
					continue;
				case 269u:
					num = ((int)num2 * -1066045247) ^ 0x66B62D1D;
					continue;
				case 268u:
					Admit.smethod_19((Control)(object)Label12, "Label12");
					num = (int)((num2 * 1212321888) ^ 0x1E4C0A6E);
					continue;
				case 267u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)RoomNo1Txt);
					num = ((int)num2 * -1769849171) ^ -1369213887;
					continue;
				case 266u:
					num = ((int)num2 * -1865742093) ^ -318517702;
					continue;
				case 265u:
					Admit.smethod_12((Control)(object)AdmitDetailsBox);
					num = ((int)num2 * -2135875449) ^ -1696111046;
					continue;
				case 264u:
					Admit.smethod_17((Control)(object)Label15, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1750573189) ^ 0x5423C003;
					continue;
				case 263u:
					Admit.smethod_21((Control)(object)NameSTxt, 1);
					num = ((int)num2 * -562668819) ^ -808158475;
					continue;
				case 262u:
					num = ((int)num2 * -1090839387) ^ 0x20D4F59;
					continue;
				case 261u:
					Admit.smethod_29((Control)(object)PrintBtn, Color.White);
					num = (int)((num2 * 1745022331) ^ 0x3A4CF8A6);
					continue;
				case 260u:
					Admit.smethod_18((Control)(object)PIDTxt, new Point(96, 43));
					num = (int)(num2 * 1258854380) ^ -1101215455;
					continue;
				case 259u:
					Admit.smethod_37((Control)(object)RoomType1Txt, bool_0: false);
					num = (int)((num2 * 714370628) ^ 0x647F73DC);
					continue;
				case 258u:
					NameTxt = Admit.smethod_6();
					Label14 = Admit.smethod_3();
					num = (int)((num2 * 850951764) ^ 0x6E366488);
					continue;
				case 257u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)AdmitDischargeBtn);
					num = ((int)num2 * -1515950514) ^ -617736321;
					continue;
				case 256u:
					num = ((int)num2 * -1821000250) ^ -721049563;
					continue;
				case 255u:
					num = (int)((num2 * 2048529573) ^ 0x2D11D42F);
					continue;
				case 254u:
					Admit.smethod_17((Control)(object)Label9, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Admit.smethod_18((Control)(object)Label9, new Point(18, 71));
					num = (int)((num2 * 1232681577) ^ 0x7BFC3926);
					continue;
				case 253u:
					Admit.smethod_44(PrintDialog1, bool_0: true);
					num = ((int)num2 * -591883846) ^ -1890379372;
					continue;
				case 252u:
					num = ((int)num2 * -157645504) ^ -127043454;
					continue;
				case 251u:
					Admit.smethod_22(Label5, "DOB :");
					num = ((int)num2 * -413731477) ^ 0x4F6C10ED;
					continue;
				case 250u:
					Admit.smethod_23(Label11, (ContentAlignment)32);
					num = (int)((num2 * 1151354265) ^ 0x1208C06B);
					continue;
				case 249u:
					Admit.smethod_18((Control)(object)MobileSTxt, new Point(96, 116));
					Admit.smethod_19((Control)(object)MobileSTxt, "MobileSTxt");
					num = ((int)num2 * -2083359394) ^ 0x30C28D94;
					continue;
				case 248u:
					num = (int)((num2 * 1661908418) ^ 0x5F6D525F);
					continue;
				case 247u:
					Admit.smethod_17((Control)(object)Label3, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1357326544) ^ 0x71B3D75A);
					continue;
				case 246u:
					Admit.smethod_30((ButtonBase)(object)PrintBtn, "Print");
					num = (int)(num2 * 38791579) ^ -505700706;
					continue;
				case 245u:
					Admit.smethod_17((Control)(object)RoomNoTxt, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1715960008) ^ 0x1519F897);
					continue;
				case 244u:
					Label13 = Admit.smethod_3();
					num = ((int)num2 * -564083188) ^ -796246658;
					continue;
				case 243u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)Label8);
					num = ((int)num2 * -998654970) ^ 0x59B9D421;
					continue;
				case 242u:
					Admit.smethod_22(Label8, "Room No :");
					num = ((int)num2 * -1379129403) ^ 0x48CC7784;
					continue;
				case 241u:
					num = (int)(num2 * 1356696165) ^ -1416441489;
					continue;
				case 240u:
					Admit.smethod_19((Control)(object)SaveBtn, "SaveBtn");
					num = (int)((num2 * 1506485059) ^ 0x3B1A6C74);
					continue;
				case 239u:
					Admit.smethod_20((Control)(object)Label1, new Size(344, 35));
					num = ((int)num2 * -1111289766) ^ 0x3B627B95;
					continue;
				case 238u:
					Admit.smethod_21((Control)(object)Label8, 1);
					num = (int)((num2 * 858474418) ^ 0x781D6D67);
					continue;
				case 237u:
					num = (int)(num2 * 1142931608) ^ -66658148;
					continue;
				case 236u:
					num = (int)((num2 * 347394407) ^ 0x57C6804B);
					continue;
				case 235u:
					num = (int)((num2 * 704921158) ^ 0x290B4CF1);
					continue;
				case 234u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)PatientInfoBox);
					num = (int)(num2 * 1861629349) ^ -1588310881;
					continue;
				case 233u:
					DateIn1Txt = Admit.smethod_6();
					num = (int)(num2 * 134540133) ^ -505555129;
					continue;
				case 232u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)DateOutTxt);
					num = (int)((num2 * 327536535) ^ 0x6AFF288A);
					continue;
				case 231u:
					Admit.smethod_23(Label10, (ContentAlignment)32);
					num = ((int)num2 * -160156732) ^ -8981315;
					continue;
				case 230u:
					num = (int)((num2 * 1072387672) ^ 0x76D38735);
					continue;
				case 229u:
					PrintDialog1 = Admit.smethod_9();
					num = ((int)num2 * -269291878) ^ 0x1C99C1AC;
					continue;
				case 228u:
					Admit.smethod_21((Control)(object)HistoryBtn, 18);
					num = ((int)num2 * -482376558) ^ 0x48D56370;
					continue;
				case 227u:
					Admit.smethod_18((Control)(object)HistoryBtn, new Point(784, 163));
					num = (int)((num2 * 2070718108) ^ 0x7B82AAD9);
					continue;
				case 226u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)Label1);
					num = ((int)num2 * -1645205441) ^ 0x778472AC;
					continue;
				case 225u:
					num = ((int)num2 * -1690885397) ^ -343497298;
					continue;
				case 224u:
					num = (int)((num2 * 1212479704) ^ 0x23DE320E);
					continue;
				case 223u:
					num = ((int)num2 * -1853463164) ^ 0x60569499;
					continue;
				case 222u:
					Admit.smethod_17((Control)(object)PrintBtn, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -899530323) ^ 0x7B49D245;
					continue;
				case 221u:
					num = (int)(num2 * 1323005044) ^ -575089626;
					continue;
				case 220u:
					Admit.smethod_20((Control)(object)MobileTxt, new Size(237, 28));
					num = ((int)num2 * -1250140010) ^ -2027422893;
					continue;
				case 219u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)StatusTxt);
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)DateOut1Txt);
					num = ((int)num2 * -984003186) ^ 0xD09E5B7;
					continue;
				case 218u:
					num = ((int)num2 * -881206554) ^ 0x2B29B73;
					continue;
				case 217u:
					Admit.smethod_20((Control)(object)Label6, new Size(84, 26));
					num = (int)(num2 * 390363564) ^ -1878364250;
					continue;
				case 216u:
					Admit.smethod_53((Control)(object)this, "Admit");
					num = (int)(num2 * 1102865081) ^ -83208502;
					continue;
				case 215u:
					GenderTxt = Admit.smethod_6();
					num = ((int)num2 * -280888378) ^ -1078099501;
					continue;
				case 214u:
					Admit.smethod_58((Control)(object)this, bool_0: false);
					num = ((int)num2 * -660247144) ^ 0x622A25E8;
					continue;
				case 213u:
					Admit.smethod_43(Admit.smethod_42(RoomTypeTxt), new object[3] { "General", "V.I.P.", "ICU" });
					num = ((int)num2 * -1877071051) ^ -800088882;
					continue;
				case 212u:
					Label9 = Admit.smethod_3();
					Label8 = Admit.smethod_3();
					num = ((int)num2 * -277957192) ^ 0x55B7CE40;
					continue;
				case 211u:
					Admit.smethod_28((ButtonBase)(object)HistoryBtn, Color.MidnightBlue);
					num = (int)(num2 * 545486170) ^ -1084257158;
					continue;
				case 210u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)Label11);
					num = (int)(num2 * 2057895099) ^ -1542424156;
					continue;
				case 209u:
					Admit.smethod_18((Control)(object)ClearBtn, new Point(504, 746));
					num = (int)(num2 * 889270843) ^ -308537122;
					continue;
				case 208u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)Label4);
					num = (int)(num2 * 590611739) ^ -45286077;
					continue;
				case 207u:
					num = (int)((num2 * 513498670) ^ 0x5A9C67B8);
					continue;
				case 206u:
					num = ((int)num2 * -841334120) ^ -1994616709;
					continue;
				case 205u:
					Admit.smethod_18((Control)(object)Label5, new Point(13, 154));
					num = (int)(num2 * 2103806469) ^ -1260105059;
					continue;
				case 204u:
					Admit.smethod_30((ButtonBase)(object)AdmitDischargeBtn, "Admit/Discharge");
					num = (int)((num2 * 1464113473) ^ 0x60715EAC);
					continue;
				case 203u:
					num = (int)((num2 * 1829564748) ^ 0x1FD0D352);
					continue;
				case 202u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)MobileSTxt);
					num = (int)(num2 * 712256967) ^ -844169253;
					continue;
				case 201u:
					Admit.smethod_50((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 1358207365) ^ 0x134B700D);
					continue;
				case 200u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)Label9);
					num = (int)(num2 * 1342507810) ^ -236132185;
					continue;
				case 199u:
					num = (int)((num2 * 439614559) ^ 0x16C964D3);
					continue;
				case 198u:
					Admit.smethod_18((Control)(object)Label6, new Point(232, 154));
					num = ((int)num2 * -887584841) ^ 0x51A5649D;
					continue;
				case 197u:
					Admit.smethod_43(Admit.smethod_42(StatusTxt), new object[2] { "Paid", "Not Paid" });
					num = ((int)num2 * -2050910751) ^ -841086144;
					continue;
				case 196u:
					num = (int)((num2 * 1159163271) ^ 0x609B840E);
					continue;
				case 195u:
					Label6 = Admit.smethod_3();
					num = ((int)num2 * -1292855763) ^ -1814454291;
					continue;
				case 194u:
					num = (int)((num2 * 1197038385) ^ 0x7E5128DF);
					continue;
				case 193u:
					num = ((int)num2 * -452673136) ^ 0x712062AD;
					continue;
				case 192u:
					Label10 = Admit.smethod_3();
					num = (int)(num2 * 620915979) ^ -472386151;
					continue;
				case 191u:
					Admit.smethod_20((Control)(object)Label7, new Size(105, 26));
					num = (int)(num2 * 1064054439) ^ -1370165606;
					continue;
				case 190u:
					Admit.smethod_18((Control)(object)Label3, new Point(37, 87));
					num = ((int)num2 * -2083234948) ^ -516211250;
					continue;
				case 189u:
					Admit.smethod_56((Control)(object)GroupBox1);
					num = (int)(num2 * 410419556) ^ -533165482;
					continue;
				case 188u:
					Admit.smethod_17((Control)(object)AdmitDetailsBox, Admit.smethod_16("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Admit.smethod_18((Control)(object)AdmitDetailsBox, new Point(504, 485));
					num = ((int)num2 * -1926504044) ^ -1975057356;
					continue;
				case 187u:
					num = ((int)num2 * -564399600) ^ -1625497852;
					continue;
				case 186u:
					Admit.smethod_18((Control)(object)AgeTxt, new Point(96, 154));
					num = ((int)num2 * -765640067) ^ 0x1E4D2FED;
					continue;
				case 185u:
					Label7 = Admit.smethod_3();
					num = (int)(num2 * 2033823263) ^ -80214288;
					continue;
				case 184u:
					Admit.smethod_18((Control)(object)PictureBox1, new Point(260, 22));
					num = (int)((num2 * 692667287) ^ 0x14633FFF);
					continue;
				case 183u:
					DateInTxt = Admit.smethod_8();
					num = ((int)num2 * -721366251) ^ 0x425E0DC6;
					continue;
				case 182u:
					Admit.smethod_20((Control)(object)Label4, new Size(68, 25));
					num = ((int)num2 * -1510261665) ^ 0x162652B8;
					continue;
				case 181u:
					RoomNoTxt = Admit.smethod_8();
					num = (int)((num2 * 2093947833) ^ 0x1D81F2CB);
					continue;
				case 180u:
					Admit.smethod_21((Control)(object)MobileTxt, 2);
					Admit.smethod_18((Control)(object)NameSTxt, new Point(120, 44));
					num = ((int)num2 * -1927005056) ^ 0x35F65677;
					continue;
				case 179u:
					Admit.smethod_26(PatientInfoBox, bool_0: false);
					num = ((int)num2 * -1320874794) ^ -2049922969;
					continue;
				case 178u:
					Admit.smethod_20((Control)(object)SaveBtn, new Size(98, 37));
					Admit.smethod_21((Control)(object)SaveBtn, 11);
					num = (int)((num2 * 1260972420) ^ 0x23564877);
					continue;
				case 177u:
					Admit.smethod_18((Control)(object)RoomType1Txt, new Point(161, 73));
					num = ((int)num2 * -1330438271) ^ 0xF14C076;
					continue;
				case 176u:
					num = ((int)num2 * -1095094551) ^ -1090284777;
					continue;
				case 175u:
					Admit.smethod_23(Label2, (ContentAlignment)32);
					num = ((int)num2 * -1315114781) ^ 0x73230350;
					continue;
				case 174u:
					Admit.smethod_21((Control)(object)Label14, 8);
					num = ((int)num2 * -284887022) ^ 0x280E8973;
					continue;
				case 173u:
					Admit.smethod_21((Control)(object)AgeTxt, 5);
					num = (int)(num2 * 1061290346) ^ -1531352552;
					continue;
				case 172u:
					Admit.smethod_21((Control)(object)RoomNo1Txt, 20);
					num = (int)(num2 * 1611479940) ^ -2074827128;
					continue;
				case 171u:
					num = (int)(num2 * 1042406495) ^ -658727467;
					continue;
				case 170u:
					StatusTxt = Admit.smethod_8();
					num = ((int)num2 * -263603012) ^ 0x2B5CB91A;
					continue;
				case 169u:
					Admit.smethod_19((Control)(object)RoomType1Txt, "RoomType1Txt");
					num = (int)(num2 * 1715596042) ^ -1778833721;
					continue;
				case 168u:
					AddressTxt = Admit.smethod_6();
					num = ((int)num2 * -1289382103) ^ -1999021493;
					continue;
				case 167u:
					num = ((int)num2 * -342899795) ^ 0x1CB0D1AE;
					continue;
				case 166u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)FeesTxt);
					num = (int)((num2 * 322500355) ^ 0x56D47EA);
					continue;
				case 165u:
					num = (int)((num2 * 1581565791) ^ 0x767069C6);
					continue;
				case 164u:
					num = (int)((num2 * 760067921) ^ 0x2D9B78FC);
					continue;
				case 163u:
					num = ((int)num2 * -1776473393) ^ -876861181;
					continue;
				case 162u:
					num = ((int)num2 * -1152588517) ^ -82937099;
					continue;
				case 161u:
					num = (int)(num2 * 272901259) ^ -2140618837;
					continue;
				case 160u:
					num = (int)((num2 * 2127564713) ^ 0x27135350);
					continue;
				case 159u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)Label15);
					num = (int)((num2 * 987609327) ^ 0x3CF991CD);
					continue;
				case 158u:
					Admit.smethod_40(StatusTxt, (ComboBoxStyle)2);
					num = (int)(num2 * 1227045441) ^ -1614390628;
					continue;
				case 157u:
					num = (int)((num2 * 946651977) ^ 0x2AA6F577);
					continue;
				case 156u:
					Admit.smethod_37((Control)(object)HistoryBtn, bool_0: false);
					num = (int)(num2 * 1043835489) ^ -47312003;
					continue;
				case 155u:
					num = (int)((num2 * 1247453759) ^ 0x18D5F637);
					continue;
				case 154u:
					num = ((int)num2 * -1035217939) ^ 0x72C0D370;
					continue;
				case 153u:
					Admit.smethod_19((Control)(object)AdmitDetailsBox, "AdmitDetailsBox");
					Admit.smethod_20((Control)(object)AdmitDetailsBox, new Size(408, 255));
					num = (int)((num2 * 1064090445) ^ 0x3A630A0A);
					continue;
				case 152u:
					Admit.smethod_17((Control)(object)Label12, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 742067509) ^ 0x1FA30722);
					continue;
				case 151u:
					Label12 = Admit.smethod_3();
					num = (int)(num2 * 85153710) ^ -1610030053;
					continue;
				case 150u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)Label13);
					num = ((int)num2 * -2090022890) ^ 0x58A7027E;
					continue;
				case 149u:
					Admit.smethod_38((TextBoxBase)(object)DateIn1Txt, bool_0: true);
					Admit.smethod_20((Control)(object)DateIn1Txt, new Size(181, 28));
					num = ((int)num2 * -696271135) ^ 0x41DE2D72;
					continue;
				case 148u:
					num = (int)(num2 * 1912986933) ^ -1991726459;
					continue;
				case 147u:
					Admit.smethod_21((Control)(object)StatusTxt, 15);
					Admit.smethod_18((Control)(object)DateOut1Txt, new Point(161, 157));
					Admit.smethod_19((Control)(object)DateOut1Txt, "DateOut1Txt");
					num = (int)((num2 * 938175168) ^ 0x6149376);
					continue;
				case 146u:
					Admit.smethod_22(Label3, "Mobile : ");
					num = ((int)num2 * -1849613544) ^ -1274638242;
					continue;
				case 145u:
					Admit.smethod_57((ISupportInitialize)PictureBox1);
					num = (int)((num2 * 1879686929) ^ 0x6F24C2CE);
					continue;
				case 144u:
					Admit.smethod_21((Control)(object)PrintBtn, 10);
					num = (int)(num2 * 393678762) ^ -1450538448;
					continue;
				case 143u:
					num = ((int)num2 * -976167893) ^ -1263598780;
					continue;
				case 142u:
					Admit.smethod_21((Control)(object)GroupBox1, 5);
					Admit.smethod_26(GroupBox1, bool_0: false);
					num = (int)((num2 * 1214454919) ^ 0x3FFED380);
					continue;
				case 141u:
					num = ((int)num2 * -1291821637) ^ 0x5EA9C760;
					continue;
				case 140u:
					Admit.smethod_19((Control)(object)SearchBtn, "SearchBtn");
					num = ((int)num2 * -2017980742) ^ -1595971146;
					continue;
				case 139u:
					Admit.smethod_19((Control)(object)Label8, "Label8");
					num = (int)((num2 * 2021042338) ^ 0x346CF7B9);
					continue;
				case 138u:
					Admit.smethod_19((Control)(object)FeesTxt, "FeesTxt");
					num = (int)(num2 * 530755913) ^ -733776863;
					continue;
				case 137u:
					num = ((int)num2 * -1739466677) ^ -1547005140;
					continue;
				case 136u:
					num = (int)((num2 * 276700708) ^ 0x7C6457C6);
					continue;
				case 135u:
					Admit.smethod_20((Control)(object)ClearBtn, new Size(97, 37));
					num = (int)((num2 * 1398823818) ^ 0x14CE45DA);
					continue;
				case 133u:
					num = ((int)num2 * -1256799672) ^ -1096701733;
					continue;
				case 132u:
					Label4 = Admit.smethod_3();
					num = (int)(num2 * 221000974) ^ -831758437;
					continue;
				case 131u:
					num = (int)(num2 * 609455161) ^ -1363048792;
					continue;
				case 130u:
					Admit.smethod_18((Control)(object)FeesTxt, new Point(92, 201));
					num = ((int)num2 * -2057946353) ^ -593928139;
					continue;
				case 129u:
					Admit.smethod_17((Control)(object)RoomTypeTxt, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 922341568) ^ -802781793;
					continue;
				case 128u:
					num = ((int)num2 * -1205817526) ^ 0x6F7B39C4;
					continue;
				case 127u:
					Admit.smethod_41((ListControl)(object)RoomNoTxt, bool_0: true);
					num = ((int)num2 * -1088688090) ^ -1565978308;
					continue;
				case 126u:
					num = (int)((num2 * 587541794) ^ 0x2FCB50CB);
					continue;
				case 125u:
					num = ((int)num2 * -1780128002) ^ 0xC55BEF3;
					continue;
				case 124u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)PrintBtn);
					num = ((int)num2 * -623830117) ^ -112295286;
					continue;
				case 123u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)ClearBtn);
					num = (int)((num2 * 839955966) ^ 0x690CD693);
					continue;
				case 122u:
					num = (int)((num2 * 629450976) ^ 0x8D0AD12);
					continue;
				case 121u:
					ClearBtn = Admit.smethod_5();
					num = ((int)num2 * -33169806) ^ -368079534;
					continue;
				case 120u:
					Admit.smethod_17((Control)(object)Label7, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1722956902) ^ -161494303;
					continue;
				case 119u:
					Admit.smethod_19((Control)(object)PictureBox1, "PictureBox1");
					num = (int)(num2 * 1544517549) ^ -1231609995;
					continue;
				case 118u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)RoomType1Txt);
					num = ((int)num2 * -837454949) ^ -49102287;
					continue;
				case 117u:
					num = ((int)num2 * -1065762003) ^ -1471594162;
					continue;
				case 116u:
					num = ((int)num2 * -1089225565) ^ -1250758741;
					continue;
				case 115u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)SaveBtn);
					num = (int)((num2 * 1772294131) ^ 0x24EF66EF);
					continue;
				case 114u:
					Admit.smethod_31((ButtonBase)(object)ClearBtn, bool_0: false);
					num = (int)(num2 * 1034407058) ^ -1491416050;
					continue;
				case 113u:
					PrintBtn = Admit.smethod_5();
					SaveBtn = Admit.smethod_5();
					num = (int)(num2 * 1191092390) ^ -1679259111;
					continue;
				case 112u:
					num = (int)(num2 * 235122320) ^ -727731631;
					continue;
				case 111u:
					num = (int)((num2 * 813089870) ^ 0x54B674A0);
					continue;
				case 110u:
					Admit.smethod_21((Control)(object)AddressTxt, 7);
					num = (int)(num2 * 193164101) ^ -1178188430;
					continue;
				case 109u:
					Admit.smethod_38((TextBoxBase)(object)DateOut1Txt, bool_0: true);
					num = (int)(num2 * 2059939120) ^ -722039459;
					continue;
				case 108u:
					Admit.smethod_13((ISupportInitialize)PictureBox1);
					num = (int)((num2 * 560227481) ^ 0x6FD8E7E);
					continue;
				case 107u:
					Label11 = Admit.smethod_3();
					FeesTxt = Admit.smethod_6();
					num = ((int)num2 * -1322863751) ^ 0x7A11FE41;
					continue;
				case 106u:
					PIDTxt = Admit.smethod_6();
					num = ((int)num2 * -330951422) ^ 0x19EB4FE0;
					continue;
				case 105u:
					Admit.smethod_21((Control)(object)ClearBtn, 9);
					num = ((int)num2 * -761008211) ^ 0x149FEC0A;
					continue;
				case 104u:
					Label3 = Admit.smethod_3();
					num = (int)((num2 * 1000133911) ^ 0xBE80648);
					continue;
				case 103u:
					Admit.smethod_17((Control)(object)HistoryBtn, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -294168681) ^ 0x2033763F;
					continue;
				case 102u:
					Admit.smethod_23(Label3, (ContentAlignment)32);
					num = (int)(num2 * 186272391) ^ -116986860;
					continue;
				case 101u:
					Admit.smethod_21((Control)(object)Label6, 2);
					Admit.smethod_22(Label6, "Gender : ");
					num = (int)(num2 * 1232105149) ^ -684958764;
					continue;
				case 100u:
					num = (int)((num2 * 2037645751) ^ 0x2117D58E);
					continue;
				case 99u:
					Admit.smethod_20((Control)(object)SearchBtn, new Size(133, 37));
					num = ((int)num2 * -1120785429) ^ -1876703991;
					continue;
				case 98u:
					num = ((int)num2 * -1887179238) ^ -469716667;
					continue;
				case 97u:
					Admit.smethod_17((Control)(object)SearchBtn, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1094833089) ^ 0x69F636E3;
					continue;
				case 96u:
					Admit.smethod_33(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					num = (int)(num2 * 1893281695) ^ -173670215;
					continue;
				case 95u:
					num = ((int)num2 * -1291901174) ^ 0x125A3C37;
					continue;
				case 94u:
					num = ((int)num2 * -719939166) ^ 0xA9A66D0;
					continue;
				case 93u:
					num = ((int)num2 * -1016766350) ^ -1223415580;
					continue;
				case 92u:
					Admit.smethod_18((Control)(object)Label7, new Point(13, 198));
					num = ((int)num2 * -266633787) ^ -244881124;
					continue;
				case 91u:
					num = ((int)num2 * -1403519062) ^ -257182289;
					continue;
				case 90u:
					num = ((int)num2 * -1932157090) ^ 0x76783701;
					continue;
				case 89u:
					num = ((int)num2 * -462864249) ^ 0xEEF24B8;
					continue;
				case 88u:
					Admit.smethod_18((Control)(object)Label15, new Point(13, 116));
					num = ((int)num2 * -1560537777) ^ 0x557EF948;
					continue;
				case 87u:
					Admit.smethod_15(Label1, bool_0: true);
					num = ((int)num2 * -1741684199) ^ -814127822;
					continue;
				case 86u:
					num = ((int)num2 * -1971219248) ^ 0xB038FD3;
					continue;
				case 85u:
					Admit.smethod_31((ButtonBase)(object)HistoryBtn, bool_0: false);
					num = ((int)num2 * -2107039930) ^ 0xF056953;
					continue;
				case 84u:
					Admit.smethod_21((Control)(object)AdmitDetailsBox, 8);
					num = (int)(num2 * 671240083) ^ -641938133;
					continue;
				case 83u:
					Admit.smethod_30((ButtonBase)(object)HistoryBtn, "History");
					num = (int)((num2 * 1574206400) ^ 0x3ABE2832);
					continue;
				case 82u:
					Admit.smethod_18((Control)(object)DateIn1Txt, new Point(161, 110));
					num = ((int)num2 * -461072071) ^ -813343109;
					continue;
				case 81u:
					Admit.smethod_20((Control)(object)Label13, new Size(109, 25));
					Admit.smethod_21((Control)(object)Label13, 12);
					num = (int)((num2 * 1112967441) ^ 0x36DA8196);
					continue;
				case 80u:
					Admit.smethod_18((Control)(object)PatientInfoBox, new Point(59, 485));
					num = ((int)num2 * -713654553) ^ -1687667336;
					continue;
				case 79u:
					Admit.smethod_22(Label4, "PID :");
					num = (int)((num2 * 1168414834) ^ 0x5CED8312);
					continue;
				case 78u:
					Admit.smethod_56((Control)(object)PatientInfoBox);
					Admit.smethod_55((Control)(object)AdmitDetailsBox, bool_0: false);
					Admit.smethod_56((Control)(object)AdmitDetailsBox);
					num = (int)(num2 * 1856879346) ^ -354311079;
					continue;
				case 77u:
					Admit.smethod_21((Control)(object)Label4, 0);
					num = ((int)num2 * -1979393904) ^ -600582899;
					continue;
				case 76u:
					num = ((int)num2 * -2145995580) ^ 0x49CCB259;
					continue;
				case 75u:
					num = ((int)num2 * -1047930293) ^ -2024370966;
					continue;
				case 74u:
					Admit.smethod_40(DateOutTxt, (ComboBoxStyle)2);
					num = (int)((num2 * 885215102) ^ 0x645682D);
					continue;
				case 73u:
					Admit.smethod_21((Control)(object)PIDTxt, 4);
					num = ((int)num2 * -1307973160) ^ -1141037427;
					continue;
				case 72u:
					num = (int)(num2 * 1831022953) ^ -1802267915;
					continue;
				case 71u:
					Admit.smethod_54((Control)(object)this, new Size(977, 804));
					num = (int)((num2 * 1923674174) ^ 0x6000EC7F);
					continue;
				case 70u:
					Admit.smethod_18((Control)(object)RoomNoTxt, new Point(161, 32));
					Admit.smethod_19((Control)(object)RoomNoTxt, "RoomNoTxt");
					num = ((int)num2 * -1806545739) ^ 0x6B5AF08B;
					continue;
				case 69u:
					Admit.smethod_34(SearchResultGrid, bool_0: true);
					Admit.smethod_36(Admit.smethod_35(SearchResultGrid), 24);
					num = ((int)num2 * -2037308428) ^ 0x4EFCCE5C;
					continue;
				case 68u:
					num = (int)((num2 * 1684543374) ^ 0xB639CF8);
					continue;
				case 67u:
					Admit.smethod_18((Control)(object)StatusTxt, new Point(266, 198));
					num = ((int)num2 * -387767625) ^ 0x3EDCEEF1;
					continue;
				case 66u:
					Admit.smethod_17((Control)(object)Label2, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 604603904) ^ 0x663542B8);
					continue;
				case 65u:
					DateOut1Txt = Admit.smethod_6();
					num = (int)(num2 * 13739182) ^ -1436972406;
					continue;
				case 64u:
					num = ((int)num2 * -1510528510) ^ 0x204BA27B;
					continue;
				case 63u:
					num = ((int)num2 * -923970630) ^ -1895321882;
					continue;
				case 62u:
					num = (int)((num2 * 1851959460) ^ 0x3CCC92AF);
					continue;
				case 61u:
					num = (int)((num2 * 1747495822) ^ 0x714FA326);
					continue;
				case 60u:
					Admit.smethod_17((Control)(object)Label1, Admit.smethod_16("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -2016139491) ^ -98165707;
					continue;
				case 59u:
					Admit.smethod_23(Label1, (ContentAlignment)32);
					num = (int)(num2 * 378200367) ^ -174462044;
					continue;
				case 58u:
					Admit.smethod_21((Control)(object)PatientInfoBox, 7);
					num = ((int)num2 * -1596478700) ^ 0x7E024B64;
					continue;
				case 57u:
					Admit.smethod_17((Control)(object)Label8, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 613594842) ^ -698368364;
					continue;
				case 56u:
					Admit.smethod_18((Control)(object)SearchResultGrid, new Point(59, 295));
					num = ((int)num2 * -1925204017) ^ 0x2516AE80;
					continue;
				case 55u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)AdmitDetailsBox);
					num = (int)((num2 * 739058395) ^ 0x1ACDEF4F);
					continue;
				case 54u:
					num = ((int)num2 * -1141716795) ^ -2123777388;
					continue;
				case 53u:
					Admit.smethod_20((Control)(object)Label12, new Size(101, 28));
					Admit.smethod_21((Control)(object)Label12, 11);
					num = (int)(num2 * 1671874475) ^ -30756081;
					continue;
				case 52u:
					Admit.smethod_38((TextBoxBase)(object)AgeTxt, bool_0: true);
					num = ((int)num2 * -1147732157) ^ 0x79C3A4DE;
					continue;
				case 51u:
					Admit.smethod_19((Control)(object)Label14, "Label14");
					num = ((int)num2 * -571308830) ^ -1670801019;
					continue;
				case 50u:
					num = (int)(num2 * 635558171) ^ -1114085284;
					continue;
				case 49u:
					Admit.smethod_23(Label8, (ContentAlignment)32);
					num = (int)(num2 * 252275285) ^ -25723319;
					continue;
				case 48u:
					Admit.smethod_21((Control)(object)DateInTxt, 16);
					num = ((int)num2 * -845936219) ^ 0x4C0ED03F;
					continue;
				case 47u:
					Admit.smethod_17((Control)(object)PatientInfoBox, Admit.smethod_16("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -361770745) ^ -91413908;
					continue;
				case 46u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)PictureBox1);
					num = (int)((num2 * 196605767) ^ 0x66F22777);
					continue;
				case 45u:
					Admit.smethod_19((Control)(object)Label5, "Label5");
					num = (int)(num2 * 1673672769) ^ -1411696563;
					continue;
				case 44u:
					Admit.smethod_17((Control)(object)DateInTxt, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Admit.smethod_41((ListControl)(object)DateInTxt, bool_0: true);
					num = ((int)num2 * -1907230289) ^ 0x44FF343B;
					continue;
				case 43u:
					Admit.smethod_38((TextBoxBase)(object)AddressTxt, bool_0: true);
					num = ((int)num2 * -1312841828) ^ -1640377390;
					continue;
				case 42u:
					num = ((int)num2 * -546234328) ^ 0x60451A3A;
					continue;
				case 41u:
					num = (int)(num2 * 414534983) ^ -890274090;
					continue;
				case 40u:
					num = ((int)num2 * -180664048) ^ -583536379;
					continue;
				case 39u:
					Admit.smethod_19((Control)(object)HistoryBtn, "HistoryBtn");
					num = ((int)num2 * -1719219468) ^ 0x24F0689D;
					continue;
				case 38u:
					Label15 = Admit.smethod_3();
					num = (int)(num2 * 1552020250) ^ -686975872;
					continue;
				case 37u:
					num = ((int)num2 * -338512142) ^ 0x235160D4;
					continue;
				case 36u:
					Admit.smethod_55((Control)(object)GroupBox1, bool_0: false);
					num = (int)((num2 * 803413424) ^ 0x1F0D8B32);
					continue;
				case 35u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)GroupBox1), (Control)(object)Label2);
					num = ((int)num2 * -731406741) ^ 0x35019D01;
					continue;
				case 34u:
					Admit.smethod_17((Control)(object)AgeTxt, Admit.smethod_16("MS Reference Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -636711386) ^ 0x77BD9956;
					continue;
				case 33u:
					num = ((int)num2 * -1279750825) ^ -1603190068;
					continue;
				case 32u:
					num = (int)(num2 * 91148475) ^ -1658822208;
					continue;
				case 31u:
					Admit.smethod_20((Control)(object)SearchResultGrid, new Size(853, 169));
					num = ((int)num2 * -880177456) ^ 0x440A3CAF;
					continue;
				case 30u:
					RoomNo1Txt = Admit.smethod_6();
					num = ((int)num2 * -213558587) ^ -66680160;
					continue;
				case 29u:
					Admit.smethod_19((Control)(object)Label9, "Label9");
					num = (int)((num2 * 491315910) ^ 0x411DF884);
					continue;
				case 28u:
					Admit.smethod_17((Control)(object)Label13, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -516426647) ^ -315349431;
					continue;
				case 27u:
					PrintDocument1 = Admit.smethod_10();
					PictureBox1 = Admit.smethod_11();
					num = ((int)num2 * -343737104) ^ 0x57345AC2;
					continue;
				case 26u:
					Admit.smethod_46(PictureBox1, (PictureBoxSizeMode)1);
					num = ((int)num2 * -1008617700) ^ -393581188;
					continue;
				case 25u:
					Admit.smethod_19((Control)(object)ClearBtn, "ClearBtn");
					num = ((int)num2 * -1969632564) ^ 0x5BCCA053;
					continue;
				case 24u:
					num = (int)((num2 * 857130495) ^ 0x21807F30);
					continue;
				case 23u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)AddressTxt);
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)GenderTxt);
					num = ((int)num2 * -1393302789) ^ -350497419;
					continue;
				case 22u:
					Admit.smethod_20((Control)(object)Label9, new Size(122, 28));
					num = ((int)num2 * -1520933917) ^ -1093506764;
					continue;
				case 21u:
					Admit.smethod_37((Control)(object)SearchResultGrid, bool_0: false);
					num = (int)(num2 * 736858924) ^ -382327061;
					continue;
				case 20u:
					Admit.smethod_49((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -358556663) ^ -1645522886;
					continue;
				case 19u:
					num = (int)((num2 * 1565251576) ^ 0x47DAD946);
					continue;
				case 18u:
					Admit.smethod_21((Control)(object)AdmitDischargeBtn, 19);
					num = (int)((num2 * 832761605) ^ 0x692305D1);
					continue;
				case 17u:
					Admit.smethod_37((Control)(object)PrintBtn, bool_0: false);
					num = ((int)num2 * -2086059260) ^ 0x15609FC2;
					continue;
				case 16u:
					Admit.smethod_19((Control)(object)AgeTxt, "AgeTxt");
					num = ((int)num2 * -517739247) ^ 0x124FA386;
					continue;
				case 15u:
					num = ((int)num2 * -557554216) ^ -1411424978;
					continue;
				case 14u:
					Admit.smethod_20((Control)(object)FeesTxt, new Size(86, 28));
					Admit.smethod_21((Control)(object)FeesTxt, 9);
					Admit.smethod_17((Control)(object)Label10, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -989113725) ^ 0x699F45D3;
					continue;
				case 13u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)DateIn1Txt);
					num = ((int)num2 * -1067507476) ^ 0x7761C5A2;
					continue;
				case 12u:
					Admit.smethod_18((Control)(object)RoomNo1Txt, new Point(161, 32));
					num = (int)(num2 * 1513659681) ^ -727883191;
					continue;
				case 11u:
					Admit.smethod_29((Control)(object)HistoryBtn, Color.White);
					num = (int)((num2 * 736522835) ^ 0x1765A0E2);
					continue;
				case 10u:
					Admit.smethod_18((Control)(object)Label8, new Point(18, 34));
					num = (int)(num2 * 984837287) ^ -1126406897;
					continue;
				case 9u:
					num = ((int)num2 * -671953949) ^ 0x8D7543B;
					continue;
				case 8u:
					Admit.smethod_18((Control)(object)Label13, new Point(18, 157));
					Admit.smethod_19((Control)(object)Label13, "Label13");
					num = ((int)num2 * -2111885581) ^ 0x20E1C2E;
					continue;
				case 7u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)Label6);
					num = (int)(num2 * 1091059367) ^ -1003974539;
					continue;
				case 6u:
					num = ((int)num2 * -1162961647) ^ -1840096187;
					continue;
				case 5u:
					Admit.smethod_20((Control)(object)Label10, new Size(79, 25));
					Admit.smethod_21((Control)(object)Label10, 3);
					Admit.smethod_22(Label10, "Fees  :");
					num = (int)(num2 * 1257048421) ^ -843788855;
					continue;
				case 4u:
					Admit.smethod_28((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					num = (int)((num2 * 1996802930) ^ 0x6C134311);
					continue;
				case 3u:
					Admit.smethod_17((Control)(object)ClearBtn, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 333184728) ^ 0x3A2BB8ED);
					continue;
				case 2u:
					Admit.smethod_20((Control)(object)Label14, new Size(77, 25));
					num = (int)((num2 * 651961496) ^ 0x1A89F2FE);
					continue;
				case 1u:
					Admit.smethod_19((Control)(object)RoomNo1Txt, "RoomNo1Txt");
					num = ((int)num2 * -572246906) ^ -1556845780;
					continue;
				case 0u:
					Admit.smethod_18((Control)(object)Label10, new Point(18, 201));
					num = ((int)num2 * -1831145589) ^ 0x16690E06;
					continue;
				case 300u:
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
			int num = 2060199524;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8AE4599u) % 5u)
				{
				case 4u:
					num = (int)((num2 * 1294766005) ^ 0x3D0CB5CC);
					continue;
				case 3u:
					HideItemsOnForm();
					Admit.smethod_70(Admit.smethod_42(DateInTxt), (object)Admit.smethod_69((object)Admit.smethod_68(), "dd-MM-yyyy"));
					num = (int)(num2 * 944239717) ^ -1937217731;
					continue;
				case 2u:
					Admit.smethod_70(Admit.smethod_42(DateOutTxt), (object)Admit.smethod_68());
					Admit.smethod_71(Admit.smethod_42(RoomNoTxt));
					num = (int)(num2 * 523967771) ^ -2005755726;
					continue;
				case 0u:
					break;
				default:
					Add_Rooms();
					return;
				}
				break;
			}
		}
	}

	private void SearchBtn_Click(object sender, EventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected I4, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected I4, but got Unknown
		//IL_02dd: Incompatible stack heights: 0 vs 1
		//IL_02f2: Incompatible stack heights: 0 vs 1
		//IL_0302: Incompatible stack heights: 0 vs 1
		//IL_0309: Incompatible stack heights: 0 vs 1
		HideItemsOnForm();
		bool flag2 = default(bool);
		string string_ = default(string);
		DataTable dataTable = default(DataTable);
		bool flag = default(bool);
		while (true)
		{
			int num = -775716046;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF68470F4u) % 8u)
				{
				case 7u:
					Admit.smethod_74("No Results Found");
					num = ((int)num2 * -1152093807) ^ 0x445DEEF0;
					continue;
				case 6u:
					flag2 = !MyProject.Forms.Form1.Name_Validation(Admit.smethod_73(Admit.smethod_72(NameSTxt))) | !MyProject.Forms.Form1.Mobile_Validator(Admit.smethod_73(Admit.smethod_72(MobileTxt)));
					num = (int)((num2 * 53047544) ^ 0x6D4C2445);
					continue;
				case 5u:
					num = -1327565480;
					continue;
				case 4u:
					Admit.smethod_75();
					string_ = Admit.smethod_76(new string[5]
					{
						"Select * From [Patient] Where [Name] Like '%",
						Admit.smethod_73(Admit.smethod_72(NameSTxt)),
						"%' And [Mobile] Like '%",
						Admit.smethod_72(MobileTxt),
						"%';"
					});
					dataTable = Admit.smethod_77();
					num = (int)((num2 * 644248874) ^ 0x71416136);
					continue;
				case 1u:
				{
					int num6;
					int num7;
					if (!flag2)
					{
						num6 = 1106671884;
						num7 = 1106671884;
					}
					else
					{
						num6 = 1365352246;
						num7 = 1365352246;
					}
					num = num6 ^ ((int)num2 * -1892976347);
					continue;
				}
				case 0u:
					break;
				default:
					Admit.smethod_78(myconnection);
					try
					{
						OleDbDataAdapter dbDataAdapter_ = Admit.smethod_79(string_, myconnection);
						Admit.smethod_80((DbDataAdapter)(object)dbDataAdapter_, dataTable);
						Admit.smethod_81(SearchResultGrid, (object)dataTable);
						while (true)
						{
							int num3 = -106933672;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xF68470F4u) % 11u)
								{
								case 8u:
									Admit.smethod_83(myconnection);
									num3 = (int)((num2 * 2052941132) ^ 0xDDB2533);
									continue;
								case 7u:
									flag = Admit.smethod_82(SearchResultGrid) == 1;
									num3 = ((int)num2 * -397541119) ^ 0x2F39C6D9;
									continue;
								case 6u:
									Admit.smethod_37((Control)(object)SearchResultGrid, bool_0: true);
									Admit.smethod_83(myconnection);
									num3 = (int)(num2 * 284854396) ^ -1892471464;
									continue;
								case 5u:
									num3 = -1659695739;
									continue;
								case 3u:
									Admit.smethod_74("No Result Found");
									num3 = (int)(num2 * 1569374024) ^ -781916413;
									continue;
								case 2u:
									num3 = ((int)num2 * -2031773041) ^ -1500393497;
									continue;
								case 1u:
									num3 = (int)((num2 * 84100254) ^ 0x218C1DFD);
									continue;
								case 0u:
								{
									int num4;
									int num5;
									if (!flag)
									{
										num4 = 2143417375;
										num5 = 2143417375;
									}
									else
									{
										num4 = 1555659481;
										num5 = 1555659481;
									}
									num3 = num4 ^ (int)(num2 * 665553713);
									continue;
								}
								default:
									return;
								case 4u:
									break;
								case 9u:
									return;
								case 10u:
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
							_ = -2125112944;
							while (true)
							{
								_003F val = /*Error near IL_02a4: Stack underflow*/^ -159092492;
								num2 = (uint)(int)val;
								switch (val % 5)
								{
								default:
									return;
								case 4:
									Admit.smethod_83(myconnection);
									_ = ((int)num2 * -272991014) ^ 0x3AD79105;
									continue;
								case 3:
									Admit.smethod_85();
									_ = (num2 * 76073234) ^ 0xBA051250u;
									continue;
								case 0:
									_ = (num2 * 1300784056) ^ 0xCDEAEF1Cu;
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
				case 3u:
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
			int num = 956517212;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3404B165u) % 5u)
				{
				case 4u:
					Admit.smethod_75();
					performQueryStatement();
					num = 40876550;
					continue;
				case 3u:
					num = ((int)num2 * -746707046) ^ -2074260544;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (Validate_Print_Data())
					{
						num3 = -1258514027;
						num4 = -1258514027;
					}
					else
					{
						num3 = -609425413;
						num4 = -609425413;
					}
					num = num3 ^ (int)(num2 * 1086365049);
					continue;
				}
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

	private bool HideItemsOnForm()
	{
		bool result = default(bool);
		while (true)
		{
			int num = -2005743793;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAFBC77A5u) % 15u)
				{
				case 14u:
					num = ((int)num2 * -833289723) ^ -1479399825;
					continue;
				case 12u:
					num = ((int)num2 * -2130984216) ^ 0xF811DB3;
					continue;
				case 11u:
					num = (int)((num2 * 1419653725) ^ 0x2E8B8F56);
					continue;
				case 10u:
					Admit.smethod_37((Control)(object)SearchResultGrid, bool_0: false);
					num = ((int)num2 * -884935889) ^ -112080436;
					continue;
				case 9u:
					Admit.smethod_37((Control)(object)AdmitDetailsBox, bool_0: false);
					num = ((int)num2 * -2059424956) ^ 0x70ABB6D;
					continue;
				case 7u:
					Admit.smethod_37((Control)(object)PrintBtn, bool_0: false);
					num = (int)((num2 * 1240104170) ^ 0x62CC8F90);
					continue;
				case 6u:
					Admit.smethod_37((Control)(object)HistoryBtn, bool_0: false);
					num = (int)(num2 * 2062557009) ^ -1652745203;
					continue;
				case 5u:
					num = ((int)num2 * -532219732) ^ -32303994;
					continue;
				case 4u:
					num = (int)((num2 * 677168592) ^ 0x1CF8BCC7);
					continue;
				case 3u:
					Admit.smethod_37((Control)(object)AdmitDischargeBtn, bool_0: false);
					result = true;
					num = (int)(num2 * 1789273836) ^ -497180010;
					continue;
				case 2u:
					Admit.smethod_37((Control)(object)SaveBtn, bool_0: false);
					num = (int)((num2 * 939238660) ^ 0x7CE653A0);
					continue;
				case 1u:
					Admit.smethod_37((Control)(object)PatientInfoBox, bool_0: false);
					num = ((int)num2 * -1618881128) ^ 0x2AA8CF4;
					continue;
				case 0u:
					Admit.smethod_37((Control)(object)ClearBtn, bool_0: false);
					num = ((int)num2 * -1797406788) ^ -313585806;
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
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected I4, but got Unknown
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected I4, but got Unknown
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Incompatible stack heights: 0 vs 1
		//IL_045f: Incompatible stack heights: 0 vs 1
		//IL_047a: Incompatible stack heights: 0 vs 1
		//IL_048f: Incompatible stack heights: 0 vs 1
		//IL_0499: Incompatible stack heights: 0 vs 1
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b1: Expected I4, but got Unknown
		//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Expected I4, but got Unknown
		//IL_06e5: Incompatible stack heights: 0 vs 1
		//IL_06f5: Incompatible stack heights: 0 vs 1
		//IL_0710: Incompatible stack heights: 0 vs 1
		//IL_071c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0730: Incompatible stack heights: 0 vs 1
		//IL_073a: Incompatible stack heights: 0 vs 1
		OleDbCommand val = Admit.smethod_75();
		string text = default(string);
		string result = default(string);
		DateTime dateTime_ = default(DateTime);
		while (true)
		{
			int num = -1430142403;
			while (true)
			{
				int num5;
				int num6;
				uint num2;
				switch ((num2 = (uint)num ^ 0xBDB343F0u) % 5u)
				{
				case 3u:
					if (Admit.smethod_87(Admit.smethod_72(DateIn1Txt), "", bool_0: false) == 0)
					{
						num = (int)(num2 * 1479341278) ^ -1957143459;
						continue;
					}
					while ((Admit.smethod_87(Admit.smethod_72(DateIn1Txt), "", bool_0: false) != 0) & (Admit.smethod_87(Admit.smethod_72(DateOut1Txt), "", bool_0: false) == 0))
					{
						int num4 = -797609915;
						while (true)
						{
							switch ((num2 = (uint)num4 ^ 0xBDB343F0u) % 3u)
							{
							case 0u:
								num4 = -312113351;
								continue;
							case 1u:
								break;
							default:
								goto IL_0116;
							}
							break;
						}
					}
					goto IL_024f;
				case 1u:
					dateTime_ = Admit.smethod_86(Admit.smethod_69((object)DateTime.Now, "dd-MM-yyyy"));
					num = ((int)num2 * -857524824) ^ 0x5D1059D5;
					continue;
				case 0u:
					text = "Insert Into [Admit-Discharge] ([DateIn],[PID],[Fee Status],[Room No],[Room type]) Values (?,?,?,?,?);";
					Admit.smethod_78(myconnection);
					num = (int)((num2 * 1810962524) ^ 0xC089466);
					continue;
				case 2u:
					break;
				default:
					{
						try
						{
							while (true)
							{
								IL_0690:
								int num3 = -286569662;
								while (true)
								{
									switch ((num2 = (uint)num3 ^ 0xBDB343F0u) % 11u)
									{
									case 10u:
										Admit.smethod_92(Admit.smethod_89(val), Admit.smethod_91("Room No", (object)Admit.smethod_93(Admit.smethod_94(RoomNoTxt))));
										Admit.smethod_92(Admit.smethod_89(val), Admit.smethod_91("Room Type", (object)Admit.smethod_95(Admit.smethod_94(RoomTypeTxt))));
										num3 = (int)(num2 * 1172907254) ^ -446489159;
										continue;
									case 9u:
										UpdateTable();
										num3 = ((int)num2 * -1121783674) ^ 0x50704C2C;
										continue;
									case 7u:
										num3 = (int)(num2 * 1408539198) ^ -212188315;
										continue;
									case 6u:
										Admit.smethod_92(Admit.smethod_89(val), Admit.smethod_91("DateIn", (object)Admit.smethod_90(dateTime_)));
										num3 = (int)((num2 * 464420589) ^ 0x60AF0DF0);
										continue;
									case 5u:
										Admit.smethod_92(Admit.smethod_89(val), Admit.smethod_91("Fee Status", (object)Admit.smethod_94(StatusTxt)));
										num3 = (int)(num2 * 1101919479) ^ -1929759078;
										continue;
									case 4u:
										Admit.smethod_96(val);
										Admit.smethod_97((Component)(object)val);
										Admit.smethod_83(myconnection);
										num3 = ((int)num2 * -80236666) ^ -629340285;
										continue;
									case 2u:
										Admit.smethod_74("Successfully Updated Details");
										Update_Rooms(Admit.smethod_94(RoomNoTxt), "No");
										num3 = ((int)num2 * -1465724472) ^ 0x251C6879;
										continue;
									case 1u:
										val = Admit.smethod_88(text, myconnection);
										num3 = ((int)num2 * -1470499009) ^ -1098643389;
										continue;
									case 0u:
										Admit.smethod_92(Admit.smethod_89(val), Admit.smethod_91("PID", (object)Admit.smethod_93(Admit.smethod_72(PIDTxt))));
										num3 = ((int)num2 * -1009424515) ^ 0x139C9259;
										continue;
									default:
										goto end_IL_0651;
									case 8u:
										break;
									case 3u:
										goto end_IL_0651;
									}
									goto IL_0690;
									continue;
									end_IL_0651:
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
								IL_0735:
								_ = -953054521;
								while (true)
								{
									_003F val2 = /*Error near IL_06ae: Stack underflow*/^ -1112325136;
									num2 = (uint)(int)val2;
									switch (val2 % 6)
									{
									default:
										goto end_IL_06a8;
									case 4:
										Admit.smethod_85();
										_ = (num2 * 437343444) ^ 0x859178EAu;
										continue;
									case 3:
										_ = (num2 * 820489674) ^ 0xE35183FEu;
										continue;
									case 1:
										Admit.smethod_83(myconnection);
										_ = (num2 * 570836101) ^ 0xE117DF02u;
										continue;
									case 0:
										Admit.smethod_98("Cannot proceed with the request!", "INVALID REQUEST");
										_ = ((int)num2 * -1670841665) ^ 0x1F1978E2;
										continue;
									case 5:
										break;
									case 2:
										goto end_IL_06a8;
									}
									goto IL_0735;
									continue;
									end_IL_06a8:
									break;
								}
								break;
							}
						}
						goto IL_078c;
					}
					IL_078c:
					result = text;
					num5 = -717805438;
					goto IL_0746;
					IL_0302:
					num6 = -293402280;
					goto IL_02c1;
					IL_0116:
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
					Admit.smethod_78(myconnection);
					try
					{
						val = Admit.smethod_88(text, myconnection);
						while (true)
						{
							IL_0210:
							int num7 = -2002670929;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0xBDB343F0u) % 4u)
								{
								case 3u:
									Admit.smethod_96(val);
									Admit.smethod_97((Component)(object)val);
									num7 = (int)((num2 * 1334386847) ^ 0x2CF607D9);
									continue;
								case 0u:
									Admit.smethod_83(myconnection);
									Admit.smethod_74("Successfully Updated Details");
									Update_Rooms(Admit.smethod_72(RoomNo1Txt), "Yes");
									num7 = ((int)num2 * -1040458505) ^ 0x6F02BCE1;
									continue;
								case 2u:
									break;
								default:
									UpdateTable();
									goto end_IL_01ee;
								}
								goto IL_0210;
								continue;
								end_IL_01ee:
								break;
							}
							break;
						}
					}
					catch (Exception exception_2)
					{
						Admit.smethod_84(exception_2);
						Admit.smethod_83(myconnection);
						Admit.smethod_98("Cannot proceed with the request!", "INVALID REQUEST");
						Admit.smethod_85();
					}
					goto IL_0302;
					IL_024f:
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
					num6 = -1521053580;
					goto IL_02c1;
					IL_02c1:
					while (true)
					{
						switch ((num2 = (uint)num6 ^ 0xBDB343F0u) % 5u)
						{
						case 4u:
							break;
						case 1u:
							Admit.smethod_78(myconnection);
							num6 = ((int)num2 * -2004806333) ^ -765589077;
							continue;
						case 0u:
							goto IL_0302;
						default:
							goto IL_0309;
						case 3u:
							goto IL_078c;
						}
						break;
					}
					goto IL_024f;
					IL_0309:
					try
					{
						while (true)
						{
							IL_03ef:
							int num8 = -308924127;
							while (true)
							{
								switch ((num2 = (uint)num8 ^ 0xBDB343F0u) % 9u)
								{
								case 8u:
									num8 = ((int)num2 * -1573854780) ^ -1396654614;
									continue;
								case 6u:
									UpdateTable();
									num8 = ((int)num2 * -1717226735) ^ -827504355;
									continue;
								case 5u:
									val = Admit.smethod_88(text, myconnection);
									num8 = (int)((num2 * 2106703576) ^ 0x656DAAFB);
									continue;
								case 3u:
									Admit.smethod_96(val);
									num8 = ((int)num2 * -1340716450) ^ 0x1C2AEFE3;
									continue;
								case 2u:
									Admit.smethod_83(myconnection);
									num8 = ((int)num2 * -1967773507) ^ 0x4B7FC344;
									continue;
								case 1u:
									Admit.smethod_97((Component)(object)val);
									num8 = ((int)num2 * -936214110) ^ -1923306946;
									continue;
								case 0u:
									Admit.smethod_74("Successfully Updated Details");
									num8 = (int)(num2 * 932457240) ^ -966525298;
									continue;
								default:
									goto end_IL_03b8;
								case 7u:
									break;
								case 4u:
									goto end_IL_03b8;
								}
								goto IL_03ef;
								continue;
								end_IL_03b8:
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
							IL_0494:
							_ = -1052512741;
							while (true)
							{
								_003F val3 = /*Error near IL_040d: Stack underflow*/^ -1112325136;
								num2 = (uint)(int)val3;
								switch (val3 % 6)
								{
								default:
									goto end_IL_0407;
								case 5:
									Admit.smethod_98("Cannot proceed with the request!", "INVALID REQUEST");
									_ = (num2 * 1995670980) ^ 0x259EE850;
									continue;
								case 3:
									_ = (num2 * 1098976424) ^ 0xEA4C9D2Du;
									continue;
								case 1:
									Admit.smethod_83(myconnection);
									_ = (num2 * 1518782124) ^ 0x72FA9D31;
									continue;
								case 0:
									Admit.smethod_85();
									_ = ((int)num2 * -2119564296) ^ 0x4A5E9052;
									continue;
								case 4:
									break;
								case 2:
									goto end_IL_0407;
								}
								goto IL_0494;
								continue;
								end_IL_0407:
								break;
							}
							break;
						}
					}
					goto IL_0741;
					IL_0741:
					num5 = -1912696916;
					goto IL_0746;
					IL_0746:
					while (true)
					{
						switch ((num2 = (uint)num5 ^ 0xBDB343F0u) % 5u)
						{
						case 4u:
							break;
						case 2u:
							num5 = ((int)num2 * -1729532850) ^ -1046319503;
							continue;
						case 1u:
							num5 = (int)(num2 * 1711943277) ^ -190293814;
							continue;
						case 0u:
							goto IL_078c;
						default:
							return result;
						}
						break;
					}
					goto IL_0741;
				}
				break;
			}
		}
	}

	private void SearchResultGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected I4, but got Unknown
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Expected I4, but got Unknown
		//IL_0489: Incompatible stack heights: 0 vs 1
		//IL_0498: Incompatible stack heights: 0 vs 1
		//IL_049f: Incompatible stack heights: 0 vs 1
		try
		{
			while (true)
			{
				int num = 722495011;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x608217BBu) % 28u)
					{
					case 27u:
						num = ((int)num2 * -479358063) ^ -38849930;
						continue;
					case 26u:
						Admit.smethod_37((Control)(object)PrintBtn, bool_0: false);
						num = ((int)num2 * -1044392387) ^ 0x5889E2C5;
						continue;
					case 25u:
						Admit.smethod_37((Control)(object)PatientInfoBox, bool_0: true);
						Admit.smethod_37((Control)(object)ClearBtn, bool_0: false);
						num = (int)(num2 * 710612358) ^ -2002418693;
						continue;
					case 24u:
						Admit.smethod_37((Control)(object)SaveBtn, bool_0: false);
						num = (int)((num2 * 641567723) ^ 0x50FA3581);
						continue;
					case 23u:
						Admit.smethod_37((Control)(object)AdmitDetailsBox, bool_0: false);
						num = ((int)num2 * -1815961984) ^ 0x4CC5BC58;
						continue;
					case 22u:
						Admit.smethod_106(MobileSTxt, Admit.smethod_105(Admit.smethod_104(Admit.smethod_103(Admit.smethod_102(Admit.smethod_101(Admit.smethod_99(SearchResultGrid), Admit.smethod_100(e))), 4))));
						num = ((int)num2 * -1210546286) ^ 0x3525E90C;
						continue;
					case 21u:
						Admit.smethod_106(AgeTxt, Admit.smethod_105(Admit.smethod_104(Admit.smethod_103(Admit.smethod_102(Admit.smethod_101(Admit.smethod_99(SearchResultGrid), Admit.smethod_100(e))), 2))));
						num = (int)(num2 * 1300432914) ^ -826618380;
						continue;
					case 19u:
						Admit.smethod_106(GenderTxt, Admit.smethod_105(Admit.smethod_104(Admit.smethod_103(Admit.smethod_102(Admit.smethod_101(Admit.smethod_99(SearchResultGrid), Admit.smethod_100(e))), 3))));
						num = (int)(num2 * 1103796970) ^ -823027661;
						continue;
					case 18u:
						Admit.smethod_107(RoomTypeTxt, -1);
						num = (int)(num2 * 296264513) ^ -1112987038;
						continue;
					case 16u:
						Admit.smethod_106(NameTxt, Admit.smethod_105(Admit.smethod_104(Admit.smethod_103(Admit.smethod_102(Admit.smethod_101(Admit.smethod_99(SearchResultGrid), Admit.smethod_100(e))), 1))));
						num = ((int)num2 * -995284996) ^ 0x5CF3D0B2;
						continue;
					case 15u:
						Admit.smethod_108((TextBoxBase)(object)FeesTxt);
						num = ((int)num2 * -1611719678) ^ 0x30DF4118;
						continue;
					case 14u:
						num = ((int)num2 * -782967164) ^ -186455342;
						continue;
					case 13u:
						num = ((int)num2 * -627666244) ^ 0x2D4608B4;
						continue;
					case 12u:
						Admit.smethod_106(PIDTxt, Admit.smethod_105(Admit.smethod_104(Admit.smethod_103(Admit.smethod_102(Admit.smethod_101(Admit.smethod_99(SearchResultGrid), Admit.smethod_100(e))), 0))));
						num = ((int)num2 * -794452622) ^ 0x7B2A348D;
						continue;
					case 11u:
						num = ((int)num2 * -2120830715) ^ -485917465;
						continue;
					case 10u:
						Admit.smethod_108((TextBoxBase)(object)DateOut1Txt);
						Admit.smethod_107(StatusTxt, -1);
						num = (int)(num2 * 595242968) ^ -458848400;
						continue;
					case 9u:
						Admit.smethod_108((TextBoxBase)(object)DateIn1Txt);
						num = ((int)num2 * -159703415) ^ -565358756;
						continue;
					case 8u:
						Admit.smethod_37((Control)(object)AdmitDischargeBtn, bool_0: true);
						num = ((int)num2 * -1049657695) ^ 0x103C146C;
						continue;
					case 7u:
						num = ((int)num2 * -1598821588) ^ -1580323365;
						continue;
					case 6u:
						num = (int)((num2 * 43845473) ^ 0x147461A1);
						continue;
					case 5u:
						Admit.smethod_107(RoomNoTxt, -1);
						num = (int)((num2 * 491724619) ^ 0x3C5DC8A);
						continue;
					case 4u:
						Admit.smethod_106(AddressTxt, Admit.smethod_105(Admit.smethod_104(Admit.smethod_103(Admit.smethod_102(Admit.smethod_101(Admit.smethod_99(SearchResultGrid), Admit.smethod_100(e))), 5))));
						num = ((int)num2 * -713414739) ^ -335136613;
						continue;
					case 3u:
						num = (int)(num2 * 1256770632) ^ -1128605150;
						continue;
					case 2u:
						Admit.smethod_107(DateInTxt, -1);
						Admit.smethod_107(DateOutTxt, -1);
						num = (int)(num2 * 122230822) ^ -858979490;
						continue;
					case 1u:
						num = (int)((num2 * 830857982) ^ 0x3BB82F9C);
						continue;
					case 0u:
						Admit.smethod_37((Control)(object)HistoryBtn, bool_0: true);
						num = (int)(num2 * 623431922) ^ -1318722309;
						continue;
					default:
						return;
					case 20u:
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
			Admit.smethod_84(exception_);
			while (true)
			{
				_ = 1807722829;
				while (true)
				{
					_003F val = /*Error near IL_045c: Stack underflow*/^ 0x608217BB;
					uint num2 = (uint)(int)val;
					switch (val % 4)
					{
					default:
						return;
					case 3:
						Admit.smethod_85();
						_ = ((int)num2 * -1207418887) ^ -2052468819;
						continue;
					case 2:
						_ = ((int)num2 * -857775353) ^ -1263968342;
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

	private bool UpdateTable()
	{
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected I4, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected I4, but got Unknown
		//IL_0253: Incompatible stack heights: 0 vs 1
		//IL_0268: Incompatible stack heights: 0 vs 1
		//IL_026f: Incompatible stack heights: 0 vs 1
		string string_ = default(string);
		DataTable dataTable = default(DataTable);
		OleDbDataAdapter dbDataAdapter_ = default(OleDbDataAdapter);
		bool flag = default(bool);
		while (true)
		{
			int num = -1868900119;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x90752598u) % 4u)
				{
				case 2u:
					string_ = Admit.smethod_76(new string[5]
					{
						"Select * From [Patient] Where [Name] Like '%",
						Admit.smethod_73(Admit.smethod_72(NameSTxt)),
						"%' And [Mobile] Like '%",
						Admit.smethod_72(MobileTxt),
						"%';"
					});
					dataTable = Admit.smethod_77();
					num = (int)((num2 * 53924373) ^ 0x3D462AC1);
					continue;
				case 1u:
					Admit.smethod_75();
					num = ((int)num2 * -2027175296) ^ -835851986;
					continue;
				case 0u:
					break;
				default:
					Admit.smethod_78(myconnection);
					try
					{
						while (true)
						{
							IL_0202:
							int num3 = -421402525;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x90752598u) % 13u)
								{
								case 12u:
									Admit.smethod_81(SearchResultGrid, (object)dataTable);
									num3 = (int)((num2 * 1147574128) ^ 0x14D77B74);
									continue;
								case 11u:
									Admit.smethod_37((Control)(object)SearchResultGrid, bool_0: true);
									num3 = ((int)num2 * -1047376089) ^ -1558418346;
									continue;
								case 9u:
									Admit.smethod_83(myconnection);
									num3 = ((int)num2 * -1968590039) ^ 0x6D31D67A;
									continue;
								case 8u:
									Admit.smethod_83(myconnection);
									num3 = ((int)num2 * -1238121079) ^ 0x33F2D915;
									continue;
								case 6u:
									dbDataAdapter_ = Admit.smethod_79(string_, myconnection);
									num3 = ((int)num2 * -814240607) ^ -495711006;
									continue;
								case 5u:
									num3 = ((int)num2 * -1956369644) ^ -157529921;
									continue;
								case 4u:
									flag = Admit.smethod_82(SearchResultGrid) == 1;
									num3 = (int)((num2 * 1693982147) ^ 0x50E86DFB);
									continue;
								case 3u:
									Admit.smethod_80((DbDataAdapter)(object)dbDataAdapter_, dataTable);
									num3 = (int)((num2 * 438556709) ^ 0x7D4AF072);
									continue;
								case 1u:
								{
									int num4;
									int num5;
									if (flag)
									{
										num4 = -593460212;
										num5 = -593460212;
									}
									else
									{
										num4 = -545927392;
										num5 = -545927392;
									}
									num3 = num4 ^ (int)(num2 * 1975103320);
									continue;
								}
								case 0u:
									num3 = -565710407;
									continue;
								default:
									goto end_IL_01bb;
								case 7u:
									break;
								case 2u:
									goto end_IL_01bb;
								case 10u:
									return false;
								}
								goto IL_0202;
								continue;
								end_IL_01bb:
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
							IL_026a:
							_ = -928623985;
							while (true)
							{
								_003F val = /*Error near IL_021e: Stack underflow*/^ -1871370856;
								num2 = (uint)(int)val;
								switch (val % 4)
								{
								default:
									goto end_IL_0218;
								case 3:
									Admit.smethod_83(myconnection);
									_ = (num2 * 951817294) ^ 0xD7D0B240u;
									continue;
								case 2:
									Admit.smethod_85();
									_ = ((int)num2 * -2005269584) ^ 0xE1E30D;
									continue;
								case 0:
									break;
								case 1:
									goto end_IL_0218;
								}
								goto IL_026a;
								continue;
								end_IL_0218:
								break;
							}
							break;
						}
					}
					return true;
				}
				break;
			}
		}
	}

	private void ClearBtn_Click(object sender, EventArgs e)
	{
		ClearPatientInfo();
		ClearAdmitDetails();
		Admit.smethod_71(Admit.smethod_42(RoomNoTxt));
		while (true)
		{
			int num = 938909511;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1DE38462u) % 3u)
				{
				case 1u:
					goto IL_0020;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0020:
				Add_Rooms();
				num = ((int)num2 * -1919844720) ^ -1732132136;
			}
		}
	}

	private bool ClearPatientInfo()
	{
		Admit.smethod_108((TextBoxBase)(object)PIDTxt);
		Admit.smethod_108((TextBoxBase)(object)NameTxt);
		bool result = default(bool);
		while (true)
		{
			int num = 2092461613;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x50943AE1u) % 5u)
				{
				case 4u:
					result = true;
					num = ((int)num2 * -509256235) ^ 0x7420F670;
					continue;
				case 3u:
					Admit.smethod_108((TextBoxBase)(object)AgeTxt);
					Admit.smethod_108((TextBoxBase)(object)AddressTxt);
					Admit.smethod_108((TextBoxBase)(object)GenderTxt);
					num = ((int)num2 * -458340159) ^ -1894904106;
					continue;
				case 1u:
					Admit.smethod_108((TextBoxBase)(object)MobileSTxt);
					num = ((int)num2 * -1450040034) ^ -1337463317;
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

	private bool ClearAdmitDetails()
	{
		bool result = default(bool);
		while (true)
		{
			int num = -442513382;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8DB58B67u) % 11u)
				{
				case 10u:
					Admit.smethod_108((TextBoxBase)(object)DateIn1Txt);
					num = ((int)num2 * -1917469899) ^ 0x64F27439;
					continue;
				case 9u:
					Admit.smethod_107(StatusTxt, -1);
					Admit.smethod_108((TextBoxBase)(object)FeesTxt);
					num = (int)(num2 * 1818290691) ^ -1332795512;
					continue;
				case 8u:
					Admit.smethod_107(DateInTxt, -1);
					num = ((int)num2 * -1829067485) ^ -1990710338;
					continue;
				case 7u:
					Admit.smethod_107(DateOutTxt, -1);
					num = (int)(num2 * 952781817) ^ -41421229;
					continue;
				case 6u:
					Admit.smethod_108((TextBoxBase)(object)DateOut1Txt);
					num = (int)((num2 * 1763744062) ^ 0x762263DA);
					continue;
				case 5u:
					num = ((int)num2 * -774860780) ^ -38386494;
					continue;
				case 3u:
					Admit.smethod_107(RoomNoTxt, -1);
					Admit.smethod_107(RoomTypeTxt, -1);
					Admit.smethod_108((TextBoxBase)(object)RoomNo1Txt);
					Admit.smethod_108((TextBoxBase)(object)RoomType1Txt);
					num = (int)((num2 * 104464405) ^ 0x3CCB5513);
					continue;
				case 2u:
					result = true;
					num = ((int)num2 * -1106604066) ^ 0x281550E8;
					continue;
				case 1u:
					num = ((int)num2 * -56091265) ^ -1102471937;
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

	private void PrintBtn_Click(object sender, EventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 634761821;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x16F9ED4Cu) % 19u)
				{
				case 18u:
					num = (int)(num2 * 1500586976) ^ -627489454;
					continue;
				case 17u:
					flag2 = (int)Admit.smethod_113((CommonDialog)(object)PrintDialog1) == 1;
					num = (int)(num2 * 2116670651) ^ -1217550493;
					continue;
				case 16u:
					num = (int)(num2 * 1677815660) ^ -1696273064;
					continue;
				case 15u:
					Admit.smethod_109(PrintDialog1, PrintDocument1);
					num = 1253673101;
					continue;
				case 14u:
					Admit.smethod_111(PrintDialog1, Admit.smethod_110(PrintDocument1));
					num = (int)((num2 * 275708387) ^ 0x48726F1F);
					continue;
				case 12u:
					Admit.smethod_112(PrintDialog1, bool_0: true);
					num = (int)((num2 * 871604309) ^ 0x76A134C7);
					continue;
				case 11u:
					Admit.smethod_74("No Patient to Print");
					num = ((int)num2 * -403138022) ^ -1744829224;
					continue;
				case 10u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = 1786859767;
						num8 = 1786859767;
					}
					else
					{
						num7 = 2009367973;
						num8 = 2009367973;
					}
					num = num7 ^ ((int)num2 * -2092444053);
					continue;
				}
				case 9u:
					Admit.smethod_116(PrintDocument1);
					num = ((int)num2 * -132867275) ^ 0x363252AA;
					continue;
				case 8u:
					num = 1956843664;
					continue;
				case 7u:
					num = ((int)num2 * -975395027) ^ -2016932492;
					continue;
				case 6u:
					flag = !Validate_Print_Data();
					num = (int)(num2 * 808620423) ^ -656063927;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (Admit.smethod_87(Admit.smethod_72(PIDTxt), "", bool_0: false) == 0)
					{
						num5 = -1192838205;
						num6 = -1192838205;
					}
					else
					{
						num5 = -513654470;
						num6 = -513654470;
					}
					num = num5 ^ ((int)num2 * -1536355174);
					continue;
				}
				case 3u:
					num = 1814271597;
					continue;
				case 2u:
					Admit.smethod_115(PrintDocument1, Admit.smethod_114(PrintDialog1));
					num = ((int)num2 * -823788478) ^ -2107906058;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 910601378;
						num4 = 910601378;
					}
					else
					{
						num3 = 653156704;
						num4 = 653156704;
					}
					num = num3 ^ (int)(num2 * 79109021);
					continue;
				}
				case 0u:
					num = ((int)num2 * -1524760538) ^ 0x415C7F83;
					continue;
				default:
					return;
				case 13u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
	{
		bool flag = Admit.smethod_117((Control)(object)RoomNo1Txt);
		Font font_ = default(Font);
		string string_ = default(string);
		string string_2 = default(string);
		while (true)
		{
			int num = 1696471570;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x487E0A6Eu) % 20u)
				{
				case 19u:
					num = ((int)num2 * -1508668068) ^ 0x7CB28F3E;
					continue;
				case 18u:
					Admit.smethod_121(Admit.smethod_119(e), Admit.smethod_66("Name - ", Admit.smethod_72(NameTxt)) ?? "", font_, Admit.smethod_120(), 100f, 150f);
					num = 1065726520;
					continue;
				case 16u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 919755120;
						num5 = 919755120;
					}
					else
					{
						num4 = 1818206747;
						num5 = 1818206747;
					}
					num = num4 ^ ((int)num2 * -1876001486);
					continue;
				}
				case 15u:
					num = ((int)num2 * -1324569701) ^ 0x493FCEB8;
					continue;
				case 14u:
					num = ((int)num2 * -1395553379) ^ -806813796;
					continue;
				case 13u:
					string_ = Admit.smethod_94(RoomTypeTxt);
					num = (int)(num2 * 1325393330) ^ -638938936;
					continue;
				case 12u:
					num = (int)(num2 * 1884778344) ^ -184812042;
					continue;
				case 11u:
					num = (int)((num2 * 353520147) ^ 0x6BB82171);
					continue;
				case 10u:
					Admit.smethod_121(Admit.smethod_119(e), Admit.smethod_66("Mobile - ", Admit.smethod_72(MobileTxt)) ?? "", font_, Admit.smethod_120(), 100f, 200f);
					num = 337203957;
					continue;
				case 9u:
					string_2 = Admit.smethod_72(RoomNo1Txt);
					num = (int)((num2 * 1734976009) ^ 0x5BAA7DFF);
					continue;
				case 8u:
				{
					Font font_2 = Admit.smethod_118("Times New Roman", 20f);
					font_ = Admit.smethod_118("Times New Roman", 12f);
					Admit.smethod_121(Admit.smethod_119(e), "Admit/Discharge", font_2, Admit.smethod_120(), 250f, 100f);
					num = 1596314225;
					continue;
				}
				case 7u:
					num = (int)(num2 * 1449014416) ^ -969500841;
					continue;
				case 6u:
					string_2 = Admit.smethod_94(RoomNoTxt);
					num = 962037948;
					continue;
				case 5u:
					num = 1214041847;
					continue;
				case 3u:
					Admit.smethod_121(Admit.smethod_119(e), Admit.smethod_66("Room No - ", string_2) ?? "", font_, Admit.smethod_120(), 100f, 250f);
					Admit.smethod_121(Admit.smethod_119(e), Admit.smethod_66("Room Type - ", string_) ?? "", font_, Admit.smethod_120(), 100f, 300f);
					num = 231697481;
					continue;
				case 2u:
					string_ = Admit.smethod_72(RoomType1Txt);
					num = ((int)num2 * -767627103) ^ 0x1462A317;
					continue;
				case 1u:
					Admit.smethod_121(Admit.smethod_119(e), Admit.smethod_66("Fees - ", Admit.smethod_72(FeesTxt)) ?? "", font_, Admit.smethod_120(), 100f, 350f);
					num = 764748154;
					continue;
				case 0u:
				{
					int num3;
					if (Admit.smethod_117((Control)(object)RoomType1Txt))
					{
						num = 368703288;
						num3 = 368703288;
					}
					else
					{
						num = 1336106403;
						num3 = 1336106403;
					}
					continue;
				}
				default:
					return;
				case 17u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void HistoryBtn_Click(object sender, EventArgs e)
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		bool flag = Admit.smethod_87(Admit.smethod_72(PIDTxt), "", bool_0: false) == 0;
		while (true)
		{
			int num = -302829789;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8C61E986u) % 7u)
				{
				case 6u:
					num = -13771566;
					continue;
				case 3u:
					MyProject.Forms.Form2.PID_Value = Admit.smethod_72(PIDTxt);
					Admit.smethod_122((Control)(object)MyProject.Forms.Form5);
					num = ((int)num2 * -1723414438) ^ 0x1F3023CB;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -106576637;
						num4 = -106576637;
					}
					else
					{
						num3 = -647372257;
						num4 = -647372257;
					}
					num = num3 ^ ((int)num2 * -794392357);
					continue;
				}
				case 1u:
					Admit.smethod_74("No Patient Selected");
					num = (int)((num2 * 1429329094) ^ 0x6E44DF78);
					continue;
				case 0u:
					num = ((int)num2 * -604751444) ^ 0x232B30D0;
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

	private void AdmitDischargeBtn_Click(object sender, EventArgs e)
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06aa: Expected I4, but got Unknown
		//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Expected I4, but got Unknown
		//IL_0719: Incompatible stack heights: 0 vs 1
		//IL_0734: Incompatible stack heights: 0 vs 1
		//IL_0747: Incompatible stack heights: 0 vs 1
		//IL_0766: Incompatible stack heights: 0 vs 1
		//IL_0785: Incompatible stack heights: 0 vs 1
		//IL_07a4: Incompatible stack heights: 0 vs 1
		//IL_07c3: Incompatible stack heights: 0 vs 1
		//IL_07e2: Incompatible stack heights: 0 vs 1
		//IL_07f5: Incompatible stack heights: 0 vs 1
		//IL_0808: Incompatible stack heights: 0 vs 1
		//IL_081b: Incompatible stack heights: 0 vs 1
		//IL_082e: Incompatible stack heights: 0 vs 1
		//IL_0859: Incompatible stack heights: 0 vs 1
		//IL_086c: Incompatible stack heights: 0 vs 1
		//IL_088b: Incompatible stack heights: 0 vs 1
		//IL_089e: Incompatible stack heights: 0 vs 1
		//IL_08a8: Incompatible stack heights: 0 vs 1
		//IL_08b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
		if (Admit.smethod_87(Admit.smethod_72(PIDTxt), "", bool_0: false) == 0)
		{
			goto IL_007c;
		}
		goto IL_00af;
		IL_00af:
		int num = 779562036;
		goto IL_0081;
		IL_0081:
		string string_ = default(string);
		bool flag2 = default(bool);
		OleDbDataReader oleDbDataReader_ = default(OleDbDataReader);
		bool flag = default(bool);
		int num4 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xAFB1969u) % 7u)
			{
			case 5u:
			{
				OleDbCommand oleDbCommand_ = Admit.smethod_75();
				num = ((int)num2 * -852599669) ^ 0x4623F14C;
				continue;
			}
			case 2u:
				string_ = Admit.smethod_123("Select * From [Admit-Discharge] Where [PID] = ", Admit.smethod_72(PIDTxt), ";");
				num = (int)((num2 * 275357882) ^ 0xE3C3463);
				continue;
			case 1u:
				Admit.smethod_78(myconnection);
				num = (int)((num2 * 1569821331) ^ 0x1A09E9A1);
				continue;
			case 0u:
				break;
			case 6u:
				goto IL_00af;
			case 3u:
				Admit.smethod_74("No Patient Selected");
				return;
			default:
				try
				{
					OleDbCommand oleDbCommand_ = Admit.smethod_88(string_, myconnection);
					while (true)
					{
						int num3 = 1734493864;
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0xAFB1969u) % 44u)
							{
							case 43u:
								Admit.smethod_37((Control)(object)PrintBtn, bool_0: true);
								num3 = ((int)num2 * -1525487199) ^ 0x6B9D0A70;
								continue;
							case 42u:
								Admit.smethod_37((Control)(object)RoomTypeTxt, bool_0: true);
								num3 = ((int)num2 * -1463051055) ^ -1629073136;
								continue;
							case 41u:
								num3 = ((int)num2 * -1292946284) ^ -403124717;
								continue;
							case 40u:
								flag2 = Admit.smethod_128(oleDbDataReader_);
								num3 = 1067861448;
								continue;
							case 39u:
								num3 = 1595341003;
								continue;
							case 38u:
								Admit.smethod_37((Control)(object)DateIn1Txt, bool_0: true);
								Admit.smethod_37((Control)(object)DateInTxt, bool_0: false);
								num3 = (int)((num2 * 1183503827) ^ 0x48123D28);
								continue;
							case 37u:
								num3 = ((int)num2 * -1936929668) ^ 0x23514AF;
								continue;
							case 36u:
								Admit.smethod_37((Control)(object)RoomNoTxt, bool_0: false);
								Admit.smethod_37((Control)(object)RoomNo1Txt, bool_0: true);
								num3 = ((int)num2 * -1531203470) ^ 0x4F75ECB3;
								continue;
							case 35u:
							{
								int num8;
								int num9;
								if (flag)
								{
									num8 = -1983394561;
									num9 = -1983394561;
								}
								else
								{
									num8 = -1498529326;
									num9 = -1498529326;
								}
								num3 = num8 ^ (int)(num2 * 1863869040);
								continue;
							}
							case 33u:
								Admit.smethod_37((Control)(object)ClearBtn, bool_0: true);
								num3 = ((int)num2 * -1863317843) ^ 0x16B761B3;
								continue;
							case 32u:
								num3 = (int)((num2 * 1002528734) ^ 0x179F93E5);
								continue;
							case 31u:
							{
								int num7;
								if ((Admit.smethod_87(Admit.smethod_126(Admit.smethod_125(oleDbDataReader_, 2)), "", bool_0: false) != 0) & (Admit.smethod_87(Admit.smethod_126(Admit.smethod_125(oleDbDataReader_, 3)), "", bool_0: false) == 0))
								{
									num3 = 252656273;
									num7 = 252656273;
								}
								else
								{
									num3 = 1880107664;
									num7 = 1880107664;
								}
								continue;
							}
							case 30u:
								Admit.smethod_37((Control)(object)DateOutTxt, bool_0: false);
								Admit.smethod_37((Control)(object)DateIn1Txt, bool_0: false);
								num3 = ((int)num2 * -1081521892) ^ 0x51EA89DD;
								continue;
							case 29u:
								num3 = ((int)num2 * -739681659) ^ 0x4861A1DE;
								continue;
							case 28u:
								Admit.smethod_37((Control)(object)AdmitDischargeBtn, bool_0: false);
								num3 = ((int)num2 * -986821346) ^ 0x65255ED;
								continue;
							case 27u:
								Admit.smethod_37((Control)(object)RoomNo1Txt, bool_0: false);
								num3 = (int)((num2 * 1238028638) ^ 0x651470F5);
								continue;
							case 26u:
								Admit.smethod_83(myconnection);
								num3 = 1709471497;
								continue;
							case 25u:
								num3 = 1672089177;
								continue;
							case 24u:
								num3 = ((int)num2 * -763443401) ^ -1111175375;
								continue;
							case 23u:
								num3 = ((int)num2 * -594374358) ^ -790205966;
								continue;
							case 22u:
								Admit.smethod_106(RoomType1Txt, Admit.smethod_126(Admit.smethod_125(oleDbDataReader_, 5)));
								Admit.smethod_37((Control)(object)RoomTypeTxt, bool_0: false);
								num3 = ((int)num2 * -1199215745) ^ -1688778734;
								continue;
							case 21u:
							{
								int num5;
								int num6;
								if (flag2)
								{
									num5 = -866317795;
									num6 = -866317795;
								}
								else
								{
									num5 = -537735468;
									num6 = -537735468;
								}
								num3 = num5 ^ (int)(num2 * 937004835);
								continue;
							}
							case 20u:
								Admit.smethod_37((Control)(object)DateInTxt, bool_0: true);
								num3 = ((int)num2 * -1666950156) ^ -401514014;
								continue;
							case 19u:
								Admit.smethod_37((Control)(object)RoomType1Txt, bool_0: true);
								num3 = (int)((num2 * 1112613290) ^ 0x55BD8D90);
								continue;
							case 17u:
								Admit.smethod_37((Control)(object)DateOut1Txt, bool_0: false);
								num3 = (int)(num2 * 1277585585) ^ -1105722926;
								continue;
							case 16u:
								Admit.smethod_37((Control)(object)RoomType1Txt, bool_0: false);
								Admit.smethod_37((Control)(object)RoomNoTxt, bool_0: true);
								num3 = ((int)num2 * -173570299) ^ -381284844;
								continue;
							case 15u:
								num3 = (int)((num2 * 784316947) ^ 0x4BFCAA33);
								continue;
							case 14u:
								Admit.smethod_37((Control)(object)SaveBtn, bool_0: true);
								num3 = ((int)num2 * -1134511923) ^ 0x2C38D477;
								continue;
							case 13u:
								oleDbDataReader_ = Admit.smethod_124(oleDbCommand_);
								num3 = ((int)num2 * -76450867) ^ 0x8BC6C9C;
								continue;
							case 12u:
								flag = num4 == 0;
								num3 = ((int)num2 * -1047358230) ^ -536382418;
								continue;
							case 11u:
								num3 = (int)((num2 * 2071435539) ^ 0x70B2B8E3);
								continue;
							case 10u:
								Admit.smethod_37((Control)(object)DateOut1Txt, bool_0: true);
								num3 = (int)((num2 * 284310051) ^ 0x7D0C48B6);
								continue;
							case 9u:
								num3 = (int)((num2 * 895899428) ^ 0x6609AEC5);
								continue;
							case 8u:
								Admit.smethod_37((Control)(object)AdmitDetailsBox, bool_0: true);
								num3 = ((int)num2 * -1774346690) ^ 0x60038560;
								continue;
							case 7u:
								Admit.smethod_127(StatusTxt, Admit.smethod_126(Admit.smethod_125(oleDbDataReader_, 6)));
								num3 = ((int)num2 * -1287682834) ^ -1978073751;
								continue;
							case 6u:
								num3 = ((int)num2 * -421541567) ^ -792234029;
								continue;
							case 5u:
								num3 = (int)((num2 * 349798978) ^ 0x1BD35873);
								continue;
							case 4u:
								num4 = 0;
								num3 = ((int)num2 * -974872304) ^ 0x4B3A519C;
								continue;
							case 3u:
								Admit.smethod_106(RoomNo1Txt, Admit.smethod_126(Admit.smethod_125(oleDbDataReader_, 4)));
								num3 = ((int)num2 * -611989482) ^ 0x7B6D032A;
								continue;
							case 2u:
								Admit.smethod_37((Control)(object)DateOutTxt, bool_0: true);
								id = Admit.smethod_126(Admit.smethod_125(oleDbDataReader_, 0));
								Admit.smethod_106(DateIn1Txt, Admit.smethod_105(Admit.smethod_125(oleDbDataReader_, 2)));
								num3 = (int)((num2 * 1203448503) ^ 0x3E3CE980);
								continue;
							case 1u:
								num3 = ((int)num2 * -417829205) ^ -1037893167;
								continue;
							case 0u:
								num4 = 1;
								num3 = ((int)num2 * -2006481696) ^ 0x1F4DFC8;
								continue;
							default:
								return;
							case 34u:
								break;
							case 18u:
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
					while (true)
					{
						_ = 580272472;
						while (true)
						{
							_003F val = /*Error near IL_06a7: Stack underflow*/^ 0xAFB1969;
							num2 = (uint)(int)val;
							switch (val % 18)
							{
							case 17:
								Admit.smethod_37((Control)(object)AdmitDetailsBox, bool_0: true);
								_ = ((int)num2 * -1803927530) ^ 0x1682B300;
								continue;
							case 16:
								Admit.smethod_83(myconnection);
								_ = (num2 * 774877194) ^ 0x2343FB35;
								continue;
							case 15:
								_ = ((int)num2 * -2025473032) ^ -1002403795;
								continue;
							case 14:
								Admit.smethod_37((Control)(object)RoomTypeTxt, bool_0: true);
								_ = (num2 * 1745075592) ^ 0x62972508;
								continue;
							case 13:
								Admit.smethod_37((Control)(object)DateOut1Txt, bool_0: true);
								_ = (num2 * 896075429) ^ 0xA21C6C13u;
								continue;
							case 12:
								Admit.smethod_37((Control)(object)RoomNoTxt, bool_0: true);
								_ = (num2 * 2124023310) ^ 0xEFDBFD87u;
								continue;
							case 11:
								Admit.smethod_37((Control)(object)DateIn1Txt, bool_0: false);
								_ = (num2 * 563579214) ^ 0xC8D62C39u;
								continue;
							case 10:
								Admit.smethod_37((Control)(object)RoomType1Txt, bool_0: false);
								_ = (num2 * 8518815) ^ 0x26C62DF;
								continue;
							case 9:
								_ = ((int)num2 * -1278744311) ^ -776517191;
								continue;
							case 8:
								_ = (num2 * 1602335960) ^ 0x26C7E3E;
								continue;
							case 7:
								_ = ((int)num2 * -1791642219) ^ -1304626396;
								continue;
							case 5:
								_ = (num2 * 984447914) ^ 0x2A150F53;
								continue;
							case 4:
								Admit.smethod_37((Control)(object)DateInTxt, bool_0: true);
								Admit.smethod_37((Control)(object)RoomNo1Txt, bool_0: false);
								_ = ((int)num2 * -234422344) ^ 0x227A04DA;
								continue;
							case 2:
								_ = ((int)num2 * -23988636) ^ -1099308329;
								continue;
							case 1:
								Admit.smethod_37((Control)(object)DateOutTxt, bool_0: false);
								_ = (num2 * 1848935524) ^ 0xA6359F4Fu;
								continue;
							case 0:
								_ = (num2 * 998447695) ^ 0x8D316710u;
								continue;
							case 3:
								break;
							default:
								Admit.smethod_74(Admit.smethod_129(exception_));
								Admit.smethod_74(string_);
								Admit.smethod_85();
								return;
							}
							break;
						}
					}
				}
			}
			break;
		}
		goto IL_007c;
		IL_007c:
		num = 682749873;
		goto IL_0081;
	}

	private bool Add_Rooms()
	{
		OleDbDataReader oleDbDataReader_ = default(OleDbDataReader);
		string string_ = default(string);
		while (true)
		{
			int num = 2008586542;
			while (true)
			{
				uint num2;
				OleDbCommand oleDbCommand_;
				switch ((num2 = (uint)num ^ 0x768E0674u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
					try
					{
						while (true)
						{
							IL_0182:
							int num3 = 1755452438;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x768E0674u) % 11u)
								{
								case 10u:
									num3 = (int)(num2 * 947515814) ^ -659874492;
									continue;
								case 9u:
								{
									int num6;
									if (!Admit.smethod_128(oleDbDataReader_))
									{
										num3 = 2003998867;
										num6 = 2003998867;
									}
									else
									{
										num3 = 1476301137;
										num6 = 1476301137;
									}
									continue;
								}
								case 8u:
									num3 = (int)((num2 * 976589694) ^ 0x5B261B9);
									continue;
								case 6u:
									num3 = (int)(num2 * 238091499) ^ -172819035;
									continue;
								case 5u:
									oleDbCommand_ = Admit.smethod_88(string_, myconnection);
									oleDbDataReader_ = Admit.smethod_124(oleDbCommand_);
									num3 = (int)((num2 * 54179953) ^ 0x30A7BF10);
									continue;
								case 4u:
								{
									int num4;
									int num5;
									if (Admit.smethod_130(oleDbDataReader_))
									{
										num4 = 900415245;
										num5 = 900415245;
									}
									else
									{
										num4 = 1984608329;
										num5 = 1984608329;
									}
									num3 = num4 ^ ((int)num2 * -1215239173);
									continue;
								}
								case 3u:
									Admit.smethod_83(myconnection);
									num3 = (int)((num2 * 1610677439) ^ 0x7482D38F);
									continue;
								case 2u:
									Admit.smethod_70(Admit.smethod_42(RoomNoTxt), (object)Admit.smethod_126(Admit.smethod_125(oleDbDataReader_, 0)));
									num3 = 2112320908;
									continue;
								case 1u:
									num3 = 499483526;
									continue;
								default:
									goto end_IL_0143;
								case 0u:
									break;
								case 7u:
									goto end_IL_0143;
								}
								goto IL_0182;
								continue;
								end_IL_0143:
								break;
							}
							break;
						}
					}
					catch (Exception exception_)
					{
						Admit.smethod_84(exception_);
						Admit.smethod_83(myconnection);
						Admit.smethod_85();
					}
					return true;
				}
				break;
				IL_0003:
				oleDbCommand_ = Admit.smethod_75();
				string_ = "Select * From [Room] Where [Availability] = 'Yes';";
				Admit.smethod_78(myconnection);
				num = (int)(num2 * 1745964925) ^ -116289296;
			}
		}
	}

	private bool Update_Rooms(string roomNo, string status)
	{
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected I4, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected I4, but got Unknown
		//IL_01a3: Incompatible stack heights: 0 vs 1
		//IL_01be: Incompatible stack heights: 0 vs 1
		//IL_01ce: Incompatible stack heights: 0 vs 1
		//IL_01d5: Incompatible stack heights: 0 vs 1
		OleDbCommand val = default(OleDbCommand);
		string string_ = default(string);
		bool result = default(bool);
		while (true)
		{
			int num = 118207209;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5E53D3AFu) % 5u)
				{
				case 4u:
					val = Admit.smethod_75();
					num = (int)(num2 * 1345941529) ^ -958930176;
					continue;
				case 1u:
					Admit.smethod_78(myconnection);
					num = (int)(num2 * 1306251627) ^ -596759539;
					continue;
				case 0u:
					string_ = Admit.smethod_76(new string[5] { "Update [Room] Set [Availability] = '", status, "' Where [Room No] = ", roomNo, ";" });
					num = ((int)num2 * -2013467239) ^ 0x68F85343;
					continue;
				case 2u:
					break;
				default:
					try
					{
						while (true)
						{
							IL_015a:
							int num3 = 503231785;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x5E53D3AFu) % 8u)
								{
								case 7u:
									num3 = (int)(num2 * 472303601) ^ -50115055;
									continue;
								case 6u:
									val = Admit.smethod_88(string_, myconnection);
									num3 = ((int)num2 * -1168225087) ^ -480747867;
									continue;
								case 5u:
									Admit.smethod_97((Component)(object)val);
									num3 = (int)(num2 * 843016684) ^ -170972940;
									continue;
								case 4u:
									Admit.smethod_96(val);
									num3 = (int)(num2 * 1741686244) ^ -647302614;
									continue;
								case 3u:
									num3 = (int)(num2 * 612757953) ^ -1993457834;
									continue;
								case 1u:
									Admit.smethod_83(myconnection);
									num3 = ((int)num2 * -1271822615) ^ 0x27ACAD7D;
									continue;
								default:
									goto end_IL_0128;
								case 0u:
									break;
								case 2u:
									goto end_IL_0128;
								}
								goto IL_015a;
								continue;
								end_IL_0128:
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
							IL_01d0:
							_ = 632534719;
							while (true)
							{
								_003F val2 = /*Error near IL_0175: Stack underflow*/^ 0x5E53D3AF;
								num2 = (uint)(int)val2;
								switch (val2 % 5)
								{
								case 4:
									_ = (num2 * 2072015876) ^ 0x9C650D2Fu;
									continue;
								case 2:
									Admit.smethod_83(myconnection);
									_ = (num2 * 1904057622) ^ 0xA1A704BEu;
									continue;
								case 0:
									_ = ((int)num2 * -546843012) ^ 0x6FCBCB05;
									continue;
								case 3:
									break;
								default:
									Admit.smethod_85();
									goto end_IL_016f;
								}
								goto IL_01d0;
								continue;
								end_IL_016f:
								break;
							}
							break;
						}
					}
					while (true)
					{
						int num4 = 1198533698;
						while (true)
						{
							switch ((num2 = (uint)num4 ^ 0x5E53D3AFu) % 4u)
							{
							case 3u:
								num4 = ((int)num2 * -36177717) ^ 0x3BBB54D2;
								continue;
							case 1u:
								result = true;
								num4 = ((int)num2 * -1237303071) ^ -2076367131;
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
				break;
			}
		}
	}

	private bool Validate_Print_Data()
	{
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		bool flag5 = default(bool);
		bool flag4 = default(bool);
		bool flag3 = default(bool);
		bool result = default(bool);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1763114060;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEF89E858u) % 45u)
				{
				case 44u:
				{
					int num19;
					int num20;
					if (flag5)
					{
						num19 = 2321353;
						num20 = 2321353;
					}
					else
					{
						num19 = 1705961160;
						num20 = 1705961160;
					}
					num = num19 ^ (int)(num2 * 519483748);
					continue;
				}
				case 43u:
					flag4 = (Admit.smethod_131(RoomNoTxt) == -1) & (Admit.smethod_87(Admit.smethod_72(RoomNo1Txt), "", bool_0: false) == 0);
					num = ((int)num2 * -1173697722) ^ 0x4B374830;
					continue;
				case 42u:
					flag5 = (Admit.smethod_87(Admit.smethod_94(StatusTxt), "", bool_0: false) == 0) | (Admit.smethod_87(Admit.smethod_94(StatusTxt), "Not Paid", bool_0: false) == 0);
					num = -1117594616;
					continue;
				case 41u:
					flag3 = !Admit.smethod_117((Control)(object)DateOut1Txt);
					num = ((int)num2 * -1323691030) ^ 0x5B15EBBE;
					continue;
				case 40u:
					result = false;
					num = ((int)num2 * -1104988811) ^ 0x645969C4;
					continue;
				case 39u:
					num = ((int)num2 * -767663054) ^ 0x3CF12C04;
					continue;
				case 38u:
					num = (int)((num2 * 295693256) ^ 0x2BBF1215);
					continue;
				case 37u:
					Admit.smethod_74("Incorrect fees Value");
					num = (int)((num2 * 103921579) ^ 0x36CC277);
					continue;
				case 36u:
					result = false;
					num = (int)(num2 * 605377359) ^ -885516884;
					continue;
				case 35u:
				{
					int num15;
					int num16;
					if (!flag)
					{
						num15 = 2017308386;
						num16 = 2017308386;
					}
					else
					{
						num15 = 1146887248;
						num16 = 1146887248;
					}
					num = num15 ^ ((int)num2 * -905080481);
					continue;
				}
				case 34u:
					Admit.smethod_74("Missing Room No");
					result = false;
					num = ((int)num2 * -2082848247) ^ -1857140534;
					continue;
				case 33u:
					num = -1676958032;
					continue;
				case 32u:
					Admit.smethod_74("Missing Date out");
					result = false;
					num = (int)(num2 * 1207956527) ^ -145468146;
					continue;
				case 31u:
					Admit.smethod_74("Cannot discharge Without Paying fees");
					result = false;
					num = (int)((num2 * 712170639) ^ 0x38F90702);
					continue;
				case 30u:
				{
					int num7;
					int num8;
					if (!MyProject.Forms.Form1.Number_Validator(Admit.smethod_72(FeesTxt)))
					{
						num7 = 2069965871;
						num8 = 2069965871;
					}
					else
					{
						num7 = 735328899;
						num8 = 735328899;
					}
					num = num7 ^ (int)(num2 * 1447905591);
					continue;
				}
				case 29u:
					num = ((int)num2 * -918456829) ^ 0x319DC8C;
					continue;
				case 28u:
					num = -313091554;
					continue;
				case 27u:
					Admit.smethod_74("Missing fees");
					result = false;
					num = (int)(num2 * 233832861) ^ -625571973;
					continue;
				case 26u:
					flag2 = Admit.smethod_131(DateOutTxt) == -1;
					num = (int)(num2 * 2022384630) ^ -663791436;
					continue;
				case 25u:
				{
					int num21;
					if (!((Admit.smethod_87(Admit.smethod_94(StatusTxt), "Paid", bool_0: false) == 0) & !MyProject.Forms.Form1.Number_Validator(Admit.smethod_72(FeesTxt))))
					{
						num = -1290998760;
						num21 = -1290998760;
					}
					else
					{
						num = -414221651;
						num21 = -414221651;
					}
					continue;
				}
				case 24u:
					num = -1248510757;
					continue;
				case 23u:
					num = -1705015331;
					continue;
				case 22u:
					num = (int)((num2 * 1438018049) ^ 0x4E1EA58A);
					continue;
				case 21u:
					num = (int)(num2 * 72532490) ^ -1612196351;
					continue;
				case 20u:
					Admit.smethod_74("Missing Date In");
					result = false;
					num = ((int)num2 * -1219030886) ^ 0x596D1A6F;
					continue;
				case 19u:
					result = true;
					num = ((int)num2 * -825065194) ^ 0xE58D7B2;
					continue;
				case 18u:
					num = ((int)num2 * -1439696088) ^ -1603459547;
					continue;
				case 17u:
				{
					int num17;
					int num18;
					if (!Admit.smethod_117((Control)(object)DateIn1Txt))
					{
						num17 = 652971602;
						num18 = 652971602;
					}
					else
					{
						num17 = 1047781518;
						num18 = 1047781518;
					}
					num = num17 ^ (int)(num2 * 298124195);
					continue;
				}
				case 16u:
					num = -109094510;
					continue;
				case 15u:
				{
					int num13;
					int num14;
					if (!((Admit.smethod_131(RoomTypeTxt) == -1) & (Admit.smethod_87(Admit.smethod_72(RoomType1Txt), "", bool_0: false) == 0)))
					{
						num13 = -119832953;
						num14 = -119832953;
					}
					else
					{
						num13 = -1145061153;
						num14 = -1145061153;
					}
					num = num13 ^ ((int)num2 * -1414048375);
					continue;
				}
				case 14u:
				{
					int num11;
					int num12;
					if (flag4)
					{
						num11 = 838555770;
						num12 = 838555770;
					}
					else
					{
						num11 = 345598029;
						num12 = 345598029;
					}
					num = num11 ^ (int)(num2 * 139656202);
					continue;
				}
				case 13u:
					Admit.smethod_74("Cannot Display Fees when Not Paid");
					num = ((int)num2 * -1549609433) ^ -460130801;
					continue;
				case 12u:
					num = -2081853168;
					continue;
				case 11u:
					result = false;
					num = (int)((num2 * 1820526286) ^ 0x67B29FE7);
					continue;
				case 10u:
				{
					int num9;
					int num10;
					if (!flag3)
					{
						num9 = 1145190964;
						num10 = 1145190964;
					}
					else
					{
						num9 = 1469169095;
						num10 = 1469169095;
					}
					num = num9 ^ (int)(num2 * 198543353);
					continue;
				}
				case 9u:
				{
					int num5;
					int num6;
					if (Admit.smethod_131(DateInTxt) == -1)
					{
						num5 = 1717670416;
						num6 = 1717670416;
					}
					else
					{
						num5 = 341910242;
						num6 = 341910242;
					}
					num = num5 ^ ((int)num2 * -818968225);
					continue;
				}
				case 8u:
				{
					int num3;
					int num4;
					if (!flag2)
					{
						num3 = 298541642;
						num4 = 298541642;
					}
					else
					{
						num3 = 1391396870;
						num4 = 1391396870;
					}
					num = num3 ^ ((int)num2 * -415322677);
					continue;
				}
				case 7u:
					num = (int)((num2 * 38222552) ^ 0x6F9EDA2D);
					continue;
				case 6u:
					Admit.smethod_74("Missing Room type");
					num = (int)((num2 * 2115954699) ^ 0x2984D888);
					continue;
				case 5u:
					flag = (Admit.smethod_87(Admit.smethod_94(StatusTxt), "Not Paid", bool_0: false) == 0) & (Admit.smethod_87(Admit.smethod_72(FeesTxt), "", bool_0: false) != 0);
					num = ((int)num2 * -1588203863) ^ 0x71EA598D;
					continue;
				case 4u:
					num = -1139580884;
					continue;
				case 3u:
					num = ((int)num2 * -1263297324) ^ -1080254403;
					continue;
				case 2u:
					num = -578177272;
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
