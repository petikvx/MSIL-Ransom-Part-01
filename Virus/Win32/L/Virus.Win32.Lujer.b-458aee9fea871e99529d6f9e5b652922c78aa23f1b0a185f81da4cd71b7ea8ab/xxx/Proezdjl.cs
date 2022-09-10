using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using pfcls;
using xxx.My;

namespace xxx;

[DesignerGenerated]
public class Proezdjl : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("ll_lblccs")]
	private ListBox _ll_lblccs;

	[AccessedThroughProperty("ll_txtlccs")]
	private TextBoxX _ll_txtlccs;

	[AccessedThroughProperty("ll_btnshang")]
	private ButtonX _ll_btnshang;

	[AccessedThroughProperty("ll_btnxia")]
	private ButtonX _ll_btnxia;

	[AccessedThroughProperty("ll_btnremoved")]
	private ButtonX _ll_btnremoved;

	[AccessedThroughProperty("ll_btnclear")]
	private ButtonX _ll_btnclear;

	[AccessedThroughProperty("ll_btnchecklccs")]
	private ButtonX _ll_btnchecklccs;

	[AccessedThroughProperty("ll_btnadd2cur")]
	private ButtonX _ll_btnadd2cur;

	[AccessedThroughProperty("ll_btneditcur")]
	private ButtonX _ll_btneditcur;

	[AccessedThroughProperty("ll_btn5filecs")]
	private ButtonX _ll_btn5filecs;

	[AccessedThroughProperty("ll_btn5fileothercs")]
	private ButtonX _ll_btn5fileothercs;

	[AccessedThroughProperty("ll_btn2filecs")]
	private ButtonX _ll_btn2filecs;

	[AccessedThroughProperty("LabelX2")]
	private LabelX _LabelX2;

	[AccessedThroughProperty("LabelX3")]
	private LabelX _LabelX3;

	[AccessedThroughProperty("ll_txtmp1")]
	private TextBoxX _ll_txtmp1;

	[AccessedThroughProperty("ll_cbmsq")]
	private ComboBoxEx _ll_cbmsq;

	[AccessedThroughProperty("ll_btnmsq")]
	private ButtonX _ll_btnmsq;

	[AccessedThroughProperty("LabelX4")]
	private LabelX _LabelX4;

	[AccessedThroughProperty("ll_btn5filekey")]
	private ButtonX _ll_btn5filekey;

	[AccessedThroughProperty("ll_btn5fileotherkey")]
	private ButtonX _ll_btn5fileotherkey;

	[AccessedThroughProperty("ll_btn2filekey")]
	private ButtonX _ll_btn2filekey;

	[AccessedThroughProperty("ll_btnlinkproe")]
	private ButtonX _ll_btnlinkproe;

	[AccessedThroughProperty("LabelX5")]
	private LabelX _LabelX5;

	[AccessedThroughProperty("ll_txtcsnamelist")]
	private TextBoxX _ll_txtcsnamelist;

	[AccessedThroughProperty("ll_btngennamelist")]
	private ButtonX _ll_btngennamelist;

	[AccessedThroughProperty("LabelX6")]
	private LabelX _LabelX6;

	[AccessedThroughProperty("ll_lbnamelist")]
	private ListBox _ll_lbnamelist;

	[AccessedThroughProperty("ll_btnall")]
	private ButtonX _ll_btnall;

	[AccessedThroughProperty("ll_btnother")]
	private ButtonX _ll_btnother;

	[AccessedThroughProperty("ll_btn2lclist")]
	private ButtonX _ll_btn2lclist;

	[AccessedThroughProperty("ll_lblclist")]
	private ListBox _ll_lblclist;

	[AccessedThroughProperty("LabelX7")]
	private LabelX _LabelX7;

	[AccessedThroughProperty("ll_checkgeogen")]
	private CheckBoxX _ll_checkgeogen;

	[AccessedThroughProperty("ll_btnbatch")]
	private ButtonX _ll_btnbatch;

	[AccessedThroughProperty("ll_btnexit")]
	private ButtonX _ll_btnexit;

	[AccessedThroughProperty("ll_frmautocs")]
	private GroupPanel _ll_frmautocs;

	[AccessedThroughProperty("ll_frmdefname")]
	private GroupPanel _ll_frmdefname;

	[AccessedThroughProperty("ll_frmautokey")]
	private GroupPanel _ll_frmautokey;

	[AccessedThroughProperty("ll_checkkey5")]
	private CheckBoxX _ll_checkkey5;

	[AccessedThroughProperty("LabelX8")]
	private LabelX _LabelX8;

	[AccessedThroughProperty("ll_lbliucheng")]
	private ListBox _ll_lbliucheng;

	[AccessedThroughProperty("ll_lbemapkey1")]
	private LabelX _ll_lbemapkey1;

	[AccessedThroughProperty("GetOpenFilename")]
	private OpenFileDialog _GetOpenFilename;

	[AccessedThroughProperty("btndel")]
	private ButtonX _btndel;

	[AccessedThroughProperty("ll_txttime")]
	private IntegerInput _ll_txttime;

	[AccessedThroughProperty("luzhishuoming")]
	private ButtonX _luzhishuoming;

	private string curvalue;

	private int curi;

	private string batchpath;

	private string batchfullfile;

	private string strm1;

	private string fname;

	private string strtemp;

	public const string ll_mlc = "mlc";

	public bool ProeOK;

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

	internal virtual ListBox ll_lblccs
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lblccs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_lblccs_SelectedIndexChanged;
			if (_ll_lblccs != null)
			{
				_ll_lblccs.remove_SelectedIndexChanged(eventHandler);
			}
			_ll_lblccs = value;
			if (_ll_lblccs != null)
			{
				_ll_lblccs.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual TextBoxX ll_txtlccs
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txtlccs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txtlccs = value;
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

	internal virtual ButtonX ll_btnremoved
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnremoved;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnremoved_Click;
			if (_ll_btnremoved != null)
			{
				((Control)_ll_btnremoved).remove_Click(eventHandler);
			}
			_ll_btnremoved = value;
			if (_ll_btnremoved != null)
			{
				((Control)_ll_btnremoved).add_Click(eventHandler);
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

	internal virtual ButtonX ll_btnchecklccs
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnchecklccs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnchecklccs_Click;
			if (_ll_btnchecklccs != null)
			{
				((Control)_ll_btnchecklccs).remove_Click(eventHandler);
			}
			_ll_btnchecklccs = value;
			if (_ll_btnchecklccs != null)
			{
				((Control)_ll_btnchecklccs).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnadd2cur
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnadd2cur;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnadd2cur_Click;
			if (_ll_btnadd2cur != null)
			{
				((Control)_ll_btnadd2cur).remove_Click(eventHandler);
			}
			_ll_btnadd2cur = value;
			if (_ll_btnadd2cur != null)
			{
				((Control)_ll_btnadd2cur).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btneditcur
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btneditcur;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btneditcur_Click;
			if (_ll_btneditcur != null)
			{
				((Control)_ll_btneditcur).remove_Click(eventHandler);
			}
			_ll_btneditcur = value;
			if (_ll_btneditcur != null)
			{
				((Control)_ll_btneditcur).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btn5filecs
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btn5filecs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btn5filecs_Click;
			if (_ll_btn5filecs != null)
			{
				((Control)_ll_btn5filecs).remove_Click(eventHandler);
			}
			_ll_btn5filecs = value;
			if (_ll_btn5filecs != null)
			{
				((Control)_ll_btn5filecs).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btn5fileothercs
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btn5fileothercs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btn5fileothercs_Click;
			if (_ll_btn5fileothercs != null)
			{
				((Control)_ll_btn5fileothercs).remove_Click(eventHandler);
			}
			_ll_btn5fileothercs = value;
			if (_ll_btn5fileothercs != null)
			{
				((Control)_ll_btn5fileothercs).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btn2filecs
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btn2filecs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btn2filecs_Click;
			if (_ll_btn2filecs != null)
			{
				((Control)_ll_btn2filecs).remove_Click(eventHandler);
			}
			_ll_btn2filecs = value;
			if (_ll_btn2filecs != null)
			{
				((Control)_ll_btn2filecs).add_Click(eventHandler);
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

	internal virtual TextBoxX ll_txtmp1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txtmp1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txtmp1 = value;
		}
	}

	internal virtual ComboBoxEx ll_cbmsq
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_cbmsq;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_cbmsq = value;
		}
	}

	internal virtual ButtonX ll_btnmsq
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnmsq;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnmsq_Click;
			if (_ll_btnmsq != null)
			{
				((Control)_ll_btnmsq).remove_Click(eventHandler);
			}
			_ll_btnmsq = value;
			if (_ll_btnmsq != null)
			{
				((Control)_ll_btnmsq).add_Click(eventHandler);
			}
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

	internal virtual ButtonX ll_btn5filekey
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btn5filekey;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btn5filekey_Click;
			if (_ll_btn5filekey != null)
			{
				((Control)_ll_btn5filekey).remove_Click(eventHandler);
			}
			_ll_btn5filekey = value;
			if (_ll_btn5filekey != null)
			{
				((Control)_ll_btn5filekey).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btn5fileotherkey
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btn5fileotherkey;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btn5fileotherkey_Click;
			if (_ll_btn5fileotherkey != null)
			{
				((Control)_ll_btn5fileotherkey).remove_Click(eventHandler);
			}
			_ll_btn5fileotherkey = value;
			if (_ll_btn5fileotherkey != null)
			{
				((Control)_ll_btn5fileotherkey).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btn2filekey
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btn2filekey;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btn2filekey_Click;
			if (_ll_btn2filekey != null)
			{
				((Control)_ll_btn2filekey).remove_Click(eventHandler);
			}
			_ll_btn2filekey = value;
			if (_ll_btn2filekey != null)
			{
				((Control)_ll_btn2filekey).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnlinkproe
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnlinkproe;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnlinkproe_Click;
			if (_ll_btnlinkproe != null)
			{
				((Control)_ll_btnlinkproe).remove_Click(eventHandler);
			}
			_ll_btnlinkproe = value;
			if (_ll_btnlinkproe != null)
			{
				((Control)_ll_btnlinkproe).add_Click(eventHandler);
			}
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

	internal virtual TextBoxX ll_txtcsnamelist
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txtcsnamelist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txtcsnamelist = value;
		}
	}

	internal virtual ButtonX ll_btngennamelist
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btngennamelist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btngennamelist_Click;
			if (_ll_btngennamelist != null)
			{
				((Control)_ll_btngennamelist).remove_Click(eventHandler);
			}
			_ll_btngennamelist = value;
			if (_ll_btngennamelist != null)
			{
				((Control)_ll_btngennamelist).add_Click(eventHandler);
			}
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

	internal virtual ListBox ll_lbnamelist
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbnamelist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbnamelist = value;
		}
	}

	internal virtual ButtonX ll_btnall
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnall;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnall_Click;
			if (_ll_btnall != null)
			{
				((Control)_ll_btnall).remove_Click(eventHandler);
			}
			_ll_btnall = value;
			if (_ll_btnall != null)
			{
				((Control)_ll_btnall).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btnother
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnother;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnother_Click;
			if (_ll_btnother != null)
			{
				((Control)_ll_btnother).remove_Click(eventHandler);
			}
			_ll_btnother = value;
			if (_ll_btnother != null)
			{
				((Control)_ll_btnother).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ll_btn2lclist
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btn2lclist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btn2lclist_Click;
			if (_ll_btn2lclist != null)
			{
				((Control)_ll_btn2lclist).remove_Click(eventHandler);
			}
			_ll_btn2lclist = value;
			if (_ll_btn2lclist != null)
			{
				((Control)_ll_btn2lclist).add_Click(eventHandler);
			}
		}
	}

	internal virtual ListBox ll_lblclist
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lblclist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lblclist = value;
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

	internal virtual CheckBoxX ll_checkgeogen
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_checkgeogen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_checkgeogen = value;
		}
	}

	internal virtual ButtonX ll_btnbatch
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_btnbatch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ll_btnbatch_Click;
			if (_ll_btnbatch != null)
			{
				((Control)_ll_btnbatch).remove_Click(eventHandler);
			}
			_ll_btnbatch = value;
			if (_ll_btnbatch != null)
			{
				((Control)_ll_btnbatch).add_Click(eventHandler);
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

	internal virtual GroupPanel ll_frmautocs
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_frmautocs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_frmautocs = value;
		}
	}

	internal virtual GroupPanel ll_frmdefname
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_frmdefname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_frmdefname = value;
		}
	}

	internal virtual GroupPanel ll_frmautokey
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_frmautokey;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_frmautokey = value;
		}
	}

	internal virtual CheckBoxX ll_checkkey5
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_checkkey5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_checkkey5 = value;
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

	internal virtual LabelX ll_lbemapkey1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_lbemapkey1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_lbemapkey1 = value;
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

	internal virtual ButtonX btndel
	{
		[DebuggerNonUserCode]
		get
		{
			return _btndel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btndel_Click;
			if (_btndel != null)
			{
				((Control)_btndel).remove_Click(eventHandler);
			}
			_btndel = value;
			if (_btndel != null)
			{
				((Control)_btndel).add_Click(eventHandler);
			}
		}
	}

	internal virtual IntegerInput ll_txttime
	{
		[DebuggerNonUserCode]
		get
		{
			return _ll_txttime;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ll_txttime = value;
		}
	}

	internal virtual ButtonX luzhishuoming
	{
		[DebuggerNonUserCode]
		get
		{
			return _luzhishuoming;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = luzhishuoming_Click;
			if (_luzhishuoming != null)
			{
				((Control)_luzhishuoming).remove_Click(eventHandler);
			}
			_luzhishuoming = value;
			if (_luzhishuoming != null)
			{
				((Control)_luzhishuoming).add_Click(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	public Proezdjl()
	{
		((Form)this).add_Load((EventHandler)Proezdjl_Load);
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
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_2223: Unknown result type (might be due to invalid IL or missing references)
		//IL_222d: Expected O, but got Unknown
		//IL_2312: Unknown result type (might be due to invalid IL or missing references)
		//IL_231c: Expected O, but got Unknown
		LabelX1 = new LabelX();
		ll_lblccs = new ListBox();
		ll_txtlccs = new TextBoxX();
		ll_btnshang = new ButtonX();
		ll_btnxia = new ButtonX();
		ll_btnremoved = new ButtonX();
		ll_btnclear = new ButtonX();
		ll_btnchecklccs = new ButtonX();
		ll_btnadd2cur = new ButtonX();
		ll_btneditcur = new ButtonX();
		ll_btn5filecs = new ButtonX();
		ll_btn5fileothercs = new ButtonX();
		ll_btn2filecs = new ButtonX();
		LabelX2 = new LabelX();
		LabelX3 = new LabelX();
		ll_txtmp1 = new TextBoxX();
		ll_cbmsq = new ComboBoxEx();
		ll_btnmsq = new ButtonX();
		LabelX4 = new LabelX();
		ll_btn5filekey = new ButtonX();
		ll_btn5fileotherkey = new ButtonX();
		ll_btn2filekey = new ButtonX();
		ll_btnlinkproe = new ButtonX();
		LabelX5 = new LabelX();
		ll_txtcsnamelist = new TextBoxX();
		ll_btngennamelist = new ButtonX();
		LabelX6 = new LabelX();
		ll_lbnamelist = new ListBox();
		ll_btnall = new ButtonX();
		ll_btnother = new ButtonX();
		ll_btn2lclist = new ButtonX();
		ll_lblclist = new ListBox();
		LabelX7 = new LabelX();
		ll_checkgeogen = new CheckBoxX();
		ll_btnbatch = new ButtonX();
		ll_btnexit = new ButtonX();
		ll_frmautocs = new GroupPanel();
		ll_frmdefname = new GroupPanel();
		LabelX8 = new LabelX();
		btndel = new ButtonX();
		ll_frmautokey = new GroupPanel();
		ll_lbemapkey1 = new LabelX();
		ll_checkkey5 = new CheckBoxX();
		ll_lbliucheng = new ListBox();
		GetOpenFilename = new OpenFileDialog();
		ll_txttime = new IntegerInput();
		luzhishuoming = new ButtonX();
		((Control)ll_frmautocs).SuspendLayout();
		((Control)ll_frmdefname).SuspendLayout();
		((Control)ll_frmautokey).SuspendLayout();
		((ISupportInitialize)ll_txttime).BeginInit();
		((Control)this).SuspendLayout();
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX = LabelX1;
		Point location = new Point(8, 2);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		Size size = new Size(98, 16);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(0);
		LabelX1.set_Text("工况参数列表");
		((ListControl)ll_lblccs).set_FormattingEnabled(true);
		ll_lblccs.set_ItemHeight(12);
		ListBox obj = ll_lblccs;
		location = new Point(8, 21);
		((Control)obj).set_Location(location);
		((Control)ll_lblccs).set_Name("ll_lblccs");
		ListBox obj2 = ll_lblccs;
		size = new Size(366, 160);
		((Control)obj2).set_Size(size);
		((Control)ll_lblccs).set_TabIndex(1);
		((TextBoxBase)ll_txtlccs).set_BackColor(SystemColors.ControlDarkDark);
		ll_txtlccs.get_Border().set_Class("TextBoxBorder");
		ll_txtlccs.get_Border().set_CornerType((eCornerType)1);
		((TextBoxBase)ll_txtlccs).set_ForeColor(Color.White);
		TextBoxX obj3 = ll_txtlccs;
		location = new Point(8, 187);
		((Control)obj3).set_Location(location);
		((Control)ll_txtlccs).set_Name("ll_txtlccs");
		TextBoxX obj4 = ll_txtlccs;
		size = new Size(366, 21);
		((Control)obj4).set_Size(size);
		((Control)ll_txtlccs).set_TabIndex(2);
		((Control)ll_btnshang).set_AccessibleRole((AccessibleRole)43);
		ll_btnshang.set_ColorTable((eButtonColor)3);
		ButtonX obj5 = ll_btnshang;
		location = new Point(380, 21);
		((Control)obj5).set_Location(location);
		((Control)ll_btnshang).set_Name("ll_btnshang");
		ButtonX obj6 = ll_btnshang;
		size = new Size(54, 23);
		((Control)obj6).set_Size(size);
		((PopupItemControl)ll_btnshang).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnshang).set_TabIndex(3);
		ll_btnshang.set_Text("上移");
		((Control)ll_btnxia).set_AccessibleRole((AccessibleRole)43);
		ll_btnxia.set_ColorTable((eButtonColor)3);
		ButtonX obj7 = ll_btnxia;
		location = new Point(434, 21);
		((Control)obj7).set_Location(location);
		((Control)ll_btnxia).set_Name("ll_btnxia");
		ButtonX obj8 = ll_btnxia;
		size = new Size(54, 23);
		((Control)obj8).set_Size(size);
		((PopupItemControl)ll_btnxia).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnxia).set_TabIndex(3);
		ll_btnxia.set_Text("下移");
		((Control)ll_btnremoved).set_AccessibleRole((AccessibleRole)43);
		ll_btnremoved.set_ColorTable((eButtonColor)3);
		ButtonX obj9 = ll_btnremoved;
		location = new Point(380, 50);
		((Control)obj9).set_Location(location);
		((Control)ll_btnremoved).set_Name("ll_btnremoved");
		ButtonX obj10 = ll_btnremoved;
		size = new Size(108, 23);
		((Control)obj10).set_Size(size);
		((PopupItemControl)ll_btnremoved).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnremoved).set_TabIndex(3);
		ll_btnremoved.set_Text("移除当前");
		((Control)ll_btnclear).set_AccessibleRole((AccessibleRole)43);
		ll_btnclear.set_ColorTable((eButtonColor)3);
		ButtonX obj11 = ll_btnclear;
		location = new Point(380, 79);
		((Control)obj11).set_Location(location);
		((Control)ll_btnclear).set_Name("ll_btnclear");
		ButtonX obj12 = ll_btnclear;
		size = new Size(108, 23);
		((Control)obj12).set_Size(size);
		((PopupItemControl)ll_btnclear).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnclear).set_TabIndex(3);
		ll_btnclear.set_Text("清空");
		((Control)ll_btnchecklccs).set_AccessibleRole((AccessibleRole)43);
		ll_btnchecklccs.set_ColorTable((eButtonColor)3);
		ButtonX obj13 = ll_btnchecklccs;
		location = new Point(380, 108);
		((Control)obj13).set_Location(location);
		((Control)ll_btnchecklccs).set_Name("ll_btnchecklccs");
		ButtonX obj14 = ll_btnchecklccs;
		size = new Size(108, 23);
		((Control)obj14).set_Size(size);
		((PopupItemControl)ll_btnchecklccs).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnchecklccs).set_TabIndex(3);
		ll_btnchecklccs.set_Text("格式检查");
		((Control)ll_btnadd2cur).set_AccessibleRole((AccessibleRole)43);
		ll_btnadd2cur.set_ColorTable((eButtonColor)3);
		ButtonX obj15 = ll_btnadd2cur;
		location = new Point(380, 158);
		((Control)obj15).set_Location(location);
		((Control)ll_btnadd2cur).set_Name("ll_btnadd2cur");
		ButtonX obj16 = ll_btnadd2cur;
		size = new Size(108, 23);
		((Control)obj16).set_Size(size);
		((PopupItemControl)ll_btnadd2cur).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnadd2cur).set_TabIndex(3);
		ll_btnadd2cur.set_Text("追加");
		((Control)ll_btneditcur).set_AccessibleRole((AccessibleRole)43);
		ll_btneditcur.set_ColorTable((eButtonColor)3);
		ButtonX obj17 = ll_btneditcur;
		location = new Point(380, 187);
		((Control)obj17).set_Location(location);
		((Control)ll_btneditcur).set_Name("ll_btneditcur");
		ButtonX obj18 = ll_btneditcur;
		size = new Size(108, 23);
		((Control)obj18).set_Size(size);
		((PopupItemControl)ll_btneditcur).set_Style((eDotNetBarStyle)7);
		((Control)ll_btneditcur).set_TabIndex(3);
		ll_btneditcur.set_Text("编辑当前");
		((Control)ll_btn5filecs).set_AccessibleRole((AccessibleRole)43);
		ll_btn5filecs.set_ColorTable((eButtonColor)3);
		ButtonX obj19 = ll_btn5filecs;
		location = new Point(8, 214);
		((Control)obj19).set_Location(location);
		((Control)ll_btn5filecs).set_Name("ll_btn5filecs");
		ButtonX obj20 = ll_btn5filecs;
		size = new Size(108, 23);
		((Control)obj20).set_Size(size);
		((PopupItemControl)ll_btn5filecs).set_Style((eDotNetBarStyle)7);
		((Control)ll_btn5filecs).set_TabIndex(3);
		ll_btn5filecs.set_Text("来自默认文件");
		((Control)ll_btn5fileothercs).set_AccessibleRole((AccessibleRole)43);
		ll_btn5fileothercs.set_ColorTable((eButtonColor)3);
		ButtonX obj21 = ll_btn5fileothercs;
		location = new Point(122, 214);
		((Control)obj21).set_Location(location);
		((Control)ll_btn5fileothercs).set_Name("ll_btn5fileothercs");
		ButtonX obj22 = ll_btn5fileothercs;
		size = new Size(108, 23);
		((Control)obj22).set_Size(size);
		((PopupItemControl)ll_btn5fileothercs).set_Style((eDotNetBarStyle)7);
		((Control)ll_btn5fileothercs).set_TabIndex(3);
		ll_btn5fileothercs.set_Text("来自指定文件");
		((Control)ll_btn2filecs).set_AccessibleRole((AccessibleRole)43);
		ll_btn2filecs.set_ColorTable((eButtonColor)3);
		ButtonX obj23 = ll_btn2filecs;
		location = new Point(236, 214);
		((Control)obj23).set_Location(location);
		((Control)ll_btn2filecs).set_Name("ll_btn2filecs");
		ButtonX obj24 = ll_btn2filecs;
		size = new Size(108, 23);
		((Control)obj24).set_Size(size);
		((PopupItemControl)ll_btn2filecs).set_Style((eDotNetBarStyle)7);
		((Control)ll_btn2filecs).set_TabIndex(3);
		ll_btn2filecs.set_Text("保存至默认");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX3 = LabelX2;
		location = new Point(8, 3);
		((Control)labelX3).set_Location(location);
		((Control)LabelX2).set_Name("LabelX2");
		LabelX labelX4 = LabelX2;
		size = new Size(148, 14);
		((Control)labelX4).set_Size(size);
		((Control)LabelX2).set_TabIndex(0);
		LabelX2.set_Text("批处理过程映射键序列");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX5 = LabelX3;
		location = new Point(8, 19);
		((Control)labelX5).set_Location(location);
		((Control)LabelX3).set_Name("LabelX3");
		LabelX labelX6 = LabelX3;
		size = new Size(86, 14);
		((Control)labelX6).set_Size(size);
		((Control)LabelX3).set_TabIndex(0);
		LabelX3.set_Text("当前求解方法:");
		ll_txtmp1.get_Border().set_Class("TextBoxBorder");
		ll_txtmp1.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj25 = ll_txtmp1;
		location = new Point(8, 38);
		((Control)obj25).set_Location(location);
		((TextBox)ll_txtmp1).set_Multiline(true);
		((Control)ll_txtmp1).set_Name("ll_txtmp1");
		((TextBoxBase)ll_txtmp1).set_ReadOnly(true);
		TextBoxX obj26 = ll_txtmp1;
		size = new Size(366, 99);
		((Control)obj26).set_Size(size);
		((Control)ll_txtmp1).set_TabIndex(4);
		((ListControl)ll_cbmsq).set_DisplayMember("Text");
		((ComboBox)ll_cbmsq).set_DrawMode((DrawMode)1);
		((ComboBox)ll_cbmsq).set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)ll_cbmsq).set_FormattingEnabled(true);
		((ComboBox)ll_cbmsq).set_ItemHeight(15);
		ComboBoxEx obj27 = ll_cbmsq;
		location = new Point(380, 38);
		((Control)obj27).set_Location(location);
		((Control)ll_cbmsq).set_Name("ll_cbmsq");
		ComboBoxEx obj28 = ll_cbmsq;
		size = new Size(108, 21);
		((Control)obj28).set_Size(size);
		ll_cbmsq.set_Style((eDotNetBarStyle)7);
		((Control)ll_cbmsq).set_TabIndex(5);
		((Control)ll_btnmsq).set_AccessibleRole((AccessibleRole)43);
		ll_btnmsq.set_ColorTable((eButtonColor)3);
		ButtonX obj29 = ll_btnmsq;
		location = new Point(380, 65);
		((Control)obj29).set_Location(location);
		((Control)ll_btnmsq).set_Name("ll_btnmsq");
		ButtonX obj30 = ll_btnmsq;
		size = new Size(108, 23);
		((Control)obj30).set_Size(size);
		((PopupItemControl)ll_btnmsq).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnmsq).set_TabIndex(3);
		ll_btnmsq.set_Text("更新求解方法");
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX4.set_ImagePosition((eImagePosition)1);
		LabelX labelX7 = LabelX4;
		location = new Point(8, 143);
		((Control)labelX7).set_Location(location);
		((Control)LabelX4).set_Name("LabelX4");
		LabelX labelX8 = LabelX4;
		size = new Size(480, 27);
		((Control)labelX8).set_Size(size);
		((Control)LabelX4).set_TabIndex(0);
		LabelX4.set_Text("映射键序列说明：打开研究对话框/定义研究名称/设置计算选项/batch过程操作流/清空研究列表/关闭研究对话框");
		LabelX4.set_TextLineAlignment((StringAlignment)0);
		LabelX4.set_WordWrap(true);
		((Control)ll_btn5filekey).set_AccessibleRole((AccessibleRole)43);
		ll_btn5filekey.set_ColorTable((eButtonColor)3);
		ButtonX obj31 = ll_btn5filekey;
		location = new Point(34, 174);
		((Control)obj31).set_Location(location);
		((Control)ll_btn5filekey).set_Name("ll_btn5filekey");
		ButtonX obj32 = ll_btn5filekey;
		size = new Size(108, 23);
		((Control)obj32).set_Size(size);
		((PopupItemControl)ll_btn5filekey).set_Style((eDotNetBarStyle)7);
		((Control)ll_btn5filekey).set_TabIndex(3);
		ll_btn5filekey.set_Text("来自默认文件");
		((Control)ll_btn5fileotherkey).set_AccessibleRole((AccessibleRole)43);
		ll_btn5fileotherkey.set_ColorTable((eButtonColor)3);
		ButtonX obj33 = ll_btn5fileotherkey;
		location = new Point(148, 174);
		((Control)obj33).set_Location(location);
		((Control)ll_btn5fileotherkey).set_Name("ll_btn5fileotherkey");
		ButtonX obj34 = ll_btn5fileotherkey;
		size = new Size(108, 23);
		((Control)obj34).set_Size(size);
		((PopupItemControl)ll_btn5fileotherkey).set_Style((eDotNetBarStyle)7);
		((Control)ll_btn5fileotherkey).set_TabIndex(3);
		ll_btn5fileotherkey.set_Text("来自指定文件");
		((Control)ll_btn2filekey).set_AccessibleRole((AccessibleRole)43);
		ll_btn2filekey.set_ColorTable((eButtonColor)3);
		ButtonX obj35 = ll_btn2filekey;
		location = new Point(262, 174);
		((Control)obj35).set_Location(location);
		((Control)ll_btn2filekey).set_Name("ll_btn2filekey");
		ButtonX obj36 = ll_btn2filekey;
		size = new Size(108, 23);
		((Control)obj36).set_Size(size);
		((PopupItemControl)ll_btn2filekey).set_Style((eDotNetBarStyle)7);
		((Control)ll_btn2filekey).set_TabIndex(3);
		ll_btn2filekey.set_Text("保存至默认");
		((Control)ll_btnlinkproe).set_AccessibleRole((AccessibleRole)43);
		ll_btnlinkproe.set_ColorTable((eButtonColor)3);
		ButtonX obj37 = ll_btnlinkproe;
		location = new Point(160, 465);
		((Control)obj37).set_Location(location);
		((Control)ll_btnlinkproe).set_Name("ll_btnlinkproe");
		ButtonX obj38 = ll_btnlinkproe;
		size = new Size(222, 28);
		((Control)obj38).set_Size(size);
		((PopupItemControl)ll_btnlinkproe).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnlinkproe).set_TabIndex(3);
		ll_btnlinkproe.set_Text("连接至当前proe.. .");
		((BaseItemControl)LabelX5).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX5).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX9 = LabelX5;
		location = new Point(10, 3);
		((Control)labelX9).set_Location(location);
		((Control)LabelX5).set_Name("LabelX5");
		LabelX labelX10 = LabelX5;
		size = new Size(89, 16);
		((Control)labelX10).set_Size(size);
		((Control)LabelX5).set_TabIndex(0);
		LabelX5.set_Text("分析名称定义");
		((TextBoxBase)ll_txtcsnamelist).set_BackColor(Color.White);
		ll_txtcsnamelist.get_Border().set_Class("TextBoxBorder");
		ll_txtcsnamelist.get_Border().set_CornerType((eCornerType)1);
		((TextBoxBase)ll_txtcsnamelist).set_ForeColor(Color.Black);
		TextBoxX obj39 = ll_txtcsnamelist;
		location = new Point(10, 21);
		((Control)obj39).set_Location(location);
		((Control)ll_txtcsnamelist).set_Name("ll_txtcsnamelist");
		TextBoxX obj40 = ll_txtcsnamelist;
		size = new Size(247, 21);
		((Control)obj40).set_Size(size);
		((Control)ll_txtcsnamelist).set_TabIndex(6);
		((Control)ll_btngennamelist).set_AccessibleRole((AccessibleRole)43);
		ll_btngennamelist.set_ColorTable((eButtonColor)3);
		ButtonX obj41 = ll_btngennamelist;
		location = new Point(263, 21);
		((Control)obj41).set_Location(location);
		((Control)ll_btngennamelist).set_Name("ll_btngennamelist");
		ButtonX obj42 = ll_btngennamelist;
		size = new Size(108, 23);
		((Control)obj42).set_Size(size);
		((PopupItemControl)ll_btngennamelist).set_Style((eDotNetBarStyle)7);
		((Control)ll_btngennamelist).set_TabIndex(3);
		ll_btngennamelist.set_Text("生成名称列表");
		((BaseItemControl)LabelX6).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX6).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX6.set_ImagePosition((eImagePosition)1);
		LabelX labelX11 = LabelX6;
		location = new Point(10, 50);
		((Control)labelX11).set_Location(location);
		((Control)LabelX6).set_Name("LabelX6");
		LabelX labelX12 = LabelX6;
		size = new Size(361, 33);
		((Control)labelX12).set_Size(size);
		((Control)LabelX6).set_TabIndex(0);
		LabelX6.set_Text("请指定要体现的参数名称列表,用非汉语模式下的逗号分割;如果无,则名称默认为A_工况序号.");
		LabelX6.set_TextLineAlignment((StringAlignment)0);
		LabelX6.set_WordWrap(true);
		((ListControl)ll_lbnamelist).set_FormattingEnabled(true);
		ll_lbnamelist.set_ItemHeight(12);
		ListBox obj43 = ll_lbnamelist;
		location = new Point(8, 107);
		((Control)obj43).set_Location(location);
		((Control)ll_lbnamelist).set_Name("ll_lbnamelist");
		ll_lbnamelist.set_SelectionMode((SelectionMode)2);
		ListBox obj44 = ll_lbnamelist;
		size = new Size(149, 208);
		((Control)obj44).set_Size(size);
		((Control)ll_lbnamelist).set_TabIndex(1);
		((Control)ll_btnall).set_AccessibleRole((AccessibleRole)43);
		ll_btnall.set_ColorTable((eButtonColor)3);
		ButtonX obj45 = ll_btnall;
		location = new Point(163, 136);
		((Control)obj45).set_Location(location);
		((Control)ll_btnall).set_Name("ll_btnall");
		ButtonX obj46 = ll_btnall;
		size = new Size(51, 23);
		((Control)obj46).set_Size(size);
		((PopupItemControl)ll_btnall).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnall).set_TabIndex(3);
		ll_btnall.set_Text("全选");
		((Control)ll_btnother).set_AccessibleRole((AccessibleRole)43);
		ll_btnother.set_ColorTable((eButtonColor)3);
		ButtonX obj47 = ll_btnother;
		location = new Point(163, 165);
		((Control)obj47).set_Location(location);
		((Control)ll_btnother).set_Name("ll_btnother");
		ButtonX obj48 = ll_btnother;
		size = new Size(51, 23);
		((Control)obj48).set_Size(size);
		((PopupItemControl)ll_btnother).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnother).set_TabIndex(3);
		ll_btnother.set_Text("反选");
		((Control)ll_btn2lclist).set_AccessibleRole((AccessibleRole)43);
		ll_btn2lclist.set_ColorTable((eButtonColor)3);
		ButtonX obj49 = ll_btn2lclist;
		location = new Point(163, 194);
		((Control)obj49).set_Location(location);
		((Control)ll_btn2lclist).set_Name("ll_btn2lclist");
		ButtonX obj50 = ll_btn2lclist;
		size = new Size(51, 23);
		((Control)obj50).set_Size(size);
		((PopupItemControl)ll_btn2lclist).set_Style((eDotNetBarStyle)7);
		((Control)ll_btn2lclist).set_TabIndex(3);
		ll_btn2lclist.set_Text(">>");
		((ListControl)ll_lblclist).set_FormattingEnabled(true);
		ll_lblclist.set_ItemHeight(12);
		ListBox obj51 = ll_lblclist;
		location = new Point(220, 105);
		((Control)obj51).set_Location(location);
		((Control)ll_lblclist).set_Name("ll_lblclist");
		ll_lblclist.set_SelectionMode((SelectionMode)2);
		ListBox obj52 = ll_lblclist;
		size = new Size(149, 208);
		((Control)obj52).set_Size(size);
		((Control)ll_lblclist).set_TabIndex(1);
		((BaseItemControl)LabelX7).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX7).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX13 = LabelX7;
		location = new Point(518, 329);
		((Control)labelX13).set_Location(location);
		((Control)LabelX7).set_Name("LabelX7");
		LabelX labelX14 = LabelX7;
		size = new Size(172, 23);
		((Control)labelX14).set_Size(size);
		((Control)LabelX7).set_TabIndex(0);
		LabelX7.set_Text("模型再生延时(秒)默认为10s");
		((BaseItemControl)ll_checkgeogen).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_checkgeogen).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((BaseItemControl)ll_checkgeogen).set_FocusCuesEnabled(false);
		CheckBoxX obj53 = ll_checkgeogen;
		location = new Point(520, 341);
		((Control)obj53).set_Location(location);
		((Control)ll_checkgeogen).set_Name("ll_checkgeogen");
		CheckBoxX obj54 = ll_checkgeogen;
		size = new Size(379, 43);
		((Control)obj54).set_Size(size);
		((BaseItemControl)ll_checkgeogen).set_Style((eDotNetBarStyle)7);
		((Control)ll_checkgeogen).set_TabIndex(7);
		ll_checkgeogen.set_Text("几何强力再生(更新几何时可能需要,强烈建议不要轻易使用,该选项在模型复杂时极可能导致再生失败.)");
		((Control)ll_checkgeogen).set_Visible(false);
		((Control)ll_btnbatch).set_AccessibleRole((AccessibleRole)43);
		ll_btnbatch.set_ColorTable((eButtonColor)3);
		ButtonX obj55 = ll_btnbatch;
		location = new Point(531, 465);
		((Control)obj55).set_Location(location);
		((Control)ll_btnbatch).set_Name("ll_btnbatch");
		ButtonX obj56 = ll_btnbatch;
		size = new Size(149, 28);
		((Control)obj56).set_Size(size);
		((PopupItemControl)ll_btnbatch).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnbatch).set_TabIndex(3);
		ll_btnbatch.set_Text("开始批量生成计算文件");
		((Control)ll_btnexit).set_AccessibleRole((AccessibleRole)43);
		ll_btnexit.set_ColorTable((eButtonColor)3);
		ll_btnexit.set_DialogResult((DialogResult)2);
		ButtonX obj57 = ll_btnexit;
		location = new Point(753, 465);
		((Control)obj57).set_Location(location);
		((Control)ll_btnexit).set_Name("ll_btnexit");
		ButtonX obj58 = ll_btnexit;
		size = new Size(149, 28);
		((Control)obj58).set_Size(size);
		((PopupItemControl)ll_btnexit).set_Style((eDotNetBarStyle)7);
		((Control)ll_btnexit).set_TabIndex(3);
		ll_btnexit.set_Text("关闭");
		((PanelControl)ll_frmautocs).set_CanvasColor(SystemColors.Control);
		((PanelControl)ll_frmautocs).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)ll_frmautocs).get_Controls().Add((Control)(object)ll_lblccs);
		((Control)ll_frmautocs).get_Controls().Add((Control)(object)LabelX1);
		((Control)ll_frmautocs).get_Controls().Add((Control)(object)ll_txtlccs);
		((Control)ll_frmautocs).get_Controls().Add((Control)(object)ll_btnshang);
		((Control)ll_frmautocs).get_Controls().Add((Control)(object)ll_btnremoved);
		((Control)ll_frmautocs).get_Controls().Add((Control)(object)ll_btnclear);
		((Control)ll_frmautocs).get_Controls().Add((Control)(object)ll_btnchecklccs);
		((Control)ll_frmautocs).get_Controls().Add((Control)(object)ll_btnadd2cur);
		((Control)ll_frmautocs).get_Controls().Add((Control)(object)ll_btneditcur);
		((Control)ll_frmautocs).get_Controls().Add((Control)(object)ll_btnxia);
		((Control)ll_frmautocs).get_Controls().Add((Control)(object)ll_btn5filecs);
		((Control)ll_frmautocs).get_Controls().Add((Control)(object)ll_btn5fileothercs);
		((Control)ll_frmautocs).get_Controls().Add((Control)(object)ll_btn2filecs);
		GroupPanel obj59 = ll_frmautocs;
		location = new Point(5, 1);
		((Control)obj59).set_Location(location);
		((Control)ll_frmautocs).set_Name("ll_frmautocs");
		GroupPanel obj60 = ll_frmautocs;
		size = new Size(498, 247);
		((Control)obj60).set_Size(size);
		((PanelControl)ll_frmautocs).get_Style().set_BackColor2SchemePart((eColorSchemePart)52);
		((PanelControl)ll_frmautocs).get_Style().set_BackColorGradientAngle(90);
		((PanelControl)ll_frmautocs).get_Style().set_BackColorSchemePart((eColorSchemePart)51);
		((PanelControl)ll_frmautocs).get_Style().set_BorderBottom((eStyleBorderType)1);
		((PanelControl)ll_frmautocs).get_Style().set_BorderBottomWidth(1);
		((PanelControl)ll_frmautocs).get_Style().set_BorderColorSchemePart((eColorSchemePart)53);
		((PanelControl)ll_frmautocs).get_Style().set_BorderLeft((eStyleBorderType)1);
		((PanelControl)ll_frmautocs).get_Style().set_BorderLeftWidth(1);
		((PanelControl)ll_frmautocs).get_Style().set_BorderRight((eStyleBorderType)1);
		((PanelControl)ll_frmautocs).get_Style().set_BorderRightWidth(1);
		((PanelControl)ll_frmautocs).get_Style().set_BorderTop((eStyleBorderType)1);
		((PanelControl)ll_frmautocs).get_Style().set_BorderTopWidth(1);
		((PanelControl)ll_frmautocs).get_Style().set_Class("");
		((PanelControl)ll_frmautocs).get_Style().set_CornerDiameter(4);
		((PanelControl)ll_frmautocs).get_Style().set_CornerType((eCornerType)2);
		((PanelControl)ll_frmautocs).get_Style().set_TextAlignment((eStyleTextAlignment)1);
		((PanelControl)ll_frmautocs).get_Style().set_TextColorSchemePart((eColorSchemePart)54);
		((PanelControl)ll_frmautocs).get_Style().set_TextLineAlignment((eStyleTextAlignment)0);
		((PanelControl)ll_frmautocs).get_StyleMouseDown().set_Class("");
		((PanelControl)ll_frmautocs).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)ll_frmautocs).get_StyleMouseOver().set_Class("");
		((PanelControl)ll_frmautocs).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)ll_frmautocs).set_TabIndex(8);
		((PanelControl)ll_frmdefname).set_CanvasColor(SystemColors.Control);
		((PanelControl)ll_frmdefname).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)ll_frmdefname).get_Controls().Add((Control)(object)LabelX8);
		((Control)ll_frmdefname).get_Controls().Add((Control)(object)LabelX5);
		((Control)ll_frmdefname).get_Controls().Add((Control)(object)LabelX6);
		((Control)ll_frmdefname).get_Controls().Add((Control)(object)ll_lbnamelist);
		((Control)ll_frmdefname).get_Controls().Add((Control)(object)ll_txtcsnamelist);
		((Control)ll_frmdefname).get_Controls().Add((Control)(object)ll_lblclist);
		((Control)ll_frmdefname).get_Controls().Add((Control)(object)ll_btnall);
		((Control)ll_frmdefname).get_Controls().Add((Control)(object)ll_btngennamelist);
		((Control)ll_frmdefname).get_Controls().Add((Control)(object)btndel);
		((Control)ll_frmdefname).get_Controls().Add((Control)(object)ll_btn2lclist);
		((Control)ll_frmdefname).get_Controls().Add((Control)(object)ll_btnother);
		GroupPanel obj61 = ll_frmdefname;
		location = new Point(518, 1);
		((Control)obj61).set_Location(location);
		((Control)ll_frmdefname).set_Name("ll_frmdefname");
		GroupPanel obj62 = ll_frmdefname;
		size = new Size(381, 325);
		((Control)obj62).set_Size(size);
		((PanelControl)ll_frmdefname).get_Style().set_BackColor2SchemePart((eColorSchemePart)52);
		((PanelControl)ll_frmdefname).get_Style().set_BackColorGradientAngle(90);
		((PanelControl)ll_frmdefname).get_Style().set_BackColorSchemePart((eColorSchemePart)51);
		((PanelControl)ll_frmdefname).get_Style().set_BorderBottom((eStyleBorderType)1);
		((PanelControl)ll_frmdefname).get_Style().set_BorderBottomWidth(1);
		((PanelControl)ll_frmdefname).get_Style().set_BorderColorSchemePart((eColorSchemePart)53);
		((PanelControl)ll_frmdefname).get_Style().set_BorderLeft((eStyleBorderType)1);
		((PanelControl)ll_frmdefname).get_Style().set_BorderLeftWidth(1);
		((PanelControl)ll_frmdefname).get_Style().set_BorderRight((eStyleBorderType)1);
		((PanelControl)ll_frmdefname).get_Style().set_BorderRightWidth(1);
		((PanelControl)ll_frmdefname).get_Style().set_BorderTop((eStyleBorderType)1);
		((PanelControl)ll_frmdefname).get_Style().set_BorderTopWidth(1);
		((PanelControl)ll_frmdefname).get_Style().set_Class("");
		((PanelControl)ll_frmdefname).get_Style().set_CornerDiameter(4);
		((PanelControl)ll_frmdefname).get_Style().set_CornerType((eCornerType)2);
		((PanelControl)ll_frmdefname).get_Style().set_TextAlignment((eStyleTextAlignment)1);
		((PanelControl)ll_frmdefname).get_Style().set_TextColorSchemePart((eColorSchemePart)54);
		((PanelControl)ll_frmdefname).get_Style().set_TextLineAlignment((eStyleTextAlignment)0);
		((PanelControl)ll_frmdefname).get_StyleMouseDown().set_Class("");
		((PanelControl)ll_frmdefname).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)ll_frmdefname).get_StyleMouseOver().set_Class("");
		((PanelControl)ll_frmdefname).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)ll_frmdefname).set_TabIndex(9);
		((BaseItemControl)LabelX8).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX8).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX labelX15 = LabelX8;
		location = new Point(220, 86);
		((Control)labelX15).set_Location(location);
		((Control)LabelX8).set_Name("LabelX8");
		LabelX labelX16 = LabelX8;
		size = new Size(111, 16);
		((Control)labelX16).set_Size(size);
		((Control)LabelX8).set_TabIndex(0);
		LabelX8.set_Text("批量分析工况列表");
		((Control)btndel).set_AccessibleRole((AccessibleRole)43);
		btndel.set_ColorTable((eButtonColor)3);
		ButtonX obj63 = btndel;
		location = new Point(163, 221);
		((Control)obj63).set_Location(location);
		((Control)btndel).set_Name("btndel");
		ButtonX obj64 = btndel;
		size = new Size(51, 23);
		((Control)obj64).set_Size(size);
		((PopupItemControl)btndel).set_Style((eDotNetBarStyle)7);
		((Control)btndel).set_TabIndex(3);
		btndel.set_Text("<<");
		((PanelControl)ll_frmautokey).set_CanvasColor(SystemColors.Control);
		((PanelControl)ll_frmautokey).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)ll_frmautokey).get_Controls().Add((Control)(object)LabelX2);
		((Control)ll_frmautokey).get_Controls().Add((Control)(object)ll_lbemapkey1);
		((Control)ll_frmautokey).get_Controls().Add((Control)(object)LabelX3);
		((Control)ll_frmautokey).get_Controls().Add((Control)(object)LabelX4);
		((Control)ll_frmautokey).get_Controls().Add((Control)(object)luzhishuoming);
		((Control)ll_frmautokey).get_Controls().Add((Control)(object)ll_btnmsq);
		((Control)ll_frmautokey).get_Controls().Add((Control)(object)ll_btn5filekey);
		((Control)ll_frmautokey).get_Controls().Add((Control)(object)ll_cbmsq);
		((Control)ll_frmautokey).get_Controls().Add((Control)(object)ll_btn5fileotherkey);
		((Control)ll_frmautokey).get_Controls().Add((Control)(object)ll_txtmp1);
		((Control)ll_frmautokey).get_Controls().Add((Control)(object)ll_btn2filekey);
		GroupPanel obj65 = ll_frmautokey;
		location = new Point(5, 251);
		((Control)obj65).set_Location(location);
		((Control)ll_frmautokey).set_Name("ll_frmautokey");
		GroupPanel obj66 = ll_frmautokey;
		size = new Size(498, 208);
		((Control)obj66).set_Size(size);
		((PanelControl)ll_frmautokey).get_Style().set_BackColor2SchemePart((eColorSchemePart)52);
		((PanelControl)ll_frmautokey).get_Style().set_BackColorGradientAngle(90);
		((PanelControl)ll_frmautokey).get_Style().set_BackColorSchemePart((eColorSchemePart)51);
		((PanelControl)ll_frmautokey).get_Style().set_BorderBottom((eStyleBorderType)1);
		((PanelControl)ll_frmautokey).get_Style().set_BorderBottomWidth(1);
		((PanelControl)ll_frmautokey).get_Style().set_BorderColorSchemePart((eColorSchemePart)53);
		((PanelControl)ll_frmautokey).get_Style().set_BorderLeft((eStyleBorderType)1);
		((PanelControl)ll_frmautokey).get_Style().set_BorderLeftWidth(1);
		((PanelControl)ll_frmautokey).get_Style().set_BorderRight((eStyleBorderType)1);
		((PanelControl)ll_frmautokey).get_Style().set_BorderRightWidth(1);
		((PanelControl)ll_frmautokey).get_Style().set_BorderTop((eStyleBorderType)1);
		((PanelControl)ll_frmautokey).get_Style().set_BorderTopWidth(1);
		((PanelControl)ll_frmautokey).get_Style().set_Class("");
		((PanelControl)ll_frmautokey).get_Style().set_CornerDiameter(4);
		((PanelControl)ll_frmautokey).get_Style().set_CornerType((eCornerType)2);
		((PanelControl)ll_frmautokey).get_Style().set_TextAlignment((eStyleTextAlignment)1);
		((PanelControl)ll_frmautokey).get_Style().set_TextColorSchemePart((eColorSchemePart)54);
		((PanelControl)ll_frmautokey).get_Style().set_TextLineAlignment((eStyleTextAlignment)0);
		((PanelControl)ll_frmautokey).get_StyleMouseDown().set_Class("");
		((PanelControl)ll_frmautokey).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)ll_frmautokey).get_StyleMouseOver().set_Class("");
		((PanelControl)ll_frmautokey).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)ll_frmautokey).set_TabIndex(10);
		((BaseItemControl)ll_lbemapkey1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_lbemapkey1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		LabelX obj67 = ll_lbemapkey1;
		location = new Point(95, 19);
		((Control)obj67).set_Location(location);
		((Control)ll_lbemapkey1).set_Name("ll_lbemapkey1");
		LabelX obj68 = ll_lbemapkey1;
		size = new Size(56, 14);
		((Control)obj68).set_Size(size);
		((Control)ll_lbemapkey1).set_TabIndex(0);
		((BaseItemControl)ll_checkkey5).get_BackgroundStyle().set_Class("");
		((BaseItemControl)ll_checkkey5).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((BaseItemControl)ll_checkkey5).set_FocusCuesEnabled(false);
		CheckBoxX obj69 = ll_checkkey5;
		location = new Point(520, 351);
		((Control)obj69).set_Location(location);
		((Control)ll_checkkey5).set_Name("ll_checkkey5");
		((Control)ll_checkkey5).set_RightToLeft((RightToLeft)0);
		CheckBoxX obj70 = ll_checkkey5;
		size = new Size(379, 108);
		((Control)obj70).set_Size(size);
		((BaseItemControl)ll_checkkey5).set_Style((eDotNetBarStyle)7);
		((Control)ll_checkkey5).set_TabIndex(7);
		ll_checkkey5.set_Text("映射键补充(使用默认的4.0版本中录制的带有接触定义的映射键,在5.0版本中由于界面的更新,可能需要补充2句才可以使用,如果不理解该选项,请直接在当前版本中录制,然后使用即可。)");
		((Control)ll_checkkey5).set_Visible(false);
		((ListControl)ll_lbliucheng).set_FormattingEnabled(true);
		ll_lbliucheng.set_ItemHeight(12);
		ListBox obj71 = ll_lbliucheng;
		location = new Point(5, 499);
		((Control)obj71).set_Location(location);
		((Control)ll_lbliucheng).set_Name("ll_lbliucheng");
		ListBox obj72 = ll_lbliucheng;
		size = new Size(894, 112);
		((Control)obj72).set_Size(size);
		((Control)ll_lbliucheng).set_TabIndex(1);
		((FileDialog)GetOpenFilename).set_Filter("参数列表文本|*.txt");
		((VisualControlBase)ll_txttime).get_BackgroundStyle().set_Class("DateTimeInputBackground");
		((VisualControlBase)ll_txttime).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((NumericInputBase)ll_txttime).get_ButtonFreeText().set_Shortcut((eShortcut)113);
		IntegerInput obj73 = ll_txttime;
		location = new Point(684, 329);
		((Control)obj73).set_Location(location);
		ll_txttime.set_MaxValue(100);
		ll_txttime.set_MinValue(1);
		((Control)ll_txttime).set_Name("ll_txttime");
		((NumericInputBase)ll_txttime).set_ShowUpDown(true);
		IntegerInput obj74 = ll_txttime;
		size = new Size(80, 21);
		((Control)obj74).set_Size(size);
		((Control)ll_txttime).set_TabIndex(11);
		ll_txttime.set_Value(10);
		((Control)luzhishuoming).set_AccessibleRole((AccessibleRole)43);
		luzhishuoming.set_ColorTable((eButtonColor)3);
		ButtonX obj75 = luzhishuoming;
		location = new Point(380, 94);
		((Control)obj75).set_Location(location);
		((Control)luzhishuoming).set_Name("luzhishuoming");
		ButtonX obj76 = luzhishuoming;
		size = new Size(108, 23);
		((Control)obj76).set_Size(size);
		((PopupItemControl)luzhishuoming).set_Style((eDotNetBarStyle)7);
		((Control)luzhishuoming).set_TabIndex(3);
		luzhishuoming.set_Text("查看录制说明");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_CancelButton((IButtonControl)(object)ll_btnexit);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(904, 615);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ll_txttime);
		((Control)this).get_Controls().Add((Control)(object)LabelX7);
		((Control)this).get_Controls().Add((Control)(object)ll_checkgeogen);
		((Control)this).get_Controls().Add((Control)(object)ll_frmautokey);
		((Control)this).get_Controls().Add((Control)(object)ll_lbliucheng);
		((Control)this).get_Controls().Add((Control)(object)ll_frmdefname);
		((Control)this).get_Controls().Add((Control)(object)ll_frmautocs);
		((Control)this).get_Controls().Add((Control)(object)ll_checkkey5);
		((Control)this).get_Controls().Add((Control)(object)ll_btnexit);
		((Control)this).get_Controls().Add((Control)(object)ll_btnlinkproe);
		((Control)this).get_Controls().Add((Control)(object)ll_btnbatch);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Proezdjl");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("PROE4.0 批量生成计算文件...");
		((Control)ll_frmautocs).ResumeLayout(false);
		((Control)ll_frmdefname).ResumeLayout(false);
		((Control)ll_frmautokey).ResumeLayout(false);
		((ISupportInitialize)ll_txttime).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void Proezdjl_Load(object sender, EventArgs e)
	{
		((Control)LabelX1).set_BackColor(Color.Transparent);
		((Control)LabelX2).set_BackColor(Color.Transparent);
		((Control)LabelX3).set_BackColor(Color.Transparent);
		((Control)LabelX4).set_BackColor(Color.Transparent);
		((Control)ll_lbemapkey1).set_BackColor(Color.Transparent);
		((Control)LabelX5).set_BackColor(Color.Transparent);
		((Control)LabelX6).set_BackColor(Color.Transparent);
		((Control)LabelX8).set_BackColor(Color.Transparent);
		if (Mod1.asyncConnection != null)
		{
			((Control)ll_btnlinkproe).set_ForeColor(Color.SeaGreen);
			((Control)ll_frmautocs).set_Enabled(true);
			((Control)ll_frmautokey).set_Enabled(true);
			((Control)ll_frmdefname).set_Enabled(true);
			ll_btnlinkproe_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
		else
		{
			((Control)ll_btnlinkproe).set_ForeColor(Color.Red);
			((Control)ll_frmautocs).set_Enabled(false);
			((Control)ll_frmautokey).set_Enabled(false);
			((Control)ll_frmdefname).set_Enabled(false);
		}
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
			((Form)this).Close();
		}
	}

	private void searchmsq()
	{
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		string text = ((TextBox)ll_txtmp1).get_Text();
		string text2 = Conversions.ToString(Strings.InStr(1, text, "`mpa`", (CompareMethod)0));
		string text3 = Conversions.ToString(Strings.InStr(1, text, "`spa`", (CompareMethod)0));
		string text4 = Conversions.ToString(Strings.InStr(1, text, "`qc`", (CompareMethod)0));
		ll_cbmsq.get_Items().Clear();
		bool flag = false;
		if (Conversions.ToDouble(text2) > 0.0)
		{
			ll_lbemapkey1.set_Text("`mpa`");
			ll_cbmsq.get_Items().Add((object)"`spa`");
			ll_cbmsq.get_Items().Add((object)"`qc`");
			flag = true;
		}
		if (Conversions.ToDouble(text3) > 0.0)
		{
			ll_lbemapkey1.set_Text("`spa`");
			ll_cbmsq.get_Items().Add((object)"`mpa`");
			ll_cbmsq.get_Items().Add((object)"`qc`");
			flag = true;
		}
		if (Conversions.ToDouble(text4) > 0.0)
		{
			ll_lbemapkey1.set_Text("`qc`");
			ll_cbmsq.get_Items().Add((object)"`mpa`");
			ll_cbmsq.get_Items().Add((object)"`spa`");
			flag = true;
		}
		if (!flag)
		{
			text = "映射键1中没有找到合法的求解方法,请检查该映射键1录制是否正确.本次操作终止";
			Interaction.MsgBox((object)text, (MsgBoxStyle)0, (object)"提示");
			ll_lbliucheng.get_Items().Add((object)text);
		}
		else
		{
			((ComboBox)ll_cbmsq).set_SelectedIndex(1);
		}
	}

	private void ll_btnshang_Click(object sender, EventArgs e)
	{
		checked
		{
			if (ll_lblccs.get_SelectedIndex() >= 2)
			{
				curvalue = ll_lblccs.get_Text();
				curi = ll_lblccs.get_SelectedIndex();
				ll_lblccs.get_Items().set_Item(curi, RuntimeHelpers.GetObjectValue(ll_lblccs.get_Items().get_Item(curi - 1)));
				ll_lblccs.get_Items().set_Item(curi - 1, (object)curvalue);
				ll_lblccs.set_SelectedIndex(curi - 1);
			}
		}
	}

	private void ll_btnxia_Click(object sender, EventArgs e)
	{
		checked
		{
			if (ll_lblccs.get_SelectedIndex() != -1 && ll_lblccs.get_SelectedIndex() < ll_lblccs.get_Items().get_Count() - 1)
			{
				curvalue = ll_lblccs.get_Text();
				curi = ll_lblccs.get_SelectedIndex();
				ll_lblccs.get_Items().set_Item(curi, RuntimeHelpers.GetObjectValue(ll_lblccs.get_Items().get_Item(curi + 1)));
				ll_lblccs.get_Items().set_Item(curi + 1, (object)curvalue);
				ll_lblccs.set_SelectedIndex(curi + 1);
			}
		}
	}

	private void ll_btnremoved_Click(object sender, EventArgs e)
	{
		if ((ll_lblccs.get_Items().get_Count() != 0) & (ll_lblccs.get_SelectedIndex() != -1))
		{
			ll_lblccs.get_Items().RemoveAt(ll_lblccs.get_SelectedIndex());
		}
	}

	private void ll_btnclear_Click(object sender, EventArgs e)
	{
		ll_lblccs.get_Items().Clear();
	}

	private void ll_btnchecklccs_Click(object sender, EventArgs e)
	{
		if (ll_lblccs.get_Items().get_Count() == 0)
		{
			return;
		}
		((Control)ll_btnchecklccs).set_ForeColor(Color.Green);
		string[] array = Strings.Split(Conversions.ToString(ll_lblccs.get_Items().get_Item(0)), ",", -1, (CompareMethod)0);
		int num = Information.UBound((Array)array, 1);
		checked
		{
			int num2 = ll_lblccs.get_Items().get_Count() - 1;
			int num3 = 1;
			while (true)
			{
				if (num3 <= num2)
				{
					array = Strings.Split(Conversions.ToString(ll_lblccs.get_Items().get_Item(num3)), ",", -1, (CompareMethod)0);
					int num4 = Information.UBound((Array)array, 1);
					if (num != num4)
					{
						break;
					}
					num3++;
					continue;
				}
				return;
			}
			ll_lblccs.set_SelectedIndex(num3);
			((Control)ll_btnchecklccs).set_ForeColor(Color.Red);
		}
	}

	private void ll_btnadd2cur_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Strings.Trim(((TextBox)ll_txtlccs).get_Text()), "", false) != 0)
		{
			ll_lblccs.get_Items().Add((object)((TextBox)ll_txtlccs).get_Text());
			((Control)ll_txtlccs).Focus();
			((TextBoxBase)ll_txtlccs).set_SelectionStart(0);
			((TextBoxBase)ll_txtlccs).set_SelectionLength(100);
		}
	}

	private void ll_btneditcur_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Strings.Trim(((TextBox)ll_txtlccs).get_Text()), "", false) != 0 && ((ll_lblccs.get_SelectedIndex() != -1) & (ll_lblccs.get_Items().get_Count() != 0)))
		{
			ll_lblccs.get_Items().set_Item(ll_lblccs.get_SelectedIndex(), (object)((TextBox)ll_txtlccs).get_Text());
			((Control)ll_txtlccs).Focus();
			((TextBoxBase)ll_txtlccs).set_SelectionStart(0);
			((TextBoxBase)ll_txtlccs).set_SelectionLength(100);
		}
	}

	private void ll_btn5filecs_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		if (ll_lblccs.get_Items().get_Count() != 0 && (int)MessageBox.Show("继续操作会覆盖当前列表中的信息,是否继续?", "重要提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 7)
		{
			return;
		}
		fname = batchpath + "\\cs.txt";
		if (!File.Exists(fname))
		{
			Interaction.MsgBox((object)("不存在文件:" + fname), (MsgBoxStyle)0, (object)"提示");
			return;
		}
		ll_lblccs.get_Items().Clear();
		Mod1.lr = new StreamReader(fname, Encoding.Default);
		string text = "";
		while (!Information.IsNothing((object)text))
		{
			text = Mod1.lr.ReadLine();
			if (Information.IsNothing((object)text))
			{
				break;
			}
			ll_lblccs.get_Items().Add((object)text);
		}
		Mod1.lr.Close();
		Mod1.lr.Dispose();
		strtemp = "提示:编辑[自动过程选项]->工况参数列表,结束后选中首行参数名称列,激活[分析名称定义],点击按钮[生成名称列表].. .";
		ll_lbliucheng.get_Items().Add((object)strtemp);
	}

	private void ll_btn5fileothercs_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Invalid comparison between Unknown and I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if ((ll_lblccs.get_Items().get_Count() != 0 && (int)MessageBox.Show("继续操作会覆盖当前列表中的信息,是否继续?", "重要提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 7) || (int)((CommonDialog)GetOpenFilename).ShowDialog() != 1)
		{
			return;
		}
		fname = ((FileDialog)GetOpenFilename).get_FileName();
		if (!File.Exists(fname))
		{
			Interaction.MsgBox((object)("不存在文件:" + fname), (MsgBoxStyle)0, (object)"提示");
			return;
		}
		ll_lblccs.get_Items().Clear();
		Mod1.lr = new StreamReader(fname, Encoding.Default);
		string text = "";
		while (!Information.IsNothing((object)text))
		{
			text = Mod1.lr.ReadLine();
			if (Information.IsNothing((object)text))
			{
				break;
			}
			ll_lblccs.get_Items().Add((object)text);
		}
		Mod1.lr.Close();
		Mod1.lr.Dispose();
		strtemp = "提示:编辑[自动过程选项]->工况参数列表,结束后选中首行参数名称列,激活[分析名称定义],点击按钮[生成名称列表].. .";
		ll_lbliucheng.get_Items().Add((object)strtemp);
	}

	private void ll_btn2filecs_Click(object sender, EventArgs e)
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Invalid comparison between Unknown and I4
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (ll_lblccs.get_Items().get_Count() > 0)
			{
				if (!Directory.Exists(batchpath))
				{
					FileSystem.MkDir(batchpath);
				}
				fname = batchpath + "\\cs.txt";
				ll_lbliucheng.get_Items().Add((object)("更新了当前工况参数文本文件:" + fname));
				ll_lbliucheng.get_Items().Add((object)"当前工况参数文本文件信息如下:");
				if (File.Exists(fname))
				{
					if (unchecked((int)MessageBox.Show("继续操作会覆盖已有文件,是否覆盖?", "重要提示", (MessageBoxButtons)4, (MessageBoxIcon)64)) == 6)
					{
						Mod1.wr = new StreamWriter(fname, append: false, Encoding.Default);
						int num = ll_lblccs.get_Items().get_Count() - 1;
						for (int i = 0; i <= num; i++)
						{
							Mod1.wr.WriteLine(RuntimeHelpers.GetObjectValue(ll_lblccs.get_Items().get_Item(i)));
							ll_lbliucheng.get_Items().Add(RuntimeHelpers.GetObjectValue(ll_lblccs.get_Items().get_Item(i)));
						}
					}
					Mod1.wr.Close();
					Mod1.wr.Dispose();
				}
				else
				{
					Mod1.wr = new StreamWriter(fname, append: false, Encoding.Default);
					int num2 = ll_lblccs.get_Items().get_Count() - 1;
					for (int j = 0; j <= num2; j++)
					{
						Mod1.wr.WriteLine(RuntimeHelpers.GetObjectValue(ll_lblccs.get_Items().get_Item(j)));
						ll_lbliucheng.get_Items().Add(RuntimeHelpers.GetObjectValue(ll_lblccs.get_Items().get_Item(j)));
					}
					Mod1.wr.Close();
					Mod1.wr.Dispose();
				}
				((Control)ll_btn5filecs).set_Enabled(true);
				((Control)ll_btn5filecs).set_ForeColor(Color.Green);
			}
			else
			{
				Interaction.MsgBox((object)"当前列表中没有可以写入参数文本文件的信息 ", (MsgBoxStyle)0, (object)"提示");
			}
		}
	}

	private void ll_btnmsq_Click(object sender, EventArgs e)
	{
		string text = ll_lbemapkey1.get_Text();
		strtemp = ((TextBox)ll_txtmp1).get_Text();
		((TextBox)ll_txtmp1).set_Text(Strings.Replace(strtemp, ll_lbemapkey1.get_Text(), Conversions.ToString(ll_cbmsq.get_Items().get_Item(((ComboBox)ll_cbmsq).get_SelectedIndex())), 1, -1, (CompareMethod)0));
		searchmsq();
		text = text + "->" + ll_lbemapkey1.get_Text();
		ll_lbliucheng.get_Items().Add((object)("当前求解方法已更新:" + text));
		ll_lbliucheng.set_SelectedIndex(checked(ll_lbliucheng.get_Items().get_Count() - 1));
	}

	private void ll_btn5filekey_Click(object sender, EventArgs e)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(Strings.Trim(((TextBox)ll_txtmp1).get_Text()), "", false) != 0 && (int)MessageBox.Show("继续操作会覆盖当前列表中的信息,是否继续?", "重要提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 7)
		{
			return;
		}
		((Form)MyProject.Forms.ll_ufmapkey1).ShowDialog();
		string text = "mapkey1_" + Mod1.proex + Mod1.scontact + ".txt";
		fname = batchpath + "\\" + text;
		string path = batchpath + "\\onlysearchhere.txt";
		if (!File.Exists(fname))
		{
			if (File.Exists(path))
			{
				Interaction.MsgBox((object)("mlc下没有找到合适的映射键文件, 请自行建立并使用来自指定文件功能." + fname), (MsgBoxStyle)0, (object)"提示");
				return;
			}
			fname = Application.get_StartupPath() + "\\config\\mapkey1\\" + text;
			if (!File.Exists(fname))
			{
				Interaction.MsgBox((object)("config下没有找到合适的映射键文件, 请自行建立并使用来自指定文件功能." + fname), (MsgBoxStyle)0, (object)"提示");
				return;
			}
		}
		strtemp = "";
		Mod1.lr = new StreamReader(fname, Encoding.Default);
		string text2 = "";
		while (!Information.IsNothing((object)text2))
		{
			text2 = Mod1.lr.ReadLine();
			if (Information.IsNothing((object)text2))
			{
				break;
			}
			strtemp += text2;
		}
		Mod1.lr.Close();
		Mod1.lr.Dispose();
		((TextBox)ll_txtmp1).set_Text(strtemp);
		searchmsq();
		strtemp = "提示:编辑[自动过程选项]->工况参数列表,结束后选中首行参数名称列,激活[分析名称定义],点击按钮[生成名称列表].. .";
		ll_lbliucheng.get_Items().Add((object)strtemp);
		checked
		{
			ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
			strtemp = "映射键文件:" + fname;
			ll_lbliucheng.get_Items().Add((object)strtemp);
			ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
		}
	}

	private void ll_btn5fileotherkey_Click(object sender, EventArgs e)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(Strings.Trim(((TextBox)ll_txtmp1).get_Text()), "", false) != 0 && (int)MessageBox.Show("继续操作会覆盖当前列表中的信息,是否继续?", "重要提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 7)
		{
			return;
		}
		strtemp = "";
		if ((int)((CommonDialog)GetOpenFilename).ShowDialog() != 1)
		{
			return;
		}
		fname = ((FileDialog)GetOpenFilename).get_FileName();
		if (!File.Exists(fname))
		{
			Interaction.MsgBox((object)("不存在文件:" + fname), (MsgBoxStyle)0, (object)"提示");
			return;
		}
		Mod1.lr = new StreamReader(fname, Encoding.Default);
		string text = "";
		while (!Information.IsNothing((object)text))
		{
			text = Mod1.lr.ReadLine();
			if (Information.IsNothing((object)text))
			{
				break;
			}
			strtemp += text;
		}
		Mod1.lr.Close();
		Mod1.lr.Dispose();
		((TextBox)ll_txtmp1).set_Text(strtemp);
		((Control)ll_txtmp1).Focus();
		searchmsq();
		strtemp = "提示:编辑[自动过程选项]->工况参数列表,结束后选中首行参数名称列,激活[分析名称定义],点击按钮[生成名称列表].. .";
		ll_lbliucheng.get_Items().Add((object)strtemp);
	}

	private void ll_btn2filekey_Click(object sender, EventArgs e)
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Invalid comparison between Unknown and I4
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(Strings.Trim(((TextBox)ll_txtmp1).get_Text()), "", false) != 0)
		{
			if (!Directory.Exists(batchpath))
			{
				FileSystem.MkDir(batchpath);
			}
			fname = batchpath + "\\mapkey1.txt";
			ll_lbliucheng.get_Items().Add((object)("更新了当前映射键1文本文件:" + fname));
			ll_lbliucheng.get_Items().Add((object)"当前映射键1文本文件信息如下:");
			if (File.Exists(fname))
			{
				if ((int)MessageBox.Show("继续操作会覆盖已有文件,是否覆盖?", "重要提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 6)
				{
					Mod1.wr = new StreamWriter(fname, append: false, Encoding.Default);
					Mod1.wr.WriteLine(((TextBox)ll_txtmp1).get_Text());
				}
				Mod1.wr.Close();
				Mod1.wr.Dispose();
			}
			else
			{
				Mod1.wr = new StreamWriter(fname, append: false, Encoding.Default);
				Mod1.wr.WriteLine(((TextBox)ll_txtmp1).get_Text());
			}
			((Control)ll_btn5filekey).set_Enabled(true);
			((Control)ll_btn5filekey).set_ForeColor(Color.Green);
		}
		else
		{
			Interaction.MsgBox((object)"当前列表中没有可以写入参数文本文件的信息 ", (MsgBoxStyle)0, (object)"提示");
		}
	}

	private void ll_btnlinkproe_Click(object sender, EventArgs e)
	{
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Mod1.asyncConnection == null)
			{
				Guid clsid = new Guid("456E0110-2031-3907-AFE5-9201C97A915E");
				Mod1.asyncConnection = ((CCpfcAsyncConnection)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid))).Connect(null, null, null, null);
			}
			if (Mod1.asyncConnection != null && !Mod1.asyncConnection.IsRunning())
			{
				((Control)this).set_Cursor(Cursors.get_AppStarting());
				Guid clsid = new Guid("456E0110-2031-3907-AFE5-9201C97A915E");
				Mod1.asyncConnection = ((CCpfcAsyncConnection)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid))).Connect(null, null, null, null);
				((Control)this).set_Cursor(Cursors.get_Arrow());
			}
			Mod1.session = Mod1.asyncConnection.Session;
			if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet((object)Mod1.session, (Type)null, "ListModels", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
			{
				Mod1.model = (IpfcModel)NewLateBinding.LateGet((object)Mod1.session, (Type)null, "CurrentModel", new object[0], (string[])null, (Type[])null, (bool[])null);
				batchfullfile = Mod1.model.Descr.Device + ":" + Mod1.model.Descr.Path + Mod1.model.Descr.GetFileName();
				batchpath = Mod1.model.Descr.Device + ":" + Mod1.model.Descr.Path;
				if (Operators.CompareString(Strings.Right(batchpath, 1), "\\", false) == 0)
				{
					batchpath = Strings.Left(batchpath, checked(Strings.Len(batchpath) - 1));
				}
				string text = Conversions.ToString(Strings.InStrRev(batchpath, "\\", -1, (CompareMethod)0));
				batchpath = Strings.Left(batchpath, Conversions.ToInteger(text)) + "mlc";
				((Control)ll_btn5filecs).set_Enabled(false);
				((Control)ll_btn5filekey).set_Enabled(false);
				if (Directory.Exists(batchpath) && File.Exists(batchpath + "\\cs.txt"))
				{
					((Control)ll_btn5filecs).set_Enabled(true);
					((Control)ll_btn5filecs).set_ForeColor(Color.Green);
					((Control)ll_btn5filekey).set_Enabled(true);
					((Control)ll_btn5filekey).set_ForeColor(Color.Green);
				}
				((Control)ll_btnlinkproe).set_ForeColor(Color.Green);
				ProeOK = true;
				strtemp = Conversions.ToString(Operators.ConcatenateObject((object)"已连接到当前打开的proe程序.当前工作目录为:", NewLateBinding.LateGet((object)Mod1.session, (Type)null, "GetCurrentDirectory", new object[0], (string[])null, (Type[])null, (bool[])null)));
				ll_lbliucheng.get_Items().Add((object)strtemp);
				strtemp = "当前计算模型文件:" + batchfullfile;
				ll_lbliucheng.get_Items().Add((object)strtemp);
				strtemp = "当前自动过程选项文件所在路径:" + batchpath;
				ll_lbliucheng.get_Items().Add((object)strtemp);
				strtemp = "";
				ll_lbliucheng.get_Items().Add((object)strtemp);
				strtemp = "提示:[自动过程选项]->[来自文件]";
				ll_lbliucheng.get_Items().Add((object)strtemp);
				if (ProeOK)
				{
					strtemp = "已成功连接到当前打开的proe软件上.. .";
					ll_lbliucheng.get_Items().Add((object)strtemp);
				}
				((Control)ll_frmautocs).set_Enabled(true);
				((Control)ll_frmautokey).set_Enabled(true);
			}
			else
			{
				((Control)ll_frmautocs).set_Enabled(false);
				((Control)ll_frmautokey).set_Enabled(false);
				((Control)ll_frmdefname).set_Enabled(false);
				Interaction.MsgBox((object)"当前内存中没有找到任何可用的计算模型.", (MsgBoxStyle)0, (object)"提示");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			if (Information.Err().get_Number() != 0)
			{
				strtemp = "Pro/e 连接失败!没有打开或打开了不合适的版本(要求4.0以上),与Pro/e相关的操作无效!";
				ll_lbliucheng.get_Items().Add((object)strtemp);
				((Control)ll_btnlinkproe).set_ForeColor(Color.Red);
				ProeOK = false;
			}
			ProjectData.ClearProjectError();
		}
	}

	private void ll_btngennamelist_Click(object sender, EventArgs e)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		ll_lbnamelist.get_Items().Clear();
		ll_lblclist.get_Items().Clear();
		string text = Strings.UCase(Strings.Trim(((TextBox)ll_txtcsnamelist).get_Text()));
		string[] array = Strings.Split(text, ",", -1, (CompareMethod)0);
		checked
		{
			int num = ll_lblccs.get_Items().get_Count() - 1;
			string[] array2 = Strings.Split(Conversions.ToString(ll_lblccs.get_Items().get_Item(0)), ",", -1, (CompareMethod)0);
			int num2 = array2.Length;
			if (num >= 10000)
			{
				Interaction.MsgBox((object)"当前工况数量接近10000，请分割处理!", (MsgBoxStyle)0, (object)null);
				return;
			}
			int num3 = num;
			int num4 = 1;
			while (true)
			{
				if (num4 <= num3)
				{
					float num5 = num4;
					if (num5 < 10f)
					{
						text = "A_000" + Conversions.ToString(num4);
					}
					else if (num5 < 100f)
					{
						text = "A_00" + Conversions.ToString(num4);
					}
					else if (num5 < 1000f)
					{
						text = "A_0" + Conversions.ToString(num4);
					}
					else
					{
						if (!(num5 < 10000f))
						{
							break;
						}
						text = "A_" + Conversions.ToString(num4);
					}
					int num6 = num2 - 1;
					for (int i = 0; i <= num6; i++)
					{
						string[] array3 = array;
						foreach (string text2 in array3)
						{
							if (Operators.CompareString(Strings.UCase(Strings.Trim(array2[i])), Strings.UCase(Strings.Trim(text2)), false) == 0)
							{
								string[] array4 = Strings.Split(Conversions.ToString(ll_lblccs.get_Items().get_Item(num4)), ",", -1, (CompareMethod)0);
								if (array4.Length > i)
								{
									text = text + "_" + array4[i];
								}
							}
						}
					}
					if (Operators.ConditionalCompareObjectNotEqual(ll_lblccs.get_Items().get_Item(num4), (object)"", false))
					{
						ll_lbnamelist.get_Items().Add((object)Strings.Trim(text));
					}
					num4++;
					continue;
				}
				strtemp = "提示:在生成的 [分析名称列表] 中选择要进行定义的名称,导入[>>]右侧的 [批量分析工况列表].. .";
				ll_lbliucheng.get_Items().Add((object)strtemp);
				return;
			}
			Interaction.MsgBox((object)"当前工况数量超过10000，请仔细检查或分割处理！！ ！", (MsgBoxStyle)0, (object)null);
		}
	}

	private void ll_btnall_Click(object sender, EventArgs e)
	{
		checked
		{
			int num = ll_lbnamelist.get_Items().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				ll_lbnamelist.SetSelected(i, true);
			}
		}
	}

	private void ll_btnother_Click(object sender, EventArgs e)
	{
		checked
		{
			int num = ll_lbnamelist.get_Items().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				if (ll_lbnamelist.GetSelected(i))
				{
					ll_lbnamelist.SetSelected(i, false);
				}
				else
				{
					ll_lbnamelist.SetSelected(i, true);
				}
			}
		}
	}

	private void ll_btn2lclist_Click(object sender, EventArgs e)
	{
		if (ll_lbnamelist.get_SelectedIndex() == -1)
		{
			return;
		}
		checked
		{
			for (int i = ll_lbnamelist.get_Items().get_Count() - 1; i >= 0; i += -1)
			{
				if (ll_lbnamelist.GetSelected(i))
				{
					ll_lblclist.get_Items().Add((object)ll_lbnamelist.get_Text());
					ll_lbnamelist.get_Items().Remove((object)ll_lbnamelist.get_Text());
				}
			}
			strtemp = "提示:点击按钮[开始批量生成计算文件].. .";
			ll_lbliucheng.get_Items().Add((object)strtemp);
			ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void ll_btnbatch_Click(object sender, EventArgs e)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Invalid comparison between Unknown and I4
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Invalid comparison between Unknown and I4
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Invalid comparison between Unknown and I4
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Invalid comparison between Unknown and I4
		//IL_0ad0: Unknown result type (might be due to invalid IL or missing references)
		strm1 = ((TextBox)ll_txtmp1).get_Text();
		checked
		{
			if (Operators.CompareString(Strings.Trim(strm1), "", false) == 0)
			{
				strtemp = "当前映射键序列不能为空.";
				Interaction.MsgBox((object)strtemp, (MsgBoxStyle)0, (object)"提示");
				ll_lbliucheng.get_Items().Add((object)strtemp);
				ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
				return;
			}
			if (!ProeOK | (ll_lblclist.get_Items().get_Count() == 0))
			{
				strtemp = "proe连接不正确,或者没有指定批量分析工况列表!";
				Interaction.MsgBox((object)strtemp, (MsgBoxStyle)0, (object)"提示");
				ll_lbliucheng.get_Items().Add((object)strtemp);
				ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet((object)Mod1.session, (Type)null, "ListModels", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
			{
				strtemp = "当前proe会话中没有合法的prt或asm文件！请指定要进行批量处理的文件.. .";
				Interaction.MsgBox((object)strtemp, (MsgBoxStyle)0, (object)"提示");
				ll_lbliucheng.get_Items().Add((object)strtemp);
				ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
				return;
			}
			strtemp = "当前proe程序是否在 [应用程序/Mechanica] 环境下?";
			ll_lbliucheng.get_Items().Add((object)strtemp);
			if (unchecked((int)MessageBox.Show(strtemp, "提示", (MessageBoxButtons)4, (MessageBoxIcon)64)) == 7)
			{
				ll_lbliucheng.get_Items().Add((object)"运行中断.");
				ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
				return;
			}
			strtemp = "[Mechanica 分析/研究] 对话框中是否已清空?";
			ll_lbliucheng.get_Items().Add((object)strtemp);
			if (unchecked((int)MessageBox.Show(strtemp, "提示", (MessageBoxButtons)4, (MessageBoxIcon)64)) == 7)
			{
				ll_lbliucheng.get_Items().Add((object)"运行中断.");
				ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
				return;
			}
			FolderBrowserDialog val = new FolderBrowserDialog();
			val.set_Description("请选择当前工作目录:");
			((CommonDialog)val).ShowDialog();
			string selectedPath = val.get_SelectedPath();
			string text = default(string);
			if (Operators.CompareString(selectedPath, "", false) != 0)
			{
				text = selectedPath;
			}
			if (Operators.CompareString(text, "", false) == 0)
			{
				Interaction.MsgBox((object)"当前工作目录为空!", (MsgBoxStyle)0, (object)"提示");
				return;
			}
			string[] array = Strings.Split(text, " ", -1, (CompareMethod)0);
			if (Information.UBound((Array)array, 1) > 0)
			{
				Interaction.MsgBox((object)("当前工作目录" + text + "有空格,请选择新目录. "), (MsgBoxStyle)0, (object)"提示");
				return;
			}
			strtemp = "指定的路径" + text + " 是 [新建的] 或者 [已经清空] 了?";
			ll_lbliucheng.get_Items().Add((object)strtemp);
			if (unchecked((int)MessageBox.Show(strtemp, "重要提示", (MessageBoxButtons)4, (MessageBoxIcon)64)) == 7)
			{
				ll_lbliucheng.get_Items().Add((object)"运行中断.");
				ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
				return;
			}
			Mod1.model = (IpfcModel)NewLateBinding.LateGet((object)Mod1.session, (Type)null, "CurrentModel", new object[0], (string[])null, (Type[])null, (bool[])null);
			IpfcSession session = Mod1.session;
			object[] array2 = new object[1] { text };
			object[] array3 = array2;
			bool[] array4 = new bool[1] { true };
			NewLateBinding.LateCall((object)session, (Type)null, "ChangeDirectory", array3, (string[])null, (Type[])null, array4, true);
			if (array4[0])
			{
				text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
			}
			strtemp = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"工作目录为:", NewLateBinding.LateGet((object)Mod1.session, (Type)null, "GetCurrentDirectory", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)" ,开始批量生成计算文件吗?"));
			ll_lbliucheng.get_Items().Add((object)strtemp);
			if (unchecked((int)MessageBox.Show(strtemp, "重要提示", (MessageBoxButtons)4, (MessageBoxIcon)64)) == 7)
			{
				ll_lbliucheng.get_Items().Add((object)"运行中断.");
				ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
				return;
			}
			string text2 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet((object)Mod1.session, (Type)null, "CurrentModel", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FileName", new object[0], (string[])null, (Type[])null, (bool[])null));
			array = Strings.Split(text2, ".", -1, (CompareMethod)0);
			int num = 0;
			string[] array5 = array;
			for (int i = 0; i < array5.Length; i++)
			{
				num++;
			}
			string text3 = default(string);
			if (Operators.CompareString(Strings.UCase(array[num - 1]), "ASM", false) == 0)
			{
				text3 = "~ Command `ProCmdMmParams` ;\\~ Activate `relation_dlg` `ParamsPHLay.TBAddParam`;\\~ Activate `relation_dlg` `ParamsPHLay.TBDelParam`;\\~ Activate `relation_dlg` `PB_OK`;~ Command `ProCmdRegenAuto`;";
			}
			if (Operators.CompareString(Strings.UCase(array[num - 1]), "PRT", false) == 0)
			{
				text3 = "~ Command `ProCmdMmParams` ;\\~ Activate `relation_dlg` `ParamsPHLay.TBAddParam`;\\~ Activate `relation_dlg` `ParamsPHLay.TBDelParam`;\\~ Activate `relation_dlg` `PB_OK`;~ Command `ProCmdRegenPart`;";
			}
			string text4 = text + "\\mecbatch.bat";
			FileSystem.FileCopy(Application.get_StartupPath() + "\\config\\mecbatch.bat", text4);
			Mod1.paraowner = (IpfcParameterOwner)Mod1.model;
			Mod1.solid = (IpfcSolid)Mod1.model;
			Mod1.rege = Mod1.crege.Create(true, null, null);
			_ = ll_lblccs.get_Items().get_Count() - 1;
			array = Strings.Split(Conversions.ToString(ll_lblccs.get_Items().get_Item(0)), ",", -1, (CompareMethod)0);
			int num2 = Information.UBound((Array)array, 1);
			int num3 = ll_lblclist.get_Items().get_Count() - 1;
			for (num = 0; num <= num3; num++)
			{
				string text5 = Conversions.ToString(ll_lblclist.get_Items().get_Item(num));
				string[] array6 = Strings.Split(text5, "_", -1, (CompareMethod)0);
				int num4 = Conversions.ToInteger(array6[1]);
				string[] array7 = Strings.Split(Conversions.ToString(ll_lblccs.get_Items().get_Item(0)), ",", -1, (CompareMethod)0);
				string[] array8 = Strings.Split(Conversions.ToString(ll_lblccs.get_Items().get_Item(num4)), ",", -1, (CompareMethod)0);
				int num5 = num2;
				for (int j = 0; j <= num5; j++)
				{
					string text6 = Strings.UCase(Strings.Trim(array7[j]));
					string text7 = Strings.Trim(array8[j]);
					Mod1.para = Mod1.paraowner.GetParam(text6);
					if (Mod1.para != null)
					{
						Mod1.punit = Mod1.para.Units;
						Mod1.paravalue = Mod1.para.GetScaledValue();
						if (Mod1.paravalue.discr == 2)
						{
							switch (Strings.UCase(text7))
							{
							default:
								Mod1.paravalue.BoolValue = true;
								strtemp = "布尔类型值不恰当，应为 NO/YES/FALSE/TRUE/否/是/假/真/无/有；默认此处值为 是";
								ll_lbliucheng.get_Items().Add((object)strtemp);
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
							Mod1.paravalue.DoubleValue = Conversions.ToDouble(text7);
						}
						if (Mod1.paravalue.discr == 0)
						{
							Mod1.paravalue.StringValue = text7;
						}
						if (Mod1.paravalue.discr == 1)
						{
							Mod1.paravalue.IntValue = Conversions.ToInteger(text7);
						}
						Mod1.para.SetScaledValue(Mod1.paravalue, Mod1.punit);
						continue;
					}
					Interaction.MsgBox((object)("proe中不存在指定的参数: " + text6), (MsgBoxStyle)0, (object)null);
					return;
				}
				string text8 = text3;
				IpfcSession session2 = Mod1.session;
				object[] array9 = new object[1] { text8 };
				object[] array10 = array9;
				array4 = new bool[1] { true };
				NewLateBinding.LateCall((object)session2, (Type)null, "RunMacro", array10, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					text8 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
				}
				if (ll_checkgeogen.get_Checked())
				{
					Mod1.rege.ForceRegen = true;
					Mod1.solid.Regenerate(Mod1.rege);
				}
				text8 = " ~ Command `ProCmdSimMechSol` ;\\~ Select `run` `MenuBar1`1  `FileSTRC`;~ Close `run` `MenuBar1`;\\~ Activate `run` `FileNewStatic`;\\~ Update `anl_static_dlg` `headPH.nameInpt` `" + text5 + "`;\\";
				if (ll_checkkey5.get_Checked())
				{
					string text9 = "~ Activate `anl_static_dlg` `nonLinear`1 ;\\~ Activate `anl_static_dlg` `contactCBtn`1 ;\\";
					text8 += text9;
				}
				text8 += strm1;
				Thread.Sleep(2000);
				IpfcSession session3 = Mod1.session;
				array9 = new object[1] { text8 };
				object[] array11 = array9;
				array4 = new bool[1] { true };
				NewLateBinding.LateCall((object)session3, (Type)null, "RunMacro", array11, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					text8 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
				}
				if (Operators.CompareString(Strings.Trim(Conversions.ToString(ll_txttime.get_Value())), "", false) == 0)
				{
					ll_txttime.set_Value(Conversions.ToInteger("10"));
				}
				Thread.Sleep(Convert.ToInt32(ll_txttime.get_Value()) * 1000);
				strtemp = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(string.Concat(Conversions.ToString(num + 1) + "/", Conversions.ToString(ll_lblclist.get_Items().get_Count())), " 已经完成当前："), ll_lblclist.get_Items().get_Item(num)));
				((Form)this).set_Text(strtemp);
				ll_lbliucheng.get_Items().Add((object)strtemp);
				ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
			}
			Thread.Sleep(Convert.ToInt32(ll_txttime.get_Value()) * 1000);
			((Form)this).set_Text("PROE4.0 批量生成计算文件.. .");
			ll_lbliucheng.get_Items().Add((object)"PROE4.0 批量生成计算文件成功完成。");
			ll_lbliucheng.set_SelectedIndex(ll_lbliucheng.get_Items().get_Count() - 1);
		}
	}

	private void ll_lblccs_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (ll_lblccs.get_SelectedIndex() != -1)
		{
			if (ll_lblccs.get_SelectedIndex() == 0)
			{
				((Control)ll_btnxia).set_Enabled(false);
				((Control)ll_btnshang).set_Enabled(false);
				((Control)ll_btnremoved).set_Enabled(false);
			}
			else
			{
				((Control)ll_btnxia).set_Enabled(true);
				((Control)ll_btnshang).set_Enabled(true);
				((Control)ll_btnremoved).set_Enabled(true);
			}
			((TextBox)ll_txtlccs).set_Text(Conversions.ToString(ll_lblccs.get_Items().get_Item(ll_lblccs.get_SelectedIndex())));
			((Control)ll_txtlccs).Focus();
			((TextBoxBase)ll_txtlccs).set_SelectionStart(0);
			((TextBoxBase)ll_txtlccs).set_SelectionLength(100);
			if (ll_lblccs.get_SelectedIndex() == 0)
			{
				((TextBox)ll_txtcsnamelist).set_Text(Conversions.ToString(ll_lblccs.get_Items().get_Item(0)));
				((Control)ll_frmdefname).set_Enabled(true);
				((TextBoxBase)ll_txtcsnamelist).set_ForeColor(Color.Green);
			}
			else
			{
				((TextBox)ll_txtcsnamelist).set_Text("请选择左侧 [工况参数列表] 第1行激活当前.. .");
				((TextBoxBase)ll_txtcsnamelist).set_ForeColor(Color.Red);
				((Control)ll_frmdefname).set_Enabled(false);
			}
		}
	}

	private void btndel_Click(object sender, EventArgs e)
	{
		if (!((ll_lblclist.get_Items().get_Count() != 0) & (ll_lblclist.get_SelectedIndex() != -1)))
		{
			return;
		}
		checked
		{
			for (int i = ll_lblclist.get_Items().get_Count() - 1; i >= 0; i += -1)
			{
				if (ll_lblclist.GetSelected(i))
				{
					ll_lbnamelist.get_Items().Add(RuntimeHelpers.GetObjectValue(ll_lblclist.get_Items().get_Item(i)));
					ll_lblclist.get_Items().Remove(RuntimeHelpers.GetObjectValue(ll_lblclist.get_Items().get_Item(i)));
				}
			}
		}
	}

	private void luzhishuoming_Click(object sender, EventArgs e)
	{
		if (File.Exists(Application.get_StartupPath() + "\\config\\mapkey录制说明.txt"))
		{
			Interaction.Shell("NOTEPAD.EXE " + Application.get_StartupPath() + "\\config\\mapkey录制说明.txt", (AppWinStyle)3, false, -1);
		}
	}
}
