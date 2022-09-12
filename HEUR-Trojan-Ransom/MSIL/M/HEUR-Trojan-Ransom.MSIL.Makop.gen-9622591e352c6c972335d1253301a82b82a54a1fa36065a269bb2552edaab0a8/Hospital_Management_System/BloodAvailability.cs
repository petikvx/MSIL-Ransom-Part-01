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
			Button searchBtn = default(Button);
			while (true)
			{
				int num = -106728623;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB1F56BD6u) % 9u)
					{
					case 8u:
						BloodAvailability.smethod_58((Control)(object)searchBtn, eventHandler_);
						num = ((int)num2 * -997621089) ^ -1136424931;
						continue;
					case 7u:
					{
						int num5;
						int num6;
						if (searchBtn == null)
						{
							num5 = 1638995170;
							num6 = 1638995170;
						}
						else
						{
							num5 = 903501942;
							num6 = 903501942;
						}
						num = num5 ^ (int)(num2 * 1481518168);
						continue;
					}
					case 5u:
						searchBtn = _SearchBtn;
						num = ((int)num2 * -690661390) ^ 0x658C6B1A;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (searchBtn == null)
						{
							num3 = 1787121867;
							num4 = 1787121867;
						}
						else
						{
							num3 = 786102204;
							num4 = 786102204;
						}
						num = num3 ^ (int)(num2 * 1025813736);
						continue;
					}
					case 3u:
						searchBtn = _SearchBtn;
						num = (int)(num2 * 642229977) ^ -456338014;
						continue;
					case 2u:
						_SearchBtn = value;
						num = -1524143771;
						continue;
					case 1u:
						BloodAvailability.smethod_57((Control)(object)searchBtn, eventHandler_);
						num = (int)((num2 * 169315078) ^ 0x69C8FDB2);
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
				int num = -1563466095;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA0F5F5E5u) % 9u)
					{
					case 8u:
						BloodAvailability.smethod_58((Control)(object)donorListBtn, eventHandler_);
						num = (int)(num2 * 1853769537) ^ -1000041720;
						continue;
					case 7u:
					{
						int num5;
						int num6;
						if (donorListBtn == null)
						{
							num5 = 691621618;
							num6 = 691621618;
						}
						else
						{
							num5 = 1740061343;
							num6 = 1740061343;
						}
						num = num5 ^ ((int)num2 * -854070570);
						continue;
					}
					case 6u:
						_DonorListBtn = value;
						num = -544261180;
						continue;
					case 5u:
						donorListBtn = _DonorListBtn;
						num = (int)(num2 * 948305680) ^ -494969267;
						continue;
					case 4u:
						BloodAvailability.smethod_57((Control)(object)donorListBtn, eventHandler_);
						num = (int)(num2 * 586919928) ^ -521886252;
						continue;
					case 2u:
						donorListBtn = _DonorListBtn;
						num = ((int)num2 * -1322560198) ^ -1351637031;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (donorListBtn != null)
						{
							num3 = 435929342;
							num4 = 435929342;
						}
						else
						{
							num3 = 357957132;
							num4 = 357957132;
						}
						num = num3 ^ ((int)num2 * -294483130);
						continue;
					}
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
			Button updateBtn = default(Button);
			while (true)
			{
				int num = -1540373953;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x965D6358u) % 8u)
					{
					case 7u:
						updateBtn = _UpdateBtn;
						num = (int)(num2 * 1076325673) ^ -648565633;
						continue;
					case 4u:
						BloodAvailability.smethod_58((Control)(object)updateBtn, eventHandler_);
						num = (int)((num2 * 1426559353) ^ 0x42F9672A);
						continue;
					case 3u:
					{
						int num5;
						int num6;
						if (updateBtn == null)
						{
							num5 = -1875852759;
							num6 = -1875852759;
						}
						else
						{
							num5 = -1493686917;
							num6 = -1493686917;
						}
						num = num5 ^ ((int)num2 * -74912899);
						continue;
					}
					case 2u:
						BloodAvailability.smethod_57((Control)(object)updateBtn, eventHandler_);
						num = (int)(num2 * 646898921) ^ -1400872389;
						continue;
					case 1u:
						_UpdateBtn = value;
						updateBtn = _UpdateBtn;
						num = -331918389;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (updateBtn != null)
						{
							num3 = 528098042;
							num4 = 528098042;
						}
						else
						{
							num3 = 926764425;
							num4 = 926764425;
						}
						num = num3 ^ (int)(num2 * 1289298931);
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

	public BloodAvailability()
	{
		BloodAvailability.smethod_0((UserControl)(object)this, (EventHandler)BloodAvailability_Load);
		myconnection = BloodAvailability.smethod_1();
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
				int num = 1242768126;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x7E7B8276u) % 6u)
					{
					case 5u:
						num3 = ((components != null) ? 1 : 0);
						goto IL_0010;
					case 4u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -1644105961;
							num5 = -1644105961;
						}
						else
						{
							num4 = -1049339215;
							num5 = -1049339215;
						}
						num = num4 ^ ((int)num2 * -906818314);
						continue;
					}
					case 3u:
						BloodAvailability.smethod_2((IDisposable)components);
						num = ((int)num2 * -985623438) ^ 0x5C0786B1;
						continue;
					case 2u:
						if (disposing)
						{
							num = ((int)num2 * -416400847) ^ 0x41E93D59;
							continue;
						}
						num3 = 0;
						goto IL_0010;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
						IL_0010:
						flag = (byte)num3 != 0;
						num = 1920206074;
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
				int num6 = 343255433;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num6 ^ 0x7E7B8276u) % 4u)
					{
					case 3u:
						((ContainerControl)this).Dispose(disposing);
						num6 = ((int)num2 * -1724574966) ^ -56167624;
						continue;
					case 0u:
						num6 = ((int)num2 * -896395460) ^ -766392517;
						continue;
					default:
						goto end_IL_00c3;
					case 2u:
						break;
					case 1u:
						goto end_IL_00c3;
					}
					goto IL_00e4;
					continue;
					end_IL_00c3:
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
			int num = 74960404;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x12A70F72u) % 161u)
				{
				case 160u:
					BloodAvailability.smethod_43(Timer1, 1500);
					num = ((int)num2 * -550973049) ^ -689276412;
					continue;
				case 159u:
					BloodAvailability.smethod_49((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1211337296) ^ -1504426017;
					continue;
				case 158u:
					num = (int)((num2 * 1242501843) ^ 0x787713FB);
					continue;
				case 157u:
					components = BloodAvailability.smethod_3();
					Label1 = BloodAvailability.smethod_4();
					num = (int)((num2 * 1895102198) ^ 0x6478CD88);
					continue;
				case 156u:
					BloodAvailability.smethod_25(GroupBox1, "Search");
					BloodAvailability.smethod_26((ButtonBase)(object)SearchBtn, Color.MidnightBlue);
					BloodAvailability.smethod_15((Control)(object)SearchBtn, BloodAvailability.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1436373366) ^ 0x868927A;
					continue;
				case 155u:
					num = (int)(num2 * 2024569512) ^ -203410293;
					continue;
				case 154u:
					BloodAvailability.smethod_18((Control)(object)AmountLbl, new Size(131, 35));
					num = ((int)num2 * -342153156) ^ 0x34161A9F;
					continue;
				case 153u:
					BloodAvailability.smethod_41((Control)(object)SearchResultGrid, bool_0: false);
					num = (int)((num2 * 411149381) ^ 0x5823A22D);
					continue;
				case 152u:
					num = (int)(num2 * 1506510146) ^ -152215281;
					continue;
				case 151u:
					BloodAvailability.smethod_17((Control)(object)UpdateBtn, "UpdateBtn");
					num = (int)((num2 * 563236479) ^ 0x5C73C87D);
					continue;
				case 150u:
					BloodAvailability.smethod_15((Control)(object)Label1, BloodAvailability.smethod_14("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -442173278) ^ -1994523115;
					continue;
				case 149u:
					BloodAvailability.smethod_16((Control)(object)UpdateBtn, new Point(735, 362));
					num = (int)((num2 * 1316687393) ^ 0x44C93696);
					continue;
				case 148u:
					BloodAvailability.smethod_18((Control)(object)ValueLbl, new Size(64, 24));
					num = ((int)num2 * -1609134738) ^ 0x7A18E07C;
					continue;
				case 147u:
					GroupBox1 = BloodAvailability.smethod_5();
					SearchBtn = BloodAvailability.smethod_6();
					num = (int)((num2 * 722349546) ^ 0x1E116C11);
					continue;
				case 146u:
					num = ((int)num2 * -1862964334) ^ -285455908;
					continue;
				case 145u:
					BloodAvailability.smethod_26((ButtonBase)(object)UpdateBtn, Color.MidnightBlue);
					num = (int)((num2 * 1907829107) ^ 0x21AE48D);
					continue;
				case 144u:
					BloodAvailability.smethod_44(PictureBox1, (Image)(object)Resources.blood_goodpic);
					num = (int)((num2 * 703489603) ^ 0x3989BED7);
					continue;
				case 143u:
					BloodAvailability.smethod_27((Control)(object)SearchBtn, Color.White);
					num = (int)((num2 * 671795729) ^ 0x624D7C53);
					continue;
				case 142u:
					num = (int)((num2 * 1897189618) ^ 0x614D1EC9);
					continue;
				case 141u:
					BloodAvailability.smethod_53((Control)(object)GroupBox1, bool_0: false);
					num = ((int)num2 * -1748870034) ^ 0x18E8430;
					continue;
				case 140u:
					BloodAvailability.smethod_28((ButtonBase)(object)UpdateBtn, "Update Blood Amount");
					num = ((int)num2 * -667418631) ^ -578307042;
					continue;
				case 139u:
					BloodAvailability.smethod_33(BloodAvailability.smethod_32(BloodGrpTxt), new object[9] { "--Select--", "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
					num = (int)((num2 * 575284470) ^ 0x13F03294);
					continue;
				case 138u:
					BloodAvailability.smethod_18((Control)(object)PictureBox1, new Size(114, 113));
					BloodAvailability.smethod_45(PictureBox1, (PictureBoxSizeMode)1);
					BloodAvailability.smethod_46(PictureBox1, 10);
					num = ((int)num2 * -1951429814) ^ 0x1A97ABF7;
					continue;
				case 137u:
					num = ((int)num2 * -949724959) ^ -907348660;
					continue;
				case 136u:
					num = ((int)num2 * -1430837471) ^ 0x7F437EAE;
					continue;
				case 135u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_22((Control)(object)GroupBox1), (Control)(object)BloodGrpTxt);
					num = (int)(num2 * 2043753746) ^ -368303650;
					continue;
				case 134u:
					BloodAvailability.smethod_17((Control)(object)SearchResultGrid, "SearchResultGrid");
					num = (int)((num2 * 947404823) ^ 0x4F9BD648);
					continue;
				case 133u:
					BloodAvailability.smethod_54((ISupportInitialize)SearchResultGrid);
					num = (int)((num2 * 1257824722) ^ 0xE3C73AE);
					continue;
				case 132u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_50((Control)(object)this), (Control)(object)ValueLbl);
					num = (int)((num2 * 1193162902) ^ 0x3FDB8381);
					continue;
				case 131u:
					num = (int)((num2 * 1876169672) ^ 0x5B948D4C);
					continue;
				case 130u:
					num = (int)(num2 * 1133666747) ^ -1893250125;
					continue;
				case 129u:
					BloodAvailability.smethod_20(Label2, "Blood Group :");
					num = (int)(num2 * 325188648) ^ -1398083204;
					continue;
				case 128u:
					BloodAvailability.smethod_16((Control)(object)Label1, new Point(392, 63));
					num = ((int)num2 * -1266005988) ^ -815677966;
					continue;
				case 127u:
					num = ((int)num2 * -1657992270) ^ 0x1C0A7904;
					continue;
				case 126u:
					num = ((int)num2 * -1857271506) ^ 0x15D80408;
					continue;
				case 125u:
					num = (int)(num2 * 1909718835) ^ -463892606;
					continue;
				case 124u:
					BloodAvailability.smethod_16((Control)(object)ValueLbl, new Point(436, 380));
					num = (int)(num2 * 1222930393) ^ -156473259;
					continue;
				case 123u:
					BloodAvailability.smethod_34(ValueLbl, bool_0: true);
					num = ((int)num2 * -834475262) ^ -485352940;
					continue;
				case 122u:
					BloodGrpTxt = BloodAvailability.smethod_7();
					num = ((int)num2 * -1523951551) ^ 0x18FA52F9;
					continue;
				case 121u:
					BloodAvailability.smethod_35((Control)(object)this, Color.White);
					num = ((int)num2 * -1251011055) ^ -105119335;
					continue;
				case 120u:
					BloodAvailability.smethod_15((Control)(object)UpdateBtn, BloodAvailability.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -521951853) ^ -1584127594;
					continue;
				case 118u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_50((Control)(object)this), (Control)(object)DonorListBtn);
					num = ((int)num2 * -1878833257) ^ -710097619;
					continue;
				case 117u:
					BloodAvailability.smethod_16((Control)(object)AmountLbl, new Point(299, 369));
					BloodAvailability.smethod_17((Control)(object)AmountLbl, "AmountLbl");
					num = (int)(num2 * 1167445495) ^ -719950866;
					continue;
				case 116u:
					BloodAvailability.smethod_52((Control)(object)this, new Size(977, 804));
					num = (int)((num2 * 1897555163) ^ 0x38DC3606);
					continue;
				case 115u:
					BloodAvailability.smethod_19((Control)(object)Label2, 0);
					num = ((int)num2 * -535626155) ^ 0x6FB1B74A;
					continue;
				case 114u:
					BloodAvailability.smethod_21(ValueLbl, (ContentAlignment)32);
					num = ((int)num2 * -851322620) ^ -166135980;
					continue;
				case 113u:
					BloodAvailability.smethod_18((Control)(object)Label1, new Size(330, 47));
					BloodAvailability.smethod_19((Control)(object)Label1, 11);
					BloodAvailability.smethod_20(Label1, "Blood Availability");
					num = (int)(num2 * 1491523509) ^ -872237850;
					continue;
				case 112u:
					BloodAvailability.smethod_24(GroupBox1, bool_0: false);
					num = ((int)num2 * -2139740991) ^ -205349711;
					continue;
				case 111u:
					BloodAvailability.smethod_18((Control)(object)SuccessMsg, new Size(401, 44));
					num = ((int)num2 * -688897137) ^ -2122366591;
					continue;
				case 110u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_50((Control)(object)this), (Control)(object)GroupBox1);
					BloodAvailability.smethod_23(BloodAvailability.smethod_50((Control)(object)this), (Control)(object)Label1);
					num = ((int)num2 * -1151025262) ^ 0x46E09622;
					continue;
				case 109u:
					num = (int)(num2 * 1987667347) ^ -1176381050;
					continue;
				case 108u:
					BloodAvailability.smethod_19((Control)(object)ValueLbl, 14);
					BloodAvailability.smethod_20(ValueLbl, "litres");
					num = (int)((num2 * 1492191818) ^ 0x8315314);
					continue;
				case 107u:
					num = ((int)num2 * -601498249) ^ 0x4DBCFF7D;
					continue;
				case 106u:
					num = ((int)num2 * -86914112) ^ -1415099468;
					continue;
				case 105u:
					BloodAvailability.smethod_48((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = (int)((num2 * 1667597529) ^ 0x1CA39586);
					continue;
				case 104u:
					num = (int)(num2 * 1605618402) ^ -2079133766;
					continue;
				case 103u:
					num = (int)(num2 * 1554891939) ^ -1968008076;
					continue;
				case 102u:
					BloodAvailability.smethod_17((Control)(object)PictureBox1, "PictureBox1");
					num = (int)(num2 * 1501944883) ^ -1191125877;
					continue;
				case 101u:
					ValueLbl = BloodAvailability.smethod_4();
					num = ((int)num2 * -6699786) ^ -2106233014;
					continue;
				case 100u:
					AmountLbl = BloodAvailability.smethod_4();
					num = (int)((num2 * 213198982) ^ 0x62CF127F);
					continue;
				case 99u:
					BloodAvailability.smethod_16((Control)(object)SearchBtn, new Point(183, 91));
					num = (int)(num2 * 503582923) ^ -133733702;
					continue;
				case 98u:
					SearchResultGrid = BloodAvailability.smethod_8();
					num = ((int)num2 * -2127531392) ^ 0x40868FBE;
					continue;
				case 97u:
					num = (int)(num2 * 1678644558) ^ -1550690536;
					continue;
				case 96u:
					SuccessMsg = BloodAvailability.smethod_4();
					num = (int)(num2 * 498012986) ^ -753543214;
					continue;
				case 95u:
					BloodAvailability.smethod_21(Label2, (ContentAlignment)32);
					num = ((int)num2 * -1203406619) ^ 0x5A77EEE0;
					continue;
				case 94u:
					BloodAvailability.smethod_18((Control)(object)BloodGrpTxt, new Size(108, 26));
					num = ((int)num2 * -611492081) ^ -1532131127;
					continue;
				case 93u:
					BloodAvailability.smethod_47(PictureBox1, bool_0: false);
					num = (int)(num2 * 1344084849) ^ -1527497705;
					continue;
				case 92u:
					num = ((int)num2 * -3850746) ^ 0x50D6021;
					continue;
				case 91u:
					num = ((int)num2 * -1263898084) ^ 0x1F022C6A;
					continue;
				case 90u:
					BloodAvailability.smethod_31((ListControl)(object)BloodGrpTxt, bool_0: true);
					num = (int)(num2 * 1105252802) ^ -854510168;
					continue;
				case 89u:
					BloodAvailability.smethod_17((Control)(object)SuccessMsg, "SuccessMsg");
					num = ((int)num2 * -1512966192) ^ 0x4FC9EB70;
					continue;
				case 88u:
					num = ((int)num2 * -1694479747) ^ 0x308A19F9;
					continue;
				case 87u:
					BloodAvailability.smethod_29((ButtonBase)(object)UpdateBtn, bool_0: false);
					BloodAvailability.smethod_41((Control)(object)UpdateBtn, bool_0: false);
					num = ((int)num2 * -1548511708) ^ 0x7FA5CDCB;
					continue;
				case 86u:
					num = (int)((num2 * 851357401) ^ 0x3195E1F0);
					continue;
				case 85u:
					num = (int)(num2 * 8855708) ^ -700487929;
					continue;
				case 84u:
					BloodAvailability.smethod_19((Control)(object)AmountLbl, 13);
					num = (int)((num2 * 1145349977) ^ 0x3B90756);
					continue;
				case 83u:
					BloodAvailability.smethod_20(SuccessMsg, "Label5");
					num = (int)((num2 * 1745011725) ^ 0x47DF8C8F);
					continue;
				case 82u:
					BloodAvailability.smethod_19((Control)(object)SearchResultGrid, 24);
					num = (int)(num2 * 1956633597) ^ -513152822;
					continue;
				case 81u:
					num = ((int)num2 * -1123964229) ^ 0x3D7ABFD6;
					continue;
				case 80u:
					BloodAvailability.smethod_21(AmountLbl, (ContentAlignment)32);
					num = (int)((num2 * 1401363343) ^ 0x6FA922A6);
					continue;
				case 79u:
					num = ((int)num2 * -1126257209) ^ 0x612CF747;
					continue;
				case 78u:
					BloodAvailability.smethod_16((Control)(object)BloodGrpTxt, new Point(246, 40));
					BloodAvailability.smethod_17((Control)(object)BloodGrpTxt, "BloodGrpTxt");
					num = ((int)num2 * -904242871) ^ -1187524165;
					continue;
				case 77u:
					Timer1 = BloodAvailability.smethod_9(components);
					UpdateBtn = BloodAvailability.smethod_6();
					num = (int)(num2 * 1833050394) ^ -550887915;
					continue;
				case 76u:
					BloodAvailability.smethod_16((Control)(object)DonorListBtn, new Point(323, 434));
					num = ((int)num2 * -1929125277) ^ 0x253E3549;
					continue;
				case 75u:
					num = ((int)num2 * -1426387042) ^ -118987633;
					continue;
				case 74u:
					num = (int)(num2 * 417752898) ^ -526773139;
					continue;
				case 73u:
					num = ((int)num2 * -1637885770) ^ 0x1D83DCA0;
					continue;
				case 72u:
					BloodAvailability.smethod_18((Control)(object)SearchResultGrid, new Size(739, 296));
					num = ((int)num2 * -5932836) ^ 0x6F735ADC;
					continue;
				case 71u:
					num = (int)(num2 * 1968066244) ^ -2132615907;
					continue;
				case 70u:
					num = (int)(num2 * 417889394) ^ -695268444;
					continue;
				case 69u:
					num = ((int)num2 * -795808523) ^ -1513897080;
					continue;
				case 68u:
					BloodAvailability.smethod_41((Control)(object)SuccessMsg, bool_0: false);
					num = (int)((num2 * 274199495) ^ 0x19F2F7A);
					continue;
				case 67u:
					BloodAvailability.smethod_37(SearchResultGrid, (DataGridViewColumnHeadersHeightSizeMode)2);
					num = (int)((num2 * 831925536) ^ 0x6907FB36);
					continue;
				case 66u:
					BloodAvailability.smethod_35((Control)(object)ValueLbl, Color.FromArgb(0, 192, 0));
					BloodAvailability.smethod_15((Control)(object)ValueLbl, BloodAvailability.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1940862731) ^ 0x7E113376;
					continue;
				case 64u:
					BloodAvailability.smethod_18((Control)(object)DonorListBtn, new Size(221, 36));
					num = ((int)num2 * -810743626) ^ 0x27D1E3DD;
					continue;
				case 63u:
					num = (int)((num2 * 301253068) ^ 0x5219ACF);
					continue;
				case 62u:
					BloodAvailability.smethod_17((Control)(object)Label2, "Label2");
					num = ((int)num2 * -1824492604) ^ 0x2695E3C8;
					continue;
				case 61u:
					BloodAvailability.smethod_18((Control)(object)Label2, new Size(135, 32));
					num = ((int)num2 * -596139106) ^ 0x6C336CA7;
					continue;
				case 60u:
					BloodAvailability.smethod_20(AmountLbl, "Amount :");
					num = ((int)num2 * -288622624) ^ -2040779691;
					continue;
				case 59u:
					num = ((int)num2 * -1209388411) ^ 0x542E2EC1;
					continue;
				case 58u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_50((Control)(object)this), (Control)(object)AmountLbl);
					num = ((int)num2 * -1609459782) ^ -1612506938;
					continue;
				case 57u:
					BloodAvailability.smethod_15((Control)(object)AmountLbl, BloodAvailability.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -973289243) ^ 0x7D587BF1;
					continue;
				case 56u:
					num = ((int)num2 * -813653926) ^ 0x46C4C43;
					continue;
				case 55u:
					BloodAvailability.smethod_16((Control)(object)PictureBox1, new Point(272, 25));
					num = ((int)num2 * -355080544) ^ 0x38D41F08;
					continue;
				case 54u:
					num = ((int)num2 * -278855008) ^ 0x54F6A9EB;
					continue;
				case 53u:
					BloodAvailability.smethod_18((Control)(object)UpdateBtn, new Size(180, 52));
					num = (int)(num2 * 1155681750) ^ -1660814259;
					continue;
				case 52u:
					BloodAvailability.smethod_19((Control)(object)SuccessMsg, 28);
					num = ((int)num2 * -978730412) ^ 0x3CE28525;
					continue;
				case 51u:
					BloodAvailability.smethod_16((Control)(object)GroupBox1, new Point(232, 214));
					num = ((int)num2 * -120922639) ^ 0x248C7B8B;
					continue;
				case 50u:
					BloodAvailability.smethod_30(BloodGrpTxt, (ComboBoxStyle)2);
					num = (int)((num2 * 1876425258) ^ 0x5C4E76E2);
					continue;
				case 49u:
					BloodAvailability.smethod_15((Control)(object)SuccessMsg, BloodAvailability.smethod_42("MS Reference Sans Serif", 10.8f, (FontStyle)1));
					num = ((int)num2 * -730349439) ^ 0x79268BC1;
					continue;
				case 48u:
					BloodAvailability.smethod_36(SearchResultGrid, Color.White);
					num = (int)(num2 * 1345056725) ^ -996379595;
					continue;
				case 47u:
					num = ((int)num2 * -1361707789) ^ 0x2937B4BE;
					continue;
				case 46u:
					num = ((int)num2 * -471666441) ^ -2089883336;
					continue;
				case 45u:
					BloodAvailability.smethod_28((ButtonBase)(object)SearchBtn, "Search");
					num = (int)(num2 * 117939100) ^ -1541619299;
					continue;
				case 44u:
					BloodAvailability.smethod_27((Control)(object)DonorListBtn, Color.White);
					num = (int)((num2 * 1227168452) ^ 0x1531E9AB);
					continue;
				case 43u:
					BloodAvailability.smethod_19((Control)(object)BloodGrpTxt, 21);
					BloodAvailability.smethod_15((Control)(object)Label2, BloodAvailability.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1176680186) ^ -362672701;
					continue;
				case 42u:
					BloodAvailability.smethod_17((Control)(object)DonorListBtn, "DonorListBtn");
					num = ((int)num2 * -371899323) ^ 0x64032855;
					continue;
				case 41u:
					BloodAvailability.smethod_38(SearchResultGrid, bool_0: true);
					num = ((int)num2 * -1949110780) ^ 0x2983314C;
					continue;
				case 40u:
					BloodAvailability.smethod_26((ButtonBase)(object)DonorListBtn, Color.MidnightBlue);
					num = ((int)num2 * -2003626322) ^ 0x115C9770;
					continue;
				case 39u:
					BloodAvailability.smethod_19((Control)(object)UpdateBtn, 29);
					num = ((int)num2 * -956344792) ^ 0x67751C34;
					continue;
				case 38u:
					num = (int)(num2 * 435668717) ^ -16211253;
					continue;
				case 37u:
					num = ((int)num2 * -2017099300) ^ 0x41C8E24A;
					continue;
				case 36u:
					num = (int)((num2 * 1584822348) ^ 0x28D4527E);
					continue;
				case 35u:
					BloodAvailability.smethod_28((ButtonBase)(object)DonorListBtn, "See List of Donors");
					BloodAvailability.smethod_29((ButtonBase)(object)DonorListBtn, bool_0: false);
					num = (int)(num2 * 917296101) ^ -77418029;
					continue;
				case 34u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_50((Control)(object)this), (Control)(object)SearchResultGrid);
					num = (int)(num2 * 395443022) ^ -1192937630;
					continue;
				case 33u:
					BloodAvailability.smethod_21(Label1, (ContentAlignment)32);
					BloodAvailability.smethod_23(BloodAvailability.smethod_22((Control)(object)GroupBox1), (Control)(object)SearchBtn);
					num = ((int)num2 * -2106348676) ^ 0x230BFED8;
					continue;
				case 32u:
					BloodAvailability.smethod_17((Control)(object)Label1, "Label1");
					num = (int)((num2 * 403207307) ^ 0x3B3AB999);
					continue;
				case 31u:
					BloodAvailability.smethod_15((Control)(object)BloodGrpTxt, BloodAvailability.smethod_14("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1806389807) ^ 0x793D4E24;
					continue;
				case 30u:
					BloodAvailability.smethod_19((Control)(object)SearchBtn, 22);
					num = ((int)num2 * -1928007648) ^ -1245980966;
					continue;
				case 29u:
					num = ((int)num2 * -179739977) ^ 0x23762497;
					continue;
				case 28u:
					Label2 = BloodAvailability.smethod_4();
					num = ((int)num2 * -1183373253) ^ 0x8F98176;
					continue;
				case 27u:
					num = (int)(num2 * 783271376) ^ -641640984;
					continue;
				case 26u:
					num = ((int)num2 * -1051339397) ^ 0x45F77457;
					continue;
				case 25u:
					num = (int)(num2 * 735597765) ^ -159693107;
					continue;
				case 24u:
					BloodAvailability.smethod_17((Control)(object)GroupBox1, "GroupBox1");
					num = ((int)num2 * -244953356) ^ -423724104;
					continue;
				case 23u:
					num = ((int)num2 * -422301559) ^ 0x7AEAB0F9;
					continue;
				case 22u:
					num = (int)((num2 * 349951939) ^ 0x69793E91);
					continue;
				case 21u:
					BloodAvailability.smethod_16((Control)(object)SuccessMsg, new Point(281, 141));
					num = (int)(num2 * 505901792) ^ -357593050;
					continue;
				case 20u:
					BloodAvailability.smethod_15((Control)(object)DonorListBtn, BloodAvailability.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 45156254) ^ -1292409628;
					continue;
				case 19u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_50((Control)(object)this), (Control)(object)PictureBox1);
					num = (int)((num2 * 816050046) ^ 0x5A3F1AC);
					continue;
				case 18u:
					num = ((int)num2 * -815935124) ^ 0x1CCFFDB4;
					continue;
				case 17u:
					BloodAvailability.smethod_18((Control)(object)GroupBox1, new Size(490, 137));
					BloodAvailability.smethod_19((Control)(object)GroupBox1, 12);
					num = ((int)num2 * -166100982) ^ -8894441;
					continue;
				case 16u:
					num = (int)(num2 * 1477892781) ^ -1953112957;
					continue;
				case 15u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_22((Control)(object)GroupBox1), (Control)(object)Label2);
					num = (int)((num2 * 1038901277) ^ 0x43BE9D31);
					continue;
				case 14u:
					BloodAvailability.smethod_16((Control)(object)Label2, new Point(87, 36));
					num = (int)(num2 * 205528795) ^ -1396689822;
					continue;
				case 13u:
					BloodAvailability.smethod_17((Control)(object)SearchBtn, "SearchBtn");
					BloodAvailability.smethod_18((Control)(object)SearchBtn, new Size(102, 36));
					num = ((int)num2 * -1956322773) ^ -140353061;
					continue;
				case 12u:
					BloodAvailability.smethod_19((Control)(object)DonorListBtn, 23);
					num = ((int)num2 * -125267491) ^ -30039600;
					continue;
				case 11u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_50((Control)(object)this), (Control)(object)SuccessMsg);
					num = ((int)num2 * -868045133) ^ 0x2DCC7965;
					continue;
				case 10u:
					BloodAvailability.smethod_40(BloodAvailability.smethod_39(SearchResultGrid), 24);
					num = ((int)num2 * -704040899) ^ 0x71FC86D1;
					continue;
				case 9u:
					BloodAvailability.smethod_27((Control)(object)UpdateBtn, Color.White);
					num = ((int)num2 * -462552022) ^ 0x30F8DB2;
					continue;
				case 8u:
					BloodAvailability.smethod_16((Control)(object)SearchResultGrid, new Point(112, 494));
					num = ((int)num2 * -1329646103) ^ -912064973;
					continue;
				case 7u:
					PictureBox1 = BloodAvailability.smethod_10();
					BloodAvailability.smethod_11((Control)(object)GroupBox1);
					BloodAvailability.smethod_12((ISupportInitialize)SearchResultGrid);
					BloodAvailability.smethod_12((ISupportInitialize)PictureBox1);
					BloodAvailability.smethod_13((Control)(object)this);
					num = (int)((num2 * 1652596044) ^ 0x73D5CEC5);
					continue;
				case 6u:
					BloodAvailability.smethod_15((Control)(object)GroupBox1, BloodAvailability.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 250606241) ^ 0x319A6D0A);
					continue;
				case 5u:
					BloodAvailability.smethod_29((ButtonBase)(object)SearchBtn, bool_0: false);
					num = (int)((num2 * 1063314409) ^ 0x73300654);
					continue;
				case 4u:
					BloodAvailability.smethod_17((Control)(object)ValueLbl, "ValueLbl");
					num = ((int)num2 * -643338284) ^ 0x639586DA;
					continue;
				case 3u:
					BloodAvailability.smethod_23(BloodAvailability.smethod_50((Control)(object)this), (Control)(object)UpdateBtn);
					num = ((int)num2 * -1696801862) ^ 0x49E5D448;
					continue;
				case 2u:
					DonorListBtn = BloodAvailability.smethod_6();
					num = ((int)num2 * -575471606) ^ -205723660;
					continue;
				case 1u:
					BloodAvailability.smethod_21(SuccessMsg, (ContentAlignment)32);
					num = ((int)num2 * -2031829563) ^ 0x2B07CC9B;
					continue;
				case 0u:
					BloodAvailability.smethod_51((Control)(object)this, "BloodAvailability");
					num = ((int)num2 * -2013597041) ^ -1366720005;
					continue;
				case 65u:
					break;
				default:
					BloodAvailability.smethod_54((ISupportInitialize)PictureBox1);
					BloodAvailability.smethod_55((Control)(object)this, bool_0: false);
					BloodAvailability.smethod_56((Control)(object)this);
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
			int num = -1590278690;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBF6B4059u) % 9u)
				{
				case 8u:
					BloodAvailability.smethod_60(myconnection, BloodAvailability.smethod_59(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
					BloodAvailability.smethod_61(BloodGrpTxt, 0);
					num = (int)((num2 * 1142321497) ^ 0x6659210C);
					continue;
				case 7u:
					num = (int)((num2 * 1653742861) ^ 0x64801AB8);
					continue;
				case 5u:
					BloodAvailability.smethod_20(AmountLbl, "Amount :");
					num = (int)(num2 * 1443143804) ^ -859548111;
					continue;
				case 4u:
					num = (int)((num2 * 341827085) ^ 0x5C2AD26F);
					continue;
				case 3u:
					BloodAvailability.smethod_41((Control)(object)AmountLbl, bool_0: false);
					num = ((int)num2 * -1757957663) ^ -1656230201;
					continue;
				case 1u:
					BloodAvailability.smethod_41((Control)(object)ValueLbl, bool_0: false);
					num = ((int)num2 * -1215504611) ^ 0x62D6AB9B;
					continue;
				case 0u:
					BloodAvailability.smethod_41((Control)(object)DonorListBtn, bool_0: false);
					num = (int)(num2 * 2093577249) ^ -1207313353;
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

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Expected I4, but got Unknown
		//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected I4, but got Unknown
		//IL_05eb: Incompatible stack heights: 0 vs 1
		//IL_05fb: Incompatible stack heights: 0 vs 1
		//IL_0616: Incompatible stack heights: 0 vs 1
		//IL_061d: Incompatible stack heights: 0 vs 1
		BloodAvailability.smethod_41((Control)(object)SearchResultGrid, bool_0: false);
		string string_ = default(string);
		OleDbDataReader oleDbDataReader_ = default(OleDbDataReader);
		decimal num4 = default(decimal);
		bool flag = default(bool);
		while (true)
		{
			int num = 1481572648;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7C92F1A3u) % 19u)
				{
				case 18u:
					BloodAvailability.smethod_41((Control)(object)UpdateBtn, bool_0: false);
					num = (int)((num2 * 1507477065) ^ 0xEF0E4C4);
					continue;
				case 17u:
				{
					OleDbCommand oleDbCommand_ = BloodAvailability.smethod_64();
					num = ((int)num2 * -71778642) ^ -1145600365;
					continue;
				}
				case 16u:
					BloodAvailability.smethod_41((Control)(object)ValueLbl, bool_0: false);
					num = ((int)num2 * -154497236) ^ 0x163512BF;
					continue;
				case 15u:
					BloodAvailability.smethod_41((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -1742349069) ^ 0x176A4A91;
					continue;
				case 14u:
				{
					int num10;
					int num11;
					if (BloodAvailability.smethod_62(BloodGrpTxt) == 0)
					{
						num10 = 230242523;
						num11 = 230242523;
					}
					else
					{
						num10 = 1432173373;
						num11 = 1432173373;
					}
					num = num10 ^ (int)(num2 * 128896404);
					continue;
				}
				case 13u:
					num = 1529984039;
					continue;
				case 11u:
					BloodAvailability.smethod_20(SuccessMsg, "Select Blood Group");
					num = ((int)num2 * -320121331) ^ 0x24CC88BD;
					continue;
				case 10u:
					num = ((int)num2 * -898936957) ^ -566654509;
					continue;
				case 9u:
					num = ((int)num2 * -248028507) ^ 0x4D8253B8;
					continue;
				case 8u:
					BloodAvailability.smethod_41((Control)(object)AmountLbl, bool_0: false);
					num = ((int)num2 * -1397765898) ^ -75808385;
					continue;
				case 7u:
					string_ = BloodAvailability.smethod_66("Select * From [Blood_available] Where [Blood Group] Like '%", BloodAvailability.smethod_65(BloodGrpTxt), "%';");
					num = (int)((num2 * 1351350364) ^ 0x1EAD8723);
					continue;
				case 6u:
					num = (int)((num2 * 915716505) ^ 0x7178A7E8);
					continue;
				case 4u:
					BloodAvailability.smethod_41((Control)(object)DonorListBtn, bool_0: false);
					num = ((int)num2 * -154650612) ^ 0x56BB1227;
					continue;
				case 3u:
					num = ((int)num2 * -734492921) ^ -1961910100;
					continue;
				case 2u:
					BloodAvailability.smethod_35((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -1418042746) ^ 0x4C03F018;
					continue;
				case 1u:
					BloodAvailability.smethod_63(Timer1);
					num = ((int)num2 * -996859191) ^ -2109301384;
					continue;
				case 0u:
					break;
				default:
					BloodAvailability.smethod_67();
					BloodAvailability.smethod_68(myconnection);
					try
					{
						while (true)
						{
							int num3 = 1533633906;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x7C92F1A3u) % 25u)
								{
								case 24u:
									BloodAvailability.smethod_41((Control)(object)ValueLbl, bool_0: true);
									num3 = (int)((num2 * 611938237) ^ 0x32FBADD9);
									continue;
								case 23u:
									BloodAvailability.smethod_41((Control)(object)DonorListBtn, bool_0: true);
									num3 = ((int)num2 * -1341801857) ^ 0x2E03D064;
									continue;
								case 22u:
								{
									int num7;
									if (BloodAvailability.smethod_75(oleDbDataReader_))
									{
										num3 = 228022638;
										num7 = 228022638;
									}
									else
									{
										num3 = 2071929741;
										num7 = 2071929741;
									}
									continue;
								}
								case 21u:
								{
									int num8;
									int num9;
									if (BloodAvailability.smethod_81(BloodAvailability.smethod_80(MyProject.Forms.Form1.login_type), "admin", bool_0: false) == 0)
									{
										num8 = 1221772259;
										num9 = 1221772259;
									}
									else
									{
										num8 = 1084631405;
										num9 = 1084631405;
									}
									num3 = num8 ^ ((int)num2 * -218014360);
									continue;
								}
								case 20u:
									BloodAvailability.smethod_35((Control)(object)ValueLbl, Color.Red);
									num3 = (int)((num2 * 2093447980) ^ 0x4CE827B5);
									continue;
								case 18u:
									BloodAvailability.smethod_35((Control)(object)ValueLbl, Color.Green);
									num3 = 1948059520;
									continue;
								case 17u:
									num4 = BloodAvailability.smethod_79(BloodAvailability.smethod_78(BloodAvailability.smethod_77(ValueLbl), new char[1] { ' ' })[0]);
									MyProject.Forms.Form1.cur_blood_amount = num4;
									num3 = (int)(num2 * 1320963804) ^ -1242067923;
									continue;
								case 16u:
									num3 = (int)((num2 * 202917667) ^ 0x1CCB576A);
									continue;
								case 15u:
									num3 = ((int)num2 * -1188407539) ^ 0x7FB1184A;
									continue;
								case 14u:
									num3 = ((int)num2 * -1897436591) ^ -539819974;
									continue;
								case 13u:
									num3 = ((int)num2 * -1821205117) ^ -1965564428;
									continue;
								case 12u:
									num3 = (int)((num2 * 399063685) ^ 0x65AEF3A7);
									continue;
								case 11u:
									BloodAvailability.smethod_41((Control)(object)UpdateBtn, bool_0: true);
									num3 = (int)((num2 * 2033265355) ^ 0x72446C10);
									continue;
								case 10u:
									BloodAvailability.smethod_41((Control)(object)AmountLbl, bool_0: true);
									num3 = 1481949405;
									continue;
								case 9u:
									num3 = ((int)num2 * -1017277637) ^ -445278247;
									continue;
								case 8u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = 1690664775;
										num6 = 1690664775;
									}
									else
									{
										num5 = 1708758108;
										num6 = 1708758108;
									}
									num3 = num5 ^ ((int)num2 * -1851419659);
									continue;
								}
								case 7u:
								{
									OleDbCommand oleDbCommand_ = BloodAvailability.smethod_69(string_, myconnection);
									oleDbDataReader_ = BloodAvailability.smethod_70(oleDbCommand_);
									num3 = ((int)num2 * -696006241) ^ 0xC74212F;
									continue;
								}
								case 6u:
									BloodAvailability.smethod_20(ValueLbl, BloodAvailability.smethod_74(BloodAvailability.smethod_73(BloodAvailability.smethod_71(oleDbDataReader_, 2), (object)" litres")));
									num3 = ((int)num2 * -2124230510) ^ -603432740;
									continue;
								case 4u:
									num3 = ((int)num2 * -577791835) ^ -41420284;
									continue;
								case 3u:
									num3 = 2132744019;
									continue;
								case 2u:
									flag = decimal.Compare(num4, 0m) == 0;
									num3 = ((int)num2 * -1796061074) ^ -1622633348;
									continue;
								case 1u:
									MyProject.Forms.Form1.blood_available_id = BloodAvailability.smethod_72(BloodAvailability.smethod_71(oleDbDataReader_, 0));
									num3 = 192957358;
									continue;
								case 0u:
									BloodAvailability.smethod_76(myconnection);
									num3 = ((int)num2 * -533442) ^ -1445531791;
									continue;
								case 5u:
									break;
								default:
									blood_group = BloodAvailability.smethod_65(BloodGrpTxt);
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
							_ = 694518398;
							while (true)
							{
								_003F val = /*Error near IL_05b8: Stack underflow*/^ 0x7C92F1A3;
								num2 = (uint)(int)val;
								switch (val % 5)
								{
								default:
									return;
								case 4:
									BloodAvailability.smethod_83();
									_ = ((int)num2 * -552843102) ^ -1676011790;
									continue;
								case 3:
									_ = ((int)num2 * -503122593) ^ -420737444;
									continue;
								case 0:
									BloodAvailability.smethod_76(myconnection);
									_ = (num2 * 1988036491) ^ 0xBAF17EB;
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
				case 12u:
					return;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected I4, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected I4, but got Unknown
		//IL_0343: Incompatible stack heights: 0 vs 1
		//IL_035e: Incompatible stack heights: 0 vs 1
		//IL_0365: Incompatible stack heights: 0 vs 1
		bool flag = BloodAvailability.smethod_62(BloodGrpTxt) == 0;
		string string_ = default(string);
		while (true)
		{
			int num = -1810529140;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xABEB2E55u) % 12u)
				{
				case 11u:
					BloodAvailability.smethod_41((Control)(object)SuccessMsg, bool_0: true);
					num = (int)((num2 * 635375630) ^ 0x4F695968);
					continue;
				case 10u:
					string_ = BloodAvailability.smethod_66("Select * From [Donor] Where [Blood] Like '%", blood_group, "%';");
					num = (int)(num2 * 205723923) ^ -2119572001;
					continue;
				case 9u:
					BloodAvailability.smethod_63(Timer1);
					num = (int)((num2 * 1236364475) ^ 0x458803FE);
					continue;
				case 7u:
					BloodAvailability.smethod_20(SuccessMsg, "Select Blood Group");
					num = ((int)num2 * -1333964950) ^ 0x2D5A01B2;
					continue;
				case 5u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = 671561899;
						num8 = 671561899;
					}
					else
					{
						num7 = 1973144375;
						num8 = 1973144375;
					}
					num = num7 ^ (int)(num2 * 1012155645);
					continue;
				}
				case 3u:
					BloodAvailability.smethod_64();
					num = -986752861;
					continue;
				case 2u:
					num = (int)(num2 * 226746805) ^ -378749386;
					continue;
				case 1u:
					BloodAvailability.smethod_35((Control)(object)SuccessMsg, Color.Red);
					num = (int)(num2 * 1554115151) ^ -1672371964;
					continue;
				case 0u:
					num = (int)((num2 * 1038064080) ^ 0x1F6FB77B);
					continue;
				case 8u:
					break;
				default:
				{
					DataTable dataTable = BloodAvailability.smethod_67();
					BloodAvailability.smethod_68(myconnection);
					try
					{
						OleDbDataAdapter dbDataAdapter_ = BloodAvailability.smethod_84(string_, myconnection);
						while (true)
						{
							IL_02f9:
							int num3 = -58010350;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xABEB2E55u) % 15u)
								{
								case 14u:
									num3 = (int)((num2 * 841754497) ^ 0x19F558E8);
									continue;
								case 13u:
									BloodAvailability.smethod_76(myconnection);
									num3 = ((int)num2 * -1321536990) ^ 0x7603558C;
									continue;
								case 12u:
									BloodAvailability.smethod_86(SearchResultGrid, (object)dataTable);
									num3 = ((int)num2 * -95915725) ^ -1693756376;
									continue;
								case 11u:
									BloodAvailability.smethod_85((DbDataAdapter)(object)dbDataAdapter_, dataTable);
									num3 = (int)((num2 * 132572311) ^ 0x16F6E032);
									continue;
								case 10u:
									BloodAvailability.smethod_76(myconnection);
									num3 = ((int)num2 * -1517597882) ^ 0x1E29787F;
									continue;
								case 9u:
									HideUnusedColumns();
									num3 = ((int)num2 * -407465656) ^ 0x538C5757;
									continue;
								case 8u:
									num3 = (int)((num2 * 1797716120) ^ 0x36BA6789);
									continue;
								case 5u:
									BloodAvailability.smethod_41((Control)(object)SearchResultGrid, bool_0: true);
									num3 = (int)(num2 * 1974237693) ^ -192551029;
									continue;
								case 4u:
									BloodAvailability.smethod_88("No Result Found");
									num3 = ((int)num2 * -275187275) ^ 0x2D3DA03D;
									continue;
								case 3u:
									num3 = -1593177247;
									continue;
								case 2u:
									num3 = (int)((num2 * 1816718743) ^ 0x9DC7EE1);
									continue;
								case 1u:
								{
									int num4;
									int num5;
									if (BloodAvailability.smethod_87(SearchResultGrid) == 1)
									{
										num4 = -1601490611;
										num5 = -1601490611;
									}
									else
									{
										num4 = -335861230;
										num5 = -335861230;
									}
									num3 = num4 ^ ((int)num2 * -1686709862);
									continue;
								}
								default:
									goto end_IL_02aa;
								case 6u:
									break;
								case 0u:
									goto end_IL_02aa;
								case 7u:
									return;
								}
								goto IL_02f9;
								continue;
								end_IL_02aa:
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
							IL_0360:
							_ = -1112486340;
							while (true)
							{
								_003F val = /*Error near IL_0319: Stack underflow*/^ -1410650539;
								num2 = (uint)(int)val;
								switch (val % 4)
								{
								case 2:
									_ = ((int)num2 * -2014999024) ^ 0x6AAD7AF9;
									continue;
								case 1:
									BloodAvailability.smethod_76(myconnection);
									_ = (num2 * 1437669936) ^ 0x75F7C5D7;
									continue;
								case 3:
									break;
								default:
									BloodAvailability.smethod_83();
									goto end_IL_0313;
								}
								goto IL_0360;
								continue;
								end_IL_0313:
								break;
							}
							break;
						}
					}
					while (true)
					{
						int num6 = -542165124;
						while (true)
						{
							switch ((num2 = (uint)num6 ^ 0xABEB2E55u) % 3u)
							{
							case 1u:
								goto IL_036e;
							default:
								return;
							case 0u:
								break;
							case 2u:
								return;
							}
							break;
							IL_036e:
							num6 = (int)(num2 * 1096998438) ^ -1842516675;
						}
					}
				}
				case 6u:
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
			int num = 2072828812;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1F15C441u) % 9u)
				{
				case 8u:
				{
					int num4;
					int num5;
					if (num3 <= 8)
					{
						num4 = 2034323919;
						num5 = 2034323919;
					}
					else
					{
						num4 = 353325492;
						num5 = 353325492;
					}
					num = num4 ^ (int)(num2 * 77826636);
					continue;
				}
				case 6u:
					num3 = 3;
					num = (int)((num2 * 2061321952) ^ 0x2AE49FC3);
					continue;
				case 5u:
					num3 = checked(num3 + 1);
					num = (int)(num2 * 1693250699) ^ -1535097971;
					continue;
				case 4u:
					BloodAvailability.smethod_91(BloodAvailability.smethod_90(BloodAvailability.smethod_89(SearchResultGrid), num3), bool_0: false);
					num = 727804382;
					continue;
				case 3u:
					BloodAvailability.smethod_91(BloodAvailability.smethod_90(BloodAvailability.smethod_89(SearchResultGrid), 5), bool_0: true);
					num = (int)((num2 * 1167672239) ^ 0x1A9DAEE3);
					continue;
				case 2u:
					num = ((int)num2 * -897626854) ^ -1429867544;
					continue;
				case 1u:
					result = true;
					num = (int)((num2 * 1890501747) ^ 0x152F5AF5);
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

	private void UpdateBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -340027577;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x83A42761u) % 9u)
				{
				case 8u:
					BloodAvailability.smethod_41((Control)(object)DonorListBtn, bool_0: false);
					num = (int)((num2 * 1245251117) ^ 0x4414DCA);
					continue;
				case 7u:
					BloodAvailability.smethod_41((Control)(object)ValueLbl, bool_0: false);
					BloodAvailability.smethod_41((Control)(object)UpdateBtn, bool_0: false);
					num = ((int)num2 * -26927963) ^ 0x6E9E598C;
					continue;
				case 6u:
					BloodAvailability.smethod_41((Control)(object)AmountLbl, bool_0: false);
					num = ((int)num2 * -264861714) ^ 0x421F6A69;
					continue;
				case 5u:
					BloodAvailability.smethod_41((Control)(object)SearchResultGrid, bool_0: false);
					num = ((int)num2 * -2099864780) ^ -983688696;
					continue;
				case 3u:
					num = ((int)num2 * -753467123) ^ -615662065;
					continue;
				case 1u:
					BloodAvailability.smethod_92((Control)(object)MyProject.Forms.Form4);
					num = (int)(num2 * 488132159) ^ -463574300;
					continue;
				case 0u:
					num = (int)((num2 * 888462231) ^ 0x3FC296AE);
					continue;
				default:
					return;
				case 2u:
					break;
				case 4u:
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
