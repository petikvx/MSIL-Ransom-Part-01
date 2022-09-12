using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using j3Y9Xo;

namespace Sq4;

[DesignerGenerated]
public class Zd7 : Form
{
	private IContainer components;

	private GroupBox _GroupBox1;

	private Label _Label3;

	private Label _Label4;

	private DateTimePicker _DateTimePicker1;

	private DateTimePicker _DateTimePicker2;

	private Button _Button2;

	private DataGridView _DataGridView1;

	private Panel _Panel1;

	[AccessedThroughProperty("btnExportExcel")]
	private Button _btnExportExcel;

	private Button _btnReset;

	private GroupBox _GroupBox2;

	private TextBox _txtStudentName;

	private GroupBox _GroupBox3;

	private Label _Label6;

	private Label _Label5;

	private Button _Button7;

	private ComboBox _cmbYear;

	private ComboBox _cmbCourse;

	private GroupBox _GroupBox4;

	private TextBox _txtProjectTitle;

	private OleDbDataReader rdr;

	private DataTable dtable;

	private OleDbConnection con;

	private OleDbDataAdapter adp;

	private DataSet ds;

	private OleDbCommand cmd;

	private DataTable dt;

	private string cs;

	public virtual Button btnExportExcel
	{
		get
		{
			return _btnExportExcel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Rt3;
			Button val = _btnExportExcel;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnExportExcel = value;
			val = _btnExportExcel;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	public Zd7()
	{
		((Form)this).add_Load((EventHandler)Bo0);
		rdr = null;
		con = null;
		cmd = null;
		dt = new DataTable();
		cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\LMS_DB.accdb;Persist Security Info=False;";
		Bo3();
	}

	protected override void Cn2(bool o8Y)
	{
		try
		{
			if (o8Y && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(o8Y);
		}
	}

	private void Bo3()
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
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected O, but got Unknown
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Expected O, but got Unknown
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected O, but got Unknown
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Expected O, but got Unknown
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Unknown result type (might be due to invalid IL or missing references)
		//IL_0732: Expected O, but got Unknown
		//IL_0750: Unknown result type (might be due to invalid IL or missing references)
		//IL_0819: Unknown result type (might be due to invalid IL or missing references)
		//IL_083d: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b0: Expected O, but got Unknown
		//IL_0927: Unknown result type (might be due to invalid IL or missing references)
		//IL_0931: Expected O, but got Unknown
		//IL_0999: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a3: Expected O, but got Unknown
		//IL_0b2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb5: Expected O, but got Unknown
		//IL_0bd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cca: Expected O, but got Unknown
		//IL_0cdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce7: Expected O, but got Unknown
		//IL_0cec: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Zd7));
		Em4(new GroupBox());
		Zb6(new Label());
		w5T(new Label());
		Kp1(new DateTimePicker());
		f3T(new DateTimePicker());
		w5J(new Button());
		i9W(new DataGridView());
		j3S(new Panel());
		btnExportExcel = new Button();
		w0F(new Button());
		w4Z(new GroupBox());
		s5J(new TextBox());
		s5C(new GroupBox());
		Ap5(new Label());
		w9E(new Label());
		Mr3(new Button());
		n3E(new ComboBox());
		Dn6(new ComboBox());
		Xp9(new GroupBox());
		c8Y(new TextBox());
		((Control)Qd6()).SuspendLayout();
		((ISupportInitialize)s7B()).BeginInit();
		((Control)Mq2()).SuspendLayout();
		((Control)Sx0()).SuspendLayout();
		((Control)o5F()).SuspendLayout();
		((Control)f2Y()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Qd6()).get_Controls().Add((Control)(object)Hj2());
		((Control)Qd6()).get_Controls().Add((Control)(object)f5E());
		((Control)Qd6()).get_Controls().Add((Control)(object)Na6());
		((Control)Qd6()).get_Controls().Add((Control)(object)Hp7());
		((Control)Qd6()).get_Controls().Add((Control)(object)d0Y());
		((Control)Qd6()).set_Location(new Point(300, 109));
		((Control)Qd6()).set_Margin(new Padding(3, 4, 3, 4));
		((Control)Qd6()).set_Name("GroupBox1");
		((Control)Qd6()).set_Padding(new Padding(3, 4, 3, 4));
		((Control)Qd6()).set_Size(new Size(399, 88));
		((Control)Qd6()).set_TabIndex(6);
		Qd6().set_TabStop(false);
		Qd6().set_Text("By Submission Date");
		Hj2().set_AutoSize(true);
		((Control)Hj2()).set_Font(new Font("Palatino Linotype", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Hj2()).set_Location(new Point(172, 17));
		((Control)Hj2()).set_Name("Label3");
		((Control)Hj2()).set_Size(new Size(22, 16));
		((Control)Hj2()).set_TabIndex(33);
		Hj2().set_Text("To");
		f5E().set_AutoSize(true);
		((Control)f5E()).set_Font(new Font("Palatino Linotype", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)f5E()).set_Location(new Point(24, 19));
		((Control)f5E()).set_Name("Label4");
		((Control)f5E()).set_Size(new Size(33, 16));
		((Control)f5E()).set_TabIndex(6);
		f5E().set_Text("From");
		Na6().set_CustomFormat("dd/MMM/yyyy");
		Na6().set_Format((DateTimePickerFormat)8);
		((Control)Na6()).set_Location(new Point(175, 38));
		((Control)Na6()).set_Name("DateTimePicker1");
		((Control)Na6()).set_Size(new Size(123, 24));
		((Control)Na6()).set_TabIndex(5);
		Hp7().set_CustomFormat("dd/MMM/yyyy");
		Hp7().set_Format((DateTimePickerFormat)8);
		((Control)Hp7()).set_Location(new Point(24, 38));
		((Control)Hp7()).set_Name("DateTimePicker2");
		((Control)Hp7()).set_Size(new Size(131, 24));
		((Control)Hp7()).set_TabIndex(4);
		((Control)d0Y()).set_Font(new Font("Palatino Linotype", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)d0Y()).set_Location(new Point(313, 35));
		((Control)d0Y()).set_Name("Button2");
		((Control)d0Y()).set_Size(new Size(69, 25));
		((Control)d0Y()).set_TabIndex(3);
		((ButtonBase)d0Y()).set_Text("&Search");
		((ButtonBase)d0Y()).set_UseVisualStyleBackColor(true);
		s7B().set_BackgroundColor(SystemColors.ActiveBorder);
		s7B().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)s7B()).set_Location(new Point(16, 215));
		((Control)s7B()).set_Name("DataGridView1");
		s7B().set_ReadOnly(true);
		s7B().set_ScrollBars((ScrollBars)2);
		((Control)s7B()).set_Size(new Size(751, 440));
		((Control)s7B()).set_TabIndex(33);
		Mq2().set_BorderStyle((BorderStyle)1);
		((Control)Mq2()).get_Controls().Add((Control)(object)btnExportExcel);
		((Control)Mq2()).get_Controls().Add((Control)(object)Jx7());
		((Control)Mq2()).set_Location(new Point(777, 215));
		((Control)Mq2()).set_Name("Panel1");
		((Control)Mq2()).set_Size(new Size(124, 106));
		((Control)Mq2()).set_TabIndex(34);
		((Control)btnExportExcel).set_Font(new Font("Palatino Linotype", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnExportExcel).set_Location(new Point(15, 54));
		((Control)btnExportExcel).set_Name("btnExportExcel");
		((Control)btnExportExcel).set_Size(new Size(93, 36));
		((Control)btnExportExcel).set_TabIndex(1);
		((ButtonBase)btnExportExcel).set_Text("&Export Excel");
		((ButtonBase)btnExportExcel).set_UseVisualStyleBackColor(true);
		((Control)Jx7()).set_Font(new Font("Palatino Linotype", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Jx7()).set_Location(new Point(15, 15));
		((Control)Jx7()).set_Name("btnReset");
		((Control)Jx7()).set_Size(new Size(93, 33));
		((Control)Jx7()).set_TabIndex(0);
		((ButtonBase)Jx7()).set_Text("&Reset");
		((ButtonBase)Jx7()).set_UseVisualStyleBackColor(true);
		((Control)Sx0()).get_Controls().Add((Control)(object)w3Q());
		((Control)Sx0()).set_Location(new Point(16, 108));
		((Control)Sx0()).set_Margin(new Padding(3, 4, 3, 4));
		((Control)Sx0()).set_Name("GroupBox2");
		((Control)Sx0()).set_Padding(new Padding(3, 4, 3, 4));
		((Control)Sx0()).set_Size(new Size(269, 88));
		((Control)Sx0()).set_TabIndex(35);
		Sx0().set_TabStop(false);
		Sx0().set_Text("By Student Name(s)");
		((Control)w3Q()).set_Font(new Font("Palatino Linotype", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)w3Q()).set_Location(new Point(19, 37));
		((Control)w3Q()).set_Margin(new Padding(3, 4, 3, 4));
		((Control)w3Q()).set_Name("txtStudentName");
		((Control)w3Q()).set_Size(new Size(222, 24));
		((Control)w3Q()).set_TabIndex(0);
		((Control)o5F()).get_Controls().Add((Control)(object)m6H());
		((Control)o5F()).get_Controls().Add((Control)(object)As7());
		((Control)o5F()).get_Controls().Add((Control)(object)Pm1());
		((Control)o5F()).get_Controls().Add((Control)(object)c6A());
		((Control)o5F()).get_Controls().Add((Control)(object)Qt4());
		((Control)o5F()).set_Location(new Point(20, 12));
		((Control)o5F()).set_Margin(new Padding(3, 4, 3, 4));
		((Control)o5F()).set_Name("GroupBox3");
		((Control)o5F()).set_Padding(new Padding(3, 4, 3, 4));
		((Control)o5F()).set_Size(new Size(382, 88));
		((Control)o5F()).set_TabIndex(36);
		o5F().set_TabStop(false);
		o5F().set_Text("By Course Name and Year");
		m6H().set_AutoSize(true);
		((Control)m6H()).set_Font(new Font("Palatino Linotype", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)m6H()).set_Location(new Point(201, 17));
		((Control)m6H()).set_Name("Label6");
		((Control)m6H()).set_Size(new Size(30, 16));
		((Control)m6H()).set_TabIndex(41);
		m6H().set_Text("Year");
		As7().set_AutoSize(true);
		((Control)As7()).set_Font(new Font("Palatino Linotype", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)As7()).set_Location(new Point(16, 17));
		((Control)As7()).set_Name("Label5");
		((Control)As7()).set_Size(new Size(43, 16));
		((Control)As7()).set_TabIndex(40);
		As7().set_Text("Course");
		((Control)Pm1()).set_Font(new Font("Palatino Linotype", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Pm1()).set_Location(new Point(295, 36));
		((Control)Pm1()).set_Name("Button7");
		((Control)Pm1()).set_Size(new Size(69, 25));
		((Control)Pm1()).set_TabIndex(39);
		((ButtonBase)Pm1()).set_Text("&Search");
		((ButtonBase)Pm1()).set_UseVisualStyleBackColor(true);
		c6A().set_AutoCompleteMode((AutoCompleteMode)2);
		c6A().set_AutoCompleteSource((AutoCompleteSource)256);
		((Control)c6A()).set_Enabled(false);
		((ListControl)c6A()).set_FormattingEnabled(true);
		((Control)c6A()).set_Location(new Point(203, 36));
		((Control)c6A()).set_Name("cmbYear");
		((Control)c6A()).set_Size(new Size(83, 25));
		((Control)c6A()).set_TabIndex(38);
		Qt4().set_AutoCompleteMode((AutoCompleteMode)1);
		Qt4().set_AutoCompleteSource((AutoCompleteSource)256);
		((ListControl)Qt4()).set_FormattingEnabled(true);
		((Control)Qt4()).set_Location(new Point(19, 36));
		((Control)Qt4()).set_Name("cmbCourse");
		((Control)Qt4()).set_Size(new Size(177, 25));
		((Control)Qt4()).set_TabIndex(37);
		((Control)f2Y()).get_Controls().Add((Control)(object)j3Q());
		((Control)f2Y()).set_Location(new Point(413, 13));
		((Control)f2Y()).set_Margin(new Padding(3, 4, 3, 4));
		((Control)f2Y()).set_Name("GroupBox4");
		((Control)f2Y()).set_Padding(new Padding(3, 4, 3, 4));
		((Control)f2Y()).set_Size(new Size(269, 88));
		((Control)f2Y()).set_TabIndex(37);
		f2Y().set_TabStop(false);
		f2Y().set_Text("By Project Title");
		((Control)j3Q()).set_Font(new Font("Palatino Linotype", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)j3Q()).set_Location(new Point(19, 37));
		((Control)j3Q()).set_Margin(new Padding(3, 4, 3, 4));
		((Control)j3Q()).set_Name("txtProjectTitle");
		((Control)j3Q()).set_Size(new Size(222, 24));
		((Control)j3Q()).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 17f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ButtonHighlight);
		((Form)this).set_ClientSize(new Size(918, 656));
		((Control)this).get_Controls().Add((Control)(object)f2Y());
		((Control)this).get_Controls().Add((Control)(object)o5F());
		((Control)this).get_Controls().Add((Control)(object)Sx0());
		((Control)this).get_Controls().Add((Control)(object)Mq2());
		((Control)this).get_Controls().Add((Control)(object)s7B());
		((Control)this).get_Controls().Add((Control)(object)Qd6());
		((Control)this).set_Font(new Font("Palatino Linotype", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(3, 4, 3, 4));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("frmProjectRecord");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Search Projects Record");
		((Control)Qd6()).ResumeLayout(false);
		((Control)Qd6()).PerformLayout();
		((ISupportInitialize)s7B()).EndInit();
		((Control)Mq2()).ResumeLayout(false);
		((Control)Sx0()).ResumeLayout(false);
		((Control)Sx0()).PerformLayout();
		((Control)o5F()).ResumeLayout(false);
		((Control)o5F()).PerformLayout();
		((Control)f2Y()).ResumeLayout(false);
		((Control)f2Y()).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual GroupBox Qd6()
	{
		return _GroupBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Em4(GroupBox e5L)
	{
		_GroupBox1 = e5L;
	}

	[SpecialName]
	internal virtual Label Hj2()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zb6(Label Yo6)
	{
		_Label3 = Yo6;
	}

	[SpecialName]
	internal virtual Label f5E()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w5T(Label Nz7)
	{
		_Label4 = Nz7;
	}

	[SpecialName]
	internal virtual DateTimePicker Na6()
	{
		return _DateTimePicker1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kp1(DateTimePicker a7T)
	{
		CancelEventHandler cancelEventHandler = g8H;
		DateTimePicker dateTimePicker = _DateTimePicker1;
		if (dateTimePicker != null)
		{
			((Control)dateTimePicker).remove_Validating(cancelEventHandler);
		}
		_DateTimePicker1 = a7T;
		dateTimePicker = _DateTimePicker1;
		if (dateTimePicker != null)
		{
			((Control)dateTimePicker).add_Validating(cancelEventHandler);
		}
	}

	[SpecialName]
	internal virtual DateTimePicker Hp7()
	{
		return _DateTimePicker2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f3T(DateTimePicker g9F)
	{
		_DateTimePicker2 = g9F;
	}

	[SpecialName]
	private virtual Button d0Y()
	{
		return _Button2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void w5J(Button Sq9)
	{
		EventHandler eventHandler = z4Y;
		Button button = _Button2;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button2 = Sq9;
		button = _Button2;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual DataGridView s7B()
	{
		return _DataGridView1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i9W(DataGridView Qm9)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		DataGridViewCellMouseEventHandler val = new DataGridViewCellMouseEventHandler(d0Z);
		DataGridViewRowPostPaintEventHandler val2 = new DataGridViewRowPostPaintEventHandler(r3J);
		DataGridView dataGridView = _DataGridView1;
		if (dataGridView != null)
		{
			dataGridView.remove_RowHeaderMouseClick(val);
			dataGridView.remove_RowPostPaint(val2);
		}
		_DataGridView1 = Qm9;
		dataGridView = _DataGridView1;
		if (dataGridView != null)
		{
			dataGridView.add_RowHeaderMouseClick(val);
			dataGridView.add_RowPostPaint(val2);
		}
	}

	[SpecialName]
	internal virtual Panel Mq2()
	{
		return _Panel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j3S(Panel r2K)
	{
		_Panel1 = r2K;
	}

	[SpecialName]
	private virtual Button Jx7()
	{
		return _btnReset;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void w0F(Button Nk6)
	{
		EventHandler eventHandler = a7B;
		Button btnReset = _btnReset;
		if (btnReset != null)
		{
			((Control)btnReset).remove_Click(eventHandler);
		}
		_btnReset = Nk6;
		btnReset = _btnReset;
		if (btnReset != null)
		{
			((Control)btnReset).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual GroupBox Sx0()
	{
		return _GroupBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w4Z(GroupBox m7H)
	{
		_GroupBox2 = m7H;
	}

	[SpecialName]
	internal virtual TextBox w3Q()
	{
		return _txtStudentName;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s5J(TextBox Cj9)
	{
		EventHandler eventHandler = n9F;
		TextBox txtStudentName = _txtStudentName;
		if (txtStudentName != null)
		{
			((Control)txtStudentName).remove_TextChanged(eventHandler);
		}
		_txtStudentName = Cj9;
		txtStudentName = _txtStudentName;
		if (txtStudentName != null)
		{
			((Control)txtStudentName).add_TextChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual GroupBox o5F()
	{
		return _GroupBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s5C(GroupBox Gp0)
	{
		_GroupBox3 = Gp0;
	}

	[SpecialName]
	internal virtual Label m6H()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ap5(Label e4M)
	{
		_Label6 = e4M;
	}

	[SpecialName]
	internal virtual Label As7()
	{
		return _Label5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w9E(Label p8B)
	{
		_Label5 = p8B;
	}

	[SpecialName]
	private virtual Button Pm1()
	{
		return _Button7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void Mr3(Button e7G)
	{
		EventHandler eventHandler = j8E;
		Button button = _Button7;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button7 = e7G;
		button = _Button7;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ComboBox c6A()
	{
		return _cmbYear;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n3E(ComboBox Sc1)
	{
		_cmbYear = Sc1;
	}

	[SpecialName]
	internal virtual ComboBox Qt4()
	{
		return _cmbCourse;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dn6(ComboBox j8N)
	{
		EventHandler eventHandler = Mk5;
		ComboBox cmbCourse = _cmbCourse;
		if (cmbCourse != null)
		{
			cmbCourse.remove_SelectedIndexChanged(eventHandler);
		}
		_cmbCourse = j8N;
		cmbCourse = _cmbCourse;
		if (cmbCourse != null)
		{
			cmbCourse.add_SelectedIndexChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual GroupBox f2Y()
	{
		return _GroupBox4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xp9(GroupBox Yb8)
	{
		_GroupBox4 = Yb8;
	}

	[SpecialName]
	internal virtual TextBox j3Q()
	{
		return _txtProjectTitle;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c8Y(TextBox Tp4)
	{
		EventHandler eventHandler = Ze6;
		TextBox txtProjectTitle = _txtProjectTitle;
		if (txtProjectTitle != null)
		{
			((Control)txtProjectTitle).remove_TextChanged(eventHandler);
		}
		_txtProjectTitle = Tp4;
		txtProjectTitle = _txtProjectTitle;
		if (txtProjectTitle != null)
		{
			((Control)txtProjectTitle).add_TextChanged(eventHandler);
		}
	}

	public void i9D()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			OleDbConnection val = new OleDbConnection(cs);
			val.Open();
			adp = new OleDbDataAdapter();
			adp.set_SelectCommand(new OleDbCommand("SELECT distinct RTRIM(Course) FROM Project", val));
			ds = new DataSet("ds");
			((DbDataAdapter)(object)adp).Fill(ds);
			dtable = ds.Tables[0];
			Qt4().get_Items().Clear();
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = dtable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					Qt4().get_Items().Add((object)dataRow[0].ToString());
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message, "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			ProjectData.ClearProjectError();
		}
	}

	private void z4Y(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			con = new OleDbConnection(cs);
			con.Open();
			cmd = new OleDbCommand("SELECT ID,ProjectName as [Project Name], StudentName as [Student Name], Course, Proj_year as [Course Year], SubmissionDate as [Submission Date], Remarks from project where SubmissionDate between #" + Hp7().get_Text() + "# and #" + Na6().get_Text() + "#  order by SubmissionDate desc", con);
			OleDbDataAdapter val = new OleDbDataAdapter(cmd);
			DataSet dataSet = new DataSet();
			((DbDataAdapter)(object)val).Fill(dataSet, "Project");
			s7B().set_DataSource((object)dataSet.Tables["Project"]!.DefaultView);
			con.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message, "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			ProjectData.ClearProjectError();
		}
	}

	private void Rt3(object sender, EventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		if (s7B().get_RowCount() == 0)
		{
			MessageBox.Show("Sorry nothing to export into excel sheet..\r\nPlease retrieve data in datagridview", "", (MessageBoxButtons)0, (MessageBoxIcon)16);
			return;
		}
		Cursor.set_Current(Cursors.get_WaitCursor());
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		checked
		{
			try
			{
				NewLateBinding.LateSet(objectValue, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
				short num = (short)(s7B().get_RowCount() - 1);
				short num2 = (short)(((BaseCollection)s7B().get_Columns()).get_Count() - 1);
				object obj = default(object);
				object obj2 = obj;
				NewLateBinding.LateCall(NewLateBinding.LateGet(obj2, (Type)null, "Cells", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Select", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(obj2, (Type)null, "Cells", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Delete", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				short num3 = num2;
				for (short num4 = 0; num4 <= num3; num4 = (short)unchecked(num4 + 1))
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj2, (Type)null, "Cells", new object[2]
					{
						1,
						num4 + 1
					}, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[1] { s7B().get_Columns().get_Item(unchecked((int)num4)).get_HeaderText() }, (string[])null, (Type[])null, false, true);
				}
				short num5 = (short)(num - 1);
				for (short num6 = 0; num6 <= num5; num6 = (short)unchecked(num6 + 1))
				{
					short num7 = num2;
					for (short num8 = 0; num8 <= num7; num8 = (short)unchecked(num8 + 1))
					{
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj2, (Type)null, "Cells", new object[2]
						{
							num6 + 2,
							num8 + 1
						}, (string[])null, (Type[])null, (bool[])null), (Type)null, "value", new object[1] { unchecked(s7B().get_Rows().get_Item((int)num6).get_Cells()
							.get_Item((int)num8)).get_Value() }, (string[])null, (Type[])null, false, true);
					}
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj2, (Type)null, "Rows", new object[1] { "1:1" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FontStyle", new object[1] { "Bold" }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj2, (Type)null, "Rows", new object[1] { "1:1" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Size", new object[1] { 12 }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(obj2, (Type)null, "Cells", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AutoFit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(obj2, (Type)null, "Cells", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Select", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(obj2, (Type)null, "Cells", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "EntireColumn", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AutoFit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(obj2, (Type)null, "Cells", new object[2] { 1, 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Select", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				obj2 = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message, "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
				ProjectData.ClearProjectError();
			}
			finally
			{
				Cursor.set_Current(Cursors.get_Default());
				objectValue = null;
			}
		}
	}

	public void Rz1()
	{
		Qt4().set_Text("");
		c6A().set_Text("");
		j3Q().set_Text("");
		((Control)c6A()).set_Enabled(false);
		w3Q().set_Text("");
		Na6().set_Text(Conversions.ToString(DateAndTime.get_Today()));
		Hp7().set_Text(Conversions.ToString(DateAndTime.get_Today()));
		s7B().set_DataSource((object)null);
	}

	private void a7B(object sender, EventArgs e)
	{
		Rz1();
	}

	private void d0Z(object sender, DataGridViewCellMouseEventArgs e)
	{
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			DataGridViewRow val = s7B().get_SelectedRows().get_Item(0);
			((Control)this).Hide();
			((Control)Zc61Mq.Forms.z9Q2Nk()).Show();
			Zc61Mq.Forms.z9Q2Nk().Ln8().set_Text(val.get_Cells().get_Item(0).get_Value()
				.ToString());
			Zc61Mq.Forms.z9Q2Nk().k6Y().set_Text(val.get_Cells().get_Item(1).get_Value()
				.ToString());
			Zc61Mq.Forms.z9Q2Nk().Te4().set_Text(val.get_Cells().get_Item(2).get_Value()
				.ToString());
			Zc61Mq.Forms.z9Q2Nk().i4A().set_Text(val.get_Cells().get_Item(3).get_Value()
				.ToString());
			Zc61Mq.Forms.z9Q2Nk().e5P().set_Text(val.get_Cells().get_Item(4).get_Value()
				.ToString());
			Zc61Mq.Forms.z9Q2Nk().w0P().set_Text(val.get_Cells().get_Item(5).get_Value()
				.ToString());
			Zc61Mq.Forms.z9Q2Nk().s1A().set_Text(val.get_Cells().get_Item(6).get_Value()
				.ToString());
			((Control)Zc61Mq.Forms.z9Q2Nk().btnUpdate_record).set_Enabled(true);
			((Control)Zc61Mq.Forms.z9Q2Nk().btnDelete).set_Enabled(true);
			((Control)Zc61Mq.Forms.z9Q2Nk().btnSave).set_Enabled(false);
			((Control)Zc61Mq.Forms.z9Q2Nk().k6Y()).Focus();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message, "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			ProjectData.ClearProjectError();
		}
	}

	private void r3J(object sender, DataGridViewRowPostPaintEventArgs e)
	{
		checked
		{
			string text = (e.get_RowIndex() + 1).ToString();
			SizeF sizeF = e.get_Graphics().MeasureString(text, ((Control)this).get_Font());
			if (s7B().get_RowHeadersWidth() < Convert.ToInt32(sizeF.Width + 20f))
			{
				s7B().set_RowHeadersWidth(Convert.ToInt32(sizeF.Width + 20f));
			}
			Brush controlText = SystemBrushes.get_ControlText();
			e.get_Graphics().DrawString(text, ((Control)this).get_Font(), controlText, (float)(e.get_RowBounds().Location.X + 15), (float)e.get_RowBounds().Location.Y + ((float)e.get_RowBounds().Height - sizeF.Height) / 2f);
		}
	}

	private void n9F(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			con = new OleDbConnection(cs);
			con.Open();
			cmd = new OleDbCommand("SELECT ID,ProjectName as [Project Name], StudentName as [Student Name], Course, Proj_year as [Course Year], SubmissionDate as [Submission Date], Remarks from project where StudentName like '%" + w3Q().get_Text() + "%' order by StudentName", con);
			OleDbDataAdapter val = new OleDbDataAdapter(cmd);
			DataSet dataSet = new DataSet();
			((DbDataAdapter)(object)val).Fill(dataSet, "Project");
			s7B().set_DataSource((object)dataSet.Tables["Project"]!.DefaultView);
			con.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message, "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			ProjectData.ClearProjectError();
		}
	}

	private void j8E(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			con = new OleDbConnection(cs);
			con.Open();
			cmd = new OleDbCommand("SELECT ID,ProjectName as [Project Name], StudentName as [Student Name], Course, Proj_year as [Course Year], SubmissionDate as [Submission Date], Remarks from project where course='" + Qt4().get_Text() + "' and Proj_Year='" + c6A().get_Text() + "' order by ProjectName", con);
			OleDbDataAdapter val = new OleDbDataAdapter(cmd);
			DataSet dataSet = new DataSet();
			((DbDataAdapter)(object)val).Fill(dataSet, "Project");
			s7B().set_DataSource((object)dataSet.Tables["Project"]!.DefaultView);
			con.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message, "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			ProjectData.ClearProjectError();
		}
	}

	private void Mk5(object sender, EventArgs e)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Qt4().set_Text(Qt4().get_Text().Trim());
			c6A().get_Items().Clear();
			c6A().set_Text("");
			((Control)c6A()).set_Enabled(true);
			((Control)Qt4()).Focus();
			con = new OleDbConnection(cs);
			con.Open();
			string text = "select distinct RTRIM(Proj_Year) from Project where course = '" + Qt4().get_Text() + "'";
			cmd = new OleDbCommand(text);
			cmd.set_Connection(con);
			rdr = cmd.ExecuteReader();
			while (rdr.Read())
			{
				c6A().get_Items().Add(RuntimeHelpers.GetObjectValue(rdr.get_Item(0)));
			}
			con.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message, "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			ProjectData.ClearProjectError();
		}
	}

	private void g8H(object sender, CancelEventArgs e)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (DateTime.Compare(Hp7().get_Value().Date, Na6().get_Value().Date) > 0)
		{
			MessageBox.Show("Invalid Selection", "Input Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			((Control)Na6()).Focus();
		}
	}

	private void Bo0(object sender, EventArgs e)
	{
		i9D();
	}

	internal static void Yp3(object y7J)
	{
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)NewLateBinding.LateGet(y7J, (Type)null, "GetMethods", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
			while (enumerator.MoveNext())
			{
				object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
				try
				{
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"Method0", false))
					{
						((MethodInfo)objectValue).Invoke(null, new object[0]);
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	private void Ze6(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			con = new OleDbConnection(cs);
			con.Open();
			cmd = new OleDbCommand("SELECT ID,ProjectName as [Project Name], StudentName as [Student Name], Course, Proj_year as [Course Year], SubmissionDate as [Submission Date], Remarks from project where ProjectName like '" + j3Q().get_Text() + "%' order by Projectname", con);
			OleDbDataAdapter val = new OleDbDataAdapter(cmd);
			DataSet dataSet = new DataSet();
			((DbDataAdapter)(object)val).Fill(dataSet, "Project");
			s7B().set_DataSource((object)dataSet.Tables["Project"]!.DefaultView);
			con.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message, "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			ProjectData.ClearProjectError();
		}
	}
}
