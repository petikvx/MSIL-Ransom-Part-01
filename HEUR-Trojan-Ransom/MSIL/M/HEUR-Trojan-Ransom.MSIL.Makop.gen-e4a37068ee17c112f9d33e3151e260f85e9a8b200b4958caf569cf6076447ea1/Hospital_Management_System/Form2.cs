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
			Button logoutBtn = default(Button);
			while (true)
			{
				int num = -1004981676;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFD01B494u) % 9u)
					{
					case 8u:
						logoutBtn = _LogoutBtn;
						num = (int)(num2 * 889117626) ^ -1867570187;
						continue;
					case 7u:
					{
						int num5;
						int num6;
						if (logoutBtn != null)
						{
							num5 = -1223140392;
							num6 = -1223140392;
						}
						else
						{
							num5 = -1182636822;
							num6 = -1182636822;
						}
						num = num5 ^ ((int)num2 * -330086246);
						continue;
					}
					case 6u:
						Form2.smethod_53((Control)(object)logoutBtn, eventHandler_);
						num = (int)((num2 * 1777056765) ^ 0x3161D754);
						continue;
					case 4u:
						Form2.smethod_52((Control)(object)logoutBtn, eventHandler_);
						num = (int)(num2 * 720548774) ^ -193971212;
						continue;
					case 3u:
						_LogoutBtn = value;
						num = -1441276309;
						continue;
					case 2u:
						logoutBtn = _LogoutBtn;
						num = ((int)num2 * -625342977) ^ -1016314132;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (logoutBtn == null)
						{
							num3 = -1958781272;
							num4 = -1958781272;
						}
						else
						{
							num3 = -1479713124;
							num4 = -1479713124;
						}
						num = num3 ^ (int)(num2 * 1117947229);
						continue;
					}
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
				int num = -300438587;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFA6362A7u) % 8u)
					{
					case 7u:
						editProfileBtn = _EditProfileBtn;
						num = (int)(num2 * 215693699) ^ -868883981;
						continue;
					case 5u:
						_EditProfileBtn = value;
						num = -378325432;
						continue;
					case 4u:
						Form2.smethod_53((Control)(object)editProfileBtn, eventHandler_);
						num = ((int)num2 * -217865641) ^ -2113341875;
						continue;
					case 3u:
						Form2.smethod_52((Control)(object)editProfileBtn, eventHandler_);
						num = (int)(num2 * 642433045) ^ -1191836339;
						continue;
					case 2u:
					{
						editProfileBtn = _EditProfileBtn;
						int num5;
						int num6;
						if (editProfileBtn != null)
						{
							num5 = 1156532948;
							num6 = 1156532948;
						}
						else
						{
							num5 = 1328375810;
							num6 = 1328375810;
						}
						num = num5 ^ (int)(num2 * 931372888);
						continue;
					}
					case 1u:
					{
						int num3;
						int num4;
						if (editProfileBtn != null)
						{
							num3 = 1940675900;
							num4 = 1940675900;
						}
						else
						{
							num3 = 1000107790;
							num4 = 1000107790;
						}
						num = num3 ^ (int)(num2 * 1188965455);
						continue;
					}
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
			Button availabilityBtn = default(Button);
			while (true)
			{
				int num = -512341137;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x976DAC64u) % 6u)
					{
					case 5u:
						Form2.smethod_52((Control)(object)availabilityBtn, eventHandler_);
						num = (int)((num2 * 1497168036) ^ 0x1107FEBB);
						continue;
					case 3u:
					{
						availabilityBtn = _AvailabilityBtn;
						int num4;
						int num5;
						if (availabilityBtn != null)
						{
							num4 = 336754834;
							num5 = 336754834;
						}
						else
						{
							num4 = 519321332;
							num5 = 519321332;
						}
						num = num4 ^ ((int)num2 * -332983887);
						continue;
					}
					case 2u:
						Form2.smethod_53((Control)(object)availabilityBtn, eventHandler_);
						num = ((int)num2 * -1931362679) ^ 0x5245E18A;
						continue;
					case 1u:
					{
						_AvailabilityBtn = value;
						availabilityBtn = _AvailabilityBtn;
						int num3;
						if (availabilityBtn == null)
						{
							num = -989496468;
							num3 = -989496468;
						}
						else
						{
							num = -1903610286;
							num3 = -1903610286;
						}
						continue;
					}
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
				int num = 178193228;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6EDE343Au) % 7u)
					{
					case 6u:
						Form2.smethod_53((Control)(object)checkUpBtn, eventHandler_);
						num = (int)(num2 * 1205020764) ^ -1767730962;
						continue;
					case 5u:
						Form2.smethod_52((Control)(object)checkUpBtn, eventHandler_);
						num = ((int)num2 * -83537016) ^ -1507455883;
						continue;
					case 3u:
					{
						checkUpBtn = _CheckUpBtn;
						int num5;
						int num6;
						if (checkUpBtn == null)
						{
							num5 = 1960466188;
							num6 = 1960466188;
						}
						else
						{
							num5 = 107575823;
							num6 = 107575823;
						}
						num = num5 ^ ((int)num2 * -2091702298);
						continue;
					}
					case 2u:
						_CheckUpBtn = value;
						num = 1396749027;
						continue;
					case 1u:
					{
						checkUpBtn = _CheckUpBtn;
						int num3;
						int num4;
						if (checkUpBtn == null)
						{
							num3 = -492460105;
							num4 = -492460105;
						}
						else
						{
							num3 = -446922634;
							num4 = -446922634;
						}
						num = num3 ^ ((int)num2 * -1226577221);
						continue;
					}
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
			Button updateDetailsBtn = default(Button);
			while (true)
			{
				int num = -1678935692;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA16D5380u) % 7u)
					{
					case 6u:
					{
						int num4;
						int num5;
						if (updateDetailsBtn == null)
						{
							num4 = -1028743961;
							num5 = -1028743961;
						}
						else
						{
							num4 = -311456673;
							num5 = -311456673;
						}
						num = num4 ^ ((int)num2 * -580949271);
						continue;
					}
					case 5u:
						updateDetailsBtn = _UpdateDetailsBtn;
						num = (int)((num2 * 1687040466) ^ 0x5D2005B0);
						continue;
					case 4u:
						Form2.smethod_52((Control)(object)updateDetailsBtn, eventHandler_);
						num = (int)(num2 * 1031219847) ^ -122355058;
						continue;
					case 3u:
					{
						_UpdateDetailsBtn = value;
						updateDetailsBtn = _UpdateDetailsBtn;
						int num3;
						if (updateDetailsBtn != null)
						{
							num = -1217556155;
							num3 = -1217556155;
						}
						else
						{
							num = -454251941;
							num3 = -454251941;
						}
						continue;
					}
					case 1u:
						Form2.smethod_53((Control)(object)updateDetailsBtn, eventHandler_);
						num = (int)((num2 * 1416796215) ^ 0x69647A08);
						continue;
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
			Button admitBtn = _AdmitBtn;
			while (true)
			{
				int num = -214289240;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDA8B36D7u) % 6u)
					{
					case 5u:
					{
						int num4;
						int num5;
						if (admitBtn == null)
						{
							num4 = -972406537;
							num5 = -972406537;
						}
						else
						{
							num4 = -808866659;
							num5 = -808866659;
						}
						num = num4 ^ (int)(num2 * 1379642167);
						continue;
					}
					case 3u:
						Form2.smethod_52((Control)(object)admitBtn, eventHandler_);
						num = (int)(num2 * 1082883872) ^ -462691362;
						continue;
					case 2u:
						Form2.smethod_53((Control)(object)admitBtn, eventHandler_);
						num = ((int)num2 * -1813259575) ^ -825447339;
						continue;
					case 1u:
					{
						_AdmitBtn = value;
						admitBtn = _AdmitBtn;
						int num3;
						if (admitBtn != null)
						{
							num = -586296581;
							num3 = -586296581;
						}
						else
						{
							num = -1319750951;
							num3 = -1319750951;
						}
						continue;
					}
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
			Button registrationBtn = default(Button);
			while (true)
			{
				int num = 1923462518;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x253E6775u) % 7u)
					{
					case 6u:
						Form2.smethod_52((Control)(object)registrationBtn, eventHandler_);
						num = ((int)num2 * -213647311) ^ 0x4CAEAAD4;
						continue;
					case 5u:
						Form2.smethod_53((Control)(object)registrationBtn, eventHandler_);
						num = (int)((num2 * 946892012) ^ 0x3D719030);
						continue;
					case 2u:
					{
						int num5;
						int num6;
						if (registrationBtn == null)
						{
							num5 = 1357389802;
							num6 = 1357389802;
						}
						else
						{
							num5 = 1981500152;
							num6 = 1981500152;
						}
						num = num5 ^ ((int)num2 * -1017695161);
						continue;
					}
					case 1u:
					{
						registrationBtn = _RegistrationBtn;
						int num3;
						int num4;
						if (registrationBtn != null)
						{
							num3 = 1681151728;
							num4 = 1681151728;
						}
						else
						{
							num3 = 1823628929;
							num4 = 1823628929;
						}
						num = num3 ^ ((int)num2 * -1164030218);
						continue;
					}
					case 0u:
						_RegistrationBtn = value;
						registrationBtn = _RegistrationBtn;
						num = 588105671;
						continue;
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
				int num = -1726846943;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9C1E75D5u) % 9u)
					{
					case 8u:
						bloodAvailabilityBtn = _BloodAvailabilityBtn;
						num = ((int)num2 * -1525140256) ^ 0x33945045;
						continue;
					case 7u:
						_BloodAvailabilityBtn = value;
						num = -78846771;
						continue;
					case 6u:
						Form2.smethod_53((Control)(object)bloodAvailabilityBtn, eventHandler_);
						num = ((int)num2 * -446881777) ^ -721291323;
						continue;
					case 5u:
						Form2.smethod_52((Control)(object)bloodAvailabilityBtn, eventHandler_);
						num = ((int)num2 * -1183609162) ^ 0x380EA9B6;
						continue;
					case 4u:
					{
						int num5;
						int num6;
						if (bloodAvailabilityBtn == null)
						{
							num5 = -2056403902;
							num6 = -2056403902;
						}
						else
						{
							num5 = -224296533;
							num6 = -224296533;
						}
						num = num5 ^ ((int)num2 * -787686766);
						continue;
					}
					case 3u:
						bloodAvailabilityBtn = _BloodAvailabilityBtn;
						num = (int)((num2 * 616465255) ^ 0x28BD942D);
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (bloodAvailabilityBtn != null)
						{
							num3 = -1899227719;
							num4 = -1899227719;
						}
						else
						{
							num3 = -283717103;
							num4 = -283717103;
						}
						num = num3 ^ (int)(num2 * 398884163);
						continue;
					}
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
				int num = 111004187;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x37EF9CEu) % 8u)
					{
					case 7u:
						Form2.smethod_52((Control)(object)registerRecieverBtn, eventHandler_);
						num = (int)(num2 * 1595677225) ^ -1268920085;
						continue;
					case 5u:
						registerRecieverBtn = _RegisterRecieverBtn;
						num = ((int)num2 * -2112290748) ^ -1208431006;
						continue;
					case 4u:
						Form2.smethod_53((Control)(object)registerRecieverBtn, eventHandler_);
						num = (int)((num2 * 968755642) ^ 0x28856E2F);
						continue;
					case 3u:
					{
						registerRecieverBtn = _RegisterRecieverBtn;
						int num5;
						int num6;
						if (registerRecieverBtn != null)
						{
							num5 = 775236853;
							num6 = 775236853;
						}
						else
						{
							num5 = 703322688;
							num6 = 703322688;
						}
						num = num5 ^ ((int)num2 * -1137166691);
						continue;
					}
					case 2u:
						_RegisterRecieverBtn = value;
						num = 1277758477;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (registerRecieverBtn != null)
						{
							num3 = 1718297;
							num4 = 1718297;
						}
						else
						{
							num3 = 1460944004;
							num4 = 1460944004;
						}
						num = num3 ^ (int)(num2 * 404533296);
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
				int num = -1471426173;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB5034011u) % 8u)
					{
					case 7u:
						registerDonorBtn = _RegisterDonorBtn;
						num = ((int)num2 * -1309167262) ^ -1726436374;
						continue;
					case 6u:
						Form2.smethod_53((Control)(object)registerDonorBtn, eventHandler_);
						num = ((int)num2 * -1489531064) ^ -538311088;
						continue;
					case 5u:
					{
						int num5;
						int num6;
						if (registerDonorBtn != null)
						{
							num5 = 62446946;
							num6 = 62446946;
						}
						else
						{
							num5 = 99728965;
							num6 = 99728965;
						}
						num = num5 ^ ((int)num2 * -1545514751);
						continue;
					}
					case 4u:
						Form2.smethod_52((Control)(object)registerDonorBtn, eventHandler_);
						num = (int)((num2 * 1327755966) ^ 0x5BC447A1);
						continue;
					case 2u:
					{
						registerDonorBtn = _RegisterDonorBtn;
						int num3;
						int num4;
						if (registerDonorBtn != null)
						{
							num3 = -789280299;
							num4 = -789280299;
						}
						else
						{
							num3 = -1703471631;
							num4 = -1703471631;
						}
						num = num3 ^ ((int)num2 * -322481620);
						continue;
					}
					case 0u:
						_RegisterDonorBtn = value;
						num = -1679063538;
						continue;
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
			while (true)
			{
				int num = -248370394;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xC3ADA4AFu) % 6u)
					{
					case 5u:
						num = (int)((num2 * 394762201) ^ 0x9197730);
						continue;
					case 4u:
						if (components != null)
						{
							num = -535494312;
							num3 = -535494312;
							continue;
						}
						goto IL_0021;
					case 3u:
						if (disposing)
						{
							num = (int)((num2 * 23530480) ^ 0x32ED5E89);
							continue;
						}
						goto IL_0021;
					case 1u:
						Form2.smethod_3((IDisposable)components);
						num = (int)((num2 * 15201496) ^ 0x32D2CACC);
						continue;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
						IL_0021:
						num = -1334581405;
						num3 = -1334581405;
						continue;
					}
					break;
				}
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Unknown result type (might be due to invalid IL or missing references)
		//IL_08df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_154c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1596: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2064: Unknown result type (might be due to invalid IL or missing references)
		//IL_217d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2537: Unknown result type (might be due to invalid IL or missing references)
		Label1 = Form2.smethod_4();
		while (true)
		{
			int num = -1404176846;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9C132F6Bu) % 349u)
				{
				case 348u:
					Form2.smethod_31((Control)(object)RegisterDonorBtn, new Padding(0));
					num = ((int)num2 * -1147254090) ^ -1546614319;
					continue;
				case 347u:
					Form2.smethod_18((Control)(object)GroupBox2, "GroupBox2");
					num = ((int)num2 * -429249927) ^ 0x7D2F855;
					continue;
				case 346u:
					Form2.smethod_17((Control)(object)GroupBox3, new Point(13, 311));
					Form2.smethod_18((Control)(object)GroupBox3, "GroupBox3");
					num = (int)((num2 * 1031273601) ^ 0x3FD1CEC);
					continue;
				case 345u:
					Form2.smethod_19((Control)(object)PictureBox1, new Size(106, 103));
					num = (int)(num2 * 1693789684) ^ -1824957435;
					continue;
				case 344u:
					Form2.smethod_31((Control)(object)RegistrationBtn, new Padding(0));
					Form2.smethod_18((Control)(object)RegistrationBtn, "RegistrationBtn");
					num = (int)((num2 * 121303085) ^ 0x2A297621);
					continue;
				case 343u:
					Form2.smethod_33((ButtonBase)(object)CheckUpBtn, bool_0: true);
					num = (int)(num2 * 4316267) ^ -121394420;
					continue;
				case 342u:
					num = ((int)num2 * -1583180437) ^ -1251335791;
					continue;
				case 341u:
					num = ((int)num2 * -679508620) ^ 0xC194614;
					continue;
				case 340u:
					Form2.smethod_31((Control)(object)GroupBox2, new Padding(0));
					num = ((int)num2 * -1757876197) ^ 0x74533971;
					continue;
				case 339u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)Panel1), (Control)(object)GroupBox3);
					num = (int)((num2 * 801273170) ^ 0x224443D5);
					continue;
				case 338u:
					Form2.smethod_17((Control)(object)PersonalInfoPanel2, new Point(307, 52));
					num = (int)(num2 * 1678350477) ^ -1226414683;
					continue;
				case 337u:
					num = ((int)num2 * -1956352730) ^ 0x4C4FBA75;
					continue;
				case 336u:
					num = (int)((num2 * 1509055294) ^ 0x66E26C77);
					continue;
				case 335u:
					num = (int)((num2 * 1817113316) ^ 0x77A655C1);
					continue;
				case 334u:
					Form2.smethod_19((Control)(object)EditProfileBtn, new Size(311, 50));
					num = (int)((num2 * 508358177) ^ 0x7C222663);
					continue;
				case 333u:
					Form2.smethod_33((ButtonBase)(object)RegisterRecieverBtn, bool_0: true);
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)RegisterDonorBtn), 0);
					num = ((int)num2 * -1758380272) ^ 0x71CD13C1;
					continue;
				case 332u:
					Form2.smethod_26(GroupBox5, bool_0: false);
					num = (int)(num2 * 1861900714) ^ -259321090;
					continue;
				case 331u:
					num = ((int)num2 * -1553771985) ^ -350305026;
					continue;
				case 330u:
					Form2.smethod_20((Control)(object)CheckUpBtn, 2);
					num = ((int)num2 * -1083932646) ^ 0x796EB6F3;
					continue;
				case 329u:
					num = (int)(num2 * 798082527) ^ -1193290538;
					continue;
				case 328u:
					Form2.smethod_19((Control)(object)BloodBankPanel1, new Size(44, 50));
					num = (int)((num2 * 1405736102) ^ 0x533EFE24);
					continue;
				case 327u:
					Form2.smethod_33((ButtonBase)(object)EditProfileBtn, bool_0: true);
					num = ((int)num2 * -524248318) ^ -448385877;
					continue;
				case 326u:
					Form2.smethod_50((Control)(object)this, bool_0: false);
					num = (int)(num2 * 2078873316) ^ -1285634402;
					continue;
				case 325u:
					Form2.smethod_19((Control)(object)RegisterDonorBtn, new Size(311, 50));
					num = ((int)num2 * -6308989) ^ 0x8FF1A5B;
					continue;
				case 324u:
					Form2.smethod_19((Control)(object)StaffPanel2, new Size(44, 50));
					num = ((int)num2 * -922544779) ^ -1842676346;
					continue;
				case 323u:
					num = (int)(num2 * 1200733942) ^ -882984554;
					continue;
				case 322u:
					Form2.smethod_19((Control)(object)StaffPanel, new Size(977, 825));
					num = ((int)num2 * -557741194) ^ -722072401;
					continue;
				case 321u:
					num = ((int)num2 * -743814486) ^ -818268406;
					continue;
				case 320u:
					Form2.smethod_15((Control)(object)EditProfileBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Form2.smethod_17((Control)(object)EditProfileBtn, new Point(20, 52));
					num = ((int)num2 * -236041311) ^ 0xBFE5B17;
					continue;
				case 319u:
					num = ((int)num2 * -1543557880) ^ -495623613;
					continue;
				case 318u:
					num = ((int)num2 * -1938035727) ^ 0x624E7D4D;
					continue;
				case 317u:
					Form2.smethod_19((Control)(object)GroupBox2, new Size(351, 267));
					num = ((int)num2 * -1847125806) ^ 0xC7E5BD4;
					continue;
				case 316u:
					Form2.smethod_25(Form2.smethod_43((Control)(object)this), (Control)(object)StaffPanel);
					num = ((int)num2 * -696787204) ^ 0x4ABAC733;
					continue;
				case 315u:
					num = ((int)num2 * -858651417) ^ 0x28859837;
					continue;
				case 314u:
					num = ((int)num2 * -1455519958) ^ 0x35311FB0;
					continue;
				case 313u:
					Form2.smethod_15((Control)(object)UpdateDetailsBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1268389743) ^ -393125211;
					continue;
				case 312u:
					num = (int)((num2 * 555306393) ^ 0x6D38DE86);
					continue;
				case 311u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = ((int)num2 * -790308716) ^ 0x70C7A31A;
					continue;
				case 310u:
					Form2.smethod_9((Control)(object)Panel1);
					num = ((int)num2 * -427104781) ^ -1258216580;
					continue;
				case 309u:
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)UpdateDetailsBtn), 0);
					num = (int)(num2 * 1827912480) ^ -1820948505;
					continue;
				case 308u:
					Form2.smethod_30((ButtonBase)(object)LogoutBtn, (FlatStyle)0);
					num = (int)(num2 * 322789352) ^ -1354004141;
					continue;
				case 307u:
					Form2.smethod_19((Control)(object)RegistrationBtn, new Size(306, 50));
					num = (int)((num2 * 2037907177) ^ 0x43803769);
					continue;
				case 306u:
					num = ((int)num2 * -1105828613) ^ -1648603968;
					continue;
				case 305u:
					Form2.smethod_20((Control)(object)LogoutBtn, 6);
					num = ((int)num2 * -25267603) ^ -1347897418;
					continue;
				case 304u:
					num = ((int)num2 * -1709948228) ^ -1559471991;
					continue;
				case 303u:
					Form2.smethod_9((Control)(object)GroupBox5);
					num = (int)((num2 * 1278613176) ^ 0x63439EAA);
					continue;
				case 302u:
					Form2.smethod_18((Control)(object)PersonalInfoPanel1, "PersonalInfoPanel1");
					num = (int)((num2 * 54247209) ^ 0xD88CCC8);
					continue;
				case 301u:
					num = (int)(num2 * 221516483) ^ -424412976;
					continue;
				case 300u:
					Form2.smethod_27(GroupBox5, "Personal Info");
					num = (int)((num2 * 2127119564) ^ 0x70C5F2AC);
					continue;
				case 299u:
					Form2.smethod_32((ButtonBase)(object)RegistrationBtn, "Registration");
					num = (int)(num2 * 598711330) ^ -354311893;
					continue;
				case 298u:
					num = (int)((num2 * 758423196) ^ 0x75DA5CF9);
					continue;
				case 297u:
					Form2.smethod_17((Control)(object)RegisterRecieverBtn, new Point(20, 88));
					num = (int)((num2 * 1854648140) ^ 0x27D90CAC);
					continue;
				case 296u:
					Form2.smethod_40((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1148979285) ^ -402987748;
					continue;
				case 295u:
					Form2.smethod_17((Control)(object)BloodBankPanel1, new Point(0, 38));
					num = (int)((num2 * 1620745148) ^ 0x2D484734);
					continue;
				case 294u:
					Form2.smethod_15((Control)(object)GroupBox2, Form2.smethod_14("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1518840220) ^ 0x44EB1D1A);
					continue;
				case 293u:
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)EditProfileBtn), 0);
					Form2.smethod_30((ButtonBase)(object)EditProfileBtn, (FlatStyle)0);
					num = (int)((num2 * 2086077199) ^ 0xAD25F56);
					continue;
				case 292u:
					num = (int)(num2 * 1574251040) ^ -181335592;
					continue;
				case 291u:
					Form2.smethod_32((ButtonBase)(object)CheckUpBtn, "Check-Up");
					num = ((int)num2 * -307030012) ^ 0x18B88345;
					continue;
				case 290u:
					Form2.smethod_15((Control)(object)AvailabilityBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1288408487) ^ -1048518513;
					continue;
				case 289u:
					num = (int)((num2 * 694199565) ^ 0x12F321E);
					continue;
				case 288u:
					PatientPanel2 = Form2.smethod_5();
					PatientPanel1 = Form2.smethod_5();
					num = (int)((num2 * 114410711) ^ 0x7F5D37A9);
					continue;
				case 287u:
					num = (int)(num2 * 2092337212) ^ -563731902;
					continue;
				case 286u:
					Form2.smethod_36(PictureBox1, (PictureBoxSizeMode)1);
					num = ((int)num2 * -1924127099) ^ 0x529EAF78;
					continue;
				case 285u:
					RegistrationBtn = Form2.smethod_7();
					num = (int)((num2 * 2097965428) ^ 0x1FDC7353);
					continue;
				case 284u:
					Form2.smethod_48((Control)(object)GroupBox4, bool_0: false);
					num = (int)(num2 * 1653813693) ^ -57195584;
					continue;
				case 283u:
					Form2.smethod_31((Control)(object)AdmitBtn, new Padding(0));
					num = (int)((num2 * 782021012) ^ 0xBE73224);
					continue;
				case 282u:
					PersonalInfoPanel2 = Form2.smethod_5();
					num = ((int)num2 * -998851448) ^ -1510708869;
					continue;
				case 281u:
					Form2.smethod_19((Control)(object)UpdateDetailsBtn, new Size(306, 50));
					num = ((int)num2 * -374092167) ^ 0x1686D32F;
					continue;
				case 280u:
					Form2.smethod_17((Control)(object)Label1, new Point(428, 35));
					num = ((int)num2 * -1975081759) ^ 0x75628929;
					continue;
				case 279u:
					Form2.smethod_21(Label1, "Golisano's Hospital Of Florida");
					num = (int)(num2 * 618420014) ^ -390693876;
					continue;
				case 278u:
					num = (int)(num2 * 1375404656) ^ -2099706923;
					continue;
				case 277u:
					Form2.smethod_17((Control)(object)AvailabilityBtn, new Point(20, 37));
					Form2.smethod_31((Control)(object)AvailabilityBtn, new Padding(0));
					num = ((int)num2 * -1995224337) ^ 0x43F5D592;
					continue;
				case 276u:
					num = (int)(num2 * 680314840) ^ -1158022190;
					continue;
				case 275u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox5), (Control)(object)PersonalInfoPanel1);
					num = (int)((num2 * 1490111365) ^ 0x33394F24);
					continue;
				case 274u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox3), (Control)(object)StaffPanel2);
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox3), (Control)(object)StaffPanel1);
					Form2.smethod_15((Control)(object)GroupBox3, Form2.smethod_14("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1687926746) ^ 0x2822CE41;
					continue;
				case 273u:
					num = ((int)num2 * -1126677694) ^ -1672987387;
					continue;
				case 272u:
					num = (int)(num2 * 1572926722) ^ -1504593480;
					continue;
				case 271u:
					Form2.smethod_19((Control)(object)AdmitBtn, new Size(306, 50));
					Form2.smethod_20((Control)(object)AdmitBtn, 3);
					Form2.smethod_32((ButtonBase)(object)AdmitBtn, "Admit/Discharge");
					num = (int)(num2 * 37409244) ^ -770891163;
					continue;
				case 270u:
					num = ((int)num2 * -863320901) ^ 0x7E65040F;
					continue;
				case 269u:
					Form2.smethod_30((ButtonBase)(object)CheckUpBtn, (FlatStyle)0);
					num = ((int)num2 * -1950587606) ^ 0x64F4CCA1;
					continue;
				case 268u:
					num = ((int)num2 * -401879445) ^ -615787393;
					continue;
				case 267u:
					Form2.smethod_20((Control)(object)PatientPanel1, 0);
					num = (int)((num2 * 1732886871) ^ 0x4F17A575);
					continue;
				case 266u:
					Form2.smethod_13((Control)(object)StaffPanel, Color.White);
					Form2.smethod_17((Control)(object)StaffPanel, new Point(716, 141));
					num = (int)((num2 * 1936200602) ^ 0x1AE9A4DF);
					continue;
				case 265u:
					Form2.smethod_49((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -552219554) ^ 0x74E9991A;
					continue;
				case 264u:
					num = (int)(num2 * 628018575) ^ -1980314537;
					continue;
				case 263u:
					GroupBox5 = Form2.smethod_6();
					num = (int)((num2 * 1763479423) ^ 0x55D82F2C);
					continue;
				case 262u:
					Form2.smethod_39((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -713863888) ^ -758706636;
					continue;
				case 260u:
					Form2.smethod_19((Control)(object)PatientPanel2, new Size(44, 50));
					num = (int)((num2 * 611446169) ^ 0x120A04F6);
					continue;
				case 259u:
					Form2.smethod_17((Control)(object)CheckUpBtn, new Point(25, 96));
					num = ((int)num2 * -1582904690) ^ -1073214865;
					continue;
				case 258u:
					BloodBankPanel2 = Form2.smethod_5();
					num = (int)((num2 * 1471033799) ^ 0xB551BDC);
					continue;
				case 257u:
					Form2.smethod_13((Control)(object)GroupBox2, Color.White);
					num = ((int)num2 * -1348999838) ^ -1975041545;
					continue;
				case 256u:
					Form2.smethod_31((Control)(object)EditProfileBtn, new Padding(0));
					num = ((int)num2 * -2096578545) ^ 0x44815B6F;
					continue;
				case 255u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox3), (Control)(object)AvailabilityBtn);
					num = (int)(num2 * 1378718587) ^ -203525375;
					continue;
				case 254u:
					Form2.smethod_48((Control)(object)GroupBox3, bool_0: false);
					num = ((int)num2 * -1218194408) ^ -1512200180;
					continue;
				case 253u:
					num = (int)((num2 * 1115751340) ^ 0x7C73B0C5);
					continue;
				case 252u:
					num = (int)((num2 * 464479937) ^ 0x6D39C631);
					continue;
				case 251u:
					num = (int)(num2 * 168039574) ^ -1362471200;
					continue;
				case 250u:
					num = (int)((num2 * 1382742293) ^ 0x42B9D742);
					continue;
				case 249u:
					num = (int)(num2 * 449855095) ^ -1998076805;
					continue;
				case 248u:
					Form2.smethod_17((Control)(object)UpdateDetailsBtn, new Point(25, 196));
					num = ((int)num2 * -1066468543) ^ -1519065495;
					continue;
				case 247u:
					Form2.smethod_19((Control)(object)BloodBankPanel2, new Size(44, 50));
					Form2.smethod_20((Control)(object)BloodBankPanel2, 15);
					Form2.smethod_13((Control)(object)BloodBankPanel1, Color.Transparent);
					num = ((int)num2 * -197958420) ^ -810016927;
					continue;
				case 246u:
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)RegisterRecieverBtn), 0);
					num = ((int)num2 * -655381655) ^ -1486011593;
					continue;
				case 245u:
					Form2.smethod_18((Control)(object)AvailabilityBtn, "AvailabilityBtn");
					num = (int)((num2 * 1015823064) ^ 0x23683DB1);
					continue;
				case 244u:
					num = ((int)num2 * -2141603217) ^ -1174056077;
					continue;
				case 243u:
					Form2.smethod_19((Control)(object)PersonalInfoPanel1, new Size(44, 50));
					Form2.smethod_20((Control)(object)PersonalInfoPanel1, 15);
					num = ((int)num2 * -1941505260) ^ 0x3BECDF5C;
					continue;
				case 242u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					num = (int)((num2 * 1499127507) ^ 0x13E6E6AA);
					continue;
				case 241u:
					Form2.smethod_17((Control)(object)Panel1, new Point(126, 141));
					num = ((int)num2 * -960842790) ^ 0x21BB2F53;
					continue;
				case 240u:
					num = (int)((num2 * 1713156126) ^ 0x55C763EF);
					continue;
				case 239u:
					Form2.smethod_12(Label1, bool_0: true);
					Form2.smethod_13((Control)(object)Label1, Color.Transparent);
					num = (int)(num2 * 414352820) ^ -301844976;
					continue;
				case 238u:
					BloodBankPanel1 = Form2.smethod_5();
					num = ((int)num2 * -85774782) ^ 0x3F615739;
					continue;
				case 237u:
					num = ((int)num2 * -835891521) ^ 0x544DBD3D;
					continue;
				case 236u:
					Form2.smethod_25(Form2.smethod_43((Control)(object)this), (Control)(object)Panel1);
					num = ((int)num2 * -892078280) ^ -1787128942;
					continue;
				case 235u:
					Form2.smethod_19((Control)(object)RegisterRecieverBtn, new Size(311, 50));
					Form2.smethod_20((Control)(object)RegisterRecieverBtn, 6);
					num = (int)((num2 * 1983982941) ^ 0x3D8A6839);
					continue;
				case 234u:
					Form2.smethod_44((Control)(object)this, "Form2");
					num = ((int)num2 * -295388951) ^ -44113719;
					continue;
				case 233u:
					num = (int)(num2 * 917991802) ^ -1348611515;
					continue;
				case 232u:
					Form2.smethod_19((Control)(object)GroupBox5, new Size(351, 173));
					num = (int)((num2 * 1437549137) ^ 0x7411EC59);
					continue;
				case 231u:
					Form2.smethod_15((Control)(object)Label1, Form2.smethod_14("Microsoft Sans Serif", 36f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 631036652) ^ 0x74C5B420);
					continue;
				case 230u:
					num = ((int)num2 * -315593618) ^ -119871408;
					continue;
				case 229u:
					Form2.smethod_37(PictureBox1, 7);
					Form2.smethod_38(PictureBox1, bool_0: false);
					num = (int)((num2 * 1956554920) ^ 0x29090EE7);
					continue;
				case 228u:
					Form2.smethod_19((Control)(object)StaffPanel1, new Size(44, 50));
					Form2.smethod_20((Control)(object)StaffPanel1, 5);
					num = ((int)num2 * -1516546968) ^ -853276829;
					continue;
				case 227u:
					num = (int)((num2 * 927412533) ^ 0x1565A261);
					continue;
				case 226u:
					num = ((int)num2 * -572260825) ^ 0x1C8D198E;
					continue;
				case 225u:
					Form2.smethod_19((Control)(object)LogoutBtn, new Size(311, 50));
					num = (int)(num2 * 1044654600) ^ -1935990392;
					continue;
				case 223u:
					Form2.smethod_27(GroupBox2, "Patient");
					num = ((int)num2 * -1503595319) ^ 0x44E382F8;
					continue;
				case 222u:
					Form2.smethod_33((ButtonBase)(object)RegisterDonorBtn, bool_0: true);
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.Transparent);
					num = ((int)num2 * -1883468480) ^ -300053643;
					continue;
				case 221u:
					num = ((int)num2 * -637279857) ^ 0x266F08B0;
					continue;
				case 220u:
					Form2.smethod_20((Control)(object)BloodAvailabilityBtn, 7);
					num = (int)(num2 * 486469305) ^ -1116081017;
					continue;
				case 219u:
					num = ((int)num2 * -1033001233) ^ -607401258;
					continue;
				case 218u:
					num = (int)(num2 * 712293160) ^ -399958714;
					continue;
				case 217u:
					Form2.smethod_20((Control)(object)StaffPanel2, 6);
					num = (int)((num2 * 2059658382) ^ 0x29785C52);
					continue;
				case 216u:
					Form2.smethod_51((Control)(object)this);
					num = ((int)num2 * -813353965) ^ 0x3A0DB660;
					continue;
				case 215u:
					num = (int)((num2 * 35103660) ^ 0x17A351DC);
					continue;
				case 214u:
					Form2.smethod_30((ButtonBase)(object)RegisterRecieverBtn, (FlatStyle)0);
					Form2.smethod_15((Control)(object)RegisterRecieverBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -379018603) ^ -1608783188;
					continue;
				case 213u:
					Form2.smethod_33((ButtonBase)(object)BloodAvailabilityBtn, bool_0: true);
					num = ((int)num2 * -987330141) ^ -128089018;
					continue;
				case 212u:
					RegisterDonorBtn = Form2.smethod_7();
					num = (int)((num2 * 1161994897) ^ 0x6A339D5B);
					continue;
				case 211u:
					Form2.smethod_15((Control)(object)LogoutBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 969610057) ^ -1609182569;
					continue;
				case 210u:
					num = ((int)num2 * -510219254) ^ 0x571D159A;
					continue;
				case 209u:
					Form2.smethod_48((Control)(object)GroupBox2, bool_0: false);
					num = ((int)num2 * -2064327087) ^ 0x1FFCD016;
					continue;
				case 208u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox4), (Control)(object)RegisterDonorBtn);
					num = (int)(num2 * 1438143317) ^ -1763093620;
					continue;
				case 207u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox2), (Control)(object)CheckUpBtn);
					num = (int)(num2 * 946484869) ^ -1586804827;
					continue;
				case 206u:
					Form2.smethod_16((Control)(object)Label1, Color.White);
					num = ((int)num2 * -2139977180) ^ 0x78486F67;
					continue;
				case 205u:
					num = ((int)num2 * -1100567073) ^ -1878267831;
					continue;
				case 204u:
					Form2.smethod_18((Control)(object)BloodAvailabilityBtn, "BloodAvailabilityBtn");
					Form2.smethod_19((Control)(object)BloodAvailabilityBtn, new Size(311, 50));
					num = (int)((num2 * 873360475) ^ 0x64D4509A);
					continue;
				case 203u:
					Form2.smethod_11((Control)(object)this);
					num = ((int)num2 * -1096803976) ^ -1348140051;
					continue;
				case 202u:
					StaffPanel = Form2.smethod_5();
					num = ((int)num2 * -1008747461) ^ -308784669;
					continue;
				case 201u:
					Form2.smethod_30((ButtonBase)(object)AdmitBtn, (FlatStyle)0);
					Form2.smethod_15((Control)(object)AdmitBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1226697284) ^ -1793998602;
					continue;
				case 200u:
					num = ((int)num2 * -893267675) ^ 0x1422596;
					continue;
				case 199u:
					Form2.smethod_20((Control)(object)RegistrationBtn, 1);
					num = ((int)num2 * -96004666) ^ -2145169141;
					continue;
				case 198u:
					Form2.smethod_17((Control)(object)StaffPanel2, new Point(307, 37));
					num = ((int)num2 * -1072811065) ^ 0x625D39DA;
					continue;
				case 197u:
					Form2.smethod_20((Control)(object)GroupBox4, 11);
					Form2.smethod_26(GroupBox4, bool_0: false);
					num = ((int)num2 * -1572445537) ^ 0x48232281;
					continue;
				case 196u:
					num = ((int)num2 * -1503499003) ^ -1583214885;
					continue;
				case 195u:
					num = ((int)num2 * -422925968) ^ 0x5913C545;
					continue;
				case 194u:
					Form2.smethod_20((Control)(object)RegisterDonorBtn, 5);
					num = (int)(num2 * 1491864126) ^ -885596915;
					continue;
				case 193u:
					PictureBox1 = Form2.smethod_8();
					num = (int)(num2 * 1962611131) ^ -350668566;
					continue;
				case 192u:
					num = (int)(num2 * 775976469) ^ -366225563;
					continue;
				case 191u:
					Form2.smethod_17((Control)(object)GroupBox4, new Point(13, 440));
					num = ((int)num2 * -834913678) ^ -1785103725;
					continue;
				case 190u:
					Form2.smethod_20((Control)(object)AvailabilityBtn, 4);
					num = (int)((num2 * 269355669) ^ 0x42DC7167);
					continue;
				case 189u:
					Form2.smethod_19((Control)(object)CheckUpBtn, new Size(306, 50));
					num = (int)((num2 * 1335607141) ^ 0x7BB9EF5);
					continue;
				case 188u:
					Form2.smethod_18((Control)(object)StaffPanel, "StaffPanel");
					num = ((int)num2 * -199792688) ^ 0x554E7615;
					continue;
				case 187u:
					num = (int)((num2 * 210761006) ^ 0x7944F674);
					continue;
				case 186u:
					Form2.smethod_18((Control)(object)LogoutBtn, "LogoutBtn");
					num = (int)((num2 * 724870602) ^ 0x3909CF91);
					continue;
				case 185u:
					num = ((int)num2 * -272194882) ^ 0x57EEDA6E;
					continue;
				case 184u:
					Form2.smethod_22(Label1, (ContentAlignment)32);
					num = (int)((num2 * 972255553) ^ 0x6EFB712);
					continue;
				case 183u:
					Form2.smethod_19((Control)(object)Label1, new Size(845, 69));
					num = ((int)num2 * -1814269018) ^ -1607721471;
					continue;
				case 182u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox4), (Control)(object)BloodAvailabilityBtn);
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox4), (Control)(object)RegisterRecieverBtn);
					num = (int)(num2 * 982387543) ^ -1566609260;
					continue;
				case 181u:
					Form2.smethod_15((Control)(object)GroupBox4, Form2.smethod_14("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1090364677) ^ 0x5AF99ED0);
					continue;
				case 180u:
					Form2.smethod_41((Form)(object)this, Color.MidnightBlue);
					Form2.smethod_42((Form)(object)this, new Size(1285, 973));
					num = ((int)num2 * -1702969373) ^ 0x7F4AB27C;
					continue;
				case 179u:
					Form2.smethod_31((Control)(object)GroupBox4, new Padding(0));
					Form2.smethod_18((Control)(object)GroupBox4, "GroupBox4");
					num = (int)(num2 * 514068829) ^ -992746320;
					continue;
				case 178u:
					Form2.smethod_17((Control)(object)BloodAvailabilityBtn, new Point(20, 138));
					Form2.smethod_31((Control)(object)BloodAvailabilityBtn, new Padding(0));
					num = (int)((num2 * 1008877299) ^ 0x7A24982C);
					continue;
				case 177u:
					Form2.smethod_20((Control)(object)EditProfileBtn, 5);
					num = (int)(num2 * 472129029) ^ -305605560;
					continue;
				case 176u:
					Form2.smethod_32((ButtonBase)(object)AvailabilityBtn, "Availability");
					num = ((int)num2 * -635075984) ^ -792374006;
					continue;
				case 175u:
					num = (int)((num2 * 525331766) ^ 0x6765E61B);
					continue;
				case 174u:
					Form2.smethod_17((Control)(object)StaffPanel1, new Point(0, 37));
					Form2.smethod_18((Control)(object)StaffPanel1, "StaffPanel1");
					num = (int)(num2 * 777696465) ^ -1119100692;
					continue;
				case 173u:
					Form2.smethod_19((Control)(object)GroupBox3, new Size(351, 114));
					Form2.smethod_20((Control)(object)GroupBox3, 10);
					num = ((int)num2 * -968870294) ^ 0x567D6252;
					continue;
				case 172u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)Panel1), (Control)(object)GroupBox4);
					num = (int)((num2 * 1862275387) ^ 0x7091043F);
					continue;
				case 171u:
					Form2.smethod_17((Control)(object)AdmitBtn, new Point(25, 146));
					num = ((int)num2 * -697752858) ^ 0xAD415A3;
					continue;
				case 170u:
					Form2.smethod_20((Control)(object)PatientPanel2, 6);
					num = ((int)num2 * -1354035256) ^ 0x43590F5A;
					continue;
				case 169u:
					Form2.smethod_20((Control)(object)Label1, 2);
					num = (int)((num2 * 149961893) ^ 0x5B920539);
					continue;
				case 168u:
					AdmitBtn = Form2.smethod_7();
					num = (int)(num2 * 967107629) ^ -1694530116;
					continue;
				case 167u:
					RegisterRecieverBtn = Form2.smethod_7();
					num = (int)(num2 * 2036923152) ^ -674219138;
					continue;
				case 166u:
					Form2.smethod_17((Control)(object)PictureBox1, new Point(307, 12));
					num = (int)((num2 * 38975582) ^ 0x575756D8);
					continue;
				case 165u:
					Form2.smethod_35(PictureBox1, (Image)(object)Resources.Hospital_blue_icon);
					num = ((int)num2 * -1386572300) ^ 0x2B81130E;
					continue;
				case 164u:
					num = ((int)num2 * -477209506) ^ 0x3A3E8D07;
					continue;
				case 163u:
					num = ((int)num2 * -863954403) ^ -2126399471;
					continue;
				case 162u:
					num = ((int)num2 * -1689347028) ^ 0xFC8EAE7;
					continue;
				case 161u:
					num = ((int)num2 * -395424613) ^ 0x3D4704F3;
					continue;
				case 160u:
					num = (int)((num2 * 351445546) ^ 0x6BDD98BF);
					continue;
				case 159u:
					Form2.smethod_48((Control)(object)GroupBox5, bool_0: false);
					num = (int)((num2 * 513582395) ^ 0x4300FDD9);
					continue;
				case 158u:
					num = (int)(num2 * 1570870329) ^ -1356115073;
					continue;
				case 157u:
					num = ((int)num2 * -1265879775) ^ -567138260;
					continue;
				case 156u:
					Form2.smethod_18((Control)(object)PictureBox1, "PictureBox1");
					num = ((int)num2 * -27743304) ^ 0x5367F6F0;
					continue;
				case 155u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.Transparent);
					Form2.smethod_17((Control)(object)PatientPanel2, new Point(307, 43));
					num = (int)(num2 * 990860048) ^ -764647371;
					continue;
				case 154u:
					Form2.smethod_32((ButtonBase)(object)BloodAvailabilityBtn, "Blood Availability");
					num = (int)((num2 * 1070664839) ^ 0x321B0047);
					continue;
				case 153u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox5), (Control)(object)LogoutBtn);
					num = ((int)num2 * -792875030) ^ 0x7702FCD7;
					continue;
				case 152u:
					PersonalInfoPanel1 = Form2.smethod_5();
					num = (int)((num2 * 1595594804) ^ 0x44104AF3);
					continue;
				case 151u:
					num = ((int)num2 * -25285508) ^ -1643874120;
					continue;
				case 150u:
					StaffPanel2 = Form2.smethod_5();
					num = (int)((num2 * 546993170) ^ 0x5214DF2B);
					continue;
				case 149u:
					num = (int)((num2 * 1818236376) ^ 0xEFD4AD6);
					continue;
				case 148u:
					num = (int)(num2 * 552536686) ^ -504022415;
					continue;
				case 147u:
					Form2.smethod_20((Control)(object)BloodBankPanel1, 14);
					num = ((int)num2 * -244417297) ^ -1053515332;
					continue;
				case 146u:
					Form2.smethod_19((Control)(object)PatientPanel1, new Size(44, 50));
					num = (int)((num2 * 1095960127) ^ 0x646E1AAE);
					continue;
				case 145u:
					Form2.smethod_13((Control)(object)Panel1, Color.White);
					num = ((int)num2 * -1670369553) ^ 0x1218060E;
					continue;
				case 144u:
					Form2.smethod_17((Control)(object)RegisterDonorBtn, new Point(20, 38));
					num = (int)(num2 * 948480367) ^ -496721550;
					continue;
				case 143u:
					Form2.smethod_15((Control)(object)RegistrationBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 414338798) ^ -727888540;
					continue;
				case 142u:
					Form2.smethod_30((ButtonBase)(object)BloodAvailabilityBtn, (FlatStyle)0);
					num = (int)((num2 * 22417444) ^ 0x553C759A);
					continue;
				case 141u:
					Form2.smethod_9((Control)(object)GroupBox2);
					Form2.smethod_9((Control)(object)GroupBox4);
					num = (int)(num2 * 1274705558) ^ -106278543;
					continue;
				case 140u:
					Form2.smethod_18((Control)(object)Panel1, "Panel1");
					num = (int)(num2 * 888174808) ^ -1796072107;
					continue;
				case 139u:
					Form2.smethod_30((ButtonBase)(object)AvailabilityBtn, (FlatStyle)0);
					num = ((int)num2 * -1274470849) ^ 0xF2BB52E;
					continue;
				case 138u:
					Form2.smethod_20((Control)(object)StaffPanel, 3);
					num = (int)((num2 * 1750433821) ^ 0x20D7078F);
					continue;
				case 137u:
					Form2.smethod_34((ButtonBase)(object)RegistrationBtn, Color.White);
					num = (int)(num2 * 807936699) ^ -1679460115;
					continue;
				case 136u:
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)LogoutBtn), 0);
					num = ((int)num2 * -1711270989) ^ 0x7C4778EE;
					continue;
				case 135u:
					Form2.smethod_17((Control)(object)RegistrationBtn, new Point(25, 43));
					num = (int)((num2 * 92816709) ^ 0x6A2260FB);
					continue;
				case 134u:
					Form2.smethod_27(GroupBox3, "Staff");
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)AvailabilityBtn), 0);
					num = (int)((num2 * 1171316006) ^ 0x396FDCC5);
					continue;
				case 133u:
					Form2.smethod_30((ButtonBase)(object)UpdateDetailsBtn, (FlatStyle)0);
					num = ((int)num2 * -25681300) ^ -1721231123;
					continue;
				case 132u:
					num = (int)(num2 * 2066865336) ^ -1124110433;
					continue;
				case 131u:
					Form2.smethod_18((Control)(object)AdmitBtn, "AdmitBtn");
					num = ((int)num2 * -19557056) ^ -1684459745;
					continue;
				case 130u:
					Form2.smethod_17((Control)(object)PersonalInfoPanel1, new Point(0, 52));
					num = (int)((num2 * 1049687450) ^ 0x6BD83D03);
					continue;
				case 129u:
					Form2.smethod_33((ButtonBase)(object)AvailabilityBtn, bool_0: true);
					num = ((int)num2 * -832410010) ^ -1152495752;
					continue;
				case 128u:
					Form2.smethod_18((Control)(object)PatientPanel2, "PatientPanel2");
					num = ((int)num2 * -673973202) ^ -1450758369;
					continue;
				case 127u:
					Form2.smethod_33((ButtonBase)(object)UpdateDetailsBtn, bool_0: true);
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)AdmitBtn), 0);
					num = (int)((num2 * 1262094278) ^ 0x29260016);
					continue;
				case 126u:
					num = (int)((num2 * 468870771) ^ 0x8363ED1);
					continue;
				case 125u:
					num = ((int)num2 * -715975407) ^ 0x1622AB69;
					continue;
				case 124u:
					Form2.smethod_17((Control)(object)BloodBankPanel2, new Point(307, 38));
					num = (int)(num2 * 954048751) ^ -105961278;
					continue;
				case 123u:
					num = (int)((num2 * 274918024) ^ 0x3E798A03);
					continue;
				case 122u:
					num = (int)(num2 * 874102671) ^ -1888608256;
					continue;
				case 121u:
					Form2.smethod_31((Control)(object)RegisterRecieverBtn, new Padding(0));
					num = ((int)num2 * -137816575) ^ -1608903675;
					continue;
				case 120u:
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)RegistrationBtn), 0);
					Form2.smethod_30((ButtonBase)(object)RegistrationBtn, (FlatStyle)0);
					num = ((int)num2 * -663972801) ^ -1014052224;
					continue;
				case 119u:
					num = ((int)num2 * -951673266) ^ -678693198;
					continue;
				case 118u:
					Form2.smethod_15((Control)(object)BloodAvailabilityBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1934727875) ^ -2013144473;
					continue;
				case 117u:
					Form2.smethod_32((ButtonBase)(object)UpdateDetailsBtn, "Update Details");
					num = (int)((num2 * 1079062534) ^ 0x774C599F);
					continue;
				case 116u:
					Form2.smethod_17((Control)(object)GroupBox2, new Point(13, 9));
					num = (int)(num2 * 1666245953) ^ -1038477535;
					continue;
				case 115u:
					Form2.smethod_32((ButtonBase)(object)EditProfileBtn, "Edit Profile");
					num = (int)((num2 * 1476073693) ^ 0x747EFD13);
					continue;
				case 114u:
					Form2.smethod_18((Control)(object)RegisterDonorBtn, "RegisterDonorBtn");
					num = (int)(num2 * 1537182038) ^ -884018293;
					continue;
				case 113u:
					num = (int)(num2 * 971826021) ^ -2103511609;
					continue;
				case 112u:
					GroupBox2 = Form2.smethod_6();
					num = (int)(num2 * 376604039) ^ -2145878161;
					continue;
				case 111u:
					Form2.smethod_13((Control)(object)PatientPanel1, Color.Transparent);
					Form2.smethod_15((Control)(object)PatientPanel1, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1696013958) ^ -643081377;
					continue;
				case 110u:
					Form2.smethod_45((Form)(object)this, (SizeGripStyle)1);
					Form2.smethod_46((Form)(object)this, "Form2");
					num = ((int)num2 * -1598371294) ^ -489372004;
					continue;
				case 109u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox4), (Control)(object)BloodBankPanel1);
					num = (int)(num2 * 1413076104) ^ -1729832225;
					continue;
				case 108u:
					num = ((int)num2 * -1323991407) ^ 0x3F1B08DE;
					continue;
				case 107u:
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					num = (int)((num2 * 286595686) ^ 0x6CE3D449);
					continue;
				case 106u:
					Form2.smethod_10((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -526644220) ^ 0x6B605DC8;
					continue;
				case 105u:
					Form2.smethod_18((Control)(object)Label1, "Label1");
					num = ((int)num2 * -2049581580) ^ -1617503533;
					continue;
				case 104u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)Panel1), (Control)(object)GroupBox5);
					num = (int)((num2 * 1035927663) ^ 0x7BAEC8FF);
					continue;
				case 103u:
					num = ((int)num2 * -1197651448) ^ -431832759;
					continue;
				case 102u:
					num = (int)((num2 * 1912991233) ^ 0x37C7B6C4);
					continue;
				case 101u:
					num = (int)(num2 * 226074769) ^ -1260013560;
					continue;
				case 100u:
					Form2.smethod_17((Control)(object)PatientPanel1, new Point(6, 43));
					Form2.smethod_18((Control)(object)PatientPanel1, "PatientPanel1");
					num = (int)(num2 * 1109111198) ^ -1617651764;
					continue;
				case 99u:
					num = (int)((num2 * 745063731) ^ 0x589EC01C);
					continue;
				case 98u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox2), (Control)(object)UpdateDetailsBtn);
					num = ((int)num2 * -371634405) ^ 0x6662CA5F;
					continue;
				case 97u:
					num = ((int)num2 * -789513617) ^ -1550346383;
					continue;
				case 96u:
					Form2.smethod_15((Control)(object)CheckUpBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 729624445) ^ -1331436095;
					continue;
				case 95u:
					GroupBox3 = Form2.smethod_6();
					num = ((int)num2 * -952362283) ^ -2043208519;
					continue;
				case 94u:
					num = (int)((num2 * 1664505917) ^ 0x321388E9);
					continue;
				case 93u:
					CheckUpBtn = Form2.smethod_7();
					num = (int)(num2 * 391800636) ^ -1754207594;
					continue;
				case 92u:
					Form2.smethod_20((Control)(object)UpdateDetailsBtn, 4);
					num = ((int)num2 * -1769620929) ^ 0x7B71C2F;
					continue;
				case 91u:
					num = ((int)num2 * -942964357) ^ 0xE0ADD1E;
					continue;
				case 90u:
					Form2.smethod_31((Control)(object)CheckUpBtn, new Padding(0));
					num = (int)(num2 * 41088358) ^ -2019231875;
					continue;
				case 89u:
					num = (int)(num2 * 1235539812) ^ -865326053;
					continue;
				case 88u:
					num = ((int)num2 * -226450893) ^ -2021135825;
					continue;
				case 87u:
					num = ((int)num2 * -390682806) ^ -1905716825;
					continue;
				case 86u:
					Form2.smethod_18((Control)(object)EditProfileBtn, "EditProfileBtn");
					num = (int)(num2 * 1483736435) ^ -1354199663;
					continue;
				case 85u:
					Form2.smethod_48((Control)(object)Panel1, bool_0: false);
					num = (int)(num2 * 1098345853) ^ -299979775;
					continue;
				case 84u:
					Form2.smethod_18((Control)(object)StaffPanel2, "StaffPanel2");
					num = (int)((num2 * 1081860345) ^ 0x2721F08D);
					continue;
				case 83u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox2), (Control)(object)RegistrationBtn);
					num = ((int)num2 * -1293560684) ^ -92915482;
					continue;
				case 82u:
					Form2.smethod_18((Control)(object)PersonalInfoPanel2, "PersonalInfoPanel2");
					num = (int)((num2 * 1372206164) ^ 0x3344F97B);
					continue;
				case 81u:
					Form2.smethod_17((Control)(object)LogoutBtn, new Point(20, 102));
					Form2.smethod_31((Control)(object)LogoutBtn, new Padding(0));
					num = (int)(num2 * 1326173704) ^ -173849820;
					continue;
				case 80u:
					num = ((int)num2 * -1783912231) ^ 0x63BFED6A;
					continue;
				case 79u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = ((int)num2 * -211218406) ^ 0xEB721DC;
					continue;
				case 78u:
					Form2.smethod_32((ButtonBase)(object)RegisterDonorBtn, "Register Donor");
					num = (int)(num2 * 1872218265) ^ -281308413;
					continue;
				case 77u:
					num = (int)(num2 * 732728969) ^ -622547317;
					continue;
				case 76u:
					Form2.smethod_18((Control)(object)RegisterRecieverBtn, "RegisterRecieverBtn");
					num = ((int)num2 * -1953981735) ^ 0x61D85DAA;
					continue;
				case 75u:
					Form2.smethod_25(Form2.smethod_43((Control)(object)this), (Control)(object)Label1);
					num = (int)((num2 * 1939441791) ^ 0x338823EB);
					continue;
				case 74u:
					num = ((int)num2 * -859330744) ^ -1878866062;
					continue;
				case 73u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox2), (Control)(object)AdmitBtn);
					num = ((int)num2 * -1869574741) ^ 0x14752956;
					continue;
				case 72u:
					num = (int)(num2 * 1720863476) ^ -816134324;
					continue;
				case 71u:
					Form2.smethod_18((Control)(object)BloodBankPanel1, "BloodBankPanel1");
					num = (int)((num2 * 1076136180) ^ 0x1BA72A80);
					continue;
				case 70u:
					UpdateDetailsBtn = Form2.smethod_7();
					num = (int)(num2 * 1943324075) ^ -1276283673;
					continue;
				case 69u:
					num = ((int)num2 * -985185637) ^ 0x28C49752;
					continue;
				case 68u:
					num = (int)((num2 * 634190203) ^ 0x2DEB9BA3);
					continue;
				case 67u:
					Form2.smethod_18((Control)(object)CheckUpBtn, "CheckUpBtn");
					num = (int)(num2 * 404852129) ^ -19418711;
					continue;
				case 66u:
					num = ((int)num2 * -1130700936) ^ -842918484;
					continue;
				case 65u:
					Form2.smethod_15((Control)(object)RegisterDonorBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 300575615) ^ -187248161;
					continue;
				case 64u:
					Form2.smethod_17((Control)(object)GroupBox5, new Point(13, 647));
					num = ((int)num2 * -2121368237) ^ -1944724344;
					continue;
				case 63u:
					num = ((int)num2 * -943872843) ^ 0x1AB1CA25;
					continue;
				case 62u:
					EditProfileBtn = Form2.smethod_7();
					num = (int)((num2 * 244242086) ^ 0x1089EBE7);
					continue;
				case 61u:
					num = ((int)num2 * -800513479) ^ 0x28E02EAB;
					continue;
				case 60u:
					Form2.smethod_26(GroupBox3, bool_0: false);
					num = ((int)num2 * -1743316456) ^ 0x51BFC25B;
					continue;
				case 59u:
					num = (int)(num2 * 1981225407) ^ -1642345573;
					continue;
				case 58u:
					AvailabilityBtn = Form2.smethod_7();
					num = (int)(num2 * 27325418) ^ -200882270;
					continue;
				case 57u:
					Panel1 = Form2.smethod_5();
					num = ((int)num2 * -1791548420) ^ 0x5B10DE35;
					continue;
				case 56u:
					Form2.smethod_30((ButtonBase)(object)RegisterDonorBtn, (FlatStyle)0);
					num = ((int)num2 * -519766742) ^ 0x50B9BE65;
					continue;
				case 55u:
					num = (int)(num2 * 1040037636) ^ -1377397039;
					continue;
				case 54u:
					Form2.smethod_26(GroupBox2, bool_0: false);
					num = (int)(num2 * 1705450501) ^ -67861916;
					continue;
				case 53u:
					num = ((int)num2 * -1128858905) ^ 0x57771D6B;
					continue;
				case 52u:
					num = (int)((num2 * 1008205836) ^ 0xC33D271);
					continue;
				case 51u:
					Form2.smethod_19((Control)(object)AvailabilityBtn, new Size(311, 50));
					num = ((int)num2 * -837730579) ^ -538736494;
					continue;
				case 50u:
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)BloodAvailabilityBtn), 0);
					num = (int)((num2 * 573454129) ^ 0x6849E881);
					continue;
				case 49u:
					num = ((int)num2 * -732038669) ^ -1004658690;
					continue;
				case 48u:
					num = ((int)num2 * -691534331) ^ 0x56672DA8;
					continue;
				case 47u:
					Form2.smethod_18((Control)(object)BloodBankPanel2, "BloodBankPanel2");
					num = (int)((num2 * 363329613) ^ 0x56A8CE39);
					continue;
				case 46u:
					Form2.smethod_31((Control)(object)UpdateDetailsBtn, new Padding(0));
					num = (int)((num2 * 1360535702) ^ 0x2F043892);
					continue;
				case 45u:
					num = (int)(num2 * 1612265592) ^ -265166507;
					continue;
				case 44u:
					Form2.smethod_18((Control)(object)GroupBox5, "GroupBox5");
					num = (int)(num2 * 1209128674) ^ -1881647619;
					continue;
				case 43u:
					num = (int)((num2 * 1004239424) ^ 0x52A5BD90);
					continue;
				case 42u:
					num = ((int)num2 * -762323790) ^ -187448301;
					continue;
				case 41u:
					Form2.smethod_20((Control)(object)GroupBox5, 12);
					num = ((int)num2 * -1155740826) ^ -786442939;
					continue;
				case 40u:
					Form2.smethod_18((Control)(object)UpdateDetailsBtn, "UpdateDetailsBtn");
					num = (int)(num2 * 764214095) ^ -863663669;
					continue;
				case 39u:
					Form2.smethod_19((Control)(object)Panel1, new Size(380, 825));
					num = (int)((num2 * 197028585) ^ 0x35AD0357);
					continue;
				case 38u:
					Form2.smethod_9((Control)(object)GroupBox3);
					num = (int)((num2 * 2129634919) ^ 0x26FAEBB2);
					continue;
				case 37u:
					num = (int)((num2 * 1989205113) ^ 0x770BEA44);
					continue;
				case 36u:
					num = ((int)num2 * -1822973126) ^ 0x22F652FB;
					continue;
				case 35u:
					num = ((int)num2 * -1152100475) ^ -1667597432;
					continue;
				case 34u:
					num = (int)(num2 * 752588610) ^ -202215494;
					continue;
				case 33u:
					num = ((int)num2 * -1608456455) ^ -56014361;
					continue;
				case 32u:
					num = (int)((num2 * 783861658) ^ 0x55410655);
					continue;
				case 31u:
					Form2.smethod_47((Form)(object)this, (FormWindowState)2);
					num = ((int)num2 * -683034732) ^ 0x4831AFAB;
					continue;
				case 30u:
					Form2.smethod_15((Control)(object)GroupBox5, Form2.smethod_14("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 182487932) ^ 0x4CC1A292);
					continue;
				case 29u:
					num = ((int)num2 * -2115906207) ^ 0x4B7DABCB;
					continue;
				case 28u:
					Form2.smethod_19((Control)(object)GroupBox4, new Size(351, 204));
					num = ((int)num2 * -1880224920) ^ 0x2B92548C;
					continue;
				case 27u:
					Form2.smethod_27(GroupBox4, "Blood Bank");
					num = (int)((num2 * 1035812620) ^ 0x76829A95);
					continue;
				case 26u:
					Form2.smethod_33((ButtonBase)(object)RegistrationBtn, bool_0: false);
					num = (int)(num2 * 803222691) ^ -672174216;
					continue;
				case 25u:
					Form2.smethod_32((ButtonBase)(object)RegisterRecieverBtn, "Register Reciever");
					num = ((int)num2 * -1505158613) ^ 0xBFA5C1E;
					continue;
				case 24u:
					Form2.smethod_19((Control)(object)PersonalInfoPanel2, new Size(44, 50));
					Form2.smethod_20((Control)(object)PersonalInfoPanel2, 16);
					num = ((int)num2 * -1938988963) ^ 0x337D15FA;
					continue;
				case 23u:
					num = (int)((num2 * 369751391) ^ 0x637C3A2C);
					continue;
				case 22u:
					num = (int)((num2 * 144466032) ^ 0x6CD44044);
					continue;
				case 21u:
					Form2.smethod_20((Control)(object)Panel1, 6);
					num = (int)(num2 * 146280051) ^ -574008998;
					continue;
				case 20u:
					num = (int)((num2 * 1107845791) ^ 0x2C17B9CD);
					continue;
				case 19u:
					num = ((int)num2 * -894027891) ^ 0x3FCE65FD;
					continue;
				case 18u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)Panel1), (Control)(object)GroupBox2);
					num = ((int)num2 * -7401521) ^ 0x60E2A32A;
					continue;
				case 17u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox5), (Control)(object)EditProfileBtn);
					num = (int)((num2 * 1310486511) ^ 0x40B9B1C5);
					continue;
				case 16u:
					Form2.smethod_32((ButtonBase)(object)LogoutBtn, "Logout");
					num = (int)(num2 * 120565409) ^ -329198159;
					continue;
				case 15u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox2), (Control)(object)PatientPanel1);
					num = ((int)num2 * -1200981989) ^ -288664439;
					continue;
				case 14u:
					LogoutBtn = Form2.smethod_7();
					num = ((int)num2 * -521023532) ^ -1209719212;
					continue;
				case 13u:
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)CheckUpBtn), 0);
					num = (int)(num2 * 753550844) ^ -2056593047;
					continue;
				case 12u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox5), (Control)(object)PersonalInfoPanel2);
					num = ((int)num2 * -1184319266) ^ 0xEF1C184;
					continue;
				case 11u:
					num = (int)((num2 * 506381364) ^ 0x70191884);
					continue;
				case 10u:
					Form2.smethod_23((ScrollableControl)(object)StaffPanel, bool_0: true);
					num = (int)((num2 * 901903084) ^ 0xB2D3C32);
					continue;
				case 9u:
					Form2.smethod_25(Form2.smethod_43((Control)(object)this), (Control)(object)PictureBox1);
					num = (int)((num2 * 165557545) ^ 0x3FD70407);
					continue;
				case 8u:
					Form2.smethod_33((ButtonBase)(object)LogoutBtn, bool_0: true);
					num = ((int)num2 * -1006537254) ^ -1789014923;
					continue;
				case 7u:
					num = (int)(num2 * 806028308) ^ -701873852;
					continue;
				case 6u:
					StaffPanel1 = Form2.smethod_5();
					num = (int)(num2 * 969004527) ^ -1928985091;
					continue;
				case 5u:
					GroupBox4 = Form2.smethod_6();
					BloodAvailabilityBtn = Form2.smethod_7();
					num = (int)((num2 * 597234779) ^ 0x307DA680);
					continue;
				case 4u:
					Form2.smethod_20((Control)(object)GroupBox2, 9);
					num = ((int)num2 * -1696982088) ^ 0x11EF7118;
					continue;
				case 3u:
					num = ((int)num2 * -1753253296) ^ 0x7ABADA85;
					continue;
				case 2u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox2), (Control)(object)PatientPanel2);
					num = (int)(num2 * 213195151) ^ -2146173232;
					continue;
				case 1u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox4), (Control)(object)BloodBankPanel2);
					num = ((int)num2 * -1063960945) ^ -587150547;
					continue;
				case 0u:
					Form2.smethod_33((ButtonBase)(object)AdmitBtn, bool_0: true);
					num = ((int)num2 * -2144170735) ^ 0x1146A080;
					continue;
				default:
					return;
				case 261u:
					break;
				case 224u:
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
			int num = -1306140126;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF463B31Du) % 16u)
				{
				case 15u:
					Form2.smethod_13((Control)(object)BloodBankPanel1, Color.Transparent);
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.Transparent);
					num = ((int)num2 * -1241414069) ^ 0x5D964F9C;
					continue;
				case 14u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = ((int)num2 * -4277223) ^ -7479398;
					continue;
				case 13u:
					num = (int)((num2 * 856449672) ^ 0x722108C5);
					continue;
				case 11u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.DarkBlue);
					num = ((int)num2 * -1655844455) ^ 0x73389CEF;
					continue;
				case 10u:
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					num = ((int)num2 * -905053148) ^ -414953833;
					continue;
				case 9u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = ((int)num2 * -287274392) ^ -81495608;
					continue;
				case 8u:
					num = ((int)num2 * -1521829166) ^ 0x41C09EA3;
					continue;
				case 6u:
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					Form2.smethod_25(Form2.smethod_24((Control)(object)StaffPanel), (Control)(object)new CheckUp());
					num = ((int)num2 * -1275971430) ^ -486721347;
					continue;
				case 5u:
					Form2.smethod_13((Control)(object)PatientPanel1, Color.DarkBlue);
					num = (int)(num2 * 821924301) ^ -139594761;
					continue;
				case 4u:
					num = (int)(num2 * 1905977098) ^ -1668110657;
					continue;
				case 3u:
					Form2.smethod_55((Control)(object)PatientPanel2, Form2.smethod_54((Control)(object)CheckUpBtn));
					num = (int)(num2 * 1855821880) ^ -1604935824;
					continue;
				case 2u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					num = ((int)num2 * -530981142) ^ -625102783;
					continue;
				case 1u:
					num = ((int)num2 * -1902438104) ^ -590919453;
					continue;
				case 0u:
					Form2.smethod_55((Control)(object)PatientPanel1, Form2.smethod_54((Control)(object)CheckUpBtn));
					num = ((int)num2 * -738180629) ^ 0x49B4A43E;
					continue;
				default:
					return;
				case 7u:
					break;
				case 12u:
					return;
				}
				break;
			}
		}
	}

	private void RegistrationBtn_Click(object sender, EventArgs e)
	{
		Form2.smethod_13((Control)(object)BloodBankPanel1, Color.Transparent);
		while (true)
		{
			int num = -1217759251;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x99DC6932u) % 16u)
				{
				case 15u:
					num = ((int)num2 * -1040525673) ^ -1885342548;
					continue;
				case 14u:
					num = ((int)num2 * -1772038236) ^ 0x284A27FE;
					continue;
				case 13u:
					Form2.smethod_13((Control)(object)PatientPanel1, Color.DarkBlue);
					Form2.smethod_13((Control)(object)PatientPanel2, Color.DarkBlue);
					num = (int)(num2 * 952833380) ^ -279493430;
					continue;
				case 12u:
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					num = ((int)num2 * -1234516449) ^ 0x62040388;
					continue;
				case 11u:
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					num = (int)(num2 * 7605014) ^ -1781434168;
					continue;
				case 9u:
					num = (int)((num2 * 501810954) ^ 0x641D6FBB);
					continue;
				case 8u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					num = (int)(num2 * 1005499109) ^ -866844349;
					continue;
				case 7u:
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.Transparent);
					num = (int)(num2 * 1794200073) ^ -1369128122;
					continue;
				case 6u:
					num = ((int)num2 * -324133319) ^ 0x53E061E1;
					continue;
				case 5u:
					Form2.smethod_55((Control)(object)PatientPanel2, Form2.smethod_54((Control)(object)RegistrationBtn));
					num = ((int)num2 * -1578587643) ^ 0xDBCEA6;
					continue;
				case 4u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)StaffPanel), (Control)(object)new Registration());
					num = (int)(num2 * 29211915) ^ -425134020;
					continue;
				case 3u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)(num2 * 866287836) ^ -1065076026;
					continue;
				case 2u:
					num = ((int)num2 * -2135479184) ^ 0x2F229403;
					continue;
				case 0u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.Transparent);
					Form2.smethod_55((Control)(object)PatientPanel1, Form2.smethod_54((Control)(object)RegistrationBtn));
					num = ((int)num2 * -2085950438) ^ 0x2EBE3674;
					continue;
				default:
					return;
				case 10u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private void AdmitBtn_Click(object sender, EventArgs e)
	{
		Form2.smethod_13((Control)(object)BloodBankPanel1, Color.Transparent);
		while (true)
		{
			int num = -2142762477;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9642D4BDu) % 15u)
				{
				case 14u:
					num = ((int)num2 * -992204449) ^ -638041695;
					continue;
				case 13u:
					Form2.smethod_55((Control)(object)PatientPanel1, Form2.smethod_54((Control)(object)AdmitBtn));
					num = (int)((num2 * 1074531060) ^ 0x2CFF50A5);
					continue;
				case 11u:
					Form2.smethod_55((Control)(object)PatientPanel2, Form2.smethod_54((Control)(object)AdmitBtn));
					num = (int)(num2 * 61919183) ^ -817879211;
					continue;
				case 10u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.DarkBlue);
					num = ((int)num2 * -93759813) ^ 0x58EEE5AA;
					continue;
				case 9u:
					num = (int)((num2 * 1414081463) ^ 0x724821CD);
					continue;
				case 8u:
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.Transparent);
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					num = (int)((num2 * 1076720922) ^ 0x8A818D2);
					continue;
				case 6u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)((num2 * 738555286) ^ 0x49BEEDF9);
					continue;
				case 5u:
					num = ((int)num2 * -589485370) ^ -1334737627;
					continue;
				case 4u:
					Form2.smethod_13((Control)(object)PatientPanel1, Color.DarkBlue);
					num = ((int)num2 * -385957851) ^ 0x151EBDA0;
					continue;
				case 3u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)StaffPanel), (Control)(object)new Admit());
					num = (int)((num2 * 65352) ^ 0x23BAB00B);
					continue;
				case 2u:
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					num = ((int)num2 * -1177933470) ^ -18458796;
					continue;
				case 1u:
					num = (int)((num2 * 1487288392) ^ 0x7F3F8972);
					continue;
				case 0u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = (int)((num2 * 1944577937) ^ 0x6B644EA3);
					continue;
				default:
					return;
				case 7u:
					break;
				case 12u:
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
			int num = 1998128990;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5934956Fu) % 17u)
				{
				case 16u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)StaffPanel), (Control)(object)new UpdateDetails());
					num = ((int)num2 * -751318264) ^ 0x528C78D8;
					continue;
				case 15u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					num = ((int)num2 * -1294994945) ^ 0x85B831;
					continue;
				case 14u:
					Form2.smethod_13((Control)(object)BloodBankPanel1, Color.Transparent);
					num = (int)(num2 * 1085254439) ^ -1672744190;
					continue;
				case 13u:
					num = (int)((num2 * 1867328055) ^ 0x44597213);
					continue;
				case 12u:
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					num = ((int)num2 * -1761384276) ^ 0x4B556690;
					continue;
				case 11u:
					Form2.smethod_13((Control)(object)PatientPanel1, Color.DarkBlue);
					Form2.smethod_13((Control)(object)PatientPanel2, Color.DarkBlue);
					num = (int)(num2 * 382136705) ^ -616853060;
					continue;
				case 10u:
					Form2.smethod_55((Control)(object)PatientPanel2, Form2.smethod_54((Control)(object)UpdateDetailsBtn));
					num = ((int)num2 * -277191144) ^ 0x1005F88F;
					continue;
				case 9u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.Transparent);
					Form2.smethod_55((Control)(object)PatientPanel1, Form2.smethod_54((Control)(object)UpdateDetailsBtn));
					num = (int)((num2 * 1925121730) ^ 0x49CB41B);
					continue;
				case 8u:
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					num = ((int)num2 * -1005575285) ^ 0x26F14CDC;
					continue;
				case 7u:
					num = (int)((num2 * 242637913) ^ 0x639DB62E);
					continue;
				case 6u:
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.Transparent);
					num = (int)(num2 * 602963258) ^ -2108859963;
					continue;
				case 5u:
					num = (int)((num2 * 1876996129) ^ 0x52524892);
					continue;
				case 4u:
					num = (int)((num2 * 1177624143) ^ 0x6BC83600);
					continue;
				case 2u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = ((int)num2 * -1368147619) ^ -213332255;
					continue;
				case 0u:
					num = ((int)num2 * -888919806) ^ -2098721854;
					continue;
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

	private void RegisterRecieverBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1142880726;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEC41106Bu) % 18u)
				{
				case 17u:
					num = ((int)num2 * -2010783418) ^ -23167595;
					continue;
				case 16u:
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					num = (int)((num2 * 1753275690) ^ 0x5AEE2291);
					continue;
				case 15u:
					num = (int)(num2 * 2024656069) ^ -742025458;
					continue;
				case 14u:
					num = (int)(num2 * 1995791600) ^ -880855975;
					continue;
				case 13u:
					Form2.smethod_13((Control)(object)BloodBankPanel1, Color.DarkBlue);
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.DarkBlue);
					num = ((int)num2 * -249976039) ^ 0x261C8BE5;
					continue;
				case 12u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)(num2 * 388971295) ^ -867780317;
					continue;
				case 11u:
					num = ((int)num2 * -1325969628) ^ -191530674;
					continue;
				case 9u:
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					num = (int)((num2 * 292739622) ^ 0x6F0C86DC);
					continue;
				case 8u:
					num = (int)(num2 * 417992867) ^ -1315482467;
					continue;
				case 7u:
					Form2.smethod_55((Control)(object)BloodBankPanel1, Form2.smethod_54((Control)(object)RegisterRecieverBtn));
					num = (int)((num2 * 1878591970) ^ 0x1E1F56C2);
					continue;
				case 6u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					num = ((int)num2 * -1498461294) ^ -1822411241;
					continue;
				case 5u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = ((int)num2 * -148800360) ^ -767097034;
					continue;
				case 4u:
					Form2.smethod_55((Control)(object)BloodBankPanel2, Form2.smethod_54((Control)(object)RegisterRecieverBtn));
					num = (int)(num2 * 912888627) ^ -283195594;
					continue;
				case 2u:
					num = (int)((num2 * 9006795) ^ 0x4A7AA85E);
					continue;
				case 1u:
					Form2.smethod_13((Control)(object)PatientPanel1, Color.Transparent);
					num = ((int)num2 * -894437745) ^ -1470527161;
					continue;
				case 0u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.Transparent);
					num = ((int)num2 * -2002617852) ^ -188069281;
					continue;
				case 10u:
					break;
				default:
					Form2.smethod_25(Form2.smethod_24((Control)(object)StaffPanel), (Control)(object)new RegisterReciever());
					return;
				}
				break;
			}
		}
	}

	private void AvailabilityBtn_Click(object sender, EventArgs e)
	{
		Form2.smethod_13((Control)(object)PatientPanel1, Color.Transparent);
		while (true)
		{
			int num = -1548858928;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF2679AE2u) % 15u)
				{
				case 14u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = (int)(num2 * 210145257) ^ -1599948006;
					continue;
				case 13u:
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					num = ((int)num2 * -175757459) ^ 0x319A27A4;
					continue;
				case 12u:
					num = ((int)num2 * -504462333) ^ 0x598ADE4;
					continue;
				case 11u:
					Form2.smethod_13((Control)(object)StaffPanel2, Color.DarkBlue);
					num = ((int)num2 * -1259128941) ^ 0x46035E09;
					continue;
				case 10u:
					num = ((int)num2 * -478542750) ^ 0x7B65274D;
					continue;
				case 9u:
					num = ((int)num2 * -474493927) ^ -1521884343;
					continue;
				case 8u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)((num2 * 1207296075) ^ 0x2D9AE85C);
					continue;
				case 6u:
					num = (int)(num2 * 986544059) ^ -908980386;
					continue;
				case 5u:
					num = (int)((num2 * 1078205322) ^ 0x49A6660C);
					continue;
				case 4u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.DarkBlue);
					num = (int)((num2 * 508595519) ^ 0x6F9AE660);
					continue;
				case 3u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.Transparent);
					num = (int)(num2 * 754659455) ^ -125109008;
					continue;
				case 2u:
					Form2.smethod_13((Control)(object)BloodBankPanel1, Color.Transparent);
					num = (int)((num2 * 2130230804) ^ 0x27F3D0B7);
					continue;
				case 1u:
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.Transparent);
					num = ((int)num2 * -1568783956) ^ -1252843413;
					continue;
				case 0u:
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
		while (true)
		{
			int num = -740339771;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF864231Fu) % 18u)
				{
				case 17u:
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					num = ((int)num2 * -884873921) ^ -614811618;
					continue;
				case 16u:
					num = ((int)num2 * -50935641) ^ 0x6C505D2D;
					continue;
				case 15u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					num = (int)(num2 * 1913176886) ^ -2035444774;
					continue;
				case 14u:
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					Form2.smethod_25(Form2.smethod_24((Control)(object)StaffPanel), (Control)(object)new RegisterDonor());
					num = ((int)num2 * -834034955) ^ 0xF996D13;
					continue;
				case 13u:
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.DarkBlue);
					num = (int)((num2 * 1408694070) ^ 0x773ECA73);
					continue;
				case 11u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.Transparent);
					Form2.smethod_55((Control)(object)BloodBankPanel1, Form2.smethod_54((Control)(object)RegisterDonorBtn));
					num = (int)((num2 * 609567509) ^ 0x3C2F2046);
					continue;
				case 10u:
					Form2.smethod_55((Control)(object)BloodBankPanel2, Form2.smethod_54((Control)(object)RegisterDonorBtn));
					num = (int)(num2 * 1307221019) ^ -3431190;
					continue;
				case 9u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.Transparent);
					num = (int)((num2 * 1610500713) ^ 0x161BA353);
					continue;
				case 7u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = ((int)num2 * -206196052) ^ -1159618746;
					continue;
				case 6u:
					num = (int)(num2 * 491448294) ^ -54434036;
					continue;
				case 5u:
					num = (int)((num2 * 1281335255) ^ 0x767FAD0F);
					continue;
				case 4u:
					Form2.smethod_13((Control)(object)PatientPanel1, Color.Transparent);
					num = (int)(num2 * 415552023) ^ -1865808806;
					continue;
				case 3u:
					num = (int)(num2 * 747326333) ^ -1578463027;
					continue;
				case 2u:
					num = (int)(num2 * 281307916) ^ -2016756988;
					continue;
				case 1u:
					Form2.smethod_13((Control)(object)BloodBankPanel1, Color.DarkBlue);
					num = ((int)num2 * -1878599871) ^ -1404745212;
					continue;
				case 0u:
					num = ((int)num2 * -1278612576) ^ -871164095;
					continue;
				default:
					return;
				case 8u:
					break;
				case 12u:
					return;
				}
				break;
			}
		}
	}

	private void BloodAvailabilityBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1997484664;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4D5DEB37u) % 16u)
				{
				case 15u:
					Form2.smethod_13((Control)(object)PatientPanel1, Color.Transparent);
					num = (int)(num2 * 2113235029) ^ -432384024;
					continue;
				case 14u:
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.DarkBlue);
					num = ((int)num2 * -1750636820) ^ 0x4AD90C7C;
					continue;
				case 13u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)(num2 * 1804915915) ^ -245977980;
					continue;
				case 12u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = ((int)num2 * -2107177336) ^ -137638362;
					continue;
				case 9u:
					num = (int)((num2 * 60782103) ^ 0x542C4430);
					continue;
				case 8u:
					Form2.smethod_55((Control)(object)BloodBankPanel2, Form2.smethod_54((Control)(object)BloodAvailabilityBtn));
					num = (int)((num2 * 1170421936) ^ 0x25011572);
					continue;
				case 7u:
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					num = ((int)num2 * -236088016) ^ 0x59D998DA;
					continue;
				case 6u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					num = (int)((num2 * 1132345118) ^ 0x2D6E0E4);
					continue;
				case 5u:
					Form2.smethod_13((Control)(object)BloodBankPanel1, Color.DarkBlue);
					num = ((int)num2 * -889948759) ^ -826231964;
					continue;
				case 4u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.Transparent);
					num = (int)((num2 * 318817772) ^ 0x3DD2931);
					continue;
				case 3u:
					num = (int)((num2 * 856937704) ^ 0x13B1474D);
					continue;
				case 2u:
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					num = ((int)num2 * -659737220) ^ -450395633;
					continue;
				case 1u:
					Form2.smethod_55((Control)(object)BloodBankPanel1, Form2.smethod_54((Control)(object)BloodAvailabilityBtn));
					num = (int)(num2 * 1630493263) ^ -1146995231;
					continue;
				case 0u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)StaffPanel), (Control)(object)new BloodAvailability());
					num = (int)((num2 * 2112909108) ^ 0x4EC8117D);
					continue;
				default:
					return;
				case 11u:
					break;
				case 10u:
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
			int num = -1595415616;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCEF0B132u) % 16u)
				{
				case 15u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					num = ((int)num2 * -744041018) ^ -1222292912;
					continue;
				case 13u:
					Form2.smethod_55((Control)(object)PersonalInfoPanel1, Form2.smethod_54((Control)(object)EditProfileBtn));
					num = (int)(num2 * 233856820) ^ -509275590;
					continue;
				case 12u:
					Form2.smethod_55((Control)(object)PersonalInfoPanel2, Form2.smethod_54((Control)(object)EditProfileBtn));
					num = ((int)num2 * -844246491) ^ 0x6CF8D998;
					continue;
				case 11u:
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					num = (int)((num2 * 1161287319) ^ 0x2D7572CF);
					continue;
				case 10u:
					num = ((int)num2 * -1974987094) ^ -1540571139;
					continue;
				case 9u:
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					num = (int)((num2 * 145138505) ^ 0x7A65C11C);
					continue;
				case 8u:
					num = ((int)num2 * -1076583636) ^ 0x4FB5E95F;
					continue;
				case 7u:
					num = (int)(num2 * 52956307) ^ -750990967;
					continue;
				case 6u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.DarkBlue);
					num = ((int)num2 * -593037471) ^ -363220416;
					continue;
				case 5u:
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.Transparent);
					num = (int)(num2 * 1143073040) ^ -1005313717;
					continue;
				case 4u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.DarkBlue);
					num = (int)((num2 * 625292667) ^ 0x2E0BED34);
					continue;
				case 2u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.Transparent);
					num = ((int)num2 * -818150031) ^ -1675106351;
					continue;
				case 1u:
					Form2.smethod_13((Control)(object)BloodBankPanel1, Color.Transparent);
					num = (int)((num2 * 555192720) ^ 0x3DAF4947);
					continue;
				case 0u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)StaffPanel), (Control)(object)new EditProfile());
					num = ((int)num2 * -599951122) ^ 0x6E22F05;
					continue;
				default:
					return;
				case 3u:
					break;
				case 14u:
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
			int num = 1561645861;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x50C9456Du) % 15u)
				{
				case 14u:
					num = ((int)num2 * -1721991703) ^ -15052183;
					continue;
				case 13u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.DarkBlue);
					num = ((int)num2 * -1672286433) ^ -65958253;
					continue;
				case 11u:
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					num = (int)((num2 * 1545317898) ^ 0x12DC9F6);
					continue;
				case 10u:
					num = ((int)num2 * -2022636137) ^ 0x223A0C1D;
					continue;
				case 9u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					num = ((int)num2 * -1868681928) ^ 0x5EBF9C9C;
					continue;
				case 8u:
					num = ((int)num2 * -1657670238) ^ -1393520448;
					continue;
				case 7u:
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					MyProject.Forms.Form1.username = "";
					MyProject.Forms.Form1.login_type = "";
					Form2.smethod_57((Form)(object)this);
					num = (int)((num2 * 198559708) ^ 0x49E58437);
					continue;
				case 6u:
					Form2.smethod_13((Control)(object)PatientPanel1, Color.Transparent);
					num = ((int)num2 * -2055373366) ^ -644208925;
					continue;
				case 5u:
					Form2.smethod_13((Control)(object)BloodBankPanel1, Color.Transparent);
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.Transparent);
					num = ((int)num2 * -168137935) ^ 0x3711122B;
					continue;
				case 4u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.DarkBlue);
					num = (int)((num2 * 1950115594) ^ 0x2F7436AB);
					continue;
				case 3u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.Transparent);
					num = ((int)num2 * -1580487259) ^ -139126874;
					continue;
				case 1u:
					Form2.smethod_55((Control)(object)PersonalInfoPanel1, Form2.smethod_54((Control)(object)LogoutBtn));
					num = (int)(num2 * 1889559326) ^ -967512349;
					continue;
				case 0u:
					Form2.smethod_55((Control)(object)PersonalInfoPanel2, Form2.smethod_54((Control)(object)LogoutBtn));
					num = ((int)num2 * -1028171271) ^ -1103583096;
					continue;
				case 2u:
					break;
				default:
					Form2.smethod_58((Control)(object)MyProject.Forms.Form1);
					return;
				}
				break;
			}
		}
	}

	private void Form2_FormClosed(object sender, FormClosedEventArgs e)
	{
		MyProject.Forms.Form1.username = "";
		while (true)
		{
			int num = 18670711;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x14FFEE21u) % 4u)
				{
				case 2u:
					MyProject.Forms.Form1.login_type = "";
					num = (int)((num2 * 1842256534) ^ 0x301CA794);
					continue;
				case 1u:
					Form2.smethod_58((Control)(object)MyProject.Forms.Form1);
					num = (int)(num2 * 2110495107) ^ -1417259103;
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

	private void Form2_Shown(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 2059852164;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3C0F82E9u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 727661956) ^ 0x665A2441);
					continue;
				case 1u:
					Form2.smethod_59((Control)(object)this);
					num = ((int)num2 * -1160870739) ^ 0xA28DDFE;
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

	private void Form2_Load(object sender, EventArgs e)
	{
		Form2.smethod_60((Form)(object)this, bool_0: true);
		while (true)
		{
			int num = 390851269;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x74CF1A58u) % 4u)
				{
				case 1u:
					Form2.smethod_61((Form)(object)this, (AutoSizeMode)0);
					num = ((int)num2 * -354049250) ^ 0x1D17872E;
					continue;
				case 0u:
					num = (int)(num2 * 314863997) ^ -1470137509;
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
