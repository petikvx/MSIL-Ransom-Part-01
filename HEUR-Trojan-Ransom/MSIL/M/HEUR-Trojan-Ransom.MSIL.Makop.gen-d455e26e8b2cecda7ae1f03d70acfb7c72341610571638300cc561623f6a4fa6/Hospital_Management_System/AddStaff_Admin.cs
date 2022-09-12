using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hospital_Management_System.My;
using Hospital_Management_System.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hospital_Management_System;

[DesignerGenerated]
public class AddStaff_Admin : UserControl
{
	private IContainer components;

	private string username;

	private string password;

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SuccessMsg")]
	internal virtual Label SuccessMsg
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

	[field: AccessedThroughProperty("GenderTxt")]
	internal virtual ComboBox GenderTxt
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

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("WorkShiftTxt")]
	internal virtual ComboBox WorkShiftTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DesignationTxt")]
	internal virtual ComboBox DesignationTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button RegisterBtn
	{
		[CompilerGenerated]
		get
		{
			return _RegisterBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = RegisterBtn_Click;
			Button registerBtn = _RegisterBtn;
			if (registerBtn != null)
			{
				((Control)registerBtn).remove_Click(eventHandler);
			}
			_RegisterBtn = value;
			registerBtn = _RegisterBtn;
			if (registerBtn != null)
			{
				((Control)registerBtn).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button ClearBtn
	{
		[CompilerGenerated]
		get
		{
			return _ClearBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = ClearBtn_Click;
			Button clearBtn = _ClearBtn;
			if (clearBtn != null)
			{
				((Control)clearBtn).remove_Click(eventHandler);
			}
			_ClearBtn = value;
			clearBtn = _ClearBtn;
			if (clearBtn != null)
			{
				((Control)clearBtn).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("EmailTxt")]
	internal virtual TextBox EmailTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			Timer timer = _Timer1;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			timer = _Timer1;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("DOBTxt")]
	internal virtual DateTimePicker DOBTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public AddStaff_Admin()
	{
		((UserControl)this).add_Load((EventHandler)AddStaff_Admin_Load);
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
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected O, but got Unknown
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected O, but got Unknown
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Expected O, but got Unknown
		//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cd: Expected O, but got Unknown
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_077a: Expected O, but got Unknown
		//IL_084a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0854: Expected O, but got Unknown
		//IL_08e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f1: Expected O, but got Unknown
		//IL_096b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0975: Expected O, but got Unknown
		//IL_09e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ec: Expected O, but got Unknown
		//IL_0aa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aad: Expected O, but got Unknown
		//IL_0b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b52: Expected O, but got Unknown
		//IL_0bca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd4: Expected O, but got Unknown
		//IL_0c4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c54: Expected O, but got Unknown
		//IL_0cc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd1: Expected O, but got Unknown
		//IL_0d48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d52: Expected O, but got Unknown
		//IL_0dc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcf: Expected O, but got Unknown
		//IL_0e3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e46: Expected O, but got Unknown
		//IL_0ee3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eed: Expected O, but got Unknown
		components = new Container();
		PictureBox1 = new PictureBox();
		Label1 = new Label();
		SuccessMsg = new Label();
		GroupBox2 = new GroupBox();
		DOBTxt = new DateTimePicker();
		EmailTxt = new TextBox();
		Label9 = new Label();
		DesignationTxt = new ComboBox();
		Label8 = new Label();
		WorkShiftTxt = new ComboBox();
		Label7 = new Label();
		AddressTxt = new TextBox();
		MobileTxt = new TextBox();
		GenderTxt = new ComboBox();
		Label6 = new Label();
		Label5 = new Label();
		Label4 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		NameTxt = new TextBox();
		RegisterBtn = new Button();
		ClearBtn = new Button();
		Timer1 = new Timer(components);
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)GroupBox2).SuspendLayout();
		((Control)this).SuspendLayout();
		PictureBox1.set_Image((Image)(object)Resources.doc_Pic);
		((Control)PictureBox1).set_Location(new Point(245, 17));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(141, 136));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(10);
		PictureBox1.set_TabStop(false);
		((Control)Label1).set_Font(new Font("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(392, 63));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(330, 47));
		((Control)Label1).set_TabIndex(11);
		Label1.set_Text("Add Staff");
		Label1.set_TextAlign((ContentAlignment)32);
		((Control)SuccessMsg).set_BackColor(Color.Olive);
		((Control)SuccessMsg).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)SuccessMsg).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)SuccessMsg).set_Location(new Point(305, 156));
		((Control)SuccessMsg).set_Name("SuccessMsg");
		((Control)SuccessMsg).set_Size(new Size(401, 44));
		((Control)SuccessMsg).set_TabIndex(12);
		SuccessMsg.set_Text("Patient Successfully registered");
		SuccessMsg.set_TextAlign((ContentAlignment)32);
		((Control)SuccessMsg).set_Visible(false);
		((Control)GroupBox2).get_Controls().Add((Control)(object)DOBTxt);
		((Control)GroupBox2).get_Controls().Add((Control)(object)EmailTxt);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label9);
		((Control)GroupBox2).get_Controls().Add((Control)(object)DesignationTxt);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label8);
		((Control)GroupBox2).get_Controls().Add((Control)(object)WorkShiftTxt);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label7);
		((Control)GroupBox2).get_Controls().Add((Control)(object)AddressTxt);
		((Control)GroupBox2).get_Controls().Add((Control)(object)MobileTxt);
		((Control)GroupBox2).get_Controls().Add((Control)(object)GenderTxt);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label6);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox2).get_Controls().Add((Control)(object)NameTxt);
		((Control)GroupBox2).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox2).set_Location(new Point(261, 235));
		((Control)GroupBox2).set_Name("GroupBox2");
		((Control)GroupBox2).set_Size(new Size(486, 446));
		((Control)GroupBox2).set_TabIndex(13);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("Patient's Information");
		DOBTxt.set_Format((DateTimePickerFormat)2);
		((Control)DOBTxt).set_Location(new Point(137, 102));
		DOBTxt.set_MaxDate(new DateTime(2019, 2, 11, 0, 0, 0, 0));
		DOBTxt.set_MinDate(new DateTime(1900, 1, 1, 0, 0, 0, 0));
		((Control)DOBTxt).set_Name("DOBTxt");
		((Control)DOBTxt).set_Size(new Size(208, 29));
		((Control)DOBTxt).set_TabIndex(20);
		DOBTxt.set_Value(new DateTime(2019, 2, 11, 0, 0, 0, 0));
		((Control)EmailTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)EmailTxt).set_Location(new Point(137, 307));
		((Control)EmailTxt).set_Name("EmailTxt");
		((Control)EmailTxt).set_Size(new Size(324, 26));
		((Control)EmailTxt).set_TabIndex(19);
		((Control)Label9).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_Location(new Point(13, 307));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(87, 26));
		((Control)Label9).set_TabIndex(18);
		Label9.set_Text("Email :");
		Label9.set_TextAlign((ContentAlignment)32);
		DesignationTxt.get_AutoCompleteCustomSource().AddRange(new string[3] { "Male", "Female", "Others" });
		DesignationTxt.set_AutoCompleteMode((AutoCompleteMode)2);
		DesignationTxt.set_AutoCompleteSource((AutoCompleteSource)256);
		DesignationTxt.set_DropDownStyle((ComboBoxStyle)2);
		((Control)DesignationTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)DesignationTxt).set_FormattingEnabled(true);
		DesignationTxt.get_Items().AddRange(new object[4] { "Doctor", "Nurse", "Receptionist", "Admin" });
		((Control)DesignationTxt).set_Location(new Point(137, 262));
		((Control)DesignationTxt).set_Name("DesignationTxt");
		((Control)DesignationTxt).set_Size(new Size(147, 27));
		((Control)DesignationTxt).set_TabIndex(17);
		((Control)Label8).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_Location(new Point(3, 263));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(128, 26));
		((Control)Label8).set_TabIndex(16);
		Label8.set_Text("Designation :");
		Label8.set_TextAlign((ContentAlignment)32);
		WorkShiftTxt.get_AutoCompleteCustomSource().AddRange(new string[3] { "Male", "Female", "Others" });
		WorkShiftTxt.set_AutoCompleteMode((AutoCompleteMode)2);
		WorkShiftTxt.set_AutoCompleteSource((AutoCompleteSource)256);
		WorkShiftTxt.set_DropDownStyle((ComboBoxStyle)2);
		((Control)WorkShiftTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)WorkShiftTxt).set_FormattingEnabled(true);
		WorkShiftTxt.get_Items().AddRange(new object[2] { "Day", "Night" });
		((Control)WorkShiftTxt).set_Location(new Point(137, 221));
		((Control)WorkShiftTxt).set_Name("WorkShiftTxt");
		((Control)WorkShiftTxt).set_Size(new Size(147, 27));
		((Control)WorkShiftTxt).set_TabIndex(15);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_Location(new Point(3, 222));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(128, 26));
		((Control)Label7).set_TabIndex(14);
		Label7.set_Text("Work Shift :");
		Label7.set_TextAlign((ContentAlignment)32);
		((Control)AddressTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)AddressTxt).set_Location(new Point(137, 349));
		AddressTxt.set_Multiline(true);
		((Control)AddressTxt).set_Name("AddressTxt");
		((Control)AddressTxt).set_Size(new Size(324, 91));
		((Control)AddressTxt).set_TabIndex(13);
		((Control)MobileTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)MobileTxt).set_Location(new Point(137, 147));
		((Control)MobileTxt).set_Name("MobileTxt");
		((Control)MobileTxt).set_Size(new Size(208, 26));
		((Control)MobileTxt).set_TabIndex(12);
		GenderTxt.get_AutoCompleteCustomSource().AddRange(new string[3] { "Male", "Female", "Others" });
		GenderTxt.set_AutoCompleteMode((AutoCompleteMode)2);
		GenderTxt.set_AutoCompleteSource((AutoCompleteSource)256);
		GenderTxt.set_DropDownStyle((ComboBoxStyle)2);
		((Control)GenderTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)GenderTxt).set_FormattingEnabled(true);
		GenderTxt.get_Items().AddRange(new object[3] { "Male", "Female", "Others" });
		((Control)GenderTxt).set_Location(new Point(137, 182));
		((Control)GenderTxt).set_Name("GenderTxt");
		((Control)GenderTxt).set_Size(new Size(130, 27));
		((Control)GenderTxt).set_TabIndex(11);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_Location(new Point(15, 348));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(87, 26));
		((Control)Label6).set_TabIndex(9);
		Label6.set_Text("Address :");
		Label6.set_TextAlign((ContentAlignment)32);
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_Location(new Point(8, 144));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(94, 29));
		((Control)Label5).set_TabIndex(8);
		Label5.set_Text("Mobile :");
		Label5.set_TextAlign((ContentAlignment)32);
		((Control)Label4).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_Location(new Point(8, 101));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(92, 24));
		((Control)Label4).set_TabIndex(7);
		Label4.set_Text("D.O.B :");
		Label4.set_TextAlign((ContentAlignment)32);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_Location(new Point(13, 182));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(82, 31));
		((Control)Label3).set_TabIndex(6);
		Label3.set_Text("Gender :");
		Label3.set_TextAlign((ContentAlignment)32);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(8, 55));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(92, 23));
		((Control)Label2).set_TabIndex(5);
		Label2.set_Text("Name :");
		Label2.set_TextAlign((ContentAlignment)32);
		((Control)NameTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)NameTxt).set_Location(new Point(137, 55));
		((Control)NameTxt).set_Name("NameTxt");
		((Control)NameTxt).set_Size(new Size(324, 26));
		((Control)NameTxt).set_TabIndex(0);
		((ButtonBase)RegisterBtn).set_BackColor(Color.MidnightBlue);
		((Control)RegisterBtn).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)RegisterBtn).set_ForeColor(Color.White);
		((Control)RegisterBtn).set_Location(new Point(608, 703));
		((Control)RegisterBtn).set_Name("RegisterBtn");
		((Control)RegisterBtn).set_Size(new Size(139, 43));
		((Control)RegisterBtn).set_TabIndex(14);
		((ButtonBase)RegisterBtn).set_Text("Register");
		((ButtonBase)RegisterBtn).set_UseVisualStyleBackColor(false);
		((ButtonBase)ClearBtn).set_BackColor(Color.MidnightBlue);
		((Control)ClearBtn).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)ClearBtn).set_ForeColor(Color.White);
		((Control)ClearBtn).set_Location(new Point(261, 703));
		((Control)ClearBtn).set_Name("ClearBtn");
		((Control)ClearBtn).set_Size(new Size(143, 43));
		((Control)ClearBtn).set_TabIndex(15);
		((ButtonBase)ClearBtn).set_Text("Clear");
		((ButtonBase)ClearBtn).set_UseVisualStyleBackColor(false);
		Timer1.set_Interval(1500);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Control)this).get_Controls().Add((Control)(object)ClearBtn);
		((Control)this).get_Controls().Add((Control)(object)RegisterBtn);
		((Control)this).get_Controls().Add((Control)(object)GroupBox2);
		((Control)this).get_Controls().Add((Control)(object)SuccessMsg);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).set_Name("AddStaff_Admin");
		((Control)this).set_Size(new Size(977, 804));
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox2).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void AddStaff_Admin_Load(object sender, EventArgs e)
	{
		DOBTxt.set_MaxDate(Conversions.ToDate(Strings.Format((object)DateTime.Now, "dd-MM-yyyy")));
	}

	private void ClearBtn_Click(object sender, EventArgs e)
	{
		((TextBoxBase)NameTxt).Clear();
		DOBTxt.set_Value(Conversions.ToDate(Strings.Format((object)DateAndTime.get_Today(), "dd-MM-yyyy")));
		GenderTxt.set_SelectedIndex(-1);
		WorkShiftTxt.set_SelectedIndex(-1);
		DesignationTxt.set_SelectedIndex(-1);
		((TextBoxBase)MobileTxt).Clear();
		((TextBoxBase)EmailTxt).Clear();
		((TextBoxBase)AddressTxt).Clear();
		((Control)SuccessMsg).set_Visible(false);
	}

	private void RegisterBtn_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		OleDbConnection val = new OleDbConnection();
		val.set_ConnectionString(MyProject.Forms.Form1.provider + MyProject.Forms.Form1.datafile);
		if (Validate_data())
		{
			username = NameTxt.get_Text().Split(new char[1] { '.' })[0];
			username = username.Split(new char[1] { ' ' })[0];
			password = Random_Password_Generator();
			DateTime dateTime = Conversions.ToDate(Strings.Format((object)DOBTxt.get_Value(), "dd-MM-yyyy"));
			val.Open();
			string text = "Insert Into [Staff] ([Name],[Designation],[Date Of Birth],[Gender],[Mobile],[Address],[Work Shift],[Username],[Password]) Values (?,?,?,?,?,?,?,?,?)";
			OleDbCommand val2 = new OleDbCommand(text, val);
			try
			{
				val2.get_Parameters().Add(new OleDbParameter("Name", (object)NameTxt.get_Text().ToLower()));
				val2.get_Parameters().Add(new OleDbParameter("Designation", (object)DesignationTxt.get_Text().ToLower()));
				val2.get_Parameters().Add(new OleDbParameter("Date Of Birth", (object)Conversions.ToString(dateTime)));
				val2.get_Parameters().Add(new OleDbParameter("Gender", (object)GenderTxt.get_Text().ToLower()));
				val2.get_Parameters().Add(new OleDbParameter("Mobile", (object)MobileTxt.get_Text().ToString()));
				val2.get_Parameters().Add(new OleDbParameter("Address", (object)AddressTxt.get_Text().ToString()));
				val2.get_Parameters().Add(new OleDbParameter("Work Shift", (object)WorkShiftTxt.get_Text().ToString()));
				val2.get_Parameters().Add(new OleDbParameter("Username", (object)username));
				val2.get_Parameters().Add(new OleDbParameter("Password", (object)password));
				val2.ExecuteNonQuery();
				((Component)(object)val2).Dispose();
				val.Close();
				Send_Mail();
				((Control)SuccessMsg).set_Visible(true);
				SuccessMsg.set_Text("Staff Successfully Registered !!");
				((Control)SuccessMsg).set_BackColor(Color.Green);
				Timer1.Start();
				ClearBtn_Click(RuntimeHelpers.GetObjectValue(sender), e);
				((Control)SuccessMsg).set_Visible(true);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				val.Close();
				((Control)SuccessMsg).set_Visible(true);
				SuccessMsg.set_Text("Invalid Credentialsl");
				((Control)SuccessMsg).set_BackColor(Color.Red);
				Timer1.Start();
				ProjectData.ClearProjectError();
			}
		}
	}

	private bool Send_Mail()
	{
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			SmtpClient smtpClient = new SmtpClient();
			MailMessage mailMessage = new MailMessage();
			smtpClient.UseDefaultCredentials = false;
			smtpClient.Credentials = new NetworkCredential("tyagianubhav619@gmail.com", "tyagi09101999");
			smtpClient.Port = 587;
			smtpClient.EnableSsl = true;
			smtpClient.Host = "smtp.gmail.com";
			mailMessage = new MailMessage();
			mailMessage.From = new MailAddress("tyagianubhav619@gmail.com");
			mailMessage.To.Add(EmailTxt.get_Text());
			mailMessage.Subject = "Login Credential Details";
			mailMessage.IsBodyHtml = false;
			mailMessage.Body = "Your Username is : " + username + " and Password is : " + password + ". Remember your login credentials for future use";
			smtpClient.Send(mailMessage);
			Interaction.MsgBox((object)"Mail Sent", (MsgBoxStyle)0, (object)null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"Cannot Send Mail. Network Not available", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		return true;
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		((Control)SuccessMsg).set_Visible(false);
		Timer1.Stop();
	}

	private bool Validate_data()
	{
		if (!MyProject.Forms.Form1.Name_Validation(NameTxt.get_Text().ToLower()))
		{
			((Control)SuccessMsg).set_Visible(true);
			SuccessMsg.set_Text("Invalid Name");
			((Control)SuccessMsg).set_BackColor(Color.Red);
			Timer1.Start();
			return false;
		}
		if (GenderTxt.get_SelectedIndex() == -1)
		{
			((Control)SuccessMsg).set_Visible(true);
			SuccessMsg.set_Text("Invalid Gender");
			((Control)SuccessMsg).set_BackColor(Color.Red);
			Timer1.Start();
			return false;
		}
		if (!MyProject.Forms.Form1.Gender_Validator(GenderTxt.get_Text().ToLower()))
		{
			((Control)SuccessMsg).set_Visible(true);
			SuccessMsg.set_Text("Invalid Gender");
			((Control)SuccessMsg).set_BackColor(Color.Red);
			Timer1.Start();
			return false;
		}
		if (!MyProject.Forms.Form1.Mobile_Validator(MobileTxt.get_Text()))
		{
			((Control)SuccessMsg).set_Visible(true);
			SuccessMsg.set_Text("Invalid Mobile Number");
			((Control)SuccessMsg).set_BackColor(Color.Red);
			Timer1.Start();
			return false;
		}
		if (WorkShiftTxt.get_SelectedIndex() == -1)
		{
			((Control)SuccessMsg).set_Visible(true);
			SuccessMsg.set_Text("Invalid Workshift Number");
			((Control)SuccessMsg).set_BackColor(Color.Red);
			Timer1.Start();
			return false;
		}
		if (DesignationTxt.get_SelectedIndex() == -1)
		{
			((Control)SuccessMsg).set_Visible(true);
			SuccessMsg.set_Text("Invalid Designation");
			((Control)SuccessMsg).set_BackColor(Color.Red);
			Timer1.Start();
			return false;
		}
		if (Operators.CompareString(AddressTxt.get_Text(), "", false) == 0)
		{
			((Control)SuccessMsg).set_Visible(true);
			SuccessMsg.set_Text("Adress required ");
			((Control)SuccessMsg).set_BackColor(Color.Red);
			Timer1.Start();
			return false;
		}
		if (Operators.CompareString(EmailTxt.get_Text(), "", false) == 0)
		{
			((Control)SuccessMsg).set_Visible(true);
			SuccessMsg.set_Text("Email field is required");
			((Control)SuccessMsg).set_BackColor(Color.Red);
			Timer1.Start();
		}
		return true;
	}

	private string Random_Password_Generator()
	{
		string text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
		string text2 = "";
		Random random = new Random();
		int num = 1;
		do
		{
			int index = random.Next(0, text.Length);
			char c = text[index];
			text2 += Conversions.ToString(c);
			num = checked(num + 1);
		}
		while (num <= 10);
		return text2;
	}
}
