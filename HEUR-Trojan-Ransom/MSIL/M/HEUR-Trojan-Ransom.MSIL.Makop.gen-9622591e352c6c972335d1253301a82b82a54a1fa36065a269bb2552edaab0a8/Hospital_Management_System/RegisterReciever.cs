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
public class RegisterReciever : UserControl
{
	private IContainer components;

	private OleDbConnection myconnection;

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RegisterLbl")]
	internal virtual Label RegisterLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RecieverInfoGrp")]
	internal virtual GroupBox RecieverInfoGrp
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

	[field: AccessedThroughProperty("QuantityLbl")]
	internal virtual Label QuantityLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BloodGrpCombo")]
	internal virtual ComboBox BloodGrpCombo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BloodGrpLbl")]
	internal virtual Label BloodGrpLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateTxt")]
	internal virtual TextBox DateTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateLbl")]
	internal virtual Label DateLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GenderTxt")]
	internal virtual ComboBox GenderTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("AgeLbl")]
	internal virtual Label AgeLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("AgeTxt")]
	internal virtual TextBox AgeTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MobileLbl")]
	internal virtual Label MobileLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GenderLbl")]
	internal virtual Label GenderLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NameLbl")]
	internal virtual Label NameLbl
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

	[field: AccessedThroughProperty("NameTxt")]
	internal virtual TextBox NameTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button AddReceiptantBtn
	{
		[CompilerGenerated]
		get
		{
			return _AddReceiptantBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = AddReceiptantBtn_Click;
			Button addReceiptantBtn = _AddReceiptantBtn;
			if (addReceiptantBtn != null)
			{
				goto IL_001a;
			}
			goto IL_00b2;
			IL_00b2:
			_AddReceiptantBtn = value;
			int num = 1585594416;
			goto IL_0085;
			IL_0085:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4DAE2980u) % 7u)
				{
				case 6u:
					break;
				case 5u:
					RegisterReciever.smethod_56((Control)(object)addReceiptantBtn, eventHandler_);
					num = ((int)num2 * -395835052) ^ 0x3B4B1B59;
					continue;
				case 3u:
					addReceiptantBtn = _AddReceiptantBtn;
					num = (int)((num2 * 179314903) ^ 0x63B1CF48);
					continue;
				case 2u:
					RegisterReciever.smethod_57((Control)(object)addReceiptantBtn, eventHandler_);
					num = ((int)num2 * -1948650098) ^ -1410402063;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (addReceiptantBtn != null)
					{
						num3 = 1895443948;
						num4 = 1895443948;
					}
					else
					{
						num3 = 2094305985;
						num4 = 2094305985;
					}
					num = num3 ^ ((int)num2 * -105519181);
					continue;
				}
				default:
					return;
				case 4u:
					goto IL_00b2;
				case 0u:
					return;
				}
				break;
			}
			goto IL_001a;
			IL_001a:
			num = 489603049;
			goto IL_0085;
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
				int num = -1704189190;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA770E753u) % 9u)
					{
					case 8u:
						clearBtn = _ClearBtn;
						num = (int)(num2 * 1785227927) ^ -432848907;
						continue;
					case 7u:
					{
						int num5;
						int num6;
						if (clearBtn == null)
						{
							num5 = -2132704078;
							num6 = -2132704078;
						}
						else
						{
							num5 = -1620295459;
							num6 = -1620295459;
						}
						num = num5 ^ (int)(num2 * 1111090501);
						continue;
					}
					case 6u:
					{
						int num3;
						int num4;
						if (clearBtn != null)
						{
							num3 = 523303169;
							num4 = 523303169;
						}
						else
						{
							num3 = 176045290;
							num4 = 176045290;
						}
						num = num3 ^ (int)(num2 * 878796650);
						continue;
					}
					case 5u:
						clearBtn = _ClearBtn;
						num = (int)(num2 * 1581882843) ^ -1758141138;
						continue;
					case 4u:
						RegisterReciever.smethod_57((Control)(object)clearBtn, eventHandler_);
						num = (int)(num2 * 270152442) ^ -125000254;
						continue;
					case 3u:
						RegisterReciever.smethod_56((Control)(object)clearBtn, eventHandler_);
						num = (int)(num2 * 1718043873) ^ -225111972;
						continue;
					case 2u:
						_ClearBtn = value;
						num = -687544242;
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
				int num = -2113132371;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8892407Eu) % 8u)
					{
					case 6u:
						timer = _Timer1;
						num = (int)((num2 * 181128244) ^ 0x364F0CC7);
						continue;
					case 5u:
						_Timer1 = value;
						num = -2038508464;
						continue;
					case 3u:
					{
						timer = _Timer1;
						int num5;
						int num6;
						if (timer == null)
						{
							num5 = -465402963;
							num6 = -465402963;
						}
						else
						{
							num5 = -2068254902;
							num6 = -2068254902;
						}
						num = num5 ^ (int)(num2 * 571847546);
						continue;
					}
					case 2u:
						RegisterReciever.smethod_58(timer, eventHandler_);
						num = (int)(num2 * 312654729) ^ -2138153559;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (timer != null)
						{
							num3 = 822762991;
							num4 = 822762991;
						}
						else
						{
							num3 = 1572283224;
							num4 = 1572283224;
						}
						num = num3 ^ (int)(num2 * 2026301425);
						continue;
					}
					case 0u:
						RegisterReciever.smethod_59(timer, eventHandler_);
						num = (int)(num2 * 139092261) ^ -343044151;
						continue;
					default:
						return;
					case 4u:
						break;
					case 7u:
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public RegisterReciever()
	{
		while (true)
		{
			int num = -1473550878;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFD321D77u) % 6u)
				{
				case 4u:
					RegisterReciever.smethod_0((UserControl)(object)this, (EventHandler)RegisterReciever_Load);
					num = ((int)num2 * -1994331808) ^ -1242261785;
					continue;
				case 3u:
					InitializeComponent();
					num = (int)(num2 * 964008508) ^ -360447559;
					continue;
				case 2u:
					myconnection = RegisterReciever.smethod_1();
					num = (int)((num2 * 1013190957) ^ 0x337A2A92);
					continue;
				case 1u:
					num = ((int)num2 * -30513493) ^ -737618770;
					continue;
				default:
					return;
				case 5u:
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
				int num = -45955783;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xDDA90AEAu) % 9u)
					{
					case 7u:
						if (disposing)
						{
							num = (int)(num2 * 946890242) ^ -564063456;
							continue;
						}
						num3 = 0;
						goto IL_001a;
					case 6u:
						num = -233306153;
						continue;
					case 5u:
						num = (int)((num2 * 817814799) ^ 0x4AD52460);
						continue;
					case 3u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -1246412037;
							num5 = -1246412037;
						}
						else
						{
							num4 = -1176343931;
							num5 = -1176343931;
						}
						num = num4 ^ (int)(num2 * 143014017);
						continue;
					}
					case 2u:
						num3 = ((components != null) ? 1 : 0);
						goto IL_001a;
					case 1u:
						num = (int)((num2 * 1711536159) ^ 0x2EEE4674);
						continue;
					case 0u:
						RegisterReciever.smethod_2((IDisposable)components);
						num = (int)((num2 * 1576304994) ^ 0x4FE3A456);
						continue;
					default:
						return;
					case 8u:
						break;
					case 4u:
						return;
						IL_001a:
						flag = (byte)num3 != 0;
						num = -869096253;
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
		components = RegisterReciever.smethod_3();
		RegisterLbl = RegisterReciever.smethod_4();
		while (true)
		{
			int num = 389879669;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6E4E221Du) % 262u)
				{
				case 261u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)BloodGrpCombo);
					num = (int)((num2 * 772075779) ^ 0x314B410);
					continue;
				case 260u:
					RegisterReciever.smethod_20((Control)(object)Label1, 23);
					RegisterReciever.smethod_21(Label1, "(In litres)");
					num = (int)(num2 * 331978781) ^ -1775911554;
					continue;
				case 259u:
					RegisterReciever.smethod_22(DateLbl, (ContentAlignment)32);
					num = ((int)num2 * -735496546) ^ -2038828019;
					continue;
				case 258u:
					RegisterReciever.smethod_14(MobileLbl, bool_0: true);
					RegisterReciever.smethod_16((Control)(object)MobileLbl, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 722653650) ^ 0x6DE6D85D);
					continue;
				case 257u:
					RegisterReciever.smethod_18((Control)(object)DateTxt, "DateTxt");
					num = ((int)num2 * -1784115758) ^ -1452920764;
					continue;
				case 256u:
					RegisterReciever.smethod_17((Control)(object)MobileTxt, new Point(135, 156));
					RegisterReciever.smethod_18((Control)(object)MobileTxt, "MobileTxt");
					num = (int)((num2 * 1901117316) ^ 0x378DB111);
					continue;
				case 255u:
					RegisterReciever.smethod_20((Control)(object)AgeLbl, 13);
					num = (int)(num2 * 815410006) ^ -327838111;
					continue;
				case 254u:
					num = ((int)num2 * -467162698) ^ 0x245C3320;
					continue;
				case 253u:
					RegisterReciever.smethod_21(RegisterLbl, "Register Reciever");
					num = ((int)num2 * -1653461883) ^ 0x4031BB2C;
					continue;
				case 252u:
					num = (int)(num2 * 62616605) ^ -32876033;
					continue;
				case 251u:
					RegisterReciever.smethod_18((Control)(object)NameLbl, "NameLbl");
					num = ((int)num2 * -1504749074) ^ -1506884568;
					continue;
				case 250u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)NameTxt);
					num = (int)((num2 * 1940021473) ^ 0x58B1CCBF);
					continue;
				case 249u:
					RegisterReciever.smethod_17((Control)(object)GenderTxt, new Point(135, 327));
					num = (int)((num2 * 1665334130) ^ 0x46F6C287);
					continue;
				case 248u:
					num = ((int)num2 * -1725562805) ^ 0xEB5986F;
					continue;
				case 247u:
					num = ((int)num2 * -1093723148) ^ -1549548884;
					continue;
				case 246u:
					RegisterReciever.smethod_41(PictureBox1, (Image)(object)Resources.images);
					num = (int)((num2 * 1242500731) ^ 0x7C23B018);
					continue;
				case 245u:
					BloodGrpLbl = RegisterReciever.smethod_4();
					num = ((int)num2 * -937824826) ^ 0x744BA938;
					continue;
				case 244u:
					RegisterReciever.smethod_20((Control)(object)GenderLbl, 6);
					RegisterReciever.smethod_21(GenderLbl, "Gender :");
					num = (int)((num2 * 385806658) ^ 0x6F08AB65);
					continue;
				case 243u:
					RegisterReciever.smethod_22(NameLbl, (ContentAlignment)32);
					num = (int)((num2 * 669264711) ^ 0x3A9A2502);
					continue;
				case 242u:
					RegisterReciever.smethod_43(PictureBox1, 9);
					num = (int)((num2 * 1027537289) ^ 0x1121F368);
					continue;
				case 241u:
					RegisterReciever.smethod_18((Control)(object)AgeTxt, "AgeTxt");
					num = ((int)num2 * -2132926809) ^ 0x10CF354F;
					continue;
				case 240u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)QuantityLbl);
					num = (int)((num2 * 2079326271) ^ 0x42FE6308);
					continue;
				case 239u:
					RegisterReciever.smethod_16((Control)(object)RegisterLbl, RegisterReciever.smethod_15("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1795689570) ^ -1912553683;
					continue;
				case 238u:
					RegisterReciever.smethod_19((Control)(object)DateTxt, new Size(167, 29));
					num = ((int)num2 * -913451417) ^ -1365410805;
					continue;
				case 237u:
					RegisterReciever.smethod_19((Control)(object)QuantityTxt, new Size(86, 29));
					num = (int)(num2 * 1058377057) ^ -2016412304;
					continue;
				case 236u:
					num = ((int)num2 * -1772118615) ^ 0xA268F2E;
					continue;
				case 235u:
					num = (int)(num2 * 561485303) ^ -1670418932;
					continue;
				case 234u:
					num = (int)(num2 * 457744926) ^ -513681063;
					continue;
				case 233u:
					RegisterReciever.smethod_28(BloodGrpCombo, RegisterReciever.smethod_27());
					num = (int)(num2 * 842181699) ^ -109580705;
					continue;
				case 232u:
					RegisterReciever.smethod_47((Control)(object)this, Color.White);
					num = (int)((num2 * 957308668) ^ 0x3D6A29C);
					continue;
				case 231u:
					num = (int)((num2 * 600536922) ^ 0x8C9D925);
					continue;
				case 230u:
					num = (int)((num2 * 1152995744) ^ 0x5033A1ED);
					continue;
				case 229u:
					num = ((int)num2 * -1946858690) ^ 0x739FA0B2;
					continue;
				case 228u:
					num = (int)((num2 * 434688216) ^ 0x74D7FA1E);
					continue;
				case 227u:
					num = ((int)num2 * -528173076) ^ -555500349;
					continue;
				case 226u:
					RegisterReciever.smethod_52((Control)(object)RecieverInfoGrp);
					num = (int)(num2 * 988025095) ^ -1449479608;
					continue;
				case 225u:
					num = (int)(num2 * 89531990) ^ -891817418;
					continue;
				case 224u:
					RegisterReciever.smethod_19((Control)(object)RegisterLbl, new Size(282, 35));
					num = ((int)num2 * -641025459) ^ -1857632944;
					continue;
				case 223u:
					RegisterReciever.smethod_16((Control)(object)Label1, RegisterReciever.smethod_15("MS Reference Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1732329799) ^ -387738638;
					continue;
				case 222u:
					num = ((int)num2 * -148392556) ^ -772414959;
					continue;
				case 221u:
					RegisterReciever.smethod_18((Control)(object)BloodGrpCombo, "BloodGrpCombo");
					RegisterReciever.smethod_19((Control)(object)BloodGrpCombo, new Size(129, 26));
					RegisterReciever.smethod_20((Control)(object)BloodGrpCombo, 20);
					num = (int)((num2 * 1765673236) ^ 0x39257EE4);
					continue;
				case 220u:
					RegisterReciever.smethod_14(AgeLbl, bool_0: true);
					RegisterReciever.smethod_16((Control)(object)AgeLbl, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 375252234) ^ -1291862885;
					continue;
				case 219u:
					num = (int)(num2 * 110117773) ^ -906610507;
					continue;
				case 218u:
					RegisterReciever.smethod_36((ButtonBase)(object)ClearBtn, "Clear");
					num = (int)(num2 * 3957001) ^ -1666272769;
					continue;
				case 217u:
					num = (int)(num2 * 126376976) ^ -610251095;
					continue;
				case 216u:
					RegisterReciever.smethod_34((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					num = (int)((num2 * 426719969) ^ 0x5FBBC227);
					continue;
				case 215u:
					num = (int)((num2 * 606210143) ^ 0x4DF06F99);
					continue;
				case 214u:
					RegisterReciever.smethod_22(GenderLbl, (ContentAlignment)32);
					num = (int)(num2 * 172693247) ^ -1735476048;
					continue;
				case 213u:
					num = (int)(num2 * 220969988) ^ -369601395;
					continue;
				case 212u:
					MobileTxt = RegisterReciever.smethod_6();
					num = ((int)num2 * -1220783895) ^ 0x67AFB04B;
					continue;
				case 211u:
					RegisterReciever.smethod_30((ListControl)(object)BloodGrpCombo, bool_0: true);
					num = ((int)num2 * -1600934855) ^ 0x2E8B4898;
					continue;
				case 210u:
					num = ((int)num2 * -2086357751) ^ -1250678613;
					continue;
				case 209u:
					num = (int)((num2 * 311214527) ^ 0x4CEEF826);
					continue;
				case 208u:
					RegisterReciever.smethod_17((Control)(object)QuantityTxt, new Point(135, 262));
					RegisterReciever.smethod_18((Control)(object)QuantityTxt, "QuantityTxt");
					num = ((int)num2 * -994934527) ^ 0x44697585;
					continue;
				case 207u:
					RegisterReciever.smethod_21(AgeLbl, "Age :");
					num = ((int)num2 * -2106754856) ^ 0x58A2B123;
					continue;
				case 206u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)AgeLbl);
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)AgeTxt);
					num = ((int)num2 * -1087005415) ^ 0x282FC911;
					continue;
				case 205u:
					RegisterReciever.smethod_14(RegisterLbl, bool_0: true);
					num = (int)(num2 * 1946988945) ^ -1734546159;
					continue;
				case 204u:
					RegisterReciever.smethod_21(SuccessMsg, "Name :");
					num = (int)((num2 * 1617747453) ^ 0x5816B9BD);
					continue;
				case 203u:
					RegisterReciever.smethod_44(PictureBox1, bool_0: false);
					num = (int)(num2 * 288642534) ^ -2146562105;
					continue;
				case 202u:
					num = ((int)num2 * -2062642538) ^ 0x2ADF017;
					continue;
				case 201u:
					num = (int)((num2 * 698249979) ^ 0x493CA7D6);
					continue;
				case 200u:
					AddReceiptantBtn = RegisterReciever.smethod_8();
					num = ((int)num2 * -31782798) ^ 0x65E022F1;
					continue;
				case 199u:
					RegisterReciever.smethod_14(NameLbl, bool_0: true);
					num = ((int)num2 * -1798679778) ^ -561792547;
					continue;
				case 198u:
					RegisterReciever.smethod_32(RegisterReciever.smethod_31(BloodGrpCombo), new object[9] { "--Select--", "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
					num = ((int)num2 * -2083727317) ^ 0x519DE6A8;
					continue;
				case 197u:
					RegisterReciever.smethod_18((Control)(object)Label1, "Label1");
					num = ((int)num2 * -2125733317) ^ 0x7D0E673B;
					continue;
				case 196u:
					RegisterReciever.smethod_21(BloodGrpLbl, "Blood Group :");
					RegisterReciever.smethod_22(BloodGrpLbl, (ContentAlignment)32);
					RegisterReciever.smethod_17((Control)(object)DateTxt, new Point(205, 382));
					num = ((int)num2 * -1672673948) ^ -1872273748;
					continue;
				case 195u:
					RegisterReciever.smethod_40((Control)(object)Label1, bool_0: false);
					num = (int)((num2 * 2019201487) ^ 0x2B6FF4F3);
					continue;
				case 194u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_48((Control)(object)this), (Control)(object)RegisterLbl);
					RegisterReciever.smethod_24(RegisterReciever.smethod_48((Control)(object)this), (Control)(object)PictureBox1);
					num = (int)((num2 * 1174911255) ^ 0x4326D7AE);
					continue;
				case 193u:
					num = ((int)num2 * -1866822783) ^ -535933195;
					continue;
				case 192u:
					num = ((int)num2 * -519739855) ^ -1005034458;
					continue;
				case 191u:
					num = ((int)num2 * -1659783444) ^ -1234012549;
					continue;
				case 190u:
					num = ((int)num2 * -1226410296) ^ 0xC26FF5D;
					continue;
				case 189u:
					RegisterReciever.smethod_17((Control)(object)BloodGrpLbl, new Point(33, 216));
					num = (int)(num2 * 1617626181) ^ -1335700642;
					continue;
				case 188u:
					num = ((int)num2 * -1094267524) ^ -1666870674;
					continue;
				case 187u:
					RegisterReciever.smethod_20((Control)(object)NameTxt, 0);
					num = ((int)num2 * -1917288261) ^ 0x66C42081;
					continue;
				case 186u:
					num = ((int)num2 * -660130733) ^ -1077446448;
					continue;
				case 185u:
					PictureBox1 = RegisterReciever.smethod_10();
					num = (int)(num2 * 1288383246) ^ -381103586;
					continue;
				case 184u:
					num = (int)((num2 * 1385448122) ^ 0x73DC39A2);
					continue;
				case 183u:
					BloodGrpCombo = RegisterReciever.smethod_7();
					num = (int)((num2 * 130138811) ^ 0x36D3BF15);
					continue;
				case 182u:
					RegisterReciever.smethod_39(Timer1, 1500);
					num = (int)((num2 * 1338786330) ^ 0x2A94016A);
					continue;
				case 181u:
					RegisterReciever.smethod_20((Control)(object)ClearBtn, 14);
					num = (int)(num2 * 1122006489) ^ -1552852516;
					continue;
				case 180u:
					RegisterReciever.smethod_19((Control)(object)SuccessMsg, new Size(339, 45));
					num = (int)((num2 * 1943657925) ^ 0x157343DD);
					continue;
				case 179u:
					num = ((int)num2 * -167507671) ^ -583418795;
					continue;
				case 178u:
					num = (int)((num2 * 2066570173) ^ 0x384E90A4);
					continue;
				case 177u:
					num = (int)(num2 * 1808111650) ^ -1676206238;
					continue;
				case 176u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)GenderLbl);
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)NameLbl);
					num = ((int)num2 * -1276021468) ^ 0x6111CB09;
					continue;
				case 175u:
					num = (int)(num2 * 1228145192) ^ -1918161648;
					continue;
				case 174u:
					RegisterReciever.smethod_13((Control)(object)this);
					num = (int)((num2 * 1571544153) ^ 0x23B04B5C);
					continue;
				case 173u:
					num = (int)((num2 * 199434007) ^ 0x59C3B82C);
					continue;
				case 172u:
					num = ((int)num2 * -1418142730) ^ -749844352;
					continue;
				case 171u:
					RegisterReciever.smethod_19((Control)(object)PictureBox1, new Size(171, 126));
					num = (int)((num2 * 413776374) ^ 0x3FC6EB53);
					continue;
				case 169u:
					num = (int)(num2 * 1502735525) ^ -1524456804;
					continue;
				case 168u:
					RegisterReciever.smethod_21(QuantityLbl, "Quantity :");
					num = ((int)num2 * -282109116) ^ 0x1B74703C;
					continue;
				case 167u:
					num = ((int)num2 * -990814039) ^ 0x2AB6A468;
					continue;
				case 166u:
					RegisterReciever.smethod_19((Control)(object)MobileLbl, new Size(68, 18));
					num = ((int)num2 * -1583953950) ^ 0x58907373;
					continue;
				case 165u:
					RegisterReciever.smethod_18((Control)(object)BloodGrpLbl, "BloodGrpLbl");
					RegisterReciever.smethod_19((Control)(object)BloodGrpLbl, new Size(114, 18));
					num = ((int)num2 * -800548342) ^ -1902618777;
					continue;
				case 164u:
					RegisterReciever.smethod_18((Control)(object)RegisterLbl, "RegisterLbl");
					num = ((int)num2 * -288983744) ^ 0x5BAED647;
					continue;
				case 163u:
					RegisterReciever.smethod_22(Label1, (ContentAlignment)32);
					num = ((int)num2 * -937143466) ^ 0xF79EAD4;
					continue;
				case 162u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_48((Control)(object)this), (Control)(object)RecieverInfoGrp);
					num = (int)(num2 * 395310885) ^ -642856969;
					continue;
				case 161u:
					RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: false);
					num = ((int)num2 * -1869227762) ^ 0x6D090F9F;
					continue;
				case 160u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)MobileTxt);
					num = ((int)num2 * -743623015) ^ 0x1CE7AC3F;
					continue;
				case 159u:
					RegisterReciever.smethod_16((Control)(object)BloodGrpLbl, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1982446270) ^ -2096327419;
					continue;
				case 158u:
					RegisterReciever.smethod_20((Control)(object)AgeTxt, 10);
					num = ((int)num2 * -1558954501) ^ 0xADD684D;
					continue;
				case 157u:
					RegisterReciever.smethod_20((Control)(object)BloodGrpLbl, 19);
					num = (int)((num2 * 874755370) ^ 0x6E32E002);
					continue;
				case 156u:
					RegisterReciever.smethod_19((Control)(object)MobileTxt, new Size(190, 29));
					num = ((int)num2 * -379552604) ^ 0x155D82;
					continue;
				case 155u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)Label1);
					num = (int)((num2 * 327205787) ^ 0xD1587A8);
					continue;
				case 154u:
					QuantityLbl = RegisterReciever.smethod_4();
					num = ((int)num2 * -963420556) ^ 0x41AFFDBC;
					continue;
				case 153u:
					RegisterReciever.smethod_22(SuccessMsg, (ContentAlignment)32);
					num = (int)(num2 * 941955322) ^ -1288089648;
					continue;
				case 152u:
					RegisterReciever.smethod_16((Control)(object)RecieverInfoGrp, RegisterReciever.smethod_15("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -983731031) ^ -337491328;
					continue;
				case 151u:
					DateLbl = RegisterReciever.smethod_4();
					num = ((int)num2 * -444417598) ^ 0x438CB142;
					continue;
				case 150u:
					RegisterReciever.smethod_20((Control)(object)MobileLbl, 8);
					num = ((int)num2 * -1468076040) ^ -356172687;
					continue;
				case 149u:
					RegisterReciever.smethod_17((Control)(object)ClearBtn, new Point(420, 674));
					num = (int)(num2 * 1255050066) ^ -1428142832;
					continue;
				case 148u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)BloodGrpLbl);
					num = ((int)num2 * -2100162144) ^ 0x35CF0440;
					continue;
				case 147u:
					QuantityTxt = RegisterReciever.smethod_6();
					num = ((int)num2 * -1363026113) ^ 0x612E3EC2;
					continue;
				case 146u:
					RegisterReciever.smethod_20((Control)(object)SuccessMsg, 15);
					num = ((int)num2 * -287339621) ^ -1263879433;
					continue;
				case 145u:
					RegisterReciever.smethod_18((Control)(object)QuantityLbl, "QuantityLbl");
					num = ((int)num2 * -1349255422) ^ 0x3C6A3D73;
					continue;
				case 144u:
					RegisterReciever.smethod_22(RegisterLbl, (ContentAlignment)32);
					num = ((int)num2 * -89649475) ^ -445303468;
					continue;
				case 143u:
					RegisterReciever.smethod_18((Control)(object)AddReceiptantBtn, "AddReceiptantBtn");
					num = (int)((num2 * 1769599616) ^ 0x22AB8E80);
					continue;
				case 142u:
					RegisterReciever.smethod_20((Control)(object)RecieverInfoGrp, 11);
					num = ((int)num2 * -138753571) ^ 0x447D24D8;
					continue;
				case 141u:
					RegisterReciever.smethod_16((Control)(object)QuantityLbl, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					RegisterReciever.smethod_17((Control)(object)QuantityLbl, new Point(33, 269));
					num = (int)((num2 * 685074824) ^ 0x159C4E23);
					continue;
				case 140u:
					num = ((int)num2 * -1177457459) ^ -122988668;
					continue;
				case 139u:
					RegisterReciever.smethod_45((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -1591025425) ^ 0x654484C1;
					continue;
				case 138u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)GenderTxt);
					num = ((int)num2 * -429452951) ^ -1328435991;
					continue;
				case 136u:
					DateTxt = RegisterReciever.smethod_6();
					num = (int)(num2 * 1713034826) ^ -1147047670;
					continue;
				case 135u:
					RegisterReciever.smethod_53((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -1447790911) ^ -1412696333;
					continue;
				case 134u:
					RegisterReciever.smethod_42(PictureBox1, (PictureBoxSizeMode)1);
					num = (int)((num2 * 1640666465) ^ 0x855490D);
					continue;
				case 133u:
					RegisterReciever.smethod_20((Control)(object)DateTxt, 16);
					num = ((int)num2 * -972633793) ^ -218589525;
					continue;
				case 132u:
					RegisterReciever.smethod_17((Control)(object)BloodGrpCombo, new Point(186, 213));
					num = (int)((num2 * 984570198) ^ 0x4844B954);
					continue;
				case 131u:
					num = ((int)num2 * -210253656) ^ 0x506F91CF;
					continue;
				case 130u:
					RegisterReciever.smethod_50((Control)(object)this, new Size(977, 804));
					num = ((int)num2 * -769274609) ^ 0x27778C4D;
					continue;
				case 129u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_48((Control)(object)this), (Control)(object)AddReceiptantBtn);
					num = (int)(num2 * 1189664557) ^ -2139711650;
					continue;
				case 128u:
					RegisterReciever.smethod_20((Control)(object)QuantityTxt, 22);
					num = (int)(num2 * 1928379049) ^ -956355571;
					continue;
				case 127u:
					num = (int)((num2 * 157403272) ^ 0x1D577C70);
					continue;
				case 126u:
					num = (int)(num2 * 1345769741) ^ -448520484;
					continue;
				case 125u:
					RegisterReciever.smethod_17((Control)(object)AgeTxt, new Point(135, 109));
					num = (int)((num2 * 333134254) ^ 0x6AD4B010);
					continue;
				case 124u:
					RegisterReciever.smethod_16((Control)(object)NameTxt, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1332773553) ^ -2057649687;
					continue;
				case 123u:
					RegisterReciever.smethod_18((Control)(object)PictureBox1, "PictureBox1");
					num = ((int)num2 * -1370029882) ^ 0x2F663252;
					continue;
				case 122u:
					NameTxt = RegisterReciever.smethod_6();
					num = (int)(num2 * 1693782455) ^ -35685847;
					continue;
				case 121u:
					num = (int)(num2 * 1103383606) ^ -352807090;
					continue;
				case 120u:
					RegisterReciever.smethod_17((Control)(object)NameLbl, new Point(33, 58));
					num = ((int)num2 * -1559627290) ^ -954544212;
					continue;
				case 119u:
					num = ((int)num2 * -71361680) ^ -1457122412;
					continue;
				case 118u:
					RegisterReciever.smethod_19((Control)(object)AgeLbl, new Size(46, 18));
					num = (int)(num2 * 719359081) ^ -635740038;
					continue;
				case 117u:
					RegisterReciever.smethod_20((Control)(object)NameLbl, 5);
					num = (int)((num2 * 728029044) ^ 0x377B1CC5);
					continue;
				case 116u:
					RegisterReciever.smethod_16((Control)(object)ClearBtn, RegisterReciever.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1898519849) ^ 0x9263A1F;
					continue;
				case 115u:
					AgeTxt = RegisterReciever.smethod_6();
					MobileLbl = RegisterReciever.smethod_4();
					num = ((int)num2 * -1962023527) ^ -1978335623;
					continue;
				case 114u:
					num = (int)(num2 * 2112549240) ^ -517253287;
					continue;
				case 113u:
					RegisterReciever.smethod_22(QuantityLbl, (ContentAlignment)32);
					num = ((int)num2 * -1241884976) ^ 0x80C4A8A;
					continue;
				case 112u:
					RegisterReciever.smethod_49((Control)(object)this, "RegisterReciever");
					num = (int)((num2 * 850161453) ^ 0x4C625599);
					continue;
				case 111u:
					num = (int)(num2 * 293536175) ^ -1019720395;
					continue;
				case 110u:
					RegisterReciever.smethod_17((Control)(object)NameTxt, new Point(135, 55));
					num = (int)(num2 * 1748640219) ^ -900919455;
					continue;
				case 109u:
					RegisterReciever.smethod_32(RegisterReciever.smethod_31(GenderTxt), new object[3] { "MALE", "FEMALE", "OTHERS" });
					num = (int)((num2 * 754840199) ^ 0x6F7255A6);
					continue;
				case 108u:
					RegisterReciever.smethod_14(Label1, bool_0: true);
					num = (int)((num2 * 1749437873) ^ 0xD88F266);
					continue;
				case 107u:
					RegisterReciever.smethod_14(DateLbl, bool_0: true);
					num = (int)((num2 * 93621247) ^ 0x10BC0606);
					continue;
				case 106u:
					RegisterReciever.smethod_35((Control)(object)Label1, Color.Red);
					num = (int)(num2 * 1228698277) ^ -1246035524;
					continue;
				case 105u:
					num = ((int)num2 * -1938072960) ^ 0x522D2171;
					continue;
				case 104u:
					num = ((int)num2 * -556928450) ^ -1246530077;
					continue;
				case 103u:
					RegisterReciever.smethod_22(AgeLbl, (ContentAlignment)32);
					num = ((int)num2 * -117401879) ^ 0x4BCFF820;
					continue;
				case 102u:
					num = (int)((num2 * 987463537) ^ 0x6961AB75);
					continue;
				case 101u:
					Label1 = RegisterReciever.smethod_4();
					RegisterReciever.smethod_11((Control)(object)RecieverInfoGrp);
					num = ((int)num2 * -2033597500) ^ -239108260;
					continue;
				case 100u:
					RegisterReciever.smethod_21(DateLbl, "Recieptant Date :");
					num = ((int)num2 * -779637056) ^ 0x29CF91BC;
					continue;
				case 99u:
					RegisterReciever.smethod_16((Control)(object)GenderTxt, RegisterReciever.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1837452450) ^ -544037448;
					continue;
				case 98u:
					num = (int)((num2 * 1821627369) ^ 0x58C03123);
					continue;
				case 97u:
					num = ((int)num2 * -1452934694) ^ 0x2D6A0845;
					continue;
				case 96u:
					RegisterReciever.smethod_37((ButtonBase)(object)AddReceiptantBtn, bool_0: false);
					num = (int)((num2 * 1470495444) ^ 0x330DCBBD);
					continue;
				case 95u:
					RegisterReciever.smethod_19((Control)(object)Label1, new Size(84, 18));
					num = ((int)num2 * -251702691) ^ 0x41E94A04;
					continue;
				case 94u:
					RegisterReciever.smethod_29(GenderTxt, (ComboBoxStyle)2);
					num = ((int)num2 * -313819603) ^ 0xBDDA63A;
					continue;
				case 93u:
					AgeLbl = RegisterReciever.smethod_4();
					num = (int)((num2 * 1944285210) ^ 0x194B6E45);
					continue;
				case 92u:
					num = ((int)num2 * -745211391) ^ -650166250;
					continue;
				case 91u:
					num = ((int)num2 * -1165220133) ^ 0x7B616E85;
					continue;
				case 90u:
					num = (int)((num2 * 836163887) ^ 0x68F0C44A);
					continue;
				case 89u:
					RegisterReciever.smethod_29(BloodGrpCombo, (ComboBoxStyle)2);
					num = ((int)num2 * -1688912638) ^ 0x2E95CDDF;
					continue;
				case 88u:
					RegisterReciever.smethod_17((Control)(object)GenderLbl, new Point(33, 330));
					num = (int)(num2 * 1653437817) ^ -1577204384;
					continue;
				case 87u:
					num = ((int)num2 * -2027055923) ^ 0x1BDA8917;
					continue;
				case 86u:
					RegisterReciever.smethod_21(NameLbl, "Name :");
					num = ((int)num2 * -937685029) ^ -277649514;
					continue;
				case 85u:
					RegisterReciever.smethod_18((Control)(object)DateLbl, "DateLbl");
					num = (int)(num2 * 916382270) ^ -1224823271;
					continue;
				case 84u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)QuantityTxt);
					num = (int)(num2 * 1891780869) ^ -113529859;
					continue;
				case 83u:
					RegisterReciever.smethod_51((Control)(object)RecieverInfoGrp, bool_0: false);
					num = ((int)num2 * -1373159452) ^ -1877633880;
					continue;
				case 82u:
					RegisterReciever.smethod_17((Control)(object)MobileLbl, new Point(33, 163));
					RegisterReciever.smethod_18((Control)(object)MobileLbl, "MobileLbl");
					num = (int)(num2 * 944386173) ^ -181871244;
					continue;
				case 81u:
					RegisterReciever.smethod_17((Control)(object)SuccessMsg, new Point(311, 166));
					num = (int)((num2 * 1947611954) ^ 0xEAC1023);
					continue;
				case 80u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)DateLbl);
					num = (int)((num2 * 1818807973) ^ 0x217DBD5D);
					continue;
				case 79u:
					RegisterReciever.smethod_35((Control)(object)AddReceiptantBtn, Color.White);
					RegisterReciever.smethod_17((Control)(object)AddReceiptantBtn, new Point(587, 674));
					num = (int)((num2 * 86678422) ^ 0x1A665DE2);
					continue;
				case 78u:
					RegisterReciever.smethod_35((Control)(object)ClearBtn, Color.White);
					num = (int)((num2 * 126598547) ^ 0x67C403FE);
					continue;
				case 77u:
					num = ((int)num2 * -1018877866) ^ -1563712252;
					continue;
				case 76u:
					num = (int)(num2 * 369947525) ^ -426407912;
					continue;
				case 75u:
					RegisterReciever.smethod_18((Control)(object)SuccessMsg, "SuccessMsg");
					num = ((int)num2 * -1115027315) ^ 0x7A474478;
					continue;
				case 74u:
					Timer1 = RegisterReciever.smethod_9(components);
					SuccessMsg = RegisterReciever.smethod_4();
					num = (int)(num2 * 1657383104) ^ -1854321164;
					continue;
				case 73u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_48((Control)(object)this), (Control)(object)SuccessMsg);
					num = (int)(num2 * 121764675) ^ -1514410905;
					continue;
				case 72u:
					num = (int)(num2 * 1457040009) ^ -304546726;
					continue;
				case 71u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_48((Control)(object)this), (Control)(object)ClearBtn);
					num = ((int)num2 * -327483054) ^ -1839578042;
					continue;
				case 70u:
					num = (int)((num2 * 1360531559) ^ 0x22FB3A34);
					continue;
				case 69u:
					num = ((int)num2 * -1026289575) ^ 0x28D0A005;
					continue;
				case 68u:
					RegisterReciever.smethod_19((Control)(object)GenderLbl, new Size(73, 18));
					num = ((int)num2 * -1827189293) ^ -938439799;
					continue;
				case 67u:
					RegisterReciever.smethod_21(MobileLbl, "Mobile :");
					num = (int)((num2 * 630303894) ^ 0xE2696B5);
					continue;
				case 66u:
					num = (int)((num2 * 853035956) ^ 0x529D5F17);
					continue;
				case 65u:
					num = ((int)num2 * -144312596) ^ 0x6E6F7D9F;
					continue;
				case 64u:
					RegisterReciever.smethod_22(MobileLbl, (ContentAlignment)32);
					num = (int)((num2 * 1403470849) ^ 0x44C39FF1);
					continue;
				case 63u:
					ClearBtn = RegisterReciever.smethod_8();
					num = (int)(num2 * 324426460) ^ -71370313;
					continue;
				case 62u:
					RegisterReciever.smethod_37((ButtonBase)(object)ClearBtn, bool_0: false);
					RegisterReciever.smethod_38(Timer1, bool_0: true);
					num = (int)((num2 * 107579223) ^ 0xE4A158E);
					continue;
				case 61u:
					RecieverInfoGrp = RegisterReciever.smethod_5();
					num = (int)((num2 * 619469534) ^ 0x5CE20C10);
					continue;
				case 60u:
					num = (int)(num2 * 2146642572) ^ -1853848422;
					continue;
				case 59u:
					RegisterReciever.smethod_16((Control)(object)SuccessMsg, RegisterReciever.smethod_15("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1160782110) ^ -1915540864;
					continue;
				case 58u:
					num = ((int)num2 * -896126313) ^ 0x6C7C8E2E;
					continue;
				case 57u:
					RegisterReciever.smethod_33((TextBoxBase)(object)DateTxt, bool_0: true);
					num = (int)((num2 * 730667165) ^ 0xA66CF20);
					continue;
				case 56u:
					RegisterReciever.smethod_14(QuantityLbl, bool_0: true);
					num = (int)(num2 * 547459493) ^ -1505233750;
					continue;
				case 55u:
					GenderLbl = RegisterReciever.smethod_4();
					NameLbl = RegisterReciever.smethod_4();
					num = ((int)num2 * -758748236) ^ 0x7DF778C5;
					continue;
				case 54u:
					num = ((int)num2 * -2036781249) ^ 0x58CE8924;
					continue;
				case 53u:
					RegisterReciever.smethod_16((Control)(object)GenderLbl, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -242130621) ^ -86050812;
					continue;
				case 52u:
					RegisterReciever.smethod_19((Control)(object)GenderTxt, new Size(124, 27));
					num = ((int)num2 * -828655747) ^ 0x1BA05246;
					continue;
				case 51u:
					num = (int)(num2 * 360221788) ^ -41441763;
					continue;
				case 50u:
					num = ((int)num2 * -752303686) ^ 0x78CF8ECF;
					continue;
				case 49u:
					RegisterReciever.smethod_18((Control)(object)ClearBtn, "ClearBtn");
					num = (int)(num2 * 428114761) ^ -1941579293;
					continue;
				case 48u:
					num = ((int)num2 * -1051447789) ^ -889879629;
					continue;
				case 47u:
					RegisterReciever.smethod_19((Control)(object)AddReceiptantBtn, new Size(148, 51));
					RegisterReciever.smethod_20((Control)(object)AddReceiptantBtn, 13);
					num = (int)(num2 * 1155422407) ^ -2012199608;
					continue;
				case 46u:
					num = ((int)num2 * -810963386) ^ -291684055;
					continue;
				case 45u:
					num = (int)(num2 * 385871798) ^ -1499817319;
					continue;
				case 44u:
					RegisterReciever.smethod_20((Control)(object)GenderTxt, 14);
					num = (int)((num2 * 1107312236) ^ 0x348C6E81);
					continue;
				case 43u:
					RegisterReciever.smethod_25(RecieverInfoGrp, bool_0: false);
					RegisterReciever.smethod_26(RecieverInfoGrp, "Receiver Information");
					num = (int)(num2 * 58868597) ^ -861753424;
					continue;
				case 42u:
					num = ((int)num2 * -1625528048) ^ 0x4629D691;
					continue;
				case 41u:
					num = (int)((num2 * 604595081) ^ 0x61BFFB2A);
					continue;
				case 40u:
					RegisterReciever.smethod_17((Control)(object)DateLbl, new Point(33, 389));
					num = (int)(num2 * 695964943) ^ -27867054;
					continue;
				case 39u:
					RegisterReciever.smethod_20((Control)(object)QuantityLbl, 21);
					num = (int)(num2 * 660287059) ^ -1834604439;
					continue;
				case 38u:
					num = (int)((num2 * 1451574228) ^ 0x5BF23BE9);
					continue;
				case 37u:
					RegisterReciever.smethod_17((Control)(object)Label1, new Point(240, 268));
					num = (int)(num2 * 1224942580) ^ -1902776152;
					continue;
				case 36u:
					RegisterReciever.smethod_54((Control)(object)this, bool_0: false);
					RegisterReciever.smethod_55((Control)(object)this);
					num = (int)(num2 * 1846786976) ^ -1243207355;
					continue;
				case 35u:
					RegisterReciever.smethod_18((Control)(object)GenderLbl, "GenderLbl");
					num = ((int)num2 * -1164346940) ^ -1834044481;
					continue;
				case 34u:
					RegisterReciever.smethod_20((Control)(object)MobileTxt, 2);
					num = (int)(num2 * 18647657) ^ -919928771;
					continue;
				case 33u:
					RegisterReciever.smethod_19((Control)(object)NameLbl, new Size(62, 18));
					num = ((int)num2 * -1945987019) ^ 0x90A679B;
					continue;
				case 32u:
					RegisterReciever.smethod_17((Control)(object)RegisterLbl, new Point(392, 63));
					num = (int)(num2 * 696261905) ^ -673886664;
					continue;
				case 31u:
					RegisterReciever.smethod_18((Control)(object)GenderTxt, "GenderTxt");
					num = (int)(num2 * 1160857593) ^ -1497733636;
					continue;
				case 30u:
					RegisterReciever.smethod_19((Control)(object)AgeTxt, new Size(124, 24));
					num = ((int)num2 * -2045996211) ^ -634759563;
					continue;
				case 29u:
					RegisterReciever.smethod_34((ButtonBase)(object)AddReceiptantBtn, Color.MidnightBlue);
					RegisterReciever.smethod_16((Control)(object)AddReceiptantBtn, RegisterReciever.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1038191778) ^ 0x7811CBD4);
					continue;
				case 28u:
					num = ((int)num2 * -961963243) ^ -114665490;
					continue;
				case 27u:
					GenderTxt = RegisterReciever.smethod_7();
					num = (int)((num2 * 1023477198) ^ 0x5447EE18);
					continue;
				case 26u:
					RegisterReciever.smethod_18((Control)(object)NameTxt, "NameTxt");
					RegisterReciever.smethod_19((Control)(object)NameTxt, new Size(355, 24));
					num = ((int)num2 * -1360462222) ^ 0x766BEE54;
					continue;
				case 25u:
					num = (int)((num2 * 53264763) ^ 0x4B3034B5);
					continue;
				case 24u:
					RegisterReciever.smethod_16((Control)(object)NameLbl, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1434468800) ^ 0x3AACCCBF);
					continue;
				case 23u:
					num = (int)(num2 * 1594339846) ^ -243183118;
					continue;
				case 22u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)MobileLbl);
					num = (int)(num2 * 183202882) ^ -1289284866;
					continue;
				case 21u:
					RegisterReciever.smethod_46((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1915843069) ^ 0x1F7F765;
					continue;
				case 20u:
					num = (int)((num2 * 1418069748) ^ 0xE149705);
					continue;
				case 19u:
					RegisterReciever.smethod_19((Control)(object)ClearBtn, new Size(148, 51));
					num = (int)((num2 * 1556423287) ^ 0x55CF4CCC);
					continue;
				case 18u:
					RegisterReciever.smethod_30((ListControl)(object)GenderTxt, bool_0: true);
					num = (int)((num2 * 734612663) ^ 0x5CE82FA6);
					continue;
				case 17u:
					num = (int)((num2 * 1408675672) ^ 0x781CCF16);
					continue;
				case 16u:
					RegisterReciever.smethod_16((Control)(object)DateLbl, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -371746195) ^ 0x76DC8FF7;
					continue;
				case 15u:
					RegisterReciever.smethod_17((Control)(object)PictureBox1, new Point(215, 26));
					num = ((int)num2 * -1242768374) ^ -512021886;
					continue;
				case 14u:
					RegisterReciever.smethod_19((Control)(object)DateLbl, new Size(138, 18));
					RegisterReciever.smethod_20((Control)(object)DateLbl, 15);
					num = ((int)num2 * -624368977) ^ -518754511;
					continue;
				case 13u:
					RegisterReciever.smethod_14(BloodGrpLbl, bool_0: true);
					num = ((int)num2 * -44490067) ^ -868379371;
					continue;
				case 12u:
					RegisterReciever.smethod_14(GenderLbl, bool_0: true);
					num = (int)((num2 * 1077969541) ^ 0x619D6BAA);
					continue;
				case 11u:
					RegisterReciever.smethod_12((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -2007371328) ^ -360800010;
					continue;
				case 10u:
					RegisterReciever.smethod_17((Control)(object)AgeLbl, new Point(33, 109));
					RegisterReciever.smethod_18((Control)(object)AgeLbl, "AgeLbl");
					num = (int)((num2 * 1467732975) ^ 0x70AD8FFF);
					continue;
				case 9u:
					RegisterReciever.smethod_20((Control)(object)RegisterLbl, 10);
					num = ((int)num2 * -1869165067) ^ -2106124335;
					continue;
				case 8u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)DateTxt);
					num = ((int)num2 * -1386382922) ^ -1475946943;
					continue;
				case 7u:
					num = (int)(num2 * 190462868) ^ -654661161;
					continue;
				case 6u:
					RegisterReciever.smethod_19((Control)(object)QuantityLbl, new Size(80, 18));
					num = ((int)num2 * -558383627) ^ 0x5E79C0E2;
					continue;
				case 5u:
					RegisterReciever.smethod_16((Control)(object)AgeTxt, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 2000431098) ^ -104149888;
					continue;
				case 4u:
					num = ((int)num2 * -228070568) ^ -580065483;
					continue;
				case 3u:
					num = ((int)num2 * -870785152) ^ 0x2F3786A8;
					continue;
				case 2u:
					RegisterReciever.smethod_36((ButtonBase)(object)AddReceiptantBtn, "Add Recieptant");
					num = ((int)num2 * -970208311) ^ -118845070;
					continue;
				case 1u:
					RegisterReciever.smethod_17((Control)(object)RecieverInfoGrp, new Point(215, 214));
					RegisterReciever.smethod_18((Control)(object)RecieverInfoGrp, "RecieverInfoGrp");
					RegisterReciever.smethod_19((Control)(object)RecieverInfoGrp, new Size(520, 454));
					num = (int)(num2 * 801692774) ^ -403329933;
					continue;
				case 0u:
					RegisterReciever.smethod_16((Control)(object)BloodGrpCombo, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 350785409) ^ -1691988160;
					continue;
				default:
					return;
				case 170u:
					break;
				case 137u:
					return;
				}
				break;
			}
		}
	}

	private void RegisterReciever_Load(object sender, EventArgs e)
	{
		RegisterReciever.smethod_61(myconnection, RegisterReciever.smethod_60(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
		while (true)
		{
			int num = -1301586775;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA8275126u) % 6u)
				{
				case 5u:
					RegisterReciever.smethod_63(BloodGrpCombo, 0);
					num = (int)(num2 * 1877880477) ^ -1638267207;
					continue;
				case 4u:
					num = ((int)num2 * -1187073737) ^ -102315465;
					continue;
				case 3u:
					num = ((int)num2 * -1013428617) ^ -1895416297;
					continue;
				case 2u:
					RegisterReciever.smethod_62(DateTxt, DateTime.Today.ToShortDateString());
					num = (int)(num2 * 654703536) ^ -1015625425;
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

	private void AddReceiptantBtn_Click(object sender, EventArgs e)
	{
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected I4, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected I4, but got Unknown
		//IL_0382: Incompatible stack heights: 0 vs 1
		//IL_039e: Incompatible stack heights: 0 vs 1
		//IL_03b9: Incompatible stack heights: 0 vs 1
		//IL_03c9: Incompatible stack heights: 0 vs 1
		//IL_0407: Incompatible stack heights: 0 vs 1
		//IL_0411: Incompatible stack heights: 0 vs 1
		if (!Validate_data())
		{
			goto IL_0028;
		}
		goto IL_0053;
		IL_0053:
		string string_ = "Insert Into [Recievers] ([Name],[Age],[Gender],[Blood Group],[Contact Number],[Blood Recieved],[Date of Recieve]) Values (?,?,?,?,?,?,?)";
		int num = -962069480;
		goto IL_002d;
		IL_002d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xBEB35731u) % 5u)
			{
			case 2u:
				RegisterReciever.smethod_64(myconnection);
				num = ((int)num2 * -940907494) ^ 0x58CF6F10;
				continue;
			case 0u:
				break;
			case 3u:
				goto IL_0053;
			default:
				try
				{
					OleDbCommand val = RegisterReciever.smethod_65(string_, myconnection);
					while (true)
					{
						int num3 = -1039875359;
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0xBEB35731u) % 17u)
							{
							case 16u:
								num3 = ((int)num2 * -815121907) ^ 0x4BA03EA1;
								continue;
							case 15u:
								RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: true);
								num3 = (int)(num2 * 327554200) ^ -1924609220;
								continue;
							case 14u:
								RegisterReciever.smethod_75((Component)(object)val);
								num3 = ((int)num2 * -1097647036) ^ 0x56C49E05;
								continue;
							case 13u:
								RegisterReciever.smethod_77(Timer1);
								num3 = ((int)num2 * -153528765) ^ 0x59755C18;
								continue;
							case 12u:
								RegisterReciever.smethod_47((Control)(object)SuccessMsg, Color.Green);
								num3 = ((int)num2 * -1443537758) ^ -513794685;
								continue;
							case 11u:
								num3 = ((int)num2 * -663561903) ^ -1856932862;
								continue;
							case 10u:
								RegisterReciever.smethod_76(myconnection);
								num3 = ((int)num2 * -832636768) ^ 0xB3BF7E7;
								continue;
							case 9u:
								num3 = ((int)num2 * -585497125) ^ 0x48CE3167;
								continue;
							case 8u:
								RegisterReciever.smethod_70(RegisterReciever.smethod_66(val), RegisterReciever.smethod_69("Blood Recieved", (object)RegisterReciever.smethod_67(QuantityTxt)));
								num3 = ((int)num2 * -221755933) ^ -1391178391;
								continue;
							case 7u:
								RegisterReciever.smethod_70(RegisterReciever.smethod_66(val), RegisterReciever.smethod_69("Date of Recieve", (object)RegisterReciever.smethod_67(DateTxt)));
								num3 = ((int)num2 * -990099079) ^ 0x1948E365;
								continue;
							case 6u:
								RegisterReciever.smethod_70(RegisterReciever.smethod_66(val), RegisterReciever.smethod_69("Blood Group", (object)RegisterReciever.smethod_72(BloodGrpCombo)));
								RegisterReciever.smethod_70(RegisterReciever.smethod_66(val), RegisterReciever.smethod_69("Contact Number", (object)RegisterReciever.smethod_73(RegisterReciever.smethod_67(MobileTxt))));
								num3 = (int)((num2 * 851183136) ^ 0x5A8D669E);
								continue;
							case 4u:
								RegisterReciever.smethod_74(val);
								num3 = (int)(num2 * 91592474) ^ -494896506;
								continue;
							case 3u:
								RegisterReciever.smethod_70(RegisterReciever.smethod_66(val), RegisterReciever.smethod_69("Age", (object)(int)RegisterReciever.smethod_71(RegisterReciever.smethod_67(AgeTxt))));
								RegisterReciever.smethod_70(RegisterReciever.smethod_66(val), RegisterReciever.smethod_69("Gender", (object)RegisterReciever.smethod_68(RegisterReciever.smethod_72(GenderTxt))));
								num3 = (int)((num2 * 476360929) ^ 0x64242D32);
								continue;
							case 1u:
								RegisterReciever.smethod_70(RegisterReciever.smethod_66(val), RegisterReciever.smethod_69("Name", (object)RegisterReciever.smethod_68(RegisterReciever.smethod_67(NameTxt))));
								num3 = ((int)num2 * -1684037375) ^ 0x576FF665;
								continue;
							case 0u:
								RegisterReciever.smethod_21(SuccessMsg, "Reciever Successfully Registered !!");
								num3 = (int)(num2 * 1563469819) ^ -862639675;
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
				catch (Exception exception_)
				{
					RegisterReciever.smethod_78(exception_);
					while (true)
					{
						_ = -922958560;
						while (true)
						{
							_003F val2 = /*Error near IL_0349: Stack underflow*/^ -1095542991;
							num2 = (uint)(int)val2;
							switch (val2 % 7)
							{
							case 6:
								_ = ((int)num2 * -126690811) ^ 0x35F575A3;
								continue;
							case 4:
								RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: true);
								_ = ((int)num2 * -124093607) ^ -2128740984;
								continue;
							case 2:
								RegisterReciever.smethod_76(myconnection);
								_ = ((int)num2 * -1400695144) ^ -1157943504;
								continue;
							case 1:
								_ = ((int)num2 * -1194458875) ^ 0x57120B41;
								continue;
							case 0:
								RegisterReciever.smethod_21(SuccessMsg, "Invalid Credentials");
								RegisterReciever.smethod_47((Control)(object)SuccessMsg, Color.Red);
								RegisterReciever.smethod_77(Timer1);
								_ = (num2 * 1319371572) ^ 0xB7CCE7D2u;
								continue;
							case 3:
								break;
							default:
								RegisterReciever.smethod_79();
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
		goto IL_0028;
		IL_0028:
		num = -219900428;
		goto IL_002d;
	}

	private bool Validate_data()
	{
		bool flag = !MyProject.Forms.Form1.Name_Validation(RegisterReciever.smethod_68(RegisterReciever.smethod_67(NameTxt)));
		bool flag4 = default(bool);
		bool flag3 = default(bool);
		bool result = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1169914193;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE0217FB0u) % 44u)
				{
				case 43u:
					flag4 = !MyProject.Forms.Form1.Gender_Validator(RegisterReciever.smethod_68(RegisterReciever.smethod_72(GenderTxt)));
					num = (int)(num2 * 1576813235) ^ -906575704;
					continue;
				case 42u:
					num = (int)(num2 * 1544449687) ^ -1268522559;
					continue;
				case 41u:
					RegisterReciever.smethod_21(SuccessMsg, "Invalid Gender");
					num = (int)((num2 * 1891402170) ^ 0x5CBC847B);
					continue;
				case 40u:
				{
					int num9;
					int num10;
					if (flag3)
					{
						num9 = -940920915;
						num10 = -940920915;
					}
					else
					{
						num9 = -510736556;
						num10 = -510736556;
					}
					num = num9 ^ (int)(num2 * 1092012486);
					continue;
				}
				case 39u:
					RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -1099819619) ^ 0x36C9A4FF;
					continue;
				case 38u:
					RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: true);
					RegisterReciever.smethod_21(SuccessMsg, "Select Proper Blood Group");
					num = ((int)num2 * -2037872917) ^ -1018848529;
					continue;
				case 37u:
					num = (int)((num2 * 2046586679) ^ 0x4E3AD5FB);
					continue;
				case 35u:
					num = -1460764374;
					continue;
				case 34u:
					num = ((int)num2 * -988316022) ^ 0x70FB9413;
					continue;
				case 33u:
					RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: true);
					RegisterReciever.smethod_21(SuccessMsg, "Invalid Mobile Number");
					num = ((int)num2 * -298556565) ^ 0x377E035C;
					continue;
				case 32u:
					result = true;
					num = -419347516;
					continue;
				case 31u:
					num = (int)((num2 * 918105412) ^ 0x718FC4B6);
					continue;
				case 30u:
					RegisterReciever.smethod_47((Control)(object)SuccessMsg, Color.Red);
					RegisterReciever.smethod_77(Timer1);
					num = ((int)num2 * -1414808430) ^ -621350383;
					continue;
				case 29u:
				{
					int num11;
					int num12;
					if (flag4)
					{
						num11 = -226033185;
						num12 = -226033185;
					}
					else
					{
						num11 = -930360987;
						num12 = -930360987;
					}
					num = num11 ^ (int)(num2 * 1881590241);
					continue;
				}
				case 28u:
					flag2 = !MyProject.Forms.Form1.Mobile_Validator(RegisterReciever.smethod_67(MobileTxt));
					num = -210427243;
					continue;
				case 27u:
					num = -1915806357;
					continue;
				case 26u:
					flag3 = !MyProject.Forms.Form1.Decimal_Validator(RegisterReciever.smethod_67(QuantityTxt));
					num = ((int)num2 * -1119345765) ^ 0x23E9A802;
					continue;
				case 25u:
					RegisterReciever.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -488721397) ^ -909201871;
					continue;
				case 24u:
					num = (int)(num2 * 410179879) ^ -1096416360;
					continue;
				case 23u:
					RegisterReciever.smethod_77(Timer1);
					num = ((int)num2 * -1541816688) ^ 0x3E0B6712;
					continue;
				case 22u:
					result = false;
					num = (int)((num2 * 1051595109) ^ 0xEA91E9E);
					continue;
				case 21u:
					RegisterReciever.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = (int)(num2 * 911772221) ^ -1925174355;
					continue;
				case 20u:
					RegisterReciever.smethod_77(Timer1);
					result = false;
					num = ((int)num2 * -416024968) ^ -198923740;
					continue;
				case 19u:
					result = false;
					num = ((int)num2 * -2076729857) ^ 0x3D5D66A0;
					continue;
				case 18u:
					RegisterReciever.smethod_21(SuccessMsg, "Invalid Name");
					num = (int)((num2 * 1412298467) ^ 0x64016144);
					continue;
				case 17u:
					num = (int)((num2 * 196151011) ^ 0x2758FE5B);
					continue;
				case 15u:
					RegisterReciever.smethod_77(Timer1);
					result = false;
					num = ((int)num2 * -1304005396) ^ -672044384;
					continue;
				case 14u:
				{
					int num8;
					if (RegisterReciever.smethod_80(BloodGrpCombo) == 0)
					{
						num = -1556481334;
						num8 = -1556481334;
					}
					else
					{
						num = -1115868261;
						num8 = -1115868261;
					}
					continue;
				}
				case 13u:
					num = ((int)num2 * -369358611) ^ -619442318;
					continue;
				case 12u:
				{
					int num7;
					if (MyProject.Forms.Form1.age_validator(RegisterReciever.smethod_67(AgeTxt)))
					{
						num = -446542601;
						num7 = -446542601;
					}
					else
					{
						num = -750105797;
						num7 = -750105797;
					}
					continue;
				}
				case 11u:
					num = (int)(num2 * 1612125696) ^ -1871990746;
					continue;
				case 10u:
					RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -1098513654) ^ 0x638E7CAF;
					continue;
				case 9u:
					RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: true);
					RegisterReciever.smethod_21(SuccessMsg, "Invalid Quantity");
					num = (int)(num2 * 543922127) ^ -382124870;
					continue;
				case 8u:
					RegisterReciever.smethod_21(SuccessMsg, "Invalid Age");
					num = ((int)num2 * -2064590016) ^ -2027974536;
					continue;
				case 7u:
					RegisterReciever.smethod_47((Control)(object)SuccessMsg, Color.Red);
					RegisterReciever.smethod_77(Timer1);
					num = (int)((num2 * 562322069) ^ 0x350BE48C);
					continue;
				case 6u:
					RegisterReciever.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -790119439) ^ 0x75FF42A8;
					continue;
				case 5u:
					result = false;
					num = (int)(num2 * 1950934699) ^ -1027443102;
					continue;
				case 4u:
					RegisterReciever.smethod_77(Timer1);
					result = false;
					num = (int)(num2 * 2045997366) ^ -1038437308;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 68264840;
						num6 = 68264840;
					}
					else
					{
						num5 = 1546892846;
						num6 = 1546892846;
					}
					num = num5 ^ ((int)num2 * -1992095518);
					continue;
				}
				case 2u:
					RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: true);
					num = (int)((num2 * 263559227) ^ 0x28771DD3);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = -1418905936;
						num4 = -1418905936;
					}
					else
					{
						num3 = -1248529373;
						num4 = -1248529373;
					}
					num = num3 ^ ((int)num2 * -189918975);
					continue;
				}
				case 0u:
					RegisterReciever.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -1033506114) ^ -1523335228;
					continue;
				case 16u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private void ClearBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1937743640;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3181C33Fu) % 9u)
				{
				case 8u:
					RegisterReciever.smethod_63(GenderTxt, -1);
					num = (int)((num2 * 574066274) ^ 0x2B73B4F8);
					continue;
				case 7u:
					RegisterReciever.smethod_81((TextBoxBase)(object)MobileTxt);
					num = ((int)num2 * -687701791) ^ -551019232;
					continue;
				case 5u:
					RegisterReciever.smethod_62(DateTxt, RegisterReciever.smethod_82((object)DateTime.Now, "dd-MM-yyyy"));
					num = ((int)num2 * -1325659062) ^ 0x3BBCFF68;
					continue;
				case 4u:
					num = (int)((num2 * 971449112) ^ 0x1131BCEB);
					continue;
				case 3u:
					RegisterReciever.smethod_81((TextBoxBase)(object)QuantityTxt);
					num = ((int)num2 * -1639875181) ^ -1990199504;
					continue;
				case 2u:
					num = ((int)num2 * -986931179) ^ 0x5048C6FA;
					continue;
				case 1u:
					RegisterReciever.smethod_81((TextBoxBase)(object)NameTxt);
					RegisterReciever.smethod_81((TextBoxBase)(object)AgeTxt);
					num = ((int)num2 * -1810646318) ^ 0x2A1744B0;
					continue;
				case 0u:
					break;
				default:
					RegisterReciever.smethod_63(BloodGrpCombo, 0);
					return;
				}
				break;
			}
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: false);
		while (true)
		{
			int num = 1800737741;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x36331BC8u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -118753084) ^ 0x555AC49C;
					continue;
				case 1u:
					RegisterReciever.smethod_83(Timer1);
					num = (int)(num2 * 1300020319) ^ -730963599;
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

	static void smethod_14(Label label_0, bool bool_0)
	{
		label_0.set_AutoSize(bool_0);
	}

	static Font smethod_15(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_16(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_17(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_18(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_19(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_20(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_21(Label label_0, string string_0)
	{
		label_0.set_Text(string_0);
	}

	static void smethod_22(Label label_0, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_TextAlign(contentAlignment_0);
	}

	static ControlCollection smethod_23(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_24(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_25(GroupBox groupBox_0, bool bool_0)
	{
		groupBox_0.set_TabStop(bool_0);
	}

	static void smethod_26(GroupBox groupBox_0, string string_0)
	{
		groupBox_0.set_Text(string_0);
	}

	static Color smethod_27()
	{
		return SystemColors.ButtonHighlight;
	}

	static void smethod_28(ComboBox comboBox_0, Color color_0)
	{
		comboBox_0.set_BackColor(color_0);
	}

	static void smethod_29(ComboBox comboBox_0, ComboBoxStyle comboBoxStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		comboBox_0.set_DropDownStyle(comboBoxStyle_0);
	}

	static void smethod_30(ListControl listControl_0, bool bool_0)
	{
		listControl_0.set_FormattingEnabled(bool_0);
	}

	static ObjectCollection smethod_31(ComboBox comboBox_0)
	{
		return comboBox_0.get_Items();
	}

	static void smethod_32(ObjectCollection objectCollection_0, object[] object_0)
	{
		objectCollection_0.AddRange(object_0);
	}

	static void smethod_33(TextBoxBase textBoxBase_0, bool bool_0)
	{
		textBoxBase_0.set_ReadOnly(bool_0);
	}

	static void smethod_34(ButtonBase buttonBase_0, Color color_0)
	{
		buttonBase_0.set_BackColor(color_0);
	}

	static void smethod_35(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
	}

	static void smethod_36(ButtonBase buttonBase_0, string string_0)
	{
		buttonBase_0.set_Text(string_0);
	}

	static void smethod_37(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_38(Timer timer_0, bool bool_0)
	{
		timer_0.set_Enabled(bool_0);
	}

	static void smethod_39(Timer timer_0, int int_0)
	{
		timer_0.set_Interval(int_0);
	}

	static void smethod_40(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static void smethod_41(PictureBox pictureBox_0, Image image_0)
	{
		pictureBox_0.set_Image(image_0);
	}

	static void smethod_42(PictureBox pictureBox_0, PictureBoxSizeMode pictureBoxSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		pictureBox_0.set_SizeMode(pictureBoxSizeMode_0);
	}

	static void smethod_43(PictureBox pictureBox_0, int int_0)
	{
		pictureBox_0.set_TabIndex(int_0);
	}

	static void smethod_44(PictureBox pictureBox_0, bool bool_0)
	{
		pictureBox_0.set_TabStop(bool_0);
	}

	static void smethod_45(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_46(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_47(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static ControlCollection smethod_48(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_49(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_50(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_51(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_52(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_53(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_54(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_55(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_56(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_57(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_58(Timer timer_0, EventHandler eventHandler_0)
	{
		timer_0.remove_Tick(eventHandler_0);
	}

	static void smethod_59(Timer timer_0, EventHandler eventHandler_0)
	{
		timer_0.add_Tick(eventHandler_0);
	}

	static string smethod_60(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_61(OleDbConnection oleDbConnection_0, string string_0)
	{
		oleDbConnection_0.set_ConnectionString(string_0);
	}

	static void smethod_62(TextBox textBox_0, string string_0)
	{
		textBox_0.set_Text(string_0);
	}

	static void smethod_63(ComboBox comboBox_0, int int_0)
	{
		comboBox_0.set_SelectedIndex(int_0);
	}

	static void smethod_64(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Open();
	}

	static OleDbCommand smethod_65(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbCommand(string_0, oleDbConnection_0);
	}

	static OleDbParameterCollection smethod_66(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.get_Parameters();
	}

	static string smethod_67(TextBox textBox_0)
	{
		return textBox_0.get_Text();
	}

	static string smethod_68(string string_0)
	{
		return string_0.ToLower();
	}

	static OleDbParameter smethod_69(string string_0, object object_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbParameter(string_0, object_0);
	}

	static OleDbParameter smethod_70(OleDbParameterCollection oleDbParameterCollection_0, OleDbParameter oleDbParameter_0)
	{
		return oleDbParameterCollection_0.Add(oleDbParameter_0);
	}

	static short smethod_71(string string_0)
	{
		return Convert.ToInt16(string_0);
	}

	static string smethod_72(ComboBox comboBox_0)
	{
		return comboBox_0.get_Text();
	}

	static string smethod_73(string string_0)
	{
		return string_0.ToString();
	}

	static int smethod_74(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.ExecuteNonQuery();
	}

	static void smethod_75(Component component_0)
	{
		component_0.Dispose();
	}

	static void smethod_76(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Close();
	}

	static void smethod_77(Timer timer_0)
	{
		timer_0.Start();
	}

	static void smethod_78(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_79()
	{
		ProjectData.ClearProjectError();
	}

	static int smethod_80(ComboBox comboBox_0)
	{
		return comboBox_0.get_SelectedIndex();
	}

	static void smethod_81(TextBoxBase textBoxBase_0)
	{
		textBoxBase_0.Clear();
	}

	static string smethod_82(object object_0, string string_0)
	{
		return Strings.Format(object_0, string_0);
	}

	static void smethod_83(Timer timer_0)
	{
		timer_0.Stop();
	}
}
