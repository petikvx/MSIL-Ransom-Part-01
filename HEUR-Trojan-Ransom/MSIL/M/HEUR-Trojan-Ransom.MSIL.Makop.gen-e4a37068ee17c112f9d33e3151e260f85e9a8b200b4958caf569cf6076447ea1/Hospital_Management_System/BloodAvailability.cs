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
public class BloodAvailability : UserControl
{
	private IContainer components;

	private OleDbConnection myconnection;

	private string blood_group;

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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BloodGrpTxt")]
	internal virtual ComboBox BloodGrpTxt
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
			if (searchBtn != null)
			{
				goto IL_0073;
			}
			goto IL_00a1;
			IL_00a1:
			_SearchBtn = value;
			int num = 1518984309;
			goto IL_0078;
			IL_0078:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2EA1D2A1u) % 6u)
				{
				case 5u:
					BloodAvailability.smethod_58((Control)(object)searchBtn, eventHandler_);
					num = ((int)num2 * -1293529590) ^ -627562846;
					continue;
				case 4u:
				{
					searchBtn = _SearchBtn;
					int num3;
					int num4;
					if (searchBtn == null)
					{
						num3 = 1890488396;
						num4 = 1890488396;
					}
					else
					{
						num3 = 1665889204;
						num4 = 1665889204;
					}
					num = num3 ^ (int)(num2 * 1790719629);
					continue;
				}
				case 2u:
					BloodAvailability.smethod_57((Control)(object)searchBtn, eventHandler_);
					num = (int)((num2 * 699209326) ^ 0x57FBF602);
					continue;
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_00a1;
				case 3u:
					return;
				}
				break;
			}
			goto IL_0073;
			IL_0073:
			num = 1375786727;
			goto IL_0078;
		}
	}

	[field: AccessedThroughProperty("AmountLbl")]
	internal virtual Label AmountLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ValueLbl")]
	internal virtual Label ValueLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button DonorListBtn
	{
		[CompilerGenerated]
		get
		{
			return _DonorListBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = Button2_Click;
			Button donorListBtn = default(Button);
			while (true)
			{
				int num = -429749477;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDB0D6402u) % 8u)
					{
					case 7u:
						BloodAvailability.smethod_57((Control)(object)donorListBtn, eventHandler_);
						num = ((int)num2 * -512557110) ^ 0x44D3ADF8;
						continue;
					case 4u:
						_DonorListBtn = value;
						num = -619817751;
						continue;
					case 3u:
						donorListBtn = _DonorListBtn;
						num = (int)((num2 * 244629113) ^ 0x4B45F29);
						continue;
					case 2u:
						BloodAvailability.smethod_58((Control)(object)donorListBtn, eventHandler_);
						num = ((int)num2 * -146803369) ^ 0x4EF68A32;
						continue;
					case 1u:
					{
						donorListBtn = _DonorListBtn;
						int num5;
						int num6;
						if (donorListBtn == null)
						{
							num5 = -798096688;
							num6 = -798096688;
						}
						else
						{
							num5 = -13361565;
							num6 = -13361565;
						}
						num = num5 ^ ((int)num2 * -480320306);
						continue;
					}
					case 0u:
					{
						int num3;
						int num4;
						if (donorListBtn != null)
						{
							num3 = -534926688;
							num4 = -534926688;
						}
						else
						{
							num3 = -1707755620;
							num4 = -1707755620;
						}
						num = num3 ^ ((int)num2 * -1264923702);
						continue;
					}
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
	}

	[field: AccessedThroughProperty("SearchResultGrid")]
	internal virtual DataGridView SearchResultGrid
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SuccessMsg")]
	internal virtual Label SuccessMsg
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Timer1")]
	internal virtual Timer Timer1
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
				int num = 1274969287;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2CFAD540u) % 6u)
					{
					case 4u:
						BloodAvailability.smethod_57((Control)(object)updateBtn, eventHandler_);
						num = (int)((num2 * 1422246271) ^ 0x4CAAA4DF);
						continue;
					case 3u:
					{
						int num4;
						int num5;
						if (updateBtn != null)
						{
							num4 = 2038972378;
							num5 = 2038972378;
						}
						else
						{
							num4 = 1363904697;
							num5 = 1363904697;
						}
						num = num4 ^ ((int)num2 * -490369404);
						continue;
					}
					case 2u:
						BloodAvailability.smethod_58((Control)(object)updateBtn, eventHandler_);
						num = ((int)num2 * -2055081070) ^ 0x14DC1EBD;
						continue;
					case 1u:
					{
						_UpdateBtn = value;
						updateBtn = _UpdateBtn;
						int num3;
						if (updateBtn != null)
						{
							num = 1322125816;
							num3 = 1322125816;
						}
						else
						{
							num = 347903565;
							num3 = 347903565;
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

	public BloodAvailability()
	{
		while (true)
		{
			int num = -1497758226;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFDEA6658u) % 5u)
				{
				case 3u:
					myconnection = BloodAvailability.smethod_1();
					InitializeComponent();
					num = ((int)num2 * -475222670) ^ 0x4ABDD6E6;
					continue;
				case 2u:
					num = (int)(num2 * 572447798) ^ -1178447213;
					continue;
				case 1u:
					BloodAvailability.smethod_0((UserControl)(object)this, (EventHandler)BloodAvailability_Load);
					num = ((int)num2 * -154960950) ^ 0x5BC42814;
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
			IL_0085:
			num = ((components != null) ? 1 : 0);
			goto IL_008e;
			IL_0057:
			int num2 = 452940601;
			goto IL_005c;
			IL_005c:
			bool flag = default(bool);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x160599D6u) % 6u)
				{
				case 5u:
					num2 = ((int)num3 * -1778585144) ^ 0x2BAA3F3D;
					continue;
				case 4u:
					BloodAvailability.smethod_2((IDisposable)components);
					num2 = (int)(num3 * 2028715395) ^ -797739377;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 230265621;
						num5 = 230265621;
					}
					else
					{
						num4 = 624412492;
						num5 = 624412492;
					}
					num2 = num4 ^ (int)(num3 * 1766351151);
					continue;
				}
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_0085;
				case 3u:
					return;
				}
				break;
			}
			goto IL_0057;
			IL_008e:
			flag = (byte)num != 0;
			num2 = 585931110;
			goto IL_005c;
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
			int num = 1490467176;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2AB3FA7u) % 159u)
				{
				case 158u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_50((Control)(object)this), (Control)(object)UpdateBtn);
					num = ((int)num2 * -2091704121) ^ 0x2F2EBBFB;
					continue;
				case 157u:
					num = (int)(num2 * 807120120) ^ -777691152;
					continue;
				case 156u:
					BloodAvailability.smethod_27((Control)(object)SearchBtn, Color.White);
					num = (int)((num2 * 434086340) ^ 0x612AD550);
					continue;
				case 155u:
					SearchBtn = BloodAvailability.smethod_6();
					num = ((int)num2 * -1007470330) ^ -1812581723;
					continue;
				case 154u:
					BloodAvailability.smethod_18((Control)(object)SearchBtn, new Size(102, 36));
					num = ((int)num2 * -1838304960) ^ -2106691077;
					continue;
				case 153u:
					Timer1 = BloodAvailability.smethod_9(components);
					num = ((int)num2 * -1859328197) ^ -641116687;
					continue;
				case 152u:
					BloodAvailability.smethod_43(Timer1, 1500);
					BloodAvailability.smethod_26((ButtonBase)(object)UpdateBtn, Color.MidnightBlue);
					num = (int)((num2 * 507908149) ^ 0x563C8A19);
					continue;
				case 151u:
					BloodAvailability.smethod_18((Control)(object)ValueLbl, new Size(64, 24));
					num = ((int)num2 * -733012869) ^ -1355307303;
					continue;
				case 150u:
					num = ((int)num2 * -1371858281) ^ -1256512979;
					continue;
				case 149u:
					BloodAvailability.smethod_21(ValueLbl, (ContentAlignment)32);
					num = (int)((num2 * 1271979407) ^ 0x53B208DC);
					continue;
				case 148u:
					BloodAvailability.smethod_18((Control)(object)BloodGrpTxt, new Size(108, 26));
					BloodAvailability.smethod_19((Control)(object)BloodGrpTxt, 21);
					num = ((int)num2 * -457760082) ^ 0x33E1215;
					continue;
				case 147u:
					BloodAvailability.smethod_41((Control)(object)SuccessMsg, bool_0: false);
					num = (int)(num2 * 1129004771) ^ -94031729;
					continue;
				case 146u:
					BloodAvailability.smethod_17((Control)(object)DonorListBtn, "DonorListBtn");
					num = (int)((num2 * 438599666) ^ 0x60AFFFBA);
					continue;
				case 145u:
					num = (int)(num2 * 806387985) ^ -1709116064;
					continue;
				case 144u:
					BloodAvailability.smethod_15((Control)(object)SuccessMsg, BloodAvailability.smethod_42("MS Reference Sans Serif", 10.8f, (FontStyle)1));
					num = ((int)num2 * -67022704) ^ -2142355480;
					continue;
				case 143u:
					GroupBox1 = BloodAvailability.smethod_5();
					num = (int)((num2 * 342172293) ^ 0x38A0E46E);
					continue;
				case 142u:
					BloodAvailability.smethod_18((Control)(object)GroupBox1, new Size(490, 137));
					BloodAvailability.smethod_19((Control)(object)GroupBox1, 12);
					BloodAvailability.smethod_24(GroupBox1, bool_0: false);
					num = ((int)num2 * -784521935) ^ -696085049;
					continue;
				case 141u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_50((Control)(object)this), (Control)(object)GroupBox1);
					num = (int)((num2 * 1584041335) ^ 0x4FE7F9F0);
					continue;
				case 140u:
					BloodAvailability.smethod_17((Control)(object)UpdateBtn, "UpdateBtn");
					num = ((int)num2 * -338903430) ^ 0x4677EAC0;
					continue;
				case 139u:
					num = (int)((num2 * 1913890374) ^ 0x7C37BBBF);
					continue;
				case 138u:
					BloodAvailability.smethod_16((Control)(object)BloodGrpTxt, new Point(246, 40));
					BloodAvailability.smethod_17((Control)(object)BloodGrpTxt, "BloodGrpTxt");
					num = (int)(num2 * 1483797676) ^ -92861777;
					continue;
				case 137u:
					BloodAvailability.smethod_21(Label1, (ContentAlignment)32);
					num = (int)((num2 * 973671024) ^ 0x1E06524E);
					continue;
				case 136u:
					BloodAvailability.smethod_37(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					BloodAvailability.smethod_16((Control)(object)SearchResultGrid, new Point(112, 494));
					num = (int)((num2 * 2082670050) ^ 0x75E6F237);
					continue;
				case 135u:
					num = ((int)num2 * -1823412113) ^ -1473317305;
					continue;
				case 134u:
					BloodAvailability.smethod_18((Control)(object)Label2, new Size(135, 32));
					num = ((int)num2 * -1894204117) ^ -1337374926;
					continue;
				case 133u:
					num = (int)((num2 * 1243094117) ^ 0x2D4E44B6);
					continue;
				case 132u:
					BloodAvailability.smethod_28((ButtonBase)(object)DonorListBtn, "See List of Donors");
					num = (int)((num2 * 1162656791) ^ 0xD5C6674);
					continue;
				case 131u:
					num = ((int)num2 * -730419551) ^ -1732216167;
					continue;
				case 130u:
					BloodAvailability.smethod_17((Control)(object)SearchResultGrid, "SearchResultGrid");
					BloodAvailability.smethod_38(SearchResultGrid, bool_0: true);
					num = ((int)num2 * -1646678416) ^ -622934831;
					continue;
				case 129u:
					BloodAvailability.smethod_15((Control)(object)Label1, BloodAvailability.smethod_14("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1448565097) ^ -1082394054;
					continue;
				case 128u:
					num = ((int)num2 * -779332080) ^ -49188900;
					continue;
				case 127u:
					num = ((int)num2 * -868470469) ^ 0xC6A3368;
					continue;
				case 126u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_22((Control)(object)GroupBox1), (Control)(object)Label2);
					num = ((int)num2 * -1400962368) ^ -342228764;
					continue;
				case 125u:
					num = (int)((num2 * 125142132) ^ 0x4F927AA7);
					continue;
				case 124u:
					BloodAvailability.smethod_21(Label2, (ContentAlignment)32);
					num = (int)((num2 * 1511051858) ^ 0x6C7BC7FF);
					continue;
				case 123u:
					BloodAvailability.smethod_12((ISupportInitialize)PictureBox1);
					num = (int)(num2 * 2116726712) ^ -141195232;
					continue;
				case 122u:
					BloodAvailability.smethod_18((Control)(object)Label1, new Size(330, 47));
					BloodAvailability.smethod_19((Control)(object)Label1, 11);
					num = ((int)num2 * -160183672) ^ 0xED993D3;
					continue;
				case 121u:
					num = (int)((num2 * 226126764) ^ 0x5D954AC0);
					continue;
				case 120u:
					BloodAvailability.smethod_54((ISupportInitialize)PictureBox1);
					BloodAvailability.smethod_55((Control)(object)this, bool_0: false);
					num = ((int)num2 * -586619824) ^ 0x2BC2F860;
					continue;
				case 119u:
					BloodAvailability.smethod_17((Control)(object)AmountLbl, "AmountLbl");
					BloodAvailability.smethod_18((Control)(object)AmountLbl, new Size(131, 35));
					num = (int)((num2 * 1894887344) ^ 0x69EB680D);
					continue;
				case 118u:
					BloodAvailability.smethod_20(Label2, "Blood Group :");
					num = (int)(num2 * 374502271) ^ -1339182285;
					continue;
				case 117u:
					BloodAvailability.smethod_25(GroupBox1, "Search");
					num = ((int)num2 * -3180597) ^ 0x6C973C4C;
					continue;
				case 116u:
					BloodAvailability.smethod_19((Control)(object)DonorListBtn, 23);
					num = ((int)num2 * -1040763449) ^ 0x43057DF5;
					continue;
				case 115u:
					BloodAvailability.smethod_17((Control)(object)GroupBox1, "GroupBox1");
					num = ((int)num2 * -282924650) ^ 0x63F84A22;
					continue;
				case 114u:
					BloodAvailability.smethod_16((Control)(object)Label2, new Point(87, 36));
					num = (int)(num2 * 52730210) ^ -1207514924;
					continue;
				case 113u:
					BloodAvailability.smethod_41((Control)(object)UpdateBtn, bool_0: false);
					num = (int)(num2 * 597694685) ^ -751951337;
					continue;
				case 112u:
					BloodAvailability.smethod_35((Control)(object)ValueLbl, Color.FromArgb(0, 192, 0));
					num = (int)((num2 * 1024374579) ^ 0x6B9EAE80);
					continue;
				case 111u:
					BloodAvailability.smethod_15((Control)(object)BloodGrpTxt, BloodAvailability.smethod_14("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					BloodAvailability.smethod_31((ListControl)(object)BloodGrpTxt, bool_0: true);
					num = ((int)num2 * -783279725) ^ -106562582;
					continue;
				case 110u:
					num = (int)((num2 * 583931764) ^ 0x5AAED8DD);
					continue;
				case 109u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_50((Control)(object)this), (Control)(object)SuccessMsg);
					num = (int)((num2 * 965395413) ^ 0x6E8C999B);
					continue;
				case 108u:
					num = (int)(num2 * 1038541744) ^ -1298779812;
					continue;
				case 107u:
					BloodAvailability.smethod_19((Control)(object)ValueLbl, 14);
					num = ((int)num2 * -2061114204) ^ 0x583DCE46;
					continue;
				case 106u:
					num = (int)(num2 * 814655462) ^ -945512063;
					continue;
				case 105u:
					num = (int)((num2 * 1318777380) ^ 0x2E0A9473);
					continue;
				case 104u:
					num = ((int)num2 * -188354256) ^ 0x55329AA2;
					continue;
				case 103u:
					BloodAvailability.smethod_46(PictureBox1, 10);
					num = (int)((num2 * 1391482324) ^ 0x32415322);
					continue;
				case 102u:
					num = ((int)num2 * -1920937247) ^ 0x6AA8EA6C;
					continue;
				case 101u:
					BloodAvailability.smethod_27((Control)(object)DonorListBtn, Color.White);
					BloodAvailability.smethod_16((Control)(object)DonorListBtn, new Point(323, 434));
					num = (int)((num2 * 537001855) ^ 0x2E768D99);
					continue;
				case 100u:
					num = ((int)num2 * -1941323288) ^ -209719085;
					continue;
				case 99u:
					BloodAvailability.smethod_13((Control)(object)this);
					num = ((int)num2 * -1059581937) ^ -1767709452;
					continue;
				case 98u:
					num = (int)((num2 * 1525191009) ^ 0x6F08F386);
					continue;
				case 97u:
					BloodAvailability.smethod_16((Control)(object)SuccessMsg, new Point(281, 141));
					num = ((int)num2 * -993518070) ^ -913859269;
					continue;
				case 96u:
					num = ((int)num2 * -742765469) ^ 0x201F773A;
					continue;
				case 95u:
					BloodAvailability.smethod_11((Control)(object)GroupBox1);
					num = (int)((num2 * 878136521) ^ 0x406B8360);
					continue;
				case 94u:
					ValueLbl = BloodAvailability.smethod_4();
					num = ((int)num2 * -794902495) ^ -371867328;
					continue;
				case 93u:
					BloodAvailability.smethod_27((Control)(object)UpdateBtn, Color.White);
					num = (int)(num2 * 271365630) ^ -1482231671;
					continue;
				case 92u:
					BloodAvailability.smethod_53((Control)(object)GroupBox1, bool_0: false);
					num = ((int)num2 * -751468668) ^ -523462628;
					continue;
				case 91u:
					num = ((int)num2 * -121504880) ^ -277310268;
					continue;
				case 90u:
					BloodAvailability.smethod_52((Control)(object)this, new Size(977, 804));
					num = (int)(num2 * 313809261) ^ -879632205;
					continue;
				case 89u:
					DonorListBtn = BloodAvailability.smethod_6();
					num = ((int)num2 * -88028371) ^ 0x197F7EC9;
					continue;
				case 88u:
					BloodAvailability.smethod_28((ButtonBase)(object)UpdateBtn, "Update Blood Amount");
					num = (int)((num2 * 1934082540) ^ 0x44B5932);
					continue;
				case 87u:
					BloodGrpTxt = BloodAvailability.smethod_7();
					Label2 = BloodAvailability.smethod_4();
					num = (int)(num2 * 1542132201) ^ -1458008766;
					continue;
				case 86u:
					BloodAvailability.smethod_47(PictureBox1, bool_0: false);
					num = (int)(num2 * 1305364154) ^ -408160347;
					continue;
				case 85u:
					BloodAvailability.smethod_34(ValueLbl, bool_0: true);
					num = ((int)num2 * -373579037) ^ -170448758;
					continue;
				case 84u:
					BloodAvailability.smethod_36(SearchResultGrid, Color.White);
					num = (int)((num2 * 152038888) ^ 0x62F98AB9);
					continue;
				case 83u:
					num = ((int)num2 * -1249867608) ^ 0x415E837;
					continue;
				case 82u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_50((Control)(object)this), (Control)(object)DonorListBtn);
					num = ((int)num2 * -1732761190) ^ 0x7CE70B1E;
					continue;
				case 81u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_50((Control)(object)this), (Control)(object)Label1);
					num = (int)(num2 * 580401943) ^ -2081272465;
					continue;
				case 80u:
					BloodAvailability.smethod_12((ISupportInitialize)SearchResultGrid);
					num = (int)((num2 * 571150693) ^ 0x5DD75487);
					continue;
				case 79u:
					BloodAvailability.smethod_20(ValueLbl, "litres");
					num = ((int)num2 * -1301896469) ^ 0x3C7FBC96;
					continue;
				case 78u:
					BloodAvailability.smethod_15((Control)(object)GroupBox1, BloodAvailability.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					BloodAvailability.smethod_16((Control)(object)GroupBox1, new Point(232, 214));
					num = ((int)num2 * -308777564) ^ 0x45D6AA52;
					continue;
				case 77u:
					BloodAvailability.smethod_21(SuccessMsg, (ContentAlignment)32);
					num = (int)(num2 * 1666381416) ^ -1661189039;
					continue;
				case 76u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_22((Control)(object)GroupBox1), (Control)(object)BloodGrpTxt);
					num = (int)(num2 * 1779796970) ^ -45568715;
					continue;
				case 75u:
					num = (int)((num2 * 2060452852) ^ 0x4931E38A);
					continue;
				case 74u:
					BloodAvailability.smethod_20(SuccessMsg, "Label5");
					num = ((int)num2 * -2132359606) ^ -1055380183;
					continue;
				case 73u:
					BloodAvailability.smethod_17((Control)(object)Label1, "Label1");
					num = (int)(num2 * 1291869752) ^ -1769732119;
					continue;
				case 72u:
					BloodAvailability.smethod_15((Control)(object)Label2, BloodAvailability.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -94330369) ^ 0x22B183A8;
					continue;
				case 69u:
					num = ((int)num2 * -1431414335) ^ 0x3034DC3B;
					continue;
				case 68u:
					num = (int)(num2 * 471836738) ^ -809953488;
					continue;
				case 67u:
					components = BloodAvailability.smethod_3();
					num = ((int)num2 * -1955295883) ^ -550718213;
					continue;
				case 66u:
					BloodAvailability.smethod_17((Control)(object)ValueLbl, "ValueLbl");
					num = (int)((num2 * 1913836948) ^ 0x5BD65CF3);
					continue;
				case 65u:
					BloodAvailability.smethod_28((ButtonBase)(object)SearchBtn, "Search");
					num = (int)((num2 * 539522187) ^ 0x3D78F180);
					continue;
				case 64u:
					num = ((int)num2 * -2033682288) ^ 0x3CD77BF3;
					continue;
				case 63u:
					BloodAvailability.smethod_44(PictureBox1, (Image)(object)Resources.blood_goodpic);
					num = ((int)num2 * -657672549) ^ 0x3CF02A8B;
					continue;
				case 62u:
					BloodAvailability.smethod_26((ButtonBase)(object)SearchBtn, Color.MidnightBlue);
					BloodAvailability.smethod_15((Control)(object)SearchBtn, BloodAvailability.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1862500616) ^ 0x4B722549;
					continue;
				case 61u:
					BloodAvailability.smethod_40(BloodAvailability.smethod_39(SearchResultGrid), 24);
					BloodAvailability.smethod_18((Control)(object)SearchResultGrid, new Size(739, 296));
					num = ((int)num2 * -1152140399) ^ 0x26E58FA5;
					continue;
				case 60u:
					num = (int)((num2 * 2000997073) ^ 0x78218248);
					continue;
				case 59u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_50((Control)(object)this), (Control)(object)SearchResultGrid);
					num = (int)(num2 * 907111489) ^ -1627276929;
					continue;
				case 58u:
					BloodAvailability.smethod_18((Control)(object)UpdateBtn, new Size(180, 52));
					BloodAvailability.smethod_19((Control)(object)UpdateBtn, 29);
					num = ((int)num2 * -677417028) ^ 0x44AC7BA9;
					continue;
				case 57u:
					BloodAvailability.smethod_15((Control)(object)ValueLbl, BloodAvailability.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1608105439) ^ 0x61D6F081);
					continue;
				case 56u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_50((Control)(object)this), (Control)(object)ValueLbl);
					num = ((int)num2 * -1063876341) ^ 0x262BEBD3;
					continue;
				case 55u:
					BloodAvailability.smethod_19((Control)(object)AmountLbl, 13);
					BloodAvailability.smethod_20(AmountLbl, "Amount :");
					num = ((int)num2 * -931864771) ^ -1182607743;
					continue;
				case 54u:
					num = (int)(num2 * 1650422894) ^ -1520910387;
					continue;
				case 53u:
					num = ((int)num2 * -1824834637) ^ -145808085;
					continue;
				case 52u:
					BloodAvailability.smethod_19((Control)(object)SuccessMsg, 28);
					num = (int)((num2 * 1320210438) ^ 0x5EAB8AC4);
					continue;
				case 51u:
					num = (int)((num2 * 861685424) ^ 0x52BA4);
					continue;
				case 50u:
					num = (int)((num2 * 1461266187) ^ 0x7667C5D2);
					continue;
				case 49u:
					BloodAvailability.smethod_15((Control)(object)AmountLbl, BloodAvailability.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					BloodAvailability.smethod_16((Control)(object)AmountLbl, new Point(299, 369));
					num = (int)((num2 * 1092242496) ^ 0x62FCA49C);
					continue;
				case 48u:
					BloodAvailability.smethod_19((Control)(object)SearchResultGrid, 24);
					num = ((int)num2 * -1337242013) ^ 0x7999629;
					continue;
				case 47u:
					SearchResultGrid = BloodAvailability.smethod_8();
					num = (int)(num2 * 608261534) ^ -1603836709;
					continue;
				case 46u:
					num = ((int)num2 * -1632509382) ^ 0x22E7AA09;
					continue;
				case 45u:
					BloodAvailability.smethod_19((Control)(object)Label2, 0);
					num = ((int)num2 * -1001207036) ^ -1707746446;
					continue;
				case 44u:
					BloodAvailability.smethod_56((Control)(object)this);
					num = (int)((num2 * 1594935426) ^ 0x1591243D);
					continue;
				case 43u:
					BloodAvailability.smethod_21(AmountLbl, (ContentAlignment)32);
					num = ((int)num2 * -70015317) ^ 0x99500D0;
					continue;
				case 42u:
					num = ((int)num2 * -1092519725) ^ -644148722;
					continue;
				case 41u:
					BloodAvailability.smethod_16((Control)(object)PictureBox1, new Point(272, 25));
					num = (int)((num2 * 446488904) ^ 0x19436019);
					continue;
				case 40u:
					BloodAvailability.smethod_16((Control)(object)UpdateBtn, new Point(735, 362));
					num = ((int)num2 * -1509807033) ^ -1013691751;
					continue;
				case 39u:
					num = (int)(num2 * 44607042) ^ -2124462274;
					continue;
				case 38u:
					num = ((int)num2 * -234537848) ^ 0x635746AE;
					continue;
				case 37u:
					num = (int)((num2 * 110782709) ^ 0x46059A64);
					continue;
				case 36u:
					BloodAvailability.smethod_20(Label1, "Blood Availability");
					num = (int)(num2 * 1290934289) ^ -1284747806;
					continue;
				case 35u:
					BloodAvailability.smethod_41((Control)(object)SearchResultGrid, bool_0: false);
					num = (int)((num2 * 1547932427) ^ 0x61C2F5E);
					continue;
				case 34u:
					BloodAvailability.smethod_49((ContainerControl)(object)this, (AutoScaleMode)1);
					BloodAvailability.smethod_35((Control)(object)this, Color.White);
					num = (int)(num2 * 57816788) ^ -1611261189;
					continue;
				case 33u:
					num = ((int)num2 * -511574961) ^ 0x5ABB7433;
					continue;
				case 32u:
					UpdateBtn = BloodAvailability.smethod_6();
					PictureBox1 = BloodAvailability.smethod_10();
					num = ((int)num2 * -1927044874) ^ -1125139038;
					continue;
				case 31u:
					BloodAvailability.smethod_16((Control)(object)ValueLbl, new Point(436, 380));
					num = ((int)num2 * -151676369) ^ -1219757417;
					continue;
				case 30u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_22((Control)(object)GroupBox1), (Control)(object)SearchBtn);
					num = (int)((num2 * 624760349) ^ 0x661C7D8);
					continue;
				case 29u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_50((Control)(object)this), (Control)(object)PictureBox1);
					BloodAvailability.smethod_51((Control)(object)this, "BloodAvailability");
					num = ((int)num2 * -131916760) ^ 0x211F117A;
					continue;
				case 28u:
					num = ((int)num2 * -1143046429) ^ -1293754007;
					continue;
				case 27u:
					num = ((int)num2 * -162276652) ^ -241974497;
					continue;
				case 26u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_50((Control)(object)this), (Control)(object)AmountLbl);
					num = ((int)num2 * -286932589) ^ -1221925206;
					continue;
				case 25u:
					AmountLbl = BloodAvailability.smethod_4();
					num = (int)((num2 * 606300525) ^ 0x3B96F2F);
					continue;
				case 24u:
					BloodAvailability.smethod_29((ButtonBase)(object)UpdateBtn, bool_0: false);
					num = (int)(num2 * 2035317128) ^ -526619591;
					continue;
				case 23u:
					BloodAvailability.smethod_45(PictureBox1, (PictureBoxSizeMode)1);
					num = (int)((num2 * 810872494) ^ 0x5B0907BD);
					continue;
				case 22u:
					BloodAvailability.smethod_17((Control)(object)PictureBox1, "PictureBox1");
					BloodAvailability.smethod_18((Control)(object)PictureBox1, new Size(114, 113));
					num = (int)((num2 * 1230208054) ^ 0x29C7758A);
					continue;
				case 21u:
					Label1 = BloodAvailability.smethod_4();
					num = (int)((num2 * 261650910) ^ 0x5E024EF);
					continue;
				case 20u:
					BloodAvailability.smethod_17((Control)(object)SuccessMsg, "SuccessMsg");
					num = (int)((num2 * 1631922668) ^ 0x40A91C22);
					continue;
				case 19u:
					BloodAvailability.smethod_18((Control)(object)SuccessMsg, new Size(401, 44));
					num = (int)(num2 * 1509660036) ^ -1935260652;
					continue;
				case 18u:
					BloodAvailability.smethod_17((Control)(object)Label2, "Label2");
					num = ((int)num2 * -129348059) ^ 0x24EA0903;
					continue;
				case 17u:
					BloodAvailability.smethod_54((ISupportInitialize)SearchResultGrid);
					num = ((int)num2 * -1342982323) ^ -1654851490;
					continue;
				case 16u:
					num = (int)((num2 * 1155934544) ^ 0xCB0732C);
					continue;
				case 15u:
					SuccessMsg = BloodAvailability.smethod_4();
					num = ((int)num2 * -2145544592) ^ 0x6C54F35C;
					continue;
				case 14u:
					BloodAvailability.smethod_30(BloodGrpTxt, (ComboBoxStyle)2);
					num = ((int)num2 * -238111442) ^ -911963731;
					continue;
				case 13u:
					BloodAvailability.smethod_18((Control)(object)DonorListBtn, new Size(221, 36));
					num = ((int)num2 * -1378289939) ^ 0x59B4E31;
					continue;
				case 12u:
					BloodAvailability.smethod_16((Control)(object)SearchBtn, new Point(183, 91));
					BloodAvailability.smethod_17((Control)(object)SearchBtn, "SearchBtn");
					num = (int)(num2 * 1322216157) ^ -835971639;
					continue;
				case 11u:
					BloodAvailability.smethod_26((ButtonBase)(object)DonorListBtn, Color.MidnightBlue);
					BloodAvailability.smethod_15((Control)(object)DonorListBtn, BloodAvailability.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1229582242) ^ -403050551;
					continue;
				case 10u:
					BloodAvailability.smethod_29((ButtonBase)(object)DonorListBtn, bool_0: false);
					num = ((int)num2 * -1142978975) ^ 0x2FCC9B40;
					continue;
				case 9u:
					num = (int)((num2 * 887631677) ^ 0x6AABF554);
					continue;
				case 8u:
					BloodAvailability.smethod_48((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -1084637129) ^ -626302007;
					continue;
				case 7u:
					BloodAvailability.smethod_29((ButtonBase)(object)SearchBtn, bool_0: false);
					num = ((int)num2 * -885081380) ^ -417735131;
					continue;
				case 6u:
					BloodAvailability.smethod_33(BloodAvailability.smethod_32(BloodGrpTxt), new object[9] { "--Select--", "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
					num = ((int)num2 * -1797709818) ^ -1900839809;
					continue;
				case 5u:
					BloodAvailability.smethod_19((Control)(object)SearchBtn, 22);
					num = ((int)num2 * -1207763140) ^ -1466907493;
					continue;
				case 4u:
					BloodAvailability.smethod_16((Control)(object)Label1, new Point(392, 63));
					num = (int)((num2 * 68545572) ^ 0x21A2C8FC);
					continue;
				case 3u:
					num = (int)(num2 * 771227765) ^ -1635731011;
					continue;
				case 2u:
					BloodAvailability.smethod_15((Control)(object)UpdateBtn, BloodAvailability.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -72156636) ^ -317272484;
					continue;
				case 1u:
					num = (int)(num2 * 268723385) ^ -1682441199;
					continue;
				case 0u:
					num = ((int)num2 * -1498962665) ^ 0x49CF9582;
					continue;
				default:
					return;
				case 71u:
					break;
				case 70u:
					return;
				}
				break;
			}
		}
	}

	private void BloodAvailability_Load(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1925244969;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE7BA5C22u) % 10u)
				{
				case 9u:
					BloodAvailability.smethod_60(myconnection, BloodAvailability.smethod_59(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
					num = ((int)num2 * -108524221) ^ -722809805;
					continue;
				case 8u:
					BloodAvailability.smethod_61(BloodGrpTxt, 0);
					BloodAvailability.smethod_20(AmountLbl, "Amount :");
					num = ((int)num2 * -1973221117) ^ 0x324A61CB;
					continue;
				case 7u:
					num = ((int)num2 * -347389923) ^ 0x2F65FB07;
					continue;
				case 5u:
					BloodAvailability.smethod_41((Control)(object)DonorListBtn, bool_0: false);
					num = (int)((num2 * 1904295297) ^ 0x3F631360);
					continue;
				case 4u:
					BloodAvailability.smethod_41((Control)(object)AmountLbl, bool_0: false);
					num = (int)(num2 * 1199113281) ^ -994139192;
					continue;
				case 2u:
					num = ((int)num2 * -602470625) ^ 0x1AFFE0F4;
					continue;
				case 1u:
					num = (int)(num2 * 1460546564) ^ -1387642657;
					continue;
				case 0u:
					BloodAvailability.smethod_41((Control)(object)ValueLbl, bool_0: false);
					num = (int)(num2 * 141517987) ^ -1783072505;
					continue;
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

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Expected I4, but got Unknown
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected I4, but got Unknown
		//IL_05e6: Incompatible stack heights: 0 vs 1
		//IL_05f6: Incompatible stack heights: 0 vs 1
		//IL_060b: Incompatible stack heights: 0 vs 1
		//IL_0626: Incompatible stack heights: 0 vs 1
		//IL_062d: Incompatible stack heights: 0 vs 1
		bool flag3 = default(bool);
		OleDbCommand oleDbCommand_ = default(OleDbCommand);
		string string_ = default(string);
		bool flag = default(bool);
		decimal num4 = default(decimal);
		bool flag2 = default(bool);
		OleDbDataReader oleDbDataReader_ = default(OleDbDataReader);
		while (true)
		{
			int num = -1209358321;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x98074AEFu) % 17u)
				{
				case 16u:
					num = ((int)num2 * -1818309942) ^ -812184722;
					continue;
				case 15u:
					BloodAvailability.smethod_41((Control)(object)UpdateBtn, bool_0: false);
					flag3 = BloodAvailability.smethod_62(BloodGrpTxt) == 0;
					num = (int)(num2 * 15425210) ^ -2090823790;
					continue;
				case 14u:
					BloodAvailability.smethod_20(SuccessMsg, "Select Blood Group");
					num = ((int)num2 * -559377870) ^ -1026830973;
					continue;
				case 13u:
					BloodAvailability.smethod_35((Control)(object)SuccessMsg, Color.Red);
					BloodAvailability.smethod_63(Timer1);
					num = ((int)num2 * -1517028945) ^ 0x11F140AC;
					continue;
				case 12u:
					num = (int)(num2 * 1456911924) ^ -1354229384;
					continue;
				case 11u:
				{
					int num12;
					int num13;
					if (!flag3)
					{
						num12 = -998071922;
						num13 = -998071922;
					}
					else
					{
						num12 = -192945914;
						num13 = -192945914;
					}
					num = num12 ^ ((int)num2 * -1335166737);
					continue;
				}
				case 10u:
					BloodAvailability.smethod_41((Control)(object)DonorListBtn, bool_0: false);
					num = (int)(num2 * 926559263) ^ -1682889520;
					continue;
				case 9u:
					BloodAvailability.smethod_41((Control)(object)ValueLbl, bool_0: false);
					num = (int)(num2 * 650462894) ^ -1824964782;
					continue;
				case 8u:
					BloodAvailability.smethod_41((Control)(object)SuccessMsg, bool_0: true);
					num = (int)((num2 * 111447191) ^ 0x28B3A854);
					continue;
				case 6u:
					num = ((int)num2 * -830827061) ^ 0x1B9CE243;
					continue;
				case 4u:
					BloodAvailability.smethod_41((Control)(object)AmountLbl, bool_0: false);
					num = ((int)num2 * -1996518725) ^ -1498248962;
					continue;
				case 3u:
					BloodAvailability.smethod_41((Control)(object)SearchResultGrid, bool_0: false);
					num = (int)(num2 * 1451222094) ^ -2078002346;
					continue;
				case 1u:
					num = ((int)num2 * -633797450) ^ -670503176;
					continue;
				case 0u:
					oleDbCommand_ = BloodAvailability.smethod_64();
					string_ = BloodAvailability.smethod_66("Select * From [Blood_available] Where [Blood Group] Like '%", BloodAvailability.smethod_65(BloodGrpTxt), "%';");
					BloodAvailability.smethod_67();
					num = -1916048018;
					continue;
				case 5u:
					break;
				default:
					BloodAvailability.smethod_68(myconnection);
					try
					{
						while (true)
						{
							IL_0596:
							int num3 = -377597856;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x98074AEFu) % 26u)
								{
								case 25u:
								{
									int num9;
									int num10;
									if (BloodAvailability.smethod_81(BloodAvailability.smethod_80(MyProject.Forms.Form1.login_type), "admin", bool_0: false) != 0)
									{
										num9 = -1032639600;
										num10 = -1032639600;
									}
									else
									{
										num9 = -480451504;
										num10 = -480451504;
									}
									num3 = num9 ^ ((int)num2 * -1163906712);
									continue;
								}
								case 24u:
									BloodAvailability.smethod_41((Control)(object)AmountLbl, bool_0: true);
									num3 = -424597463;
									continue;
								case 23u:
									BloodAvailability.smethod_41((Control)(object)UpdateBtn, bool_0: true);
									num3 = (int)(num2 * 1426766181) ^ -1728309507;
									continue;
								case 22u:
									flag = decimal.Compare(num4, 0m) == 0;
									num3 = ((int)num2 * -1842099329) ^ -441037989;
									continue;
								case 21u:
									oleDbCommand_ = BloodAvailability.smethod_69(string_, myconnection);
									num3 = (int)(num2 * 619569338) ^ -586997259;
									continue;
								case 20u:
								{
									int num7;
									int num8;
									if (flag2)
									{
										num7 = -2052699619;
										num8 = -2052699619;
									}
									else
									{
										num7 = -1984325013;
										num8 = -1984325013;
									}
									num3 = num7 ^ ((int)num2 * -419362197);
									continue;
								}
								case 19u:
									flag2 = BloodAvailability.smethod_75(oleDbDataReader_);
									num3 = -308222473;
									continue;
								case 18u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = -849078790;
										num6 = -849078790;
									}
									else
									{
										num5 = -570388023;
										num6 = -570388023;
									}
									num3 = num5 ^ ((int)num2 * -802007969);
									continue;
								}
								case 17u:
									BloodAvailability.smethod_41((Control)(object)DonorListBtn, bool_0: true);
									num3 = ((int)num2 * -1377851013) ^ 0x5643AEC5;
									continue;
								case 16u:
									BloodAvailability.smethod_76(myconnection);
									num3 = ((int)num2 * -565890730) ^ 0x48C353E4;
									continue;
								case 15u:
									num3 = (int)(num2 * 1189183277) ^ -1658931804;
									continue;
								case 14u:
									num3 = ((int)num2 * -1650586006) ^ 0x511E551F;
									continue;
								case 13u:
									num4 = BloodAvailability.smethod_79(BloodAvailability.smethod_78(BloodAvailability.smethod_77(ValueLbl), new char[1] { ' ' })[0]);
									num3 = (int)(num2 * 1500572476) ^ -700284040;
									continue;
								case 12u:
									oleDbDataReader_ = BloodAvailability.smethod_70(oleDbCommand_);
									num3 = (int)(num2 * 8343165) ^ -1586470234;
									continue;
								case 11u:
									num3 = ((int)num2 * -986370562) ^ 0x147650E;
									continue;
								case 10u:
									BloodAvailability.smethod_41((Control)(object)ValueLbl, bool_0: true);
									num3 = (int)((num2 * 1171651395) ^ 0x4D2536EE);
									continue;
								case 7u:
									MyProject.Forms.Form1.cur_blood_amount = num4;
									num3 = (int)(num2 * 1121642298) ^ -877797227;
									continue;
								case 6u:
									MyProject.Forms.Form1.blood_available_id = BloodAvailability.smethod_72(BloodAvailability.smethod_71(oleDbDataReader_, 0));
									num3 = -1916029627;
									continue;
								case 5u:
									blood_group = BloodAvailability.smethod_65(BloodGrpTxt);
									num3 = -1444033645;
									continue;
								case 4u:
									BloodAvailability.smethod_20(ValueLbl, BloodAvailability.smethod_74(BloodAvailability.smethod_73(BloodAvailability.smethod_71(oleDbDataReader_, 2), (object)" litres")));
									num3 = ((int)num2 * -1672251447) ^ 0x264ADED;
									continue;
								case 3u:
									BloodAvailability.smethod_35((Control)(object)ValueLbl, Color.Red);
									num3 = (int)((num2 * 1035596598) ^ 0x6F8786D2);
									continue;
								case 2u:
									num3 = (int)(num2 * 1091204202) ^ -1794784742;
									continue;
								case 1u:
									num3 = (int)((num2 * 1995244239) ^ 0x16CA5F19);
									continue;
								case 0u:
									BloodAvailability.smethod_35((Control)(object)ValueLbl, Color.Green);
									num3 = -131966631;
									continue;
								default:
									goto end_IL_051b;
								case 9u:
									break;
								case 8u:
									goto end_IL_051b;
								}
								goto IL_0596;
								continue;
								end_IL_051b:
								break;
							}
							break;
						}
					}
					catch (Exception exception_)
					{
						BloodAvailability.smethod_82(exception_);
						while (true)
						{
							IL_0628:
							_ = -1344023456;
							while (true)
							{
								_003F val = /*Error near IL_05b4: Stack underflow*/^ -1744352529;
								num2 = (uint)(int)val;
								switch (val % 6)
								{
								default:
									goto end_IL_05ae;
								case 5:
									_ = ((int)num2 * -2103588885) ^ 0x52207A57;
									continue;
								case 3:
									_ = (num2 * 603828719) ^ 0xFC851C96u;
									continue;
								case 2:
									BloodAvailability.smethod_83();
									_ = (num2 * 229955506) ^ 0xFA6C5BD3u;
									continue;
								case 1:
									BloodAvailability.smethod_76(myconnection);
									_ = ((int)num2 * -718183890) ^ 0x110DE848;
									continue;
								case 0:
									break;
								case 4:
									goto end_IL_05ae;
								}
								goto IL_0628;
								continue;
								end_IL_05ae:
								break;
							}
							break;
						}
					}
					while (true)
					{
						int num11 = -1084577520;
						while (true)
						{
							switch ((num2 = (uint)num11 ^ 0x98074AEFu) % 3u)
							{
							case 2u:
								goto IL_0634;
							default:
								return;
							case 0u:
								break;
							case 1u:
								return;
							}
							break;
							IL_0634:
							num11 = (int)((num2 * 2135025580) ^ 0x72D427F1);
						}
					}
				case 7u:
					return;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected I4, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected I4, but got Unknown
		//IL_0351: Incompatible stack heights: 0 vs 1
		//IL_0366: Incompatible stack heights: 0 vs 1
		//IL_0381: Incompatible stack heights: 0 vs 1
		//IL_0388: Incompatible stack heights: 0 vs 1
		bool flag2 = default(bool);
		string string_ = default(string);
		DataTable dataTable = default(DataTable);
		bool flag = default(bool);
		while (true)
		{
			int num = -1346273641;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBA8A138Eu) % 14u)
				{
				case 12u:
					num = -1453864457;
					continue;
				case 11u:
					BloodAvailability.smethod_63(Timer1);
					num = (int)((num2 * 1372872729) ^ 0x35498A2D);
					continue;
				case 9u:
					flag2 = BloodAvailability.smethod_62(BloodGrpTxt) == 0;
					num = (int)(num2 * 1233349662) ^ -294485860;
					continue;
				case 8u:
					num = (int)((num2 * 645149961) ^ 0x3AC49934);
					continue;
				case 6u:
					num = ((int)num2 * -386763473) ^ -1964527533;
					continue;
				case 5u:
					BloodAvailability.smethod_64();
					num = (int)((num2 * 1609874775) ^ 0x4197F717);
					continue;
				case 4u:
					string_ = BloodAvailability.smethod_66("Select * From [Donor] Where [Blood] Like '%", blood_group, "%';");
					dataTable = BloodAvailability.smethod_67();
					num = (int)(num2 * 875859156) ^ -2003550691;
					continue;
				case 3u:
					BloodAvailability.smethod_41((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -503488349) ^ 0x54A88A41;
					continue;
				case 2u:
					BloodAvailability.smethod_20(SuccessMsg, "Select Blood Group");
					BloodAvailability.smethod_35((Control)(object)SuccessMsg, Color.Red);
					num = (int)(num2 * 111732703) ^ -1799016107;
					continue;
				case 1u:
					BloodAvailability.smethod_68(myconnection);
					num = (int)((num2 * 816250620) ^ 0x15C15EBD);
					continue;
				case 0u:
				{
					int num6;
					int num7;
					if (!flag2)
					{
						num6 = 572591282;
						num7 = 572591282;
					}
					else
					{
						num6 = 290074855;
						num7 = 290074855;
					}
					num = num6 ^ ((int)num2 * -1247790278);
					continue;
				}
				case 10u:
					break;
				default:
					try
					{
						while (true)
						{
							int num3 = -1054989745;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xBA8A138Eu) % 13u)
								{
								case 12u:
									num3 = (int)(num2 * 1003669788) ^ -1452139349;
									continue;
								case 11u:
									HideUnusedColumns();
									BloodAvailability.smethod_41((Control)(object)SearchResultGrid, bool_0: true);
									num3 = (int)(num2 * 2137433859) ^ -1639359259;
									continue;
								case 10u:
									num3 = -1022139848;
									continue;
								case 9u:
								{
									int num4;
									int num5;
									if (flag)
									{
										num4 = 1013434409;
										num5 = 1013434409;
									}
									else
									{
										num4 = 1322013547;
										num5 = 1322013547;
									}
									num3 = num4 ^ (int)(num2 * 2001062451);
									continue;
								}
								case 8u:
									num3 = (int)((num2 * 366674979) ^ 0x185B62A3);
									continue;
								case 5u:
								{
									OleDbDataAdapter dbDataAdapter_ = BloodAvailability.smethod_84(string_, myconnection);
									BloodAvailability.smethod_85((DbDataAdapter)(object)dbDataAdapter_, dataTable);
									BloodAvailability.smethod_86(SearchResultGrid, (object)dataTable);
									num3 = ((int)num2 * -1384112205) ^ 0x136689FC;
									continue;
								}
								case 4u:
									BloodAvailability.smethod_76(myconnection);
									num3 = ((int)num2 * -211496601) ^ 0x36B06F30;
									continue;
								case 3u:
									BloodAvailability.smethod_88("No Result Found");
									num3 = ((int)num2 * -2141037799) ^ -2034800457;
									continue;
								case 1u:
									flag = BloodAvailability.smethod_87(SearchResultGrid) == 1;
									num3 = ((int)num2 * -101413235) ^ 0x40369103;
									continue;
								case 0u:
									BloodAvailability.smethod_76(myconnection);
									num3 = (int)((num2 * 372698423) ^ 0x1858C08C);
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
						BloodAvailability.smethod_82(exception_);
						while (true)
						{
							_ = -1395930092;
							while (true)
							{
								_003F val = /*Error near IL_0323: Stack underflow*/^ -1165356146;
								num2 = (uint)(int)val;
								switch (val % 5)
								{
								default:
									return;
								case 4:
									_ = ((int)num2 * -1878734805) ^ -1794010258;
									continue;
								case 2:
									BloodAvailability.smethod_83();
									_ = ((int)num2 * -1721270175) ^ -650672904;
									continue;
								case 0:
									BloodAvailability.smethod_76(myconnection);
									_ = (num2 * 1782684950) ^ 0xD3279C80u;
									continue;
								case 3:
									break;
								case 1:
									return;
								}
								break;
							}
						}
					}
				case 13u:
					return;
				}
				break;
			}
		}
	}

	private bool HideUnusedColumns()
	{
		int num3 = default(int);
		bool result = default(bool);
		while (true)
		{
			int num = -449666640;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBB9E1B9Fu) % 7u)
				{
				case 6u:
					BloodAvailability.smethod_91(BloodAvailability.smethod_90(BloodAvailability.smethod_89(SearchResultGrid), num3), bool_0: false);
					num = -1200293721;
					continue;
				case 4u:
					num3 = 3;
					num = (int)(num2 * 1168210359) ^ -516928486;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (num3 <= 8)
					{
						num4 = -1916709277;
						num5 = -1916709277;
					}
					else
					{
						num4 = -80097753;
						num5 = -80097753;
					}
					num = num4 ^ (int)(num2 * 2127033712);
					continue;
				}
				case 1u:
					BloodAvailability.smethod_91(BloodAvailability.smethod_90(BloodAvailability.smethod_89(SearchResultGrid), 5), bool_0: true);
					result = true;
					num = ((int)num2 * -1286842983) ^ 0x13C68C93;
					continue;
				case 0u:
					num3 = checked(num3 + 1);
					num = (int)((num2 * 1796538937) ^ 0x649D0685);
					continue;
				case 3u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private void UpdateBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1409250434;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x87BE8AE9u) % 7u)
				{
				case 6u:
					BloodAvailability.smethod_41((Control)(object)ValueLbl, bool_0: false);
					num = ((int)num2 * -14722992) ^ 0x6A08E9DC;
					continue;
				case 5u:
					BloodAvailability.smethod_41((Control)(object)AmountLbl, bool_0: false);
					num = (int)(num2 * 1666330884) ^ -589088371;
					continue;
				case 4u:
					BloodAvailability.smethod_92((Control)(object)MyProject.Forms.Form4);
					num = (int)(num2 * 423497052) ^ -1900976046;
					continue;
				case 3u:
					num = ((int)num2 * -891543909) ^ 0x779834F3;
					continue;
				case 0u:
					BloodAvailability.smethod_41((Control)(object)UpdateBtn, bool_0: false);
					BloodAvailability.smethod_41((Control)(object)SearchResultGrid, bool_0: false);
					num = ((int)num2 * -1435303473) ^ -475248848;
					continue;
				case 2u:
					break;
				default:
					BloodAvailability.smethod_41((Control)(object)DonorListBtn, bool_0: false);
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

	static Container smethod_3()
	{
		return new Container();
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

	static ComboBox smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ComboBox();
	}

	static DataGridView smethod_8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DataGridView();
	}

	static Timer smethod_9(IContainer icontainer_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_0);
	}

	static PictureBox smethod_10()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PictureBox();
	}

	static void smethod_11(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_12(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_13(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static Font smethod_14(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_15(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_16(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_17(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_18(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_19(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_20(Label label_0, string string_0)
	{
		label_0.set_Text(string_0);
	}

	static void smethod_21(Label label_0, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_TextAlign(contentAlignment_0);
	}

	static ControlCollection smethod_22(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_23(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_24(GroupBox groupBox_0, bool bool_0)
	{
		groupBox_0.set_TabStop(bool_0);
	}

	static void smethod_25(GroupBox groupBox_0, string string_0)
	{
		groupBox_0.set_Text(string_0);
	}

	static void smethod_26(ButtonBase buttonBase_0, Color color_0)
	{
		buttonBase_0.set_BackColor(color_0);
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

	static void smethod_30(ComboBox comboBox_0, ComboBoxStyle comboBoxStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		comboBox_0.set_DropDownStyle(comboBoxStyle_0);
	}

	static void smethod_31(ListControl listControl_0, bool bool_0)
	{
		listControl_0.set_FormattingEnabled(bool_0);
	}

	static ObjectCollection smethod_32(ComboBox comboBox_0)
	{
		return comboBox_0.get_Items();
	}

	static void smethod_33(ObjectCollection objectCollection_0, object[] object_0)
	{
		objectCollection_0.AddRange(object_0);
	}

	static void smethod_34(Label label_0, bool bool_0)
	{
		label_0.set_AutoSize(bool_0);
	}

	static void smethod_35(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static void smethod_36(DataGridView dataGridView_0, Color color_0)
	{
		dataGridView_0.set_BackgroundColor(color_0);
	}

	static void smethod_37(DataGridView dataGridView_0, DataGridViewColumnHeadersHeightSizeMode dataGridViewColumnHeadersHeightSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		dataGridView_0.set_ColumnHeadersHeightSizeMode(dataGridViewColumnHeadersHeightSizeMode_0);
	}

	static void smethod_38(DataGridView dataGridView_0, bool bool_0)
	{
		dataGridView_0.set_ReadOnly(bool_0);
	}

	static DataGridViewRow smethod_39(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_RowTemplate();
	}

	static void smethod_40(DataGridViewRow dataGridViewRow_0, int int_0)
	{
		dataGridViewRow_0.set_Height(int_0);
	}

	static void smethod_41(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static Font smethod_42(string string_0, float float_0, FontStyle fontStyle_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0);
	}

	static void smethod_43(Timer timer_0, int int_0)
	{
		timer_0.set_Interval(int_0);
	}

	static void smethod_44(PictureBox pictureBox_0, Image image_0)
	{
		pictureBox_0.set_Image(image_0);
	}

	static void smethod_45(PictureBox pictureBox_0, PictureBoxSizeMode pictureBoxSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		pictureBox_0.set_SizeMode(pictureBoxSizeMode_0);
	}

	static void smethod_46(PictureBox pictureBox_0, int int_0)
	{
		pictureBox_0.set_TabIndex(int_0);
	}

	static void smethod_47(PictureBox pictureBox_0, bool bool_0)
	{
		pictureBox_0.set_TabStop(bool_0);
	}

	static void smethod_48(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_49(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static ControlCollection smethod_50(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_51(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_52(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_53(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_54(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_55(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_56(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_57(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_58(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static string smethod_59(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_60(OleDbConnection oleDbConnection_0, string string_0)
	{
		oleDbConnection_0.set_ConnectionString(string_0);
	}

	static void smethod_61(ComboBox comboBox_0, int int_0)
	{
		comboBox_0.set_SelectedIndex(int_0);
	}

	static int smethod_62(ComboBox comboBox_0)
	{
		return comboBox_0.get_SelectedIndex();
	}

	static void smethod_63(Timer timer_0)
	{
		timer_0.Start();
	}

	static OleDbCommand smethod_64()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new OleDbCommand();
	}

	static string smethod_65(ComboBox comboBox_0)
	{
		return comboBox_0.get_Text();
	}

	static string smethod_66(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static DataTable smethod_67()
	{
		return new DataTable();
	}

	static void smethod_68(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Open();
	}

	static OleDbCommand smethod_69(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbCommand(string_0, oleDbConnection_0);
	}

	static OleDbDataReader smethod_70(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.ExecuteReader();
	}

	static object smethod_71(OleDbDataReader oleDbDataReader_0, int int_0)
	{
		return oleDbDataReader_0.get_Item(int_0);
	}

	static int smethod_72(object object_0)
	{
		return Conversions.ToInteger(object_0);
	}

	static object smethod_73(object object_0, object object_1)
	{
		return Operators.AddObject(object_0, object_1);
	}

	static string smethod_74(object object_0)
	{
		return Conversions.ToString(object_0);
	}

	static bool smethod_75(OleDbDataReader oleDbDataReader_0)
	{
		return oleDbDataReader_0.Read();
	}

	static void smethod_76(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Close();
	}

	static string smethod_77(Label label_0)
	{
		return label_0.get_Text();
	}

	static string[] smethod_78(string string_0, char[] char_0)
	{
		return string_0.Split(char_0);
	}

	static decimal smethod_79(string string_0)
	{
		return Convert.ToDecimal(string_0);
	}

	static string smethod_80(string string_0)
	{
		return string_0.ToLower();
	}

	static int smethod_81(string string_0, string string_1, bool bool_0)
	{
		return Operators.CompareString(string_0, string_1, bool_0);
	}

	static void smethod_82(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_83()
	{
		ProjectData.ClearProjectError();
	}

	static OleDbDataAdapter smethod_84(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbDataAdapter(string_0, oleDbConnection_0);
	}

	static int smethod_85(DbDataAdapter dbDataAdapter_0, DataTable dataTable_0)
	{
		return dbDataAdapter_0.Fill(dataTable_0);
	}

	static void smethod_86(DataGridView dataGridView_0, object object_0)
	{
		dataGridView_0.set_DataSource(object_0);
	}

	static int smethod_87(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_RowCount();
	}

	static DialogResult smethod_88(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}

	static DataGridViewColumnCollection smethod_89(DataGridView dataGridView_0)
	{
		return dataGridView_0.get_Columns();
	}

	static DataGridViewColumn smethod_90(DataGridViewColumnCollection dataGridViewColumnCollection_0, int int_0)
	{
		return dataGridViewColumnCollection_0.get_Item(int_0);
	}

	static void smethod_91(DataGridViewColumn dataGridViewColumn_0, bool bool_0)
	{
		dataGridViewColumn_0.set_Visible(bool_0);
	}

	static void smethod_92(Control control_0)
	{
		control_0.Show();
	}
}
