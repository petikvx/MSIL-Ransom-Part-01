using System;
using System.ComponentModel;
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
public class EditProfile : UserControl
{
	private IContainer components;

	private OleDbConnection myconnection;

	private string password;

	private string primary_key;

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

	[field: AccessedThroughProperty("DOBTxt")]
	internal virtual TextBox DOBTxt
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

	[field: AccessedThroughProperty("GenderTxt")]
	internal virtual TextBox GenderTxt
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

	[field: AccessedThroughProperty("SIDTxt")]
	internal virtual TextBox SIDTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("OldPasswdTxt")]
	internal virtual TextBox OldPasswdTxt
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
				int num = -90544101;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE2526B92u) % 7u)
					{
					case 6u:
					{
						updateBtn = _UpdateBtn;
						int num5;
						int num6;
						if (updateBtn == null)
						{
							num5 = -129955700;
							num6 = -129955700;
						}
						else
						{
							num5 = -2133788832;
							num6 = -2133788832;
						}
						num = num5 ^ ((int)num2 * -1568755690);
						continue;
					}
					case 5u:
						EditProfile.smethod_46((Control)(object)updateBtn, eventHandler_);
						num = (int)(num2 * 1122839340) ^ -2100623942;
						continue;
					case 3u:
						EditProfile.smethod_47((Control)(object)updateBtn, eventHandler_);
						num = (int)((num2 * 737321148) ^ 0x4D23BBC1);
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (updateBtn == null)
						{
							num3 = -1505351995;
							num4 = -1505351995;
						}
						else
						{
							num3 = -161081712;
							num4 = -161081712;
						}
						num = num3 ^ ((int)num2 * -345736206);
						continue;
					}
					case 1u:
						_UpdateBtn = value;
						updateBtn = _UpdateBtn;
						num = -836414140;
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

	internal virtual CheckBox CheckBox1
	{
		[CompilerGenerated]
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = CheckBox1_CheckedChanged;
			CheckBox checkBox = default(CheckBox);
			while (true)
			{
				int num = -1830254027;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8E692509u) % 8u)
					{
					case 7u:
					{
						int num5;
						int num6;
						if (checkBox != null)
						{
							num5 = 327347725;
							num6 = 327347725;
						}
						else
						{
							num5 = 928441151;
							num6 = 928441151;
						}
						num = num5 ^ (int)(num2 * 211308116);
						continue;
					}
					case 6u:
					{
						int num3;
						int num4;
						if (checkBox == null)
						{
							num3 = 2092171890;
							num4 = 2092171890;
						}
						else
						{
							num3 = 458905118;
							num4 = 458905118;
						}
						num = num3 ^ ((int)num2 * -9751687);
						continue;
					}
					case 4u:
						checkBox = _CheckBox1;
						num = (int)((num2 * 1652238502) ^ 0x1A6131E);
						continue;
					case 2u:
						_CheckBox1 = value;
						checkBox = _CheckBox1;
						num = -590564649;
						continue;
					case 1u:
						EditProfile.smethod_49(checkBox, eventHandler_);
						num = (int)(num2 * 2131953338) ^ -1853203082;
						continue;
					case 0u:
						EditProfile.smethod_48(checkBox, eventHandler_);
						num = ((int)num2 * -1948731243) ^ 0x6F40915B;
						continue;
					default:
						return;
					case 3u:
						break;
					case 5u:
						return;
					}
					break;
				}
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
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

	[field: AccessedThroughProperty("NewPasswdTxt")]
	internal virtual TextBox NewPasswdTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button ChangePasswdBtn
	{
		[CompilerGenerated]
		get
		{
			return _ChangePasswdBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = ChangePasswdBtn_Click;
			Button changePasswdBtn = _ChangePasswdBtn;
			if (changePasswdBtn != null)
			{
				goto IL_0017;
			}
			goto IL_0095;
			IL_0095:
			_ChangePasswdBtn = value;
			changePasswdBtn = _ChangePasswdBtn;
			int num = -237226291;
			goto IL_006c;
			IL_006c:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF4C12E1Bu) % 6u)
				{
				case 5u:
					break;
				case 3u:
					EditProfile.smethod_47((Control)(object)changePasswdBtn, eventHandler_);
					num = ((int)num2 * -1195867833) ^ -1265225122;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (changePasswdBtn != null)
					{
						num3 = -1044478112;
						num4 = -1044478112;
					}
					else
					{
						num3 = -712329213;
						num4 = -712329213;
					}
					num = num3 ^ (int)(num2 * 795310735);
					continue;
				}
				case 1u:
					EditProfile.smethod_46((Control)(object)changePasswdBtn, eventHandler_);
					num = ((int)num2 * -1895710114) ^ -1481077493;
					continue;
				default:
					return;
				case 4u:
					goto IL_0095;
				case 0u:
					return;
				}
				break;
			}
			goto IL_0017;
			IL_0017:
			num = -1690381322;
			goto IL_006c;
		}
	}

	public EditProfile()
	{
		while (true)
		{
			int num = -1224817923;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBE76CDB1u) % 7u)
				{
				case 6u:
					myconnection = EditProfile.smethod_1();
					num = (int)((num2 * 14838401) ^ 0x4B069A4F);
					continue;
				case 4u:
					InitializeComponent();
					num = ((int)num2 * -857013540) ^ -2051806292;
					continue;
				case 3u:
					num = ((int)num2 * -2134517718) ^ 0x1DE1A0A2;
					continue;
				case 2u:
					num = (int)(num2 * 1529176888) ^ -1414371314;
					continue;
				case 0u:
					EditProfile.smethod_0((UserControl)(object)this, (EventHandler)EditProfile_Load);
					num = ((int)num2 * -1071304586) ^ 0x26937876;
					continue;
				default:
					return;
				case 5u:
					break;
				case 1u:
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
			while (true)
			{
				int num = -104204614;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xBDA14438u) % 7u)
					{
					case 6u:
						num = (int)((num2 * 1708889871) ^ 0x75CD9FE7);
						continue;
					case 5u:
						if (disposing)
						{
							num = ((int)num2 * -390243818) ^ -1348270626;
							continue;
						}
						goto IL_0037;
					case 4u:
						EditProfile.smethod_2((IDisposable)components);
						num = (int)(num2 * 1944483987) ^ -1607446922;
						continue;
					case 2u:
						num = (int)(num2 * 1629368227) ^ -1549958975;
						continue;
					case 0u:
						if (components != null)
						{
							num = -1029961695;
							num3 = -1029961695;
							continue;
						}
						goto IL_0037;
					default:
						return;
					case 3u:
						break;
					case 1u:
						return;
						IL_0037:
						num = -1012631459;
						num3 = -1012631459;
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
				int num4 = -745572117;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num4 ^ 0xBDA14438u) % 3u)
					{
					case 1u:
						goto IL_00b7;
					default:
						goto end_IL_00c4;
					case 2u:
						break;
					case 0u:
						goto end_IL_00c4;
					}
					goto IL_00e1;
					IL_00b7:
					num4 = ((int)num2 * -395626075) ^ 0x26D2DD5B;
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
		Label1 = EditProfile.smethod_3();
		while (true)
		{
			int num = 1129219255;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x52D7C3C4u) % 255u)
				{
				case 254u:
					EditProfile.smethod_34(PictureBox1, 7);
					EditProfile.smethod_35(PictureBox1, bool_0: false);
					EditProfile.smethod_36((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = (int)(num2 * 656212935) ^ -1168642198;
					continue;
				case 253u:
					EditProfile.smethod_13((Control)(object)Label8, EditProfile.smethod_12("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					EditProfile.smethod_14((Control)(object)Label8, new Point(21, 32));
					num = ((int)num2 * -477546817) ^ -1704418400;
					continue;
				case 252u:
					EditProfile.smethod_14((Control)(object)NameTxt, new Point(135, 98));
					num = (int)(num2 * 1256754192) ^ -30918778;
					continue;
				case 251u:
					Label2 = EditProfile.smethod_3();
					num = ((int)num2 * -636795903) ^ -13197696;
					continue;
				case 250u:
					num = (int)(num2 * 1260683706) ^ -1073986990;
					continue;
				case 249u:
					num = (int)((num2 * 274125672) ^ 0x194E1994);
					continue;
				case 248u:
					EditProfile.smethod_37((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 513717928) ^ 0x85A46A4);
					continue;
				case 247u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)Label3);
					num = (int)((num2 * 1742959087) ^ 0x7410894);
					continue;
				case 246u:
					num = ((int)num2 * -1502026056) ^ 0x3994AE59;
					continue;
				case 245u:
					num = (int)((num2 * 499946481) ^ 0x39616D76);
					continue;
				case 244u:
					EditProfile.smethod_31(NewPasswdTxt, bool_0: true);
					num = ((int)num2 * -1467386078) ^ 0x76B389F7;
					continue;
				case 243u:
					EditProfile.smethod_21(EditProfile.smethod_39((Control)(object)this), (Control)(object)PictureBox1);
					num = (int)(num2 * 1628432108) ^ -1088136096;
					continue;
				case 242u:
					EditProfile.smethod_29(AddressTxt, bool_0: true);
					EditProfile.smethod_15((Control)(object)AddressTxt, "AddressTxt");
					num = (int)((num2 * 1287164233) ^ 0x2A3E6841);
					continue;
				case 241u:
					EditProfile.smethod_17((Control)(object)AddressTxt, 4);
					num = (int)((num2 * 1356750930) ^ 0x4D3EB387);
					continue;
				case 240u:
					EditProfile.smethod_16((Control)(object)Label1, new Size(330, 47));
					num = (int)(num2 * 133102109) ^ -1626030867;
					continue;
				case 239u:
					num = ((int)num2 * -148197024) ^ 0x6EAAE583;
					continue;
				case 238u:
					num = (int)((num2 * 683500265) ^ 0x52E1CE92);
					continue;
				case 237u:
					EditProfile.smethod_17((Control)(object)GroupBox2, 8);
					num = (int)(num2 * 1783782921) ^ -633962232;
					continue;
				case 236u:
					num = ((int)num2 * -1604928024) ^ 0x2F246132;
					continue;
				case 235u:
					EditProfile.smethod_22(GroupBox1, bool_0: false);
					num = ((int)num2 * -1654511688) ^ 0x6D9BBCF7;
					continue;
				case 234u:
					EditProfile.smethod_17((Control)(object)NameTxt, 0);
					num = (int)(num2 * 844767882) ^ -1328725144;
					continue;
				case 233u:
					EditProfile.smethod_13((Control)(object)Label6, EditProfile.smethod_12("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1537584196) ^ 0x6AFDC4AB;
					continue;
				case 232u:
					num = (int)((num2 * 1790546180) ^ 0x7B0EF070);
					continue;
				case 231u:
					EditProfile.smethod_25((ButtonBase)(object)UpdateBtn, Color.MidnightBlue);
					num = (int)((num2 * 1621060677) ^ 0x2B17FE69);
					continue;
				case 230u:
					Label3 = EditProfile.smethod_3();
					num = (int)((num2 * 874516041) ^ 0x5751B181);
					continue;
				case 229u:
					EditProfile.smethod_14((Control)(object)Label5, new Point(31, 211));
					num = (int)(num2 * 2116086828) ^ -1531510842;
					continue;
				case 228u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)UpdateBtn);
					num = (int)(num2 * 1077280975) ^ -1474426204;
					continue;
				case 227u:
					EditProfile.smethod_17((Control)(object)Label5, 8);
					num = (int)((num2 * 1553167529) ^ 0x2218609E);
					continue;
				case 226u:
					num = (int)(num2 * 120890491) ^ -208148421;
					continue;
				case 225u:
					EditProfile.smethod_19(Label1, (ContentAlignment)32);
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)SIDTxt);
					num = ((int)num2 * -544030514) ^ 0x6758A9CC;
					continue;
				case 224u:
					GroupBox2 = EditProfile.smethod_4();
					num = (int)(num2 * 1284840462) ^ -46662727;
					continue;
				case 223u:
					EditProfile.smethod_14((Control)(object)PictureBox1, new Point(281, 42));
					num = (int)((num2 * 110493021) ^ 0x7ACB9C5);
					continue;
				case 222u:
					num = (int)((num2 * 522571622) ^ 0x3B83EC54);
					continue;
				case 221u:
					SIDTxt = EditProfile.smethod_5();
					num = (int)(num2 * 1412143303) ^ -1771573272;
					continue;
				case 220u:
					num = ((int)num2 * -1258925581) ^ 0x76A2766E;
					continue;
				case 219u:
					num = (int)((num2 * 1159300737) ^ 0x694A2F30);
					continue;
				case 218u:
					Label6 = EditProfile.smethod_3();
					num = (int)(num2 * 2020498473) ^ -1442031314;
					continue;
				case 216u:
					num = ((int)num2 * -1900691729) ^ 0x6064F0B0;
					continue;
				case 215u:
					CheckBox1 = EditProfile.smethod_7();
					num = ((int)num2 * -1443243304) ^ -951684934;
					continue;
				case 214u:
					EditProfile.smethod_15((Control)(object)GroupBox1, "GroupBox1");
					num = ((int)num2 * -1418312166) ^ -94932479;
					continue;
				case 213u:
					num = ((int)num2 * -778386404) ^ -1131567251;
					continue;
				case 212u:
					EditProfile.smethod_43((Control)(object)GroupBox2);
					EditProfile.smethod_42((Control)(object)GroupBox1, bool_0: false);
					num = (int)(num2 * 873383825) ^ -1667983246;
					continue;
				case 211u:
					EditProfile.smethod_13((Control)(object)GroupBox2, EditProfile.smethod_12("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 367802862) ^ 0x5C98E97E);
					continue;
				case 210u:
					EditProfile.smethod_18(Label4, "D.O.B  :");
					num = (int)(num2 * 1986223265) ^ -701601707;
					continue;
				case 209u:
					num = (int)((num2 * 413963718) ^ 0x73E2B89A);
					continue;
				case 208u:
					Label7 = EditProfile.smethod_3();
					num = (int)((num2 * 1179198207) ^ 0x42855E1D);
					continue;
				case 207u:
					EditProfile.smethod_16((Control)(object)MobileTxt, new Size(204, 26));
					num = ((int)num2 * -2120306325) ^ -670508973;
					continue;
				case 206u:
					num = ((int)num2 * -766160555) ^ -2052022176;
					continue;
				case 205u:
					num = ((int)num2 * -393737288) ^ 0x694333C1;
					continue;
				case 204u:
					EditProfile.smethod_15((Control)(object)GroupBox2, "GroupBox2");
					num = ((int)num2 * -526196952) ^ -1038879586;
					continue;
				case 203u:
					num = (int)(num2 * 2101251513) ^ -599573596;
					continue;
				case 202u:
					EditProfile.smethod_43((Control)(object)GroupBox1);
					EditProfile.smethod_44((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -1923390812) ^ 0x39B637E9;
					continue;
				case 201u:
					EditProfile.smethod_18(Label2, "Name :");
					num = (int)((num2 * 945057537) ^ 0x41263A4A);
					continue;
				case 200u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)NameTxt);
					num = ((int)num2 * -1592019613) ^ 0x7E600657;
					continue;
				case 199u:
					EditProfile.smethod_42((Control)(object)GroupBox2, bool_0: false);
					num = ((int)num2 * -859462820) ^ -1759166;
					continue;
				case 198u:
					num = (int)(num2 * 1439671504) ^ -228486225;
					continue;
				case 197u:
					EditProfile.smethod_16((Control)(object)SIDTxt, new Size(91, 26));
					num = (int)((num2 * 700816764) ^ 0x1E987B08);
					continue;
				case 196u:
					EditProfile.smethod_15((Control)(object)Label4, "Label4");
					num = ((int)num2 * -2046003713) ^ 0x31141080;
					continue;
				case 195u:
					num = ((int)num2 * -1567784570) ^ -539911571;
					continue;
				case 194u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)Label2);
					num = (int)((num2 * 1678991071) ^ 0x53BDE14B);
					continue;
				case 193u:
					num = ((int)num2 * -198278046) ^ 0xFF88A06;
					continue;
				case 192u:
					EditProfile.smethod_16((Control)(object)Label6, new Size(87, 26));
					num = (int)(num2 * 895291568) ^ -1177926294;
					continue;
				case 191u:
					EditProfile.smethod_13((Control)(object)Label5, EditProfile.smethod_12("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 2027002524) ^ -159728865;
					continue;
				case 190u:
					EditProfile.smethod_13((Control)(object)NameTxt, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1492972782) ^ -215548033;
					continue;
				case 189u:
					EditProfile.smethod_16((Control)(object)UpdateBtn, new Size(133, 37));
					EditProfile.smethod_17((Control)(object)UpdateBtn, 9);
					num = (int)(num2 * 1667552269) ^ -1403568594;
					continue;
				case 188u:
					EditProfile.smethod_17((Control)(object)Label8, 13);
					num = ((int)num2 * -1271196200) ^ 0x67910AEE;
					continue;
				case 187u:
					EditProfile.smethod_30((ButtonBase)(object)CheckBox1, bool_0: true);
					num = (int)(num2 * 2050639814) ^ -1679543727;
					continue;
				case 186u:
					EditProfile.smethod_15((Control)(object)GenderTxt, "GenderTxt");
					num = ((int)num2 * -1959156629) ^ 0x663EE012;
					continue;
				case 185u:
					EditProfile.smethod_26((Control)(object)UpdateBtn, Color.White);
					num = ((int)num2 * -1435174036) ^ 0x653C49D4;
					continue;
				case 184u:
					ChangePasswdBtn = EditProfile.smethod_6();
					NewPasswdTxt = EditProfile.smethod_5();
					num = ((int)num2 * -1473690848) ^ 0x38BB615F;
					continue;
				case 183u:
					EditProfile.smethod_15((Control)(object)Label3, "Label3");
					num = (int)((num2 * 1634180626) ^ 0x79DFC88C);
					continue;
				case 182u:
					num = ((int)num2 * -1441011495) ^ -454655721;
					continue;
				case 181u:
					EditProfile.smethod_24((TextBoxBase)(object)NameTxt, bool_0: true);
					num = (int)((num2 * 169826190) ^ 0x140AA77E);
					continue;
				case 180u:
					num = ((int)num2 * -1185396353) ^ -298969774;
					continue;
				case 179u:
					Label5 = EditProfile.smethod_3();
					num = ((int)num2 * -24223462) ^ 0x72DB5FC8;
					continue;
				case 178u:
					EditProfile.smethod_16((Control)(object)PictureBox1, new Size(172, 90));
					num = ((int)num2 * -2023536349) ^ 0x4A9EA7F;
					continue;
				case 177u:
					EditProfile.smethod_14((Control)(object)UpdateBtn, new Point(311, 372));
					num = (int)((num2 * 1722477614) ^ 0x36D66072);
					continue;
				case 176u:
					EditProfile.smethod_24((TextBoxBase)(object)DOBTxt, bool_0: true);
					num = ((int)num2 * -408607366) ^ -1306724639;
					continue;
				case 175u:
					num = (int)((num2 * 2118524362) ^ 0x5CA46A8F);
					continue;
				case 174u:
					EditProfile.smethod_17((Control)(object)SIDTxt, 12);
					num = (int)(num2 * 1289711406) ^ -1468513694;
					continue;
				case 173u:
					num = (int)(num2 * 1633028535) ^ -1512776297;
					continue;
				case 172u:
					EditProfile.smethod_16((Control)(object)CheckBox1, new Size(163, 23));
					num = (int)((num2 * 86582665) ^ 0x44E2A3A7);
					continue;
				case 171u:
					num = (int)((num2 * 1514341580) ^ 0x416B842);
					continue;
				case 170u:
					EditProfile.smethod_13((Control)(object)ChangePasswdBtn, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1179906328) ^ -1414534456;
					continue;
				case 169u:
					num = ((int)num2 * -1559069858) ^ -1648061055;
					continue;
				case 168u:
					EditProfile.smethod_14((Control)(object)AddressTxt, new Point(135, 269));
					num = (int)(num2 * 1979197950) ^ -700540092;
					continue;
				case 167u:
					EditProfile.smethod_18(Label3, "Gender :");
					num = ((int)num2 * -952447493) ^ -1385820029;
					continue;
				case 166u:
					EditProfile.smethod_17((Control)(object)GenderTxt, 10);
					num = (int)(num2 * 1148130987) ^ -141607108;
					continue;
				case 165u:
					EditProfile.smethod_16((Control)(object)Label8, new Size(154, 26));
					num = ((int)num2 * -1974322508) ^ 0x62DB2222;
					continue;
				case 164u:
					num = ((int)num2 * -565376243) ^ -1823110371;
					continue;
				case 163u:
					EditProfile.smethod_17((Control)(object)DOBTxt, 1);
					num = ((int)num2 * -957210888) ^ -247955200;
					continue;
				case 162u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)Label5);
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)Label4);
					num = ((int)num2 * -681136499) ^ 0x7F7BFB3D;
					continue;
				case 161u:
					EditProfile.smethod_14((Control)(object)DOBTxt, new Point(135, 148));
					num = ((int)num2 * -1571221017) ^ -313936469;
					continue;
				case 160u:
					EditProfile.smethod_45((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1391167544) ^ -361903467;
					continue;
				case 159u:
					num = ((int)num2 * -601926506) ^ 0x4255201B;
					continue;
				case 158u:
					num = ((int)num2 * -1689765020) ^ -1358943458;
					continue;
				case 157u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox1), (Control)(object)CheckBox1);
					num = (int)((num2 * 1911477211) ^ 0x5E7A4142);
					continue;
				case 156u:
					num = (int)(num2 * 312812675) ^ -1437631647;
					continue;
				case 155u:
					EditProfile.smethod_15((Control)(object)CheckBox1, "CheckBox1");
					num = ((int)num2 * -1249681362) ^ 0x48F78F9B;
					continue;
				case 154u:
					EditProfile.smethod_26((Control)(object)ChangePasswdBtn, Color.White);
					EditProfile.smethod_14((Control)(object)ChangePasswdBtn, new Point(272, 135));
					num = (int)(num2 * 899164326) ^ -278089487;
					continue;
				case 153u:
					EditProfile.smethod_38((Control)(object)this, Color.White);
					num = (int)(num2 * 1489536529) ^ -2052265170;
					continue;
				case 152u:
					EditProfile.smethod_16((Control)(object)Label4, new Size(85, 24));
					num = (int)(num2 * 671541264) ^ -1415701554;
					continue;
				case 151u:
					num = ((int)num2 * -1195022104) ^ -408784581;
					continue;
				case 150u:
					EditProfile.smethod_13((Control)(object)Label1, EditProfile.smethod_12("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1269575082) ^ 0x6829073;
					continue;
				case 149u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)Label7);
					num = ((int)num2 * -1773008252) ^ -1165348592;
					continue;
				case 148u:
					EditProfile.smethod_15((Control)(object)Label8, "Label8");
					num = ((int)num2 * -579850733) ^ 0x18F92846;
					continue;
				case 147u:
					EditProfile.smethod_28((ButtonBase)(object)ChangePasswdBtn, bool_0: false);
					EditProfile.smethod_13((Control)(object)NewPasswdTxt, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1643784298) ^ 0x3CA9B76;
					continue;
				case 146u:
					EditProfile.smethod_19(Label3, (ContentAlignment)32);
					num = (int)((num2 * 1281665771) ^ 0x2A17E955);
					continue;
				case 145u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox1), (Control)(object)OldPasswdTxt);
					num = (int)(num2 * 2060408057) ^ -1941750932;
					continue;
				case 144u:
					EditProfile.smethod_13((Control)(object)GroupBox1, EditProfile.smethod_12("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1368071282) ^ -1627424739;
					continue;
				case 143u:
					num = (int)((num2 * 288243602) ^ 0x3D0A2408);
					continue;
				case 142u:
					EditProfile.smethod_16((Control)(object)NameTxt, new Size(309, 26));
					num = (int)((num2 * 800377015) ^ 0x1A5407F6);
					continue;
				case 141u:
					num = (int)(num2 * 1641086999) ^ -1833940624;
					continue;
				case 140u:
					EditProfile.smethod_16((Control)(object)GroupBox2, new Size(486, 418));
					num = (int)((num2 * 1713520691) ^ 0x6F7BB3F1);
					continue;
				case 139u:
					num = ((int)num2 * -1763853715) ^ 0x782E89F6;
					continue;
				case 138u:
					EditProfile.smethod_18(Label5, "Mobile :");
					EditProfile.smethod_19(Label5, (ContentAlignment)32);
					num = (int)(num2 * 480480780) ^ -1217279140;
					continue;
				case 137u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox1), (Control)(object)NewPasswdTxt);
					num = ((int)num2 * -1800631121) ^ -271532647;
					continue;
				case 136u:
					EditProfile.smethod_15((Control)(object)Label1, "Label1");
					num = (int)(num2 * 1993601275) ^ -184489700;
					continue;
				case 135u:
					num = (int)((num2 * 1834659946) ^ 0x65956CC5);
					continue;
				case 134u:
					EditProfile.smethod_17((Control)(object)Label2, 5);
					num = (int)(num2 * 1383158996) ^ -1424729011;
					continue;
				case 133u:
					EditProfile.smethod_15((Control)(object)SIDTxt, "SIDTxt");
					num = (int)(num2 * 1786928622) ^ -737861944;
					continue;
				case 132u:
					EditProfile.smethod_11((Control)(object)this);
					num = ((int)num2 * -623894992) ^ 0x50E2369C;
					continue;
				case 131u:
					num = (int)(num2 * 581186409) ^ -812491654;
					continue;
				case 130u:
					EditProfile.smethod_16((Control)(object)Label5, new Size(94, 29));
					num = ((int)num2 * -1721406642) ^ -511481728;
					continue;
				case 129u:
					EditProfile.smethod_28((ButtonBase)(object)CheckBox1, bool_0: true);
					EditProfile.smethod_13((Control)(object)OldPasswdTxt, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -356001482) ^ -1675966116;
					continue;
				case 128u:
					EditProfile.smethod_14((Control)(object)Label7, new Point(21, 51));
					EditProfile.smethod_15((Control)(object)Label7, "Label7");
					num = ((int)num2 * -157103525) ^ 0xE45B8C5;
					continue;
				case 127u:
					EditProfile.smethod_16((Control)(object)OldPasswdTxt, new Size(247, 26));
					num = (int)((num2 * 1021142109) ^ 0x58251719);
					continue;
				case 126u:
					EditProfile.smethod_16((Control)(object)GroupBox1, new Size(486, 178));
					num = (int)((num2 * 8936782) ^ 0x900D897);
					continue;
				case 125u:
					Label8 = EditProfile.smethod_3();
					GroupBox1 = EditProfile.smethod_4();
					num = ((int)num2 * -1452469190) ^ -1401860964;
					continue;
				case 124u:
					EditProfile.smethod_17((Control)(object)Label6, 9);
					EditProfile.smethod_18(Label6, "Address :");
					num = ((int)num2 * -1010571735) ^ -1399882707;
					continue;
				case 123u:
					EditProfile.smethod_28((ButtonBase)(object)UpdateBtn, bool_0: false);
					num = ((int)num2 * -122654029) ^ -353443895;
					continue;
				case 121u:
					num = ((int)num2 * -13926304) ^ 0x74571B05;
					continue;
				case 120u:
					EditProfile.smethod_21(EditProfile.smethod_39((Control)(object)this), (Control)(object)GroupBox2);
					num = ((int)num2 * -147106613) ^ 0x3F3F1991;
					continue;
				case 119u:
					EditProfile.smethod_17((Control)(object)Label1, 6);
					EditProfile.smethod_18(Label1, "Edit Profile");
					num = (int)(num2 * 374076381) ^ -1140808206;
					continue;
				case 118u:
					EditProfile.smethod_14((Control)(object)NewPasswdTxt, new Point(197, 73));
					EditProfile.smethod_15((Control)(object)NewPasswdTxt, "NewPasswdTxt");
					EditProfile.smethod_16((Control)(object)NewPasswdTxt, new Size(247, 26));
					EditProfile.smethod_17((Control)(object)NewPasswdTxt, 16);
					num = ((int)num2 * -1853626407) ^ 0x19E097C8;
					continue;
				case 117u:
					EditProfile.smethod_14((Control)(object)GroupBox1, new Point(261, 591));
					num = (int)(num2 * 930417309) ^ -392901958;
					continue;
				case 116u:
					EditProfile.smethod_19(Label9, (ContentAlignment)32);
					EditProfile.smethod_32(PictureBox1, (Image)(object)Resources.patient_pic);
					num = (int)((num2 * 464775672) ^ 0x2F8766AE);
					continue;
				case 115u:
					num = ((int)num2 * -959424022) ^ 0x700B0CEB;
					continue;
				case 114u:
					EditProfile.smethod_15((Control)(object)NameTxt, "NameTxt");
					num = ((int)num2 * -1398416648) ^ 0x5FA3AEDE;
					continue;
				case 113u:
					EditProfile.smethod_13((Control)(object)Label7, EditProfile.smethod_12("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1523209414) ^ 0x20084F9D;
					continue;
				case 112u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox1), (Control)(object)ChangePasswdBtn);
					num = (int)(num2 * 574512942) ^ -1399331097;
					continue;
				case 111u:
					num = (int)(num2 * 344852696) ^ -1578073211;
					continue;
				case 110u:
					EditProfile.smethod_13((Control)(object)CheckBox1, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1693999603) ^ 0xBA237C4;
					continue;
				case 109u:
					MobileTxt = EditProfile.smethod_5();
					DOBTxt = EditProfile.smethod_5();
					num = ((int)num2 * -1463807458) ^ 0x64DD61E5;
					continue;
				case 108u:
					num = (int)(num2 * 96476171) ^ -2082879868;
					continue;
				case 107u:
					EditProfile.smethod_19(Label6, (ContentAlignment)32);
					num = ((int)num2 * -1682281563) ^ 0x2C98D34;
					continue;
				case 106u:
					num = (int)((num2 * 490237533) ^ 0x7D857F02);
					continue;
				case 105u:
					num = ((int)num2 * -59089300) ^ 0x29838A79;
					continue;
				case 104u:
					EditProfile.smethod_14((Control)(object)OldPasswdTxt, new Point(197, 36));
					num = (int)(num2 * 47863890) ^ -374534931;
					continue;
				case 103u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)MobileTxt);
					num = ((int)num2 * -575636947) ^ -131902420;
					continue;
				case 102u:
					EditProfile.smethod_17((Control)(object)Label7, 11);
					EditProfile.smethod_18(Label7, "SID :");
					num = ((int)num2 * -690274734) ^ 0x390A16C;
					continue;
				case 101u:
					num = ((int)num2 * -929538735) ^ -733462598;
					continue;
				case 100u:
					EditProfile.smethod_14((Control)(object)SIDTxt, new Point(135, 51));
					num = ((int)num2 * -160918413) ^ -1245353661;
					continue;
				case 99u:
					EditProfile.smethod_24((TextBoxBase)(object)SIDTxt, bool_0: true);
					num = ((int)num2 * -169699600) ^ -732392063;
					continue;
				case 98u:
					num = ((int)num2 * -34978614) ^ 0x500CFD73;
					continue;
				case 97u:
					num = ((int)num2 * -2137576815) ^ -763756687;
					continue;
				case 96u:
					num = (int)(num2 * 1378211503) ^ -2007119316;
					continue;
				case 95u:
					EditProfile.smethod_15((Control)(object)Label5, "Label5");
					num = ((int)num2 * -706531249) ^ 0x64DDA625;
					continue;
				case 94u:
					num = (int)(num2 * 1084896976) ^ -1027237114;
					continue;
				case 93u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)GenderTxt);
					num = ((int)num2 * -904661509) ^ 0x402672C5;
					continue;
				case 92u:
					EditProfile.smethod_19(Label2, (ContentAlignment)32);
					num = ((int)num2 * -284003889) ^ 0x7E68CDB3;
					continue;
				case 91u:
					EditProfile.smethod_9((Control)(object)GroupBox2);
					num = ((int)num2 * -405569220) ^ 0x1714134;
					continue;
				case 90u:
					EditProfile.smethod_14((Control)(object)Label4, new Point(21, 152));
					num = ((int)num2 * -1694613555) ^ -1967266913;
					continue;
				case 89u:
					EditProfile.smethod_31(OldPasswdTxt, bool_0: true);
					num = ((int)num2 * -1879229302) ^ 0x6C6F63D5;
					continue;
				case 88u:
					PictureBox1 = EditProfile.smethod_8();
					num = (int)(num2 * 726967582) ^ -383319226;
					continue;
				case 87u:
					EditProfile.smethod_15((Control)(object)MobileTxt, "MobileTxt");
					num = ((int)num2 * -1552496251) ^ 0x3AA87400;
					continue;
				case 86u:
					num = (int)((num2 * 607260389) ^ 0x5CE32893);
					continue;
				case 85u:
					EditProfile.smethod_17((Control)(object)GroupBox1, 16);
					num = ((int)num2 * -257022990) ^ -875994998;
					continue;
				case 84u:
					EditProfile.smethod_41((Control)(object)this, new Size(977, 804));
					num = (int)((num2 * 1200646434) ^ 0x7DC50966);
					continue;
				case 83u:
					EditProfile.smethod_9((Control)(object)GroupBox1);
					num = ((int)num2 * -1266510097) ^ 0x355C4423;
					continue;
				case 82u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)Label6);
					num = (int)((num2 * 597878900) ^ 0xF153B68);
					continue;
				case 81u:
					EditProfile.smethod_16((Control)(object)Label3, new Size(73, 31));
					num = (int)((num2 * 708730842) ^ 0x5012C473);
					continue;
				case 80u:
					EditProfile.smethod_13((Control)(object)Label9, EditProfile.smethod_12("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					EditProfile.smethod_14((Control)(object)Label9, new Point(21, 73));
					num = (int)((num2 * 915263470) ^ 0x497F7CBC);
					continue;
				case 79u:
					EditProfile.smethod_16((Control)(object)AddressTxt, new Size(309, 97));
					num = (int)(num2 * 51019237) ^ -1419106392;
					continue;
				case 78u:
					num = (int)(num2 * 1751473734) ^ -1188461460;
					continue;
				case 77u:
					OldPasswdTxt = EditProfile.smethod_5();
					num = ((int)num2 * -2057755149) ^ 0xBBADB8D;
					continue;
				case 76u:
					EditProfile.smethod_14((Control)(object)MobileTxt, new Point(135, 211));
					num = ((int)num2 * -1667459587) ^ 0x26DE0819;
					continue;
				case 75u:
					EditProfile.smethod_15((Control)(object)DOBTxt, "DOBTxt");
					num = (int)(num2 * 1964071575) ^ -1421827650;
					continue;
				case 74u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox1), (Control)(object)Label9);
					num = ((int)num2 * -195662511) ^ -1456113373;
					continue;
				case 73u:
					EditProfile.smethod_17((Control)(object)Label9, 15);
					num = ((int)num2 * -54316785) ^ -1375912799;
					continue;
				case 72u:
					EditProfile.smethod_13((Control)(object)Label4, EditProfile.smethod_12("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -596040092) ^ -477864616;
					continue;
				case 71u:
					num = ((int)num2 * -669959471) ^ 0x10E2B81D;
					continue;
				case 70u:
					EditProfile.smethod_15((Control)(object)Label9, "Label9");
					EditProfile.smethod_16((Control)(object)Label9, new Size(154, 26));
					num = (int)((num2 * 987106865) ^ 0x5667F0AA);
					continue;
				case 69u:
					EditProfile.smethod_21(EditProfile.smethod_39((Control)(object)this), (Control)(object)Label1);
					num = (int)(num2 * 1859403590) ^ -460148676;
					continue;
				case 68u:
					EditProfile.smethod_13((Control)(object)AddressTxt, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1454492901) ^ 0x57F72B02;
					continue;
				case 67u:
					EditProfile.smethod_13((Control)(object)UpdateBtn, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1882310186) ^ 0x10A50B8D);
					continue;
				case 66u:
					num = ((int)num2 * -1324812406) ^ -1611156250;
					continue;
				case 65u:
					num = ((int)num2 * -1111985651) ^ 0x2497230B;
					continue;
				case 64u:
					EditProfile.smethod_33(PictureBox1, (PictureBoxSizeMode)1);
					num = ((int)num2 * -560102040) ^ -207029584;
					continue;
				case 63u:
					num = (int)(num2 * 1983008998) ^ -1871691131;
					continue;
				case 62u:
					Label9 = EditProfile.smethod_3();
					num = (int)((num2 * 1134825246) ^ 0x7D54D19E);
					continue;
				case 61u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)DOBTxt);
					num = ((int)num2 * -763314014) ^ 0x1AC4A669;
					continue;
				case 60u:
					GenderTxt = EditProfile.smethod_5();
					num = ((int)num2 * -974498697) ^ 0x3C2DFCE5;
					continue;
				case 59u:
					num = ((int)num2 * -1416965326) ^ 0x4C9862E4;
					continue;
				case 58u:
					Label4 = EditProfile.smethod_3();
					num = ((int)num2 * -1291743783) ^ -1774511942;
					continue;
				case 57u:
					EditProfile.smethod_14((Control)(object)Label2, new Point(17, 98));
					EditProfile.smethod_15((Control)(object)Label2, "Label2");
					EditProfile.smethod_16((Control)(object)Label2, new Size(87, 29));
					num = ((int)num2 * -526850909) ^ -1345084299;
					continue;
				case 56u:
					num = (int)(num2 * 2114030038) ^ -472546746;
					continue;
				case 55u:
					EditProfile.smethod_10((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -2041406821) ^ -1428984967;
					continue;
				case 54u:
					EditProfile.smethod_15((Control)(object)Label6, "Label6");
					num = (int)(num2 * 1763032807) ^ -539326418;
					continue;
				case 53u:
					num = (int)((num2 * 763685301) ^ 0x25A6A2CD);
					continue;
				case 52u:
					NameTxt = EditProfile.smethod_5();
					num = ((int)num2 * -1917009362) ^ 0x5104EDE2;
					continue;
				case 51u:
					EditProfile.smethod_13((Control)(object)Label2, EditProfile.smethod_12("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1356259649) ^ -239623805;
					continue;
				case 50u:
					EditProfile.smethod_18(Label9, "New Password :");
					num = ((int)num2 * -1818353808) ^ 0x5D65FF86;
					continue;
				case 49u:
					EditProfile.smethod_27((ButtonBase)(object)CheckBox1, "Show Password");
					num = (int)(num2 * 651494898) ^ -1548527749;
					continue;
				case 48u:
					EditProfile.smethod_16((Control)(object)DOBTxt, new Size(128, 26));
					num = ((int)num2 * -473781787) ^ -783996482;
					continue;
				case 47u:
					EditProfile.smethod_22(GroupBox2, bool_0: false);
					EditProfile.smethod_23(GroupBox2, "Personal Information");
					num = ((int)num2 * -1002947519) ^ 0x28B7D5D5;
					continue;
				case 46u:
					num = (int)(num2 * 161106091) ^ -1017340476;
					continue;
				case 45u:
					EditProfile.smethod_17((Control)(object)CheckBox1, 15);
					num = (int)(num2 * 853409023) ^ -1110673566;
					continue;
				case 44u:
					EditProfile.smethod_24((TextBoxBase)(object)GenderTxt, bool_0: true);
					num = ((int)num2 * -940245366) ^ 0x5A9C57B0;
					continue;
				case 43u:
					num = ((int)num2 * -1848899145) ^ 0x7ECCB678;
					continue;
				case 42u:
					EditProfile.smethod_19(Label4, (ContentAlignment)32);
					EditProfile.smethod_13((Control)(object)Label3, EditProfile.smethod_12("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					EditProfile.smethod_14((Control)(object)Label3, new Point(269, 146));
					num = (int)((num2 * 1333329634) ^ 0x4C126690);
					continue;
				case 41u:
					EditProfile.smethod_15((Control)(object)OldPasswdTxt, "OldPasswdTxt");
					num = ((int)num2 * -1939393462) ^ -236939485;
					continue;
				case 40u:
					EditProfile.smethod_15((Control)(object)PictureBox1, "PictureBox1");
					num = (int)(num2 * 451237581) ^ -877842367;
					continue;
				case 39u:
					EditProfile.smethod_14((Control)(object)CheckBox1, new Point(197, 110));
					num = (int)(num2 * 615144206) ^ -1990666711;
					continue;
				case 38u:
					UpdateBtn = EditProfile.smethod_6();
					num = (int)(num2 * 695652974) ^ -2128677512;
					continue;
				case 37u:
					num = ((int)num2 * -1281221235) ^ 0x3A41164E;
					continue;
				case 36u:
					EditProfile.smethod_14((Control)(object)Label6, new Point(31, 269));
					num = (int)((num2 * 1497254964) ^ 0x6602B118);
					continue;
				case 35u:
					num = (int)(num2 * 1681038688) ^ -1399844321;
					continue;
				case 34u:
					EditProfile.smethod_17((Control)(object)OldPasswdTxt, 14);
					num = (int)((num2 * 410633678) ^ 0x267CE9D5);
					continue;
				case 33u:
					EditProfile.smethod_23(GroupBox1, "Change Password");
					EditProfile.smethod_25((ButtonBase)(object)ChangePasswdBtn, Color.MidnightBlue);
					num = (int)((num2 * 608457782) ^ 0x20534CDA);
					continue;
				case 32u:
					num = ((int)num2 * -1337596519) ^ -1510564883;
					continue;
				case 31u:
					num = ((int)num2 * -1644798363) ^ -1781185656;
					continue;
				case 30u:
					EditProfile.smethod_14((Control)(object)Label1, new Point(392, 63));
					num = ((int)num2 * -1985559658) ^ -1157083279;
					continue;
				case 29u:
					num = ((int)num2 * -1174422627) ^ 0x13EA9BB4;
					continue;
				case 28u:
					EditProfile.smethod_13((Control)(object)MobileTxt, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -2123025381) ^ 0xADF7929;
					continue;
				case 27u:
					EditProfile.smethod_18(Label8, "Old Password :");
					EditProfile.smethod_19(Label8, (ContentAlignment)32);
					num = ((int)num2 * -881886629) ^ 0x5885CCDA;
					continue;
				case 26u:
					EditProfile.smethod_21(EditProfile.smethod_39((Control)(object)this), (Control)(object)GroupBox1);
					num = (int)(num2 * 386166363) ^ -989803398;
					continue;
				case 25u:
					num = (int)(num2 * 284273004) ^ -2097725294;
					continue;
				case 24u:
					EditProfile.smethod_15((Control)(object)UpdateBtn, "UpdateBtn");
					num = (int)(num2 * 1615142176) ^ -1115273564;
					continue;
				case 23u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)AddressTxt);
					num = ((int)num2 * -1632741075) ^ 0xC0D87DB;
					continue;
				case 22u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox1), (Control)(object)Label8);
					num = (int)((num2 * 1606450466) ^ 0x43319D27);
					continue;
				case 21u:
					num = ((int)num2 * -1162580885) ^ 0x671295A5;
					continue;
				case 20u:
					num = ((int)num2 * -52176927) ^ -979421720;
					continue;
				case 19u:
					num = ((int)num2 * -708162404) ^ -321960322;
					continue;
				case 18u:
					EditProfile.smethod_17((Control)(object)MobileTxt, 2);
					EditProfile.smethod_13((Control)(object)DOBTxt, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -356853428) ^ 0x12BBD09A;
					continue;
				case 17u:
					EditProfile.smethod_16((Control)(object)GenderTxt, new Size(96, 26));
					num = (int)((num2 * 271509617) ^ 0x6E115CD);
					continue;
				case 16u:
					EditProfile.smethod_16((Control)(object)Label7, new Size(87, 23));
					num = (int)(num2 * 1255562827) ^ -1265257036;
					continue;
				case 15u:
					num = ((int)num2 * -2052215386) ^ -17263105;
					continue;
				case 14u:
					AddressTxt = EditProfile.smethod_5();
					num = (int)((num2 * 1939534491) ^ 0x4E22EDFD);
					continue;
				case 13u:
					EditProfile.smethod_17((Control)(object)Label3, 6);
					num = (int)(num2 * 1069090979) ^ -235909844;
					continue;
				case 12u:
					EditProfile.smethod_15((Control)(object)ChangePasswdBtn, "ChangePasswdBtn");
					EditProfile.smethod_16((Control)(object)ChangePasswdBtn, new Size(172, 37));
					EditProfile.smethod_17((Control)(object)ChangePasswdBtn, 17);
					EditProfile.smethod_27((ButtonBase)(object)ChangePasswdBtn, "Change Password");
					num = (int)(num2 * 962101641) ^ -1989177596;
					continue;
				case 11u:
					EditProfile.smethod_14((Control)(object)GroupBox2, new Point(261, 167));
					num = (int)((num2 * 1236387564) ^ 0x58E8DA5D);
					continue;
				case 10u:
					num = (int)(num2 * 1921855812) ^ -175072972;
					continue;
				case 9u:
					EditProfile.smethod_13((Control)(object)SIDTxt, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -514203593) ^ 0x376E475B;
					continue;
				case 8u:
					EditProfile.smethod_27((ButtonBase)(object)UpdateBtn, "Update");
					num = (int)((num2 * 2124195708) ^ 0x31EA5242);
					continue;
				case 7u:
					num = (int)((num2 * 1782803837) ^ 0x6D4EBBFC);
					continue;
				case 6u:
					EditProfile.smethod_17((Control)(object)Label4, 7);
					num = ((int)num2 * -1477276743) ^ 0x6EBD13CB;
					continue;
				case 5u:
					num = ((int)num2 * -464507778) ^ 0x7F6BA431;
					continue;
				case 4u:
					num = (int)((num2 * 726110226) ^ 0x3FBA5440);
					continue;
				case 3u:
					num = ((int)num2 * -1165197136) ^ 0x7985C204;
					continue;
				case 2u:
					EditProfile.smethod_19(Label7, (ContentAlignment)32);
					EditProfile.smethod_13((Control)(object)GenderTxt, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					EditProfile.smethod_14((Control)(object)GenderTxt, new Point(348, 147));
					num = (int)((num2 * 420143035) ^ 0x7FB2CF65);
					continue;
				case 1u:
					num = (int)((num2 * 1261131810) ^ 0x52B09EA1);
					continue;
				case 0u:
					EditProfile.smethod_40((Control)(object)this, "EditProfile");
					num = (int)((num2 * 1198046119) ^ 0xA430B02);
					continue;
				default:
					return;
				case 122u:
					break;
				case 217u:
					return;
				}
				break;
			}
		}
	}

	private void EditProfile_Load(object sender, EventArgs e)
	{
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected I4, but got Unknown
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected I4, but got Unknown
		//IL_0348: Incompatible stack heights: 0 vs 1
		//IL_0363: Incompatible stack heights: 0 vs 1
		//IL_036a: Incompatible stack heights: 0 vs 1
		EditProfile.smethod_51(myconnection, EditProfile.smethod_50(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
		OleDbCommand val = EditProfile.smethod_52();
		string string_ = default(string);
		OleDbDataReader oleDbDataReader_ = default(OleDbDataReader);
		bool flag = default(bool);
		while (true)
		{
			int num = 1693868819;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x57AD5F4Eu) % 4u)
				{
				case 1u:
					string_ = EditProfile.smethod_53("Select * From [Staff] Where [Username] = '", MyProject.Forms.Form1.username, "';");
					num = ((int)num2 * -405656265) ^ -1581942911;
					continue;
				case 0u:
					EditProfile.smethod_54(myconnection);
					num = (int)(num2 * 2124081049) ^ -389942879;
					continue;
				case 2u:
					break;
				default:
					try
					{
						while (true)
						{
							int num3 = 788247851;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x57AD5F4Eu) % 18u)
								{
								case 17u:
									num3 = ((int)num2 * -1878868804) ^ 0x31961C3D;
									continue;
								case 16u:
									EditProfile.smethod_59(NameTxt, EditProfile.smethod_58(EditProfile.smethod_57(oleDbDataReader_, 1)));
									num3 = ((int)num2 * -444972169) ^ 0x2A86319C;
									continue;
								case 15u:
									primary_key = EditProfile.smethod_58(EditProfile.smethod_57(oleDbDataReader_, 0));
									num3 = (int)((num2 * 868523887) ^ 0x20B0B0C7);
									continue;
								case 14u:
									num3 = (int)((num2 * 1585589009) ^ 0x64F03FB8);
									continue;
								case 13u:
								{
									int num4;
									int num5;
									if (!flag)
									{
										num4 = -2074533553;
										num5 = -2074533553;
									}
									else
									{
										num4 = -975559528;
										num5 = -975559528;
									}
									num3 = num4 ^ ((int)num2 * -808825230);
									continue;
								}
								case 12u:
									EditProfile.smethod_59(SIDTxt, EditProfile.smethod_58(EditProfile.smethod_57(oleDbDataReader_, 0)));
									num3 = 574097058;
									continue;
								case 11u:
									EditProfile.smethod_61(myconnection);
									num3 = ((int)num2 * -425076213) ^ 0x581AF19C;
									continue;
								case 10u:
									flag = EditProfile.smethod_60(oleDbDataReader_);
									num3 = 986017773;
									continue;
								case 8u:
									num3 = (int)((num2 * 1931693209) ^ 0x3B833396);
									continue;
								case 7u:
									EditProfile.smethod_59(AddressTxt, EditProfile.smethod_58(EditProfile.smethod_57(oleDbDataReader_, 6)));
									num3 = (int)((num2 * 910834619) ^ 0x79F8AE4A);
									continue;
								case 6u:
									num3 = (int)(num2 * 248473995) ^ -1985316644;
									continue;
								case 5u:
									val = EditProfile.smethod_55(string_, myconnection);
									oleDbDataReader_ = EditProfile.smethod_56(val);
									num3 = ((int)num2 * -2112293008) ^ 0x7E66EC56;
									continue;
								case 4u:
									num3 = ((int)num2 * -1665485788) ^ 0x7437168F;
									continue;
								case 2u:
									password = EditProfile.smethod_58(EditProfile.smethod_57(oleDbDataReader_, 9));
									num3 = ((int)num2 * -1280526433) ^ 0x6DE39D88;
									continue;
								case 1u:
									EditProfile.smethod_59(MobileTxt, EditProfile.smethod_58(EditProfile.smethod_57(oleDbDataReader_, 5)));
									num3 = (int)((num2 * 1525485299) ^ 0xAE888E3);
									continue;
								case 0u:
									EditProfile.smethod_59(DOBTxt, EditProfile.smethod_58(EditProfile.smethod_57(oleDbDataReader_, 3)));
									EditProfile.smethod_59(GenderTxt, EditProfile.smethod_58(EditProfile.smethod_57(oleDbDataReader_, 4)));
									num3 = ((int)num2 * -1498179791) ^ 0x20AAFC37;
									continue;
								default:
									return;
								case 3u:
									break;
								case 9u:
									return;
								}
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						EditProfile.smethod_62(exception_);
						while (true)
						{
							_ = 1211700867;
							while (true)
							{
								_003F val2 = /*Error near IL_031e: Stack underflow*/^ 0x57AD5F4E;
								num2 = (uint)(int)val2;
								switch (val2 % 4)
								{
								case 1:
									_ = (num2 * 136773714) ^ 0xA8E13B38u;
									continue;
								case 0:
									EditProfile.smethod_61(myconnection);
									_ = (num2 * 1312041190) ^ 0xF7EF14E4u;
									continue;
								case 3:
									break;
								default:
									EditProfile.smethod_63();
									return;
								}
								break;
							}
						}
					}
				}
				break;
			}
		}
	}

	private void UpdateBtn_Click(object sender, EventArgs e)
	{
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected I4, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected I4, but got Unknown
		//IL_0235: Incompatible stack heights: 0 vs 1
		//IL_0245: Incompatible stack heights: 0 vs 1
		//IL_025a: Incompatible stack heights: 0 vs 1
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Incompatible stack heights: 0 vs 1
		//IL_0289: Incompatible stack heights: 0 vs 1
		//IL_0293: Incompatible stack heights: 0 vs 1
		OleDbCommand val = default(OleDbCommand);
		string string_ = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = -186445971;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9A72F398u) % 7u)
				{
				case 5u:
					val = EditProfile.smethod_52();
					string_ = EditProfile.smethod_68(new string[7]
					{
						"Update [Staff] Set [Mobile] = '",
						EditProfile.smethod_64(MobileTxt),
						"', [Address] = '",
						EditProfile.smethod_64(AddressTxt),
						"' Where [SID] = ",
						primary_key,
						";"
					});
					num = -750515771;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -459439654;
						num5 = -459439654;
					}
					else
					{
						num4 = -1614500797;
						num5 = -1614500797;
					}
					num = num4 ^ (int)(num2 * 1949605343);
					continue;
				}
				case 1u:
					flag = !MyProject.Forms.Form1.Mobile_Validator(EditProfile.smethod_65(EditProfile.smethod_64(MobileTxt))) | (EditProfile.smethod_66(EditProfile.smethod_64(AddressTxt), "", bool_0: false) == 0);
					num = ((int)num2 * -496498445) ^ 0x33591354;
					continue;
				case 0u:
					EditProfile.smethod_54(myconnection);
					num = ((int)num2 * -275970147) ^ -646575179;
					continue;
				case 3u:
					break;
				case 4u:
					EditProfile.smethod_67("Incorrect Credentials");
					return;
				default:
					try
					{
						while (true)
						{
							int num3 = -1198234990;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x9A72F398u) % 6u)
								{
								case 5u:
									num3 = ((int)num2 * -583109192) ^ 0x5BD62FEB;
									continue;
								case 3u:
									EditProfile.smethod_61(myconnection);
									num3 = (int)(num2 * 1016205903) ^ -1565015755;
									continue;
								case 2u:
									val = EditProfile.smethod_55(string_, myconnection);
									EditProfile.smethod_69(val);
									num3 = ((int)num2 * -1931583230) ^ 0x225072E5;
									continue;
								case 1u:
									EditProfile.smethod_70((Component)(object)val);
									num3 = (int)((num2 * 1527795390) ^ 0x3A4F1F5D);
									continue;
								case 4u:
									break;
								default:
									EditProfile.smethod_67("Successfully Updated Details");
									return;
								}
								break;
							}
						}
					}
					catch (Exception ex)
					{
						EditProfile.smethod_62(ex);
						Exception exception_ = ex;
						while (true)
						{
							_ = -1057138868;
							while (true)
							{
								_003F val2 = /*Error near IL_01f4: Stack underflow*/^ -1703742568;
								num2 = (uint)(int)val2;
								switch (val2 % 7)
								{
								default:
									return;
								case 6:
									EditProfile.smethod_61(myconnection);
									_ = ((int)num2 * -523033532) ^ 0x2BBE76C0;
									continue;
								case 5:
									_ = ((int)num2 * -1052542344) ^ 0x485433A5;
									continue;
								case 4:
									EditProfile.smethod_63();
									_ = (num2 * 1993238763) ^ 0x6698F7CF;
									continue;
								case 2:
									EditProfile.smethod_67(EditProfile.smethod_71(exception_));
									_ = (num2 * 440221788) ^ 0xEE3B2DD;
									continue;
								case 1:
									_ = ((int)num2 * -1370189487) ^ -1295615912;
									continue;
								case 0:
									break;
								case 3:
									return;
								}
								break;
							}
						}
					}
				}
				break;
			}
		}
	}

	private void ChangePasswdBtn_Click(object sender, EventArgs e)
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected I4, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected I4, but got Unknown
		//IL_025a: Incompatible stack heights: 0 vs 1
		//IL_0261: Incompatible stack heights: 0 vs 1
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		bool flag = EditProfile.smethod_66(EditProfile.smethod_64(OldPasswdTxt), password, bool_0: false) != 0;
		string string_ = default(string);
		while (true)
		{
			int num = -1799211886;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFB14B74Du) % 10u)
				{
				case 9u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = 441762340;
						num7 = 441762340;
					}
					else
					{
						num6 = 1592053920;
						num7 = 1592053920;
					}
					num = num6 ^ (int)(num2 * 177813443);
					continue;
				}
				case 8u:
				{
					OleDbCommand val = EditProfile.smethod_52();
					num = -280521388;
					continue;
				}
				case 7u:
					string_ = EditProfile.smethod_68(new string[5]
					{
						"Update [Staff] Set [Password] = '",
						EditProfile.smethod_64(NewPasswdTxt),
						"' Where [SID] = ",
						primary_key,
						";"
					});
					num = ((int)num2 * -1556533335) ^ -643516159;
					continue;
				case 4u:
					num = -621492423;
					continue;
				case 3u:
					EditProfile.smethod_67("Password cannot be empty field");
					num = ((int)num2 * -873918820) ^ -1637705983;
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (EditProfile.smethod_66(EditProfile.smethod_64(NewPasswdTxt), "", bool_0: false) != 0)
					{
						num4 = 1012618285;
						num5 = 1012618285;
					}
					else
					{
						num4 = 833383138;
						num5 = 833383138;
					}
					num = num4 ^ (int)(num2 * 497710982);
					continue;
				}
				case 5u:
					break;
				default:
					EditProfile.smethod_54(myconnection);
					try
					{
						OleDbCommand val = EditProfile.smethod_55(string_, myconnection);
						EditProfile.smethod_69(val);
						while (true)
						{
							int num3 = -2061625848;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xFB14B74Du) % 6u)
								{
								case 4u:
									EditProfile.smethod_72((TextBoxBase)(object)NewPasswdTxt);
									num3 = (int)((num2 * 1914901985) ^ 0xE82DD04);
									continue;
								case 3u:
									EditProfile.smethod_70((Component)(object)val);
									num3 = (int)(num2 * 1322429062) ^ -1522509427;
									continue;
								case 2u:
									EditProfile.smethod_61(myconnection);
									password = EditProfile.smethod_64(NewPasswdTxt);
									num3 = (int)(num2 * 7467872) ^ -167783212;
									continue;
								case 1u:
									EditProfile.smethod_72((TextBoxBase)(object)OldPasswdTxt);
									num3 = (int)((num2 * 483632688) ^ 0x11D4F805);
									continue;
								case 0u:
									break;
								default:
									EditProfile.smethod_67("Successfully Updated Password");
									return;
								}
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						EditProfile.smethod_62(exception_);
						while (true)
						{
							_ = -174822250;
							while (true)
							{
								_003F val2 = /*Error near IL_0229: Stack underflow*/^ -82528435;
								num2 = (uint)(int)val2;
								switch (val2 % 3)
								{
								case 1:
									EditProfile.smethod_61(myconnection);
									_ = ((int)num2 * -1248711867) ^ 0x5952DC49;
									continue;
								case 0:
									break;
								default:
									EditProfile.smethod_63();
									return;
								}
								break;
							}
						}
					}
				case 6u:
					EditProfile.smethod_67("Invalid Old Password");
					return;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void CheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -1521325379;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFC6CC13Cu) % 13u)
				{
				case 11u:
					num = (int)((num2 * 1917426143) ^ 0x247DAB1B);
					continue;
				case 10u:
					num = (int)(num2 * 852579235) ^ -139840420;
					continue;
				case 9u:
					num = (int)(num2 * 1346461374) ^ -666970623;
					continue;
				case 8u:
					num = ((int)num2 * -614040480) ^ 0x6037B806;
					continue;
				case 7u:
					num = (int)((num2 * 96219482) ^ 0x61A9D5B2);
					continue;
				case 6u:
					flag = EditProfile.smethod_73(OldPasswdTxt);
					num = ((int)num2 * -779386879) ^ -350959541;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 519897524;
						num4 = 519897524;
					}
					else
					{
						num3 = 1145382802;
						num4 = 1145382802;
					}
					num = num3 ^ ((int)num2 * -142104333);
					continue;
				}
				case 4u:
					EditProfile.smethod_31(NewPasswdTxt, bool_0: true);
					num = ((int)num2 * -867898225) ^ -295653689;
					continue;
				case 3u:
					EditProfile.smethod_31(OldPasswdTxt, bool_0: true);
					num = ((int)num2 * -621732433) ^ -160839766;
					continue;
				case 2u:
					EditProfile.smethod_31(OldPasswdTxt, bool_0: false);
					EditProfile.smethod_31(NewPasswdTxt, bool_0: false);
					num = ((int)num2 * -852270094) ^ 0x1AB27DA6;
					continue;
				case 1u:
					num = -36707348;
					continue;
				default:
					return;
				case 12u:
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

	static TextBox smethod_5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static Button smethod_6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static CheckBox smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new CheckBox();
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

	static Font smethod_12(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_13(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_14(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_15(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_16(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_17(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_18(Label label_0, string string_0)
	{
		label_0.set_Text(string_0);
	}

	static void smethod_19(Label label_0, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_TextAlign(contentAlignment_0);
	}

	static ControlCollection smethod_20(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_21(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_22(GroupBox groupBox_0, bool bool_0)
	{
		groupBox_0.set_TabStop(bool_0);
	}

	static void smethod_23(GroupBox groupBox_0, string string_0)
	{
		groupBox_0.set_Text(string_0);
	}

	static void smethod_24(TextBoxBase textBoxBase_0, bool bool_0)
	{
		textBoxBase_0.set_ReadOnly(bool_0);
	}

	static void smethod_25(ButtonBase buttonBase_0, Color color_0)
	{
		buttonBase_0.set_BackColor(color_0);
	}

	static void smethod_26(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
	}

	static void smethod_27(ButtonBase buttonBase_0, string string_0)
	{
		buttonBase_0.set_Text(string_0);
	}

	static void smethod_28(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_29(TextBox textBox_0, bool bool_0)
	{
		textBox_0.set_Multiline(bool_0);
	}

	static void smethod_30(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_AutoSize(bool_0);
	}

	static void smethod_31(TextBox textBox_0, bool bool_0)
	{
		textBox_0.set_UseSystemPasswordChar(bool_0);
	}

	static void smethod_32(PictureBox pictureBox_0, Image image_0)
	{
		pictureBox_0.set_Image(image_0);
	}

	static void smethod_33(PictureBox pictureBox_0, PictureBoxSizeMode pictureBoxSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		pictureBox_0.set_SizeMode(pictureBoxSizeMode_0);
	}

	static void smethod_34(PictureBox pictureBox_0, int int_0)
	{
		pictureBox_0.set_TabIndex(int_0);
	}

	static void smethod_35(PictureBox pictureBox_0, bool bool_0)
	{
		pictureBox_0.set_TabStop(bool_0);
	}

	static void smethod_36(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_37(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_38(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static ControlCollection smethod_39(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_40(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_41(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_42(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_43(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_44(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_45(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_46(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_47(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_48(CheckBox checkBox_0, EventHandler eventHandler_0)
	{
		checkBox_0.remove_CheckedChanged(eventHandler_0);
	}

	static void smethod_49(CheckBox checkBox_0, EventHandler eventHandler_0)
	{
		checkBox_0.add_CheckedChanged(eventHandler_0);
	}

	static string smethod_50(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_51(OleDbConnection oleDbConnection_0, string string_0)
	{
		oleDbConnection_0.set_ConnectionString(string_0);
	}

	static OleDbCommand smethod_52()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new OleDbCommand();
	}

	static string smethod_53(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static void smethod_54(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Open();
	}

	static OleDbCommand smethod_55(string string_0, OleDbConnection oleDbConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new OleDbCommand(string_0, oleDbConnection_0);
	}

	static OleDbDataReader smethod_56(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.ExecuteReader();
	}

	static object smethod_57(OleDbDataReader oleDbDataReader_0, int int_0)
	{
		return oleDbDataReader_0.get_Item(int_0);
	}

	static string smethod_58(object object_0)
	{
		return Conversions.ToString(object_0);
	}

	static void smethod_59(TextBox textBox_0, string string_0)
	{
		textBox_0.set_Text(string_0);
	}

	static bool smethod_60(OleDbDataReader oleDbDataReader_0)
	{
		return oleDbDataReader_0.Read();
	}

	static void smethod_61(OleDbConnection oleDbConnection_0)
	{
		oleDbConnection_0.Close();
	}

	static void smethod_62(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_63()
	{
		ProjectData.ClearProjectError();
	}

	static string smethod_64(TextBox textBox_0)
	{
		return textBox_0.get_Text();
	}

	static string smethod_65(string string_0)
	{
		return string_0.ToLower();
	}

	static int smethod_66(string string_0, string string_1, bool bool_0)
	{
		return Operators.CompareString(string_0, string_1, bool_0);
	}

	static DialogResult smethod_67(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}

	static string smethod_68(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static int smethod_69(OleDbCommand oleDbCommand_0)
	{
		return oleDbCommand_0.ExecuteNonQuery();
	}

	static void smethod_70(Component component_0)
	{
		component_0.Dispose();
	}

	static string smethod_71(Exception exception_0)
	{
		return exception_0.Message;
	}

	static void smethod_72(TextBoxBase textBoxBase_0)
	{
		textBoxBase_0.Clear();
	}

	static bool smethod_73(TextBox textBox_0)
	{
		return textBox_0.get_UseSystemPasswordChar();
	}
}
