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
				int num = 755909101;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3EDD462Cu) % 7u)
					{
					case 6u:
						_SearchBtn = value;
						searchBtn = _SearchBtn;
						num = 1516344129;
						continue;
					case 5u:
						UpdateDetails.smethod_52((Control)(object)searchBtn, eventHandler_);
						num = (int)((num2 * 1722006285) ^ 0x274FB3D1);
						continue;
					case 4u:
					{
						int num5;
						int num6;
						if (searchBtn != null)
						{
							num5 = -1345748489;
							num6 = -1345748489;
						}
						else
						{
							num5 = -844153150;
							num6 = -844153150;
						}
						num = num5 ^ (int)(num2 * 1595961021);
						continue;
					}
					case 2u:
					{
						int num3;
						int num4;
						if (searchBtn != null)
						{
							num3 = -234920526;
							num4 = -234920526;
						}
						else
						{
							num3 = -1748044294;
							num4 = -1748044294;
						}
						num = num3 ^ ((int)num2 * -1794612471);
						continue;
					}
					case 1u:
						UpdateDetails.smethod_53((Control)(object)searchBtn, eventHandler_);
						num = (int)((num2 * 451927962) ^ 0x4557B831);
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
				int num = -1941438014;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDB6B3856u) % 7u)
					{
					case 6u:
						UpdateDetails.smethod_54(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = ((int)num2 * -1140646776) ^ 0x690BC7BE;
						continue;
					case 5u:
						_SearchResultGrid = value;
						num = -30572686;
						continue;
					case 4u:
						UpdateDetails.smethod_55(searchResultGrid, dataGridViewCellMouseEventHandler_);
						num = (int)(num2 * 456116003) ^ -1965752523;
						continue;
					case 1u:
					{
						int num5;
						int num6;
						if (searchResultGrid == null)
						{
							num5 = 1031803730;
							num6 = 1031803730;
						}
						else
						{
							num5 = 1210551;
							num6 = 1210551;
						}
						num = num5 ^ ((int)num2 * -749739267);
						continue;
					}
					case 0u:
					{
						searchResultGrid = _SearchResultGrid;
						int num3;
						int num4;
						if (searchResultGrid != null)
						{
							num3 = -2135071194;
							num4 = -2135071194;
						}
						else
						{
							num3 = -780025907;
							num4 = -780025907;
						}
						num = num3 ^ ((int)num2 * -638810485);
						continue;
					}
					default:
						return;
					case 3u:
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
			if (updateBtn != null)
			{
				goto IL_0040;
			}
			goto IL_009a;
			IL_009a:
			_UpdateBtn = value;
			updateBtn = _UpdateBtn;
			int num = -1293568771;
			goto IL_0071;
			IL_0071:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFE821549u) % 6u)
				{
				case 4u:
				{
					int num3;
					int num4;
					if (updateBtn != null)
					{
						num3 = -896255209;
						num4 = -896255209;
					}
					else
					{
						num3 = -822516114;
						num4 = -822516114;
					}
					num = num3 ^ ((int)num2 * -65917172);
					continue;
				}
				case 2u:
					break;
				case 1u:
					UpdateDetails.smethod_52((Control)(object)updateBtn, eventHandler_);
					num = (int)((num2 * 127191223) ^ 0x7EDCE677);
					continue;
				case 0u:
					UpdateDetails.smethod_53((Control)(object)updateBtn, eventHandler_);
					num = ((int)num2 * -1371479717) ^ 0x6C053E44;
					continue;
				default:
					return;
				case 5u:
					goto IL_009a;
				case 3u:
					return;
				}
				break;
			}
			goto IL_0040;
			IL_0040:
			num = -895067258;
			goto IL_0071;
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
				int num = 516852919;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x14348C62u) % 7u)
					{
					case 5u:
						UpdateDetails.smethod_52((Control)(object)clearBtn, eventHandler_);
						num = (int)((num2 * 1600025914) ^ 0x5761C86);
						continue;
					case 4u:
						_ClearBtn = value;
						clearBtn = _ClearBtn;
						num = 859635279;
						continue;
					case 3u:
					{
						int num5;
						int num6;
						if (clearBtn != null)
						{
							num5 = 755070481;
							num6 = 755070481;
						}
						else
						{
							num5 = 1677276695;
							num6 = 1677276695;
						}
						num = num5 ^ (int)(num2 * 1932670320);
						continue;
					}
					case 2u:
					{
						clearBtn = _ClearBtn;
						int num3;
						int num4;
						if (clearBtn == null)
						{
							num3 = -523263151;
							num4 = -523263151;
						}
						else
						{
							num3 = -235677894;
							num4 = -235677894;
						}
						num = num3 ^ ((int)num2 * -203831375);
						continue;
					}
					case 1u:
						UpdateDetails.smethod_53((Control)(object)clearBtn, eventHandler_);
						num = (int)(num2 * 2077594045) ^ -1069794736;
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

	public UpdateDetails()
	{
		while (true)
		{
			int num = -1196373721;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8605A717u) % 7u)
				{
				case 5u:
					UpdateDetails.smethod_0((UserControl)(object)this, (EventHandler)UpdateDetails_Load);
					num = (int)(num2 * 1590424655) ^ -1740849995;
					continue;
				case 3u:
					num = ((int)num2 * -1731344813) ^ 0x1BE35ABB;
					continue;
				case 2u:
					num = (int)(num2 * 1109257583) ^ -1887874740;
					continue;
				case 1u:
					InitializeComponent();
					num = (int)((num2 * 2143517653) ^ 0x44009757);
					continue;
				case 0u:
					myconnection = UpdateDetails.smethod_1();
					num = ((int)num2 * -1307188459) ^ 0x53D5A0D4;
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

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (!disposing)
			{
				goto IL_0007;
			}
			goto IL_002e;
			IL_002e:
			int num = 1476119003;
			goto IL_0033;
			IL_0033:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x71EC52BCu) % 4u)
				{
				case 2u:
					UpdateDetails.smethod_2((IDisposable)components);
					num = ((int)num2 * -1302615836) ^ -305581191;
					continue;
				case 0u:
					break;
				default:
					return;
				case 3u:
					goto IL_0054;
				case 1u:
					return;
				}
				break;
				IL_0054:
				if (components != null)
				{
					num = 1551738642;
					num3 = 1551738642;
					continue;
				}
				goto IL_0007;
			}
			goto IL_002e;
			IL_0007:
			num = 1574686081;
			num3 = 1574686081;
			goto IL_0033;
		}
		finally
		{
			((ContainerControl)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		Label1 = UpdateDetails.smethod_3();
		GroupBox1 = UpdateDetails.smethod_4();
		while (true)
		{
			int num = 935064705;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x35B43FB0u) % 273u)
				{
				case 272u:
					UpdateDetails.smethod_16((Control)(object)Label4, "Label4");
					num = ((int)num2 * -1947619628) ^ -590665613;
					continue;
				case 271u:
					num = (int)((num2 * 674852304) ^ 0x5471B1BF);
					continue;
				case 269u:
					UpdateDetails.smethod_34(UpdateDetails.smethod_33(SearchResultGrid), 24);
					num = ((int)num2 * -1129428404) ^ -1771564871;
					continue;
				case 268u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)Label6);
					num = ((int)num2 * -1005485341) ^ 0x1189E03D;
					continue;
				case 267u:
					UpdateDetails.smethod_17((Control)(object)NameTxt, new Size(244, 28));
					num = ((int)num2 * -202838408) ^ -38578155;
					continue;
				case 266u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_44((Control)(object)this), (Control)(object)GroupBox1);
					num = ((int)num2 * -1158334902) ^ -412691576;
					continue;
				case 265u:
					num = ((int)num2 * -1586362243) ^ 0x27217E66;
					continue;
				case 264u:
					UpdateDetails.smethod_29((ButtonBase)(object)SearchBtn, bool_0: false);
					num = (int)((num2 * 1190253442) ^ 0x4D17807D);
					continue;
				case 263u:
					UpdateDetails.smethod_20(Label3, (ContentAlignment)32);
					num = ((int)num2 * -1479684348) ^ 0x33141A3A;
					continue;
				case 262u:
					num = (int)((num2 * 640773879) ^ 0x2E9FD2E8);
					continue;
				case 261u:
					UpdateDetails.smethod_18((Control)(object)PatientInfoBox, 8);
					num = ((int)num2 * -2013832860) ^ 0x631DE918;
					continue;
				case 260u:
					UpdateDetails.smethod_35((TextBoxBase)(object)GenderTxt, bool_0: true);
					UpdateDetails.smethod_17((Control)(object)GenderTxt, new Size(131, 28));
					num = ((int)num2 * -2049694968) ^ 0x47AA85DB;
					continue;
				case 259u:
					UpdateDetails.smethod_17((Control)(object)Label7, new Size(98, 26));
					num = (int)((num2 * 353016750) ^ 0x53D07D06);
					continue;
				case 258u:
					UpdateDetails.smethod_18((Control)(object)MobileTxt, 12);
					num = ((int)num2 * -593093127) ^ 0x3A10D0DF;
					continue;
				case 257u:
					UpdateDetails.smethod_18((Control)(object)DOBTxt, 5);
					num = ((int)num2 * -121173465) ^ -716959646;
					continue;
				case 256u:
					UpdateDetails.smethod_18((Control)(object)Label8, 9);
					num = ((int)num2 * -2129396580) ^ -961521784;
					continue;
				case 255u:
					num = ((int)num2 * -381771581) ^ -1128949398;
					continue;
				case 254u:
					num = (int)(num2 * 1090236285) ^ -601668453;
					continue;
				case 253u:
					UpdateDetails.smethod_9((Control)(object)PatientInfoBox);
					num = (int)(num2 * 1728876683) ^ -164486228;
					continue;
				case 252u:
					num = (int)((num2 * 1954487622) ^ 0x158B15D4);
					continue;
				case 251u:
					Label2 = UpdateDetails.smethod_3();
					num = (int)((num2 * 494429105) ^ 0x40C3787C);
					continue;
				case 250u:
					num = (int)((num2 * 586749114) ^ 0x68E12F25);
					continue;
				case 249u:
					UpdateDetails.smethod_17((Control)(object)PatientInfoBox, new Size(623, 292));
					num = ((int)num2 * -1097200948) ^ -382128993;
					continue;
				case 248u:
					UpdateDetails.smethod_14((Control)(object)ClearBtn, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -589187041) ^ 0x7E34E9A5;
					continue;
				case 247u:
					UpdateDetails.smethod_18((Control)(object)ClearBtn, 10);
					num = (int)(num2 * 267127238) ^ -417734786;
					continue;
				case 246u:
					Label6 = UpdateDetails.smethod_3();
					Label5 = UpdateDetails.smethod_3();
					num = (int)(num2 * 1373992912) ^ -935481166;
					continue;
				case 245u:
					num = (int)(num2 * 603246877) ^ -622136690;
					continue;
				case 244u:
					num = ((int)num2 * -731854546) ^ 0x4E89458E;
					continue;
				case 243u:
					UpdateDetails.smethod_17((Control)(object)PIDTxt, new Size(100, 28));
					num = (int)(num2 * 1395585522) ^ -1797547398;
					continue;
				case 242u:
					UpdateDetails.smethod_45((Control)(object)this, "UpdateDetails");
					num = ((int)num2 * -462479327) ^ 0x1EA2DEC7;
					continue;
				case 241u:
					UpdateDetails.smethod_16((Control)(object)ClearBtn, "ClearBtn");
					num = ((int)num2 * -1292193482) ^ -1256819451;
					continue;
				case 240u:
					UpdateDetails.smethod_15((Control)(object)GenderTxt, new Point(473, 125));
					num = ((int)num2 * -592360071) ^ -1132890087;
					continue;
				case 239u:
					num = ((int)num2 * -1851215013) ^ -799186917;
					continue;
				case 238u:
					UpdateDetails.smethod_20(Label2, (ContentAlignment)32);
					num = (int)(num2 * 677768834) ^ -2115389042;
					continue;
				case 237u:
					num = (int)(num2 * 522131002) ^ -745096330;
					continue;
				case 236u:
					UpdateDetails.smethod_17((Control)(object)DOBTxt, new Size(147, 28));
					num = (int)((num2 * 1703282351) ^ 0x23569DA6);
					continue;
				case 235u:
					UpdateDetails.smethod_30(SearchResultGrid, Color.White);
					num = (int)(num2 * 638023109) ^ -1291162916;
					continue;
				case 234u:
					UpdateDetails.smethod_15((Control)(object)PIDTxt, new Point(124, 43));
					UpdateDetails.smethod_16((Control)(object)PIDTxt, "PIDTxt");
					num = ((int)num2 * -1943314979) ^ 0x61CA10E8;
					continue;
				case 233u:
					num = ((int)num2 * -1650279247) ^ 0x4E26CAF8;
					continue;
				case 232u:
					UpdateDetails.smethod_35((TextBoxBase)(object)NameTxt, bool_0: true);
					num = ((int)num2 * -126294029) ^ 0x7BFE8C8D;
					continue;
				case 231u:
					UpdateDetails.smethod_15((Control)(object)Label6, new Point(383, 132));
					num = (int)((num2 * 68567688) ^ 0x12D9C3F8);
					continue;
				case 230u:
					Label3 = UpdateDetails.smethod_3();
					num = (int)((num2 * 1995417395) ^ 0x5437091);
					continue;
				case 229u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)GroupBox1), (Control)(object)MobileSTxt);
					num = ((int)num2 * -1688089161) ^ 0x18B887B1;
					continue;
				case 228u:
					UpdateDetails.smethod_14((Control)(object)Label3, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1601635802) ^ -2045805044;
					continue;
				case 227u:
					UpdateDetails.smethod_27((Control)(object)UpdateBtn, UpdateDetails.smethod_26());
					UpdateDetails.smethod_15((Control)(object)UpdateBtn, new Point(779, 563));
					num = (int)(num2 * 120819390) ^ -2032964978;
					continue;
				case 226u:
					UpdateDetails.smethod_51((Control)(object)this);
					num = (int)(num2 * 2075191819) ^ -1831266208;
					continue;
				case 225u:
					UpdateDetails.smethod_18((Control)(object)SearchResultGrid, 7);
					num = ((int)num2 * -965614781) ^ 0x1C56B195;
					continue;
				case 224u:
					UpdateDetails.smethod_14((Control)(object)Label1, UpdateDetails.smethod_13("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					UpdateDetails.smethod_15((Control)(object)Label1, new Point(392, 63));
					num = ((int)num2 * -1969486058) ^ 0x186E78C2;
					continue;
				case 223u:
					num = (int)((num2 * 524100451) ^ 0x3B30CBD);
					continue;
				case 222u:
					UpdateDetails.smethod_16((Control)(object)MobileTxt, "MobileTxt");
					num = ((int)num2 * -754862107) ^ -1370067364;
					continue;
				case 221u:
					UpdateDetails.smethod_19(Label1, "Update Details ");
					num = (int)((num2 * 2022651843) ^ 0x2F4F3321);
					continue;
				case 220u:
					UpdateDetails.smethod_28((ButtonBase)(object)SearchBtn, "Search");
					num = (int)(num2 * 329595085) ^ -2061859615;
					continue;
				case 219u:
					num = (int)(num2 * 723256896) ^ -528571198;
					continue;
				case 218u:
					num = ((int)num2 * -661899314) ^ -1229434376;
					continue;
				case 217u:
					Label4 = UpdateDetails.smethod_3();
					num = ((int)num2 * -503249425) ^ -351286236;
					continue;
				case 216u:
					num = ((int)num2 * -408445815) ^ -56597032;
					continue;
				case 215u:
					num = ((int)num2 * -1821860765) ^ -2088877859;
					continue;
				case 214u:
					UpdateDetails.smethod_18((Control)(object)Label2, 0);
					UpdateDetails.smethod_19(Label2, "Name : ");
					num = ((int)num2 * -1926734373) ^ -418407564;
					continue;
				case 213u:
					num = ((int)num2 * -683607642) ^ -1273463508;
					continue;
				case 212u:
					num = ((int)num2 * -265375543) ^ 0x145D0971;
					continue;
				case 211u:
					num = ((int)num2 * -856686449) ^ 0x5CEA648F;
					continue;
				case 210u:
					UpdateDetails.smethod_25((ButtonBase)(object)UpdateBtn, Color.MidnightBlue);
					num = ((int)num2 * -1040644931) ^ 0x3094B157;
					continue;
				case 209u:
					UpdateDetails.smethod_15((Control)(object)Label2, new Point(37, 44));
					num = ((int)num2 * -1640936436) ^ -647411274;
					continue;
				case 208u:
					UpdateDetails.smethod_42((ContainerControl)(object)this, (AutoScaleMode)1);
					UpdateDetails.smethod_43((Control)(object)this, Color.White);
					num = ((int)num2 * -1747113771) ^ 0x9AAF31C;
					continue;
				case 207u:
					num = ((int)num2 * -597278388) ^ 0x64AC57C4;
					continue;
				case 206u:
					UpdateDetails.smethod_18((Control)(object)SearchBtn, 4);
					num = ((int)num2 * -648731497) ^ -1038227115;
					continue;
				case 204u:
					num = ((int)num2 * -1771037135) ^ 0x40091607;
					continue;
				case 203u:
					UpdateDetails.smethod_18((Control)(object)MobileSTxt, 2);
					num = (int)((num2 * 203838071) ^ 0x4F117253);
					continue;
				case 202u:
					UpdateDetails.smethod_18((Control)(object)UpdateBtn, 9);
					num = ((int)num2 * -1917840009) ^ 0x2E758995;
					continue;
				case 201u:
					Label8 = UpdateDetails.smethod_3();
					num = (int)(num2 * 860631492) ^ -535052609;
					continue;
				case 200u:
					num = ((int)num2 * -1454151622) ^ 0x664739EF;
					continue;
				case 199u:
					UpdateDetails.smethod_38(PictureBox1, (PictureBoxSizeMode)1);
					num = ((int)num2 * -2105775015) ^ 0x288B0C0A;
					continue;
				case 198u:
					num = (int)((num2 * 562923274) ^ 0x149AEBC0);
					continue;
				case 197u:
					UpdateDetails.smethod_18((Control)(object)Label9, 11);
					num = ((int)num2 * -494822125) ^ -2016203114;
					continue;
				case 196u:
					UpdateDetails.smethod_17((Control)(object)Label6, new Size(84, 26));
					num = ((int)num2 * -1851030782) ^ 0x335C311F;
					continue;
				case 195u:
					num = (int)((num2 * 1621432422) ^ 0x2B6C159C);
					continue;
				case 194u:
					num = ((int)num2 * -962332133) ^ -2065188926;
					continue;
				case 193u:
					num = (int)((num2 * 847721283) ^ 0x18FF289C);
					continue;
				case 192u:
					PictureBox1 = UpdateDetails.smethod_8();
					UpdateDetails.smethod_9((Control)(object)GroupBox1);
					num = ((int)num2 * -371497750) ^ 0x41316DF4;
					continue;
				case 191u:
					UpdateDetails.smethod_18((Control)(object)NameTxt, 10);
					UpdateDetails.smethod_14((Control)(object)Label8, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1538507481) ^ 0x36BFEA9F);
					continue;
				case 190u:
					num = ((int)num2 * -1127693017) ^ -1152039830;
					continue;
				case 189u:
					UpdateDetails.smethod_24(PatientInfoBox, "Patient Information");
					num = ((int)num2 * -486990328) ^ -656742930;
					continue;
				case 188u:
					num = (int)(num2 * 128817658) ^ -1059141723;
					continue;
				case 187u:
					UpdateDetails.smethod_18((Control)(object)Label7, 3);
					num = ((int)num2 * -1179540291) ^ 0x2893D064;
					continue;
				case 186u:
					UpdateDetails.smethod_12(Label1, bool_0: true);
					num = (int)((num2 * 841125448) ^ 0x53898334);
					continue;
				case 185u:
					UpdateDetails.smethod_31(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					num = ((int)num2 * -1069642230) ^ -1201427823;
					continue;
				case 184u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_44((Control)(object)this), (Control)(object)PictureBox1);
					num = ((int)num2 * -471688589) ^ -396176730;
					continue;
				case 183u:
					UpdateDetails.smethod_16((Control)(object)Label3, "Label3");
					num = ((int)num2 * -324144768) ^ -1298404226;
					continue;
				case 182u:
					UpdateDetails.smethod_15((Control)(object)Label7, new Point(20, 182));
					num = (int)((num2 * 1661974616) ^ 0x507328E);
					continue;
				case 181u:
					UpdateDetails.smethod_16((Control)(object)Label7, "Label7");
					num = ((int)num2 * -1220923052) ^ -134950909;
					continue;
				case 180u:
					UpdateDetails.smethod_17((Control)(object)PictureBox1, new Size(126, 122));
					num = (int)((num2 * 1301501278) ^ 0x1A7EE498);
					continue;
				case 179u:
					UpdateDetails.smethod_16((Control)(object)SearchBtn, "SearchBtn");
					num = (int)(num2 * 2053774740) ^ -1272472141;
					continue;
				case 178u:
					UpdateDetails.smethod_25((ButtonBase)(object)SearchBtn, Color.MidnightBlue);
					num = (int)((num2 * 686151208) ^ 0x21A8B144);
					continue;
				case 177u:
					UpdateDetails.smethod_18((Control)(object)AddressTxt, 7);
					num = ((int)num2 * -1142310012) ^ 0x3C309DC3;
					continue;
				case 176u:
					num = ((int)num2 * -1089639065) ^ 0x3594ADC3;
					continue;
				case 175u:
					UpdateDetails.smethod_17((Control)(object)Label4, new Size(68, 25));
					num = ((int)num2 * -292291867) ^ -1558067923;
					continue;
				case 174u:
					UpdateDetails.smethod_17((Control)(object)MobileSTxt, new Size(237, 28));
					num = ((int)num2 * -201491389) ^ 0x5F18882D;
					continue;
				case 173u:
					UpdateDetails.smethod_16((Control)(object)Label1, "Label1");
					UpdateDetails.smethod_17((Control)(object)Label1, new Size(250, 35));
					UpdateDetails.smethod_18((Control)(object)Label1, 4);
					num = (int)(num2 * 1257604315) ^ -440525530;
					continue;
				case 172u:
					UpdateDetails.smethod_50((Control)(object)this, bool_0: false);
					num = (int)(num2 * 2057401398) ^ -1233840667;
					continue;
				case 171u:
					UpdateDetails.smethod_17((Control)(object)UpdateBtn, new Size(133, 37));
					num = (int)(num2 * 1746516359) ^ -1925441336;
					continue;
				case 170u:
					UpdateDetails.smethod_18((Control)(object)Label6, 2);
					num = (int)(num2 * 1037201139) ^ -1547903718;
					continue;
				case 169u:
					num = ((int)num2 * -1485567162) ^ 0x2FBA2AE0;
					continue;
				case 168u:
					num = ((int)num2 * -1629446495) ^ -623429365;
					continue;
				case 167u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)MobileTxt);
					num = (int)((num2 * 1541863018) ^ 0x6B49AC8D);
					continue;
				case 166u:
					UpdateDetails.smethod_16((Control)(object)SearchResultGrid, "SearchResultGrid");
					UpdateDetails.smethod_32(SearchResultGrid, bool_0: true);
					num = (int)((num2 * 273475466) ^ 0x75316659);
					continue;
				case 165u:
					num = ((int)num2 * -1485470303) ^ -1256498628;
					continue;
				case 164u:
					UpdateBtn = UpdateDetails.smethod_5();
					num = (int)(num2 * 445500826) ^ -784007652;
					continue;
				case 163u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_44((Control)(object)this), (Control)(object)UpdateBtn);
					num = ((int)num2 * -2102794652) ^ -1850929164;
					continue;
				case 162u:
					UpdateDetails.smethod_14((Control)(object)Label9, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 452921117) ^ -409466101;
					continue;
				case 161u:
					UpdateDetails.smethod_15((Control)(object)Label4, new Point(20, 46));
					num = ((int)num2 * -2112176468) ^ 0x52329F2B;
					continue;
				case 160u:
					DOBTxt = UpdateDetails.smethod_6();
					num = ((int)num2 * -393266520) ^ -904683093;
					continue;
				case 159u:
					PatientInfoBox = UpdateDetails.smethod_4();
					num = ((int)num2 * -1064292806) ^ 0x2BC7F127;
					continue;
				case 158u:
					UpdateDetails.smethod_16((Control)(object)AddressTxt, "AddressTxt");
					num = (int)(num2 * 2023231348) ^ -718982320;
					continue;
				case 157u:
					UpdateDetails.smethod_27((Control)(object)SearchBtn, UpdateDetails.smethod_26());
					num = ((int)num2 * -2045516833) ^ 0x72B5DAB;
					continue;
				case 156u:
					UpdateDetails.smethod_37(PictureBox1, (Image)(object)Resources.useless_pic);
					num = (int)((num2 * 1331879208) ^ 0x113EA6D1);
					continue;
				case 155u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)Label5);
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)Label4);
					num = ((int)num2 * -1204782409) ^ -579307238;
					continue;
				case 154u:
					num = ((int)num2 * -1182634143) ^ 0x333FB216;
					continue;
				case 153u:
					UpdateDetails.smethod_20(Label9, (ContentAlignment)32);
					UpdateDetails.smethod_15((Control)(object)NameTxt, new Point(124, 92));
					num = (int)((num2 * 416665635) ^ 0x1C2ECDAF);
					continue;
				case 152u:
					num = ((int)num2 * -812628758) ^ -1690004494;
					continue;
				case 151u:
					num = ((int)num2 * -1158640935) ^ 0x2EB332BF;
					continue;
				case 150u:
					UpdateDetails.smethod_15((Control)(object)AddressTxt, new Point(124, 182));
					num = (int)((num2 * 1747946697) ^ 0x7A81722A);
					continue;
				case 149u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)GroupBox1), (Control)(object)NameSTxt);
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)GroupBox1), (Control)(object)Label2);
					num = (int)(num2 * 282700745) ^ -117732672;
					continue;
				case 148u:
					UpdateDetails.smethod_17((Control)(object)AddressTxt, new Size(480, 90));
					num = ((int)num2 * -1283504596) ^ 0x45977E28;
					continue;
				case 147u:
					UpdateDetails.smethod_48((Control)(object)GroupBox1);
					num = ((int)num2 * -1747165972) ^ 0x794A90D9;
					continue;
				case 146u:
					UpdateDetails.smethod_23(GroupBox1, bool_0: false);
					num = ((int)num2 * -1532598704) ^ -1957348410;
					continue;
				case 145u:
					UpdateDetails.smethod_16((Control)(object)NameTxt, "NameTxt");
					num = (int)((num2 * 312738181) ^ 0x6B81071F);
					continue;
				case 144u:
					UpdateDetails.smethod_16((Control)(object)MobileSTxt, "MobileSTxt");
					num = ((int)num2 * -195894705) ^ 0x18C2BA14;
					continue;
				case 143u:
					UpdateDetails.smethod_14((Control)(object)UpdateBtn, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1452703858) ^ 0x5DA467EA;
					continue;
				case 142u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_44((Control)(object)this), (Control)(object)SearchResultGrid);
					num = (int)((num2 * 1445007489) ^ 0x296EB5AF);
					continue;
				case 141u:
					num = (int)((num2 * 1374434875) ^ 0x4A4F4671);
					continue;
				case 140u:
					num = (int)(num2 * 921539325) ^ -1781468050;
					continue;
				case 139u:
					num = ((int)num2 * -153326326) ^ 0x294FBE5B;
					continue;
				case 138u:
					num = (int)((num2 * 339495132) ^ 0x7C5C89BD);
					continue;
				case 137u:
					UpdateDetails.smethod_18((Control)(object)Label4, 0);
					num = (int)(num2 * 915458413) ^ -1670526065;
					continue;
				case 136u:
					num = ((int)num2 * -1923164195) ^ 0x4E905308;
					continue;
				case 135u:
					UpdateDetails.smethod_15((Control)(object)Label5, new Point(383, 93));
					num = ((int)num2 * -826122028) ^ 0x7D045243;
					continue;
				case 134u:
					UpdateDetails.smethod_15((Control)(object)PatientInfoBox, new Point(108, 480));
					num = ((int)num2 * -1427440501) ^ -321904640;
					continue;
				case 133u:
					num = ((int)num2 * -1346785794) ^ -1524294209;
					continue;
				case 132u:
					UpdateDetails.smethod_18((Control)(object)GroupBox1, 6);
					num = ((int)num2 * -1438804647) ^ 0x528806A4;
					continue;
				case 131u:
					num = (int)((num2 * 1994680368) ^ 0x336A15C);
					continue;
				case 130u:
					UpdateDetails.smethod_16((Control)(object)PictureBox1, "PictureBox1");
					num = ((int)num2 * -498661815) ^ 0x125C2259;
					continue;
				case 129u:
					num = ((int)num2 * -84844546) ^ 0x185D3CF0;
					continue;
				case 128u:
					UpdateDetails.smethod_49((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -91001658) ^ 0x3A1743F1;
					continue;
				case 127u:
					UpdateDetails.smethod_15((Control)(object)Label3, new Point(37, 87));
					num = (int)(num2 * 1438791529) ^ -546922445;
					continue;
				case 126u:
					UpdateDetails.smethod_16((Control)(object)Label2, "Label2");
					num = (int)((num2 * 1184967028) ^ 0x6B841B83);
					continue;
				case 125u:
					UpdateDetails.smethod_19(Label4, "PID :");
					num = ((int)num2 * -265445255) ^ 0x5DDC7165;
					continue;
				case 124u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_44((Control)(object)this), (Control)(object)ClearBtn);
					num = (int)(num2 * 1456304902) ^ -826131492;
					continue;
				case 123u:
					UpdateDetails.smethod_10((ISupportInitialize)PictureBox1);
					UpdateDetails.smethod_11((Control)(object)this);
					num = ((int)num2 * -709247870) ^ -2026216491;
					continue;
				case 122u:
					GenderTxt = UpdateDetails.smethod_6();
					num = (int)((num2 * 1800402766) ^ 0x21D253F2);
					continue;
				case 121u:
					UpdateDetails.smethod_15((Control)(object)MobileSTxt, new Point(120, 94));
					num = (int)((num2 * 1261262522) ^ 0x287F62CE);
					continue;
				case 120u:
					num = (int)(num2 * 1544038863) ^ -1248278300;
					continue;
				case 119u:
					UpdateDetails.smethod_19(Label5, "DOB :");
					num = (int)(num2 * 89672703) ^ -2007335492;
					continue;
				case 118u:
					UpdateDetails.smethod_48((Control)(object)PatientInfoBox);
					num = ((int)num2 * -310751142) ^ -26003963;
					continue;
				case 117u:
					UpdateDetails.smethod_15((Control)(object)GroupBox1, new Point(155, 150));
					num = (int)((num2 * 1226494364) ^ 0x40CF91FB);
					continue;
				case 116u:
					SearchBtn = UpdateDetails.smethod_5();
					num = ((int)num2 * -853355505) ^ 0x3038C8EB;
					continue;
				case 115u:
					UpdateDetails.smethod_16((Control)(object)UpdateBtn, "UpdateBtn");
					num = (int)(num2 * 19181647) ^ -412933633;
					continue;
				case 114u:
					num = ((int)num2 * -2012338953) ^ -1496983112;
					continue;
				case 113u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_44((Control)(object)this), (Control)(object)PatientInfoBox);
					num = ((int)num2 * -702966002) ^ 0x72D16B11;
					continue;
				case 112u:
					UpdateDetails.smethod_15((Control)(object)SearchResultGrid, new Point(59, 295));
					num = (int)((num2 * 1771847992) ^ 0x5B71E454);
					continue;
				case 111u:
					num = (int)((num2 * 485869814) ^ 0x472556A6);
					continue;
				case 110u:
					ClearBtn = UpdateDetails.smethod_5();
					num = ((int)num2 * -1786463884) ^ -2068962820;
					continue;
				case 109u:
					num = (int)(num2 * 1310735124) ^ -1110447358;
					continue;
				case 108u:
					UpdateDetails.smethod_14((Control)(object)PatientInfoBox, UpdateDetails.smethod_13("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 352303183) ^ -1552196480;
					continue;
				case 107u:
					num = ((int)num2 * -1766553430) ^ 0x7C074490;
					continue;
				case 106u:
					UpdateDetails.smethod_15((Control)(object)NameSTxt, new Point(120, 44));
					num = ((int)num2 * -1333892555) ^ 0x61482D80;
					continue;
				case 105u:
					MobileSTxt = UpdateDetails.smethod_6();
					num = ((int)num2 * -686103382) ^ 0x17F806A8;
					continue;
				case 104u:
					UpdateDetails.smethod_15((Control)(object)Label9, new Point(20, 132));
					num = ((int)num2 * -1552261736) ^ -939012725;
					continue;
				case 103u:
					UpdateDetails.smethod_28((ButtonBase)(object)ClearBtn, "Clear");
					UpdateDetails.smethod_29((ButtonBase)(object)ClearBtn, bool_0: false);
					num = (int)(num2 * 1531978616) ^ -2145375622;
					continue;
				case 102u:
					UpdateDetails.smethod_18((Control)(object)PIDTxt, 4);
					num = ((int)num2 * -1569694700) ^ 0x3BC8609F;
					continue;
				case 101u:
					UpdateDetails.smethod_19(Label7, "Address : ");
					num = (int)((num2 * 949371622) ^ 0x630BAB58);
					continue;
				case 100u:
					UpdateDetails.smethod_14((Control)(object)SearchBtn, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 2113218049) ^ -748808154;
					continue;
				case 99u:
					UpdateDetails.smethod_17((Control)(object)SearchBtn, new Size(133, 37));
					num = ((int)num2 * -1713231347) ^ 0x7A1594E9;
					continue;
				case 98u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_44((Control)(object)this), (Control)(object)Label1);
					num = ((int)num2 * -1646594993) ^ -1106606351;
					continue;
				case 97u:
					UpdateDetails.smethod_20(Label1, (ContentAlignment)32);
					num = ((int)num2 * -541806358) ^ -20647222;
					continue;
				case 96u:
					MobileTxt = UpdateDetails.smethod_6();
					num = (int)((num2 * 1541044844) ^ 0x1EF157C7);
					continue;
				case 95u:
					num = ((int)num2 * -305997920) ^ -79778799;
					continue;
				case 94u:
					UpdateDetails.smethod_16((Control)(object)GenderTxt, "GenderTxt");
					num = (int)(num2 * 2023041321) ^ -1435251081;
					continue;
				case 93u:
					UpdateDetails.smethod_14((Control)(object)Label4, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1199012219) ^ 0x2DB90103;
					continue;
				case 92u:
					UpdateDetails.smethod_18((Control)(object)NameSTxt, 1);
					UpdateDetails.smethod_14((Control)(object)Label2, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 267203978) ^ 0x24CBAF51);
					continue;
				case 91u:
					num = ((int)num2 * -567217220) ^ -1546636453;
					continue;
				case 90u:
					num = (int)((num2 * 771857318) ^ 0x25F3745);
					continue;
				case 89u:
					num = (int)((num2 * 900928867) ^ 0x5DF0F1F);
					continue;
				case 88u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)GroupBox1), (Control)(object)SearchBtn);
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)GroupBox1), (Control)(object)Label3);
					num = ((int)num2 * -2146530282) ^ -1547236102;
					continue;
				case 87u:
					UpdateDetails.smethod_49((ISupportInitialize)SearchResultGrid);
					UpdateDetails.smethod_47((Control)(object)PatientInfoBox, bool_0: false);
					num = ((int)num2 * -1197025980) ^ -2068159556;
					continue;
				case 86u:
					UpdateDetails.smethod_16((Control)(object)Label8, "Label8");
					num = (int)((num2 * 1065522290) ^ 0x4AC78BDB);
					continue;
				case 85u:
					SearchResultGrid = UpdateDetails.smethod_7();
					num = ((int)num2 * -1107264051) ^ -450705797;
					continue;
				case 84u:
					PIDTxt = UpdateDetails.smethod_6();
					num = ((int)num2 * -141171600) ^ -209996575;
					continue;
				case 83u:
					UpdateDetails.smethod_16((Control)(object)Label5, "Label5");
					num = (int)((num2 * 633103062) ^ 0xED626EA);
					continue;
				case 82u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)AddressTxt);
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)GenderTxt);
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)DOBTxt);
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)PIDTxt);
					num = (int)(num2 * 1399063369) ^ -1608487392;
					continue;
				case 81u:
					num = ((int)num2 * -2030141974) ^ -177725424;
					continue;
				case 80u:
					Label7 = UpdateDetails.smethod_3();
					num = (int)(num2 * 1726634465) ^ -1678352741;
					continue;
				case 79u:
					num = (int)((num2 * 68592799) ^ 0x1CAFA1D6);
					continue;
				case 78u:
					UpdateDetails.smethod_17((Control)(object)MobileTxt, new Size(244, 28));
					num = ((int)num2 * -59302679) ^ -1524782656;
					continue;
				case 77u:
					num = ((int)num2 * -1333909021) ^ 0x3807DC0C;
					continue;
				case 76u:
					num = (int)(num2 * 1427542232) ^ -652598520;
					continue;
				case 75u:
					UpdateDetails.smethod_16((Control)(object)GroupBox1, "GroupBox1");
					num = ((int)num2 * -638958743) ^ 0x676FA056;
					continue;
				case 74u:
					num = ((int)num2 * -227228716) ^ 0x3AE6574D;
					continue;
				case 73u:
					UpdateDetails.smethod_24(GroupBox1, "Search Patient");
					num = ((int)num2 * -136472287) ^ 0x1A32FF2C;
					continue;
				case 72u:
					Label9 = UpdateDetails.smethod_3();
					NameTxt = UpdateDetails.smethod_6();
					num = ((int)num2 * -28933489) ^ 0x2A73FFAF;
					continue;
				case 71u:
					UpdateDetails.smethod_39(PictureBox1, 3);
					num = (int)((num2 * 500097964) ^ 0x7E09DF08);
					continue;
				case 70u:
					UpdateDetails.smethod_16((Control)(object)Label6, "Label6");
					num = ((int)num2 * -579980486) ^ 0x38F71A28;
					continue;
				case 69u:
					num = (int)(num2 * 375758404) ^ -1948165819;
					continue;
				case 68u:
					UpdateDetails.smethod_15((Control)(object)MobileTxt, new Point(124, 132));
					num = ((int)num2 * -1234261419) ^ 0x7B74B8A5;
					continue;
				case 67u:
					UpdateDetails.smethod_17((Control)(object)Label3, new Size(77, 28));
					UpdateDetails.smethod_18((Control)(object)Label3, 3);
					num = (int)(num2 * 1462281070) ^ -1372566420;
					continue;
				case 66u:
					UpdateDetails.smethod_14((Control)(object)Label5, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1644925370) ^ 0x3CD4E631;
					continue;
				case 65u:
					num = ((int)num2 * -1026197260) ^ -1760886257;
					continue;
				case 64u:
					UpdateDetails.smethod_16((Control)(object)DOBTxt, "DOBTxt");
					UpdateDetails.smethod_35((TextBoxBase)(object)DOBTxt, bool_0: true);
					num = (int)(num2 * 2099187094) ^ -2069960599;
					continue;
				case 63u:
					UpdateDetails.smethod_17((Control)(object)NameSTxt, new Size(237, 28));
					num = ((int)num2 * -87372943) ^ 0x222D9EF6;
					continue;
				case 62u:
					num = (int)(num2 * 1137459309) ^ -417416622;
					continue;
				case 61u:
					num = (int)(num2 * 1550397003) ^ -1652622438;
					continue;
				case 60u:
					UpdateDetails.smethod_19(Label9, "Phone : ");
					num = (int)((num2 * 518906296) ^ 0x274806A4);
					continue;
				case 59u:
					UpdateDetails.smethod_18((Control)(object)GenderTxt, 6);
					UpdateDetails.smethod_15((Control)(object)DOBTxt, new Point(457, 88));
					num = (int)((num2 * 288649890) ^ 0x283280B0);
					continue;
				case 58u:
					num = (int)((num2 * 2009901744) ^ 0x69F0175C);
					continue;
				case 57u:
					UpdateDetails.smethod_18((Control)(object)Label5, 1);
					num = ((int)num2 * -476914432) ^ -1590003124;
					continue;
				case 56u:
					UpdateDetails.smethod_27((Control)(object)ClearBtn, UpdateDetails.smethod_26());
					UpdateDetails.smethod_15((Control)(object)ClearBtn, new Point(779, 651));
					num = (int)((num2 * 1282837317) ^ 0x73F5D908);
					continue;
				case 55u:
					UpdateDetails.smethod_15((Control)(object)PictureBox1, new Point(260, 22));
					num = ((int)num2 * -1067934123) ^ -2044056201;
					continue;
				case 54u:
					UpdateDetails.smethod_14((Control)(object)GroupBox1, UpdateDetails.smethod_13("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 392856935) ^ 0x5E119FAA);
					continue;
				case 53u:
					UpdateDetails.smethod_15((Control)(object)SearchBtn, new Point(468, 82));
					num = ((int)num2 * -2142842020) ^ 0x34ED0D87;
					continue;
				case 52u:
					UpdateDetails.smethod_29((ButtonBase)(object)UpdateBtn, bool_0: false);
					UpdateDetails.smethod_25((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					num = ((int)num2 * -387127973) ^ 0x2861762E;
					continue;
				case 51u:
					UpdateDetails.smethod_14((Control)(object)Label6, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 173012371) ^ 0xFD5E873);
					continue;
				case 50u:
					UpdateDetails.smethod_35((TextBoxBase)(object)PIDTxt, bool_0: true);
					num = (int)(num2 * 1052348013) ^ -1508358760;
					continue;
				case 49u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)Label7);
					num = (int)((num2 * 731479297) ^ 0x787BA118);
					continue;
				case 48u:
					UpdateDetails.smethod_16((Control)(object)PatientInfoBox, "PatientInfoBox");
					num = ((int)num2 * -1579543775) ^ -1431231178;
					continue;
				case 47u:
					UpdateDetails.smethod_19(Label6, "Gender : ");
					num = ((int)num2 * -1598337405) ^ -132076753;
					continue;
				case 46u:
					num = (int)((num2 * 760654695) ^ 0x91F1514);
					continue;
				case 45u:
					UpdateDetails.smethod_28((ButtonBase)(object)UpdateBtn, "Update ");
					num = ((int)num2 * -247030858) ^ -1561910370;
					continue;
				case 44u:
					num = ((int)num2 * -1315726132) ^ -1049507707;
					continue;
				case 43u:
					num = (int)(num2 * 1957093739) ^ -280667931;
					continue;
				case 42u:
					UpdateDetails.smethod_36(AddressTxt, bool_0: true);
					num = ((int)num2 * -2106943425) ^ -150309674;
					continue;
				case 41u:
					UpdateDetails.smethod_16((Control)(object)NameSTxt, "NameSTxt");
					num = ((int)num2 * -669134255) ^ 0x58C0055B;
					continue;
				case 40u:
					num = (int)(num2 * 2141209371) ^ -2145893748;
					continue;
				case 39u:
					UpdateDetails.smethod_15((Control)(object)Label8, new Point(20, 88));
					num = (int)(num2 * 1729423548) ^ -1823027345;
					continue;
				case 38u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)Label8);
					num = (int)(num2 * 1450513547) ^ -102593059;
					continue;
				case 37u:
					num = ((int)num2 * -779808097) ^ 0x3DF48CBD;
					continue;
				case 36u:
					num = ((int)num2 * -617772340) ^ 0x5E633CAA;
					continue;
				case 35u:
					UpdateDetails.smethod_19(Label3, "Phone : ");
					num = ((int)num2 * -1748825151) ^ 0x55BB36D;
					continue;
				case 34u:
					UpdateDetails.smethod_23(PatientInfoBox, bool_0: false);
					num = ((int)num2 * -1268203739) ^ 0x17E82393;
					continue;
				case 33u:
					num = ((int)num2 * -807988269) ^ -764719165;
					continue;
				case 32u:
					num = ((int)num2 * -500034020) ^ -816858952;
					continue;
				case 31u:
					num = ((int)num2 * -404880520) ^ -1836538159;
					continue;
				case 30u:
					UpdateDetails.smethod_16((Control)(object)Label9, "Label9");
					num = ((int)num2 * -1938489736) ^ 0x3FEF4783;
					continue;
				case 29u:
					UpdateDetails.smethod_19(Label8, "Name : ");
					num = ((int)num2 * -1766490104) ^ 0x44139EDF;
					continue;
				case 28u:
					UpdateDetails.smethod_17((Control)(object)GroupBox1, new Size(623, 128));
					num = (int)(num2 * 170696316) ^ -465990735;
					continue;
				case 27u:
					num = (int)((num2 * 897454652) ^ 0x65424146);
					continue;
				case 26u:
					AddressTxt = UpdateDetails.smethod_6();
					num = ((int)num2 * -635529758) ^ -635628020;
					continue;
				case 25u:
					UpdateDetails.smethod_10((ISupportInitialize)SearchResultGrid);
					num = ((int)num2 * -1854241219) ^ -1682808332;
					continue;
				case 24u:
					num = (int)(num2 * 373599143) ^ -2013461013;
					continue;
				case 23u:
					num = (int)(num2 * 1705724784) ^ -534006381;
					continue;
				case 22u:
					UpdateDetails.smethod_40(PictureBox1, bool_0: false);
					UpdateDetails.smethod_41((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = (int)((num2 * 408906654) ^ 0x3E4BEDF7);
					continue;
				case 21u:
					UpdateDetails.smethod_46((Control)(object)this, new Size(977, 804));
					UpdateDetails.smethod_47((Control)(object)GroupBox1, bool_0: false);
					num = ((int)num2 * -1493507123) ^ 0x5585F18B;
					continue;
				case 20u:
					UpdateDetails.smethod_17((Control)(object)Label5, new Size(68, 26));
					num = ((int)num2 * -517913079) ^ -2142097292;
					continue;
				case 19u:
					UpdateDetails.smethod_17((Control)(object)Label8, new Size(77, 28));
					num = (int)((num2 * 1250483778) ^ 0x7A8C3B46);
					continue;
				case 18u:
					num = ((int)num2 * -1028000747) ^ 0x68B45DBD;
					continue;
				case 17u:
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)Label9);
					UpdateDetails.smethod_22(UpdateDetails.smethod_21((Control)(object)PatientInfoBox), (Control)(object)NameTxt);
					num = ((int)num2 * -472037419) ^ 0x4873CB31;
					continue;
				case 16u:
					num = (int)(num2 * 132940689) ^ -615795564;
					continue;
				case 15u:
					num = (int)(num2 * 245288955) ^ -711556574;
					continue;
				case 14u:
					NameSTxt = UpdateDetails.smethod_6();
					num = (int)((num2 * 1989003616) ^ 0x3AA3AB2C);
					continue;
				case 13u:
					num = ((int)num2 * -334024146) ^ 0x21862A4B;
					continue;
				case 12u:
					num = ((int)num2 * -839731807) ^ 0x7A91D17A;
					continue;
				case 11u:
					UpdateDetails.smethod_14((Control)(object)Label7, UpdateDetails.smethod_13("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 430570530) ^ 0x47A37980);
					continue;
				case 10u:
					UpdateDetails.smethod_17((Control)(object)SearchResultGrid, new Size(853, 169));
					num = ((int)num2 * -776372674) ^ -534842094;
					continue;
				case 9u:
					num = ((int)num2 * -766244048) ^ -1002648675;
					continue;
				case 8u:
					UpdateDetails.smethod_17((Control)(object)ClearBtn, new Size(133, 37));
					num = (int)(num2 * 1134665887) ^ -2037799721;
					continue;
				case 7u:
					num = (int)((num2 * 2044168586) ^ 0x23054860);
					continue;
				case 6u:
					UpdateDetails.smethod_17((Control)(object)Label9, new Size(77, 28));
					num = ((int)num2 * -1832972938) ^ 0x75547A78;
					continue;
				case 5u:
					num = ((int)num2 * -810335111) ^ -2138824804;
					continue;
				case 4u:
					UpdateDetails.smethod_17((Control)(object)Label2, new Size(77, 28));
					num = ((int)num2 * -1530927244) ^ -1232974252;
					continue;
				case 3u:
					num = (int)(num2 * 2053424313) ^ -2093071766;
					continue;
				case 2u:
					num = ((int)num2 * -790703533) ^ -1240592098;
					continue;
				case 1u:
					num = (int)((num2 * 1779868841) ^ 0x3A1CEB0A);
					continue;
				case 0u:
					UpdateDetails.smethod_20(Label8, (ContentAlignment)32);
					num = ((int)num2 * -754465041) ^ -638317736;
					continue;
				default:
					return;
				case 270u:
					break;
				case 205u:
					return;
				}
				break;
			}
		}
	}

	private void UpdateDetails_Load(object sender, EventArgs e)
	{
		UpdateDetails.smethod_57(myconnection, UpdateDetails.smethod_56(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
		while (true)
		{
			int num = -1893908119;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA161ED89u) % 5u)
				{
				case 3u:
					num = ((int)num2 * -325125558) ^ -154047075;
					continue;
				case 2u:
					Hidedata();
					num = (int)((num2 * 1517869968) ^ 0x28579436);
					continue;
				case 1u:
					num = ((int)num2 * -1825966127) ^ 0x67F41C19;
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

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected I4, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected I4, but got Unknown
		//IL_0323: Incompatible stack heights: 0 vs 1
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Incompatible stack heights: 0 vs 1
		//IL_0359: Incompatible stack heights: 0 vs 1
		//IL_036e: Incompatible stack heights: 0 vs 1
		//IL_0378: Incompatible stack heights: 0 vs 1
		Hidedata();
		bool flag2 = default(bool);
		DataTable dataTable_ = default(DataTable);
		bool flag = default(bool);
		OleDbDataAdapter dbDataAdapter_ = default(OleDbDataAdapter);
		while (true)
		{
			int num = -68097405;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE582DE9Au) % 6u)
				{
				case 5u:
					flag2 = !MyProject.Forms.Form1.Name_Validation(UpdateDetails.smethod_59(UpdateDetails.smethod_58(NameSTxt))) | !MyProject.Forms.Form1.Mobile_Validator(UpdateDetails.smethod_59(UpdateDetails.smethod_58(MobileSTxt)));
					num = ((int)num2 * -1207685884) ^ -1563500905;
					continue;
				case 4u:
					UpdateDetails.smethod_60("No Results Found");
					num = (int)(num2 * 1797702315) ^ -470322892;
					continue;
				case 3u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = 1909755949;
						num7 = 1909755949;
					}
					else
					{
						num6 = 1366149210;
						num7 = 1366149210;
					}
					num = num6 ^ (int)(num2 * 14666795);
					continue;
				}
				case 2u:
					break;
				default:
					try
					{
						while (true)
						{
							int num3 = -377091776;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xE582DE9Au) % 14u)
								{
								case 13u:
									num3 = (int)(num2 * 2051105379) ^ -781096032;
									continue;
								case 12u:
									num3 = ((int)num2 * -1349896225) ^ -1885783730;
									continue;
								case 11u:
									UpdateDetails.smethod_72((Control)(object)SearchResultGrid);
									num3 = -1860140668;
									continue;
								case 10u:
									num3 = (int)(num2 * 1248287663) ^ -636248927;
									continue;
								case 9u:
									UpdateDetails.smethod_71(myconnection);
									mobile = UpdateDetails.smethod_58(MobileSTxt);
									num3 = ((int)num2 * -1532977344) ^ 0x37E3ACA;
									continue;
								case 7u:
									UpdateDetails.smethod_68(SearchResultGrid, (object)UpdateDetails.smethod_67(dataTable_));
									flag = UpdateDetails.smethod_69(SearchResultGrid) == 1;
									num3 = ((int)num2 * -729140664) ^ -775286159;
									continue;
								case 6u:
									dataTable_ = UpdateDetails.smethod_61();
									dbDataAdapter_ = UpdateDetails.smethod_62();
									UpdateDetails.smethod_63(myconnection);
									num3 = ((int)num2 * -215903020) ^ 0x14406B89;
									continue;
								case 5u:
									dbDataAdapter_ = UpdateDetails.smethod_65(UpdateDetails.smethod_64(new string[5]
									{
										"Select * from Patient where Name like '%",
										UpdateDetails.smethod_58(NameSTxt),
										"%'  And   Mobile like '%",
										UpdateDetails.smethod_58(MobileSTxt),
										"%' "
									}), myconnection);
									num3 = (int)(num2 * 1550572537) ^ -975993673;
									continue;
								case 3u:
								{
									int num4;
									int num5;
									if (!flag)
									{
										num4 = 961803732;
										num5 = 961803732;
									}
									else
									{
										num4 = 1518806814;
										num5 = 1518806814;
									}
									num3 = num4 ^ (int)(num2 * 102015275);
									continue;
								}
								case 2u:
									UpdateDetails.smethod_66((DbDataAdapter)(object)dbDataAdapter_, dataTable_);
									num3 = ((int)num2 * -40285855) ^ -506192611;
									continue;
								case 1u:
									UpdateDetails.smethod_70("Not Found.", "Result");
									UpdateDetails.smethod_71(myconnection);
									num3 = ((int)num2 * -1320301978) ^ 0x1C7C18CC;
									continue;
								case 4u:
									break;
								case 0u:
									return;
								default:
									name_search = UpdateDetails.smethod_58(NameSTxt);
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
							_ = -256789216;
							while (true)
							{
								_003F val = /*Error near IL_02f1: Stack underflow*/^ -444408166;
								num2 = (uint)(int)val;
								switch (val % 6)
								{
								default:
									return;
								case 5:
									_ = ((int)num2 * -920450230) ^ -886685287;
									continue;
								case 3:
									UpdateDetails.smethod_60("Incorrect Credentials");
									_ = (num2 * 365366955) ^ 0x1552C80B;
									continue;
								case 2:
									UpdateDetails.smethod_71(myconnection);
									_ = ((int)num2 * -1885264707) ^ 0x407A2E83;
									continue;
								case 0:
									UpdateDetails.smethod_74();
									_ = ((int)num2 * -642292067) ^ 0x52432099;
									continue;
								case 4:
									break;
								case 1:
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
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
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
			int num = 543159955;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x656D1745u) % 8u)
				{
				case 6u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -742300467;
						num5 = -742300467;
					}
					else
					{
						num4 = -190117777;
						num5 = -190117777;
					}
					num = num4 ^ (int)(num2 * 1214048072);
					continue;
				}
				case 4u:
					UpdateDetails.smethod_63(myconnection);
					num = (int)((num2 * 790720315) ^ 0x733B16B2);
					continue;
				case 3u:
					num = ((int)num2 * -294063459) ^ 0xF422C8F;
					continue;
				case 2u:
					UpdateDetails.smethod_60("Enter Valid Phone number");
					num = ((int)num2 * -1945026754) ^ -1555903984;
					continue;
				case 0u:
					num = 63671737;
					continue;
				case 7u:
					break;
				default:
				{
					OleDbCommand val = UpdateDetails.smethod_76(string_, myconnection);
					try
					{
						while (true)
						{
							int num3 = 1015890662;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x656D1745u) % 7u)
								{
								case 4u:
									UpdateDetails.smethod_77(val);
									num3 = ((int)num2 * -1087448639) ^ -76008520;
									continue;
								case 3u:
									updatedatagrid();
									num3 = (int)(num2 * 1334272050) ^ -1105537956;
									continue;
								case 2u:
									UpdateDetails.smethod_71(myconnection);
									num3 = (int)(num2 * 250410824) ^ -1651150306;
									continue;
								case 1u:
									UpdateDetails.smethod_60("Updated Sucessfully");
									num3 = (int)((num2 * 161679900) ^ 0x4149AF9B);
									continue;
								case 0u:
									UpdateDetails.smethod_78((Component)(object)val);
									num3 = ((int)num2 * -1399264574) ^ -1837571823;
									continue;
								default:
									return;
								case 5u:
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
						UpdateDetails.smethod_73(exception_);
						UpdateDetails.smethod_71(myconnection);
						UpdateDetails.smethod_74();
						return;
					}
				}
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		bool flag = (checked(UpdateDetails.smethod_79(e) + 1) == UpdateDetails.smethod_69(SearchResultGrid)) | (UpdateDetails.smethod_79(e) == -1);
		DataGridViewRow dataGridViewRow_ = default(DataGridViewRow);
		while (true)
		{
			int num = 237401174;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3775EC57u) % 5u)
				{
				case 3u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1239165156;
						num5 = 1239165156;
					}
					else
					{
						num4 = 2130826645;
						num5 = 2130826645;
					}
					num = num4 ^ (int)(num2 * 798362683);
					continue;
				}
				case 2u:
					num = 1862390723;
					continue;
				case 4u:
					break;
				default:
					selectrow = UpdateDetails.smethod_79(e);
					try
					{
						UpdateDetails.smethod_80((Control)(object)PatientInfoBox, bool_0: true);
						while (true)
						{
							int num3 = 1495740289;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x3775EC57u) % 12u)
								{
								case 11u:
									num3 = ((int)num2 * -1422575417) ^ -1056731993;
									continue;
								case 10u:
									UpdateDetails.smethod_72((Control)(object)UpdateBtn);
									UpdateDetails.smethod_72((Control)(object)ClearBtn);
									num3 = (int)(num2 * 784052404) ^ -1965792960;
									continue;
								case 9u:
									UpdateDetails.smethod_88(PIDTxt, UpdateDetails.smethod_87(UpdateDetails.smethod_86(UpdateDetails.smethod_85(UpdateDetails.smethod_84(dataGridViewRow_), 0))));
									UpdateDetails.smethod_88(NameTxt, UpdateDetails.smethod_87(UpdateDetails.smethod_86(UpdateDetails.smethod_85(UpdateDetails.smethod_84(dataGridViewRow_), 1))));
									UpdateDetails.smethod_88(DOBTxt, UpdateDetails.smethod_89(UpdateDetails.smethod_86(UpdateDetails.smethod_85(UpdateDetails.smethod_84(dataGridViewRow_), 2))));
									num3 = (int)((num2 * 2118960251) ^ 0x34D3D103);
									continue;
								case 8u:
									dataGridViewRow_ = UpdateDetails.smethod_83(UpdateDetails.smethod_82(SearchResultGrid), selectrow);
									num3 = (int)(num2 * 1621589073) ^ -1079009386;
									continue;
								case 7u:
									num3 = ((int)num2 * -605155938) ^ -157339850;
									continue;
								case 5u:
									UpdateDetails.smethod_88(MobileTxt, UpdateDetails.smethod_87(UpdateDetails.smethod_86(UpdateDetails.smethod_85(UpdateDetails.smethod_84(dataGridViewRow_), 4))));
									num3 = ((int)num2 * -1430413877) ^ -1571541987;
									continue;
								case 4u:
									num3 = (int)(num2 * 1617240990) ^ -446515095;
									continue;
								case 3u:
									selectrow = UpdateDetails.smethod_79(e);
									num3 = (int)(num2 * 347823496) ^ -1087421603;
									continue;
								case 2u:
									dataGridViewRow_ = UpdateDetails.smethod_81();
									num3 = (int)(num2 * 841107282) ^ -795257613;
									continue;
								case 1u:
									UpdateDetails.smethod_88(GenderTxt, UpdateDetails.smethod_87(UpdateDetails.smethod_86(UpdateDetails.smethod_85(UpdateDetails.smethod_84(dataGridViewRow_), 3))));
									num3 = (int)(num2 * 1332291982) ^ -901453223;
									continue;
								case 0u:
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
						UpdateDetails.smethod_74();
						return;
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
			int num = 1481484519;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6D404AAEu) % 7u)
				{
				case 6u:
					UpdateDetails.smethod_80((Control)(object)PatientInfoBox, bool_0: false);
					num = (int)((num2 * 995391162) ^ 0x7A6057B4);
					continue;
				case 3u:
					UpdateDetails.smethod_90((Control)(object)SearchResultGrid);
					num = ((int)num2 * -2047902520) ^ -1692697447;
					continue;
				case 2u:
					UpdateDetails.smethod_90((Control)(object)UpdateBtn);
					num = ((int)num2 * -1877502647) ^ -763877794;
					continue;
				case 1u:
					UpdateDetails.smethod_90((Control)(object)ClearBtn);
					num = ((int)num2 * -1249356245) ^ 0xE501E6F;
					continue;
				case 0u:
					num = (int)((num2 * 1199137768) ^ 0x62A7CCFF);
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

	private void updatedatagrid()
	{
		DataGridViewRow dataGridViewRow_ = default(DataGridViewRow);
		while (true)
		{
			int num = 343267224;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x27DA0F14u) % 8u)
				{
				case 6u:
					UpdateDetails.smethod_91(UpdateDetails.smethod_85(UpdateDetails.smethod_84(dataGridViewRow_), 2), (object)UpdateDetails.smethod_58(DOBTxt));
					num = ((int)num2 * -1136179061) ^ 0x3C9B05BF;
					continue;
				case 4u:
					dataGridViewRow_ = UpdateDetails.smethod_81();
					num = ((int)num2 * -359132643) ^ -263563936;
					continue;
				case 3u:
					UpdateDetails.smethod_91(UpdateDetails.smethod_85(UpdateDetails.smethod_84(dataGridViewRow_), 4), (object)UpdateDetails.smethod_58(MobileTxt));
					UpdateDetails.smethod_91(UpdateDetails.smethod_85(UpdateDetails.smethod_84(dataGridViewRow_), 5), (object)UpdateDetails.smethod_58(AddressTxt));
					num = ((int)num2 * -481052088) ^ -786944450;
					continue;
				case 2u:
					num = ((int)num2 * -1833540400) ^ 0x5AC37163;
					continue;
				case 1u:
					num = (int)(num2 * 1072936959) ^ -1229692320;
					continue;
				case 0u:
					dataGridViewRow_ = UpdateDetails.smethod_83(UpdateDetails.smethod_82(SearchResultGrid), selectrow);
					num = (int)((num2 * 573790976) ^ 0x65AA5E52);
					continue;
				default:
					return;
				case 5u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	private void ClearBtn_Click(object sender, EventArgs e)
	{
		UpdateDetails.smethod_92((TextBoxBase)(object)PIDTxt);
		UpdateDetails.smethod_92((TextBoxBase)(object)NameTxt);
		UpdateDetails.smethod_92((TextBoxBase)(object)DOBTxt);
		while (true)
		{
			int num = -471044147;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFF4D63CEu) % 4u)
				{
				case 3u:
					UpdateDetails.smethod_92((TextBoxBase)(object)MobileTxt);
					num = (int)((num2 * 591503910) ^ 0x2FCC50BE);
					continue;
				case 2u:
					UpdateDetails.smethod_92((TextBoxBase)(object)GenderTxt);
					num = ((int)num2 * -1931104592) ^ 0x7899B37;
					continue;
				case 0u:
					break;
				default:
					UpdateDetails.smethod_92((TextBoxBase)(object)AddressTxt);
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
