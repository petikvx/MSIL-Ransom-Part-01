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
public class BloodAvailability : UserControl
{
	private IContainer components;

	private OleDbConnection myconnection;

	private string blood_group;

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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	[field: AccessedThroughProperty("AmountLbl")]
	internal virtual Label AmountLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ValueLbl")]
	internal virtual Label ValueLbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button DonorListBtn
	{
		[CompilerGenerated]
		get
		{
			return _DonorListBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button2_Click;
			Button donorListBtn = _DonorListBtn;
			if (donorListBtn != null)
			{
				((Control)donorListBtn).remove_Click(eventHandler);
			}
			_DonorListBtn = value;
			donorListBtn = _DonorListBtn;
			if (donorListBtn != null)
			{
				((Control)donorListBtn).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("SearchResultGrid")]
	internal virtual DataGridView SearchResultGrid
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SuccessMsg")]
	internal virtual Label SuccessMsg
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Timer1")]
	internal virtual Timer Timer1
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

	public BloodAvailability()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		((UserControl)this).add_Load((EventHandler)BloodAvailability_Load);
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
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected O, but got Unknown
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Expected O, but got Unknown
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected O, but got Unknown
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Expected O, but got Unknown
		//IL_0746: Unknown result type (might be due to invalid IL or missing references)
		//IL_0750: Expected O, but got Unknown
		components = new Container();
		Label1 = new Label();
		GroupBox1 = new GroupBox();
		SearchBtn = new Button();
		BloodGrpTxt = new ComboBox();
		Label2 = new Label();
		AmountLbl = new Label();
		ValueLbl = new Label();
		DonorListBtn = new Button();
		SearchResultGrid = new DataGridView();
		SuccessMsg = new Label();
		Timer1 = new Timer(components);
		UpdateBtn = new Button();
		PictureBox1 = new PictureBox();
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)SearchResultGrid).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Label1).set_Font(new Font("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(392, 63));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(330, 47));
		((Control)Label1).set_TabIndex(11);
		Label1.set_Text("Blood Availability");
		Label1.set_TextAlign((ContentAlignment)32);
		((Control)GroupBox1).get_Controls().Add((Control)(object)SearchBtn);
		((Control)GroupBox1).get_Controls().Add((Control)(object)BloodGrpTxt);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox1).set_Location(new Point(232, 214));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(490, 137));
		((Control)GroupBox1).set_TabIndex(12);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Search");
		((ButtonBase)SearchBtn).set_BackColor(Color.MidnightBlue);
		((Control)SearchBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)SearchBtn).set_ForeColor(Color.White);
		((Control)SearchBtn).set_Location(new Point(183, 91));
		((Control)SearchBtn).set_Name("SearchBtn");
		((Control)SearchBtn).set_Size(new Size(102, 36));
		((Control)SearchBtn).set_TabIndex(22);
		((ButtonBase)SearchBtn).set_Text("Search");
		((ButtonBase)SearchBtn).set_UseVisualStyleBackColor(false);
		BloodGrpTxt.set_DropDownStyle((ComboBoxStyle)2);
		((Control)BloodGrpTxt).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)BloodGrpTxt).set_FormattingEnabled(true);
		BloodGrpTxt.get_Items().AddRange(new object[9] { "--Select--", "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
		((Control)BloodGrpTxt).set_Location(new Point(246, 40));
		((Control)BloodGrpTxt).set_Name("BloodGrpTxt");
		((Control)BloodGrpTxt).set_Size(new Size(108, 26));
		((Control)BloodGrpTxt).set_TabIndex(21);
		((Control)Label2).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(87, 36));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(135, 32));
		((Control)Label2).set_TabIndex(0);
		Label2.set_Text("Blood Group :");
		Label2.set_TextAlign((ContentAlignment)32);
		((Control)AmountLbl).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)AmountLbl).set_Location(new Point(299, 369));
		((Control)AmountLbl).set_Name("AmountLbl");
		((Control)AmountLbl).set_Size(new Size(131, 35));
		((Control)AmountLbl).set_TabIndex(13);
		AmountLbl.set_Text("Amount :");
		AmountLbl.set_TextAlign((ContentAlignment)32);
		ValueLbl.set_AutoSize(true);
		((Control)ValueLbl).set_BackColor(Color.FromArgb(0, 192, 0));
		((Control)ValueLbl).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)ValueLbl).set_Location(new Point(436, 380));
		((Control)ValueLbl).set_Name("ValueLbl");
		((Control)ValueLbl).set_Size(new Size(64, 24));
		((Control)ValueLbl).set_TabIndex(14);
		ValueLbl.set_Text("litres");
		ValueLbl.set_TextAlign((ContentAlignment)32);
		((ButtonBase)DonorListBtn).set_BackColor(Color.MidnightBlue);
		((Control)DonorListBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)DonorListBtn).set_ForeColor(Color.White);
		((Control)DonorListBtn).set_Location(new Point(323, 434));
		((Control)DonorListBtn).set_Name("DonorListBtn");
		((Control)DonorListBtn).set_Size(new Size(221, 36));
		((Control)DonorListBtn).set_TabIndex(23);
		((ButtonBase)DonorListBtn).set_Text("See List of Donors");
		((ButtonBase)DonorListBtn).set_UseVisualStyleBackColor(false);
		SearchResultGrid.set_BackgroundColor(Color.White);
		SearchResultGrid.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)SearchResultGrid).set_Location(new Point(112, 494));
		((Control)SearchResultGrid).set_Name("SearchResultGrid");
		SearchResultGrid.set_ReadOnly(true);
		SearchResultGrid.get_RowTemplate().set_Height(24);
		((Control)SearchResultGrid).set_Size(new Size(739, 296));
		((Control)SearchResultGrid).set_TabIndex(24);
		((Control)SearchResultGrid).set_Visible(false);
		((Control)SuccessMsg).set_Font(new Font("MS Reference Sans Serif", 10.8f, (FontStyle)1));
		((Control)SuccessMsg).set_Location(new Point(281, 141));
		((Control)SuccessMsg).set_Name("SuccessMsg");
		((Control)SuccessMsg).set_Size(new Size(401, 44));
		((Control)SuccessMsg).set_TabIndex(28);
		SuccessMsg.set_Text("Label5");
		SuccessMsg.set_TextAlign((ContentAlignment)32);
		((Control)SuccessMsg).set_Visible(false);
		Timer1.set_Interval(1500);
		((ButtonBase)UpdateBtn).set_BackColor(Color.MidnightBlue);
		((Control)UpdateBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)UpdateBtn).set_ForeColor(Color.White);
		((Control)UpdateBtn).set_Location(new Point(735, 362));
		((Control)UpdateBtn).set_Name("UpdateBtn");
		((Control)UpdateBtn).set_Size(new Size(180, 52));
		((Control)UpdateBtn).set_TabIndex(29);
		((ButtonBase)UpdateBtn).set_Text("Update Blood Amount");
		((ButtonBase)UpdateBtn).set_UseVisualStyleBackColor(false);
		((Control)UpdateBtn).set_Visible(false);
		PictureBox1.set_Image((Image)(object)Resources.blood_goodpic);
		((Control)PictureBox1).set_Location(new Point(272, 25));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(114, 113));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(10);
		PictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Control)this).get_Controls().Add((Control)(object)UpdateBtn);
		((Control)this).get_Controls().Add((Control)(object)SuccessMsg);
		((Control)this).get_Controls().Add((Control)(object)SearchResultGrid);
		((Control)this).get_Controls().Add((Control)(object)DonorListBtn);
		((Control)this).get_Controls().Add((Control)(object)ValueLbl);
		((Control)this).get_Controls().Add((Control)(object)AmountLbl);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).set_Name("BloodAvailability");
		((Control)this).set_Size(new Size(977, 804));
		((Control)GroupBox1).ResumeLayout(false);
		((ISupportInitialize)SearchResultGrid).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void BloodAvailability_Load(object sender, EventArgs e)
	{
		myconnection.set_ConnectionString(MyProject.Forms.Form1.provider + MyProject.Forms.Form1.datafile);
		BloodGrpTxt.set_SelectedIndex(0);
		AmountLbl.set_Text("Amount :");
		((Control)AmountLbl).set_Visible(false);
		((Control)ValueLbl).set_Visible(false);
		((Control)DonorListBtn).set_Visible(false);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		((Control)SearchResultGrid).set_Visible(false);
		((Control)AmountLbl).set_Visible(false);
		((Control)ValueLbl).set_Visible(false);
		((Control)DonorListBtn).set_Visible(false);
		((Control)UpdateBtn).set_Visible(false);
		if (BloodGrpTxt.get_SelectedIndex() == 0)
		{
			((Control)SuccessMsg).set_Visible(true);
			SuccessMsg.set_Text("Select Blood Group");
			((Control)SuccessMsg).set_BackColor(Color.Red);
			Timer1.Start();
			return;
		}
		OleDbCommand val = new OleDbCommand();
		string text = "Select * From [Blood_available] Where [Blood Group] Like '%" + BloodGrpTxt.get_Text() + "%';";
		new DataTable();
		myconnection.Open();
		try
		{
			val = new OleDbCommand(text, myconnection);
			OleDbDataReader val2 = val.ExecuteReader();
			while (val2.Read())
			{
				MyProject.Forms.Form1.blood_available_id = Conversions.ToInteger(val2.get_Item(0));
				ValueLbl.set_Text(Conversions.ToString(Operators.AddObject(val2.get_Item(2), (object)" litres")));
			}
			myconnection.Close();
			decimal num = Convert.ToDecimal(ValueLbl.get_Text().Split(new char[1] { ' ' })[0]);
			MyProject.Forms.Form1.cur_blood_amount = num;
			if (decimal.Compare(num, 0m) == 0)
			{
				((Control)ValueLbl).set_BackColor(Color.Red);
			}
			else
			{
				((Control)ValueLbl).set_BackColor(Color.Green);
			}
			((Control)AmountLbl).set_Visible(true);
			((Control)ValueLbl).set_Visible(true);
			((Control)DonorListBtn).set_Visible(true);
			if (Operators.CompareString(MyProject.Forms.Form1.login_type.ToLower(), "admin", false) == 0)
			{
				((Control)UpdateBtn).set_Visible(true);
			}
			blood_group = BloodGrpTxt.get_Text();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			myconnection.Close();
			ProjectData.ClearProjectError();
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (BloodGrpTxt.get_SelectedIndex() == 0)
		{
			((Control)SuccessMsg).set_Visible(true);
			SuccessMsg.set_Text("Select Blood Group");
			((Control)SuccessMsg).set_BackColor(Color.Red);
			Timer1.Start();
			return;
		}
		new OleDbCommand();
		string text = "Select * From [Donor] Where [Blood] Like '%" + blood_group + "%';";
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
				HideUnusedColumns();
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

	private bool HideUnusedColumns()
	{
		int num = 3;
		do
		{
			SearchResultGrid.get_Columns().get_Item(num).set_Visible(false);
			num = checked(num + 1);
		}
		while (num <= 8);
		SearchResultGrid.get_Columns().get_Item(5).set_Visible(true);
		return true;
	}

	private void UpdateBtn_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.Form4).Show();
		((Control)AmountLbl).set_Visible(false);
		((Control)ValueLbl).set_Visible(false);
		((Control)UpdateBtn).set_Visible(false);
		((Control)SearchResultGrid).set_Visible(false);
		((Control)DonorListBtn).set_Visible(false);
	}
}
