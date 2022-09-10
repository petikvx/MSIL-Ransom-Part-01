using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class Save : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("LabelX2")]
	private LabelX _LabelX2;

	[AccessedThroughProperty("ll_txtnewname")]
	private TextBoxX _ll_txtnewname;

	[AccessedThroughProperty("ll_btnok")]
	private ButtonX _ll_btnok;

	[AccessedThroughProperty("ll_btncancel")]
	private ButtonX _ll_btncancel;

	[AccessedThroughProperty("ll_chkzb")]
	private CheckBoxX _ll_chkzb;

	[AccessedThroughProperty("ll_chkfb")]
	private CheckBoxX _ll_chkfb;

	[AccessedThroughProperty("ll_chktb")]
	private CheckBoxX _ll_chktb;

	[AccessedThroughProperty("ll_chkcq")]
	private CheckBoxX _ll_chkcq;

	[AccessedThroughProperty("ll_txtname")]
	private TextBoxX _ll_txtname;

	[AccessedThroughProperty("GP1")]
	private GroupPanel _GP1;

	private string curcsfile;

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

	internal virtual LabelX LabelX2
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX2 = value;
		}
	}

	internal virtual TextBoxX ll_txtnewname
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txtnewname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txtnewname = value;
		}
	}

	internal virtual ButtonX ll_btnok
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnok;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnok_Click;
			if (_ll_btnok != null)
			{
				((Control)_ll_btnok).remove_Click(eventHandler);
			}
			_ll_btnok = value;
			if (_ll_btnok != null)
			{
				((Control)_ll_btnok).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btncancel
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btncancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btncancel_Click;
			if (_ll_btncancel != null)
			{
				((Control)_ll_btncancel).remove_Click(eventHandler);
			}
			_ll_btncancel = value;
			if (_ll_btncancel != null)
			{
				((Control)_ll_btncancel).add_Click(eventHandler);
			}
		}
	}

	internal virtual CheckBoxX ll_chkzb
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_chkzb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_chkzb = value;
		}
	}

	internal virtual CheckBoxX ll_chkfb
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_chkfb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_chkfb = value;
		}
	}

	internal virtual CheckBoxX ll_chktb
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_chktb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_chktb = value;
		}
	}

	internal virtual CheckBoxX ll_chkcq
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_chkcq;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_chkcq = value;
		}
	}

	public virtual TextBoxX ll_txtname
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txtname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txtname = value;
		}
	}

	public virtual GroupPanel GP1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GP1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GP1 = value;
		}
	}

	[DebuggerNonUserCode]
	public Save()
	{
		((Form)this).add_Load((EventHandler)Save_Load);
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
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
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected O, but got Unknown
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected O, but got Unknown
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected O, but got Unknown
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Expected O, but got Unknown
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Expected O, but got Unknown
		//IL_09b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bd: Expected O, but got Unknown
		//IL_0a65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6f: Expected O, but got Unknown
		LabelX1 = new LabelX();
		ll_txtname = new TextBoxX();
		LabelX2 = new LabelX();
		ll_txtnewname = new TextBoxX();
		ll_btnok = new ButtonX();
		ll_btncancel = new ButtonX();
		ll_chkzb = new CheckBoxX();
		ll_chkfb = new CheckBoxX();
		ll_chktb = new CheckBoxX();
		ll_chkcq = new CheckBoxX();
		GP1 = new GroupPanel();
		((Control)GP1).SuspendLayout();
		((Control)this).SuspendLayout();
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX = LabelX1;
		Point location = new Point(15, 12);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		Size size = new Size(47, 23);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(0);
		LabelX1.set_Text("原名称");
		ll_txtname.get_Border().set_Class("TextBoxBorder");
		ll_txtname.get_Border().set_CornerType((eCornerType)1);
		((Control)ll_txtname).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		TextBoxX obj = ll_txtname;
		location = new Point(68, 12);
		((Control)obj).set_Location(location);
		((Control)ll_txtname).set_Name("ll_txtname");
		TextBoxX obj2 = ll_txtname;
		size = new Size(191, 21);
		((Control)obj2).set_Size(size);
		((Control)ll_txtname).set_TabIndex(1);
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX2).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX3 = LabelX2;
		location = new Point(15, 41);
		((Control)labelX3).set_Location(location);
		((Control)LabelX2).set_Name("LabelX2");
		LabelX labelX4 = LabelX2;
		size = new Size(47, 20);
		((Control)labelX4).set_Size(size);
		((Control)LabelX2).set_TabIndex(0);
		LabelX2.set_Text("新名称");
		ll_txtnewname.get_Border().set_Class("TextBoxBorder");
		ll_txtnewname.get_Border().set_CornerType((eCornerType)1);
		((Control)ll_txtnewname).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		TextBoxX obj3 = ll_txtnewname;
		location = new Point(68, 41);
		((Control)obj3).set_Location(location);
		((Control)ll_txtnewname).set_Name("ll_txtnewname");
		TextBoxX obj4 = ll_txtnewname;
		size = new Size(191, 21);
		((Control)obj4).set_Size(size);
		((Control)ll_txtnewname).set_TabIndex(1);
		((Control)ll_btnok).set_AccessibleRole((AccessibleRole)43);
		ll_btnok.set_ColorTable((eButtonColor)3);
		((Control)ll_btnok).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj5 = ll_btnok;
		location = new Point(18, 138);
		((Control)obj5).set_Location(location);
		((Control)ll_btnok).set_Name("ll_btnok");
		ButtonX obj6 = ll_btnok;
		size = new Size(75, 23);
		((Control)obj6).set_Size(size);
		((PopupItemControl)ll_btnok).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnok).set_TabIndex(3);
		ll_btnok.set_Text("确定");
		((Control)ll_btncancel).set_AccessibleRole((AccessibleRole)43);
		ll_btncancel.set_ColorTable((eButtonColor)3);
		ll_btncancel.set_DialogResult((DialogResult)2);
		((Control)ll_btncancel).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj7 = ll_btncancel;
		location = new Point(184, 138);
		((Control)obj7).set_Location(location);
		((Control)ll_btncancel).set_Name("ll_btncancel");
		ButtonX obj8 = ll_btncancel;
		size = new Size(75, 23);
		((Control)obj8).set_Size(size);
		((PopupItemControl)ll_btncancel).set_Style((eDotNetBarStyle)7);
		((Control)ll_btncancel).set_TabIndex(3);
		ll_btncancel.set_Text("取消");
		((BaseItemControl)ll_chkzb).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_chkzb).get_BackgroundStyle().set_CornerType((eCornerType)1);
		ll_chkzb.set_Checked(true);
		ll_chkzb.set_CheckState((CheckState)1);
		ll_chkzb.set_CheckValue((object)"Y");
		((Control)ll_chkzb).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		CheckBoxX obj9 = ll_chkzb;
		location = new Point(0, 3);
		((Control)obj9).set_Location(location);
		((Control)ll_chkzb).set_Name("ll_chkzb");
		CheckBoxX obj10 = ll_chkzb;
		size = new Size(54, 20);
		((Control)obj10).set_Size(size);
		((BaseItemControl)ll_chkzb).set_Style((eDotNetBarStyle)7);
		((Control)ll_chkzb).set_TabIndex(1);
		ll_chkzb.set_Text("主臂");
		((BaseItemControl)ll_chkfb).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_chkfb).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)ll_chkfb).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		CheckBoxX obj11 = ll_chkfb;
		location = new Point(60, 3);
		((Control)obj11).set_Location(location);
		((Control)ll_chkfb).set_Name("ll_chkfb");
		CheckBoxX obj12 = ll_chkfb;
		size = new Size(54, 20);
		((Control)obj12).set_Size(size);
		((BaseItemControl)ll_chkfb).set_Style((eDotNetBarStyle)7);
		((Control)ll_chkfb).set_TabIndex(1);
		ll_chkfb.set_Text("副臂");
		((BaseItemControl)ll_chktb).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_chktb).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)ll_chktb).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		CheckBoxX obj13 = ll_chktb;
		location = new Point(120, 3);
		((Control)obj13).set_Location(location);
		((Control)ll_chktb).set_Name("ll_chktb");
		CheckBoxX obj14 = ll_chktb;
		size = new Size(54, 20);
		((Control)obj14).set_Size(size);
		((BaseItemControl)ll_chktb).set_Style((eDotNetBarStyle)7);
		((Control)ll_chktb).set_TabIndex(1);
		ll_chktb.set_Text("塔臂");
		((BaseItemControl)ll_chkcq).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_chkcq).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)ll_chkcq).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		CheckBoxX obj15 = ll_chkcq;
		location = new Point(180, 3);
		((Control)obj15).set_Location(location);
		((Control)ll_chkcq).set_Name("ll_chkcq");
		CheckBoxX obj16 = ll_chkcq;
		size = new Size(52, 20);
		((Control)obj16).set_Size(size);
		((BaseItemControl)ll_chkcq).set_Style((eDotNetBarStyle)7);
		((Control)ll_chkcq).set_TabIndex(1);
		ll_chkcq.set_Text("超起");
		((PanelControl)GP1).set_CanvasColor(SystemColors.Control);
		((PanelControl)GP1).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)GP1).get_Controls().Add((Control)(object)ll_chkzb);
		((Control)GP1).get_Controls().Add((Control)(object)ll_chktb);
		((Control)GP1).get_Controls().Add((Control)(object)ll_chkcq);
		((Control)GP1).get_Controls().Add((Control)(object)ll_chkfb);
		GroupPanel gP = GP1;
		location = new Point(15, 70);
		((Control)gP).set_Location(location);
		((Control)GP1).set_Name("GP1");
		GroupPanel gP2 = GP1;
		size = new Size(244, 53);
		((Control)gP2).set_Size(size);
		((PanelControl)GP1).get_Style().set_BackColor2SchemePart((eColorSchemePart)52);
		((PanelControl)GP1).get_Style().set_BackColorGradientAngle(90);
		((PanelControl)GP1).get_Style().set_BackColorSchemePart((eColorSchemePart)51);
		((PanelControl)GP1).get_Style().set_BorderBottom((eStyleBorderType)1);
		((PanelControl)GP1).get_Style().set_BorderBottomWidth(1);
		((PanelControl)GP1).get_Style().set_BorderColorSchemePart((eColorSchemePart)53);
		((PanelControl)GP1).get_Style().set_BorderLeft((eStyleBorderType)1);
		((PanelControl)GP1).get_Style().set_BorderLeftWidth(1);
		((PanelControl)GP1).get_Style().set_BorderRight((eStyleBorderType)1);
		((PanelControl)GP1).get_Style().set_BorderRightWidth(1);
		((PanelControl)GP1).get_Style().set_BorderTop((eStyleBorderType)1);
		((PanelControl)GP1).get_Style().set_BorderTopWidth(1);
		((PanelControl)GP1).get_Style().set_Class("");
		((PanelControl)GP1).get_Style().set_CornerDiameter(4);
		((PanelControl)GP1).get_Style().set_CornerType((eCornerType)2);
		((PanelControl)GP1).get_Style().set_TextAlignment((eStyleTextAlignment)1);
		((PanelControl)GP1).get_Style().set_TextColorSchemePart((eColorSchemePart)54);
		((PanelControl)GP1).get_Style().set_TextLineAlignment((eStyleTextAlignment)0);
		((PanelControl)GP1).get_StyleMouseDown().set_Class("");
		((PanelControl)GP1).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)GP1).get_StyleMouseOver().set_Class("");
		((PanelControl)GP1).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)GP1).set_TabIndex(4);
		((PanelControl)GP1).set_Text("性能计算参数表保存项");
		((Form)this).set_AcceptButton((IButtonControl)(object)ll_btnok);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)ll_btncancel);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(275, 175);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)GP1);
		((Control)this).get_Controls().Add((Control)(object)ll_btncancel);
		((Control)this).get_Controls().Add((Control)(object)ll_btnok);
		((Control)this).get_Controls().Add((Control)(object)ll_txtnewname);
		((Control)this).get_Controls().Add((Control)(object)ll_txtname);
		((Control)this).get_Controls().Add((Control)(object)LabelX2);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Save");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("指定保存的参数文件名称");
		((Control)GP1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void ll_btnok_Click(object sender, EventArgs e)
	{
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(MyProject.Forms.FrmOf.qyx, "qyxxn", false) == 0)
		{
			if (Operators.CompareString(((TextBox)ll_txtnewname).get_Text(), "", false) != 0)
			{
				if (ll_chkzb.get_Checked() | ll_chkfb.get_Checked() | ll_chktb.get_Checked() | ll_chkcq.get_Checked())
				{
					Mod1.excelapp.DisplayAlerts = false;
					((Control)this).set_Cursor(Cursors.get_AppStarting());
					curcsfile = Mod1.path1 + "\\cs\\" + ((TextBox)ll_txtnewname).get_Text();
					if (ll_chkzb.get_Checked())
					{
						ll_savexnopt("主臂");
					}
					if (ll_chkfb.get_Checked())
					{
						ll_savexnopt("副臂");
					}
					if (ll_chktb.get_Checked())
					{
						ll_savexnopt("塔臂");
					}
					if (ll_chkcq.get_Checked())
					{
						ll_savexnopt("超起");
					}
					Mod1.wb.SaveAs(curcsfile, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
					Mod1.wb.Close(Missing.Value, Missing.Value, Missing.Value);
					Mod1.wb = Mod1.excelapp.Workbooks.Open(curcsfile, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
					Mod1.cswj = ((TextBox)ll_txtnewname).get_Text();
					MyProject.Forms.Main.lbx.set_Text("已打开部件： " + Mod1.bjlb1 + "  参数文件：" + Mod1.cswj);
					MyProject.Forms.Main.lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 参数文件已保存到：" + curcsfile));
					((Component)(object)MyProject.Forms.FrmOf).Dispose();
					MyProject.Forms.FrmOf.qyx = "qyxxn";
					Mod1.Saved = true;
					((BaseItem)MyProject.Forms.Main.ToolsSave).set_Enabled(false);
					((Control)this).set_Cursor(Cursors.get_Arrow());
					Interaction.MsgBox((object)"保存成功，程序会自动打开已保存的文件！", (MsgBoxStyle)64, (object)"文件保存");
					((Form)this).Close();
				}
				else
				{
					Interaction.MsgBox((object)"请选择一个要保存的项！", (MsgBoxStyle)64, (object)"提示");
				}
			}
			else
			{
				Interaction.MsgBox((object)"参数文件没有保存！", (MsgBoxStyle)64, (object)"提示");
			}
		}
		else
		{
			curcsfile = Mod1.path1 + "\\cs\\" + ((TextBox)ll_txtnewname).get_Text();
			Mod1.wb.SaveAs(curcsfile, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
			Mod1.wb.Close(Missing.Value, Missing.Value, Missing.Value);
			Mod1.Saved = true;
			((BaseItem)MyProject.Forms.Main.ToolsSave).set_Enabled(false);
			Interaction.MsgBox((object)"保存成功！", (MsgBoxStyle)64, (object)"保存");
			MyProject.Forms.Main.lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员对已修改的参数文件 " + Mod1.filename + " 进行了保存"));
			((Form)this).Close();
		}
	}

	public void ll_savexnopt(string strxn)
	{
		Mod1.excelsheet = (Worksheet)Mod1.excelapp.Worksheets[strxn];
		Excel.Range range = (Excel.Range)Mod1.excelsheet.Cells[Mod1.excelsheet.Cells.Rows.Count, 8];
		int row = range.get_End(XlDirection.xlUp).Row;
		int num = row;
		for (int i = 2; i <= num; i = checked(i + 1))
		{
			NewLateBinding.LateSetComplex(Mod1.excelsheet.Cells[i, 6], (Type)null, "value", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, 8], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(Mod1.excelsheet.Cells[i, 5], (Type)null, "value", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Mod1.excelsheet.Cells[i, 7], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
		}
	}

	private void ll_btncancel_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Save_Load(object sender, EventArgs e)
	{
		((TextBox)ll_txtname).set_Text(Mod1.cswj);
		((TextBox)ll_txtnewname).set_Text(Mod1.cswj);
		((Control)ll_chkzb).set_BackColor(Color.Transparent);
		((Control)ll_chkfb).set_BackColor(Color.Transparent);
		((Control)ll_chktb).set_BackColor(Color.Transparent);
		((Control)ll_chkcq).set_BackColor(Color.Transparent);
	}
}
