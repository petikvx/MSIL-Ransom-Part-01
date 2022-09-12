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
using Microsoft.VisualBasic.CompilerServices;

namespace Hospital_Management_System;

[DesignerGenerated]
public class Availability : UserControl
{
	private IContainer components;

	private string Designation;

	private OleDbConnection myconnection;

	private int day;

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

	internal virtual RadioButton ReceptionistBtn
	{
		[CompilerGenerated]
		get
		{
			return _ReceptionistBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = RadioButton3_CheckedChanged;
			RadioButton receptionistBtn = _ReceptionistBtn;
			if (receptionistBtn != null)
			{
				receptionistBtn.remove_CheckedChanged(eventHandler);
			}
			_ReceptionistBtn = value;
			receptionistBtn = _ReceptionistBtn;
			if (receptionistBtn != null)
			{
				receptionistBtn.add_CheckedChanged(eventHandler);
			}
		}
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

	[field: AccessedThroughProperty("NameTxt")]
	internal virtual TextBox NameTxt
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

	[field: AccessedThroughProperty("GenderTxt")]
	internal virtual TextBox GenderTxt
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

	[field: AccessedThroughProperty("SIDTxt")]
	internal virtual TextBox SIDTxt
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DesignationTxt")]
	internal virtual TextBox DesignationTxt
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

	public Availability()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		((UserControl)this).add_Load((EventHandler)Availability_Load);
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
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected O, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected O, but got Unknown
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected O, but got Unknown
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected O, but got Unknown
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected O, but got Unknown
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Expected O, but got Unknown
		//IL_08c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cc: Expected O, but got Unknown
		//IL_0a1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a25: Expected O, but got Unknown
		//IL_0af4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afe: Expected O, but got Unknown
		//IL_0bca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd4: Expected O, but got Unknown
		//IL_0daa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db4: Expected O, but got Unknown
		//IL_0e1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e28: Expected O, but got Unknown
		//IL_0e95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9f: Expected O, but got Unknown
		//IL_0f09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f13: Expected O, but got Unknown
		Label1 = new Label();
		GroupBox1 = new GroupBox();
		ClearBtn = new Button();
		ReceptionistBtn = new RadioButton();
		NurseBtn = new RadioButton();
		DoctorBtn = new RadioButton();
		SearchBtn = new Button();
		NameSTxt = new TextBox();
		Label2 = new Label();
		SearchResultGrid = new DataGridView();
		DetailsBox = new GroupBox();
		ShowAvailability = new Label();
		DesignationTxt = new TextBox();
		Label3 = new Label();
		MobileTxt = new TextBox();
		Label9 = new Label();
		NameTxt = new TextBox();
		Label8 = new Label();
		AddressTxt = new TextBox();
		GenderTxt = new TextBox();
		DOBTxt = new TextBox();
		SIDTxt = new TextBox();
		Label7 = new Label();
		Label6 = new Label();
		Label5 = new Label();
		Label4 = new Label();
		PictureBox1 = new PictureBox();
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)SearchResultGrid).BeginInit();
		((Control)DetailsBox).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(392, 63));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(270, 35));
		((Control)Label1).set_TabIndex(5);
		Label1.set_Text("Staff Availability");
		Label1.set_TextAlign((ContentAlignment)32);
		((Control)GroupBox1).get_Controls().Add((Control)(object)ClearBtn);
		((Control)GroupBox1).get_Controls().Add((Control)(object)ReceptionistBtn);
		((Control)GroupBox1).get_Controls().Add((Control)(object)NurseBtn);
		((Control)GroupBox1).get_Controls().Add((Control)(object)DoctorBtn);
		((Control)GroupBox1).get_Controls().Add((Control)(object)SearchBtn);
		((Control)GroupBox1).get_Controls().Add((Control)(object)NameSTxt);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox1).set_Location(new Point(155, 150));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(623, 127));
		((Control)GroupBox1).set_TabIndex(7);
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
		((ButtonBase)ReceptionistBtn).set_AutoSize(true);
		((Control)ReceptionistBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)ReceptionistBtn).set_Location(new Point(280, 84));
		((Control)ReceptionistBtn).set_Name("ReceptionistBtn");
		((Control)ReceptionistBtn).set_Size(new Size(132, 23));
		((Control)ReceptionistBtn).set_TabIndex(7);
		ReceptionistBtn.set_TabStop(true);
		((ButtonBase)ReceptionistBtn).set_Text("Receptionist");
		((ButtonBase)ReceptionistBtn).set_UseVisualStyleBackColor(true);
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
		SearchResultGrid.set_ReadOnly(true);
		SearchResultGrid.get_RowTemplate().set_Height(24);
		((Control)SearchResultGrid).set_Size(new Size(853, 169));
		((Control)SearchResultGrid).set_TabIndex(8);
		((Control)DetailsBox).get_Controls().Add((Control)(object)ShowAvailability);
		((Control)DetailsBox).get_Controls().Add((Control)(object)DesignationTxt);
		((Control)DetailsBox).get_Controls().Add((Control)(object)Label3);
		((Control)DetailsBox).get_Controls().Add((Control)(object)MobileTxt);
		((Control)DetailsBox).get_Controls().Add((Control)(object)Label9);
		((Control)DetailsBox).get_Controls().Add((Control)(object)NameTxt);
		((Control)DetailsBox).get_Controls().Add((Control)(object)Label8);
		((Control)DetailsBox).get_Controls().Add((Control)(object)AddressTxt);
		((Control)DetailsBox).get_Controls().Add((Control)(object)GenderTxt);
		((Control)DetailsBox).get_Controls().Add((Control)(object)DOBTxt);
		((Control)DetailsBox).get_Controls().Add((Control)(object)SIDTxt);
		((Control)DetailsBox).get_Controls().Add((Control)(object)Label7);
		((Control)DetailsBox).get_Controls().Add((Control)(object)Label6);
		((Control)DetailsBox).get_Controls().Add((Control)(object)Label5);
		((Control)DetailsBox).get_Controls().Add((Control)(object)Label4);
		((Control)DetailsBox).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)DetailsBox).set_Location(new Point(155, 470));
		((Control)DetailsBox).set_Name("DetailsBox");
		((Control)DetailsBox).set_Size(new Size(623, 313));
		((Control)DetailsBox).set_TabIndex(9);
		DetailsBox.set_TabStop(false);
		DetailsBox.set_Text("Staff Member Detail");
		((Control)ShowAvailability).set_BackColor(Color.Red);
		((Control)ShowAvailability).set_Location(new Point(389, 24));
		((Control)ShowAvailability).set_Name("ShowAvailability");
		((Control)ShowAvailability).set_Size(new Size(218, 23));
		((Control)ShowAvailability).set_TabIndex(15);
		ShowAvailability.set_Text("UnAvailable");
		ShowAvailability.set_TextAlign((ContentAlignment)32);
		((Control)DesignationTxt).set_Location(new Point(428, 71));
		((Control)DesignationTxt).set_Name("DesignationTxt");
		((TextBoxBase)DesignationTxt).set_ReadOnly(true);
		((Control)DesignationTxt).set_Size(new Size(179, 28));
		((Control)DesignationTxt).set_TabIndex(14);
		((Control)Label3).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_Location(new Point(291, 72));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(121, 28));
		((Control)Label3).set_TabIndex(13);
		Label3.set_Text("Designation : ");
		Label3.set_TextAlign((ContentAlignment)32);
		((Control)MobileTxt).set_Location(new Point(124, 169));
		((Control)MobileTxt).set_Name("MobileTxt");
		((TextBoxBase)MobileTxt).set_ReadOnly(true);
		((Control)MobileTxt).set_Size(new Size(241, 28));
		((Control)MobileTxt).set_TabIndex(12);
		((Control)Label9).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_Location(new Point(16, 169));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(77, 28));
		((Control)Label9).set_TabIndex(11);
		Label9.set_Text("Phone : ");
		Label9.set_TextAlign((ContentAlignment)32);
		((Control)NameTxt).set_Location(new Point(124, 123));
		((Control)NameTxt).set_Name("NameTxt");
		((TextBoxBase)NameTxt).set_ReadOnly(true);
		((Control)NameTxt).set_Size(new Size(241, 28));
		((Control)NameTxt).set_TabIndex(10);
		((Control)Label8).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_Location(new Point(20, 124));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(77, 28));
		((Control)Label8).set_TabIndex(9);
		Label8.set_Text("Name : ");
		Label8.set_TextAlign((ContentAlignment)32);
		((Control)AddressTxt).set_Location(new Point(124, 217));
		AddressTxt.set_Multiline(true);
		((Control)AddressTxt).set_Name("AddressTxt");
		((TextBoxBase)AddressTxt).set_ReadOnly(true);
		((Control)AddressTxt).set_Size(new Size(483, 90));
		((Control)AddressTxt).set_TabIndex(7);
		((Control)GenderTxt).set_Location(new Point(479, 163));
		((Control)GenderTxt).set_Name("GenderTxt");
		((TextBoxBase)GenderTxt).set_ReadOnly(true);
		((Control)GenderTxt).set_Size(new Size(128, 28));
		((Control)GenderTxt).set_TabIndex(6);
		((Control)DOBTxt).set_Location(new Point(479, 121));
		((Control)DOBTxt).set_Name("DOBTxt");
		((TextBoxBase)DOBTxt).set_ReadOnly(true);
		((Control)DOBTxt).set_Size(new Size(128, 28));
		((Control)DOBTxt).set_TabIndex(5);
		((Control)SIDTxt).set_Location(new Point(124, 77));
		((Control)SIDTxt).set_Name("SIDTxt");
		((TextBoxBase)SIDTxt).set_ReadOnly(true);
		((Control)SIDTxt).set_Size(new Size(100, 28));
		((Control)SIDTxt).set_TabIndex(4);
		((Control)Label7).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_Location(new Point(16, 217));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(98, 26));
		((Control)Label7).set_TabIndex(3);
		Label7.set_Text("Address : ");
		((Control)Label6).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_Location(new Point(389, 169));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(84, 26));
		((Control)Label6).set_TabIndex(2);
		Label6.set_Text("Gender : ");
		((Control)Label5).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_Location(new Point(389, 123));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(84, 26));
		((Control)Label5).set_TabIndex(1);
		Label5.set_Text("D.O.B. :");
		((Control)Label4).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_Location(new Point(25, 77));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(68, 25));
		((Control)Label4).set_TabIndex(0);
		Label4.set_Text("SID :");
		PictureBox1.set_Image((Image)(object)Resources.images);
		((Control)PictureBox1).set_Location(new Point(260, 22));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(126, 122));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(4);
		PictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Control)this).get_Controls().Add((Control)(object)DetailsBox);
		((Control)this).get_Controls().Add((Control)(object)SearchResultGrid);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).set_Name("Availability");
		((Control)this).set_Size(new Size(977, 804));
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((ISupportInitialize)SearchResultGrid).EndInit();
		((Control)DetailsBox).ResumeLayout(false);
		((Control)DetailsBox).PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Availability_Load(object sender, EventArgs e)
	{
		myconnection.set_ConnectionString(MyProject.Forms.Form1.provider + MyProject.Forms.Form1.datafile);
		Designation = "";
		close();
	}

	private void SearchBtn_Click(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		close();
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
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		if ((checked(e.get_RowIndex() + 1) == SearchResultGrid.get_RowCount()) | (e.get_RowIndex() == -1))
		{
			return;
		}
		int rowIndex = e.get_RowIndex();
		((Control)DetailsBox).set_Visible(true);
		try
		{
			DataGridViewRow val = new DataGridViewRow();
			val = SearchResultGrid.get_Rows().get_Item(rowIndex);
			SIDTxt.set_Text(val.get_Cells().get_Item(0).get_Value()
				.ToString());
			NameTxt.set_Text(val.get_Cells().get_Item(1).get_Value()
				.ToString());
			MobileTxt.set_Text(val.get_Cells().get_Item(5).get_Value()
				.ToString());
			AddressTxt.set_Text(val.get_Cells().get_Item(6).get_Value()
				.ToString());
			DesignationTxt.set_Text(val.get_Cells().get_Item(2).get_Value()
				.ToString());
			DOBTxt.set_Text(Conversions.ToString(val.get_Cells().get_Item(3).get_Value()));
			GenderTxt.set_Text(val.get_Cells().get_Item(4).get_Value()
				.ToString());
			if (Operators.ConditionalCompareObjectEqual((object)Shift(), val.get_Cells().get_Item(8).get_Value(), false))
			{
				colourgreen();
			}
			else
			{
				colourred();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void close()
	{
		((Control)DetailsBox).set_Visible(false);
		((Control)SearchResultGrid).Hide();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		((TextBoxBase)NameSTxt).Clear();
		((Control)SearchResultGrid).Hide();
		DoctorBtn.set_Checked(false);
		NurseBtn.set_Checked(false);
		ReceptionistBtn.set_Checked(false);
		((Control)DetailsBox).set_Visible(false);
		Designation = "";
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
		ShowAvailability.set_Text("Unavailable");
	}
}
