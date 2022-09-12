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
			EventHandler eventHandler = AvailabilityBtn_Click;
			Button availabilityBtn = _AvailabilityBtn;
			if (availabilityBtn != null)
			{
				((Control)availabilityBtn).remove_Click(eventHandler);
			}
			_AvailabilityBtn = value;
			availabilityBtn = _AvailabilityBtn;
			if (availabilityBtn != null)
			{
				((Control)availabilityBtn).add_Click(eventHandler);
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
			EventHandler eventHandler = CheckUpBtn_Click;
			Button checkUpBtn = _CheckUpBtn;
			if (checkUpBtn != null)
			{
				((Control)checkUpBtn).remove_Click(eventHandler);
			}
			_CheckUpBtn = value;
			checkUpBtn = _CheckUpBtn;
			if (checkUpBtn != null)
			{
				((Control)checkUpBtn).add_Click(eventHandler);
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
			EventHandler eventHandler = UpdateDetailsBtn_Click;
			Button updateDetailsBtn = _UpdateDetailsBtn;
			if (updateDetailsBtn != null)
			{
				((Control)updateDetailsBtn).remove_Click(eventHandler);
			}
			_UpdateDetailsBtn = value;
			updateDetailsBtn = _UpdateDetailsBtn;
			if (updateDetailsBtn != null)
			{
				((Control)updateDetailsBtn).add_Click(eventHandler);
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
			EventHandler eventHandler = AdmitBtn_Click;
			Button admitBtn = _AdmitBtn;
			if (admitBtn != null)
			{
				((Control)admitBtn).remove_Click(eventHandler);
			}
			_AdmitBtn = value;
			admitBtn = _AdmitBtn;
			if (admitBtn != null)
			{
				((Control)admitBtn).add_Click(eventHandler);
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
			EventHandler eventHandler = RegistrationBtn_Click;
			Button registrationBtn = _RegistrationBtn;
			if (registrationBtn != null)
			{
				((Control)registrationBtn).remove_Click(eventHandler);
			}
			_RegistrationBtn = value;
			registrationBtn = _RegistrationBtn;
			if (registrationBtn != null)
			{
				((Control)registrationBtn).add_Click(eventHandler);
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
			EventHandler eventHandler = RegisterRecieverBtn_Click;
			Button registerRecieverBtn = _RegisterRecieverBtn;
			if (registerRecieverBtn != null)
			{
				((Control)registerRecieverBtn).remove_Click(eventHandler);
			}
			_RegisterRecieverBtn = value;
			registerRecieverBtn = _RegisterRecieverBtn;
			if (registerRecieverBtn != null)
			{
				((Control)registerRecieverBtn).add_Click(eventHandler);
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
			EventHandler eventHandler = RegisterDonorBtn_Click;
			Button registerDonorBtn = _RegisterDonorBtn;
			if (registerDonorBtn != null)
			{
				((Control)registerDonorBtn).remove_Click(eventHandler);
			}
			_RegisterDonorBtn = value;
			registerDonorBtn = _RegisterDonorBtn;
			if (registerDonorBtn != null)
			{
				((Control)registerDonorBtn).add_Click(eventHandler);
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
		((Form)this).add_FormClosed(new FormClosedEventHandler(Form2_FormClosed));
		((Form)this).add_Shown((EventHandler)Form2_Shown);
		((Form)this).add_Load((EventHandler)Form2_Load);
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
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected O, but got Unknown
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Expected O, but got Unknown
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Expected O, but got Unknown
		//IL_0714: Unknown result type (might be due to invalid IL or missing references)
		//IL_071e: Expected O, but got Unknown
		//IL_0739: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ed: Expected O, but got Unknown
		//IL_0908: Unknown result type (might be due to invalid IL or missing references)
		//IL_0995: Unknown result type (might be due to invalid IL or missing references)
		//IL_099f: Expected O, but got Unknown
		//IL_09ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4d: Expected O, but got Unknown
		//IL_0a6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afe: Expected O, but got Unknown
		//IL_0b1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbf: Expected O, but got Unknown
		//IL_0bda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb7: Expected O, but got Unknown
		//IL_0d7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d85: Expected O, but got Unknown
		//IL_0da3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3a: Expected O, but got Unknown
		//IL_0e58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eeb: Expected O, but got Unknown
		//IL_0f06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f99: Expected O, but got Unknown
		//IL_0fb4: Unknown result type (might be due to invalid IL or missing references)
		Label1 = new Label();
		StaffPanel = new Panel();
		Panel1 = new Panel();
		GroupBox5 = new GroupBox();
		LogoutBtn = new Button();
		EditProfileBtn = new Button();
		PersonalInfoPanel2 = new Panel();
		PersonalInfoPanel1 = new Panel();
		GroupBox3 = new GroupBox();
		AvailabilityBtn = new Button();
		StaffPanel2 = new Panel();
		StaffPanel1 = new Panel();
		GroupBox2 = new GroupBox();
		CheckUpBtn = new Button();
		UpdateDetailsBtn = new Button();
		AdmitBtn = new Button();
		RegistrationBtn = new Button();
		PatientPanel2 = new Panel();
		PatientPanel1 = new Panel();
		GroupBox4 = new GroupBox();
		BloodAvailabilityBtn = new Button();
		RegisterRecieverBtn = new Button();
		RegisterDonorBtn = new Button();
		BloodBankPanel2 = new Panel();
		BloodBankPanel1 = new Panel();
		PictureBox1 = new PictureBox();
		((Control)Panel1).SuspendLayout();
		((Control)GroupBox5).SuspendLayout();
		((Control)GroupBox3).SuspendLayout();
		((Control)GroupBox2).SuspendLayout();
		((Control)GroupBox4).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 36f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.White);
		((Control)Label1).set_Location(new Point(428, 35));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(845, 69));
		((Control)Label1).set_TabIndex(2);
		Label1.set_Text("Golisano's Hospital Of Florida");
		Label1.set_TextAlign((ContentAlignment)32);
		((ScrollableControl)StaffPanel).set_AutoScroll(true);
		((Control)StaffPanel).set_BackColor(Color.White);
		((Control)StaffPanel).set_Location(new Point(716, 141));
		((Control)StaffPanel).set_Name("StaffPanel");
		((Control)StaffPanel).set_Size(new Size(977, 825));
		((Control)StaffPanel).set_TabIndex(3);
		((Control)Panel1).set_BackColor(Color.White);
		((Control)Panel1).get_Controls().Add((Control)(object)GroupBox5);
		((Control)Panel1).get_Controls().Add((Control)(object)GroupBox3);
		((Control)Panel1).get_Controls().Add((Control)(object)GroupBox2);
		((Control)Panel1).get_Controls().Add((Control)(object)GroupBox4);
		((Control)Panel1).set_Location(new Point(126, 141));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(380, 825));
		((Control)Panel1).set_TabIndex(6);
		((Control)GroupBox5).get_Controls().Add((Control)(object)LogoutBtn);
		((Control)GroupBox5).get_Controls().Add((Control)(object)EditProfileBtn);
		((Control)GroupBox5).get_Controls().Add((Control)(object)PersonalInfoPanel2);
		((Control)GroupBox5).get_Controls().Add((Control)(object)PersonalInfoPanel1);
		((Control)GroupBox5).set_Font(new Font("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox5).set_Location(new Point(13, 647));
		((Control)GroupBox5).set_Name("GroupBox5");
		((Control)GroupBox5).set_Size(new Size(351, 173));
		((Control)GroupBox5).set_TabIndex(12);
		GroupBox5.set_TabStop(false);
		GroupBox5.set_Text("Personal Info");
		((ButtonBase)LogoutBtn).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)LogoutBtn).set_FlatStyle((FlatStyle)0);
		((Control)LogoutBtn).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)LogoutBtn).set_Location(new Point(20, 102));
		((Control)LogoutBtn).set_Margin(new Padding(0));
		((Control)LogoutBtn).set_Name("LogoutBtn");
		((Control)LogoutBtn).set_Size(new Size(311, 50));
		((Control)LogoutBtn).set_TabIndex(6);
		((ButtonBase)LogoutBtn).set_Text("Logout");
		((ButtonBase)LogoutBtn).set_UseVisualStyleBackColor(true);
		((ButtonBase)EditProfileBtn).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)EditProfileBtn).set_FlatStyle((FlatStyle)0);
		((Control)EditProfileBtn).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)EditProfileBtn).set_Location(new Point(20, 52));
		((Control)EditProfileBtn).set_Margin(new Padding(0));
		((Control)EditProfileBtn).set_Name("EditProfileBtn");
		((Control)EditProfileBtn).set_Size(new Size(311, 50));
		((Control)EditProfileBtn).set_TabIndex(5);
		((ButtonBase)EditProfileBtn).set_Text("Edit Profile");
		((ButtonBase)EditProfileBtn).set_UseVisualStyleBackColor(true);
		((Control)PersonalInfoPanel2).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel2).set_Location(new Point(307, 52));
		((Control)PersonalInfoPanel2).set_Name("PersonalInfoPanel2");
		((Control)PersonalInfoPanel2).set_Size(new Size(44, 50));
		((Control)PersonalInfoPanel2).set_TabIndex(16);
		((Control)PersonalInfoPanel1).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel1).set_Location(new Point(0, 52));
		((Control)PersonalInfoPanel1).set_Name("PersonalInfoPanel1");
		((Control)PersonalInfoPanel1).set_Size(new Size(44, 50));
		((Control)PersonalInfoPanel1).set_TabIndex(15);
		((Control)GroupBox3).get_Controls().Add((Control)(object)AvailabilityBtn);
		((Control)GroupBox3).get_Controls().Add((Control)(object)StaffPanel2);
		((Control)GroupBox3).get_Controls().Add((Control)(object)StaffPanel1);
		((Control)GroupBox3).set_Font(new Font("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox3).set_Location(new Point(13, 311));
		((Control)GroupBox3).set_Name("GroupBox3");
		((Control)GroupBox3).set_Size(new Size(351, 114));
		((Control)GroupBox3).set_TabIndex(10);
		GroupBox3.set_TabStop(false);
		GroupBox3.set_Text("Staff");
		((ButtonBase)AvailabilityBtn).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)AvailabilityBtn).set_FlatStyle((FlatStyle)0);
		((Control)AvailabilityBtn).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)AvailabilityBtn).set_Location(new Point(20, 37));
		((Control)AvailabilityBtn).set_Margin(new Padding(0));
		((Control)AvailabilityBtn).set_Name("AvailabilityBtn");
		((Control)AvailabilityBtn).set_Size(new Size(311, 50));
		((Control)AvailabilityBtn).set_TabIndex(4);
		((ButtonBase)AvailabilityBtn).set_Text("Availability");
		((ButtonBase)AvailabilityBtn).set_UseVisualStyleBackColor(true);
		((Control)StaffPanel2).set_BackColor(Color.Transparent);
		((Control)StaffPanel2).set_Location(new Point(307, 37));
		((Control)StaffPanel2).set_Name("StaffPanel2");
		((Control)StaffPanel2).set_Size(new Size(44, 50));
		((Control)StaffPanel2).set_TabIndex(6);
		((Control)StaffPanel1).set_BackColor(Color.Transparent);
		((Control)StaffPanel1).set_Location(new Point(0, 37));
		((Control)StaffPanel1).set_Name("StaffPanel1");
		((Control)StaffPanel1).set_Size(new Size(44, 50));
		((Control)StaffPanel1).set_TabIndex(5);
		((Control)GroupBox2).set_BackColor(Color.White);
		((Control)GroupBox2).get_Controls().Add((Control)(object)CheckUpBtn);
		((Control)GroupBox2).get_Controls().Add((Control)(object)UpdateDetailsBtn);
		((Control)GroupBox2).get_Controls().Add((Control)(object)AdmitBtn);
		((Control)GroupBox2).get_Controls().Add((Control)(object)RegistrationBtn);
		((Control)GroupBox2).get_Controls().Add((Control)(object)PatientPanel2);
		((Control)GroupBox2).get_Controls().Add((Control)(object)PatientPanel1);
		((Control)GroupBox2).set_Font(new Font("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox2).set_Location(new Point(13, 9));
		((Control)GroupBox2).set_Margin(new Padding(0));
		((Control)GroupBox2).set_Name("GroupBox2");
		((Control)GroupBox2).set_Size(new Size(351, 267));
		((Control)GroupBox2).set_TabIndex(9);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("Patient");
		((ButtonBase)CheckUpBtn).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)CheckUpBtn).set_FlatStyle((FlatStyle)0);
		((Control)CheckUpBtn).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)CheckUpBtn).set_Location(new Point(25, 96));
		((Control)CheckUpBtn).set_Margin(new Padding(0));
		((Control)CheckUpBtn).set_Name("CheckUpBtn");
		((Control)CheckUpBtn).set_Size(new Size(306, 50));
		((Control)CheckUpBtn).set_TabIndex(2);
		((ButtonBase)CheckUpBtn).set_Text("Check-Up");
		((ButtonBase)CheckUpBtn).set_UseVisualStyleBackColor(true);
		((ButtonBase)UpdateDetailsBtn).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)UpdateDetailsBtn).set_FlatStyle((FlatStyle)0);
		((Control)UpdateDetailsBtn).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)UpdateDetailsBtn).set_Location(new Point(25, 196));
		((Control)UpdateDetailsBtn).set_Margin(new Padding(0));
		((Control)UpdateDetailsBtn).set_Name("UpdateDetailsBtn");
		((Control)UpdateDetailsBtn).set_Size(new Size(306, 50));
		((Control)UpdateDetailsBtn).set_TabIndex(4);
		((ButtonBase)UpdateDetailsBtn).set_Text("Update Details");
		((ButtonBase)UpdateDetailsBtn).set_UseVisualStyleBackColor(true);
		((ButtonBase)AdmitBtn).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)AdmitBtn).set_FlatStyle((FlatStyle)0);
		((Control)AdmitBtn).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)AdmitBtn).set_Location(new Point(25, 146));
		((Control)AdmitBtn).set_Margin(new Padding(0));
		((Control)AdmitBtn).set_Name("AdmitBtn");
		((Control)AdmitBtn).set_Size(new Size(306, 50));
		((Control)AdmitBtn).set_TabIndex(3);
		((ButtonBase)AdmitBtn).set_Text("Admit/Discharge");
		((ButtonBase)AdmitBtn).set_UseVisualStyleBackColor(true);
		((ButtonBase)RegistrationBtn).set_BackColor(Color.White);
		((ButtonBase)RegistrationBtn).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)RegistrationBtn).set_FlatStyle((FlatStyle)0);
		((Control)RegistrationBtn).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)RegistrationBtn).set_Location(new Point(25, 43));
		((Control)RegistrationBtn).set_Margin(new Padding(0));
		((Control)RegistrationBtn).set_Name("RegistrationBtn");
		((Control)RegistrationBtn).set_Size(new Size(306, 50));
		((Control)RegistrationBtn).set_TabIndex(1);
		((ButtonBase)RegistrationBtn).set_Text("Registration");
		((ButtonBase)RegistrationBtn).set_UseVisualStyleBackColor(false);
		((Control)PatientPanel2).set_BackColor(Color.Transparent);
		((Control)PatientPanel2).set_Location(new Point(307, 43));
		((Control)PatientPanel2).set_Name("PatientPanel2");
		((Control)PatientPanel2).set_Size(new Size(44, 50));
		((Control)PatientPanel2).set_TabIndex(6);
		((Control)PatientPanel1).set_BackColor(Color.Transparent);
		((Control)PatientPanel1).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)PatientPanel1).set_Location(new Point(6, 43));
		((Control)PatientPanel1).set_Name("PatientPanel1");
		((Control)PatientPanel1).set_Size(new Size(44, 50));
		((Control)PatientPanel1).set_TabIndex(0);
		((Control)GroupBox4).get_Controls().Add((Control)(object)BloodAvailabilityBtn);
		((Control)GroupBox4).get_Controls().Add((Control)(object)RegisterRecieverBtn);
		((Control)GroupBox4).get_Controls().Add((Control)(object)RegisterDonorBtn);
		((Control)GroupBox4).get_Controls().Add((Control)(object)BloodBankPanel2);
		((Control)GroupBox4).get_Controls().Add((Control)(object)BloodBankPanel1);
		((Control)GroupBox4).set_Font(new Font("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox4).set_Location(new Point(13, 440));
		((Control)GroupBox4).set_Margin(new Padding(0));
		((Control)GroupBox4).set_Name("GroupBox4");
		((Control)GroupBox4).set_Size(new Size(351, 204));
		((Control)GroupBox4).set_TabIndex(11);
		GroupBox4.set_TabStop(false);
		GroupBox4.set_Text("Blood Bank");
		((ButtonBase)BloodAvailabilityBtn).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)BloodAvailabilityBtn).set_FlatStyle((FlatStyle)0);
		((Control)BloodAvailabilityBtn).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)BloodAvailabilityBtn).set_Location(new Point(20, 138));
		((Control)BloodAvailabilityBtn).set_Margin(new Padding(0));
		((Control)BloodAvailabilityBtn).set_Name("BloodAvailabilityBtn");
		((Control)BloodAvailabilityBtn).set_Size(new Size(311, 50));
		((Control)BloodAvailabilityBtn).set_TabIndex(7);
		((ButtonBase)BloodAvailabilityBtn).set_Text("Blood Availability");
		((ButtonBase)BloodAvailabilityBtn).set_UseVisualStyleBackColor(true);
		((ButtonBase)RegisterRecieverBtn).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)RegisterRecieverBtn).set_FlatStyle((FlatStyle)0);
		((Control)RegisterRecieverBtn).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)RegisterRecieverBtn).set_Location(new Point(20, 88));
		((Control)RegisterRecieverBtn).set_Margin(new Padding(0));
		((Control)RegisterRecieverBtn).set_Name("RegisterRecieverBtn");
		((Control)RegisterRecieverBtn).set_Size(new Size(311, 50));
		((Control)RegisterRecieverBtn).set_TabIndex(6);
		((ButtonBase)RegisterRecieverBtn).set_Text("Register Reciever");
		((ButtonBase)RegisterRecieverBtn).set_UseVisualStyleBackColor(true);
		((ButtonBase)RegisterDonorBtn).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)RegisterDonorBtn).set_FlatStyle((FlatStyle)0);
		((Control)RegisterDonorBtn).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)RegisterDonorBtn).set_Location(new Point(20, 38));
		((Control)RegisterDonorBtn).set_Margin(new Padding(0));
		((Control)RegisterDonorBtn).set_Name("RegisterDonorBtn");
		((Control)RegisterDonorBtn).set_Size(new Size(311, 50));
		((Control)RegisterDonorBtn).set_TabIndex(5);
		((ButtonBase)RegisterDonorBtn).set_Text("Register Donor");
		((ButtonBase)RegisterDonorBtn).set_UseVisualStyleBackColor(true);
		((Control)BloodBankPanel2).set_BackColor(Color.Transparent);
		((Control)BloodBankPanel2).set_Location(new Point(307, 38));
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
		PictureBox1.set_TabIndex(7);
		PictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.MidnightBlue);
		((Form)this).set_ClientSize(new Size(1285, 973));
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)StaffPanel);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).set_Name("Form2");
		((Form)this).set_SizeGripStyle((SizeGripStyle)1);
		((Form)this).set_Text("Form2");
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

	private void CheckUpBtn_Click(object sender, EventArgs e)
	{
		((Control)BloodBankPanel1).set_BackColor(Color.Transparent);
		((Control)BloodBankPanel2).set_BackColor(Color.Transparent);
		((Control)StaffPanel2).set_BackColor(Color.Transparent);
		((Control)StaffPanel1).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel1).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel2).set_BackColor(Color.Transparent);
		((Control)PatientPanel1).set_Top(((Control)CheckUpBtn).get_Top());
		((Control)PatientPanel2).set_Top(((Control)CheckUpBtn).get_Top());
		((Control)PatientPanel1).set_BackColor(Color.DarkBlue);
		((Control)PatientPanel2).set_BackColor(Color.DarkBlue);
		((Control)StaffPanel).get_Controls().Clear();
		((Control)StaffPanel).get_Controls().Add((Control)(object)new CheckUp());
	}

	private void RegistrationBtn_Click(object sender, EventArgs e)
	{
		((Control)BloodBankPanel1).set_BackColor(Color.Transparent);
		((Control)BloodBankPanel2).set_BackColor(Color.Transparent);
		((Control)StaffPanel2).set_BackColor(Color.Transparent);
		((Control)StaffPanel1).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel1).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel2).set_BackColor(Color.Transparent);
		((Control)PatientPanel1).set_Top(((Control)RegistrationBtn).get_Top());
		((Control)PatientPanel2).set_Top(((Control)RegistrationBtn).get_Top());
		((Control)PatientPanel1).set_BackColor(Color.DarkBlue);
		((Control)PatientPanel2).set_BackColor(Color.DarkBlue);
		((Control)StaffPanel).get_Controls().Clear();
		((Control)StaffPanel).get_Controls().Add((Control)(object)new Registration());
	}

	private void AdmitBtn_Click(object sender, EventArgs e)
	{
		((Control)BloodBankPanel1).set_BackColor(Color.Transparent);
		((Control)BloodBankPanel2).set_BackColor(Color.Transparent);
		((Control)StaffPanel2).set_BackColor(Color.Transparent);
		((Control)StaffPanel1).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel1).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel2).set_BackColor(Color.Transparent);
		((Control)PatientPanel1).set_Top(((Control)AdmitBtn).get_Top());
		((Control)PatientPanel2).set_Top(((Control)AdmitBtn).get_Top());
		((Control)PatientPanel1).set_BackColor(Color.DarkBlue);
		((Control)PatientPanel2).set_BackColor(Color.DarkBlue);
		((Control)StaffPanel).get_Controls().Clear();
		((Control)StaffPanel).get_Controls().Add((Control)(object)new Admit());
	}

	private void UpdateDetailsBtn_Click(object sender, EventArgs e)
	{
		((Control)BloodBankPanel1).set_BackColor(Color.Transparent);
		((Control)BloodBankPanel2).set_BackColor(Color.Transparent);
		((Control)StaffPanel2).set_BackColor(Color.Transparent);
		((Control)StaffPanel1).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel1).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel2).set_BackColor(Color.Transparent);
		((Control)PatientPanel1).set_Top(((Control)UpdateDetailsBtn).get_Top());
		((Control)PatientPanel2).set_Top(((Control)UpdateDetailsBtn).get_Top());
		((Control)PatientPanel1).set_BackColor(Color.DarkBlue);
		((Control)PatientPanel2).set_BackColor(Color.DarkBlue);
		((Control)StaffPanel).get_Controls().Clear();
		((Control)StaffPanel).get_Controls().Add((Control)(object)new UpdateDetails());
	}

	private void RegisterRecieverBtn_Click(object sender, EventArgs e)
	{
		((Control)PatientPanel1).set_BackColor(Color.Transparent);
		((Control)PatientPanel2).set_BackColor(Color.Transparent);
		((Control)StaffPanel1).set_BackColor(Color.Transparent);
		((Control)StaffPanel2).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel1).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel2).set_BackColor(Color.Transparent);
		((Control)BloodBankPanel1).set_Top(((Control)RegisterRecieverBtn).get_Top());
		((Control)BloodBankPanel2).set_Top(((Control)RegisterRecieverBtn).get_Top());
		((Control)BloodBankPanel1).set_BackColor(Color.DarkBlue);
		((Control)BloodBankPanel2).set_BackColor(Color.DarkBlue);
		((Control)StaffPanel).get_Controls().Clear();
		((Control)StaffPanel).get_Controls().Add((Control)(object)new RegisterReciever());
	}

	private void AvailabilityBtn_Click(object sender, EventArgs e)
	{
		((Control)PatientPanel1).set_BackColor(Color.Transparent);
		((Control)PatientPanel2).set_BackColor(Color.Transparent);
		((Control)BloodBankPanel1).set_BackColor(Color.Transparent);
		((Control)BloodBankPanel2).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel1).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel2).set_BackColor(Color.Transparent);
		((Control)StaffPanel2).set_BackColor(Color.DarkBlue);
		((Control)StaffPanel1).set_BackColor(Color.DarkBlue);
		((Control)StaffPanel).get_Controls().Clear();
		((Control)StaffPanel).get_Controls().Add((Control)(object)new Availability());
	}

	private void RegisterDonorBtn_Click(object sender, EventArgs e)
	{
		((Control)PatientPanel1).set_BackColor(Color.Transparent);
		((Control)PatientPanel2).set_BackColor(Color.Transparent);
		((Control)StaffPanel1).set_BackColor(Color.Transparent);
		((Control)StaffPanel2).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel1).set_BackColor(Color.Transparent);
		((Control)PersonalInfoPanel2).set_BackColor(Color.Transparent);
		((Control)BloodBankPanel1).set_Top(((Control)RegisterDonorBtn).get_Top());
		((Control)BloodBankPanel2).set_Top(((Control)RegisterDonorBtn).get_Top());
		((Control)BloodBankPanel1).set_BackColor(Color.DarkBlue);
		((Control)BloodBankPanel2).set_BackColor(Color.DarkBlue);
		((Control)StaffPanel).get_Controls().Clear();
		((Control)StaffPanel).get_Controls().Add((Control)(object)new RegisterDonor());
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
		((Control)StaffPanel).get_Controls().Clear();
		((Control)StaffPanel).get_Controls().Add((Control)(object)new BloodAvailability());
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
		((Control)StaffPanel).get_Controls().Clear();
		((Control)StaffPanel).get_Controls().Add((Control)(object)new EditProfile());
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
		((Control)StaffPanel).get_Controls().Clear();
		MyProject.Forms.Form1.username = "";
		MyProject.Forms.Form1.login_type = "";
		((Form)this).Close();
		((Control)MyProject.Forms.Form1).Show();
	}

	private void Form2_FormClosed(object sender, FormClosedEventArgs e)
	{
		MyProject.Forms.Form1.username = "";
		MyProject.Forms.Form1.login_type = "";
		((Control)MyProject.Forms.Form1).Show();
	}

	private void Form2_Shown(object sender, EventArgs e)
	{
		((Control)this).Refresh();
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		((Form)this).set_AutoSize(true);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
	}
}
