using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Excel;
using Microsoft.VisualBasic.CompilerServices;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class bjxslck : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("cbgzb")]
	private ComboBoxEx _cbgzb;

	[AccessedThroughProperty("DGV")]
	private DataGridViewX _DGV;

	[AccessedThroughProperty("bjgb")]
	private ButtonX _bjgb;

	private OleDbConnection MyConnection;

	private OleDbDataAdapter MyCommand;

	private DataSet ds;

	private string cbgzb1;

	internal virtual LabelX LabelX1
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX1 = value;
		}
	}

	internal virtual ComboBoxEx cbgzb
	{
		[DebuggerNonUserCode]
		get
		{
			return _cbgzb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cbgzb_SelectedIndexChanged;
			if (_cbgzb != null)
			{
				((ComboBox)_cbgzb).remove_SelectedIndexChanged(eventHandler);
			}
			_cbgzb = value;
			if (_cbgzb != null)
			{
				((ComboBox)_cbgzb).add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual DataGridViewX DGV
	{
		[DebuggerNonUserCode]
		get
		{
			return _DGV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DGV = value;
		}
	}

	internal virtual ButtonX bjgb
	{
		[DebuggerNonUserCode]
		get
		{
			return _bjgb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = bjgb_Click;
			if (_bjgb != null)
			{
				((Control)_bjgb).remove_Click(eventHandler);
			}
			_bjgb = value;
			if (_bjgb != null)
			{
				((Control)_bjgb).add_Click(eventHandler);
			}
		}
	}

	public bjxslck()
	{
		((Form)this).add_Load((EventHandler)bjxslck_Load);
		ds = new DataSet();
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
			((Office2007Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected O, but got Unknown
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		LabelX1 = new LabelX();
		cbgzb = new ComboBoxEx();
		DGV = new DataGridViewX();
		bjgb = new ButtonX();
		((ISupportInitialize)DGV).BeginInit();
		((Control)this).SuspendLayout();
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX = LabelX1;
		Point location = new Point(12, 12);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		Size size = new Size(99, 23);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(0);
		LabelX1.set_Text("布局文件XLS：");
		((ListControl)cbgzb).set_DisplayMember("Text");
		((ComboBox)cbgzb).set_DrawMode((DrawMode)1);
		((ComboBox)cbgzb).set_DropDownStyle((ComboBoxStyle)2);
		((Control)cbgzb).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)cbgzb).set_FormattingEnabled(true);
		((ComboBox)cbgzb).set_ItemHeight(15);
		ComboBoxEx obj = cbgzb;
		location = new Point(117, 12);
		((Control)obj).set_Location(location);
		((Control)cbgzb).set_Name("cbgzb");
		ComboBoxEx obj2 = cbgzb;
		size = new Size(184, 21);
		((Control)obj2).set_Size(size);
		cbgzb.set_Style((eDotNetBarStyle)7);
		((Control)cbgzb).set_TabIndex(1);
		((DataGridView)DGV).set_AllowUserToAddRows(false);
		((DataGridView)DGV).set_AllowUserToDeleteRows(false);
		val.set_Alignment((DataGridViewContentAlignment)16);
		val.set_BackColor(SystemColors.Control);
		val.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		val.set_ForeColor(SystemColors.WindowText);
		val.set_SelectionBackColor(SystemColors.Highlight);
		val.set_SelectionForeColor(SystemColors.HighlightText);
		val.set_WrapMode((DataGridViewTriState)1);
		((DataGridView)DGV).set_ColumnHeadersDefaultCellStyle(val);
		((DataGridView)DGV).set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		val2.set_Alignment((DataGridViewContentAlignment)16);
		val2.set_BackColor(SystemColors.Window);
		val2.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		val2.set_ForeColor(SystemColors.ControlText);
		val2.set_SelectionBackColor(SystemColors.Highlight);
		val2.set_SelectionForeColor(SystemColors.ControlText);
		val2.set_WrapMode((DataGridViewTriState)2);
		((DataGridView)DGV).set_DefaultCellStyle(val2);
		((DataGridView)DGV).set_GridColor(Color.FromArgb(208, 215, 229));
		DataGridViewX dGV = DGV;
		location = new Point(12, 50);
		((Control)dGV).set_Location(location);
		((DataGridView)DGV).set_MultiSelect(false);
		((Control)DGV).set_Name("DGV");
		((DataGridView)DGV).set_ReadOnly(true);
		((DataGridView)DGV).get_RowTemplate().set_Height(23);
		((DataGridView)DGV).set_SelectionMode((DataGridViewSelectionMode)1);
		DataGridViewX dGV2 = DGV;
		size = new Size(880, 391);
		((Control)dGV2).set_Size(size);
		((Control)DGV).set_TabIndex(2);
		((Control)bjgb).set_AccessibleRole((AccessibleRole)43);
		bjgb.set_ColorTable((eButtonColor)3);
		bjgb.set_DialogResult((DialogResult)2);
		ButtonX obj3 = bjgb;
		location = new Point(353, 447);
		((Control)obj3).set_Location(location);
		((Control)bjgb).set_Name("bjgb");
		ButtonX obj4 = bjgb;
		size = new Size(232, 29);
		((Control)obj4).set_Size(size);
		((PopupItemControl)bjgb).set_Style((eDotNetBarStyle)7);
		((Control)bjgb).set_TabIndex(3);
		bjgb.set_Text("关闭");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)bjgb);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f));
		size = new Size(904, 482);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)bjgb);
		((Control)this).get_Controls().Add((Control)(object)DGV);
		((Control)this).get_Controls().Add((Control)(object)cbgzb);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("bjxslck");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("布局文件浏览...");
		((ISupportInitialize)DGV).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void bjxslck_Load(object sender, EventArgs e)
	{
		cbgzb.get_Items().Clear();
		ListBox lbcl = MyProject.Forms.clxd.lbcl;
		string text = lbcl.get_Text();
		string text2 = Mod1.toen(ref text);
		lbcl.set_Text(text);
		if (Operators.CompareString(text2, "", false) != 0)
		{
			try
			{
				clxd obj = MyProject.Forms.clxd;
				Workbooks workbooks = Mod1.excelapp.Workbooks;
				string[] array = new string[6]
				{
					Mod1.xdpath,
					"\\",
					null,
					null,
					null,
					null
				};
				string[] array2 = array;
				ListBox lbcl2 = MyProject.Forms.clxd.lbcl;
				string text3 = lbcl2.get_Text();
				string text4 = Mod1.toen(ref text3);
				lbcl2.set_Text(text3);
				array2[2] = text4;
				array[3] = "\\";
				array[4] = MyProject.Forms.clxd.lbsl.get_Text();
				array[5] = "\\layoutvar.xls";
				obj.wblay = workbooks.Open(string.Concat(array), Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				MyProject.Forms.clxd.wblay.Close(Missing.Value, Missing.Value, Missing.Value);
				clxd obj2 = MyProject.Forms.clxd;
				Workbooks workbooks2 = Mod1.excelapp.Workbooks;
				string[] array = new string[6]
				{
					Mod1.xdpath,
					"\\",
					null,
					null,
					null,
					null
				};
				string[] array3 = array;
				ListBox lbcl2 = MyProject.Forms.clxd.lbcl;
				string text3 = lbcl2.get_Text();
				string text5 = Mod1.toen(ref text3);
				lbcl2.set_Text(text3);
				array3[2] = text5;
				array[3] = "\\";
				array[4] = MyProject.Forms.clxd.lbsl.get_Text();
				array[5] = "\\layoutvar.xls";
				obj2.wblay = workbooks2.Open(string.Concat(array), Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
				ProjectData.ClearProjectError();
			}
			int count = MyProject.Forms.clxd.wblay.Sheets.Count;
			for (int i = 1; i <= count; i = checked(i + 1))
			{
				cbgzb.get_Items().Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(MyProject.Forms.clxd.wblay.Sheets[i], (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null)));
			}
			((ComboBox)cbgzb).set_SelectedIndex(0);
		}
	}

	public void dislplay1()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		if (Operators.CompareString(((ComboBox)cbgzb).get_Text(), "", false) != 0 && Operators.CompareString(Mod1.path, "", false) != 0)
		{
			try
			{
				MyConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + Mod1.path + "; Extended Properties=Excel 8.0;");
				MyCommand = new OleDbDataAdapter("select * from [" + ((ComboBox)cbgzb).get_Text() + "$]", MyConnection);
				((DbDataAdapter)(object)MyCommand).Fill(ds, "[" + ((ComboBox)cbgzb).get_Text() + "$]");
				((DataGridView)DGV).set_DataSource((object)ds.Tables["[" + ((ComboBox)cbgzb).get_Text() + "$]"]);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void cbgzb_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(cbgzb1, "", false) == 0)
		{
			cbgzb1 = ((ComboBox)cbgzb).get_Text();
			dislplay1();
		}
		else if (Operators.CompareString(cbgzb1, ((ComboBox)cbgzb).get_Text(), false) != 0)
		{
			cbgzb1 = ((ComboBox)cbgzb).get_Text();
			ds.Clear();
			((Control)DGV).Refresh();
			dislplay1();
		}
	}

	private void bjgb_Click(object sender, EventArgs e)
	{
		MyConnection.Close();
		((Component)(object)MyConnection).Dispose();
		((Component)(object)MyCommand).Dispose();
		ds.Dispose();
		((Form)this).Close();
	}
}
