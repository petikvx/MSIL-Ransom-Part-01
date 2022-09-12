using System;
using System.ComponentModel;
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
public class RegisterReciever : UserControl
{
	private IContainer components;

	private OleDbConnection myconnection;

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RegisterLbl")]
	internal virtual Label RegisterLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RecieverInfoGrp")]
	internal virtual GroupBox RecieverInfoGrp
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

	[field: AccessedThroughProperty("QuantityLbl")]
	internal virtual Label QuantityLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BloodGrpCombo")]
	internal virtual ComboBox BloodGrpCombo
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

	[field: AccessedThroughProperty("DateTxt")]
	internal virtual TextBox DateTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateLbl")]
	internal virtual Label DateLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GenderTxt")]
	internal virtual ComboBox GenderTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	internal virtual Button AddReceiptantBtn
	{
		[CompilerGenerated]
		get
		{
			return _AddReceiptantBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = AddReceiptantBtn_Click;
			Button addReceiptantBtn = _AddReceiptantBtn;
			if (addReceiptantBtn != null)
			{
				((Control)addReceiptantBtn).remove_Click(eventHandler);
			}
			_AddReceiptantBtn = value;
			addReceiptantBtn = _AddReceiptantBtn;
			if (addReceiptantBtn != null)
			{
				((Control)addReceiptantBtn).add_Click(eventHandler);
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public RegisterReciever()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		((UserControl)this).add_Load((EventHandler)RegisterReciever_Load);
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
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected O, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected O, but got Unknown
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected O, but got Unknown
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected O, but got Unknown
		//IL_0656: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Expected O, but got Unknown
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f1: Expected O, but got Unknown
		//IL_0795: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Expected O, but got Unknown
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_081e: Expected O, but got Unknown
		//IL_0885: Unknown result type (might be due to invalid IL or missing references)
		//IL_088f: Expected O, but got Unknown
		//IL_0912: Unknown result type (might be due to invalid IL or missing references)
		//IL_091c: Expected O, but got Unknown
		//IL_099f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a9: Expected O, but got Unknown
		//IL_0a6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a74: Expected O, but got Unknown
		//IL_0ae1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aeb: Expected O, but got Unknown
		//IL_0b88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b92: Expected O, but got Unknown
		//IL_0c3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c45: Expected O, but got Unknown
		//IL_0d4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d58: Expected O, but got Unknown
		components = new Container();
		RegisterLbl = new Label();
		RecieverInfoGrp = new GroupBox();
		QuantityTxt = new TextBox();
		QuantityLbl = new Label();
		BloodGrpCombo = new ComboBox();
		BloodGrpLbl = new Label();
		DateTxt = new TextBox();
		DateLbl = new Label();
		GenderTxt = new ComboBox();
		AgeLbl = new Label();
		AgeTxt = new TextBox();
		MobileLbl = new Label();
		GenderLbl = new Label();
		NameLbl = new Label();
		MobileTxt = new TextBox();
		NameTxt = new TextBox();
		AddReceiptantBtn = new Button();
		ClearBtn = new Button();
		Timer1 = new Timer(components);
		SuccessMsg = new Label();
		PictureBox1 = new PictureBox();
		Label1 = new Label();
		((Control)RecieverInfoGrp).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		RegisterLbl.set_AutoSize(true);
		((Control)RegisterLbl).set_Font(new Font("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)RegisterLbl).set_Location(new Point(392, 63));
		((Control)RegisterLbl).set_Name("RegisterLbl");
		((Control)RegisterLbl).set_Size(new Size(282, 35));
		((Control)RegisterLbl).set_TabIndex(10);
		RegisterLbl.set_Text("Register Reciever");
		RegisterLbl.set_TextAlign((ContentAlignment)32);
		((Control)RecieverInfoGrp).get_Controls().Add((Control)(object)Label1);
		((Control)RecieverInfoGrp).get_Controls().Add((Control)(object)QuantityTxt);
		((Control)RecieverInfoGrp).get_Controls().Add((Control)(object)QuantityLbl);
		((Control)RecieverInfoGrp).get_Controls().Add((Control)(object)BloodGrpCombo);
		((Control)RecieverInfoGrp).get_Controls().Add((Control)(object)BloodGrpLbl);
		((Control)RecieverInfoGrp).get_Controls().Add((Control)(object)DateTxt);
		((Control)RecieverInfoGrp).get_Controls().Add((Control)(object)DateLbl);
		((Control)RecieverInfoGrp).get_Controls().Add((Control)(object)GenderTxt);
		((Control)RecieverInfoGrp).get_Controls().Add((Control)(object)AgeLbl);
		((Control)RecieverInfoGrp).get_Controls().Add((Control)(object)AgeTxt);
		((Control)RecieverInfoGrp).get_Controls().Add((Control)(object)MobileLbl);
		((Control)RecieverInfoGrp).get_Controls().Add((Control)(object)GenderLbl);
		((Control)RecieverInfoGrp).get_Controls().Add((Control)(object)NameLbl);
		((Control)RecieverInfoGrp).get_Controls().Add((Control)(object)MobileTxt);
		((Control)RecieverInfoGrp).get_Controls().Add((Control)(object)NameTxt);
		((Control)RecieverInfoGrp).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)RecieverInfoGrp).set_Location(new Point(215, 214));
		((Control)RecieverInfoGrp).set_Name("RecieverInfoGrp");
		((Control)RecieverInfoGrp).set_Size(new Size(520, 454));
		((Control)RecieverInfoGrp).set_TabIndex(11);
		RecieverInfoGrp.set_TabStop(false);
		RecieverInfoGrp.set_Text("Receiver Information");
		((Control)QuantityTxt).set_Location(new Point(135, 262));
		((Control)QuantityTxt).set_Name("QuantityTxt");
		((Control)QuantityTxt).set_Size(new Size(86, 29));
		((Control)QuantityTxt).set_TabIndex(22);
		QuantityLbl.set_AutoSize(true);
		((Control)QuantityLbl).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)QuantityLbl).set_Location(new Point(33, 269));
		((Control)QuantityLbl).set_Name("QuantityLbl");
		((Control)QuantityLbl).set_Size(new Size(80, 18));
		((Control)QuantityLbl).set_TabIndex(21);
		QuantityLbl.set_Text("Quantity :");
		QuantityLbl.set_TextAlign((ContentAlignment)32);
		BloodGrpCombo.set_BackColor(SystemColors.ButtonHighlight);
		BloodGrpCombo.set_DropDownStyle((ComboBoxStyle)2);
		((Control)BloodGrpCombo).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)BloodGrpCombo).set_FormattingEnabled(true);
		BloodGrpCombo.get_Items().AddRange(new object[9] { "--Select--", "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
		((Control)BloodGrpCombo).set_Location(new Point(186, 213));
		((Control)BloodGrpCombo).set_Name("BloodGrpCombo");
		((Control)BloodGrpCombo).set_Size(new Size(129, 26));
		((Control)BloodGrpCombo).set_TabIndex(20);
		BloodGrpLbl.set_AutoSize(true);
		((Control)BloodGrpLbl).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)BloodGrpLbl).set_Location(new Point(33, 216));
		((Control)BloodGrpLbl).set_Name("BloodGrpLbl");
		((Control)BloodGrpLbl).set_Size(new Size(114, 18));
		((Control)BloodGrpLbl).set_TabIndex(19);
		BloodGrpLbl.set_Text("Blood Group :");
		BloodGrpLbl.set_TextAlign((ContentAlignment)32);
		((Control)DateTxt).set_Location(new Point(205, 382));
		((Control)DateTxt).set_Name("DateTxt");
		((TextBoxBase)DateTxt).set_ReadOnly(true);
		((Control)DateTxt).set_Size(new Size(167, 29));
		((Control)DateTxt).set_TabIndex(16);
		DateLbl.set_AutoSize(true);
		((Control)DateLbl).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)DateLbl).set_Location(new Point(33, 389));
		((Control)DateLbl).set_Name("DateLbl");
		((Control)DateLbl).set_Size(new Size(138, 18));
		((Control)DateLbl).set_TabIndex(15);
		DateLbl.set_Text("Recieptant Date :");
		DateLbl.set_TextAlign((ContentAlignment)32);
		GenderTxt.set_DropDownStyle((ComboBoxStyle)2);
		((Control)GenderTxt).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)GenderTxt).set_FormattingEnabled(true);
		GenderTxt.get_Items().AddRange(new object[3] { "MALE", "FEMALE", "OTHERS" });
		((Control)GenderTxt).set_Location(new Point(135, 327));
		((Control)GenderTxt).set_Name("GenderTxt");
		((Control)GenderTxt).set_Size(new Size(124, 27));
		((Control)GenderTxt).set_TabIndex(14);
		AgeLbl.set_AutoSize(true);
		((Control)AgeLbl).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)AgeLbl).set_Location(new Point(33, 109));
		((Control)AgeLbl).set_Name("AgeLbl");
		((Control)AgeLbl).set_Size(new Size(46, 18));
		((Control)AgeLbl).set_TabIndex(13);
		AgeLbl.set_Text("Age :");
		AgeLbl.set_TextAlign((ContentAlignment)32);
		((Control)AgeTxt).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)AgeTxt).set_Location(new Point(135, 109));
		((Control)AgeTxt).set_Name("AgeTxt");
		((Control)AgeTxt).set_Size(new Size(124, 24));
		((Control)AgeTxt).set_TabIndex(10);
		MobileLbl.set_AutoSize(true);
		((Control)MobileLbl).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)MobileLbl).set_Location(new Point(33, 163));
		((Control)MobileLbl).set_Name("MobileLbl");
		((Control)MobileLbl).set_Size(new Size(68, 18));
		((Control)MobileLbl).set_TabIndex(8);
		MobileLbl.set_Text("Mobile :");
		MobileLbl.set_TextAlign((ContentAlignment)32);
		GenderLbl.set_AutoSize(true);
		((Control)GenderLbl).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)GenderLbl).set_Location(new Point(33, 330));
		((Control)GenderLbl).set_Name("GenderLbl");
		((Control)GenderLbl).set_Size(new Size(73, 18));
		((Control)GenderLbl).set_TabIndex(6);
		GenderLbl.set_Text("Gender :");
		GenderLbl.set_TextAlign((ContentAlignment)32);
		NameLbl.set_AutoSize(true);
		((Control)NameLbl).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)NameLbl).set_Location(new Point(33, 58));
		((Control)NameLbl).set_Name("NameLbl");
		((Control)NameLbl).set_Size(new Size(62, 18));
		((Control)NameLbl).set_TabIndex(5);
		NameLbl.set_Text("Name :");
		NameLbl.set_TextAlign((ContentAlignment)32);
		((Control)MobileTxt).set_Location(new Point(135, 156));
		((Control)MobileTxt).set_Name("MobileTxt");
		((Control)MobileTxt).set_Size(new Size(190, 29));
		((Control)MobileTxt).set_TabIndex(2);
		((Control)NameTxt).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)NameTxt).set_Location(new Point(135, 55));
		((Control)NameTxt).set_Name("NameTxt");
		((Control)NameTxt).set_Size(new Size(355, 24));
		((Control)NameTxt).set_TabIndex(0);
		((ButtonBase)AddReceiptantBtn).set_BackColor(Color.MidnightBlue);
		((Control)AddReceiptantBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)AddReceiptantBtn).set_ForeColor(Color.White);
		((Control)AddReceiptantBtn).set_Location(new Point(587, 674));
		((Control)AddReceiptantBtn).set_Name("AddReceiptantBtn");
		((Control)AddReceiptantBtn).set_Size(new Size(148, 51));
		((Control)AddReceiptantBtn).set_TabIndex(13);
		((ButtonBase)AddReceiptantBtn).set_Text("Add Recieptant");
		((ButtonBase)AddReceiptantBtn).set_UseVisualStyleBackColor(false);
		((ButtonBase)ClearBtn).set_BackColor(Color.MidnightBlue);
		((Control)ClearBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)ClearBtn).set_ForeColor(Color.White);
		((Control)ClearBtn).set_Location(new Point(420, 674));
		((Control)ClearBtn).set_Name("ClearBtn");
		((Control)ClearBtn).set_Size(new Size(148, 51));
		((Control)ClearBtn).set_TabIndex(14);
		((ButtonBase)ClearBtn).set_Text("Clear");
		((ButtonBase)ClearBtn).set_UseVisualStyleBackColor(false);
		Timer1.set_Enabled(true);
		Timer1.set_Interval(1500);
		((Control)SuccessMsg).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)SuccessMsg).set_Location(new Point(311, 166));
		((Control)SuccessMsg).set_Name("SuccessMsg");
		((Control)SuccessMsg).set_Size(new Size(339, 45));
		((Control)SuccessMsg).set_TabIndex(15);
		SuccessMsg.set_Text("Name :");
		SuccessMsg.set_TextAlign((ContentAlignment)32);
		((Control)SuccessMsg).set_Visible(false);
		PictureBox1.set_Image((Image)(object)Resources.images);
		((Control)PictureBox1).set_Location(new Point(215, 26));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(171, 126));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(9);
		PictureBox1.set_TabStop(false);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("MS Reference Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.Red);
		((Control)Label1).set_Location(new Point(240, 268));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(84, 18));
		((Control)Label1).set_TabIndex(23);
		Label1.set_Text("(In litres)");
		Label1.set_TextAlign((ContentAlignment)32);
		((Control)Label1).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Control)this).get_Controls().Add((Control)(object)SuccessMsg);
		((Control)this).get_Controls().Add((Control)(object)ClearBtn);
		((Control)this).get_Controls().Add((Control)(object)AddReceiptantBtn);
		((Control)this).get_Controls().Add((Control)(object)RecieverInfoGrp);
		((Control)this).get_Controls().Add((Control)(object)RegisterLbl);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).set_Name("RegisterReciever");
		((Control)this).set_Size(new Size(977, 804));
		((Control)RecieverInfoGrp).ResumeLayout(false);
		((Control)RecieverInfoGrp).PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void RegisterReciever_Load(object sender, EventArgs e)
	{
		myconnection.set_ConnectionString(MyProject.Forms.Form1.provider + MyProject.Forms.Form1.datafile);
		DateTxt.set_Text(DateTime.Today.ToShortDateString());
		BloodGrpCombo.set_SelectedIndex(0);
	}

	private void AddReceiptantBtn_Click(object sender, EventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		if (Validate_data())
		{
			string text = "Insert Into [Recievers] ([Name],[Age],[Gender],[Blood Group],[Contact Number],[Blood Recieved],[Date of Recieve]) Values (?,?,?,?,?,?,?)";
			myconnection.Open();
			try
			{
				OleDbCommand val = new OleDbCommand(text, myconnection);
				val.get_Parameters().Add(new OleDbParameter("Name", (object)NameTxt.get_Text().ToLower()));
				val.get_Parameters().Add(new OleDbParameter("Age", (object)(int)Convert.ToInt16(AgeTxt.get_Text())));
				val.get_Parameters().Add(new OleDbParameter("Gender", (object)GenderTxt.get_Text().ToLower()));
				val.get_Parameters().Add(new OleDbParameter("Blood Group", (object)BloodGrpCombo.get_Text()));
				val.get_Parameters().Add(new OleDbParameter("Contact Number", (object)MobileTxt.get_Text().ToString()));
				val.get_Parameters().Add(new OleDbParameter("Blood Recieved", (object)QuantityTxt.get_Text()));
				val.get_Parameters().Add(new OleDbParameter("Date of Recieve", (object)DateTxt.get_Text()));
				val.ExecuteNonQuery();
				((Component)(object)val).Dispose();
				myconnection.Close();
				((Control)SuccessMsg).set_Visible(true);
				SuccessMsg.set_Text("Reciever Successfully Registered !!");
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
		if (BloodGrpCombo.get_SelectedIndex() == 0)
		{
			((Control)SuccessMsg).set_Visible(true);
			SuccessMsg.set_Text("Select Proper Blood Group");
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
		DateTxt.set_Text(Strings.Format((object)DateTime.Now, "dd-MM-yyyy"));
		((TextBoxBase)QuantityTxt).Clear();
		((TextBoxBase)MobileTxt).Clear();
		GenderTxt.set_SelectedIndex(-1);
		BloodGrpCombo.set_SelectedIndex(0);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		((Control)SuccessMsg).set_Visible(false);
		Timer1.Stop();
	}
}
