using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
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
public class gxcs : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("LabelX2")]
	private LabelX _LabelX2;

	[AccessedThroughProperty("btnC")]
	private ButtonX _btnC;

	[AccessedThroughProperty("ButtonX1")]
	private ButtonX _ButtonX1;

	[AccessedThroughProperty("btnok")]
	private ButtonX _btnok;

	[AccessedThroughProperty("tbxcs")]
	private TextBoxX _tbxcs;

	[AccessedThroughProperty("tbycs")]
	private TextBoxX _tbycs;

	private virtual LabelX LabelX1
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

	private virtual LabelX LabelX2
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

	private virtual ButtonX btnC
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnC_Click;
			if (_btnC != null)
			{
				((Control)_btnC).remove_Click(eventHandler);
			}
			_btnC = value;
			if (_btnC != null)
			{
				((Control)_btnC).add_Click(eventHandler);
			}
		}
	}

	private virtual ButtonX ButtonX1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ButtonX1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ButtonX1 = value;
		}
	}

	private virtual ButtonX btnok
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnok;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnok_Click;
			if (_btnok != null)
			{
				((Control)_btnok).remove_Click(eventHandler);
			}
			_btnok = value;
			if (_btnok != null)
			{
				((Control)_btnok).add_Click(eventHandler);
			}
		}
	}

	public virtual TextBoxX tbxcs
	{
		[DebuggerNonUserCode]
		get
		{
			return _tbxcs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tbxcs = value;
		}
	}

	public virtual TextBoxX tbycs
	{
		[DebuggerNonUserCode]
		get
		{
			return _tbycs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tbycs = value;
		}
	}

	[DebuggerNonUserCode]
	public gxcs()
	{
		((Form)this).add_Load((EventHandler)gxcs_Load);
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
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected O, but got Unknown
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected O, but got Unknown
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Expected O, but got Unknown
		tbycs = new TextBoxX();
		tbxcs = new TextBoxX();
		LabelX1 = new LabelX();
		LabelX2 = new LabelX();
		btnC = new ButtonX();
		ButtonX1 = new ButtonX();
		btnok = new ButtonX();
		((Control)this).SuspendLayout();
		((TextBoxBase)tbycs).set_BackColor(SystemColors.AppWorkspace);
		tbycs.get_Border().set_Class("TextBoxBorder");
		tbycs.get_Border().set_CornerType((eCornerType)1);
		((Control)tbycs).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((TextBoxBase)tbycs).set_ForeColor(Color.White);
		TextBoxX obj = tbycs;
		Point location = new Point(97, 14);
		((Control)obj).set_Location(location);
		((Control)tbycs).set_Name("tbycs");
		TextBoxX obj2 = tbycs;
		Size size = new Size(170, 21);
		((Control)obj2).set_Size(size);
		((Control)tbycs).set_TabIndex(0);
		tbxcs.get_Border().set_Class("TextBoxBorder");
		tbxcs.get_Border().set_CornerType((eCornerType)1);
		((Control)tbxcs).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		TextBoxX obj3 = tbxcs;
		location = new Point(97, 41);
		((Control)obj3).set_Location(location);
		((Control)tbxcs).set_Name("tbxcs");
		TextBoxX obj4 = tbxcs;
		size = new Size(170, 21);
		((Control)obj4).set_Size(size);
		((Control)tbxcs).set_TabIndex(0);
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX = LabelX1;
		location = new Point(31, 15);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		size = new Size(60, 23);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(1);
		LabelX1.set_Text("原参数");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX2).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX3 = LabelX2;
		location = new Point(31, 44);
		((Control)labelX3).set_Location(location);
		((Control)LabelX2).set_Name("LabelX2");
		LabelX labelX4 = LabelX2;
		size = new Size(60, 23);
		((Control)labelX4).set_Size(size);
		((Control)LabelX2).set_TabIndex(1);
		LabelX2.set_Text("新参数");
		((Control)btnC).set_AccessibleRole((AccessibleRole)43);
		btnC.set_ColorTable((eButtonColor)3);
		btnC.set_DialogResult((DialogResult)2);
		((Control)btnC).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj5 = btnC;
		location = new Point(192, 72);
		((Control)obj5).set_Location(location);
		((Control)btnC).set_Name("btnC");
		ButtonX obj6 = btnC;
		size = new Size(75, 23);
		((Control)obj6).set_Size(size);
		((PopupItemControl)btnC).set_Style((eDotNetBarStyle)7);
		((Control)btnC).set_TabIndex(2);
		btnC.set_Text("放弃修改");
		((Control)ButtonX1).set_AccessibleRole((AccessibleRole)43);
		ButtonX1.set_ColorTable((eButtonColor)3);
		ButtonX buttonX = ButtonX1;
		location = new Point(97, 72);
		((Control)buttonX).set_Location(location);
		((Control)ButtonX1).set_Name("ButtonX1");
		ButtonX buttonX2 = ButtonX1;
		size = new Size(75, 23);
		((Control)buttonX2).set_Size(size);
		((PopupItemControl)ButtonX1).set_Style((eDotNetBarStyle)7);
		((Control)ButtonX1).set_TabIndex(2);
		ButtonX1.set_Text("确认修改");
		((Control)btnok).set_AccessibleRole((AccessibleRole)43);
		btnok.set_ColorTable((eButtonColor)3);
		btnok.set_DialogResult((DialogResult)2);
		((Control)btnok).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj7 = btnok;
		location = new Point(97, 72);
		((Control)obj7).set_Location(location);
		((Control)btnok).set_Name("btnok");
		ButtonX obj8 = btnok;
		size = new Size(75, 23);
		((Control)obj8).set_Size(size);
		((PopupItemControl)btnok).set_Style((eDotNetBarStyle)7);
		((Control)btnok).set_TabIndex(2);
		btnok.set_Text("确认修改");
		((Form)this).set_AcceptButton((IButtonControl)(object)btnok);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)btnC);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(300, 109);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)btnok);
		((Control)this).get_Controls().Add((Control)(object)btnC);
		((Control)this).get_Controls().Add((Control)(object)LabelX2);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).get_Controls().Add((Control)(object)tbxcs);
		((Control)this).get_Controls().Add((Control)(object)tbycs);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("gxcs");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("参数值修改");
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
	}

	private void btnok_Click(object sender, EventArgs e)
	{
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if ((Operators.CompareString(Strings.Trim(((TextBox)tbxcs).get_Text()), "", false) != 0) & Conversions.ToBoolean(Strings.Trim(Conversions.ToString(((TextBox)tbxcs).get_Text().IndexOf("'") == -1))))
				{
					MyProject.Forms.cslr.w = false;
					Mod1.excelsheet = (Worksheet)Mod1.wb.Sheets.get_Item((object)Mod1.o);
					Mod1.excelsheet.Activate();
					if (MyProject.Forms.cslr.lslog.get_Items().get_Count() == 0)
					{
						MyProject.Forms.Main.lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 当前操作员对参数文件的修改如下："));
						MyProject.Forms.cslr.lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 部件：" + Mod1.bjlb1 + " 的参数文件 " + Mod1.cswj + " 已被修改"));
					}
					MyProject.Forms.cslr.lbcsz.get_Items().set_Item(MyProject.Forms.cslr.lbcsz.get_SelectedIndex(), (object)Strings.Trim(((TextBox)tbxcs).get_Text()));
					MyProject.Forms.cslr.lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 工作表：【" + MyProject.Forms.cslr.lbcsx.get_Text() + "】 的参数值第 " + Conversions.ToString(Convert.ToInt32(MyProject.Forms.cslr.lba.get_Text()) - 1) + " 行 " + Mod1.biaoji + " --> " + ((TextBox)tbxcs).get_Text()));
					if (MyProject.Forms.cslr.lslog.get_Items().get_Count() != 0)
					{
						MyProject.Forms.cslr.lslog.set_SelectedIndex(MyProject.Forms.cslr.lslog.get_Items().get_Count() - 1);
					}
					if (Operators.CompareString(MyProject.Forms.FrmOf.qyx, "qyxxn", false) == 0)
					{
						NewLateBinding.LateSetComplex(Mod1.excelsheet.Cells[MyProject.Forms.cslr.lba.get_Text(), 3], (Type)null, "Value", new object[1] { Strings.Trim(((TextBox)tbxcs).get_Text()) }, (string[])null, (Type[])null, false, true);
						NewLateBinding.LateSetComplex(Mod1.excelsheet.Cells[MyProject.Forms.cslr.lba.get_Text(), 7], (Type)null, "Value", new object[1] { Strings.Trim(((TextBox)tbxcs).get_Text()) }, (string[])null, (Type[])null, false, true);
					}
					else
					{
						NewLateBinding.LateSetComplex(Mod1.excelsheet.Cells[MyProject.Forms.cslr.lba.get_Text(), 3], (Type)null, "Value", new object[1] { Strings.Trim(((TextBox)tbxcs).get_Text()) }, (string[])null, (Type[])null, false, true);
					}
					Mod1.biaoji = "";
					((Component)(object)this).Dispose();
					((Control)MyProject.Forms.cslr.btnbcjg).set_Enabled(false);
					((Control)MyProject.Forms.cslr.btntqjl).set_Enabled(false);
					MyProject.Forms.cslr.STC.set_SelectedTabIndex(1);
					Mod1.Saved = false;
					((BaseItem)MyProject.Forms.Main.ToolsSave).set_Enabled(true);
					if (Operators.CompareString(Mod1.cswj, "截面i.xls", false) == 0)
					{
						Mod1.Saved = true;
						((BaseItem)MyProject.Forms.Main.ToolsSave).set_Enabled(false);
					}
				}
				else
				{
					Interaction.MsgBox((object)"请输入一个有效的值！！", (MsgBoxStyle)64, (object)"非法字符");
					MyProject.Forms.cslr.w = true;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void btnC_Click(object sender, EventArgs e)
	{
		MyProject.Forms.cslr.w = false;
		((Component)(object)this).Dispose();
	}

	private void gxcs_Load(object sender, EventArgs e)
	{
		((Control)tbxcs).Focus();
	}
}
