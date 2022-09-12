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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hospital_Management_System;

[DesignerGenerated]
public class Admit : UserControl
{
	private IContainer components;

	private OleDbConnection myconnection;

	private string id;

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

	[field: AccessedThroughProperty("AgeTxt")]
	internal virtual TextBox AgeTxt
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

	[field: AccessedThroughProperty("AdmitDetailsBox")]
	internal virtual GroupBox AdmitDetailsBox
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

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
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

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateOut1Txt")]
	internal virtual TextBox DateOut1Txt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateIn1Txt")]
	internal virtual TextBox DateIn1Txt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("StatusTxt")]
	internal virtual ComboBox StatusTxt
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

	internal virtual Button SaveBtn
	{
		[CompilerGenerated]
		get
		{
			return _SaveBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = SaveBtn_Click;
			Button saveBtn = _SaveBtn;
			if (saveBtn != null)
			{
				((Control)saveBtn).remove_Click(eventHandler);
			}
			_SaveBtn = value;
			saveBtn = _SaveBtn;
			if (saveBtn != null)
			{
				((Control)saveBtn).add_Click(eventHandler);
			}
		}
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

	[field: AccessedThroughProperty("DateOutTxt")]
	internal virtual ComboBox DateOutTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateInTxt")]
	internal virtual ComboBox DateInTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label15")]
	internal virtual Label Label15
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

	[field: AccessedThroughProperty("PrintDialog1")]
	internal virtual PrintDialog PrintDialog1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	internal virtual Button HistoryBtn
	{
		[CompilerGenerated]
		get
		{
			return _HistoryBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = HistoryBtn_Click;
			Button historyBtn = _HistoryBtn;
			if (historyBtn != null)
			{
				((Control)historyBtn).remove_Click(eventHandler);
			}
			_HistoryBtn = value;
			historyBtn = _HistoryBtn;
			if (historyBtn != null)
			{
				((Control)historyBtn).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button AdmitDischargeBtn
	{
		[CompilerGenerated]
		get
		{
			return _AdmitDischargeBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = AdmitDischargeBtn_Click;
			Button admitDischargeBtn = _AdmitDischargeBtn;
			if (admitDischargeBtn != null)
			{
				((Control)admitDischargeBtn).remove_Click(eventHandler);
			}
			_AdmitDischargeBtn = value;
			admitDischargeBtn = _AdmitDischargeBtn;
			if (admitDischargeBtn != null)
			{
				((Control)admitDischargeBtn).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("RoomTypeTxt")]
	internal virtual ComboBox RoomTypeTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RoomNoTxt")]
	internal virtual ComboBox RoomNoTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RoomNo1Txt")]
	internal virtual TextBox RoomNo1Txt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RoomType1Txt")]
	internal virtual TextBox RoomType1Txt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Admit()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		((UserControl)this).add_Load((EventHandler)Admit_Load);
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
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected O, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected O, but got Unknown
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected O, but got Unknown
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected O, but got Unknown
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected O, but got Unknown
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a3: Expected O, but got Unknown
		//IL_087f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0889: Expected O, but got Unknown
		//IL_0945: Unknown result type (might be due to invalid IL or missing references)
		//IL_094f: Expected O, but got Unknown
		//IL_0a6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a78: Expected O, but got Unknown
		//IL_0b34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3e: Expected O, but got Unknown
		//IL_0ba8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb2: Expected O, but got Unknown
		//IL_0c1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c29: Expected O, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9d: Expected O, but got Unknown
		//IL_0e64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6e: Expected O, but got Unknown
		//IL_0f05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0f: Expected O, but got Unknown
		//IL_0f85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8f: Expected O, but got Unknown
		//IL_1033: Unknown result type (might be due to invalid IL or missing references)
		//IL_103d: Expected O, but got Unknown
		//IL_10b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c0: Expected O, but got Unknown
		//IL_1267: Unknown result type (might be due to invalid IL or missing references)
		//IL_1271: Expected O, but got Unknown
		//IL_12e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f3: Expected O, but got Unknown
		//IL_1368: Unknown result type (might be due to invalid IL or missing references)
		//IL_1372: Expected O, but got Unknown
		//IL_1435: Unknown result type (might be due to invalid IL or missing references)
		//IL_143f: Expected O, but got Unknown
		//IL_14b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c0: Expected O, but got Unknown
		//IL_1534: Unknown result type (might be due to invalid IL or missing references)
		//IL_153e: Expected O, but got Unknown
		//IL_15c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15cc: Expected O, but got Unknown
		//IL_1672: Unknown result type (might be due to invalid IL or missing references)
		//IL_167c: Expected O, but got Unknown
		//IL_1722: Unknown result type (might be due to invalid IL or missing references)
		//IL_172c: Expected O, but got Unknown
		//IL_184d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1857: Expected O, but got Unknown
		//IL_1900: Unknown result type (might be due to invalid IL or missing references)
		//IL_190a: Expected O, but got Unknown
		Label1 = new Label();
		GroupBox1 = new GroupBox();
		SearchBtn = new Button();
		Label3 = new Label();
		MobileTxt = new TextBox();
		NameSTxt = new TextBox();
		Label2 = new Label();
		SearchResultGrid = new DataGridView();
		PatientInfoBox = new GroupBox();
		MobileSTxt = new TextBox();
		Label15 = new Label();
		NameTxt = new TextBox();
		Label14 = new Label();
		AddressTxt = new TextBox();
		GenderTxt = new TextBox();
		AgeTxt = new TextBox();
		PIDTxt = new TextBox();
		Label7 = new Label();
		Label6 = new Label();
		Label5 = new Label();
		Label4 = new Label();
		AdmitDetailsBox = new GroupBox();
		RoomNoTxt = new ComboBox();
		RoomTypeTxt = new ComboBox();
		DateOutTxt = new ComboBox();
		DateInTxt = new ComboBox();
		StatusTxt = new ComboBox();
		DateOut1Txt = new TextBox();
		DateIn1Txt = new TextBox();
		Label13 = new Label();
		Label12 = new Label();
		Label11 = new Label();
		FeesTxt = new TextBox();
		Label10 = new Label();
		Label9 = new Label();
		Label8 = new Label();
		ClearBtn = new Button();
		PrintBtn = new Button();
		SaveBtn = new Button();
		PrintDialog1 = new PrintDialog();
		PrintDocument1 = new PrintDocument();
		PictureBox1 = new PictureBox();
		HistoryBtn = new Button();
		AdmitDischargeBtn = new Button();
		RoomNo1Txt = new TextBox();
		RoomType1Txt = new TextBox();
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)SearchResultGrid).BeginInit();
		((Control)PatientInfoBox).SuspendLayout();
		((Control)AdmitDetailsBox).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(392, 63));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(344, 35));
		((Control)Label1).set_TabIndex(3);
		Label1.set_Text("Admit And Discharge ");
		Label1.set_TextAlign((ContentAlignment)32);
		((Control)GroupBox1).get_Controls().Add((Control)(object)SearchBtn);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)MobileTxt);
		((Control)GroupBox1).get_Controls().Add((Control)(object)NameSTxt);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox1).set_Location(new Point(155, 150));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(623, 128));
		((Control)GroupBox1).set_TabIndex(5);
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
		((Control)MobileTxt).set_Location(new Point(120, 86));
		((Control)MobileTxt).set_Name("MobileTxt");
		((Control)MobileTxt).set_Size(new Size(237, 28));
		((Control)MobileTxt).set_TabIndex(2);
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
		((Control)SearchResultGrid).set_TabIndex(6);
		((Control)SearchResultGrid).set_Visible(false);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)MobileSTxt);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)Label15);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)NameTxt);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)Label14);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)AddressTxt);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)GenderTxt);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)AgeTxt);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)PIDTxt);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)Label7);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)Label6);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)Label5);
		((Control)PatientInfoBox).get_Controls().Add((Control)(object)Label4);
		((Control)PatientInfoBox).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)PatientInfoBox).set_Location(new Point(59, 485));
		((Control)PatientInfoBox).set_Name("PatientInfoBox");
		((Control)PatientInfoBox).set_Size(new Size(439, 298));
		((Control)PatientInfoBox).set_TabIndex(7);
		PatientInfoBox.set_TabStop(false);
		PatientInfoBox.set_Text("Patient Information");
		((Control)PatientInfoBox).set_Visible(false);
		((Control)MobileSTxt).set_Location(new Point(96, 116));
		((Control)MobileSTxt).set_Name("MobileSTxt");
		((TextBoxBase)MobileSTxt).set_ReadOnly(true);
		((Control)MobileSTxt).set_Size(new Size(253, 28));
		((Control)MobileSTxt).set_TabIndex(11);
		((Control)Label15).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label15).set_Location(new Point(13, 116));
		((Control)Label15).set_Name("Label15");
		((Control)Label15).set_Size(new Size(77, 26));
		((Control)Label15).set_TabIndex(10);
		Label15.set_Text("Mobile :");
		((Control)NameTxt).set_Location(new Point(96, 77));
		((Control)NameTxt).set_Name("NameTxt");
		((TextBoxBase)NameTxt).set_ReadOnly(true);
		((Control)NameTxt).set_Size(new Size(326, 28));
		((Control)NameTxt).set_TabIndex(9);
		((Control)Label14).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label14).set_Location(new Point(13, 80));
		((Control)Label14).set_Name("Label14");
		((Control)Label14).set_Size(new Size(77, 25));
		((Control)Label14).set_TabIndex(8);
		Label14.set_Text("Name :");
		((Control)AddressTxt).set_Location(new Point(124, 198));
		AddressTxt.set_Multiline(true);
		((Control)AddressTxt).set_Name("AddressTxt");
		((TextBoxBase)AddressTxt).set_ReadOnly(true);
		((Control)AddressTxt).set_Size(new Size(298, 90));
		((Control)AddressTxt).set_TabIndex(7);
		((Control)GenderTxt).set_Location(new Point(322, 152));
		((Control)GenderTxt).set_Name("GenderTxt");
		((TextBoxBase)GenderTxt).set_ReadOnly(true);
		((Control)GenderTxt).set_Size(new Size(100, 28));
		((Control)GenderTxt).set_TabIndex(6);
		((Control)AgeTxt).set_Font(new Font("MS Reference Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)AgeTxt).set_Location(new Point(96, 154));
		((Control)AgeTxt).set_Name("AgeTxt");
		((TextBoxBase)AgeTxt).set_ReadOnly(true);
		((Control)AgeTxt).set_Size(new Size(128, 23));
		((Control)AgeTxt).set_TabIndex(5);
		((Control)PIDTxt).set_Location(new Point(96, 43));
		((Control)PIDTxt).set_Name("PIDTxt");
		((TextBoxBase)PIDTxt).set_ReadOnly(true);
		((Control)PIDTxt).set_Size(new Size(128, 28));
		((Control)PIDTxt).set_TabIndex(4);
		((Control)Label7).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_Location(new Point(13, 198));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(105, 26));
		((Control)Label7).set_TabIndex(3);
		Label7.set_Text("Address : ");
		((Control)Label6).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_Location(new Point(232, 154));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(84, 26));
		((Control)Label6).set_TabIndex(2);
		Label6.set_Text("Gender : ");
		((Control)Label5).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_Location(new Point(13, 154));
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
		((Control)AdmitDetailsBox).get_Controls().Add((Control)(object)RoomNo1Txt);
		((Control)AdmitDetailsBox).get_Controls().Add((Control)(object)RoomType1Txt);
		((Control)AdmitDetailsBox).get_Controls().Add((Control)(object)RoomNoTxt);
		((Control)AdmitDetailsBox).get_Controls().Add((Control)(object)RoomTypeTxt);
		((Control)AdmitDetailsBox).get_Controls().Add((Control)(object)DateOutTxt);
		((Control)AdmitDetailsBox).get_Controls().Add((Control)(object)DateInTxt);
		((Control)AdmitDetailsBox).get_Controls().Add((Control)(object)StatusTxt);
		((Control)AdmitDetailsBox).get_Controls().Add((Control)(object)DateOut1Txt);
		((Control)AdmitDetailsBox).get_Controls().Add((Control)(object)DateIn1Txt);
		((Control)AdmitDetailsBox).get_Controls().Add((Control)(object)Label13);
		((Control)AdmitDetailsBox).get_Controls().Add((Control)(object)Label12);
		((Control)AdmitDetailsBox).get_Controls().Add((Control)(object)Label11);
		((Control)AdmitDetailsBox).get_Controls().Add((Control)(object)FeesTxt);
		((Control)AdmitDetailsBox).get_Controls().Add((Control)(object)Label10);
		((Control)AdmitDetailsBox).get_Controls().Add((Control)(object)Label9);
		((Control)AdmitDetailsBox).get_Controls().Add((Control)(object)Label8);
		((Control)AdmitDetailsBox).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)AdmitDetailsBox).set_Location(new Point(504, 485));
		((Control)AdmitDetailsBox).set_Name("AdmitDetailsBox");
		((Control)AdmitDetailsBox).set_Size(new Size(408, 255));
		((Control)AdmitDetailsBox).set_TabIndex(8);
		AdmitDetailsBox.set_TabStop(false);
		AdmitDetailsBox.set_Text("Admit Details");
		((Control)AdmitDetailsBox).set_Visible(false);
		RoomNoTxt.set_DropDownStyle((ComboBoxStyle)2);
		((Control)RoomNoTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)RoomNoTxt).set_FormattingEnabled(true);
		((Control)RoomNoTxt).set_Location(new Point(161, 32));
		((Control)RoomNoTxt).set_Name("RoomNoTxt");
		((Control)RoomNoTxt).set_Size(new Size(141, 27));
		((Control)RoomNoTxt).set_TabIndex(19);
		RoomTypeTxt.set_DropDownStyle((ComboBoxStyle)2);
		((Control)RoomTypeTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)RoomTypeTxt).set_FormattingEnabled(true);
		RoomTypeTxt.get_Items().AddRange(new object[3] { "General", "V.I.P.", "ICU" });
		((Control)RoomTypeTxt).set_Location(new Point(161, 71));
		((Control)RoomTypeTxt).set_Name("RoomTypeTxt");
		((Control)RoomTypeTxt).set_Size(new Size(181, 27));
		((Control)RoomTypeTxt).set_TabIndex(18);
		DateOutTxt.set_DropDownStyle((ComboBoxStyle)2);
		((Control)DateOutTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)DateOutTxt).set_FormattingEnabled(true);
		((Control)DateOutTxt).set_Location(new Point(161, 157));
		((Control)DateOutTxt).set_Name("DateOutTxt");
		((Control)DateOutTxt).set_Size(new Size(181, 27));
		((Control)DateOutTxt).set_TabIndex(17);
		DateInTxt.set_DropDownStyle((ComboBoxStyle)2);
		((Control)DateInTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)DateInTxt).set_FormattingEnabled(true);
		((Control)DateInTxt).set_Location(new Point(161, 111));
		((Control)DateInTxt).set_Name("DateInTxt");
		((Control)DateInTxt).set_Size(new Size(181, 27));
		((Control)DateInTxt).set_TabIndex(16);
		StatusTxt.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)StatusTxt).set_FormattingEnabled(true);
		StatusTxt.get_Items().AddRange(new object[2] { "Paid", "Not Paid" });
		((Control)StatusTxt).set_Location(new Point(266, 198));
		((Control)StatusTxt).set_Name("StatusTxt");
		((Control)StatusTxt).set_Size(new Size(136, 30));
		((Control)StatusTxt).set_TabIndex(15);
		((Control)DateOut1Txt).set_Location(new Point(161, 157));
		((Control)DateOut1Txt).set_Name("DateOut1Txt");
		((TextBoxBase)DateOut1Txt).set_ReadOnly(true);
		((Control)DateOut1Txt).set_Size(new Size(181, 28));
		((Control)DateOut1Txt).set_TabIndex(14);
		((Control)DateIn1Txt).set_Location(new Point(161, 110));
		((Control)DateIn1Txt).set_Name("DateIn1Txt");
		((TextBoxBase)DateIn1Txt).set_ReadOnly(true);
		((Control)DateIn1Txt).set_Size(new Size(181, 28));
		((Control)DateIn1Txt).set_TabIndex(13);
		((Control)Label13).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label13).set_Location(new Point(18, 157));
		((Control)Label13).set_Name("Label13");
		((Control)Label13).set_Size(new Size(109, 25));
		((Control)Label13).set_TabIndex(12);
		Label13.set_Text("Date Out  :");
		Label13.set_TextAlign((ContentAlignment)32);
		((Control)Label12).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label12).set_Location(new Point(18, 111));
		((Control)Label12).set_Name("Label12");
		((Control)Label12).set_Size(new Size(101, 28));
		((Control)Label12).set_TabIndex(11);
		Label12.set_Text("Date In  :");
		Label12.set_TextAlign((ContentAlignment)32);
		((Control)Label11).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label11).set_Location(new Point(184, 201));
		((Control)Label11).set_Name("Label11");
		((Control)Label11).set_Size(new Size(76, 28));
		((Control)Label11).set_TabIndex(10);
		Label11.set_Text("Status:");
		Label11.set_TextAlign((ContentAlignment)32);
		((Control)FeesTxt).set_Location(new Point(92, 201));
		((Control)FeesTxt).set_Name("FeesTxt");
		((Control)FeesTxt).set_Size(new Size(86, 28));
		((Control)FeesTxt).set_TabIndex(9);
		((Control)Label10).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label10).set_Location(new Point(18, 201));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(79, 25));
		((Control)Label10).set_TabIndex(3);
		Label10.set_Text("Fees  :");
		Label10.set_TextAlign((ContentAlignment)32);
		((Control)Label9).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_Location(new Point(18, 71));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(122, 28));
		((Control)Label9).set_TabIndex(2);
		Label9.set_Text("Room Type :");
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
		((Control)ClearBtn).set_Location(new Point(504, 746));
		((Control)ClearBtn).set_Name("ClearBtn");
		((Control)ClearBtn).set_Size(new Size(97, 37));
		((Control)ClearBtn).set_TabIndex(9);
		((ButtonBase)ClearBtn).set_Text("Clear");
		((ButtonBase)ClearBtn).set_UseVisualStyleBackColor(false);
		((Control)ClearBtn).set_Visible(false);
		((ButtonBase)PrintBtn).set_BackColor(Color.MidnightBlue);
		((Control)PrintBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)PrintBtn).set_ForeColor(Color.White);
		((Control)PrintBtn).set_Location(new Point(655, 746));
		((Control)PrintBtn).set_Name("PrintBtn");
		((Control)PrintBtn).set_Size(new Size(101, 37));
		((Control)PrintBtn).set_TabIndex(10);
		((ButtonBase)PrintBtn).set_Text("Print");
		((ButtonBase)PrintBtn).set_UseVisualStyleBackColor(false);
		((Control)PrintBtn).set_Visible(false);
		((ButtonBase)SaveBtn).set_BackColor(Color.MidnightBlue);
		((Control)SaveBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)SaveBtn).set_ForeColor(Color.White);
		((Control)SaveBtn).set_Location(new Point(814, 746));
		((Control)SaveBtn).set_Name("SaveBtn");
		((Control)SaveBtn).set_Size(new Size(98, 37));
		((Control)SaveBtn).set_TabIndex(11);
		((ButtonBase)SaveBtn).set_Text("Save");
		((ButtonBase)SaveBtn).set_UseVisualStyleBackColor(false);
		((Control)SaveBtn).set_Visible(false);
		PrintDialog1.set_UseEXDialog(true);
		PictureBox1.set_Image((Image)(object)Resources.medical_bed_icon);
		((Control)PictureBox1).set_Location(new Point(260, 22));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(126, 122));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(2);
		PictureBox1.set_TabStop(false);
		((ButtonBase)HistoryBtn).set_BackColor(Color.MidnightBlue);
		((Control)HistoryBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)HistoryBtn).set_ForeColor(Color.White);
		((Control)HistoryBtn).set_Location(new Point(784, 163));
		((Control)HistoryBtn).set_Name("HistoryBtn");
		((Control)HistoryBtn).set_Size(new Size(181, 41));
		((Control)HistoryBtn).set_TabIndex(18);
		((ButtonBase)HistoryBtn).set_Text("History");
		((ButtonBase)HistoryBtn).set_UseVisualStyleBackColor(false);
		((Control)HistoryBtn).set_Visible(false);
		((ButtonBase)AdmitDischargeBtn).set_BackColor(Color.MidnightBlue);
		((Control)AdmitDischargeBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)AdmitDischargeBtn).set_ForeColor(Color.White);
		((Control)AdmitDischargeBtn).set_Location(new Point(784, 220));
		((Control)AdmitDischargeBtn).set_Name("AdmitDischargeBtn");
		((Control)AdmitDischargeBtn).set_Size(new Size(181, 45));
		((Control)AdmitDischargeBtn).set_TabIndex(19);
		((ButtonBase)AdmitDischargeBtn).set_Text("Admit/Discharge");
		((ButtonBase)AdmitDischargeBtn).set_UseVisualStyleBackColor(false);
		((Control)AdmitDischargeBtn).set_Visible(false);
		((Control)RoomNo1Txt).set_Location(new Point(161, 32));
		((Control)RoomNo1Txt).set_Name("RoomNo1Txt");
		((TextBoxBase)RoomNo1Txt).set_ReadOnly(true);
		((Control)RoomNo1Txt).set_Size(new Size(141, 28));
		((Control)RoomNo1Txt).set_TabIndex(20);
		((Control)RoomNo1Txt).set_Visible(false);
		((Control)RoomType1Txt).set_Location(new Point(161, 73));
		((Control)RoomType1Txt).set_Name("RoomType1Txt");
		((TextBoxBase)RoomType1Txt).set_ReadOnly(true);
		((Control)RoomType1Txt).set_Size(new Size(181, 28));
		((Control)RoomType1Txt).set_TabIndex(21);
		((Control)RoomType1Txt).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Control)this).get_Controls().Add((Control)(object)AdmitDischargeBtn);
		((Control)this).get_Controls().Add((Control)(object)HistoryBtn);
		((Control)this).get_Controls().Add((Control)(object)SaveBtn);
		((Control)this).get_Controls().Add((Control)(object)PrintBtn);
		((Control)this).get_Controls().Add((Control)(object)ClearBtn);
		((Control)this).get_Controls().Add((Control)(object)AdmitDetailsBox);
		((Control)this).get_Controls().Add((Control)(object)PatientInfoBox);
		((Control)this).get_Controls().Add((Control)(object)SearchResultGrid);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).set_Name("Admit");
		((Control)this).set_Size(new Size(977, 804));
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((ISupportInitialize)SearchResultGrid).EndInit();
		((Control)PatientInfoBox).ResumeLayout(false);
		((Control)PatientInfoBox).PerformLayout();
		((Control)AdmitDetailsBox).ResumeLayout(false);
		((Control)AdmitDetailsBox).PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Admit_Load(object sender, EventArgs e)
	{
		myconnection.set_ConnectionString(MyProject.Forms.Form1.provider + MyProject.Forms.Form1.datafile);
		HideItemsOnForm();
		DateInTxt.get_Items().Add((object)Strings.Format((object)DateAndTime.get_Today(), "dd-MM-yyyy"));
		DateOutTxt.get_Items().Add((object)DateAndTime.get_Today());
		RoomNoTxt.get_Items().Clear();
		Add_Rooms();
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
			MessageBox.Show("No Results Found");
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
			}
			else
			{
				((Control)SearchResultGrid).set_Visible(true);
				myconnection.Close();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			myconnection.Close();
			ProjectData.ClearProjectError();
		}
	}

	private void SaveBtn_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Validate_Print_Data())
		{
			new OleDbCommand();
			performQueryStatement();
		}
	}

	private bool HideItemsOnForm()
	{
		((Control)SearchResultGrid).set_Visible(false);
		((Control)AdmitDetailsBox).set_Visible(false);
		((Control)PatientInfoBox).set_Visible(false);
		((Control)ClearBtn).set_Visible(false);
		((Control)PrintBtn).set_Visible(false);
		((Control)SaveBtn).set_Visible(false);
		((Control)HistoryBtn).set_Visible(false);
		((Control)AdmitDischargeBtn).set_Visible(false);
		return true;
	}

	private string performQueryStatement()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		OleDbCommand val = new OleDbCommand();
		DateTime dateTime = Conversions.ToDate(Strings.Format((object)DateTime.Now, "dd-MM-yyyy"));
		string text;
		if (Operators.CompareString(DateIn1Txt.get_Text(), "", false) == 0)
		{
			text = "Insert Into [Admit-Discharge] ([DateIn],[PID],[Fee Status],[Room No],[Room type]) Values (?,?,?,?,?);";
			myconnection.Open();
			try
			{
				val = new OleDbCommand(text, myconnection);
				val.get_Parameters().Add(new OleDbParameter("DateIn", (object)Conversions.ToString(dateTime)));
				val.get_Parameters().Add(new OleDbParameter("PID", (object)Conversions.ToInteger(PIDTxt.get_Text())));
				val.get_Parameters().Add(new OleDbParameter("Fee Status", (object)StatusTxt.get_Text()));
				val.get_Parameters().Add(new OleDbParameter("Room No", (object)Conversions.ToInteger(RoomNoTxt.get_Text())));
				val.get_Parameters().Add(new OleDbParameter("Room Type", (object)RoomTypeTxt.get_Text().ToString()));
				val.ExecuteNonQuery();
				((Component)(object)val).Dispose();
				myconnection.Close();
				MessageBox.Show("Successfully Updated Details");
				Update_Rooms(RoomNoTxt.get_Text(), "No");
				UpdateTable();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				myconnection.Close();
				MessageBox.Show("Cannot proceed with the request!", "INVALID REQUEST");
				ProjectData.ClearProjectError();
			}
		}
		else if ((Operators.CompareString(DateIn1Txt.get_Text(), "", false) != 0) & (Operators.CompareString(DateOut1Txt.get_Text(), "", false) == 0))
		{
			dateTime = Conversions.ToDate(Strings.Format((object)DateTime.Today, "MM-dd-yyyy"));
			text = "Update [Admit-Discharge] Set [DateOut] = #" + Conversions.ToString(dateTime) + "#, [Fee Status] = '" + StatusTxt.get_Text() + "' Where [ID] = " + id + " ;";
			myconnection.Open();
			try
			{
				val = new OleDbCommand(text, myconnection);
				val.ExecuteNonQuery();
				((Component)(object)val).Dispose();
				myconnection.Close();
				MessageBox.Show("Successfully Updated Details");
				Update_Rooms(RoomNo1Txt.get_Text(), "Yes");
				UpdateTable();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				myconnection.Close();
				MessageBox.Show("Cannot proceed with the request!", "INVALID REQUEST");
				ProjectData.ClearProjectError();
			}
		}
		else
		{
			text = "Update [Admit-Discharge] Set [Room No] = " + RoomNoTxt.get_Text() + ", [Room Type] = '" + RoomTypeTxt.get_Text() + "', [Fee Status] = '" + StatusTxt.get_Text() + "' Where [PID] = " + PIDTxt.get_Text() + ";";
			myconnection.Open();
			try
			{
				val = new OleDbCommand(text, myconnection);
				val.ExecuteNonQuery();
				((Component)(object)val).Dispose();
				myconnection.Close();
				MessageBox.Show("Successfully Updated Details");
				UpdateTable();
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				myconnection.Close();
				MessageBox.Show("Cannot proceed with the request!", "INVALID REQUEST");
				ProjectData.ClearProjectError();
			}
		}
		return text;
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
			AgeTxt.set_Text(Conversions.ToString(SearchResultGrid.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(2)
				.get_Value()));
			GenderTxt.set_Text(Conversions.ToString(SearchResultGrid.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(3)
				.get_Value()));
			MobileSTxt.set_Text(Conversions.ToString(SearchResultGrid.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(4)
				.get_Value()));
			AddressTxt.set_Text(Conversions.ToString(SearchResultGrid.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(5)
				.get_Value()));
			((Control)HistoryBtn).set_Visible(true);
			((Control)AdmitDischargeBtn).set_Visible(true);
			((Control)AdmitDetailsBox).set_Visible(false);
			((Control)PatientInfoBox).set_Visible(true);
			((Control)ClearBtn).set_Visible(false);
			((Control)PrintBtn).set_Visible(false);
			((Control)SaveBtn).set_Visible(false);
			RoomNoTxt.set_SelectedIndex(-1);
			RoomTypeTxt.set_SelectedIndex(-1);
			((TextBoxBase)FeesTxt).Clear();
			((TextBoxBase)DateIn1Txt).Clear();
			((TextBoxBase)DateOut1Txt).Clear();
			StatusTxt.set_SelectedIndex(-1);
			DateInTxt.set_SelectedIndex(-1);
			DateOutTxt.set_SelectedIndex(-1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private bool UpdateTable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
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
		return true;
	}

	private void ClearBtn_Click(object sender, EventArgs e)
	{
		ClearPatientInfo();
		ClearAdmitDetails();
		RoomNoTxt.get_Items().Clear();
		Add_Rooms();
	}

	private bool ClearPatientInfo()
	{
		((TextBoxBase)PIDTxt).Clear();
		((TextBoxBase)NameTxt).Clear();
		((TextBoxBase)MobileSTxt).Clear();
		((TextBoxBase)AgeTxt).Clear();
		((TextBoxBase)AddressTxt).Clear();
		((TextBoxBase)GenderTxt).Clear();
		return true;
	}

	private bool ClearAdmitDetails()
	{
		RoomNoTxt.set_SelectedIndex(-1);
		RoomTypeTxt.set_SelectedIndex(-1);
		((TextBoxBase)RoomNo1Txt).Clear();
		((TextBoxBase)RoomType1Txt).Clear();
		((TextBoxBase)DateIn1Txt).Clear();
		((TextBoxBase)DateOut1Txt).Clear();
		DateInTxt.set_SelectedIndex(-1);
		DateOutTxt.set_SelectedIndex(-1);
		StatusTxt.set_SelectedIndex(-1);
		((TextBoxBase)FeesTxt).Clear();
		return true;
	}

	private void PrintBtn_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		if (Operators.CompareString(PIDTxt.get_Text(), "", false) == 0)
		{
			MessageBox.Show("No Patient to Print");
		}
		else if (Validate_Print_Data())
		{
			PrintDialog1.set_Document(PrintDocument1);
			PrintDialog1.set_PrinterSettings(PrintDocument1.get_PrinterSettings());
			PrintDialog1.set_AllowSomePages(true);
			if ((int)((CommonDialog)PrintDialog1).ShowDialog() == 1)
			{
				PrintDocument1.set_PrinterSettings(PrintDialog1.get_PrinterSettings());
				PrintDocument1.Print();
			}
		}
	}

	private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		string text = ((!((Control)RoomNo1Txt).get_Visible()) ? RoomNoTxt.get_Text() : RoomNo1Txt.get_Text());
		string text2 = ((!((Control)RoomType1Txt).get_Visible()) ? RoomTypeTxt.get_Text() : RoomType1Txt.get_Text());
		Font val = new Font("Times New Roman", 20f);
		Font val2 = new Font("Times New Roman", 12f);
		e.get_Graphics().DrawString("Admit/Discharge", val, Brushes.get_Chocolate(), 250f, 100f);
		e.get_Graphics().DrawString(("Name - " + NameTxt.get_Text()) ?? "", val2, Brushes.get_Chocolate(), 100f, 150f);
		e.get_Graphics().DrawString(("Mobile - " + MobileTxt.get_Text()) ?? "", val2, Brushes.get_Chocolate(), 100f, 200f);
		e.get_Graphics().DrawString(("Room No - " + text) ?? "", val2, Brushes.get_Chocolate(), 100f, 250f);
		e.get_Graphics().DrawString(("Room Type - " + text2) ?? "", val2, Brushes.get_Chocolate(), 100f, 300f);
		e.get_Graphics().DrawString(("Fees - " + FeesTxt.get_Text()) ?? "", val2, Brushes.get_Chocolate(), 100f, 350f);
	}

	private void HistoryBtn_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(PIDTxt.get_Text(), "", false) == 0)
		{
			MessageBox.Show("No Patient Selected");
			return;
		}
		MyProject.Forms.Form2.PID_Value = PIDTxt.get_Text();
		((Control)MyProject.Forms.Form5).Show();
	}

	private void AdmitDischargeBtn_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(PIDTxt.get_Text(), "", false) == 0)
		{
			MessageBox.Show("No Patient Selected");
			return;
		}
		OleDbCommand val = new OleDbCommand();
		string text = "Select * From [Admit-Discharge] Where [PID] = " + PIDTxt.get_Text() + ";";
		myconnection.Open();
		try
		{
			val = new OleDbCommand(text, myconnection);
			OleDbDataReader val2 = val.ExecuteReader();
			int num = 0;
			while (val2.Read())
			{
				if ((Operators.CompareString(val2.get_Item(2).ToString(), "", false) != 0) & (Operators.CompareString(val2.get_Item(3).ToString(), "", false) == 0))
				{
					num = 1;
					((Control)DateOut1Txt).set_Visible(false);
					((Control)DateOutTxt).set_Visible(true);
					id = val2.get_Item(0).ToString();
					DateIn1Txt.set_Text(Conversions.ToString(val2.get_Item(2)));
					RoomNo1Txt.set_Text(val2.get_Item(4).ToString());
					((Control)RoomNoTxt).set_Visible(false);
					((Control)RoomNo1Txt).set_Visible(true);
					RoomType1Txt.set_Text(val2.get_Item(5).ToString());
					((Control)RoomTypeTxt).set_Visible(false);
					((Control)RoomType1Txt).set_Visible(true);
					StatusTxt.set_Text(val2.get_Item(6).ToString());
					((Control)DateIn1Txt).set_Visible(true);
					((Control)DateInTxt).set_Visible(false);
					break;
				}
			}
			myconnection.Close();
			((Control)AdmitDischargeBtn).set_Visible(false);
			((Control)AdmitDetailsBox).set_Visible(true);
			((Control)ClearBtn).set_Visible(true);
			((Control)PrintBtn).set_Visible(true);
			((Control)SaveBtn).set_Visible(true);
			if (num == 0)
			{
				((Control)DateOut1Txt).set_Visible(true);
				((Control)DateOutTxt).set_Visible(false);
				((Control)DateIn1Txt).set_Visible(false);
				((Control)DateInTxt).set_Visible(true);
				((Control)RoomNo1Txt).set_Visible(false);
				((Control)RoomType1Txt).set_Visible(false);
				((Control)RoomNoTxt).set_Visible(true);
				((Control)RoomTypeTxt).set_Visible(true);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			myconnection.Close();
			((Control)AdmitDetailsBox).set_Visible(true);
			((Control)DateOut1Txt).set_Visible(true);
			((Control)DateOutTxt).set_Visible(false);
			((Control)DateIn1Txt).set_Visible(false);
			((Control)DateInTxt).set_Visible(true);
			((Control)RoomNo1Txt).set_Visible(false);
			((Control)RoomType1Txt).set_Visible(false);
			((Control)RoomNoTxt).set_Visible(true);
			((Control)RoomTypeTxt).set_Visible(true);
			MessageBox.Show(ex2.Message);
			MessageBox.Show(text);
			ProjectData.ClearProjectError();
		}
	}

	private bool Add_Rooms()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		OleDbCommand val = new OleDbCommand();
		string text = "Select * From [Room] Where [Availability] = 'Yes';";
		myconnection.Open();
		try
		{
			val = new OleDbCommand(text, myconnection);
			OleDbDataReader val2 = val.ExecuteReader();
			if (val2.get_HasRows())
			{
				while (val2.Read())
				{
					RoomNoTxt.get_Items().Add((object)val2.get_Item(0).ToString());
				}
			}
			myconnection.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			myconnection.Close();
			ProjectData.ClearProjectError();
		}
		return true;
	}

	private bool Update_Rooms(string roomNo, string status)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		OleDbCommand val = new OleDbCommand();
		string text = "Update [Room] Set [Availability] = '" + status + "' Where [Room No] = " + roomNo + ";";
		myconnection.Open();
		try
		{
			val = new OleDbCommand(text, myconnection);
			val.ExecuteNonQuery();
			((Component)(object)val).Dispose();
			myconnection.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			myconnection.Close();
			ProjectData.ClearProjectError();
		}
		return true;
	}

	private bool Validate_Print_Data()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		if ((RoomNoTxt.get_SelectedIndex() == -1) & (Operators.CompareString(RoomNo1Txt.get_Text(), "", false) == 0))
		{
			MessageBox.Show("Missing Room No");
			return false;
		}
		if ((RoomTypeTxt.get_SelectedIndex() == -1) & (Operators.CompareString(RoomType1Txt.get_Text(), "", false) == 0))
		{
			MessageBox.Show("Missing Room type");
			return false;
		}
		if (!((Control)DateIn1Txt).get_Visible())
		{
			if (DateInTxt.get_SelectedIndex() == -1)
			{
				MessageBox.Show("Missing Date In");
				return false;
			}
			if ((Operators.CompareString(StatusTxt.get_Text(), "Paid", false) == 0) & !MyProject.Forms.Form1.Number_Validator(FeesTxt.get_Text()))
			{
				MessageBox.Show("Missing fees");
				return false;
			}
			if ((Operators.CompareString(StatusTxt.get_Text(), "Not Paid", false) == 0) & (Operators.CompareString(FeesTxt.get_Text(), "", false) != 0))
			{
				MessageBox.Show("Cannot Display Fees when Not Paid");
				return false;
			}
		}
		if (!((Control)DateOut1Txt).get_Visible())
		{
			if (DateOutTxt.get_SelectedIndex() == -1)
			{
				MessageBox.Show("Missing Date out");
				return false;
			}
			if (!MyProject.Forms.Form1.Number_Validator(FeesTxt.get_Text()))
			{
				MessageBox.Show("Incorrect fees Value");
				return false;
			}
			if ((Operators.CompareString(StatusTxt.get_Text(), "", false) == 0) | (Operators.CompareString(StatusTxt.get_Text(), "Not Paid", false) == 0))
			{
				MessageBox.Show("Cannot discharge Without Paying fees");
				return false;
			}
		}
		return true;
	}
}
