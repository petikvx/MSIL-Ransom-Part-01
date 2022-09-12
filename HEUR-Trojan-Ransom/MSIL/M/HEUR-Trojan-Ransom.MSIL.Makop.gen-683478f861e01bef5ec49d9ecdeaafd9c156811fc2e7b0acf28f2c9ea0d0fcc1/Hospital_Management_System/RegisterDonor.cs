using System;
using System.ComponentModel;
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
internal class RegisterDonor : UserControl
{
	private IContainer components;

	private OleDbConnection myconnection;

	internal virtual Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			Timer timer = _Timer1;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			timer = _Timer1;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("SuccessMsg")]
	internal virtual Label SuccessMsg
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

	internal virtual Button AddBtn
	{
		[CompilerGenerated]
		get
		{
			return _AddBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button1_Click;
			Button addBtn = _AddBtn;
			if (addBtn != null)
			{
				((Control)addBtn).remove_Click(eventHandler);
			}
			_AddBtn = value;
			addBtn = _AddBtn;
			if (addBtn != null)
			{
				((Control)addBtn).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox8")]
	internal virtual CheckBox CheckBox8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox7")]
	internal virtual CheckBox CheckBox7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox6")]
	internal virtual CheckBox CheckBox6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox5")]
	internal virtual CheckBox CheckBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox4")]
	internal virtual CheckBox CheckBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox3")]
	internal virtual CheckBox CheckBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox2")]
	internal virtual CheckBox CheckBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox1")]
	internal virtual CheckBox CheckBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateTxt")]
	internal virtual TextBox DateTxt
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

	[field: AccessedThroughProperty("QuantityTxt")]
	internal virtual TextBox QuantityTxt
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

	[field: AccessedThroughProperty("WarningLbl")]
	internal virtual Label WarningLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BloodGrpTxt")]
	internal virtual ComboBox BloodGrpTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BloodGrpLbl")]
	internal virtual Label BloodGrpLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox GenderTxt
	{
		[CompilerGenerated]
		get
		{
			return _GenderTxt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = GenderTxt_SelectionChangeCommitted;
			ComboBox genderTxt = _GenderTxt;
			if (genderTxt != null)
			{
				genderTxt.remove_SelectionChangeCommitted(eventHandler);
			}
			_GenderTxt = value;
			genderTxt = _GenderTxt;
			if (genderTxt != null)
			{
				genderTxt.add_SelectionChangeCommitted(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("AgeLbl")]
	internal virtual Label AgeLbl
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

	[field: AccessedThroughProperty("MobileLbl")]
	internal virtual Label MobileLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GenderLbl")]
	internal virtual Label GenderLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NameLbl")]
	internal virtual Label NameLbl
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

	[field: AccessedThroughProperty("NameTxt")]
	internal virtual TextBox NameTxt
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

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
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

	public RegisterDonor()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		((UserControl)this).add_Load((EventHandler)RegisterDonor_Load);
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected O, but got Unknown
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected O, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected O, but got Unknown
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Expected O, but got Unknown
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Expected O, but got Unknown
		//IL_061d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Expected O, but got Unknown
		//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Expected O, but got Unknown
		//IL_0735: Unknown result type (might be due to invalid IL or missing references)
		//IL_073f: Expected O, but got Unknown
		//IL_07c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cb: Expected O, but got Unknown
		//IL_084d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0857: Expected O, but got Unknown
		//IL_08d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e3: Expected O, but got Unknown
		//IL_0968: Unknown result type (might be due to invalid IL or missing references)
		//IL_0972: Expected O, but got Unknown
		//IL_0b45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4f: Expected O, but got Unknown
		//IL_0bcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd6: Expected O, but got Unknown
		//IL_0c4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c56: Expected O, but got Unknown
		//IL_0cce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd8: Expected O, but got Unknown
		//IL_0d42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4c: Expected O, but got Unknown
		//IL_0dd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddd: Expected O, but got Unknown
		//IL_0e74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7e: Expected O, but got Unknown
		//IL_0f53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5d: Expected O, but got Unknown
		//IL_0fd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdf: Expected O, but got Unknown
		//IL_1080: Unknown result type (might be due to invalid IL or missing references)
		//IL_108a: Expected O, but got Unknown
		//IL_1102: Unknown result type (might be due to invalid IL or missing references)
		//IL_110c: Expected O, but got Unknown
		//IL_1173: Unknown result type (might be due to invalid IL or missing references)
		//IL_117d: Expected O, but got Unknown
		//IL_1200: Unknown result type (might be due to invalid IL or missing references)
		//IL_120a: Expected O, but got Unknown
		//IL_128d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1297: Expected O, but got Unknown
		//IL_130b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1315: Expected O, but got Unknown
		//IL_1375: Unknown result type (might be due to invalid IL or missing references)
		//IL_137f: Expected O, but got Unknown
		//IL_13e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ef: Expected O, but got Unknown
		//IL_14e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f3: Expected O, but got Unknown
		components = new Container();
		Timer1 = new Timer(components);
		SuccessMsg = new Label();
		ClearBtn = new Button();
		AddBtn = new Button();
		GroupBox1 = new GroupBox();
		Label3 = new Label();
		CheckBox8 = new CheckBox();
		CheckBox7 = new CheckBox();
		CheckBox6 = new CheckBox();
		CheckBox5 = new CheckBox();
		CheckBox4 = new CheckBox();
		CheckBox3 = new CheckBox();
		CheckBox2 = new CheckBox();
		CheckBox1 = new CheckBox();
		GroupBox2 = new GroupBox();
		DateTxt = new TextBox();
		Label2 = new Label();
		QuantityTxt = new TextBox();
		Label7 = new Label();
		WarningLbl = new Label();
		BloodGrpTxt = new ComboBox();
		BloodGrpLbl = new Label();
		GenderTxt = new ComboBox();
		AgeLbl = new Label();
		AgeTxt = new TextBox();
		MobileLbl = new Label();
		GenderLbl = new Label();
		NameLbl = new Label();
		MobileTxt = new TextBox();
		NameTxt = new TextBox();
		Label1 = new Label();
		PictureBox1 = new PictureBox();
		Label4 = new Label();
		((Control)GroupBox1).SuspendLayout();
		((Control)GroupBox2).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		Timer1.set_Interval(1500);
		((Control)SuccessMsg).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1));
		((Control)SuccessMsg).set_Location(new Point(117, 174));
		((Control)SuccessMsg).set_Name("SuccessMsg");
		((Control)SuccessMsg).set_Size(new Size(401, 44));
		((Control)SuccessMsg).set_TabIndex(21);
		SuccessMsg.set_Text("Name :");
		SuccessMsg.set_TextAlign((ContentAlignment)32);
		((Control)SuccessMsg).set_Visible(false);
		((ButtonBase)ClearBtn).set_BackColor(Color.MidnightBlue);
		((Control)ClearBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)ClearBtn).set_ForeColor(Color.White);
		((Control)ClearBtn).set_Location(new Point(547, 704));
		((Control)ClearBtn).set_Name("ClearBtn");
		((Control)ClearBtn).set_Size(new Size(148, 51));
		((Control)ClearBtn).set_TabIndex(20);
		((ButtonBase)ClearBtn).set_Text("Clear");
		((ButtonBase)ClearBtn).set_UseVisualStyleBackColor(false);
		((ButtonBase)AddBtn).set_BackColor(Color.MidnightBlue);
		((Control)AddBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)AddBtn).set_ForeColor(Color.White);
		((Control)AddBtn).set_Location(new Point(760, 704));
		((Control)AddBtn).set_Name("AddBtn");
		((Control)AddBtn).set_Size(new Size(148, 51));
		((Control)AddBtn).set_TabIndex(19);
		((ButtonBase)AddBtn).set_Text("Add Donor");
		((ButtonBase)AddBtn).set_UseVisualStyleBackColor(false);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)CheckBox8);
		((Control)GroupBox1).get_Controls().Add((Control)(object)CheckBox7);
		((Control)GroupBox1).get_Controls().Add((Control)(object)CheckBox6);
		((Control)GroupBox1).get_Controls().Add((Control)(object)CheckBox5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)CheckBox4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)CheckBox3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)CheckBox2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)CheckBox1);
		((Control)GroupBox1).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox1).set_Location(new Point(614, 198));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(269, 480));
		((Control)GroupBox1).set_TabIndex(18);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Parameter Check");
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.Red);
		((Control)Label3).set_Location(new Point(31, 36));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(212, 36));
		((Control)Label3).set_TabIndex(23);
		Label3.set_Text("Diseases Not Present");
		Label3.set_TextAlign((ContentAlignment)32);
		((ButtonBase)CheckBox8).set_AutoSize(true);
		((Control)CheckBox8).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)CheckBox8).set_Location(new Point(34, 434));
		((Control)CheckBox8).set_Name("CheckBox8");
		((Control)CheckBox8).set_Size(new Size(96, 23));
		((Control)CheckBox8).set_TabIndex(7);
		((ButtonBase)CheckBox8).set_Text("Typhoid");
		((ButtonBase)CheckBox8).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox7).set_AutoSize(true);
		((Control)CheckBox7).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)CheckBox7).set_Location(new Point(34, 387));
		((Control)CheckBox7).set_Name("CheckBox7");
		((Control)CheckBox7).set_Size(new Size(116, 23));
		((Control)CheckBox7).set_TabIndex(6);
		((ButtonBase)CheckBox7).set_Text("Cholestrol");
		((ButtonBase)CheckBox7).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox6).set_AutoSize(true);
		((Control)CheckBox6).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)CheckBox6).set_Location(new Point(34, 333));
		((Control)CheckBox6).set_Name("CheckBox6");
		((Control)CheckBox6).set_Size(new Size(93, 23));
		((Control)CheckBox6).set_TabIndex(5);
		((ButtonBase)CheckBox6).set_Text("Syphilis");
		((ButtonBase)CheckBox6).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox5).set_AutoSize(true);
		((Control)CheckBox5).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)CheckBox5).set_Location(new Point(34, 284));
		((Control)CheckBox5).set_Name("CheckBox5");
		((Control)CheckBox5).set_Size(new Size(91, 23));
		((Control)CheckBox5).set_TabIndex(4);
		((ButtonBase)CheckBox5).set_Text("HTLV II");
		((ButtonBase)CheckBox5).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox4).set_AutoSize(true);
		((Control)CheckBox4).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)CheckBox4).set_Location(new Point(34, 237));
		((Control)CheckBox4).set_Name("CheckBox4");
		((Control)CheckBox4).set_Size(new Size(85, 23));
		((Control)CheckBox4).set_TabIndex(3);
		((ButtonBase)CheckBox4).set_Text("HTLV I");
		((ButtonBase)CheckBox4).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox3).set_AutoSize(true);
		((Control)CheckBox3).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)CheckBox3).set_Location(new Point(34, 187));
		((Control)CheckBox3).set_Name("CheckBox3");
		((Control)CheckBox3).set_Size(new Size(60, 23));
		((Control)CheckBox3).set_TabIndex(2);
		((ButtonBase)CheckBox3).set_Text("HIV");
		((ButtonBase)CheckBox3).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox2).set_AutoSize(true);
		((Control)CheckBox2).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)CheckBox2).set_Location(new Point(34, 137));
		((Control)CheckBox2).set_Name("CheckBox2");
		((Control)CheckBox2).set_Size(new Size(128, 23));
		((Control)CheckBox2).set_TabIndex(1);
		((ButtonBase)CheckBox2).set_Text("Hepatitus C");
		((ButtonBase)CheckBox2).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox1).set_AutoSize(true);
		((Control)CheckBox1).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)CheckBox1).set_Location(new Point(34, 86));
		((Control)CheckBox1).set_Name("CheckBox1");
		((Control)CheckBox1).set_Size(new Size(127, 23));
		((Control)CheckBox1).set_TabIndex(0);
		((ButtonBase)CheckBox1).set_Text("Hepatitus B");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox2).get_Controls().Add((Control)(object)DateTxt);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox2).get_Controls().Add((Control)(object)QuantityTxt);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label7);
		((Control)GroupBox2).get_Controls().Add((Control)(object)WarningLbl);
		((Control)GroupBox2).get_Controls().Add((Control)(object)BloodGrpTxt);
		((Control)GroupBox2).get_Controls().Add((Control)(object)BloodGrpLbl);
		((Control)GroupBox2).get_Controls().Add((Control)(object)GenderTxt);
		((Control)GroupBox2).get_Controls().Add((Control)(object)AgeLbl);
		((Control)GroupBox2).get_Controls().Add((Control)(object)AgeTxt);
		((Control)GroupBox2).get_Controls().Add((Control)(object)MobileLbl);
		((Control)GroupBox2).get_Controls().Add((Control)(object)GenderLbl);
		((Control)GroupBox2).get_Controls().Add((Control)(object)NameLbl);
		((Control)GroupBox2).get_Controls().Add((Control)(object)MobileTxt);
		((Control)GroupBox2).get_Controls().Add((Control)(object)NameTxt);
		((Control)GroupBox2).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox2).set_Location(new Point(68, 234));
		((Control)GroupBox2).set_Name("GroupBox2");
		((Control)GroupBox2).set_Size(new Size(520, 444));
		((Control)GroupBox2).set_TabIndex(17);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("Donor Information");
		((Control)DateTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)DateTxt).set_Location(new Point(121, 374));
		((Control)DateTxt).set_Name("DateTxt");
		((TextBoxBase)DateTxt).set_ReadOnly(true);
		((Control)DateTxt).set_Size(new Size(167, 26));
		((Control)DateTxt).set_TabIndex(25);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(25, 377));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(62, 19));
		((Control)Label2).set_TabIndex(24);
		Label2.set_Text("Date :");
		Label2.set_TextAlign((ContentAlignment)32);
		((Control)QuantityTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)QuantityTxt).set_Location(new Point(250, 324));
		((Control)QuantityTxt).set_Name("QuantityTxt");
		((Control)QuantityTxt).set_Size(new Size(87, 26));
		((Control)QuantityTxt).set_TabIndex(23);
		Label7.set_AutoSize(true);
		((Control)Label7).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_Location(new Point(25, 327));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(164, 19));
		((Control)Label7).set_TabIndex(22);
		Label7.set_Text("Amount Donated: ");
		Label7.set_TextAlign((ContentAlignment)32);
		WarningLbl.set_AutoSize(true);
		((Control)WarningLbl).set_Font(new Font("Microsoft Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)WarningLbl).set_ForeColor(Color.Red);
		((Control)WarningLbl).set_Location(new Point(272, 133));
		((Control)WarningLbl).set_Name("WarningLbl");
		((Control)WarningLbl).set_Size(new Size(107, 17));
		((Control)WarningLbl).set_TabIndex(21);
		WarningLbl.set_Text("(18-55 years)");
		WarningLbl.set_TextAlign((ContentAlignment)32);
		BloodGrpTxt.set_DropDownStyle((ComboBoxStyle)2);
		((Control)BloodGrpTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)BloodGrpTxt).set_FormattingEnabled(true);
		BloodGrpTxt.get_Items().AddRange(new object[9] { "--Select--", "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
		((Control)BloodGrpTxt).set_Location(new Point(163, 277));
		((Control)BloodGrpTxt).set_Name("BloodGrpTxt");
		((Control)BloodGrpTxt).set_Size(new Size(113, 27));
		((Control)BloodGrpTxt).set_TabIndex(20);
		BloodGrpLbl.set_AutoSize(true);
		((Control)BloodGrpLbl).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)BloodGrpLbl).set_Location(new Point(25, 280));
		((Control)BloodGrpLbl).set_Name("BloodGrpLbl");
		((Control)BloodGrpLbl).set_Size(new Size(127, 19));
		((Control)BloodGrpLbl).set_TabIndex(19);
		BloodGrpLbl.set_Text("Blood Group :");
		BloodGrpLbl.set_TextAlign((ContentAlignment)32);
		((Control)GenderTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)GenderTxt).set_FormattingEnabled(true);
		GenderTxt.get_Items().AddRange(new object[3] { "MALE", "FEMALE", "OTHERS" });
		((Control)GenderTxt).set_Location(new Point(127, 226));
		((Control)GenderTxt).set_Name("GenderTxt");
		((Control)GenderTxt).set_Size(new Size(124, 27));
		((Control)GenderTxt).set_TabIndex(14);
		AgeLbl.set_AutoSize(true);
		((Control)AgeLbl).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)AgeLbl).set_Location(new Point(25, 131));
		((Control)AgeLbl).set_Name("AgeLbl");
		((Control)AgeLbl).set_Size(new Size(54, 19));
		((Control)AgeLbl).set_TabIndex(13);
		AgeLbl.set_Text("Age :");
		AgeLbl.set_TextAlign((ContentAlignment)32);
		((Control)AgeTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)AgeTxt).set_Location(new Point(127, 128));
		((Control)AgeTxt).set_Name("AgeTxt");
		((Control)AgeTxt).set_Size(new Size(124, 26));
		((Control)AgeTxt).set_TabIndex(10);
		MobileLbl.set_AutoSize(true);
		((Control)MobileLbl).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)MobileLbl).set_Location(new Point(25, 181));
		((Control)MobileLbl).set_Name("MobileLbl");
		((Control)MobileLbl).set_Size(new Size(76, 19));
		((Control)MobileLbl).set_TabIndex(8);
		MobileLbl.set_Text("Mobile :");
		MobileLbl.set_TextAlign((ContentAlignment)32);
		GenderLbl.set_AutoSize(true);
		((Control)GenderLbl).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)GenderLbl).set_Location(new Point(25, 229));
		((Control)GenderLbl).set_Name("GenderLbl");
		((Control)GenderLbl).set_Size(new Size(83, 19));
		((Control)GenderLbl).set_TabIndex(6);
		GenderLbl.set_Text("Gender :");
		GenderLbl.set_TextAlign((ContentAlignment)32);
		NameLbl.set_AutoSize(true);
		((Control)NameLbl).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)NameLbl).set_Location(new Point(25, 76));
		((Control)NameLbl).set_Name("NameLbl");
		((Control)NameLbl).set_Size(new Size(71, 19));
		((Control)NameLbl).set_TabIndex(5);
		NameLbl.set_Text("Name :");
		NameLbl.set_TextAlign((ContentAlignment)32);
		((Control)MobileTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)MobileTxt).set_Location(new Point(147, 178));
		((Control)MobileTxt).set_Name("MobileTxt");
		((Control)MobileTxt).set_Size(new Size(232, 26));
		((Control)MobileTxt).set_TabIndex(2);
		((Control)NameTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)NameTxt).set_Location(new Point(127, 73));
		((Control)NameTxt).set_Name("NameTxt");
		((Control)NameTxt).set_Size(new Size(355, 26));
		((Control)NameTxt).set_TabIndex(0);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(392, 60));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(242, 35));
		((Control)Label1).set_TabIndex(16);
		Label1.set_Text("Register Donor");
		Label1.set_TextAlign((ContentAlignment)32);
		PictureBox1.set_Image((Image)(object)Resources.images1232);
		((Control)PictureBox1).set_Location(new Point(156, 33));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(230, 123));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(15);
		PictureBox1.set_TabStop(false);
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("MS Reference Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_ForeColor(Color.Red);
		((Control)Label4).set_Location(new Point(357, 328));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(84, 18));
		((Control)Label4).set_TabIndex(26);
		Label4.set_Text("(In litres)");
		Label4.set_TextAlign((ContentAlignment)32);
		((Control)Label4).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Control)this).get_Controls().Add((Control)(object)SuccessMsg);
		((Control)this).get_Controls().Add((Control)(object)ClearBtn);
		((Control)this).get_Controls().Add((Control)(object)AddBtn);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).set_Name("RegisterDonor");
		((Control)this).set_Size(new Size(977, 804));
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox2).PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void RegisterDonor_Load(object sender, EventArgs e)
	{
		myconnection.set_ConnectionString(MyProject.Forms.Form1.provider + MyProject.Forms.Form1.datafile);
		BloodGrpTxt.set_SelectedIndex(0);
		GenderTxt.set_SelectedIndex(-1);
		DateTxt.set_Text(DateTime.Today.ToShortDateString());
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		if (Validate_data())
		{
			string text = "Insert Into [Donor] (Name,Gender,Age,Blood,Mobile,[Blood Amount],[Donation Date]) Values (?,?,?,?,?,?,?)";
			myconnection.Open();
			try
			{
				OleDbCommand val = new OleDbCommand(text, myconnection);
				val.get_Parameters().Add(new OleDbParameter("Name", (object)NameTxt.get_Text().ToLower()));
				val.get_Parameters().Add(new OleDbParameter("Gender", (object)GenderTxt.get_Text().ToLower()));
				val.get_Parameters().Add(new OleDbParameter("Age", (object)(int)Convert.ToInt16(AgeTxt.get_Text())));
				val.get_Parameters().Add(new OleDbParameter("Blood", (object)BloodGrpTxt.get_Text()));
				val.get_Parameters().Add(new OleDbParameter("Mobile", (object)MobileTxt.get_Text().ToString()));
				val.get_Parameters().Add(new OleDbParameter("Blood Amount", (object)QuantityTxt.get_Text()));
				val.get_Parameters().Add(new OleDbParameter("Donation Date", (object)DateTxt.get_Text().ToString()));
				val.ExecuteNonQuery();
				((Component)(object)val).Dispose();
				myconnection.Close();
				((Control)SuccessMsg).set_Visible(true);
				SuccessMsg.set_Text("Donor Successfully Registered !!");
				((Control)SuccessMsg).set_BackColor(Color.Green);
				Timer1.Start();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				myconnection.Close();
				((Control)SuccessMsg).set_Visible(true);
				SuccessMsg.set_Text("Invalid Credentials");
				((Control)SuccessMsg).set_BackColor(Color.Red);
				Timer1.Start();
				ProjectData.ClearProjectError();
			}
		}
	}

	private bool Validate_data()
	{
		if (!MyProject.Forms.Form1.Name_Validation(NameTxt.get_Text().ToLower()))
		{
			((Control)SuccessMsg).set_Visible(true);
			SuccessMsg.set_Text("Invalid Name");
			((Control)SuccessMsg).set_BackColor(Color.Red);
			Timer1.Start();
			return false;
		}
		if (!MyProject.Forms.Form1.age_validator(AgeTxt.get_Text()))
		{
			((Control)SuccessMsg).set_Visible(true);
			SuccessMsg.set_Text("Invalid Age");
			((Control)SuccessMsg).set_BackColor(Color.Red);
			Timer1.Start();
			return false;
		}
		if (int.TryParse(AgeTxt.get_Text(), out var result) && (result < 18 || result > 55))
		{
			((Control)SuccessMsg).set_Visible(true);
			SuccessMsg.set_Text("Donor Not Eligible");
			((Control)SuccessMsg).set_BackColor(Color.Red);
			Timer1.Start();
			return false;
		}
		if (!MyProject.Forms.Form1.Gender_Validator(GenderTxt.get_Text().ToLower()))
		{
			((Control)SuccessMsg).set_Visible(true);
			SuccessMsg.set_Text("Invalid Gender");
			((Control)SuccessMsg).set_BackColor(Color.Red);
			Timer1.Start();
			return false;
		}
		if (!MyProject.Forms.Form1.Mobile_Validator(MobileTxt.get_Text()))
		{
			((Control)SuccessMsg).set_Visible(true);
			SuccessMsg.set_Text("Invalid Mobile Number");
			((Control)SuccessMsg).set_BackColor(Color.Red);
			Timer1.Start();
			return false;
		}
		if (BloodGrpTxt.get_SelectedIndex() == 0)
		{
			((Control)SuccessMsg).set_Visible(true);
			SuccessMsg.set_Text("Select Proper Blood Group");
			((Control)SuccessMsg).set_BackColor(Color.Red);
			Timer1.Start();
			return false;
		}
		if (!CheckBox1.get_Checked() | !CheckBox2.get_Checked() | !CheckBox3.get_Checked() | !CheckBox4.get_Checked() | !CheckBox5.get_Checked() | !CheckBox6.get_Checked() | !CheckBox7.get_Checked() | !CheckBox8.get_Checked())
		{
			((Control)SuccessMsg).set_Visible(true);
			SuccessMsg.set_Text("Donor Not Eligible.");
			((Control)SuccessMsg).set_BackColor(Color.Red);
			Timer1.Start();
			return false;
		}
		if (!MyProject.Forms.Form1.Decimal_Validator(QuantityTxt.get_Text()))
		{
			((Control)SuccessMsg).set_Visible(true);
			SuccessMsg.set_Text("Invalid Quantity");
			((Control)SuccessMsg).set_BackColor(Color.Red);
			Timer1.Start();
			return false;
		}
		return true;
	}

	private void ClearBtn_Click(object sender, EventArgs e)
	{
		((TextBoxBase)NameTxt).Clear();
		((TextBoxBase)AgeTxt).Clear();
		GenderTxt.set_SelectedIndex(-1);
		((TextBoxBase)MobileTxt).Clear();
		BloodGrpTxt.set_SelectedIndex(0);
		CheckBox1.set_Checked(false);
		CheckBox2.set_Checked(false);
		CheckBox3.set_Checked(false);
		CheckBox4.set_Checked(false);
		CheckBox5.set_Checked(false);
		CheckBox6.set_Checked(false);
		CheckBox7.set_Checked(false);
		CheckBox8.set_Checked(false);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		((Control)SuccessMsg).set_Visible(false);
		Timer1.Stop();
	}

	private void GenderTxt_SelectionChangeCommitted(object sender, EventArgs e)
	{
		((Control)BloodGrpTxt).Focus();
	}
}
