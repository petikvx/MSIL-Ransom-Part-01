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
public class UpdateDetails : UserControl
{
	private IContainer components;

	private OleDbConnection myconnection;

	private int selectrow;

	private string mobile;

	private string name_search;

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
			EventHandler eventHandler_ = Button1_Click;
			Button searchBtn = _SearchBtn;
			while (true)
			{
				int num = -301481755;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x86341FA0u) % 6u)
					{
					case 5u:
					{
						_SearchBtn = value;
						searchBtn = _SearchBtn;
						int num5;
						if (searchBtn == null)
						{
							num = -42955351;
							num5 = -42955351;
						}
						else
						{
							num = -1645954222;
							num5 = -1645954222;
						}
						continue;
					}
					case 3u:
					{
						int num3;
						int num4;
						if (searchBtn != null)
						{
							num3 = -116366389;
							num4 = -116366389;
						}
						else
						{
							num3 = -989681286;
							num4 = -989681286;
						}
						num = num3 ^ ((int)num2 * -450851567);
						continue;
					}
					case 2u:
						UpdateDetails.smethod_53((Control)(object)searchBtn, eventHandler_);
						num = ((int)num2 * -2130614060) ^ -1613994559;
						continue;
					case 0u:
						UpdateDetails.smethod_52((Control)(object)searchBtn, eventHandler_);
						num = ((int)num2 * -1003652916) ^ 0x6B03C787;
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
			DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler_ = new DataGridViewCellMouseEventHandler(DataGridView1_CellMouseClick);
			DataGridView searchResultGrid = _SearchResultGrid;
			while (true)
			{
				int num = 1608855939;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x72DAC236u) % 8u)
					{
					case 7u:
					{
						int num5;
						int num6;
						if (searchResultGrid == null)
						{
							num5 = 920480394;
							num6 = 920480394;
						}
						else
						{
							num5 = 585546207;
							num6 = 585546207;
						}
						num = num5 ^ (int)(num2 * 1160906731);
						continue;
					}
					case 6u:
						_SearchResultGrid = value;
						num = 230288638;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (searchResultGrid == null)
						{
							num3 = 1850341978;
							num4 = 1850341978;
						}
						else
						{
							num3 = 302125166;
							num4 = 302125166;
						}
						num = num3 ^ (int)(num2 * 1805855578);
						continue;
					}
					case 4u:
						UpdateDetails.smethod_55(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = ((int)num2 * -806235298) ^ -1201192297;
						continue;
					case 2u:
						UpdateDetails.smethod_54(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = (int)((num2 * 343469956) ^ 0x3C21010);
						continue;
					case 0u:
						searchResultGrid = _SearchResultGrid;
						num = (int)((num2 * 1297436671) ^ 0xEB6371);
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

	[field: AccessedThroughProperty("PatientInfoBox")]
	internal virtual GroupBox PatientInfoBox
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

	[field: AccessedThroughProperty("DOBTxt")]
	internal virtual TextBox DOBTxt
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

	[field: AccessedThroughProperty("NameTxt")]
	internal virtual TextBox NameTxt
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
			Button updateBtn = _UpdateBtn;
			while (true)
			{
				int num = -1784356716;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDB9E13A4u) % 6u)
					{
					case 5u:
						UpdateDetails.smethod_52((Control)(object)updateBtn, eventHandler_);
						num = ((int)num2 * -1883996308) ^ 0x72C8B4BD;
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (updateBtn != null)
						{
							num4 = 388376081;
							num5 = 388376081;
						}
						else
						{
							num4 = 1443582497;
							num5 = 1443582497;
						}
						num = num4 ^ (int)(num2 * 573397988);
						continue;
					}
					case 3u:
					{
						_UpdateBtn = value;
						updateBtn = _UpdateBtn;
						int num3;
						if (updateBtn == null)
						{
							num = -383483198;
							num3 = -383483198;
						}
						else
						{
							num = -219660905;
							num3 = -219660905;
						}
						continue;
					}
					case 1u:
						UpdateDetails.smethod_53((Control)(object)updateBtn, eventHandler_);
						num = ((int)num2 * -16583141) ^ -261790813;
						continue;
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
				int num = 2066223921;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7BBA95E1u) % 6u)
					{
					case 4u:
					{
						_ClearBtn = value;
						clearBtn = _ClearBtn;
						int num5;
						if (clearBtn == null)
						{
							num = 821352720;
							num5 = 821352720;
						}
						else
						{
							num = 2043642804;
							num5 = 2043642804;
						}
						continue;
					}
					case 3u:
						UpdateDetails.smethod_52((Control)(object)clearBtn, eventHandler_);
						num = (int)(num2 * 1776472037) ^ -1273570426;
						continue;
					case 2u:
					{
						clearBtn = _ClearBtn;
						int num3;
						int num4;
						if (clearBtn == null)
						{
							num3 = -698704115;
							num4 = -698704115;
						}
						else
						{
							num3 = -1487566770;
							num4 = -1487566770;
						}
						num = num3 ^ ((int)num2 * -421012344);
						continue;
					}
					case 1u:
						UpdateDetails.smethod_53((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -1518283134) ^ 0x2354BC3A;
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

	public UpdateDetails()
	{
		UpdateDetails.smethod_0((UserControl)(object)this, (EventHandler)UpdateDetails_Load);
		myconnection = UpdateDetails.smethod_1();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			while (true)
			{
				int num = 2026048208;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x1A421761u) % 7u)
					{
					case 6u:
						if (components != null)
						{
							num = 1576422234;
							num3 = 1576422234;
							continue;
						}
						goto IL_001e;
					case 5u:
						if (disposing)
						{
							num = ((int)num2 * -161206676) ^ 0x1507B490;
							continue;
						}
						goto IL_001e;
					case 4u:
						UpdateDetails.smethod_2((IDisposable)components);
						num = ((int)num2 * -674417595) ^ 0xF9F31A1;
						continue;
					case 3u:
						num = 878814128;
						continue;
					case 1u:
						num = (int)(num2 * 794765877) ^ -1799739671;
						continue;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
						IL_001e:
						num = 473396730;
						num3 = 473396730;
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
				IL_00d8:
				int num4 = 1424593703;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num4 ^ 0x1A421761u) % 3u)
					{
					case 1u:
						goto IL_00a7;
					default:
						goto end_IL_00bb;
					case 2u:
						break;
					case 0u:
						goto end_IL_00bb;
					}
					goto IL_00d8;
					IL_00a7:
					((ContainerControl)this).Dispose(disposing);
					num4 = ((int)num2 * -1054763650) ^ 0x4C309634;
					continue;
					end_IL_00bb:
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
			int num = 818533577;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE4941C7u) % 257u)
				{
				case 256u:
					UpdateDetails.smethod_28((ButtonBase)(object)ClearBtn, "Clear");
					num = ((int)num2 * -2040406316) ^ -1524560684;
					continue;
				case 255u:
					UpdateDetails.smethod_14((Control)(object)Label8, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1729426058) ^ -397684421;
					continue;
				case 254u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_44((Control)(object)this), (Control)(object)PatientInfoBox);
					num = ((int)num2 * -589981153) ^ 0x68394478;
					continue;
				case 253u:
					UpdateDetails.smethod_17((Control)(object)DOBTxt, new Size(147, 28));
					num = (int)(num2 * 794136705) ^ -1438290709;
					continue;
				case 252u:
					num = ((int)num2 * -1309470120) ^ 0x6B780A3D;
					continue;
				case 251u:
					UpdateDetails.smethod_23(GroupBox1, bool_0: false);
					num = ((int)num2 * -1839629085) ^ -1791166734;
					continue;
				case 250u:
					UpdateDetails.smethod_50((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1451481244) ^ -878858418;
					continue;
				case 249u:
					UpdateDetails.smethod_18((Control)(object)NameSTxt, 1);
					num = (int)(num2 * 410191770) ^ -450631807;
					continue;
				case 248u:
					UpdateDetails.smethod_18((Control)(object)Label2, 0);
					num = ((int)num2 * -1557344178) ^ 0x43670758;
					continue;
				case 247u:
					num = (int)(num2 * 1619957973) ^ -86039091;
					continue;
				case 246u:
					num = (int)(num2 * 1380182991) ^ -2095805189;
					continue;
				case 245u:
					num = (int)((num2 * 637806784) ^ 0x47600C0);
					continue;
				case 244u:
					UpdateDetails.smethod_16((Control)(object)Label4, "Label4");
					num = (int)(num2 * 1332102806) ^ -1938116121;
					continue;
				case 243u:
					num = ((int)num2 * -812943112) ^ -2103183690;
					continue;
				case 242u:
					UpdateDetails.smethod_15((Control)(object)MobileTxt, new Point(124, 132));
					num = ((int)num2 * -1495408870) ^ -875749874;
					continue;
				case 241u:
					UpdateDetails.smethod_14((Control)(object)PatientInfoBox, UpdateDetails.smethod_13("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -405978703) ^ 0x5AE4F54F;
					continue;
				case 240u:
					SearchBtn = UpdateDetails.smethod_5();
					num = (int)(num2 * 630284019) ^ -373003118;
					continue;
				case 239u:
					UpdateDetails.smethod_14((Control)(object)Label9, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					UpdateDetails.smethod_15((Control)(object)Label9, new Point(20, 132));
					num = ((int)num2 * -1060685861) ^ -2061221173;
					continue;
				case 238u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)Label7);
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)Label6);
					num = (int)(num2 * 388284849) ^ -1451981720;
					continue;
				case 237u:
					UpdateDetails.smethod_18((Control)(object)ClearBtn, 10);
					num = ((int)num2 * -1127287120) ^ 0x332B44E1;
					continue;
				case 236u:
					MobileTxt = UpdateDetails.smethod_6();
					num = (int)((num2 * 1602641150) ^ 0x34E5D58B);
					continue;
				case 235u:
					UpdateDetails.smethod_29((ButtonBase)(object)ClearBtn, bool_0: false);
					num = ((int)num2 * -1509984001) ^ 0x7820720D;
					continue;
				case 234u:
					UpdateDetails.smethod_14((Control)(object)Label1, UpdateDetails.smethod_13("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					UpdateDetails.smethod_15((Control)(object)Label1, new Point(392, 63));
					num = (int)(num2 * 1487551335) ^ -1971964942;
					continue;
				case 233u:
					Label9 = UpdateDetails.smethod_3();
					num = ((int)num2 * -1932630830) ^ -69523548;
					continue;
				case 232u:
					num = ((int)num2 * -2135001211) ^ 0x586AE5CD;
					continue;
				case 231u:
					num = ((int)num2 * -587933800) ^ -681129616;
					continue;
				case 230u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)PIDTxt);
					num = (int)(num2 * 456636761) ^ -927096505;
					continue;
				case 229u:
					UpdateDetails.smethod_18((Control)(object)UpdateBtn, 9);
					num = (int)(num2 * 224747034) ^ -1025011150;
					continue;
				case 228u:
					UpdateDetails.smethod_15((Control)(object)NameSTxt, new Point(120, 44));
					num = ((int)num2 * -1176550666) ^ 0x633DA7BB;
					continue;
				case 227u:
					num = ((int)num2 * -1798556846) ^ 0x1C183D50;
					continue;
				case 226u:
					UpdateDetails.smethod_16((Control)(object)PictureBox1, "PictureBox1");
					num = ((int)num2 * -125911065) ^ -1452682892;
					continue;
				case 225u:
					num = (int)(num2 * 32935647) ^ -1601282686;
					continue;
				case 224u:
					UpdateDetails.smethod_17((Control)(object)ClearBtn, new Size(133, 37));
					num = (int)((num2 * 428261653) ^ 0x5BC9ED11);
					continue;
				case 223u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)Label4);
					num = ((int)num2 * -127676609) ^ -811902820;
					continue;
				case 222u:
					num = (int)(num2 * 1587740131) ^ -370356802;
					continue;
				case 221u:
					UpdateDetails.smethod_17((Control)(object)Label7, new Size(98, 26));
					num = (int)((num2 * 1907739631) ^ 0x7C43BCA6);
					continue;
				case 220u:
					UpdateDetails.smethod_15((Control)(object)NameTxt, new Point(124, 92));
					num = (int)(num2 * 666895795) ^ -1491352262;
					continue;
				case 219u:
					SearchResultGrid = UpdateDetails.smethod_7();
					num = ((int)num2 * -203169930) ^ -1091227252;
					continue;
				case 218u:
					UpdateDetails.smethod_32(SearchResultGrid, bool_0: true);
					num = (int)((num2 * 532319131) ^ 0x442E08C4);
					continue;
				case 217u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)Label5);
					num = ((int)num2 * -1606262644) ^ -1857368657;
					continue;
				case 216u:
					UpdateDetails.smethod_16((Control)(object)GroupBox1, "GroupBox1");
					num = (int)((num2 * 206398648) ^ 0x384E536D);
					continue;
				case 215u:
					UpdateDetails.smethod_17((Control)(object)Label9, new Size(77, 28));
					UpdateDetails.smethod_18((Control)(object)Label9, 11);
					num = ((int)num2 * -796067378) ^ -991265424;
					continue;
				case 214u:
					num = ((int)num2 * -1356708430) ^ 0x621C2258;
					continue;
				case 213u:
					UpdateDetails.smethod_41((ContainerControl)(object)this, new SizeF(8f, 16f));
					UpdateDetails.smethod_42((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1500584304) ^ -752738143;
					continue;
				case 212u:
					UpdateDetails.smethod_36(AddressTxt, bool_0: true);
					UpdateDetails.smethod_16((Control)(object)AddressTxt, "AddressTxt");
					num = (int)(num2 * 207140308) ^ -73711543;
					continue;
				case 211u:
					num = (int)(num2 * 203019841) ^ -1904710505;
					continue;
				case 210u:
					UpdateDetails.smethod_18((Control)(object)Label6, 2);
					num = (int)((num2 * 1606701278) ^ 0x3CBC1C6E);
					continue;
				case 209u:
					UpdateDetails.smethod_47((Control)(object)PatientInfoBox, bool_0: false);
					num = ((int)num2 * -463112083) ^ 0x4B1B7311;
					continue;
				case 208u:
					num = ((int)num2 * -1939081958) ^ 0x9A64462;
					continue;
				case 207u:
					UpdateDetails.smethod_15((Control)(object)Label4, new Point(20, 46));
					num = (int)((num2 * 2024738156) ^ 0x358FCB74);
					continue;
				case 206u:
					UpdateDetails.smethod_16((Control)(object)DOBTxt, "DOBTxt");
					num = (int)((num2 * 51339057) ^ 0x3C631439);
					continue;
				case 205u:
					UpdateDetails.smethod_16((Control)(object)MobileTxt, "MobileTxt");
					num = ((int)num2 * -1325283283) ^ 0x2906DFCD;
					continue;
				case 204u:
					num = (int)((num2 * 1578388613) ^ 0x1BA0A0AB);
					continue;
				case 203u:
					num = ((int)num2 * -408763478) ^ -655933562;
					continue;
				case 202u:
					UpdateDetails.smethod_14((Control)(object)Label5, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1444633399) ^ -725756342;
					continue;
				case 201u:
					num = (int)(num2 * 983558411) ^ -1222105183;
					continue;
				case 200u:
					UpdateDetails.smethod_17((Control)(object)NameSTxt, new Size(237, 28));
					num = (int)(num2 * 1489288014) ^ -300774566;
					continue;
				case 199u:
					num = ((int)num2 * -2080309924) ^ -542276245;
					continue;
				case 198u:
					num = ((int)num2 * -2123484049) ^ 0x7EA87376;
					continue;
				case 197u:
					UpdateDetails.smethod_16((Control)(object)SearchResultGrid, "SearchResultGrid");
					num = ((int)num2 * -1430260011) ^ -1457481204;
					continue;
				case 196u:
					num = (int)(num2 * 450724749) ^ -2056974047;
					continue;
				case 195u:
					num = ((int)num2 * -2102379765) ^ -1012453496;
					continue;
				case 194u:
					NameSTxt = UpdateDetails.smethod_6();
					num = ((int)num2 * -831953590) ^ 0x928E6B7;
					continue;
				case 193u:
					num = (int)(num2 * 586252263) ^ -2133024444;
					continue;
				case 192u:
					UpdateDetails.smethod_20(Label1, (ContentAlignment)32);
					num = ((int)num2 * -1732495684) ^ 0x834FD01;
					continue;
				case 191u:
					num = (int)((num2 * 311858749) ^ 0x7A9FB580);
					continue;
				case 190u:
					UpdateDetails.smethod_16((Control)(object)Label5, "Label5");
					num = (int)((num2 * 376781121) ^ 0x364827F0);
					continue;
				case 189u:
					UpdateDetails.smethod_29((ButtonBase)(object)SearchBtn, bool_0: false);
					num = ((int)num2 * -621522019) ^ -475054068;
					continue;
				case 188u:
					Label1 = UpdateDetails.smethod_3();
					num = ((int)num2 * -1536472491) ^ 0x7C604EA1;
					continue;
				case 187u:
					num = (int)((num2 * 216970473) ^ 0x579FC221);
					continue;
				case 186u:
					num = (int)((num2 * 790827426) ^ 0x364698B4);
					continue;
				case 185u:
					UpdateDetails.smethod_16((Control)(object)UpdateBtn, "UpdateBtn");
					num = (int)(num2 * 782465421) ^ -1814161901;
					continue;
				case 184u:
					num = ((int)num2 * -1554279501) ^ -122696559;
					continue;
				case 183u:
					UpdateDetails.smethod_18((Control)(object)DOBTxt, 5);
					num = ((int)num2 * -883526152) ^ -1945556947;
					continue;
				case 182u:
					num = (int)((num2 * 1943898210) ^ 0x35B45E99);
					continue;
				case 181u:
					num = ((int)num2 * -63371212) ^ 0x23E46AD2;
					continue;
				case 180u:
					UpdateDetails.smethod_15((Control)(object)Label3, new Point(37, 87));
					num = ((int)num2 * -57090086) ^ -1016838941;
					continue;
				case 179u:
					UpdateDetails.smethod_15((Control)(object)GenderTxt, new Point(473, 125));
					num = ((int)num2 * -1727954316) ^ -992075690;
					continue;
				case 178u:
					UpdateDetails.smethod_10((ISupportInitialize)PictureBox1);
					num = (int)((num2 * 248089787) ^ 0x4B4F393B);
					continue;
				case 177u:
					UpdateDetails.smethod_17((Control)(object)UpdateBtn, new Size(133, 37));
					num = ((int)num2 * -527613451) ^ 0x77676080;
					continue;
				case 176u:
					UpdateDetails.smethod_17((Control)(object)Label2, new Size(77, 28));
					num = ((int)num2 * -1477893815) ^ -1031304153;
					continue;
				case 175u:
					PatientInfoBox = UpdateDetails.smethod_4();
					num = (int)(num2 * 1228682813) ^ -561434516;
					continue;
				case 174u:
					UpdateDetails.smethod_16((Control)(object)Label6, "Label6");
					num = (int)(num2 * 687719199) ^ -794199093;
					continue;
				case 173u:
					UpdateDetails.smethod_17((Control)(object)NameTxt, new Size(244, 28));
					num = ((int)num2 * -194945597) ^ 0xD1B345A;
					continue;
				case 172u:
					Label8 = UpdateDetails.smethod_3();
					num = (int)(num2 * 743241063) ^ -1956719981;
					continue;
				case 171u:
					UpdateDetails.smethod_17((Control)(object)PictureBox1, new Size(126, 122));
					num = (int)((num2 * 250029276) ^ 0x4DC631BE);
					continue;
				case 170u:
					UpdateDetails.smethod_15((Control)(object)GroupBox1, new Point(155, 150));
					num = (int)((num2 * 696479350) ^ 0x197934F8);
					continue;
				case 169u:
					UpdateDetails.smethod_39(PictureBox1, 3);
					num = (int)(num2 * 288558066) ^ -1622981482;
					continue;
				case 168u:
					UpdateDetails.smethod_12(Label1, bool_0: true);
					num = ((int)num2 * -1075558894) ^ 0x490B546E;
					continue;
				case 167u:
					UpdateDetails.smethod_18((Control)(object)PatientInfoBox, 8);
					num = (int)((num2 * 1619500011) ^ 0x44F06965);
					continue;
				case 165u:
					UpdateDetails.smethod_14((Control)(object)Label6, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					UpdateDetails.smethod_15((Control)(object)Label6, new Point(383, 132));
					num = ((int)num2 * -109684019) ^ 0xA7D1FA3;
					continue;
				case 164u:
					ClearBtn = UpdateDetails.smethod_5();
					num = ((int)num2 * -1225549572) ^ 0x4BFB647A;
					continue;
				case 163u:
					num = ((int)num2 * -1177249253) ^ -8315898;
					continue;
				case 162u:
					num = ((int)num2 * -603909575) ^ 0x681E50AA;
					continue;
				case 161u:
					UpdateDetails.smethod_18((Control)(object)MobileTxt, 12);
					num = ((int)num2 * -612310320) ^ 0xC1B1EA2;
					continue;
				case 160u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_44((Control)(object)this), (Control)(object)Label1);
					UpdateDetails.smethod_22(UpdateDetails.smethod_44((Control)(object)this), (Control)(object)PictureBox1);
					num = ((int)num2 * -2141284178) ^ 0x177A1E9B;
					continue;
				case 159u:
					num = (int)((num2 * 2090060351) ^ 0x7D9F9873);
					continue;
				case 158u:
					UpdateDetails.smethod_17((Control)(object)Label3, new Size(77, 28));
					num = (int)(num2 * 560160746) ^ -859687409;
					continue;
				case 157u:
					Label2 = UpdateDetails.smethod_3();
					num = ((int)num2 * -1242678804) ^ -1666797641;
					continue;
				case 156u:
					UpdateDetails.smethod_16((Control)(object)Label9, "Label9");
					num = ((int)num2 * -1594644132) ^ 0x3BA5ABDE;
					continue;
				case 155u:
					UpdateDetails.smethod_47((Control)(object)GroupBox1, bool_0: false);
					num = (int)(num2 * 1597046412) ^ -173949987;
					continue;
				case 154u:
					num = ((int)num2 * -1412219546) ^ 0x3429F7E0;
					continue;
				case 153u:
					num = ((int)num2 * -35589497) ^ -1464696938;
					continue;
				case 152u:
					num = (int)((num2 * 358468857) ^ 0x3A263C73);
					continue;
				case 151u:
					UpdateDetails.smethod_16((Control)(object)NameSTxt, "NameSTxt");
					num = ((int)num2 * -16374307) ^ 0x43B458AE;
					continue;
				case 150u:
					UpdateDetails.smethod_19(Label2, "Name : ");
					num = (int)((num2 * 577576695) ^ 0x7DA22E20);
					continue;
				case 149u:
					UpdateDetails.smethod_19(Label1, "Update Details ");
					num = ((int)num2 * -182994425) ^ -865751523;
					continue;
				case 148u:
					UpdateDetails.smethod_16((Control)(object)Label3, "Label3");
					num = ((int)num2 * -36991414) ^ 0x16366C12;
					continue;
				case 147u:
					UpdateDetails.smethod_48((Control)(object)GroupBox1);
					num = (int)((num2 * 2013770105) ^ 0x42DA3633);
					continue;
				case 146u:
					UpdateDetails.smethod_18((Control)(object)Label7, 3);
					num = ((int)num2 * -1077641401) ^ -1303490005;
					continue;
				case 145u:
					UpdateDetails.smethod_16((Control)(object)Label1, "Label1");
					num = ((int)num2 * -650937748) ^ 0x6C670C3B;
					continue;
				case 144u:
					num = ((int)num2 * -127259607) ^ -992638050;
					continue;
				case 143u:
					num = ((int)num2 * -1812648954) ^ 0x7052A877;
					continue;
				case 142u:
					UpdateDetails.smethod_29((ButtonBase)(object)UpdateBtn, bool_0: false);
					UpdateDetails.smethod_25((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					num = (int)(num2 * 1965446799) ^ -952766334;
					continue;
				case 141u:
					UpdateDetails.smethod_24(GroupBox1, "Search Patient");
					num = ((int)num2 * -1004036455) ^ -318361373;
					continue;
				case 140u:
					UpdateDetails.smethod_34(UpdateDetails.smethod_33(SearchResultGrid), 24);
					num = (int)(num2 * 903430429) ^ -1611912736;
					continue;
				case 139u:
					num = ((int)num2 * -1047826649) ^ 0x45BA9B5A;
					continue;
				case 138u:
					num = (int)((num2 * 1301388610) ^ 0x69C4828E);
					continue;
				case 137u:
					UpdateDetails.smethod_20(Label3, (ContentAlignment)32);
					UpdateDetails.smethod_15((Control)(object)MobileSTxt, new Point(120, 94));
					num = (int)(num2 * 652699769) ^ -1822456169;
					continue;
				case 136u:
					UpdateDetails.smethod_15((Control)(object)SearchBtn, new Point(468, 82));
					UpdateDetails.smethod_16((Control)(object)SearchBtn, "SearchBtn");
					UpdateDetails.smethod_17((Control)(object)SearchBtn, new Size(133, 37));
					num = ((int)num2 * -2072338971) ^ -1156650316;
					continue;
				case 135u:
					UpdateDetails.smethod_17((Control)(object)PIDTxt, new Size(100, 28));
					UpdateDetails.smethod_18((Control)(object)PIDTxt, 4);
					UpdateDetails.smethod_14((Control)(object)Label7, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1197210926) ^ 0x21F08E14);
					continue;
				case 134u:
					UpdateDetails.smethod_18((Control)(object)GenderTxt, 6);
					num = ((int)num2 * -1041586362) ^ 0x5E755CD6;
					continue;
				case 133u:
					UpdateDetails.smethod_20(Label2, (ContentAlignment)32);
					UpdateDetails.smethod_30(SearchResultGrid, Color.White);
					num = (int)((num2 * 1783074918) ^ 0x4F1128C5);
					continue;
				case 132u:
					UpdateDetails.smethod_17((Control)(object)Label1, new Size(250, 35));
					num = ((int)num2 * -630081703) ^ -1773364049;
					continue;
				case 131u:
					num = (int)((num2 * 1426454920) ^ 0x19F9B219);
					continue;
				case 130u:
					UpdateDetails.smethod_16((Control)(object)PIDTxt, "PIDTxt");
					UpdateDetails.smethod_35((TextBoxBase)(object)PIDTxt, bool_0: true);
					num = ((int)num2 * -403367783) ^ -49388687;
					continue;
				case 129u:
					num = (int)((num2 * 1496704464) ^ 0x47951D86);
					continue;
				case 128u:
					GroupBox1 = UpdateDetails.smethod_4();
					num = (int)(num2 * 1810065618) ^ -315196394;
					continue;
				case 127u:
					UpdateDetails.smethod_18((Control)(object)SearchBtn, 4);
					UpdateDetails.smethod_28((ButtonBase)(object)SearchBtn, "Search");
					num = ((int)num2 * -1858777215) ^ -191329557;
					continue;
				case 126u:
					UpdateDetails.smethod_14((Control)(object)ClearBtn, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					UpdateDetails.smethod_27((Control)(object)ClearBtn, UpdateDetails.smethod_26());
					UpdateDetails.smethod_15((Control)(object)ClearBtn, new Point(779, 651));
					num = ((int)num2 * -1188557444) ^ 0x22220627;
					continue;
				case 125u:
					UpdateDetails.smethod_18((Control)(object)Label8, 9);
					num = ((int)num2 * -427754012) ^ 0x5643BD2D;
					continue;
				case 124u:
					UpdateDetails.smethod_31(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					num = (int)(num2 * 2096661880) ^ -680479414;
					continue;
				case 123u:
					UpdateDetails.smethod_16((Control)(object)Label8, "Label8");
					num = (int)((num2 * 1249154559) ^ 0x392E5A14);
					continue;
				case 122u:
					UpdateDetails.smethod_17((Control)(object)Label5, new Size(68, 26));
					UpdateDetails.smethod_18((Control)(object)Label5, 1);
					num = ((int)num2 * -838189153) ^ -678123830;
					continue;
				case 121u:
					UpdateDetails.smethod_19(Label3, "Phone : ");
					num = (int)(num2 * 1196181340) ^ -254475966;
					continue;
				case 120u:
					num = (int)((num2 * 805982183) ^ 0x7277843D);
					continue;
				case 119u:
					Label3 = UpdateDetails.smethod_3();
					num = ((int)num2 * -411840363) ^ 0x301D8F5F;
					continue;
				case 118u:
					UpdateDetails.smethod_15((Control)(object)PatientInfoBox, new Point(108, 480));
					UpdateDetails.smethod_16((Control)(object)PatientInfoBox, "PatientInfoBox");
					num = ((int)num2 * -1141856404) ^ -1831561592;
					continue;
				case 117u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_44((Control)(object)this), (Control)(object)SearchResultGrid);
					UpdateDetails.smethod_22(UpdateDetails.smethod_44((Control)(object)this), (Control)(object)GroupBox1);
					num = ((int)num2 * -1780356192) ^ -2065870049;
					continue;
				case 116u:
					UpdateDetails.smethod_18((Control)(object)Label3, 3);
					num = (int)((num2 * 1780807343) ^ 0x51D0CEF4);
					continue;
				case 115u:
					UpdateDetails.smethod_15((Control)(object)SearchResultGrid, new Point(59, 295));
					num = (int)((num2 * 1471320568) ^ 0x71657DD0);
					continue;
				case 114u:
					UpdateDetails.smethod_18((Control)(object)Label1, 4);
					num = ((int)num2 * -78193730) ^ 0x300B8DE5;
					continue;
				case 113u:
					num = ((int)num2 * -675200028) ^ -1124717019;
					continue;
				case 112u:
					UpdateDetails.smethod_15((Control)(object)PIDTxt, new Point(124, 43));
					num = ((int)num2 * -1752363782) ^ 0x59395981;
					continue;
				case 111u:
					UpdateDetails.smethod_16((Control)(object)Label2, "Label2");
					num = ((int)num2 * -1090848010) ^ -1076537668;
					continue;
				case 110u:
					GenderTxt = UpdateDetails.smethod_6();
					DOBTxt = UpdateDetails.smethod_6();
					num = ((int)num2 * -310901095) ^ 0x290D14D8;
					continue;
				case 109u:
					UpdateDetails.smethod_19(Label5, "DOB :");
					UpdateDetails.smethod_14((Control)(object)Label4, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1559147884) ^ 0x1EA69C6C);
					continue;
				case 108u:
					UpdateDetails.smethod_16((Control)(object)Label7, "Label7");
					num = ((int)num2 * -1454647542) ^ -1564249314;
					continue;
				case 107u:
					UpdateDetails.smethod_14((Control)(object)UpdateBtn, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 994994122) ^ 0xCC5CAE1);
					continue;
				case 106u:
					num = (int)(num2 * 981265016) ^ -1281797083;
					continue;
				case 105u:
					num = (int)(num2 * 276278274) ^ -1710025445;
					continue;
				case 104u:
					num = (int)(num2 * 228735710) ^ -1501416370;
					continue;
				case 103u:
					UpdateDetails.smethod_18((Control)(object)NameTxt, 10);
					num = ((int)num2 * -597360705) ^ 0x7A1EFBDF;
					continue;
				case 102u:
					num = ((int)num2 * -1772424026) ^ -614674974;
					continue;
				case 101u:
					UpdateDetails.smethod_15((Control)(object)DOBTxt, new Point(457, 88));
					num = (int)((num2 * 1208821679) ^ 0x138B0C2E);
					continue;
				case 100u:
					UpdateDetails.smethod_17((Control)(object)SearchResultGrid, new Size(853, 169));
					num = ((int)num2 * -1141548380) ^ -1936750938;
					continue;
				case 99u:
					num = ((int)num2 * -189339527) ^ -1828627383;
					continue;
				case 98u:
					UpdateDetails.smethod_15((Control)(object)Label7, new Point(20, 182));
					num = ((int)num2 * -1449160124) ^ -1301343739;
					continue;
				case 97u:
					UpdateDetails.smethod_24(PatientInfoBox, "Patient Information");
					num = ((int)num2 * -1070308776) ^ 0x2491DD0B;
					continue;
				case 96u:
					UpdateDetails.smethod_35((TextBoxBase)(object)NameTxt, bool_0: true);
					num = ((int)num2 * -1896682930) ^ -1197223543;
					continue;
				case 95u:
					UpdateDetails.smethod_27((Control)(object)UpdateBtn, UpdateDetails.smethod_26());
					num = ((int)num2 * -182481625) ^ 0x5A96A67E;
					continue;
				case 94u:
					num = (int)(num2 * 1325555433) ^ -1867781212;
					continue;
				case 93u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)GroupBox1), (Control)(object)SearchBtn);
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)GroupBox1), (Control)(object)Label3);
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)GroupBox1), (Control)(object)MobileSTxt);
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)GroupBox1), (Control)(object)NameSTxt);
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)GroupBox1), (Control)(object)Label2);
					num = (int)((num2 * 1689502161) ^ 0x54D62342);
					continue;
				case 92u:
					UpdateDetails.smethod_15((Control)(object)Label8, new Point(20, 88));
					num = (int)((num2 * 346404410) ^ 0x5965337B);
					continue;
				case 91u:
					num = ((int)num2 * -1729383400) ^ -1074691443;
					continue;
				case 90u:
					UpdateDetails.smethod_17((Control)(object)PatientInfoBox, new Size(623, 292));
					num = (int)((num2 * 1349149075) ^ 0x1DF2C9BE);
					continue;
				case 89u:
					UpdateDetails.smethod_19(Label4, "PID :");
					num = (int)((num2 * 2023466488) ^ 0xD5D9032);
					continue;
				case 88u:
					UpdateDetails.smethod_17((Control)(object)Label8, new Size(77, 28));
					num = (int)((num2 * 657335216) ^ 0x5898C7D);
					continue;
				case 86u:
					Label4 = UpdateDetails.smethod_3();
					num = (int)((num2 * 1281243418) ^ 0x6A44B87A);
					continue;
				case 85u:
					num = ((int)num2 * -1997503868) ^ -1079376765;
					continue;
				case 84u:
					UpdateDetails.smethod_25((ButtonBase)(object)SearchBtn, Color.MidnightBlue);
					num = (int)(num2 * 979590622) ^ -1515312654;
					continue;
				case 83u:
					num = ((int)num2 * -2006203175) ^ 0x6ACBA79;
					continue;
				case 82u:
					UpdateDetails.smethod_15((Control)(object)Label5, new Point(383, 93));
					num = ((int)num2 * -149309586) ^ 0x4FE33DA2;
					continue;
				case 81u:
					UpdateDetails.smethod_11((Control)(object)this);
					num = (int)((num2 * 1694048621) ^ 0x60008C1D);
					continue;
				case 80u:
					num = (int)(num2 * 1114876497) ^ -1110399768;
					continue;
				case 79u:
					UpdateDetails.smethod_9((Control)(object)GroupBox1);
					num = ((int)num2 * -897143748) ^ 0x3CF41E29;
					continue;
				case 78u:
					num = (int)((num2 * 1580077657) ^ 0x78E12A40);
					continue;
				case 77u:
					UpdateDetails.smethod_35((TextBoxBase)(object)GenderTxt, bool_0: true);
					UpdateDetails.smethod_17((Control)(object)GenderTxt, new Size(131, 28));
					num = ((int)num2 * -362778332) ^ -2016104119;
					continue;
				case 76u:
					UpdateDetails.smethod_17((Control)(object)Label4, new Size(68, 25));
					num = (int)((num2 * 17259033) ^ 0x4B4A1077);
					continue;
				case 75u:
					num = ((int)num2 * -562214761) ^ 0x249AE425;
					continue;
				case 74u:
					UpdateDetails.smethod_10((ISupportInitialize)SearchResultGrid);
					num = ((int)num2 * -914643351) ^ -825971784;
					continue;
				case 73u:
					num = (int)(num2 * 1887436606) ^ -1141176570;
					continue;
				case 72u:
					MobileSTxt = UpdateDetails.smethod_6();
					num = ((int)num2 * -681301268) ^ 0x24FA268B;
					continue;
				case 71u:
					NameTxt = UpdateDetails.smethod_6();
					num = (int)(num2 * 85085891) ^ -616509760;
					continue;
				case 70u:
					PIDTxt = UpdateDetails.smethod_6();
					Label7 = UpdateDetails.smethod_3();
					num = (int)((num2 * 1813836563) ^ 0x6572EDA);
					continue;
				case 69u:
					UpdateDetails.smethod_16((Control)(object)MobileSTxt, "MobileSTxt");
					UpdateDetails.smethod_17((Control)(object)MobileSTxt, new Size(237, 28));
					num = (int)((num2 * 1516172133) ^ 0x201D54AA);
					continue;
				case 68u:
					num = (int)(num2 * 1395642971) ^ -174565166;
					continue;
				case 67u:
					num = (int)((num2 * 752535323) ^ 0xB297AFB);
					continue;
				case 66u:
					UpdateDetails.smethod_28((ButtonBase)(object)UpdateBtn, "Update ");
					num = (int)((num2 * 1132220067) ^ 0x34ECED1F);
					continue;
				case 65u:
					num = ((int)num2 * -1537626820) ^ -739113475;
					continue;
				case 64u:
					UpdateDetails.smethod_14((Control)(object)SearchBtn, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					UpdateDetails.smethod_27((Control)(object)SearchBtn, UpdateDetails.smethod_26());
					num = ((int)num2 * -560202642) ^ 0x603916C4;
					continue;
				case 63u:
					UpdateDetails.smethod_19(Label8, "Name : ");
					UpdateDetails.smethod_20(Label8, (ContentAlignment)32);
					num = (int)(num2 * 1120240641) ^ -1148168386;
					continue;
				case 62u:
					UpdateDetails.smethod_17((Control)(object)GroupBox1, new Size(623, 128));
					num = (int)(num2 * 1252693887) ^ -781752805;
					continue;
				case 61u:
					UpdateDetails.smethod_9((Control)(object)PatientInfoBox);
					num = (int)((num2 * 998387863) ^ 0x459438DD);
					continue;
				case 60u:
					num = ((int)num2 * -1909259764) ^ -1360831936;
					continue;
				case 59u:
					num = ((int)num2 * -77915941) ^ 0x563650B6;
					continue;
				case 58u:
					UpdateDetails.smethod_35((TextBoxBase)(object)DOBTxt, bool_0: true);
					num = ((int)num2 * -1017635315) ^ 0x60809CCD;
					continue;
				case 57u:
					num = ((int)num2 * -1538013294) ^ -694040229;
					continue;
				case 56u:
					UpdateDetails.smethod_45((Control)(object)this, "UpdateDetails");
					UpdateDetails.smethod_46((Control)(object)this, new Size(977, 804));
					num = (int)(num2 * 2047977198) ^ -914256228;
					continue;
				case 55u:
					num = ((int)num2 * -1374973582) ^ -1764293110;
					continue;
				case 54u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)Label8);
					num = ((int)num2 * -650697243) ^ -1509135444;
					continue;
				case 53u:
					UpdateDetails.smethod_25((ButtonBase)(object)UpdateBtn, Color.MidnightBlue);
					num = ((int)num2 * -755119721) ^ -89441730;
					continue;
				case 52u:
					UpdateDetails.smethod_15((Control)(object)UpdateBtn, new Point(779, 563));
					num = ((int)num2 * -1956039962) ^ 0x4884045B;
					continue;
				case 51u:
					PictureBox1 = UpdateDetails.smethod_8();
					num = (int)((num2 * 146536280) ^ 0x6AE1CE46);
					continue;
				case 50u:
					UpdateDetails.smethod_15((Control)(object)AddressTxt, new Point(124, 182));
					num = (int)(num2 * 774209590) ^ -1470905428;
					continue;
				case 49u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)DOBTxt);
					num = ((int)num2 * -1264443092) ^ 0x268AE9D1;
					continue;
				case 48u:
					UpdateDetails.smethod_18((Control)(object)SearchResultGrid, 7);
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)MobileTxt);
					num = (int)(num2 * 2078555304) ^ -762263697;
					continue;
				case 47u:
					UpdateDetails.smethod_16((Control)(object)ClearBtn, "ClearBtn");
					num = ((int)num2 * -163435787) ^ -1634666117;
					continue;
				case 46u:
					UpdateDetails.smethod_18((Control)(object)Label4, 0);
					num = ((int)num2 * -1560208153) ^ -1059034855;
					continue;
				case 45u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)NameTxt);
					num = ((int)num2 * -1487541309) ^ -169329384;
					continue;
				case 44u:
					num = (int)((num2 * 353256092) ^ 0x48DCAB8C);
					continue;
				case 43u:
					num = (int)((num2 * 1045201754) ^ 0x1B60BB24);
					continue;
				case 42u:
					num = (int)((num2 * 1601241591) ^ 0x14685EFC);
					continue;
				case 41u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)AddressTxt);
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)GenderTxt);
					num = (int)((num2 * 1233992089) ^ 0x3C30125F);
					continue;
				case 40u:
					UpdateDetails.smethod_17((Control)(object)AddressTxt, new Size(480, 90));
					num = ((int)num2 * -1213282607) ^ 0x1F22DE54;
					continue;
				case 39u:
					num = (int)(num2 * 123186661) ^ -1432741315;
					continue;
				case 38u:
					num = (int)((num2 * 683597287) ^ 0x16CC1971);
					continue;
				case 37u:
					num = (int)((num2 * 480023668) ^ 0x43A3A208);
					continue;
				case 36u:
					num = ((int)num2 * -1902122469) ^ -186366343;
					continue;
				case 35u:
					num = ((int)num2 * -1887022557) ^ -267320797;
					continue;
				case 34u:
					UpdateDetails.smethod_38(PictureBox1, (PictureBoxSizeMode)1);
					num = (int)((num2 * 1498158500) ^ 0x6B3CF55D);
					continue;
				case 33u:
					num = ((int)num2 * -2001721673) ^ -576464135;
					continue;
				case 32u:
					UpdateDetails.smethod_37(PictureBox1, (Image)(object)Resources.useless_pic);
					UpdateDetails.smethod_15((Control)(object)PictureBox1, new Point(260, 22));
					num = (int)((num2 * 233842123) ^ 0x36F93B61);
					continue;
				case 31u:
					num = ((int)num2 * -234740126) ^ 0x7B929242;
					continue;
				case 30u:
					UpdateDetails.smethod_49((ISupportInitialize)SearchResultGrid);
					num = ((int)num2 * -1360683410) ^ 0x25A8BFE7;
					continue;
				case 29u:
					UpdateDetails.smethod_16((Control)(object)NameTxt, "NameTxt");
					num = ((int)num2 * -1819850292) ^ -1327325653;
					continue;
				case 28u:
					UpdateDetails.smethod_43((Control)(object)this, Color.White);
					UpdateDetails.smethod_22(UpdateDetails.smethod_44((Control)(object)this), (Control)(object)ClearBtn);
					UpdateDetails.smethod_22(UpdateDetails.smethod_44((Control)(object)this), (Control)(object)UpdateBtn);
					num = (int)(num2 * 819463617) ^ -636671331;
					continue;
				case 27u:
					UpdateDetails.smethod_18((Control)(object)GroupBox1, 6);
					num = (int)((num2 * 1187290264) ^ 0x5BB2976C);
					continue;
				case 26u:
					num = (int)(num2 * 795614938) ^ -497039290;
					continue;
				case 25u:
					UpdateDetails.smethod_18((Control)(object)AddressTxt, 7);
					num = (int)(num2 * 987046543) ^ -48338515;
					continue;
				case 24u:
					AddressTxt = UpdateDetails.smethod_6();
					num = ((int)num2 * -1136320743) ^ -978916200;
					continue;
				case 23u:
					UpdateDetails.smethod_19(Label9, "Phone : ");
					num = ((int)num2 * -743100259) ^ 0x59E357A3;
					continue;
				case 22u:
					UpdateDetails.smethod_17((Control)(object)Label6, new Size(84, 26));
					num = ((int)num2 * -1687435778) ^ -1825949232;
					continue;
				case 21u:
					UpdateDetails.smethod_14((Control)(object)GroupBox1, UpdateDetails.smethod_13("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1418178547) ^ 0x49F6DD74;
					continue;
				case 20u:
					UpdateDetails.smethod_20(Label9, (ContentAlignment)32);
					num = (int)((num2 * 890737774) ^ 0x38775624);
					continue;
				case 19u:
					UpdateDetails.smethod_19(Label6, "Gender : ");
					num = ((int)num2 * -1182131552) ^ 0x6391B6C2;
					continue;
				case 18u:
					UpdateDetails.smethod_19(Label7, "Address : ");
					num = ((int)num2 * -1086927241) ^ 0x47DC43B7;
					continue;
				case 17u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)Label9);
					num = ((int)num2 * -890478436) ^ -839950659;
					continue;
				case 16u:
					UpdateDetails.smethod_18((Control)(object)MobileSTxt, 2);
					num = (int)(num2 * 264812306) ^ -1102158329;
					continue;
				case 15u:
					num = (int)(num2 * 1914960451) ^ -22134146;
					continue;
				case 14u:
					UpdateDetails.smethod_48((Control)(object)PatientInfoBox);
					UpdateDetails.smethod_49((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -1865902040) ^ -207402696;
					continue;
				case 13u:
					UpdateBtn = UpdateDetails.smethod_5();
					num = (int)((num2 * 1172829581) ^ 0x7FE49628);
					continue;
				case 12u:
					UpdateDetails.smethod_16((Control)(object)GenderTxt, "GenderTxt");
					num = ((int)num2 * -84372288) ^ -314436952;
					continue;
				case 11u:
					UpdateDetails.smethod_15((Control)(object)Label2, new Point(37, 44));
					num = (int)((num2 * 731336865) ^ 0x56A13E9E);
					continue;
				case 10u:
					UpdateDetails.smethod_17((Control)(object)MobileTxt, new Size(244, 28));
					num = ((int)num2 * -181559128) ^ -505131907;
					continue;
				case 9u:
					num = ((int)num2 * -2099740200) ^ -1940078657;
					continue;
				case 8u:
					Label6 = UpdateDetails.smethod_3();
					Label5 = UpdateDetails.smethod_3();
					num = (int)((num2 * 742649982) ^ 0x6833F5F0);
					continue;
				case 7u:
					num = ((int)num2 * -731870087) ^ 0x128155FC;
					continue;
				case 6u:
					num = ((int)num2 * -943678362) ^ -962684666;
					continue;
				case 5u:
					UpdateDetails.smethod_23(PatientInfoBox, bool_0: false);
					num = (int)((num2 * 35798412) ^ 0x530F949B);
					continue;
				case 4u:
					UpdateDetails.smethod_14((Control)(object)Label2, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1061807967) ^ -30843661;
					continue;
				case 3u:
					num = (int)(num2 * 569150993) ^ -1790390631;
					continue;
				case 2u:
					UpdateDetails.smethod_14((Control)(object)Label3, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1478563207) ^ -1648126286;
					continue;
				case 1u:
					UpdateDetails.smethod_40(PictureBox1, bool_0: false);
					num = (int)((num2 * 274353125) ^ 0x16E0DEA4);
					continue;
				case 0u:
					num = ((int)num2 * -1288774929) ^ 0x52BE121F;
					continue;
				case 87u:
					break;
				default:
					UpdateDetails.smethod_51((Control)(object)this);
					return;
				}
				break;
			}
		}
	}

	private void UpdateDetails_Load(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1152529352;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x40235F92u) % 5u)
				{
				case 4u:
					num = ((int)num2 * -421448945) ^ 0x3E551DB7;
					continue;
				case 2u:
					UpdateDetails.smethod_57(myconnection, UpdateDetails.smethod_56(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
					num = (int)((num2 * 1544267769) ^ 0x28E170E9);
					continue;
				case 1u:
					Hidedata();
					num = ((int)num2 * -730936835) ^ -293875235;
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

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected I4, but got Unknown
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected I4, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Incompatible stack heights: 0 vs 1
		//IL_0329: Incompatible stack heights: 0 vs 1
		//IL_0330: Incompatible stack heights: 0 vs 1
		Hidedata();
		OleDbDataAdapter dbDataAdapter_ = default(OleDbDataAdapter);
		DataTable dataTable_ = default(DataTable);
		bool flag = default(bool);
		while (true)
		{
			int num = -1751647232;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCEDF2A47u) % 5u)
				{
				case 1u:
					num = (int)(num2 * 994677688) ^ -1277180578;
					continue;
				case 0u:
				{
					int num6;
					int num7;
					if (!MyProject.Forms.Form1.Name_Validation(UpdateDetails.smethod_59(UpdateDetails.smethod_58(NameSTxt))) | !MyProject.Forms.Form1.Mobile_Validator(UpdateDetails.smethod_59(UpdateDetails.smethod_58(MobileSTxt))))
					{
						num6 = -190199997;
						num7 = -190199997;
					}
					else
					{
						num6 = -871614198;
						num7 = -871614198;
					}
					num = num6 ^ (int)(num2 * 1517687955);
					continue;
				}
				case 4u:
					break;
				case 2u:
					UpdateDetails.smethod_60("No Results Found");
					return;
				default:
					try
					{
						while (true)
						{
							int num3 = -367650707;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xCEDF2A47u) % 14u)
								{
								case 13u:
									dbDataAdapter_ = UpdateDetails.smethod_62();
									num3 = (int)((num2 * 974728670) ^ 0x5B26BD75);
									continue;
								case 12u:
									UpdateDetails.smethod_71(myconnection);
									num3 = (int)((num2 * 1339471527) ^ 0x78B6B34F);
									continue;
								case 11u:
									dbDataAdapter_ = UpdateDetails.smethod_65(UpdateDetails.smethod_64(new string[5]
									{
										"Select * from Patient where Name like '%",
										UpdateDetails.smethod_58(NameSTxt),
										"%'  And   Mobile like '%",
										UpdateDetails.smethod_58(MobileSTxt),
										"%' "
									}), myconnection);
									num3 = ((int)num2 * -1821784256) ^ 0x4162DF2D;
									continue;
								case 10u:
									UpdateDetails.smethod_70("Not Found.", "Result");
									num3 = ((int)num2 * -1952613586) ^ 0x14EF26B0;
									continue;
								case 9u:
									num3 = (int)(num2 * 551545630) ^ -842808651;
									continue;
								case 8u:
									dataTable_ = UpdateDetails.smethod_61();
									num3 = ((int)num2 * -75895957) ^ 0x689BAAB6;
									continue;
								case 6u:
									UpdateDetails.smethod_68(SearchResultGrid, (object)UpdateDetails.smethod_67(dataTable_));
									flag = UpdateDetails.smethod_69(SearchResultGrid) == 1;
									num3 = ((int)num2 * -1973191026) ^ 0x765E80EC;
									continue;
								case 5u:
								{
									int num4;
									int num5;
									if (!flag)
									{
										num4 = 100928766;
										num5 = 100928766;
									}
									else
									{
										num4 = 1934815681;
										num5 = 1934815681;
									}
									num3 = num4 ^ ((int)num2 * -934241590);
									continue;
								}
								case 2u:
									UpdateDetails.smethod_66((DbDataAdapter)(object)dbDataAdapter_, dataTable_);
									num3 = (int)(num2 * 1647646526) ^ -1319368893;
									continue;
								case 1u:
									UpdateDetails.smethod_72((Control)(object)SearchResultGrid);
									num3 = -2061051422;
									continue;
								case 0u:
									UpdateDetails.smethod_63(myconnection);
									num3 = ((int)num2 * -1391614226) ^ 0x235DD380;
									continue;
								case 3u:
									break;
								default:
									mobile = UpdateDetails.smethod_58(MobileSTxt);
									name_search = UpdateDetails.smethod_58(NameSTxt);
									return;
								case 7u:
									UpdateDetails.smethod_71(myconnection);
									return;
								}
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						UpdateDetails.smethod_73(exception_);
						while (true)
						{
							_ = -1420846995;
							while (true)
							{
								_003F val = /*Error near IL_02d4: Stack underflow*/^ -824235449;
								num2 = (uint)(int)val;
								switch (val % 4)
								{
								default:
									return;
								case 3:
									UpdateDetails.smethod_60("Incorrect Credentials");
									UpdateDetails.smethod_74();
									_ = (num2 * 709752969) ^ 0xA8381B39u;
									continue;
								case 2:
									UpdateDetails.smethod_71(myconnection);
									_ = (num2 * 1491787055) ^ 0x14582FB2;
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
				break;
			}
		}
	}

	private void UpdateBtn_Click(object sender, EventArgs e)
	{
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		string string_ = UpdateDetails.smethod_64(new string[7]
		{
			"Update [Patient] set [Mobile]='",
			UpdateDetails.smethod_58(MobileTxt),
			"',[Address]='",
			UpdateDetails.smethod_58(AddressTxt),
			"'where [PID] = ",
			UpdateDetails.smethod_58(PIDTxt),
			" "
		});
		bool flag = !(MyProject.Forms.Form1.Mobile_Validator(UpdateDetails.smethod_59(UpdateDetails.smethod_58(MobileTxt))) & (UpdateDetails.smethod_75(UpdateDetails.smethod_58(AddressTxt), "", bool_0: false) != 0));
		while (true)
		{
			int num = -945834228;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9A591A86u) % 6u)
				{
				case 4u:
					num = -198134150;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 901579721;
						num5 = 901579721;
					}
					else
					{
						num4 = 1810814288;
						num5 = 1810814288;
					}
					num = num4 ^ ((int)num2 * -1732116378);
					continue;
				}
				case 0u:
					UpdateDetails.smethod_63(myconnection);
					num = (int)((num2 * 409904814) ^ 0x5641FECD);
					continue;
				case 3u:
					break;
				default:
				{
					OleDbCommand val = UpdateDetails.smethod_76(string_, myconnection);
					try
					{
						UpdateDetails.smethod_77(val);
						while (true)
						{
							int num3 = -350942388;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x9A591A86u) % 5u)
								{
								case 4u:
									UpdateDetails.smethod_60("Updated Sucessfully");
									UpdateDetails.smethod_71(myconnection);
									num3 = ((int)num2 * -1762427251) ^ -1549101784;
									continue;
								case 3u:
									UpdateDetails.smethod_78((Component)(object)val);
									num3 = (int)(num2 * 14688986) ^ -1461463714;
									continue;
								case 0u:
									updatedatagrid();
									num3 = (int)(num2 * 1654201914) ^ -569618750;
									continue;
								default:
									return;
								case 2u:
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
						UpdateDetails.smethod_73(exception_);
						UpdateDetails.smethod_71(myconnection);
						UpdateDetails.smethod_74();
						return;
					}
				}
				case 5u:
					UpdateDetails.smethod_60("Enter Valid Phone number");
					return;
				}
				break;
			}
		}
	}

	private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected I4, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected I4, but got Unknown
		//IL_02e7: Incompatible stack heights: 0 vs 1
		//IL_02ee: Incompatible stack heights: 0 vs 1
		bool flag = (checked(UpdateDetails.smethod_79(e) + 1) == UpdateDetails.smethod_69(SearchResultGrid)) | (UpdateDetails.smethod_79(e) == -1);
		DataGridViewRow dataGridViewRow_ = default(DataGridViewRow);
		while (true)
		{
			int num = 1333851141;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x176A2083u) % 5u)
				{
				case 4u:
					num = 459980044;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1113216427;
						num5 = -1113216427;
					}
					else
					{
						num4 = -1808701343;
						num5 = -1808701343;
					}
					num = num4 ^ (int)(num2 * 1292478060);
					continue;
				}
				case 0u:
					break;
				default:
					selectrow = UpdateDetails.smethod_79(e);
					try
					{
						while (true)
						{
							int num3 = 2145186200;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x176A2083u) % 14u)
								{
								case 13u:
									num3 = (int)(num2 * 1525312591) ^ -67131142;
									continue;
								case 12u:
									num3 = ((int)num2 * -2099600166) ^ -2077259157;
									continue;
								case 11u:
									num3 = (int)((num2 * 964320730) ^ 0x5B2CECEA);
									continue;
								case 10u:
									UpdateDetails.smethod_72((Control)(object)ClearBtn);
									num3 = (int)((num2 * 441326876) ^ 0x44DD923D);
									continue;
								case 9u:
									UpdateDetails.smethod_72((Control)(object)UpdateBtn);
									num3 = (int)((num2 * 1801194334) ^ 0x302931F9);
									continue;
								case 8u:
									selectrow = UpdateDetails.smethod_79(e);
									num3 = (int)(num2 * 202345300) ^ -1818865216;
									continue;
								case 6u:
									dataGridViewRow_ = UpdateDetails.smethod_83(UpdateDetails.smethod_82(SearchResultGrid), selectrow);
									UpdateDetails.smethod_88(PIDTxt, UpdateDetails.smethod_87(UpdateDetails.smethod_86(UpdateDetails.smethod_85(UpdateDetails.smethod_84(dataGridViewRow_), 0))));
									num3 = ((int)num2 * -199124771) ^ -1337352596;
									continue;
								case 4u:
									UpdateDetails.smethod_88(DOBTxt, UpdateDetails.smethod_89(UpdateDetails.smethod_86(UpdateDetails.smethod_85(UpdateDetails.smethod_84(dataGridViewRow_), 2))));
									UpdateDetails.smethod_88(MobileTxt, UpdateDetails.smethod_87(UpdateDetails.smethod_86(UpdateDetails.smethod_85(UpdateDetails.smethod_84(dataGridViewRow_), 4))));
									UpdateDetails.smethod_88(GenderTxt, UpdateDetails.smethod_87(UpdateDetails.smethod_86(UpdateDetails.smethod_85(UpdateDetails.smethod_84(dataGridViewRow_), 3))));
									num3 = ((int)num2 * -883347041) ^ -1589842884;
									continue;
								case 3u:
									dataGridViewRow_ = UpdateDetails.smethod_81();
									num3 = ((int)num2 * -1816901223) ^ -2092248778;
									continue;
								case 2u:
									UpdateDetails.smethod_88(NameTxt, UpdateDetails.smethod_87(UpdateDetails.smethod_86(UpdateDetails.smethod_85(UpdateDetails.smethod_84(dataGridViewRow_), 1))));
									num3 = (int)((num2 * 1048149113) ^ 0x42FAE691);
									continue;
								case 1u:
									UpdateDetails.smethod_80((Control)(object)PatientInfoBox, bool_0: true);
									num3 = ((int)num2 * -1885744663) ^ -1430983793;
									continue;
								case 0u:
									num3 = (int)((num2 * 984093303) ^ 0x4754FB8F);
									continue;
								case 5u:
									break;
								default:
									UpdateDetails.smethod_88(AddressTxt, UpdateDetails.smethod_87(UpdateDetails.smethod_86(UpdateDetails.smethod_85(UpdateDetails.smethod_84(dataGridViewRow_), 5))));
									return;
								}
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						UpdateDetails.smethod_73(exception_);
						while (true)
						{
							_ = 137410701;
							while (true)
							{
								_003F val = /*Error near IL_02c3: Stack underflow*/^ 0x176A2083;
								num2 = (uint)(int)val;
								switch (val % 3)
								{
								case 2:
									_ = ((int)num2 * -2062983951) ^ -860668655;
									continue;
								case 0:
									break;
								default:
									UpdateDetails.smethod_74();
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

	private void Hidedata()
	{
		while (true)
		{
			int num = -1459436670;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAC5DD8E6u) % 6u)
				{
				case 5u:
					num = ((int)num2 * -1889987956) ^ -1397737261;
					continue;
				case 4u:
					UpdateDetails.smethod_90((Control)(object)UpdateBtn);
					num = ((int)num2 * -4672243) ^ -326832945;
					continue;
				case 3u:
					UpdateDetails.smethod_90((Control)(object)SearchResultGrid);
					num = (int)((num2 * 667966066) ^ 0x52948F24);
					continue;
				case 2u:
					UpdateDetails.smethod_80((Control)(object)PatientInfoBox, bool_0: false);
					num = (int)((num2 * 368737311) ^ 0x3B71F0EB);
					continue;
				case 0u:
					break;
				default:
					UpdateDetails.smethod_90((Control)(object)ClearBtn);
					return;
				}
				break;
			}
		}
	}

	private void updatedatagrid()
	{
		DataGridViewRow dataGridViewRow_ = default(DataGridViewRow);
		while (true)
		{
			int num = -762357230;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF970C859u) % 9u)
				{
				case 8u:
					dataGridViewRow_ = UpdateDetails.smethod_83(UpdateDetails.smethod_82(SearchResultGrid), selectrow);
					num = ((int)num2 * -655014393) ^ -2004201544;
					continue;
				case 6u:
					UpdateDetails.smethod_91(UpdateDetails.smethod_85(UpdateDetails.smethod_84(dataGridViewRow_), 4), (object)UpdateDetails.smethod_58(MobileTxt));
					num = (int)(num2 * 2104173572) ^ -1132747352;
					continue;
				case 4u:
					UpdateDetails.smethod_91(UpdateDetails.smethod_85(UpdateDetails.smethod_84(dataGridViewRow_), 2), (object)UpdateDetails.smethod_58(DOBTxt));
					num = ((int)num2 * -552451807) ^ -644011926;
					continue;
				case 3u:
					dataGridViewRow_ = UpdateDetails.smethod_81();
					num = ((int)num2 * -1933497329) ^ 0x7A54A8BB;
					continue;
				case 2u:
					num = (int)(num2 * 1194427237) ^ -166946104;
					continue;
				case 1u:
					num = (int)((num2 * 876065925) ^ 0x2EC090EB);
					continue;
				case 0u:
					UpdateDetails.smethod_91(UpdateDetails.smethod_85(UpdateDetails.smethod_84(dataGridViewRow_), 5), (object)UpdateDetails.smethod_58(AddressTxt));
					num = ((int)num2 * -1146999984) ^ -1347320738;
					continue;
				default:
					return;
				case 7u:
					break;
				case 5u:
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
			int num = -2092635529;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC64C4340u) % 12u)
				{
				case 11u:
					num = (int)(num2 * 1680529765) ^ -1572496897;
					continue;
				case 10u:
					UpdateDetails.smethod_92((TextBoxBase)(object)DOBTxt);
					num = ((int)num2 * -562798215) ^ -347368710;
					continue;
				case 8u:
					UpdateDetails.smethod_92((TextBoxBase)(object)MobileTxt);
					num = ((int)num2 * -583707335) ^ 0x24CC85C9;
					continue;
				case 7u:
					UpdateDetails.smethod_92((TextBoxBase)(object)PIDTxt);
					num = ((int)num2 * -64617768) ^ 0x3BFED987;
					continue;
				case 6u:
					num = ((int)num2 * -596486197) ^ -706942673;
					continue;
				case 5u:
					num = ((int)num2 * -1933394844) ^ 0x1EAE9159;
					continue;
				case 4u:
					num = (int)(num2 * 1215797899) ^ -204591800;
					continue;
				case 3u:
					UpdateDetails.smethod_92((TextBoxBase)(object)AddressTxt);
					num = ((int)num2 * -715725503) ^ -959530331;
					continue;
				case 1u:
					UpdateDetails.smethod_92((TextBoxBase)(object)GenderTxt);
					num = ((int)num2 * -1757173821) ^ -550136392;
					continue;
				case 0u:
					UpdateDetails.smethod_92((TextBoxBase)(object)NameTxt);
					num = ((int)num2 * -155746949) ^ 0x1CED7E5A;
					continue;
				default:
					return;
				case 2u:
					break;
				case 9u:
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

	static PictureBox smethod_8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PictureBox();
	}

	static void smethod_9(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_10(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_11(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_12(Label label_0, bool bool_0)
	{
		label_0.set_AutoSize(bool_0);
	}

	static Font smethod_13(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_14(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_15(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_16(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_17(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_18(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_19(Label label_0, string string_0)
	{
		label_0.set_Text(string_0);
	}

	static void smethod_20(Label label_0, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_TextAlign(contentAlignment_0);
	}

	static ControlCollection smethod_21(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_22(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_23(GroupBox groupBox_0, bool bool_0)
	{
		groupBox_0.set_TabStop(bool_0);
	}

	static void smethod_24(GroupBox groupBox_0, string string_0)
	{
		groupBox_0.set_Text(string_0);
	}

	static void smethod_25(ButtonBase buttonBase_0, Color color_0)
	{
		buttonBase_0.set_BackColor(color_0);
	}

	static Color smethod_26()
	{
		return SystemColors.ButtonHighlight;
	}

	static void smethod_27(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
	}

	static void smethod_28(ButtonBase buttonBase_0, string string_0)
	{
		buttonBase_0.set_Text(string_0);
	}

	static void smethod_29(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_30(DataGridView dataGridView_0, Color color_0)
	{
		dataGridView_0.set_BackgroundColor(color_0);
	}

	static void smethod_31(DataGridView dataGridView_0, DataGridViewColumnHeadersHeightSizeMode dataGridViewColumnHeadersHeightSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		dataGridView_0.set_ColumnHeadersHeightSizeMode(dataGridViewColumnHeadersHeightSizeMode_0);
	}

	static void smethod_32(DataGridView dataGridView_0, bool bool_0)
	{
		dataGridView_0.set_ReadOnly(bool_0);
	}

	static DataGridViewRow smethod_33(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_RowTemplate();
	}

	static void smethod_34(DataGridViewRow dataGridViewRow_0, int int_0)
	{
		dataGridViewRow_0.set_Height(int_0);
	}

	static void smethod_35(TextBoxBase textBoxBase_0, bool bool_0)
	{
		textBoxBase_0.set_ReadOnly(bool_0);
	}

	static void smethod_36(TextBox textBox_0, bool bool_0)
	{
		textBox_0.set_Multiline(bool_0);
	}

	static void smethod_37(PictureBox pictureBox_0, Image image_0)
	{
		pictureBox_0.set_Image(image_0);
	}

	static void smethod_38(PictureBox pictureBox_0, PictureBoxSizeMode pictureBoxSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		pictureBox_0.set_SizeMode(pictureBoxSizeMode_0);
	}

	static void smethod_39(PictureBox pictureBox_0, int int_0)
	{
		pictureBox_0.set_TabIndex(int_0);
	}

	static void smethod_40(PictureBox pictureBox_0, bool bool_0)
	{
		pictureBox_0.set_TabStop(bool_0);
	}

	static void smethod_41(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_42(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_43(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static ControlCollection smethod_44(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_45(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_46(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_47(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_48(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_49(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_50(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_51(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_52(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_53(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_54(DataGridView dataGridView_0, DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler_0)
	{
		dataGridView_0.remove_CellMouseClick(dataGridViewCellMouseEventHandler_0);
	}

	static void smethod_55(DataGridView dataGridView_0, DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler_0)
	{
		dataGridView_0.add_CellMouseClick(dataGridViewCellMouseEventHandler_0);
	}

	static string smethod_56(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_57(OleDbConnection oleDbConnection_0, string string_0)
	{
		oleDbConnection_0.set_ConnectionString(string_0);
	}

	static string smethod_58(TextBox textBox_0)
	{
		return textBox_0.get_Text();
	}

	static string smethod_59(string string_0)
	{
		return string_0.ToLower();
	}

	static DialogResult smethod_60(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}

	static DataTable smethod_61()
	{
		return new DataTable();
	}

	static OleDbDataAdapter smethod_62()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new OleDbDataAdapter();
	}

	static void smethod_63(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Open();
	}

	static string smethod_64(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static OleDbDataAdapter smethod_65(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbDataAdapter(string_0, oleDbConnection_0);
	}

	static int smethod_66(DbDataAdapter dbDataAdapter_0, DataTable dataTable_0)
	{
		return dbDataAdapter_0.Fill(dataTable_0);
	}

	static DataView smethod_67(DataTable dataTable_0)
	{
		return dataTable_0.DefaultView;
	}

	static void smethod_68(DataGridView dataGridView_0, object object_0)
	{
		dataGridView_0.set_DataSource(object_0);
	}

	static int smethod_69(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_RowCount();
	}

	static DialogResult smethod_70(string string_0, string string_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0, string_1);
	}

	static void smethod_71(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Close();
	}

	static void smethod_72(Control control_0)
	{
		control_0.Show();
	}

	static void smethod_73(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_74()
	{
		ProjectData.ClearProjectError();
	}

	static int smethod_75(string string_0, string string_1, bool bool_0)
	{
		return Operators.CompareString(string_0, string_1, bool_0);
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

	static int smethod_79(DataGridViewCellMouseEventArgs dataGridViewCellMouseEventArgs_0)
	{
		return dataGridViewCellMouseEventArgs_0.get_RowIndex();
	}

	static void smethod_80(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static DataGridViewRow smethod_81()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DataGridViewRow();
	}

	static DataGridViewRowCollection smethod_82(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_Rows();
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
		return object_0.ToString();
	}

	static void smethod_88(TextBox textBox_0, string string_0)
	{
		textBox_0.set_Text(string_0);
	}

	static string smethod_89(object object_0)
	{
		return Conversions.ToString(object_0);
	}

	static void smethod_90(Control control_0)
	{
		control_0.Hide();
	}

	static void smethod_91(DataGridViewCell dataGridViewCell_0, object object_0)
	{
		dataGridViewCell_0.set_Value(object_0);
	}

	static void smethod_92(TextBoxBase textBoxBase_0)
	{
		textBoxBase_0.Clear();
	}
}
