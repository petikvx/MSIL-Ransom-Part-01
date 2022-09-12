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
			EventHandler eventHandler = UpdateBtn_Click;
			Button updateBtn = _UpdateBtn;
			if (updateBtn != null)
			{
				((Control)updateBtn).remove_Click(eventHandler);
			}
			_UpdateBtn = value;
			updateBtn = _UpdateBtn;
			if (updateBtn != null)
			{
				((Control)updateBtn).add_Click(eventHandler);
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
			EventHandler eventHandler = CheckBox1_CheckedChanged;
			CheckBox checkBox = _CheckBox1;
			if (checkBox != null)
			{
				checkBox.remove_CheckedChanged(eventHandler);
			}
			_CheckBox1 = value;
			checkBox = _CheckBox1;
			if (checkBox != null)
			{
				checkBox.add_CheckedChanged(eventHandler);
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
			EventHandler eventHandler = ChangePasswdBtn_Click;
			Button changePasswdBtn = _ChangePasswdBtn;
			if (changePasswdBtn != null)
			{
				((Control)changePasswdBtn).remove_Click(eventHandler);
			}
			_ChangePasswdBtn = value;
			changePasswdBtn = _ChangePasswdBtn;
			if (changePasswdBtn != null)
			{
				((Control)changePasswdBtn).add_Click(eventHandler);
			}
		}
	}

	public EditProfile()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		((UserControl)this).add_Load((EventHandler)EditProfile_Load);
		myconnection = new OleDbConnection();
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
			((ContainerControl)this).Dispose(disposing);
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
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected O, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected O, but got Unknown
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected O, but got Unknown
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected O, but got Unknown
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0577: Expected O, but got Unknown
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected O, but got Unknown
		//IL_0670: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Expected O, but got Unknown
		//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fb: Expected O, but got Unknown
		//IL_0775: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Expected O, but got Unknown
		//IL_07f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fd: Expected O, but got Unknown
		//IL_0869: Unknown result type (might be due to invalid IL or missing references)
		//IL_0873: Expected O, but got Unknown
		//IL_08d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dd: Expected O, but got Unknown
		//IL_0949: Unknown result type (might be due to invalid IL or missing references)
		//IL_0953: Expected O, but got Unknown
		//IL_09c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d2: Expected O, but got Unknown
		//IL_0a4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a56: Expected O, but got Unknown
		//IL_0ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aca: Expected O, but got Unknown
		//IL_0bc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd0: Expected O, but got Unknown
		//IL_0c60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6a: Expected O, but got Unknown
		//IL_0cf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d01: Expected O, but got Unknown
		//IL_0d6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d75: Expected O, but got Unknown
		Label1 = new Label();
		GroupBox2 = new GroupBox();
		SIDTxt = new TextBox();
		UpdateBtn = new Button();
		Label7 = new Label();
		GenderTxt = new TextBox();
		Label6 = new Label();
		Label5 = new Label();
		Label4 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		AddressTxt = new TextBox();
		MobileTxt = new TextBox();
		DOBTxt = new TextBox();
		NameTxt = new TextBox();
		CheckBox1 = new CheckBox();
		OldPasswdTxt = new TextBox();
		Label8 = new Label();
		GroupBox1 = new GroupBox();
		ChangePasswdBtn = new Button();
		NewPasswdTxt = new TextBox();
		Label9 = new Label();
		PictureBox1 = new PictureBox();
		((Control)GroupBox2).SuspendLayout();
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Label1).set_Font(new Font("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(392, 63));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(330, 47));
		((Control)Label1).set_TabIndex(6);
		Label1.set_Text("Edit Profile");
		Label1.set_TextAlign((ContentAlignment)32);
		((Control)GroupBox2).get_Controls().Add((Control)(object)SIDTxt);
		((Control)GroupBox2).get_Controls().Add((Control)(object)UpdateBtn);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label7);
		((Control)GroupBox2).get_Controls().Add((Control)(object)GenderTxt);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label6);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox2).get_Controls().Add((Control)(object)AddressTxt);
		((Control)GroupBox2).get_Controls().Add((Control)(object)MobileTxt);
		((Control)GroupBox2).get_Controls().Add((Control)(object)DOBTxt);
		((Control)GroupBox2).get_Controls().Add((Control)(object)NameTxt);
		((Control)GroupBox2).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox2).set_Location(new Point(261, 167));
		((Control)GroupBox2).set_Name("GroupBox2");
		((Control)GroupBox2).set_Size(new Size(486, 418));
		((Control)GroupBox2).set_TabIndex(8);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("Personal Information");
		((Control)SIDTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)SIDTxt).set_Location(new Point(135, 51));
		((Control)SIDTxt).set_Name("SIDTxt");
		((TextBoxBase)SIDTxt).set_ReadOnly(true);
		((Control)SIDTxt).set_Size(new Size(91, 26));
		((Control)SIDTxt).set_TabIndex(12);
		((ButtonBase)UpdateBtn).set_BackColor(Color.MidnightBlue);
		((Control)UpdateBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)UpdateBtn).set_ForeColor(Color.White);
		((Control)UpdateBtn).set_Location(new Point(311, 372));
		((Control)UpdateBtn).set_Name("UpdateBtn");
		((Control)UpdateBtn).set_Size(new Size(133, 37));
		((Control)UpdateBtn).set_TabIndex(9);
		((ButtonBase)UpdateBtn).set_Text("Update");
		((ButtonBase)UpdateBtn).set_UseVisualStyleBackColor(false);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_Location(new Point(21, 51));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(87, 23));
		((Control)Label7).set_TabIndex(11);
		Label7.set_Text("SID :");
		Label7.set_TextAlign((ContentAlignment)32);
		((Control)GenderTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)GenderTxt).set_Location(new Point(348, 147));
		((Control)GenderTxt).set_Name("GenderTxt");
		((TextBoxBase)GenderTxt).set_ReadOnly(true);
		((Control)GenderTxt).set_Size(new Size(96, 26));
		((Control)GenderTxt).set_TabIndex(10);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_Location(new Point(31, 269));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(87, 26));
		((Control)Label6).set_TabIndex(9);
		Label6.set_Text("Address :");
		Label6.set_TextAlign((ContentAlignment)32);
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_Location(new Point(31, 211));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(94, 29));
		((Control)Label5).set_TabIndex(8);
		Label5.set_Text("Mobile :");
		Label5.set_TextAlign((ContentAlignment)32);
		((Control)Label4).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_Location(new Point(21, 152));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(85, 24));
		((Control)Label4).set_TabIndex(7);
		Label4.set_Text("D.O.B  :");
		Label4.set_TextAlign((ContentAlignment)32);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_Location(new Point(269, 146));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(73, 31));
		((Control)Label3).set_TabIndex(6);
		Label3.set_Text("Gender :");
		Label3.set_TextAlign((ContentAlignment)32);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(17, 98));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(87, 29));
		((Control)Label2).set_TabIndex(5);
		Label2.set_Text("Name :");
		Label2.set_TextAlign((ContentAlignment)32);
		((Control)AddressTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)AddressTxt).set_Location(new Point(135, 269));
		AddressTxt.set_Multiline(true);
		((Control)AddressTxt).set_Name("AddressTxt");
		((Control)AddressTxt).set_Size(new Size(309, 97));
		((Control)AddressTxt).set_TabIndex(4);
		((Control)MobileTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)MobileTxt).set_Location(new Point(135, 211));
		((Control)MobileTxt).set_Name("MobileTxt");
		((Control)MobileTxt).set_Size(new Size(204, 26));
		((Control)MobileTxt).set_TabIndex(2);
		((Control)DOBTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)DOBTxt).set_Location(new Point(135, 148));
		((Control)DOBTxt).set_Name("DOBTxt");
		((TextBoxBase)DOBTxt).set_ReadOnly(true);
		((Control)DOBTxt).set_Size(new Size(128, 26));
		((Control)DOBTxt).set_TabIndex(1);
		((Control)NameTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)NameTxt).set_Location(new Point(135, 98));
		((Control)NameTxt).set_Name("NameTxt");
		((TextBoxBase)NameTxt).set_ReadOnly(true);
		((Control)NameTxt).set_Size(new Size(309, 26));
		((Control)NameTxt).set_TabIndex(0);
		((ButtonBase)CheckBox1).set_AutoSize(true);
		((Control)CheckBox1).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)CheckBox1).set_Location(new Point(197, 110));
		((Control)CheckBox1).set_Name("CheckBox1");
		((Control)CheckBox1).set_Size(new Size(163, 23));
		((Control)CheckBox1).set_TabIndex(15);
		((ButtonBase)CheckBox1).set_Text("Show Password");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		((Control)OldPasswdTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)OldPasswdTxt).set_Location(new Point(197, 36));
		((Control)OldPasswdTxt).set_Name("OldPasswdTxt");
		((Control)OldPasswdTxt).set_Size(new Size(247, 26));
		((Control)OldPasswdTxt).set_TabIndex(14);
		OldPasswdTxt.set_UseSystemPasswordChar(true);
		((Control)Label8).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_Location(new Point(21, 32));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(154, 26));
		((Control)Label8).set_TabIndex(13);
		Label8.set_Text("Old Password :");
		Label8.set_TextAlign((ContentAlignment)32);
		((Control)GroupBox1).get_Controls().Add((Control)(object)ChangePasswdBtn);
		((Control)GroupBox1).get_Controls().Add((Control)(object)NewPasswdTxt);
		((Control)GroupBox1).get_Controls().Add((Control)(object)CheckBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label9);
		((Control)GroupBox1).get_Controls().Add((Control)(object)OldPasswdTxt);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label8);
		((Control)GroupBox1).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox1).set_Location(new Point(261, 591));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(486, 178));
		((Control)GroupBox1).set_TabIndex(16);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Change Password");
		((ButtonBase)ChangePasswdBtn).set_BackColor(Color.MidnightBlue);
		((Control)ChangePasswdBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)ChangePasswdBtn).set_ForeColor(Color.White);
		((Control)ChangePasswdBtn).set_Location(new Point(272, 135));
		((Control)ChangePasswdBtn).set_Name("ChangePasswdBtn");
		((Control)ChangePasswdBtn).set_Size(new Size(172, 37));
		((Control)ChangePasswdBtn).set_TabIndex(17);
		((ButtonBase)ChangePasswdBtn).set_Text("Change Password");
		((ButtonBase)ChangePasswdBtn).set_UseVisualStyleBackColor(false);
		((Control)NewPasswdTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)NewPasswdTxt).set_Location(new Point(197, 73));
		((Control)NewPasswdTxt).set_Name("NewPasswdTxt");
		((Control)NewPasswdTxt).set_Size(new Size(247, 26));
		((Control)NewPasswdTxt).set_TabIndex(16);
		NewPasswdTxt.set_UseSystemPasswordChar(true);
		((Control)Label9).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_Location(new Point(21, 73));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(154, 26));
		((Control)Label9).set_TabIndex(15);
		Label9.set_Text("New Password :");
		Label9.set_TextAlign((ContentAlignment)32);
		PictureBox1.set_Image((Image)(object)Resources.patient_pic);
		((Control)PictureBox1).set_Location(new Point(281, 42));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(172, 90));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(7);
		PictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox2);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).set_Name("EditProfile");
		((Control)this).set_Size(new Size(977, 804));
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox2).PerformLayout();
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void EditProfile_Load(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		myconnection.set_ConnectionString(MyProject.Forms.Form1.provider + MyProject.Forms.Form1.datafile);
		OleDbCommand val = new OleDbCommand();
		string text = "Select * From [Staff] Where [Username] = '" + MyProject.Forms.Form1.username + "';";
		myconnection.Open();
		try
		{
			val = new OleDbCommand(text, myconnection);
			OleDbDataReader val2 = val.ExecuteReader();
			while (val2.Read())
			{
				SIDTxt.set_Text(Conversions.ToString(val2.get_Item(0)));
				NameTxt.set_Text(Conversions.ToString(val2.get_Item(1)));
				DOBTxt.set_Text(Conversions.ToString(val2.get_Item(3)));
				GenderTxt.set_Text(Conversions.ToString(val2.get_Item(4)));
				MobileTxt.set_Text(Conversions.ToString(val2.get_Item(5)));
				AddressTxt.set_Text(Conversions.ToString(val2.get_Item(6)));
				primary_key = Conversions.ToString(val2.get_Item(0));
				password = Conversions.ToString(val2.get_Item(9));
			}
			myconnection.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			myconnection.Close();
			ProjectData.ClearProjectError();
		}
	}

	private void UpdateBtn_Click(object sender, EventArgs e)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		if (!MyProject.Forms.Form1.Mobile_Validator(MobileTxt.get_Text().ToLower()) | (Operators.CompareString(AddressTxt.get_Text(), "", false) == 0))
		{
			MessageBox.Show("Incorrect Credentials");
			return;
		}
		OleDbCommand val = new OleDbCommand();
		string text = "Update [Staff] Set [Mobile] = '" + MobileTxt.get_Text() + "', [Address] = '" + AddressTxt.get_Text() + "' Where [SID] = " + primary_key + ";";
		myconnection.Open();
		try
		{
			val = new OleDbCommand(text, myconnection);
			val.ExecuteNonQuery();
			((Component)(object)val).Dispose();
			myconnection.Close();
			MessageBox.Show("Successfully Updated Details");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			myconnection.Close();
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void ChangePasswdBtn_Click(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(OldPasswdTxt.get_Text(), password, false) != 0)
		{
			MessageBox.Show("Invalid Old Password");
			return;
		}
		if (Operators.CompareString(NewPasswdTxt.get_Text(), "", false) == 0)
		{
			MessageBox.Show("Password cannot be empty field");
			return;
		}
		OleDbCommand val = new OleDbCommand();
		string text = "Update [Staff] Set [Password] = '" + NewPasswdTxt.get_Text() + "' Where [SID] = " + primary_key + ";";
		myconnection.Open();
		try
		{
			val = new OleDbCommand(text, myconnection);
			val.ExecuteNonQuery();
			((Component)(object)val).Dispose();
			myconnection.Close();
			password = NewPasswdTxt.get_Text();
			((TextBoxBase)OldPasswdTxt).Clear();
			((TextBoxBase)NewPasswdTxt).Clear();
			MessageBox.Show("Successfully Updated Password");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			myconnection.Close();
			ProjectData.ClearProjectError();
		}
	}

	private void CheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (OldPasswdTxt.get_UseSystemPasswordChar())
		{
			OldPasswdTxt.set_UseSystemPasswordChar(false);
			NewPasswdTxt.set_UseSystemPasswordChar(false);
		}
		else
		{
			OldPasswdTxt.set_UseSystemPasswordChar(true);
			NewPasswdTxt.set_UseSystemPasswordChar(true);
		}
	}
}
