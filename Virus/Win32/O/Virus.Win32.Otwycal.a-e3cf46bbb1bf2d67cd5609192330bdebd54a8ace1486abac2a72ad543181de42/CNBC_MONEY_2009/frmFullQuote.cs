using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CNBC.DAL;
using CNBC_MONEY_2009.My;
using Infragistics.Win.Misc;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CNBC_MONEY_2009;

[DesignerGenerated]
public class frmFullQuote : InheritedForm
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("lbldlp")]
	private Label _lbldlp;

	[AccessedThroughProperty("lbldl")]
	private Label _lbldl;

	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	[AccessedThroughProperty("lbldhp")]
	private Label _lbldhp;

	[AccessedThroughProperty("lblllow")]
	private Label _lblllow;

	[AccessedThroughProperty("lbllhigh")]
	private Label _lbllhigh;

	[AccessedThroughProperty("lblwlow")]
	private Label _lblwlow;

	[AccessedThroughProperty("lblwhigh")]
	private Label _lblwhigh;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("UltraGroupBox2")]
	private UltraGroupBox _UltraGroupBox2;

	[AccessedThroughProperty("lbllc")]
	private Label _lbllc;

	[AccessedThroughProperty("lblupc")]
	private Label _lblupc;

	[AccessedThroughProperty("lbldate")]
	private Label _lbldate;

	[AccessedThroughProperty("lblexsymbol")]
	private Label _lblexsymbol;

	[AccessedThroughProperty("lblsymbol")]
	private Label _lblsymbol;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("UltraGroupBox4")]
	private UltraGroupBox _UltraGroupBox4;

	[AccessedThroughProperty("lblclose")]
	private Label _lblclose;

	[AccessedThroughProperty("lbllow")]
	private Label _lbllow;

	[AccessedThroughProperty("lblhigh")]
	private Label _lblhigh;

	[AccessedThroughProperty("lblopen")]
	private Label _lblopen;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("UltraGroupBox3")]
	private UltraGroupBox _UltraGroupBox3;

	[AccessedThroughProperty("lbldh")]
	private Label _lbldh;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("lblvol")]
	private Label _lblvol;

	[AccessedThroughProperty("lblpchange")]
	private Label _lblpchange;

	[AccessedThroughProperty("lblchange")]
	private Label _lblchange;

	[AccessedThroughProperty("lbllp")]
	private Label _lbllp;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("UltraGroupBox5")]
	private UltraGroupBox _UltraGroupBox5;

	private string _BridgeSymbol;

	internal virtual Label lbldlp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbldlp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbldlp = value;
		}
	}

	internal virtual Label lbldl
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbldl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbldl = value;
		}
	}

	internal virtual Label Label21
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label21 = value;
		}
	}

	internal virtual Label lbldhp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbldhp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbldhp = value;
		}
	}

	internal virtual Label lblllow
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblllow;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblllow = value;
		}
	}

	internal virtual Label lbllhigh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbllhigh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbllhigh = value;
		}
	}

	internal virtual Label lblwlow
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblwlow;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblwlow = value;
		}
	}

	internal virtual Label lblwhigh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblwhigh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblwhigh = value;
		}
	}

	internal virtual Label Label12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label12 = value;
		}
	}

	internal virtual Label Label11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label11 = value;
		}
	}

	internal virtual Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
		}
	}

	internal virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
		}
	}

	internal virtual Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick((EventHandler)Timer1_Tick);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick((EventHandler)Timer1_Tick);
			}
		}
	}

	internal virtual UltraGroupBox UltraGroupBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _UltraGroupBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UltraGroupBox2 = value;
		}
	}

	internal virtual Label lbllc
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbllc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbllc = value;
		}
	}

	internal virtual Label lblupc
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblupc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblupc = value;
		}
	}

	internal virtual Label lbldate
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbldate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbldate = value;
		}
	}

	internal virtual Label lblexsymbol
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblexsymbol;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblexsymbol = value;
		}
	}

	internal virtual Label lblsymbol
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblsymbol;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblsymbol = value;
		}
	}

	internal virtual Label Label17
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label17 = value;
		}
	}

	internal virtual Label Label16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label16 = value;
		}
	}

	internal virtual Label Label15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label15 = value;
		}
	}

	internal virtual Label Label14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label14 = value;
		}
	}

	internal virtual Label Label13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label13 = value;
		}
	}

	internal virtual UltraGroupBox UltraGroupBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return _UltraGroupBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UltraGroupBox4 = value;
		}
	}

	internal virtual Label lblclose
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblclose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblclose = value;
		}
	}

	internal virtual Label lbllow
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbllow;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbllow = value;
		}
	}

	internal virtual Label lblhigh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblhigh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblhigh = value;
		}
	}

	internal virtual Label lblopen
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblopen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblopen = value;
		}
	}

	internal virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
		}
	}

	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
		}
	}

	internal virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
		}
	}

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual UltraGroupBox UltraGroupBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _UltraGroupBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UltraGroupBox3 = value;
		}
	}

	internal virtual Label lbldh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbldh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbldh = value;
		}
	}

	internal virtual Label Label19
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label19 = value;
		}
	}

	internal virtual Label lblvol
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblvol;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblvol = value;
		}
	}

	internal virtual Label lblpchange
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblpchange;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblpchange = value;
		}
	}

	internal virtual Label lblchange
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblchange;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblchange = value;
		}
	}

	internal virtual Label lbllp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbllp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbllp = value;
		}
	}

	internal virtual Label Label8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label8 = value;
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual UltraGroupBox UltraGroupBox5
	{
		[DebuggerNonUserCode]
		get
		{
			return _UltraGroupBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UltraGroupBox5 = value;
		}
	}

	public string BridgeSymbol
	{
		get
		{
			return _BridgeSymbol;
		}
		set
		{
			_BridgeSymbol = value;
		}
	}

	[DebuggerNonUserCode]
	public frmFullQuote()
	{
		((Form)this).add_Load((EventHandler)frmFullQuote_Load);
		__ENCList.Add(new WeakReference(this));
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
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
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected O, but got Unknown
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected O, but got Unknown
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Expected O, but got Unknown
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Expected O, but got Unknown
		//IL_075f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0769: Expected O, but got Unknown
		//IL_0813: Unknown result type (might be due to invalid IL or missing references)
		//IL_081d: Expected O, but got Unknown
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ce: Expected O, but got Unknown
		//IL_0975: Unknown result type (might be due to invalid IL or missing references)
		//IL_097f: Expected O, but got Unknown
		//IL_0b84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8e: Expected O, but got Unknown
		//IL_0c38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c42: Expected O, but got Unknown
		//IL_0ce9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf3: Expected O, but got Unknown
		//IL_0d9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da4: Expected O, but got Unknown
		//IL_0e4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e55: Expected O, but got Unknown
		//IL_0eff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f09: Expected O, but got Unknown
		//IL_0fa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0faf: Expected O, but got Unknown
		//IL_1059: Unknown result type (might be due to invalid IL or missing references)
		//IL_1063: Expected O, but got Unknown
		//IL_10fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1106: Expected O, but got Unknown
		//IL_11a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ac: Expected O, but got Unknown
		//IL_1245: Unknown result type (might be due to invalid IL or missing references)
		//IL_124f: Expected O, but got Unknown
		//IL_1446: Unknown result type (might be due to invalid IL or missing references)
		//IL_1450: Expected O, but got Unknown
		//IL_14fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1504: Expected O, but got Unknown
		//IL_15a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15aa: Expected O, but got Unknown
		//IL_1654: Unknown result type (might be due to invalid IL or missing references)
		//IL_165e: Expected O, but got Unknown
		//IL_1705: Unknown result type (might be due to invalid IL or missing references)
		//IL_170f: Expected O, but got Unknown
		//IL_17b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c0: Expected O, but got Unknown
		//IL_1867: Unknown result type (might be due to invalid IL or missing references)
		//IL_1871: Expected O, but got Unknown
		//IL_191b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1925: Expected O, but got Unknown
		//IL_19c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_19cb: Expected O, but got Unknown
		//IL_1a64: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a6e: Expected O, but got Unknown
		//IL_1b07: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b11: Expected O, but got Unknown
		//IL_1cee: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf8: Expected O, but got Unknown
		//IL_1da5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1daf: Expected O, but got Unknown
		//IL_1e5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e66: Expected O, but got Unknown
		//IL_1f10: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f1a: Expected O, but got Unknown
		//IL_1fc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fce: Expected O, but got Unknown
		//IL_2078: Unknown result type (might be due to invalid IL or missing references)
		//IL_2082: Expected O, but got Unknown
		//IL_211e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2128: Expected O, but got Unknown
		//IL_21c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ce: Expected O, but got Unknown
		//IL_226a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2274: Expected O, but got Unknown
		//IL_230d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2317: Expected O, but got Unknown
		components = new Container();
		UltraGroupBox5 = new UltraGroupBox();
		Label12 = new Label();
		Label9 = new Label();
		Label10 = new Label();
		Label11 = new Label();
		lblllow = new Label();
		lblwhigh = new Label();
		lbllhigh = new Label();
		lblwlow = new Label();
		UltraGroupBox4 = new UltraGroupBox();
		lblclose = new Label();
		lbllow = new Label();
		lblhigh = new Label();
		lblopen = new Label();
		lbldlp = new Label();
		Label7 = new Label();
		lbldl = new Label();
		Label6 = new Label();
		Label21 = new Label();
		Label5 = new Label();
		Label4 = new Label();
		UltraGroupBox3 = new UltraGroupBox();
		lbldh = new Label();
		Label19 = new Label();
		lblvol = new Label();
		lblpchange = new Label();
		lblchange = new Label();
		lbllp = new Label();
		lbldhp = new Label();
		Label8 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		Label1 = new Label();
		UltraGroupBox2 = new UltraGroupBox();
		lbllc = new Label();
		lblupc = new Label();
		lbldate = new Label();
		lblexsymbol = new Label();
		lblsymbol = new Label();
		Label17 = new Label();
		Label16 = new Label();
		Label15 = new Label();
		Label14 = new Label();
		Label13 = new Label();
		Timer1 = new Timer(components);
		((ISupportInitialize)grForm).BeginInit();
		((Control)grForm).SuspendLayout();
		((ISupportInitialize)UltraGroupBox5).BeginInit();
		((Control)UltraGroupBox5).SuspendLayout();
		((ISupportInitialize)UltraGroupBox4).BeginInit();
		((Control)UltraGroupBox4).SuspendLayout();
		((ISupportInitialize)UltraGroupBox3).BeginInit();
		((Control)UltraGroupBox3).SuspendLayout();
		((ISupportInitialize)UltraGroupBox2).BeginInit();
		((Control)UltraGroupBox2).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)grForm).get_Controls().Add((Control)(object)UltraGroupBox2);
		((Control)grForm).get_Controls().Add((Control)(object)UltraGroupBox5);
		((Control)grForm).get_Controls().Add((Control)(object)UltraGroupBox3);
		((Control)grForm).get_Controls().Add((Control)(object)UltraGroupBox4);
		UltraGroupBox obj = grForm;
		Size size = new Size(951, 277);
		((Control)obj).set_Size(size);
		grForm.set_Text("FULL QUOTE");
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)UltraGroupBox4, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)UltraGroupBox3, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)UltraGroupBox5, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)CloseButton, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)UltraGroupBox2, 0);
		UltraButton closeButton = CloseButton;
		Point location = new Point(911, 2);
		((Control)closeButton).set_Location(location);
		UltraGroupBox5.set_CaptionAlignment((GroupBoxCaptionAlignment)1);
		((Control)UltraGroupBox5).get_Controls().Add((Control)(object)Label12);
		((Control)UltraGroupBox5).get_Controls().Add((Control)(object)Label9);
		((Control)UltraGroupBox5).get_Controls().Add((Control)(object)Label10);
		((Control)UltraGroupBox5).get_Controls().Add((Control)(object)Label11);
		((Control)UltraGroupBox5).get_Controls().Add((Control)(object)lblllow);
		((Control)UltraGroupBox5).get_Controls().Add((Control)(object)lblwhigh);
		((Control)UltraGroupBox5).get_Controls().Add((Control)(object)lbllhigh);
		((Control)UltraGroupBox5).get_Controls().Add((Control)(object)lblwlow);
		UltraGroupBox ultraGroupBox = UltraGroupBox5;
		location = new Point(736, 30);
		((Control)ultraGroupBox).set_Location(location);
		((Control)UltraGroupBox5).set_Name("UltraGroupBox5");
		UltraGroupBox ultraGroupBox2 = UltraGroupBox5;
		size = new Size(208, 240);
		((Control)ultraGroupBox2).set_Size(size);
		((Control)UltraGroupBox5).set_TabIndex(85);
		UltraGroupBox5.set_ViewStyle((GroupBoxViewStyle)3);
		Label12.set_AutoSize(true);
		((Control)Label12).set_BackColor(Color.Transparent);
		((Control)Label12).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label12).set_ForeColor(Color.Black);
		Label label = Label12;
		location = new Point(8, 138);
		((Control)label).set_Location(location);
		((Control)Label12).set_Name("Label12");
		Label label2 = Label12;
		size = new Size(89, 13);
		((Control)label2).set_Size(size);
		((Control)Label12).set_TabIndex(52);
		Label12.set_Text("Lifetime Low");
		Label9.set_AutoSize(true);
		((Control)Label9).set_BackColor(Color.Transparent);
		((Control)Label9).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_ForeColor(Color.Black);
		Label label3 = Label9;
		location = new Point(8, 12);
		((Control)label3).set_Location(location);
		((Control)Label9).set_Name("Label9");
		Label label4 = Label9;
		size = new Size(96, 13);
		((Control)label4).set_Size(size);
		((Control)Label9).set_TabIndex(49);
		Label9.set_Text("52 Week High");
		Label10.set_AutoSize(true);
		((Control)Label10).set_BackColor(Color.Transparent);
		((Control)Label10).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label10).set_ForeColor(Color.Black);
		Label label5 = Label10;
		location = new Point(8, 54);
		((Control)label5).set_Location(location);
		((Control)Label10).set_Name("Label10");
		Label label6 = Label10;
		size = new Size(92, 13);
		((Control)label6).set_Size(size);
		((Control)Label10).set_TabIndex(50);
		Label10.set_Text("52 Week Low");
		Label11.set_AutoSize(true);
		((Control)Label11).set_BackColor(Color.Transparent);
		((Control)Label11).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label11).set_ForeColor(Color.Black);
		Label label7 = Label11;
		location = new Point(8, 96);
		((Control)label7).set_Location(location);
		((Control)Label11).set_Name("Label11");
		Label label8 = Label11;
		size = new Size(93, 13);
		((Control)label8).set_Size(size);
		((Control)Label11).set_TabIndex(51);
		Label11.set_Text("Lifetime High");
		lblllow.set_AutoSize(true);
		((Control)lblllow).set_BackColor(Color.Transparent);
		((Control)lblllow).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblllow).set_ForeColor(Color.Black);
		Label obj2 = lblllow;
		location = new Point(112, 138);
		((Control)obj2).set_Location(location);
		((Control)lblllow).set_Name("lblllow");
		Label obj3 = lblllow;
		size = new Size(77, 13);
		((Control)obj3).set_Size(size);
		((Control)lblllow).set_TabIndex(74);
		lblllow.set_Text("LifeTimeLow");
		lblllow.set_TextAlign((ContentAlignment)32);
		lblwhigh.set_AutoSize(true);
		((Control)lblwhigh).set_BackColor(Color.Transparent);
		((Control)lblwhigh).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblwhigh).set_ForeColor(Color.Black);
		Label obj4 = lblwhigh;
		location = new Point(112, 12);
		((Control)obj4).set_Location(location);
		((Control)lblwhigh).set_Name("lblwhigh");
		Label obj5 = lblwhigh;
		size = new Size(78, 13);
		((Control)obj5).set_Size(size);
		((Control)lblwhigh).set_TabIndex(71);
		lblwhigh.set_Text("52WeekHigh");
		lblwhigh.set_TextAlign((ContentAlignment)32);
		lbllhigh.set_AutoSize(true);
		((Control)lbllhigh).set_BackColor(Color.Transparent);
		((Control)lbllhigh).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lbllhigh).set_ForeColor(Color.Black);
		Label obj6 = lbllhigh;
		location = new Point(112, 96);
		((Control)obj6).set_Location(location);
		((Control)lbllhigh).set_Name("lbllhigh");
		Label obj7 = lbllhigh;
		size = new Size(80, 13);
		((Control)obj7).set_Size(size);
		((Control)lbllhigh).set_TabIndex(73);
		lbllhigh.set_Text("LifeTimeHigh");
		lbllhigh.set_TextAlign((ContentAlignment)32);
		lblwlow.set_AutoSize(true);
		((Control)lblwlow).set_BackColor(Color.Transparent);
		((Control)lblwlow).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblwlow).set_ForeColor(Color.Black);
		Label obj8 = lblwlow;
		location = new Point(112, 54);
		((Control)obj8).set_Location(location);
		((Control)lblwlow).set_Name("lblwlow");
		Label obj9 = lblwlow;
		size = new Size(75, 13);
		((Control)obj9).set_Size(size);
		((Control)lblwlow).set_TabIndex(72);
		lblwlow.set_Text("52WeekLow");
		lblwlow.set_TextAlign((ContentAlignment)32);
		UltraGroupBox4.set_CaptionAlignment((GroupBoxCaptionAlignment)1);
		((Control)UltraGroupBox4).get_Controls().Add((Control)(object)lblclose);
		((Control)UltraGroupBox4).get_Controls().Add((Control)(object)lbllow);
		((Control)UltraGroupBox4).get_Controls().Add((Control)(object)lblhigh);
		((Control)UltraGroupBox4).get_Controls().Add((Control)(object)lblopen);
		((Control)UltraGroupBox4).get_Controls().Add((Control)(object)lbldlp);
		((Control)UltraGroupBox4).get_Controls().Add((Control)(object)Label7);
		((Control)UltraGroupBox4).get_Controls().Add((Control)(object)lbldl);
		((Control)UltraGroupBox4).get_Controls().Add((Control)(object)Label6);
		((Control)UltraGroupBox4).get_Controls().Add((Control)(object)Label21);
		((Control)UltraGroupBox4).get_Controls().Add((Control)(object)Label5);
		((Control)UltraGroupBox4).get_Controls().Add((Control)(object)Label4);
		UltraGroupBox ultraGroupBox3 = UltraGroupBox4;
		location = new Point(530, 30);
		((Control)ultraGroupBox3).set_Location(location);
		((Control)UltraGroupBox4).set_Name("UltraGroupBox4");
		UltraGroupBox ultraGroupBox4 = UltraGroupBox4;
		size = new Size(205, 240);
		((Control)ultraGroupBox4).set_Size(size);
		((Control)UltraGroupBox4).set_TabIndex(84);
		UltraGroupBox4.set_ViewStyle((GroupBoxViewStyle)3);
		lblclose.set_AutoSize(true);
		((Control)lblclose).set_BackColor(Color.Transparent);
		((Control)lblclose).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblclose).set_ForeColor(Color.Black);
		Label obj10 = lblclose;
		location = new Point(110, 138);
		((Control)obj10).set_Location(location);
		((Control)lblclose).set_Name("lblclose");
		Label obj11 = lblclose;
		size = new Size(39, 13);
		((Control)obj11).set_Size(size);
		((Control)lblclose).set_TabIndex(78);
		lblclose.set_Text("Close");
		lblclose.set_TextAlign((ContentAlignment)32);
		lbllow.set_AutoSize(true);
		((Control)lbllow).set_BackColor(Color.Transparent);
		((Control)lbllow).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lbllow).set_ForeColor(Color.Black);
		Label obj12 = lbllow;
		location = new Point(110, 96);
		((Control)obj12).set_Location(location);
		((Control)lbllow).set_Name("lbllow");
		Label obj13 = lbllow;
		size = new Size(29, 13);
		((Control)obj13).set_Size(size);
		((Control)lbllow).set_TabIndex(77);
		lbllow.set_Text("Low");
		lbllow.set_TextAlign((ContentAlignment)32);
		lblhigh.set_AutoSize(true);
		((Control)lblhigh).set_BackColor(Color.Transparent);
		((Control)lblhigh).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblhigh).set_ForeColor(Color.Black);
		Label obj14 = lblhigh;
		location = new Point(110, 54);
		((Control)obj14).set_Location(location);
		((Control)lblhigh).set_Name("lblhigh");
		Label obj15 = lblhigh;
		size = new Size(32, 13);
		((Control)obj15).set_Size(size);
		((Control)lblhigh).set_TabIndex(76);
		lblhigh.set_Text("High");
		lblhigh.set_TextAlign((ContentAlignment)32);
		lblopen.set_AutoSize(true);
		((Control)lblopen).set_BackColor(Color.Transparent);
		((Control)lblopen).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblopen).set_ForeColor(Color.Black);
		Label obj16 = lblopen;
		location = new Point(110, 12);
		((Control)obj16).set_Location(location);
		((Control)lblopen).set_Name("lblopen");
		Label obj17 = lblopen;
		size = new Size(37, 13);
		((Control)obj17).set_Size(size);
		((Control)lblopen).set_TabIndex(75);
		lblopen.set_Text("Open");
		lblopen.set_TextAlign((ContentAlignment)64);
		lbldlp.set_AutoSize(true);
		((Control)lbldlp).set_BackColor(Color.Transparent);
		((Control)lbldlp).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lbldlp).set_ForeColor(Color.Black);
		Label obj18 = lbldlp;
		location = new Point(110, 211);
		((Control)obj18).set_Location(location);
		((Control)lbldlp).set_Name("lbldlp");
		Label obj19 = lbldlp;
		size = new Size(76, 13);
		((Control)obj19).set_Size(size);
		((Control)lbldlp).set_TabIndex(81);
		lbldlp.set_Text("OffDayLow2");
		lbldlp.set_TextAlign((ContentAlignment)32);
		Label7.set_AutoSize(true);
		((Control)Label7).set_BackColor(Color.Transparent);
		((Control)Label7).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.Black);
		Label label9 = Label7;
		location = new Point(7, 138);
		((Control)label9).set_Location(location);
		((Control)Label7).set_Name("Label7");
		Label label10 = Label7;
		size = new Size(42, 13);
		((Control)label10).set_Size(size);
		((Control)Label7).set_TabIndex(74);
		Label7.set_Text("Close");
		lbldl.set_AutoSize(true);
		((Control)lbldl).set_BackColor(Color.Transparent);
		((Control)lbldl).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lbldl).set_ForeColor(Color.Black);
		Label obj20 = lbldl;
		location = new Point(110, 180);
		((Control)obj20).set_Location(location);
		((Control)lbldl).set_Name("lbldl");
		Label obj21 = lbldl;
		size = new Size(76, 13);
		((Control)obj21).set_Size(size);
		((Control)lbldl).set_TabIndex(80);
		lbldl.set_Text("OffDayLow1");
		lbldl.set_TextAlign((ContentAlignment)32);
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.Transparent);
		((Control)Label6).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.Black);
		Label label11 = Label6;
		location = new Point(7, 96);
		((Control)label11).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label12 = Label6;
		size = new Size(32, 13);
		((Control)label12).set_Size(size);
		((Control)Label6).set_TabIndex(73);
		Label6.set_Text("Low");
		Label21.set_AutoSize(true);
		((Control)Label21).set_BackColor(Color.Transparent);
		((Control)Label21).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label21).set_ForeColor(Color.Black);
		Label label13 = Label21;
		location = new Point(7, 180);
		((Control)label13).set_Location(location);
		((Control)Label21).set_Name("Label21");
		Label label14 = Label21;
		size = new Size(95, 13);
		((Control)label14).set_Size(size);
		((Control)Label21).set_TabIndex(79);
		Label21.set_Text("Off Day's Low");
		Label5.set_AutoSize(true);
		((Control)Label5).set_BackColor(Color.Transparent);
		((Control)Label5).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_ForeColor(Color.Black);
		Label label15 = Label5;
		location = new Point(7, 54);
		((Control)label15).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label16 = Label5;
		size = new Size(36, 13);
		((Control)label16).set_Size(size);
		((Control)Label5).set_TabIndex(72);
		Label5.set_Text("High");
		Label4.set_AutoSize(true);
		((Control)Label4).set_BackColor(Color.Transparent);
		((Control)Label4).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_ForeColor(Color.Black);
		Label label17 = Label4;
		location = new Point(7, 12);
		((Control)label17).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label18 = Label4;
		size = new Size(40, 13);
		((Control)label18).set_Size(size);
		((Control)Label4).set_TabIndex(71);
		Label4.set_Text("Open");
		UltraGroupBox3.set_CaptionAlignment((GroupBoxCaptionAlignment)1);
		((Control)UltraGroupBox3).get_Controls().Add((Control)(object)lbldh);
		((Control)UltraGroupBox3).get_Controls().Add((Control)(object)Label19);
		((Control)UltraGroupBox3).get_Controls().Add((Control)(object)lblvol);
		((Control)UltraGroupBox3).get_Controls().Add((Control)(object)lblpchange);
		((Control)UltraGroupBox3).get_Controls().Add((Control)(object)lblchange);
		((Control)UltraGroupBox3).get_Controls().Add((Control)(object)lbllp);
		((Control)UltraGroupBox3).get_Controls().Add((Control)(object)lbldhp);
		((Control)UltraGroupBox3).get_Controls().Add((Control)(object)Label8);
		((Control)UltraGroupBox3).get_Controls().Add((Control)(object)Label3);
		((Control)UltraGroupBox3).get_Controls().Add((Control)(object)Label2);
		((Control)UltraGroupBox3).get_Controls().Add((Control)(object)Label1);
		UltraGroupBox ultraGroupBox5 = UltraGroupBox3;
		location = new Point(296, 30);
		((Control)ultraGroupBox5).set_Location(location);
		((Control)UltraGroupBox3).set_Name("UltraGroupBox3");
		UltraGroupBox ultraGroupBox6 = UltraGroupBox3;
		size = new Size(233, 240);
		((Control)ultraGroupBox6).set_Size(size);
		((Control)UltraGroupBox3).set_TabIndex(83);
		UltraGroupBox3.set_ViewStyle((GroupBoxViewStyle)3);
		lbldh.set_AutoSize(true);
		((Control)lbldh).set_BackColor(Color.Transparent);
		((Control)lbldh).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lbldh).set_ForeColor(Color.Black);
		Label obj22 = lbldh;
		location = new Point(123, 180);
		((Control)obj22).set_Location(location);
		((Control)lbldh).set_Name("lbldh");
		Label obj23 = lbldh;
		size = new Size(79, 13);
		((Control)obj23).set_Size(size);
		((Control)lbldh).set_TabIndex(87);
		lbldh.set_Text("OffDayHigh1");
		lbldh.set_TextAlign((ContentAlignment)32);
		Label19.set_AutoSize(true);
		((Control)Label19).set_BackColor(Color.Transparent);
		((Control)Label19).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label19).set_ForeColor(Color.Black);
		Label label19 = Label19;
		location = new Point(6, 180);
		((Control)label19).set_Location(location);
		((Control)Label19).set_Name("Label19");
		Label label20 = Label19;
		size = new Size(99, 13);
		((Control)label20).set_Size(size);
		((Control)Label19).set_TabIndex(86);
		Label19.set_Text("Off Day's High");
		lblvol.set_AutoSize(true);
		((Control)lblvol).set_BackColor(Color.Transparent);
		((Control)lblvol).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblvol).set_ForeColor(Color.Black);
		Label obj24 = lblvol;
		location = new Point(123, 138);
		((Control)obj24).set_Location(location);
		((Control)lblvol).set_Name("lblvol");
		Label obj25 = lblvol;
		size = new Size(50, 13);
		((Control)obj25).set_Size(size);
		((Control)lblvol).set_TabIndex(85);
		lblvol.set_Text("Volume");
		lblvol.set_TextAlign((ContentAlignment)32);
		lblpchange.set_AutoSize(true);
		((Control)lblpchange).set_BackColor(Color.Transparent);
		((Control)lblpchange).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblpchange).set_ForeColor(Color.Black);
		Label obj26 = lblpchange;
		location = new Point(123, 96);
		((Control)obj26).set_Location(location);
		((Control)lblpchange).set_Name("lblpchange");
		Label obj27 = lblpchange;
		size = new Size(102, 13);
		((Control)obj27).set_Size(size);
		((Control)lblpchange).set_TabIndex(84);
		lblpchange.set_Text("Percent  Change");
		lblpchange.set_TextAlign((ContentAlignment)32);
		lblchange.set_AutoSize(true);
		((Control)lblchange).set_BackColor(Color.Transparent);
		((Control)lblchange).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblchange).set_ForeColor(Color.Black);
		Label obj28 = lblchange;
		location = new Point(123, 54);
		((Control)obj28).set_Location(location);
		((Control)lblchange).set_Name("lblchange");
		Label obj29 = lblchange;
		size = new Size(51, 13);
		((Control)obj29).set_Size(size);
		((Control)lblchange).set_TabIndex(83);
		lblchange.set_Text("Change");
		lblchange.set_TextAlign((ContentAlignment)32);
		lbllp.set_AutoSize(true);
		((Control)lbllp).set_BackColor(Color.Transparent);
		((Control)lbllp).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lbllp).set_ForeColor(Color.Black);
		Label obj30 = lbllp;
		location = new Point(123, 12);
		((Control)obj30).set_Location(location);
		((Control)lbllp).set_Name("lbllp");
		Label obj31 = lbllp;
		size = new Size(58, 13);
		((Control)obj31).set_Size(size);
		((Control)lbllp).set_TabIndex(82);
		lbllp.set_Text("LastPrice");
		lbllp.set_TextAlign((ContentAlignment)32);
		lbldhp.set_AutoSize(true);
		((Control)lbldhp).set_BackColor(Color.Transparent);
		((Control)lbldhp).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lbldhp).set_ForeColor(Color.Black);
		Label obj32 = lbldhp;
		location = new Point(123, 211);
		((Control)obj32).set_Location(location);
		((Control)lbldhp).set_Name("lbldhp");
		Label obj33 = lbldhp;
		size = new Size(79, 13);
		((Control)obj33).set_Size(size);
		((Control)lbldhp).set_TabIndex(78);
		lbldhp.set_Text("OffDayHigh2");
		lbldhp.set_TextAlign((ContentAlignment)32);
		Label8.set_AutoSize(true);
		((Control)Label8).set_BackColor(Color.Transparent);
		((Control)Label8).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_ForeColor(Color.Black);
		Label label21 = Label8;
		location = new Point(6, 138);
		((Control)label21).set_Location(location);
		((Control)Label8).set_Name("Label8");
		Label label22 = Label8;
		size = new Size(55, 13);
		((Control)label22).set_Size(size);
		((Control)Label8).set_TabIndex(81);
		Label8.set_Text("Volume");
		Label3.set_AutoSize(true);
		((Control)Label3).set_BackColor(Color.Transparent);
		((Control)Label3).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.Black);
		Label label23 = Label3;
		location = new Point(6, 96);
		((Control)label23).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label24 = Label3;
		size = new Size(109, 13);
		((Control)label24).set_Size(size);
		((Control)Label3).set_TabIndex(80);
		Label3.set_Text("Percent Change");
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(Color.Transparent);
		((Control)Label2).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.Black);
		Label label25 = Label2;
		location = new Point(6, 54);
		((Control)label25).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label26 = Label2;
		size = new Size(55, 13);
		((Control)label26).set_Size(size);
		((Control)Label2).set_TabIndex(79);
		Label2.set_Text("Change");
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.Black);
		Label label27 = Label1;
		location = new Point(6, 12);
		((Control)label27).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label28 = Label1;
		size = new Size(67, 13);
		((Control)label28).set_Size(size);
		((Control)Label1).set_TabIndex(78);
		Label1.set_Text("LastPrice");
		UltraGroupBox2.set_CaptionAlignment((GroupBoxCaptionAlignment)1);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)lbllc);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)lblupc);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)lbldate);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)lblexsymbol);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)lblsymbol);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)Label17);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)Label16);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)Label15);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)Label14);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)Label13);
		UltraGroupBox ultraGroupBox7 = UltraGroupBox2;
		location = new Point(4, 30);
		((Control)ultraGroupBox7).set_Location(location);
		((Control)UltraGroupBox2).set_Name("UltraGroupBox2");
		UltraGroupBox ultraGroupBox8 = UltraGroupBox2;
		size = new Size(291, 240);
		((Control)ultraGroupBox8).set_Size(size);
		((Control)UltraGroupBox2).set_TabIndex(82);
		UltraGroupBox2.set_ViewStyle((GroupBoxViewStyle)3);
		lbllc.set_AutoSize(true);
		((Control)lbllc).set_BackColor(Color.Transparent);
		((Control)lbllc).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lbllc).set_ForeColor(Color.Black);
		Label obj34 = lbllc;
		location = new Point(145, 180);
		((Control)obj34).set_Location(location);
		((Control)lbllc).set_Name("lbllc");
		Label obj35 = lbllc;
		size = new Size(82, 13);
		((Control)obj35).set_Size(size);
		((Control)lbllc).set_TabIndex(72);
		lbllc.set_Text("Lower Circuit");
		lbllc.set_TextAlign((ContentAlignment)32);
		lblupc.set_AutoSize(true);
		((Control)lblupc).set_BackColor(Color.Transparent);
		((Control)lblupc).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblupc).set_ForeColor(Color.Black);
		Label obj36 = lblupc;
		location = new Point(145, 138);
		((Control)obj36).set_Location(location);
		((Control)lblupc).set_Name("lblupc");
		Label obj37 = lblupc;
		size = new Size(82, 13);
		((Control)obj37).set_Size(size);
		((Control)lblupc).set_TabIndex(71);
		lblupc.set_Text("Upper Circuit");
		lblupc.set_TextAlign((ContentAlignment)32);
		lbldate.set_AutoSize(true);
		((Control)lbldate).set_BackColor(Color.Transparent);
		((Control)lbldate).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lbldate).set_ForeColor(Color.Black);
		Label obj38 = lbldate;
		location = new Point(145, 96);
		((Control)obj38).set_Location(location);
		((Control)lbldate).set_Name("lbldate");
		Label obj39 = lbldate;
		size = new Size(113, 13);
		((Control)obj39).set_Size(size);
		((Control)lbldate).set_TabIndex(70);
		lbldate.set_Text("Last Updated Time");
		lbldate.set_TextAlign((ContentAlignment)32);
		lblexsymbol.set_AutoSize(true);
		((Control)lblexsymbol).set_BackColor(Color.Transparent);
		((Control)lblexsymbol).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblexsymbol).set_ForeColor(Color.Black);
		Label obj40 = lblexsymbol;
		location = new Point(145, 54);
		((Control)obj40).set_Location(location);
		((Control)lblexsymbol).set_Name("lblexsymbol");
		Label obj41 = lblexsymbol;
		size = new Size(109, 13);
		((Control)obj41).set_Size(size);
		((Control)lblexsymbol).set_TabIndex(69);
		lblexsymbol.set_Text("Exchange Symbol");
		lblexsymbol.set_TextAlign((ContentAlignment)32);
		lblsymbol.set_AutoSize(true);
		((Control)lblsymbol).set_BackColor(Color.Transparent);
		((Control)lblsymbol).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblsymbol).set_ForeColor(Color.Black);
		Label obj42 = lblsymbol;
		location = new Point(145, 12);
		((Control)obj42).set_Location(location);
		((Control)lblsymbol).set_Name("lblsymbol");
		Label obj43 = lblsymbol;
		size = new Size(87, 13);
		((Control)obj43).set_Size(size);
		((Control)lblsymbol).set_TabIndex(68);
		lblsymbol.set_Text("BridgeSymbol");
		lblsymbol.set_TextAlign((ContentAlignment)32);
		Label17.set_AutoSize(true);
		((Control)Label17).set_BackColor(Color.Transparent);
		((Control)Label17).set_Font(new Font("Verdana", 8.5f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label17).set_ForeColor(Color.Black);
		Label label29 = Label17;
		location = new Point(7, 180);
		((Control)label29).set_Location(location);
		((Control)Label17).set_Name("Label17");
		Label label30 = Label17;
		size = new Size(96, 14);
		((Control)label30).set_Size(size);
		((Control)Label17).set_TabIndex(67);
		Label17.set_Text("Lower Circuit");
		Label16.set_AutoSize(true);
		((Control)Label16).set_BackColor(Color.Transparent);
		((Control)Label16).set_Font(new Font("Verdana", 8.5f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label16).set_ForeColor(Color.Black);
		Label label31 = Label16;
		location = new Point(7, 138);
		((Control)label31).set_Location(location);
		((Control)Label16).set_Name("Label16");
		Label label32 = Label16;
		size = new Size(90, 14);
		((Control)label32).set_Size(size);
		((Control)Label16).set_TabIndex(66);
		Label16.set_Text("UpperCircuit");
		Label15.set_AutoSize(true);
		((Control)Label15).set_BackColor(Color.Transparent);
		((Control)Label15).set_Font(new Font("Verdana", 8.5f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label15).set_ForeColor(Color.Black);
		Label label33 = Label15;
		location = new Point(7, 96);
		((Control)label33).set_Location(location);
		((Control)Label15).set_Name("Label15");
		Label label34 = Label15;
		size = new Size(130, 14);
		((Control)label34).set_Size(size);
		((Control)Label15).set_TabIndex(65);
		Label15.set_Text("Last Updated Time");
		Label14.set_AutoSize(true);
		((Control)Label14).set_BackColor(Color.Transparent);
		((Control)Label14).set_Font(new Font("Verdana", 8.5f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label14).set_ForeColor(Color.Black);
		Label label35 = Label14;
		location = new Point(7, 54);
		((Control)label35).set_Location(location);
		((Control)Label14).set_Name("Label14");
		Label label36 = Label14;
		size = new Size(123, 14);
		((Control)label36).set_Size(size);
		((Control)Label14).set_TabIndex(64);
		Label14.set_Text("Exchange Symbol");
		Label13.set_AutoSize(true);
		((Control)Label13).set_BackColor(Color.Transparent);
		((Control)Label13).set_Font(new Font("Verdana", 8.5f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label13).set_ForeColor(Color.Black);
		Label label37 = Label13;
		location = new Point(7, 12);
		((Control)label37).set_Location(location);
		((Control)Label13).set_Name("Label13");
		Label label38 = Label13;
		size = new Size(99, 14);
		((Control)label38).set_Size(size);
		((Control)Label13).set_TabIndex(63);
		Label13.set_Text("BridgeSymbol");
		Timer1.set_Enabled(true);
		Timer1.set_Interval(3000);
		SizeF autoScaleDimensions = new SizeF(7f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		size = new Size(951, 277);
		((Form)this).set_ClientSize(size);
		((Control)this).set_Name("frmFullQuote");
		((ISupportInitialize)grForm).EndInit();
		((Control)grForm).ResumeLayout(false);
		((ISupportInitialize)UltraGroupBox5).EndInit();
		((Control)UltraGroupBox5).ResumeLayout(false);
		((Control)UltraGroupBox5).PerformLayout();
		((ISupportInitialize)UltraGroupBox4).EndInit();
		((Control)UltraGroupBox4).ResumeLayout(false);
		((Control)UltraGroupBox4).PerformLayout();
		((ISupportInitialize)UltraGroupBox3).EndInit();
		((Control)UltraGroupBox3).ResumeLayout(false);
		((Control)UltraGroupBox3).PerformLayout();
		((ISupportInitialize)UltraGroupBox2).EndInit();
		((Control)UltraGroupBox2).ResumeLayout(false);
		((Control)UltraGroupBox2).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void frmFullQuote_Load(object sender, EventArgs e)
	{
		Money_Splash money_Splash = new Money_Splash();
		((Control)money_Splash).Show();
		((Control)money_Splash).Refresh();
		BindControls();
		((Form)money_Splash).Close();
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Timer1.set_Enabled(false);
		BindControls();
		Timer1.set_Enabled(true);
	}

	private void BindControls()
	{
		try
		{
			DataTable dataTable = new DataTable();
			string text = "Select * from equity_transaction_data where bridgesymbol='" + BridgeSymbol + "' and series in ('BE','EQ','INX') and market_type='N'";
			dataTable = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, text).Tables[0];
			if (dataTable.Rows[0]["Shortname"] != DBNull.Value)
			{
				grForm.set_Text(Conversions.ToString(dataTable.Rows[0]["Shortname"]));
			}
			if (dataTable.Rows[0]["change"] != DBNull.Value)
			{
				lblchange.set_Text(Strings.FormatNumber(Operators.SubtractObject(dataTable.Rows[0]["lastprice"], dataTable.Rows[0]["Close"]), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)));
			}
			if (dataTable.Rows[0]["Close"] != DBNull.Value)
			{
				lblclose.set_Text(Conversions.ToString(dataTable.Rows[0]["Close"]));
			}
			if (dataTable.Rows[0]["Time"] != DBNull.Value)
			{
				lbldate.set_Text(Conversions.ToString(dataTable.Rows[0]["Time"]));
			}
			if (dataTable.Rows[0]["exchangesymbol"] != DBNull.Value)
			{
				lblexsymbol.set_Text(Conversions.ToString(dataTable.Rows[0]["exchangesymbol"]));
			}
			if (dataTable.Rows[0]["High"] != DBNull.Value)
			{
				lblhigh.set_Text(Conversions.ToString(dataTable.Rows[0]["High"]));
			}
			if (dataTable.Rows[0]["lower_circuit"] != DBNull.Value)
			{
				lbllc.set_Text(Conversions.ToString(dataTable.Rows[0]["lower_circuit"]));
			}
			if (dataTable.Rows[0]["lifetimehigh"] != DBNull.Value)
			{
				lbllhigh.set_Text(Conversions.ToString(dataTable.Rows[0]["lifetimehigh"]));
			}
			if (dataTable.Rows[0]["lifetimelow"] != DBNull.Value)
			{
				lblllow.set_Text(Conversions.ToString(dataTable.Rows[0]["lifetimelow"]));
			}
			if (dataTable.Rows[0]["Low"] != DBNull.Value)
			{
				lbllow.set_Text(Conversions.ToString(dataTable.Rows[0]["Low"]));
			}
			if (dataTable.Rows[0]["lastprice"] != DBNull.Value)
			{
				lbllp.set_Text(Conversions.ToString(dataTable.Rows[0]["lastprice"]));
			}
			if (dataTable.Rows[0]["Open"] != DBNull.Value)
			{
				lblopen.set_Text(Conversions.ToString(dataTable.Rows[0]["Open"]));
			}
			if (dataTable.Rows[0]["percentchange"] != DBNull.Value)
			{
				lblpchange.set_Text(Strings.FormatNumber(Operators.MultiplyObject(Operators.DivideObject(Operators.SubtractObject(dataTable.Rows[0]["lastprice"], dataTable.Rows[0]["Close"]), dataTable.Rows[0]["Close"]), (object)100), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)) + "%");
			}
			if (dataTable.Rows[0]["bridgesymbol"] != DBNull.Value)
			{
				lblsymbol.set_Text(Conversions.ToString(dataTable.Rows[0]["bridgesymbol"]));
			}
			if (dataTable.Rows[0]["upper_circuit"] != DBNull.Value)
			{
				lblupc.set_Text(Conversions.ToString(dataTable.Rows[0]["upper_circuit"]));
			}
			if (dataTable.Rows[0]["Volume"] != DBNull.Value)
			{
				lblvol.set_Text(Conversions.ToString(dataTable.Rows[0]["Volume"]));
			}
			if (dataTable.Rows[0]["weekhigh52"] != DBNull.Value)
			{
				lblwhigh.set_Text(Conversions.ToString(dataTable.Rows[0]["weekhigh52"]));
			}
			if (dataTable.Rows[0]["weeklow52"] != DBNull.Value)
			{
				lblwlow.set_Text(Conversions.ToString(dataTable.Rows[0]["weeklow52"]));
			}
			lbldh.set_Text(Strings.FormatNumber((object)(Conversions.ToDouble(lblhigh.get_Text()) - Conversions.ToDouble(lbllp.get_Text())), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)));
			lbldhp.set_Text(Strings.FormatNumber((object)((Conversions.ToDouble(lblhigh.get_Text()) - Conversions.ToDouble(lbllp.get_Text())) / Conversions.ToDouble(lbllp.get_Text()) * 100.0), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)) + "%");
			lbldl.set_Text(Strings.FormatNumber((object)(Conversions.ToDouble(lbllp.get_Text()) - Conversions.ToDouble(lbllow.get_Text())), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)));
			lbldlp.set_Text(Strings.FormatNumber((object)((Conversions.ToDouble(lbllp.get_Text()) - Conversions.ToDouble(lbllow.get_Text())) / Conversions.ToDouble(lbllow.get_Text()) * 100.0), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)) + "%");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
