using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class mxkgl : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("RibbonControl1")]
	private RibbonControl _RibbonControl1;

	[AccessedThroughProperty("RibbonPanel1")]
	private RibbonPanel _RibbonPanel1;

	[AccessedThroughProperty("RibbonTabItem1")]
	private RibbonTabItem _RibbonTabItem1;

	[AccessedThroughProperty("QatCustomizeItem1")]
	private QatCustomizeItem _QatCustomizeItem1;

	[AccessedThroughProperty("scbj")]
	private RibbonBar _scbj;

	[AccessedThroughProperty("zjbj1")]
	private ButtonItem _zjbj1;

	[AccessedThroughProperty("btndcbj")]
	private ButtonItem _btndcbj;

	[AccessedThroughProperty("ButtonItem3")]
	private ButtonItem _ButtonItem3;

	[AccessedThroughProperty("jcbj")]
	private ButtonItem _jcbj;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("RibbonPanel2")]
	private RibbonPanel _RibbonPanel2;

	[AccessedThroughProperty("RibbonBar2")]
	private RibbonBar _RibbonBar2;

	[AccessedThroughProperty("drk")]
	private ButtonItem _drk;

	[AccessedThroughProperty("RibbonPanel3")]
	private RibbonPanel _RibbonPanel3;

	[AccessedThroughProperty("RibbonTabItem2")]
	private RibbonTabItem _RibbonTabItem2;

	[AccessedThroughProperty("RibbonTabItem3")]
	private RibbonTabItem _RibbonTabItem3;

	[AccessedThroughProperty("RibbonBar3")]
	private RibbonBar _RibbonBar3;

	[AccessedThroughProperty("btnbjmlibs")]
	private ButtonItem _btnbjmlibs;

	[AccessedThroughProperty("gxk")]
	private ButtonItem _gxk;

	[AccessedThroughProperty("dck")]
	private ButtonItem _dck;

	[AccessedThroughProperty("LabelX2")]
	private LabelX _LabelX2;

	[AccessedThroughProperty("gb")]
	private ButtonX _gb;

	[AccessedThroughProperty("log")]
	private ListBox _log;

	private string n;

	private string f;

	private string[] nn;

	private ArrayList list1;

	private ArrayList bjname;

	private ArrayList pp;

	internal virtual RibbonControl RibbonControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RibbonControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RibbonControl1 = value;
		}
	}

	internal virtual RibbonPanel RibbonPanel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RibbonPanel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RibbonPanel1 = value;
		}
	}

	internal virtual RibbonTabItem RibbonTabItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RibbonTabItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RibbonTabItem1 = value;
		}
	}

	internal virtual QatCustomizeItem QatCustomizeItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _QatCustomizeItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_QatCustomizeItem1 = value;
		}
	}

	internal virtual RibbonBar scbj
	{
		[DebuggerNonUserCode]
		get
		{
			return _scbj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_scbj = value;
		}
	}

	internal virtual ButtonItem zjbj1
	{
		[DebuggerNonUserCode]
		get
		{
			return _zjbj1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = zjbj1_Click;
			if (_zjbj1 != null)
			{
				((BaseItem)_zjbj1).remove_Click(eventHandler);
			}
			_zjbj1 = value;
			if (_zjbj1 != null)
			{
				((BaseItem)_zjbj1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonItem btndcbj
	{
		[DebuggerNonUserCode]
		get
		{
			return _btndcbj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btndcbj_Click;
			if (_btndcbj != null)
			{
				((BaseItem)_btndcbj).remove_Click(eventHandler);
			}
			_btndcbj = value;
			if (_btndcbj != null)
			{
				((BaseItem)_btndcbj).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonItem ButtonItem3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ButtonItem3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ButtonItem3_Click;
			if (_ButtonItem3 != null)
			{
				((BaseItem)_ButtonItem3).remove_Click(eventHandler);
			}
			_ButtonItem3 = value;
			if (_ButtonItem3 != null)
			{
				((BaseItem)_ButtonItem3).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonItem jcbj
	{
		[DebuggerNonUserCode]
		get
		{
			return _jcbj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = jcbj_Click;
			if (_jcbj != null)
			{
				((BaseItem)_jcbj).remove_Click(eventHandler);
			}
			_jcbj = value;
			if (_jcbj != null)
			{
				((BaseItem)_jcbj).add_Click(eventHandler);
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

	internal virtual RibbonPanel RibbonPanel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _RibbonPanel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RibbonPanel2 = value;
		}
	}

	internal virtual RibbonBar RibbonBar2
	{
		[DebuggerNonUserCode]
		get
		{
			return _RibbonBar2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RibbonBar2 = value;
		}
	}

	internal virtual ButtonItem drk
	{
		[DebuggerNonUserCode]
		get
		{
			return _drk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = drk_Click;
			if (_drk != null)
			{
				((BaseItem)_drk).remove_Click(eventHandler);
			}
			_drk = value;
			if (_drk != null)
			{
				((BaseItem)_drk).add_Click(eventHandler);
			}
		}
	}

	internal virtual RibbonPanel RibbonPanel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _RibbonPanel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RibbonPanel3 = value;
		}
	}

	internal virtual RibbonTabItem RibbonTabItem2
	{
		[DebuggerNonUserCode]
		get
		{
			return _RibbonTabItem2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RibbonTabItem2 = value;
		}
	}

	internal virtual RibbonTabItem RibbonTabItem3
	{
		[DebuggerNonUserCode]
		get
		{
			return _RibbonTabItem3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RibbonTabItem3 = value;
		}
	}

	internal virtual RibbonBar RibbonBar3
	{
		[DebuggerNonUserCode]
		get
		{
			return _RibbonBar3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RibbonBar3 = value;
		}
	}

	internal virtual ButtonItem btnbjmlibs
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnbjmlibs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnbjmlibs_Click;
			if (_btnbjmlibs != null)
			{
				((BaseItem)_btnbjmlibs).remove_Click(eventHandler);
			}
			_btnbjmlibs = value;
			if (_btnbjmlibs != null)
			{
				((BaseItem)_btnbjmlibs).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonItem gxk
	{
		[DebuggerNonUserCode]
		get
		{
			return _gxk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = gxk_Click;
			if (_gxk != null)
			{
				((BaseItem)_gxk).remove_Click(eventHandler);
			}
			_gxk = value;
			if (_gxk != null)
			{
				((BaseItem)_gxk).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonItem dck
	{
		[DebuggerNonUserCode]
		get
		{
			return _dck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = dck_Click;
			if (_dck != null)
			{
				((BaseItem)_dck).remove_Click(eventHandler);
			}
			_dck = value;
			if (_dck != null)
			{
				((BaseItem)_dck).add_Click(eventHandler);
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

	public virtual ListBox log
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

	public mxkgl()
	{
		((Form)this).add_Load((EventHandler)mxkgl_Load);
		list1 = new ArrayList();
		bjname = new ArrayList();
		pp = new ArrayList();
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
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Expected O, but got Unknown
		//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f5: Expected O, but got Unknown
		//IL_079f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ea: Expected O, but got Unknown
		//IL_0a4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a56: Expected O, but got Unknown
		//IL_0ab8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac2: Expected O, but got Unknown
		//IL_0b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2e: Expected O, but got Unknown
		//IL_0bcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e05: Expected O, but got Unknown
		//IL_0e67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e71: Expected O, but got Unknown
		//IL_11b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c0: Expected O, but got Unknown
		//IL_1240: Unknown result type (might be due to invalid IL or missing references)
		//IL_124a: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(mxkgl));
		RibbonControl1 = new RibbonControl();
		RibbonPanel2 = new RibbonPanel();
		RibbonBar2 = new RibbonBar();
		drk = new ButtonItem();
		dck = new ButtonItem();
		RibbonPanel1 = new RibbonPanel();
		scbj = new RibbonBar();
		zjbj1 = new ButtonItem();
		btndcbj = new ButtonItem();
		ButtonItem3 = new ButtonItem();
		jcbj = new ButtonItem();
		RibbonPanel3 = new RibbonPanel();
		RibbonBar3 = new RibbonBar();
		btnbjmlibs = new ButtonItem();
		gxk = new ButtonItem();
		RibbonTabItem1 = new RibbonTabItem();
		RibbonTabItem2 = new RibbonTabItem();
		RibbonTabItem3 = new RibbonTabItem();
		QatCustomizeItem1 = new QatCustomizeItem();
		LabelX1 = new LabelX();
		LabelX2 = new LabelX();
		log = new ListBox();
		gb = new ButtonX();
		RibbonControl1.SuspendLayout();
		((Control)RibbonPanel2).SuspendLayout();
		((Control)RibbonPanel1).SuspendLayout();
		((Control)RibbonPanel3).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)RibbonControl1).set_Anchor((AnchorStyles)13);
		RibbonControl1.set_AutoExpand(false);
		RibbonControl1.set_AutoSize(true);
		RibbonControl1.get_BackgroundStyle().set_Class("");
		RibbonControl1.get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)RibbonControl1).get_Controls().Add((Control)(object)RibbonPanel2);
		((Control)RibbonControl1).get_Controls().Add((Control)(object)RibbonPanel1);
		((Control)RibbonControl1).get_Controls().Add((Control)(object)RibbonPanel3);
		RibbonControl1.get_Items().AddRange((BaseItem[])(object)new BaseItem[3]
		{
			(BaseItem)RibbonTabItem1,
			(BaseItem)RibbonTabItem2,
			(BaseItem)RibbonTabItem3
		});
		RibbonControl1.set_KeyTipsFont(new Font("Tahoma", 7f));
		RibbonControl ribbonControl = RibbonControl1;
		Point location = new Point(5, 19);
		((Control)ribbonControl).set_Location(location);
		((Control)RibbonControl1).set_Name("RibbonControl1");
		RibbonControl ribbonControl2 = RibbonControl1;
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(0, 0, 0, 2);
		((Control)ribbonControl2).set_Padding(padding);
		RibbonControl1.get_QuickToolbarItems().AddRange((BaseItem[])(object)new BaseItem[1] { (BaseItem)QatCustomizeItem1 });
		RibbonControl ribbonControl3 = RibbonControl1;
		Size size = new Size(731, 90);
		((Control)ribbonControl3).set_Size(size);
		RibbonControl1.set_Style((eDotNetBarStyle)7);
		RibbonControl1.get_SystemText().set_MaximizeRibbonText("&Maximize the Ribbon");
		RibbonControl1.get_SystemText().set_MinimizeRibbonText("Mi&nimize the Ribbon");
		RibbonControl1.get_SystemText().set_QatAddItemText("&Add to Quick Access Toolbar");
		RibbonControl1.get_SystemText().set_QatCustomizeMenuLabel("<b>Customize Quick Access Toolbar</b>");
		RibbonControl1.get_SystemText().set_QatCustomizeText("&Customize Quick Access Toolbar...");
		RibbonControl1.get_SystemText().set_QatDialogAddButton("&Add >>");
		RibbonControl1.get_SystemText().set_QatDialogCancelButton("Cancel");
		RibbonControl1.get_SystemText().set_QatDialogCaption("Customize Quick Access Toolbar");
		RibbonControl1.get_SystemText().set_QatDialogCategoriesLabel("&Choose commands from:");
		RibbonControl1.get_SystemText().set_QatDialogOkButton("OK");
		RibbonControl1.get_SystemText().set_QatDialogPlacementCheckbox("&Place Quick Access Toolbar below the Ribbon");
		RibbonControl1.get_SystemText().set_QatDialogRemoveButton("&Remove");
		RibbonControl1.get_SystemText().set_QatPlaceAboveRibbonText("&Place Quick Access Toolbar above the Ribbon");
		RibbonControl1.get_SystemText().set_QatPlaceBelowRibbonText("&Place Quick Access Toolbar below the Ribbon");
		RibbonControl1.get_SystemText().set_QatRemoveItemText("&Remove from Quick Access Toolbar");
		RibbonControl1.set_TabGroupHeight(14);
		((Control)RibbonControl1).set_TabIndex(0);
		((Control)RibbonControl1).set_Text("RibbonControl1");
		((PanelControl)RibbonPanel2).set_ColorSchemeStyle((eDotNetBarStyle)7);
		((Control)RibbonPanel2).get_Controls().Add((Control)(object)RibbonBar2);
		RibbonPanel2.set_Dock((DockStyle)5);
		RibbonPanel ribbonPanel = RibbonPanel2;
		location = new Point(0, 26);
		ribbonPanel.set_Location(location);
		((Control)RibbonPanel2).set_Name("RibbonPanel2");
		RibbonPanel ribbonPanel2 = RibbonPanel2;
		((Padding)(ref padding))._002Ector(3, 0, 3, 3);
		((Control)ribbonPanel2).set_Padding(padding);
		RibbonPanel ribbonPanel3 = RibbonPanel2;
		size = new Size(731, 62);
		ribbonPanel3.set_Size(size);
		((PanelControl)RibbonPanel2).get_Style().set_Class("");
		((PanelControl)RibbonPanel2).get_Style().set_CornerType((eCornerType)1);
		((PanelControl)RibbonPanel2).get_StyleMouseDown().set_Class("");
		((PanelControl)RibbonPanel2).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)RibbonPanel2).get_StyleMouseOver().set_Class("");
		((PanelControl)RibbonPanel2).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)RibbonPanel2).set_TabIndex(2);
		RibbonBar2.set_AutoOverflowEnabled(true);
		RibbonBar2.get_BackgroundMouseOverStyle().set_Class("");
		RibbonBar2.get_BackgroundMouseOverStyle().set_CornerType((eCornerType)1);
		((ItemControl)RibbonBar2).get_BackgroundStyle().set_Class("");
		((ItemControl)RibbonBar2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((ItemControl)RibbonBar2).set_ContainerControlProcessDialogKey(true);
		((Control)RibbonBar2).set_Dock((DockStyle)3);
		RibbonBar2.get_Items().AddRange((BaseItem[])(object)new BaseItem[2]
		{
			(BaseItem)drk,
			(BaseItem)dck
		});
		RibbonBar ribbonBar = RibbonBar2;
		location = new Point(3, 0);
		((Control)ribbonBar).set_Location(location);
		((Control)RibbonBar2).set_Name("RibbonBar2");
		RibbonBar ribbonBar2 = RibbonBar2;
		size = new Size(725, 59);
		((Control)ribbonBar2).set_Size(size);
		RibbonBar2.set_Style((eDotNetBarStyle)7);
		((Control)RibbonBar2).set_TabIndex(0);
		((Control)RibbonBar2).set_Text("RibbonBar2");
		RibbonBar2.get_TitleStyle().set_Class("");
		RibbonBar2.get_TitleStyle().set_CornerType((eCornerType)1);
		RibbonBar2.get_TitleStyleMouseOver().set_Class("");
		RibbonBar2.get_TitleStyleMouseOver().set_CornerType((eCornerType)1);
		RibbonBar2.set_TitleVisible(false);
		drk.set_HotFontBold(true);
		drk.set_Image((Image)componentResourceManager.GetObject("drk.Image"));
		drk.set_ImagePosition((eImagePosition)2);
		((BaseItem)drk).set_Name("drk");
		drk.set_SubItemsExpandWidth(14);
		drk.set_Text("导入某处理模块");
		dck.set_ButtonStyle((eButtonStyle)2);
		dck.set_HotFontBold(true);
		dck.set_Image((Image)componentResourceManager.GetObject("dck.Image"));
		dck.set_ImagePosition((eImagePosition)2);
		((BaseItem)dck).set_Name("dck");
		dck.set_SubItemsExpandWidth(14);
		dck.set_Text("导出某处理模块");
		((Panel)RibbonPanel1).set_AutoSize(true);
		((PanelControl)RibbonPanel1).set_ColorSchemeStyle((eDotNetBarStyle)7);
		((Control)RibbonPanel1).get_Controls().Add((Control)(object)scbj);
		RibbonPanel1.set_Dock((DockStyle)5);
		RibbonPanel ribbonPanel4 = RibbonPanel1;
		location = new Point(0, 26);
		ribbonPanel4.set_Location(location);
		((Control)RibbonPanel1).set_Name("RibbonPanel1");
		RibbonPanel ribbonPanel5 = RibbonPanel1;
		((Padding)(ref padding))._002Ector(3, 0, 3, 3);
		((Control)ribbonPanel5).set_Padding(padding);
		RibbonPanel ribbonPanel6 = RibbonPanel1;
		size = new Size(731, 62);
		ribbonPanel6.set_Size(size);
		((PanelControl)RibbonPanel1).get_Style().set_Class("");
		((PanelControl)RibbonPanel1).get_Style().set_CornerType((eCornerType)1);
		((PanelControl)RibbonPanel1).get_StyleMouseDown().set_Class("");
		((PanelControl)RibbonPanel1).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)RibbonPanel1).get_StyleMouseOver().set_Class("");
		((PanelControl)RibbonPanel1).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)RibbonPanel1).set_TabIndex(1);
		RibbonPanel1.set_Visible(false);
		scbj.set_AutoOverflowEnabled(true);
		scbj.get_BackgroundMouseOverStyle().set_Class("");
		scbj.get_BackgroundMouseOverStyle().set_CornerType((eCornerType)1);
		((ItemControl)scbj).get_BackgroundStyle().set_Class("");
		((ItemControl)scbj).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((ItemControl)scbj).set_ContainerControlProcessDialogKey(true);
		((Control)scbj).set_Dock((DockStyle)3);
		scbj.get_Items().AddRange((BaseItem[])(object)new BaseItem[4]
		{
			(BaseItem)zjbj1,
			(BaseItem)btndcbj,
			(BaseItem)ButtonItem3,
			(BaseItem)jcbj
		});
		RibbonBar obj = scbj;
		location = new Point(3, 0);
		((Control)obj).set_Location(location);
		((Control)scbj).set_Name("scbj");
		RibbonBar obj2 = scbj;
		size = new Size(725, 59);
		((Control)obj2).set_Size(size);
		scbj.set_Style((eDotNetBarStyle)7);
		((Control)scbj).set_TabIndex(1);
		((Control)scbj).set_Text("RibbonBar1");
		scbj.get_TitleStyle().set_Class("");
		scbj.get_TitleStyle().set_CornerType((eCornerType)1);
		scbj.get_TitleStyleMouseOver().set_Class("");
		scbj.get_TitleStyleMouseOver().set_CornerType((eCornerType)1);
		scbj.set_TitleVisible(false);
		zjbj1.set_ButtonStyle((eButtonStyle)2);
		zjbj1.set_HotFontBold(true);
		zjbj1.set_Image((Image)componentResourceManager.GetObject("zjbj1.Image"));
		zjbj1.set_ImagePosition((eImagePosition)2);
		((BaseItem)zjbj1).set_Name("zjbj1");
		zjbj1.set_SubItemsExpandWidth(14);
		zjbj1.set_Text("追加部件至当前库");
		btndcbj.set_ButtonStyle((eButtonStyle)2);
		btndcbj.set_HotFontBold(true);
		btndcbj.set_Image((Image)componentResourceManager.GetObject("btndcbj.Image"));
		btndcbj.set_ImagePosition((eImagePosition)2);
		((BaseItem)btndcbj).set_Name("btndcbj");
		btndcbj.set_SubItemsExpandWidth(14);
		btndcbj.set_Text("从当前库导出部件");
		ButtonItem3.set_ButtonStyle((eButtonStyle)2);
		ButtonItem3.set_HotFontBold(true);
		ButtonItem3.set_Image((Image)componentResourceManager.GetObject("ButtonItem3.Image"));
		ButtonItem3.set_ImagePosition((eImagePosition)2);
		((BaseItem)ButtonItem3).set_Name("ButtonItem3");
		ButtonItem3.set_SubItemsExpandWidth(14);
		ButtonItem3.set_Text("从当前库删除部件");
		jcbj.set_ButtonStyle((eButtonStyle)2);
		jcbj.set_HotFontBold(true);
		jcbj.set_Image((Image)componentResourceManager.GetObject("jcbj.Image"));
		jcbj.set_ImagePosition((eImagePosition)2);
		((BaseItem)jcbj).set_Name("jcbj");
		jcbj.set_SubItemsExpandWidth(14);
		jcbj.set_Text("检查库部件的完备性");
		((PanelControl)RibbonPanel3).set_ColorSchemeStyle((eDotNetBarStyle)7);
		((Control)RibbonPanel3).get_Controls().Add((Control)(object)RibbonBar3);
		RibbonPanel3.set_Dock((DockStyle)5);
		RibbonPanel ribbonPanel7 = RibbonPanel3;
		location = new Point(0, 26);
		ribbonPanel7.set_Location(location);
		((Control)RibbonPanel3).set_Name("RibbonPanel3");
		RibbonPanel ribbonPanel8 = RibbonPanel3;
		((Padding)(ref padding))._002Ector(3, 0, 3, 3);
		((Control)ribbonPanel8).set_Padding(padding);
		RibbonPanel ribbonPanel9 = RibbonPanel3;
		size = new Size(731, 62);
		ribbonPanel9.set_Size(size);
		((PanelControl)RibbonPanel3).get_Style().set_Class("");
		((PanelControl)RibbonPanel3).get_Style().set_CornerType((eCornerType)1);
		((PanelControl)RibbonPanel3).get_StyleMouseDown().set_Class("");
		((PanelControl)RibbonPanel3).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)RibbonPanel3).get_StyleMouseOver().set_Class("");
		((PanelControl)RibbonPanel3).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)RibbonPanel3).set_TabIndex(3);
		RibbonPanel3.set_Visible(false);
		RibbonBar3.set_AutoOverflowEnabled(true);
		RibbonBar3.get_BackgroundMouseOverStyle().set_Class("");
		RibbonBar3.get_BackgroundMouseOverStyle().set_CornerType((eCornerType)1);
		((ItemControl)RibbonBar3).get_BackgroundStyle().set_Class("");
		((ItemControl)RibbonBar3).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((ItemControl)RibbonBar3).set_ContainerControlProcessDialogKey(true);
		((Control)RibbonBar3).set_Dock((DockStyle)3);
		RibbonBar3.get_Items().AddRange((BaseItem[])(object)new BaseItem[2]
		{
			(BaseItem)btnbjmlibs,
			(BaseItem)gxk
		});
		RibbonBar ribbonBar3 = RibbonBar3;
		location = new Point(3, 0);
		((Control)ribbonBar3).set_Location(location);
		((Control)RibbonBar3).set_Name("RibbonBar3");
		RibbonBar ribbonBar4 = RibbonBar3;
		size = new Size(725, 59);
		((Control)ribbonBar4).set_Size(size);
		RibbonBar3.set_Style((eDotNetBarStyle)7);
		((Control)RibbonBar3).set_TabIndex(0);
		((Control)RibbonBar3).set_Text("RibbonBar3");
		RibbonBar3.get_TitleStyle().set_Class("");
		RibbonBar3.get_TitleStyle().set_CornerType((eCornerType)1);
		RibbonBar3.get_TitleStyleMouseOver().set_Class("");
		RibbonBar3.get_TitleStyleMouseOver().set_CornerType((eCornerType)1);
		RibbonBar3.set_TitleVisible(false);
		btnbjmlibs.set_ButtonStyle((eButtonStyle)2);
		btnbjmlibs.set_HotFontBold(true);
		btnbjmlibs.set_Image((Image)componentResourceManager.GetObject("btnbjmlibs.Image"));
		btnbjmlibs.set_ImagePosition((eImagePosition)2);
		((BaseItem)btnbjmlibs).set_Name("btnbjmlibs");
		btnbjmlibs.set_SubItemsExpandWidth(14);
		btnbjmlibs.set_Text("编辑当前库mlibs.lis");
		gxk.set_ButtonStyle((eButtonStyle)2);
		gxk.set_HotFontBold(true);
		gxk.set_Image((Image)componentResourceManager.GetObject("gxk.Image"));
		gxk.set_ImagePosition((eImagePosition)2);
		((BaseItem)gxk).set_Name("gxk");
		gxk.set_SubItemsExpandWidth(14);
		gxk.set_Text("更新当前库中子列表信息");
		((BaseItem)RibbonTabItem1).set_Name("RibbonTabItem1");
		RibbonTabItem1.set_Panel(RibbonPanel1);
		((ButtonItem)RibbonTabItem1).set_Text("库结构处理功能");
		RibbonTabItem2.set_Checked(true);
		((BaseItem)RibbonTabItem2).set_Name("RibbonTabItem2");
		RibbonTabItem2.set_Panel(RibbonPanel2);
		((ButtonItem)RibbonTabItem2).set_Text("库模板处理功能");
		((ButtonItem)RibbonTabItem3).set_HotFontBold(true);
		((BaseItem)RibbonTabItem3).set_Name("RibbonTabItem3");
		RibbonTabItem3.set_Panel(RibbonPanel3);
		((ButtonItem)RibbonTabItem3).set_Text("库列表信息处理功能");
		((BaseItem)QatCustomizeItem1).set_Name("QatCustomizeItem1");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX = LabelX1;
		location = new Point(9, 5);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		size = new Size(75, 14);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(4);
		LabelX1.set_Text("库管理对象");
		((Control)LabelX2).set_BackgroundImageLayout((ImageLayout)0);
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX3 = LabelX2;
		location = new Point(5, 115);
		((Control)labelX3).set_Location(location);
		((Control)LabelX2).set_Name("LabelX2");
		LabelX labelX4 = LabelX2;
		size = new Size(700, 47);
		((Control)labelX4).set_Size(size);
		((Control)LabelX2).set_TabIndex(5);
		LabelX2.set_Text("在管理模型库的过程中,一定要保证现有库结构与其列表信息文件的一致.\r\n举例:如果进行了对库部件的\"追加\"或\"删除\"或\"导入\"操作,则现有的mlibs.lis文件就需要更新了,就要进行\"编辑mlibs.lis\".注意看一下每次操作后的提示信息.. .");
		LabelX2.set_TextLineAlignment((StringAlignment)0);
		LabelX2.set_WordWrap(true);
		((ListControl)log).set_FormattingEnabled(true);
		log.set_ItemHeight(12);
		ListBox obj3 = log;
		location = new Point(5, 168);
		((Control)obj3).set_Location(location);
		((Control)log).set_Name("log");
		ListBox obj4 = log;
		size = new Size(731, 220);
		((Control)obj4).set_Size(size);
		((Control)log).set_TabIndex(6);
		((Control)gb).set_AccessibleRole((AccessibleRole)43);
		gb.set_ColorTable((eButtonColor)3);
		gb.set_DialogResult((DialogResult)2);
		ButtonX obj5 = gb;
		location = new Point(317, 394);
		((Control)obj5).set_Location(location);
		((Control)gb).set_Name("gb");
		ButtonX obj6 = gb;
		size = new Size(124, 25);
		((Control)obj6).set_Size(size);
		((PopupItemControl)gb).set_Style((eDotNetBarStyle)7);
		((Control)gb).set_TabIndex(7);
		gb.set_Text("关闭");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)gb);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(741, 425);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)gb);
		((Control)this).get_Controls().Add((Control)(object)log);
		((Control)this).get_Controls().Add((Control)(object)LabelX2);
		((Control)this).get_Controls().Add((Control)(object)RibbonControl1);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("mxkgl");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("模型库管理");
		RibbonControl1.ResumeLayout(false);
		((Control)RibbonControl1).PerformLayout();
		((Control)RibbonPanel2).ResumeLayout(false);
		((Control)RibbonPanel1).ResumeLayout(false);
		((Control)RibbonPanel3).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void mxkgl_Load(object sender, EventArgs e)
	{
		RibbonTabItem1.Select();
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
					MyProject.Forms.Main.lslog.get_Items().Add(RuntimeHelpers.GetObjectValue(log.get_Items().get_Item(i)));
				}
			}
			MyProject.Forms.Main.lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员关闭了模型库管理对话框"));
			((Component)(object)this).Dispose();
		}
	}

	private void zjbj1_Click(object sender, EventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员打开追加部件对话框"));
		((Form)MyProject.Forms.zjbj).ShowDialog();
		((Component)(object)MyProject.Forms.zjbj).Dispose();
		((Component)(object)MyProject.Forms.FrmOf).Dispose();
		if (log.get_Items().get_Count() != 0)
		{
			log.set_SelectedIndex(checked(log.get_Items().get_Count() - 1));
		}
	}

	private void btndcbj_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		if (!Mod1.Saved && (int)MessageBox.Show("当前参数文件已经被修改，在导出部件已前是否要保存？", "重要提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 6)
		{
			Mod1.wb.Save();
			Mod1.wb.Close(Missing.Value, Missing.Value, Missing.Value);
			Mod1.Saved = true;
			Interaction.MsgBox((object)"保存成功！", (MsgBoxStyle)64, (object)"成功");
			((BaseItem)MyProject.Forms.Main.ToolsSave).set_Enabled(false);
		}
		log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员打开部件导出对话框"));
		((Form)MyProject.Forms.dcbj).ShowDialog();
		((Component)(object)MyProject.Forms.dcbj).Dispose();
		if (log.get_Items().get_Count() != 0)
		{
			log.set_SelectedIndex(checked(log.get_Items().get_Count() - 1));
		}
	}

	private void ButtonItem3_Click(object sender, EventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员打开删除部件对话框"));
		((Form)MyProject.Forms.shanchubj).ShowDialog();
		((Component)(object)MyProject.Forms.shanchubj).Dispose();
		if (log.get_Items().get_Count() != 0)
		{
			log.set_SelectedIndex(checked(log.get_Items().get_Count() - 1));
		}
	}

	private void jcbj_Click(object sender, EventArgs e)
	{
		Readmlibs();
		if (log.get_Items().get_Count() != 0)
		{
			log.set_SelectedIndex(checked(log.get_Items().get_Count() - 1));
		}
	}

	public void Readmlibs()
	{
		f = "";
		list1.Clear();
		bjname.Clear();
		checked
		{
			if (log.get_Items().get_Count() != 0)
			{
				int num = log.get_Items().get_Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					MyProject.Forms.Main.lslog.get_Items().Add(RuntimeHelpers.GetObjectValue(log.get_Items().get_Item(i)));
				}
			}
			log.get_Items().Clear();
			Mod1.lr = new StreamReader(Mod1.Kulujing + "mlibs.lis", Encoding.Default);
			while (!Information.IsNothing((object)f))
			{
				f = Mod1.lr.ReadLine();
				if (Information.IsNothing((object)f))
				{
					break;
				}
				nn = f.Split(new char[1] { ',' });
				bjname.Add(nn[0]);
				list1.Add(nn[1]);
			}
			Mod1.lr.Close();
			Mod1.lr.Dispose();
			Checklis(ref list1, ref bjname);
		}
	}

	public void Checklis(ref ArrayList array, ref ArrayList bname)
	{
		checked
		{
			int num = array.Count - 1;
			StreamReader streamReader = default(StreamReader);
			for (int i = 0; i <= num; i++)
			{
				log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 正在验证：" + bname[i]!.ToString() + "..."));
				string text = Conversions.ToString(Operators.ConcatenateObject((object)Mod1.Kulujing, array[i]));
				string text2 = Conversions.ToString(array[i]);
				if (Operators.CompareString(Strings.Right(text, 1), "\\", false) != 0)
				{
					text += "\\";
				}
				if (Directory.Exists(text))
				{
					if (File.Exists(text + text2 + ".lis"))
					{
						Mod1.lr = new StreamReader(text + text2 + ".lis", Encoding.Default);
						f = "";
						while (!Information.IsNothing((object)f))
						{
							f = Mod1.lr.ReadLine();
							if (Information.IsNothing((object)f))
							{
								break;
							}
							if (Operators.CompareString(Mod1.toen(ref f), "", false) == 0)
							{
								log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 在列表文件 " + text + text2 + ".lis 找到了其它信息！！"));
								continue;
							}
							string text3 = text + Mod1.toen(ref f);
							if ((Operators.CompareString(f, "参数化模型", false) == 0) | (Operators.CompareString(f, "实例模型", false) == 0))
							{
								if (!Directory.Exists(text3))
								{
									continue;
								}
								if (Operators.CompareString(f, "参数化模型", false) == 0)
								{
									text3 = text3.Substring(text3.LastIndexOf("\\") + 1);
									string text4 = "";
									if (Directory.Exists(text + text3 + "\\cs"))
									{
										string[] files = Directory.GetFiles(text + text3 + "\\cs", "*.xls", SearchOption.TopDirectoryOnly);
										if (files.Length == 0)
										{
											log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " " + bname[i]!.ToString() + " 参数文件不存在！！"));
										}
									}
									else
									{
										log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " " + text + text3 + "\\cs 文件夹不存在！！"));
									}
									if (File.Exists(text + text3 + "\\" + text3 + ".lis"))
									{
										streamReader = new StreamReader(text + text3 + "\\" + text3 + ".lis", Encoding.Default);
										while (!Information.IsNothing((object)text4))
										{
											text4 = streamReader.ReadLine();
											if (Information.IsNothing((object)text4))
											{
												break;
											}
											if (Operators.CompareString(Mod1.toen(ref text4), "", false) == 0)
											{
												log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 在列表文件 " + text + text3 + ".lis 找到了其它信息！！"));
												continue;
											}
											pp.Add(text + text3 + "\\" + Mod1.toen(ref text4));
											string text5 = text + text3 + "\\" + Mod1.toen(ref text4);
											if (Directory.Exists(text5))
											{
												string[] directories = Directory.GetDirectories(text5);
												int num2 = directories.Length - 1;
												int num3 = 0;
												while (true)
												{
													if (num3 <= num2)
													{
														string text6 = directories[num3].Substring(directories[num3].LastIndexOf("\\") + 1);
														if (Operators.CompareString(Mod1.toen(ref text4), "fa", false) != 0)
														{
															if (Operators.CompareString(text6, "tempxls", false) != 0 && Operators.ConditionalCompareObjectNotEqual(array[i], (object)"qyxxn", false))
															{
																if (!File.Exists(text5 + "\\" + text6 + "\\layoutvar.xls"))
																{
																	log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " " + text5 + "下不存在 layoutvar.xls 布局文件！！"));
																}
																if (!Directory.Exists(text5 + "\\" + text6 + "\\source"))
																{
																	log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " " + text5 + "下不存在 source 文件夹！！"));
																}
																else
																{
																	string[] files = Directory.GetFiles(text5 + "\\" + text6 + "\\source", text6 + ".asm.*", SearchOption.TopDirectoryOnly);
																	if (files.Length == 0)
																	{
																		files = Directory.GetFiles(text5 + "\\" + text6 + "\\source", text6 + ".prt.*", SearchOption.TopDirectoryOnly);
																		if (files.Length == 0)
																		{
																			log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " " + text5 + "\\" + text6 + "\\source 下文件不正确，请确认文件名是否与跟目录一致！！"));
																		}
																	}
																}
															}
															num3++;
															continue;
														}
														string pat = text5 + "\\" + text6;
														Checkfa(ref pat);
														break;
													}
													if (!Operators.ConditionalCompareObjectEqual(array[i], (object)"qyxxn", false))
													{
														break;
													}
													int num4 = directories.Length - 1;
													for (int j = 0; j <= num4; j++)
													{
														if (!File.Exists(directories[j] + "\\source\\Run.bat"))
														{
															log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 没有找到 " + directories[j] + "\\source\\Run.bat"));
														}
													}
													break;
												}
											}
											else
											{
												log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 没有找到 " + text4 + " 对应文件夹！！"));
											}
										}
									}
									else
									{
										log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 没有找到 " + text + text3 + "\\" + text3 + ".lis 文件！！"));
									}
									streamReader.Close();
									streamReader.Dispose();
								}
								else if (Operators.CompareString(f, "实例模型", false) == 0)
								{
									if (!Directory.Exists(text3))
									{
										continue;
									}
									text3 = text3.Substring(text3.LastIndexOf("\\") + 1);
									streamReader = new StreamReader(text + text3 + "\\" + text3 + ".lis", Encoding.Default);
									string text4 = "";
									while (!Information.IsNothing((object)text4))
									{
										text4 = streamReader.ReadLine();
										if (Information.IsNothing((object)text4))
										{
											break;
										}
										if (Operators.CompareString(Mod1.toen(ref text4), "", false) == 0)
										{
											log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 在列表文件 " + text + text3 + ".lis 找到了其它信息！！"));
											continue;
										}
										string text5 = text + text3 + "\\" + Mod1.toen(ref text4);
										if (!Directory.Exists(text5))
										{
											continue;
										}
										string[] directories = Directory.GetDirectories(text5);
										int num5 = directories.Length - 1;
										for (int k = 0; k <= num5; k++)
										{
											string text6 = directories[k].Substring(directories[k].LastIndexOf("\\") + 1);
											string[] files = Directory.GetFiles(text5 + "\\" + text6 + "\\source", text6 + ".asm.*", SearchOption.TopDirectoryOnly);
											if (files.Length == 0)
											{
												files = Directory.GetFiles(text5 + "\\" + text6 + "\\source", text6 + ".prt.*", SearchOption.TopDirectoryOnly);
												if (files.Length == 0)
												{
													log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " " + text5 + "\\" + text6 + " 下文件不正确，请确认文件名是否与跟目录一致！！"));
												}
											}
										}
									}
									streamReader.Close();
									streamReader.Dispose();
								}
								else
								{
									log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " " + f + " 即不是【参数模型】也不是【实例模型】!!"));
								}
							}
							else
							{
								log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " " + text + text2 + ".lis 不符合模型库部件要求！"));
							}
						}
						Mod1.lr.Close();
						Mod1.lr.Dispose();
					}
					else
					{
						log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " " + text + text2 + ".lis 文件不存在！！"));
					}
				}
				else
				{
					log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 部件文件夹不存在！！"));
				}
				log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " " + bname[i]!.ToString() + " 部件验证完成。"));
				log.get_Items().Add((object)"");
			}
		}
	}

	private void drk_Click(object sender, EventArgs e)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!File.Exists(Application.get_StartupPath() + "\\config\\参数化实例列表.ini"))
		{
			Interaction.MsgBox((object)(Application.get_StartupPath() + "\\config\\参数化实例列表.ini 丢失，请重新拷贝！"), (MsgBoxStyle)64, (object)"文件丢失");
			return;
		}
		if (!File.Exists(Application.get_StartupPath() + "\\config\\处理功能列表.ini"))
		{
			Interaction.MsgBox((object)(Application.get_StartupPath() + "\\config\\处理功能列表.ini 丢失，请重新拷贝！"), (MsgBoxStyle)64, (object)"文件丢失");
			return;
		}
		log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员打开添加处理块对话框"));
		((Form)MyProject.Forms.drclk).ShowDialog();
		((Component)(object)MyProject.Forms.drclk).Dispose();
	}

	private void dck_Click(object sender, EventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员打开导出块对话框"));
		((Form)MyProject.Forms.dcmk).ShowDialog();
		((Component)(object)MyProject.Forms.dcmk).Dispose();
	}

	private void btnbjmlibs_Click(object sender, EventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员打开编辑当前库mlibs.lis对话框"));
		((Form)MyProject.Forms.bjmlibs).ShowDialog();
		((Component)(object)MyProject.Forms.bjmlibs).Dispose();
	}

	private void gxk_Click(object sender, EventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员打开更新当前库中子列表信息对话框"));
		((Form)MyProject.Forms.gxlisfile).ShowDialog();
		((Component)(object)MyProject.Forms.gxlisfile).Dispose();
	}

	public void Checkfa(ref string pat)
	{
		if (!File.Exists(pat + "\\source\\臂头曲线计算_1.BAT"))
		{
			log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + "  pat & \\source\\臂头曲线计算_1.BAT 文件不存在！"));
		}
		if (!File.Exists(pat + "\\source\\方案计算_2.BAT"))
		{
			log.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + "  pat & \\source\\方案计算_2.BAT 文件不存在！"));
		}
	}
}
