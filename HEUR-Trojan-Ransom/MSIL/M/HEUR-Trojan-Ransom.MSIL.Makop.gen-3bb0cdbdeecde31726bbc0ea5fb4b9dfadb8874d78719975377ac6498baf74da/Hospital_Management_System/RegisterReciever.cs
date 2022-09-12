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
			while (true)
			{
				int num = -189772913;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB10F09CDu) % 7u)
					{
					case 5u:
						_AddReceiptantBtn = value;
						addReceiptantBtn = _AddReceiptantBtn;
						num = -1916914492;
						continue;
					case 4u:
					{
						int num5;
						int num6;
						if (addReceiptantBtn == null)
						{
							num5 = -1570278333;
							num6 = -1570278333;
						}
						else
						{
							num5 = -286508545;
							num6 = -286508545;
						}
						num = num5 ^ (int)(num2 * 178334842);
						continue;
					}
					case 3u:
						RegisterReciever.smethod_57((Control)(object)addReceiptantBtn, eventHandler_);
						num = (int)(num2 * 1401741359) ^ -470210704;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (addReceiptantBtn == null)
						{
							num3 = -550979196;
							num4 = -550979196;
						}
						else
						{
							num3 = -437555463;
							num4 = -437555463;
						}
						num = num3 ^ ((int)num2 * -170547020);
						continue;
					}
					case 1u:
						RegisterReciever.smethod_56((Control)(object)addReceiptantBtn, eventHandler_);
						num = (int)(num2 * 170391257) ^ -738738847;
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
				int num = 372981400;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1D196DC1u) % 9u)
					{
					case 7u:
						_ClearBtn = value;
						num = 852311216;
						continue;
					case 6u:
						clearBtn = _ClearBtn;
						num = ((int)num2 * -1726751282) ^ 0x5BC4F579;
						continue;
					case 5u:
					{
						int num5;
						int num6;
						if (clearBtn == null)
						{
							num5 = -173839495;
							num6 = -173839495;
						}
						else
						{
							num5 = -1690935751;
							num6 = -1690935751;
						}
						num = num5 ^ ((int)num2 * -1195476617);
						continue;
					}
					case 4u:
						clearBtn = _ClearBtn;
						num = (int)((num2 * 233416457) ^ 0x76C1E55E);
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (clearBtn == null)
						{
							num3 = 1676303230;
							num4 = 1676303230;
						}
						else
						{
							num3 = 268767173;
							num4 = 268767173;
						}
						num = num3 ^ (int)(num2 * 664275132);
						continue;
					}
					case 1u:
						RegisterReciever.smethod_57((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -1364494559) ^ 0x6E1092FA;
						continue;
					case 0u:
						RegisterReciever.smethod_56((Control)(object)clearBtn, eventHandler_);
						num = (int)(num2 * 1368201385) ^ -682506223;
						continue;
					default:
						return;
					case 8u:
						break;
					case 2u:
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
			Timer timer = _Timer1;
			while (true)
			{
				int num = -1264408451;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x89A51EFCu) % 7u)
					{
					case 6u:
					{
						timer = _Timer1;
						int num5;
						int num6;
						if (timer != null)
						{
							num5 = -918110148;
							num6 = -918110148;
						}
						else
						{
							num5 = -151852217;
							num6 = -151852217;
						}
						num = num5 ^ (int)(num2 * 885349189);
						continue;
					}
					case 5u:
						_Timer1 = value;
						num = -508236634;
						continue;
					case 4u:
						RegisterReciever.smethod_59(timer, eventHandler_);
						num = (int)((num2 * 228244293) ^ 0x33C8E40F);
						continue;
					case 2u:
						RegisterReciever.smethod_58(timer, eventHandler_);
						num = (int)((num2 * 277593351) ^ 0x56A3D415);
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (timer == null)
						{
							num3 = -1610176814;
							num4 = -1610176814;
						}
						else
						{
							num3 = -1964567267;
							num4 = -1964567267;
						}
						num = num3 ^ ((int)num2 * -150615622);
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
			int num = 450947014;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1734A4E1u) % 6u)
				{
				case 5u:
					myconnection = RegisterReciever.smethod_1();
					InitializeComponent();
					num = (int)(num2 * 679152133) ^ -84983342;
					continue;
				case 4u:
					num = (int)(num2 * 304150752) ^ -1170721354;
					continue;
				case 1u:
					RegisterReciever.smethod_0((UserControl)(object)this, (EventHandler)RegisterReciever_Load);
					num = ((int)num2 * -1655437002) ^ 0x7C975AD5;
					continue;
				case 0u:
					num = ((int)num2 * -1906125543) ^ -1360468498;
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

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing)
			{
				goto IL_0066;
			}
			int num = 0;
			goto IL_00a1;
			IL_00a1:
			bool flag = (byte)num != 0;
			int num2 = -447279564;
			goto IL_006b;
			IL_0066:
			num2 = -1540062137;
			goto IL_006b;
			IL_006b:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xF7357552u) % 7u)
				{
				case 4u:
					num2 = (int)(num3 * 1904511728) ^ -779017872;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -876967629;
						num5 = -876967629;
					}
					else
					{
						num4 = -1243395088;
						num5 = -1243395088;
					}
					num2 = num4 ^ (int)(num3 * 1506215710);
					continue;
				}
				case 2u:
					num2 = ((int)num3 * -1623049743) ^ 0x57FA2FF6;
					continue;
				case 1u:
					RegisterReciever.smethod_2((IDisposable)components);
					num2 = ((int)num3 * -1806357100) ^ 0x33FB56B;
					continue;
				case 0u:
					break;
				default:
					return;
				case 6u:
					goto IL_0098;
				case 5u:
					return;
				}
				break;
			}
			goto IL_0066;
			IL_0098:
			num = ((components != null) ? 1 : 0);
			goto IL_00a1;
		}
		finally
		{
			while (true)
			{
				IL_00df:
				int num6 = -895505332;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0xF7357552u) % 3u)
					{
					case 1u:
						goto IL_00ae;
					default:
						goto end_IL_00c2;
					case 2u:
						break;
					case 0u:
						goto end_IL_00c2;
					}
					goto IL_00df;
					IL_00ae:
					((ContainerControl)this).Dispose(disposing);
					num6 = (int)(num3 * 716303011) ^ -339515392;
					continue;
					end_IL_00c2:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		components = RegisterReciever.smethod_3();
		while (true)
		{
			int num = 752748726;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x212A71D9u) % 259u)
				{
				case 258u:
					RegisterReciever.smethod_17((Control)(object)MobileLbl, new Point(33, 163));
					num = ((int)num2 * -1222341702) ^ -1612512422;
					continue;
				case 257u:
					RegisterReciever.smethod_21(AgeLbl, "Age :");
					num = (int)(num2 * 1613086081) ^ -1110082378;
					continue;
				case 256u:
					num = (int)(num2 * 1570915490) ^ -1451191745;
					continue;
				case 255u:
					num = ((int)num2 * -827239339) ^ -330000955;
					continue;
				case 254u:
					RegisterReciever.smethod_16((Control)(object)RegisterLbl, RegisterReciever.smethod_15("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 952582968) ^ 0x112FA9DC);
					continue;
				case 253u:
					RegisterReciever.smethod_19((Control)(object)GenderLbl, new Size(73, 18));
					num = (int)(num2 * 1045381857) ^ -531056409;
					continue;
				case 252u:
					NameLbl = RegisterReciever.smethod_4();
					num = ((int)num2 * -516371214) ^ -255459604;
					continue;
				case 251u:
					RegisterReciever.smethod_47((Control)(object)this, Color.White);
					num = (int)(num2 * 2111163199) ^ -199221457;
					continue;
				case 250u:
					num = (int)(num2 * 141320980) ^ -892994750;
					continue;
				case 249u:
					num = (int)((num2 * 1203187784) ^ 0x6064F56F);
					continue;
				case 248u:
					RegisterReciever.smethod_16((Control)(object)AgeLbl, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1545769451) ^ -1964397225;
					continue;
				case 247u:
					num = ((int)num2 * -301146330) ^ 0x788D661A;
					continue;
				case 246u:
					RegisterReciever.smethod_17((Control)(object)SuccessMsg, new Point(311, 166));
					RegisterReciever.smethod_18((Control)(object)SuccessMsg, "SuccessMsg");
					num = ((int)num2 * -17564239) ^ -522329784;
					continue;
				case 245u:
					RegisterReciever.smethod_17((Control)(object)RegisterLbl, new Point(392, 63));
					RegisterReciever.smethod_18((Control)(object)RegisterLbl, "RegisterLbl");
					num = (int)(num2 * 1079247265) ^ -384114177;
					continue;
				case 244u:
					RegisterReciever.smethod_21(GenderLbl, "Gender :");
					RegisterReciever.smethod_22(GenderLbl, (ContentAlignment)32);
					num = (int)(num2 * 1611678562) ^ -682111621;
					continue;
				case 243u:
					RegisterReciever.smethod_16((Control)(object)MobileLbl, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 753952862) ^ -2062126290;
					continue;
				case 242u:
					RegisterReciever.smethod_17((Control)(object)AddReceiptantBtn, new Point(587, 674));
					num = ((int)num2 * -454513747) ^ -127198112;
					continue;
				case 241u:
					RegisterReciever.smethod_20((Control)(object)AgeLbl, 13);
					num = ((int)num2 * -947701260) ^ 0x1048E955;
					continue;
				case 240u:
					PictureBox1 = RegisterReciever.smethod_10();
					num = (int)(num2 * 1602019356) ^ -1395578525;
					continue;
				case 239u:
					RegisterReciever.smethod_18((Control)(object)MobileTxt, "MobileTxt");
					num = (int)((num2 * 1315209336) ^ 0x79CD6AC3);
					continue;
				case 238u:
					RegisterReciever.smethod_21(DateLbl, "Recieptant Date :");
					num = ((int)num2 * -261299434) ^ 0x4E68A409;
					continue;
				case 237u:
					RegisterReciever.smethod_22(BloodGrpLbl, (ContentAlignment)32);
					num = (int)(num2 * 507797726) ^ -1744027661;
					continue;
				case 236u:
					num = (int)((num2 * 1390546094) ^ 0x8CEBDFD);
					continue;
				case 235u:
					num = ((int)num2 * -1110234148) ^ 0x6C39B389;
					continue;
				case 234u:
					num = ((int)num2 * -1948048880) ^ 0xF4097BE;
					continue;
				case 233u:
					num = (int)(num2 * 1078376279) ^ -2097946948;
					continue;
				case 232u:
					QuantityLbl = RegisterReciever.smethod_4();
					BloodGrpCombo = RegisterReciever.smethod_7();
					num = ((int)num2 * -1994860813) ^ 0x11F20F7A;
					continue;
				case 231u:
					RegisterReciever.smethod_19((Control)(object)MobileLbl, new Size(68, 18));
					RegisterReciever.smethod_20((Control)(object)MobileLbl, 8);
					num = ((int)num2 * -1556729872) ^ 0x633B021B;
					continue;
				case 230u:
					num = (int)(num2 * 2088826497) ^ -1064490133;
					continue;
				case 229u:
					num = ((int)num2 * -2111158065) ^ -1557600448;
					continue;
				case 228u:
					num = (int)((num2 * 1879488139) ^ 0x16EE37F3);
					continue;
				case 227u:
					RegisterReciever.smethod_17((Control)(object)MobileTxt, new Point(135, 156));
					num = ((int)num2 * -1362404229) ^ -2138789006;
					continue;
				case 226u:
					num = ((int)num2 * -461223606) ^ -1955217643;
					continue;
				case 225u:
					RegisterReciever.smethod_20((Control)(object)NameLbl, 5);
					num = ((int)num2 * -855356383) ^ -1623427547;
					continue;
				case 224u:
					RegisterReciever.smethod_17((Control)(object)Label1, new Point(240, 268));
					num = ((int)num2 * -90936582) ^ 0x13919FA0;
					continue;
				case 223u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)BloodGrpLbl);
					num = ((int)num2 * -1839312870) ^ 0x32278B93;
					continue;
				case 222u:
					RegisterReciever.smethod_21(QuantityLbl, "Quantity :");
					num = ((int)num2 * -191237575) ^ 0x2B95AEB8;
					continue;
				case 221u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)DateLbl);
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)GenderTxt);
					num = ((int)num2 * -1441018985) ^ -1713742993;
					continue;
				case 220u:
					RegisterReciever.smethod_16((Control)(object)ClearBtn, RegisterReciever.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 203622796) ^ -996250810;
					continue;
				case 219u:
					RegisterReciever.smethod_44(PictureBox1, bool_0: false);
					num = ((int)num2 * -681169821) ^ -1573439152;
					continue;
				case 218u:
					RegisterReciever.smethod_18((Control)(object)ClearBtn, "ClearBtn");
					num = (int)((num2 * 946060200) ^ 0x702B54CB);
					continue;
				case 217u:
					RegisterReciever.smethod_17((Control)(object)BloodGrpCombo, new Point(186, 213));
					num = (int)((num2 * 1455655198) ^ 0x184F27E0);
					continue;
				case 216u:
					BloodGrpLbl = RegisterReciever.smethod_4();
					num = (int)(num2 * 1823760708) ^ -1058529010;
					continue;
				case 215u:
					num = (int)((num2 * 1563776380) ^ 0x20DC4407);
					continue;
				case 214u:
					RegisterReciever.smethod_16((Control)(object)Label1, RegisterReciever.smethod_15("MS Reference Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					RegisterReciever.smethod_35((Control)(object)Label1, Color.Red);
					num = (int)((num2 * 1326380577) ^ 0x28C6CD00);
					continue;
				case 213u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)AgeLbl);
					num = (int)(num2 * 1495297577) ^ -359951302;
					continue;
				case 212u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)MobileTxt);
					num = ((int)num2 * -1551476044) ^ -937748108;
					continue;
				case 211u:
					RegisterReciever.smethod_16((Control)(object)GenderLbl, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -629202941) ^ 0xD784E56;
					continue;
				case 210u:
					RegisterReciever.smethod_20((Control)(object)AddReceiptantBtn, 13);
					num = (int)((num2 * 1039624951) ^ 0x59DC4B8);
					continue;
				case 209u:
					num = (int)(num2 * 498289918) ^ -1950110782;
					continue;
				case 208u:
					RegisterReciever.smethod_22(NameLbl, (ContentAlignment)32);
					num = (int)((num2 * 1205306275) ^ 0x2F429E25);
					continue;
				case 207u:
					RegisterReciever.smethod_18((Control)(object)QuantityLbl, "QuantityLbl");
					num = (int)((num2 * 1470057111) ^ 0x73C2A1FE);
					continue;
				case 206u:
					AgeLbl = RegisterReciever.smethod_4();
					num = (int)((num2 * 90785580) ^ 0xA27BEC2);
					continue;
				case 205u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)QuantityLbl);
					num = (int)((num2 * 1648914739) ^ 0x7FEDF5F9);
					continue;
				case 204u:
					RegisterReciever.smethod_20((Control)(object)MobileTxt, 2);
					num = ((int)num2 * -823725104) ^ 0x7F902AA3;
					continue;
				case 203u:
					RegisterReciever.smethod_34((ButtonBase)(object)AddReceiptantBtn, Color.MidnightBlue);
					num = (int)((num2 * 1646086232) ^ 0x4A654C16);
					continue;
				case 202u:
					RegisterReciever.smethod_16((Control)(object)DateLbl, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 90031017) ^ 0x2C7C77FF);
					continue;
				case 201u:
					RegisterReciever.smethod_17((Control)(object)PictureBox1, new Point(215, 26));
					RegisterReciever.smethod_18((Control)(object)PictureBox1, "PictureBox1");
					RegisterReciever.smethod_19((Control)(object)PictureBox1, new Size(171, 126));
					num = (int)((num2 * 2071777899) ^ 0x604E756C);
					continue;
				case 200u:
					num = (int)((num2 * 1638222673) ^ 0x25D5A5A4);
					continue;
				case 199u:
					num = ((int)num2 * -1922910215) ^ 0xEAB454C;
					continue;
				case 198u:
					RegisterReciever.smethod_22(AgeLbl, (ContentAlignment)32);
					num = ((int)num2 * -1371053478) ^ -1072851621;
					continue;
				case 197u:
					RegisterReciever.smethod_19((Control)(object)AgeLbl, new Size(46, 18));
					num = (int)(num2 * 2006117460) ^ -1452031633;
					continue;
				case 196u:
					RegisterReciever.smethod_18((Control)(object)Label1, "Label1");
					num = ((int)num2 * -1060372537) ^ -1376628284;
					continue;
				case 195u:
					num = ((int)num2 * -495044603) ^ 0x144D02A3;
					continue;
				case 194u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_48((Control)(object)this), (Control)(object)RegisterLbl);
					num = (int)((num2 * 786439942) ^ 0x4F840DB);
					continue;
				case 193u:
					RegisterReciever.smethod_14(NameLbl, bool_0: true);
					RegisterReciever.smethod_16((Control)(object)NameLbl, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1079528386) ^ 0x659E592B;
					continue;
				case 192u:
					RegisterReciever.smethod_19((Control)(object)AddReceiptantBtn, new Size(148, 51));
					num = (int)(num2 * 1703470930) ^ -362598601;
					continue;
				case 191u:
					RegisterReciever.smethod_20((Control)(object)QuantityLbl, 21);
					num = (int)((num2 * 1382887687) ^ 0x66464BC);
					continue;
				case 190u:
					RegisterReciever.smethod_12((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -1421160690) ^ -982806274;
					continue;
				case 189u:
					RegisterReciever.smethod_19((Control)(object)SuccessMsg, new Size(339, 45));
					num = ((int)num2 * -70711574) ^ 0x71429C01;
					continue;
				case 188u:
					RegisterReciever.smethod_19((Control)(object)Label1, new Size(84, 18));
					num = ((int)num2 * -1944466726) ^ -781147891;
					continue;
				case 187u:
					RegisterReciever.smethod_46((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 1728966926) ^ 0x66B3275F);
					continue;
				case 186u:
					num = ((int)num2 * -1509974900) ^ -1149289087;
					continue;
				case 185u:
					RegisterReciever.smethod_26(RecieverInfoGrp, "Receiver Information");
					RegisterReciever.smethod_17((Control)(object)QuantityTxt, new Point(135, 262));
					num = ((int)num2 * -1625225652) ^ 0x708D699B;
					continue;
				case 184u:
					RegisterReciever.smethod_19((Control)(object)RegisterLbl, new Size(282, 35));
					num = ((int)num2 * -562504016) ^ -1177401764;
					continue;
				case 183u:
					RegisterReciever.smethod_22(RegisterLbl, (ContentAlignment)32);
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)Label1);
					num = ((int)num2 * -1906761408) ^ -1783669191;
					continue;
				case 182u:
					num = (int)(num2 * 34452084) ^ -1400599367;
					continue;
				case 181u:
					RegisterReciever.smethod_18((Control)(object)NameTxt, "NameTxt");
					RegisterReciever.smethod_19((Control)(object)NameTxt, new Size(355, 24));
					num = ((int)num2 * -1079568212) ^ 0x1E3A77BE;
					continue;
				case 180u:
					num = ((int)num2 * -1176019590) ^ -2129354736;
					continue;
				case 179u:
					RegisterReciever.smethod_33((TextBoxBase)(object)DateTxt, bool_0: true);
					num = ((int)num2 * -1751908974) ^ -1811663049;
					continue;
				case 178u:
					num = (int)((num2 * 276889262) ^ 0x332429F3);
					continue;
				case 177u:
					num = (int)((num2 * 677687462) ^ 0x6BD2889D);
					continue;
				case 176u:
					RegisterReciever.smethod_17((Control)(object)DateTxt, new Point(205, 382));
					num = (int)(num2 * 1917512326) ^ -1231877236;
					continue;
				case 175u:
					RegisterReciever.smethod_16((Control)(object)GenderTxt, RegisterReciever.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1896441817) ^ -779042255;
					continue;
				case 174u:
					num = ((int)num2 * -689302477) ^ 0x56B55B83;
					continue;
				case 173u:
					RegisterReciever.smethod_19((Control)(object)BloodGrpLbl, new Size(114, 18));
					num = (int)((num2 * 1013578764) ^ 0x4A8E5BA3);
					continue;
				case 172u:
					num = (int)(num2 * 1388703119) ^ -1472221046;
					continue;
				case 171u:
					RegisterReciever.smethod_53((ISupportInitialize)PictureBox1);
					RegisterReciever.smethod_54((Control)(object)this, bool_0: false);
					num = (int)((num2 * 822424029) ^ 0x31B71A0B);
					continue;
				case 170u:
					RegisterReciever.smethod_19((Control)(object)DateLbl, new Size(138, 18));
					num = ((int)num2 * -1946075686) ^ 0x5299030C;
					continue;
				case 169u:
					RegisterReciever.smethod_40((Control)(object)Label1, bool_0: false);
					RegisterReciever.smethod_45((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -1154949) ^ 0x27856749;
					continue;
				case 168u:
					num = (int)(num2 * 133286448) ^ -134207901;
					continue;
				case 167u:
					num = (int)((num2 * 1821219248) ^ 0x41F55EA3);
					continue;
				case 166u:
					num = (int)(num2 * 216285253) ^ -605371083;
					continue;
				case 165u:
					num = (int)((num2 * 112427932) ^ 0x65C8DEB7);
					continue;
				case 164u:
					RegisterReciever.smethod_18((Control)(object)DateLbl, "DateLbl");
					num = (int)((num2 * 812623621) ^ 0x24D142D9);
					continue;
				case 163u:
					RecieverInfoGrp = RegisterReciever.smethod_5();
					num = ((int)num2 * -650177788) ^ -601346684;
					continue;
				case 162u:
					RegisterReciever.smethod_17((Control)(object)NameTxt, new Point(135, 55));
					num = (int)(num2 * 523812376) ^ -597211579;
					continue;
				case 161u:
					RegisterReciever.smethod_55((Control)(object)this);
					num = (int)(num2 * 112638842) ^ -850425076;
					continue;
				case 160u:
					num = ((int)num2 * -1715475098) ^ -209168771;
					continue;
				case 159u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_48((Control)(object)this), (Control)(object)AddReceiptantBtn);
					num = ((int)num2 * -812710242) ^ 0x6869FD88;
					continue;
				case 158u:
					num = ((int)num2 * -1839414744) ^ 0x3CBA4D6A;
					continue;
				case 157u:
					ClearBtn = RegisterReciever.smethod_8();
					Timer1 = RegisterReciever.smethod_9(components);
					num = ((int)num2 * -1745539727) ^ 0x66813C0C;
					continue;
				case 156u:
					RegisterReciever.smethod_20((Control)(object)Label1, 23);
					num = (int)((num2 * 1157672981) ^ 0x54DDB562);
					continue;
				case 155u:
					RegisterReciever.smethod_19((Control)(object)RecieverInfoGrp, new Size(520, 454));
					num = (int)(num2 * 291247097) ^ -930903004;
					continue;
				case 154u:
					RegisterReciever.smethod_18((Control)(object)BloodGrpLbl, "BloodGrpLbl");
					num = (int)((num2 * 1580234965) ^ 0x7F41EBB3);
					continue;
				case 153u:
					RegisterReciever.smethod_18((Control)(object)GenderTxt, "GenderTxt");
					num = (int)(num2 * 560615301) ^ -162172501;
					continue;
				case 152u:
					RegisterReciever.smethod_22(DateLbl, (ContentAlignment)32);
					num = ((int)num2 * -302904539) ^ 0x326BC136;
					continue;
				case 151u:
					RegisterReciever.smethod_21(Label1, "(In litres)");
					num = (int)((num2 * 212411808) ^ 0x4159E534);
					continue;
				case 150u:
					RegisterReciever.smethod_20((Control)(object)RegisterLbl, 10);
					num = ((int)num2 * -283523554) ^ 0x61DD6986;
					continue;
				case 149u:
					RegisterReciever.smethod_20((Control)(object)SuccessMsg, 15);
					RegisterReciever.smethod_21(SuccessMsg, "Name :");
					RegisterReciever.smethod_22(SuccessMsg, (ContentAlignment)32);
					RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: false);
					num = (int)((num2 * 1294549541) ^ 0x2A227050);
					continue;
				case 148u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)BloodGrpCombo);
					num = (int)((num2 * 366786741) ^ 0x2373500C);
					continue;
				case 147u:
					Label1 = RegisterReciever.smethod_4();
					num = ((int)num2 * -346636361) ^ -1276900613;
					continue;
				case 146u:
					RegisterReciever.smethod_18((Control)(object)RecieverInfoGrp, "RecieverInfoGrp");
					num = ((int)num2 * -1629099806) ^ -147858195;
					continue;
				case 145u:
					RegisterReciever.smethod_22(MobileLbl, (ContentAlignment)32);
					num = (int)(num2 * 1267523602) ^ -1237296310;
					continue;
				case 144u:
					MobileTxt = RegisterReciever.smethod_6();
					NameTxt = RegisterReciever.smethod_6();
					num = (int)(num2 * 574521018) ^ -2085072313;
					continue;
				case 143u:
					num = (int)((num2 * 669871409) ^ 0x445ED14E);
					continue;
				case 142u:
					RegisterReciever.smethod_25(RecieverInfoGrp, bool_0: false);
					num = ((int)num2 * -2005489076) ^ 0x567D05B9;
					continue;
				case 141u:
					RegisterReciever.smethod_17((Control)(object)DateLbl, new Point(33, 389));
					num = (int)((num2 * 1547159164) ^ 0xC439273);
					continue;
				case 140u:
					num = ((int)num2 * -778636914) ^ -793584453;
					continue;
				case 139u:
					RegisterReciever.smethod_37((ButtonBase)(object)AddReceiptantBtn, bool_0: false);
					num = (int)(num2 * 172111495) ^ -389944584;
					continue;
				case 138u:
					num = ((int)num2 * -45102224) ^ -2140827216;
					continue;
				case 137u:
					RegisterReciever.smethod_36((ButtonBase)(object)AddReceiptantBtn, "Add Recieptant");
					num = (int)((num2 * 2027502734) ^ 0x490E8134);
					continue;
				case 136u:
					RegisterReciever.smethod_18((Control)(object)AgeLbl, "AgeLbl");
					num = ((int)num2 * -482455974) ^ -1107342194;
					continue;
				case 135u:
					RegisterReciever.smethod_17((Control)(object)GenderLbl, new Point(33, 330));
					RegisterReciever.smethod_18((Control)(object)GenderLbl, "GenderLbl");
					num = (int)((num2 * 44869770) ^ 0x1936F525);
					continue;
				case 134u:
					num = (int)(num2 * 253837821) ^ -446014001;
					continue;
				case 133u:
					RegisterReciever.smethod_28(BloodGrpCombo, RegisterReciever.smethod_27());
					num = ((int)num2 * -1158040034) ^ -1056129300;
					continue;
				case 132u:
					RegisterReciever.smethod_14(QuantityLbl, bool_0: true);
					num = ((int)num2 * -858269124) ^ 0x237F3F73;
					continue;
				case 131u:
					RegisterReciever.smethod_21(RegisterLbl, "Register Reciever");
					num = ((int)num2 * -2144264612) ^ 0x53587EFE;
					continue;
				case 130u:
					RegisterReciever.smethod_29(BloodGrpCombo, (ComboBoxStyle)2);
					RegisterReciever.smethod_16((Control)(object)BloodGrpCombo, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1659266628) ^ -160804037;
					continue;
				case 129u:
					RegisterReciever.smethod_16((Control)(object)RecieverInfoGrp, RegisterReciever.smethod_15("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1792321278) ^ 0x600CC1D9);
					continue;
				case 128u:
					RegisterReciever.smethod_18((Control)(object)BloodGrpCombo, "BloodGrpCombo");
					num = ((int)num2 * -812416898) ^ 0x1E0798CF;
					continue;
				case 127u:
					RegisterReciever.smethod_19((Control)(object)MobileTxt, new Size(190, 29));
					num = ((int)num2 * -1422389849) ^ 0x789974B3;
					continue;
				case 126u:
					num = ((int)num2 * -344087549) ^ 0x4A40FFBE;
					continue;
				case 125u:
					RegisterReciever.smethod_21(MobileLbl, "Mobile :");
					num = ((int)num2 * -2141079397) ^ 0x728E900E;
					continue;
				case 124u:
					num = ((int)num2 * -277278320) ^ 0x6117DF76;
					continue;
				case 123u:
					num = (int)((num2 * 1093263124) ^ 0x72352499);
					continue;
				case 122u:
					RegisterReciever.smethod_14(BloodGrpLbl, bool_0: true);
					num = ((int)num2 * -1548353902) ^ 0x3A94C8A;
					continue;
				case 121u:
					num = (int)((num2 * 122099686) ^ 0x694405AF);
					continue;
				case 120u:
					RegisterReciever.smethod_14(GenderLbl, bool_0: true);
					num = ((int)num2 * -825994316) ^ -1228746501;
					continue;
				case 119u:
					num = ((int)num2 * -500350245) ^ -1265187932;
					continue;
				case 118u:
					RegisterReciever.smethod_20((Control)(object)ClearBtn, 14);
					num = (int)(num2 * 361669801) ^ -609665365;
					continue;
				case 117u:
					RegisterReciever.smethod_18((Control)(object)MobileLbl, "MobileLbl");
					num = ((int)num2 * -537079040) ^ -1960758327;
					continue;
				case 116u:
					RegisterReciever.smethod_52((Control)(object)RecieverInfoGrp);
					num = ((int)num2 * -146703564) ^ -839415804;
					continue;
				case 115u:
					num = ((int)num2 * -579639522) ^ 0x4575B5F2;
					continue;
				case 114u:
					GenderLbl = RegisterReciever.smethod_4();
					num = ((int)num2 * -132442967) ^ -763836792;
					continue;
				case 113u:
					RegisterReciever.smethod_16((Control)(object)AgeTxt, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1780440005) ^ 0x41654570;
					continue;
				case 112u:
					num = (int)(num2 * 204481) ^ -1865327568;
					continue;
				case 111u:
					RegisterReciever.smethod_32(RegisterReciever.smethod_31(BloodGrpCombo), new object[9] { "--Select--", "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
					num = (int)(num2 * 470043490) ^ -1063702611;
					continue;
				case 110u:
					num = ((int)num2 * -474091076) ^ 0x615D4F2A;
					continue;
				case 109u:
					RegisterReciever.smethod_22(QuantityLbl, (ContentAlignment)32);
					num = (int)(num2 * 2046394572) ^ -1158713147;
					continue;
				case 108u:
					num = (int)((num2 * 377373473) ^ 0x2841047D);
					continue;
				case 107u:
					num = ((int)num2 * -1134219683) ^ -194452458;
					continue;
				case 106u:
					num = ((int)num2 * -827791735) ^ -473295174;
					continue;
				case 105u:
					DateLbl = RegisterReciever.smethod_4();
					GenderTxt = RegisterReciever.smethod_7();
					num = (int)(num2 * 1723006637) ^ -656543072;
					continue;
				case 104u:
					RegisterReciever.smethod_16((Control)(object)AddReceiptantBtn, RegisterReciever.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 645321601) ^ -402110639;
					continue;
				case 103u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)AgeTxt);
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)MobileLbl);
					num = (int)(num2 * 881715165) ^ -1094217156;
					continue;
				case 102u:
					num = ((int)num2 * -1235003092) ^ -1408241753;
					continue;
				case 101u:
					RegisterReciever.smethod_14(DateLbl, bool_0: true);
					num = ((int)num2 * -1506036636) ^ -382343484;
					continue;
				case 100u:
					num = ((int)num2 * -608738076) ^ 0x42C7D890;
					continue;
				case 99u:
					RegisterReciever.smethod_19((Control)(object)QuantityLbl, new Size(80, 18));
					num = (int)((num2 * 2146164082) ^ 0x40DCE2D0);
					continue;
				case 98u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_48((Control)(object)this), (Control)(object)PictureBox1);
					num = (int)((num2 * 452904368) ^ 0x222BA57E);
					continue;
				case 97u:
					RegisterReciever.smethod_19((Control)(object)BloodGrpCombo, new Size(129, 26));
					RegisterReciever.smethod_20((Control)(object)BloodGrpCombo, 20);
					num = (int)((num2 * 128844755) ^ 0xA12661D);
					continue;
				case 96u:
					RegisterReciever.smethod_17((Control)(object)GenderTxt, new Point(135, 327));
					num = (int)((num2 * 1317177205) ^ 0x2D833CEC);
					continue;
				case 95u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)NameLbl);
					num = (int)(num2 * 562284290) ^ -1986014449;
					continue;
				case 94u:
					RegisterReciever.smethod_17((Control)(object)BloodGrpLbl, new Point(33, 216));
					num = ((int)num2 * -765385725) ^ 0x13FD9950;
					continue;
				case 93u:
					num = ((int)num2 * -1118454444) ^ 0xEF89EE2;
					continue;
				case 92u:
					RegisterReciever.smethod_20((Control)(object)DateTxt, 16);
					num = ((int)num2 * -946744533) ^ 0x54E2FC49;
					continue;
				case 91u:
					RegisterReciever.smethod_13((Control)(object)this);
					num = (int)((num2 * 2003835572) ^ 0x784A33D5);
					continue;
				case 90u:
					num = (int)((num2 * 267296941) ^ 0x32E45FF3);
					continue;
				case 89u:
					RegisterReciever.smethod_22(Label1, (ContentAlignment)32);
					num = ((int)num2 * -1692984550) ^ -1560419793;
					continue;
				case 88u:
					RegisterReciever.smethod_17((Control)(object)QuantityLbl, new Point(33, 269));
					num = (int)((num2 * 1553523539) ^ 0x3B857527);
					continue;
				case 87u:
					RegisterReciever.smethod_11((Control)(object)RecieverInfoGrp);
					num = ((int)num2 * -26293317) ^ 0xF41B8B1;
					continue;
				case 86u:
					RegisterReciever.smethod_30((ListControl)(object)BloodGrpCombo, bool_0: true);
					num = (int)(num2 * 928433876) ^ -1306494764;
					continue;
				case 85u:
					RegisterReciever.smethod_20((Control)(object)DateLbl, 15);
					num = (int)((num2 * 632466753) ^ 0x5128BFF3);
					continue;
				case 84u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)GenderLbl);
					num = ((int)num2 * -1803937470) ^ 0x40E8A745;
					continue;
				case 83u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)DateTxt);
					num = (int)((num2 * 885345424) ^ 0x2120F6A7);
					continue;
				case 82u:
					num = ((int)num2 * -1341252738) ^ -254803133;
					continue;
				case 81u:
					RegisterReciever.smethod_20((Control)(object)NameTxt, 0);
					num = (int)(num2 * 1392364515) ^ -1266985434;
					continue;
				case 80u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_48((Control)(object)this), (Control)(object)ClearBtn);
					num = ((int)num2 * -361078981) ^ 0x4D95841D;
					continue;
				case 79u:
					RegisterReciever.smethod_21(NameLbl, "Name :");
					num = (int)((num2 * 194076389) ^ 0x1DDD25AD);
					continue;
				case 78u:
					num = ((int)num2 * -1026301662) ^ -1285762806;
					continue;
				case 77u:
					num = (int)(num2 * 1933084420) ^ -1750189852;
					continue;
				case 76u:
					num = ((int)num2 * -1717458758) ^ -578397145;
					continue;
				case 75u:
					num = ((int)num2 * -929454830) ^ 0x58DE724C;
					continue;
				case 74u:
					RegisterReciever.smethod_30((ListControl)(object)GenderTxt, bool_0: true);
					num = ((int)num2 * -117086112) ^ -2020136214;
					continue;
				case 73u:
					num = ((int)num2 * -1322460810) ^ 0x3716E78B;
					continue;
				case 72u:
					RegisterReciever.smethod_51((Control)(object)RecieverInfoGrp, bool_0: false);
					num = ((int)num2 * -1598416371) ^ -1322054546;
					continue;
				case 71u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)QuantityTxt);
					num = (int)((num2 * 701838322) ^ 0x1431A850);
					continue;
				case 70u:
					num = (int)((num2 * 1260096144) ^ 0x6A060C98);
					continue;
				case 69u:
					RegisterReciever.smethod_18((Control)(object)QuantityTxt, "QuantityTxt");
					num = ((int)num2 * -982449851) ^ -1055192130;
					continue;
				case 68u:
					num = (int)(num2 * 440741147) ^ -1457648273;
					continue;
				case 67u:
					num = (int)((num2 * 1388484728) ^ 0x1186F8A8);
					continue;
				case 66u:
					QuantityTxt = RegisterReciever.smethod_6();
					num = ((int)num2 * -48644612) ^ -1548912687;
					continue;
				case 65u:
					RegisterReciever.smethod_35((Control)(object)AddReceiptantBtn, Color.White);
					num = (int)(num2 * 117257659) ^ -840857997;
					continue;
				case 64u:
					RegisterReciever.smethod_37((ButtonBase)(object)ClearBtn, bool_0: false);
					num = ((int)num2 * -1694413501) ^ -1358950077;
					continue;
				case 63u:
					RegisterReciever.smethod_29(GenderTxt, (ComboBoxStyle)2);
					num = (int)(num2 * 1935790862) ^ -166310546;
					continue;
				case 62u:
					AddReceiptantBtn = RegisterReciever.smethod_8();
					num = (int)(num2 * 1110644019) ^ -1408074338;
					continue;
				case 61u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_48((Control)(object)this), (Control)(object)SuccessMsg);
					num = ((int)num2 * -975143447) ^ 0x29DAC63C;
					continue;
				case 60u:
					RegisterReciever.smethod_18((Control)(object)AddReceiptantBtn, "AddReceiptantBtn");
					num = (int)(num2 * 358683839) ^ -598833142;
					continue;
				case 59u:
					RegisterReciever.smethod_42(PictureBox1, (PictureBoxSizeMode)1);
					num = (int)((num2 * 1836318171) ^ 0x37C279EB);
					continue;
				case 58u:
					RegisterReciever.smethod_49((Control)(object)this, "RegisterReciever");
					num = ((int)num2 * -1251463847) ^ -1070650852;
					continue;
				case 57u:
					SuccessMsg = RegisterReciever.smethod_4();
					num = ((int)num2 * -430990167) ^ 0x19788246;
					continue;
				case 56u:
					RegisterReciever.smethod_38(Timer1, bool_0: true);
					RegisterReciever.smethod_39(Timer1, 1500);
					num = (int)((num2 * 1592276352) ^ 0x54EA27FB);
					continue;
				case 55u:
					num = ((int)num2 * -307217684) ^ -1832922045;
					continue;
				case 54u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_48((Control)(object)this), (Control)(object)RecieverInfoGrp);
					num = (int)((num2 * 1270083947) ^ 0x56EE638);
					continue;
				case 53u:
					RegisterReciever.smethod_14(RegisterLbl, bool_0: true);
					num = ((int)num2 * -1292904228) ^ -1723374631;
					continue;
				case 52u:
					num = ((int)num2 * -482703378) ^ 0x61C3C3D2;
					continue;
				case 51u:
					num = ((int)num2 * -267144279) ^ -205777600;
					continue;
				case 50u:
					num = ((int)num2 * -1982837266) ^ -1868015501;
					continue;
				case 49u:
					AgeTxt = RegisterReciever.smethod_6();
					num = (int)((num2 * 1825259964) ^ 0x4B27BD64);
					continue;
				case 48u:
					RegisterReciever.smethod_17((Control)(object)AgeLbl, new Point(33, 109));
					num = (int)(num2 * 204748156) ^ -1792064533;
					continue;
				case 47u:
					RegisterReciever.smethod_16((Control)(object)SuccessMsg, RegisterReciever.smethod_15("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1938797890) ^ 0x177B0851;
					continue;
				case 46u:
					RegisterReciever.smethod_20((Control)(object)GenderLbl, 6);
					num = (int)(num2 * 1670680190) ^ -2074850328;
					continue;
				case 45u:
					num = ((int)num2 * -751222443) ^ -755806314;
					continue;
				case 44u:
					RegisterReciever.smethod_17((Control)(object)NameLbl, new Point(33, 58));
					RegisterReciever.smethod_18((Control)(object)NameLbl, "NameLbl");
					num = (int)(num2 * 453553123) ^ -910507050;
					continue;
				case 43u:
					num = (int)((num2 * 1333718474) ^ 0x423A442D);
					continue;
				case 42u:
					num = ((int)num2 * -2023853398) ^ 0x21057BFE;
					continue;
				case 41u:
					RegisterReciever.smethod_19((Control)(object)ClearBtn, new Size(148, 51));
					num = ((int)num2 * -526437040) ^ 0x2DF6DC2A;
					continue;
				case 39u:
					RegisterLbl = RegisterReciever.smethod_4();
					num = (int)(num2 * 2086215413) ^ -1737455372;
					continue;
				case 38u:
					num = (int)(num2 * 903604000) ^ -1027992771;
					continue;
				case 37u:
					num = (int)((num2 * 193834663) ^ 0x187CD41D);
					continue;
				case 36u:
					RegisterReciever.smethod_20((Control)(object)AgeTxt, 10);
					RegisterReciever.smethod_14(MobileLbl, bool_0: true);
					num = ((int)num2 * -62818995) ^ 0x25F51C12;
					continue;
				case 35u:
					num = ((int)num2 * -1209604139) ^ -1151392825;
					continue;
				case 34u:
					DateTxt = RegisterReciever.smethod_6();
					num = ((int)num2 * -581313524) ^ 0x7DAC2FD;
					continue;
				case 33u:
					RegisterReciever.smethod_16((Control)(object)QuantityLbl, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -828641066) ^ -450695352;
					continue;
				case 32u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)NameTxt);
					num = (int)((num2 * 504692948) ^ 0x5696F68E);
					continue;
				case 31u:
					num = ((int)num2 * -1236041251) ^ 0x38011571;
					continue;
				case 30u:
					RegisterReciever.smethod_35((Control)(object)ClearBtn, Color.White);
					num = ((int)num2 * -241134941) ^ -960837003;
					continue;
				case 29u:
					num = (int)(num2 * 1435474173) ^ -1681313065;
					continue;
				case 28u:
					RegisterReciever.smethod_18((Control)(object)DateTxt, "DateTxt");
					num = (int)(num2 * 11314269) ^ -953492506;
					continue;
				case 27u:
					RegisterReciever.smethod_20((Control)(object)GenderTxt, 14);
					RegisterReciever.smethod_14(AgeLbl, bool_0: true);
					num = (int)((num2 * 1369735953) ^ 0x7C3780CE);
					continue;
				case 26u:
					RegisterReciever.smethod_20((Control)(object)BloodGrpLbl, 19);
					num = (int)((num2 * 1298301645) ^ 0x3FB7EB93);
					continue;
				case 25u:
					num = (int)((num2 * 1288400903) ^ 0xED0DA5C);
					continue;
				case 24u:
					MobileLbl = RegisterReciever.smethod_4();
					num = (int)((num2 * 1172977383) ^ 0x5C4B858D);
					continue;
				case 23u:
					RegisterReciever.smethod_19((Control)(object)AgeTxt, new Size(124, 24));
					num = ((int)num2 * -822204979) ^ 0x69017716;
					continue;
				case 22u:
					num = (int)((num2 * 1041398266) ^ 0xDEFC1F4);
					continue;
				case 21u:
					RegisterReciever.smethod_17((Control)(object)RecieverInfoGrp, new Point(215, 214));
					num = ((int)num2 * -832579399) ^ 0x22695F;
					continue;
				case 20u:
					RegisterReciever.smethod_16((Control)(object)BloodGrpLbl, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1310376362) ^ 0x2107E237);
					continue;
				case 19u:
					RegisterReciever.smethod_17((Control)(object)ClearBtn, new Point(420, 674));
					num = ((int)num2 * -1499079788) ^ 0x5EE0B88F;
					continue;
				case 18u:
					RegisterReciever.smethod_19((Control)(object)QuantityTxt, new Size(86, 29));
					RegisterReciever.smethod_20((Control)(object)QuantityTxt, 22);
					num = (int)(num2 * 1619165671) ^ -616612678;
					continue;
				case 17u:
					RegisterReciever.smethod_36((ButtonBase)(object)ClearBtn, "Clear");
					num = (int)((num2 * 1557014022) ^ 0x2B802A4A);
					continue;
				case 16u:
					RegisterReciever.smethod_17((Control)(object)AgeTxt, new Point(135, 109));
					RegisterReciever.smethod_18((Control)(object)AgeTxt, "AgeTxt");
					num = (int)(num2 * 1031803519) ^ -1070463236;
					continue;
				case 15u:
					RegisterReciever.smethod_20((Control)(object)RecieverInfoGrp, 11);
					num = (int)((num2 * 1263061178) ^ 0x2FA69801);
					continue;
				case 14u:
					RegisterReciever.smethod_43(PictureBox1, 9);
					num = ((int)num2 * -1372334623) ^ 0x2C56C9B1;
					continue;
				case 13u:
					RegisterReciever.smethod_19((Control)(object)DateTxt, new Size(167, 29));
					num = (int)(num2 * 131252106) ^ -1597288418;
					continue;
				case 12u:
					RegisterReciever.smethod_50((Control)(object)this, new Size(977, 804));
					num = ((int)num2 * -2134057927) ^ -1983354145;
					continue;
				case 10u:
					RegisterReciever.smethod_21(BloodGrpLbl, "Blood Group :");
					num = (int)(num2 * 1879497600) ^ -441985603;
					continue;
				case 9u:
					RegisterReciever.smethod_19((Control)(object)NameLbl, new Size(62, 18));
					num = (int)((num2 * 1640496338) ^ 0x1C6926CA);
					continue;
				case 8u:
					num = ((int)num2 * -1587582723) ^ 0x5EEC9E1;
					continue;
				case 7u:
					num = (int)(num2 * 1159326651) ^ -535272283;
					continue;
				case 6u:
					num = ((int)num2 * -409832134) ^ -602125749;
					continue;
				case 5u:
					RegisterReciever.smethod_41(PictureBox1, (Image)(object)Resources.images);
					num = (int)((num2 * 1092476848) ^ 0x69C49A1B);
					continue;
				case 4u:
					RegisterReciever.smethod_34((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					num = ((int)num2 * -412931202) ^ -815135065;
					continue;
				case 3u:
					RegisterReciever.smethod_32(RegisterReciever.smethod_31(GenderTxt), new object[3] { "MALE", "FEMALE", "OTHERS" });
					num = (int)(num2 * 416593984) ^ -1431022584;
					continue;
				case 2u:
					RegisterReciever.smethod_14(Label1, bool_0: true);
					num = ((int)num2 * -1542708624) ^ -1907534924;
					continue;
				case 1u:
					RegisterReciever.smethod_19((Control)(object)GenderTxt, new Size(124, 27));
					num = ((int)num2 * -717733381) ^ 0x661B383D;
					continue;
				case 0u:
					RegisterReciever.smethod_16((Control)(object)NameTxt, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -851587997) ^ -1058767767;
					continue;
				default:
					return;
				case 11u:
					break;
				case 40u:
					return;
				}
				break;
			}
		}
	}

	private void RegisterReciever_Load(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 483492169;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x78F6AC2Bu) % 4u)
				{
				case 3u:
					RegisterReciever.smethod_63(BloodGrpCombo, 0);
					num = ((int)num2 * -1796992380) ^ 0x7458D2D6;
					continue;
				case 2u:
					RegisterReciever.smethod_61(myconnection, RegisterReciever.smethod_60(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
					RegisterReciever.smethod_62(DateTxt, DateTime.Today.ToShortDateString());
					num = (int)(num2 * 575824977) ^ -2065600790;
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
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected I4, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected I4, but got Unknown
		//IL_036d: Incompatible stack heights: 0 vs 1
		//IL_0382: Incompatible stack heights: 0 vs 1
		//IL_0392: Incompatible stack heights: 0 vs 1
		//IL_03b2: Incompatible stack heights: 0 vs 1
		//IL_03e1: Incompatible stack heights: 0 vs 1
		//IL_03ff: Incompatible stack heights: 0 vs 1
		//IL_0409: Incompatible stack heights: 0 vs 1
		if (!Validate_data())
		{
			uint num = 1861776658u;
			return;
		}
		string string_ = "Insert Into [Recievers] ([Name],[Age],[Gender],[Blood Group],[Contact Number],[Blood Recieved],[Date of Recieve]) Values (?,?,?,?,?,?,?)";
		RegisterReciever.smethod_64(myconnection);
		try
		{
			OleDbCommand val = default(OleDbCommand);
			while (true)
			{
				int num2 = -1089566289;
				while (true)
				{
					uint num;
					switch ((num = (uint)num2 ^ 0xB7F275B2u) % 18u)
					{
					case 17u:
						RegisterReciever.smethod_74(val);
						num2 = ((int)num * -1327394880) ^ 0x2E36B411;
						continue;
					case 16u:
						RegisterReciever.smethod_70(RegisterReciever.smethod_66(val), RegisterReciever.smethod_69("Contact Number", (object)RegisterReciever.smethod_73(RegisterReciever.smethod_67(MobileTxt))));
						RegisterReciever.smethod_70(RegisterReciever.smethod_66(val), RegisterReciever.smethod_69("Blood Recieved", (object)RegisterReciever.smethod_67(QuantityTxt)));
						num2 = (int)(num * 12485224) ^ -1006511718;
						continue;
					case 15u:
						RegisterReciever.smethod_77(Timer1);
						num2 = ((int)num * -443180849) ^ -1439996563;
						continue;
					case 14u:
						RegisterReciever.smethod_47((Control)(object)SuccessMsg, Color.Green);
						num2 = (int)((num * 911217272) ^ 0xE28CEF);
						continue;
					case 13u:
						RegisterReciever.smethod_75((Component)(object)val);
						num2 = (int)(num * 53310329) ^ -1196945181;
						continue;
					case 12u:
						RegisterReciever.smethod_21(SuccessMsg, "Reciever Successfully Registered !!");
						num2 = (int)((num * 1220526539) ^ 0x8FB04CC);
						continue;
					case 11u:
						num2 = (int)((num * 1236603808) ^ 0x437F238C);
						continue;
					case 10u:
						RegisterReciever.smethod_70(RegisterReciever.smethod_66(val), RegisterReciever.smethod_69("Age", (object)(int)RegisterReciever.smethod_71(RegisterReciever.smethod_67(AgeTxt))));
						num2 = (int)((num * 107295681) ^ 0x60B847BB);
						continue;
					case 9u:
						RegisterReciever.smethod_70(RegisterReciever.smethod_66(val), RegisterReciever.smethod_69("Gender", (object)RegisterReciever.smethod_68(RegisterReciever.smethod_72(GenderTxt))));
						num2 = (int)(num * 2073767206) ^ -1461831093;
						continue;
					case 8u:
						RegisterReciever.smethod_70(RegisterReciever.smethod_66(val), RegisterReciever.smethod_69("Date of Recieve", (object)RegisterReciever.smethod_67(DateTxt)));
						num2 = ((int)num * -1452543682) ^ 0x336E7FFF;
						continue;
					case 7u:
						num2 = ((int)num * -1597583265) ^ 0x375DBAF9;
						continue;
					case 5u:
						RegisterReciever.smethod_70(RegisterReciever.smethod_66(val), RegisterReciever.smethod_69("Name", (object)RegisterReciever.smethod_68(RegisterReciever.smethod_67(NameTxt))));
						num2 = ((int)num * -416968797) ^ 0x3A3857F1;
						continue;
					case 3u:
						RegisterReciever.smethod_70(RegisterReciever.smethod_66(val), RegisterReciever.smethod_69("Blood Group", (object)RegisterReciever.smethod_72(BloodGrpCombo)));
						num2 = ((int)num * -233454056) ^ 0x3C3C0742;
						continue;
					case 2u:
						RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: true);
						num2 = (int)(num * 734810681) ^ -328583681;
						continue;
					case 1u:
						val = RegisterReciever.smethod_65(string_, myconnection);
						num2 = (int)(num * 1118067158) ^ -1415180433;
						continue;
					case 0u:
						RegisterReciever.smethod_76(myconnection);
						num2 = (int)(num * 934957422) ^ -2101406947;
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
		catch (Exception exception_)
		{
			RegisterReciever.smethod_78(exception_);
			while (true)
			{
				_ = -1919701659;
				while (true)
				{
					_003F val2 = /*Error near IL_0325: Stack underflow*/^ -1208846926;
					uint num = (uint)(int)val2;
					switch (val2 % 8)
					{
					default:
						return;
					case 7:
						RegisterReciever.smethod_76(myconnection);
						_ = ((int)num * -554759594) ^ -1239113459;
						continue;
					case 6:
						RegisterReciever.smethod_79();
						_ = ((int)num * -695698690) ^ -152815441;
						continue;
					case 5:
						_ = (num * 434442212) ^ 0xA72CBAA4u;
						continue;
					case 3:
						RegisterReciever.smethod_47((Control)(object)SuccessMsg, Color.Red);
						_ = (num * 515188952) ^ 0xDA9689D2u;
						continue;
					case 2:
						RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: true);
						RegisterReciever.smethod_21(SuccessMsg, "Invalid Credentials");
						_ = (num * 1468061413) ^ 0x69E41AC3;
						continue;
					case 0:
						RegisterReciever.smethod_77(Timer1);
						_ = ((int)num * -1846314167) ^ 0x5C9A65D4;
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
	}

	private bool Validate_data()
	{
		bool flag4 = default(bool);
		bool result = default(bool);
		bool flag3 = default(bool);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1620641686;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x54BCEBE5u) % 58u)
				{
				case 57u:
					RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -1147124229) ^ 0x48BBA;
					continue;
				case 56u:
					num = 1848750556;
					continue;
				case 55u:
					RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -1506668839) ^ 0x7429BD66;
					continue;
				case 54u:
					RegisterReciever.smethod_21(SuccessMsg, "Select Proper Blood Group");
					num = (int)(num2 * 176015441) ^ -1682388764;
					continue;
				case 53u:
					num = (int)(num2 * 962607947) ^ -1828124416;
					continue;
				case 52u:
					RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: true);
					num = (int)(num2 * 426341156) ^ -2189550;
					continue;
				case 51u:
					flag4 = !MyProject.Forms.Form1.Gender_Validator(RegisterReciever.smethod_68(RegisterReciever.smethod_72(GenderTxt)));
					num = ((int)num2 * -1608237364) ^ 0x2B33D4C1;
					continue;
				case 50u:
					num = (int)((num2 * 160972552) ^ 0x5637E519);
					continue;
				case 49u:
					num = (int)((num2 * 606444339) ^ 0x5B82301A);
					continue;
				case 48u:
					result = false;
					num = (int)(num2 * 1026104421) ^ -835982338;
					continue;
				case 47u:
					flag3 = !MyProject.Forms.Form1.age_validator(RegisterReciever.smethod_67(AgeTxt));
					num = (int)((num2 * 955969992) ^ 0x3EA8EAA5);
					continue;
				case 46u:
					RegisterReciever.smethod_21(SuccessMsg, "Invalid Gender");
					num = (int)(num2 * 644825841) ^ -560366974;
					continue;
				case 45u:
					RegisterReciever.smethod_21(SuccessMsg, "Invalid Age");
					num = (int)((num2 * 1906271722) ^ 0x3C418A49);
					continue;
				case 44u:
					num = 254937723;
					continue;
				case 42u:
					RegisterReciever.smethod_77(Timer1);
					num = ((int)num2 * -1283406143) ^ 0x75378B8F;
					continue;
				case 41u:
					num = ((int)num2 * -1412792624) ^ -807082690;
					continue;
				case 40u:
				{
					int num13;
					int num14;
					if (!flag4)
					{
						num13 = -182537713;
						num14 = -182537713;
					}
					else
					{
						num13 = -707810058;
						num14 = -707810058;
					}
					num = num13 ^ (int)(num2 * 371967712);
					continue;
				}
				case 39u:
					RegisterReciever.smethod_77(Timer1);
					num = ((int)num2 * -1838470212) ^ 0x2A46416B;
					continue;
				case 38u:
					result = false;
					num = ((int)num2 * -330492833) ^ -1383174962;
					continue;
				case 37u:
					RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: true);
					num = (int)(num2 * 1547193510) ^ -758091203;
					continue;
				case 36u:
				{
					int num11;
					int num12;
					if (!flag3)
					{
						num11 = 1772698479;
						num12 = 1772698479;
					}
					else
					{
						num11 = 1349906355;
						num12 = 1349906355;
					}
					num = num11 ^ ((int)num2 * -1372849669);
					continue;
				}
				case 35u:
					num = 1234988198;
					continue;
				case 34u:
					flag = RegisterReciever.smethod_80(BloodGrpCombo) == 0;
					num = 405917869;
					continue;
				case 32u:
					RegisterReciever.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -190620431) ^ -358998092;
					continue;
				case 31u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = -1839575781;
						num10 = -1839575781;
					}
					else
					{
						num9 = -1937211682;
						num10 = -1937211682;
					}
					num = num9 ^ ((int)num2 * -1448572438);
					continue;
				}
				case 30u:
					RegisterReciever.smethod_77(Timer1);
					num = (int)(num2 * 1412679475) ^ -506863711;
					continue;
				case 29u:
				{
					int num7;
					int num8;
					if (MyProject.Forms.Form1.Decimal_Validator(RegisterReciever.smethod_67(QuantityTxt)))
					{
						num7 = -15110810;
						num8 = -15110810;
					}
					else
					{
						num7 = -724310494;
						num8 = -724310494;
					}
					num = num7 ^ (int)(num2 * 113248490);
					continue;
				}
				case 28u:
					num = (int)((num2 * 1276474588) ^ 0x7AFBB5C0);
					continue;
				case 27u:
					RegisterReciever.smethod_47((Control)(object)SuccessMsg, Color.Red);
					RegisterReciever.smethod_77(Timer1);
					num = (int)((num2 * 680627791) ^ 0x1C22C640);
					continue;
				case 26u:
					RegisterReciever.smethod_77(Timer1);
					num = (int)((num2 * 1212085984) ^ 0x7995B6B6);
					continue;
				case 25u:
					num = ((int)num2 * -1283127207) ^ 0x7CBC23CB;
					continue;
				case 24u:
					flag2 = !MyProject.Forms.Form1.Mobile_Validator(RegisterReciever.smethod_67(MobileTxt));
					num = ((int)num2 * -568699494) ^ 0x462DFA58;
					continue;
				case 23u:
					result = false;
					num = ((int)num2 * -1344438795) ^ 0x6F8A6290;
					continue;
				case 22u:
					result = false;
					num = (int)(num2 * 2110011051) ^ -599093720;
					continue;
				case 21u:
					RegisterReciever.smethod_21(SuccessMsg, "Invalid Quantity");
					num = (int)((num2 * 111763241) ^ 0x36C2E781);
					continue;
				case 20u:
					num = (int)((num2 * 674304365) ^ 0x355D4B09);
					continue;
				case 19u:
					RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -1071647053) ^ -77006927;
					continue;
				case 18u:
					result = false;
					num = ((int)num2 * -1289920096) ^ -990453867;
					continue;
				case 17u:
					RegisterReciever.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -207656639) ^ 0x4708F581;
					continue;
				case 16u:
					result = false;
					num = (int)(num2 * 554404652) ^ -1438246256;
					continue;
				case 15u:
					num = (int)(num2 * 563042267) ^ -1709952941;
					continue;
				case 14u:
					num = ((int)num2 * -17292413) ^ 0x50ACA51E;
					continue;
				case 13u:
					RegisterReciever.smethod_77(Timer1);
					num = ((int)num2 * -1694655875) ^ 0x2DE97A66;
					continue;
				case 12u:
					RegisterReciever.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -1133946257) ^ -493888032;
					continue;
				case 11u:
					RegisterReciever.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -1359468520) ^ 0x25E80385;
					continue;
				case 10u:
					num = (int)((num2 * 1637743389) ^ 0x1BF7907C);
					continue;
				case 9u:
					RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -1114422090) ^ -1737672183;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 703915831;
						num6 = 703915831;
					}
					else
					{
						num5 = 1176740086;
						num6 = 1176740086;
					}
					num = num5 ^ ((int)num2 * -2072593592);
					continue;
				}
				case 7u:
					num = 1387106764;
					continue;
				case 6u:
					RegisterReciever.smethod_21(SuccessMsg, "Invalid Mobile Number");
					RegisterReciever.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -478183668) ^ 0x520F50ED;
					continue;
				case 5u:
					result = true;
					num = ((int)num2 * -770851141) ^ 0x6A50320C;
					continue;
				case 4u:
					num = 374830910;
					continue;
				case 3u:
					RegisterReciever.smethod_21(SuccessMsg, "Invalid Name");
					num = ((int)num2 * -617916222) ^ 0x752A1DDB;
					continue;
				case 2u:
					num = ((int)num2 * -1277205464) ^ 0x319BA89E;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (MyProject.Forms.Form1.Name_Validation(RegisterReciever.smethod_68(RegisterReciever.smethod_67(NameTxt))))
					{
						num3 = 594642945;
						num4 = 594642945;
					}
					else
					{
						num3 = 2023214969;
						num4 = 2023214969;
					}
					num = num3 ^ (int)(num2 * 2067468927);
					continue;
				}
				case 0u:
					num = ((int)num2 * -1307196931) ^ -2133090330;
					continue;
				case 33u:
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
		RegisterReciever.smethod_81((TextBoxBase)(object)NameTxt);
		while (true)
		{
			int num = 429925683;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x52833A0u) % 11u)
				{
				case 10u:
					num = (int)((num2 * 611395658) ^ 0x3AAE456D);
					continue;
				case 9u:
					RegisterReciever.smethod_81((TextBoxBase)(object)MobileTxt);
					RegisterReciever.smethod_63(GenderTxt, -1);
					num = (int)(num2 * 487679956) ^ -981395001;
					continue;
				case 7u:
					num = ((int)num2 * -2088750757) ^ -1043539965;
					continue;
				case 6u:
					num = ((int)num2 * -795111933) ^ -134787186;
					continue;
				case 5u:
					num = ((int)num2 * -628020770) ^ 0x35AF5078;
					continue;
				case 4u:
					RegisterReciever.smethod_81((TextBoxBase)(object)AgeTxt);
					num = ((int)num2 * -1110096149) ^ -1886856213;
					continue;
				case 3u:
					RegisterReciever.smethod_63(BloodGrpCombo, 0);
					num = ((int)num2 * -162708682) ^ 0xE926A8E;
					continue;
				case 2u:
					RegisterReciever.smethod_81((TextBoxBase)(object)QuantityTxt);
					num = ((int)num2 * -1940401579) ^ 0x69BF67FB;
					continue;
				case 1u:
					RegisterReciever.smethod_62(DateTxt, RegisterReciever.smethod_82((object)DateTime.Now, "dd-MM-yyyy"));
					num = ((int)num2 * -1783506789) ^ -236505592;
					continue;
				default:
					return;
				case 0u:
					break;
				case 8u:
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
			int num = 1606981297;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDD9D70Fu) % 5u)
				{
				case 4u:
					RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: false);
					num = (int)(num2 * 1134562860) ^ -1290723140;
					continue;
				case 2u:
					num = (int)(num2 * 1419620883) ^ -227904957;
					continue;
				case 1u:
					RegisterReciever.smethod_83(Timer1);
					num = ((int)num2 * -1590307093) ^ 0x4CC69387;
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
