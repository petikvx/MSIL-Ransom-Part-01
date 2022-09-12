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
				int num = -2095208930;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAD618B7Au) % 9u)
					{
					case 8u:
					{
						int num5;
						int num6;
						if (logoutBtn == null)
						{
							num5 = -2087598256;
							num6 = -2087598256;
						}
						else
						{
							num5 = -319784908;
							num6 = -319784908;
						}
						num = num5 ^ ((int)num2 * -878413813);
						continue;
					}
					case 7u:
						logoutBtn = _LogoutBtn;
						num = (int)(num2 * 1751454430) ^ -1880805103;
						continue;
					case 6u:
						logoutBtn = _LogoutBtn;
						num = (int)(num2 * 874636759) ^ -1867913899;
						continue;
					case 5u:
						Form3.smethod_51((Control)(object)logoutBtn, eventHandler_);
						num = ((int)num2 * -366446856) ^ 0x46080064;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (logoutBtn != null)
						{
							num3 = 554889259;
							num4 = 554889259;
						}
						else
						{
							num3 = 1048373906;
							num4 = 1048373906;
						}
						num = num3 ^ (int)(num2 * 892212682);
						continue;
					}
					case 1u:
						_LogoutBtn = value;
						num = -810831234;
						continue;
					case 0u:
						Form3.smethod_52((Control)(object)logoutBtn, eventHandler_);
						num = (int)(num2 * 254548565) ^ -330722742;
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
				int num = -988191869;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC3033808u) % 9u)
					{
					case 8u:
						Form3.smethod_51((Control)(object)editProfileBtn, eventHandler_);
						num = ((int)num2 * -889397695) ^ -1756770154;
						continue;
					case 7u:
						editProfileBtn = _EditProfileBtn;
						num = ((int)num2 * -1820538951) ^ -1181408374;
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (editProfileBtn == null)
						{
							num5 = -319019858;
							num6 = -319019858;
						}
						else
						{
							num5 = -1219285840;
							num6 = -1219285840;
						}
						num = num5 ^ (int)(num2 * 1855576650);
						continue;
					}
					case 4u:
						Form3.smethod_52((Control)(object)editProfileBtn, eventHandler_);
						num = ((int)num2 * -1668683265) ^ -780474461;
						continue;
					case 3u:
						editProfileBtn = _EditProfileBtn;
						num = (int)((num2 * 958904215) ^ 0x75CC0E88);
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (editProfileBtn == null)
						{
							num3 = 1044737338;
							num4 = 1044737338;
						}
						else
						{
							num3 = 1645219153;
							num4 = 1645219153;
						}
						num = num3 ^ (int)(num2 * 358334697);
						continue;
					}
					case 1u:
						_EditProfileBtn = value;
						num = -615685921;
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
				goto IL_0047;
			}
			goto IL_00a1;
			IL_00a1:
			_UpdateStaffBtn = value;
			int num = 792576569;
			goto IL_0078;
			IL_0078:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6F1C4D8Bu) % 6u)
				{
				case 4u:
				{
					updateStaffBtn = _UpdateStaffBtn;
					int num3;
					int num4;
					if (updateStaffBtn != null)
					{
						num3 = 866112559;
						num4 = 866112559;
					}
					else
					{
						num3 = 959877876;
						num4 = 959877876;
					}
					num = num3 ^ ((int)num2 * -1525256190);
					continue;
				}
				case 3u:
					break;
				case 2u:
					Form3.smethod_52((Control)(object)updateStaffBtn, eventHandler_);
					num = ((int)num2 * -328047390) ^ -274606064;
					continue;
				case 1u:
					Form3.smethod_51((Control)(object)updateStaffBtn, eventHandler_);
					num = ((int)num2 * -1200969016) ^ -652137957;
					continue;
				default:
					return;
				case 0u:
					goto IL_00a1;
				case 5u:
					return;
				}
				break;
			}
			goto IL_0047;
			IL_0047:
			num = 1089172598;
			goto IL_0078;
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
			if (addStaffBtn != null)
			{
				goto IL_0032;
			}
			goto IL_00a1;
			IL_00a1:
			_AddStaffBtn = value;
			int num = 1804759377;
			goto IL_0078;
			IL_0078:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x38F68ADFu) % 6u)
				{
				case 5u:
					Form3.smethod_52((Control)(object)addStaffBtn, eventHandler_);
					num = (int)(num2 * 731806075) ^ -2106376045;
					continue;
				case 4u:
					break;
				case 1u:
					Form3.smethod_51((Control)(object)addStaffBtn, eventHandler_);
					num = ((int)num2 * -887534306) ^ -259009509;
					continue;
				case 0u:
				{
					addStaffBtn = _AddStaffBtn;
					int num3;
					int num4;
					if (addStaffBtn != null)
					{
						num3 = 1746868316;
						num4 = 1746868316;
					}
					else
					{
						num3 = 1628174754;
						num4 = 1628174754;
					}
					num = num3 ^ (int)(num2 * 1114450152);
					continue;
				}
				default:
					return;
				case 2u:
					goto IL_00a1;
				case 3u:
					return;
				}
				break;
			}
			goto IL_0032;
			IL_0032:
			num = 190002714;
			goto IL_0078;
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
			Button searchPtntBtn = _SearchPtntBtn;
			if (searchPtntBtn != null)
			{
				goto IL_001a;
			}
			goto IL_009f;
			IL_009f:
			_SearchPtntBtn = value;
			int num = 190720423;
			goto IL_0076;
			IL_0076:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x207ECDAFu) % 6u)
				{
				case 5u:
					break;
				case 4u:
					Form3.smethod_52((Control)(object)searchPtntBtn, eventHandler_);
					num = (int)((num2 * 1872280210) ^ 0x6DE598BD);
					continue;
				case 2u:
				{
					searchPtntBtn = _SearchPtntBtn;
					int num3;
					int num4;
					if (searchPtntBtn != null)
					{
						num3 = -1595952377;
						num4 = -1595952377;
					}
					else
					{
						num3 = -1559706827;
						num4 = -1559706827;
					}
					num = num3 ^ ((int)num2 * -664971383);
					continue;
				}
				case 1u:
					Form3.smethod_51((Control)(object)searchPtntBtn, eventHandler_);
					num = ((int)num2 * -2070188080) ^ -1115821406;
					continue;
				default:
					return;
				case 3u:
					goto IL_009f;
				case 0u:
					return;
				}
				break;
			}
			goto IL_001a;
			IL_001a:
			num = 1376415976;
			goto IL_0076;
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
				int num = -655106964;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBA3F3055u) % 8u)
					{
					case 7u:
						Form3.smethod_51((Control)(object)bloodAvailabilityBtn, eventHandler_);
						num = (int)(num2 * 2095425633) ^ -338191992;
						continue;
					case 6u:
					{
						bloodAvailabilityBtn = _BloodAvailabilityBtn;
						int num5;
						int num6;
						if (bloodAvailabilityBtn == null)
						{
							num5 = 667127601;
							num6 = 667127601;
						}
						else
						{
							num5 = 1671385950;
							num6 = 1671385950;
						}
						num = num5 ^ ((int)num2 * -1354164200);
						continue;
					}
					case 3u:
						Form3.smethod_52((Control)(object)bloodAvailabilityBtn, eventHandler_);
						num = ((int)num2 * -1213612340) ^ -1414376219;
						continue;
					case 2u:
						_BloodAvailabilityBtn = value;
						num = -110310309;
						continue;
					case 1u:
						bloodAvailabilityBtn = _BloodAvailabilityBtn;
						num = ((int)num2 * -349381798) ^ 0x22624E4F;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (bloodAvailabilityBtn != null)
						{
							num3 = 1079320066;
							num4 = 1079320066;
						}
						else
						{
							num3 = 1277926015;
							num4 = 1277926015;
						}
						num = num3 ^ (int)(num2 * 1780306477);
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
				int num = -1232974304;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA06CBE25u) % 6u)
					{
					case 4u:
					{
						_SearchRecieverBtn = value;
						searchRecieverBtn = _SearchRecieverBtn;
						int num5;
						if (searchRecieverBtn == null)
						{
							num = -720179598;
							num5 = -720179598;
						}
						else
						{
							num = -1129765607;
							num5 = -1129765607;
						}
						continue;
					}
					case 2u:
						Form3.smethod_52((Control)(object)searchRecieverBtn, eventHandler_);
						num = ((int)num2 * -196010082) ^ 0x28ACFD7A;
						continue;
					case 1u:
					{
						searchRecieverBtn = _SearchRecieverBtn;
						int num3;
						int num4;
						if (searchRecieverBtn == null)
						{
							num3 = 1930896139;
							num4 = 1930896139;
						}
						else
						{
							num3 = 837709123;
							num4 = 837709123;
						}
						num = num3 ^ ((int)num2 * -861084554);
						continue;
					}
					case 0u:
						Form3.smethod_51((Control)(object)searchRecieverBtn, eventHandler_);
						num = (int)((num2 * 1523523433) ^ 0x13E5802D);
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
			Button searchDonorBtn = default(Button);
			while (true)
			{
				int num = -321170613;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x844B0612u) % 7u)
					{
					case 5u:
					{
						_SearchDonorBtn = value;
						searchDonorBtn = _SearchDonorBtn;
						int num5;
						if (searchDonorBtn == null)
						{
							num = -1405367942;
							num5 = -1405367942;
						}
						else
						{
							num = -381939802;
							num5 = -381939802;
						}
						continue;
					}
					case 3u:
						Form3.smethod_52((Control)(object)searchDonorBtn, eventHandler_);
						num = ((int)num2 * -1714467540) ^ -1495857270;
						continue;
					case 2u:
						searchDonorBtn = _SearchDonorBtn;
						num = (int)((num2 * 1799563462) ^ 0x2AC4B27B);
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (searchDonorBtn == null)
						{
							num3 = -526479227;
							num4 = -526479227;
						}
						else
						{
							num3 = -2146478010;
							num4 = -2146478010;
						}
						num = num3 ^ ((int)num2 * -1992933501);
						continue;
					}
					case 0u:
						Form3.smethod_51((Control)(object)searchDonorBtn, eventHandler_);
						num = (int)(num2 * 1357815069) ^ -607898275;
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
				int num = 1065667515;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xB7F7FE4u) % 7u)
					{
					case 6u:
						if (components != null)
						{
							num = 637093895;
							num3 = 637093895;
							continue;
						}
						goto IL_0012;
					case 5u:
						Form3.smethod_2((IDisposable)components);
						num = ((int)num2 * -1782741253) ^ 0x6682A164;
						continue;
					case 4u:
						if (disposing)
						{
							num = (int)(num2 * 649527048) ^ -2088438468;
							continue;
						}
						goto IL_0012;
					case 3u:
						num = (int)((num2 * 433687898) ^ 0x55509344);
						continue;
					case 1u:
						num = 156446304;
						continue;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
						IL_0012:
						num = 22176702;
						num3 = 22176702;
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
				IL_00eb:
				int num4 = 1514087394;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num4 ^ 0xB7F7FE4u) % 4u)
					{
					case 2u:
						((Form)this).Dispose(disposing);
						num4 = ((int)num2 * -2045433811) ^ 0x1EF97FBB;
						continue;
					case 1u:
						num4 = ((int)num2 * -172820037) ^ 0x654B51C8;
						continue;
					default:
						goto end_IL_00ca;
					case 0u:
						break;
					case 3u:
						goto end_IL_00ca;
					}
					goto IL_00eb;
					continue;
					end_IL_00ca:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1120: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_1911: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d18: Unknown result type (might be due to invalid IL or missing references)
		//IL_22ec: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = -437959816;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9A2C9FFFu) % 316u)
				{
				case 315u:
					num = ((int)num2 * -1587734210) ^ -416292682;
					continue;
				case 314u:
					SearchDonorBtn = Form3.smethod_5();
					num = ((int)num2 * -164423956) ^ 0x71B10370;
					continue;
				case 313u:
					Form3.smethod_12((Control)(object)GroupBox2, new Point(13, 20));
					num = (int)((num2 * 1105978439) ^ 0x37CF1F6E);
					continue;
				case 312u:
					Form3.smethod_20((Control)(object)LogoutBtn, Form3.smethod_19("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Form3.smethod_12((Control)(object)LogoutBtn, new Point(20, 102));
					num = ((int)num2 * -854831838) ^ -989164377;
					continue;
				case 311u:
					Form3.smethod_26((Control)(object)GroupBox2, new Padding(0));
					Form3.smethod_13((Control)(object)GroupBox2, "GroupBox2");
					num = (int)((num2 * 353875836) ^ 0x37D6E00);
					continue;
				case 310u:
					num = (int)((num2 * 1192492387) ^ 0x2A258491);
					continue;
				case 309u:
					PictureBox1 = Form3.smethod_6();
					num = ((int)num2 * -1234954526) ^ 0x124838F6;
					continue;
				case 308u:
					Form3.smethod_14((Control)(object)GroupBox5, new Size(355, 177));
					Form3.smethod_15((Control)(object)GroupBox5, 12);
					num = (int)(num2 * 376350732) ^ -921855250;
					continue;
				case 307u:
					Form3.smethod_18(Form3.smethod_42((Control)(object)this), (Control)(object)Panel1);
					num = ((int)num2 * -1345389004) ^ -770986877;
					continue;
				case 306u:
					num = (int)(num2 * 1143741576) ^ -243277470;
					continue;
				case 305u:
					Form3.smethod_20((Control)(object)GroupBox4, Form3.smethod_19("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 921524179) ^ -1107986842;
					continue;
				case 304u:
					Form3.smethod_8((Control)(object)Panel1);
					num = ((int)num2 * -569158487) ^ -386303665;
					continue;
				case 303u:
					Form3.smethod_13((Control)(object)Label2, "Label2");
					num = ((int)num2 * -1501674197) ^ -1952082365;
					continue;
				case 302u:
					Form3.smethod_12((Control)(object)SearchRecieverBtn, new Point(20, 88));
					num = ((int)num2 * -1886280182) ^ -1020298744;
					continue;
				case 301u:
					Form3.smethod_14((Control)(object)AddStaffBtn, new Size(316, 50));
					num = (int)(num2 * 1110975117) ^ -1633160298;
					continue;
				case 300u:
					Form3.smethod_15((Control)(object)AddStaffBtn, 4);
					num = ((int)num2 * -794050345) ^ -1468216044;
					continue;
				case 299u:
					num = (int)(num2 * 953286252) ^ -741141988;
					continue;
				case 298u:
					num = ((int)num2 * -597152438) ^ -1566032187;
					continue;
				case 297u:
					Form3.smethod_27((ButtonBase)(object)SearchRecieverBtn, "Search Reciever");
					num = ((int)num2 * -1562608186) ^ 0x7794F6E5;
					continue;
				case 296u:
					num = (int)((num2 * 1995794231) ^ 0x70188CDC);
					continue;
				case 295u:
					Form3.smethod_30(PictureBox1, (Image)(object)Resources.Hospital_blue_icon);
					num = (int)((num2 * 954788005) ^ 0x3C4FADF7);
					continue;
				case 293u:
					Form3.smethod_11((Control)(object)PatientPanel2, Color.Transparent);
					num = ((int)num2 * -1565121972) ^ 0x4B2C6EC6;
					continue;
				case 292u:
					Form3.smethod_18(Form3.smethod_42((Control)(object)this), (Control)(object)AdminPanel);
					Form3.smethod_43((Form)(object)this, bool_0: false);
					num = (int)(num2 * 1239350234) ^ -241439754;
					continue;
				case 291u:
					Form3.smethod_47((Control)(object)GroupBox5, bool_0: false);
					num = ((int)num2 * -912493770) ^ 0x5DE8747E;
					continue;
				case 290u:
					num = ((int)num2 * -482257849) ^ 0x563C429;
					continue;
				case 289u:
					num = ((int)num2 * -34478388) ^ -818933896;
					continue;
				case 288u:
					Form3.smethod_47((Control)(object)Panel1, bool_0: false);
					num = ((int)num2 * -734707109) ^ -1198726821;
					continue;
				case 287u:
					Form3.smethod_15((Control)(object)SearchPtntBtn, 1);
					num = (int)(num2 * 1381621568) ^ -784795428;
					continue;
				case 286u:
					num = (int)((num2 * 845908032) ^ 0x2EFEE625);
					continue;
				case 285u:
					num = ((int)num2 * -788198765) ^ -125951926;
					continue;
				case 284u:
					Form3.smethod_13((Control)(object)BloodBankPanel1, "BloodBankPanel1");
					num = (int)(num2 * 1660927811) ^ -1550093504;
					continue;
				case 283u:
					SearchRecieverBtn = Form3.smethod_5();
					num = (int)((num2 * 201964700) ^ 0xB27EC85);
					continue;
				case 282u:
					num = ((int)num2 * -1539480961) ^ -696292505;
					continue;
				case 281u:
					Form3.smethod_12((Control)(object)PatientPanel2, new Point(311, 43));
					Form3.smethod_13((Control)(object)PatientPanel2, "PatientPanel2");
					num = (int)(num2 * 239321093) ^ -1331486772;
					continue;
				case 280u:
					Form3.smethod_11((Control)(object)PatientPanel1, Color.Transparent);
					num = ((int)num2 * -1174406402) ^ -632948984;
					continue;
				case 279u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox2), (Control)(object)SearchPtntBtn);
					num = ((int)num2 * -262642882) ^ -1241977510;
					continue;
				case 278u:
					Form3.smethod_24(Form3.smethod_23((ButtonBase)(object)SearchRecieverBtn), 0);
					num = ((int)num2 * -605402591) ^ 0x6367314E;
					continue;
				case 277u:
					Form3.smethod_12((Control)(object)SearchPtntBtn, new Point(25, 43));
					num = ((int)num2 * -1447118286) ^ -1952938829;
					continue;
				case 276u:
					Form3.smethod_40((Form)(object)this, Color.MidnightBlue);
					num = (int)(num2 * 1250436371) ^ -1178983943;
					continue;
				case 275u:
					Form3.smethod_14((Control)(object)GroupBox4, new Size(355, 210));
					num = ((int)num2 * -1910589001) ^ 0x5A578C19;
					continue;
				case 274u:
					Form3.smethod_14((Control)(object)SearchPtntBtn, new Size(311, 50));
					num = (int)(num2 * 1912842093) ^ -405705826;
					continue;
				case 273u:
					Panel1 = Form3.smethod_3();
					GroupBox5 = Form3.smethod_4();
					num = ((int)num2 * -336543539) ^ 0xC071F27;
					continue;
				case 272u:
					Form3.smethod_28((ButtonBase)(object)SearchRecieverBtn, bool_0: true);
					num = ((int)num2 * -902600546) ^ -498483324;
					continue;
				case 271u:
					Form3.smethod_47((Control)(object)GroupBox3, bool_0: false);
					Form3.smethod_47((Control)(object)GroupBox2, bool_0: false);
					num = ((int)num2 * -927026611) ^ 0x2E4AB55B;
					continue;
				case 270u:
					Form3.smethod_13((Control)(object)SearchRecieverBtn, "SearchRecieverBtn");
					num = ((int)num2 * -1161822785) ^ -925617116;
					continue;
				case 269u:
					Form3.smethod_28((ButtonBase)(object)EditProfileBtn, bool_0: true);
					num = ((int)num2 * -507136998) ^ 0x1691309;
					continue;
				case 268u:
					Form3.smethod_13((Control)(object)GroupBox3, "GroupBox3");
					num = ((int)num2 * -994604149) ^ -126920010;
					continue;
				case 267u:
					GroupBox2 = Form3.smethod_4();
					num = ((int)num2 * -1758294360) ^ -313436408;
					continue;
				case 266u:
					Form3.smethod_18(Form3.smethod_42((Control)(object)this), (Control)(object)Label2);
					num = (int)(num2 * 214864081) ^ -363390578;
					continue;
				case 265u:
					Form3.smethod_15((Control)(object)BloodAvailabilityBtn, 7);
					num = ((int)num2 * -1360806259) ^ -757047773;
					continue;
				case 264u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox3), (Control)(object)StaffPanel1);
					num = (int)((num2 * 152874427) ^ 0x5D4ECAEA);
					continue;
				case 263u:
					Form3.smethod_12((Control)(object)Label2, new Point(428, 35));
					num = (int)((num2 * 2054535572) ^ 0x426FB0A0);
					continue;
				case 262u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = ((int)num2 * -1457350851) ^ 0x11294AF5;
					continue;
				case 261u:
					num = (int)((num2 * 1727332208) ^ 0x4395B46E);
					continue;
				case 260u:
					Form3.smethod_25((ButtonBase)(object)UpdateStaffBtn, (FlatStyle)0);
					Form3.smethod_20((Control)(object)UpdateStaffBtn, Form3.smethod_19("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -799206389) ^ -1225870161;
					continue;
				case 259u:
					num = ((int)num2 * -1353831296) ^ -1768764815;
					continue;
				case 258u:
					Form3.smethod_25((ButtonBase)(object)AddStaffBtn, (FlatStyle)0);
					num = (int)(num2 * 1889751002) ^ -254586584;
					continue;
				case 257u:
					Form3.smethod_12((Control)(object)PatientPanel1, new Point(6, 43));
					num = (int)((num2 * 1775529719) ^ 0x2AE7AD41);
					continue;
				case 256u:
					num = (int)((num2 * 1468215224) ^ 0x20ACE43F);
					continue;
				case 255u:
					Form3.smethod_12((Control)(object)PictureBox1, new Point(307, 12));
					num = ((int)num2 * -1325378735) ^ 0x1A64A73D;
					continue;
				case 254u:
					Form3.smethod_46((Form)(object)this, (FormWindowState)2);
					num = ((int)num2 * -2027113950) ^ -833532877;
					continue;
				case 253u:
					Form3.smethod_14((Control)(object)LogoutBtn, new Size(316, 50));
					num = ((int)num2 * -1120580572) ^ 0x4FCB5C86;
					continue;
				case 252u:
					Form3.smethod_25((ButtonBase)(object)SearchPtntBtn, (FlatStyle)0);
					num = (int)((num2 * 1750885989) ^ 0x32C680A3);
					continue;
				case 251u:
					Form3.smethod_20((Control)(object)Label2, Form3.smethod_19("Microsoft Sans Serif", 36f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -440919460) ^ 0x6B54EE81;
					continue;
				case 250u:
					Form3.smethod_15((Control)(object)GroupBox4, 11);
					num = ((int)num2 * -1179871125) ^ 0xA21801B;
					continue;
				case 249u:
					num = (int)((num2 * 1824871353) ^ 0x570BAB95);
					continue;
				case 248u:
					Form3.smethod_24(Form3.smethod_23((ButtonBase)(object)UpdateStaffBtn), 0);
					num = (int)(num2 * 1922768188) ^ -1324616779;
					continue;
				case 247u:
					Form3.smethod_14((Control)(object)PersonalInfoPanel1, new Size(44, 50));
					num = ((int)num2 * -1417646900) ^ 0x10FA3050;
					continue;
				case 246u:
					num = ((int)num2 * -2139453174) ^ 0x2EC0B9C7;
					continue;
				case 245u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox5), (Control)(object)PersonalInfoPanel1);
					num = ((int)num2 * -1739278476) ^ 0x16B1B31C;
					continue;
				case 244u:
					num = ((int)num2 * -1344295957) ^ 0x135633F4;
					continue;
				case 243u:
					Form3.smethod_8((Control)(object)GroupBox4);
					num = (int)(num2 * 870956852) ^ -766176609;
					continue;
				case 242u:
					Form3.smethod_13((Control)(object)StaffPanel1, "StaffPanel1");
					Form3.smethod_14((Control)(object)StaffPanel1, new Size(44, 50));
					Form3.smethod_15((Control)(object)StaffPanel1, 5);
					num = ((int)num2 * -1284644012) ^ -1322689148;
					continue;
				case 241u:
					Form3.smethod_16((ScrollableControl)(object)Panel1, bool_0: true);
					num = ((int)num2 * -729788716) ^ -638543835;
					continue;
				case 240u:
					num = ((int)num2 * -1320966535) ^ -1818197939;
					continue;
				case 239u:
					num = ((int)num2 * -920386824) ^ 0x399549B2;
					continue;
				case 238u:
					Form3.smethod_11((Control)(object)Panel1, Color.White);
					num = ((int)num2 * -1921926543) ^ -1710032830;
					continue;
				case 237u:
					Form3.smethod_12((Control)(object)PersonalInfoPanel2, new Point(311, 52));
					num = (int)(num2 * 1398036054) ^ -1824998128;
					continue;
				case 236u:
					Form3.smethod_12((Control)(object)PersonalInfoPanel1, new Point(0, 52));
					Form3.smethod_13((Control)(object)PersonalInfoPanel1, "PersonalInfoPanel1");
					num = ((int)num2 * -592434880) ^ 0x7B3C4CCC;
					continue;
				case 235u:
					Form3.smethod_24(Form3.smethod_23((ButtonBase)(object)SearchPtntBtn), 0);
					num = ((int)num2 * -1714570921) ^ -1442284498;
					continue;
				case 234u:
					Form3.smethod_33(PictureBox1, bool_0: false);
					Form3.smethod_34(Label2, bool_0: true);
					Form3.smethod_11((Control)(object)Label2, Color.Transparent);
					num = (int)(num2 * 1289427836) ^ -1498606719;
					continue;
				case 233u:
					num = (int)(num2 * 567438095) ^ -1549856747;
					continue;
				case 232u:
					Form3.smethod_12((Control)(object)StaffPanel2, new Point(311, 37));
					num = ((int)num2 * -1645924672) ^ -125938410;
					continue;
				case 231u:
					num = ((int)num2 * -1830083981) ^ 0x2CDD0941;
					continue;
				case 230u:
					num = ((int)num2 * -1971328572) ^ 0x330F840B;
					continue;
				case 229u:
					Form3.smethod_20((Control)(object)GroupBox3, Form3.smethod_19("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Form3.smethod_12((Control)(object)GroupBox3, new Point(13, 161));
					num = ((int)num2 * -1203407237) ^ 0x32B17AB8;
					continue;
				case 228u:
					num = ((int)num2 * -266655829) ^ -1355312235;
					continue;
				case 227u:
					num = ((int)num2 * -1181892315) ^ -1647693236;
					continue;
				case 226u:
					Form3.smethod_15((Control)(object)SearchDonorBtn, 5);
					Form3.smethod_27((ButtonBase)(object)SearchDonorBtn, "Search Donor");
					Form3.smethod_28((ButtonBase)(object)SearchDonorBtn, bool_0: true);
					num = ((int)num2 * -136726756) ^ -625913197;
					continue;
				case 225u:
					num = (int)(num2 * 830737039) ^ -900252117;
					continue;
				case 224u:
					Form3.smethod_14((Control)(object)BloodBankPanel1, new Size(44, 50));
					num = ((int)num2 * -738955442) ^ -620919252;
					continue;
				case 223u:
					num = (int)(num2 * 1913656497) ^ -1424512026;
					continue;
				case 222u:
					Form3.smethod_12((Control)(object)StaffPanel1, new Point(0, 37));
					num = (int)((num2 * 191159074) ^ 0x35E9AB96);
					continue;
				case 221u:
					num = (int)(num2 * 935637334) ^ -995498324;
					continue;
				case 220u:
					Form3.smethod_11((Control)(object)StaffPanel2, Color.Transparent);
					num = ((int)num2 * -125513507) ^ -129485797;
					continue;
				case 219u:
					Form3.smethod_13((Control)(object)PersonalInfoPanel2, "PersonalInfoPanel2");
					Form3.smethod_14((Control)(object)PersonalInfoPanel2, new Size(44, 50));
					num = (int)((num2 * 1182808864) ^ 0x5C04607D);
					continue;
				case 218u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox4), (Control)(object)BloodBankPanel1);
					num = (int)(num2 * 1428361414) ^ -44600950;
					continue;
				case 217u:
					num = (int)(num2 * 1979683653) ^ -1078166900;
					continue;
				case 216u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox3), (Control)(object)StaffPanel2);
					num = ((int)num2 * -2049761075) ^ 0x51686CB1;
					continue;
				case 215u:
					num = (int)(num2 * 2136531313) ^ -207830510;
					continue;
				case 214u:
					Form3.smethod_10((Control)(object)this);
					num = (int)(num2 * 160854829) ^ -670510176;
					continue;
				case 213u:
					Form3.smethod_24(Form3.smethod_23((ButtonBase)(object)EditProfileBtn), 0);
					num = (int)(num2 * 739599787) ^ -551166197;
					continue;
				case 212u:
					num = (int)(num2 * 1706713005) ^ -1553588079;
					continue;
				case 211u:
					Form3.smethod_27((ButtonBase)(object)AddStaffBtn, "Add Staff");
					num = (int)((num2 * 1802149594) ^ 0x493FF938);
					continue;
				case 210u:
					num = (int)((num2 * 105109982) ^ 0x36062F4C);
					continue;
				case 209u:
					num = ((int)num2 * -1829605782) ^ -822493874;
					continue;
				case 208u:
					Form3.smethod_26((Control)(object)LogoutBtn, new Padding(0));
					num = ((int)num2 * -1306826560) ^ -246752990;
					continue;
				case 207u:
					num = ((int)num2 * -1292121867) ^ 0x7E819797;
					continue;
				case 206u:
					Form3.smethod_27((ButtonBase)(object)LogoutBtn, "Logout");
					num = (int)(num2 * 1209687310) ^ -1532392613;
					continue;
				case 205u:
					Form3.smethod_13((Control)(object)SearchDonorBtn, "SearchDonorBtn");
					num = ((int)num2 * -554947527) ^ -1730502298;
					continue;
				case 204u:
					Form3.smethod_9((ISupportInitialize)PictureBox1);
					num = ((int)num2 * -1206211096) ^ -968248628;
					continue;
				case 203u:
					Form3.smethod_13((Control)(object)GroupBox5, "GroupBox5");
					num = ((int)num2 * -876316038) ^ 0x482A9CB9;
					continue;
				case 202u:
					Form3.smethod_15((Control)(object)PatientPanel1, 0);
					num = ((int)num2 * -1585105462) ^ -1492710777;
					continue;
				case 201u:
					Form3.smethod_15((Control)(object)LogoutBtn, 6);
					num = ((int)num2 * -1530138271) ^ -242223368;
					continue;
				case 200u:
					UpdateStaffBtn = Form3.smethod_5();
					num = ((int)num2 * -41088750) ^ -180374012;
					continue;
				case 199u:
					Form3.smethod_50((Control)(object)this);
					num = (int)((num2 * 191478134) ^ 0x1A2550E3);
					continue;
				case 198u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)Panel1), (Control)(object)GroupBox5);
					num = (int)((num2 * 1716619367) ^ 0x14604197);
					continue;
				case 197u:
					Form3.smethod_14((Control)(object)GroupBox3, new Size(355, 165));
					num = (int)((num2 * 1520631527) ^ 0x37166A63);
					continue;
				case 196u:
					Form3.smethod_11((Control)(object)GroupBox2, Color.White);
					num = (int)(num2 * 334923500) ^ -1203740710;
					continue;
				case 195u:
					Form3.smethod_15((Control)(object)Panel1, 7);
					num = ((int)num2 * -629288722) ^ 0x1D1D0FCD;
					continue;
				case 194u:
					PersonalInfoPanel2 = Form3.smethod_3();
					PersonalInfoPanel1 = Form3.smethod_3();
					num = ((int)num2 * -1939745346) ^ -1454104374;
					continue;
				case 193u:
					num = (int)(num2 * 258669744) ^ -1456159086;
					continue;
				case 192u:
					BloodAvailabilityBtn = Form3.smethod_5();
					num = (int)(num2 * 187616643) ^ -1022355609;
					continue;
				case 191u:
					Form3.smethod_45((Form)(object)this, "Form3");
					num = (int)(num2 * 667484566) ^ -293758541;
					continue;
				case 190u:
					num = ((int)num2 * -1616172318) ^ -321128745;
					continue;
				case 189u:
					num = (int)((num2 * 1827635375) ^ 0x2E30D0A6);
					continue;
				case 188u:
					Form3.smethod_14((Control)(object)BloodBankPanel2, new Size(44, 50));
					num = (int)(num2 * 1550057713) ^ -1758997030;
					continue;
				case 187u:
					num = ((int)num2 * -1179999919) ^ 0x76A75A3;
					continue;
				case 186u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox3), (Control)(object)AddStaffBtn);
					num = ((int)num2 * -819643506) ^ 0x43DB85D3;
					continue;
				case 185u:
					Form3.smethod_13((Control)(object)PatientPanel1, "PatientPanel1");
					Form3.smethod_14((Control)(object)PatientPanel1, new Size(44, 50));
					num = (int)(num2 * 1247869159) ^ -404051844;
					continue;
				case 184u:
					Form3.smethod_20((Control)(object)SearchRecieverBtn, Form3.smethod_19("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -900044660) ^ 0x4CA85F62;
					continue;
				case 183u:
					num = (int)(num2 * 225724372) ^ -1735989212;
					continue;
				case 182u:
					Form3.smethod_14((Control)(object)SearchDonorBtn, new Size(316, 50));
					num = ((int)num2 * -1618386939) ^ -572187104;
					continue;
				case 181u:
					num = (int)(num2 * 54891155) ^ -1082858240;
					continue;
				case 180u:
					Form3.smethod_25((ButtonBase)(object)BloodAvailabilityBtn, (FlatStyle)0);
					num = ((int)num2 * -1961665782) ^ 0x6497EDCB;
					continue;
				case 179u:
					Form3.smethod_15((Control)(object)AdminPanel, 5);
					num = (int)((num2 * 1593120569) ^ 0xE43DDC9);
					continue;
				case 178u:
					Form3.smethod_26((Control)(object)AddStaffBtn, new Padding(0));
					num = ((int)num2 * -497841757) ^ -597925622;
					continue;
				case 177u:
					num = ((int)num2 * -1942226541) ^ 0x79AE2D0D;
					continue;
				case 176u:
					Form3.smethod_13((Control)(object)AdminPanel, "AdminPanel");
					num = (int)((num2 * 1017261834) ^ 0x745A0C7C);
					continue;
				case 175u:
					Form3.smethod_32(PictureBox1, 9);
					num = ((int)num2 * -2130774237) ^ -726213773;
					continue;
				case 174u:
					num = (int)(num2 * 1891366234) ^ -964126694;
					continue;
				case 173u:
					num = (int)(num2 * 53869646) ^ -1642935792;
					continue;
				case 172u:
					num = (int)((num2 * 582947371) ^ 0x3EEE93DE);
					continue;
				case 171u:
					SearchPtntBtn = Form3.smethod_5();
					PatientPanel2 = Form3.smethod_3();
					num = ((int)num2 * -513856064) ^ -1945239767;
					continue;
				case 170u:
					num = ((int)num2 * -1888060044) ^ -1162932548;
					continue;
				case 169u:
					Form3.smethod_11((Control)(object)BloodBankPanel1, Color.Transparent);
					num = (int)((num2 * 1774830684) ^ 0x3858D403);
					continue;
				case 168u:
					Form3.smethod_12((Control)(object)AdminPanel, new Point(716, 141));
					num = (int)(num2 * 1429713617) ^ -1456859257;
					continue;
				case 167u:
					Form3.smethod_20((Control)(object)GroupBox5, Form3.smethod_19("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -936991571) ^ -1261912150;
					continue;
				case 166u:
					Form3.smethod_13((Control)(object)GroupBox4, "GroupBox4");
					num = (int)((num2 * 368938430) ^ 0x36C1C4C3);
					continue;
				case 165u:
					Form3.smethod_12((Control)(object)EditProfileBtn, new Point(20, 52));
					Form3.smethod_26((Control)(object)EditProfileBtn, new Padding(0));
					Form3.smethod_13((Control)(object)EditProfileBtn, "EditProfileBtn");
					num = ((int)num2 * -1817563474) ^ -932563602;
					continue;
				case 164u:
					num = ((int)num2 * -1996893683) ^ -925612635;
					continue;
				case 163u:
					Form3.smethod_8((Control)(object)GroupBox3);
					num = (int)((num2 * 922565595) ^ 0x457EF09);
					continue;
				case 162u:
					num = (int)(num2 * 1468390961) ^ -1908686648;
					continue;
				case 161u:
					num = ((int)num2 * -669852820) ^ 0xE1DA38B;
					continue;
				case 160u:
					Form3.smethod_14((Control)(object)Label2, new Size(845, 69));
					num = ((int)num2 * -1105759878) ^ -1721027467;
					continue;
				case 159u:
					Form3.smethod_27((ButtonBase)(object)BloodAvailabilityBtn, "Blood Availability");
					num = ((int)num2 * -1231327057) ^ -718900693;
					continue;
				case 158u:
					num = ((int)num2 * -2023812422) ^ 0x45CD02A7;
					continue;
				case 157u:
					Form3.smethod_14((Control)(object)EditProfileBtn, new Size(316, 50));
					num = ((int)num2 * -1413392418) ^ -1882399739;
					continue;
				case 156u:
					num = ((int)num2 * -2035052396) ^ -126419522;
					continue;
				case 155u:
					num = ((int)num2 * -1915689847) ^ 0x60D979D0;
					continue;
				case 154u:
					num = ((int)num2 * -341825319) ^ -526414089;
					continue;
				case 153u:
					Form3.smethod_13((Control)(object)StaffPanel2, "StaffPanel2");
					num = (int)(num2 * 409277541) ^ -1933497216;
					continue;
				case 152u:
					Form3.smethod_24(Form3.smethod_23((ButtonBase)(object)BloodAvailabilityBtn), 0);
					num = ((int)num2 * -374541989) ^ 0x52DB2D5D;
					continue;
				case 151u:
					Form3.smethod_25((ButtonBase)(object)SearchRecieverBtn, (FlatStyle)0);
					num = ((int)num2 * -534460739) ^ 0x718DF0FC;
					continue;
				case 150u:
					Form3.smethod_11((Control)(object)StaffPanel1, Color.Transparent);
					num = (int)(num2 * 617265328) ^ -1993879414;
					continue;
				case 149u:
					Form3.smethod_15((Control)(object)PersonalInfoPanel2, 16);
					num = ((int)num2 * -969950887) ^ 0x70FD1834;
					continue;
				case 148u:
					Form3.smethod_15((Control)(object)SearchRecieverBtn, 6);
					num = ((int)num2 * -309209607) ^ 0x1B5957E9;
					continue;
				case 147u:
					num = ((int)num2 * -1168141101) ^ -346642000;
					continue;
				case 146u:
					PatientPanel1 = Form3.smethod_3();
					num = (int)((num2 * 63322920) ^ 0x2C39D765);
					continue;
				case 145u:
					num = (int)(num2 * 1592609997) ^ -1276499797;
					continue;
				case 144u:
					num = ((int)num2 * -1608000560) ^ -1500994569;
					continue;
				case 143u:
					Form3.smethod_48((ISupportInitialize)PictureBox1);
					num = (int)((num2 * 107475732) ^ 0x2CF87953);
					continue;
				case 142u:
					num = ((int)num2 * -840783398) ^ -292853518;
					continue;
				case 141u:
					Form3.smethod_27((ButtonBase)(object)UpdateStaffBtn, "Update Staff");
					Form3.smethod_28((ButtonBase)(object)UpdateStaffBtn, bool_0: true);
					num = (int)(num2 * 1390184300) ^ -569240666;
					continue;
				case 140u:
					Form3.smethod_41((Form)(object)this, new Size(1262, 953));
					num = ((int)num2 * -1355213667) ^ 0x368C348E;
					continue;
				case 139u:
					Form3.smethod_22(GroupBox4, "Blood Bank");
					num = ((int)num2 * -342474103) ^ -802186784;
					continue;
				case 138u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox4), (Control)(object)BloodBankPanel2);
					num = ((int)num2 * -1864568320) ^ 0x7B49C4A7;
					continue;
				case 137u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox5), (Control)(object)EditProfileBtn);
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox5), (Control)(object)PersonalInfoPanel2);
					num = ((int)num2 * -854008798) ^ 0x1D5A57F4;
					continue;
				case 136u:
					Form3.smethod_20((Control)(object)SearchPtntBtn, Form3.smethod_19("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1162108714) ^ 0x33DA56DE);
					continue;
				case 135u:
					num = ((int)num2 * -999350091) ^ 0x6E5FD8EB;
					continue;
				case 134u:
					Form3.smethod_12((Control)(object)BloodAvailabilityBtn, new Point(20, 138));
					num = (int)(num2 * 1222910483) ^ -2063957792;
					continue;
				case 133u:
					num = ((int)num2 * -1511414684) ^ 0x671EEE2B;
					continue;
				case 132u:
					num = (int)(num2 * 720978274) ^ -1294253264;
					continue;
				case 131u:
					Form3.smethod_25((ButtonBase)(object)EditProfileBtn, (FlatStyle)0);
					num = (int)(num2 * 1522723165) ^ -576102209;
					continue;
				case 130u:
					num = ((int)num2 * -126527859) ^ 0x328A83AF;
					continue;
				case 129u:
					Form3.smethod_44((Control)(object)this, "Form3");
					num = ((int)num2 * -766158104) ^ 0x6560F52C;
					continue;
				case 128u:
					Form3.smethod_11((Control)(object)BloodBankPanel2, Color.Transparent);
					num = (int)(num2 * 368596956) ^ -218706451;
					continue;
				case 127u:
					AdminPanel = Form3.smethod_3();
					num = (int)((num2 * 1081145865) ^ 0x3E85BD9);
					continue;
				case 126u:
					num = (int)((num2 * 863438398) ^ 0x5251E3AF);
					continue;
				case 125u:
					num = (int)((num2 * 1528481627) ^ 0x78A78C9A);
					continue;
				case 124u:
					num = (int)(num2 * 322258687) ^ -24065988;
					continue;
				case 123u:
					Form3.smethod_15((Control)(object)BloodBankPanel1, 14);
					num = ((int)num2 * -1702071918) ^ 0x1787236E;
					continue;
				case 122u:
					BloodBankPanel2 = Form3.smethod_3();
					num = ((int)num2 * -330456182) ^ 0x2FCED736;
					continue;
				case 121u:
					Form3.smethod_14((Control)(object)GroupBox2, new Size(355, 114));
					num = (int)((num2 * 1474289615) ^ 0x21622991);
					continue;
				case 120u:
					Form3.smethod_12((Control)(object)UpdateStaffBtn, new Point(20, 90));
					num = (int)(num2 * 1185717828) ^ -195757757;
					continue;
				case 119u:
					num = (int)((num2 * 1027637660) ^ 0x47DA8366);
					continue;
				case 118u:
					Form3.smethod_12((Control)(object)GroupBox5, new Point(13, 578));
					num = (int)((num2 * 220533755) ^ 0x1B10EBD8);
					continue;
				case 117u:
					num = ((int)num2 * -343530455) ^ -774784878;
					continue;
				case 116u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox4), (Control)(object)BloodAvailabilityBtn);
					num = (int)(num2 * 15389134) ^ -1762800091;
					continue;
				case 115u:
					Form3.smethod_24(Form3.smethod_23((ButtonBase)(object)SearchDonorBtn), 0);
					num = ((int)num2 * -2058521687) ^ -1944962059;
					continue;
				case 114u:
					Form3.smethod_15((Control)(object)Label2, 8);
					Form3.smethod_36(Label2, "Golisano's Hospital Of Florida");
					Form3.smethod_37(Label2, (ContentAlignment)32);
					num = ((int)num2 * -1588015895) ^ 0x365B958F;
					continue;
				case 113u:
					Form3.smethod_26((Control)(object)GroupBox4, new Padding(0));
					num = (int)((num2 * 378293078) ^ 0x769DB03B);
					continue;
				case 112u:
					num = ((int)num2 * -1289080515) ^ 0x54B7A3F1;
					continue;
				case 111u:
					num = (int)((num2 * 1872513456) ^ 0x773633E4);
					continue;
				case 110u:
					Form3.smethod_26((Control)(object)SearchPtntBtn, new Padding(0));
					num = ((int)num2 * -1185884222) ^ -1157389766;
					continue;
				case 109u:
					Form3.smethod_14((Control)(object)PictureBox1, new Size(106, 103));
					num = ((int)num2 * -1495798395) ^ 0x1A1B77CE;
					continue;
				case 108u:
					Form3.smethod_29((ButtonBase)(object)SearchPtntBtn, Color.White);
					num = ((int)num2 * -1080916462) ^ -1112544360;
					continue;
				case 107u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)Panel1), (Control)(object)GroupBox3);
					num = ((int)num2 * -2021049508) ^ -1820415867;
					continue;
				case 106u:
					Form3.smethod_26((Control)(object)BloodAvailabilityBtn, new Padding(0));
					num = (int)((num2 * 1825430696) ^ 0x3F737AC2);
					continue;
				case 105u:
					Form3.smethod_13((Control)(object)UpdateStaffBtn, "UpdateStaffBtn");
					Form3.smethod_14((Control)(object)UpdateStaffBtn, new Size(316, 50));
					num = ((int)num2 * -370379435) ^ 0x5AF968D0;
					continue;
				case 104u:
					Form3.smethod_8((Control)(object)GroupBox5);
					num = ((int)num2 * -859916872) ^ -1465927056;
					continue;
				case 103u:
					Form3.smethod_14((Control)(object)AdminPanel, new Size(977, 804));
					num = ((int)num2 * -531169238) ^ -623906515;
					continue;
				case 102u:
					num = ((int)num2 * -1950681409) ^ 0x6E7E94F7;
					continue;
				case 101u:
					num = ((int)num2 * -1292412358) ^ -468409511;
					continue;
				case 100u:
					Form3.smethod_13((Control)(object)SearchPtntBtn, "SearchPtntBtn");
					num = ((int)num2 * -389059300) ^ -856827715;
					continue;
				case 99u:
					Form3.smethod_20((Control)(object)AddStaffBtn, Form3.smethod_19("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1670208271) ^ -1069556607;
					continue;
				case 98u:
					num = ((int)num2 * -402957342) ^ 0x5F85CA7D;
					continue;
				case 97u:
					BloodBankPanel1 = Form3.smethod_3();
					num = ((int)num2 * -816462026) ^ 0x6E2856CC;
					continue;
				case 96u:
					Form3.smethod_15((Control)(object)EditProfileBtn, 5);
					Form3.smethod_27((ButtonBase)(object)EditProfileBtn, "Edit Profile");
					num = ((int)num2 * -212372884) ^ 0x269FFA56;
					continue;
				case 95u:
					StaffPanel1 = Form3.smethod_3();
					num = (int)(num2 * 756539346) ^ -49873245;
					continue;
				case 94u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox4), (Control)(object)SearchRecieverBtn);
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox4), (Control)(object)SearchDonorBtn);
					num = ((int)num2 * -895880573) ^ 0xE267777;
					continue;
				case 93u:
					num = (int)((num2 * 1477984791) ^ 0x3E44F50C);
					continue;
				case 92u:
					num = ((int)num2 * -1379364983) ^ -1245947225;
					continue;
				case 91u:
					Form3.smethod_13((Control)(object)AddStaffBtn, "AddStaffBtn");
					num = (int)(num2 * 736881626) ^ -528163207;
					continue;
				case 90u:
					num = ((int)num2 * -1893770006) ^ 0x45EC555;
					continue;
				case 89u:
					Form3.smethod_12((Control)(object)BloodBankPanel2, new Point(311, 38));
					num = ((int)num2 * -1946788256) ^ -1424868897;
					continue;
				case 88u:
					Form3.smethod_26((Control)(object)UpdateStaffBtn, new Padding(0));
					num = (int)(num2 * 123772271) ^ -403899809;
					continue;
				case 87u:
					num = ((int)num2 * -1702870011) ^ -1632276915;
					continue;
				case 86u:
					Form3.smethod_12((Control)(object)GroupBox4, new Point(13, 344));
					num = (int)(num2 * 521407740) ^ -1812792946;
					continue;
				case 85u:
					Form3.smethod_28((ButtonBase)(object)SearchPtntBtn, bool_0: false);
					num = ((int)num2 * -1108607296) ^ 0x52E3A4BA;
					continue;
				case 84u:
					num = (int)((num2 * 898306396) ^ 0x6CDFB363);
					continue;
				case 83u:
					Label2 = Form3.smethod_7();
					num = (int)((num2 * 1731116383) ^ 0x4599EB2);
					continue;
				case 82u:
					num = ((int)num2 * -987143214) ^ 0x378E1B98;
					continue;
				case 81u:
					LogoutBtn = Form3.smethod_5();
					EditProfileBtn = Form3.smethod_5();
					num = ((int)num2 * -1762080057) ^ -295577418;
					continue;
				case 80u:
					Form3.smethod_13((Control)(object)Panel1, "Panel1");
					Form3.smethod_14((Control)(object)Panel1, new Size(380, 804));
					num = (int)(num2 * 954769507) ^ -828853898;
					continue;
				case 79u:
					Form3.smethod_26((Control)(object)SearchRecieverBtn, new Padding(0));
					num = (int)((num2 * 1718323691) ^ 0x6ABD99B4);
					continue;
				case 78u:
					Form3.smethod_38((ContainerControl)(object)this, new SizeF(8f, 16f));
					num = ((int)num2 * -1239165359) ^ -96800990;
					continue;
				case 77u:
					Form3.smethod_14((Control)(object)SearchRecieverBtn, new Size(316, 50));
					num = ((int)num2 * -530989518) ^ -980708427;
					continue;
				case 76u:
					num = ((int)num2 * -1619770750) ^ -192809226;
					continue;
				case 75u:
					num = ((int)num2 * -168280884) ^ 0x53C5374C;
					continue;
				case 74u:
					num = ((int)num2 * -311614704) ^ 0x36A80331;
					continue;
				case 73u:
					Form3.smethod_11((Control)(object)AdminPanel, Color.White);
					num = (int)(num2 * 1491452295) ^ -1515503538;
					continue;
				case 72u:
					Form3.smethod_15((Control)(object)BloodBankPanel2, 15);
					num = (int)(num2 * 1132691821) ^ -909244571;
					continue;
				case 71u:
					Form3.smethod_15((Control)(object)PersonalInfoPanel1, 15);
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox3), (Control)(object)UpdateStaffBtn);
					num = (int)((num2 * 301066959) ^ 0x444BC0D9);
					continue;
				case 70u:
					Form3.smethod_14((Control)(object)StaffPanel2, new Size(44, 50));
					Form3.smethod_15((Control)(object)StaffPanel2, 6);
					num = (int)(num2 * 1801066791) ^ -880191113;
					continue;
				case 69u:
					num = ((int)num2 * -1334777358) ^ 0x152CA537;
					continue;
				case 68u:
					Form3.smethod_49((Control)(object)this, bool_0: false);
					num = (int)(num2 * 1743421097) ^ -1369306360;
					continue;
				case 67u:
					num = ((int)num2 * -568113311) ^ -1130801156;
					continue;
				case 66u:
					Form3.smethod_21(GroupBox2, bool_0: false);
					num = ((int)num2 * -559947216) ^ -1590859221;
					continue;
				case 65u:
					num = ((int)num2 * -51722133) ^ -1637918793;
					continue;
				case 64u:
					num = (int)(num2 * 146191685) ^ -1854269624;
					continue;
				case 63u:
					Form3.smethod_15((Control)(object)GroupBox3, 10);
					num = (int)(num2 * 1008782348) ^ -1075575336;
					continue;
				case 62u:
					Form3.smethod_25((ButtonBase)(object)LogoutBtn, (FlatStyle)0);
					num = (int)(num2 * 1168344066) ^ -704248617;
					continue;
				case 61u:
					Form3.smethod_18(Form3.smethod_42((Control)(object)this), (Control)(object)PictureBox1);
					num = ((int)num2 * -814137456) ^ 0x74775C51;
					continue;
				case 60u:
					num = ((int)num2 * -846887211) ^ 0x3467621E;
					continue;
				case 59u:
					AddStaffBtn = Form3.smethod_5();
					num = (int)((num2 * 62117806) ^ 0x554CC699);
					continue;
				case 57u:
					num = ((int)num2 * -564580983) ^ -648496540;
					continue;
				case 56u:
					Form3.smethod_31(PictureBox1, (PictureBoxSizeMode)1);
					num = (int)(num2 * 452724632) ^ -1701635432;
					continue;
				case 55u:
					num = (int)((num2 * 1493797849) ^ 0x7A9071F4);
					continue;
				case 54u:
					Form3.smethod_35((Control)(object)Label2, Color.White);
					num = (int)((num2 * 1523839601) ^ 0x6F21479D);
					continue;
				case 53u:
					Form3.smethod_20((Control)(object)SearchDonorBtn, Form3.smethod_19("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Form3.smethod_12((Control)(object)SearchDonorBtn, new Point(20, 38));
					num = (int)(num2 * 1361214166) ^ -465708689;
					continue;
				case 52u:
					Form3.smethod_13((Control)(object)BloodBankPanel2, "BloodBankPanel2");
					num = ((int)num2 * -1751662462) ^ 0x4974A937;
					continue;
				case 51u:
					Form3.smethod_8((Control)(object)GroupBox2);
					num = (int)(num2 * 1012876287) ^ -1828162591;
					continue;
				case 50u:
					GroupBox4 = Form3.smethod_4();
					num = (int)(num2 * 1944486284) ^ -1726316928;
					continue;
				case 49u:
					Form3.smethod_13((Control)(object)PictureBox1, "PictureBox1");
					num = (int)((num2 * 49143318) ^ 0x41FBD4E5);
					continue;
				case 48u:
					Form3.smethod_14((Control)(object)PatientPanel2, new Size(44, 50));
					num = ((int)num2 * -1303516877) ^ 0x213E4C0D;
					continue;
				case 47u:
					Form3.smethod_27((ButtonBase)(object)SearchPtntBtn, "Search Patient");
					num = ((int)num2 * -2022943996) ^ 0x261EA8EB;
					continue;
				case 46u:
					num = ((int)num2 * -1979721272) ^ -1848073049;
					continue;
				case 45u:
					num = ((int)num2 * -1495006123) ^ 0x4465467A;
					continue;
				case 44u:
					Form3.smethod_22(GroupBox5, "Personal Info");
					Form3.smethod_24(Form3.smethod_23((ButtonBase)(object)LogoutBtn), 0);
					num = ((int)num2 * -1659222580) ^ -936622235;
					continue;
				case 43u:
					num = (int)((num2 * 434405462) ^ 0x6D71F7F);
					continue;
				case 42u:
					num = ((int)num2 * -1791827240) ^ -2091145773;
					continue;
				case 41u:
					GroupBox3 = Form3.smethod_4();
					num = (int)(num2 * 1851833883) ^ -1741078435;
					continue;
				case 40u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = ((int)num2 * -1643244076) ^ -1487910514;
					continue;
				case 39u:
					num = ((int)num2 * -1142188987) ^ 0x7B06D995;
					continue;
				case 38u:
					Form3.smethod_20((Control)(object)BloodAvailabilityBtn, Form3.smethod_19("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1139408707) ^ -1780625230;
					continue;
				case 37u:
					Form3.smethod_12((Control)(object)BloodBankPanel1, new Point(0, 38));
					num = (int)(num2 * 1687662821) ^ -2014114542;
					continue;
				case 36u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox5), (Control)(object)LogoutBtn);
					num = ((int)num2 * -28019918) ^ -1268989344;
					continue;
				case 35u:
					num = (int)(num2 * 1201230824) ^ -1828022788;
					continue;
				case 34u:
					Form3.smethod_20((Control)(object)GroupBox2, Form3.smethod_19("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -757386711) ^ -1236625276;
					continue;
				case 33u:
					Form3.smethod_24(Form3.smethod_23((ButtonBase)(object)AddStaffBtn), 0);
					num = ((int)num2 * -1102826899) ^ 0x5DAF212C;
					continue;
				case 32u:
					Form3.smethod_15((Control)(object)UpdateStaffBtn, 7);
					num = (int)((num2 * 909418286) ^ 0x5F867D78);
					continue;
				case 31u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox2), (Control)(object)PatientPanel2);
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox2), (Control)(object)PatientPanel1);
					num = ((int)num2 * -778743503) ^ 0x6A6E54A2;
					continue;
				case 30u:
					Form3.smethod_26((Control)(object)SearchDonorBtn, new Padding(0));
					num = (int)((num2 * 1373291800) ^ 0x64CDA18A);
					continue;
				case 29u:
					Form3.smethod_28((ButtonBase)(object)BloodAvailabilityBtn, bool_0: true);
					num = ((int)num2 * -99520761) ^ 0x3CE616F6;
					continue;
				case 28u:
					Form3.smethod_20((Control)(object)EditProfileBtn, Form3.smethod_19("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -978281087) ^ 0x2D5FF16E;
					continue;
				case 27u:
					num = ((int)num2 * -1801697226) ^ -872840993;
					continue;
				case 26u:
					num = (int)(num2 * 500286812) ^ -1050535285;
					continue;
				case 25u:
					Form3.smethod_13((Control)(object)BloodAvailabilityBtn, "BloodAvailabilityBtn");
					num = ((int)num2 * -1849979154) ^ 0x3CF93806;
					continue;
				case 24u:
					StaffPanel2 = Form3.smethod_3();
					num = ((int)num2 * -1887691154) ^ 0x1914BCA4;
					continue;
				case 23u:
					Form3.smethod_47((Control)(object)GroupBox4, bool_0: false);
					num = (int)(num2 * 443623091) ^ -1171471171;
					continue;
				case 22u:
					num = ((int)num2 * -1307249749) ^ -84136609;
					continue;
				case 21u:
					Form3.smethod_25((ButtonBase)(object)SearchDonorBtn, (FlatStyle)0);
					num = ((int)num2 * -745710079) ^ -880250041;
					continue;
				case 20u:
					num = (int)(num2 * 572215394) ^ -629559446;
					continue;
				case 19u:
					Form3.smethod_39((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -1669722360) ^ 0x58999475;
					continue;
				case 18u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)Panel1), (Control)(object)GroupBox2);
					Form3.smethod_18(Form3.smethod_17((Control)(object)Panel1), (Control)(object)GroupBox4);
					num = (int)(num2 * 1135955651) ^ -1108888979;
					continue;
				case 17u:
					Form3.smethod_13((Control)(object)LogoutBtn, "LogoutBtn");
					num = ((int)num2 * -77869137) ^ 0x64517BCA;
					continue;
				case 16u:
					Form3.smethod_15((Control)(object)PatientPanel2, 6);
					num = ((int)num2 * -206800418) ^ -1026377997;
					continue;
				case 15u:
					Form3.smethod_22(GroupBox2, "Patient");
					num = ((int)num2 * -141978181) ^ 0x173C0237;
					continue;
				case 14u:
					num = (int)((num2 * 69303) ^ 0xD19C338);
					continue;
				case 13u:
					Form3.smethod_21(GroupBox4, bool_0: false);
					num = (int)((num2 * 2046117154) ^ 0x466FAB92);
					continue;
				case 12u:
					Form3.smethod_12((Control)(object)AddStaffBtn, new Point(20, 37));
					num = (int)((num2 * 1358721406) ^ 0x59F6DDD);
					continue;
				case 11u:
					Form3.smethod_14((Control)(object)BloodAvailabilityBtn, new Size(316, 50));
					num = (int)(num2 * 1308473294) ^ -1682220160;
					continue;
				case 10u:
					num = ((int)num2 * -1169842018) ^ 0x4FF38FDF;
					continue;
				case 9u:
					Form3.smethod_15((Control)(object)GroupBox2, 9);
					num = ((int)num2 * -2092304728) ^ -2094970169;
					continue;
				case 8u:
					Form3.smethod_12((Control)(object)Panel1, new Point(126, 141));
					num = (int)((num2 * 22109595) ^ 0x5EE2DB4B);
					continue;
				case 7u:
					Form3.smethod_21(GroupBox3, bool_0: false);
					Form3.smethod_22(GroupBox3, "Staff");
					num = ((int)num2 * -2114925974) ^ -1486733289;
					continue;
				case 6u:
					num = (int)((num2 * 892259461) ^ 0x43942404);
					continue;
				case 5u:
					Form3.smethod_21(GroupBox5, bool_0: false);
					num = ((int)num2 * -2059183000) ^ 0x73EEF71E;
					continue;
				case 4u:
					num = (int)(num2 * 1347398290) ^ -777895324;
					continue;
				case 3u:
					num = (int)((num2 * 1985256324) ^ 0x139D8EBA);
					continue;
				case 2u:
					num = ((int)num2 * -594212686) ^ -2051440072;
					continue;
				case 1u:
					Form3.smethod_28((ButtonBase)(object)AddStaffBtn, bool_0: true);
					num = (int)(num2 * 1916018943) ^ -2080942778;
					continue;
				case 0u:
					Form3.smethod_28((ButtonBase)(object)LogoutBtn, bool_0: true);
					num = (int)(num2 * 1177757383) ^ -38456154;
					continue;
				default:
					return;
				case 294u:
					break;
				case 58u:
					return;
				}
				break;
			}
		}
	}

	private void AddStaffBtn_Click_1(object sender, EventArgs e)
	{
		Form3.smethod_11((Control)(object)PatientPanel1, Color.Transparent);
		while (true)
		{
			int num = -817733687;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9915EC37u) % 15u)
				{
				case 14u:
					Form3.smethod_54((Control)(object)StaffPanel2, Form3.smethod_53((Control)(object)AddStaffBtn));
					Form3.smethod_11((Control)(object)StaffPanel2, Color.DarkBlue);
					num = ((int)num2 * -1599050349) ^ -1156402202;
					continue;
				case 13u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)((num2 * 457708140) ^ 0x7985E8A0);
					continue;
				case 12u:
					Form3.smethod_54((Control)(object)StaffPanel1, Form3.smethod_53((Control)(object)AddStaffBtn));
					num = ((int)num2 * -1528689524) ^ -659211624;
					continue;
				case 11u:
					num = (int)(num2 * 1883355599) ^ -59246738;
					continue;
				case 10u:
					num = ((int)num2 * -416276182) ^ -532210078;
					continue;
				case 9u:
					Form3.smethod_55(Form3.smethod_17((Control)(object)AdminPanel));
					num = ((int)num2 * -109536576) ^ 0x24A80ED3;
					continue;
				case 7u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = ((int)num2 * -2134043201) ^ 0x574FB5DF;
					continue;
				case 6u:
					num = ((int)num2 * -328774575) ^ 0x20B6587E;
					continue;
				case 5u:
					Form3.smethod_11((Control)(object)BloodBankPanel1, Color.Transparent);
					num = (int)(num2 * 2021280425) ^ -1537656157;
					continue;
				case 4u:
					Form3.smethod_11((Control)(object)StaffPanel1, Color.DarkBlue);
					num = (int)(num2 * 573677298) ^ -1550848675;
					continue;
				case 3u:
					Form3.smethod_11((Control)(object)PatientPanel2, Color.Transparent);
					num = (int)((num2 * 1047084030) ^ 0x75C90A0D);
					continue;
				case 2u:
					num = ((int)num2 * -1347261160) ^ -1709564524;
					continue;
				case 1u:
					Form3.smethod_11((Control)(object)BloodBankPanel2, Color.Transparent);
					num = ((int)num2 * -1629568792) ^ 0xEED4A18;
					continue;
				case 0u:
					break;
				default:
					Form3.smethod_18(Form3.smethod_17((Control)(object)AdminPanel), (Control)(object)new AddStaff_Admin());
					return;
				}
				break;
			}
		}
	}

	private void UpdateStaffBtn_Click(object sender, EventArgs e)
	{
		Form3.smethod_11((Control)(object)PatientPanel1, Color.Transparent);
		while (true)
		{
			int num = 173699512;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x260364D9u) % 13u)
				{
				case 12u:
					num = ((int)num2 * -1604692171) ^ -965654658;
					continue;
				case 11u:
					Form3.smethod_11((Control)(object)BloodBankPanel2, Color.Transparent);
					Form3.smethod_11((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = ((int)num2 * -381513132) ^ 0x6D3F76DB;
					continue;
				case 10u:
					Form3.smethod_54((Control)(object)StaffPanel2, Form3.smethod_53((Control)(object)UpdateStaffBtn));
					num = (int)(num2 * 2084238367) ^ -411736715;
					continue;
				case 9u:
					Form3.smethod_11((Control)(object)PatientPanel2, Color.Transparent);
					Form3.smethod_11((Control)(object)BloodBankPanel1, Color.Transparent);
					num = (int)(num2 * 1722238484) ^ -1089524266;
					continue;
				case 7u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = ((int)num2 * -124641308) ^ -332264970;
					continue;
				case 6u:
					num = (int)(num2 * 526161410) ^ -1514955046;
					continue;
				case 5u:
					Form3.smethod_11((Control)(object)StaffPanel2, Color.DarkBlue);
					num = ((int)num2 * -1160078781) ^ 0x3D1D3423;
					continue;
				case 4u:
					Form3.smethod_11((Control)(object)StaffPanel1, Color.DarkBlue);
					num = (int)(num2 * 1956976528) ^ -226949909;
					continue;
				case 3u:
					Form3.smethod_54((Control)(object)StaffPanel1, Form3.smethod_53((Control)(object)UpdateStaffBtn));
					num = ((int)num2 * -872618432) ^ -334510034;
					continue;
				case 1u:
					num = (int)((num2 * 1817145142) ^ 0x372E32E8);
					continue;
				case 0u:
					num = ((int)num2 * -700822693) ^ 0xA265AE6;
					continue;
				case 8u:
					break;
				default:
					Form3.smethod_55(Form3.smethod_17((Control)(object)AdminPanel));
					Form3.smethod_18(Form3.smethod_17((Control)(object)AdminPanel), (Control)(object)new UpdateStaff_Admin());
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
			int num = -890595773;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEEB25FE0u) % 15u)
				{
				case 14u:
					num = ((int)num2 * -792966408) ^ 0x32555001;
					continue;
				case 13u:
					num = ((int)num2 * -610025552) ^ -1520165267;
					continue;
				case 12u:
					Form3.smethod_11((Control)(object)BloodBankPanel2, Color.DarkBlue);
					Form3.smethod_55(Form3.smethod_17((Control)(object)AdminPanel));
					num = ((int)num2 * -1924593605) ^ 0x5C4A13E9;
					continue;
				case 11u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel2, Color.Transparent);
					Form3.smethod_54((Control)(object)BloodBankPanel1, Form3.smethod_53((Control)(object)SearchDonorBtn));
					num = (int)((num2 * 913755025) ^ 0x2B019EE8);
					continue;
				case 8u:
					Form3.smethod_11((Control)(object)PatientPanel1, Color.Transparent);
					num = ((int)num2 * -34837635) ^ 0x1D39DF60;
					continue;
				case 7u:
					Form3.smethod_11((Control)(object)PatientPanel2, Color.Transparent);
					num = ((int)num2 * -487897233) ^ -611934382;
					continue;
				case 6u:
					Form3.smethod_11((Control)(object)BloodBankPanel1, Color.DarkBlue);
					num = ((int)num2 * -1484228951) ^ -2145168908;
					continue;
				case 5u:
					num = (int)(num2 * 752731664) ^ -356325477;
					continue;
				case 4u:
					Form3.smethod_11((Control)(object)StaffPanel1, Color.Transparent);
					num = ((int)num2 * -1725175094) ^ 0x30E9D0E5;
					continue;
				case 3u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)((num2 * 529598661) ^ 0x43E41D4B);
					continue;
				case 2u:
					num = ((int)num2 * -1783708668) ^ 0x13B4DD04;
					continue;
				case 1u:
					Form3.smethod_11((Control)(object)StaffPanel2, Color.Transparent);
					num = ((int)num2 * -1924413278) ^ -802416856;
					continue;
				case 0u:
					Form3.smethod_54((Control)(object)BloodBankPanel2, Form3.smethod_53((Control)(object)SearchDonorBtn));
					num = ((int)num2 * -732870813) ^ -2120876252;
					continue;
				case 10u:
					break;
				default:
					Form3.smethod_18(Form3.smethod_17((Control)(object)AdminPanel), (Control)(object)new SearchDonor_Admin());
					return;
				}
				break;
			}
		}
	}

	private void SearchRecieverBtn_Click(object sender, EventArgs e)
	{
		Form3.smethod_11((Control)(object)PatientPanel1, Color.Transparent);
		while (true)
		{
			int num = -1835922007;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x958AC4C6u) % 16u)
				{
				case 15u:
					Form3.smethod_11((Control)(object)PatientPanel2, Color.Transparent);
					num = (int)((num2 * 1261107991) ^ 0x24509C87);
					continue;
				case 14u:
					Form3.smethod_11((Control)(object)StaffPanel2, Color.Transparent);
					num = (int)(num2 * 1178290899) ^ -1018023577;
					continue;
				case 13u:
					Form3.smethod_11((Control)(object)BloodBankPanel2, Color.DarkBlue);
					num = (int)(num2 * 1454821712) ^ -243775705;
					continue;
				case 11u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)(num2 * 206559128) ^ -197456002;
					continue;
				case 10u:
					Form3.smethod_54((Control)(object)BloodBankPanel2, Form3.smethod_53((Control)(object)SearchRecieverBtn));
					num = (int)(num2 * 285502256) ^ -2005277313;
					continue;
				case 9u:
					num = ((int)num2 * -1907221865) ^ 0x1136DF9A;
					continue;
				case 8u:
					Form3.smethod_11((Control)(object)StaffPanel1, Color.Transparent);
					num = ((int)num2 * -999541881) ^ 0x3DF266E0;
					continue;
				case 6u:
					num = ((int)num2 * -1594884297) ^ -1816361410;
					continue;
				case 5u:
					Form3.smethod_54((Control)(object)BloodBankPanel1, Form3.smethod_53((Control)(object)SearchRecieverBtn));
					num = ((int)num2 * -494410299) ^ 0x1DC4D115;
					continue;
				case 4u:
					num = (int)((num2 * 286928353) ^ 0x65AE24F5);
					continue;
				case 3u:
					Form3.smethod_11((Control)(object)BloodBankPanel1, Color.DarkBlue);
					num = ((int)num2 * -273319076) ^ -89440241;
					continue;
				case 2u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)AdminPanel), (Control)(object)new SearchReciever_Admin());
					num = ((int)num2 * -1197738007) ^ -587133616;
					continue;
				case 1u:
					Form3.smethod_55(Form3.smethod_17((Control)(object)AdminPanel));
					num = (int)(num2 * 1563335511) ^ -10920121;
					continue;
				case 0u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = (int)(num2 * 742368315) ^ -1451602749;
					continue;
				default:
					return;
				case 12u:
					break;
				case 7u:
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
			int num = -110561741;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9AC3CE38u) % 15u)
				{
				case 14u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = (int)(num2 * 2049763584) ^ -569066923;
					continue;
				case 13u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)AdminPanel), (Control)(object)new BloodAvailability());
					num = ((int)num2 * -1115340016) ^ 0x5D242080;
					continue;
				case 12u:
					num = ((int)num2 * -1110464903) ^ -1345728694;
					continue;
				case 11u:
					Form3.smethod_11((Control)(object)StaffPanel1, Color.Transparent);
					Form3.smethod_11((Control)(object)StaffPanel2, Color.Transparent);
					Form3.smethod_11((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)((num2 * 321915729) ^ 0x5BD2DD19);
					continue;
				case 10u:
					Form3.smethod_55(Form3.smethod_17((Control)(object)AdminPanel));
					num = (int)(num2 * 871219926) ^ -1283294402;
					continue;
				case 9u:
					num = ((int)num2 * -1707206954) ^ -394851899;
					continue;
				case 8u:
					Form3.smethod_11((Control)(object)PatientPanel2, Color.Transparent);
					num = ((int)num2 * -1569607591) ^ -1117019232;
					continue;
				case 7u:
					num = ((int)num2 * -1372428507) ^ 0x2DBD5E5;
					continue;
				case 6u:
					num = (int)((num2 * 633762534) ^ 0x34425950);
					continue;
				case 5u:
					Form3.smethod_54((Control)(object)BloodBankPanel2, Form3.smethod_53((Control)(object)BloodAvailabilityBtn));
					num = ((int)num2 * -1444556611) ^ -459125735;
					continue;
				case 3u:
					Form3.smethod_11((Control)(object)BloodBankPanel1, Color.DarkBlue);
					num = ((int)num2 * -442843915) ^ 0x55A2E7C3;
					continue;
				case 1u:
					Form3.smethod_54((Control)(object)BloodBankPanel1, Form3.smethod_53((Control)(object)BloodAvailabilityBtn));
					num = (int)(num2 * 323278173) ^ -52272248;
					continue;
				case 0u:
					Form3.smethod_11((Control)(object)BloodBankPanel2, Color.DarkBlue);
					num = (int)((num2 * 1945783791) ^ 0x366D5ED2);
					continue;
				default:
					return;
				case 4u:
					break;
				case 2u:
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
			int num = -130713836;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEF18ACF1u) % 15u)
				{
				case 14u:
					Form3.smethod_11((Control)(object)BloodBankPanel2, Color.Transparent);
					num = ((int)num2 * -185995445) ^ 0x48730960;
					continue;
				case 12u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel1, Color.DarkBlue);
					num = ((int)num2 * -789935907) ^ 0x2E62C009;
					continue;
				case 11u:
					Form3.smethod_54((Control)(object)PersonalInfoPanel1, Form3.smethod_53((Control)(object)EditProfileBtn));
					Form3.smethod_54((Control)(object)PersonalInfoPanel2, Form3.smethod_53((Control)(object)EditProfileBtn));
					num = (int)(num2 * 1026482597) ^ -2008509212;
					continue;
				case 10u:
					Form3.smethod_11((Control)(object)PatientPanel2, Color.Transparent);
					num = ((int)num2 * -617002613) ^ -837592740;
					continue;
				case 8u:
					num = (int)((num2 * 168335724) ^ 0x32A67787);
					continue;
				case 7u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel2, Color.DarkBlue);
					Form3.smethod_55(Form3.smethod_17((Control)(object)AdminPanel));
					num = (int)(num2 * 1369087674) ^ -1931790201;
					continue;
				case 6u:
					Form3.smethod_11((Control)(object)PatientPanel1, Color.Transparent);
					num = (int)(num2 * 309984480) ^ -825336643;
					continue;
				case 5u:
					Form3.smethod_11((Control)(object)StaffPanel2, Color.Transparent);
					num = (int)(num2 * 471937426) ^ -781292271;
					continue;
				case 4u:
					num = (int)(num2 * 1487735672) ^ -464786848;
					continue;
				case 3u:
					num = ((int)num2 * -1226529074) ^ 0x6BE11345;
					continue;
				case 2u:
					Form3.smethod_11((Control)(object)StaffPanel1, Color.Transparent);
					num = ((int)num2 * -1910232031) ^ -1173395438;
					continue;
				case 1u:
					Form3.smethod_11((Control)(object)BloodBankPanel1, Color.Transparent);
					num = ((int)num2 * -1602556662) ^ 0x73DE8A2D;
					continue;
				case 0u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)AdminPanel), (Control)(object)new EditProfile());
					num = (int)((num2 * 699412647) ^ 0x624C449D);
					continue;
				default:
					return;
				case 13u:
					break;
				case 9u:
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
			int num = -443307436;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA9F4227Au) % 21u)
				{
				case 20u:
					Form3.smethod_11((Control)(object)BloodBankPanel2, Color.Transparent);
					num = (int)((num2 * 1421379235) ^ 0x6632C4FF);
					continue;
				case 19u:
					num = ((int)num2 * -1245755205) ^ 0x2435607;
					continue;
				case 18u:
					num = (int)(num2 * 1042345686) ^ -576071006;
					continue;
				case 17u:
					num = (int)(num2 * 912025508) ^ -1768186600;
					continue;
				case 16u:
					Form3.smethod_57((Control)(object)MyProject.Forms.Form1);
					num = (int)(num2 * 1526509635) ^ -1346072712;
					continue;
				case 15u:
					Form3.smethod_11((Control)(object)PatientPanel2, Color.Transparent);
					num = (int)((num2 * 107606934) ^ 0x527CFD15);
					continue;
				case 14u:
					num = ((int)num2 * -1631088143) ^ -273064709;
					continue;
				case 13u:
					Form3.smethod_56((Form)(object)this);
					num = ((int)num2 * -1214024984) ^ -844997160;
					continue;
				case 12u:
					num = ((int)num2 * -886782171) ^ 0x7A0EEDF4;
					continue;
				case 11u:
					Form3.smethod_54((Control)(object)PersonalInfoPanel2, Form3.smethod_53((Control)(object)LogoutBtn));
					num = (int)((num2 * 1483324806) ^ 0x5A762A4B);
					continue;
				case 10u:
					num = ((int)num2 * -1019278519) ^ 0x71389C2C;
					continue;
				case 8u:
					Form3.smethod_11((Control)(object)BloodBankPanel1, Color.Transparent);
					num = ((int)num2 * -1271546075) ^ 0x3CE0CE88;
					continue;
				case 7u:
					num = ((int)num2 * -1600860355) ^ -200440940;
					continue;
				case 6u:
					MyProject.Forms.Form1.username = "";
					MyProject.Forms.Form1.login_type = "";
					num = ((int)num2 * -190746989) ^ 0x55AA476E;
					continue;
				case 5u:
					num = ((int)num2 * -1753883996) ^ -383327691;
					continue;
				case 4u:
					Form3.smethod_11((Control)(object)PatientPanel1, Color.Transparent);
					num = (int)((num2 * 2130229026) ^ 0x5472D920);
					continue;
				case 3u:
					Form3.smethod_11((Control)(object)StaffPanel2, Color.Transparent);
					Form3.smethod_11((Control)(object)StaffPanel1, Color.Transparent);
					Form3.smethod_54((Control)(object)PersonalInfoPanel1, Form3.smethod_53((Control)(object)LogoutBtn));
					num = (int)(num2 * 94548180) ^ -602335938;
					continue;
				case 1u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel1, Color.DarkBlue);
					num = ((int)num2 * -1620794338) ^ 0x2FF5E518;
					continue;
				case 0u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel2, Color.DarkBlue);
					num = (int)((num2 * 1329580960) ^ 0x1140CF3E);
					continue;
				default:
					return;
				case 2u:
					break;
				case 9u:
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
			int num = 685378419;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x626DFBD9u) % 5u)
				{
				case 4u:
					MyProject.Forms.Form1.login_type = "";
					num = (int)(num2 * 1359583850) ^ -636771449;
					continue;
				case 2u:
					MyProject.Forms.Form1.username = "";
					num = (int)((num2 * 346994415) ^ 0x43B50631);
					continue;
				case 1u:
					Form3.smethod_57((Control)(object)MyProject.Forms.Form1);
					num = ((int)num2 * -1745413336) ^ 0x52EF80F5;
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
		while (true)
		{
			int num = 752268663;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x53D0662Bu) % 18u)
				{
				case 17u:
					num = ((int)num2 * -460158602) ^ 0x4C03A9A2;
					continue;
				case 16u:
					Form3.smethod_11((Control)(object)BloodBankPanel1, Color.Transparent);
					Form3.smethod_11((Control)(object)BloodBankPanel2, Color.Transparent);
					num = (int)(num2 * 1007136620) ^ -1354275426;
					continue;
				case 15u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)AdminPanel), (Control)(object)new SearchPatient_Admin());
					num = ((int)num2 * -152071462) ^ -2017148948;
					continue;
				case 14u:
					Form3.smethod_54((Control)(object)PatientPanel2, Form3.smethod_53((Control)(object)SearchPtntBtn));
					num = ((int)num2 * -1778535612) ^ 0x654D782A;
					continue;
				case 13u:
					Form3.smethod_11((Control)(object)StaffPanel2, Color.Transparent);
					num = (int)((num2 * 1814698398) ^ 0x69B84025);
					continue;
				case 12u:
					Form3.smethod_11((Control)(object)PatientPanel1, Color.DarkBlue);
					Form3.smethod_11((Control)(object)PatientPanel2, Color.DarkBlue);
					num = ((int)num2 * -1659257016) ^ 0x5217B29F;
					continue;
				case 10u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = ((int)num2 * -740533029) ^ 0x2EB0066D;
					continue;
				case 8u:
					Form3.smethod_55(Form3.smethod_17((Control)(object)AdminPanel));
					num = ((int)num2 * -1962556137) ^ -1003847498;
					continue;
				case 7u:
					num = (int)((num2 * 1994029878) ^ 0x26FA046B);
					continue;
				case 6u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel2, Color.Transparent);
					Form3.smethod_54((Control)(object)PatientPanel1, Form3.smethod_53((Control)(object)SearchPtntBtn));
					num = (int)(num2 * 2082267891) ^ -1955246575;
					continue;
				case 5u:
					num = (int)(num2 * 1633266907) ^ -1652026914;
					continue;
				case 4u:
					num = (int)(num2 * 1738574438) ^ -669378584;
					continue;
				case 3u:
					num = (int)((num2 * 1457417235) ^ 0xD23C76F);
					continue;
				case 2u:
					num = ((int)num2 * -1656466391) ^ 0x757284C1;
					continue;
				case 1u:
					Form3.smethod_11((Control)(object)StaffPanel1, Color.Transparent);
					num = (int)(num2 * 34452339) ^ -1608565357;
					continue;
				case 0u:
					num = ((int)num2 * -1932303986) ^ 0x8F3BFA5;
					continue;
				default:
					return;
				case 11u:
					break;
				case 9u:
					return;
				}
				break;
			}
		}
	}

	private void Form3_Shown(object sender, EventArgs e)
	{
		Form3.smethod_58((Control)(object)this);
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
