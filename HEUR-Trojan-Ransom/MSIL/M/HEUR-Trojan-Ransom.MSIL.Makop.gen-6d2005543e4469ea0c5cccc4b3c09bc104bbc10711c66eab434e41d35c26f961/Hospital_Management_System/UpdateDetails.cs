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
public class UpdateDetails : UserControl
{
	private IContainer components;

	private OleDbConnection myconnection;

	private int selectrow;

	private string mobile;

	private string name_search;

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
			EventHandler eventHandler = Button1_Click;
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MobileSTxt")]
	internal virtual TextBox MobileSTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("PatientInfoBox")]
	internal virtual GroupBox PatientInfoBox
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

	[field: AccessedThroughProperty("PIDTxt")]
	internal virtual TextBox PIDTxt
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

	[field: AccessedThroughProperty("NameTxt")]
	internal virtual TextBox NameTxt
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

	public UpdateDetails()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		((UserControl)this).add_Load((EventHandler)UpdateDetails_Load);
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
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected O, but got Unknown
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected O, but got Unknown
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Expected O, but got Unknown
		//IL_0761: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Expected O, but got Unknown
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_0841: Expected O, but got Unknown
		//IL_0a08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a12: Expected O, but got Unknown
		//IL_0a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a86: Expected O, but got Unknown
		//IL_0af3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afd: Expected O, but got Unknown
		//IL_0b67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b71: Expected O, but got Unknown
		//IL_0be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf2: Expected O, but got Unknown
		//IL_0c8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c99: Expected O, but got Unknown
		Label1 = new Label();
		GroupBox1 = new GroupBox();
		SearchBtn = new Button();
		Label3 = new Label();
		MobileSTxt = new TextBox();
		NameSTxt = new TextBox();
		Label2 = new Label();
		SearchResultGrid = new DataGridView();
		PatientInfoBox = new GroupBox();
		MobileTxt = new TextBox();
		Label9 = new Label();
		NameTxt = new TextBox();
		Label8 = new Label();
		AddressTxt = new TextBox();
		GenderTxt = new TextBox();
		DOBTxt = new TextBox();
		PIDTxt = new TextBox();
		Label7 = new Label();
		Label6 = new Label();
		Label5 = new Label();
		Label4 = new Label();
		UpdateBtn = new Button();
		ClearBtn = new Button();
		PictureBox1 = new PictureBox();
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)SearchResultGrid).BeginInit();
		((Control)PatientInfoBox).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(392, 63));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(250, 35));
		((Control)Label1).set_TabIndex(4);
		Label1.set_Text("Update Details ");
		Label1.set_TextAlign((ContentAlignment)32);
		((Control)GroupBox1).get_Controls().Add((Control)(object)SearchBtn);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)MobileSTxt);
		((Control)GroupBox1).get_Controls().Add((Control)(object)NameSTxt);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox1).set_Location(new Point(155, 150));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(623, 128));
		((Control)GroupBox1).set_TabIndex(6);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Search Patient");
		((ButtonBase)SearchBtn).set_BackColor(Color.MidnightBlue);
		((Control)SearchBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)SearchBtn).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)SearchBtn).set_Location(new Point(468, 82));
		((Control)SearchBtn).set_Name("SearchBtn");
		((Control)SearchBtn).set_Size(new Size(133, 37));
		((Control)SearchBtn).set_TabIndex(4);
		((ButtonBase)SearchBtn).set_Text("Search");
		((ButtonBase)SearchBtn).set_UseVisualStyleBackColor(false);
		((Control)Label3).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_Location(new Point(37, 87));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(77, 28));
		((Control)Label3).set_TabIndex(3);
		Label3.set_Text("Phone : ");
		Label3.set_TextAlign((ContentAlignment)32);
		((Control)MobileSTxt).set_Location(new Point(120, 94));
		((Control)MobileSTxt).set_Name("MobileSTxt");
		((Control)MobileSTxt).set_Size(new Size(237, 28));
		((Control)MobileSTxt).set_TabIndex(2);
		((Control)NameSTxt).set_Location(new Point(120, 44));
		((Control)NameSTxt).set_Name("NameSTxt");
		((Control)NameSTxt).set_Size(new Size(237, 28));
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
		((Control)SearchResultGrid).set_TabIndex(7);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)MobileTxt);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)Label9);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)NameTxt);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)Label8);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)AddressTxt);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)GenderTxt);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)DOBTxt);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)PIDTxt);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)Label7);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)Label6);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)Label5);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)Label4);
		((Control)PatientInfoBox).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)PatientInfoBox).set_Location(new Point(108, 480));
		((Control)PatientInfoBox).set_Name("PatientInfoBox");
		((Control)PatientInfoBox).set_Size(new Size(623, 292));
		((Control)PatientInfoBox).set_TabIndex(8);
		PatientInfoBox.set_TabStop(false);
		PatientInfoBox.set_Text("Patient Information");
		((Control)MobileTxt).set_Location(new Point(124, 132));
		((Control)MobileTxt).set_Name("MobileTxt");
		((Control)MobileTxt).set_Size(new Size(244, 28));
		((Control)MobileTxt).set_TabIndex(12);
		((Control)Label9).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_Location(new Point(20, 132));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(77, 28));
		((Control)Label9).set_TabIndex(11);
		Label9.set_Text("Phone : ");
		Label9.set_TextAlign((ContentAlignment)32);
		((Control)NameTxt).set_Location(new Point(124, 92));
		((Control)NameTxt).set_Name("NameTxt");
		((TextBoxBase)NameTxt).set_ReadOnly(true);
		((Control)NameTxt).set_Size(new Size(244, 28));
		((Control)NameTxt).set_TabIndex(10);
		((Control)Label8).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_Location(new Point(20, 88));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(77, 28));
		((Control)Label8).set_TabIndex(9);
		Label8.set_Text("Name : ");
		Label8.set_TextAlign((ContentAlignment)32);
		((Control)AddressTxt).set_Location(new Point(124, 182));
		AddressTxt.set_Multiline(true);
		((Control)AddressTxt).set_Name("AddressTxt");
		((Control)AddressTxt).set_Size(new Size(480, 90));
		((Control)AddressTxt).set_TabIndex(7);
		((Control)GenderTxt).set_Location(new Point(473, 125));
		((Control)GenderTxt).set_Name("GenderTxt");
		((TextBoxBase)GenderTxt).set_ReadOnly(true);
		((Control)GenderTxt).set_Size(new Size(131, 28));
		((Control)GenderTxt).set_TabIndex(6);
		((Control)DOBTxt).set_Location(new Point(457, 88));
		((Control)DOBTxt).set_Name("DOBTxt");
		((TextBoxBase)DOBTxt).set_ReadOnly(true);
		((Control)DOBTxt).set_Size(new Size(147, 28));
		((Control)DOBTxt).set_TabIndex(5);
		((Control)PIDTxt).set_Location(new Point(124, 43));
		((Control)PIDTxt).set_Name("PIDTxt");
		((TextBoxBase)PIDTxt).set_ReadOnly(true);
		((Control)PIDTxt).set_Size(new Size(100, 28));
		((Control)PIDTxt).set_TabIndex(4);
		((Control)Label7).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_Location(new Point(20, 182));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(98, 26));
		((Control)Label7).set_TabIndex(3);
		Label7.set_Text("Address : ");
		((Control)Label6).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_Location(new Point(383, 132));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(84, 26));
		((Control)Label6).set_TabIndex(2);
		Label6.set_Text("Gender : ");
		((Control)Label5).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_Location(new Point(383, 93));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(68, 26));
		((Control)Label5).set_TabIndex(1);
		Label5.set_Text("DOB :");
		((Control)Label4).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_Location(new Point(20, 46));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(68, 25));
		((Control)Label4).set_TabIndex(0);
		Label4.set_Text("PID :");
		((ButtonBase)UpdateBtn).set_BackColor(Color.MidnightBlue);
		((Control)UpdateBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)UpdateBtn).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)UpdateBtn).set_Location(new Point(779, 563));
		((Control)UpdateBtn).set_Name("UpdateBtn");
		((Control)UpdateBtn).set_Size(new Size(133, 37));
		((Control)UpdateBtn).set_TabIndex(9);
		((ButtonBase)UpdateBtn).set_Text("Update ");
		((ButtonBase)UpdateBtn).set_UseVisualStyleBackColor(false);
		((ButtonBase)ClearBtn).set_BackColor(Color.MidnightBlue);
		((Control)ClearBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)ClearBtn).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)ClearBtn).set_Location(new Point(779, 651));
		((Control)ClearBtn).set_Name("ClearBtn");
		((Control)ClearBtn).set_Size(new Size(133, 37));
		((Control)ClearBtn).set_TabIndex(10);
		((ButtonBase)ClearBtn).set_Text("Clear");
		((ButtonBase)ClearBtn).set_UseVisualStyleBackColor(false);
		PictureBox1.set_Image((Image)(object)Resources.useless_pic);
		((Control)PictureBox1).set_Location(new Point(260, 22));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(126, 122));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(3);
		PictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Control)this).get_Controls().Add((Control)(object)ClearBtn);
		((Control)this).get_Controls().Add((Control)(object)UpdateBtn);
		((Control)this).get_Controls().Add((Control)(object)PatientInfoBox);
		((Control)this).get_Controls().Add((Control)(object)SearchResultGrid);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).set_Name("UpdateDetails");
		((Control)this).set_Size(new Size(977, 804));
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((ISupportInitialize)SearchResultGrid).EndInit();
		((Control)PatientInfoBox).ResumeLayout(false);
		((Control)PatientInfoBox).PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void UpdateDetails_Load(object sender, EventArgs e)
	{
		myconnection.set_ConnectionString(MyProject.Forms.Form1.provider + MyProject.Forms.Form1.datafile);
		Hidedata();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		Hidedata();
		if (!MyProject.Forms.Form1.Name_Validation(NameSTxt.get_Text().ToLower()) | !MyProject.Forms.Form1.Mobile_Validator(MobileSTxt.get_Text().ToLower()))
		{
			MessageBox.Show("No Results Found");
			return;
		}
		try
		{
			DataTable dataTable = new DataTable();
			OleDbDataAdapter val = new OleDbDataAdapter();
			myconnection.Open();
			val = new OleDbDataAdapter("Select * from Patient where Name like '%" + NameSTxt.get_Text() + "%'  And   Mobile like '%" + MobileSTxt.get_Text() + "%' ", myconnection);
			((DbDataAdapter)(object)val).Fill(dataTable);
			SearchResultGrid.set_DataSource((object)dataTable.DefaultView);
			if (SearchResultGrid.get_RowCount() == 1)
			{
				MessageBox.Show("Not Found.", "Result");
				myconnection.Close();
				return;
			}
			((Control)SearchResultGrid).Show();
			myconnection.Close();
			mobile = MobileSTxt.get_Text();
			name_search = NameSTxt.get_Text();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			myconnection.Close();
			MessageBox.Show("Incorrect Credentials");
			ProjectData.ClearProjectError();
		}
	}

	private void UpdateBtn_Click(object sender, EventArgs e)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		string text = "Update [Patient] set [Mobile]='" + MobileTxt.get_Text() + "',[Address]='" + AddressTxt.get_Text() + "'where [PID] = " + PIDTxt.get_Text() + " ";
		if (!(MyProject.Forms.Form1.Mobile_Validator(MobileTxt.get_Text().ToLower()) & (Operators.CompareString(AddressTxt.get_Text(), "", false) != 0)))
		{
			MessageBox.Show("Enter Valid Phone number");
			return;
		}
		myconnection.Open();
		OleDbCommand val = new OleDbCommand(text, myconnection);
		try
		{
			val.ExecuteNonQuery();
			((Component)(object)val).Dispose();
			updatedatagrid();
			MessageBox.Show("Updated Sucessfully");
			myconnection.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			myconnection.Close();
			ProjectData.ClearProjectError();
		}
	}

	private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		if (!((checked(e.get_RowIndex() + 1) == SearchResultGrid.get_RowCount()) | (e.get_RowIndex() == -1)))
		{
			selectrow = e.get_RowIndex();
			try
			{
				((Control)PatientInfoBox).set_Visible(true);
				((Control)UpdateBtn).Show();
				((Control)ClearBtn).Show();
				selectrow = e.get_RowIndex();
				DataGridViewRow val = new DataGridViewRow();
				val = SearchResultGrid.get_Rows().get_Item(selectrow);
				PIDTxt.set_Text(val.get_Cells().get_Item(0).get_Value()
					.ToString());
				NameTxt.set_Text(val.get_Cells().get_Item(1).get_Value()
					.ToString());
				DOBTxt.set_Text(Conversions.ToString(val.get_Cells().get_Item(2).get_Value()));
				MobileTxt.set_Text(val.get_Cells().get_Item(4).get_Value()
					.ToString());
				GenderTxt.set_Text(val.get_Cells().get_Item(3).get_Value()
					.ToString());
				AddressTxt.set_Text(val.get_Cells().get_Item(5).get_Value()
					.ToString());
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
		((Control)PatientInfoBox).set_Visible(false);
		((Control)SearchResultGrid).Hide();
		((Control)UpdateBtn).Hide();
		((Control)ClearBtn).Hide();
	}

	private void updatedatagrid()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		DataGridViewRow val = new DataGridViewRow();
		val = SearchResultGrid.get_Rows().get_Item(selectrow);
		val.get_Cells().get_Item(2).set_Value((object)DOBTxt.get_Text());
		val.get_Cells().get_Item(4).set_Value((object)MobileTxt.get_Text());
		val.get_Cells().get_Item(5).set_Value((object)AddressTxt.get_Text());
	}

	private void ClearBtn_Click(object sender, EventArgs e)
	{
		((TextBoxBase)PIDTxt).Clear();
		((TextBoxBase)NameTxt).Clear();
		((TextBoxBase)DOBTxt).Clear();
		((TextBoxBase)MobileTxt).Clear();
		((TextBoxBase)GenderTxt).Clear();
		((TextBoxBase)AddressTxt).Clear();
	}
}
