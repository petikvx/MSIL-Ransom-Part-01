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
				int num = -1484005724;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC0E7FD75u) % 8u)
					{
					case 7u:
					{
						int num5;
						int num6;
						if (registerBtn != null)
						{
							num5 = 1477369494;
							num6 = 1477369494;
						}
						else
						{
							num5 = 1601306810;
							num6 = 1601306810;
						}
						num = num5 ^ ((int)num2 * -1565176727);
						continue;
					}
					case 6u:
					{
						int num3;
						int num4;
						if (registerBtn != null)
						{
							num3 = 534451490;
							num4 = 534451490;
						}
						else
						{
							num3 = 626850692;
							num4 = 626850692;
						}
						num = num3 ^ (int)(num2 * 540211730);
						continue;
					}
					case 4u:
						Registration.smethod_61((Control)(object)registerBtn, eventHandler_);
						num = ((int)num2 * -688304671) ^ 0x1D223BD9;
						continue;
					case 3u:
						Registration.smethod_62((Control)(object)registerBtn, eventHandler_);
						num = ((int)num2 * -1477055958) ^ -482488010;
						continue;
					case 1u:
						registerBtn = _RegisterBtn;
						num = (int)((num2 * 1700421192) ^ 0x385ED0F2);
						continue;
					case 0u:
						_RegisterBtn = value;
						registerBtn = _RegisterBtn;
						num = -1285776037;
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
				int num = -248165481;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBEAC8598u) % 8u)
					{
					case 7u:
					{
						int num5;
						int num6;
						if (clearBtn == null)
						{
							num5 = 1592608630;
							num6 = 1592608630;
						}
						else
						{
							num5 = 873538098;
							num6 = 873538098;
						}
						num = num5 ^ (int)(num2 * 655251882);
						continue;
					}
					case 5u:
						clearBtn = _ClearBtn;
						num = (int)((num2 * 738525945) ^ 0x7745E66F);
						continue;
					case 4u:
						Registration.smethod_61((Control)(object)clearBtn, eventHandler_);
						num = (int)((num2 * 1963946346) ^ 0x6AD5DB98);
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (clearBtn == null)
						{
							num3 = -959390610;
							num4 = -959390610;
						}
						else
						{
							num3 = -423437519;
							num4 = -423437519;
						}
						num = num3 ^ (int)(num2 * 1339557172);
						continue;
					}
					case 1u:
						Registration.smethod_62((Control)(object)clearBtn, eventHandler_);
						num = (int)(num2 * 1712425311) ^ -206731367;
						continue;
					case 0u:
						_ClearBtn = value;
						num = -812992811;
						continue;
					default:
						return;
					case 3u:
						break;
					case 6u:
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
			if (genderTxt != null)
			{
				goto IL_0082;
			}
			goto IL_00b4;
			IL_00b4:
			_GenderTxt = value;
			int num = 1467225425;
			goto IL_0087;
			IL_0087:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x75A2B5D6u) % 7u)
				{
				case 6u:
					Registration.smethod_64(genderTxt, eventHandler_);
					num = (int)(num2 * 107911751) ^ -1776654014;
					continue;
				case 5u:
					genderTxt = _GenderTxt;
					num = (int)(num2 * 1052979643) ^ -1534263584;
					continue;
				case 3u:
					Registration.smethod_63(genderTxt, eventHandler_);
					num = ((int)num2 * -2061069858) ^ -1757864334;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (genderTxt != null)
					{
						num3 = 1208734419;
						num4 = 1208734419;
					}
					else
					{
						num3 = 238260561;
						num4 = 238260561;
					}
					num = num3 ^ ((int)num2 * -1558718686);
					continue;
				}
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_00b4;
				case 4u:
					return;
				}
				break;
			}
			goto IL_0082;
			IL_0082:
			num = 1096776103;
			goto IL_0087;
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
				int num = -994925404;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE037A0D2u) % 9u)
					{
					case 7u:
						timer = _Timer1;
						num = ((int)num2 * -1065480601) ^ 0xF29A46;
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (timer != null)
						{
							num5 = -1521443886;
							num6 = -1521443886;
						}
						else
						{
							num5 = -1216379209;
							num6 = -1216379209;
						}
						num = num5 ^ ((int)num2 * -1707553606);
						continue;
					}
					case 5u:
						Registration.smethod_66(timer, eventHandler_);
						num = ((int)num2 * -2034092666) ^ -412318694;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (timer == null)
						{
							num3 = -43818274;
							num4 = -43818274;
						}
						else
						{
							num3 = -515420600;
							num4 = -515420600;
						}
						num = num3 ^ ((int)num2 * -1517046476);
						continue;
					}
					case 3u:
						timer = _Timer1;
						num = (int)(num2 * 316905107) ^ -1809338685;
						continue;
					case 1u:
						Registration.smethod_65(timer, eventHandler_);
						num = ((int)num2 * -1793903685) ^ 0x740F3703;
						continue;
					case 0u:
						_Timer1 = value;
						num = -256266968;
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
				int num = 643631644;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0x706C40FEu) % 7u)
					{
					case 6u:
						if (disposing)
						{
							num = (int)(num2 * 165645917) ^ -516272353;
							continue;
						}
						num5 = 0;
						goto IL_001a;
					case 5u:
						num5 = ((components != null) ? 1 : 0);
						goto IL_001a;
					case 4u:
						num = (int)((num2 * 2034349600) ^ 0x2A757DEB);
						continue;
					case 1u:
						Registration.smethod_1((IDisposable)components);
						num = ((int)num2 * -1933661418) ^ -1315160992;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -770602849;
							num4 = -770602849;
						}
						else
						{
							num3 = -1509593179;
							num4 = -1509593179;
						}
						num = num3 ^ ((int)num2 * -1866073926);
						continue;
					}
					default:
						return;
					case 3u:
						break;
					case 2u:
						return;
						IL_001a:
						flag = (byte)num5 != 0;
						num = 1512791917;
						continue;
					}
					break;
				}
			}
		}
		finally
		{
			((ContainerControl)this).Dispose(disposing);
			while (true)
			{
				IL_00e1:
				int num6 = 1297050743;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num6 ^ 0x706C40FEu) % 3u)
					{
					case 1u:
						goto IL_00b7;
					default:
						goto end_IL_00c4;
					case 0u:
						break;
					case 2u:
						goto end_IL_00c4;
					}
					goto IL_00e1;
					IL_00b7:
					num6 = ((int)num2 * -1695120151) ^ -289640598;
					continue;
					end_IL_00c4:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		components = Registration.smethod_2();
		while (true)
		{
			int num = -17091736;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD3FBA135u) % 213u)
				{
				case 212u:
					Registration.smethod_15((Control)(object)Label3, Registration.smethod_14("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 776144115) ^ 0x70C12215);
					continue;
				case 211u:
					num = (int)((num2 * 1189637384) ^ 0x3CA2D886);
					continue;
				case 210u:
					num = ((int)num2 * -1323189552) ^ 0x9E281CA;
					continue;
				case 209u:
					Registration.smethod_20(Label5, "Mobile :");
					num = (int)((num2 * 409471204) ^ 0x347F24FD);
					continue;
				case 208u:
					Registration.smethod_17((Control)(object)Label2, "Label2");
					num = (int)(num2 * 1996452773) ^ -714788258;
					continue;
				case 207u:
					Registration.smethod_18((Control)(object)Label6, new Size(87, 26));
					num = ((int)num2 * -2098423881) ^ -510335552;
					continue;
				case 206u:
					Registration.smethod_18((Control)(object)RegisterBtn, new Size(147, 47));
					num = (int)((num2 * 209919273) ^ 0x655A9286);
					continue;
				case 205u:
					num = (int)(num2 * 812772462) ^ -1541501887;
					continue;
				case 204u:
					Registration.smethod_18((Control)(object)Label2, new Size(87, 23));
					num = ((int)num2 * -1894811641) ^ -754613126;
					continue;
				case 203u:
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)Label5);
					num = (int)(num2 * 1427661899) ^ -957457722;
					continue;
				case 202u:
					num = ((int)num2 * -1308533139) ^ -1778685754;
					continue;
				case 201u:
					Registration.smethod_23(Registration.smethod_54((Control)(object)this), (Control)(object)RegisterBtn);
					Registration.smethod_23(Registration.smethod_54((Control)(object)this), (Control)(object)GroupBox2);
					Registration.smethod_23(Registration.smethod_54((Control)(object)this), (Control)(object)PictureBox1);
					num = ((int)num2 * -337893074) ^ 0x11542965;
					continue;
				case 200u:
					num = ((int)num2 * -1026565384) ^ -177173113;
					continue;
				case 199u:
					Registration.smethod_49(PictureBox1, (PictureBoxSizeMode)1);
					num = (int)((num2 * 1839229460) ^ 0x15F0E74A);
					continue;
				case 198u:
					RegisterBtn = Registration.smethod_8();
					num = (int)((num2 * 1800588219) ^ 0x2CF9D9F0);
					continue;
				case 197u:
					Registration.smethod_16((Control)(object)GenderTxt, new Point(108, 151));
					num = ((int)num2 * -721826658) ^ -1766061126;
					continue;
				case 196u:
					Registration.smethod_13((Control)(object)this);
					num = ((int)num2 * -950923986) ^ 0x73B193D0;
					continue;
				case 195u:
					Registration.smethod_42((ButtonBase)(object)ClearBtn, "Clear");
					num = (int)((num2 * 679199981) ^ 0x4F7FAAB6);
					continue;
				case 194u:
					num = (int)(num2 * 1677557214) ^ -1538439373;
					continue;
				case 193u:
					MobileTxt = Registration.smethod_6();
					num = (int)(num2 * 1962504310) ^ -58883170;
					continue;
				case 192u:
					Registration.smethod_53((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 1051026942) ^ -1630254031;
					continue;
				case 191u:
					Registration.smethod_20(SuccessMsg, "Patient Successfully registered");
					Registration.smethod_21(SuccessMsg, (ContentAlignment)32);
					num = ((int)num2 * -977216205) ^ -1469592671;
					continue;
				case 190u:
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)NameTxt);
					num = (int)((num2 * 204746539) ^ 0x468ABBC0);
					continue;
				case 189u:
					num = ((int)num2 * -1587064049) ^ 0x60BC556D;
					continue;
				case 187u:
					Label2 = Registration.smethod_3();
					num = ((int)num2 * -2136074076) ^ -935496120;
					continue;
				case 186u:
					num = (int)((num2 * 1318175890) ^ 0x1C39AEFE);
					continue;
				case 185u:
					Registration.smethod_15((Control)(object)MobileTxt, Registration.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1214477668) ^ 0x7288948E;
					continue;
				case 184u:
					num = (int)(num2 * 928832169) ^ -1860548666;
					continue;
				case 183u:
					num = (int)(num2 * 1030660357) ^ -1525049136;
					continue;
				case 182u:
					Registration.smethod_18((Control)(object)DOBTxt, new Size(178, 29));
					Registration.smethod_19((Control)(object)DOBTxt, 14);
					num = (int)(num2 * 782591255) ^ -2033599415;
					continue;
				case 181u:
					Registration.smethod_56((Control)(object)this, new Size(977, 804));
					num = (int)((num2 * 1670572202) ^ 0x3288D0D);
					continue;
				case 180u:
					Registration.smethod_17((Control)(object)SuccessMsg, "SuccessMsg");
					num = (int)(num2 * 529963659) ^ -1960545693;
					continue;
				case 179u:
					Registration.smethod_48(PictureBox1, (Image)(object)Resources.patient_pic);
					num = (int)(num2 * 2085940826) ^ -1367307160;
					continue;
				case 178u:
					num = (int)((num2 * 1250472571) ^ 0x358D9AE3);
					continue;
				case 177u:
					Registration.smethod_15((Control)(object)SuccessMsg, Registration.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -815369704) ^ -692958999;
					continue;
				case 176u:
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)Label6);
					num = (int)((num2 * 485337756) ^ 0x61CD9A2);
					continue;
				case 175u:
					num = (int)((num2 * 1038460245) ^ 0x33C5541A);
					continue;
				case 174u:
					Registration.smethod_41((Control)(object)RegisterBtn, Color.White);
					num = (int)((num2 * 1804369548) ^ 0x39954D16);
					continue;
				case 173u:
					Registration.smethod_15((Control)(object)Label1, Registration.smethod_14("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1149264616) ^ -1619781423;
					continue;
				case 172u:
					num = (int)(num2 * 914718924) ^ -1255623781;
					continue;
				case 171u:
					num = (int)((num2 * 1509796783) ^ 0x162D658);
					continue;
				case 170u:
					Registration.smethod_17((Control)(object)AddressTxt, "AddressTxt");
					num = (int)(num2 * 2071240659) ^ -1006218600;
					continue;
				case 169u:
					Registration.smethod_17((Control)(object)GroupBox2, "GroupBox2");
					num = (int)((num2 * 2014138109) ^ 0x15A7777F);
					continue;
				case 168u:
					Registration.smethod_18((Control)(object)ClearBtn, new Size(146, 47));
					num = ((int)num2 * -69120261) ^ -1691815792;
					continue;
				case 167u:
					Registration.smethod_19((Control)(object)SuccessMsg, 6);
					num = (int)((num2 * 2088275680) ^ 0x46309136);
					continue;
				case 166u:
					num = ((int)num2 * -10374438) ^ -887528186;
					continue;
				case 164u:
					num = (int)(num2 * 1598000960) ^ -817994907;
					continue;
				case 163u:
					Registration.smethod_16((Control)(object)RegisterBtn, new Point(600, 661));
					num = ((int)num2 * -1605203657) ^ 0x5D4E6540;
					continue;
				case 162u:
					Registration.smethod_16((Control)(object)Label3, new Point(15, 151));
					num = (int)(num2 * 1352807523) ^ -1612224592;
					continue;
				case 161u:
					Registration.smethod_17((Control)(object)MobileTxt, "MobileTxt");
					num = (int)(num2 * 2056417054) ^ -414881162;
					continue;
				case 160u:
					Registration.smethod_19((Control)(object)Label5, 8);
					num = (int)(num2 * 277870596) ^ -277677306;
					continue;
				case 159u:
					num = (int)((num2 * 1298070030) ^ 0x78A77005);
					continue;
				case 158u:
					GroupBox2 = Registration.smethod_4();
					DOBTxt = Registration.smethod_5();
					num = (int)(num2 * 1525148298) ^ -1448409376;
					continue;
				case 157u:
					Registration.smethod_47(Timer1, 1500);
					num = (int)((num2 * 804753456) ^ 0x66CE6359);
					continue;
				case 156u:
					num = (int)(num2 * 165766894) ^ -2106612728;
					continue;
				case 155u:
					Registration.smethod_17((Control)(object)NameTxt, "NameTxt");
					num = ((int)num2 * -396127407) ^ 0x5636B165;
					continue;
				case 154u:
					Registration.smethod_18((Control)(object)Label1, new Size(372, 47));
					num = (int)((num2 * 1250135189) ^ 0x405198EA);
					continue;
				case 153u:
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)MobileTxt);
					num = ((int)num2 * -436397223) ^ 0x1013E456;
					continue;
				case 152u:
					Registration.smethod_33(Registration.smethod_32(GenderTxt), new string[3] { "Male", "Female", "Others" });
					Registration.smethod_34(GenderTxt, (AutoCompleteMode)2);
					num = (int)(num2 * 1249887775) ^ -1970485494;
					continue;
				case 151u:
					num = ((int)num2 * -1699153601) ^ 0x5B41D20A;
					continue;
				case 150u:
					Registration.smethod_39(Registration.smethod_38(GenderTxt), new object[3] { "Male", "Female", "Others" });
					num = (int)(num2 * 517527807) ^ -1603353327;
					continue;
				case 149u:
					num = ((int)num2 * -1139251703) ^ 0x56F7BF14;
					continue;
				case 148u:
					num = (int)(num2 * 469255529) ^ -936304178;
					continue;
				case 147u:
					Registration.smethod_44((Control)(object)SuccessMsg, Color.Olive);
					num = (int)(num2 * 1300471403) ^ -1009880620;
					continue;
				case 146u:
					num = (int)((num2 * 1004242993) ^ 0x10ABEF99);
					continue;
				case 145u:
					Registration.smethod_16((Control)(object)ClearBtn, new Point(261, 661));
					num = ((int)num2 * -1437382928) ^ -769387506;
					continue;
				case 144u:
					Registration.smethod_19((Control)(object)Label2, 5);
					num = ((int)num2 * -1856312920) ^ 0x77AB92B6;
					continue;
				case 143u:
					num = ((int)num2 * -1928837255) ^ -600533288;
					continue;
				case 142u:
					Registration.smethod_30(DOBTxt, new DateTime(2019, 2, 11, 0, 0, 0, 0));
					num = ((int)num2 * -1774375301) ^ 0x1468DAFF;
					continue;
				case 141u:
					Registration.smethod_18((Control)(object)PictureBox1, new Size(126, 122));
					num = ((int)num2 * -1651253608) ^ 0x607B6CDD;
					continue;
				case 140u:
					Registration.smethod_21(Label2, (ContentAlignment)32);
					num = (int)((num2 * 777783622) ^ 0x57A5FE52);
					continue;
				case 139u:
					Registration.smethod_15((Control)(object)ClearBtn, Registration.smethod_14("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1898353867) ^ 0x1538E544);
					continue;
				case 138u:
					num = (int)((num2 * 95960980) ^ 0x6462A35E);
					continue;
				case 137u:
					num = (int)(num2 * 1758244510) ^ -1145504487;
					continue;
				case 136u:
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)Label4);
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)Label3);
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)Label2);
					num = ((int)num2 * -1400715339) ^ 0x7DF979F6;
					continue;
				case 135u:
					Registration.smethod_20(Label1, "Patient Registration");
					num = ((int)num2 * -1899531668) ^ 0x5181CB68;
					continue;
				case 134u:
					Registration.smethod_41((Control)(object)SuccessMsg, Registration.smethod_45());
					num = ((int)num2 * -79656) ^ 0x479CFD1B;
					continue;
				case 133u:
					num = (int)(num2 * 2012656984) ^ -970682295;
					continue;
				case 132u:
					Registration.smethod_18((Control)(object)GenderTxt, new Size(112, 27));
					num = ((int)num2 * -1734094780) ^ -2122409760;
					continue;
				case 131u:
					num = ((int)num2 * -2075961367) ^ 0x1F5290B7;
					continue;
				case 130u:
					Registration.smethod_16((Control)(object)GroupBox2, new Point(261, 235));
					num = ((int)num2 * -1111261455) ^ 0x7C9CF85;
					continue;
				case 129u:
					num = (int)(num2 * 631289699) ^ -409252879;
					continue;
				case 128u:
					Registration.smethod_23(Registration.smethod_54((Control)(object)this), (Control)(object)Label1);
					num = ((int)num2 * -1040119932) ^ -1333759175;
					continue;
				case 127u:
					Label5 = Registration.smethod_3();
					num = (int)((num2 * 149196167) ^ 0x316C5330);
					continue;
				case 126u:
					NameTxt = Registration.smethod_6();
					num = ((int)num2 * -238232377) ^ 0x6757535E;
					continue;
				case 125u:
					Registration.smethod_16((Control)(object)DOBTxt, new Point(108, 110));
					Registration.smethod_28(DOBTxt, new DateTime(2019, 2, 11, 0, 0, 0, 0));
					num = (int)((num2 * 1135518557) ^ 0x241567F9);
					continue;
				case 124u:
					Registration.smethod_20(Label4, "DOB :");
					Registration.smethod_21(Label4, (ContentAlignment)32);
					num = (int)(num2 * 548796675) ^ -1835078944;
					continue;
				case 123u:
					Registration.smethod_16((Control)(object)Label5, new Point(6, 203));
					num = ((int)num2 * -318100697) ^ 0x6EC65728;
					continue;
				case 122u:
					Registration.smethod_24(GroupBox2, bool_0: false);
					num = ((int)num2 * -1404813377) ^ 0x5E00AD42;
					continue;
				case 121u:
					Registration.smethod_16((Control)(object)NameTxt, new Point(108, 55));
					num = (int)(num2 * 1391240836) ^ -168286536;
					continue;
				case 120u:
					num = (int)(num2 * 531751453) ^ -992251876;
					continue;
				case 119u:
					Registration.smethod_16((Control)(object)Label1, new Point(392, 60));
					num = ((int)num2 * -484149569) ^ 0x5774AE1;
					continue;
				case 118u:
					Registration.smethod_17((Control)(object)DOBTxt, "DOBTxt");
					num = ((int)num2 * -711181041) ^ 0x6D38C1C3;
					continue;
				case 117u:
					Registration.smethod_15((Control)(object)Label5, Registration.smethod_14("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 506221383) ^ 0x28DF9CF7);
					continue;
				case 116u:
					Registration.smethod_15((Control)(object)AddressTxt, Registration.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -462549252) ^ -1081559336;
					continue;
				case 115u:
					num = (int)((num2 * 1196843143) ^ 0x2ED078BD);
					continue;
				case 114u:
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)DOBTxt);
					num = (int)((num2 * 1134934724) ^ 0x219074E);
					continue;
				case 113u:
					num = ((int)num2 * -2058878453) ^ 0x3241D707;
					continue;
				case 112u:
					Registration.smethod_55((Control)(object)this, "Registration");
					num = (int)((num2 * 1289470064) ^ 0x7849F146);
					continue;
				case 111u:
					Registration.smethod_18((Control)(object)AddressTxt, new Size(316, 91));
					Registration.smethod_19((Control)(object)AddressTxt, 13);
					num = (int)((num2 * 614208534) ^ 0x5FA7BADD);
					continue;
				case 110u:
					Registration.smethod_21(Label3, (ContentAlignment)32);
					num = (int)((num2 * 1271494237) ^ 0x7839DDC0);
					continue;
				case 109u:
					Registration.smethod_50(PictureBox1, 1);
					num = (int)(num2 * 135496549) ^ -302190592;
					continue;
				case 108u:
					Registration.smethod_21(Label5, (ContentAlignment)32);
					Registration.smethod_15((Control)(object)Label4, Registration.smethod_14("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Registration.smethod_16((Control)(object)Label4, new Point(15, 110));
					num = ((int)num2 * -1267608906) ^ 0x6747EB20;
					continue;
				case 107u:
					Registration.smethod_41((Control)(object)ClearBtn, Color.White);
					num = ((int)num2 * -405363807) ^ -1158165366;
					continue;
				case 106u:
					num = ((int)num2 * -1230369552) ^ 0x77FD5188;
					continue;
				case 105u:
					Registration.smethod_16((Control)(object)SuccessMsg, new Point(305, 156));
					num = ((int)num2 * -1810899327) ^ -128719788;
					continue;
				case 104u:
					GenderTxt = Registration.smethod_7();
					num = (int)((num2 * 909288045) ^ 0x7E2BE75A);
					continue;
				case 103u:
					num = ((int)num2 * -1101168446) ^ 0x377BC764;
					continue;
				case 102u:
					Registration.smethod_37((ListControl)(object)GenderTxt, bool_0: true);
					num = ((int)num2 * -1020406189) ^ 0x479C846B;
					continue;
				case 101u:
					AddressTxt = Registration.smethod_6();
					num = (int)(num2 * 1708545800) ^ -329594013;
					continue;
				case 100u:
					Registration.smethod_18((Control)(object)Label4, new Size(60, 24));
					num = ((int)num2 * -1396881225) ^ -1555651567;
					continue;
				case 99u:
					num = (int)(num2 * 188599755) ^ -1096636124;
					continue;
				case 98u:
					Label4 = Registration.smethod_3();
					num = (int)(num2 * 786254270) ^ -1605556927;
					continue;
				case 97u:
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)AddressTxt);
					num = (int)((num2 * 350913205) ^ 0x43A6DDA5);
					continue;
				case 96u:
					Registration.smethod_19((Control)(object)Label4, 7);
					num = ((int)num2 * -333633291) ^ 0x6F55A86C;
					continue;
				case 95u:
					Registration.smethod_60((Control)(object)this, bool_0: false);
					num = ((int)num2 * -831194336) ^ -1308631995;
					continue;
				case 94u:
					Registration.smethod_18((Control)(object)Label5, new Size(94, 29));
					num = (int)(num2 * 1224261612) ^ -1510147634;
					continue;
				case 93u:
					num = ((int)num2 * -1018924602) ^ -6967980;
					continue;
				case 92u:
					Registration.smethod_42((ButtonBase)(object)RegisterBtn, "Register");
					num = (int)(num2 * 1719960944) ^ -1618875690;
					continue;
				case 91u:
					Registration.smethod_27(DOBTxt, (DateTimePickerFormat)2);
					num = (int)(num2 * 1121907611) ^ -366413029;
					continue;
				case 90u:
					SuccessMsg = Registration.smethod_3();
					num = ((int)num2 * -1852928828) ^ 0x3A0D8E1;
					continue;
				case 89u:
					num = (int)((num2 * 2071852892) ^ 0x39D98B8C);
					continue;
				case 88u:
					Registration.smethod_23(Registration.smethod_54((Control)(object)this), (Control)(object)ClearBtn);
					num = ((int)num2 * -1987162416) ^ -1607254229;
					continue;
				case 87u:
					Registration.smethod_17((Control)(object)Label6, "Label6");
					num = (int)(num2 * 1624770395) ^ -1277242555;
					continue;
				case 86u:
					Registration.smethod_16((Control)(object)AddressTxt, new Point(110, 256));
					num = (int)(num2 * 2002218767) ^ -265764706;
					continue;
				case 85u:
					num = ((int)num2 * -69752375) ^ 0x58C88FE2;
					continue;
				case 84u:
					Registration.smethod_17((Control)(object)Label4, "Label4");
					num = ((int)num2 * -702851159) ^ 0x56D54962;
					continue;
				case 83u:
					Registration.smethod_18((Control)(object)Label3, new Size(82, 31));
					Registration.smethod_19((Control)(object)Label3, 6);
					num = ((int)num2 * -1234252718) ^ 0xE98E111;
					continue;
				case 82u:
					Registration.smethod_17((Control)(object)ClearBtn, "ClearBtn");
					num = (int)((num2 * 49050783) ^ 0x60602593);
					continue;
				case 81u:
					Registration.smethod_20(Label3, "Gender :");
					num = (int)((num2 * 1959677449) ^ 0x303F55A2);
					continue;
				case 80u:
					num = (int)((num2 * 240805561) ^ 0x2945ABD2);
					continue;
				case 79u:
					Registration.smethod_15((Control)(object)Label2, Registration.smethod_14("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -50566828) ^ -552364946;
					continue;
				case 78u:
					Registration.smethod_20(Label2, "Name :");
					num = (int)(num2 * 339254431) ^ -11108276;
					continue;
				case 77u:
					num = (int)(num2 * 2014981149) ^ -1090642288;
					continue;
				case 76u:
					Registration.smethod_36(GenderTxt, (ComboBoxStyle)2);
					num = ((int)num2 * -1354687726) ^ -103153399;
					continue;
				case 75u:
					ClearBtn = Registration.smethod_8();
					num = (int)(num2 * 224700801) ^ -543377924;
					continue;
				case 74u:
					Registration.smethod_43((ButtonBase)(object)ClearBtn, bool_0: false);
					num = (int)((num2 * 1035301521) ^ 0x6A762610);
					continue;
				case 73u:
					num = ((int)num2 * -1100198394) ^ 0x41962487;
					continue;
				case 72u:
					num = (int)(num2 * 928822606) ^ -1511648915;
					continue;
				case 71u:
					num = (int)((num2 * 872437533) ^ 0x51215FFE);
					continue;
				case 70u:
					Registration.smethod_15((Control)(object)NameTxt, Registration.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1049788277) ^ 0x562D7795);
					continue;
				case 69u:
					num = (int)((num2 * 27136361) ^ 0x3AE48670);
					continue;
				case 68u:
					num = (int)(num2 * 1254896274) ^ -1040713639;
					continue;
				case 67u:
					Registration.smethod_19((Control)(object)NameTxt, 0);
					num = ((int)num2 * -1760668864) ^ -1600736511;
					continue;
				case 66u:
					Registration.smethod_19((Control)(object)Label6, 9);
					Registration.smethod_20(Label6, "Address :");
					num = (int)((num2 * 1032330811) ^ 0x1630AF01);
					continue;
				case 65u:
					Registration.smethod_18((Control)(object)SuccessMsg, new Size(401, 44));
					num = ((int)num2 * -1757596238) ^ -1598179011;
					continue;
				case 64u:
					Registration.smethod_59((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -72453564) ^ 0x537B62F7;
					continue;
				case 63u:
					num = (int)(num2 * 1116169378) ^ -1261010672;
					continue;
				case 62u:
					Registration.smethod_15((Control)(object)Label6, Registration.smethod_14("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Registration.smethod_16((Control)(object)Label6, new Point(17, 255));
					num = ((int)num2 * -633298306) ^ -78210010;
					continue;
				case 61u:
					num = (int)((num2 * 1626989419) ^ 0x2BAAE64B);
					continue;
				case 60u:
					Registration.smethod_18((Control)(object)NameTxt, new Size(318, 26));
					num = (int)((num2 * 1227779728) ^ 0x32A9065F);
					continue;
				case 59u:
					Registration.smethod_23(Registration.smethod_22((Control)(object)GroupBox2), (Control)(object)GenderTxt);
					num = ((int)num2 * -2017075577) ^ 0x54DDE282;
					continue;
				case 58u:
					Registration.smethod_18((Control)(object)MobileTxt, new Size(201, 26));
					Registration.smethod_19((Control)(object)MobileTxt, 12);
					num = ((int)num2 * -76907203) ^ 0x77AE8EF8;
					continue;
				case 57u:
					Registration.smethod_19((Control)(object)GenderTxt, 11);
					num = ((int)num2 * -1801046274) ^ 0x2DD60443;
					continue;
				case 56u:
					Registration.smethod_19((Control)(object)Label1, 0);
					num = ((int)num2 * -1891483893) ^ -354627770;
					continue;
				case 55u:
					Registration.smethod_17((Control)(object)GenderTxt, "GenderTxt");
					num = (int)((num2 * 597663170) ^ 0x386276D2);
					continue;
				case 54u:
					num = (int)((num2 * 1662384945) ^ 0x64D83496);
					continue;
				case 53u:
					num = (int)(num2 * 46392952) ^ -1693202472;
					continue;
				case 52u:
					Registration.smethod_19((Control)(object)RegisterBtn, 4);
					num = (int)(num2 * 203561926) ^ -477579235;
					continue;
				case 51u:
					Registration.smethod_57((Control)(object)GroupBox2, bool_0: false);
					num = (int)(num2 * 2009252656) ^ -711396207;
					continue;
				case 50u:
					Registration.smethod_17((Control)(object)Label3, "Label3");
					num = (int)((num2 * 180826791) ^ 0x3E806132);
					continue;
				case 49u:
					num = (int)((num2 * 1173548792) ^ 0x4AC4F030);
					continue;
				case 48u:
					Label3 = Registration.smethod_3();
					num = (int)(num2 * 374086196) ^ -188560608;
					continue;
				case 47u:
					Registration.smethod_26(DOBTxt, "");
					num = (int)(num2 * 1866204453) ^ -1660377083;
					continue;
				case 46u:
					num = (int)(num2 * 1261554293) ^ -102002667;
					continue;
				case 45u:
					Registration.smethod_23(Registration.smethod_54((Control)(object)this), (Control)(object)SuccessMsg);
					num = (int)(num2 * 2101764920) ^ -1270196156;
					continue;
				case 44u:
					num = (int)((num2 * 925248632) ^ 0x1764574E);
					continue;
				case 43u:
					Registration.smethod_40((ButtonBase)(object)RegisterBtn, Color.MidnightBlue);
					num = (int)((num2 * 1937325641) ^ 0x3DCC1868);
					continue;
				case 42u:
					num = ((int)num2 * -384070280) ^ 0x79167F52;
					continue;
				case 41u:
					Registration.smethod_31(AddressTxt, bool_0: true);
					num = (int)(num2 * 111269264) ^ -1761819229;
					continue;
				case 40u:
					num = (int)((num2 * 1082266101) ^ 0x63E0C949);
					continue;
				case 39u:
					Registration.smethod_35(GenderTxt, (AutoCompleteSource)256);
					num = (int)((num2 * 1753652561) ^ 0x538F08A7);
					continue;
				case 38u:
					num = ((int)num2 * -2130168304) ^ -871205949;
					continue;
				case 37u:
					Registration.smethod_17((Control)(object)PictureBox1, "PictureBox1");
					num = ((int)num2 * -1264580875) ^ 0x2761A461;
					continue;
				case 36u:
					num = (int)((num2 * 1897753110) ^ 0x29BAECB2);
					continue;
				case 35u:
					Label1 = Registration.smethod_3();
					num = ((int)num2 * -572668795) ^ -859138520;
					continue;
				case 34u:
					PictureBox1 = Registration.smethod_10();
					num = ((int)num2 * -235299555) ^ 0xC259751;
					continue;
				case 33u:
					Registration.smethod_17((Control)(object)RegisterBtn, "RegisterBtn");
					num = (int)(num2 * 1585953726) ^ -548371646;
					continue;
				case 32u:
					Registration.smethod_43((ButtonBase)(object)RegisterBtn, bool_0: false);
					Registration.smethod_40((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					num = ((int)num2 * -999607680) ^ -1013596149;
					continue;
				case 31u:
					Registration.smethod_16((Control)(object)Label2, new Point(8, 55));
					num = (int)((num2 * 800518222) ^ 0x3C4BE5AF);
					continue;
				case 30u:
					Registration.smethod_15((Control)(object)GroupBox2, Registration.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 747363555) ^ -914038875;
					continue;
				case 29u:
					Registration.smethod_29(DOBTxt, new DateTime(1900, 1, 1, 0, 0, 0, 0));
					num = ((int)num2 * -319928024) ^ 0x69FC16C9;
					continue;
				case 28u:
					Registration.smethod_25(GroupBox2, "Patient's Information");
					num = (int)(num2 * 1871078721) ^ -1794883589;
					continue;
				case 27u:
					Registration.smethod_19((Control)(object)ClearBtn, 5);
					num = ((int)num2 * -2106471512) ^ 0x66980C57;
					continue;
				case 26u:
					Registration.smethod_15((Control)(object)RegisterBtn, Registration.smethod_14("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1075765698) ^ -209326588;
					continue;
				case 25u:
					num = (int)(num2 * 384897031) ^ -1477941030;
					continue;
				case 24u:
					Registration.smethod_58((Control)(object)GroupBox2);
					num = (int)(num2 * 1523243844) ^ -1438390387;
					continue;
				case 23u:
					num = (int)(num2 * 672665022) ^ -746084797;
					continue;
				case 22u:
					Registration.smethod_15((Control)(object)GenderTxt, Registration.smethod_14("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -10367109) ^ -1064579466;
					continue;
				case 21u:
					Registration.smethod_21(Label6, (ContentAlignment)32);
					num = ((int)num2 * -831660922) ^ -313425532;
					continue;
				case 20u:
					num = (int)(num2 * 499720032) ^ -570068079;
					continue;
				case 19u:
					Registration.smethod_17((Control)(object)Label1, "Label1");
					num = ((int)num2 * -971916165) ^ -1663509175;
					continue;
				case 18u:
					num = (int)((num2 * 730209335) ^ 0x47558E74);
					continue;
				case 17u:
					Registration.smethod_12((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -285555361) ^ -1501488637;
					continue;
				case 16u:
					Registration.smethod_51(PictureBox1, bool_0: false);
					num = ((int)num2 * -874172441) ^ -1377420242;
					continue;
				case 15u:
					Timer1 = Registration.smethod_9(components);
					num = ((int)num2 * -2033465745) ^ 0x2CC5774E;
					continue;
				case 14u:
					Registration.smethod_21(Label1, (ContentAlignment)32);
					num = (int)((num2 * 46864371) ^ 0x48BBBFAA);
					continue;
				case 13u:
					num = ((int)num2 * -1869561599) ^ -1755763808;
					continue;
				case 12u:
					num = ((int)num2 * -1699320167) ^ -772321693;
					continue;
				case 11u:
					Registration.smethod_46((Control)(object)SuccessMsg, bool_0: false);
					num = ((int)num2 * -486318652) ^ 0x29227E99;
					continue;
				case 10u:
					Registration.smethod_17((Control)(object)Label5, "Label5");
					num = ((int)num2 * -1342002568) ^ 0x36DA254B;
					continue;
				case 9u:
					Registration.smethod_16((Control)(object)MobileTxt, new Point(108, 203));
					num = ((int)num2 * -1289691347) ^ -391708103;
					continue;
				case 8u:
					Registration.smethod_44((Control)(object)this, Color.White);
					num = (int)((num2 * 1062794331) ^ 0x2BA29FD4);
					continue;
				case 7u:
					Registration.smethod_16((Control)(object)PictureBox1, new Point(281, 21));
					num = (int)(num2 * 1670226886) ^ -324844811;
					continue;
				case 6u:
					Registration.smethod_19((Control)(object)GroupBox2, 3);
					num = ((int)num2 * -201582811) ^ 0x5E5BBA65;
					continue;
				case 5u:
					num = ((int)num2 * -1460160542) ^ -767663350;
					continue;
				case 4u:
					Registration.smethod_18((Control)(object)GroupBox2, new Size(486, 394));
					num = (int)((num2 * 1077476886) ^ 0x252E92EF);
					continue;
				case 3u:
					Registration.smethod_11((Control)(object)GroupBox2);
					num = (int)((num2 * 2033424272) ^ 0x51655966);
					continue;
				case 2u:
					num = ((int)num2 * -1055869958) ^ 0x754F2AE6;
					continue;
				case 1u:
					Label6 = Registration.smethod_3();
					num = (int)(num2 * 2007580405) ^ -1512034804;
					continue;
				case 0u:
					Registration.smethod_52((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -1110021828) ^ 0x441A1A96;
					continue;
				default:
					return;
				case 165u:
					break;
				case 188u:
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
		Registration.smethod_67((TextBoxBase)(object)NameTxt);
		Registration.smethod_30(DOBTxt, Registration.smethod_69(Registration.smethod_68((object)DateTime.Now, "dd-MM-yyyy")));
		while (true)
		{
			int num = 852962054;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3E564762u) % 5u)
				{
				case 4u:
					Registration.smethod_70(GenderTxt, -1);
					num = (int)((num2 * 1278748641) ^ 0x2AA096BE);
					continue;
				case 3u:
					Registration.smethod_67((TextBoxBase)(object)MobileTxt);
					num = (int)(num2 * 1066328684) ^ -1170680005;
					continue;
				case 1u:
					num = (int)((num2 * 1039839915) ^ 0x306317D6);
					continue;
				case 0u:
					break;
				default:
					Registration.smethod_67((TextBoxBase)(object)AddressTxt);
					Registration.smethod_46((Control)(object)SuccessMsg, bool_0: false);
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
			int num = -1510951064;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC5A4F039u) % 3u)
				{
				case 2u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0003:
				Registration.smethod_71((Control)(object)MobileTxt);
				num = (int)((num2 * 1812173183) ^ 0x7A837BAB);
			}
		}
	}

	private void RegisterBtn_Click(object sender, EventArgs e)
	{
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected I4, but got Unknown
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected I4, but got Unknown
		//IL_0391: Incompatible stack heights: 0 vs 1
		//IL_03ac: Incompatible stack heights: 0 vs 1
		//IL_03c1: Incompatible stack heights: 0 vs 1
		//IL_03da: Incompatible stack heights: 0 vs 1
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Incompatible stack heights: 0 vs 1
		//IL_041d: Incompatible stack heights: 0 vs 1
		//IL_0430: Incompatible stack heights: 0 vs 1
		//IL_0443: Incompatible stack heights: 0 vs 1
		//IL_0462: Incompatible stack heights: 0 vs 1
		//IL_046c: Incompatible stack heights: 0 vs 1
		OleDbConnection oleDbConnection_ = Registration.smethod_72();
		Registration.smethod_74(oleDbConnection_, Registration.smethod_73(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
		bool flag = !Validate_data();
		DateTime dateTime_ = default(DateTime);
		while (true)
		{
			int num = 1674451698;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4AD93DF6u) % 6u)
				{
				case 4u:
					dateTime_ = Registration.smethod_69(Registration.smethod_68((object)Registration.smethod_75(DOBTxt), "dd-MM-yyyy"));
					num = 136039651;
					continue;
				case 3u:
					Registration.smethod_76(oleDbConnection_);
					num = ((int)num2 * -305127881) ^ -1316716925;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1607152427;
						num5 = -1607152427;
					}
					else
					{
						num4 = -1941524056;
						num5 = -1941524056;
					}
					num = num4 ^ (int)(num2 * 1110112567);
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
							int num3 = 1028818559;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x4AD93DF6u) % 15u)
								{
								case 14u:
									Registration.smethod_82(Registration.smethod_78(val), Registration.smethod_81("Address", (object)Registration.smethod_85(Registration.smethod_79(AddressTxt))));
									num3 = ((int)num2 * -579686571) ^ -1622685490;
									continue;
								case 13u:
									Registration.smethod_46((Control)(object)SuccessMsg, bool_0: true);
									Registration.smethod_20(SuccessMsg, "Patient Successfully Registered !!");
									num3 = (int)((num2 * 123188942) ^ 0x418C1BC6);
									continue;
								case 12u:
									Registration.smethod_82(Registration.smethod_78(val), Registration.smethod_81("Name", (object)Registration.smethod_80(Registration.smethod_79(NameTxt))));
									num3 = ((int)num2 * -2079397119) ^ -1070502332;
									continue;
								case 10u:
									Registration.smethod_82(Registration.smethod_78(val), Registration.smethod_81("Mobile", (object)Registration.smethod_85(Registration.smethod_79(MobileTxt))));
									num3 = ((int)num2 * -1349006101) ^ 0x12F41AEA;
									continue;
								case 8u:
									Registration.smethod_89(Timer1);
									num3 = ((int)num2 * -303341919) ^ -105036679;
									continue;
								case 7u:
									num3 = (int)(num2 * 1839238556) ^ -906709301;
									continue;
								case 6u:
									Registration.smethod_88(oleDbConnection_);
									num3 = (int)((num2 * 226270876) ^ 0x3CC265DF);
									continue;
								case 5u:
									Registration.smethod_82(Registration.smethod_78(val), Registration.smethod_81("Gender", (object)Registration.smethod_80(Registration.smethod_84(GenderTxt))));
									num3 = ((int)num2 * -228371859) ^ 0x6FA00642;
									continue;
								case 4u:
									num3 = (int)((num2 * 1943058114) ^ 0x59515C11);
									continue;
								case 3u:
									num3 = ((int)num2 * -1599729861) ^ 0x438B9982;
									continue;
								case 2u:
									Registration.smethod_44((Control)(object)SuccessMsg, Color.Green);
									num3 = (int)((num2 * 618127455) ^ 0x5EF75BD5);
									continue;
								case 1u:
									Registration.smethod_86(val);
									Registration.smethod_87((Component)(object)val);
									num3 = ((int)num2 * -1819739674) ^ 0x64F6B22B;
									continue;
								case 0u:
									Registration.smethod_82(Registration.smethod_78(val), Registration.smethod_81("DOB", (object)Registration.smethod_83(dateTime_)));
									num3 = ((int)num2 * -1128373118) ^ 0x54B2040E;
									continue;
								default:
									return;
								case 11u:
									break;
								case 9u:
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
							_ = 348084516;
							while (true)
							{
								_003F val2 = /*Error near IL_0337: Stack underflow*/^ 0x4AD93DF6;
								num2 = (uint)(int)val2;
								switch (val2 % 11)
								{
								default:
									return;
								case 9:
									Registration.smethod_20(SuccessMsg, "Invalid Credentials");
									_ = ((int)num2 * -712900773) ^ 0x26DE4BD2;
									continue;
								case 8:
									Registration.smethod_89(Timer1);
									_ = (num2 * 2003668275) ^ 0x4BEE8235;
									continue;
								case 7:
									Registration.smethod_93();
									_ = ((int)num2 * -1646859841) ^ 0x55CF6E38;
									continue;
								case 6:
									Registration.smethod_88(oleDbConnection_);
									_ = ((int)num2 * -809140092) ^ 0x4379C8AD;
									continue;
								case 4:
									Registration.smethod_92(Registration.smethod_91(exception_));
									Registration.smethod_44((Control)(object)SuccessMsg, Color.Red);
									_ = ((int)num2 * -1406434305) ^ 0x32D8732B;
									continue;
								case 3:
									_ = (num2 * 519303004) ^ 0xADC87DCFu;
									continue;
								case 2:
									_ = (num2 * 1288381751) ^ 0x66C60B81;
									continue;
								case 1:
									_ = ((int)num2 * -1870544840) ^ 0x1AA15129;
									continue;
								case 0:
									Registration.smethod_46((Control)(object)SuccessMsg, bool_0: true);
									_ = ((int)num2 * -909659914) ^ -1598607531;
									continue;
								case 10:
									break;
								case 5:
									return;
								}
								break;
							}
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

	private void Timer1_Tick(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1991489988;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3560F635u) % 4u)
				{
				case 1u:
					Registration.smethod_46((Control)(object)SuccessMsg, bool_0: false);
					num = ((int)num2 * -617109809) ^ 0x7083A962;
					continue;
				case 0u:
					Registration.smethod_94(Timer1);
					num = (int)((num2 * 189225637) ^ 0x80E26BE);
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
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = -870405442;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE0E2BFDEu) % 36u)
				{
				case 35u:
					flag2 = Registration.smethod_95(Registration.smethod_79(AddressTxt), "", bool_0: false) == 0;
					num = ((int)num2 * -1178083124) ^ -1706950388;
					continue;
				case 34u:
				{
					int num5;
					if (!MyProject.Forms.Form1.Gender_Validator(Registration.smethod_80(Registration.smethod_84(GenderTxt))))
					{
						num = -2143183555;
						num5 = -2143183555;
					}
					else
					{
						num = -1837936470;
						num5 = -1837936470;
					}
					continue;
				}
				case 33u:
					Registration.smethod_20(SuccessMsg, "Invalid Name");
					num = (int)((num2 * 225984349) ^ 0x4C65A50B);
					continue;
				case 32u:
					num = -196711182;
					continue;
				case 31u:
					Registration.smethod_89(Timer1);
					num = (int)(num2 * 244982685) ^ -989916462;
					continue;
				case 30u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = 2077225366;
						num7 = 2077225366;
					}
					else
					{
						num6 = 769780995;
						num7 = 769780995;
					}
					num = num6 ^ (int)(num2 * 591670079);
					continue;
				}
				case 29u:
					Registration.smethod_46((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -1172917751) ^ -947517455;
					continue;
				case 28u:
					num = ((int)num2 * -1818092933) ^ 0x4952E18A;
					continue;
				case 27u:
					num = (int)((num2 * 2090517412) ^ 0x3BFFFBDD);
					continue;
				case 26u:
					Registration.smethod_46((Control)(object)SuccessMsg, bool_0: true);
					num = (int)(num2 * 193298498) ^ -186030690;
					continue;
				case 25u:
					num = (int)(num2 * 1403618698) ^ -464122309;
					continue;
				case 24u:
					result = false;
					num = ((int)num2 * -360350927) ^ -698373377;
					continue;
				case 23u:
					Registration.smethod_89(Timer1);
					result = false;
					num = (int)(num2 * 763098459) ^ -536843752;
					continue;
				case 22u:
					Registration.smethod_20(SuccessMsg, "Invalid Gender");
					num = ((int)num2 * -1939099519) ^ 0x5DA91221;
					continue;
				case 21u:
					result = false;
					num = (int)(num2 * 669973485) ^ -106808112;
					continue;
				case 18u:
					num = -1766592896;
					continue;
				case 17u:
					num = ((int)num2 * -502196596) ^ -1919606859;
					continue;
				case 16u:
					num = (int)(num2 * 697997894) ^ -4915858;
					continue;
				case 15u:
					result = false;
					num = (int)(num2 * 1102206833) ^ -920805224;
					continue;
				case 14u:
					result = true;
					num = (int)(num2 * 12047909) ^ -1892724337;
					continue;
				case 13u:
					num = (int)((num2 * 1460101362) ^ 0x5C24F289);
					continue;
				case 12u:
					Registration.smethod_20(SuccessMsg, "Invalid Mobile Number");
					Registration.smethod_44((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -2053398131) ^ -110947743;
					continue;
				case 11u:
					num = -876476911;
					continue;
				case 10u:
				{
					int num8;
					int num9;
					if (!flag2)
					{
						num8 = -99481264;
						num9 = -99481264;
					}
					else
					{
						num8 = -1891593204;
						num9 = -1891593204;
					}
					num = num8 ^ (int)(num2 * 1128502734);
					continue;
				}
				case 9u:
					Registration.smethod_44((Control)(object)SuccessMsg, Color.Red);
					Registration.smethod_89(Timer1);
					num = ((int)num2 * -404285813) ^ -1858942420;
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if (!MyProject.Forms.Form1.Name_Validation(Registration.smethod_80(Registration.smethod_79(NameTxt))))
					{
						num3 = 406524575;
						num4 = 406524575;
					}
					else
					{
						num3 = 1859604624;
						num4 = 1859604624;
					}
					num = num3 ^ (int)(num2 * 959603477);
					continue;
				}
				case 7u:
					Registration.smethod_46((Control)(object)SuccessMsg, bool_0: true);
					num = (int)(num2 * 1946193450) ^ -950446710;
					continue;
				case 6u:
					num = (int)(num2 * 771875265) ^ -1762303559;
					continue;
				case 5u:
					Registration.smethod_44((Control)(object)SuccessMsg, Color.Red);
					Registration.smethod_89(Timer1);
					num = ((int)num2 * -1732098682) ^ -1925613416;
					continue;
				case 4u:
					flag = !MyProject.Forms.Form1.Mobile_Validator(Registration.smethod_79(MobileTxt));
					num = ((int)num2 * -2129942131) ^ -393851992;
					continue;
				case 3u:
					Registration.smethod_20(SuccessMsg, "Enter Address");
					num = (int)(num2 * 1458253426) ^ -2063971987;
					continue;
				case 2u:
					Registration.smethod_46((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -15657166) ^ -555914001;
					continue;
				case 1u:
					num = (int)((num2 * 1684234154) ^ 0x73B0D5E7);
					continue;
				case 0u:
					Registration.smethod_44((Control)(object)SuccessMsg, Color.Red);
					num = (int)((num2 * 1413638283) ^ 0x7B3ADB4D);
					continue;
				case 20u:
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
