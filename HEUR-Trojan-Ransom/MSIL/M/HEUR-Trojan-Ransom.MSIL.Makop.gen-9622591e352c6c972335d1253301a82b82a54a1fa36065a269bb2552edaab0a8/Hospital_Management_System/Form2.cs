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
				int num = -892507041;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x974090B7u) % 9u)
					{
					case 8u:
						Form2.smethod_53((Control)(object)logoutBtn, eventHandler_);
						num = ((int)num2 * -1279665368) ^ 0x7EB6341C;
						continue;
					case 7u:
						logoutBtn = _LogoutBtn;
						num = ((int)num2 * -1877247806) ^ 0x308D4CD7;
						continue;
					case 6u:
						_LogoutBtn = value;
						num = -1625256316;
						continue;
					case 5u:
						logoutBtn = _LogoutBtn;
						num = ((int)num2 * -484545876) ^ -454942266;
						continue;
					case 3u:
					{
						int num5;
						int num6;
						if (logoutBtn != null)
						{
							num5 = 1486550207;
							num6 = 1486550207;
						}
						else
						{
							num5 = 1339080267;
							num6 = 1339080267;
						}
						num = num5 ^ (int)(num2 * 1126175219);
						continue;
					}
					case 2u:
						Form2.smethod_52((Control)(object)logoutBtn, eventHandler_);
						num = ((int)num2 * -797850708) ^ 0x2E7C5BFD;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (logoutBtn != null)
						{
							num3 = 1112318985;
							num4 = 1112318985;
						}
						else
						{
							num3 = 1421320885;
							num4 = 1421320885;
						}
						num = num3 ^ ((int)num2 * -1929707438);
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
			Button editProfileBtn = _EditProfileBtn;
			if (editProfileBtn != null)
			{
				goto IL_0040;
			}
			goto IL_009a;
			IL_009a:
			_EditProfileBtn = value;
			editProfileBtn = _EditProfileBtn;
			int num = 678255685;
			goto IL_0071;
			IL_0071:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x17DDBAB8u) % 6u)
				{
				case 5u:
				{
					int num3;
					int num4;
					if (editProfileBtn == null)
					{
						num3 = 1178239151;
						num4 = 1178239151;
					}
					else
					{
						num3 = 84901010;
						num4 = 84901010;
					}
					num = num3 ^ ((int)num2 * -1914438235);
					continue;
				}
				case 4u:
					break;
				case 3u:
					Form2.smethod_53((Control)(object)editProfileBtn, eventHandler_);
					num = ((int)num2 * -1506064990) ^ 0x72BB8EE8;
					continue;
				case 1u:
					Form2.smethod_52((Control)(object)editProfileBtn, eventHandler_);
					num = ((int)num2 * -85388390) ^ 0xFA716D6;
					continue;
				default:
					return;
				case 2u:
					goto IL_009a;
				case 0u:
					return;
				}
				break;
			}
			goto IL_0040;
			IL_0040:
			num = 387729593;
			goto IL_0071;
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
			if (availabilityBtn != null)
			{
				goto IL_0032;
			}
			goto IL_00b4;
			IL_00b4:
			_AvailabilityBtn = value;
			int num = -145256264;
			goto IL_0087;
			IL_0087:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF7BA26EFu) % 7u)
				{
				case 5u:
					Form2.smethod_53((Control)(object)availabilityBtn, eventHandler_);
					num = (int)(num2 * 716397792) ^ -394227426;
					continue;
				case 4u:
					break;
				case 3u:
					Form2.smethod_52((Control)(object)availabilityBtn, eventHandler_);
					num = ((int)num2 * -1551019597) ^ 0x439A8858;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (availabilityBtn != null)
					{
						num3 = -289106677;
						num4 = -289106677;
					}
					else
					{
						num3 = -889898934;
						num4 = -889898934;
					}
					num = num3 ^ ((int)num2 * -1825607533);
					continue;
				}
				case 1u:
					availabilityBtn = _AvailabilityBtn;
					num = (int)(num2 * 1773799311) ^ -160658774;
					continue;
				default:
					return;
				case 6u:
					goto IL_00b4;
				case 0u:
					return;
				}
				break;
			}
			goto IL_0032;
			IL_0032:
			num = -1785006288;
			goto IL_0087;
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
				int num = -700193958;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE0E2E3A4u) % 6u)
					{
					case 4u:
					{
						checkUpBtn = _CheckUpBtn;
						int num4;
						int num5;
						if (checkUpBtn != null)
						{
							num4 = -462776995;
							num5 = -462776995;
						}
						else
						{
							num4 = -552841294;
							num5 = -552841294;
						}
						num = num4 ^ (int)(num2 * 72980879);
						continue;
					}
					case 3u:
						Form2.smethod_52((Control)(object)checkUpBtn, eventHandler_);
						num = ((int)num2 * -607382798) ^ -1558340138;
						continue;
					case 1u:
						Form2.smethod_53((Control)(object)checkUpBtn, eventHandler_);
						num = (int)((num2 * 365207923) ^ 0x124756B7);
						continue;
					case 0u:
					{
						_CheckUpBtn = value;
						checkUpBtn = _CheckUpBtn;
						int num3;
						if (checkUpBtn != null)
						{
							num = -2064303561;
							num3 = -2064303561;
						}
						else
						{
							num = -2007013698;
							num3 = -2007013698;
						}
						continue;
					}
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
			if (updateDetailsBtn != null)
			{
				goto IL_006c;
			}
			goto IL_009a;
			IL_009a:
			_UpdateDetailsBtn = value;
			updateDetailsBtn = _UpdateDetailsBtn;
			int num = -160447343;
			goto IL_0071;
			IL_0071:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFA548A00u) % 6u)
				{
				case 5u:
					Form2.smethod_52((Control)(object)updateDetailsBtn, eventHandler_);
					num = (int)((num2 * 1751292868) ^ 0x483AA2C4);
					continue;
				case 4u:
					Form2.smethod_53((Control)(object)updateDetailsBtn, eventHandler_);
					num = ((int)num2 * -1148675611) ^ -1441960761;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (updateDetailsBtn != null)
					{
						num3 = 1964879369;
						num4 = 1964879369;
					}
					else
					{
						num3 = 4694550;
						num4 = 4694550;
					}
					num = num3 ^ ((int)num2 * -184837469);
					continue;
				}
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_009a;
				case 1u:
					return;
				}
				break;
			}
			goto IL_006c;
			IL_006c:
			num = -501863051;
			goto IL_0071;
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
				int num = -384792821;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF4D241A0u) % 9u)
					{
					case 7u:
					{
						int num5;
						int num6;
						if (admitBtn != null)
						{
							num5 = -763059819;
							num6 = -763059819;
						}
						else
						{
							num5 = -1365232887;
							num6 = -1365232887;
						}
						num = num5 ^ ((int)num2 * -1386434238);
						continue;
					}
					case 5u:
						Form2.smethod_53((Control)(object)admitBtn, eventHandler_);
						num = (int)(num2 * 1462368526) ^ -364680733;
						continue;
					case 4u:
						_AdmitBtn = value;
						num = -177186873;
						continue;
					case 3u:
						admitBtn = _AdmitBtn;
						num = ((int)num2 * -589225430) ^ -1983742364;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (admitBtn != null)
						{
							num3 = 1519922565;
							num4 = 1519922565;
						}
						else
						{
							num3 = 1389938012;
							num4 = 1389938012;
						}
						num = num3 ^ (int)(num2 * 577924500);
						continue;
					}
					case 1u:
						admitBtn = _AdmitBtn;
						num = (int)((num2 * 1952931836) ^ 0x445EF44A);
						continue;
					case 0u:
						Form2.smethod_52((Control)(object)admitBtn, eventHandler_);
						num = ((int)num2 * -493020531) ^ 0x584FE6DD;
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
				int num = 565298507;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x14D32A81u) % 8u)
					{
					case 7u:
						registrationBtn = _RegistrationBtn;
						num = (int)((num2 * 900586512) ^ 0x4922DB6A);
						continue;
					case 5u:
						Form2.smethod_53((Control)(object)registrationBtn, eventHandler_);
						num = ((int)num2 * -1022435764) ^ 0x18B82EDB;
						continue;
					case 4u:
						_RegistrationBtn = value;
						num = 1496911126;
						continue;
					case 3u:
					{
						int num5;
						int num6;
						if (registrationBtn == null)
						{
							num5 = -1740581559;
							num6 = -1740581559;
						}
						else
						{
							num5 = -2014217110;
							num6 = -2014217110;
						}
						num = num5 ^ (int)(num2 * 341836458);
						continue;
					}
					case 2u:
					{
						registrationBtn = _RegistrationBtn;
						int num3;
						int num4;
						if (registrationBtn == null)
						{
							num3 = -299852455;
							num4 = -299852455;
						}
						else
						{
							num3 = -1533737764;
							num4 = -1533737764;
						}
						num = num3 ^ (int)(num2 * 1512123390);
						continue;
					}
					case 1u:
						Form2.smethod_52((Control)(object)registrationBtn, eventHandler_);
						num = (int)(num2 * 655580950) ^ -1369042429;
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
			Button bloodAvailabilityBtn = _BloodAvailabilityBtn;
			if (bloodAvailabilityBtn != null)
			{
				goto IL_0032;
			}
			goto IL_009a;
			IL_009a:
			_BloodAvailabilityBtn = value;
			bloodAvailabilityBtn = _BloodAvailabilityBtn;
			int num = -1068300835;
			goto IL_0071;
			IL_0071:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF0E720B3u) % 6u)
				{
				case 4u:
					Form2.smethod_52((Control)(object)bloodAvailabilityBtn, eventHandler_);
					num = (int)((num2 * 2138695816) ^ 0x4DB8DEF8);
					continue;
				case 2u:
					break;
				case 1u:
					Form2.smethod_53((Control)(object)bloodAvailabilityBtn, eventHandler_);
					num = (int)(num2 * 1234086908) ^ -1512964736;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (bloodAvailabilityBtn != null)
					{
						num3 = -1811228318;
						num4 = -1811228318;
					}
					else
					{
						num3 = -1017522800;
						num4 = -1017522800;
					}
					num = num3 ^ (int)(num2 * 2017680258);
					continue;
				}
				default:
					return;
				case 3u:
					goto IL_009a;
				case 5u:
					return;
				}
				break;
			}
			goto IL_0032;
			IL_0032:
			num = -1522655999;
			goto IL_0071;
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
				int num = -1776712062;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD84ACE14u) % 8u)
					{
					case 6u:
						registerRecieverBtn = _RegisterRecieverBtn;
						num = ((int)num2 * -1858389755) ^ 0x71C7235E;
						continue;
					case 5u:
						Form2.smethod_53((Control)(object)registerRecieverBtn, eventHandler_);
						num = (int)(num2 * 1914303346) ^ -1566367802;
						continue;
					case 4u:
					{
						int num5;
						int num6;
						if (registerRecieverBtn != null)
						{
							num5 = 107345657;
							num6 = 107345657;
						}
						else
						{
							num5 = 618345554;
							num6 = 618345554;
						}
						num = num5 ^ (int)(num2 * 725563639);
						continue;
					}
					case 3u:
					{
						int num3;
						int num4;
						if (registerRecieverBtn != null)
						{
							num3 = 550352474;
							num4 = 550352474;
						}
						else
						{
							num3 = 2084358375;
							num4 = 2084358375;
						}
						num = num3 ^ (int)(num2 * 1085712849);
						continue;
					}
					case 2u:
						_RegisterRecieverBtn = value;
						registerRecieverBtn = _RegisterRecieverBtn;
						num = -269594017;
						continue;
					case 1u:
						Form2.smethod_52((Control)(object)registerRecieverBtn, eventHandler_);
						num = ((int)num2 * -2113959423) ^ 0x4DDA66BF;
						continue;
					default:
						return;
					case 7u:
						break;
					case 0u:
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
				int num = 370182725;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x662B7339u) % 6u)
					{
					case 5u:
					{
						_RegisterDonorBtn = value;
						registerDonorBtn = _RegisterDonorBtn;
						int num5;
						if (registerDonorBtn == null)
						{
							num = 427602836;
							num5 = 427602836;
						}
						else
						{
							num = 281441529;
							num5 = 281441529;
						}
						continue;
					}
					case 4u:
					{
						registerDonorBtn = _RegisterDonorBtn;
						int num3;
						int num4;
						if (registerDonorBtn == null)
						{
							num3 = 1104042484;
							num4 = 1104042484;
						}
						else
						{
							num3 = 786001446;
							num4 = 786001446;
						}
						num = num3 ^ ((int)num2 * -168781733);
						continue;
					}
					case 2u:
						Form2.smethod_53((Control)(object)registerDonorBtn, eventHandler_);
						num = ((int)num2 * -669418788) ^ -229074284;
						continue;
					case 1u:
						Form2.smethod_52((Control)(object)registerDonorBtn, eventHandler_);
						num = (int)(num2 * 2024020504) ^ -402794008;
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
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		while (true)
		{
			int num = -871474411;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xECBE2F8Bu) % 4u)
				{
				case 2u:
					Form2.smethod_0((Form)(object)this, new FormClosedEventHandler(Form2_FormClosed));
					Form2.smethod_1((Form)(object)this, (EventHandler)Form2_Shown);
					num = ((int)num2 * -538830925) ^ -339063596;
					continue;
				case 1u:
					Form2.smethod_2((Form)(object)this, (EventHandler)Form2_Load);
					InitializeComponent();
					num = ((int)num2 * -677998939) ^ 0x50E61B1E;
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

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing)
			{
				goto IL_0047;
			}
			goto IL_0080;
			IL_0047:
			int num = 323798405;
			goto IL_004c;
			IL_004c:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4FC553A1u) % 6u)
				{
				case 5u:
					num = 1893930764;
					continue;
				case 2u:
					num = (int)((num2 * 1855115268) ^ 0x6A13DB9E);
					continue;
				case 1u:
					Form2.smethod_3((IDisposable)components);
					num = ((int)num2 * -631386005) ^ -807039548;
					continue;
				case 0u:
					break;
				default:
					return;
				case 4u:
					goto IL_0075;
				case 3u:
					return;
				}
				break;
				IL_0075:
				if (components != null)
				{
					num = 2009556034;
					num3 = 2009556034;
					continue;
				}
				goto IL_0080;
			}
			goto IL_0047;
			IL_0080:
			num = 2086686094;
			num3 = 2086686094;
			goto IL_004c;
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0789: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca8: Unknown result type (might be due to invalid IL or missing references)
		//IL_150d: Unknown result type (might be due to invalid IL or missing references)
		//IL_16dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cac: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d43: Unknown result type (might be due to invalid IL or missing references)
		//IL_235c: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = -1941839309;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xED02CFFBu) % 337u)
				{
				case 336u:
					Form2.smethod_37(PictureBox1, 7);
					num = ((int)num2 * -549176155) ^ -1690551515;
					continue;
				case 335u:
					Form2.smethod_27(GroupBox2, "Patient");
					num = (int)(num2 * 535232435) ^ -1912367237;
					continue;
				case 334u:
					Form2.smethod_30((ButtonBase)(object)RegisterDonorBtn, (FlatStyle)0);
					num = (int)(num2 * 2088492297) ^ -987407871;
					continue;
				case 333u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox2), (Control)(object)UpdateDetailsBtn);
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox2), (Control)(object)AdmitBtn);
					num = (int)(num2 * 920630487) ^ -711245812;
					continue;
				case 332u:
					num = ((int)num2 * -1248600414) ^ -2061420426;
					continue;
				case 331u:
					Form2.smethod_18((Control)(object)RegistrationBtn, "RegistrationBtn");
					Form2.smethod_19((Control)(object)RegistrationBtn, new Size(306, 50));
					num = (int)((num2 * 422393734) ^ 0x5F21131A);
					continue;
				case 330u:
					Form2.smethod_15((Control)(object)RegisterDonorBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1846259271) ^ -405666875;
					continue;
				case 329u:
					num = ((int)num2 * -790018505) ^ -315002708;
					continue;
				case 328u:
					Form2.smethod_19((Control)(object)GroupBox3, new Size(351, 114));
					num = (int)(num2 * 8151911) ^ -1171148181;
					continue;
				case 327u:
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)CheckUpBtn), 0);
					num = ((int)num2 * -10985010) ^ 0x2B4C2CF6;
					continue;
				case 326u:
					Panel1 = Form2.smethod_5();
					GroupBox5 = Form2.smethod_6();
					num = (int)((num2 * 307091451) ^ 0x7B33CA31);
					continue;
				case 325u:
					num = (int)(num2 * 164195067) ^ -958806437;
					continue;
				case 324u:
					Form2.smethod_13((Control)(object)Panel1, Color.White);
					num = (int)(num2 * 1098458131) ^ -379770113;
					continue;
				case 323u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox3), (Control)(object)AvailabilityBtn);
					num = (int)((num2 * 1433341172) ^ 0x4B4FE32F);
					continue;
				case 322u:
					Form2.smethod_13((Control)(object)GroupBox2, Color.White);
					num = (int)(num2 * 180201082) ^ -1259174350;
					continue;
				case 321u:
					Form2.smethod_20((Control)(object)AdmitBtn, 3);
					num = ((int)num2 * -1924224568) ^ -651269958;
					continue;
				case 320u:
					num = ((int)num2 * -1482139058) ^ 0x337E629D;
					continue;
				case 319u:
					num = ((int)num2 * -430788693) ^ 0x4F746759;
					continue;
				case 318u:
					Form2.smethod_40((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 351773050) ^ -2022989979;
					continue;
				case 317u:
					Form2.smethod_17((Control)(object)RegisterDonorBtn, new Point(20, 38));
					num = ((int)num2 * -1339530621) ^ -290020562;
					continue;
				case 316u:
					UpdateDetailsBtn = Form2.smethod_7();
					num = ((int)num2 * -977307125) ^ -1775327138;
					continue;
				case 315u:
					Form2.smethod_48((Control)(object)GroupBox3, bool_0: false);
					Form2.smethod_48((Control)(object)GroupBox2, bool_0: false);
					num = ((int)num2 * -49065454) ^ 0x75C112ED;
					continue;
				case 314u:
					num = ((int)num2 * -1481350343) ^ 0x7E15A110;
					continue;
				case 313u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.Transparent);
					Form2.smethod_17((Control)(object)PersonalInfoPanel2, new Point(307, 52));
					num = ((int)num2 * -940266962) ^ 0x2FCD86BF;
					continue;
				case 312u:
					Form2.smethod_33((ButtonBase)(object)LogoutBtn, bool_0: true);
					num = ((int)num2 * -307587887) ^ -1884830944;
					continue;
				case 311u:
					Form2.smethod_18((Control)(object)GroupBox3, "GroupBox3");
					num = (int)((num2 * 822693953) ^ 0x475D70EE);
					continue;
				case 310u:
					Form2.smethod_9((Control)(object)GroupBox5);
					Form2.smethod_9((Control)(object)GroupBox3);
					num = (int)((num2 * 1441957405) ^ 0x2E533AE9);
					continue;
				case 309u:
					num = ((int)num2 * -1560747050) ^ -625368000;
					continue;
				case 308u:
					Form2.smethod_31((Control)(object)RegisterRecieverBtn, new Padding(0));
					num = ((int)num2 * -2021380355) ^ -1653235706;
					continue;
				case 307u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox2), (Control)(object)PatientPanel1);
					num = ((int)num2 * -2042880027) ^ 0x34C43B48;
					continue;
				case 306u:
					Form2.smethod_33((ButtonBase)(object)BloodAvailabilityBtn, bool_0: true);
					num = (int)(num2 * 2126942816) ^ -1310986743;
					continue;
				case 305u:
					num = ((int)num2 * -827831681) ^ -674269636;
					continue;
				case 304u:
					Form2.smethod_18((Control)(object)LogoutBtn, "LogoutBtn");
					num = (int)(num2 * 1444842842) ^ -2012370372;
					continue;
				case 303u:
					Form2.smethod_49((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -506084911) ^ -1459498326;
					continue;
				case 302u:
					Form2.smethod_19((Control)(object)BloodBankPanel1, new Size(44, 50));
					num = (int)(num2 * 536711976) ^ -1622073619;
					continue;
				case 301u:
					Form2.smethod_19((Control)(object)RegisterDonorBtn, new Size(311, 50));
					num = (int)(num2 * 1631876746) ^ -1310459245;
					continue;
				case 300u:
					Form2.smethod_31((Control)(object)RegisterDonorBtn, new Padding(0));
					num = (int)((num2 * 659747155) ^ 0x1E1B13C9);
					continue;
				case 299u:
					Form2.smethod_39((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = (int)(num2 * 1222037222) ^ -971442208;
					continue;
				case 298u:
					num = ((int)num2 * -123589879) ^ -1003137691;
					continue;
				case 297u:
					num = (int)((num2 * 2135797102) ^ 0x3FF98E3A);
					continue;
				case 296u:
					num = ((int)num2 * -719629392) ^ 0x11B22B5C;
					continue;
				case 295u:
					Form2.smethod_9((Control)(object)GroupBox2);
					num = ((int)num2 * -29373662) ^ -1333096142;
					continue;
				case 294u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox3), (Control)(object)StaffPanel1);
					num = ((int)num2 * -975382919) ^ 0x11576B45;
					continue;
				case 293u:
					num = (int)((num2 * 820728357) ^ 0x3FB9C8B6);
					continue;
				case 292u:
					num = (int)(num2 * 980662119) ^ -1781720224;
					continue;
				case 291u:
					Form2.smethod_17((Control)(object)StaffPanel1, new Point(0, 37));
					Form2.smethod_18((Control)(object)StaffPanel1, "StaffPanel1");
					num = (int)(num2 * 1277288744) ^ -2086692060;
					continue;
				case 290u:
					num = (int)((num2 * 69351491) ^ 0x46794D2E);
					continue;
				case 289u:
					num = (int)(num2 * 1797560044) ^ -1198953191;
					continue;
				case 288u:
					num = ((int)num2 * -94406772) ^ -1765258813;
					continue;
				case 287u:
					Form2.smethod_19((Control)(object)Panel1, new Size(380, 825));
					num = (int)(num2 * 954431240) ^ -906557719;
					continue;
				case 286u:
					Form2.smethod_18((Control)(object)GroupBox2, "GroupBox2");
					num = ((int)num2 * -119508791) ^ -463574227;
					continue;
				case 285u:
					num = (int)((num2 * 2007426254) ^ 0x25650AC4);
					continue;
				case 284u:
					BloodBankPanel2 = Form2.smethod_5();
					num = ((int)num2 * -1256910533) ^ -289267989;
					continue;
				case 283u:
					Form2.smethod_31((Control)(object)AdmitBtn, new Padding(0));
					Form2.smethod_18((Control)(object)AdmitBtn, "AdmitBtn");
					num = ((int)num2 * -600942539) ^ -1232475923;
					continue;
				case 282u:
					PatientPanel1 = Form2.smethod_5();
					num = ((int)num2 * -1757617975) ^ 0x7B5BB7FC;
					continue;
				case 281u:
					Form2.smethod_17((Control)(object)PatientPanel2, new Point(307, 43));
					Form2.smethod_18((Control)(object)PatientPanel2, "PatientPanel2");
					Form2.smethod_19((Control)(object)PatientPanel2, new Size(44, 50));
					num = (int)((num2 * 1643868528) ^ 0x57A4C257);
					continue;
				case 280u:
					num = (int)((num2 * 594502818) ^ 0x22929F8C);
					continue;
				case 279u:
					RegisterRecieverBtn = Form2.smethod_7();
					num = ((int)num2 * -716126732) ^ -388703344;
					continue;
				case 278u:
					GroupBox4 = Form2.smethod_6();
					num = (int)((num2 * 1905742870) ^ 0x2147450E);
					continue;
				case 277u:
					num = (int)((num2 * 1396559353) ^ 0x76FEB9C3);
					continue;
				case 276u:
					Form2.smethod_31((Control)(object)GroupBox2, new Padding(0));
					num = (int)((num2 * 1238105356) ^ 0x4C62F3BE);
					continue;
				case 275u:
					PatientPanel2 = Form2.smethod_5();
					num = (int)(num2 * 1293350720) ^ -1561030111;
					continue;
				case 274u:
					num = ((int)num2 * -830662351) ^ 0xE28C49B;
					continue;
				case 273u:
					num = (int)((num2 * 2054411799) ^ 0x7DA2681F);
					continue;
				case 272u:
					Form2.smethod_19((Control)(object)LogoutBtn, new Size(311, 50));
					Form2.smethod_20((Control)(object)LogoutBtn, 6);
					num = (int)(num2 * 135690423) ^ -35164225;
					continue;
				case 271u:
					num = ((int)num2 * -1850214834) ^ -987984510;
					continue;
				case 270u:
					Form2.smethod_12(Label1, bool_0: true);
					num = ((int)num2 * -1013653207) ^ -1197732659;
					continue;
				case 269u:
					Form2.smethod_48((Control)(object)GroupBox4, bool_0: false);
					num = ((int)num2 * -1531361726) ^ 0x1E916D95;
					continue;
				case 268u:
					Form2.smethod_18((Control)(object)PersonalInfoPanel1, "PersonalInfoPanel1");
					num = (int)(num2 * 1024924961) ^ -1481461795;
					continue;
				case 267u:
					num = ((int)num2 * -2074213690) ^ -1850148713;
					continue;
				case 266u:
					Form2.smethod_42((Form)(object)this, new Size(1285, 973));
					num = ((int)num2 * -2061358633) ^ 0x455CD241;
					continue;
				case 265u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox2), (Control)(object)CheckUpBtn);
					num = (int)(num2 * 596931599) ^ -449928602;
					continue;
				case 264u:
					Form2.smethod_19((Control)(object)GroupBox5, new Size(351, 173));
					num = (int)((num2 * 1658861186) ^ 0x59D6E449);
					continue;
				case 263u:
					Form2.smethod_33((ButtonBase)(object)AvailabilityBtn, bool_0: true);
					num = ((int)num2 * -1490013186) ^ -1390063449;
					continue;
				case 262u:
					Form2.smethod_50((Control)(object)this, bool_0: false);
					num = (int)((num2 * 1350788860) ^ 0x2313BD69);
					continue;
				case 261u:
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)RegistrationBtn), 0);
					num = (int)(num2 * 794045100) ^ -160561866;
					continue;
				case 260u:
					num = (int)(num2 * 1761148182) ^ -1319119127;
					continue;
				case 259u:
					num = (int)(num2 * 363979129) ^ -1725687854;
					continue;
				case 258u:
					Form2.smethod_15((Control)(object)UpdateDetailsBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1598440590) ^ -693349714;
					continue;
				case 257u:
					num = (int)(num2 * 1731974475) ^ -174399947;
					continue;
				case 256u:
					Form2.smethod_18((Control)(object)GroupBox5, "GroupBox5");
					num = (int)((num2 * 435959470) ^ 0x4A811341);
					continue;
				case 255u:
					num = ((int)num2 * -361776532) ^ 0x424638D2;
					continue;
				case 254u:
					Form2.smethod_31((Control)(object)EditProfileBtn, new Padding(0));
					num = ((int)num2 * -2118135307) ^ 0x4EE9470F;
					continue;
				case 253u:
					num = ((int)num2 * -1117905523) ^ -714801671;
					continue;
				case 252u:
					num = (int)((num2 * 1271962179) ^ 0x4505896B);
					continue;
				case 251u:
					StaffPanel1 = Form2.smethod_5();
					num = (int)(num2 * 614275523) ^ -1063406422;
					continue;
				case 250u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)Panel1), (Control)(object)GroupBox4);
					num = (int)(num2 * 1655367162) ^ -828346262;
					continue;
				case 249u:
					num = (int)((num2 * 242452279) ^ 0x3F85E638);
					continue;
				case 248u:
					num = ((int)num2 * -111274465) ^ 0x51E7C7AE;
					continue;
				case 247u:
					PersonalInfoPanel2 = Form2.smethod_5();
					num = (int)(num2 * 857119699) ^ -390570235;
					continue;
				case 246u:
					Form2.smethod_11((Control)(object)this);
					num = ((int)num2 * -2003742474) ^ 0x41725563;
					continue;
				case 245u:
					Form2.smethod_44((Control)(object)this, "Form2");
					num = ((int)num2 * -666284103) ^ -2102102107;
					continue;
				case 244u:
					LogoutBtn = Form2.smethod_7();
					num = (int)((num2 * 585721795) ^ 0x4AB5A1A5);
					continue;
				case 243u:
					Form2.smethod_33((ButtonBase)(object)UpdateDetailsBtn, bool_0: true);
					num = ((int)num2 * -764404100) ^ -312986467;
					continue;
				case 242u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					num = ((int)num2 * -1869021918) ^ -1928200855;
					continue;
				case 241u:
					num = ((int)num2 * -1397984552) ^ 0x611BBA0;
					continue;
				case 240u:
					num = ((int)num2 * -2038353690) ^ -1349680954;
					continue;
				case 239u:
					num = ((int)num2 * -666489095) ^ 0x36BD8BE5;
					continue;
				case 238u:
					Form2.smethod_13((Control)(object)PatientPanel1, Color.Transparent);
					Form2.smethod_15((Control)(object)PatientPanel1, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 2044728200) ^ 0x30C66F02);
					continue;
				case 237u:
					Form2.smethod_34((ButtonBase)(object)RegistrationBtn, Color.White);
					num = (int)(num2 * 321580696) ^ -1572006989;
					continue;
				case 236u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.Transparent);
					num = (int)((num2 * 1120481202) ^ 0x5A4A96F1);
					continue;
				case 235u:
					num = ((int)num2 * -699926849) ^ -60027592;
					continue;
				case 234u:
					Form2.smethod_32((ButtonBase)(object)AdmitBtn, "Admit/Discharge");
					num = (int)((num2 * 850898231) ^ 0x4BBEFB74);
					continue;
				case 233u:
					Form2.smethod_19((Control)(object)PersonalInfoPanel2, new Size(44, 50));
					num = ((int)num2 * -370935617) ^ -714457345;
					continue;
				case 232u:
					num = ((int)num2 * -404761059) ^ -590129336;
					continue;
				case 231u:
					num = (int)(num2 * 496931159) ^ -639042332;
					continue;
				case 230u:
					Form2.smethod_31((Control)(object)RegistrationBtn, new Padding(0));
					num = ((int)num2 * -1371124471) ^ 0x19728C00;
					continue;
				case 229u:
					Form2.smethod_20((Control)(object)PersonalInfoPanel1, 15);
					num = ((int)num2 * -659251362) ^ -342154977;
					continue;
				case 228u:
					Form2.smethod_17((Control)(object)AdmitBtn, new Point(25, 146));
					num = (int)(num2 * 1296649772) ^ -385852792;
					continue;
				case 227u:
					num = (int)((num2 * 1636904641) ^ 0x4E0BFD68);
					continue;
				case 226u:
					num = (int)((num2 * 1223395330) ^ 0x46CF88F3);
					continue;
				case 225u:
					Form2.smethod_18((Control)(object)AvailabilityBtn, "AvailabilityBtn");
					Form2.smethod_19((Control)(object)AvailabilityBtn, new Size(311, 50));
					num = (int)(num2 * 1668847699) ^ -2003727828;
					continue;
				case 224u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox2), (Control)(object)PatientPanel2);
					num = (int)(num2 * 2043533840) ^ -1683126344;
					continue;
				case 223u:
					Form2.smethod_15((Control)(object)AvailabilityBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Form2.smethod_17((Control)(object)AvailabilityBtn, new Point(20, 37));
					num = ((int)num2 * -1937160426) ^ -458151763;
					continue;
				case 222u:
					num = ((int)num2 * -568974423) ^ -1289338400;
					continue;
				case 221u:
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.Transparent);
					Form2.smethod_17((Control)(object)BloodBankPanel2, new Point(307, 38));
					num = ((int)num2 * -945597554) ^ 0x3633715B;
					continue;
				case 220u:
					num = (int)(num2 * 692494086) ^ -1396003189;
					continue;
				case 219u:
					num = ((int)num2 * -468928817) ^ 0x39220269;
					continue;
				case 218u:
					Form2.smethod_18((Control)(object)RegisterRecieverBtn, "RegisterRecieverBtn");
					num = (int)(num2 * 481909128) ^ -1476030948;
					continue;
				case 217u:
					Form2.smethod_26(GroupBox5, bool_0: false);
					num = ((int)num2 * -322956989) ^ -2024522968;
					continue;
				case 216u:
					Form2.smethod_19((Control)(object)PatientPanel1, new Size(44, 50));
					Form2.smethod_20((Control)(object)PatientPanel1, 0);
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox4), (Control)(object)BloodAvailabilityBtn);
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox4), (Control)(object)RegisterRecieverBtn);
					num = (int)((num2 * 932594380) ^ 0x4E12F65C);
					continue;
				case 215u:
					Form2.smethod_33((ButtonBase)(object)EditProfileBtn, bool_0: true);
					num = (int)((num2 * 1052216747) ^ 0x2FED404E);
					continue;
				case 214u:
					Form2.smethod_19((Control)(object)StaffPanel, new Size(977, 825));
					num = (int)(num2 * 1790742570) ^ -96558578;
					continue;
				case 213u:
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)RegisterRecieverBtn), 0);
					num = (int)(num2 * 847094824) ^ -454366146;
					continue;
				case 212u:
					num = ((int)num2 * -983127387) ^ -1176045101;
					continue;
				case 211u:
					num = (int)(num2 * 1525874374) ^ -629036189;
					continue;
				case 210u:
					num = ((int)num2 * -842808603) ^ 0x49DFCD16;
					continue;
				case 209u:
					Form2.smethod_38(PictureBox1, bool_0: false);
					num = ((int)num2 * -1769968548) ^ 0x1B89228C;
					continue;
				case 208u:
					Form2.smethod_30((ButtonBase)(object)UpdateDetailsBtn, (FlatStyle)0);
					num = (int)((num2 * 876467325) ^ 0x76E82EE8);
					continue;
				case 207u:
					num = (int)(num2 * 790841760) ^ -1089740185;
					continue;
				case 206u:
					num = (int)((num2 * 2118953918) ^ 0x7716B90D);
					continue;
				case 205u:
					num = ((int)num2 * -1388388610) ^ 0x3009B0;
					continue;
				case 204u:
					StaffPanel2 = Form2.smethod_5();
					num = (int)((num2 * 395741495) ^ 0x28EAD46F);
					continue;
				case 203u:
					Form2.smethod_20((Control)(object)GroupBox5, 12);
					num = (int)((num2 * 1217080766) ^ 0x44342BF0);
					continue;
				case 202u:
					PersonalInfoPanel1 = Form2.smethod_5();
					num = ((int)num2 * -2036286137) ^ -577808225;
					continue;
				case 201u:
					num = (int)(num2 * 1787653857) ^ -1574583860;
					continue;
				case 200u:
					num = ((int)num2 * -1602778957) ^ 0x5BE9EAD6;
					continue;
				case 199u:
					num = ((int)num2 * -679117244) ^ 0x7E2F9B4B;
					continue;
				case 198u:
					Form2.smethod_15((Control)(object)BloodAvailabilityBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1458573151) ^ 0x3121AE6B);
					continue;
				case 197u:
					Form2.smethod_47((Form)(object)this, (FormWindowState)2);
					Form2.smethod_48((Control)(object)Panel1, bool_0: false);
					num = (int)(num2 * 1072126733) ^ -152501848;
					continue;
				case 196u:
					num = (int)((num2 * 1952916994) ^ 0x50CAF0FD);
					continue;
				case 195u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox5), (Control)(object)LogoutBtn);
					num = (int)(num2 * 645966595) ^ -51781596;
					continue;
				case 194u:
					num = (int)((num2 * 599292807) ^ 0x73BE731B);
					continue;
				case 193u:
					Form2.smethod_20((Control)(object)StaffPanel, 3);
					num = ((int)num2 * -582945168) ^ 0x45E3BCD5;
					continue;
				case 192u:
					Form2.smethod_19((Control)(object)AdmitBtn, new Size(306, 50));
					num = ((int)num2 * -1475886948) ^ -1479776514;
					continue;
				case 191u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)Panel1), (Control)(object)GroupBox3);
					num = (int)(num2 * 955229218) ^ -1012327325;
					continue;
				case 190u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox3), (Control)(object)StaffPanel2);
					num = ((int)num2 * -2094801768) ^ -1509555311;
					continue;
				case 189u:
					Form2.smethod_20((Control)(object)AvailabilityBtn, 4);
					Form2.smethod_32((ButtonBase)(object)AvailabilityBtn, "Availability");
					num = (int)(num2 * 152675811) ^ -1853637952;
					continue;
				case 188u:
					Form2.smethod_19((Control)(object)StaffPanel1, new Size(44, 50));
					num = ((int)num2 * -2135606586) ^ 0x35F2802B;
					continue;
				case 187u:
					Form2.smethod_15((Control)(object)GroupBox2, Form2.smethod_14("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -280557125) ^ -1559109869;
					continue;
				case 186u:
					Form2.smethod_19((Control)(object)StaffPanel2, new Size(44, 50));
					Form2.smethod_20((Control)(object)StaffPanel2, 6);
					num = (int)((num2 * 1567682875) ^ 0x1421AE7A);
					continue;
				case 185u:
					Form2.smethod_19((Control)(object)RegisterRecieverBtn, new Size(311, 50));
					num = (int)(num2 * 1810381842) ^ -448226545;
					continue;
				case 184u:
					Form2.smethod_20((Control)(object)CheckUpBtn, 2);
					Form2.smethod_32((ButtonBase)(object)CheckUpBtn, "Check-Up");
					Form2.smethod_33((ButtonBase)(object)CheckUpBtn, bool_0: true);
					num = (int)(num2 * 1683170184) ^ -1537405019;
					continue;
				case 183u:
					GroupBox2 = Form2.smethod_6();
					num = (int)((num2 * 419906490) ^ 0x6037280F);
					continue;
				case 182u:
					RegisterDonorBtn = Form2.smethod_7();
					num = (int)(num2 * 1554610740) ^ -1219610821;
					continue;
				case 181u:
					num = ((int)num2 * -1235597383) ^ -1660716773;
					continue;
				case 180u:
					num = (int)(num2 * 1222047283) ^ -1293753228;
					continue;
				case 179u:
					num = ((int)num2 * -1059438766) ^ 0x665D4A03;
					continue;
				case 178u:
					num = ((int)num2 * -664440828) ^ -2023704070;
					continue;
				case 177u:
					num = (int)(num2 * 1696366582) ^ -254321279;
					continue;
				case 176u:
					num = ((int)num2 * -1484593523) ^ 0x2554434F;
					continue;
				case 175u:
					Form2.smethod_19((Control)(object)EditProfileBtn, new Size(311, 50));
					num = ((int)num2 * -1823449637) ^ -1885597380;
					continue;
				case 174u:
					Form2.smethod_15((Control)(object)LogoutBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 2023564324) ^ -282957685;
					continue;
				case 173u:
					Form2.smethod_23((ScrollableControl)(object)StaffPanel, bool_0: true);
					num = ((int)num2 * -561571421) ^ -1834652588;
					continue;
				case 172u:
					Form2.smethod_27(GroupBox3, "Staff");
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)AvailabilityBtn), 0);
					num = (int)(num2 * 1554978175) ^ -1453232390;
					continue;
				case 171u:
					Form2.smethod_26(GroupBox4, bool_0: false);
					num = ((int)num2 * -1570859829) ^ -473740697;
					continue;
				case 170u:
					CheckUpBtn = Form2.smethod_7();
					num = ((int)num2 * -1131194447) ^ 0x6300B5EC;
					continue;
				case 169u:
					Form2.smethod_46((Form)(object)this, "Form2");
					num = ((int)num2 * -1614345367) ^ -1168363248;
					continue;
				case 168u:
					Form2.smethod_18((Control)(object)EditProfileBtn, "EditProfileBtn");
					num = ((int)num2 * -1376492575) ^ -803142661;
					continue;
				case 167u:
					Form2.smethod_41((Form)(object)this, Color.MidnightBlue);
					num = (int)(num2 * 1293959444) ^ -648421367;
					continue;
				case 166u:
					Label1 = Form2.smethod_4();
					StaffPanel = Form2.smethod_5();
					num = ((int)num2 * -307623971) ^ -406079964;
					continue;
				case 164u:
					num = ((int)num2 * -1917378635) ^ 0x79DE3DBE;
					continue;
				case 163u:
					num = ((int)num2 * -1557764228) ^ 0x37209917;
					continue;
				case 162u:
					Form2.smethod_31((Control)(object)BloodAvailabilityBtn, new Padding(0));
					Form2.smethod_18((Control)(object)BloodAvailabilityBtn, "BloodAvailabilityBtn");
					Form2.smethod_19((Control)(object)BloodAvailabilityBtn, new Size(311, 50));
					Form2.smethod_20((Control)(object)BloodAvailabilityBtn, 7);
					num = (int)(num2 * 1028232130) ^ -1940165887;
					continue;
				case 161u:
					Form2.smethod_20((Control)(object)EditProfileBtn, 5);
					Form2.smethod_32((ButtonBase)(object)EditProfileBtn, "Edit Profile");
					num = ((int)num2 * -584006147) ^ -1724659955;
					continue;
				case 160u:
					Form2.smethod_17((Control)(object)BloodBankPanel1, new Point(0, 38));
					num = ((int)num2 * -823709321) ^ -257044207;
					continue;
				case 159u:
					Form2.smethod_30((ButtonBase)(object)RegisterRecieverBtn, (FlatStyle)0);
					num = (int)((num2 * 1385278171) ^ 0x5754024F);
					continue;
				case 158u:
					Form2.smethod_18((Control)(object)PatientPanel1, "PatientPanel1");
					num = ((int)num2 * -1967825106) ^ -505818405;
					continue;
				case 157u:
					num = (int)((num2 * 1009248445) ^ 0xAB37385);
					continue;
				case 156u:
					Form2.smethod_19((Control)(object)Label1, new Size(845, 69));
					num = (int)((num2 * 1840402439) ^ 0x141A0B0D);
					continue;
				case 155u:
					num = (int)(num2 * 170808102) ^ -1648913916;
					continue;
				case 154u:
					num = (int)((num2 * 422442457) ^ 0x4F8FE52E);
					continue;
				case 153u:
					num = ((int)num2 * -988097957) ^ 0x47BA6AEC;
					continue;
				case 152u:
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)LogoutBtn), 0);
					num = ((int)num2 * -226463223) ^ -1901232393;
					continue;
				case 151u:
					Form2.smethod_33((ButtonBase)(object)RegisterDonorBtn, bool_0: true);
					num = ((int)num2 * -792204999) ^ -1518705326;
					continue;
				case 150u:
					Form2.smethod_25(Form2.smethod_43((Control)(object)this), (Control)(object)PictureBox1);
					num = ((int)num2 * -829872066) ^ -1518086520;
					continue;
				case 149u:
					num = (int)((num2 * 1968779021) ^ 0x39D03102);
					continue;
				case 148u:
					Form2.smethod_31((Control)(object)CheckUpBtn, new Padding(0));
					num = ((int)num2 * -87879153) ^ 0x20E694D1;
					continue;
				case 147u:
					num = (int)(num2 * 2060748908) ^ -1603106000;
					continue;
				case 146u:
					Form2.smethod_20((Control)(object)UpdateDetailsBtn, 4);
					num = (int)(num2 * 291778221) ^ -348024485;
					continue;
				case 145u:
					num = (int)(num2 * 1913776310) ^ -1276550527;
					continue;
				case 144u:
					Form2.smethod_17((Control)(object)PersonalInfoPanel1, new Point(0, 52));
					num = (int)((num2 * 1182902474) ^ 0x7EEE44E2);
					continue;
				case 143u:
					Form2.smethod_17((Control)(object)RegisterRecieverBtn, new Point(20, 88));
					num = ((int)num2 * -758156015) ^ 0x67AAF2DF;
					continue;
				case 142u:
					num = ((int)num2 * -972171722) ^ -810514767;
					continue;
				case 141u:
					num = (int)(num2 * 233894839) ^ -1673540079;
					continue;
				case 140u:
					BloodBankPanel1 = Form2.smethod_5();
					num = ((int)num2 * -1785769371) ^ 0x712AC5DA;
					continue;
				case 139u:
					Form2.smethod_25(Form2.smethod_43((Control)(object)this), (Control)(object)StaffPanel);
					Form2.smethod_25(Form2.smethod_43((Control)(object)this), (Control)(object)Label1);
					num = (int)(num2 * 1964176206) ^ -836585996;
					continue;
				case 138u:
					num = (int)(num2 * 40361577) ^ -1402086303;
					continue;
				case 137u:
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)UpdateDetailsBtn), 0);
					num = ((int)num2 * -1306401569) ^ 0x351FC8A8;
					continue;
				case 136u:
					Form2.smethod_17((Control)(object)RegistrationBtn, new Point(25, 43));
					num = ((int)num2 * -218359177) ^ -1644100823;
					continue;
				case 135u:
					Form2.smethod_17((Control)(object)BloodAvailabilityBtn, new Point(20, 138));
					num = (int)(num2 * 586427540) ^ -1045979279;
					continue;
				case 134u:
					Form2.smethod_17((Control)(object)PictureBox1, new Point(307, 12));
					num = (int)(num2 * 1435152658) ^ -1690727324;
					continue;
				case 133u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox4), (Control)(object)RegisterDonorBtn);
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox4), (Control)(object)BloodBankPanel2);
					num = ((int)num2 * -188844041) ^ 0x5EE3D0BE;
					continue;
				case 132u:
					Form2.smethod_17((Control)(object)GroupBox3, new Point(13, 311));
					num = (int)(num2 * 202375116) ^ -1851410357;
					continue;
				case 131u:
					num = (int)((num2 * 2082147262) ^ 0x2DD58CCB);
					continue;
				case 130u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox2), (Control)(object)RegistrationBtn);
					num = ((int)num2 * -640123605) ^ 0x78F63523;
					continue;
				case 129u:
					Form2.smethod_27(GroupBox4, "Blood Bank");
					num = ((int)num2 * -1408350573) ^ 0x6C765DC;
					continue;
				case 128u:
					Form2.smethod_18((Control)(object)Panel1, "Panel1");
					num = ((int)num2 * -311482265) ^ 0x5D2A37FC;
					continue;
				case 127u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)((num2 * 146081570) ^ 0x50BC015C);
					continue;
				case 126u:
					num = (int)(num2 * 1327755188) ^ -745201690;
					continue;
				case 125u:
					Form2.smethod_31((Control)(object)AvailabilityBtn, new Padding(0));
					num = ((int)num2 * -1618876479) ^ -565197770;
					continue;
				case 124u:
					num = (int)(num2 * 2060318928) ^ -282523295;
					continue;
				case 123u:
					Form2.smethod_13((Control)(object)Label1, Color.Transparent);
					Form2.smethod_15((Control)(object)Label1, Form2.smethod_14("Microsoft Sans Serif", 36f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 720710304) ^ 0x36350289);
					continue;
				case 122u:
					Form2.smethod_15((Control)(object)EditProfileBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 942357597) ^ -1968213922;
					continue;
				case 121u:
					Form2.smethod_15((Control)(object)RegistrationBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 572708370) ^ -374138285;
					continue;
				case 120u:
					Form2.smethod_20((Control)(object)GroupBox2, 9);
					num = (int)((num2 * 34923472) ^ 0x1D0DFB1D);
					continue;
				case 119u:
					Form2.smethod_17((Control)(object)GroupBox4, new Point(13, 440));
					num = (int)((num2 * 827111825) ^ 0x2CBE2EE5);
					continue;
				case 118u:
					Form2.smethod_20((Control)(object)BloodBankPanel1, 14);
					num = (int)(num2 * 1484250607) ^ -1432091365;
					continue;
				case 117u:
					Form2.smethod_32((ButtonBase)(object)BloodAvailabilityBtn, "Blood Availability");
					num = ((int)num2 * -2011152137) ^ 0x2CA96D96;
					continue;
				case 116u:
					num = ((int)num2 * -1549123054) ^ 0x48BEA02D;
					continue;
				case 115u:
					num = ((int)num2 * -1509614539) ^ 0x6200B6A7;
					continue;
				case 114u:
					Form2.smethod_18((Control)(object)UpdateDetailsBtn, "UpdateDetailsBtn");
					num = ((int)num2 * -36188429) ^ -1083100840;
					continue;
				case 113u:
					Form2.smethod_13((Control)(object)StaffPanel, Color.White);
					num = ((int)num2 * -1023585567) ^ 0x6D076CF9;
					continue;
				case 112u:
					Form2.smethod_18((Control)(object)PersonalInfoPanel2, "PersonalInfoPanel2");
					num = ((int)num2 * -748718016) ^ -1226652119;
					continue;
				case 111u:
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)RegisterDonorBtn), 0);
					num = (int)((num2 * 995766359) ^ 0x13D07AB1);
					continue;
				case 110u:
					num = ((int)num2 * -819829812) ^ 0x226B0DF6;
					continue;
				case 109u:
					Form2.smethod_17((Control)(object)GroupBox2, new Point(13, 9));
					num = (int)((num2 * 988668636) ^ 0xA264139);
					continue;
				case 108u:
					Form2.smethod_51((Control)(object)this);
					num = (int)((num2 * 1499988883) ^ 0x3522B485);
					continue;
				case 107u:
					num = (int)((num2 * 1778953472) ^ 0x17410DAC);
					continue;
				case 106u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox4), (Control)(object)BloodBankPanel1);
					num = ((int)num2 * -436236238) ^ 0x71E03F53;
					continue;
				case 105u:
					Form2.smethod_30((ButtonBase)(object)LogoutBtn, (FlatStyle)0);
					num = (int)(num2 * 754318513) ^ -549677823;
					continue;
				case 104u:
					num = (int)(num2 * 485218988) ^ -1568856202;
					continue;
				case 102u:
					Form2.smethod_18((Control)(object)CheckUpBtn, "CheckUpBtn");
					num = ((int)num2 * -1152365168) ^ 0x1626E8CB;
					continue;
				case 101u:
					Form2.smethod_31((Control)(object)UpdateDetailsBtn, new Padding(0));
					num = ((int)num2 * -1574324758) ^ -391893145;
					continue;
				case 100u:
					Form2.smethod_19((Control)(object)GroupBox2, new Size(351, 267));
					num = (int)(num2 * 1100057780) ^ -683081066;
					continue;
				case 99u:
					Form2.smethod_32((ButtonBase)(object)LogoutBtn, "Logout");
					num = ((int)num2 * -1550779644) ^ -1345502606;
					continue;
				case 98u:
					num = (int)(num2 * 1831693752) ^ -844271957;
					continue;
				case 97u:
					Form2.smethod_17((Control)(object)LogoutBtn, new Point(20, 102));
					Form2.smethod_31((Control)(object)LogoutBtn, new Padding(0));
					num = ((int)num2 * -649130844) ^ 0x5C98A63F;
					continue;
				case 96u:
					Form2.smethod_15((Control)(object)RegisterRecieverBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1543637143) ^ -296201704;
					continue;
				case 95u:
					Form2.smethod_20((Control)(object)PersonalInfoPanel2, 16);
					num = (int)((num2 * 73542410) ^ 0x5515A82F);
					continue;
				case 94u:
					num = ((int)num2 * -86865086) ^ -283099500;
					continue;
				case 93u:
					num = (int)((num2 * 601212623) ^ 0xE3F399A);
					continue;
				case 92u:
					Form2.smethod_18((Control)(object)RegisterDonorBtn, "RegisterDonorBtn");
					num = ((int)num2 * -1000881586) ^ -730519231;
					continue;
				case 91u:
					num = (int)(num2 * 905746166) ^ -713045538;
					continue;
				case 90u:
					Form2.smethod_33((ButtonBase)(object)AdmitBtn, bool_0: true);
					num = (int)(num2 * 1924706369) ^ -1180778442;
					continue;
				case 89u:
					num = (int)(num2 * 1766744157) ^ -2055377165;
					continue;
				case 88u:
					num = ((int)num2 * -384403687) ^ 0xC5C7B35;
					continue;
				case 87u:
					Form2.smethod_17((Control)(object)StaffPanel2, new Point(307, 37));
					num = (int)(num2 * 1337034213) ^ -1586203915;
					continue;
				case 86u:
					num = (int)(num2 * 1113011764) ^ -1548433888;
					continue;
				case 85u:
					num = ((int)num2 * -1394097761) ^ 0x7CECBDB7;
					continue;
				case 84u:
					Form2.smethod_18((Control)(object)Label1, "Label1");
					num = ((int)num2 * -1414438083) ^ -1835129418;
					continue;
				case 83u:
					Form2.smethod_18((Control)(object)BloodBankPanel1, "BloodBankPanel1");
					num = ((int)num2 * -1260957755) ^ 0x1CB96A49;
					continue;
				case 82u:
					Form2.smethod_17((Control)(object)EditProfileBtn, new Point(20, 52));
					num = ((int)num2 * -1896316463) ^ 0x20C0F3F7;
					continue;
				case 81u:
					Form2.smethod_20((Control)(object)GroupBox3, 10);
					Form2.smethod_26(GroupBox3, bool_0: false);
					num = ((int)num2 * -78464254) ^ 0x225C519B;
					continue;
				case 80u:
					num = ((int)num2 * -634558323) ^ 0x6A2A092;
					continue;
				case 79u:
					num = (int)(num2 * 800188426) ^ -602622039;
					continue;
				case 78u:
					Form2.smethod_15((Control)(object)CheckUpBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1925005548) ^ 0x5836FFB3;
					continue;
				case 77u:
					Form2.smethod_19((Control)(object)PersonalInfoPanel1, new Size(44, 50));
					num = ((int)num2 * -1830212252) ^ 0x26A7B926;
					continue;
				case 76u:
					Form2.smethod_18((Control)(object)GroupBox4, "GroupBox4");
					num = ((int)num2 * -1397128580) ^ 0x2C4A17A6;
					continue;
				case 75u:
					Form2.smethod_18((Control)(object)PictureBox1, "PictureBox1");
					num = ((int)num2 * -1800314027) ^ 0x64EF81F5;
					continue;
				case 74u:
					Form2.smethod_20((Control)(object)RegistrationBtn, 1);
					Form2.smethod_32((ButtonBase)(object)RegistrationBtn, "Registration");
					Form2.smethod_33((ButtonBase)(object)RegistrationBtn, bool_0: false);
					num = ((int)num2 * -45883897) ^ 0x4E329ED4;
					continue;
				case 73u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox5), (Control)(object)EditProfileBtn);
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox5), (Control)(object)PersonalInfoPanel2);
					num = (int)(num2 * 1700685786) ^ -1830547261;
					continue;
				case 72u:
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)BloodAvailabilityBtn), 0);
					Form2.smethod_30((ButtonBase)(object)BloodAvailabilityBtn, (FlatStyle)0);
					num = ((int)num2 * -176551647) ^ -1817014290;
					continue;
				case 71u:
					Form2.smethod_15((Control)(object)GroupBox5, Form2.smethod_14("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Form2.smethod_17((Control)(object)GroupBox5, new Point(13, 647));
					num = (int)((num2 * 390662040) ^ 0x1B41763A);
					continue;
				case 70u:
					Form2.smethod_16((Control)(object)Label1, Color.White);
					num = (int)((num2 * 1923494639) ^ 0x209D779B);
					continue;
				case 69u:
					Form2.smethod_45((Form)(object)this, (SizeGripStyle)1);
					num = (int)(num2 * 1888413367) ^ -660343176;
					continue;
				case 68u:
					Form2.smethod_36(PictureBox1, (PictureBoxSizeMode)1);
					num = ((int)num2 * -1000217410) ^ -1058118425;
					continue;
				case 67u:
					Form2.smethod_15((Control)(object)GroupBox3, Form2.smethod_14("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1389377561) ^ 0x2A5AC3E4;
					continue;
				case 66u:
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					num = (int)((num2 * 357125243) ^ 0x157F7D19);
					continue;
				case 65u:
					Form2.smethod_9((Control)(object)GroupBox4);
					Form2.smethod_10((ISupportInitialize)PictureBox1);
					num = (int)(num2 * 1843230203) ^ -237982851;
					continue;
				case 64u:
					Form2.smethod_30((ButtonBase)(object)RegistrationBtn, (FlatStyle)0);
					num = (int)((num2 * 2083632166) ^ 0x44FC97D8);
					continue;
				case 63u:
					Form2.smethod_19((Control)(object)PictureBox1, new Size(106, 103));
					num = (int)((num2 * 427472177) ^ 0x3E9A08F3);
					continue;
				case 62u:
					num = (int)(num2 * 489751109) ^ -1531082952;
					continue;
				case 61u:
					num = ((int)num2 * -922692093) ^ 0xE8FD85F;
					continue;
				case 60u:
					num = (int)(num2 * 75873819) ^ -800204740;
					continue;
				case 59u:
					Form2.smethod_15((Control)(object)GroupBox4, Form2.smethod_14("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -340861460) ^ 0x3BC3E613;
					continue;
				case 58u:
					Form2.smethod_17((Control)(object)PatientPanel1, new Point(6, 43));
					num = (int)(num2 * 185358554) ^ -1455896934;
					continue;
				case 57u:
					Form2.smethod_17((Control)(object)Panel1, new Point(126, 141));
					num = (int)((num2 * 2112321294) ^ 0x56BBA3E3);
					continue;
				case 56u:
					BloodAvailabilityBtn = Form2.smethod_7();
					num = ((int)num2 * -1570492561) ^ 0xFF1E783;
					continue;
				case 55u:
					Form2.smethod_18((Control)(object)BloodBankPanel2, "BloodBankPanel2");
					Form2.smethod_19((Control)(object)BloodBankPanel2, new Size(44, 50));
					num = ((int)num2 * -2013610933) ^ 0x371885D1;
					continue;
				case 54u:
					num = ((int)num2 * -582075364) ^ 0x75346D79;
					continue;
				case 53u:
					num = ((int)num2 * -580748659) ^ -1898765562;
					continue;
				case 52u:
					Form2.smethod_20((Control)(object)RegisterRecieverBtn, 6);
					num = ((int)num2 * -506290945) ^ 0x2BBA18D4;
					continue;
				case 51u:
					num = ((int)num2 * -218785095) ^ 0x4E6EFFE6;
					continue;
				case 50u:
					num = (int)((num2 * 278348436) ^ 0x3BE4D73F);
					continue;
				case 49u:
					Form2.smethod_31((Control)(object)GroupBox4, new Padding(0));
					num = ((int)num2 * -657562868) ^ -2123593055;
					continue;
				case 48u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)GroupBox5), (Control)(object)PersonalInfoPanel1);
					num = ((int)num2 * -273177580) ^ -468961824;
					continue;
				case 47u:
					Form2.smethod_32((ButtonBase)(object)UpdateDetailsBtn, "Update Details");
					num = (int)((num2 * 1819745191) ^ 0xF7A1DA);
					continue;
				case 46u:
					Form2.smethod_33((ButtonBase)(object)RegisterRecieverBtn, bool_0: true);
					num = ((int)num2 * -1360855468) ^ 0x2ABB160D;
					continue;
				case 45u:
					num = (int)(num2 * 1898503417) ^ -1427615774;
					continue;
				case 44u:
					Form2.smethod_18((Control)(object)StaffPanel2, "StaffPanel2");
					num = ((int)num2 * -200959784) ^ 0x5F7117B;
					continue;
				case 43u:
					Form2.smethod_20((Control)(object)Panel1, 6);
					num = (int)((num2 * 155412504) ^ 0x72D6055B);
					continue;
				case 42u:
					Form2.smethod_30((ButtonBase)(object)CheckUpBtn, (FlatStyle)0);
					num = ((int)num2 * -104065892) ^ -657859024;
					continue;
				case 41u:
					num = ((int)num2 * -30821305) ^ -740639134;
					continue;
				case 40u:
					Form2.smethod_17((Control)(object)UpdateDetailsBtn, new Point(25, 196));
					num = (int)(num2 * 1648206894) ^ -516955132;
					continue;
				case 39u:
					num = ((int)num2 * -515923581) ^ -1503053015;
					continue;
				case 38u:
					Form2.smethod_32((ButtonBase)(object)RegisterRecieverBtn, "Register Reciever");
					num = ((int)num2 * -1844807273) ^ -1333194093;
					continue;
				case 37u:
					Form2.smethod_9((Control)(object)Panel1);
					num = ((int)num2 * -30931312) ^ 0x474E30A0;
					continue;
				case 36u:
					num = (int)((num2 * 1388423765) ^ 0x5D37360C);
					continue;
				case 35u:
					Form2.smethod_17((Control)(object)StaffPanel, new Point(716, 141));
					num = ((int)num2 * -844736182) ^ 0x45C49B48;
					continue;
				case 34u:
					Form2.smethod_17((Control)(object)CheckUpBtn, new Point(25, 96));
					num = ((int)num2 * -1253810464) ^ -1383983522;
					continue;
				case 33u:
					AdmitBtn = Form2.smethod_7();
					RegistrationBtn = Form2.smethod_7();
					num = (int)(num2 * 401729918) ^ -316876233;
					continue;
				case 32u:
					num = ((int)num2 * -1434046249) ^ -1026210577;
					continue;
				case 31u:
					EditProfileBtn = Form2.smethod_7();
					num = ((int)num2 * -1021272769) ^ -88336207;
					continue;
				case 30u:
					Form2.smethod_27(GroupBox5, "Personal Info");
					num = ((int)num2 * -1760449345) ^ -120249591;
					continue;
				case 29u:
					num = ((int)num2 * -231440982) ^ -809083126;
					continue;
				case 28u:
					num = (int)((num2 * 1564283649) ^ 0x4FFB739F);
					continue;
				case 27u:
					Form2.smethod_20((Control)(object)Label1, 2);
					Form2.smethod_21(Label1, "Golisano's Hospital Of Florida");
					Form2.smethod_22(Label1, (ContentAlignment)32);
					num = ((int)num2 * -1555677926) ^ -1218933344;
					continue;
				case 26u:
					Form2.smethod_30((ButtonBase)(object)AvailabilityBtn, (FlatStyle)0);
					num = (int)(num2 * 1226168095) ^ -1420376315;
					continue;
				case 25u:
					Form2.smethod_25(Form2.smethod_43((Control)(object)this), (Control)(object)Panel1);
					num = ((int)num2 * -62155047) ^ 0x75B8D069;
					continue;
				case 24u:
					GroupBox3 = Form2.smethod_6();
					AvailabilityBtn = Form2.smethod_7();
					num = (int)(num2 * 387470054) ^ -935192396;
					continue;
				case 23u:
					Form2.smethod_35(PictureBox1, (Image)(object)Resources.Hospital_blue_icon);
					num = ((int)num2 * -1213919057) ^ 0x32F2B534;
					continue;
				case 22u:
					num = ((int)num2 * -1271439293) ^ -381228321;
					continue;
				case 21u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)Panel1), (Control)(object)GroupBox5);
					num = ((int)num2 * -560523442) ^ 0x6C5B0820;
					continue;
				case 20u:
					Form2.smethod_26(GroupBox2, bool_0: false);
					num = ((int)num2 * -16861928) ^ 0x6094E96;
					continue;
				case 19u:
					Form2.smethod_20((Control)(object)StaffPanel1, 5);
					num = (int)((num2 * 1407862005) ^ 0x3893115);
					continue;
				case 18u:
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)EditProfileBtn), 0);
					num = (int)(num2 * 1224385174) ^ -702243007;
					continue;
				case 17u:
					Form2.smethod_19((Control)(object)CheckUpBtn, new Size(306, 50));
					num = ((int)num2 * -1505194064) ^ 0x360B5115;
					continue;
				case 16u:
					Form2.smethod_30((ButtonBase)(object)EditProfileBtn, (FlatStyle)0);
					num = (int)((num2 * 969284739) ^ 0x24DD564A);
					continue;
				case 15u:
					Form2.smethod_19((Control)(object)GroupBox4, new Size(351, 204));
					Form2.smethod_20((Control)(object)GroupBox4, 11);
					num = ((int)num2 * -2051193193) ^ -15893252;
					continue;
				case 14u:
					num = ((int)num2 * -1224961128) ^ -300148245;
					continue;
				case 13u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)Panel1), (Control)(object)GroupBox2);
					num = ((int)num2 * -1723285170) ^ 0x1743E4DA;
					continue;
				case 12u:
					Form2.smethod_32((ButtonBase)(object)RegisterDonorBtn, "Register Donor");
					num = ((int)num2 * -1927327950) ^ -257024258;
					continue;
				case 11u:
					Form2.smethod_20((Control)(object)PatientPanel2, 6);
					num = ((int)num2 * -477695148) ^ 0x4D21E17A;
					continue;
				case 10u:
					Form2.smethod_19((Control)(object)UpdateDetailsBtn, new Size(306, 50));
					num = ((int)num2 * -1855525430) ^ -1559975374;
					continue;
				case 9u:
					PictureBox1 = Form2.smethod_8();
					num = (int)(num2 * 1421674284) ^ -25289272;
					continue;
				case 8u:
					Form2.smethod_20((Control)(object)BloodBankPanel2, 15);
					Form2.smethod_13((Control)(object)BloodBankPanel1, Color.Transparent);
					num = ((int)num2 * -441777787) ^ 0x381C1553;
					continue;
				case 7u:
					Form2.smethod_18((Control)(object)StaffPanel, "StaffPanel");
					num = (int)(num2 * 1085770755) ^ -117003691;
					continue;
				case 6u:
					num = ((int)num2 * -647843867) ^ -1218760798;
					continue;
				case 5u:
					Form2.smethod_20((Control)(object)RegisterDonorBtn, 5);
					num = (int)(num2 * 1952110536) ^ -379796630;
					continue;
				case 4u:
					Form2.smethod_29(Form2.smethod_28((ButtonBase)(object)AdmitBtn), 0);
					Form2.smethod_30((ButtonBase)(object)AdmitBtn, (FlatStyle)0);
					Form2.smethod_15((Control)(object)AdmitBtn, Form2.smethod_14("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1599153881) ^ -1868785793;
					continue;
				case 3u:
					num = (int)(num2 * 1377694701) ^ -2011375976;
					continue;
				case 2u:
					Form2.smethod_17((Control)(object)Label1, new Point(428, 35));
					num = ((int)num2 * -1697492336) ^ 0x309297A2;
					continue;
				case 1u:
					Form2.smethod_48((Control)(object)GroupBox5, bool_0: false);
					num = (int)((num2 * 1909608073) ^ 0x6F0E1EF9);
					continue;
				case 0u:
					num = (int)(num2 * 616782167) ^ -916141885;
					continue;
				default:
					return;
				case 103u:
					break;
				case 165u:
					return;
				}
				break;
			}
		}
	}

	private void CheckUpBtn_Click(object sender, EventArgs e)
	{
		Form2.smethod_13((Control)(object)BloodBankPanel1, Color.Transparent);
		Form2.smethod_13((Control)(object)BloodBankPanel2, Color.Transparent);
		while (true)
		{
			int num = -1688973108;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9EE77397u) % 15u)
				{
				case 14u:
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					num = ((int)num2 * -1761665827) ^ 0x27497935;
					continue;
				case 13u:
					Form2.smethod_55((Control)(object)PatientPanel1, Form2.smethod_54((Control)(object)CheckUpBtn));
					num = (int)(num2 * 1869815338) ^ -919228918;
					continue;
				case 12u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					num = (int)((num2 * 1930803573) ^ 0x609E34B8);
					continue;
				case 11u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.Transparent);
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = ((int)num2 * -1726151954) ^ 0x79824E83;
					continue;
				case 10u:
					num = ((int)num2 * -151731746) ^ -1511349349;
					continue;
				case 9u:
					Form2.smethod_13((Control)(object)PatientPanel1, Color.DarkBlue);
					num = ((int)num2 * -863627352) ^ -1039488196;
					continue;
				case 8u:
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					num = ((int)num2 * -1744846106) ^ 0x5E1D32AA;
					continue;
				case 7u:
					num = ((int)num2 * -1130208921) ^ -1038016578;
					continue;
				case 5u:
					Form2.smethod_55((Control)(object)PatientPanel2, Form2.smethod_54((Control)(object)CheckUpBtn));
					num = (int)((num2 * 1627508593) ^ 0x6AEEF73B);
					continue;
				case 4u:
					num = ((int)num2 * -1316481058) ^ 0x1112ABB5;
					continue;
				case 3u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.DarkBlue);
					num = (int)(num2 * 337594619) ^ -1224706993;
					continue;
				case 2u:
					num = ((int)num2 * -1013193192) ^ 0x1E6C19D;
					continue;
				case 1u:
					num = (int)(num2 * 803353379) ^ -39931655;
					continue;
				case 6u:
					break;
				default:
					Form2.smethod_25(Form2.smethod_24((Control)(object)StaffPanel), (Control)(object)new CheckUp());
					return;
				}
				break;
			}
		}
	}

	private void RegistrationBtn_Click(object sender, EventArgs e)
	{
		Form2.smethod_13((Control)(object)BloodBankPanel1, Color.Transparent);
		Form2.smethod_13((Control)(object)BloodBankPanel2, Color.Transparent);
		while (true)
		{
			int num = 50817183;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x72A9C58u) % 13u)
				{
				case 12u:
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					num = (int)((num2 * 1570415384) ^ 0x2C018DB5);
					continue;
				case 11u:
					num = ((int)num2 * -1324069480) ^ 0x5B3D70E;
					continue;
				case 9u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)(num2 * 1697234946) ^ -146210002;
					continue;
				case 8u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					num = (int)((num2 * 1029960327) ^ 0x2D70C44A);
					continue;
				case 7u:
					Form2.smethod_55((Control)(object)PatientPanel2, Form2.smethod_54((Control)(object)RegistrationBtn));
					Form2.smethod_13((Control)(object)PatientPanel1, Color.DarkBlue);
					num = (int)((num2 * 825847778) ^ 0x44745E3C);
					continue;
				case 6u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = (int)(num2 * 515500015) ^ -1282186089;
					continue;
				case 5u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.DarkBlue);
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					Form2.smethod_25(Form2.smethod_24((Control)(object)StaffPanel), (Control)(object)new Registration());
					num = (int)(num2 * 1817065487) ^ -1225946978;
					continue;
				case 4u:
					num = (int)(num2 * 976087785) ^ -1293095190;
					continue;
				case 3u:
					num = ((int)num2 * -689623063) ^ 0x50833817;
					continue;
				case 2u:
					Form2.smethod_55((Control)(object)PatientPanel1, Form2.smethod_54((Control)(object)RegistrationBtn));
					num = ((int)num2 * -997676068) ^ -1649496863;
					continue;
				case 0u:
					num = ((int)num2 * -1547521740) ^ -871491471;
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
			int num = -275085774;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xADB5061Bu) % 15u)
				{
				case 14u:
					num = (int)(num2 * 669261618) ^ -1430758094;
					continue;
				case 13u:
					num = ((int)num2 * -1403624085) ^ -764801968;
					continue;
				case 12u:
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.Transparent);
					num = ((int)num2 * -1792683251) ^ 0x343DF2E3;
					continue;
				case 11u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.DarkBlue);
					num = ((int)num2 * -881449319) ^ -150971287;
					continue;
				case 10u:
					num = ((int)num2 * -1615490048) ^ -659682278;
					continue;
				case 9u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = (int)(num2 * 1653932774) ^ -1761799821;
					continue;
				case 7u:
					Form2.smethod_55((Control)(object)PatientPanel1, Form2.smethod_54((Control)(object)AdmitBtn));
					Form2.smethod_55((Control)(object)PatientPanel2, Form2.smethod_54((Control)(object)AdmitBtn));
					Form2.smethod_13((Control)(object)PatientPanel1, Color.DarkBlue);
					num = (int)(num2 * 1986583854) ^ -698412839;
					continue;
				case 6u:
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					num = ((int)num2 * -2038797076) ^ -118336438;
					continue;
				case 5u:
					num = ((int)num2 * -1546864289) ^ -1382715436;
					continue;
				case 4u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)(num2 * 1964086814) ^ -1941398769;
					continue;
				case 3u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					num = ((int)num2 * -1968799178) ^ 0x88BAB59;
					continue;
				case 1u:
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					Form2.smethod_25(Form2.smethod_24((Control)(object)StaffPanel), (Control)(object)new Admit());
					num = ((int)num2 * -2014699332) ^ 0x18F92389;
					continue;
				case 0u:
					num = ((int)num2 * -1200973158) ^ -50735714;
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

	private void UpdateDetailsBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1249540228;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1C2ABF90u) % 19u)
				{
				case 18u:
					num = ((int)num2 * -675378792) ^ -370580022;
					continue;
				case 17u:
					num = (int)(num2 * 1672771092) ^ -1001854728;
					continue;
				case 16u:
					Form2.smethod_55((Control)(object)PatientPanel1, Form2.smethod_54((Control)(object)UpdateDetailsBtn));
					num = (int)(num2 * 175210352) ^ -1212882966;
					continue;
				case 15u:
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					num = (int)((num2 * 553079413) ^ 0x4BBAA916);
					continue;
				case 14u:
					Form2.smethod_55((Control)(object)PatientPanel2, Form2.smethod_54((Control)(object)UpdateDetailsBtn));
					Form2.smethod_13((Control)(object)PatientPanel1, Color.DarkBlue);
					num = ((int)num2 * -2053049394) ^ -933731338;
					continue;
				case 13u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					num = ((int)num2 * -2094408168) ^ 0x4C346412;
					continue;
				case 11u:
					num = ((int)num2 * -440145773) ^ 0x4A66D3AC;
					continue;
				case 10u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)(num2 * 525216035) ^ -1142758828;
					continue;
				case 9u:
					num = (int)((num2 * 76697237) ^ 0x72712122);
					continue;
				case 8u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.DarkBlue);
					num = (int)(num2 * 855890556) ^ -1617686166;
					continue;
				case 7u:
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.Transparent);
					num = ((int)num2 * -965519175) ^ -1720312498;
					continue;
				case 6u:
					num = ((int)num2 * -1187070209) ^ -77660175;
					continue;
				case 4u:
					num = (int)(num2 * 1428447174) ^ -1490929270;
					continue;
				case 3u:
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					num = (int)((num2 * 2030385746) ^ 0x4366731D);
					continue;
				case 2u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = (int)((num2 * 1921115999) ^ 0x19DB0006);
					continue;
				case 1u:
					Form2.smethod_13((Control)(object)BloodBankPanel1, Color.Transparent);
					num = ((int)num2 * -945385101) ^ 0x19F3390C;
					continue;
				case 0u:
					num = (int)(num2 * 231460191) ^ -1766400415;
					continue;
				case 12u:
					break;
				default:
					Form2.smethod_25(Form2.smethod_24((Control)(object)StaffPanel), (Control)(object)new UpdateDetails());
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
			int num = -1468649830;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBB84EF4Bu) % 20u)
				{
				case 19u:
					num = (int)((num2 * 249713603) ^ 0x520B9FE1);
					continue;
				case 18u:
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					num = (int)((num2 * 1468239249) ^ 0xA2CF879);
					continue;
				case 17u:
					num = (int)(num2 * 1501793646) ^ -1350450474;
					continue;
				case 16u:
					num = ((int)num2 * -1614558342) ^ -1055589996;
					continue;
				case 15u:
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					num = ((int)num2 * -1871279670) ^ 0x3F2E6EC4;
					continue;
				case 14u:
					Form2.smethod_55((Control)(object)BloodBankPanel2, Form2.smethod_54((Control)(object)RegisterRecieverBtn));
					num = (int)((num2 * 1973059447) ^ 0x5E4DD92F);
					continue;
				case 13u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.Transparent);
					num = (int)(num2 * 1977001101) ^ -2030019181;
					continue;
				case 12u:
					num = ((int)num2 * -1460581774) ^ -236776807;
					continue;
				case 11u:
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.DarkBlue);
					num = ((int)num2 * -303527031) ^ 0x459821DC;
					continue;
				case 10u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					num = ((int)num2 * -840773342) ^ -732980952;
					continue;
				case 9u:
					num = (int)(num2 * 849960813) ^ -347542736;
					continue;
				case 8u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)StaffPanel), (Control)(object)new RegisterReciever());
					num = ((int)num2 * -1172550202) ^ 0x57BB898A;
					continue;
				case 7u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = ((int)num2 * -2129764112) ^ -1900898868;
					continue;
				case 4u:
					num = ((int)num2 * -1319330023) ^ 0x40444E29;
					continue;
				case 3u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = ((int)num2 * -2008079257) ^ 0x1C2E8BF6;
					continue;
				case 2u:
					Form2.smethod_13((Control)(object)BloodBankPanel1, Color.DarkBlue);
					num = (int)(num2 * 1940595272) ^ -902130817;
					continue;
				case 1u:
					num = (int)(num2 * 324420617) ^ -980673652;
					continue;
				case 0u:
					Form2.smethod_55((Control)(object)BloodBankPanel1, Form2.smethod_54((Control)(object)RegisterRecieverBtn));
					num = ((int)num2 * -1719104253) ^ -144402261;
					continue;
				default:
					return;
				case 5u:
					break;
				case 6u:
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
			int num = 5858564;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x543D514Eu) % 18u)
				{
				case 16u:
					Form2.smethod_13((Control)(object)BloodBankPanel1, Color.Transparent);
					num = (int)(num2 * 513394882) ^ -2095792573;
					continue;
				case 15u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)(num2 * 1026754806) ^ -231639183;
					continue;
				case 14u:
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					num = ((int)num2 * -109499863) ^ 0x7716A65D;
					continue;
				case 13u:
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.Transparent);
					num = (int)((num2 * 2009563486) ^ 0x787C2078);
					continue;
				case 12u:
					num = (int)(num2 * 951583466) ^ -1515841752;
					continue;
				case 11u:
					num = (int)(num2 * 1386913521) ^ -1407820880;
					continue;
				case 9u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.Transparent);
					num = (int)((num2 * 1279067420) ^ 0x7E7F7A50);
					continue;
				case 8u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.DarkBlue);
					num = ((int)num2 * -711321907) ^ 0x53E8E6AA;
					continue;
				case 7u:
					num = ((int)num2 * -612523635) ^ 0x513212BF;
					continue;
				case 6u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = (int)(num2 * 555298247) ^ -1329789809;
					continue;
				case 5u:
					num = (int)((num2 * 1434907398) ^ 0x9545678);
					continue;
				case 4u:
					Form2.smethod_13((Control)(object)PatientPanel1, Color.Transparent);
					num = ((int)num2 * -1124218035) ^ -1630260835;
					continue;
				case 3u:
					num = ((int)num2 * -127554318) ^ 0x6AD2869B;
					continue;
				case 2u:
					num = (int)((num2 * 470166608) ^ 0x1E47E3AB);
					continue;
				case 1u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)StaffPanel), (Control)(object)new Availability());
					num = (int)(num2 * 763039078) ^ -604293190;
					continue;
				case 0u:
					Form2.smethod_13((Control)(object)StaffPanel2, Color.DarkBlue);
					num = (int)(num2 * 1507682806) ^ -908370322;
					continue;
				default:
					return;
				case 17u:
					break;
				case 10u:
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
			int num = -964301832;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x93C43F50u) % 15u)
				{
				case 13u:
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					num = ((int)num2 * -509126794) ^ -1620075356;
					continue;
				case 12u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)StaffPanel), (Control)(object)new RegisterDonor());
					num = (int)((num2 * 329750283) ^ 0x78F982E3);
					continue;
				case 11u:
					num = (int)((num2 * 1421352845) ^ 0x7D952782);
					continue;
				case 10u:
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.DarkBlue);
					num = ((int)num2 * -1569796534) ^ -654082916;
					continue;
				case 9u:
					num = ((int)num2 * -2017624644) ^ 0x77FDEA27;
					continue;
				case 8u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)(num2 * 655330551) ^ -119882226;
					continue;
				case 7u:
					Form2.smethod_13((Control)(object)BloodBankPanel1, Color.DarkBlue);
					num = (int)(num2 * 1478277788) ^ -1988387034;
					continue;
				case 6u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = ((int)num2 * -465048174) ^ -1274921820;
					continue;
				case 5u:
					num = (int)(num2 * 1808056086) ^ -429180311;
					continue;
				case 4u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.Transparent);
					num = ((int)num2 * -1880813260) ^ -1760446432;
					continue;
				case 2u:
					num = (int)((num2 * 1684877380) ^ 0x119B442);
					continue;
				case 1u:
					Form2.smethod_55((Control)(object)BloodBankPanel1, Form2.smethod_54((Control)(object)RegisterDonorBtn));
					Form2.smethod_55((Control)(object)BloodBankPanel2, Form2.smethod_54((Control)(object)RegisterDonorBtn));
					num = ((int)num2 * -2062018229) ^ 0x1D38B548;
					continue;
				case 0u:
					num = ((int)num2 * -2087576351) ^ -584686083;
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

	private void BloodAvailabilityBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -675876855;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBCC8BB03u) % 18u)
				{
				case 17u:
					num = (int)((num2 * 885174049) ^ 0x5825E6AF);
					continue;
				case 16u:
					num = (int)((num2 * 1450260347) ^ 0x688C93A4);
					continue;
				case 14u:
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					num = (int)((num2 * 305002144) ^ 0x2E44ED81);
					continue;
				case 13u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.Transparent);
					num = ((int)num2 * -409384147) ^ -221647012;
					continue;
				case 12u:
					Form2.smethod_13((Control)(object)PatientPanel1, Color.Transparent);
					num = (int)(num2 * 171065145) ^ -1762047298;
					continue;
				case 11u:
					num = ((int)num2 * -398723026) ^ -478975046;
					continue;
				case 10u:
					Form2.smethod_13((Control)(object)BloodBankPanel1, Color.DarkBlue);
					num = ((int)num2 * -1869201537) ^ -853964160;
					continue;
				case 9u:
					Form2.smethod_55((Control)(object)BloodBankPanel1, Form2.smethod_54((Control)(object)BloodAvailabilityBtn));
					Form2.smethod_55((Control)(object)BloodBankPanel2, Form2.smethod_54((Control)(object)BloodAvailabilityBtn));
					num = (int)(num2 * 698041761) ^ -1207219362;
					continue;
				case 8u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = ((int)num2 * -818915471) ^ -1971440364;
					continue;
				case 6u:
					num = ((int)num2 * -713250974) ^ 0x1E95FEEF;
					continue;
				case 5u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)(num2 * 182172107) ^ -1794205180;
					continue;
				case 4u:
					num = (int)((num2 * 1410312380) ^ 0x3B29EBF8);
					continue;
				case 3u:
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.DarkBlue);
					num = (int)(num2 * 1625870198) ^ -465036967;
					continue;
				case 2u:
					num = ((int)num2 * -1110679071) ^ -1895354079;
					continue;
				case 1u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)StaffPanel), (Control)(object)new BloodAvailability());
					num = ((int)num2 * -228614438) ^ -226262889;
					continue;
				case 0u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					num = (int)(num2 * 346789568) ^ -641690992;
					continue;
				default:
					return;
				case 7u:
					break;
				case 15u:
					return;
				}
				break;
			}
		}
	}

	private void EditProfileBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 695586565;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x53999938u) % 14u)
				{
				case 13u:
					Form2.smethod_55((Control)(object)PersonalInfoPanel1, Form2.smethod_54((Control)(object)EditProfileBtn));
					Form2.smethod_55((Control)(object)PersonalInfoPanel2, Form2.smethod_54((Control)(object)EditProfileBtn));
					num = (int)(num2 * 1101045437) ^ -1800398776;
					continue;
				case 11u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.DarkBlue);
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.DarkBlue);
					num = (int)((num2 * 1600307697) ^ 0x79FAC916);
					continue;
				case 9u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					num = (int)((num2 * 1927419189) ^ 0x5EC5FDD);
					continue;
				case 8u:
					num = (int)((num2 * 1262747861) ^ 0x58B72B5);
					continue;
				case 7u:
					Form2.smethod_25(Form2.smethod_24((Control)(object)StaffPanel), (Control)(object)new EditProfile());
					num = ((int)num2 * -46618853) ^ -1375586643;
					continue;
				case 6u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.Transparent);
					num = ((int)num2 * -199721879) ^ 0x27958350;
					continue;
				case 5u:
					Form2.smethod_13((Control)(object)PatientPanel1, Color.Transparent);
					num = (int)((num2 * 1540299645) ^ 0x192CC337);
					continue;
				case 4u:
					num = ((int)num2 * -1365001601) ^ -1013124326;
					continue;
				case 3u:
					num = (int)(num2 * 446792166) ^ -131293698;
					continue;
				case 2u:
					Form2.smethod_13((Control)(object)BloodBankPanel1, Color.Transparent);
					num = (int)(num2 * 179861529) ^ -843604763;
					continue;
				case 1u:
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.Transparent);
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					num = (int)((num2 * 1908868682) ^ 0x63E7EC53);
					continue;
				case 0u:
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					num = (int)(num2 * 1902581096) ^ -95264207;
					continue;
				default:
					return;
				case 10u:
					break;
				case 12u:
					return;
				}
				break;
			}
		}
	}

	private void LogoutBtn_Click(object sender, EventArgs e)
	{
		Form2.smethod_13((Control)(object)PatientPanel1, Color.Transparent);
		while (true)
		{
			int num = -2111062523;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCFE0C31Au) % 18u)
				{
				case 17u:
					num = (int)((num2 * 571315134) ^ 0x840612A);
					continue;
				case 16u:
					num = (int)(num2 * 1963660991) ^ -1803628932;
					continue;
				case 15u:
					Form2.smethod_57((Form)(object)this);
					Form2.smethod_58((Control)(object)MyProject.Forms.Form1);
					num = (int)((num2 * 1959609896) ^ 0xF1902D3);
					continue;
				case 14u:
					Form2.smethod_13((Control)(object)StaffPanel2, Color.Transparent);
					num = ((int)num2 * -519564008) ^ 0x5D05A1F7;
					continue;
				case 13u:
					Form2.smethod_13((Control)(object)PatientPanel2, Color.Transparent);
					Form2.smethod_13((Control)(object)BloodBankPanel1, Color.Transparent);
					num = (int)(num2 * 243179207) ^ -2010862818;
					continue;
				case 11u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel1, Color.DarkBlue);
					num = (int)((num2 * 1358346526) ^ 0x2FE1C8AD);
					continue;
				case 10u:
					MyProject.Forms.Form1.username = "";
					num = ((int)num2 * -1839075680) ^ -1837152542;
					continue;
				case 8u:
					Form2.smethod_56(Form2.smethod_24((Control)(object)StaffPanel));
					num = (int)((num2 * 511085940) ^ 0x30F87C61);
					continue;
				case 7u:
					Form2.smethod_13((Control)(object)PersonalInfoPanel2, Color.DarkBlue);
					num = (int)((num2 * 987052030) ^ 0x483985F0);
					continue;
				case 6u:
					Form2.smethod_55((Control)(object)PersonalInfoPanel1, Form2.smethod_54((Control)(object)LogoutBtn));
					num = (int)((num2 * 1073220532) ^ 0x15242594);
					continue;
				case 5u:
					Form2.smethod_13((Control)(object)BloodBankPanel2, Color.Transparent);
					num = (int)((num2 * 51178659) ^ 0x7F9960BD);
					continue;
				case 4u:
					MyProject.Forms.Form1.login_type = "";
					num = ((int)num2 * -2104740561) ^ -1668997477;
					continue;
				case 3u:
					num = ((int)num2 * -890035380) ^ -163476239;
					continue;
				case 2u:
					num = (int)((num2 * 1075373655) ^ 0x29D3B8C0);
					continue;
				case 1u:
					Form2.smethod_13((Control)(object)StaffPanel1, Color.Transparent);
					num = (int)(num2 * 2129386231) ^ -1793400007;
					continue;
				case 0u:
					Form2.smethod_55((Control)(object)PersonalInfoPanel2, Form2.smethod_54((Control)(object)LogoutBtn));
					num = (int)(num2 * 2062808728) ^ -1389250575;
					continue;
				default:
					return;
				case 12u:
					break;
				case 9u:
					return;
				}
				break;
			}
		}
	}

	private void Form2_FormClosed(object sender, FormClosedEventArgs e)
	{
		while (true)
		{
			int num = -684300669;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF04533B3u) % 3u)
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
				MyProject.Forms.Form1.username = "";
				MyProject.Forms.Form1.login_type = "";
				Form2.smethod_58((Control)(object)MyProject.Forms.Form1);
				num = (int)(num2 * 943217896) ^ -1942753926;
			}
		}
	}

	private void Form2_Shown(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1528184572;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF41882C1u) % 4u)
				{
				case 1u:
					Form2.smethod_59((Control)(object)this);
					num = (int)(num2 * 1638839473) ^ -1010366480;
					continue;
				case 0u:
					num = ((int)num2 * -1448148262) ^ -1439601541;
					continue;
				default:
					return;
				case 3u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 968202060;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x79E02821u) % 4u)
				{
				case 3u:
					Form2.smethod_61((Form)(object)this, (AutoSizeMode)0);
					num = (int)((num2 * 1886761767) ^ 0x40BA6E50);
					continue;
				case 1u:
					Form2.smethod_60((Form)(object)this, bool_0: true);
					num = (int)((num2 * 262093641) ^ 0x2A39C2C3);
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
