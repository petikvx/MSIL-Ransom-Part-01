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
using Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using pfcls;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class clxd : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("RibbonControl1")]
	private RibbonControl _RibbonControl1;

	[AccessedThroughProperty("RibbonPanel3")]
	private RibbonPanel _RibbonPanel3;

	[AccessedThroughProperty("RB3")]
	private RibbonBar _RB3;

	[AccessedThroughProperty("RibbonPanel2")]
	private RibbonPanel _RibbonPanel2;

	[AccessedThroughProperty("RB2")]
	private RibbonBar _RB2;

	[AccessedThroughProperty("bjxlsgx")]
	private ButtonItem _bjxlsgx;

	[AccessedThroughProperty("bjxlsck")]
	private ButtonItem _bjxlsck;

	[AccessedThroughProperty("bjlaygx")]
	private ButtonItem _bjlaygx;

	[AccessedThroughProperty("bjqd")]
	private ButtonItem _bjqd;

	[AccessedThroughProperty("RibbonPanel1")]
	private RibbonPanel _RibbonPanel1;

	[AccessedThroughProperty("RB1")]
	private RibbonBar _RB1;

	[AccessedThroughProperty("bicswb")]
	private ButtonItem _bicswb;

	[AccessedThroughProperty("biwbck")]
	private ButtonItem _biwbck;

	[AccessedThroughProperty("biccqd")]
	private ButtonItem _biccqd;

	[AccessedThroughProperty("RTI2")]
	private RibbonTabItem _RTI2;

	[AccessedThroughProperty("RTI3")]
	private RibbonTabItem _RTI3;

	[AccessedThroughProperty("ButtonItem2")]
	private ButtonItem _ButtonItem2;

	[AccessedThroughProperty("lbsl")]
	private ListBox _lbsl;

	[AccessedThroughProperty("LabelX2")]
	private LabelX _LabelX2;

	[AccessedThroughProperty("lbcl")]
	private ListBox _lbcl;

	[AccessedThroughProperty("LabelX3")]
	private LabelX _LabelX3;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("ButtonItem1")]
	private ButtonItem _ButtonItem1;

	[AccessedThroughProperty("Btngb")]
	private ButtonX _Btngb;

	[AccessedThroughProperty("RibbonPanel4")]
	private RibbonPanel _RibbonPanel4;

	[AccessedThroughProperty("RB4")]
	private RibbonBar _RB4;

	[AccessedThroughProperty("RTI4")]
	private RibbonTabItem _RTI4;

	[AccessedThroughProperty("ll_btnvarinfo")]
	private ButtonItem _ll_btnvarinfo;

	[AccessedThroughProperty("ButtonItem4")]
	private ButtonItem _ButtonItem4;

	[AccessedThroughProperty("ll_btnout")]
	private ButtonItem _ll_btnout;

	[AccessedThroughProperty("ll_btnlookout")]
	private ButtonItem _ll_btnlookout;

	[AccessedThroughProperty("lblog")]
	private ListBox _lblog;

	[AccessedThroughProperty("gb")]
	private ButtonItem _gb;

	[AccessedThroughProperty("btnhqmx")]
	private ButtonItem _btnhqmx;

	[AccessedThroughProperty("btnljproe")]
	private ButtonItem _btnljproe;

	[AccessedThroughProperty("RTI1")]
	private RibbonTabItem _RTI1;

	[AccessedThroughProperty("RibbonPanel5")]
	private RibbonPanel _RibbonPanel5;

	[AccessedThroughProperty("RB5")]
	private RibbonBar _RB5;

	[AccessedThroughProperty("btnfan")]
	private ButtonItem _btnfan;

	[AccessedThroughProperty("RTI5")]
	private RibbonTabItem _RTI5;

	[AccessedThroughProperty("gb3")]
	private ButtonItem _gb3;

	[AccessedThroughProperty("TM1")]
	private Timer _TM1;

	public Workbook wblay;

	public Worksheet sheetlay;

	public Excel.Range ran;

	public int CL;

	public int CH;

	public bool zd;

	public string lbtxt;

	public string ID;

	public int jlul;

	public int CCH;

	public Hashtable array;

	public bool a;

	public bool b;

	public bool c;

	public string shees;

	public string strtemp;

	public bool jr;

	private string cl1;

	private string sl;

	private string outpath;

	public bool uplay;

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

	internal virtual RibbonBar RB3
	{
		[DebuggerNonUserCode]
		get
		{
			return _RB3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RB3 = value;
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

	internal virtual RibbonBar RB2
	{
		[DebuggerNonUserCode]
		get
		{
			return _RB2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RB2 = value;
		}
	}

	internal virtual ButtonItem bjxlsgx
	{
		[DebuggerNonUserCode]
		get
		{
			return _bjxlsgx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = bjxlsgx_Click;
			if (_bjxlsgx != null)
			{
				((BaseItem)_bjxlsgx).remove_Click(eventHandler);
			}
			_bjxlsgx = value;
			if (_bjxlsgx != null)
			{
				((BaseItem)_bjxlsgx).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonItem bjxlsck
	{
		[DebuggerNonUserCode]
		get
		{
			return _bjxlsck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = bjxlsck_Click;
			if (_bjxlsck != null)
			{
				((BaseItem)_bjxlsck).remove_Click(eventHandler);
			}
			_bjxlsck = value;
			if (_bjxlsck != null)
			{
				((BaseItem)_bjxlsck).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonItem bjlaygx
	{
		[DebuggerNonUserCode]
		get
		{
			return _bjlaygx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = bjlaygx_Click;
			if (_bjlaygx != null)
			{
				((BaseItem)_bjlaygx).remove_Click(eventHandler);
			}
			_bjlaygx = value;
			if (_bjlaygx != null)
			{
				((BaseItem)_bjlaygx).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonItem bjqd
	{
		[DebuggerNonUserCode]
		get
		{
			return _bjqd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = bjqd_Click;
			if (_bjqd != null)
			{
				((BaseItem)_bjqd).remove_Click(eventHandler);
			}
			_bjqd = value;
			if (_bjqd != null)
			{
				((BaseItem)_bjqd).add_Click(eventHandler);
			}
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

	internal virtual RibbonBar RB1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RB1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RB1 = value;
		}
	}

	internal virtual ButtonItem bicswb
	{
		[DebuggerNonUserCode]
		get
		{
			return _bicswb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_bicswb = value;
		}
	}

	internal virtual ButtonItem biwbck
	{
		[DebuggerNonUserCode]
		get
		{
			return _biwbck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_biwbck = value;
		}
	}

	internal virtual ButtonItem biccqd
	{
		[DebuggerNonUserCode]
		get
		{
			return _biccqd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_biccqd = value;
		}
	}

	internal virtual RibbonTabItem RTI2
	{
		[DebuggerNonUserCode]
		get
		{
			return _RTI2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RTI2 = value;
		}
	}

	internal virtual RibbonTabItem RTI3
	{
		[DebuggerNonUserCode]
		get
		{
			return _RTI3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RTI3 = value;
		}
	}

	internal virtual ButtonItem ButtonItem2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ButtonItem2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ButtonItem2 = value;
		}
	}

	internal virtual ListBox lbsl
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbsl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lbsl_SelectedIndexChanged;
			if (_lbsl != null)
			{
				_lbsl.remove_SelectedIndexChanged(eventHandler);
			}
			_lbsl = value;
			if (_lbsl != null)
			{
				_lbsl.add_SelectedIndexChanged(eventHandler);
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

	internal virtual ListBox lbcl
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbcl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lbcl_SelectedIndexChanged;
			if (_lbcl != null)
			{
				_lbcl.remove_SelectedIndexChanged(eventHandler);
			}
			_lbcl = value;
			if (_lbcl != null)
			{
				_lbcl.add_SelectedIndexChanged(eventHandler);
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

	internal virtual ButtonItem ButtonItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ButtonItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ButtonItem1 = value;
		}
	}

	internal virtual ButtonX Btngb
	{
		[DebuggerNonUserCode]
		get
		{
			return _Btngb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btngb_Click;
			if (_Btngb != null)
			{
				((Control)_Btngb).remove_Click(eventHandler);
			}
			_Btngb = value;
			if (_Btngb != null)
			{
				((Control)_Btngb).add_Click(eventHandler);
			}
		}
	}

	internal virtual RibbonPanel RibbonPanel4
	{
		[DebuggerNonUserCode]
		get
		{
			return _RibbonPanel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RibbonPanel4 = value;
		}
	}

	internal virtual RibbonBar RB4
	{
		[DebuggerNonUserCode]
		get
		{
			return _RB4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RB4 = value;
		}
	}

	internal virtual RibbonTabItem RTI4
	{
		[DebuggerNonUserCode]
		get
		{
			return _RTI4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RTI4 = value;
		}
	}

	internal virtual ButtonItem ll_btnvarinfo
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnvarinfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnvarinfo_Click;
			if (_ll_btnvarinfo != null)
			{
				((BaseItem)_ll_btnvarinfo).remove_Click(eventHandler);
			}
			_ll_btnvarinfo = value;
			if (_ll_btnvarinfo != null)
			{
				((BaseItem)_ll_btnvarinfo).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonItem ButtonItem4
	{
		[DebuggerNonUserCode]
		get
		{
			return _ButtonItem4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ButtonItem4_Click;
			if (_ButtonItem4 != null)
			{
				((BaseItem)_ButtonItem4).remove_Click(eventHandler);
			}
			_ButtonItem4 = value;
			if (_ButtonItem4 != null)
			{
				((BaseItem)_ButtonItem4).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonItem ll_btnout
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnout;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnout_Click;
			if (_ll_btnout != null)
			{
				((BaseItem)_ll_btnout).remove_Click(eventHandler);
			}
			_ll_btnout = value;
			if (_ll_btnout != null)
			{
				((BaseItem)_ll_btnout).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonItem ll_btnlookout
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnlookout;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnlookout_Click;
			if (_ll_btnlookout != null)
			{
				((BaseItem)_ll_btnlookout).remove_Click(eventHandler);
			}
			_ll_btnlookout = value;
			if (_ll_btnlookout != null)
			{
				((BaseItem)_ll_btnlookout).add_Click(eventHandler);
			}
		}
	}

	public virtual ListBox lblog
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblog;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lblog_DoubleClick;
			if (_lblog != null)
			{
				((Control)_lblog).remove_DoubleClick(eventHandler);
			}
			_lblog = value;
			if (_lblog != null)
			{
				((Control)_lblog).add_DoubleClick(eventHandler);
			}
		}
	}

	internal virtual ButtonItem gb
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
				((BaseItem)_gb).remove_Click(eventHandler);
			}
			_gb = value;
			if (_gb != null)
			{
				((BaseItem)_gb).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonItem btnhqmx
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnhqmx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnhqmx_Click;
			if (_btnhqmx != null)
			{
				((BaseItem)_btnhqmx).remove_Click(eventHandler);
			}
			_btnhqmx = value;
			if (_btnhqmx != null)
			{
				((BaseItem)_btnhqmx).add_Click(eventHandler);
			}
		}
	}

	public virtual ButtonItem btnljproe
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnljproe;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnljproe_Click;
			if (_btnljproe != null)
			{
				((BaseItem)_btnljproe).remove_Click(eventHandler);
			}
			_btnljproe = value;
			if (_btnljproe != null)
			{
				((BaseItem)_btnljproe).add_Click(eventHandler);
			}
		}
	}

	internal virtual RibbonTabItem RTI1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RTI1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RTI1 = value;
		}
	}

	internal virtual RibbonPanel RibbonPanel5
	{
		[DebuggerNonUserCode]
		get
		{
			return _RibbonPanel5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RibbonPanel5 = value;
		}
	}

	internal virtual RibbonBar RB5
	{
		[DebuggerNonUserCode]
		get
		{
			return _RB5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RB5 = value;
		}
	}

	internal virtual ButtonItem btnfan
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnfan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnfan_Click;
			if (_btnfan != null)
			{
				((BaseItem)_btnfan).remove_Click(eventHandler);
			}
			_btnfan = value;
			if (_btnfan != null)
			{
				((BaseItem)_btnfan).add_Click(eventHandler);
			}
		}
	}

	internal virtual RibbonTabItem RTI5
	{
		[DebuggerNonUserCode]
		get
		{
			return _RTI5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RTI5 = value;
		}
	}

	internal virtual ButtonItem gb3
	{
		[DebuggerNonUserCode]
		get
		{
			return _gb3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = gb_Click;
			if (_gb3 != null)
			{
				((BaseItem)_gb3).remove_Click(eventHandler);
			}
			_gb3 = value;
			if (_gb3 != null)
			{
				((BaseItem)_gb3).add_Click(eventHandler);
			}
		}
	}

	internal virtual Timer TM1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TM1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TM1_Tick;
			if (_TM1 != null)
			{
				_TM1.remove_Tick(eventHandler);
			}
			_TM1 = value;
			if (_TM1 != null)
			{
				_TM1.add_Tick(eventHandler);
			}
		}
	}

	public clxd()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)clxd_Load);
		((Form)this).add_FormClosed(new FormClosedEventHandler(clxd_FormClosed));
		array = new Hashtable();
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
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected O, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Expected O, but got Unknown
		//IL_084f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0859: Expected O, but got Unknown
		//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3b: Expected O, but got Unknown
		//IL_0b9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba7: Expected O, but got Unknown
		//IL_0c15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1f: Expected O, but got Unknown
		//IL_0c8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c97: Expected O, but got Unknown
		//IL_0d05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0f: Expected O, but got Unknown
		//IL_0dad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff1: Expected O, but got Unknown
		//IL_1053: Unknown result type (might be due to invalid IL or missing references)
		//IL_105d: Expected O, but got Unknown
		//IL_10bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c9: Expected O, but got Unknown
		//IL_112b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1135: Expected O, but got Unknown
		//IL_1197: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a1: Expected O, but got Unknown
		//IL_123f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1465: Unknown result type (might be due to invalid IL or missing references)
		//IL_146f: Expected O, but got Unknown
		//IL_1519: Unknown result type (might be due to invalid IL or missing references)
		//IL_1769: Unknown result type (might be due to invalid IL or missing references)
		//IL_1773: Expected O, but got Unknown
		//IL_17d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_17df: Expected O, but got Unknown
		//IL_1841: Unknown result type (might be due to invalid IL or missing references)
		//IL_184b: Expected O, but got Unknown
		//IL_19e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f2: Expected O, but got Unknown
		//IL_1a74: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a7e: Expected O, but got Unknown
		//IL_1b26: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b30: Expected O, but got Unknown
		//IL_1bb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bbe: Expected O, but got Unknown
		//IL_1c60: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c6a: Expected O, but got Unknown
		//IL_1d05: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d0f: Expected O, but got Unknown
		//IL_1e12: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e1c: Expected O, but got Unknown
		//IL_1ecf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ed9: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(clxd));
		RibbonControl1 = new RibbonControl();
		RibbonPanel5 = new RibbonPanel();
		RB5 = new RibbonBar();
		btnfan = new ButtonItem();
		gb3 = new ButtonItem();
		RibbonPanel2 = new RibbonPanel();
		RB2 = new RibbonBar();
		bjxlsgx = new ButtonItem();
		bjxlsck = new ButtonItem();
		btnhqmx = new ButtonItem();
		bjlaygx = new ButtonItem();
		bjqd = new ButtonItem();
		RibbonPanel4 = new RibbonPanel();
		RB4 = new RibbonBar();
		ll_btnvarinfo = new ButtonItem();
		ButtonItem4 = new ButtonItem();
		ll_btnout = new ButtonItem();
		ll_btnlookout = new ButtonItem();
		gb = new ButtonItem();
		RibbonPanel3 = new RibbonPanel();
		RB3 = new RibbonBar();
		btnljproe = new ButtonItem();
		RibbonPanel1 = new RibbonPanel();
		RB1 = new RibbonBar();
		bicswb = new ButtonItem();
		biwbck = new ButtonItem();
		biccqd = new ButtonItem();
		RTI1 = new RibbonTabItem();
		RTI2 = new RibbonTabItem();
		RTI3 = new RibbonTabItem();
		RTI4 = new RibbonTabItem();
		RTI5 = new RibbonTabItem();
		ButtonItem1 = new ButtonItem();
		ButtonItem2 = new ButtonItem();
		lblog = new ListBox();
		lbsl = new ListBox();
		LabelX2 = new LabelX();
		lbcl = new ListBox();
		LabelX3 = new LabelX();
		LabelX1 = new LabelX();
		Btngb = new ButtonX();
		TM1 = new Timer(components);
		RibbonControl1.SuspendLayout();
		((Control)RibbonPanel5).SuspendLayout();
		((Control)RibbonPanel2).SuspendLayout();
		((Control)RibbonPanel4).SuspendLayout();
		((Control)RibbonPanel3).SuspendLayout();
		((Control)RibbonPanel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)RibbonControl1).set_Anchor((AnchorStyles)13);
		RibbonControl1.set_AutoExpand(false);
		RibbonControl1.set_AutoSize(true);
		RibbonControl1.get_BackgroundStyle().set_Class("");
		RibbonControl1.get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)RibbonControl1).get_Controls().Add((Control)(object)RibbonPanel5);
		((Control)RibbonControl1).get_Controls().Add((Control)(object)RibbonPanel2);
		((Control)RibbonControl1).get_Controls().Add((Control)(object)RibbonPanel4);
		((Control)RibbonControl1).get_Controls().Add((Control)(object)RibbonPanel3);
		((Control)RibbonControl1).get_Controls().Add((Control)(object)RibbonPanel1);
		((Control)RibbonControl1).set_Cursor(Cursors.get_Default());
		((Control)RibbonControl1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		RibbonControl1.get_Items().AddRange((BaseItem[])(object)new BaseItem[5]
		{
			(BaseItem)RTI1,
			(BaseItem)RTI2,
			(BaseItem)RTI3,
			(BaseItem)RTI4,
			(BaseItem)RTI5
		});
		RibbonControl1.set_KeyTipsFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		RibbonControl ribbonControl = RibbonControl1;
		Point location = new Point(266, 30);
		((Control)ribbonControl).set_Location(location);
		((Control)RibbonControl1).set_Name("RibbonControl1");
		RibbonControl ribbonControl2 = RibbonControl1;
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(0, 0, 0, 2);
		((Control)ribbonControl2).set_Padding(padding);
		RibbonControl1.get_QuickToolbarItems().AddRange((BaseItem[])(object)new BaseItem[2]
		{
			(BaseItem)ButtonItem1,
			(BaseItem)ButtonItem2
		});
		RibbonControl ribbonControl3 = RibbonControl1;
		Size size = new Size(615, 90);
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
		((Control)RibbonControl1).set_TabIndex(16);
		((PanelControl)RibbonPanel5).set_ColorSchemeStyle((eDotNetBarStyle)7);
		((Control)RibbonPanel5).get_Controls().Add((Control)(object)RB5);
		RibbonPanel5.set_Dock((DockStyle)5);
		RibbonPanel ribbonPanel = RibbonPanel5;
		location = new Point(0, 26);
		ribbonPanel.set_Location(location);
		((Control)RibbonPanel5).set_Name("RibbonPanel5");
		RibbonPanel ribbonPanel2 = RibbonPanel5;
		((Padding)(ref padding))._002Ector(3, 0, 3, 3);
		((Control)ribbonPanel2).set_Padding(padding);
		RibbonPanel ribbonPanel3 = RibbonPanel5;
		size = new Size(615, 62);
		ribbonPanel3.set_Size(size);
		((PanelControl)RibbonPanel5).get_Style().set_Class("");
		((PanelControl)RibbonPanel5).get_Style().set_CornerType((eCornerType)1);
		((PanelControl)RibbonPanel5).get_StyleMouseDown().set_Class("");
		((PanelControl)RibbonPanel5).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)RibbonPanel5).get_StyleMouseOver().set_Class("");
		((PanelControl)RibbonPanel5).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)RibbonPanel5).set_TabIndex(5);
		RB5.set_AutoOverflowEnabled(true);
		RB5.get_BackgroundMouseOverStyle().set_Class("");
		RB5.get_BackgroundMouseOverStyle().set_CornerType((eCornerType)1);
		((ItemControl)RB5).get_BackgroundStyle().set_Class("");
		((ItemControl)RB5).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((ItemControl)RB5).set_ContainerControlProcessDialogKey(true);
		((Control)RB5).set_Dock((DockStyle)3);
		RB5.get_Items().AddRange((BaseItem[])(object)new BaseItem[2]
		{
			(BaseItem)btnfan,
			(BaseItem)gb3
		});
		RibbonBar rB = RB5;
		location = new Point(3, 0);
		((Control)rB).set_Location(location);
		((Control)RB5).set_Name("RB5");
		RibbonBar rB2 = RB5;
		size = new Size(609, 59);
		((Control)rB2).set_Size(size);
		RB5.set_Style((eDotNetBarStyle)7);
		((Control)RB5).set_TabIndex(1);
		RB5.get_TitleStyle().set_Class("");
		RB5.get_TitleStyle().set_CornerType((eCornerType)1);
		RB5.get_TitleStyleMouseOver().set_Class("");
		RB5.get_TitleStyleMouseOver().set_CornerType((eCornerType)1);
		RB5.set_TitleVisible(false);
		btnfan.set_ButtonStyle((eButtonStyle)2);
		btnfan.set_HotFontBold(true);
		btnfan.set_Image((Image)componentResourceManager.GetObject("btnfan.Image"));
		btnfan.set_ImagePosition((eImagePosition)2);
		((BaseItem)btnfan).set_Name("btnfan");
		btnfan.set_SubItemsExpandWidth(14);
		btnfan.set_Text("方案计算");
		gb3.set_ButtonStyle((eButtonStyle)2);
		gb3.set_HotFontBold(true);
		gb3.set_Image((Image)componentResourceManager.GetObject("gb3.Image"));
		gb3.set_ImagePosition((eImagePosition)2);
		((BaseItem)gb3).set_Name("gb3");
		gb3.set_SubItemsExpandWidth(14);
		gb3.set_Text("关闭当前窗口");
		((PanelControl)RibbonPanel2).set_ColorSchemeStyle((eDotNetBarStyle)7);
		((Control)RibbonPanel2).get_Controls().Add((Control)(object)RB2);
		RibbonPanel2.set_Dock((DockStyle)5);
		RibbonPanel ribbonPanel4 = RibbonPanel2;
		location = new Point(0, 26);
		ribbonPanel4.set_Location(location);
		((Control)RibbonPanel2).set_Name("RibbonPanel2");
		RibbonPanel ribbonPanel5 = RibbonPanel2;
		((Padding)(ref padding))._002Ector(3, 0, 3, 3);
		((Control)ribbonPanel5).set_Padding(padding);
		RibbonPanel ribbonPanel6 = RibbonPanel2;
		size = new Size(615, 62);
		ribbonPanel6.set_Size(size);
		((PanelControl)RibbonPanel2).get_Style().set_Class("");
		((PanelControl)RibbonPanel2).get_Style().set_CornerType((eCornerType)1);
		((PanelControl)RibbonPanel2).get_StyleMouseDown().set_Class("");
		((PanelControl)RibbonPanel2).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)RibbonPanel2).get_StyleMouseOver().set_Class("");
		((PanelControl)RibbonPanel2).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)RibbonPanel2).set_TabIndex(2);
		RibbonPanel2.set_Visible(false);
		RB2.set_AutoOverflowEnabled(true);
		RB2.get_BackgroundMouseOverStyle().set_Class("");
		RB2.get_BackgroundMouseOverStyle().set_CornerType((eCornerType)1);
		((ItemControl)RB2).get_BackgroundStyle().set_Class("");
		((ItemControl)RB2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((ItemControl)RB2).set_ContainerControlProcessDialogKey(true);
		((Control)RB2).set_Dock((DockStyle)3);
		RB2.get_Items().AddRange((BaseItem[])(object)new BaseItem[5]
		{
			(BaseItem)bjxlsgx,
			(BaseItem)bjxlsck,
			(BaseItem)btnhqmx,
			(BaseItem)bjlaygx,
			(BaseItem)bjqd
		});
		RibbonBar rB3 = RB2;
		location = new Point(3, 0);
		((Control)rB3).set_Location(location);
		((Control)RB2).set_Name("RB2");
		RibbonBar rB4 = RB2;
		size = new Size(609, 59);
		((Control)rB4).set_Size(size);
		RB2.set_Style((eDotNetBarStyle)7);
		((Control)RB2).set_TabIndex(0);
		RB2.get_TitleStyle().set_Class("");
		RB2.get_TitleStyle().set_CornerType((eCornerType)1);
		RB2.get_TitleStyleMouseOver().set_Class("");
		RB2.get_TitleStyleMouseOver().set_CornerType((eCornerType)1);
		RB2.set_TitleVisible(false);
		bjxlsgx.set_ButtonStyle((eButtonStyle)2);
		bjxlsgx.set_HotFontBold(true);
		bjxlsgx.set_Image((Image)componentResourceManager.GetObject("bjxlsgx.Image"));
		bjxlsgx.set_ImagePosition((eImagePosition)2);
		((BaseItem)bjxlsgx).set_Name("bjxlsgx");
		bjxlsgx.set_SubItemsExpandWidth(14);
		bjxlsgx.set_Text("[B1]布局xls更新");
		bjxlsck.set_ButtonStyle((eButtonStyle)2);
		bjxlsck.set_HotFontBold(true);
		bjxlsck.set_Image((Image)componentResourceManager.GetObject("bjxlsck.Image"));
		bjxlsck.set_ImagePosition((eImagePosition)2);
		((BaseItem)bjxlsck).set_Name("bjxlsck");
		bjxlsck.set_SubItemsExpandWidth(14);
		bjxlsck.set_Text("[B2]布局xls查看");
		btnhqmx.set_ButtonStyle((eButtonStyle)2);
		((BaseItem)btnhqmx).set_Enabled(false);
		btnhqmx.set_HotFontBold(true);
		btnhqmx.set_Image((Image)componentResourceManager.GetObject("btnhqmx.Image"));
		btnhqmx.set_ImagePosition((eImagePosition)2);
		((BaseItem)btnhqmx).set_Name("btnhqmx");
		btnhqmx.set_SubItemsExpandWidth(14);
		btnhqmx.set_Text("[B3]获取库模型");
		bjlaygx.set_ButtonStyle((eButtonStyle)2);
		((BaseItem)bjlaygx).set_Enabled(false);
		bjlaygx.set_HotFontBold(true);
		bjlaygx.set_Image((Image)componentResourceManager.GetObject("bjlaygx.Image"));
		bjlaygx.set_ImagePosition((eImagePosition)2);
		((BaseItem)bjlaygx).set_Name("bjlaygx");
		bjlaygx.set_SubItemsExpandWidth(14);
		bjlaygx.set_Text("[B4]布局lay更新");
		bjqd.set_ButtonStyle((eButtonStyle)2);
		((BaseItem)bjqd).set_Enabled(false);
		bjqd.set_HotFontBold(true);
		bjqd.set_Image((Image)componentResourceManager.GetObject("bjqd.Image"));
		bjqd.set_ImagePosition((eImagePosition)2);
		((BaseItem)bjqd).set_Name("bjqd");
		bjqd.set_SubItemsExpandWidth(14);
		bjqd.set_Text("[B5]布局驱动模型更新");
		((PanelControl)RibbonPanel4).set_ColorSchemeStyle((eDotNetBarStyle)7);
		((Control)RibbonPanel4).get_Controls().Add((Control)(object)RB4);
		RibbonPanel4.set_Dock((DockStyle)5);
		RibbonPanel ribbonPanel7 = RibbonPanel4;
		location = new Point(0, 26);
		ribbonPanel7.set_Location(location);
		((Control)RibbonPanel4).set_Name("RibbonPanel4");
		RibbonPanel ribbonPanel8 = RibbonPanel4;
		((Padding)(ref padding))._002Ector(3, 0, 3, 3);
		((Control)ribbonPanel8).set_Padding(padding);
		RibbonPanel ribbonPanel9 = RibbonPanel4;
		size = new Size(615, 62);
		ribbonPanel9.set_Size(size);
		((PanelControl)RibbonPanel4).get_Style().set_Class("");
		((PanelControl)RibbonPanel4).get_Style().set_CornerType((eCornerType)1);
		((PanelControl)RibbonPanel4).get_StyleMouseDown().set_Class("");
		((PanelControl)RibbonPanel4).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)RibbonPanel4).get_StyleMouseOver().set_Class("");
		((PanelControl)RibbonPanel4).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)RibbonPanel4).set_TabIndex(4);
		RibbonPanel4.set_Visible(false);
		RB4.set_AutoOverflowEnabled(true);
		RB4.get_BackgroundMouseOverStyle().set_Class("");
		RB4.get_BackgroundMouseOverStyle().set_CornerType((eCornerType)1);
		((ItemControl)RB4).get_BackgroundStyle().set_Class("");
		((ItemControl)RB4).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((ItemControl)RB4).set_ContainerControlProcessDialogKey(true);
		((Control)RB4).set_Dock((DockStyle)3);
		RB4.get_Items().AddRange((BaseItem[])(object)new BaseItem[5]
		{
			(BaseItem)ll_btnvarinfo,
			(BaseItem)ButtonItem4,
			(BaseItem)ll_btnout,
			(BaseItem)ll_btnlookout,
			(BaseItem)gb
		});
		RibbonBar rB5 = RB4;
		location = new Point(3, 0);
		((Control)rB5).set_Location(location);
		((Control)RB4).set_Name("RB4");
		RibbonBar rB6 = RB4;
		size = new Size(612, 59);
		((Control)rB6).set_Size(size);
		RB4.set_Style((eDotNetBarStyle)7);
		((Control)RB4).set_TabIndex(0);
		RB4.get_TitleStyle().set_Class("");
		RB4.get_TitleStyle().set_CornerType((eCornerType)1);
		RB4.get_TitleStyleMouseOver().set_Class("");
		RB4.get_TitleStyleMouseOver().set_CornerType((eCornerType)1);
		RB4.set_TitleVisible(false);
		ll_btnvarinfo.set_ButtonStyle((eButtonStyle)2);
		ll_btnvarinfo.set_HotFontBold(true);
		ll_btnvarinfo.set_Image((Image)componentResourceManager.GetObject("ll_btnvarinfo.Image"));
		ll_btnvarinfo.set_ImagePosition((eImagePosition)2);
		((BaseItem)ll_btnvarinfo).set_Name("ll_btnvarinfo");
		ll_btnvarinfo.set_SubItemsExpandWidth(14);
		ll_btnvarinfo.set_Text("生成参数文本");
		ButtonItem4.set_ButtonStyle((eButtonStyle)2);
		ButtonItem4.set_HotFontBold(true);
		ButtonItem4.set_Image((Image)componentResourceManager.GetObject("ButtonItem4.Image"));
		ButtonItem4.set_ImagePosition((eImagePosition)2);
		((BaseItem)ButtonItem4).set_Name("ButtonItem4");
		ButtonItem4.set_SubItemsExpandWidth(14);
		ButtonItem4.set_Text("生成工况文本");
		ll_btnout.set_ButtonStyle((eButtonStyle)2);
		ll_btnout.set_HotFontBold(true);
		ll_btnout.set_Image((Image)componentResourceManager.GetObject("ll_btnout.Image"));
		ll_btnout.set_ImagePosition((eImagePosition)2);
		((BaseItem)ll_btnout).set_Name("ll_btnout");
		ll_btnout.set_SubItemsExpandWidth(14);
		ll_btnout.set_Text("输出计算文件夹");
		ll_btnlookout.set_ButtonStyle((eButtonStyle)2);
		ll_btnlookout.set_HotFontBold(true);
		ll_btnlookout.set_Image((Image)componentResourceManager.GetObject("ll_btnlookout.Image"));
		ll_btnlookout.set_ImagePosition((eImagePosition)2);
		((BaseItem)ll_btnlookout).set_Name("ll_btnlookout");
		ll_btnlookout.set_SubItemsExpandWidth(14);
		ll_btnlookout.set_Text("浏览计算文件夹");
		gb.set_ButtonStyle((eButtonStyle)2);
		gb.set_HotFontBold(true);
		gb.set_Image((Image)componentResourceManager.GetObject("gb.Image"));
		gb.set_ImagePosition((eImagePosition)2);
		((BaseItem)gb).set_Name("gb");
		gb.set_SubItemsExpandWidth(14);
		gb.set_Text("关闭当前窗口");
		((PanelControl)RibbonPanel3).set_ColorSchemeStyle((eDotNetBarStyle)7);
		((Control)RibbonPanel3).get_Controls().Add((Control)(object)RB3);
		RibbonPanel3.set_Dock((DockStyle)5);
		RibbonPanel ribbonPanel10 = RibbonPanel3;
		location = new Point(0, 26);
		ribbonPanel10.set_Location(location);
		((Control)RibbonPanel3).set_Name("RibbonPanel3");
		RibbonPanel ribbonPanel11 = RibbonPanel3;
		((Padding)(ref padding))._002Ector(3, 0, 3, 3);
		((Control)ribbonPanel11).set_Padding(padding);
		RibbonPanel ribbonPanel12 = RibbonPanel3;
		size = new Size(615, 62);
		ribbonPanel12.set_Size(size);
		((PanelControl)RibbonPanel3).get_Style().set_Class("");
		((PanelControl)RibbonPanel3).get_Style().set_CornerType((eCornerType)1);
		((PanelControl)RibbonPanel3).get_StyleMouseDown().set_Class("");
		((PanelControl)RibbonPanel3).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)RibbonPanel3).get_StyleMouseOver().set_Class("");
		((PanelControl)RibbonPanel3).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)RibbonPanel3).set_TabIndex(3);
		RibbonPanel3.set_Visible(false);
		RB3.set_AutoOverflowEnabled(true);
		RB3.get_BackgroundMouseOverStyle().set_Class("");
		RB3.get_BackgroundMouseOverStyle().set_CornerType((eCornerType)1);
		((ItemControl)RB3).get_BackgroundStyle().set_Class("");
		((ItemControl)RB3).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((ItemControl)RB3).set_ContainerControlProcessDialogKey(true);
		((Control)RB3).set_Dock((DockStyle)3);
		RB3.get_Items().AddRange((BaseItem[])(object)new BaseItem[1] { (BaseItem)btnljproe });
		RibbonBar rB7 = RB3;
		location = new Point(3, 0);
		((Control)rB7).set_Location(location);
		((Control)RB3).set_Name("RB3");
		RibbonBar rB8 = RB3;
		size = new Size(609, 59);
		((Control)rB8).set_Size(size);
		RB3.set_Style((eDotNetBarStyle)7);
		((Control)RB3).set_TabIndex(0);
		RB3.get_TitleStyle().set_Class("");
		RB3.get_TitleStyle().set_CornerType((eCornerType)1);
		RB3.get_TitleStyleMouseOver().set_Class("");
		RB3.get_TitleStyleMouseOver().set_CornerType((eCornerType)1);
		RB3.set_TitleVisible(false);
		btnljproe.set_ButtonStyle((eButtonStyle)2);
		btnljproe.set_ForeColor(Color.Red);
		btnljproe.set_HotFontBold(true);
		btnljproe.set_Image((Image)componentResourceManager.GetObject("btnljproe.Image"));
		btnljproe.set_ImagePosition((eImagePosition)2);
		((BaseItem)btnljproe).set_Name("btnljproe");
		btnljproe.set_SubItemsExpandWidth(14);
		btnljproe.set_Text("连接当前ProE");
		((PanelControl)RibbonPanel1).set_ColorSchemeStyle((eDotNetBarStyle)7);
		((Control)RibbonPanel1).get_Controls().Add((Control)(object)RB1);
		((PanelControl)RibbonPanel1).set_DialogResult((DialogResult)2);
		RibbonPanel1.set_Dock((DockStyle)5);
		RibbonPanel ribbonPanel13 = RibbonPanel1;
		location = new Point(0, 26);
		ribbonPanel13.set_Location(location);
		((Control)RibbonPanel1).set_Name("RibbonPanel1");
		RibbonPanel ribbonPanel14 = RibbonPanel1;
		((Padding)(ref padding))._002Ector(3, 0, 3, 3);
		((Control)ribbonPanel14).set_Padding(padding);
		RibbonPanel ribbonPanel15 = RibbonPanel1;
		size = new Size(615, 62);
		ribbonPanel15.set_Size(size);
		((PanelControl)RibbonPanel1).get_Style().set_Class("");
		((PanelControl)RibbonPanel1).get_Style().set_CornerType((eCornerType)1);
		((PanelControl)RibbonPanel1).get_StyleMouseDown().set_Class("");
		((PanelControl)RibbonPanel1).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)RibbonPanel1).get_StyleMouseOver().set_Class("");
		((PanelControl)RibbonPanel1).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)RibbonPanel1).set_TabIndex(1);
		RibbonPanel1.set_Visible(false);
		RB1.set_AutoOverflowEnabled(true);
		RB1.get_BackgroundMouseOverStyle().set_Class("");
		RB1.get_BackgroundMouseOverStyle().set_CornerType((eCornerType)1);
		((ItemControl)RB1).get_BackgroundStyle().set_Class("");
		((ItemControl)RB1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((ItemControl)RB1).set_ContainerControlProcessDialogKey(true);
		((Control)RB1).set_Dock((DockStyle)3);
		((Control)RB1).set_ImeMode((ImeMode)1);
		RB1.get_Items().AddRange((BaseItem[])(object)new BaseItem[3]
		{
			(BaseItem)bicswb,
			(BaseItem)biwbck,
			(BaseItem)biccqd
		});
		RibbonBar rB9 = RB1;
		location = new Point(3, 0);
		((Control)rB9).set_Location(location);
		((Control)RB1).set_Name("RB1");
		RibbonBar rB10 = RB1;
		size = new Size(609, 59);
		((Control)rB10).set_Size(size);
		RB1.set_Style((eDotNetBarStyle)7);
		((Control)RB1).set_TabIndex(0);
		((Control)RB1).set_Text("打开参数文件");
		RB1.get_TitleStyle().set_Class("");
		RB1.get_TitleStyle().set_CornerType((eCornerType)1);
		RB1.get_TitleStyleMouseOver().set_Class("");
		RB1.get_TitleStyleMouseOver().set_CornerType((eCornerType)1);
		RB1.set_TitleVisible(false);
		((Control)RB1).set_Visible(false);
		bicswb.set_ButtonStyle((eButtonStyle)2);
		bicswb.set_HotFontBold(true);
		bicswb.set_Image((Image)componentResourceManager.GetObject("bicswb.Image"));
		bicswb.set_ImagePosition((eImagePosition)2);
		((BaseItem)bicswb).set_Name("bicswb");
		bicswb.set_SubItemsExpandWidth(14);
		bicswb.set_Text("[A1]参数文本生成");
		biwbck.set_ButtonStyle((eButtonStyle)2);
		biwbck.set_HotFontBold(true);
		biwbck.set_Image((Image)componentResourceManager.GetObject("biwbck.Image"));
		biwbck.set_ImagePosition((eImagePosition)2);
		((BaseItem)biwbck).set_Name("biwbck");
		biwbck.set_SubItemsExpandWidth(14);
		biwbck.set_Text("[A2]参数文本查看");
		biccqd.set_ButtonStyle((eButtonStyle)2);
		biccqd.set_HotFontBold(true);
		biccqd.set_Image((Image)componentResourceManager.GetObject("biccqd.Image"));
		biccqd.set_ImagePosition((eImagePosition)2);
		((BaseItem)biccqd).set_Name("biccqd");
		biccqd.set_SubItemsExpandWidth(14);
		biccqd.set_Text("[A3]参数/尺寸驱动模型更新");
		((BaseItem)RTI1).set_Name("RTI1");
		RTI1.set_Panel(RibbonPanel1);
		((ButtonItem)RTI1).set_Text("参数与尺寸.xls驱动");
		((BaseItem)RTI1).set_Visible(false);
		((BaseItem)RTI2).set_Name("RTI2");
		RTI2.set_Panel(RibbonPanel2);
		((ButtonItem)RTI2).set_Text("布局参数lay驱动");
		((BaseItem)RTI3).set_Name("RTI3");
		RTI3.set_Panel(RibbonPanel3);
		((ButtonItem)RTI3).set_Text("ProE连接");
		((BaseItem)RTI4).set_Name("RTI4");
		RTI4.set_Panel(RibbonPanel4);
		((ButtonItem)RTI4).set_Text("性能处理");
		RTI5.set_Checked(true);
		((BaseItem)RTI5).set_Name("RTI5");
		RTI5.set_Panel(RibbonPanel5);
		((ButtonItem)RTI5).set_Text("方案计算");
		((BaseItem)ButtonItem1).set_Name("ButtonItem1");
		ButtonItem1.set_Text("ButtonItem1");
		((BaseItem)ButtonItem2).set_Name("ButtonItem2");
		ButtonItem2.set_Text("ButtonItem1");
		lblog.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)lblog).set_FormattingEnabled(true);
		lblog.set_ItemHeight(12);
		ListBox obj = lblog;
		location = new Point(12, 120);
		((Control)obj).set_Location(location);
		((Control)lblog).set_Name("lblog");
		ListBox obj2 = lblog;
		size = new Size(870, 316);
		((Control)obj2).set_Size(size);
		((Control)lblog).set_TabIndex(14);
		lbsl.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)lbsl).set_FormattingEnabled(true);
		lbsl.set_ItemHeight(12);
		ListBox obj3 = lbsl;
		location = new Point(131, 31);
		((Control)obj3).set_Location(location);
		((Control)lbsl).set_Name("lbsl");
		ListBox obj4 = lbsl;
		size = new Size(133, 88);
		((Control)obj4).set_Size(size);
		((Control)lbsl).set_TabIndex(13);
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX2).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX = LabelX2;
		location = new Point(133, 6);
		((Control)labelX).set_Location(location);
		((Control)LabelX2).set_Name("LabelX2");
		LabelX labelX2 = LabelX2;
		size = new Size(128, 19);
		((Control)labelX2).set_Size(size);
		((BaseItemControl)LabelX2).set_Style((eDotNetBarStyle)5);
		((Control)LabelX2).set_TabIndex(9);
		LabelX2.set_Text("选择要处理的实例模型");
		lbcl.set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ListControl)lbcl).set_FormattingEnabled(true);
		lbcl.set_ItemHeight(12);
		ListBox obj5 = lbcl;
		location = new Point(12, 31);
		((Control)obj5).set_Location(location);
		((Control)lbcl).set_Name("lbcl");
		ListBox obj6 = lbcl;
		size = new Size(113, 88);
		((Control)obj6).set_Size(size);
		((Control)lbcl).set_TabIndex(12);
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX3).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX3 = LabelX3;
		location = new Point(267, 6);
		((Control)labelX3).set_Location(location);
		((Control)LabelX3).set_Name("LabelX3");
		LabelX labelX4 = LabelX3;
		size = new Size(96, 19);
		((Control)labelX4).set_Size(size);
		((Control)LabelX3).set_TabIndex(10);
		LabelX3.set_Text("模型驱动方式");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX5 = LabelX1;
		location = new Point(12, 6);
		((Control)labelX5).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX6 = LabelX1;
		size = new Size(122, 19);
		((Control)labelX6).set_Size(size);
		((Control)LabelX1).set_TabIndex(11);
		LabelX1.set_Text("选择要进行的处理");
		((Control)Btngb).set_AccessibleRole((AccessibleRole)43);
		Btngb.set_ColorTable((eButtonColor)3);
		Btngb.set_DialogResult((DialogResult)2);
		ButtonX btngb = Btngb;
		location = new Point(368, 158);
		((Control)btngb).set_Location(location);
		((Control)Btngb).set_Name("Btngb");
		ButtonX btngb2 = Btngb;
		size = new Size(105, 14);
		((Control)btngb2).set_Size(size);
		((PopupItemControl)Btngb).set_Style((eDotNetBarStyle)7);
		((Control)Btngb).set_TabIndex(17);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)Btngb);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f));
		size = new Size(894, 448);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)RibbonControl1);
		((Control)this).get_Controls().Add((Control)(object)lblog);
		((Control)this).get_Controls().Add((Control)(object)lbsl);
		((Control)this).get_Controls().Add((Control)(object)LabelX2);
		((Control)this).get_Controls().Add((Control)(object)lbcl);
		((Control)this).get_Controls().Add((Control)(object)LabelX3);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).get_Controls().Add((Control)(object)Btngb);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("clxd");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("分析向导");
		RibbonControl1.ResumeLayout(false);
		((Control)RibbonControl1).PerformLayout();
		((Control)RibbonPanel5).ResumeLayout(false);
		((Control)RibbonPanel2).ResumeLayout(false);
		((Control)RibbonPanel4).ResumeLayout(false);
		((Control)RibbonPanel3).ResumeLayout(false);
		((Control)RibbonPanel1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void clxd_Load(object sender, EventArgs e)
	{
		if (Mod1.asyncConnection != null)
		{
			btnljproe.set_ForeColor(Color.SeaGreen);
		}
		else
		{
			btnljproe.set_ForeColor(Color.Red);
		}
		string text = Mod1.cshh.Substring(checked(Mod1.cshh.LastIndexOf("\\") + 1));
		Mod1.lr = new StreamReader(Mod1.cshh + "\\" + text + ".lis", Encoding.Default);
		string text2 = "";
		while (!Information.IsNothing((object)text2))
		{
			text2 = Mod1.lr.ReadLine();
			if (Information.IsNothing((object)text2))
			{
				break;
			}
			lbcl.get_Items().Add((object)text2);
		}
		Mod1.lr.Close();
		Mod1.lr.Dispose();
		if (lbcl.get_Items().get_Count() != 0)
		{
			lbcl.set_SelectedIndex(0);
		}
		Mod1.proetime();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void lbcl_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Invalid comparison between Unknown and I4
		if ((lbcl.get_Items().get_Count() != 0) & (lbcl.get_SelectedIndex() != -1))
		{
			ListBox val = lbcl;
			string text = val.get_Text();
			string text2 = Mod1.toen(ref text);
			val.set_Text(text);
			string text3 = text2;
			lbsl.get_Items().Clear();
			string text4 = Mod1.cshh + "\\" + text3;
			if (Operators.CompareString(Strings.Right(text4, 1), "\\", false) != 0)
			{
				text4 += "\\";
			}
			string text5 = FileSystem.Dir(text4, (FileAttribute)16);
			while (Operators.CompareString(text5, "", false) != 0)
			{
				if ((FileSystem.GetAttr(text4 + text5) & 0x10) == 16 && ((Operators.CompareString(text5, ".", false) != 0) & (Operators.CompareString(text5, "..", false) != 0)))
				{
					if (Operators.CompareString(MyProject.Forms.FrmOf.qyx, "qyxxn", false) == 0)
					{
						lbsl.get_Items().Add((object)Mod1.toch(text5));
					}
					else
					{
						lbsl.get_Items().Add((object)text5);
					}
				}
				text5 = FileSystem.Dir();
			}
		}
		if (lbsl.get_Items().get_Count() != 0)
		{
			lbsl.set_SelectedIndex(0);
		}
		((Control)RB2).set_Enabled(false);
		((BaseItem)RTI2).set_Visible(false);
		((Control)RB3).set_Enabled(false);
		((BaseItem)RTI3).set_Visible(false);
		((Control)RB4).set_Enabled(false);
		((BaseItem)RTI4).set_Visible(false);
		((Control)RB5).set_Enabled(false);
		((BaseItem)RTI5).set_Visible(false);
		if (Operators.CompareString(lbcl.get_Text(), "ansys性能计算", false) == 0)
		{
			((Control)RibbonControl1).set_Visible(true);
			((Control)RB4).set_Enabled(true);
			((BaseItem)RTI4).set_Visible(true);
			RTI4.Select();
		}
		else if (Operators.CompareString(lbcl.get_Text(), "ansys方案计算", false) == 0)
		{
			if (Operators.CompareString(lbsl.get_Text(), "", false) != 0)
			{
				((Control)RibbonControl1).set_Visible(true);
				((Control)RB5).set_Enabled(true);
				((BaseItem)RTI5).set_Visible(true);
				RTI5.Select();
			}
			else
			{
				((Control)RibbonControl1).set_Visible(false);
			}
		}
		else
		{
			((Control)RibbonControl1).set_Visible(true);
			((Control)RB2).set_Enabled(true);
			((BaseItem)RTI2).set_Visible(true);
			((Control)RB3).set_Enabled(true);
			((BaseItem)RTI3).set_Visible(true);
		}
	}

	private void lbsl_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(MyProject.Forms.FrmOf.qyx, "qyxxn", false) != 0 && ((Operators.CompareString(sl, "", false) == 0) | (Operators.CompareString(lbsl.get_Text(), lbcl.get_Text(), false) != 0)))
		{
			excell();
		}
	}

	public void countHL()
	{
		ran = (Excel.Range)sheetlay.Cells[1, sheetlay.Cells.Columns.Count];
		CL = ran.get_End(XlDirection.xlToLeft).Column;
		ran = (Excel.Range)sheetlay.Cells[sheetlay.Cells.Rows.Count, 1];
		CH = ran.get_End(XlDirection.xlUp).Row;
	}

	public void excell()
	{
		bool num = Operators.CompareString(Strings.Trim(lbsl.get_Text()), "", false) != 0;
		ListBox val = lbcl;
		string text = val.get_Text();
		string text2 = Mod1.toen(ref text);
		val.set_Text(text);
		if (!(num & (Operators.CompareString(text2, "", false) != 0)))
		{
			return;
		}
		this.array.Clear();
		val = lbcl;
		text = val.get_Text();
		string text3 = Mod1.toen(ref text);
		val.set_Text(text);
		if (Operators.CompareString(text3, "", false) != 0)
		{
			string[] array = new string[6]
			{
				Mod1.xdpath,
				"\\",
				null,
				null,
				null,
				null
			};
			ListBox val2 = lbcl;
			string text4 = val2.get_Text();
			string text5 = Mod1.toen(ref text4);
			val2.set_Text(text4);
			array[2] = text5;
			array[3] = "\\";
			array[4] = lbsl.get_Text();
			array[5] = "\\layoutvar.xls";
			if (File.Exists(string.Concat(array)))
			{
				string[] array2 = new string[6]
				{
					Mod1.xdpath,
					"\\",
					null,
					null,
					null,
					null
				};
				ListBox val3 = lbcl;
				string text6 = val3.get_Text();
				string text7 = Mod1.toen(ref text6);
				val3.set_Text(text6);
				array2[2] = text7;
				array2[3] = "\\";
				array2[4] = lbsl.get_Text();
				array2[5] = "\\layoutvar.xls";
				Mod1.path = string.Concat(array2);
				((Control)RB2).set_Enabled(true);
				((Control)RB1).set_Enabled(false);
				RTI2.Select();
			}
			else
			{
				((Control)RB2).set_Enabled(false);
			}
		}
	}

	private void bjxlsgx_Click(object sender, EventArgs e)
	{
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(Strings.Trim(lbsl.get_Text()), "", false) == 0)
		{
			return;
		}
		a = true;
		if (wblay == null)
		{
			try
			{
				ListBox val = lbcl;
				string text = val.get_Text();
				string text2 = Mod1.toen(ref text);
				val.set_Text(text);
				if (Operators.CompareString(text2, "", false) != 0)
				{
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
					string[] obj = array;
					ListBox val2 = lbcl;
					string text3 = val2.get_Text();
					string text4 = Mod1.toen(ref text3);
					val2.set_Text(text3);
					obj[2] = text4;
					array[3] = "\\";
					array[4] = lbsl.get_Text();
					array[5] = "\\layoutvar.xls";
					wblay = workbooks.Open(string.Concat(array), Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		else
		{
			ListBox val2 = lbcl;
			string text3 = val2.get_Text();
			string text5 = Mod1.toen(ref text3);
			val2.set_Text(text3);
			if (Operators.CompareString(text5, "", false) != 0)
			{
				wblay.Close(Missing.Value, Missing.Value, Missing.Value);
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
				string[] obj2 = array;
				val2 = lbcl;
				text3 = val2.get_Text();
				string text6 = Mod1.toen(ref text3);
				val2.set_Text(text3);
				obj2[2] = text6;
				array[3] = "\\";
				array[4] = lbsl.get_Text();
				array[5] = "\\layoutvar.xls";
				wblay = workbooks2.Open(string.Concat(array), Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
			}
		}
		csh();
		string text7 = "";
		((Control)MyProject.Forms.jinduclxd).Show();
		int count = wblay.Worksheets.Count;
		checked
		{
			for (int i = 1; i <= count; i++)
			{
				sheetlay = (Worksheet)wblay.Sheets.get_Item((object)i);
				countHL();
				MyProject.Forms.jinduclxd.PBZ.set_Maximum(wblay.Worksheets.Count);
				MyProject.Forms.jinduclxd.PBZ.set_Value(i);
				MyProject.Forms.jinduclxd.PBD.set_Maximum(CH);
				int cH = CH;
				for (int j = 2; j <= cH; j++)
				{
					if ((Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(sheetlay.Cells[j, 5], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "完全", false) == 0) | (Operators.CompareString(Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(sheetlay.Cells[j, 5], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null)))), "FULL", false) == 0))
					{
						Type typeFromHandle = typeof(Strings);
						object[] array2 = new object[1];
						object obj3 = sheetlay.Cells[j, 1];
						array2[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj3, (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null));
						object[] array3 = array2;
						bool[] array4 = new bool[1] { true };
						object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle, "UCase", array3, (string[])null, (Type[])null, array4);
						if (array4[0])
						{
							NewLateBinding.LateSetComplex(obj3, (Type)null, "value", new object[1] { RuntimeHelpers.GetObjectValue(array3[0]) }, (string[])null, (Type[])null, true, true);
						}
						text7 = Strings.Trim(Conversions.ToString(obj4));
						MyProject.Forms.jinduclxd.xx.set_Text("");
						MyProject.Forms.jinduclxd.xx.set_Text(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"当前工作表：", NewLateBinding.LateGet(wblay.Sheets.get_Item((object)i), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)" "), (object)"参数名称："), (object)text7)));
						((Control)MyProject.Forms.jinduclxd).Refresh();
					}
					MyProject.Forms.jinduclxd.PBD.set_Value(j);
					if (Operators.ConditionalCompareObjectNotEqual(this.array[text7], (object)null, false))
					{
						NewLateBinding.LateSetComplex(sheetlay.Cells[j, 3], (Type)null, "value", new object[1] { RuntimeHelpers.GetObjectValue(this.array[text7]) }, (string[])null, (Type[])null, false, true);
					}
				}
			}
			((Component)(object)MyProject.Forms.jinduclxd).Dispose();
			try
			{
				wblay.Save();
				ObjectCollection items = lblog.get_Items();
				string[] array = new string[8]
				{
					Conversions.ToString(DateTime.Now),
					" 操作员更新了布局xls文件：",
					Mod1.xdpath,
					"\\",
					null,
					null,
					null,
					null
				};
				string[] obj5 = array;
				ListBox val2 = lbcl;
				string text3 = val2.get_Text();
				string text8 = Mod1.toen(ref text3);
				val2.set_Text(text3);
				obj5[4] = text8;
				array[5] = "\\";
				array[6] = lbsl.get_Text();
				array[7] = "\\layoutvar.xls";
				items.Add((object)string.Concat(array));
				lblog.get_Items().Add((object)"布局xls更新成功.");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)64, (object)"提示");
				ProjectData.ClearProjectError();
			}
			((BaseItem)bjxlsgx).set_Enabled(false);
			((BaseItem)btnhqmx).set_Enabled(true);
		}
	}

	public void getid(string by)
	{
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		switch (by)
		{
		case "ansys性能计算":
			ID = "性能计算ID_" + lbsl.get_Text();
			break;
		case "ansys校核计算":
			ID = "校核计算ID_" + lbsl.get_Text();
			break;
		case "ansys方案计算":
			ID = "方案计算ID_" + lbsl.get_Text();
			break;
		case "proe几何检验":
			ID = "几何检验ID_" + lbsl.get_Text();
			break;
		case "proe局部详细":
			ID = "局部详细ID_" + lbsl.get_Text();
			break;
		case "proe设计":
			ID = "设计ID_" + lbsl.get_Text();
			break;
		default:
			Interaction.MsgBox((object)"没有适合的处理功能!! !", (MsgBoxStyle)64, (object)"提示");
			break;
		}
	}

	public void csh()
	{
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (Operators.CompareString(lbsl.get_Text(), "", false) == 0)
				{
					return;
				}
				array.Clear();
				getid(Strings.Trim(lbcl.get_Text()));
				int count = Mod1.wb.Worksheets.Count;
				for (int i = 1; i <= count; i++)
				{
					Mod1.excelsheet = (Worksheet)Mod1.wb.Sheets.get_Item((object)i);
					if (!Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(NewLateBinding.LateGet(Mod1.wb.Sheets.get_Item((object)i), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"参数校验", false), Operators.CompareObjectNotEqual(NewLateBinding.LateGet(Mod1.wb.Sheets.get_Item((object)i), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"动参数临时", false))))
					{
						continue;
					}
					Mod1.lie();
					int num = Mod1.countL - 1;
					for (int j = 5; j <= num; j++)
					{
						if (Strings.InStr(1, Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[1, j], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null))), ID, (CompareMethod)0) == 0)
						{
							continue;
						}
						Mod1.rng = (Excel.Range)Mod1.excelsheet.Cells[Mod1.excelsheet.Cells.Rows.Count, j];
						Mod1.countH = Mod1.rng.get_End(XlDirection.xlUp).Row;
						int countH = Mod1.countH;
						for (int k = 2; k <= countH; k++)
						{
							if (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(Mod1.excelsheet.Cells[k, j], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "1", false) == 0)
							{
								try
								{
									array.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Mod1.excelsheet.Cells[k, 2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null)), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Mod1.excelsheet.Cells[k, 3], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null)));
								}
								catch (Exception projectError)
								{
									ProjectData.SetProjectError(projectError);
									lblog.get_Items().Add(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"工作表：", NewLateBinding.LateGet(Mod1.wb.Sheets.get_Item((object)i), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)" "), NewLateBinding.LateGet(Mod1.excelsheet.Cells[k, 2], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)" 参数名称存在重复！！请检查！！"));
									ProjectData.ClearProjectError();
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)64, (object)"提示");
				ProjectData.ClearProjectError();
			}
		}
	}

	private void bjxlsck_Click(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((Form)MyProject.Forms.bjxslck).ShowDialog();
		((Component)(object)MyProject.Forms.bjxslck).Dispose();
	}

	private void bjlaygx_Click(object sender, EventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_094d: Unknown result type (might be due to invalid IL or missing references)
		((Control)RibbonControl1).set_Cursor(Cursors.get_AppStarting());
		checked
		{
			if (Mod1.Wait1)
			{
				Interaction.MsgBox((object)"与Pro/E模型相关的处理，请不要频繁操作，稍等片刻...", (MsgBoxStyle)64, (object)"提示");
			}
			else if (a)
			{
				c = true;
				uplay = true;
				if (Mod1.asyncConnection == null)
				{
					Interaction.MsgBox((object)"请点击按钮[连接至当前],测试Pro/e连接是否正常!", (MsgBoxStyle)64, (object)"提示");
					return;
				}
				if (Mod1.asyncConnection != null && !Mod1.asyncConnection.IsRunning())
				{
					Interaction.MsgBox((object)"请点击按钮[连接至当前],测试Pro/e连接是否正常!", (MsgBoxStyle)64, (object)"提示");
					return;
				}
				if (!Mod1.getm)
				{
					Interaction.MsgBox((object)"请先获取当前模型后再更新lay布局文件！", (MsgBoxStyle)64, (object)"提示");
					return;
				}
				ListBox val = lbcl;
				string text = val.get_Text();
				string text2 = Mod1.toen(ref text);
				val.set_Text(text);
				if (Operators.CompareString(text2, "", false) == 0)
				{
					Interaction.MsgBox((object)"参数传入了无效值！", (MsgBoxStyle)64, (object)"提示");
					return;
				}
				((Form)this).Activate();
				if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet((object)Mod1.session, (Type)null, "ListModels", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
				{
					string[] array = new string[6]
					{
						Mod1.xdpath,
						"\\",
						null,
						null,
						null,
						null
					};
					val = lbcl;
					text = val.get_Text();
					string text3 = Mod1.toen(ref text);
					val.set_Text(text);
					array[2] = text3;
					array[3] = "\\";
					array[4] = lbsl.get_Text();
					array[5] = "\\layoutvar.xls";
					string text4 = string.Concat(array);
					if (!File.Exists(text4))
					{
						Interaction.MsgBox((object)(text4 + " 文件不存在！"), (MsgBoxStyle)64, (object)"提示");
						lblog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " " + text4 + " 文件不存在！，打开失败！"));
						return;
					}
					try
					{
						wblay = Mod1.excelapp.Workbooks.Open(text4, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						wblay.Close(Missing.Value, Missing.Value, Missing.Value);
						wblay = Mod1.excelapp.Workbooks.Open(text4, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
						ProjectData.ClearProjectError();
					}
					((Control)MyProject.Forms.jinduclxd).Show();
					int count = wblay.Worksheets.Count;
					for (int i = 1; i <= count; i++)
					{
						sheetlay = (Worksheet)wblay.Sheets.get_Item((object)i);
						if (!Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(NewLateBinding.LateGet(wblay.Sheets.get_Item((object)i), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"参数校验", false), Operators.CompareObjectNotEqual(NewLateBinding.LateGet(wblay.Sheets.get_Item((object)i), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"动参数临时", false))))
						{
							continue;
						}
						MyProject.Forms.jinduclxd.PBZ.set_Maximum(wblay.Worksheets.Count);
						MyProject.Forms.jinduclxd.PBZ.set_Value(i);
						countHL();
						MyProject.Forms.jinduclxd.PBD.set_Maximum(CH);
						Mod1.model = (IpfcModel)NewLateBinding.LateGet((object)Mod1.session, (Type)null, "GetModelFromFileName", new object[1] { sheetlay.Name + ".lay" }, (string[])null, (Type[])null, (bool[])null);
						Mod1.paraowner = (IpfcParameterOwner)Mod1.model;
						int cH = CH;
						for (int j = 2; j <= cH; j++)
						{
							if ((Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(sheetlay.Cells[j, 5], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))), "完全", false) == 0) | Conversions.ToBoolean(Strings.UCase(Strings.Trim(Conversions.ToString(Operators.CompareObjectEqual(NewLateBinding.LateGet(sheetlay.Cells[j, 5], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"FULL", false))))))
							{
								Mod1.para = Mod1.paraowner.GetParam(Conversions.ToString(NewLateBinding.LateGet(sheetlay.Cells[j, 1], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)));
								Mod1.punit = Mod1.para.Units;
								Mod1.paravalue = Mod1.para.GetScaledValue();
								if (Mod1.paravalue.discr == 2)
								{
									switch (Strings.UCase(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(sheetlay.Cells[j, 4], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null)))))
									{
									default:
										Mod1.paravalue.BoolValue = true;
										Interaction.MsgBox((object)"布尔类型值不恰当,应为 NO/YES/FALSE/TRUE/否/是/假/真/无/有;默认此处值为 是", (MsgBoxStyle)48, (object)"提示");
										break;
									case "YES":
									case "是":
									case "TRUE":
									case "真":
									case "有":
										Mod1.paravalue.BoolValue = true;
										break;
									case "NO":
									case "否":
									case "FALSE":
									case "假":
									case "无":
										Mod1.paravalue.BoolValue = false;
										break;
									}
								}
								if (Mod1.paravalue.discr == 3)
								{
									Mod1.paravalue.DoubleValue = Conversions.ToDouble(NewLateBinding.LateGet(sheetlay.Cells[j, 3], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
								}
								if (Mod1.paravalue.discr == 0)
								{
									Mod1.paravalue.StringValue = Conversions.ToString(NewLateBinding.LateGet(sheetlay.Cells[j, 3], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
								}
								if (Mod1.paravalue.discr == 1)
								{
									Mod1.paravalue.IntValue = Conversions.ToInteger(NewLateBinding.LateGet(sheetlay.Cells[j, 3], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
								}
								Mod1.para.SetScaledValue(Mod1.paravalue, Mod1.punit);
							}
							MyProject.Forms.jinduclxd.PBD.set_Value(j);
							MyProject.Forms.jinduclxd.xx.set_Text(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"当前文件： ", NewLateBinding.LateGet(wblay.Sheets.get_Item((object)i), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)".Lay "), (object)"参数名称："), NewLateBinding.LateGet(sheetlay.Cells[j, 1], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))));
							((Control)MyProject.Forms.jinduclxd).Refresh();
						}
					}
					((Component)(object)MyProject.Forms.jinduclxd).Dispose();
					wblay.Close(Missing.Value, Missing.Value, Missing.Value);
					lblog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员更新布局 " + Mod1.flay + " 文件成功!"));
					lblog.get_Items().Add((object)"布局lay更新成功.");
					Mod1.win = (IpfcWindow)NewLateBinding.LateGet((object)Mod1.session, (Type)null, "CurrentWindow", new object[0], (string[])null, (Type[])null, (bool[])null);
					Mod1.model.Display();
					Mod1.win.Activate();
					Mod1.win.Repaint();
					((BaseItem)bjlaygx).set_Enabled(false);
					((BaseItem)bjqd).set_Enabled(true);
					Mod1.Wait1 = true;
					TM1.set_Interval(Mod1.time1 * 1000);
					TM1.set_Enabled(true);
					TM1.Start();
				}
				else
				{
					Interaction.MsgBox((object)"要更新.lay文件必须先获取当前模型！！", (MsgBoxStyle)64, (object)"提示");
				}
			}
			else
			{
				lblog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 没有更新布局xls文件！！"));
			}
		}
	}

	private void btnljproe_Click(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Process.GetProcessesByName("xtop").Length <= 0)
			{
				Interaction.MsgBox((object)"当前系统没有运行PROE，请运行后再试！", (MsgBoxStyle)64, (object)"提示");
				btnljproe.set_ForeColor(Color.Red);
				return;
			}
			if (Operators.CompareString(Environment.GetEnvironmentVariable("PRO_COMM_MSG_EXE"), "", false) == 0)
			{
				Interaction.MsgBox((object)"当前系统没有添加系统环境变量 PRO_COMM_MSG_EXE，请添加后再试！", (MsgBoxStyle)64, (object)"提示");
				btnljproe.set_ForeColor(Color.Red);
				return;
			}
			((Control)this).set_Cursor(Cursors.get_AppStarting());
			if (Mod1.asyncConnection == null)
			{
				Guid clsid = new Guid("456E0110-2031-3907-AFE5-9201C97A915E");
				Mod1.asyncConnection = ((CCpfcAsyncConnection)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid))).Connect(null, null, null, null);
			}
			((Control)this).set_Cursor(Cursors.get_Arrow());
			if (Mod1.asyncConnection != null && !Mod1.asyncConnection.IsRunning())
			{
				Guid clsid = new Guid("456E0110-2031-3907-AFE5-9201C97A915E");
				Mod1.asyncConnection = ((CCpfcAsyncConnection)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid))).Connect(null, null, null, null);
			}
			Mod1.session = Mod1.asyncConnection.Session;
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet((object)Mod1.session, (Type)null, "ListModels", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
			{
				lblog.get_Items().Add((object)"当前Proe 已经有打开的文件，请不要忘记保存！");
			}
			lblog.get_Items().Add((object)"PRO/E连接成功.");
			btnljproe.set_ForeColor(Color.Green);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"Pro/E 连接失败！！请手动关闭Pro/E所有进程！！", (MsgBoxStyle)64, (object)"连接失败");
			ProjectData.ClearProjectError();
		}
	}

	private void bjqd_Click(object sender, EventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		((Control)RibbonControl1).set_Cursor(Cursors.get_AppStarting());
		if (Mod1.Wait1)
		{
			Interaction.MsgBox((object)"与Pro/E模型相关的处理，请不要频繁操作，稍等片刻...", (MsgBoxStyle)64, (object)"提示");
		}
		else if (a & c)
		{
			if (Mod1.asyncConnection == null)
			{
				Interaction.MsgBox((object)"请点击按钮[连接至当前],测试Pro/e连接是否正常!", (MsgBoxStyle)0, (object)"提示");
				return;
			}
			if (Mod1.asyncConnection == null || Mod1.asyncConnection.IsRunning())
			{
				try
				{
					Mod1.modeld = Mod1.cmodeld.CreateFromFileName(Mod1.flay);
					IpfcSession session = Mod1.session;
					object[] array = new object[1] { Mod1.modeld };
					bool[] array2 = new bool[1] { true };
					object obj = NewLateBinding.LateGet((object)session, (Type)null, "RetrieveModel", array, (string[])null, (Type[])null, array2);
					if (array2[0])
					{
						Mod1.modeld = (IpfcModelDescriptor)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(IpfcModelDescriptor));
					}
					Mod1.model = (IpfcModel)obj;
					Mod1.model.Display();
					Mod1.win = (IpfcWindow)NewLateBinding.LateGet((object)Mod1.session, (Type)null, "CurrentWindow", new object[0], (string[])null, (Type[])null, (bool[])null);
					Mod1.win.Activate();
					Mod1.win.Repaint();
					Mod1.solid = (IpfcSolid)Mod1.model;
					try
					{
						Mod1.rege = Mod1.crege.Create(false, null, null);
						Mod1.solid.Regenerate(Mod1.rege);
						lblog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 布局驱动模型更新成功！"));
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						Interaction.MsgBox((object)("模型再生失败，请仔细检查参数或在Pro/E中调试.\r" + ex2.Message), (MsgBoxStyle)64, (object)"提示");
						ProjectData.ClearProjectError();
					}
					((BaseItem)bjqd).set_Enabled(false);
					Mod1.Wait1 = true;
					TM1.set_Interval(checked(Mod1.time1 * 1000));
					TM1.set_Enabled(true);
					TM1.Start();
					return;
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					Interaction.MsgBox((object)ex4.Message, (MsgBoxStyle)64, (object)"提示");
					ProjectData.ClearProjectError();
					return;
				}
			}
			Interaction.MsgBox((object)"请点击按钮[连接至当前],测试Pro/e连接是否正常!", (MsgBoxStyle)0, (object)"提示");
		}
		else
		{
			lblog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 请先更新布局参数文件xls，再更新布局lay文件！"));
		}
	}

	private void btnhqmx_Click(object sender, EventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (Mod1.asyncConnection == null)
		{
			Interaction.MsgBox((object)"请点击按钮[连接至当前],测试Pro/e连接是否正常!", (MsgBoxStyle)64, (object)"提示");
			return;
		}
		((Control)RibbonControl1).set_Cursor(Cursors.get_AppStarting());
		if (Mod1.asyncConnection != null && !Mod1.asyncConnection.IsRunning())
		{
			Interaction.MsgBox((object)"请点击按钮[连接至当前],测试Pro/e连接是否正常!", (MsgBoxStyle)64, (object)"提示");
			return;
		}
		if (Mod1.Wait1)
		{
			Interaction.MsgBox((object)"与Pro/E模型相关的处理，请不要频繁操作，稍等片刻...", (MsgBoxStyle)64, (object)"提示");
			return;
		}
		if (!hqmode())
		{
			Interaction.MsgBox((object)"没有找到目标文件，打开失败！！", (MsgBoxStyle)64, (object)"打开失败");
			lblog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 没有找到目标文件，打开失败！"));
			return;
		}
		Mod1.getm = true;
		Mod1.Wait1 = true;
		TM1.set_Interval(checked(Mod1.time1 * 1000));
		TM1.set_Enabled(true);
		TM1.Start();
		((BaseItem)btnhqmx).set_Enabled(false);
		((BaseItem)bjlaygx).set_Enabled(true);
	}

	public bool hqmode()
	{
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		bool result = true;
		if (Operators.CompareString(Strings.Trim(lbsl.get_Text()), "", false) != 0)
		{
			try
			{
				string[] array = new string[6]
				{
					Mod1.xdpath,
					"\\",
					null,
					null,
					null,
					null
				};
				ListBox val = lbcl;
				string text = val.get_Text();
				string text2 = Mod1.toen(ref text);
				val.set_Text(text);
				array[2] = text2;
				array[3] = "\\";
				array[4] = lbsl.get_Text();
				array[5] = "\\source\\";
				Mod1.flay = string.Concat(array);
				string[] files = Directory.GetFiles(Mod1.flay, lbsl.get_Text() + ".asm.*", SearchOption.AllDirectories);
				if (files.Length == 0)
				{
					files = Directory.GetFiles(Mod1.flay, lbsl.get_Text() + ".prt.*", SearchOption.AllDirectories);
					if (files.Length == 0)
					{
						result = false;
						return result;
					}
					Mod1.flay = Mod1.flay + lbsl.get_Text() + ".prt";
				}
				else
				{
					Mod1.flay = Mod1.flay + lbsl.get_Text() + ".asm";
				}
				Mod1.shichu();
				Mod1.modeld = Mod1.cmodeld.CreateFromFileName(Mod1.flay);
				IpfcSession session = Mod1.session;
				object[] array2 = new object[1] { Mod1.modeld };
				bool[] array3 = new bool[1] { true };
				object obj = NewLateBinding.LateGet((object)session, (Type)null, "RetrieveModel", array2, (string[])null, (Type[])null, array3);
				if (array3[0])
				{
					Mod1.modeld = (IpfcModelDescriptor)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(IpfcModelDescriptor));
				}
				Mod1.model = (IpfcModel)obj;
				Mod1.model.Display();
				Mod1.win = (IpfcWindow)NewLateBinding.LateGet((object)Mod1.session, (Type)null, "CurrentWindow", new object[0], (string[])null, (Type[])null, (bool[])null);
				Mod1.win.Activate();
				Mod1.win.Repaint();
				lblog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " " + Mod1.flay + " 获取库模型成功！"));
				return result;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)64, (object)"提示");
				ProjectData.ClearProjectError();
				return result;
			}
		}
		return result;
	}

	private void clxd_FormClosed(object sender, FormClosedEventArgs e)
	{
		checked
		{
			if (!jr)
			{
				int num = lblog.get_Items().get_Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					lblog.set_SelectedIndex(i);
					MyProject.Forms.Main.lslog.get_Items().Add((object)lblog.get_Text());
				}
				MyProject.Forms.Main.lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员关闭了分析向导"));
				try
				{
					wblay.Close(Missing.Value, Missing.Value, Missing.Value);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				((Component)(object)this).Dispose();
			}
		}
	}

	private void btngb_Click(object sender, EventArgs e)
	{
		jr = true;
		checked
		{
			int num = lblog.get_Items().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				lblog.set_SelectedIndex(i);
				MyProject.Forms.Main.lslog.get_Items().Add((object)lblog.get_Text());
			}
			MyProject.Forms.Main.lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员关闭了分析向导"));
			try
			{
				wblay.Close(Missing.Value, Missing.Value, Missing.Value);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			((Component)(object)this).Dispose();
		}
	}

	private void ButtonItem4_Click(object sender, EventArgs e)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		ListBox val = lbsl;
		string curxnpartname = val.get_Text();
		ll_lbzpnameselect(ref curxnpartname);
		val.set_Text(curxnpartname);
		lblog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " 操作员打开了生成工况对话框"));
		((Form)MyProject.Forms.fxdd).ShowDialog();
	}

	private void ll_lbzpnameselect(ref string curxnpartname)
	{
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		switch (curxnpartname)
		{
		case "主臂":
			Mod1.curloadcaseformat = "主臂长度,主臂组合";
			goto IL_00a9;
		case "主臂+固定副臂":
			Mod1.curloadcaseformat = "主臂长度,主臂组合,副臂长度,副臂组合,安装角度";
			goto IL_00a9;
		case "主臂+塔式副臂":
			Mod1.curloadcaseformat = "主臂长度,主臂组合,副臂长度,副臂组合,主臂仰角";
			goto IL_00a9;
		case "主臂+超起":
			Mod1.curloadcaseformat = "主臂长度,主臂组合,超起夹角";
			goto IL_00a9;
		case "主臂+固定副臂+超起":
			Mod1.curloadcaseformat = "主臂长度,主臂组合,副臂长度,副臂组合,安装角度,超起夹角";
			goto IL_00a9;
		case "主臂+塔式副臂+超起":
			Mod1.curloadcaseformat = "主臂长度,主臂组合,副臂长度,副臂组合,主臂仰角,超起夹角";
			goto IL_00a9;
		default:
			{
				Interaction.MsgBox((object)"当前装配文件夹名称不合法,请联系开发人员.. .", (MsgBoxStyle)64, (object)"提示");
				break;
			}
			IL_00a9:
			MyProject.Forms.ll_ufloadcaserow.ll_lbleformat.set_Text(Mod1.curloadcaseformat);
			MyProject.Forms.fxdd.ll_lbleformat.set_Text("序号," + Mod1.curloadcaseformat);
			((Control)MyProject.Forms.ll_ufloadcaserow).Refresh();
			strtemp = "【装配列表】-- " + curxnpartname;
			MyProject.Forms.fxdd.lslog.get_Items().Add((object)strtemp);
			strtemp = "相应工况表格式:" + Mod1.curloadcaseformat;
			MyProject.Forms.fxdd.lslog.get_Items().Add((object)strtemp);
			strtemp = "";
			lblog.get_Items().Add((object)strtemp);
			break;
		}
	}

	private void gb_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void ll_btnout_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Invalid comparison between Unknown and I4
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Invalid comparison between Unknown and I4
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Invalid comparison between Unknown and I4
		try
		{
			FolderBrowserDialog val = new FolderBrowserDialog();
			ListBox val2 = lbsl;
			string text = val2.get_Text();
			string text2 = Mod1.toen(ref text);
			val2.set_Text(text);
			if (Operators.CompareString(text2, "", false) == 0)
			{
				return;
			}
			val.set_Description("请选择输出文件夹路径");
			((CommonDialog)val).ShowDialog();
			if (!Directory.Exists(val.get_SelectedPath()) || Operators.CompareString(val.get_SelectedPath(), "", false) == 0)
			{
				return;
			}
			outpath = val.get_SelectedPath();
			val2 = lbsl;
			text = val2.get_Text();
			string text3 = Mod1.toen(ref text);
			val2.set_Text(text);
			if (Operators.CompareString(text3, "", false) == 0)
			{
				return;
			}
			if (outpath.IndexOf(" ") == -1)
			{
				((Control)this).set_Cursor(Cursors.get_AppStarting());
				FileSystemProxy fileSystem = ((ServerComputer)MyProject.Computer).get_FileSystem();
				string path = Mod1.path1;
				val2 = lbsl;
				text = val2.get_Text();
				string text4 = Mod1.toen(ref text);
				val2.set_Text(text);
				fileSystem.CopyDirectory(path + "\\xn\\" + text4 + "\\source", outpath, true);
				((Control)this).set_Cursor(Cursors.get_Arrow());
				if ((int)MessageBox.Show("输出文件成功，是否浏览？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 6)
				{
					Process.Start(outpath);
				}
			}
			else if ((int)MessageBox.Show("输出路径当中有空格，这可能会造成无法直接计算，是否继续输出？", "警告", (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
			{
				((Control)this).set_Cursor(Cursors.get_AppStarting());
				FileSystemProxy fileSystem2 = ((ServerComputer)MyProject.Computer).get_FileSystem();
				string path2 = Mod1.path1;
				val2 = lbsl;
				text = val2.get_Text();
				string text5 = Mod1.toen(ref text);
				val2.set_Text(text);
				fileSystem2.CopyDirectory(path2 + "\\xn\\" + text5 + "\\source", outpath, true);
				((Control)this).set_Cursor(Cursors.get_Arrow());
				if ((int)MessageBox.Show("输出文件成功，是否浏览？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 6)
				{
					Process.Start(outpath);
				}
			}
			else
			{
				outpath = "";
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ll_btnlookout_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(outpath, "", false) != 0)
		{
			Process.Start(outpath);
		}
	}

	private void ll_btnvarinfo_Click(object sender, EventArgs e)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		ListBox val = lbsl;
		string text = val.get_Text();
		string curxnpartname = Mod1.toen(ref text);
		val.set_Text(text);
		Mod1.curxnpartname = curxnpartname;
		((Form)MyProject.Forms.ll_ufxnIDsaveopt).ShowDialog();
		((Component)(object)MyProject.Forms.ll_ufxnIDsaveopt).Dispose();
	}

	private void lblog_DoubleClick(object sender, EventArgs e)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		Mod1.curtxtfname = lblog.get_Text();
		if (File.Exists(lblog.get_Text()))
		{
			((Form)MyProject.Forms.ll_ufshowtxtinfo).ShowDialog();
		}
	}

	private void btnfan_Click(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		getid1(lbcl.get_Text());
		((Form)MyProject.Forms.fanjs).ShowDialog();
	}

	public void getid1(string by)
	{
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		switch (by)
		{
		case "ansys性能计算":
			MyProject.Forms.fanjs.curenhanceID = "性能计算ID_" + lbsl.get_Text();
			break;
		case "ansys校核计算":
			MyProject.Forms.fanjs.curenhanceID = "校核计算ID_" + lbsl.get_Text();
			break;
		case "ansys方案计算":
			MyProject.Forms.fanjs.curenhanceID = "方案计算ID_" + lbsl.get_Text();
			break;
		case "proe几何检验":
			MyProject.Forms.fanjs.curenhanceID = "几何检验ID_" + lbsl.get_Text();
			break;
		case "proe局部详细":
			MyProject.Forms.fanjs.curenhanceID = "局部详细ID_" + lbsl.get_Text();
			break;
		case "proe设计":
			MyProject.Forms.fanjs.curenhanceID = "设计ID_" + lbsl.get_Text();
			break;
		default:
			Interaction.MsgBox((object)"没有适合的处理功能!! !", (MsgBoxStyle)64, (object)"提示");
			break;
		}
	}

	private void TM1_Tick(object sender, EventArgs e)
	{
		Mod1.Wait1 = false;
		TM1.Stop();
		((Control)RibbonControl1).set_Cursor(Cursors.get_Arrow());
	}
}
