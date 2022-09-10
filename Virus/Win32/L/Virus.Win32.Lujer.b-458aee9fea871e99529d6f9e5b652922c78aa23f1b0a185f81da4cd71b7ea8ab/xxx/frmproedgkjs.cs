using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace xxx;

[DesignerGenerated]
public class frmproedgkjs : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("ll_frmsystem")]
	private GroupPanel _ll_frmsystem;

	[AccessedThroughProperty("ll_btncheckthis")]
	private ButtonX _ll_btncheckthis;

	[AccessedThroughProperty("CommandButton2")]
	private ButtonX _CommandButton2;

	[AccessedThroughProperty("ll_btnpath")]
	private ButtonX _ll_btnpath;

	[AccessedThroughProperty("CommandButton1")]
	private ButtonX _CommandButton1;

	[AccessedThroughProperty("ll_txtpath")]
	private TextBoxX _ll_txtpath;

	[AccessedThroughProperty("TextBox3")]
	private TextBoxX _TextBox3;

	[AccessedThroughProperty("TextBox1")]
	private TextBoxX _TextBox1;

	[AccessedThroughProperty("TextBox4")]
	private TextBoxX _TextBox4;

	[AccessedThroughProperty("LabelX7")]
	private LabelX _LabelX7;

	[AccessedThroughProperty("LabelX6")]
	private LabelX _LabelX6;

	[AccessedThroughProperty("LabelX4")]
	private LabelX _LabelX4;

	[AccessedThroughProperty("LabelX2")]
	private LabelX _LabelX2;

	[AccessedThroughProperty("LabelX5")]
	private LabelX _LabelX5;

	[AccessedThroughProperty("LabelX3")]
	private LabelX _LabelX3;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("ll_btnlocalrun")]
	private ButtonX _ll_btnlocalrun;

	[AccessedThroughProperty("ll_btnotherrun")]
	private ButtonX _ll_btnotherrun;

	[AccessedThroughProperty("ll_btnexit")]
	private ButtonX _ll_btnexit;

	[AccessedThroughProperty("LabelX8")]
	private LabelX _LabelX8;

	public string strpath;

	public string fname;

	internal virtual GroupPanel ll_frmsystem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_frmsystem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_frmsystem = value;
		}
	}

	internal virtual ButtonX ll_btncheckthis
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btncheckthis;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btncheckthis_Click;
			if (_ll_btncheckthis != null)
			{
				((Control)_ll_btncheckthis).remove_Click(eventHandler);
			}
			_ll_btncheckthis = value;
			if (_ll_btncheckthis != null)
			{
				((Control)_ll_btncheckthis).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX CommandButton2
	{
		[DebuggerNonUserCode]
		get
		{
			return _CommandButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CommandButton2 = value;
		}
	}

	internal virtual ButtonX ll_btnpath
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnpath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnpath_Click;
			if (_ll_btnpath != null)
			{
				((Control)_ll_btnpath).remove_Click(eventHandler);
			}
			_ll_btnpath = value;
			if (_ll_btnpath != null)
			{
				((Control)_ll_btnpath).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX CommandButton1
	{
		[DebuggerNonUserCode]
		get
		{
			return _CommandButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CommandButton1 = value;
		}
	}

	internal virtual TextBoxX ll_txtpath
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txtpath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txtpath = value;
		}
	}

	internal virtual TextBoxX TextBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox3 = value;
		}
	}

	internal virtual TextBoxX TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual TextBoxX TextBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox4 = value;
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

	internal virtual LabelX LabelX5
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX5 = value;
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

	internal virtual ButtonX ll_btnlocalrun
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnlocalrun;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnlocalrun_Click;
			if (_ll_btnlocalrun != null)
			{
				((Control)_ll_btnlocalrun).remove_Click(eventHandler);
			}
			_ll_btnlocalrun = value;
			if (_ll_btnlocalrun != null)
			{
				((Control)_ll_btnlocalrun).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnotherrun
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnotherrun;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_btnotherrun = value;
		}
	}

	internal virtual ButtonX ll_btnexit
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnexit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnexit_Click;
			if (_ll_btnexit != null)
			{
				((Control)_ll_btnexit).remove_Click(eventHandler);
			}
			_ll_btnexit = value;
			if (_ll_btnexit != null)
			{
				((Control)_ll_btnexit).add_Click(eventHandler);
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

	[DebuggerNonUserCode]
	public frmproedgkjs()
	{
		((Form)this).add_Load((EventHandler)proedgkjs_Load);
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
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_0e47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e51: Expected O, but got Unknown
		//IL_0ef3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efd: Expected O, but got Unknown
		ll_frmsystem = new GroupPanel();
		CommandButton2 = new ButtonX();
		CommandButton1 = new ButtonX();
		TextBox3 = new TextBoxX();
		TextBox1 = new TextBoxX();
		TextBox4 = new TextBoxX();
		LabelX7 = new LabelX();
		LabelX6 = new LabelX();
		LabelX4 = new LabelX();
		LabelX8 = new LabelX();
		LabelX2 = new LabelX();
		LabelX5 = new LabelX();
		LabelX3 = new LabelX();
		LabelX1 = new LabelX();
		ll_btncheckthis = new ButtonX();
		ll_btnpath = new ButtonX();
		ll_txtpath = new TextBoxX();
		ll_btnlocalrun = new ButtonX();
		ll_btnotherrun = new ButtonX();
		ll_btnexit = new ButtonX();
		((Control)ll_frmsystem).SuspendLayout();
		((Control)this).SuspendLayout();
		((PanelControl)ll_frmsystem).set_CanvasColor(SystemColors.Control);
		((PanelControl)ll_frmsystem).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)ll_frmsystem).get_Controls().Add((Control)(object)CommandButton2);
		((Control)ll_frmsystem).get_Controls().Add((Control)(object)CommandButton1);
		((Control)ll_frmsystem).get_Controls().Add((Control)(object)TextBox3);
		((Control)ll_frmsystem).get_Controls().Add((Control)(object)TextBox1);
		((Control)ll_frmsystem).get_Controls().Add((Control)(object)TextBox4);
		((Control)ll_frmsystem).get_Controls().Add((Control)(object)LabelX7);
		((Control)ll_frmsystem).get_Controls().Add((Control)(object)LabelX6);
		((Control)ll_frmsystem).get_Controls().Add((Control)(object)LabelX4);
		((Control)ll_frmsystem).get_Controls().Add((Control)(object)LabelX8);
		((Control)ll_frmsystem).get_Controls().Add((Control)(object)LabelX2);
		((Control)ll_frmsystem).get_Controls().Add((Control)(object)LabelX5);
		((Control)ll_frmsystem).get_Controls().Add((Control)(object)LabelX3);
		((Control)ll_frmsystem).get_Controls().Add((Control)(object)LabelX1);
		GroupPanel obj = ll_frmsystem;
		Point location = new Point(6, 3);
		((Control)obj).set_Location(location);
		((Control)ll_frmsystem).set_Name("ll_frmsystem");
		GroupPanel obj2 = ll_frmsystem;
		Size size = new Size(742, 216);
		((Control)obj2).set_Size(size);
		((PanelControl)ll_frmsystem).get_Style().set_BackColor2SchemePart((eColorSchemePart)52);
		((PanelControl)ll_frmsystem).get_Style().set_BackColorGradientAngle(90);
		((PanelControl)ll_frmsystem).get_Style().set_BackColorSchemePart((eColorSchemePart)51);
		((PanelControl)ll_frmsystem).get_Style().set_BorderBottom((eStyleBorderType)1);
		((PanelControl)ll_frmsystem).get_Style().set_BorderBottomWidth(1);
		((PanelControl)ll_frmsystem).get_Style().set_BorderColorSchemePart((eColorSchemePart)53);
		((PanelControl)ll_frmsystem).get_Style().set_BorderLeft((eStyleBorderType)1);
		((PanelControl)ll_frmsystem).get_Style().set_BorderLeftWidth(1);
		((PanelControl)ll_frmsystem).get_Style().set_BorderRight((eStyleBorderType)1);
		((PanelControl)ll_frmsystem).get_Style().set_BorderRightWidth(1);
		((PanelControl)ll_frmsystem).get_Style().set_BorderTop((eStyleBorderType)1);
		((PanelControl)ll_frmsystem).get_Style().set_BorderTopWidth(1);
		((PanelControl)ll_frmsystem).get_Style().set_Class("");
		((PanelControl)ll_frmsystem).get_Style().set_CornerDiameter(4);
		((PanelControl)ll_frmsystem).get_Style().set_CornerType((eCornerType)2);
		((PanelControl)ll_frmsystem).get_Style().set_TextAlignment((eStyleTextAlignment)1);
		((PanelControl)ll_frmsystem).get_Style().set_TextColorSchemePart((eColorSchemePart)54);
		((PanelControl)ll_frmsystem).get_Style().set_TextLineAlignment((eStyleTextAlignment)0);
		((PanelControl)ll_frmsystem).get_StyleMouseDown().set_Class("");
		((PanelControl)ll_frmsystem).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)ll_frmsystem).get_StyleMouseOver().set_Class("");
		((PanelControl)ll_frmsystem).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)ll_frmsystem).set_TabIndex(0);
		((Control)CommandButton2).set_AccessibleRole((AccessibleRole)43);
		CommandButton2.set_ColorTable((eButtonColor)3);
		ButtonX commandButton = CommandButton2;
		location = new Point(580, 174);
		((Control)commandButton).set_Location(location);
		((Control)CommandButton2).set_Name("CommandButton2");
		ButtonX commandButton2 = CommandButton2;
		size = new Size(145, 29);
		((Control)commandButton2).set_Size(size);
		((PopupItemControl)CommandButton2).set_Style((eDotNetBarStyle)7);
		((Control)CommandButton2).set_TabIndex(2);
		CommandButton2.set_Text("当前系统环境变量检查");
		((Control)CommandButton1).set_AccessibleRole((AccessibleRole)43);
		CommandButton1.set_ColorTable((eButtonColor)3);
		ButtonX commandButton3 = CommandButton1;
		location = new Point(429, 174);
		((Control)commandButton3).set_Location(location);
		((Control)CommandButton1).set_Name("CommandButton1");
		ButtonX commandButton4 = CommandButton1;
		size = new Size(145, 29);
		((Control)commandButton4).set_Size(size);
		((PopupItemControl)CommandButton1).set_Style((eDotNetBarStyle)7);
		((Control)CommandButton1).set_TabIndex(2);
		CommandButton1.set_Text("当前系统环境变量定义");
		TextBox3.get_Border().set_Class("TextBoxBorder");
		TextBox3.get_Border().set_CornerType((eCornerType)1);
		TextBoxX textBox = TextBox3;
		location = new Point(160, 142);
		((Control)textBox).set_Location(location);
		((Control)TextBox3).set_Name("TextBox3");
		TextBoxX textBox2 = TextBox3;
		size = new Size(565, 21);
		((Control)textBox2).set_Size(size);
		((Control)TextBox3).set_TabIndex(1);
		TextBox1.get_Border().set_Class("TextBoxBorder");
		TextBox1.get_Border().set_CornerType((eCornerType)1);
		TextBoxX textBox3 = TextBox1;
		location = new Point(160, 93);
		((Control)textBox3).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBoxX textBox4 = TextBox1;
		size = new Size(565, 21);
		((Control)textBox4).set_Size(size);
		((Control)TextBox1).set_TabIndex(1);
		TextBox4.get_Border().set_Class("TextBoxBorder");
		TextBox4.get_Border().set_CornerType((eCornerType)1);
		TextBoxX textBox5 = TextBox4;
		location = new Point(160, 47);
		((Control)textBox5).set_Location(location);
		((Control)TextBox4).set_Name("TextBox4");
		TextBoxX textBox6 = TextBox4;
		size = new Size(565, 21);
		((Control)textBox6).set_Size(size);
		((Control)TextBox4).set_TabIndex(1);
		((BaseItemControl)LabelX7).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX7).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX = LabelX7;
		location = new Point(8, 169);
		((Control)labelX).set_Location(location);
		((Control)LabelX7).set_Name("LabelX7");
		LabelX labelX2 = LabelX7;
		size = new Size(403, 34);
		((Control)labelX2).set_Size(size);
		((Control)LabelX7).set_TabIndex(0);
		LabelX7.set_Text("先在计算服务器上手工定义批处理过程,查看生成的mecbatch.bat文件,其中就有关于这三个系统环境变量的相关内容.");
		LabelX7.set_TextLineAlignment((StringAlignment)0);
		LabelX7.set_WordWrap(true);
		((BaseItemControl)LabelX6).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX6).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX3 = LabelX6;
		location = new Point(9, 143);
		((Control)labelX3).set_Location(location);
		((Control)LabelX6).set_Name("LabelX6");
		LabelX labelX4 = LabelX6;
		size = new Size(124, 12);
		((Control)labelX4).set_Size(size);
		((Control)LabelX6).set_TabIndex(0);
		LabelX6.set_Text("msengine_bat=");
		LabelX6.set_TextLineAlignment((StringAlignment)0);
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX5 = LabelX4;
		location = new Point(8, 96);
		((Control)labelX5).set_Location(location);
		((Control)LabelX4).set_Name("LabelX4");
		LabelX labelX6 = LabelX4;
		size = new Size(124, 15);
		((Control)labelX6).set_Size(size);
		((Control)LabelX4).set_TabIndex(0);
		LabelX4.set_Text("PTC_D_LICENSE_FILE=");
		LabelX4.set_TextLineAlignment((StringAlignment)0);
		((BaseItemControl)LabelX8).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX8).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX7 = LabelX8;
		location = new Point(8, 6);
		((Control)labelX7).set_Location(location);
		((Control)LabelX8).set_Name("LabelX8");
		LabelX labelX8 = LabelX8;
		size = new Size(217, 13);
		((Control)labelX8).set_Size(size);
		((Control)LabelX8).set_TabIndex(0);
		LabelX8.set_Text("计算用服务器系统环境变量设置说明");
		LabelX8.set_TextLineAlignment((StringAlignment)0);
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX9 = LabelX2;
		location = new Point(8, 51);
		((Control)labelX9).set_Location(location);
		((Control)LabelX2).set_Name("LabelX2");
		LabelX labelX10 = LabelX2;
		size = new Size(124, 13);
		((Control)labelX10).set_Size(size);
		((Control)LabelX2).set_TabIndex(0);
		LabelX2.set_Text("PRO_MECH_COMMAND=");
		LabelX2.set_TextLineAlignment((StringAlignment)0);
		((BaseItemControl)LabelX5).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX5).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX11 = LabelX5;
		location = new Point(8, 120);
		((Control)labelX11).set_Location(location);
		((Control)LabelX5).set_Name("LabelX5");
		LabelX labelX12 = LabelX5;
		size = new Size(430, 16);
		((Control)labelX12).set_Size(size);
		((Control)LabelX5).set_TabIndex(0);
		LabelX5.set_Text("msengine_bat=C:\\Program Files\\proeWildfire 4.0\\mech\\bin\\msengine.bat");
		LabelX5.set_TextLineAlignment((StringAlignment)0);
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX13 = LabelX3;
		location = new Point(8, 74);
		((Control)labelX13).set_Location(location);
		((Control)LabelX3).set_Name("LabelX3");
		LabelX labelX14 = LabelX3;
		size = new Size(403, 13);
		((Control)labelX14).set_Size(size);
		((Control)LabelX3).set_TabIndex(0);
		LabelX3.set_Text("PTC_D_LICENSE_FILE=D:\\DaRuanJian\\PROE4.0\\SHooTERS\\ptc_licfile.");
		LabelX3.set_TextLineAlignment((StringAlignment)0);
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX15 = LabelX1;
		location = new Point(8, 25);
		((Control)labelX15).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX16 = LabelX1;
		size = new Size(717, 16);
		((Control)labelX16).set_Size(size);
		((Control)LabelX1).set_TabIndex(0);
		LabelX1.set_Text("PRO_MECH_COMMAND=\"C:\\Program Files\\proeWildfire 4.0\\bin\\proe.exe\" \"C:\\Program Files\\proeWildfire 4.0\\bin\\proe1.psf\"");
		LabelX1.set_TextLineAlignment((StringAlignment)0);
		LabelX1.set_WordWrap(true);
		((Control)ll_btncheckthis).set_AccessibleRole((AccessibleRole)43);
		ll_btncheckthis.set_ColorTable((eButtonColor)3);
		ButtonX obj3 = ll_btncheckthis;
		location = new Point(169, 225);
		((Control)obj3).set_Location(location);
		((Control)ll_btncheckthis).set_Name("ll_btncheckthis");
		ButtonX obj4 = ll_btncheckthis;
		size = new Size(145, 27);
		((Control)obj4).set_Size(size);
		((PopupItemControl)ll_btncheckthis).set_Style((eDotNetBarStyle)7);
		((Control)ll_btncheckthis).set_TabIndex(2);
		ll_btncheckthis.set_Text("计算文件夹合理性检验");
		((Control)ll_btnpath).set_AccessibleRole((AccessibleRole)43);
		ll_btnpath.set_ColorTable((eButtonColor)3);
		ButtonX obj5 = ll_btnpath;
		location = new Point(18, 225);
		((Control)obj5).set_Location(location);
		((Control)ll_btnpath).set_Name("ll_btnpath");
		ButtonX obj6 = ll_btnpath;
		size = new Size(145, 27);
		((Control)obj6).set_Size(size);
		((PopupItemControl)ll_btnpath).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnpath).set_TabIndex(2);
		ll_btnpath.set_Text("指定计算文件所在文件夹");
		ll_txtpath.get_Border().set_Class("TextBoxBorder");
		ll_txtpath.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj7 = ll_txtpath;
		location = new Point(18, 258);
		((Control)obj7).set_Location(location);
		((Control)ll_txtpath).set_Name("ll_txtpath");
		((TextBoxBase)ll_txtpath).set_ReadOnly(true);
		TextBoxX obj8 = ll_txtpath;
		size = new Size(716, 21);
		((Control)obj8).set_Size(size);
		((Control)ll_txtpath).set_TabIndex(1);
		((Control)ll_btnlocalrun).set_AccessibleRole((AccessibleRole)43);
		ll_btnlocalrun.set_ColorTable((eButtonColor)3);
		ButtonX obj9 = ll_btnlocalrun;
		location = new Point(18, 286);
		((Control)obj9).set_Location(location);
		((Control)ll_btnlocalrun).set_Name("ll_btnlocalrun");
		ButtonX obj10 = ll_btnlocalrun;
		size = new Size(145, 28);
		((Control)obj10).set_Size(size);
		((PopupItemControl)ll_btnlocalrun).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnlocalrun).set_TabIndex(2);
		ll_btnlocalrun.set_Text("本机提交");
		((Control)ll_btnotherrun).set_AccessibleRole((AccessibleRole)43);
		ll_btnotherrun.set_ColorTable((eButtonColor)3);
		ButtonX obj11 = ll_btnotherrun;
		location = new Point(169, 286);
		((Control)obj11).set_Location(location);
		((Control)ll_btnotherrun).set_Name("ll_btnotherrun");
		ButtonX obj12 = ll_btnotherrun;
		size = new Size(145, 28);
		((Control)obj12).set_Size(size);
		((PopupItemControl)ll_btnotherrun).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnotherrun).set_TabIndex(2);
		ll_btnotherrun.set_Text("计算服务器提交");
		((Control)ll_btnexit).set_AccessibleRole((AccessibleRole)43);
		ll_btnexit.set_ColorTable((eButtonColor)3);
		ButtonX obj13 = ll_btnexit;
		location = new Point(589, 286);
		((Control)obj13).set_Location(location);
		((Control)ll_btnexit).set_Name("ll_btnexit");
		ButtonX obj14 = ll_btnexit;
		size = new Size(145, 28);
		((Control)obj14).set_Size(size);
		((PopupItemControl)ll_btnexit).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnexit).set_TabIndex(2);
		ll_btnexit.set_Text("关闭");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(754, 320);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ll_btncheckthis);
		((Control)this).get_Controls().Add((Control)(object)ll_btnotherrun);
		((Control)this).get_Controls().Add((Control)(object)ll_btnpath);
		((Control)this).get_Controls().Add((Control)(object)ll_frmsystem);
		((Control)this).get_Controls().Add((Control)(object)ll_btnlocalrun);
		((Control)this).get_Controls().Add((Control)(object)ll_txtpath);
		((Control)this).get_Controls().Add((Control)(object)ll_btnexit);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmproedgkjs");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("PROE4.0 多工况计算文件自动计算.. .");
		((Control)ll_frmsystem).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void proedgkjs_Load(object sender, EventArgs e)
	{
		((Control)ll_btnlocalrun).set_Enabled(false);
		((Control)ll_btnotherrun).set_Enabled(false);
		((Control)ll_frmsystem).set_Enabled(false);
		((Control)LabelX8).set_BackColor(Color.Transparent);
		((Control)LabelX1).set_BackColor(Color.Transparent);
		((Control)LabelX2).set_BackColor(Color.Transparent);
		((Control)LabelX3).set_BackColor(Color.Transparent);
		((Control)LabelX4).set_BackColor(Color.Transparent);
		((Control)LabelX5).set_BackColor(Color.Transparent);
		((Control)LabelX6).set_BackColor(Color.Transparent);
		((Control)LabelX7).set_BackColor(Color.Transparent);
	}

	private void ll_btnpath_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		FolderBrowserDialog val = new FolderBrowserDialog();
		val.set_Description("请指定已定义计算文件所在路径");
		((CommonDialog)val).ShowDialog();
		string selectedPath = val.get_SelectedPath();
		if (Operators.CompareString(selectedPath, "", false) != 0)
		{
			((TextBox)ll_txtpath).set_Text(selectedPath);
		}
		ll_btncheckthis_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void ll_btncheckthis_Click(object sender, EventArgs e)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		((Control)ll_btnlocalrun).set_Enabled(false);
		strpath = ((TextBox)ll_txtpath).get_Text();
		if (Operators.CompareString(Strings.Trim(strpath), "", false) == 0)
		{
			return;
		}
		if (!Directory.Exists(strpath))
		{
			Interaction.MsgBox((object)("当前输入路径不存在." + strpath), (MsgBoxStyle)0, (object)"提示");
			return;
		}
		string[] array = Strings.Split(strpath, " ", -1, (CompareMethod)0);
		if (Information.UBound((Array)array, 1) > 0)
		{
			Interaction.MsgBox((object)"** 当前指定的路径含有空格,请重新指定.", (MsgBoxStyle)0, (object)"提示");
			return;
		}
		array = Strings.Split(strpath, "\\", -1, (CompareMethod)0);
		if (Information.UBound((Array)array, 1) == 0)
		{
			Interaction.MsgBox((object)"** 当前指定的路径不合法.", (MsgBoxStyle)0, (object)"提示");
			return;
		}
		fname = strpath + "\\mecbatch.bat";
		if (!File.Exists(fname))
		{
			Interaction.MsgBox((object)("本地批量提交文件不存在:" + fname), (MsgBoxStyle)0, (object)"提示");
			return;
		}
		((Control)ll_btnlocalrun).set_Enabled(true);
		((Control)ll_btnlocalrun).set_ForeColor(Color.Green);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void ll_btnlocalrun_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Invalid comparison between Unknown and I4
		if ((int)MessageBox.Show("双击打开文件夹下的run.bat,执行批处理过程.是否开始?", "提示", (MessageBoxButtons)4, (MessageBoxIcon)64) != 6)
		{
			return;
		}
		strpath = ((TextBox)ll_txtpath).get_Text();
		fname = strpath + "\\mecbatch.bat";
		if (!File.Exists(fname))
		{
			Interaction.MsgBox((object)("不存在:" + fname), (MsgBoxStyle)0, (object)null);
			return;
		}
		string path = strpath + "\\run.bat";
		int num = 0;
		if (Operators.CompareString(Strings.Right(strpath, 1), "\\", false) != 0)
		{
			strpath += "\\";
		}
		string text = FileSystem.Dir(strpath, (FileAttribute)16);
		checked
		{
			while (Operators.CompareString(text, "", false) != 0)
			{
				if ((FileSystem.GetAttr(strpath + text) & 0x10) == 16 && ((Operators.CompareString(text, ".", false) != 0) & (Operators.CompareString(text, "..", false) != 0)))
				{
					num++;
				}
				text = FileSystem.Dir();
			}
			int num2 = num;
			num = 0;
			Mod1.wr = new StreamWriter(path, append: false, Encoding.Default);
			Mod1.wr.WriteLine("@title " + ((Form)this).get_Text());
			Mod1.wr.WriteLine("@echo 当前计算文件夹:" + strpath);
			Mod1.lr = new StreamReader(fname, Encoding.Default);
			string text2 = "";
			string text3 = default(string);
			while (!Information.IsNothing((object)text2))
			{
				text2 = Mod1.lr.ReadLine();
				if (Information.IsNothing((object)text2))
				{
					break;
				}
				text3 += text2;
				if (Operators.CompareString(text2, "", false) != 0)
				{
					string[] array = Strings.Split(text2, " ", -1, (CompareMethod)0);
					if (Information.UBound((Array)array, 1) >= 2 && ((Operators.CompareString(Strings.UCase(array[0]), "REM", false) == 0) & (Operators.CompareString(Strings.UCase(array[1]), "DESIGN", false) == 0) & (Operators.CompareString(Strings.UCase(array[2]), "STUDY", false) == 0)))
					{
						text2 = Strings.Replace(text2, "REM", "ECHO", 1, -1, (CompareMethod)0);
						num++;
						Mod1.wr.WriteLine("title " + ((Form)this).get_Text() + " 正在进行 [" + Conversions.ToString(num) + "/" + Conversions.ToString(num2) + "] ");
						Mod1.wr.WriteLine("echo.");
						Mod1.wr.WriteLine("date /t");
						Mod1.wr.WriteLine("time /t");
					}
				}
				Mod1.wr.WriteLine(text2);
			}
			Mod1.lr.Close();
			Mod1.lr.Dispose();
			Mod1.wr.WriteLine("echo.");
			Mod1.wr.WriteLine("echo.");
			Mod1.wr.WriteLine("echo **** 计算完毕,任意键结束当前计算过程 ****");
			Mod1.wr.WriteLine("pause>nul");
			Mod1.wr.Close();
			Mod1.wr.Dispose();
			Process.Start(strpath);
		}
	}

	private void ll_btnexit_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
