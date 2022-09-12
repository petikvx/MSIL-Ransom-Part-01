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
public class SearchDonor_Admin : UserControl
{
	private IContainer components;

	private OleDbConnection myconnection;

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
				int num = 555615246;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3F220C2Bu) % 7u)
					{
					case 6u:
					{
						int num4;
						int num5;
						if (searchResultGrid != null)
						{
							num4 = -714517861;
							num5 = -714517861;
						}
						else
						{
							num4 = -41864316;
							num5 = -41864316;
						}
						num = num4 ^ (int)(num2 * 967538371);
						continue;
					}
					case 4u:
						SearchDonor_Admin.smethod_55(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = ((int)num2 * -1191649462) ^ 0x24A097C2;
						continue;
					case 3u:
						SearchDonor_Admin.smethod_54(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = (int)(num2 * 1585280004) ^ -106772730;
						continue;
					case 2u:
						searchResultGrid = _SearchResultGrid;
						num = (int)((num2 * 626359026) ^ 0x60A1D31F);
						continue;
					case 1u:
					{
						_SearchResultGrid = value;
						searchResultGrid = _SearchResultGrid;
						int num3;
						if (searchResultGrid != null)
						{
							num = 1324885745;
							num3 = 1324885745;
						}
						else
						{
							num = 53796550;
							num3 = 53796550;
						}
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
			Button deleteBtn = _DeleteBtn;
			while (true)
			{
				int num = -1508688972;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBF6F6CFEu) % 7u)
					{
					case 6u:
						SearchDonor_Admin.smethod_57((Control)(object)deleteBtn, eventHandler_);
						num = (int)(num2 * 98903353) ^ -1451014562;
						continue;
					case 3u:
						SearchDonor_Admin.smethod_56((Control)(object)deleteBtn, eventHandler_);
						num = (int)((num2 * 137513701) ^ 0x91D99EF);
						continue;
					case 2u:
					{
						int num5;
						int num6;
						if (deleteBtn != null)
						{
							num5 = 424991827;
							num6 = 424991827;
						}
						else
						{
							num5 = 968313094;
							num6 = 968313094;
						}
						num = num5 ^ (int)(num2 * 211988946);
						continue;
					}
					case 1u:
						_DeleteBtn = value;
						deleteBtn = _DeleteBtn;
						num = -808823454;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (deleteBtn == null)
						{
							num3 = -1711641973;
							num4 = -1711641973;
						}
						else
						{
							num3 = -1736808685;
							num4 = -1736808685;
						}
						num = num3 ^ (int)(num2 * 1066826077);
						continue;
					}
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
				int num = -1594232201;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB2AB92F5u) % 8u)
					{
					case 7u:
						_SearchBtn = value;
						num = -1703768724;
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (searchBtn != null)
						{
							num5 = -1257385223;
							num6 = -1257385223;
						}
						else
						{
							num5 = -223868146;
							num6 = -223868146;
						}
						num = num5 ^ ((int)num2 * -148820906);
						continue;
					}
					case 5u:
						SearchDonor_Admin.smethod_57((Control)(object)searchBtn, eventHandler_);
						num = ((int)num2 * -656288220) ^ 0x1692EF72;
						continue;
					case 2u:
						searchBtn = _SearchBtn;
						num = ((int)num2 * -955846917) ^ 0x4F7230AD;
						continue;
					case 1u:
					{
						searchBtn = _SearchBtn;
						int num3;
						int num4;
						if (searchBtn != null)
						{
							num3 = 1866257471;
							num4 = 1866257471;
						}
						else
						{
							num3 = 1746479289;
							num4 = 1746479289;
						}
						num = num3 ^ (int)(num2 * 1394306839);
						continue;
					}
					case 0u:
						SearchDonor_Admin.smethod_56((Control)(object)searchBtn, eventHandler_);
						num = ((int)num2 * -1137080031) ^ 0x639F5202;
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DonorInfoBox")]
	internal virtual GroupBox DonorInfoBox
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

	[field: AccessedThroughProperty("DateOfDonationTxt")]
	internal virtual TextBox DateOfDonationTxt
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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
				int num = -1534764058;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE0442035u) % 7u)
					{
					case 6u:
						SearchDonor_Admin.smethod_57((Control)(object)clearBtn, eventHandler_);
						num = (int)((num2 * 395782654) ^ 0x5B3193D5);
						continue;
					case 5u:
					{
						int num5;
						int num6;
						if (clearBtn != null)
						{
							num5 = -1314144604;
							num6 = -1314144604;
						}
						else
						{
							num5 = -1830653956;
							num6 = -1830653956;
						}
						num = num5 ^ ((int)num2 * -923110975);
						continue;
					}
					case 4u:
						_ClearBtn = value;
						clearBtn = _ClearBtn;
						num = -1786421588;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (clearBtn != null)
						{
							num3 = -798166864;
							num4 = -798166864;
						}
						else
						{
							num3 = -1195871850;
							num4 = -1195871850;
						}
						num = num3 ^ (int)(num2 * 1457769612);
						continue;
					}
					case 1u:
						SearchDonor_Admin.smethod_56((Control)(object)clearBtn, eventHandler_);
						num = (int)(num2 * 1310020221) ^ -2093452241;
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
				int num = -1521049415;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBFE7D687u) % 9u)
					{
					case 8u:
						updateBtn = _UpdateBtn;
						num = ((int)num2 * -1076422666) ^ -488406849;
						continue;
					case 7u:
						SearchDonor_Admin.smethod_57((Control)(object)updateBtn, eventHandler_);
						num = ((int)num2 * -816093929) ^ -97142204;
						continue;
					case 5u:
						_UpdateBtn = value;
						num = -1247339100;
						continue;
					case 4u:
					{
						int num5;
						int num6;
						if (updateBtn != null)
						{
							num5 = -1307328307;
							num6 = -1307328307;
						}
						else
						{
							num5 = -637449406;
							num6 = -637449406;
						}
						num = num5 ^ ((int)num2 * -491017748);
						continue;
					}
					case 3u:
					{
						int num3;
						int num4;
						if (updateBtn == null)
						{
							num3 = 218713143;
							num4 = 218713143;
						}
						else
						{
							num3 = 2113903118;
							num4 = 2113903118;
						}
						num = num3 ^ (int)(num2 * 2114339223);
						continue;
					}
					case 1u:
						SearchDonor_Admin.smethod_56((Control)(object)updateBtn, eventHandler_);
						num = ((int)num2 * -1613103511) ^ 0x6994A586;
						continue;
					case 0u:
						updateBtn = _UpdateBtn;
						num = (int)((num2 * 671171788) ^ 0x51000389);
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

	public SearchDonor_Admin()
	{
		while (true)
		{
			int num = -218015973;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBE13E35Au) % 6u)
				{
				case 5u:
					InitializeComponent();
					num = ((int)num2 * -1700894337) ^ 0x54ACDA28;
					continue;
				case 3u:
					num = (int)(num2 * 1600658742) ^ -1655141236;
					continue;
				case 2u:
					SearchDonor_Admin.smethod_0((UserControl)(object)this, (EventHandler)SearchDonor_Admin_Load);
					myconnection = SearchDonor_Admin.smethod_1();
					num = ((int)num2 * -542091947) ^ 0x73C2461F;
					continue;
				case 1u:
					num = (int)(num2 * 634861954) ^ -254648892;
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

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing)
			{
				goto IL_0057;
			}
			int num = 0;
			goto IL_008e;
			IL_008e:
			bool flag = (byte)num != 0;
			int num2 = 1169042088;
			goto IL_005c;
			IL_0057:
			num2 = 1054075052;
			goto IL_005c;
			IL_005c:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x71C98CB1u) % 6u)
				{
				case 5u:
					SearchDonor_Admin.smethod_2((IDisposable)components);
					num2 = (int)(num3 * 229073588) ^ -1803137381;
					continue;
				case 4u:
					num2 = ((int)num3 * -1976655626) ^ -1340254469;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -449847574;
						num5 = -449847574;
					}
					else
					{
						num4 = -861271341;
						num5 = -861271341;
					}
					num2 = num4 ^ ((int)num3 * -1124712419);
					continue;
				}
				case 0u:
					break;
				default:
					return;
				case 3u:
					goto IL_0085;
				case 2u:
					return;
				}
				break;
			}
			goto IL_0057;
			IL_0085:
			num = ((components != null) ? 1 : 0);
			goto IL_008e;
		}
		finally
		{
			while (true)
			{
				IL_00df:
				int num6 = 1980705267;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0x71C98CB1u) % 4u)
					{
					case 3u:
						num6 = ((int)num3 * -590156123) ^ 0x4A810717;
						continue;
					case 2u:
						((ContainerControl)this).Dispose(disposing);
						num6 = ((int)num3 * -1978051239) ^ 0x12792A64;
						continue;
					default:
						goto end_IL_00be;
					case 0u:
						break;
					case 1u:
						goto end_IL_00be;
					}
					goto IL_00df;
					continue;
					end_IL_00be:
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
			int num = 25708090;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x43F2D994u) % 325u)
				{
				case 324u:
					SearchDonor_Admin.smethod_15((Control)(object)Label5, "Label5");
					num = (int)((num2 * 1018791593) ^ 0x5D66AF9E);
					continue;
				case 323u:
					Label5 = SearchDonor_Admin.smethod_4();
					num = ((int)num2 * -237811292) ^ 0x185EE24A;
					continue;
				case 322u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_47((Control)(object)this), (Control)(object)SearchResultGrid);
					num = ((int)num2 * -1006559354) ^ -1558394911;
					continue;
				case 321u:
					SearchDonor_Admin.smethod_15((Control)(object)SearchBtn, "SearchBtn");
					num = (int)(num2 * 244641187) ^ -1028410448;
					continue;
				case 320u:
					SearchDonor_Admin.smethod_14((Control)(object)PictureBox1, new Point(165, 20));
					num = (int)((num2 * 1980467654) ^ 0x34837260);
					continue;
				case 319u:
					SearchDonor_Admin.smethod_14((Control)(object)ClearBtn, new Point(808, 667));
					num = (int)(num2 * 603195062) ^ -851454336;
					continue;
				case 318u:
					num = (int)((num2 * 1953899196) ^ 0x71AE417B);
					continue;
				case 317u:
					num = ((int)num2 * -1229152213) ^ 0x524B158E;
					continue;
				case 316u:
					num = ((int)num2 * -1238559549) ^ 0x5B1F4EE0;
					continue;
				case 315u:
					num = ((int)num2 * -1696390674) ^ -1562115957;
					continue;
				case 314u:
					SearchDonor_Admin.smethod_22((Control)(object)Label11, 16);
					num = (int)((num2 * 112199069) ^ 0x79B4EFA);
					continue;
				case 313u:
					num = (int)((num2 * 1816100594) ^ 0x72887721);
					continue;
				case 312u:
					num = ((int)num2 * -878531121) ^ -1085998225;
					continue;
				case 311u:
					SearchResultGrid = SearchDonor_Admin.smethod_5();
					num = (int)((num2 * 1891149992) ^ 0x4783D5CD);
					continue;
				case 310u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)MobileTxt);
					num = ((int)num2 * -377108436) ^ 0x312DC489;
					continue;
				case 309u:
					num = (int)((num2 * 212174624) ^ 0x3ABEA919);
					continue;
				case 308u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)GroupBox1), (Control)(object)SearchBtn);
					num = (int)(num2 * 874718079) ^ -1264753001;
					continue;
				case 307u:
					SearchDonor_Admin.smethod_14((Control)(object)DeleteBtn, new Point(808, 588));
					num = ((int)num2 * -876061270) ^ -1841424553;
					continue;
				case 306u:
					num = (int)(num2 * 1944350028) ^ -147780492;
					continue;
				case 305u:
					SearchDonor_Admin.smethod_31((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					num = ((int)num2 * -1178468785) ^ -315707448;
					continue;
				case 304u:
					num = (int)((num2 * 18500779) ^ 0x3DEE97C4);
					continue;
				case 303u:
					SearchDonor_Admin.smethod_21((Control)(object)Label4, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1019582569) ^ -1755653512;
					continue;
				case 302u:
					SearchDonor_Admin.smethod_16((Control)(object)SearchResultGrid, new Size(853, 169));
					num = ((int)num2 * -528885032) ^ 0x824EB20;
					continue;
				case 301u:
					SearchDonor_Admin.smethod_15((Control)(object)Label1, "Label1");
					num = ((int)num2 * -1546061739) ^ -1547216443;
					continue;
				case 300u:
					SearchDonor_Admin.smethod_16((Control)(object)Label12, new Size(100, 26));
					SearchDonor_Admin.smethod_22((Control)(object)Label12, 18);
					num = (int)((num2 * 1987397106) ^ 0x141A41F6);
					continue;
				case 299u:
					num = ((int)num2 * -221203310) ^ -2127694224;
					continue;
				case 298u:
					SearchDonor_Admin.smethod_21((Control)(object)ClearBtn, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchDonor_Admin.smethod_32((Control)(object)ClearBtn, Color.White);
					num = ((int)num2 * -481553455) ^ -23080704;
					continue;
				case 297u:
					SearchDonor_Admin.smethod_16((Control)(object)DateOfDonationTxt, new Size(192, 28));
					num = (int)(num2 * 1101981342) ^ -1715811742;
					continue;
				case 296u:
					SearchDonor_Admin.smethod_14((Control)(object)IDTxt, new Point(117, 36));
					num = ((int)num2 * -1329196054) ^ -391937869;
					continue;
				case 295u:
					SearchDonor_Admin.smethod_22((Control)(object)GroupBox1, 14);
					num = ((int)num2 * -977686435) ^ 0x7E58B030;
					continue;
				case 294u:
					SearchDonor_Admin.smethod_26(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					num = (int)(num2 * 1250462712) ^ -4644020;
					continue;
				case 293u:
					SearchDonor_Admin.smethod_23(Label9, "Phone : ");
					num = (int)(num2 * 1940003367) ^ -2111872300;
					continue;
				case 292u:
					num = ((int)num2 * -1896961032) ^ -1887546164;
					continue;
				case 291u:
					SearchDonor_Admin.smethod_38(GroupBox1, "Search Patient");
					num = (int)(num2 * 333965718) ^ -2002596770;
					continue;
				case 290u:
					IDTxt = SearchDonor_Admin.smethod_8();
					num = ((int)num2 * -505561518) ^ -1624924022;
					continue;
				case 289u:
					num = (int)(num2 * 1511330113) ^ -1660104727;
					continue;
				case 288u:
					SearchDonor_Admin.smethod_42(SearchDonor_Admin.smethod_41(GenderTxt), new object[3] { "Male", "Female", "Others" });
					num = (int)(num2 * 1513078752) ^ -532695844;
					continue;
				case 287u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)Label4);
					num = ((int)num2 * -932567351) ^ 0x1D676334;
					continue;
				case 286u:
					num = ((int)num2 * -1383740753) ^ 0x22A7A3DB;
					continue;
				case 285u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)Label6);
					num = (int)((num2 * 702605854) ^ 0x5E809D30);
					continue;
				case 284u:
					num = ((int)num2 * -1306815776) ^ -1871946213;
					continue;
				case 283u:
					SearchDonor_Admin.smethod_14((Control)(object)Label12, new Point(401, 217));
					num = (int)(num2 * 46418231) ^ -1510284960;
					continue;
				case 282u:
					SearchDonor_Admin.smethod_43((TextBoxBase)(object)IDTxt, bool_0: true);
					num = (int)(num2 * 842451788) ^ -825938843;
					continue;
				case 281u:
					SearchDonor_Admin.smethod_31((ButtonBase)(object)SearchBtn, Color.MidnightBlue);
					num = ((int)num2 * -624926031) ^ 0x31EF93FE;
					continue;
				case 280u:
					num = ((int)num2 * -1646904519) ^ 0x2D6AED30;
					continue;
				case 279u:
					SearchDonor_Admin.smethod_17(PictureBox1, (PictureBoxSizeMode)1);
					num = ((int)num2 * -1916287818) ^ 0x31D9CE5B;
					continue;
				case 278u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)GroupBox1), (Control)(object)Label10);
					num = ((int)num2 * -552848615) ^ 0x71B9E3EE;
					continue;
				case 277u:
					num = (int)(num2 * 1450056066) ^ -471590181;
					continue;
				case 276u:
					DeleteBtn = SearchDonor_Admin.smethod_6();
					GroupBox1 = SearchDonor_Admin.smethod_7();
					num = ((int)num2 * -150474178) ^ 0x6C2B00AF;
					continue;
				case 275u:
					num = ((int)num2 * -1654567662) ^ 0x19C9C4E6;
					continue;
				case 274u:
					SearchDonor_Admin.smethod_14((Control)(object)MobileSTxt, new Point(120, 86));
					num = ((int)num2 * -1407772445) ^ 0x3353D3A;
					continue;
				case 273u:
					SearchDonor_Admin.smethod_16((Control)(object)DeleteBtn, new Size(104, 37));
					num = (int)(num2 * 2034376036) ^ -1884785367;
					continue;
				case 272u:
					SearchDonor_Admin.smethod_15((Control)(object)Label12, "Label12");
					num = (int)((num2 * 1145490732) ^ 0x3090DEF2);
					continue;
				case 271u:
					SearchDonor_Admin.smethod_34((ButtonBase)(object)SearchBtn, bool_0: false);
					num = (int)((num2 * 1710587120) ^ 0x3A67F201);
					continue;
				case 270u:
					DOBTxt = SearchDonor_Admin.smethod_8();
					num = (int)(num2 * 104511884) ^ -1767067135;
					continue;
				case 269u:
					SearchDonor_Admin.smethod_21((Control)(object)DeleteBtn, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -140910230) ^ -1915967014;
					continue;
				case 268u:
					num = (int)(num2 * 1904139871) ^ -842141955;
					continue;
				case 267u:
					SearchDonor_Admin.smethod_24(Label2, (ContentAlignment)32);
					num = (int)(num2 * 1597503859) ^ -1374032410;
					continue;
				case 266u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)GroupBox1), (Control)(object)Label2);
					num = (int)(num2 * 1623180675) ^ -1766628209;
					continue;
				case 265u:
					num = (int)(num2 * 119231340) ^ -400686261;
					continue;
				case 264u:
					SearchDonor_Admin.smethod_16((Control)(object)ClearBtn, new Size(104, 37));
					num = ((int)num2 * -1057273086) ^ -483266491;
					continue;
				case 263u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_47((Control)(object)this), (Control)(object)DeleteBtn);
					num = (int)((num2 * 656748473) ^ 0x4D36934C);
					continue;
				case 262u:
					SearchDonor_Admin.smethod_14((Control)(object)SearchResultGrid, new Point(59, 295));
					SearchDonor_Admin.smethod_15((Control)(object)SearchResultGrid, "SearchResultGrid");
					SearchDonor_Admin.smethod_27(SearchResultGrid, bool_0: true);
					num = ((int)num2 * -1771925512) ^ 0x178B4739;
					continue;
				case 261u:
					SearchDonor_Admin.smethod_33((ButtonBase)(object)DeleteBtn, "Delete");
					num = ((int)num2 * -1706230549) ^ 0x54063446;
					continue;
				case 260u:
					num = ((int)num2 * -682673998) ^ -1177451288;
					continue;
				case 259u:
					num = (int)((num2 * 132042110) ^ 0x5C9E7F59);
					continue;
				case 258u:
					num = (int)((num2 * 1230536555) ^ 0x36ECBAAF);
					continue;
				case 257u:
					num = (int)(num2 * 1202651373) ^ -917565865;
					continue;
				case 256u:
					SearchDonor_Admin.smethod_15((Control)(object)MobileSTxt, "MobileSTxt");
					num = ((int)num2 * -574710794) ^ 0x1D04D127;
					continue;
				case 255u:
					num = (int)(num2 * 14160376) ^ -545416350;
					continue;
				case 254u:
					SearchDonor_Admin.smethod_16((Control)(object)DOBTxt, new Size(169, 28));
					num = ((int)num2 * -1566287576) ^ -144331994;
					continue;
				case 253u:
					num = (int)(num2 * 1705965761) ^ -490227136;
					continue;
				case 252u:
					SearchDonor_Admin.smethod_16((Control)(object)NameSTxt, new Size(237, 28));
					num = ((int)num2 * -1873640729) ^ 0x1598A0CE;
					continue;
				case 251u:
					num = ((int)num2 * -430599049) ^ -435556129;
					continue;
				case 250u:
					SearchDonor_Admin.smethod_21((Control)(object)SearchBtn, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1991848391) ^ 0x1EA4A323);
					continue;
				case 249u:
					SearchDonor_Admin.smethod_14((Control)(object)Label9, new Point(16, 124));
					SearchDonor_Admin.smethod_15((Control)(object)Label9, "Label9");
					SearchDonor_Admin.smethod_16((Control)(object)Label9, new Size(77, 28));
					num = (int)((num2 * 1856574081) ^ 0x2454AC0C);
					continue;
				case 248u:
					num = (int)((num2 * 1552681615) ^ 0x44B6EA14);
					continue;
				case 247u:
					SearchDonor_Admin.smethod_16((Control)(object)UpdateBtn, new Size(104, 37));
					num = ((int)num2 * -203253395) ^ 0x6811A3;
					continue;
				case 246u:
					SearchDonor_Admin.smethod_22((Control)(object)DateOfDonationTxt, 10);
					num = ((int)num2 * -1015082870) ^ -1193118459;
					continue;
				case 245u:
					SearchDonor_Admin.smethod_16((Control)(object)SearchBtn, new Size(133, 37));
					num = (int)((num2 * 1304063402) ^ 0x14DDD27B);
					continue;
				case 244u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)NameTxt);
					num = (int)(num2 * 2047473037) ^ -1062742667;
					continue;
				case 243u:
					SearchDonor_Admin.smethod_15((Control)(object)PictureBox1, "PictureBox1");
					num = ((int)num2 * -1098847099) ^ 0x770075BE;
					continue;
				case 242u:
					num = (int)((num2 * 1253923227) ^ 0x65DF974C);
					continue;
				case 241u:
					SearchDonor_Admin.smethod_33((ButtonBase)(object)SearchBtn, "Search");
					num = (int)((num2 * 1131868481) ^ 0x2A042596);
					continue;
				case 240u:
					SearchDonor_Admin.smethod_21((Control)(object)DonorInfoBox, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1241640226) ^ 0x74CDCD75);
					continue;
				case 239u:
					MobileSTxt = SearchDonor_Admin.smethod_8();
					num = (int)((num2 * 1672508121) ^ 0x41C33B2B);
					continue;
				case 238u:
					SearchDonor_Admin.smethod_24(Label8, (ContentAlignment)32);
					num = (int)(num2 * 1430544487) ^ -1422490363;
					continue;
				case 237u:
					num = ((int)num2 * -29096586) ^ -1355635164;
					continue;
				case 236u:
					Label6 = SearchDonor_Admin.smethod_4();
					num = ((int)num2 * -1359539418) ^ -874516546;
					continue;
				case 235u:
					num = ((int)num2 * -1617288275) ^ 0x2552FB95;
					continue;
				case 234u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)QuantityTxt);
					num = (int)(num2 * 1727884970) ^ -1590481357;
					continue;
				case 233u:
					num = (int)(num2 * 748414656) ^ -799690378;
					continue;
				case 232u:
					num = (int)((num2 * 1316514798) ^ 0x2105DD70);
					continue;
				case 231u:
					num = ((int)num2 * -1025100928) ^ 0x471AA3C3;
					continue;
				case 230u:
					num = (int)(num2 * 675769919) ^ -678765750;
					continue;
				case 229u:
					SearchDonor_Admin.smethod_16((Control)(object)QuantityTxt, new Size(169, 28));
					num = ((int)num2 * -710011381) ^ 0x3DCACF92;
					continue;
				case 228u:
					num = ((int)num2 * -1826180604) ^ -210110934;
					continue;
				case 227u:
					SearchDonor_Admin.smethod_50((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -2054259248) ^ 0x7664EEC5;
					continue;
				case 226u:
					num = ((int)num2 * -704489696) ^ -811350445;
					continue;
				case 225u:
					SearchDonor_Admin.smethod_22((Control)(object)IDTxt, 17);
					num = ((int)num2 * -1957333897) ^ -1018836945;
					continue;
				case 224u:
					num = ((int)num2 * -545506940) ^ -1515359691;
					continue;
				case 223u:
					SearchDonor_Admin.smethod_15((Control)(object)GroupBox1, "GroupBox1");
					num = (int)(num2 * 1474262948) ^ -632123072;
					continue;
				case 222u:
					MobileTxt = SearchDonor_Admin.smethod_8();
					num = ((int)num2 * -1564055808) ^ 0x4ABCD67F;
					continue;
				case 221u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)GenderTxt);
					num = ((int)num2 * -867713514) ^ -648053058;
					continue;
				case 220u:
					num = ((int)num2 * -723691062) ^ -2096007874;
					continue;
				case 219u:
					num = ((int)num2 * -1964573094) ^ 0x46AEAACF;
					continue;
				case 218u:
					SearchDonor_Admin.smethod_11((Control)(object)GroupBox1);
					num = ((int)num2 * -1398978339) ^ 0x547DE721;
					continue;
				case 217u:
					num = (int)((num2 * 117044163) ^ 0x5334CEA2);
					continue;
				case 216u:
					SearchDonor_Admin.smethod_22((Control)(object)SearchBtn, 4);
					num = ((int)num2 * -1826739120) ^ -39736306;
					continue;
				case 215u:
					num = ((int)num2 * -1574212373) ^ -1148233180;
					continue;
				case 214u:
					SearchDonor_Admin.smethod_14((Control)(object)NameTxt, new Point(117, 77));
					num = ((int)num2 * -4938907) ^ 0x62A87255;
					continue;
				case 213u:
					SearchDonor_Admin.smethod_21((Control)(object)Label11, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchDonor_Admin.smethod_14((Control)(object)Label11, new Point(16, 36));
					num = ((int)num2 * -1639027075) ^ -1694111199;
					continue;
				case 212u:
					SearchDonor_Admin.smethod_15((Control)(object)DeleteBtn, "DeleteBtn");
					num = ((int)num2 * -1423838387) ^ -1723787866;
					continue;
				case 211u:
					SearchDonor_Admin.smethod_25(SearchResultGrid, Color.White);
					num = (int)((num2 * 1666471929) ^ 0x426D2CA1);
					continue;
				case 210u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_47((Control)(object)this), (Control)(object)Label1);
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_47((Control)(object)this), (Control)(object)PictureBox1);
					num = ((int)num2 * -1040114644) ^ -801984751;
					continue;
				case 209u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)Label9);
					num = ((int)num2 * -504724325) ^ 0x16407040;
					continue;
				case 208u:
					num = (int)(num2 * 968517696) ^ -769519927;
					continue;
				case 207u:
					SearchDonor_Admin.smethod_18(PictureBox1, 6);
					num = (int)(num2 * 2002413097) ^ -2080522383;
					continue;
				case 206u:
					num = ((int)num2 * -1113226639) ^ 0x42D0E982;
					continue;
				case 205u:
					SearchDonor_Admin.smethod_15((Control)(object)Label10, "Label10");
					num = (int)((num2 * 634029105) ^ 0x787EB7DD);
					continue;
				case 204u:
					num = (int)(num2 * 1249095822) ^ -1058396969;
					continue;
				case 203u:
					SearchDonor_Admin.smethod_21((Control)(object)Label9, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1466217724) ^ 0x392A3C09;
					continue;
				case 202u:
					SearchDonor_Admin.smethod_16((Control)(object)GroupBox1, new Size(623, 128));
					num = ((int)num2 * -1942908628) ^ -1807730516;
					continue;
				case 201u:
					SearchDonor_Admin.smethod_22((Control)(object)Label10, 0);
					num = (int)((num2 * 1709241742) ^ 0x65177688);
					continue;
				case 200u:
					SearchDonor_Admin.smethod_22((Control)(object)DOBTxt, 5);
					num = ((int)num2 * -1381171353) ^ 0x5C1ADDE6;
					continue;
				case 199u:
					SearchDonor_Admin.smethod_24(Label10, (ContentAlignment)32);
					num = (int)((num2 * 1039989511) ^ 0x7D810BFD);
					continue;
				case 198u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_47((Control)(object)this), (Control)(object)DonorInfoBox);
					num = (int)(num2 * 1488541698) ^ -1672120983;
					continue;
				case 197u:
					SearchDonor_Admin.smethod_23(Label3, "Date Of Donation :");
					num = ((int)num2 * -520836801) ^ -1886656064;
					continue;
				case 196u:
					Label8 = SearchDonor_Admin.smethod_4();
					num = ((int)num2 * -1865116216) ^ -1992675650;
					continue;
				case 195u:
					num = ((int)num2 * -1990156571) ^ 0x72CE49A1;
					continue;
				case 194u:
					SearchDonor_Admin.smethod_14((Control)(object)DateOfDonationTxt, new Point(196, 215));
					SearchDonor_Admin.smethod_15((Control)(object)DateOfDonationTxt, "DateOfDonationTxt");
					SearchDonor_Admin.smethod_43((TextBoxBase)(object)DateOfDonationTxt, bool_0: true);
					num = (int)((num2 * 962972918) ^ 0x500F2878);
					continue;
				case 193u:
					SearchDonor_Admin.smethod_22((Control)(object)Label8, 9);
					num = (int)(num2 * 1491709899) ^ -780720012;
					continue;
				case 192u:
					SearchDonor_Admin.smethod_22((Control)(object)NameTxt, 4);
					num = (int)(num2 * 1401877814) ^ -561222087;
					continue;
				case 191u:
					num = ((int)num2 * -223653606) ^ 0x5A781A67;
					continue;
				case 190u:
					SearchDonor_Admin.smethod_14((Control)(object)DonorInfoBox, new Point(79, 470));
					SearchDonor_Admin.smethod_15((Control)(object)DonorInfoBox, "DonorInfoBox");
					num = (int)((num2 * 785502636) ^ 0x6EE65735);
					continue;
				case 189u:
					Label11 = SearchDonor_Admin.smethod_4();
					num = (int)((num2 * 1992974506) ^ 0x390A0EF0);
					continue;
				case 188u:
					num = (int)(num2 * 1592341345) ^ -163811833;
					continue;
				case 187u:
					num = ((int)num2 * -670082561) ^ 0x3391747A;
					continue;
				case 186u:
					UpdateBtn = SearchDonor_Admin.smethod_6();
					SearchDonor_Admin.smethod_10((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -2047068088) ^ 0x24C4A3BB;
					continue;
				case 185u:
					SearchDonor_Admin.smethod_14((Control)(object)UpdateBtn, new Point(808, 517));
					num = ((int)num2 * -1424485827) ^ 0x3105137B;
					continue;
				case 184u:
					num = (int)((num2 * 1025944871) ^ 0x3339F3B4);
					continue;
				case 183u:
					SearchDonor_Admin.smethod_30((Control)(object)UpdateBtn, bool_0: false);
					num = ((int)num2 * -1435664325) ^ 0x4DA4217B;
					continue;
				case 182u:
					SearchDonor_Admin.smethod_15((Control)(object)Label6, "Label6");
					SearchDonor_Admin.smethod_16((Control)(object)Label6, new Size(84, 26));
					num = ((int)num2 * -820472399) ^ 0x2CFFE33B;
					continue;
				case 181u:
					num = ((int)num2 * -743180995) ^ -504123602;
					continue;
				case 180u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)GroupBox1), (Control)(object)MobileSTxt);
					num = ((int)num2 * -105383640) ^ 0x1944891B;
					continue;
				case 179u:
					SearchDonor_Admin.smethod_21((Control)(object)Label6, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1791363927) ^ -1267641126;
					continue;
				case 178u:
					SearchDonor_Admin.smethod_21((Control)(object)GroupBox1, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 595037307) ^ 0x46218308);
					continue;
				case 177u:
					num = (int)((num2 * 119383430) ^ 0x26A256D5);
					continue;
				case 176u:
					Label12 = SearchDonor_Admin.smethod_4();
					num = (int)(num2 * 2118380749) ^ -982439132;
					continue;
				case 175u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_47((Control)(object)this), (Control)(object)GroupBox1);
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_47((Control)(object)this), (Control)(object)ClearBtn);
					num = (int)((num2 * 1197994513) ^ 0x191EB750);
					continue;
				case 174u:
					SearchDonor_Admin.smethod_14((Control)(object)Label8, new Point(16, 78));
					num = (int)((num2 * 1699077004) ^ 0x3DA1D7E5);
					continue;
				case 173u:
					DateOfDonationTxt = SearchDonor_Admin.smethod_8();
					num = ((int)num2 * -51646421) ^ -290024910;
					continue;
				case 171u:
					num = ((int)num2 * -1243664300) ^ -1646447929;
					continue;
				case 170u:
					SearchDonor_Admin.smethod_44((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -303163750) ^ 0x5FE2A12E;
					continue;
				case 169u:
					SearchDonor_Admin.smethod_15((Control)(object)QuantityTxt, "QuantityTxt");
					SearchDonor_Admin.smethod_43((TextBoxBase)(object)QuantityTxt, bool_0: true);
					num = ((int)num2 * -522697557) ^ -150039667;
					continue;
				case 168u:
					SearchDonor_Admin.smethod_14((Control)(object)DOBTxt, new Point(117, 167));
					num = ((int)num2 * -808122042) ^ 0x14B50FF1;
					continue;
				case 167u:
					SearchDonor_Admin.smethod_23(Label10, "Name : ");
					num = (int)(num2 * 1180585714) ^ -1619026380;
					continue;
				case 166u:
					SearchDonor_Admin.smethod_21((Control)(object)UpdateBtn, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchDonor_Admin.smethod_32((Control)(object)UpdateBtn, Color.White);
					num = (int)(num2 * 294637562) ^ -1063533494;
					continue;
				case 165u:
					SearchDonor_Admin.smethod_51((Control)(object)DonorInfoBox, bool_0: false);
					num = (int)(num2 * 39110746) ^ -874807392;
					continue;
				case 164u:
					num = ((int)num2 * -600507890) ^ -1696234237;
					continue;
				case 163u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)Label11);
					num = (int)(num2 * 768662184) ^ -819687839;
					continue;
				case 162u:
					SearchDonor_Admin.smethod_34((ButtonBase)(object)UpdateBtn, bool_0: false);
					num = (int)(num2 * 973250769) ^ -1285780220;
					continue;
				case 161u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)GroupBox1), (Control)(object)NameSTxt);
					num = (int)((num2 * 1838438179) ^ 0x40244F54);
					continue;
				case 159u:
					SearchDonor_Admin.smethod_23(Label4, "Blood Group : ");
					num = ((int)num2 * -1166921161) ^ 0x4EC165F8;
					continue;
				case 158u:
					num = ((int)num2 * -1938671599) ^ 0x689D7F5A;
					continue;
				case 157u:
					num = (int)((num2 * 1838492676) ^ 0x9E88AA9);
					continue;
				case 156u:
					SearchDonor_Admin.smethod_52((Control)(object)DonorInfoBox);
					num = ((int)num2 * -596210922) ^ -334470699;
					continue;
				case 155u:
					num = ((int)num2 * -747803038) ^ 0x5DD366C3;
					continue;
				case 154u:
					SearchDonor_Admin.smethod_40((ListControl)(object)BloodGroupTxt, bool_0: true);
					num = ((int)num2 * -1687689554) ^ 0x5F4520B4;
					continue;
				case 153u:
					SearchDonor_Admin.smethod_16((Control)(object)GenderTxt, new Size(146, 30));
					num = (int)((num2 * 761732217) ^ 0xBC7D197);
					continue;
				case 152u:
					SearchDonor_Admin.smethod_16((Control)(object)Label2, new Size(77, 28));
					num = (int)((num2 * 697366130) ^ 0x506583B2);
					continue;
				case 151u:
					SearchDonor_Admin.smethod_24(Label9, (ContentAlignment)32);
					num = ((int)num2 * -2065864293) ^ 0x6C6FA4E1;
					continue;
				case 150u:
					SearchDonor_Admin.smethod_14((Control)(object)Label2, new Point(37, 87));
					num = (int)((num2 * 525642258) ^ 0x785F7167);
					continue;
				case 149u:
					SearchDonor_Admin.smethod_21((Control)(object)Label2, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -624028009) ^ -1565411500;
					continue;
				case 148u:
					SearchDonor_Admin.smethod_33((ButtonBase)(object)UpdateBtn, "Update");
					num = (int)((num2 * 1636699067) ^ 0x7901F8B6);
					continue;
				case 147u:
					SearchDonor_Admin.smethod_15((Control)(object)Label3, "Label3");
					SearchDonor_Admin.smethod_16((Control)(object)Label3, new Size(174, 25));
					num = ((int)num2 * -1921486238) ^ -1548923225;
					continue;
				case 146u:
					num = (int)((num2 * 1683474004) ^ 0xEBAAA22);
					continue;
				case 145u:
					SearchDonor_Admin.smethod_15((Control)(object)NameTxt, "NameTxt");
					num = (int)((num2 * 1578947342) ^ 0x78D413E7);
					continue;
				case 144u:
					SearchDonor_Admin.smethod_23(Label8, "Name : ");
					num = ((int)num2 * -1726773775) ^ 0x989763E;
					continue;
				case 143u:
					SearchDonor_Admin.smethod_34((ButtonBase)(object)DeleteBtn, bool_0: false);
					SearchDonor_Admin.smethod_30((Control)(object)DeleteBtn, bool_0: false);
					num = (int)((num2 * 2010654790) ^ 0x4BB7D5E2);
					continue;
				case 142u:
					num = (int)(num2 * 1062262256) ^ -1187231775;
					continue;
				case 141u:
					num = (int)((num2 * 1059490281) ^ 0x58944D6E);
					continue;
				case 140u:
					SearchDonor_Admin.smethod_22((Control)(object)Label3, 0);
					num = (int)(num2 * 1288050205) ^ -1527501079;
					continue;
				case 139u:
					SearchDonor_Admin.smethod_16((Control)(object)IDTxt, new Size(204, 28));
					num = ((int)num2 * -249422241) ^ -1324923382;
					continue;
				case 138u:
					SearchDonor_Admin.smethod_16((Control)(object)MobileSTxt, new Size(237, 28));
					num = ((int)num2 * -2054331056) ^ 0x7460C89F;
					continue;
				case 137u:
					SearchDonor_Admin.smethod_21((Control)(object)Label12, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -47633336) ^ -1793492464;
					continue;
				case 136u:
					SearchDonor_Admin.smethod_51((Control)(object)GroupBox1, bool_0: false);
					num = ((int)num2 * -1968534913) ^ 0x646A4E51;
					continue;
				case 135u:
					num = ((int)num2 * -1047476322) ^ -2026031400;
					continue;
				case 134u:
					SearchDonor_Admin.smethod_14((Control)(object)GroupBox1, new Point(155, 150));
					num = ((int)num2 * -1379622771) ^ -1713054784;
					continue;
				case 133u:
					num = (int)((num2 * 155746750) ^ 0x7DE09194);
					continue;
				case 132u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)Label8);
					num = (int)((num2 * 562165573) ^ 0x7016EE2C);
					continue;
				case 131u:
					num = (int)((num2 * 23211770) ^ 0x6F270B97);
					continue;
				case 130u:
					SearchDonor_Admin.smethod_49((Control)(object)this, new Size(977, 804));
					num = ((int)num2 * -123871842) ^ 0x2DA75268;
					continue;
				case 129u:
					SearchDonor_Admin.smethod_30((Control)(object)DonorInfoBox, bool_0: false);
					SearchDonor_Admin.smethod_39(BloodGroupTxt, (ComboBoxStyle)2);
					num = (int)(num2 * 1374673002) ^ -329934766;
					continue;
				case 128u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)Label3);
					num = (int)(num2 * 1270903350) ^ -1275586601;
					continue;
				case 127u:
					num = ((int)num2 * -1746106433) ^ 0x74CB92C7;
					continue;
				case 126u:
					PictureBox1 = SearchDonor_Admin.smethod_3();
					num = ((int)num2 * -1156250857) ^ -464776091;
					continue;
				case 125u:
					SearchDonor_Admin.smethod_52((Control)(object)GroupBox1);
					num = (int)((num2 * 307640808) ^ 0x43DC9B36);
					continue;
				case 124u:
					SearchDonor_Admin.smethod_14((Control)(object)SearchBtn, new Point(468, 82));
					num = (int)((num2 * 253848941) ^ 0x6BDC6B3);
					continue;
				case 123u:
					SearchDonor_Admin.smethod_19(PictureBox1, bool_0: false);
					SearchDonor_Admin.smethod_21((Control)(object)Label1, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1415534840) ^ 0x3D0DEEE4);
					continue;
				case 122u:
					num = (int)(num2 * 489371238) ^ -285918963;
					continue;
				case 121u:
					num = ((int)num2 * -930205204) ^ -295283709;
					continue;
				case 120u:
					num = (int)(num2 * 531064086) ^ -232010388;
					continue;
				case 119u:
					num = ((int)num2 * -1535398244) ^ 0x1914D7EF;
					continue;
				case 118u:
					SearchDonor_Admin.smethod_31((ButtonBase)(object)UpdateBtn, Color.MidnightBlue);
					num = (int)(num2 * 1385189278) ^ -888532299;
					continue;
				case 117u:
					SearchDonor_Admin.smethod_22((Control)(object)Label1, 7);
					SearchDonor_Admin.smethod_23(Label1, "Search Donor");
					num = ((int)num2 * -1842736088) ^ 0x43A0CAD3;
					continue;
				case 116u:
					num = ((int)num2 * -664144395) ^ 0x7CA5F9D4;
					continue;
				case 115u:
					num = ((int)num2 * -199892335) ^ 0x5E12249F;
					continue;
				case 114u:
					SearchDonor_Admin.smethod_14((Control)(object)Label5, new Point(16, 169));
					num = (int)(num2 * 985627105) ^ -755885043;
					continue;
				case 113u:
					num = ((int)num2 * -1359816412) ^ 0x35382ECD;
					continue;
				case 112u:
					Label3 = SearchDonor_Admin.smethod_4();
					num = ((int)num2 * -1607903165) ^ 0x584E88E4;
					continue;
				case 111u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)DOBTxt);
					num = (int)((num2 * 361016824) ^ 0x73F147DB);
					continue;
				case 110u:
					num = ((int)num2 * -509554907) ^ -1455497264;
					continue;
				case 109u:
					num = (int)((num2 * 1799712782) ^ 0x56DC15FC);
					continue;
				case 108u:
					DonorInfoBox = SearchDonor_Admin.smethod_7();
					num = (int)(num2 * 1400857925) ^ -1734251743;
					continue;
				case 107u:
					SearchDonor_Admin.smethod_14((Control)(object)Label4, new Point(388, 164));
					num = ((int)num2 * -933370237) ^ -1944487797;
					continue;
				case 106u:
					num = (int)((num2 * 866118217) ^ 0x10316F77);
					continue;
				case 105u:
					Label4 = SearchDonor_Admin.smethod_4();
					num = (int)(num2 * 580014919) ^ -178171649;
					continue;
				case 104u:
					SearchDonor_Admin.smethod_42(SearchDonor_Admin.smethod_41(BloodGroupTxt), new object[8] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
					num = (int)((num2 * 298912205) ^ 0x4896C8D8);
					continue;
				case 103u:
					num = (int)(num2 * 685128960) ^ -175055454;
					continue;
				case 102u:
					num = (int)((num2 * 518580272) ^ 0x1A426183);
					continue;
				case 101u:
					SearchDonor_Admin.smethod_38(DonorInfoBox, "Donor Information");
					num = ((int)num2 * -85108954) ^ 0x1A1CE47C;
					continue;
				case 100u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)DateOfDonationTxt);
					num = ((int)num2 * -939263271) ^ 0x4A4D8E94;
					continue;
				case 99u:
					num = ((int)num2 * -917029446) ^ -1465891806;
					continue;
				case 98u:
					SearchDonor_Admin.smethod_24(Label4, (ContentAlignment)32);
					num = ((int)num2 * -1974490891) ^ 0x4E99EF4A;
					continue;
				case 97u:
					num = (int)((num2 * 716978810) ^ 0x1586D193);
					continue;
				case 96u:
					SearchDonor_Admin.smethod_15((Control)(object)BloodGroupTxt, "BloodGroupTxt");
					num = ((int)num2 * -1445651136) ^ -323817613;
					continue;
				case 95u:
					SearchDonor_Admin.smethod_22((Control)(object)QuantityTxt, 19);
					num = ((int)num2 * -1414368675) ^ 0x62D9F7CE;
					continue;
				case 94u:
					SearchDonor_Admin.smethod_14((Control)(object)Label1, new Point(392, 63));
					num = (int)(num2 * 958031387) ^ -1598413394;
					continue;
				case 93u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)Label5);
					num = (int)(num2 * 1940088078) ^ -349265218;
					continue;
				case 92u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)Label12);
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)IDTxt);
					num = (int)((num2 * 622642317) ^ 0x453C34FD);
					continue;
				case 91u:
					num = ((int)num2 * -967746758) ^ -1814658250;
					continue;
				case 90u:
					SearchDonor_Admin.smethod_23(Label12, "Quantity : ");
					num = ((int)num2 * -1733685981) ^ 0x14A18B9F;
					continue;
				case 89u:
					Label2 = SearchDonor_Admin.smethod_4();
					num = ((int)num2 * -1756415234) ^ -1165867919;
					continue;
				case 88u:
					num = ((int)num2 * -885404711) ^ 0x4BE67CDF;
					continue;
				case 87u:
					num = ((int)num2 * -18751155) ^ -1156355444;
					continue;
				case 86u:
					num = (int)(num2 * 1271923187) ^ -194773379;
					continue;
				case 85u:
					SearchDonor_Admin.smethod_22((Control)(object)Label2, 3);
					SearchDonor_Admin.smethod_23(Label2, "Mobile : ");
					num = ((int)num2 * -1920488479) ^ 0x7F3AB27C;
					continue;
				case 84u:
					SearchDonor_Admin.smethod_15((Control)(object)ClearBtn, "ClearBtn");
					num = (int)(num2 * 227899196) ^ -824865050;
					continue;
				case 83u:
					SearchDonor_Admin.smethod_48((Control)(object)this, "SearchDonor_Admin");
					num = (int)(num2 * 1432586396) ^ -1415685681;
					continue;
				case 82u:
					SearchDonor_Admin.smethod_37(DonorInfoBox, bool_0: false);
					num = (int)((num2 * 1178363186) ^ 0x78A663EF);
					continue;
				case 81u:
					SearchDonor_Admin.smethod_37(GroupBox1, bool_0: false);
					num = ((int)num2 * -1278105600) ^ -605945041;
					continue;
				case 80u:
					SearchDonor_Admin.smethod_23(Label11, "ID :");
					num = (int)((num2 * 1472810588) ^ 0x175CD456);
					continue;
				case 79u:
					SearchDonor_Admin.smethod_16((Control)(object)Label5, new Size(84, 26));
					num = ((int)num2 * -1108240780) ^ 0x17B6DE81;
					continue;
				case 78u:
					SearchDonor_Admin.smethod_16((Control)(object)DonorInfoBox, new Size(699, 259));
					num = ((int)num2 * -407768647) ^ 0x2AA35554;
					continue;
				case 77u:
					SearchDonor_Admin.smethod_12((Control)(object)this);
					num = ((int)num2 * -871540119) ^ 0x7F9BE66B;
					continue;
				case 76u:
					SearchDonor_Admin.smethod_14((Control)(object)Label10, new Point(37, 44));
					num = ((int)num2 * -1012775340) ^ -1247398491;
					continue;
				case 75u:
					SearchDonor_Admin.smethod_10((ISupportInitialize)SearchResultGrid);
					num = (int)(num2 * 607228184) ^ -718971122;
					continue;
				case 74u:
					SearchDonor_Admin.smethod_22((Control)(object)MobileSTxt, 2);
					SearchDonor_Admin.smethod_14((Control)(object)NameSTxt, new Point(120, 44));
					num = ((int)num2 * -1378061001) ^ 0x4F8AC82F;
					continue;
				case 73u:
					SearchDonor_Admin.smethod_16((Control)(object)Label10, new Size(77, 28));
					num = ((int)num2 * -1007977976) ^ -545019296;
					continue;
				case 72u:
					SearchBtn = SearchDonor_Admin.smethod_6();
					num = ((int)num2 * -1690887203) ^ -1477647195;
					continue;
				case 71u:
					NameTxt = SearchDonor_Admin.smethod_8();
					num = ((int)num2 * -575025119) ^ -1081175168;
					continue;
				case 70u:
					SearchDonor_Admin.smethod_22((Control)(object)NameSTxt, 1);
					SearchDonor_Admin.smethod_21((Control)(object)Label10, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1729773914) ^ -1093266784;
					continue;
				case 69u:
					SearchDonor_Admin.smethod_16((Control)(object)NameTxt, new Size(271, 28));
					num = ((int)num2 * -1046483963) ^ -1904886307;
					continue;
				case 68u:
					Label9 = SearchDonor_Admin.smethod_4();
					num = ((int)num2 * -421065112) ^ 0x7ADDF3AB;
					continue;
				case 67u:
					num = ((int)num2 * -473843556) ^ 0x86EDE43;
					continue;
				case 66u:
					SearchDonor_Admin.smethod_15((Control)(object)Label4, "Label4");
					num = (int)(num2 * 847063422) ^ -1407942782;
					continue;
				case 65u:
					SearchDonor_Admin.smethod_23(Label5, "Age :");
					num = (int)(num2 * 1305301528) ^ -1412287140;
					continue;
				case 64u:
					num = (int)(num2 * 187580029) ^ -1545768659;
					continue;
				case 63u:
					SearchDonor_Admin.smethod_16((Control)(object)Label8, new Size(77, 28));
					num = ((int)num2 * -1920638057) ^ -1833975679;
					continue;
				case 62u:
					SearchDonor_Admin.smethod_22((Control)(object)Label9, 11);
					num = (int)((num2 * 1215960338) ^ 0x20519DBD);
					continue;
				case 61u:
					SearchDonor_Admin.smethod_24(Label1, (ContentAlignment)32);
					num = ((int)num2 * -1390395635) ^ -686894668;
					continue;
				case 60u:
					SearchDonor_Admin.smethod_15((Control)(object)NameSTxt, "NameSTxt");
					num = ((int)num2 * -908383364) ^ -1460657727;
					continue;
				case 59u:
					SearchDonor_Admin.smethod_22((Control)(object)Label6, 2);
					SearchDonor_Admin.smethod_23(Label6, "Gender : ");
					SearchDonor_Admin.smethod_21((Control)(object)Label5, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -768586495) ^ -718333259;
					continue;
				case 58u:
					SearchDonor_Admin.smethod_50((ISupportInitialize)SearchResultGrid);
					num = ((int)num2 * -1909142088) ^ 0x6FCBCE73;
					continue;
				case 57u:
					SearchDonor_Admin.smethod_32((Control)(object)SearchBtn, Color.White);
					num = ((int)num2 * -1665579335) ^ -1136595160;
					continue;
				case 56u:
					num = (int)((num2 * 1698769065) ^ 0x1BE19371);
					continue;
				case 55u:
					SearchDonor_Admin.smethod_15((Control)(object)Label8, "Label8");
					num = (int)(num2 * 70309468) ^ -10969411;
					continue;
				case 54u:
					SearchDonor_Admin.smethod_15((Control)(object)Label2, "Label2");
					num = (int)((num2 * 864792447) ^ 0x34AFA55A);
					continue;
				case 53u:
					num = ((int)num2 * -1398225851) ^ 0x1D01E797;
					continue;
				case 52u:
					SearchDonor_Admin.smethod_22((Control)(object)ClearBtn, 12);
					SearchDonor_Admin.smethod_33((ButtonBase)(object)ClearBtn, "Clear");
					num = (int)((num2 * 395354412) ^ 0x64B39BF2);
					continue;
				case 51u:
					BloodGroupTxt = SearchDonor_Admin.smethod_9();
					GenderTxt = SearchDonor_Admin.smethod_9();
					QuantityTxt = SearchDonor_Admin.smethod_8();
					num = ((int)num2 * -359037935) ^ -306614324;
					continue;
				case 50u:
					SearchDonor_Admin.smethod_22((Control)(object)MobileTxt, 12);
					num = ((int)num2 * -1974771345) ^ 0x6A8A1659;
					continue;
				case 49u:
					SearchDonor_Admin.smethod_22((Control)(object)UpdateBtn, 16);
					num = ((int)num2 * -1726828144) ^ 0xD405CAE;
					continue;
				case 48u:
					SearchDonor_Admin.smethod_15((Control)(object)Label11, "Label11");
					num = (int)((num2 * 1202762614) ^ 0x166813F2);
					continue;
				case 47u:
					SearchDonor_Admin.smethod_34((ButtonBase)(object)ClearBtn, bool_0: false);
					num = (int)(num2 * 1828041307) ^ -1430323349;
					continue;
				case 46u:
					SearchDonor_Admin.smethod_16((Control)(object)BloodGroupTxt, new Size(146, 30));
					SearchDonor_Admin.smethod_22((Control)(object)BloodGroupTxt, 21);
					SearchDonor_Admin.smethod_39(GenderTxt, (ComboBoxStyle)2);
					num = (int)(num2 * 675019935) ^ -1999438860;
					continue;
				case 45u:
					SearchDonor_Admin.smethod_22((Control)(object)GenderTxt, 20);
					SearchDonor_Admin.smethod_14((Control)(object)QuantityTxt, new Point(507, 215));
					num = (int)(num2 * 1910112969) ^ -1674415442;
					continue;
				case 44u:
					num = (int)((num2 * 727600345) ^ 0x4E175046);
					continue;
				case 43u:
					SearchDonor_Admin.smethod_14((Control)(object)BloodGroupTxt, new Point(531, 164));
					num = ((int)num2 * -1031318718) ^ 0x27F11281;
					continue;
				case 42u:
					SearchDonor_Admin.smethod_29(SearchDonor_Admin.smethod_28(SearchResultGrid), 24);
					num = (int)((num2 * 414574508) ^ 0x7B3E48BC);
					continue;
				case 41u:
					SearchDonor_Admin.smethod_14((Control)(object)MobileTxt, new Point(117, 124));
					SearchDonor_Admin.smethod_15((Control)(object)MobileTxt, "MobileTxt");
					num = (int)((num2 * 1404444184) ^ 0x446A63FD);
					continue;
				case 40u:
					NameSTxt = SearchDonor_Admin.smethod_8();
					Label10 = SearchDonor_Admin.smethod_4();
					ClearBtn = SearchDonor_Admin.smethod_6();
					num = (int)(num2 * 1885439324) ^ -1924779255;
					continue;
				case 39u:
					SearchDonor_Admin.smethod_16((Control)(object)MobileTxt, new Size(271, 28));
					num = ((int)num2 * -1793344230) ^ 0x1DEF6CD9;
					continue;
				case 38u:
					Label1 = SearchDonor_Admin.smethod_4();
					num = ((int)num2 * -42211714) ^ -1287596969;
					continue;
				case 37u:
					num = ((int)num2 * -345583495) ^ 0x6A4660EF;
					continue;
				case 36u:
					SearchDonor_Admin.smethod_15((Control)(object)GenderTxt, "GenderTxt");
					num = (int)((num2 * 1078266167) ^ 0x53ED6990);
					continue;
				case 35u:
					num = ((int)num2 * -2035020635) ^ 0x49C89ACF;
					continue;
				case 34u:
					num = ((int)num2 * -537129505) ^ 0x1A4C6378;
					continue;
				case 33u:
					num = ((int)num2 * -1081416028) ^ 0x3A1AAFCD;
					continue;
				case 32u:
					num = ((int)num2 * -788398375) ^ 0x2BE9D7F;
					continue;
				case 31u:
					SearchDonor_Admin.smethod_16((Control)(object)Label11, new Size(68, 25));
					num = (int)(num2 * 2015839642) ^ -1671775139;
					continue;
				case 30u:
					SearchDonor_Admin.smethod_22((Control)(object)Label5, 1);
					num = ((int)num2 * -1278360451) ^ -1997278126;
					continue;
				case 29u:
					SearchDonor_Admin.smethod_16((Control)(object)Label1, new Size(330, 47));
					num = (int)(num2 * 1790816271) ^ -557467655;
					continue;
				case 28u:
					num = ((int)num2 * -288125137) ^ -813872695;
					continue;
				case 27u:
					num = ((int)num2 * -1387164586) ^ 0x7887DC33;
					continue;
				case 26u:
					SearchDonor_Admin.smethod_40((ListControl)(object)GenderTxt, bool_0: true);
					num = ((int)num2 * -1571869853) ^ -1540131459;
					continue;
				case 25u:
					num = ((int)num2 * -1080394300) ^ 0x45573F51;
					continue;
				case 24u:
					num = ((int)num2 * -716397568) ^ -1523953648;
					continue;
				case 23u:
					num = ((int)num2 * -903972907) ^ 0x737CC56;
					continue;
				case 22u:
					SearchDonor_Admin.smethod_45((ContainerControl)(object)this, (AutoScaleMode)1);
					SearchDonor_Admin.smethod_46((Control)(object)this, Color.White);
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_47((Control)(object)this), (Control)(object)UpdateBtn);
					num = ((int)num2 * -1949175240) ^ -205913529;
					continue;
				case 21u:
					SearchDonor_Admin.smethod_11((Control)(object)DonorInfoBox);
					num = ((int)num2 * -1288713508) ^ -551136605;
					continue;
				case 20u:
					SearchDonor_Admin.smethod_16((Control)(object)Label4, new Size(134, 28));
					SearchDonor_Admin.smethod_22((Control)(object)Label4, 13);
					num = (int)((num2 * 870009240) ^ 0x686AA5B4);
					continue;
				case 19u:
					SearchDonor_Admin.smethod_32((Control)(object)DeleteBtn, Color.White);
					num = (int)(num2 * 1192653909) ^ -555733499;
					continue;
				case 18u:
					num = (int)((num2 * 1085300538) ^ 0xBEFA692);
					continue;
				case 17u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)BloodGroupTxt);
					num = (int)((num2 * 2062266143) ^ 0x11C93B22);
					continue;
				case 16u:
					SearchDonor_Admin.smethod_31((ButtonBase)(object)DeleteBtn, Color.MidnightBlue);
					num = (int)(num2 * 326879202) ^ -506970862;
					continue;
				case 15u:
					SearchDonor_Admin.smethod_22((Control)(object)DonorInfoBox, 15);
					num = ((int)num2 * -1452751410) ^ -1905783285;
					continue;
				case 14u:
					SearchDonor_Admin.smethod_22((Control)(object)SearchResultGrid, 10);
					SearchDonor_Admin.smethod_30((Control)(object)SearchResultGrid, bool_0: false);
					num = ((int)num2 * -1713175288) ^ -1173631731;
					continue;
				case 13u:
					SearchDonor_Admin.smethod_14((Control)(object)GenderTxt, new Point(530, 118));
					num = (int)((num2 * 452321790) ^ 0x64E38CAF);
					continue;
				case 12u:
					num = ((int)num2 * -689922726) ^ 0x1C514F10;
					continue;
				case 11u:
					SearchDonor_Admin.smethod_15((Control)(object)IDTxt, "IDTxt");
					num = (int)(num2 * 1470106807) ^ -878003381;
					continue;
				case 10u:
					num = (int)((num2 * 2103841181) ^ 0x7DC973E5);
					continue;
				case 9u:
					num = ((int)num2 * -1384992196) ^ 0x4EE237CE;
					continue;
				case 8u:
					SearchDonor_Admin.smethod_15((Control)(object)UpdateBtn, "UpdateBtn");
					num = (int)((num2 * 251257037) ^ 0x50573BA9);
					continue;
				case 7u:
					SearchDonor_Admin.smethod_21((Control)(object)Label8, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1540137199) ^ 0x328B96B9);
					continue;
				case 6u:
					SearchDonor_Admin.smethod_21((Control)(object)Label3, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchDonor_Admin.smethod_14((Control)(object)Label3, new Point(16, 221));
					num = ((int)num2 * -386346125) ^ 0x1B1303A3;
					continue;
				case 5u:
					SearchDonor_Admin.smethod_22((Control)(object)DeleteBtn, 13);
					num = ((int)num2 * -319193783) ^ -2020666554;
					continue;
				case 4u:
					num = ((int)num2 * -1143195637) ^ -10219813;
					continue;
				case 3u:
					SearchDonor_Admin.smethod_13(PictureBox1, (Image)(object)Resources.images1232);
					num = (int)((num2 * 1250780806) ^ 0x69B0A63B);
					continue;
				case 2u:
					SearchDonor_Admin.smethod_15((Control)(object)DOBTxt, "DOBTxt");
					num = ((int)num2 * -1754274799) ^ -1272440891;
					continue;
				case 1u:
					SearchDonor_Admin.smethod_14((Control)(object)Label6, new Point(401, 129));
					num = (int)((num2 * 1140261324) ^ 0x2E38F3D5);
					continue;
				case 0u:
					SearchDonor_Admin.smethod_16((Control)(object)PictureBox1, new Size(200, 110));
					num = ((int)num2 * -1015628172) ^ -28599081;
					continue;
				case 160u:
					break;
				default:
					SearchDonor_Admin.smethod_53((Control)(object)this, bool_0: false);
					return;
				}
				break;
			}
		}
	}

	private void SearchDonor_Admin_Load(object sender, EventArgs e)
	{
		SearchDonor_Admin.smethod_59(myconnection, SearchDonor_Admin.smethod_58(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
		while (true)
		{
			int num = -777134486;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA85CE2C5u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1466736791) ^ -1490942341;
					continue;
				case 1u:
					HideItemsOnForm();
					num = ((int)num2 * -1856288471) ^ 0x3365FE02;
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
		SearchDonor_Admin.smethod_30((Control)(object)SearchResultGrid, bool_0: false);
		bool result = default(bool);
		while (true)
		{
			int num = 360011022;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6CDFCA1Eu) % 9u)
				{
				case 8u:
					num = (int)(num2 * 994346871) ^ -1798980749;
					continue;
				case 7u:
					result = true;
					num = ((int)num2 * -2112323147) ^ -2098393206;
					continue;
				case 6u:
					num = ((int)num2 * -1066873050) ^ -1955427647;
					continue;
				case 3u:
					SearchDonor_Admin.smethod_30((Control)(object)ClearBtn, bool_0: false);
					SearchDonor_Admin.smethod_30((Control)(object)DeleteBtn, bool_0: false);
					num = (int)((num2 * 338537695) ^ 0x652BC5FA);
					continue;
				case 2u:
					SearchDonor_Admin.smethod_30((Control)(object)UpdateBtn, bool_0: false);
					num = ((int)num2 * -1197284006) ^ 0x3ABD4DC9;
					continue;
				case 1u:
					SearchDonor_Admin.smethod_30((Control)(object)DonorInfoBox, bool_0: false);
					num = (int)((num2 * 1818166577) ^ 0x3C37E40);
					continue;
				case 0u:
					num = (int)((num2 * 1380823313) ^ 0x58A8F252);
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

	private void SearchBtn_Click(object sender, EventArgs e)
	{
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected I4, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected I4, but got Unknown
		//IL_02d0: Incompatible stack heights: 0 vs 1
		//IL_02e0: Incompatible stack heights: 0 vs 1
		//IL_02fb: Incompatible stack heights: 0 vs 1
		//IL_0302: Incompatible stack heights: 0 vs 1
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		bool flag = !MyProject.Forms.Form1.Name_Validation(SearchDonor_Admin.smethod_61(SearchDonor_Admin.smethod_60(NameSTxt))) | !MyProject.Forms.Form1.Mobile_Validator(SearchDonor_Admin.smethod_61(SearchDonor_Admin.smethod_60(MobileSTxt)));
		string string_ = default(string);
		DataTable dataTable = default(DataTable);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -462155066;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE8894F50u) % 8u)
				{
				case 6u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = -56822102;
						num7 = -56822102;
					}
					else
					{
						num6 = -561528529;
						num7 = -561528529;
					}
					num = num6 ^ (int)(num2 * 1198352596);
					continue;
				}
				case 4u:
					SearchDonor_Admin.smethod_66(myconnection);
					num = ((int)num2 * -1410450446) ^ -975886819;
					continue;
				case 3u:
					HideItemsOnForm();
					SearchDonor_Admin.smethod_63();
					num = (int)(num2 * 1107773315) ^ -864010584;
					continue;
				case 2u:
					num = -225012621;
					continue;
				case 1u:
					string_ = SearchDonor_Admin.smethod_64(new string[5]
					{
						"Select * From [Donor] Where [Name] Like '%",
						SearchDonor_Admin.smethod_61(SearchDonor_Admin.smethod_60(NameSTxt)),
						"%' And [Mobile] Like '%",
						SearchDonor_Admin.smethod_60(MobileSTxt),
						"%';"
					});
					dataTable = SearchDonor_Admin.smethod_65();
					num = (int)((num2 * 1161512070) ^ 0x36D1F65A);
					continue;
				case 0u:
					break;
				default:
					try
					{
						OleDbDataAdapter dbDataAdapter_ = SearchDonor_Admin.smethod_67(string_, myconnection);
						while (true)
						{
							int num3 = -2108734468;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xE8894F50u) % 11u)
								{
								case 10u:
									SearchDonor_Admin.smethod_62("No Result Found");
									num3 = ((int)num2 * -618913592) ^ -1250411525;
									continue;
								case 9u:
									num3 = -1477627739;
									continue;
								case 8u:
									SearchDonor_Admin.smethod_71(myconnection);
									num3 = ((int)num2 * -534161247) ^ -1534042235;
									continue;
								case 7u:
									SearchDonor_Admin.smethod_30((Control)(object)SearchResultGrid, bool_0: true);
									SearchDonor_Admin.smethod_71(myconnection);
									num3 = (int)((num2 * 1731474216) ^ 0xFAD1A5D);
									continue;
								case 5u:
									num3 = (int)(num2 * 1836932598) ^ -145524629;
									continue;
								case 3u:
									flag2 = SearchDonor_Admin.smethod_70(SearchResultGrid) == 1;
									num3 = (int)((num2 * 1634188630) ^ 0x6E334054);
									continue;
								case 1u:
									SearchDonor_Admin.smethod_68((DbDataAdapter)(object)dbDataAdapter_, dataTable);
									SearchDonor_Admin.smethod_69(SearchResultGrid, (object)dataTable);
									num3 = ((int)num2 * -615605388) ^ -1718898332;
									continue;
								case 0u:
								{
									int num4;
									int num5;
									if (flag2)
									{
										num4 = -1054259183;
										num5 = -1054259183;
									}
									else
									{
										num4 = -1811729463;
										num5 = -1811729463;
									}
									num3 = num4 ^ (int)(num2 * 731543175);
									continue;
								}
								default:
									return;
								case 4u:
									break;
								case 2u:
									return;
								case 6u:
									return;
								}
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						SearchDonor_Admin.smethod_72(exception_);
						while (true)
						{
							_ = -256850551;
							while (true)
							{
								_003F val = /*Error near IL_029d: Stack underflow*/^ -393654448;
								num2 = (uint)(int)val;
								switch (val % 5)
								{
								default:
									return;
								case 4:
									SearchDonor_Admin.smethod_73();
									_ = (num2 * 368499861) ^ 0x4F7D1B44;
									continue;
								case 1:
									_ = ((int)num2 * -382742533) ^ -60373822;
									continue;
								case 0:
									SearchDonor_Admin.smethod_71(myconnection);
									_ = (num2 * 1262146208) ^ 0x6814194E;
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
				case 7u:
					SearchDonor_Admin.smethod_62("No Results Found");
					return;
				}
				break;
			}
		}
	}

	private void UpdateBtn_Click(object sender, EventArgs e)
	{
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected I4, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected I4, but got Unknown
		//IL_037f: Incompatible stack heights: 0 vs 1
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Incompatible stack heights: 0 vs 1
		//IL_03b7: Incompatible stack heights: 0 vs 1
		//IL_03be: Incompatible stack heights: 0 vs 1
		string string_ = default(string);
		while (true)
		{
			int num = 64792572;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x29A7DFECu) % 11u)
				{
				case 10u:
				{
					int num6;
					int num7;
					if ((SearchDonor_Admin.smethod_74(SearchDonor_Admin.smethod_60(NameTxt), "", bool_0: false) == 0) | (SearchDonor_Admin.smethod_74(SearchDonor_Admin.smethod_60(MobileTxt), "", bool_0: false) == 0) | (SearchDonor_Admin.smethod_74(SearchDonor_Admin.smethod_75(GenderTxt), "", bool_0: false) == 0) | (SearchDonor_Admin.smethod_74(SearchDonor_Admin.smethod_60(DOBTxt), "", bool_0: false) == 0) | (SearchDonor_Admin.smethod_74(SearchDonor_Admin.smethod_75(BloodGroupTxt), "", bool_0: false) == 0))
					{
						num6 = 1414356180;
						num7 = 1414356180;
					}
					else
					{
						num6 = 309291;
						num7 = 309291;
					}
					num = num6 ^ ((int)num2 * -203799466);
					continue;
				}
				case 9u:
					num = 184803671;
					continue;
				case 8u:
					SearchDonor_Admin.smethod_62("Fields Cannot be empty");
					num = ((int)num2 * -881750714) ^ -1513921662;
					continue;
				case 7u:
					num = 1145384112;
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if (MyProject.Forms.Form1.Name_Validation(SearchDonor_Admin.smethod_61(SearchDonor_Admin.smethod_60(NameTxt))) & MyProject.Forms.Form1.Mobile_Validator(SearchDonor_Admin.smethod_60(MobileTxt)) & MyProject.Forms.Form1.age_validator(SearchDonor_Admin.smethod_60(DOBTxt)))
					{
						num4 = -595527880;
						num5 = -595527880;
					}
					else
					{
						num4 = -1477619045;
						num5 = -1477619045;
					}
					num = num4 ^ ((int)num2 * -188680943);
					continue;
				}
				case 3u:
					SearchDonor_Admin.smethod_66(myconnection);
					num = (int)(num2 * 505435044) ^ -867392462;
					continue;
				case 1u:
				{
					OleDbCommand val = SearchDonor_Admin.smethod_63();
					string_ = SearchDonor_Admin.smethod_64(new string[13]
					{
						"Update [Donor] Set [Name] = '",
						SearchDonor_Admin.smethod_60(NameTxt),
						"', [Mobile] = '",
						SearchDonor_Admin.smethod_60(MobileTxt),
						"', [Age] = ",
						SearchDonor_Admin.smethod_60(DOBTxt),
						", [Gender] = '",
						SearchDonor_Admin.smethod_75(GenderTxt),
						"', [Blood] = '",
						SearchDonor_Admin.smethod_75(BloodGroupTxt),
						"' Where [DID] = ",
						SearchDonor_Admin.smethod_60(IDTxt),
						";"
					});
					num = ((int)num2 * -1825984170) ^ -2053289929;
					continue;
				}
				case 0u:
					break;
				case 2u:
					SearchDonor_Admin.smethod_62("Invalid Credentitals");
					return;
				default:
					try
					{
						OleDbCommand val = SearchDonor_Admin.smethod_76(string_, myconnection);
						while (true)
						{
							int num3 = 706011297;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x29A7DFECu) % 6u)
								{
								case 5u:
									ClearDonorInfoBox();
									num3 = ((int)num2 * -1968786895) ^ -1153657931;
									continue;
								case 3u:
									SearchDonor_Admin.smethod_71(myconnection);
									UpdateTable();
									num3 = ((int)num2 * -1393606490) ^ 0x70483592;
									continue;
								case 2u:
									SearchDonor_Admin.smethod_62("Successfully Updated Details");
									num3 = (int)(num2 * 2119090613) ^ -1771752855;
									continue;
								case 1u:
									SearchDonor_Admin.smethod_77(val);
									SearchDonor_Admin.smethod_78((Component)(object)val);
									num3 = (int)(num2 * 1279780932) ^ -1809397841;
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
					catch (Exception ex)
					{
						SearchDonor_Admin.smethod_72(ex);
						Exception exception_ = ex;
						while (true)
						{
							_ = 2134842865;
							while (true)
							{
								_003F val2 = /*Error near IL_034c: Stack underflow*/^ 0x29A7DFEC;
								num2 = (uint)(int)val2;
								switch (val2 % 5)
								{
								default:
									return;
								case 4:
									SearchDonor_Admin.smethod_73();
									_ = (num2 * 2067176369) ^ 0x32E0B033;
									continue;
								case 3:
									SearchDonor_Admin.smethod_62(SearchDonor_Admin.smethod_79(exception_));
									_ = ((int)num2 * -1194420136) ^ -87730954;
									continue;
								case 1:
									SearchDonor_Admin.smethod_71(myconnection);
									_ = (num2 * 1994232086) ^ 0xCCA28D4Cu;
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
				case 5u:
					return;
				}
				break;
			}
		}
	}

	private void DeleteBtn_Click(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		if (SearchDonor_Admin.smethod_74(SearchDonor_Admin.smethod_60(IDTxt), "", bool_0: false) == 0)
		{
			goto IL_0081;
		}
		goto IL_00b4;
		IL_00b4:
		OleDbCommand val = SearchDonor_Admin.smethod_63();
		int num = 1333779427;
		goto IL_0086;
		IL_0086:
		string string_ = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x1E8BBE22u) % 7u)
			{
			case 4u:
				string_ = SearchDonor_Admin.smethod_80("Delete From [Donor] Where [DID] = ", SearchDonor_Admin.smethod_60(IDTxt), ";");
				num = ((int)num2 * -1806270557) ^ 0x5AF26DB5;
				continue;
			case 2u:
				SearchDonor_Admin.smethod_62("Nothing To Delete");
				num = (int)(num2 * 573370950) ^ -23260516;
				continue;
			case 1u:
				SearchDonor_Admin.smethod_66(myconnection);
				num = (int)((num2 * 1577412003) ^ 0x381B8EF6);
				continue;
			case 0u:
				break;
			case 5u:
				goto IL_00b4;
			default:
				try
				{
					while (true)
					{
						int num3 = 1889340497;
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0x1E8BBE22u) % 9u)
							{
							case 8u:
								num3 = ((int)num2 * -1723972590) ^ 0x6A6DB18B;
								continue;
							case 7u:
								ClearDonorInfoBox();
								num3 = (int)((num2 * 1030056197) ^ 0x42254934);
								continue;
							case 6u:
								SearchDonor_Admin.smethod_62("Successfully Deleted Entry");
								num3 = ((int)num2 * -847413103) ^ -1559348187;
								continue;
							case 5u:
								SearchDonor_Admin.smethod_77(val);
								SearchDonor_Admin.smethod_78((Component)(object)val);
								num3 = ((int)num2 * -1921676889) ^ -1320407931;
								continue;
							case 4u:
								UpdateTable();
								num3 = ((int)num2 * -1998416359) ^ -1684933078;
								continue;
							case 3u:
								SearchDonor_Admin.smethod_71(myconnection);
								num3 = ((int)num2 * -826764106) ^ -1006561969;
								continue;
							case 2u:
								val = SearchDonor_Admin.smethod_76(string_, myconnection);
								num3 = (int)(num2 * 837398286) ^ -1530539623;
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
				catch (Exception exception_)
				{
					SearchDonor_Admin.smethod_72(exception_);
					SearchDonor_Admin.smethod_71(myconnection);
					SearchDonor_Admin.smethod_73();
					return;
				}
			case 3u:
				return;
			}
			break;
		}
		goto IL_0081;
		IL_0081:
		num = 282847220;
		goto IL_0086;
	}

	private void SearchResultGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		try
		{
			while (true)
			{
				int num = 377054390;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3471FD13u) % 20u)
					{
					case 19u:
						num = ((int)num2 * -1270503484) ^ -1349839832;
						continue;
					case 18u:
						num = ((int)num2 * -1201219821) ^ 0x47926D8B;
						continue;
					case 17u:
						num = ((int)num2 * -1100806770) ^ 0x1975A288;
						continue;
					case 15u:
						SearchDonor_Admin.smethod_88(NameTxt, SearchDonor_Admin.smethod_87(SearchDonor_Admin.smethod_86(SearchDonor_Admin.smethod_85(SearchDonor_Admin.smethod_84(SearchDonor_Admin.smethod_83(SearchDonor_Admin.smethod_81(SearchResultGrid), SearchDonor_Admin.smethod_82(e))), 1))));
						num = ((int)num2 * -1809970365) ^ 0x2D97DF32;
						continue;
					case 14u:
						SearchDonor_Admin.smethod_89(BloodGroupTxt, SearchDonor_Admin.smethod_87(SearchDonor_Admin.smethod_86(SearchDonor_Admin.smethod_85(SearchDonor_Admin.smethod_84(SearchDonor_Admin.smethod_83(SearchDonor_Admin.smethod_81(SearchResultGrid), SearchDonor_Admin.smethod_82(e))), 4))));
						num = ((int)num2 * -1357073658) ^ -1892365892;
						continue;
					case 13u:
						SearchDonor_Admin.smethod_88(DateOfDonationTxt, SearchDonor_Admin.smethod_87(SearchDonor_Admin.smethod_86(SearchDonor_Admin.smethod_85(SearchDonor_Admin.smethod_84(SearchDonor_Admin.smethod_83(SearchDonor_Admin.smethod_81(SearchResultGrid), SearchDonor_Admin.smethod_82(e))), 6))));
						num = (int)((num2 * 1717045623) ^ 0x69C61495);
						continue;
					case 12u:
						SearchDonor_Admin.smethod_89(GenderTxt, SearchDonor_Admin.smethod_87(SearchDonor_Admin.smethod_86(SearchDonor_Admin.smethod_85(SearchDonor_Admin.smethod_84(SearchDonor_Admin.smethod_83(SearchDonor_Admin.smethod_81(SearchResultGrid), SearchDonor_Admin.smethod_82(e))), 2))));
						num = (int)((num2 * 914389434) ^ 0x61E9E186);
						continue;
					case 11u:
						SearchDonor_Admin.smethod_30((Control)(object)DonorInfoBox, bool_0: true);
						num = (int)(num2 * 1143164320) ^ -292136403;
						continue;
					case 10u:
						num = ((int)num2 * -726370230) ^ -1518169885;
						continue;
					case 9u:
						SearchDonor_Admin.smethod_88(QuantityTxt, SearchDonor_Admin.smethod_87(SearchDonor_Admin.smethod_86(SearchDonor_Admin.smethod_85(SearchDonor_Admin.smethod_84(SearchDonor_Admin.smethod_83(SearchDonor_Admin.smethod_81(SearchResultGrid), SearchDonor_Admin.smethod_82(e))), 7))));
						num = ((int)num2 * -1020154347) ^ -1816493819;
						continue;
					case 8u:
						num = ((int)num2 * -1155455878) ^ 0x2D65F5D7;
						continue;
					case 7u:
						num = ((int)num2 * -761616448) ^ -1990200536;
						continue;
					case 6u:
						SearchDonor_Admin.smethod_30((Control)(object)ClearBtn, bool_0: true);
						num = ((int)num2 * -1181646651) ^ 0x3386E9C9;
						continue;
					case 5u:
						SearchDonor_Admin.smethod_88(IDTxt, SearchDonor_Admin.smethod_87(SearchDonor_Admin.smethod_86(SearchDonor_Admin.smethod_85(SearchDonor_Admin.smethod_84(SearchDonor_Admin.smethod_83(SearchDonor_Admin.smethod_81(SearchResultGrid), SearchDonor_Admin.smethod_82(e))), 0))));
						num = (int)(num2 * 114261040) ^ -1525444732;
						continue;
					case 4u:
						SearchDonor_Admin.smethod_30((Control)(object)DeleteBtn, bool_0: true);
						num = (int)((num2 * 68191289) ^ 0x1AB47A59);
						continue;
					case 3u:
						SearchDonor_Admin.smethod_88(MobileTxt, SearchDonor_Admin.smethod_87(SearchDonor_Admin.smethod_86(SearchDonor_Admin.smethod_85(SearchDonor_Admin.smethod_84(SearchDonor_Admin.smethod_83(SearchDonor_Admin.smethod_81(SearchResultGrid), SearchDonor_Admin.smethod_82(e))), 5))));
						num = (int)((num2 * 170558094) ^ 0x46CFC954);
						continue;
					case 1u:
						SearchDonor_Admin.smethod_88(DOBTxt, SearchDonor_Admin.smethod_87(SearchDonor_Admin.smethod_86(SearchDonor_Admin.smethod_85(SearchDonor_Admin.smethod_84(SearchDonor_Admin.smethod_83(SearchDonor_Admin.smethod_81(SearchResultGrid), SearchDonor_Admin.smethod_82(e))), 3))));
						num = (int)(num2 * 1811319833) ^ -862555316;
						continue;
					case 0u:
						SearchDonor_Admin.smethod_30((Control)(object)UpdateBtn, bool_0: true);
						num = (int)(num2 * 1577016027) ^ -713323087;
						continue;
					default:
						return;
					case 16u:
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
			SearchDonor_Admin.smethod_72(exception_);
			SearchDonor_Admin.smethod_73();
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
			int num = 1832354475;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x720CF997u) % 14u)
				{
				case 13u:
					SearchDonor_Admin.smethod_90((TextBoxBase)(object)DOBTxt);
					num = ((int)num2 * -1621924533) ^ -505175378;
					continue;
				case 10u:
					SearchDonor_Admin.smethod_90((TextBoxBase)(object)MobileTxt);
					num = (int)(num2 * 1013430247) ^ -1274545540;
					continue;
				case 9u:
					num = ((int)num2 * -1099745194) ^ -1488461242;
					continue;
				case 8u:
					SearchDonor_Admin.smethod_90((TextBoxBase)(object)IDTxt);
					num = (int)(num2 * 842049722) ^ -814770634;
					continue;
				case 7u:
					num = ((int)num2 * -111481938) ^ 0x4849CCF2;
					continue;
				case 6u:
					result = true;
					num = ((int)num2 * -926268878) ^ -1417111462;
					continue;
				case 5u:
					SearchDonor_Admin.smethod_90((TextBoxBase)(object)NameTxt);
					num = (int)(num2 * 959030905) ^ -408777336;
					continue;
				case 4u:
					num = ((int)num2 * -1325393046) ^ 0x42881FC5;
					continue;
				case 3u:
					num = ((int)num2 * -1061275267) ^ -1351652784;
					continue;
				case 2u:
					SearchDonor_Admin.smethod_90((TextBoxBase)(object)QuantityTxt);
					num = ((int)num2 * -1839749428) ^ -1038665987;
					continue;
				case 1u:
					SearchDonor_Admin.smethod_91(BloodGroupTxt, -1);
					num = (int)(num2 * 1645759083) ^ -733749741;
					continue;
				case 0u:
					SearchDonor_Admin.smethod_90((TextBoxBase)(object)DateOfDonationTxt);
					SearchDonor_Admin.smethod_91(GenderTxt, -1);
					num = (int)(num2 * 83597095) ^ -1571033994;
					continue;
				case 12u:
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
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected I4, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected I4, but got Unknown
		//IL_0213: Incompatible stack heights: 0 vs 1
		//IL_021a: Incompatible stack heights: 0 vs 1
		string string_ = default(string);
		while (true)
		{
			int num = 239502145;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x842575Cu) % 4u)
				{
				case 3u:
					string_ = SearchDonor_Admin.smethod_64(new string[5]
					{
						"Select * From [Donor] Where [Name] Like '%",
						SearchDonor_Admin.smethod_61(SearchDonor_Admin.smethod_60(NameSTxt)),
						"%' And [Mobile] Like '%",
						SearchDonor_Admin.smethod_60(MobileTxt),
						"%';"
					});
					num = (int)((num2 * 2014249838) ^ 0x22AAF2CC);
					continue;
				case 1u:
					SearchDonor_Admin.smethod_63();
					num = (int)((num2 * 313066584) ^ 0x6F085C8F);
					continue;
				case 0u:
					break;
				default:
				{
					DataTable dataTable = SearchDonor_Admin.smethod_65();
					SearchDonor_Admin.smethod_66(myconnection);
					try
					{
						OleDbDataAdapter dbDataAdapter_ = SearchDonor_Admin.smethod_67(string_, myconnection);
						while (true)
						{
							IL_01be:
							int num3 = 1745166176;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x842575Cu) % 10u)
								{
								case 9u:
									SearchDonor_Admin.smethod_30((Control)(object)SearchResultGrid, bool_0: true);
									num3 = (int)(num2 * 89770719) ^ -75473742;
									continue;
								case 8u:
									num3 = (int)((num2 * 615496628) ^ 0x7FC83214);
									continue;
								case 7u:
									num3 = 1612728051;
									continue;
								case 4u:
									SearchDonor_Admin.smethod_68((DbDataAdapter)(object)dbDataAdapter_, dataTable);
									num3 = (int)(num2 * 618422191) ^ -645991548;
									continue;
								case 3u:
									SearchDonor_Admin.smethod_71(myconnection);
									num3 = ((int)num2 * -543199638) ^ 0x2228C212;
									continue;
								case 2u:
								{
									SearchDonor_Admin.smethod_69(SearchResultGrid, (object)dataTable);
									int num4;
									int num5;
									if (SearchDonor_Admin.smethod_70(SearchResultGrid) == 1)
									{
										num4 = -1368343199;
										num5 = -1368343199;
									}
									else
									{
										num4 = -272354777;
										num5 = -272354777;
									}
									num3 = num4 ^ (int)(num2 * 882646088);
									continue;
								}
								case 1u:
									SearchDonor_Admin.smethod_71(myconnection);
									num3 = (int)((num2 * 1350393496) ^ 0x1E356178);
									continue;
								default:
									goto end_IL_0183;
								case 5u:
									break;
								case 0u:
									return false;
								case 6u:
									goto end_IL_0183;
								}
								goto IL_01be;
								continue;
								end_IL_0183:
								break;
							}
							break;
						}
					}
					catch (Exception exception_)
					{
						SearchDonor_Admin.smethod_72(exception_);
						SearchDonor_Admin.smethod_71(myconnection);
						while (true)
						{
							IL_0215:
							_ = 1069869053;
							while (true)
							{
								_003F val = /*Error near IL_01e8: Stack underflow*/^ 0x842575C;
								num2 = (uint)(int)val;
								switch (val % 3)
								{
								default:
									goto end_IL_01e2;
								case 1:
									SearchDonor_Admin.smethod_73();
									_ = (num2 * 925131091) ^ 0x420353A2;
									continue;
								case 2:
									break;
								case 0:
									goto end_IL_01e2;
								}
								goto IL_0215;
								continue;
								end_IL_01e2:
								break;
							}
							break;
						}
					}
					bool result = true;
					while (true)
					{
						int num6 = 1123074029;
						while (true)
						{
							switch ((num2 = (uint)num6 ^ 0x842575Cu) % 3u)
							{
							case 1u:
								goto IL_0222;
							case 2u:
								break;
							default:
								return result;
							}
							break;
							IL_0222:
							num6 = (int)((num2 * 1974225307) ^ 0x2223086A);
						}
					}
				}
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

	static DataGridView smethod_5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DataGridView();
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

	static TextBox smethod_8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
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

	static void smethod_25(DataGridView dataGridView_0, Color color_0)
	{
		dataGridView_0.set_BackgroundColor(color_0);
	}

	static void smethod_26(DataGridView dataGridView_0, DataGridViewColumnHeadersHeightSizeMode dataGridViewColumnHeadersHeightSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		dataGridView_0.set_ColumnHeadersHeightSizeMode(dataGridViewColumnHeadersHeightSizeMode_0);
	}

	static void smethod_27(DataGridView dataGridView_0, bool bool_0)
	{
		dataGridView_0.set_ReadOnly(bool_0);
	}

	static DataGridViewRow smethod_28(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_RowTemplate();
	}

	static void smethod_29(DataGridViewRow dataGridViewRow_0, int int_0)
	{
		dataGridViewRow_0.set_Height(int_0);
	}

	static void smethod_30(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
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

	static ControlCollection smethod_35(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_36(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_37(GroupBox groupBox_0, bool bool_0)
	{
		groupBox_0.set_TabStop(bool_0);
	}

	static void smethod_38(GroupBox groupBox_0, string string_0)
	{
		groupBox_0.set_Text(string_0);
	}

	static void smethod_39(ComboBox comboBox_0, ComboBoxStyle comboBoxStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		comboBox_0.set_DropDownStyle(comboBoxStyle_0);
	}

	static void smethod_40(ListControl listControl_0, bool bool_0)
	{
		listControl_0.set_FormattingEnabled(bool_0);
	}

	static ObjectCollection smethod_41(ComboBox comboBox_0)
	{
		return comboBox_0.get_Items();
	}

	static void smethod_42(ObjectCollection objectCollection_0, object[] object_0)
	{
		objectCollection_0.AddRange(object_0);
	}

	static void smethod_43(TextBoxBase textBoxBase_0, bool bool_0)
	{
		textBoxBase_0.set_ReadOnly(bool_0);
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

	static void smethod_54(DataGridView dataGridView_0, DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler_0)
	{
		dataGridView_0.remove_CellMouseClick(dataGridViewCellMouseEventHandler_0);
	}

	static void smethod_55(DataGridView dataGridView_0, DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler_0)
	{
		dataGridView_0.add_CellMouseClick(dataGridViewCellMouseEventHandler_0);
	}

	static void smethod_56(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_57(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
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

	static string smethod_79(Exception exception_0)
	{
		return exception_0.Message;
	}

	static string smethod_80(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static DataGridViewRowCollection smethod_81(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_Rows();
	}

	static int smethod_82(DataGridViewCellMouseEventArgs dataGridViewCellMouseEventArgs_0)
	{
		return dataGridViewCellMouseEventArgs_0.get_RowIndex();
	}

	static DataGridViewRow smethod_83(DataGridViewRowCollection dataGridViewRowCollection_0, int int_0)
	{
		return dataGridViewRowCollection_0.get_Item(int_0);
	}

	static DataGridViewCellCollection smethod_84(DataGridViewRow dataGridViewRow_0)
	{
		return dataGridViewRow_0.get_Cells();
	}

	static DataGridViewCell smethod_85(DataGridViewCellCollection dataGridViewCellCollection_0, int int_0)
	{
		return dataGridViewCellCollection_0.get_Item(int_0);
	}

	static object smethod_86(DataGridViewCell dataGridViewCell_0)
	{
		return dataGridViewCell_0.get_Value();
	}

	static string smethod_87(object object_0)
	{
		return Conversions.ToString(object_0);
	}

	static void smethod_88(TextBox textBox_0, string string_0)
	{
		textBox_0.set_Text(string_0);
	}

	static void smethod_89(ComboBox comboBox_0, string string_0)
	{
		comboBox_0.set_Text(string_0);
	}

	static void smethod_90(TextBoxBase textBoxBase_0)
	{
		textBoxBase_0.Clear();
	}

	static void smethod_91(ComboBox comboBox_0, int int_0)
	{
		comboBox_0.set_SelectedIndex(int_0);
	}
}
