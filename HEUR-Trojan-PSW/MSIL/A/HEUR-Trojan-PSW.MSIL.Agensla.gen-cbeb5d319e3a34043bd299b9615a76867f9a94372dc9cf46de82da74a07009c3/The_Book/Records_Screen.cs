using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace The_Book;

[DesignerGenerated]
public class Records_Screen : Form
{
	private IContainer components;

	private static bool bolDelete;

	internal virtual ListBox lstRecords
	{
		[CompilerGenerated]
		get
		{
			return _lstRecords;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = lstRecords_SelectedIndexChanged;
			ListBox val = _lstRecords;
			if (val != null)
			{
				val.remove_SelectedIndexChanged(eventHandler);
			}
			_lstRecords = value;
			val = _lstRecords;
			if (val != null)
			{
				val.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
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

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblName")]
	internal virtual Label lblName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblBirthday")]
	internal virtual Label lblBirthday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFlagDate")]
	internal virtual Label lblFlagDate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAge")]
	internal virtual Label lblAge
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCurrentClassroom")]
	internal virtual Label lblCurrentClassroom
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNextClassroom")]
	internal virtual Label lblNextClassroom
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

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
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

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMondayTime")]
	internal virtual Label lblMondayTime
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTuesdayTime")]
	internal virtual Label lblTuesdayTime
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblWednesdayTime")]
	internal virtual Label lblWednesdayTime
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblThursdayTime")]
	internal virtual Label lblThursdayTime
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFridayTime")]
	internal virtual Label lblFridayTime
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PictureBox clpAdd
	{
		[CompilerGenerated]
		get
		{
			return _clpAdd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = clpAdd_Click;
			PictureBox val = _clpAdd;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_clpAdd = value;
			val = _clpAdd;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox clpEdit
	{
		[CompilerGenerated]
		get
		{
			return _clpEdit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = clpEdit_Click;
			PictureBox val = _clpEdit;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_clpEdit = value;
			val = _clpEdit;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox clpDelete
	{
		[CompilerGenerated]
		get
		{
			return _clpDelete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = clpDelete_Click;
			PictureBox val = _clpDelete;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_clpDelete = value;
			val = _clpDelete;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
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

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
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

	[field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Records_Screen()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		((Form)this).add_Activated((EventHandler)Records_Screen_Activated);
		((Control)this).add_Paint(new PaintEventHandler(Form_Paint));
		((Form)this).add_Load((EventHandler)Records_Screen_Load);
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
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected O, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected O, but got Unknown
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected O, but got Unknown
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected O, but got Unknown
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Expected O, but got Unknown
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Expected O, but got Unknown
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d7: Expected O, but got Unknown
		//IL_075c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Expected O, but got Unknown
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f2: Expected O, but got Unknown
		//IL_0877: Unknown result type (might be due to invalid IL or missing references)
		//IL_0881: Expected O, but got Unknown
		//IL_08fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0904: Expected O, but got Unknown
		//IL_098b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0995: Expected O, but got Unknown
		//IL_0a13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1d: Expected O, but got Unknown
		//IL_0aa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab1: Expected O, but got Unknown
		//IL_0b3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b45: Expected O, but got Unknown
		//IL_0bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be5: Expected O, but got Unknown
		//IL_0c67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c71: Expected O, but got Unknown
		//IL_0cf6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d00: Expected O, but got Unknown
		//IL_0d85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8f: Expected O, but got Unknown
		//IL_0e14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1e: Expected O, but got Unknown
		//IL_0e79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e83: Expected O, but got Unknown
		//IL_0ef4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efe: Expected O, but got Unknown
		//IL_0f72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7c: Expected O, but got Unknown
		//IL_1002: Unknown result type (might be due to invalid IL or missing references)
		//IL_100c: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Records_Screen));
		lstRecords = new ListBox();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		Label6 = new Label();
		lblName = new Label();
		lblBirthday = new Label();
		lblFlagDate = new Label();
		lblAge = new Label();
		lblCurrentClassroom = new Label();
		lblNextClassroom = new Label();
		Label7 = new Label();
		Label8 = new Label();
		Label9 = new Label();
		Label10 = new Label();
		Label11 = new Label();
		lblMondayTime = new Label();
		lblTuesdayTime = new Label();
		lblWednesdayTime = new Label();
		lblThursdayTime = new Label();
		lblFridayTime = new Label();
		clpAdd = new PictureBox();
		clpEdit = new PictureBox();
		clpDelete = new PictureBox();
		lstUnique = new ListBox();
		btnMainMenu = new Button();
		Label12 = new Label();
		Label13 = new Label();
		Label14 = new Label();
		((ISupportInitialize)clpAdd).BeginInit();
		((ISupportInitialize)clpEdit).BeginInit();
		((ISupportInitialize)clpDelete).BeginInit();
		((Control)this).SuspendLayout();
		lstRecords.set_BackColor(Color.ForestGreen);
		lstRecords.set_Font(new Font("Century Gothic", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((ListControl)lstRecords).set_FormattingEnabled(true);
		lstRecords.set_ItemHeight(23);
		((Control)lstRecords).set_Location(new Point(597, 76));
		((Control)lstRecords).set_Name("lstRecords");
		((Control)lstRecords).set_Size(new Size(299, 395));
		((Control)lstRecords).set_TabIndex(0);
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.ForestGreen);
		((Control)Label1).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(49, 86));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(81, 25));
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("Name:");
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(Color.ForestGreen);
		((Control)Label2).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(49, 127));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(63, 25));
		((Control)Label2).set_TabIndex(2);
		Label2.set_Text("DOB:");
		Label3.set_AutoSize(true);
		((Control)Label3).set_BackColor(Color.ForestGreen);
		((Control)Label3).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_Location(new Point(49, 169));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(115, 25));
		((Control)Label3).set_TabIndex(3);
		Label3.set_Text("Flag Date:");
		Label4.set_AutoSize(true);
		((Control)Label4).set_BackColor(Color.ForestGreen);
		((Control)Label4).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_Location(new Point(49, 211));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(61, 25));
		((Control)Label4).set_TabIndex(4);
		Label4.set_Text("Age:");
		Label5.set_AutoSize(true);
		((Control)Label5).set_BackColor(Color.ForestGreen);
		((Control)Label5).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_Location(new Point(49, 252));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(205, 25));
		((Control)Label5).set_TabIndex(5);
		Label5.set_Text("Current Classroom:");
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.ForestGreen);
		((Control)Label6).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_Location(new Point(49, 293));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(177, 25));
		((Control)Label6).set_TabIndex(6);
		Label6.set_Text("Next Classroom:");
		lblName.set_AutoSize(true);
		((Control)lblName).set_BackColor(Color.Green);
		lblName.set_BorderStyle((BorderStyle)1);
		((Control)lblName).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblName).set_Location(new Point(136, 85));
		((Control)lblName).set_Name("lblName");
		((Control)lblName).set_Size(new Size(2, 27));
		((Control)lblName).set_TabIndex(7);
		lblBirthday.set_AutoSize(true);
		((Control)lblBirthday).set_BackColor(Color.Green);
		lblBirthday.set_BorderStyle((BorderStyle)1);
		((Control)lblBirthday).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblBirthday).set_Location(new Point(118, 126));
		((Control)lblBirthday).set_Name("lblBirthday");
		((Control)lblBirthday).set_Size(new Size(2, 27));
		((Control)lblBirthday).set_TabIndex(8);
		lblFlagDate.set_AutoSize(true);
		((Control)lblFlagDate).set_BackColor(Color.Green);
		lblFlagDate.set_BorderStyle((BorderStyle)1);
		((Control)lblFlagDate).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblFlagDate).set_Location(new Point(170, 168));
		((Control)lblFlagDate).set_Name("lblFlagDate");
		((Control)lblFlagDate).set_Size(new Size(2, 27));
		((Control)lblFlagDate).set_TabIndex(9);
		lblAge.set_AutoSize(true);
		((Control)lblAge).set_BackColor(Color.Green);
		lblAge.set_BorderStyle((BorderStyle)1);
		((Control)lblAge).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblAge).set_Location(new Point(116, 210));
		((Control)lblAge).set_Name("lblAge");
		((Control)lblAge).set_Size(new Size(2, 27));
		((Control)lblAge).set_TabIndex(10);
		lblCurrentClassroom.set_AutoSize(true);
		((Control)lblCurrentClassroom).set_BackColor(Color.Green);
		lblCurrentClassroom.set_BorderStyle((BorderStyle)1);
		((Control)lblCurrentClassroom).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblCurrentClassroom).set_Location(new Point(260, 251));
		((Control)lblCurrentClassroom).set_Name("lblCurrentClassroom");
		((Control)lblCurrentClassroom).set_Size(new Size(2, 27));
		((Control)lblCurrentClassroom).set_TabIndex(11);
		lblNextClassroom.set_AutoSize(true);
		((Control)lblNextClassroom).set_BackColor(Color.Green);
		lblNextClassroom.set_BorderStyle((BorderStyle)1);
		((Control)lblNextClassroom).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblNextClassroom).set_Location(new Point(232, 292));
		((Control)lblNextClassroom).set_Name("lblNextClassroom");
		((Control)lblNextClassroom).set_Size(new Size(2, 27));
		((Control)lblNextClassroom).set_TabIndex(12);
		Label7.set_AutoSize(true);
		((Control)Label7).set_BackColor(Color.ForestGreen);
		((Control)Label7).set_Font(new Font("Century Gothic", 12f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_Location(new Point(28, 380));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(74, 19));
		((Control)Label7).set_TabIndex(13);
		Label7.set_Text("Monday");
		Label8.set_AutoSize(true);
		((Control)Label8).set_BackColor(Color.ForestGreen);
		((Control)Label8).set_Font(new Font("Century Gothic", 12f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_Location(new Point(144, 380));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(73, 19));
		((Control)Label8).set_TabIndex(14);
		Label8.set_Text("Tuesday");
		((Control)Label9).set_BackColor(Color.ForestGreen);
		((Control)Label9).set_Font(new Font("Century Gothic", 9.75f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_Location(new Point(249, 380));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(86, 19));
		((Control)Label9).set_TabIndex(15);
		Label9.set_Text("Wednesday");
		Label10.set_AutoSize(true);
		((Control)Label10).set_BackColor(Color.ForestGreen);
		((Control)Label10).set_Font(new Font("Century Gothic", 12f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)Label10).set_Location(new Point(366, 380));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(78, 19));
		((Control)Label10).set_TabIndex(16);
		Label10.set_Text("Thursday");
		Label11.set_AutoSize(true);
		((Control)Label11).set_BackColor(Color.ForestGreen);
		((Control)Label11).set_Font(new Font("Century Gothic", 12f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)Label11).set_Location(new Point(488, 380));
		((Control)Label11).set_Name("Label11");
		((Control)Label11).set_Size(new Size(57, 19));
		((Control)Label11).set_TabIndex(17);
		Label11.set_Text("Friday");
		lblMondayTime.set_AutoSize(true);
		((Control)lblMondayTime).set_BackColor(Color.Green);
		lblMondayTime.set_BorderStyle((BorderStyle)1);
		((Control)lblMondayTime).set_Font(new Font("Century Gothic", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblMondayTime).set_Location(new Point(30, 420));
		((Control)lblMondayTime).set_Name("lblMondayTime");
		((Control)lblMondayTime).set_Size(new Size(2, 21));
		((Control)lblMondayTime).set_TabIndex(18);
		lblTuesdayTime.set_AutoSize(true);
		((Control)lblTuesdayTime).set_BackColor(Color.Green);
		lblTuesdayTime.set_BorderStyle((BorderStyle)1);
		((Control)lblTuesdayTime).set_Font(new Font("Century Gothic", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblTuesdayTime).set_Location(new Point(143, 420));
		((Control)lblTuesdayTime).set_Name("lblTuesdayTime");
		((Control)lblTuesdayTime).set_Size(new Size(2, 21));
		((Control)lblTuesdayTime).set_TabIndex(19);
		lblWednesdayTime.set_AutoSize(true);
		((Control)lblWednesdayTime).set_BackColor(Color.Green);
		lblWednesdayTime.set_BorderStyle((BorderStyle)1);
		((Control)lblWednesdayTime).set_Font(new Font("Century Gothic", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblWednesdayTime).set_Location(new Point(256, 420));
		((Control)lblWednesdayTime).set_Name("lblWednesdayTime");
		((Control)lblWednesdayTime).set_Size(new Size(2, 21));
		((Control)lblWednesdayTime).set_TabIndex(20);
		lblThursdayTime.set_AutoSize(true);
		((Control)lblThursdayTime).set_BackColor(Color.Green);
		lblThursdayTime.set_BorderStyle((BorderStyle)1);
		((Control)lblThursdayTime).set_Font(new Font("Century Gothic", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblThursdayTime).set_Location(new Point(370, 420));
		((Control)lblThursdayTime).set_Name("lblThursdayTime");
		((Control)lblThursdayTime).set_Size(new Size(2, 21));
		((Control)lblThursdayTime).set_TabIndex(21);
		lblFridayTime.set_AutoSize(true);
		((Control)lblFridayTime).set_BackColor(Color.Green);
		lblFridayTime.set_BorderStyle((BorderStyle)1);
		((Control)lblFridayTime).set_Font(new Font("Century Gothic", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblFridayTime).set_Location(new Point(481, 420));
		((Control)lblFridayTime).set_Name("lblFridayTime");
		((Control)lblFridayTime).set_Size(new Size(2, 21));
		((Control)lblFridayTime).set_TabIndex(22);
		clpAdd.set_Image((Image)componentResourceManager.GetObject("clpAdd.Image"));
		((Control)clpAdd).set_Location(new Point(103, 521));
		((Control)clpAdd).set_Name("clpAdd");
		((Control)clpAdd).set_Size(new Size(76, 76));
		clpAdd.set_SizeMode((PictureBoxSizeMode)2);
		clpAdd.set_TabIndex(23);
		clpAdd.set_TabStop(false);
		clpEdit.set_Image((Image)componentResourceManager.GetObject("clpEdit.Image"));
		((Control)clpEdit).set_Location(new Point(249, 521));
		((Control)clpEdit).set_Name("clpEdit");
		((Control)clpEdit).set_Size(new Size(76, 76));
		clpEdit.set_SizeMode((PictureBoxSizeMode)2);
		clpEdit.set_TabIndex(24);
		clpEdit.set_TabStop(false);
		clpDelete.set_Image((Image)componentResourceManager.GetObject("clpDelete.Image"));
		((Control)clpDelete).set_Location(new Point(395, 521));
		((Control)clpDelete).set_Name("clpDelete");
		((Control)clpDelete).set_Size(new Size(76, 76));
		clpDelete.set_SizeMode((PictureBoxSizeMode)2);
		clpDelete.set_TabIndex(25);
		clpDelete.set_TabStop(false);
		lstUnique.set_BackColor(Color.ForestGreen);
		lstUnique.set_Font(new Font("Century Gothic", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((ListControl)lstUnique).set_FormattingEnabled(true);
		lstUnique.set_ItemHeight(23);
		((Control)lstUnique).set_Location(new Point(597, 76));
		((Control)lstUnique).set_Name("lstUnique");
		((Control)lstUnique).set_Size(new Size(299, 395));
		((Control)lstUnique).set_TabIndex(26);
		((Control)lstUnique).set_Visible(false);
		((ButtonBase)btnMainMenu).set_BackColor(Color.Transparent);
		((Control)btnMainMenu).set_Location(new Point(831, 595));
		((Control)btnMainMenu).set_Name("btnMainMenu");
		((Control)btnMainMenu).set_Size(new Size(75, 43));
		((Control)btnMainMenu).set_TabIndex(27);
		((ButtonBase)btnMainMenu).set_Text("Return to Main Menu");
		((ButtonBase)btnMainMenu).set_UseVisualStyleBackColor(false);
		Label12.set_AutoSize(true);
		((Control)Label12).set_BackColor(Color.ForestGreen);
		((Control)Label12).set_Location(new Point(126, 600));
		((Control)Label12).set_Name("Label12");
		((Control)Label12).set_Size(new Size(26, 13));
		((Control)Label12).set_TabIndex(28);
		Label12.set_Text("Add");
		Label13.set_AutoSize(true);
		((Control)Label13).set_BackColor(Color.ForestGreen);
		((Control)Label13).set_Location(new Point(273, 600));
		((Control)Label13).set_Name("Label13");
		((Control)Label13).set_Size(new Size(25, 13));
		((Control)Label13).set_TabIndex(29);
		Label13.set_Text("Edit");
		Label14.set_AutoSize(true);
		((Control)Label14).set_BackColor(Color.ForestGreen);
		((Control)Label14).set_Location(new Point(416, 600));
		((Control)Label14).set_Name("Label14");
		((Control)Label14).set_Size(new Size(38, 13));
		((Control)Label14).set_TabIndex(30);
		Label14.set_Text("Delete");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(918, 650));
		((Control)this).get_Controls().Add((Control)(object)Label14);
		((Control)this).get_Controls().Add((Control)(object)Label13);
		((Control)this).get_Controls().Add((Control)(object)Label12);
		((Control)this).get_Controls().Add((Control)(object)btnMainMenu);
		((Control)this).get_Controls().Add((Control)(object)clpDelete);
		((Control)this).get_Controls().Add((Control)(object)clpEdit);
		((Control)this).get_Controls().Add((Control)(object)clpAdd);
		((Control)this).get_Controls().Add((Control)(object)lblFridayTime);
		((Control)this).get_Controls().Add((Control)(object)lblThursdayTime);
		((Control)this).get_Controls().Add((Control)(object)lblWednesdayTime);
		((Control)this).get_Controls().Add((Control)(object)lblTuesdayTime);
		((Control)this).get_Controls().Add((Control)(object)lblMondayTime);
		((Control)this).get_Controls().Add((Control)(object)Label11);
		((Control)this).get_Controls().Add((Control)(object)Label10);
		((Control)this).get_Controls().Add((Control)(object)Label9);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)lblNextClassroom);
		((Control)this).get_Controls().Add((Control)(object)lblCurrentClassroom);
		((Control)this).get_Controls().Add((Control)(object)lblAge);
		((Control)this).get_Controls().Add((Control)(object)lblFlagDate);
		((Control)this).get_Controls().Add((Control)(object)lblBirthday);
		((Control)this).get_Controls().Add((Control)(object)lblName);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)lstRecords);
		((Control)this).get_Controls().Add((Control)(object)lstUnique);
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Records_Screen");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Records");
		((ISupportInitialize)clpAdd).EndInit();
		((ISupportInitialize)clpEdit).EndInit();
		((ISupportInitialize)clpDelete).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void lstRecords_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (lstRecords.get_SelectedIndex() < 0)
		{
			return;
		}
		string text = Conversions.ToString(lstUnique.get_Items().get_Item(lstRecords.get_SelectedIndex()));
		string text2 = text.Substring(text.LastIndexOf(" "));
		text2 = text2.Substring(1, checked(text2.Length - 1));
		foreach (Child item in Child.lstChild)
		{
			if (Operators.CompareString(item.intUnique.ToString(), text2, false) == 0)
			{
				lblName.set_Text(item.strLastName + ", " + item.strFirstName);
				lblBirthday.set_Text(item.strBirthday);
				lblFlagDate.set_Text(item.strFlagDate);
				lblAge.set_Text(item.intAge + " Yrs., " + item.intMonths + " Mos.");
				lblCurrentClassroom.set_Text(item.strCurrentClassroom);
				lblNextClassroom.set_Text(item.strNextClassroom);
				lblMondayTime.set_Text(item.strMonday);
				lblTuesdayTime.set_Text(item.strTuesday);
				lblWednesdayTime.set_Text(item.strWednesday);
				lblThursdayTime.set_Text(item.strThursday);
				lblFridayTime.set_Text(item.strFriday);
				((Control)lblName).set_Visible(true);
				((Control)lblBirthday).set_Visible(true);
				((Control)lblFlagDate).set_Visible(true);
				((Control)lblAge).set_Visible(true);
				((Control)lblCurrentClassroom).set_Visible(true);
				((Control)lblNextClassroom).set_Visible(true);
				((Control)lblMondayTime).set_Visible(true);
				((Control)lblTuesdayTime).set_Visible(true);
				((Control)lblWednesdayTime).set_Visible(true);
				((Control)lblThursdayTime).set_Visible(true);
				((Control)lblFridayTime).set_Visible(true);
			}
		}
	}

	private void Records_Screen_Activated(object sender, EventArgs e)
	{
		if (!bolDelete)
		{
			FillListBox();
		}
		HideLabels();
	}

	private void FillListBox()
	{
		lstRecords.get_Items().Clear();
		lstUnique.get_Items().Clear();
		foreach (Child item in Child.lstChild)
		{
			if (Operators.CompareString(item.strLastName, "", false) != 0)
			{
				lstRecords.get_Items().Add((object)(item.strLastName + ", " + item.strFirstName));
				lstRecords.set_Sorted(true);
				lstUnique.get_Items().Add((object)(item.strLastName + ", " + item.strFirstName + ", " + item.intUnique));
				lstUnique.set_Sorted(true);
			}
		}
	}

	private void Form_Paint(object sender, PaintEventArgs e)
	{
	}

	private void clpAdd_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		Add_New_Screen add_New_Screen = new Add_New_Screen();
		((Form)add_New_Screen).ShowDialog();
	}

	private void clpEdit_Click(object sender, EventArgs e)
	{
		if (lstRecords.get_SelectedIndex() > -1)
		{
			string text = Conversions.ToString(lstUnique.get_Items().get_Item(lstRecords.get_SelectedIndex()));
			string text2 = text.Substring(text.LastIndexOf(" "));
			text2 = text2.Substring(1, checked(text2.Length - 1));
			Edit edit = new Edit();
			edit.lblUnique.set_Text(text2);
			((Control)edit).Show();
		}
	}

	private void clpDelete_Click(object sender, EventArgs e)
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected I4, but got Unknown
		if (lstRecords.get_SelectedIndex() <= -1)
		{
			return;
		}
		string text = Conversions.ToString(lstUnique.get_Items().get_Item(lstRecords.get_SelectedIndex()));
		string text2 = text.Substring(text.LastIndexOf(" "));
		text2 = text2.Substring(1, checked(text2.Length - 1));
		int num = Conversions.ToInteger(text2);
		int num2 = (int)MessageBox.Show("Are you sure you want to delete child?\r\nThis cannot be undone.", "Are you sure?", (MessageBoxButtons)3);
		if (num2 == 6)
		{
			Database_Handling database_Handling = new Database_Handling();
			database_Handling.DeleteChild(num);
			Child.lstChild.RemoveAll((Child Child) => Child.intUnique == num);
			FillListBox();
			HideLabels();
		}
	}

	private void Records_Screen_Load(object sender, EventArgs e)
	{
		HideLabels();
	}

	private void HideLabels()
	{
		((Control)lblName).set_Visible(false);
		((Control)lblBirthday).set_Visible(false);
		((Control)lblFlagDate).set_Visible(false);
		((Control)lblAge).set_Visible(false);
		((Control)lblCurrentClassroom).set_Visible(false);
		((Control)lblNextClassroom).set_Visible(false);
		((Control)lblMondayTime).set_Visible(false);
		((Control)lblTuesdayTime).set_Visible(false);
		((Control)lblWednesdayTime).set_Visible(false);
		((Control)lblThursdayTime).set_Visible(false);
		((Control)lblFridayTime).set_Visible(false);
	}

	private void btnMainMenu_Click(object sender, EventArgs e)
	{
		Main_Menu main_Menu = new Main_Menu();
		((Control)main_Menu).Show();
		((Form)this).Close();
	}
}
