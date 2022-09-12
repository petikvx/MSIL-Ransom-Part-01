using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hospital_Management_System.My;
using Hospital_Management_System.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hospital_Management_System;

[DesignerGenerated]
public class Registration : UserControl
{
	private IContainer components;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("NameTxt")]
	internal virtual TextBox NameTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button RegisterBtn
	{
		[CompilerGenerated]
		get
		{
			return _RegisterBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = RegisterBtn_Click;
			Button registerBtn = default(Button);
			while (true)
			{
				int num = 1902597839;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3740A352u) % 9u)
					{
					case 7u:
						Registration.smethod_61((Control)(object)registerBtn, eventHandler_);
						num = (int)((num2 * 1199175688) ^ 0x3B4CA83D);
						continue;
					case 5u:
					{
						int num5;
						int num6;
						if (registerBtn == null)
						{
							num5 = 936406173;
							num6 = 936406173;
						}
						else
						{
							num5 = 1197691575;
							num6 = 1197691575;
						}
						num = num5 ^ (int)(num2 * 1855898340);
						continue;
					}
					case 4u:
						registerBtn = _RegisterBtn;
						num = (int)((num2 * 3266172) ^ 0x2C0E0B5C);
						continue;
					case 3u:
						_RegisterBtn = value;
						num = 387332338;
						continue;
					case 2u:
						Registration.smethod_62((Control)(object)registerBtn, eventHandler_);
						num = (int)((num2 * 441196785) ^ 0x16E12300);
						continue;
					case 1u:
						registerBtn = _RegisterBtn;
						num = ((int)num2 * -2147024651) ^ 0x2D19C4E5;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (registerBtn != null)
						{
							num3 = 423814998;
							num4 = 423814998;
						}
						else
						{
							num3 = 1402495924;
							num4 = 1402495924;
						}
						num = num3 ^ ((int)num2 * -1282255399);
						continue;
					}
					default:
						return;
					case 8u:
						break;
					case 6u:
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
				int num = 453800675;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x19CF636Cu) % 9u)
					{
					case 8u:
					{
						int num5;
						int num6;
						if (clearBtn != null)
						{
							num5 = -743545419;
							num6 = -743545419;
						}
						else
						{
							num5 = -1452766744;
							num6 = -1452766744;
						}
						num = num5 ^ ((int)num2 * -1052245460);
						continue;
					}
					case 7u:
					{
						int num3;
						int num4;
						if (clearBtn == null)
						{
							num3 = 2072228361;
							num4 = 2072228361;
						}
						else
						{
							num3 = 504733342;
							num4 = 504733342;
						}
						num = num3 ^ (int)(num2 * 1293206309);
						continue;
					}
					case 6u:
						clearBtn = _ClearBtn;
						num = ((int)num2 * -1241369353) ^ -1905739759;
						continue;
					case 4u:
						Registration.smethod_61((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -1439304214) ^ -1552255400;
						continue;
					case 3u:
						clearBtn = _ClearBtn;
						num = (int)(num2 * 1136970686) ^ -1905215263;
						continue;
					case 1u:
						_ClearBtn = value;
						num = 2003505957;
						continue;
					case 0u:
						Registration.smethod_62((Control)(object)clearBtn, eventHandler_);
						num = (int)(num2 * 1836895341) ^ -694118947;
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
	}

	[field: AccessedThroughProperty("AddressTxt")]
	internal virtual TextBox AddressTxt
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

	internal virtual ComboBox GenderTxt
	{
		[CompilerGenerated]
		get
		{
			return _GenderTxt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = GenderTxt_SelectionChangeCommitted;
			ComboBox genderTxt = _GenderTxt;
			while (true)
			{
				int num = -1077329059;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDCD2D037u) % 6u)
					{
					case 5u:
						Registration.smethod_64(genderTxt, eventHandler_);
						num = ((int)num2 * -508244313) ^ 0x571DDA39;
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (genderTxt != null)
						{
							num4 = 1928142481;
							num5 = 1928142481;
						}
						else
						{
							num4 = 2069973643;
							num5 = 2069973643;
						}
						num = num4 ^ (int)(num2 * 1338437733);
						continue;
					}
					case 2u:
						Registration.smethod_63(genderTxt, eventHandler_);
						num = (int)(num2 * 1381938137) ^ -375646707;
						continue;
					case 0u:
					{
						_GenderTxt = value;
						genderTxt = _GenderTxt;
						int num3;
						if (genderTxt == null)
						{
							num = -63371642;
							num3 = -63371642;
						}
						else
						{
							num = -734245858;
							num3 = -734245858;
						}
						continue;
					}
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

	[field: AccessedThroughProperty("SuccessMsg")]
	internal virtual Label SuccessMsg
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = Timer1_Tick;
			Timer timer = default(Timer);
			while (true)
			{
				int num = 281034938;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x66306E48u) % 7u)
					{
					case 6u:
						Registration.smethod_66(timer, eventHandler_);
						num = (int)((num2 * 1696176578) ^ 0x8F8B570);
						continue;
					case 5u:
						_Timer1 = value;
						timer = _Timer1;
						num = 1744648519;
						continue;
					case 4u:
					{
						int num5;
						int num6;
						if (timer == null)
						{
							num5 = -748448138;
							num6 = -748448138;
						}
						else
						{
							num5 = -1859952810;
							num6 = -1859952810;
						}
						num = num5 ^ ((int)num2 * -1957099126);
						continue;
					}
					case 2u:
					{
						timer = _Timer1;
						int num3;
						int num4;
						if (timer == null)
						{
							num3 = 1886789782;
							num4 = 1886789782;
						}
						else
						{
							num3 = 1349717150;
							num4 = 1349717150;
						}
						num = num3 ^ (int)(num2 * 1390430514);
						continue;
					}
					case 1u:
						Registration.smethod_65(timer, eventHandler_);
						num = (int)((num2 * 1787950145) ^ 0x37D651C0);
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

	[field: AccessedThroughProperty("DOBTxt")]
	internal virtual DateTimePicker DOBTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Registration()
	{
		Registration.smethod_0((UserControl)(object)this, (EventHandler)Registration_Load);
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
				int num = -1482405194;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xF5E42AAFu) % 8u)
					{
					case 6u:
						Registration.smethod_1((IDisposable)components);
						num = ((int)num2 * -822747948) ^ 0x5F10CCBF;
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -1020097687;
							num5 = -1020097687;
						}
						else
						{
							num4 = -904457003;
							num5 = -904457003;
						}
						num = num4 ^ ((int)num2 * -766246176);
						continue;
					}
					case 3u:
						num3 = ((components != null) ? 1 : 0);
						goto IL_004e;
					case 2u:
						num = -1976036062;
						continue;
					case 1u:
						if (disposing)
						{
							num = (int)(num2 * 1739471118) ^ -1743139710;
							continue;
						}
						num3 = 0;
						goto IL_004e;
					case 0u:
						num = ((int)num2 * -1950604415) ^ -124222275;
						continue;
					default:
						return;
					case 7u:
						break;
					case 5u:
						return;
						IL_004e:
						flag = (byte)num3 != 0;
						num = -2019184725;
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
			int num = -80021712;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD312A1A2u) % 200u)
				{
				case 199u:
					MobileTxt = Registration.smethod_6();
					GenderTxt = Registration.smethod_7();
					num = (int)(num2 * 590138949) ^ -794593839;
					continue;
				case 198u:
					Registration.smethod_29(DOBTxt, new DateTime(1900, 1, 1, 0, 0, 0, 0));
					num = (int)(num2 * 2137451163) ^ -1811348707;
					continue;
				case 197u:
					Registration.smethod_21(Label1, (ContentAlignment)32);
					num = ((int)num2 * -396942259) ^ -2093370477;
					continue;
				case 196u:
					num = (int)((num2 * 1025242017) ^ 0x2ABF41AC);
					continue;
				case 195u:
					Registration.smethod_18((Control)(object)SuccessMsg, new Size(401, 44));
					num = (int)(num2 * 787067965) ^ -1040400625;
					continue;
				case 194u:
					Registration.smethod_17((Control)(object)Label2, "Label2");
					num = ((int)num2 * -1764871899) ^ 0x4EF6A5C9;
					continue;
				case 193u:
					Registration.smethod_19((Control)(object)Label2, 5);
					Registration.smethod_20(Label2, "Name :");
					num = ((int)num2 * -941284562) ^ 0x56B7FB1B;
					continue;
				case 192u:
					Registration.smethod_16((Control)(object)ClearBtn, new Point(261, 661));
					num = ((int)num2 * -607789574) ^ 0x17D86060;
					continue;
				case 191u:
					Registration.smethod_16((Control)(object)GenderTxt, new Point(108, 151));
					num = (int)((num2 * 977011429) ^ 0x26536E4D);
					continue;
				case 190u:
					num = (int)((num2 * 950388089) ^ 0x29B001C7);
					continue;
				case 189u:
					num = (int)(num2 * 467418061) ^ -1104958675;
					continue;
				case 188u:
					Registration.smethod_18((Control)(object)DOBTxt, new Size(178, 29));
					num = ((int)num2 * -481847353) ^ -1296138496;
					continue;
				case 187u:
					RegisterBtn = Registration.smethod_8();
					ClearBtn = Registration.smethod_8();
					num = (int)((num2 * 680141676) ^ 0x59349B21);
					continue;
				case 186u:
					num = ((int)num2 * -797515665) ^ -2056205764;
					continue;
				case 185u:
					num = (int)(num2 * 1565795712) ^ -1258226774;
					continue;
				case 184u:
					num = (int)((num2 * 182238899) ^ 0x50CE9543);
					continue;
				case 183u:
					Registration.smethod_17((Control)(object)MobileTxt, "MobileTxt");
					num = ((int)num2 * -864395696) ^ -1761327048;
					continue;
				case 182u:
					Registration.smethod_41((Control)(object)SuccessMsg, Registration.smethod_45());
					num = ((int)num2 * -495024287) ^ 0x39300867;
					continue;
				case 180u:
					num = ((int)num2 * -1675954341) ^ 0x484547D4;
					continue;
				case 179u:
					Registration.smethod_16((Control)(object)Label3, new Point(15, 151));
					num = (int)(num2 * 1448927864) ^ -1901432371;
					continue;
				case 178u:
					num = ((int)num2 * -602759269) ^ 0x17AE4B91;
					continue;
				case 177u:
					num = ((int)num2 * -688218362) ^ -607576622;
					continue;
				case 176u:
					Registration.smethod_21(Label6, (ContentAlignment)32);
					Registration.smethod_15((Control)(object)Label5, Registration.smethod_14("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1008235537) ^ -377961084;
					continue;
				case 175u:
					Registration.smethod_40((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					num = (int)((num2 * 1036089484) ^ 0x6DB83263);
					continue;
				case 174u:
					Registration.smethod_23(Registration.smethod_54((Control)(object)this), (Control)(object)ClearBtn);
					num = ((int)num2 * -1450947578) ^ 0x34914272;
					continue;
				case 173u:
					Registration.smethod_18((Control)(object)GroupBox2, new Size(486, 394));
					num = ((int)num2 * -1115963222) ^ 0x12BAABF0;
					continue;
				case 172u:
					Registration.smethod_18((Control)(object)Label3, new Size(82, 31));
					num = ((int)num2 * -360630633) ^ -1337677136;
					continue;
				case 171u:
					Registration.smethod_33(Registration.smethod_32(GenderTxt), new string[3] { "Male", "Female", "Others" });
					num = (int)((num2 * 443272295) ^ 0x1B99A0EE);
					continue;
				case 170u:
					Registration.smethod_18((Control)(object)Label2, new Size(87, 23));
					num = ((int)num2 * -1259624902) ^ 0x6B082627;
					continue;
				case 169u:
					Registration.smethod_17((Control)(object)Label5, "Label5");
					num = ((int)num2 * -1549561234) ^ -1515068549;
					continue;
				case 168u:
					num = ((int)num2 * -1430486336) ^ 0x4F57B51C;
					continue;
				case 167u:
					Registration.smethod_17((Control)(object)Label3, "Label3");
					num = (int)(num2 * 920025025) ^ -1516155111;
					continue;
				case 166u:
					Registration.smethod_19((Control)(object)DOBTxt, 14);
					num = ((int)num2 * -816168598) ^ 0x4C9DE92B;
					continue;
				case 165u:
					Registration.smethod_51(PictureBox1, bool_0: false);
					num = (int)(num2 * 963040508) ^ -1526741999;
					continue;
				case 164u:
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)Label5);
					num = ((int)num2 * -1309065302) ^ -733996884;
					continue;
				case 163u:
					Registration.smethod_20(Label5, "Mobile :");
					num = ((int)num2 * -413750582) ^ 0x6831F40F;
					continue;
				case 162u:
					Registration.smethod_31(AddressTxt, bool_0: true);
					num = ((int)num2 * -1014663369) ^ 0x204B2AE6;
					continue;
				case 161u:
					num = (int)((num2 * 539064134) ^ 0x6A2F5185);
					continue;
				case 160u:
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)Label3);
					num = ((int)num2 * -1794582064) ^ -144057932;
					continue;
				case 159u:
					Registration.smethod_20(Label3, "Gender :");
					num = ((int)num2 * -1564473680) ^ -2038544538;
					continue;
				case 158u:
					Registration.smethod_19((Control)(object)AddressTxt, 13);
					num = (int)((num2 * 609377807) ^ 0x31A877BD);
					continue;
				case 157u:
					num = ((int)num2 * -1844350207) ^ -1111293741;
					continue;
				case 156u:
					Registration.smethod_21(Label3, (ContentAlignment)32);
					num = (int)((num2 * 1445857636) ^ 0x1528F9F7);
					continue;
				case 155u:
					num = ((int)num2 * -917520336) ^ -1144877980;
					continue;
				case 154u:
					num = (int)(num2 * 866685079) ^ -1277773969;
					continue;
				case 152u:
					Registration.smethod_19((Control)(object)RegisterBtn, 4);
					num = (int)(num2 * 976584734) ^ -425877590;
					continue;
				case 151u:
					GroupBox2 = Registration.smethod_4();
					num = ((int)num2 * -1041147322) ^ -930071697;
					continue;
				case 150u:
					num = ((int)num2 * -1195084534) ^ 0x443B9749;
					continue;
				case 149u:
					Registration.smethod_17((Control)(object)DOBTxt, "DOBTxt");
					num = ((int)num2 * -1864306763) ^ -979399609;
					continue;
				case 148u:
					Registration.smethod_58((Control)(object)GroupBox2);
					num = ((int)num2 * -1165889774) ^ -1698713975;
					continue;
				case 147u:
					Registration.smethod_16((Control)(object)SuccessMsg, new Point(305, 156));
					num = ((int)num2 * -855725941) ^ 0x4388ED3C;
					continue;
				case 146u:
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)MobileTxt);
					num = ((int)num2 * -418690841) ^ 0x7DF72086;
					continue;
				case 145u:
					Registration.smethod_17((Control)(object)GroupBox2, "GroupBox2");
					num = (int)(num2 * 1182354551) ^ -1755810484;
					continue;
				case 144u:
					Registration.smethod_18((Control)(object)MobileTxt, new Size(201, 26));
					num = ((int)num2 * -1553678860) ^ 0x7F65576E;
					continue;
				case 143u:
					num = (int)(num2 * 825043245) ^ -537934748;
					continue;
				case 142u:
					Registration.smethod_15((Control)(object)Label2, Registration.smethod_14("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 929469886) ^ -392495633;
					continue;
				case 141u:
					Registration.smethod_16((Control)(object)NameTxt, new Point(108, 55));
					num = (int)((num2 * 1575062722) ^ 0x44D8966A);
					continue;
				case 140u:
					Registration.smethod_21(Label2, (ContentAlignment)32);
					num = ((int)num2 * -1037185685) ^ -587677969;
					continue;
				case 139u:
					num = (int)((num2 * 115521854) ^ 0x2B174D38);
					continue;
				case 138u:
					SuccessMsg = Registration.smethod_3();
					num = ((int)num2 * -1914620628) ^ -1057972181;
					continue;
				case 137u:
					num = ((int)num2 * -1307717177) ^ 0x710122A0;
					continue;
				case 136u:
					num = (int)(num2 * 1479443137) ^ -419077445;
					continue;
				case 135u:
					Label4 = Registration.smethod_3();
					num = ((int)num2 * -1266139955) ^ -1792680287;
					continue;
				case 134u:
					num = ((int)num2 * -719339551) ^ -1027639925;
					continue;
				case 133u:
					Registration.smethod_17((Control)(object)Label6, "Label6");
					num = (int)((num2 * 1460176643) ^ 0x3B20F79C);
					continue;
				case 132u:
					num = ((int)num2 * -1749344684) ^ 0x5AF12D31;
					continue;
				case 131u:
					Registration.smethod_15((Control)(object)RegisterBtn, Registration.smethod_14("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -2007155592) ^ -470030556;
					continue;
				case 130u:
					Registration.smethod_40((ButtonBase)(object)RegisterBtn, Color.MidnightBlue);
					num = ((int)num2 * -1636046195) ^ -1891245786;
					continue;
				case 129u:
					Registration.smethod_34(GenderTxt, (AutoCompleteMode)2);
					Registration.smethod_35(GenderTxt, (AutoCompleteSource)256);
					Registration.smethod_36(GenderTxt, (ComboBoxStyle)2);
					num = (int)((num2 * 735795817) ^ 0x24BBA478);
					continue;
				case 128u:
					Registration.smethod_15((Control)(object)NameTxt, Registration.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1857262463) ^ 0x476B5C23;
					continue;
				case 127u:
					num = ((int)num2 * -1998615107) ^ 0x362A7A1D;
					continue;
				case 126u:
					Registration.smethod_23(Registration.smethod_54((Control)(object)this), (Control)(object)GroupBox2);
					num = ((int)num2 * -1296487302) ^ -74951151;
					continue;
				case 125u:
					num = (int)((num2 * 1746186132) ^ 0x61EED99);
					continue;
				case 124u:
					Registration.smethod_18((Control)(object)PictureBox1, new Size(126, 122));
					Registration.smethod_49(PictureBox1, (PictureBoxSizeMode)1);
					num = ((int)num2 * -535064910) ^ 0x60EFDB86;
					continue;
				case 123u:
					Registration.smethod_15((Control)(object)AddressTxt, Registration.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1925649338) ^ -1741817243;
					continue;
				case 122u:
					num = ((int)num2 * -1989867626) ^ -621013056;
					continue;
				case 121u:
					Registration.smethod_47(Timer1, 1500);
					num = ((int)num2 * -1268318314) ^ -548380335;
					continue;
				case 120u:
					num = (int)(num2 * 1103612713) ^ -2073222368;
					continue;
				case 119u:
					num = ((int)num2 * -1446709170) ^ -730358470;
					continue;
				case 118u:
					Registration.smethod_39(Registration.smethod_38(GenderTxt), new object[3] { "Male", "Female", "Others" });
					num = (int)((num2 * 468829713) ^ 0x6BE226EC);
					continue;
				case 117u:
					Registration.smethod_21(SuccessMsg, (ContentAlignment)32);
					num = ((int)num2 * -1232054069) ^ 0x683C3EC2;
					continue;
				case 116u:
					Registration.smethod_16((Control)(object)PictureBox1, new Point(281, 21));
					Registration.smethod_17((Control)(object)PictureBox1, "PictureBox1");
					num = (int)(num2 * 672837044) ^ -474176208;
					continue;
				case 115u:
					num = (int)((num2 * 1367052683) ^ 0x4D275938);
					continue;
				case 114u:
					Registration.smethod_26(DOBTxt, "");
					num = (int)((num2 * 1957641711) ^ 0x650E7E1E);
					continue;
				case 113u:
					Label5 = Registration.smethod_3();
					num = ((int)num2 * -1992051200) ^ 0x77F01155;
					continue;
				case 112u:
					Registration.smethod_15((Control)(object)Label4, Registration.smethod_14("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 592775392) ^ -205776901;
					continue;
				case 111u:
					num = (int)(num2 * 1804055243) ^ -484001165;
					continue;
				case 110u:
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)Label2);
					num = (int)(num2 * 176683607) ^ -1398884055;
					continue;
				case 109u:
					num = ((int)num2 * -1900867140) ^ -287984357;
					continue;
				case 108u:
					num = (int)(num2 * 2091067445) ^ -920367521;
					continue;
				case 107u:
					Registration.smethod_23(Registration.smethod_54((Control)(object)this), (Control)(object)RegisterBtn);
					num = ((int)num2 * -1266766876) ^ 0x424035F0;
					continue;
				case 106u:
					Registration.smethod_17((Control)(object)ClearBtn, "ClearBtn");
					num = (int)(num2 * 968065484) ^ -475154535;
					continue;
				case 105u:
					num = ((int)num2 * -1650131101) ^ -58845765;
					continue;
				case 104u:
					num = (int)((num2 * 1670339255) ^ 0x20F2867D);
					continue;
				case 103u:
					Registration.smethod_18((Control)(object)Label5, new Size(94, 29));
					num = ((int)num2 * -437477251) ^ 0x6A66FF15;
					continue;
				case 102u:
					Registration.smethod_16((Control)(object)Label5, new Point(6, 203));
					num = ((int)num2 * -1236975518) ^ -68737057;
					continue;
				case 101u:
					Registration.smethod_15((Control)(object)MobileTxt, Registration.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -216649581) ^ 0x442622B0;
					continue;
				case 100u:
					num = (int)((num2 * 730712284) ^ 0x4E0909C4);
					continue;
				case 99u:
					num = (int)((num2 * 247874117) ^ 0x279D2079);
					continue;
				case 98u:
					Registration.smethod_17((Control)(object)NameTxt, "NameTxt");
					num = ((int)num2 * -2025781391) ^ 0x6B0BC8A1;
					continue;
				case 97u:
					Registration.smethod_44((Control)(object)this, Color.White);
					num = ((int)num2 * -19215518) ^ 0x5B29B6C6;
					continue;
				case 96u:
					num = (int)((num2 * 643689067) ^ 0x6ED71974);
					continue;
				case 95u:
					Registration.smethod_46((Control)(object)SuccessMsg, bool_0: false);
					num = ((int)num2 * -1477931454) ^ 0xCA82C15;
					continue;
				case 94u:
					Registration.smethod_18((Control)(object)NameTxt, new Size(318, 26));
					num = (int)(num2 * 558040814) ^ -1195869296;
					continue;
				case 93u:
					Registration.smethod_17((Control)(object)Label4, "Label4");
					num = (int)(num2 * 1815064779) ^ -1023330990;
					continue;
				case 92u:
					num = (int)((num2 * 1639095396) ^ 0x3B76A072);
					continue;
				case 91u:
					Registration.smethod_59((ISupportInitialize)PictureBox1);
					num = (int)((num2 * 735838941) ^ 0x78B600E5);
					continue;
				case 90u:
					Registration.smethod_60((Control)(object)this, bool_0: false);
					num = (int)((num2 * 289396555) ^ 0x451F03A5);
					continue;
				case 89u:
					num = ((int)num2 * -1857694518) ^ 0x5D5EE21B;
					continue;
				case 88u:
					Timer1 = Registration.smethod_9(components);
					PictureBox1 = Registration.smethod_10();
					num = (int)((num2 * 1554271304) ^ 0x69752E60);
					continue;
				case 87u:
					num = ((int)num2 * -1215751046) ^ -272035773;
					continue;
				case 86u:
					Registration.smethod_23(Registration.smethod_54((Control)(object)this), (Control)(object)SuccessMsg);
					num = (int)((num2 * 591156480) ^ 0xC9C1064);
					continue;
				case 85u:
					Registration.smethod_17((Control)(object)GenderTxt, "GenderTxt");
					num = (int)((num2 * 602466973) ^ 0x1F49B04D);
					continue;
				case 84u:
					Registration.smethod_16((Control)(object)MobileTxt, new Point(108, 203));
					num = (int)(num2 * 608543431) ^ -502805829;
					continue;
				case 83u:
					Registration.smethod_15((Control)(object)GenderTxt, Registration.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1237617017) ^ -117959734;
					continue;
				case 82u:
					Registration.smethod_11((Control)(object)GroupBox2);
					num = (int)(num2 * 613523486) ^ -1557505108;
					continue;
				case 81u:
					num = (int)((num2 * 1962520217) ^ 0x239F480B);
					continue;
				case 80u:
					Registration.smethod_17((Control)(object)RegisterBtn, "RegisterBtn");
					Registration.smethod_18((Control)(object)RegisterBtn, new Size(147, 47));
					num = ((int)num2 * -1298682461) ^ 0x5374E2EA;
					continue;
				case 79u:
					DOBTxt = Registration.smethod_5();
					num = (int)(num2 * 815398423) ^ -366308808;
					continue;
				case 78u:
					Registration.smethod_19((Control)(object)NameTxt, 0);
					num = (int)(num2 * 1398980682) ^ -503439820;
					continue;
				case 77u:
					Registration.smethod_19((Control)(object)SuccessMsg, 6);
					num = (int)(num2 * 1891497646) ^ -2091537703;
					continue;
				case 76u:
					Registration.smethod_19((Control)(object)Label5, 8);
					num = (int)((num2 * 1822545727) ^ 0x229D2F35);
					continue;
				case 75u:
					Registration.smethod_15((Control)(object)SuccessMsg, Registration.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1028546176) ^ 0x29BDCA44;
					continue;
				case 74u:
					num = (int)(num2 * 710639016) ^ -985936218;
					continue;
				case 73u:
					Registration.smethod_16((Control)(object)Label4, new Point(15, 110));
					num = (int)(num2 * 1640239579) ^ -1607769644;
					continue;
				case 72u:
					Label6 = Registration.smethod_3();
					num = (int)(num2 * 166649459) ^ -2079713283;
					continue;
				case 71u:
					Registration.smethod_23(Registration.smethod_54((Control)(object)this), (Control)(object)PictureBox1);
					num = ((int)num2 * -2025384934) ^ 0x1F0E5B0B;
					continue;
				case 70u:
					Registration.smethod_18((Control)(object)GenderTxt, new Size(112, 27));
					Registration.smethod_19((Control)(object)GenderTxt, 11);
					num = ((int)num2 * -1219342214) ^ -1143639372;
					continue;
				case 69u:
					num = ((int)num2 * -247064200) ^ -1530025786;
					continue;
				case 68u:
					Registration.smethod_18((Control)(object)Label1, new Size(372, 47));
					num = ((int)num2 * -2095248327) ^ -590317003;
					continue;
				case 67u:
					num = ((int)num2 * -921469520) ^ -1336687281;
					continue;
				case 66u:
					num = ((int)num2 * -1119632638) ^ 0x77DE71DE;
					continue;
				case 65u:
					Registration.smethod_17((Control)(object)AddressTxt, "AddressTxt");
					Registration.smethod_18((Control)(object)AddressTxt, new Size(316, 91));
					num = (int)((num2 * 1026152335) ^ 0x4B3B6F6D);
					continue;
				case 64u:
					Registration.smethod_19((Control)(object)GroupBox2, 3);
					Registration.smethod_24(GroupBox2, bool_0: false);
					Registration.smethod_25(GroupBox2, "Patient's Information");
					num = (int)(num2 * 1173236864) ^ -58052408;
					continue;
				case 63u:
					num = ((int)num2 * -801285894) ^ 0x8B41A93;
					continue;
				case 62u:
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)NameTxt);
					Registration.smethod_15((Control)(object)GroupBox2, Registration.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Registration.smethod_16((Control)(object)GroupBox2, new Point(261, 235));
					num = ((int)num2 * -1996469030) ^ 0xD997BA7;
					continue;
				case 61u:
					Registration.smethod_30(DOBTxt, new DateTime(2019, 2, 11, 0, 0, 0, 0));
					num = ((int)num2 * -509555367) ^ -1207854644;
					continue;
				case 60u:
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)AddressTxt);
					num = ((int)num2 * -183481410) ^ -1092024200;
					continue;
				case 59u:
					Registration.smethod_56((Control)(object)this, new Size(977, 804));
					num = ((int)num2 * -1969028239) ^ 0x53EEF775;
					continue;
				case 58u:
					Registration.smethod_19((Control)(object)MobileTxt, 12);
					num = (int)((num2 * 1766401671) ^ 0x685E9217);
					continue;
				case 57u:
					num = ((int)num2 * -1405131315) ^ 0x8BC7D91;
					continue;
				case 56u:
					Registration.smethod_16((Control)(object)DOBTxt, new Point(108, 110));
					Registration.smethod_28(DOBTxt, new DateTime(2019, 2, 11, 0, 0, 0, 0));
					num = (int)(num2 * 1044804803) ^ -465388479;
					continue;
				case 55u:
					Registration.smethod_17((Control)(object)SuccessMsg, "SuccessMsg");
					num = ((int)num2 * -1057077249) ^ 0x6D2086F0;
					continue;
				case 54u:
					Registration.smethod_19((Control)(object)Label4, 7);
					Registration.smethod_20(Label4, "DOB :");
					Registration.smethod_21(Label4, (ContentAlignment)32);
					num = (int)(num2 * 1552532694) ^ -1096766291;
					continue;
				case 53u:
					Registration.smethod_48(PictureBox1, (Image)(object)Resources.patient_pic);
					num = (int)(num2 * 442252266) ^ -38398332;
					continue;
				case 52u:
					Registration.smethod_15((Control)(object)Label3, Registration.smethod_14("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 447864786) ^ -1485351773;
					continue;
				case 51u:
					Registration.smethod_18((Control)(object)ClearBtn, new Size(146, 47));
					num = (int)(num2 * 1926172310) ^ -1942922740;
					continue;
				case 50u:
					num = (int)(num2 * 958549213) ^ -863886127;
					continue;
				case 49u:
					Registration.smethod_16((Control)(object)AddressTxt, new Point(110, 256));
					num = ((int)num2 * -865416358) ^ -2045673980;
					continue;
				case 48u:
					Registration.smethod_44((Control)(object)SuccessMsg, Color.Olive);
					num = ((int)num2 * -369636421) ^ 0x4BE43951;
					continue;
				case 47u:
					num = (int)((num2 * 893623284) ^ 0x4D56A863);
					continue;
				case 46u:
					Registration.smethod_55((Control)(object)this, "Registration");
					num = ((int)num2 * -518255681) ^ 0x4FC84DBB;
					continue;
				case 45u:
					Registration.smethod_18((Control)(object)Label4, new Size(60, 24));
					num = (int)((num2 * 1169332623) ^ 0x7DB7D141);
					continue;
				case 44u:
					Registration.smethod_50(PictureBox1, 1);
					num = ((int)num2 * -1677074998) ^ 0x14C7066F;
					continue;
				case 43u:
					num = ((int)num2 * -1733678225) ^ 0x27EEA484;
					continue;
				case 42u:
					components = Registration.smethod_2();
					num = (int)(num2 * 801367893) ^ -789068989;
					continue;
				case 41u:
					Registration.smethod_53((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1723194526) ^ -1566606256;
					continue;
				case 40u:
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)DOBTxt);
					num = (int)((num2 * 1654367783) ^ 0x3F667356);
					continue;
				case 39u:
					num = ((int)num2 * -209780581) ^ -1501476705;
					continue;
				case 38u:
					Registration.smethod_19((Control)(object)Label3, 6);
					num = (int)(num2 * 457668365) ^ -724052997;
					continue;
				case 37u:
					Registration.smethod_12((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -767815667) ^ 0x363A4E1;
					continue;
				case 36u:
					Registration.smethod_43((ButtonBase)(object)ClearBtn, bool_0: false);
					num = ((int)num2 * -1862749964) ^ 0xC00E90D;
					continue;
				case 35u:
					Registration.smethod_20(Label6, "Address :");
					num = ((int)num2 * -1988237498) ^ -1286037870;
					continue;
				case 34u:
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)GenderTxt);
					num = ((int)num2 * -1285271049) ^ -1832721948;
					continue;
				case 33u:
					Registration.smethod_18((Control)(object)Label6, new Size(87, 26));
					Registration.smethod_19((Control)(object)Label6, 9);
					num = ((int)num2 * -655024926) ^ -326264045;
					continue;
				case 32u:
					Registration.smethod_19((Control)(object)ClearBtn, 5);
					num = (int)(num2 * 306194435) ^ -764152724;
					continue;
				case 31u:
					Registration.smethod_23(Registration.smethod_54((Control)(object)this), (Control)(object)Label1);
					num = (int)((num2 * 568001948) ^ 0x7E83CCA4);
					continue;
				case 30u:
					Registration.smethod_42((ButtonBase)(object)ClearBtn, "Clear");
					num = (int)((num2 * 1973977739) ^ 0x322EBB14);
					continue;
				case 29u:
					Registration.smethod_37((ListControl)(object)GenderTxt, bool_0: true);
					num = (int)((num2 * 1398122971) ^ 0x56E82CEB);
					continue;
				case 28u:
					num = (int)(num2 * 1244287107) ^ -2069057997;
					continue;
				case 27u:
					Registration.smethod_19((Control)(object)Label1, 0);
					Registration.smethod_20(Label1, "Patient Registration");
					num = (int)(num2 * 585720965) ^ -1858779080;
					continue;
				case 26u:
					Registration.smethod_13((Control)(object)this);
					num = ((int)num2 * -82250298) ^ 0x30F32CA6;
					continue;
				case 25u:
					num = ((int)num2 * -608956961) ^ 0xFF0B2A0;
					continue;
				case 24u:
					Registration.smethod_15((Control)(object)Label1, Registration.smethod_14("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Registration.smethod_16((Control)(object)Label1, new Point(392, 60));
					num = ((int)num2 * -488222881) ^ -480881906;
					continue;
				case 23u:
					Registration.smethod_41((Control)(object)RegisterBtn, Color.White);
					Registration.smethod_16((Control)(object)RegisterBtn, new Point(600, 661));
					num = (int)((num2 * 2002893018) ^ 0x7B3A5D44);
					continue;
				case 22u:
					num = ((int)num2 * -770482779) ^ 0x44E9456A;
					continue;
				case 21u:
					Registration.smethod_43((ButtonBase)(object)RegisterBtn, bool_0: false);
					num = (int)((num2 * 1246977112) ^ 0x6E083B22);
					continue;
				case 20u:
					Registration.smethod_15((Control)(object)ClearBtn, Registration.smethod_14("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Registration.smethod_41((Control)(object)ClearBtn, Color.White);
					num = (int)((num2 * 175264958) ^ 0x2CB239EA);
					continue;
				case 19u:
					Label1 = Registration.smethod_3();
					num = ((int)num2 * -402988713) ^ 0x27AFB831;
					continue;
				case 18u:
					Registration.smethod_27(DOBTxt, (DateTimePickerFormat)2);
					num = (int)((num2 * 1186181830) ^ 0x12291CF6);
					continue;
				case 17u:
					Label3 = Registration.smethod_3();
					num = (int)((num2 * 2097538390) ^ 0xE8E9770);
					continue;
				case 16u:
					num = (int)(num2 * 265058764) ^ -1811819651;
					continue;
				case 15u:
					num = ((int)num2 * -400434910) ^ -1834160237;
					continue;
				case 14u:
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)Label4);
					num = (int)((num2 * 906354244) ^ 0x4C13E3CA);
					continue;
				case 13u:
					Registration.smethod_20(SuccessMsg, "Patient Successfully registered");
					num = (int)(num2 * 1709753688) ^ -536183601;
					continue;
				case 12u:
					Registration.smethod_17((Control)(object)Label1, "Label1");
					num = ((int)num2 * -2037814035) ^ -1676914462;
					continue;
				case 11u:
					AddressTxt = Registration.smethod_6();
					num = (int)((num2 * 179378359) ^ 0x1C273118);
					continue;
				case 10u:
					num = (int)(num2 * 696555350) ^ -1687691988;
					continue;
				case 9u:
					Registration.smethod_16((Control)(object)Label2, new Point(8, 55));
					num = ((int)num2 * -743777667) ^ 0x3E6DEA5;
					continue;
				case 8u:
					Registration.smethod_21(Label5, (ContentAlignment)32);
					num = ((int)num2 * -1223862652) ^ -1962730158;
					continue;
				case 7u:
					num = (int)((num2 * 2040799975) ^ 0x10484772);
					continue;
				case 6u:
					Registration.smethod_57((Control)(object)GroupBox2, bool_0: false);
					num = ((int)num2 * -1895475189) ^ 0x6774EE8C;
					continue;
				case 5u:
					Registration.smethod_52((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = (int)(num2 * 948445114) ^ -1262117695;
					continue;
				case 4u:
					Label2 = Registration.smethod_3();
					NameTxt = Registration.smethod_6();
					num = ((int)num2 * -150637028) ^ 0x440E9319;
					continue;
				case 3u:
					Registration.smethod_15((Control)(object)Label6, Registration.smethod_14("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Registration.smethod_16((Control)(object)Label6, new Point(17, 255));
					num = (int)((num2 * 933969860) ^ 0x21793D23);
					continue;
				case 2u:
					num = ((int)num2 * -2059840614) ^ -1861391813;
					continue;
				case 1u:
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)Label6);
					num = ((int)num2 * -1041113373) ^ -1334701682;
					continue;
				case 0u:
					Registration.smethod_42((ButtonBase)(object)RegisterBtn, "Register");
					num = ((int)num2 * -584785899) ^ 0x4DE0AE89;
					continue;
				default:
					return;
				case 181u:
					break;
				case 153u:
					return;
				}
				break;
			}
		}
	}

	private void Registration_Load(object sender, EventArgs e)
	{
		Registration.smethod_28(DOBTxt, DateTime.Now);
	}

	private void ClearBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -282334103;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCC6E0E6Au) % 11u)
				{
				case 10u:
					Registration.smethod_30(DOBTxt, Registration.smethod_69(Registration.smethod_68((object)DateTime.Now, "dd-MM-yyyy")));
					num = (int)((num2 * 1520844109) ^ 0x2D272748);
					continue;
				case 9u:
					num = ((int)num2 * -1462592317) ^ -98311754;
					continue;
				case 8u:
					Registration.smethod_67((TextBoxBase)(object)AddressTxt);
					num = ((int)num2 * -1386726359) ^ 0x12C46384;
					continue;
				case 7u:
					num = ((int)num2 * -898489441) ^ -192312791;
					continue;
				case 6u:
					Registration.smethod_46((Control)(object)SuccessMsg, bool_0: false);
					num = (int)(num2 * 2050185248) ^ -1661016441;
					continue;
				case 4u:
					num = ((int)num2 * -1631696752) ^ 0x7AD81774;
					continue;
				case 3u:
					Registration.smethod_67((TextBoxBase)(object)NameTxt);
					num = (int)(num2 * 179324632) ^ -1972043658;
					continue;
				case 1u:
					Registration.smethod_70(GenderTxt, -1);
					Registration.smethod_67((TextBoxBase)(object)MobileTxt);
					num = (int)((num2 * 1989559167) ^ 0x3647138);
					continue;
				case 0u:
					num = (int)((num2 * 207177824) ^ 0x2D6997BC);
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

	private void GenderTxt_SelectionChangeCommitted(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -709255941;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEAB6A493u) % 3u)
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
				Registration.smethod_71((Control)(object)MobileTxt);
				num = ((int)num2 * -2028759256) ^ 0x305F83C6;
			}
		}
	}

	private void RegisterBtn_Click(object sender, EventArgs e)
	{
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected I4, but got Unknown
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected I4, but got Unknown
		//IL_0345: Incompatible stack heights: 0 vs 1
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Incompatible stack heights: 0 vs 1
		//IL_0372: Incompatible stack heights: 0 vs 1
		//IL_0392: Incompatible stack heights: 0 vs 1
		//IL_03a5: Incompatible stack heights: 0 vs 1
		//IL_03d3: Incompatible stack heights: 0 vs 1
		//IL_03dd: Incompatible stack heights: 0 vs 1
		OleDbConnection oleDbConnection_ = default(OleDbConnection);
		bool flag = default(bool);
		DateTime dateTime_ = default(DateTime);
		string string_ = default(string);
		while (true)
		{
			int num = 224482002;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5887ADABu) % 7u)
				{
				case 6u:
					oleDbConnection_ = Registration.smethod_72();
					Registration.smethod_74(oleDbConnection_, Registration.smethod_73(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
					flag = !Validate_data();
					num = ((int)num2 * -237326350) ^ -48491457;
					continue;
				case 3u:
					dateTime_ = Registration.smethod_69(Registration.smethod_68((object)Registration.smethod_75(DOBTxt), "dd-MM-yyyy"));
					num = 1770889817;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 386780340;
						num5 = 386780340;
					}
					else
					{
						num4 = 531474025;
						num5 = 531474025;
					}
					num = num4 ^ ((int)num2 * -315294582);
					continue;
				}
				case 0u:
					Registration.smethod_76(oleDbConnection_);
					string_ = "Insert Into [Patient] (Name,DOB,Gender,Mobile,Address) Values (?,?,?,?,?)";
					num = (int)(num2 * 1066325833) ^ -473093823;
					continue;
				case 5u:
					break;
				default:
				{
					OleDbCommand val = Registration.smethod_77(string_, oleDbConnection_);
					try
					{
						while (true)
						{
							int num3 = 628338548;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x5887ADABu) % 11u)
								{
								case 10u:
									Registration.smethod_88(oleDbConnection_);
									num3 = ((int)num2 * -1579309827) ^ 0x6699CA0E;
									continue;
								case 9u:
									Registration.smethod_44((Control)(object)SuccessMsg, Color.Green);
									Registration.smethod_89(Timer1);
									num3 = ((int)num2 * -1751460726) ^ -2125995696;
									continue;
								case 6u:
									Registration.smethod_87((Component)(object)val);
									num3 = (int)(num2 * 748463734) ^ -983966586;
									continue;
								case 5u:
									num3 = (int)((num2 * 252433516) ^ 0x1CDCB765);
									continue;
								case 4u:
									Registration.smethod_20(SuccessMsg, "Patient Successfully Registered !!");
									num3 = ((int)num2 * -968374010) ^ -222735619;
									continue;
								case 3u:
									Registration.smethod_82(Registration.smethod_78(val), Registration.smethod_81("Name", (object)Registration.smethod_80(Registration.smethod_79(NameTxt))));
									Registration.smethod_82(Registration.smethod_78(val), Registration.smethod_81("DOB", (object)Registration.smethod_83(dateTime_)));
									Registration.smethod_82(Registration.smethod_78(val), Registration.smethod_81("Gender", (object)Registration.smethod_80(Registration.smethod_84(GenderTxt))));
									num3 = ((int)num2 * -1119201637) ^ -2105594223;
									continue;
								case 2u:
									Registration.smethod_86(val);
									num3 = ((int)num2 * -1197678351) ^ 0x2C3A411C;
									continue;
								case 1u:
									Registration.smethod_82(Registration.smethod_78(val), Registration.smethod_81("Mobile", (object)Registration.smethod_85(Registration.smethod_79(MobileTxt))));
									Registration.smethod_82(Registration.smethod_78(val), Registration.smethod_81("Address", (object)Registration.smethod_85(Registration.smethod_79(AddressTxt))));
									num3 = ((int)num2 * -1703979624) ^ 0x7041E45B;
									continue;
								case 0u:
									Registration.smethod_46((Control)(object)SuccessMsg, bool_0: true);
									num3 = (int)((num2 * 587671186) ^ 0x4FC7A448);
									continue;
								default:
									return;
								case 8u:
									break;
								case 7u:
									return;
								}
								break;
							}
						}
					}
					catch (Exception ex)
					{
						Registration.smethod_90(ex);
						Exception exception_ = ex;
						Registration.smethod_88(oleDbConnection_);
						while (true)
						{
							_ = 791426980;
							while (true)
							{
								_003F val2 = /*Error near IL_02fc: Stack underflow*/^ 0x5887ADAB;
								num2 = (uint)(int)val2;
								switch (val2 % 8)
								{
								case 7:
									Registration.smethod_46((Control)(object)SuccessMsg, bool_0: true);
									_ = ((int)num2 * -1606226008) ^ -1582225937;
									continue;
								case 6:
									Registration.smethod_92(Registration.smethod_91(exception_));
									_ = ((int)num2 * -212645097) ^ 0x6DA38831;
									continue;
								case 5:
									_ = (num2 * 294112) ^ 0x7A234AD0;
									continue;
								case 4:
									Registration.smethod_20(SuccessMsg, "Invalid Credentials");
									_ = (num2 * 351771958) ^ 0x8813FC12u;
									continue;
								case 1:
									_ = (num2 * 114772008) ^ 0xAD2AB4E5u;
									continue;
								case 0:
									Registration.smethod_44((Control)(object)SuccessMsg, Color.Red);
									Registration.smethod_89(Timer1);
									_ = (num2 * 589717234) ^ 0x3A643AB6;
									continue;
								case 2:
									break;
								default:
									Registration.smethod_93();
									return;
								}
								break;
							}
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

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Registration.smethod_46((Control)(object)SuccessMsg, bool_0: false);
		while (true)
		{
			int num = 291798715;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5F6F539Eu) % 5u)
				{
				case 4u:
					num = ((int)num2 * -1365939536) ^ 0x354ECDD4;
					continue;
				case 1u:
					num = ((int)num2 * -602514516) ^ 0x25241EC;
					continue;
				case 0u:
					Registration.smethod_94(Timer1);
					num = (int)((num2 * 1071001617) ^ 0x46B239A0);
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

	private bool Validate_data()
	{
		bool result = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -2091575885;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA0F4856Fu) % 36u)
				{
				case 35u:
					result = false;
					num = ((int)num2 * -745997545) ^ 0x6E089BC;
					continue;
				case 34u:
					num = (int)((num2 * 1454248104) ^ 0x62C6D0B2);
					continue;
				case 33u:
					Registration.smethod_46((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -857931637) ^ -918528228;
					continue;
				case 32u:
				{
					int num6;
					int num7;
					if (!MyProject.Forms.Form1.Name_Validation(Registration.smethod_80(Registration.smethod_79(NameTxt))))
					{
						num6 = -2097749131;
						num7 = -2097749131;
					}
					else
					{
						num6 = -1528198412;
						num7 = -1528198412;
					}
					num = num6 ^ (int)(num2 * 617334864);
					continue;
				}
				case 30u:
					Registration.smethod_89(Timer1);
					num = ((int)num2 * -1273712812) ^ 0x5BDDDE22;
					continue;
				case 29u:
					Registration.smethod_44((Control)(object)SuccessMsg, Color.Red);
					num = (int)(num2 * 312660446) ^ -78765826;
					continue;
				case 28u:
					num = (int)((num2 * 245905562) ^ 0xA1CD3FA);
					continue;
				case 27u:
					result = true;
					num = ((int)num2 * -1904393079) ^ 0x6CFA987D;
					continue;
				case 26u:
				{
					int num8;
					int num9;
					if (!flag2)
					{
						num8 = -1836103426;
						num9 = -1836103426;
					}
					else
					{
						num8 = -426898928;
						num9 = -426898928;
					}
					num = num8 ^ ((int)num2 * -2031066919);
					continue;
				}
				case 25u:
					Registration.smethod_89(Timer1);
					num = (int)((num2 * 270971809) ^ 0x19967C7D);
					continue;
				case 24u:
					result = false;
					num = ((int)num2 * -1463858973) ^ -1282302450;
					continue;
				case 23u:
					num = ((int)num2 * -119447515) ^ 0x3847841E;
					continue;
				case 22u:
					num = -1203355001;
					continue;
				case 21u:
					num = (int)(num2 * 1972381445) ^ -116497925;
					continue;
				case 20u:
					Registration.smethod_44((Control)(object)SuccessMsg, Color.Red);
					num = (int)(num2 * 1457576662) ^ -261691875;
					continue;
				case 19u:
					Registration.smethod_89(Timer1);
					result = false;
					num = (int)(num2 * 206337767) ^ -1751824021;
					continue;
				case 18u:
					Registration.smethod_46((Control)(object)SuccessMsg, bool_0: true);
					Registration.smethod_20(SuccessMsg, "Enter Address");
					num = ((int)num2 * -1913064270) ^ 0x29CA3063;
					continue;
				case 17u:
					Registration.smethod_44((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -1411980259) ^ 0x62658C43;
					continue;
				case 16u:
					num = ((int)num2 * -1891870342) ^ -14566732;
					continue;
				case 15u:
					num = (int)((num2 * 1380424918) ^ 0x4E92D319);
					continue;
				case 14u:
					Registration.smethod_46((Control)(object)SuccessMsg, bool_0: true);
					num = (int)(num2 * 767927087) ^ -1550121622;
					continue;
				case 12u:
					flag = Registration.smethod_95(Registration.smethod_79(AddressTxt), "", bool_0: false) == 0;
					num = ((int)num2 * -267482860) ^ -489283358;
					continue;
				case 11u:
				{
					int num5;
					if (!MyProject.Forms.Form1.Mobile_Validator(Registration.smethod_79(MobileTxt)))
					{
						num = -2123188113;
						num5 = -2123188113;
					}
					else
					{
						num = -1001048967;
						num5 = -1001048967;
					}
					continue;
				}
				case 10u:
					Registration.smethod_44((Control)(object)SuccessMsg, Color.Red);
					num = (int)((num2 * 1679791455) ^ 0x56FC0BB3);
					continue;
				case 9u:
					result = false;
					num = (int)(num2 * 87239900) ^ -1084926194;
					continue;
				case 8u:
					num = (int)((num2 * 1144971425) ^ 0x1F94E772);
					continue;
				case 7u:
					Registration.smethod_20(SuccessMsg, "Invalid Mobile Number");
					num = ((int)num2 * -1078392779) ^ 0x4A783864;
					continue;
				case 6u:
					Registration.smethod_20(SuccessMsg, "Invalid Name");
					num = (int)(num2 * 616853227) ^ -1434457412;
					continue;
				case 5u:
					Registration.smethod_20(SuccessMsg, "Invalid Gender");
					num = ((int)num2 * -1428980702) ^ 0x4D1B499B;
					continue;
				case 4u:
					num = -1347729816;
					continue;
				case 3u:
					flag2 = !MyProject.Forms.Form1.Gender_Validator(Registration.smethod_80(Registration.smethod_84(GenderTxt)));
					num = -136590387;
					continue;
				case 2u:
					Registration.smethod_89(Timer1);
					num = ((int)num2 * -1690708972) ^ 0x1B8D6A2B;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 2001368988;
						num4 = 2001368988;
					}
					else
					{
						num3 = 1639584342;
						num4 = 1639584342;
					}
					num = num3 ^ ((int)num2 * -2037655733);
					continue;
				}
				case 0u:
					Registration.smethod_46((Control)(object)SuccessMsg, bool_0: true);
					num = (int)((num2 * 589295178) ^ 0xAF56800);
					continue;
				case 31u:
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

	static void smethod_1(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_2()
	{
		return new Container();
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

	static DateTimePicker smethod_5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DateTimePicker();
	}

	static TextBox smethod_6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static ComboBox smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ComboBox();
	}

	static Button smethod_8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
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

	static void smethod_26(DateTimePicker dateTimePicker_0, string string_0)
	{
		dateTimePicker_0.set_CustomFormat(string_0);
	}

	static void smethod_27(DateTimePicker dateTimePicker_0, DateTimePickerFormat dateTimePickerFormat_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		dateTimePicker_0.set_Format(dateTimePickerFormat_0);
	}

	static void smethod_28(DateTimePicker dateTimePicker_0, DateTime dateTime_0)
	{
		dateTimePicker_0.set_MaxDate(dateTime_0);
	}

	static void smethod_29(DateTimePicker dateTimePicker_0, DateTime dateTime_0)
	{
		dateTimePicker_0.set_MinDate(dateTime_0);
	}

	static void smethod_30(DateTimePicker dateTimePicker_0, DateTime dateTime_0)
	{
		dateTimePicker_0.set_Value(dateTime_0);
	}

	static void smethod_31(TextBox textBox_0, bool bool_0)
	{
		textBox_0.set_Multiline(bool_0);
	}

	static AutoCompleteStringCollection smethod_32(ComboBox comboBox_0)
	{
		return comboBox_0.get_AutoCompleteCustomSource();
	}

	static void smethod_33(AutoCompleteStringCollection autoCompleteStringCollection_0, string[] string_0)
	{
		autoCompleteStringCollection_0.AddRange(string_0);
	}

	static void smethod_34(ComboBox comboBox_0, AutoCompleteMode autoCompleteMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		comboBox_0.set_AutoCompleteMode(autoCompleteMode_0);
	}

	static void smethod_35(ComboBox comboBox_0, AutoCompleteSource autoCompleteSource_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		comboBox_0.set_AutoCompleteSource(autoCompleteSource_0);
	}

	static void smethod_36(ComboBox comboBox_0, ComboBoxStyle comboBoxStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		comboBox_0.set_DropDownStyle(comboBoxStyle_0);
	}

	static void smethod_37(ListControl listControl_0, bool bool_0)
	{
		listControl_0.set_FormattingEnabled(bool_0);
	}

	static ObjectCollection smethod_38(ComboBox comboBox_0)
	{
		return comboBox_0.get_Items();
	}

	static void smethod_39(ObjectCollection objectCollection_0, object[] object_0)
	{
		objectCollection_0.AddRange(object_0);
	}

	static void smethod_40(ButtonBase buttonBase_0, Color color_0)
	{
		buttonBase_0.set_BackColor(color_0);
	}

	static void smethod_41(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
	}

	static void smethod_42(ButtonBase buttonBase_0, string string_0)
	{
		buttonBase_0.set_Text(string_0);
	}

	static void smethod_43(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_44(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static Color smethod_45()
	{
		return SystemColors.ButtonHighlight;
	}

	static void smethod_46(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static void smethod_47(Timer timer_0, int int_0)
	{
		timer_0.set_Interval(int_0);
	}

	static void smethod_48(PictureBox pictureBox_0, Image image_0)
	{
		pictureBox_0.set_Image(image_0);
	}

	static void smethod_49(PictureBox pictureBox_0, PictureBoxSizeMode pictureBoxSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		pictureBox_0.set_SizeMode(pictureBoxSizeMode_0);
	}

	static void smethod_50(PictureBox pictureBox_0, int int_0)
	{
		pictureBox_0.set_TabIndex(int_0);
	}

	static void smethod_51(PictureBox pictureBox_0, bool bool_0)
	{
		pictureBox_0.set_TabStop(bool_0);
	}

	static void smethod_52(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_53(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static ControlCollection smethod_54(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_55(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_56(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_57(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_58(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_59(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_60(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_61(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_62(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_63(ComboBox comboBox_0, EventHandler eventHandler_0)
	{
		comboBox_0.remove_SelectionChangeCommitted(eventHandler_0);
	}

	static void smethod_64(ComboBox comboBox_0, EventHandler eventHandler_0)
	{
		comboBox_0.add_SelectionChangeCommitted(eventHandler_0);
	}

	static void smethod_65(Timer timer_0, EventHandler eventHandler_0)
	{
		timer_0.remove_Tick(eventHandler_0);
	}

	static void smethod_66(Timer timer_0, EventHandler eventHandler_0)
	{
		timer_0.add_Tick(eventHandler_0);
	}

	static void smethod_67(TextBoxBase textBoxBase_0)
	{
		textBoxBase_0.Clear();
	}

	static string smethod_68(object object_0, string string_0)
	{
		return Strings.Format(object_0, string_0);
	}

	static DateTime smethod_69(string string_0)
	{
		return Conversions.ToDate(string_0);
	}

	static void smethod_70(ComboBox comboBox_0, int int_0)
	{
		comboBox_0.set_SelectedIndex(int_0);
	}

	static bool smethod_71(Control control_0)
	{
		return control_0.Focus();
	}

	static OleDbConnection smethod_72()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new OleDbConnection();
	}

	static string smethod_73(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_74(OleDbConnection oleDbConnection_0, string string_0)
	{
		oleDbConnection_0.set_ConnectionString(string_0);
	}

	static DateTime smethod_75(DateTimePicker dateTimePicker_0)
	{
		return dateTimePicker_0.get_Value();
	}

	static void smethod_76(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Open();
	}

	static OleDbCommand smethod_77(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbCommand(string_0, oleDbConnection_0);
	}

	static OleDbParameterCollection smethod_78(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.get_Parameters();
	}

	static string smethod_79(TextBox textBox_0)
	{
		return textBox_0.get_Text();
	}

	static string smethod_80(string string_0)
	{
		return string_0.ToLower();
	}

	static OleDbParameter smethod_81(string string_0, object object_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbParameter(string_0, object_0);
	}

	static OleDbParameter smethod_82(OleDbParameterCollection oleDbParameterCollection_0, OleDbParameter oleDbParameter_0)
	{
		return oleDbParameterCollection_0.Add(oleDbParameter_0);
	}

	static string smethod_83(DateTime dateTime_0)
	{
		return Conversions.ToString(dateTime_0);
	}

	static string smethod_84(ComboBox comboBox_0)
	{
		return comboBox_0.get_Text();
	}

	static string smethod_85(string string_0)
	{
		return string_0.ToString();
	}

	static int smethod_86(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.ExecuteNonQuery();
	}

	static void smethod_87(Component component_0)
	{
		component_0.Dispose();
	}

	static void smethod_88(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Close();
	}

	static void smethod_89(Timer timer_0)
	{
		timer_0.Start();
	}

	static void smethod_90(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static string smethod_91(Exception exception_0)
	{
		return exception_0.Message;
	}

	static DialogResult smethod_92(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}

	static void smethod_93()
	{
		ProjectData.ClearProjectError();
	}

	static void smethod_94(Timer timer_0)
	{
		timer_0.Stop();
	}

	static int smethod_95(string string_0, string string_1, bool bool_0)
	{
		return Operators.CompareString(string_0, string_1, bool_0);
	}
}
