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
public class SearchReciever_Admin : UserControl
{
	private IContainer components;

	private OleDbConnection myconnection;

	private string name_search;

	private string mobile_search;

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
			if (searchBtn != null)
			{
				goto IL_0048;
			}
			goto IL_00b4;
			IL_00b4:
			_SearchBtn = value;
			int num = -1702928985;
			goto IL_0087;
			IL_0087:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x941ADC18u) % 7u)
				{
				case 6u:
					searchBtn = _SearchBtn;
					num = (int)((num2 * 679451212) ^ 0x3E2D2C73);
					continue;
				case 5u:
					SearchReciever_Admin.smethod_55((Control)(object)searchBtn, eventHandler_);
					num = ((int)num2 * -362819042) ^ 0x4F2C0F8C;
					continue;
				case 4u:
					break;
				case 3u:
				{
					int num3;
					int num4;
					if (searchBtn != null)
					{
						num3 = -369117710;
						num4 = -369117710;
					}
					else
					{
						num3 = -1208939549;
						num4 = -1208939549;
					}
					num = num3 ^ (int)(num2 * 1360526595);
					continue;
				}
				case 1u:
					SearchReciever_Admin.smethod_54((Control)(object)searchBtn, eventHandler_);
					num = ((int)num2 * -1506120877) ^ -1875017052;
					continue;
				default:
					return;
				case 2u:
					goto IL_00b4;
				case 0u:
					return;
				}
				break;
			}
			goto IL_0048;
			IL_0048:
			num = -467233936;
			goto IL_0087;
		}
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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
				int num = -212207329;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA3173F05u) % 6u)
					{
					case 4u:
					{
						searchResultGrid = _SearchResultGrid;
						int num4;
						int num5;
						if (searchResultGrid != null)
						{
							num4 = -1349221503;
							num5 = -1349221503;
						}
						else
						{
							num4 = -1749201575;
							num5 = -1749201575;
						}
						num = num4 ^ ((int)num2 * -629117003);
						continue;
					}
					case 2u:
					{
						_SearchResultGrid = value;
						searchResultGrid = _SearchResultGrid;
						int num3;
						if (searchResultGrid == null)
						{
							num = -1235392754;
							num3 = -1235392754;
						}
						else
						{
							num = -1378710950;
							num3 = -1378710950;
						}
						continue;
					}
					case 1u:
						SearchReciever_Admin.smethod_57(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = (int)(num2 * 1947852738) ^ -1689954832;
						continue;
					case 0u:
						SearchReciever_Admin.smethod_56(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = (int)((num2 * 1071713969) ^ 0x1A5EE63D);
						continue;
					default:
						return;
					case 3u:
						break;
					case 5u:
						return;
					}
					break;
				}
			}
		}
	}

	[field: AccessedThroughProperty("RecieverInfoBox")]
	internal virtual GroupBox RecieverInfoBox
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

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IDTxt")]
	internal virtual TextBox IDTxt
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
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

	[field: AccessedThroughProperty("DateRecievedTxt")]
	internal virtual TextBox DateRecievedTxt
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

	[field: AccessedThroughProperty("DOBTxt")]
	internal virtual TextBox DOBTxt
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

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button DeleteBtn
	{
		[CompilerGenerated]
		get
		{
			return _DeleteBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = DeleteBtn_Click;
			Button deleteBtn = default(Button);
			while (true)
			{
				int num = 305730292;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1230BE71u) % 9u)
					{
					case 7u:
						SearchReciever_Admin.smethod_54((Control)(object)deleteBtn, eventHandler_);
						num = (int)((num2 * 1352698624) ^ 0x3E96DD6);
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (deleteBtn != null)
						{
							num5 = 1974466218;
							num6 = 1974466218;
						}
						else
						{
							num5 = 564919022;
							num6 = 564919022;
						}
						num = num5 ^ ((int)num2 * -311319021);
						continue;
					}
					case 5u:
					{
						int num3;
						int num4;
						if (deleteBtn != null)
						{
							num3 = -834579564;
							num4 = -834579564;
						}
						else
						{
							num3 = -1471532406;
							num4 = -1471532406;
						}
						num = num3 ^ (int)(num2 * 1560749275);
						continue;
					}
					case 4u:
						_DeleteBtn = value;
						num = 1543600389;
						continue;
					case 3u:
						SearchReciever_Admin.smethod_55((Control)(object)deleteBtn, eventHandler_);
						num = (int)(num2 * 28585826) ^ -540809888;
						continue;
					case 2u:
						deleteBtn = _DeleteBtn;
						num = ((int)num2 * -488359915) ^ 0x1C737770;
						continue;
					case 1u:
						deleteBtn = _DeleteBtn;
						num = ((int)num2 * -1158328924) ^ 0x64221661;
						continue;
					default:
						return;
					case 0u:
						break;
					case 8u:
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
			Button clearBtn = _ClearBtn;
			while (true)
			{
				int num = 1612681707;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x67D4D49Bu) % 7u)
					{
					case 5u:
						_ClearBtn = value;
						clearBtn = _ClearBtn;
						num = 1140758686;
						continue;
					case 4u:
						SearchReciever_Admin.smethod_54((Control)(object)clearBtn, eventHandler_);
						num = (int)((num2 * 1365031959) ^ 0x3A24E57F);
						continue;
					case 3u:
					{
						int num5;
						int num6;
						if (clearBtn == null)
						{
							num5 = 1793683110;
							num6 = 1793683110;
						}
						else
						{
							num5 = 1945926548;
							num6 = 1945926548;
						}
						num = num5 ^ ((int)num2 * -1897668449);
						continue;
					}
					case 2u:
					{
						int num3;
						int num4;
						if (clearBtn == null)
						{
							num3 = -2122815779;
							num4 = -2122815779;
						}
						else
						{
							num3 = -2723085;
							num4 = -2723085;
						}
						num = num3 ^ ((int)num2 * -1558533175);
						continue;
					}
					case 1u:
						SearchReciever_Admin.smethod_55((Control)(object)clearBtn, eventHandler_);
						num = (int)((num2 * 1266704191) ^ 0x2DFCBB8B);
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
	}

	internal virtual Button UpdateBtn
	{
		[CompilerGenerated]
		get
		{
			return _UpdateBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = UpdateBtn_Click;
			Button updateBtn = default(Button);
			while (true)
			{
				int num = -850091289;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xACBA827Cu) % 7u)
					{
					case 5u:
						SearchReciever_Admin.smethod_54((Control)(object)updateBtn, eventHandler_);
						num = (int)(num2 * 34082498) ^ -1137832754;
						continue;
					case 4u:
						SearchReciever_Admin.smethod_55((Control)(object)updateBtn, eventHandler_);
						num = ((int)num2 * -1087777469) ^ -1603604372;
						continue;
					case 3u:
					{
						int num4;
						int num5;
						if (updateBtn == null)
						{
							num4 = 520997454;
							num5 = 520997454;
						}
						else
						{
							num4 = 2141401347;
							num5 = 2141401347;
						}
						num = num4 ^ ((int)num2 * -1995052042);
						continue;
					}
					case 2u:
						updateBtn = _UpdateBtn;
						num = (int)((num2 * 1952587149) ^ 0x6402F62C);
						continue;
					case 1u:
					{
						_UpdateBtn = value;
						updateBtn = _UpdateBtn;
						int num3;
						if (updateBtn != null)
						{
							num = -289870859;
							num3 = -289870859;
						}
						else
						{
							num = -972330057;
							num3 = -972330057;
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

	[field: AccessedThroughProperty("GenderTxt")]
	internal virtual ComboBox GenderTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BloodGroupTxt")]
	internal virtual ComboBox BloodGroupTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public SearchReciever_Admin()
	{
		SearchReciever_Admin.smethod_0((UserControl)(object)this, (EventHandler)SearchDonor_Admin_Load);
		myconnection = SearchReciever_Admin.smethod_1();
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
			goto IL_0056;
			IL_0056:
			int num = 1951986623;
			goto IL_005b;
			IL_005b:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6FEDAC1Eu) % 7u)
				{
				case 5u:
					num = ((int)num2 * -1879880055) ^ 0x7C500D25;
					continue;
				case 4u:
					num = 951265895;
					continue;
				case 3u:
					num = ((int)num2 * -425500858) ^ 0x579E2864;
					continue;
				case 2u:
					SearchReciever_Admin.smethod_2((IDisposable)components);
					num = (int)((num2 * 610486069) ^ 0x6932AD49);
					continue;
				case 0u:
					break;
				default:
					return;
				case 6u:
					goto IL_0088;
				case 1u:
					return;
				}
				break;
				IL_0088:
				if (components != null)
				{
					num = 161792321;
					num3 = 161792321;
					continue;
				}
				goto IL_000a;
			}
			goto IL_0056;
			IL_000a:
			num = 1651741447;
			num3 = 1651741447;
			goto IL_005b;
		}
		finally
		{
			while (true)
			{
				IL_00df:
				int num4 = 480150819;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num4 ^ 0x6FEDAC1Eu) % 3u)
					{
					case 2u:
						goto IL_00ae;
					default:
						goto end_IL_00c2;
					case 0u:
						break;
					case 1u:
						goto end_IL_00c2;
					}
					goto IL_00df;
					IL_00ae:
					((ContainerControl)this).Dispose(disposing);
					num4 = ((int)num2 * -1973645520) ^ -1048488054;
					continue;
					end_IL_00c2:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		PictureBox1 = SearchReciever_Admin.smethod_3();
		while (true)
		{
			int num = 480532654;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x62831C83u) % 310u)
				{
				case 309u:
					num = (int)((num2 * 563093521) ^ 0x34D4D81);
					continue;
				case 308u:
					SearchReciever_Admin.smethod_21((Control)(object)GroupBox1, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchReciever_Admin.smethod_14((Control)(object)GroupBox1, new Point(155, 150));
					num = (int)(num2 * 1716128100) ^ -1566783695;
					continue;
				case 307u:
					SearchReciever_Admin.smethod_21((Control)(object)Label2, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 613790358) ^ -43776048;
					continue;
				case 306u:
					SearchReciever_Admin.smethod_22((Control)(object)MobileSTxt, 2);
					num = ((int)num2 * -397907301) ^ -1790623003;
					continue;
				case 305u:
					num = ((int)num2 * -470566376) ^ -956421851;
					continue;
				case 304u:
					num = (int)(num2 * 24897839) ^ -497704827;
					continue;
				case 303u:
					num = ((int)num2 * -1985488461) ^ 0x65A6317C;
					continue;
				case 302u:
					SearchReciever_Admin.smethod_15((Control)(object)ClearBtn, "ClearBtn");
					num = ((int)num2 * -1238600759) ^ -527229082;
					continue;
				case 301u:
					SearchReciever_Admin.smethod_15((Control)(object)Label6, "Label6");
					num = ((int)num2 * -1599961362) ^ 0x17979A33;
					continue;
				case 300u:
					num = (int)(num2 * 2094455039) ^ -1871542797;
					continue;
				case 299u:
					SearchReciever_Admin.smethod_16((Control)(object)GenderTxt, new Size(146, 30));
					SearchReciever_Admin.smethod_22((Control)(object)GenderTxt, 20);
					SearchReciever_Admin.smethod_14((Control)(object)QuantityTxt, new Point(507, 215));
					num = (int)((num2 * 837812317) ^ 0x35EFE678);
					continue;
				case 298u:
					Label4 = SearchReciever_Admin.smethod_4();
					num = ((int)num2 * -795189388) ^ -500778729;
					continue;
				case 297u:
					SearchReciever_Admin.smethod_21((Control)(object)DeleteBtn, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -502631756) ^ -1562647906;
					continue;
				case 296u:
					SearchReciever_Admin.smethod_23(Label3, "Mobile : ");
					num = (int)(num2 * 1262523474) ^ -1799583755;
					continue;
				case 295u:
					Label9 = SearchReciever_Admin.smethod_4();
					num = (int)(num2 * 476811343) ^ -746755898;
					continue;
				case 294u:
					num = ((int)num2 * -610907073) ^ 0x4C60EFE9;
					continue;
				case 293u:
					num = ((int)num2 * -480605531) ^ 0x38DB875C;
					continue;
				case 292u:
					num = ((int)num2 * -394261839) ^ 0x6F72491C;
					continue;
				case 291u:
					SearchReciever_Admin.smethod_15((Control)(object)Label8, "Label8");
					num = ((int)num2 * -1417872882) ^ -1577793914;
					continue;
				case 290u:
					SearchReciever_Admin.smethod_30((Control)(object)SearchBtn, Color.White);
					num = (int)(num2 * 1844668689) ^ -1385972883;
					continue;
				case 289u:
					SearchReciever_Admin.smethod_21((Control)(object)Label10, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -60766008) ^ -1402519591;
					continue;
				case 288u:
					SearchReciever_Admin.smethod_16((Control)(object)NameSTxt, new Size(237, 28));
					num = ((int)num2 * -112690663) ^ 0x6F52F0AC;
					continue;
				case 287u:
					SearchReciever_Admin.smethod_29((ButtonBase)(object)SearchBtn, Color.MidnightBlue);
					SearchReciever_Admin.smethod_21((Control)(object)SearchBtn, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1920804123) ^ -825583431;
					continue;
				case 286u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)Label6);
					num = (int)((num2 * 580452060) ^ 0x5E186D42);
					continue;
				case 285u:
					num = (int)(num2 * 1527990595) ^ -1515665840;
					continue;
				case 284u:
					SearchReciever_Admin.smethod_24(Label9, (ContentAlignment)32);
					num = ((int)num2 * -1184262767) ^ 0x7975BABC;
					continue;
				case 283u:
					num = (int)((num2 * 759080993) ^ 0x246685DE);
					continue;
				case 282u:
					num = ((int)num2 * -794297136) ^ -286791302;
					continue;
				case 281u:
					num = (int)(num2 * 1035125133) ^ -566179851;
					continue;
				case 280u:
					num = ((int)num2 * -141217823) ^ 0x46B2808A;
					continue;
				case 279u:
					num = (int)(num2 * 285608010) ^ -2040855735;
					continue;
				case 278u:
					SearchReciever_Admin.smethod_32((ButtonBase)(object)UpdateBtn, bool_0: false);
					num = ((int)num2 * -49728722) ^ 0x2ABA74F8;
					continue;
				case 277u:
					SearchReciever_Admin.smethod_16((Control)(object)Label4, new Size(134, 28));
					num = (int)(num2 * 562617047) ^ -350569078;
					continue;
				case 276u:
					SearchReciever_Admin.smethod_48((Control)(object)this, "SearchReciever_Admin");
					SearchReciever_Admin.smethod_49((Control)(object)this, new Size(977, 804));
					num = (int)((num2 * 659735026) ^ 0x5F4888D2);
					continue;
				case 275u:
					SearchReciever_Admin.smethod_22((Control)(object)Label2, 0);
					num = (int)((num2 * 428808154) ^ 0x671EAD32);
					continue;
				case 274u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)DOBTxt);
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)NameTxt);
					num = (int)(num2 * 165786372) ^ -454552849;
					continue;
				case 273u:
					SearchReciever_Admin.smethod_16((Control)(object)NameTxt, new Size(271, 28));
					num = ((int)num2 * -1393367432) ^ 0x2E6DF8BE;
					continue;
				case 272u:
					NameTxt = SearchReciever_Admin.smethod_7();
					num = ((int)num2 * -1186184337) ^ -1348483399;
					continue;
				case 271u:
					SearchReciever_Admin.smethod_39((ListControl)(object)BloodGroupTxt, bool_0: true);
					SearchReciever_Admin.smethod_41(SearchReciever_Admin.smethod_40(BloodGroupTxt), new object[8] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
					num = (int)(num2 * 1297798751) ^ -1019617383;
					continue;
				case 270u:
					SearchReciever_Admin.smethod_23(Label5, "Age :");
					num = ((int)num2 * -1867782337) ^ 0x4718DA34;
					continue;
				case 269u:
					SearchReciever_Admin.smethod_14((Control)(object)DateRecievedTxt, new Point(166, 215));
					num = (int)((num2 * 1243541757) ^ 0x4453F6A4);
					continue;
				case 268u:
					SearchReciever_Admin.smethod_14((Control)(object)MobileSTxt, new Point(120, 86));
					num = ((int)num2 * -1254789552) ^ -1726234753;
					continue;
				case 267u:
					SearchReciever_Admin.smethod_23(Label12, "Quantity : ");
					SearchReciever_Admin.smethod_14((Control)(object)IDTxt, new Point(117, 36));
					num = ((int)num2 * -200903723) ^ 0x2613BA91;
					continue;
				case 266u:
					SearchReciever_Admin.smethod_21((Control)(object)Label9, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -931751776) ^ 0x3440205B;
					continue;
				case 265u:
					SearchReciever_Admin.smethod_19(PictureBox1, bool_0: false);
					num = ((int)num2 * -171877180) ^ 0x134F9262;
					continue;
				case 264u:
					num = ((int)num2 * -774531677) ^ 0x7A227A5D;
					continue;
				case 263u:
					num = ((int)num2 * -1756176619) ^ -1865012607;
					continue;
				case 262u:
					DOBTxt = SearchReciever_Admin.smethod_7();
					num = (int)(num2 * 2016477311) ^ -131585539;
					continue;
				case 261u:
					SearchReciever_Admin.smethod_30((Control)(object)ClearBtn, Color.White);
					num = (int)((num2 * 892823667) ^ 0x69022974);
					continue;
				case 260u:
					SearchReciever_Admin.smethod_44((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -1263811828) ^ 0x5F5F1D20;
					continue;
				case 259u:
					SearchReciever_Admin.smethod_22((Control)(object)Label9, 11);
					num = (int)(num2 * 649240554) ^ -809289980;
					continue;
				case 258u:
					SearchReciever_Admin.smethod_16((Control)(object)RecieverInfoBox, new Size(699, 259));
					num = (int)(num2 * 981922155) ^ -765931202;
					continue;
				case 257u:
					num = (int)(num2 * 418078158) ^ -1809529025;
					continue;
				case 256u:
					SearchResultGrid = SearchReciever_Admin.smethod_8();
					num = (int)(num2 * 1500138044) ^ -1065479694;
					continue;
				case 255u:
					SearchReciever_Admin.smethod_42((TextBoxBase)(object)IDTxt, bool_0: true);
					num = ((int)num2 * -1205633129) ^ 0x8CC1071;
					continue;
				case 254u:
					SearchReciever_Admin.smethod_16((Control)(object)SearchResultGrid, new Size(853, 169));
					SearchReciever_Admin.smethod_22((Control)(object)SearchResultGrid, 13);
					num = (int)(num2 * 1193119746) ^ -881131262;
					continue;
				case 253u:
					num = ((int)num2 * -1489403337) ^ 0x5A4F2B31;
					continue;
				case 252u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)NameSTxt);
					num = ((int)num2 * -1727460753) ^ -501487960;
					continue;
				case 251u:
					num = ((int)num2 * -512776669) ^ 0x5E781E3B;
					continue;
				case 250u:
					num = (int)((num2 * 1825401930) ^ 0x33606468);
					continue;
				case 249u:
					SearchReciever_Admin.smethod_15((Control)(object)DOBTxt, "DOBTxt");
					SearchReciever_Admin.smethod_16((Control)(object)DOBTxt, new Size(169, 28));
					num = ((int)num2 * -1422315940) ^ 0x76769F47;
					continue;
				case 248u:
					num = ((int)num2 * -973543007) ^ -516050373;
					continue;
				case 247u:
					SearchReciever_Admin.smethod_38(GenderTxt, (ComboBoxStyle)2);
					num = ((int)num2 * -1623340157) ^ 0x39918003;
					continue;
				case 246u:
					num = (int)((num2 * 82650643) ^ 0x176E1593);
					continue;
				case 245u:
					SearchReciever_Admin.smethod_22((Control)(object)RecieverInfoBox, 14);
					num = (int)((num2 * 49972304) ^ 0x1E7388A5);
					continue;
				case 244u:
					SearchReciever_Admin.smethod_12((Control)(object)this);
					num = ((int)num2 * -1510802638) ^ -1391274167;
					continue;
				case 243u:
					num = (int)((num2 * 1751196159) ^ 0x778BB31C);
					continue;
				case 242u:
					SearchReciever_Admin.smethod_41(SearchReciever_Admin.smethod_40(GenderTxt), new object[3] { "Male", "Female", "Others" });
					num = ((int)num2 * -63669119) ^ 0x3090514E;
					continue;
				case 241u:
					SearchReciever_Admin.smethod_28(GroupBox1, "Search Patient");
					num = (int)((num2 * 1662083985) ^ 0x12F5910D);
					continue;
				case 240u:
					num = (int)(num2 * 1936466979) ^ -1130705854;
					continue;
				case 239u:
					num = (int)((num2 * 1759461598) ^ 0x7ECDF5F6);
					continue;
				case 238u:
					num = (int)((num2 * 339898878) ^ 0x5748954B);
					continue;
				case 237u:
					SearchReciever_Admin.smethod_31((ButtonBase)(object)ClearBtn, "Clear");
					num = (int)((num2 * 1803367042) ^ 0x124940C0);
					continue;
				case 236u:
					SearchReciever_Admin.smethod_22((Control)(object)QuantityTxt, 19);
					num = (int)(num2 * 338187516) ^ -857860880;
					continue;
				case 235u:
					SearchReciever_Admin.smethod_16((Control)(object)Label9, new Size(77, 28));
					num = ((int)num2 * -1972766301) ^ 0xE95FAE9;
					continue;
				case 234u:
					num = (int)((num2 * 1274307543) ^ 0x7E8F3EAD);
					continue;
				case 233u:
					SearchReciever_Admin.smethod_14((Control)(object)RecieverInfoBox, new Point(79, 470));
					num = (int)(num2 * 249080609) ^ -760492236;
					continue;
				case 232u:
					SearchReciever_Admin.smethod_15((Control)(object)SearchResultGrid, "SearchResultGrid");
					num = (int)(num2 * 656692546) ^ -454401324;
					continue;
				case 231u:
					GroupBox1 = SearchReciever_Admin.smethod_5();
					num = (int)(num2 * 962363866) ^ -1978025000;
					continue;
				case 230u:
					SearchReciever_Admin.smethod_23(Label10, "Date Recieved :");
					num = (int)((num2 * 1464105175) ^ 0x64B4A14D);
					continue;
				case 229u:
					SearchReciever_Admin.smethod_21((Control)(object)RecieverInfoBox, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -164241678) ^ 0x7EC8D467;
					continue;
				case 228u:
					num = (int)((num2 * 2134157150) ^ 0x37B2E220);
					continue;
				case 227u:
					SearchReciever_Admin.smethod_14((Control)(object)Label5, new Point(16, 169));
					num = (int)(num2 * 574414480) ^ -297807540;
					continue;
				case 226u:
					num = (int)((num2 * 1393654109) ^ 0x14C0B5ED);
					continue;
				case 224u:
					SearchReciever_Admin.smethod_16((Control)(object)Label3, new Size(77, 28));
					num = ((int)num2 * -1594194940) ^ 0x2E785731;
					continue;
				case 223u:
					SearchReciever_Admin.smethod_22((Control)(object)NameTxt, 4);
					SearchReciever_Admin.smethod_21((Control)(object)Label6, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchReciever_Admin.smethod_14((Control)(object)Label6, new Point(401, 129));
					num = ((int)num2 * -2035750556) ^ 0x493F0E0C;
					continue;
				case 222u:
					SearchReciever_Admin.smethod_28(RecieverInfoBox, "Reciever Information");
					num = (int)((num2 * 2004339060) ^ 0x7F6852F4);
					continue;
				case 221u:
					SearchReciever_Admin.smethod_21((Control)(object)Label4, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1124481007) ^ -1335096174;
					continue;
				case 220u:
					SearchReciever_Admin.smethod_16((Control)(object)MobileSTxt, new Size(237, 28));
					num = ((int)num2 * -959843500) ^ 0x473EA493;
					continue;
				case 219u:
					SearchReciever_Admin.smethod_45((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1552055265) ^ 0x103A843B;
					continue;
				case 218u:
					SearchReciever_Admin.smethod_23(Label8, "Name : ");
					num = ((int)num2 * -924571287) ^ 0x49604CE2;
					continue;
				case 217u:
					num = (int)((num2 * 336698968) ^ 0x785D1880);
					continue;
				case 216u:
					SearchReciever_Admin.smethod_31((ButtonBase)(object)UpdateBtn, "Update");
					num = (int)((num2 * 1368136791) ^ 0x5A21C52D);
					continue;
				case 215u:
					SearchReciever_Admin.smethod_52((Control)(object)RecieverInfoBox);
					num = (int)((num2 * 1156046876) ^ 0x6898D4AC);
					continue;
				case 214u:
					SearchReciever_Admin.smethod_27(RecieverInfoBox, bool_0: false);
					num = ((int)num2 * -715260687) ^ -1141112241;
					continue;
				case 213u:
					SearchReciever_Admin.smethod_22((Control)(object)Label12, 18);
					num = (int)((num2 * 784808924) ^ 0x5D796288);
					continue;
				case 212u:
					SearchReciever_Admin.smethod_21((Control)(object)Label12, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1122384374) ^ -1442805394;
					continue;
				case 211u:
					SearchReciever_Admin.smethod_15((Control)(object)IDTxt, "IDTxt");
					num = (int)((num2 * 733332809) ^ 0x60D70E6C);
					continue;
				case 210u:
					num = ((int)num2 * -579772182) ^ 0xAC93FF6;
					continue;
				case 209u:
					SearchReciever_Admin.smethod_16((Control)(object)Label8, new Size(77, 28));
					num = (int)(num2 * 525211336) ^ -696038734;
					continue;
				case 208u:
					SearchReciever_Admin.smethod_18(PictureBox1, 7);
					num = ((int)num2 * -1423920207) ^ 0x167C0724;
					continue;
				case 207u:
					SearchReciever_Admin.smethod_50((ISupportInitialize)SearchResultGrid);
					num = (int)(num2 * 583324465) ^ -697649950;
					continue;
				case 206u:
					BloodGroupTxt = SearchReciever_Admin.smethod_9();
					num = ((int)num2 * -1770068010) ^ -875291855;
					continue;
				case 205u:
					SearchReciever_Admin.smethod_14((Control)(object)Label2, new Point(37, 44));
					num = (int)(num2 * 776188464) ^ -702564153;
					continue;
				case 204u:
					SearchReciever_Admin.smethod_22((Control)(object)DOBTxt, 5);
					num = (int)((num2 * 437092058) ^ 0x5336AF38);
					continue;
				case 203u:
					Label1 = SearchReciever_Admin.smethod_4();
					num = ((int)num2 * -1502003534) ^ -1335327720;
					continue;
				case 202u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)QuantityTxt);
					num = (int)(num2 * 1625268092) ^ -2124947174;
					continue;
				case 201u:
					SearchReciever_Admin.smethod_29((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					SearchReciever_Admin.smethod_21((Control)(object)ClearBtn, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -138192971) ^ 0x2BB2C162;
					continue;
				case 200u:
					Label6 = SearchReciever_Admin.smethod_4();
					num = (int)(num2 * 869031778) ^ -639525799;
					continue;
				case 199u:
					SearchReciever_Admin.smethod_42((TextBoxBase)(object)DateRecievedTxt, bool_0: true);
					SearchReciever_Admin.smethod_16((Control)(object)DateRecievedTxt, new Size(222, 28));
					num = (int)(num2 * 689336529) ^ -265514113;
					continue;
				case 198u:
					num = ((int)num2 * -2115711940) ^ -1982848893;
					continue;
				case 197u:
					SearchReciever_Admin.smethod_17(PictureBox1, (PictureBoxSizeMode)1);
					num = ((int)num2 * -225673448) ^ -282086701;
					continue;
				case 196u:
					SearchReciever_Admin.smethod_22((Control)(object)Label3, 3);
					num = ((int)num2 * -1459954179) ^ 0x6EF6300C;
					continue;
				case 195u:
					num = (int)(num2 * 1907273591) ^ -1819206647;
					continue;
				case 194u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)SearchBtn);
					num = ((int)num2 * -550367828) ^ -1456492989;
					continue;
				case 193u:
					Label3 = SearchReciever_Admin.smethod_4();
					num = (int)(num2 * 1461835630) ^ -1750307604;
					continue;
				case 192u:
					SearchReciever_Admin.smethod_14((Control)(object)NameTxt, new Point(117, 77));
					num = (int)(num2 * 1139597085) ^ -1375558229;
					continue;
				case 191u:
					num = (int)(num2 * 1150936666) ^ -825625875;
					continue;
				case 190u:
					SearchReciever_Admin.smethod_31((ButtonBase)(object)DeleteBtn, "Delete");
					num = ((int)num2 * -516131362) ^ -1833114519;
					continue;
				case 189u:
					num = ((int)num2 * -585779137) ^ -440043423;
					continue;
				case 188u:
					SearchReciever_Admin.smethod_16((Control)(object)Label6, new Size(84, 26));
					num = ((int)num2 * -569211807) ^ 0x7D50EF59;
					continue;
				case 187u:
					SearchReciever_Admin.smethod_22((Control)(object)GroupBox1, 12);
					num = (int)((num2 * 1542859522) ^ 0x3E6B99A4);
					continue;
				case 186u:
					SearchReciever_Admin.smethod_50((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -501080109) ^ 0x10031CB4;
					continue;
				case 185u:
					SearchReciever_Admin.smethod_34(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					SearchReciever_Admin.smethod_14((Control)(object)SearchResultGrid, new Point(59, 295));
					num = (int)(num2 * 1284852469) ^ -1491722987;
					continue;
				case 184u:
					SearchReciever_Admin.smethod_22((Control)(object)Label6, 2);
					num = ((int)num2 * -2104908300) ^ 0xC9556AC;
					continue;
				case 183u:
					SearchReciever_Admin.smethod_23(Label1, "Search Reciever");
					num = ((int)num2 * -949069464) ^ 0x16B02744;
					continue;
				case 182u:
					num = ((int)num2 * -739888250) ^ -176817182;
					continue;
				case 181u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)Label11);
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)Label4);
					num = ((int)num2 * -219613332) ^ 0x503D0115;
					continue;
				case 180u:
					SearchReciever_Admin.smethod_51((Control)(object)RecieverInfoBox, bool_0: false);
					num = (int)((num2 * 1707328632) ^ 0xD66F486);
					continue;
				case 179u:
					SearchReciever_Admin.smethod_15((Control)(object)Label3, "Label3");
					num = (int)(num2 * 1738028466) ^ -1385257663;
					continue;
				case 178u:
					SearchReciever_Admin.smethod_22((Control)(object)ClearBtn, 16);
					num = ((int)num2 * -1690892732) ^ 0x7B4D1067;
					continue;
				case 177u:
					SearchReciever_Admin.smethod_14((Control)(object)Label3, new Point(37, 87));
					num = (int)((num2 * 1460257044) ^ 0x74CC000C);
					continue;
				case 176u:
					SearchReciever_Admin.smethod_22((Control)(object)BloodGroupTxt, 21);
					num = (int)((num2 * 203849937) ^ 0xC2C42B5);
					continue;
				case 175u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_47((Control)(object)this), (Control)(object)UpdateBtn);
					num = (int)((num2 * 1336228721) ^ 0x1A39994);
					continue;
				case 174u:
					SearchReciever_Admin.smethod_14((Control)(object)Label9, new Point(16, 124));
					SearchReciever_Admin.smethod_15((Control)(object)Label9, "Label9");
					num = (int)(num2 * 1691319001) ^ -1293524923;
					continue;
				case 173u:
					num = ((int)num2 * -983689551) ^ -1012289536;
					continue;
				case 172u:
					num = ((int)num2 * -80781069) ^ -2131764510;
					continue;
				case 171u:
					num = ((int)num2 * -1287517075) ^ -457367123;
					continue;
				case 170u:
					num = ((int)num2 * -136233201) ^ 0x5272DCD8;
					continue;
				case 169u:
					SearchReciever_Admin.smethod_51((Control)(object)GroupBox1, bool_0: false);
					num = ((int)num2 * -968320902) ^ -976996470;
					continue;
				case 168u:
					SearchReciever_Admin.smethod_16((Control)(object)MobileTxt, new Size(271, 28));
					num = (int)((num2 * 744508726) ^ 0x66EDD21A);
					continue;
				case 167u:
					num = (int)(num2 * 997466482) ^ -3561840;
					continue;
				case 166u:
					SearchReciever_Admin.smethod_15((Control)(object)UpdateBtn, "UpdateBtn");
					SearchReciever_Admin.smethod_16((Control)(object)UpdateBtn, new Size(104, 37));
					num = (int)(num2 * 1371907210) ^ -667206336;
					continue;
				case 165u:
					SearchReciever_Admin.smethod_22((Control)(object)Label11, 16);
					num = (int)((num2 * 1164119078) ^ 0xBB7278A);
					continue;
				case 164u:
					SearchReciever_Admin.smethod_13(PictureBox1, (Image)(object)Resources.images);
					SearchReciever_Admin.smethod_14((Control)(object)PictureBox1, new Point(203, 18));
					num = ((int)num2 * -1457343317) ^ 0x2A0F21AB;
					continue;
				case 163u:
					num = ((int)num2 * -580157208) ^ -631325978;
					continue;
				case 162u:
					SearchReciever_Admin.smethod_46((Control)(object)this, Color.White);
					num = (int)((num2 * 1002691002) ^ 0x7C80D768);
					continue;
				case 161u:
					SearchReciever_Admin.smethod_39((ListControl)(object)GenderTxt, bool_0: true);
					num = ((int)num2 * -1512069084) ^ -1951426263;
					continue;
				case 160u:
					SearchReciever_Admin.smethod_15((Control)(object)BloodGroupTxt, "BloodGroupTxt");
					num = ((int)num2 * -27727595) ^ 0x65CCA037;
					continue;
				case 159u:
					SearchReciever_Admin.smethod_16((Control)(object)ClearBtn, new Size(104, 37));
					num = ((int)num2 * -1364302509) ^ -663589632;
					continue;
				case 158u:
					SearchReciever_Admin.smethod_14((Control)(object)GenderTxt, new Point(530, 117));
					num = (int)(num2 * 520523968) ^ -449830225;
					continue;
				case 157u:
					num = ((int)num2 * -2019183249) ^ 0x28C44815;
					continue;
				case 156u:
					SearchReciever_Admin.smethod_21((Control)(object)Label8, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1552913930) ^ -1916602942;
					continue;
				case 155u:
					num = ((int)num2 * -1326077242) ^ -2020593575;
					continue;
				case 154u:
					SearchReciever_Admin.smethod_14((Control)(object)ClearBtn, new Point(808, 649));
					num = (int)((num2 * 973679440) ^ 0x6BEF278F);
					continue;
				case 153u:
					num = (int)((num2 * 2017427124) ^ 0x3B91AE54);
					continue;
				case 152u:
					num = (int)((num2 * 655912400) ^ 0x1FFB1C4D);
					continue;
				case 151u:
					num = (int)((num2 * 808269585) ^ 0x7EE6A955);
					continue;
				case 150u:
					SearchReciever_Admin.smethod_14((Control)(object)Label10, new Point(16, 221));
					num = (int)(num2 * 77000011) ^ -841012042;
					continue;
				case 149u:
					SearchReciever_Admin.smethod_27(GroupBox1, bool_0: false);
					num = (int)(num2 * 920901203) ^ -1543662829;
					continue;
				case 148u:
					num = ((int)num2 * -1226097540) ^ 0x2724934C;
					continue;
				case 147u:
					SearchReciever_Admin.smethod_33(SearchResultGrid, Color.White);
					num = (int)(num2 * 754966067) ^ -1376476053;
					continue;
				case 146u:
					num = (int)((num2 * 1199687356) ^ 0x40DCE19);
					continue;
				case 145u:
					SearchReciever_Admin.smethod_24(Label4, (ContentAlignment)32);
					num = ((int)num2 * -629359535) ^ -206414133;
					continue;
				case 144u:
					IDTxt = SearchReciever_Admin.smethod_7();
					Label11 = SearchReciever_Admin.smethod_4();
					num = ((int)num2 * -1123449815) ^ -2136052187;
					continue;
				case 143u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_47((Control)(object)this), (Control)(object)SearchResultGrid);
					num = (int)((num2 * 652398056) ^ 0x64296D23);
					continue;
				case 142u:
					SearchReciever_Admin.smethod_32((ButtonBase)(object)DeleteBtn, bool_0: false);
					num = (int)((num2 * 106062828) ^ 0x2B8737F0);
					continue;
				case 141u:
					SearchReciever_Admin.smethod_22((Control)(object)SearchBtn, 4);
					num = ((int)num2 * -1316308505) ^ -1987029482;
					continue;
				case 140u:
					num = (int)((num2 * 886141680) ^ 0x7D643DCC);
					continue;
				case 139u:
					SearchReciever_Admin.smethod_22((Control)(object)NameSTxt, 1);
					num = (int)((num2 * 826080899) ^ 0x48ADF6BF);
					continue;
				case 138u:
					SearchReciever_Admin.smethod_24(Label3, (ContentAlignment)32);
					num = ((int)num2 * -577666743) ^ -1756933557;
					continue;
				case 137u:
					num = ((int)num2 * -1425758357) ^ -997620647;
					continue;
				case 136u:
					DeleteBtn = SearchReciever_Admin.smethod_6();
					num = (int)(num2 * 1310947869) ^ -2127574782;
					continue;
				case 135u:
					num = ((int)num2 * -1162379687) ^ 0x28D59C8C;
					continue;
				case 134u:
					num = (int)((num2 * 181249149) ^ 0x1854F8E4);
					continue;
				case 133u:
					SearchReciever_Admin.smethod_14((Control)(object)Label8, new Point(16, 78));
					num = (int)((num2 * 1849515231) ^ 0x17C6E658);
					continue;
				case 132u:
					SearchReciever_Admin.smethod_15((Control)(object)MobileSTxt, "MobileSTxt");
					num = ((int)num2 * -1847733127) ^ -298590265;
					continue;
				case 131u:
					SearchReciever_Admin.smethod_16((Control)(object)BloodGroupTxt, new Size(146, 30));
					num = ((int)num2 * -1856201169) ^ 0x80A7E22;
					continue;
				case 130u:
					SearchReciever_Admin.smethod_15((Control)(object)RecieverInfoBox, "RecieverInfoBox");
					num = ((int)num2 * -431808085) ^ 0x3A1077B4;
					continue;
				case 129u:
					SearchReciever_Admin.smethod_23(Label11, "ID :");
					num = (int)((num2 * 928163007) ^ 0x5906C4AD);
					continue;
				case 128u:
					num = (int)(num2 * 1330112095) ^ -986571418;
					continue;
				case 127u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)Label2);
					num = (int)(num2 * 1621238985) ^ -1929066585;
					continue;
				case 126u:
					num = (int)(num2 * 274984803) ^ -262236839;
					continue;
				case 125u:
					SearchReciever_Admin.smethod_43((Control)(object)UpdateBtn, bool_0: false);
					num = (int)((num2 * 1096641528) ^ 0x740B67AC);
					continue;
				case 124u:
					num = (int)(num2 * 1110887699) ^ -208614721;
					continue;
				case 123u:
					SearchReciever_Admin.smethod_15((Control)(object)GenderTxt, "GenderTxt");
					num = ((int)num2 * -1199932379) ^ 0x27BDEB01;
					continue;
				case 122u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)MobileTxt);
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)Label9);
					num = (int)(num2 * 2086881538) ^ -361362314;
					continue;
				case 121u:
					num = (int)((num2 * 1120753442) ^ 0x12D301F7);
					continue;
				case 120u:
					SearchReciever_Admin.smethod_14((Control)(object)SearchBtn, new Point(468, 82));
					num = (int)((num2 * 2117223977) ^ 0x4FE5B66B);
					continue;
				case 119u:
					RecieverInfoBox = SearchReciever_Admin.smethod_5();
					num = (int)((num2 * 652464320) ^ 0x7548852);
					continue;
				case 118u:
					SearchReciever_Admin.smethod_35(SearchResultGrid, bool_0: true);
					SearchReciever_Admin.smethod_37(SearchReciever_Admin.smethod_36(SearchResultGrid), 24);
					num = (int)((num2 * 1613343228) ^ 0x1B1982B3);
					continue;
				case 117u:
					SearchReciever_Admin.smethod_23(Label6, "Gender : ");
					num = ((int)num2 * -607256071) ^ 0x417A7A6A;
					continue;
				case 116u:
					SearchReciever_Admin.smethod_15((Control)(object)Label2, "Label2");
					SearchReciever_Admin.smethod_16((Control)(object)Label2, new Size(77, 28));
					num = ((int)num2 * -1012399739) ^ -1880457523;
					continue;
				case 115u:
					num = (int)(num2 * 1862717239) ^ -1946961688;
					continue;
				case 114u:
					SearchReciever_Admin.smethod_11((Control)(object)RecieverInfoBox);
					num = (int)(num2 * 1319565390) ^ -2141364109;
					continue;
				case 113u:
					SearchReciever_Admin.smethod_23(Label9, "Phone : ");
					num = ((int)num2 * -1865394696) ^ -1360988029;
					continue;
				case 112u:
					num = (int)(num2 * 696451737) ^ -1435143412;
					continue;
				case 111u:
					SearchReciever_Admin.smethod_52((Control)(object)GroupBox1);
					num = ((int)num2 * -168468594) ^ 0x637A91BA;
					continue;
				case 110u:
					SearchReciever_Admin.smethod_14((Control)(object)Label12, new Point(401, 217));
					num = (int)(num2 * 1011764044) ^ -118632382;
					continue;
				case 109u:
					SearchReciever_Admin.smethod_23(Label4, "Blood Group : ");
					num = ((int)num2 * -1354341639) ^ -2616817;
					continue;
				case 108u:
					SearchReciever_Admin.smethod_14((Control)(object)Label4, new Point(388, 164));
					num = ((int)num2 * -529939559) ^ -946179988;
					continue;
				case 107u:
					SearchReciever_Admin.smethod_14((Control)(object)UpdateBtn, new Point(808, 517));
					num = (int)((num2 * 1550804587) ^ 0x2019080E);
					continue;
				case 106u:
					SearchReciever_Admin.smethod_15((Control)(object)SearchBtn, "SearchBtn");
					SearchReciever_Admin.smethod_16((Control)(object)SearchBtn, new Size(133, 37));
					num = ((int)num2 * -1394561545) ^ -1228865230;
					continue;
				case 105u:
					Label10 = SearchReciever_Admin.smethod_4();
					num = (int)(num2 * 235188074) ^ -884738145;
					continue;
				case 104u:
					SearchReciever_Admin.smethod_30((Control)(object)UpdateBtn, Color.White);
					num = (int)(num2 * 298714049) ^ -1621049074;
					continue;
				case 103u:
					num = (int)((num2 * 1776687962) ^ 0x779878F8);
					continue;
				case 102u:
					NameSTxt = SearchReciever_Admin.smethod_7();
					Label2 = SearchReciever_Admin.smethod_4();
					num = (int)((num2 * 1425760884) ^ 0x5543E4AB);
					continue;
				case 101u:
					SearchReciever_Admin.smethod_22((Control)(object)IDTxt, 17);
					SearchReciever_Admin.smethod_21((Control)(object)Label11, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchReciever_Admin.smethod_14((Control)(object)Label11, new Point(16, 36));
					SearchReciever_Admin.smethod_15((Control)(object)Label11, "Label11");
					num = ((int)num2 * -1371108887) ^ -1526867036;
					continue;
				case 100u:
					num = (int)((num2 * 845247145) ^ 0x3CFDBCBB);
					continue;
				case 99u:
					num = ((int)num2 * -1341708418) ^ -1269428527;
					continue;
				case 98u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_47((Control)(object)this), (Control)(object)ClearBtn);
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_47((Control)(object)this), (Control)(object)DeleteBtn);
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_47((Control)(object)this), (Control)(object)RecieverInfoBox);
					num = (int)(num2 * 754714693) ^ -28223697;
					continue;
				case 97u:
					num = (int)(num2 * 844976408) ^ -671088789;
					continue;
				case 96u:
					MobileTxt = SearchReciever_Admin.smethod_7();
					num = ((int)num2 * -1153502870) ^ -1128325641;
					continue;
				case 95u:
					SearchReciever_Admin.smethod_23(Label2, "Name : ");
					SearchReciever_Admin.smethod_24(Label2, (ContentAlignment)32);
					num = (int)(num2 * 754093015) ^ -191661535;
					continue;
				case 94u:
					GenderTxt = SearchReciever_Admin.smethod_9();
					num = ((int)num2 * -1078670081) ^ -769244358;
					continue;
				case 93u:
					num = (int)(num2 * 2019837282) ^ -1030280126;
					continue;
				case 92u:
					SearchReciever_Admin.smethod_22((Control)(object)DeleteBtn, 15);
					num = ((int)num2 * -145094337) ^ -1324673627;
					continue;
				case 91u:
					num = (int)(num2 * 770807159) ^ -1297558236;
					continue;
				case 90u:
					num = ((int)num2 * -216543265) ^ -342837420;
					continue;
				case 89u:
					num = (int)((num2 * 1892881893) ^ 0x59D46132);
					continue;
				case 88u:
					SearchReciever_Admin.smethod_16((Control)(object)DeleteBtn, new Size(104, 37));
					num = (int)((num2 * 750879604) ^ 0x533FC739);
					continue;
				case 87u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)Label8);
					num = (int)(num2 * 1949244881) ^ -729776436;
					continue;
				case 86u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_47((Control)(object)this), (Control)(object)PictureBox1);
					num = (int)(num2 * 1760035827) ^ -12571214;
					continue;
				case 85u:
					SearchReciever_Admin.smethod_24(Label8, (ContentAlignment)32);
					num = ((int)num2 * -1121865543) ^ -2013959184;
					continue;
				case 84u:
					SearchReciever_Admin.smethod_16((Control)(object)QuantityTxt, new Size(169, 28));
					num = ((int)num2 * -1375426939) ^ 0x27D1A6E3;
					continue;
				case 83u:
					SearchReciever_Admin.smethod_10((ISupportInitialize)SearchResultGrid);
					num = (int)(num2 * 838141273) ^ -1059371094;
					continue;
				case 82u:
					SearchReciever_Admin.smethod_15((Control)(object)Label12, "Label12");
					num = (int)((num2 * 1912256244) ^ 0x61F9AFFD);
					continue;
				case 81u:
					num = (int)(num2 * 1688867367) ^ -858831515;
					continue;
				case 80u:
					num = ((int)num2 * -251252621) ^ -596536578;
					continue;
				case 79u:
					SearchReciever_Admin.smethod_16((Control)(object)IDTxt, new Size(204, 28));
					num = (int)(num2 * 905292301) ^ -1781108016;
					continue;
				case 78u:
					SearchReciever_Admin.smethod_11((Control)(object)GroupBox1);
					num = (int)((num2 * 75277945) ^ 0x7E373E04);
					continue;
				case 77u:
					num = ((int)num2 * -356511518) ^ -1259914024;
					continue;
				case 76u:
					num = (int)((num2 * 989846868) ^ 0x2DC07AB7);
					continue;
				case 75u:
					SearchReciever_Admin.smethod_32((ButtonBase)(object)SearchBtn, bool_0: false);
					num = (int)(num2 * 1416934016) ^ -2104455047;
					continue;
				case 74u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)Label3);
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)MobileSTxt);
					num = (int)(num2 * 1518477466) ^ -836003732;
					continue;
				case 73u:
					SearchReciever_Admin.smethod_14((Control)(object)Label1, new Point(392, 63));
					SearchReciever_Admin.smethod_15((Control)(object)Label1, "Label1");
					num = ((int)num2 * -1181743426) ^ -720175989;
					continue;
				case 72u:
					SearchReciever_Admin.smethod_21((Control)(object)Label3, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 390783235) ^ -435086690;
					continue;
				case 70u:
					num = ((int)num2 * -1751060212) ^ 0x36C437D;
					continue;
				case 69u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)BloodGroupTxt);
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)GenderTxt);
					num = ((int)num2 * -160369547) ^ -1781602704;
					continue;
				case 68u:
					SearchReciever_Admin.smethod_16((Control)(object)Label12, new Size(100, 26));
					num = (int)((num2 * 257802284) ^ 0x2FCAE940);
					continue;
				case 67u:
					SearchReciever_Admin.smethod_21((Control)(object)Label5, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 300381808) ^ -842563230;
					continue;
				case 66u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_47((Control)(object)this), (Control)(object)GroupBox1);
					num = ((int)num2 * -882658227) ^ -1110480299;
					continue;
				case 65u:
					SearchReciever_Admin.smethod_21((Control)(object)Label1, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1422344740) ^ -532923444;
					continue;
				case 64u:
					num = (int)(num2 * 1205911661) ^ -673234608;
					continue;
				case 63u:
					SearchReciever_Admin.smethod_30((Control)(object)DeleteBtn, Color.White);
					SearchReciever_Admin.smethod_14((Control)(object)DeleteBtn, new Point(808, 584));
					num = (int)((num2 * 2020498200) ^ 0x7F673652);
					continue;
				case 62u:
					SearchReciever_Admin.smethod_31((ButtonBase)(object)SearchBtn, "Search");
					num = (int)(num2 * 1677191329) ^ -795771118;
					continue;
				case 61u:
					SearchBtn = SearchReciever_Admin.smethod_6();
					num = ((int)num2 * -609258426) ^ 0x2951747E;
					continue;
				case 60u:
					num = ((int)num2 * -1662040168) ^ -896772307;
					continue;
				case 59u:
					SearchReciever_Admin.smethod_24(Label1, (ContentAlignment)32);
					num = (int)((num2 * 2036871358) ^ 0x6F76C166);
					continue;
				case 58u:
					UpdateBtn = SearchReciever_Admin.smethod_6();
					num = ((int)num2 * -821428054) ^ -1924847950;
					continue;
				case 57u:
					MobileSTxt = SearchReciever_Admin.smethod_7();
					num = (int)((num2 * 1736650352) ^ 0x270444B3);
					continue;
				case 56u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)Label12);
					num = ((int)num2 * -1867914852) ^ 0x17B2249;
					continue;
				case 55u:
					DateRecievedTxt = SearchReciever_Admin.smethod_7();
					Label8 = SearchReciever_Admin.smethod_4();
					num = (int)((num2 * 241400996) ^ 0x29ACE07D);
					continue;
				case 54u:
					num = ((int)num2 * -540897128) ^ -1575439629;
					continue;
				case 53u:
					num = (int)(num2 * 1986633991) ^ -1316711938;
					continue;
				case 52u:
					SearchReciever_Admin.smethod_15((Control)(object)DateRecievedTxt, "DateRecievedTxt");
					num = (int)(num2 * 136410512) ^ -838334768;
					continue;
				case 51u:
					SearchReciever_Admin.smethod_15((Control)(object)Label10, "Label10");
					SearchReciever_Admin.smethod_16((Control)(object)Label10, new Size(174, 25));
					num = (int)(num2 * 592150911) ^ -164699426;
					continue;
				case 50u:
					num = (int)(num2 * 1284320427) ^ -264851930;
					continue;
				case 49u:
					num = (int)((num2 * 670031425) ^ 0x7D0A7D7B);
					continue;
				case 48u:
					SearchReciever_Admin.smethod_15((Control)(object)PictureBox1, "PictureBox1");
					SearchReciever_Admin.smethod_16((Control)(object)PictureBox1, new Size(197, 126));
					num = (int)(num2 * 1579142408) ^ -1952905642;
					continue;
				case 47u:
					SearchReciever_Admin.smethod_29((ButtonBase)(object)UpdateBtn, Color.MidnightBlue);
					SearchReciever_Admin.smethod_21((Control)(object)UpdateBtn, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 736772732) ^ -756930982;
					continue;
				case 46u:
					SearchReciever_Admin.smethod_15((Control)(object)DeleteBtn, "DeleteBtn");
					num = (int)((num2 * 637909408) ^ 0xFD518A5);
					continue;
				case 45u:
					num = (int)(num2 * 180938706) ^ -764885947;
					continue;
				case 44u:
					QuantityTxt = SearchReciever_Admin.smethod_7();
					Label12 = SearchReciever_Admin.smethod_4();
					num = ((int)num2 * -1380680425) ^ 0xE4C53ED;
					continue;
				case 43u:
					num = (int)(num2 * 656790373) ^ -1090935137;
					continue;
				case 42u:
					num = ((int)num2 * -1257069865) ^ -957879540;
					continue;
				case 41u:
					num = (int)(num2 * 780290673) ^ -806120078;
					continue;
				case 40u:
					num = (int)(num2 * 174842787) ^ -270447204;
					continue;
				case 39u:
					SearchReciever_Admin.smethod_15((Control)(object)Label4, "Label4");
					num = ((int)num2 * -610312333) ^ -1912122579;
					continue;
				case 38u:
					SearchReciever_Admin.smethod_15((Control)(object)NameTxt, "NameTxt");
					num = (int)((num2 * 758425449) ^ 0x51D6C28B);
					continue;
				case 37u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)IDTxt);
					num = (int)((num2 * 1347384247) ^ 0x39AC9531);
					continue;
				case 36u:
					num = ((int)num2 * -241051182) ^ 0x6944A94D;
					continue;
				case 35u:
					ClearBtn = SearchReciever_Admin.smethod_6();
					num = (int)((num2 * 879308014) ^ 0x6D8515D1);
					continue;
				case 34u:
					num = (int)(num2 * 951727037) ^ -597535619;
					continue;
				case 33u:
					num = (int)(num2 * 1308998975) ^ -1777477144;
					continue;
				case 32u:
					SearchReciever_Admin.smethod_22((Control)(object)MobileTxt, 12);
					num = (int)(num2 * 282721922) ^ -1425362325;
					continue;
				case 31u:
					SearchReciever_Admin.smethod_14((Control)(object)MobileTxt, new Point(117, 124));
					SearchReciever_Admin.smethod_15((Control)(object)MobileTxt, "MobileTxt");
					num = ((int)num2 * -558828214) ^ -1681977641;
					continue;
				case 30u:
					SearchReciever_Admin.smethod_16((Control)(object)Label11, new Size(68, 25));
					num = ((int)num2 * -1412642500) ^ -235253249;
					continue;
				case 29u:
					num = (int)((num2 * 562128146) ^ 0x62F2CD7);
					continue;
				case 28u:
					SearchReciever_Admin.smethod_15((Control)(object)NameSTxt, "NameSTxt");
					num = (int)(num2 * 1547102221) ^ -1514995245;
					continue;
				case 27u:
					num = ((int)num2 * -13755725) ^ -514192622;
					continue;
				case 26u:
					SearchReciever_Admin.smethod_15((Control)(object)QuantityTxt, "QuantityTxt");
					SearchReciever_Admin.smethod_42((TextBoxBase)(object)QuantityTxt, bool_0: true);
					num = (int)(num2 * 906166734) ^ -136635275;
					continue;
				case 25u:
					SearchReciever_Admin.smethod_22((Control)(object)Label8, 9);
					num = (int)(num2 * 1799401905) ^ -1702615332;
					continue;
				case 24u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)Label10);
					num = (int)(num2 * 2057527406) ^ -798096456;
					continue;
				case 23u:
					SearchReciever_Admin.smethod_22((Control)(object)DateRecievedTxt, 10);
					num = ((int)num2 * -806300555) ^ 0x67FB68E2;
					continue;
				case 22u:
					SearchReciever_Admin.smethod_15((Control)(object)Label5, "Label5");
					SearchReciever_Admin.smethod_16((Control)(object)Label5, new Size(84, 26));
					num = (int)((num2 * 1939451470) ^ 0x4299F375);
					continue;
				case 21u:
					SearchReciever_Admin.smethod_16((Control)(object)Label1, new Size(330, 47));
					SearchReciever_Admin.smethod_22((Control)(object)Label1, 8);
					num = ((int)num2 * -465920768) ^ 0x56DB106E;
					continue;
				case 20u:
					SearchReciever_Admin.smethod_15((Control)(object)GroupBox1, "GroupBox1");
					SearchReciever_Admin.smethod_16((Control)(object)GroupBox1, new Size(623, 128));
					num = ((int)num2 * -1114062264) ^ -338261010;
					continue;
				case 19u:
					SearchReciever_Admin.smethod_22((Control)(object)Label10, 0);
					num = (int)(num2 * 1079782029) ^ -1913589674;
					continue;
				case 18u:
					SearchReciever_Admin.smethod_29((ButtonBase)(object)DeleteBtn, Color.MidnightBlue);
					num = ((int)num2 * -1885888809) ^ 0x39D41D4C;
					continue;
				case 17u:
					num = (int)(num2 * 843734038) ^ -1553558748;
					continue;
				case 16u:
					SearchReciever_Admin.smethod_22((Control)(object)Label5, 1);
					num = (int)(num2 * 1544077694) ^ -1000094785;
					continue;
				case 15u:
					SearchReciever_Admin.smethod_22((Control)(object)UpdateBtn, 17);
					num = (int)(num2 * 244563134) ^ -917902377;
					continue;
				case 14u:
					SearchReciever_Admin.smethod_22((Control)(object)Label4, 13);
					num = (int)((num2 * 1045153580) ^ 0x148973EB);
					continue;
				case 13u:
					num = ((int)num2 * -1463222089) ^ -679871362;
					continue;
				case 12u:
					num = ((int)num2 * -1794938589) ^ 0x75D5ED31;
					continue;
				case 11u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)Label5);
					num = ((int)num2 * -721423291) ^ -1090842198;
					continue;
				case 10u:
					SearchReciever_Admin.smethod_38(BloodGroupTxt, (ComboBoxStyle)2);
					num = (int)(num2 * 477408050) ^ -1020089844;
					continue;
				case 9u:
					SearchReciever_Admin.smethod_32((ButtonBase)(object)ClearBtn, bool_0: false);
					num = (int)(num2 * 122992500) ^ -1611626434;
					continue;
				case 8u:
					num = (int)(num2 * 607918092) ^ -1436933694;
					continue;
				case 7u:
					SearchReciever_Admin.smethod_10((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -873723160) ^ 0x78AC68FD;
					continue;
				case 6u:
					SearchReciever_Admin.smethod_14((Control)(object)NameSTxt, new Point(120, 44));
					num = (int)(num2 * 1130693745) ^ -1411305549;
					continue;
				case 5u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)DateRecievedTxt);
					num = ((int)num2 * -974895940) ^ 0x2C437D00;
					continue;
				case 4u:
					SearchReciever_Admin.smethod_14((Control)(object)BloodGroupTxt, new Point(531, 164));
					num = (int)((num2 * 291931977) ^ 0x16A1904B);
					continue;
				case 3u:
					num = ((int)num2 * -203167819) ^ -1097811462;
					continue;
				case 2u:
					Label5 = SearchReciever_Admin.smethod_4();
					num = ((int)num2 * -1997521014) ^ -340288062;
					continue;
				case 1u:
					SearchReciever_Admin.smethod_14((Control)(object)DOBTxt, new Point(117, 167));
					num = ((int)num2 * -801997475) ^ 0x9E89663;
					continue;
				case 0u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_47((Control)(object)this), (Control)(object)Label1);
					num = ((int)num2 * -1189307595) ^ -1521045435;
					continue;
				case 225u:
					break;
				default:
					SearchReciever_Admin.smethod_53((Control)(object)this, bool_0: false);
					return;
				}
				break;
			}
		}
	}

	private void SearchDonor_Admin_Load(object sender, EventArgs e)
	{
		SearchReciever_Admin.smethod_59(myconnection, SearchReciever_Admin.smethod_58(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
		while (true)
		{
			int num = 636108721;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x271F183Au) % 4u)
				{
				case 3u:
					num = ((int)num2 * -2146542365) ^ 0x2DCE7E7E;
					continue;
				case 1u:
					HideItemsOnForm();
					num = (int)((num2 * 1512297500) ^ 0x53C2CF90);
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

	private bool HideItemsOnForm()
	{
		bool result = default(bool);
		while (true)
		{
			int num = -356014168;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF9E5991Cu) % 9u)
				{
				case 8u:
					SearchReciever_Admin.smethod_43((Control)(object)ClearBtn, bool_0: false);
					num = (int)((num2 * 1334941900) ^ 0x5B57D82A);
					continue;
				case 7u:
					SearchReciever_Admin.smethod_43((Control)(object)RecieverInfoBox, bool_0: false);
					num = (int)(num2 * 116515237) ^ -694103867;
					continue;
				case 6u:
					num = (int)(num2 * 104020868) ^ -391022469;
					continue;
				case 5u:
					result = true;
					num = ((int)num2 * -2139956227) ^ -331618927;
					continue;
				case 3u:
					num = ((int)num2 * -1782665604) ^ -34210083;
					continue;
				case 1u:
					SearchReciever_Admin.smethod_43((Control)(object)SearchResultGrid, bool_0: false);
					num = ((int)num2 * -1338905739) ^ 0x6D53646E;
					continue;
				case 0u:
					SearchReciever_Admin.smethod_43((Control)(object)DeleteBtn, bool_0: false);
					SearchReciever_Admin.smethod_43((Control)(object)UpdateBtn, bool_0: false);
					num = ((int)num2 * -414341664) ^ -1057408409;
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

	private void SearchBtn_Click(object sender, EventArgs e)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected I4, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected I4, but got Unknown
		//IL_035d: Incompatible stack heights: 0 vs 1
		//IL_0372: Incompatible stack heights: 0 vs 1
		//IL_0379: Incompatible stack heights: 0 vs 1
		DataTable dataTable = default(DataTable);
		string string_ = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = -159907391;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF5BDA6F8u) % 12u)
				{
				case 11u:
					SearchReciever_Admin.smethod_66(myconnection);
					num = ((int)num2 * -1785005213) ^ 0x1700D0F;
					continue;
				case 10u:
					HideItemsOnForm();
					num = -1742101044;
					continue;
				case 9u:
					name_search = SearchReciever_Admin.smethod_61(SearchReciever_Admin.smethod_60(NameSTxt));
					num = ((int)num2 * -1085761406) ^ -907463237;
					continue;
				case 8u:
					dataTable = SearchReciever_Admin.smethod_65();
					num = (int)((num2 * 104999419) ^ 0x348313B7);
					continue;
				case 7u:
					SearchReciever_Admin.smethod_62("No Results Found");
					num = (int)(num2 * 676231681) ^ -578350384;
					continue;
				case 6u:
					string_ = SearchReciever_Admin.smethod_64(new string[5]
					{
						"Select * From [Recievers] Where [Name] Like '%",
						SearchReciever_Admin.smethod_61(SearchReciever_Admin.smethod_60(NameSTxt)),
						"%' And [Contact Number] Like '%",
						SearchReciever_Admin.smethod_60(MobileSTxt),
						"%';"
					});
					num = (int)(num2 * 1009354024) ^ -1253206616;
					continue;
				case 5u:
					mobile_search = SearchReciever_Admin.smethod_61(SearchReciever_Admin.smethod_60(MobileSTxt));
					num = (int)(num2 * 1074043223) ^ -2005303503;
					continue;
				case 1u:
				{
					int num6;
					int num7;
					if (!(!MyProject.Forms.Form1.Name_Validation(SearchReciever_Admin.smethod_61(SearchReciever_Admin.smethod_60(NameSTxt))) | !MyProject.Forms.Form1.Mobile_Validator(SearchReciever_Admin.smethod_61(SearchReciever_Admin.smethod_60(MobileSTxt)))))
					{
						num6 = -2032879068;
						num7 = -2032879068;
					}
					else
					{
						num6 = -700940159;
						num7 = -700940159;
					}
					num = num6 ^ ((int)num2 * -1553125542);
					continue;
				}
				case 0u:
					SearchReciever_Admin.smethod_63();
					num = (int)(num2 * 630420241) ^ -285866151;
					continue;
				case 4u:
					break;
				default:
					try
					{
						OleDbDataAdapter dbDataAdapter_ = SearchReciever_Admin.smethod_67(string_, myconnection);
						SearchReciever_Admin.smethod_68((DbDataAdapter)(object)dbDataAdapter_, dataTable);
						while (true)
						{
							int num3 = -968352035;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xF5BDA6F8u) % 11u)
								{
								case 10u:
									flag = SearchReciever_Admin.smethod_70(SearchResultGrid) == 1;
									num3 = (int)((num2 * 1787656550) ^ 0x51EBF30E);
									continue;
								case 9u:
									SearchReciever_Admin.smethod_71(myconnection);
									num3 = (int)(num2 * 1959745258) ^ -1686247649;
									continue;
								case 8u:
									num3 = (int)((num2 * 883623919) ^ 0x67B407B5);
									continue;
								case 6u:
								{
									int num4;
									int num5;
									if (flag)
									{
										num4 = -1901929212;
										num5 = -1901929212;
									}
									else
									{
										num4 = -1766939783;
										num5 = -1766939783;
									}
									num3 = num4 ^ ((int)num2 * -149765677);
									continue;
								}
								case 5u:
									SearchReciever_Admin.smethod_62("No Result Found");
									num3 = ((int)num2 * -1157682171) ^ 0x2A0E073D;
									continue;
								case 3u:
									SearchReciever_Admin.smethod_43((Control)(object)SearchResultGrid, bool_0: true);
									num3 = (int)((num2 * 992995313) ^ 0x3216D155);
									continue;
								case 2u:
									SearchReciever_Admin.smethod_69(SearchResultGrid, (object)dataTable);
									num3 = ((int)num2 * -2013569977) ^ 0x3CCF9E7;
									continue;
								case 1u:
									num3 = -203257279;
									continue;
								case 7u:
									break;
								default:
									SearchReciever_Admin.smethod_71(myconnection);
									return;
								case 4u:
									return;
								}
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						SearchReciever_Admin.smethod_72(exception_);
						SearchReciever_Admin.smethod_71(myconnection);
						while (true)
						{
							_ = -1380609019;
							while (true)
							{
								_003F val = /*Error near IL_0333: Stack underflow*/^ -172120328;
								num2 = (uint)(int)val;
								switch (val % 4)
								{
								default:
									return;
								case 1:
									_ = ((int)num2 * -375520198) ^ 0x6DEECE7E;
									continue;
								case 0:
									SearchReciever_Admin.smethod_73();
									_ = ((int)num2 * -1981657488) ^ 0x111EC3E6;
									continue;
								case 3:
									break;
								case 2:
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

	private void UpdateBtn_Click(object sender, EventArgs e)
	{
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected I4, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected I4, but got Unknown
		//IL_0368: Incompatible stack heights: 0 vs 1
		//IL_0383: Incompatible stack heights: 0 vs 1
		//IL_038a: Incompatible stack heights: 0 vs 1
		bool flag = (SearchReciever_Admin.smethod_74(SearchReciever_Admin.smethod_60(NameTxt), "", bool_0: false) == 0) | (SearchReciever_Admin.smethod_74(SearchReciever_Admin.smethod_60(MobileTxt), "", bool_0: false) == 0) | (SearchReciever_Admin.smethod_74(SearchReciever_Admin.smethod_75(GenderTxt), "", bool_0: false) == 0) | (SearchReciever_Admin.smethod_74(SearchReciever_Admin.smethod_60(DOBTxt), "", bool_0: false) == 0) | (SearchReciever_Admin.smethod_74(SearchReciever_Admin.smethod_75(BloodGroupTxt), "", bool_0: false) == 0);
		bool flag2 = default(bool);
		string string_ = default(string);
		while (true)
		{
			int num = 1059209374;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2E7E29EBu) % 10u)
				{
				case 9u:
					flag2 = !(MyProject.Forms.Form1.Name_Validation(SearchReciever_Admin.smethod_61(SearchReciever_Admin.smethod_60(NameTxt))) & MyProject.Forms.Form1.Mobile_Validator(SearchReciever_Admin.smethod_60(MobileTxt)) & MyProject.Forms.Form1.age_validator(SearchReciever_Admin.smethod_60(DOBTxt)));
					num = 1757552608;
					continue;
				case 7u:
					SearchReciever_Admin.smethod_62("Fields Cannot be empty");
					num = (int)((num2 * 1045825785) ^ 0x4A3D327C);
					continue;
				case 5u:
				{
					OleDbCommand val = SearchReciever_Admin.smethod_63();
					string_ = SearchReciever_Admin.smethod_64(new string[13]
					{
						"Update [Recievers] Set [Name] = '",
						SearchReciever_Admin.smethod_60(NameTxt),
						"', [Contact Number] = '",
						SearchReciever_Admin.smethod_60(MobileTxt),
						"', [Age] = ",
						SearchReciever_Admin.smethod_60(DOBTxt),
						", [Gender] = '",
						SearchReciever_Admin.smethod_75(GenderTxt),
						"', [Blood Group] = '",
						SearchReciever_Admin.smethod_75(BloodGroupTxt),
						"' Where [ID] = ",
						SearchReciever_Admin.smethod_60(IDTxt),
						";"
					});
					num = 250293595;
					continue;
				}
				case 3u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = -1639937734;
						num7 = -1639937734;
					}
					else
					{
						num6 = -1724102807;
						num7 = -1724102807;
					}
					num = num6 ^ ((int)num2 * -1164295109);
					continue;
				}
				case 2u:
					SearchReciever_Admin.smethod_62("Invalid Credentitals");
					num = (int)(num2 * 560447982) ^ -1478846777;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -57786839;
						num5 = -57786839;
					}
					else
					{
						num4 = -1468084615;
						num5 = -1468084615;
					}
					num = num4 ^ ((int)num2 * -1212058035);
					continue;
				}
				case 0u:
					break;
				default:
					SearchReciever_Admin.smethod_66(myconnection);
					try
					{
						OleDbCommand val = SearchReciever_Admin.smethod_76(string_, myconnection);
						SearchReciever_Admin.smethod_77(val);
						while (true)
						{
							int num3 = 263335876;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x2E7E29EBu) % 7u)
								{
								case 6u:
									SearchReciever_Admin.smethod_71(myconnection);
									num3 = ((int)num2 * -910147299) ^ -311063406;
									continue;
								case 4u:
									ClearDonorInfoBox();
									num3 = ((int)num2 * -1087030180) ^ -517513560;
									continue;
								case 3u:
									num3 = ((int)num2 * -1034769244) ^ 0x5BA4D788;
									continue;
								case 1u:
									SearchReciever_Admin.smethod_78((Component)(object)val);
									num3 = (int)((num2 * 1150393116) ^ 0x3BDEA2C2);
									continue;
								case 0u:
									UpdateTable();
									SearchReciever_Admin.smethod_62("Successfully Updated Details");
									num3 = ((int)num2 * -1317997091) ^ -516655471;
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
					catch (Exception exception_)
					{
						SearchReciever_Admin.smethod_72(exception_);
						while (true)
						{
							_ = 127641214;
							while (true)
							{
								_003F val2 = /*Error near IL_0339: Stack underflow*/^ 0x2E7E29EB;
								num2 = (uint)(int)val2;
								switch (val2 % 4)
								{
								default:
									return;
								case 3:
									SearchReciever_Admin.smethod_73();
									_ = (num2 * 1563432711) ^ 0xEAE9B220u;
									continue;
								case 1:
									SearchReciever_Admin.smethod_71(myconnection);
									_ = ((int)num2 * -936621437) ^ -1856510209;
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
				case 4u:
				case 8u:
					return;
				}
				break;
			}
		}
	}

	private void DeleteBtn_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected I4, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected I4, but got Unknown
		//IL_01f5: Incompatible stack heights: 0 vs 1
		//IL_0210: Incompatible stack heights: 0 vs 1
		//IL_0217: Incompatible stack heights: 0 vs 1
		string string_ = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = -731492156;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF57D2725u) % 9u)
				{
				case 8u:
					SearchReciever_Admin.smethod_62("Nothing To Delete");
					num = ((int)num2 * -1708409784) ^ -1433197144;
					continue;
				case 7u:
					string_ = SearchReciever_Admin.smethod_79("Delete From [Recievers] Where [ID] = ", SearchReciever_Admin.smethod_60(IDTxt), ";");
					num = (int)(num2 * 1700097775) ^ -736782163;
					continue;
				case 6u:
				{
					OleDbCommand val = SearchReciever_Admin.smethod_63();
					num = -1081296003;
					continue;
				}
				case 5u:
					flag = SearchReciever_Admin.smethod_74(SearchReciever_Admin.smethod_60(IDTxt), "", bool_0: false) == 0;
					num = ((int)num2 * -626655846) ^ 0x1E04B720;
					continue;
				case 4u:
					SearchReciever_Admin.smethod_66(myconnection);
					num = (int)(num2 * 1828564726) ^ -1732723945;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1512619099;
						num5 = 1512619099;
					}
					else
					{
						num4 = 1902781813;
						num5 = 1902781813;
					}
					num = num4 ^ (int)(num2 * 1033609435);
					continue;
				}
				case 0u:
					break;
				default:
					try
					{
						OleDbCommand val = SearchReciever_Admin.smethod_76(string_, myconnection);
						while (true)
						{
							int num3 = -1603313399;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xF57D2725u) % 6u)
								{
								case 5u:
									SearchReciever_Admin.smethod_71(myconnection);
									UpdateTable();
									num3 = ((int)num2 * -1414190396) ^ 0x14B14C44;
									continue;
								case 4u:
									SearchReciever_Admin.smethod_77(val);
									num3 = ((int)num2 * -161974835) ^ 0x125C9DF5;
									continue;
								case 1u:
									ClearDonorInfoBox();
									SearchReciever_Admin.smethod_62("Successfully Deleted Entry");
									num3 = (int)(num2 * 1378805911) ^ -1276407911;
									continue;
								case 0u:
									SearchReciever_Admin.smethod_78((Component)(object)val);
									num3 = ((int)num2 * -1725528501) ^ 0x36E6261C;
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
					catch (Exception exception_)
					{
						SearchReciever_Admin.smethod_72(exception_);
						while (true)
						{
							_ = -903963816;
							while (true)
							{
								_003F val2 = /*Error near IL_01c6: Stack underflow*/^ -176347355;
								num2 = (uint)(int)val2;
								switch (val2 % 4)
								{
								default:
									return;
								case 2:
									SearchReciever_Admin.smethod_73();
									_ = ((int)num2 * -1001638247) ^ 0x2AB7492B;
									continue;
								case 1:
									SearchReciever_Admin.smethod_71(myconnection);
									_ = (num2 * 1563788178) ^ 0x73AB57DD;
									continue;
								case 3:
									break;
								case 0:
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

	private void SearchResultGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected I4, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected I4, but got Unknown
		//IL_0337: Incompatible stack heights: 0 vs 1
		//IL_033e: Incompatible stack heights: 0 vs 1
		try
		{
			while (true)
			{
				int num = 92797715;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x64BDC236u) % 14u)
					{
					case 12u:
						SearchReciever_Admin.smethod_88(BloodGroupTxt, SearchReciever_Admin.smethod_86(SearchReciever_Admin.smethod_85(SearchReciever_Admin.smethod_84(SearchReciever_Admin.smethod_83(SearchReciever_Admin.smethod_82(SearchReciever_Admin.smethod_80(SearchResultGrid), SearchReciever_Admin.smethod_81(e))), 4))));
						num = (int)((num2 * 757918161) ^ 0x3DDC4E6B);
						continue;
					case 11u:
						num = ((int)num2 * -407802657) ^ -1299037515;
						continue;
					case 10u:
						SearchReciever_Admin.smethod_88(GenderTxt, SearchReciever_Admin.smethod_86(SearchReciever_Admin.smethod_85(SearchReciever_Admin.smethod_84(SearchReciever_Admin.smethod_83(SearchReciever_Admin.smethod_82(SearchReciever_Admin.smethod_80(SearchResultGrid), SearchReciever_Admin.smethod_81(e))), 2))));
						num = (int)((num2 * 2081162763) ^ 0x629FF98B);
						continue;
					case 9u:
						SearchReciever_Admin.smethod_87(IDTxt, SearchReciever_Admin.smethod_86(SearchReciever_Admin.smethod_85(SearchReciever_Admin.smethod_84(SearchReciever_Admin.smethod_83(SearchReciever_Admin.smethod_82(SearchReciever_Admin.smethod_80(SearchResultGrid), SearchReciever_Admin.smethod_81(e))), 0))));
						num = ((int)num2 * -888026400) ^ 0x6823BB03;
						continue;
					case 8u:
						SearchReciever_Admin.smethod_87(NameTxt, SearchReciever_Admin.smethod_86(SearchReciever_Admin.smethod_85(SearchReciever_Admin.smethod_84(SearchReciever_Admin.smethod_83(SearchReciever_Admin.smethod_82(SearchReciever_Admin.smethod_80(SearchResultGrid), SearchReciever_Admin.smethod_81(e))), 1))));
						num = (int)(num2 * 603339599) ^ -1668939695;
						continue;
					case 7u:
						num = ((int)num2 * -204469902) ^ -809355734;
						continue;
					case 6u:
						SearchReciever_Admin.smethod_43((Control)(object)UpdateBtn, bool_0: true);
						SearchReciever_Admin.smethod_43((Control)(object)DeleteBtn, bool_0: true);
						num = ((int)num2 * -928835702) ^ 0x34F053F7;
						continue;
					case 5u:
						SearchReciever_Admin.smethod_87(MobileTxt, SearchReciever_Admin.smethod_86(SearchReciever_Admin.smethod_85(SearchReciever_Admin.smethod_84(SearchReciever_Admin.smethod_83(SearchReciever_Admin.smethod_82(SearchReciever_Admin.smethod_80(SearchResultGrid), SearchReciever_Admin.smethod_81(e))), 5))));
						SearchReciever_Admin.smethod_87(DateRecievedTxt, SearchReciever_Admin.smethod_86(SearchReciever_Admin.smethod_85(SearchReciever_Admin.smethod_84(SearchReciever_Admin.smethod_83(SearchReciever_Admin.smethod_82(SearchReciever_Admin.smethod_80(SearchResultGrid), SearchReciever_Admin.smethod_81(e))), 7))));
						num = (int)((num2 * 746955689) ^ 0x709F9FC0);
						continue;
					case 3u:
						SearchReciever_Admin.smethod_87(DOBTxt, SearchReciever_Admin.smethod_86(SearchReciever_Admin.smethod_85(SearchReciever_Admin.smethod_84(SearchReciever_Admin.smethod_83(SearchReciever_Admin.smethod_82(SearchReciever_Admin.smethod_80(SearchResultGrid), SearchReciever_Admin.smethod_81(e))), 3))));
						num = ((int)num2 * -2045174183) ^ 0x6297C5F;
						continue;
					case 2u:
						SearchReciever_Admin.smethod_87(QuantityTxt, SearchReciever_Admin.smethod_86(SearchReciever_Admin.smethod_85(SearchReciever_Admin.smethod_84(SearchReciever_Admin.smethod_83(SearchReciever_Admin.smethod_82(SearchReciever_Admin.smethod_80(SearchResultGrid), SearchReciever_Admin.smethod_81(e))), 6))));
						num = ((int)num2 * -262864785) ^ -1341447660;
						continue;
					case 1u:
						num = ((int)num2 * -1715380570) ^ 0x7EC82724;
						continue;
					case 0u:
						SearchReciever_Admin.smethod_43((Control)(object)RecieverInfoBox, bool_0: true);
						SearchReciever_Admin.smethod_43((Control)(object)ClearBtn, bool_0: true);
						num = ((int)num2 * -1399519571) ^ 0x45A7BA98;
						continue;
					default:
						return;
					case 4u:
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
			SearchReciever_Admin.smethod_72(exception_);
			while (true)
			{
				_ = 1527845856;
				while (true)
				{
					_003F val = /*Error near IL_0313: Stack underflow*/^ 0x64BDC236;
					uint num2 = (uint)(int)val;
					switch (val % 3)
					{
					case 1:
						_ = (num2 * 276501557) ^ 0xDC44E935u;
						continue;
					case 2:
						break;
					default:
						SearchReciever_Admin.smethod_73();
						return;
					}
					break;
				}
			}
		}
	}

	private void ClearBtn_Click(object sender, EventArgs e)
	{
		ClearDonorInfoBox();
	}

	private bool ClearDonorInfoBox()
	{
		bool result = default(bool);
		while (true)
		{
			int num = 835778128;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3EC32118u) % 14u)
				{
				case 13u:
					SearchReciever_Admin.smethod_89((TextBoxBase)(object)DateRecievedTxt);
					num = ((int)num2 * -1253656731) ^ -940696833;
					continue;
				case 12u:
					SearchReciever_Admin.smethod_89((TextBoxBase)(object)IDTxt);
					num = (int)((num2 * 1153716684) ^ 0x358E847F);
					continue;
				case 11u:
					SearchReciever_Admin.smethod_89((TextBoxBase)(object)DOBTxt);
					num = ((int)num2 * -1617355719) ^ 0x70D7B3EC;
					continue;
				case 10u:
					num = ((int)num2 * -145395491) ^ 0x20EE51CE;
					continue;
				case 9u:
					SearchReciever_Admin.smethod_90(BloodGroupTxt, -1);
					num = ((int)num2 * -1060553173) ^ -2092141163;
					continue;
				case 8u:
					num = (int)(num2 * 1447190631) ^ -1728081968;
					continue;
				case 7u:
					SearchReciever_Admin.smethod_89((TextBoxBase)(object)NameTxt);
					num = ((int)num2 * -361586203) ^ -1655913685;
					continue;
				case 6u:
					SearchReciever_Admin.smethod_89((TextBoxBase)(object)MobileTxt);
					num = (int)(num2 * 1827548267) ^ -856676738;
					continue;
				case 4u:
					SearchReciever_Admin.smethod_90(GenderTxt, -1);
					num = (int)(num2 * 1075765563) ^ -586560993;
					continue;
				case 3u:
					result = true;
					num = ((int)num2 * -1146025571) ^ 0x1A6C4490;
					continue;
				case 2u:
					SearchReciever_Admin.smethod_89((TextBoxBase)(object)QuantityTxt);
					num = ((int)num2 * -2116217812) ^ -1172667621;
					continue;
				case 0u:
					num = ((int)num2 * -1522791627) ^ 0x58D5B85;
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

	private bool UpdateTable()
	{
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected I4, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected I4, but got Unknown
		//IL_017a: Incompatible stack heights: 0 vs 1
		//IL_018f: Incompatible stack heights: 0 vs 1
		//IL_0196: Incompatible stack heights: 0 vs 1
		SearchReciever_Admin.smethod_63();
		string string_ = default(string);
		bool result = default(bool);
		while (true)
		{
			int num = -357942090;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF0BFFDAFu) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 0u:
					break;
				default:
				{
					DataTable dataTable = SearchReciever_Admin.smethod_65();
					SearchReciever_Admin.smethod_66(myconnection);
					try
					{
						while (true)
						{
							IL_012a:
							int num3 = -1793367265;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xF0BFFDAFu) % 6u)
								{
								case 4u:
									SearchReciever_Admin.smethod_69(SearchResultGrid, (object)dataTable);
									num3 = (int)(num2 * 1938029757) ^ -455920939;
									continue;
								case 2u:
								{
									OleDbDataAdapter dbDataAdapter_ = SearchReciever_Admin.smethod_67(string_, myconnection);
									SearchReciever_Admin.smethod_68((DbDataAdapter)(object)dbDataAdapter_, dataTable);
									num3 = ((int)num2 * -1616760896) ^ -207839827;
									continue;
								}
								case 1u:
									SearchReciever_Admin.smethod_43((Control)(object)SearchResultGrid, bool_0: true);
									SearchReciever_Admin.smethod_71(myconnection);
									num3 = ((int)num2 * -1600279137) ^ 0x66813DCD;
									continue;
								case 0u:
									num3 = (int)(num2 * 1300048642) ^ -310061668;
									continue;
								default:
									goto end_IL_0100;
								case 5u:
									break;
								case 3u:
									goto end_IL_0100;
								}
								goto IL_012a;
								continue;
								end_IL_0100:
								break;
							}
							break;
						}
					}
					catch (Exception exception_)
					{
						SearchReciever_Admin.smethod_72(exception_);
						SearchReciever_Admin.smethod_71(myconnection);
						while (true)
						{
							IL_0191:
							_ = -1829418796;
							while (true)
							{
								_003F val = /*Error near IL_0150: Stack underflow*/^ -255853137;
								num2 = (uint)(int)val;
								switch (val % 4)
								{
								default:
									goto end_IL_014a;
								case 3:
									_ = (num2 * 384259770) ^ 0x1168DEAD;
									continue;
								case 0:
									SearchReciever_Admin.smethod_73();
									_ = ((int)num2 * -727906230) ^ -1088347346;
									continue;
								case 2:
									break;
								case 1:
									goto end_IL_014a;
								}
								goto IL_0191;
								continue;
								end_IL_014a:
								break;
							}
							break;
						}
					}
					while (true)
					{
						int num4 = -2080271373;
						while (true)
						{
							switch ((num2 = (uint)num4 ^ 0xF0BFFDAFu) % 3u)
							{
							case 1u:
								goto IL_019a;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_019a:
							result = true;
							num4 = (int)((num2 * 982818389) ^ 0x1709C559);
						}
					}
				}
				}
				break;
				IL_0008:
				string_ = SearchReciever_Admin.smethod_64(new string[5] { "Select * From [Recievers] Where [Name] Like '%", name_search, "%' And [Contact Number] Like '%", mobile_search, "%';" });
				num = ((int)num2 * -440966746) ^ 0xA6125B8;
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

	static DataGridView smethod_8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DataGridView();
	}

	static ComboBox smethod_9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ComboBox();
	}

	static void smethod_10(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_11(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_12(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_13(PictureBox pictureBox_0, Image image_0)
	{
		pictureBox_0.set_Image(image_0);
	}

	static void smethod_14(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_15(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_16(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_17(PictureBox pictureBox_0, PictureBoxSizeMode pictureBoxSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		pictureBox_0.set_SizeMode(pictureBoxSizeMode_0);
	}

	static void smethod_18(PictureBox pictureBox_0, int int_0)
	{
		pictureBox_0.set_TabIndex(int_0);
	}

	static void smethod_19(PictureBox pictureBox_0, bool bool_0)
	{
		pictureBox_0.set_TabStop(bool_0);
	}

	static Font smethod_20(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_21(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_22(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_23(Label label_0, string string_0)
	{
		label_0.set_Text(string_0);
	}

	static void smethod_24(Label label_0, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_TextAlign(contentAlignment_0);
	}

	static ControlCollection smethod_25(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_26(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_27(GroupBox groupBox_0, bool bool_0)
	{
		groupBox_0.set_TabStop(bool_0);
	}

	static void smethod_28(GroupBox groupBox_0, string string_0)
	{
		groupBox_0.set_Text(string_0);
	}

	static void smethod_29(ButtonBase buttonBase_0, Color color_0)
	{
		buttonBase_0.set_BackColor(color_0);
	}

	static void smethod_30(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
	}

	static void smethod_31(ButtonBase buttonBase_0, string string_0)
	{
		buttonBase_0.set_Text(string_0);
	}

	static void smethod_32(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
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

	static void smethod_38(ComboBox comboBox_0, ComboBoxStyle comboBoxStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		comboBox_0.set_DropDownStyle(comboBoxStyle_0);
	}

	static void smethod_39(ListControl listControl_0, bool bool_0)
	{
		listControl_0.set_FormattingEnabled(bool_0);
	}

	static ObjectCollection smethod_40(ComboBox comboBox_0)
	{
		return comboBox_0.get_Items();
	}

	static void smethod_41(ObjectCollection objectCollection_0, object[] object_0)
	{
		objectCollection_0.AddRange(object_0);
	}

	static void smethod_42(TextBoxBase textBoxBase_0, bool bool_0)
	{
		textBoxBase_0.set_ReadOnly(bool_0);
	}

	static void smethod_43(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static void smethod_44(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_45(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_46(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
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

	static void smethod_50(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_51(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_52(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_53(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_54(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_55(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_56(DataGridView dataGridView_0, DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler_0)
	{
		dataGridView_0.remove_CellMouseClick(dataGridViewCellMouseEventHandler_0);
	}

	static void smethod_57(DataGridView dataGridView_0, DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler_0)
	{
		dataGridView_0.add_CellMouseClick(dataGridViewCellMouseEventHandler_0);
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

	static void smethod_72(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_73()
	{
		ProjectData.ClearProjectError();
	}

	static int smethod_74(string string_0, string string_1, bool bool_0)
	{
		return Operators.CompareString(string_0, string_1, bool_0);
	}

	static string smethod_75(ComboBox comboBox_0)
	{
		return comboBox_0.get_Text();
	}

	static OleDbCommand smethod_76(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbCommand(string_0, oleDbConnection_0);
	}

	static int smethod_77(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.ExecuteNonQuery();
	}

	static void smethod_78(Component component_0)
	{
		component_0.Dispose();
	}

	static string smethod_79(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static DataGridViewRowCollection smethod_80(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_Rows();
	}

	static int smethod_81(DataGridViewCellMouseEventArgs dataGridViewCellMouseEventArgs_0)
	{
		return dataGridViewCellMouseEventArgs_0.get_RowIndex();
	}

	static DataGridViewRow smethod_82(DataGridViewRowCollection dataGridViewRowCollection_0, int int_0)
	{
		return dataGridViewRowCollection_0.get_Item(int_0);
	}

	static DataGridViewCellCollection smethod_83(DataGridViewRow dataGridViewRow_0)
	{
		return dataGridViewRow_0.get_Cells();
	}

	static DataGridViewCell smethod_84(DataGridViewCellCollection dataGridViewCellCollection_0, int int_0)
	{
		return dataGridViewCellCollection_0.get_Item(int_0);
	}

	static object smethod_85(DataGridViewCell dataGridViewCell_0)
	{
		return dataGridViewCell_0.get_Value();
	}

	static string smethod_86(object object_0)
	{
		return Conversions.ToString(object_0);
	}

	static void smethod_87(TextBox textBox_0, string string_0)
	{
		textBox_0.set_Text(string_0);
	}

	static void smethod_88(ComboBox comboBox_0, string string_0)
	{
		comboBox_0.set_Text(string_0);
	}

	static void smethod_89(TextBoxBase textBoxBase_0)
	{
		textBoxBase_0.Clear();
	}

	static void smethod_90(ComboBox comboBox_0, int int_0)
	{
		comboBox_0.set_SelectedIndex(int_0);
	}
}
