using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hospital_Management_System.My;
using Hospital_Management_System.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace Hospital_Management_System;

[DesignerGenerated]
public class Form2 : Form
{
	private IContainer components;

	public string PID_Value;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("StaffPanel")]
	internal virtual Panel StaffPanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox5")]
	internal virtual GroupBox GroupBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button LogoutBtn
	{
		[CompilerGenerated]
		get
		{
			return _LogoutBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = LogoutBtn_Click;
			Button logoutBtn = _LogoutBtn;
			if (logoutBtn != null)
			{
				goto IL_006c;
			}
			goto IL_009a;
			IL_009a:
			_LogoutBtn = value;
			logoutBtn = _LogoutBtn;
			int num = 1000293589;
			goto IL_0071;
			IL_0071:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x35001060u) % 6u)
				{
				case 4u:
					Form2.smethod_52((Control)(object)logoutBtn, eventHandler_);
					num = ((int)num2 * -1857751589) ^ -2135635183;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (logoutBtn != null)
					{
						num3 = 665357325;
						num4 = 665357325;
					}
					else
					{
						num3 = 1127979332;
						num4 = 1127979332;
					}
					num = num3 ^ ((int)num2 * -287407149);
					continue;
				}
				case 2u:
					Form2.smethod_53((Control)(object)logoutBtn, eventHandler_);
					num = ((int)num2 * -2093152980) ^ -1903096781;
					continue;
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_009a;
				case 5u:
					return;
				}
				break;
			}
			goto IL_006c;
			IL_006c:
			num = 256872252;
			goto IL_0071;
		}
	}

	internal virtual Button EditProfileBtn
	{
		[CompilerGenerated]
		get
		{
			return _EditProfileBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = EditProfileBtn_Click;
			Button editProfileBtn = default(Button);
			while (true)
			{
				int num = 2008798320;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA57660Au) % 8u)
					{
					case 7u:
						Form2.smethod_53((Control)(object)editProfileBtn, eventHandler_);
						num = ((int)num2 * -716776778) ^ 0x4D0C84F5;
						continue;
					case 6u:
					{
						editProfileBtn = _EditProfileBtn;
						int num5;
						int num6;
						if (editProfileBtn != null)
						{
							num5 = -1047981353;
							num6 = -1047981353;
						}
						else
						{
							num5 = -2053790307;
							num6 = -2053790307;
						}
						num = num5 ^ ((int)num2 * -527263037);
						continue;
					}
					case 4u:
						Form2.smethod_52((Control)(object)editProfileBtn, eventHandler_);
						num = (int)((num2 * 2061885465) ^ 0x7F4837BE);
						continue;
					case 2u:
						editProfileBtn = _EditProfileBtn;
						num = ((int)num2 * -1297676129) ^ -2107514699;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (editProfileBtn == null)
						{
							num3 = 1014049095;
							num4 = 1014049095;
						}
						else
						{
							num3 = 887729107;
							num4 = 887729107;
						}
						num = num3 ^ ((int)num2 * -728319467);
						continue;
					}
					case 0u:
						_EditProfileBtn = value;
						num = 1221635388;
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

	[field: AccessedThroughProperty("PersonalInfoPanel2")]
	internal virtual Panel PersonalInfoPanel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PersonalInfoPanel1")]
	internal virtual Panel PersonalInfoPanel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox3")]
	internal virtual GroupBox GroupBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button AvailabilityBtn
	{
		[CompilerGenerated]
		get
		{
			return _AvailabilityBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = AvailabilityBtn_Click;
			Button availabilityBtn = _AvailabilityBtn;
			while (true)
			{
				int num = 577316878;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1F72F1F8u) % 7u)
					{
					case 6u:
						_AvailabilityBtn = value;
						availabilityBtn = _AvailabilityBtn;
						num = 1927403538;
						continue;
					case 5u:
						Form2.smethod_53((Control)(object)availabilityBtn, eventHandler_);
						num = ((int)num2 * -1095559972) ^ -1856067540;
						continue;
					case 4u:
					{
						int num5;
						int num6;
						if (availabilityBtn != null)
						{
							num5 = 177004390;
							num6 = 177004390;
						}
						else
						{
							num5 = 617377549;
							num6 = 617377549;
						}
						num = num5 ^ ((int)num2 * -1153777743);
						continue;
					}
					case 3u:
					{
						int num3;
						int num4;
						if (availabilityBtn != null)
						{
							num3 = -971550551;
							num4 = -971550551;
						}
						else
						{
							num3 = -1702979284;
							num4 = -1702979284;
						}
						num = num3 ^ (int)(num2 * 760709150);
						continue;
					}
					case 2u:
						Form2.smethod_52((Control)(object)availabilityBtn, eventHandler_);
						num = ((int)num2 * -1044369893) ^ 0x6E8A2D43;
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

	[field: AccessedThroughProperty("StaffPanel2")]
	internal virtual Panel StaffPanel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("StaffPanel1")]
	internal virtual Panel StaffPanel1
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

	internal virtual Button CheckUpBtn
	{
		[CompilerGenerated]
		get
		{
			return _CheckUpBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = CheckUpBtn_Click;
			Button checkUpBtn = default(Button);
			while (true)
			{
				int num = -301796049;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC9C3CBDAu) % 7u)
					{
					case 6u:
						_CheckUpBtn = value;
						checkUpBtn = _CheckUpBtn;
						num = -118405109;
						continue;
					case 5u:
						Form2.smethod_52((Control)(object)checkUpBtn, eventHandler_);
						num = (int)((num2 * 603147533) ^ 0x7A085E63);
						continue;
					case 2u:
						Form2.smethod_53((Control)(object)checkUpBtn, eventHandler_);
						num = (int)(num2 * 644077930) ^ -851134623;
						continue;
					case 1u:
					{
						checkUpBtn = _CheckUpBtn;
						int num5;
						int num6;
						if (checkUpBtn != null)
						{
							num5 = 619274950;
							num6 = 619274950;
						}
						else
						{
							num5 = 921434095;
							num6 = 921434095;
						}
						num = num5 ^ ((int)num2 * -1095120944);
						continue;
					}
					case 0u:
					{
						int num3;
						int num4;
						if (checkUpBtn != null)
						{
							num3 = 1492331048;
							num4 = 1492331048;
						}
						else
						{
							num3 = 235269721;
							num4 = 235269721;
						}
						num = num3 ^ (int)(num2 * 1972717924);
						continue;
					}
					default:
						return;
					case 3u:
						break;
					case 4u:
						return;
					}
					break;
				}
			}
		}
	}

	internal virtual Button UpdateDetailsBtn
	{
		[CompilerGenerated]
		get
		{
			return _UpdateDetailsBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = UpdateDetailsBtn_Click;
			Button updateDetailsBtn = _UpdateDetailsBtn;
			while (true)
			{
				int num = 355617497;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x55792780u) % 8u)
					{
					case 7u:
						updateDetailsBtn = _UpdateDetailsBtn;
						num = ((int)num2 * -1371580663) ^ 0x5A39740A;
						continue;
					case 5u:
					{
						int num5;
						int num6;
						if (updateDetailsBtn != null)
						{
							num5 = 1707122789;
							num6 = 1707122789;
						}
						else
						{
							num5 = 526659027;
							num6 = 526659027;
						}
						num = num5 ^ ((int)num2 * -719743413);
						continue;
					}
					case 3u:
						Form2.smethod_52((Control)(object)updateDetailsBtn, eventHandler_);
						num = ((int)num2 * -328825876) ^ 0x4E937B04;
						continue;
					case 2u:
						Form2.smethod_53((Control)(object)updateDetailsBtn, eventHandler_);
						num = (int)((num2 * 2079953408) ^ 0x2C719454);
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (updateDetailsBtn != null)
						{
							num3 = 993436546;
							num4 = 993436546;
						}
						else
						{
							num3 = 1062826169;
							num4 = 1062826169;
						}
						num = num3 ^ (int)(num2 * 727324161);
						continue;
					}
					case 0u:
						_UpdateDetailsBtn = value;
						num = 572299527;
						continue;
					default:
						return;
					case 6u:
						break;
					case 4u:
						return;
					}
					break;
				}
			}
		}
	}

	internal virtual Button AdmitBtn
	{
		[CompilerGenerated]
		get
		{
			return _AdmitBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = AdmitBtn_Click;
			Button admitBtn = default(Button);
			while (true)
			{
				int num = -2102928288;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE9DCB941u) % 7u)
					{
					case 6u:
					{
						admitBtn = _AdmitBtn;
						int num5;
						int num6;
						if (admitBtn != null)
						{
							num5 = 1620558552;
							num6 = 1620558552;
						}
						else
						{
							num5 = 1358157967;
							num6 = 1358157967;
						}
						num = num5 ^ ((int)num2 * -1999288795);
						continue;
					}
					case 5u:
						Form2.smethod_53((Control)(object)admitBtn, eventHandler_);
						num = (int)(num2 * 831117591) ^ -1145323572;
						continue;
					case 4u:
						_AdmitBtn = value;
						admitBtn = _AdmitBtn;
						num = -181483089;
						continue;
					case 2u:
						Form2.smethod_52((Control)(object)admitBtn, eventHandler_);
						num = ((int)num2 * -605805264) ^ 0x383FA60A;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (admitBtn == null)
						{
							num3 = 853139158;
							num4 = 853139158;
						}
						else
						{
							num3 = 1176254523;
							num4 = 1176254523;
						}
						num = num3 ^ ((int)num2 * -1775273533);
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

	internal virtual Button RegistrationBtn
	{
		[CompilerGenerated]
		get
		{
			return _RegistrationBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = RegistrationBtn_Click;
			Button registrationBtn = _RegistrationBtn;
			if (registrationBtn != null)
			{
				goto IL_006c;
			}
			goto IL_009a;
			IL_009a:
			_RegistrationBtn = value;
			registrationBtn = _RegistrationBtn;
			int num = -1136952509;
			goto IL_0071;
			IL_0071:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC911AB4Fu) % 6u)
				{
				case 5u:
					Form2.smethod_53((Control)(object)registrationBtn, eventHandler_);
					num = ((int)num2 * -1411883621) ^ 0x54E775A4;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (registrationBtn == null)
					{
						num3 = -2055790961;
						num4 = -2055790961;
					}
					else
					{
						num3 = -1340791434;
						num4 = -1340791434;
					}
					num = num3 ^ (int)(num2 * 736189879);
					continue;
				}
				case 1u:
					Form2.smethod_52((Control)(object)registrationBtn, eventHandler_);
					num = ((int)num2 * -1534756524) ^ -617318712;
					continue;
				case 0u:
					break;
				default:
					return;
				case 3u:
					goto IL_009a;
				case 2u:
					return;
				}
				break;
			}
			goto IL_006c;
			IL_006c:
			num = -1215627246;
			goto IL_0071;
		}
	}

	[field: AccessedThroughProperty("PatientPanel2")]
	internal virtual Panel PatientPanel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PatientPanel1")]
	internal virtual Panel PatientPanel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox4")]
	internal virtual GroupBox GroupBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button BloodAvailabilityBtn
	{
		[CompilerGenerated]
		get
		{
			return _BloodAvailabilityBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = BloodAvailabilityBtn_Click;
			Button bloodAvailabilityBtn = default(Button);
			while (true)
			{
				int num = -1180709384;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9D49CFD9u) % 8u)
					{
					case 6u:
						bloodAvailabilityBtn = _BloodAvailabilityBtn;
						num = (int)(num2 * 1720507732) ^ -1626790347;
						continue;
					case 4u:
					{
						int num5;
						int num6;
						if (bloodAvailabilityBtn == null)
						{
							num5 = -1647745752;
							num6 = -1647745752;
						}
						else
						{
							num5 = -1809944218;
							num6 = -1809944218;
						}
						num = num5 ^ ((int)num2 * -1908856675);
						continue;
					}
					case 3u:
						Form2.smethod_53((Control)(object)bloodAvailabilityBtn, eventHandler_);
						num = (int)(num2 * 803923252) ^ -1318569744;
						continue;
					case 2u:
						Form2.smethod_52((Control)(object)bloodAvailabilityBtn, eventHandler_);
						num = ((int)num2 * -2108559707) ^ -2048104829;
						continue;
					case 1u:
					{
						bloodAvailabilityBtn = _BloodAvailabilityBtn;
						int num3;
						int num4;
						if (bloodAvailabilityBtn != null)
						{
							num3 = 1143187643;
							num4 = 1143187643;
						}
						else
						{
							num3 = 476967481;
							num4 = 476967481;
						}
						num = num3 ^ ((int)num2 * -907254888);
						continue;
					}
					case 0u:
						_BloodAvailabilityBtn = value;
						num = -141194505;
						continue;
					default:
						return;
					case 7u:
						break;
					case 5u:
						return;
					}
					break;
				}
			}
		}
	}

	internal virtual Button RegisterRecieverBtn
	{
		[CompilerGenerated]
		get
		{
			return _RegisterRecieverBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = RegisterRecieverBtn_Click;
			Button registerRecieverBtn = default(Button);
			while (true)
			{
				int num = -1606452327;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA22E2D7Eu) % 7u)
					{
					case 5u:
						_RegisterRecieverBtn = value;
						registerRecieverBtn = _RegisterRecieverBtn;
						num = -1194573963;
						continue;
					case 4u:
						Form2.smethod_52((Control)(object)registerRecieverBtn, eventHandler_);
						num = ((int)num2 * -339395317) ^ -2079206382;
						continue;
					case 2u:
					{
						registerRecieverBtn = _RegisterRecieverBtn;
						int num5;
						int num6;
						if (registerRecieverBtn != null)
						{
							num5 = 1723340150;
							num6 = 1723340150;
						}
						else
						{
							num5 = 1784437262;
							num6 = 1784437262;
						}
						num = num5 ^ ((int)num2 * -286671946);
						continue;
					}
					case 1u:
					{
						int num3;
						int num4;
						if (registerRecieverBtn == null)
						{
							num3 = 1744855652;
							num4 = 1744855652;
						}
						else
						{
							num3 = 840812093;
							num4 = 840812093;
						}
						num = num3 ^ (int)(num2 * 406718580);
						continue;
					}
					case 0u:
						Form2.smethod_53((Control)(object)registerRecieverBtn, eventHandler_);
						num = ((int)num2 * -204207148) ^ 0x1FA359B4;
						continue;
					default:
						return;
					case 6u:
						break;
					case 3u:
						return;
					}
					break;
				}
			}
		}
	}

	internal virtual Button RegisterDonorBtn
	{
		[CompilerGenerated]
		get
		{
			return _RegisterDonorBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = RegisterDonorBtn_Click;
			Button registerDonorBtn = default(Button);
			while (true)
			{
				int num = 472764214;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6CACB1FDu) % 8u)
					{
					case 7u:
						Form2.smethod_53((Control)(object)registerDonorBtn, eventHandler_);
						num = (int)(num2 * 1598131613) ^ -284437270;
						continue;
					case 6u:
					{
						registerDonorBtn = _RegisterDonorBtn;
						int num5;
						int num6;
						if (registerDonorBtn == null)
						{
							num5 = 1190015907;
							num6 = 1190015907;
						}
						else
						{
							num5 = 2047198264;
							num6 = 2047198264;
						}
						num = num5 ^ (int)(num2 * 86770463);
						continue;
					}
					case 3u:
						registerDonorBtn = _RegisterDonorBtn;
						num = (int)(num2 * 494969229) ^ -1661876078;
						continue;
					case 2u:
						_RegisterDonorBtn = value;
						num = 793926515;
						continue;
					case 1u:
						Form2.smethod_52((Control)(object)registerDonorBtn, eventHandler_);
						num = ((int)num2 * -1659253329) ^ -68116912;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (registerDonorBtn == null)
						{
							num3 = 662728631;
							num4 = 662728631;
						}
						else
						{
							num3 = 870960436;
							num4 = 870960436;
						}
						num = num3 ^ (int)(num2 * 446249203);
						continue;
					}
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

	[field: AccessedThroughProperty("BloodBankPanel2")]
	internal virtual Panel BloodBankPanel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BloodBankPanel1")]
	internal virtual Panel BloodBankPanel1
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

	public Form2()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		Form2.smethod_0((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
		Form2.smethod_1((Form)(object)this, (EventHandler)Form2_Shown);
		Form2.smethod_2((Form)(object)this, (EventHandler)Form2_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing)
			{
				goto IL_004c;
			}
			int num = 0;
			goto IL_0083;
			IL_0083:
			bool flag = (byte)num != 0;
			int num2 = -1233277728;
			goto IL_0051;
			IL_004c:
			num2 = -185603084;
			goto IL_0051;
			IL_0051:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xDC2BA23Eu) % 6u)
				{
				case 3u:
					num2 = -1110946161;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -343375183;
						num5 = -343375183;
					}
					else
					{
						num4 = -1291753255;
						num5 = -1291753255;
					}
					num2 = num4 ^ (int)(num3 * 526471611);
					continue;
				}
				case 1u:
					Form2.smethod_3((IDisposable)components);
					num2 = ((int)num3 * -1738962725) ^ -997449788;
					continue;
				case 0u:
					break;
				default:
					return;
				case 4u:
					goto IL_007a;
				case 5u:
					return;
				}
				break;
			}
			goto IL_004c;
			IL_007a:
			num = ((components != null) ? 1 : 0);
			goto IL_0083;
		}
		finally
		{
			((Form)this).Dispose(disposing);
			while (true)
			{
				IL_00c0:
				int num6 = -861761495;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0xDC2BA23Eu) % 3u)
					{
					case 1u:
						goto IL_0096;
					default:
						goto end_IL_00a3;
					case 2u:
						break;
					case 0u:
						goto end_IL_00a3;
					}
					goto IL_00c0;
					IL_0096:
					num6 = ((int)num3 * -1170903592) ^ -1138505503;
					continue;
					end_IL_00a3:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f61: Unknown result type (might be due to invalid IL or missing references)
		//IL_1114: Unknown result type (might be due to invalid IL or missing references)
		//IL_1882: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dca: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_24dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_25b5: Unknown result type (might be due to invalid IL or missing references)
		Label1 = Form2.smethod_4();
		StaffPanel = Form2.smethod_5();
		while (true)
		{
			int num = 720738025;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x175C4119u) % 359u)
				{
				case 358u:
					num = ((int)num2 * -2081232932) ^ -1067943590;
					continue;
				case 357u:
					Form2.smethod_19((Control)(object)RegisterRecieverBtn, new Size(311, 50));
					num = (int)(num2 * 1720956188) ^ -2007154520;
					continue;
				case 356u:
					AvailabilityBtn = Form2.smethod_7();
					num = (int)(num2 * 103430720) ^ -983643293;
					continue;
				case 355u:
					GroupBox4 = Form2.smethod_6();
					num = ((int)num2 * -525008816) ^ 0x6DBCA8C2;
					continue;
				case 354u:
					Form2.smethod_20((Control)(object)EditProfileBtn, 5);
					num = (int)((num2 * 388923895) ^ 0x34B7EB8F);
					continue;
				case 353u:
					Form2.smethod_16((Control)(object)Label1, Color.White);
					Form2.smethod_17((Control)(object)Label1, new Point(428, 35));
					num = (int)((num2 * 1900584163) ^ 0x5F70F544);
					continue;
				case 352u:
					Form2.smethod_30((ButtonBase)(object)RegisterRecieverBtn, (FlatStyle)0);
					Form2.smethod_15((Control)(object)RegisterRecieverBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Form2.smethod_17((Control)(object)RegisterRecieverBtn, new Point(20, 88));
					Form2.smethod_31((Control)(object)RegisterRecieverBtn, new Padding(0));
					num = (int)((num2 * 1084174705) ^ 0x6D69E80);
					continue;
				case 351u:
					Form2.smethod_17((Control)(object)GroupBox4, new Point(13, 440));
					num = ((int)num2 * -1817332466) ^ -2091186943;
					continue;
				case 350u:
					Form2.smethod_17((Control)(object)AvailabilityBtn, new Point(20, 37));
					num = (int)(num2 * 1048378900) ^ -146385336;
					continue;
				case 349u:
					Form2.smethod_18((Control)(object)LogoutBtn, "LogoutBtn");
					num = ((int)num2 * -493802790) ^ -1363451169;
					continue;
				case 348u:
					Form2.smethod_18((Control)(object)PatientPanel1, "PatientPanel1");
					num = (int)((num2 * 1817757512) ^ 0x16D09DA9);
					continue;
				case 347u:
					Form2.smethod_25(Form2.smethod_43((Control)(object)this), (Control)(object)PictureBox1);
					num = (int)((num2 * 1467276896) ^ 0x620FF39);
					continue;
				case 346u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)Panel1), (Control)(object)GroupBox5);
					num = (int)(num2 * 650597865) ^ -536588119;
					continue;
				case 345u:
					num = (int)((num2 * 1108051160) ^ 0x58CCA7C0);
					continue;
				case 344u:
					num = (int)((num2 * 1997800649) ^ 0x4DD87309);
					continue;
				case 343u:
					num = ((int)num2 * -323670586) ^ 0x6744BF6B;
					continue;
				case 342u:
					Form2.smethod_37(PictureBox1, 7);
					num = (int)((num2 * 749776723) ^ 0x54FB75DF);
					continue;
				case 341u:
					num = (int)((num2 * 2051978167) ^ 0x21EA8B3);
					continue;
				case 340u:
					num = ((int)num2 * -1154258408) ^ 0x6D6DC4C3;
					continue;
				case 339u:
					Form2.smethod_20((Control)(object)RegisterRecieverBtn, 6);
					num = (int)((num2 * 547095235) ^ 0x190E179F);
					continue;
				case 338u:
					Form2.smethod_31((Control)(object)CheckUpBtn, new Padding(0));
					num = ((int)num2 * -250180478) ^ -1948047410;
					continue;
				case 337u:
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)RegistrationBtn), 0);
					num = (int)((num2 * 905597732) ^ 0x2B43A17B);
					continue;
				case 336u:
					num = ((int)num2 * -1394089734) ^ -61213283;
					continue;
				case 335u:
					Form2.smethod_31((Control)(object)UpdateDetailsBtn, new Padding(0));
					num = ((int)num2 * -819659396) ^ -646020959;
					continue;
				case 334u:
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.Transparent);
					Form2.smethod_17((Control)(object)BloodBankPanel2, new Point(307, 38));
					num = (int)(num2 * 782013098) ^ -2035033903;
					continue;
				case 333u:
					Form2.smethod_33((ButtonBase)(object)AvailabilityBtn, bool_0: true);
					num = (int)((num2 * 405405281) ^ 0x6BB96388);
					continue;
				case 332u:
					Form2.smethod_49((ISupportInitialize)PictureBox1);
					num = (int)(num2 * 458374620) ^ -1708968368;
					continue;
				case 331u:
					num = ((int)num2 * -760692586) ^ -46199037;
					continue;
				case 330u:
					num = ((int)num2 * -1770403925) ^ 0x5DE316C;
					continue;
				case 329u:
					num = ((int)num2 * -1217074638) ^ -1432411758;
					continue;
				case 328u:
					num = ((int)num2 * -2023031621) ^ 0x4D18E5D5;
					continue;
				case 327u:
					num = ((int)num2 * -272880618) ^ 0x14044B42;
					continue;
				case 326u:
					Form2.smethod_19((Control)(object)PatientPanel2, new Size(44, 50));
					num = (int)((num2 * 340467338) ^ 0x1FEA9DC1);
					continue;
				case 325u:
					num = (int)((num2 * 1599396164) ^ 0x373179FD);
					continue;
				case 324u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox2), (Control)(object)AdmitBtn);
					num = ((int)num2 * -1322533960) ^ -563436667;
					continue;
				case 323u:
					num = (int)((num2 * 1145232676) ^ 0x38108BEF);
					continue;
				case 322u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox5), (Control)(object)PersonalInfoPanel1);
					num = (int)((num2 * 329918333) ^ 0x24CE1A2D);
					continue;
				case 321u:
					UpdateDetailsBtn = Form2.smethod_7();
					num = (int)((num2 * 1272846730) ^ 0x4A5A261F);
					continue;
				case 320u:
					Form2.smethod_33((ButtonBase)(object)LogoutBtn, bool_0: true);
					num = ((int)num2 * -1312283331) ^ 0x2EEFFB;
					continue;
				case 319u:
					Form2.smethod_30((ButtonBase)(object)RegisterDonorBtn, (FlatStyle)0);
					num = ((int)num2 * -1556805154) ^ 0x6AE1070B;
					continue;
				case 318u:
					EditProfileBtn = Form2.smethod_7();
					num = (int)(num2 * 1602730473) ^ -134209815;
					continue;
				case 317u:
					Form2.smethod_30((ButtonBase)(object)RegistrationBtn, (FlatStyle)0);
					num = (int)((num2 * 368887863) ^ 0x136FAF81);
					continue;
				case 316u:
					num = ((int)num2 * -2089327096) ^ -1000004067;
					continue;
				case 315u:
					num = ((int)num2 * -1683403054) ^ -1380361402;
					continue;
				case 314u:
					Form2.smethod_17((Control)(object)StaffPanel1, new Point(0, 37));
					num = ((int)num2 * -378368959) ^ -1434339246;
					continue;
				case 313u:
					Form2.smethod_48((Control)(object)GroupBox5, bool_0: false);
					num = ((int)num2 * -582480696) ^ -1171252615;
					continue;
				case 312u:
					Form2.smethod_17((Control)(object)PatientPanel2, new Point(307, 43));
					num = (int)((num2 * 393557487) ^ 0x43E9FCB3);
					continue;
				case 311u:
					Form2.smethod_20((Control)(object)GroupBox3, 10);
					num = (int)((num2 * 1360120056) ^ 0x2B1DEB9F);
					continue;
				case 310u:
					num = (int)(num2 * 655452410) ^ -513067883;
					continue;
				case 309u:
					StaffPanel2 = Form2.smethod_5();
					num = ((int)num2 * -1391275634) ^ 0x154FD999;
					continue;
				case 308u:
					num = ((int)num2 * -783323521) ^ 0x611F9368;
					continue;
				case 307u:
					Form2.smethod_19((Control)(object)LogoutBtn, new Size(311, 50));
					Form2.smethod_20((Control)(object)LogoutBtn, 6);
					Form2.smethod_32((ButtonBase)(object)LogoutBtn, "Logout");
					num = ((int)num2 * -1472551624) ^ -916802291;
					continue;
				case 306u:
					Form2.smethod_19((Control)(object)StaffPanel, new Size(977, 825));
					num = (int)((num2 * 279817022) ^ 0x4D3A3607);
					continue;
				case 305u:
					Form2.smethod_19((Control)(object)GroupBox3, new Size(351, 114));
					num = (int)(num2 * 1816467618) ^ -1628544861;
					continue;
				case 304u:
					Form2.smethod_18((Control)(object)RegisterDonorBtn, "RegisterDonorBtn");
					num = ((int)num2 * -2046738186) ^ -1311955171;
					continue;
				case 303u:
					Form2.smethod_18((Control)(object)Panel1, "Panel1");
					num = (int)((num2 * 289848890) ^ 0x6EB6FF3B);
					continue;
				case 302u:
					Form2.smethod_15((Control)(object)AvailabilityBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1110507814) ^ -974238698;
					continue;
				case 301u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					num = ((int)num2 * -2096278014) ^ 0x590BE587;
					continue;
				case 300u:
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)AdmitBtn), 0);
					Form2.smethod_30((ButtonBase)(object)AdmitBtn, (FlatStyle)0);
					num = ((int)num2 * -914882816) ^ 0x56EEBABB;
					continue;
				case 299u:
					Form2.smethod_20((Control)(object)BloodBankPanel1, 14);
					Form2.smethod_35(PictureBox1, (Image)(object)Resources.Hospital_blue_icon);
					num = ((int)num2 * -2087217773) ^ 0x7365635D;
					continue;
				case 298u:
					Form2.smethod_19((Control)(object)EditProfileBtn, new Size(311, 50));
					num = (int)(num2 * 662011402) ^ -817060916;
					continue;
				case 297u:
					num = ((int)num2 * -1474463412) ^ 0x1D97191C;
					continue;
				case 296u:
					Form2.smethod_42((Form)(object)this, new Size(1285, 973));
					num = ((int)num2 * -834264217) ^ -327963107;
					continue;
				case 295u:
					Form2.smethod_18((Control)(object)BloodBankPanel2, "BloodBankPanel2");
					num = (int)((num2 * 857623556) ^ 0x8EEB6CD);
					continue;
				case 294u:
					num = (int)((num2 * 316156574) ^ 0x1880AE50);
					continue;
				case 293u:
					Form2.smethod_18((Control)(object)EditProfileBtn, "EditProfileBtn");
					num = (int)((num2 * 1950790370) ^ 0x65162A82);
					continue;
				case 292u:
					Form2.smethod_33((ButtonBase)(object)BloodAvailabilityBtn, bool_0: true);
					num = ((int)num2 * -874369625) ^ -1242319501;
					continue;
				case 291u:
					Form2.smethod_17((Control)(object)RegistrationBtn, new Point(25, 43));
					num = (int)(num2 * 1008141235) ^ -1961701147;
					continue;
				case 290u:
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)AvailabilityBtn), 0);
					Form2.smethod_30((ButtonBase)(object)AvailabilityBtn, (FlatStyle)0);
					num = ((int)num2 * -1464437646) ^ -144011897;
					continue;
				case 289u:
					num = ((int)num2 * -1723971642) ^ -1972535399;
					continue;
				case 288u:
					Form2.smethod_15((Control)(object)Label1, Form2.smethod_14("Microsoft Sans Serif", 36f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1477029393) ^ 0x653E8F04;
					continue;
				case 287u:
					Form2.smethod_19((Control)(object)Panel1, new Size(380, 825));
					num = ((int)num2 * -28958520) ^ 0x34578DDB;
					continue;
				case 286u:
					num = ((int)num2 * -1468398604) ^ -425838573;
					continue;
				case 285u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox2), (Control)(object)PatientPanel1);
					num = ((int)num2 * -1344283380) ^ 0x1364A80E;
					continue;
				case 284u:
					Form2.smethod_20((Control)(object)PersonalInfoPanel1, 15);
					num = ((int)num2 * -1795693781) ^ 0x31B477F2;
					continue;
				case 283u:
					num = (int)(num2 * 487243301) ^ -340973573;
					continue;
				case 282u:
					num = ((int)num2 * -1169136356) ^ 0xD4E9CF2;
					continue;
				case 281u:
					Form2.smethod_20((Control)(object)GroupBox4, 11);
					num = ((int)num2 * -1893975980) ^ 0x22F3A461;
					continue;
				case 280u:
					Form2.smethod_19((Control)(object)GroupBox2, new Size(351, 267));
					Form2.smethod_20((Control)(object)GroupBox2, 9);
					num = ((int)num2 * -220754918) ^ 0x972E17;
					continue;
				case 279u:
					Form2.smethod_19((Control)(object)RegistrationBtn, new Size(306, 50));
					num = ((int)num2 * -1970437673) ^ -1929671193;
					continue;
				case 278u:
					Form2.smethod_22(Label1, (ContentAlignment)32);
					num = (int)((num2 * 72694651) ^ 0x664784D3);
					continue;
				case 277u:
					num = (int)((num2 * 1588612214) ^ 0x1D9B0F2E);
					continue;
				case 276u:
					num = (int)((num2 * 1410598319) ^ 0x719356AC);
					continue;
				case 275u:
					Form2.smethod_25(Form2.smethod_43((Control)(object)this), (Control)(object)Label1);
					Form2.smethod_44((Control)(object)this, "Form2");
					num = (int)((num2 * 1189416374) ^ 0x28966902);
					continue;
				case 274u:
					PersonalInfoPanel2 = Form2.smethod_5();
					PersonalInfoPanel1 = Form2.smethod_5();
					num = (int)(num2 * 1915161547) ^ -1867959648;
					continue;
				case 273u:
					PatientPanel2 = Form2.smethod_5();
					PatientPanel1 = Form2.smethod_5();
					num = (int)(num2 * 850064582) ^ -316768553;
					continue;
				case 271u:
					num = (int)(num2 * 395719405) ^ -2027168430;
					continue;
				case 270u:
					num = (int)((num2 * 1740576126) ^ 0x12902E23);
					continue;
				case 269u:
					Form2.smethod_48((Control)(object)GroupBox2, bool_0: false);
					num = (int)(num2 * 1351671918) ^ -728937606;
					continue;
				case 268u:
					Form2.smethod_33((ButtonBase)(object)AdmitBtn, bool_0: true);
					num = ((int)num2 * -2070480033) ^ -861259480;
					continue;
				case 267u:
					num = ((int)num2 * -2038669300) ^ 0x12ADEE98;
					continue;
				case 266u:
					Form2.smethod_27(GroupBox5, "Personal Info");
					num = ((int)num2 * -1253331917) ^ -1179292117;
					continue;
				case 265u:
					Form2.smethod_19((Control)(object)AdmitBtn, new Size(306, 50));
					num = ((int)num2 * -1304165343) ^ -1719131331;
					continue;
				case 264u:
					Form2.smethod_19((Control)(object)StaffPanel2, new Size(44, 50));
					num = ((int)num2 * -1660078271) ^ 0x560C31CE;
					continue;
				case 263u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox3), (Control)(object)AvailabilityBtn);
					num = (int)((num2 * 1848082099) ^ 0x1072531E);
					continue;
				case 262u:
					Form2.smethod_13((Control)(object)Label1, Color.Transparent);
					num = (int)(num2 * 874042662) ^ -2081365054;
					continue;
				case 261u:
					GroupBox3 = Form2.smethod_6();
					num = ((int)num2 * -1287175598) ^ -1177074369;
					continue;
				case 260u:
					Form2.smethod_32((ButtonBase)(object)RegisterDonorBtn, "Register Donor");
					num = ((int)num2 * -1486399021) ^ -2076719479;
					continue;
				case 259u:
					num = (int)((num2 * 363215467) ^ 0x4D487A27);
					continue;
				case 258u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox5), (Control)(object)LogoutBtn);
					num = ((int)num2 * -1874694835) ^ 0x11CD8D2A;
					continue;
				case 257u:
					Form2.smethod_9((Control)(object)GroupBox3);
					num = (int)(num2 * 1939601578) ^ -1213551856;
					continue;
				case 256u:
					num = ((int)num2 * -161417077) ^ 0x574513D7;
					continue;
				case 255u:
					Form2.smethod_32((ButtonBase)(object)AvailabilityBtn, "Availability");
					num = (int)(num2 * 606517788) ^ -2074048831;
					continue;
				case 254u:
					num = (int)(num2 * 445065857) ^ -1333769130;
					continue;
				case 253u:
					Form2.smethod_30((ButtonBase)(object)BloodAvailabilityBtn, (FlatStyle)0);
					num = (int)((num2 * 1873268825) ^ 0x48312FE4);
					continue;
				case 252u:
					Form2.smethod_18((Control)(object)StaffPanel2, "StaffPanel2");
					num = (int)(num2 * 527459447) ^ -2080791636;
					continue;
				case 251u:
					Form2.smethod_17((Control)(object)GroupBox3, new Point(13, 311));
					num = (int)((num2 * 977332182) ^ 0x36580F2);
					continue;
				case 250u:
					Form2.smethod_20((Control)(object)StaffPanel1, 5);
					num = ((int)num2 * -189296386) ^ 0x7DED9E02;
					continue;
				case 249u:
					Form2.smethod_13((Control)(object)GroupBox2, Color.White);
					num = (int)((num2 * 1100428006) ^ 0x2F4FD5E4);
					continue;
				case 248u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox2), (Control)(object)RegistrationBtn);
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox2), (Control)(object)PatientPanel2);
					num = ((int)num2 * -84823709) ^ 0x44B5C6C3;
					continue;
				case 247u:
					Form2.smethod_18((Control)(object)StaffPanel1, "StaffPanel1");
					num = ((int)num2 * -330311802) ^ -60010172;
					continue;
				case 246u:
					num = ((int)num2 * -1356146902) ^ -1427426755;
					continue;
				case 245u:
					num = ((int)num2 * -1031624106) ^ -124789084;
					continue;
				case 244u:
					Form2.smethod_36(PictureBox1, (PictureBoxSizeMode)1);
					num = ((int)num2 * -1129996650) ^ -217643410;
					continue;
				case 243u:
					Form2.smethod_9((Control)(object)GroupBox4);
					num = (int)((num2 * 55995962) ^ 0x3C5DD85);
					continue;
				case 242u:
					Form2.smethod_31((Control)(object)GroupBox4, new Padding(0));
					num = (int)((num2 * 1986011014) ^ 0x8D0FB14);
					continue;
				case 241u:
					Form2.smethod_17((Control)(object)AdmitBtn, new Point(25, 146));
					Form2.smethod_31((Control)(object)AdmitBtn, new Padding(0));
					num = ((int)num2 * -739032691) ^ -2073673481;
					continue;
				case 240u:
					Form2.smethod_18((Control)(object)PersonalInfoPanel1, "PersonalInfoPanel1");
					num = (int)((num2 * 1858045675) ^ 0x4E730315);
					continue;
				case 239u:
					num = ((int)num2 * -934987729) ^ -89572496;
					continue;
				case 238u:
					Form2.smethod_18((Control)(object)PatientPanel2, "PatientPanel2");
					num = ((int)num2 * -106587983) ^ 0x2E79C623;
					continue;
				case 237u:
					Form2.smethod_30((ButtonBase)(object)UpdateDetailsBtn, (FlatStyle)0);
					num = ((int)num2 * -1844124004) ^ 0x599711C0;
					continue;
				case 236u:
					num = (int)((num2 * 488740010) ^ 0x33731DAF);
					continue;
				case 235u:
					Form2.smethod_31((Control)(object)BloodAvailabilityBtn, new Padding(0));
					Form2.smethod_18((Control)(object)BloodAvailabilityBtn, "BloodAvailabilityBtn");
					num = (int)((num2 * 42789904) ^ 0x6EB111);
					continue;
				case 234u:
					Form2.smethod_13((Control)(object)PatientPanel1, Color.Transparent);
					Form2.smethod_15((Control)(object)PatientPanel1, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -621032574) ^ -235795839;
					continue;
				case 233u:
					num = ((int)num2 * -132041739) ^ 0x1512EC96;
					continue;
				case 232u:
					num = (int)((num2 * 336662206) ^ 0x2D8536C8);
					continue;
				case 231u:
					Form2.smethod_20((Control)(object)RegisterDonorBtn, 5);
					num = (int)((num2 * 2030698078) ^ 0x483F0994);
					continue;
				case 230u:
					BloodBankPanel1 = Form2.smethod_5();
					PictureBox1 = Form2.smethod_8();
					num = ((int)num2 * -1213372031) ^ -736623862;
					continue;
				case 229u:
					num = (int)(num2 * 1906919417) ^ -904071007;
					continue;
				case 228u:
					num = (int)(num2 * 365318550) ^ -55637393;
					continue;
				case 227u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox2), (Control)(object)CheckUpBtn);
					num = ((int)num2 * -1716253180) ^ -872470194;
					continue;
				case 226u:
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)RegisterDonorBtn), 0);
					num = ((int)num2 * -806976434) ^ 0x2A826206;
					continue;
				case 225u:
					num = (int)((num2 * 2013742686) ^ 0x57D4C873);
					continue;
				case 224u:
					num = (int)((num2 * 28313360) ^ 0x523D107A);
					continue;
				case 223u:
					Form2.smethod_32((ButtonBase)(object)EditProfileBtn, "Edit Profile");
					num = (int)(num2 * 1835544616) ^ -1270244023;
					continue;
				case 222u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.Transparent);
					num = (int)(num2 * 455106992) ^ -134302483;
					continue;
				case 221u:
					Form2.smethod_31((Control)(object)RegistrationBtn, new Padding(0));
					num = ((int)num2 * -91460851) ^ -303103714;
					continue;
				case 220u:
					Form2.smethod_18((Control)(object)BloodBankPanel1, "BloodBankPanel1");
					num = (int)((num2 * 482378937) ^ 0x72B6CB0A);
					continue;
				case 219u:
					Form2.smethod_10((ISupportInitialize)PictureBox1);
					num = (int)((num2 * 1575931402) ^ 0x34C700E6);
					continue;
				case 218u:
					Form2.smethod_15((Control)(object)EditProfileBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1514762944) ^ 0x166F7D1E;
					continue;
				case 217u:
					Form2.smethod_20((Control)(object)AvailabilityBtn, 4);
					num = (int)(num2 * 2088269138) ^ -1506043400;
					continue;
				case 216u:
					Form2.smethod_20((Control)(object)StaffPanel2, 6);
					num = ((int)num2 * -650438272) ^ 0x47349C4C;
					continue;
				case 215u:
					num = (int)(num2 * 1373798836) ^ -1817276534;
					continue;
				case 214u:
					Panel1 = Form2.smethod_5();
					GroupBox5 = Form2.smethod_6();
					LogoutBtn = Form2.smethod_7();
					num = (int)(num2 * 219176781) ^ -851699391;
					continue;
				case 213u:
					num = (int)((num2 * 1697015483) ^ 0x4630D42);
					continue;
				case 212u:
					Form2.smethod_15((Control)(object)GroupBox3, Form2.smethod_14("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1796195070) ^ 0x145F6C65;
					continue;
				case 211u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox3), (Control)(object)StaffPanel1);
					num = (int)((num2 * 85143156) ^ 0x5D6AFCE1);
					continue;
				case 210u:
					Form2.smethod_33((ButtonBase)(object)EditProfileBtn, bool_0: true);
					num = ((int)num2 * -1233104657) ^ 0x74E0A9BA;
					continue;
				case 209u:
					Form2.smethod_33((ButtonBase)(object)RegisterDonorBtn, bool_0: true);
					num = ((int)num2 * -567818384) ^ 0x17F9F568;
					continue;
				case 208u:
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					num = (int)((num2 * 1791481418) ^ 0xB63BAA8);
					continue;
				case 207u:
					num = (int)(num2 * 820778477) ^ -2071051234;
					continue;
				case 206u:
					num = (int)((num2 * 1721770940) ^ 0x7EA09485);
					continue;
				case 205u:
					Form2.smethod_26(GroupBox3, bool_0: false);
					num = ((int)num2 * -2081096993) ^ -146414515;
					continue;
				case 204u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox4), (Control)(object)RegisterDonorBtn);
					num = ((int)num2 * -1235968545) ^ 0x3DB5BE2D;
					continue;
				case 203u:
					num = (int)((num2 * 337762768) ^ 0x2E860F6B);
					continue;
				case 202u:
					num = (int)((num2 * 2093592895) ^ 0x6144A567);
					continue;
				case 201u:
					num = (int)((num2 * 473701586) ^ 0x3F3C469F);
					continue;
				case 200u:
					num = (int)((num2 * 742569618) ^ 0x2229EB12);
					continue;
				case 199u:
					Form2.smethod_17((Control)(object)PictureBox1, new Point(307, 12));
					num = (int)(num2 * 402479641) ^ -8058579;
					continue;
				case 198u:
					Form2.smethod_17((Control)(object)GroupBox5, new Point(13, 647));
					num = ((int)num2 * -739194344) ^ -1792389948;
					continue;
				case 197u:
					Form2.smethod_20((Control)(object)Panel1, 6);
					num = ((int)num2 * -383201958) ^ 0x682B92F1;
					continue;
				case 196u:
					Form2.smethod_33((ButtonBase)(object)RegisterRecieverBtn, bool_0: true);
					num = (int)(num2 * 169506079) ^ -429727619;
					continue;
				case 195u:
					Form2.smethod_17((Control)(object)Panel1, new Point(126, 141));
					num = ((int)num2 * -1534602749) ^ -2121204404;
					continue;
				case 194u:
					num = (int)(num2 * 304318541) ^ -57570514;
					continue;
				case 193u:
					num = (int)(num2 * 968721462) ^ -1037018307;
					continue;
				case 192u:
					Form2.smethod_17((Control)(object)UpdateDetailsBtn, new Point(25, 196));
					num = ((int)num2 * -1324877788) ^ -85266068;
					continue;
				case 191u:
					Form2.smethod_25(Form2.smethod_43((Control)(object)this), (Control)(object)Panel1);
					num = (int)((num2 * 1815600675) ^ 0x64480233);
					continue;
				case 190u:
					Form2.smethod_17((Control)(object)LogoutBtn, new Point(20, 102));
					num = (int)(num2 * 549154954) ^ -1760331934;
					continue;
				case 189u:
					num = (int)(num2 * 1581771896) ^ -1116495328;
					continue;
				case 188u:
					Form2.smethod_20((Control)(object)UpdateDetailsBtn, 4);
					num = (int)((num2 * 1709743075) ^ 0x7B446B1D);
					continue;
				case 187u:
					Form2.smethod_18((Control)(object)Label1, "Label1");
					num = ((int)num2 * -1507798385) ^ -1830050011;
					continue;
				case 186u:
					num = (int)((num2 * 121320485) ^ 0x45B612AA);
					continue;
				case 185u:
					num = ((int)num2 * -67238785) ^ -986003845;
					continue;
				case 184u:
					num = ((int)num2 * -158015594) ^ 0x408DB262;
					continue;
				case 183u:
					Form2.smethod_19((Control)(object)PersonalInfoPanel1, new Size(44, 50));
					num = (int)((num2 * 39936113) ^ 0x3FB446E9);
					continue;
				case 182u:
					Form2.smethod_18((Control)(object)RegisterRecieverBtn, "RegisterRecieverBtn");
					num = ((int)num2 * -1177493199) ^ -147419624;
					continue;
				case 181u:
					num = (int)(num2 * 690781206) ^ -248894482;
					continue;
				case 180u:
					Form2.smethod_27(GroupBox3, "Staff");
					num = (int)(num2 * 1811406931) ^ -92610854;
					continue;
				case 179u:
					Form2.smethod_41((Form)(object)this, Color.MidnightBlue);
					num = (int)((num2 * 1739146421) ^ 0x40FAF96F);
					continue;
				case 178u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox5), (Control)(object)PersonalInfoPanel2);
					num = ((int)num2 * -988618283) ^ -972983368;
					continue;
				case 177u:
					num = (int)(num2 * 1524991197) ^ -499270905;
					continue;
				case 176u:
					Form2.smethod_18((Control)(object)GroupBox4, "GroupBox4");
					num = ((int)num2 * -845257204) ^ -2102511037;
					continue;
				case 175u:
					Form2.smethod_27(GroupBox2, "Patient");
					num = (int)((num2 * 87805278) ^ 0x74996104);
					continue;
				case 174u:
					num = ((int)num2 * -1928881468) ^ -977742892;
					continue;
				case 173u:
					Form2.smethod_40((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -703703125) ^ -882532735;
					continue;
				case 172u:
					Form2.smethod_15((Control)(object)LogoutBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1779996762) ^ 0x252673D;
					continue;
				case 171u:
					num = (int)(num2 * 996404942) ^ -703504299;
					continue;
				case 170u:
					Form2.smethod_32((ButtonBase)(object)CheckUpBtn, "Check-Up");
					num = (int)(num2 * 693243615) ^ -1676361810;
					continue;
				case 169u:
					num = ((int)num2 * -273367103) ^ 0x4A68EBF0;
					continue;
				case 168u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox3), (Control)(object)StaffPanel2);
					num = (int)(num2 * 1256084659) ^ -1032490880;
					continue;
				case 167u:
					Form2.smethod_18((Control)(object)GroupBox2, "GroupBox2");
					num = (int)((num2 * 51649122) ^ 0x3E5C41D1);
					continue;
				case 166u:
					Form2.smethod_13((Control)(object)StaffPanel, Color.White);
					num = (int)(num2 * 1410262830) ^ -1958683562;
					continue;
				case 165u:
					num = ((int)num2 * -1895297818) ^ 0x1DCA46C7;
					continue;
				case 164u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox5), (Control)(object)EditProfileBtn);
					num = ((int)num2 * -488311413) ^ 0x4238369C;
					continue;
				case 163u:
					Form2.smethod_15((Control)(object)BloodAvailabilityBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Form2.smethod_17((Control)(object)BloodAvailabilityBtn, new Point(20, 138));
					num = ((int)num2 * -227380434) ^ -513106059;
					continue;
				case 162u:
					num = (int)((num2 * 1563447732) ^ 0x5228E9BB);
					continue;
				case 161u:
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)CheckUpBtn), 0);
					num = (int)((num2 * 905743607) ^ 0x2290A49E);
					continue;
				case 160u:
					num = ((int)num2 * -1608008770) ^ -1538856418;
					continue;
				case 159u:
					num = ((int)num2 * -1601956440) ^ 0x12B1DA32;
					continue;
				case 158u:
					num = ((int)num2 * -88977245) ^ 0x70DBB52C;
					continue;
				case 157u:
					Form2.smethod_31((Control)(object)AvailabilityBtn, new Padding(0));
					num = ((int)num2 * -493338392) ^ -925307070;
					continue;
				case 156u:
					num = ((int)num2 * -530394539) ^ 0x22FA1F42;
					continue;
				case 155u:
					num = ((int)num2 * -1540337854) ^ -1983295800;
					continue;
				case 154u:
					num = ((int)num2 * -1665251568) ^ -1524086810;
					continue;
				case 153u:
					Form2.smethod_18((Control)(object)GroupBox3, "GroupBox3");
					num = ((int)num2 * -531090750) ^ 0x6C61C9B6;
					continue;
				case 152u:
					Form2.smethod_18((Control)(object)AdmitBtn, "AdmitBtn");
					num = ((int)num2 * -976631032) ^ -66528778;
					continue;
				case 151u:
					Form2.smethod_19((Control)(object)PersonalInfoPanel2, new Size(44, 50));
					num = ((int)num2 * -1876048406) ^ -137999853;
					continue;
				case 150u:
					Form2.smethod_20((Control)(object)AdmitBtn, 3);
					num = (int)(num2 * 2087865650) ^ -327951840;
					continue;
				case 149u:
					num = (int)(num2 * 2069394133) ^ -1585734876;
					continue;
				case 148u:
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)EditProfileBtn), 0);
					Form2.smethod_30((ButtonBase)(object)EditProfileBtn, (FlatStyle)0);
					num = ((int)num2 * -1827041685) ^ 0x642243DE;
					continue;
				case 147u:
					num = (int)(num2 * 1453152602) ^ -789785409;
					continue;
				case 146u:
					num = ((int)num2 * -1182007526) ^ -454653945;
					continue;
				case 145u:
					Form2.smethod_20((Control)(object)PatientPanel2, 6);
					num = ((int)num2 * -449338377) ^ -1160953924;
					continue;
				case 144u:
					Form2.smethod_20((Control)(object)CheckUpBtn, 2);
					num = ((int)num2 * -1766802886) ^ 0x584A8A07;
					continue;
				case 143u:
					Form2.smethod_15((Control)(object)AdmitBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 959312741) ^ 0x5167EB1F);
					continue;
				case 142u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = ((int)num2 * -1866800885) ^ 0x4F9B34CF;
					continue;
				case 141u:
					Form2.smethod_26(GroupBox2, bool_0: false);
					num = ((int)num2 * -2086229998) ^ -1740240458;
					continue;
				case 140u:
					num = (int)((num2 * 1871559858) ^ 0x4B806FB4);
					continue;
				case 139u:
					Form2.smethod_17((Control)(object)StaffPanel, new Point(716, 141));
					num = ((int)num2 * -126582852) ^ 0x97C8724;
					continue;
				case 138u:
					num = (int)((num2 * 1469955528) ^ 0x371CDA7F);
					continue;
				case 137u:
					Form2.smethod_15((Control)(object)GroupBox5, Form2.smethod_14("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1041651895) ^ -2138648565;
					continue;
				case 136u:
					num = ((int)num2 * -1301240159) ^ 0x6791DE9E;
					continue;
				case 135u:
					Form2.smethod_45((Form)(object)this, (SizeGripStyle)1);
					num = ((int)num2 * -1639281258) ^ -429465331;
					continue;
				case 134u:
					Form2.smethod_18((Control)(object)AvailabilityBtn, "AvailabilityBtn");
					num = (int)(num2 * 867265671) ^ -207322315;
					continue;
				case 133u:
					Form2.smethod_19((Control)(object)BloodBankPanel1, new Size(44, 50));
					num = (int)((num2 * 440122059) ^ 0x1A4B0637);
					continue;
				case 132u:
					num = ((int)num2 * -916450794) ^ -983897551;
					continue;
				case 131u:
					num = ((int)num2 * -27070465) ^ -475534371;
					continue;
				case 130u:
					num = (int)(num2 * 543263246) ^ -187917078;
					continue;
				case 129u:
					Form2.smethod_20((Control)(object)PersonalInfoPanel2, 16);
					num = (int)(num2 * 978922328) ^ -1945505008;
					continue;
				case 128u:
					Form2.smethod_17((Control)(object)EditProfileBtn, new Point(20, 52));
					num = (int)((num2 * 781579615) ^ 0x16EDF61D);
					continue;
				case 127u:
					Form2.smethod_19((Control)(object)BloodAvailabilityBtn, new Size(311, 50));
					Form2.smethod_20((Control)(object)BloodAvailabilityBtn, 7);
					num = ((int)num2 * -282313358) ^ 0x31C46F14;
					continue;
				case 126u:
					Form2.smethod_19((Control)(object)Label1, new Size(845, 69));
					num = (int)((num2 * 608634169) ^ 0x6E0E8156);
					continue;
				case 125u:
					num = (int)(num2 * 1744856980) ^ -1560113065;
					continue;
				case 124u:
					Form2.smethod_13((Control)(object)BloodBankPanel1, Color.Transparent);
					Form2.smethod_17((Control)(object)BloodBankPanel1, new Point(0, 38));
					num = (int)(num2 * 584920402) ^ -329363172;
					continue;
				case 123u:
					num = ((int)num2 * -760979385) ^ -45497651;
					continue;
				case 122u:
					Form2.smethod_20((Control)(object)PatientPanel1, 0);
					num = (int)(num2 * 884488236) ^ -453875275;
					continue;
				case 121u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox4), (Control)(object)BloodAvailabilityBtn);
					num = ((int)num2 * -930810946) ^ -1498714901;
					continue;
				case 120u:
					num = ((int)num2 * -613527882) ^ -458509614;
					continue;
				case 119u:
					Form2.smethod_9((Control)(object)GroupBox5);
					num = ((int)num2 * -777412687) ^ -1935072346;
					continue;
				case 118u:
					num = (int)(num2 * 252137781) ^ -429555266;
					continue;
				case 117u:
					Form2.smethod_17((Control)(object)PersonalInfoPanel1, new Point(0, 52));
					num = ((int)num2 * -1811423707) ^ 0x6E2553D1;
					continue;
				case 116u:
					num = (int)(num2 * 1138046580) ^ -880149696;
					continue;
				case 115u:
					num = ((int)num2 * -268170540) ^ -1192753278;
					continue;
				case 114u:
					Form2.smethod_23((ScrollableControl)(object)StaffPanel, bool_0: true);
					num = ((int)num2 * -529902079) ^ 0x69ADC451;
					continue;
				case 113u:
					Form2.smethod_9((Control)(object)Panel1);
					num = ((int)num2 * -1366824089) ^ -1670037842;
					continue;
				case 112u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox4), (Control)(object)BloodBankPanel2);
					num = ((int)num2 * -1393631881) ^ 0x248596EA;
					continue;
				case 111u:
					Form2.smethod_31((Control)(object)RegisterDonorBtn, new Padding(0));
					num = ((int)num2 * -636912828) ^ 0x30ABECE8;
					continue;
				case 110u:
					Form2.smethod_9((Control)(object)GroupBox2);
					num = ((int)num2 * -728529874) ^ 0x2E52EAE2;
					continue;
				case 109u:
					Form2.smethod_19((Control)(object)StaffPanel1, new Size(44, 50));
					num = ((int)num2 * -344194617) ^ -33629495;
					continue;
				case 108u:
					Form2.smethod_18((Control)(object)RegistrationBtn, "RegistrationBtn");
					num = ((int)num2 * -36332919) ^ -565820172;
					continue;
				case 107u:
					Form2.smethod_32((ButtonBase)(object)RegisterRecieverBtn, "Register Reciever");
					num = ((int)num2 * -363805721) ^ -1196448973;
					continue;
				case 106u:
					Form2.smethod_19((Control)(object)GroupBox4, new Size(351, 204));
					num = ((int)num2 * -770696280) ^ -1968478685;
					continue;
				case 105u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox4), (Control)(object)BloodBankPanel1);
					Form2.smethod_15((Control)(object)GroupBox4, Form2.smethod_14("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1184708379) ^ -173165998;
					continue;
				case 104u:
					Form2.smethod_50((Control)(object)this, bool_0: false);
					Form2.smethod_51((Control)(object)this);
					num = (int)((num2 * 1562434500) ^ 0x67338C7D);
					continue;
				case 103u:
					num = (int)(num2 * 644984341) ^ -511585315;
					continue;
				case 102u:
					num = (int)((num2 * 411002118) ^ 0x73A21939);
					continue;
				case 101u:
					Form2.smethod_26(GroupBox4, bool_0: false);
					num = (int)(num2 * 888224164) ^ -1421439716;
					continue;
				case 100u:
					num = (int)(num2 * 1477011790) ^ -931327826;
					continue;
				case 99u:
					num = ((int)num2 * -1383955962) ^ 0xF9D6A85;
					continue;
				case 98u:
					Form2.smethod_48((Control)(object)GroupBox3, bool_0: false);
					num = (int)(num2 * 1748208094) ^ -1933469471;
					continue;
				case 97u:
					num = ((int)num2 * -1039206421) ^ 0x606424C3;
					continue;
				case 96u:
					num = (int)((num2 * 163623036) ^ 0x4A07640D);
					continue;
				case 95u:
					Form2.smethod_17((Control)(object)GroupBox2, new Point(13, 9));
					Form2.smethod_31((Control)(object)GroupBox2, new Padding(0));
					num = (int)((num2 * 1463147985) ^ 0x927F116);
					continue;
				case 94u:
					Form2.smethod_18((Control)(object)PictureBox1, "PictureBox1");
					num = (int)((num2 * 2100817823) ^ 0x106207D1);
					continue;
				case 93u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = ((int)num2 * -277360470) ^ 0x7E528122;
					continue;
				case 92u:
					Form2.smethod_19((Control)(object)AvailabilityBtn, new Size(311, 50));
					num = ((int)num2 * -1663619978) ^ 0x68D8C9A7;
					continue;
				case 91u:
					num = (int)(num2 * 966292527) ^ -1411709105;
					continue;
				case 90u:
					Form2.smethod_33((ButtonBase)(object)CheckUpBtn, bool_0: true);
					num = ((int)num2 * -2041640599) ^ -1221806088;
					continue;
				case 89u:
					Form2.smethod_19((Control)(object)PatientPanel1, new Size(44, 50));
					num = ((int)num2 * -586211133) ^ -1122828513;
					continue;
				case 88u:
					num = ((int)num2 * -1044126278) ^ 0x7EF9B4DD;
					continue;
				case 87u:
					StaffPanel1 = Form2.smethod_5();
					num = (int)(num2 * 330320813) ^ -1747236233;
					continue;
				case 86u:
					num = (int)((num2 * 2137992189) ^ 0x6395B3F3);
					continue;
				case 85u:
					num = ((int)num2 * -1953092382) ^ -54031822;
					continue;
				case 84u:
					Form2.smethod_30((ButtonBase)(object)LogoutBtn, (FlatStyle)0);
					num = ((int)num2 * -351911409) ^ 0x5EAA55E6;
					continue;
				case 83u:
					num = ((int)num2 * -1934744817) ^ 0x67507339;
					continue;
				case 82u:
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)UpdateDetailsBtn), 0);
					num = ((int)num2 * -273434479) ^ 0x3D90A95A;
					continue;
				case 81u:
					Form2.smethod_20((Control)(object)BloodBankPanel2, 15);
					num = ((int)num2 * -506461592) ^ 0x2E44BCA9;
					continue;
				case 80u:
					num = ((int)num2 * -1661955664) ^ 0x3AE1ED79;
					continue;
				case 78u:
					num = (int)(num2 * 1285099323) ^ -741066703;
					continue;
				case 77u:
					Form2.smethod_25(Form2.smethod_43((Control)(object)this), (Control)(object)StaffPanel);
					num = (int)(num2 * 1506798221) ^ -1145210907;
					continue;
				case 76u:
					num = ((int)num2 * -70976460) ^ -1993184072;
					continue;
				case 75u:
					BloodAvailabilityBtn = Form2.smethod_7();
					RegisterRecieverBtn = Form2.smethod_7();
					num = (int)((num2 * 1513867406) ^ 0x399040A1);
					continue;
				case 74u:
					Form2.smethod_19((Control)(object)CheckUpBtn, new Size(306, 50));
					num = (int)(num2 * 968692226) ^ -1149986204;
					continue;
				case 73u:
					Form2.smethod_18((Control)(object)UpdateDetailsBtn, "UpdateDetailsBtn");
					Form2.smethod_19((Control)(object)UpdateDetailsBtn, new Size(306, 50));
					num = (int)(num2 * 1111944848) ^ -1531579642;
					continue;
				case 72u:
					num = (int)((num2 * 144255488) ^ 0x5B401590);
					continue;
				case 71u:
					Form2.smethod_15((Control)(object)RegisterDonorBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 75524112) ^ 0x3B4CC376);
					continue;
				case 70u:
					num = (int)(num2 * 2037196120) ^ -831866648;
					continue;
				case 69u:
					num = ((int)num2 * -1370930542) ^ 0x4616DF73;
					continue;
				case 68u:
					GroupBox2 = Form2.smethod_6();
					CheckUpBtn = Form2.smethod_7();
					num = ((int)num2 * -551096251) ^ 0x3C163FAA;
					continue;
				case 67u:
					num = (int)(num2 * 1296917737) ^ -163992786;
					continue;
				case 66u:
					num = (int)((num2 * 1999424558) ^ 0x3A90ACA6);
					continue;
				case 65u:
					num = ((int)num2 * -876516215) ^ 0x707BE4F1;
					continue;
				case 64u:
					num = (int)(num2 * 1872578051) ^ -1531220722;
					continue;
				case 63u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)Panel1), (Control)(object)GroupBox3);
					Form2.smethod_25(Form2.smethod_24((Control)(object)Panel1), (Control)(object)GroupBox2);
					Form2.smethod_25(Form2.smethod_24((Control)(object)Panel1), (Control)(object)GroupBox4);
					num = ((int)num2 * -1082822934) ^ -460184586;
					continue;
				case 62u:
					Form2.smethod_17((Control)(object)PatientPanel1, new Point(6, 43));
					num = (int)(num2 * 1444251964) ^ -1826702248;
					continue;
				case 61u:
					num = ((int)num2 * -1310331101) ^ -239701782;
					continue;
				case 60u:
					num = ((int)num2 * -1953625182) ^ -469342795;
					continue;
				case 59u:
					num = (int)(num2 * 1490622300) ^ -762140794;
					continue;
				case 58u:
					num = ((int)num2 * -531130672) ^ -737930376;
					continue;
				case 57u:
					num = (int)((num2 * 806271457) ^ 0x71FA9A6);
					continue;
				case 56u:
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)BloodAvailabilityBtn), 0);
					num = (int)(num2 * 442006736) ^ -1138200035;
					continue;
				case 55u:
					Form2.smethod_20((Control)(object)StaffPanel, 3);
					num = (int)(num2 * 1885517653) ^ -166198624;
					continue;
				case 54u:
					Form2.smethod_17((Control)(object)RegisterDonorBtn, new Point(20, 38));
					num = ((int)num2 * -1019520954) ^ -1050355642;
					continue;
				case 53u:
					num = (int)((num2 * 736849266) ^ 0x3A7E6BC8);
					continue;
				case 52u:
					Form2.smethod_18((Control)(object)PersonalInfoPanel2, "PersonalInfoPanel2");
					num = (int)(num2 * 544515784) ^ -1714673870;
					continue;
				case 51u:
					Form2.smethod_32((ButtonBase)(object)BloodAvailabilityBtn, "Blood Availability");
					num = ((int)num2 * -1937128485) ^ 0x3931317A;
					continue;
				case 50u:
					Form2.smethod_19((Control)(object)RegisterDonorBtn, new Size(311, 50));
					num = (int)((num2 * 1205009369) ^ 0x1BDF71BF);
					continue;
				case 49u:
					Form2.smethod_31((Control)(object)LogoutBtn, new Padding(0));
					num = ((int)num2 * -1460476697) ^ 0x4F6A003C;
					continue;
				case 48u:
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)LogoutBtn), 0);
					num = (int)(num2 * 1938815986) ^ -913505601;
					continue;
				case 47u:
					num = ((int)num2 * -368576655) ^ -52735994;
					continue;
				case 46u:
					num = (int)((num2 * 2008989339) ^ 0x4274EF6D);
					continue;
				case 45u:
					Form2.smethod_17((Control)(object)PersonalInfoPanel2, new Point(307, 52));
					num = ((int)num2 * -637444471) ^ 0x30EBEE87;
					continue;
				case 44u:
					num = (int)((num2 * 1978799696) ^ 0x5A8632E7);
					continue;
				case 43u:
					num = (int)((num2 * 121578785) ^ 0x44D413C9);
					continue;
				case 42u:
					Form2.smethod_13((Control)(object)Panel1, Color.White);
					num = ((int)num2 * -714143311) ^ -2050784054;
					continue;
				case 41u:
					Form2.smethod_31((Control)(object)EditProfileBtn, new Padding(0));
					num = (int)((num2 * 1887404163) ^ 0x40178AAC);
					continue;
				case 40u:
					Form2.smethod_15((Control)(object)UpdateDetailsBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 345703478) ^ -1429915710;
					continue;
				case 39u:
					num = (int)((num2 * 503890772) ^ 0x2025DA04);
					continue;
				case 38u:
					Form2.smethod_18((Control)(object)GroupBox5, "GroupBox5");
					num = ((int)num2 * -88914297) ^ -770566089;
					continue;
				case 37u:
					Form2.smethod_46((Form)(object)this, "Form2");
					Form2.smethod_47((Form)(object)this, (FormWindowState)2);
					Form2.smethod_48((Control)(object)Panel1, bool_0: false);
					num = ((int)num2 * -1733405339) ^ 0x6A377A5E;
					continue;
				case 36u:
					Form2.smethod_32((ButtonBase)(object)RegistrationBtn, "Registration");
					num = ((int)num2 * -1221090983) ^ 0x4DA75CAD;
					continue;
				case 35u:
					Form2.smethod_26(GroupBox5, bool_0: false);
					num = ((int)num2 * -1549803712) ^ -1385177569;
					continue;
				case 34u:
					Form2.smethod_15((Control)(object)RegistrationBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 394986685) ^ 0x67C12B3D);
					continue;
				case 33u:
					Form2.smethod_20((Control)(object)GroupBox5, 12);
					num = (int)(num2 * 1984376533) ^ -1099818770;
					continue;
				case 32u:
					Form2.smethod_19((Control)(object)PictureBox1, new Size(106, 103));
					num = (int)(num2 * 1597637235) ^ -1910619140;
					continue;
				case 31u:
					Form2.smethod_18((Control)(object)CheckUpBtn, "CheckUpBtn");
					num = (int)((num2 * 658069588) ^ 0x3A810F6C);
					continue;
				case 30u:
					Form2.smethod_20((Control)(object)RegistrationBtn, 1);
					num = ((int)num2 * -310201882) ^ -840148203;
					continue;
				case 29u:
					Form2.smethod_19((Control)(object)GroupBox5, new Size(351, 173));
					num = (int)(num2 * 1934391663) ^ -1807059125;
					continue;
				case 28u:
					num = ((int)num2 * -472342758) ^ 0x1D6B476F;
					continue;
				case 27u:
					Form2.smethod_33((ButtonBase)(object)RegistrationBtn, bool_0: false);
					num = (int)(num2 * 560910602) ^ -2017842708;
					continue;
				case 26u:
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)RegisterRecieverBtn), 0);
					num = (int)(num2 * 470789273) ^ -1247379644;
					continue;
				case 25u:
					Form2.smethod_48((Control)(object)GroupBox4, bool_0: false);
					num = ((int)num2 * -215764783) ^ 0x7F3A59D6;
					continue;
				case 24u:
					RegisterDonorBtn = Form2.smethod_7();
					num = (int)(num2 * 1379732572) ^ -247662439;
					continue;
				case 23u:
					num = (int)(num2 * 784461339) ^ -926488873;
					continue;
				case 22u:
					Form2.smethod_32((ButtonBase)(object)UpdateDetailsBtn, "Update Details");
					Form2.smethod_33((ButtonBase)(object)UpdateDetailsBtn, bool_0: true);
					num = ((int)num2 * -438813817) ^ 0x4742461B;
					continue;
				case 21u:
					Form2.smethod_15((Control)(object)GroupBox2, Form2.smethod_14("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 2078532198) ^ 0x4BD3FC5D);
					continue;
				case 20u:
					Form2.smethod_17((Control)(object)StaffPanel2, new Point(307, 37));
					num = (int)((num2 * 1728361964) ^ 0x2C255DC9);
					continue;
				case 19u:
					num = (int)(num2 * 1526717866) ^ -1660587546;
					continue;
				case 18u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox4), (Control)(object)RegisterRecieverBtn);
					num = ((int)num2 * -1445462153) ^ 0x6AA0B733;
					continue;
				case 17u:
					Form2.smethod_34((ButtonBase)(object)RegistrationBtn, Color.White);
					num = (int)((num2 * 1422139060) ^ 0x57A220B);
					continue;
				case 16u:
					Form2.smethod_32((ButtonBase)(object)AdmitBtn, "Admit/Discharge");
					num = ((int)num2 * -1757107348) ^ 0xE6A5103;
					continue;
				case 15u:
					num = ((int)num2 * -387569772) ^ -2125439771;
					continue;
				case 14u:
					Form2.smethod_27(GroupBox4, "Blood Bank");
					num = ((int)num2 * -321525856) ^ 0x41DA7AAE;
					continue;
				case 13u:
					num = (int)((num2 * 1606655514) ^ 0x4E47ABE4);
					continue;
				case 12u:
					Form2.smethod_19((Control)(object)BloodBankPanel2, new Size(44, 50));
					num = (int)(num2 * 1507157741) ^ -2002718511;
					continue;
				case 11u:
					num = (int)((num2 * 1831097502) ^ 0x785D5A77);
					continue;
				case 10u:
					Form2.smethod_18((Control)(object)StaffPanel, "StaffPanel");
					num = ((int)num2 * -1125332171) ^ 0x359133DE;
					continue;
				case 9u:
					BloodBankPanel2 = Form2.smethod_5();
					num = ((int)num2 * -1377252513) ^ -1095171939;
					continue;
				case 8u:
					Form2.smethod_12(Label1, bool_0: true);
					num = ((int)num2 * -1119551665) ^ -698419912;
					continue;
				case 7u:
					Form2.smethod_30((ButtonBase)(object)CheckUpBtn, (FlatStyle)0);
					Form2.smethod_15((Control)(object)CheckUpBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Form2.smethod_17((Control)(object)CheckUpBtn, new Point(25, 96));
					num = (int)(num2 * 2025447404) ^ -1044307413;
					continue;
				case 6u:
					Form2.smethod_38(PictureBox1, bool_0: false);
					Form2.smethod_39((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = (int)(num2 * 238776828) ^ -1376582087;
					continue;
				case 5u:
					Form2.smethod_11((Control)(object)this);
					num = ((int)num2 * -192718548) ^ -1557631518;
					continue;
				case 4u:
					RegistrationBtn = Form2.smethod_7();
					num = (int)((num2 * 380255262) ^ 0x7CFF674C);
					continue;
				case 3u:
					num = ((int)num2 * -2052177410) ^ -499351750;
					continue;
				case 2u:
					AdmitBtn = Form2.smethod_7();
					num = ((int)num2 * -1369353921) ^ -653976860;
					continue;
				case 1u:
					Form2.smethod_20((Control)(object)Label1, 2);
					Form2.smethod_21(Label1, "Golisano's Hospital Of Florida");
					num = ((int)num2 * -511352399) ^ -130067101;
					continue;
				case 0u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox2), (Control)(object)UpdateDetailsBtn);
					num = (int)(num2 * 1261869534) ^ -593366054;
					continue;
				default:
					return;
				case 272u:
					break;
				case 79u:
					return;
				}
				break;
			}
		}
	}

	private void CheckUpBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 2089725886;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4C85CEEDu) % 20u)
				{
				case 19u:
					Form2.smethod_13((Control)(object)BloodBankPanel1, Color.Transparent);
					num = (int)(num2 * 23542090) ^ -59322190;
					continue;
				case 18u:
					num = (int)(num2 * 845912464) ^ -821698003;
					continue;
				case 17u:
					num = ((int)num2 * -1649195999) ^ 0x494B694B;
					continue;
				case 16u:
					Form2.smethod_13((Control)(object)PatientPanel1, Color.DarkBlue);
					num = (int)(num2 * 290585652) ^ -1251621149;
					continue;
				case 15u:
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					num = ((int)num2 * -1059692443) ^ -942782807;
					continue;
				case 14u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.DarkBlue);
					num = (int)((num2 * 1269375200) ^ 0x4C9F955);
					continue;
				case 13u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					num = ((int)num2 * -407438337) ^ -1605417334;
					continue;
				case 12u:
					num = (int)((num2 * 1699561933) ^ 0x374263A8);
					continue;
				case 11u:
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.Transparent);
					num = ((int)num2 * -1011845185) ^ -668863499;
					continue;
				case 10u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = (int)((num2 * 1264202843) ^ 0x63DC808F);
					continue;
				case 8u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)(num2 * 255548701) ^ -67066529;
					continue;
				case 7u:
					num = (int)((num2 * 1449832675) ^ 0x1771492A);
					continue;
				case 6u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)StaffPanel), (Control)(object)new CheckUp());
					num = (int)(num2 * 1108970646) ^ -1032642161;
					continue;
				case 5u:
					Form2.smethod_55((Control)(object)PatientPanel1, Form2.smethod_54((Control)(object)CheckUpBtn));
					Form2.smethod_55((Control)(object)PatientPanel2, Form2.smethod_54((Control)(object)CheckUpBtn));
					num = (int)(num2 * 1180881151) ^ -362823302;
					continue;
				case 3u:
					num = ((int)num2 * -265052943) ^ 0x1ABFF737;
					continue;
				case 2u:
					num = (int)((num2 * 738140704) ^ 0x38E17393);
					continue;
				case 1u:
					num = (int)(num2 * 64858437) ^ -1250379521;
					continue;
				case 0u:
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					num = (int)(num2 * 452950340) ^ -51313782;
					continue;
				default:
					return;
				case 9u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void RegistrationBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -849652233;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA26C636Bu) % 15u)
				{
				case 14u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)(num2 * 818028145) ^ -1778874115;
					continue;
				case 13u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)StaffPanel), (Control)(object)new Registration());
					num = ((int)num2 * -1472373667) ^ 0x61ED674;
					continue;
				case 12u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					num = ((int)num2 * -1830236862) ^ -317736537;
					continue;
				case 11u:
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					num = (int)(num2 * 1902117674) ^ -1464819307;
					continue;
				case 10u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.Transparent);
					Form2.smethod_55((Control)(object)PatientPanel1, Form2.smethod_54((Control)(object)RegistrationBtn));
					num = (int)(num2 * 494638107) ^ -1916457785;
					continue;
				case 9u:
					num = (int)((num2 * 351748758) ^ 0x3FC4A418);
					continue;
				case 7u:
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.Transparent);
					num = (int)(num2 * 1980456282) ^ -1556378451;
					continue;
				case 5u:
					num = ((int)num2 * -143723704) ^ -82239863;
					continue;
				case 4u:
					Form2.smethod_13((Control)(object)PatientPanel1, Color.DarkBlue);
					num = (int)(num2 * 144617553) ^ -1210058466;
					continue;
				case 3u:
					num = ((int)num2 * -955782467) ^ 0x45E5BF86;
					continue;
				case 2u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.DarkBlue);
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					num = ((int)num2 * -209072239) ^ 0x16E320D6;
					continue;
				case 1u:
					Form2.smethod_13((Control)(object)BloodBankPanel1, Color.Transparent);
					num = (int)(num2 * 1735496558) ^ -389696191;
					continue;
				case 0u:
					Form2.smethod_55((Control)(object)PatientPanel2, Form2.smethod_54((Control)(object)RegistrationBtn));
					num = (int)((num2 * 2055337259) ^ 0x280D5240);
					continue;
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

	private void AdmitBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 730246833;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5988D4A8u) % 17u)
				{
				case 16u:
					num = (int)((num2 * 1782120618) ^ 0x7C4CDF86);
					continue;
				case 15u:
					num = (int)(num2 * 421324445) ^ -452369103;
					continue;
				case 14u:
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.Transparent);
					num = (int)(num2 * 1428849083) ^ -440220694;
					continue;
				case 12u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = ((int)num2 * -1769940) ^ -1929427220;
					continue;
				case 11u:
					num = ((int)num2 * -610326461) ^ 0x74DB41DD;
					continue;
				case 10u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.DarkBlue);
					num = ((int)num2 * -249975902) ^ 0x46D93324;
					continue;
				case 9u:
					num = (int)((num2 * 2109446885) ^ 0x6C111861);
					continue;
				case 8u:
					num = ((int)num2 * -923399452) ^ 0x5DE7B32B;
					continue;
				case 7u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)StaffPanel), (Control)(object)new Admit());
					num = ((int)num2 * -927301015) ^ -1971395812;
					continue;
				case 6u:
					Form2.smethod_55((Control)(object)PatientPanel1, Form2.smethod_54((Control)(object)AdmitBtn));
					Form2.smethod_55((Control)(object)PatientPanel2, Form2.smethod_54((Control)(object)AdmitBtn));
					Form2.smethod_13((Control)(object)PatientPanel1, Color.DarkBlue);
					num = (int)((num2 * 1588724480) ^ 0x46A7ADFA);
					continue;
				case 4u:
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					num = ((int)num2 * -248986679) ^ -391208005;
					continue;
				case 3u:
					Form2.smethod_13((Control)(object)BloodBankPanel1, Color.Transparent);
					num = ((int)num2 * -94928421) ^ -1210257260;
					continue;
				case 2u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)(num2 * 2060387999) ^ -723899340;
					continue;
				case 1u:
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					num = (int)((num2 * 1230882607) ^ 0x4FAF0123);
					continue;
				case 0u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					num = (int)((num2 * 1769426142) ^ 0x2C28C9A6);
					continue;
				default:
					return;
				case 5u:
					break;
				case 13u:
					return;
				}
				break;
			}
		}
	}

	private void UpdateDetailsBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1724533522;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x12475EADu) % 18u)
				{
				case 17u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)StaffPanel), (Control)(object)new UpdateDetails());
					num = ((int)num2 * -1851631555) ^ 0x2A85BA20;
					continue;
				case 16u:
					num = (int)((num2 * 415923542) ^ 0x1BFA8C3F);
					continue;
				case 15u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.DarkBlue);
					num = (int)((num2 * 1158476325) ^ 0x2AC25A5D);
					continue;
				case 13u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					num = ((int)num2 * -1560198139) ^ -396793758;
					continue;
				case 12u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)(num2 * 10072256) ^ -1380663007;
					continue;
				case 10u:
					Form2.smethod_55((Control)(object)PatientPanel2, Form2.smethod_54((Control)(object)UpdateDetailsBtn));
					num = ((int)num2 * -495708107) ^ 0xF824A72;
					continue;
				case 9u:
					num = ((int)num2 * -1432671586) ^ -299832461;
					continue;
				case 8u:
					Form2.smethod_55((Control)(object)PatientPanel1, Form2.smethod_54((Control)(object)UpdateDetailsBtn));
					num = (int)(num2 * 470811185) ^ -628534976;
					continue;
				case 7u:
					Form2.smethod_13((Control)(object)PatientPanel1, Color.DarkBlue);
					num = (int)(num2 * 407086949) ^ -383773609;
					continue;
				case 6u:
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					num = (int)(num2 * 805750508) ^ -343377278;
					continue;
				case 5u:
					num = (int)(num2 * 1252454910) ^ -664933657;
					continue;
				case 4u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = ((int)num2 * -1941726517) ^ 0x3DE3B72F;
					continue;
				case 3u:
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.Transparent);
					num = ((int)num2 * -257566116) ^ -1360798523;
					continue;
				case 2u:
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					num = ((int)num2 * -124442932) ^ 0x582C42F1;
					continue;
				case 1u:
					Form2.smethod_13((Control)(object)BloodBankPanel1, Color.Transparent);
					num = (int)((num2 * 904101639) ^ 0x618EE777);
					continue;
				case 0u:
					num = (int)((num2 * 1181747202) ^ 0x5E55E450);
					continue;
				default:
					return;
				case 11u:
					break;
				case 14u:
					return;
				}
				break;
			}
		}
	}

	private void RegisterRecieverBtn_Click(object sender, EventArgs e)
	{
		Form2.smethod_13((Control)(object)PatientPanel1, Color.Transparent);
		while (true)
		{
			int num = -374762837;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x92073B31u) % 14u)
				{
				case 13u:
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					num = ((int)num2 * -1799811220) ^ 0x1B095CD6;
					continue;
				case 10u:
					Form2.smethod_55((Control)(object)BloodBankPanel1, Form2.smethod_54((Control)(object)RegisterRecieverBtn));
					Form2.smethod_55((Control)(object)BloodBankPanel2, Form2.smethod_54((Control)(object)RegisterRecieverBtn));
					Form2.smethod_13((Control)(object)BloodBankPanel1, Color.DarkBlue);
					num = ((int)num2 * -1990164449) ^ -649274278;
					continue;
				case 9u:
					num = ((int)num2 * -1875352706) ^ 0x39AA0144;
					continue;
				case 8u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.Transparent);
					num = ((int)num2 * -1966962038) ^ -459837713;
					continue;
				case 7u:
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.DarkBlue);
					num = ((int)num2 * -711372151) ^ -1604685284;
					continue;
				case 6u:
					num = ((int)num2 * -205272172) ^ -746079365;
					continue;
				case 5u:
					num = ((int)num2 * -53506497) ^ 0x569F66DB;
					continue;
				case 4u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = (int)(num2 * 1012749358) ^ -1092718549;
					continue;
				case 3u:
					num = (int)(num2 * 1315329437) ^ -857825708;
					continue;
				case 2u:
					num = ((int)num2 * -2126991214) ^ 0xE86441C;
					continue;
				case 1u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = ((int)num2 * -943033388) ^ -224840396;
					continue;
				case 0u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					num = (int)((num2 * 1969519537) ^ 0x6E3B0078);
					continue;
				case 12u:
					break;
				default:
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					Form2.smethod_25(Form2.smethod_24((Control)(object)StaffPanel), (Control)(object)new RegisterReciever());
					return;
				}
				break;
			}
		}
	}

	private void AvailabilityBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -32569454;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD76A5C64u) % 11u)
				{
				case 10u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.Transparent);
					Form2.smethod_13((Control)(object)BloodBankPanel1, Color.Transparent);
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.Transparent);
					num = ((int)num2 * -836852723) ^ 0x5C9A3F32;
					continue;
				case 9u:
					Form2.smethod_13((Control)(object)StaffPanel2, Color.DarkBlue);
					num = (int)((num2 * 184161757) ^ 0x19D97733);
					continue;
				case 8u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.DarkBlue);
					num = (int)((num2 * 1676062518) ^ 0x5E99AB9E);
					continue;
				case 6u:
					num = (int)(num2 * 1514627728) ^ -557180475;
					continue;
				case 5u:
					Form2.smethod_13((Control)(object)PatientPanel1, Color.Transparent);
					num = ((int)num2 * -1335602788) ^ -247178749;
					continue;
				case 3u:
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					num = ((int)num2 * -2006214504) ^ 0x57DE0E2B;
					continue;
				case 2u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = (int)((num2 * 947230729) ^ 0x33BCB758);
					continue;
				case 1u:
					num = ((int)num2 * -1457543382) ^ -2111896383;
					continue;
				case 0u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)(num2 * 253606398) ^ -1804476498;
					continue;
				case 7u:
					break;
				default:
					Form2.smethod_25(Form2.smethod_24((Control)(object)StaffPanel), (Control)(object)new Availability());
					return;
				}
				break;
			}
		}
	}

	private void RegisterDonorBtn_Click(object sender, EventArgs e)
	{
		Form2.smethod_13((Control)(object)PatientPanel1, Color.Transparent);
		while (true)
		{
			int num = -48654005;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA115A6EAu) % 15u)
				{
				case 14u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.Transparent);
					num = ((int)num2 * -251494753) ^ -696009704;
					continue;
				case 13u:
					num = ((int)num2 * -1332130588) ^ -1490484228;
					continue;
				case 11u:
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					Form2.smethod_25(Form2.smethod_24((Control)(object)StaffPanel), (Control)(object)new RegisterDonor());
					num = ((int)num2 * -1703995758) ^ 0x59404DDD;
					continue;
				case 10u:
					num = ((int)num2 * -1392286468) ^ 0x7483A165;
					continue;
				case 9u:
					num = ((int)num2 * -709774378) ^ -1953138770;
					continue;
				case 8u:
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.DarkBlue);
					num = ((int)num2 * -1605398729) ^ 0x7DCE26E;
					continue;
				case 7u:
					Form2.smethod_13((Control)(object)BloodBankPanel1, Color.DarkBlue);
					num = ((int)num2 * -789790749) ^ 0x371DD014;
					continue;
				case 6u:
					num = ((int)num2 * -166699619) ^ -1653270333;
					continue;
				case 5u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.Transparent);
					Form2.smethod_55((Control)(object)BloodBankPanel1, Form2.smethod_54((Control)(object)RegisterDonorBtn));
					Form2.smethod_55((Control)(object)BloodBankPanel2, Form2.smethod_54((Control)(object)RegisterDonorBtn));
					num = (int)(num2 * 273589199) ^ -2116543304;
					continue;
				case 4u:
					num = (int)(num2 * 596192367) ^ -1677754311;
					continue;
				case 3u:
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					num = ((int)num2 * -2066045097) ^ 0x31E5470;
					continue;
				case 2u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)((num2 * 1774256290) ^ 0x3A1DC4C4);
					continue;
				case 0u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					num = (int)(num2 * 475378825) ^ -574272515;
					continue;
				default:
					return;
				case 12u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private void BloodAvailabilityBtn_Click(object sender, EventArgs e)
	{
		Form2.smethod_13((Control)(object)PatientPanel1, Color.Transparent);
		while (true)
		{
			int num = -1470639473;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD02F25ADu) % 19u)
				{
				case 18u:
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					num = ((int)num2 * -575924010) ^ 0x372183E6;
					continue;
				case 17u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)((num2 * 87347800) ^ 0xFA63A00);
					continue;
				case 16u:
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.DarkBlue);
					num = (int)(num2 * 1712907131) ^ -157871504;
					continue;
				case 15u:
					num = ((int)num2 * -2047725025) ^ 0x34426008;
					continue;
				case 14u:
					num = ((int)num2 * -1064324894) ^ -121164978;
					continue;
				case 13u:
					Form2.smethod_55((Control)(object)BloodBankPanel2, Form2.smethod_54((Control)(object)BloodAvailabilityBtn));
					num = (int)((num2 * 1217354512) ^ 0x53B44F88);
					continue;
				case 12u:
					num = ((int)num2 * -938744794) ^ -241733959;
					continue;
				case 11u:
					num = ((int)num2 * -1101148414) ^ 0x74EB321A;
					continue;
				case 10u:
					Form2.smethod_55((Control)(object)BloodBankPanel1, Form2.smethod_54((Control)(object)BloodAvailabilityBtn));
					num = ((int)num2 * -1050130950) ^ -1300021070;
					continue;
				case 8u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.Transparent);
					num = (int)(num2 * 1678680093) ^ -2065488182;
					continue;
				case 7u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = ((int)num2 * -974525473) ^ -146433123;
					continue;
				case 6u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					num = (int)(num2 * 2004941136) ^ -192114982;
					continue;
				case 5u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)StaffPanel), (Control)(object)new BloodAvailability());
					num = (int)((num2 * 986314619) ^ 0x26BD69B2);
					continue;
				case 4u:
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					num = ((int)num2 * -1046955217) ^ 0x4506619F;
					continue;
				case 3u:
					num = ((int)num2 * -1738060867) ^ -1436722121;
					continue;
				case 2u:
					num = (int)((num2 * 728264177) ^ 0x2607BF9B);
					continue;
				case 1u:
					Form2.smethod_13((Control)(object)BloodBankPanel1, Color.DarkBlue);
					num = (int)((num2 * 2145721739) ^ 0x67119D5B);
					continue;
				default:
					return;
				case 0u:
					break;
				case 9u:
					return;
				}
				break;
			}
		}
	}

	private void EditProfileBtn_Click(object sender, EventArgs e)
	{
		Form2.smethod_13((Control)(object)PatientPanel1, Color.Transparent);
		while (true)
		{
			int num = 1208861599;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6E0CD778u) % 14u)
				{
				case 13u:
					Form2.smethod_55((Control)(object)PersonalInfoPanel2, Form2.smethod_54((Control)(object)EditProfileBtn));
					num = (int)((num2 * 533277722) ^ 0x3DD3FBC1);
					continue;
				case 12u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.DarkBlue);
					num = ((int)num2 * -469356489) ^ 0x632C8CA;
					continue;
				case 11u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.DarkBlue);
					num = (int)(num2 * 711528392) ^ -409111732;
					continue;
				case 10u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.Transparent);
					num = ((int)num2 * -2060309996) ^ 0x195BF333;
					continue;
				case 9u:
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.Transparent);
					num = ((int)num2 * -287683204) ^ -486510838;
					continue;
				case 8u:
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					num = (int)((num2 * 1425893650) ^ 0x106C28DF);
					continue;
				case 7u:
					Form2.smethod_55((Control)(object)PersonalInfoPanel1, Form2.smethod_54((Control)(object)EditProfileBtn));
					num = ((int)num2 * -1231865806) ^ -2102921379;
					continue;
				case 6u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)StaffPanel), (Control)(object)new EditProfile());
					num = (int)(num2 * 873862605) ^ -289916161;
					continue;
				case 4u:
					num = ((int)num2 * -2016495890) ^ -590833959;
					continue;
				case 3u:
					Form2.smethod_13((Control)(object)BloodBankPanel1, Color.Transparent);
					num = ((int)num2 * -412501794) ^ -725253144;
					continue;
				case 2u:
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					num = ((int)num2 * -379405012) ^ 0x2D3C2CBC;
					continue;
				case 1u:
					num = (int)((num2 * 1931046103) ^ 0x2229B407);
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

	private void LogoutBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1342366069;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE042A0C0u) % 21u)
				{
				case 20u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.Transparent);
					Form2.smethod_13((Control)(object)BloodBankPanel1, Color.Transparent);
					num = ((int)num2 * -562198889) ^ -302659483;
					continue;
				case 19u:
					num = (int)((num2 * 1618855026) ^ 0x714EBFB0);
					continue;
				case 18u:
					num = ((int)num2 * -869318783) ^ -1196916391;
					continue;
				case 17u:
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					num = (int)((num2 * 1174681741) ^ 0x3840DC9A);
					continue;
				case 16u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					num = (int)((num2 * 1403006409) ^ 0x7CD77F4D);
					continue;
				case 15u:
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.Transparent);
					num = ((int)num2 * -1461949120) ^ -2041908175;
					continue;
				case 14u:
					Form2.smethod_55((Control)(object)PersonalInfoPanel2, Form2.smethod_54((Control)(object)LogoutBtn));
					num = ((int)num2 * -99296815) ^ -1223995768;
					continue;
				case 13u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.DarkBlue);
					num = ((int)num2 * -1298960609) ^ 0x1DDE0C4D;
					continue;
				case 12u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.DarkBlue);
					num = ((int)num2 * -1880289755) ^ 0x7AC30AD4;
					continue;
				case 11u:
					MyProject.Forms.Form1.username = "";
					num = ((int)num2 * -337194539) ^ 0x560A48BE;
					continue;
				case 10u:
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					num = ((int)num2 * -1228158606) ^ 0x72CD8A4D;
					continue;
				case 9u:
					Form2.smethod_58((Control)(object)MyProject.Forms.Form1);
					num = (int)(num2 * 63375894) ^ -1171915667;
					continue;
				case 8u:
					MyProject.Forms.Form1.login_type = "";
					num = ((int)num2 * -386748245) ^ 0x76927D18;
					continue;
				case 7u:
					num = ((int)num2 * -2070440062) ^ -973014459;
					continue;
				case 6u:
					num = ((int)num2 * -1875849137) ^ -661966080;
					continue;
				case 5u:
					Form2.smethod_55((Control)(object)PersonalInfoPanel1, Form2.smethod_54((Control)(object)LogoutBtn));
					num = (int)(num2 * 1129353695) ^ -368979233;
					continue;
				case 3u:
					Form2.smethod_57((Form)(object)this);
					num = ((int)num2 * -743250574) ^ -317496257;
					continue;
				case 1u:
					Form2.smethod_13((Control)(object)PatientPanel1, Color.Transparent);
					num = ((int)num2 * -1159121008) ^ 0x2A1BF4B1;
					continue;
				case 0u:
					num = (int)(num2 * 1958596326) ^ -774377101;
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

	private void Form2_FormClosed(object sender, FormClosedEventArgs e)
	{
		MyProject.Forms.Form1.username = "";
		MyProject.Forms.Form1.login_type = "";
		Form2.smethod_58((Control)(object)MyProject.Forms.Form1);
	}

	private void Form2_Shown(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1939317078;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3891EAE3u) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0003:
				Form2.smethod_59((Control)(object)this);
				num = ((int)num2 * -622318445) ^ -648994357;
			}
		}
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -376350312;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8EC6A875u) % 4u)
				{
				case 3u:
					Form2.smethod_61((Form)(object)this, (AutoSizeMode)0);
					num = (int)((num2 * 764936583) ^ 0x7559C51C);
					continue;
				case 1u:
					Form2.smethod_60((Form)(object)this, bool_0: true);
					num = ((int)num2 * -1000489553) ^ 0xDCE0D7D;
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

	static void smethod_0(Form form_0, FormClosedEventHandler formClosedEventHandler_0)
	{
		form_0.add_FormClosed(formClosedEventHandler_0);
	}

	static void smethod_1(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Shown(eventHandler_0);
	}

	static void smethod_2(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static void smethod_3(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Label smethod_4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static Panel smethod_5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Panel();
	}

	static GroupBox smethod_6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new GroupBox();
	}

	static Button smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
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

	static void smethod_12(Label label_0, bool bool_0)
	{
		label_0.set_AutoSize(bool_0);
	}

	static void smethod_13(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
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

	static void smethod_16(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
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

	static void smethod_23(ScrollableControl scrollableControl_0, bool bool_0)
	{
		scrollableControl_0.set_AutoScroll(bool_0);
	}

	static ControlCollection smethod_24(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_25(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_26(GroupBox groupBox_0, bool bool_0)
	{
		groupBox_0.set_TabStop(bool_0);
	}

	static void smethod_27(GroupBox groupBox_0, string string_0)
	{
		groupBox_0.set_Text(string_0);
	}

	static FlatButtonAppearance smethod_28(ButtonBase buttonBase_0)
	{
		return buttonBase_0.get_FlatAppearance();
	}

	static void smethod_29(FlatButtonAppearance flatButtonAppearance_0, int int_0)
	{
		flatButtonAppearance_0.set_BorderSize(int_0);
	}

	static void smethod_30(ButtonBase buttonBase_0, FlatStyle flatStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		buttonBase_0.set_FlatStyle(flatStyle_0);
	}

	static void smethod_31(Control control_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Margin(padding_0);
	}

	static void smethod_32(ButtonBase buttonBase_0, string string_0)
	{
		buttonBase_0.set_Text(string_0);
	}

	static void smethod_33(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_34(ButtonBase buttonBase_0, Color color_0)
	{
		buttonBase_0.set_BackColor(color_0);
	}

	static void smethod_35(PictureBox pictureBox_0, Image image_0)
	{
		pictureBox_0.set_Image(image_0);
	}

	static void smethod_36(PictureBox pictureBox_0, PictureBoxSizeMode pictureBoxSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		pictureBox_0.set_SizeMode(pictureBoxSizeMode_0);
	}

	static void smethod_37(PictureBox pictureBox_0, int int_0)
	{
		pictureBox_0.set_TabIndex(int_0);
	}

	static void smethod_38(PictureBox pictureBox_0, bool bool_0)
	{
		pictureBox_0.set_TabStop(bool_0);
	}

	static void smethod_39(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_40(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_41(Form form_0, Color color_0)
	{
		form_0.set_BackColor(color_0);
	}

	static void smethod_42(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_43(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_44(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_45(Form form_0, SizeGripStyle sizeGripStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_SizeGripStyle(sizeGripStyle_0);
	}

	static void smethod_46(Form form_0, string string_0)
	{
		form_0.set_Text(string_0);
	}

	static void smethod_47(Form form_0, FormWindowState formWindowState_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_WindowState(formWindowState_0);
	}

	static void smethod_48(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_49(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_50(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_51(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_52(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_53(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static int smethod_54(Control control_0)
	{
		return control_0.get_Top();
	}

	static void smethod_55(Control control_0, int int_0)
	{
		control_0.set_Top(int_0);
	}

	static void smethod_56(ControlCollection controlCollection_0)
	{
		controlCollection_0.Clear();
	}

	static void smethod_57(Form form_0)
	{
		form_0.Close();
	}

	static void smethod_58(Control control_0)
	{
		control_0.Show();
	}

	static void smethod_59(Control control_0)
	{
		control_0.Refresh();
	}

	static void smethod_60(Form form_0, bool bool_0)
	{
		form_0.set_AutoSize(bool_0);
	}

	static void smethod_61(Form form_0, AutoSizeMode autoSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_AutoSizeMode(autoSizeMode_0);
	}
}
