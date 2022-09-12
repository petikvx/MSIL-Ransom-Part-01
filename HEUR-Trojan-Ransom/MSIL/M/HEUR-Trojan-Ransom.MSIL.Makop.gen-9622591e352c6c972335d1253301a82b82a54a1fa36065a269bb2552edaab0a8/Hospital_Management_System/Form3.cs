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
public class Form3 : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("AdminPanel")]
	internal virtual Panel AdminPanel
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
				int num = -482548496;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDE49F2BBu) % 8u)
					{
					case 7u:
						_LogoutBtn = value;
						logoutBtn = _LogoutBtn;
						num = -492922678;
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (logoutBtn == null)
						{
							num5 = 1049533266;
							num6 = 1049533266;
						}
						else
						{
							num5 = 1557605048;
							num6 = 1557605048;
						}
						num = num5 ^ (int)(num2 * 528756877);
						continue;
					}
					case 5u:
						Form3.smethod_51((Control)(object)logoutBtn, eventHandler_);
						num = ((int)num2 * -990072221) ^ -2083133605;
						continue;
					case 3u:
						logoutBtn = _LogoutBtn;
						num = (int)((num2 * 1628939515) ^ 0x5480CBDC);
						continue;
					case 2u:
						Form3.smethod_52((Control)(object)logoutBtn, eventHandler_);
						num = (int)(num2 * 1915543049) ^ -46324695;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (logoutBtn != null)
						{
							num3 = -538269599;
							num4 = -538269599;
						}
						else
						{
							num3 = -635632157;
							num4 = -635632157;
						}
						num = num3 ^ (int)(num2 * 127658360);
						continue;
					}
					default:
						return;
					case 4u:
						break;
					case 0u:
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
				int num = 1598256063;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4A276273u) % 8u)
					{
					case 7u:
						editProfileBtn = _EditProfileBtn;
						num = (int)((num2 * 1932554264) ^ 0x7CF9DADE);
						continue;
					case 6u:
						Form3.smethod_51((Control)(object)editProfileBtn, eventHandler_);
						num = (int)((num2 * 863222233) ^ 0x5F8784CD);
						continue;
					case 5u:
					{
						int num5;
						int num6;
						if (editProfileBtn == null)
						{
							num5 = 1859052216;
							num6 = 1859052216;
						}
						else
						{
							num5 = 689885147;
							num6 = 689885147;
						}
						num = num5 ^ ((int)num2 * -404711723);
						continue;
					}
					case 4u:
					{
						editProfileBtn = _EditProfileBtn;
						int num3;
						int num4;
						if (editProfileBtn != null)
						{
							num3 = 409422321;
							num4 = 409422321;
						}
						else
						{
							num3 = 682219935;
							num4 = 682219935;
						}
						num = num3 ^ (int)(num2 * 916874417);
						continue;
					}
					case 1u:
						Form3.smethod_52((Control)(object)editProfileBtn, eventHandler_);
						num = (int)((num2 * 228450798) ^ 0x576D147F);
						continue;
					case 0u:
						_EditProfileBtn = value;
						num = 841048116;
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

	internal virtual Button UpdateStaffBtn
	{
		[CompilerGenerated]
		get
		{
			return _UpdateStaffBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = UpdateStaffBtn_Click;
			Button updateStaffBtn = _UpdateStaffBtn;
			if (updateStaffBtn != null)
			{
				goto IL_001a;
			}
			goto IL_00b2;
			IL_00b2:
			_UpdateStaffBtn = value;
			int num = 1671068886;
			goto IL_0085;
			IL_0085:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x287EC514u) % 7u)
				{
				case 6u:
					break;
				case 5u:
					Form3.smethod_51((Control)(object)updateStaffBtn, eventHandler_);
					num = (int)(num2 * 1873927835) ^ -2118894645;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (updateStaffBtn == null)
					{
						num3 = 1559692269;
						num4 = 1559692269;
					}
					else
					{
						num3 = 1683207713;
						num4 = 1683207713;
					}
					num = num3 ^ (int)(num2 * 300633311);
					continue;
				}
				case 2u:
					updateStaffBtn = _UpdateStaffBtn;
					num = (int)(num2 * 1471516745) ^ -263333133;
					continue;
				case 1u:
					Form3.smethod_52((Control)(object)updateStaffBtn, eventHandler_);
					num = ((int)num2 * -2031865870) ^ 0x1F4F81A;
					continue;
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
			num = 324132507;
			goto IL_0085;
		}
	}

	internal virtual Button AddStaffBtn
	{
		[CompilerGenerated]
		get
		{
			return _AddStaffBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = AddStaffBtn_Click_1;
			Button addStaffBtn = _AddStaffBtn;
			while (true)
			{
				int num = -1471255545;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8A4AC721u) % 8u)
					{
					case 7u:
						addStaffBtn = _AddStaffBtn;
						num = (int)(num2 * 339539060) ^ -684781688;
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (addStaffBtn != null)
						{
							num5 = -429907654;
							num6 = -429907654;
						}
						else
						{
							num5 = -1886028735;
							num6 = -1886028735;
						}
						num = num5 ^ ((int)num2 * -165620085);
						continue;
					}
					case 5u:
					{
						int num3;
						int num4;
						if (addStaffBtn != null)
						{
							num3 = 1673280540;
							num4 = 1673280540;
						}
						else
						{
							num3 = 1317616251;
							num4 = 1317616251;
						}
						num = num3 ^ (int)(num2 * 1222159877);
						continue;
					}
					case 4u:
						Form3.smethod_52((Control)(object)addStaffBtn, eventHandler_);
						num = ((int)num2 * -2114561363) ^ -1743980554;
						continue;
					case 2u:
						_AddStaffBtn = value;
						num = -983645954;
						continue;
					case 1u:
						Form3.smethod_51((Control)(object)addStaffBtn, eventHandler_);
						num = ((int)num2 * -235748889) ^ 0x6EAC6D0C;
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

	internal virtual Button SearchPtntBtn
	{
		[CompilerGenerated]
		get
		{
			return _SearchPtntBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = SearchPtntBtn_Click;
			Button searchPtntBtn = default(Button);
			while (true)
			{
				int num = 1565161534;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x10B032A8u) % 7u)
					{
					case 6u:
						_SearchPtntBtn = value;
						searchPtntBtn = _SearchPtntBtn;
						num = 1161507727;
						continue;
					case 4u:
						Form3.smethod_52((Control)(object)searchPtntBtn, eventHandler_);
						num = (int)((num2 * 281854599) ^ 0x3AD2D6A6);
						continue;
					case 2u:
						Form3.smethod_51((Control)(object)searchPtntBtn, eventHandler_);
						num = ((int)num2 * -120796246) ^ -406524733;
						continue;
					case 1u:
					{
						searchPtntBtn = _SearchPtntBtn;
						int num5;
						int num6;
						if (searchPtntBtn != null)
						{
							num5 = 219893110;
							num6 = 219893110;
						}
						else
						{
							num5 = 1554881095;
							num6 = 1554881095;
						}
						num = num5 ^ (int)(num2 * 1631982036);
						continue;
					}
					case 0u:
					{
						int num3;
						int num4;
						if (searchPtntBtn != null)
						{
							num3 = -261179143;
							num4 = -261179143;
						}
						else
						{
							num3 = -521074793;
							num4 = -521074793;
						}
						num = num3 ^ (int)(num2 * 906431191);
						continue;
					}
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
				goto IL_0082;
			}
			goto IL_00b4;
			IL_00b4:
			_BloodAvailabilityBtn = value;
			int num = -1872595003;
			goto IL_0087;
			IL_0087:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x97C2DEF5u) % 7u)
				{
				case 6u:
					Form3.smethod_51((Control)(object)bloodAvailabilityBtn, eventHandler_);
					num = ((int)num2 * -45454379) ^ -192780912;
					continue;
				case 5u:
					Form3.smethod_52((Control)(object)bloodAvailabilityBtn, eventHandler_);
					num = ((int)num2 * -1315036585) ^ -1000076169;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (bloodAvailabilityBtn != null)
					{
						num3 = -1069250578;
						num4 = -1069250578;
					}
					else
					{
						num3 = -424019622;
						num4 = -424019622;
					}
					num = num3 ^ ((int)num2 * -488387878);
					continue;
				}
				case 1u:
					bloodAvailabilityBtn = _BloodAvailabilityBtn;
					num = ((int)num2 * -910185632) ^ -2050048331;
					continue;
				case 0u:
					break;
				default:
					return;
				case 3u:
					goto IL_00b4;
				case 4u:
					return;
				}
				break;
			}
			goto IL_0082;
			IL_0082:
			num = -488903627;
			goto IL_0087;
		}
	}

	internal virtual Button SearchRecieverBtn
	{
		[CompilerGenerated]
		get
		{
			return _SearchRecieverBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = SearchRecieverBtn_Click;
			Button searchRecieverBtn = default(Button);
			while (true)
			{
				int num = 1678965230;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1EBBF098u) % 8u)
					{
					case 7u:
						Form3.smethod_51((Control)(object)searchRecieverBtn, eventHandler_);
						num = (int)((num2 * 925428841) ^ 0x7CC3051E);
						continue;
					case 6u:
						searchRecieverBtn = _SearchRecieverBtn;
						num = ((int)num2 * -48088293) ^ -1343448936;
						continue;
					case 5u:
						Form3.smethod_52((Control)(object)searchRecieverBtn, eventHandler_);
						num = (int)((num2 * 1403626311) ^ 0x71820718);
						continue;
					case 4u:
					{
						searchRecieverBtn = _SearchRecieverBtn;
						int num5;
						int num6;
						if (searchRecieverBtn != null)
						{
							num5 = 1524951101;
							num6 = 1524951101;
						}
						else
						{
							num5 = 352471339;
							num6 = 352471339;
						}
						num = num5 ^ (int)(num2 * 2301646);
						continue;
					}
					case 2u:
					{
						int num3;
						int num4;
						if (searchRecieverBtn == null)
						{
							num3 = -1442076193;
							num4 = -1442076193;
						}
						else
						{
							num3 = -932653135;
							num4 = -932653135;
						}
						num = num3 ^ ((int)num2 * -1797734173);
						continue;
					}
					case 1u:
						_SearchRecieverBtn = value;
						num = 1965513020;
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

	internal virtual Button SearchDonorBtn
	{
		[CompilerGenerated]
		get
		{
			return _SearchDonorBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = SearchDonorBtn_Click;
			Button searchDonorBtn = _SearchDonorBtn;
			if (searchDonorBtn != null)
			{
				goto IL_0056;
			}
			goto IL_009a;
			IL_009a:
			_SearchDonorBtn = value;
			searchDonorBtn = _SearchDonorBtn;
			int num = -383924858;
			goto IL_0071;
			IL_0071:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB2A6A063u) % 6u)
				{
				case 5u:
				{
					int num3;
					int num4;
					if (searchDonorBtn == null)
					{
						num3 = -625921073;
						num4 = -625921073;
					}
					else
					{
						num3 = -2067246235;
						num4 = -2067246235;
					}
					num = num3 ^ ((int)num2 * -176989530);
					continue;
				}
				case 4u:
					Form3.smethod_52((Control)(object)searchDonorBtn, eventHandler_);
					num = ((int)num2 * -2017412854) ^ 0x21D36501;
					continue;
				case 3u:
					break;
				case 1u:
					Form3.smethod_51((Control)(object)searchDonorBtn, eventHandler_);
					num = ((int)num2 * -2115657779) ^ -1014033692;
					continue;
				default:
					return;
				case 0u:
					goto IL_009a;
				case 2u:
					return;
				}
				break;
			}
			goto IL_0056;
			IL_0056:
			num = -159999764;
			goto IL_0071;
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Form3()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		Form3.smethod_0((Form)(object)this, new FormClosedEventHandler(Form3_FormClosed));
		Form3.smethod_1((Form)(object)this, (EventHandler)Form3_Shown);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			while (true)
			{
				int num = 1073500241;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x7E1FC670u) % 7u)
					{
					case 6u:
						num = 784834456;
						continue;
					case 5u:
						if (components != null)
						{
							num = 87222640;
							num3 = 87222640;
							continue;
						}
						goto IL_0019;
					case 4u:
						if (disposing)
						{
							num = ((int)num2 * -633766459) ^ 0x3F8B0E34;
							continue;
						}
						goto IL_0019;
					case 3u:
						num = ((int)num2 * -2131609560) ^ 0x6A698CBC;
						continue;
					case 2u:
						Form3.smethod_2((IDisposable)components);
						num = (int)((num2 * 796752398) ^ 0x63B4888E);
						continue;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
						IL_0019:
						num = 951556876;
						num3 = 951556876;
						continue;
					}
					break;
				}
			}
		}
		finally
		{
			while (true)
			{
				IL_00d8:
				int num4 = 1102161406;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num4 ^ 0x7E1FC670u) % 3u)
					{
					case 1u:
						goto IL_00a7;
					default:
						goto end_IL_00bb;
					case 0u:
						break;
					case 2u:
						goto end_IL_00bb;
					}
					goto IL_00d8;
					IL_00a7:
					((Form)this).Dispose(disposing);
					num4 = (int)((num2 * 1811541291) ^ 0x7FBD46DF);
					continue;
					end_IL_00bb:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1342: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_17f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1905: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b91: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d18: Unknown result type (might be due to invalid IL or missing references)
		//IL_2586: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = 64917961;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x34FF9DDEu) % 305u)
				{
				case 304u:
					Form3.smethod_13((Control)(object)AddStaffBtn, "AddStaffBtn");
					Form3.smethod_14((Control)(object)AddStaffBtn, new Size(316, 50));
					Form3.smethod_15((Control)(object)AddStaffBtn, 4);
					num = (int)((num2 * 1183118959) ^ 0x2D7EE941);
					continue;
				case 303u:
					num = ((int)num2 * -117252822) ^ 0x3D43A62;
					continue;
				case 302u:
					num = (int)(num2 * 1343093660) ^ -207795929;
					continue;
				case 301u:
					Form3.smethod_26((Control)(object)GroupBox4, new Padding(0));
					num = ((int)num2 * -1208878788) ^ 0x5C1401CD;
					continue;
				case 300u:
					Form3.smethod_35((Control)(object)Label2, Color.White);
					num = ((int)num2 * -2056890184) ^ -577360595;
					continue;
				case 299u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox5), (Control)(object)EditProfileBtn);
					num = ((int)num2 * -752199199) ^ -2099699455;
					continue;
				case 298u:
					PatientPanel2 = Form3.smethod_3();
					num = ((int)num2 * -2029366279) ^ 0x4A1BF528;
					continue;
				case 297u:
					Form3.smethod_26((Control)(object)SearchRecieverBtn, new Padding(0));
					num = ((int)num2 * -1019939255) ^ 0x552E253F;
					continue;
				case 296u:
					Form3.smethod_15((Control)(object)UpdateStaffBtn, 7);
					Form3.smethod_27((ButtonBase)(object)UpdateStaffBtn, "Update Staff");
					num = (int)(num2 * 1712596486) ^ -304302986;
					continue;
				case 295u:
					Form3.smethod_27((ButtonBase)(object)BloodAvailabilityBtn, "Blood Availability");
					num = ((int)num2 * -172210709) ^ -928329673;
					continue;
				case 294u:
					Form3.smethod_15((Control)(object)StaffPanel2, 6);
					num = (int)(num2 * 752938209) ^ -610430690;
					continue;
				case 293u:
					num = ((int)num2 * -68669035) ^ 0x2FD81A1B;
					continue;
				case 292u:
					Form3.smethod_13((Control)(object)SearchPtntBtn, "SearchPtntBtn");
					num = ((int)num2 * -1030291262) ^ 0x25611AE8;
					continue;
				case 291u:
					Form3.smethod_11((Control)(object)StaffPanel2, Color.Transparent);
					Form3.smethod_12((Control)(object)StaffPanel2, new Point(311, 37));
					Form3.smethod_13((Control)(object)StaffPanel2, "StaffPanel2");
					num = ((int)num2 * -663427156) ^ 0x16275C0E;
					continue;
				case 290u:
					num = ((int)num2 * -1237887859) ^ -1143778421;
					continue;
				case 289u:
					UpdateStaffBtn = Form3.smethod_5();
					num = ((int)num2 * -2007845844) ^ 0x10C3F4F1;
					continue;
				case 288u:
					Form3.smethod_15((Control)(object)StaffPanel1, 5);
					Form3.smethod_11((Control)(object)GroupBox2, Color.White);
					num = (int)(num2 * 1908860571) ^ -947171940;
					continue;
				case 287u:
					Form3.smethod_13((Control)(object)GroupBox3, "GroupBox3");
					num = ((int)num2 * -1958562580) ^ 0x2C330473;
					continue;
				case 286u:
					num = (int)((num2 * 1479879649) ^ 0x22E27950);
					continue;
				case 285u:
					Form3.smethod_20((Control)(object)GroupBox5, Form3.smethod_19("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Form3.smethod_12((Control)(object)GroupBox5, new Point(13, 578));
					num = (int)((num2 * 421679199) ^ 0x5334C7F6);
					continue;
				case 284u:
					StaffPanel1 = Form3.smethod_3();
					GroupBox2 = Form3.smethod_4();
					num = (int)((num2 * 1917843474) ^ 0x4D3F42BC);
					continue;
				case 283u:
					Form3.smethod_38((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = (int)(num2 * 609996892) ^ -809687149;
					continue;
				case 282u:
					Form3.smethod_15((Control)(object)GroupBox3, 10);
					num = (int)((num2 * 16533328) ^ 0x6AF4E5E0);
					continue;
				case 281u:
					Form3.smethod_14((Control)(object)UpdateStaffBtn, new Size(316, 50));
					num = ((int)num2 * -224047777) ^ 0x4F06CA04;
					continue;
				case 280u:
					Form3.smethod_14((Control)(object)GroupBox2, new Size(355, 114));
					num = ((int)num2 * -856593349) ^ 0x2153BD92;
					continue;
				case 279u:
					Form3.smethod_15((Control)(object)AdminPanel, 5);
					num = ((int)num2 * -1615798667) ^ 0x7E5B1DF6;
					continue;
				case 278u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox4), (Control)(object)BloodBankPanel1);
					num = (int)((num2 * 1709384275) ^ 0x2DECE87);
					continue;
				case 277u:
					Form3.smethod_46((Form)(object)this, (FormWindowState)2);
					num = (int)((num2 * 1225857737) ^ 0x821A89E);
					continue;
				case 276u:
					Form3.smethod_13((Control)(object)GroupBox2, "GroupBox2");
					num = ((int)num2 * -385739545) ^ 0x46A50CED;
					continue;
				case 275u:
					Form3.smethod_45((Form)(object)this, "Form3");
					num = ((int)num2 * -69218007) ^ 0x7BBBD05B;
					continue;
				case 274u:
					num = ((int)num2 * -520139986) ^ -640315205;
					continue;
				case 273u:
					Form3.smethod_12((Control)(object)LogoutBtn, new Point(20, 102));
					num = (int)((num2 * 1960208909) ^ 0x9368F2A);
					continue;
				case 272u:
					Form3.smethod_27((ButtonBase)(object)SearchDonorBtn, "Search Donor");
					Form3.smethod_28((ButtonBase)(object)SearchDonorBtn, bool_0: true);
					num = (int)((num2 * 828918758) ^ 0x4A3A348D);
					continue;
				case 271u:
					Form3.smethod_13((Control)(object)PictureBox1, "PictureBox1");
					num = (int)((num2 * 266805140) ^ 0x2767F659);
					continue;
				case 270u:
					GroupBox4 = Form3.smethod_4();
					BloodAvailabilityBtn = Form3.smethod_5();
					num = ((int)num2 * -267176750) ^ 0x50A2CD7B;
					continue;
				case 269u:
					num = ((int)num2 * -11501052) ^ -1542570149;
					continue;
				case 268u:
					Form3.smethod_15((Control)(object)Panel1, 7);
					num = (int)((num2 * 156815501) ^ 0x1F697F87);
					continue;
				case 267u:
					num = ((int)num2 * -1931969263) ^ 0x2C062971;
					continue;
				case 266u:
					PatientPanel1 = Form3.smethod_3();
					num = ((int)num2 * -1656989897) ^ 0x7015146F;
					continue;
				case 265u:
					Form3.smethod_36(Label2, "Golisano's Hospital Of Florida");
					num = ((int)num2 * -543787496) ^ -320710356;
					continue;
				case 264u:
					num = ((int)num2 * -1864521176) ^ 0x1B20854F;
					continue;
				case 263u:
					Form3.smethod_20((Control)(object)SearchRecieverBtn, Form3.smethod_19("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -160868568) ^ -376849110;
					continue;
				case 262u:
					num = (int)((num2 * 1891616099) ^ 0xA162E2D);
					continue;
				case 261u:
					num = (int)((num2 * 124914604) ^ 0xC318C20);
					continue;
				case 260u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox5), (Control)(object)PersonalInfoPanel2);
					num = ((int)num2 * -1976376031) ^ -147147374;
					continue;
				case 259u:
					Form3.smethod_12((Control)(object)SearchRecieverBtn, new Point(20, 88));
					num = (int)(num2 * 1006893794) ^ -667353082;
					continue;
				case 258u:
					num = (int)(num2 * 1844701176) ^ -1372516161;
					continue;
				case 257u:
					Form3.smethod_12((Control)(object)PatientPanel1, new Point(6, 43));
					num = ((int)num2 * -527778677) ^ 0x36716987;
					continue;
				case 256u:
					Form3.smethod_48((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -1650462033) ^ -756959939;
					continue;
				case 255u:
					num = (int)(num2 * 446904278) ^ -1689479117;
					continue;
				case 254u:
					BloodBankPanel1 = Form3.smethod_3();
					PictureBox1 = Form3.smethod_6();
					num = (int)((num2 * 1323121811) ^ 0x3DC50E8A);
					continue;
				case 253u:
					Form3.smethod_26((Control)(object)UpdateStaffBtn, new Padding(0));
					num = ((int)num2 * -916928111) ^ -1816598738;
					continue;
				case 252u:
					num = ((int)num2 * -1191208451) ^ -1153049844;
					continue;
				case 251u:
					AddStaffBtn = Form3.smethod_5();
					num = ((int)num2 * -1128180157) ^ 0x35844139;
					continue;
				case 250u:
					GroupBox3 = Form3.smethod_4();
					num = ((int)num2 * -377567615) ^ -750379741;
					continue;
				case 249u:
					num = (int)(num2 * 1787312773) ^ -252714695;
					continue;
				case 248u:
					SearchPtntBtn = Form3.smethod_5();
					num = ((int)num2 * -129807811) ^ 0x62EBCBB0;
					continue;
				case 247u:
					num = ((int)num2 * -329985123) ^ -85383405;
					continue;
				case 246u:
					num = (int)(num2 * 1540795664) ^ -1088085867;
					continue;
				case 245u:
					Form3.smethod_15((Control)(object)GroupBox4, 11);
					num = ((int)num2 * -2131651326) ^ -41575556;
					continue;
				case 244u:
					Form3.smethod_27((ButtonBase)(object)EditProfileBtn, "Edit Profile");
					num = ((int)num2 * -1312075333) ^ -1265736578;
					continue;
				case 243u:
					Form3.smethod_14((Control)(object)BloodBankPanel1, new Size(44, 50));
					num = ((int)num2 * -1939601654) ^ 0x314C64C4;
					continue;
				case 242u:
					Form3.smethod_24(Form3.smethod_23((ButtonBase)(object)AddStaffBtn), 0);
					Form3.smethod_25((ButtonBase)(object)AddStaffBtn, (FlatStyle)0);
					num = ((int)num2 * -1962550661) ^ 0x46B751AF;
					continue;
				case 241u:
					Form3.smethod_15((Control)(object)SearchPtntBtn, 1);
					num = (int)(num2 * 1603190441) ^ -166923931;
					continue;
				case 240u:
					Form3.smethod_28((ButtonBase)(object)EditProfileBtn, bool_0: true);
					Form3.smethod_11((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = ((int)num2 * -1324593361) ^ -1243690124;
					continue;
				case 239u:
					num = ((int)num2 * -245333862) ^ -1383119434;
					continue;
				case 238u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox4), (Control)(object)SearchRecieverBtn);
					num = ((int)num2 * -493107282) ^ 0x696ECB;
					continue;
				case 237u:
					Form3.smethod_25((ButtonBase)(object)EditProfileBtn, (FlatStyle)0);
					num = (int)((num2 * 169297282) ^ 0x33DCCB);
					continue;
				case 236u:
					num = (int)(num2 * 535916567) ^ -1520759415;
					continue;
				case 235u:
					Form3.smethod_13((Control)(object)GroupBox4, "GroupBox4");
					num = ((int)num2 * -517321631) ^ 0x261E91A9;
					continue;
				case 234u:
					num = (int)((num2 * 618443319) ^ 0x18B98F2C);
					continue;
				case 233u:
					Form3.smethod_8((Control)(object)GroupBox5);
					num = (int)((num2 * 224293019) ^ 0x468ABBBD);
					continue;
				case 232u:
					Form3.smethod_31(PictureBox1, (PictureBoxSizeMode)1);
					num = (int)(num2 * 856803654) ^ -1935479734;
					continue;
				case 231u:
					Form3.smethod_27((ButtonBase)(object)AddStaffBtn, "Add Staff");
					num = ((int)num2 * -2116475595) ^ 0x1EE5AC82;
					continue;
				case 230u:
					num = (int)((num2 * 379515706) ^ 0x38E47503);
					continue;
				case 229u:
					Form3.smethod_14((Control)(object)GroupBox4, new Size(355, 210));
					num = (int)(num2 * 174393106) ^ -1380276069;
					continue;
				case 228u:
					num = (int)(num2 * 1212476335) ^ -1168728374;
					continue;
				case 227u:
					Form3.smethod_12((Control)(object)SearchDonorBtn, new Point(20, 38));
					num = (int)(num2 * 1079861715) ^ -1993414939;
					continue;
				case 226u:
					num = ((int)num2 * -1519378550) ^ -262198292;
					continue;
				case 225u:
					num = (int)((num2 * 461765970) ^ 0x4A078A4);
					continue;
				case 224u:
					Form3.smethod_13((Control)(object)UpdateStaffBtn, "UpdateStaffBtn");
					num = ((int)num2 * -1066418340) ^ 0x720818E6;
					continue;
				case 223u:
					num = (int)(num2 * 626214302) ^ -1942770628;
					continue;
				case 222u:
					Form3.smethod_39((ContainerControl)(object)this, (AutoScaleMode)1);
					Form3.smethod_40((Form)(object)this, Color.MidnightBlue);
					num = ((int)num2 * -2139431220) ^ 0x1B19ECB6;
					continue;
				case 221u:
					Form3.smethod_15((Control)(object)GroupBox2, 9);
					Form3.smethod_21(GroupBox2, bool_0: false);
					num = ((int)num2 * -793549286) ^ 0x575C342F;
					continue;
				case 220u:
					Form3.smethod_20((Control)(object)AddStaffBtn, Form3.smethod_19("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1194901915) ^ 0x262E25BC;
					continue;
				case 219u:
					num = ((int)num2 * -1567657681) ^ 0x6EE4CA13;
					continue;
				case 218u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)Panel1), (Control)(object)GroupBox5);
					num = (int)(num2 * 1617874732) ^ -1839825334;
					continue;
				case 217u:
					num = ((int)num2 * -1887107001) ^ 0x4225AD84;
					continue;
				case 216u:
					num = ((int)num2 * -463246247) ^ 0x7EBB4BDF;
					continue;
				case 215u:
					Form3.smethod_20((Control)(object)SearchPtntBtn, Form3.smethod_19("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1237550400) ^ 0x39E16AFE);
					continue;
				case 214u:
					num = ((int)num2 * -709723400) ^ 0x63AC9507;
					continue;
				case 213u:
					EditProfileBtn = Form3.smethod_5();
					num = (int)((num2 * 1115295496) ^ 0x7FE9FB06);
					continue;
				case 212u:
					Form3.smethod_25((ButtonBase)(object)SearchPtntBtn, (FlatStyle)0);
					num = ((int)num2 * -1662016135) ^ -2063347077;
					continue;
				case 211u:
					Form3.smethod_47((Control)(object)GroupBox5, bool_0: false);
					num = (int)(num2 * 1116616007) ^ -638354277;
					continue;
				case 210u:
					num = (int)((num2 * 968128038) ^ 0x665F2A24);
					continue;
				case 209u:
					num = ((int)num2 * -1898390093) ^ 0x6E9D74B;
					continue;
				case 208u:
					PersonalInfoPanel1 = Form3.smethod_3();
					num = (int)(num2 * 836562973) ^ -1183033851;
					continue;
				case 207u:
					num = ((int)num2 * -1365557321) ^ 0x26797AA5;
					continue;
				case 206u:
					Form3.smethod_13((Control)(object)PersonalInfoPanel1, "PersonalInfoPanel1");
					Form3.smethod_14((Control)(object)PersonalInfoPanel1, new Size(44, 50));
					num = (int)(num2 * 1767467182) ^ -360689833;
					continue;
				case 205u:
					num = (int)((num2 * 1114453365) ^ 0x13916BAD);
					continue;
				case 204u:
					num = (int)(num2 * 230280865) ^ -1683534027;
					continue;
				case 203u:
					num = (int)((num2 * 2145725362) ^ 0x4C47F374);
					continue;
				case 202u:
					Form3.smethod_20((Control)(object)Label2, Form3.smethod_19("Microsoft Sans Serif", 36f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1145068985) ^ -561765347;
					continue;
				case 201u:
					Form3.smethod_25((ButtonBase)(object)UpdateStaffBtn, (FlatStyle)0);
					num = (int)(num2 * 2046380560) ^ -481978055;
					continue;
				case 200u:
					Form3.smethod_13((Control)(object)PersonalInfoPanel2, "PersonalInfoPanel2");
					Form3.smethod_14((Control)(object)PersonalInfoPanel2, new Size(44, 50));
					num = ((int)num2 * -1398571856) ^ -1062674135;
					continue;
				case 199u:
					Form3.smethod_18(Form3.smethod_42((Control)(object)this), (Control)(object)Label2);
					num = ((int)num2 * -1590499533) ^ -112010369;
					continue;
				case 197u:
					num = ((int)num2 * -682717343) ^ -1478659227;
					continue;
				case 196u:
					Form3.smethod_14((Control)(object)SearchPtntBtn, new Size(311, 50));
					num = (int)((num2 * 2077098803) ^ 0x72A85716);
					continue;
				case 195u:
					num = ((int)num2 * -640940340) ^ 0x3DBEFE09;
					continue;
				case 194u:
					num = (int)((num2 * 1117213868) ^ 0x164F93EE);
					continue;
				case 193u:
					Form3.smethod_14((Control)(object)BloodBankPanel2, new Size(44, 50));
					Form3.smethod_15((Control)(object)BloodBankPanel2, 15);
					num = ((int)num2 * -966172769) ^ 0x4911C8F2;
					continue;
				case 192u:
					Form3.smethod_14((Control)(object)GroupBox3, new Size(355, 165));
					num = ((int)num2 * -1623396256) ^ -552489254;
					continue;
				case 191u:
					Form3.smethod_16((ScrollableControl)(object)Panel1, bool_0: true);
					num = ((int)num2 * -1351853757) ^ -409472510;
					continue;
				case 190u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox4), (Control)(object)BloodAvailabilityBtn);
					num = (int)(num2 * 559139730) ^ -786816765;
					continue;
				case 189u:
					num = (int)(num2 * 1880486140) ^ -1968585626;
					continue;
				case 188u:
					Form3.smethod_37(Label2, (ContentAlignment)32);
					num = ((int)num2 * -1839864775) ^ -535818367;
					continue;
				case 187u:
					Form3.smethod_14((Control)(object)StaffPanel1, new Size(44, 50));
					num = ((int)num2 * -1770738635) ^ -1133484953;
					continue;
				case 186u:
					Form3.smethod_25((ButtonBase)(object)SearchDonorBtn, (FlatStyle)0);
					num = ((int)num2 * -1570668692) ^ 0x53D5E800;
					continue;
				case 185u:
					Form3.smethod_12((Control)(object)UpdateStaffBtn, new Point(20, 90));
					num = (int)(num2 * 1061521372) ^ -47700027;
					continue;
				case 184u:
					Form3.smethod_15((Control)(object)BloodBankPanel1, 14);
					num = (int)((num2 * 19976438) ^ 0x4E112ECB);
					continue;
				case 183u:
					num = (int)((num2 * 1223896170) ^ 0x5D1BD4AD);
					continue;
				case 182u:
					Form3.smethod_12((Control)(object)BloodBankPanel1, new Point(0, 38));
					num = (int)((num2 * 2067648168) ^ 0x6216F7B5);
					continue;
				case 181u:
					Form3.smethod_47((Control)(object)Panel1, bool_0: false);
					num = ((int)num2 * -1411982756) ^ 0x75E48CC3;
					continue;
				case 180u:
					Form3.smethod_12((Control)(object)AdminPanel, new Point(716, 141));
					num = (int)((num2 * 719257026) ^ 0x1473509E);
					continue;
				case 179u:
					Form3.smethod_11((Control)(object)BloodBankPanel1, Color.Transparent);
					num = ((int)num2 * -1792353146) ^ 0x45FEE967;
					continue;
				case 178u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox3), (Control)(object)StaffPanel2);
					num = (int)(num2 * 1293255514) ^ -289969250;
					continue;
				case 177u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox5), (Control)(object)LogoutBtn);
					num = (int)(num2 * 2094681722) ^ -1404262056;
					continue;
				case 176u:
					Form3.smethod_47((Control)(object)GroupBox3, bool_0: false);
					num = ((int)num2 * -878732746) ^ 0x700F4671;
					continue;
				case 175u:
					num = (int)((num2 * 919073724) ^ 0x7DBF9460);
					continue;
				case 174u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox4), (Control)(object)SearchDonorBtn);
					num = ((int)num2 * -17007815) ^ -573331441;
					continue;
				case 173u:
					Form3.smethod_15((Control)(object)GroupBox5, 12);
					Form3.smethod_21(GroupBox5, bool_0: false);
					num = (int)((num2 * 1804915174) ^ 0x11568DEF);
					continue;
				case 172u:
					num = ((int)num2 * -79729163) ^ 0x5AC1558;
					continue;
				case 171u:
					Form3.smethod_12((Control)(object)PersonalInfoPanel2, new Point(311, 52));
					num = (int)((num2 * 2084440006) ^ 0x7D687370);
					continue;
				case 170u:
					Form3.smethod_13((Control)(object)SearchRecieverBtn, "SearchRecieverBtn");
					num = ((int)num2 * -2070944692) ^ -205530255;
					continue;
				case 169u:
					num = ((int)num2 * -413808978) ^ -353886540;
					continue;
				case 168u:
					Form3.smethod_11((Control)(object)Panel1, Color.White);
					num = ((int)num2 * -389911372) ^ 0x5F40B0D;
					continue;
				case 167u:
					Form3.smethod_15((Control)(object)BloodAvailabilityBtn, 7);
					num = ((int)num2 * -2040957612) ^ -1076976569;
					continue;
				case 166u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox5), (Control)(object)PersonalInfoPanel1);
					num = ((int)num2 * -2110022374) ^ -436738373;
					continue;
				case 165u:
					Form3.smethod_13((Control)(object)SearchDonorBtn, "SearchDonorBtn");
					num = (int)((num2 * 1531439599) ^ 0x7BDE01B9);
					continue;
				case 164u:
					Form3.smethod_22(GroupBox2, "Patient");
					num = (int)((num2 * 1488668036) ^ 0x5A16C9F6);
					continue;
				case 163u:
					AdminPanel = Form3.smethod_3();
					num = (int)((num2 * 97262660) ^ 0x7E4AEE1A);
					continue;
				case 162u:
					Form3.smethod_34(Label2, bool_0: true);
					Form3.smethod_11((Control)(object)Label2, Color.Transparent);
					num = ((int)num2 * -1691498580) ^ 0x78205A7D;
					continue;
				case 161u:
					num = ((int)num2 * -754323251) ^ -1413858091;
					continue;
				case 160u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox4), (Control)(object)BloodBankPanel2);
					num = ((int)num2 * -1290723134) ^ -310240701;
					continue;
				case 159u:
					num = (int)(num2 * 1712704278) ^ -132586112;
					continue;
				case 158u:
					num = ((int)num2 * -1500050957) ^ 0x61E3C856;
					continue;
				case 157u:
					num = (int)(num2 * 975520402) ^ -1471581987;
					continue;
				case 156u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)Panel1), (Control)(object)GroupBox4);
					num = (int)(num2 * 1894996778) ^ -1618676025;
					continue;
				case 155u:
					num = (int)(num2 * 433372138) ^ -244329306;
					continue;
				case 154u:
					num = ((int)num2 * -2110906878) ^ 0x33336A5C;
					continue;
				case 153u:
					Form3.smethod_12((Control)(object)AddStaffBtn, new Point(20, 37));
					num = ((int)num2 * -1785736269) ^ 0x6CEB5DFF;
					continue;
				case 152u:
					num = (int)((num2 * 785790097) ^ 0x5099F2DE);
					continue;
				case 151u:
					Form3.smethod_12((Control)(object)GroupBox4, new Point(13, 344));
					num = ((int)num2 * -420953148) ^ 0x2F870FD;
					continue;
				case 150u:
					num = (int)((num2 * 131599226) ^ 0x8EE8FC8);
					continue;
				case 149u:
					Form3.smethod_27((ButtonBase)(object)LogoutBtn, "Logout");
					num = ((int)num2 * -51712184) ^ 0x63C5A284;
					continue;
				case 148u:
					Form3.smethod_14((Control)(object)EditProfileBtn, new Size(316, 50));
					num = ((int)num2 * -573348694) ^ -3433497;
					continue;
				case 147u:
					num = (int)(num2 * 1971935487) ^ -785814981;
					continue;
				case 146u:
					Form3.smethod_32(PictureBox1, 9);
					num = (int)((num2 * 1630854571) ^ 0x38519F95);
					continue;
				case 145u:
					Form3.smethod_26((Control)(object)LogoutBtn, new Padding(0));
					Form3.smethod_13((Control)(object)LogoutBtn, "LogoutBtn");
					num = (int)(num2 * 1339932843) ^ -879062931;
					continue;
				case 144u:
					Form3.smethod_12((Control)(object)PersonalInfoPanel1, new Point(0, 52));
					num = (int)((num2 * 634356578) ^ 0x6C5795AA);
					continue;
				case 143u:
					num = (int)((num2 * 96320599) ^ 0x1C43A030);
					continue;
				case 142u:
					Form3.smethod_24(Form3.smethod_23((ButtonBase)(object)SearchPtntBtn), 0);
					num = (int)(num2 * 305723371) ^ -1859372155;
					continue;
				case 141u:
					Form3.smethod_11((Control)(object)PatientPanel2, Color.Transparent);
					num = (int)((num2 * 170480445) ^ 0x126D1B85);
					continue;
				case 140u:
					Form3.smethod_26((Control)(object)GroupBox2, new Padding(0));
					num = ((int)num2 * -112849917) ^ -1567365662;
					continue;
				case 139u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox2), (Control)(object)SearchPtntBtn);
					num = ((int)num2 * -196190556) ^ 0x59DEA20;
					continue;
				case 138u:
					GroupBox5 = Form3.smethod_4();
					num = (int)(num2 * 1181527219) ^ -1167057983;
					continue;
				case 137u:
					Form3.smethod_25((ButtonBase)(object)LogoutBtn, (FlatStyle)0);
					num = (int)((num2 * 2088750458) ^ 0x234F5B2F);
					continue;
				case 136u:
					num = (int)((num2 * 1243996821) ^ 0x61B589DD);
					continue;
				case 135u:
					Form3.smethod_12((Control)(object)SearchPtntBtn, new Point(25, 43));
					num = (int)(num2 * 1912156727) ^ -88246939;
					continue;
				case 134u:
					num = (int)(num2 * 1396225078) ^ -1496578416;
					continue;
				case 133u:
					Form3.smethod_14((Control)(object)Label2, new Size(845, 69));
					num = ((int)num2 * -122792263) ^ 0x6B23AC16;
					continue;
				case 132u:
					num = (int)(num2 * 1296768219) ^ -1396044417;
					continue;
				case 131u:
					StaffPanel2 = Form3.smethod_3();
					num = (int)(num2 * 145332631) ^ -1321876799;
					continue;
				case 130u:
					Form3.smethod_41((Form)(object)this, new Size(1262, 953));
					num = ((int)num2 * -1672617095) ^ 0x6D5A2C04;
					continue;
				case 129u:
					Form3.smethod_12((Control)(object)Label2, new Point(428, 35));
					num = (int)(num2 * 1262686010) ^ -184291797;
					continue;
				case 128u:
					num = (int)(num2 * 685558031) ^ -798665028;
					continue;
				case 127u:
					num = (int)(num2 * 1178976798) ^ -829872661;
					continue;
				case 126u:
					Form3.smethod_22(GroupBox4, "Blood Bank");
					Form3.smethod_24(Form3.smethod_23((ButtonBase)(object)BloodAvailabilityBtn), 0);
					Form3.smethod_25((ButtonBase)(object)BloodAvailabilityBtn, (FlatStyle)0);
					Form3.smethod_20((Control)(object)BloodAvailabilityBtn, Form3.smethod_19("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 545771067) ^ 0xF31795B);
					continue;
				case 125u:
					Form3.smethod_27((ButtonBase)(object)SearchRecieverBtn, "Search Reciever");
					Form3.smethod_28((ButtonBase)(object)SearchRecieverBtn, bool_0: true);
					Form3.smethod_24(Form3.smethod_23((ButtonBase)(object)SearchDonorBtn), 0);
					num = ((int)num2 * -2066491971) ^ 0x134472FC;
					continue;
				case 124u:
					Form3.smethod_13((Control)(object)StaffPanel1, "StaffPanel1");
					num = ((int)num2 * -1421866956) ^ 0x1DDA5B9;
					continue;
				case 123u:
					num = ((int)num2 * -409136027) ^ -419019119;
					continue;
				case 122u:
					num = (int)(num2 * 1984618220) ^ -15982763;
					continue;
				case 121u:
					num = (int)((num2 * 630674937) ^ 0x677B048C);
					continue;
				case 120u:
					Form3.smethod_15((Control)(object)PersonalInfoPanel1, 15);
					num = (int)(num2 * 965203739) ^ -449235102;
					continue;
				case 119u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox3), (Control)(object)UpdateStaffBtn);
					num = ((int)num2 * -1829117705) ^ 0x5F6CDA95;
					continue;
				case 118u:
					Form3.smethod_12((Control)(object)BloodAvailabilityBtn, new Point(20, 138));
					num = ((int)num2 * -527261846) ^ 0x733EA9EB;
					continue;
				case 117u:
					Form3.smethod_13((Control)(object)Panel1, "Panel1");
					num = ((int)num2 * -1716363535) ^ 0x650C8777;
					continue;
				case 116u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox3), (Control)(object)AddStaffBtn);
					num = (int)(num2 * 329742107) ^ -276084186;
					continue;
				case 115u:
					Form3.smethod_12((Control)(object)StaffPanel1, new Point(0, 37));
					num = (int)(num2 * 1683287591) ^ -833487140;
					continue;
				case 114u:
					Form3.smethod_12((Control)(object)GroupBox3, new Point(13, 161));
					num = ((int)num2 * -1806218138) ^ -70083509;
					continue;
				case 113u:
					num = (int)(num2 * 1206712105) ^ -2051690165;
					continue;
				case 112u:
					SearchRecieverBtn = Form3.smethod_5();
					num = (int)(num2 * 1951263350) ^ -1577110363;
					continue;
				case 111u:
					num = (int)((num2 * 1155027543) ^ 0x16440692);
					continue;
				case 110u:
					num = ((int)num2 * -1221682655) ^ -1949751361;
					continue;
				case 109u:
					Form3.smethod_21(GroupBox3, bool_0: false);
					num = (int)((num2 * 576108474) ^ 0x7B4E16A2);
					continue;
				case 108u:
					Form3.smethod_26((Control)(object)SearchDonorBtn, new Padding(0));
					num = (int)((num2 * 1811298815) ^ 0x2448DA74);
					continue;
				case 107u:
					num = (int)((num2 * 1387485148) ^ 0x76A645E9);
					continue;
				case 106u:
					Form3.smethod_24(Form3.smethod_23((ButtonBase)(object)EditProfileBtn), 0);
					num = (int)((num2 * 1999849916) ^ 0x6BEF2FDD);
					continue;
				case 105u:
					Label2 = Form3.smethod_7();
					num = ((int)num2 * -316786916) ^ -650101177;
					continue;
				case 104u:
					num = (int)((num2 * 710385604) ^ 0x41567BC4);
					continue;
				case 103u:
					Form3.smethod_12((Control)(object)PictureBox1, new Point(307, 12));
					num = (int)(num2 * 832203152) ^ -2109002070;
					continue;
				case 102u:
					Form3.smethod_49((Control)(object)this, bool_0: false);
					num = ((int)num2 * -1664156399) ^ 0x3125C2F3;
					continue;
				case 101u:
					num = ((int)num2 * -16955466) ^ 0x4A1949BA;
					continue;
				case 100u:
					Form3.smethod_20((Control)(object)EditProfileBtn, Form3.smethod_19("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Form3.smethod_12((Control)(object)EditProfileBtn, new Point(20, 52));
					Form3.smethod_26((Control)(object)EditProfileBtn, new Padding(0));
					num = (int)(num2 * 1705991872) ^ -86435218;
					continue;
				case 99u:
					Form3.smethod_10((Control)(object)this);
					num = ((int)num2 * -2070933303) ^ -77280524;
					continue;
				case 98u:
					Form3.smethod_13((Control)(object)PatientPanel2, "PatientPanel2");
					num = (int)((num2 * 1915493356) ^ 0x597A38C7);
					continue;
				case 97u:
					Form3.smethod_18(Form3.smethod_42((Control)(object)this), (Control)(object)AdminPanel);
					Form3.smethod_43((Form)(object)this, bool_0: false);
					Form3.smethod_44((Control)(object)this, "Form3");
					num = (int)(num2 * 946305044) ^ -1297226723;
					continue;
				case 96u:
					num = (int)((num2 * 2108894158) ^ 0x16510376);
					continue;
				case 95u:
					num = (int)((num2 * 375515165) ^ 0x392BCCF3);
					continue;
				case 94u:
					num = (int)((num2 * 2020107492) ^ 0x6E240987);
					continue;
				case 93u:
					num = (int)((num2 * 316711026) ^ 0x25999214);
					continue;
				case 92u:
					Form3.smethod_27((ButtonBase)(object)SearchPtntBtn, "Search Patient");
					num = (int)((num2 * 2139179217) ^ 0x660B3D74);
					continue;
				case 91u:
					num = (int)(num2 * 980426596) ^ -610572325;
					continue;
				case 90u:
					num = ((int)num2 * -1722011957) ^ -539042581;
					continue;
				case 89u:
					num = (int)((num2 * 1921132299) ^ 0x7C7FD41D);
					continue;
				case 88u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)Panel1), (Control)(object)GroupBox2);
					num = ((int)num2 * -597884204) ^ 0x3C244D1A;
					continue;
				case 87u:
					num = (int)((num2 * 539552131) ^ 0x331A6CCD);
					continue;
				case 86u:
					Form3.smethod_13((Control)(object)BloodBankPanel1, "BloodBankPanel1");
					num = ((int)num2 * -1533424925) ^ 0x15EB3D94;
					continue;
				case 85u:
					Form3.smethod_20((Control)(object)SearchDonorBtn, Form3.smethod_19("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 827282198) ^ 0x40CA5969);
					continue;
				case 84u:
					Form3.smethod_13((Control)(object)BloodBankPanel2, "BloodBankPanel2");
					num = ((int)num2 * -400670291) ^ -2133388404;
					continue;
				case 83u:
					Form3.smethod_14((Control)(object)LogoutBtn, new Size(316, 50));
					Form3.smethod_15((Control)(object)LogoutBtn, 6);
					num = ((int)num2 * -1238141666) ^ -1038293727;
					continue;
				case 82u:
					num = (int)(num2 * 1462975720) ^ -722201651;
					continue;
				case 81u:
					Form3.smethod_28((ButtonBase)(object)AddStaffBtn, bool_0: true);
					num = ((int)num2 * -1688829175) ^ -1373176633;
					continue;
				case 80u:
					Form3.smethod_14((Control)(object)PatientPanel1, new Size(44, 50));
					num = ((int)num2 * -555745032) ^ -1868860396;
					continue;
				case 78u:
					Form3.smethod_30(PictureBox1, (Image)(object)Resources.Hospital_blue_icon);
					num = (int)((num2 * 658349216) ^ 0x221B7EF4);
					continue;
				case 77u:
					Form3.smethod_26((Control)(object)SearchPtntBtn, new Padding(0));
					num = (int)(num2 * 383551465) ^ -636336215;
					continue;
				case 76u:
					BloodBankPanel2 = Form3.smethod_3();
					num = (int)(num2 * 221486223) ^ -936029675;
					continue;
				case 75u:
					Form3.smethod_13((Control)(object)GroupBox5, "GroupBox5");
					Form3.smethod_14((Control)(object)GroupBox5, new Size(355, 177));
					num = ((int)num2 * -217980733) ^ -211659966;
					continue;
				case 74u:
					Form3.smethod_14((Control)(object)SearchRecieverBtn, new Size(316, 50));
					Form3.smethod_15((Control)(object)SearchRecieverBtn, 6);
					num = ((int)num2 * -173205830) ^ 0x21B1B9B1;
					continue;
				case 73u:
					num = ((int)num2 * -1884902114) ^ -1767501116;
					continue;
				case 72u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)Panel1), (Control)(object)GroupBox3);
					num = ((int)num2 * -136900252) ^ 0x462A81F9;
					continue;
				case 71u:
					Form3.smethod_14((Control)(object)BloodAvailabilityBtn, new Size(316, 50));
					num = ((int)num2 * -1282848514) ^ -524023484;
					continue;
				case 70u:
					Form3.smethod_11((Control)(object)BloodBankPanel2, Color.Transparent);
					num = ((int)num2 * -1795480158) ^ -185549291;
					continue;
				case 69u:
					Form3.smethod_11((Control)(object)StaffPanel1, Color.Transparent);
					num = (int)(num2 * 1014439670) ^ -141079668;
					continue;
				case 68u:
					Form3.smethod_9((ISupportInitialize)PictureBox1);
					num = (int)((num2 * 2023394972) ^ 0x5C3FBAE4);
					continue;
				case 67u:
					num = (int)((num2 * 1743614621) ^ 0x318D61E7);
					continue;
				case 66u:
					Form3.smethod_26((Control)(object)AddStaffBtn, new Padding(0));
					num = (int)(num2 * 1312412705) ^ -1963505815;
					continue;
				case 65u:
					Form3.smethod_13((Control)(object)AdminPanel, "AdminPanel");
					Form3.smethod_14((Control)(object)AdminPanel, new Size(977, 804));
					num = ((int)num2 * -2001807080) ^ -1588720644;
					continue;
				case 64u:
					num = ((int)num2 * -203130122) ^ -1717667138;
					continue;
				case 63u:
					Form3.smethod_14((Control)(object)PictureBox1, new Size(106, 103));
					num = (int)((num2 * 1248928423) ^ 0x4792D7FE);
					continue;
				case 62u:
					num = (int)(num2 * 764212758) ^ -759317759;
					continue;
				case 61u:
					Form3.smethod_18(Form3.smethod_42((Control)(object)this), (Control)(object)PictureBox1);
					num = ((int)num2 * -1292152420) ^ -408870944;
					continue;
				case 60u:
					Form3.smethod_12((Control)(object)BloodBankPanel2, new Point(311, 38));
					num = ((int)num2 * -1979538507) ^ 0x5136368A;
					continue;
				case 59u:
					num = (int)(num2 * 155277265) ^ -1214636458;
					continue;
				case 58u:
					num = ((int)num2 * -86212380) ^ 0x5F8AD112;
					continue;
				case 57u:
					Form3.smethod_12((Control)(object)Panel1, new Point(126, 141));
					num = (int)((num2 * 1012380896) ^ 0x15E62400);
					continue;
				case 56u:
					Form3.smethod_20((Control)(object)GroupBox4, Form3.smethod_19("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1143050572) ^ -666208121;
					continue;
				case 55u:
					Form3.smethod_24(Form3.smethod_23((ButtonBase)(object)SearchRecieverBtn), 0);
					num = ((int)num2 * -84298938) ^ -2011444757;
					continue;
				case 54u:
					Form3.smethod_28((ButtonBase)(object)UpdateStaffBtn, bool_0: true);
					num = ((int)num2 * -2026969080) ^ -1750343108;
					continue;
				case 53u:
					Form3.smethod_18(Form3.smethod_42((Control)(object)this), (Control)(object)Panel1);
					num = ((int)num2 * -615969792) ^ 0x7FB624FD;
					continue;
				case 52u:
					Form3.smethod_28((ButtonBase)(object)SearchPtntBtn, bool_0: false);
					num = ((int)num2 * -1121003096) ^ -1200522173;
					continue;
				case 51u:
					Form3.smethod_14((Control)(object)SearchDonorBtn, new Size(316, 50));
					Form3.smethod_15((Control)(object)SearchDonorBtn, 5);
					num = (int)((num2 * 1357562208) ^ 0x3153A436);
					continue;
				case 50u:
					Form3.smethod_20((Control)(object)LogoutBtn, Form3.smethod_19("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1189954726) ^ 0x56A343D6;
					continue;
				case 49u:
					Form3.smethod_15((Control)(object)EditProfileBtn, 5);
					num = (int)(num2 * 515303973) ^ -661021621;
					continue;
				case 48u:
					num = (int)(num2 * 1380206775) ^ -1020511157;
					continue;
				case 47u:
					Form3.smethod_47((Control)(object)GroupBox2, bool_0: false);
					num = (int)(num2 * 569918124) ^ -12574351;
					continue;
				case 46u:
					Form3.smethod_8((Control)(object)GroupBox3);
					num = ((int)num2 * -674313278) ^ -837023253;
					continue;
				case 45u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox2), (Control)(object)PatientPanel1);
					num = ((int)num2 * -2056032136) ^ 0x42A3AB9D;
					continue;
				case 44u:
					num = (int)(num2 * 1699959715) ^ -193256709;
					continue;
				case 43u:
					num = ((int)num2 * -1135964544) ^ -1777486074;
					continue;
				case 42u:
					Form3.smethod_21(GroupBox4, bool_0: false);
					num = (int)(num2 * 1631428983) ^ -361492822;
					continue;
				case 41u:
					num = (int)((num2 * 870205641) ^ 0x64F235FC);
					continue;
				case 40u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox2), (Control)(object)PatientPanel2);
					num = ((int)num2 * -1695400607) ^ 0x13606A7B;
					continue;
				case 39u:
					Form3.smethod_13((Control)(object)EditProfileBtn, "EditProfileBtn");
					num = ((int)num2 * -1658913325) ^ 0x55F55CF2;
					continue;
				case 38u:
					Form3.smethod_28((ButtonBase)(object)BloodAvailabilityBtn, bool_0: true);
					num = ((int)num2 * -441135993) ^ 0x6EDEE59C;
					continue;
				case 37u:
					SearchDonorBtn = Form3.smethod_5();
					num = ((int)num2 * -1693040348) ^ 0x633FF5A4;
					continue;
				case 36u:
					num = ((int)num2 * -438272989) ^ 0x788D8838;
					continue;
				case 35u:
					Form3.smethod_14((Control)(object)StaffPanel2, new Size(44, 50));
					num = ((int)num2 * -1970842051) ^ 0x4FA6E2EE;
					continue;
				case 34u:
					Form3.smethod_28((ButtonBase)(object)LogoutBtn, bool_0: true);
					num = (int)(num2 * 424919179) ^ -139626022;
					continue;
				case 33u:
					Form3.smethod_13((Control)(object)PatientPanel1, "PatientPanel1");
					num = ((int)num2 * -872167425) ^ -1714272514;
					continue;
				case 32u:
					Form3.smethod_11((Control)(object)PatientPanel1, Color.Transparent);
					num = ((int)num2 * -1175805734) ^ -1210956015;
					continue;
				case 31u:
					num = (int)(num2 * 750762169) ^ -1920526720;
					continue;
				case 30u:
					Form3.smethod_47((Control)(object)GroupBox4, bool_0: false);
					num = ((int)num2 * -1606475703) ^ 0x2EBF8116;
					continue;
				case 29u:
					Form3.smethod_11((Control)(object)AdminPanel, Color.White);
					num = ((int)num2 * -13986496) ^ 0x37BB301A;
					continue;
				case 28u:
					Form3.smethod_22(GroupBox3, "Staff");
					Form3.smethod_24(Form3.smethod_23((ButtonBase)(object)UpdateStaffBtn), 0);
					num = (int)((num2 * 1855667548) ^ 0x10DB8894);
					continue;
				case 27u:
					Form3.smethod_8((Control)(object)GroupBox2);
					Form3.smethod_8((Control)(object)GroupBox4);
					num = (int)((num2 * 691817056) ^ 0x72C0814);
					continue;
				case 26u:
					Form3.smethod_13((Control)(object)BloodAvailabilityBtn, "BloodAvailabilityBtn");
					num = (int)(num2 * 3825350) ^ -1998871101;
					continue;
				case 25u:
					Form3.smethod_8((Control)(object)Panel1);
					num = ((int)num2 * -1697038843) ^ -205223038;
					continue;
				case 24u:
					num = (int)((num2 * 1066997178) ^ 0x21F71811);
					continue;
				case 23u:
					num = ((int)num2 * -241320591) ^ -1491573246;
					continue;
				case 22u:
					num = (int)((num2 * 1863894675) ^ 0x4D3A14A);
					continue;
				case 21u:
					Panel1 = Form3.smethod_3();
					num = ((int)num2 * -1451451048) ^ -774578517;
					continue;
				case 20u:
					Form3.smethod_15((Control)(object)Label2, 8);
					num = ((int)num2 * -1584738562) ^ -2000789074;
					continue;
				case 19u:
					Form3.smethod_14((Control)(object)Panel1, new Size(380, 804));
					num = ((int)num2 * -754519307) ^ -1954626558;
					continue;
				case 18u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox3), (Control)(object)StaffPanel1);
					Form3.smethod_20((Control)(object)GroupBox3, Form3.smethod_19("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -710375139) ^ -807569964;
					continue;
				case 17u:
					Form3.smethod_15((Control)(object)PatientPanel1, 0);
					num = ((int)num2 * -86376154) ^ 0x5066D58F;
					continue;
				case 16u:
					Form3.smethod_22(GroupBox5, "Personal Info");
					Form3.smethod_24(Form3.smethod_23((ButtonBase)(object)LogoutBtn), 0);
					num = ((int)num2 * -1735607513) ^ -683161428;
					continue;
				case 15u:
					num = (int)(num2 * 1098222834) ^ -1517205992;
					continue;
				case 14u:
					Form3.smethod_33(PictureBox1, bool_0: false);
					num = (int)(num2 * 1533862288) ^ -189425552;
					continue;
				case 13u:
					Form3.smethod_12((Control)(object)PatientPanel2, new Point(311, 43));
					num = (int)(num2 * 1472268466) ^ -1785347188;
					continue;
				case 12u:
					Form3.smethod_15((Control)(object)PersonalInfoPanel2, 16);
					Form3.smethod_11((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)((num2 * 1922966538) ^ 0x16080FA);
					continue;
				case 11u:
					Form3.smethod_20((Control)(object)GroupBox2, Form3.smethod_19("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1296934041) ^ 0x2552C305;
					continue;
				case 10u:
					LogoutBtn = Form3.smethod_5();
					num = (int)(num2 * 996734477) ^ -2047229868;
					continue;
				case 9u:
					Form3.smethod_20((Control)(object)UpdateStaffBtn, Form3.smethod_19("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1626881899) ^ 0x51983BEE);
					continue;
				case 8u:
					Form3.smethod_13((Control)(object)Label2, "Label2");
					num = (int)(num2 * 86069431) ^ -1793415025;
					continue;
				case 7u:
					Form3.smethod_12((Control)(object)GroupBox2, new Point(13, 20));
					num = (int)((num2 * 148148621) ^ 0x169D3B96);
					continue;
				case 6u:
					num = ((int)num2 * -1980757151) ^ 0x37D041A;
					continue;
				case 5u:
					Form3.smethod_15((Control)(object)PatientPanel2, 6);
					num = ((int)num2 * -779380609) ^ -2021449523;
					continue;
				case 4u:
					Form3.smethod_25((ButtonBase)(object)SearchRecieverBtn, (FlatStyle)0);
					num = (int)((num2 * 1468997832) ^ 0x6EA511C3);
					continue;
				case 3u:
					PersonalInfoPanel2 = Form3.smethod_3();
					num = ((int)num2 * -1281695133) ^ 0x6BDA8FF3;
					continue;
				case 2u:
					Form3.smethod_14((Control)(object)PatientPanel2, new Size(44, 50));
					num = (int)((num2 * 1421555633) ^ 0x4642D024);
					continue;
				case 1u:
					Form3.smethod_29((ButtonBase)(object)SearchPtntBtn, Color.White);
					num = ((int)num2 * -2130011813) ^ -1960485529;
					continue;
				case 0u:
					Form3.smethod_26((Control)(object)BloodAvailabilityBtn, new Padding(0));
					num = ((int)num2 * -119157620) ^ 0x43195537;
					continue;
				case 79u:
					break;
				default:
					Form3.smethod_50((Control)(object)this);
					return;
				}
				break;
			}
		}
	}

	private void AddStaffBtn_Click_1(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 798629616;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x518ACEAAu) % 17u)
				{
				case 16u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel1, Color.Transparent);
					Form3.smethod_11((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = (int)(num2 * 1939064156) ^ -1040814820;
					continue;
				case 15u:
					Form3.smethod_11((Control)(object)PatientPanel1, Color.Transparent);
					num = (int)((num2 * 410030393) ^ 0x3E3D2B45);
					continue;
				case 14u:
					Form3.smethod_11((Control)(object)StaffPanel2, Color.DarkBlue);
					num = ((int)num2 * -564295917) ^ 0x15509FB3;
					continue;
				case 13u:
					num = ((int)num2 * -89507102) ^ 0x75BD3D2F;
					continue;
				case 10u:
					Form3.smethod_55(Form3.smethod_17((Control)(object)AdminPanel));
					num = ((int)num2 * -1342583225) ^ 0x1E44706;
					continue;
				case 9u:
					num = ((int)num2 * -269920745) ^ -1894748013;
					continue;
				case 8u:
					num = ((int)num2 * -1892319725) ^ 0x358E00F9;
					continue;
				case 7u:
					Form3.smethod_11((Control)(object)BloodBankPanel2, Color.Transparent);
					num = ((int)num2 * -643800159) ^ 0x6CD655E8;
					continue;
				case 6u:
					Form3.smethod_54((Control)(object)StaffPanel2, Form3.smethod_53((Control)(object)AddStaffBtn));
					num = ((int)num2 * -559385693) ^ 0x4102217C;
					continue;
				case 5u:
					Form3.smethod_54((Control)(object)StaffPanel1, Form3.smethod_53((Control)(object)AddStaffBtn));
					num = ((int)num2 * -240750408) ^ 0xFB72760;
					continue;
				case 4u:
					Form3.smethod_11((Control)(object)BloodBankPanel1, Color.Transparent);
					num = ((int)num2 * -1545742952) ^ -1926278082;
					continue;
				case 3u:
					num = (int)((num2 * 1625478816) ^ 0x6344B281);
					continue;
				case 2u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)AdminPanel), (Control)(object)new AddStaff_Admin());
					num = ((int)num2 * -561907423) ^ 0x2D15EB75;
					continue;
				case 1u:
					Form3.smethod_11((Control)(object)PatientPanel2, Color.Transparent);
					num = ((int)num2 * -379688306) ^ -2066654631;
					continue;
				case 0u:
					Form3.smethod_11((Control)(object)StaffPanel1, Color.DarkBlue);
					num = (int)(num2 * 1112127172) ^ -94777961;
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

	private void UpdateStaffBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 104605037;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x36E3A9E0u) % 18u)
				{
				case 17u:
					Form3.smethod_11((Control)(object)BloodBankPanel1, Color.Transparent);
					num = ((int)num2 * -1440459517) ^ 0x7A496C33;
					continue;
				case 16u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)((num2 * 1505826307) ^ 0x1370FD4C);
					continue;
				case 15u:
					Form3.smethod_11((Control)(object)PatientPanel1, Color.Transparent);
					Form3.smethod_11((Control)(object)PatientPanel2, Color.Transparent);
					num = ((int)num2 * -884543252) ^ -790318689;
					continue;
				case 14u:
					Form3.smethod_11((Control)(object)StaffPanel1, Color.DarkBlue);
					num = ((int)num2 * -968785987) ^ -1971999295;
					continue;
				case 13u:
					Form3.smethod_55(Form3.smethod_17((Control)(object)AdminPanel));
					num = (int)((num2 * 735784393) ^ 0x4573056A);
					continue;
				case 11u:
					Form3.smethod_54((Control)(object)StaffPanel1, Form3.smethod_53((Control)(object)UpdateStaffBtn));
					Form3.smethod_54((Control)(object)StaffPanel2, Form3.smethod_53((Control)(object)UpdateStaffBtn));
					num = ((int)num2 * -1286369271) ^ 0x3F9F7857;
					continue;
				case 10u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)AdminPanel), (Control)(object)new UpdateStaff_Admin());
					num = ((int)num2 * -1300360758) ^ 0x3759ED2B;
					continue;
				case 9u:
					num = ((int)num2 * -876356727) ^ 0xB7F69C4;
					continue;
				case 8u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = (int)(num2 * 1418270106) ^ -710964151;
					continue;
				case 7u:
					num = (int)(num2 * 2092059735) ^ -922346281;
					continue;
				case 6u:
					num = ((int)num2 * -1616439218) ^ 0x40150A22;
					continue;
				case 5u:
					num = (int)((num2 * 23512350) ^ 0x653189C4);
					continue;
				case 4u:
					Form3.smethod_11((Control)(object)BloodBankPanel2, Color.Transparent);
					num = (int)(num2 * 19239303) ^ -1931941367;
					continue;
				case 3u:
					num = (int)(num2 * 486393949) ^ -1674286321;
					continue;
				case 2u:
					num = (int)((num2 * 183112123) ^ 0x75F0928A);
					continue;
				case 0u:
					Form3.smethod_11((Control)(object)StaffPanel2, Color.DarkBlue);
					num = ((int)num2 * -1887994127) ^ -2093427107;
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

	private void SearchDonorBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1076056296;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB2FA52BEu) % 19u)
				{
				case 18u:
					num = (int)((num2 * 2072120423) ^ 0x6CFCB966);
					continue;
				case 17u:
					Form3.smethod_55(Form3.smethod_17((Control)(object)AdminPanel));
					num = (int)((num2 * 1938245365) ^ 0x30C4F671);
					continue;
				case 15u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = ((int)num2 * -1802822180) ^ -1538064172;
					continue;
				case 14u:
					Form3.smethod_11((Control)(object)StaffPanel2, Color.Transparent);
					num = ((int)num2 * -1187649073) ^ 0x5DFDC57B;
					continue;
				case 12u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel2, Color.Transparent);
					Form3.smethod_54((Control)(object)BloodBankPanel1, Form3.smethod_53((Control)(object)SearchDonorBtn));
					num = (int)(num2 * 1241982664) ^ -1943495467;
					continue;
				case 11u:
					Form3.smethod_11((Control)(object)BloodBankPanel2, Color.DarkBlue);
					num = ((int)num2 * -1259854241) ^ -1136824105;
					continue;
				case 10u:
					Form3.smethod_11((Control)(object)BloodBankPanel1, Color.DarkBlue);
					num = (int)(num2 * 949094137) ^ -1144229546;
					continue;
				case 9u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)AdminPanel), (Control)(object)new SearchDonor_Admin());
					num = (int)(num2 * 792822099) ^ -1493115472;
					continue;
				case 8u:
					Form3.smethod_11((Control)(object)StaffPanel1, Color.Transparent);
					num = (int)(num2 * 1723830462) ^ -1224725689;
					continue;
				case 7u:
					Form3.smethod_11((Control)(object)PatientPanel1, Color.Transparent);
					num = (int)((num2 * 104848067) ^ 0x25510CC4);
					continue;
				case 6u:
					Form3.smethod_54((Control)(object)BloodBankPanel2, Form3.smethod_53((Control)(object)SearchDonorBtn));
					num = ((int)num2 * -245336043) ^ 0x626B5191;
					continue;
				case 5u:
					num = (int)(num2 * 1526940718) ^ -1677222155;
					continue;
				case 4u:
					Form3.smethod_11((Control)(object)PatientPanel2, Color.Transparent);
					num = ((int)num2 * -1746962617) ^ -730430547;
					continue;
				case 3u:
					num = (int)(num2 * 1612176611) ^ -930970696;
					continue;
				case 2u:
					num = (int)((num2 * 1481475424) ^ 0x304DAB67);
					continue;
				case 1u:
					num = (int)(num2 * 1317041517) ^ -1075046050;
					continue;
				case 0u:
					num = ((int)num2 * -1880278136) ^ 0x56E97B17;
					continue;
				default:
					return;
				case 16u:
					break;
				case 13u:
					return;
				}
				break;
			}
		}
	}

	private void SearchRecieverBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1022804047;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC22DF857u) % 17u)
				{
				case 16u:
					num = (int)(num2 * 420936745) ^ -1564986459;
					continue;
				case 15u:
					Form3.smethod_54((Control)(object)BloodBankPanel2, Form3.smethod_53((Control)(object)SearchRecieverBtn));
					Form3.smethod_11((Control)(object)BloodBankPanel1, Color.DarkBlue);
					num = ((int)num2 * -1595096855) ^ -1050585855;
					continue;
				case 13u:
					num = ((int)num2 * -1308274592) ^ -1664622618;
					continue;
				case 12u:
					num = ((int)num2 * -1049436239) ^ 0x426004C1;
					continue;
				case 11u:
					Form3.smethod_55(Form3.smethod_17((Control)(object)AdminPanel));
					num = (int)((num2 * 355336137) ^ 0x2373183F);
					continue;
				case 10u:
					num = (int)((num2 * 1076008349) ^ 0x104C4CB5);
					continue;
				case 9u:
					Form3.smethod_11((Control)(object)BloodBankPanel2, Color.DarkBlue);
					num = ((int)num2 * -273558900) ^ 0x15D38889;
					continue;
				case 8u:
					Form3.smethod_11((Control)(object)PatientPanel2, Color.Transparent);
					num = (int)((num2 * 1088537447) ^ 0x7AA7C378);
					continue;
				case 7u:
					Form3.smethod_11((Control)(object)PatientPanel1, Color.Transparent);
					num = (int)(num2 * 451682509) ^ -979759236;
					continue;
				case 6u:
					Form3.smethod_11((Control)(object)StaffPanel1, Color.Transparent);
					num = ((int)num2 * -766898556) ^ -1695486197;
					continue;
				case 5u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)AdminPanel), (Control)(object)new SearchReciever_Admin());
					num = (int)(num2 * 1029748591) ^ -161609164;
					continue;
				case 4u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel2, Color.Transparent);
					Form3.smethod_54((Control)(object)BloodBankPanel1, Form3.smethod_53((Control)(object)SearchRecieverBtn));
					num = (int)(num2 * 332278200) ^ -1671004475;
					continue;
				case 3u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = ((int)num2 * -1299934545) ^ -1371692669;
					continue;
				case 2u:
					Form3.smethod_11((Control)(object)StaffPanel2, Color.Transparent);
					num = (int)((num2 * 1864936833) ^ 0x8C17C81);
					continue;
				case 1u:
					num = (int)(num2 * 2089593314) ^ -2124230934;
					continue;
				default:
					return;
				case 14u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void BloodAvailabilityBtn_Click(object sender, EventArgs e)
	{
		Form3.smethod_11((Control)(object)PatientPanel1, Color.Transparent);
		while (true)
		{
			int num = 1754256209;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x49583088u) % 15u)
				{
				case 14u:
					Form3.smethod_11((Control)(object)StaffPanel2, Color.Transparent);
					num = (int)(num2 * 641820381) ^ -597797957;
					continue;
				case 13u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = (int)(num2 * 221797196) ^ -1568129113;
					continue;
				case 12u:
					Form3.smethod_55(Form3.smethod_17((Control)(object)AdminPanel));
					num = ((int)num2 * -1061035847) ^ -13782293;
					continue;
				case 11u:
					Form3.smethod_54((Control)(object)BloodBankPanel2, Form3.smethod_53((Control)(object)BloodAvailabilityBtn));
					num = (int)((num2 * 1597603459) ^ 0x14AD57F1);
					continue;
				case 10u:
					num = ((int)num2 * -206571781) ^ 0x35F7DAC8;
					continue;
				case 9u:
					num = ((int)num2 * -728821861) ^ 0x7CD141B2;
					continue;
				case 8u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)AdminPanel), (Control)(object)new BloodAvailability());
					num = ((int)num2 * -259011728) ^ -390757134;
					continue;
				case 7u:
					Form3.smethod_54((Control)(object)BloodBankPanel1, Form3.smethod_53((Control)(object)BloodAvailabilityBtn));
					num = ((int)num2 * -671062574) ^ -37905348;
					continue;
				case 4u:
					Form3.smethod_11((Control)(object)BloodBankPanel2, Color.DarkBlue);
					num = ((int)num2 * -1781487796) ^ 0x3347F7F5;
					continue;
				case 3u:
					num = (int)(num2 * 1380829785) ^ -272028674;
					continue;
				case 2u:
					Form3.smethod_11((Control)(object)PatientPanel2, Color.Transparent);
					Form3.smethod_11((Control)(object)StaffPanel1, Color.Transparent);
					num = (int)((num2 * 1581013007) ^ 0x655AB987);
					continue;
				case 1u:
					Form3.smethod_11((Control)(object)BloodBankPanel1, Color.DarkBlue);
					num = (int)((num2 * 777770036) ^ 0x687C9CFA);
					continue;
				case 0u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)(num2 * 602225812) ^ -645254188;
					continue;
				default:
					return;
				case 6u:
					break;
				case 5u:
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
			int num = -351271543;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x94B9C67Cu) % 13u)
				{
				case 12u:
					num = ((int)num2 * -1876373800) ^ 0x2BB7AC81;
					continue;
				case 10u:
					Form3.smethod_54((Control)(object)PersonalInfoPanel2, Form3.smethod_53((Control)(object)EditProfileBtn));
					Form3.smethod_11((Control)(object)PersonalInfoPanel1, Color.DarkBlue);
					num = (int)(num2 * 219183243) ^ -1767763093;
					continue;
				case 9u:
					num = (int)((num2 * 1050728294) ^ 0x619D0B0);
					continue;
				case 8u:
					Form3.smethod_11((Control)(object)PatientPanel1, Color.Transparent);
					Form3.smethod_11((Control)(object)PatientPanel2, Color.Transparent);
					Form3.smethod_11((Control)(object)BloodBankPanel1, Color.Transparent);
					Form3.smethod_11((Control)(object)BloodBankPanel2, Color.Transparent);
					num = (int)((num2 * 901963884) ^ 0x641580E9);
					continue;
				case 7u:
					Form3.smethod_11((Control)(object)StaffPanel2, Color.Transparent);
					num = (int)((num2 * 1880632961) ^ 0x239FBA9D);
					continue;
				case 6u:
					Form3.smethod_11((Control)(object)StaffPanel1, Color.Transparent);
					num = ((int)num2 * -1089647417) ^ -431246524;
					continue;
				case 5u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)AdminPanel), (Control)(object)new EditProfile());
					num = (int)((num2 * 807352001) ^ 0x1AC3B828);
					continue;
				case 4u:
					num = ((int)num2 * -1055403996) ^ 0x6B39455F;
					continue;
				case 2u:
					Form3.smethod_54((Control)(object)PersonalInfoPanel1, Form3.smethod_53((Control)(object)EditProfileBtn));
					num = (int)((num2 * 2010731928) ^ 0x1692C5EC);
					continue;
				case 1u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel2, Color.DarkBlue);
					Form3.smethod_55(Form3.smethod_17((Control)(object)AdminPanel));
					num = ((int)num2 * -320200920) ^ -124121443;
					continue;
				case 0u:
					num = (int)((num2 * 620639224) ^ 0x7718BE69);
					continue;
				default:
					return;
				case 11u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	private void LogoutBtn_Click(object sender, EventArgs e)
	{
		Form3.smethod_11((Control)(object)PatientPanel1, Color.Transparent);
		while (true)
		{
			int num = -1856931772;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF4044009u) % 19u)
				{
				case 18u:
					Form3.smethod_11((Control)(object)BloodBankPanel1, Color.Transparent);
					num = ((int)num2 * -154961290) ^ -1315088876;
					continue;
				case 17u:
					MyProject.Forms.Form1.login_type = "";
					Form3.smethod_56((Form)(object)this);
					num = ((int)num2 * -1603237955) ^ 0x43EB3FEC;
					continue;
				case 16u:
					Form3.smethod_11((Control)(object)StaffPanel1, Color.Transparent);
					num = ((int)num2 * -1689368144) ^ 0x3FFF177;
					continue;
				case 15u:
					Form3.smethod_54((Control)(object)PersonalInfoPanel2, Form3.smethod_53((Control)(object)LogoutBtn));
					num = ((int)num2 * -213595353) ^ -1742415452;
					continue;
				case 14u:
					Form3.smethod_57((Control)(object)MyProject.Forms.Form1);
					num = (int)(num2 * 1544823339) ^ -1753548258;
					continue;
				case 13u:
					Form3.smethod_54((Control)(object)PersonalInfoPanel1, Form3.smethod_53((Control)(object)LogoutBtn));
					num = ((int)num2 * -35569086) ^ -1631550186;
					continue;
				case 12u:
					Form3.smethod_11((Control)(object)BloodBankPanel2, Color.Transparent);
					num = ((int)num2 * -1319482763) ^ 0x244921F4;
					continue;
				case 10u:
					MyProject.Forms.Form1.username = "";
					num = (int)((num2 * 1637139920) ^ 0x4CD2831B);
					continue;
				case 9u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel2, Color.DarkBlue);
					num = ((int)num2 * -316466424) ^ -638798709;
					continue;
				case 8u:
					num = ((int)num2 * -408758812) ^ 0x35F37681;
					continue;
				case 7u:
					num = (int)(num2 * 1903746019) ^ -474883913;
					continue;
				case 5u:
					num = (int)((num2 * 1343213845) ^ 0x40C08F08);
					continue;
				case 4u:
					num = ((int)num2 * -1886194064) ^ 0x1BCC6F18;
					continue;
				case 3u:
					Form3.smethod_11((Control)(object)PatientPanel2, Color.Transparent);
					num = (int)(num2 * 966982594) ^ -1420375791;
					continue;
				case 2u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel1, Color.DarkBlue);
					num = ((int)num2 * -1904338818) ^ 0x32E12649;
					continue;
				case 1u:
					num = ((int)num2 * -1358087276) ^ -812482940;
					continue;
				case 0u:
					Form3.smethod_11((Control)(object)StaffPanel2, Color.Transparent);
					num = ((int)num2 * -175864880) ^ 0x6E2D59E6;
					continue;
				default:
					return;
				case 6u:
					break;
				case 11u:
					return;
				}
				break;
			}
		}
	}

	private void Form3_FormClosed(object sender, FormClosedEventArgs e)
	{
		while (true)
		{
			int num = 1958132470;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x66C823CFu) % 5u)
				{
				case 4u:
					MyProject.Forms.Form1.username = "";
					MyProject.Forms.Form1.login_type = "";
					num = ((int)num2 * -708868224) ^ -322106940;
					continue;
				case 2u:
					Form3.smethod_57((Control)(object)MyProject.Forms.Form1);
					num = (int)(num2 * 1707157676) ^ -1055235941;
					continue;
				case 1u:
					num = (int)((num2 * 983854602) ^ 0x64894BCA);
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

	private void SearchPtntBtn_Click(object sender, EventArgs e)
	{
		Form3.smethod_11((Control)(object)BloodBankPanel1, Color.Transparent);
		while (true)
		{
			int num = -1779168495;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE08EB17Au) % 17u)
				{
				case 15u:
					Form3.smethod_11((Control)(object)PatientPanel1, Color.DarkBlue);
					num = (int)(num2 * 177044863) ^ -625520564;
					continue;
				case 14u:
					num = ((int)num2 * -345034603) ^ 0x64377CA0;
					continue;
				case 13u:
					Form3.smethod_11((Control)(object)StaffPanel2, Color.Transparent);
					num = ((int)num2 * -1012661942) ^ 0x1F0B48B2;
					continue;
				case 12u:
					Form3.smethod_55(Form3.smethod_17((Control)(object)AdminPanel));
					num = (int)((num2 * 1751500267) ^ 0x68B90254);
					continue;
				case 11u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = ((int)num2 * -2111016173) ^ 0x4D72863E;
					continue;
				case 9u:
					num = (int)((num2 * 1303595872) ^ 0x52CFB33E);
					continue;
				case 8u:
					Form3.smethod_11((Control)(object)StaffPanel1, Color.Transparent);
					num = (int)(num2 * 1097352954) ^ -1360141136;
					continue;
				case 7u:
					Form3.smethod_11((Control)(object)PatientPanel2, Color.DarkBlue);
					num = (int)(num2 * 2046321279) ^ -2025083103;
					continue;
				case 6u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)AdminPanel), (Control)(object)new SearchPatient_Admin());
					num = ((int)num2 * -2134008459) ^ 0x5B7812F;
					continue;
				case 5u:
					Form3.smethod_11((Control)(object)BloodBankPanel2, Color.Transparent);
					num = (int)(num2 * 429977699) ^ -340739694;
					continue;
				case 4u:
					Form3.smethod_54((Control)(object)PatientPanel2, Form3.smethod_53((Control)(object)SearchPtntBtn));
					num = ((int)num2 * -531702955) ^ 0xC3585DE;
					continue;
				case 3u:
					num = ((int)num2 * -1745638197) ^ -1106996892;
					continue;
				case 2u:
					Form3.smethod_54((Control)(object)PatientPanel1, Form3.smethod_53((Control)(object)SearchPtntBtn));
					num = ((int)num2 * -1841325511) ^ 0x617985ED;
					continue;
				case 1u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = (int)(num2 * 969874073) ^ -1019808285;
					continue;
				case 0u:
					num = (int)((num2 * 1651934850) ^ 0x62F247B2);
					continue;
				default:
					return;
				case 16u:
					break;
				case 10u:
					return;
				}
				break;
			}
		}
	}

	private void Form3_Shown(object sender, EventArgs e)
	{
		Form3.smethod_58((Control)(object)this);
		while (true)
		{
			int num = 1782039782;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x25DD4D05u) % 3u)
				{
				case 2u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -100970253) ^ 0x22A66A12;
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

	static void smethod_2(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Panel smethod_3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Panel();
	}

	static GroupBox smethod_4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new GroupBox();
	}

	static Button smethod_5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static PictureBox smethod_6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PictureBox();
	}

	static Label smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static void smethod_8(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_9(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_10(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_11(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static void smethod_12(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_13(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_14(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_15(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_16(ScrollableControl scrollableControl_0, bool bool_0)
	{
		scrollableControl_0.set_AutoScroll(bool_0);
	}

	static ControlCollection smethod_17(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_18(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static Font smethod_19(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_20(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_21(GroupBox groupBox_0, bool bool_0)
	{
		groupBox_0.set_TabStop(bool_0);
	}

	static void smethod_22(GroupBox groupBox_0, string string_0)
	{
		groupBox_0.set_Text(string_0);
	}

	static FlatButtonAppearance smethod_23(ButtonBase buttonBase_0)
	{
		return buttonBase_0.get_FlatAppearance();
	}

	static void smethod_24(FlatButtonAppearance flatButtonAppearance_0, int int_0)
	{
		flatButtonAppearance_0.set_BorderSize(int_0);
	}

	static void smethod_25(ButtonBase buttonBase_0, FlatStyle flatStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		buttonBase_0.set_FlatStyle(flatStyle_0);
	}

	static void smethod_26(Control control_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Margin(padding_0);
	}

	static void smethod_27(ButtonBase buttonBase_0, string string_0)
	{
		buttonBase_0.set_Text(string_0);
	}

	static void smethod_28(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_29(ButtonBase buttonBase_0, Color color_0)
	{
		buttonBase_0.set_BackColor(color_0);
	}

	static void smethod_30(PictureBox pictureBox_0, Image image_0)
	{
		pictureBox_0.set_Image(image_0);
	}

	static void smethod_31(PictureBox pictureBox_0, PictureBoxSizeMode pictureBoxSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		pictureBox_0.set_SizeMode(pictureBoxSizeMode_0);
	}

	static void smethod_32(PictureBox pictureBox_0, int int_0)
	{
		pictureBox_0.set_TabIndex(int_0);
	}

	static void smethod_33(PictureBox pictureBox_0, bool bool_0)
	{
		pictureBox_0.set_TabStop(bool_0);
	}

	static void smethod_34(Label label_0, bool bool_0)
	{
		label_0.set_AutoSize(bool_0);
	}

	static void smethod_35(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
	}

	static void smethod_36(Label label_0, string string_0)
	{
		label_0.set_Text(string_0);
	}

	static void smethod_37(Label label_0, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_TextAlign(contentAlignment_0);
	}

	static void smethod_38(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_39(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_40(Form form_0, Color color_0)
	{
		form_0.set_BackColor(color_0);
	}

	static void smethod_41(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_42(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_43(Form form_0, bool bool_0)
	{
		form_0.set_MinimizeBox(bool_0);
	}

	static void smethod_44(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_45(Form form_0, string string_0)
	{
		form_0.set_Text(string_0);
	}

	static void smethod_46(Form form_0, FormWindowState formWindowState_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_WindowState(formWindowState_0);
	}

	static void smethod_47(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_48(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_49(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_50(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_51(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_52(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static int smethod_53(Control control_0)
	{
		return control_0.get_Top();
	}

	static void smethod_54(Control control_0, int int_0)
	{
		control_0.set_Top(int_0);
	}

	static void smethod_55(ControlCollection controlCollection_0)
	{
		controlCollection_0.Clear();
	}

	static void smethod_56(Form form_0)
	{
		form_0.Close();
	}

	static void smethod_57(Control control_0)
	{
		control_0.Show();
	}

	static void smethod_58(Control control_0)
	{
		control_0.Refresh();
	}
}
