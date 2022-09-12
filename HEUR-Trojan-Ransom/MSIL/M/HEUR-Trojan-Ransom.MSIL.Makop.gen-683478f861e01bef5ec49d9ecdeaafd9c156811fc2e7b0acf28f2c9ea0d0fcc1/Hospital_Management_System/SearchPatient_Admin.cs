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
public class SearchPatient_Admin : UserControl
{
	private IContainer components;

	private OleDbConnection myconnection;

	private string mobile_search;

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
			DataGridViewCellMouseEventHandler val = new DataGridViewCellMouseEventHandler(SearchResultGrid_CellMouseClick);
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

	[field: AccessedThroughProperty("NameTxt")]
	internal virtual TextBox NameTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
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

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
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
	internal virtual DateTimePicker DOBTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public SearchPatient_Admin()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		((UserControl)this).add_Load((EventHandler)SearchPatient_Admin_Load);
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
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected O, but got Unknown
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected O, but got Unknown
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected O, but got Unknown
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Expected O, but got Unknown
		//IL_0899: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a3: Expected O, but got Unknown
		//IL_0963: Unknown result type (might be due to invalid IL or missing references)
		//IL_096d: Expected O, but got Unknown
		//IL_0ac7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad1: Expected O, but got Unknown
		//IL_0b3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b48: Expected O, but got Unknown
		//IL_0bb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbc: Expected O, but got Unknown
		//IL_0c26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c30: Expected O, but got Unknown
		//IL_0ca7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb1: Expected O, but got Unknown
		//IL_0d57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d61: Expected O, but got Unknown
		//IL_0e07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e11: Expected O, but got Unknown
		PictureBox1 = new PictureBox();
		Label1 = new Label();
		GroupBox1 = new GroupBox();
		SearchBtn = new Button();
		Label3 = new Label();
		MobileSTxt = new TextBox();
		NameSTxt = new TextBox();
		Label2 = new Label();
		SearchResultGrid = new DataGridView();
		PatientInfoBox = new GroupBox();
		DOBTxt = new DateTimePicker();
		MobileTxt = new TextBox();
		Label10 = new Label();
		NameTxt = new TextBox();
		Label14 = new Label();
		AddressTxt = new TextBox();
		GenderTxt = new TextBox();
		PIDTxt = new TextBox();
		Label7 = new Label();
		Label6 = new Label();
		Label5 = new Label();
		Label4 = new Label();
		ClearBtn = new Button();
		UpdateBtn = new Button();
		DeleteBtn = new Button();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)SearchResultGrid).BeginInit();
		((Control)PatientInfoBox).SuspendLayout();
		((Control)this).SuspendLayout();
		PictureBox1.set_Image((Image)(object)Resources.patient_pic);
		((Control)PictureBox1).set_Location(new Point(256, 19));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(130, 125));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(9);
		PictureBox1.set_TabStop(false);
		((Control)Label1).set_Font(new Font("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(392, 63));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(330, 47));
		((Control)Label1).set_TabIndex(10);
		Label1.set_Text("Search Patient");
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
		((Control)GroupBox1).set_TabIndex(11);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Search Patient");
		((ButtonBase)SearchBtn).set_BackColor(Color.MidnightBlue);
		((Control)SearchBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)SearchBtn).set_ForeColor(Color.White);
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
		Label3.set_Text("Mobile : ");
		Label3.set_TextAlign((ContentAlignment)32);
		((Control)MobileSTxt).set_Location(new Point(120, 86));
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
		((Control)SearchResultGrid).set_TabIndex(12);
		((Control)SearchResultGrid).set_Visible(false);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)DOBTxt);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)MobileTxt);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)Label10);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)NameTxt);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)Label14);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)AddressTxt);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)GenderTxt);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)PIDTxt);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)Label7);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)Label6);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)Label5);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)Label4);
		((Control)PatientInfoBox).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)PatientInfoBox).set_Location(new Point(59, 486));
		((Control)PatientInfoBox).set_Name("PatientInfoBox");
		((Control)PatientInfoBox).set_Size(new Size(860, 231));
		((Control)PatientInfoBox).set_TabIndex(13);
		PatientInfoBox.set_TabStop(false);
		PatientInfoBox.set_Text("Patient Information");
		((Control)PatientInfoBox).set_Visible(false);
		DOBTxt.set_Format((DateTimePickerFormat)2);
		((Control)DOBTxt).set_Location(new Point(124, 132));
		DOBTxt.set_MaxDate(new DateTime(2019, 2, 11, 0, 0, 0, 0));
		DOBTxt.set_MinDate(new DateTime(1900, 1, 1, 0, 0, 0, 0));
		((Control)DOBTxt).set_Name("DOBTxt");
		((Control)DOBTxt).set_Size(new Size(166, 28));
		((Control)DOBTxt).set_TabIndex(12);
		DOBTxt.set_Value(new DateTime(2019, 2, 11, 0, 0, 0, 0));
		((Control)MobileTxt).set_Location(new Point(554, 83));
		((Control)MobileTxt).set_Name("MobileTxt");
		((Control)MobileTxt).set_Size(new Size(258, 28));
		((Control)MobileTxt).set_TabIndex(11);
		((Control)Label10).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label10).set_Location(new Point(472, 86));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(76, 28));
		((Control)Label10).set_TabIndex(10);
		Label10.set_Text("Mobile :");
		Label10.set_TextAlign((ContentAlignment)32);
		((Control)NameTxt).set_Location(new Point(124, 89));
		((Control)NameTxt).set_Name("NameTxt");
		((Control)NameTxt).set_Size(new Size(315, 28));
		((Control)NameTxt).set_TabIndex(9);
		((Control)Label14).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label14).set_Location(new Point(13, 89));
		((Control)Label14).set_Name("Label14");
		((Control)Label14).set_Size(new Size(80, 25));
		((Control)Label14).set_TabIndex(8);
		Label14.set_Text("Name :");
		((Control)AddressTxt).set_Location(new Point(554, 128));
		AddressTxt.set_Multiline(true);
		((Control)AddressTxt).set_Name("AddressTxt");
		((Control)AddressTxt).set_Size(new Size(258, 90));
		((Control)AddressTxt).set_TabIndex(7);
		((Control)GenderTxt).set_Location(new Point(124, 178));
		((Control)GenderTxt).set_Name("GenderTxt");
		((Control)GenderTxt).set_Size(new Size(166, 28));
		((Control)GenderTxt).set_TabIndex(6);
		((Control)PIDTxt).set_Location(new Point(124, 43));
		((Control)PIDTxt).set_Name("PIDTxt");
		((TextBoxBase)PIDTxt).set_ReadOnly(true);
		((Control)PIDTxt).set_Size(new Size(116, 28));
		((Control)PIDTxt).set_TabIndex(4);
		((Control)Label7).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_Location(new Point(452, 132));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(96, 26));
		((Control)Label7).set_TabIndex(3);
		Label7.set_Text("Address : ");
		((Control)Label6).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_Location(new Point(13, 180));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(84, 26));
		((Control)Label6).set_TabIndex(2);
		Label6.set_Text("Gender : ");
		((Control)Label5).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_Location(new Point(13, 134));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(68, 26));
		((Control)Label5).set_TabIndex(1);
		Label5.set_Text("DOB :");
		((Control)Label4).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_Location(new Point(13, 43));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(68, 25));
		((Control)Label4).set_TabIndex(0);
		Label4.set_Text("PID :");
		((ButtonBase)ClearBtn).set_BackColor(Color.MidnightBlue);
		((Control)ClearBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)ClearBtn).set_ForeColor(Color.White);
		((Control)ClearBtn).set_Location(new Point(546, 747));
		((Control)ClearBtn).set_Name("ClearBtn");
		((Control)ClearBtn).set_Size(new Size(97, 37));
		((Control)ClearBtn).set_TabIndex(15);
		((ButtonBase)ClearBtn).set_Text("Clear");
		((ButtonBase)ClearBtn).set_UseVisualStyleBackColor(false);
		((Control)ClearBtn).set_Visible(false);
		((ButtonBase)UpdateBtn).set_BackColor(Color.MidnightBlue);
		((Control)UpdateBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)UpdateBtn).set_ForeColor(Color.White);
		((Control)UpdateBtn).set_Location(new Point(681, 747));
		((Control)UpdateBtn).set_Name("UpdateBtn");
		((Control)UpdateBtn).set_Size(new Size(97, 37));
		((Control)UpdateBtn).set_TabIndex(16);
		((ButtonBase)UpdateBtn).set_Text("Update");
		((ButtonBase)UpdateBtn).set_UseVisualStyleBackColor(false);
		((Control)UpdateBtn).set_Visible(false);
		((ButtonBase)DeleteBtn).set_BackColor(Color.MidnightBlue);
		((Control)DeleteBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)DeleteBtn).set_ForeColor(Color.White);
		((Control)DeleteBtn).set_Location(new Point(815, 747));
		((Control)DeleteBtn).set_Name("DeleteBtn");
		((Control)DeleteBtn).set_Size(new Size(97, 37));
		((Control)DeleteBtn).set_TabIndex(17);
		((ButtonBase)DeleteBtn).set_Text("Delete");
		((ButtonBase)DeleteBtn).set_UseVisualStyleBackColor(false);
		((Control)DeleteBtn).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Control)this).get_Controls().Add((Control)(object)DeleteBtn);
		((Control)this).get_Controls().Add((Control)(object)UpdateBtn);
		((Control)this).get_Controls().Add((Control)(object)ClearBtn);
		((Control)this).get_Controls().Add((Control)(object)PatientInfoBox);
		((Control)this).get_Controls().Add((Control)(object)SearchResultGrid);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).set_Name("SearchPatient_Admin");
		((Control)this).set_Size(new Size(977, 804));
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((ISupportInitialize)SearchResultGrid).EndInit();
		((Control)PatientInfoBox).ResumeLayout(false);
		((Control)PatientInfoBox).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void SearchPatient_Admin_Load(object sender, EventArgs e)
	{
		myconnection.set_ConnectionString(MyProject.Forms.Form1.provider + MyProject.Forms.Form1.datafile);
		HideItemsOnForm();
		DOBTxt.set_MaxDate(Conversions.ToDate(Strings.Format((object)DateTime.Now, "dd-MM-yyyy")));
	}

	private void SearchBtn_Click(object sender, EventArgs e)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		if (!MyProject.Forms.Form1.Name_Validation(NameSTxt.get_Text().ToLower()) | !MyProject.Forms.Form1.Mobile_Validator(MobileSTxt.get_Text().ToLower()))
		{
			MessageBox.Show("No Results Found");
			return;
		}
		HideItemsOnForm();
		new OleDbCommand();
		string text = "Select * From [Patient] Where [Name] Like '%" + NameSTxt.get_Text().ToLower() + "%' And [Mobile] Like '%" + MobileSTxt.get_Text() + "%';";
		DataTable dataTable = new DataTable();
		myconnection.Open();
		try
		{
			OleDbDataAdapter val = new OleDbDataAdapter(text, myconnection);
			((DbDataAdapter)(object)val).Fill(dataTable);
			SearchResultGrid.set_DataSource((object)dataTable);
			if (SearchResultGrid.get_RowCount() == 1)
			{
				MessageBox.Show("No Result Found");
				myconnection.Close();
				return;
			}
			((Control)SearchResultGrid).set_Visible(true);
			myconnection.Close();
			name_search = NameSTxt.get_Text().ToLower();
			mobile_search = MobileSTxt.get_Text();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			myconnection.Close();
			ProjectData.ClearProjectError();
		}
	}

	private bool HideItemsOnForm()
	{
		((Control)SearchResultGrid).set_Visible(false);
		((Control)PatientInfoBox).set_Visible(false);
		((Control)ClearBtn).set_Visible(false);
		((Control)UpdateBtn).set_Visible(false);
		((Control)DeleteBtn).set_Visible(false);
		return true;
	}

	private void DeleteBtn_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(PIDTxt.get_Text(), "", false) == 0)
		{
			MessageBox.Show("Nothing To Delete");
			return;
		}
		OleDbCommand val = new OleDbCommand();
		string text = "Delete From [Patient] Where [PID] = " + PIDTxt.get_Text() + ";";
		myconnection.Open();
		try
		{
			val = new OleDbCommand(text, myconnection);
			val.ExecuteNonQuery();
			((Component)(object)val).Dispose();
			myconnection.Close();
			UpdateTable();
			ClearPatientInfo();
			MessageBox.Show("Successfully Deleted Entry");
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
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.CompareString(NameTxt.get_Text(), "", false) == 0) | (Operators.CompareString(MobileSTxt.get_Text(), "", false) == 0) | (Operators.CompareString(GenderTxt.get_Text(), "", false) == 0) | (Operators.CompareString(AddressTxt.get_Text(), "", false) == 0))
		{
			MessageBox.Show("Empty Fields Not Allowed");
			return;
		}
		if (!(MyProject.Forms.Form1.Name_Validation(NameTxt.get_Text().ToLower()) & MyProject.Forms.Form1.Mobile_Validator(MobileSTxt.get_Text()) & MyProject.Forms.Form1.Gender_Validator(GenderTxt.get_Text().ToLower())))
		{
			MessageBox.Show("Invalid Credentials");
			return;
		}
		OleDbCommand val = new OleDbCommand();
		DateTime dateTime = Conversions.ToDate(Strings.Format((object)DOBTxt.get_Value(), "dd-MM-yyyy"));
		string text = "Update [Patient] Set [Name] = '" + NameTxt.get_Text() + "', [DOB] = #" + Conversions.ToString(dateTime) + "#, [Mobile] = '" + MobileTxt.get_Text() + "', [Gender] = '" + GenderTxt.get_Text() + "', [Address] = '" + AddressTxt.get_Text() + "' Where [PID] = " + PIDTxt.get_Text() + ";";
		myconnection.Open();
		try
		{
			val = new OleDbCommand(text, myconnection);
			val.ExecuteNonQuery();
			((Component)(object)val).Dispose();
			myconnection.Close();
			MessageBox.Show("Successfully Updated Details");
			ClearPatientInfo();
			UpdateTable();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			myconnection.Close();
			ProjectData.ClearProjectError();
		}
	}

	private void ClearBtn_Click(object sender, EventArgs e)
	{
		ClearPatientInfo();
	}

	private bool UpdateTable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		new OleDbCommand();
		string text = "Select * From [Patient] Where [Name] Like '%" + name_search.ToLower() + "%' And [Mobile] Like '%" + mobile_search + "%';";
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
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			myconnection.Close();
			ProjectData.ClearProjectError();
		}
		return false;
	}

	private void SearchResultGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		try
		{
			PIDTxt.set_Text(Conversions.ToString(SearchResultGrid.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(0)
				.get_Value()));
			NameTxt.set_Text(Conversions.ToString(SearchResultGrid.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(1)
				.get_Value()));
			DOBTxt.set_Text(Conversions.ToString(SearchResultGrid.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(2)
				.get_Value()));
			GenderTxt.set_Text(Conversions.ToString(SearchResultGrid.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(3)
				.get_Value()));
			AddressTxt.set_Text(Conversions.ToString(SearchResultGrid.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(5)
				.get_Value()));
			MobileTxt.set_Text(Conversions.ToString(SearchResultGrid.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(4)
				.get_Value()));
			((Control)PatientInfoBox).set_Visible(true);
			((Control)ClearBtn).set_Visible(true);
			((Control)UpdateBtn).set_Visible(true);
			((Control)DeleteBtn).set_Visible(true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private bool ClearPatientInfo()
	{
		((TextBoxBase)PIDTxt).Clear();
		((TextBoxBase)NameTxt).Clear();
		((TextBoxBase)MobileTxt).Clear();
		DOBTxt.set_Value(Conversions.ToDate(Strings.Format((object)DateAndTime.get_Today(), "dd-MM-yyyy")));
		((TextBoxBase)AddressTxt).Clear();
		((TextBoxBase)GenderTxt).Clear();
		return true;
	}
}
