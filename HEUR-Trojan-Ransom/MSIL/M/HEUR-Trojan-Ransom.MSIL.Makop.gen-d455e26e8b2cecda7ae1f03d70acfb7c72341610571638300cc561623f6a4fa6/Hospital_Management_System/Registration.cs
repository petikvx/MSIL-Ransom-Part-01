using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hospital_Management_System.My;
using Hospital_Management_System.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hospital_Management_System;

[DesignerGenerated]
public class Registration : UserControl
{
	private IContainer components;

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

	[field: AccessedThroughProperty("NameTxt")]
	internal virtual TextBox NameTxt
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

	internal virtual ComboBox GenderTxt
	{
		[CompilerGenerated]
		get
		{
			return _GenderTxt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = GenderTxt_SelectionChangeCommitted;
			ComboBox genderTxt = _GenderTxt;
			if (genderTxt != null)
			{
				genderTxt.remove_SelectionChangeCommitted(eventHandler);
			}
			_GenderTxt = value;
			genderTxt = _GenderTxt;
			if (genderTxt != null)
			{
				genderTxt.add_SelectionChangeCommitted(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("SuccessMsg")]
	internal virtual Label SuccessMsg
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

	public Registration()
	{
		((UserControl)this).add_Load((EventHandler)Registration_Load);
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
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected O, but got Unknown
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected O, but got Unknown
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected O, but got Unknown
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Expected O, but got Unknown
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Expected O, but got Unknown
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Expected O, but got Unknown
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Expected O, but got Unknown
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Expected O, but got Unknown
		//IL_07ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f4: Expected O, but got Unknown
		//IL_085e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0868: Expected O, but got Unknown
		//IL_0904: Unknown result type (might be due to invalid IL or missing references)
		//IL_090e: Expected O, but got Unknown
		//IL_09aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b4: Expected O, but got Unknown
		components = new Container();
		Label1 = new Label();
		GroupBox2 = new GroupBox();
		DOBTxt = new DateTimePicker();
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
		SuccessMsg = new Label();
		Timer1 = new Timer(components);
		PictureBox1 = new PictureBox();
		((Control)GroupBox2).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Label1).set_Font(new Font("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(392, 60));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(372, 47));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Patient Registration");
		Label1.set_TextAlign((ContentAlignment)32);
		((Control)GroupBox2).get_Controls().Add((Control)(object)DOBTxt);
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
		((Control)GroupBox2).set_Size(new Size(486, 394));
		((Control)GroupBox2).set_TabIndex(3);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("Patient's Information");
		DOBTxt.set_CustomFormat("");
		DOBTxt.set_Format((DateTimePickerFormat)2);
		((Control)DOBTxt).set_Location(new Point(108, 110));
		DOBTxt.set_MaxDate(new DateTime(2019, 2, 11, 0, 0, 0, 0));
		DOBTxt.set_MinDate(new DateTime(1900, 1, 1, 0, 0, 0, 0));
		((Control)DOBTxt).set_Name("DOBTxt");
		((Control)DOBTxt).set_Size(new Size(178, 29));
		((Control)DOBTxt).set_TabIndex(14);
		DOBTxt.set_Value(new DateTime(2019, 2, 11, 0, 0, 0, 0));
		((Control)AddressTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)AddressTxt).set_Location(new Point(110, 256));
		AddressTxt.set_Multiline(true);
		((Control)AddressTxt).set_Name("AddressTxt");
		((Control)AddressTxt).set_Size(new Size(316, 91));
		((Control)AddressTxt).set_TabIndex(13);
		((Control)MobileTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)MobileTxt).set_Location(new Point(108, 203));
		((Control)MobileTxt).set_Name("MobileTxt");
		((Control)MobileTxt).set_Size(new Size(201, 26));
		((Control)MobileTxt).set_TabIndex(12);
		GenderTxt.get_AutoCompleteCustomSource().AddRange(new string[3] { "Male", "Female", "Others" });
		GenderTxt.set_AutoCompleteMode((AutoCompleteMode)2);
		GenderTxt.set_AutoCompleteSource((AutoCompleteSource)256);
		GenderTxt.set_DropDownStyle((ComboBoxStyle)2);
		((Control)GenderTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)GenderTxt).set_FormattingEnabled(true);
		GenderTxt.get_Items().AddRange(new object[3] { "Male", "Female", "Others" });
		((Control)GenderTxt).set_Location(new Point(108, 151));
		((Control)GenderTxt).set_Name("GenderTxt");
		((Control)GenderTxt).set_Size(new Size(112, 27));
		((Control)GenderTxt).set_TabIndex(11);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_Location(new Point(17, 255));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(87, 26));
		((Control)Label6).set_TabIndex(9);
		Label6.set_Text("Address :");
		Label6.set_TextAlign((ContentAlignment)32);
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_Location(new Point(6, 203));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(94, 29));
		((Control)Label5).set_TabIndex(8);
		Label5.set_Text("Mobile :");
		Label5.set_TextAlign((ContentAlignment)32);
		((Control)Label4).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_Location(new Point(15, 110));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(60, 24));
		((Control)Label4).set_TabIndex(7);
		Label4.set_Text("DOB :");
		Label4.set_TextAlign((ContentAlignment)32);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_Location(new Point(15, 151));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(82, 31));
		((Control)Label3).set_TabIndex(6);
		Label3.set_Text("Gender :");
		Label3.set_TextAlign((ContentAlignment)32);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(8, 55));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(87, 23));
		((Control)Label2).set_TabIndex(5);
		Label2.set_Text("Name :");
		Label2.set_TextAlign((ContentAlignment)32);
		((Control)NameTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)NameTxt).set_Location(new Point(108, 55));
		((Control)NameTxt).set_Name("NameTxt");
		((Control)NameTxt).set_Size(new Size(318, 26));
		((Control)NameTxt).set_TabIndex(0);
		((ButtonBase)RegisterBtn).set_BackColor(Color.MidnightBlue);
		((Control)RegisterBtn).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)RegisterBtn).set_ForeColor(Color.White);
		((Control)RegisterBtn).set_Location(new Point(600, 661));
		((Control)RegisterBtn).set_Name("RegisterBtn");
		((Control)RegisterBtn).set_Size(new Size(147, 47));
		((Control)RegisterBtn).set_TabIndex(4);
		((ButtonBase)RegisterBtn).set_Text("Register");
		((ButtonBase)RegisterBtn).set_UseVisualStyleBackColor(false);
		((ButtonBase)ClearBtn).set_BackColor(Color.MidnightBlue);
		((Control)ClearBtn).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)ClearBtn).set_ForeColor(Color.White);
		((Control)ClearBtn).set_Location(new Point(261, 661));
		((Control)ClearBtn).set_Name("ClearBtn");
		((Control)ClearBtn).set_Size(new Size(146, 47));
		((Control)ClearBtn).set_TabIndex(5);
		((ButtonBase)ClearBtn).set_Text("Clear");
		((ButtonBase)ClearBtn).set_UseVisualStyleBackColor(false);
		((Control)SuccessMsg).set_BackColor(Color.Olive);
		((Control)SuccessMsg).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)SuccessMsg).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)SuccessMsg).set_Location(new Point(305, 156));
		((Control)SuccessMsg).set_Name("SuccessMsg");
		((Control)SuccessMsg).set_Size(new Size(401, 44));
		((Control)SuccessMsg).set_TabIndex(6);
		SuccessMsg.set_Text("Patient Successfully registered");
		SuccessMsg.set_TextAlign((ContentAlignment)32);
		((Control)SuccessMsg).set_Visible(false);
		Timer1.set_Interval(1500);
		PictureBox1.set_Image((Image)(object)Resources.patient_pic);
		((Control)PictureBox1).set_Location(new Point(281, 21));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(126, 122));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(1);
		PictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Control)this).get_Controls().Add((Control)(object)SuccessMsg);
		((Control)this).get_Controls().Add((Control)(object)ClearBtn);
		((Control)this).get_Controls().Add((Control)(object)RegisterBtn);
		((Control)this).get_Controls().Add((Control)(object)GroupBox2);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).set_Name("Registration");
		((Control)this).set_Size(new Size(977, 804));
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox2).PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void Registration_Load(object sender, EventArgs e)
	{
		DOBTxt.set_MaxDate(DateTime.Now);
	}

	private void ClearBtn_Click(object sender, EventArgs e)
	{
		((TextBoxBase)NameTxt).Clear();
		DOBTxt.set_Value(Conversions.ToDate(Strings.Format((object)DateTime.Now, "dd-MM-yyyy")));
		GenderTxt.set_SelectedIndex(-1);
		((TextBoxBase)MobileTxt).Clear();
		((TextBoxBase)AddressTxt).Clear();
		((Control)SuccessMsg).set_Visible(false);
	}

	private void GenderTxt_SelectionChangeCommitted(object sender, EventArgs e)
	{
		((Control)MobileTxt).Focus();
	}

	private void RegisterBtn_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		OleDbConnection val = new OleDbConnection();
		val.set_ConnectionString(MyProject.Forms.Form1.provider + MyProject.Forms.Form1.datafile);
		if (Validate_data())
		{
			DateTime dateTime = Conversions.ToDate(Strings.Format((object)DOBTxt.get_Value(), "dd-MM-yyyy"));
			val.Open();
			string text = "Insert Into [Patient] (Name,DOB,Gender,Mobile,Address) Values (?,?,?,?,?)";
			OleDbCommand val2 = new OleDbCommand(text, val);
			try
			{
				val2.get_Parameters().Add(new OleDbParameter("Name", (object)NameTxt.get_Text().ToLower()));
				val2.get_Parameters().Add(new OleDbParameter("DOB", (object)Conversions.ToString(dateTime)));
				val2.get_Parameters().Add(new OleDbParameter("Gender", (object)GenderTxt.get_Text().ToLower()));
				val2.get_Parameters().Add(new OleDbParameter("Mobile", (object)MobileTxt.get_Text().ToString()));
				val2.get_Parameters().Add(new OleDbParameter("Address", (object)AddressTxt.get_Text().ToString()));
				val2.ExecuteNonQuery();
				((Component)(object)val2).Dispose();
				val.Close();
				((Control)SuccessMsg).set_Visible(true);
				SuccessMsg.set_Text("Patient Successfully Registered !!");
				((Control)SuccessMsg).set_BackColor(Color.Green);
				Timer1.Start();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				val.Close();
				((Control)SuccessMsg).set_Visible(true);
				SuccessMsg.set_Text("Invalid Credentials");
				MessageBox.Show(ex2.Message);
				((Control)SuccessMsg).set_BackColor(Color.Red);
				Timer1.Start();
				ProjectData.ClearProjectError();
			}
		}
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
		if (Operators.CompareString(AddressTxt.get_Text(), "", false) == 0)
		{
			((Control)SuccessMsg).set_Visible(true);
			SuccessMsg.set_Text("Enter Address");
			((Control)SuccessMsg).set_BackColor(Color.Red);
			Timer1.Start();
			return false;
		}
		return true;
	}
}
