using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
public class UpdateStaff_Admin : UserControl
{
	private IContainer components;

	private string Designation;

	private OleDbConnection myconnection;

	private int day;

	private int selectrow;

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

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler eventHandler = Button2_Click;
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

	internal virtual RadioButton Receptionistbtn
	{
		[CompilerGenerated]
		get
		{
			return _Receptionistbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = RadioButton3_CheckedChanged;
			RadioButton receptionistbtn = _Receptionistbtn;
			if (receptionistbtn != null)
			{
				receptionistbtn.remove_CheckedChanged(eventHandler);
			}
			_Receptionistbtn = value;
			receptionistbtn = _Receptionistbtn;
			if (receptionistbtn != null)
			{
				receptionistbtn.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual RadioButton NurseBtn
	{
		[CompilerGenerated]
		get
		{
			return _NurseBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = RadioButton2_CheckedChanged;
			RadioButton nurseBtn = _NurseBtn;
			if (nurseBtn != null)
			{
				nurseBtn.remove_CheckedChanged(eventHandler);
			}
			_NurseBtn = value;
			nurseBtn = _NurseBtn;
			if (nurseBtn != null)
			{
				nurseBtn.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual RadioButton DoctorBtn
	{
		[CompilerGenerated]
		get
		{
			return _DoctorBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = RadioButton1_CheckedChanged;
			RadioButton doctorBtn = _DoctorBtn;
			if (doctorBtn != null)
			{
				doctorBtn.remove_CheckedChanged(eventHandler);
			}
			_DoctorBtn = value;
			doctorBtn = _DoctorBtn;
			if (doctorBtn != null)
			{
				doctorBtn.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual Button SearchBtn
	{
		[CompilerGenerated]
		get
		{
			return _SearchBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = SearchBtn_Click;
			Button searchBtn = _SearchBtn;
			if (searchBtn != null)
			{
				((Control)searchBtn).remove_Click(eventHandler);
			}
			_SearchBtn = value;
			searchBtn = _SearchBtn;
			if (searchBtn != null)
			{
				((Control)searchBtn).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("NameSTxt")]
	internal virtual TextBox NameSTxt
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

	internal virtual DataGridView SearchResultGrid
	{
		[CompilerGenerated]
		get
		{
			return _SearchResultGrid;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			DataGridViewCellMouseEventHandler val = new DataGridViewCellMouseEventHandler(DataGridView1_CellMouseClick);
			DataGridView searchResultGrid = _SearchResultGrid;
			if (searchResultGrid != null)
			{
				searchResultGrid.remove_CellMouseClick(val);
			}
			_SearchResultGrid = value;
			searchResultGrid = _SearchResultGrid;
			if (searchResultGrid != null)
			{
				searchResultGrid.add_CellMouseClick(val);
			}
		}
	}

	[field: AccessedThroughProperty("DetailsBox")]
	internal virtual GroupBox DetailsBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ShowAvailability")]
	internal virtual Label ShowAvailability
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

	[field: AccessedThroughProperty("MobileTxt")]
	internal virtual TextBox MobileTxt
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

	[field: AccessedThroughProperty("EmailTxt")]
	internal virtual TextBox EmailTxt
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

	[field: AccessedThroughProperty("AddressTxt")]
	internal virtual TextBox AddressTxt
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

	[field: AccessedThroughProperty("SIDTxt")]
	internal virtual TextBox SIDTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
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
			EventHandler eventHandler = UpadateBtn_Click;
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

	internal virtual Button DeleteBtn
	{
		[CompilerGenerated]
		get
		{
			return _DeleteBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = DeleteBtn_Click;
			Button deleteBtn = _DeleteBtn;
			if (deleteBtn != null)
			{
				((Control)deleteBtn).remove_Click(eventHandler);
			}
			_DeleteBtn = value;
			deleteBtn = _DeleteBtn;
			if (deleteBtn != null)
			{
				((Control)deleteBtn).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("DOBTxt")]
	internal virtual DateTimePicker DOBTxt
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

	[field: AccessedThroughProperty("GenderTxt")]
	internal virtual ComboBox GenderTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public UpdateStaff_Admin()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		((UserControl)this).add_Load((EventHandler)UpdateStaff_Admin_Load);
		myconnection = new OleDbConnection();
		day = Conversions.ToInteger(DateTime.Now.ToString("HH"));
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
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected O, but got Unknown
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Expected O, but got Unknown
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected O, but got Unknown
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected O, but got Unknown
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected O, but got Unknown
		//IL_0643: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Expected O, but got Unknown
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Expected O, but got Unknown
		//IL_09b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c3: Expected O, but got Unknown
		//IL_0b76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b80: Expected O, but got Unknown
		//IL_0c42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4c: Expected O, but got Unknown
		//IL_0d2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d36: Expected O, but got Unknown
		//IL_0dfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e06: Expected O, but got Unknown
		//IL_0ec6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed0: Expected O, but got Unknown
		//IL_0fe2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fec: Expected O, but got Unknown
		//IL_1056: Unknown result type (might be due to invalid IL or missing references)
		//IL_1060: Expected O, but got Unknown
		//IL_10cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d7: Expected O, but got Unknown
		//IL_1141: Unknown result type (might be due to invalid IL or missing references)
		//IL_114b: Expected O, but got Unknown
		//IL_11c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11cc: Expected O, but got Unknown
		//IL_1266: Unknown result type (might be due to invalid IL or missing references)
		//IL_1270: Expected O, but got Unknown
		PictureBox1 = new PictureBox();
		Label1 = new Label();
		GroupBox1 = new GroupBox();
		ClearBtn = new Button();
		Receptionistbtn = new RadioButton();
		NurseBtn = new RadioButton();
		DoctorBtn = new RadioButton();
		SearchBtn = new Button();
		NameSTxt = new TextBox();
		Label2 = new Label();
		SearchResultGrid = new DataGridView();
		DetailsBox = new GroupBox();
		DOBTxt = new DateTimePicker();
		WorkShiftTxt = new ComboBox();
		Label12 = new Label();
		SIDTxt = new TextBox();
		Label11 = new Label();
		ShowAvailability = new Label();
		Label3 = new Label();
		MobileTxt = new TextBox();
		Label9 = new Label();
		EmailTxt = new TextBox();
		Label8 = new Label();
		AddressTxt = new TextBox();
		NameTxt = new TextBox();
		Label7 = new Label();
		Label6 = new Label();
		Label5 = new Label();
		Label4 = new Label();
		UpdateBtn = new Button();
		DeleteBtn = new Button();
		DesignationTxt = new ComboBox();
		GenderTxt = new ComboBox();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)SearchResultGrid).BeginInit();
		((Control)DetailsBox).SuspendLayout();
		((Control)this).SuspendLayout();
		PictureBox1.set_Image((Image)(object)Resources.doc_Pic);
		((Control)PictureBox1).set_Location(new Point(242, 3));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(144, 141));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(5);
		PictureBox1.set_TabStop(false);
		((Control)Label1).set_Font(new Font("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(392, 63));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(330, 47));
		((Control)Label1).set_TabIndex(6);
		Label1.set_Text("Update Staff");
		Label1.set_TextAlign((ContentAlignment)32);
		((Control)GroupBox1).get_Controls().Add((Control)(object)ClearBtn);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Receptionistbtn);
		((Control)GroupBox1).get_Controls().Add((Control)(object)NurseBtn);
		((Control)GroupBox1).get_Controls().Add((Control)(object)DoctorBtn);
		((Control)GroupBox1).get_Controls().Add((Control)(object)SearchBtn);
		((Control)GroupBox1).get_Controls().Add((Control)(object)NameSTxt);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox1).set_Location(new Point(155, 150));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(623, 127));
		((Control)GroupBox1).set_TabIndex(8);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Search Staff Member");
		((ButtonBase)ClearBtn).set_BackColor(Color.MidnightBlue);
		((Control)ClearBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)ClearBtn).set_ForeColor(Color.White);
		((Control)ClearBtn).set_Location(new Point(467, 30));
		((Control)ClearBtn).set_Name("ClearBtn");
		((Control)ClearBtn).set_Size(new Size(133, 37));
		((Control)ClearBtn).set_TabIndex(8);
		((ButtonBase)ClearBtn).set_Text("Clear");
		((ButtonBase)ClearBtn).set_UseVisualStyleBackColor(false);
		((ButtonBase)Receptionistbtn).set_AutoSize(true);
		((Control)Receptionistbtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Receptionistbtn).set_Location(new Point(280, 84));
		((Control)Receptionistbtn).set_Name("Receptionistbtn");
		((Control)Receptionistbtn).set_Size(new Size(132, 23));
		((Control)Receptionistbtn).set_TabIndex(7);
		Receptionistbtn.set_TabStop(true);
		((ButtonBase)Receptionistbtn).set_Text("Receptionist");
		((ButtonBase)Receptionistbtn).set_UseVisualStyleBackColor(true);
		((ButtonBase)NurseBtn).set_AutoSize(true);
		((Control)NurseBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)NurseBtn).set_Location(new Point(174, 84));
		((Control)NurseBtn).set_Name("NurseBtn");
		((Control)NurseBtn).set_Size(new Size(78, 23));
		((Control)NurseBtn).set_TabIndex(6);
		NurseBtn.set_TabStop(true);
		((ButtonBase)NurseBtn).set_Text("Nurse");
		((ButtonBase)NurseBtn).set_UseVisualStyleBackColor(true);
		((ButtonBase)DoctorBtn).set_AutoSize(true);
		((Control)DoctorBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)DoctorBtn).set_Location(new Point(65, 84));
		((Control)DoctorBtn).set_Name("DoctorBtn");
		((Control)DoctorBtn).set_Size(new Size(87, 23));
		((Control)DoctorBtn).set_TabIndex(5);
		DoctorBtn.set_TabStop(true);
		((ButtonBase)DoctorBtn).set_Text("Doctor");
		((ButtonBase)DoctorBtn).set_UseVisualStyleBackColor(true);
		((ButtonBase)SearchBtn).set_BackColor(Color.MidnightBlue);
		((Control)SearchBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)SearchBtn).set_ForeColor(Color.White);
		((Control)SearchBtn).set_Location(new Point(467, 73));
		((Control)SearchBtn).set_Name("SearchBtn");
		((Control)SearchBtn).set_Size(new Size(133, 37));
		((Control)SearchBtn).set_TabIndex(4);
		((ButtonBase)SearchBtn).set_Text("Search");
		((ButtonBase)SearchBtn).set_UseVisualStyleBackColor(false);
		((Control)NameSTxt).set_Location(new Point(120, 44));
		((Control)NameSTxt).set_Name("NameSTxt");
		((Control)NameSTxt).set_Size(new Size(292, 28));
		((Control)NameSTxt).set_TabIndex(1);
		((Control)Label2).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(37, 44));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(77, 28));
		((Control)Label2).set_TabIndex(0);
		Label2.set_Text("Name : ");
		Label2.set_TextAlign((ContentAlignment)32);
		SearchResultGrid.set_BackgroundColor(Color.White);
		SearchResultGrid.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)SearchResultGrid).set_Location(new Point(59, 295));
		((Control)SearchResultGrid).set_Name("SearchResultGrid");
		SearchResultGrid.get_RowTemplate().set_Height(24);
		((Control)SearchResultGrid).set_Size(new Size(853, 169));
		((Control)SearchResultGrid).set_TabIndex(9);
		((Control)DetailsBox).get_Controls().Add((Control)(object)GenderTxt);
		((Control)DetailsBox).get_Controls().Add((Control)(object)DesignationTxt);
		((Control)DetailsBox).get_Controls().Add((Control)(object)DOBTxt);
		((Control)DetailsBox).get_Controls().Add((Control)(object)WorkShiftTxt);
		((Control)DetailsBox).get_Controls().Add((Control)(object)Label12);
		((Control)DetailsBox).get_Controls().Add((Control)(object)SIDTxt);
		((Control)DetailsBox).get_Controls().Add((Control)(object)Label11);
		((Control)DetailsBox).get_Controls().Add((Control)(object)ShowAvailability);
		((Control)DetailsBox).get_Controls().Add((Control)(object)Label3);
		((Control)DetailsBox).get_Controls().Add((Control)(object)MobileTxt);
		((Control)DetailsBox).get_Controls().Add((Control)(object)Label9);
		((Control)DetailsBox).get_Controls().Add((Control)(object)EmailTxt);
		((Control)DetailsBox).get_Controls().Add((Control)(object)Label8);
		((Control)DetailsBox).get_Controls().Add((Control)(object)AddressTxt);
		((Control)DetailsBox).get_Controls().Add((Control)(object)NameTxt);
		((Control)DetailsBox).get_Controls().Add((Control)(object)Label7);
		((Control)DetailsBox).get_Controls().Add((Control)(object)Label6);
		((Control)DetailsBox).get_Controls().Add((Control)(object)Label5);
		((Control)DetailsBox).get_Controls().Add((Control)(object)Label4);
		((Control)DetailsBox).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)DetailsBox).set_Location(new Point(79, 470));
		((Control)DetailsBox).set_Name("DetailsBox");
		((Control)DetailsBox).set_Size(new Size(699, 313));
		((Control)DetailsBox).set_TabIndex(10);
		DetailsBox.set_TabStop(false);
		DetailsBox.set_Text("Staff Member Detail");
		DOBTxt.set_Format((DateTimePickerFormat)2);
		((Control)DOBTxt).set_Location(new Point(505, 118));
		DOBTxt.set_MaxDate(new DateTime(2019, 2, 12, 0, 0, 0, 0));
		DOBTxt.set_MinDate(new DateTime(1900, 1, 1, 0, 0, 0, 0));
		((Control)DOBTxt).set_Name("DOBTxt");
		((Control)DOBTxt).set_Size(new Size(171, 28));
		((Control)DOBTxt).set_TabIndex(18);
		DOBTxt.set_Value(new DateTime(2019, 2, 12, 0, 0, 0, 0));
		WorkShiftTxt.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)WorkShiftTxt).set_FormattingEnabled(true);
		WorkShiftTxt.get_Items().AddRange(new object[2] { "Day", "Night" });
		((Control)WorkShiftTxt).set_Location(new Point(542, 217));
		((Control)WorkShiftTxt).set_Name("WorkShiftTxt");
		((Control)WorkShiftTxt).set_Size(new Size(134, 30));
		((Control)WorkShiftTxt).set_TabIndex(19);
		((Control)Label12).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label12).set_Location(new Point(417, 223));
		((Control)Label12).set_Name("Label12");
		((Control)Label12).set_Size(new Size(118, 26));
		((Control)Label12).set_TabIndex(18);
		Label12.set_Text("Work Shift : ");
		((Control)SIDTxt).set_Location(new Point(124, 36));
		((Control)SIDTxt).set_Name("SIDTxt");
		((TextBoxBase)SIDTxt).set_ReadOnly(true);
		((Control)SIDTxt).set_Size(new Size(204, 28));
		((Control)SIDTxt).set_TabIndex(17);
		((Control)Label11).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label11).set_Location(new Point(16, 36));
		((Control)Label11).set_Name("Label11");
		((Control)Label11).set_Size(new Size(68, 25));
		((Control)Label11).set_TabIndex(16);
		Label11.set_Text("SID :");
		((Control)ShowAvailability).set_BackColor(Color.Red);
		((Control)ShowAvailability).set_Location(new Point(450, 24));
		((Control)ShowAvailability).set_Name("ShowAvailability");
		((Control)ShowAvailability).set_Size(new Size(204, 23));
		((Control)ShowAvailability).set_TabIndex(15);
		ShowAvailability.set_Text("UnAvailable");
		ShowAvailability.set_TextAlign((ContentAlignment)32);
		((Control)Label3).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_Location(new Point(367, 72));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(134, 28));
		((Control)Label3).set_TabIndex(13);
		Label3.set_Text("Designation : ");
		Label3.set_TextAlign((ContentAlignment)32);
		((Control)MobileTxt).set_Location(new Point(124, 169));
		((Control)MobileTxt).set_Name("MobileTxt");
		((Control)MobileTxt).set_Size(new Size(271, 28));
		((Control)MobileTxt).set_TabIndex(12);
		((Control)Label9).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_Location(new Point(16, 169));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(77, 28));
		((Control)Label9).set_TabIndex(11);
		Label9.set_Text("Phone : ");
		Label9.set_TextAlign((ContentAlignment)32);
		((Control)EmailTxt).set_Location(new Point(124, 123));
		((Control)EmailTxt).set_Name("EmailTxt");
		((Control)EmailTxt).set_Size(new Size(271, 28));
		((Control)EmailTxt).set_TabIndex(10);
		((Control)Label8).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_Location(new Point(16, 78));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(77, 28));
		((Control)Label8).set_TabIndex(9);
		Label8.set_Text("Name : ");
		Label8.set_TextAlign((ContentAlignment)32);
		((Control)AddressTxt).set_Location(new Point(124, 217));
		AddressTxt.set_Multiline(true);
		((Control)AddressTxt).set_Name("AddressTxt");
		((Control)AddressTxt).set_Size(new Size(271, 90));
		((Control)AddressTxt).set_TabIndex(7);
		((Control)NameTxt).set_Location(new Point(124, 77));
		((Control)NameTxt).set_Name("NameTxt");
		((Control)NameTxt).set_Size(new Size(237, 28));
		((Control)NameTxt).set_TabIndex(4);
		((Control)Label7).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_Location(new Point(16, 217));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(98, 26));
		((Control)Label7).set_TabIndex(3);
		Label7.set_Text("Address : ");
		((Control)Label6).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_Location(new Point(417, 169));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(84, 26));
		((Control)Label6).set_TabIndex(2);
		Label6.set_Text("Gender : ");
		((Control)Label5).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_Location(new Point(417, 123));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(84, 26));
		((Control)Label5).set_TabIndex(1);
		Label5.set_Text("D.O.B. :");
		((Control)Label4).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_Location(new Point(16, 126));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(68, 25));
		((Control)Label4).set_TabIndex(0);
		Label4.set_Text("Email :");
		((ButtonBase)UpdateBtn).set_BackColor(Color.MidnightBlue);
		((Control)UpdateBtn).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)UpdateBtn).set_ForeColor(Color.White);
		((Control)UpdateBtn).set_Location(new Point(790, 608));
		((Control)UpdateBtn).set_Name("UpdateBtn");
		((Control)UpdateBtn).set_Size(new Size(122, 33));
		((Control)UpdateBtn).set_TabIndex(16);
		((ButtonBase)UpdateBtn).set_Text("Update");
		((ButtonBase)UpdateBtn).set_UseVisualStyleBackColor(false);
		((ButtonBase)DeleteBtn).set_BackColor(Color.MidnightBlue);
		((Control)DeleteBtn).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)DeleteBtn).set_ForeColor(Color.White);
		((Control)DeleteBtn).set_Location(new Point(790, 680));
		((Control)DeleteBtn).set_Name("DeleteBtn");
		((Control)DeleteBtn).set_Size(new Size(122, 33));
		((Control)DeleteBtn).set_TabIndex(17);
		((ButtonBase)DeleteBtn).set_Text("Delete");
		((ButtonBase)DeleteBtn).set_UseVisualStyleBackColor(false);
		DesignationTxt.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)DesignationTxt).set_FormattingEnabled(true);
		DesignationTxt.get_Items().AddRange(new object[4] { "Doctor", "Nurse", "Receptionist", "Admin" });
		((Control)DesignationTxt).set_Location(new Point(505, 72));
		((Control)DesignationTxt).set_Name("DesignationTxt");
		((Control)DesignationTxt).set_Size(new Size(170, 30));
		((Control)DesignationTxt).set_TabIndex(20);
		GenderTxt.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)GenderTxt).set_FormattingEnabled(true);
		GenderTxt.get_Items().AddRange(new object[3] { "Male", "Female", "Others" });
		((Control)GenderTxt).set_Location(new Point(521, 163));
		((Control)GenderTxt).set_Name("GenderTxt");
		((Control)GenderTxt).set_Size(new Size(156, 30));
		((Control)GenderTxt).set_TabIndex(21);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Control)this).get_Controls().Add((Control)(object)DeleteBtn);
		((Control)this).get_Controls().Add((Control)(object)UpdateBtn);
		((Control)this).get_Controls().Add((Control)(object)DetailsBox);
		((Control)this).get_Controls().Add((Control)(object)SearchResultGrid);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).set_Name("UpdateStaff_Admin");
		((Control)this).set_Size(new Size(977, 804));
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((ISupportInitialize)SearchResultGrid).EndInit();
		((Control)DetailsBox).ResumeLayout(false);
		((Control)DetailsBox).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void UpdateStaff_Admin_Load(object sender, EventArgs e)
	{
		myconnection.set_ConnectionString(MyProject.Forms.Form1.provider + MyProject.Forms.Form1.datafile);
		Designation = "";
		DOBTxt.set_MaxDate(Conversions.ToDate(Strings.Format((object)DateTime.Now, "dd-MM-yyyy")));
		Hidedata();
	}

	private void SearchBtn_Click(object sender, EventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		Hidedata();
		if (!MyProject.Forms.Form1.Name_Validation(NameSTxt.get_Text().ToLower()))
		{
			MessageBox.Show("Enter Valid Name");
			return;
		}
		if (Operators.CompareString(Designation, "", false) == 0)
		{
			MessageBox.Show("click designation");
			return;
		}
		try
		{
			DataTable dataTable = new DataTable();
			OleDbDataAdapter val = new OleDbDataAdapter();
			myconnection.Open();
			val = new OleDbDataAdapter("Select * from Staff where Name like '%" + NameSTxt.get_Text() + "%'  And   Designation = '" + Designation + "'", myconnection);
			((DbDataAdapter)(object)val).Fill(dataTable);
			SearchResultGrid.set_DataSource((object)dataTable.DefaultView);
			if (SearchResultGrid.get_RowCount() == 1)
			{
				MessageBox.Show("Not Found.", "Result");
				myconnection.Close();
			}
			else
			{
				((Control)SearchResultGrid).Show();
				myconnection.Close();
				HideunusedColumns();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			myconnection.Close();
			MessageBox.Show("Incorrect Credentials");
			ProjectData.ClearProjectError();
		}
	}

	private bool HideunusedColumns()
	{
		SearchResultGrid.get_Columns().get_Item(7).set_Visible(false);
		SearchResultGrid.get_Columns().get_Item(9).set_Visible(false);
		return false;
	}

	private void RadioButton1_CheckedChanged(object sender, EventArgs e)
	{
		Designation = "Doctor";
	}

	private void RadioButton2_CheckedChanged(object sender, EventArgs e)
	{
		Designation = "Nurse";
	}

	private void RadioButton3_CheckedChanged(object sender, EventArgs e)
	{
		Designation = "Receptionist";
	}

	private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		if (!((checked(e.get_RowIndex() + 1) == SearchResultGrid.get_RowCount()) | (e.get_RowIndex() == -1)))
		{
			selectrow = e.get_RowIndex();
			((Control)DetailsBox).set_Visible(true);
			((Control)UpdateBtn).Show();
			((Control)DeleteBtn).Show();
			try
			{
				DataGridViewRow val = new DataGridViewRow();
				val = SearchResultGrid.get_Rows().get_Item(selectrow);
				SIDTxt.set_Text(val.get_Cells().get_Item(0).get_Value()
					.ToString());
				NameTxt.set_Text(val.get_Cells().get_Item(1).get_Value()
					.ToString());
				DesignationTxt.set_Text(val.get_Cells().get_Item(2).get_Value()
					.ToString());
				DOBTxt.set_Text(Conversions.ToString(val.get_Cells().get_Item(3).get_Value()));
				GenderTxt.set_Text(val.get_Cells().get_Item(4).get_Value()
					.ToString());
				MobileTxt.set_Text(val.get_Cells().get_Item(5).get_Value()
					.ToString());
				AddressTxt.set_Text(val.get_Cells().get_Item(6).get_Value()
					.ToString());
				WorkShiftTxt.set_Text(val.get_Cells().get_Item(8).get_Value()
					.ToString());
				putcolor(Conversions.ToString(val.get_Cells().get_Item(8).get_Value()));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Hidedata()
	{
		((Control)DetailsBox).set_Visible(false);
		((Control)SearchResultGrid).Hide();
		((Control)UpdateBtn).Hide();
		((Control)DeleteBtn).Hide();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		((TextBoxBase)NameSTxt).Clear();
		((Control)SearchResultGrid).Hide();
		DoctorBtn.set_Checked(false);
		NurseBtn.set_Checked(false);
		Receptionistbtn.set_Checked(false);
		((Control)DetailsBox).set_Visible(false);
		Designation = "";
		((Control)UpdateBtn).Hide();
		((Control)DeleteBtn).Hide();
	}

	private void putcolor(string WorkShift)
	{
		if (Operators.CompareString(Shift(), WorkShift, false) == 0)
		{
			colourgreen();
		}
		else
		{
			colourred();
		}
	}

	private string Shift()
	{
		if ((day >= 7) & (day <= 19))
		{
			return "Day";
		}
		return "Night";
	}

	private void colourgreen()
	{
		((Control)ShowAvailability).set_BackColor(Color.Green);
		ShowAvailability.set_Text("Available");
	}

	private void colourred()
	{
		((Control)ShowAvailability).set_BackColor(Color.Red);
		ShowAvailability.set_Text("Unavilable");
	}

	private void UpadateBtn_Click(object sender, EventArgs e)
	{
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.CompareString(NameTxt.get_Text(), "", false) == 0) | (Operators.CompareString(MobileTxt.get_Text(), "", false) == 0) | (Operators.CompareString(GenderTxt.get_Text(), "", false) == 0) | (Operators.CompareString(DOBTxt.get_Text(), "", false) == 0) | (Operators.CompareString(DesignationTxt.get_Text(), "", false) == 0) | (Operators.CompareString(AddressTxt.get_Text(), "", false) == 0) | (Operators.CompareString(WorkShiftTxt.get_Text(), "", false) == 0))
		{
			MessageBox.Show("Fields Cannot be empty");
			return;
		}
		DateTime dateTime = Conversions.ToDate(Strings.Format((object)DOBTxt.get_Value(), "dd-MM-yyyy"));
		string text = "Update [Staff] set [Date Of Birth] = #" + Conversions.ToString(dateTime) + "#, [Mobile]='" + MobileTxt.get_Text() + "',[Work Shift]='" + WorkShiftTxt.get_Text() + "',[Address]='" + AddressTxt.get_Text() + "'where [SID] = " + SIDTxt.get_Text() + " ";
		if (!(MyProject.Forms.Form1.Mobile_Validator(MobileTxt.get_Text().ToLower()) & MyProject.Forms.Form1.Name_Validation(NameTxt.get_Text().ToLower()) & MyProject.Forms.Form1.Gender_Validator(GenderTxt.get_Text().ToLower())))
		{
			MessageBox.Show("Invalid Credentials");
			return;
		}
		myconnection.Open();
		OleDbCommand val = new OleDbCommand(text, myconnection);
		try
		{
			val.ExecuteNonQuery();
			((Component)(object)val).Dispose();
			ClearDetailsBox();
			MessageBox.Show("Updated Sucessfully");
			myconnection.Close();
			UpdateTable();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"Invalid Credentials", (MsgBoxStyle)0, (object)null);
			myconnection.Close();
			ProjectData.ClearProjectError();
		}
	}

	private void DeleteBtn_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		new DataGridViewRow();
		SearchResultGrid.get_Rows().get_Item(selectrow);
		if (Operators.CompareString(SIDTxt.get_Text(), "", false) == 0)
		{
			MessageBox.Show("No Data To Delete");
			return;
		}
		string text = "Delete from [Staff] where [SID] = " + SIDTxt.get_Text() + " ";
		myconnection.Open();
		OleDbCommand val = new OleDbCommand(text, myconnection);
		try
		{
			val.ExecuteNonQuery();
			((Component)(object)val).Dispose();
			myconnection.Close();
			MessageBox.Show("Deleted  Sucessfully");
			UpdateTable();
			ClearDetailsBox();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			myconnection.Close();
			ProjectData.ClearProjectError();
		}
	}

	private bool UpdateTable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		new OleDbCommand();
		string text = "Select * From [Staff] Where [Name] Like '%" + NameSTxt.get_Text().ToLower() + "%' And [Designation] Like '%" + Designation + "%';";
		DataTable dataTable = new DataTable();
		myconnection.Open();
		try
		{
			OleDbDataAdapter val = new OleDbDataAdapter(text, myconnection);
			((DbDataAdapter)(object)val).Fill(dataTable);
			SearchResultGrid.set_DataSource((object)dataTable);
			if (SearchResultGrid.get_RowCount() == 1)
			{
				myconnection.Close();
				return false;
			}
			((Control)SearchResultGrid).set_Visible(true);
			myconnection.Close();
			HideunusedColumns();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			MessageBox.Show("Error updating table");
			myconnection.Close();
			ProjectData.ClearProjectError();
		}
		return true;
	}

	private bool ClearDetailsBox()
	{
		((TextBoxBase)SIDTxt).Clear();
		((TextBoxBase)NameTxt).Clear();
		((TextBoxBase)MobileTxt).Clear();
		DOBTxt.set_Value(Conversions.ToDate(Strings.Format((object)DateTime.Now, "dd-MM-yyyy")));
		((TextBoxBase)AddressTxt).Clear();
		GenderTxt.set_SelectedIndex(-1);
		((TextBoxBase)EmailTxt).Clear();
		DesignationTxt.set_SelectedIndex(-1);
		WorkShiftTxt.set_SelectedIndex(-1);
		return true;
	}
}
