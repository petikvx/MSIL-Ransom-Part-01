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
			DataGridView searchResultGrid = _SearchResultGrid;
			if (searchResultGrid != null)
			{
				goto IL_003c;
			}
			goto IL_0088;
			IL_0088:
			_SearchResultGrid = value;
			searchResultGrid = _SearchResultGrid;
			int num;
			int num2;
			if (searchResultGrid == null)
			{
				num = 2139136779;
				num2 = 2139136779;
			}
			else
			{
				num = 922509760;
				num2 = 922509760;
			}
			goto IL_0057;
			IL_0057:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num ^ 0xBF5CAD2u) % 5u)
				{
				case 4u:
					SearchDonor_Admin.smethod_55(searchResultGrid, dataGridViewCellMouseEventHandler_);
					num = ((int)num3 * -961069914) ^ 0x71BB86A7;
					continue;
				case 3u:
					break;
				case 2u:
					SearchDonor_Admin.smethod_54(searchResultGrid, dataGridViewCellMouseEventHandler_);
					num = ((int)num3 * -361753018) ^ 0x364776D9;
					continue;
				default:
					return;
				case 1u:
					goto IL_0088;
				case 0u:
					return;
				}
				break;
			}
			goto IL_003c;
			IL_003c:
			num = 13649335;
			goto IL_0057;
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
			Button deleteBtn = default(Button);
			while (true)
			{
				int num = -2079229084;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDE00926Au) % 8u)
					{
					case 7u:
					{
						int num5;
						int num6;
						if (deleteBtn != null)
						{
							num5 = 1590991822;
							num6 = 1590991822;
						}
						else
						{
							num5 = 197236559;
							num6 = 197236559;
						}
						num = num5 ^ ((int)num2 * -332940071);
						continue;
					}
					case 6u:
						deleteBtn = _DeleteBtn;
						num = (int)((num2 * 1046538879) ^ 0x1F51F8E7);
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (deleteBtn != null)
						{
							num3 = 271427638;
							num4 = 271427638;
						}
						else
						{
							num3 = 1784235331;
							num4 = 1784235331;
						}
						num = num3 ^ ((int)num2 * -1148075440);
						continue;
					}
					case 4u:
						SearchDonor_Admin.smethod_57((Control)(object)deleteBtn, eventHandler_);
						num = ((int)num2 * -646700285) ^ 0x7061F9B7;
						continue;
					case 3u:
						SearchDonor_Admin.smethod_56((Control)(object)deleteBtn, eventHandler_);
						num = (int)((num2 * 1241947249) ^ 0x267BF5BB);
						continue;
					case 2u:
						_DeleteBtn = value;
						deleteBtn = _DeleteBtn;
						num = -2108252105;
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
				int num = 1761634469;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2CDEA36Fu) % 7u)
					{
					case 6u:
						_SearchBtn = value;
						num = 309497134;
						continue;
					case 4u:
					{
						searchBtn = _SearchBtn;
						int num5;
						int num6;
						if (searchBtn == null)
						{
							num5 = -1568422081;
							num6 = -1568422081;
						}
						else
						{
							num5 = -1350721233;
							num6 = -1350721233;
						}
						num = num5 ^ (int)(num2 * 1589866791);
						continue;
					}
					case 3u:
						SearchDonor_Admin.smethod_57((Control)(object)searchBtn, eventHandler_);
						num = ((int)num2 * -951399044) ^ 0x9683C;
						continue;
					case 1u:
					{
						searchBtn = _SearchBtn;
						int num3;
						int num4;
						if (searchBtn != null)
						{
							num3 = 1058851208;
							num4 = 1058851208;
						}
						else
						{
							num3 = 1387635340;
							num4 = 1387635340;
						}
						num = num3 ^ ((int)num2 * -202724497);
						continue;
					}
					case 0u:
						SearchDonor_Admin.smethod_56((Control)(object)searchBtn, eventHandler_);
						num = ((int)num2 * -2107195007) ^ 0x73CC61EB;
						continue;
					default:
						return;
					case 2u:
						break;
					case 5u:
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
			Button clearBtn = default(Button);
			while (true)
			{
				int num = 142345409;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x55E323EDu) % 8u)
					{
					case 6u:
						SearchDonor_Admin.smethod_57((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -1663675265) ^ -1277477321;
						continue;
					case 5u:
					{
						int num5;
						int num6;
						if (clearBtn != null)
						{
							num5 = 514215417;
							num6 = 514215417;
						}
						else
						{
							num5 = 1486773983;
							num6 = 1486773983;
						}
						num = num5 ^ (int)(num2 * 1922084786);
						continue;
					}
					case 4u:
						clearBtn = _ClearBtn;
						num = ((int)num2 * -1499022360) ^ 0x398037D4;
						continue;
					case 3u:
						SearchDonor_Admin.smethod_56((Control)(object)clearBtn, eventHandler_);
						num = (int)(num2 * 641574436) ^ -1317305909;
						continue;
					case 2u:
						_ClearBtn = value;
						clearBtn = _ClearBtn;
						num = 1033866920;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (clearBtn != null)
						{
							num3 = 374861668;
							num4 = 374861668;
						}
						else
						{
							num3 = 1609040517;
							num4 = 1609040517;
						}
						num = num3 ^ ((int)num2 * -1943133550);
						continue;
					}
					default:
						return;
					case 7u:
						break;
					case 0u:
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
				int num = -9840405;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x97E2D4CEu) % 9u)
					{
					case 8u:
						_UpdateBtn = value;
						num = -1210937027;
						continue;
					case 7u:
						SearchDonor_Admin.smethod_57((Control)(object)updateBtn, eventHandler_);
						num = (int)(num2 * 2144193513) ^ -556140574;
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (updateBtn == null)
						{
							num5 = -1467917620;
							num6 = -1467917620;
						}
						else
						{
							num5 = -1946761800;
							num6 = -1946761800;
						}
						num = num5 ^ ((int)num2 * -912947137);
						continue;
					}
					case 5u:
						updateBtn = _UpdateBtn;
						num = (int)(num2 * 716195368) ^ -6238425;
						continue;
					case 4u:
						SearchDonor_Admin.smethod_56((Control)(object)updateBtn, eventHandler_);
						num = ((int)num2 * -1172704922) ^ 0x600C4618;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (updateBtn != null)
						{
							num3 = 1188376835;
							num4 = 1188376835;
						}
						else
						{
							num3 = 496499250;
							num4 = 496499250;
						}
						num = num3 ^ (int)(num2 * 1575601006);
						continue;
					}
					case 1u:
						updateBtn = _UpdateBtn;
						num = (int)(num2 * 1539260875) ^ -2074867053;
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
			int num = -1255594888;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBEC69050u) % 6u)
				{
				case 3u:
					SearchDonor_Admin.smethod_0((UserControl)(object)this, (EventHandler)SearchDonor_Admin_Load);
					num = (int)(num2 * 997389374) ^ -1776354179;
					continue;
				case 2u:
					num = ((int)num2 * -54183440) ^ 0x396422C1;
					continue;
				case 1u:
					num = (int)(num2 * 685813786) ^ -1869313616;
					continue;
				case 0u:
					myconnection = SearchDonor_Admin.smethod_1();
					InitializeComponent();
					num = (int)(num2 * 1842652232) ^ -200869589;
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

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing)
			{
				goto IL_0056;
			}
			goto IL_0093;
			IL_0056:
			int num = -1380620840;
			goto IL_005b;
			IL_005b:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBC639E18u) % 7u)
				{
				case 5u:
					num = ((int)num2 * -779390811) ^ 0x6D77A65B;
					continue;
				case 4u:
					num = -1204454183;
					continue;
				case 2u:
					SearchDonor_Admin.smethod_2((IDisposable)components);
					num = ((int)num2 * -343741514) ^ 0x3A470D1A;
					continue;
				case 1u:
					num = (int)(num2 * 203099388) ^ -1677190117;
					continue;
				case 0u:
					break;
				default:
					return;
				case 3u:
					goto IL_0088;
				case 6u:
					return;
				}
				break;
				IL_0088:
				if (components != null)
				{
					num = -1171730605;
					num3 = -1171730605;
					continue;
				}
				goto IL_0093;
			}
			goto IL_0056;
			IL_0093:
			num = -1003804753;
			num3 = -1003804753;
			goto IL_005b;
		}
		finally
		{
			((ContainerControl)this).Dispose(disposing);
			while (true)
			{
				IL_00de:
				int num4 = -673828478;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num4 ^ 0xBC639E18u) % 3u)
					{
					case 2u:
						goto IL_00b4;
					default:
						goto end_IL_00c1;
					case 0u:
						break;
					case 1u:
						goto end_IL_00c1;
					}
					goto IL_00de;
					IL_00b4:
					num4 = ((int)num2 * -1873458529) ^ -1938835044;
					continue;
					end_IL_00c1:
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
			int num = -1104585828;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA1282FD2u) % 321u)
				{
				case 320u:
					SearchDonor_Admin.smethod_22((Control)(object)Label8, 9);
					num = ((int)num2 * -825659050) ^ -28901707;
					continue;
				case 319u:
					SearchDonor_Admin.smethod_15((Control)(object)SearchBtn, "SearchBtn");
					SearchDonor_Admin.smethod_16((Control)(object)SearchBtn, new Size(133, 37));
					num = (int)((num2 * 1292151310) ^ 0x1AC65AA0);
					continue;
				case 318u:
					Label4 = SearchDonor_Admin.smethod_4();
					num = ((int)num2 * -403568945) ^ -1718507407;
					continue;
				case 317u:
					num = ((int)num2 * -1839019229) ^ -634601792;
					continue;
				case 316u:
					SearchDonor_Admin.smethod_16((Control)(object)Label8, new Size(77, 28));
					num = (int)(num2 * 1732549) ^ -1756892686;
					continue;
				case 315u:
					num = (int)((num2 * 474715216) ^ 0x524A162D);
					continue;
				case 314u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_47((Control)(object)this), (Control)(object)PictureBox1);
					num = (int)(num2 * 1299098738) ^ -381348217;
					continue;
				case 313u:
					num = ((int)num2 * -929672479) ^ -1111126227;
					continue;
				case 312u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)BloodGroupTxt);
					num = (int)((num2 * 1142141204) ^ 0x708C6B11);
					continue;
				case 311u:
					SearchDonor_Admin.smethod_15((Control)(object)SearchResultGrid, "SearchResultGrid");
					num = ((int)num2 * -1276830455) ^ -413032949;
					continue;
				case 310u:
					num = ((int)num2 * -1873701195) ^ -1684140195;
					continue;
				case 309u:
					SearchDonor_Admin.smethod_53((Control)(object)this, bool_0: false);
					num = (int)((num2 * 297138077) ^ 0x5CDEEFB);
					continue;
				case 308u:
					SearchDonor_Admin.smethod_24(Label2, (ContentAlignment)32);
					SearchDonor_Admin.smethod_14((Control)(object)MobileSTxt, new Point(120, 86));
					num = (int)(num2 * 961865552) ^ -976144622;
					continue;
				case 307u:
					SearchDonor_Admin.smethod_16((Control)(object)DOBTxt, new Size(169, 28));
					num = (int)(num2 * 1734259964) ^ -1818964027;
					continue;
				case 306u:
					num = (int)((num2 * 1521699983) ^ 0x6715AC49);
					continue;
				case 305u:
					SearchDonor_Admin.smethod_15((Control)(object)DonorInfoBox, "DonorInfoBox");
					num = ((int)num2 * -1819399734) ^ -1872166959;
					continue;
				case 304u:
					SearchDonor_Admin.smethod_22((Control)(object)GroupBox1, 14);
					num = (int)(num2 * 1588153765) ^ -1194658785;
					continue;
				case 303u:
					MobileSTxt = SearchDonor_Admin.smethod_8();
					num = ((int)num2 * -343652548) ^ -2071262553;
					continue;
				case 302u:
					SearchDonor_Admin.smethod_31((ButtonBase)(object)UpdateBtn, Color.MidnightBlue);
					SearchDonor_Admin.smethod_21((Control)(object)UpdateBtn, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 642390469) ^ 0x4A2555D4);
					continue;
				case 301u:
					SearchDonor_Admin.smethod_14((Control)(object)SearchBtn, new Point(468, 82));
					num = ((int)num2 * -983599316) ^ 0x10E42532;
					continue;
				case 300u:
					num = (int)(num2 * 1259733539) ^ -519028442;
					continue;
				case 299u:
					SearchDonor_Admin.smethod_52((Control)(object)DonorInfoBox);
					num = (int)((num2 * 1563714081) ^ 0x2319FA74);
					continue;
				case 298u:
					num = ((int)num2 * -183057883) ^ 0x762A67C5;
					continue;
				case 297u:
					num = ((int)num2 * -1695628949) ^ 0x47C299DE;
					continue;
				case 296u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)MobileTxt);
					num = ((int)num2 * -1961494039) ^ -1978337515;
					continue;
				case 295u:
					SearchDonor_Admin.smethod_44((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -1266171859) ^ 0x603345DC;
					continue;
				case 294u:
					num = (int)(num2 * 1568473056) ^ -1799697103;
					continue;
				case 293u:
					SearchDonor_Admin.smethod_22((Control)(object)IDTxt, 17);
					SearchDonor_Admin.smethod_21((Control)(object)Label11, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchDonor_Admin.smethod_14((Control)(object)Label11, new Point(16, 36));
					num = ((int)num2 * -1065875480) ^ -290869560;
					continue;
				case 292u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)GroupBox1), (Control)(object)SearchBtn);
					num = (int)((num2 * 1804740521) ^ 0x1BA9F28F);
					continue;
				case 291u:
					num = (int)(num2 * 628894446) ^ -710340958;
					continue;
				case 290u:
					num = ((int)num2 * -1375257007) ^ -1011684366;
					continue;
				case 289u:
					num = ((int)num2 * -599299746) ^ -2114397893;
					continue;
				case 288u:
					SearchDonor_Admin.smethod_23(Label4, "Blood Group : ");
					num = ((int)num2 * -739778787) ^ 0x3146A194;
					continue;
				case 287u:
					SearchDonor_Admin.smethod_21((Control)(object)Label2, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1153171008) ^ -450915332;
					continue;
				case 286u:
					SearchDonor_Admin.smethod_21((Control)(object)Label6, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -931973933) ^ -1696883347;
					continue;
				case 285u:
					SearchDonor_Admin.smethod_10((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -271555176) ^ -637866268;
					continue;
				case 284u:
					SearchDonor_Admin.smethod_14((Control)(object)Label6, new Point(401, 129));
					SearchDonor_Admin.smethod_15((Control)(object)Label6, "Label6");
					num = (int)((num2 * 735473942) ^ 0x4677403E);
					continue;
				case 283u:
					num = (int)(num2 * 27827509) ^ -902389130;
					continue;
				case 282u:
					SearchDonor_Admin.smethod_17(PictureBox1, (PictureBoxSizeMode)1);
					num = (int)((num2 * 1321270753) ^ 0x5D0FD1AF);
					continue;
				case 281u:
					SearchDonor_Admin.smethod_16((Control)(object)GroupBox1, new Size(623, 128));
					num = (int)(num2 * 228350779) ^ -693251261;
					continue;
				case 280u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_47((Control)(object)this), (Control)(object)SearchResultGrid);
					num = ((int)num2 * -1326151674) ^ -73578852;
					continue;
				case 279u:
					SearchDonor_Admin.smethod_22((Control)(object)MobileSTxt, 2);
					num = ((int)num2 * -563712298) ^ -1082954505;
					continue;
				case 278u:
					SearchDonor_Admin.smethod_21((Control)(object)ClearBtn, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchDonor_Admin.smethod_32((Control)(object)ClearBtn, Color.White);
					num = ((int)num2 * -291630961) ^ 0x1BE141BA;
					continue;
				case 277u:
					SearchBtn = SearchDonor_Admin.smethod_6();
					num = ((int)num2 * -245659337) ^ -98344351;
					continue;
				case 276u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)QuantityTxt);
					num = (int)(num2 * 2073254299) ^ -448161743;
					continue;
				case 275u:
					Label2 = SearchDonor_Admin.smethod_4();
					num = (int)((num2 * 601208496) ^ 0x1B137ABA);
					continue;
				case 274u:
					num = (int)((num2 * 1265773546) ^ 0x7264674);
					continue;
				case 273u:
					SearchDonor_Admin.smethod_22((Control)(object)MobileTxt, 12);
					num = ((int)num2 * -528819382) ^ -350184184;
					continue;
				case 272u:
					num = ((int)num2 * -1585434342) ^ 0x27EF0F86;
					continue;
				case 271u:
					num = (int)(num2 * 1394440612) ^ -749015672;
					continue;
				case 270u:
					num = ((int)num2 * -242022754) ^ 0x37F6F9A5;
					continue;
				case 269u:
					num = (int)(num2 * 1562858902) ^ -1071125106;
					continue;
				case 268u:
					num = ((int)num2 * -1758644939) ^ -1902945563;
					continue;
				case 267u:
					num = ((int)num2 * -1323226098) ^ -461731232;
					continue;
				case 266u:
					Label12 = SearchDonor_Admin.smethod_4();
					num = ((int)num2 * -296663756) ^ 0x5DCC3A6B;
					continue;
				case 265u:
					num = ((int)num2 * -1756922390) ^ -1836105149;
					continue;
				case 264u:
					num = ((int)num2 * -1383277308) ^ 0x19229DCF;
					continue;
				case 263u:
					SearchDonor_Admin.smethod_16((Control)(object)GenderTxt, new Size(146, 30));
					num = (int)((num2 * 2130385235) ^ 0x72056EBB);
					continue;
				case 262u:
					num = (int)((num2 * 680908885) ^ 0x1920D18F);
					continue;
				case 261u:
					SearchDonor_Admin.smethod_16((Control)(object)Label2, new Size(77, 28));
					num = (int)((num2 * 30801156) ^ 0xF6A8562);
					continue;
				case 260u:
					SearchDonor_Admin.smethod_16((Control)(object)UpdateBtn, new Size(104, 37));
					num = (int)(num2 * 1184376905) ^ -1185269889;
					continue;
				case 259u:
					SearchDonor_Admin.smethod_46((Control)(object)this, Color.White);
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_47((Control)(object)this), (Control)(object)UpdateBtn);
					num = ((int)num2 * -101042631) ^ -342895439;
					continue;
				case 258u:
					SearchDonor_Admin.smethod_43((TextBoxBase)(object)IDTxt, bool_0: true);
					num = ((int)num2 * -1465769697) ^ -1501104276;
					continue;
				case 257u:
					num = (int)((num2 * 1617794610) ^ 0x5D7E852);
					continue;
				case 256u:
					SearchDonor_Admin.smethod_29(SearchDonor_Admin.smethod_28(SearchResultGrid), 24);
					num = ((int)num2 * -1283195876) ^ -1686558694;
					continue;
				case 255u:
					SearchDonor_Admin.smethod_14((Control)(object)Label5, new Point(16, 169));
					num = (int)((num2 * 1671208668) ^ 0x691EEA9E);
					continue;
				case 254u:
					SearchDonor_Admin.smethod_23(Label8, "Name : ");
					num = ((int)num2 * -633217056) ^ 0x1DA6B6AA;
					continue;
				case 253u:
					num = ((int)num2 * -2118339948) ^ -1189367779;
					continue;
				case 252u:
					num = ((int)num2 * -1662333432) ^ 0x2772CF0C;
					continue;
				case 251u:
					SearchDonor_Admin.smethod_16((Control)(object)MobileSTxt, new Size(237, 28));
					num = (int)((num2 * 751437205) ^ 0x1FA5EAE0);
					continue;
				case 250u:
					SearchDonor_Admin.smethod_48((Control)(object)this, "SearchDonor_Admin");
					SearchDonor_Admin.smethod_49((Control)(object)this, new Size(977, 804));
					num = ((int)num2 * -663804079) ^ -1604443667;
					continue;
				case 249u:
					SearchDonor_Admin.smethod_23(Label9, "Phone : ");
					num = ((int)num2 * -1343082552) ^ -873222211;
					continue;
				case 248u:
					num = ((int)num2 * -1368924484) ^ 0x41B50471;
					continue;
				case 247u:
					num = (int)((num2 * 1125714121) ^ 0x6C003EB0);
					continue;
				case 246u:
					SearchDonor_Admin.smethod_14((Control)(object)IDTxt, new Point(117, 36));
					num = (int)((num2 * 1178112319) ^ 0x53634D5);
					continue;
				case 245u:
					SearchDonor_Admin.smethod_14((Control)(object)DeleteBtn, new Point(808, 588));
					num = ((int)num2 * -733994004) ^ -93036415;
					continue;
				case 244u:
					SearchDonor_Admin.smethod_52((Control)(object)GroupBox1);
					num = ((int)num2 * -962004856) ^ -1621417838;
					continue;
				case 243u:
					SearchDonor_Admin.smethod_51((Control)(object)GroupBox1, bool_0: false);
					num = (int)(num2 * 672903879) ^ -1034206449;
					continue;
				case 242u:
					num = (int)(num2 * 811282848) ^ -41657160;
					continue;
				case 241u:
					SearchDonor_Admin.smethod_15((Control)(object)MobileTxt, "MobileTxt");
					num = (int)(num2 * 1417033182) ^ -1081360599;
					continue;
				case 240u:
					SearchDonor_Admin.smethod_15((Control)(object)PictureBox1, "PictureBox1");
					num = ((int)num2 * -2093179735) ^ -1814434924;
					continue;
				case 239u:
					SearchDonor_Admin.smethod_15((Control)(object)NameTxt, "NameTxt");
					num = (int)((num2 * 1965717566) ^ 0x3132988B);
					continue;
				case 238u:
					SearchDonor_Admin.smethod_16((Control)(object)MobileTxt, new Size(271, 28));
					num = (int)((num2 * 2104381983) ^ 0x14B05082);
					continue;
				case 237u:
					SearchDonor_Admin.smethod_22((Control)(object)Label3, 0);
					num = ((int)num2 * -1259832133) ^ -1389633467;
					continue;
				case 236u:
					num = ((int)num2 * -1785265862) ^ 0x19E1750B;
					continue;
				case 235u:
					SearchDonor_Admin.smethod_16((Control)(object)ClearBtn, new Size(104, 37));
					SearchDonor_Admin.smethod_22((Control)(object)ClearBtn, 12);
					num = ((int)num2 * -846950782) ^ -1138383588;
					continue;
				case 234u:
					SearchDonor_Admin.smethod_15((Control)(object)MobileSTxt, "MobileSTxt");
					num = (int)((num2 * 1377766494) ^ 0x274D1CDC);
					continue;
				case 233u:
					SearchDonor_Admin.smethod_22((Control)(object)SearchBtn, 4);
					num = (int)((num2 * 1048797698) ^ 0x2628C6D3);
					continue;
				case 232u:
					SearchDonor_Admin.smethod_32((Control)(object)UpdateBtn, Color.White);
					num = ((int)num2 * -974544143) ^ 0x31D67160;
					continue;
				case 231u:
					SearchDonor_Admin.smethod_14((Control)(object)Label4, new Point(388, 164));
					num = (int)((num2 * 1504728369) ^ 0x76D08ED7);
					continue;
				case 230u:
					SearchDonor_Admin.smethod_16((Control)(object)IDTxt, new Size(204, 28));
					num = ((int)num2 * -302051824) ^ 0x53D7608A;
					continue;
				case 229u:
					num = ((int)num2 * -87996060) ^ -1002037321;
					continue;
				case 228u:
					num = (int)(num2 * 507615108) ^ -282889293;
					continue;
				case 227u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)Label9);
					num = ((int)num2 * -676598232) ^ 0x3FF25943;
					continue;
				case 226u:
					num = (int)((num2 * 994597254) ^ 0x322B1989);
					continue;
				case 225u:
					SearchDonor_Admin.smethod_15((Control)(object)Label1, "Label1");
					num = (int)(num2 * 361610719) ^ -1164447298;
					continue;
				case 224u:
					DOBTxt = SearchDonor_Admin.smethod_8();
					NameTxt = SearchDonor_Admin.smethod_8();
					num = ((int)num2 * -173646326) ^ -492139754;
					continue;
				case 223u:
					SearchDonor_Admin.smethod_22((Control)(object)SearchResultGrid, 10);
					num = (int)(num2 * 1355072722) ^ -856537816;
					continue;
				case 222u:
					SearchResultGrid = SearchDonor_Admin.smethod_5();
					DeleteBtn = SearchDonor_Admin.smethod_6();
					GroupBox1 = SearchDonor_Admin.smethod_7();
					num = ((int)num2 * -499468976) ^ 0x6C5487CC;
					continue;
				case 221u:
					num = (int)((num2 * 1064028210) ^ 0x4C35DAC);
					continue;
				case 220u:
					SearchDonor_Admin.smethod_21((Control)(object)SearchBtn, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -197143053) ^ -739206836;
					continue;
				case 219u:
					num = ((int)num2 * -1847184780) ^ -2097704731;
					continue;
				case 218u:
					SearchDonor_Admin.smethod_22((Control)(object)UpdateBtn, 16);
					SearchDonor_Admin.smethod_33((ButtonBase)(object)UpdateBtn, "Update");
					SearchDonor_Admin.smethod_34((ButtonBase)(object)UpdateBtn, bool_0: false);
					SearchDonor_Admin.smethod_30((Control)(object)UpdateBtn, bool_0: false);
					num = (int)(num2 * 549188944) ^ -585907563;
					continue;
				case 217u:
					num = ((int)num2 * -673604108) ^ -860190466;
					continue;
				case 216u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_47((Control)(object)this), (Control)(object)GroupBox1);
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_47((Control)(object)this), (Control)(object)ClearBtn);
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_47((Control)(object)this), (Control)(object)DeleteBtn);
					num = ((int)num2 * -1276768478) ^ 0x44546D6B;
					continue;
				case 215u:
					SearchDonor_Admin.smethod_15((Control)(object)ClearBtn, "ClearBtn");
					num = (int)((num2 * 1024621347) ^ 0x309BA2F6);
					continue;
				case 214u:
					num = (int)((num2 * 356778928) ^ 0x3C143089);
					continue;
				case 213u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)Label8);
					num = (int)(num2 * 1954660341) ^ -353869564;
					continue;
				case 212u:
					SearchDonor_Admin.smethod_15((Control)(object)UpdateBtn, "UpdateBtn");
					num = (int)((num2 * 1644998816) ^ 0x3B3227F8);
					continue;
				case 210u:
					IDTxt = SearchDonor_Admin.smethod_8();
					num = ((int)num2 * -1754490606) ^ 0x7967E2E5;
					continue;
				case 209u:
					num = (int)(num2 * 731439794) ^ -1147008023;
					continue;
				case 208u:
					SearchDonor_Admin.smethod_15((Control)(object)IDTxt, "IDTxt");
					num = ((int)num2 * -1806854387) ^ 0x3E06AC08;
					continue;
				case 207u:
					SearchDonor_Admin.smethod_33((ButtonBase)(object)SearchBtn, "Search");
					num = (int)((num2 * 1653977334) ^ 0x5F5AD4BC);
					continue;
				case 206u:
					SearchDonor_Admin.smethod_23(Label5, "Age :");
					SearchDonor_Admin.smethod_21((Control)(object)Label3, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -276914763) ^ -1003484814;
					continue;
				case 205u:
					SearchDonor_Admin.smethod_43((TextBoxBase)(object)QuantityTxt, bool_0: true);
					num = (int)(num2 * 1160341576) ^ -1782738051;
					continue;
				case 204u:
					num = (int)(num2 * 270968994) ^ -1943936993;
					continue;
				case 203u:
					num = ((int)num2 * -2144432536) ^ -455664223;
					continue;
				case 202u:
					SearchDonor_Admin.smethod_13(PictureBox1, (Image)(object)Resources.images1232);
					num = ((int)num2 * -1291584378) ^ 0x3D8C4E07;
					continue;
				case 201u:
					SearchDonor_Admin.smethod_15((Control)(object)Label4, "Label4");
					num = ((int)num2 * -427146103) ^ 0x4D2C518C;
					continue;
				case 200u:
					SearchDonor_Admin.smethod_14((Control)(object)SearchResultGrid, new Point(59, 295));
					num = (int)(num2 * 2081846009) ^ -150851584;
					continue;
				case 199u:
					SearchDonor_Admin.smethod_31((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					num = (int)(num2 * 246075533) ^ -1766794630;
					continue;
				case 198u:
					SearchDonor_Admin.smethod_15((Control)(object)NameSTxt, "NameSTxt");
					num = (int)(num2 * 946161816) ^ -2082223623;
					continue;
				case 197u:
					SearchDonor_Admin.smethod_50((ISupportInitialize)SearchResultGrid);
					num = ((int)num2 * -1698150246) ^ 0x58D97C70;
					continue;
				case 196u:
					num = ((int)num2 * -280233432) ^ 0x47071622;
					continue;
				case 195u:
					SearchDonor_Admin.smethod_22((Control)(object)NameTxt, 4);
					num = ((int)num2 * -1554024966) ^ 0x6EA89D7E;
					continue;
				case 194u:
					DateOfDonationTxt = SearchDonor_Admin.smethod_8();
					num = ((int)num2 * -818510149) ^ 0x39E5F46C;
					continue;
				case 193u:
					SearchDonor_Admin.smethod_25(SearchResultGrid, Color.White);
					SearchDonor_Admin.smethod_26(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					num = ((int)num2 * -76587266) ^ -1135061343;
					continue;
				case 192u:
					SearchDonor_Admin.smethod_16((Control)(object)BloodGroupTxt, new Size(146, 30));
					num = ((int)num2 * -120114203) ^ 0x7F346CCC;
					continue;
				case 191u:
					num = (int)((num2 * 52491870) ^ 0x29D775DE);
					continue;
				case 190u:
					SearchDonor_Admin.smethod_24(Label8, (ContentAlignment)32);
					num = (int)(num2 * 817560176) ^ -608438780;
					continue;
				case 189u:
					Label11 = SearchDonor_Admin.smethod_4();
					num = ((int)num2 * -577419836) ^ 0x657F92EE;
					continue;
				case 188u:
					num = ((int)num2 * -1812289050) ^ -4942448;
					continue;
				case 187u:
					SearchDonor_Admin.smethod_14((Control)(object)GenderTxt, new Point(530, 118));
					num = (int)(num2 * 747970993) ^ -126777727;
					continue;
				case 186u:
					num = (int)((num2 * 1223485087) ^ 0x2D2C533D);
					continue;
				case 185u:
					SearchDonor_Admin.smethod_16((Control)(object)DonorInfoBox, new Size(699, 259));
					num = ((int)num2 * -1705243984) ^ -1455438146;
					continue;
				case 184u:
					SearchDonor_Admin.smethod_38(GroupBox1, "Search Patient");
					num = (int)(num2 * 1119311387) ^ -1386390197;
					continue;
				case 183u:
					Label6 = SearchDonor_Admin.smethod_4();
					num = ((int)num2 * -855717225) ^ 0x7A51F8B5;
					continue;
				case 182u:
					num = (int)((num2 * 113264030) ^ 0x3173B721);
					continue;
				case 181u:
					SearchDonor_Admin.smethod_16((Control)(object)Label10, new Size(77, 28));
					SearchDonor_Admin.smethod_22((Control)(object)Label10, 0);
					num = (int)((num2 * 1704541665) ^ 0x3ED55D9C);
					continue;
				case 180u:
					num = (int)((num2 * 1718428199) ^ 0xE728405);
					continue;
				case 179u:
					SearchDonor_Admin.smethod_30((Control)(object)DonorInfoBox, bool_0: false);
					SearchDonor_Admin.smethod_39(BloodGroupTxt, (ComboBoxStyle)2);
					num = (int)((num2 * 1517562575) ^ 0x79E92DDE);
					continue;
				case 178u:
					BloodGroupTxt = SearchDonor_Admin.smethod_9();
					num = ((int)num2 * -649730360) ^ 0x4F67957E;
					continue;
				case 177u:
					SearchDonor_Admin.smethod_42(SearchDonor_Admin.smethod_41(GenderTxt), new object[3] { "Male", "Female", "Others" });
					num = (int)((num2 * 1918864306) ^ 0x1AE625F);
					continue;
				case 176u:
					SearchDonor_Admin.smethod_15((Control)(object)Label8, "Label8");
					num = (int)((num2 * 2088652847) ^ 0x7BAF3E8);
					continue;
				case 175u:
					SearchDonor_Admin.smethod_22((Control)(object)Label9, 11);
					num = (int)(num2 * 1558074377) ^ -76153011;
					continue;
				case 174u:
					SearchDonor_Admin.smethod_21((Control)(object)Label12, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1523095579) ^ -1243179943;
					continue;
				case 173u:
					SearchDonor_Admin.smethod_16((Control)(object)Label4, new Size(134, 28));
					num = ((int)num2 * -1718166033) ^ 0x29C7FFA4;
					continue;
				case 172u:
					num = ((int)num2 * -1687650803) ^ -297560570;
					continue;
				case 171u:
					SearchDonor_Admin.smethod_14((Control)(object)Label3, new Point(16, 221));
					SearchDonor_Admin.smethod_15((Control)(object)Label3, "Label3");
					num = ((int)num2 * -754503582) ^ 0x1922D477;
					continue;
				case 170u:
					SearchDonor_Admin.smethod_22((Control)(object)DeleteBtn, 13);
					num = ((int)num2 * -132830017) ^ 0x2F2F74FB;
					continue;
				case 169u:
					num = (int)((num2 * 228679120) ^ 0x2D98AB8E);
					continue;
				case 168u:
					SearchDonor_Admin.smethod_15((Control)(object)BloodGroupTxt, "BloodGroupTxt");
					num = ((int)num2 * -73042009) ^ -637725805;
					continue;
				case 167u:
					SearchDonor_Admin.smethod_15((Control)(object)Label5, "Label5");
					num = ((int)num2 * -1121995434) ^ -599132286;
					continue;
				case 166u:
					num = ((int)num2 * -898071774) ^ -1609224188;
					continue;
				case 165u:
					num = ((int)num2 * -154443904) ^ 0x176BC211;
					continue;
				case 164u:
					MobileTxt = SearchDonor_Admin.smethod_8();
					num = ((int)num2 * -27613715) ^ 0x12CE63DC;
					continue;
				case 163u:
					SearchDonor_Admin.smethod_14((Control)(object)GroupBox1, new Point(155, 150));
					SearchDonor_Admin.smethod_15((Control)(object)GroupBox1, "GroupBox1");
					num = ((int)num2 * -904028901) ^ 0x53FF7ED5;
					continue;
				case 162u:
					SearchDonor_Admin.smethod_14((Control)(object)UpdateBtn, new Point(808, 517));
					num = ((int)num2 * -1051319348) ^ 0x24A5CBFB;
					continue;
				case 161u:
					num = (int)(num2 * 557663015) ^ -853785592;
					continue;
				case 160u:
					PictureBox1 = SearchDonor_Admin.smethod_3();
					num = ((int)num2 * -654768347) ^ -830138454;
					continue;
				case 159u:
					SearchDonor_Admin.smethod_16((Control)(object)NameTxt, new Size(271, 28));
					num = (int)(num2 * 1318242503) ^ -1548073633;
					continue;
				case 158u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)Label4);
					num = ((int)num2 * -2088741808) ^ -223411565;
					continue;
				case 157u:
					SearchDonor_Admin.smethod_24(Label1, (ContentAlignment)32);
					num = ((int)num2 * -1629626750) ^ -1973411738;
					continue;
				case 156u:
					SearchDonor_Admin.smethod_21((Control)(object)Label8, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 480752380) ^ -372215319;
					continue;
				case 155u:
					num = ((int)num2 * -1257133229) ^ 0x613C8CD3;
					continue;
				case 154u:
					num = (int)(num2 * 829962974) ^ -1908268893;
					continue;
				case 153u:
					SearchDonor_Admin.smethod_31((ButtonBase)(object)SearchBtn, Color.MidnightBlue);
					num = ((int)num2 * -105505576) ^ -1779766461;
					continue;
				case 152u:
					num = (int)(num2 * 1407058894) ^ -614163923;
					continue;
				case 151u:
					SearchDonor_Admin.smethod_50((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -285683398) ^ -513786970;
					continue;
				case 150u:
					SearchDonor_Admin.smethod_23(Label10, "Name : ");
					num = (int)((num2 * 717724282) ^ 0x6E263658);
					continue;
				case 149u:
					num = (int)((num2 * 1528294308) ^ 0x5EF1E2AE);
					continue;
				case 148u:
					SearchDonor_Admin.smethod_14((Control)(object)ClearBtn, new Point(808, 667));
					num = ((int)num2 * -25859531) ^ -1947112347;
					continue;
				case 147u:
					SearchDonor_Admin.smethod_14((Control)(object)NameTxt, new Point(117, 77));
					num = ((int)num2 * -1828115734) ^ 0x3DB4EF9;
					continue;
				case 146u:
					num = ((int)num2 * -1790494930) ^ -1975610612;
					continue;
				case 145u:
					num = (int)((num2 * 818854964) ^ 0x41E7BC1E);
					continue;
				case 144u:
					SearchDonor_Admin.smethod_22((Control)(object)Label5, 1);
					num = (int)((num2 * 593394894) ^ 0x727E55A5);
					continue;
				case 143u:
					SearchDonor_Admin.smethod_21((Control)(object)Label9, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -526514076) ^ -1128730233;
					continue;
				case 142u:
					num = (int)(num2 * 1473652551) ^ -1929676176;
					continue;
				case 141u:
					num = (int)(num2 * 657963097) ^ -136461865;
					continue;
				case 140u:
					QuantityTxt = SearchDonor_Admin.smethod_8();
					num = ((int)num2 * -1435895742) ^ -279335743;
					continue;
				case 139u:
					SearchDonor_Admin.smethod_37(DonorInfoBox, bool_0: false);
					num = (int)((num2 * 1761153205) ^ 0x6EBC272F);
					continue;
				case 138u:
					num = ((int)num2 * -1279890956) ^ -115430748;
					continue;
				case 137u:
					num = (int)(num2 * 1348231199) ^ -1006859712;
					continue;
				case 136u:
					num = ((int)num2 * -2112485927) ^ 0x59809C3B;
					continue;
				case 135u:
					SearchDonor_Admin.smethod_15((Control)(object)QuantityTxt, "QuantityTxt");
					num = ((int)num2 * -1565255398) ^ 0xF824586;
					continue;
				case 134u:
					num = ((int)num2 * -429682108) ^ -917978837;
					continue;
				case 133u:
					SearchDonor_Admin.smethod_34((ButtonBase)(object)SearchBtn, bool_0: false);
					num = ((int)num2 * -1355156725) ^ -1013848773;
					continue;
				case 132u:
					SearchDonor_Admin.smethod_27(SearchResultGrid, bool_0: true);
					num = (int)(num2 * 1571117774) ^ -1955662265;
					continue;
				case 131u:
					SearchDonor_Admin.smethod_22((Control)(object)Label1, 7);
					num = ((int)num2 * -1169218877) ^ 0x1F0379B3;
					continue;
				case 130u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)NameTxt);
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)Label6);
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)Label5);
					num = ((int)num2 * -1353535434) ^ 0x77235E;
					continue;
				case 129u:
					SearchDonor_Admin.smethod_34((ButtonBase)(object)DeleteBtn, bool_0: false);
					num = (int)((num2 * 1022092140) ^ 0x2618E981);
					continue;
				case 128u:
					Label1 = SearchDonor_Admin.smethod_4();
					num = ((int)num2 * -1439644800) ^ 0x2D9F6AF7;
					continue;
				case 127u:
					ClearBtn = SearchDonor_Admin.smethod_6();
					num = ((int)num2 * -1544445613) ^ -2096257698;
					continue;
				case 126u:
					SearchDonor_Admin.smethod_16((Control)(object)Label11, new Size(68, 25));
					SearchDonor_Admin.smethod_22((Control)(object)Label11, 16);
					num = (int)(num2 * 1518132198) ^ -1061615333;
					continue;
				case 125u:
					SearchDonor_Admin.smethod_22((Control)(object)Label6, 2);
					SearchDonor_Admin.smethod_23(Label6, "Gender : ");
					num = ((int)num2 * -1300056606) ^ 0x203DF384;
					continue;
				case 124u:
					Label10 = SearchDonor_Admin.smethod_4();
					num = ((int)num2 * -1981201530) ^ -1334623019;
					continue;
				case 123u:
					SearchDonor_Admin.smethod_23(Label11, "ID :");
					SearchDonor_Admin.smethod_21((Control)(object)Label4, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 282842153) ^ 0xAC1FBAE);
					continue;
				case 122u:
					SearchDonor_Admin.smethod_23(Label12, "Quantity : ");
					num = ((int)num2 * -83989428) ^ -167764855;
					continue;
				case 121u:
					SearchDonor_Admin.smethod_11((Control)(object)DonorInfoBox);
					SearchDonor_Admin.smethod_12((Control)(object)this);
					num = (int)((num2 * 969471587) ^ 0x7C7ACD86);
					continue;
				case 120u:
					SearchDonor_Admin.smethod_22((Control)(object)Label4, 13);
					num = (int)(num2 * 807519604) ^ -1288406145;
					continue;
				case 119u:
					SearchDonor_Admin.smethod_22((Control)(object)Label12, 18);
					num = ((int)num2 * -77306610) ^ 0x3FA8093F;
					continue;
				case 118u:
					num = ((int)num2 * -100621924) ^ 0x5339D266;
					continue;
				case 117u:
					SearchDonor_Admin.smethod_14((Control)(object)QuantityTxt, new Point(507, 215));
					num = ((int)num2 * -1749383689) ^ -1385891461;
					continue;
				case 116u:
					SearchDonor_Admin.smethod_16((Control)(object)Label5, new Size(84, 26));
					num = ((int)num2 * -1922840326) ^ 0x30829C51;
					continue;
				case 115u:
					num = (int)((num2 * 2040482160) ^ 0x337138C1);
					continue;
				case 114u:
					SearchDonor_Admin.smethod_32((Control)(object)SearchBtn, Color.White);
					num = ((int)num2 * -1292923084) ^ -911676751;
					continue;
				case 113u:
					UpdateBtn = SearchDonor_Admin.smethod_6();
					num = ((int)num2 * -1751187660) ^ 0x19A1BC3F;
					continue;
				case 112u:
					SearchDonor_Admin.smethod_16((Control)(object)Label3, new Size(174, 25));
					num = (int)(num2 * 1993704681) ^ -162043801;
					continue;
				case 111u:
					SearchDonor_Admin.smethod_32((Control)(object)DeleteBtn, Color.White);
					num = (int)((num2 * 753189856) ^ 0x5731F285);
					continue;
				case 110u:
					SearchDonor_Admin.smethod_15((Control)(object)Label10, "Label10");
					num = (int)((num2 * 1378739348) ^ 0x6C261153);
					continue;
				case 109u:
					SearchDonor_Admin.smethod_31((ButtonBase)(object)DeleteBtn, Color.MidnightBlue);
					num = ((int)num2 * -448143963) ^ -385316674;
					continue;
				case 108u:
					num = ((int)num2 * -1354993593) ^ 0x2ED6E537;
					continue;
				case 107u:
					SearchDonor_Admin.smethod_22((Control)(object)NameSTxt, 1);
					SearchDonor_Admin.smethod_21((Control)(object)Label10, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -239220815) ^ -562128818;
					continue;
				case 106u:
					SearchDonor_Admin.smethod_40((ListControl)(object)BloodGroupTxt, bool_0: true);
					SearchDonor_Admin.smethod_42(SearchDonor_Admin.smethod_41(BloodGroupTxt), new object[8] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
					num = (int)((num2 * 618129240) ^ 0x59EAF347);
					continue;
				case 105u:
					SearchDonor_Admin.smethod_16((Control)(object)Label1, new Size(330, 47));
					num = (int)((num2 * 919672642) ^ 0x103A7C58);
					continue;
				case 104u:
					SearchDonor_Admin.smethod_16((Control)(object)QuantityTxt, new Size(169, 28));
					num = (int)((num2 * 1739215897) ^ 0x611C3C79);
					continue;
				case 103u:
					num = (int)(num2 * 1935038719) ^ -531833547;
					continue;
				case 102u:
					SearchDonor_Admin.smethod_21((Control)(object)GroupBox1, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1457360808) ^ -586054342;
					continue;
				case 101u:
					SearchDonor_Admin.smethod_16((Control)(object)PictureBox1, new Size(200, 110));
					num = (int)(num2 * 666518646) ^ -2095611956;
					continue;
				case 100u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)GenderTxt);
					num = ((int)num2 * -445676615) ^ 0x3186D19;
					continue;
				case 99u:
					SearchDonor_Admin.smethod_14((Control)(object)Label9, new Point(16, 124));
					num = (int)(num2 * 1363363808) ^ -325381088;
					continue;
				case 98u:
					SearchDonor_Admin.smethod_38(DonorInfoBox, "Donor Information");
					num = ((int)num2 * -443126241) ^ -1567809148;
					continue;
				case 97u:
					SearchDonor_Admin.smethod_14((Control)(object)Label2, new Point(37, 87));
					num = ((int)num2 * -297454626) ^ 0x135EF2A6;
					continue;
				case 96u:
					SearchDonor_Admin.smethod_16((Control)(object)DateOfDonationTxt, new Size(192, 28));
					num = ((int)num2 * -1295082129) ^ 0x6C44179C;
					continue;
				case 95u:
					SearchDonor_Admin.smethod_14((Control)(object)BloodGroupTxt, new Point(531, 164));
					num = (int)((num2 * 1280320997) ^ 0xF94FFF2);
					continue;
				case 94u:
					num = ((int)num2 * -437033761) ^ -1155610143;
					continue;
				case 93u:
					SearchDonor_Admin.smethod_23(Label1, "Search Donor");
					num = (int)(num2 * 674226878) ^ -1863563068;
					continue;
				case 92u:
					SearchDonor_Admin.smethod_30((Control)(object)SearchResultGrid, bool_0: false);
					num = (int)((num2 * 1550100346) ^ 0x2847BDBE);
					continue;
				case 91u:
					num = (int)((num2 * 575091100) ^ 0x379C62F0);
					continue;
				case 90u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)Label3);
					num = (int)((num2 * 354601038) ^ 0x2CD9B578);
					continue;
				case 89u:
					num = ((int)num2 * -604210193) ^ 0x6C79DF2C;
					continue;
				case 88u:
					SearchDonor_Admin.smethod_14((Control)(object)Label8, new Point(16, 78));
					num = (int)((num2 * 205478036) ^ 0x656C192D);
					continue;
				case 87u:
					SearchDonor_Admin.smethod_22((Control)(object)BloodGroupTxt, 21);
					SearchDonor_Admin.smethod_39(GenderTxt, (ComboBoxStyle)2);
					num = (int)(num2 * 110098223) ^ -1767502533;
					continue;
				case 86u:
					num = (int)((num2 * 432964537) ^ 0x48F3C59F);
					continue;
				case 85u:
					SearchDonor_Admin.smethod_11((Control)(object)GroupBox1);
					num = ((int)num2 * -1529430221) ^ -1576205268;
					continue;
				case 84u:
					Label9 = SearchDonor_Admin.smethod_4();
					num = ((int)num2 * -759825326) ^ -1643145314;
					continue;
				case 83u:
					SearchDonor_Admin.smethod_22((Control)(object)GenderTxt, 20);
					num = (int)(num2 * 1612029793) ^ -1131222125;
					continue;
				case 82u:
					SearchDonor_Admin.smethod_15((Control)(object)GenderTxt, "GenderTxt");
					num = (int)((num2 * 1333206572) ^ 0x14FED5D0);
					continue;
				case 81u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)GroupBox1), (Control)(object)NameSTxt);
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)GroupBox1), (Control)(object)Label10);
					num = ((int)num2 * -1613647275) ^ -1430900934;
					continue;
				case 80u:
					num = (int)(num2 * 1473564289) ^ -400955757;
					continue;
				case 79u:
					num = ((int)num2 * -474786421) ^ 0x6034DD9B;
					continue;
				case 78u:
					SearchDonor_Admin.smethod_23(Label3, "Date Of Donation :");
					num = (int)(num2 * 1805528545) ^ -567353019;
					continue;
				case 77u:
					SearchDonor_Admin.smethod_15((Control)(object)Label11, "Label11");
					num = ((int)num2 * -919953547) ^ 0x3F4679C9;
					continue;
				case 76u:
					SearchDonor_Admin.smethod_21((Control)(object)DeleteBtn, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -49619297) ^ 0x6BEE1875;
					continue;
				case 74u:
					SearchDonor_Admin.smethod_16((Control)(object)Label12, new Size(100, 26));
					num = ((int)num2 * -1678103759) ^ 0x1B9B6AA6;
					continue;
				case 73u:
					num = ((int)num2 * -1677850651) ^ 0x33251C03;
					continue;
				case 72u:
					SearchDonor_Admin.smethod_18(PictureBox1, 6);
					SearchDonor_Admin.smethod_19(PictureBox1, bool_0: false);
					SearchDonor_Admin.smethod_21((Control)(object)Label1, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchDonor_Admin.smethod_14((Control)(object)Label1, new Point(392, 63));
					num = ((int)num2 * -734194183) ^ 0xAB18E3E;
					continue;
				case 71u:
					SearchDonor_Admin.smethod_21((Control)(object)DonorInfoBox, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchDonor_Admin.smethod_14((Control)(object)DonorInfoBox, new Point(79, 470));
					num = (int)((num2 * 1338898140) ^ 0x79E81C45);
					continue;
				case 70u:
					SearchDonor_Admin.smethod_15((Control)(object)DeleteBtn, "DeleteBtn");
					num = ((int)num2 * -743772564) ^ 0x22FE3495;
					continue;
				case 69u:
					SearchDonor_Admin.smethod_14((Control)(object)DOBTxt, new Point(117, 167));
					SearchDonor_Admin.smethod_15((Control)(object)DOBTxt, "DOBTxt");
					num = ((int)num2 * -903816925) ^ 0x76C8F6EA;
					continue;
				case 68u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)DOBTxt);
					num = ((int)num2 * -117718065) ^ 0x58EC6B73;
					continue;
				case 67u:
					num = (int)(num2 * 548047394) ^ -1462197967;
					continue;
				case 66u:
					SearchDonor_Admin.smethod_16((Control)(object)NameSTxt, new Size(237, 28));
					num = ((int)num2 * -1304814721) ^ 0x33ECA252;
					continue;
				case 65u:
					SearchDonor_Admin.smethod_14((Control)(object)PictureBox1, new Point(165, 20));
					num = (int)((num2 * 866954431) ^ 0x3FD1656);
					continue;
				case 64u:
					Label5 = SearchDonor_Admin.smethod_4();
					num = (int)((num2 * 1747234177) ^ 0x222C591C);
					continue;
				case 63u:
					SearchDonor_Admin.smethod_24(Label9, (ContentAlignment)32);
					SearchDonor_Admin.smethod_14((Control)(object)DateOfDonationTxt, new Point(196, 215));
					num = (int)(num2 * 607944431) ^ -902287744;
					continue;
				case 62u:
					num = ((int)num2 * -2114091218) ^ 0x310E902;
					continue;
				case 61u:
					Label8 = SearchDonor_Admin.smethod_4();
					num = ((int)num2 * -192507813) ^ -789597436;
					continue;
				case 60u:
					SearchDonor_Admin.smethod_45((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 1291964352) ^ 0x35C4926C);
					continue;
				case 59u:
					SearchDonor_Admin.smethod_16((Control)(object)Label6, new Size(84, 26));
					num = (int)((num2 * 651859519) ^ 0xED8F661);
					continue;
				case 58u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_47((Control)(object)this), (Control)(object)DonorInfoBox);
					num = (int)((num2 * 1877854224) ^ 0x3EB6FCCD);
					continue;
				case 57u:
					SearchDonor_Admin.smethod_22((Control)(object)DateOfDonationTxt, 10);
					num = ((int)num2 * -714423117) ^ -643212652;
					continue;
				case 56u:
					SearchDonor_Admin.smethod_14((Control)(object)NameSTxt, new Point(120, 44));
					num = ((int)num2 * -1505293842) ^ 0x2A856B5D;
					continue;
				case 55u:
					num = ((int)num2 * -1594998307) ^ 0x3D98BCA6;
					continue;
				case 54u:
					num = ((int)num2 * -1857264885) ^ 0x5C51EF7E;
					continue;
				case 53u:
					num = ((int)num2 * -1290163687) ^ 0x1117A14;
					continue;
				case 52u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_47((Control)(object)this), (Control)(object)Label1);
					num = (int)((num2 * 1686247503) ^ 0x15918CE6);
					continue;
				case 51u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)DateOfDonationTxt);
					num = ((int)num2 * -217217678) ^ -1748313453;
					continue;
				case 50u:
					SearchDonor_Admin.smethod_51((Control)(object)DonorInfoBox, bool_0: false);
					num = (int)((num2 * 1274163094) ^ 0x2239DCBA);
					continue;
				case 49u:
					SearchDonor_Admin.smethod_14((Control)(object)MobileTxt, new Point(117, 124));
					num = (int)((num2 * 1189071270) ^ 0x2C831B00);
					continue;
				case 48u:
					NameSTxt = SearchDonor_Admin.smethod_8();
					num = ((int)num2 * -555926206) ^ -1281861592;
					continue;
				case 47u:
					num = ((int)num2 * -1329279595) ^ 0x6471059;
					continue;
				case 46u:
					DonorInfoBox = SearchDonor_Admin.smethod_7();
					num = (int)((num2 * 106917176) ^ 0x3EFE170E);
					continue;
				case 45u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)Label11);
					num = (int)((num2 * 922927424) ^ 0x4DE4C92F);
					continue;
				case 44u:
					num = ((int)num2 * -2041473676) ^ 0x3D225151;
					continue;
				case 43u:
					SearchDonor_Admin.smethod_37(GroupBox1, bool_0: false);
					num = ((int)num2 * -650642741) ^ 0x598AEA9C;
					continue;
				case 42u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)IDTxt);
					num = (int)((num2 * 775510889) ^ 0x48652ED1);
					continue;
				case 41u:
					num = (int)((num2 * 1581602845) ^ 0x283F280B);
					continue;
				case 40u:
					SearchDonor_Admin.smethod_30((Control)(object)DeleteBtn, bool_0: false);
					num = ((int)num2 * -1691737919) ^ -741850812;
					continue;
				case 39u:
					num = (int)((num2 * 1053261619) ^ 0x2775DB3B);
					continue;
				case 38u:
					SearchDonor_Admin.smethod_14((Control)(object)Label12, new Point(401, 217));
					SearchDonor_Admin.smethod_15((Control)(object)Label12, "Label12");
					num = ((int)num2 * -998297571) ^ -1129910287;
					continue;
				case 37u:
					Label3 = SearchDonor_Admin.smethod_4();
					num = ((int)num2 * -155417566) ^ -1508834405;
					continue;
				case 36u:
					SearchDonor_Admin.smethod_33((ButtonBase)(object)DeleteBtn, "Delete");
					num = (int)(num2 * 1224171399) ^ -2004672825;
					continue;
				case 35u:
					SearchDonor_Admin.smethod_15((Control)(object)DateOfDonationTxt, "DateOfDonationTxt");
					num = ((int)num2 * -850016545) ^ -1009395000;
					continue;
				case 34u:
					num = (int)(num2 * 681222582) ^ -1674576079;
					continue;
				case 33u:
					SearchDonor_Admin.smethod_33((ButtonBase)(object)ClearBtn, "Clear");
					num = ((int)num2 * -1784338058) ^ -1561119667;
					continue;
				case 32u:
					SearchDonor_Admin.smethod_43((TextBoxBase)(object)DateOfDonationTxt, bool_0: true);
					num = ((int)num2 * -190478075) ^ -393091140;
					continue;
				case 31u:
					SearchDonor_Admin.smethod_15((Control)(object)Label2, "Label2");
					num = ((int)num2 * -573456294) ^ -546087199;
					continue;
				case 30u:
					num = ((int)num2 * -543586656) ^ 0x1F175A50;
					continue;
				case 29u:
					SearchDonor_Admin.smethod_16((Control)(object)SearchResultGrid, new Size(853, 169));
					num = ((int)num2 * -12212003) ^ 0x3EB7EF8E;
					continue;
				case 28u:
					num = ((int)num2 * -2117395841) ^ -1027222967;
					continue;
				case 27u:
					GenderTxt = SearchDonor_Admin.smethod_9();
					num = ((int)num2 * -328460810) ^ 0x229154D5;
					continue;
				case 26u:
					SearchDonor_Admin.smethod_16((Control)(object)Label9, new Size(77, 28));
					num = ((int)num2 * -1157225552) ^ 0x39CC89BC;
					continue;
				case 25u:
					num = (int)(num2 * 1315472878) ^ -785943642;
					continue;
				case 24u:
					SearchDonor_Admin.smethod_22((Control)(object)QuantityTxt, 19);
					num = ((int)num2 * -458330379) ^ -706454307;
					continue;
				case 23u:
					num = ((int)num2 * -1298487353) ^ 0x5FE21CCB;
					continue;
				case 22u:
					SearchDonor_Admin.smethod_40((ListControl)(object)GenderTxt, bool_0: true);
					num = (int)((num2 * 1482041615) ^ 0x6F8869);
					continue;
				case 21u:
					SearchDonor_Admin.smethod_15((Control)(object)Label9, "Label9");
					num = ((int)num2 * -1340889903) ^ -559120492;
					continue;
				case 20u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)Label12);
					num = (int)(num2 * 1728241776) ^ -1015449089;
					continue;
				case 19u:
					num = (int)((num2 * 702763176) ^ 0x48B49BE);
					continue;
				case 18u:
					SearchDonor_Admin.smethod_10((ISupportInitialize)SearchResultGrid);
					num = (int)(num2 * 1196190798) ^ -230970330;
					continue;
				case 17u:
					SearchDonor_Admin.smethod_22((Control)(object)Label2, 3);
					SearchDonor_Admin.smethod_23(Label2, "Mobile : ");
					num = (int)(num2 * 1700312547) ^ -418376061;
					continue;
				case 16u:
					SearchDonor_Admin.smethod_16((Control)(object)DeleteBtn, new Size(104, 37));
					num = (int)(num2 * 793930644) ^ -32537423;
					continue;
				case 15u:
					SearchDonor_Admin.smethod_24(Label10, (ContentAlignment)32);
					num = ((int)num2 * -541324717) ^ -1476963539;
					continue;
				case 14u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)GroupBox1), (Control)(object)Label2);
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)GroupBox1), (Control)(object)MobileSTxt);
					num = ((int)num2 * -1735144454) ^ 0x3635467;
					continue;
				case 13u:
					SearchDonor_Admin.smethod_22((Control)(object)DOBTxt, 5);
					num = (int)(num2 * 1567896849) ^ -1309310379;
					continue;
				case 12u:
					num = ((int)num2 * -1081401186) ^ -2004951225;
					continue;
				case 11u:
					num = (int)((num2 * 749134873) ^ 0x2537A3C4);
					continue;
				case 10u:
					SearchDonor_Admin.smethod_22((Control)(object)DonorInfoBox, 15);
					num = ((int)num2 * -918309878) ^ -1545953513;
					continue;
				case 9u:
					SearchDonor_Admin.smethod_24(Label4, (ContentAlignment)32);
					num = (int)(num2 * 466999795) ^ -1520632172;
					continue;
				case 8u:
					num = (int)(num2 * 1753316323) ^ -786838031;
					continue;
				case 7u:
					num = ((int)num2 * -496804305) ^ -1057285205;
					continue;
				case 6u:
					num = ((int)num2 * -456514835) ^ -1231632833;
					continue;
				case 5u:
					num = (int)(num2 * 150709964) ^ -1167391854;
					continue;
				case 4u:
					num = (int)((num2 * 1196468443) ^ 0x5C5CC141);
					continue;
				case 3u:
					SearchDonor_Admin.smethod_21((Control)(object)Label5, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 926327530) ^ 0x1D085FC);
					continue;
				case 2u:
					SearchDonor_Admin.smethod_14((Control)(object)Label10, new Point(37, 44));
					num = ((int)num2 * -1285262935) ^ -601139966;
					continue;
				case 1u:
					SearchDonor_Admin.smethod_34((ButtonBase)(object)ClearBtn, bool_0: false);
					num = ((int)num2 * -1074748338) ^ 0x266EF223;
					continue;
				case 0u:
					num = (int)(num2 * 873283273) ^ -2126792994;
					continue;
				default:
					return;
				case 75u:
					break;
				case 211u:
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
			int num = -327328842;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x81918DF9u) % 3u)
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
				num = (int)(num2 * 962365719) ^ -1117277470;
			}
		}
	}

	private bool HideItemsOnForm()
	{
		bool result = default(bool);
		while (true)
		{
			int num = -1682498127;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFC00C3BDu) % 11u)
				{
				case 10u:
					SearchDonor_Admin.smethod_30((Control)(object)DeleteBtn, bool_0: false);
					num = ((int)num2 * -1647126975) ^ -168534246;
					continue;
				case 9u:
					num = (int)((num2 * 912269360) ^ 0x7572E235);
					continue;
				case 8u:
					num = ((int)num2 * -786913123) ^ -336892436;
					continue;
				case 7u:
					SearchDonor_Admin.smethod_30((Control)(object)UpdateBtn, bool_0: false);
					num = (int)((num2 * 1871607317) ^ 0x43989CE2);
					continue;
				case 5u:
					num = ((int)num2 * -186250426) ^ -1340886167;
					continue;
				case 4u:
					SearchDonor_Admin.smethod_30((Control)(object)ClearBtn, bool_0: false);
					num = ((int)num2 * -949130480) ^ -262998348;
					continue;
				case 2u:
					SearchDonor_Admin.smethod_30((Control)(object)SearchResultGrid, bool_0: false);
					num = ((int)num2 * -486699001) ^ -1184513814;
					continue;
				case 1u:
					SearchDonor_Admin.smethod_30((Control)(object)DonorInfoBox, bool_0: false);
					num = (int)((num2 * 922394706) ^ 0x3377261E);
					continue;
				case 0u:
					result = true;
					num = ((int)num2 * -1347824163) ^ 0x41B793A1;
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

	private void SearchBtn_Click(object sender, EventArgs e)
	{
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected I4, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected I4, but got Unknown
		//IL_02dd: Incompatible stack heights: 0 vs 1
		//IL_02e4: Incompatible stack heights: 0 vs 1
		bool flag2 = default(bool);
		string string_ = default(string);
		DataTable dataTable = default(DataTable);
		OleDbDataAdapter dbDataAdapter_ = default(OleDbDataAdapter);
		bool flag = default(bool);
		while (true)
		{
			int num = -1466964740;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8DB4D9BCu) % 11u)
				{
				case 10u:
					SearchDonor_Admin.smethod_66(myconnection);
					num = (int)((num2 * 1171605637) ^ 0x42A46CE7);
					continue;
				case 9u:
				{
					int num6;
					int num7;
					if (!flag2)
					{
						num6 = 808128563;
						num7 = 808128563;
					}
					else
					{
						num6 = 1122619792;
						num7 = 1122619792;
					}
					num = num6 ^ ((int)num2 * -150375267);
					continue;
				}
				case 7u:
					HideItemsOnForm();
					num = -2069984359;
					continue;
				case 6u:
					flag2 = !MyProject.Forms.Form1.Name_Validation(SearchDonor_Admin.smethod_61(SearchDonor_Admin.smethod_60(NameSTxt))) | !MyProject.Forms.Form1.Mobile_Validator(SearchDonor_Admin.smethod_61(SearchDonor_Admin.smethod_60(MobileSTxt)));
					num = ((int)num2 * -2038475491) ^ 0x2B661964;
					continue;
				case 5u:
					string_ = SearchDonor_Admin.smethod_64(new string[5]
					{
						"Select * From [Donor] Where [Name] Like '%",
						SearchDonor_Admin.smethod_61(SearchDonor_Admin.smethod_60(NameSTxt)),
						"%' And [Mobile] Like '%",
						SearchDonor_Admin.smethod_60(MobileSTxt),
						"%';"
					});
					num = (int)(num2 * 1563181900) ^ -1566607293;
					continue;
				case 4u:
					dataTable = SearchDonor_Admin.smethod_65();
					num = (int)((num2 * 1864862795) ^ 0x5DED9D5A);
					continue;
				case 3u:
					SearchDonor_Admin.smethod_62("No Results Found");
					num = (int)(num2 * 1213872811) ^ -416141854;
					continue;
				case 2u:
					SearchDonor_Admin.smethod_63();
					num = ((int)num2 * -1896351572) ^ 0x4B13BBEF;
					continue;
				case 8u:
					break;
				default:
					try
					{
						while (true)
						{
							int num3 = -1391983101;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x8DB4D9BCu) % 8u)
								{
								case 7u:
									dbDataAdapter_ = SearchDonor_Admin.smethod_67(string_, myconnection);
									num3 = (int)((num2 * 1167910550) ^ 0x36D81087);
									continue;
								case 6u:
								{
									int num4;
									int num5;
									if (!flag)
									{
										num4 = -1814715124;
										num5 = -1814715124;
									}
									else
									{
										num4 = -440789739;
										num5 = -440789739;
									}
									num3 = num4 ^ ((int)num2 * -1651189865);
									continue;
								}
								case 2u:
									SearchDonor_Admin.smethod_30((Control)(object)SearchResultGrid, bool_0: true);
									SearchDonor_Admin.smethod_71(myconnection);
									num3 = -1447644048;
									continue;
								case 1u:
									SearchDonor_Admin.smethod_68((DbDataAdapter)(object)dbDataAdapter_, dataTable);
									SearchDonor_Admin.smethod_69(SearchResultGrid, (object)dataTable);
									num3 = ((int)num2 * -1502859692) ^ 0x2E9C2EE8;
									continue;
								case 0u:
									flag = SearchDonor_Admin.smethod_70(SearchResultGrid) == 1;
									num3 = (int)(num2 * 1578798303) ^ -133156166;
									continue;
								default:
									return;
								case 5u:
									break;
								case 3u:
									SearchDonor_Admin.smethod_62("No Result Found");
									SearchDonor_Admin.smethod_71(myconnection);
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
						SearchDonor_Admin.smethod_72(exception_);
						while (true)
						{
							_ = -707978147;
							while (true)
							{
								_003F val = /*Error near IL_02a7: Stack underflow*/^ -1917527620;
								num2 = (uint)(int)val;
								switch (val % 3)
								{
								default:
									return;
								case 1:
									SearchDonor_Admin.smethod_71(myconnection);
									SearchDonor_Admin.smethod_73();
									_ = ((int)num2 * -370858498) ^ -1146986276;
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
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void UpdateBtn_Click(object sender, EventArgs e)
	{
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected I4, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected I4, but got Unknown
		//IL_0361: Incompatible stack heights: 0 vs 1
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Incompatible stack heights: 0 vs 1
		//IL_0385: Incompatible stack heights: 0 vs 1
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		bool flag2 = default(bool);
		bool flag = default(bool);
		OleDbCommand val = default(OleDbCommand);
		string string_ = default(string);
		while (true)
		{
			int num = -1317551971;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x85063DF3u) % 10u)
				{
				case 9u:
					flag2 = !(MyProject.Forms.Form1.Name_Validation(SearchDonor_Admin.smethod_61(SearchDonor_Admin.smethod_60(NameTxt))) & MyProject.Forms.Form1.Mobile_Validator(SearchDonor_Admin.smethod_60(MobileTxt)) & MyProject.Forms.Form1.age_validator(SearchDonor_Admin.smethod_60(DOBTxt)));
					num = -135485524;
					continue;
				case 8u:
					flag = (SearchDonor_Admin.smethod_74(SearchDonor_Admin.smethod_60(NameTxt), "", bool_0: false) == 0) | (SearchDonor_Admin.smethod_74(SearchDonor_Admin.smethod_60(MobileTxt), "", bool_0: false) == 0) | (SearchDonor_Admin.smethod_74(SearchDonor_Admin.smethod_75(GenderTxt), "", bool_0: false) == 0) | (SearchDonor_Admin.smethod_74(SearchDonor_Admin.smethod_60(DOBTxt), "", bool_0: false) == 0) | (SearchDonor_Admin.smethod_74(SearchDonor_Admin.smethod_75(BloodGroupTxt), "", bool_0: false) == 0);
					num = ((int)num2 * -883711235) ^ -969921622;
					continue;
				case 7u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = 743233013;
						num7 = 743233013;
					}
					else
					{
						num6 = 1986826910;
						num7 = 1986826910;
					}
					num = num6 ^ ((int)num2 * -404240000);
					continue;
				}
				case 6u:
					SearchDonor_Admin.smethod_62("Invalid Credentitals");
					num = ((int)num2 * -193935891) ^ 0x21325C3D;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 2025182227;
						num5 = 2025182227;
					}
					else
					{
						num4 = 1818849972;
						num5 = 1818849972;
					}
					num = num4 ^ ((int)num2 * -1027915691);
					continue;
				}
				case 1u:
					val = SearchDonor_Admin.smethod_63();
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
					SearchDonor_Admin.smethod_66(myconnection);
					num = -327807650;
					continue;
				case 2u:
					break;
				default:
					try
					{
						while (true)
						{
							int num3 = -967829082;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x85063DF3u) % 6u)
								{
								case 4u:
									SearchDonor_Admin.smethod_77(val);
									SearchDonor_Admin.smethod_78((Component)(object)val);
									num3 = ((int)num2 * -939845788) ^ 0x543D4FB;
									continue;
								case 2u:
									SearchDonor_Admin.smethod_71(myconnection);
									num3 = (int)((num2 * 523042635) ^ 0x5D1DA177);
									continue;
								case 1u:
									val = SearchDonor_Admin.smethod_76(string_, myconnection);
									num3 = ((int)num2 * -1465427611) ^ 0x5BB88BDC;
									continue;
								case 0u:
									num3 = ((int)num2 * -408688763) ^ 0x198A5550;
									continue;
								case 5u:
									break;
								default:
									UpdateTable();
									SearchDonor_Admin.smethod_62("Successfully Updated Details");
									ClearDonorInfoBox();
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
						SearchDonor_Admin.smethod_71(myconnection);
						while (true)
						{
							_ = -1264568274;
							while (true)
							{
								_003F val2 = /*Error near IL_0332: Stack underflow*/^ -2063188493;
								num2 = (uint)(int)val2;
								switch (val2 % 4)
								{
								default:
									return;
								case 2:
									SearchDonor_Admin.smethod_73();
									_ = ((int)num2 * -350584733) ^ -1762233054;
									continue;
								case 1:
									SearchDonor_Admin.smethod_62(SearchDonor_Admin.smethod_79(exception_));
									_ = (num2 * 339202883) ^ 0xAC95E3BAu;
									continue;
								case 0:
									break;
								case 3:
									return;
								}
								break;
							}
						}
					}
				case 4u:
					SearchDonor_Admin.smethod_62("Fields Cannot be empty");
					return;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void DeleteBtn_Click(object sender, EventArgs e)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected I4, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected I4, but got Unknown
		//IL_020b: Incompatible stack heights: 0 vs 1
		//IL_0212: Incompatible stack heights: 0 vs 1
		bool flag = SearchDonor_Admin.smethod_74(SearchDonor_Admin.smethod_60(IDTxt), "", bool_0: false) == 0;
		OleDbCommand val = default(OleDbCommand);
		string string_ = default(string);
		while (true)
		{
			int num = -887173969;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC5301F9Bu) % 7u)
				{
				case 6u:
					val = SearchDonor_Admin.smethod_63();
					num = -1815274348;
					continue;
				case 5u:
					SearchDonor_Admin.smethod_62("Nothing To Delete");
					num = ((int)num2 * -2021818973) ^ 0x5366D4D3;
					continue;
				case 3u:
					string_ = SearchDonor_Admin.smethod_80("Delete From [Donor] Where [DID] = ", SearchDonor_Admin.smethod_60(IDTxt), ";");
					SearchDonor_Admin.smethod_66(myconnection);
					num = (int)((num2 * 2092157310) ^ 0x7DA334E1);
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -432095433;
						num5 = -432095433;
					}
					else
					{
						num4 = -924477283;
						num5 = -924477283;
					}
					num = num4 ^ (int)(num2 * 391152957);
					continue;
				}
				case 2u:
					break;
				default:
					try
					{
						while (true)
						{
							int num3 = -2086055249;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xC5301F9Bu) % 9u)
								{
								case 8u:
									ClearDonorInfoBox();
									SearchDonor_Admin.smethod_62("Successfully Deleted Entry");
									num3 = ((int)num2 * -1233965702) ^ -1619053029;
									continue;
								case 7u:
									val = SearchDonor_Admin.smethod_76(string_, myconnection);
									num3 = ((int)num2 * -321806740) ^ -2106589903;
									continue;
								case 6u:
									UpdateTable();
									num3 = (int)(num2 * 1226129082) ^ -1179245741;
									continue;
								case 4u:
									num3 = ((int)num2 * -1452747280) ^ 0x159596C5;
									continue;
								case 3u:
									SearchDonor_Admin.smethod_71(myconnection);
									num3 = (int)((num2 * 1829280028) ^ 0x62079BEF);
									continue;
								case 2u:
									SearchDonor_Admin.smethod_77(val);
									num3 = ((int)num2 * -2057064264) ^ -613128618;
									continue;
								case 0u:
									SearchDonor_Admin.smethod_78((Component)(object)val);
									num3 = (int)(num2 * 117885237) ^ -1189617219;
									continue;
								default:
									return;
								case 5u:
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
						while (true)
						{
							_ = -1429644398;
							while (true)
							{
								_003F val2 = /*Error near IL_01da: Stack underflow*/^ -986701925;
								num2 = (uint)(int)val2;
								switch (val2 % 3)
								{
								case 2:
									SearchDonor_Admin.smethod_71(myconnection);
									_ = ((int)num2 * -1728451267) ^ 0x31717814;
									continue;
								case 0:
									break;
								default:
									SearchDonor_Admin.smethod_73();
									return;
								}
								break;
							}
						}
					}
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void SearchResultGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		try
		{
			SearchDonor_Admin.smethod_88(IDTxt, SearchDonor_Admin.smethod_87(SearchDonor_Admin.smethod_86(SearchDonor_Admin.smethod_85(SearchDonor_Admin.smethod_84(SearchDonor_Admin.smethod_83(SearchDonor_Admin.smethod_81(SearchResultGrid), SearchDonor_Admin.smethod_82(e))), 0))));
			while (true)
			{
				int num = -1704276687;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBCA0DB8Cu) % 16u)
					{
					case 15u:
						SearchDonor_Admin.smethod_88(MobileTxt, SearchDonor_Admin.smethod_87(SearchDonor_Admin.smethod_86(SearchDonor_Admin.smethod_85(SearchDonor_Admin.smethod_84(SearchDonor_Admin.smethod_83(SearchDonor_Admin.smethod_81(SearchResultGrid), SearchDonor_Admin.smethod_82(e))), 5))));
						num = (int)((num2 * 1697302806) ^ 0x39A264DF);
						continue;
					case 14u:
						num = ((int)num2 * -1398151674) ^ -1386256146;
						continue;
					case 13u:
						SearchDonor_Admin.smethod_88(NameTxt, SearchDonor_Admin.smethod_87(SearchDonor_Admin.smethod_86(SearchDonor_Admin.smethod_85(SearchDonor_Admin.smethod_84(SearchDonor_Admin.smethod_83(SearchDonor_Admin.smethod_81(SearchResultGrid), SearchDonor_Admin.smethod_82(e))), 1))));
						num = ((int)num2 * -2114326214) ^ -429088806;
						continue;
					case 12u:
						SearchDonor_Admin.smethod_30((Control)(object)DonorInfoBox, bool_0: true);
						num = ((int)num2 * -706345336) ^ 0x231807B4;
						continue;
					case 11u:
						num = (int)(num2 * 952949322) ^ -1660157997;
						continue;
					case 9u:
						SearchDonor_Admin.smethod_88(DateOfDonationTxt, SearchDonor_Admin.smethod_87(SearchDonor_Admin.smethod_86(SearchDonor_Admin.smethod_85(SearchDonor_Admin.smethod_84(SearchDonor_Admin.smethod_83(SearchDonor_Admin.smethod_81(SearchResultGrid), SearchDonor_Admin.smethod_82(e))), 6))));
						num = (int)(num2 * 252196428) ^ -1256404509;
						continue;
					case 8u:
						SearchDonor_Admin.smethod_30((Control)(object)DeleteBtn, bool_0: true);
						num = ((int)num2 * -1399406545) ^ 0x1802530A;
						continue;
					case 7u:
						SearchDonor_Admin.smethod_88(DOBTxt, SearchDonor_Admin.smethod_87(SearchDonor_Admin.smethod_86(SearchDonor_Admin.smethod_85(SearchDonor_Admin.smethod_84(SearchDonor_Admin.smethod_83(SearchDonor_Admin.smethod_81(SearchResultGrid), SearchDonor_Admin.smethod_82(e))), 3))));
						num = (int)((num2 * 2109644828) ^ 0x6C3F56F8);
						continue;
					case 6u:
						SearchDonor_Admin.smethod_30((Control)(object)ClearBtn, bool_0: true);
						num = ((int)num2 * -1373749510) ^ 0x1DC9EEAB;
						continue;
					case 5u:
						num = (int)(num2 * 1861108613) ^ -1200488606;
						continue;
					case 4u:
						SearchDonor_Admin.smethod_89(GenderTxt, SearchDonor_Admin.smethod_87(SearchDonor_Admin.smethod_86(SearchDonor_Admin.smethod_85(SearchDonor_Admin.smethod_84(SearchDonor_Admin.smethod_83(SearchDonor_Admin.smethod_81(SearchResultGrid), SearchDonor_Admin.smethod_82(e))), 2))));
						num = (int)((num2 * 2035047100) ^ 0x1D8B92E9);
						continue;
					case 3u:
						num = (int)((num2 * 1020343086) ^ 0x66348814);
						continue;
					case 2u:
						SearchDonor_Admin.smethod_88(QuantityTxt, SearchDonor_Admin.smethod_87(SearchDonor_Admin.smethod_86(SearchDonor_Admin.smethod_85(SearchDonor_Admin.smethod_84(SearchDonor_Admin.smethod_83(SearchDonor_Admin.smethod_81(SearchResultGrid), SearchDonor_Admin.smethod_82(e))), 7))));
						num = (int)((num2 * 658832330) ^ 0x13AD6964);
						continue;
					case 0u:
						SearchDonor_Admin.smethod_89(BloodGroupTxt, SearchDonor_Admin.smethod_87(SearchDonor_Admin.smethod_86(SearchDonor_Admin.smethod_85(SearchDonor_Admin.smethod_84(SearchDonor_Admin.smethod_83(SearchDonor_Admin.smethod_81(SearchResultGrid), SearchDonor_Admin.smethod_82(e))), 4))));
						num = (int)(num2 * 611327687) ^ -939019853;
						continue;
					case 10u:
						break;
					default:
						SearchDonor_Admin.smethod_30((Control)(object)UpdateBtn, bool_0: true);
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
		while (true)
		{
			int num = 570474599;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x61D11D69u) % 3u)
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
				ClearDonorInfoBox();
				num = (int)(num2 * 1521323255) ^ -2052285425;
			}
		}
	}

	private bool ClearDonorInfoBox()
	{
		bool result = default(bool);
		while (true)
		{
			int num = 1348787044;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1D306EB5u) % 10u)
				{
				case 9u:
					SearchDonor_Admin.smethod_91(BloodGroupTxt, -1);
					num = (int)(num2 * 1197533736) ^ -1679518539;
					continue;
				case 8u:
					SearchDonor_Admin.smethod_91(GenderTxt, -1);
					num = ((int)num2 * -1501204457) ^ -2060475538;
					continue;
				case 7u:
					num = ((int)num2 * -489289390) ^ 0x177CB939;
					continue;
				case 4u:
					SearchDonor_Admin.smethod_90((TextBoxBase)(object)NameTxt);
					num = (int)(num2 * 2058274860) ^ -521374622;
					continue;
				case 3u:
					SearchDonor_Admin.smethod_90((TextBoxBase)(object)DateOfDonationTxt);
					num = (int)((num2 * 241646230) ^ 0x6ADF0D99);
					continue;
				case 2u:
					SearchDonor_Admin.smethod_90((TextBoxBase)(object)MobileTxt);
					SearchDonor_Admin.smethod_90((TextBoxBase)(object)DOBTxt);
					num = (int)((num2 * 1304123754) ^ 0x217F2284);
					continue;
				case 1u:
					SearchDonor_Admin.smethod_90((TextBoxBase)(object)IDTxt);
					num = ((int)num2 * -1451635442) ^ -1185466317;
					continue;
				case 0u:
					SearchDonor_Admin.smethod_90((TextBoxBase)(object)QuantityTxt);
					result = true;
					num = ((int)num2 * -104411443) ^ -1595664150;
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

	private bool UpdateTable()
	{
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected I4, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected I4, but got Unknown
		//IL_0240: Incompatible stack heights: 0 vs 1
		//IL_025b: Incompatible stack heights: 0 vs 1
		//IL_026b: Incompatible stack heights: 0 vs 1
		//IL_0272: Incompatible stack heights: 0 vs 1
		SearchDonor_Admin.smethod_63();
		string string_ = default(string);
		DataTable dataTable = default(DataTable);
		OleDbDataAdapter dbDataAdapter_ = default(OleDbDataAdapter);
		bool flag = default(bool);
		while (true)
		{
			int num = -550052353;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE958696Eu) % 4u)
				{
				case 2u:
					SearchDonor_Admin.smethod_66(myconnection);
					num = (int)((num2 * 902800566) ^ 0x7D2B20AE);
					continue;
				case 1u:
					string_ = SearchDonor_Admin.smethod_64(new string[5]
					{
						"Select * From [Donor] Where [Name] Like '%",
						SearchDonor_Admin.smethod_61(SearchDonor_Admin.smethod_60(NameSTxt)),
						"%' And [Mobile] Like '%",
						SearchDonor_Admin.smethod_60(MobileTxt),
						"%';"
					});
					dataTable = SearchDonor_Admin.smethod_65();
					num = ((int)num2 * -188538288) ^ -462470848;
					continue;
				case 3u:
					break;
				default:
				{
					try
					{
						while (true)
						{
							IL_01ee:
							int num3 = -1063756645;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xE958696Eu) % 12u)
								{
								case 11u:
									SearchDonor_Admin.smethod_30((Control)(object)SearchResultGrid, bool_0: true);
									num3 = -2032385839;
									continue;
								case 10u:
									SearchDonor_Admin.smethod_71(myconnection);
									num3 = (int)(num2 * 1782655340) ^ -108329458;
									continue;
								case 9u:
									dbDataAdapter_ = SearchDonor_Admin.smethod_67(string_, myconnection);
									num3 = ((int)num2 * -1086917372) ^ 0x28B4AC8F;
									continue;
								case 7u:
									num3 = (int)((num2 * 241724900) ^ 0x232CB630);
									continue;
								case 6u:
									SearchDonor_Admin.smethod_71(myconnection);
									num3 = (int)((num2 * 823451323) ^ 0x26C93B91);
									continue;
								case 5u:
									SearchDonor_Admin.smethod_68((DbDataAdapter)(object)dbDataAdapter_, dataTable);
									SearchDonor_Admin.smethod_69(SearchResultGrid, (object)dataTable);
									num3 = (int)((num2 * 1939216604) ^ 0x3B3EF121);
									continue;
								case 4u:
								{
									int num4;
									int num5;
									if (flag)
									{
										num4 = 364013288;
										num5 = 364013288;
									}
									else
									{
										num4 = 1177485733;
										num5 = 1177485733;
									}
									num3 = num4 ^ ((int)num2 * -1959582572);
									continue;
								}
								case 3u:
									num3 = ((int)num2 * -806603505) ^ -1895544189;
									continue;
								case 0u:
									flag = SearchDonor_Admin.smethod_70(SearchResultGrid) == 1;
									num3 = ((int)num2 * -609589150) ^ 0x3B6207A6;
									continue;
								default:
									goto end_IL_01ab;
								case 2u:
									break;
								case 1u:
									return false;
								case 8u:
									goto end_IL_01ab;
								}
								goto IL_01ee;
								continue;
								end_IL_01ab:
								break;
							}
							break;
						}
					}
					catch (Exception exception_)
					{
						SearchDonor_Admin.smethod_72(exception_);
						while (true)
						{
							IL_026d:
							_ = -2076392859;
							while (true)
							{
								_003F val = /*Error near IL_020d: Stack underflow*/^ -380081810;
								num2 = (uint)(int)val;
								switch (val % 5)
								{
								default:
									goto end_IL_0207;
								case 4:
									SearchDonor_Admin.smethod_73();
									_ = ((int)num2 * -1135600390) ^ 0x3C3D534F;
									continue;
								case 2:
									SearchDonor_Admin.smethod_71(myconnection);
									_ = (num2 * 971326956) ^ 0x77D001CB;
									continue;
								case 1:
									_ = ((int)num2 * -1251290634) ^ 0x40F3F21B;
									continue;
								case 0:
									break;
								case 3:
									goto end_IL_0207;
								}
								goto IL_026d;
								continue;
								end_IL_0207:
								break;
							}
							break;
						}
					}
					bool result = true;
					while (true)
					{
						int num6 = -1012267872;
						while (true)
						{
							switch ((num2 = (uint)num6 ^ 0xE958696Eu) % 3u)
							{
							case 2u:
								goto IL_027a;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_027a:
							num6 = (int)((num2 * 927149985) ^ 0x103BB8C5);
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
