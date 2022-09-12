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

namespace c2QGt9;

[DesignerGenerated]
public class a7N8Mb : Form
{
	private IContainer components;

	private GroupBox _GroupBox4;

	private Label _Label2;

	private Label _Label1;

	private DateTimePicker _dtpDateTo;

	private DateTimePicker _dtpDateFrom;

	private GroupBox _GroupBox3;

	private DataGridView _DataGridView1;

	[AccessedThroughProperty("btnExportExcel")]
	private Button _btnExportExcel;

	private Button _btnReset;

	private ComboBox _cmbPaperName;

	private Button _Button1;

	private GroupBox _GroupBox1;

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
			EventHandler eventHandler = Dg6m3C;
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

	public a7N8Mb()
	{
		((Form)this).add_Load((EventHandler)q3DQj9);
		rdr = null;
		con = null;
		cmd = null;
		dt = new DataTable();
		cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\LMS_DB.accdb;Persist Security Info=False;";
		Ny6f2J();
	}

	protected override void a0HXz2(bool s7S4Fp)
	{
		try
		{
			if (s7S4Fp && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(s7S4Fp);
		}
	}

	private void Ny6f2J()
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
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected O, but got Unknown
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected O, but got Unknown
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Expected O, but got Unknown
		//IL_06dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d1: Expected O, but got Unknown
		//IL_07e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ee: Expected O, but got Unknown
		//IL_07f3: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(a7N8Mb));
		g8KXw2(new GroupBox());
		Zg2d7S(new Label());
		q9BPb2(new Label());
		j2X5By(new DateTimePicker());
		Dm5p7H(new DateTimePicker());
		Fe79Bm(new GroupBox());
		Le2t7D(new ComboBox());
		Ec10Qi(new DataGridView());
		btnExportExcel = new Button();
		o0JDk7(new Button());
		Sb49Wz(new Button());
		i5TSw7(new GroupBox());
		((Control)a9RAe4()).SuspendLayout();
		((Control)Me45Qf()).SuspendLayout();
		((ISupportInitialize)n6C7Zw()).BeginInit();
		((Control)Wq21Xb()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)a9RAe4()).get_Controls().Add((Control)(object)x3P2Tq());
		((Control)a9RAe4()).get_Controls().Add((Control)(object)Bn1f8M());
		((Control)a9RAe4()).get_Controls().Add((Control)(object)Er5j7T());
		((Control)a9RAe4()).get_Controls().Add((Control)(object)w5X1Hg());
		((Control)a9RAe4()).set_Location(new Point(300, 13));
		((Control)a9RAe4()).set_Margin(new Padding(3, 4, 3, 4));
		((Control)a9RAe4()).set_Name("GroupBox4");
		((Control)a9RAe4()).set_Padding(new Padding(3, 4, 3, 4));
		((Control)a9RAe4()).set_Size(new Size(318, 88));
		((Control)a9RAe4()).set_TabIndex(1);
		a9RAe4().set_TabStop(false);
		a9RAe4().set_Text("By Date");
		x3P2Tq().set_AutoSize(true);
		((Control)x3P2Tq()).set_Font(new Font("Palatino Linotype", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)x3P2Tq()).set_Location(new Point(172, 17));
		((Control)x3P2Tq()).set_Name("Label2");
		((Control)x3P2Tq()).set_Size(new Size(22, 16));
		((Control)x3P2Tq()).set_TabIndex(33);
		x3P2Tq().set_Text("To");
		Bn1f8M().set_AutoSize(true);
		((Control)Bn1f8M()).set_Font(new Font("Palatino Linotype", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Bn1f8M()).set_Location(new Point(24, 19));
		((Control)Bn1f8M()).set_Name("Label1");
		((Control)Bn1f8M()).set_Size(new Size(33, 16));
		((Control)Bn1f8M()).set_TabIndex(6);
		Bn1f8M().set_Text("From");
		Er5j7T().set_CustomFormat("dd/MMM/yyyy");
		Er5j7T().set_Format((DateTimePickerFormat)8);
		((Control)Er5j7T()).set_Location(new Point(175, 36));
		((Control)Er5j7T()).set_Name("dtpDateTo");
		((Control)Er5j7T()).set_Size(new Size(123, 24));
		((Control)Er5j7T()).set_TabIndex(1);
		w5X1Hg().set_CustomFormat("dd/MMM/yyyy");
		w5X1Hg().set_Format((DateTimePickerFormat)8);
		((Control)w5X1Hg()).set_Location(new Point(24, 38));
		((Control)w5X1Hg()).set_Name("dtpDateFrom");
		((Control)w5X1Hg()).set_Size(new Size(131, 24));
		((Control)w5X1Hg()).set_TabIndex(0);
		((Control)Me45Qf()).get_Controls().Add((Control)(object)Fj01Ga());
		((Control)Me45Qf()).set_Location(new Point(16, 12));
		((Control)Me45Qf()).set_Margin(new Padding(3, 4, 3, 4));
		((Control)Me45Qf()).set_Name("GroupBox3");
		((Control)Me45Qf()).set_Padding(new Padding(3, 4, 3, 4));
		((Control)Me45Qf()).set_Size(new Size(269, 88));
		((Control)Me45Qf()).set_TabIndex(0);
		Me45Qf().set_TabStop(false);
		Me45Qf().set_Text("By Paper Name");
		Fj01Ga().set_AutoCompleteMode((AutoCompleteMode)1);
		Fj01Ga().set_AutoCompleteSource((AutoCompleteSource)256);
		((ListControl)Fj01Ga()).set_FormattingEnabled(true);
		((Control)Fj01Ga()).set_Location(new Point(18, 39));
		((Control)Fj01Ga()).set_Name("cmbPaperName");
		((Control)Fj01Ga()).set_Size(new Size(227, 25));
		((Control)Fj01Ga()).set_TabIndex(0);
		n6C7Zw().set_BackgroundColor(SystemColors.ActiveBorder);
		n6C7Zw().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)n6C7Zw()).set_Location(new Point(16, 108));
		n6C7Zw().set_MultiSelect(false);
		((Control)n6C7Zw()).set_Name("DataGridView1");
		n6C7Zw().set_ScrollBars((ScrollBars)2);
		((Control)n6C7Zw()).set_Size(new Size(560, 547));
		((Control)n6C7Zw()).set_TabIndex(33);
		((Control)btnExportExcel).set_Font(new Font("Palatino Linotype", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnExportExcel).set_Location(new Point(213, 30));
		((Control)btnExportExcel).set_Name("btnExportExcel");
		((Control)btnExportExcel).set_Size(new Size(93, 36));
		((Control)btnExportExcel).set_TabIndex(1);
		((ButtonBase)btnExportExcel).set_Text("&Export Excel");
		((ButtonBase)btnExportExcel).set_UseVisualStyleBackColor(true);
		((Control)b7F0Lq()).set_Font(new Font("Palatino Linotype", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)b7F0Lq()).set_Location(new Point(114, 31));
		((Control)b7F0Lq()).set_Name("btnReset");
		((Control)b7F0Lq()).set_Size(new Size(93, 33));
		((Control)b7F0Lq()).set_TabIndex(0);
		((ButtonBase)b7F0Lq()).set_Text("&Reset");
		((ButtonBase)b7F0Lq()).set_UseVisualStyleBackColor(true);
		((Control)Re60Wz()).set_Font(new Font("Palatino Linotype", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Re60Wz()).set_Location(new Point(15, 31));
		((Control)Re60Wz()).set_Name("Button1");
		((Control)Re60Wz()).set_Size(new Size(93, 33));
		((Control)Re60Wz()).set_TabIndex(2);
		((ButtonBase)Re60Wz()).set_Text("&Get Data");
		((ButtonBase)Re60Wz()).set_UseVisualStyleBackColor(true);
		((Control)Wq21Xb()).get_Controls().Add((Control)(object)Re60Wz());
		((Control)Wq21Xb()).get_Controls().Add((Control)(object)btnExportExcel);
		((Control)Wq21Xb()).get_Controls().Add((Control)(object)b7F0Lq());
		((Control)Wq21Xb()).set_Location(new Point(633, 12));
		((Control)Wq21Xb()).set_Margin(new Padding(3, 4, 3, 4));
		((Control)Wq21Xb()).set_Name("GroupBox1");
		((Control)Wq21Xb()).set_Padding(new Padding(3, 4, 3, 4));
		((Control)Wq21Xb()).set_Size(new Size(317, 88));
		((Control)Wq21Xb()).set_TabIndex(2);
		Wq21Xb().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 17f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ButtonHighlight);
		((Form)this).set_ClientSize(new Size(973, 656));
		((Control)this).get_Controls().Add((Control)(object)Wq21Xb());
		((Control)this).get_Controls().Add((Control)(object)n6C7Zw());
		((Control)this).get_Controls().Add((Control)(object)a9RAe4());
		((Control)this).get_Controls().Add((Control)(object)Me45Qf());
		((Control)this).set_Font(new Font("Palatino Linotype", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(3, 4, 3, 4));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("frmNewsPaperRecord1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Search News Paper Record");
		((Control)a9RAe4()).ResumeLayout(false);
		((Control)a9RAe4()).PerformLayout();
		((Control)Me45Qf()).ResumeLayout(false);
		((ISupportInitialize)n6C7Zw()).EndInit();
		((Control)Wq21Xb()).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual GroupBox a9RAe4()
	{
		return _GroupBox4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g8KXw2(GroupBox r9PWy6)
	{
		_GroupBox4 = r9PWy6;
	}

	[SpecialName]
	internal virtual Label x3P2Tq()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zg2d7S(Label Sy37Fw)
	{
		_Label2 = Sy37Fw;
	}

	[SpecialName]
	internal virtual Label Bn1f8M()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q9BPb2(Label Hp7c4L)
	{
		_Label1 = Hp7c4L;
	}

	[SpecialName]
	internal virtual DateTimePicker Er5j7T()
	{
		return _dtpDateTo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j2X5By(DateTimePicker Jd85Zq)
	{
		CancelEventHandler cancelEventHandler = Ct0y7A;
		DateTimePicker dtpDateTo = _dtpDateTo;
		if (dtpDateTo != null)
		{
			((Control)dtpDateTo).remove_Validating(cancelEventHandler);
		}
		_dtpDateTo = Jd85Zq;
		dtpDateTo = _dtpDateTo;
		if (dtpDateTo != null)
		{
			((Control)dtpDateTo).add_Validating(cancelEventHandler);
		}
	}

	[SpecialName]
	internal virtual DateTimePicker w5X1Hg()
	{
		return _dtpDateFrom;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dm5p7H(DateTimePicker Ek45Ms)
	{
		_dtpDateFrom = Ek45Ms;
	}

	[SpecialName]
	internal virtual GroupBox Me45Qf()
	{
		return _GroupBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fe79Bm(GroupBox c4W1Zr)
	{
		_GroupBox3 = c4W1Zr;
	}

	[SpecialName]
	internal virtual DataGridView n6C7Zw()
	{
		return _DataGridView1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ec10Qi(DataGridView Tm9c7Y)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		DataGridViewRowPostPaintEventHandler val = new DataGridViewRowPostPaintEventHandler(Cw61Qj);
		DataGridView dataGridView = _DataGridView1;
		if (dataGridView != null)
		{
			dataGridView.remove_RowPostPaint(val);
		}
		_DataGridView1 = Tm9c7Y;
		dataGridView = _DataGridView1;
		if (dataGridView != null)
		{
			dataGridView.add_RowPostPaint(val);
		}
	}

	[SpecialName]
	private virtual Button b7F0Lq()
	{
		return _btnReset;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void o0JDk7(Button Tp5m0H)
	{
		EventHandler eventHandler = Yo56Ga;
		Button btnReset = _btnReset;
		if (btnReset != null)
		{
			((Control)btnReset).remove_Click(eventHandler);
		}
		_btnReset = Tp5m0H;
		btnReset = _btnReset;
		if (btnReset != null)
		{
			((Control)btnReset).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ComboBox Fj01Ga()
	{
		return _cmbPaperName;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Le2t7D(ComboBox n3P9Kx)
	{
		_cmbPaperName = n3P9Kx;
	}

	[SpecialName]
	private virtual Button Re60Wz()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void Sb49Wz(Button e0M6Rq)
	{
		EventHandler eventHandler = m2N9Xq;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = e0M6Rq;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual GroupBox Wq21Xb()
	{
		return _GroupBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i5TSw7(GroupBox e7G8Cd)
	{
		_GroupBox1 = e7G8Cd;
	}

	private void Dg6m3C(object sender, EventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		if (n6C7Zw().get_RowCount() == 0)
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
				short num = (short)(n6C7Zw().get_RowCount() - 1);
				short num2 = (short)(((BaseCollection)n6C7Zw().get_Columns()).get_Count() - 1);
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
					}, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[1] { n6C7Zw().get_Columns().get_Item(unchecked((int)num4)).get_HeaderText() }, (string[])null, (Type[])null, false, true);
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
						}, (string[])null, (Type[])null, (bool[])null), (Type)null, "value", new object[1] { unchecked(n6C7Zw().get_Rows().get_Item((int)num6).get_Cells()
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

	public void Bs8y2P()
	{
		Fj01Ga().set_Text("");
		w5X1Hg().set_Text(Conversions.ToString(DateAndTime.get_Today()));
		Er5j7T().set_Text(Conversions.ToString(DateAndTime.get_Today()));
		n6C7Zw().set_DataSource((object)null);
	}

	private void Yo56Ga(object sender, EventArgs e)
	{
		Bs8y2P();
	}

	private void Cw61Qj(object sender, DataGridViewRowPostPaintEventArgs e)
	{
		checked
		{
			string text = (e.get_RowIndex() + 1).ToString();
			SizeF sizeF = e.get_Graphics().MeasureString(text, ((Control)this).get_Font());
			if (n6C7Zw().get_RowHeadersWidth() < Convert.ToInt32(sizeF.Width + 20f))
			{
				n6C7Zw().set_RowHeadersWidth(Convert.ToInt32(sizeF.Width + 20f));
			}
			Brush controlText = SystemBrushes.get_ControlText();
			e.get_Graphics().DrawString(text, ((Control)this).get_Font(), controlText, (float)(e.get_RowBounds().Location.X + 15), (float)e.get_RowBounds().Location.Y + ((float)e.get_RowBounds().Height - sizeF.Height) / 2f);
		}
	}

	private void m2N9Xq(object sender, EventArgs e)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Strings.Len(Strings.Trim(Fj01Ga().get_Text())) == 0)
			{
				MessageBox.Show("Please Select Paper Name", "Input Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
				((Control)Fj01Ga()).Focus();
				return;
			}
			con = new OleDbConnection(cs);
			con.Open();
			cmd = new OleDbCommand("SELECT ID,PaperName as [Paper Name],N_Date as [Date],Status,Remarks from NewsPaper where N_Date between #" + w5X1Hg().get_Text() + "# and #" + Er5j7T().get_Text() + "# and PaperName='" + Fj01Ga().get_Text() + "'  order by N_Date", con);
			OleDbDataAdapter val = new OleDbDataAdapter(cmd);
			DataSet dataSet = new DataSet();
			((DbDataAdapter)(object)val).Fill(dataSet, "NewsPaper");
			n6C7Zw().set_DataSource((object)dataSet.Tables["NewsPaper"]!.DefaultView);
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

	public void Fy6m2E()
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
			adp.set_SelectCommand(new OleDbCommand("SELECT distinct RTRIM(PaperName) FROM NewsPaper", val));
			ds = new DataSet("ds");
			((DbDataAdapter)(object)adp).Fill(ds);
			dtable = ds.Tables[0];
			Fj01Ga().get_Items().Clear();
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = dtable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					Fj01Ga().get_Items().Add((object)dataRow[0].ToString());
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

	private void q3DQj9(object sender, EventArgs e)
	{
		Fy6m2E();
	}

	internal static object Cy5k9M()
	{
		return AppDomain.CurrentDomain;
	}

	private void Ct0y7A(object sender, CancelEventArgs e)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (DateTime.Compare(w5X1Hg().get_Value().Date, Er5j7T().get_Value().Date) > 0)
		{
			MessageBox.Show("Invalid Selection", "Input Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			((Control)Er5j7T()).Focus();
		}
	}
}
