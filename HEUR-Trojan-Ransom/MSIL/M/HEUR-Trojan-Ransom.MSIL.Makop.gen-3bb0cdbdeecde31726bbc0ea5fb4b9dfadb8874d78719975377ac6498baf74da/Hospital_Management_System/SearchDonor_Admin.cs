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
				int num = 1143718085;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6BAB166Bu) % 7u)
					{
					case 5u:
						SearchDonor_Admin.smethod_54(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = ((int)num2 * -169454953) ^ 0x5FBC15FB;
						continue;
					case 4u:
						_SearchResultGrid = value;
						searchResultGrid = _SearchResultGrid;
						num = 1300453770;
						continue;
					case 3u:
					{
						searchResultGrid = _SearchResultGrid;
						int num5;
						int num6;
						if (searchResultGrid != null)
						{
							num5 = -166793187;
							num6 = -166793187;
						}
						else
						{
							num5 = -1209563551;
							num6 = -1209563551;
						}
						num = num5 ^ (int)(num2 * 1483110976);
						continue;
					}
					case 2u:
						SearchDonor_Admin.smethod_55(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = ((int)num2 * -676077816) ^ -1014130692;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (searchResultGrid != null)
						{
							num3 = -2089642319;
							num4 = -2089642319;
						}
						else
						{
							num3 = -940250607;
							num4 = -940250607;
						}
						num = num3 ^ ((int)num2 * -1719216843);
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
				int num = -1857681322;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB71FA7C0u) % 7u)
					{
					case 6u:
						SearchDonor_Admin.smethod_57((Control)(object)deleteBtn, eventHandler_);
						num = ((int)num2 * -694963595) ^ 0x69CBE940;
						continue;
					case 5u:
						SearchDonor_Admin.smethod_56((Control)(object)deleteBtn, eventHandler_);
						num = ((int)num2 * -1883686903) ^ 0x14C210F6;
						continue;
					case 4u:
						_DeleteBtn = value;
						num = -1961899736;
						continue;
					case 2u:
					{
						deleteBtn = _DeleteBtn;
						int num5;
						int num6;
						if (deleteBtn != null)
						{
							num5 = 363867017;
							num6 = 363867017;
						}
						else
						{
							num5 = 1470980695;
							num6 = 1470980695;
						}
						num = num5 ^ (int)(num2 * 1878753210);
						continue;
					}
					case 1u:
					{
						deleteBtn = _DeleteBtn;
						int num3;
						int num4;
						if (deleteBtn == null)
						{
							num3 = 419227339;
							num4 = 419227339;
						}
						else
						{
							num3 = 919282367;
							num4 = 919282367;
						}
						num = num3 ^ (int)(num2 * 2101634408);
						continue;
					}
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
				goto IL_0026;
			}
			goto IL_0088;
			IL_0088:
			_SearchBtn = value;
			searchBtn = _SearchBtn;
			int num;
			int num2;
			if (searchBtn != null)
			{
				num = 1255781818;
				num2 = 1255781818;
			}
			else
			{
				num = 447646704;
				num2 = 447646704;
			}
			goto IL_0057;
			IL_0057:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num ^ 0x5AD0525Du) % 5u)
				{
				case 4u:
					break;
				case 3u:
					SearchDonor_Admin.smethod_56((Control)(object)searchBtn, eventHandler_);
					num = ((int)num3 * -1457054284) ^ 0x6472149E;
					continue;
				case 2u:
					SearchDonor_Admin.smethod_57((Control)(object)searchBtn, eventHandler_);
					num = (int)(num3 * 829270610) ^ -1322768882;
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
			goto IL_0026;
			IL_0026:
			num = 576372313;
			goto IL_0057;
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
				int num = 1038608519;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x453EB236u) % 7u)
					{
					case 6u:
					{
						int num5;
						int num6;
						if (clearBtn != null)
						{
							num5 = 1772724740;
							num6 = 1772724740;
						}
						else
						{
							num5 = 1876104872;
							num6 = 1876104872;
						}
						num = num5 ^ (int)(num2 * 1726079177);
						continue;
					}
					case 5u:
					{
						clearBtn = _ClearBtn;
						int num3;
						int num4;
						if (clearBtn != null)
						{
							num3 = 1079239565;
							num4 = 1079239565;
						}
						else
						{
							num3 = 1238279990;
							num4 = 1238279990;
						}
						num = num3 ^ (int)(num2 * 1592155270);
						continue;
					}
					case 4u:
						_ClearBtn = value;
						num = 2081532348;
						continue;
					case 2u:
						SearchDonor_Admin.smethod_57((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -1994482703) ^ 0xA6EFA1D;
						continue;
					case 0u:
						SearchDonor_Admin.smethod_56((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -214966919) ^ 0x259280A2;
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
				int num = 1556783072;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x94A13BFu) % 9u)
					{
					case 7u:
						updateBtn = _UpdateBtn;
						num = (int)(num2 * 1188165259) ^ -1648740514;
						continue;
					case 6u:
						SearchDonor_Admin.smethod_57((Control)(object)updateBtn, eventHandler_);
						num = ((int)num2 * -2089872753) ^ -2084498855;
						continue;
					case 5u:
					{
						int num5;
						int num6;
						if (updateBtn == null)
						{
							num5 = 1267507827;
							num6 = 1267507827;
						}
						else
						{
							num5 = 991428345;
							num6 = 991428345;
						}
						num = num5 ^ ((int)num2 * -1359314331);
						continue;
					}
					case 4u:
						SearchDonor_Admin.smethod_56((Control)(object)updateBtn, eventHandler_);
						num = (int)(num2 * 440065375) ^ -2029892727;
						continue;
					case 2u:
						_UpdateBtn = value;
						num = 1722667981;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (updateBtn == null)
						{
							num3 = -1395780196;
							num4 = -1395780196;
						}
						else
						{
							num3 = -1355654412;
							num4 = -1355654412;
						}
						num = num3 ^ (int)(num2 * 1035048632);
						continue;
					}
					case 0u:
						updateBtn = _UpdateBtn;
						num = (int)(num2 * 1044822405) ^ -1017648581;
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
			int num = 743001866;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3773ABDFu) % 6u)
				{
				case 5u:
					myconnection = SearchDonor_Admin.smethod_1();
					num = (int)(num2 * 1366595786) ^ -1908288774;
					continue;
				case 3u:
					InitializeComponent();
					num = ((int)num2 * -153186438) ^ -1902911627;
					continue;
				case 2u:
					SearchDonor_Admin.smethod_0((UserControl)(object)this, (EventHandler)SearchDonor_Admin_Load);
					num = ((int)num2 * -699427249) ^ -528418406;
					continue;
				case 1u:
					num = (int)(num2 * 1388698370) ^ -390355469;
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
			bool flag = default(bool);
			while (true)
			{
				int num = 125023960;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x2FDE73C2u) % 9u)
					{
					case 8u:
						num3 = ((components != null) ? 1 : 0);
						goto IL_0010;
					case 7u:
						num = ((int)num2 * -315354298) ^ -1896622089;
						continue;
					case 6u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = 695880320;
							num5 = 695880320;
						}
						else
						{
							num4 = 310421718;
							num5 = 310421718;
						}
						num = num4 ^ ((int)num2 * -1145442943);
						continue;
					}
					case 5u:
						num = ((int)num2 * -359169263) ^ -1827947647;
						continue;
					case 4u:
						if (disposing)
						{
							num = (int)((num2 * 289048423) ^ 0x716E2E96);
							continue;
						}
						num3 = 0;
						goto IL_0010;
					case 3u:
						SearchDonor_Admin.smethod_2((IDisposable)components);
						num = (int)((num2 * 771230308) ^ 0x1C34AC53);
						continue;
					case 1u:
						num = 1412950118;
						continue;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
						IL_0010:
						flag = (byte)num3 != 0;
						num = 745832769;
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
				int num6 = 1553277740;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num6 ^ 0x2FDE73C2u) % 3u)
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
					num6 = ((int)num2 * -1771685320) ^ -512576193;
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
			int num = -1844855008;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC0A9B705u) % 322u)
				{
				case 321u:
					num = (int)((num2 * 1505415553) ^ 0x62CF73AF);
					continue;
				case 320u:
					num = (int)((num2 * 1803018870) ^ 0x37E48DFB);
					continue;
				case 319u:
					SearchDonor_Admin.smethod_16((Control)(object)BloodGroupTxt, new Size(146, 30));
					num = (int)(num2 * 1260762481) ^ -695294914;
					continue;
				case 317u:
					SearchDonor_Admin.smethod_21((Control)(object)Label3, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1846103781) ^ -1320713138;
					continue;
				case 316u:
					num = (int)((num2 * 1854804436) ^ 0x1DBF1CC0);
					continue;
				case 315u:
					SearchDonor_Admin.smethod_33((ButtonBase)(object)SearchBtn, "Search");
					num = ((int)num2 * -1551263099) ^ 0x601C2694;
					continue;
				case 314u:
					SearchDonor_Admin.smethod_15((Control)(object)Label1, "Label1");
					num = (int)((num2 * 1013598392) ^ 0x45D58F87);
					continue;
				case 313u:
					SearchDonor_Admin.smethod_14((Control)(object)DOBTxt, new Point(117, 167));
					num = (int)(num2 * 372328299) ^ -2140814331;
					continue;
				case 312u:
					num = (int)(num2 * 144053013) ^ -1448658270;
					continue;
				case 311u:
					num = ((int)num2 * -1939945272) ^ 0x465EFDF9;
					continue;
				case 310u:
					num = (int)((num2 * 283921320) ^ 0x6F35AEB9);
					continue;
				case 309u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)DOBTxt);
					num = (int)((num2 * 912194058) ^ 0x86952D8);
					continue;
				case 308u:
					num = ((int)num2 * -238266693) ^ 0x7EF38907;
					continue;
				case 307u:
					SearchDonor_Admin.smethod_23(Label6, "Gender : ");
					num = ((int)num2 * -367719139) ^ -457521835;
					continue;
				case 306u:
					SearchDonor_Admin.smethod_17(PictureBox1, (PictureBoxSizeMode)1);
					num = ((int)num2 * -2059492256) ^ -1404633764;
					continue;
				case 305u:
					num = ((int)num2 * -237218462) ^ 0x445687D;
					continue;
				case 304u:
					SearchDonor_Admin.smethod_15((Control)(object)Label6, "Label6");
					num = (int)((num2 * 757115750) ^ 0x7DBF586E);
					continue;
				case 303u:
					SearchDonor_Admin.smethod_15((Control)(object)IDTxt, "IDTxt");
					num = ((int)num2 * -950673612) ^ -796650383;
					continue;
				case 302u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)IDTxt);
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)Label11);
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)Label4);
					num = ((int)num2 * -307635415) ^ 0x3B9A11FB;
					continue;
				case 301u:
					SearchDonor_Admin.smethod_21((Control)(object)Label9, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1586445974) ^ -1606500120;
					continue;
				case 300u:
					num = ((int)num2 * -1480698960) ^ 0x34E0C0AD;
					continue;
				case 299u:
					SearchDonor_Admin.smethod_16((Control)(object)Label6, new Size(84, 26));
					num = ((int)num2 * -359933715) ^ 0x3C148E05;
					continue;
				case 298u:
					SearchDonor_Admin.smethod_15((Control)(object)Label5, "Label5");
					num = (int)((num2 * 348828829) ^ 0x45F0AE10);
					continue;
				case 297u:
					num = (int)(num2 * 2016526094) ^ -1582267029;
					continue;
				case 296u:
					SearchDonor_Admin.smethod_23(Label10, "Name : ");
					num = (int)(num2 * 884431624) ^ -102430409;
					continue;
				case 295u:
					num = (int)((num2 * 537557507) ^ 0x516B4533);
					continue;
				case 294u:
					SearchDonor_Admin.smethod_44((ContainerControl)(object)this, new SizeF(8f, 16f));
					SearchDonor_Admin.smethod_45((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 1729686353) ^ 0x692A29E2);
					continue;
				case 293u:
					SearchDonor_Admin.smethod_22((Control)(object)Label11, 16);
					num = (int)((num2 * 810739531) ^ 0x6304F8B0);
					continue;
				case 292u:
					Label9 = SearchDonor_Admin.smethod_4();
					DateOfDonationTxt = SearchDonor_Admin.smethod_8();
					Label8 = SearchDonor_Admin.smethod_4();
					num = ((int)num2 * -1012895746) ^ 0x15F140FD;
					continue;
				case 291u:
					SearchDonor_Admin.smethod_16((Control)(object)IDTxt, new Size(204, 28));
					num = (int)((num2 * 1638085072) ^ 0x68936EE2);
					continue;
				case 290u:
					num = ((int)num2 * -398903389) ^ -1975267862;
					continue;
				case 289u:
					SearchDonor_Admin.smethod_29(SearchDonor_Admin.smethod_28(SearchResultGrid), 24);
					num = ((int)num2 * -64697966) ^ 0x22724B2;
					continue;
				case 288u:
					SearchDonor_Admin.smethod_22((Control)(object)SearchBtn, 4);
					num = ((int)num2 * -1581610255) ^ -372112136;
					continue;
				case 287u:
					num = ((int)num2 * -834565622) ^ 0x5B25AE2D;
					continue;
				case 286u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)MobileTxt);
					num = ((int)num2 * -2009305721) ^ 0xE437221;
					continue;
				case 285u:
					num = (int)((num2 * 817129232) ^ 0x1F3C310C);
					continue;
				case 284u:
					SearchDonor_Admin.smethod_14((Control)(object)NameSTxt, new Point(120, 44));
					num = (int)(num2 * 93073516) ^ -1987478623;
					continue;
				case 283u:
					SearchDonor_Admin.smethod_15((Control)(object)DOBTxt, "DOBTxt");
					num = ((int)num2 * -1354104507) ^ 0x5715BFEA;
					continue;
				case 282u:
					num = (int)((num2 * 331701596) ^ 0x6F70D32F);
					continue;
				case 281u:
					num = (int)((num2 * 285690827) ^ 0x185FCAE7);
					continue;
				case 280u:
					UpdateBtn = SearchDonor_Admin.smethod_6();
					SearchDonor_Admin.smethod_10((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -2116241368) ^ 0x6D80FFA;
					continue;
				case 279u:
					num = ((int)num2 * -1112345431) ^ 0x4E6199A1;
					continue;
				case 278u:
					SearchDonor_Admin.smethod_16((Control)(object)Label1, new Size(330, 47));
					num = ((int)num2 * -377578267) ^ 0x4EB2E6D0;
					continue;
				case 277u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)NameTxt);
					num = ((int)num2 * -399384445) ^ 0x2BD894D3;
					continue;
				case 276u:
					SearchDonor_Admin.smethod_16((Control)(object)MobileTxt, new Size(271, 28));
					num = ((int)num2 * -719354367) ^ -893107467;
					continue;
				case 275u:
					SearchDonor_Admin.smethod_10((ISupportInitialize)SearchResultGrid);
					num = (int)((num2 * 509581636) ^ 0x54670767);
					continue;
				case 274u:
					num = ((int)num2 * -1727049288) ^ 0x454C9283;
					continue;
				case 273u:
					SearchDonor_Admin.smethod_46((Control)(object)this, Color.White);
					num = ((int)num2 * -178657223) ^ -985541391;
					continue;
				case 272u:
					SearchDonor_Admin.smethod_15((Control)(object)SearchBtn, "SearchBtn");
					num = ((int)num2 * -1842756793) ^ 0x2703DF3;
					continue;
				case 271u:
					SearchDonor_Admin.smethod_34((ButtonBase)(object)DeleteBtn, bool_0: false);
					num = ((int)num2 * -1875897263) ^ -1263654640;
					continue;
				case 270u:
					SearchDonor_Admin.smethod_22((Control)(object)BloodGroupTxt, 21);
					num = ((int)num2 * -814435914) ^ -1749308664;
					continue;
				case 269u:
					SearchDonor_Admin.smethod_21((Control)(object)Label8, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 893547799) ^ 0x714A11);
					continue;
				case 268u:
					SearchDonor_Admin.smethod_14((Control)(object)Label11, new Point(16, 36));
					num = (int)(num2 * 770024147) ^ -2141959707;
					continue;
				case 267u:
					SearchDonor_Admin.smethod_24(Label8, (ContentAlignment)32);
					num = (int)((num2 * 1969271574) ^ 0x2E9686EC);
					continue;
				case 266u:
					SearchDonor_Admin.smethod_22((Control)(object)GenderTxt, 20);
					num = (int)((num2 * 702646089) ^ 0x460219AE);
					continue;
				case 265u:
					SearchDonor_Admin.smethod_14((Control)(object)Label9, new Point(16, 124));
					num = (int)((num2 * 329641935) ^ 0x7DEA0A45);
					continue;
				case 264u:
					num = ((int)num2 * -1058746153) ^ -446413405;
					continue;
				case 263u:
					num = ((int)num2 * -55467510) ^ -88185236;
					continue;
				case 262u:
					SearchDonor_Admin.smethod_15((Control)(object)Label2, "Label2");
					num = ((int)num2 * -281906599) ^ -1821725781;
					continue;
				case 261u:
					num = (int)(num2 * 1845098257) ^ -953483311;
					continue;
				case 260u:
					SearchDonor_Admin.smethod_16((Control)(object)Label12, new Size(100, 26));
					SearchDonor_Admin.smethod_22((Control)(object)Label12, 18);
					SearchDonor_Admin.smethod_23(Label12, "Quantity : ");
					num = (int)((num2 * 1358156646) ^ 0x78A342A8);
					continue;
				case 259u:
					SearchDonor_Admin.smethod_22((Control)(object)QuantityTxt, 19);
					num = (int)(num2 * 238484861) ^ -80066117;
					continue;
				case 258u:
					SearchDonor_Admin.smethod_25(SearchResultGrid, Color.White);
					num = (int)(num2 * 2044964060) ^ -2114904990;
					continue;
				case 257u:
					MobileSTxt = SearchDonor_Admin.smethod_8();
					num = ((int)num2 * -1707205031) ^ -496042115;
					continue;
				case 256u:
					SearchDonor_Admin.smethod_15((Control)(object)Label11, "Label11");
					num = ((int)num2 * -829852191) ^ 0x22038DAA;
					continue;
				case 255u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)Label8);
					num = (int)(num2 * 393336668) ^ -1491222003;
					continue;
				case 254u:
					num = (int)(num2 * 602775855) ^ -1187898006;
					continue;
				case 253u:
					num = ((int)num2 * -1010596405) ^ -884256807;
					continue;
				case 252u:
					SearchDonor_Admin.smethod_40((ListControl)(object)GenderTxt, bool_0: true);
					num = ((int)num2 * -236436158) ^ 0x51324588;
					continue;
				case 251u:
					SearchDonor_Admin.smethod_22((Control)(object)MobileTxt, 12);
					num = (int)((num2 * 1817805267) ^ 0x965F6D3);
					continue;
				case 250u:
					num = ((int)num2 * -1823502962) ^ 0x370026D9;
					continue;
				case 249u:
					SearchDonor_Admin.smethod_42(SearchDonor_Admin.smethod_41(GenderTxt), new object[3] { "Male", "Female", "Others" });
					SearchDonor_Admin.smethod_14((Control)(object)GenderTxt, new Point(530, 118));
					SearchDonor_Admin.smethod_15((Control)(object)GenderTxt, "GenderTxt");
					num = ((int)num2 * -2103480164) ^ 0x41F2AEAC;
					continue;
				case 248u:
					SearchDonor_Admin.smethod_22((Control)(object)DeleteBtn, 13);
					SearchDonor_Admin.smethod_33((ButtonBase)(object)DeleteBtn, "Delete");
					num = (int)((num2 * 518481181) ^ 0x53E79F45);
					continue;
				case 247u:
					num = (int)((num2 * 1559943652) ^ 0x33B2C1B4);
					continue;
				case 246u:
					SearchDonor_Admin.smethod_22((Control)(object)DOBTxt, 5);
					num = (int)((num2 * 14386198) ^ 0x16A93BB3);
					continue;
				case 245u:
					SearchDonor_Admin.smethod_14((Control)(object)IDTxt, new Point(117, 36));
					num = ((int)num2 * -747647848) ^ -465357450;
					continue;
				case 244u:
					num = ((int)num2 * -1037149398) ^ 0xB440460;
					continue;
				case 243u:
					SearchDonor_Admin.smethod_16((Control)(object)SearchResultGrid, new Size(853, 169));
					num = ((int)num2 * -647861437) ^ 0x3E949442;
					continue;
				case 242u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)Label5);
					num = ((int)num2 * -93830184) ^ 0x2D5CD8C7;
					continue;
				case 241u:
					num = ((int)num2 * -361351325) ^ -515324988;
					continue;
				case 240u:
					SearchDonor_Admin.smethod_21((Control)(object)DeleteBtn, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1343919725) ^ 0x44DA8F0;
					continue;
				case 239u:
					DonorInfoBox = SearchDonor_Admin.smethod_7();
					num = ((int)num2 * -1275315607) ^ -1811804238;
					continue;
				case 238u:
					SearchDonor_Admin.smethod_14((Control)(object)DateOfDonationTxt, new Point(196, 215));
					num = ((int)num2 * -1234657767) ^ -677506617;
					continue;
				case 237u:
					SearchDonor_Admin.smethod_16((Control)(object)QuantityTxt, new Size(169, 28));
					num = (int)(num2 * 767350736) ^ -1463327864;
					continue;
				case 236u:
					Label2 = SearchDonor_Admin.smethod_4();
					num = ((int)num2 * -45578277) ^ -1605551748;
					continue;
				case 235u:
					num = ((int)num2 * -2141933745) ^ 0x48DCC53A;
					continue;
				case 234u:
					num = (int)((num2 * 1173603346) ^ 0x6D9D0C9A);
					continue;
				case 233u:
					SearchDonor_Admin.smethod_14((Control)(object)Label1, new Point(392, 63));
					num = (int)(num2 * 148792679) ^ -1067516600;
					continue;
				case 232u:
					SearchDonor_Admin.smethod_15((Control)(object)Label12, "Label12");
					num = ((int)num2 * -2106567513) ^ 0x12BE481A;
					continue;
				case 231u:
					Label1 = SearchDonor_Admin.smethod_4();
					SearchResultGrid = SearchDonor_Admin.smethod_5();
					num = ((int)num2 * -397617214) ^ -388219059;
					continue;
				case 230u:
					num = ((int)num2 * -304605731) ^ 0x372867F8;
					continue;
				case 229u:
					num = ((int)num2 * -1304455683) ^ 0x5E81E952;
					continue;
				case 228u:
					SearchDonor_Admin.smethod_22((Control)(object)Label1, 7);
					SearchDonor_Admin.smethod_23(Label1, "Search Donor");
					num = ((int)num2 * -2036243988) ^ 0x4911911A;
					continue;
				case 227u:
					SearchDonor_Admin.smethod_31((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					num = ((int)num2 * -1443565618) ^ -90334168;
					continue;
				case 226u:
					SearchDonor_Admin.smethod_53((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1301508926) ^ -1632553627;
					continue;
				case 225u:
					SearchDonor_Admin.smethod_21((Control)(object)UpdateBtn, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1877423672) ^ -2035591764;
					continue;
				case 224u:
					SearchDonor_Admin.smethod_23(Label3, "Date Of Donation :");
					num = ((int)num2 * -1894488917) ^ -104935591;
					continue;
				case 223u:
					SearchDonor_Admin.smethod_51((Control)(object)DonorInfoBox, bool_0: false);
					num = (int)((num2 * 1345381119) ^ 0x5DEE7E15);
					continue;
				case 222u:
					ClearBtn = SearchDonor_Admin.smethod_6();
					num = ((int)num2 * -1187628283) ^ 0x232D005A;
					continue;
				case 221u:
					num = ((int)num2 * -1769496037) ^ -397203924;
					continue;
				case 220u:
					SearchDonor_Admin.smethod_24(Label10, (ContentAlignment)32);
					num = ((int)num2 * -1572673000) ^ 0x2E30E5E;
					continue;
				case 219u:
					PictureBox1 = SearchDonor_Admin.smethod_3();
					num = ((int)num2 * -1527831084) ^ 0x5D36BC8F;
					continue;
				case 218u:
					SearchDonor_Admin.smethod_40((ListControl)(object)BloodGroupTxt, bool_0: true);
					num = (int)((num2 * 2017865650) ^ 0x23A2B16A);
					continue;
				case 217u:
					SearchDonor_Admin.smethod_15((Control)(object)ClearBtn, "ClearBtn");
					SearchDonor_Admin.smethod_16((Control)(object)ClearBtn, new Size(104, 37));
					SearchDonor_Admin.smethod_22((Control)(object)ClearBtn, 12);
					num = ((int)num2 * -1683758381) ^ -372427239;
					continue;
				case 216u:
					SearchDonor_Admin.smethod_27(SearchResultGrid, bool_0: true);
					num = ((int)num2 * -28220375) ^ -376832414;
					continue;
				case 215u:
					num = ((int)num2 * -734245526) ^ 0x46F7B504;
					continue;
				case 214u:
					num = (int)((num2 * 2032732988) ^ 0x719749B4);
					continue;
				case 213u:
					SearchDonor_Admin.smethod_30((Control)(object)UpdateBtn, bool_0: false);
					num = ((int)num2 * -1338233566) ^ -1350543254;
					continue;
				case 212u:
					SearchDonor_Admin.smethod_14((Control)(object)PictureBox1, new Point(165, 20));
					num = ((int)num2 * -1627343856) ^ 0x43FC4ACE;
					continue;
				case 211u:
					SearchDonor_Admin.smethod_39(GenderTxt, (ComboBoxStyle)2);
					num = (int)((num2 * 1911074142) ^ 0x54C9B81D);
					continue;
				case 210u:
					SearchDonor_Admin.smethod_23(Label2, "Mobile : ");
					num = (int)((num2 * 44645124) ^ 0x2F31BD5F);
					continue;
				case 209u:
					MobileTxt = SearchDonor_Admin.smethod_8();
					num = (int)((num2 * 1279813969) ^ 0x4E8F07D0);
					continue;
				case 208u:
					SearchDonor_Admin.smethod_43((TextBoxBase)(object)QuantityTxt, bool_0: true);
					num = ((int)num2 * -1700619605) ^ 0x3DF9A35B;
					continue;
				case 207u:
					num = ((int)num2 * -1431401384) ^ 0x34CD2E31;
					continue;
				case 206u:
					SearchDonor_Admin.smethod_23(Label4, "Blood Group : ");
					SearchDonor_Admin.smethod_24(Label4, (ContentAlignment)32);
					num = ((int)num2 * -1356634055) ^ -1040000889;
					continue;
				case 205u:
					SearchDonor_Admin.smethod_23(Label8, "Name : ");
					num = (int)((num2 * 932460066) ^ 0x3E57770E);
					continue;
				case 204u:
					num = (int)(num2 * 745256955) ^ -1584220261;
					continue;
				case 203u:
					SearchDonor_Admin.smethod_14((Control)(object)QuantityTxt, new Point(507, 215));
					num = ((int)num2 * -207126630) ^ 0x7F8882FD;
					continue;
				case 202u:
					num = (int)((num2 * 1588967393) ^ 0x38812E06);
					continue;
				case 201u:
					SearchBtn = SearchDonor_Admin.smethod_6();
					num = (int)(num2 * 61636968) ^ -2131035191;
					continue;
				case 200u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)Label3);
					num = ((int)num2 * -1383345226) ^ 0x700389B7;
					continue;
				case 199u:
					SearchDonor_Admin.smethod_32((Control)(object)ClearBtn, Color.White);
					num = (int)(num2 * 129235541) ^ -1583528889;
					continue;
				case 198u:
					SearchDonor_Admin.smethod_14((Control)(object)Label4, new Point(388, 164));
					SearchDonor_Admin.smethod_15((Control)(object)Label4, "Label4");
					num = ((int)num2 * -1590228328) ^ -1812629280;
					continue;
				case 197u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_47((Control)(object)this), (Control)(object)SearchResultGrid);
					num = ((int)num2 * -1519730059) ^ -730859235;
					continue;
				case 196u:
					SearchDonor_Admin.smethod_16((Control)(object)NameTxt, new Size(271, 28));
					SearchDonor_Admin.smethod_22((Control)(object)NameTxt, 4);
					num = ((int)num2 * -1535609332) ^ 0x486F8D27;
					continue;
				case 195u:
					SearchDonor_Admin.smethod_14((Control)(object)Label2, new Point(37, 87));
					num = ((int)num2 * -764961603) ^ -765269462;
					continue;
				case 194u:
					SearchDonor_Admin.smethod_22((Control)(object)Label2, 3);
					num = ((int)num2 * -17587083) ^ 0x27E14A5;
					continue;
				case 193u:
					SearchDonor_Admin.smethod_14((Control)(object)Label10, new Point(37, 44));
					SearchDonor_Admin.smethod_15((Control)(object)Label10, "Label10");
					num = (int)(num2 * 524635892) ^ -1206709349;
					continue;
				case 192u:
					SearchDonor_Admin.smethod_15((Control)(object)QuantityTxt, "QuantityTxt");
					num = (int)((num2 * 2042611235) ^ 0x66344481);
					continue;
				case 191u:
					DeleteBtn = SearchDonor_Admin.smethod_6();
					num = (int)(num2 * 1474493294) ^ -150014820;
					continue;
				case 190u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)Label12);
					num = (int)(num2 * 1431292717) ^ -1053124867;
					continue;
				case 189u:
					GroupBox1 = SearchDonor_Admin.smethod_7();
					num = ((int)num2 * -1442158535) ^ -723160940;
					continue;
				case 188u:
					num = (int)(num2 * 394994879) ^ -920347720;
					continue;
				case 187u:
					SearchDonor_Admin.smethod_31((ButtonBase)(object)SearchBtn, Color.MidnightBlue);
					num = ((int)num2 * -1588597524) ^ -2047671969;
					continue;
				case 186u:
					num = ((int)num2 * -1885435760) ^ -496008616;
					continue;
				case 185u:
					SearchDonor_Admin.smethod_22((Control)(object)MobileSTxt, 2);
					num = (int)(num2 * 1360197597) ^ -1868889753;
					continue;
				case 184u:
					num = (int)(num2 * 946348507) ^ -1129635040;
					continue;
				case 183u:
					num = ((int)num2 * -937412256) ^ 0x2769F07C;
					continue;
				case 182u:
					SearchDonor_Admin.smethod_14((Control)(object)NameTxt, new Point(117, 77));
					num = (int)(num2 * 690977236) ^ -58383550;
					continue;
				case 181u:
					SearchDonor_Admin.smethod_21((Control)(object)Label10, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1036639154) ^ 0x3FC73BBC);
					continue;
				case 180u:
					SearchDonor_Admin.smethod_30((Control)(object)DeleteBtn, bool_0: false);
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)GroupBox1), (Control)(object)SearchBtn);
					num = ((int)num2 * -266684579) ^ -566380886;
					continue;
				case 179u:
					SearchDonor_Admin.smethod_33((ButtonBase)(object)UpdateBtn, "Update");
					SearchDonor_Admin.smethod_34((ButtonBase)(object)UpdateBtn, bool_0: false);
					num = (int)((num2 * 1298003662) ^ 0x2120F70D);
					continue;
				case 178u:
					SearchDonor_Admin.smethod_16((Control)(object)Label9, new Size(77, 28));
					num = (int)(num2 * 1529894786) ^ -1669423555;
					continue;
				case 177u:
					SearchDonor_Admin.smethod_38(DonorInfoBox, "Donor Information");
					num = (int)((num2 * 29420994) ^ 0x2D8019F7);
					continue;
				case 176u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)Label6);
					num = (int)((num2 * 1690645278) ^ 0x2883688D);
					continue;
				case 175u:
					num = ((int)num2 * -843508928) ^ 0x25BA6707;
					continue;
				case 174u:
					SearchDonor_Admin.smethod_21((Control)(object)Label2, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1612043389) ^ -1498511465;
					continue;
				case 173u:
					num = (int)(num2 * 380624729) ^ -638973776;
					continue;
				case 172u:
					DOBTxt = SearchDonor_Admin.smethod_8();
					num = ((int)num2 * -2134808873) ^ 0x46DD15E2;
					continue;
				case 171u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)GroupBox1), (Control)(object)NameSTxt);
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)GroupBox1), (Control)(object)Label10);
					num = ((int)num2 * -1455909573) ^ -2032529019;
					continue;
				case 170u:
					SearchDonor_Admin.smethod_22((Control)(object)Label3, 0);
					num = (int)((num2 * 1535353440) ^ 0x3138CB5B);
					continue;
				case 169u:
					SearchDonor_Admin.smethod_16((Control)(object)Label8, new Size(77, 28));
					num = (int)(num2 * 838763539) ^ -559869146;
					continue;
				case 168u:
					Label12 = SearchDonor_Admin.smethod_4();
					IDTxt = SearchDonor_Admin.smethod_8();
					Label11 = SearchDonor_Admin.smethod_4();
					num = ((int)num2 * -1813286215) ^ -313002213;
					continue;
				case 167u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_47((Control)(object)this), (Control)(object)ClearBtn);
					num = ((int)num2 * -1645224628) ^ -1244205620;
					continue;
				case 166u:
					SearchDonor_Admin.smethod_16((Control)(object)SearchBtn, new Size(133, 37));
					num = (int)((num2 * 1933756999) ^ 0x32E01A05);
					continue;
				case 165u:
					SearchDonor_Admin.smethod_16((Control)(object)GenderTxt, new Size(146, 30));
					num = (int)((num2 * 1998210069) ^ 0x318E312E);
					continue;
				case 164u:
					GenderTxt = SearchDonor_Admin.smethod_9();
					num = ((int)num2 * -914137655) ^ -780055240;
					continue;
				case 163u:
					num = ((int)num2 * -2136396226) ^ -715402033;
					continue;
				case 162u:
					SearchDonor_Admin.smethod_16((Control)(object)MobileSTxt, new Size(237, 28));
					num = (int)(num2 * 1800071112) ^ -239573678;
					continue;
				case 161u:
					SearchDonor_Admin.smethod_52((Control)(object)DonorInfoBox);
					num = (int)((num2 * 1919240287) ^ 0x4E3F9B);
					continue;
				case 160u:
					SearchDonor_Admin.smethod_22((Control)(object)Label5, 1);
					SearchDonor_Admin.smethod_23(Label5, "Age :");
					num = (int)(num2 * 1269796677) ^ -1031080071;
					continue;
				case 159u:
					SearchDonor_Admin.smethod_14((Control)(object)SearchResultGrid, new Point(59, 295));
					num = (int)((num2 * 307056829) ^ 0xEAC10E);
					continue;
				case 158u:
					SearchDonor_Admin.smethod_24(Label2, (ContentAlignment)32);
					SearchDonor_Admin.smethod_14((Control)(object)MobileSTxt, new Point(120, 86));
					SearchDonor_Admin.smethod_15((Control)(object)MobileSTxt, "MobileSTxt");
					num = (int)(num2 * 1329811930) ^ -1162029649;
					continue;
				case 157u:
					SearchDonor_Admin.smethod_49((Control)(object)this, new Size(977, 804));
					num = (int)(num2 * 748829087) ^ -185415595;
					continue;
				case 156u:
					num = (int)(num2 * 918215574) ^ -1048838091;
					continue;
				case 155u:
					SearchDonor_Admin.smethod_15((Control)(object)PictureBox1, "PictureBox1");
					num = (int)((num2 * 226821650) ^ 0x3265B0A1);
					continue;
				case 154u:
					num = (int)(num2 * 1136464790) ^ -886607504;
					continue;
				case 153u:
					SearchDonor_Admin.smethod_19(PictureBox1, bool_0: false);
					num = ((int)num2 * -1270963713) ^ -1743369203;
					continue;
				case 152u:
					num = ((int)num2 * -453763836) ^ 0x375928C9;
					continue;
				case 151u:
					Label3 = SearchDonor_Admin.smethod_4();
					num = (int)(num2 * 1719755213) ^ -517845556;
					continue;
				case 150u:
					num = ((int)num2 * -1097979191) ^ -1065964016;
					continue;
				case 149u:
					SearchDonor_Admin.smethod_33((ButtonBase)(object)ClearBtn, "Clear");
					num = ((int)num2 * -1675646463) ^ 0x41E2064D;
					continue;
				case 148u:
					num = (int)((num2 * 1754174355) ^ 0x2C299A86);
					continue;
				case 147u:
					QuantityTxt = SearchDonor_Admin.smethod_8();
					num = (int)((num2 * 388433229) ^ 0x3237BEF2);
					continue;
				case 146u:
					SearchDonor_Admin.smethod_16((Control)(object)UpdateBtn, new Size(104, 37));
					num = ((int)num2 * -857064215) ^ -2018478458;
					continue;
				case 145u:
					SearchDonor_Admin.smethod_22((Control)(object)IDTxt, 17);
					num = (int)(num2 * 1573037037) ^ -2077946719;
					continue;
				case 144u:
					num = ((int)num2 * -95826875) ^ 0x4167682C;
					continue;
				case 143u:
					num = ((int)num2 * -8062275) ^ 0x4591AC36;
					continue;
				case 142u:
					SearchDonor_Admin.smethod_22((Control)(object)Label9, 11);
					SearchDonor_Admin.smethod_23(Label9, "Phone : ");
					num = ((int)num2 * -1837227849) ^ 0x63646F82;
					continue;
				case 141u:
					SearchDonor_Admin.smethod_22((Control)(object)Label6, 2);
					num = ((int)num2 * -1828314186) ^ 0x17D5A66E;
					continue;
				case 140u:
					SearchDonor_Admin.smethod_22((Control)(object)Label8, 9);
					num = (int)((num2 * 904361848) ^ 0x4A34F8F4);
					continue;
				case 139u:
					SearchDonor_Admin.smethod_22((Control)(object)NameSTxt, 1);
					num = ((int)num2 * -880967892) ^ 0x24730451;
					continue;
				case 138u:
					SearchDonor_Admin.smethod_21((Control)(object)Label1, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1593231695) ^ 0x793CD830);
					continue;
				case 137u:
					num = ((int)num2 * -991717072) ^ -1898707313;
					continue;
				case 136u:
					num = (int)((num2 * 2077732428) ^ 0x25C43361);
					continue;
				case 135u:
					SearchDonor_Admin.smethod_21((Control)(object)ClearBtn, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1117536090) ^ 0x15DBE9E);
					continue;
				case 134u:
					SearchDonor_Admin.smethod_22((Control)(object)SearchResultGrid, 10);
					num = ((int)num2 * -356729235) ^ -2079841283;
					continue;
				case 133u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)GroupBox1), (Control)(object)Label2);
					num = (int)((num2 * 2030199704) ^ 0x69ABF572);
					continue;
				case 132u:
					num = ((int)num2 * -946772928) ^ 0x7842246C;
					continue;
				case 131u:
					num = (int)((num2 * 808290772) ^ 0x4A5B56F7);
					continue;
				case 130u:
					SearchDonor_Admin.smethod_16((Control)(object)Label10, new Size(77, 28));
					num = ((int)num2 * -401929926) ^ 0x5A5F9C59;
					continue;
				case 129u:
					SearchDonor_Admin.smethod_13(PictureBox1, (Image)(object)Resources.images1232);
					num = (int)((num2 * 1634438688) ^ 0x61A4A575);
					continue;
				case 128u:
					Label4 = SearchDonor_Admin.smethod_4();
					num = ((int)num2 * -1054974134) ^ -1613045247;
					continue;
				case 127u:
					SearchDonor_Admin.smethod_22((Control)(object)GroupBox1, 14);
					num = ((int)num2 * -249193347) ^ -1813912049;
					continue;
				case 126u:
					SearchDonor_Admin.smethod_15((Control)(object)SearchResultGrid, "SearchResultGrid");
					num = ((int)num2 * -1553851319) ^ 0x22B81246;
					continue;
				case 125u:
					num = ((int)num2 * -102568680) ^ 0x1ABE381A;
					continue;
				case 124u:
					num = (int)((num2 * 1850414134) ^ 0x1B1CEBEF);
					continue;
				case 123u:
					num = (int)(num2 * 308469728) ^ -43432320;
					continue;
				case 122u:
					num = ((int)num2 * -1247601027) ^ -841770292;
					continue;
				case 121u:
					SearchDonor_Admin.smethod_22((Control)(object)Label10, 0);
					num = (int)((num2 * 2018122018) ^ 0x4C56D66D);
					continue;
				case 120u:
					SearchDonor_Admin.smethod_16((Control)(object)Label4, new Size(134, 28));
					num = (int)(num2 * 1474040222) ^ -865398993;
					continue;
				case 119u:
					SearchDonor_Admin.smethod_16((Control)(object)Label11, new Size(68, 25));
					num = ((int)num2 * -2043484146) ^ 0xA5057FA;
					continue;
				case 118u:
					SearchDonor_Admin.smethod_21((Control)(object)Label6, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1371469623) ^ 0x5A0065F8);
					continue;
				case 117u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_47((Control)(object)this), (Control)(object)UpdateBtn);
					num = ((int)num2 * -1596148490) ^ -1768869597;
					continue;
				case 116u:
					BloodGroupTxt = SearchDonor_Admin.smethod_9();
					num = (int)(num2 * 754383657) ^ -1376858345;
					continue;
				case 115u:
					SearchDonor_Admin.smethod_14((Control)(object)BloodGroupTxt, new Point(531, 164));
					num = ((int)num2 * -1184721223) ^ 0xB5803FB;
					continue;
				case 114u:
					SearchDonor_Admin.smethod_30((Control)(object)SearchResultGrid, bool_0: false);
					num = ((int)num2 * -331942614) ^ -1628837142;
					continue;
				case 113u:
					num = ((int)num2 * -1963561154) ^ 0x1D58913;
					continue;
				case 112u:
					SearchDonor_Admin.smethod_48((Control)(object)this, "SearchDonor_Admin");
					num = ((int)num2 * -684302706) ^ 0x7CA35F1D;
					continue;
				case 111u:
					SearchDonor_Admin.smethod_31((ButtonBase)(object)DeleteBtn, Color.MidnightBlue);
					num = (int)(num2 * 45854864) ^ -1830035576;
					continue;
				case 110u:
					num = (int)((num2 * 564885318) ^ 0x433C3E78);
					continue;
				case 109u:
					SearchDonor_Admin.smethod_18(PictureBox1, 6);
					num = ((int)num2 * -817175232) ^ -1148864252;
					continue;
				case 108u:
					SearchDonor_Admin.smethod_12((Control)(object)this);
					num = (int)((num2 * 1990567250) ^ 0x2A341076);
					continue;
				case 107u:
					SearchDonor_Admin.smethod_21((Control)(object)Label12, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -234436149) ^ -1840782490;
					continue;
				case 106u:
					SearchDonor_Admin.smethod_42(SearchDonor_Admin.smethod_41(BloodGroupTxt), new object[8] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
					num = ((int)num2 * -857420106) ^ 0x4E90B17B;
					continue;
				case 105u:
					SearchDonor_Admin.smethod_16((Control)(object)DonorInfoBox, new Size(699, 259));
					num = (int)((num2 * 1823388983) ^ 0x23B805E9);
					continue;
				case 104u:
					num = (int)((num2 * 1712953451) ^ 0x18A0F30D);
					continue;
				case 103u:
					num = (int)((num2 * 266290192) ^ 0xC9FC733);
					continue;
				case 102u:
					SearchDonor_Admin.smethod_16((Control)(object)PictureBox1, new Size(200, 110));
					num = ((int)num2 * -436940179) ^ -792032477;
					continue;
				case 101u:
					SearchDonor_Admin.smethod_38(GroupBox1, "Search Patient");
					num = (int)((num2 * 98909553) ^ 0x3B423435);
					continue;
				case 100u:
					SearchDonor_Admin.smethod_14((Control)(object)Label6, new Point(401, 129));
					num = (int)((num2 * 1717720833) ^ 0x7C000165);
					continue;
				case 99u:
					num = (int)(num2 * 60437241) ^ -330674139;
					continue;
				case 98u:
					SearchDonor_Admin.smethod_32((Control)(object)SearchBtn, Color.White);
					num = ((int)num2 * -71191087) ^ 0x69D4F7B5;
					continue;
				case 97u:
					num = (int)(num2 * 845099193) ^ -1719537022;
					continue;
				case 96u:
					SearchDonor_Admin.smethod_16((Control)(object)GroupBox1, new Size(623, 128));
					num = ((int)num2 * -1212499024) ^ -1411150202;
					continue;
				case 95u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_47((Control)(object)this), (Control)(object)Label1);
					num = ((int)num2 * -1395112604) ^ -579409677;
					continue;
				case 94u:
					num = (int)(num2 * 896208695) ^ -929965157;
					continue;
				case 93u:
					SearchDonor_Admin.smethod_14((Control)(object)ClearBtn, new Point(808, 667));
					num = ((int)num2 * -193919272) ^ -790705175;
					continue;
				case 92u:
					num = ((int)num2 * -2068915322) ^ 0x6E64119E;
					continue;
				case 91u:
					SearchDonor_Admin.smethod_15((Control)(object)NameSTxt, "NameSTxt");
					SearchDonor_Admin.smethod_16((Control)(object)NameSTxt, new Size(237, 28));
					num = ((int)num2 * -168096617) ^ -1931020993;
					continue;
				case 90u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_47((Control)(object)this), (Control)(object)DonorInfoBox);
					num = (int)((num2 * 1931637123) ^ 0x6DECB4D2);
					continue;
				case 89u:
					num = ((int)num2 * -1654329274) ^ -47172879;
					continue;
				case 88u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)Label9);
					num = (int)((num2 * 1689409380) ^ 0x8280BB1);
					continue;
				case 87u:
					num = (int)(num2 * 730169527) ^ -898622320;
					continue;
				case 86u:
					num = (int)(num2 * 1596917834) ^ -1051304395;
					continue;
				case 85u:
					num = (int)(num2 * 1168357000) ^ -1479192941;
					continue;
				case 84u:
					SearchDonor_Admin.smethod_14((Control)(object)GroupBox1, new Point(155, 150));
					num = ((int)num2 * -2013768359) ^ -1039204487;
					continue;
				case 83u:
					SearchDonor_Admin.smethod_34((ButtonBase)(object)ClearBtn, bool_0: false);
					num = ((int)num2 * -433244760) ^ -444914673;
					continue;
				case 82u:
					SearchDonor_Admin.smethod_14((Control)(object)SearchBtn, new Point(468, 82));
					num = (int)((num2 * 1524433590) ^ 0x2D830138);
					continue;
				case 81u:
					SearchDonor_Admin.smethod_24(Label1, (ContentAlignment)32);
					num = (int)(num2 * 1890988099) ^ -1792439716;
					continue;
				case 80u:
					num = (int)((num2 * 745762783) ^ 0x38720299);
					continue;
				case 79u:
					SearchDonor_Admin.smethod_15((Control)(object)Label8, "Label8");
					num = ((int)num2 * -1772739520) ^ -751850767;
					continue;
				case 78u:
					SearchDonor_Admin.smethod_11((Control)(object)DonorInfoBox);
					num = (int)((num2 * 1607363615) ^ 0x170D3B11);
					continue;
				case 77u:
					num = ((int)num2 * -812854442) ^ 0x11432E27;
					continue;
				case 76u:
					num = (int)(num2 * 1502420569) ^ -657261051;
					continue;
				case 75u:
					SearchDonor_Admin.smethod_15((Control)(object)Label9, "Label9");
					num = ((int)num2 * -141048477) ^ -1741208658;
					continue;
				case 74u:
					num = (int)(num2 * 467596682) ^ -673696326;
					continue;
				case 73u:
					num = (int)(num2 * 1056504694) ^ -1682705656;
					continue;
				case 72u:
					num = (int)((num2 * 1979030925) ^ 0x6D62A20E);
					continue;
				case 71u:
					num = (int)((num2 * 708231176) ^ 0x1DDC0EE7);
					continue;
				case 70u:
					SearchDonor_Admin.smethod_16((Control)(object)DOBTxt, new Size(169, 28));
					num = (int)(num2 * 592158302) ^ -1263010076;
					continue;
				case 69u:
					SearchDonor_Admin.smethod_16((Control)(object)DateOfDonationTxt, new Size(192, 28));
					num = (int)(num2 * 1780426780) ^ -332901308;
					continue;
				case 68u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)QuantityTxt);
					num = (int)((num2 * 19273268) ^ 0x4632BC70);
					continue;
				case 67u:
					SearchDonor_Admin.smethod_32((Control)(object)UpdateBtn, Color.White);
					num = (int)((num2 * 230588951) ^ 0x15FCDA85);
					continue;
				case 66u:
					num = ((int)num2 * -1674134394) ^ -361430206;
					continue;
				case 64u:
					SearchDonor_Admin.smethod_15((Control)(object)UpdateBtn, "UpdateBtn");
					num = (int)(num2 * 234510394) ^ -750076445;
					continue;
				case 63u:
					SearchDonor_Admin.smethod_21((Control)(object)SearchBtn, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -544663398) ^ -1001120423;
					continue;
				case 62u:
					Label6 = SearchDonor_Admin.smethod_4();
					num = (int)(num2 * 652401727) ^ -661407499;
					continue;
				case 61u:
					SearchDonor_Admin.smethod_21((Control)(object)GroupBox1, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 36675340) ^ 0x7FD6A43D);
					continue;
				case 60u:
					num = ((int)num2 * -877443993) ^ -212861941;
					continue;
				case 59u:
					SearchDonor_Admin.smethod_43((TextBoxBase)(object)DateOfDonationTxt, bool_0: true);
					num = (int)((num2 * 1572147690) ^ 0x9792394);
					continue;
				case 58u:
					SearchDonor_Admin.smethod_22((Control)(object)Label4, 13);
					num = (int)(num2 * 1790966028) ^ -1602604435;
					continue;
				case 57u:
					SearchDonor_Admin.smethod_52((Control)(object)GroupBox1);
					num = ((int)num2 * -1767783543) ^ 0x3A004313;
					continue;
				case 56u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)BloodGroupTxt);
					num = ((int)num2 * -958014601) ^ -1131720831;
					continue;
				case 55u:
					SearchDonor_Admin.smethod_30((Control)(object)DonorInfoBox, bool_0: false);
					num = ((int)num2 * -1154975778) ^ -2040468893;
					continue;
				case 54u:
					SearchDonor_Admin.smethod_34((ButtonBase)(object)SearchBtn, bool_0: false);
					num = ((int)num2 * -1939754019) ^ 0x55C6AB8F;
					continue;
				case 53u:
					SearchDonor_Admin.smethod_16((Control)(object)Label5, new Size(84, 26));
					num = ((int)num2 * -2861738) ^ -1222670771;
					continue;
				case 52u:
					num = (int)(num2 * 1403359586) ^ -2060790600;
					continue;
				case 51u:
					SearchDonor_Admin.smethod_15((Control)(object)DateOfDonationTxt, "DateOfDonationTxt");
					num = ((int)num2 * -1885566605) ^ -335457353;
					continue;
				case 50u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)GroupBox1), (Control)(object)MobileSTxt);
					num = (int)((num2 * 2128853396) ^ 0x180AF163);
					continue;
				case 49u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_47((Control)(object)this), (Control)(object)GroupBox1);
					num = ((int)num2 * -504481772) ^ 0x3C46868E;
					continue;
				case 48u:
					num = ((int)num2 * -158313298) ^ 0x29DF25FF;
					continue;
				case 47u:
					SearchDonor_Admin.smethod_15((Control)(object)BloodGroupTxt, "BloodGroupTxt");
					num = ((int)num2 * -1390354518) ^ 0x6DBDB895;
					continue;
				case 46u:
					SearchDonor_Admin.smethod_32((Control)(object)DeleteBtn, Color.White);
					num = ((int)num2 * -827948061) ^ 0x7CCE0830;
					continue;
				case 45u:
					SearchDonor_Admin.smethod_14((Control)(object)UpdateBtn, new Point(808, 517));
					num = (int)(num2 * 1244928283) ^ -344137443;
					continue;
				case 44u:
					SearchDonor_Admin.smethod_31((ButtonBase)(object)UpdateBtn, Color.MidnightBlue);
					num = (int)(num2 * 1295580149) ^ -1570655934;
					continue;
				case 43u:
					SearchDonor_Admin.smethod_50((ISupportInitialize)PictureBox1);
					SearchDonor_Admin.smethod_50((ISupportInitialize)SearchResultGrid);
					SearchDonor_Admin.smethod_51((Control)(object)GroupBox1, bool_0: false);
					num = ((int)num2 * -713497485) ^ -1224506849;
					continue;
				case 42u:
					SearchDonor_Admin.smethod_22((Control)(object)DonorInfoBox, 15);
					SearchDonor_Admin.smethod_37(DonorInfoBox, bool_0: false);
					num = ((int)num2 * -1747886651) ^ -834386533;
					continue;
				case 41u:
					num = ((int)num2 * -689310208) ^ -1349845328;
					continue;
				case 40u:
					num = ((int)num2 * -2006747682) ^ 0x5FD21D6;
					continue;
				case 39u:
					SearchDonor_Admin.smethod_26(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					num = ((int)num2 * -114640693) ^ 0x375BBB11;
					continue;
				case 38u:
					num = ((int)num2 * -675508260) ^ 0x6AF1889B;
					continue;
				case 37u:
					SearchDonor_Admin.smethod_15((Control)(object)MobileTxt, "MobileTxt");
					num = ((int)num2 * -2096632553) ^ -1156725342;
					continue;
				case 36u:
					Label10 = SearchDonor_Admin.smethod_4();
					num = ((int)num2 * -1375187147) ^ -1341440416;
					continue;
				case 35u:
					num = (int)(num2 * 61490070) ^ -1668470332;
					continue;
				case 34u:
					SearchDonor_Admin.smethod_43((TextBoxBase)(object)IDTxt, bool_0: true);
					num = (int)((num2 * 978935239) ^ 0x464F0C9B);
					continue;
				case 33u:
					num = (int)((num2 * 1790624486) ^ 0x318497D8);
					continue;
				case 32u:
					num = ((int)num2 * -603709106) ^ -704919041;
					continue;
				case 31u:
					num = ((int)num2 * -255848505) ^ -1806220226;
					continue;
				case 30u:
					SearchDonor_Admin.smethod_15((Control)(object)GroupBox1, "GroupBox1");
					num = ((int)num2 * -225256536) ^ 0x68D2EDD3;
					continue;
				case 29u:
					NameSTxt = SearchDonor_Admin.smethod_8();
					num = (int)(num2 * 228096545) ^ -208373670;
					continue;
				case 28u:
					Label5 = SearchDonor_Admin.smethod_4();
					num = (int)((num2 * 1798276647) ^ 0xBE81DA0);
					continue;
				case 27u:
					SearchDonor_Admin.smethod_24(Label9, (ContentAlignment)32);
					num = (int)((num2 * 344905276) ^ 0x4A0BE35F);
					continue;
				case 26u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)GenderTxt);
					num = ((int)num2 * -1376727883) ^ 0x48A6BD95;
					continue;
				case 25u:
					SearchDonor_Admin.smethod_21((Control)(object)Label11, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 814588851) ^ 0x1060FE14);
					continue;
				case 24u:
					SearchDonor_Admin.smethod_15((Control)(object)DeleteBtn, "DeleteBtn");
					SearchDonor_Admin.smethod_16((Control)(object)DeleteBtn, new Size(104, 37));
					num = ((int)num2 * -1848690556) ^ 0x3CB9E5C9;
					continue;
				case 23u:
					SearchDonor_Admin.smethod_21((Control)(object)Label5, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchDonor_Admin.smethod_14((Control)(object)Label5, new Point(16, 169));
					num = ((int)num2 * -1144311400) ^ 0x74B7EC1D;
					continue;
				case 22u:
					SearchDonor_Admin.smethod_16((Control)(object)Label2, new Size(77, 28));
					num = ((int)num2 * -331359187) ^ -62456078;
					continue;
				case 21u:
					num = (int)((num2 * 163971780) ^ 0x3F19B2E6);
					continue;
				case 20u:
					SearchDonor_Admin.smethod_39(BloodGroupTxt, (ComboBoxStyle)2);
					num = ((int)num2 * -278294179) ^ -906372007;
					continue;
				case 19u:
					num = ((int)num2 * -536521846) ^ 0x37212BAB;
					continue;
				case 18u:
					SearchDonor_Admin.smethod_14((Control)(object)Label3, new Point(16, 221));
					SearchDonor_Admin.smethod_15((Control)(object)Label3, "Label3");
					SearchDonor_Admin.smethod_16((Control)(object)Label3, new Size(174, 25));
					num = ((int)num2 * -1918083911) ^ -1922707075;
					continue;
				case 17u:
					SearchDonor_Admin.smethod_15((Control)(object)NameTxt, "NameTxt");
					num = ((int)num2 * -400884856) ^ -1114606105;
					continue;
				case 16u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_47((Control)(object)this), (Control)(object)PictureBox1);
					num = (int)((num2 * 256358969) ^ 0x194B6BA4);
					continue;
				case 15u:
					SearchDonor_Admin.smethod_22((Control)(object)UpdateBtn, 16);
					num = (int)((num2 * 1110845854) ^ 0x28E663BC);
					continue;
				case 14u:
					num = (int)((num2 * 311922579) ^ 0x63E57D80);
					continue;
				case 13u:
					SearchDonor_Admin.smethod_14((Control)(object)DeleteBtn, new Point(808, 588));
					num = ((int)num2 * -1144573747) ^ -2037364588;
					continue;
				case 12u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_35((Control)(object)DonorInfoBox), (Control)(object)DateOfDonationTxt);
					num = (int)((num2 * 606126577) ^ 0x42838B3C);
					continue;
				case 11u:
					SearchDonor_Admin.smethod_22((Control)(object)DateOfDonationTxt, 10);
					num = (int)((num2 * 964413163) ^ 0x20621DE3);
					continue;
				case 10u:
					SearchDonor_Admin.smethod_11((Control)(object)GroupBox1);
					num = ((int)num2 * -635971985) ^ -1728583616;
					continue;
				case 9u:
					NameTxt = SearchDonor_Admin.smethod_8();
					num = ((int)num2 * -1215643322) ^ -1180642347;
					continue;
				case 8u:
					num = ((int)num2 * -1230406645) ^ -665941035;
					continue;
				case 7u:
					SearchDonor_Admin.smethod_37(GroupBox1, bool_0: false);
					num = (int)((num2 * 2033336760) ^ 0x65685880);
					continue;
				case 6u:
					num = ((int)num2 * -1045945990) ^ -781126244;
					continue;
				case 5u:
					SearchDonor_Admin.smethod_14((Control)(object)Label12, new Point(401, 217));
					num = (int)((num2 * 1413138481) ^ 0x55480975);
					continue;
				case 4u:
					SearchDonor_Admin.smethod_14((Control)(object)MobileTxt, new Point(117, 124));
					num = ((int)num2 * -828258372) ^ -875292554;
					continue;
				case 3u:
					SearchDonor_Admin.smethod_36(SearchDonor_Admin.smethod_47((Control)(object)this), (Control)(object)DeleteBtn);
					num = ((int)num2 * -2003461355) ^ -219432979;
					continue;
				case 2u:
					SearchDonor_Admin.smethod_23(Label11, "ID :");
					SearchDonor_Admin.smethod_21((Control)(object)Label4, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -498370318) ^ 0x3D77FD36;
					continue;
				case 1u:
					SearchDonor_Admin.smethod_14((Control)(object)Label8, new Point(16, 78));
					num = (int)((num2 * 1097026096) ^ 0x6D86638F);
					continue;
				case 0u:
					SearchDonor_Admin.smethod_21((Control)(object)DonorInfoBox, SearchDonor_Admin.smethod_20("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchDonor_Admin.smethod_14((Control)(object)DonorInfoBox, new Point(79, 470));
					SearchDonor_Admin.smethod_15((Control)(object)DonorInfoBox, "DonorInfoBox");
					num = ((int)num2 * -1383973599) ^ 0x2EB7C74A;
					continue;
				default:
					return;
				case 65u:
					break;
				case 318u:
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
			int num = -45512291;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD3AEE7F3u) % 3u)
				{
				case 2u:
					goto IL_0030;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0030:
				HideItemsOnForm();
				num = ((int)num2 * -1809074145) ^ -1007316720;
			}
		}
	}

	private bool HideItemsOnForm()
	{
		SearchDonor_Admin.smethod_30((Control)(object)SearchResultGrid, bool_0: false);
		bool result = default(bool);
		while (true)
		{
			int num = 1054542710;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2D873348u) % 6u)
				{
				case 4u:
					num = ((int)num2 * -1420388792) ^ -2026280866;
					continue;
				case 3u:
					SearchDonor_Admin.smethod_30((Control)(object)UpdateBtn, bool_0: false);
					result = true;
					num = ((int)num2 * -338934165) ^ -197074039;
					continue;
				case 1u:
					SearchDonor_Admin.smethod_30((Control)(object)DeleteBtn, bool_0: false);
					num = ((int)num2 * -1673716885) ^ 0x1C4EE2C8;
					continue;
				case 0u:
					SearchDonor_Admin.smethod_30((Control)(object)DonorInfoBox, bool_0: false);
					SearchDonor_Admin.smethod_30((Control)(object)ClearBtn, bool_0: false);
					num = ((int)num2 * -2064345259) ^ -1956537183;
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
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected I4, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected I4, but got Unknown
		//IL_032b: Incompatible stack heights: 0 vs 1
		//IL_0332: Incompatible stack heights: 0 vs 1
		bool flag2 = default(bool);
		string string_ = default(string);
		DataTable dataTable = default(DataTable);
		bool flag = default(bool);
		while (true)
		{
			int num = 1074436488;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6BB586EDu) % 11u)
				{
				case 10u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = 282729473;
						num7 = 282729473;
					}
					else
					{
						num6 = 1504992193;
						num7 = 1504992193;
					}
					num = num6 ^ (int)(num2 * 1827395871);
					continue;
				}
				case 8u:
					string_ = SearchDonor_Admin.smethod_64(new string[5]
					{
						"Select * From [Donor] Where [Name] Like '%",
						SearchDonor_Admin.smethod_61(SearchDonor_Admin.smethod_60(NameSTxt)),
						"%' And [Mobile] Like '%",
						SearchDonor_Admin.smethod_60(MobileSTxt),
						"%';"
					});
					num = ((int)num2 * -173921695) ^ 0x67F40EE7;
					continue;
				case 6u:
					SearchDonor_Admin.smethod_62("No Results Found");
					num = (int)((num2 * 110153190) ^ 0x410D8FF2);
					continue;
				case 5u:
					flag2 = !MyProject.Forms.Form1.Name_Validation(SearchDonor_Admin.smethod_61(SearchDonor_Admin.smethod_60(NameSTxt))) | !MyProject.Forms.Form1.Mobile_Validator(SearchDonor_Admin.smethod_61(SearchDonor_Admin.smethod_60(MobileSTxt)));
					num = (int)((num2 * 1410112444) ^ 0x2C06E1C9);
					continue;
				case 3u:
					HideItemsOnForm();
					SearchDonor_Admin.smethod_63();
					num = (int)(num2 * 1080220759) ^ -265162971;
					continue;
				case 2u:
					num = 1831141748;
					continue;
				case 1u:
					dataTable = SearchDonor_Admin.smethod_65();
					num = ((int)num2 * -1182779365) ^ 0x2FC35E32;
					continue;
				case 0u:
					SearchDonor_Admin.smethod_66(myconnection);
					num = (int)((num2 * 2057401665) ^ 0x45185C14);
					continue;
				case 9u:
					break;
				default:
					try
					{
						OleDbDataAdapter dbDataAdapter_ = SearchDonor_Admin.smethod_67(string_, myconnection);
						while (true)
						{
							int num3 = 1938824861;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x6BB586EDu) % 12u)
								{
								case 11u:
								{
									int num4;
									int num5;
									if (!flag)
									{
										num4 = -156077217;
										num5 = -156077217;
									}
									else
									{
										num4 = -1311222554;
										num5 = -1311222554;
									}
									num3 = num4 ^ ((int)num2 * -1019598828);
									continue;
								}
								case 9u:
									num3 = (int)(num2 * 1811979154) ^ -496162819;
									continue;
								case 6u:
									SearchDonor_Admin.smethod_71(myconnection);
									num3 = ((int)num2 * -1146653065) ^ -13980366;
									continue;
								case 5u:
									flag = SearchDonor_Admin.smethod_70(SearchResultGrid) == 1;
									num3 = (int)(num2 * 1490084352) ^ -1442780266;
									continue;
								case 4u:
									SearchDonor_Admin.smethod_68((DbDataAdapter)(object)dbDataAdapter_, dataTable);
									SearchDonor_Admin.smethod_69(SearchResultGrid, (object)dataTable);
									num3 = ((int)num2 * -268638304) ^ -212296475;
									continue;
								case 3u:
									SearchDonor_Admin.smethod_62("No Result Found");
									num3 = ((int)num2 * -28534538) ^ 0x3869BCE9;
									continue;
								case 2u:
									num3 = 1622874800;
									continue;
								case 1u:
									SearchDonor_Admin.smethod_30((Control)(object)SearchResultGrid, bool_0: true);
									num3 = (int)(num2 * 982082798) ^ -959101017;
									continue;
								case 0u:
									num3 = (int)((num2 * 1994321966) ^ 0x18F0B390);
									continue;
								case 7u:
									break;
								default:
									SearchDonor_Admin.smethod_71(myconnection);
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
						SearchDonor_Admin.smethod_72(exception_);
						while (true)
						{
							_ = 585670037;
							while (true)
							{
								_003F val = /*Error near IL_02fa: Stack underflow*/^ 0x6BB586ED;
								num2 = (uint)(int)val;
								switch (val % 3)
								{
								case 1:
									SearchDonor_Admin.smethod_71(myconnection);
									_ = ((int)num2 * -647358482) ^ -35647274;
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
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void UpdateBtn_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected I4, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected I4, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Incompatible stack heights: 0 vs 1
		//IL_0376: Incompatible stack heights: 0 vs 1
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		bool flag = default(bool);
		while (true)
		{
			int num = 1027375634;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1FEFF4C5u) % 10u)
				{
				case 8u:
					SearchDonor_Admin.smethod_62("Invalid Credentitals");
					num = ((int)num2 * -2079663495) ^ 0x467510BD;
					continue;
				case 6u:
				{
					int num6;
					int num7;
					if (!(MyProject.Forms.Form1.Name_Validation(SearchDonor_Admin.smethod_61(SearchDonor_Admin.smethod_60(NameTxt))) & MyProject.Forms.Form1.Mobile_Validator(SearchDonor_Admin.smethod_60(MobileTxt)) & MyProject.Forms.Form1.age_validator(SearchDonor_Admin.smethod_60(DOBTxt))))
					{
						num6 = 844815925;
						num7 = 844815925;
					}
					else
					{
						num6 = 2079110873;
						num7 = 2079110873;
					}
					num = num6 ^ ((int)num2 * -743012259);
					continue;
				}
				case 5u:
					num = 499212861;
					continue;
				case 3u:
					flag = (SearchDonor_Admin.smethod_74(SearchDonor_Admin.smethod_60(NameTxt), "", bool_0: false) == 0) | (SearchDonor_Admin.smethod_74(SearchDonor_Admin.smethod_60(MobileTxt), "", bool_0: false) == 0) | (SearchDonor_Admin.smethod_74(SearchDonor_Admin.smethod_75(GenderTxt), "", bool_0: false) == 0) | (SearchDonor_Admin.smethod_74(SearchDonor_Admin.smethod_60(DOBTxt), "", bool_0: false) == 0) | (SearchDonor_Admin.smethod_74(SearchDonor_Admin.smethod_75(BloodGroupTxt), "", bool_0: false) == 0);
					num = (int)(num2 * 344808459) ^ -1281982813;
					continue;
				case 2u:
					num = 126882161;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1989722686;
						num5 = -1989722686;
					}
					else
					{
						num4 = -1703162888;
						num5 = -1703162888;
					}
					num = num4 ^ (int)(num2 * 1048900350);
					continue;
				}
				case 9u:
					break;
				default:
				{
					OleDbCommand val = SearchDonor_Admin.smethod_63();
					string string_ = SearchDonor_Admin.smethod_64(new string[13]
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
					try
					{
						val = SearchDonor_Admin.smethod_76(string_, myconnection);
						SearchDonor_Admin.smethod_77(val);
						SearchDonor_Admin.smethod_78((Component)(object)val);
						while (true)
						{
							int num3 = 1815929481;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x1FEFF4C5u) % 7u)
								{
								case 6u:
									ClearDonorInfoBox();
									num3 = ((int)num2 * -1390678838) ^ -216407863;
									continue;
								case 5u:
									SearchDonor_Admin.smethod_62("Successfully Updated Details");
									num3 = ((int)num2 * -1070721689) ^ -1270395391;
									continue;
								case 4u:
									SearchDonor_Admin.smethod_71(myconnection);
									num3 = ((int)num2 * -367362416) ^ 0x1D9006A1;
									continue;
								case 2u:
									UpdateTable();
									num3 = ((int)num2 * -466806437) ^ -566658409;
									continue;
								case 1u:
									num3 = (int)(num2 * 117527816) ^ -216699014;
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
					catch (Exception ex)
					{
						SearchDonor_Admin.smethod_72(ex);
						Exception exception_ = ex;
						while (true)
						{
							_ = 750350596;
							while (true)
							{
								_003F val2 = /*Error near IL_0331: Stack underflow*/^ 0x1FEFF4C5;
								num2 = (uint)(int)val2;
								switch (val2 % 3)
								{
								case 1:
									SearchDonor_Admin.smethod_71(myconnection);
									SearchDonor_Admin.smethod_62(SearchDonor_Admin.smethod_79(exception_));
									_ = (num2 * 2135414898) ^ 0x93486F95u;
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
				}
				case 7u:
					SearchDonor_Admin.smethod_62("Fields Cannot be empty");
					return;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void DeleteBtn_Click(object sender, EventArgs e)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected I4, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected I4, but got Unknown
		//IL_01c9: Incompatible stack heights: 0 vs 1
		//IL_01d0: Incompatible stack heights: 0 vs 1
		OleDbCommand val = default(OleDbCommand);
		string string_ = default(string);
		while (true)
		{
			int num = -360028164;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF74135F4u) % 7u)
				{
				case 4u:
					val = SearchDonor_Admin.smethod_63();
					string_ = SearchDonor_Admin.smethod_80("Delete From [Donor] Where [DID] = ", SearchDonor_Admin.smethod_60(IDTxt), ";");
					num = ((int)num2 * -1452259337) ^ 0x16EBA3CF;
					continue;
				case 3u:
					num = -1439700403;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (SearchDonor_Admin.smethod_74(SearchDonor_Admin.smethod_60(IDTxt), "", bool_0: false) != 0)
					{
						num4 = -294040017;
						num5 = -294040017;
					}
					else
					{
						num4 = -1817430457;
						num5 = -1817430457;
					}
					num = num4 ^ ((int)num2 * -1851399283);
					continue;
				}
				case 0u:
					SearchDonor_Admin.smethod_62("Nothing To Delete");
					num = ((int)num2 * -1713817084) ^ 0x114418E1;
					continue;
				case 6u:
					break;
				default:
					SearchDonor_Admin.smethod_66(myconnection);
					try
					{
						while (true)
						{
							int num3 = -773967378;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xF74135F4u) % 6u)
								{
								case 4u:
									SearchDonor_Admin.smethod_78((Component)(object)val);
									num3 = ((int)num2 * -995307442) ^ -1322649385;
									continue;
								case 3u:
									SearchDonor_Admin.smethod_77(val);
									num3 = ((int)num2 * -965617385) ^ -1717558997;
									continue;
								case 2u:
									val = SearchDonor_Admin.smethod_76(string_, myconnection);
									num3 = ((int)num2 * -1233147390) ^ -1011461217;
									continue;
								case 1u:
									SearchDonor_Admin.smethod_71(myconnection);
									UpdateTable();
									ClearDonorInfoBox();
									SearchDonor_Admin.smethod_62("Successfully Deleted Entry");
									num3 = ((int)num2 * -572151731) ^ -105466960;
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
					catch (Exception exception_)
					{
						SearchDonor_Admin.smethod_72(exception_);
						while (true)
						{
							_ = -226630618;
							while (true)
							{
								_003F val2 = /*Error near IL_0198: Stack underflow*/^ -146721292;
								num2 = (uint)(int)val2;
								switch (val2 % 3)
								{
								case 1:
									SearchDonor_Admin.smethod_71(myconnection);
									_ = (num2 * 1764721189) ^ 0xF065751Bu;
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
				case 5u:
					return;
				}
				break;
			}
		}
	}

	private void SearchResultGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected I4, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected I4, but got Unknown
		//IL_0378: Incompatible stack heights: 0 vs 1
		//IL_037f: Incompatible stack heights: 0 vs 1
		try
		{
			SearchDonor_Admin.smethod_88(IDTxt, SearchDonor_Admin.smethod_87(SearchDonor_Admin.smethod_86(SearchDonor_Admin.smethod_85(SearchDonor_Admin.smethod_84(SearchDonor_Admin.smethod_83(SearchDonor_Admin.smethod_81(SearchResultGrid), SearchDonor_Admin.smethod_82(e))), 0))));
			while (true)
			{
				int num = 436846912;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x74C6F5ABu) % 17u)
					{
					case 16u:
						SearchDonor_Admin.smethod_30((Control)(object)UpdateBtn, bool_0: true);
						num = (int)(num2 * 672854044) ^ -916065100;
						continue;
					case 15u:
						SearchDonor_Admin.smethod_88(QuantityTxt, SearchDonor_Admin.smethod_87(SearchDonor_Admin.smethod_86(SearchDonor_Admin.smethod_85(SearchDonor_Admin.smethod_84(SearchDonor_Admin.smethod_83(SearchDonor_Admin.smethod_81(SearchResultGrid), SearchDonor_Admin.smethod_82(e))), 7))));
						num = (int)((num2 * 1313857281) ^ 0x43A8CA20);
						continue;
					case 14u:
						num = (int)((num2 * 2099656391) ^ 0x37915A);
						continue;
					case 13u:
						num = (int)(num2 * 1434661) ^ -1239212177;
						continue;
					case 12u:
						SearchDonor_Admin.smethod_88(DateOfDonationTxt, SearchDonor_Admin.smethod_87(SearchDonor_Admin.smethod_86(SearchDonor_Admin.smethod_85(SearchDonor_Admin.smethod_84(SearchDonor_Admin.smethod_83(SearchDonor_Admin.smethod_81(SearchResultGrid), SearchDonor_Admin.smethod_82(e))), 6))));
						num = (int)(num2 * 638993198) ^ -254074711;
						continue;
					case 11u:
						SearchDonor_Admin.smethod_88(MobileTxt, SearchDonor_Admin.smethod_87(SearchDonor_Admin.smethod_86(SearchDonor_Admin.smethod_85(SearchDonor_Admin.smethod_84(SearchDonor_Admin.smethod_83(SearchDonor_Admin.smethod_81(SearchResultGrid), SearchDonor_Admin.smethod_82(e))), 5))));
						num = ((int)num2 * -1712375149) ^ -1324413740;
						continue;
					case 10u:
						SearchDonor_Admin.smethod_30((Control)(object)DonorInfoBox, bool_0: true);
						num = ((int)num2 * -515879542) ^ -733522438;
						continue;
					case 9u:
						SearchDonor_Admin.smethod_88(NameTxt, SearchDonor_Admin.smethod_87(SearchDonor_Admin.smethod_86(SearchDonor_Admin.smethod_85(SearchDonor_Admin.smethod_84(SearchDonor_Admin.smethod_83(SearchDonor_Admin.smethod_81(SearchResultGrid), SearchDonor_Admin.smethod_82(e))), 1))));
						SearchDonor_Admin.smethod_89(GenderTxt, SearchDonor_Admin.smethod_87(SearchDonor_Admin.smethod_86(SearchDonor_Admin.smethod_85(SearchDonor_Admin.smethod_84(SearchDonor_Admin.smethod_83(SearchDonor_Admin.smethod_81(SearchResultGrid), SearchDonor_Admin.smethod_82(e))), 2))));
						num = (int)((num2 * 429246502) ^ 0x19E69EA1);
						continue;
					case 8u:
						num = ((int)num2 * -1555614562) ^ -1619945100;
						continue;
					case 7u:
						SearchDonor_Admin.smethod_89(BloodGroupTxt, SearchDonor_Admin.smethod_87(SearchDonor_Admin.smethod_86(SearchDonor_Admin.smethod_85(SearchDonor_Admin.smethod_84(SearchDonor_Admin.smethod_83(SearchDonor_Admin.smethod_81(SearchResultGrid), SearchDonor_Admin.smethod_82(e))), 4))));
						num = ((int)num2 * -1811367959) ^ 0x25C9A0C1;
						continue;
					case 5u:
						num = ((int)num2 * -2029598589) ^ 0x2B798C53;
						continue;
					case 4u:
						num = ((int)num2 * -861453366) ^ 0x32E25106;
						continue;
					case 3u:
						SearchDonor_Admin.smethod_30((Control)(object)DeleteBtn, bool_0: true);
						SearchDonor_Admin.smethod_30((Control)(object)ClearBtn, bool_0: true);
						num = ((int)num2 * -745836759) ^ -456505922;
						continue;
					case 2u:
						num = ((int)num2 * -544618039) ^ -220273908;
						continue;
					case 1u:
						SearchDonor_Admin.smethod_88(DOBTxt, SearchDonor_Admin.smethod_87(SearchDonor_Admin.smethod_86(SearchDonor_Admin.smethod_85(SearchDonor_Admin.smethod_84(SearchDonor_Admin.smethod_83(SearchDonor_Admin.smethod_81(SearchResultGrid), SearchDonor_Admin.smethod_82(e))), 3))));
						num = ((int)num2 * -699270239) ^ 0x777C03F8;
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
		catch (Exception exception_)
		{
			SearchDonor_Admin.smethod_72(exception_);
			while (true)
			{
				_ = 1710108405;
				while (true)
				{
					_003F val = /*Error near IL_0354: Stack underflow*/^ 0x74C6F5AB;
					uint num2 = (uint)(int)val;
					switch (val % 3)
					{
					case 1:
						_ = ((int)num2 * -513728808) ^ 0x3A931CF2;
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
	}

	private void ClearBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -910459104;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCF455FAAu) % 3u)
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
				ClearDonorInfoBox();
				num = (int)(num2 * 342563945) ^ -2110574216;
			}
		}
	}

	private bool ClearDonorInfoBox()
	{
		bool result = default(bool);
		while (true)
		{
			int num = 157217994;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5B620F8Bu) % 11u)
				{
				case 9u:
					SearchDonor_Admin.smethod_90((TextBoxBase)(object)DOBTxt);
					num = ((int)num2 * -377726160) ^ -1770902447;
					continue;
				case 8u:
					SearchDonor_Admin.smethod_90((TextBoxBase)(object)IDTxt);
					num = ((int)num2 * -1503746728) ^ -1317028503;
					continue;
				case 7u:
					SearchDonor_Admin.smethod_90((TextBoxBase)(object)NameTxt);
					num = (int)((num2 * 2067607473) ^ 0x3245161B);
					continue;
				case 6u:
					SearchDonor_Admin.smethod_91(GenderTxt, -1);
					num = (int)((num2 * 1595072010) ^ 0x3A8ACB7B);
					continue;
				case 5u:
					SearchDonor_Admin.smethod_91(BloodGroupTxt, -1);
					num = ((int)num2 * -1653937084) ^ 0x1AF8930;
					continue;
				case 4u:
					SearchDonor_Admin.smethod_90((TextBoxBase)(object)MobileTxt);
					num = (int)((num2 * 1318653699) ^ 0x441CAE6D);
					continue;
				case 3u:
					SearchDonor_Admin.smethod_90((TextBoxBase)(object)QuantityTxt);
					result = true;
					num = (int)(num2 * 2074782859) ^ -875100409;
					continue;
				case 1u:
					SearchDonor_Admin.smethod_90((TextBoxBase)(object)DateOfDonationTxt);
					num = ((int)num2 * -306464018) ^ 0x2D9FF939;
					continue;
				case 0u:
					num = (int)(num2 * 588058211) ^ -126162362;
					continue;
				case 10u:
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
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected I4, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected I4, but got Unknown
		//IL_0219: Incompatible stack heights: 0 vs 1
		//IL_0229: Incompatible stack heights: 0 vs 1
		//IL_0230: Incompatible stack heights: 0 vs 1
		string string_ = default(string);
		DataTable dataTable = default(DataTable);
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 1462127748;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x719595C7u) % 4u)
				{
				case 3u:
					SearchDonor_Admin.smethod_63();
					string_ = SearchDonor_Admin.smethod_64(new string[5]
					{
						"Select * From [Donor] Where [Name] Like '%",
						SearchDonor_Admin.smethod_61(SearchDonor_Admin.smethod_60(NameSTxt)),
						"%' And [Mobile] Like '%",
						SearchDonor_Admin.smethod_60(MobileTxt),
						"%';"
					});
					num = ((int)num2 * -130792940) ^ 0x507DF72;
					continue;
				case 1u:
					dataTable = SearchDonor_Admin.smethod_65();
					num = (int)((num2 * 1978600967) ^ 0x7B0CFFDA);
					continue;
				case 0u:
					break;
				default:
					SearchDonor_Admin.smethod_66(myconnection);
					try
					{
						while (true)
						{
							IL_01c2:
							int num3 = 820609034;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x719595C7u) % 10u)
								{
								case 9u:
									result = false;
									num3 = (int)((num2 * 1823213939) ^ 0x666C4A50);
									continue;
								case 8u:
									SearchDonor_Admin.smethod_30((Control)(object)SearchResultGrid, bool_0: true);
									SearchDonor_Admin.smethod_71(myconnection);
									num3 = (int)((num2 * 824189965) ^ 0x7654ABEC);
									continue;
								case 6u:
								{
									int num4;
									int num5;
									if (flag)
									{
										num4 = 8583664;
										num5 = 8583664;
									}
									else
									{
										num4 = 370570328;
										num5 = 370570328;
									}
									num3 = num4 ^ ((int)num2 * -284662133);
									continue;
								}
								case 5u:
								{
									OleDbDataAdapter dbDataAdapter_ = SearchDonor_Admin.smethod_67(string_, myconnection);
									SearchDonor_Admin.smethod_68((DbDataAdapter)(object)dbDataAdapter_, dataTable);
									SearchDonor_Admin.smethod_69(SearchResultGrid, (object)dataTable);
									num3 = ((int)num2 * -689598896) ^ 0x656B85D1;
									continue;
								}
								case 3u:
									num3 = 1861014809;
									continue;
								case 1u:
									SearchDonor_Admin.smethod_71(myconnection);
									num3 = ((int)num2 * -1124254453) ^ -1145589545;
									continue;
								case 0u:
									flag = SearchDonor_Admin.smethod_70(SearchResultGrid) == 1;
									num3 = ((int)num2 * -1914610613) ^ -771188387;
									continue;
								default:
									goto end_IL_0187;
								case 2u:
									break;
								case 7u:
									goto end_IL_0187;
								case 4u:
									return result;
								}
								goto IL_01c2;
								continue;
								end_IL_0187:
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
							IL_022b:
							_ = 184430874;
							while (true)
							{
								_003F val = /*Error near IL_01df: Stack underflow*/^ 0x719595C7;
								num2 = (uint)(int)val;
								switch (val % 4)
								{
								default:
									goto end_IL_01d9;
								case 3:
									SearchDonor_Admin.smethod_71(myconnection);
									SearchDonor_Admin.smethod_73();
									_ = (num2 * 1887870922) ^ 0x4E6E858D;
									continue;
								case 1:
									_ = (num2 * 374450752) ^ 0xCBA90C0;
									continue;
								case 2:
									break;
								case 0:
									goto end_IL_01d9;
								}
								goto IL_022b;
								continue;
								end_IL_01d9:
								break;
							}
							break;
						}
					}
					result = true;
					while (true)
					{
						int num6 = 1102134660;
						while (true)
						{
							switch ((num2 = (uint)num6 ^ 0x719595C7u) % 3u)
							{
							case 1u:
								goto IL_0238;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_0238:
							num6 = ((int)num2 * -1920484457) ^ -1936223769;
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
