using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hospital_Management_System.My;
using Hospital_Management_System.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hospital_Management_System;

[DesignerGenerated]
public class AddStaff_Admin : UserControl
{
	private IContainer components;

	private string username;

	private string password;

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

	[field: AccessedThroughProperty("SuccessMsg")]
	internal virtual Label SuccessMsg
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

	[field: AccessedThroughProperty("GenderTxt")]
	internal virtual ComboBox GenderTxt
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

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
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

	[field: AccessedThroughProperty("WorkShiftTxt")]
	internal virtual ComboBox WorkShiftTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DesignationTxt")]
	internal virtual ComboBox DesignationTxt
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
			Button registerBtn = _RegisterBtn;
			while (true)
			{
				int num = 1968584270;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3A912C87u) % 8u)
					{
					case 7u:
					{
						int num5;
						int num6;
						if (registerBtn != null)
						{
							num5 = -476565007;
							num6 = -476565007;
						}
						else
						{
							num5 = -564981620;
							num6 = -564981620;
						}
						num = num5 ^ (int)(num2 * 679650571);
						continue;
					}
					case 5u:
						registerBtn = _RegisterBtn;
						num = ((int)num2 * -523248723) ^ -858331799;
						continue;
					case 3u:
						AddStaff_Admin.smethod_61((Control)(object)registerBtn, eventHandler_);
						num = ((int)num2 * -38630455) ^ -1483028606;
						continue;
					case 2u:
						_RegisterBtn = value;
						num = 1971143938;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (registerBtn != null)
						{
							num3 = 149833410;
							num4 = 149833410;
						}
						else
						{
							num3 = 716395856;
							num4 = 716395856;
						}
						num = num3 ^ ((int)num2 * -1571214931);
						continue;
					}
					case 0u:
						AddStaff_Admin.smethod_60((Control)(object)registerBtn, eventHandler_);
						num = (int)((num2 * 1742084078) ^ 0x69662A65);
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
				int num = -209413421;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC9EFB8C2u) % 7u)
					{
					case 5u:
					{
						clearBtn = _ClearBtn;
						int num5;
						int num6;
						if (clearBtn == null)
						{
							num5 = 1314189729;
							num6 = 1314189729;
						}
						else
						{
							num5 = 2111667021;
							num6 = 2111667021;
						}
						num = num5 ^ (int)(num2 * 1156717025);
						continue;
					}
					case 4u:
					{
						int num3;
						int num4;
						if (clearBtn != null)
						{
							num3 = 107044788;
							num4 = 107044788;
						}
						else
						{
							num3 = 577855027;
							num4 = 577855027;
						}
						num = num3 ^ ((int)num2 * -952714288);
						continue;
					}
					case 2u:
						AddStaff_Admin.smethod_60((Control)(object)clearBtn, eventHandler_);
						num = (int)((num2 * 1641244783) ^ 0x109204F2);
						continue;
					case 1u:
						AddStaff_Admin.smethod_61((Control)(object)clearBtn, eventHandler_);
						num = ((int)num2 * -1784820232) ^ -1772461277;
						continue;
					case 0u:
						_ClearBtn = value;
						clearBtn = _ClearBtn;
						num = -1854033210;
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

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("EmailTxt")]
	internal virtual TextBox EmailTxt
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
				int num = 1899709189;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x43B56812u) % 8u)
					{
					case 7u:
						timer = _Timer1;
						num = ((int)num2 * -988833429) ^ 0x7D56027;
						continue;
					case 5u:
						AddStaff_Admin.smethod_62(timer, eventHandler_);
						num = (int)(num2 * 2079459703) ^ -27835494;
						continue;
					case 4u:
						AddStaff_Admin.smethod_63(timer, eventHandler_);
						num = ((int)num2 * -1036952415) ^ -1808612769;
						continue;
					case 3u:
						_Timer1 = value;
						num = 2052080312;
						continue;
					case 2u:
					{
						timer = _Timer1;
						int num5;
						int num6;
						if (timer == null)
						{
							num5 = -1323083915;
							num6 = -1323083915;
						}
						else
						{
							num5 = -587342664;
							num6 = -587342664;
						}
						num = num5 ^ ((int)num2 * -494673113);
						continue;
					}
					case 0u:
					{
						int num3;
						int num4;
						if (timer != null)
						{
							num3 = -389235161;
							num4 = -389235161;
						}
						else
						{
							num3 = -1850008071;
							num4 = -1850008071;
						}
						num = num3 ^ (int)(num2 * 1956832550);
						continue;
					}
					default:
						return;
					case 6u:
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

	public AddStaff_Admin()
	{
		while (true)
		{
			int num = 1651086231;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3B587095u) % 4u)
				{
				case 2u:
					AddStaff_Admin.smethod_0((UserControl)(object)this, (EventHandler)AddStaff_Admin_Load);
					num = ((int)num2 * -1017551842) ^ 0x4985A7E8;
					continue;
				case 1u:
					InitializeComponent();
					num = (int)(num2 * 894505950) ^ -849619124;
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

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (!disposing)
			{
				goto IL_000a;
			}
			goto IL_004f;
			IL_004f:
			int num = 194226093;
			goto IL_0054;
			IL_0054:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6A5430D6u) % 6u)
				{
				case 4u:
					num = ((int)num2 * -1292300814) ^ 0x12A650B3;
					continue;
				case 2u:
					AddStaff_Admin.smethod_1((IDisposable)components);
					num = ((int)num2 * -986401368) ^ 0x99A7DCF;
					continue;
				case 1u:
					num = ((int)num2 * -2018560717) ^ 0x2CBEE5BB;
					continue;
				case 0u:
					break;
				default:
					return;
				case 3u:
					goto IL_007d;
				case 5u:
					return;
				}
				break;
				IL_007d:
				if (components != null)
				{
					num = 2058575484;
					num3 = 2058575484;
					continue;
				}
				goto IL_000a;
			}
			goto IL_004f;
			IL_000a:
			num = 1116693343;
			num3 = 1116693343;
			goto IL_0054;
		}
		finally
		{
			while (true)
			{
				IL_00d1:
				int num4 = 1051247072;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num4 ^ 0x6A5430D6u) % 3u)
					{
					case 1u:
						goto IL_00a0;
					default:
						goto end_IL_00b4;
					case 2u:
						break;
					case 0u:
						goto end_IL_00b4;
					}
					goto IL_00d1;
					IL_00a0:
					((ContainerControl)this).Dispose(disposing);
					num4 = (int)(num2 * 2077997823) ^ -699029853;
					continue;
					end_IL_00b4:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		components = AddStaff_Admin.smethod_2();
		while (true)
		{
			int num = 1140048144;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x66460F2Au) % 272u)
				{
				case 271u:
					AddStaff_Admin.smethod_25(Label1, (ContentAlignment)32);
					num = ((int)num2 * -1442185705) ^ -2080504395;
					continue;
				case 270u:
					AddStaff_Admin.smethod_23((Control)(object)Label9, 18);
					num = ((int)num2 * -1411399002) ^ -1967231264;
					continue;
				case 269u:
					AddStaff_Admin.smethod_22((Control)(object)NameTxt, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					AddStaff_Admin.smethod_15((Control)(object)NameTxt, new Point(137, 55));
					num = (int)((num2 * 1631607386) ^ 0x49CFAD6A);
					continue;
				case 268u:
					AddStaff_Admin.smethod_40(DesignationTxt, (AutoCompleteMode)2);
					num = (int)((num2 * 1537951453) ^ 0x70BE4BAB);
					continue;
				case 267u:
					num = (int)((num2 * 1642885225) ^ 0x4C4347E3);
					continue;
				case 266u:
					num = (int)(num2 * 1305263806) ^ -372234544;
					continue;
				case 265u:
					num = ((int)num2 * -681619803) ^ 0xDB30CBB;
					continue;
				case 264u:
					AddStaff_Admin.smethod_46(AddressTxt, bool_0: true);
					num = ((int)num2 * -1437277498) ^ -2084993594;
					continue;
				case 263u:
					num = (int)(num2 * 1733258514) ^ -766961208;
					continue;
				case 262u:
					num = (int)(num2 * 404570616) ^ -81048481;
					continue;
				case 261u:
					num = ((int)num2 * -743795219) ^ -1183558198;
					continue;
				case 260u:
					AddStaff_Admin.smethod_56((ISupportInitialize)PictureBox1);
					num = (int)((num2 * 410543567) ^ 0x59C7AE36);
					continue;
				case 259u:
					AddStaff_Admin.smethod_17((Control)(object)Label7, new Size(128, 26));
					num = (int)(num2 * 30172895) ^ -884462977;
					continue;
				case 258u:
					num = (int)(num2 * 1864734755) ^ -1912072188;
					continue;
				case 257u:
					AddStaff_Admin.smethod_42(DesignationTxt, (ComboBoxStyle)2);
					num = ((int)num2 * -536025878) ^ 0x42685335;
					continue;
				case 256u:
					AddStaff_Admin.smethod_23((Control)(object)Label8, 16);
					num = ((int)num2 * -96173919) ^ 0x5D4FFCF4;
					continue;
				case 255u:
					AddStaff_Admin.smethod_41(WorkShiftTxt, (AutoCompleteSource)256);
					num = (int)(num2 * 1578161052) ^ -1229186599;
					continue;
				case 254u:
					AddStaff_Admin.smethod_50(Timer1, 1500);
					num = ((int)num2 * -819969099) ^ -1479726852;
					continue;
				case 253u:
					AddStaff_Admin.smethod_37(DOBTxt, new DateTime(2019, 2, 11, 0, 0, 0, 0));
					num = ((int)num2 * -1616115687) ^ 0x2AAB32E4;
					continue;
				case 252u:
					EmailTxt = AddStaff_Admin.smethod_7();
					num = (int)(num2 * 1346399149) ^ -595668931;
					continue;
				case 251u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)Label8);
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)WorkShiftTxt);
					num = ((int)num2 * -1936338681) ^ 0x4DAC363E;
					continue;
				case 250u:
					num = (int)((num2 * 1404991562) ^ 0x4473D1CF);
					continue;
				case 249u:
					AddStaff_Admin.smethod_49((ButtonBase)(object)ClearBtn, bool_0: false);
					num = (int)(num2 * 1940741120) ^ -557002604;
					continue;
				case 248u:
					num = ((int)num2 * -1958385913) ^ -401261056;
					continue;
				case 247u:
					AddStaff_Admin.smethod_42(WorkShiftTxt, (ComboBoxStyle)2);
					num = ((int)num2 * -1511443246) ^ 0x30C87AAA;
					continue;
				case 246u:
					AddStaff_Admin.smethod_15((Control)(object)Label9, new Point(13, 307));
					num = ((int)num2 * -1319899654) ^ 0x409EFE79;
					continue;
				case 245u:
					AddStaff_Admin.smethod_34(DOBTxt, (DateTimePickerFormat)2);
					num = ((int)num2 * -1689769371) ^ 0x6E809072;
					continue;
				case 244u:
					AddStaff_Admin.smethod_15((Control)(object)Label6, new Point(15, 348));
					AddStaff_Admin.smethod_16((Control)(object)Label6, "Label6");
					num = ((int)num2 * -2117939930) ^ -230341328;
					continue;
				case 243u:
					AddStaff_Admin.smethod_39(AddStaff_Admin.smethod_38(GenderTxt), new string[3] { "Male", "Female", "Others" });
					num = ((int)num2 * -1523504188) ^ -118762295;
					continue;
				case 242u:
					AddStaff_Admin.smethod_16((Control)(object)NameTxt, "NameTxt");
					num = ((int)num2 * -1072104298) ^ 0x33CC9778;
					continue;
				case 241u:
					AddStaff_Admin.smethod_16((Control)(object)DOBTxt, "DOBTxt");
					num = (int)(num2 * 1353222504) ^ -376140177;
					continue;
				case 240u:
					num = (int)((num2 * 1319799420) ^ 0x3EBF2C92);
					continue;
				case 239u:
					AddStaff_Admin.smethod_25(SuccessMsg, (ContentAlignment)32);
					num = (int)(num2 * 1564525867) ^ -250372877;
					continue;
				case 238u:
					num = ((int)num2 * -2131981194) ^ 0xD177925;
					continue;
				case 237u:
					AddStaff_Admin.smethod_26((Control)(object)this, Color.White);
					num = (int)((num2 * 1998472638) ^ 0x302FC930);
					continue;
				case 236u:
					num = (int)(num2 * 973041335) ^ -1613375288;
					continue;
				case 235u:
					AddStaff_Admin.smethod_23((Control)(object)Label5, 8);
					num = (int)(num2 * 478766504) ^ -2083277830;
					continue;
				case 234u:
					AddStaff_Admin.smethod_16((Control)(object)AddressTxt, "AddressTxt");
					num = ((int)num2 * -1115324703) ^ 0x4DFF3D8D;
					continue;
				case 233u:
					num = (int)((num2 * 200958984) ^ 0x371FD897);
					continue;
				case 232u:
					RegisterBtn = AddStaff_Admin.smethod_9();
					ClearBtn = AddStaff_Admin.smethod_9();
					num = (int)(num2 * 406232459) ^ -1715833109;
					continue;
				case 231u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)DOBTxt);
					num = ((int)num2 * -1692288684) ^ 0x333CB4BF;
					continue;
				case 230u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)Label4);
					num = (int)((num2 * 518805270) ^ 0x74067C26);
					continue;
				case 229u:
					AddStaff_Admin.smethod_17((Control)(object)SuccessMsg, new Size(401, 44));
					num = ((int)num2 * -541351008) ^ -748245142;
					continue;
				case 228u:
					AddStaff_Admin.smethod_24(Label2, "Name :");
					num = ((int)num2 * -811223378) ^ 0x3A23CE46;
					continue;
				case 227u:
					AddStaff_Admin.smethod_22((Control)(object)RegisterBtn, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -486269808) ^ -1936911260;
					continue;
				case 226u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)Label3);
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)Label2);
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)NameTxt);
					num = ((int)num2 * -241192983) ^ -582389200;
					continue;
				case 225u:
					AddStaff_Admin.smethod_16((Control)(object)ClearBtn, "ClearBtn");
					AddStaff_Admin.smethod_17((Control)(object)ClearBtn, new Size(143, 43));
					num = (int)(num2 * 927661536) ^ -1644670310;
					continue;
				case 224u:
					num = ((int)num2 * -47748736) ^ -990709051;
					continue;
				case 223u:
					WorkShiftTxt = AddStaff_Admin.smethod_8();
					Label7 = AddStaff_Admin.smethod_4();
					num = (int)((num2 * 1410272475) ^ 0x4D4957CB);
					continue;
				case 222u:
					AddStaff_Admin.smethod_45(AddStaff_Admin.smethod_44(GenderTxt), new object[3] { "Male", "Female", "Others" });
					num = ((int)num2 * -1951936066) ^ -114555578;
					continue;
				case 221u:
					num = ((int)num2 * -1229969605) ^ 0x6D771992;
					continue;
				case 220u:
					AddStaff_Admin.smethod_16((Control)(object)Label7, "Label7");
					num = ((int)num2 * -1030999093) ^ 0x141FB58D;
					continue;
				case 219u:
					AddStaff_Admin.smethod_22((Control)(object)Label9, AddStaff_Admin.smethod_21("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1606876753) ^ 0x46C6BA5;
					continue;
				case 218u:
					num = ((int)num2 * -1142783074) ^ -1241425619;
					continue;
				case 217u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)EmailTxt);
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)Label9);
					num = ((int)num2 * -58119821) ^ 0x370FFD2D;
					continue;
				case 216u:
					Label3 = AddStaff_Admin.smethod_4();
					num = (int)(num2 * 588095851) ^ -2056284296;
					continue;
				case 215u:
					AddStaff_Admin.smethod_25(Label8, (ContentAlignment)32);
					num = (int)(num2 * 1208005762) ^ -202131763;
					continue;
				case 214u:
					AddStaff_Admin.smethod_25(Label3, (ContentAlignment)32);
					num = (int)((num2 * 60032) ^ 0x66BF8BEB);
					continue;
				case 212u:
					AddStaff_Admin.smethod_25(Label2, (ContentAlignment)32);
					num = (int)(num2 * 658082255) ^ -46002405;
					continue;
				case 211u:
					AddStaff_Admin.smethod_16((Control)(object)WorkShiftTxt, "WorkShiftTxt");
					num = (int)((num2 * 180841308) ^ 0x81528FA);
					continue;
				case 210u:
					AddStaff_Admin.smethod_22((Control)(object)Label1, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					AddStaff_Admin.smethod_15((Control)(object)Label1, new Point(392, 63));
					num = (int)(num2 * 83502693) ^ -412948863;
					continue;
				case 209u:
					AddStaff_Admin.smethod_17((Control)(object)Label5, new Size(94, 29));
					num = (int)((num2 * 650865382) ^ 0x21171146);
					continue;
				case 208u:
					AddStaff_Admin.smethod_43((ListControl)(object)WorkShiftTxt, bool_0: true);
					num = (int)((num2 * 2047541822) ^ 0x7F2F6C53);
					continue;
				case 207u:
					AddStaff_Admin.smethod_32(GroupBox2, bool_0: false);
					num = ((int)num2 * -1971082467) ^ 0x2D447A78;
					continue;
				case 206u:
					num = ((int)num2 * -1153663618) ^ -1802471654;
					continue;
				case 205u:
					AddStaff_Admin.smethod_22((Control)(object)Label4, AddStaff_Admin.smethod_21("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1278234986) ^ 0x3C6243E0);
					continue;
				case 204u:
					AddStaff_Admin.smethod_24(Label4, "D.O.B :");
					num = (int)((num2 * 1644725819) ^ 0x2393CA81);
					continue;
				case 203u:
					num = ((int)num2 * -1810145428) ^ -737087811;
					continue;
				case 202u:
					AddStaff_Admin.smethod_15((Control)(object)Label7, new Point(3, 222));
					num = ((int)num2 * -160280094) ^ 0x5D1D2357;
					continue;
				case 201u:
					AddStaff_Admin.smethod_39(AddStaff_Admin.smethod_38(WorkShiftTxt), new string[3] { "Male", "Female", "Others" });
					num = (int)((num2 * 416345107) ^ 0x252B61F1);
					continue;
				case 200u:
					AddStaff_Admin.smethod_36(DOBTxt, new DateTime(1900, 1, 1, 0, 0, 0, 0));
					num = (int)((num2 * 459204303) ^ 0x5C5B48F3);
					continue;
				case 199u:
					num = ((int)num2 * -1714314752) ^ 0x4ED3AFB8;
					continue;
				case 198u:
					num = (int)((num2 * 1632373259) ^ 0x726141BA);
					continue;
				case 197u:
					num = (int)(num2 * 1613278786) ^ -1543324649;
					continue;
				case 196u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_53((Control)(object)this), (Control)(object)GroupBox2);
					num = (int)(num2 * 919087464) ^ -121009565;
					continue;
				case 195u:
					num = ((int)num2 * -187695775) ^ 0x7A21B597;
					continue;
				case 194u:
					AddStaff_Admin.smethod_43((ListControl)(object)GenderTxt, bool_0: true);
					num = ((int)num2 * -796894970) ^ 0x3072624E;
					continue;
				case 193u:
					num = ((int)num2 * -1536600728) ^ 0x1A6452F5;
					continue;
				case 192u:
					AddStaff_Admin.smethod_49((ButtonBase)(object)RegisterBtn, bool_0: false);
					num = (int)(num2 * 835086970) ^ -1894785750;
					continue;
				case 191u:
					AddStaff_Admin.smethod_15((Control)(object)Label2, new Point(8, 55));
					num = (int)((num2 * 1718422118) ^ 0x8684EF9);
					continue;
				case 190u:
					AddStaff_Admin.smethod_28((Control)(object)RegisterBtn, Color.White);
					num = ((int)num2 * -1159027621) ^ -1572033743;
					continue;
				case 189u:
					num = ((int)num2 * -474067735) ^ -669148028;
					continue;
				case 188u:
					Label1 = AddStaff_Admin.smethod_4();
					num = (int)((num2 * 1381619088) ^ 0x79EC4F8);
					continue;
				case 187u:
					AddStaff_Admin.smethod_23((Control)(object)EmailTxt, 19);
					num = ((int)num2 * -1227978238) ^ 0x9F71501;
					continue;
				case 186u:
					num = (int)((num2 * 473354746) ^ 0x69B8F7CB);
					continue;
				case 185u:
					AddStaff_Admin.smethod_24(Label3, "Gender :");
					num = ((int)num2 * -147539593) ^ -1639473325;
					continue;
				case 184u:
					AddStaff_Admin.smethod_16((Control)(object)Label1, "Label1");
					num = ((int)num2 * -506980630) ^ 0x6892FD9E;
					continue;
				case 183u:
					AddStaff_Admin.smethod_23((Control)(object)MobileTxt, 12);
					num = (int)((num2 * 362058866) ^ 0x549758D7);
					continue;
				case 182u:
					num = (int)(num2 * 955736442) ^ -1508910934;
					continue;
				case 181u:
					AddStaff_Admin.smethod_22((Control)(object)Label5, AddStaff_Admin.smethod_21("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1755312068) ^ 0x635B9EF9);
					continue;
				case 180u:
					num = ((int)num2 * -355072275) ^ -1577257407;
					continue;
				case 179u:
					AddStaff_Admin.smethod_17((Control)(object)Label6, new Size(87, 26));
					num = (int)(num2 * 810551902) ^ -1840382255;
					continue;
				case 178u:
					SuccessMsg = AddStaff_Admin.smethod_4();
					num = (int)((num2 * 1996122138) ^ 0x7079A449);
					continue;
				case 177u:
					AddStaff_Admin.smethod_15((Control)(object)DOBTxt, new Point(137, 102));
					num = ((int)num2 * -1989540448) ^ 0x68295900;
					continue;
				case 176u:
					AddStaff_Admin.smethod_51((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = (int)(num2 * 999989443) ^ -2047817778;
					continue;
				case 175u:
					num = (int)((num2 * 1667312441) ^ 0x4C66B25F);
					continue;
				case 174u:
					AddStaff_Admin.smethod_16((Control)(object)MobileTxt, "MobileTxt");
					num = (int)(num2 * 359192795) ^ -747770973;
					continue;
				case 173u:
					AddStaff_Admin.smethod_16((Control)(object)PictureBox1, "PictureBox1");
					AddStaff_Admin.smethod_17((Control)(object)PictureBox1, new Size(141, 136));
					num = (int)((num2 * 179572148) ^ 0x1C78357C);
					continue;
				case 172u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)DesignationTxt);
					num = (int)(num2 * 84941503) ^ -1002334747;
					continue;
				case 171u:
					num = (int)(num2 * 522006601) ^ -1059695476;
					continue;
				case 170u:
					AddStaff_Admin.smethod_28((Control)(object)SuccessMsg, AddStaff_Admin.smethod_27());
					AddStaff_Admin.smethod_15((Control)(object)SuccessMsg, new Point(305, 156));
					num = ((int)num2 * -1695600339) ^ 0x70CD1292;
					continue;
				case 169u:
					AddStaff_Admin.smethod_23((Control)(object)Label6, 9);
					AddStaff_Admin.smethod_24(Label6, "Address :");
					num = ((int)num2 * -1302636162) ^ -1539978714;
					continue;
				case 168u:
					AddStaff_Admin.smethod_17((Control)(object)GroupBox2, new Size(486, 446));
					num = ((int)num2 * -484267830) ^ 0xC062D63;
					continue;
				case 167u:
					num = ((int)num2 * -1407559802) ^ -442783101;
					continue;
				case 166u:
					AddStaff_Admin.smethod_24(Label7, "Work Shift :");
					num = (int)((num2 * 824618844) ^ 0x56A81CE1);
					continue;
				case 165u:
					num = ((int)num2 * -823217687) ^ -1227042497;
					continue;
				case 164u:
					AddStaff_Admin.smethod_17((Control)(object)Label1, new Size(330, 47));
					num = ((int)num2 * -1906777771) ^ -301279410;
					continue;
				case 163u:
					num = (int)((num2 * 1114916835) ^ 0x777FAF89);
					continue;
				case 162u:
					num = (int)((num2 * 1351160659) ^ 0x7ACDCDAF);
					continue;
				case 161u:
					num = ((int)num2 * -812305885) ^ 0x3C7545D0;
					continue;
				case 160u:
					AddStaff_Admin.smethod_15((Control)(object)MobileTxt, new Point(137, 147));
					num = (int)((num2 * 433848762) ^ 0x4C378A59);
					continue;
				case 159u:
					AddressTxt = AddStaff_Admin.smethod_7();
					num = ((int)num2 * -777633139) ^ 0x5EDB589F;
					continue;
				case 158u:
					AddStaff_Admin.smethod_25(Label5, (ContentAlignment)32);
					num = (int)(num2 * 395215836) ^ -1111985964;
					continue;
				case 157u:
					num = (int)(num2 * 1444830771) ^ -1188584196;
					continue;
				case 156u:
					num = (int)(num2 * 132384439) ^ -802794214;
					continue;
				case 155u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_53((Control)(object)this), (Control)(object)Label1);
					num = ((int)num2 * -841781161) ^ -1329425081;
					continue;
				case 154u:
					num = ((int)num2 * -1767733630) ^ 0x6A7AE5F2;
					continue;
				case 153u:
					num = ((int)num2 * -909617170) ^ -1542080773;
					continue;
				case 152u:
					num = (int)((num2 * 1755062591) ^ 0x4E24691D);
					continue;
				case 151u:
					num = (int)((num2 * 482451054) ^ 0x4A939F61);
					continue;
				case 150u:
					AddStaff_Admin.smethod_16((Control)(object)Label5, "Label5");
					num = ((int)num2 * -612725353) ^ 0x4685F539;
					continue;
				case 149u:
					num = (int)(num2 * 1128103160) ^ -745670131;
					continue;
				case 148u:
					num = ((int)num2 * -363682561) ^ 0xE57C15A;
					continue;
				case 147u:
					AddStaff_Admin.smethod_23((Control)(object)AddressTxt, 13);
					num = ((int)num2 * -686532240) ^ 0x2ED1F242;
					continue;
				case 146u:
					AddStaff_Admin.smethod_22((Control)(object)Label3, AddStaff_Admin.smethod_21("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1945571328) ^ 0xD0CED7E);
					continue;
				case 145u:
					AddStaff_Admin.smethod_48((ButtonBase)(object)RegisterBtn, "Register");
					num = (int)(num2 * 1027449002) ^ -1194965264;
					continue;
				case 144u:
					NameTxt = AddStaff_Admin.smethod_7();
					num = ((int)num2 * -2011213842) ^ -196463342;
					continue;
				case 143u:
					AddStaff_Admin.smethod_25(Label4, (ContentAlignment)32);
					num = (int)((num2 * 1769782517) ^ 0x79F21033);
					continue;
				case 142u:
					AddStaff_Admin.smethod_16((Control)(object)Label8, "Label8");
					AddStaff_Admin.smethod_17((Control)(object)Label8, new Size(128, 26));
					num = ((int)num2 * -69190727) ^ -1603696577;
					continue;
				case 141u:
					AddStaff_Admin.smethod_17((Control)(object)AddressTxt, new Size(324, 91));
					num = ((int)num2 * -961264253) ^ 0x7F0C0267;
					continue;
				case 140u:
					AddStaff_Admin.smethod_13((Control)(object)this);
					AddStaff_Admin.smethod_14(PictureBox1, (Image)(object)Resources.doc_Pic);
					num = ((int)num2 * -250503881) ^ -1561570847;
					continue;
				case 139u:
					AddStaff_Admin.smethod_22((Control)(object)EmailTxt, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 986513199) ^ -1237748956;
					continue;
				case 138u:
					num = ((int)num2 * -333392574) ^ 0x3676741D;
					continue;
				case 137u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)Label7);
					num = ((int)num2 * -1673005959) ^ -2095590692;
					continue;
				case 136u:
					AddStaff_Admin.smethod_22((Control)(object)GroupBox2, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -2094215288) ^ -1703770180;
					continue;
				case 135u:
					AddStaff_Admin.smethod_19(PictureBox1, 10);
					AddStaff_Admin.smethod_20(PictureBox1, bool_0: false);
					num = ((int)num2 * -2124800932) ^ 0x11110B7C;
					continue;
				case 134u:
					DOBTxt = AddStaff_Admin.smethod_6();
					num = ((int)num2 * -461459651) ^ -1498316088;
					continue;
				case 133u:
					AddStaff_Admin.smethod_39(AddStaff_Admin.smethod_38(DesignationTxt), new string[3] { "Male", "Female", "Others" });
					num = ((int)num2 * -1027458118) ^ -763657183;
					continue;
				case 132u:
					num = (int)(num2 * 1152818474) ^ -839958577;
					continue;
				case 131u:
					AddStaff_Admin.smethod_25(Label7, (ContentAlignment)32);
					AddStaff_Admin.smethod_22((Control)(object)AddressTxt, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 292876853) ^ 0x7279401B);
					continue;
				case 130u:
					AddStaff_Admin.smethod_40(GenderTxt, (AutoCompleteMode)2);
					AddStaff_Admin.smethod_41(GenderTxt, (AutoCompleteSource)256);
					AddStaff_Admin.smethod_42(GenderTxt, (ComboBoxStyle)2);
					num = (int)((num2 * 2139046187) ^ 0x5F38E40F);
					continue;
				case 129u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_53((Control)(object)this), (Control)(object)RegisterBtn);
					num = (int)(num2 * 1578750827) ^ -1924027003;
					continue;
				case 128u:
					num = (int)((num2 * 107352214) ^ 0x51245685);
					continue;
				case 127u:
					AddStaff_Admin.smethod_47((ButtonBase)(object)ClearBtn, Color.MidnightBlue);
					AddStaff_Admin.smethod_22((Control)(object)ClearBtn, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					AddStaff_Admin.smethod_28((Control)(object)ClearBtn, Color.White);
					num = (int)((num2 * 1584327583) ^ 0x401CAE);
					continue;
				case 126u:
					num = ((int)num2 * -2088314648) ^ -752663252;
					continue;
				case 125u:
					num = ((int)num2 * -693820222) ^ 0xE2BA9FE;
					continue;
				case 124u:
					AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Olive);
					num = (int)(num2 * 1079171275) ^ -1149122708;
					continue;
				case 123u:
					num = ((int)num2 * -424126503) ^ 0x6EEBAD59;
					continue;
				case 122u:
					Label2 = AddStaff_Admin.smethod_4();
					num = ((int)num2 * -409035267) ^ 0x63DC92B8;
					continue;
				case 121u:
					num = ((int)num2 * -96191497) ^ 0x391B3BE9;
					continue;
				case 120u:
					AddStaff_Admin.smethod_22((Control)(object)MobileTxt, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -58749639) ^ 0x4BBF6962;
					continue;
				case 119u:
					AddStaff_Admin.smethod_25(Label6, (ContentAlignment)32);
					num = ((int)num2 * -1801935639) ^ 0x5B16B820;
					continue;
				case 118u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)MobileTxt);
					num = ((int)num2 * -1286466439) ^ -990157078;
					continue;
				case 117u:
					AddStaff_Admin.smethod_22((Control)(object)SuccessMsg, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 926782341) ^ -1989894999;
					continue;
				case 116u:
					num = ((int)num2 * -118310971) ^ 0x3302DADF;
					continue;
				case 115u:
					num = ((int)num2 * -1542192047) ^ 0x6261DB81;
					continue;
				case 114u:
					AddStaff_Admin.smethod_18(PictureBox1, (PictureBoxSizeMode)1);
					num = (int)((num2 * 675017174) ^ 0x3E70E991);
					continue;
				case 113u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_53((Control)(object)this), (Control)(object)SuccessMsg);
					num = (int)((num2 * 1627892554) ^ 0x3676409B);
					continue;
				case 112u:
					AddStaff_Admin.smethod_23((Control)(object)SuccessMsg, 12);
					num = (int)(num2 * 1623606222) ^ -1345184954;
					continue;
				case 111u:
					AddStaff_Admin.smethod_22((Control)(object)WorkShiftTxt, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1197134988) ^ 0x3F7FE74E);
					continue;
				case 110u:
					AddStaff_Admin.smethod_55((Control)(object)this, new Size(977, 804));
					num = (int)((num2 * 883109080) ^ 0x1534424E);
					continue;
				case 109u:
					AddStaff_Admin.smethod_17((Control)(object)Label2, new Size(92, 23));
					AddStaff_Admin.smethod_23((Control)(object)Label2, 5);
					num = (int)(num2 * 258630411) ^ -1583986751;
					continue;
				case 108u:
					AddStaff_Admin.smethod_23((Control)(object)GenderTxt, 11);
					AddStaff_Admin.smethod_22((Control)(object)Label6, AddStaff_Admin.smethod_21("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1644043200) ^ 0x3E0F7C5E);
					continue;
				case 107u:
					AddStaff_Admin.smethod_15((Control)(object)EmailTxt, new Point(137, 307));
					AddStaff_Admin.smethod_16((Control)(object)EmailTxt, "EmailTxt");
					num = ((int)num2 * -1447223842) ^ 0x282A719B;
					continue;
				case 106u:
					num = ((int)num2 * -1574724203) ^ -1046580754;
					continue;
				case 105u:
					AddStaff_Admin.smethod_45(AddStaff_Admin.smethod_44(DesignationTxt), new object[4] { "Doctor", "Nurse", "Receptionist", "Admin" });
					num = (int)(num2 * 576504126) ^ -399029441;
					continue;
				case 104u:
					num = (int)((num2 * 713350653) ^ 0x72F2898C);
					continue;
				case 103u:
					num = (int)(num2 * 147677850) ^ -992298022;
					continue;
				case 102u:
					AddStaff_Admin.smethod_15((Control)(object)GroupBox2, new Point(261, 235));
					num = (int)((num2 * 615193886) ^ 0x59914BDB);
					continue;
				case 101u:
					AddStaff_Admin.smethod_17((Control)(object)DesignationTxt, new Size(147, 27));
					num = ((int)num2 * -56040754) ^ 0xDFC1DC9;
					continue;
				case 100u:
					Label8 = AddStaff_Admin.smethod_4();
					num = ((int)num2 * -229007013) ^ 0x6D6561E2;
					continue;
				case 99u:
					AddStaff_Admin.smethod_22((Control)(object)GenderTxt, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1457888003) ^ 0x6ABE4C84);
					continue;
				case 98u:
					num = ((int)num2 * -24603566) ^ 0x3075A48B;
					continue;
				case 97u:
					num = (int)(num2 * 1433780317) ^ -1036512700;
					continue;
				case 96u:
					AddStaff_Admin.smethod_47((ButtonBase)(object)RegisterBtn, Color.MidnightBlue);
					num = ((int)num2 * -43685184) ^ -1691589831;
					continue;
				case 95u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)Label6);
					num = (int)(num2 * 1008550898) ^ -2035925177;
					continue;
				case 94u:
					AddStaff_Admin.smethod_23((Control)(object)WorkShiftTxt, 15);
					num = ((int)num2 * -1136296840) ^ 0x259B80D;
					continue;
				case 93u:
					AddStaff_Admin.smethod_16((Control)(object)Label9, "Label9");
					num = ((int)num2 * -1574913872) ^ -1757409250;
					continue;
				case 92u:
					num = ((int)num2 * -2001465218) ^ -825083613;
					continue;
				case 91u:
					num = (int)((num2 * 701006522) ^ 0x7A2FBF84);
					continue;
				case 90u:
					AddStaff_Admin.smethod_16((Control)(object)SuccessMsg, "SuccessMsg");
					num = (int)((num2 * 207965128) ^ 0x4D7F42AF);
					continue;
				case 89u:
					num = ((int)num2 * -1501495244) ^ 0x3F4F32E;
					continue;
				case 88u:
					AddStaff_Admin.smethod_23((Control)(object)Label7, 14);
					num = (int)(num2 * 1579251108) ^ -2064151924;
					continue;
				case 87u:
					AddStaff_Admin.smethod_22((Control)(object)Label7, AddStaff_Admin.smethod_21("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 840587797) ^ 0x34DDEE93);
					continue;
				case 86u:
					MobileTxt = AddStaff_Admin.smethod_7();
					num = (int)(num2 * 1735097634) ^ -1274197789;
					continue;
				case 85u:
					AddStaff_Admin.smethod_23((Control)(object)GroupBox2, 13);
					num = ((int)num2 * -1390013254) ^ 0x700B3C8D;
					continue;
				case 84u:
					AddStaff_Admin.smethod_17((Control)(object)Label9, new Size(87, 26));
					num = (int)(num2 * 1981516259) ^ -348348405;
					continue;
				case 83u:
					AddStaff_Admin.smethod_16((Control)(object)RegisterBtn, "RegisterBtn");
					AddStaff_Admin.smethod_17((Control)(object)RegisterBtn, new Size(139, 43));
					AddStaff_Admin.smethod_23((Control)(object)RegisterBtn, 14);
					num = (int)((num2 * 1414278524) ^ 0x1532A18F);
					continue;
				case 82u:
					AddStaff_Admin.smethod_11((ISupportInitialize)PictureBox1);
					AddStaff_Admin.smethod_12((Control)(object)GroupBox2);
					num = (int)(num2 * 946456475) ^ -1739106344;
					continue;
				case 81u:
					AddStaff_Admin.smethod_15((Control)(object)ClearBtn, new Point(261, 703));
					num = (int)((num2 * 1461752741) ^ 0xDB80905);
					continue;
				case 80u:
					AddStaff_Admin.smethod_23((Control)(object)ClearBtn, 15);
					AddStaff_Admin.smethod_48((ButtonBase)(object)ClearBtn, "Clear");
					num = (int)(num2 * 995538195) ^ -1444746915;
					continue;
				case 79u:
					AddStaff_Admin.smethod_15((Control)(object)PictureBox1, new Point(245, 17));
					num = ((int)num2 * -912899353) ^ -1520540217;
					continue;
				case 78u:
					num = ((int)num2 * -381558728) ^ -1324132891;
					continue;
				case 77u:
					AddStaff_Admin.smethod_17((Control)(object)DOBTxt, new Size(208, 29));
					num = ((int)num2 * -687088051) ^ -86309067;
					continue;
				case 76u:
					num = ((int)num2 * -1490401181) ^ 0x384A3064;
					continue;
				case 75u:
					AddStaff_Admin.smethod_16((Control)(object)GenderTxt, "GenderTxt");
					num = ((int)num2 * -2029150431) ^ 0x54B3D1A7;
					continue;
				case 74u:
					PictureBox1 = AddStaff_Admin.smethod_3();
					num = ((int)num2 * -2010768778) ^ 0x83B32A;
					continue;
				case 73u:
					num = (int)(num2 * 55046608) ^ -2083571301;
					continue;
				case 72u:
					AddStaff_Admin.smethod_15((Control)(object)GenderTxt, new Point(137, 182));
					num = ((int)num2 * -1731007935) ^ 0x15F26A99;
					continue;
				case 71u:
					AddStaff_Admin.smethod_15((Control)(object)Label5, new Point(8, 144));
					num = ((int)num2 * -1700653705) ^ -1842190703;
					continue;
				case 70u:
					num = (int)(num2 * 2111443470) ^ -752848100;
					continue;
				case 69u:
					num = (int)(num2 * 1625727905) ^ -1798214272;
					continue;
				case 68u:
					AddStaff_Admin.smethod_15((Control)(object)Label3, new Point(13, 182));
					num = ((int)num2 * -582812779) ^ 0x52EB6719;
					continue;
				case 67u:
					AddStaff_Admin.smethod_33(GroupBox2, "Patient's Information");
					num = ((int)num2 * -234446635) ^ -355476210;
					continue;
				case 66u:
					num = (int)((num2 * 1933991075) ^ 0x7843317E);
					continue;
				case 65u:
					AddStaff_Admin.smethod_25(Label9, (ContentAlignment)32);
					num = ((int)num2 * -111918824) ^ 0x1E14908;
					continue;
				case 64u:
					AddStaff_Admin.smethod_45(AddStaff_Admin.smethod_44(WorkShiftTxt), new object[2] { "Day", "Night" });
					num = ((int)num2 * -1641008221) ^ -1880874759;
					continue;
				case 62u:
					AddStaff_Admin.smethod_24(Label9, "Email :");
					num = ((int)num2 * -1559384797) ^ -825815860;
					continue;
				case 61u:
					AddStaff_Admin.smethod_41(DesignationTxt, (AutoCompleteSource)256);
					num = (int)((num2 * 1003161807) ^ 0x7993CA4);
					continue;
				case 60u:
					AddStaff_Admin.smethod_35(DOBTxt, new DateTime(2019, 2, 11, 0, 0, 0, 0));
					num = ((int)num2 * -1673695872) ^ 0x2C84499A;
					continue;
				case 59u:
					AddStaff_Admin.smethod_15((Control)(object)DesignationTxt, new Point(137, 262));
					AddStaff_Admin.smethod_16((Control)(object)DesignationTxt, "DesignationTxt");
					num = (int)((num2 * 197702661) ^ 0x5C26A5D8);
					continue;
				case 58u:
					Label9 = AddStaff_Admin.smethod_4();
					num = ((int)num2 * -920891365) ^ 0x1DD2B11E;
					continue;
				case 57u:
					AddStaff_Admin.smethod_16((Control)(object)Label2, "Label2");
					num = (int)(num2 * 379157222) ^ -716802566;
					continue;
				case 56u:
					AddStaff_Admin.smethod_15((Control)(object)Label4, new Point(8, 101));
					AddStaff_Admin.smethod_16((Control)(object)Label4, "Label4");
					AddStaff_Admin.smethod_17((Control)(object)Label4, new Size(92, 24));
					num = (int)(num2 * 377446546) ^ -1050669852;
					continue;
				case 55u:
					AddStaff_Admin.smethod_15((Control)(object)RegisterBtn, new Point(608, 703));
					num = (int)(num2 * 1284759070) ^ -1762151083;
					continue;
				case 54u:
					num = ((int)num2 * -628241749) ^ -975002875;
					continue;
				case 53u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)GenderTxt);
					num = ((int)num2 * -41563528) ^ -1829489843;
					continue;
				case 52u:
					AddStaff_Admin.smethod_17((Control)(object)NameTxt, new Size(324, 26));
					num = ((int)num2 * -1332625411) ^ -1411499997;
					continue;
				case 51u:
					num = (int)((num2 * 2027008901) ^ 0x248F4CBC);
					continue;
				case 50u:
					num = (int)((num2 * 1472341050) ^ 0x634B8F29);
					continue;
				case 49u:
					AddStaff_Admin.smethod_52((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 97283484) ^ 0x22BEF28B);
					continue;
				case 48u:
					num = (int)((num2 * 2133726126) ^ 0x7909D3F2);
					continue;
				case 47u:
					AddStaff_Admin.smethod_24(Label1, "Add Staff");
					num = ((int)num2 * -203251782) ^ -602371949;
					continue;
				case 46u:
					num = (int)(num2 * 2023940109) ^ -2070555768;
					continue;
				case 45u:
					num = ((int)num2 * -1145472136) ^ 0x1CC18F71;
					continue;
				case 44u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)AddressTxt);
					num = ((int)num2 * -703629576) ^ -922024458;
					continue;
				case 43u:
					AddStaff_Admin.smethod_24(Label8, "Designation :");
					num = ((int)num2 * -2136152001) ^ 0x10AD35C8;
					continue;
				case 42u:
					DesignationTxt = AddStaff_Admin.smethod_8();
					num = ((int)num2 * -462049878) ^ 0x3EC680D0;
					continue;
				case 41u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_30((Control)(object)GroupBox2), (Control)(object)Label5);
					num = (int)(num2 * 1812409675) ^ -15888221;
					continue;
				case 40u:
					GenderTxt = AddStaff_Admin.smethod_8();
					Label6 = AddStaff_Admin.smethod_4();
					num = ((int)num2 * -1011157183) ^ -503522137;
					continue;
				case 39u:
					GroupBox2 = AddStaff_Admin.smethod_5();
					num = ((int)num2 * -737528570) ^ 0x15481C47;
					continue;
				case 38u:
					AddStaff_Admin.smethod_16((Control)(object)Label3, "Label3");
					AddStaff_Admin.smethod_17((Control)(object)Label3, new Size(82, 31));
					num = ((int)num2 * -144158022) ^ 0x6FC606A5;
					continue;
				case 37u:
					AddStaff_Admin.smethod_16((Control)(object)GroupBox2, "GroupBox2");
					num = (int)(num2 * 1965329416) ^ -987767318;
					continue;
				case 36u:
					num = (int)((num2 * 1711525317) ^ 0x2C5C63A1);
					continue;
				case 35u:
					AddStaff_Admin.smethod_17((Control)(object)MobileTxt, new Size(208, 26));
					num = (int)((num2 * 71593154) ^ 0x6E970BC1);
					continue;
				case 34u:
					AddStaff_Admin.smethod_23((Control)(object)DOBTxt, 20);
					num = ((int)num2 * -798900227) ^ -697414979;
					continue;
				case 33u:
					AddStaff_Admin.smethod_22((Control)(object)Label2, AddStaff_Admin.smethod_21("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 2117196107) ^ 0x1701A40E);
					continue;
				case 32u:
					AddStaff_Admin.smethod_57((Control)(object)GroupBox2, bool_0: false);
					AddStaff_Admin.smethod_58((Control)(object)GroupBox2);
					num = (int)(num2 * 1896293461) ^ -1053747825;
					continue;
				case 31u:
					num = ((int)num2 * -1952856538) ^ -1230321331;
					continue;
				case 30u:
					AddStaff_Admin.smethod_15((Control)(object)AddressTxt, new Point(137, 349));
					num = (int)(num2 * 454161907) ^ -1865140400;
					continue;
				case 29u:
					num = ((int)num2 * -1153086038) ^ -671364715;
					continue;
				case 28u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: false);
					num = ((int)num2 * -1228235537) ^ 0x155CF3D9;
					continue;
				case 27u:
					num = (int)((num2 * 1886900580) ^ 0x447DDD7D);
					continue;
				case 26u:
					AddStaff_Admin.smethod_23((Control)(object)Label3, 6);
					num = (int)((num2 * 516349491) ^ 0x652FF38D);
					continue;
				case 25u:
					Timer1 = AddStaff_Admin.smethod_10(components);
					num = (int)(num2 * 631396846) ^ -1837620010;
					continue;
				case 24u:
					AddStaff_Admin.smethod_15((Control)(object)WorkShiftTxt, new Point(137, 221));
					num = ((int)num2 * -544346776) ^ 0x71FC833D;
					continue;
				case 23u:
					AddStaff_Admin.smethod_23((Control)(object)DesignationTxt, 17);
					AddStaff_Admin.smethod_22((Control)(object)Label8, AddStaff_Admin.smethod_21("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 952478044) ^ -1494306049;
					continue;
				case 22u:
					AddStaff_Admin.smethod_23((Control)(object)Label4, 7);
					num = (int)(num2 * 1597861042) ^ -1917565238;
					continue;
				case 21u:
					Label5 = AddStaff_Admin.smethod_4();
					Label4 = AddStaff_Admin.smethod_4();
					num = (int)(num2 * 1179380370) ^ -2080040126;
					continue;
				case 20u:
					AddStaff_Admin.smethod_17((Control)(object)WorkShiftTxt, new Size(147, 27));
					num = ((int)num2 * -1398898845) ^ -1363557240;
					continue;
				case 19u:
					num = ((int)num2 * -783141432) ^ 0x5C24A6DE;
					continue;
				case 18u:
					AddStaff_Admin.smethod_17((Control)(object)GenderTxt, new Size(130, 27));
					num = (int)(num2 * 796617367) ^ -550210009;
					continue;
				case 17u:
					AddStaff_Admin.smethod_15((Control)(object)Label8, new Point(3, 263));
					num = ((int)num2 * -221219360) ^ -565016620;
					continue;
				case 16u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_53((Control)(object)this), (Control)(object)PictureBox1);
					num = (int)((num2 * 232547173) ^ 0x68514D11);
					continue;
				case 15u:
					AddStaff_Admin.smethod_40(WorkShiftTxt, (AutoCompleteMode)2);
					num = (int)(num2 * 1643506145) ^ -1461974500;
					continue;
				case 14u:
					num = ((int)num2 * -693920976) ^ 0x92D9161;
					continue;
				case 13u:
					AddStaff_Admin.smethod_23((Control)(object)NameTxt, 0);
					num = (int)((num2 * 1743789449) ^ 0x5D5CDDE4);
					continue;
				case 12u:
					AddStaff_Admin.smethod_24(SuccessMsg, "Patient Successfully registered");
					num = (int)(num2 * 875594407) ^ -1838906010;
					continue;
				case 11u:
					AddStaff_Admin.smethod_17((Control)(object)EmailTxt, new Size(324, 26));
					num = (int)(num2 * 1264235069) ^ -668501205;
					continue;
				case 10u:
					num = (int)((num2 * 1448589862) ^ 0x2F1DF6E0);
					continue;
				case 9u:
					num = ((int)num2 * -558628281) ^ -981680780;
					continue;
				case 8u:
					AddStaff_Admin.smethod_24(Label5, "Mobile :");
					num = (int)((num2 * 1951067859) ^ 0x699EB5AC);
					continue;
				case 7u:
					num = ((int)num2 * -452901608) ^ 0x7DC162C4;
					continue;
				case 6u:
					num = ((int)num2 * -1626903558) ^ -1494124821;
					continue;
				case 5u:
					AddStaff_Admin.smethod_22((Control)(object)DesignationTxt, AddStaff_Admin.smethod_21("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1738229738) ^ -2013210278;
					continue;
				case 4u:
					AddStaff_Admin.smethod_31(AddStaff_Admin.smethod_53((Control)(object)this), (Control)(object)ClearBtn);
					num = ((int)num2 * -970544106) ^ -157434413;
					continue;
				case 3u:
					AddStaff_Admin.smethod_54((Control)(object)this, "AddStaff_Admin");
					num = ((int)num2 * -21791769) ^ 0x5EE0D5A1;
					continue;
				case 2u:
					AddStaff_Admin.smethod_43((ListControl)(object)DesignationTxt, bool_0: true);
					num = (int)((num2 * 1636212785) ^ 0x74EBDAE1);
					continue;
				case 1u:
					num = ((int)num2 * -1821755048) ^ -556070262;
					continue;
				case 0u:
					AddStaff_Admin.smethod_23((Control)(object)Label1, 11);
					num = (int)(num2 * 1294667430) ^ -1189190651;
					continue;
				case 213u:
					break;
				default:
					AddStaff_Admin.smethod_59((Control)(object)this, bool_0: false);
					return;
				}
				break;
			}
		}
	}

	private void AddStaff_Admin_Load(object sender, EventArgs e)
	{
		AddStaff_Admin.smethod_35(DOBTxt, AddStaff_Admin.smethod_65(AddStaff_Admin.smethod_64((object)DateTime.Now, "dd-MM-yyyy")));
	}

	private void ClearBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1039231365;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x49233AE1u) % 12u)
				{
				case 11u:
					num = (int)((num2 * 1658638619) ^ 0x2FBE467E);
					continue;
				case 10u:
					AddStaff_Admin.smethod_68(WorkShiftTxt, -1);
					num = ((int)num2 * -2116980626) ^ 0x4CD72CBD;
					continue;
				case 9u:
					AddStaff_Admin.smethod_37(DOBTxt, AddStaff_Admin.smethod_65(AddStaff_Admin.smethod_64((object)AddStaff_Admin.smethod_67(), "dd-MM-yyyy")));
					AddStaff_Admin.smethod_68(GenderTxt, -1);
					num = (int)(num2 * 1077875215) ^ -1777092376;
					continue;
				case 8u:
					AddStaff_Admin.smethod_66((TextBoxBase)(object)NameTxt);
					num = ((int)num2 * -330817622) ^ -1334570412;
					continue;
				case 7u:
					AddStaff_Admin.smethod_66((TextBoxBase)(object)EmailTxt);
					num = ((int)num2 * -2020506640) ^ 0x1C188F70;
					continue;
				case 5u:
					AddStaff_Admin.smethod_66((TextBoxBase)(object)AddressTxt);
					num = (int)(num2 * 1679618408) ^ -500212472;
					continue;
				case 4u:
					AddStaff_Admin.smethod_66((TextBoxBase)(object)MobileTxt);
					num = ((int)num2 * -1955026856) ^ 0x1C3E3846;
					continue;
				case 2u:
					num = ((int)num2 * -636942322) ^ 0x4D63AB15;
					continue;
				case 1u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: false);
					num = ((int)num2 * -56508748) ^ -1175269966;
					continue;
				case 0u:
					AddStaff_Admin.smethod_68(DesignationTxt, -1);
					num = (int)(num2 * 627636037) ^ -1252431297;
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

	private void RegisterBtn_Click(object sender, EventArgs e)
	{
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected I4, but got Unknown
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected I4, but got Unknown
		//IL_0534: Incompatible stack heights: 0 vs 1
		//IL_0550: Incompatible stack heights: 0 vs 1
		//IL_058b: Incompatible stack heights: 0 vs 1
		//IL_059e: Incompatible stack heights: 0 vs 1
		//IL_05b7: Incompatible stack heights: 0 vs 1
		//IL_05ca: Incompatible stack heights: 0 vs 1
		//IL_05d4: Incompatible stack heights: 0 vs 1
		bool flag = default(bool);
		OleDbConnection oleDbConnection_ = default(OleDbConnection);
		DateTime dateTime_ = default(DateTime);
		string string_ = default(string);
		while (true)
		{
			int num = -896909138;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF738A963u) % 10u)
				{
				case 9u:
					flag = !Validate_data();
					num = ((int)num2 * -2041954111) ^ -1305327005;
					continue;
				case 7u:
					oleDbConnection_ = AddStaff_Admin.smethod_69();
					AddStaff_Admin.smethod_71(oleDbConnection_, AddStaff_Admin.smethod_70(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
					num = (int)(num2 * 204188271) ^ -161185445;
					continue;
				case 6u:
					username = AddStaff_Admin.smethod_73(username, new char[1] { ' ' })[0];
					password = Random_Password_Generator();
					dateTime_ = AddStaff_Admin.smethod_65(AddStaff_Admin.smethod_64((object)AddStaff_Admin.smethod_74(DOBTxt), "dd-MM-yyyy"));
					AddStaff_Admin.smethod_75(oleDbConnection_);
					num = (int)(num2 * 1134657407) ^ -275086874;
					continue;
				case 5u:
					string_ = "Insert Into [Staff] ([Name],[Designation],[Date Of Birth],[Gender],[Mobile],[Address],[Work Shift],[Username],[Password]) Values (?,?,?,?,?,?,?,?,?)";
					num = ((int)num2 * -1457309029) ^ -1926076432;
					continue;
				case 4u:
					num = -1677943022;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1407089774;
						num5 = 1407089774;
					}
					else
					{
						num4 = 426052482;
						num5 = 426052482;
					}
					num = num4 ^ (int)(num2 * 2133200187);
					continue;
				}
				case 1u:
					username = AddStaff_Admin.smethod_73(AddStaff_Admin.smethod_72(NameTxt), new char[1] { '.' })[0];
					num = ((int)num2 * -645941023) ^ -1845732356;
					continue;
				case 2u:
					break;
				default:
				{
					OleDbCommand val = AddStaff_Admin.smethod_76(string_, oleDbConnection_);
					try
					{
						while (true)
						{
							int num3 = -1102524399;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xF738A963u) % 20u)
								{
								case 19u:
									AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
									num3 = (int)((num2 * 181507480) ^ 0x661ACD7F);
									continue;
								case 18u:
									AddStaff_Admin.smethod_87(Timer1);
									num3 = ((int)num2 * -756781104) ^ -1395699184;
									continue;
								case 17u:
									AddStaff_Admin.smethod_80(AddStaff_Admin.smethod_77(val), AddStaff_Admin.smethod_79("Address", (object)AddStaff_Admin.smethod_83(AddStaff_Admin.smethod_72(AddressTxt))));
									AddStaff_Admin.smethod_80(AddStaff_Admin.smethod_77(val), AddStaff_Admin.smethod_79("Work Shift", (object)AddStaff_Admin.smethod_83(AddStaff_Admin.smethod_81(WorkShiftTxt))));
									AddStaff_Admin.smethod_80(AddStaff_Admin.smethod_77(val), AddStaff_Admin.smethod_79("Username", (object)username));
									num3 = (int)(num2 * 1066848459) ^ -43514838;
									continue;
								case 16u:
									num3 = (int)((num2 * 1919593252) ^ 0x399BF99C);
									continue;
								case 15u:
									AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Green);
									num3 = (int)(num2 * 65747960) ^ -1484503518;
									continue;
								case 14u:
									AddStaff_Admin.smethod_80(AddStaff_Admin.smethod_77(val), AddStaff_Admin.smethod_79("Password", (object)password));
									num3 = ((int)num2 * -1071016972) ^ 0x49586BDA;
									continue;
								case 12u:
									ClearBtn_Click(AddStaff_Admin.smethod_88(sender), e);
									num3 = ((int)num2 * -800745869) ^ -1081472870;
									continue;
								case 11u:
									num3 = ((int)num2 * -1956735279) ^ 0x3ABECE80;
									continue;
								case 10u:
									AddStaff_Admin.smethod_80(AddStaff_Admin.smethod_77(val), AddStaff_Admin.smethod_79("Name", (object)AddStaff_Admin.smethod_78(AddStaff_Admin.smethod_72(NameTxt))));
									AddStaff_Admin.smethod_80(AddStaff_Admin.smethod_77(val), AddStaff_Admin.smethod_79("Designation", (object)AddStaff_Admin.smethod_78(AddStaff_Admin.smethod_81(DesignationTxt))));
									num3 = ((int)num2 * -1310621314) ^ -823316789;
									continue;
								case 9u:
									num3 = ((int)num2 * -2098020138) ^ -147355489;
									continue;
								case 8u:
									Send_Mail();
									num3 = ((int)num2 * -2066094016) ^ -1035105676;
									continue;
								case 7u:
									AddStaff_Admin.smethod_86(oleDbConnection_);
									num3 = (int)((num2 * 187586343) ^ 0x6E12656);
									continue;
								case 6u:
									AddStaff_Admin.smethod_80(AddStaff_Admin.smethod_77(val), AddStaff_Admin.smethod_79("Gender", (object)AddStaff_Admin.smethod_78(AddStaff_Admin.smethod_81(GenderTxt))));
									AddStaff_Admin.smethod_80(AddStaff_Admin.smethod_77(val), AddStaff_Admin.smethod_79("Mobile", (object)AddStaff_Admin.smethod_83(AddStaff_Admin.smethod_72(MobileTxt))));
									num3 = ((int)num2 * -1138478762) ^ 0xC1FA8D2;
									continue;
								case 5u:
									num3 = ((int)num2 * -2022455481) ^ 0x69AB7A59;
									continue;
								case 4u:
									num3 = ((int)num2 * -666541993) ^ -660029920;
									continue;
								case 3u:
									AddStaff_Admin.smethod_24(SuccessMsg, "Staff Successfully Registered !!");
									num3 = ((int)num2 * -1593635885) ^ -595629958;
									continue;
								case 1u:
									AddStaff_Admin.smethod_84(val);
									AddStaff_Admin.smethod_85((Component)(object)val);
									num3 = (int)((num2 * 973092726) ^ 0x307191DE);
									continue;
								case 0u:
									AddStaff_Admin.smethod_80(AddStaff_Admin.smethod_77(val), AddStaff_Admin.smethod_79("Date Of Birth", (object)AddStaff_Admin.smethod_82(dateTime_)));
									num3 = (int)((num2 * 1395925256) ^ 0x28A87E51);
									continue;
								case 2u:
									break;
								default:
									AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
									return;
								}
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						AddStaff_Admin.smethod_89(exception_);
						while (true)
						{
							_ = -194468878;
							while (true)
							{
								_003F val2 = /*Error near IL_04f2: Stack underflow*/^ -147281565;
								num2 = (uint)(int)val2;
								switch (val2 % 8)
								{
								default:
									return;
								case 7:
									AddStaff_Admin.smethod_90();
									_ = (num2 * 1569545228) ^ 0x85B77D4Cu;
									continue;
								case 6:
									AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
									_ = (num2 * 45247489) ^ 0xF2BFDFF;
									continue;
								case 4:
									AddStaff_Admin.smethod_24(SuccessMsg, "Invalid Credentialsl");
									AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Red);
									AddStaff_Admin.smethod_87(Timer1);
									_ = (num2 * 262531161) ^ 0xDEC03500u;
									continue;
								case 2:
									_ = ((int)num2 * -176863078) ^ 0x478F17B;
									continue;
								case 1:
									AddStaff_Admin.smethod_86(oleDbConnection_);
									_ = (num2 * 1923438927) ^ 0xB1EA9BF4u;
									continue;
								case 0:
									_ = (num2 * 228263919) ^ 0x1EFF02ED;
									continue;
								case 5:
									break;
								case 3:
									return;
								}
								break;
							}
						}
					}
				}
				case 8u:
					return;
				}
				break;
			}
		}
	}

	private bool Send_Mail()
	{
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected I4, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected I4, but got Unknown
		//IL_027a: Incompatible stack heights: 0 vs 1
		//IL_0281: Incompatible stack heights: 0 vs 1
		try
		{
			SmtpClient smtpClient_ = AddStaff_Admin.smethod_91();
			MailMessage mailMessage_ = default(MailMessage);
			while (true)
			{
				IL_0227:
				int num = 1809085087;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7FABBCECu) % 16u)
					{
					case 15u:
						num = ((int)num2 * -967860082) ^ -1339566702;
						continue;
					case 14u:
						AddStaff_Admin.smethod_98(smtpClient_, "smtp.gmail.com");
						num = (int)((num2 * 816647732) ^ 0x6F6D3829);
						continue;
					case 13u:
						num = ((int)num2 * -231796702) ^ -2090238019;
						continue;
					case 12u:
						AddStaff_Admin.smethod_103(mailMessage_, "Login Credential Details");
						num = (int)((num2 * 315531789) ^ 0x26C40547);
						continue;
					case 11u:
						mailMessage_ = AddStaff_Admin.smethod_92();
						AddStaff_Admin.smethod_100(mailMessage_, AddStaff_Admin.smethod_99("tyagianubhav619@gmail.com"));
						num = ((int)num2 * -1364567862) ^ -501455898;
						continue;
					case 10u:
						num = (int)(num2 * 1337920370) ^ -334629703;
						continue;
					case 9u:
						num = (int)(num2 * 276945403) ^ -1300508937;
						continue;
					case 8u:
						AddStaff_Admin.smethod_106(mailMessage_, AddStaff_Admin.smethod_105(new string[5] { "Your Username is : ", username, " and Password is : ", password, ". Remember your login credentials for future use" }));
						num = ((int)num2 * -106437745) ^ -155513852;
						continue;
					case 7u:
						AddStaff_Admin.smethod_104(mailMessage_, bool_0: false);
						num = ((int)num2 * -1619789423) ^ -1948908750;
						continue;
					case 5u:
						AddStaff_Admin.smethod_108((object)"Mail Sent", (MsgBoxStyle)0, (object)null);
						num = ((int)num2 * -131770382) ^ 0x29BE2F4;
						continue;
					case 4u:
						AddStaff_Admin.smethod_102(AddStaff_Admin.smethod_101(mailMessage_), AddStaff_Admin.smethod_72(EmailTxt));
						num = ((int)num2 * -1300644095) ^ -1102032505;
						continue;
					case 3u:
						mailMessage_ = AddStaff_Admin.smethod_92();
						AddStaff_Admin.smethod_93(smtpClient_, bool_0: false);
						AddStaff_Admin.smethod_95(smtpClient_, (ICredentialsByHost)AddStaff_Admin.smethod_94("tyagianubhav619@gmail.com", "tyagi09101999"));
						num = (int)((num2 * 2138767698) ^ 0x4F825AA0);
						continue;
					case 1u:
						AddStaff_Admin.smethod_96(smtpClient_, 587);
						AddStaff_Admin.smethod_97(smtpClient_, bool_0: true);
						num = (int)((num2 * 765451577) ^ 0x4C614F1B);
						continue;
					case 0u:
						AddStaff_Admin.smethod_107(smtpClient_, mailMessage_);
						num = ((int)num2 * -2069855863) ^ -1193629975;
						continue;
					default:
						goto end_IL_01d4;
					case 6u:
						break;
					case 2u:
						goto end_IL_01d4;
					}
					goto IL_0227;
					continue;
					end_IL_01d4:
					break;
				}
				break;
			}
		}
		catch (Exception exception_)
		{
			AddStaff_Admin.smethod_89(exception_);
			AddStaff_Admin.smethod_108((object)"Cannot Send Mail. Network Not available", (MsgBoxStyle)0, (object)null);
			while (true)
			{
				IL_027c:
				_ = 1775389842;
				while (true)
				{
					_003F val = /*Error near IL_024f: Stack underflow*/^ 0x7FABBCEC;
					uint num2 = (uint)(int)val;
					switch (val % 3)
					{
					default:
						goto end_IL_0249;
					case 2:
						AddStaff_Admin.smethod_90();
						_ = ((int)num2 * -432035443) ^ 0x305F7CA5;
						continue;
					case 0:
						break;
					case 1:
						goto end_IL_0249;
					}
					goto IL_027c;
					continue;
					end_IL_0249:
					break;
				}
				break;
			}
		}
		bool result = default(bool);
		while (true)
		{
			int num3 = 1616614384;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num3 ^ 0x7FABBCECu) % 3u)
				{
				case 1u:
					goto IL_0285;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0285:
				result = true;
				num3 = ((int)num2 * -1265333860) ^ -261873507;
			}
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: false);
		while (true)
		{
			int num = 1493053827;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x44FF1B1Du) % 5u)
				{
				case 4u:
					num = ((int)num2 * -1280251172) ^ -430690576;
					continue;
				case 1u:
					num = (int)((num2 * 1469670072) ^ 0x40797070);
					continue;
				case 0u:
					AddStaff_Admin.smethod_109(Timer1);
					num = (int)((num2 * 2111825033) ^ 0x728F548F);
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
		bool flag4 = default(bool);
		bool result = default(bool);
		bool flag5 = default(bool);
		bool flag = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1400990334;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9A08AFE3u) % 74u)
				{
				case 73u:
					AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Red);
					num = (int)((num2 * 1844084080) ^ 0x6F4A8ED1);
					continue;
				case 72u:
					num = (int)((num2 * 228759821) ^ 0x3DEA64CC);
					continue;
				case 71u:
					AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Red);
					AddStaff_Admin.smethod_87(Timer1);
					num = (int)(num2 * 2080185119) ^ -893334948;
					continue;
				case 70u:
					flag4 = !MyProject.Forms.Form1.Mobile_Validator(AddStaff_Admin.smethod_72(MobileTxt));
					num = -318401326;
					continue;
				case 69u:
				{
					int num16;
					int num17;
					if (flag4)
					{
						num16 = -1440151449;
						num17 = -1440151449;
					}
					else
					{
						num16 = -1091256907;
						num17 = -1091256907;
					}
					num = num16 ^ ((int)num2 * -1939651773);
					continue;
				}
				case 68u:
					AddStaff_Admin.smethod_24(SuccessMsg, "Invalid Gender");
					num = ((int)num2 * -674663984) ^ -1701995623;
					continue;
				case 67u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
					AddStaff_Admin.smethod_24(SuccessMsg, "Email field is required");
					num = (int)(num2 * 101617979) ^ -188148966;
					continue;
				case 66u:
					num = -1456759216;
					continue;
				case 65u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
					num = (int)((num2 * 97614071) ^ 0x296E3626);
					continue;
				case 64u:
					AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -731294332) ^ 0x656F158C;
					continue;
				case 63u:
					num = (int)((num2 * 106609326) ^ 0x40FC9BBB);
					continue;
				case 61u:
				{
					int num9;
					if (AddStaff_Admin.smethod_110(GenderTxt) != -1)
					{
						num = -2019113707;
						num9 = -2019113707;
					}
					else
					{
						num = -1817591006;
						num9 = -1817591006;
					}
					continue;
				}
				case 60u:
					num = ((int)num2 * -378991395) ^ -128368801;
					continue;
				case 59u:
					num = ((int)num2 * -1369469885) ^ 0x2E205F39;
					continue;
				case 58u:
					result = false;
					num = ((int)num2 * -1683983468) ^ 0x31EE1B9D;
					continue;
				case 57u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -1517741233) ^ 0x2EDB4F30;
					continue;
				case 56u:
					num = (int)((num2 * 809470102) ^ 0x72EA4969);
					continue;
				case 55u:
					AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Red);
					num = (int)(num2 * 1999696764) ^ -367640005;
					continue;
				case 54u:
					num = (int)((num2 * 1299612823) ^ 0x1922F4A6);
					continue;
				case 53u:
					num = (int)((num2 * 544497721) ^ 0x30242214);
					continue;
				case 52u:
					AddStaff_Admin.smethod_87(Timer1);
					num = ((int)num2 * -764009545) ^ -1699471828;
					continue;
				case 51u:
					AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -1155379031) ^ -813734547;
					continue;
				case 50u:
					num = (int)((num2 * 1436708982) ^ 0x4C4CF6D5);
					continue;
				case 49u:
					num = -2094264465;
					continue;
				case 48u:
					result = false;
					num = ((int)num2 * -996252812) ^ -1454766867;
					continue;
				case 47u:
				{
					int num14;
					int num15;
					if (flag5)
					{
						num14 = -1542580705;
						num15 = -1542580705;
					}
					else
					{
						num14 = -362996800;
						num15 = -362996800;
					}
					num = num14 ^ ((int)num2 * -1552103478);
					continue;
				}
				case 46u:
				{
					int num12;
					int num13;
					if (!flag)
					{
						num12 = -1186907659;
						num13 = -1186907659;
					}
					else
					{
						num12 = -152587168;
						num13 = -152587168;
					}
					num = num12 ^ (int)(num2 * 413133466);
					continue;
				}
				case 45u:
					flag5 = !MyProject.Forms.Form1.Name_Validation(AddStaff_Admin.smethod_78(AddStaff_Admin.smethod_72(NameTxt)));
					num = (int)(num2 * 1146465082) ^ -1251320192;
					continue;
				case 44u:
					AddStaff_Admin.smethod_24(SuccessMsg, "Invalid Gender");
					num = ((int)num2 * -335534455) ^ -220698504;
					continue;
				case 43u:
					flag3 = AddStaff_Admin.smethod_110(DesignationTxt) == -1;
					num = ((int)num2 * -25499607) ^ -634380415;
					continue;
				case 42u:
					num = (int)(num2 * 677058982) ^ -1879918008;
					continue;
				case 41u:
					AddStaff_Admin.smethod_87(Timer1);
					result = false;
					num = (int)((num2 * 805587308) ^ 0x29130C51);
					continue;
				case 40u:
					result = false;
					num = (int)((num2 * 1746930220) ^ 0x130D0643);
					continue;
				case 39u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -45889368) ^ 0x57F16893;
					continue;
				case 38u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
					num = (int)(num2 * 1128371806) ^ -2119108305;
					continue;
				case 37u:
					AddStaff_Admin.smethod_24(SuccessMsg, "Invalid Name");
					num = ((int)num2 * -905249193) ^ -2133227273;
					continue;
				case 35u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -1003232284) ^ -763333090;
					continue;
				case 34u:
					AddStaff_Admin.smethod_87(Timer1);
					num = (int)(num2 * 77812480) ^ -547033495;
					continue;
				case 33u:
					num = (int)((num2 * 142486148) ^ 0x6315C011);
					continue;
				case 32u:
					AddStaff_Admin.smethod_87(Timer1);
					num = ((int)num2 * -1670009986) ^ 0x4F288C8A;
					continue;
				case 31u:
					AddStaff_Admin.smethod_24(SuccessMsg, "Adress required ");
					num = ((int)num2 * -944264154) ^ -165751854;
					continue;
				case 30u:
					num = (int)((num2 * 956949777) ^ 0x5602826B);
					continue;
				case 29u:
					AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Red);
					num = (int)(num2 * 570503218) ^ -2118744070;
					continue;
				case 28u:
					num = (int)((num2 * 758830200) ^ 0x716D01D1);
					continue;
				case 27u:
					result = true;
					num = -1442731830;
					continue;
				case 26u:
					result = false;
					num = (int)(num2 * 1733662557) ^ -711974852;
					continue;
				case 25u:
					AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -1413204830) ^ -1964793045;
					continue;
				case 24u:
					AddStaff_Admin.smethod_24(SuccessMsg, "Invalid Mobile Number");
					num = ((int)num2 * -620085457) ^ -744199780;
					continue;
				case 23u:
					AddStaff_Admin.smethod_26((Control)(object)SuccessMsg, Color.Red);
					num = ((int)num2 * -1476240102) ^ 0x2BB3C271;
					continue;
				case 22u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
					num = (int)((num2 * 945609808) ^ 0x43E13ECE);
					continue;
				case 21u:
					num = ((int)num2 * -365846584) ^ -36079235;
					continue;
				case 20u:
					num = (int)((num2 * 1396658464) ^ 0x39D881E5);
					continue;
				case 19u:
					AddStaff_Admin.smethod_29((Control)(object)SuccessMsg, bool_0: true);
					num = ((int)num2 * -2069613740) ^ -1664548098;
					continue;
				case 18u:
					AddStaff_Admin.smethod_87(Timer1);
					num = (int)((num2 * 305122234) ^ 0xBA6F925);
					continue;
				case 17u:
					num = -1968995279;
					continue;
				case 16u:
				{
					int num10;
					int num11;
					if (AddStaff_Admin.smethod_111(AddStaff_Admin.smethod_72(AddressTxt), "", bool_0: false) != 0)
					{
						num10 = 1256734694;
						num11 = 1256734694;
					}
					else
					{
						num10 = 1151620208;
						num11 = 1151620208;
					}
					num = num10 ^ (int)(num2 * 2100533885);
					continue;
				}
				case 15u:
					num = ((int)num2 * -1132373302) ^ 0x3A514CAB;
					continue;
				case 14u:
					AddStaff_Admin.smethod_24(SuccessMsg, "Invalid Workshift Number");
					num = (int)((num2 * 1158967421) ^ 0x1CA6D122);
					continue;
				case 13u:
					AddStaff_Admin.smethod_24(SuccessMsg, "Invalid Designation");
					num = (int)((num2 * 142251260) ^ 0x495A49DA);
					continue;
				case 12u:
					flag2 = AddStaff_Admin.smethod_111(AddStaff_Admin.smethod_72(EmailTxt), "", bool_0: false) == 0;
					num = ((int)num2 * -1858326725) ^ -1944367160;
					continue;
				case 11u:
					AddStaff_Admin.smethod_87(Timer1);
					result = false;
					num = (int)((num2 * 235181334) ^ 0x519644B5);
					continue;
				case 10u:
					num = (int)(num2 * 1793526217) ^ -45021749;
					continue;
				case 9u:
				{
					int num7;
					int num8;
					if (!flag3)
					{
						num7 = -220991072;
						num8 = -220991072;
					}
					else
					{
						num7 = -809350558;
						num8 = -809350558;
					}
					num = num7 ^ ((int)num2 * -1238758058);
					continue;
				}
				case 8u:
					num = -1549790267;
					continue;
				case 7u:
					num = -2099358737;
					continue;
				case 6u:
					num = (int)((num2 * 1613593877) ^ 0xF3EE725);
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -508880121;
						num6 = -508880121;
					}
					else
					{
						num5 = -1464990973;
						num6 = -1464990973;
					}
					num = num5 ^ ((int)num2 * -986171371);
					continue;
				}
				case 4u:
					flag = AddStaff_Admin.smethod_110(WorkShiftTxt) == -1;
					num = ((int)num2 * -1231570863) ^ -799700713;
					continue;
				case 3u:
					num = ((int)num2 * -205365408) ^ -1748939707;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!MyProject.Forms.Form1.Gender_Validator(AddStaff_Admin.smethod_78(AddStaff_Admin.smethod_81(GenderTxt))))
					{
						num3 = -1203855235;
						num4 = -1203855235;
					}
					else
					{
						num3 = -158787893;
						num4 = -158787893;
					}
					num = num3 ^ (int)(num2 * 1801047180);
					continue;
				}
				case 1u:
					result = false;
					num = ((int)num2 * -1437518433) ^ -105898441;
					continue;
				case 0u:
					AddStaff_Admin.smethod_87(Timer1);
					num = ((int)num2 * -288066203) ^ -1351126989;
					continue;
				case 62u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private string Random_Password_Generator()
	{
		string string_ = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
		string text = "";
		int int_ = default(int);
		Random random_ = default(Random);
		int num3 = default(int);
		string result = default(string);
		char char_ = default(char);
		while (true)
		{
			int num = 138079876;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4E857BD6u) % 9u)
				{
				case 8u:
					int_ = AddStaff_Admin.smethod_114(random_, 0, AddStaff_Admin.smethod_113(string_));
					num = 1339341101;
					continue;
				case 7u:
				{
					num3 = checked(num3 + 1);
					int num4;
					int num5;
					if (num3 > 10)
					{
						num4 = -1794456509;
						num5 = -1794456509;
					}
					else
					{
						num4 = -2078856118;
						num5 = -2078856118;
					}
					num = num4 ^ ((int)num2 * -921474126);
					continue;
				}
				case 6u:
					random_ = AddStaff_Admin.smethod_112();
					num3 = 1;
					num = (int)(num2 * 2142711850) ^ -186084432;
					continue;
				case 5u:
					result = text;
					num = ((int)num2 * -1381284080) ^ 0x3F1A181B;
					continue;
				case 4u:
					text = AddStaff_Admin.smethod_70(text, AddStaff_Admin.smethod_116(char_));
					num = (int)(num2 * 680397616) ^ -1507521927;
					continue;
				case 2u:
					char_ = AddStaff_Admin.smethod_115(string_, int_);
					num = ((int)num2 * -1698219794) ^ -1159464155;
					continue;
				case 1u:
					num = ((int)num2 * -1945922504) ^ 0xF7A184F;
					continue;
				case 0u:
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

	static DateTimePicker smethod_6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DateTimePicker();
	}

	static TextBox smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static ComboBox smethod_8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ComboBox();
	}

	static Button smethod_9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static Timer smethod_10(IContainer icontainer_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_0);
	}

	static void smethod_11(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_12(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_13(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_14(PictureBox pictureBox_0, Image image_0)
	{
		pictureBox_0.set_Image(image_0);
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

	static void smethod_18(PictureBox pictureBox_0, PictureBoxSizeMode pictureBoxSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		pictureBox_0.set_SizeMode(pictureBoxSizeMode_0);
	}

	static void smethod_19(PictureBox pictureBox_0, int int_0)
	{
		pictureBox_0.set_TabIndex(int_0);
	}

	static void smethod_20(PictureBox pictureBox_0, bool bool_0)
	{
		pictureBox_0.set_TabStop(bool_0);
	}

	static Font smethod_21(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_22(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_23(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_24(Label label_0, string string_0)
	{
		label_0.set_Text(string_0);
	}

	static void smethod_25(Label label_0, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_TextAlign(contentAlignment_0);
	}

	static void smethod_26(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static Color smethod_27()
	{
		return SystemColors.ButtonHighlight;
	}

	static void smethod_28(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
	}

	static void smethod_29(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static ControlCollection smethod_30(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_31(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_32(GroupBox groupBox_0, bool bool_0)
	{
		groupBox_0.set_TabStop(bool_0);
	}

	static void smethod_33(GroupBox groupBox_0, string string_0)
	{
		groupBox_0.set_Text(string_0);
	}

	static void smethod_34(DateTimePicker dateTimePicker_0, DateTimePickerFormat dateTimePickerFormat_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		dateTimePicker_0.set_Format(dateTimePickerFormat_0);
	}

	static void smethod_35(DateTimePicker dateTimePicker_0, DateTime dateTime_0)
	{
		dateTimePicker_0.set_MaxDate(dateTime_0);
	}

	static void smethod_36(DateTimePicker dateTimePicker_0, DateTime dateTime_0)
	{
		dateTimePicker_0.set_MinDate(dateTime_0);
	}

	static void smethod_37(DateTimePicker dateTimePicker_0, DateTime dateTime_0)
	{
		dateTimePicker_0.set_Value(dateTime_0);
	}

	static AutoCompleteStringCollection smethod_38(ComboBox comboBox_0)
	{
		return comboBox_0.get_AutoCompleteCustomSource();
	}

	static void smethod_39(AutoCompleteStringCollection autoCompleteStringCollection_0, string[] string_0)
	{
		autoCompleteStringCollection_0.AddRange(string_0);
	}

	static void smethod_40(ComboBox comboBox_0, AutoCompleteMode autoCompleteMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		comboBox_0.set_AutoCompleteMode(autoCompleteMode_0);
	}

	static void smethod_41(ComboBox comboBox_0, AutoCompleteSource autoCompleteSource_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		comboBox_0.set_AutoCompleteSource(autoCompleteSource_0);
	}

	static void smethod_42(ComboBox comboBox_0, ComboBoxStyle comboBoxStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		comboBox_0.set_DropDownStyle(comboBoxStyle_0);
	}

	static void smethod_43(ListControl listControl_0, bool bool_0)
	{
		listControl_0.set_FormattingEnabled(bool_0);
	}

	static ObjectCollection smethod_44(ComboBox comboBox_0)
	{
		return comboBox_0.get_Items();
	}

	static void smethod_45(ObjectCollection objectCollection_0, object[] object_0)
	{
		objectCollection_0.AddRange(object_0);
	}

	static void smethod_46(TextBox textBox_0, bool bool_0)
	{
		textBox_0.set_Multiline(bool_0);
	}

	static void smethod_47(ButtonBase buttonBase_0, Color color_0)
	{
		buttonBase_0.set_BackColor(color_0);
	}

	static void smethod_48(ButtonBase buttonBase_0, string string_0)
	{
		buttonBase_0.set_Text(string_0);
	}

	static void smethod_49(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_50(Timer timer_0, int int_0)
	{
		timer_0.set_Interval(int_0);
	}

	static void smethod_51(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_52(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static ControlCollection smethod_53(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_54(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_55(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_56(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_57(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_58(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_59(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_60(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_61(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_62(Timer timer_0, EventHandler eventHandler_0)
	{
		timer_0.remove_Tick(eventHandler_0);
	}

	static void smethod_63(Timer timer_0, EventHandler eventHandler_0)
	{
		timer_0.add_Tick(eventHandler_0);
	}

	static string smethod_64(object object_0, string string_0)
	{
		return Strings.Format(object_0, string_0);
	}

	static DateTime smethod_65(string string_0)
	{
		return Conversions.ToDate(string_0);
	}

	static void smethod_66(TextBoxBase textBoxBase_0)
	{
		textBoxBase_0.Clear();
	}

	static DateTime smethod_67()
	{
		return DateAndTime.get_Today();
	}

	static void smethod_68(ComboBox comboBox_0, int int_0)
	{
		comboBox_0.set_SelectedIndex(int_0);
	}

	static OleDbConnection smethod_69()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new OleDbConnection();
	}

	static string smethod_70(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_71(OleDbConnection oleDbConnection_0, string string_0)
	{
		oleDbConnection_0.set_ConnectionString(string_0);
	}

	static string smethod_72(TextBox textBox_0)
	{
		return textBox_0.get_Text();
	}

	static string[] smethod_73(string string_0, char[] char_0)
	{
		return string_0.Split(char_0);
	}

	static DateTime smethod_74(DateTimePicker dateTimePicker_0)
	{
		return dateTimePicker_0.get_Value();
	}

	static void smethod_75(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Open();
	}

	static OleDbCommand smethod_76(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbCommand(string_0, oleDbConnection_0);
	}

	static OleDbParameterCollection smethod_77(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.get_Parameters();
	}

	static string smethod_78(string string_0)
	{
		return string_0.ToLower();
	}

	static OleDbParameter smethod_79(string string_0, object object_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbParameter(string_0, object_0);
	}

	static OleDbParameter smethod_80(OleDbParameterCollection oleDbParameterCollection_0, OleDbParameter oleDbParameter_0)
	{
		return oleDbParameterCollection_0.Add(oleDbParameter_0);
	}

	static string smethod_81(ComboBox comboBox_0)
	{
		return comboBox_0.get_Text();
	}

	static string smethod_82(DateTime dateTime_0)
	{
		return Conversions.ToString(dateTime_0);
	}

	static string smethod_83(string string_0)
	{
		return string_0.ToString();
	}

	static int smethod_84(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.ExecuteNonQuery();
	}

	static void smethod_85(Component component_0)
	{
		component_0.Dispose();
	}

	static void smethod_86(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Close();
	}

	static void smethod_87(Timer timer_0)
	{
		timer_0.Start();
	}

	static object smethod_88(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}

	static void smethod_89(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_90()
	{
		ProjectData.ClearProjectError();
	}

	static SmtpClient smethod_91()
	{
		return new SmtpClient();
	}

	static MailMessage smethod_92()
	{
		return new MailMessage();
	}

	static void smethod_93(SmtpClient smtpClient_0, bool bool_0)
	{
		smtpClient_0.UseDefaultCredentials = bool_0;
	}

	static NetworkCredential smethod_94(string string_0, string string_1)
	{
		return new NetworkCredential(string_0, string_1);
	}

	static void smethod_95(SmtpClient smtpClient_0, ICredentialsByHost icredentialsByHost_0)
	{
		smtpClient_0.Credentials = icredentialsByHost_0;
	}

	static void smethod_96(SmtpClient smtpClient_0, int int_0)
	{
		smtpClient_0.Port = int_0;
	}

	static void smethod_97(SmtpClient smtpClient_0, bool bool_0)
	{
		smtpClient_0.EnableSsl = bool_0;
	}

	static void smethod_98(SmtpClient smtpClient_0, string string_0)
	{
		smtpClient_0.Host = string_0;
	}

	static MailAddress smethod_99(string string_0)
	{
		return new MailAddress(string_0);
	}

	static void smethod_100(MailMessage mailMessage_0, MailAddress mailAddress_0)
	{
		mailMessage_0.From = mailAddress_0;
	}

	static MailAddressCollection smethod_101(MailMessage mailMessage_0)
	{
		return mailMessage_0.To;
	}

	static void smethod_102(MailAddressCollection mailAddressCollection_0, string string_0)
	{
		mailAddressCollection_0.Add(string_0);
	}

	static void smethod_103(MailMessage mailMessage_0, string string_0)
	{
		mailMessage_0.Subject = string_0;
	}

	static void smethod_104(MailMessage mailMessage_0, bool bool_0)
	{
		mailMessage_0.IsBodyHtml = bool_0;
	}

	static string smethod_105(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static void smethod_106(MailMessage mailMessage_0, string string_0)
	{
		mailMessage_0.Body = string_0;
	}

	static void smethod_107(SmtpClient smtpClient_0, MailMessage mailMessage_0)
	{
		smtpClient_0.Send(mailMessage_0);
	}

	static MsgBoxResult smethod_108(object object_0, MsgBoxStyle msgBoxStyle_0, object object_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return Interaction.MsgBox(object_0, msgBoxStyle_0, object_1);
	}

	static void smethod_109(Timer timer_0)
	{
		timer_0.Stop();
	}

	static int smethod_110(ComboBox comboBox_0)
	{
		return comboBox_0.get_SelectedIndex();
	}

	static int smethod_111(string string_0, string string_1, bool bool_0)
	{
		return Operators.CompareString(string_0, string_1, bool_0);
	}

	static Random smethod_112()
	{
		return new Random();
	}

	static int smethod_113(string string_0)
	{
		return string_0.Length;
	}

	static int smethod_114(Random random_0, int int_0, int int_1)
	{
		return random_0.Next(int_0, int_1);
	}

	static char smethod_115(string string_0, int int_0)
	{
		return string_0[int_0];
	}

	static string smethod_116(char char_0)
	{
		return Conversions.ToString(char_0);
	}
}
