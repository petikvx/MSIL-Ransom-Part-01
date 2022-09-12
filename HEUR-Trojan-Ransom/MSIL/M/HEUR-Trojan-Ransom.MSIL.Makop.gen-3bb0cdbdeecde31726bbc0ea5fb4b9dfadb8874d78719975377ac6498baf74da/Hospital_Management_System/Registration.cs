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
				int num = -1366695118;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB4C1B49Bu) % 7u)
					{
					case 6u:
						Registration.smethod_61((Control)(object)registerBtn, eventHandler_);
						num = (int)(num2 * 1589391479) ^ -1429785259;
						continue;
					case 5u:
						Registration.smethod_62((Control)(object)registerBtn, eventHandler_);
						num = ((int)num2 * -1245742805) ^ -1230724251;
						continue;
					case 3u:
					{
						_RegisterBtn = value;
						registerBtn = _RegisterBtn;
						int num5;
						if (registerBtn != null)
						{
							num = -1539598661;
							num5 = -1539598661;
						}
						else
						{
							num = -1667205115;
							num5 = -1667205115;
						}
						continue;
					}
					case 2u:
					{
						int num3;
						int num4;
						if (registerBtn != null)
						{
							num3 = 2035808677;
							num4 = 2035808677;
						}
						else
						{
							num3 = 1985271751;
							num4 = 1985271751;
						}
						num = num3 ^ (int)(num2 * 1165072303);
						continue;
					}
					case 1u:
						registerBtn = _RegisterBtn;
						num = (int)((num2 * 690106743) ^ 0x4E0B14B8);
						continue;
					default:
						return;
					case 0u:
						break;
					case 4u:
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
			if (clearBtn != null)
			{
				goto IL_006c;
			}
			goto IL_009a;
			IL_009a:
			_ClearBtn = value;
			clearBtn = _ClearBtn;
			int num = -1490059469;
			goto IL_0071;
			IL_0071:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE5188FFCu) % 6u)
				{
				case 4u:
					Registration.smethod_61((Control)(object)clearBtn, eventHandler_);
					num = (int)(num2 * 154886392) ^ -1684033125;
					continue;
				case 2u:
					Registration.smethod_62((Control)(object)clearBtn, eventHandler_);
					num = ((int)num2 * -1483787272) ^ 0x485B568F;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (clearBtn != null)
					{
						num3 = 784536434;
						num4 = 784536434;
					}
					else
					{
						num3 = 113828041;
						num4 = 113828041;
					}
					num = num3 ^ (int)(num2 * 1985006490);
					continue;
				}
				case 0u:
					break;
				default:
					return;
				case 5u:
					goto IL_009a;
				case 3u:
					return;
				}
				break;
			}
			goto IL_006c;
			IL_006c:
			num = -2071645164;
			goto IL_0071;
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
				int num = 1965800602;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7D682041u) % 8u)
					{
					case 7u:
						Registration.smethod_64(genderTxt, eventHandler_);
						num = ((int)num2 * -809047303) ^ 0x4644C383;
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (genderTxt == null)
						{
							num5 = -918334456;
							num6 = -918334456;
						}
						else
						{
							num5 = -719418750;
							num6 = -719418750;
						}
						num = num5 ^ ((int)num2 * -1671358218);
						continue;
					}
					case 4u:
						Registration.smethod_63(genderTxt, eventHandler_);
						num = ((int)num2 * -1025649487) ^ 0x4F30530C;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (genderTxt == null)
						{
							num3 = 754921539;
							num4 = 754921539;
						}
						else
						{
							num3 = 802464590;
							num4 = 802464590;
						}
						num = num3 ^ (int)(num2 * 142164449);
						continue;
					}
					case 2u:
						genderTxt = _GenderTxt;
						num = (int)((num2 * 99718067) ^ 0x567460B9);
						continue;
					case 1u:
						_GenderTxt = value;
						num = 1622652523;
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
			Timer timer = _Timer1;
			while (true)
			{
				int num = 2093384090;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6FC80191u) % 7u)
					{
					case 6u:
						_Timer1 = value;
						timer = _Timer1;
						num = 2092115519;
						continue;
					case 5u:
						Registration.smethod_65(timer, eventHandler_);
						num = (int)(num2 * 222432412) ^ -1774129392;
						continue;
					case 3u:
					{
						int num5;
						int num6;
						if (timer == null)
						{
							num5 = 1422152349;
							num6 = 1422152349;
						}
						else
						{
							num5 = 527706833;
							num6 = 527706833;
						}
						num = num5 ^ ((int)num2 * -1801247981);
						continue;
					}
					case 2u:
						Registration.smethod_66(timer, eventHandler_);
						num = (int)((num2 * 2094973683) ^ 0x6437A464);
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (timer == null)
						{
							num3 = 1409830076;
							num4 = 1409830076;
						}
						else
						{
							num3 = 1898100221;
							num4 = 1898100221;
						}
						num = num3 ^ ((int)num2 * -1732674685);
						continue;
					}
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

	[field: AccessedThroughProperty("DOBTxt")]
	internal virtual DateTimePicker DOBTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Registration()
	{
		while (true)
		{
			int num = 906142804;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x50DF96Eu) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0008:
				Registration.smethod_0((UserControl)(object)this, (EventHandler)Registration_Load);
				InitializeComponent();
				num = (int)((num2 * 2009837296) ^ 0x367B35A1);
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
				int num = -1040655967;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x88B617B0u) % 7u)
					{
					case 6u:
						if (disposing)
						{
							num = (int)(num2 * 1933311848) ^ -1700876072;
							continue;
						}
						num3 = 0;
						goto IL_001a;
					case 4u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -1897180083;
							num5 = -1897180083;
						}
						else
						{
							num4 = -275427737;
							num5 = -275427737;
						}
						num = num4 ^ ((int)num2 * -1230003622);
						continue;
					}
					case 3u:
						Registration.smethod_1((IDisposable)components);
						num = ((int)num2 * -1651956669) ^ -400603688;
						continue;
					case 1u:
						num = (int)((num2 * 912771664) ^ 0xC569879);
						continue;
					case 0u:
						num3 = ((components != null) ? 1 : 0);
						goto IL_001a;
					default:
						return;
					case 2u:
						break;
					case 5u:
						return;
						IL_001a:
						flag = (byte)num3 != 0;
						num = -1034192118;
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
			int num = 1422900818;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3C51C8B4u) % 199u)
				{
				case 198u:
					Registration.smethod_31(AddressTxt, bool_0: true);
					num = (int)(num2 * 704322707) ^ -623345854;
					continue;
				case 197u:
					Registration.smethod_18((Control)(object)PictureBox1, new Size(126, 122));
					num = (int)((num2 * 13882141) ^ 0x2181CBA9);
					continue;
				case 196u:
					Registration.smethod_15((Control)(object)Label1, Registration.smethod_14("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 962472740) ^ -1129577357;
					continue;
				case 195u:
					Registration.smethod_18((Control)(object)AddressTxt, new Size(316, 91));
					num = ((int)num2 * -330991972) ^ -1468838430;
					continue;
				case 194u:
					Registration.smethod_15((Control)(object)NameTxt, Registration.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1062401542) ^ 0x4F4B43FB);
					continue;
				case 193u:
					Registration.smethod_26(DOBTxt, "");
					num = ((int)num2 * -454882390) ^ 0x2FAE961E;
					continue;
				case 192u:
					Registration.smethod_19((Control)(object)Label2, 5);
					num = (int)((num2 * 1746564186) ^ 0x466C7737);
					continue;
				case 191u:
					Registration.smethod_15((Control)(object)Label4, Registration.smethod_14("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1334253244) ^ 0x81BEA40);
					continue;
				case 190u:
					num = (int)(num2 * 1853511423) ^ -1640387904;
					continue;
				case 189u:
					Registration.smethod_17((Control)(object)SuccessMsg, "SuccessMsg");
					num = ((int)num2 * -572049967) ^ -1480988110;
					continue;
				case 188u:
					GroupBox2 = Registration.smethod_4();
					num = (int)(num2 * 973810150) ^ -1941633118;
					continue;
				case 187u:
					Registration.smethod_17((Control)(object)DOBTxt, "DOBTxt");
					Registration.smethod_18((Control)(object)DOBTxt, new Size(178, 29));
					num = (int)((num2 * 1700826697) ^ 0x1E0A6031);
					continue;
				case 186u:
					Registration.smethod_23(Registration.smethod_54((Control)(object)this), (Control)(object)RegisterBtn);
					num = (int)(num2 * 1143670698) ^ -519244079;
					continue;
				case 185u:
					Registration.smethod_16((Control)(object)Label1, new Point(392, 60));
					num = ((int)num2 * -61103528) ^ -1148504149;
					continue;
				case 184u:
					Registration.smethod_40((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					num = (int)(num2 * 1985872665) ^ -323060796;
					continue;
				case 183u:
					Registration.smethod_20(Label5, "Mobile :");
					num = ((int)num2 * -1602807648) ^ 0x5522021B;
					continue;
				case 182u:
					num = (int)((num2 * 179688862) ^ 0x3ED7F160);
					continue;
				case 181u:
					Registration.smethod_19((Control)(object)Label3, 6);
					num = (int)(num2 * 149099942) ^ -1990813512;
					continue;
				case 180u:
					num = ((int)num2 * -1255694670) ^ -221591202;
					continue;
				case 179u:
					Registration.smethod_15((Control)(object)Label6, Registration.smethod_14("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1567965688) ^ -456479434;
					continue;
				case 178u:
					Registration.smethod_19((Control)(object)NameTxt, 0);
					Registration.smethod_40((ButtonBase)(object)RegisterBtn, Color.MidnightBlue);
					Registration.smethod_15((Control)(object)RegisterBtn, Registration.smethod_14("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -178579971) ^ 0x59530E02;
					continue;
				case 177u:
					num = (int)(num2 * 288907342) ^ -1534743132;
					continue;
				case 176u:
					num = ((int)num2 * -680428014) ^ -2142754237;
					continue;
				case 175u:
					Registration.smethod_43((ButtonBase)(object)RegisterBtn, bool_0: false);
					num = ((int)num2 * -1444368959) ^ -1160694016;
					continue;
				case 174u:
					num = ((int)num2 * -929062102) ^ 0x2D042587;
					continue;
				case 173u:
					Registration.smethod_20(Label2, "Name :");
					num = (int)(num2 * 410842599) ^ -1157852497;
					continue;
				case 172u:
					Label5 = Registration.smethod_3();
					num = (int)((num2 * 1881177439) ^ 0x6D888470);
					continue;
				case 171u:
					num = ((int)num2 * -1211355124) ^ 0x260B8862;
					continue;
				case 170u:
					Timer1 = Registration.smethod_9(components);
					num = (int)((num2 * 254909923) ^ 0xEDED44E);
					continue;
				case 169u:
					Registration.smethod_17((Control)(object)MobileTxt, "MobileTxt");
					num = (int)((num2 * 987549544) ^ 0x57418988);
					continue;
				case 168u:
					components = Registration.smethod_2();
					Label1 = Registration.smethod_3();
					num = ((int)num2 * -897319389) ^ -1880241940;
					continue;
				case 167u:
					Registration.smethod_16((Control)(object)ClearBtn, new Point(261, 661));
					num = ((int)num2 * -339663447) ^ 0x7831701D;
					continue;
				case 166u:
					Label3 = Registration.smethod_3();
					Label2 = Registration.smethod_3();
					num = ((int)num2 * -585100993) ^ 0x7464CC24;
					continue;
				case 165u:
					Registration.smethod_20(Label3, "Gender :");
					num = (int)(num2 * 1009145023) ^ -385113943;
					continue;
				case 164u:
					Registration.smethod_44((Control)(object)SuccessMsg, Color.Olive);
					num = (int)((num2 * 1339708160) ^ 0x244A53E5);
					continue;
				case 163u:
					Registration.smethod_19((Control)(object)Label4, 7);
					num = (int)((num2 * 603097390) ^ 0x5FFF60A);
					continue;
				case 162u:
					NameTxt = Registration.smethod_6();
					num = ((int)num2 * -839011121) ^ -2071552711;
					continue;
				case 161u:
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)DOBTxt);
					num = ((int)num2 * -888773138) ^ 0x70DB55FD;
					continue;
				case 160u:
					Registration.smethod_37((ListControl)(object)GenderTxt, bool_0: true);
					num = (int)(num2 * 475607965) ^ -435150309;
					continue;
				case 159u:
					Registration.smethod_18((Control)(object)Label6, new Size(87, 26));
					num = ((int)num2 * -575277934) ^ -1057999512;
					continue;
				case 158u:
					Registration.smethod_17((Control)(object)Label4, "Label4");
					num = (int)(num2 * 2043329342) ^ -520788191;
					continue;
				case 157u:
					num = ((int)num2 * -482494452) ^ -1602123218;
					continue;
				case 156u:
					num = ((int)num2 * -1858094333) ^ -322575816;
					continue;
				case 155u:
					Registration.smethod_51(PictureBox1, bool_0: false);
					Registration.smethod_52((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -1917776656) ^ 0x7F737684;
					continue;
				case 154u:
					Registration.smethod_16((Control)(object)Label5, new Point(6, 203));
					Registration.smethod_17((Control)(object)Label5, "Label5");
					num = ((int)num2 * -2070075163) ^ -1108745255;
					continue;
				case 153u:
					AddressTxt = Registration.smethod_6();
					num = ((int)num2 * -1373211023) ^ -283431602;
					continue;
				case 152u:
					Registration.smethod_11((Control)(object)GroupBox2);
					num = ((int)num2 * -1022260827) ^ 0x2DE88E2D;
					continue;
				case 151u:
					num = ((int)num2 * -44524500) ^ -1415769100;
					continue;
				case 150u:
					Registration.smethod_16((Control)(object)GroupBox2, new Point(261, 235));
					num = ((int)num2 * -222481503) ^ 0x210193E8;
					continue;
				case 149u:
					Registration.smethod_15((Control)(object)Label3, Registration.smethod_14("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -513919603) ^ -1418124173;
					continue;
				case 148u:
					num = ((int)num2 * -177715718) ^ 0x6BC1FF7A;
					continue;
				case 147u:
					num = ((int)num2 * -1784793016) ^ -811056784;
					continue;
				case 146u:
					num = (int)((num2 * 729850326) ^ 0x7FC41302);
					continue;
				case 145u:
					num = (int)((num2 * 1264000188) ^ 0x292F4710);
					continue;
				case 144u:
					Registration.smethod_17((Control)(object)GenderTxt, "GenderTxt");
					num = (int)((num2 * 1865018622) ^ 0x25FE8AD0);
					continue;
				case 143u:
					Registration.smethod_17((Control)(object)PictureBox1, "PictureBox1");
					num = (int)((num2 * 1888441067) ^ 0x6F39F643);
					continue;
				case 142u:
					GenderTxt = Registration.smethod_7();
					num = ((int)num2 * -1803310871) ^ 0x1A009EEC;
					continue;
				case 141u:
					num = ((int)num2 * -358777074) ^ -1376266017;
					continue;
				case 140u:
					Registration.smethod_15((Control)(object)ClearBtn, Registration.smethod_14("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 951768421) ^ 0x2D0AA0ED);
					continue;
				case 139u:
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)Label2);
					num = (int)(num2 * 324766016) ^ -998092053;
					continue;
				case 138u:
					num = ((int)num2 * -534367779) ^ 0x1D60A4EA;
					continue;
				case 137u:
					Registration.smethod_16((Control)(object)Label3, new Point(15, 151));
					num = ((int)num2 * -1084461759) ^ -220560543;
					continue;
				case 136u:
					Registration.smethod_19((Control)(object)MobileTxt, 12);
					num = ((int)num2 * -1172716942) ^ 0x4B88FF3E;
					continue;
				case 135u:
					num = ((int)num2 * -1339032521) ^ 0xA6C7A07;
					continue;
				case 134u:
					Registration.smethod_12((ISupportInitialize)PictureBox1);
					Registration.smethod_13((Control)(object)this);
					num = (int)(num2 * 1020020105) ^ -1559221520;
					continue;
				case 133u:
					Registration.smethod_21(SuccessMsg, (ContentAlignment)32);
					Registration.smethod_46((Control)(object)SuccessMsg, bool_0: false);
					num = (int)((num2 * 628261797) ^ 0x7B6CA0D5);
					continue;
				case 132u:
					Registration.smethod_19((Control)(object)ClearBtn, 5);
					num = ((int)num2 * -1388408881) ^ -1077164332;
					continue;
				case 131u:
					num = (int)(num2 * 791724274) ^ -649590536;
					continue;
				case 130u:
					Registration.smethod_19((Control)(object)SuccessMsg, 6);
					num = ((int)num2 * -765332012) ^ -2128442641;
					continue;
				case 129u:
					Registration.smethod_18((Control)(object)NameTxt, new Size(318, 26));
					num = ((int)num2 * -593889926) ^ -1719345303;
					continue;
				case 128u:
					num = ((int)num2 * -208225330) ^ -1040180415;
					continue;
				case 127u:
					Label4 = Registration.smethod_3();
					num = (int)((num2 * 432799632) ^ 0x2B92A99);
					continue;
				case 126u:
					Registration.smethod_41((Control)(object)ClearBtn, Color.White);
					num = ((int)num2 * -394653028) ^ 0x5F2B95F2;
					continue;
				case 125u:
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)Label4);
					num = (int)((num2 * 664115725) ^ 0x11FAFB58);
					continue;
				case 124u:
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)Label6);
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)Label5);
					num = (int)(num2 * 1092775854) ^ -1205426318;
					continue;
				case 123u:
					Registration.smethod_16((Control)(object)MobileTxt, new Point(108, 203));
					num = (int)((num2 * 1508665148) ^ 0x42DC8771);
					continue;
				case 122u:
					Registration.smethod_19((Control)(object)Label6, 9);
					num = (int)(num2 * 361518855) ^ -797171989;
					continue;
				case 121u:
					num = ((int)num2 * -1443145953) ^ -246630783;
					continue;
				case 120u:
					num = ((int)num2 * -328462520) ^ -251988776;
					continue;
				case 119u:
					Registration.smethod_17((Control)(object)Label1, "Label1");
					Registration.smethod_18((Control)(object)Label1, new Size(372, 47));
					Registration.smethod_19((Control)(object)Label1, 0);
					num = (int)(num2 * 832272653) ^ -1984018707;
					continue;
				case 118u:
					num = ((int)num2 * -748204857) ^ -1025403451;
					continue;
				case 117u:
					Registration.smethod_21(Label6, (ContentAlignment)32);
					num = (int)((num2 * 1432085103) ^ 0x411F3706);
					continue;
				case 116u:
					num = (int)(num2 * 1750209699) ^ -1042446714;
					continue;
				case 115u:
					Registration.smethod_42((ButtonBase)(object)RegisterBtn, "Register");
					num = ((int)num2 * -990418368) ^ 0x42376E91;
					continue;
				case 114u:
					Registration.smethod_18((Control)(object)ClearBtn, new Size(146, 47));
					num = (int)((num2 * 945199190) ^ 0x5BF1EC39);
					continue;
				case 113u:
					num = (int)(num2 * 556752753) ^ -2060103371;
					continue;
				case 112u:
					Registration.smethod_18((Control)(object)RegisterBtn, new Size(147, 47));
					num = (int)((num2 * 2003213395) ^ 0x60E81048);
					continue;
				case 111u:
					num = (int)((num2 * 476858473) ^ 0x5442E751);
					continue;
				case 110u:
					Registration.smethod_18((Control)(object)Label4, new Size(60, 24));
					num = (int)(num2 * 892887821) ^ -1641445385;
					continue;
				case 109u:
					Registration.smethod_21(Label3, (ContentAlignment)32);
					Registration.smethod_15((Control)(object)Label2, Registration.smethod_14("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1991715228) ^ -1285394817;
					continue;
				case 108u:
					num = (int)(num2 * 252167055) ^ -788611469;
					continue;
				case 107u:
					Registration.smethod_48(PictureBox1, (Image)(object)Resources.patient_pic);
					num = (int)(num2 * 1249261055) ^ -856278624;
					continue;
				case 106u:
					num = (int)((num2 * 221721479) ^ 0x279F665);
					continue;
				case 105u:
					Registration.smethod_23(Registration.smethod_54((Control)(object)this), (Control)(object)ClearBtn);
					num = (int)((num2 * 248880722) ^ 0x6CAD24A6);
					continue;
				case 104u:
					Registration.smethod_19((Control)(object)GroupBox2, 3);
					num = ((int)num2 * -1346657816) ^ 0xC789F8D;
					continue;
				case 103u:
					RegisterBtn = Registration.smethod_8();
					ClearBtn = Registration.smethod_8();
					SuccessMsg = Registration.smethod_3();
					num = ((int)num2 * -2010468214) ^ -1768407510;
					continue;
				case 102u:
					Registration.smethod_18((Control)(object)Label5, new Size(94, 29));
					num = (int)((num2 * 689636273) ^ 0x17374E5B);
					continue;
				case 101u:
					num = (int)((num2 * 1486307881) ^ 0x63EB8AB8);
					continue;
				case 100u:
					Registration.smethod_15((Control)(object)GenderTxt, Registration.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1150089172) ^ -1561127200;
					continue;
				case 99u:
					num = (int)((num2 * 1068605763) ^ 0x1FC7852D);
					continue;
				case 98u:
					Registration.smethod_30(DOBTxt, new DateTime(2019, 2, 11, 0, 0, 0, 0));
					num = (int)(num2 * 1171122082) ^ -572738903;
					continue;
				case 97u:
					PictureBox1 = Registration.smethod_10();
					num = (int)((num2 * 827272280) ^ 0x7AC815EB);
					continue;
				case 96u:
					num = (int)((num2 * 75761015) ^ 0xF0ACC32);
					continue;
				case 95u:
					Registration.smethod_41((Control)(object)SuccessMsg, Registration.smethod_45());
					num = (int)(num2 * 1258184316) ^ -1065017860;
					continue;
				case 94u:
					num = (int)((num2 * 919182550) ^ 0x7A0BDEFE);
					continue;
				case 93u:
					num = ((int)num2 * -1086165458) ^ -38598912;
					continue;
				case 92u:
					MobileTxt = Registration.smethod_6();
					num = (int)(num2 * 2028273769) ^ -728259008;
					continue;
				case 91u:
					Registration.smethod_43((ButtonBase)(object)ClearBtn, bool_0: false);
					num = ((int)num2 * -1002249630) ^ -1394316684;
					continue;
				case 90u:
					Registration.smethod_44((Control)(object)this, Color.White);
					Registration.smethod_23(Registration.smethod_54((Control)(object)this), (Control)(object)SuccessMsg);
					num = ((int)num2 * -1926826878) ^ -1044718475;
					continue;
				case 89u:
					Registration.smethod_18((Control)(object)GroupBox2, new Size(486, 394));
					num = ((int)num2 * -1528130005) ^ 0x584718BC;
					continue;
				case 88u:
					Registration.smethod_17((Control)(object)RegisterBtn, "RegisterBtn");
					num = ((int)num2 * -683070272) ^ -1091632964;
					continue;
				case 87u:
					num = ((int)num2 * -1462452773) ^ 0x5BB59F9B;
					continue;
				case 86u:
					Registration.smethod_16((Control)(object)PictureBox1, new Point(281, 21));
					num = (int)((num2 * 778475306) ^ 0x7A9512D3);
					continue;
				case 85u:
					Registration.smethod_33(Registration.smethod_32(GenderTxt), new string[3] { "Male", "Female", "Others" });
					num = (int)((num2 * 1333180373) ^ 0xF02075D);
					continue;
				case 84u:
					Registration.smethod_47(Timer1, 1500);
					num = ((int)num2 * -2083315960) ^ 0x57E3628B;
					continue;
				case 83u:
					Registration.smethod_28(DOBTxt, new DateTime(2019, 2, 11, 0, 0, 0, 0));
					Registration.smethod_29(DOBTxt, new DateTime(1900, 1, 1, 0, 0, 0, 0));
					num = (int)((num2 * 1773195729) ^ 0x7EEDDACF);
					continue;
				case 82u:
					num = (int)((num2 * 1784743600) ^ 0x3E8696E);
					continue;
				case 81u:
					num = (int)((num2 * 1930761378) ^ 0x71BD4687);
					continue;
				case 80u:
					Registration.smethod_15((Control)(object)Label5, Registration.smethod_14("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1197973345) ^ -923669565;
					continue;
				case 79u:
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)MobileTxt);
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)GenderTxt);
					num = ((int)num2 * -1962329678) ^ -624511861;
					continue;
				case 78u:
					Registration.smethod_16((Control)(object)Label4, new Point(15, 110));
					num = (int)((num2 * 1718059354) ^ 0x1664B2FD);
					continue;
				case 76u:
					Registration.smethod_17((Control)(object)ClearBtn, "ClearBtn");
					num = ((int)num2 * -64453588) ^ 0x510D9641;
					continue;
				case 75u:
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)NameTxt);
					num = (int)(num2 * 776121388) ^ -1230648059;
					continue;
				case 74u:
					Registration.smethod_20(Label6, "Address :");
					num = ((int)num2 * -921155655) ^ -2119452186;
					continue;
				case 73u:
					Registration.smethod_16((Control)(object)Label2, new Point(8, 55));
					Registration.smethod_17((Control)(object)Label2, "Label2");
					num = (int)(num2 * 275242763) ^ -297083587;
					continue;
				case 72u:
					Registration.smethod_15((Control)(object)MobileTxt, Registration.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1310082244) ^ -1606146126;
					continue;
				case 71u:
					num = ((int)num2 * -1642320764) ^ -237198774;
					continue;
				case 70u:
					Registration.smethod_57((Control)(object)GroupBox2, bool_0: false);
					num = (int)(num2 * 1619386064) ^ -1011802428;
					continue;
				case 69u:
					Registration.smethod_16((Control)(object)DOBTxt, new Point(108, 110));
					num = ((int)num2 * -436214988) ^ -1818976657;
					continue;
				case 68u:
					Registration.smethod_19((Control)(object)RegisterBtn, 4);
					num = (int)(num2 * 1596269228) ^ -235977886;
					continue;
				case 67u:
					Registration.smethod_21(Label5, (ContentAlignment)32);
					num = ((int)num2 * -1279858697) ^ -2038718774;
					continue;
				case 66u:
					Registration.smethod_17((Control)(object)Label3, "Label3");
					num = (int)(num2 * 776759017) ^ -1735066870;
					continue;
				case 65u:
					Registration.smethod_17((Control)(object)AddressTxt, "AddressTxt");
					num = ((int)num2 * -2026436390) ^ 0x2D457A46;
					continue;
				case 64u:
					Registration.smethod_58((Control)(object)GroupBox2);
					num = (int)(num2 * 263968577) ^ -2115720633;
					continue;
				case 63u:
					Registration.smethod_19((Control)(object)DOBTxt, 14);
					num = (int)(num2 * 1063387034) ^ -2030753417;
					continue;
				case 62u:
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)Label3);
					num = (int)((num2 * 1108913174) ^ 0x80B184C);
					continue;
				case 61u:
					Registration.smethod_18((Control)(object)Label2, new Size(87, 23));
					num = ((int)num2 * -13765967) ^ 0x5092F58;
					continue;
				case 60u:
					num = (int)(num2 * 1104662474) ^ -62841515;
					continue;
				case 59u:
					num = ((int)num2 * -1576184488) ^ 0x4212824;
					continue;
				case 58u:
					Registration.smethod_20(Label4, "DOB :");
					Registration.smethod_21(Label4, (ContentAlignment)32);
					num = ((int)num2 * -1396754928) ^ 0x73EBACCE;
					continue;
				case 57u:
					num = ((int)num2 * -1601173802) ^ 0x3585636B;
					continue;
				case 56u:
					Registration.smethod_20(SuccessMsg, "Patient Successfully registered");
					num = (int)((num2 * 1812256886) ^ 0x7C91066C);
					continue;
				case 55u:
					num = ((int)num2 * -751380523) ^ -6629906;
					continue;
				case 54u:
					Registration.smethod_16((Control)(object)Label6, new Point(17, 255));
					Registration.smethod_17((Control)(object)Label6, "Label6");
					num = (int)(num2 * 1788984189) ^ -384937272;
					continue;
				case 53u:
					Registration.smethod_23(Registration.smethod_54((Control)(object)this), (Control)(object)Label1);
					num = ((int)num2 * -674955670) ^ -516352601;
					continue;
				case 52u:
					Registration.smethod_16((Control)(object)NameTxt, new Point(108, 55));
					num = (int)((num2 * 381803764) ^ 0x293AE983);
					continue;
				case 51u:
					Registration.smethod_19((Control)(object)Label5, 8);
					num = ((int)num2 * -1421170304) ^ -1828308994;
					continue;
				case 50u:
					num = (int)((num2 * 1037751447) ^ 0x7C2E37F3);
					continue;
				case 49u:
					Registration.smethod_17((Control)(object)NameTxt, "NameTxt");
					num = ((int)num2 * -803216517) ^ 0x27C0CC42;
					continue;
				case 48u:
					num = ((int)num2 * -287933567) ^ -1519846808;
					continue;
				case 47u:
					Registration.smethod_53((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1815084501) ^ -1053610612;
					continue;
				case 46u:
					Registration.smethod_20(Label1, "Patient Registration");
					num = (int)(num2 * 400518225) ^ -623132936;
					continue;
				case 45u:
					num = ((int)num2 * -1450589209) ^ 0x62DE3A9B;
					continue;
				case 44u:
					Registration.smethod_15((Control)(object)AddressTxt, Registration.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Registration.smethod_16((Control)(object)AddressTxt, new Point(110, 256));
					num = (int)(num2 * 1808277326) ^ -641271375;
					continue;
				case 43u:
					num = (int)(num2 * 696575192) ^ -688636134;
					continue;
				case 42u:
					Registration.smethod_16((Control)(object)SuccessMsg, new Point(305, 156));
					num = ((int)num2 * -1565908520) ^ 0x3CBE9E50;
					continue;
				case 41u:
					num = (int)(num2 * 1780423996) ^ -929109719;
					continue;
				case 40u:
					num = (int)(num2 * 689836487) ^ -1936868208;
					continue;
				case 39u:
					num = ((int)num2 * -1274069316) ^ 0x22B45818;
					continue;
				case 38u:
					Label6 = Registration.smethod_3();
					num = (int)(num2 * 1813052015) ^ -472899224;
					continue;
				case 37u:
					num = ((int)num2 * -31623977) ^ 0x79D69933;
					continue;
				case 36u:
					Registration.smethod_19((Control)(object)AddressTxt, 13);
					num = (int)(num2 * 892755588) ^ -802827502;
					continue;
				case 35u:
					Registration.smethod_49(PictureBox1, (PictureBoxSizeMode)1);
					num = ((int)num2 * -1376526975) ^ 0x7E6E3E99;
					continue;
				case 34u:
					num = ((int)num2 * -147079716) ^ 0x5ECD3081;
					continue;
				case 33u:
					Registration.smethod_34(GenderTxt, (AutoCompleteMode)2);
					Registration.smethod_35(GenderTxt, (AutoCompleteSource)256);
					num = (int)(num2 * 1983961082) ^ -1363875936;
					continue;
				case 32u:
					Registration.smethod_17((Control)(object)GroupBox2, "GroupBox2");
					num = (int)(num2 * 624823966) ^ -1157617881;
					continue;
				case 31u:
					Registration.smethod_50(PictureBox1, 1);
					num = ((int)num2 * -447160113) ^ 0x7A0B5522;
					continue;
				case 30u:
					num = ((int)num2 * -663235668) ^ -2101589815;
					continue;
				case 29u:
					num = ((int)num2 * -1614152222) ^ 0x3E5A022B;
					continue;
				case 28u:
					num = (int)(num2 * 39770678) ^ -89564117;
					continue;
				case 27u:
					DOBTxt = Registration.smethod_5();
					num = (int)(num2 * 309769178) ^ -898920219;
					continue;
				case 26u:
					Registration.smethod_19((Control)(object)GenderTxt, 11);
					num = (int)(num2 * 408380126) ^ -1347758861;
					continue;
				case 25u:
					Registration.smethod_15((Control)(object)SuccessMsg, Registration.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1845702124) ^ 0x61DCC475;
					continue;
				case 24u:
					Registration.smethod_18((Control)(object)GenderTxt, new Size(112, 27));
					num = ((int)num2 * -841192415) ^ -2121981801;
					continue;
				case 23u:
					Registration.smethod_25(GroupBox2, "Patient's Information");
					num = (int)(num2 * 581756774) ^ -1089505912;
					continue;
				case 22u:
					Registration.smethod_41((Control)(object)RegisterBtn, Color.White);
					num = (int)(num2 * 1974028776) ^ -1806917231;
					continue;
				case 21u:
					Registration.smethod_21(Label2, (ContentAlignment)32);
					num = (int)((num2 * 1418557533) ^ 0x65F4F608);
					continue;
				case 20u:
					num = ((int)num2 * -867417231) ^ 0x2EE63BD4;
					continue;
				case 19u:
					Registration.smethod_27(DOBTxt, (DateTimePickerFormat)2);
					num = (int)((num2 * 1352516397) ^ 0x3CEB2C1C);
					continue;
				case 18u:
					Registration.smethod_59((ISupportInitialize)PictureBox1);
					Registration.smethod_60((Control)(object)this, bool_0: false);
					num = ((int)num2 * -542199692) ^ -1125409308;
					continue;
				case 17u:
					Registration.smethod_23(Registration.smethod_54((Control)(object)this), (Control)(object)GroupBox2);
					Registration.smethod_23(Registration.smethod_54((Control)(object)this), (Control)(object)PictureBox1);
					num = ((int)num2 * -576241573) ^ 0x68417541;
					continue;
				case 16u:
					Registration.smethod_15((Control)(object)GroupBox2, Registration.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1517743237) ^ -1354297020;
					continue;
				case 15u:
					Registration.smethod_55((Control)(object)this, "Registration");
					Registration.smethod_56((Control)(object)this, new Size(977, 804));
					num = ((int)num2 * -1297723983) ^ -895487704;
					continue;
				case 14u:
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)AddressTxt);
					num = (int)(num2 * 1008886726) ^ -174335490;
					continue;
				case 13u:
					Registration.smethod_24(GroupBox2, bool_0: false);
					num = (int)(num2 * 1068305069) ^ -208266945;
					continue;
				case 12u:
					Registration.smethod_39(Registration.smethod_38(GenderTxt), new object[3] { "Male", "Female", "Others" });
					Registration.smethod_16((Control)(object)GenderTxt, new Point(108, 151));
					num = (int)(num2 * 1073258320) ^ -314502867;
					continue;
				case 10u:
					Registration.smethod_21(Label1, (ContentAlignment)32);
					num = (int)(num2 * 542379892) ^ -722911120;
					continue;
				case 9u:
					Registration.smethod_36(GenderTxt, (ComboBoxStyle)2);
					num = (int)((num2 * 1729863421) ^ 0x684C637B);
					continue;
				case 8u:
					num = (int)(num2 * 1775956582) ^ -2035911724;
					continue;
				case 7u:
					num = ((int)num2 * -1716448813) ^ 0x6B0C81E4;
					continue;
				case 6u:
					Registration.smethod_16((Control)(object)RegisterBtn, new Point(600, 661));
					num = (int)((num2 * 1013930995) ^ 0x35901E68);
					continue;
				case 5u:
					Registration.smethod_42((ButtonBase)(object)ClearBtn, "Clear");
					num = ((int)num2 * -1144497651) ^ 0x2BD96D6E;
					continue;
				case 4u:
					num = ((int)num2 * -1522818026) ^ -1974723359;
					continue;
				case 3u:
					Registration.smethod_18((Control)(object)MobileTxt, new Size(201, 26));
					num = ((int)num2 * -1285769320) ^ 0x2EC3078A;
					continue;
				case 2u:
					Registration.smethod_18((Control)(object)SuccessMsg, new Size(401, 44));
					num = ((int)num2 * -1555354658) ^ 0x3A87AE27;
					continue;
				case 1u:
					Registration.smethod_18((Control)(object)Label3, new Size(82, 31));
					num = ((int)num2 * -1453334890) ^ 0x3C68EFF4;
					continue;
				case 0u:
					num = ((int)num2 * -868430327) ^ 0x3B851ACA;
					continue;
				default:
					return;
				case 77u:
					break;
				case 11u:
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
			int num = -1952834738;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF2DFAD0Bu) % 9u)
				{
				case 7u:
					Registration.smethod_67((TextBoxBase)(object)MobileTxt);
					num = ((int)num2 * -1668927847) ^ -8966973;
					continue;
				case 6u:
					Registration.smethod_67((TextBoxBase)(object)NameTxt);
					num = ((int)num2 * -9344249) ^ 0x42190C20;
					continue;
				case 5u:
					Registration.smethod_46((Control)(object)SuccessMsg, bool_0: false);
					num = ((int)num2 * -1998119819) ^ -1673621512;
					continue;
				case 4u:
					Registration.smethod_67((TextBoxBase)(object)AddressTxt);
					num = ((int)num2 * -1580169964) ^ -1236839171;
					continue;
				case 3u:
					Registration.smethod_30(DOBTxt, Registration.smethod_69(Registration.smethod_68((object)DateTime.Now, "dd-MM-yyyy")));
					Registration.smethod_70(GenderTxt, -1);
					num = ((int)num2 * -839541096) ^ -1827614662;
					continue;
				case 1u:
					num = ((int)num2 * -1961983652) ^ 0x507D414D;
					continue;
				case 0u:
					num = (int)(num2 * 2055115237) ^ -706152807;
					continue;
				default:
					return;
				case 2u:
					break;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	private void GenderTxt_SelectionChangeCommitted(object sender, EventArgs e)
	{
		Registration.smethod_71((Control)(object)MobileTxt);
	}

	private void RegisterBtn_Click(object sender, EventArgs e)
	{
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected I4, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected I4, but got Unknown
		//IL_0393: Incompatible stack heights: 0 vs 1
		//IL_03a3: Incompatible stack heights: 0 vs 1
		//IL_03c3: Incompatible stack heights: 0 vs 1
		//IL_03d9: Incompatible stack heights: 0 vs 1
		//IL_03f8: Incompatible stack heights: 0 vs 1
		//IL_0426: Incompatible stack heights: 0 vs 1
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Incompatible stack heights: 0 vs 1
		//IL_0450: Incompatible stack heights: 0 vs 1
		OleDbConnection oleDbConnection_ = Registration.smethod_72();
		bool flag = default(bool);
		DateTime dateTime_ = default(DateTime);
		while (true)
		{
			int num = 522435780;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7F3B3135u) % 9u)
				{
				case 7u:
					Registration.smethod_74(oleDbConnection_, Registration.smethod_73(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
					num = (int)(num2 * 1676594970) ^ -2061038177;
					continue;
				case 6u:
					Registration.smethod_76(oleDbConnection_);
					num = (int)(num2 * 1996686886) ^ -793023970;
					continue;
				case 4u:
					num = ((int)num2 * -1066739686) ^ 0x63027914;
					continue;
				case 3u:
					flag = !Validate_data();
					num = (int)(num2 * 786205942) ^ -555689478;
					continue;
				case 1u:
					dateTime_ = Registration.smethod_69(Registration.smethod_68((object)Registration.smethod_75(DOBTxt), "dd-MM-yyyy"));
					num = 1351840568;
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1115080324;
						num5 = -1115080324;
					}
					else
					{
						num4 = -278834684;
						num5 = -278834684;
					}
					num = num4 ^ ((int)num2 * -1760456629);
					continue;
				}
				case 5u:
					break;
				default:
				{
					string string_ = "Insert Into [Patient] (Name,DOB,Gender,Mobile,Address) Values (?,?,?,?,?)";
					OleDbCommand val = Registration.smethod_77(string_, oleDbConnection_);
					try
					{
						while (true)
						{
							int num3 = 809326328;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x7F3B3135u) % 13u)
								{
								case 12u:
									Registration.smethod_44((Control)(object)SuccessMsg, Color.Green);
									num3 = ((int)num2 * -690060092) ^ -259434791;
									continue;
								case 11u:
									Registration.smethod_82(Registration.smethod_78(val), Registration.smethod_81("Gender", (object)Registration.smethod_80(Registration.smethod_84(GenderTxt))));
									num3 = ((int)num2 * -1511131118) ^ 0x693D8AD7;
									continue;
								case 10u:
									Registration.smethod_82(Registration.smethod_78(val), Registration.smethod_81("Mobile", (object)Registration.smethod_85(Registration.smethod_79(MobileTxt))));
									Registration.smethod_82(Registration.smethod_78(val), Registration.smethod_81("Address", (object)Registration.smethod_85(Registration.smethod_79(AddressTxt))));
									num3 = ((int)num2 * -1100293025) ^ 0x67EE6F8B;
									continue;
								case 9u:
									Registration.smethod_86(val);
									num3 = ((int)num2 * -2078503750) ^ 0x78ED5C3E;
									continue;
								case 8u:
									num3 = ((int)num2 * -1555767221) ^ 0x67DE60F0;
									continue;
								case 7u:
									Registration.smethod_82(Registration.smethod_78(val), Registration.smethod_81("Name", (object)Registration.smethod_80(Registration.smethod_79(NameTxt))));
									num3 = (int)((num2 * 769950692) ^ 0x68745F78);
									continue;
								case 6u:
									Registration.smethod_87((Component)(object)val);
									num3 = ((int)num2 * -1312902954) ^ -2054506195;
									continue;
								case 4u:
									Registration.smethod_20(SuccessMsg, "Patient Successfully Registered !!");
									num3 = (int)(num2 * 673413904) ^ -192609668;
									continue;
								case 3u:
									Registration.smethod_89(Timer1);
									num3 = (int)(num2 * 1500869006) ^ -2042988619;
									continue;
								case 2u:
									Registration.smethod_82(Registration.smethod_78(val), Registration.smethod_81("DOB", (object)Registration.smethod_83(dateTime_)));
									num3 = ((int)num2 * -803537028) ^ -2043042161;
									continue;
								case 1u:
									Registration.smethod_88(oleDbConnection_);
									Registration.smethod_46((Control)(object)SuccessMsg, bool_0: true);
									num3 = ((int)num2 * -1383600786) ^ -922305047;
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
					catch (Exception ex)
					{
						Registration.smethod_90(ex);
						Exception exception_ = ex;
						while (true)
						{
							_ = 1965370280;
							while (true)
							{
								_003F val2 = /*Error near IL_034c: Stack underflow*/^ 0x7F3B3135;
								num2 = (uint)(int)val2;
								switch (val2 % 9)
								{
								default:
									return;
								case 8:
									Registration.smethod_93();
									_ = (num2 * 1880723580) ^ 0x36BC603F;
									continue;
								case 7:
									_ = (num2 * 329177192) ^ 0xEEB01EB3u;
									continue;
								case 5:
									Registration.smethod_20(SuccessMsg, "Invalid Credentials");
									_ = (num2 * 937117831) ^ 0x37743AF1;
									continue;
								case 4:
									Registration.smethod_88(oleDbConnection_);
									_ = (num2 * 485995526) ^ 0x34D9D72;
									continue;
								case 3:
									Registration.smethod_46((Control)(object)SuccessMsg, bool_0: true);
									_ = (num2 * 403291492) ^ 0xAA6A02E4u;
									continue;
								case 2:
									Registration.smethod_44((Control)(object)SuccessMsg, Color.Red);
									Registration.smethod_89(Timer1);
									_ = (num2 * 42825919) ^ 0xD4026F87u;
									continue;
								case 1:
									Registration.smethod_92(Registration.smethod_91(exception_));
									_ = (num2 * 864302643) ^ 0x6C7B6A96;
									continue;
								case 0:
									break;
								case 6:
									return;
								}
								break;
							}
						}
					}
				}
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -285126034;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC1CAF069u) % 6u)
				{
				case 4u:
					num = (int)(num2 * 1315803100) ^ -646319666;
					continue;
				case 3u:
					num = ((int)num2 * -1537103213) ^ -1526881800;
					continue;
				case 2u:
					Registration.smethod_94(Timer1);
					num = (int)(num2 * 64323473) ^ -1168557717;
					continue;
				case 1u:
					Registration.smethod_46((Control)(object)SuccessMsg, bool_0: false);
					num = ((int)num2 * -837860793) ^ 0x7BD7D11F;
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

	private bool Validate_data()
	{
		bool result = default(bool);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1829634300;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFC2ECDABu) % 41u)
				{
				case 40u:
					result = false;
					num = (int)(num2 * 294524064) ^ -304338177;
					continue;
				case 39u:
					num = ((int)num2 * -1873984324) ^ -450898451;
					continue;
				case 38u:
					num = -1345860029;
					continue;
				case 37u:
					Registration.smethod_20(SuccessMsg, "Invalid Mobile Number");
					num = ((int)num2 * -1129421240) ^ -26652549;
					continue;
				case 36u:
					num = (int)(num2 * 828001271) ^ -1933376743;
					continue;
				case 35u:
					Registration.smethod_44((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -1386668896) ^ 0x654B41CD;
					continue;
				case 34u:
					result = false;
					num = (int)(num2 * 1350568291) ^ -1007085962;
					continue;
				case 33u:
				{
					int num5;
					int num6;
					if (flag3)
					{
						num5 = 330327218;
						num6 = 330327218;
					}
					else
					{
						num5 = 972156575;
						num6 = 972156575;
					}
					num = num5 ^ ((int)num2 * -1473247573);
					continue;
				}
				case 32u:
					Registration.smethod_46((Control)(object)SuccessMsg, bool_0: true);
					num = (int)(num2 * 246167461) ^ -433218511;
					continue;
				case 31u:
					Registration.smethod_46((Control)(object)SuccessMsg, bool_0: true);
					num = (int)(num2 * 1534987530) ^ -71563498;
					continue;
				case 30u:
				{
					int num9;
					int num10;
					if (!flag4)
					{
						num9 = 1452420919;
						num10 = 1452420919;
					}
					else
					{
						num9 = 1290423491;
						num10 = 1290423491;
					}
					num = num9 ^ ((int)num2 * -1665521975);
					continue;
				}
				case 29u:
					Registration.smethod_44((Control)(object)SuccessMsg, Color.Red);
					Registration.smethod_89(Timer1);
					num = (int)((num2 * 655815288) ^ 0x5FF8B71D);
					continue;
				case 28u:
					result = false;
					num = (int)((num2 * 1391535607) ^ 0x4D7F0657);
					continue;
				case 27u:
					Registration.smethod_46((Control)(object)SuccessMsg, bool_0: true);
					num = (int)(num2 * 1579763543) ^ -63199440;
					continue;
				case 26u:
					Registration.smethod_46((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -645369866) ^ 0x724E96A7;
					continue;
				case 25u:
					num = -1824994582;
					continue;
				case 24u:
					num = ((int)num2 * -635906273) ^ 0x59700C47;
					continue;
				case 23u:
					flag4 = !MyProject.Forms.Form1.Gender_Validator(Registration.smethod_80(Registration.smethod_84(GenderTxt)));
					num = -769633402;
					continue;
				case 21u:
					Registration.smethod_20(SuccessMsg, "Enter Address");
					num = (int)((num2 * 32474500) ^ 0x6851D91D);
					continue;
				case 20u:
					Registration.smethod_44((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -1829593224) ^ 0x365EB78;
					continue;
				case 18u:
					flag3 = Registration.smethod_95(Registration.smethod_79(AddressTxt), "", bool_0: false) == 0;
					num = ((int)num2 * -1001571481) ^ -1398243262;
					continue;
				case 17u:
					num = (int)(num2 * 94922194) ^ -1306934634;
					continue;
				case 16u:
					Registration.smethod_89(Timer1);
					num = (int)(num2 * 1333626107) ^ -1915316525;
					continue;
				case 15u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = -1826698726;
						num8 = -1826698726;
					}
					else
					{
						num7 = -697005753;
						num8 = -697005753;
					}
					num = num7 ^ (int)(num2 * 1421988478);
					continue;
				}
				case 14u:
					Registration.smethod_89(Timer1);
					num = ((int)num2 * -601516651) ^ 0x73B8B777;
					continue;
				case 13u:
				{
					int num3;
					int num4;
					if (!flag2)
					{
						num3 = -1780523378;
						num4 = -1780523378;
					}
					else
					{
						num3 = -1245869951;
						num4 = -1245869951;
					}
					num = num3 ^ (int)(num2 * 973524745);
					continue;
				}
				case 12u:
					flag2 = !MyProject.Forms.Form1.Name_Validation(Registration.smethod_80(Registration.smethod_79(NameTxt)));
					num = ((int)num2 * -1131731559) ^ 0x762CC8D1;
					continue;
				case 11u:
					result = true;
					num = ((int)num2 * -528302192) ^ -1149521861;
					continue;
				case 10u:
					Registration.smethod_44((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -1913385963) ^ -1643156027;
					continue;
				case 9u:
					num = (int)((num2 * 902980810) ^ 0xFDCF999);
					continue;
				case 8u:
					num = ((int)num2 * -980175775) ^ -994329687;
					continue;
				case 7u:
					num = -397101277;
					continue;
				case 6u:
					result = false;
					num = ((int)num2 * -1918449986) ^ -1385158603;
					continue;
				case 5u:
					Registration.smethod_89(Timer1);
					num = (int)((num2 * 1202981665) ^ 0x532059AB);
					continue;
				case 4u:
					num = (int)(num2 * 1272782375) ^ -1865128503;
					continue;
				case 3u:
					flag = !MyProject.Forms.Form1.Mobile_Validator(Registration.smethod_79(MobileTxt));
					num = (int)((num2 * 206212841) ^ 0x240AFFC0);
					continue;
				case 2u:
					num = ((int)num2 * -285479900) ^ -392009549;
					continue;
				case 1u:
					Registration.smethod_20(SuccessMsg, "Invalid Name");
					num = ((int)num2 * -1627337396) ^ -114607704;
					continue;
				case 0u:
					Registration.smethod_20(SuccessMsg, "Invalid Gender");
					num = ((int)num2 * -389271417) ^ -1351018061;
					continue;
				case 22u:
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
