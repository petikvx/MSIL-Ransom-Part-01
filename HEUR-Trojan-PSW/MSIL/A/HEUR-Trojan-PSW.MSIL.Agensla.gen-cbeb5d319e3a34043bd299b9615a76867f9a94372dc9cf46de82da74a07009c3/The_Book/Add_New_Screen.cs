using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using The_Book.My;

namespace The_Book;

[DesignerGenerated]
public class Add_New_Screen : Form
{
	private IContainer components;

	private Child New_Child;

	[field: AccessedThroughProperty("grpNames")]
	internal virtual GroupBox grpNames
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Classrooms")]
	internal virtual GroupBox Classrooms
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grpDates")]
	internal virtual GroupBox grpDates
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grpAutoAssigned")]
	internal virtual GroupBox grpAutoAssigned
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grpMonday")]
	internal virtual GroupBox grpMonday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Tuesday")]
	internal virtual GroupBox Tuesday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grpWednesday")]
	internal virtual GroupBox grpWednesday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grpThursday")]
	internal virtual GroupBox grpThursday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grpFriday")]
	internal virtual GroupBox grpFriday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtLastName")]
	internal virtual TextBox txtLastName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFirstName")]
	internal virtual TextBox txtFirstName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtBirthday")]
	internal virtual TextBox txtBirthday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox cboCurrentClassroom
	{
		[CompilerGenerated]
		get
		{
			return _cboCurrentClassroom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cboCurrentClassroom_DropDown;
			ComboBox val = _cboCurrentClassroom;
			if (val != null)
			{
				val.remove_DropDown(eventHandler);
			}
			_cboCurrentClassroom = value;
			val = _cboCurrentClassroom;
			if (val != null)
			{
				val.add_DropDown(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("txtUniqueIdentifier")]
	internal virtual TextBox txtUniqueIdentifier
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbFull_Day_Monday")]
	internal virtual RadioButton rbFull_Day_Monday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbFull_Day_Tuesday")]
	internal virtual RadioButton rbFull_Day_Tuesday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbFull_Day_Wednesday")]
	internal virtual RadioButton rbFull_Day_Wednesday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbFull_Day_Thursday")]
	internal virtual RadioButton rbFull_Day_Thursday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbFull_Day_Friday")]
	internal virtual RadioButton rbFull_Day_Friday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbHalf_AM_Monday")]
	internal virtual RadioButton rbHalf_AM_Monday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbHalf_AM_Tuesday")]
	internal virtual RadioButton rbHalf_AM_Tuesday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbHalf_AM_Wednesday")]
	internal virtual RadioButton rbHalf_AM_Wednesday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbHalf_AM_Thursday")]
	internal virtual RadioButton rbHalf_AM_Thursday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbHalf_AM_Friday")]
	internal virtual RadioButton rbHalf_AM_Friday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbHalf_PM_Monday")]
	internal virtual RadioButton rbHalf_PM_Monday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbHalf_PM_Tuesday")]
	internal virtual RadioButton rbHalf_PM_Tuesday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbHalf_PM_Wednesday")]
	internal virtual RadioButton rbHalf_PM_Wednesday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbHalf_PM_Thursday")]
	internal virtual RadioButton rbHalf_PM_Thursday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbHalf_PM_Friday")]
	internal virtual RadioButton rbHalf_PM_Friday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbAbsent_Monday")]
	internal virtual RadioButton rbAbsent_Monday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbAbsent_Tuesday")]
	internal virtual RadioButton rbAbsent_Tuesday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbAbsent_Wednesday")]
	internal virtual RadioButton rbAbsent_Wednesday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbAbsent_Thursday")]
	internal virtual RadioButton rbAbsent_Thursday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbAbsent_Friday")]
	internal virtual RadioButton rbAbsent_Friday
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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

	internal virtual PictureBox clpAccept
	{
		[CompilerGenerated]
		get
		{
			return _clpAccept;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = clpAccept_Click;
			PictureBox val = _clpAccept;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_clpAccept = value;
			val = _clpAccept;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox clpCancel
	{
		[CompilerGenerated]
		get
		{
			return _clpCancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = clpCancel_Click;
			PictureBox val = _clpCancel;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_clpCancel = value;
			val = _clpCancel;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("txtStartDate")]
	internal virtual TextBox txtStartDate
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

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
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

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
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

	public Add_New_Screen()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((Control)this).add_Paint(new PaintEventHandler(Form_Paint));
		((Form)this).add_Shown((EventHandler)Add_New_Screen_Shown);
		((Form)this).add_Load((EventHandler)Add_New_Screen_Load);
		New_Child = new Child();
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
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected O, but got Unknown
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected O, but got Unknown
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected O, but got Unknown
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Expected O, but got Unknown
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ed: Expected O, but got Unknown
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected O, but got Unknown
		//IL_07f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fd: Expected O, but got Unknown
		//IL_08b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c3: Expected O, but got Unknown
		//IL_09af: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b9: Expected O, but got Unknown
		//IL_0a41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4b: Expected O, but got Unknown
		//IL_0b74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7e: Expected O, but got Unknown
		//IL_0c00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0a: Expected O, but got Unknown
		//IL_0c96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca0: Expected O, but got Unknown
		//IL_0d2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d36: Expected O, but got Unknown
		//IL_0dc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcc: Expected O, but got Unknown
		//IL_0eb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebe: Expected O, but got Unknown
		//IL_0f43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4d: Expected O, but got Unknown
		//IL_0fd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe3: Expected O, but got Unknown
		//IL_106f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1079: Expected O, but got Unknown
		//IL_1105: Unknown result type (might be due to invalid IL or missing references)
		//IL_110f: Expected O, but got Unknown
		//IL_11f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1201: Expected O, but got Unknown
		//IL_1286: Unknown result type (might be due to invalid IL or missing references)
		//IL_1290: Expected O, but got Unknown
		//IL_131c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1326: Expected O, but got Unknown
		//IL_13b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bc: Expected O, but got Unknown
		//IL_1448: Unknown result type (might be due to invalid IL or missing references)
		//IL_1452: Expected O, but got Unknown
		//IL_153a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1544: Expected O, but got Unknown
		//IL_15c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d3: Expected O, but got Unknown
		//IL_165f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1669: Expected O, but got Unknown
		//IL_16f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ff: Expected O, but got Unknown
		//IL_178b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1795: Expected O, but got Unknown
		//IL_187d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1887: Expected O, but got Unknown
		//IL_190c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1916: Expected O, but got Unknown
		//IL_19a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ac: Expected O, but got Unknown
		//IL_1a38: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a42: Expected O, but got Unknown
		//IL_1ace: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad8: Expected O, but got Unknown
		//IL_1b56: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b60: Expected O, but got Unknown
		//IL_1bd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bdd: Expected O, but got Unknown
		//IL_1cd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce0: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Add_New_Screen));
		grpNames = new GroupBox();
		Label2 = new Label();
		Label1 = new Label();
		txtFirstName = new TextBox();
		txtLastName = new TextBox();
		Classrooms = new GroupBox();
		Label3 = new Label();
		cboCurrentClassroom = new ComboBox();
		grpDates = new GroupBox();
		Label4 = new Label();
		txtStartDate = new TextBox();
		Label5 = new Label();
		txtBirthday = new TextBox();
		grpAutoAssigned = new GroupBox();
		Label8 = new Label();
		txtUniqueIdentifier = new TextBox();
		grpMonday = new GroupBox();
		rbAbsent_Monday = new RadioButton();
		rbHalf_PM_Monday = new RadioButton();
		rbHalf_AM_Monday = new RadioButton();
		rbFull_Day_Monday = new RadioButton();
		Tuesday = new GroupBox();
		rbAbsent_Tuesday = new RadioButton();
		rbHalf_PM_Tuesday = new RadioButton();
		rbHalf_AM_Tuesday = new RadioButton();
		rbFull_Day_Tuesday = new RadioButton();
		grpWednesday = new GroupBox();
		rbAbsent_Wednesday = new RadioButton();
		rbHalf_PM_Wednesday = new RadioButton();
		rbHalf_AM_Wednesday = new RadioButton();
		rbFull_Day_Wednesday = new RadioButton();
		grpThursday = new GroupBox();
		rbAbsent_Thursday = new RadioButton();
		rbHalf_PM_Thursday = new RadioButton();
		rbHalf_AM_Thursday = new RadioButton();
		rbFull_Day_Thursday = new RadioButton();
		grpFriday = new GroupBox();
		rbAbsent_Friday = new RadioButton();
		rbHalf_PM_Friday = new RadioButton();
		rbHalf_AM_Friday = new RadioButton();
		rbFull_Day_Friday = new RadioButton();
		clpAccept = new PictureBox();
		clpCancel = new PictureBox();
		Label7 = new Label();
		Label9 = new Label();
		Label6 = new Label();
		Label10 = new Label();
		((Control)grpNames).SuspendLayout();
		((Control)Classrooms).SuspendLayout();
		((Control)grpDates).SuspendLayout();
		((Control)grpAutoAssigned).SuspendLayout();
		((Control)grpMonday).SuspendLayout();
		((Control)Tuesday).SuspendLayout();
		((Control)grpWednesday).SuspendLayout();
		((Control)grpThursday).SuspendLayout();
		((Control)grpFriday).SuspendLayout();
		((ISupportInitialize)clpAccept).BeginInit();
		((ISupportInitialize)clpCancel).BeginInit();
		((Control)this).SuspendLayout();
		((Control)grpNames).set_BackColor(Color.ForestGreen);
		((Control)grpNames).get_Controls().Add((Control)(object)Label2);
		((Control)grpNames).get_Controls().Add((Control)(object)Label1);
		((Control)grpNames).get_Controls().Add((Control)(object)txtFirstName);
		((Control)grpNames).get_Controls().Add((Control)(object)txtLastName);
		((Control)grpNames).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)grpNames).set_Location(new Point(69, 55));
		((Control)grpNames).set_Name("grpNames");
		((Control)grpNames).set_Size(new Size(315, 100));
		((Control)grpNames).set_TabIndex(0);
		grpNames.set_TabStop(false);
		grpNames.set_Text("Names");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(13, 57));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(100, 20));
		((Control)Label2).set_TabIndex(9);
		Label2.set_Text("* First Name:");
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(13, 24));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(100, 20));
		((Control)Label1).set_TabIndex(7);
		Label1.set_Text("* Last Name:");
		((Control)txtFirstName).set_Location(new Point(127, 57));
		((Control)txtFirstName).set_Name("txtFirstName");
		((Control)txtFirstName).set_Size(new Size(154, 22));
		((Control)txtFirstName).set_TabIndex(8);
		((Control)txtLastName).set_Location(new Point(127, 24));
		((Control)txtLastName).set_Name("txtLastName");
		((Control)txtLastName).set_Size(new Size(154, 22));
		((Control)txtLastName).set_TabIndex(7);
		((Control)Classrooms).set_BackColor(Color.ForestGreen);
		((Control)Classrooms).get_Controls().Add((Control)(object)Label3);
		((Control)Classrooms).get_Controls().Add((Control)(object)cboCurrentClassroom);
		((Control)Classrooms).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Classrooms).set_Location(new Point(416, 55));
		((Control)Classrooms).set_Name("Classrooms");
		((Control)Classrooms).set_Size(new Size(338, 100));
		((Control)Classrooms).set_TabIndex(1);
		Classrooms.set_TabStop(false);
		Classrooms.set_Text("Classrooms");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_Location(new Point(10, 43));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(155, 20));
		((Control)Label3).set_TabIndex(10);
		Label3.set_Text("* Current Classroom:");
		((ListControl)cboCurrentClassroom).set_FormattingEnabled(true);
		cboCurrentClassroom.get_Items().AddRange(new object[7] { "Select a classroom...", "Caterpillars", "Turtles/Butterflies", "Fireflies/Ladybugs", "Dragonflies/Lions", "Tree Frogs", "Kindergarten" });
		((Control)cboCurrentClassroom).set_Location(new Point(171, 43));
		((Control)cboCurrentClassroom).set_Name("cboCurrentClassroom");
		((Control)cboCurrentClassroom).set_Size(new Size(148, 24));
		((Control)cboCurrentClassroom).set_TabIndex(7);
		((Control)grpDates).set_BackColor(Color.ForestGreen);
		((Control)grpDates).get_Controls().Add((Control)(object)Label4);
		((Control)grpDates).get_Controls().Add((Control)(object)txtStartDate);
		((Control)grpDates).get_Controls().Add((Control)(object)Label5);
		((Control)grpDates).get_Controls().Add((Control)(object)txtBirthday);
		((Control)grpDates).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)grpDates).set_Location(new Point(69, 172));
		((Control)grpDates).set_Name("grpDates");
		((Control)grpDates).set_Size(new Size(315, 108));
		((Control)grpDates).set_TabIndex(1);
		grpDates.set_TabStop(false);
		grpDates.set_Text("Dates (mm/dd/yyyy)");
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_Location(new Point(26, 73));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(87, 20));
		((Control)Label4).set_TabIndex(15);
		Label4.set_Text("Start Date:");
		((Control)txtStartDate).set_Location(new Point(127, 73));
		((Control)txtStartDate).set_Name("txtStartDate");
		((Control)txtStartDate).set_Size(new Size(155, 22));
		((Control)txtStartDate).set_TabIndex(13);
		Label5.set_AutoSize(true);
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_Location(new Point(32, 35));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(81, 20));
		((Control)Label5).set_TabIndex(12);
		Label5.set_Text("* Birthday:");
		((Control)txtBirthday).set_Location(new Point(127, 33));
		((Control)txtBirthday).set_Name("txtBirthday");
		((Control)txtBirthday).set_Size(new Size(155, 22));
		((Control)txtBirthday).set_TabIndex(9);
		((Control)grpAutoAssigned).set_BackColor(Color.ForestGreen);
		((Control)grpAutoAssigned).get_Controls().Add((Control)(object)Label8);
		((Control)grpAutoAssigned).get_Controls().Add((Control)(object)txtUniqueIdentifier);
		((Control)grpAutoAssigned).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)grpAutoAssigned).set_Location(new Point(416, 181));
		((Control)grpAutoAssigned).set_Name("grpAutoAssigned");
		((Control)grpAutoAssigned).set_Size(new Size(338, 88));
		((Control)grpAutoAssigned).set_TabIndex(2);
		grpAutoAssigned.set_TabStop(false);
		grpAutoAssigned.set_Text("Unique Identifier");
		Label8.set_AutoSize(true);
		((Control)Label8).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_Location(new Point(35, 39));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(130, 20));
		((Control)Label8).set_TabIndex(15);
		Label8.set_Text("Unique Identifier:");
		((Control)txtUniqueIdentifier).set_Enabled(false);
		((Control)txtUniqueIdentifier).set_Location(new Point(171, 39));
		((Control)txtUniqueIdentifier).set_Name("txtUniqueIdentifier");
		((Control)txtUniqueIdentifier).set_Size(new Size(138, 22));
		((Control)txtUniqueIdentifier).set_TabIndex(8);
		((Control)grpMonday).set_BackColor(Color.ForestGreen);
		((Control)grpMonday).get_Controls().Add((Control)(object)rbAbsent_Monday);
		((Control)grpMonday).get_Controls().Add((Control)(object)rbHalf_PM_Monday);
		((Control)grpMonday).get_Controls().Add((Control)(object)rbHalf_AM_Monday);
		((Control)grpMonday).get_Controls().Add((Control)(object)rbFull_Day_Monday);
		((Control)grpMonday).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)grpMonday).set_Location(new Point(112, 298));
		((Control)grpMonday).set_Name("grpMonday");
		((Control)grpMonday).set_Size(new Size(115, 115));
		((Control)grpMonday).set_TabIndex(2);
		grpMonday.set_TabStop(false);
		grpMonday.set_Text("* Monday ");
		((ButtonBase)rbAbsent_Monday).set_AutoSize(true);
		((Control)rbAbsent_Monday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbAbsent_Monday).set_Location(new Point(16, 88));
		((Control)rbAbsent_Monday).set_Name("rbAbsent_Monday");
		((Control)rbAbsent_Monday).set_Size(new Size(78, 24));
		((Control)rbAbsent_Monday).set_TabIndex(12);
		rbAbsent_Monday.set_TabStop(true);
		((ButtonBase)rbAbsent_Monday).set_Text("Absent");
		((ButtonBase)rbAbsent_Monday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbHalf_PM_Monday).set_AutoSize(true);
		((Control)rbHalf_PM_Monday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbHalf_PM_Monday).set_Location(new Point(16, 65));
		((Control)rbHalf_PM_Monday).set_Name("rbHalf_PM_Monday");
		((Control)rbHalf_PM_Monday).set_Size(new Size(83, 24));
		((Control)rbHalf_PM_Monday).set_TabIndex(11);
		rbHalf_PM_Monday.set_TabStop(true);
		((ButtonBase)rbHalf_PM_Monday).set_Text("Half PM");
		((ButtonBase)rbHalf_PM_Monday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbHalf_AM_Monday).set_AutoSize(true);
		((Control)rbHalf_AM_Monday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbHalf_AM_Monday).set_Location(new Point(16, 42));
		((Control)rbHalf_AM_Monday).set_Name("rbHalf_AM_Monday");
		((Control)rbHalf_AM_Monday).set_Size(new Size(84, 24));
		((Control)rbHalf_AM_Monday).set_TabIndex(10);
		rbHalf_AM_Monday.set_TabStop(true);
		((ButtonBase)rbHalf_AM_Monday).set_Text("Half AM");
		((ButtonBase)rbHalf_AM_Monday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbFull_Day_Monday).set_AutoSize(true);
		((Control)rbFull_Day_Monday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbFull_Day_Monday).set_Location(new Point(16, 19));
		((Control)rbFull_Day_Monday).set_Name("rbFull_Day_Monday");
		((Control)rbFull_Day_Monday).set_Size(new Size(84, 24));
		((Control)rbFull_Day_Monday).set_TabIndex(9);
		rbFull_Day_Monday.set_TabStop(true);
		((ButtonBase)rbFull_Day_Monday).set_Text("Full Day");
		((ButtonBase)rbFull_Day_Monday).set_UseVisualStyleBackColor(true);
		((Control)Tuesday).set_BackColor(Color.ForestGreen);
		((Control)Tuesday).get_Controls().Add((Control)(object)rbAbsent_Tuesday);
		((Control)Tuesday).get_Controls().Add((Control)(object)rbHalf_PM_Tuesday);
		((Control)Tuesday).get_Controls().Add((Control)(object)rbHalf_AM_Tuesday);
		((Control)Tuesday).get_Controls().Add((Control)(object)rbFull_Day_Tuesday);
		((Control)Tuesday).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Tuesday).set_Location(new Point(233, 298));
		((Control)Tuesday).set_Name("Tuesday");
		((Control)Tuesday).set_Size(new Size(115, 115));
		((Control)Tuesday).set_TabIndex(3);
		Tuesday.set_TabStop(false);
		Tuesday.set_Text("* Tuesday");
		((ButtonBase)rbAbsent_Tuesday).set_AutoSize(true);
		((Control)rbAbsent_Tuesday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbAbsent_Tuesday).set_Location(new Point(16, 88));
		((Control)rbAbsent_Tuesday).set_Name("rbAbsent_Tuesday");
		((Control)rbAbsent_Tuesday).set_Size(new Size(78, 24));
		((Control)rbAbsent_Tuesday).set_TabIndex(13);
		rbAbsent_Tuesday.set_TabStop(true);
		((ButtonBase)rbAbsent_Tuesday).set_Text("Absent");
		((ButtonBase)rbAbsent_Tuesday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbHalf_PM_Tuesday).set_AutoSize(true);
		((Control)rbHalf_PM_Tuesday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbHalf_PM_Tuesday).set_Location(new Point(16, 65));
		((Control)rbHalf_PM_Tuesday).set_Name("rbHalf_PM_Tuesday");
		((Control)rbHalf_PM_Tuesday).set_Size(new Size(83, 24));
		((Control)rbHalf_PM_Tuesday).set_TabIndex(12);
		rbHalf_PM_Tuesday.set_TabStop(true);
		((ButtonBase)rbHalf_PM_Tuesday).set_Text("Half PM");
		((ButtonBase)rbHalf_PM_Tuesday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbHalf_AM_Tuesday).set_AutoSize(true);
		((Control)rbHalf_AM_Tuesday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbHalf_AM_Tuesday).set_Location(new Point(16, 42));
		((Control)rbHalf_AM_Tuesday).set_Name("rbHalf_AM_Tuesday");
		((Control)rbHalf_AM_Tuesday).set_Size(new Size(84, 24));
		((Control)rbHalf_AM_Tuesday).set_TabIndex(11);
		rbHalf_AM_Tuesday.set_TabStop(true);
		((ButtonBase)rbHalf_AM_Tuesday).set_Text("Half AM");
		((ButtonBase)rbHalf_AM_Tuesday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbFull_Day_Tuesday).set_AutoSize(true);
		((Control)rbFull_Day_Tuesday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbFull_Day_Tuesday).set_Location(new Point(16, 19));
		((Control)rbFull_Day_Tuesday).set_Name("rbFull_Day_Tuesday");
		((Control)rbFull_Day_Tuesday).set_Size(new Size(84, 24));
		((Control)rbFull_Day_Tuesday).set_TabIndex(10);
		rbFull_Day_Tuesday.set_TabStop(true);
		((ButtonBase)rbFull_Day_Tuesday).set_Text("Full Day");
		((ButtonBase)rbFull_Day_Tuesday).set_UseVisualStyleBackColor(true);
		((Control)grpWednesday).set_BackColor(Color.ForestGreen);
		((Control)grpWednesday).get_Controls().Add((Control)(object)rbAbsent_Wednesday);
		((Control)grpWednesday).get_Controls().Add((Control)(object)rbHalf_PM_Wednesday);
		((Control)grpWednesday).get_Controls().Add((Control)(object)rbHalf_AM_Wednesday);
		((Control)grpWednesday).get_Controls().Add((Control)(object)rbFull_Day_Wednesday);
		((Control)grpWednesday).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)grpWednesday).set_Location(new Point(354, 298));
		((Control)grpWednesday).set_Name("grpWednesday");
		((Control)grpWednesday).set_Size(new Size(115, 115));
		((Control)grpWednesday).set_TabIndex(4);
		grpWednesday.set_TabStop(false);
		grpWednesday.set_Text("* Wednesday");
		((ButtonBase)rbAbsent_Wednesday).set_AutoSize(true);
		((Control)rbAbsent_Wednesday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbAbsent_Wednesday).set_Location(new Point(16, 88));
		((Control)rbAbsent_Wednesday).set_Name("rbAbsent_Wednesday");
		((Control)rbAbsent_Wednesday).set_Size(new Size(78, 24));
		((Control)rbAbsent_Wednesday).set_TabIndex(14);
		rbAbsent_Wednesday.set_TabStop(true);
		((ButtonBase)rbAbsent_Wednesday).set_Text("Absent");
		((ButtonBase)rbAbsent_Wednesday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbHalf_PM_Wednesday).set_AutoSize(true);
		((Control)rbHalf_PM_Wednesday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbHalf_PM_Wednesday).set_Location(new Point(16, 65));
		((Control)rbHalf_PM_Wednesday).set_Name("rbHalf_PM_Wednesday");
		((Control)rbHalf_PM_Wednesday).set_Size(new Size(83, 24));
		((Control)rbHalf_PM_Wednesday).set_TabIndex(13);
		rbHalf_PM_Wednesday.set_TabStop(true);
		((ButtonBase)rbHalf_PM_Wednesday).set_Text("Half PM");
		((ButtonBase)rbHalf_PM_Wednesday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbHalf_AM_Wednesday).set_AutoSize(true);
		((Control)rbHalf_AM_Wednesday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbHalf_AM_Wednesday).set_Location(new Point(16, 42));
		((Control)rbHalf_AM_Wednesday).set_Name("rbHalf_AM_Wednesday");
		((Control)rbHalf_AM_Wednesday).set_Size(new Size(84, 24));
		((Control)rbHalf_AM_Wednesday).set_TabIndex(12);
		rbHalf_AM_Wednesday.set_TabStop(true);
		((ButtonBase)rbHalf_AM_Wednesday).set_Text("Half AM");
		((ButtonBase)rbHalf_AM_Wednesday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbFull_Day_Wednesday).set_AutoSize(true);
		((Control)rbFull_Day_Wednesday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbFull_Day_Wednesday).set_Location(new Point(16, 19));
		((Control)rbFull_Day_Wednesday).set_Name("rbFull_Day_Wednesday");
		((Control)rbFull_Day_Wednesday).set_Size(new Size(84, 24));
		((Control)rbFull_Day_Wednesday).set_TabIndex(11);
		rbFull_Day_Wednesday.set_TabStop(true);
		((ButtonBase)rbFull_Day_Wednesday).set_Text("Full Day");
		((ButtonBase)rbFull_Day_Wednesday).set_UseVisualStyleBackColor(true);
		((Control)grpThursday).set_BackColor(Color.ForestGreen);
		((Control)grpThursday).get_Controls().Add((Control)(object)rbAbsent_Thursday);
		((Control)grpThursday).get_Controls().Add((Control)(object)rbHalf_PM_Thursday);
		((Control)grpThursday).get_Controls().Add((Control)(object)rbHalf_AM_Thursday);
		((Control)grpThursday).get_Controls().Add((Control)(object)rbFull_Day_Thursday);
		((Control)grpThursday).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)grpThursday).set_Location(new Point(475, 298));
		((Control)grpThursday).set_Name("grpThursday");
		((Control)grpThursday).set_Size(new Size(115, 115));
		((Control)grpThursday).set_TabIndex(5);
		grpThursday.set_TabStop(false);
		grpThursday.set_Text("* Thursday");
		((ButtonBase)rbAbsent_Thursday).set_AutoSize(true);
		((Control)rbAbsent_Thursday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbAbsent_Thursday).set_Location(new Point(16, 88));
		((Control)rbAbsent_Thursday).set_Name("rbAbsent_Thursday");
		((Control)rbAbsent_Thursday).set_Size(new Size(78, 24));
		((Control)rbAbsent_Thursday).set_TabIndex(14);
		rbAbsent_Thursday.set_TabStop(true);
		((ButtonBase)rbAbsent_Thursday).set_Text("Absent");
		((ButtonBase)rbAbsent_Thursday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbHalf_PM_Thursday).set_AutoSize(true);
		((Control)rbHalf_PM_Thursday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbHalf_PM_Thursday).set_Location(new Point(16, 65));
		((Control)rbHalf_PM_Thursday).set_Name("rbHalf_PM_Thursday");
		((Control)rbHalf_PM_Thursday).set_Size(new Size(83, 24));
		((Control)rbHalf_PM_Thursday).set_TabIndex(14);
		rbHalf_PM_Thursday.set_TabStop(true);
		((ButtonBase)rbHalf_PM_Thursday).set_Text("Half PM");
		((ButtonBase)rbHalf_PM_Thursday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbHalf_AM_Thursday).set_AutoSize(true);
		((Control)rbHalf_AM_Thursday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbHalf_AM_Thursday).set_Location(new Point(16, 42));
		((Control)rbHalf_AM_Thursday).set_Name("rbHalf_AM_Thursday");
		((Control)rbHalf_AM_Thursday).set_Size(new Size(84, 24));
		((Control)rbHalf_AM_Thursday).set_TabIndex(13);
		rbHalf_AM_Thursday.set_TabStop(true);
		((ButtonBase)rbHalf_AM_Thursday).set_Text("Half AM");
		((ButtonBase)rbHalf_AM_Thursday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbFull_Day_Thursday).set_AutoSize(true);
		((Control)rbFull_Day_Thursday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbFull_Day_Thursday).set_Location(new Point(16, 19));
		((Control)rbFull_Day_Thursday).set_Name("rbFull_Day_Thursday");
		((Control)rbFull_Day_Thursday).set_Size(new Size(84, 24));
		((Control)rbFull_Day_Thursday).set_TabIndex(12);
		rbFull_Day_Thursday.set_TabStop(true);
		((ButtonBase)rbFull_Day_Thursday).set_Text("Full Day");
		((ButtonBase)rbFull_Day_Thursday).set_UseVisualStyleBackColor(true);
		((Control)grpFriday).set_BackColor(Color.ForestGreen);
		((Control)grpFriday).get_Controls().Add((Control)(object)rbAbsent_Friday);
		((Control)grpFriday).get_Controls().Add((Control)(object)rbHalf_PM_Friday);
		((Control)grpFriday).get_Controls().Add((Control)(object)rbHalf_AM_Friday);
		((Control)grpFriday).get_Controls().Add((Control)(object)rbFull_Day_Friday);
		((Control)grpFriday).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)grpFriday).set_Location(new Point(596, 298));
		((Control)grpFriday).set_Name("grpFriday");
		((Control)grpFriday).set_Size(new Size(115, 115));
		((Control)grpFriday).set_TabIndex(6);
		grpFriday.set_TabStop(false);
		grpFriday.set_Text("* Friday");
		((ButtonBase)rbAbsent_Friday).set_AutoSize(true);
		((Control)rbAbsent_Friday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbAbsent_Friday).set_Location(new Point(16, 88));
		((Control)rbAbsent_Friday).set_Name("rbAbsent_Friday");
		((Control)rbAbsent_Friday).set_Size(new Size(78, 24));
		((Control)rbAbsent_Friday).set_TabIndex(15);
		rbAbsent_Friday.set_TabStop(true);
		((ButtonBase)rbAbsent_Friday).set_Text("Absent");
		((ButtonBase)rbAbsent_Friday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbHalf_PM_Friday).set_AutoSize(true);
		((Control)rbHalf_PM_Friday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbHalf_PM_Friday).set_Location(new Point(16, 65));
		((Control)rbHalf_PM_Friday).set_Name("rbHalf_PM_Friday");
		((Control)rbHalf_PM_Friday).set_Size(new Size(83, 24));
		((Control)rbHalf_PM_Friday).set_TabIndex(15);
		rbHalf_PM_Friday.set_TabStop(true);
		((ButtonBase)rbHalf_PM_Friday).set_Text("Half PM");
		((ButtonBase)rbHalf_PM_Friday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbHalf_AM_Friday).set_AutoSize(true);
		((Control)rbHalf_AM_Friday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbHalf_AM_Friday).set_Location(new Point(16, 42));
		((Control)rbHalf_AM_Friday).set_Name("rbHalf_AM_Friday");
		((Control)rbHalf_AM_Friday).set_Size(new Size(84, 24));
		((Control)rbHalf_AM_Friday).set_TabIndex(14);
		rbHalf_AM_Friday.set_TabStop(true);
		((ButtonBase)rbHalf_AM_Friday).set_Text("Half AM");
		((ButtonBase)rbHalf_AM_Friday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbFull_Day_Friday).set_AutoSize(true);
		((Control)rbFull_Day_Friday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbFull_Day_Friday).set_Location(new Point(16, 19));
		((Control)rbFull_Day_Friday).set_Name("rbFull_Day_Friday");
		((Control)rbFull_Day_Friday).set_Size(new Size(84, 24));
		((Control)rbFull_Day_Friday).set_TabIndex(13);
		rbFull_Day_Friday.set_TabStop(true);
		((ButtonBase)rbFull_Day_Friday).set_Text("Full Day");
		((ButtonBase)rbFull_Day_Friday).set_UseVisualStyleBackColor(true);
		clpAccept.set_Image((Image)componentResourceManager.GetObject("clpAccept.Image"));
		((Control)clpAccept).set_Location(new Point(318, 427));
		((Control)clpAccept).set_Name("clpAccept");
		((Control)clpAccept).set_Size(new Size(76, 76));
		clpAccept.set_SizeMode((PictureBoxSizeMode)2);
		clpAccept.set_TabIndex(7);
		clpAccept.set_TabStop(false);
		clpCancel.set_Image((Image)componentResourceManager.GetObject("clpCancel.Image"));
		((Control)clpCancel).set_Location(new Point(431, 427));
		((Control)clpCancel).set_Name("clpCancel");
		((Control)clpCancel).set_Size(new Size(76, 76));
		clpCancel.set_SizeMode((PictureBoxSizeMode)2);
		clpCancel.set_TabIndex(8);
		clpCancel.set_TabStop(false);
		Label7.set_AutoSize(true);
		((Control)Label7).set_BackColor(Color.ForestGreen);
		((Control)Label7).set_Location(new Point(66, 504));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(75, 13));
		((Control)Label7).set_TabIndex(10);
		Label7.set_Text("Required Field");
		((Control)Label9).set_BackColor(Color.ForestGreen);
		((Control)Label9).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_Location(new Point(49, 500));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(21, 20));
		((Control)Label9).set_TabIndex(11);
		Label9.set_Text("*");
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.ForestGreen);
		((Control)Label6).set_Location(new Point(333, 504));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(41, 13));
		((Control)Label6).set_TabIndex(12);
		Label6.set_Text("Accept");
		Label10.set_AutoSize(true);
		((Control)Label10).set_BackColor(Color.ForestGreen);
		((Control)Label10).set_Location(new Point(452, 504));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(40, 13));
		((Control)Label10).set_TabIndex(13);
		Label10.set_Text("Cancel");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(822, 572));
		((Control)this).get_Controls().Add((Control)(object)Label10);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)Label9);
		((Control)this).get_Controls().Add((Control)(object)clpCancel);
		((Control)this).get_Controls().Add((Control)(object)clpAccept);
		((Control)this).get_Controls().Add((Control)(object)grpFriday);
		((Control)this).get_Controls().Add((Control)(object)grpThursday);
		((Control)this).get_Controls().Add((Control)(object)grpWednesday);
		((Control)this).get_Controls().Add((Control)(object)Tuesday);
		((Control)this).get_Controls().Add((Control)(object)grpMonday);
		((Control)this).get_Controls().Add((Control)(object)grpAutoAssigned);
		((Control)this).get_Controls().Add((Control)(object)grpDates);
		((Control)this).get_Controls().Add((Control)(object)Classrooms);
		((Control)this).get_Controls().Add((Control)(object)grpNames);
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Add_New_Screen");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Add New Child");
		((Control)grpNames).ResumeLayout(false);
		((Control)grpNames).PerformLayout();
		((Control)Classrooms).ResumeLayout(false);
		((Control)Classrooms).PerformLayout();
		((Control)grpDates).ResumeLayout(false);
		((Control)grpDates).PerformLayout();
		((Control)grpAutoAssigned).ResumeLayout(false);
		((Control)grpAutoAssigned).PerformLayout();
		((Control)grpMonday).ResumeLayout(false);
		((Control)grpMonday).PerformLayout();
		((Control)Tuesday).ResumeLayout(false);
		((Control)Tuesday).PerformLayout();
		((Control)grpWednesday).ResumeLayout(false);
		((Control)grpWednesday).PerformLayout();
		((Control)grpThursday).ResumeLayout(false);
		((Control)grpThursday).PerformLayout();
		((Control)grpFriday).ResumeLayout(false);
		((Control)grpFriday).PerformLayout();
		((ISupportInitialize)clpAccept).EndInit();
		((ISupportInitialize)clpCancel).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public void Add_Child()
	{
		New_Child = new Child();
		Child new_Child = New_Child;
		new_Child.strLastName = txtLastName.get_Text();
		new_Child.strFirstName = txtFirstName.get_Text();
		new_Child.strBirthday = txtBirthday.get_Text();
		new_Child.strFlagDate = GetFlagDate(cboCurrentClassroom.get_Text(), new_Child.strCurrentSpecificClassroom, txtBirthday.get_Text());
		new_Child.intAge = GetAge(txtBirthday.get_Text());
		new_Child.intMonths = GetMonths(txtBirthday.get_Text());
		new_Child.strCurrentClassroom = cboCurrentClassroom.get_Text();
		new_Child.strNextClassroom = GetNextClassroom(cboCurrentClassroom.get_Text());
		new_Child.strMonday = DaysOfTheWeek("Monday");
		new_Child.strTuesday = DaysOfTheWeek("Tuesday");
		new_Child.strWednesday = DaysOfTheWeek("Wednesday");
		new_Child.strThursday = DaysOfTheWeek("Thursday");
		new_Child.strFriday = DaysOfTheWeek("Friday");
		new_Child.intUnique = Conversions.ToInteger(txtUniqueIdentifier.get_Text());
		new_Child.strStartDate = txtStartDate.get_Text();
		new_Child = null;
		Child.lstChild.Add(New_Child);
		MyProject.Forms.Records_Screen.lstRecords.set_SelectedIndex(-1);
		Database_Handling database_Handling = new Database_Handling();
		database_Handling.AddChild(New_Child.strLastName, New_Child.strFirstName, New_Child.strBirthday, New_Child.intAge, New_Child.intMonths, New_Child.strFlagDate, New_Child.strCurrentClassroom, New_Child.strNextClassroom, New_Child.strCurrentSpecificClassroom, New_Child.strNextSpecificClassroom, New_Child.strMonday, New_Child.strTuesday, New_Child.strWednesday, New_Child.strThursday, New_Child.strFriday, New_Child.intUnique, New_Child.strStartDate, New_Child.strEndDate);
		((Form)this).Close();
	}

	public string GetFlagDate(string strCurrentClassroom, string strSpecificClassroom, string strBirthday)
	{
		int num = Conversions.ToInteger(strBirthday.Substring(0, 2));
		int num2 = Conversions.ToInteger(strBirthday.Substring(6, 4));
		int num3 = Conversions.ToInteger(strBirthday.Substring(3, 2));
		string text = DateTime.Now.ToString("MM/dd/yyyy");
		Conversions.ToInteger(text.Substring(0, 2));
		Conversions.ToInteger(text.Substring(6, 4));
		bool flag = false;
		checked
		{
			switch (strCurrentClassroom)
			{
			default:
				flag = true;
				break;
			case "Dragonflies/Lions":
				num2 += 3;
				num += 10;
				if (num > 12)
				{
					num -= 12;
					num2++;
				}
				break;
			case "Fireflies/Ladybugs":
				num2 += 2;
				num += 10;
				if (num > 12)
				{
					num -= 12;
					num2++;
				}
				break;
			case "Turtles/Butterflies":
				num2++;
				num += 10;
				if (num > 12)
				{
					num -= 12;
					num2++;
				}
				break;
			case "Caterpillars":
				num += 10;
				if (num > 12)
				{
					num -= 12;
					num2++;
				}
				break;
			}
			switch (num)
			{
			case 11:
				if (num3 > 30)
				{
					num3 = 30;
				}
				break;
			case 9:
				if (num3 > 30)
				{
					num3 = 30;
				}
				break;
			case 2:
				if (num3 > 28)
				{
					num3 = 28;
				}
				break;
			case 4:
				if (num3 > 30)
				{
					num3 = 30;
				}
				break;
			case 6:
				if (num3 > 30)
				{
					num3 = 30;
				}
				break;
			}
			string text2 = ((num >= 10) ? num.ToString() : ("0" + num));
			string text3 = ((num3 >= 10) ? num3.ToString() : ("0" + num3));
			if (!flag)
			{
				return (text2 + "/" + text3 + "/" + Conversions.ToString(num2)).ToString();
			}
			return "None";
		}
	}

	public int GetAge(string strBirthday)
	{
		string text = DateTime.Now.ToString("MM/dd/yyyy");
		int num = Conversions.ToInteger(strBirthday.Substring(6, 4));
		int num2 = Conversions.ToInteger(text.Substring(6, 4));
		checked
		{
			int num3 = num2 - num;
			int num4 = Conversions.ToInteger(strBirthday.Substring(0, 2));
			int num5 = Conversions.ToInteger(text.Substring(0, 2));
			num3 = num2 - num;
			int num6 = num5 - num4;
			if (num6 < 0)
			{
				Math.Abs(num6);
				num3--;
			}
			return num3;
		}
	}

	public int GetMonths(string strBirthday)
	{
		string text = DateTime.Now.ToString("MM/dd/yyyy");
		int num = Conversions.ToInteger(strBirthday.Substring(0, 2));
		int num2 = Conversions.ToInteger(text.Substring(0, 2));
		checked
		{
			int num3 = num2 - num;
			if (num3 < 0)
			{
				num3 = Math.Abs(num3);
				num3 = 12 - num3;
			}
			return num3;
		}
	}

	private string GetNextClassroom(string strCurrentClassroom)
	{
		string result = "";
		switch (strCurrentClassroom)
		{
		case "Kindergarten":
			result = "TBA";
			break;
		case "Tree Frogs":
			result = "TBA";
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
		return result;
	}

	private string DaysOfTheWeek(string strDayTime)
	{
		string result = "";
		switch (strDayTime)
		{
		case "Friday":
			result = ((!rbFull_Day_Friday.get_Checked()) ? ((!rbHalf_AM_Friday.get_Checked()) ? ((!rbHalf_PM_Friday.get_Checked()) ? "Absent" : "Half PM") : "Half AM") : "Full Day");
			break;
		case "Thursday":
			result = ((!rbFull_Day_Thursday.get_Checked()) ? ((!rbHalf_AM_Thursday.get_Checked()) ? ((!rbHalf_PM_Thursday.get_Checked()) ? "Absent" : "Half PM") : "Half AM") : "Full Day");
			break;
		case "Wednesday":
			result = ((!rbFull_Day_Wednesday.get_Checked()) ? ((!rbHalf_AM_Wednesday.get_Checked()) ? ((!rbHalf_PM_Wednesday.get_Checked()) ? "Absent" : "Half PM") : "Half AM") : "Full Day");
			break;
		case "Tuesday":
			result = ((!rbFull_Day_Tuesday.get_Checked()) ? ((!rbHalf_AM_Tuesday.get_Checked()) ? ((!rbHalf_PM_Tuesday.get_Checked()) ? "Absent" : "Half PM") : "Half AM") : "Full Day");
			break;
		case "Monday":
			result = ((!rbFull_Day_Monday.get_Checked()) ? ((!rbHalf_AM_Monday.get_Checked()) ? ((!rbHalf_PM_Monday.get_Checked()) ? "Absent" : "Half PM") : "Half AM") : "Full Day");
			break;
		}
		return result;
	}

	private int GetUniqueIdentifier()
	{
		Database_Handling database_Handling = new Database_Handling();
		int intID = default(int);
		database_Handling.GetNextID(ref intID);
		return intID;
	}

	private void Form_Paint(object sender, PaintEventArgs e)
	{
	}

	private void clpAccept_Click(object sender, EventArgs e)
	{
		InputValidation();
	}

	private void InputValidation()
	{
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		if (Operators.CompareString(txtLastName.get_Text(), "", false) == 0)
		{
			flag = true;
		}
		else if (Operators.CompareString(txtFirstName.get_Text(), "", false) == 0)
		{
			flag = true;
		}
		else if ((Operators.CompareString(cboCurrentClassroom.get_Text(), "Caterpillars", false) != 0) & (Operators.CompareString(cboCurrentClassroom.get_Text(), "Turtles/Butterflies", false) != 0) & (Operators.CompareString(cboCurrentClassroom.get_Text(), "Fireflies/Ladybugs", false) != 0) & (Operators.CompareString(cboCurrentClassroom.get_Text(), "Dragonflies/Lions", false) != 0) & (Operators.CompareString(cboCurrentClassroom.get_Text(), "Tree Frogs", false) != 0) & (Operators.CompareString(cboCurrentClassroom.get_Text(), "Kindergarten", false) != 0))
		{
			flag = true;
		}
		else if (!Information.IsDate((object)txtBirthday.get_Text()) | (txtBirthday.get_Text().Length != 10))
		{
			flag = true;
		}
		else if (Operators.CompareString(txtStartDate.get_Text(), "", false) != 0)
		{
			if (!Information.IsDate((object)txtStartDate.get_Text()) | (txtStartDate.get_Text().Length != 10))
			{
				flag = true;
			}
		}
		else if (!rbFull_Day_Monday.get_Checked() & !rbHalf_AM_Monday.get_Checked() & !rbHalf_PM_Monday.get_Checked() & !rbAbsent_Monday.get_Checked())
		{
			flag = true;
		}
		else if (!rbFull_Day_Tuesday.get_Checked() & !rbHalf_AM_Tuesday.get_Checked() & !rbHalf_PM_Tuesday.get_Checked() & !rbAbsent_Tuesday.get_Checked())
		{
			flag = true;
		}
		else if (!rbFull_Day_Wednesday.get_Checked() & !rbHalf_AM_Wednesday.get_Checked() & !rbHalf_PM_Wednesday.get_Checked() & !rbAbsent_Wednesday.get_Checked())
		{
			flag = true;
		}
		else if (!rbFull_Day_Thursday.get_Checked() & !rbHalf_AM_Thursday.get_Checked() & !rbHalf_PM_Thursday.get_Checked() & !rbAbsent_Thursday.get_Checked())
		{
			flag = true;
		}
		else if (!rbFull_Day_Friday.get_Checked() & !rbHalf_AM_Friday.get_Checked() & !rbHalf_PM_Friday.get_Checked() & !rbAbsent_Friday.get_Checked())
		{
			flag = true;
		}
		if (!flag)
		{
			Add_Child();
		}
		else
		{
			MessageBox.Show("Error - Please check the following:\r\n\r\n - Required fields are not left blank.\r\n - Date format is correct (mm/dd/yyyy).\r\n - Current classroom is one of the given options.\r\n - One time slot is selected for each day of the week.", "Error");
		}
	}

	private void Add_New_Screen_Shown(object sender, EventArgs e)
	{
		txtUniqueIdentifier.set_Text(GetUniqueIdentifier().ToString());
	}

	private void Add_New_Screen_Load(object sender, EventArgs e)
	{
		cboCurrentClassroom.set_Text(Conversions.ToString(cboCurrentClassroom.get_Items().get_Item(0)));
	}

	private void clpCancel_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got Unknown
		int num = (int)MessageBox.Show("Are you sure you want to cancel adding a new child?\r\nInformation will not be saved.", "Are you sure?", (MessageBoxButtons)3);
		if (num == 6)
		{
			((Form)this).Close();
		}
	}

	private void cboCurrentClassroom_DropDown(object sender, EventArgs e)
	{
		if (cboCurrentClassroom.get_Items().get_Count() == 7)
		{
			cboCurrentClassroom.get_Items().RemoveAt(0);
		}
	}
}
