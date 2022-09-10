using System;
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
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class proejshz : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("GroupPanel1")]
	private GroupPanel _GroupPanel1;

	[AccessedThroughProperty("GroupPanel2")]
	private GroupPanel _GroupPanel2;

	[AccessedThroughProperty("ll_opt2")]
	private CheckBoxX _ll_opt2;

	[AccessedThroughProperty("ll_opt1")]
	private CheckBoxX _ll_opt1;

	[AccessedThroughProperty("LabelX3")]
	private LabelX _LabelX3;

	[AccessedThroughProperty("ll_btn2file")]
	private ButtonX _ll_btn2file;

	[AccessedThroughProperty("ll_btn5file")]
	private ButtonX _ll_btn5file;

	[AccessedThroughProperty("ll_btnjsq")]
	private ButtonX _ll_btnjsq;

	[AccessedThroughProperty("ll_btnclear")]
	private ButtonX _ll_btnclear;

	[AccessedThroughProperty("ll_btnremoved2")]
	private ButtonX _ll_btnremoved2;

	[AccessedThroughProperty("ll_btnremoved1")]
	private ButtonX _ll_btnremoved1;

	[AccessedThroughProperty("ll_btnxia")]
	private ButtonX _ll_btnxia;

	[AccessedThroughProperty("ll_btnshang")]
	private ButtonX _ll_btnshang;

	[AccessedThroughProperty("ll_lbmeasures")]
	private ListBox _ll_lbmeasures;

	[AccessedThroughProperty("LabelX2")]
	private LabelX _LabelX2;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("ll_btnpath")]
	private ButtonX _ll_btnpath;

	[AccessedThroughProperty("ll_btncheckthis")]
	private ButtonX _ll_btncheckthis;

	[AccessedThroughProperty("ll_txtpath")]
	private TextBoxX _ll_txtpath;

	[AccessedThroughProperty("LabelX4")]
	private LabelX _LabelX4;

	[AccessedThroughProperty("ll_lbresult")]
	private ListBox _ll_lbresult;

	[AccessedThroughProperty("ll_btnoutput")]
	private ButtonX _ll_btnoutput;

	[AccessedThroughProperty("ll_btnpick2curlist")]
	private ButtonX _ll_btnpick2curlist;

	[AccessedThroughProperty("ll_btnexit")]
	private ButtonX _ll_btnexit;

	[AccessedThroughProperty("ll_opt2ctrlshift")]
	private CheckBoxX _ll_opt2ctrlshift;

	[AccessedThroughProperty("ll_lbliucheng")]
	private ListBox _ll_lbliucheng;

	[AccessedThroughProperty("LabelX5")]
	private LabelX _LabelX5;

	[AccessedThroughProperty("GetOpenFilename")]
	private OpenFileDialog _GetOpenFilename;

	[AccessedThroughProperty("GetSaveAsFilename")]
	private SaveFileDialog _GetSaveAsFilename;

	private string strtemp;

	private string curvalue;

	private int curi;

	private string fname;

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

	internal virtual GroupPanel GroupPanel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupPanel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupPanel2 = value;
		}
	}

	internal virtual CheckBoxX ll_opt2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_opt2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_opt2_Click;
			if (_ll_opt2 != null)
			{
				((Control)_ll_opt2).remove_Click(eventHandler);
			}
			_ll_opt2 = value;
			if (_ll_opt2 != null)
			{
				((Control)_ll_opt2).add_Click(eventHandler);
			}
		}
	}

	internal virtual CheckBoxX ll_opt1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_opt1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_opt1_Click;
			if (_ll_opt1 != null)
			{
				((Control)_ll_opt1).remove_Click(eventHandler);
			}
			_ll_opt1 = value;
			if (_ll_opt1 != null)
			{
				((Control)_ll_opt1).add_Click(eventHandler);
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

	internal virtual ButtonX ll_btn2file
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btn2file;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btn2file_Click;
			if (_ll_btn2file != null)
			{
				((Control)_ll_btn2file).remove_Click(eventHandler);
			}
			_ll_btn2file = value;
			if (_ll_btn2file != null)
			{
				((Control)_ll_btn2file).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btn5file
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btn5file;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btn5file_Click;
			if (_ll_btn5file != null)
			{
				((Control)_ll_btn5file).remove_Click(eventHandler);
			}
			_ll_btn5file = value;
			if (_ll_btn5file != null)
			{
				((Control)_ll_btn5file).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnjsq
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnjsq;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnjsq_Click;
			if (_ll_btnjsq != null)
			{
				((Control)_ll_btnjsq).remove_Click(eventHandler);
			}
			_ll_btnjsq = value;
			if (_ll_btnjsq != null)
			{
				((Control)_ll_btnjsq).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnclear
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnclear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnclear_Click;
			if (_ll_btnclear != null)
			{
				((Control)_ll_btnclear).remove_Click(eventHandler);
			}
			_ll_btnclear = value;
			if (_ll_btnclear != null)
			{
				((Control)_ll_btnclear).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnremoved2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnremoved2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnremoved2_Click;
			if (_ll_btnremoved2 != null)
			{
				((Control)_ll_btnremoved2).remove_Click(eventHandler);
			}
			_ll_btnremoved2 = value;
			if (_ll_btnremoved2 != null)
			{
				((Control)_ll_btnremoved2).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnremoved1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnremoved1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnremoved1_Click;
			if (_ll_btnremoved1 != null)
			{
				((Control)_ll_btnremoved1).remove_Click(eventHandler);
			}
			_ll_btnremoved1 = value;
			if (_ll_btnremoved1 != null)
			{
				((Control)_ll_btnremoved1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnxia
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnxia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnxia_Click;
			if (_ll_btnxia != null)
			{
				((Control)_ll_btnxia).remove_Click(eventHandler);
			}
			_ll_btnxia = value;
			if (_ll_btnxia != null)
			{
				((Control)_ll_btnxia).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnshang
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnshang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnshang_Click;
			if (_ll_btnshang != null)
			{
				((Control)_ll_btnshang).remove_Click(eventHandler);
			}
			_ll_btnshang = value;
			if (_ll_btnshang != null)
			{
				((Control)_ll_btnshang).add_Click(eventHandler);
			}
		}
	}

	internal virtual ListBox ll_lbmeasures
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbmeasures;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbmeasures = value;
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

	internal virtual ListBox ll_lbresult
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbresult;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbresult = value;
		}
	}

	internal virtual ButtonX ll_btnoutput
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnoutput;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnoutput_Click;
			if (_ll_btnoutput != null)
			{
				((Control)_ll_btnoutput).remove_Click(eventHandler);
			}
			_ll_btnoutput = value;
			if (_ll_btnoutput != null)
			{
				((Control)_ll_btnoutput).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnpick2curlist
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnpick2curlist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnpick2curlist_Click;
			if (_ll_btnpick2curlist != null)
			{
				((Control)_ll_btnpick2curlist).remove_Click(eventHandler);
			}
			_ll_btnpick2curlist = value;
			if (_ll_btnpick2curlist != null)
			{
				((Control)_ll_btnpick2curlist).add_Click(eventHandler);
			}
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

	internal virtual CheckBoxX ll_opt2ctrlshift
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_opt2ctrlshift;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_opt2ctrlshift_Click;
			if (_ll_opt2ctrlshift != null)
			{
				((Control)_ll_opt2ctrlshift).remove_Click(eventHandler);
			}
			_ll_opt2ctrlshift = value;
			if (_ll_opt2ctrlshift != null)
			{
				((Control)_ll_opt2ctrlshift).add_Click(eventHandler);
			}
		}
	}

	internal virtual ListBox ll_lbliucheng
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbliucheng;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbliucheng = value;
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

	internal virtual OpenFileDialog GetOpenFilename
	{
		[DebuggerNonUserCode]
		get
		{
			return _GetOpenFilename;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GetOpenFilename = value;
		}
	}

	internal virtual SaveFileDialog GetSaveAsFilename
	{
		[DebuggerNonUserCode]
		get
		{
			return _GetSaveAsFilename;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GetSaveAsFilename = value;
		}
	}

	[DebuggerNonUserCode]
	public proejshz()
	{
		((Form)this).add_Load((EventHandler)proejshz_Load);
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
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_13f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1401: Expected O, but got Unknown
		//IL_14e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f1: Expected O, but got Unknown
		GroupPanel1 = new GroupPanel();
		GroupPanel2 = new GroupPanel();
		ll_opt2 = new CheckBoxX();
		ll_opt1 = new CheckBoxX();
		LabelX3 = new LabelX();
		ll_opt2ctrlshift = new CheckBoxX();
		ll_btn2file = new ButtonX();
		ll_btn5file = new ButtonX();
		ll_btnjsq = new ButtonX();
		ll_btnclear = new ButtonX();
		ll_btnremoved2 = new ButtonX();
		ll_btnremoved1 = new ButtonX();
		ll_btnxia = new ButtonX();
		ll_btnshang = new ButtonX();
		ll_lbmeasures = new ListBox();
		LabelX2 = new LabelX();
		LabelX1 = new LabelX();
		LabelX5 = new LabelX();
		ll_btnpath = new ButtonX();
		ll_btncheckthis = new ButtonX();
		ll_txtpath = new TextBoxX();
		LabelX4 = new LabelX();
		ll_lbresult = new ListBox();
		ll_btnoutput = new ButtonX();
		ll_btnpick2curlist = new ButtonX();
		ll_btnexit = new ButtonX();
		ll_lbliucheng = new ListBox();
		GetOpenFilename = new OpenFileDialog();
		GetSaveAsFilename = new SaveFileDialog();
		((Control)GroupPanel1).SuspendLayout();
		((Control)GroupPanel2).SuspendLayout();
		((Control)this).SuspendLayout();
		((PanelControl)GroupPanel1).set_CanvasColor(SystemColors.Control);
		((PanelControl)GroupPanel1).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)GroupPanel2);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)ll_btn2file);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)ll_btn5file);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)ll_btnjsq);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)ll_btnclear);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)ll_btnremoved2);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)ll_btnremoved1);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)ll_btnxia);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)ll_btnshang);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)ll_lbmeasures);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)LabelX2);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)LabelX1);
		GroupPanel groupPanel = GroupPanel1;
		Point location = new Point(2, 2);
		((Control)groupPanel).set_Location(location);
		((Control)GroupPanel1).set_Name("GroupPanel1");
		GroupPanel groupPanel2 = GroupPanel1;
		Size size = new Size(314, 421);
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
		((Control)GroupPanel1).set_TabIndex(0);
		((PanelControl)GroupPanel2).set_CanvasColor(SystemColors.Control);
		((PanelControl)GroupPanel2).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)ll_opt2);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)ll_opt1);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)LabelX3);
		((Control)GroupPanel2).get_Controls().Add((Control)(object)ll_opt2ctrlshift);
		GroupPanel groupPanel3 = GroupPanel2;
		location = new Point(216, 296);
		((Control)groupPanel3).set_Location(location);
		((Control)GroupPanel2).set_Name("GroupPanel2");
		GroupPanel groupPanel4 = GroupPanel2;
		size = new Size(86, 106);
		((Control)groupPanel4).set_Size(size);
		((PanelControl)GroupPanel2).get_Style().set_BackColor2SchemePart((eColorSchemePart)52);
		((PanelControl)GroupPanel2).get_Style().set_BackColorGradientAngle(90);
		((PanelControl)GroupPanel2).get_Style().set_BackColorSchemePart((eColorSchemePart)51);
		((PanelControl)GroupPanel2).get_Style().set_BorderBottom((eStyleBorderType)1);
		((PanelControl)GroupPanel2).get_Style().set_BorderBottomWidth(1);
		((PanelControl)GroupPanel2).get_Style().set_BorderColorSchemePart((eColorSchemePart)53);
		((PanelControl)GroupPanel2).get_Style().set_BorderLeft((eStyleBorderType)1);
		((PanelControl)GroupPanel2).get_Style().set_BorderLeftWidth(1);
		((PanelControl)GroupPanel2).get_Style().set_BorderRight((eStyleBorderType)1);
		((PanelControl)GroupPanel2).get_Style().set_BorderRightWidth(1);
		((PanelControl)GroupPanel2).get_Style().set_BorderTop((eStyleBorderType)1);
		((PanelControl)GroupPanel2).get_Style().set_BorderTopWidth(1);
		((PanelControl)GroupPanel2).get_Style().set_Class("");
		((PanelControl)GroupPanel2).get_Style().set_CornerDiameter(4);
		((PanelControl)GroupPanel2).get_Style().set_CornerType((eCornerType)2);
		((PanelControl)GroupPanel2).get_Style().set_TextAlignment((eStyleTextAlignment)1);
		((PanelControl)GroupPanel2).get_Style().set_TextColorSchemePart((eColorSchemePart)54);
		((PanelControl)GroupPanel2).get_Style().set_TextLineAlignment((eStyleTextAlignment)0);
		((PanelControl)GroupPanel2).get_StyleMouseDown().set_Class("");
		((PanelControl)GroupPanel2).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)GroupPanel2).get_StyleMouseOver().set_Class("");
		((PanelControl)GroupPanel2).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)GroupPanel2).set_TabIndex(4);
		((BaseItemControl)ll_opt2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_opt2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		ll_opt2.set_CheckBoxStyle((eCheckBoxStyle)1);
		((BaseItemControl)ll_opt2).set_FocusCuesEnabled(false);
		CheckBoxX obj = ll_opt2;
		location = new Point(-1, 45);
		((Control)obj).set_Location(location);
		((Control)ll_opt2).set_Name("ll_opt2");
		CheckBoxX obj2 = ll_opt2;
		size = new Size(83, 15);
		((Control)obj2).set_Size(size);
		((BaseItemControl)ll_opt2).set_Style((eDotNetBarStyle)7);
		((Control)ll_opt2).set_TabIndex(2);
		ll_opt2.set_Text("多选");
		((BaseItemControl)ll_opt1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_opt1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		ll_opt1.set_CheckBoxStyle((eCheckBoxStyle)1);
		((BaseItemControl)ll_opt1).set_FocusCuesEnabled(false);
		CheckBoxX obj3 = ll_opt1;
		location = new Point(-1, 22);
		((Control)obj3).set_Location(location);
		((Control)ll_opt1).set_Name("ll_opt1");
		CheckBoxX obj4 = ll_opt1;
		size = new Size(83, 15);
		((Control)obj4).set_Size(size);
		((BaseItemControl)ll_opt1).set_Style((eDotNetBarStyle)7);
		((Control)ll_opt1).set_TabIndex(2);
		ll_opt1.set_Text("单选");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX = LabelX3;
		location = new Point(1, 3);
		((Control)labelX).set_Location(location);
		((Control)LabelX3).set_Name("LabelX3");
		LabelX labelX2 = LabelX3;
		size = new Size(62, 16);
		((Control)labelX2).set_Size(size);
		((Control)LabelX3).set_TabIndex(1);
		LabelX3.set_Text("选择方式");
		((BaseItemControl)ll_opt2ctrlshift).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_opt2ctrlshift).get_BackgroundStyle().set_CornerType((eCornerType)1);
		ll_opt2ctrlshift.set_CheckBoxStyle((eCheckBoxStyle)1);
		((BaseItemControl)ll_opt2ctrlshift).set_FocusCuesEnabled(false);
		CheckBoxX obj5 = ll_opt2ctrlshift;
		location = new Point(-1, 51);
		((Control)obj5).set_Location(location);
		((Control)ll_opt2ctrlshift).set_Name("ll_opt2ctrlshift");
		CheckBoxX obj6 = ll_opt2ctrlshift;
		size = new Size(83, 47);
		((Control)obj6).set_Size(size);
		((BaseItemControl)ll_opt2ctrlshift).set_Style((eDotNetBarStyle)7);
		((Control)ll_opt2ctrlshift).set_TabIndex(2);
		ll_opt2ctrlshift.set_Text("多选ctrl/shift");
		((Control)ll_btn2file).set_AccessibleRole((AccessibleRole)43);
		ll_btn2file.set_ColorTable((eButtonColor)3);
		ButtonX obj7 = ll_btn2file;
		location = new Point(216, 260);
		((Control)obj7).set_Location(location);
		((Control)ll_btn2file).set_Name("ll_btn2file");
		ButtonX obj8 = ll_btn2file;
		size = new Size(86, 23);
		((Control)obj8).set_Size(size);
		((PopupItemControl)ll_btn2file).set_Style((eDotNetBarStyle)7);
		((Control)ll_btn2file).set_TabIndex(3);
		ll_btn2file.set_Text("保存至文件");
		((Control)ll_btn5file).set_AccessibleRole((AccessibleRole)43);
		ll_btn5file.set_ColorTable((eButtonColor)3);
		ButtonX obj9 = ll_btn5file;
		location = new Point(216, 231);
		((Control)obj9).set_Location(location);
		((Control)ll_btn5file).set_Name("ll_btn5file");
		ButtonX obj10 = ll_btn5file;
		size = new Size(86, 23);
		((Control)obj10).set_Size(size);
		((PopupItemControl)ll_btn5file).set_Style((eDotNetBarStyle)7);
		((Control)ll_btn5file).set_TabIndex(3);
		ll_btn5file.set_Text("来自文件");
		((Control)ll_btnjsq).set_AccessibleRole((AccessibleRole)43);
		ll_btnjsq.set_ColorTable((eButtonColor)3);
		ButtonX obj11 = ll_btnjsq;
		location = new Point(216, 195);
		((Control)obj11).set_Location(location);
		((Control)ll_btnjsq).set_Name("ll_btnjsq");
		ButtonX obj12 = ll_btnjsq;
		size = new Size(86, 23);
		((Control)obj12).set_Size(size);
		((PopupItemControl)ll_btnjsq).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnjsq).set_TabIndex(3);
		ll_btnjsq.set_Text("当前测量个数");
		((Control)ll_btnclear).set_AccessibleRole((AccessibleRole)43);
		ll_btnclear.set_ColorTable((eButtonColor)3);
		ButtonX obj13 = ll_btnclear;
		location = new Point(216, 166);
		((Control)obj13).set_Location(location);
		((Control)ll_btnclear).set_Name("ll_btnclear");
		ButtonX obj14 = ll_btnclear;
		size = new Size(86, 23);
		((Control)obj14).set_Size(size);
		((PopupItemControl)ll_btnclear).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnclear).set_TabIndex(3);
		ll_btnclear.set_Text("清空");
		((Control)ll_btnremoved2).set_AccessibleRole((AccessibleRole)43);
		ll_btnremoved2.set_ColorTable((eButtonColor)3);
		ButtonX obj15 = ll_btnremoved2;
		location = new Point(216, 137);
		((Control)obj15).set_Location(location);
		((Control)ll_btnremoved2).set_Name("ll_btnremoved2");
		ButtonX obj16 = ll_btnremoved2;
		size = new Size(86, 23);
		((Control)obj16).set_Size(size);
		((PopupItemControl)ll_btnremoved2).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnremoved2).set_TabIndex(3);
		ll_btnremoved2.set_Text("移除多行");
		((Control)ll_btnremoved1).set_AccessibleRole((AccessibleRole)43);
		ll_btnremoved1.set_ColorTable((eButtonColor)3);
		ButtonX obj17 = ll_btnremoved1;
		location = new Point(216, 108);
		((Control)obj17).set_Location(location);
		((Control)ll_btnremoved1).set_Name("ll_btnremoved1");
		ButtonX obj18 = ll_btnremoved1;
		size = new Size(86, 23);
		((Control)obj18).set_Size(size);
		((PopupItemControl)ll_btnremoved1).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnremoved1).set_TabIndex(3);
		ll_btnremoved1.set_Text("移除当前行");
		((Control)ll_btnxia).set_AccessibleRole((AccessibleRole)43);
		ll_btnxia.set_ColorTable((eButtonColor)3);
		ButtonX obj19 = ll_btnxia;
		location = new Point(216, 79);
		((Control)obj19).set_Location(location);
		((Control)ll_btnxia).set_Name("ll_btnxia");
		ButtonX obj20 = ll_btnxia;
		size = new Size(86, 23);
		((Control)obj20).set_Size(size);
		((PopupItemControl)ll_btnxia).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnxia).set_TabIndex(3);
		ll_btnxia.set_Text("下移");
		((Control)ll_btnshang).set_AccessibleRole((AccessibleRole)43);
		ll_btnshang.set_ColorTable((eButtonColor)3);
		ButtonX obj21 = ll_btnshang;
		location = new Point(216, 50);
		((Control)obj21).set_Location(location);
		((Control)ll_btnshang).set_Name("ll_btnshang");
		ButtonX obj22 = ll_btnshang;
		size = new Size(86, 23);
		((Control)obj22).set_Size(size);
		((PopupItemControl)ll_btnshang).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnshang).set_TabIndex(3);
		ll_btnshang.set_Text("上移");
		((ListControl)ll_lbmeasures).set_FormattingEnabled(true);
		ll_lbmeasures.set_ItemHeight(12);
		ListBox obj23 = ll_lbmeasures;
		location = new Point(7, 50);
		((Control)obj23).set_Location(location);
		((Control)ll_lbmeasures).set_Name("ll_lbmeasures");
		ListBox obj24 = ll_lbmeasures;
		size = new Size(203, 352);
		((Control)obj24).set_Size(size);
		((Control)ll_lbmeasures).set_TabIndex(2);
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX3 = LabelX2;
		location = new Point(7, 24);
		((Control)labelX3).set_Location(location);
		((Control)LabelX2).set_Name("LabelX2");
		LabelX labelX4 = LabelX2;
		size = new Size(127, 23);
		((Control)labelX4).set_Size(size);
		((Control)LabelX2).set_TabIndex(1);
		LabelX2.set_Text("预提取的测量列表");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX5 = LabelX1;
		location = new Point(7, 3);
		((Control)labelX5).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX6 = LabelX1;
		size = new Size(75, 20);
		((Control)labelX6).set_Size(size);
		((Control)LabelX1).set_TabIndex(1);
		LabelX1.set_Text("测量定义");
		((BaseItemControl)LabelX5).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX5).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX7 = LabelX5;
		location = new Point(2, 439);
		((Control)labelX7).set_Location(location);
		((Control)LabelX5).set_Name("LabelX5");
		LabelX labelX8 = LabelX5;
		size = new Size(127, 16);
		((Control)labelX8).set_Size(size);
		((Control)LabelX5).set_TabIndex(1);
		LabelX5.set_Text("当前操作记录");
		((Control)ll_btnpath).set_AccessibleRole((AccessibleRole)43);
		ll_btnpath.set_ColorTable((eButtonColor)3);
		ButtonX obj25 = ll_btnpath;
		location = new Point(322, 2);
		((Control)obj25).set_Location(location);
		((Control)ll_btnpath).set_Name("ll_btnpath");
		ButtonX obj26 = ll_btnpath;
		size = new Size(157, 26);
		((Control)obj26).set_Size(size);
		((PopupItemControl)ll_btnpath).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnpath).set_TabIndex(3);
		ll_btnpath.set_Text("指定预提取结果文件夹");
		((Control)ll_btncheckthis).set_AccessibleRole((AccessibleRole)43);
		ll_btncheckthis.set_ColorTable((eButtonColor)3);
		ButtonX obj27 = ll_btncheckthis;
		location = new Point(485, 2);
		((Control)obj27).set_Location(location);
		((Control)ll_btncheckthis).set_Name("ll_btncheckthis");
		ButtonX obj28 = ll_btncheckthis;
		size = new Size(94, 26);
		((Control)obj28).set_Size(size);
		((PopupItemControl)ll_btncheckthis).set_Style((eDotNetBarStyle)7);
		((Control)ll_btncheckthis).set_TabIndex(3);
		ll_btncheckthis.set_Text("结果文件夹检查");
		ll_txtpath.get_Border().set_Class("TextBoxBorder");
		ll_txtpath.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj29 = ll_txtpath;
		location = new Point(322, 31);
		((Control)obj29).set_Location(location);
		((Control)ll_txtpath).set_Name("ll_txtpath");
		((TextBoxBase)ll_txtpath).set_ReadOnly(true);
		TextBoxX obj30 = ll_txtpath;
		size = new Size(544, 21);
		((Control)obj30).set_Size(size);
		((Control)ll_txtpath).set_TabIndex(0);
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX9 = LabelX4;
		location = new Point(322, 55);
		((Control)labelX9).set_Location(location);
		((Control)LabelX4).set_Name("LabelX4");
		LabelX labelX10 = LabelX4;
		size = new Size(194, 15);
		((Control)labelX10).set_Size(size);
		((Control)LabelX4).set_TabIndex(1);
		LabelX4.set_Text("与预测量相应的结果列表");
		((ListControl)ll_lbresult).set_FormattingEnabled(true);
		ll_lbresult.set_HorizontalScrollbar(true);
		ll_lbresult.set_ItemHeight(12);
		ListBox obj31 = ll_lbresult;
		location = new Point(322, 71);
		((Control)obj31).set_Location(location);
		((Control)ll_lbresult).set_Name("ll_lbresult");
		ListBox obj32 = ll_lbresult;
		size = new Size(544, 352);
		((Control)obj32).set_Size(size);
		((Control)ll_lbresult).set_TabIndex(2);
		((Control)ll_btnoutput).set_AccessibleRole((AccessibleRole)43);
		ll_btnoutput.set_ColorTable((eButtonColor)3);
		ButtonX obj33 = ll_btnoutput;
		location = new Point(529, 429);
		((Control)obj33).set_Location(location);
		((Control)ll_btnoutput).set_Name("ll_btnoutput");
		ButtonX obj34 = ll_btnoutput;
		size = new Size(131, 26);
		((Control)obj34).set_Size(size);
		((PopupItemControl)ll_btnoutput).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnoutput).set_TabIndex(5);
		ll_btnoutput.set_Text("输出当前结果表");
		((Control)ll_btnpick2curlist).set_AccessibleRole((AccessibleRole)43);
		ll_btnpick2curlist.set_ColorTable((eButtonColor)3);
		ButtonX obj35 = ll_btnpick2curlist;
		location = new Point(322, 429);
		((Control)obj35).set_Location(location);
		((Control)ll_btnpick2curlist).set_Name("ll_btnpick2curlist");
		ButtonX obj36 = ll_btnpick2curlist;
		size = new Size(131, 26);
		((Control)obj36).set_Size(size);
		((PopupItemControl)ll_btnpick2curlist).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnpick2curlist).set_TabIndex(4);
		ll_btnpick2curlist.set_Text("结果提取");
		((Control)ll_btnexit).set_AccessibleRole((AccessibleRole)43);
		ll_btnexit.set_ColorTable((eButtonColor)3);
		ll_btnexit.set_DialogResult((DialogResult)2);
		ButtonX obj37 = ll_btnexit;
		location = new Point(735, 429);
		((Control)obj37).set_Location(location);
		((Control)ll_btnexit).set_Name("ll_btnexit");
		ButtonX obj38 = ll_btnexit;
		size = new Size(131, 26);
		((Control)obj38).set_Size(size);
		((PopupItemControl)ll_btnexit).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnexit).set_TabIndex(5);
		ll_btnexit.set_Text("关闭");
		((ListControl)ll_lbliucheng).set_FormattingEnabled(true);
		ll_lbliucheng.set_ItemHeight(12);
		ListBox obj39 = ll_lbliucheng;
		location = new Point(2, 461);
		((Control)obj39).set_Location(location);
		((Control)ll_lbliucheng).set_Name("ll_lbliucheng");
		ListBox obj40 = ll_lbliucheng;
		size = new Size(864, 160);
		((Control)obj40).set_Size(size);
		((Control)ll_lbliucheng).set_TabIndex(2);
		((FileDialog)GetSaveAsFilename).set_Filter("CSV 逗号分隔|*.csv");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)ll_btnexit);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(871, 624);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ll_btnexit);
		((Control)this).get_Controls().Add((Control)(object)ll_btnoutput);
		((Control)this).get_Controls().Add((Control)(object)ll_btnpick2curlist);
		((Control)this).get_Controls().Add((Control)(object)LabelX5);
		((Control)this).get_Controls().Add((Control)(object)ll_txtpath);
		((Control)this).get_Controls().Add((Control)(object)GroupPanel1);
		((Control)this).get_Controls().Add((Control)(object)ll_btncheckthis);
		((Control)this).get_Controls().Add((Control)(object)ll_btnpath);
		((Control)this).get_Controls().Add((Control)(object)LabelX4);
		((Control)this).get_Controls().Add((Control)(object)ll_lbliucheng);
		((Control)this).get_Controls().Add((Control)(object)ll_lbresult);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("proejshz");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("PROE4.0 多工况计算结果汇总.. .");
		((Control)GroupPanel1).ResumeLayout(false);
		((Control)GroupPanel2).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void proejshz_Load(object sender, EventArgs e)
	{
		((Control)LabelX1).set_BackColor(Color.Transparent);
		((Control)LabelX2).set_BackColor(Color.Transparent);
		((Control)LabelX3).set_BackColor(Color.Transparent);
		((Control)ll_opt1).set_BackColor(Color.Transparent);
		((Control)ll_opt2).set_BackColor(Color.Transparent);
		((Control)ll_opt2ctrlshift).set_BackColor(Color.Transparent);
		((Control)LabelX5).set_BackColor(Color.Transparent);
		ll_opt1.set_Checked(true);
		((Control)ll_btnpick2curlist).set_Enabled(false);
		((Control)ll_btn5file).set_ForeColor(Color.Green);
		((Control)ll_btnoutput).set_Enabled(false);
		strtemp = "提示:[测量定义]->[来自文件],在计算结果目录中选择含有测量列表的某csv文件.";
		ll_lbliucheng.get_Items().Add((object)strtemp);
		strtemp = "常规操作流程:[测量定义]->[来自文件]->[指定预提取结果文件夹]->[结果提取]->[输出当前结果表].";
		ll_lbliucheng.get_Items().Add((object)strtemp);
	}

	private void ll_btnshang_Click(object sender, EventArgs e)
	{
		checked
		{
			if (ll_lbmeasures.get_SelectedIndex() >= 1)
			{
				curvalue = ll_lbmeasures.get_Text();
				curi = ll_lbmeasures.get_SelectedIndex();
				ll_lbmeasures.get_Items().set_Item(curi, RuntimeHelpers.GetObjectValue(ll_lbmeasures.get_Items().get_Item(curi - 1)));
				ll_lbmeasures.get_Items().set_Item(curi - 1, (object)curvalue);
				ll_lbmeasures.set_SelectedIndex(curi - 1);
			}
		}
	}

	private void ll_btnxia_Click(object sender, EventArgs e)
	{
		checked
		{
			if (ll_lbmeasures.get_SelectedIndex() <= ll_lbmeasures.get_Items().get_Count() - 2)
			{
				curvalue = ll_lbmeasures.get_Text();
				curi = ll_lbmeasures.get_SelectedIndex();
				ll_lbmeasures.get_Items().set_Item(curi, RuntimeHelpers.GetObjectValue(ll_lbmeasures.get_Items().get_Item(curi + 1)));
				ll_lbmeasures.get_Items().set_Item(curi + 1, (object)curvalue);
				ll_lbmeasures.set_SelectedIndex(curi + 1);
			}
		}
	}

	private void ll_btnremoved1_Click(object sender, EventArgs e)
	{
		if ((ll_lbmeasures.get_Items().get_Count() != 0) & (ll_lbmeasures.get_SelectedIndex() != -1))
		{
			ll_lbmeasures.get_Items().RemoveAt(ll_lbmeasures.get_SelectedIndex());
		}
	}

	private void ll_btnremoved2_Click(object sender, EventArgs e)
	{
		if (!((ll_lbmeasures.get_Items().get_Count() != 0) & (ll_lbmeasures.get_SelectedIndex() != -1)))
		{
			return;
		}
		checked
		{
			for (int i = ll_lbmeasures.get_Items().get_Count() - 1; i >= 0; i += -1)
			{
				if (ll_lbmeasures.GetSelected(i))
				{
					ll_lbmeasures.get_Items().RemoveAt(i);
				}
			}
		}
	}

	private void ll_btnclear_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		if (ll_lbmeasures.get_Items().get_Count() > 0 && (int)MessageBox.Show("是否清空当前列表中的信息?", "提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 6)
		{
			ll_lbmeasures.get_Items().Clear();
		}
	}

	private void ll_btnjsq_Click(object sender, EventArgs e)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)("当前测量个数:" + Conversions.ToString(ll_lbmeasures.get_Items().get_Count())), (MsgBoxStyle)0, (object)"提示");
	}

	private void ll_btn5file_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Invalid comparison between Unknown and I4
		if (ll_lbmeasures.get_Items().get_Count() != 0 && (int)MessageBox.Show("继续操作会覆盖当前列表中的信息,是否继续?", "提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 7)
		{
			return;
		}
		((FileDialog)GetOpenFilename).set_Filter("CSV 逗号分隔|*.csv");
		if ((int)((CommonDialog)GetOpenFilename).ShowDialog() != 1)
		{
			return;
		}
		fname = ((FileDialog)GetOpenFilename).get_FileName();
		if (!File.Exists(fname))
		{
			return;
		}
		ll_lbmeasures.get_Items().Clear();
		Mod1.lr = new StreamReader(fname, Encoding.Default);
		string text = "";
		text = Mod1.lr.ReadLine();
		text = Mod1.lr.ReadLine();
		while (true)
		{
			if (!Information.IsNothing((object)text))
			{
				text = Mod1.lr.ReadLine();
				if (!Information.IsNothing((object)text))
				{
					strtemp += text;
					if (Operators.CompareString(Strings.Trim(text), "", false) != 0)
					{
						string[] array = Strings.Split(text, ",", -1, (CompareMethod)0);
						ll_lbmeasures.get_Items().Add((object)array[0]);
						continue;
					}
					break;
				}
			}
			Mod1.lr.Close();
			Mod1.lr.Dispose();
			strtemp = "当前测量 [来自文件];" + fname;
			ll_lbliucheng.get_Items().Add((object)strtemp);
			ll_lbliucheng.set_SelectedIndex(checked(ll_lbliucheng.get_Items().get_Count() - 1));
			break;
		}
	}

	private void ll_btn2file_Click(object sender, EventArgs e)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		if (ll_lbmeasures.get_Items().get_Count() == 0)
		{
			return;
		}
		((FileDialog)GetSaveAsFilename).set_InitialDirectory("measures");
		if ((int)((CommonDialog)GetSaveAsFilename).ShowDialog() == 1)
		{
			fname = ((FileDialog)GetSaveAsFilename).get_FileName();
			Mod1.wr = new StreamWriter(fname, append: false, Encoding.Default);
			Mod1.wr.WriteLine("");
			Mod1.wr.WriteLine("");
			checked
			{
				int num = ll_lbmeasures.get_Items().get_Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					Mod1.wr.WriteLine(RuntimeHelpers.GetObjectValue(ll_lbmeasures.get_Items().get_Item(i)));
				}
				Mod1.wr.Close();
				Mod1.wr.Dispose();
				strtemp = "当前测量 [保存至文件].双击文件可以查看该文件.";
				ll_lbliucheng.get_Items().Add((object)strtemp);
				ll_lbliucheng.get_Items().Add((object)fname);
			}
		}
	}

	private void ll_opt1_Click(object sender, EventArgs e)
	{
		ll_lbmeasures.set_SelectionMode((SelectionMode)1);
		((Control)ll_btnshang).set_Enabled(true);
		((Control)ll_btnxia).set_Enabled(true);
		((Control)ll_btnremoved1).set_Enabled(true);
		((Control)ll_btnremoved2).set_Enabled(false);
	}

	private void ll_btnexit_Click(object sender, EventArgs e)
	{
		checked
		{
			if (ll_lbliucheng.get_Items().get_Count() != 0)
			{
				int num = ll_lbliucheng.get_Items().get_Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					MyProject.Forms.Main.lslog.get_Items().Add(RuntimeHelpers.GetObjectValue(ll_lbliucheng.get_Items().get_Item(i)));
				}
			}
			MyProject.Forms.Main.lslog.set_SelectedIndex(MyProject.Forms.Main.lslog.get_Items().get_Count() - 1);
			((Form)this).Close();
		}
	}

	private void ll_opt2_Click(object sender, EventArgs e)
	{
		ll_lbmeasures.set_SelectionMode((SelectionMode)2);
		((Control)ll_btnshang).set_Enabled(false);
		((Control)ll_btnxia).set_Enabled(false);
		((Control)ll_btnremoved1).set_Enabled(false);
		((Control)ll_btnremoved2).set_Enabled(true);
	}

	private void ll_opt2ctrlshift_Click(object sender, EventArgs e)
	{
		ll_lbmeasures.set_SelectionMode((SelectionMode)3);
		((Control)ll_btnshang).set_Enabled(false);
		((Control)ll_btnxia).set_Enabled(false);
		((Control)ll_btnremoved1).set_Enabled(false);
		((Control)ll_btnremoved2).set_Enabled(true);
	}

	private void ll_btnpath_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		FolderBrowserDialog val = new FolderBrowserDialog();
		val.set_Description("请指定已进行批量计算成功的结果文件所在路径");
		((CommonDialog)val).ShowDialog();
		string selectedPath = val.get_SelectedPath();
		if (Operators.CompareString(selectedPath, "", false) != 0)
		{
			((TextBox)ll_txtpath).set_Text(selectedPath);
		}
		selectedPath = null;
		ll_btncheckthis_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void ll_btncheckthis_Click(object sender, EventArgs e)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		((Control)ll_btnpick2curlist).set_Enabled(false);
		string text = ((TextBox)ll_txtpath).get_Text();
		if (Operators.CompareString(Strings.Trim(text), "", false) == 0)
		{
			return;
		}
		if (!Directory.Exists(text))
		{
			Interaction.MsgBox((object)("当前输入路径不存在." + text), (MsgBoxStyle)0, (object)"提示");
			return;
		}
		string[] array = Strings.Split(text, " ", -1, (CompareMethod)0);
		if (Information.UBound((Array)array, 1) > 0)
		{
			Interaction.MsgBox((object)"** 当前指定的路径含有空格,请重新指定.", (MsgBoxStyle)0, (object)"提示");
			return;
		}
		array = Strings.Split(text, "\\", -1, (CompareMethod)0);
		if (Information.UBound((Array)array, 1) == 0)
		{
			Interaction.MsgBox((object)"** 当前指定的路径不合法.", (MsgBoxStyle)0, (object)"提示");
			return;
		}
		((Control)ll_btnpick2curlist).set_Enabled(true);
		((Control)ll_btnpick2curlist).set_BackColor(Color.Green);
	}

	private void ll_btnpick2curlist_Click(object sender, EventArgs e)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (ll_lbmeasures.get_Items().get_Count() == 0 || (ll_lbresult.get_Items().get_Count() != 0 && unchecked((int)MessageBox.Show("重新提取相应测量结果数据吗?", "提示", (MessageBoxButtons)4, (MessageBoxIcon)64)) == 7))
				{
					return;
				}
				ll_lbresult.get_Items().Clear();
				strtemp = "标识";
				int num = ll_lbmeasures.get_Items().get_Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					strtemp = Conversions.ToString(Operators.ConcatenateObject((object)(strtemp + ","), ll_lbmeasures.get_Items().get_Item(i)));
				}
				ll_lbresult.get_Items().Add((object)strtemp);
				string text = ((TextBox)ll_txtpath).get_Text();
				if (Operators.CompareString(Strings.Right(text, 1), "\\", false) != 0)
				{
					text += "\\";
				}
				string[] files = Directory.GetFiles(text, "*.csv", SearchOption.AllDirectories);
				int num2 = 0;
				int num3 = files.Count() - 1;
				for (int j = 0; j <= num3; j++)
				{
					num2++;
					string text2 = files[j];
					string text3 = Conversions.ToString(Strings.InStrRev(text2, "\\", -1, (CompareMethod)0));
					string text4 = Strings.Right(text2, (int)Math.Round((double)Strings.Len(text2) - Conversions.ToDouble(text3)));
					string[] array = Strings.Split(text4, ".", -1, (CompareMethod)0);
					string text5 = (strtemp = array[0]);
					Mod1.lr = new StreamReader(text2, Encoding.Default);
					string text6 = Mod1.lr.ReadLine();
					text6 = Mod1.lr.ReadLine();
					while (!Information.IsNothing((object)text6))
					{
						text6 = Mod1.lr.ReadLine();
						if (Operators.CompareString(Strings.Trim(text6), "", false) == 0)
						{
							break;
						}
						array = Strings.Split(text6, ",", -1, (CompareMethod)0);
						if (Information.UBound((Array)array, 1) < 1)
						{
							continue;
						}
						string text7 = array[0];
						curvalue = array[1];
						int num4 = ll_lbmeasures.get_Items().get_Count() - 1;
						for (int k = 0; k <= num4; k++)
						{
							if (Operators.CompareString(Strings.Trim(text7), Strings.Trim(Conversions.ToString(ll_lbmeasures.get_Items().get_Item(k))), false) == 0)
							{
								strtemp = strtemp + "," + Strings.Trim(curvalue);
							}
						}
					}
					Mod1.lr.Close();
					Mod1.lr.Dispose();
					ll_lbresult.get_Items().Add((object)strtemp);
				}
				strtemp = "[结果提取] 共处理了 " + Conversions.ToString(num2) + " 个文件!";
				ll_lbliucheng.get_Items().Add((object)strtemp);
				((Control)ll_btnoutput).set_Enabled(true);
				((Control)ll_btnoutput).set_ForeColor(Color.Green);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox((object)("提取失败,可能是指定的测量数量过多,当前为:" + Conversions.ToString(ll_lbmeasures.get_Items().get_Count() + 1) + " .通常调整为100以内"), (MsgBoxStyle)0, (object)"提示");
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ll_btnoutput_Click(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (ll_lbresult.get_Items().get_Count() == 0)
			{
				return;
			}
			((FileDialog)GetSaveAsFilename).set_InitialDirectory("results");
			if ((int)((CommonDialog)GetSaveAsFilename).ShowDialog() == 1)
			{
				fname = ((FileDialog)GetSaveAsFilename).get_FileName();
				Mod1.wr = new StreamWriter(fname, append: false, Encoding.Default);
				checked
				{
					int num = ll_lbresult.get_Items().get_Count() - 1;
					for (int i = 0; i <= num; i++)
					{
						Mod1.wr.WriteLine(RuntimeHelpers.GetObjectValue(ll_lbresult.get_Items().get_Item(i)));
					}
					Mod1.wr.Close();
					Mod1.wr.Dispose();
					strtemp = "[输出当前结果表] 当前测量结果文件输出到文件;" + fname;
					ll_lbliucheng.get_Items().Add((object)strtemp);
					ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)("请查看是否在Excel中打开当前文件:" + fname + "\r\n如果是,需要关闭该文件方可继续当前操作."), (MsgBoxStyle)0, (object)"提示");
			strtemp = "请查看是否在Excel中打开如下文件,如果是,需要关闭该文件方可继续当前操作.双击文件可以查看该文件.";
			ll_lbliucheng.get_Items().Add((object)strtemp);
			ll_lbliucheng.get_Items().Add((object)fname);
			ProjectData.ClearProjectError();
		}
	}
}
