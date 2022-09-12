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
			EventHandler eventHandler = LogoutBtn_Click;
			Button logoutBtn = _LogoutBtn;
			if (logoutBtn != null)
			{
				((Control)logoutBtn).remove_Click(eventHandler);
			}
			_LogoutBtn = value;
			logoutBtn = _LogoutBtn;
			if (logoutBtn != null)
			{
				((Control)logoutBtn).add_Click(eventHandler);
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
			EventHandler eventHandler = EditProfileBtn_Click;
			Button editProfileBtn = _EditProfileBtn;
			if (editProfileBtn != null)
			{
				((Control)editProfileBtn).remove_Click(eventHandler);
			}
			_EditProfileBtn = value;
			editProfileBtn = _EditProfileBtn;
			if (editProfileBtn != null)
			{
				((Control)editProfileBtn).add_Click(eventHandler);
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
			EventHandler eventHandler = UpdateStaffBtn_Click;
			Button updateStaffBtn = _UpdateStaffBtn;
			if (updateStaffBtn != null)
			{
				((Control)updateStaffBtn).remove_Click(eventHandler);
			}
			_UpdateStaffBtn = value;
			updateStaffBtn = _UpdateStaffBtn;
			if (updateStaffBtn != null)
			{
				((Control)updateStaffBtn).add_Click(eventHandler);
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
			EventHandler eventHandler = AddStaffBtn_Click_1;
			Button addStaffBtn = _AddStaffBtn;
			if (addStaffBtn != null)
			{
				((Control)addStaffBtn).remove_Click(eventHandler);
			}
			_AddStaffBtn = value;
			addStaffBtn = _AddStaffBtn;
			if (addStaffBtn != null)
			{
				((Control)addStaffBtn).add_Click(eventHandler);
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
			EventHandler eventHandler = SearchPtntBtn_Click;
			Button searchPtntBtn = _SearchPtntBtn;
			if (searchPtntBtn != null)
			{
				((Control)searchPtntBtn).remove_Click(eventHandler);
			}
			_SearchPtntBtn = value;
			searchPtntBtn = _SearchPtntBtn;
			if (searchPtntBtn != null)
			{
				((Control)searchPtntBtn).add_Click(eventHandler);
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
			EventHandler eventHandler = BloodAvailabilityBtn_Click;
			Button bloodAvailabilityBtn = _BloodAvailabilityBtn;
			if (bloodAvailabilityBtn != null)
			{
				((Control)bloodAvailabilityBtn).remove_Click(eventHandler);
			}
			_BloodAvailabilityBtn = value;
			bloodAvailabilityBtn = _BloodAvailabilityBtn;
			if (bloodAvailabilityBtn != null)
			{
				((Control)bloodAvailabilityBtn).add_Click(eventHandler);
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
			EventHandler eventHandler = SearchRecieverBtn_Click;
			Button searchRecieverBtn = _SearchRecieverBtn;
			if (searchRecieverBtn != null)
			{
				((Control)searchRecieverBtn).remove_Click(eventHandler);
			}
			_SearchRecieverBtn = value;
			searchRecieverBtn = _SearchRecieverBtn;
			if (searchRecieverBtn != null)
			{
				((Control)searchRecieverBtn).add_Click(eventHandler);
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
			EventHandler eventHandler = SearchDonorBtn_Click;
			Button searchDonorBtn = _SearchDonorBtn;
			if (searchDonorBtn != null)
			{
				((Control)searchDonorBtn).remove_Click(eventHandler);
			}
			_SearchDonorBtn = value;
			searchDonorBtn = _SearchDonorBtn;
			if (searchDonorBtn != null)
			{
				((Control)searchDonorBtn).add_Click(eventHandler);
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
		((Form)this).add_FormClosed(new FormClosedEventHandler(Form3_FormClosed));
		((Form)this).add_Shown((EventHandler)Form3_Shown);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected O, but got Unknown
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected O, but got Unknown
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Expected O, but got Unknown
		//IL_0667: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Expected O, but got Unknown
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0715: Unknown result type (might be due to invalid IL or missing references)
		//IL_071f: Expected O, but got Unknown
		//IL_073a: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ac: Expected O, but got Unknown
		//IL_08c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Unknown result type (might be due to invalid IL or missing references)
		//IL_096b: Expected O, but got Unknown
		//IL_0986: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b14: Expected O, but got Unknown
		//IL_0b32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc9: Expected O, but got Unknown
		//IL_0be7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7a: Expected O, but got Unknown
		//IL_0c95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d28: Expected O, but got Unknown
		//IL_0d43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef1: Expected O, but got Unknown
		AdminPanel = new Panel();
		Panel1 = new Panel();
		GroupBox5 = new GroupBox();
		LogoutBtn = new Button();
		EditProfileBtn = new Button();
		PersonalInfoPanel2 = new Panel();
		PersonalInfoPanel1 = new Panel();
		GroupBox3 = new GroupBox();
		UpdateStaffBtn = new Button();
		AddStaffBtn = new Button();
		StaffPanel2 = new Panel();
		StaffPanel1 = new Panel();
		GroupBox2 = new GroupBox();
		SearchPtntBtn = new Button();
		PatientPanel2 = new Panel();
		PatientPanel1 = new Panel();
		GroupBox4 = new GroupBox();
		BloodAvailabilityBtn = new Button();
		SearchRecieverBtn = new Button();
		SearchDonorBtn = new Button();
		BloodBankPanel2 = new Panel();
		BloodBankPanel1 = new Panel();
		PictureBox1 = new PictureBox();
		Label2 = new Label();
		((Control)Panel1).SuspendLayout();
		((Control)GroupBox5).SuspendLayout();
		((Control)GroupBox3).SuspendLayout();
		((Control)GroupBox2).SuspendLayout();
		((Control)GroupBox4).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)AdminPanel).set_BackColor(Color.White);
		((Control)AdminPanel).set_Location(new Point(716, 141));
		((Control)AdminPanel).set_Name("AdminPanel");
		((Control)AdminPanel).set_Size(new Size(977, 804));
		((Control)AdminPanel).set_TabIndex(5);
		((ScrollableControl)Panel1).set_AutoScroll(true);
		((Control)Panel1).set_BackColor(Color.White);
		((Control)Panel1).get_Controls().Add((Control)(object)GroupBox5);
		((Control)Panel1).get_Controls().Add((Control)(object)GroupBox3);
		((Control)Panel1).get_Controls().Add((Control)(object)GroupBox2);
		((Control)Panel1).get_Controls().Add((Control)(object)GroupBox4);
		((Control)Panel1).set_Location(new Point(126, 141));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(380, 804));
		((Control)Panel1).set_TabIndex(7);
		((Control)GroupBox5).get_Controls().Add((Control)(object)LogoutBtn);
		((Control)GroupBox5).get_Controls().Add((Control)(object)EditProfileBtn);
		((Control)GroupBox5).get_Controls().Add((Control)(object)PersonalInfoPanel2);
		((Control)GroupBox5).get_Controls().Add((Control)(object)PersonalInfoPanel1);
		((Control)GroupBox5).set_Font(new Font("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox5).set_Location(new Point(13, 578));
		((Control)GroupBox5).set_Name("GroupBox5");
		((Control)GroupBox5).set_Size(new Size(355, 177));
		((Control)GroupBox5).set_TabIndex(12);
		GroupBox5.set_TabStop(false);
		GroupBox5.set_Text("Personal Info");
		((ButtonBase)LogoutBtn).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)LogoutBtn).set_FlatStyle((FlatStyle)0);
		((Control)LogoutBtn).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)LogoutBtn).set_Location(new Point(20, 102));
		((Control)LogoutBtn).set_Margin(new Padding(0));
		((Control)LogoutBtn).set_Name("LogoutBtn");
		((Control)LogoutBtn).set_Size(new Size(316, 50));
		((Control)LogoutBtn).set_TabIndex(6);
		((ButtonBase)LogoutBtn).set_Text("Logout");
		((ButtonBase)LogoutBtn).set_UseVisualStyleBackColor(true);
		((ButtonBase)EditProfileBtn).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)EditProfileBtn).set_FlatStyle((FlatStyle)0);
		((Control)EditProfileBtn).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)EditProfileBtn).set_Location(new Point(20, 52));
		((Control)EditProfileBtn).set_Margin(new Padding(0));
		((Control)EditProfileBtn).set_Name("EditProfileBtn");
		((Control)EditProfileBtn).set_Size(new Size(316, 50));
		((Control)EditProfileBtn).set_TabIndex(5);
		((ButtonBase)EditProfileBtn).set_Text("Edit Profile");
		((ButtonBase)EditProfileBtn).set_UseVisualStyleBackColor(true);
		((Control)PersonalInfoPanel2).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel2).set_Location(new Point(311, 52));
		((Control)PersonalInfoPanel2).set_Name("PersonalInfoPanel2");
		((Control)PersonalInfoPanel2).set_Size(new Size(44, 50));
		((Control)PersonalInfoPanel2).set_TabIndex(16);
		((Control)PersonalInfoPanel1).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel1).set_Location(new Point(0, 52));
		((Control)PersonalInfoPanel1).set_Name("PersonalInfoPanel1");
		((Control)PersonalInfoPanel1).set_Size(new Size(44, 50));
		((Control)PersonalInfoPanel1).set_TabIndex(15);
		((Control)GroupBox3).get_Controls().Add((Control)(object)UpdateStaffBtn);
		((Control)GroupBox3).get_Controls().Add((Control)(object)AddStaffBtn);
		((Control)GroupBox3).get_Controls().Add((Control)(object)StaffPanel2);
		((Control)GroupBox3).get_Controls().Add((Control)(object)StaffPanel1);
		((Control)GroupBox3).set_Font(new Font("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox3).set_Location(new Point(13, 161));
		((Control)GroupBox3).set_Name("GroupBox3");
		((Control)GroupBox3).set_Size(new Size(355, 165));
		((Control)GroupBox3).set_TabIndex(10);
		GroupBox3.set_TabStop(false);
		GroupBox3.set_Text("Staff");
		((ButtonBase)UpdateStaffBtn).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)UpdateStaffBtn).set_FlatStyle((FlatStyle)0);
		((Control)UpdateStaffBtn).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)UpdateStaffBtn).set_Location(new Point(20, 90));
		((Control)UpdateStaffBtn).set_Margin(new Padding(0));
		((Control)UpdateStaffBtn).set_Name("UpdateStaffBtn");
		((Control)UpdateStaffBtn).set_Size(new Size(316, 50));
		((Control)UpdateStaffBtn).set_TabIndex(7);
		((ButtonBase)UpdateStaffBtn).set_Text("Update Staff");
		((ButtonBase)UpdateStaffBtn).set_UseVisualStyleBackColor(true);
		((ButtonBase)AddStaffBtn).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)AddStaffBtn).set_FlatStyle((FlatStyle)0);
		((Control)AddStaffBtn).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)AddStaffBtn).set_Location(new Point(20, 37));
		((Control)AddStaffBtn).set_Margin(new Padding(0));
		((Control)AddStaffBtn).set_Name("AddStaffBtn");
		((Control)AddStaffBtn).set_Size(new Size(316, 50));
		((Control)AddStaffBtn).set_TabIndex(4);
		((ButtonBase)AddStaffBtn).set_Text("Add Staff");
		((ButtonBase)AddStaffBtn).set_UseVisualStyleBackColor(true);
		((Control)StaffPanel2).set_BackColor(Color.Transparent);
		((Control)StaffPanel2).set_Location(new Point(311, 37));
		((Control)StaffPanel2).set_Name("StaffPanel2");
		((Control)StaffPanel2).set_Size(new Size(44, 50));
		((Control)StaffPanel2).set_TabIndex(6);
		((Control)StaffPanel1).set_BackColor(Color.Transparent);
		((Control)StaffPanel1).set_Location(new Point(0, 37));
		((Control)StaffPanel1).set_Name("StaffPanel1");
		((Control)StaffPanel1).set_Size(new Size(44, 50));
		((Control)StaffPanel1).set_TabIndex(5);
		((Control)GroupBox2).set_BackColor(Color.White);
		((Control)GroupBox2).get_Controls().Add((Control)(object)SearchPtntBtn);
		((Control)GroupBox2).get_Controls().Add((Control)(object)PatientPanel2);
		((Control)GroupBox2).get_Controls().Add((Control)(object)PatientPanel1);
		((Control)GroupBox2).set_Font(new Font("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox2).set_Location(new Point(13, 20));
		((Control)GroupBox2).set_Margin(new Padding(0));
		((Control)GroupBox2).set_Name("GroupBox2");
		((Control)GroupBox2).set_Size(new Size(355, 114));
		((Control)GroupBox2).set_TabIndex(9);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("Patient");
		((ButtonBase)SearchPtntBtn).set_BackColor(Color.White);
		((ButtonBase)SearchPtntBtn).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)SearchPtntBtn).set_FlatStyle((FlatStyle)0);
		((Control)SearchPtntBtn).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)SearchPtntBtn).set_Location(new Point(25, 43));
		((Control)SearchPtntBtn).set_Margin(new Padding(0));
		((Control)SearchPtntBtn).set_Name("SearchPtntBtn");
		((Control)SearchPtntBtn).set_Size(new Size(311, 50));
		((Control)SearchPtntBtn).set_TabIndex(1);
		((ButtonBase)SearchPtntBtn).set_Text("Search Patient");
		((ButtonBase)SearchPtntBtn).set_UseVisualStyleBackColor(false);
		((Control)PatientPanel2).set_BackColor(Color.Transparent);
		((Control)PatientPanel2).set_Location(new Point(311, 43));
		((Control)PatientPanel2).set_Name("PatientPanel2");
		((Control)PatientPanel2).set_Size(new Size(44, 50));
		((Control)PatientPanel2).set_TabIndex(6);
		((Control)PatientPanel1).set_BackColor(Color.Transparent);
		((Control)PatientPanel1).set_Location(new Point(6, 43));
		((Control)PatientPanel1).set_Name("PatientPanel1");
		((Control)PatientPanel1).set_Size(new Size(44, 50));
		((Control)PatientPanel1).set_TabIndex(0);
		((Control)GroupBox4).get_Controls().Add((Control)(object)BloodAvailabilityBtn);
		((Control)GroupBox4).get_Controls().Add((Control)(object)SearchRecieverBtn);
		((Control)GroupBox4).get_Controls().Add((Control)(object)SearchDonorBtn);
		((Control)GroupBox4).get_Controls().Add((Control)(object)BloodBankPanel2);
		((Control)GroupBox4).get_Controls().Add((Control)(object)BloodBankPanel1);
		((Control)GroupBox4).set_Font(new Font("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox4).set_Location(new Point(13, 344));
		((Control)GroupBox4).set_Margin(new Padding(0));
		((Control)GroupBox4).set_Name("GroupBox4");
		((Control)GroupBox4).set_Size(new Size(355, 210));
		((Control)GroupBox4).set_TabIndex(11);
		GroupBox4.set_TabStop(false);
		GroupBox4.set_Text("Blood Bank");
		((ButtonBase)BloodAvailabilityBtn).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)BloodAvailabilityBtn).set_FlatStyle((FlatStyle)0);
		((Control)BloodAvailabilityBtn).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)BloodAvailabilityBtn).set_Location(new Point(20, 138));
		((Control)BloodAvailabilityBtn).set_Margin(new Padding(0));
		((Control)BloodAvailabilityBtn).set_Name("BloodAvailabilityBtn");
		((Control)BloodAvailabilityBtn).set_Size(new Size(316, 50));
		((Control)BloodAvailabilityBtn).set_TabIndex(7);
		((ButtonBase)BloodAvailabilityBtn).set_Text("Blood Availability");
		((ButtonBase)BloodAvailabilityBtn).set_UseVisualStyleBackColor(true);
		((ButtonBase)SearchRecieverBtn).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)SearchRecieverBtn).set_FlatStyle((FlatStyle)0);
		((Control)SearchRecieverBtn).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)SearchRecieverBtn).set_Location(new Point(20, 88));
		((Control)SearchRecieverBtn).set_Margin(new Padding(0));
		((Control)SearchRecieverBtn).set_Name("SearchRecieverBtn");
		((Control)SearchRecieverBtn).set_Size(new Size(316, 50));
		((Control)SearchRecieverBtn).set_TabIndex(6);
		((ButtonBase)SearchRecieverBtn).set_Text("Search Reciever");
		((ButtonBase)SearchRecieverBtn).set_UseVisualStyleBackColor(true);
		((ButtonBase)SearchDonorBtn).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)SearchDonorBtn).set_FlatStyle((FlatStyle)0);
		((Control)SearchDonorBtn).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)SearchDonorBtn).set_Location(new Point(20, 38));
		((Control)SearchDonorBtn).set_Margin(new Padding(0));
		((Control)SearchDonorBtn).set_Name("SearchDonorBtn");
		((Control)SearchDonorBtn).set_Size(new Size(316, 50));
		((Control)SearchDonorBtn).set_TabIndex(5);
		((ButtonBase)SearchDonorBtn).set_Text("Search Donor");
		((ButtonBase)SearchDonorBtn).set_UseVisualStyleBackColor(true);
		((Control)BloodBankPanel2).set_BackColor(Color.Transparent);
		((Control)BloodBankPanel2).set_Location(new Point(311, 38));
		((Control)BloodBankPanel2).set_Name("BloodBankPanel2");
		((Control)BloodBankPanel2).set_Size(new Size(44, 50));
		((Control)BloodBankPanel2).set_TabIndex(15);
		((Control)BloodBankPanel1).set_BackColor(Color.Transparent);
		((Control)BloodBankPanel1).set_Location(new Point(0, 38));
		((Control)BloodBankPanel1).set_Name("BloodBankPanel1");
		((Control)BloodBankPanel1).set_Size(new Size(44, 50));
		((Control)BloodBankPanel1).set_TabIndex(14);
		PictureBox1.set_Image((Image)(object)Resources.Hospital_blue_icon);
		((Control)PictureBox1).set_Location(new Point(307, 12));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(106, 103));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(9);
		PictureBox1.set_TabStop(false);
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(Color.Transparent);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 36f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.White);
		((Control)Label2).set_Location(new Point(428, 35));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(845, 69));
		((Control)Label2).set_TabIndex(8);
		Label2.set_Text("Golisano's Hospital Of Florida");
		Label2.set_TextAlign((ContentAlignment)32);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.MidnightBlue);
		((Form)this).set_ClientSize(new Size(1262, 953));
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)AdminPanel);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form3");
		((Form)this).set_Text("Form3");
		((Form)this).set_WindowState((FormWindowState)2);
		((Control)Panel1).ResumeLayout(false);
		((Control)GroupBox5).ResumeLayout(false);
		((Control)GroupBox3).ResumeLayout(false);
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox4).ResumeLayout(false);
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void AddStaffBtn_Click_1(object sender, EventArgs e)
	{
		((Control)PatientPanel1).set_BackColor(Color.Transparent);
		((Control)PatientPanel2).set_BackColor(Color.Transparent);
		((Control)BloodBankPanel1).set_BackColor(Color.Transparent);
		((Control)BloodBankPanel2).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel1).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel2).set_BackColor(Color.Transparent);
		((Control)StaffPanel1).set_Top(((Control)AddStaffBtn).get_Top());
		((Control)StaffPanel2).set_Top(((Control)AddStaffBtn).get_Top());
		((Control)StaffPanel2).set_BackColor(Color.DarkBlue);
		((Control)StaffPanel1).set_BackColor(Color.DarkBlue);
		((Control)AdminPanel).get_Controls().Clear();
		((Control)AdminPanel).get_Controls().Add((Control)(object)new AddStaff_Admin());
	}

	private void UpdateStaffBtn_Click(object sender, EventArgs e)
	{
		((Control)PatientPanel1).set_BackColor(Color.Transparent);
		((Control)PatientPanel2).set_BackColor(Color.Transparent);
		((Control)BloodBankPanel1).set_BackColor(Color.Transparent);
		((Control)BloodBankPanel2).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel1).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel2).set_BackColor(Color.Transparent);
		((Control)StaffPanel1).set_Top(((Control)UpdateStaffBtn).get_Top());
		((Control)StaffPanel2).set_Top(((Control)UpdateStaffBtn).get_Top());
		((Control)StaffPanel2).set_BackColor(Color.DarkBlue);
		((Control)StaffPanel1).set_BackColor(Color.DarkBlue);
		((Control)AdminPanel).get_Controls().Clear();
		((Control)AdminPanel).get_Controls().Add((Control)(object)new UpdateStaff_Admin());
	}

	private void SearchDonorBtn_Click(object sender, EventArgs e)
	{
		((Control)PatientPanel1).set_BackColor(Color.Transparent);
		((Control)PatientPanel2).set_BackColor(Color.Transparent);
		((Control)StaffPanel1).set_BackColor(Color.Transparent);
		((Control)StaffPanel2).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel1).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel2).set_BackColor(Color.Transparent);
		((Control)BloodBankPanel1).set_Top(((Control)SearchDonorBtn).get_Top());
		((Control)BloodBankPanel2).set_Top(((Control)SearchDonorBtn).get_Top());
		((Control)BloodBankPanel1).set_BackColor(Color.DarkBlue);
		((Control)BloodBankPanel2).set_BackColor(Color.DarkBlue);
		((Control)AdminPanel).get_Controls().Clear();
		((Control)AdminPanel).get_Controls().Add((Control)(object)new SearchDonor_Admin());
	}

	private void SearchRecieverBtn_Click(object sender, EventArgs e)
	{
		((Control)PatientPanel1).set_BackColor(Color.Transparent);
		((Control)PatientPanel2).set_BackColor(Color.Transparent);
		((Control)StaffPanel1).set_BackColor(Color.Transparent);
		((Control)StaffPanel2).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel1).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel2).set_BackColor(Color.Transparent);
		((Control)BloodBankPanel1).set_Top(((Control)SearchRecieverBtn).get_Top());
		((Control)BloodBankPanel2).set_Top(((Control)SearchRecieverBtn).get_Top());
		((Control)BloodBankPanel1).set_BackColor(Color.DarkBlue);
		((Control)BloodBankPanel2).set_BackColor(Color.DarkBlue);
		((Control)AdminPanel).get_Controls().Clear();
		((Control)AdminPanel).get_Controls().Add((Control)(object)new SearchReciever_Admin());
	}

	private void BloodAvailabilityBtn_Click(object sender, EventArgs e)
	{
		((Control)PatientPanel1).set_BackColor(Color.Transparent);
		((Control)PatientPanel2).set_BackColor(Color.Transparent);
		((Control)StaffPanel1).set_BackColor(Color.Transparent);
		((Control)StaffPanel2).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel1).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel2).set_BackColor(Color.Transparent);
		((Control)BloodBankPanel1).set_Top(((Control)BloodAvailabilityBtn).get_Top());
		((Control)BloodBankPanel2).set_Top(((Control)BloodAvailabilityBtn).get_Top());
		((Control)BloodBankPanel1).set_BackColor(Color.DarkBlue);
		((Control)BloodBankPanel2).set_BackColor(Color.DarkBlue);
		((Control)AdminPanel).get_Controls().Clear();
		((Control)AdminPanel).get_Controls().Add((Control)(object)new BloodAvailability());
	}

	private void EditProfileBtn_Click(object sender, EventArgs e)
	{
		((Control)PatientPanel1).set_BackColor(Color.Transparent);
		((Control)PatientPanel2).set_BackColor(Color.Transparent);
		((Control)BloodBankPanel1).set_BackColor(Color.Transparent);
		((Control)BloodBankPanel2).set_BackColor(Color.Transparent);
		((Control)StaffPanel2).set_BackColor(Color.Transparent);
		((Control)StaffPanel1).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel1).set_Top(((Control)EditProfileBtn).get_Top());
		((Control)PersonalInfoPanel2).set_Top(((Control)EditProfileBtn).get_Top());
		((Control)PersonalInfoPanel1).set_BackColor(Color.DarkBlue);
		((Control)PersonalInfoPanel2).set_BackColor(Color.DarkBlue);
		((Control)AdminPanel).get_Controls().Clear();
		((Control)AdminPanel).get_Controls().Add((Control)(object)new EditProfile());
	}

	private void LogoutBtn_Click(object sender, EventArgs e)
	{
		((Control)PatientPanel1).set_BackColor(Color.Transparent);
		((Control)PatientPanel2).set_BackColor(Color.Transparent);
		((Control)BloodBankPanel1).set_BackColor(Color.Transparent);
		((Control)BloodBankPanel2).set_BackColor(Color.Transparent);
		((Control)StaffPanel2).set_BackColor(Color.Transparent);
		((Control)StaffPanel1).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel1).set_Top(((Control)LogoutBtn).get_Top());
		((Control)PersonalInfoPanel2).set_Top(((Control)LogoutBtn).get_Top());
		((Control)PersonalInfoPanel1).set_BackColor(Color.DarkBlue);
		((Control)PersonalInfoPanel2).set_BackColor(Color.DarkBlue);
		MyProject.Forms.Form1.username = "";
		MyProject.Forms.Form1.login_type = "";
		((Form)this).Close();
		((Control)MyProject.Forms.Form1).Show();
	}

	private void Form3_FormClosed(object sender, FormClosedEventArgs e)
	{
		MyProject.Forms.Form1.username = "";
		MyProject.Forms.Form1.login_type = "";
		((Control)MyProject.Forms.Form1).Show();
	}

	private void SearchPtntBtn_Click(object sender, EventArgs e)
	{
		((Control)BloodBankPanel1).set_BackColor(Color.Transparent);
		((Control)BloodBankPanel2).set_BackColor(Color.Transparent);
		((Control)StaffPanel2).set_BackColor(Color.Transparent);
		((Control)StaffPanel1).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel1).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel2).set_BackColor(Color.Transparent);
		((Control)PatientPanel1).set_Top(((Control)SearchPtntBtn).get_Top());
		((Control)PatientPanel2).set_Top(((Control)SearchPtntBtn).get_Top());
		((Control)PatientPanel1).set_BackColor(Color.DarkBlue);
		((Control)PatientPanel2).set_BackColor(Color.DarkBlue);
		((Control)AdminPanel).get_Controls().Clear();
		((Control)AdminPanel).get_Controls().Add((Control)(object)new SearchPatient_Admin());
	}

	private void Form3_Shown(object sender, EventArgs e)
	{
		((Control)this).Refresh();
	}
}
