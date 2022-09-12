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
				int num = -853987100;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8D90E1F9u) % 7u)
					{
					case 6u:
					{
						logoutBtn = _LogoutBtn;
						int num5;
						int num6;
						if (logoutBtn == null)
						{
							num5 = 90911264;
							num6 = 90911264;
						}
						else
						{
							num5 = 1276321677;
							num6 = 1276321677;
						}
						num = num5 ^ ((int)num2 * -1442536610);
						continue;
					}
					case 5u:
					{
						int num3;
						int num4;
						if (logoutBtn != null)
						{
							num3 = -366546119;
							num4 = -366546119;
						}
						else
						{
							num3 = -1835743198;
							num4 = -1835743198;
						}
						num = num3 ^ ((int)num2 * -1886640797);
						continue;
					}
					case 4u:
						Form3.smethod_51((Control)(object)logoutBtn, eventHandler_);
						num = (int)(num2 * 1007411262) ^ -297681574;
						continue;
					case 3u:
						Form3.smethod_52((Control)(object)logoutBtn, eventHandler_);
						num = ((int)num2 * -698327247) ^ -1967825518;
						continue;
					case 2u:
						_LogoutBtn = value;
						logoutBtn = _LogoutBtn;
						num = -1640732166;
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
				int num = 1328237964;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x77814509u) % 7u)
					{
					case 5u:
					{
						int num4;
						int num5;
						if (editProfileBtn != null)
						{
							num4 = -471316552;
							num5 = -471316552;
						}
						else
						{
							num4 = -213101492;
							num5 = -213101492;
						}
						num = num4 ^ ((int)num2 * -1544193170);
						continue;
					}
					case 4u:
						Form3.smethod_52((Control)(object)editProfileBtn, eventHandler_);
						num = ((int)num2 * -1783778150) ^ 0x6A742D09;
						continue;
					case 3u:
					{
						_EditProfileBtn = value;
						editProfileBtn = _EditProfileBtn;
						int num3;
						if (editProfileBtn == null)
						{
							num = 1581094517;
							num3 = 1581094517;
						}
						else
						{
							num = 1246401215;
							num3 = 1246401215;
						}
						continue;
					}
					case 2u:
						Form3.smethod_51((Control)(object)editProfileBtn, eventHandler_);
						num = (int)((num2 * 80118157) ^ 0x6AEEA619);
						continue;
					case 1u:
						editProfileBtn = _EditProfileBtn;
						num = ((int)num2 * -1467715605) ^ 0xFB375C4;
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
			while (true)
			{
				int num = -93251661;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE6A12484u) % 7u)
					{
					case 6u:
						Form3.smethod_52((Control)(object)updateStaffBtn, eventHandler_);
						num = ((int)num2 * -1355298358) ^ 0x74C54F0;
						continue;
					case 4u:
						_UpdateStaffBtn = value;
						updateStaffBtn = _UpdateStaffBtn;
						num = -1187030405;
						continue;
					case 3u:
					{
						int num5;
						int num6;
						if (updateStaffBtn == null)
						{
							num5 = 327800758;
							num6 = 327800758;
						}
						else
						{
							num5 = 1767994464;
							num6 = 1767994464;
						}
						num = num5 ^ ((int)num2 * -1600371990);
						continue;
					}
					case 2u:
						Form3.smethod_51((Control)(object)updateStaffBtn, eventHandler_);
						num = ((int)num2 * -1187462898) ^ -948271316;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (updateStaffBtn == null)
						{
							num3 = 713883858;
							num4 = 713883858;
						}
						else
						{
							num3 = 1403081655;
							num4 = 1403081655;
						}
						num = num3 ^ ((int)num2 * -1798243780);
						continue;
					}
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
				int num = -1582390987;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA5D2AD16u) % 7u)
					{
					case 6u:
					{
						int num5;
						int num6;
						if (addStaffBtn != null)
						{
							num5 = 381015466;
							num6 = 381015466;
						}
						else
						{
							num5 = 1454875689;
							num6 = 1454875689;
						}
						num = num5 ^ (int)(num2 * 353954446);
						continue;
					}
					case 5u:
					{
						addStaffBtn = _AddStaffBtn;
						int num3;
						int num4;
						if (addStaffBtn != null)
						{
							num3 = -390453529;
							num4 = -390453529;
						}
						else
						{
							num3 = -1745146224;
							num4 = -1745146224;
						}
						num = num3 ^ (int)(num2 * 1971568605);
						continue;
					}
					case 4u:
						_AddStaffBtn = value;
						num = -1957286725;
						continue;
					case 3u:
						Form3.smethod_52((Control)(object)addStaffBtn, eventHandler_);
						num = (int)((num2 * 2089583395) ^ 0x22CC5331);
						continue;
					case 2u:
						Form3.smethod_51((Control)(object)addStaffBtn, eventHandler_);
						num = ((int)num2 * -1843665976) ^ -762631053;
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
			while (true)
			{
				int num = 756441133;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2BFF5FF5u) % 7u)
					{
					case 6u:
					{
						searchPtntBtn = _SearchPtntBtn;
						int num5;
						int num6;
						if (searchPtntBtn != null)
						{
							num5 = -670585619;
							num6 = -670585619;
						}
						else
						{
							num5 = -1702049650;
							num6 = -1702049650;
						}
						num = num5 ^ ((int)num2 * -1572619153);
						continue;
					}
					case 5u:
						_SearchPtntBtn = value;
						num = 462277377;
						continue;
					case 3u:
						Form3.smethod_52((Control)(object)searchPtntBtn, eventHandler_);
						num = ((int)num2 * -738143459) ^ -738787514;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (searchPtntBtn == null)
						{
							num3 = 411185397;
							num4 = 411185397;
						}
						else
						{
							num3 = 223592145;
							num4 = 223592145;
						}
						num = num3 ^ ((int)num2 * -1967345528);
						continue;
					}
					case 1u:
						Form3.smethod_51((Control)(object)searchPtntBtn, eventHandler_);
						num = ((int)num2 * -1588710598) ^ 0x4B86479D;
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
			while (true)
			{
				int num = -465901109;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x89F7198Au) % 6u)
					{
					case 5u:
					{
						_BloodAvailabilityBtn = value;
						bloodAvailabilityBtn = _BloodAvailabilityBtn;
						int num5;
						if (bloodAvailabilityBtn == null)
						{
							num = -210771089;
							num5 = -210771089;
						}
						else
						{
							num = -14229692;
							num5 = -14229692;
						}
						continue;
					}
					case 2u:
						Form3.smethod_52((Control)(object)bloodAvailabilityBtn, eventHandler_);
						num = (int)(num2 * 980817856) ^ -1236631569;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (bloodAvailabilityBtn == null)
						{
							num3 = -1761328448;
							num4 = -1761328448;
						}
						else
						{
							num3 = -2011198779;
							num4 = -2011198779;
						}
						num = num3 ^ ((int)num2 * -1015836339);
						continue;
					}
					case 0u:
						Form3.smethod_51((Control)(object)bloodAvailabilityBtn, eventHandler_);
						num = (int)((num2 * 1382951511) ^ 0x70EBA0A3);
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
				int num = 2016967069;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x719F979Bu) % 7u)
					{
					case 6u:
						searchRecieverBtn = _SearchRecieverBtn;
						num = (int)((num2 * 910433072) ^ 0x659AC49C);
						continue;
					case 5u:
						Form3.smethod_51((Control)(object)searchRecieverBtn, eventHandler_);
						num = ((int)num2 * -1146638362) ^ 0x16B52D24;
						continue;
					case 4u:
						Form3.smethod_52((Control)(object)searchRecieverBtn, eventHandler_);
						num = ((int)num2 * -1173870312) ^ 0x374DD68B;
						continue;
					case 1u:
					{
						_SearchRecieverBtn = value;
						searchRecieverBtn = _SearchRecieverBtn;
						int num5;
						if (searchRecieverBtn == null)
						{
							num = 1470871867;
							num5 = 1470871867;
						}
						else
						{
							num = 479803145;
							num5 = 479803145;
						}
						continue;
					}
					case 0u:
					{
						int num3;
						int num4;
						if (searchRecieverBtn == null)
						{
							num3 = -770399785;
							num4 = -770399785;
						}
						else
						{
							num3 = -185457565;
							num4 = -185457565;
						}
						num = num3 ^ (int)(num2 * 695944715);
						continue;
					}
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
				goto IL_006c;
			}
			goto IL_00b4;
			IL_00b4:
			_SearchDonorBtn = value;
			int num = -744786351;
			goto IL_0087;
			IL_0087:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBCF3D776u) % 7u)
				{
				case 6u:
					Form3.smethod_52((Control)(object)searchDonorBtn, eventHandler_);
					num = (int)((num2 * 1094169267) ^ 0x2CC40801);
					continue;
				case 5u:
					Form3.smethod_51((Control)(object)searchDonorBtn, eventHandler_);
					num = ((int)num2 * -1092671384) ^ -1221787240;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (searchDonorBtn != null)
					{
						num3 = -1229383892;
						num4 = -1229383892;
					}
					else
					{
						num3 = -1689465165;
						num4 = -1689465165;
					}
					num = num3 ^ ((int)num2 * -1535199978);
					continue;
				}
				case 2u:
					break;
				case 1u:
					searchDonorBtn = _SearchDonorBtn;
					num = ((int)num2 * -176174389) ^ -1422408310;
					continue;
				default:
					return;
				case 0u:
					goto IL_00b4;
				case 3u:
					return;
				}
				break;
			}
			goto IL_006c;
			IL_006c:
			num = -707540208;
			goto IL_0087;
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
				int num = -36252481;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xC788D51Bu) % 8u)
					{
					case 7u:
						Form3.smethod_2((IDisposable)components);
						num = (int)((num2 * 452888492) ^ 0x4CF2B062);
						continue;
					case 6u:
						num = -459294766;
						continue;
					case 5u:
						num = (int)((num2 * 1787913005) ^ 0x2D205DD1);
						continue;
					case 4u:
						if (disposing)
						{
							num = (int)(num2 * 243227830) ^ -649976751;
							continue;
						}
						goto IL_004c;
					case 3u:
						num = ((int)num2 * -618108847) ^ 0x6680F1C6;
						continue;
					case 2u:
						if (components != null)
						{
							num = -400159076;
							num3 = -400159076;
							continue;
						}
						goto IL_004c;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
						IL_004c:
						num = -1155294347;
						num3 = -1155294347;
						continue;
					}
					break;
				}
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
			while (true)
			{
				IL_00ec:
				int num4 = -1320747553;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num4 ^ 0xC788D51Bu) % 3u)
					{
					case 2u:
						goto IL_00c2;
					default:
						goto end_IL_00cf;
					case 0u:
						break;
					case 1u:
						goto end_IL_00cf;
					}
					goto IL_00ec;
					IL_00c2:
					num4 = ((int)num2 * -2019317133) ^ 0x5261286F;
					continue;
					end_IL_00cf:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1513: Unknown result type (might be due to invalid IL or missing references)
		//IL_16bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1994: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c62: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f23: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = 1644565182;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5F8A6A86u) % 289u)
				{
				case 288u:
					Form3.smethod_50((Control)(object)this);
					num = (int)((num2 * 757563690) ^ 0x4E1EFADA);
					continue;
				case 287u:
					Form3.smethod_26((Control)(object)SearchRecieverBtn, new Padding(0));
					num = (int)((num2 * 2072117898) ^ 0x6E440856);
					continue;
				case 286u:
					GroupBox5 = Form3.smethod_4();
					num = (int)((num2 * 1407014822) ^ 0x53AF35A7);
					continue;
				case 285u:
					num = ((int)num2 * -2119160888) ^ 0xA1CBF0F;
					continue;
				case 284u:
					Form3.smethod_26((Control)(object)SearchPtntBtn, new Padding(0));
					num = (int)(num2 * 577371189) ^ -1109311451;
					continue;
				case 283u:
					Form3.smethod_12((Control)(object)SearchRecieverBtn, new Point(20, 88));
					num = ((int)num2 * -1787727416) ^ 0x6F904DBC;
					continue;
				case 282u:
					num = ((int)num2 * -963511180) ^ -134506335;
					continue;
				case 281u:
					Form3.smethod_15((Control)(object)BloodBankPanel2, 15);
					num = (int)((num2 * 613123429) ^ 0x66680191);
					continue;
				case 280u:
					BloodBankPanel1 = Form3.smethod_3();
					num = (int)(num2 * 871408484) ^ -1692060267;
					continue;
				case 279u:
					Form3.smethod_11((Control)(object)StaffPanel1, Color.Transparent);
					num = ((int)num2 * -2075465784) ^ 0x525023DB;
					continue;
				case 278u:
					Form3.smethod_12((Control)(object)PersonalInfoPanel2, new Point(311, 52));
					num = (int)((num2 * 57781856) ^ 0xD7726C);
					continue;
				case 277u:
					Form3.smethod_15((Control)(object)PersonalInfoPanel2, 16);
					num = (int)(num2 * 967772983) ^ -2007363230;
					continue;
				case 276u:
					StaffPanel2 = Form3.smethod_3();
					num = (int)(num2 * 1022802058) ^ -1884451869;
					continue;
				case 275u:
					num = ((int)num2 * -1235023161) ^ -941883898;
					continue;
				case 274u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox2), (Control)(object)PatientPanel1);
					num = (int)((num2 * 1979487277) ^ 0x6F6790DB);
					continue;
				case 273u:
					num = ((int)num2 * -1066334132) ^ -1153068800;
					continue;
				case 272u:
					Form3.smethod_14((Control)(object)SearchDonorBtn, new Size(316, 50));
					Form3.smethod_15((Control)(object)SearchDonorBtn, 5);
					num = ((int)num2 * -1711453244) ^ 0x65FB486E;
					continue;
				case 271u:
					Form3.smethod_11((Control)(object)Panel1, Color.White);
					num = ((int)num2 * -506810369) ^ 0xC90CF28;
					continue;
				case 270u:
					Form3.smethod_15((Control)(object)PatientPanel2, 6);
					num = ((int)num2 * -1362475776) ^ -419986929;
					continue;
				case 269u:
					BloodAvailabilityBtn = Form3.smethod_5();
					num = (int)(num2 * 532533022) ^ -945812830;
					continue;
				case 268u:
					Form3.smethod_14((Control)(object)Label2, new Size(845, 69));
					num = (int)((num2 * 528728699) ^ 0x171ABEB5);
					continue;
				case 267u:
					num = (int)((num2 * 1636868160) ^ 0x7D0B06EE);
					continue;
				case 266u:
					Form3.smethod_18(Form3.smethod_42((Control)(object)this), (Control)(object)AdminPanel);
					num = (int)((num2 * 756516346) ^ 0x52C29273);
					continue;
				case 265u:
					num = (int)(num2 * 1500102149) ^ -351160824;
					continue;
				case 264u:
					num = ((int)num2 * -1202933236) ^ 0x34848840;
					continue;
				case 263u:
					Form3.smethod_13((Control)(object)StaffPanel2, "StaffPanel2");
					Form3.smethod_14((Control)(object)StaffPanel2, new Size(44, 50));
					Form3.smethod_15((Control)(object)StaffPanel2, 6);
					num = ((int)num2 * -1289231181) ^ -706508127;
					continue;
				case 262u:
					GroupBox2 = Form3.smethod_4();
					num = (int)(num2 * 24090424) ^ -608047248;
					continue;
				case 261u:
					Form3.smethod_24(Form3.smethod_23((ButtonBase)(object)BloodAvailabilityBtn), 0);
					num = (int)((num2 * 1503084203) ^ 0x34E17A77);
					continue;
				case 260u:
					num = (int)((num2 * 1203231696) ^ 0x69C83CCF);
					continue;
				case 259u:
					Form3.smethod_13((Control)(object)SearchPtntBtn, "SearchPtntBtn");
					num = (int)((num2 * 832908909) ^ 0xF43B913);
					continue;
				case 258u:
					Form3.smethod_47((Control)(object)GroupBox3, bool_0: false);
					num = (int)(num2 * 956518524) ^ -707597026;
					continue;
				case 257u:
					Form3.smethod_11((Control)(object)BloodBankPanel1, Color.Transparent);
					num = ((int)num2 * -584025209) ^ 0x35C0370D;
					continue;
				case 256u:
					Form3.smethod_31(PictureBox1, (PictureBoxSizeMode)1);
					Form3.smethod_32(PictureBox1, 9);
					num = ((int)num2 * -1907225133) ^ -551647986;
					continue;
				case 255u:
					Form3.smethod_48((ISupportInitialize)PictureBox1);
					num = (int)((num2 * 1070231776) ^ 0x5142F2EC);
					continue;
				case 254u:
					Form3.smethod_12((Control)(object)SearchDonorBtn, new Point(20, 38));
					Form3.smethod_26((Control)(object)SearchDonorBtn, new Padding(0));
					num = (int)(num2 * 1410025533) ^ -412456563;
					continue;
				case 253u:
					num = ((int)num2 * -331733353) ^ 0x17B136C9;
					continue;
				case 252u:
					Form3.smethod_8((Control)(object)Panel1);
					num = (int)(num2 * 586736918) ^ -874189673;
					continue;
				case 251u:
					num = ((int)num2 * -1595207332) ^ -328323864;
					continue;
				case 250u:
					PersonalInfoPanel2 = Form3.smethod_3();
					num = ((int)num2 * -1187692250) ^ 0x18CED5CA;
					continue;
				case 249u:
					num = ((int)num2 * -1330831580) ^ 0x4A012B74;
					continue;
				case 248u:
					Form3.smethod_22(GroupBox4, "Blood Bank");
					num = (int)(num2 * 777339165) ^ -598209711;
					continue;
				case 247u:
					num = (int)(num2 * 1544581097) ^ -1706264507;
					continue;
				case 246u:
					Form3.smethod_27((ButtonBase)(object)SearchPtntBtn, "Search Patient");
					num = (int)(num2 * 423443911) ^ -179159136;
					continue;
				case 245u:
					Form3.smethod_13((Control)(object)LogoutBtn, "LogoutBtn");
					Form3.smethod_14((Control)(object)LogoutBtn, new Size(316, 50));
					num = (int)(num2 * 173437834) ^ -1847387448;
					continue;
				case 244u:
					num = (int)(num2 * 1895722590) ^ -2064311873;
					continue;
				case 243u:
					Form3.smethod_15((Control)(object)GroupBox2, 9);
					num = (int)((num2 * 610244990) ^ 0x3D39D51F);
					continue;
				case 242u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)Panel1), (Control)(object)GroupBox5);
					Form3.smethod_18(Form3.smethod_17((Control)(object)Panel1), (Control)(object)GroupBox3);
					num = ((int)num2 * -963372504) ^ -1183653630;
					continue;
				case 241u:
					num = ((int)num2 * -1085425979) ^ 0x507CAC9A;
					continue;
				case 240u:
					Form3.smethod_15((Control)(object)LogoutBtn, 6);
					num = (int)(num2 * 1788114440) ^ -175299763;
					continue;
				case 239u:
					Form3.smethod_28((ButtonBase)(object)SearchDonorBtn, bool_0: true);
					num = ((int)num2 * -2133524718) ^ 0x683EF54B;
					continue;
				case 238u:
					num = (int)((num2 * 1134152140) ^ 0x51B9479A);
					continue;
				case 237u:
					Form3.smethod_18(Form3.smethod_42((Control)(object)this), (Control)(object)PictureBox1);
					num = ((int)num2 * -1228074344) ^ 0xEBA3095;
					continue;
				case 236u:
					Form3.smethod_26((Control)(object)AddStaffBtn, new Padding(0));
					num = (int)((num2 * 1905288543) ^ 0x7D206FE1);
					continue;
				case 235u:
					Form3.smethod_43((Form)(object)this, bool_0: false);
					num = ((int)num2 * -584506932) ^ 0x23673D6C;
					continue;
				case 234u:
					Form3.smethod_15((Control)(object)BloodBankPanel1, 14);
					num = ((int)num2 * -1406145718) ^ 0x30F64287;
					continue;
				case 233u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox5), (Control)(object)LogoutBtn);
					num = ((int)num2 * -1304544879) ^ -1389915339;
					continue;
				case 232u:
					num = (int)(num2 * 2010797982) ^ -333203901;
					continue;
				case 231u:
					num = ((int)num2 * -1840532363) ^ -521839273;
					continue;
				case 230u:
					num = (int)((num2 * 1715265503) ^ 0x576E5D2C);
					continue;
				case 229u:
					num = (int)((num2 * 508086640) ^ 0x22B4D9D2);
					continue;
				case 228u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox3), (Control)(object)UpdateStaffBtn);
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox3), (Control)(object)AddStaffBtn);
					num = ((int)num2 * -1017518395) ^ -1792159603;
					continue;
				case 227u:
					Form3.smethod_13((Control)(object)PersonalInfoPanel2, "PersonalInfoPanel2");
					num = (int)(num2 * 883500171) ^ -1413832495;
					continue;
				case 226u:
					num = ((int)num2 * -1240956969) ^ 0x3D2A146;
					continue;
				case 225u:
					Form3.smethod_9((ISupportInitialize)PictureBox1);
					num = (int)((num2 * 200718361) ^ 0x1C1298D1);
					continue;
				case 224u:
					Form3.smethod_12((Control)(object)BloodBankPanel2, new Point(311, 38));
					num = ((int)num2 * -990029552) ^ -859429134;
					continue;
				case 223u:
					Form3.smethod_13((Control)(object)GroupBox3, "GroupBox3");
					num = (int)(num2 * 481440474) ^ -576259338;
					continue;
				case 222u:
					num = (int)((num2 * 384689678) ^ 0x6A121F);
					continue;
				case 221u:
					Form3.smethod_27((ButtonBase)(object)UpdateStaffBtn, "Update Staff");
					Form3.smethod_28((ButtonBase)(object)UpdateStaffBtn, bool_0: true);
					num = (int)(num2 * 2076735011) ^ -555947859;
					continue;
				case 220u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = ((int)num2 * -1957465880) ^ -657073537;
					continue;
				case 219u:
					Form3.smethod_24(Form3.smethod_23((ButtonBase)(object)LogoutBtn), 0);
					num = (int)(num2 * 1605297878) ^ -1585928215;
					continue;
				case 218u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)Panel1), (Control)(object)GroupBox2);
					num = (int)((num2 * 193008162) ^ 0x2C23EAFC);
					continue;
				case 217u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox5), (Control)(object)PersonalInfoPanel2);
					num = ((int)num2 * -1451566042) ^ -1730492092;
					continue;
				case 216u:
					Form3.smethod_25((ButtonBase)(object)EditProfileBtn, (FlatStyle)0);
					num = (int)(num2 * 1134914129) ^ -1458375395;
					continue;
				case 215u:
					Form3.smethod_18(Form3.smethod_42((Control)(object)this), (Control)(object)Label2);
					num = ((int)num2 * -647900216) ^ -2069895859;
					continue;
				case 214u:
					Form3.smethod_25((ButtonBase)(object)AddStaffBtn, (FlatStyle)0);
					num = ((int)num2 * -1595076211) ^ 0x19E59F2F;
					continue;
				case 213u:
					Form3.smethod_15((Control)(object)GroupBox4, 11);
					num = (int)((num2 * 767974966) ^ 0x4A28F601);
					continue;
				case 212u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox4), (Control)(object)SearchRecieverBtn);
					num = ((int)num2 * -1546725269) ^ -264527788;
					continue;
				case 211u:
					Form3.smethod_25((ButtonBase)(object)BloodAvailabilityBtn, (FlatStyle)0);
					num = (int)(num2 * 2076289012) ^ -32265663;
					continue;
				case 210u:
					Form3.smethod_20((Control)(object)SearchRecieverBtn, Form3.smethod_19("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1634847985) ^ 0x16EBB3);
					continue;
				case 209u:
					Form3.smethod_15((Control)(object)Label2, 8);
					Form3.smethod_36(Label2, "Golisano's Hospital Of Florida");
					num = ((int)num2 * -1625183114) ^ 0x228444E5;
					continue;
				case 208u:
					Form3.smethod_11((Control)(object)StaffPanel2, Color.Transparent);
					Form3.smethod_12((Control)(object)StaffPanel2, new Point(311, 37));
					num = ((int)num2 * -1730889602) ^ -39551636;
					continue;
				case 207u:
					AdminPanel = Form3.smethod_3();
					num = ((int)num2 * -719340037) ^ 0xCA93965;
					continue;
				case 206u:
					num = (int)((num2 * 821660044) ^ 0x71002080);
					continue;
				case 205u:
					num = ((int)num2 * -1563834150) ^ -1787017240;
					continue;
				case 204u:
					num = ((int)num2 * -1027279347) ^ -1280175415;
					continue;
				case 203u:
					num = (int)((num2 * 922099445) ^ 0x43E4AD);
					continue;
				case 202u:
					Form3.smethod_14((Control)(object)GroupBox3, new Size(355, 165));
					num = (int)(num2 * 1523000188) ^ -571081668;
					continue;
				case 201u:
					SearchRecieverBtn = Form3.smethod_5();
					num = (int)((num2 * 653374953) ^ 0x164C267D);
					continue;
				case 200u:
					num = (int)((num2 * 46437747) ^ 0x41D961B);
					continue;
				case 199u:
					num = (int)(num2 * 1263233539) ^ -1751445996;
					continue;
				case 198u:
					num = ((int)num2 * -1285366277) ^ -647212445;
					continue;
				case 197u:
					Form3.smethod_11((Control)(object)AdminPanel, Color.White);
					num = ((int)num2 * -144365492) ^ -1709907548;
					continue;
				case 196u:
					Form3.smethod_14((Control)(object)BloodBankPanel2, new Size(44, 50));
					num = ((int)num2 * -1747155015) ^ 0x4ED2EC7A;
					continue;
				case 195u:
					num = (int)((num2 * 2050216514) ^ 0x62CCFA10);
					continue;
				case 194u:
					Form3.smethod_47((Control)(object)GroupBox5, bool_0: false);
					num = (int)(num2 * 1843086027) ^ -601352231;
					continue;
				case 193u:
					Form3.smethod_8((Control)(object)GroupBox5);
					num = (int)((num2 * 570897089) ^ 0x6CED0E8F);
					continue;
				case 192u:
					GroupBox4 = Form3.smethod_4();
					num = ((int)num2 * -2110252298) ^ -1650280040;
					continue;
				case 191u:
					Form3.smethod_29((ButtonBase)(object)SearchPtntBtn, Color.White);
					Form3.smethod_24(Form3.smethod_23((ButtonBase)(object)SearchPtntBtn), 0);
					num = ((int)num2 * -1178623082) ^ 0x4C025E57;
					continue;
				case 190u:
					num = ((int)num2 * -890217079) ^ 0x1E939BD7;
					continue;
				case 189u:
					num = ((int)num2 * -183738957) ^ -1624808144;
					continue;
				case 188u:
					Form3.smethod_13((Control)(object)PictureBox1, "PictureBox1");
					num = (int)(num2 * 209686310) ^ -2007267243;
					continue;
				case 187u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox2), (Control)(object)SearchPtntBtn);
					num = (int)((num2 * 872548859) ^ 0x74A02B97);
					continue;
				case 186u:
					Form3.smethod_14((Control)(object)GroupBox2, new Size(355, 114));
					num = ((int)num2 * -1243521007) ^ 0x76669140;
					continue;
				case 185u:
					num = (int)(num2 * 1662084871) ^ -219053762;
					continue;
				case 184u:
					Form3.smethod_13((Control)(object)AddStaffBtn, "AddStaffBtn");
					num = ((int)num2 * -1632724531) ^ -1686688247;
					continue;
				case 183u:
					Form3.smethod_13((Control)(object)UpdateStaffBtn, "UpdateStaffBtn");
					num = (int)((num2 * 243469010) ^ 0x49B005);
					continue;
				case 182u:
					Form3.smethod_15((Control)(object)SearchRecieverBtn, 6);
					num = (int)((num2 * 1063247003) ^ 0x5EB755D8);
					continue;
				case 181u:
					Form3.smethod_13((Control)(object)StaffPanel1, "StaffPanel1");
					num = ((int)num2 * -345313576) ^ -1286121731;
					continue;
				case 180u:
					Form3.smethod_15((Control)(object)GroupBox5, 12);
					Form3.smethod_21(GroupBox5, bool_0: false);
					num = ((int)num2 * -1101495924) ^ 0x5A373DFF;
					continue;
				case 179u:
					num = ((int)num2 * -969466562) ^ 0x48B624C1;
					continue;
				case 178u:
					Form3.smethod_15((Control)(object)PersonalInfoPanel1, 15);
					num = ((int)num2 * -91706007) ^ 0x21A06EB4;
					continue;
				case 177u:
					num = (int)((num2 * 1008453708) ^ 0x44998DAE);
					continue;
				case 176u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)Panel1), (Control)(object)GroupBox4);
					num = ((int)num2 * -214057669) ^ -1730468652;
					continue;
				case 175u:
					num = ((int)num2 * -2053369643) ^ 0xF00E7C0;
					continue;
				case 174u:
					num = (int)(num2 * 1324318705) ^ -466605856;
					continue;
				case 173u:
					Form3.smethod_21(GroupBox4, bool_0: false);
					num = ((int)num2 * -599079924) ^ 0x484C2A07;
					continue;
				case 172u:
					num = ((int)num2 * -1564872114) ^ 0x6F8BA12;
					continue;
				case 171u:
					Form3.smethod_28((ButtonBase)(object)SearchPtntBtn, bool_0: false);
					num = ((int)num2 * -286705636) ^ -1459093732;
					continue;
				case 170u:
					Form3.smethod_25((ButtonBase)(object)LogoutBtn, (FlatStyle)0);
					Form3.smethod_20((Control)(object)LogoutBtn, Form3.smethod_19("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -217515623) ^ 0x5A9E8DE9;
					continue;
				case 169u:
					Form3.smethod_8((Control)(object)GroupBox3);
					num = ((int)num2 * -1544690760) ^ 0x36AB5550;
					continue;
				case 168u:
					Form3.smethod_13((Control)(object)GroupBox2, "GroupBox2");
					num = (int)((num2 * 790763959) ^ 0x41A697D5);
					continue;
				case 167u:
					Form3.smethod_20((Control)(object)GroupBox2, Form3.smethod_19("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -362032214) ^ -733397570;
					continue;
				case 166u:
					num = ((int)num2 * -1478538475) ^ -1141443407;
					continue;
				case 165u:
					Form3.smethod_10((Control)(object)this);
					num = (int)((num2 * 1423077027) ^ 0x517259DF);
					continue;
				case 164u:
					num = ((int)num2 * -455863541) ^ 0x4FD53BBB;
					continue;
				case 163u:
					num = (int)(num2 * 1544436074) ^ -986048885;
					continue;
				case 162u:
					Form3.smethod_15((Control)(object)Panel1, 7);
					num = (int)((num2 * 30283060) ^ 0x2F0AF568);
					continue;
				case 161u:
					Form3.smethod_13((Control)(object)SearchDonorBtn, "SearchDonorBtn");
					num = (int)((num2 * 293326257) ^ 0x35A222CE);
					continue;
				case 160u:
					num = ((int)num2 * -1069904009) ^ -1533276260;
					continue;
				case 159u:
					Form3.smethod_49((Control)(object)this, bool_0: false);
					num = ((int)num2 * -256553936) ^ 0x1976687D;
					continue;
				case 158u:
					num = ((int)num2 * -924186943) ^ -2049443853;
					continue;
				case 157u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox4), (Control)(object)BloodBankPanel1);
					num = (int)((num2 * 629915826) ^ 0x6105E017);
					continue;
				case 156u:
					num = ((int)num2 * -273092306) ^ -381062609;
					continue;
				case 155u:
					Form3.smethod_33(PictureBox1, bool_0: false);
					num = (int)((num2 * 1430147244) ^ 0x341F6436);
					continue;
				case 154u:
					Form3.smethod_28((ButtonBase)(object)SearchRecieverBtn, bool_0: true);
					Form3.smethod_24(Form3.smethod_23((ButtonBase)(object)SearchDonorBtn), 0);
					num = ((int)num2 * -1260062563) ^ 0x141AC569;
					continue;
				case 153u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox4), (Control)(object)BloodBankPanel2);
					num = (int)((num2 * 1185819812) ^ 0x59F6A491);
					continue;
				case 152u:
					Form3.smethod_20((Control)(object)SearchDonorBtn, Form3.smethod_19("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1852796039) ^ -772297717;
					continue;
				case 151u:
					num = ((int)num2 * -1199438794) ^ 0x32E0990B;
					continue;
				case 150u:
					num = ((int)num2 * -243080395) ^ 0x60A30032;
					continue;
				case 149u:
					Form3.smethod_34(Label2, bool_0: true);
					Form3.smethod_11((Control)(object)Label2, Color.Transparent);
					num = (int)(num2 * 757265029) ^ -2003126644;
					continue;
				case 148u:
					Form3.smethod_20((Control)(object)GroupBox4, Form3.smethod_19("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 863066924) ^ -1430605838;
					continue;
				case 147u:
					UpdateStaffBtn = Form3.smethod_5();
					num = ((int)num2 * -192099986) ^ -1192539234;
					continue;
				case 146u:
					Form3.smethod_12((Control)(object)Panel1, new Point(126, 141));
					Form3.smethod_13((Control)(object)Panel1, "Panel1");
					Form3.smethod_14((Control)(object)Panel1, new Size(380, 804));
					num = ((int)num2 * -2097222419) ^ 0x51C11DAB;
					continue;
				case 145u:
					Form3.smethod_20((Control)(object)BloodAvailabilityBtn, Form3.smethod_19("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1367776464) ^ -1841666928;
					continue;
				case 144u:
					Form3.smethod_22(GroupBox3, "Staff");
					num = (int)((num2 * 1407955890) ^ 0x6E7492E9);
					continue;
				case 143u:
					Form3.smethod_25((ButtonBase)(object)SearchRecieverBtn, (FlatStyle)0);
					num = (int)(num2 * 56486219) ^ -1708573767;
					continue;
				case 142u:
					num = (int)((num2 * 2146701619) ^ 0x6AF413B6);
					continue;
				case 141u:
					Form3.smethod_12((Control)(object)GroupBox3, new Point(13, 161));
					num = ((int)num2 * -154684120) ^ -1299126232;
					continue;
				case 140u:
					Form3.smethod_15((Control)(object)AdminPanel, 5);
					num = ((int)num2 * -878471375) ^ -1135715025;
					continue;
				case 139u:
					Form3.smethod_21(GroupBox2, bool_0: false);
					num = (int)(num2 * 1663592979) ^ -122982854;
					continue;
				case 138u:
					Form3.smethod_15((Control)(object)BloodAvailabilityBtn, 7);
					num = ((int)num2 * -1490211662) ^ 0x579E6157;
					continue;
				case 137u:
					Form3.smethod_28((ButtonBase)(object)AddStaffBtn, bool_0: true);
					num = (int)(num2 * 1345781043) ^ -679614874;
					continue;
				case 136u:
					num = ((int)num2 * -1418661448) ^ 0x7138F8D9;
					continue;
				case 135u:
					Form3.smethod_18(Form3.smethod_42((Control)(object)this), (Control)(object)Panel1);
					num = ((int)num2 * -1775452718) ^ -207059231;
					continue;
				case 134u:
					Form3.smethod_15((Control)(object)StaffPanel1, 5);
					num = (int)(num2 * 2059430913) ^ -1674891884;
					continue;
				case 133u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)(num2 * 1028843060) ^ -1047102372;
					continue;
				case 132u:
					num = (int)((num2 * 249128853) ^ 0x1E8C6271);
					continue;
				case 131u:
					Form3.smethod_12((Control)(object)GroupBox2, new Point(13, 20));
					num = (int)((num2 * 554668348) ^ 0x40526CA9);
					continue;
				case 130u:
					num = ((int)num2 * -1290130345) ^ -1529587316;
					continue;
				case 129u:
					Form3.smethod_14((Control)(object)PatientPanel2, new Size(44, 50));
					num = ((int)num2 * -1512133380) ^ 0x3AA610AD;
					continue;
				case 128u:
					Form3.smethod_13((Control)(object)BloodBankPanel1, "BloodBankPanel1");
					num = ((int)num2 * -1033127460) ^ 0x761C88E1;
					continue;
				case 127u:
					Form3.smethod_12((Control)(object)PatientPanel2, new Point(311, 43));
					num = (int)((num2 * 165903733) ^ 0x1BEEEEDB);
					continue;
				case 126u:
					num = ((int)num2 * -2058861065) ^ -1780860996;
					continue;
				case 125u:
					Form3.smethod_12((Control)(object)SearchPtntBtn, new Point(25, 43));
					num = (int)((num2 * 456067948) ^ 0x2EC76145);
					continue;
				case 124u:
					num = (int)(num2 * 190428197) ^ -2012482259;
					continue;
				case 123u:
					Form3.smethod_11((Control)(object)GroupBox2, Color.White);
					num = ((int)num2 * -1119079235) ^ 0x3170C4D9;
					continue;
				case 122u:
					Form3.smethod_24(Form3.smethod_23((ButtonBase)(object)AddStaffBtn), 0);
					num = ((int)num2 * -2028820327) ^ -1710276385;
					continue;
				case 121u:
					Form3.smethod_12((Control)(object)AdminPanel, new Point(716, 141));
					Form3.smethod_13((Control)(object)AdminPanel, "AdminPanel");
					num = (int)((num2 * 1436874906) ^ 0x6C75CF90);
					continue;
				case 120u:
					BloodBankPanel2 = Form3.smethod_3();
					num = (int)((num2 * 1653287122) ^ 0x7EFFAC8A);
					continue;
				case 119u:
					Form3.smethod_30(PictureBox1, (Image)(object)Resources.Hospital_blue_icon);
					num = (int)((num2 * 1648913318) ^ 0x18DF3666);
					continue;
				case 118u:
					num = (int)((num2 * 1713641155) ^ 0x2B7FF99C);
					continue;
				case 117u:
					Form3.smethod_28((ButtonBase)(object)EditProfileBtn, bool_0: true);
					num = ((int)num2 * -1198594491) ^ 0x33A9D223;
					continue;
				case 116u:
					Form3.smethod_12((Control)(object)BloodAvailabilityBtn, new Point(20, 138));
					Form3.smethod_26((Control)(object)BloodAvailabilityBtn, new Padding(0));
					Form3.smethod_13((Control)(object)BloodAvailabilityBtn, "BloodAvailabilityBtn");
					Form3.smethod_14((Control)(object)BloodAvailabilityBtn, new Size(316, 50));
					num = ((int)num2 * -664210086) ^ -465101738;
					continue;
				case 115u:
					num = ((int)num2 * -756754160) ^ -2019437061;
					continue;
				case 114u:
					num = (int)(num2 * 832147877) ^ -355002;
					continue;
				case 113u:
					Form3.smethod_25((ButtonBase)(object)SearchDonorBtn, (FlatStyle)0);
					num = ((int)num2 * -1609089472) ^ -1482403815;
					continue;
				case 112u:
					PatientPanel1 = Form3.smethod_3();
					num = ((int)num2 * -1091564118) ^ -1527830596;
					continue;
				case 111u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox3), (Control)(object)StaffPanel2);
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox3), (Control)(object)StaffPanel1);
					Form3.smethod_20((Control)(object)GroupBox3, Form3.smethod_19("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -715370503) ^ -1283718553;
					continue;
				case 110u:
					Form3.smethod_14((Control)(object)PictureBox1, new Size(106, 103));
					num = (int)((num2 * 1215466009) ^ 0x58CB117C);
					continue;
				case 109u:
					Form3.smethod_12((Control)(object)GroupBox5, new Point(13, 578));
					num = (int)(num2 * 1938290763) ^ -1557664528;
					continue;
				case 108u:
					num = (int)((num2 * 1410649913) ^ 0x731F11C3);
					continue;
				case 107u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox5), (Control)(object)PersonalInfoPanel1);
					Form3.smethod_20((Control)(object)GroupBox5, Form3.smethod_19("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1920560518) ^ 0x6227EEC5);
					continue;
				case 106u:
					Form3.smethod_26((Control)(object)GroupBox2, new Padding(0));
					num = ((int)num2 * -1364593122) ^ 0x11435EB7;
					continue;
				case 105u:
					Form3.smethod_16((ScrollableControl)(object)Panel1, bool_0: true);
					num = (int)(num2 * 730935860) ^ -112344781;
					continue;
				case 104u:
					Form3.smethod_14((Control)(object)GroupBox5, new Size(355, 177));
					num = (int)((num2 * 1816028617) ^ 0x55B4B6BA);
					continue;
				case 103u:
					SearchDonorBtn = Form3.smethod_5();
					num = (int)((num2 * 812051921) ^ 0x11269C25);
					continue;
				case 102u:
					Form3.smethod_20((Control)(object)AddStaffBtn, Form3.smethod_19("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = (int)(num2 * 1726415775) ^ -1636064555;
					continue;
				case 101u:
					Form3.smethod_14((Control)(object)BloodBankPanel1, new Size(44, 50));
					num = (int)(num2 * 717092160) ^ -1685529827;
					continue;
				case 100u:
					Form3.smethod_11((Control)(object)BloodBankPanel2, Color.Transparent);
					num = (int)((num2 * 2023549482) ^ 0x526C3BB2);
					continue;
				case 99u:
					Form3.smethod_13((Control)(object)SearchRecieverBtn, "SearchRecieverBtn");
					num = ((int)num2 * -1652570813) ^ 0x12752142;
					continue;
				case 98u:
					Form3.smethod_13((Control)(object)EditProfileBtn, "EditProfileBtn");
					Form3.smethod_14((Control)(object)EditProfileBtn, new Size(316, 50));
					num = (int)((num2 * 358172982) ^ 0x2106AD63);
					continue;
				case 97u:
					Label2 = Form3.smethod_7();
					num = ((int)num2 * -1023487657) ^ -1688916785;
					continue;
				case 96u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox4), (Control)(object)SearchDonorBtn);
					num = (int)((num2 * 1612196267) ^ 0x6F1DF7BA);
					continue;
				case 95u:
					num = ((int)num2 * -907807847) ^ -608131514;
					continue;
				case 94u:
					num = ((int)num2 * -1828901044) ^ 0x5248FC89;
					continue;
				case 93u:
					Form3.smethod_37(Label2, (ContentAlignment)32);
					num = (int)(num2 * 515743602) ^ -1306669128;
					continue;
				case 92u:
					Form3.smethod_27((ButtonBase)(object)BloodAvailabilityBtn, "Blood Availability");
					Form3.smethod_28((ButtonBase)(object)BloodAvailabilityBtn, bool_0: true);
					num = (int)(num2 * 287957358) ^ -207271186;
					continue;
				case 91u:
					Form3.smethod_12((Control)(object)BloodBankPanel1, new Point(0, 38));
					num = (int)((num2 * 1753665176) ^ 0x5B6F120F);
					continue;
				case 90u:
					Form3.smethod_13((Control)(object)GroupBox5, "GroupBox5");
					num = (int)((num2 * 302000375) ^ 0xA2B35DA);
					continue;
				case 89u:
					num = ((int)num2 * -1979601752) ^ 0x24D6C773;
					continue;
				case 88u:
					Form3.smethod_25((ButtonBase)(object)SearchPtntBtn, (FlatStyle)0);
					Form3.smethod_20((Control)(object)SearchPtntBtn, Form3.smethod_19("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -452672383) ^ 0x4E186B8D;
					continue;
				case 87u:
					Form3.smethod_20((Control)(object)UpdateStaffBtn, Form3.smethod_19("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					Form3.smethod_12((Control)(object)UpdateStaffBtn, new Point(20, 90));
					Form3.smethod_26((Control)(object)UpdateStaffBtn, new Padding(0));
					num = (int)((num2 * 475907336) ^ 0xB9C00B6);
					continue;
				case 86u:
					num = (int)((num2 * 1227929662) ^ 0x4B325C05);
					continue;
				case 85u:
					Form3.smethod_13((Control)(object)Label2, "Label2");
					num = (int)(num2 * 89188276) ^ -780122099;
					continue;
				case 84u:
					Form3.smethod_44((Control)(object)this, "Form3");
					Form3.smethod_45((Form)(object)this, "Form3");
					num = ((int)num2 * -654136498) ^ -1852830278;
					continue;
				case 83u:
					Form3.smethod_24(Form3.smethod_23((ButtonBase)(object)UpdateStaffBtn), 0);
					Form3.smethod_25((ButtonBase)(object)UpdateStaffBtn, (FlatStyle)0);
					num = ((int)num2 * -1766767401) ^ -460833793;
					continue;
				case 82u:
					Form3.smethod_24(Form3.smethod_23((ButtonBase)(object)EditProfileBtn), 0);
					num = ((int)num2 * -1937692584) ^ -346674078;
					continue;
				case 81u:
					SearchPtntBtn = Form3.smethod_5();
					num = ((int)num2 * -237312648) ^ 0x734207BF;
					continue;
				case 80u:
					Form3.smethod_12((Control)(object)Label2, new Point(428, 35));
					num = (int)((num2 * 301603713) ^ 0x424D06D0);
					continue;
				case 79u:
					Form3.smethod_14((Control)(object)GroupBox4, new Size(355, 210));
					num = (int)((num2 * 1844731288) ^ 0x51772DB8);
					continue;
				case 78u:
					Form3.smethod_20((Control)(object)Label2, Form3.smethod_19("Microsoft Sans Serif", 36f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -788525494) ^ -1557066512;
					continue;
				case 77u:
					Form3.smethod_38((ContainerControl)(object)this, new SizeF(8f, 16f));
					Form3.smethod_39((ContainerControl)(object)this, (AutoScaleMode)1);
					Form3.smethod_40((Form)(object)this, Color.MidnightBlue);
					Form3.smethod_41((Form)(object)this, new Size(1262, 953));
					num = ((int)num2 * -1619917336) ^ 0x6598943C;
					continue;
				case 76u:
					Form3.smethod_13((Control)(object)PatientPanel2, "PatientPanel2");
					num = ((int)num2 * -1030695961) ^ 0xF6E751F;
					continue;
				case 75u:
					num = (int)(num2 * 2083347637) ^ -1188801426;
					continue;
				case 74u:
					num = ((int)num2 * -1040096119) ^ -1040845780;
					continue;
				case 73u:
					Panel1 = Form3.smethod_3();
					num = ((int)num2 * -1866814192) ^ 0x4D29EE14;
					continue;
				case 72u:
					Form3.smethod_11((Control)(object)PatientPanel1, Color.Transparent);
					Form3.smethod_12((Control)(object)PatientPanel1, new Point(6, 43));
					num = (int)((num2 * 1344069279) ^ 0x6262961B);
					continue;
				case 71u:
					Form3.smethod_21(GroupBox3, bool_0: false);
					num = ((int)num2 * -1419118975) ^ 0x3F108D74;
					continue;
				case 70u:
					num = ((int)num2 * -1684752354) ^ -986160680;
					continue;
				case 69u:
					num = (int)(num2 * 372840123) ^ -2134346859;
					continue;
				case 68u:
					num = ((int)num2 * -239790741) ^ 0x4062A5D7;
					continue;
				case 67u:
					Form3.smethod_35((Control)(object)Label2, Color.White);
					num = ((int)num2 * -1597128947) ^ -1270676881;
					continue;
				case 66u:
					Form3.smethod_26((Control)(object)GroupBox4, new Padding(0));
					Form3.smethod_13((Control)(object)GroupBox4, "GroupBox4");
					num = (int)(num2 * 596605071) ^ -944942703;
					continue;
				case 65u:
					Form3.smethod_22(GroupBox2, "Patient");
					num = (int)(num2 * 73997669) ^ -1128506466;
					continue;
				case 64u:
					Form3.smethod_27((ButtonBase)(object)AddStaffBtn, "Add Staff");
					num = (int)(num2 * 1759761144) ^ -133401901;
					continue;
				case 63u:
					Form3.smethod_26((Control)(object)LogoutBtn, new Padding(0));
					num = (int)((num2 * 1341346705) ^ 0x7532107);
					continue;
				case 62u:
					num = ((int)num2 * -328925913) ^ -86493241;
					continue;
				case 61u:
					Form3.smethod_15((Control)(object)GroupBox3, 10);
					num = ((int)num2 * -1765456415) ^ -47425659;
					continue;
				case 60u:
					Form3.smethod_15((Control)(object)UpdateStaffBtn, 7);
					num = ((int)num2 * -1385443194) ^ 0x40FB6C57;
					continue;
				case 59u:
					Form3.smethod_14((Control)(object)StaffPanel1, new Size(44, 50));
					num = (int)(num2 * 1916273075) ^ -2057536484;
					continue;
				case 58u:
					num = ((int)num2 * -1369042102) ^ 0x871870E;
					continue;
				case 57u:
					PictureBox1 = Form3.smethod_6();
					num = ((int)num2 * -1568170144) ^ 0x4DBEACAB;
					continue;
				case 56u:
					Form3.smethod_47((Control)(object)GroupBox4, bool_0: false);
					num = ((int)num2 * -1952435915) ^ -128352511;
					continue;
				case 55u:
					Form3.smethod_27((ButtonBase)(object)LogoutBtn, "Logout");
					num = (int)((num2 * 1890017286) ^ 0x54228F0A);
					continue;
				case 54u:
					num = ((int)num2 * -1675724477) ^ 0x36567CC3;
					continue;
				case 53u:
					num = ((int)num2 * -679837617) ^ -452998852;
					continue;
				case 52u:
					Form3.smethod_47((Control)(object)GroupBox2, bool_0: false);
					num = (int)((num2 * 1561429690) ^ 0x7E1177AC);
					continue;
				case 51u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox5), (Control)(object)EditProfileBtn);
					num = ((int)num2 * -905182255) ^ 0x3584C8F;
					continue;
				case 50u:
					num = (int)((num2 * 991991670) ^ 0x6DA1BC69);
					continue;
				case 49u:
					Form3.smethod_46((Form)(object)this, (FormWindowState)2);
					Form3.smethod_47((Control)(object)Panel1, bool_0: false);
					num = ((int)num2 * -1353245554) ^ 0x91BCEC6;
					continue;
				case 48u:
					Form3.smethod_27((ButtonBase)(object)EditProfileBtn, "Edit Profile");
					num = ((int)num2 * -2124616844) ^ -93653969;
					continue;
				case 47u:
					GroupBox3 = Form3.smethod_4();
					num = (int)(num2 * 1220737897) ^ -1717552475;
					continue;
				case 46u:
					num = ((int)num2 * -283091458) ^ -642287714;
					continue;
				case 45u:
					EditProfileBtn = Form3.smethod_5();
					num = (int)(num2 * 1491434087) ^ -798476187;
					continue;
				case 44u:
					Form3.smethod_11((Control)(object)PatientPanel2, Color.Transparent);
					num = (int)(num2 * 1675168236) ^ -1526660273;
					continue;
				case 43u:
					num = ((int)num2 * -776430051) ^ 0xBBF6E4F;
					continue;
				case 42u:
					Form3.smethod_26((Control)(object)EditProfileBtn, new Padding(0));
					num = ((int)num2 * -932631377) ^ 0x1202E5F6;
					continue;
				case 41u:
					Form3.smethod_14((Control)(object)PersonalInfoPanel2, new Size(44, 50));
					num = ((int)num2 * -852026319) ^ 0x74B57AD5;
					continue;
				case 40u:
					Form3.smethod_12((Control)(object)EditProfileBtn, new Point(20, 52));
					num = (int)(num2 * 1016511394) ^ -1058765137;
					continue;
				case 39u:
					Form3.smethod_20((Control)(object)EditProfileBtn, Form3.smethod_19("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -315497970) ^ 0x6548E7B0;
					continue;
				case 38u:
					num = ((int)num2 * -1438056949) ^ 0x783F2693;
					continue;
				case 37u:
					num = (int)(num2 * 373861034) ^ -2087762584;
					continue;
				case 36u:
					Form3.smethod_12((Control)(object)AddStaffBtn, new Point(20, 37));
					num = (int)(num2 * 1727378268) ^ -1976845205;
					continue;
				case 35u:
					num = (int)((num2 * 1965446161) ^ 0x2BED2715);
					continue;
				case 34u:
					Form3.smethod_27((ButtonBase)(object)SearchRecieverBtn, "Search Reciever");
					num = (int)(num2 * 301637445) ^ -1010134714;
					continue;
				case 33u:
					Form3.smethod_28((ButtonBase)(object)LogoutBtn, bool_0: true);
					num = (int)(num2 * 527711649) ^ -454393331;
					continue;
				case 32u:
					PatientPanel2 = Form3.smethod_3();
					num = ((int)num2 * -820316224) ^ 0x3A992FF1;
					continue;
				case 31u:
					num = ((int)num2 * -45764549) ^ -1045438265;
					continue;
				case 30u:
					Form3.smethod_12((Control)(object)PictureBox1, new Point(307, 12));
					num = (int)((num2 * 2030917294) ^ 0x4DA88BA6);
					continue;
				case 29u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox2), (Control)(object)PatientPanel2);
					num = ((int)num2 * -1602101652) ^ -1258302962;
					continue;
				case 28u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)GroupBox4), (Control)(object)BloodAvailabilityBtn);
					num = (int)((num2 * 1803444399) ^ 0x424C3871);
					continue;
				case 27u:
					Form3.smethod_22(GroupBox5, "Personal Info");
					num = ((int)num2 * -1608547741) ^ 0x8F8CF76;
					continue;
				case 26u:
					Form3.smethod_12((Control)(object)LogoutBtn, new Point(20, 102));
					num = ((int)num2 * -1497623872) ^ 0x3B9DD5C1;
					continue;
				case 25u:
					Form3.smethod_24(Form3.smethod_23((ButtonBase)(object)SearchRecieverBtn), 0);
					num = (int)((num2 * 807295574) ^ 0x7698A53D);
					continue;
				case 24u:
					Form3.smethod_14((Control)(object)UpdateStaffBtn, new Size(316, 50));
					num = (int)((num2 * 106119038) ^ 0x29B9A605);
					continue;
				case 23u:
					Form3.smethod_15((Control)(object)EditProfileBtn, 5);
					num = ((int)num2 * -1888007059) ^ 0x2B0FCD8E;
					continue;
				case 22u:
					Form3.smethod_12((Control)(object)StaffPanel1, new Point(0, 37));
					num = (int)((num2 * 730137841) ^ 0x6A94B77C);
					continue;
				case 21u:
					Form3.smethod_14((Control)(object)AdminPanel, new Size(977, 804));
					num = ((int)num2 * -145256138) ^ -1044091945;
					continue;
				case 20u:
					num = (int)((num2 * 1674627717) ^ 0x8547EC1);
					continue;
				case 19u:
					Form3.smethod_13((Control)(object)BloodBankPanel2, "BloodBankPanel2");
					num = (int)((num2 * 1954164268) ^ 0x5723829A);
					continue;
				case 17u:
					num = (int)(num2 * 274307362) ^ -508135321;
					continue;
				case 16u:
					Form3.smethod_13((Control)(object)PatientPanel1, "PatientPanel1");
					Form3.smethod_14((Control)(object)PatientPanel1, new Size(44, 50));
					Form3.smethod_15((Control)(object)PatientPanel1, 0);
					num = ((int)num2 * -2089211686) ^ 0x74DB51E4;
					continue;
				case 15u:
					num = (int)(num2 * 2032710066) ^ -849895263;
					continue;
				case 14u:
					num = ((int)num2 * -125947176) ^ -1760134491;
					continue;
				case 13u:
					Form3.smethod_14((Control)(object)SearchRecieverBtn, new Size(316, 50));
					num = (int)(num2 * 93448121) ^ -1117901123;
					continue;
				case 12u:
					StaffPanel1 = Form3.smethod_3();
					num = ((int)num2 * -2048228912) ^ 0x27759A12;
					continue;
				case 11u:
					num = ((int)num2 * -1366117770) ^ -223344713;
					continue;
				case 10u:
					num = ((int)num2 * -1938249731) ^ 0x74221BBC;
					continue;
				case 9u:
					PersonalInfoPanel1 = Form3.smethod_3();
					num = ((int)num2 * -1245254782) ^ -34161143;
					continue;
				case 7u:
					Form3.smethod_27((ButtonBase)(object)SearchDonorBtn, "Search Donor");
					num = ((int)num2 * -1878422511) ^ 0x323C6761;
					continue;
				case 6u:
					Form3.smethod_12((Control)(object)GroupBox4, new Point(13, 344));
					num = ((int)num2 * -806554177) ^ -836502308;
					continue;
				case 5u:
					Form3.smethod_14((Control)(object)SearchPtntBtn, new Size(311, 50));
					Form3.smethod_15((Control)(object)SearchPtntBtn, 1);
					num = (int)(num2 * 298741288) ^ -619808645;
					continue;
				case 4u:
					Form3.smethod_8((Control)(object)GroupBox2);
					Form3.smethod_8((Control)(object)GroupBox4);
					num = (int)(num2 * 1721457186) ^ -1801813051;
					continue;
				case 3u:
					Form3.smethod_12((Control)(object)PersonalInfoPanel1, new Point(0, 52));
					Form3.smethod_13((Control)(object)PersonalInfoPanel1, "PersonalInfoPanel1");
					Form3.smethod_14((Control)(object)PersonalInfoPanel1, new Size(44, 50));
					num = (int)(num2 * 639600604) ^ -1625114105;
					continue;
				case 2u:
					AddStaffBtn = Form3.smethod_5();
					num = (int)((num2 * 1907227486) ^ 0x5DE67E5E);
					continue;
				case 1u:
					LogoutBtn = Form3.smethod_5();
					num = ((int)num2 * -1662331086) ^ 0x6740B83D;
					continue;
				case 0u:
					Form3.smethod_14((Control)(object)AddStaffBtn, new Size(316, 50));
					Form3.smethod_15((Control)(object)AddStaffBtn, 4);
					num = ((int)num2 * -1076262616) ^ -1585355727;
					continue;
				default:
					return;
				case 18u:
					break;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	private void AddStaffBtn_Click_1(object sender, EventArgs e)
	{
		Form3.smethod_11((Control)(object)PatientPanel1, Color.Transparent);
		Form3.smethod_11((Control)(object)PatientPanel2, Color.Transparent);
		Form3.smethod_11((Control)(object)BloodBankPanel1, Color.Transparent);
		while (true)
		{
			int num = -775554945;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF107BC5Eu) % 15u)
				{
				case 14u:
					Form3.smethod_54((Control)(object)StaffPanel2, Form3.smethod_53((Control)(object)AddStaffBtn));
					num = (int)(num2 * 1225404713) ^ -365329139;
					continue;
				case 13u:
					num = ((int)num2 * -1793600503) ^ -120933769;
					continue;
				case 12u:
					num = (int)((num2 * 836931445) ^ 0xBC640F6);
					continue;
				case 11u:
					num = (int)(num2 * 812806293) ^ -1793741904;
					continue;
				case 10u:
					Form3.smethod_11((Control)(object)StaffPanel1, Color.DarkBlue);
					Form3.smethod_55(Form3.smethod_17((Control)(object)AdminPanel));
					Form3.smethod_18(Form3.smethod_17((Control)(object)AdminPanel), (Control)(object)new AddStaff_Admin());
					num = ((int)num2 * -1917467218) ^ -1907826640;
					continue;
				case 9u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)((num2 * 935342849) ^ 0x588E70ED);
					continue;
				case 8u:
					Form3.smethod_54((Control)(object)StaffPanel1, Form3.smethod_53((Control)(object)AddStaffBtn));
					num = (int)((num2 * 724137701) ^ 0x55436D73);
					continue;
				case 7u:
					Form3.smethod_11((Control)(object)StaffPanel2, Color.DarkBlue);
					num = ((int)num2 * -1339886253) ^ -1250112485;
					continue;
				case 6u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = (int)((num2 * 1027330721) ^ 0x1AED36B2);
					continue;
				case 5u:
					num = (int)(num2 * 1713341619) ^ -1286812445;
					continue;
				case 3u:
					Form3.smethod_11((Control)(object)BloodBankPanel2, Color.Transparent);
					num = ((int)num2 * -906312796) ^ 0x339E0EAC;
					continue;
				case 2u:
					num = (int)(num2 * 1207001052) ^ -51122363;
					continue;
				case 1u:
					num = ((int)num2 * -333208197) ^ -180037260;
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

	private void UpdateStaffBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -2139450197;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDFF3B3BAu) % 16u)
				{
				case 14u:
					Form3.smethod_11((Control)(object)PatientPanel2, Color.Transparent);
					Form3.smethod_11((Control)(object)BloodBankPanel1, Color.Transparent);
					num = (int)(num2 * 1697722678) ^ -1519910517;
					continue;
				case 13u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = ((int)num2 * -1172217839) ^ 0x245B33BF;
					continue;
				case 12u:
					num = (int)((num2 * 1802945805) ^ 0x299310DC);
					continue;
				case 11u:
					num = ((int)num2 * -335810642) ^ 0x36D8DDB2;
					continue;
				case 10u:
					Form3.smethod_11((Control)(object)StaffPanel1, Color.DarkBlue);
					num = (int)((num2 * 228007107) ^ 0xD0CA24);
					continue;
				case 8u:
					Form3.smethod_54((Control)(object)StaffPanel1, Form3.smethod_53((Control)(object)UpdateStaffBtn));
					num = ((int)num2 * -310812896) ^ -911853492;
					continue;
				case 7u:
					num = ((int)num2 * -493427118) ^ -740961477;
					continue;
				case 6u:
					Form3.smethod_54((Control)(object)StaffPanel2, Form3.smethod_53((Control)(object)UpdateStaffBtn));
					num = (int)((num2 * 1908636821) ^ 0x75B8567F);
					continue;
				case 5u:
					Form3.smethod_11((Control)(object)BloodBankPanel2, Color.Transparent);
					Form3.smethod_11((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = ((int)num2 * -255884148) ^ 0x51B1901B;
					continue;
				case 4u:
					num = ((int)num2 * -1886984189) ^ -1489420155;
					continue;
				case 3u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)AdminPanel), (Control)(object)new UpdateStaff_Admin());
					num = ((int)num2 * -1230397488) ^ 0x1B7CC87D;
					continue;
				case 2u:
					Form3.smethod_11((Control)(object)StaffPanel2, Color.DarkBlue);
					num = (int)((num2 * 247586059) ^ 0x4FF91610);
					continue;
				case 1u:
					Form3.smethod_11((Control)(object)PatientPanel1, Color.Transparent);
					num = ((int)num2 * -2028180575) ^ 0x5D6AA335;
					continue;
				case 0u:
					Form3.smethod_55(Form3.smethod_17((Control)(object)AdminPanel));
					num = ((int)num2 * -536555607) ^ 0x610AAD7E;
					continue;
				default:
					return;
				case 9u:
					break;
				case 15u:
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
			int num = 650645385;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x71943A24u) % 21u)
				{
				case 20u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)AdminPanel), (Control)(object)new SearchDonor_Admin());
					num = ((int)num2 * -796604957) ^ 0x70519FD4;
					continue;
				case 19u:
					Form3.smethod_54((Control)(object)BloodBankPanel2, Form3.smethod_53((Control)(object)SearchDonorBtn));
					num = (int)(num2 * 698232664) ^ -879646390;
					continue;
				case 18u:
					num = ((int)num2 * -77116283) ^ -1378105875;
					continue;
				case 17u:
					Form3.smethod_11((Control)(object)StaffPanel1, Color.Transparent);
					num = (int)((num2 * 445797164) ^ 0x5C25D9ED);
					continue;
				case 16u:
					Form3.smethod_11((Control)(object)BloodBankPanel2, Color.DarkBlue);
					num = (int)((num2 * 689188152) ^ 0x74DAF2CA);
					continue;
				case 15u:
					num = ((int)num2 * -632307474) ^ -80159965;
					continue;
				case 14u:
					Form3.smethod_54((Control)(object)BloodBankPanel1, Form3.smethod_53((Control)(object)SearchDonorBtn));
					num = ((int)num2 * -1980527208) ^ 0x53C39A29;
					continue;
				case 13u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = ((int)num2 * -661238308) ^ 0x54FAAE95;
					continue;
				case 12u:
					Form3.smethod_11((Control)(object)PatientPanel1, Color.Transparent);
					num = (int)((num2 * 1901945538) ^ 0x5B145018);
					continue;
				case 10u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = (int)(num2 * 295402053) ^ -1612015540;
					continue;
				case 9u:
					num = ((int)num2 * -150421525) ^ 0x10DE5C4E;
					continue;
				case 8u:
					num = (int)((num2 * 1890590955) ^ 0x3A638957);
					continue;
				case 7u:
					Form3.smethod_11((Control)(object)PatientPanel2, Color.Transparent);
					num = (int)(num2 * 1725196897) ^ -1019281697;
					continue;
				case 5u:
					num = (int)((num2 * 981446079) ^ 0x619177);
					continue;
				case 4u:
					Form3.smethod_11((Control)(object)BloodBankPanel1, Color.DarkBlue);
					num = ((int)num2 * -653023931) ^ 0x64E5CDB6;
					continue;
				case 3u:
					Form3.smethod_11((Control)(object)StaffPanel2, Color.Transparent);
					num = (int)((num2 * 1295991445) ^ 0x1257AE89);
					continue;
				case 2u:
					Form3.smethod_55(Form3.smethod_17((Control)(object)AdminPanel));
					num = ((int)num2 * -729719191) ^ 0x2F96E475;
					continue;
				case 1u:
					num = (int)(num2 * 1470415334) ^ -807341253;
					continue;
				case 0u:
					num = (int)((num2 * 65847251) ^ 0x334338C9);
					continue;
				default:
					return;
				case 11u:
					break;
				case 6u:
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
			int num = 238266718;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE3D1AC7u) % 14u)
				{
				case 13u:
					Form3.smethod_11((Control)(object)StaffPanel1, Color.Transparent);
					num = (int)((num2 * 1462410651) ^ 0x5DDAF825);
					continue;
				case 12u:
					Form3.smethod_11((Control)(object)BloodBankPanel1, Color.DarkBlue);
					Form3.smethod_11((Control)(object)BloodBankPanel2, Color.DarkBlue);
					num = ((int)num2 * -186746860) ^ -181781537;
					continue;
				case 11u:
					Form3.smethod_54((Control)(object)BloodBankPanel2, Form3.smethod_53((Control)(object)SearchRecieverBtn));
					num = (int)(num2 * 414541965) ^ -472089773;
					continue;
				case 10u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)((num2 * 364915623) ^ 0x4B6104E3);
					continue;
				case 9u:
					num = (int)((num2 * 1618239451) ^ 0x782789E8);
					continue;
				case 7u:
					Form3.smethod_11((Control)(object)StaffPanel2, Color.Transparent);
					num = (int)((num2 * 1539756964) ^ 0x5E4DCA43);
					continue;
				case 6u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = (int)((num2 * 481252435) ^ 0x37DCE010);
					continue;
				case 5u:
					Form3.smethod_54((Control)(object)BloodBankPanel1, Form3.smethod_53((Control)(object)SearchRecieverBtn));
					num = ((int)num2 * -1315793454) ^ 0xE50FBAD;
					continue;
				case 4u:
					Form3.smethod_55(Form3.smethod_17((Control)(object)AdminPanel));
					Form3.smethod_18(Form3.smethod_17((Control)(object)AdminPanel), (Control)(object)new SearchReciever_Admin());
					num = (int)(num2 * 1214281937) ^ -421129301;
					continue;
				case 3u:
					num = (int)((num2 * 1811668317) ^ 0x45AA8EB);
					continue;
				case 1u:
					Form3.smethod_11((Control)(object)PatientPanel1, Color.Transparent);
					Form3.smethod_11((Control)(object)PatientPanel2, Color.Transparent);
					num = ((int)num2 * -695499142) ^ 0x5FD35A94;
					continue;
				case 0u:
					num = (int)(num2 * 1720386302) ^ -95984582;
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

	private void BloodAvailabilityBtn_Click(object sender, EventArgs e)
	{
		Form3.smethod_11((Control)(object)PatientPanel1, Color.Transparent);
		while (true)
		{
			int num = -1114139861;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF65282CEu) % 12u)
				{
				case 11u:
					Form3.smethod_11((Control)(object)StaffPanel2, Color.Transparent);
					Form3.smethod_11((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = ((int)num2 * -1680230670) ^ 0x35125C1D;
					continue;
				case 9u:
					Form3.smethod_11((Control)(object)BloodBankPanel1, Color.DarkBlue);
					num = (int)(num2 * 71603459) ^ -1366260723;
					continue;
				case 8u:
					Form3.smethod_54((Control)(object)BloodBankPanel1, Form3.smethod_53((Control)(object)BloodAvailabilityBtn));
					num = ((int)num2 * -889110089) ^ 0x4119BB68;
					continue;
				case 7u:
					Form3.smethod_11((Control)(object)StaffPanel1, Color.Transparent);
					num = (int)((num2 * 1874845305) ^ 0x604DC356);
					continue;
				case 6u:
					Form3.smethod_54((Control)(object)BloodBankPanel2, Form3.smethod_53((Control)(object)BloodAvailabilityBtn));
					num = ((int)num2 * -1148126708) ^ -297418661;
					continue;
				case 5u:
					Form3.smethod_11((Control)(object)PatientPanel2, Color.Transparent);
					num = (int)(num2 * 778063705) ^ -1321737828;
					continue;
				case 4u:
					Form3.smethod_11((Control)(object)BloodBankPanel2, Color.DarkBlue);
					Form3.smethod_55(Form3.smethod_17((Control)(object)AdminPanel));
					num = (int)(num2 * 2021001941) ^ -82026684;
					continue;
				case 3u:
					num = (int)(num2 * 783201103) ^ -140109999;
					continue;
				case 2u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)AdminPanel), (Control)(object)new BloodAvailability());
					num = ((int)num2 * -1680052029) ^ -1826129065;
					continue;
				case 1u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = ((int)num2 * -1365890306) ^ 0x7B63C34;
					continue;
				default:
					return;
				case 0u:
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
		while (true)
		{
			int num = -598509674;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA45483F3u) % 14u)
				{
				case 13u:
					num = ((int)num2 * -519056652) ^ 0x24996814;
					continue;
				case 12u:
					Form3.smethod_11((Control)(object)PatientPanel2, Color.Transparent);
					num = (int)((num2 * 1661662871) ^ 0x490E09FA);
					continue;
				case 11u:
					num = (int)(num2 * 2054677636) ^ -929378119;
					continue;
				case 10u:
					Form3.smethod_11((Control)(object)BloodBankPanel1, Color.Transparent);
					num = (int)((num2 * 1212940287) ^ 0x4B213145);
					continue;
				case 9u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel2, Color.DarkBlue);
					num = (int)((num2 * 2128812357) ^ 0x4E2CB222);
					continue;
				case 8u:
					Form3.smethod_11((Control)(object)BloodBankPanel2, Color.Transparent);
					Form3.smethod_11((Control)(object)StaffPanel2, Color.Transparent);
					num = (int)((num2 * 1055561595) ^ 0x4BACB2F9);
					continue;
				case 7u:
					Form3.smethod_11((Control)(object)PatientPanel1, Color.Transparent);
					num = ((int)num2 * -1693745689) ^ 0x5482FE27;
					continue;
				case 4u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel1, Color.DarkBlue);
					num = (int)((num2 * 332539451) ^ 0x2B3A1E36);
					continue;
				case 3u:
					num = (int)((num2 * 2115555973) ^ 0x7EB725F0);
					continue;
				case 2u:
					Form3.smethod_11((Control)(object)StaffPanel1, Color.Transparent);
					Form3.smethod_54((Control)(object)PersonalInfoPanel1, Form3.smethod_53((Control)(object)EditProfileBtn));
					num = (int)((num2 * 476215863) ^ 0x6C13E4D4);
					continue;
				case 1u:
					Form3.smethod_54((Control)(object)PersonalInfoPanel2, Form3.smethod_53((Control)(object)EditProfileBtn));
					num = ((int)num2 * -1323318009) ^ -104959362;
					continue;
				case 0u:
					Form3.smethod_55(Form3.smethod_17((Control)(object)AdminPanel));
					num = ((int)num2 * -2143401375) ^ 0x2B8F18B5;
					continue;
				case 5u:
					break;
				default:
					Form3.smethod_18(Form3.smethod_17((Control)(object)AdminPanel), (Control)(object)new EditProfile());
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
			int num = -729761519;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9F4D3EC6u) % 13u)
				{
				case 12u:
					Form3.smethod_11((Control)(object)StaffPanel2, Color.Transparent);
					Form3.smethod_11((Control)(object)StaffPanel1, Color.Transparent);
					num = (int)(num2 * 1730283334) ^ -1018823498;
					continue;
				case 11u:
					Form3.smethod_56((Form)(object)this);
					num = ((int)num2 * -1844332298) ^ -675158037;
					continue;
				case 9u:
					Form3.smethod_54((Control)(object)PersonalInfoPanel1, Form3.smethod_53((Control)(object)LogoutBtn));
					Form3.smethod_54((Control)(object)PersonalInfoPanel2, Form3.smethod_53((Control)(object)LogoutBtn));
					num = (int)(num2 * 356947032) ^ -1310255230;
					continue;
				case 8u:
					Form3.smethod_11((Control)(object)BloodBankPanel1, Color.Transparent);
					num = ((int)num2 * -95991764) ^ 0x71CBA685;
					continue;
				case 7u:
					Form3.smethod_57((Control)(object)MyProject.Forms.Form1);
					num = (int)((num2 * 548616690) ^ 0x9C5A95);
					continue;
				case 6u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel1, Color.DarkBlue);
					num = ((int)num2 * -82766108) ^ 0x6F9F3EE9;
					continue;
				case 4u:
					Form3.smethod_11((Control)(object)BloodBankPanel2, Color.Transparent);
					num = ((int)num2 * -975037328) ^ -2018289072;
					continue;
				case 3u:
					Form3.smethod_11((Control)(object)PatientPanel2, Color.Transparent);
					num = (int)((num2 * 522178514) ^ 0x5DE7F30B);
					continue;
				case 2u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel2, Color.DarkBlue);
					MyProject.Forms.Form1.username = "";
					MyProject.Forms.Form1.login_type = "";
					num = (int)(num2 * 1551785209) ^ -1650417797;
					continue;
				case 1u:
					Form3.smethod_11((Control)(object)PatientPanel1, Color.Transparent);
					num = (int)((num2 * 311529509) ^ 0x7201C9DF);
					continue;
				case 0u:
					num = (int)((num2 * 1729175322) ^ 0x2FC95A52);
					continue;
				default:
					return;
				case 5u:
					break;
				case 10u:
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
			int num = -1825195368;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCAB61614u) % 5u)
				{
				case 3u:
					MyProject.Forms.Form1.login_type = "";
					Form3.smethod_57((Control)(object)MyProject.Forms.Form1);
					num = ((int)num2 * -2127216752) ^ -283118158;
					continue;
				case 2u:
					MyProject.Forms.Form1.username = "";
					num = (int)((num2 * 1905993725) ^ 0x7EB6D27A);
					continue;
				case 1u:
					num = (int)((num2 * 621761511) ^ 0x39ACA236);
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

	private void SearchPtntBtn_Click(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 319194896;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x71795A3Cu) % 19u)
				{
				case 18u:
					num = (int)((num2 * 421755657) ^ 0x13074614);
					continue;
				case 17u:
					num = ((int)num2 * -1662947763) ^ -96799186;
					continue;
				case 16u:
					Form3.smethod_11((Control)(object)StaffPanel2, Color.Transparent);
					num = ((int)num2 * -1568895044) ^ 0x3C2658BB;
					continue;
				case 15u:
					num = (int)(num2 * 621234947) ^ -1723765120;
					continue;
				case 14u:
					Form3.smethod_11((Control)(object)PatientPanel2, Color.DarkBlue);
					num = ((int)num2 * -641820768) ^ -295098720;
					continue;
				case 13u:
					Form3.smethod_11((Control)(object)PatientPanel1, Color.DarkBlue);
					num = ((int)num2 * -841225181) ^ -566805646;
					continue;
				case 12u:
					Form3.smethod_18(Form3.smethod_17((Control)(object)AdminPanel), (Control)(object)new SearchPatient_Admin());
					num = (int)(num2 * 1556988351) ^ -772071521;
					continue;
				case 11u:
					num = ((int)num2 * -560730167) ^ 0x65D6D861;
					continue;
				case 10u:
					Form3.smethod_11((Control)(object)BloodBankPanel1, Color.Transparent);
					num = (int)(num2 * 712648652) ^ -555907756;
					continue;
				case 8u:
					Form3.smethod_54((Control)(object)PatientPanel2, Form3.smethod_53((Control)(object)SearchPtntBtn));
					num = ((int)num2 * -1621850204) ^ 0x381A0E2F;
					continue;
				case 7u:
					Form3.smethod_11((Control)(object)StaffPanel1, Color.Transparent);
					num = ((int)num2 * -2052545227) ^ -1210705142;
					continue;
				case 5u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel1, Color.Transparent);
					num = (int)(num2 * 2051676953) ^ -40404302;
					continue;
				case 4u:
					Form3.smethod_54((Control)(object)PatientPanel1, Form3.smethod_53((Control)(object)SearchPtntBtn));
					num = ((int)num2 * -447925328) ^ 0x6168E3BF;
					continue;
				case 3u:
					Form3.smethod_55(Form3.smethod_17((Control)(object)AdminPanel));
					num = (int)(num2 * 1639447383) ^ -1724036982;
					continue;
				case 2u:
					Form3.smethod_11((Control)(object)BloodBankPanel2, Color.Transparent);
					num = (int)((num2 * 252216154) ^ 0x3F975AE5);
					continue;
				case 1u:
					Form3.smethod_11((Control)(object)PersonalInfoPanel2, Color.Transparent);
					num = ((int)num2 * -91542524) ^ -29911743;
					continue;
				case 0u:
					num = ((int)num2 * -622880674) ^ 0x6587FA91;
					continue;
				default:
					return;
				case 9u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	private void Form3_Shown(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1512867461;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEDA148D0u) % 3u)
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
				Form3.smethod_58((Control)(object)this);
				num = (int)(num2 * 1477724850) ^ -1715847964;
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
