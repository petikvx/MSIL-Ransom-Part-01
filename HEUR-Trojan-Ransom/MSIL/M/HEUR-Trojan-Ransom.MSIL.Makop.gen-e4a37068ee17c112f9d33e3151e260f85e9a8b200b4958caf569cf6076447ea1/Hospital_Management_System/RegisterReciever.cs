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
			Button addReceiptantBtn = default(Button);
			while (true)
			{
				int num = -1385609067;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x83B4E846u) % 7u)
					{
					case 6u:
					{
						_AddReceiptantBtn = value;
						addReceiptantBtn = _AddReceiptantBtn;
						int num5;
						if (addReceiptantBtn == null)
						{
							num = -2054381831;
							num5 = -2054381831;
						}
						else
						{
							num = -1303465139;
							num5 = -1303465139;
						}
						continue;
					}
					case 3u:
						RegisterReciever.smethod_56((Control)(object)addReceiptantBtn, eventHandler_);
						num = (int)(num2 * 15771304) ^ -700633202;
						continue;
					case 2u:
						addReceiptantBtn = _AddReceiptantBtn;
						num = ((int)num2 * -251695634) ^ 0x19BEDADD;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (addReceiptantBtn == null)
						{
							num3 = -172804000;
							num4 = -172804000;
						}
						else
						{
							num3 = -603858292;
							num4 = -603858292;
						}
						num = num3 ^ (int)(num2 * 1272941486);
						continue;
					}
					case 0u:
						RegisterReciever.smethod_57((Control)(object)addReceiptantBtn, eventHandler_);
						num = ((int)num2 * -1698687503) ^ -102038878;
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
				int num = -1649085409;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB733E62Bu) % 9u)
					{
					case 8u:
						RegisterReciever.smethod_56((Control)(object)clearBtn, eventHandler_);
						num = (int)(num2 * 484194632) ^ -741077521;
						continue;
					case 7u:
						RegisterReciever.smethod_57((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -1257401039) ^ 0x1A2AA5D3;
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (clearBtn == null)
						{
							num5 = -789926561;
							num6 = -789926561;
						}
						else
						{
							num5 = -182534570;
							num6 = -182534570;
						}
						num = num5 ^ ((int)num2 * -318782824);
						continue;
					}
					case 5u:
						_ClearBtn = value;
						num = -1203921288;
						continue;
					case 4u:
						clearBtn = _ClearBtn;
						num = ((int)num2 * -1954856361) ^ -2117898306;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (clearBtn == null)
						{
							num3 = -1628084345;
							num4 = -1628084345;
						}
						else
						{
							num3 = -1443306993;
							num4 = -1443306993;
						}
						num = num3 ^ ((int)num2 * -751346859);
						continue;
					}
					case 1u:
						clearBtn = _ClearBtn;
						num = ((int)num2 * -632687496) ^ 0x128F789E;
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
				int num = -1253085545;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF8E835FEu) % 7u)
					{
					case 5u:
					{
						timer = _Timer1;
						int num5;
						int num6;
						if (timer == null)
						{
							num5 = 1464355925;
							num6 = 1464355925;
						}
						else
						{
							num5 = 1321027224;
							num6 = 1321027224;
						}
						num = num5 ^ (int)(num2 * 2063877811);
						continue;
					}
					case 4u:
						_Timer1 = value;
						timer = _Timer1;
						num = -659683953;
						continue;
					case 3u:
						RegisterReciever.smethod_59(timer, eventHandler_);
						num = (int)(num2 * 1044994091) ^ -1391178342;
						continue;
					case 2u:
						RegisterReciever.smethod_58(timer, eventHandler_);
						num = (int)((num2 * 2008848425) ^ 0x2550692B);
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (timer != null)
						{
							num3 = 765472580;
							num4 = 765472580;
						}
						else
						{
							num3 = 1340483952;
							num4 = 1340483952;
						}
						num = num3 ^ ((int)num2 * -547129838);
						continue;
					}
					default:
						return;
					case 6u:
						break;
					case 0u:
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
		RegisterReciever.smethod_0((UserControl)(object)this, (EventHandler)RegisterReciever_Load);
		myconnection = RegisterReciever.smethod_1();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing)
			{
				goto IL_006d;
			}
			int num = 0;
			goto IL_00ac;
			IL_00a3:
			num = ((components != null) ? 1 : 0);
			goto IL_00ac;
			IL_006d:
			int num2 = 1494098612;
			goto IL_0072;
			IL_0072:
			bool flag = default(bool);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x3AEE724Du) % 8u)
				{
				case 6u:
					num2 = ((int)num3 * -1129543803) ^ 0x10DF50B9;
					continue;
				case 5u:
					RegisterReciever.smethod_2((IDisposable)components);
					num2 = ((int)num3 * -970702370) ^ 0x684E0B90;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -943533249;
						num5 = -943533249;
					}
					else
					{
						num4 = -1081337544;
						num5 = -1081337544;
					}
					num2 = num4 ^ ((int)num3 * -509676962);
					continue;
				}
				case 3u:
					num2 = ((int)num3 * -1650182182) ^ -1255257595;
					continue;
				case 2u:
					num2 = 470123578;
					continue;
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_00a3;
				case 7u:
					return;
				}
				break;
			}
			goto IL_006d;
			IL_00ac:
			flag = (byte)num != 0;
			num2 = 61280017;
			goto IL_0072;
		}
		finally
		{
			while (true)
			{
				IL_00fd:
				int num6 = 2036283584;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0x3AEE724Du) % 4u)
					{
					case 2u:
						num6 = ((int)num3 * -975403728) ^ 0xDBA35EA;
						continue;
					case 1u:
						((ContainerControl)this).Dispose(disposing);
						num6 = (int)(num3 * 2094653799) ^ -917511148;
						continue;
					default:
						goto end_IL_00dc;
					case 0u:
						break;
					case 3u:
						goto end_IL_00dc;
					}
					goto IL_00fd;
					continue;
					end_IL_00dc:
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
			int num = -1889578833;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF822E768u) % 260u)
				{
				case 259u:
					RegisterReciever.smethod_19((Control)(object)MobileTxt, new Size(190, 29));
					num = (int)(num2 * 1710852577) ^ -147018096;
					continue;
				case 258u:
					num = ((int)num2 * -2099578265) ^ 0x507CBB01;
					continue;
				case 257u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)AgeTxt);
					num = (int)((num2 * 216736829) ^ 0x67637AC5);
					continue;
				case 256u:
					RegisterReciever.smethod_16((Control)(object)NameLbl, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1411522310) ^ -784558109;
					continue;
				case 255u:
					RegisterReciever.smethod_18((Control)(object)DateTxt, "DateTxt");
					num = ((int)num2 * -1885375653) ^ -201032788;
					continue;
				case 254u:
					Label1 = RegisterReciever.smethod_4();
					num = (int)((num2 * 1150430185) ^ 0x4036D401);
					continue;
				case 253u:
					RegisterReciever.smethod_17((Control)(object)DateTxt, new Point(205, 382));
					num = (int)(num2 * 1024983322) ^ -411036879;
					continue;
				case 252u:
					num = (int)((num2 * 402491988) ^ 0x5CA0DA85);
					continue;
				case 251u:
					RegisterReciever.smethod_18((Control)(object)MobileTxt, "MobileTxt");
					num = ((int)num2 * -1600557621) ^ -883819920;
					continue;
				case 250u:
					AddReceiptantBtn = RegisterReciever.smethod_8();
					num = ((int)num2 * -442409229) ^ 0x73972AC7;
					continue;
				case 249u:
					RegisterReciever.smethod_21(AgeLbl, "Age :");
					num = (int)((num2 * 2121613997) ^ 0x6809FF41);
					continue;
				case 248u:
					RegisterReciever.smethod_17((Control)(object)BloodGrpCombo, new Point(186, 213));
					num = ((int)num2 * -797948826) ^ 0x4C43D26B;
					continue;
				case 247u:
					num = (int)(num2 * 109442685) ^ -479652499;
					continue;
				case 246u:
					RegisterReciever.smethod_42(PictureBox1, (PictureBoxSizeMode)1);
					num = ((int)num2 * -1995293295) ^ -499218453;
					continue;
				case 245u:
					RegisterReciever.smethod_18((Control)(object)DateLbl, "DateLbl");
					num = (int)((num2 * 895569185) ^ 0x778AD1A0);
					continue;
				case 244u:
					num = (int)((num2 * 410383872) ^ 0x16A9B69E);
					continue;
				case 243u:
					RegisterReciever.smethod_45((ContainerControl)(object)this, new SizeF(8f, 16f));
					RegisterReciever.smethod_46((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -752973204) ^ -1355699374;
					continue;
				case 242u:
					RegisterReciever.smethod_14(AgeLbl, bool_0: true);
					num = ((int)num2 * -195236956) ^ 0x137B8EE8;
					continue;
				case 241u:
					MobileTxt = RegisterReciever.smethod_6();
					num = (int)(num2 * 1630232381) ^ -320506864;
					continue;
				case 240u:
					RegisterReciever.smethod_18((Control)(object)NameLbl, "NameLbl");
					num = ((int)num2 * -1263886295) ^ 0x71D5303;
					continue;
				case 239u:
					GenderLbl = RegisterReciever.smethod_4();
					num = ((int)num2 * -1015650764) ^ -1906623397;
					continue;
				case 238u:
					num = (int)((num2 * 500577812) ^ 0x2EA6AFAB);
					continue;
				case 237u:
					num = (int)((num2 * 525334220) ^ 0x50FD07F1);
					continue;
				case 236u:
					num = (int)(num2 * 1603353915) ^ -448476389;
					continue;
				case 235u:
					RegisterReciever.smethod_54((Control)(object)this, bool_0: false);
					RegisterReciever.smethod_55((Control)(object)this);
					num = (int)((num2 * 2146620767) ^ 0x5E5BDD3D);
					continue;
				case 234u:
					RegisterReciever.smethod_14(RegisterLbl, bool_0: true);
					num = (int)((num2 * 482866499) ^ 0x1FAAB22B);
					continue;
				case 233u:
					NameTxt = RegisterReciever.smethod_6();
					num = (int)(num2 * 488321128) ^ -1540806296;
					continue;
				case 232u:
					num = ((int)num2 * -1060161955) ^ -1501043418;
					continue;
				case 231u:
					RegisterReciever.smethod_19((Control)(object)RecieverInfoGrp, new Size(520, 454));
					num = ((int)num2 * -999386978) ^ -1790786355;
					continue;
				case 230u:
					RegisterReciever.smethod_17((Control)(object)RegisterLbl, new Point(392, 63));
					num = ((int)num2 * -80847555) ^ -1981423248;
					continue;
				case 229u:
					RegisterReciever.smethod_35((Control)(object)AddReceiptantBtn, Color.White);
					num = (int)((num2 * 1379916519) ^ 0x758A9EB5);
					continue;
				case 228u:
					RegisterReciever.smethod_16((Control)(object)GenderTxt, RegisterReciever.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -221577353) ^ -547658633;
					continue;
				case 227u:
					num = ((int)num2 * -1791069937) ^ 0x28443E23;
					continue;
				case 226u:
					RegisterReciever.smethod_30((ListControl)(object)BloodGrpCombo, bool_0: true);
					RegisterReciever.smethod_32(RegisterReciever.smethod_31(BloodGrpCombo), new object[9] { "--Select--", "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
					num = (int)((num2 * 1585019316) ^ 0x69820D92);
					continue;
				case 225u:
					GenderTxt = RegisterReciever.smethod_7();
					num = (int)(num2 * 829155851) ^ -21364080;
					continue;
				case 224u:
					RegisterReciever.smethod_40((Control)(object)Label1, bool_0: false);
					num = ((int)num2 * -1783800405) ^ -2123921133;
					continue;
				case 223u:
					RegisterReciever.smethod_21(Label1, "(In litres)");
					num = ((int)num2 * -425695465) ^ 0x4652025F;
					continue;
				case 222u:
					RegisterReciever.smethod_17((Control)(object)RecieverInfoGrp, new Point(215, 214));
					num = (int)((num2 * 1253845036) ^ 0x38F27C60);
					continue;
				case 221u:
					RegisterReciever.smethod_18((Control)(object)AddReceiptantBtn, "AddReceiptantBtn");
					num = ((int)num2 * -261521008) ^ 0x13554F64;
					continue;
				case 220u:
					RegisterReciever.smethod_12((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -1473132739) ^ 0x39AFE2C0;
					continue;
				case 219u:
					RegisterReciever.smethod_20((Control)(object)DateTxt, 16);
					num = (int)(num2 * 2141223677) ^ -1896369609;
					continue;
				case 218u:
					RegisterReciever.smethod_19((Control)(object)MobileLbl, new Size(68, 18));
					RegisterReciever.smethod_20((Control)(object)MobileLbl, 8);
					num = ((int)num2 * -1563539781) ^ 0x6B33A7D6;
					continue;
				case 217u:
					num = (int)((num2 * 1189806122) ^ 0x8A61C5A);
					continue;
				case 216u:
					RegisterReciever.smethod_17((Control)(object)AgeTxt, new Point(135, 109));
					num = ((int)num2 * -1502747929) ^ 0x5AEC2C1A;
					continue;
				case 215u:
					num = (int)(num2 * 819600421) ^ -1406669130;
					continue;
				case 214u:
					RegisterReciever.smethod_19((Control)(object)Label1, new Size(84, 18));
					num = (int)(num2 * 809799257) ^ -203068629;
					continue;
				case 213u:
					RegisterReciever.smethod_43(PictureBox1, 9);
					num = (int)((num2 * 181187310) ^ 0x7E5D5120);
					continue;
				case 212u:
					RegisterReciever.smethod_50((Control)(object)this, new Size(977, 804));
					num = (int)((num2 * 218234766) ^ 0x280340C1);
					continue;
				case 211u:
					RegisterReciever.smethod_37((ButtonBase)(object)ClearBtn, bool_0: false);
					num = ((int)num2 * -830986192) ^ -1601807099;
					continue;
				case 210u:
					Timer1 = RegisterReciever.smethod_9(components);
					num = (int)((num2 * 907590112) ^ 0x7619A47F);
					continue;
				case 209u:
					num = ((int)num2 * -1913766090) ^ 0x1B42DF5C;
					continue;
				case 208u:
					num = (int)(num2 * 1532708793) ^ -493012702;
					continue;
				case 207u:
					RegisterReciever.smethod_18((Control)(object)BloodGrpCombo, "BloodGrpCombo");
					num = (int)(num2 * 1602165764) ^ -1891966915;
					continue;
				case 206u:
					RegisterReciever.smethod_22(BloodGrpLbl, (ContentAlignment)32);
					num = (int)((num2 * 313211172) ^ 0x4B4C5D7D);
					continue;
				case 204u:
					num = (int)((num2 * 705097437) ^ 0x3E4B5726);
					continue;
				case 203u:
					RegisterReciever.smethod_17((Control)(object)NameTxt, new Point(135, 55));
					num = (int)((num2 * 1873973151) ^ 0x108798F9);
					continue;
				case 202u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)QuantityTxt);
					num = (int)((num2 * 264451227) ^ 0x5E0B7182);
					continue;
				case 201u:
					num = (int)((num2 * 41583682) ^ 0x18DBEC0A);
					continue;
				case 200u:
					RegisterReciever.smethod_20((Control)(object)ClearBtn, 14);
					num = ((int)num2 * -925843163) ^ -1225093080;
					continue;
				case 199u:
					RegisterReciever.smethod_18((Control)(object)AgeTxt, "AgeTxt");
					num = (int)((num2 * 746723503) ^ 0x3A88FB85);
					continue;
				case 198u:
					RegisterReciever.smethod_22(DateLbl, (ContentAlignment)32);
					RegisterReciever.smethod_29(GenderTxt, (ComboBoxStyle)2);
					num = (int)((num2 * 1704284541) ^ 0x53BE2FA2);
					continue;
				case 197u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)BloodGrpLbl);
					num = ((int)num2 * -1139611005) ^ 0x1867F239;
					continue;
				case 196u:
					num = ((int)num2 * -2003544883) ^ -542198312;
					continue;
				case 195u:
					RegisterReciever.smethod_20((Control)(object)AgeLbl, 13);
					num = ((int)num2 * -1485401435) ^ 0x3EFCA64A;
					continue;
				case 194u:
					RegisterReciever.smethod_22(GenderLbl, (ContentAlignment)32);
					num = (int)((num2 * 1580265757) ^ 0x6B000AE);
					continue;
				case 193u:
					RegisterReciever.smethod_53((ISupportInitialize)PictureBox1);
					num = (int)(num2 * 1815548091) ^ -1459658697;
					continue;
				case 192u:
					num = ((int)num2 * -236744173) ^ 0x19265EDF;
					continue;
				case 191u:
					RegisterReciever.smethod_17((Control)(object)QuantityLbl, new Point(33, 269));
					num = (int)((num2 * 368941162) ^ 0x515A2585);
					continue;
				case 190u:
					RegisterReciever.smethod_21(BloodGrpLbl, "Blood Group :");
					num = (int)((num2 * 1039789191) ^ 0xC007A0);
					continue;
				case 189u:
					MobileLbl = RegisterReciever.smethod_4();
					num = ((int)num2 * -2038901181) ^ -800148052;
					continue;
				case 188u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)QuantityLbl);
					num = ((int)num2 * -55881175) ^ -2110178136;
					continue;
				case 187u:
					SuccessMsg = RegisterReciever.smethod_4();
					num = (int)(num2 * 1121718711) ^ -980311615;
					continue;
				case 186u:
					RegisterReciever.smethod_17((Control)(object)QuantityTxt, new Point(135, 262));
					num = ((int)num2 * -1491900186) ^ 0x6D4EA0D;
					continue;
				case 185u:
					RegisterReciever.smethod_22(SuccessMsg, (ContentAlignment)32);
					num = (int)(num2 * 1937835172) ^ -90994992;
					continue;
				case 184u:
					RegisterReciever.smethod_20((Control)(object)BloodGrpLbl, 19);
					num = (int)(num2 * 1147812069) ^ -1785388633;
					continue;
				case 183u:
					RegisterReciever.smethod_19((Control)(object)SuccessMsg, new Size(339, 45));
					RegisterReciever.smethod_20((Control)(object)SuccessMsg, 15);
					RegisterReciever.smethod_21(SuccessMsg, "Name :");
					num = ((int)num2 * -97096210) ^ 0x5B3A1B57;
					continue;
				case 182u:
					num = ((int)num2 * -1098422315) ^ -280382274;
					continue;
				case 181u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)MobileTxt);
					num = ((int)num2 * -1719949297) ^ 0x2FC4B23C;
					continue;
				case 180u:
					num = (int)(num2 * 83114614) ^ -758184460;
					continue;
				case 179u:
					RegisterReciever.smethod_17((Control)(object)MobileLbl, new Point(33, 163));
					RegisterReciever.smethod_18((Control)(object)MobileLbl, "MobileLbl");
					num = (int)((num2 * 119246576) ^ 0x24F96802);
					continue;
				case 178u:
					num = (int)((num2 * 2003797936) ^ 0x30A57222);
					continue;
				case 177u:
					DateLbl = RegisterReciever.smethod_4();
					num = (int)((num2 * 1541174771) ^ 0x6410D5BE);
					continue;
				case 176u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_48((Control)(object)this), (Control)(object)ClearBtn);
					num = ((int)num2 * -1722365697) ^ -811779063;
					continue;
				case 175u:
					RegisterReciever.smethod_49((Control)(object)this, "RegisterReciever");
					num = ((int)num2 * -2005934727) ^ 0x60064F6B;
					continue;
				case 174u:
					RegisterReciever.smethod_22(NameLbl, (ContentAlignment)32);
					RegisterReciever.smethod_17((Control)(object)MobileTxt, new Point(135, 156));
					num = (int)(num2 * 669842138) ^ -1246184705;
					continue;
				case 173u:
					ClearBtn = RegisterReciever.smethod_8();
					num = ((int)num2 * -392308847) ^ 0x46984593;
					continue;
				case 172u:
					RegisterReciever.smethod_19((Control)(object)NameTxt, new Size(355, 24));
					num = (int)(num2 * 1385078977) ^ -1153310335;
					continue;
				case 171u:
					num = (int)(num2 * 1363362861) ^ -406202591;
					continue;
				case 170u:
					num = (int)((num2 * 415554526) ^ 0x3016652);
					continue;
				case 169u:
					num = ((int)num2 * -837719335) ^ -1831025221;
					continue;
				case 168u:
					num = (int)((num2 * 412377052) ^ 0x6255C12);
					continue;
				case 167u:
					RegisterReciever.smethod_19((Control)(object)AgeLbl, new Size(46, 18));
					num = (int)(num2 * 176249947) ^ -1891822698;
					continue;
				case 166u:
					RegisterReciever.smethod_16((Control)(object)QuantityLbl, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1622249407) ^ -2018338875;
					continue;
				case 165u:
					RegisterReciever.smethod_18((Control)(object)BloodGrpLbl, "BloodGrpLbl");
					num = (int)((num2 * 199443541) ^ 0x63B7427F);
					continue;
				case 164u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_48((Control)(object)this), (Control)(object)PictureBox1);
					num = (int)(num2 * 1809886970) ^ -679395449;
					continue;
				case 163u:
					RegisterReciever.smethod_19((Control)(object)PictureBox1, new Size(171, 126));
					num = (int)((num2 * 1593823922) ^ 0x7FE3F328);
					continue;
				case 162u:
					RegisterReciever.smethod_19((Control)(object)BloodGrpCombo, new Size(129, 26));
					num = (int)(num2 * 1645690028) ^ -2140119977;
					continue;
				case 161u:
					RegisterReciever.smethod_20((Control)(object)GenderTxt, 14);
					num = ((int)num2 * -543257979) ^ 0x5C378401;
					continue;
				case 160u:
					RegisterReciever.smethod_13((Control)(object)this);
					num = (int)(num2 * 1488999912) ^ -1186210818;
					continue;
				case 159u:
					RegisterReciever.smethod_16((Control)(object)BloodGrpCombo, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 664264463) ^ -180916633;
					continue;
				case 158u:
					RegisterReciever.smethod_14(NameLbl, bool_0: true);
					num = ((int)num2 * -816231332) ^ -1453843704;
					continue;
				case 157u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)GenderLbl);
					num = ((int)num2 * -656969647) ^ -922299524;
					continue;
				case 156u:
					num = (int)((num2 * 1504272114) ^ 0x75465C22);
					continue;
				case 155u:
					RegisterReciever.smethod_21(DateLbl, "Recieptant Date :");
					num = (int)((num2 * 150456976) ^ 0x4001F352);
					continue;
				case 154u:
					num = ((int)num2 * -312255194) ^ -372626758;
					continue;
				case 153u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_48((Control)(object)this), (Control)(object)AddReceiptantBtn);
					num = ((int)num2 * -1018470814) ^ -2088139971;
					continue;
				case 152u:
					RegisterReciever.smethod_14(Label1, bool_0: true);
					num = ((int)num2 * -2086362840) ^ 0x7EA04F8E;
					continue;
				case 151u:
					num = (int)((num2 * 1324924981) ^ 0x5ADA3252);
					continue;
				case 150u:
					RegisterReciever.smethod_47((Control)(object)this, Color.White);
					num = ((int)num2 * -46637826) ^ 0x7EDC2FB8;
					continue;
				case 149u:
					RegisterReciever.smethod_21(RegisterLbl, "Register Reciever");
					RegisterReciever.smethod_22(RegisterLbl, (ContentAlignment)32);
					num = (int)((num2 * 903478619) ^ 0x44CA0A60);
					continue;
				case 148u:
					RegisterReciever.smethod_19((Control)(object)GenderLbl, new Size(73, 18));
					RegisterReciever.smethod_20((Control)(object)GenderLbl, 6);
					num = ((int)num2 * -939080630) ^ 0x26730CB4;
					continue;
				case 147u:
					RegisterReciever.smethod_19((Control)(object)RegisterLbl, new Size(282, 35));
					RegisterReciever.smethod_20((Control)(object)RegisterLbl, 10);
					num = (int)(num2 * 701268961) ^ -1605418374;
					continue;
				case 146u:
					num = (int)(num2 * 1646597674) ^ -1126768422;
					continue;
				case 145u:
					RegisterReciever.smethod_20((Control)(object)Label1, 23);
					num = (int)((num2 * 2055859966) ^ 0x53219CE5);
					continue;
				case 144u:
					RegisterReciever.smethod_19((Control)(object)DateLbl, new Size(138, 18));
					num = ((int)num2 * -2083417087) ^ -230118350;
					continue;
				case 143u:
					num = (int)((num2 * 1095523168) ^ 0x51BBDC6B);
					continue;
				case 142u:
					num = (int)((num2 * 224878375) ^ 0x2D5CE340);
					continue;
				case 141u:
					num = ((int)num2 * -29042362) ^ -1768009272;
					continue;
				case 140u:
					RegisterReciever.smethod_14(GenderLbl, bool_0: true);
					num = ((int)num2 * -1977237101) ^ 0x46391194;
					continue;
				case 139u:
					RegisterReciever.smethod_37((ButtonBase)(object)AddReceiptantBtn, bool_0: false);
					RegisterReciever.smethod_34((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					num = ((int)num2 * -557232987) ^ 0xEFDA29C;
					continue;
				case 138u:
					RegisterReciever.smethod_17((Control)(object)AddReceiptantBtn, new Point(587, 674));
					num = (int)(num2 * 281988473) ^ -574065070;
					continue;
				case 137u:
					RegisterReciever.smethod_19((Control)(object)DateTxt, new Size(167, 29));
					num = ((int)num2 * -1509033576) ^ -794782293;
					continue;
				case 136u:
					RegisterReciever.smethod_20((Control)(object)QuantityLbl, 21);
					num = (int)(num2 * 1337002128) ^ -2052863904;
					continue;
				case 135u:
					RegisterReciever.smethod_35((Control)(object)ClearBtn, Color.White);
					num = ((int)num2 * -1328693364) ^ 0x1FA18FB5;
					continue;
				case 134u:
					RegisterReciever.smethod_20((Control)(object)DateLbl, 15);
					num = ((int)num2 * -1572338256) ^ -1951279049;
					continue;
				case 133u:
					num = (int)(num2 * 1991171935) ^ -1695130743;
					continue;
				case 132u:
					num = ((int)num2 * -1549478459) ^ -1321712410;
					continue;
				case 131u:
					RegisterReciever.smethod_36((ButtonBase)(object)ClearBtn, "Clear");
					num = ((int)num2 * -1949091792) ^ 0x34ADF070;
					continue;
				case 130u:
					RegisterReciever.smethod_20((Control)(object)RecieverInfoGrp, 11);
					num = (int)((num2 * 1612216462) ^ 0x3B583D25);
					continue;
				case 129u:
					RegisterReciever.smethod_14(BloodGrpLbl, bool_0: true);
					num = (int)((num2 * 681119581) ^ 0x2685F198);
					continue;
				case 128u:
					num = (int)(num2 * 2108386275) ^ -693215739;
					continue;
				case 127u:
					num = (int)(num2 * 1028181590) ^ -1207242323;
					continue;
				case 126u:
					num = (int)((num2 * 335735369) ^ 0x35C5685E);
					continue;
				case 125u:
					RegisterReciever.smethod_29(BloodGrpCombo, (ComboBoxStyle)2);
					num = ((int)num2 * -816834947) ^ -501098795;
					continue;
				case 124u:
					RegisterReciever.smethod_18((Control)(object)NameTxt, "NameTxt");
					num = ((int)num2 * -2024922945) ^ 0x7CFE3AF8;
					continue;
				case 123u:
					RegisterReciever.smethod_19((Control)(object)NameLbl, new Size(62, 18));
					num = ((int)num2 * -1425053339) ^ 0x2CCC7C59;
					continue;
				case 122u:
					num = ((int)num2 * -1464479563) ^ -668600200;
					continue;
				case 121u:
					RegisterReciever.smethod_17((Control)(object)NameLbl, new Point(33, 58));
					num = ((int)num2 * -495747014) ^ 0xCA9FBFE;
					continue;
				case 120u:
					RegisterReciever.smethod_19((Control)(object)QuantityLbl, new Size(80, 18));
					num = ((int)num2 * -530646357) ^ -144234488;
					continue;
				case 119u:
					RegisterReciever.smethod_30((ListControl)(object)GenderTxt, bool_0: true);
					num = ((int)num2 * -2057428231) ^ -1695573147;
					continue;
				case 118u:
					num = (int)((num2 * 135300093) ^ 0x4D8D1F48);
					continue;
				case 117u:
					num = ((int)num2 * -1721319874) ^ -1532917805;
					continue;
				case 116u:
					PictureBox1 = RegisterReciever.smethod_10();
					num = ((int)num2 * -871844721) ^ 0x76213F16;
					continue;
				case 115u:
					RegisterReciever.smethod_41(PictureBox1, (Image)(object)Resources.images);
					num = (int)(num2 * 1732781543) ^ -1016880463;
					continue;
				case 114u:
					num = ((int)num2 * -2124580936) ^ -784744688;
					continue;
				case 113u:
					num = ((int)num2 * -450992975) ^ 0x19D64558;
					continue;
				case 112u:
					DateTxt = RegisterReciever.smethod_6();
					num = ((int)num2 * -484038479) ^ -285259095;
					continue;
				case 111u:
					RegisterReciever.smethod_21(NameLbl, "Name :");
					num = ((int)num2 * -1715256349) ^ -1709663939;
					continue;
				case 110u:
					RegisterReciever.smethod_20((Control)(object)NameTxt, 0);
					RegisterReciever.smethod_34((ButtonBase)(object)AddReceiptantBtn, Color.MidnightBlue);
					num = ((int)num2 * -1464016957) ^ -1666416588;
					continue;
				case 109u:
					RegisterReciever.smethod_22(MobileLbl, (ContentAlignment)32);
					num = (int)((num2 * 489129588) ^ 0x3EDA8BD8);
					continue;
				case 108u:
					num = (int)((num2 * 611093406) ^ 0x35C72D8D);
					continue;
				case 107u:
					BloodGrpLbl = RegisterReciever.smethod_4();
					num = (int)(num2 * 1048677937) ^ -1880902102;
					continue;
				case 106u:
					RegisterReciever.smethod_14(MobileLbl, bool_0: true);
					num = (int)((num2 * 2075685866) ^ 0x69A451B7);
					continue;
				case 105u:
					num = ((int)num2 * -1059367514) ^ -543483521;
					continue;
				case 104u:
					RegisterReciever.smethod_18((Control)(object)GenderLbl, "GenderLbl");
					num = ((int)num2 * -1850678150) ^ -1714121020;
					continue;
				case 103u:
					RegisterReciever.smethod_22(QuantityLbl, (ContentAlignment)32);
					num = ((int)num2 * -467975855) ^ -1210154833;
					continue;
				case 102u:
					num = (int)((num2 * 911300271) ^ 0x51609A2A);
					continue;
				case 101u:
					num = (int)(num2 * 147009200) ^ -1190527404;
					continue;
				case 100u:
					RegisterReciever.smethod_22(AgeLbl, (ContentAlignment)32);
					RegisterReciever.smethod_16((Control)(object)AgeTxt, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -25603929) ^ -488868023;
					continue;
				case 99u:
					num = ((int)num2 * -361370690) ^ 0x7F1473A3;
					continue;
				case 98u:
					RegisterReciever.smethod_44(PictureBox1, bool_0: false);
					num = (int)((num2 * 659147270) ^ 0x43BB1A71);
					continue;
				case 97u:
					RegisterReciever.smethod_16((Control)(object)BloodGrpLbl, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					RegisterReciever.smethod_17((Control)(object)BloodGrpLbl, new Point(33, 216));
					num = ((int)num2 * -895932561) ^ 0x1A07B64A;
					continue;
				case 95u:
					RegisterReciever.smethod_28(BloodGrpCombo, RegisterReciever.smethod_27());
					num = (int)((num2 * 1521929142) ^ 0x32E34B23);
					continue;
				case 94u:
					num = ((int)num2 * -1699519912) ^ -1778729635;
					continue;
				case 93u:
					RecieverInfoGrp = RegisterReciever.smethod_5();
					num = ((int)num2 * -266066823) ^ -1046301206;
					continue;
				case 92u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)NameLbl);
					num = (int)(num2 * 539874033) ^ -797832154;
					continue;
				case 91u:
					RegisterLbl = RegisterReciever.smethod_4();
					num = (int)((num2 * 2050171117) ^ 0x35DD65E6);
					continue;
				case 90u:
					RegisterReciever.smethod_16((Control)(object)AddReceiptantBtn, RegisterReciever.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -862935225) ^ 0x356C1D13;
					continue;
				case 89u:
					num = (int)(num2 * 1269817949) ^ -2057001639;
					continue;
				case 88u:
					num = (int)((num2 * 1004561035) ^ 0x75CD0FD7);
					continue;
				case 87u:
					num = ((int)num2 * -899311124) ^ 0xAC8A816;
					continue;
				case 86u:
					num = (int)(num2 * 1125201614) ^ -79936651;
					continue;
				case 85u:
					RegisterReciever.smethod_19((Control)(object)QuantityTxt, new Size(86, 29));
					RegisterReciever.smethod_20((Control)(object)QuantityTxt, 22);
					num = ((int)num2 * -177896852) ^ -1522818026;
					continue;
				case 84u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_48((Control)(object)this), (Control)(object)RegisterLbl);
					num = (int)(num2 * 1417732056) ^ -1140557079;
					continue;
				case 83u:
					num = ((int)num2 * -1060572580) ^ 0x54A612BB;
					continue;
				case 82u:
					RegisterReciever.smethod_22(Label1, (ContentAlignment)32);
					num = (int)((num2 * 1881046477) ^ 0x7E60503A);
					continue;
				case 81u:
					RegisterReciever.smethod_25(RecieverInfoGrp, bool_0: false);
					num = (int)((num2 * 1504754840) ^ 0x39F0F7F0);
					continue;
				case 80u:
					BloodGrpCombo = RegisterReciever.smethod_7();
					num = ((int)num2 * -1008094551) ^ 0xD3FC60B;
					continue;
				case 79u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)BloodGrpCombo);
					num = ((int)num2 * -927507432) ^ -504057757;
					continue;
				case 78u:
					RegisterReciever.smethod_19((Control)(object)ClearBtn, new Size(148, 51));
					num = ((int)num2 * -1825450946) ^ 0x25322877;
					continue;
				case 77u:
					RegisterReciever.smethod_36((ButtonBase)(object)AddReceiptantBtn, "Add Recieptant");
					num = ((int)num2 * -1072151838) ^ -681940527;
					continue;
				case 76u:
					RegisterReciever.smethod_19((Control)(object)BloodGrpLbl, new Size(114, 18));
					num = (int)(num2 * 924557842) ^ -753661720;
					continue;
				case 75u:
					RegisterReciever.smethod_11((Control)(object)RecieverInfoGrp);
					num = ((int)num2 * -2081659315) ^ -417173269;
					continue;
				case 74u:
					num = ((int)num2 * -2092406534) ^ -453508343;
					continue;
				case 73u:
					RegisterReciever.smethod_17((Control)(object)Label1, new Point(240, 268));
					num = (int)(num2 * 2086853046) ^ -745600069;
					continue;
				case 72u:
					num = (int)((num2 * 17709758) ^ 0x1265DCF0);
					continue;
				case 71u:
					RegisterReciever.smethod_32(RegisterReciever.smethod_31(GenderTxt), new object[3] { "MALE", "FEMALE", "OTHERS" });
					num = (int)(num2 * 622864661) ^ -1231463197;
					continue;
				case 70u:
					AgeTxt = RegisterReciever.smethod_6();
					num = ((int)num2 * -1076594447) ^ 0x4AE8D737;
					continue;
				case 69u:
					num = (int)(num2 * 1141881187) ^ -435335229;
					continue;
				case 68u:
					RegisterReciever.smethod_21(MobileLbl, "Mobile :");
					num = ((int)num2 * -1126139689) ^ 0x258A8AB9;
					continue;
				case 67u:
					RegisterReciever.smethod_18((Control)(object)QuantityLbl, "QuantityLbl");
					num = (int)((num2 * 78933800) ^ 0x62E2B0DC);
					continue;
				case 66u:
					num = ((int)num2 * -599853449) ^ -557676512;
					continue;
				case 65u:
					num = (int)((num2 * 219137056) ^ 0x6D0FD3DF);
					continue;
				case 64u:
					RegisterReciever.smethod_17((Control)(object)GenderLbl, new Point(33, 330));
					num = ((int)num2 * -769888661) ^ -1347532860;
					continue;
				case 63u:
					RegisterReciever.smethod_17((Control)(object)SuccessMsg, new Point(311, 166));
					RegisterReciever.smethod_18((Control)(object)SuccessMsg, "SuccessMsg");
					num = (int)(num2 * 2139251643) ^ -1335535722;
					continue;
				case 62u:
					num = (int)(num2 * 253181729) ^ -535226583;
					continue;
				case 61u:
					RegisterReciever.smethod_38(Timer1, bool_0: true);
					num = ((int)num2 * -1593046689) ^ -1413177007;
					continue;
				case 60u:
					num = ((int)num2 * -1152116414) ^ 0x23FDE5CB;
					continue;
				case 59u:
					num = (int)((num2 * 200203241) ^ 0x264F09F1);
					continue;
				case 58u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)AgeLbl);
					num = ((int)num2 * -1059864300) ^ 0x31D6857D;
					continue;
				case 57u:
					RegisterReciever.smethod_16((Control)(object)RegisterLbl, RegisterReciever.smethod_15("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 72602773) ^ -1689795109;
					continue;
				case 56u:
					RegisterReciever.smethod_26(RecieverInfoGrp, "Receiver Information");
					num = ((int)num2 * -1372121805) ^ 0x24109177;
					continue;
				case 55u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)NameTxt);
					RegisterReciever.smethod_16((Control)(object)RecieverInfoGrp, RegisterReciever.smethod_15("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1371807116) ^ -579796698;
					continue;
				case 54u:
					RegisterReciever.smethod_18((Control)(object)Label1, "Label1");
					num = ((int)num2 * -1539819190) ^ -330902535;
					continue;
				case 53u:
					QuantityLbl = RegisterReciever.smethod_4();
					num = ((int)num2 * -241872559) ^ 0x46352355;
					continue;
				case 52u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_48((Control)(object)this), (Control)(object)SuccessMsg);
					num = (int)((num2 * 1051918991) ^ 0x3826BD00);
					continue;
				case 51u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_48((Control)(object)this), (Control)(object)RecieverInfoGrp);
					num = (int)(num2 * 1316097872) ^ -1596354618;
					continue;
				case 50u:
					RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: false);
					num = (int)(num2 * 738376332) ^ -2005603601;
					continue;
				case 49u:
					RegisterReciever.smethod_33((TextBoxBase)(object)DateTxt, bool_0: true);
					num = ((int)num2 * -1952322599) ^ -2021724924;
					continue;
				case 48u:
					RegisterReciever.smethod_17((Control)(object)DateLbl, new Point(33, 389));
					num = ((int)num2 * -919375611) ^ -42070978;
					continue;
				case 47u:
					RegisterReciever.smethod_16((Control)(object)MobileLbl, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1412981776) ^ -120704849;
					continue;
				case 46u:
					RegisterReciever.smethod_39(Timer1, 1500);
					num = ((int)num2 * -667873285) ^ 0x7360178C;
					continue;
				case 45u:
					RegisterReciever.smethod_17((Control)(object)ClearBtn, new Point(420, 674));
					num = ((int)num2 * -2119159773) ^ -1636799811;
					continue;
				case 44u:
					RegisterReciever.smethod_14(DateLbl, bool_0: true);
					num = (int)((num2 * 320149501) ^ 0x7E846988);
					continue;
				case 43u:
					RegisterReciever.smethod_18((Control)(object)PictureBox1, "PictureBox1");
					num = (int)((num2 * 978449437) ^ 0x465A14D8);
					continue;
				case 42u:
					NameLbl = RegisterReciever.smethod_4();
					num = (int)(num2 * 2004050872) ^ -921892419;
					continue;
				case 41u:
					RegisterReciever.smethod_20((Control)(object)NameLbl, 5);
					num = ((int)num2 * -1355072353) ^ 0x4BFD7FC4;
					continue;
				case 40u:
					RegisterReciever.smethod_17((Control)(object)GenderTxt, new Point(135, 327));
					num = ((int)num2 * -999564746) ^ -1161129059;
					continue;
				case 39u:
					num = ((int)num2 * -1918007995) ^ 0x3726C095;
					continue;
				case 38u:
					RegisterReciever.smethod_18((Control)(object)RegisterLbl, "RegisterLbl");
					num = (int)(num2 * 350227508) ^ -405556866;
					continue;
				case 37u:
					num = (int)(num2 * 1474809207) ^ -1035714665;
					continue;
				case 36u:
					num = (int)((num2 * 2075268906) ^ 0x3F4865C7);
					continue;
				case 35u:
					QuantityTxt = RegisterReciever.smethod_6();
					num = ((int)num2 * -1728232819) ^ 0x200EF5AA;
					continue;
				case 34u:
					RegisterReciever.smethod_14(QuantityLbl, bool_0: true);
					num = (int)((num2 * 2100695334) ^ 0x7C1BEDB0);
					continue;
				case 33u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)MobileLbl);
					num = ((int)num2 * -1174137891) ^ -1329181880;
					continue;
				case 32u:
					num = (int)((num2 * 724569475) ^ 0x175466FE);
					continue;
				case 31u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)Label1);
					num = ((int)num2 * -1973362147) ^ 0x44F078C1;
					continue;
				case 30u:
					num = (int)((num2 * 1398316031) ^ 0x5301A363);
					continue;
				case 29u:
					num = (int)((num2 * 1430356754) ^ 0x70A397A7);
					continue;
				case 28u:
					RegisterReciever.smethod_16((Control)(object)SuccessMsg, RegisterReciever.smethod_15("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1923113669) ^ -71794309;
					continue;
				case 27u:
					RegisterReciever.smethod_20((Control)(object)BloodGrpCombo, 20);
					num = (int)((num2 * 701284374) ^ 0x307DD118);
					continue;
				case 26u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)DateLbl);
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)GenderTxt);
					num = (int)((num2 * 518320546) ^ 0x1DEC3ACE);
					continue;
				case 25u:
					RegisterReciever.smethod_18((Control)(object)QuantityTxt, "QuantityTxt");
					num = ((int)num2 * -790536798) ^ 0x2B176187;
					continue;
				case 24u:
					RegisterReciever.smethod_19((Control)(object)AgeTxt, new Size(124, 24));
					RegisterReciever.smethod_20((Control)(object)AgeTxt, 10);
					num = ((int)num2 * -1620353472) ^ -846516814;
					continue;
				case 23u:
					RegisterReciever.smethod_16((Control)(object)ClearBtn, RegisterReciever.smethod_15("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1237466672) ^ 0x4BD92CF);
					continue;
				case 22u:
					RegisterReciever.smethod_18((Control)(object)RecieverInfoGrp, "RecieverInfoGrp");
					num = ((int)num2 * -1318191869) ^ -769096127;
					continue;
				case 21u:
					num = (int)((num2 * 620378243) ^ 0x696067B8);
					continue;
				case 20u:
					RegisterReciever.smethod_21(QuantityLbl, "Quantity :");
					num = ((int)num2 * -597891643) ^ -975125717;
					continue;
				case 19u:
					RegisterReciever.smethod_20((Control)(object)MobileTxt, 2);
					RegisterReciever.smethod_16((Control)(object)NameTxt, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -854967993) ^ -1221996128;
					continue;
				case 18u:
					num = (int)(num2 * 603239482) ^ -1382790402;
					continue;
				case 17u:
					num = ((int)num2 * -1352649276) ^ -1833371759;
					continue;
				case 16u:
					num = ((int)num2 * -580146104) ^ 0x71BE8C13;
					continue;
				case 15u:
					AgeLbl = RegisterReciever.smethod_4();
					num = (int)(num2 * 944541764) ^ -12429078;
					continue;
				case 14u:
					RegisterReciever.smethod_16((Control)(object)Label1, RegisterReciever.smethod_15("MS Reference Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1779125032) ^ -439508415;
					continue;
				case 13u:
					RegisterReciever.smethod_35((Control)(object)Label1, Color.Red);
					num = ((int)num2 * -1809780077) ^ 0x41F49406;
					continue;
				case 12u:
					RegisterReciever.smethod_16((Control)(object)GenderLbl, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1688640328) ^ 0xD212750);
					continue;
				case 11u:
					num = (int)((num2 * 2020219104) ^ 0x692A4FFB);
					continue;
				case 10u:
					RegisterReciever.smethod_24(RegisterReciever.smethod_23((Control)(object)RecieverInfoGrp), (Control)(object)DateTxt);
					num = (int)(num2 * 274370830) ^ -1110942302;
					continue;
				case 9u:
					RegisterReciever.smethod_18((Control)(object)GenderTxt, "GenderTxt");
					RegisterReciever.smethod_19((Control)(object)GenderTxt, new Size(124, 27));
					num = (int)((num2 * 75522185) ^ 0x7A9CE9C4);
					continue;
				case 8u:
					RegisterReciever.smethod_16((Control)(object)DateLbl, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -942278501) ^ 0x1D58BE3C;
					continue;
				case 7u:
					RegisterReciever.smethod_52((Control)(object)RecieverInfoGrp);
					num = (int)(num2 * 2130796856) ^ -702352117;
					continue;
				case 6u:
					RegisterReciever.smethod_18((Control)(object)ClearBtn, "ClearBtn");
					num = (int)((num2 * 550767712) ^ 0x238AA893);
					continue;
				case 5u:
					RegisterReciever.smethod_51((Control)(object)RecieverInfoGrp, bool_0: false);
					num = (int)(num2 * 1192991506) ^ -1797521151;
					continue;
				case 4u:
					RegisterReciever.smethod_17((Control)(object)PictureBox1, new Point(215, 26));
					num = ((int)num2 * -1165416539) ^ -647379965;
					continue;
				case 3u:
					num = (int)((num2 * 827401437) ^ 0x265C0E4B);
					continue;
				case 2u:
					RegisterReciever.smethod_19((Control)(object)AddReceiptantBtn, new Size(148, 51));
					RegisterReciever.smethod_20((Control)(object)AddReceiptantBtn, 13);
					num = ((int)num2 * -48116222) ^ -372131507;
					continue;
				case 1u:
					RegisterReciever.smethod_16((Control)(object)AgeLbl, RegisterReciever.smethod_15("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					RegisterReciever.smethod_17((Control)(object)AgeLbl, new Point(33, 109));
					RegisterReciever.smethod_18((Control)(object)AgeLbl, "AgeLbl");
					num = ((int)num2 * -1544611894) ^ 0x4A289F1D;
					continue;
				case 0u:
					RegisterReciever.smethod_21(GenderLbl, "Gender :");
					num = ((int)num2 * -63685737) ^ -121754625;
					continue;
				default:
					return;
				case 205u:
					break;
				case 96u:
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
			int num = -958408087;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC3AAFA0Cu) % 4u)
				{
				case 3u:
					RegisterReciever.smethod_62(DateTxt, DateTime.Today.ToShortDateString());
					num = (int)(num2 * 1788251618) ^ -1252941082;
					continue;
				case 1u:
					RegisterReciever.smethod_61(myconnection, RegisterReciever.smethod_60(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
					num = ((int)num2 * -322698264) ^ -343162665;
					continue;
				case 2u:
					break;
				default:
					RegisterReciever.smethod_63(BloodGrpCombo, 0);
					return;
				}
				break;
			}
		}
	}

	private void AddReceiptantBtn_Click(object sender, EventArgs e)
	{
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected I4, but got Unknown
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected I4, but got Unknown
		//IL_03f1: Incompatible stack heights: 0 vs 1
		//IL_040c: Incompatible stack heights: 0 vs 1
		//IL_0428: Incompatible stack heights: 0 vs 1
		//IL_044b: Incompatible stack heights: 0 vs 1
		//IL_045e: Incompatible stack heights: 0 vs 1
		//IL_0471: Incompatible stack heights: 0 vs 1
		//IL_048f: Incompatible stack heights: 0 vs 1
		//IL_0499: Incompatible stack heights: 0 vs 1
		string string_ = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = -320651645;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFEC6DFA5u) % 7u)
				{
				case 6u:
					string_ = "Insert Into [Recievers] ([Name],[Age],[Gender],[Blood Group],[Contact Number],[Blood Recieved],[Date of Recieve]) Values (?,?,?,?,?,?,?)";
					num = (int)((num2 * 564538785) ^ 0x3018AC22);
					continue;
				case 2u:
					num = -545732646;
					continue;
				case 1u:
					flag = !Validate_data();
					num = (int)((num2 * 557039635) ^ 0x27175B59);
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1443818837;
						num5 = -1443818837;
					}
					else
					{
						num4 = -234117682;
						num5 = -234117682;
					}
					num = num4 ^ ((int)num2 * -318637593);
					continue;
				}
				case 3u:
					break;
				default:
					RegisterReciever.smethod_64(myconnection);
					try
					{
						OleDbCommand val = RegisterReciever.smethod_65(string_, myconnection);
						while (true)
						{
							int num3 = -2085105981;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xFEC6DFA5u) % 18u)
								{
								case 17u:
									RegisterReciever.smethod_70(RegisterReciever.smethod_66(val), RegisterReciever.smethod_69("Blood Recieved", (object)RegisterReciever.smethod_67(QuantityTxt)));
									num3 = (int)((num2 * 1404908251) ^ 0xDB7953D);
									continue;
								case 16u:
									num3 = ((int)num2 * -1918136661) ^ -1495926380;
									continue;
								case 15u:
									RegisterReciever.smethod_70(RegisterReciever.smethod_66(val), RegisterReciever.smethod_69("Date of Recieve", (object)RegisterReciever.smethod_67(DateTxt)));
									num3 = ((int)num2 * -2013273917) ^ -645898952;
									continue;
								case 14u:
									RegisterReciever.smethod_77(Timer1);
									num3 = ((int)num2 * -1004230099) ^ 0x29E15FE6;
									continue;
								case 13u:
									RegisterReciever.smethod_76(myconnection);
									num3 = ((int)num2 * -1484906309) ^ 0x7885D27F;
									continue;
								case 10u:
									RegisterReciever.smethod_75((Component)(object)val);
									num3 = (int)((num2 * 1376229023) ^ 0x2D22DE19);
									continue;
								case 9u:
									num3 = (int)((num2 * 759602497) ^ 0x3C68DD12);
									continue;
								case 8u:
									RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: true);
									num3 = ((int)num2 * -1237763817) ^ -1306284916;
									continue;
								case 7u:
									RegisterReciever.smethod_21(SuccessMsg, "Reciever Successfully Registered !!");
									RegisterReciever.smethod_47((Control)(object)SuccessMsg, Color.Green);
									num3 = ((int)num2 * -1341542876) ^ -134215986;
									continue;
								case 6u:
									RegisterReciever.smethod_70(RegisterReciever.smethod_66(val), RegisterReciever.smethod_69("Name", (object)RegisterReciever.smethod_68(RegisterReciever.smethod_67(NameTxt))));
									num3 = (int)((num2 * 673159216) ^ 0x1F13D134);
									continue;
								case 5u:
									RegisterReciever.smethod_70(RegisterReciever.smethod_66(val), RegisterReciever.smethod_69("Age", (object)(int)RegisterReciever.smethod_71(RegisterReciever.smethod_67(AgeTxt))));
									num3 = ((int)num2 * -380129104) ^ 0x54C7551D;
									continue;
								case 4u:
									RegisterReciever.smethod_74(val);
									num3 = (int)(num2 * 881912548) ^ -50773923;
									continue;
								case 3u:
									num3 = ((int)num2 * -412520938) ^ 0x3DB13A59;
									continue;
								case 2u:
									RegisterReciever.smethod_70(RegisterReciever.smethod_66(val), RegisterReciever.smethod_69("Gender", (object)RegisterReciever.smethod_68(RegisterReciever.smethod_72(GenderTxt))));
									num3 = ((int)num2 * -1499325759) ^ -1624528283;
									continue;
								case 1u:
									num3 = ((int)num2 * -1689464692) ^ -2130793504;
									continue;
								case 0u:
									RegisterReciever.smethod_70(RegisterReciever.smethod_66(val), RegisterReciever.smethod_69("Blood Group", (object)RegisterReciever.smethod_72(BloodGrpCombo)));
									RegisterReciever.smethod_70(RegisterReciever.smethod_66(val), RegisterReciever.smethod_69("Contact Number", (object)RegisterReciever.smethod_73(RegisterReciever.smethod_67(MobileTxt))));
									num3 = ((int)num2 * -860122626) ^ 0x59A2375C;
									continue;
								default:
									return;
								case 12u:
									break;
								case 11u:
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
							_ = -1329350487;
							while (true)
							{
								_003F val2 = /*Error near IL_039f: Stack underflow*/^ -20521051;
								num2 = (uint)(int)val2;
								switch (val2 % 9)
								{
								case 8:
									RegisterReciever.smethod_21(SuccessMsg, "Invalid Credentials");
									_ = ((int)num2 * -840869226) ^ -1593317024;
									continue;
								case 6:
									RegisterReciever.smethod_76(myconnection);
									_ = (num2 * 2108605434) ^ 0xAE9B8107u;
									continue;
								case 5:
									RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: true);
									_ = (num2 * 1642755650) ^ 0x906A51E1u;
									continue;
								case 4:
									RegisterReciever.smethod_47((Control)(object)SuccessMsg, Color.Red);
									_ = ((int)num2 * -677615745) ^ -1896586069;
									continue;
								case 3:
									_ = ((int)num2 * -1046172991) ^ 0x24F4BB1F;
									continue;
								case 2:
									_ = (num2 * 890374888) ^ 0x94040E15u;
									continue;
								case 0:
									RegisterReciever.smethod_77(Timer1);
									_ = (num2 * 88740661) ^ 0x6373523C;
									continue;
								case 7:
									break;
								default:
									RegisterReciever.smethod_79();
									return;
								}
								break;
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

	private bool Validate_data()
	{
		bool flag2 = default(bool);
		bool result = default(bool);
		bool flag4 = default(bool);
		bool flag = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 1586185919;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2572B10Eu) % 55u)
				{
				case 54u:
				{
					int num13;
					int num14;
					if (!MyProject.Forms.Form1.Gender_Validator(RegisterReciever.smethod_68(RegisterReciever.smethod_72(GenderTxt))))
					{
						num13 = 223934440;
						num14 = 223934440;
					}
					else
					{
						num13 = 572272210;
						num14 = 572272210;
					}
					num = num13 ^ ((int)num2 * -1613211500);
					continue;
				}
				case 53u:
					num = ((int)num2 * -1729558332) ^ 0x625670AF;
					continue;
				case 52u:
					RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: true);
					RegisterReciever.smethod_21(SuccessMsg, "Invalid Quantity");
					num = (int)((num2 * 212789630) ^ 0x73F5717A);
					continue;
				case 51u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = -2144453801;
						num10 = -2144453801;
					}
					else
					{
						num9 = -136127215;
						num10 = -136127215;
					}
					num = num9 ^ ((int)num2 * -721089114);
					continue;
				}
				case 50u:
					num = (int)(num2 * 1674345577) ^ -1003271208;
					continue;
				case 49u:
					RegisterReciever.smethod_21(SuccessMsg, "Invalid Name");
					RegisterReciever.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -877197196) ^ 0x801CAC2;
					continue;
				case 48u:
					RegisterReciever.smethod_77(Timer1);
					num = ((int)num2 * -1143146780) ^ -1643999629;
					continue;
				case 47u:
					RegisterReciever.smethod_77(Timer1);
					result = false;
					num = ((int)num2 * -1616135630) ^ -1339550746;
					continue;
				case 46u:
					RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: true);
					RegisterReciever.smethod_21(SuccessMsg, "Invalid Age");
					RegisterReciever.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = (int)(num2 * 590339445) ^ -882109413;
					continue;
				case 45u:
					num = (int)(num2 * 635543945) ^ -1701729182;
					continue;
				case 44u:
					RegisterReciever.smethod_77(Timer1);
					num = (int)((num2 * 258694906) ^ 0x53BC7AF2);
					continue;
				case 43u:
				{
					int num11;
					int num12;
					if (!flag4)
					{
						num11 = 635804566;
						num12 = 635804566;
					}
					else
					{
						num11 = 1273808122;
						num12 = 1273808122;
					}
					num = num11 ^ (int)(num2 * 534250994);
					continue;
				}
				case 42u:
					num = 34970714;
					continue;
				case 41u:
					num = ((int)num2 * -84302378) ^ -1946481203;
					continue;
				case 39u:
					num = (int)(num2 * 1949245570) ^ -1273796329;
					continue;
				case 38u:
					flag4 = !MyProject.Forms.Form1.Mobile_Validator(RegisterReciever.smethod_67(MobileTxt));
					num = (int)((num2 * 182876113) ^ 0x6A4359DF);
					continue;
				case 37u:
					RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -570197458) ^ 0x580A8B56;
					continue;
				case 35u:
					RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: true);
					RegisterReciever.smethod_21(SuccessMsg, "Select Proper Blood Group");
					num = (int)((num2 * 1717316304) ^ 0x5DA7A3F0);
					continue;
				case 34u:
					RegisterReciever.smethod_77(Timer1);
					num = (int)(num2 * 344429082) ^ -896634199;
					continue;
				case 33u:
					RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: true);
					num = (int)((num2 * 1469754813) ^ 0x3FD1886D);
					continue;
				case 32u:
					result = false;
					num = ((int)num2 * -1993046307) ^ -233772882;
					continue;
				case 31u:
					num = (int)((num2 * 88458753) ^ 0x591DF324);
					continue;
				case 30u:
					num = (int)(num2 * 1706077108) ^ -1020278464;
					continue;
				case 29u:
					num = (int)((num2 * 1428335558) ^ 0x2FC7442B);
					continue;
				case 28u:
					RegisterReciever.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = (int)((num2 * 584408660) ^ 0x63BC7446);
					continue;
				case 27u:
					RegisterReciever.smethod_77(Timer1);
					num = (int)(num2 * 1790858071) ^ -99679522;
					continue;
				case 26u:
					result = true;
					num = ((int)num2 * -1908891342) ^ 0x690BB3E2;
					continue;
				case 25u:
					result = false;
					num = ((int)num2 * -1802934397) ^ -1930409433;
					continue;
				case 24u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = -1169882469;
						num8 = -1169882469;
					}
					else
					{
						num7 = -1365666025;
						num8 = -1365666025;
					}
					num = num7 ^ ((int)num2 * -1956344785);
					continue;
				}
				case 23u:
					flag3 = RegisterReciever.smethod_80(BloodGrpCombo) == 0;
					num = 1805702447;
					continue;
				case 22u:
					RegisterReciever.smethod_21(SuccessMsg, "Invalid Gender");
					num = ((int)num2 * -1038189938) ^ -121646215;
					continue;
				case 21u:
				{
					int num5;
					int num6;
					if (!MyProject.Forms.Form1.age_validator(RegisterReciever.smethod_67(AgeTxt)))
					{
						num5 = -495294120;
						num6 = -495294120;
					}
					else
					{
						num5 = -2128166336;
						num6 = -2128166336;
					}
					num = num5 ^ (int)(num2 * 640161140);
					continue;
				}
				case 20u:
					RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -1547872587) ^ -463709120;
					continue;
				case 19u:
					num = ((int)num2 * -246409828) ^ 0x2C4B50B3;
					continue;
				case 18u:
					num = (int)((num2 * 1595465865) ^ 0xCB63976);
					continue;
				case 17u:
					num = (int)((num2 * 2132318855) ^ 0x7D737E12);
					continue;
				case 16u:
					num = (int)(num2 * 729856223) ^ -1695999713;
					continue;
				case 15u:
					RegisterReciever.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = (int)(num2 * 1586796930) ^ -934385184;
					continue;
				case 14u:
					RegisterReciever.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -470857518) ^ -1555238019;
					continue;
				case 13u:
					num = (int)((num2 * 504176600) ^ 0x3CB94D56);
					continue;
				case 12u:
					result = false;
					num = (int)(num2 * 1549432560) ^ -194014979;
					continue;
				case 11u:
					num = ((int)num2 * -1660541309) ^ -1900099552;
					continue;
				case 10u:
					RegisterReciever.smethod_47((Control)(object)SuccessMsg, Color.Red);
					num = (int)(num2 * 1416471988) ^ -88270065;
					continue;
				case 9u:
					num = 1226035837;
					continue;
				case 8u:
					RegisterReciever.smethod_21(SuccessMsg, "Invalid Mobile Number");
					num = (int)(num2 * 1503802009) ^ -2034097525;
					continue;
				case 7u:
					num = 541874497;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (flag3)
					{
						num3 = -1586755828;
						num4 = -1586755828;
					}
					else
					{
						num3 = -2070524437;
						num4 = -2070524437;
					}
					num = num3 ^ (int)(num2 * 1400408838);
					continue;
				}
				case 5u:
					flag2 = !MyProject.Forms.Form1.Decimal_Validator(RegisterReciever.smethod_67(QuantityTxt));
					num = 1949928993;
					continue;
				case 4u:
					num = 1594299150;
					continue;
				case 3u:
					num = (int)((num2 * 1823145401) ^ 0x6663EFE1);
					continue;
				case 2u:
					RegisterReciever.smethod_77(Timer1);
					result = false;
					num = (int)((num2 * 1771906893) ^ 0x536A21C7);
					continue;
				case 1u:
					flag = !MyProject.Forms.Form1.Name_Validation(RegisterReciever.smethod_68(RegisterReciever.smethod_67(NameTxt)));
					num = ((int)num2 * -252894758) ^ 0xF3AE8CC;
					continue;
				case 0u:
					result = false;
					num = (int)((num2 * 479942741) ^ 0x1A540214);
					continue;
				case 36u:
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
			int num = -1161157637;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF06E0701u) % 9u)
				{
				case 8u:
					num = (int)(num2 * 2049133013) ^ -1747504599;
					continue;
				case 7u:
					num = (int)(num2 * 2042407147) ^ -25772418;
					continue;
				case 6u:
					RegisterReciever.smethod_62(DateTxt, RegisterReciever.smethod_82((object)DateTime.Now, "dd-MM-yyyy"));
					RegisterReciever.smethod_81((TextBoxBase)(object)QuantityTxt);
					num = ((int)num2 * -721258477) ^ 0x7881F7D5;
					continue;
				case 5u:
					RegisterReciever.smethod_81((TextBoxBase)(object)NameTxt);
					RegisterReciever.smethod_81((TextBoxBase)(object)AgeTxt);
					num = ((int)num2 * -1116465249) ^ -1325405229;
					continue;
				case 4u:
					RegisterReciever.smethod_81((TextBoxBase)(object)MobileTxt);
					num = (int)(num2 * 442873334) ^ -1448590382;
					continue;
				case 3u:
					RegisterReciever.smethod_63(GenderTxt, -1);
					num = (int)(num2 * 1346091280) ^ -1667974605;
					continue;
				case 2u:
					RegisterReciever.smethod_63(BloodGrpCombo, 0);
					num = ((int)num2 * -1130985364) ^ 0x4BDF3CA1;
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

	private void Timer1_Tick(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1444397561;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDC6B4015u) % 5u)
				{
				case 2u:
					RegisterReciever.smethod_40((Control)(object)SuccessMsg, bool_0: false);
					num = (int)(num2 * 278194952) ^ -924978779;
					continue;
				case 1u:
					RegisterReciever.smethod_83(Timer1);
					num = (int)((num2 * 1479965826) ^ 0x7EB05E17);
					continue;
				case 0u:
					num = (int)(num2 * 2113631812) ^ -1438801620;
					continue;
				default:
					return;
				case 4u:
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
