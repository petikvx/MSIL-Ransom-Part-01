using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hospital_Management_System.My;
using Hospital_Management_System.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace Hospital_Management_System;

[DesignerGenerated]
public class CheckUp : UserControl
{
	private IContainer components;

	private OleDbConnection myconnection;

	private string mobile;

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

	[field: AccessedThroughProperty("SearchBox")]
	internal virtual GroupBox SearchBox
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

	[field: AccessedThroughProperty("NameSTxt")]
	internal virtual TextBox NameSTxt
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

	[field: AccessedThroughProperty("PatientInfoBox")]
	internal virtual GroupBox PatientInfoBox
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

	[field: AccessedThroughProperty("PIDTxt")]
	internal virtual TextBox PIDTxt
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

	[field: AccessedThroughProperty("PaymentBox")]
	internal virtual GroupBox PaymentBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RoomNoTxt")]
	internal virtual TextBox RoomNoTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
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

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TokenNoTxt")]
	internal virtual TextBox TokenNoTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FeesTxt")]
	internal virtual TextBox FeesTxt
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

	internal virtual Button PrintBtn
	{
		[CompilerGenerated]
		get
		{
			return _PrintBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = PrintBtn_Click;
			Button printBtn = _PrintBtn;
			if (printBtn != null)
			{
				((Control)printBtn).remove_Click(eventHandler);
			}
			_PrintBtn = value;
			printBtn = _PrintBtn;
			if (printBtn != null)
			{
				((Control)printBtn).add_Click(eventHandler);
			}
		}
	}

	internal virtual PrintDocument PrintDocument1
	{
		[CompilerGenerated]
		get
		{
			return _PrintDocument1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			PrintPageEventHandler val = new PrintPageEventHandler(PrintDocument1_PrintPage);
			PrintDocument printDocument = _PrintDocument1;
			if (printDocument != null)
			{
				printDocument.remove_PrintPage(val);
			}
			_PrintDocument1 = value;
			printDocument = _PrintDocument1;
			if (printDocument != null)
			{
				printDocument.add_PrintPage(val);
			}
		}
	}

	[field: AccessedThroughProperty("PrintDialog1")]
	internal virtual PrintDialog PrintDialog1
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

	[field: AccessedThroughProperty("NameTxt")]
	internal virtual TextBox NameTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public CheckUp()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		((UserControl)this).add_Load((EventHandler)CheckUp_Load);
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
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected O, but got Unknown
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected O, but got Unknown
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected O, but got Unknown
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Expected O, but got Unknown
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected O, but got Unknown
		//IL_0736: Unknown result type (might be due to invalid IL or missing references)
		//IL_0740: Expected O, but got Unknown
		//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Expected O, but got Unknown
		//IL_0825: Unknown result type (might be due to invalid IL or missing references)
		//IL_082f: Expected O, but got Unknown
		//IL_08a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ae: Expected O, but got Unknown
		//IL_0914: Unknown result type (might be due to invalid IL or missing references)
		//IL_091e: Expected O, but got Unknown
		//IL_0984: Unknown result type (might be due to invalid IL or missing references)
		//IL_098e: Expected O, but got Unknown
		//IL_09f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fe: Expected O, but got Unknown
		//IL_0a68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a72: Expected O, but got Unknown
		//IL_0adc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae6: Expected O, but got Unknown
		//IL_0b5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b64: Expected O, but got Unknown
		//IL_0c4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c59: Expected O, but got Unknown
		//IL_0cd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce2: Expected O, but got Unknown
		//IL_0d46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d50: Expected O, but got Unknown
		//IL_0db3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbd: Expected O, but got Unknown
		//IL_0e20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2a: Expected O, but got Unknown
		//IL_0e9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea8: Expected O, but got Unknown
		//IL_0f1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f26: Expected O, but got Unknown
		//IL_0faa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb4: Expected O, but got Unknown
		//IL_104d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1057: Expected O, but got Unknown
		Label1 = new Label();
		SearchResultGrid = new DataGridView();
		SearchBox = new GroupBox();
		SearchBtn = new Button();
		Label3 = new Label();
		MobileTxt = new TextBox();
		NameSTxt = new TextBox();
		Label2 = new Label();
		PatientInfoBox = new GroupBox();
		NameTxt = new TextBox();
		Label11 = new Label();
		AddressTxt = new TextBox();
		GenderTxt = new TextBox();
		DOBTxt = new TextBox();
		PIDTxt = new TextBox();
		Label7 = new Label();
		Label6 = new Label();
		Label5 = new Label();
		Label4 = new Label();
		PaymentBox = new GroupBox();
		FeesTxt = new TextBox();
		TokenNoTxt = new TextBox();
		RoomNoTxt = new TextBox();
		Label10 = new Label();
		Label9 = new Label();
		Label8 = new Label();
		ClearBtn = new Button();
		PrintBtn = new Button();
		PrintDocument1 = new PrintDocument();
		PrintDialog1 = new PrintDialog();
		PictureBox1 = new PictureBox();
		((ISupportInitialize)SearchResultGrid).BeginInit();
		((Control)SearchBox).SuspendLayout();
		((Control)PatientInfoBox).SuspendLayout();
		((Control)PaymentBox).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Label1).set_Font(new Font("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(392, 60));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(261, 47));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Check-Up");
		Label1.set_TextAlign((ContentAlignment)32);
		SearchResultGrid.set_BackgroundColor(Color.White);
		SearchResultGrid.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)SearchResultGrid).set_Location(new Point(59, 295));
		((Control)SearchResultGrid).set_Name("SearchResultGrid");
		SearchResultGrid.set_ReadOnly(true);
		SearchResultGrid.get_RowTemplate().set_Height(24);
		((Control)SearchResultGrid).set_Size(new Size(853, 169));
		((Control)SearchResultGrid).set_TabIndex(3);
		((Control)SearchBox).get_Controls().Add((Control)(object)SearchBtn);
		((Control)SearchBox).get_Controls().Add((Control)(object)Label3);
		((Control)SearchBox).get_Controls().Add((Control)(object)MobileTxt);
		((Control)SearchBox).get_Controls().Add((Control)(object)NameSTxt);
		((Control)SearchBox).get_Controls().Add((Control)(object)Label2);
		((Control)SearchBox).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)SearchBox).set_Location(new Point(179, 151));
		((Control)SearchBox).set_Name("SearchBox");
		((Control)SearchBox).set_Size(new Size(623, 128));
		((Control)SearchBox).set_TabIndex(4);
		SearchBox.set_TabStop(false);
		SearchBox.set_Text("Search Patient");
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
		((Control)MobileTxt).set_Location(new Point(120, 87));
		((Control)MobileTxt).set_Name("MobileTxt");
		((Control)MobileTxt).set_Size(new Size(237, 28));
		((Control)MobileTxt).set_TabIndex(2);
		((Control)NameSTxt).set_Location(new Point(120, 43));
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
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)NameTxt);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)Label11);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)AddressTxt);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)GenderTxt);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)DOBTxt);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)PIDTxt);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)Label7);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)Label6);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)Label5);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)Label4);
		((Control)PatientInfoBox).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)PatientInfoBox).set_Location(new Point(101, 485));
		((Control)PatientInfoBox).set_Name("PatientInfoBox");
		((Control)PatientInfoBox).set_Size(new Size(439, 255));
		((Control)PatientInfoBox).set_TabIndex(5);
		PatientInfoBox.set_TabStop(false);
		PatientInfoBox.set_Text("Patient Information");
		((Control)NameTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)NameTxt).set_Location(new Point(94, 80));
		((Control)NameTxt).set_Name("NameTxt");
		((TextBoxBase)NameTxt).set_ReadOnly(true);
		((Control)NameTxt).set_Size(new Size(328, 26));
		((Control)NameTxt).set_TabIndex(9);
		((Control)Label11).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label11).set_Location(new Point(20, 80));
		((Control)Label11).set_Name("Label11");
		((Control)Label11).set_Size(new Size(76, 26));
		((Control)Label11).set_TabIndex(8);
		Label11.set_Text("Name :");
		Label11.set_TextAlign((ContentAlignment)32);
		((Control)AddressTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)AddressTxt).set_Location(new Point(124, 159));
		AddressTxt.set_Multiline(true);
		((Control)AddressTxt).set_Name("AddressTxt");
		((TextBoxBase)AddressTxt).set_ReadOnly(true);
		((Control)AddressTxt).set_Size(new Size(298, 90));
		((Control)AddressTxt).set_TabIndex(7);
		((Control)GenderTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)GenderTxt).set_Location(new Point(322, 115));
		((Control)GenderTxt).set_Name("GenderTxt");
		((TextBoxBase)GenderTxt).set_ReadOnly(true);
		((Control)GenderTxt).set_Size(new Size(100, 26));
		((Control)GenderTxt).set_TabIndex(6);
		((Control)DOBTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)DOBTxt).set_Location(new Point(94, 115));
		((Control)DOBTxt).set_Name("DOBTxt");
		((TextBoxBase)DOBTxt).set_ReadOnly(true);
		((Control)DOBTxt).set_Size(new Size(130, 26));
		((Control)DOBTxt).set_TabIndex(5);
		((Control)PIDTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)PIDTxt).set_Location(new Point(94, 43));
		((Control)PIDTxt).set_Name("PIDTxt");
		((TextBoxBase)PIDTxt).set_ReadOnly(true);
		((Control)PIDTxt).set_Size(new Size(130, 26));
		((Control)PIDTxt).set_TabIndex(4);
		((Control)Label7).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_Location(new Point(20, 159));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(105, 26));
		((Control)Label7).set_TabIndex(3);
		Label7.set_Text("Address : ");
		((Control)Label6).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_Location(new Point(230, 113));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(84, 26));
		((Control)Label6).set_TabIndex(2);
		Label6.set_Text("Gender : ");
		((Control)Label5).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_Location(new Point(20, 115));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(68, 26));
		((Control)Label5).set_TabIndex(1);
		Label5.set_Text("DOB :");
		Label5.set_TextAlign((ContentAlignment)32);
		((Control)Label4).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_Location(new Point(20, 46));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(68, 25));
		((Control)Label4).set_TabIndex(0);
		Label4.set_Text("PID :");
		((Control)PaymentBox).get_Controls().Add((Control)(object)FeesTxt);
		((Control)PaymentBox).get_Controls().Add((Control)(object)TokenNoTxt);
		((Control)PaymentBox).get_Controls().Add((Control)(object)RoomNoTxt);
		((Control)PaymentBox).get_Controls().Add((Control)(object)Label10);
		((Control)PaymentBox).get_Controls().Add((Control)(object)Label9);
		((Control)PaymentBox).get_Controls().Add((Control)(object)Label8);
		((Control)PaymentBox).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)PaymentBox).set_Location(new Point(589, 485));
		((Control)PaymentBox).set_Name("PaymentBox");
		((Control)PaymentBox).set_Size(new Size(286, 165));
		((Control)PaymentBox).set_TabIndex(6);
		PaymentBox.set_TabStop(false);
		PaymentBox.set_Text("Payment Details");
		((Control)FeesTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)FeesTxt).set_Location(new Point(125, 108));
		((Control)FeesTxt).set_Name("FeesTxt");
		((TextBoxBase)FeesTxt).set_ReadOnly(true);
		((Control)FeesTxt).set_Size(new Size(100, 26));
		((Control)FeesTxt).set_TabIndex(9);
		((Control)TokenNoTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)TokenNoTxt).set_Location(new Point(125, 68));
		((Control)TokenNoTxt).set_Name("TokenNoTxt");
		((TextBoxBase)TokenNoTxt).set_ReadOnly(true);
		((Control)TokenNoTxt).set_Size(new Size(100, 26));
		((Control)TokenNoTxt).set_TabIndex(8);
		((Control)RoomNoTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)RoomNoTxt).set_Location(new Point(125, 34));
		((Control)RoomNoTxt).set_Name("RoomNoTxt");
		((TextBoxBase)RoomNoTxt).set_ReadOnly(true);
		((Control)RoomNoTxt).set_Size(new Size(100, 26));
		((Control)RoomNoTxt).set_TabIndex(7);
		((Control)Label10).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label10).set_Location(new Point(18, 114));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(101, 25));
		((Control)Label10).set_TabIndex(3);
		Label10.set_Text("Fees  :");
		Label10.set_TextAlign((ContentAlignment)32);
		((Control)Label9).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_Location(new Point(18, 71));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(107, 28));
		((Control)Label9).set_TabIndex(2);
		Label9.set_Text("Token No :");
		Label9.set_TextAlign((ContentAlignment)32);
		((Control)Label8).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_Location(new Point(18, 34));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(101, 25));
		((Control)Label8).set_TabIndex(1);
		Label8.set_Text("Room No :");
		Label8.set_TextAlign((ContentAlignment)32);
		((ButtonBase)ClearBtn).set_BackColor(Color.MidnightBlue);
		((Control)ClearBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)ClearBtn).set_ForeColor(Color.White);
		((Control)ClearBtn).set_Location(new Point(589, 696));
		((Control)ClearBtn).set_Name("ClearBtn");
		((Control)ClearBtn).set_Size(new Size(119, 44));
		((Control)ClearBtn).set_TabIndex(7);
		((ButtonBase)ClearBtn).set_Text("Clear");
		((ButtonBase)ClearBtn).set_UseVisualStyleBackColor(false);
		((ButtonBase)PrintBtn).set_BackColor(Color.MidnightBlue);
		((Control)PrintBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)PrintBtn).set_ForeColor(Color.White);
		((Control)PrintBtn).set_Location(new Point(756, 696));
		((Control)PrintBtn).set_Name("PrintBtn");
		((Control)PrintBtn).set_Size(new Size(119, 44));
		((Control)PrintBtn).set_TabIndex(8);
		((ButtonBase)PrintBtn).set_Text("Print");
		((ButtonBase)PrintBtn).set_UseVisualStyleBackColor(false);
		PrintDialog1.set_UseEXDialog(true);
		PictureBox1.set_Image((Image)(object)Resources.doc_Pic);
		((Control)PictureBox1).set_Location(new Point(281, 21));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(126, 122));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(2);
		PictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Control)this).get_Controls().Add((Control)(object)PrintBtn);
		((Control)this).get_Controls().Add((Control)(object)ClearBtn);
		((Control)this).get_Controls().Add((Control)(object)PaymentBox);
		((Control)this).get_Controls().Add((Control)(object)PatientInfoBox);
		((Control)this).get_Controls().Add((Control)(object)SearchBox);
		((Control)this).get_Controls().Add((Control)(object)SearchResultGrid);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).set_Name("CheckUp");
		((Control)this).set_Size(new Size(977, 804));
		((ISupportInitialize)SearchResultGrid).EndInit();
		((Control)SearchBox).ResumeLayout(false);
		((Control)SearchBox).PerformLayout();
		((Control)PatientInfoBox).ResumeLayout(false);
		((Control)PatientInfoBox).PerformLayout();
		((Control)PaymentBox).ResumeLayout(false);
		((Control)PaymentBox).PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void CheckUp_Load(object sender, EventArgs e)
	{
		myconnection.set_ConnectionString(MyProject.Forms.Form1.provider + MyProject.Forms.Form1.datafile);
		HideItemsOnForm();
	}

	private void SearchBtn_Click(object sender, EventArgs e)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		HideItemsOnForm();
		if (!MyProject.Forms.Form1.Name_Validation(NameSTxt.get_Text().ToLower()) | !MyProject.Forms.Form1.Mobile_Validator(MobileTxt.get_Text().ToLower()))
		{
			MessageBox.Show("No Result Found");
			return;
		}
		new OleDbCommand();
		string text = "Select * From [Patient] Where [Name] Like '%" + NameSTxt.get_Text().ToLower() + "%' And [Mobile] Like '%" + MobileTxt.get_Text() + "%';";
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
			SetPaymentBoxFields();
			((Control)SearchResultGrid).set_Visible(true);
			myconnection.Close();
			mobile = MobileTxt.get_Text();
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
		((TextBoxBase)NameTxt).Clear();
		((TextBoxBase)GenderTxt).Clear();
		((TextBoxBase)PIDTxt).Clear();
		((TextBoxBase)DOBTxt).Clear();
		((TextBoxBase)AddressTxt).Clear();
		((TextBoxBase)TokenNoTxt).Clear();
		((TextBoxBase)RoomNoTxt).Clear();
		((TextBoxBase)FeesTxt).Clear();
	}

	private void SearchResultGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
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
			((Control)PaymentBox).set_Visible(true);
			((Control)PatientInfoBox).set_Visible(true);
			((Control)ClearBtn).set_Visible(true);
			((Control)PrintBtn).set_Visible(true);
			SetPaymentBoxFields();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private bool SetPaymentBoxFields()
	{
		TokenNoTxt.set_Text(Conversions.ToString(MyProject.Forms.Form1.Current_tokenNo));
		RoomNoTxt.set_Text(Conversions.ToString(checked(MyProject.Forms.Form1.Current_RoomNo + 100)));
		FeesTxt.set_Text("500");
		return true;
	}

	private bool HideItemsOnForm()
	{
		((Control)SearchResultGrid).set_Visible(false);
		((Control)PaymentBox).set_Visible(false);
		((Control)PatientInfoBox).set_Visible(false);
		((Control)ClearBtn).set_Visible(false);
		((Control)PrintBtn).set_Visible(false);
		return true;
	}

	private void PrintBtn_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Invalid comparison between Unknown and I4
		if (Operators.CompareString(PIDTxt.get_Text(), "", false) == 0)
		{
			MessageBox.Show("No Patient to Print");
			return;
		}
		MyProject.Forms.Form1.Current_tokenNo = checked(MyProject.Forms.Form1.Current_tokenNo + 1);
		MyProject.Forms.Form1.Current_RoomNo = checked(MyProject.Forms.Form1.Current_RoomNo + 1) % 8;
		PrintDialog1.set_Document(PrintDocument1);
		PrintDialog1.set_PrinterSettings(PrintDocument1.get_PrinterSettings());
		PrintDialog1.set_AllowSomePages(true);
		if ((int)((CommonDialog)PrintDialog1).ShowDialog() == 1)
		{
			PrintDocument1.set_PrinterSettings(PrintDialog1.get_PrinterSettings());
			PrintDocument1.Print();
		}
	}

	private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		Font val = new Font("Times New Roman", 20f);
		Font val2 = new Font("Times New Roman", 12f);
		e.get_Graphics().DrawString("Check Up", val, Brushes.get_Chocolate(), 250f, 100f);
		e.get_Graphics().DrawString(("Name - " + NameTxt.get_Text()) ?? "", val2, Brushes.get_Chocolate(), 100f, 400f);
		e.get_Graphics().DrawString(("Mobile - " + mobile) ?? "", val2, Brushes.get_Chocolate(), 100f, 800f);
		e.get_Graphics().DrawString(("Token No. - " + TokenNoTxt.get_Text()) ?? "", val2, Brushes.get_Chocolate(), 100f, 1000f);
		e.get_Graphics().DrawString(("Room No. - " + RoomNoTxt.get_Text()) ?? "", val2, Brushes.get_Chocolate(), 100f, 1200f);
		e.get_Graphics().DrawString(("Fees - " + FeesTxt.get_Text()) ?? "", val2, Brushes.get_Chocolate(), 100f, 1400f);
	}
}
