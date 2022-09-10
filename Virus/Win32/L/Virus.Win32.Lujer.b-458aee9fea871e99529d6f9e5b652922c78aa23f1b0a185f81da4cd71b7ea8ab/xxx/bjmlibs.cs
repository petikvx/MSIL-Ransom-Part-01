using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class bjmlibs : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("log")]
	private ListBox _log;

	[AccessedThroughProperty("bc")]
	private ButtonX _bc;

	[AccessedThroughProperty("yz")]
	private ButtonX _yz;

	[AccessedThroughProperty("xy")]
	private ButtonX _xy;

	[AccessedThroughProperty("sy")]
	private ButtonX _sy;

	[AccessedThroughProperty("gb")]
	private ButtonX _gb;

	[AccessedThroughProperty("scbjm")]
	private ButtonX _scbjm;

	[AccessedThroughProperty("bjbjm")]
	private ButtonX _bjbjm;

	[AccessedThroughProperty("tjbjm")]
	private ButtonX _tjbjm;

	[AccessedThroughProperty("LabelX2")]
	private LabelX _LabelX2;

	[AccessedThroughProperty("qkbj")]
	private ButtonX _qkbj;

	[AccessedThroughProperty("zrbj")]
	private ButtonX _zrbj;

	[AccessedThroughProperty("bjname")]
	private ListBox _bjname;

	[AccessedThroughProperty("LabelX3")]
	private LabelX _LabelX3;

	[AccessedThroughProperty("Dir0")]
	private ListBox _Dir0;

	private string f;

	private bool ky;

	private string[] nn;

	private int index;

	private string[] bjnn;

	public ArrayList YS;

	public string[] dirr;

	public ArrayList mlibsdir;

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

	internal virtual ListBox log
	{
		[DebuggerNonUserCode]
		get
		{
			return _log;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_log = value;
		}
	}

	internal virtual ButtonX bc
	{
		[DebuggerNonUserCode]
		get
		{
			return _bc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = bc_Click;
			if (_bc != null)
			{
				((Control)_bc).remove_Click(eventHandler);
			}
			_bc = value;
			if (_bc != null)
			{
				((Control)_bc).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX yz
	{
		[DebuggerNonUserCode]
		get
		{
			return _yz;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = yz_Click;
			if (_yz != null)
			{
				((Control)_yz).remove_Click(eventHandler);
			}
			_yz = value;
			if (_yz != null)
			{
				((Control)_yz).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX xy
	{
		[DebuggerNonUserCode]
		get
		{
			return _xy;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = xy_Click;
			if (_xy != null)
			{
				((Control)_xy).remove_Click(eventHandler);
			}
			_xy = value;
			if (_xy != null)
			{
				((Control)_xy).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX sy
	{
		[DebuggerNonUserCode]
		get
		{
			return _sy;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = sy_Click;
			if (_sy != null)
			{
				((Control)_sy).remove_Click(eventHandler);
			}
			_sy = value;
			if (_sy != null)
			{
				((Control)_sy).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX gb
	{
		[DebuggerNonUserCode]
		get
		{
			return _gb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = gb_Click;
			if (_gb != null)
			{
				((Control)_gb).remove_Click(eventHandler);
			}
			_gb = value;
			if (_gb != null)
			{
				((Control)_gb).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX scbjm
	{
		[DebuggerNonUserCode]
		get
		{
			return _scbjm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = scbjm_Click;
			if (_scbjm != null)
			{
				((Control)_scbjm).remove_Click(eventHandler);
			}
			_scbjm = value;
			if (_scbjm != null)
			{
				((Control)_scbjm).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX bjbjm
	{
		[DebuggerNonUserCode]
		get
		{
			return _bjbjm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = bjbjm_Click;
			if (_bjbjm != null)
			{
				((Control)_bjbjm).remove_Click(eventHandler);
			}
			_bjbjm = value;
			if (_bjbjm != null)
			{
				((Control)_bjbjm).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX tjbjm
	{
		[DebuggerNonUserCode]
		get
		{
			return _tjbjm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = tjbjm_Click;
			if (_tjbjm != null)
			{
				((Control)_tjbjm).remove_Click(eventHandler);
			}
			_tjbjm = value;
			if (_tjbjm != null)
			{
				((Control)_tjbjm).add_Click(eventHandler);
			}
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

	internal virtual ButtonX qkbj
	{
		[DebuggerNonUserCode]
		get
		{
			return _qkbj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = qkbj_Click;
			if (_qkbj != null)
			{
				((Control)_qkbj).remove_Click(eventHandler);
			}
			_qkbj = value;
			if (_qkbj != null)
			{
				((Control)_qkbj).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX zrbj
	{
		[DebuggerNonUserCode]
		get
		{
			return _zrbj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = zrbj_Click;
			if (_zrbj != null)
			{
				((Control)_zrbj).remove_Click(eventHandler);
			}
			_zrbj = value;
			if (_zrbj != null)
			{
				((Control)_zrbj).add_Click(eventHandler);
			}
		}
	}

	public virtual ListBox bjname
	{
		[DebuggerNonUserCode]
		get
		{
			return _bjname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = bjname_DoubleClick;
			EventHandler eventHandler2 = bjname_SelectedIndexChanged;
			if (_bjname != null)
			{
				((Control)_bjname).remove_DoubleClick(eventHandler);
				_bjname.remove_SelectedIndexChanged(eventHandler2);
			}
			_bjname = value;
			if (_bjname != null)
			{
				((Control)_bjname).add_DoubleClick(eventHandler);
				_bjname.add_SelectedIndexChanged(eventHandler2);
			}
		}
	}

	internal virtual LabelX LabelX3
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX3 = value;
		}
	}

	public virtual ListBox Dir0
	{
		[DebuggerNonUserCode]
		get
		{
			return _Dir0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = bjname_DoubleClick;
			EventHandler eventHandler2 = bjname_SelectedIndexChanged;
			if (_Dir0 != null)
			{
				((Control)_Dir0).remove_DoubleClick(eventHandler);
				_Dir0.remove_SelectedIndexChanged(eventHandler2);
			}
			_Dir0 = value;
			if (_Dir0 != null)
			{
				((Control)_Dir0).add_DoubleClick(eventHandler);
				_Dir0.add_SelectedIndexChanged(eventHandler2);
			}
		}
	}

	public bjmlibs()
	{
		((Form)this).add_Load((EventHandler)bjmlibs_Load);
		YS = new ArrayList();
		mlibsdir = new ArrayList();
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
		//IL_08e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08eb: Expected O, but got Unknown
		//IL_0a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2f: Expected O, but got Unknown
		LabelX1 = new LabelX();
		bjname = new ListBox();
		log = new ListBox();
		bc = new ButtonX();
		yz = new ButtonX();
		xy = new ButtonX();
		sy = new ButtonX();
		gb = new ButtonX();
		scbjm = new ButtonX();
		bjbjm = new ButtonX();
		tjbjm = new ButtonX();
		LabelX2 = new LabelX();
		qkbj = new ButtonX();
		zrbj = new ButtonX();
		LabelX3 = new LabelX();
		Dir0 = new ListBox();
		((Control)this).SuspendLayout();
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX = LabelX1;
		Point location = new Point(325, 12);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		Size size = new Size(147, 15);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(0);
		LabelX1.set_Text("部件中文名,英文名");
		((ListControl)bjname).set_FormattingEnabled(true);
		bjname.set_ItemHeight(12);
		ListBox obj = bjname;
		location = new Point(325, 33);
		((Control)obj).set_Location(location);
		((Control)bjname).set_Name("bjname");
		ListBox obj2 = bjname;
		size = new Size(174, 136);
		((Control)obj2).set_Size(size);
		((Control)bjname).set_TabIndex(1);
		((ListControl)log).set_FormattingEnabled(true);
		log.set_ItemHeight(12);
		ListBox obj3 = log;
		location = new Point(199, 200);
		((Control)obj3).set_Location(location);
		((Control)log).set_Name("log");
		ListBox obj4 = log;
		size = new Size(418, 124);
		((Control)obj4).set_Size(size);
		((Control)log).set_TabIndex(1);
		((Control)bc).set_AccessibleRole((AccessibleRole)43);
		bc.set_ColorTable((eButtonColor)3);
		((Control)bc).set_Enabled(false);
		ButtonX obj5 = bc;
		location = new Point(505, 118);
		((Control)obj5).set_Location(location);
		((Control)bc).set_Name("bc");
		ButtonX obj6 = bc;
		size = new Size(112, 23);
		((Control)obj6).set_Size(size);
		((PopupItemControl)bc).set_Style((eDotNetBarStyle)7);
		((Control)bc).set_TabIndex(7);
		bc.set_Text("保存修改");
		((Control)yz).set_AccessibleRole((AccessibleRole)43);
		yz.set_ColorTable((eButtonColor)3);
		ButtonX obj7 = yz;
		location = new Point(505, 89);
		((Control)obj7).set_Location(location);
		((Control)yz).set_Name("yz");
		ButtonX obj8 = yz;
		size = new Size(112, 23);
		((Control)obj8).set_Size(size);
		((PopupItemControl)yz).set_Style((eDotNetBarStyle)7);
		((Control)yz).set_TabIndex(11);
		yz.set_Text("验证部件有效性");
		((Control)xy).set_AccessibleRole((AccessibleRole)43);
		xy.set_ColorTable((eButtonColor)3);
		ButtonX obj9 = xy;
		location = new Point(505, 60);
		((Control)obj9).set_Location(location);
		((Control)xy).set_Name("xy");
		ButtonX obj10 = xy;
		size = new Size(112, 23);
		((Control)obj10).set_Size(size);
		((PopupItemControl)xy).set_Style((eDotNetBarStyle)7);
		((Control)xy).set_TabIndex(10);
		xy.set_Text("下移");
		((Control)sy).set_AccessibleRole((AccessibleRole)43);
		sy.set_ColorTable((eButtonColor)3);
		ButtonX obj11 = sy;
		location = new Point(505, 31);
		((Control)obj11).set_Location(location);
		((Control)sy).set_Name("sy");
		ButtonX obj12 = sy;
		size = new Size(112, 23);
		((Control)obj12).set_Size(size);
		((PopupItemControl)sy).set_Style((eDotNetBarStyle)7);
		((Control)sy).set_TabIndex(13);
		sy.set_Text("上移");
		((Control)gb).set_AccessibleRole((AccessibleRole)43);
		gb.set_ColorTable((eButtonColor)3);
		gb.set_DialogResult((DialogResult)2);
		ButtonX obj13 = gb;
		location = new Point(505, 147);
		((Control)obj13).set_Location(location);
		((Control)gb).set_Name("gb");
		ButtonX obj14 = gb;
		size = new Size(112, 23);
		((Control)obj14).set_Size(size);
		((PopupItemControl)gb).set_Style((eDotNetBarStyle)7);
		((Control)gb).set_TabIndex(9);
		gb.set_Text("关闭");
		((Control)scbjm).set_AccessibleRole((AccessibleRole)43);
		scbjm.set_ColorTable((eButtonColor)3);
		ButtonX obj15 = scbjm;
		location = new Point(199, 91);
		((Control)obj15).set_Location(location);
		((Control)scbjm).set_Name("scbjm");
		ButtonX obj16 = scbjm;
		size = new Size(112, 23);
		((Control)obj16).set_Size(size);
		((PopupItemControl)scbjm).set_Style((eDotNetBarStyle)7);
		((Control)scbjm).set_TabIndex(6);
		scbjm.set_Text("删除部件名称");
		((Control)bjbjm).set_AccessibleRole((AccessibleRole)43);
		bjbjm.set_ColorTable((eButtonColor)3);
		ButtonX obj17 = bjbjm;
		location = new Point(199, 62);
		((Control)obj17).set_Location(location);
		((Control)bjbjm).set_Name("bjbjm");
		ButtonX obj18 = bjbjm;
		size = new Size(112, 23);
		((Control)obj18).set_Size(size);
		((PopupItemControl)bjbjm).set_Style((eDotNetBarStyle)7);
		((Control)bjbjm).set_TabIndex(5);
		bjbjm.set_Text("编辑部件名称");
		((Control)tjbjm).set_AccessibleRole((AccessibleRole)43);
		tjbjm.set_ColorTable((eButtonColor)3);
		ButtonX obj19 = tjbjm;
		location = new Point(199, 33);
		((Control)obj19).set_Location(location);
		((Control)tjbjm).set_Name("tjbjm");
		ButtonX obj20 = tjbjm;
		size = new Size(112, 23);
		((Control)obj20).set_Size(size);
		((PopupItemControl)tjbjm).set_Style((eDotNetBarStyle)7);
		((Control)tjbjm).set_TabIndex(8);
		tjbjm.set_Text("添加部件名称");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX3 = LabelX2;
		location = new Point(199, 176);
		((Control)labelX3).set_Location(location);
		((Control)LabelX2).set_Name("LabelX2");
		LabelX labelX4 = LabelX2;
		size = new Size(58, 19);
		((Control)labelX4).set_Size(size);
		((Control)LabelX2).set_TabIndex(4);
		LabelX2.set_Text("输出信息");
		((Control)qkbj).set_AccessibleRole((AccessibleRole)43);
		qkbj.set_ColorTable((eButtonColor)3);
		ButtonX obj21 = qkbj;
		location = new Point(199, 120);
		((Control)obj21).set_Location(location);
		((Control)qkbj).set_Name("qkbj");
		ButtonX obj22 = qkbj;
		size = new Size(112, 23);
		((Control)obj22).set_Size(size);
		((PopupItemControl)qkbj).set_Style((eDotNetBarStyle)7);
		((Control)qkbj).set_TabIndex(13);
		qkbj.set_Text("清空当前部件列表");
		((Control)zrbj).set_AccessibleRole((AccessibleRole)43);
		zrbj.set_ColorTable((eButtonColor)3);
		ButtonX obj23 = zrbj;
		location = new Point(199, 149);
		((Control)obj23).set_Location(location);
		((Control)zrbj).set_Name("zrbj");
		ButtonX obj24 = zrbj;
		size = new Size(112, 23);
		((Control)obj24).set_Size(size);
		((PopupItemControl)zrbj).set_Style((eDotNetBarStyle)7);
		((Control)zrbj).set_TabIndex(10);
		zrbj.set_Text("重新载入部件名称");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX5 = LabelX3;
		location = new Point(7, 12);
		((Control)labelX5).set_Location(location);
		((Control)LabelX3).set_Name("LabelX3");
		LabelX labelX6 = LabelX3;
		size = new Size(193, 15);
		((Control)labelX6).set_Size(size);
		((Control)LabelX3).set_TabIndex(0);
		LabelX3.set_Text("当前模型库目录存在的所有文件夹");
		((ListControl)Dir0).set_FormattingEnabled(true);
		Dir0.set_ItemHeight(12);
		ListBox dir = Dir0;
		location = new Point(7, 33);
		((Control)dir).set_Location(location);
		((Control)Dir0).set_Name("Dir0");
		ListBox dir2 = Dir0;
		size = new Size(181, 292);
		((Control)dir2).set_Size(size);
		((Control)Dir0).set_TabIndex(1);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)gb);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f));
		size = new Size(626, 333);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)bc);
		((Control)this).get_Controls().Add((Control)(object)yz);
		((Control)this).get_Controls().Add((Control)(object)zrbj);
		((Control)this).get_Controls().Add((Control)(object)xy);
		((Control)this).get_Controls().Add((Control)(object)qkbj);
		((Control)this).get_Controls().Add((Control)(object)sy);
		((Control)this).get_Controls().Add((Control)(object)gb);
		((Control)this).get_Controls().Add((Control)(object)scbjm);
		((Control)this).get_Controls().Add((Control)(object)bjbjm);
		((Control)this).get_Controls().Add((Control)(object)tjbjm);
		((Control)this).get_Controls().Add((Control)(object)log);
		((Control)this).get_Controls().Add((Control)(object)Dir0);
		((Control)this).get_Controls().Add((Control)(object)LabelX3);
		((Control)this).get_Controls().Add((Control)(object)bjname);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).get_Controls().Add((Control)(object)LabelX2);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("bjmlibs");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("编辑当前库【mlibs.lis】文件");
		((Control)this).ResumeLayout(false);
	}

	private void bjmlibs_Load(object sender, EventArgs e)
	{
		if (File.Exists(Mod1.Kulujing + "mlibs.lis"))
		{
			bjname.get_Items().Clear();
			if (Dir0.get_Items().get_Count() == 0)
			{
				GetDir();
			}
			Readmlibs();
		}
		dirr = Directory.GetDirectories(Mod1.Kulujing);
	}

	public void Readmlibs()
	{
		f = "";
		YS.Clear();
		bjname.get_Items().Clear();
		Mod1.lr = new StreamReader(Mod1.Kulujing + "mlibs.lis", Encoding.Default);
		while (!Information.IsNothing((object)f))
		{
			f = Mod1.lr.ReadLine();
			if (Information.IsNothing((object)f))
			{
				break;
			}
			bjname.get_Items().Add((object)f);
			YS.Add(f);
			nn = f.Split(new char[1] { ',' });
			mlibsdir.Add(nn[1]);
		}
		Mod1.lr.Close();
		Mod1.lr.Dispose();
	}

	private void tjbjm_Click(object sender, EventArgs e)
	{
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(Dir0.get_Text(), "", false) != 0)
		{
			((Form)MyProject.Forms.tjbj).set_Text("添加部件名称");
			((TextBox)MyProject.Forms.tjbj.bjch).set_Text("");
			if (Dir0.get_SelectedIndex() != -1)
			{
				((TextBox)MyProject.Forms.tjbj.bjen).set_Text(Dir0.get_Text());
				((Control)MyProject.Forms.tjbj.bjen).Focus();
			}
			((Form)MyProject.Forms.tjbj).ShowDialog();
			((Component)(object)MyProject.Forms.tjbj).Dispose();
		}
		else
		{
			Interaction.MsgBox((object)"请在左侧选择一个要添加的英文名称.", (MsgBoxStyle)64, (object)"提示");
		}
	}

	private void bjbjm_Click(object sender, EventArgs e)
	{
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(bjname.get_Text(), "", false) != 0)
		{
			((Form)MyProject.Forms.tjbj).set_Text("编辑部件名称");
			bjnn = bjname.get_Text().Split(new char[1] { ',' });
			((TextBox)MyProject.Forms.tjbj.bjch).set_Text(bjnn[0]);
			((TextBox)MyProject.Forms.tjbj.bjen).set_Text(bjnn[1]);
			MyProject.Forms.tjbj.index = index;
			((Control)MyProject.Forms.tjbj.bjch).Focus();
			((Form)MyProject.Forms.tjbj).ShowDialog();
			((Component)(object)MyProject.Forms.tjbj).Dispose();
		}
		else
		{
			Interaction.MsgBox((object)"请在右侧选择一个要编辑的部件！", (MsgBoxStyle)64, (object)"提示");
		}
	}

	private void bjname_SelectedIndexChanged(object sender, EventArgs e)
	{
		index = bjname.get_SelectedIndex();
	}

	private void zrbj_Click(object sender, EventArgs e)
	{
		((Control)bc).set_Enabled(false);
		bjname.get_Items().Clear();
		Readmlibs();
	}

	private void scbjm_Click(object sender, EventArgs e)
	{
		if (bjname.get_SelectedIndex() != -1)
		{
			((Control)bc).set_Enabled(false);
			log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员删除：" + bjname.get_Text()));
			bjname.get_Items().RemoveAt(bjname.get_SelectedIndex());
		}
	}

	private void qkbj_Click(object sender, EventArgs e)
	{
		((Control)bc).set_Enabled(false);
		bjname.get_Items().Clear();
	}

	private void sy_Click(object sender, EventArgs e)
	{
		((Control)bc).set_Enabled(false);
		checked
		{
			if ((bjname.get_SelectedIndex() != 0) & (bjname.get_SelectedIndex() != -1))
			{
				string text = bjname.get_Text();
				int selectedIndex = bjname.get_SelectedIndex();
				bjname.get_Items().set_Item(selectedIndex, RuntimeHelpers.GetObjectValue(bjname.get_Items().get_Item(selectedIndex - 1)));
				bjname.get_Items().set_Item(selectedIndex - 1, (object)text);
				bjname.set_SelectedIndex(selectedIndex - 1);
			}
		}
	}

	private void xy_Click(object sender, EventArgs e)
	{
		((Control)bc).set_Enabled(false);
		checked
		{
			if ((bjname.get_SelectedIndex() != bjname.get_Items().get_Count() - 1) & (bjname.get_SelectedIndex() != -1))
			{
				string text = bjname.get_Text();
				int selectedIndex = bjname.get_SelectedIndex();
				bjname.get_Items().set_Item(selectedIndex, RuntimeHelpers.GetObjectValue(bjname.get_Items().get_Item(selectedIndex + 1)));
				bjname.get_Items().set_Item(selectedIndex + 1, (object)text);
				bjname.set_SelectedIndex(selectedIndex + 1);
			}
		}
	}

	private void bjname_DoubleClick(object sender, EventArgs e)
	{
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(bjname.get_Text(), "", false) != 0)
		{
			((Form)MyProject.Forms.tjbj).set_Text("编辑部件名称");
			bjnn = bjname.get_Text().Split(new char[1] { ',' });
			((TextBox)MyProject.Forms.tjbj.bjch).set_Text(bjnn[0]);
			((TextBox)MyProject.Forms.tjbj.bjen).set_Text(bjnn[1]);
			MyProject.Forms.tjbj.index = index;
			((Form)MyProject.Forms.tjbj).ShowDialog();
			((Component)(object)MyProject.Forms.tjbj).Dispose();
		}
		else
		{
			Interaction.MsgBox((object)"请选择一个要编辑的部件！", (MsgBoxStyle)64, (object)"提示");
		}
	}

	private void yz_Click(object sender, EventArgs e)
	{
		ky = true;
		Readmlibs1();
		checked
		{
			if (bjname.get_Items().get_Count() != 0)
			{
				if (YS.Count == bjname.get_Items().get_Count())
				{
					ky = false;
					int num = YS.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.ConditionalCompareObjectNotEqual(YS[i], bjname.get_Items().get_Item(i), false))
						{
							ky = true;
							break;
						}
					}
				}
				int num2 = bjname.get_Items().get_Count() - 1;
				for (int j = 0; j <= num2; j++)
				{
					string text = Conversions.ToString(bjname.get_Items().get_Item(j));
					string[] array = text.Split(new char[1] { ',' });
					if (!Directory.Exists(Mod1.Kulujing + array[1]))
					{
						ky = false;
						log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " " + array[0] + " 部件对应的 " + array[1] + " 文件夹不存在，"));
						log.get_Items().Add((object)"没有通过验证！");
						log.set_SelectedIndex(log.get_Items().get_Count() - 1);
					}
					else
					{
						log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " " + array[0] + " 部件通过验证."));
					}
				}
			}
			else
			{
				ky = false;
				log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 当前部件名称列表不能为空!"));
			}
			Readmlibs1();
			int num3 = dirr.Length - 1;
			int num5 = default(int);
			for (int k = 0; k <= num3; k++)
			{
				string text = dirr[k].Substring(dirr[k].LastIndexOf("\\") + 1);
				int num4 = mlibsdir.Count - 1;
				for (int l = 0; l <= num4; l++)
				{
					if (Operators.ConditionalCompareObjectNotEqual((object)text, mlibsdir[l], false))
					{
						num5++;
					}
				}
				if (num5 == mlibsdir.Count)
				{
					log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " mlibs.lis 中不存在 " + text + " 对应的部件名称！"));
					log.get_Items().Add((object)"请使用 【添加部件名称】按钮添加该部件。");
				}
				num5 = 0;
			}
			mlibsdir.Clear();
			if (ky)
			{
				((Control)bc).set_Enabled(true);
			}
			else
			{
				((Control)bc).set_Enabled(false);
			}
			log.set_SelectedIndex(log.get_Items().get_Count() - 1);
		}
	}

	private void gb_Click(object sender, EventArgs e)
	{
		checked
		{
			if (log.get_Items().get_Count() != 0)
			{
				int num = log.get_Items().get_Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					MyProject.Forms.mxkgl.log.get_Items().Add(RuntimeHelpers.GetObjectValue(log.get_Items().get_Item(i)));
				}
			}
			log.get_Items().Clear();
			MyProject.Forms.mxkgl.log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员关闭了编辑当前库mlibs.lis文件对话框"));
			((Form)this).Close();
		}
	}

	private void bc_Click(object sender, EventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Invalid comparison between Unknown and I4
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		if (File.Exists(Mod1.Kulujing + "mlibs.lis"))
		{
			if ((int)MessageBox.Show("是否保存当前修改的结果？", "重要提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 6)
			{
				Updatamlibs();
				Interaction.MsgBox((object)"保存完成！", (MsgBoxStyle)64, (object)"保存");
				((Control)bc).set_Enabled(false);
				((Component)(object)MyProject.Forms.FrmOf).Dispose();
				log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员保存了修改的结果！"));
			}
			if ((int)MessageBox.Show("是否同时更新与产品对应的源库列表文件？", "重要提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 6)
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Mod1.Kulujing + "\\mlibs.lis", Application.get_StartupPath() + "\\Config\\" + Mod1.bb + "\\mlibs.lis", true);
			}
		}
		else
		{
			Interaction.MsgBox((object)"当前模型库中不存在【mlibs.lis】文件！", (MsgBoxStyle)64, (object)"保存");
		}
	}

	public void Updatamlibs()
	{
		Mod1.wr = new StreamWriter(Mod1.Kulujing + "mlibs.lis", append: false, Encoding.Default);
		checked
		{
			int num = bjname.get_Items().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				Mod1.wr.WriteLine(RuntimeHelpers.GetObjectValue(bjname.get_Items().get_Item(i)));
			}
			Mod1.wr.Close();
			Mod1.wr.Dispose();
		}
	}

	public void Readmlibs1()
	{
		f = "";
		YS.Clear();
		Mod1.lr = new StreamReader(Mod1.Kulujing + "mlibs.lis", Encoding.Default);
		while (!Information.IsNothing((object)f))
		{
			f = Mod1.lr.ReadLine();
			if (Information.IsNothing((object)f))
			{
				break;
			}
			nn = f.Split(new char[1] { ',' });
			mlibsdir.Add(nn[1]);
			YS.Add(f);
		}
		Mod1.lr.Close();
		Mod1.lr.Dispose();
	}

	public void GetDir()
	{
		string[] directories = Directory.GetDirectories(Mod1.Kulujing);
		checked
		{
			int num = directories.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = directories[i].Substring(directories[i].LastIndexOf("\\") + 1);
				Dir0.get_Items().Add((object)text);
			}
		}
	}
}
