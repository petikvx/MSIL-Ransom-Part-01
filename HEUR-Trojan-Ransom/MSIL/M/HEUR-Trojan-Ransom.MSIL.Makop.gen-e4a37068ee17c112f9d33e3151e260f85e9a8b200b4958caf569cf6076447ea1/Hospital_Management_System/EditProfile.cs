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
				int num = 1724623951;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7E3760B7u) % 7u)
					{
					case 6u:
						EditProfile.smethod_46((Control)(object)updateBtn, eventHandler_);
						num = (int)(num2 * 534303039) ^ -1590564869;
						continue;
					case 5u:
						EditProfile.smethod_47((Control)(object)updateBtn, eventHandler_);
						num = ((int)num2 * -396571625) ^ -1751272677;
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (updateBtn == null)
						{
							num4 = 629545931;
							num5 = 629545931;
						}
						else
						{
							num4 = 316464825;
							num5 = 316464825;
						}
						num = num4 ^ ((int)num2 * -1547052979);
						continue;
					}
					case 3u:
						updateBtn = _UpdateBtn;
						num = (int)((num2 * 1633048922) ^ 0x19EC14DE);
						continue;
					case 1u:
					{
						_UpdateBtn = value;
						updateBtn = _UpdateBtn;
						int num3;
						if (updateBtn != null)
						{
							num = 1888089838;
							num3 = 1888089838;
						}
						else
						{
							num = 1970790116;
							num3 = 1970790116;
						}
						continue;
					}
					default:
						return;
					case 0u:
						break;
					case 2u:
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
			CheckBox checkBox = _CheckBox1;
			while (true)
			{
				int num = -1791220542;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA905D66Cu) % 8u)
					{
					case 7u:
						checkBox = _CheckBox1;
						num = ((int)num2 * -1901261411) ^ -404292604;
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (checkBox == null)
						{
							num5 = -1765199282;
							num6 = -1765199282;
						}
						else
						{
							num5 = -31359852;
							num6 = -31359852;
						}
						num = num5 ^ ((int)num2 * -123164653);
						continue;
					}
					case 3u:
					{
						int num3;
						int num4;
						if (checkBox != null)
						{
							num3 = -1656786523;
							num4 = -1656786523;
						}
						else
						{
							num3 = -855629304;
							num4 = -855629304;
						}
						num = num3 ^ (int)(num2 * 1247372360);
						continue;
					}
					case 2u:
						EditProfile.smethod_48(checkBox, eventHandler_);
						num = ((int)num2 * -45338593) ^ 0x2FC4CA8A;
						continue;
					case 1u:
						EditProfile.smethod_49(checkBox, eventHandler_);
						num = (int)(num2 * 419265626) ^ -1635111638;
						continue;
					case 0u:
						_CheckBox1 = value;
						num = -862707381;
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
			Button changePasswdBtn = default(Button);
			while (true)
			{
				int num = -530445682;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC29E32E8u) % 8u)
					{
					case 6u:
						changePasswdBtn = _ChangePasswdBtn;
						num = (int)(num2 * 1842941297) ^ -710799698;
						continue;
					case 5u:
						EditProfile.smethod_46((Control)(object)changePasswdBtn, eventHandler_);
						num = (int)(num2 * 972525669) ^ -1662105686;
						continue;
					case 4u:
					{
						changePasswdBtn = _ChangePasswdBtn;
						int num5;
						int num6;
						if (changePasswdBtn != null)
						{
							num5 = 1182693069;
							num6 = 1182693069;
						}
						else
						{
							num5 = 1566176243;
							num6 = 1566176243;
						}
						num = num5 ^ (int)(num2 * 1549649951);
						continue;
					}
					case 3u:
						_ChangePasswdBtn = value;
						num = -1925910412;
						continue;
					case 1u:
						EditProfile.smethod_47((Control)(object)changePasswdBtn, eventHandler_);
						num = (int)((num2 * 905121582) ^ 0x6AE74AB9);
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (changePasswdBtn != null)
						{
							num3 = 842358997;
							num4 = 842358997;
						}
						else
						{
							num3 = 1232370619;
							num4 = 1232370619;
						}
						num = num3 ^ (int)(num2 * 1263005722);
						continue;
					}
					default:
						return;
					case 2u:
						break;
					case 7u:
						return;
					}
					break;
				}
			}
		}
	}

	public EditProfile()
	{
		EditProfile.smethod_0((UserControl)(object)this, (EventHandler)EditProfile_Load);
		myconnection = EditProfile.smethod_1();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			while (true)
			{
				int num = -721223596;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xD9150395u) % 7u)
					{
					case 6u:
						EditProfile.smethod_2((IDisposable)components);
						num = (int)((num2 * 1454277145) ^ 0x61995378);
						continue;
					case 5u:
						if (components != null)
						{
							num = -1449431326;
							num3 = -1449431326;
							continue;
						}
						goto IL_002c;
					case 3u:
						num = -271880973;
						continue;
					case 2u:
						if (disposing)
						{
							num = ((int)num2 * -633613421) ^ -1990908575;
							continue;
						}
						goto IL_002c;
					case 0u:
						num = (int)((num2 * 1716703153) ^ 0x138F8E36);
						continue;
					default:
						return;
					case 4u:
						break;
					case 1u:
						return;
						IL_002c:
						num = -292887324;
						num3 = -292887324;
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
			int num = -1015865995;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9F3484F1u) % 267u)
				{
				case 266u:
					num = (int)(num2 * 1211519329) ^ -264043432;
					continue;
				case 265u:
					num = (int)(num2 * 1812586818) ^ -1696068537;
					continue;
				case 264u:
					EditProfile.smethod_17((Control)(object)Label7, 11);
					num = (int)((num2 * 12033271) ^ 0x5A94E8CA);
					continue;
				case 263u:
					EditProfile.smethod_15((Control)(object)SIDTxt, "SIDTxt");
					EditProfile.smethod_24((TextBoxBase)(object)SIDTxt, bool_0: true);
					num = ((int)num2 * -502067233) ^ -984526513;
					continue;
				case 262u:
					num = (int)(num2 * 951915173) ^ -439419483;
					continue;
				case 261u:
					EditProfile.smethod_14((Control)(object)OldPasswdTxt, new Point(197, 36));
					num = (int)((num2 * 1363108560) ^ 0x73837837);
					continue;
				case 260u:
					num = (int)((num2 * 2040027043) ^ 0x35AF7F2D);
					continue;
				case 259u:
					GenderTxt = EditProfile.smethod_5();
					num = ((int)num2 * -383714303) ^ 0x4BBB6E1E;
					continue;
				case 258u:
					num = (int)((num2 * 804568857) ^ 0x3A7B13B5);
					continue;
				case 257u:
					EditProfile.smethod_13((Control)(object)DOBTxt, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1768460635) ^ 0x671E050B);
					continue;
				case 256u:
					EditProfile.smethod_14((Control)(object)Label4, new Point(21, 152));
					num = ((int)num2 * -1094205130) ^ 0x71665EA0;
					continue;
				case 255u:
					EditProfile.smethod_17((Control)(object)Label3, 6);
					num = (int)((num2 * 1192770498) ^ 0x7D6D958F);
					continue;
				case 254u:
					num = (int)((num2 * 1688076603) ^ 0x602019A8);
					continue;
				case 253u:
					EditProfile.smethod_13((Control)(object)OldPasswdTxt, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 897538577) ^ 0x1955A9D2);
					continue;
				case 252u:
					num = ((int)num2 * -956712594) ^ 0x70C66C1E;
					continue;
				case 251u:
					EditProfile.smethod_15((Control)(object)DOBTxt, "DOBTxt");
					num = ((int)num2 * -1282286539) ^ -1137570737;
					continue;
				case 250u:
					EditProfile.smethod_19(Label3, (ContentAlignment)32);
					num = ((int)num2 * -1893449578) ^ 0x69EFF59D;
					continue;
				case 249u:
					EditProfile.smethod_17((Control)(object)UpdateBtn, 9);
					num = ((int)num2 * -558412840) ^ -1864490082;
					continue;
				case 248u:
					EditProfile.smethod_21(EditProfile.smethod_39((Control)(object)this), (Control)(object)GroupBox2);
					num = (int)((num2 * 2119331405) ^ 0x7A45834F);
					continue;
				case 247u:
					EditProfile.smethod_17((Control)(object)GenderTxt, 10);
					num = (int)((num2 * 1250976301) ^ 0x26A600EE);
					continue;
				case 246u:
					EditProfile.smethod_16((Control)(object)AddressTxt, new Size(309, 97));
					EditProfile.smethod_17((Control)(object)AddressTxt, 4);
					num = (int)((num2 * 48759286) ^ 0x2E609BC5);
					continue;
				case 245u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)Label2);
					num = ((int)num2 * -1210271837) ^ -508821148;
					continue;
				case 244u:
					EditProfile.smethod_34(PictureBox1, 7);
					num = (int)((num2 * 672769119) ^ 0x7B9D411A);
					continue;
				case 243u:
					EditProfile.smethod_16((Control)(object)OldPasswdTxt, new Size(247, 26));
					EditProfile.smethod_17((Control)(object)OldPasswdTxt, 14);
					num = ((int)num2 * -613536196) ^ -1275223857;
					continue;
				case 242u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)Label7);
					num = (int)(num2 * 205073576) ^ -1141917662;
					continue;
				case 241u:
					EditProfile.smethod_17((Control)(object)NewPasswdTxt, 16);
					num = (int)(num2 * 1049547538) ^ -156708194;
					continue;
				case 240u:
					num = (int)((num2 * 1332070022) ^ 0x1241132C);
					continue;
				case 239u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox1), (Control)(object)Label9);
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox1), (Control)(object)OldPasswdTxt);
					num = ((int)num2 * -297036873) ^ 0x1E65E5E8;
					continue;
				case 238u:
					EditProfile.smethod_15((Control)(object)ChangePasswdBtn, "ChangePasswdBtn");
					num = (int)(num2 * 2144761190) ^ -554369229;
					continue;
				case 237u:
					num = (int)(num2 * 647902909) ^ -1795005249;
					continue;
				case 236u:
					EditProfile.smethod_14((Control)(object)Label9, new Point(21, 73));
					num = (int)((num2 * 1653083706) ^ 0x119EE4F9);
					continue;
				case 235u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox1), (Control)(object)ChangePasswdBtn);
					num = (int)((num2 * 1073002323) ^ 0x121B9AC6);
					continue;
				case 234u:
					EditProfile.smethod_15((Control)(object)Label8, "Label8");
					num = ((int)num2 * -937469533) ^ 0x4601E387;
					continue;
				case 233u:
					EditProfile.smethod_21(EditProfile.smethod_39((Control)(object)this), (Control)(object)PictureBox1);
					EditProfile.smethod_21(EditProfile.smethod_39((Control)(object)this), (Control)(object)Label1);
					num = (int)(num2 * 1906416242) ^ -1463275843;
					continue;
				case 232u:
					EditProfile.smethod_27((ButtonBase)(object)ChangePasswdBtn, "Change Password");
					num = ((int)num2 * -2049585235) ^ 0x124C549C;
					continue;
				case 231u:
					EditProfile.smethod_28((ButtonBase)(object)CheckBox1, bool_0: true);
					num = ((int)num2 * -1085811293) ^ -1239044328;
					continue;
				case 230u:
					EditProfile.smethod_38((Control)(object)this, Color.White);
					num = (int)((num2 * 890096297) ^ 0x22196A08);
					continue;
				case 229u:
					EditProfile.smethod_13((Control)(object)GenderTxt, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1492185801) ^ 0x7A3A3F97);
					continue;
				case 228u:
					EditProfile.smethod_13((Control)(object)UpdateBtn, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1156610553) ^ 0x4E674561);
					continue;
				case 227u:
					EditProfile.smethod_16((Control)(object)NameTxt, new Size(309, 26));
					EditProfile.smethod_17((Control)(object)NameTxt, 0);
					num = ((int)num2 * -343778294) ^ -974373089;
					continue;
				case 226u:
					EditProfile.smethod_18(Label3, "Gender :");
					num = ((int)num2 * -2030471637) ^ 0x2511ADD1;
					continue;
				case 225u:
					EditProfile.smethod_14((Control)(object)GenderTxt, new Point(348, 147));
					num = ((int)num2 * -274672173) ^ 0x6B795D4E;
					continue;
				case 224u:
					EditProfile.smethod_16((Control)(object)Label5, new Size(94, 29));
					num = ((int)num2 * -796998744) ^ -548193156;
					continue;
				case 223u:
					num = ((int)num2 * -2112360698) ^ 0x74FEB560;
					continue;
				case 222u:
					EditProfile.smethod_9((Control)(object)GroupBox2);
					num = (int)(num2 * 260824858) ^ -2117252546;
					continue;
				case 221u:
					num = ((int)num2 * -1827504770) ^ -1411990408;
					continue;
				case 220u:
					EditProfile.smethod_15((Control)(object)AddressTxt, "AddressTxt");
					num = ((int)num2 * -413633379) ^ 0x7CD37874;
					continue;
				case 219u:
					num = (int)(num2 * 208248627) ^ -1941348885;
					continue;
				case 218u:
					EditProfile.smethod_16((Control)(object)GroupBox2, new Size(486, 418));
					num = ((int)num2 * -350347797) ^ -1434049558;
					continue;
				case 217u:
					EditProfile.smethod_15((Control)(object)MobileTxt, "MobileTxt");
					num = ((int)num2 * -1947653464) ^ 0x6B874D00;
					continue;
				case 216u:
					EditProfile.smethod_19(Label7, (ContentAlignment)32);
					num = ((int)num2 * -1638591619) ^ 0x4EFF5B91;
					continue;
				case 215u:
					EditProfile.smethod_18(Label9, "New Password :");
					num = (int)((num2 * 1537003700) ^ 0x6285CA8);
					continue;
				case 214u:
					num = (int)((num2 * 1949601499) ^ 0x29A92263);
					continue;
				case 213u:
					EditProfile.smethod_13((Control)(object)ChangePasswdBtn, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1490645259) ^ -1472568421;
					continue;
				case 212u:
					EditProfile.smethod_17((Control)(object)DOBTxt, 1);
					num = (int)(num2 * 1433226383) ^ -1660395920;
					continue;
				case 211u:
					EditProfile.smethod_40((Control)(object)this, "EditProfile");
					num = ((int)num2 * -946068580) ^ 0x3668EC81;
					continue;
				case 210u:
					EditProfile.smethod_15((Control)(object)Label4, "Label4");
					num = (int)((num2 * 1322896728) ^ 0x5F3F72D6);
					continue;
				case 209u:
					EditProfile.smethod_16((Control)(object)NewPasswdTxt, new Size(247, 26));
					num = (int)(num2 * 327741397) ^ -834189628;
					continue;
				case 208u:
					EditProfile.smethod_15((Control)(object)Label9, "Label9");
					num = ((int)num2 * -785066457) ^ -2026076134;
					continue;
				case 207u:
					EditProfile.smethod_15((Control)(object)Label1, "Label1");
					num = ((int)num2 * -2098702000) ^ -445022423;
					continue;
				case 206u:
					num = ((int)num2 * -277575858) ^ -469125576;
					continue;
				case 205u:
					num = ((int)num2 * -1066385771) ^ 0x9D58687;
					continue;
				case 204u:
					EditProfile.smethod_15((Control)(object)CheckBox1, "CheckBox1");
					num = (int)(num2 * 1047725374) ^ -437417427;
					continue;
				case 203u:
					num = (int)((num2 * 6267807) ^ 0x3BCE3974);
					continue;
				case 202u:
					num = ((int)num2 * -88252785) ^ -1753408091;
					continue;
				case 201u:
					EditProfile.smethod_16((Control)(object)Label1, new Size(330, 47));
					num = (int)(num2 * 1528169510) ^ -317017715;
					continue;
				case 200u:
					EditProfile.smethod_14((Control)(object)GroupBox2, new Point(261, 167));
					num = ((int)num2 * -809202949) ^ 0x2A185591;
					continue;
				case 199u:
					Label1 = EditProfile.smethod_3();
					num = ((int)num2 * -1645643525) ^ 0x18710752;
					continue;
				case 198u:
					EditProfile.smethod_17((Control)(object)MobileTxt, 2);
					num = (int)((num2 * 686498398) ^ 0x3BF5A80C);
					continue;
				case 197u:
					num = (int)(num2 * 749934983) ^ -547601193;
					continue;
				case 196u:
					num = ((int)num2 * -1737064833) ^ 0x29BD9E33;
					continue;
				case 195u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)SIDTxt);
					num = ((int)num2 * -1891060154) ^ -1499459905;
					continue;
				case 194u:
					EditProfile.smethod_36((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = (int)(num2 * 699197177) ^ -1467985264;
					continue;
				case 193u:
					num = (int)(num2 * 331652563) ^ -680260994;
					continue;
				case 192u:
					EditProfile.smethod_18(Label2, "Name :");
					num = ((int)num2 * -597189269) ^ -1423375739;
					continue;
				case 191u:
					EditProfile.smethod_14((Control)(object)ChangePasswdBtn, new Point(272, 135));
					num = (int)((num2 * 1101928346) ^ 0x3646BDF6);
					continue;
				case 190u:
					AddressTxt = EditProfile.smethod_5();
					num = ((int)num2 * -871966061) ^ -1615443954;
					continue;
				case 189u:
					EditProfile.smethod_14((Control)(object)SIDTxt, new Point(135, 51));
					num = ((int)num2 * -1272455992) ^ 0x181EBB4E;
					continue;
				case 188u:
					EditProfile.smethod_17((Control)(object)ChangePasswdBtn, 17);
					num = ((int)num2 * -538475477) ^ -20287474;
					continue;
				case 187u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)AddressTxt);
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)MobileTxt);
					num = (int)((num2 * 767921765) ^ 0x752888B6);
					continue;
				case 186u:
					num = (int)(num2 * 1090749131) ^ -135304983;
					continue;
				case 184u:
					num = ((int)num2 * -1017558939) ^ -1577274612;
					continue;
				case 183u:
					num = ((int)num2 * -1483105543) ^ 0x1937726D;
					continue;
				case 182u:
					num = ((int)num2 * -1645146729) ^ 0x57E1C5AA;
					continue;
				case 181u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox1), (Control)(object)CheckBox1);
					num = ((int)num2 * -980183792) ^ 0x7566EF67;
					continue;
				case 180u:
					EditProfile.smethod_11((Control)(object)this);
					num = (int)((num2 * 2058998740) ^ 0x7FA4BCB2);
					continue;
				case 179u:
					EditProfile.smethod_13((Control)(object)MobileTxt, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1051862032) ^ 0x728888D1;
					continue;
				case 178u:
					SIDTxt = EditProfile.smethod_5();
					num = (int)((num2 * 394586672) ^ 0x7C7A3C4B);
					continue;
				case 177u:
					num = (int)((num2 * 829172507) ^ 0x27E10D96);
					continue;
				case 176u:
					num = (int)(num2 * 1701732606) ^ -804854298;
					continue;
				case 175u:
					EditProfile.smethod_27((ButtonBase)(object)UpdateBtn, "Update");
					num = (int)(num2 * 140478920) ^ -2058467829;
					continue;
				case 174u:
					num = (int)(num2 * 655254974) ^ -2002631479;
					continue;
				case 173u:
					EditProfile.smethod_18(Label5, "Mobile :");
					EditProfile.smethod_19(Label5, (ContentAlignment)32);
					num = ((int)num2 * -991802726) ^ -388284113;
					continue;
				case 172u:
					EditProfile.smethod_43((Control)(object)GroupBox2);
					num = ((int)num2 * -921100282) ^ 0x4AF562B2;
					continue;
				case 171u:
					ChangePasswdBtn = EditProfile.smethod_6();
					num = ((int)num2 * -901369839) ^ 0x1442300A;
					continue;
				case 170u:
					EditProfile.smethod_16((Control)(object)Label2, new Size(87, 29));
					num = ((int)num2 * -954527211) ^ -425147262;
					continue;
				case 169u:
					num = ((int)num2 * -1478487089) ^ 0x5A15780A;
					continue;
				case 168u:
					EditProfile.smethod_16((Control)(object)GenderTxt, new Size(96, 26));
					num = (int)((num2 * 1346204091) ^ 0x3B7F8EC2);
					continue;
				case 167u:
					UpdateBtn = EditProfile.smethod_6();
					Label7 = EditProfile.smethod_3();
					num = (int)(num2 * 2101596265) ^ -1192973925;
					continue;
				case 165u:
					EditProfile.smethod_15((Control)(object)Label6, "Label6");
					EditProfile.smethod_16((Control)(object)Label6, new Size(87, 26));
					num = (int)((num2 * 1104618130) ^ 0x32FC4001);
					continue;
				case 164u:
					EditProfile.smethod_17((Control)(object)Label4, 7);
					EditProfile.smethod_18(Label4, "D.O.B  :");
					EditProfile.smethod_19(Label4, (ContentAlignment)32);
					num = ((int)num2 * -1612276893) ^ 0x39BA5C7A;
					continue;
				case 163u:
					num = (int)((num2 * 529213167) ^ 0x2BF80245);
					continue;
				case 162u:
					EditProfile.smethod_16((Control)(object)MobileTxt, new Size(204, 26));
					num = ((int)num2 * -1708663675) ^ -348727039;
					continue;
				case 161u:
					GroupBox2 = EditProfile.smethod_4();
					num = ((int)num2 * -1248312169) ^ 0x111DDBCB;
					continue;
				case 160u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox1), (Control)(object)Label8);
					EditProfile.smethod_13((Control)(object)GroupBox1, EditProfile.smethod_12("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -184177549) ^ 0x6D9033D1;
					continue;
				case 159u:
					EditProfile.smethod_16((Control)(object)Label3, new Size(73, 31));
					num = ((int)num2 * -1448072043) ^ -1669554006;
					continue;
				case 158u:
					EditProfile.smethod_15((Control)(object)GenderTxt, "GenderTxt");
					EditProfile.smethod_24((TextBoxBase)(object)GenderTxt, bool_0: true);
					num = ((int)num2 * -1800127935) ^ -1487429920;
					continue;
				case 157u:
					num = (int)(num2 * 1063974580) ^ -620631168;
					continue;
				case 156u:
					EditProfile.smethod_13((Control)(object)Label4, EditProfile.smethod_12("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 793359017) ^ -1385192847;
					continue;
				case 155u:
					EditProfile.smethod_13((Control)(object)NameTxt, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -706449755) ^ -634875556;
					continue;
				case 154u:
					Label4 = EditProfile.smethod_3();
					Label3 = EditProfile.smethod_3();
					num = ((int)num2 * -1976796605) ^ 0x514D2F7A;
					continue;
				case 153u:
					EditProfile.smethod_15((Control)(object)NewPasswdTxt, "NewPasswdTxt");
					num = ((int)num2 * -1270295374) ^ 0x411168B0;
					continue;
				case 152u:
					EditProfile.smethod_26((Control)(object)ChangePasswdBtn, Color.White);
					num = (int)(num2 * 1034107562) ^ -770918089;
					continue;
				case 151u:
					EditProfile.smethod_14((Control)(object)DOBTxt, new Point(135, 148));
					num = ((int)num2 * -716185662) ^ -1965304168;
					continue;
				case 150u:
					num = ((int)num2 * -1597304684) ^ 0x10FB62AB;
					continue;
				case 149u:
					num = ((int)num2 * -1531321471) ^ -292084339;
					continue;
				case 148u:
					EditProfile.smethod_14((Control)(object)GroupBox1, new Point(261, 591));
					EditProfile.smethod_15((Control)(object)GroupBox1, "GroupBox1");
					EditProfile.smethod_16((Control)(object)GroupBox1, new Size(486, 178));
					num = (int)((num2 * 1346640658) ^ 0x76EBF688);
					continue;
				case 147u:
					EditProfile.smethod_16((Control)(object)SIDTxt, new Size(91, 26));
					EditProfile.smethod_17((Control)(object)SIDTxt, 12);
					num = (int)(num2 * 1345904348) ^ -1556862998;
					continue;
				case 146u:
					EditProfile.smethod_13((Control)(object)NewPasswdTxt, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -366103883) ^ -1707603307;
					continue;
				case 145u:
					num = ((int)num2 * -1921225135) ^ 0x649FAF01;
					continue;
				case 144u:
					EditProfile.smethod_14((Control)(object)Label3, new Point(269, 146));
					num = ((int)num2 * -189536983) ^ 0x3D17B857;
					continue;
				case 143u:
					num = (int)(num2 * 1593976372) ^ -626596149;
					continue;
				case 142u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)Label6);
					num = (int)((num2 * 807930347) ^ 0x46180FC7);
					continue;
				case 141u:
					EditProfile.smethod_13((Control)(object)Label6, EditProfile.smethod_12("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 794695344) ^ 0x29C8988E);
					continue;
				case 140u:
					num = ((int)num2 * -1856113042) ^ -109146902;
					continue;
				case 139u:
					num = ((int)num2 * -1305016223) ^ -1410214803;
					continue;
				case 138u:
					num = ((int)num2 * -1473075097) ^ -30400152;
					continue;
				case 137u:
					EditProfile.smethod_16((Control)(object)DOBTxt, new Size(128, 26));
					num = (int)((num2 * 1752466150) ^ 0x62DE7019);
					continue;
				case 136u:
					EditProfile.smethod_14((Control)(object)AddressTxt, new Point(135, 269));
					EditProfile.smethod_29(AddressTxt, bool_0: true);
					num = ((int)num2 * -1588809382) ^ 0x24449254;
					continue;
				case 135u:
					EditProfile.smethod_17((Control)(object)Label6, 9);
					EditProfile.smethod_18(Label6, "Address :");
					num = (int)(num2 * 35334236) ^ -449588352;
					continue;
				case 134u:
					EditProfile.smethod_17((Control)(object)Label5, 8);
					num = ((int)num2 * -63069564) ^ 0x403FB94C;
					continue;
				case 133u:
					EditProfile.smethod_18(Label7, "SID :");
					num = (int)((num2 * 1479067593) ^ 0x58DFEE3E);
					continue;
				case 132u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)Label3);
					num = ((int)num2 * -233188363) ^ 0x549A070D;
					continue;
				case 131u:
					EditProfile.smethod_16((Control)(object)Label9, new Size(154, 26));
					EditProfile.smethod_17((Control)(object)Label9, 15);
					num = (int)((num2 * 1175891804) ^ 0x45CCE4D0);
					continue;
				case 130u:
					EditProfile.smethod_27((ButtonBase)(object)CheckBox1, "Show Password");
					num = ((int)num2 * -252801274) ^ -1018314252;
					continue;
				case 129u:
					OldPasswdTxt = EditProfile.smethod_5();
					num = ((int)num2 * -1346692570) ^ -231087566;
					continue;
				case 128u:
					num = (int)((num2 * 1982085647) ^ 0x2199FE9C);
					continue;
				case 127u:
					EditProfile.smethod_19(Label6, (ContentAlignment)32);
					EditProfile.smethod_13((Control)(object)Label5, EditProfile.smethod_12("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -464875252) ^ 0x12D899D8;
					continue;
				case 126u:
					num = ((int)num2 * -753154837) ^ -2011358646;
					continue;
				case 125u:
					EditProfile.smethod_15((Control)(object)NameTxt, "NameTxt");
					num = (int)(num2 * 727254707) ^ -280876815;
					continue;
				case 124u:
					EditProfile.smethod_13((Control)(object)CheckBox1, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1227300211) ^ -1345899039;
					continue;
				case 123u:
					num = (int)((num2 * 1442038246) ^ 0x5E4510EB);
					continue;
				case 122u:
					EditProfile.smethod_16((Control)(object)Label4, new Size(85, 24));
					num = (int)((num2 * 1725685721) ^ 0x409881EE);
					continue;
				case 121u:
					EditProfile.smethod_22(GroupBox2, bool_0: false);
					num = ((int)num2 * -2015928119) ^ -471940045;
					continue;
				case 120u:
					num = (int)((num2 * 578932673) ^ 0x34523DB7);
					continue;
				case 119u:
					num = (int)((num2 * 1876405271) ^ 0x3924E459);
					continue;
				case 118u:
					EditProfile.smethod_30((ButtonBase)(object)CheckBox1, bool_0: true);
					num = (int)((num2 * 368705245) ^ 0x705E3469);
					continue;
				case 117u:
					num = (int)(num2 * 1291463167) ^ -1455481886;
					continue;
				case 116u:
					Label5 = EditProfile.smethod_3();
					num = (int)((num2 * 1165608328) ^ 0x5A738204);
					continue;
				case 115u:
					num = ((int)num2 * -66556522) ^ -1665300054;
					continue;
				case 114u:
					EditProfile.smethod_14((Control)(object)Label5, new Point(31, 211));
					num = ((int)num2 * -1972921299) ^ 0x175C3217;
					continue;
				case 113u:
					EditProfile.smethod_28((ButtonBase)(object)UpdateBtn, bool_0: false);
					num = ((int)num2 * -1963579030) ^ 0x1AF630BF;
					continue;
				case 112u:
					num = ((int)num2 * -553349453) ^ 0x3EFD9047;
					continue;
				case 111u:
					EditProfile.smethod_15((Control)(object)Label5, "Label5");
					num = ((int)num2 * -2055863667) ^ 0x15CB187F;
					continue;
				case 110u:
					EditProfile.smethod_14((Control)(object)NewPasswdTxt, new Point(197, 73));
					num = ((int)num2 * -841295725) ^ 0x47381763;
					continue;
				case 109u:
					EditProfile.smethod_15((Control)(object)GroupBox2, "GroupBox2");
					num = ((int)num2 * -1817176528) ^ 0x755AA120;
					continue;
				case 108u:
					EditProfile.smethod_37((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -193849006) ^ -1167421998;
					continue;
				case 107u:
					num = ((int)num2 * -712306932) ^ 0x5C96A94C;
					continue;
				case 106u:
					EditProfile.smethod_16((Control)(object)Label7, new Size(87, 23));
					num = (int)((num2 * 1859884953) ^ 0x5D20EC0E);
					continue;
				case 105u:
					EditProfile.smethod_16((Control)(object)Label8, new Size(154, 26));
					EditProfile.smethod_17((Control)(object)Label8, 13);
					num = (int)((num2 * 1107937469) ^ 0x521D3E6B);
					continue;
				case 104u:
					EditProfile.smethod_13((Control)(object)Label8, EditProfile.smethod_12("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 428250411) ^ -1709173637;
					continue;
				case 103u:
					EditProfile.smethod_15((Control)(object)Label3, "Label3");
					num = (int)(num2 * 2112408456) ^ -839390869;
					continue;
				case 102u:
					EditProfile.smethod_17((Control)(object)CheckBox1, 15);
					num = (int)(num2 * 1707705187) ^ -51658321;
					continue;
				case 101u:
					EditProfile.smethod_14((Control)(object)CheckBox1, new Point(197, 110));
					num = ((int)num2 * -335584091) ^ 0x60556F0F;
					continue;
				case 100u:
					EditProfile.smethod_13((Control)(object)Label1, EditProfile.smethod_12("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1940704886) ^ 0x59878428;
					continue;
				case 99u:
					EditProfile.smethod_35(PictureBox1, bool_0: false);
					num = ((int)num2 * -1772316219) ^ -922005474;
					continue;
				case 98u:
					num = (int)((num2 * 2007681900) ^ 0x58BC2E9A);
					continue;
				case 97u:
					EditProfile.smethod_42((Control)(object)GroupBox2, bool_0: false);
					num = (int)(num2 * 582092753) ^ -288453814;
					continue;
				case 96u:
					EditProfile.smethod_19(Label1, (ContentAlignment)32);
					num = ((int)num2 * -941925718) ^ 0x6B2EA5FA;
					continue;
				case 95u:
					EditProfile.smethod_24((TextBoxBase)(object)DOBTxt, bool_0: true);
					num = ((int)num2 * -1608655974) ^ -1258773372;
					continue;
				case 94u:
					num = ((int)num2 * -492124846) ^ 0xEC23DB4;
					continue;
				case 93u:
					EditProfile.smethod_13((Control)(object)Label9, EditProfile.smethod_12("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1903788688) ^ 0xFB5D18F;
					continue;
				case 92u:
					num = (int)((num2 * 2036901034) ^ 0x66769BA0);
					continue;
				case 91u:
					num = ((int)num2 * -74900909) ^ 0x4BEE95DF;
					continue;
				case 90u:
					EditProfile.smethod_44((ISupportInitialize)PictureBox1);
					EditProfile.smethod_45((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1572653568) ^ -1533361427;
					continue;
				case 89u:
					num = (int)((num2 * 1859783110) ^ 0x7A4B5FE0);
					continue;
				case 88u:
					Label6 = EditProfile.smethod_3();
					num = (int)((num2 * 597608561) ^ 0x5C718B12);
					continue;
				case 87u:
					EditProfile.smethod_31(OldPasswdTxt, bool_0: true);
					num = ((int)num2 * -1309289272) ^ 0x1AAC27BC;
					continue;
				case 86u:
					EditProfile.smethod_14((Control)(object)Label7, new Point(21, 51));
					num = ((int)num2 * -1959133653) ^ -971085557;
					continue;
				case 85u:
					EditProfile.smethod_14((Control)(object)Label1, new Point(392, 63));
					num = (int)((num2 * 355060117) ^ 0x2C3A2CC1);
					continue;
				case 84u:
					num = ((int)num2 * -938078268) ^ 0x42A5BCAC;
					continue;
				case 83u:
					num = (int)(num2 * 1909728081) ^ -1948507493;
					continue;
				case 82u:
					EditProfile.smethod_26((Control)(object)UpdateBtn, Color.White);
					num = ((int)num2 * -724928549) ^ 0x1F55E2DE;
					continue;
				case 81u:
					NewPasswdTxt = EditProfile.smethod_5();
					num = (int)(num2 * 2143367680) ^ -1935824150;
					continue;
				case 80u:
					EditProfile.smethod_21(EditProfile.smethod_39((Control)(object)this), (Control)(object)GroupBox1);
					num = (int)(num2 * 2040272021) ^ -1369110412;
					continue;
				case 79u:
					EditProfile.smethod_28((ButtonBase)(object)ChangePasswdBtn, bool_0: false);
					num = (int)(num2 * 2031906684) ^ -1435884765;
					continue;
				case 78u:
					EditProfile.smethod_16((Control)(object)CheckBox1, new Size(163, 23));
					num = ((int)num2 * -35624862) ^ -1881952890;
					continue;
				case 77u:
					EditProfile.smethod_13((Control)(object)Label3, EditProfile.smethod_12("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -845821123) ^ 0x1AD530CA;
					continue;
				case 76u:
					EditProfile.smethod_41((Control)(object)this, new Size(977, 804));
					num = ((int)num2 * -1356020873) ^ 0x654F2A32;
					continue;
				case 75u:
					num = (int)((num2 * 1628758242) ^ 0x7E0EFB81);
					continue;
				case 74u:
					EditProfile.smethod_16((Control)(object)PictureBox1, new Size(172, 90));
					EditProfile.smethod_33(PictureBox1, (PictureBoxSizeMode)1);
					num = (int)(num2 * 1179018412) ^ -1697191168;
					continue;
				case 73u:
					CheckBox1 = EditProfile.smethod_7();
					num = ((int)num2 * -1783919305) ^ -52754635;
					continue;
				case 72u:
					EditProfile.smethod_15((Control)(object)OldPasswdTxt, "OldPasswdTxt");
					num = (int)((num2 * 655226456) ^ 0x326C6099);
					continue;
				case 71u:
					PictureBox1 = EditProfile.smethod_8();
					num = (int)(num2 * 135472617) ^ -284757900;
					continue;
				case 70u:
					EditProfile.smethod_17((Control)(object)Label1, 6);
					num = (int)(num2 * 1351951324) ^ -416185905;
					continue;
				case 69u:
					EditProfile.smethod_25((ButtonBase)(object)UpdateBtn, Color.MidnightBlue);
					num = ((int)num2 * -206748760) ^ 0x728A10B7;
					continue;
				case 68u:
					num = (int)(num2 * 778085451) ^ -1882184160;
					continue;
				case 67u:
					EditProfile.smethod_15((Control)(object)UpdateBtn, "UpdateBtn");
					EditProfile.smethod_16((Control)(object)UpdateBtn, new Size(133, 37));
					num = (int)((num2 * 451082513) ^ 0x3D8CFF2D);
					continue;
				case 66u:
					EditProfile.smethod_14((Control)(object)Label6, new Point(31, 269));
					num = (int)(num2 * 2020406873) ^ -1323928884;
					continue;
				case 65u:
					num = ((int)num2 * -611309347) ^ 0x24C1FA33;
					continue;
				case 64u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)UpdateBtn);
					num = ((int)num2 * -1959938754) ^ -1192617727;
					continue;
				case 63u:
					EditProfile.smethod_32(PictureBox1, (Image)(object)Resources.patient_pic);
					num = ((int)num2 * -1190462488) ^ -1717710772;
					continue;
				case 62u:
					EditProfile.smethod_19(Label9, (ContentAlignment)32);
					num = ((int)num2 * -497787415) ^ -1453983017;
					continue;
				case 61u:
					num = (int)((num2 * 873699870) ^ 0x6EE5EA81);
					continue;
				case 60u:
					EditProfile.smethod_18(Label1, "Edit Profile");
					num = (int)(num2 * 808380127) ^ -1266663066;
					continue;
				case 59u:
					EditProfile.smethod_42((Control)(object)GroupBox1, bool_0: false);
					EditProfile.smethod_43((Control)(object)GroupBox1);
					num = (int)(num2 * 261423999) ^ -348406678;
					continue;
				case 58u:
					num = ((int)num2 * -2062825382) ^ 0x7D82F7E2;
					continue;
				case 57u:
					EditProfile.smethod_14((Control)(object)Label8, new Point(21, 32));
					num = ((int)num2 * -83877649) ^ 0x43005E7B;
					continue;
				case 56u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)GenderTxt);
					num = ((int)num2 * -449453206) ^ -1451210826;
					continue;
				case 55u:
					num = ((int)num2 * -2141315454) ^ -190587412;
					continue;
				case 54u:
					EditProfile.smethod_24((TextBoxBase)(object)NameTxt, bool_0: true);
					num = ((int)num2 * -559787081) ^ -1685799724;
					continue;
				case 53u:
					GroupBox1 = EditProfile.smethod_4();
					num = ((int)num2 * -911110442) ^ -86142412;
					continue;
				case 52u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)NameTxt);
					num = ((int)num2 * -313908108) ^ -993319305;
					continue;
				case 51u:
					EditProfile.smethod_14((Control)(object)PictureBox1, new Point(281, 42));
					EditProfile.smethod_15((Control)(object)PictureBox1, "PictureBox1");
					num = ((int)num2 * -2132807877) ^ 0x5E31ED51;
					continue;
				case 50u:
					num = (int)(num2 * 1455644574) ^ -226149128;
					continue;
				case 49u:
					num = (int)((num2 * 856806256) ^ 0x61359831);
					continue;
				case 48u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)DOBTxt);
					num = ((int)num2 * -1079762366) ^ -393048499;
					continue;
				case 47u:
					num = (int)(num2 * 98048793) ^ -256978104;
					continue;
				case 46u:
					EditProfile.smethod_13((Control)(object)SIDTxt, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1623360476) ^ -1361191498;
					continue;
				case 45u:
					EditProfile.smethod_22(GroupBox1, bool_0: false);
					num = (int)((num2 * 778915204) ^ 0x1C993BA6);
					continue;
				case 44u:
					EditProfile.smethod_9((Control)(object)GroupBox1);
					num = (int)((num2 * 714336066) ^ 0x51F387C0);
					continue;
				case 43u:
					num = ((int)num2 * -2116854842) ^ 0x11E018DD;
					continue;
				case 42u:
					MobileTxt = EditProfile.smethod_5();
					num = (int)((num2 * 446351868) ^ 0xB17AE62);
					continue;
				case 41u:
					DOBTxt = EditProfile.smethod_5();
					num = (int)((num2 * 293153249) ^ 0x563ED8B5);
					continue;
				case 40u:
					num = (int)((num2 * 823159941) ^ 0x449D9497);
					continue;
				case 39u:
					EditProfile.smethod_13((Control)(object)Label7, EditProfile.smethod_12("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1992580199) ^ -1729112111;
					continue;
				case 38u:
					EditProfile.smethod_17((Control)(object)GroupBox1, 16);
					num = ((int)num2 * -2093398778) ^ -844802181;
					continue;
				case 37u:
					num = ((int)num2 * -1382159476) ^ 0x3543D8B0;
					continue;
				case 36u:
					EditProfile.smethod_31(NewPasswdTxt, bool_0: true);
					num = (int)((num2 * 1463937689) ^ 0x388CE88B);
					continue;
				case 35u:
					Label2 = EditProfile.smethod_3();
					num = (int)(num2 * 560935423) ^ -2121485470;
					continue;
				case 34u:
					num = ((int)num2 * -473277131) ^ 0x208FCA9F;
					continue;
				case 33u:
					num = (int)(num2 * 1991474667) ^ -867523192;
					continue;
				case 32u:
					NameTxt = EditProfile.smethod_5();
					num = (int)(num2 * 886162917) ^ -1410478797;
					continue;
				case 31u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)Label5);
					num = ((int)num2 * -1929325677) ^ 0x2CFF06AC;
					continue;
				case 30u:
					EditProfile.smethod_25((ButtonBase)(object)ChangePasswdBtn, Color.MidnightBlue);
					num = (int)(num2 * 1454920112) ^ -1653053229;
					continue;
				case 29u:
					num = (int)((num2 * 556004010) ^ 0x600FAC4);
					continue;
				case 28u:
					num = (int)((num2 * 486869055) ^ 0x4F5A6792);
					continue;
				case 27u:
					num = (int)(num2 * 1337443840) ^ -1034669576;
					continue;
				case 26u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox1), (Control)(object)NewPasswdTxt);
					num = ((int)num2 * -138808725) ^ -1584338661;
					continue;
				case 25u:
					EditProfile.smethod_16((Control)(object)ChangePasswdBtn, new Size(172, 37));
					num = (int)(num2 * 1736980581) ^ -1864266022;
					continue;
				case 24u:
					EditProfile.smethod_14((Control)(object)NameTxt, new Point(135, 98));
					num = (int)((num2 * 561625454) ^ 0x139E3803);
					continue;
				case 23u:
					Label9 = EditProfile.smethod_3();
					num = ((int)num2 * -1972909650) ^ -353653405;
					continue;
				case 22u:
					EditProfile.smethod_23(GroupBox1, "Change Password");
					num = (int)(num2 * 1486861381) ^ -741569934;
					continue;
				case 21u:
					EditProfile.smethod_17((Control)(object)GroupBox2, 8);
					num = ((int)num2 * -1719427993) ^ -856133852;
					continue;
				case 20u:
					num = ((int)num2 * -1973986102) ^ -956051727;
					continue;
				case 19u:
					num = ((int)num2 * -797176543) ^ 0x4BFAD68C;
					continue;
				case 18u:
					num = (int)((num2 * 1871168784) ^ 0x6C85D5A2);
					continue;
				case 17u:
					EditProfile.smethod_10((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -814996341) ^ 0x1BCC2344;
					continue;
				case 16u:
					EditProfile.smethod_17((Control)(object)Label2, 5);
					num = (int)(num2 * 632531107) ^ -108468579;
					continue;
				case 15u:
					EditProfile.smethod_13((Control)(object)AddressTxt, EditProfile.smethod_12("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 548055175) ^ 0x3EFF6EB0);
					continue;
				case 14u:
					EditProfile.smethod_14((Control)(object)UpdateBtn, new Point(311, 372));
					num = (int)(num2 * 210768290) ^ -1023415284;
					continue;
				case 13u:
					num = (int)(num2 * 1507316282) ^ -640531260;
					continue;
				case 12u:
					EditProfile.smethod_21(EditProfile.smethod_20((Control)(object)GroupBox2), (Control)(object)Label4);
					num = ((int)num2 * -1982630432) ^ 0x2A1B4DF0;
					continue;
				case 11u:
					EditProfile.smethod_18(Label8, "Old Password :");
					EditProfile.smethod_19(Label8, (ContentAlignment)32);
					num = (int)(num2 * 1103055632) ^ -88883913;
					continue;
				case 10u:
					EditProfile.smethod_14((Control)(object)MobileTxt, new Point(135, 211));
					num = ((int)num2 * -1674502770) ^ 0x781122EA;
					continue;
				case 9u:
					num = ((int)num2 * -1181839778) ^ 0x166A59BA;
					continue;
				case 8u:
					EditProfile.smethod_19(Label2, (ContentAlignment)32);
					num = (int)(num2 * 220739973) ^ -459575390;
					continue;
				case 7u:
					EditProfile.smethod_13((Control)(object)GroupBox2, EditProfile.smethod_12("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 206644527) ^ 0x23D09274);
					continue;
				case 6u:
					EditProfile.smethod_23(GroupBox2, "Personal Information");
					num = (int)(num2 * 1195118790) ^ -1855349371;
					continue;
				case 5u:
					num = ((int)num2 * -1760525188) ^ -409085080;
					continue;
				case 4u:
					EditProfile.smethod_15((Control)(object)Label7, "Label7");
					num = (int)((num2 * 1533059446) ^ 0x41DDBDC1);
					continue;
				case 3u:
					num = (int)(num2 * 1982670176) ^ -1893657380;
					continue;
				case 2u:
					num = ((int)num2 * -1724940046) ^ 0x357444E3;
					continue;
				case 1u:
					Label8 = EditProfile.smethod_3();
					num = ((int)num2 * -1903030413) ^ -430631970;
					continue;
				case 0u:
					EditProfile.smethod_13((Control)(object)Label2, EditProfile.smethod_12("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					EditProfile.smethod_14((Control)(object)Label2, new Point(17, 98));
					EditProfile.smethod_15((Control)(object)Label2, "Label2");
					num = (int)(num2 * 664005328) ^ -408655473;
					continue;
				default:
					return;
				case 166u:
					break;
				case 185u:
					return;
				}
				break;
			}
		}
	}

	private void EditProfile_Load(object sender, EventArgs e)
	{
		OleDbDataReader oleDbDataReader_ = default(OleDbDataReader);
		bool flag = default(bool);
		while (true)
		{
			int num = -524137013;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA490210Du) % 4u)
				{
				case 3u:
					num = (int)((num2 * 1872107133) ^ 0xD52865B);
					continue;
				case 2u:
					EditProfile.smethod_51(myconnection, EditProfile.smethod_50(MyProject.Forms.Form1.provider, MyProject.Forms.Form1.datafile));
					num = (int)(num2 * 1114727570) ^ -1426757322;
					continue;
				case 0u:
					break;
				default:
				{
					OleDbCommand oleDbCommand_ = EditProfile.smethod_52();
					string string_ = EditProfile.smethod_53("Select * From [Staff] Where [Username] = '", MyProject.Forms.Form1.username, "';");
					EditProfile.smethod_54(myconnection);
					try
					{
						while (true)
						{
							int num3 = -754630761;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xA490210Du) % 18u)
								{
								case 17u:
									num3 = (int)((num2 * 1608173837) ^ 0xC037E86);
									continue;
								case 15u:
									password = EditProfile.smethod_58(EditProfile.smethod_57(oleDbDataReader_, 9));
									num3 = ((int)num2 * -2063605143) ^ -1614604207;
									continue;
								case 14u:
									oleDbCommand_ = EditProfile.smethod_55(string_, myconnection);
									num3 = (int)((num2 * 2018339916) ^ 0x5DA0E4BA);
									continue;
								case 13u:
									EditProfile.smethod_59(NameTxt, EditProfile.smethod_58(EditProfile.smethod_57(oleDbDataReader_, 1)));
									num3 = (int)(num2 * 1259093243) ^ -863014399;
									continue;
								case 12u:
									EditProfile.smethod_59(SIDTxt, EditProfile.smethod_58(EditProfile.smethod_57(oleDbDataReader_, 0)));
									num3 = -898711646;
									continue;
								case 11u:
									oleDbDataReader_ = EditProfile.smethod_56(oleDbCommand_);
									num3 = ((int)num2 * -150715438) ^ -1939588931;
									continue;
								case 10u:
									num3 = (int)((num2 * 1610727626) ^ 0x57425FF2);
									continue;
								case 9u:
									EditProfile.smethod_59(GenderTxt, EditProfile.smethod_58(EditProfile.smethod_57(oleDbDataReader_, 4)));
									num3 = (int)(num2 * 2125026773) ^ -764752357;
									continue;
								case 8u:
									EditProfile.smethod_59(AddressTxt, EditProfile.smethod_58(EditProfile.smethod_57(oleDbDataReader_, 6)));
									num3 = ((int)num2 * -172363177) ^ -212784445;
									continue;
								case 7u:
									EditProfile.smethod_61(myconnection);
									num3 = ((int)num2 * -1623520652) ^ 0x1106DFCD;
									continue;
								case 5u:
									EditProfile.smethod_59(DOBTxt, EditProfile.smethod_58(EditProfile.smethod_57(oleDbDataReader_, 3)));
									num3 = (int)(num2 * 1585080118) ^ -832682582;
									continue;
								case 4u:
									EditProfile.smethod_59(MobileTxt, EditProfile.smethod_58(EditProfile.smethod_57(oleDbDataReader_, 5)));
									num3 = ((int)num2 * -1952062743) ^ 0x39585A69;
									continue;
								case 3u:
									primary_key = EditProfile.smethod_58(EditProfile.smethod_57(oleDbDataReader_, 0));
									num3 = ((int)num2 * -757184895) ^ -1808308089;
									continue;
								case 2u:
									num3 = ((int)num2 * -1504087156) ^ -174102280;
									continue;
								case 1u:
									flag = EditProfile.smethod_60(oleDbDataReader_);
									num3 = -2052861079;
									continue;
								case 0u:
								{
									int num4;
									int num5;
									if (!flag)
									{
										num4 = -1989704938;
										num5 = -1989704938;
									}
									else
									{
										num4 = -1826335815;
										num5 = -1826335815;
									}
									num3 = num4 ^ ((int)num2 * -2102191088);
									continue;
								}
								default:
									return;
								case 16u:
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
						EditProfile.smethod_62(exception_);
						EditProfile.smethod_61(myconnection);
						EditProfile.smethod_63();
						return;
					}
				}
				}
				break;
			}
		}
	}

	private void UpdateBtn_Click(object sender, EventArgs e)
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected I4, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected I4, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Incompatible stack heights: 0 vs 1
		//IL_0231: Incompatible stack heights: 0 vs 1
		//IL_0238: Incompatible stack heights: 0 vs 1
		bool flag = !MyProject.Forms.Form1.Mobile_Validator(EditProfile.smethod_65(EditProfile.smethod_64(MobileTxt))) | (EditProfile.smethod_66(EditProfile.smethod_64(AddressTxt), "", bool_0: false) == 0);
		string string_ = default(string);
		while (true)
		{
			int num = -2112841807;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9422DD87u) % 7u)
				{
				case 6u:
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
					num = (int)((num2 * 1683116223) ^ 0x2001078E);
					continue;
				case 5u:
				{
					OleDbCommand val = EditProfile.smethod_52();
					num = -1099487941;
					continue;
				}
				case 4u:
					EditProfile.smethod_67("Incorrect Credentials");
					num = ((int)num2 * -452229887) ^ 0x6282467A;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -657446184;
						num5 = -657446184;
					}
					else
					{
						num4 = -1109604289;
						num5 = -1109604289;
					}
					num = num4 ^ (int)(num2 * 1714903321);
					continue;
				}
				case 0u:
					break;
				default:
					EditProfile.smethod_54(myconnection);
					try
					{
						OleDbCommand val = EditProfile.smethod_55(string_, myconnection);
						EditProfile.smethod_69(val);
						while (true)
						{
							int num3 = -1207997948;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x9422DD87u) % 6u)
								{
								case 5u:
									num3 = ((int)num2 * -1856145596) ^ -263584343;
									continue;
								case 4u:
									EditProfile.smethod_61(myconnection);
									num3 = ((int)num2 * -1889895414) ^ 0x4F5D7047;
									continue;
								case 3u:
									EditProfile.smethod_70((Component)(object)val);
									num3 = (int)(num2 * 99822480) ^ -1267882584;
									continue;
								case 2u:
									num3 = (int)(num2 * 1769293924) ^ -1213442988;
									continue;
								case 0u:
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
							_ = -57120394;
							while (true)
							{
								_003F val2 = /*Error near IL_01e0: Stack underflow*/^ -1809654393;
								num2 = (uint)(int)val2;
								switch (val2 % 4)
								{
								case 2:
									EditProfile.smethod_67(EditProfile.smethod_71(exception_));
									_ = ((int)num2 * -1926579835) ^ 0x76932391;
									continue;
								case 1:
									EditProfile.smethod_61(myconnection);
									_ = ((int)num2 * -252287719) ^ 0x323F0754;
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
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void ChangePasswdBtn_Click(object sender, EventArgs e)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected I4, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected I4, but got Unknown
		//IL_0294: Incompatible stack heights: 0 vs 1
		//IL_02a9: Incompatible stack heights: 0 vs 1
		//IL_02c4: Incompatible stack heights: 0 vs 1
		//IL_02cb: Incompatible stack heights: 0 vs 1
		if (EditProfile.smethod_66(EditProfile.smethod_64(OldPasswdTxt), password, bool_0: false) != 0)
		{
			goto IL_00ac;
		}
		goto IL_0110;
		IL_0110:
		int num = 326767551;
		goto IL_00d9;
		IL_00d9:
		string string_ = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x14B594F7u) % 9u)
			{
			case 8u:
				string_ = EditProfile.smethod_68(new string[5]
				{
					"Update [Staff] Set [Password] = '",
					EditProfile.smethod_64(NewPasswdTxt),
					"' Where [SID] = ",
					primary_key,
					";"
				});
				num = ((int)num2 * -1349256209) ^ 0x47BBBA1B;
				continue;
			case 7u:
			{
				int num4;
				int num5;
				if (EditProfile.smethod_66(EditProfile.smethod_64(NewPasswdTxt), "", bool_0: false) == 0)
				{
					num4 = 2125335170;
					num5 = 2125335170;
				}
				else
				{
					num4 = 585784929;
					num5 = 585784929;
				}
				num = num4 ^ (int)(num2 * 1892273424);
				continue;
			}
			case 4u:
				break;
			case 3u:
			{
				OleDbCommand val = EditProfile.smethod_52();
				num = 227939913;
				continue;
			}
			case 1u:
				EditProfile.smethod_67("Invalid Old Password");
				num = ((int)num2 * -1290230270) ^ 0x839B8BB;
				continue;
			case 6u:
				goto IL_0110;
			case 2u:
				EditProfile.smethod_67("Password cannot be empty field");
				return;
			default:
				EditProfile.smethod_54(myconnection);
				try
				{
					while (true)
					{
						int num3 = 1316264471;
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0x14B594F7u) % 10u)
							{
							case 9u:
								num3 = ((int)num2 * -1023829555) ^ -1786318988;
								continue;
							case 8u:
								EditProfile.smethod_61(myconnection);
								num3 = (int)((num2 * 181259214) ^ 0x7544F953);
								continue;
							case 6u:
							{
								OleDbCommand val = EditProfile.smethod_55(string_, myconnection);
								EditProfile.smethod_69(val);
								EditProfile.smethod_70((Component)(object)val);
								num3 = (int)((num2 * 240388709) ^ 0x7E89DD6E);
								continue;
							}
							case 5u:
								password = EditProfile.smethod_64(NewPasswdTxt);
								num3 = ((int)num2 * -1058790717) ^ 0x6EB3A1E5;
								continue;
							case 4u:
								num3 = ((int)num2 * -1420834309) ^ -2047911342;
								continue;
							case 3u:
								num3 = ((int)num2 * -927913934) ^ -1992113827;
								continue;
							case 2u:
								EditProfile.smethod_72((TextBoxBase)(object)NewPasswdTxt);
								num3 = ((int)num2 * -623885697) ^ 0x4A03ADC5;
								continue;
							case 1u:
								EditProfile.smethod_72((TextBoxBase)(object)OldPasswdTxt);
								num3 = (int)((num2 * 201374346) ^ 0x21871BD6);
								continue;
							case 7u:
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
						_ = 866636247;
						while (true)
						{
							_003F val2 = /*Error near IL_0266: Stack underflow*/^ 0x14B594F7;
							num2 = (uint)(int)val2;
							switch (val2 % 5)
							{
							default:
								return;
							case 3:
								_ = (num2 * 1583409068) ^ 0x61C30590;
								continue;
							case 1:
								EditProfile.smethod_63();
								_ = ((int)num2 * -2027246836) ^ -1010690032;
								continue;
							case 0:
								EditProfile.smethod_61(myconnection);
								_ = ((int)num2 * -1213310770) ^ -812086765;
								continue;
							case 4:
								break;
							case 2:
								return;
							}
							break;
						}
					}
				}
			case 0u:
				return;
			}
			break;
		}
		goto IL_00ac;
		IL_00ac:
		num = 1461341567;
		goto IL_00d9;
	}

	private void CheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 1699175805;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x41F7F066u) % 14u)
				{
				case 13u:
					num = ((int)num2 * -884677353) ^ 0x6F6180D5;
					continue;
				case 11u:
					EditProfile.smethod_31(NewPasswdTxt, bool_0: true);
					num = ((int)num2 * -1544498069) ^ 0x5D5C3586;
					continue;
				case 10u:
					EditProfile.smethod_31(OldPasswdTxt, bool_0: true);
					num = ((int)num2 * -1422045341) ^ -669528823;
					continue;
				case 9u:
					num = 1331679270;
					continue;
				case 8u:
					EditProfile.smethod_31(OldPasswdTxt, bool_0: false);
					num = (int)(num2 * 1285043538) ^ -267610870;
					continue;
				case 7u:
					num = (int)((num2 * 1536347301) ^ 0x6EAF2BA2);
					continue;
				case 5u:
					num = ((int)num2 * -551780743) ^ 0x1A41A48B;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -289468558;
						num4 = -289468558;
					}
					else
					{
						num3 = -107919569;
						num4 = -107919569;
					}
					num = num3 ^ ((int)num2 * -1687420388);
					continue;
				}
				case 3u:
					num = ((int)num2 * -703107194) ^ -1780966973;
					continue;
				case 2u:
					EditProfile.smethod_31(NewPasswdTxt, bool_0: false);
					num = (int)((num2 * 1773204957) ^ 0x23FD983B);
					continue;
				case 1u:
					flag = EditProfile.smethod_73(OldPasswdTxt);
					num = (int)((num2 * 992157273) ^ 0x2370F231);
					continue;
				case 0u:
					num = ((int)num2 * -1638796223) ^ -679416560;
					continue;
				default:
					return;
				case 12u:
					break;
				case 6u:
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
