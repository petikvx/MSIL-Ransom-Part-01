using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace w2L;

[DesignerGenerated]
public class w6A : Form
{
	private IContainer components;

	private GroupBox _GroupBox1;

	private ComboBox _cmbYear;

	private ComboBox _cmbCourse;

	private Label _Label4;

	private TextBox _txtStudentName;

	private Label _Label3;

	private DateTimePicker _dtpSubmissionDate;

	private Label _Label2;

	private TextBox _txtRemarks;

	private Label _Label11;

	private TextBox _txtProjectName;

	private Label _Label10;

	private Label _Label1;

	private Panel _panel1;

	[AccessedThroughProperty("btnGetDetails")]
	private Button _btnGetDetails;

	[AccessedThroughProperty("btnUpdate_record")]
	private Button _btnUpdate_record;

	[AccessedThroughProperty("btnDelete")]
	private Button _btnDelete;

	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	[AccessedThroughProperty("btnNewRecord")]
	private Button _btnNewRecord;

	private Button _Button1;

	private TextBox _txtID;

	private OleDbDataReader rdr;

	private DataTable dtable;

	private OleDbConnection con;

	private OleDbDataAdapter adp;

	private DataSet ds;

	private OleDbCommand cmd;

	private DataTable dt;

	private string cs;

	public virtual Button btnGetDetails
	{
		get
		{
			return _btnGetDetails;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Dw6;
			Button val = _btnGetDetails;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnGetDetails = value;
			val = _btnGetDetails;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	public virtual Button btnUpdate_record
	{
		get
		{
			return _btnUpdate_record;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Bt8;
			Button val = _btnUpdate_record;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnUpdate_record = value;
			val = _btnUpdate_record;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	public virtual Button btnDelete
	{
		get
		{
			return _btnDelete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = x1S;
			Button val = _btnDelete;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnDelete = value;
			val = _btnDelete;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	public virtual Button btnSave
	{
		get
		{
			return _btnSave;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = y2K;
			Button val = _btnSave;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnSave = value;
			val = _btnSave;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	public virtual Button btnNewRecord
	{
		get
		{
			return _btnNewRecord;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Af1;
			Button val = _btnNewRecord;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnNewRecord = value;
			val = _btnNewRecord;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	public w6A()
	{
		((Form)this).add_Load((EventHandler)Ld8);
		rdr = null;
		con = null;
		cmd = null;
		dt = new DataTable();
		cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\LMS_DB.accdb;Persist Security Info=False;";
		Lq3();
	}

	protected override void Da3(bool Qf9)
	{
		try
		{
			if (Qf9 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Qf9);
		}
	}

	private void Lq3()
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
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_0941: Unknown result type (might be due to invalid IL or missing references)
		//IL_094b: Expected O, but got Unknown
		//IL_09cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d7: Expected O, but got Unknown
		//IL_0a56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a60: Expected O, but got Unknown
		//IL_0ad3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0add: Expected O, but got Unknown
		//IL_0b50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5a: Expected O, but got Unknown
		//IL_0c86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c90: Expected O, but got Unknown
		//IL_0ca3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cad: Expected O, but got Unknown
		//IL_0caf: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(w6A));
		k3E(new GroupBox());
		w1T(new Button());
		Si0(new ComboBox());
		Ra9(new ComboBox());
		j6L(new Label());
		z5F(new TextBox());
		Rg8(new Label());
		Xs4(new DateTimePicker());
		c3W(new Label());
		a4S(new TextBox());
		Yi9(new Label());
		Gi5(new TextBox());
		Mz0(new Label());
		Mb4(new Label());
		r7H(new Panel());
		btnGetDetails = new Button();
		btnUpdate_record = new Button();
		btnDelete = new Button();
		btnSave = new Button();
		btnNewRecord = new Button();
		g4H(new TextBox());
		((Control)Qi5()).SuspendLayout();
		((Control)Cn1()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Qi5()).set_Anchor((AnchorStyles)15);
		((Control)Qi5()).set_BackColor(Color.Transparent);
		((Control)Qi5()).get_Controls().Add((Control)(object)m1B());
		((Control)Qi5()).get_Controls().Add((Control)(object)e5P());
		((Control)Qi5()).get_Controls().Add((Control)(object)i4A());
		((Control)Qi5()).get_Controls().Add((Control)(object)Ss0());
		((Control)Qi5()).get_Controls().Add((Control)(object)Te4());
		((Control)Qi5()).get_Controls().Add((Control)(object)c9E());
		((Control)Qi5()).get_Controls().Add((Control)(object)w0P());
		((Control)Qi5()).get_Controls().Add((Control)(object)e3G());
		((Control)Qi5()).get_Controls().Add((Control)(object)s1A());
		((Control)Qi5()).get_Controls().Add((Control)(object)Qx7());
		((Control)Qi5()).get_Controls().Add((Control)(object)k6Y());
		((Control)Qi5()).get_Controls().Add((Control)(object)Ly7());
		((Control)Qi5()).get_Controls().Add((Control)(object)e1C());
		((Control)Qi5()).set_Location(new Point(28, 24));
		((Control)Qi5()).set_Name("GroupBox1");
		((Control)Qi5()).set_Size(new Size(665, 310));
		((Control)Qi5()).set_TabIndex(0);
		Qi5().set_TabStop(false);
		Qi5().set_Text("Project");
		((Control)m1B()).set_Font(new Font("Palatino Linotype", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)m1B()).set_Location(new Point(601, 76));
		((Control)m1B()).set_Name("Button1");
		((Control)m1B()).set_Size(new Size(28, 23));
		((Control)m1B()).set_TabIndex(95);
		((ButtonBase)m1B()).set_Text(">");
		((ButtonBase)m1B()).set_UseVisualStyleBackColor(true);
		e5P().set_AutoCompleteMode((AutoCompleteMode)2);
		e5P().set_AutoCompleteSource((AutoCompleteSource)256);
		((Control)e5P()).set_Enabled(false);
		((ListControl)e5P()).set_FormattingEnabled(true);
		((Control)e5P()).set_Location(new Point(211, 143));
		((Control)e5P()).set_Name("cmbYear");
		((Control)e5P()).set_Size(new Size(121, 26));
		((Control)e5P()).set_TabIndex(3);
		i4A().set_AutoCompleteMode((AutoCompleteMode)1);
		i4A().set_AutoCompleteSource((AutoCompleteSource)256);
		((ListControl)i4A()).set_FormattingEnabled(true);
		((Control)i4A()).set_Location(new Point(211, 109));
		((Control)i4A()).set_Name("cmbCourse");
		((Control)i4A()).set_Size(new Size(173, 26));
		((Control)i4A()).set_TabIndex(2);
		Ss0().set_AutoSize(true);
		((Control)Ss0()).set_BackColor(Color.Transparent);
		((Control)Ss0()).set_Location(new Point(33, 113));
		((Control)Ss0()).set_Name("Label4");
		((Control)Ss0()).set_Size(new Size(51, 18));
		((Control)Ss0()).set_TabIndex(91);
		Ss0().set_Text("Course");
		((Control)Te4()).set_Location(new Point(211, 74));
		Te4().set_Multiline(true);
		((Control)Te4()).set_Name("txtStudentName");
		((TextBoxBase)Te4()).set_ReadOnly(true);
		Te4().set_ScrollBars((ScrollBars)3);
		((Control)Te4()).set_Size(new Size(384, 28));
		((Control)Te4()).set_TabIndex(1);
		c9E().set_AutoSize(true);
		((Control)c9E()).set_BackColor(Color.Transparent);
		((Control)c9E()).set_Location(new Point(33, 79));
		((Control)c9E()).set_Name("Label3");
		((Control)c9E()).set_Size(new Size(112, 18));
		((Control)c9E()).set_TabIndex(86);
		c9E().set_Text("Student Name (s)");
		w0P().set_CustomFormat("dd/MMM/yyyy");
		w0P().set_Format((DateTimePickerFormat)8);
		((Control)w0P()).set_Location(new Point(211, 180));
		((Control)w0P()).set_Name("dtpSubmissionDate");
		((Control)w0P()).set_Size(new Size(136, 25));
		((Control)w0P()).set_TabIndex(4);
		e3G().set_AutoSize(true);
		((Control)e3G()).set_BackColor(Color.Transparent);
		((Control)e3G()).set_Location(new Point(33, 184));
		((Control)e3G()).set_Name("Label2");
		((Control)e3G()).set_Size(new Size(112, 18));
		((Control)e3G()).set_TabIndex(83);
		e3G().set_Text("Submission Date");
		((Control)s1A()).set_Location(new Point(211, 220));
		s1A().set_Multiline(true);
		((Control)s1A()).set_Name("txtRemarks");
		s1A().set_ScrollBars((ScrollBars)3);
		((Control)s1A()).set_Size(new Size(384, 70));
		((Control)s1A()).set_TabIndex(5);
		Qx7().set_AutoSize(true);
		((Control)Qx7()).set_BackColor(Color.Transparent);
		((Control)Qx7()).set_Location(new Point(33, 222));
		((Control)Qx7()).set_Name("Label11");
		((Control)Qx7()).set_Size(new Size(62, 18));
		((Control)Qx7()).set_TabIndex(77);
		Qx7().set_Text("Remarks");
		((Control)k6Y()).set_Location(new Point(211, 42));
		((Control)k6Y()).set_Name("txtProjectName");
		((Control)k6Y()).set_Size(new Size(384, 25));
		((Control)k6Y()).set_TabIndex(0);
		Ly7().set_AutoSize(true);
		((Control)Ly7()).set_BackColor(Color.Transparent);
		((Control)Ly7()).set_Location(new Point(33, 148));
		((Control)Ly7()).set_Name("Label10");
		((Control)Ly7()).set_Size(new Size(35, 18));
		((Control)Ly7()).set_TabIndex(75);
		Ly7().set_Text("Year");
		e1C().set_AutoSize(true);
		((Control)e1C()).set_BackColor(Color.Transparent);
		((Control)e1C()).set_Location(new Point(33, 45));
		((Control)e1C()).set_Name("Label1");
		((Control)e1C()).set_Size(new Size(90, 18));
		((Control)e1C()).set_TabIndex(72);
		e1C().set_Text("Project Name");
		((Control)Cn1()).set_BackColor(Color.Transparent);
		Cn1().set_BorderStyle((BorderStyle)1);
		((Control)Cn1()).get_Controls().Add((Control)(object)btnGetDetails);
		((Control)Cn1()).get_Controls().Add((Control)(object)btnUpdate_record);
		((Control)Cn1()).get_Controls().Add((Control)(object)btnDelete);
		((Control)Cn1()).get_Controls().Add((Control)(object)btnSave);
		((Control)Cn1()).get_Controls().Add((Control)(object)btnNewRecord);
		((Control)Cn1()).set_Location(new Point(709, 34));
		((Control)Cn1()).set_Name("panel1");
		((Control)Cn1()).set_Size(new Size(123, 197));
		((Control)Cn1()).set_TabIndex(2);
		((Control)btnGetDetails).set_Font(new Font("Palatino Linotype", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnGetDetails).set_Location(new Point(14, 150));
		((Control)btnGetDetails).set_Name("btnGetDetails");
		((Control)btnGetDetails).set_Size(new Size(94, 28));
		((Control)btnGetDetails).set_TabIndex(4);
		((ButtonBase)btnGetDetails).set_Text("&Get Data");
		((ButtonBase)btnGetDetails).set_UseVisualStyleBackColor(true);
		((Control)btnUpdate_record).set_Enabled(false);
		((Control)btnUpdate_record).set_Font(new Font("Palatino Linotype", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnUpdate_record).set_Location(new Point(14, 117));
		((Control)btnUpdate_record).set_Name("btnUpdate_record");
		((Control)btnUpdate_record).set_Size(new Size(94, 27));
		((Control)btnUpdate_record).set_TabIndex(3);
		((ButtonBase)btnUpdate_record).set_Text("&Update");
		((ButtonBase)btnUpdate_record).set_UseVisualStyleBackColor(true);
		((Control)btnDelete).set_Enabled(false);
		((Control)btnDelete).set_Font(new Font("Palatino Linotype", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnDelete).set_Location(new Point(14, 84));
		((Control)btnDelete).set_Name("btnDelete");
		((Control)btnDelete).set_Size(new Size(94, 27));
		((Control)btnDelete).set_TabIndex(2);
		((ButtonBase)btnDelete).set_Text("&Delete");
		((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
		((Control)btnSave).set_Font(new Font("Palatino Linotype", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnSave).set_Location(new Point(14, 51));
		((Control)btnSave).set_Name("btnSave");
		((Control)btnSave).set_Size(new Size(94, 27));
		((Control)btnSave).set_TabIndex(1);
		((ButtonBase)btnSave).set_Text("&Save");
		((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
		((Control)btnNewRecord).set_Font(new Font("Palatino Linotype", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnNewRecord).set_Location(new Point(14, 18));
		((Control)btnNewRecord).set_Name("btnNewRecord");
		((Control)btnNewRecord).set_Size(new Size(94, 27));
		((Control)btnNewRecord).set_TabIndex(0);
		((ButtonBase)btnNewRecord).set_Text("&New");
		((ButtonBase)btnNewRecord).set_UseVisualStyleBackColor(true);
		((Control)Ln8()).set_Location(new Point(709, 2));
		((Control)Ln8()).set_Name("txtID");
		((Control)Ln8()).set_Size(new Size(100, 25));
		((Control)Ln8()).set_TabIndex(10);
		((Control)Ln8()).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 18f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(872, 357));
		((Control)this).get_Controls().Add((Control)(object)Ln8());
		((Control)this).get_Controls().Add((Control)(object)Cn1());
		((Control)this).get_Controls().Add((Control)(object)Qi5());
		((Control)this).set_Font(new Font("Palatino Linotype", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(4));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("frmProject");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Project");
		((Control)Qi5()).ResumeLayout(false);
		((Control)Qi5()).PerformLayout();
		((Control)Cn1()).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual GroupBox Qi5()
	{
		return _GroupBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k3E(GroupBox Lz6)
	{
		_GroupBox1 = Lz6;
	}

	[SpecialName]
	internal virtual ComboBox e5P()
	{
		return _cmbYear;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Si0(ComboBox z6M)
	{
		_cmbYear = z6M;
	}

	[SpecialName]
	internal virtual ComboBox i4A()
	{
		return _cmbCourse;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ra9(ComboBox Hj3)
	{
		EventHandler eventHandler = x5A;
		ComboBox cmbCourse = _cmbCourse;
		if (cmbCourse != null)
		{
			cmbCourse.remove_SelectedIndexChanged(eventHandler);
		}
		_cmbCourse = Hj3;
		cmbCourse = _cmbCourse;
		if (cmbCourse != null)
		{
			cmbCourse.add_SelectedIndexChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Ss0()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j6L(Label d0B)
	{
		_Label4 = d0B;
	}

	[SpecialName]
	internal virtual TextBox Te4()
	{
		return _txtStudentName;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z5F(TextBox x1R)
	{
		_txtStudentName = x1R;
	}

	[SpecialName]
	internal virtual Label c9E()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rg8(Label Sw5)
	{
		_Label3 = Sw5;
	}

	[SpecialName]
	internal virtual DateTimePicker w0P()
	{
		return _dtpSubmissionDate;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xs4(DateTimePicker o5J)
	{
		_dtpSubmissionDate = o5J;
	}

	[SpecialName]
	internal virtual Label e3G()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c3W(Label a7E)
	{
		_Label2 = a7E;
	}

	[SpecialName]
	internal virtual TextBox s1A()
	{
		return _txtRemarks;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a4S(TextBox Ki5)
	{
		_txtRemarks = Ki5;
	}

	[SpecialName]
	internal virtual Label Qx7()
	{
		return _Label11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yi9(Label Lc0)
	{
		_Label11 = Lc0;
	}

	[SpecialName]
	internal virtual TextBox k6Y()
	{
		return _txtProjectName;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gi5(TextBox Jx9)
	{
		_txtProjectName = Jx9;
	}

	[SpecialName]
	internal virtual Label Ly7()
	{
		return _Label10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mz0(Label g5D)
	{
		_Label10 = g5D;
	}

	[SpecialName]
	internal virtual Label e1C()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mb4(Label z3C)
	{
		_Label1 = z3C;
	}

	[SpecialName]
	internal virtual Panel Cn1()
	{
		return _panel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r7H(Panel Wb9)
	{
		_panel1 = Wb9;
	}

	[SpecialName]
	internal virtual Button m1B()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w1T(Button Wm5)
	{
		EventHandler eventHandler = Ca9;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = Wm5;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox Ln8()
	{
		return _txtID;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g4H(TextBox n6N)
	{
		_txtID = n6N;
	}

	public void Tz2()
	{
		k6Y().set_Text("");
		s1A().set_Text("");
		Te4().set_Text("");
		i4A().set_Text("");
		e5P().set_Text("");
		w0P().set_Text(Conversions.ToString(DateAndTime.get_Today()));
		((Control)btnSave).set_Enabled(true);
		((Control)btnDelete).set_Enabled(false);
		((Control)btnUpdate_record).set_Enabled(false);
		((Control)e5P()).set_Enabled(false);
		((Control)k6Y()).Focus();
	}

	public void Aq9()
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
			adp.set_SelectCommand(new OleDbCommand("SELECT distinct RTRIM(Coursename) FROM Course", val));
			ds = new DataSet("ds");
			((DbDataAdapter)(object)adp).Fill(ds);
			dtable = ds.Tables[0];
			i4A().get_Items().Clear();
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = dtable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					i4A().get_Items().Add((object)dataRow[0].ToString());
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

	private void Ld8(object sender, EventArgs e)
	{
		Aq9();
	}

	private void Af1(object sender, EventArgs e)
	{
		Tz2();
	}

	private void y2K(object sender, EventArgs e)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Strings.Len(Strings.Trim(k6Y().get_Text())) == 0)
			{
				MessageBox.Show("Please enter project name", "Input Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
				((Control)k6Y()).Focus();
				return;
			}
			if (Strings.Len(Strings.Trim(Te4().get_Text())) == 0)
			{
				MessageBox.Show("Please retrieve student name(s)", "Input Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
				((Control)Te4()).Focus();
				return;
			}
			if (Strings.Len(Strings.Trim(i4A().get_Text())) == 0)
			{
				MessageBox.Show("Please select course", "Input Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
				((Control)i4A()).Focus();
				return;
			}
			if (Strings.Len(Strings.Trim(e5P().get_Text())) == 0)
			{
				MessageBox.Show("Please select year", "Input Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
				((Control)e5P()).Focus();
				return;
			}
			con = new OleDbConnection(cs);
			con.Open();
			string text = "insert into Project(ProjectName, StudentName, Course, Proj_year, SubmissionDate, Remarks) VALUES('" + k6Y().get_Text() + "','" + Te4().get_Text() + "','" + i4A().get_Text() + "','" + e5P().get_Text() + "',#" + w0P().get_Text() + "#,'" + s1A().get_Text() + "')";
			cmd = new OleDbCommand(text);
			cmd.set_Connection(con);
			cmd.ExecuteNonQuery();
			con.Close();
			MessageBox.Show("Successfully saved", "Project Record", (MessageBoxButtons)0, (MessageBoxIcon)64);
			((Control)btnSave).set_Enabled(false);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message, "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			ProjectData.ClearProjectError();
		}
	}

	private void x5A(object sender, EventArgs e)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			i4A().set_Text(i4A().get_Text().Trim());
			e5P().get_Items().Clear();
			e5P().set_Text("");
			((Control)e5P()).set_Enabled(true);
			((Control)e5P()).Focus();
			con = new OleDbConnection(cs);
			con.Open();
			string text = "select distinct RTRIM(C_Year) from tblYears where course = '" + i4A().get_Text() + "'";
			cmd = new OleDbCommand(text);
			cmd.set_Connection(con);
			rdr = cmd.ExecuteReader();
			while (rdr.Read())
			{
				e5P().get_Items().Add(RuntimeHelpers.GetObjectValue(rdr.get_Item(0)));
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

	private void x1S(object sender, EventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if ((int)MessageBox.Show("Do you really want to delete this record?", "Confirmation", (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
			{
				e4H();
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

	public void e4H()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int num = 0;
			con = new OleDbConnection(cs);
			con.Open();
			string text = ("delete from Project where ID = " + Ln8().get_Text()) ?? "";
			cmd = new OleDbCommand(text);
			cmd.set_Connection(con);
			num = cmd.ExecuteNonQuery();
			if (num > 0)
			{
				MessageBox.Show("Successfully deleted", "Record", (MessageBoxButtons)0, (MessageBoxIcon)64);
				Tz2();
				return;
			}
			MessageBox.Show("No record found", "Sorry", (MessageBoxButtons)0, (MessageBoxIcon)64);
			Tz2();
			if (con.get_State() == ConnectionState.Open)
			{
				con.Close();
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

	private void Bt8(object sender, EventArgs e)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Strings.Len(Strings.Trim(k6Y().get_Text())) == 0)
			{
				MessageBox.Show("Please enter project name", "Input Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
				((Control)k6Y()).Focus();
				return;
			}
			if (Strings.Len(Strings.Trim(Te4().get_Text())) == 0)
			{
				MessageBox.Show("Please retrieve student name(s)", "Input Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
				((Control)Te4()).Focus();
				return;
			}
			if (Strings.Len(Strings.Trim(i4A().get_Text())) == 0)
			{
				MessageBox.Show("Please select course", "Input Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
				((Control)i4A()).Focus();
				return;
			}
			if (Strings.Len(Strings.Trim(e5P().get_Text())) == 0)
			{
				MessageBox.Show("Please select year", "Input Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
				((Control)e5P()).Focus();
				return;
			}
			con = new OleDbConnection(cs);
			con.Open();
			string text = ("update Project set projectName='" + k6Y().get_Text() + "',StudentName='" + Te4().get_Text() + "',Course='" + i4A().get_Text() + "',proj_Year='" + e5P().get_Text() + "',SubmissionDate=#" + w0P().get_Text() + "#,remarks='" + s1A().get_Text() + "' where ID= " + Ln8().get_Text()) ?? "";
			cmd = new OleDbCommand(text);
			cmd.set_Connection(con);
			cmd.ExecuteNonQuery();
			con.Close();
			MessageBox.Show("Successfully updated", "Project Record", (MessageBoxButtons)0, (MessageBoxIcon)64);
			((Control)btnUpdate_record).set_Enabled(false);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message, "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			ProjectData.ClearProjectError();
		}
	}

	private void Ca9(object sender, EventArgs e)
	{
	}

	internal static byte[] Sc0(byte[] Rc3, byte[] Jp6, int Wr4)
	{
		int num = checked(Rc3.Length - 1);
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			Rc3[i] = (byte)(Rc3[i] ^ checked((byte)(Jp6[unchecked(i % Jp6.Length)] ^ ((i + unchecked(Wr4 % Jp6.Length)) & Wr4))));
		}
		return Rc3;
	}

	private void Dw6(object sender, EventArgs e)
	{
	}
}
