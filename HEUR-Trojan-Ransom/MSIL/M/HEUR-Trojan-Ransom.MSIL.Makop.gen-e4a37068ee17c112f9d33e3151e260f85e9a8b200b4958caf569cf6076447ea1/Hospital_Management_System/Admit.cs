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
				int num = 1762107569;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2174653Eu) % 8u)
					{
					case 7u:
					{
						int num5;
						int num6;
						if (searchBtn != null)
						{
							num5 = 1029419309;
							num6 = 1029419309;
						}
						else
						{
							num5 = 971944902;
							num6 = 971944902;
						}
						num = num5 ^ ((int)num2 * -364929778);
						continue;
					}
					case 6u:
						Admit.smethod_61((Control)(object)searchBtn, eventHandler_);
						num = ((int)num2 * -12187523) ^ -1565648557;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (searchBtn != null)
						{
							num3 = -1138845257;
							num4 = -1138845257;
						}
						else
						{
							num3 = -2118233038;
							num4 = -2118233038;
						}
						num = num3 ^ (int)(num2 * 705125523);
						continue;
					}
					case 4u:
						searchBtn = _SearchBtn;
						num = (int)(num2 * 935397669) ^ -2099004697;
						continue;
					case 2u:
						_SearchBtn = value;
						num = 232952370;
						continue;
					case 1u:
						Admit.smethod_60((Control)(object)searchBtn, eventHandler_);
						num = (int)(num2 * 1408391419) ^ -2078129617;
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
				int num = -910182610;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA8DE5B6Fu) % 8u)
					{
					case 7u:
						Admit.smethod_62(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = (int)((num2 * 1442677374) ^ 0x1D4D1C70);
						continue;
					case 6u:
						searchResultGrid = _SearchResultGrid;
						num = (int)((num2 * 1414455788) ^ 0x200A4B9D);
						continue;
					case 5u:
						_SearchResultGrid = value;
						num = -1289819287;
						continue;
					case 2u:
					{
						int num5;
						int num6;
						if (searchResultGrid != null)
						{
							num5 = -77112859;
							num6 = -77112859;
						}
						else
						{
							num5 = -887579634;
							num6 = -887579634;
						}
						num = num5 ^ (int)(num2 * 307085913);
						continue;
					}
					case 1u:
					{
						searchResultGrid = _SearchResultGrid;
						int num3;
						int num4;
						if (searchResultGrid == null)
						{
							num3 = -1099431127;
							num4 = -1099431127;
						}
						else
						{
							num3 = -108090669;
							num4 = -108090669;
						}
						num = num3 ^ ((int)num2 * -1038351093);
						continue;
					}
					case 0u:
						Admit.smethod_63(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = (int)(num2 * 1948972412) ^ -257139228;
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
				int num = -629295387;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB1FEC672u) % 8u)
					{
					case 7u:
					{
						clearBtn = _ClearBtn;
						int num5;
						int num6;
						if (clearBtn != null)
						{
							num5 = -1014753261;
							num6 = -1014753261;
						}
						else
						{
							num5 = -1177685754;
							num6 = -1177685754;
						}
						num = num5 ^ ((int)num2 * -2129551121);
						continue;
					}
					case 5u:
						_ClearBtn = value;
						num = -381221216;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (clearBtn != null)
						{
							num3 = 1688691225;
							num4 = 1688691225;
						}
						else
						{
							num3 = 1958670846;
							num4 = 1958670846;
						}
						num = num3 ^ ((int)num2 * -297012986);
						continue;
					}
					case 2u:
						clearBtn = _ClearBtn;
						num = (int)((num2 * 1121439507) ^ 0x4EAC3007);
						continue;
					case 1u:
						Admit.smethod_61((Control)(object)clearBtn, eventHandler_);
						num = (int)(num2 * 94577056) ^ -695929076;
						continue;
					case 0u:
						Admit.smethod_60((Control)(object)clearBtn, eventHandler_);
						num = (int)(num2 * 1150361864) ^ -1748229825;
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
				int num = -1494526876;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB0D30E31u) % 9u)
					{
					case 7u:
						Admit.smethod_61((Control)(object)printBtn, eventHandler_);
						num = (int)(num2 * 496900517) ^ -1769691148;
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (printBtn != null)
						{
							num5 = -1333784571;
							num6 = -1333784571;
						}
						else
						{
							num5 = -1561626268;
							num6 = -1561626268;
						}
						num = num5 ^ ((int)num2 * -1740497693);
						continue;
					}
					case 5u:
						_PrintBtn = value;
						num = -598343199;
						continue;
					case 4u:
						printBtn = _PrintBtn;
						num = (int)(num2 * 680973835) ^ -192163631;
						continue;
					case 2u:
						printBtn = _PrintBtn;
						num = ((int)num2 * -934405779) ^ 0x6928A568;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (printBtn != null)
						{
							num3 = -971677017;
							num4 = -971677017;
						}
						else
						{
							num3 = -1975414320;
							num4 = -1975414320;
						}
						num = num3 ^ (int)(num2 * 1734570464);
						continue;
					}
					case 0u:
						Admit.smethod_60((Control)(object)printBtn, eventHandler_);
						num = (int)((num2 * 1511930888) ^ 0x142A9140);
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
			Button saveBtn = default(Button);
			while (true)
			{
				int num = 1167913661;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x22978F8Cu) % 8u)
					{
					case 6u:
						Admit.smethod_60((Control)(object)saveBtn, eventHandler_);
						num = ((int)num2 * -1561207685) ^ -767455730;
						continue;
					case 5u:
						Admit.smethod_61((Control)(object)saveBtn, eventHandler_);
						num = (int)((num2 * 1892554804) ^ 0x34192B8F);
						continue;
					case 4u:
					{
						int num5;
						int num6;
						if (saveBtn != null)
						{
							num5 = -796389026;
							num6 = -796389026;
						}
						else
						{
							num5 = -1755102040;
							num6 = -1755102040;
						}
						num = num5 ^ (int)(num2 * 486146951);
						continue;
					}
					case 3u:
					{
						int num3;
						int num4;
						if (saveBtn != null)
						{
							num3 = -58814116;
							num4 = -58814116;
						}
						else
						{
							num3 = -349512330;
							num4 = -349512330;
						}
						num = num3 ^ (int)(num2 * 437691407);
						continue;
					}
					case 1u:
						saveBtn = _SaveBtn;
						num = ((int)num2 * -900411090) ^ -1398204778;
						continue;
					case 0u:
						_SaveBtn = value;
						saveBtn = _SaveBtn;
						num = 2005821791;
						continue;
					default:
						return;
					case 2u:
						break;
					case 7u:
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
				int num = -649260686;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE535B40Fu) % 8u)
					{
					case 7u:
					{
						printDocument = _PrintDocument1;
						int num5;
						int num6;
						if (printDocument != null)
						{
							num5 = -321793819;
							num6 = -321793819;
						}
						else
						{
							num5 = -862559625;
							num6 = -862559625;
						}
						num = num5 ^ ((int)num2 * -1287290474);
						continue;
					}
					case 5u:
						printDocument = _PrintDocument1;
						num = ((int)num2 * -1205639590) ^ 0x680047DC;
						continue;
					case 4u:
						Admit.smethod_64(printDocument, printPageEventHandler_);
						num = ((int)num2 * -1143402256) ^ 0x3F0E68AC;
						continue;
					case 3u:
						_PrintDocument1 = value;
						num = -1285726888;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (printDocument == null)
						{
							num3 = 404567410;
							num4 = 404567410;
						}
						else
						{
							num3 = 1481399773;
							num4 = 1481399773;
						}
						num = num3 ^ ((int)num2 * -392577314);
						continue;
					}
					case 0u:
						Admit.smethod_65(printDocument, printPageEventHandler_);
						num = (int)((num2 * 1033785165) ^ 0x17D24E5D);
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
				int num = 502830633;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4755861Au) % 7u)
					{
					case 6u:
						Admit.smethod_60((Control)(object)historyBtn, eventHandler_);
						num = ((int)num2 * -116310247) ^ -450520434;
						continue;
					case 5u:
					{
						historyBtn = _HistoryBtn;
						int num5;
						int num6;
						if (historyBtn != null)
						{
							num5 = -1903362447;
							num6 = -1903362447;
						}
						else
						{
							num5 = -1087959339;
							num6 = -1087959339;
						}
						num = num5 ^ (int)(num2 * 1361519759);
						continue;
					}
					case 4u:
						_HistoryBtn = value;
						historyBtn = _HistoryBtn;
						num = 1021820311;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (historyBtn == null)
						{
							num3 = 1353428947;
							num4 = 1353428947;
						}
						else
						{
							num3 = 663591752;
							num4 = 663591752;
						}
						num = num3 ^ ((int)num2 * -67940590);
						continue;
					}
					case 1u:
						Admit.smethod_61((Control)(object)historyBtn, eventHandler_);
						num = (int)((num2 * 1617302290) ^ 0x44B11FC9);
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
				int num = 1969240024;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1A6D39CAu) % 7u)
					{
					case 6u:
					{
						int num5;
						int num6;
						if (admitDischargeBtn == null)
						{
							num5 = -1603463893;
							num6 = -1603463893;
						}
						else
						{
							num5 = -287796302;
							num6 = -287796302;
						}
						num = num5 ^ (int)(num2 * 468773443);
						continue;
					}
					case 5u:
						Admit.smethod_60((Control)(object)admitDischargeBtn, eventHandler_);
						num = ((int)num2 * -1736484251) ^ -188978508;
						continue;
					case 4u:
						Admit.smethod_61((Control)(object)admitDischargeBtn, eventHandler_);
						num = (int)((num2 * 788048309) ^ 0x3C71413);
						continue;
					case 3u:
						_AdmitDischargeBtn = value;
						admitDischargeBtn = _AdmitDischargeBtn;
						num = 1896586418;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (admitDischargeBtn != null)
						{
							num3 = -1525065065;
							num4 = -1525065065;
						}
						else
						{
							num3 = -1980305467;
							num4 = -1980305467;
						}
						num = num3 ^ ((int)num2 * -923392449);
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
		Admit.smethod_0((UserControl)(object)this, (EventHandler)Admit_Load);
		myconnection = Admit.smethod_1();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			bool flag = default(bool);
			while (true)
			{
				int num = -868646340;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x84CE52E6u) % 7u)
					{
					case 6u:
						if (disposing)
						{
							num = (int)(num2 * 1983624053) ^ -2122468382;
							continue;
						}
						num3 = 0;
						goto IL_001a;
					case 4u:
						num = (int)((num2 * 454492559) ^ 0x27BEC2CC);
						continue;
					case 3u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -677605618;
							num5 = -677605618;
						}
						else
						{
							num4 = -1837848395;
							num5 = -1837848395;
						}
						num = num4 ^ ((int)num2 * -361838381);
						continue;
					}
					case 1u:
						Admit.smethod_2((IDisposable)components);
						num = ((int)num2 * -844179664) ^ -757033554;
						continue;
					case 0u:
						num3 = ((components != null) ? 1 : 0);
						goto IL_001a;
					default:
						return;
					case 2u:
						break;
					case 5u:
						return;
						IL_001a:
						flag = (byte)num3 != 0;
						num = -59354200;
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
				IL_00e4:
				int num6 = -1932408645;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num6 ^ 0x84CE52E6u) % 3u)
					{
					case 1u:
						goto IL_00b3;
					default:
						goto end_IL_00c7;
					case 2u:
						break;
					case 0u:
						goto end_IL_00c7;
					}
					goto IL_00e4;
					IL_00b3:
					((ContainerControl)this).Dispose(disposing);
					num6 = (int)(num2 * 187752620) ^ -2106862903;
					continue;
					end_IL_00c7:
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
			int num = -1541598043;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x819C9DC5u) % 507u)
				{
				case 506u:
					num = ((int)num2 * -1936846977) ^ 0x671F7150;
					continue;
				case 505u:
					num = ((int)num2 * -602619294) ^ 0x74DD2353;
					continue;
				case 504u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)RoomNoTxt);
					num = ((int)num2 * -308856429) ^ -352141725;
					continue;
				case 503u:
					PatientInfoBox = Admit.smethod_4();
					num = ((int)num2 * -710170266) ^ 0xCB034E6;
					continue;
				case 502u:
					Admit.smethod_23(Label10, (ContentAlignment)32);
					num = ((int)num2 * -508745309) ^ 0x276A3F0B;
					continue;
				case 501u:
					Admit.smethod_30((ButtonBase)(object)ClearBtn, "Clear");
					Admit.smethod_31((ButtonBase)(object)ClearBtn, bool_0: false);
					num = ((int)num2 * -602496383) ^ -165595755;
					continue;
				case 500u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)RoomTypeTxt);
					num = ((int)num2 * -481995580) ^ -1628982297;
					continue;
				case 499u:
					Admit.smethod_21((Control)(object)PatientInfoBox, 7);
					num = ((int)num2 * -1877684506) ^ 0x6E85FB13;
					continue;
				case 498u:
					num = ((int)num2 * -1476256893) ^ 0x69B7FDA7;
					continue;
				case 497u:
					Admit.smethod_17((Control)(object)Label9, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 94813152) ^ 0x6F037850);
					continue;
				case 496u:
					Admit.smethod_20((Control)(object)RoomType1Txt, new Size(181, 28));
					Admit.smethod_21((Control)(object)RoomType1Txt, 21);
					num = ((int)num2 * -1798405644) ^ -470566818;
					continue;
				case 495u:
					Admit.smethod_31((ButtonBase)(object)SaveBtn, bool_0: false);
					num = (int)(num2 * 2077130522) ^ -1605566856;
					continue;
				case 494u:
					num = (int)((num2 * 36039911) ^ 0x6CF78440);
					continue;
				case 493u:
					Admit.smethod_21((Control)(object)DateInTxt, 16);
					num = ((int)num2 * -1961769929) ^ 0x107D5226;
					continue;
				case 492u:
					Label1 = Admit.smethod_3();
					num = (int)(num2 * 923670022) ^ -332532042;
					continue;
				case 491u:
					num = ((int)num2 * -1320189260) ^ -827302669;
					continue;
				case 490u:
					Admit.smethod_22(Label14, "Name :");
					Admit.smethod_18((Control)(object)AddressTxt, new Point(124, 198));
					num = (int)((num2 * 269719685) ^ 0x1318CC05);
					continue;
				case 489u:
					Admit.smethod_17((Control)(object)DateInTxt, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1585124028) ^ -1315653532;
					continue;
				case 488u:
					num = ((int)num2 * -403091993) ^ 0x54AB7168;
					continue;
				case 487u:
					Admit.smethod_38((TextBoxBase)(object)AgeTxt, bool_0: true);
					num = ((int)num2 * -207186722) ^ -2097580206;
					continue;
				case 486u:
					Label13 = Admit.smethod_3();
					num = (int)(num2 * 1125538441) ^ -1135615503;
					continue;
				case 485u:
					Admit.smethod_18((Control)(object)PictureBox1, new Point(260, 22));
					Admit.smethod_19((Control)(object)PictureBox1, "PictureBox1");
					num = (int)(num2 * 778382131) ^ -159744024;
					continue;
				case 484u:
					Admit.smethod_22(Label1, "Admit And Discharge ");
					num = (int)(num2 * 1247231867) ^ -1689743193;
					continue;
				case 483u:
					Admit.smethod_21((Control)(object)AdmitDetailsBox, 8);
					num = ((int)num2 * -133230507) ^ 0x710D6967;
					continue;
				case 482u:
					num = (int)(num2 * 457687097) ^ -1477888403;
					continue;
				case 481u:
					num = (int)(num2 * 252590765) ^ -1944770426;
					continue;
				case 480u:
					Admit.smethod_20((Control)(object)Label12, new Size(101, 28));
					num = ((int)num2 * -1822608) ^ 0x1FF21B83;
					continue;
				case 479u:
					Admit.smethod_18((Control)(object)Label2, new Point(37, 44));
					num = (int)((num2 * 2080039234) ^ 0x74895879);
					continue;
				case 478u:
					Admit.smethod_57((ISupportInitialize)SearchResultGrid);
					num = (int)((num2 * 30586545) ^ 0x2321E13E);
					continue;
				case 477u:
					num = ((int)num2 * -165674982) ^ -1653180102;
					continue;
				case 476u:
					Label7 = Admit.smethod_3();
					Label6 = Admit.smethod_3();
					num = (int)(num2 * 1128999678) ^ -366302138;
					continue;
				case 475u:
					num = (int)((num2 * 1023395299) ^ 0xFA7FE4E);
					continue;
				case 474u:
					Admit.smethod_28((ButtonBase)(object)AdmitDischargeBtn, Color.MidnightBlue);
					num = ((int)num2 * -847258762) ^ 0x3314D3A5;
					continue;
				case 473u:
					Admit.smethod_20((Control)(object)SaveBtn, new Size(98, 37));
					num = ((int)num2 * -368357856) ^ -1544988787;
					continue;
				case 472u:
					num = (int)((num2 * 1269790648) ^ 0x2646A1F2);
					continue;
				case 471u:
					AddressTxt = Admit.smethod_6();
					num = ((int)num2 * -445609488) ^ -1953636156;
					continue;
				case 470u:
					GroupBox1 = Admit.smethod_4();
					num = (int)(num2 * 983310429) ^ -1724016820;
					continue;
				case 469u:
					DateIn1Txt = Admit.smethod_6();
					num = ((int)num2 * -1034925301) ^ 0x3ACE7468;
					continue;
				case 468u:
					num = (int)(num2 * 1709210667) ^ -1203860925;
					continue;
				case 467u:
					Admit.smethod_23(Label13, (ContentAlignment)32);
					num = ((int)num2 * -2040467868) ^ 0x358E498C;
					continue;
				case 466u:
					Admit.smethod_17((Control)(object)PrintBtn, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1900080161) ^ 0x77A6C8FE;
					continue;
				case 465u:
					RoomNoTxt = Admit.smethod_8();
					RoomTypeTxt = Admit.smethod_8();
					num = ((int)num2 * -1696847280) ^ -762903028;
					continue;
				case 464u:
					Admit.smethod_40(DateInTxt, (ComboBoxStyle)2);
					num = ((int)num2 * -1405438212) ^ -1444617786;
					continue;
				case 463u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)Label4);
					num = (int)(num2 * 2035600911) ^ -2140074565;
					continue;
				case 462u:
					Admit.smethod_21((Control)(object)Label13, 12);
					num = ((int)num2 * -2136092609) ^ 0x67C55A1F;
					continue;
				case 461u:
					Admit.smethod_43(Admit.smethod_42(StatusTxt), new object[2] { "Paid", "Not Paid" });
					num = (int)(num2 * 1116738385) ^ -2034909313;
					continue;
				case 460u:
					Admit.smethod_17((Control)(object)Label10, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1117144727) ^ -762133337;
					continue;
				case 459u:
					Admit.smethod_31((ButtonBase)(object)PrintBtn, bool_0: false);
					num = ((int)num2 * -1118761002) ^ 0x7402133A;
					continue;
				case 458u:
					Admit.smethod_17((Control)(object)AdmitDischargeBtn, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1721685760) ^ 0x597D8B5F);
					continue;
				case 457u:
					Admit.smethod_31((ButtonBase)(object)SearchBtn, bool_0: false);
					num = ((int)num2 * -68213362) ^ -221117691;
					continue;
				case 456u:
					Admit.smethod_29((Control)(object)SaveBtn, Color.White);
					num = ((int)num2 * -902320725) ^ -1838022934;
					continue;
				case 455u:
					Admit.smethod_41((ListControl)(object)StatusTxt, bool_0: true);
					num = ((int)num2 * -126841814) ^ -1562391036;
					continue;
				case 454u:
					AdmitDischargeBtn = Admit.smethod_5();
					num = (int)(num2 * 938644597) ^ -1234436897;
					continue;
				case 453u:
					num = ((int)num2 * -114730144) ^ -1580455290;
					continue;
				case 452u:
					Admit.smethod_38((TextBoxBase)(object)RoomType1Txt, bool_0: true);
					num = ((int)num2 * -461909007) ^ 0x66423996;
					continue;
				case 451u:
					Admit.smethod_18((Control)(object)HistoryBtn, new Point(784, 163));
					num = (int)((num2 * 1147506619) ^ 0x533F43DE);
					continue;
				case 450u:
					num = ((int)num2 * -1806340843) ^ 0x4004C6F7;
					continue;
				case 449u:
					Admit.smethod_56((Control)(object)GroupBox1);
					num = ((int)num2 * -332197881) ^ 0x3BF0D7DD;
					continue;
				case 448u:
					Admit.smethod_19((Control)(object)Label2, "Label2");
					num = (int)(num2 * 1466365341) ^ -1563517424;
					continue;
				case 447u:
					num = ((int)num2 * -1981719657) ^ -474518733;
					continue;
				case 446u:
					Label15 = Admit.smethod_3();
					num = ((int)num2 * -212249513) ^ 0x5BB35C7C;
					continue;
				case 445u:
					num = ((int)num2 * -710960479) ^ 0x6239148B;
					continue;
				case 444u:
					Admit.smethod_22(Label10, "Fees  :");
					num = (int)((num2 * 1071077136) ^ 0x6BBDBB33);
					continue;
				case 443u:
					num = ((int)num2 * -614179199) ^ -1337294873;
					continue;
				case 442u:
					Admit.smethod_18((Control)(object)DateIn1Txt, new Point(161, 110));
					num = (int)((num2 * 490423521) ^ 0x42BFE211);
					continue;
				case 441u:
					Admit.smethod_21((Control)(object)DateIn1Txt, 13);
					num = (int)(num2 * 597359563) ^ -1939502625;
					continue;
				case 440u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)PictureBox1);
					num = (int)((num2 * 199041744) ^ 0x2FC20AB3);
					continue;
				case 439u:
					num = (int)((num2 * 1475639645) ^ 0x94F5DAB);
					continue;
				case 438u:
					num = (int)(num2 * 1996121306) ^ -1499178934;
					continue;
				case 437u:
					NameTxt = Admit.smethod_6();
					num = (int)(num2 * 659524427) ^ -96005490;
					continue;
				case 436u:
					Admit.smethod_17((Control)(object)RoomTypeTxt, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 439393567) ^ 0x39A688DC);
					continue;
				case 435u:
					num = ((int)num2 * -2036583892) ^ -111748154;
					continue;
				case 434u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)Label11);
					num = (int)(num2 * 83243994) ^ -878837082;
					continue;
				case 433u:
					num = ((int)num2 * -1191428877) ^ -2052488800;
					continue;
				case 432u:
					Admit.smethod_18((Control)(object)AdmitDetailsBox, new Point(504, 485));
					num = (int)(num2 * 1422853739) ^ -1236926987;
					continue;
				case 431u:
					Admit.smethod_59((Control)(object)this);
					num = (int)(num2 * 1828616565) ^ -2046735118;
					continue;
				case 430u:
					Admit.smethod_18((Control)(object)AdmitDischargeBtn, new Point(784, 220));
					num = (int)((num2 * 91580029) ^ 0x7A1FA8F);
					continue;
				case 429u:
					num = ((int)num2 * -68266217) ^ 0x1D6FC7DF;
					continue;
				case 428u:
					num = ((int)num2 * -255879748) ^ -2110592465;
					continue;
				case 427u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)AdmitDischargeBtn);
					num = (int)(num2 * 1380785938) ^ -972313822;
					continue;
				case 426u:
					Admit.smethod_20((Control)(object)DateOutTxt, new Size(181, 27));
					num = ((int)num2 * -1663019112) ^ -1693427128;
					continue;
				case 425u:
					Admit.smethod_21((Control)(object)AdmitDischargeBtn, 19);
					num = ((int)num2 * -1095468536) ^ 0x5BFB7AB2;
					continue;
				case 424u:
					Admit.smethod_14((Control)(object)this);
					num = (int)(num2 * 1083156683) ^ -1268115002;
					continue;
				case 423u:
					Admit.smethod_41((ListControl)(object)DateInTxt, bool_0: true);
					num = (int)(num2 * 257508801) ^ -179714302;
					continue;
				case 422u:
					Admit.smethod_19((Control)(object)AgeTxt, "AgeTxt");
					num = ((int)num2 * -1149020824) ^ 0x1E36AD4B;
					continue;
				case 421u:
					num = (int)((num2 * 1992155274) ^ 0x58AF0826);
					continue;
				case 420u:
					Admit.smethod_20((Control)(object)Label8, new Size(101, 25));
					num = ((int)num2 * -657426794) ^ -609978786;
					continue;
				case 419u:
					Admit.smethod_22(Label13, "Date Out  :");
					num = ((int)num2 * -1480118516) ^ 0x9C9E929;
					continue;
				case 418u:
					Admit.smethod_37((Control)(object)RoomNo1Txt, bool_0: false);
					num = ((int)num2 * -894571913) ^ 0x6B13F70C;
					continue;
				case 417u:
					Admit.smethod_17((Control)(object)HistoryBtn, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -274383503) ^ 0x44B9B693;
					continue;
				case 416u:
					Admit.smethod_21((Control)(object)SearchBtn, 4);
					num = ((int)num2 * -915127527) ^ -134768712;
					continue;
				case 415u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)SaveBtn);
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)PrintBtn);
					num = ((int)num2 * -1982398328) ^ 0x232B6349;
					continue;
				case 414u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)Label1);
					num = (int)((num2 * 187308131) ^ 0x10267F86);
					continue;
				case 413u:
					num = (int)((num2 * 1784179576) ^ 0x7130AE9B);
					continue;
				case 412u:
					Admit.smethod_21((Control)(object)PrintBtn, 10);
					num = (int)(num2 * 1745928215) ^ -5918327;
					continue;
				case 411u:
					Admit.smethod_26(GroupBox1, bool_0: false);
					Admit.smethod_27(GroupBox1, "Search Patient");
					num = (int)(num2 * 1917746760) ^ -1749518162;
					continue;
				case 410u:
					num = ((int)num2 * -1576416730) ^ 0x6D42A0FE;
					continue;
				case 409u:
					num = (int)(num2 * 22922017) ^ -1008754990;
					continue;
				case 408u:
					num = (int)(num2 * 885312160) ^ -1645148143;
					continue;
				case 407u:
					Admit.smethod_22(Label11, "Status:");
					num = (int)(num2 * 1149309527) ^ -206760161;
					continue;
				case 406u:
					num = ((int)num2 * -1349709917) ^ 0x142B78C;
					continue;
				case 405u:
					Admit.smethod_55((Control)(object)GroupBox1, bool_0: false);
					num = ((int)num2 * -549672314) ^ 0xA2F51F4;
					continue;
				case 404u:
					Label9 = Admit.smethod_3();
					num = ((int)num2 * -156596720) ^ -1083982207;
					continue;
				case 403u:
					Admit.smethod_49((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -1315319734) ^ -2025431309;
					continue;
				case 402u:
					num = (int)((num2 * 15422066) ^ 0x7E328D9F);
					continue;
				case 401u:
					Admit.smethod_21((Control)(object)RoomNoTxt, 19);
					num = ((int)num2 * -1702263614) ^ 0x176C19BF;
					continue;
				case 400u:
					Admit.smethod_17((Control)(object)Label5, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 794621792) ^ 0x6202B3FE);
					continue;
				case 399u:
					Admit.smethod_21((Control)(object)SaveBtn, 11);
					num = ((int)num2 * -792443661) ^ -1705742226;
					continue;
				case 398u:
					Admit.smethod_22(Label3, "Mobile : ");
					num = (int)((num2 * 1926760918) ^ 0x31F39833);
					continue;
				case 397u:
					Admit.smethod_18((Control)(object)Label10, new Point(18, 201));
					num = (int)(num2 * 1342433950) ^ -1097451956;
					continue;
				case 396u:
					Admit.smethod_18((Control)(object)SearchResultGrid, new Point(59, 295));
					num = ((int)num2 * -604410186) ^ 0x459DBA03;
					continue;
				case 395u:
					num = ((int)num2 * -1537458550) ^ 0x5E8A5F96;
					continue;
				case 394u:
					num = ((int)num2 * -920917859) ^ -112085457;
					continue;
				case 393u:
					Admit.smethod_18((Control)(object)Label11, new Point(184, 201));
					Admit.smethod_19((Control)(object)Label11, "Label11");
					num = (int)((num2 * 1104133263) ^ 0x6FBAA39);
					continue;
				case 392u:
					num = ((int)num2 * -918896212) ^ 0x320B4F85;
					continue;
				case 391u:
					Admit.smethod_20((Control)(object)StatusTxt, new Size(136, 30));
					num = (int)(num2 * 832485847) ^ -1516300178;
					continue;
				case 390u:
					Admit.smethod_23(Label2, (ContentAlignment)32);
					Admit.smethod_32(SearchResultGrid, Color.White);
					num = ((int)num2 * -733345851) ^ -199899083;
					continue;
				case 389u:
					Admit.smethod_18((Control)(object)PrintBtn, new Point(655, 746));
					num = (int)((num2 * 953213156) ^ 0x661A4DA2);
					continue;
				case 388u:
					DateOutTxt = Admit.smethod_8();
					num = ((int)num2 * -1775783891) ^ 0x2032DCD7;
					continue;
				case 387u:
					num = (int)(num2 * 1017768840) ^ -421033003;
					continue;
				case 386u:
					Admit.smethod_21((Control)(object)NameTxt, 9);
					Admit.smethod_17((Control)(object)Label14, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1247756389) ^ 0x78EB87CF);
					continue;
				case 385u:
					num = ((int)num2 * -974072979) ^ -2097367626;
					continue;
				case 384u:
					Admit.smethod_18((Control)(object)Label14, new Point(13, 80));
					Admit.smethod_19((Control)(object)Label14, "Label14");
					num = ((int)num2 * -1762214515) ^ 0x2B933E32;
					continue;
				case 383u:
					num = ((int)num2 * -1417015589) ^ 0x73EF9163;
					continue;
				case 382u:
					Admit.smethod_23(Label3, (ContentAlignment)32);
					num = (int)(num2 * 1614440082) ^ -1996510387;
					continue;
				case 381u:
					num = ((int)num2 * -337220079) ^ 0x1B2B8AB0;
					continue;
				case 380u:
					num = (int)((num2 * 299123368) ^ 0x5BE3C250);
					continue;
				case 379u:
					num = ((int)num2 * -2089809428) ^ 0x67CA95F4;
					continue;
				case 378u:
					Admit.smethod_56((Control)(object)PatientInfoBox);
					num = ((int)num2 * -1964654136) ^ -57768571;
					continue;
				case 377u:
					num = ((int)num2 * -1490302011) ^ -987176387;
					continue;
				case 376u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)DateIn1Txt);
					num = ((int)num2 * -1996877589) ^ 0x31D8E7B8;
					continue;
				case 375u:
					Label10 = Admit.smethod_3();
					num = (int)(num2 * 424505738) ^ -2102090842;
					continue;
				case 374u:
					num = ((int)num2 * -1430325607) ^ 0x1D7C893D;
					continue;
				case 373u:
					Label14 = Admit.smethod_3();
					num = (int)(num2 * 646826061) ^ -1787150592;
					continue;
				case 372u:
					num = ((int)num2 * -1786672578) ^ 0x2E37ACC4;
					continue;
				case 371u:
					Admit.smethod_22(Label2, "Name : ");
					num = ((int)num2 * -2024070534) ^ 0x169A2426;
					continue;
				case 370u:
					Admit.smethod_18((Control)(object)Label5, new Point(13, 154));
					Admit.smethod_19((Control)(object)Label5, "Label5");
					num = (int)(num2 * 2079180518) ^ -667964351;
					continue;
				case 369u:
					Admit.smethod_18((Control)(object)SaveBtn, new Point(814, 746));
					num = (int)((num2 * 1381196267) ^ 0x6ED736D4);
					continue;
				case 368u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)DateInTxt);
					num = ((int)num2 * -1011319240) ^ 0x18E3860F;
					continue;
				case 367u:
					num = ((int)num2 * -533338615) ^ 0x46BEA00A;
					continue;
				case 366u:
					num = ((int)num2 * -1251763233) ^ -2111754525;
					continue;
				case 365u:
					Admit.smethod_37((Control)(object)ClearBtn, bool_0: false);
					num = ((int)num2 * -1620022874) ^ 0x27DA0D2B;
					continue;
				case 364u:
					Admit.smethod_28((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					num = ((int)num2 * -1123965727) ^ -688668309;
					continue;
				case 363u:
					num = (int)(num2 * 2074217475) ^ -1700582549;
					continue;
				case 362u:
					num = (int)(num2 * 1412298498) ^ -1087395869;
					continue;
				case 361u:
					Admit.smethod_20((Control)(object)PatientInfoBox, new Size(439, 298));
					num = ((int)num2 * -312993357) ^ -1844799177;
					continue;
				case 360u:
					Admit.smethod_51((Control)(object)this, Color.White);
					num = (int)(num2 * 1834124778) ^ -1173376212;
					continue;
				case 359u:
					Admit.smethod_17((Control)(object)Label6, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -2027539574) ^ 0x5AA4D02E;
					continue;
				case 358u:
					Admit.smethod_18((Control)(object)RoomType1Txt, new Point(161, 73));
					num = (int)((num2 * 143015667) ^ 0x5BCD709F);
					continue;
				case 357u:
					Admit.smethod_19((Control)(object)Label1, "Label1");
					num = (int)(num2 * 78384446) ^ -475535439;
					continue;
				case 356u:
					num = ((int)num2 * -1667649094) ^ -1030463901;
					continue;
				case 355u:
					Admit.smethod_38((TextBoxBase)(object)NameTxt, bool_0: true);
					num = (int)((num2 * 1152935919) ^ 0x17B960C);
					continue;
				case 354u:
					Admit.smethod_23(Label1, (ContentAlignment)32);
					num = (int)(num2 * 1073548671) ^ -988856559;
					continue;
				case 353u:
					Admit.smethod_20((Control)(object)GenderTxt, new Size(100, 28));
					num = ((int)num2 * -2037001957) ^ 0x5AFEBAA6;
					continue;
				case 352u:
					Admit.smethod_30((ButtonBase)(object)SaveBtn, "Save");
					num = (int)(num2 * 1429772795) ^ -1144065080;
					continue;
				case 351u:
					num = ((int)num2 * -854377606) ^ -1630448640;
					continue;
				case 350u:
					num = (int)((num2 * 1971665210) ^ 0x4733B714);
					continue;
				case 349u:
					Admit.smethod_17((Control)(object)AdmitDetailsBox, Admit.smethod_16("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -652043129) ^ 0x2C1CC9BE;
					continue;
				case 348u:
					SearchBtn = Admit.smethod_5();
					num = ((int)num2 * -889646615) ^ -556755291;
					continue;
				case 347u:
					num = (int)(num2 * 2028180304) ^ -491158656;
					continue;
				case 346u:
					num = (int)((num2 * 2021662437) ^ 0x1F4BC3B3);
					continue;
				case 345u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)Label15);
					num = (int)((num2 * 961991059) ^ 0x2BD7985A);
					continue;
				case 344u:
					Label4 = Admit.smethod_3();
					num = ((int)num2 * -1112062873) ^ -1775757847;
					continue;
				case 343u:
					Admit.smethod_37((Control)(object)PatientInfoBox, bool_0: false);
					Admit.smethod_18((Control)(object)MobileSTxt, new Point(96, 116));
					num = ((int)num2 * -173368622) ^ -1674732319;
					continue;
				case 342u:
					num = (int)(num2 * 1685514555) ^ -505585976;
					continue;
				case 341u:
					Admit.smethod_19((Control)(object)Label8, "Label8");
					num = (int)(num2 * 1481402682) ^ -1540468380;
					continue;
				case 340u:
					num = ((int)num2 * -151092295) ^ 0x510B2C54;
					continue;
				case 339u:
					Admit.smethod_19((Control)(object)SearchResultGrid, "SearchResultGrid");
					num = (int)((num2 * 65276226) ^ 0x3749525D);
					continue;
				case 338u:
					Admit.smethod_26(AdmitDetailsBox, bool_0: false);
					num = (int)(num2 * 1889238981) ^ -1087453006;
					continue;
				case 337u:
					num = ((int)num2 * -818054211) ^ 0x4BAEFFC0;
					continue;
				case 336u:
					Admit.smethod_45(PictureBox1, (Image)(object)Resources.medical_bed_icon);
					num = ((int)num2 * -2097088870) ^ 0x29DFB4BB;
					continue;
				case 335u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)AddressTxt);
					num = ((int)num2 * -350754053) ^ 0x1843BE14;
					continue;
				case 334u:
					Admit.smethod_20((Control)(object)GroupBox1, new Size(623, 128));
					num = ((int)num2 * -535545289) ^ 0x3C2E8EC6;
					continue;
				case 333u:
					num = ((int)num2 * -1105783165) ^ -211492573;
					continue;
				case 332u:
					num = ((int)num2 * -1767950318) ^ -816873020;
					continue;
				case 331u:
					Admit.smethod_21((Control)(object)Label1, 3);
					num = ((int)num2 * -1092913910) ^ 0x77BC3F72;
					continue;
				case 330u:
					num = (int)(num2 * 943726115) ^ -1377186755;
					continue;
				case 329u:
					num = ((int)num2 * -783062409) ^ 0x512FA690;
					continue;
				case 328u:
					num = ((int)num2 * -1437463645) ^ 0x342BEEAD;
					continue;
				case 327u:
					Admit.smethod_19((Control)(object)MobileSTxt, "MobileSTxt");
					Admit.smethod_38((TextBoxBase)(object)MobileSTxt, bool_0: true);
					num = (int)((num2 * 1918151231) ^ 0x7CAD51);
					continue;
				case 326u:
					Admit.smethod_29((Control)(object)ClearBtn, Color.White);
					num = ((int)num2 * -1585596907) ^ -1354361883;
					continue;
				case 325u:
					Admit.smethod_19((Control)(object)DateIn1Txt, "DateIn1Txt");
					num = ((int)num2 * -1680909460) ^ -919386181;
					continue;
				case 324u:
					Admit.smethod_38((TextBoxBase)(object)DateIn1Txt, bool_0: true);
					num = (int)((num2 * 645492552) ^ 0x37509388);
					continue;
				case 323u:
					Admit.smethod_18((Control)(object)MobileTxt, new Point(120, 86));
					num = ((int)num2 * -1153823903) ^ 0x2DC6305C;
					continue;
				case 322u:
					Admit.smethod_19((Control)(object)RoomNo1Txt, "RoomNo1Txt");
					num = ((int)num2 * -1978497046) ^ 0x23EEC7D;
					continue;
				case 321u:
					num = ((int)num2 * -1237015757) ^ 0xC033336;
					continue;
				case 320u:
					num = ((int)num2 * -37664903) ^ 0x5F94A465;
					continue;
				case 319u:
					num = (int)(num2 * 1158307094) ^ -1137350409;
					continue;
				case 318u:
					Admit.smethod_34(SearchResultGrid, bool_0: true);
					num = ((int)num2 * -309710105) ^ 0x485E9E5F;
					continue;
				case 317u:
					Admit.smethod_44(PrintDialog1, bool_0: true);
					num = (int)(num2 * 891616964) ^ -1873965464;
					continue;
				case 316u:
					num = ((int)num2 * -1567195210) ^ -157230676;
					continue;
				case 315u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)GroupBox1), (Control)(object)SearchBtn);
					num = (int)(num2 * 1228159030) ^ -573427422;
					continue;
				case 314u:
					num = (int)(num2 * 1503222201) ^ -500742487;
					continue;
				case 313u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)Label6);
					num = ((int)num2 * -994728149) ^ 0x4986B0D4;
					continue;
				case 312u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)NameTxt);
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)Label14);
					num = (int)(num2 * 335203805) ^ -737589607;
					continue;
				case 311u:
					Admit.smethod_19((Control)(object)PrintBtn, "PrintBtn");
					num = ((int)num2 * -2035813371) ^ -915702405;
					continue;
				case 310u:
					Admit.smethod_37((Control)(object)SearchResultGrid, bool_0: false);
					num = (int)(num2 * 242801030) ^ -21062956;
					continue;
				case 309u:
					num = ((int)num2 * -1480640985) ^ 0x3E0471FF;
					continue;
				case 308u:
					num = ((int)num2 * -1373066086) ^ -986729627;
					continue;
				case 307u:
					num = (int)((num2 * 1012853060) ^ 0x1F03B524);
					continue;
				case 306u:
					num = (int)((num2 * 1257898933) ^ 0x3B64CFBE);
					continue;
				case 305u:
					Admit.smethod_27(AdmitDetailsBox, "Admit Details");
					num = ((int)num2 * -1473801572) ^ -49749549;
					continue;
				case 304u:
					Admit.smethod_21((Control)(object)GenderTxt, 6);
					num = ((int)num2 * -782332942) ^ 0x3F287F1D;
					continue;
				case 303u:
					Admit.smethod_21((Control)(object)Label15, 10);
					num = ((int)num2 * -437348017) ^ 0x293AED52;
					continue;
				case 302u:
					num = (int)(num2 * 2122286099) ^ -1483849830;
					continue;
				case 301u:
					num = ((int)num2 * -1748098223) ^ 0x7DA1837E;
					continue;
				case 300u:
					SaveBtn = Admit.smethod_5();
					num = ((int)num2 * -1302139247) ^ -1656848235;
					continue;
				case 299u:
					MobileSTxt = Admit.smethod_6();
					num = (int)((num2 * 1716413240) ^ 0x605E0BE);
					continue;
				case 298u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)GroupBox1);
					num = ((int)num2 * -1870195244) ^ -2120444475;
					continue;
				case 297u:
					num = (int)((num2 * 859676400) ^ 0x39400770);
					continue;
				case 295u:
					Admit.smethod_29((Control)(object)AdmitDischargeBtn, Color.White);
					num = (int)((num2 * 1638068643) ^ 0x3805CC66);
					continue;
				case 294u:
					num = (int)((num2 * 410675900) ^ 0x2BAB2842);
					continue;
				case 293u:
					num = (int)(num2 * 1211315858) ^ -1427005401;
					continue;
				case 292u:
					num = (int)((num2 * 353751014) ^ 0x75830C27);
					continue;
				case 291u:
					Admit.smethod_19((Control)(object)AddressTxt, "AddressTxt");
					Admit.smethod_38((TextBoxBase)(object)AddressTxt, bool_0: true);
					Admit.smethod_20((Control)(object)AddressTxt, new Size(298, 90));
					num = (int)((num2 * 615695864) ^ 0x12EA8213);
					continue;
				case 290u:
					num = (int)(num2 * 1260445697) ^ -757323824;
					continue;
				case 289u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)DateOut1Txt);
					num = ((int)num2 * -1552997774) ^ 0x525E0C5D;
					continue;
				case 288u:
					Admit.smethod_21((Control)(object)Label14, 8);
					num = (int)((num2 * 2015000168) ^ 0x37BD3B81);
					continue;
				case 287u:
					Label2 = Admit.smethod_3();
					num = ((int)num2 * -1421156211) ^ 0x476E516D;
					continue;
				case 286u:
					Admit.smethod_21((Control)(object)RoomNo1Txt, 20);
					num = ((int)num2 * -708264400) ^ -130900877;
					continue;
				case 285u:
					Admit.smethod_19((Control)(object)ClearBtn, "ClearBtn");
					num = ((int)num2 * -765730987) ^ -1835153073;
					continue;
				case 284u:
					Admit.smethod_19((Control)(object)Label7, "Label7");
					num = (int)(num2 * 71497873) ^ -1273044929;
					continue;
				case 283u:
					Admit.smethod_20((Control)(object)DateIn1Txt, new Size(181, 28));
					num = (int)(num2 * 823751859) ^ -1736295924;
					continue;
				case 282u:
					Admit.smethod_46(PictureBox1, (PictureBoxSizeMode)1);
					Admit.smethod_47(PictureBox1, 2);
					num = ((int)num2 * -1202494956) ^ -2024042008;
					continue;
				case 281u:
					Admit.smethod_21((Control)(object)Label10, 3);
					num = ((int)num2 * -989252511) ^ -1165797800;
					continue;
				case 280u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)AgeTxt);
					num = (int)((num2 * 1065564865) ^ 0x40F3FE4F);
					continue;
				case 279u:
					Label3 = Admit.smethod_3();
					num = (int)(num2 * 1587981647) ^ -22342661;
					continue;
				case 278u:
					Admit.smethod_13((ISupportInitialize)SearchResultGrid);
					Admit.smethod_12((Control)(object)PatientInfoBox);
					num = (int)((num2 * 558157766) ^ 0x154E79F7);
					continue;
				case 277u:
					Admit.smethod_40(RoomTypeTxt, (ComboBoxStyle)2);
					num = (int)((num2 * 1723251731) ^ 0x4E99A248);
					continue;
				case 276u:
					Admit.smethod_28((ButtonBase)(object)SaveBtn, Color.MidnightBlue);
					Admit.smethod_17((Control)(object)SaveBtn, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1314792296) ^ 0x1437929E;
					continue;
				case 275u:
					num = ((int)num2 * -506627444) ^ 0x20A5A8FE;
					continue;
				case 274u:
					num = (int)(num2 * 2111840243) ^ -1761881555;
					continue;
				case 273u:
					num = ((int)num2 * -2114481509) ^ -1463336917;
					continue;
				case 272u:
					Admit.smethod_39(AddressTxt, bool_0: true);
					num = ((int)num2 * -443446007) ^ -1902362571;
					continue;
				case 271u:
					Admit.smethod_20((Control)(object)Label2, new Size(77, 28));
					num = (int)((num2 * 473469982) ^ 0x29B2FDD3);
					continue;
				case 270u:
					Admit.smethod_21((Control)(object)FeesTxt, 9);
					num = ((int)num2 * -368750946) ^ -1143351962;
					continue;
				case 269u:
					Admit.smethod_17((Control)(object)Label13, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 627344862) ^ -529820291;
					continue;
				case 268u:
					num = (int)((num2 * 1427748929) ^ 0x78638671);
					continue;
				case 267u:
					num = ((int)num2 * -995056373) ^ 0x7B00E4B4;
					continue;
				case 266u:
					Admit.smethod_21((Control)(object)DateOutTxt, 17);
					num = ((int)num2 * -1248063292) ^ -1422377715;
					continue;
				case 265u:
					num = ((int)num2 * -17201144) ^ -1765658595;
					continue;
				case 264u:
					Admit.smethod_43(Admit.smethod_42(RoomTypeTxt), new object[3] { "General", "V.I.P.", "ICU" });
					num = (int)(num2 * 503994065) ^ -1152961929;
					continue;
				case 263u:
					Admit.smethod_19((Control)(object)AdmitDischargeBtn, "AdmitDischargeBtn");
					num = ((int)num2 * -1195961932) ^ -195201777;
					continue;
				case 262u:
					num = (int)(num2 * 97125035) ^ -27677228;
					continue;
				case 261u:
					RoomType1Txt = Admit.smethod_6();
					num = ((int)num2 * -1826248947) ^ -357054743;
					continue;
				case 260u:
					Admit.smethod_19((Control)(object)PIDTxt, "PIDTxt");
					num = (int)(num2 * 1524157729) ^ -2035056059;
					continue;
				case 259u:
					Admit.smethod_18((Control)(object)ClearBtn, new Point(504, 746));
					num = (int)(num2 * 1359348883) ^ -1298518579;
					continue;
				case 258u:
					num = ((int)num2 * -236934264) ^ -1751409666;
					continue;
				case 257u:
					num = (int)(num2 * 1004843190) ^ -1910516233;
					continue;
				case 256u:
					Admit.smethod_40(StatusTxt, (ComboBoxStyle)2);
					num = ((int)num2 * -1377303281) ^ -102525641;
					continue;
				case 255u:
					AdmitDetailsBox = Admit.smethod_4();
					num = ((int)num2 * -1944981080) ^ 0x14F09E44;
					continue;
				case 254u:
					num = ((int)num2 * -780408055) ^ -1138422905;
					continue;
				case 253u:
					Admit.smethod_17((Control)(object)AgeTxt, Admit.smethod_16("MS Reference Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Admit.smethod_18((Control)(object)AgeTxt, new Point(96, 154));
					num = ((int)num2 * -1536374383) ^ 0x49CFF349;
					continue;
				case 252u:
					Admit.smethod_28((ButtonBase)(object)SearchBtn, Color.MidnightBlue);
					num = ((int)num2 * -2072540450) ^ 0x3F9B81C1;
					continue;
				case 251u:
					Admit.smethod_18((Control)(object)RoomTypeTxt, new Point(161, 71));
					num = (int)((num2 * 1063531685) ^ 0x499C6B14);
					continue;
				case 250u:
					num = ((int)num2 * -977252754) ^ -182677493;
					continue;
				case 249u:
					num = ((int)num2 * -3463312) ^ 0x4238E56A;
					continue;
				case 248u:
					Admit.smethod_21((Control)(object)Label2, 0);
					num = ((int)num2 * -2024623498) ^ 0xD40B088;
					continue;
				case 247u:
					Admit.smethod_55((Control)(object)PatientInfoBox, bool_0: false);
					num = ((int)num2 * -1990072183) ^ 0x12A8A7B9;
					continue;
				case 246u:
					Admit.smethod_38((TextBoxBase)(object)GenderTxt, bool_0: true);
					num = (int)(num2 * 1208018914) ^ -1053035041;
					continue;
				case 245u:
					Admit.smethod_19((Control)(object)GroupBox1, "GroupBox1");
					num = ((int)num2 * -455312588) ^ 0x767751CF;
					continue;
				case 244u:
					AgeTxt = Admit.smethod_6();
					num = (int)(num2 * 637183075) ^ -402095235;
					continue;
				case 243u:
					Admit.smethod_20((Control)(object)FeesTxt, new Size(86, 28));
					num = ((int)num2 * -1764581103) ^ 0x35DC27A6;
					continue;
				case 242u:
					num = ((int)num2 * -1834201481) ^ -260693505;
					continue;
				case 241u:
					Admit.smethod_17((Control)(object)Label4, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 362522789) ^ 0x22078F00);
					continue;
				case 240u:
					Label8 = Admit.smethod_3();
					num = ((int)num2 * -1061299462) ^ -1263435738;
					continue;
				case 239u:
					Admit.smethod_18((Control)(object)Label3, new Point(37, 87));
					num = (int)((num2 * 633116261) ^ 0x7417959B);
					continue;
				case 238u:
					num = ((int)num2 * -1215219348) ^ -1094724141;
					continue;
				case 237u:
					num = (int)(num2 * 624625340) ^ -377044154;
					continue;
				case 236u:
					Admit.smethod_22(Label6, "Gender : ");
					num = (int)((num2 * 735728915) ^ 0x3E33D1D4);
					continue;
				case 235u:
					Admit.smethod_19((Control)(object)MobileTxt, "MobileTxt");
					num = ((int)num2 * -1504199937) ^ -1306677180;
					continue;
				case 234u:
					num = (int)(num2 * 765440846) ^ -400350264;
					continue;
				case 233u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)SearchResultGrid);
					num = ((int)num2 * -159538491) ^ -1928108601;
					continue;
				case 232u:
					Admit.smethod_20((Control)(object)Label5, new Size(68, 26));
					Admit.smethod_21((Control)(object)Label5, 1);
					num = (int)((num2 * 1783839400) ^ 0x7BE1DCFD);
					continue;
				case 231u:
					num = ((int)num2 * -1236311270) ^ 0x2B910C7A;
					continue;
				case 230u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)AdmitDetailsBox);
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)PatientInfoBox);
					num = (int)((num2 * 1953233459) ^ 0x71AD6ECD);
					continue;
				case 229u:
					num = ((int)num2 * -359736580) ^ -1142148831;
					continue;
				case 228u:
					num = ((int)num2 * -640161380) ^ -876795407;
					continue;
				case 227u:
					Admit.smethod_17((Control)(object)GroupBox1, Admit.smethod_16("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1711110830) ^ -1869863169;
					continue;
				case 226u:
					Admit.smethod_21((Control)(object)PIDTxt, 4);
					num = (int)(num2 * 132240345) ^ -1789418419;
					continue;
				case 225u:
					Admit.smethod_23(Label12, (ContentAlignment)32);
					num = ((int)num2 * -622318483) ^ 0x3ADF2F53;
					continue;
				case 224u:
					num = (int)((num2 * 1545233647) ^ 0x648FC884);
					continue;
				case 223u:
					num = (int)((num2 * 961607952) ^ 0x32ECC6DC);
					continue;
				case 222u:
					Admit.smethod_21((Control)(object)Label9, 2);
					num = (int)((num2 * 198348444) ^ 0x4F715D4E);
					continue;
				case 221u:
					Admit.smethod_18((Control)(object)RoomNoTxt, new Point(161, 32));
					num = (int)((num2 * 552741147) ^ 0x41892CC6);
					continue;
				case 220u:
					Admit.smethod_37((Control)(object)AdmitDischargeBtn, bool_0: false);
					Admit.smethod_18((Control)(object)RoomNo1Txt, new Point(161, 32));
					num = ((int)num2 * -1470423284) ^ 0x58D205C;
					continue;
				case 219u:
					PrintDialog1 = Admit.smethod_9();
					num = (int)((num2 * 1462830934) ^ 0x4A1FE0F4);
					continue;
				case 218u:
					num = ((int)num2 * -339007288) ^ 0x1D58CF56;
					continue;
				case 217u:
					num = ((int)num2 * -2014159155) ^ -488793127;
					continue;
				case 216u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)DateOutTxt);
					num = ((int)num2 * -757698562) ^ -632210251;
					continue;
				case 215u:
					PrintDocument1 = Admit.smethod_10();
					PictureBox1 = Admit.smethod_11();
					num = ((int)num2 * -1353138163) ^ -1568726717;
					continue;
				case 214u:
					Admit.smethod_21((Control)(object)HistoryBtn, 18);
					num = (int)(num2 * 630700415) ^ -330600220;
					continue;
				case 213u:
					Admit.smethod_23(Label9, (ContentAlignment)32);
					num = ((int)num2 * -1468642908) ^ 0x38274E0B;
					continue;
				case 212u:
					Admit.smethod_17((Control)(object)SearchBtn, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 2146656710) ^ -1525294704;
					continue;
				case 211u:
					Admit.smethod_17((Control)(object)RoomNoTxt, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -146097243) ^ 0x183EF81B;
					continue;
				case 210u:
					Admit.smethod_22(Label8, "Room No :");
					Admit.smethod_23(Label8, (ContentAlignment)32);
					num = (int)(num2 * 1130136144) ^ -1536469521;
					continue;
				case 209u:
					num = (int)(num2 * 1795260066) ^ -411559632;
					continue;
				case 208u:
					Admit.smethod_22(Label9, "Room Type :");
					num = ((int)num2 * -2129345005) ^ 0x3562DC6F;
					continue;
				case 207u:
					num = ((int)num2 * -718081648) ^ 0x7511DEF7;
					continue;
				case 206u:
					Admit.smethod_21((Control)(object)NameSTxt, 1);
					num = ((int)num2 * -1590804523) ^ 0x3D40B17A;
					continue;
				case 205u:
					Admit.smethod_19((Control)(object)NameSTxt, "NameSTxt");
					Admit.smethod_20((Control)(object)NameSTxt, new Size(237, 28));
					num = (int)((num2 * 408019488) ^ 0x3541BBD2);
					continue;
				case 204u:
					Admit.smethod_22(Label4, "PID :");
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)RoomNo1Txt);
					num = ((int)num2 * -1582820382) ^ 0x5DDF61A1;
					continue;
				case 203u:
					num = ((int)num2 * -167622320) ^ -1344448574;
					continue;
				case 202u:
					Admit.smethod_19((Control)(object)RoomType1Txt, "RoomType1Txt");
					num = ((int)num2 * -410537744) ^ 0x2906FA2D;
					continue;
				case 201u:
					Admit.smethod_20((Control)(object)HistoryBtn, new Size(181, 41));
					num = ((int)num2 * -932046849) ^ 0x61F6225D;
					continue;
				case 200u:
					Admit.smethod_20((Control)(object)AdmitDischargeBtn, new Size(181, 45));
					num = (int)(num2 * 727199067) ^ -1060218682;
					continue;
				case 199u:
					Admit.smethod_20((Control)(object)DateOut1Txt, new Size(181, 28));
					num = ((int)num2 * -434184576) ^ -816049365;
					continue;
				case 198u:
					Admit.smethod_30((ButtonBase)(object)PrintBtn, "Print");
					num = ((int)num2 * -483692287) ^ 0x7DA4B78F;
					continue;
				case 197u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)MobileSTxt);
					num = (int)(num2 * 1876998609) ^ -270498013;
					continue;
				case 196u:
					Admit.smethod_37((Control)(object)PrintBtn, bool_0: false);
					num = ((int)num2 * -692318791) ^ -1677053189;
					continue;
				case 195u:
					num = ((int)num2 * -1881292721) ^ -265564914;
					continue;
				case 194u:
					Admit.smethod_19((Control)(object)RoomTypeTxt, "RoomTypeTxt");
					num = (int)((num2 * 1564004138) ^ 0x18F925C9);
					continue;
				case 193u:
					num = (int)(num2 * 315008679) ^ -962837129;
					continue;
				case 192u:
					Admit.smethod_37((Control)(object)RoomType1Txt, bool_0: false);
					num = ((int)num2 * -1934251253) ^ 0x18BFCB69;
					continue;
				case 191u:
					Admit.smethod_22(Label15, "Mobile :");
					num = ((int)num2 * -1872270718) ^ -1047580518;
					continue;
				case 190u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)Label12);
					num = (int)((num2 * 1712174020) ^ 0x40DDF4D0);
					continue;
				case 189u:
					Admit.smethod_21((Control)(object)Label12, 11);
					Admit.smethod_22(Label12, "Date In  :");
					num = ((int)num2 * -1727740000) ^ 0x28A85BB5;
					continue;
				case 188u:
					RoomNo1Txt = Admit.smethod_6();
					num = (int)(num2 * 1418255664) ^ -625237198;
					continue;
				case 187u:
					Admit.smethod_29((Control)(object)HistoryBtn, Color.White);
					num = (int)((num2 * 700141458) ^ 0x49D2D623);
					continue;
				case 186u:
					num = ((int)num2 * -1206438030) ^ -987300493;
					continue;
				case 185u:
					Admit.smethod_30((ButtonBase)(object)AdmitDischargeBtn, "Admit/Discharge");
					num = ((int)num2 * -651639127) ^ -569419003;
					continue;
				case 184u:
					Admit.smethod_17((Control)(object)Label12, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -761746283) ^ 0x68F6CA23;
					continue;
				case 183u:
					num = (int)((num2 * 413045799) ^ 0x33BD3ACA);
					continue;
				case 182u:
					num = (int)((num2 * 1911814541) ^ 0x31D09C53);
					continue;
				case 181u:
					num = (int)((num2 * 1802814948) ^ 0x16BD4F3A);
					continue;
				case 180u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)ClearBtn);
					num = (int)((num2 * 1178005618) ^ 0x3D0751A7);
					continue;
				case 179u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)Label7);
					num = ((int)num2 * -1891868963) ^ -1347519241;
					continue;
				case 178u:
					num = (int)((num2 * 1447796004) ^ 0x2F1135CE);
					continue;
				case 177u:
					Admit.smethod_21((Control)(object)ClearBtn, 9);
					num = (int)(num2 * 600085323) ^ -1780769883;
					continue;
				case 176u:
					Admit.smethod_21((Control)(object)MobileTxt, 2);
					num = (int)(num2 * 1069446743) ^ -149036315;
					continue;
				case 175u:
					Admit.smethod_19((Control)(object)GenderTxt, "GenderTxt");
					num = ((int)num2 * -2087350549) ^ -1041153440;
					continue;
				case 174u:
					num = (int)(num2 * 1251806589) ^ -743687439;
					continue;
				case 173u:
					num = ((int)num2 * -1325421677) ^ 0x3BEA1233;
					continue;
				case 172u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)Label13);
					num = (int)(num2 * 1284896520) ^ -1099929043;
					continue;
				case 171u:
					Admit.smethod_38((TextBoxBase)(object)RoomNo1Txt, bool_0: true);
					Admit.smethod_20((Control)(object)RoomNo1Txt, new Size(141, 28));
					num = ((int)num2 * -423559196) ^ -463775488;
					continue;
				case 170u:
					num = (int)(num2 * 741721808) ^ -1809639474;
					continue;
				case 169u:
					Admit.smethod_20((Control)(object)Label11, new Size(76, 28));
					num = (int)(num2 * 614803470) ^ -2077433610;
					continue;
				case 168u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)FeesTxt);
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)Label10);
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)Label9);
					num = (int)((num2 * 1837410732) ^ 0x5716FED);
					continue;
				case 167u:
					num = (int)((num2 * 1204699443) ^ 0x3085502F);
					continue;
				case 166u:
					num = (int)((num2 * 822995484) ^ 0x595A1194);
					continue;
				case 165u:
					Admit.smethod_18((Control)(object)Label4, new Point(13, 43));
					Admit.smethod_19((Control)(object)Label4, "Label4");
					num = ((int)num2 * -473147183) ^ -8069513;
					continue;
				case 164u:
					num = ((int)num2 * -982880387) ^ -2060595640;
					continue;
				case 163u:
					Admit.smethod_20((Control)(object)Label14, new Size(77, 25));
					num = ((int)num2 * -2137989084) ^ 0x5E033220;
					continue;
				case 161u:
					GenderTxt = Admit.smethod_6();
					num = (int)((num2 * 1390462140) ^ 0x1168A5);
					continue;
				case 160u:
					Admit.smethod_17((Control)(object)Label2, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -3703211) ^ 0x352F3A8B;
					continue;
				case 159u:
					Admit.smethod_18((Control)(object)DateOut1Txt, new Point(161, 157));
					Admit.smethod_19((Control)(object)DateOut1Txt, "DateOut1Txt");
					num = ((int)num2 * -2135957814) ^ 0x61A1F234;
					continue;
				case 158u:
					ClearBtn = Admit.smethod_5();
					num = (int)((num2 * 1186002939) ^ 0x60E5B30D);
					continue;
				case 157u:
					num = ((int)num2 * -135683911) ^ 0x32E91E07;
					continue;
				case 156u:
					num = (int)((num2 * 1426995780) ^ 0x3A3B55C7);
					continue;
				case 155u:
					Admit.smethod_18((Control)(object)FeesTxt, new Point(92, 201));
					num = ((int)num2 * -292927851) ^ -549907668;
					continue;
				case 154u:
					num = ((int)num2 * -1706554930) ^ -1965937883;
					continue;
				case 153u:
					Admit.smethod_28((ButtonBase)(object)PrintBtn, Color.MidnightBlue);
					num = ((int)num2 * -1662864435) ^ -527770299;
					continue;
				case 152u:
					Admit.smethod_17((Control)(object)PatientInfoBox, Admit.smethod_16("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Admit.smethod_18((Control)(object)PatientInfoBox, new Point(59, 485));
					num = ((int)num2 * -541617992) ^ 0x3C5649EA;
					continue;
				case 151u:
					DateOut1Txt = Admit.smethod_6();
					num = ((int)num2 * -12573303) ^ -345877337;
					continue;
				case 150u:
					Admit.smethod_17((Control)(object)Label11, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1119531039) ^ 0x2584148A);
					continue;
				case 149u:
					Admit.smethod_21((Control)(object)Label4, 0);
					num = ((int)num2 * -1316603294) ^ 0x45705719;
					continue;
				case 148u:
					Admit.smethod_25(Admit.smethod_52((Control)(object)this), (Control)(object)HistoryBtn);
					num = (int)((num2 * 549559256) ^ 0x7BAE5CD0);
					continue;
				case 147u:
					num = ((int)num2 * -1712791460) ^ 0xF22CB7F;
					continue;
				case 146u:
					Admit.smethod_21((Control)(object)SearchResultGrid, 6);
					num = (int)((num2 * 62602567) ^ 0x52FF6916);
					continue;
				case 145u:
					num = (int)((num2 * 1884821591) ^ 0x3C7F2AAC);
					continue;
				case 144u:
					Label12 = Admit.smethod_3();
					num = (int)((num2 * 833372116) ^ 0x620489C2);
					continue;
				case 143u:
					num = (int)(num2 * 819881458) ^ -2112408503;
					continue;
				case 142u:
					Admit.smethod_17((Control)(object)Label8, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 2007378747) ^ 0x1CCAC85D);
					continue;
				case 141u:
					Admit.smethod_29((Control)(object)SearchBtn, Color.White);
					num = (int)((num2 * 84944547) ^ 0x2FD0CF4C);
					continue;
				case 140u:
					Admit.smethod_50((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -343482684) ^ 0x60817031;
					continue;
				case 139u:
					Admit.smethod_18((Control)(object)GroupBox1, new Point(155, 150));
					num = ((int)num2 * -1687612586) ^ 0x37ECD429;
					continue;
				case 138u:
					num = (int)((num2 * 1779077271) ^ 0x8C7AA6D);
					continue;
				case 137u:
					num = (int)(num2 * 1288241073) ^ -239853032;
					continue;
				case 136u:
					Admit.smethod_21((Control)(object)Label11, 10);
					num = ((int)num2 * -114806971) ^ 0x15846D73;
					continue;
				case 135u:
					Admit.smethod_19((Control)(object)SaveBtn, "SaveBtn");
					num = ((int)num2 * -1152970803) ^ 0x497CEFA9;
					continue;
				case 134u:
					Admit.smethod_58((Control)(object)this, bool_0: false);
					num = (int)((num2 * 273672914) ^ 0x38BB29D5);
					continue;
				case 133u:
					Admit.smethod_15(Label1, bool_0: true);
					Admit.smethod_17((Control)(object)Label1, Admit.smethod_16("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -411950514) ^ 0x24EB8C53;
					continue;
				case 132u:
					Admit.smethod_21((Control)(object)StatusTxt, 15);
					num = ((int)num2 * -1940826997) ^ -2081050688;
					continue;
				case 131u:
					Admit.smethod_20((Control)(object)RoomNoTxt, new Size(141, 27));
					num = (int)((num2 * 254401226) ^ 0x21C749B0);
					continue;
				case 130u:
					num = ((int)num2 * -1939487602) ^ 0x6B8563A9;
					continue;
				case 129u:
					Admit.smethod_19((Control)(object)Label15, "Label15");
					Admit.smethod_20((Control)(object)Label15, new Size(77, 26));
					num = (int)(num2 * 521509902) ^ -316346568;
					continue;
				case 128u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)StatusTxt);
					num = ((int)num2 * -2125448495) ^ -1433692152;
					continue;
				case 127u:
					Admit.smethod_18((Control)(object)GenderTxt, new Point(322, 152));
					num = (int)(num2 * 2100706329) ^ -341259658;
					continue;
				case 126u:
					num = (int)(num2 * 324911223) ^ -716648853;
					continue;
				case 125u:
					num = (int)(num2 * 1835763038) ^ -1201110992;
					continue;
				case 124u:
					Admit.smethod_54((Control)(object)this, new Size(977, 804));
					num = (int)(num2 * 1013339359) ^ -1830089322;
					continue;
				case 123u:
					Admit.smethod_18((Control)(object)DateInTxt, new Point(161, 111));
					num = (int)((num2 * 982207068) ^ 0x29485CAD);
					continue;
				case 122u:
					Admit.smethod_20((Control)(object)Label4, new Size(68, 25));
					num = (int)(num2 * 800666625) ^ -885192229;
					continue;
				case 121u:
					Label11 = Admit.smethod_3();
					num = ((int)num2 * -2074108112) ^ -1986420449;
					continue;
				case 120u:
					Admit.smethod_18((Control)(object)Label12, new Point(18, 111));
					num = ((int)num2 * -913433735) ^ -538927496;
					continue;
				case 119u:
					Admit.smethod_27(PatientInfoBox, "Patient Information");
					num = (int)((num2 * 653675877) ^ 0x33E1625E);
					continue;
				case 118u:
					Admit.smethod_12((Control)(object)GroupBox1);
					num = ((int)num2 * -893132757) ^ 0x651F64D5;
					continue;
				case 117u:
					Admit.smethod_26(PatientInfoBox, bool_0: false);
					num = (int)(num2 * 1556467260) ^ -299358023;
					continue;
				case 116u:
					Admit.smethod_19((Control)(object)RoomNoTxt, "RoomNoTxt");
					num = ((int)num2 * -361312437) ^ 0x7ECAFBE7;
					continue;
				case 115u:
					Admit.smethod_20((Control)(object)PictureBox1, new Size(126, 122));
					num = ((int)num2 * -1474232689) ^ -1303319059;
					continue;
				case 114u:
					Admit.smethod_41((ListControl)(object)RoomNoTxt, bool_0: true);
					num = ((int)num2 * -466304208) ^ 0x3F5EA998;
					continue;
				case 113u:
					Admit.smethod_55((Control)(object)AdmitDetailsBox, bool_0: false);
					num = ((int)num2 * -2030880469) ^ -1418352450;
					continue;
				case 112u:
					num = ((int)num2 * -474614638) ^ -1697638166;
					continue;
				case 111u:
					Admit.smethod_30((ButtonBase)(object)SearchBtn, "Search");
					num = (int)(num2 * 427350079) ^ -1457243242;
					continue;
				case 110u:
					num = ((int)num2 * -1044576) ^ 0x2AE29C8E;
					continue;
				case 109u:
					Admit.smethod_18((Control)(object)Label6, new Point(232, 154));
					Admit.smethod_19((Control)(object)Label6, "Label6");
					Admit.smethod_20((Control)(object)Label6, new Size(84, 26));
					num = ((int)num2 * -1547271044) ^ -712227252;
					continue;
				case 108u:
					Admit.smethod_18((Control)(object)NameTxt, new Point(96, 77));
					Admit.smethod_19((Control)(object)NameTxt, "NameTxt");
					num = ((int)num2 * -1711467739) ^ -580848278;
					continue;
				case 107u:
					Admit.smethod_18((Control)(object)Label15, new Point(13, 116));
					num = ((int)num2 * -1146855886) ^ 0x5B277B68;
					continue;
				case 106u:
					Admit.smethod_21((Control)(object)DateOut1Txt, 14);
					num = (int)((num2 * 466662419) ^ 0x2026BB1C);
					continue;
				case 105u:
					Admit.smethod_21((Control)(object)Label6, 2);
					num = ((int)num2 * -1079745138) ^ 0x4F86E889;
					continue;
				case 104u:
					num = ((int)num2 * -1787147384) ^ 0x77884117;
					continue;
				case 103u:
					Label5 = Admit.smethod_3();
					num = ((int)num2 * -1635599163) ^ -2007772105;
					continue;
				case 102u:
					Admit.smethod_41((ListControl)(object)RoomTypeTxt, bool_0: true);
					num = (int)((num2 * 1608385549) ^ 0x6242A3C8);
					continue;
				case 101u:
					num = (int)(num2 * 189915586) ^ -179903421;
					continue;
				case 100u:
					num = (int)((num2 * 880675746) ^ 0xD6BA82A);
					continue;
				case 99u:
					num = (int)((num2 * 1165253055) ^ 0x7B757C3D);
					continue;
				case 98u:
					Admit.smethod_37((Control)(object)SaveBtn, bool_0: false);
					num = ((int)num2 * -1640047148) ^ 0x5B01BFF3;
					continue;
				case 97u:
					Admit.smethod_18((Control)(object)Label1, new Point(392, 63));
					num = ((int)num2 * -1643318265) ^ 0x7617405A;
					continue;
				case 96u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)Label8);
					num = (int)(num2 * 1803790425) ^ -1617263206;
					continue;
				case 95u:
					Admit.smethod_22(Label5, "DOB :");
					num = (int)((num2 * 664396045) ^ 0x2F542EF7);
					continue;
				case 94u:
					Admit.smethod_56((Control)(object)AdmitDetailsBox);
					num = (int)(num2 * 227577752) ^ -1861085819;
					continue;
				case 93u:
					Admit.smethod_19((Control)(object)Label10, "Label10");
					num = ((int)num2 * -220231370) ^ -817893448;
					continue;
				case 92u:
					Admit.smethod_31((ButtonBase)(object)AdmitDischargeBtn, bool_0: false);
					num = ((int)num2 * -189424007) ^ -104306617;
					continue;
				case 91u:
					num = (int)(num2 * 440424164) ^ -39109120;
					continue;
				case 90u:
					Admit.smethod_37((Control)(object)AdmitDetailsBox, bool_0: false);
					num = ((int)num2 * -430775353) ^ 0x3272AAD0;
					continue;
				case 89u:
					PIDTxt = Admit.smethod_6();
					num = (int)((num2 * 897572752) ^ 0x4D83BE76);
					continue;
				case 88u:
					Admit.smethod_19((Control)(object)PatientInfoBox, "PatientInfoBox");
					num = ((int)num2 * -791132310) ^ -1227217978;
					continue;
				case 87u:
					num = (int)((num2 * 1222309883) ^ 0x45306DBA);
					continue;
				case 86u:
					Admit.smethod_21((Control)(object)Label3, 3);
					num = (int)((num2 * 670465612) ^ 0x51383829);
					continue;
				case 85u:
					num = ((int)num2 * -1806008098) ^ -1282321154;
					continue;
				case 84u:
					Admit.smethod_40(RoomNoTxt, (ComboBoxStyle)2);
					num = (int)(num2 * 1443702556) ^ -833571833;
					continue;
				case 83u:
					Admit.smethod_20((Control)(object)MobileTxt, new Size(237, 28));
					num = ((int)num2 * -119693992) ^ -1403741281;
					continue;
				case 82u:
					num = (int)(num2 * 1595631986) ^ -1839454193;
					continue;
				case 81u:
					Admit.smethod_18((Control)(object)PIDTxt, new Point(96, 43));
					num = (int)(num2 * 2129968752) ^ -1233977011;
					continue;
				case 80u:
					num = ((int)num2 * -1857628643) ^ 0x28C5317D;
					continue;
				case 79u:
					num = ((int)num2 * -2109271995) ^ 0x244DDB86;
					continue;
				case 78u:
					Admit.smethod_22(Label7, "Address : ");
					num = (int)(num2 * 47347293) ^ -24069171;
					continue;
				case 77u:
					Admit.smethod_29((Control)(object)PrintBtn, Color.White);
					num = ((int)num2 * -420756823) ^ 0x6EDBBA49;
					continue;
				case 76u:
					PrintBtn = Admit.smethod_5();
					num = ((int)num2 * -2107481290) ^ -576046913;
					continue;
				case 75u:
					Admit.smethod_48(PictureBox1, bool_0: false);
					Admit.smethod_28((ButtonBase)(object)HistoryBtn, Color.MidnightBlue);
					num = (int)((num2 * 688928311) ^ 0x4F986621);
					continue;
				case 74u:
					Admit.smethod_20((Control)(object)Label9, new Size(122, 28));
					num = (int)((num2 * 1333096378) ^ 0xD64D579);
					continue;
				case 73u:
					Admit.smethod_33(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					num = ((int)num2 * -796509336) ^ 0x6378261A;
					continue;
				case 72u:
					num = (int)(num2 * 823310437) ^ -2047338020;
					continue;
				case 71u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)AdmitDetailsBox), (Control)(object)RoomType1Txt);
					num = ((int)num2 * -1110532861) ^ 0xF764F22;
					continue;
				case 70u:
					Admit.smethod_21((Control)(object)GroupBox1, 5);
					num = (int)((num2 * 633248493) ^ 0x45A4920B);
					continue;
				case 69u:
					Admit.smethod_20((Control)(object)Label13, new Size(109, 25));
					num = (int)((num2 * 532515371) ^ 0x2DFCB644);
					continue;
				case 68u:
					num = ((int)num2 * -400435388) ^ 0x1A38A3DC;
					continue;
				case 67u:
					num = ((int)num2 * -308687433) ^ 0x6AD1B3E2;
					continue;
				case 66u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)GenderTxt);
					num = (int)((num2 * 184544313) ^ 0x6F140C23);
					continue;
				case 65u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)PIDTxt);
					num = ((int)num2 * -1553691685) ^ -2048446578;
					continue;
				case 64u:
					num = ((int)num2 * -707094882) ^ -769641792;
					continue;
				case 63u:
					num = ((int)num2 * -222400006) ^ -2105246410;
					continue;
				case 62u:
					Admit.smethod_38((TextBoxBase)(object)PIDTxt, bool_0: true);
					Admit.smethod_20((Control)(object)PIDTxt, new Size(128, 28));
					num = (int)((num2 * 1079331174) ^ 0x52523482);
					continue;
				case 61u:
					Admit.smethod_21((Control)(object)RoomTypeTxt, 18);
					Admit.smethod_40(DateOutTxt, (ComboBoxStyle)2);
					Admit.smethod_17((Control)(object)DateOutTxt, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Admit.smethod_41((ListControl)(object)DateOutTxt, bool_0: true);
					Admit.smethod_18((Control)(object)DateOutTxt, new Point(161, 157));
					Admit.smethod_19((Control)(object)DateOutTxt, "DateOutTxt");
					num = ((int)num2 * -1681112776) ^ -1234718504;
					continue;
				case 60u:
					Admit.smethod_20((Control)(object)SearchBtn, new Size(133, 37));
					num = ((int)num2 * -938530967) ^ -1121766823;
					continue;
				case 59u:
					Admit.smethod_20((Control)(object)Label10, new Size(79, 25));
					num = (int)(num2 * 1988642706) ^ -1011092309;
					continue;
				case 58u:
					Admit.smethod_18((Control)(object)SearchBtn, new Point(468, 82));
					Admit.smethod_19((Control)(object)SearchBtn, "SearchBtn");
					num = (int)((num2 * 1704824062) ^ 0x38F93360);
					continue;
				case 57u:
					Admit.smethod_30((ButtonBase)(object)HistoryBtn, "History");
					Admit.smethod_31((ButtonBase)(object)HistoryBtn, bool_0: false);
					num = (int)(num2 * 678533017) ^ -903931863;
					continue;
				case 56u:
					Admit.smethod_19((Control)(object)FeesTxt, "FeesTxt");
					num = ((int)num2 * -1571712809) ^ 0x6D347F68;
					continue;
				case 55u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)PatientInfoBox), (Control)(object)Label5);
					num = (int)(num2 * 1272314637) ^ -488965750;
					continue;
				case 54u:
					Admit.smethod_57((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -560808072) ^ 0x69232105;
					continue;
				case 53u:
					num = ((int)num2 * -427317633) ^ 0x187500A7;
					continue;
				case 52u:
					Admit.smethod_37((Control)(object)HistoryBtn, bool_0: false);
					num = ((int)num2 * -871150893) ^ 0x6C5DE0DD;
					continue;
				case 51u:
					Admit.smethod_19((Control)(object)DateInTxt, "DateInTxt");
					Admit.smethod_20((Control)(object)DateInTxt, new Size(181, 27));
					num = ((int)num2 * -215539264) ^ -489976537;
					continue;
				case 50u:
					num = (int)((num2 * 1131270496) ^ 0x4E13062D);
					continue;
				case 49u:
					DateInTxt = Admit.smethod_8();
					StatusTxt = Admit.smethod_8();
					num = ((int)num2 * -2017522084) ^ 0x1ABAC611;
					continue;
				case 48u:
					num = ((int)num2 * -428859941) ^ 0x4B62AEC5;
					continue;
				case 47u:
					num = (int)(num2 * 1262330044) ^ -2060583432;
					continue;
				case 46u:
					Admit.smethod_19((Control)(object)HistoryBtn, "HistoryBtn");
					num = (int)((num2 * 1939125891) ^ 0x2DB42E6B);
					continue;
				case 45u:
					HistoryBtn = Admit.smethod_5();
					num = (int)((num2 * 200259811) ^ 0x3D20266A);
					continue;
				case 44u:
					Admit.smethod_19((Control)(object)Label12, "Label12");
					num = (int)(num2 * 1266434790) ^ -1458732044;
					continue;
				case 43u:
					Admit.smethod_53((Control)(object)this, "Admit");
					num = (int)((num2 * 964532972) ^ 0x26857683);
					continue;
				case 42u:
					Admit.smethod_20((Control)(object)AgeTxt, new Size(128, 23));
					Admit.smethod_21((Control)(object)AgeTxt, 5);
					num = (int)((num2 * 952537610) ^ 0x365FCC6D);
					continue;
				case 41u:
					num = (int)(num2 * 1738006910) ^ -580812435;
					continue;
				case 40u:
					Admit.smethod_17((Control)(object)Label3, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1725708385) ^ 0x61CCCE6F;
					continue;
				case 39u:
					Admit.smethod_36(Admit.smethod_35(SearchResultGrid), 24);
					Admit.smethod_20((Control)(object)SearchResultGrid, new Size(853, 169));
					num = (int)(num2 * 961480816) ^ -855235720;
					continue;
				case 38u:
					Admit.smethod_17((Control)(object)Label7, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Admit.smethod_18((Control)(object)Label7, new Point(13, 198));
					num = (int)(num2 * 2134293604) ^ -1216278672;
					continue;
				case 37u:
					Admit.smethod_20((Control)(object)MobileSTxt, new Size(253, 28));
					Admit.smethod_21((Control)(object)MobileSTxt, 11);
					Admit.smethod_17((Control)(object)Label15, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1454714923) ^ 0x5790F368;
					continue;
				case 36u:
					num = (int)(num2 * 1318957131) ^ -1214630581;
					continue;
				case 35u:
					Admit.smethod_20((Control)(object)Label1, new Size(344, 35));
					num = (int)((num2 * 236909423) ^ 0x6F85B7E);
					continue;
				case 34u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)GroupBox1), (Control)(object)NameSTxt);
					Admit.smethod_25(Admit.smethod_24((Control)(object)GroupBox1), (Control)(object)Label2);
					num = ((int)num2 * -2045251741) ^ -1133653860;
					continue;
				case 33u:
					Admit.smethod_17((Control)(object)ClearBtn, Admit.smethod_16("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -40095725) ^ 0x46CE89C2;
					continue;
				case 32u:
					Admit.smethod_19((Control)(object)AdmitDetailsBox, "AdmitDetailsBox");
					Admit.smethod_20((Control)(object)AdmitDetailsBox, new Size(408, 255));
					num = (int)(num2 * 1302456700) ^ -1301613254;
					continue;
				case 31u:
					Admit.smethod_18((Control)(object)Label8, new Point(18, 34));
					num = (int)((num2 * 1521856895) ^ 0xB7D7857);
					continue;
				case 30u:
					FeesTxt = Admit.smethod_6();
					num = ((int)num2 * -1762452691) ^ 0x57B208C2;
					continue;
				case 29u:
					num = ((int)num2 * -1677001911) ^ 0x3936598E;
					continue;
				case 28u:
					num = (int)((num2 * 1712706040) ^ 0x88884A4);
					continue;
				case 27u:
					Admit.smethod_21((Control)(object)AddressTxt, 7);
					num = ((int)num2 * -261140269) ^ 0x7F37EFEC;
					continue;
				case 26u:
					Admit.smethod_21((Control)(object)Label8, 1);
					num = (int)(num2 * 1477532336) ^ -1612585596;
					continue;
				case 25u:
					Admit.smethod_18((Control)(object)Label13, new Point(18, 157));
					Admit.smethod_19((Control)(object)Label13, "Label13");
					num = ((int)num2 * -1283890523) ^ -1703550095;
					continue;
				case 24u:
					Admit.smethod_20((Control)(object)Label7, new Size(105, 26));
					num = (int)((num2 * 1278144692) ^ 0x73D6F400);
					continue;
				case 23u:
					num = ((int)num2 * -474420892) ^ -218778651;
					continue;
				case 22u:
					num = (int)(num2 * 1709582381) ^ -522385145;
					continue;
				case 21u:
					Admit.smethod_20((Control)(object)RoomTypeTxt, new Size(181, 27));
					num = ((int)num2 * -307787596) ^ 0x2850F410;
					continue;
				case 20u:
					num = (int)(num2 * 80893638) ^ -1731399165;
					continue;
				case 19u:
					MobileTxt = Admit.smethod_6();
					NameSTxt = Admit.smethod_6();
					num = (int)(num2 * 1308153654) ^ -257022724;
					continue;
				case 18u:
					Admit.smethod_18((Control)(object)NameSTxt, new Point(120, 44));
					num = ((int)num2 * -337002596) ^ -994494600;
					continue;
				case 17u:
					Admit.smethod_18((Control)(object)Label9, new Point(18, 71));
					Admit.smethod_19((Control)(object)Label9, "Label9");
					num = (int)(num2 * 1694087132) ^ -1073597503;
					continue;
				case 16u:
					Admit.smethod_38((TextBoxBase)(object)DateOut1Txt, bool_0: true);
					num = (int)((num2 * 807644606) ^ 0x46FB9313);
					continue;
				case 15u:
					Admit.smethod_23(Label11, (ContentAlignment)32);
					num = ((int)num2 * -206786017) ^ 0x740EA9BD;
					continue;
				case 14u:
					SearchResultGrid = Admit.smethod_7();
					num = (int)((num2 * 1702921866) ^ 0x7996450B);
					continue;
				case 13u:
					Admit.smethod_18((Control)(object)StatusTxt, new Point(266, 198));
					Admit.smethod_19((Control)(object)StatusTxt, "StatusTxt");
					num = ((int)num2 * -182560945) ^ -1909782377;
					continue;
				case 12u:
					Admit.smethod_20((Control)(object)ClearBtn, new Size(97, 37));
					num = ((int)num2 * -892080238) ^ -378227112;
					continue;
				case 11u:
					num = (int)(num2 * 1000862349) ^ -270696708;
					continue;
				case 10u:
					num = (int)(num2 * 270321341) ^ -167432991;
					continue;
				case 9u:
					num = ((int)num2 * -1828467042) ^ -2051681492;
					continue;
				case 8u:
					Admit.smethod_12((Control)(object)AdmitDetailsBox);
					Admit.smethod_13((ISupportInitialize)PictureBox1);
					num = (int)((num2 * 1588119735) ^ 0x61CA9715);
					continue;
				case 7u:
					Admit.smethod_20((Control)(object)Label3, new Size(77, 28));
					num = ((int)num2 * -1552924469) ^ -313676413;
					continue;
				case 6u:
					Admit.smethod_19((Control)(object)Label3, "Label3");
					num = ((int)num2 * -66458724) ^ 0x7D6AAB37;
					continue;
				case 5u:
					num = (int)(num2 * 1971724714) ^ -567995034;
					continue;
				case 4u:
					Admit.smethod_20((Control)(object)PrintBtn, new Size(101, 37));
					num = ((int)num2 * -844610662) ^ -767506535;
					continue;
				case 3u:
					Admit.smethod_20((Control)(object)NameTxt, new Size(326, 28));
					num = ((int)num2 * -173513529) ^ 0x551E3930;
					continue;
				case 2u:
					num = ((int)num2 * -437194330) ^ 0x56EBD934;
					continue;
				case 1u:
					Admit.smethod_25(Admit.smethod_24((Control)(object)GroupBox1), (Control)(object)Label3);
					Admit.smethod_25(Admit.smethod_24((Control)(object)GroupBox1), (Control)(object)MobileTxt);
					num = ((int)num2 * -811289670) ^ 0x683EAE1E;
					continue;
				case 0u:
					Admit.smethod_21((Control)(object)Label7, 3);
					num = (int)((num2 * 90850507) ^ 0x636FC89B);
					continue;
				default:
					return;
				case 296u:
					break;
				case 162u:
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
			int num = -1327974921;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA4251E06u) % 7u)
				{
				case 6u:
					Admit.smethod_70(Admit.smethod_42(DateInTxt), (object)Admit.smethod_69((object)Admit.smethod_68(), "dd-MM-yyyy"));
					num = (int)(num2 * 1508081355) ^ -698298534;
					continue;
				case 3u:
					Add_Rooms();
					num = (int)(num2 * 501581767) ^ -1972401082;
					continue;
				case 2u:
					HideItemsOnForm();
					num = (int)(num2 * 2138779798) ^ -628592647;
					continue;
				case 1u:
					Admit.smethod_70(Admit.smethod_42(DateOutTxt), (object)Admit.smethod_68());
					Admit.smethod_71(Admit.smethod_42(RoomNoTxt));
					num = (int)((num2 * 2020535671) ^ 0x4934E37F);
					continue;
				case 0u:
					num = (int)(num2 * 1237310392) ^ -1336263418;
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

	private void SearchBtn_Click(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected I4, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected I4, but got Unknown
		//IL_02ac: Incompatible stack heights: 0 vs 1
		//IL_02c1: Incompatible stack heights: 0 vs 1
		//IL_02d1: Incompatible stack heights: 0 vs 1
		//IL_02d8: Incompatible stack heights: 0 vs 1
		HideItemsOnForm();
		bool flag = !MyProject.Forms.Form1.Name_Validation(Admit.smethod_73(Admit.smethod_72(NameSTxt))) | !MyProject.Forms.Form1.Mobile_Validator(Admit.smethod_73(Admit.smethod_72(MobileTxt)));
		DataTable dataTable = default(DataTable);
		string string_ = default(string);
		while (true)
		{
			int num = -1020666707;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCDBE37DFu) % 8u)
				{
				case 7u:
					Admit.smethod_74("No Results Found");
					num = (int)(num2 * 1829568911) ^ -669554617;
					continue;
				case 6u:
					Admit.smethod_78(myconnection);
					num = (int)((num2 * 242992393) ^ 0x61446D32);
					continue;
				case 4u:
					dataTable = Admit.smethod_77();
					num = ((int)num2 * -1964482529) ^ 0x5E452BB5;
					continue;
				case 2u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = -494199585;
						num7 = -494199585;
					}
					else
					{
						num6 = -602708368;
						num7 = -602708368;
					}
					num = num6 ^ (int)(num2 * 1665736772);
					continue;
				}
				case 0u:
					Admit.smethod_75();
					string_ = Admit.smethod_76(new string[5]
					{
						"Select * From [Patient] Where [Name] Like '%",
						Admit.smethod_73(Admit.smethod_72(NameSTxt)),
						"%' And [Mobile] Like '%",
						Admit.smethod_72(MobileTxt),
						"%';"
					});
					num = -473282293;
					continue;
				case 5u:
					break;
				default:
					try
					{
						OleDbDataAdapter dbDataAdapter_ = Admit.smethod_79(string_, myconnection);
						Admit.smethod_80((DbDataAdapter)(object)dbDataAdapter_, dataTable);
						Admit.smethod_81(SearchResultGrid, (object)dataTable);
						while (true)
						{
							int num3 = -1643868840;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xCDBE37DFu) % 9u)
								{
								case 8u:
									Admit.smethod_83(myconnection);
									num3 = (int)((num2 * 1126352088) ^ 0x707C70FE);
									continue;
								case 5u:
								{
									int num4;
									int num5;
									if (Admit.smethod_82(SearchResultGrid) == 1)
									{
										num4 = 22457026;
										num5 = 22457026;
									}
									else
									{
										num4 = 1350159575;
										num5 = 1350159575;
									}
									num3 = num4 ^ ((int)num2 * -916155903);
									continue;
								}
								case 4u:
									Admit.smethod_37((Control)(object)SearchResultGrid, bool_0: true);
									num3 = -509355460;
									continue;
								case 3u:
									Admit.smethod_74("No Result Found");
									num3 = (int)((num2 * 734652743) ^ 0x3ED78D8E);
									continue;
								case 1u:
									Admit.smethod_83(myconnection);
									num3 = ((int)num2 * -1480503196) ^ 0x4FC6482F;
									continue;
								case 0u:
									num3 = (int)((num2 * 261229430) ^ 0x2E0F51B3);
									continue;
								default:
									return;
								case 2u:
									break;
								case 6u:
									return;
								case 7u:
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
							_ = -732164496;
							while (true)
							{
								_003F val = /*Error near IL_0273: Stack underflow*/^ -843171873;
								num2 = (uint)(int)val;
								switch (val % 5)
								{
								default:
									return;
								case 3:
									Admit.smethod_83(myconnection);
									_ = (num2 * 1087043563) ^ 0x9AADE78Du;
									continue;
								case 1:
									Admit.smethod_85();
									_ = (num2 * 1125188893) ^ 0x39F6C2B4;
									continue;
								case 0:
									_ = (num2 * 1125710215) ^ 0x417E4FE9;
									continue;
								case 4:
									break;
								case 2:
									return;
								}
								break;
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

	private void SaveBtn_Click(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -1319891277;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9EFF58F0u) % 7u)
				{
				case 6u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -696512523;
						num4 = -696512523;
					}
					else
					{
						num3 = -1995761702;
						num4 = -1995761702;
					}
					num = num3 ^ ((int)num2 * -1688513079);
					continue;
				}
				case 3u:
					Admit.smethod_75();
					num = -708624288;
					continue;
				case 2u:
					flag = !Validate_Print_Data();
					num = (int)((num2 * 1809564402) ^ 0x1BEF21F);
					continue;
				case 1u:
					performQueryStatement();
					num = (int)((num2 * 2106656147) ^ 0x421ED090);
					continue;
				case 0u:
					num = (int)((num2 * 301551183) ^ 0x554F8725);
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

	private bool HideItemsOnForm()
	{
		Admit.smethod_37((Control)(object)SearchResultGrid, bool_0: false);
		bool result = default(bool);
		while (true)
		{
			int num = 1206911050;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x12669CD2u) % 13u)
				{
				case 11u:
					num = (int)(num2 * 1994203996) ^ -1595530920;
					continue;
				case 10u:
					Admit.smethod_37((Control)(object)ClearBtn, bool_0: false);
					num = ((int)num2 * -1668259795) ^ -1937962597;
					continue;
				case 9u:
					Admit.smethod_37((Control)(object)PatientInfoBox, bool_0: false);
					num = (int)(num2 * 760851571) ^ -209272207;
					continue;
				case 8u:
					Admit.smethod_37((Control)(object)PrintBtn, bool_0: false);
					num = (int)(num2 * 737982662) ^ -569009311;
					continue;
				case 6u:
					Admit.smethod_37((Control)(object)HistoryBtn, bool_0: false);
					num = (int)(num2 * 1912335305) ^ -910342093;
					continue;
				case 5u:
					Admit.smethod_37((Control)(object)AdmitDetailsBox, bool_0: false);
					num = ((int)num2 * -651584954) ^ 0x6AF0475;
					continue;
				case 4u:
					result = true;
					num = (int)(num2 * 695521332) ^ -313222124;
					continue;
				case 3u:
					num = ((int)num2 * -473279019) ^ -20152194;
					continue;
				case 2u:
					Admit.smethod_37((Control)(object)SaveBtn, bool_0: false);
					num = (int)(num2 * 905900070) ^ -179683568;
					continue;
				case 1u:
					num = (int)((num2 * 444515169) ^ 0x40AF5E2);
					continue;
				case 0u:
					Admit.smethod_37((Control)(object)AdmitDischargeBtn, bool_0: false);
					num = (int)((num2 * 1830742390) ^ 0x443890F9);
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

	private string performQueryStatement()
	{
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected I4, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected I4, but got Unknown
		//IL_02d7: Incompatible stack heights: 0 vs 1
		//IL_02f2: Incompatible stack heights: 0 vs 1
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Incompatible stack heights: 0 vs 1
		//IL_031e: Incompatible stack heights: 0 vs 1
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected I4, but got Unknown
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected I4, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Incompatible stack heights: 0 vs 1
		//IL_04a3: Incompatible stack heights: 0 vs 1
		//IL_04aa: Incompatible stack heights: 0 vs 1
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Expected I4, but got Unknown
		//IL_06bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Expected I4, but got Unknown
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fc: Incompatible stack heights: 0 vs 1
		//IL_0703: Incompatible stack heights: 0 vs 1
		bool flag = default(bool);
		string text = default(string);
		OleDbCommand val = default(OleDbCommand);
		DateTime dateTime_ = default(DateTime);
		string result = default(string);
		while (true)
		{
			int num = 2076897423;
			while (true)
			{
				int num6;
				uint num2;
				switch ((num2 = (uint)num ^ 0x393812D3u) % 5u)
				{
				case 2u:
					if (flag)
					{
						num = (int)(num2 * 1993244656) ^ -1517486888;
						continue;
					}
					while ((Admit.smethod_87(Admit.smethod_72(DateIn1Txt), "", bool_0: false) != 0) & (Admit.smethod_87(Admit.smethod_72(DateOut1Txt), "", bool_0: false) == 0))
					{
						int num4 = 1274447444;
						while (true)
						{
							switch ((num2 = (uint)num4 ^ 0x393812D3u) % 5u)
							{
							case 4u:
								num4 = 191515901;
								continue;
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
								num4 = ((int)num2 * -2039421468) ^ -1909997743;
								continue;
							case 1u:
								Admit.smethod_78(myconnection);
								num4 = (int)(num2 * 1215045354) ^ -95788186;
								continue;
							case 2u:
								break;
							default:
								goto IL_01bd;
							}
							break;
						}
					}
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
					try
					{
						val = Admit.smethod_88(text, myconnection);
						Admit.smethod_96(val);
						Admit.smethod_97((Component)(object)val);
						while (true)
						{
							IL_042c:
							int num5 = 1021046175;
							while (true)
							{
								switch ((num2 = (uint)num5 ^ 0x393812D3u) % 5u)
								{
								case 3u:
									num5 = (int)(num2 * 309196355) ^ -945737030;
									continue;
								case 2u:
									Admit.smethod_83(myconnection);
									num5 = (int)((num2 * 251416499) ^ 0x4AC1E2AB);
									continue;
								case 1u:
									Admit.smethod_74("Successfully Updated Details");
									num5 = ((int)num2 * -1764213975) ^ -1170272772;
									continue;
								case 0u:
									break;
								default:
									UpdateTable();
									goto end_IL_0406;
								}
								goto IL_042c;
								continue;
								end_IL_0406:
								break;
							}
							break;
						}
					}
					catch (Exception exception_2)
					{
						Admit.smethod_84(exception_2);
						Admit.smethod_83(myconnection);
						while (true)
						{
							IL_04a5:
							_ = 156401618;
							while (true)
							{
								_003F val3 = /*Error near IL_0459: Stack underflow*/^ 0x393812D3;
								num2 = (uint)(int)val3;
								switch (val3 % 4)
								{
								case 2:
									Admit.smethod_98("Cannot proceed with the request!", "INVALID REQUEST");
									_ = (num2 * 1637125343) ^ 0x94EC553Au;
									continue;
								case 1:
									_ = (num2 * 1775563847) ^ 0xDE199A3Au;
									continue;
								case 0:
									break;
								default:
									Admit.smethod_85();
									goto end_IL_0453;
								}
								goto IL_04a5;
								continue;
								end_IL_0453:
								break;
							}
							break;
						}
					}
					goto IL_070c;
				case 1u:
					val = Admit.smethod_75();
					dateTime_ = Admit.smethod_86(Admit.smethod_69((object)DateTime.Now, "dd-MM-yyyy"));
					flag = Admit.smethod_87(Admit.smethod_72(DateIn1Txt), "", bool_0: false) == 0;
					num = (int)((num2 * 403403446) ^ 0x33512CCE);
					continue;
				case 0u:
					text = "Insert Into [Admit-Discharge] ([DateIn],[PID],[Fee Status],[Room No],[Room type]) Values (?,?,?,?,?);";
					Admit.smethod_78(myconnection);
					num = (int)((num2 * 1567743533) ^ 0x5193A972);
					continue;
				case 3u:
					break;
				default:
					{
						try
						{
							while (true)
							{
								IL_0699:
								int num3 = 225456636;
								while (true)
								{
									switch ((num2 = (uint)num3 ^ 0x393812D3u) % 11u)
									{
									case 10u:
										Admit.smethod_74("Successfully Updated Details");
										num3 = ((int)num2 * -1296993855) ^ -1788236347;
										continue;
									case 9u:
										Admit.smethod_97((Component)(object)val);
										num3 = (int)(num2 * 503666258) ^ -1312215222;
										continue;
									case 8u:
										Update_Rooms(Admit.smethod_94(RoomNoTxt), "No");
										num3 = (int)(num2 * 2122600095) ^ -524170881;
										continue;
									case 7u:
										Admit.smethod_96(val);
										num3 = (int)((num2 * 1874315640) ^ 0x1484A735);
										continue;
									case 6u:
										Admit.smethod_92(Admit.smethod_89(val), Admit.smethod_91("Fee Status", (object)Admit.smethod_94(StatusTxt)));
										Admit.smethod_92(Admit.smethod_89(val), Admit.smethod_91("Room No", (object)Admit.smethod_93(Admit.smethod_94(RoomNoTxt))));
										num3 = ((int)num2 * -1533864968) ^ -1723335135;
										continue;
									case 5u:
										Admit.smethod_92(Admit.smethod_89(val), Admit.smethod_91("DateIn", (object)Admit.smethod_90(dateTime_)));
										Admit.smethod_92(Admit.smethod_89(val), Admit.smethod_91("PID", (object)Admit.smethod_93(Admit.smethod_72(PIDTxt))));
										num3 = ((int)num2 * -158739292) ^ -1895834637;
										continue;
									case 4u:
										val = Admit.smethod_88(text, myconnection);
										num3 = ((int)num2 * -71945543) ^ -1519202739;
										continue;
									case 3u:
										Admit.smethod_83(myconnection);
										num3 = ((int)num2 * -1257974473) ^ -1037071314;
										continue;
									case 2u:
										Admit.smethod_92(Admit.smethod_89(val), Admit.smethod_91("Room Type", (object)Admit.smethod_95(Admit.smethod_94(RoomTypeTxt))));
										num3 = (int)(num2 * 2067308357) ^ -837760114;
										continue;
									case 0u:
										break;
									default:
										UpdateTable();
										goto end_IL_065a;
									}
									goto IL_0699;
									continue;
									end_IL_065a:
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
								IL_06fe:
								_ = 1350568297;
								while (true)
								{
									_003F val2 = /*Error near IL_06bb: Stack underflow*/^ 0x393812D3;
									num2 = (uint)(int)val2;
									switch (val2 % 3)
									{
									case 1:
										Admit.smethod_83(myconnection);
										Admit.smethod_98("Cannot proceed with the request!", "INVALID REQUEST");
										_ = ((int)num2 * -719232842) ^ -335610764;
										continue;
									case 0:
										break;
									default:
										Admit.smethod_85();
										goto end_IL_06b5;
									}
									goto IL_06fe;
									continue;
									end_IL_06b5:
									break;
								}
								break;
							}
						}
						goto IL_0743;
					}
					IL_0711:
					while (true)
					{
						switch ((num2 = (uint)num6 ^ 0x393812D3u) % 4u)
						{
						case 0u:
							break;
						case 2u:
							num6 = (int)(num2 * 1481290031) ^ -1643102780;
							continue;
						case 1u:
							goto IL_0743;
						default:
							return result;
						}
						break;
					}
					goto IL_070c;
					IL_070c:
					num6 = 1518000373;
					goto IL_0711;
					IL_01bd:
					try
					{
						while (true)
						{
							IL_0287:
							int num7 = 2117399989;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0x393812D3u) % 7u)
								{
								case 6u:
									Update_Rooms(Admit.smethod_72(RoomNo1Txt), "Yes");
									num7 = ((int)num2 * -437169228) ^ 0x6288EF06;
									continue;
								case 4u:
									Admit.smethod_96(val);
									Admit.smethod_97((Component)(object)val);
									num7 = ((int)num2 * -1798939026) ^ -2122094699;
									continue;
								case 3u:
									Admit.smethod_83(myconnection);
									num7 = (int)((num2 * 1197432589) ^ 0x4D8D336);
									continue;
								case 2u:
									Admit.smethod_74("Successfully Updated Details");
									num7 = (int)(num2 * 2011586276) ^ -2118960542;
									continue;
								case 1u:
									val = Admit.smethod_88(text, myconnection);
									num7 = ((int)num2 * -1763142267) ^ -748818798;
									continue;
								case 0u:
									break;
								default:
									UpdateTable();
									goto end_IL_0259;
								}
								goto IL_0287;
								continue;
								end_IL_0259:
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
							IL_0319:
							_ = 247562354;
							while (true)
							{
								_003F val4 = /*Error near IL_02a9: Stack underflow*/^ 0x393812D3;
								num2 = (uint)(int)val4;
								switch (val4 % 5)
								{
								default:
									goto end_IL_02a3;
								case 4:
									_ = (num2 * 203427232) ^ 0xA8B21244u;
									continue;
								case 1:
									Admit.smethod_83(myconnection);
									_ = (num2 * 1260866246) ^ 0x866F753Du;
									continue;
								case 0:
									Admit.smethod_98("Cannot proceed with the request!", "INVALID REQUEST");
									Admit.smethod_85();
									_ = ((int)num2 * -786264571) ^ -1891621450;
									continue;
								case 2:
									break;
								case 3:
									goto end_IL_02a3;
								}
								goto IL_0319;
								continue;
								end_IL_02a3:
								break;
							}
							break;
						}
					}
					num2 = 961601537u;
					goto IL_0743;
					IL_0743:
					result = text;
					num6 = 783013616;
					goto IL_0711;
				}
				break;
			}
		}
	}

	private void SearchResultGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected I4, but got Unknown
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected I4, but got Unknown
		//IL_048a: Incompatible stack heights: 0 vs 1
		//IL_0491: Incompatible stack heights: 0 vs 1
		try
		{
			Admit.smethod_106(PIDTxt, Admit.smethod_105(Admit.smethod_104(Admit.smethod_103(Admit.smethod_102(Admit.smethod_101(Admit.smethod_99(SearchResultGrid), Admit.smethod_100(e))), 0))));
			while (true)
			{
				int num = 1010486368;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2FFBFF5Cu) % 28u)
					{
					case 27u:
						num = ((int)num2 * -132780467) ^ -1533588523;
						continue;
					case 26u:
						Admit.smethod_37((Control)(object)SaveBtn, bool_0: false);
						num = (int)((num2 * 448543235) ^ 0x51CE132C);
						continue;
					case 25u:
						Admit.smethod_107(StatusTxt, -1);
						num = ((int)num2 * -122359523) ^ -245656909;
						continue;
					case 24u:
						Admit.smethod_108((TextBoxBase)(object)DateOut1Txt);
						num = (int)(num2 * 1103675480) ^ -158660575;
						continue;
					case 23u:
						Admit.smethod_37((Control)(object)PrintBtn, bool_0: false);
						num = ((int)num2 * -372864657) ^ 0x9FE8DDE;
						continue;
					case 22u:
						Admit.smethod_106(NameTxt, Admit.smethod_105(Admit.smethod_104(Admit.smethod_103(Admit.smethod_102(Admit.smethod_101(Admit.smethod_99(SearchResultGrid), Admit.smethod_100(e))), 1))));
						num = ((int)num2 * -1119935257) ^ 0x564DBCBA;
						continue;
					case 21u:
						Admit.smethod_106(MobileSTxt, Admit.smethod_105(Admit.smethod_104(Admit.smethod_103(Admit.smethod_102(Admit.smethod_101(Admit.smethod_99(SearchResultGrid), Admit.smethod_100(e))), 4))));
						num = (int)(num2 * 1269045865) ^ -733693504;
						continue;
					case 20u:
						Admit.smethod_37((Control)(object)HistoryBtn, bool_0: true);
						num = ((int)num2 * -1985641179) ^ 0x64F1E1AD;
						continue;
					case 19u:
						Admit.smethod_108((TextBoxBase)(object)FeesTxt);
						num = (int)(num2 * 1535084123) ^ -1639700491;
						continue;
					case 18u:
						Admit.smethod_107(RoomNoTxt, -1);
						num = (int)((num2 * 1914559511) ^ 0x79C5E555);
						continue;
					case 17u:
						num = ((int)num2 * -268711391) ^ 0x5711B79B;
						continue;
					case 16u:
						Admit.smethod_106(GenderTxt, Admit.smethod_105(Admit.smethod_104(Admit.smethod_103(Admit.smethod_102(Admit.smethod_101(Admit.smethod_99(SearchResultGrid), Admit.smethod_100(e))), 3))));
						num = ((int)num2 * -1670054624) ^ -1613419183;
						continue;
					case 15u:
						Admit.smethod_106(AgeTxt, Admit.smethod_105(Admit.smethod_104(Admit.smethod_103(Admit.smethod_102(Admit.smethod_101(Admit.smethod_99(SearchResultGrid), Admit.smethod_100(e))), 2))));
						num = (int)((num2 * 508658713) ^ 0x34E2EEA3);
						continue;
					case 13u:
						num = ((int)num2 * -790965043) ^ -173167065;
						continue;
					case 12u:
						num = ((int)num2 * -1764858813) ^ -1864924737;
						continue;
					case 11u:
						num = (int)((num2 * 985422413) ^ 0x63A3E6DC);
						continue;
					case 10u:
						Admit.smethod_37((Control)(object)ClearBtn, bool_0: false);
						num = ((int)num2 * -980278376) ^ -251157252;
						continue;
					case 8u:
						num = (int)(num2 * 1808178850) ^ -402397601;
						continue;
					case 7u:
						Admit.smethod_107(RoomTypeTxt, -1);
						num = ((int)num2 * -1708976942) ^ 0x6F4B4D1D;
						continue;
					case 6u:
						num = ((int)num2 * -1140425229) ^ -995792097;
						continue;
					case 5u:
						Admit.smethod_107(DateInTxt, -1);
						Admit.smethod_107(DateOutTxt, -1);
						num = ((int)num2 * -1596859484) ^ 0x2288A8A;
						continue;
					case 4u:
						num = ((int)num2 * -699555527) ^ 0x2FEB516E;
						continue;
					case 3u:
						Admit.smethod_37((Control)(object)PatientInfoBox, bool_0: true);
						num = (int)((num2 * 1319284304) ^ 0x13E1A365);
						continue;
					case 2u:
						Admit.smethod_106(AddressTxt, Admit.smethod_105(Admit.smethod_104(Admit.smethod_103(Admit.smethod_102(Admit.smethod_101(Admit.smethod_99(SearchResultGrid), Admit.smethod_100(e))), 5))));
						num = ((int)num2 * -414553110) ^ 0x6989007C;
						continue;
					case 1u:
						Admit.smethod_37((Control)(object)AdmitDischargeBtn, bool_0: true);
						Admit.smethod_37((Control)(object)AdmitDetailsBox, bool_0: false);
						num = (int)((num2 * 587975969) ^ 0x57C976A6);
						continue;
					case 0u:
						Admit.smethod_108((TextBoxBase)(object)DateIn1Txt);
						num = ((int)num2 * -526027443) ^ -1991620184;
						continue;
					default:
						return;
					case 9u:
						break;
					case 14u:
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
				_ = 1018974446;
				while (true)
				{
					_003F val = /*Error near IL_0461: Stack underflow*/^ 0x2FFBFF5C;
					uint num2 = (uint)(int)val;
					switch (val % 3)
					{
					default:
						return;
					case 2:
						Admit.smethod_85();
						_ = (num2 * 764611745) ^ 0xD3D1AC4Fu;
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
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected I4, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected I4, but got Unknown
		//IL_0240: Incompatible stack heights: 0 vs 1
		//IL_0247: Incompatible stack heights: 0 vs 1
		string string_ = default(string);
		DataTable dataTable = default(DataTable);
		OleDbDataAdapter dbDataAdapter_ = default(OleDbDataAdapter);
		bool result = default(bool);
		while (true)
		{
			int num = 1891104218;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7D49A197u) % 4u)
				{
				case 1u:
					Admit.smethod_75();
					num = ((int)num2 * -482819628) ^ 0x27282CCF;
					continue;
				case 0u:
					string_ = Admit.smethod_76(new string[5]
					{
						"Select * From [Patient] Where [Name] Like '%",
						Admit.smethod_73(Admit.smethod_72(NameSTxt)),
						"%' And [Mobile] Like '%",
						Admit.smethod_72(MobileTxt),
						"%';"
					});
					dataTable = Admit.smethod_77();
					num = (int)((num2 * 1956259396) ^ 0x6B4C9205);
					continue;
				case 3u:
					break;
				default:
					Admit.smethod_78(myconnection);
					try
					{
						while (true)
						{
							IL_01e4:
							int num3 = 1508103317;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x7D49A197u) % 12u)
								{
								case 10u:
									dbDataAdapter_ = Admit.smethod_79(string_, myconnection);
									num3 = (int)((num2 * 112532981) ^ 0x17CEE897);
									continue;
								case 9u:
									num3 = (int)((num2 * 725410757) ^ 0x3DE6C1AC);
									continue;
								case 8u:
									num3 = (int)((num2 * 231337573) ^ 0x5E731E20);
									continue;
								case 7u:
									num3 = 1014446830;
									continue;
								case 5u:
									Admit.smethod_83(myconnection);
									num3 = (int)(num2 * 1401462494) ^ -1364010391;
									continue;
								case 3u:
									result = false;
									num3 = ((int)num2 * -1051320410) ^ 0x2BAD82DE;
									continue;
								case 2u:
									Admit.smethod_80((DbDataAdapter)(object)dbDataAdapter_, dataTable);
									Admit.smethod_81(SearchResultGrid, (object)dataTable);
									num3 = (int)(num2 * 577242838) ^ -754501857;
									continue;
								case 1u:
									Admit.smethod_37((Control)(object)SearchResultGrid, bool_0: true);
									num3 = ((int)num2 * -1096449163) ^ -1847922481;
									continue;
								case 0u:
								{
									int num4;
									int num5;
									if (Admit.smethod_82(SearchResultGrid) == 1)
									{
										num4 = 1481268398;
										num5 = 1481268398;
									}
									else
									{
										num4 = 2062377136;
										num5 = 2062377136;
									}
									num3 = num4 ^ (int)(num2 * 538345786);
									continue;
								}
								case 4u:
									break;
								default:
									Admit.smethod_83(myconnection);
									goto end_IL_01a1;
								case 11u:
									return result;
								}
								goto IL_01e4;
								continue;
								end_IL_01a1:
								break;
							}
							break;
						}
					}
					catch (Exception exception_)
					{
						Admit.smethod_84(exception_);
						Admit.smethod_83(myconnection);
						while (true)
						{
							IL_0242:
							_ = 1311588809;
							while (true)
							{
								_003F val = /*Error near IL_021a: Stack underflow*/^ 0x7D49A197;
								num2 = (uint)(int)val;
								switch (val % 3)
								{
								case 1:
									_ = ((int)num2 * -1469094896) ^ -1283143879;
									continue;
								case 0:
									break;
								default:
									Admit.smethod_85();
									goto end_IL_0214;
								}
								goto IL_0242;
								continue;
								end_IL_0214:
								break;
							}
							break;
						}
					}
					while (true)
					{
						int num6 = 766418640;
						while (true)
						{
							switch ((num2 = (uint)num6 ^ 0x7D49A197u) % 3u)
							{
							case 1u:
								goto IL_0250;
							case 2u:
								break;
							default:
								return result;
							}
							break;
							IL_0250:
							result = true;
							num6 = (int)((num2 * 1819618179) ^ 0x5D51EA77);
						}
					}
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
			int num = -859759668;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF127157Au) % 3u)
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
				num = ((int)num2 * -1037002670) ^ -1817818832;
			}
		}
	}

	private bool ClearPatientInfo()
	{
		Admit.smethod_108((TextBoxBase)(object)PIDTxt);
		bool result = default(bool);
		while (true)
		{
			int num = 278161007;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4548D76Eu) % 9u)
				{
				case 8u:
					Admit.smethod_108((TextBoxBase)(object)GenderTxt);
					result = true;
					num = ((int)num2 * -925931606) ^ 0x3DD0A217;
					continue;
				case 7u:
					num = (int)(num2 * 1712197125) ^ -190638936;
					continue;
				case 6u:
					Admit.smethod_108((TextBoxBase)(object)NameTxt);
					num = (int)((num2 * 925656864) ^ 0x793D4E2);
					continue;
				case 5u:
					Admit.smethod_108((TextBoxBase)(object)MobileSTxt);
					Admit.smethod_108((TextBoxBase)(object)AgeTxt);
					num = (int)((num2 * 607992299) ^ 0x403A2CD9);
					continue;
				case 3u:
					num = ((int)num2 * -2147422196) ^ 0x987C9EC;
					continue;
				case 2u:
					Admit.smethod_108((TextBoxBase)(object)AddressTxt);
					num = (int)((num2 * 1506986564) ^ 0x49A58B35);
					continue;
				case 1u:
					num = ((int)num2 * -554019971) ^ -2065865944;
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

	private bool ClearAdmitDetails()
	{
		Admit.smethod_107(RoomNoTxt, -1);
		bool result = default(bool);
		while (true)
		{
			int num = -680617518;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA157E606u) % 12u)
				{
				case 11u:
					Admit.smethod_108((TextBoxBase)(object)FeesTxt);
					num = (int)((num2 * 70523428) ^ 0x5FB718DD);
					continue;
				case 10u:
					Admit.smethod_107(DateOutTxt, -1);
					Admit.smethod_107(StatusTxt, -1);
					num = (int)((num2 * 898246740) ^ 0x8992229);
					continue;
				case 7u:
					Admit.smethod_108((TextBoxBase)(object)DateIn1Txt);
					Admit.smethod_108((TextBoxBase)(object)DateOut1Txt);
					num = ((int)num2 * -1559660997) ^ 0x609E400A;
					continue;
				case 6u:
					num = (int)((num2 * 451482920) ^ 0x437CCD4A);
					continue;
				case 5u:
					Admit.smethod_108((TextBoxBase)(object)RoomNo1Txt);
					num = (int)((num2 * 629850585) ^ 0x5B70FE2B);
					continue;
				case 4u:
					Admit.smethod_107(RoomTypeTxt, -1);
					num = (int)((num2 * 2144236128) ^ 0x4D707E6F);
					continue;
				case 3u:
					result = true;
					num = ((int)num2 * -1407572485) ^ 0x4E7B52E5;
					continue;
				case 2u:
					Admit.smethod_108((TextBoxBase)(object)RoomType1Txt);
					num = (int)(num2 * 14616386) ^ -1882604695;
					continue;
				case 1u:
					Admit.smethod_107(DateInTxt, -1);
					num = ((int)num2 * -226469876) ^ -1864788704;
					continue;
				case 0u:
					num = ((int)num2 * -1668207904) ^ -1251026532;
					continue;
				case 9u:
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
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		bool flag = Admit.smethod_87(Admit.smethod_72(PIDTxt), "", bool_0: false) == 0;
		while (true)
		{
			int num = -547275475;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCC700A2Cu) % 14u)
				{
				case 13u:
					num = -1757191138;
					continue;
				case 12u:
					num = ((int)num2 * -958460453) ^ -831670016;
					continue;
				case 11u:
					Admit.smethod_111(PrintDialog1, Admit.smethod_110(PrintDocument1));
					Admit.smethod_112(PrintDialog1, bool_0: true);
					num = (int)(num2 * 445380313) ^ -229952151;
					continue;
				case 10u:
				{
					int num4;
					int num5;
					if ((int)Admit.smethod_113((CommonDialog)(object)PrintDialog1) != 1)
					{
						num4 = 226066739;
						num5 = 226066739;
					}
					else
					{
						num4 = 883439359;
						num5 = 883439359;
					}
					num = num4 ^ (int)(num2 * 586829595);
					continue;
				}
				case 8u:
					num = ((int)num2 * -823937150) ^ 0x7C203731;
					continue;
				case 7u:
					Admit.smethod_115(PrintDocument1, Admit.smethod_114(PrintDialog1));
					num = (int)(num2 * 941888289) ^ -111548383;
					continue;
				case 6u:
					num = (int)((num2 * 530410871) ^ 0x19FEF88C);
					continue;
				case 5u:
					Admit.smethod_116(PrintDocument1);
					num = (int)(num2 * 1853501520) ^ -854157081;
					continue;
				case 3u:
					Admit.smethod_109(PrintDialog1, PrintDocument1);
					num = -1880406371;
					continue;
				case 2u:
					Admit.smethod_74("No Patient to Print");
					num = (int)((num2 * 2105306012) ^ 0x6DA0CC72);
					continue;
				case 1u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -1766810593;
						num7 = -1766810593;
					}
					else
					{
						num6 = -2050060623;
						num7 = -2050060623;
					}
					num = num6 ^ (int)(num2 * 1458278155);
					continue;
				}
				case 0u:
				{
					int num3;
					if (!Validate_Print_Data())
					{
						num = -785109354;
						num3 = -785109354;
					}
					else
					{
						num = -192251223;
						num3 = -192251223;
					}
					continue;
				}
				default:
					return;
				case 9u:
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
		Font font_2 = default(Font);
		string string_ = default(string);
		string string_2 = default(string);
		while (true)
		{
			int num = 746510748;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6E258A12u) % 20u)
				{
				case 19u:
					num = (int)((num2 * 1553918307) ^ 0x4E248D71);
					continue;
				case 18u:
					num = (int)((num2 * 1527687600) ^ 0x7794622A);
					continue;
				case 17u:
					Admit.smethod_121(Admit.smethod_119(e), Admit.smethod_66("Name - ", Admit.smethod_72(NameTxt)) ?? "", font_, Admit.smethod_120(), 100f, 150f);
					num = 983017129;
					continue;
				case 16u:
					font_2 = Admit.smethod_118("Times New Roman", 20f);
					num = 979028202;
					continue;
				case 15u:
					string_ = Admit.smethod_94(RoomNoTxt);
					num = ((int)num2 * -1837039190) ^ 0x1A90E202;
					continue;
				case 14u:
				{
					int num5;
					if (Admit.smethod_117((Control)(object)RoomType1Txt))
					{
						num = 948550443;
						num5 = 948550443;
					}
					else
					{
						num = 1869486030;
						num5 = 1869486030;
					}
					continue;
				}
				case 13u:
					string_2 = Admit.smethod_94(RoomTypeTxt);
					num = (int)((num2 * 770218149) ^ 0x12A4F11A);
					continue;
				case 12u:
					Admit.smethod_121(Admit.smethod_119(e), Admit.smethod_66("Fees - ", Admit.smethod_72(FeesTxt)) ?? "", font_, Admit.smethod_120(), 100f, 350f);
					num = 639248292;
					continue;
				case 11u:
					num = (int)(num2 * 1748160706) ^ -392567373;
					continue;
				case 9u:
					string_2 = Admit.smethod_72(RoomType1Txt);
					num = (int)((num2 * 1550534700) ^ 0x547B6EBC);
					continue;
				case 8u:
					num = 357502999;
					continue;
				case 7u:
					Admit.smethod_121(Admit.smethod_119(e), Admit.smethod_66("Room Type - ", string_2) ?? "", font_, Admit.smethod_120(), 100f, 300f);
					num = 1682144982;
					continue;
				case 6u:
					num = 186993381;
					continue;
				case 4u:
					string_ = Admit.smethod_72(RoomNo1Txt);
					num = ((int)num2 * -233133664) ^ -2147482815;
					continue;
				case 3u:
					Admit.smethod_121(Admit.smethod_119(e), Admit.smethod_66("Mobile - ", Admit.smethod_72(MobileTxt)) ?? "", font_, Admit.smethod_120(), 100f, 200f);
					Admit.smethod_121(Admit.smethod_119(e), Admit.smethod_66("Room No - ", string_) ?? "", font_, Admit.smethod_120(), 100f, 250f);
					num = 131777273;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -84514566;
						num4 = -84514566;
					}
					else
					{
						num3 = -728974992;
						num4 = -728974992;
					}
					num = num3 ^ ((int)num2 * -817668174);
					continue;
				}
				case 1u:
					num = ((int)num2 * -1160248423) ^ 0x14FEC103;
					continue;
				case 0u:
					font_ = Admit.smethod_118("Times New Roman", 12f);
					Admit.smethod_121(Admit.smethod_119(e), "Admit/Discharge", font_2, Admit.smethod_120(), 250f, 100f);
					num = (int)((num2 * 853454797) ^ 0x53B2133F);
					continue;
				default:
					return;
				case 5u:
					break;
				case 10u:
					return;
				}
				break;
			}
		}
	}

	private void HistoryBtn_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		bool flag = default(bool);
		while (true)
		{
			int num = -866182799;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEDB52890u) % 9u)
				{
				case 8u:
					Admit.smethod_74("No Patient Selected");
					num = ((int)num2 * -157059875) ^ 0x2AE073;
					continue;
				case 7u:
					num = (int)(num2 * 750060277) ^ -566814350;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 694992914;
						num4 = 694992914;
					}
					else
					{
						num3 = 1549991785;
						num4 = 1549991785;
					}
					num = num3 ^ ((int)num2 * -152170796);
					continue;
				}
				case 5u:
					Admit.smethod_122((Control)(object)MyProject.Forms.Form5);
					num = (int)(num2 * 173247606) ^ -1196573280;
					continue;
				case 4u:
					flag = Admit.smethod_87(Admit.smethod_72(PIDTxt), "", bool_0: false) == 0;
					num = (int)(num2 * 426308079) ^ -1334044652;
					continue;
				case 2u:
					num = -1473624203;
					continue;
				case 1u:
					MyProject.Forms.Form2.PID_Value = Admit.smethod_72(PIDTxt);
					num = (int)((num2 * 1766494616) ^ 0x191AA548);
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

	private void AdmitDischargeBtn_Click(object sender, EventArgs e)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0730: Expected I4, but got Unknown
		//IL_0732: Unknown result type (might be due to invalid IL or missing references)
		//IL_077c: Expected I4, but got Unknown
		//IL_079b: Incompatible stack heights: 0 vs 1
		//IL_07ab: Incompatible stack heights: 0 vs 1
		//IL_07be: Incompatible stack heights: 0 vs 1
		//IL_07dd: Incompatible stack heights: 0 vs 1
		//IL_07fc: Incompatible stack heights: 0 vs 1
		//IL_081a: Incompatible stack heights: 0 vs 1
		//IL_0839: Incompatible stack heights: 0 vs 1
		//IL_0845: Unknown result type (might be due to invalid IL or missing references)
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0860: Incompatible stack heights: 0 vs 1
		//IL_087f: Incompatible stack heights: 0 vs 1
		//IL_089e: Incompatible stack heights: 0 vs 1
		//IL_08bd: Incompatible stack heights: 0 vs 1
		//IL_08dc: Incompatible stack heights: 0 vs 1
		//IL_08ef: Incompatible stack heights: 0 vs 1
		//IL_0902: Incompatible stack heights: 0 vs 1
		//IL_0921: Incompatible stack heights: 0 vs 1
		//IL_092b: Incompatible stack heights: 0 vs 1
		OleDbCommand oleDbCommand_ = default(OleDbCommand);
		string string_ = default(string);
		bool flag4 = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		OleDbDataReader oleDbDataReader_ = default(OleDbDataReader);
		bool flag = default(bool);
		int num6 = default(int);
		while (true)
		{
			int num = -1365766212;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCB994384u) % 7u)
				{
				case 5u:
					oleDbCommand_ = Admit.smethod_75();
					num = -1451828563;
					continue;
				case 4u:
					string_ = Admit.smethod_123("Select * From [Admit-Discharge] Where [PID] = ", Admit.smethod_72(PIDTxt), ";");
					num = ((int)num2 * -76672716) ^ -348276008;
					continue;
				case 3u:
				{
					int num11;
					int num12;
					if (flag4)
					{
						num11 = -919999651;
						num12 = -919999651;
					}
					else
					{
						num11 = -748503924;
						num12 = -748503924;
					}
					num = num11 ^ ((int)num2 * -2123098519);
					continue;
				}
				case 1u:
					flag4 = Admit.smethod_87(Admit.smethod_72(PIDTxt), "", bool_0: false) == 0;
					num = (int)((num2 * 1477971794) ^ 0x114F1519);
					continue;
				case 2u:
					break;
				case 0u:
					Admit.smethod_74("No Patient Selected");
					return;
				default:
					Admit.smethod_78(myconnection);
					try
					{
						while (true)
						{
							int num3 = -1880204314;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xCB994384u) % 49u)
								{
								case 48u:
									num3 = (int)((num2 * 1576472245) ^ 0x4FCE7502);
									continue;
								case 47u:
									num3 = (int)(num2 * 1672394240) ^ -859007338;
									continue;
								case 46u:
								{
									int num9;
									int num10;
									if (flag3)
									{
										num9 = 93968001;
										num10 = 93968001;
									}
									else
									{
										num9 = 1291850692;
										num10 = 1291850692;
									}
									num3 = num9 ^ ((int)num2 * -1316752146);
									continue;
								}
								case 45u:
									num3 = (int)((num2 * 1882381319) ^ 0x648B7172);
									continue;
								case 44u:
									flag2 = (Admit.smethod_87(Admit.smethod_126(Admit.smethod_125(oleDbDataReader_, 2)), "", bool_0: false) != 0) & (Admit.smethod_87(Admit.smethod_126(Admit.smethod_125(oleDbDataReader_, 3)), "", bool_0: false) == 0);
									num3 = -274036846;
									continue;
								case 43u:
									Admit.smethod_127(StatusTxt, Admit.smethod_126(Admit.smethod_125(oleDbDataReader_, 6)));
									Admit.smethod_37((Control)(object)DateIn1Txt, bool_0: true);
									num3 = ((int)num2 * -1263833877) ^ 0x2818C7A4;
									continue;
								case 42u:
								{
									int num7;
									int num8;
									if (flag)
									{
										num7 = -2027087444;
										num8 = -2027087444;
									}
									else
									{
										num7 = -1412991782;
										num8 = -1412991782;
									}
									num3 = num7 ^ (int)(num2 * 192122002);
									continue;
								}
								case 41u:
									num6 = 0;
									num3 = (int)((num2 * 702199721) ^ 0x3AAA9A8E);
									continue;
								case 40u:
									Admit.smethod_37((Control)(object)RoomNoTxt, bool_0: true);
									num3 = (int)(num2 * 1787334347) ^ -74797521;
									continue;
								case 39u:
									flag3 = num6 == 0;
									num3 = ((int)num2 * -843038493) ^ -1321916169;
									continue;
								case 38u:
									Admit.smethod_37((Control)(object)DateInTxt, bool_0: false);
									num3 = ((int)num2 * -459468019) ^ 0x225EAF3D;
									continue;
								case 37u:
									num3 = ((int)num2 * -1168317381) ^ -1487012863;
									continue;
								case 36u:
									num6 = 1;
									num3 = (int)(num2 * 2028642218) ^ -1950874340;
									continue;
								case 35u:
									Admit.smethod_37((Control)(object)AdmitDetailsBox, bool_0: true);
									num3 = ((int)num2 * -1525612795) ^ 0x147E7C76;
									continue;
								case 34u:
									Admit.smethod_37((Control)(object)RoomTypeTxt, bool_0: true);
									num3 = (int)(num2 * 544047800) ^ -425951114;
									continue;
								case 33u:
									oleDbDataReader_ = Admit.smethod_124(oleDbCommand_);
									num3 = (int)((num2 * 1569742535) ^ 0x36D35B08);
									continue;
								case 32u:
									num3 = ((int)num2 * -2045891468) ^ -1250057589;
									continue;
								case 31u:
									id = Admit.smethod_126(Admit.smethod_125(oleDbDataReader_, 0));
									num3 = (int)(num2 * 1569889577) ^ -640118154;
									continue;
								case 30u:
									Admit.smethod_37((Control)(object)AdmitDischargeBtn, bool_0: false);
									num3 = ((int)num2 * -423542232) ^ -472501841;
									continue;
								case 29u:
									num3 = ((int)num2 * -1045692058) ^ 0x7B14F9AF;
									continue;
								case 28u:
									Admit.smethod_37((Control)(object)RoomType1Txt, bool_0: true);
									num3 = ((int)num2 * -2022330754) ^ 0x643E2590;
									continue;
								case 27u:
									Admit.smethod_37((Control)(object)RoomType1Txt, bool_0: false);
									num3 = (int)((num2 * 1461171844) ^ 0x7A9E5B9F);
									continue;
								case 26u:
									Admit.smethod_37((Control)(object)DateOut1Txt, bool_0: false);
									Admit.smethod_37((Control)(object)DateOutTxt, bool_0: true);
									num3 = (int)(num2 * 1731765774) ^ -1073243739;
									continue;
								case 25u:
									Admit.smethod_37((Control)(object)ClearBtn, bool_0: true);
									num3 = (int)(num2 * 1013902142) ^ -2045118748;
									continue;
								case 24u:
									num3 = ((int)num2 * -1445557653) ^ -1486030073;
									continue;
								case 23u:
									Admit.smethod_37((Control)(object)SaveBtn, bool_0: true);
									num3 = (int)((num2 * 172384970) ^ 0x7BAF0FA6);
									continue;
								case 22u:
									Admit.smethod_37((Control)(object)RoomNo1Txt, bool_0: false);
									num3 = ((int)num2 * -568827365) ^ -76557974;
									continue;
								case 21u:
									num3 = ((int)num2 * -1266938489) ^ -1364887227;
									continue;
								case 20u:
									num3 = -2146278219;
									continue;
								case 19u:
									Admit.smethod_37((Control)(object)RoomNoTxt, bool_0: false);
									Admit.smethod_37((Control)(object)RoomNo1Txt, bool_0: true);
									num3 = ((int)num2 * -2108528537) ^ -794157237;
									continue;
								case 18u:
									num3 = ((int)num2 * -1486916825) ^ -337029945;
									continue;
								case 17u:
									oleDbCommand_ = Admit.smethod_88(string_, myconnection);
									num3 = (int)((num2 * 1007137311) ^ 0x1A9794E3);
									continue;
								case 16u:
									num3 = (int)((num2 * 349885728) ^ 0x62BD6B7A);
									continue;
								case 15u:
									num3 = ((int)num2 * -1693472193) ^ 0x31144BB5;
									continue;
								case 14u:
									num3 = ((int)num2 * -1705862762) ^ 0x355E5D7C;
									continue;
								case 13u:
								{
									int num4;
									int num5;
									if (!flag2)
									{
										num4 = -2052452403;
										num5 = -2052452403;
									}
									else
									{
										num4 = -1423294165;
										num5 = -1423294165;
									}
									num3 = num4 ^ (int)(num2 * 1508239066);
									continue;
								}
								case 12u:
									flag = Admit.smethod_128(oleDbDataReader_);
									num3 = -101713347;
									continue;
								case 11u:
									Admit.smethod_37((Control)(object)PrintBtn, bool_0: true);
									num3 = (int)(num2 * 1337757529) ^ -902961918;
									continue;
								case 10u:
									Admit.smethod_37((Control)(object)DateIn1Txt, bool_0: false);
									Admit.smethod_37((Control)(object)DateInTxt, bool_0: true);
									num3 = ((int)num2 * -562185435) ^ -1647462947;
									continue;
								case 9u:
									Admit.smethod_106(DateIn1Txt, Admit.smethod_105(Admit.smethod_125(oleDbDataReader_, 2)));
									num3 = (int)(num2 * 709900471) ^ -1101906966;
									continue;
								case 8u:
									Admit.smethod_37((Control)(object)DateOut1Txt, bool_0: true);
									num3 = ((int)num2 * -1838951760) ^ 0x68F33E8;
									continue;
								case 7u:
									Admit.smethod_106(RoomType1Txt, Admit.smethod_126(Admit.smethod_125(oleDbDataReader_, 5)));
									num3 = (int)(num2 * 895464097) ^ -911560854;
									continue;
								case 5u:
									Admit.smethod_83(myconnection);
									num3 = -105877981;
									continue;
								case 4u:
									Admit.smethod_37((Control)(object)RoomTypeTxt, bool_0: false);
									num3 = (int)((num2 * 1488513050) ^ 0x6D702D4B);
									continue;
								case 3u:
									Admit.smethod_106(RoomNo1Txt, Admit.smethod_126(Admit.smethod_125(oleDbDataReader_, 4)));
									num3 = ((int)num2 * -1202469571) ^ 0x7E38EAB0;
									continue;
								case 2u:
									Admit.smethod_37((Control)(object)DateOutTxt, bool_0: false);
									num3 = ((int)num2 * -1107443953) ^ -1081310581;
									continue;
								case 1u:
									num3 = -473881417;
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
					catch (Exception ex)
					{
						Admit.smethod_84(ex);
						Exception exception_ = ex;
						while (true)
						{
							_ = -152816883;
							while (true)
							{
								_003F val = /*Error near IL_072d: Stack underflow*/^ -879148156;
								num2 = (uint)(int)val;
								switch (val % 17)
								{
								case 15:
									Admit.smethod_37((Control)(object)AdmitDetailsBox, bool_0: true);
									_ = (num2 * 237515638) ^ 0x3B52811B;
									continue;
								case 14:
									_ = ((int)num2 * -1433801573) ^ 0x6FDECB8C;
									continue;
								case 13:
									_ = ((int)num2 * -192557397) ^ -95955187;
									continue;
								case 12:
									Admit.smethod_37((Control)(object)RoomNoTxt, bool_0: true);
									_ = ((int)num2 * -734338293) ^ 0x9B86EB1;
									continue;
								case 11:
									Admit.smethod_37((Control)(object)RoomType1Txt, bool_0: false);
									_ = ((int)num2 * -760695630) ^ 0x5288A600;
									continue;
								case 10:
									Admit.smethod_83(myconnection);
									_ = (num2 * 1212512723) ^ 0x57FDF53C;
									continue;
								case 8:
									Admit.smethod_37((Control)(object)DateOut1Txt, bool_0: true);
									_ = (num2 * 585781006) ^ 0x94B06244u;
									continue;
								case 7:
									Admit.smethod_74(Admit.smethod_129(exception_));
									Admit.smethod_74(string_);
									_ = ((int)num2 * -1296925516) ^ 0x4691E39A;
									continue;
								case 6:
									Admit.smethod_37((Control)(object)RoomNo1Txt, bool_0: false);
									_ = (num2 * 1844408941) ^ 0x8B126A89u;
									continue;
								case 5:
									Admit.smethod_37((Control)(object)DateIn1Txt, bool_0: false);
									_ = (num2 * 165060354) ^ 0xA732F12Fu;
									continue;
								case 4:
									Admit.smethod_37((Control)(object)DateInTxt, bool_0: true);
									_ = (num2 * 867557803) ^ 0x66A7314;
									continue;
								case 3:
									Admit.smethod_37((Control)(object)RoomTypeTxt, bool_0: true);
									_ = (num2 * 256484606) ^ 0x986F18AFu;
									continue;
								case 2:
									_ = ((int)num2 * -70329781) ^ -183784277;
									continue;
								case 1:
									_ = ((int)num2 * -1614861711) ^ -27933274;
									continue;
								case 0:
									Admit.smethod_37((Control)(object)DateOutTxt, bool_0: false);
									_ = ((int)num2 * -1753592930) ^ -500040285;
									continue;
								case 9:
									break;
								default:
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
		}
	}

	private bool Add_Rooms()
	{
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected I4, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected I4, but got Unknown
		//IL_0218: Incompatible stack heights: 0 vs 1
		//IL_0228: Incompatible stack heights: 0 vs 1
		//IL_022f: Incompatible stack heights: 0 vs 1
		string string_ = default(string);
		bool flag2 = default(bool);
		OleDbDataReader oleDbDataReader_ = default(OleDbDataReader);
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 627010072;
			while (true)
			{
				uint num2;
				OleDbCommand oleDbCommand_;
				switch ((num2 = (uint)num ^ 0xBFBD6E6u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
					try
					{
						oleDbCommand_ = Admit.smethod_88(string_, myconnection);
						while (true)
						{
							IL_01c8:
							int num3 = 1745509756;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xBFBD6E6u) % 14u)
								{
								case 13u:
								{
									int num6;
									int num7;
									if (!flag2)
									{
										num6 = 5857709;
										num7 = 5857709;
									}
									else
									{
										num6 = 150228439;
										num7 = 150228439;
									}
									num3 = num6 ^ ((int)num2 * -313151004);
									continue;
								}
								case 12u:
									num3 = 630899806;
									continue;
								case 11u:
									Admit.smethod_70(Admit.smethod_42(RoomNoTxt), (object)Admit.smethod_126(Admit.smethod_125(oleDbDataReader_, 0)));
									num3 = 133105314;
									continue;
								case 10u:
									oleDbDataReader_ = Admit.smethod_124(oleDbCommand_);
									num3 = ((int)num2 * -1260124064) ^ -1557809759;
									continue;
								case 8u:
								{
									int num4;
									int num5;
									if (flag)
									{
										num4 = -398062639;
										num5 = -398062639;
									}
									else
									{
										num4 = -1138305666;
										num5 = -1138305666;
									}
									num3 = num4 ^ ((int)num2 * -364254542);
									continue;
								}
								case 7u:
									num3 = ((int)num2 * -1307303843) ^ 0xFB89829;
									continue;
								case 6u:
									Admit.smethod_83(myconnection);
									num3 = ((int)num2 * -1164486740) ^ -1764568520;
									continue;
								case 5u:
									flag2 = Admit.smethod_128(oleDbDataReader_);
									num3 = 1141045803;
									continue;
								case 3u:
									num3 = ((int)num2 * -1256795597) ^ -52207038;
									continue;
								case 2u:
									num3 = ((int)num2 * -1702618762) ^ 0x3BBB7583;
									continue;
								case 1u:
									flag = Admit.smethod_130(oleDbDataReader_);
									num3 = ((int)num2 * -1900556784) ^ 0x5F05EAAC;
									continue;
								case 0u:
									num3 = (int)(num2 * 314779968) ^ -2125234181;
									continue;
								default:
									goto end_IL_017d;
								case 4u:
									break;
								case 9u:
									goto end_IL_017d;
								}
								goto IL_01c8;
								continue;
								end_IL_017d:
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
							IL_022a:
							_ = 1661731559;
							while (true)
							{
								_003F val = /*Error near IL_01e3: Stack underflow*/^ 0xBFBD6E6;
								num2 = (uint)(int)val;
								switch (val % 4)
								{
								case 3:
									Admit.smethod_83(myconnection);
									_ = (num2 * 1641821301) ^ 0x1F79CA73;
									continue;
								case 1:
									_ = ((int)num2 * -1964208739) ^ -2107571664;
									continue;
								case 0:
									break;
								default:
									Admit.smethod_85();
									goto end_IL_01dd;
								}
								goto IL_022a;
								continue;
								end_IL_01dd:
								break;
							}
							break;
						}
					}
					while (true)
					{
						int num8 = 1436866781;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0xBFBD6E6u) % 4u)
							{
							case 3u:
								result = true;
								num8 = (int)((num2 * 385532845) ^ 0xBB6E435);
								continue;
							case 0u:
								num8 = ((int)num2 * -1714032985) ^ 0x7560C76F;
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
				IL_0003:
				oleDbCommand_ = Admit.smethod_75();
				string_ = "Select * From [Room] Where [Availability] = 'Yes';";
				Admit.smethod_78(myconnection);
				num = ((int)num2 * -498220725) ^ -1973567706;
			}
		}
	}

	private bool Update_Rooms(string roomNo, string status)
	{
		OleDbCommand val = default(OleDbCommand);
		string string_ = default(string);
		bool result = default(bool);
		while (true)
		{
			int num = -1008714923;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9C7A80B4u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
					Admit.smethod_78(myconnection);
					try
					{
						while (true)
						{
							IL_012e:
							int num3 = -992169139;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x9C7A80B4u) % 8u)
								{
								case 7u:
									Admit.smethod_97((Component)(object)val);
									num3 = ((int)num2 * -1426714287) ^ -455942179;
									continue;
								case 6u:
									num3 = ((int)num2 * -232967462) ^ 0x42BBA5AA;
									continue;
								case 3u:
									num3 = (int)((num2 * 259322669) ^ 0x3E11F78F);
									continue;
								case 2u:
									Admit.smethod_83(myconnection);
									num3 = ((int)num2 * -1377654330) ^ -525140581;
									continue;
								case 1u:
									val = Admit.smethod_88(string_, myconnection);
									num3 = (int)((num2 * 1326794374) ^ 0x1744EA1A);
									continue;
								case 0u:
									Admit.smethod_96(val);
									num3 = ((int)num2 * -599929905) ^ -1033294109;
									continue;
								default:
									goto end_IL_00fc;
								case 5u:
									break;
								case 4u:
									goto end_IL_00fc;
								}
								goto IL_012e;
								continue;
								end_IL_00fc:
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
					while (true)
					{
						int num4 = -1307512738;
						while (true)
						{
							switch ((num2 = (uint)num4 ^ 0x9C7A80B4u) % 4u)
							{
							case 3u:
								num4 = ((int)num2 * -155987389) ^ 0x490542F0;
								continue;
							case 2u:
								result = true;
								num4 = ((int)num2 * -205566143) ^ 0x662F74A9;
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
				break;
				IL_0003:
				val = Admit.smethod_75();
				string_ = Admit.smethod_76(new string[5] { "Update [Room] Set [Availability] = '", status, "' Where [Room No] = ", roomNo, ";" });
				num = ((int)num2 * -1172719112) ^ -2100674366;
			}
		}
	}

	private bool Validate_Print_Data()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		bool result = default(bool);
		bool flag2 = default(bool);
		bool flag4 = default(bool);
		bool flag6 = default(bool);
		bool flag3 = default(bool);
		bool flag7 = default(bool);
		bool flag = default(bool);
		bool flag5 = default(bool);
		while (true)
		{
			int num = -1349009852;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC4FB2B47u) % 45u)
				{
				case 44u:
					num = ((int)num2 * -1621940659) ^ 0x3273F194;
					continue;
				case 43u:
					Admit.smethod_74("Missing Room No");
					result = false;
					num = (int)(num2 * 259803567) ^ -814412660;
					continue;
				case 42u:
					flag2 = (Admit.smethod_87(Admit.smethod_94(StatusTxt), "Paid", bool_0: false) == 0) & !MyProject.Forms.Form1.Number_Validator(Admit.smethod_72(FeesTxt));
					num = -483471144;
					continue;
				case 41u:
					num = ((int)num2 * -1843572298) ^ -1870442633;
					continue;
				case 40u:
					flag4 = !MyProject.Forms.Form1.Number_Validator(Admit.smethod_72(FeesTxt));
					num = -678990836;
					continue;
				case 39u:
					num = -1704553823;
					continue;
				case 38u:
					result = false;
					num = ((int)num2 * -2145089114) ^ -1629142783;
					continue;
				case 37u:
				{
					int num18;
					int num19;
					if (Admit.smethod_131(DateInTxt) != -1)
					{
						num18 = 2064403047;
						num19 = 2064403047;
					}
					else
					{
						num18 = 402637729;
						num19 = 402637729;
					}
					num = num18 ^ (int)(num2 * 139786352);
					continue;
				}
				case 36u:
					num = (int)((num2 * 1488836855) ^ 0x6AF40CBD);
					continue;
				case 35u:
					result = true;
					num = ((int)num2 * -1708448159) ^ 0x503F29B6;
					continue;
				case 34u:
					num = (int)(num2 * 838956566) ^ -1495571153;
					continue;
				case 33u:
				{
					int num12;
					int num13;
					if (!flag6)
					{
						num12 = 1698171958;
						num13 = 1698171958;
					}
					else
					{
						num12 = 151916204;
						num13 = 151916204;
					}
					num = num12 ^ ((int)num2 * -1825602073);
					continue;
				}
				case 32u:
					num = -1181220474;
					continue;
				case 31u:
					Admit.smethod_74("Missing Date In");
					num = (int)(num2 * 748008752) ^ -2072193850;
					continue;
				case 30u:
					Admit.smethod_74("Missing Date out");
					result = false;
					num = ((int)num2 * -1702197970) ^ -1183962337;
					continue;
				case 29u:
					Admit.smethod_74("Cannot discharge Without Paying fees");
					num = (int)((num2 * 2124127490) ^ 0x73DD1C62);
					continue;
				case 28u:
					num = ((int)num2 * -1897484) ^ -637660135;
					continue;
				case 27u:
					flag3 = Admit.smethod_131(DateOutTxt) == -1;
					num = (int)(num2 * 1382868231) ^ -786725231;
					continue;
				case 26u:
					num = ((int)num2 * -1584408340) ^ -1184063039;
					continue;
				case 25u:
					result = false;
					num = ((int)num2 * -1398731271) ^ -41765617;
					continue;
				case 24u:
				{
					int num20;
					int num21;
					if (!flag7)
					{
						num20 = 1412787442;
						num21 = 1412787442;
					}
					else
					{
						num20 = 1400116916;
						num21 = 1400116916;
					}
					num = num20 ^ (int)(num2 * 2091231647);
					continue;
				}
				case 23u:
					Admit.smethod_74("Missing Room type");
					num = (int)(num2 * 1192697445) ^ -1645360070;
					continue;
				case 22u:
					flag = (Admit.smethod_131(RoomNoTxt) == -1) & (Admit.smethod_87(Admit.smethod_72(RoomNo1Txt), "", bool_0: false) == 0);
					num = (int)((num2 * 72308265) ^ 0x5198C270);
					continue;
				case 21u:
				{
					int num16;
					int num17;
					if (!Admit.smethod_117((Control)(object)DateOut1Txt))
					{
						num16 = -1702996390;
						num17 = -1702996390;
					}
					else
					{
						num16 = -721895828;
						num17 = -721895828;
					}
					num = num16 ^ ((int)num2 * -45405732);
					continue;
				}
				case 20u:
					flag6 = (Admit.smethod_131(RoomTypeTxt) == -1) & (Admit.smethod_87(Admit.smethod_72(RoomType1Txt), "", bool_0: false) == 0);
					num = -1026476771;
					continue;
				case 19u:
					num = -1440617088;
					continue;
				case 18u:
					Admit.smethod_74("Missing fees");
					result = false;
					num = ((int)num2 * -1327930854) ^ -564056604;
					continue;
				case 17u:
					Admit.smethod_74("Cannot Display Fees when Not Paid");
					result = false;
					num = ((int)num2 * -1482260322) ^ 0x4FD2475;
					continue;
				case 16u:
					num = -580521774;
					continue;
				case 15u:
				{
					int num14;
					int num15;
					if (flag3)
					{
						num14 = 951677126;
						num15 = 951677126;
					}
					else
					{
						num14 = 1328112970;
						num15 = 1328112970;
					}
					num = num14 ^ ((int)num2 * -769269603);
					continue;
				}
				case 14u:
					result = false;
					num = (int)((num2 * 1380721711) ^ 0x236D9230);
					continue;
				case 12u:
					result = false;
					num = (int)((num2 * 664420963) ^ 0x7D7E954A);
					continue;
				case 11u:
					num = -2109003324;
					continue;
				case 10u:
					flag7 = !Admit.smethod_117((Control)(object)DateIn1Txt);
					num = -2027888142;
					continue;
				case 9u:
					flag5 = (Admit.smethod_87(Admit.smethod_94(StatusTxt), "Not Paid", bool_0: false) == 0) & (Admit.smethod_87(Admit.smethod_72(FeesTxt), "", bool_0: false) != 0);
					num = ((int)num2 * -2110257518) ^ -1916544719;
					continue;
				case 8u:
					Admit.smethod_74("Incorrect fees Value");
					num = ((int)num2 * -635211872) ^ 0x7F773A86;
					continue;
				case 7u:
					num = ((int)num2 * -1999276572) ^ 0x3A702FD1;
					continue;
				case 6u:
					num = (int)(num2 * 1279849887) ^ -610549695;
					continue;
				case 5u:
				{
					int num10;
					int num11;
					if (flag5)
					{
						num10 = 960939438;
						num11 = 960939438;
					}
					else
					{
						num10 = 1424176748;
						num11 = 1424176748;
					}
					num = num10 ^ (int)(num2 * 734635747);
					continue;
				}
				case 4u:
				{
					int num8;
					int num9;
					if (!flag4)
					{
						num8 = -592655102;
						num9 = -592655102;
					}
					else
					{
						num8 = -411613651;
						num9 = -411613651;
					}
					num = num8 ^ (int)(num2 * 1423610949);
					continue;
				}
				case 2u:
				{
					int num6;
					int num7;
					if (!flag2)
					{
						num6 = -1767007200;
						num7 = -1767007200;
					}
					else
					{
						num6 = -235641969;
						num7 = -235641969;
					}
					num = num6 ^ ((int)num2 * -722665865);
					continue;
				}
				case 1u:
				{
					int num5;
					if (!((Admit.smethod_87(Admit.smethod_94(StatusTxt), "", bool_0: false) == 0) | (Admit.smethod_87(Admit.smethod_94(StatusTxt), "Not Paid", bool_0: false) == 0)))
					{
						num = -757870441;
						num5 = -757870441;
					}
					else
					{
						num = -2103287969;
						num5 = -2103287969;
					}
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -410838424;
						num4 = -410838424;
					}
					else
					{
						num3 = -381210920;
						num4 = -381210920;
					}
					num = num3 ^ (int)(num2 * 1009752077);
					continue;
				}
				case 3u:
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
