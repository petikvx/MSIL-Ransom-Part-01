using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class dcmk : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("btngb")]
	private ButtonX _btngb;

	[AccessedThroughProperty("btnlldqwjj")]
	private ButtonX _btnlldqwjj;

	[AccessedThroughProperty("btntqmk")]
	private ButtonX _btntqmk;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("LabelX7")]
	private LabelX _LabelX7;

	[AccessedThroughProperty("lbmxtp")]
	private ListBox _lbmxtp;

	[AccessedThroughProperty("GroupPanel1")]
	private GroupPanel _GroupPanel1;

	[AccessedThroughProperty("lbjslx")]
	private ListBox _lbjslx;

	[AccessedThroughProperty("LabelX8")]
	private LabelX _LabelX8;

	[AccessedThroughProperty("LabelX6")]
	private LabelX _LabelX6;

	[AccessedThroughProperty("LabelX4")]
	private LabelX _LabelX4;

	[AccessedThroughProperty("LabelX3")]
	private LabelX _LabelX3;

	[AccessedThroughProperty("LabelX2")]
	private LabelX _LabelX2;

	[AccessedThroughProperty("cmcsh")]
	private ComboBoxEx _cmcsh;

	[AccessedThroughProperty("cmbj")]
	private ComboBoxEx _cmbj;

	[AccessedThroughProperty("lbslwj")]
	private ListBox _lbslwj;

	[AccessedThroughProperty("lbcswj")]
	private ListBox _lbcswj;

	[AccessedThroughProperty("lbmxsm")]
	private LabelX _lbmxsm;

	private string path;

	private string path2;

	private string[] nn;

	private object list1;

	private string[] filename;

	private string bj;

	private string csh;

	private string jslx;

	private string slwj;

	public string qyx;

	private bool asm;

	private bool prt;

	private string f;

	private int pp;

	internal virtual PictureBox PictureBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox1_Click;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).remove_Click(eventHandler);
			}
			_PictureBox1 = value;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX btngb
	{
		[DebuggerNonUserCode]
		get
		{
			return _btngb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btngb_Click;
			if (_btngb != null)
			{
				((Control)_btngb).remove_Click(eventHandler);
			}
			_btngb = value;
			if (_btngb != null)
			{
				((Control)_btngb).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX btnlldqwjj
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnlldqwjj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnlldqwjj_Click;
			if (_btnlldqwjj != null)
			{
				((Control)_btnlldqwjj).remove_Click(eventHandler);
			}
			_btnlldqwjj = value;
			if (_btnlldqwjj != null)
			{
				((Control)_btnlldqwjj).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX btntqmk
	{
		[DebuggerNonUserCode]
		get
		{
			return _btntqmk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btntqmk_Click;
			if (_btntqmk != null)
			{
				((Control)_btntqmk).remove_Click(eventHandler);
			}
			_btntqmk = value;
			if (_btntqmk != null)
			{
				((Control)_btntqmk).add_Click(eventHandler);
			}
		}
	}

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

	internal virtual LabelX LabelX7
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX7 = value;
		}
	}

	internal virtual ListBox lbmxtp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbmxtp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lbmxtp_SelectedIndexChanged;
			if (_lbmxtp != null)
			{
				_lbmxtp.remove_SelectedIndexChanged(eventHandler);
			}
			_lbmxtp = value;
			if (_lbmxtp != null)
			{
				_lbmxtp.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual GroupPanel GroupPanel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupPanel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupPanel1 = value;
		}
	}

	internal virtual ListBox lbjslx
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbjslx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lbjslx_SelectedIndexChanged;
			if (_lbjslx != null)
			{
				_lbjslx.remove_SelectedIndexChanged(eventHandler);
			}
			_lbjslx = value;
			if (_lbjslx != null)
			{
				_lbjslx.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual LabelX LabelX8
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX8 = value;
		}
	}

	internal virtual LabelX LabelX6
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX6 = value;
		}
	}

	internal virtual LabelX LabelX4
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX4 = value;
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

	public virtual ComboBoxEx cmcsh
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmcsh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmcsh_SelectedIndexChanged;
			if (_cmcsh != null)
			{
				((ComboBox)_cmcsh).remove_SelectedIndexChanged(eventHandler);
			}
			_cmcsh = value;
			if (_cmcsh != null)
			{
				((ComboBox)_cmcsh).add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	public virtual ComboBoxEx cmbj
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmbj_SelectedIndexChanged;
			if (_cmbj != null)
			{
				((ComboBox)_cmbj).remove_SelectedIndexChanged(eventHandler);
			}
			_cmbj = value;
			if (_cmbj != null)
			{
				((ComboBox)_cmbj).add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual ListBox lbslwj
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbslwj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lbslwj_SelectedIndexChanged;
			if (_lbslwj != null)
			{
				_lbslwj.remove_SelectedIndexChanged(eventHandler);
			}
			_lbslwj = value;
			if (_lbslwj != null)
			{
				_lbslwj.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual ListBox lbcswj
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbcswj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lbcswj_SelectedIndexChanged;
			if (_lbcswj != null)
			{
				_lbcswj.remove_SelectedIndexChanged(eventHandler);
			}
			_lbcswj = value;
			if (_lbcswj != null)
			{
				_lbcswj.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual LabelX lbmxsm
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbmxsm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbmxsm = value;
		}
	}

	public dcmk()
	{
		((Form)this).add_Load((EventHandler)dcmk_Load);
		path = "";
		list1 = new ArrayList();
		asm = false;
		prt = false;
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
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected O, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected O, but got Unknown
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected O, but got Unknown
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected O, but got Unknown
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_084a: Expected O, but got Unknown
		//IL_090f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0919: Expected O, but got Unknown
		//IL_09d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dc: Expected O, but got Unknown
		//IL_0a86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a90: Expected O, but got Unknown
		//IL_0b37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b41: Expected O, but got Unknown
		//IL_0be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf2: Expected O, but got Unknown
		//IL_0c8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c94: Expected O, but got Unknown
		//IL_0d45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4f: Expected O, but got Unknown
		//IL_0dd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de2: Expected O, but got Unknown
		//IL_0e62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6c: Expected O, but got Unknown
		//IL_0f2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f37: Expected O, but got Unknown
		//IL_0fcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd5: Expected O, but got Unknown
		//IL_1098: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a2: Expected O, but got Unknown
		PictureBox1 = new PictureBox();
		btngb = new ButtonX();
		btnlldqwjj = new ButtonX();
		btntqmk = new ButtonX();
		LabelX1 = new LabelX();
		LabelX7 = new LabelX();
		lbmxtp = new ListBox();
		GroupPanel1 = new GroupPanel();
		lbjslx = new ListBox();
		LabelX8 = new LabelX();
		LabelX6 = new LabelX();
		LabelX4 = new LabelX();
		LabelX3 = new LabelX();
		LabelX2 = new LabelX();
		cmcsh = new ComboBoxEx();
		cmbj = new ComboBoxEx();
		lbslwj = new ListBox();
		lbcswj = new ListBox();
		lbmxsm = new LabelX();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)GroupPanel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)PictureBox1).set_BackgroundImageLayout((ImageLayout)2);
		PictureBox1.set_BorderStyle((BorderStyle)2);
		PictureBox pictureBox = PictureBox1;
		Point location = new Point(447, 31);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		Size size = new Size(396, 340);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_SizeMode((PictureBoxSizeMode)3);
		PictureBox1.set_TabIndex(32);
		PictureBox1.set_TabStop(false);
		((Control)btngb).set_AccessibleRole((AccessibleRole)43);
		btngb.set_ColorTable((eButtonColor)3);
		btngb.set_DialogResult((DialogResult)2);
		((Control)btngb).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj = btngb;
		location = new Point(724, 377);
		((Control)obj).set_Location(location);
		((Control)btngb).set_Name("btngb");
		ButtonX obj2 = btngb;
		size = new Size(119, 24);
		((Control)obj2).set_Size(size);
		((PopupItemControl)btngb).set_Style((eDotNetBarStyle)7);
		((Control)btngb).set_TabIndex(30);
		btngb.set_Text("关闭(&ESC)");
		((Control)btnlldqwjj).set_AccessibleRole((AccessibleRole)43);
		btnlldqwjj.set_ColorTable((eButtonColor)3);
		ButtonX obj3 = btnlldqwjj;
		location = new Point(271, 377);
		((Control)obj3).set_Location(location);
		((Control)btnlldqwjj).set_Name("btnlldqwjj");
		ButtonX obj4 = btnlldqwjj;
		size = new Size(174, 24);
		((Control)obj4).set_Size(size);
		((PopupItemControl)btnlldqwjj).set_Style((eDotNetBarStyle)7);
		((Control)btnlldqwjj).set_TabIndex(31);
		btnlldqwjj.set_Text("浏览当前库文件夹");
		((Control)btntqmk).set_AccessibleRole((AccessibleRole)43);
		btntqmk.set_ColorTable((eButtonColor)3);
		((Control)btntqmk).set_Enabled(false);
		((Control)btntqmk).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ButtonX obj5 = btntqmk;
		location = new Point(464, 377);
		((Control)obj5).set_Location(location);
		((Control)btntqmk).set_Name("btntqmk");
		ButtonX obj6 = btntqmk;
		size = new Size(244, 24);
		((Control)obj6).set_Size(size);
		((PopupItemControl)btntqmk).set_Style((eDotNetBarStyle)7);
		((Control)btntqmk).set_TabIndex(29);
		btntqmk.set_Text("提取当前显示处理模块至[新建库x模板]");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX = LabelX1;
		location = new Point(271, 6);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		size = new Size(91, 23);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(35);
		LabelX1.set_Text("模型实例图片");
		((Control)LabelX7).set_BackColor(Color.FromArgb(194, 217, 247));
		((BaseItemControl)LabelX7).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX7).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX7).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX3 = LabelX7;
		location = new Point(4, 408);
		((Control)labelX3).set_Location(location);
		((Control)LabelX7).set_Name("LabelX7");
		LabelX labelX4 = LabelX7;
		size = new Size(246, 15);
		((Control)labelX4).set_Size(size);
		((Control)LabelX7).set_TabIndex(36);
		LabelX7.set_Text("提示：");
		lbmxtp.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)lbmxtp).set_FormattingEnabled(true);
		lbmxtp.set_ItemHeight(12);
		ListBox obj7 = lbmxtp;
		location = new Point(271, 31);
		((Control)obj7).set_Location(location);
		((Control)lbmxtp).set_Name("lbmxtp");
		ListBox obj8 = lbmxtp;
		size = new Size(174, 340);
		((Control)obj8).set_Size(size);
		((Control)lbmxtp).set_TabIndex(33);
		((PanelControl)GroupPanel1).set_CanvasColor(SystemColors.Control);
		((PanelControl)GroupPanel1).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)lbjslx);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)LabelX3);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)LabelX2);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)cmcsh);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)cmbj);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)lbslwj);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)lbcswj);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)LabelX4);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)LabelX6);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)LabelX8);
		GroupPanel groupPanel = GroupPanel1;
		location = new Point(4, 6);
		((Control)groupPanel).set_Location(location);
		((Control)GroupPanel1).set_Name("GroupPanel1");
		GroupPanel groupPanel2 = GroupPanel1;
		size = new Size(261, 395);
		((Control)groupPanel2).set_Size(size);
		((PanelControl)GroupPanel1).get_Style().set_BackColor2SchemePart((eColorSchemePart)52);
		((PanelControl)GroupPanel1).get_Style().set_BackColorGradientAngle(90);
		((PanelControl)GroupPanel1).get_Style().set_BackColorSchemePart((eColorSchemePart)51);
		((PanelControl)GroupPanel1).get_Style().set_BorderBottom((eStyleBorderType)1);
		((PanelControl)GroupPanel1).get_Style().set_BorderBottomWidth(1);
		((PanelControl)GroupPanel1).get_Style().set_BorderColorSchemePart((eColorSchemePart)53);
		((PanelControl)GroupPanel1).get_Style().set_BorderLeft((eStyleBorderType)1);
		((PanelControl)GroupPanel1).get_Style().set_BorderLeftWidth(1);
		((PanelControl)GroupPanel1).get_Style().set_BorderRight((eStyleBorderType)1);
		((PanelControl)GroupPanel1).get_Style().set_BorderRightWidth(1);
		((PanelControl)GroupPanel1).get_Style().set_BorderTop((eStyleBorderType)1);
		((PanelControl)GroupPanel1).get_Style().set_BorderTopWidth(1);
		((PanelControl)GroupPanel1).get_Style().set_Class("");
		((PanelControl)GroupPanel1).get_Style().set_CornerDiameter(4);
		((PanelControl)GroupPanel1).get_Style().set_CornerType((eCornerType)2);
		((PanelControl)GroupPanel1).get_Style().set_TextAlignment((eStyleTextAlignment)1);
		((PanelControl)GroupPanel1).get_Style().set_TextColorSchemePart((eColorSchemePart)54);
		((PanelControl)GroupPanel1).get_Style().set_TextLineAlignment((eStyleTextAlignment)0);
		((PanelControl)GroupPanel1).get_StyleMouseDown().set_Class("");
		((PanelControl)GroupPanel1).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)GroupPanel1).get_StyleMouseOver().set_Class("");
		((PanelControl)GroupPanel1).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)GroupPanel1).set_TabIndex(26);
		lbjslx.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)lbjslx).set_FormattingEnabled(true);
		lbjslx.set_ItemHeight(12);
		ListBox obj9 = lbjslx;
		location = new Point(6, 195);
		((Control)obj9).set_Location(location);
		((Control)lbjslx).set_Name("lbjslx");
		ListBox obj10 = lbjslx;
		size = new Size(242, 88);
		((Control)obj10).set_Size(size);
		((Control)lbjslx).set_TabIndex(10);
		((Control)LabelX8).set_BackColor(Color.FromArgb(194, 217, 247));
		((BaseItemControl)LabelX8).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX8).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX8).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX5 = LabelX8;
		location = new Point(7, 289);
		((Control)labelX5).set_Location(location);
		((Control)LabelX8).set_Name("LabelX8");
		LabelX labelX6 = LabelX8;
		size = new Size(66, 15);
		((Control)labelX6).set_Size(size);
		((Control)LabelX8).set_TabIndex(14);
		LabelX8.set_Text("实例文件");
		((Control)LabelX6).set_BackColor(Color.FromArgb(194, 217, 247));
		((BaseItemControl)LabelX6).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX6).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX6).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX7 = LabelX6;
		location = new Point(7, 174);
		((Control)labelX7).set_Location(location);
		((Control)LabelX6).set_Name("LabelX6");
		LabelX labelX8 = LabelX6;
		size = new Size(66, 15);
		((Control)labelX8).set_Size(size);
		((Control)LabelX6).set_TabIndex(14);
		LabelX6.set_Text("计算类型");
		((Control)LabelX4).set_BackColor(SystemColors.InactiveCaptionText);
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX4).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX9 = LabelX4;
		location = new Point(6, 95);
		((Control)labelX9).set_Location(location);
		((Control)LabelX4).set_Name("LabelX4");
		LabelX labelX10 = LabelX4;
		size = new Size(68, 15);
		((Control)labelX10).set_Size(size);
		((Control)LabelX4).set_TabIndex(14);
		LabelX4.set_Text("参数文件");
		((Control)LabelX3).set_BackColor(SystemColors.InactiveCaptionText);
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX3).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX11 = LabelX3;
		location = new Point(6, 47);
		((Control)labelX11).set_Location(location);
		((Control)LabelX3).set_Name("LabelX3");
		LabelX labelX12 = LabelX3;
		size = new Size(107, 15);
		((Control)labelX12).set_Size(size);
		((Control)LabelX3).set_TabIndex(14);
		LabelX3.set_Text("参数化库/实例库");
		((Control)LabelX2).set_BackColor(SystemColors.InactiveCaptionText);
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX2).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX13 = LabelX2;
		location = new Point(7, 3);
		((Control)labelX13).set_Location(location);
		((Control)LabelX2).set_Name("LabelX2");
		LabelX labelX14 = LabelX2;
		size = new Size(66, 15);
		((Control)labelX14).set_Size(size);
		((Control)LabelX2).set_TabIndex(14);
		LabelX2.set_Text("部件列表");
		((ListControl)cmcsh).set_DisplayMember("Text");
		((ComboBox)cmcsh).set_DrawMode((DrawMode)1);
		((ComboBox)cmcsh).set_DropDownStyle((ComboBoxStyle)2);
		((Control)cmcsh).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)cmcsh).set_FormattingEnabled(true);
		((ComboBox)cmcsh).set_ItemHeight(15);
		ComboBoxEx obj11 = cmcsh;
		location = new Point(6, 68);
		((Control)obj11).set_Location(location);
		((Control)cmcsh).set_Name("cmcsh");
		ComboBoxEx obj12 = cmcsh;
		size = new Size(242, 21);
		((Control)obj12).set_Size(size);
		cmcsh.set_Style((eDotNetBarStyle)7);
		((Control)cmcsh).set_TabIndex(12);
		((ListControl)cmbj).set_DisplayMember("Text");
		((ComboBox)cmbj).set_DrawMode((DrawMode)1);
		((ComboBox)cmbj).set_DropDownStyle((ComboBoxStyle)2);
		((Control)cmbj).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)cmbj).set_FormattingEnabled(true);
		((ComboBox)cmbj).set_ItemHeight(15);
		ComboBoxEx obj13 = cmbj;
		location = new Point(6, 20);
		((Control)obj13).set_Location(location);
		((Control)cmbj).set_Name("cmbj");
		ComboBoxEx obj14 = cmbj;
		size = new Size(242, 21);
		((Control)obj14).set_Size(size);
		cmbj.set_Style((eDotNetBarStyle)7);
		((Control)cmbj).set_TabIndex(12);
		lbslwj.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)lbslwj).set_FormattingEnabled(true);
		lbslwj.set_ItemHeight(12);
		ListBox obj15 = lbslwj;
		location = new Point(6, 310);
		((Control)obj15).set_Location(location);
		((Control)lbslwj).set_Name("lbslwj");
		ListBox obj16 = lbslwj;
		size = new Size(242, 76);
		((Control)obj16).set_Size(size);
		((Control)lbslwj).set_TabIndex(11);
		lbcswj.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)lbcswj).set_FormattingEnabled(true);
		lbcswj.set_ItemHeight(12);
		ListBox obj17 = lbcswj;
		location = new Point(6, 116);
		((Control)obj17).set_Location(location);
		((Control)lbcswj).set_Name("lbcswj");
		ListBox obj18 = lbcswj;
		size = new Size(242, 52);
		((Control)obj18).set_Size(size);
		((Control)lbcswj).set_TabIndex(6);
		((Control)lbmxsm).set_BackColor(Color.FromArgb(194, 217, 247));
		((BaseItemControl)lbmxsm).get_BackgroundStyle().set_Class("");
		((BaseItemControl)lbmxsm).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)lbmxsm).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX obj19 = lbmxsm;
		location = new Point(4, 429);
		((Control)obj19).set_Location(location);
		((Control)lbmxsm).set_Name("lbmxsm");
		LabelX obj20 = lbmxsm;
		size = new Size(839, 62);
		((Control)obj20).set_Size(size);
		((Control)lbmxsm).set_TabIndex(34);
		lbmxsm.set_TextLineAlignment((StringAlignment)0);
		lbmxsm.set_WordWrap(true);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)btngb);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(849, 504);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)btngb);
		((Control)this).get_Controls().Add((Control)(object)btnlldqwjj);
		((Control)this).get_Controls().Add((Control)(object)btntqmk);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).get_Controls().Add((Control)(object)LabelX7);
		((Control)this).get_Controls().Add((Control)(object)lbmxtp);
		((Control)this).get_Controls().Add((Control)(object)GroupPanel1);
		((Control)this).get_Controls().Add((Control)(object)lbmxsm);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("dcmk");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("提取当前显示处理模块至[新建库x模板]...");
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)GroupPanel1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void dcmk_Load(object sender, EventArgs e)
	{
		((Control)LabelX2).set_BackColor(Color.Transparent);
		((Control)LabelX3).set_BackColor(Color.Transparent);
		((Control)LabelX4).set_BackColor(Color.Transparent);
		((Control)LabelX6).set_BackColor(Color.Transparent);
		((Control)LabelX8).set_BackColor(Color.Transparent);
		if (cmbj.get_Items().get_Count() == 0)
		{
			bjlb();
		}
		else
		{
			Addxls();
		}
		Check();
	}

	public void bjlb()
	{
		try
		{
			path = Mod1.Kulujing;
			if (Operators.CompareString(Strings.Right(path, 1), "\\", false) != 0)
			{
				path += "\\";
			}
			path2 = path + "mlibs.lis";
			Mod1.lr = new StreamReader(path2, Encoding.Default);
			f = "";
			while (!Information.IsNothing((object)f))
			{
				f = Mod1.lr.ReadLine();
				if (Information.IsNothing((object)f))
				{
					break;
				}
				nn = f.Split(new char[1] { ',' });
				cmbj.get_Items().Add((object)nn[0]);
				object obj = list1;
				object[] array = new object[1];
				string[] array2 = nn;
				int num = 1;
				array[0] = array2[1];
				object[] array3 = array;
				bool[] array4 = new bool[1] { true };
				NewLateBinding.LateCall(obj, (Type)null, "Add", array3, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					array2[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(string));
				}
			}
			Mod1.lr.Close();
			Mod1.lr.Dispose();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void Addxls()
	{
		if (Operators.CompareString(Strings.Trim(((ComboBox)cmcsh).get_Text()), "实例模型", false) == 0 || !((Operators.CompareString(path, "", false) != 0) & (Operators.CompareString(((ComboBox)cmcsh).get_Text(), "", false) != 0)))
		{
			return;
		}
		lbcswj.get_Items().Clear();
		string text = path;
		object obj = list1;
		object[] array = new object[1];
		ComboBoxEx val = cmbj;
		array[0] = ((ComboBox)val).get_SelectedIndex();
		object[] array2 = array;
		bool[] array3 = new bool[1] { true };
		object obj2 = NewLateBinding.LateGet(obj, (Type)null, "item", array2, (string[])null, (Type[])null, array3);
		if (array3[0])
		{
			((ComboBox)val).set_SelectedIndex((int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int)));
		}
		checked
		{
			if (Directory.Exists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)text, obj2), (object)"\\csh\\cs"))))
			{
				string text2 = path;
				object obj3 = list1;
				object[] array4 = new object[1];
				ComboBoxEx val2 = cmbj;
				array4[0] = ((ComboBox)val2).get_SelectedIndex();
				object[] array5 = array4;
				bool[] array6 = new bool[1] { true };
				object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "item", array5, (string[])null, (Type[])null, array6);
				if (array6[0])
				{
					((ComboBox)val2).set_SelectedIndex((int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(int)));
				}
				Mod1.file = Directory.GetFiles(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)text2, obj4), (object)"\\csh\\cs")), "*.xls", SearchOption.AllDirectories);
				int num = Mod1.file.Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					Mod1.list = Mod1.file;
					lbcswj.get_Items().Add((object)Mod1.file[i].Substring(Mod1.file[i].LastIndexOf("\\") + 1));
				}
			}
		}
	}

	private void cmbj_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (!((Operators.CompareString(bj, "", false) == 0) | (Operators.CompareString(bj, ((ComboBox)cmbj).get_Text(), false) != 0)))
			{
				return;
			}
			bj = ((ComboBox)cmbj).get_Text();
			csh = "";
			lbcswj.get_Items().Clear();
			lbjslx.get_Items().Clear();
			lbslwj.get_Items().Clear();
			cmcsh.get_Items().Clear();
			lbmxtp.get_Items().Clear();
			lbmxsm.set_Text("");
			jslx = "";
			Check();
			PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\config\\" + Mod1.bb + "\\ll521.bmp");
			if (Operators.CompareString(Strings.Trim(((ComboBox)cmbj).get_Text()), "", false) != 0)
			{
				object obj = list1;
				object[] array = new object[1];
				object[] array2 = array;
				ComboBoxEx val = cmbj;
				array2[0] = ((ComboBox)val).get_SelectedIndex();
				object[] array3 = array;
				object[] array4 = array3;
				bool[] array5 = new bool[1] { true };
				object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Item", array4, (string[])null, (Type[])null, array5);
				if (array5[0])
				{
					((ComboBox)val).set_SelectedIndex((int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(int)));
				}
				qyx = Conversions.ToString(obj2);
				string text = path;
				object obj3 = list1;
				object[] array6 = new object[1];
				ComboBoxEx val2 = cmbj;
				array6[0] = ((ComboBox)val2).get_SelectedIndex();
				object[] array7 = array6;
				bool[] array8 = new bool[1] { true };
				object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "Item", array7, (string[])null, (Type[])null, array8);
				if (array8[0])
				{
					((ComboBox)val2).set_SelectedIndex((int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array7[0]), typeof(int)));
				}
				object obj5 = Operators.ConcatenateObject(Operators.ConcatenateObject((object)text, obj4), (object)"\\");
				object obj6 = list1;
				array3 = new object[1];
				object[] array9 = array3;
				val = cmbj;
				array9[0] = ((ComboBox)val).get_SelectedIndex();
				array = array3;
				object[] array10 = array;
				array5 = new bool[1] { true };
				object obj7 = NewLateBinding.LateGet(obj6, (Type)null, "Item", array10, (string[])null, (Type[])null, array5);
				if (array5[0])
				{
					((ComboBox)val).set_SelectedIndex((int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int)));
				}
				path2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(obj5, obj7), (object)".lis"));
				if (!File.Exists(path2))
				{
					Interaction.MsgBox((object)"读取的文件不存在，该选项无效！！", (MsgBoxStyle)64, (object)"错误的选项");
					return;
				}
				Mod1.lr = new StreamReader(path2, Encoding.Default);
				f = "";
				while (!Information.IsNothing((object)f))
				{
					f = Mod1.lr.ReadLine();
					if (Information.IsNothing((object)f))
					{
						break;
					}
					cmcsh.get_Items().Add((object)f);
				}
			}
			Mod1.lr.Close();
			Mod1.lr.Dispose();
			if (Operators.CompareString(Mod1.bjlb1, "", false) == 0)
			{
				Mod1.bjlb1 = ((ComboBox)cmbj).get_Text();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void cmcsh_SelectedIndexChanged(object sender, EventArgs e)
	{
		lbcswj.get_Items().Clear();
		lbjslx.get_Items().Clear();
		lbslwj.get_Items().Clear();
		ComboBoxEx val = cmcsh;
		string text = ((ComboBox)val).get_Text();
		string text2 = Mod1.toen(ref text);
		((ComboBox)val).set_Text(text);
		if (Operators.CompareString(text2, "", false) == 0)
		{
			return;
		}
		jslx = "";
		if (Operators.CompareString(Strings.Trim(((ComboBox)cmcsh).get_Text()), "实例模型", false) == 0)
		{
			string text3 = path;
			object obj = list1;
			object[] array = new object[1];
			object[] array2 = array;
			ComboBoxEx val2 = cmbj;
			array2[0] = ((ComboBox)val2).get_SelectedIndex();
			object[] array3 = array;
			object[] array4 = array3;
			bool[] array5 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Item", array4, (string[])null, (Type[])null, array5);
			if (array5[0])
			{
				((ComboBox)val2).set_SelectedIndex((int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(int)));
			}
			object obj3 = Operators.ConcatenateObject(Operators.ConcatenateObject((object)text3, obj2), (object)"\\");
			val = cmcsh;
			text = ((ComboBox)val).get_Text();
			string text4 = Mod1.toen(ref text);
			((ComboBox)val).set_Text(text);
			path2 = Conversions.ToString(Operators.ConcatenateObject(obj3, (object)text4));
			string text5 = path2;
			val2 = cmcsh;
			text = ((ComboBox)val2).get_Text();
			string text6 = Mod1.toen(ref text);
			((ComboBox)val2).set_Text(text);
			Mod1.lr = new StreamReader(text5 + "\\" + text6 + ".lis", Encoding.Default);
			f = "";
			while (!Information.IsNothing((object)f))
			{
				f = Mod1.lr.ReadLine();
				if (Information.IsNothing((object)f))
				{
					break;
				}
				if (Operators.CompareString(Mod1.toen(ref f), "", false) != 0)
				{
					lbjslx.get_Items().Add((object)f);
				}
			}
			Mod1.lr.Close();
			Mod1.lr.Dispose();
		}
		else
		{
			Check();
			string text7 = path;
			object obj4 = list1;
			object[] array3 = new object[1];
			object[] array6 = array3;
			val = cmbj;
			array6[0] = ((ComboBox)val).get_SelectedIndex();
			object[] array = array3;
			object[] array7 = array;
			bool[] array5 = new bool[1] { true };
			object obj5 = NewLateBinding.LateGet(obj4, (Type)null, "Item", array7, (string[])null, (Type[])null, array5);
			if (array5[0])
			{
				((ComboBox)val).set_SelectedIndex((int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int)));
			}
			object obj6 = Operators.ConcatenateObject(Operators.ConcatenateObject((object)text7, obj5), (object)"\\");
			ComboBoxEx val2 = cmcsh;
			text = ((ComboBox)val2).get_Text();
			string text8 = Mod1.toen(ref text);
			((ComboBox)val2).set_Text(text);
			path2 = Conversions.ToString(Operators.ConcatenateObject(obj6, (object)text8));
			string text9 = path2;
			val2 = cmcsh;
			text = ((ComboBox)val2).get_Text();
			string text10 = Mod1.toen(ref text);
			((ComboBox)val2).set_Text(text);
			Mod1.lr = new StreamReader(text9 + "\\" + text10 + ".lis", Encoding.Default);
			f = "";
			while (!Information.IsNothing((object)f))
			{
				f = Mod1.lr.ReadLine();
				if (Information.IsNothing((object)f))
				{
					break;
				}
				if (Operators.CompareString(Mod1.toen(ref f), "", false) != 0)
				{
					lbjslx.get_Items().Add((object)f);
				}
			}
			Mod1.lr.Close();
			Mod1.lr.Dispose();
		}
		Addxls();
	}

	private void lbjslx_SelectedIndexChanged(object sender, EventArgs e)
	{
		checked
		{
			if ((Operators.CompareString(jslx, "", false) == 0) | (Operators.CompareString(jslx, lbjslx.get_Text(), false) != 0))
			{
				lbslwj.get_Items().Clear();
				lbmxtp.get_Items().Clear();
				slwj = "";
				jslx = lbjslx.get_Text();
				PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\config\\ll521.bmp");
				lbmxsm.set_Text("");
				if (Operators.CompareString(Strings.Trim(lbjslx.get_Text()), "", false) != 0)
				{
					ListBox val = lbjslx;
					string text = val.get_Text();
					string text2 = Mod1.toen(ref text);
					val.set_Text(text);
					if (Operators.CompareString(text2, "", false) == 0)
					{
						return;
					}
					lbslwj.get_Items().Clear();
					string text3 = path2;
					val = lbjslx;
					text = val.get_Text();
					string text4 = Mod1.toen(ref text);
					val.set_Text(text);
					Mod1.file1 = Directory.GetDirectories(text3 + "\\" + text4);
					int num = Mod1.file1.Count() - 1;
					for (int i = 0; i <= num; i++)
					{
						Mod1.file1[i] = Mod1.file1[i].Substring(Mod1.file1[i].LastIndexOf("\\") + 1);
						if ((Operators.CompareString(Strings.UCase(Mod1.file1[i]), Strings.UCase("cstemp"), false) != 0) & (Operators.CompareString(Strings.UCase(Mod1.file1[i]), Strings.UCase("tempxls"), false) != 0))
						{
							lbslwj.get_Items().Add((object)Mod1.file1[i]);
						}
					}
					if (lbslwj.get_Items().get_Count() != 0)
					{
						if (lbjslx.get_SelectedIndex() < lbslwj.get_Items().get_Count())
						{
							lbslwj.set_SelectedIndex(lbjslx.get_SelectedIndex());
						}
						else
						{
							lbslwj.set_SelectedIndex(0);
						}
					}
				}
			}
			Check();
		}
	}

	private void lbslwj_SelectedIndexChanged(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				pp = 0;
				if ((Operators.CompareString(slwj, "", false) == 0) | ((Operators.CompareString(slwj, lbslwj.get_Text(), false) != 0) & (Operators.CompareString(Strings.Trim(lbslwj.get_Text()), "", false) != 0)))
				{
					slwj = lbslwj.get_Text();
					lbmxtp.get_Items().Clear();
					PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\config\\ll521.bmp");
					lbmxsm.set_Text("");
					Check();
					string[] array = new string[5] { path2, "\\", null, null, null };
					string[] array2 = array;
					ListBox val = lbjslx;
					string text = val.get_Text();
					string text2 = Mod1.toen(ref text);
					val.set_Text(text);
					array2[2] = text2;
					array[3] = "\\";
					array[4] = lbslwj.get_Text();
					Mod1.file1 = Directory.GetFiles(string.Concat(array), "*.jpg", SearchOption.TopDirectoryOnly);
					if (Mod1.file1.Count() != 0)
					{
						PictureBox1.set_ImageLocation(Mod1.file1[0]);
						int num = Mod1.file1.Count() - 1;
						for (int i = 0; i <= num; i++)
						{
							lbmxtp.get_Items().Add((object)Mod1.file1[i].Substring(Mod1.file1[i].LastIndexOf("\\") + 1));
							lbmxtp.set_SelectedIndex(0);
						}
					}
					array = new string[6] { path2, "\\", null, null, null, null };
					string[] array3 = array;
					val = lbjslx;
					text = val.get_Text();
					string text3 = Mod1.toen(ref text);
					val.set_Text(text);
					array3[2] = text3;
					array[3] = "\\";
					array[4] = lbslwj.get_Text();
					array[5] = "\\README.TXT";
					if (File.Exists(string.Concat(array)))
					{
						string[] array4 = new string[6] { path2, "\\", null, null, null, null };
						ListBox val2 = lbjslx;
						string text4 = val2.get_Text();
						string text5 = Mod1.toen(ref text4);
						val2.set_Text(text4);
						array4[2] = text5;
						array4[3] = "\\";
						array4[4] = lbslwj.get_Text();
						array4[5] = "\\README.TXT";
						Mod1.lr = new StreamReader(string.Concat(array4), Encoding.Default);
						lbmxsm.set_Text(Mod1.lr.ReadLine());
						Mod1.lr.Close();
						Mod1.lr.Dispose();
					}
				}
				else
				{
					PictureBox1.set_ImageLocation(Application.get_StartupPath() + "\\config\\ll521.bmp");
				}
				if (lbmxtp.get_SelectedIndex() != -1)
				{
					PictureBox1.set_ImageLocation(Mod1.file1[lbmxtp.get_SelectedIndex()]);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void lbmxtp_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (lbmxtp.get_SelectedIndex() != -1)
		{
			Mod1.t = lbmxtp.get_SelectedIndex();
			PictureBox1.set_ImageLocation(Mod1.file1[lbmxtp.get_SelectedIndex()].ToString());
		}
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
		checked
		{
			if (lbmxtp.get_Items().get_Count() != 0)
			{
				pp++;
				if (pp < lbmxtp.get_Items().get_Count())
				{
					lbmxtp.set_SelectedIndex(pp);
				}
				else if (lbmxtp.get_Items().get_Count() != 0)
				{
					pp = 0;
					lbmxtp.set_SelectedIndex(0);
				}
			}
		}
	}

	private void btnlldqwjj_Click(object sender, EventArgs e)
	{
		if (lbslwj.get_Items().get_Count() != 0)
		{
			string[] array = new string[5] { path2, "\\", null, null, null };
			ListBox val = lbjslx;
			string text = val.get_Text();
			string text2 = Mod1.toen(ref text);
			val.set_Text(text);
			array[2] = text2;
			array[3] = "\\";
			array[4] = lbslwj.get_Text();
			Process.Start(string.Concat(array));
		}
	}

	private void btntqmk_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		FolderBrowserDialog val = new FolderBrowserDialog();
		val.set_Description("请选择保存路径");
		((CommonDialog)val).ShowDialog();
		string text = val.get_SelectedPath();
		if (Directory.Exists(text) && Operators.CompareString(text, "", false) != 0)
		{
			((Control)this).set_Cursor(Cursors.get_AppStarting());
			if (Operators.CompareString(Strings.Right(text, 1), "\\", false) != 0)
			{
				text += "\\";
			}
			Directory.CreateDirectory(text + "xls文件");
			Directory.CreateDirectory(text + "实例文件夹");
			FileSystemProxy fileSystem = ((ServerComputer)MyProject.Computer).get_FileSystem();
			string[] array = new string[5] { path2, "\\", null, null, null };
			ListBox val2 = lbjslx;
			string text2 = val2.get_Text();
			string text3 = Mod1.toen(ref text2);
			val2.set_Text(text2);
			array[2] = text3;
			array[3] = "\\";
			array[4] = lbslwj.get_Text();
			fileSystem.CopyDirectory(string.Concat(array), text + "实例文件夹\\\\" + lbslwj.get_Text());
			if (Operators.CompareString(((ComboBox)cmcsh).get_Text(), "参数化模型", false) == 0)
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(path2 + "\\cs\\" + lbcswj.get_Text(), text + "xls文件\\" + lbcswj.get_Text(), true);
			}
			((Control)this).set_Cursor(Cursors.get_Arrow());
			Interaction.MsgBox((object)"导出成功！", (MsgBoxStyle)64, (object)"成功");
		}
	}

	public void Check()
	{
		if (Operators.CompareString(((ComboBox)cmcsh).get_Text(), "实例模型", false) == 0)
		{
			if ((Operators.CompareString(lbjslx.get_Text(), "", false) != 0) & (Operators.CompareString(lbslwj.get_Text(), "", false) != 0))
			{
				((Control)btntqmk).set_Enabled(true);
			}
			else
			{
				((Control)btntqmk).set_Enabled(false);
			}
		}
		else if ((Operators.CompareString(((ComboBox)cmbj).get_Text(), "", false) == 0) | (Operators.CompareString(((ComboBox)cmcsh).get_Text(), "", false) == 0) | (Operators.CompareString(lbcswj.get_Text(), "", false) == 0) | (Operators.CompareString(lbjslx.get_Text(), "", false) == 0) | (Operators.CompareString(lbslwj.get_Text(), "", false) == 0))
		{
			((Control)btntqmk).set_Enabled(false);
		}
		else
		{
			((Control)btntqmk).set_Enabled(true);
		}
	}

	private void lbcswj_SelectedIndexChanged(object sender, EventArgs e)
	{
		Check();
	}

	private void btngb_Click(object sender, EventArgs e)
	{
		MyProject.Forms.mxkgl.log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员关闭了导出块对话框"));
		((Component)(object)this).Dispose();
	}
}
