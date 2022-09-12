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
				goto IL_0056;
			}
			goto IL_00b4;
			IL_00b4:
			_SearchBtn = value;
			int num = 1241368692;
			goto IL_0087;
			IL_0087:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x14DD7CDFu) % 7u)
				{
				case 6u:
				{
					int num3;
					int num4;
					if (searchBtn != null)
					{
						num3 = -66863792;
						num4 = -66863792;
					}
					else
					{
						num3 = -2063187381;
						num4 = -2063187381;
					}
					num = num3 ^ ((int)num2 * -1219596723);
					continue;
				}
				case 5u:
					searchBtn = _SearchBtn;
					num = (int)(num2 * 1369390310) ^ -706223712;
					continue;
				case 4u:
					break;
				case 3u:
					SearchReciever_Admin.smethod_55((Control)(object)searchBtn, eventHandler_);
					num = ((int)num2 * -330154013) ^ -1968708336;
					continue;
				case 1u:
					SearchReciever_Admin.smethod_54((Control)(object)searchBtn, eventHandler_);
					num = (int)(num2 * 447113041) ^ -444731572;
					continue;
				default:
					return;
				case 0u:
					goto IL_00b4;
				case 2u:
					return;
				}
				break;
			}
			goto IL_0056;
			IL_0056:
			num = 1175041567;
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
			DataGridView searchResultGrid = _SearchResultGrid;
			while (true)
			{
				int num = 719553637;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x62F1A95Au) % 7u)
					{
					case 6u:
						_SearchResultGrid = value;
						searchResultGrid = _SearchResultGrid;
						num = 2039454233;
						continue;
					case 4u:
					{
						int num5;
						int num6;
						if (searchResultGrid == null)
						{
							num5 = 1401271775;
							num6 = 1401271775;
						}
						else
						{
							num5 = 1539416211;
							num6 = 1539416211;
						}
						num = num5 ^ ((int)num2 * -1720347510);
						continue;
					}
					case 2u:
						SearchReciever_Admin.smethod_57(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = ((int)num2 * -1157394144) ^ -306435551;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (searchResultGrid == null)
						{
							num3 = 811678063;
							num4 = 811678063;
						}
						else
						{
							num3 = 985870564;
							num4 = 985870564;
						}
						num = num3 ^ ((int)num2 * -1209745567);
						continue;
					}
					case 0u:
						SearchReciever_Admin.smethod_56(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = (int)(num2 * 1978178074) ^ -1587845270;
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
			Button deleteBtn = _DeleteBtn;
			while (true)
			{
				int num = 698616925;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3B2A3967u) % 7u)
					{
					case 6u:
						SearchReciever_Admin.smethod_55((Control)(object)deleteBtn, eventHandler_);
						num = (int)((num2 * 1303004506) ^ 0x61647039);
						continue;
					case 5u:
					{
						int num5;
						int num6;
						if (deleteBtn == null)
						{
							num5 = -2054921143;
							num6 = -2054921143;
						}
						else
						{
							num5 = -954961045;
							num6 = -954961045;
						}
						num = num5 ^ (int)(num2 * 1790625643);
						continue;
					}
					case 4u:
						SearchReciever_Admin.smethod_54((Control)(object)deleteBtn, eventHandler_);
						num = ((int)num2 * -326837453) ^ 0x47CBCD81;
						continue;
					case 2u:
					{
						deleteBtn = _DeleteBtn;
						int num3;
						int num4;
						if (deleteBtn == null)
						{
							num3 = -1373914347;
							num4 = -1373914347;
						}
						else
						{
							num3 = -1214915158;
							num4 = -1214915158;
						}
						num = num3 ^ (int)(num2 * 1270031947);
						continue;
					}
					case 0u:
						_DeleteBtn = value;
						num = 117216329;
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
				int num = -407847201;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA85ABDB2u) % 7u)
					{
					case 6u:
					{
						clearBtn = _ClearBtn;
						int num5;
						int num6;
						if (clearBtn != null)
						{
							num5 = 1269208658;
							num6 = 1269208658;
						}
						else
						{
							num5 = 1242626876;
							num6 = 1242626876;
						}
						num = num5 ^ (int)(num2 * 695705501);
						continue;
					}
					case 5u:
						_ClearBtn = value;
						num = -1227926758;
						continue;
					case 4u:
						SearchReciever_Admin.smethod_54((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -1508949015) ^ 0x18E171A4;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (clearBtn == null)
						{
							num3 = -889612605;
							num4 = -889612605;
						}
						else
						{
							num3 = -412589587;
							num4 = -412589587;
						}
						num = num3 ^ (int)(num2 * 499548206);
						continue;
					}
					case 1u:
						SearchReciever_Admin.smethod_55((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -1914657950) ^ 0x4D69C2E4;
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
				int num = -814877362;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBA5ED0A7u) % 8u)
					{
					case 6u:
						SearchReciever_Admin.smethod_55((Control)(object)updateBtn, eventHandler_);
						num = ((int)num2 * -357639621) ^ -1921311910;
						continue;
					case 5u:
						SearchReciever_Admin.smethod_54((Control)(object)updateBtn, eventHandler_);
						num = ((int)num2 * -316102433) ^ 0x397BCD0C;
						continue;
					case 4u:
					{
						int num5;
						int num6;
						if (updateBtn == null)
						{
							num5 = 1288513536;
							num6 = 1288513536;
						}
						else
						{
							num5 = 948743097;
							num6 = 948743097;
						}
						num = num5 ^ ((int)num2 * -1603708254);
						continue;
					}
					case 3u:
					{
						int num3;
						int num4;
						if (updateBtn == null)
						{
							num3 = 1751072646;
							num4 = 1751072646;
						}
						else
						{
							num3 = 22848371;
							num4 = 22848371;
						}
						num = num3 ^ (int)(num2 * 1119131483);
						continue;
					}
					case 1u:
						updateBtn = _UpdateBtn;
						num = (int)(num2 * 122102522) ^ -1169490490;
						continue;
					case 0u:
						_UpdateBtn = value;
						updateBtn = _UpdateBtn;
						num = -894464013;
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
		while (true)
		{
			int num = -110124546;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x92FA2BADu) % 4u)
				{
				case 3u:
					num = (int)(num2 * 1984936909) ^ -235252562;
					continue;
				case 0u:
					SearchReciever_Admin.smethod_0((UserControl)(object)this, (EventHandler)SearchDonor_Admin_Load);
					num = ((int)num2 * -719583881) ^ -1388885552;
					continue;
				case 2u:
					break;
				default:
					myconnection = SearchReciever_Admin.smethod_1();
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
			while (true)
			{
				int num = 314341045;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x39DA41F1u) % 8u)
					{
					case 7u:
						if (components != null)
						{
							num = 278361887;
							num3 = 278361887;
							continue;
						}
						goto IL_001e;
					case 6u:
						SearchReciever_Admin.smethod_2((IDisposable)components);
						num = (int)(num2 * 1765481114) ^ -670646650;
						continue;
					case 4u:
						if (disposing)
						{
							num = ((int)num2 * -1163244011) ^ -454398646;
							continue;
						}
						goto IL_001e;
					case 3u:
						num = (int)(num2 * 955797717) ^ -1180339356;
						continue;
					case 2u:
						num = ((int)num2 * -458134709) ^ -39728050;
						continue;
					case 1u:
						num = 1622181745;
						continue;
					default:
						return;
					case 5u:
						break;
					case 0u:
						return;
						IL_001e:
						num = 899741368;
						num3 = 899741368;
						continue;
					}
					break;
				}
			}
		}
		finally
		{
			((ContainerControl)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		while (true)
		{
			int num = -1321090016;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA3AA91C5u) % 316u)
				{
				case 315u:
					num = ((int)num2 * -1480774802) ^ -1242735410;
					continue;
				case 314u:
					num = ((int)num2 * -1555405033) ^ -1715062777;
					continue;
				case 313u:
					SearchReciever_Admin.smethod_23(Label12, "Quantity : ");
					SearchReciever_Admin.smethod_14((Control)(object)IDTxt, new Point(117, 36));
					num = (int)(num2 * 1850238748) ^ -910079535;
					continue;
				case 312u:
					num = (int)((num2 * 1593053624) ^ 0x5542070B);
					continue;
				case 311u:
					SearchReciever_Admin.smethod_16((Control)(object)NameSTxt, new Size(237, 28));
					num = (int)((num2 * 630155741) ^ 0x24EF70CD);
					continue;
				case 310u:
					SearchReciever_Admin.smethod_51((Control)(object)GroupBox1, bool_0: false);
					num = ((int)num2 * -499115267) ^ -586980018;
					continue;
				case 309u:
					Label5 = SearchReciever_Admin.smethod_4();
					num = ((int)num2 * -1430184616) ^ 0x5BE0227E;
					continue;
				case 308u:
					SearchReciever_Admin.smethod_16((Control)(object)Label8, new Size(77, 28));
					num = ((int)num2 * -976424444) ^ -49512868;
					continue;
				case 307u:
					MobileSTxt = SearchReciever_Admin.smethod_7();
					num = (int)((num2 * 735336313) ^ 0x45AC0EEF);
					continue;
				case 306u:
					SearchReciever_Admin.smethod_49((Control)(object)this, new Size(977, 804));
					num = (int)(num2 * 189703546) ^ -505615694;
					continue;
				case 305u:
					SearchReciever_Admin.smethod_15((Control)(object)MobileSTxt, "MobileSTxt");
					SearchReciever_Admin.smethod_16((Control)(object)MobileSTxt, new Size(237, 28));
					num = (int)(num2 * 804190052) ^ -806966837;
					continue;
				case 304u:
					SearchReciever_Admin.smethod_32((ButtonBase)(object)ClearBtn, bool_0: false);
					num = (int)(num2 * 1478305254) ^ -2076144049;
					continue;
				case 303u:
					GenderTxt = SearchReciever_Admin.smethod_9();
					num = (int)(num2 * 1510114740) ^ -1128420609;
					continue;
				case 302u:
					SearchReciever_Admin.smethod_14((Control)(object)DeleteBtn, new Point(808, 584));
					SearchReciever_Admin.smethod_15((Control)(object)DeleteBtn, "DeleteBtn");
					num = ((int)num2 * -115302539) ^ -674758220;
					continue;
				case 301u:
					SearchReciever_Admin.smethod_24(Label9, (ContentAlignment)32);
					num = ((int)num2 * -1864389193) ^ -657253401;
					continue;
				case 300u:
					Label9 = SearchReciever_Admin.smethod_4();
					num = (int)((num2 * 1214551631) ^ 0x1FC5734A);
					continue;
				case 299u:
					num = (int)(num2 * 1235763966) ^ -740217722;
					continue;
				case 298u:
					num = ((int)num2 * -1541670699) ^ 0x20AC9BDF;
					continue;
				case 297u:
					num = ((int)num2 * -559973276) ^ 0x4C62E68A;
					continue;
				case 296u:
					SearchReciever_Admin.smethod_22((Control)(object)Label2, 0);
					num = ((int)num2 * -1085676134) ^ 0x138F21D8;
					continue;
				case 295u:
					SearchReciever_Admin.smethod_22((Control)(object)MobileSTxt, 2);
					SearchReciever_Admin.smethod_14((Control)(object)NameSTxt, new Point(120, 44));
					num = ((int)num2 * -702305442) ^ -649435265;
					continue;
				case 294u:
					SearchReciever_Admin.smethod_30((Control)(object)DeleteBtn, Color.White);
					num = (int)(num2 * 537358733) ^ -995980227;
					continue;
				case 293u:
					SearchReciever_Admin.smethod_15((Control)(object)DOBTxt, "DOBTxt");
					num = ((int)num2 * -1094214041) ^ 0x6D75C7E7;
					continue;
				case 292u:
					SearchReciever_Admin.smethod_16((Control)(object)IDTxt, new Size(204, 28));
					num = (int)((num2 * 1088806047) ^ 0x5586E2E2);
					continue;
				case 291u:
					num = ((int)num2 * -126587516) ^ -649982863;
					continue;
				case 290u:
					num = ((int)num2 * -1657658746) ^ 0x513C5406;
					continue;
				case 289u:
					num = ((int)num2 * -1864385670) ^ -1266846348;
					continue;
				case 288u:
					SearchReciever_Admin.smethod_31((ButtonBase)(object)SearchBtn, "Search");
					num = ((int)num2 * -15350031) ^ 0x74D57203;
					continue;
				case 287u:
					num = (int)((num2 * 1879820990) ^ 0x6C6EED63);
					continue;
				case 286u:
					SearchReciever_Admin.smethod_34(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					num = (int)(num2 * 453500658) ^ -945595307;
					continue;
				case 285u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)NameSTxt);
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)Label2);
					num = ((int)num2 * -2007153208) ^ 0x1F4C56BA;
					continue;
				case 284u:
					SearchReciever_Admin.smethod_15((Control)(object)Label12, "Label12");
					num = (int)(num2 * 87325346) ^ -360060095;
					continue;
				case 283u:
					Label10 = SearchReciever_Admin.smethod_4();
					num = ((int)num2 * -1197579619) ^ -251311967;
					continue;
				case 282u:
					num = ((int)num2 * -963399106) ^ 0x60F300A8;
					continue;
				case 281u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)Label5);
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)Label10);
					num = ((int)num2 * -2001816083) ^ -2005320358;
					continue;
				case 280u:
					num = ((int)num2 * -530752497) ^ 0x7A6A2EEC;
					continue;
				case 279u:
					num = (int)((num2 * 404015763) ^ 0x57AF4025);
					continue;
				case 278u:
					SearchReciever_Admin.smethod_42((TextBoxBase)(object)DateRecievedTxt, bool_0: true);
					num = (int)((num2 * 1030207937) ^ 0x6563D225);
					continue;
				case 277u:
					SearchReciever_Admin.smethod_14((Control)(object)NameTxt, new Point(117, 77));
					SearchReciever_Admin.smethod_15((Control)(object)NameTxt, "NameTxt");
					num = ((int)num2 * -1460558071) ^ -1792301472;
					continue;
				case 276u:
					SearchReciever_Admin.smethod_22((Control)(object)QuantityTxt, 19);
					num = (int)(num2 * 2052710757) ^ -1001017550;
					continue;
				case 275u:
					SearchReciever_Admin.smethod_14((Control)(object)Label4, new Point(388, 164));
					num = (int)(num2 * 1253331722) ^ -1725035262;
					continue;
				case 274u:
					SearchReciever_Admin.smethod_48((Control)(object)this, "SearchReciever_Admin");
					num = ((int)num2 * -1104920145) ^ -1886863363;
					continue;
				case 273u:
					SearchReciever_Admin.smethod_15((Control)(object)Label4, "Label4");
					num = (int)((num2 * 850976906) ^ 0x3CECD7AB);
					continue;
				case 272u:
					SearchReciever_Admin.smethod_22((Control)(object)MobileTxt, 12);
					num = ((int)num2 * -1432218848) ^ -270151046;
					continue;
				case 271u:
					SearchReciever_Admin.smethod_50((ISupportInitialize)SearchResultGrid);
					num = ((int)num2 * -1838557171) ^ 0x42D66D0E;
					continue;
				case 270u:
					SearchReciever_Admin.smethod_16((Control)(object)Label3, new Size(77, 28));
					num = ((int)num2 * -1365977379) ^ 0x17A4EA16;
					continue;
				case 269u:
					num = (int)((num2 * 950161386) ^ 0x37790B06);
					continue;
				case 268u:
					num = ((int)num2 * -559263040) ^ 0x2BAA46BD;
					continue;
				case 267u:
					SearchReciever_Admin.smethod_33(SearchResultGrid, Color.White);
					num = (int)((num2 * 666986321) ^ 0x77620AA8);
					continue;
				case 266u:
					SearchReciever_Admin.smethod_14((Control)(object)Label12, new Point(401, 217));
					num = (int)(num2 * 1075741214) ^ -1898136936;
					continue;
				case 265u:
					num = ((int)num2 * -1758434785) ^ 0x57E9D5D7;
					continue;
				case 264u:
					SearchReciever_Admin.smethod_11((Control)(object)RecieverInfoBox);
					num = ((int)num2 * -1029993771) ^ 0x1FC81CB5;
					continue;
				case 263u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)MobileSTxt);
					num = ((int)num2 * -621897737) ^ -1897822690;
					continue;
				case 262u:
					SearchReciever_Admin.smethod_17(PictureBox1, (PictureBoxSizeMode)1);
					num = (int)((num2 * 1102003959) ^ 0x7593F566);
					continue;
				case 261u:
					UpdateBtn = SearchReciever_Admin.smethod_6();
					num = ((int)num2 * -474392399) ^ 0x33051C76;
					continue;
				case 260u:
					num = ((int)num2 * -1694973162) ^ -1144596338;
					continue;
				case 259u:
					num = ((int)num2 * -1012036051) ^ 0x1EEC5E4F;
					continue;
				case 258u:
					num = (int)((num2 * 751875258) ^ 0x26BE960C);
					continue;
				case 257u:
					SearchReciever_Admin.smethod_42((TextBoxBase)(object)IDTxt, bool_0: true);
					num = ((int)num2 * -1281381727) ^ -1985987806;
					continue;
				case 256u:
					num = (int)((num2 * 952684110) ^ 0x5BC422E7);
					continue;
				case 255u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_47((Control)(object)this), (Control)(object)GroupBox1);
					num = ((int)num2 * -618339208) ^ 0x72FC22FF;
					continue;
				case 254u:
					SearchReciever_Admin.smethod_27(RecieverInfoBox, bool_0: false);
					num = ((int)num2 * -1303287518) ^ -1611554916;
					continue;
				case 253u:
					SearchReciever_Admin.smethod_21((Control)(object)Label8, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchReciever_Admin.smethod_14((Control)(object)Label8, new Point(16, 78));
					SearchReciever_Admin.smethod_15((Control)(object)Label8, "Label8");
					num = (int)(num2 * 1490164824) ^ -1532976362;
					continue;
				case 252u:
					SearchReciever_Admin.smethod_22((Control)(object)Label12, 18);
					num = (int)((num2 * 1708906668) ^ 0x51D996F2);
					continue;
				case 251u:
					SearchReciever_Admin.smethod_14((Control)(object)QuantityTxt, new Point(507, 215));
					num = (int)(num2 * 249391119) ^ -1138431720;
					continue;
				case 250u:
					Label8 = SearchReciever_Admin.smethod_4();
					DOBTxt = SearchReciever_Admin.smethod_7();
					num = (int)(num2 * 783190330) ^ -2079707316;
					continue;
				case 249u:
					BloodGroupTxt = SearchReciever_Admin.smethod_9();
					num = (int)((num2 * 2045360227) ^ 0xE3BECAF);
					continue;
				case 248u:
					num = (int)((num2 * 2113836418) ^ 0x7ECF7AB3);
					continue;
				case 247u:
					SearchReciever_Admin.smethod_22((Control)(object)GenderTxt, 20);
					num = ((int)num2 * -816695934) ^ -464365060;
					continue;
				case 246u:
					SearchReciever_Admin.smethod_22((Control)(object)SearchResultGrid, 13);
					num = (int)(num2 * 2057262462) ^ -1223553874;
					continue;
				case 245u:
					num = ((int)num2 * -1725561244) ^ -1964683747;
					continue;
				case 244u:
					SearchReciever_Admin.smethod_16((Control)(object)DOBTxt, new Size(169, 28));
					num = (int)((num2 * 1896468591) ^ 0x21F17DE6);
					continue;
				case 243u:
					SearchReciever_Admin.smethod_22((Control)(object)GroupBox1, 12);
					num = ((int)num2 * -2013506199) ^ -1389730753;
					continue;
				case 242u:
					SearchReciever_Admin.smethod_21((Control)(object)RecieverInfoBox, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchReciever_Admin.smethod_14((Control)(object)RecieverInfoBox, new Point(79, 470));
					num = (int)((num2 * 1971792578) ^ 0x15B68468);
					continue;
				case 241u:
					SearchReciever_Admin.smethod_16((Control)(object)DateRecievedTxt, new Size(222, 28));
					num = (int)((num2 * 1171339626) ^ 0x2C83BF09);
					continue;
				case 240u:
					SearchReciever_Admin.smethod_21((Control)(object)SearchBtn, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchReciever_Admin.smethod_30((Control)(object)SearchBtn, Color.White);
					num = ((int)num2 * -413797153) ^ 0x3E8A3325;
					continue;
				case 239u:
					SearchReciever_Admin.smethod_22((Control)(object)NameTxt, 4);
					SearchReciever_Admin.smethod_21((Control)(object)Label6, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1478064208) ^ -916921202;
					continue;
				case 238u:
					SearchReciever_Admin.smethod_15((Control)(object)GroupBox1, "GroupBox1");
					num = (int)((num2 * 655980104) ^ 0x73ABBCB3);
					continue;
				case 237u:
					num = ((int)num2 * -371317282) ^ -50962497;
					continue;
				case 236u:
					SearchReciever_Admin.smethod_23(Label3, "Mobile : ");
					num = ((int)num2 * -307030226) ^ 0x7104530;
					continue;
				case 235u:
					SearchReciever_Admin.smethod_50((ISupportInitialize)PictureBox1);
					num = (int)((num2 * 1373666664) ^ 0x30644F4F);
					continue;
				case 234u:
					SearchReciever_Admin.smethod_22((Control)(object)RecieverInfoBox, 14);
					num = ((int)num2 * -1772603006) ^ 0x20810057;
					continue;
				case 233u:
					ClearBtn = SearchReciever_Admin.smethod_6();
					num = ((int)num2 * -535907558) ^ -368138790;
					continue;
				case 232u:
					num = ((int)num2 * -1861605124) ^ -1900587406;
					continue;
				case 231u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)SearchBtn);
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)GroupBox1), (Control)(object)Label3);
					num = (int)(num2 * 226398005) ^ -1984541267;
					continue;
				case 230u:
					SearchResultGrid = SearchReciever_Admin.smethod_8();
					num = (int)((num2 * 1076039721) ^ 0x30389BC0);
					continue;
				case 229u:
					SearchReciever_Admin.smethod_16((Control)(object)MobileTxt, new Size(271, 28));
					num = ((int)num2 * -1213190445) ^ 0x567B218E;
					continue;
				case 228u:
					SearchReciever_Admin.smethod_22((Control)(object)Label11, 16);
					num = (int)((num2 * 999806678) ^ 0x559C72E3);
					continue;
				case 227u:
					SearchReciever_Admin.smethod_21((Control)(object)DeleteBtn, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -685181315) ^ -2024412181;
					continue;
				case 226u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_47((Control)(object)this), (Control)(object)SearchResultGrid);
					num = ((int)num2 * -1142447870) ^ 0x372D9CE5;
					continue;
				case 225u:
					SearchReciever_Admin.smethod_15((Control)(object)Label9, "Label9");
					num = ((int)num2 * -1198139915) ^ 0x1BCAA2E2;
					continue;
				case 224u:
					SearchReciever_Admin.smethod_14((Control)(object)Label5, new Point(16, 169));
					num = ((int)num2 * -1407649550) ^ 0x3FCC3990;
					continue;
				case 223u:
					num = ((int)num2 * -1894313092) ^ -1147879213;
					continue;
				case 222u:
					SearchReciever_Admin.smethod_13(PictureBox1, (Image)(object)Resources.images);
					num = ((int)num2 * -683459479) ^ 0x7F13718E;
					continue;
				case 221u:
					SearchReciever_Admin.smethod_38(GenderTxt, (ComboBoxStyle)2);
					num = (int)((num2 * 345148191) ^ 0x7F91D1C0);
					continue;
				case 220u:
					SearchReciever_Admin.smethod_15((Control)(object)QuantityTxt, "QuantityTxt");
					num = ((int)num2 * -903867591) ^ -1095342071;
					continue;
				case 219u:
					SearchReciever_Admin.smethod_23(Label8, "Name : ");
					num = ((int)num2 * -551086104) ^ 0x18D6148E;
					continue;
				case 218u:
					SearchReciever_Admin.smethod_21((Control)(object)ClearBtn, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -624194) ^ -1792530210;
					continue;
				case 217u:
					SearchReciever_Admin.smethod_22((Control)(object)IDTxt, 17);
					num = (int)(num2 * 522333066) ^ -1966552093;
					continue;
				case 216u:
					SearchReciever_Admin.smethod_52((Control)(object)GroupBox1);
					num = (int)((num2 * 752288059) ^ 0x20899096);
					continue;
				case 215u:
					num = ((int)num2 * -1556556293) ^ 0x42BEB553;
					continue;
				case 214u:
					num = ((int)num2 * -512774909) ^ 0x19265BF6;
					continue;
				case 213u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)DateRecievedTxt);
					num = ((int)num2 * -1343487941) ^ -1261093886;
					continue;
				case 212u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)IDTxt);
					num = ((int)num2 * -1594260463) ^ -890684427;
					continue;
				case 211u:
					SearchReciever_Admin.smethod_24(Label1, (ContentAlignment)32);
					num = ((int)num2 * -1500927558) ^ -726804019;
					continue;
				case 210u:
					SearchReciever_Admin.smethod_22((Control)(object)DateRecievedTxt, 10);
					num = (int)((num2 * 1433463403) ^ 0x6CD08AA);
					continue;
				case 209u:
					SearchReciever_Admin.smethod_14((Control)(object)ClearBtn, new Point(808, 649));
					num = (int)((num2 * 1247496140) ^ 0x1AD25871);
					continue;
				case 208u:
					Label11 = SearchReciever_Admin.smethod_4();
					num = ((int)num2 * -1921735409) ^ -112266643;
					continue;
				case 207u:
					num = (int)(num2 * 334417014) ^ -345231784;
					continue;
				case 206u:
					QuantityTxt = SearchReciever_Admin.smethod_7();
					num = (int)((num2 * 644930505) ^ 0x2CE0A06);
					continue;
				case 205u:
					num = ((int)num2 * -294219861) ^ 0x537721B9;
					continue;
				case 204u:
					SearchReciever_Admin.smethod_15((Control)(object)PictureBox1, "PictureBox1");
					num = (int)((num2 * 1655046708) ^ 0x1433435D);
					continue;
				case 203u:
					SearchReciever_Admin.smethod_24(Label2, (ContentAlignment)32);
					num = ((int)num2 * -2009766360) ^ 0x40CD6E65;
					continue;
				case 202u:
					SearchReciever_Admin.smethod_14((Control)(object)Label2, new Point(37, 44));
					num = (int)(num2 * 1664248662) ^ -1104402231;
					continue;
				case 201u:
					num = (int)((num2 * 8290776) ^ 0x54AAC7D3);
					continue;
				case 200u:
					num = (int)(num2 * 2117713270) ^ -987976763;
					continue;
				case 199u:
					num = (int)((num2 * 569417578) ^ 0x3AB0896);
					continue;
				case 198u:
					SearchReciever_Admin.smethod_22((Control)(object)Label5, 1);
					SearchReciever_Admin.smethod_23(Label5, "Age :");
					num = ((int)num2 * -698717521) ^ 0x32817623;
					continue;
				case 197u:
					SearchReciever_Admin.smethod_46((Control)(object)this, Color.White);
					num = (int)((num2 * 1505666130) ^ 0x1FF28186);
					continue;
				case 196u:
					SearchBtn = SearchReciever_Admin.smethod_6();
					num = (int)((num2 * 900242788) ^ 0x11A3A658);
					continue;
				case 195u:
					SearchReciever_Admin.smethod_16((Control)(object)BloodGroupTxt, new Size(146, 30));
					num = ((int)num2 * -1188487025) ^ -1760174308;
					continue;
				case 194u:
					num = ((int)num2 * -258983866) ^ 0x3DDB96BA;
					continue;
				case 193u:
					SearchReciever_Admin.smethod_32((ButtonBase)(object)DeleteBtn, bool_0: false);
					SearchReciever_Admin.smethod_29((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					num = ((int)num2 * -1239560679) ^ 0x8ADF6F6;
					continue;
				case 192u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)BloodGroupTxt);
					num = ((int)num2 * -1352201127) ^ 0x59FB9DE6;
					continue;
				case 191u:
					num = ((int)num2 * -290279420) ^ 0x6ECA4116;
					continue;
				case 190u:
					num = ((int)num2 * -522927158) ^ -1594528853;
					continue;
				case 189u:
					num = (int)(num2 * 995814555) ^ -639468594;
					continue;
				case 188u:
					num = ((int)num2 * -578898944) ^ 0x604C8FF8;
					continue;
				case 187u:
					num = (int)((num2 * 582584706) ^ 0x7191ECAB);
					continue;
				case 186u:
					num = ((int)num2 * -789363928) ^ 0x5C1DC95E;
					continue;
				case 185u:
					NameTxt = SearchReciever_Admin.smethod_7();
					Label6 = SearchReciever_Admin.smethod_4();
					num = (int)((num2 * 1264724450) ^ 0x7BE961D3);
					continue;
				case 184u:
					num = ((int)num2 * -164388097) ^ -607373351;
					continue;
				case 183u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_47((Control)(object)this), (Control)(object)Label1);
					num = ((int)num2 * -80340342) ^ -945110340;
					continue;
				case 182u:
					SearchReciever_Admin.smethod_14((Control)(object)SearchBtn, new Point(468, 82));
					SearchReciever_Admin.smethod_15((Control)(object)SearchBtn, "SearchBtn");
					num = ((int)num2 * -1434751279) ^ -1400405680;
					continue;
				case 181u:
					SearchReciever_Admin.smethod_23(Label9, "Phone : ");
					num = (int)(num2 * 895065343) ^ -2103834997;
					continue;
				case 180u:
					SearchReciever_Admin.smethod_53((Control)(object)this, bool_0: false);
					num = ((int)num2 * -521006464) ^ -795875002;
					continue;
				case 179u:
					SearchReciever_Admin.smethod_22((Control)(object)NameSTxt, 1);
					num = ((int)num2 * -428471776) ^ -1210731838;
					continue;
				case 178u:
					SearchReciever_Admin.smethod_21((Control)(object)Label5, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1798984534) ^ 0x1898B3E5;
					continue;
				case 177u:
					Label3 = SearchReciever_Admin.smethod_4();
					num = (int)((num2 * 265894110) ^ 0x131693E2);
					continue;
				case 176u:
					SearchReciever_Admin.smethod_41(SearchReciever_Admin.smethod_40(BloodGroupTxt), new object[8] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
					num = ((int)num2 * -1152047493) ^ 0x4CDF2994;
					continue;
				case 175u:
					SearchReciever_Admin.smethod_23(Label1, "Search Reciever");
					num = (int)(num2 * 1608104590) ^ -804179652;
					continue;
				case 174u:
					SearchReciever_Admin.smethod_16((Control)(object)Label2, new Size(77, 28));
					num = ((int)num2 * -1597154127) ^ 0x7BF7CEAB;
					continue;
				case 173u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_47((Control)(object)this), (Control)(object)UpdateBtn);
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_47((Control)(object)this), (Control)(object)ClearBtn);
					num = (int)((num2 * 340422769) ^ 0x50AE0891);
					continue;
				case 172u:
					SearchReciever_Admin.smethod_43((Control)(object)UpdateBtn, bool_0: false);
					num = ((int)num2 * -2104516576) ^ 0x7F317633;
					continue;
				case 171u:
					num = ((int)num2 * -1460601528) ^ -1481769808;
					continue;
				case 170u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)QuantityTxt);
					num = (int)((num2 * 1099894163) ^ 0x490C74F7);
					continue;
				case 169u:
					SearchReciever_Admin.smethod_15((Control)(object)Label5, "Label5");
					num = ((int)num2 * -1138173731) ^ 0x51D71191;
					continue;
				case 168u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)Label9);
					num = (int)((num2 * 531113331) ^ 0x8631EAF);
					continue;
				case 167u:
					SearchReciever_Admin.smethod_22((Control)(object)DOBTxt, 5);
					num = (int)((num2 * 626127417) ^ 0x3FEB11FE);
					continue;
				case 166u:
					num = (int)(num2 * 1923195636) ^ -612585046;
					continue;
				case 165u:
					num = (int)(num2 * 2086330248) ^ -622655471;
					continue;
				case 164u:
					num = (int)(num2 * 468045138) ^ -1329738342;
					continue;
				case 163u:
					SearchReciever_Admin.smethod_16((Control)(object)GroupBox1, new Size(623, 128));
					num = (int)(num2 * 657244283) ^ -1067900209;
					continue;
				case 162u:
					SearchReciever_Admin.smethod_45((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1256356430) ^ 0x4F45ABCE;
					continue;
				case 161u:
					SearchReciever_Admin.smethod_39((ListControl)(object)GenderTxt, bool_0: true);
					num = (int)((num2 * 1403000579) ^ 0x22A9117C);
					continue;
				case 160u:
					SearchReciever_Admin.smethod_29((ButtonBase)(object)DeleteBtn, Color.MidnightBlue);
					num = ((int)num2 * -2018501378) ^ 0x41E356DA;
					continue;
				case 159u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_47((Control)(object)this), (Control)(object)PictureBox1);
					num = (int)((num2 * 812771286) ^ 0x4079016D);
					continue;
				case 158u:
					num = (int)((num2 * 1055306321) ^ 0x3D069881);
					continue;
				case 157u:
					SearchReciever_Admin.smethod_35(SearchResultGrid, bool_0: true);
					num = ((int)num2 * -1511739620) ^ 0x3E404FE2;
					continue;
				case 156u:
					SearchReciever_Admin.smethod_14((Control)(object)SearchResultGrid, new Point(59, 295));
					SearchReciever_Admin.smethod_15((Control)(object)SearchResultGrid, "SearchResultGrid");
					num = (int)((num2 * 673604907) ^ 0x37D92C08);
					continue;
				case 155u:
					SearchReciever_Admin.smethod_14((Control)(object)DOBTxt, new Point(117, 167));
					num = (int)(num2 * 90240303) ^ -1399502031;
					continue;
				case 153u:
					SearchReciever_Admin.smethod_14((Control)(object)Label10, new Point(16, 221));
					SearchReciever_Admin.smethod_15((Control)(object)Label10, "Label10");
					SearchReciever_Admin.smethod_16((Control)(object)Label10, new Size(174, 25));
					SearchReciever_Admin.smethod_22((Control)(object)Label10, 0);
					num = ((int)num2 * -704579054) ^ -1726679677;
					continue;
				case 152u:
					num = (int)((num2 * 1326635927) ^ 0xC62CDC5);
					continue;
				case 151u:
					num = ((int)num2 * -1883778249) ^ 0x668A56E9;
					continue;
				case 150u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)MobileTxt);
					num = (int)((num2 * 1924223277) ^ 0x1E1BADFD);
					continue;
				case 149u:
					SearchReciever_Admin.smethod_22((Control)(object)SearchBtn, 4);
					num = ((int)num2 * -876556677) ^ -220831999;
					continue;
				case 148u:
					num = (int)((num2 * 598142928) ^ 0x65F4DDA6);
					continue;
				case 147u:
					num = ((int)num2 * -54971442) ^ 0x3670613E;
					continue;
				case 146u:
					num = ((int)num2 * -280441357) ^ -20224652;
					continue;
				case 145u:
					SearchReciever_Admin.smethod_14((Control)(object)GenderTxt, new Point(530, 117));
					SearchReciever_Admin.smethod_15((Control)(object)GenderTxt, "GenderTxt");
					num = ((int)num2 * -1564689973) ^ 0x7D7666D2;
					continue;
				case 144u:
					num = (int)(num2 * 2020849056) ^ -1799077773;
					continue;
				case 143u:
					DateRecievedTxt = SearchReciever_Admin.smethod_7();
					num = ((int)num2 * -1024330786) ^ -955930695;
					continue;
				case 142u:
					SearchReciever_Admin.smethod_15((Control)(object)ClearBtn, "ClearBtn");
					num = (int)(num2 * 2006874339) ^ -148123067;
					continue;
				case 141u:
					num = ((int)num2 * -448055006) ^ -2023122150;
					continue;
				case 140u:
					SearchReciever_Admin.smethod_22((Control)(object)Label6, 2);
					num = ((int)num2 * -929673049) ^ 0x25E92AD7;
					continue;
				case 139u:
					SearchReciever_Admin.smethod_23(Label2, "Name : ");
					num = ((int)num2 * -1760103331) ^ 0x60C12AD2;
					continue;
				case 138u:
					num = (int)(num2 * 955209478) ^ -1423477776;
					continue;
				case 137u:
					SearchReciever_Admin.smethod_22((Control)(object)Label3, 3);
					num = ((int)num2 * -478930884) ^ -2014073835;
					continue;
				case 136u:
					num = ((int)num2 * -905892137) ^ -1265188858;
					continue;
				case 135u:
					SearchReciever_Admin.smethod_16((Control)(object)SearchResultGrid, new Size(853, 169));
					num = (int)(num2 * 142993266) ^ -1855579103;
					continue;
				case 134u:
					SearchReciever_Admin.smethod_21((Control)(object)UpdateBtn, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchReciever_Admin.smethod_30((Control)(object)UpdateBtn, Color.White);
					num = ((int)num2 * -1566890675) ^ -1429480495;
					continue;
				case 133u:
					NameSTxt = SearchReciever_Admin.smethod_7();
					Label2 = SearchReciever_Admin.smethod_4();
					num = ((int)num2 * -1817858768) ^ 0x75E198AB;
					continue;
				case 132u:
					num = (int)((num2 * 768539119) ^ 0x4A894A47);
					continue;
				case 131u:
					DeleteBtn = SearchReciever_Admin.smethod_6();
					num = (int)((num2 * 403825400) ^ 0x1E937A0A);
					continue;
				case 130u:
					SearchReciever_Admin.smethod_23(Label11, "ID :");
					num = (int)(num2 * 938127290) ^ -591577540;
					continue;
				case 129u:
					SearchReciever_Admin.smethod_21((Control)(object)Label9, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchReciever_Admin.smethod_14((Control)(object)Label9, new Point(16, 124));
					num = ((int)num2 * -308708097) ^ -745429077;
					continue;
				case 128u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)Label8);
					num = ((int)num2 * -696313407) ^ 0x2302E307;
					continue;
				case 127u:
					num = ((int)num2 * -836218783) ^ -921423959;
					continue;
				case 126u:
					num = ((int)num2 * -1998491020) ^ -1604759353;
					continue;
				case 125u:
					num = (int)((num2 * 1387126146) ^ 0xA2CE95A);
					continue;
				case 124u:
					num = (int)((num2 * 1011991699) ^ 0x49B64058);
					continue;
				case 123u:
					num = ((int)num2 * -528280) ^ 0x37337AB8;
					continue;
				case 122u:
					SearchReciever_Admin.smethod_19(PictureBox1, bool_0: false);
					SearchReciever_Admin.smethod_21((Control)(object)Label1, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1659865855) ^ -2029164715;
					continue;
				case 121u:
					SearchReciever_Admin.smethod_14((Control)(object)PictureBox1, new Point(203, 18));
					num = ((int)num2 * -1655731921) ^ 0xAD78B95;
					continue;
				case 120u:
					SearchReciever_Admin.smethod_16((Control)(object)PictureBox1, new Size(197, 126));
					num = (int)(num2 * 2093764325) ^ -1470243045;
					continue;
				case 119u:
					SearchReciever_Admin.smethod_14((Control)(object)BloodGroupTxt, new Point(531, 164));
					num = ((int)num2 * -819468788) ^ 0x4030125F;
					continue;
				case 118u:
					SearchReciever_Admin.smethod_32((ButtonBase)(object)SearchBtn, bool_0: false);
					num = ((int)num2 * -253826707) ^ 0x796CC7F0;
					continue;
				case 117u:
					num = ((int)num2 * -588890328) ^ -921310654;
					continue;
				case 116u:
					SearchReciever_Admin.smethod_14((Control)(object)Label6, new Point(401, 129));
					num = (int)((num2 * 2058180243) ^ 0x4231B953);
					continue;
				case 115u:
					SearchReciever_Admin.smethod_16((Control)(object)Label1, new Size(330, 47));
					num = ((int)num2 * -124039458) ^ -963417056;
					continue;
				case 114u:
					SearchReciever_Admin.smethod_15((Control)(object)BloodGroupTxt, "BloodGroupTxt");
					num = ((int)num2 * -1664801423) ^ 0x48C05760;
					continue;
				case 113u:
					num = (int)(num2 * 466904907) ^ -1750450127;
					continue;
				case 112u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)NameTxt);
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)Label6);
					num = (int)((num2 * 2070927942) ^ 0x1716C916);
					continue;
				case 111u:
					SearchReciever_Admin.smethod_30((Control)(object)ClearBtn, Color.White);
					num = ((int)num2 * -1367486628) ^ -1678437555;
					continue;
				case 110u:
					SearchReciever_Admin.smethod_10((ISupportInitialize)SearchResultGrid);
					num = ((int)num2 * -1900343682) ^ -447030771;
					continue;
				case 109u:
					SearchReciever_Admin.smethod_18(PictureBox1, 7);
					num = (int)((num2 * 653214916) ^ 0x1D4554A1);
					continue;
				case 108u:
					num = (int)(num2 * 1677272200) ^ -1237442063;
					continue;
				case 107u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)GenderTxt);
					num = (int)(num2 * 1736997593) ^ -1390182600;
					continue;
				case 106u:
					SearchReciever_Admin.smethod_14((Control)(object)Label1, new Point(392, 63));
					num = (int)(num2 * 1030066276) ^ -849496970;
					continue;
				case 105u:
					SearchReciever_Admin.smethod_16((Control)(object)NameTxt, new Size(271, 28));
					num = (int)((num2 * 772958222) ^ 0x637DE2D8);
					continue;
				case 104u:
					SearchReciever_Admin.smethod_16((Control)(object)Label12, new Size(100, 26));
					num = (int)(num2 * 1607201653) ^ -4046007;
					continue;
				case 103u:
					SearchReciever_Admin.smethod_23(Label10, "Date Recieved :");
					num = (int)((num2 * 69178708) ^ 0x1CFC47D1);
					continue;
				case 102u:
					SearchReciever_Admin.smethod_15((Control)(object)UpdateBtn, "UpdateBtn");
					SearchReciever_Admin.smethod_16((Control)(object)UpdateBtn, new Size(104, 37));
					num = ((int)num2 * -1143936039) ^ -1911192834;
					continue;
				case 101u:
					num = ((int)num2 * -1242975512) ^ -1747908714;
					continue;
				case 100u:
					SearchReciever_Admin.smethod_15((Control)(object)IDTxt, "IDTxt");
					num = (int)(num2 * 1288935691) ^ -1906715578;
					continue;
				case 99u:
					SearchReciever_Admin.smethod_24(Label8, (ContentAlignment)32);
					num = (int)(num2 * 1547166925) ^ -646076351;
					continue;
				case 98u:
					SearchReciever_Admin.smethod_29((ButtonBase)(object)UpdateBtn, Color.MidnightBlue);
					num = (int)((num2 * 11170147) ^ 0x6B16A50B);
					continue;
				case 97u:
					SearchReciever_Admin.smethod_15((Control)(object)Label11, "Label11");
					num = ((int)num2 * -457082387) ^ 0x4EE54D1D;
					continue;
				case 96u:
					num = (int)((num2 * 2072352758) ^ 0x3E16DDC);
					continue;
				case 95u:
					SearchReciever_Admin.smethod_16((Control)(object)Label6, new Size(84, 26));
					num = (int)(num2 * 2061821027) ^ -537369843;
					continue;
				case 94u:
					SearchReciever_Admin.smethod_16((Control)(object)QuantityTxt, new Size(169, 28));
					num = ((int)num2 * -1243489796) ^ -1581855595;
					continue;
				case 93u:
					num = ((int)num2 * -204720160) ^ -1377391616;
					continue;
				case 92u:
					SearchReciever_Admin.smethod_29((ButtonBase)(object)SearchBtn, Color.MidnightBlue);
					num = (int)(num2 * 1622505084) ^ -807387095;
					continue;
				case 91u:
					SearchReciever_Admin.smethod_16((Control)(object)Label5, new Size(84, 26));
					num = (int)(num2 * 755045941) ^ -650129760;
					continue;
				case 90u:
					SearchReciever_Admin.smethod_11((Control)(object)GroupBox1);
					num = ((int)num2 * -1313734043) ^ 0x70E441E9;
					continue;
				case 89u:
					num = ((int)num2 * -1695573732) ^ -1781024723;
					continue;
				case 88u:
					num = (int)((num2 * 941099391) ^ 0x75C4B056);
					continue;
				case 87u:
					SearchReciever_Admin.smethod_14((Control)(object)MobileTxt, new Point(117, 124));
					SearchReciever_Admin.smethod_15((Control)(object)MobileTxt, "MobileTxt");
					num = (int)((num2 * 1156264834) ^ 0x15A96FD5);
					continue;
				case 86u:
					SearchReciever_Admin.smethod_14((Control)(object)UpdateBtn, new Point(808, 517));
					num = ((int)num2 * -1217496193) ^ 0x6203F3FD;
					continue;
				case 85u:
					SearchReciever_Admin.smethod_21((Control)(object)Label12, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1503103755) ^ -193023408;
					continue;
				case 84u:
					SearchReciever_Admin.smethod_12((Control)(object)this);
					num = ((int)num2 * -865826801) ^ 0x64FF9334;
					continue;
				case 83u:
					Label1 = SearchReciever_Admin.smethod_4();
					GroupBox1 = SearchReciever_Admin.smethod_5();
					num = (int)((num2 * 1186891262) ^ 0x692114B4);
					continue;
				case 82u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)Label11);
					num = (int)(num2 * 961939957) ^ -1942115843;
					continue;
				case 81u:
					SearchReciever_Admin.smethod_15((Control)(object)DateRecievedTxt, "DateRecievedTxt");
					num = ((int)num2 * -974257285) ^ 0xE01737A;
					continue;
				case 80u:
					num = (int)((num2 * 470300553) ^ 0x1BD986E3);
					continue;
				case 79u:
					SearchReciever_Admin.smethod_15((Control)(object)Label3, "Label3");
					num = ((int)num2 * -576340590) ^ 0x6E479949;
					continue;
				case 78u:
					SearchReciever_Admin.smethod_23(Label6, "Gender : ");
					num = ((int)num2 * -236077144) ^ -2045135195;
					continue;
				case 77u:
					num = ((int)num2 * -1905867078) ^ 0x6F2EC461;
					continue;
				case 76u:
					SearchReciever_Admin.smethod_44((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -77716065) ^ -1921276172;
					continue;
				case 75u:
					SearchReciever_Admin.smethod_16((Control)(object)GenderTxt, new Size(146, 30));
					num = ((int)num2 * -272068035) ^ -360500663;
					continue;
				case 74u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)Label4);
					num = (int)((num2 * 1240791776) ^ 0x570243E3);
					continue;
				case 73u:
					num = ((int)num2 * -2024006600) ^ -1182865149;
					continue;
				case 72u:
					num = (int)((num2 * 641235062) ^ 0x4DDA10BB);
					continue;
				case 71u:
					SearchReciever_Admin.smethod_22((Control)(object)DeleteBtn, 15);
					SearchReciever_Admin.smethod_31((ButtonBase)(object)DeleteBtn, "Delete");
					num = ((int)num2 * -1543911437) ^ -792393035;
					continue;
				case 70u:
					SearchReciever_Admin.smethod_10((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -1452416075) ^ 0x66D69D19;
					continue;
				case 69u:
					num = (int)((num2 * 1828899840) ^ 0xB727E8B);
					continue;
				case 68u:
					SearchReciever_Admin.smethod_15((Control)(object)NameSTxt, "NameSTxt");
					num = ((int)num2 * -860303048) ^ -1668130706;
					continue;
				case 67u:
					SearchReciever_Admin.smethod_28(RecieverInfoBox, "Reciever Information");
					SearchReciever_Admin.smethod_38(BloodGroupTxt, (ComboBoxStyle)2);
					num = ((int)num2 * -2053687253) ^ -1465512922;
					continue;
				case 66u:
					SearchReciever_Admin.smethod_28(GroupBox1, "Search Patient");
					num = (int)(num2 * 552367991) ^ -217288357;
					continue;
				case 65u:
					SearchReciever_Admin.smethod_27(GroupBox1, bool_0: false);
					num = ((int)num2 * -718102968) ^ 0x61B02423;
					continue;
				case 64u:
					num = (int)((num2 * 447301264) ^ 0x6CACB378);
					continue;
				case 63u:
					SearchReciever_Admin.smethod_16((Control)(object)RecieverInfoBox, new Size(699, 259));
					num = ((int)num2 * -1736027611) ^ -1138809944;
					continue;
				case 62u:
					SearchReciever_Admin.smethod_41(SearchReciever_Admin.smethod_40(GenderTxt), new object[3] { "Male", "Female", "Others" });
					num = (int)(num2 * 1089563644) ^ -1206045424;
					continue;
				case 61u:
					num = (int)((num2 * 1979843532) ^ 0x3F88352D);
					continue;
				case 60u:
					num = ((int)num2 * -677842583) ^ -1618521581;
					continue;
				case 59u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_47((Control)(object)this), (Control)(object)DeleteBtn);
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_47((Control)(object)this), (Control)(object)RecieverInfoBox);
					num = ((int)num2 * -1262235703) ^ -728297224;
					continue;
				case 58u:
					num = ((int)num2 * -1305361428) ^ -176235292;
					continue;
				case 57u:
					num = ((int)num2 * -1903346445) ^ 0x83EE4CC;
					continue;
				case 56u:
					SearchReciever_Admin.smethod_16((Control)(object)Label9, new Size(77, 28));
					num = ((int)num2 * -1900250951) ^ 0x2753CCC;
					continue;
				case 55u:
					RecieverInfoBox = SearchReciever_Admin.smethod_5();
					num = (int)(num2 * 1011901053) ^ -1176128201;
					continue;
				case 54u:
					SearchReciever_Admin.smethod_31((ButtonBase)(object)ClearBtn, "Clear");
					num = ((int)num2 * -541341926) ^ -1212009631;
					continue;
				case 53u:
					Label12 = SearchReciever_Admin.smethod_4();
					IDTxt = SearchReciever_Admin.smethod_7();
					num = (int)(num2 * 1101891734) ^ -1937985749;
					continue;
				case 52u:
					SearchReciever_Admin.smethod_51((Control)(object)RecieverInfoBox, bool_0: false);
					SearchReciever_Admin.smethod_52((Control)(object)RecieverInfoBox);
					num = (int)(num2 * 625213385) ^ -785618975;
					continue;
				case 51u:
					SearchReciever_Admin.smethod_21((Control)(object)Label4, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1469348676) ^ 0x162C342A);
					continue;
				case 50u:
					SearchReciever_Admin.smethod_31((ButtonBase)(object)UpdateBtn, "Update");
					num = ((int)num2 * -1252673084) ^ -885803471;
					continue;
				case 49u:
					SearchReciever_Admin.smethod_15((Control)(object)RecieverInfoBox, "RecieverInfoBox");
					num = (int)(num2 * 1858634030) ^ -1329491184;
					continue;
				case 48u:
					SearchReciever_Admin.smethod_22((Control)(object)BloodGroupTxt, 21);
					num = ((int)num2 * -1927514603) ^ -1798736772;
					continue;
				case 47u:
					SearchReciever_Admin.smethod_21((Control)(object)GroupBox1, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchReciever_Admin.smethod_14((Control)(object)GroupBox1, new Point(155, 150));
					num = (int)(num2 * 2070215718) ^ -97725022;
					continue;
				case 46u:
					SearchReciever_Admin.smethod_21((Control)(object)Label10, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1708945129) ^ 0x210337A3;
					continue;
				case 45u:
					SearchReciever_Admin.smethod_23(Label4, "Blood Group : ");
					SearchReciever_Admin.smethod_24(Label4, (ContentAlignment)32);
					num = (int)(num2 * 1901469773) ^ -1009516797;
					continue;
				case 44u:
					SearchReciever_Admin.smethod_32((ButtonBase)(object)UpdateBtn, bool_0: false);
					num = ((int)num2 * -571775282) ^ 0x3B0CA8AC;
					continue;
				case 43u:
					num = (int)((num2 * 797955591) ^ 0x787220BC);
					continue;
				case 42u:
					num = (int)(num2 * 655576694) ^ -1419023130;
					continue;
				case 41u:
					num = ((int)num2 * -1282528879) ^ 0x7C27D4D7;
					continue;
				case 40u:
					SearchReciever_Admin.smethod_14((Control)(object)DateRecievedTxt, new Point(166, 215));
					num = (int)((num2 * 983437061) ^ 0x470221EC);
					continue;
				case 39u:
					num = ((int)num2 * -607841225) ^ 0x1448AC6C;
					continue;
				case 38u:
					SearchReciever_Admin.smethod_16((Control)(object)ClearBtn, new Size(104, 37));
					SearchReciever_Admin.smethod_22((Control)(object)ClearBtn, 16);
					num = (int)((num2 * 1226640601) ^ 0x66210736);
					continue;
				case 37u:
					num = (int)(num2 * 922593354) ^ -432297220;
					continue;
				case 36u:
					SearchReciever_Admin.smethod_16((Control)(object)Label4, new Size(134, 28));
					num = ((int)num2 * -275450675) ^ -35238177;
					continue;
				case 35u:
					SearchReciever_Admin.smethod_21((Control)(object)Label2, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 762889663) ^ 0x5162796E);
					continue;
				case 34u:
					SearchReciever_Admin.smethod_37(SearchReciever_Admin.smethod_36(SearchResultGrid), 24);
					num = (int)((num2 * 178323780) ^ 0x12040647);
					continue;
				case 33u:
					SearchReciever_Admin.smethod_22((Control)(object)Label9, 11);
					num = (int)(num2 * 2030975479) ^ -103988537;
					continue;
				case 32u:
					Label4 = SearchReciever_Admin.smethod_4();
					MobileTxt = SearchReciever_Admin.smethod_7();
					num = (int)((num2 * 470430163) ^ 0x67194525);
					continue;
				case 31u:
					num = ((int)num2 * -649464450) ^ 0x19DE6103;
					continue;
				case 30u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)Label12);
					num = (int)(num2 * 737971161) ^ -105808517;
					continue;
				case 29u:
					num = (int)(num2 * 462537063) ^ -1838757111;
					continue;
				case 28u:
					SearchReciever_Admin.smethod_22((Control)(object)Label8, 9);
					num = (int)((num2 * 1344329437) ^ 0x7C7F1E30);
					continue;
				case 27u:
					SearchReciever_Admin.smethod_21((Control)(object)Label3, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchReciever_Admin.smethod_14((Control)(object)Label3, new Point(37, 87));
					num = (int)(num2 * 2029153923) ^ -1742445517;
					continue;
				case 26u:
					SearchReciever_Admin.smethod_26(SearchReciever_Admin.smethod_25((Control)(object)RecieverInfoBox), (Control)(object)DOBTxt);
					num = ((int)num2 * -795906408) ^ 0xC9F5699;
					continue;
				case 25u:
					num = ((int)num2 * -1360521199) ^ 0x660E9E07;
					continue;
				case 24u:
					SearchReciever_Admin.smethod_16((Control)(object)DeleteBtn, new Size(104, 37));
					num = ((int)num2 * -1210355750) ^ -421954802;
					continue;
				case 23u:
					num = (int)(num2 * 862259122) ^ -1849463494;
					continue;
				case 22u:
					num = ((int)num2 * -361680060) ^ -1871702363;
					continue;
				case 21u:
					SearchReciever_Admin.smethod_15((Control)(object)Label1, "Label1");
					num = (int)(num2 * 1450948433) ^ -2125451042;
					continue;
				case 20u:
					num = (int)(num2 * 1206735990) ^ -134250281;
					continue;
				case 19u:
					SearchReciever_Admin.smethod_22((Control)(object)Label1, 8);
					num = (int)((num2 * 1790182734) ^ 0x16FF6997);
					continue;
				case 18u:
					SearchReciever_Admin.smethod_16((Control)(object)Label11, new Size(68, 25));
					num = ((int)num2 * -1746762835) ^ -1967746157;
					continue;
				case 17u:
					num = ((int)num2 * -1323616282) ^ 0x44D50A4B;
					continue;
				case 16u:
					SearchReciever_Admin.smethod_15((Control)(object)Label2, "Label2");
					num = ((int)num2 * -1201355024) ^ 0x719BC41F;
					continue;
				case 15u:
					num = ((int)num2 * -924593276) ^ 0x3111D6E1;
					continue;
				case 14u:
					SearchReciever_Admin.smethod_39((ListControl)(object)BloodGroupTxt, bool_0: true);
					num = ((int)num2 * -1707944863) ^ -1207598378;
					continue;
				case 13u:
					num = ((int)num2 * -1331862597) ^ 0x3B14ED64;
					continue;
				case 12u:
					num = (int)(num2 * 391878747) ^ -1426826875;
					continue;
				case 11u:
					SearchReciever_Admin.smethod_24(Label3, (ContentAlignment)32);
					SearchReciever_Admin.smethod_14((Control)(object)MobileSTxt, new Point(120, 86));
					num = (int)((num2 * 1022645996) ^ 0x526CFB34);
					continue;
				case 10u:
					SearchReciever_Admin.smethod_15((Control)(object)Label6, "Label6");
					num = (int)(num2 * 811441987) ^ -55313553;
					continue;
				case 9u:
					SearchReciever_Admin.smethod_22((Control)(object)UpdateBtn, 17);
					num = (int)((num2 * 822518099) ^ 0x4F31ECC);
					continue;
				case 8u:
					num = ((int)num2 * -1884863348) ^ 0x41911572;
					continue;
				case 6u:
					SearchReciever_Admin.smethod_22((Control)(object)Label4, 13);
					num = ((int)num2 * -1922579526) ^ 0x4C68E98A;
					continue;
				case 5u:
					num = (int)(num2 * 1238763969) ^ -614430716;
					continue;
				case 4u:
					SearchReciever_Admin.smethod_42((TextBoxBase)(object)QuantityTxt, bool_0: true);
					num = ((int)num2 * -232555803) ^ -1139582413;
					continue;
				case 3u:
					SearchReciever_Admin.smethod_16((Control)(object)SearchBtn, new Size(133, 37));
					num = (int)(num2 * 553983133) ^ -1072649173;
					continue;
				case 2u:
					num = (int)(num2 * 2095531347) ^ -809692409;
					continue;
				case 1u:
					PictureBox1 = SearchReciever_Admin.smethod_3();
					num = (int)(num2 * 2096835636) ^ -799014690;
					continue;
				case 0u:
					SearchReciever_Admin.smethod_21((Control)(object)Label11, SearchReciever_Admin.smethod_20("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					SearchReciever_Admin.smethod_14((Control)(object)Label11, new Point(16, 36));
					num = ((int)num2 * -803525251) ^ 0x16E0E250;
					continue;
				default:
					return;
				case 154u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	private void SearchDonor_Admin_Load(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1801200671;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xADEC59u) % 4u)
				{
				case 2u:
					SearchReciever_Admin.smethod_59(myconnection, SearchReciever_Admin.smethod_58(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
					num = ((int)num2 * -639331344) ^ -1869147704;
					continue;
				case 1u:
					num = (int)((num2 * 486293972) ^ 0x67FE6AC9);
					continue;
				case 3u:
					break;
				default:
					HideItemsOnForm();
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
			int num = 1781799353;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6F468421u) % 12u)
				{
				case 11u:
					num = ((int)num2 * -779954765) ^ -299640683;
					continue;
				case 10u:
					SearchReciever_Admin.smethod_43((Control)(object)ClearBtn, bool_0: false);
					num = ((int)num2 * -1935235586) ^ -2022647689;
					continue;
				case 9u:
					result = true;
					num = (int)((num2 * 1763236836) ^ 0x5414C49A);
					continue;
				case 8u:
					SearchReciever_Admin.smethod_43((Control)(object)SearchResultGrid, bool_0: false);
					num = (int)(num2 * 60783407) ^ -434285668;
					continue;
				case 7u:
					num = (int)((num2 * 1165866553) ^ 0x7DE3A675);
					continue;
				case 5u:
					num = (int)((num2 * 1440653704) ^ 0x617071E1);
					continue;
				case 4u:
					num = ((int)num2 * -341951865) ^ -137750212;
					continue;
				case 2u:
					SearchReciever_Admin.smethod_43((Control)(object)DeleteBtn, bool_0: false);
					num = (int)(num2 * 1790533878) ^ -2046788642;
					continue;
				case 1u:
					SearchReciever_Admin.smethod_43((Control)(object)UpdateBtn, bool_0: false);
					num = (int)((num2 * 1897670273) ^ 0x760C2430);
					continue;
				case 0u:
					SearchReciever_Admin.smethod_43((Control)(object)RecieverInfoBox, bool_0: false);
					num = ((int)num2 * -738724055) ^ 0x7094D22F;
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
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected I4, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected I4, but got Unknown
		//IL_034e: Incompatible stack heights: 0 vs 1
		//IL_0369: Incompatible stack heights: 0 vs 1
		//IL_0370: Incompatible stack heights: 0 vs 1
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default(DataTable);
		bool flag = default(bool);
		string string_ = default(string);
		while (true)
		{
			int num = 973339083;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x33B47763u) % 12u)
				{
				case 11u:
					dataTable = SearchReciever_Admin.smethod_65();
					num = ((int)num2 * -82814029) ^ 0x4A250DAF;
					continue;
				case 9u:
					num = 1241133823;
					continue;
				case 8u:
					HideItemsOnForm();
					num = ((int)num2 * -855820520) ^ 0x797511CE;
					continue;
				case 7u:
					mobile_search = SearchReciever_Admin.smethod_61(SearchReciever_Admin.smethod_60(MobileSTxt));
					num = (int)((num2 * 317556332) ^ 0x6BF87F87);
					continue;
				case 6u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = -494442128;
						num7 = -494442128;
					}
					else
					{
						num6 = -888995445;
						num7 = -888995445;
					}
					num = num6 ^ ((int)num2 * -1843004139);
					continue;
				}
				case 5u:
					SearchReciever_Admin.smethod_63();
					name_search = SearchReciever_Admin.smethod_61(SearchReciever_Admin.smethod_60(NameSTxt));
					num = (int)((num2 * 1828550007) ^ 0x542EA4B);
					continue;
				case 4u:
					flag = !MyProject.Forms.Form1.Name_Validation(SearchReciever_Admin.smethod_61(SearchReciever_Admin.smethod_60(NameSTxt))) | !MyProject.Forms.Form1.Mobile_Validator(SearchReciever_Admin.smethod_61(SearchReciever_Admin.smethod_60(MobileSTxt)));
					num = ((int)num2 * -764745349) ^ -2017519623;
					continue;
				case 1u:
					SearchReciever_Admin.smethod_66(myconnection);
					num = ((int)num2 * -125560999) ^ 0x4C4F6085;
					continue;
				case 0u:
					string_ = SearchReciever_Admin.smethod_64(new string[5]
					{
						"Select * From [Recievers] Where [Name] Like '%",
						SearchReciever_Admin.smethod_61(SearchReciever_Admin.smethod_60(NameSTxt)),
						"%' And [Contact Number] Like '%",
						SearchReciever_Admin.smethod_60(MobileSTxt),
						"%';"
					});
					num = ((int)num2 * -1130818928) ^ 0x7D358A90;
					continue;
				case 2u:
					break;
				default:
					try
					{
						while (true)
						{
							int num3 = 178818517;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x33B47763u) % 11u)
								{
								case 10u:
									num3 = ((int)num2 * -867926566) ^ 0x11D79B3D;
									continue;
								case 9u:
									SearchReciever_Admin.smethod_69(SearchResultGrid, (object)dataTable);
									num3 = (int)(num2 * 1747820639) ^ -1639044488;
									continue;
								case 7u:
									SearchReciever_Admin.smethod_43((Control)(object)SearchResultGrid, bool_0: true);
									num3 = 1599258328;
									continue;
								case 6u:
								{
									OleDbDataAdapter dbDataAdapter_ = SearchReciever_Admin.smethod_67(string_, myconnection);
									SearchReciever_Admin.smethod_68((DbDataAdapter)(object)dbDataAdapter_, dataTable);
									num3 = (int)(num2 * 1039918214) ^ -855015400;
									continue;
								}
								case 3u:
								{
									int num4;
									int num5;
									if (SearchReciever_Admin.smethod_70(SearchResultGrid) != 1)
									{
										num4 = -1073445733;
										num5 = -1073445733;
									}
									else
									{
										num4 = -1344752378;
										num5 = -1344752378;
									}
									num3 = num4 ^ (int)(num2 * 780842669);
									continue;
								}
								case 2u:
									SearchReciever_Admin.smethod_71(myconnection);
									num3 = ((int)num2 * -899603949) ^ -1193077346;
									continue;
								case 1u:
									num3 = (int)(num2 * 1174547342) ^ -357890525;
									continue;
								case 0u:
									SearchReciever_Admin.smethod_62("No Result Found");
									SearchReciever_Admin.smethod_71(myconnection);
									num3 = ((int)num2 * -1520569346) ^ -1386823596;
									continue;
								default:
									return;
								case 5u:
									break;
								case 4u:
									return;
								case 8u:
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
							_ = 1694799358;
							while (true)
							{
								_003F val = /*Error near IL_0324: Stack underflow*/^ 0x33B47763;
								num2 = (uint)(int)val;
								switch (val % 4)
								{
								case 3:
									_ = ((int)num2 * -1177172006) ^ 0x5AEB6AE1;
									continue;
								case 1:
									SearchReciever_Admin.smethod_71(myconnection);
									_ = (num2 * 889421375) ^ 0xE78943EBu;
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
				case 10u:
					SearchReciever_Admin.smethod_62("No Results Found");
					return;
				}
				break;
			}
		}
	}

	private void UpdateBtn_Click(object sender, EventArgs e)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected I4, but got Unknown
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected I4, but got Unknown
		//IL_03b9: Incompatible stack heights: 0 vs 1
		//IL_03ce: Incompatible stack heights: 0 vs 1
		//IL_03d5: Incompatible stack heights: 0 vs 1
		OleDbCommand val = default(OleDbCommand);
		string string_ = default(string);
		while (true)
		{
			int num = -1744638187;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB85D4E8Bu) % 11u)
				{
				case 10u:
				{
					int num6;
					if (MyProject.Forms.Form1.Name_Validation(SearchReciever_Admin.smethod_61(SearchReciever_Admin.smethod_60(NameTxt))) & MyProject.Forms.Form1.Mobile_Validator(SearchReciever_Admin.smethod_60(MobileTxt)) & MyProject.Forms.Form1.age_validator(SearchReciever_Admin.smethod_60(DOBTxt)))
					{
						num = -2505331;
						num6 = -2505331;
					}
					else
					{
						num = -836782759;
						num6 = -836782759;
					}
					continue;
				}
				case 9u:
					SearchReciever_Admin.smethod_62("Fields Cannot be empty");
					num = (int)(num2 * 2011512966) ^ -1610448770;
					continue;
				case 8u:
					num = -1645910354;
					continue;
				case 7u:
					val = SearchReciever_Admin.smethod_63();
					num = ((int)num2 * -354976600) ^ -1651196526;
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if ((SearchReciever_Admin.smethod_74(SearchReciever_Admin.smethod_60(NameTxt), "", bool_0: false) == 0) | (SearchReciever_Admin.smethod_74(SearchReciever_Admin.smethod_60(MobileTxt), "", bool_0: false) == 0) | (SearchReciever_Admin.smethod_74(SearchReciever_Admin.smethod_75(GenderTxt), "", bool_0: false) == 0) | (SearchReciever_Admin.smethod_74(SearchReciever_Admin.smethod_60(DOBTxt), "", bool_0: false) == 0) | (SearchReciever_Admin.smethod_74(SearchReciever_Admin.smethod_75(BloodGroupTxt), "", bool_0: false) == 0))
					{
						num4 = -1432233356;
						num5 = -1432233356;
					}
					else
					{
						num4 = -280286234;
						num5 = -280286234;
					}
					num = num4 ^ (int)(num2 * 711172367);
					continue;
				}
				case 2u:
					SearchReciever_Admin.smethod_62("Invalid Credentitals");
					num = (int)((num2 * 1953721366) ^ 0x36EE0883);
					continue;
				case 0u:
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
					SearchReciever_Admin.smethod_66(myconnection);
					num = (int)((num2 * 2060381079) ^ 0x4E30CD2D);
					continue;
				case 5u:
					break;
				default:
					try
					{
						while (true)
						{
							int num3 = -1891201417;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xB85D4E8Bu) % 9u)
								{
								case 7u:
									ClearDonorInfoBox();
									num3 = (int)(num2 * 967097055) ^ -1355958351;
									continue;
								case 6u:
									SearchReciever_Admin.smethod_77(val);
									SearchReciever_Admin.smethod_78((Component)(object)val);
									num3 = (int)(num2 * 670157421) ^ -1745174873;
									continue;
								case 5u:
									num3 = ((int)num2 * -2021099787) ^ 0x5E718404;
									continue;
								case 4u:
									val = SearchReciever_Admin.smethod_76(string_, myconnection);
									num3 = ((int)num2 * -469806900) ^ -2094032593;
									continue;
								case 2u:
									SearchReciever_Admin.smethod_71(myconnection);
									num3 = (int)(num2 * 740168029) ^ -313802003;
									continue;
								case 1u:
									UpdateTable();
									SearchReciever_Admin.smethod_62("Successfully Updated Details");
									num3 = ((int)num2 * -1599565636) ^ 0x15CA63AF;
									continue;
								case 0u:
									num3 = (int)((num2 * 2054921251) ^ 0x1108C763);
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
					catch (Exception exception_)
					{
						SearchReciever_Admin.smethod_72(exception_);
						while (true)
						{
							_ = -2093580892;
							while (true)
							{
								_003F val2 = /*Error near IL_0384: Stack underflow*/^ -1201844597;
								num2 = (uint)(int)val2;
								switch (val2 % 4)
								{
								default:
									return;
								case 3:
									SearchReciever_Admin.smethod_71(myconnection);
									_ = ((int)num2 * -309384056) ^ -1481844597;
									continue;
								case 0:
									SearchReciever_Admin.smethod_73();
									_ = ((int)num2 * -1951736307) ^ 0x38E884AA;
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
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void DeleteBtn_Click(object sender, EventArgs e)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected I4, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected I4, but got Unknown
		//IL_01b0: Incompatible stack heights: 0 vs 1
		//IL_01cb: Incompatible stack heights: 0 vs 1
		//IL_01d2: Incompatible stack heights: 0 vs 1
		bool flag = default(bool);
		while (true)
		{
			int num = -1178203405;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDD078323u) % 7u)
				{
				case 6u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 957577701;
						num5 = 957577701;
					}
					else
					{
						num4 = 1237869852;
						num5 = 1237869852;
					}
					num = num4 ^ ((int)num2 * -1180106272);
					continue;
				}
				case 4u:
					SearchReciever_Admin.smethod_62("Nothing To Delete");
					num = (int)(num2 * 1714433642) ^ -1562966490;
					continue;
				case 3u:
					flag = SearchReciever_Admin.smethod_74(SearchReciever_Admin.smethod_60(IDTxt), "", bool_0: false) == 0;
					num = ((int)num2 * -1979936735) ^ 0x74B71EE5;
					continue;
				case 1u:
					num = -1679073601;
					continue;
				case 2u:
					break;
				default:
				{
					OleDbCommand val = SearchReciever_Admin.smethod_63();
					string string_ = SearchReciever_Admin.smethod_79("Delete From [Recievers] Where [ID] = ", SearchReciever_Admin.smethod_60(IDTxt), ";");
					SearchReciever_Admin.smethod_66(myconnection);
					try
					{
						while (true)
						{
							int num3 = -1342988734;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xDD078323u) % 5u)
								{
								case 4u:
									val = SearchReciever_Admin.smethod_76(string_, myconnection);
									SearchReciever_Admin.smethod_77(val);
									SearchReciever_Admin.smethod_78((Component)(object)val);
									num3 = ((int)num2 * -1321385965) ^ 0x3331C9E;
									continue;
								case 1u:
									SearchReciever_Admin.smethod_71(myconnection);
									num3 = (int)((num2 * 795607692) ^ 0x400EFC07);
									continue;
								case 0u:
									UpdateTable();
									num3 = (int)((num2 * 6583165) ^ 0x28E1480C);
									continue;
								case 3u:
									break;
								default:
									ClearDonorInfoBox();
									SearchReciever_Admin.smethod_62("Successfully Deleted Entry");
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
							_ = -1661733676;
							while (true)
							{
								_003F val2 = /*Error near IL_0186: Stack underflow*/^ -586710237;
								num2 = (uint)(int)val2;
								switch (val2 % 4)
								{
								case 3:
									_ = ((int)num2 * -1492703019) ^ -2107208383;
									continue;
								case 1:
									SearchReciever_Admin.smethod_71(myconnection);
									_ = ((int)num2 * -853358282) ^ -514008413;
									continue;
								case 0:
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
				case 5u:
					return;
				}
				break;
			}
		}
	}

	private void SearchResultGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected I4, but got Unknown
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected I4, but got Unknown
		//IL_0345: Incompatible stack heights: 0 vs 1
		//IL_034c: Incompatible stack heights: 0 vs 1
		try
		{
			while (true)
			{
				int num = -1832760504;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDFB41C4Eu) % 14u)
					{
					case 12u:
						SearchReciever_Admin.smethod_87(MobileTxt, SearchReciever_Admin.smethod_86(SearchReciever_Admin.smethod_85(SearchReciever_Admin.smethod_84(SearchReciever_Admin.smethod_83(SearchReciever_Admin.smethod_82(SearchReciever_Admin.smethod_80(SearchResultGrid), SearchReciever_Admin.smethod_81(e))), 5))));
						num = (int)(num2 * 493935505) ^ -140887121;
						continue;
					case 11u:
						SearchReciever_Admin.smethod_88(BloodGroupTxt, SearchReciever_Admin.smethod_86(SearchReciever_Admin.smethod_85(SearchReciever_Admin.smethod_84(SearchReciever_Admin.smethod_83(SearchReciever_Admin.smethod_82(SearchReciever_Admin.smethod_80(SearchResultGrid), SearchReciever_Admin.smethod_81(e))), 4))));
						num = (int)(num2 * 496137044) ^ -557671428;
						continue;
					case 10u:
						SearchReciever_Admin.smethod_88(GenderTxt, SearchReciever_Admin.smethod_86(SearchReciever_Admin.smethod_85(SearchReciever_Admin.smethod_84(SearchReciever_Admin.smethod_83(SearchReciever_Admin.smethod_82(SearchReciever_Admin.smethod_80(SearchResultGrid), SearchReciever_Admin.smethod_81(e))), 2))));
						num = ((int)num2 * -1552424971) ^ -184098129;
						continue;
					case 9u:
						num = (int)((num2 * 545798142) ^ 0x3FF856AE);
						continue;
					case 8u:
						num = (int)(num2 * 1416651150) ^ -1719257915;
						continue;
					case 7u:
						SearchReciever_Admin.smethod_43((Control)(object)ClearBtn, bool_0: true);
						num = ((int)num2 * -420602349) ^ -829118028;
						continue;
					case 6u:
						SearchReciever_Admin.smethod_43((Control)(object)UpdateBtn, bool_0: true);
						num = ((int)num2 * -720158399) ^ -743621126;
						continue;
					case 5u:
						SearchReciever_Admin.smethod_87(DOBTxt, SearchReciever_Admin.smethod_86(SearchReciever_Admin.smethod_85(SearchReciever_Admin.smethod_84(SearchReciever_Admin.smethod_83(SearchReciever_Admin.smethod_82(SearchReciever_Admin.smethod_80(SearchResultGrid), SearchReciever_Admin.smethod_81(e))), 3))));
						num = ((int)num2 * -1782539540) ^ 0x2C1BF7AC;
						continue;
					case 4u:
						SearchReciever_Admin.smethod_43((Control)(object)DeleteBtn, bool_0: true);
						num = (int)(num2 * 29425464) ^ -90773827;
						continue;
					case 3u:
						num = ((int)num2 * -1532708859) ^ 0x3F02AFED;
						continue;
					case 2u:
						SearchReciever_Admin.smethod_87(IDTxt, SearchReciever_Admin.smethod_86(SearchReciever_Admin.smethod_85(SearchReciever_Admin.smethod_84(SearchReciever_Admin.smethod_83(SearchReciever_Admin.smethod_82(SearchReciever_Admin.smethod_80(SearchResultGrid), SearchReciever_Admin.smethod_81(e))), 0))));
						SearchReciever_Admin.smethod_87(NameTxt, SearchReciever_Admin.smethod_86(SearchReciever_Admin.smethod_85(SearchReciever_Admin.smethod_84(SearchReciever_Admin.smethod_83(SearchReciever_Admin.smethod_82(SearchReciever_Admin.smethod_80(SearchResultGrid), SearchReciever_Admin.smethod_81(e))), 1))));
						num = ((int)num2 * -1386755624) ^ 0x71977559;
						continue;
					case 1u:
						SearchReciever_Admin.smethod_87(DateRecievedTxt, SearchReciever_Admin.smethod_86(SearchReciever_Admin.smethod_85(SearchReciever_Admin.smethod_84(SearchReciever_Admin.smethod_83(SearchReciever_Admin.smethod_82(SearchReciever_Admin.smethod_80(SearchResultGrid), SearchReciever_Admin.smethod_81(e))), 7))));
						SearchReciever_Admin.smethod_87(QuantityTxt, SearchReciever_Admin.smethod_86(SearchReciever_Admin.smethod_85(SearchReciever_Admin.smethod_84(SearchReciever_Admin.smethod_83(SearchReciever_Admin.smethod_82(SearchReciever_Admin.smethod_80(SearchResultGrid), SearchReciever_Admin.smethod_81(e))), 6))));
						SearchReciever_Admin.smethod_43((Control)(object)RecieverInfoBox, bool_0: true);
						num = (int)(num2 * 829648845) ^ -943925846;
						continue;
					default:
						return;
					case 0u:
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
				_ = -614143422;
				while (true)
				{
					_003F val = /*Error near IL_031c: Stack underflow*/^ -541844402;
					uint num2 = (uint)(int)val;
					switch (val % 3)
					{
					default:
						return;
					case 2:
						SearchReciever_Admin.smethod_73();
						_ = (num2 * 1598875143) ^ 0xCB733E96u;
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

	private void ClearBtn_Click(object sender, EventArgs e)
	{
		ClearDonorInfoBox();
	}

	private bool ClearDonorInfoBox()
	{
		bool result = default(bool);
		while (true)
		{
			int num = -831131964;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC864D97Au) % 15u)
				{
				case 14u:
					result = true;
					num = (int)(num2 * 1958919519) ^ -405616838;
					continue;
				case 13u:
					SearchReciever_Admin.smethod_89((TextBoxBase)(object)IDTxt);
					num = (int)((num2 * 326597482) ^ 0x5B99DE5D);
					continue;
				case 12u:
					SearchReciever_Admin.smethod_89((TextBoxBase)(object)DOBTxt);
					num = ((int)num2 * -1015543075) ^ -1785880558;
					continue;
				case 11u:
					num = (int)((num2 * 1149732921) ^ 0x2C854B79);
					continue;
				case 10u:
					SearchReciever_Admin.smethod_89((TextBoxBase)(object)QuantityTxt);
					num = (int)(num2 * 2072279815) ^ -1733110136;
					continue;
				case 9u:
					SearchReciever_Admin.smethod_89((TextBoxBase)(object)NameTxt);
					SearchReciever_Admin.smethod_89((TextBoxBase)(object)MobileTxt);
					num = ((int)num2 * -596249633) ^ -2122982124;
					continue;
				case 8u:
					SearchReciever_Admin.smethod_90(BloodGroupTxt, -1);
					num = (int)((num2 * 1117851089) ^ 0xC89A1CB);
					continue;
				case 6u:
					num = (int)((num2 * 391463730) ^ 0x52BB3175);
					continue;
				case 5u:
					SearchReciever_Admin.smethod_89((TextBoxBase)(object)DateRecievedTxt);
					SearchReciever_Admin.smethod_90(GenderTxt, -1);
					num = ((int)num2 * -53128349) ^ 0x1B770709;
					continue;
				case 4u:
					num = ((int)num2 * -1626585303) ^ 0x273D796A;
					continue;
				case 3u:
					num = (int)(num2 * 1226703685) ^ -1001687954;
					continue;
				case 2u:
					num = ((int)num2 * -812745142) ^ -1189121186;
					continue;
				case 1u:
					num = ((int)num2 * -127616669) ^ -1890233073;
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

	private bool UpdateTable()
	{
		SearchReciever_Admin.smethod_63();
		string string_ = default(string);
		DataTable dataTable = default(DataTable);
		bool result = default(bool);
		while (true)
		{
			int num = -1308654849;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC6A8BAF6u) % 5u)
				{
				case 3u:
					SearchReciever_Admin.smethod_66(myconnection);
					num = ((int)num2 * -1239646147) ^ -2098819212;
					continue;
				case 1u:
					string_ = SearchReciever_Admin.smethod_64(new string[5] { "Select * From [Recievers] Where [Name] Like '%", name_search, "%' And [Contact Number] Like '%", mobile_search, "%';" });
					num = (int)((num2 * 1186159141) ^ 0x7228C7D);
					continue;
				case 0u:
					dataTable = SearchReciever_Admin.smethod_65();
					num = ((int)num2 * -1123310218) ^ 0xBC46573;
					continue;
				case 2u:
					break;
				default:
					try
					{
						while (true)
						{
							IL_016a:
							int num3 = -1513770476;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xC6A8BAF6u) % 7u)
								{
								case 5u:
									SearchReciever_Admin.smethod_71(myconnection);
									num3 = (int)((num2 * 1043005308) ^ 0xD0EA6B7);
									continue;
								case 4u:
									num3 = (int)(num2 * 2040464174) ^ -179607421;
									continue;
								case 2u:
									num3 = ((int)num2 * -667997621) ^ -1438060513;
									continue;
								case 1u:
								{
									OleDbDataAdapter dbDataAdapter_ = SearchReciever_Admin.smethod_67(string_, myconnection);
									SearchReciever_Admin.smethod_68((DbDataAdapter)(object)dbDataAdapter_, dataTable);
									num3 = ((int)num2 * -1678363599) ^ 0x54259E3A;
									continue;
								}
								case 0u:
									SearchReciever_Admin.smethod_69(SearchResultGrid, (object)dataTable);
									SearchReciever_Admin.smethod_43((Control)(object)SearchResultGrid, bool_0: true);
									num3 = ((int)num2 * -269244930) ^ 0x32CB65CD;
									continue;
								default:
									goto end_IL_013c;
								case 3u:
									break;
								case 6u:
									goto end_IL_013c;
								}
								goto IL_016a;
								continue;
								end_IL_013c:
								break;
							}
							break;
						}
					}
					catch (Exception exception_)
					{
						SearchReciever_Admin.smethod_72(exception_);
						SearchReciever_Admin.smethod_71(myconnection);
						SearchReciever_Admin.smethod_73();
					}
					while (true)
					{
						int num4 = -1172372047;
						while (true)
						{
							switch ((num2 = (uint)num4 ^ 0xC6A8BAF6u) % 3u)
							{
							case 2u:
								goto IL_018c;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_018c:
							result = true;
							num4 = (int)((num2 * 807261785) ^ 0x4511F519);
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
